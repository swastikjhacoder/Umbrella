#Region "Class cMarksheet..."
Public Class cMarksheet
#Region "Declarations..."
    Public AddOk As Boolean = False
    Public DeleteOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal markid As String, ByVal stuid As String, ByVal name As String, ByVal course As String, ByVal clss As String, ByVal roll As String, ByVal examinfo As String, ByVal examdate As String, ByVal examtime As String, ByVal subject As String, ByVal fullmarks As Decimal, ByVal scored As Decimal)
        Try
            cmd.CommandText = "insert into Marksheet(InsID,InsName,Period,SystemDate,markid,stuid,name,course,class,roll,examinfo,examdate,examtime,subject,fullmarks,scored) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & markid & "','" & stuid & "','" & name & "','" & course & "','" & clss & "','" & roll & "','" & examinfo & "','" & examdate & "','" & examtime & "','" & subject & "'," & fullmarks & "," & scored & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            AddOk = True
        Catch ex As Exception
            AddOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal markid As String)
        Try
            cmd.CommandText = "delete from Marksheet where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & periodd & "' and markid='" & markid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteOk = True
        Catch ex As Exception
            DeleteOk = False
            dr.Close()
        End Try
    End Sub
#End Region
End Class
#End Region