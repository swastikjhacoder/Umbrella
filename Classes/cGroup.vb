#Region "Class cGroup..."
Public Class cGroup
#Region "Declarations..."
    Public AddGroupOk As Boolean = False
    Public UpdateGroupOk As Boolean = False
    Public DeleteGroupOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal groupid As String, ByVal groupname As String, ByVal groupdetails As String)
        Try
            cmd.CommandText = "insert into GroupBooks(InsID,InsName,Period,SystemDate,groupid,groupname,groupdetails) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & groupid & "','" & groupname & "','" & groupdetails & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set groupid=groupid+1 where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddGroupOk = True
        Catch ex As Exception
            dr.Close()
            AddGroupOk = False
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal groupid As String, ByVal groupname As String, ByVal groupdetails As String)
        Try
            cmd.CommandText = "update GroupBooks set SystemDate='" & SystemDate & "',groupname='" & groupname & "',groupdetails='" & groupdetails & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and groupid='" & groupid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateGroupOk = True
        Catch ex As Exception
            dr.Close()
            UpdateGroupOk = False
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal groupid As String)
        Try
            cmd.CommandText = "delete from GroupBooks where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and groupid='" & groupid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteGroupOk = True
        Catch ex As Exception
            dr.Close()
            DeleteGroupOk = False
        End Try
    End Sub
#End Region
End Class
#End Region