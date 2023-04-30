#Region "Class cDepartment..."
Public Class cDepartment
#Region "Declarations..."
    Public AddOk As Boolean = False
    Public UpdateOk As Boolean = False
    Public DeleteOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal deptid As String, ByVal deptname As String)
        Try
            cmd.CommandText = "insert into Department(InsID,InsName,Period,deptid,deptname) values ('" & InsID & "','" & InsName & "','" & Period & "','" & deptid & "','" & deptname & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set deptid=deptid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddOk = True
        Catch ex As Exception
            AddOk = False
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal deptid As String, ByVal deptname As String)
        Try
            cmd.CommandText = "update Department set deptname='" & deptname & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Period & "' and deptid='" & deptid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateOk = True
        Catch ex As Exception
            UpdateOk = False
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal deptid As String)
        Try
            cmd.CommandText = "delete from Department where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Period & "' and deptid='" & deptid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteOk = True
        Catch ex As Exception
            DeleteOk = False
        End Try
    End Sub
#End Region
End Class
#End Region
