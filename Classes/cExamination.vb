#Region "Class cExamination..."
Public Class cExamination
#Region "Declarations..."
    Public AddExamOk As Boolean = False
    Public AddExamStuOk As Boolean = False
    Public AddExamGuardOk As Boolean = False
    Public UpdateExamOk As Boolean = False
    Public UpdateExamStuOk As Boolean = False
    Public UpdateExamGuardOk As Boolean = False
    Public DeleteExamOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddExamination(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal examcode As String, ByVal course As String, ByVal subject As String, ByVal examdate As String, ByVal branch As String, ByVal examcenter As String, ByVal examfor As String, ByVal examinstitute As String, ByVal examtime As String, ByVal roomno As String)
        Try
            cmd.CommandText = "insert into Examination(InsID,InsName,Period,SystemDate,examcode,course,subject,examdate,branch,examcenter,examfor,examinstitute,examtime,roomno) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & SystemDate & "','" & examcode & "','" & course & "','" & subject & "','" & examdate & "','" & branch & "','" & examcenter & "','" & examfor & "','" & examinstitute & "','" & examtime & "','" & roomno & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set examid=examid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddExamOk = True
        Catch ex As Exception
            AddExamOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub AddExaminationStudent(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal examcode As String, ByVal stuid As String, ByVal name As String, ByVal course As String)
        Try
            cmd.CommandText = "insert into ExamStudents(InsID,InsName,Period,SystemDate,examcode,stuid,name,course) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & SystemDate & "','" & examcode & "','" & stuid & "','" & name & "','" & course & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            AddExamStuOk = True
        Catch ex As Exception
            AddExamStuOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub AddExaminationGuard(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal examcode As String, ByVal guard As String)
        Try
            cmd.CommandText = "insert into ExamGuard(InsID,InsName,Period,SystemDate,examcode,guard) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & SystemDate & "','" & examcode & "','" & guard & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            AddExamGuardOk = True
        Catch ex As Exception
            AddExamGuardOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateExamination(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal examcode As String, ByVal course As String, ByVal subject As String, ByVal examdate As String, ByVal branch As String, ByVal examcenter As String, ByVal examfor As String, ByVal examinstitute As String, ByVal examtime As String, ByVal roomno As String)
        Try
            cmd.CommandText = "update Examination set SystemDate='" & SystemDate & "',course='" & course & "',subject='" & subject & "',examdate='" & examdate & "',branch='" & branch & "',examcenter='" & examcenter & "',examfor='" & examfor & "',examinstitute='" & examinstitute & "',examtime='" & examtime & "',roomno='" & roomno & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & periodd & "' and examcode='" & examcode & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateExamOk = True
        Catch ex As Exception
            UpdateExamOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteExamination(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal examcode As String)
        Try
            cmd.CommandText = "delete from Examination where examcode='" & examcode & "' and InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & periodd & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "delete from ExamStudents where examcode='" & examcode & "' and InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & periodd & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "delete from ExamGuard where examcode='" & examcode & "' and InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & periodd & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteExamOk = True
        Catch ex As Exception
            DeleteExamOk = False
            dr.Close()
        End Try
    End Sub
#End Region
End Class
#End Region