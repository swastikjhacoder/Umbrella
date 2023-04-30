#Region "Class cDaHra..."
Public Class cDaHra
#Region "Declarations..."
    Public UpdateRecordOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub UpdateDaHra(ByVal ID As Integer, ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal effectmonth As Integer, ByVal effectyear As Integer, ByVal darate As Decimal, ByVal hrarate As Decimal, ByVal maximum As Decimal, ByVal medical As Decimal)
        Try
            cmd.CommandText = "update DaHra set effectmonth=" & effectmonth & ",effectyear=" & effectyear & ",darate=" & darate & ",hrarate=" & hrarate & ",maximum=" & maximum & ",medical=" & medical & " where ID=" & ID & " and InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateRecordOk = True
        Catch ex As Exception
            dr.Close()
            UpdateRecordOk = False
        End Try
    End Sub
#End Region
End Class
#End Region