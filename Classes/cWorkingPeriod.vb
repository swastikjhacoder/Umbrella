#Region "Class cWorkingPeriod..."
Public Class cWorkingPeriod
#Region "Declaratopns..."
    Public AddHourlyOk As Boolean = False
    Public HourExist As Boolean = False
    Public AddDailyOk As Boolean = False
    Public DailyExist As Boolean = False
#End Region
#Region "Methods..."
    Private Sub CheckHourlyRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal empid As String, ByVal name As String, ByVal dates As String)
        Try
            cmd.CommandText = "select * from workinghourly where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and empid='" & empid & "' and name='" & name & "' and date='" & dates & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                HourExist = True
            Else
                HourExist = False
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CheckDailyRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal empid As String, ByVal name As String, ByVal dates As String)
        Try
            cmd.CommandText = "select * from workingdaily where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and empid='" & empid & "' and name='" & name & "' and date='" & dates & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                DailyExist = True
            Else
                DailyExist = False
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub AddHourlyRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal empid As String, ByVal name As String, ByVal dates As String, ByVal starttime As String, ByVal endtime As String, ByVal totalminutes As Integer)
        Try
            CheckHourlyRecord(InsID, InsName, Periodd, empid, name, dates)
            If HourExist = False Then
                cmd.CommandText = "insert into workinghourly(InsID,InsName,Period,empid,name,date,starttime,endtime,totalminutes) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & empid & "','" & name & "','" & dates & "','" & starttime & "','" & endtime & "'," & totalminutes & ")"
                dr = cmd.ExecuteReader
                dr.Close()
                AddHourlyOk = True
            Else
                cmd.CommandText = "update workinghourly set starttime='" & starttime & "',endtime='" & endtime & "',totalminutes=" & totalminutes & " where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and empid='" & empid & "' and name='" & name & "' and date='" & dates & "'"
                dr = cmd.ExecuteReader
                dr.Close()
                AddHourlyOk = True
            End If
        Catch ex As Exception
            dr.Close()
            AddHourlyOk = False
        End Try
    End Sub

    Public Sub AddDailyRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal empid As String, ByVal name As String, ByVal dates As String, ByVal presentabsent As String)
        Try
            CheckDailyRecord(InsID, InsName, Periodd, empid, name, dates)
            If DailyExist = False Then
                cmd.CommandText = "insert into workingdaily(InsID,InsName,Period,empid,name,date,presentabsent) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & empid & "','" & name & "','" & dates & "','" & presentabsent & "')"
                dr = cmd.ExecuteReader
                dr.Close()
                AddDailyOk = True
            Else
                cmd.CommandText = "update workingdaily set presentabsent='" & presentabsent & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and empid='" & empid & "' and name='" & name & "' and date='" & dates & "'"
                dr = cmd.ExecuteReader
                dr.Close()
                AddDailyOk = True
            End If
        Catch ex As Exception
            dr.Close()
            AddDailyOk = False
        End Try
    End Sub
#End Region
End Class
#End Region
