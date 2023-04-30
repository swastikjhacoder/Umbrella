' *********************************************************************
' **  A high-precision NMEA interpreter
' **  Written by Jon Person, author of "GPS.NET" (www.gpsdotnet.com)
' *********************************************************************

Imports System
Imports System.Globalization

Public Class NmeaInterpreter

	' Represents the EN-US culture, used for numers in NMEA sentences
	Public Shared NmeaCultureInfo As New CultureInfo("en-US")
	' Used to convert knots into miles per hour
	Public Shared MPHPerKnot As Double = Double.Parse("1.150779", NmeaCultureInfo)

	' Raised when the current location has changed
	Public Event PositionReceived(ByVal latitude As String, ByVal longitude As String)
	Public Event DateTimeChanged(ByVal dateTime As DateTime)
	Public Event BearingReceived(ByVal bearing As Double)
	Public Event SpeedReceived(ByVal speed As Double)
	Public Event SpeedLimitReached()
	Public Event FixObtained()
	Public Event FixLost()
	Public Event SatelliteReceived(ByVal pseudoRandomCode As Integer, _
	 ByVal azimuth As Integer, _
	 ByVal elevation As Integer, _
	 ByVal signalToNoiseRatio As Integer)
	Public Event HDOPReceived(ByVal value As Double)
	Public Event VDOPReceived(ByVal value As Double)
	Public Event PDOPReceived(ByVal value As Double)

	' Processes information from the GPS receiver
	Public Function Parse(ByVal sentence As String) As Boolean
		' Discard the sentence if its checksum does not match our calculated checksum
		If Not IsValid(sentence) Then Return False
		' Look at the first word to decide where to go next
		Select Case GetWords(sentence)(0)
			Case "$GPRMC"
				' A "Recommended Minimum" sentence was found!
				Return ParseGPRMC(sentence)
			Case "$GPGSV"
				' A "Satellites in View" sentence was recieved
				Return ParseGPGSV(sentence)
			Case "$GPGSA"
				Return ParseGPGSA(sentence)
			Case Else
				' Indicate that the sentence was not recognized
				Return False
		End Select
	End Function

	' Divides a sentence into individual words
	Public Function GetWords(ByVal sentence As String) As String()
		Return sentence.Split(","c)
	End Function

	' Interprets a $GPRMC message
	Public Function ParseGPRMC(ByVal sentence As String) As Boolean
		' Divide the sentence into words
		Dim Words() As String = GetWords(sentence)
		' Do we have enough values to describe our location?
		If Words(3) <> "" And Words(4) <> "" And Words(5) <> "" And Words(6) <> "" Then
			' Yes. Extract latitude and longitude
			Dim Latitude As String = Words(3).Substring(0, 2) & "°"				' Append hours
			Latitude = Latitude & Words(3).Substring(2) & """"			 ' Append minutes
			Latitude = Latitude & Words(4)				' Append the hemisphere
			Dim Longitude As String = Words(5).Substring(0, 3) & "°"				' Append hours
			Longitude = Longitude & Words(5).Substring(3) & """"			 ' Append minutes
			Longitude = Longitude & Words(6)				' Append the hemisphere
			' Notify the calling application of the change
			RaiseEvent PositionReceived(Latitude, Longitude)
		End If
		' Do we have enough values to parse satellite-derived time?
		If Words(1) <> "" Then
			' Yes. Extract hours, minutes, seconds and milliseconds
			Dim UtcHours As Integer = CType(Words(1).Substring(0, 2), Integer)
			Dim UtcMinutes As Integer = CType(Words(1).Substring(2, 2), Integer)
			Dim UtcSeconds As Integer = CType(Words(1).Substring(4, 2), Integer)
			Dim UtcMilliseconds As Integer
			' Extract milliseconds if it is available
			If Words(1).Length > 7 Then UtcMilliseconds = CType(Words(1).Substring(7), Integer)
			' Now build a DateTime object with all values
			Dim Today As DateTime = System.DateTime.Now.ToUniversalTime
			Dim SatelliteTime As New System.DateTime(Today.Year, Today.Month, Today.Day, UtcHours, UtcMinutes, UtcSeconds, UtcMilliseconds)
			' Notify of the new time, adjusted to the local time zone
			RaiseEvent DateTimeChanged(SatelliteTime.ToLocalTime)
		End If
		' Do we have enough information to extract the current speed?
		If Words(7) <> "" Then
			' Yes.  Parse the speed and convert it to MPH
			Dim Speed As Double = Double.Parse(Words(7), NmeaCultureInfo) * MPHPerKnot
			' Notify of the new speed
			RaiseEvent SpeedReceived(Speed)
			' Are we over the highway speed limit?
			If Speed > 55 Then RaiseEvent SpeedLimitReached()
		End If
		' Do we have enough information to extract bearing?
		If Words(8) <> "" Then
			' Indicate that the sentence was recognized
			Dim Bearing As Double = Double.Parse(Words(8), NmeaCultureInfo)
			RaiseEvent BearingReceived(Bearing)
		End If
		' Does the device currently have a satellite fix?
		If Words(2) <> "" Then
			Select Case Words(2)
				Case "A"
					RaiseEvent FixObtained()
				Case "V"
					RaiseEvent FixLost()
			End Select
		End If
		' Indicate that the sentence was recognized
		Return True
	End Function

	' Interprets a "Satellites in View" NMEA sentence
	Public Function ParseGPGSV(ByVal sentence As String) As Boolean
		Dim PseudoRandomCode As Integer
		Dim Azimuth As Integer
		Dim Elevation As Integer
		Dim SignalToNoiseRatio As Integer
		' Divide the sentence into words
		Dim Words() As String = GetWords(sentence)
		' Each sentence contains four blocks of satellite information.  Read each block
		' and report each satellite's information
		Dim Count As Integer
		For Count = 1 To 4
			' Does the sentence have enough words to analyze?
			If (Words.Length - 1) >= (Count * 4 + 3) Then
				' Yes.  Proceed with analyzing the block.  Does it contain any information?
				If Words(Count * 4) <> "" And Words(Count * 4 + 1) <> "" And Words(Count * 4 + 2) <> "" And Words(Count * 4 + 3) <> "" Then
					' Yes. Extract satellite information and report it
					PseudoRandomCode = CType(Words(Count * 4), Integer)
					Elevation = CType(Words(Count * 4 + 1), Integer)
					Azimuth = CType(Words(Count * 4 + 2), Integer)
					SignalToNoiseRatio = CType(Words(Count * 4 + 2), Integer)
					' Notify of this satellite's information
					RaiseEvent SatelliteReceived(PseudoRandomCode, Azimuth, Elevation, SignalToNoiseRatio)
				End If
			End If
		Next
		' Indicate that the sentence was recognized
		Return True
	End Function

	' Interprets a "Fixed Satellites and DOP" NMEA sentence
	Public Function ParseGPGSA(ByVal sentence As String) As Boolean
		' Divide the sentence into words
		Dim Words() As String = GetWords(sentence)
		' Update the DOP values
		If Words(15) <> "" Then
			RaiseEvent PDOPReceived(Double.Parse(Words(15), NmeaCultureInfo))
		End If
		If Words(16) <> "" Then
			RaiseEvent HDOPReceived(Double.Parse(Words(16), NmeaCultureInfo))
		End If
		If Words(17) <> "" Then
			RaiseEvent VDOPReceived(Double.Parse(Words(17), NmeaCultureInfo))
		End If
		Return True
	End Function

	' Returns True if a sentence's checksum matches the calculated checksum
	Public Function IsValid(ByVal sentence As String) As Boolean
		' Compare the characters after the asterisk to the calculation
		Return sentence.Substring(sentence.IndexOf("*") + 1) = GetChecksum(sentence)
	End Function

	' Calculates the checksum for a sentence
	Public Function GetChecksum(ByVal sentence As String) As String
		' Loop through all chars to get a checksum
		Dim Character As Char
		Dim Checksum As Integer
		For Each Character In sentence
			Select Case Character
				Case "$"c
					' Ignore the dollar sign
				Case "*"c
					' Stop processing before the asterisk
					Exit For
				Case Else
					' Is this the first value for the checksum?
					If Checksum = 0 Then
						' Yes. Set the checksum to the value
						Checksum = Convert.ToByte(Character)
					Else
						' No. XOR the checksum with this character's value
						Checksum = Checksum Xor Convert.ToByte(Character)
					End If
			End Select
		Next
		' Return the checksum formatted as a two-character hexadecimal
		Return Checksum.ToString("X2")
	End Function
End Class
