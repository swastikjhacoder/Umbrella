#Region "Class cSubject..."
Public Class cSubject
#Region "Declarations..."
    Public AddSubjectOk As Boolean = False
    Public UpdateSubjectOk As Boolean = False
    Public DeleteSubjectOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal subjectidd As String, ByVal subjectname As String, ByVal subjectdetails As String)
        Try
            cmd.CommandText = "insert into SubjectBooks(InsID,InsName,Period,SystemDate,subjectid,subjectname,subjectdetails) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & subjectidd & "','" & subjectname & "','" & subjectdetails & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set subjectid=subjectid+1 where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddSubjectOk = True
        Catch ex As Exception
            dr.Close()
            AddSubjectOk = False
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal subjectidd As String, ByVal subjectname As String, ByVal subjectdetails As String)
        Try
            cmd.CommandText = "update SubjectBooks set SystemDate='" & SystemDate & "',subjectname='" & subjectname & "',subjectdetails='" & subjectdetails & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and subjectid='" & subjectidd & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateSubjectOk = True
        Catch ex As Exception
            dr.Close()
            UpdateSubjectOk = False
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal subjectidd As String)
        Try
            cmd.CommandText = "delete from SubjectBooks where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and subjectid='" & subjectidd & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteSubjectOk = True
        Catch ex As Exception
            dr.Close()
            DeleteSubjectOk = False
        End Try
    End Sub
#End Region
End Class
#End Region