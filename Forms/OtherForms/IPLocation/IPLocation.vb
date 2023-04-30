Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization

Namespace UIControls.IpLocation
    Public Class Response
        Public Ip As String, CountryCode As String, CountryName As String, RegionCode As String, RegionName As String, City As String, _
         ZipCode As String, Latitude As String, Longitude As String

        Public Sub New()
        End Sub
        Public Shared Function GetIpLocation(ByVal IpAddress As String) As Response
            Dim serializer As New XmlSerializer(GetType(Response))
            Dim reader As XmlReader = XmlReader.Create(New StringReader(GetIpData(IpAddress)))
            Return DirectCast(serializer.Deserialize(reader), Response)
        End Function
        Private Shared Function GetIpData(ByVal IpAddress As String) As String
            Dim web = New WebClient()
            Return web.DownloadString(Convert.ToString("http://freegeoip.net/xml/") & IpAddress)
        End Function
    End Class
End Namespace