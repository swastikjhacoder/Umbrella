#Region "Class frmOnlineExamination..."
Public Class frmOnlineExamination
#Region "Declarations..."
    Private duration As String = ""
    Private ExamDuration As Integer = 0
    Private Question(1000) As String
    Private Answer1(1000) As String
    Private Answer2(1000) As String
    Private Answer3(1000) As String
    Private Answer4(1000) As String
    Private RightAnswer(1000) As String
    Private AttenAnswer(1000) As String
    Private AttenQuestion(1000) As String
    Private TotalQuestions As Integer = 0
    Private TotalAnswer As Integer = 0
    Private RightAns As Integer = 0
    Private Count As Integer = 0
    Private StudentName As String = ""
    Private StudentRoll As String = ""
    Private StudentClass As String = ""
    Private StudentCourse As String = ""
    Private RegistrationNo As String = ""
#End Region
#Region "Functions..."
    Public Function FormatTime(ByVal Time As Integer) As String
        Dim iMinutes As Integer
        Dim iSeconds As Integer
        If duration = 0 Then
            tmrCountdown.Stop()
            Dim str As String = "00:00"
            Return str
            Exit Function
        End If
        iMinutes = Math.Floor(duration / 60)
        iSeconds = duration Mod 60
        Return Format(iMinutes, "00") & ":" & Format(iSeconds, "00")
    End Function
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(21, 16, 78, 13)
        Label2.SetBounds(21, 43, 75, 13)
        Label3.SetBounds(21, 70, 76, 13)
        Label4.SetBounds(21, 97, 61, 13)
        lblexamcode.SetBounds(105, 16, 0, 13)
        lblexamdate.SetBounds(105, 43, 0, 13)
        lblexamtime.SetBounds(105, 70, 0, 13)
        lblduration.SetBounds(105, 97, 0, 13)
        lblqsn.SetBounds(21, 16, 1042, 54)

        btnstart.SetBounds(922, 70, 90, 40)
        btnprev.SetBounds(886, 5, 75, 32)
        btnnext.SetBounds(967, 5, 75, 32)

        rbtnans1.SetBounds(92, 87, 14, 13)
        rbtnans2.SetBounds(92, 116, 14, 13)
        rbtnans3.SetBounds(92, 145, 14, 13)
        rbtnans4.SetBounds(92, 174, 14, 13)
    End Sub

    Private Sub LoadExam(ByVal xmcode As String)
        Try
            cmd.CommandText = "select examid,examdate,examtime,examduration from OnlineExamQsn where examid='" & xmcode & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                lblduration.Text = dr("examduration").ToString() + " Minutes"
                ExamDuration = CInt(dr("examduration").ToString())
                duration = dr("examduration").ToString()
                lblexamcode.Text = dr("examid").ToString()
                lblexamdate.Text = dr("examdate").ToString()
                lblexamtime.Text = dr("examtime").ToString()
            End If
            dr.Close()
            duration = duration * 60
            lbltime.Text = FormatTime(duration)
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadQuestions(ByVal xmid As String)
        Try
            cmd.CommandText = "select qsn,ans1,ans2,ans3,ans4,rightans from OnlineExamQsn where examid='" & xmid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                Question(TotalQuestions) = dr("qsn").ToString()
                Answer1(TotalQuestions) = dr("ans1").ToString()
                Answer2(TotalQuestions) = dr("ans2").ToString()
                Answer3(TotalQuestions) = dr("ans3").ToString()
                Answer4(TotalQuestions) = dr("ans4").ToString()
                RightAnswer(TotalQuestions) = dr("rightans").ToString()
                TotalQuestions = TotalQuestions + 1
            End While
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadStudentInfo()
        Try
            cmd.CommandText = "select stuid,name,roll,class,course from StudentRegistration where stuid='" & StuID & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            RegistrationNo = dr("stuid").ToString()
            StudentName = dr("name").ToString()
            StudentRoll = dr("roll").ToString()
            StudentClass = dr("class").ToString()
            StudentCourse = dr("course").ToString()
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub AddRecord()
        Try
            Dim result As DialogResult = MessageBox.Show("Do you want to submit your answer sheet?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                LoadStudentInfo()
                Dim cls As New cOnlineExam()
                For i As Integer = 0 To TotalQuestions
                    If AttenAnswer(i) <> "" Then
                        TotalAnswer += 1
                    End If
                    If AttenAnswer(i) = RightAnswer(i) Then
                        RightAns += 1
                    End If
                Next
                cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, lblexamcode.Text, lblexamdate.Text, lblexamtime.Text, ExamDuration, RegistrationNo, StudentName, StudentCourse, StudentClass, StudentRoll, TotalQuestions, TotalAnswer, RightAns)
                If cls.AddRecordOk = True Then
                    Dim result1 As DialogResult = MessageBox.Show("Your answer sheet submitted successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If result1 = Windows.Forms.DialogResult.OK Then
                        rbtnans1.Visible = False
                        rbtnans2.Visible = False
                        rbtnans3.Visible = False
                        rbtnans4.Visible = False
                        btnnext.Visible = False
                        btnprev.Visible = False
                        lblqsn.Text = "Answer sheet submitted successfully..."
                        tmrCountdown.Stop()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedRecord()
        Try
            cmd.CommandText = "select * from OnlineExam where stuid='" & StuID & "' and examid='" & lblexamcode.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                btnstart.Enabled = False
                lblqsn.Text = "Answer sheet submitted successfully..."
                lblqsn.Visible = True
            Else
                btnstart.Enabled = True
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmOnlineExamination_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
        lblregno.Text += StuID
        EGroupBox1.GroupTitle = "Exam Code: " + examcode
        LoadExam(examcode)
        LoadSelectedRecord()
        For i As Integer = 0 To 1000
            AttenAnswer(i) = ""
            AttenQuestion(i) = ""
        Next
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnstart_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnstart.ClickButtonArea
        tmrCountdown.Enabled = True
        lblqsn.Visible = True
        rbtnans1.Visible = True
        rbtnans2.Visible = True
        rbtnans3.Visible = True
        rbtnans4.Visible = True
        btnnext.Visible = True
        btnprev.Visible = True

        LoadQuestions(lblexamcode.Text)

        Count = 0
        lblqsn.Text = Question(Count)
        rbtnans1.Text = Answer1(Count)
        rbtnans2.Text = Answer2(Count)
        rbtnans3.Text = Answer3(Count)
        rbtnans4.Text = Answer4(Count)

        btnprev.Enabled = False

        If Count = TotalQuestions Then
            btnnext.Enabled = False
        End If
        btnstart.Enabled = False
    End Sub

    Private Sub btnprev_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnprev.ClickButtonArea
        AttenQuestion(Count) = lblqsn.Text
        If rbtnans1.Checked = True Then
            AttenAnswer(Count) = rbtnans1.Text
        ElseIf rbtnans2.Checked = True Then
            AttenAnswer(Count) = rbtnans2.Text
        ElseIf rbtnans3.Checked = True Then
            AttenAnswer(Count) = rbtnans3.Text
        ElseIf rbtnans4.Checked = True Then
            AttenAnswer(Count) = rbtnans4.Text
        Else
            AttenAnswer(Count) = ""
        End If

        Count -= 1
        lblqsn.Text = Question(Count)
        rbtnans1.Text = Answer1(Count)
        rbtnans2.Text = Answer2(Count)
        rbtnans3.Text = Answer3(Count)
        rbtnans4.Text = Answer4(Count)

        If AttenQuestion(Count) = lblqsn.Text Then
            If AttenAnswer(Count) = rbtnans1.Text Then
                rbtnans1.Checked = True
            ElseIf AttenAnswer(Count) = rbtnans2.Text Then
                rbtnans2.Checked = True
            ElseIf AttenAnswer(Count) = rbtnans3.Text Then
                rbtnans3.Checked = True
            ElseIf AttenAnswer(Count) = rbtnans4.Text Then
                rbtnans4.Checked = True
            End If
        Else
            rbtnans1.Checked = False
            rbtnans2.Checked = False
            rbtnans3.Checked = False
            rbtnans4.Checked = False
        End If

        If Count < TotalQuestions - 1 Then
            btnnext.Text = "Next"
        End If

        If Count = 0 Then
            btnprev.Enabled = False
        End If
    End Sub

    Private Sub btnnext_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnext.ClickButtonArea
        If btnnext.Text <> "Finish" Then
            AttenQuestion(Count) = lblqsn.Text
            If rbtnans1.Checked = True Then
                AttenAnswer(Count) = rbtnans1.Text
            ElseIf rbtnans2.Checked = True Then
                AttenAnswer(Count) = rbtnans2.Text
            ElseIf rbtnans3.Checked = True Then
                AttenAnswer(Count) = rbtnans3.Text
            ElseIf rbtnans4.Checked = True Then
                AttenAnswer(Count) = rbtnans4.Text
            Else
                AttenAnswer(Count) = ""
            End If

            Count += 1
            lblqsn.Text = Question(Count)
            rbtnans1.Text = Answer1(Count)
            rbtnans2.Text = Answer2(Count)
            rbtnans3.Text = Answer3(Count)
            rbtnans4.Text = Answer4(Count)

            If AttenQuestion(Count) = lblqsn.Text Then
                If AttenAnswer(Count) = rbtnans1.Text Then
                    rbtnans1.Checked = True
                ElseIf AttenAnswer(Count) = rbtnans2.Text Then
                    rbtnans2.Checked = True
                ElseIf AttenAnswer(Count) = rbtnans3.Text Then
                    rbtnans3.Checked = True
                ElseIf AttenAnswer(Count) = rbtnans4.Text Then
                    rbtnans4.Checked = True
                End If
            Else
                rbtnans1.Checked = False
                rbtnans2.Checked = False
                rbtnans3.Checked = False
                rbtnans4.Checked = False
            End If

            btnprev.Enabled = True

            If Count = TotalQuestions - 1 Then
                btnnext.Text = "Finish"
            End If
        Else
            AttenQuestion(Count) = lblqsn.Text
            If rbtnans1.Checked = True Then
                AttenAnswer(Count) = rbtnans1.Text
            ElseIf rbtnans2.Checked = True Then
                AttenAnswer(Count) = rbtnans2.Text
            ElseIf rbtnans3.Checked = True Then
                AttenAnswer(Count) = rbtnans3.Text
            ElseIf rbtnans4.Checked = True Then
                AttenAnswer(Count) = rbtnans4.Text
            Else
                AttenAnswer(Count) = ""
            End If
            AddRecord()
        End If
    End Sub
#End Region
#Region "Timer Events..."
    Private Sub tmrCountdown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCountdown.Tick
        duration -= 1
        lbltime.Text = FormatTime(duration)
        If duration = 0 Then
            tmrCountdown.Enabled = False
        End If
    End Sub
#End Region
End Class
#End Region