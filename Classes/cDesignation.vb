#Region "Class cDesignation..."
Public Class cDesignation
#Region "Declarations..."
    Public AddOk As Boolean = False
    Public UpdateOk As Boolean = False
    Public DeleteOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal desigid As String, ByVal designame As String)
        Try
            cmd.CommandText = "insert into Designation(InsID,InsName,Period,desigid,designame) values ('" & InsID & "','" & InsName & "','" & Period & "','" & desigid & "','" & designame & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set desigid=desigid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddOk = True
        Catch ex As Exception
            AddOk = False
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal desigid As String, ByVal designame As String)
        Try
            cmd.CommandText = "update Designation set designame='" & designame & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Period & "' and desigid='" & desigid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateOk = True
        Catch ex As Exception
            UpdateOk = False
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal desigid As String)
        Try
            cmd.CommandText = "delete from Designation where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Period & "' and desigid='" & desigid & "'"
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