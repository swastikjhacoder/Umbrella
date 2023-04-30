#Region "Imports..."
Imports ESAR_Controls.UIControls.TextBox
#End Region
#Region "Class frmStudentControlPanel..."
Public Class frmStudentControlPanel
#Region "Declarations..."
    Private DGVRegNo As New DataGridView()
    Private DGVExam As New DataGridView()
    Private DGVCourse As New DataGridView()
    Private DGVNewCourse As New DataGridView()
    Private i As Integer = 0
    Private Modify As Boolean = False
    Private ModifyIndex As Integer = 0
    Private ACODE As String = ""
    Private TT As String = ""
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        ACODE = Indx.LoadControlID()
        Dim var As String
        var = CodeIncrement(ACODE)
        Me.txtcontrolid.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("CTRL:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        Label1.SetBounds(15, 17, 98, 13)
        Label10.SetBounds(12, 79, 81, 13)
        Label11.SetBounds(12, 105, 71, 13)
        Label12.SetBounds(12, 133, 61, 13)
        Label13.SetBounds(12, 187, 77, 13)
        Label14.SetBounds(12, 160, 68, 13)
        Label15.SetBounds(245, 17, 51, 13)
        Label2.SetBounds(15, 44, 93, 13)
        Label3.SetBounds(15, 31, 53, 13)
        Label4.SetBounds(15, 58, 82, 13)
        Label5.SetBounds(15, 85, 45, 13)
        Label6.SetBounds(15, 112, 65, 13)
        Label7.SetBounds(15, 139, 53, 13)
        Label8.SetBounds(15, 166, 70, 13)
        Label9.SetBounds(15, 193, 63, 13)

        btnmove.SetBounds(81, 217, 235, 36)

        cmbcourse.SetBounds(119, 28, 121, 21)
        cmbexamination.SetBounds(119, 55, 121, 21)
        cmbnewclass.SetBounds(171, 102, 108, 21)
        cmbnewcourse.SetBounds(116, 76, 163, 21)
        cmbnewtime.SetBounds(116, 157, 74, 21)
        cmbnewtuition.SetBounds(116, 184, 74, 21)
        cmbpassfail.SetBounds(119, 109, 121, 21)
        cmbregid.SetBounds(119, 14, 121, 21)

        chkupdate.SetBounds(15, 43, 168, 17)
        nudnewclass.SetBounds(116, 102, 49, 21)

        txtcontrolid.SetBounds(303, 14, 100, 21)
        txtcredits.SetBounds(119, 136, 121, 21)
        txtname.SetBounds(119, 41, 284, 21)
        txtnewrollno.SetBounds(116, 130, 47, 21)
        txtreference.SetBounds(119, 163, 284, 21)
        txtremarks.SetBounds(119, 190, 284, 21)
        txtscore.SetBounds(119, 82, 121, 21)
    End Sub

    Private Sub LoadRegNo()
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .HeaderText = "Registration No."
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .HeaderText = "Name"
            End With
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .HeaderText = "Course"
            End With

            With DGVRegNo
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVRegNo.CellClick, AddressOf DGVRegNo_CellClick
            End With

            DGVRegNo.Columns.Clear()
            DGVRegNo.Columns.Add(col1)
            DGVRegNo.Columns.Add(col2)
            DGVRegNo.Columns.Add(col3)

            DGVRegNo.Rows.Clear()
            Dim i As Integer = 0
            cmd.CommandText = "select stuid,name,course from StudentRegistration where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                DGVRegNo.Rows.Add()
                DGVRegNo.Rows(i).Cells(0).Value = dr("stuid").ToString()
                DGVRegNo.Rows(i).Cells(1).Value = dr("name").ToString()
                DGVRegNo.Rows(i).Cells(2).Value = dr("course").ToString()
                i = i + 1
            End While
            dr.Close()
            DGVRegNo.ClearSelection()

            cmbregid.AddDataGridView(DGVRegNo, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVRegNo_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVRegNo.CurrentRow.Index
            DGVRegNo.Rows(k).Selected = True
            DGVRegNo.CurrentCell = DGVRegNo.Rows(k).Cells(0)
            StuID = DGVRegNo.Rows(k).Cells(0).Value.ToString()
            StuName = DGVRegNo.Rows(k).Cells(1).Value.ToString()
            cmbregid.Text = StuID
            txtname.Text = StuName
            cmbcourse.Text = crsname
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadExamInfo(ByVal course As String)
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .HeaderText = "Exam Code"
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .HeaderText = "Course"
            End With

            With DGVExam
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVExam.CellClick, AddressOf DGVExam_CellClick
            End With

            DGVExam.Columns.Clear()
            DGVExam.Columns.Add(col1)
            DGVExam.Columns.Add(col2)

            DGVExam.Rows.Clear()
            Dim i As Integer = 0
            cmd.CommandText = "select examcode,course from ExamStudents where course='" & course & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                DGVExam.Rows.Add()
                DGVExam.Rows(i).Cells(0).Value = dr("examcode").ToString()
                DGVExam.Rows(i).Cells(1).Value = dr("course").ToString()
                i = i + 1
            End While
            dr.Close()
            DGVExam.ClearSelection()

            cmbexamination.AddDataGridView(DGVExam, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVExam_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVExam.CurrentRow.Index
            DGVExam.Rows(k).Selected = True
            DGVExam.CurrentCell = DGVExam.Rows(k).Cells(0)
            examcode = DGVExam.Rows(k).Cells(0).Value.ToString()
            cmbexamination.Text = examcode
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadCourse()
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .Name = "Col1"
                .HeaderText = "Code"
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .Name = "Col2"
                .HeaderText = "Course"
            End With
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .Name = "Col3"
                .HeaderText = "Duration"
            End With
            Dim col4 As New DataGridViewLinkColumn()
            With col4
                .Name = "Col4"
                .HeaderText = "Code"
            End With
            Dim col5 As New DataGridViewTextBoxColumn()
            With col5
                .Name = "Col5"
                .HeaderText = "Course"
            End With
            Dim col6 As New DataGridViewTextBoxColumn()
            With col6
                .Name = "Col6"
                .HeaderText = "Duration"
            End With

            With DGVCourse
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVCourse.CellClick, AddressOf DGVCourse_CellClick
            End With

            With DGVNewCourse
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVNewCourse.CellClick, AddressOf DGVNewCourse_CellClick
            End With

            DGVCourse.Columns.Clear()
            DGVCourse.Columns.Add(col1)
            DGVCourse.Columns.Add(col2)
            DGVCourse.Columns.Add(col3)

            DGVCourse.Rows.Clear()

            DGVNewCourse.Columns.Clear()
            DGVNewCourse.Columns.Add(col4)
            DGVNewCourse.Columns.Add(col5)
            DGVNewCourse.Columns.Add(col6)

            DGVNewCourse.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select CourseCode,CourseName,Duration from Course where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVCourse.Rows.Add()
                DGVCourse.Rows(indx).Cells(0).Value = dr("CourseCode").ToString()
                DGVCourse.Rows(indx).Cells(1).Value = dr("CourseName").ToString()
                DGVCourse.Rows(indx).Cells(2).Value = dr("Duration").ToString()

                DGVNewCourse.Rows.Add()
                DGVNewCourse.Rows(indx).Cells(0).Value = dr("CourseCode").ToString()
                DGVNewCourse.Rows(indx).Cells(1).Value = dr("CourseName").ToString()
                DGVNewCourse.Rows(indx).Cells(2).Value = dr("Duration").ToString()

                indx = indx + 1
            End While
            dr.Close()
            DGVCourse.ClearSelection()
            DGVNewCourse.ClearSelection()

            cmbcourse.AddDataGridView(DGVCourse, False)
            cmbnewcourse.AddDataGridView(DGVNewCourse, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVCourse_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVCourse.CurrentRow.Index
            DGVCourse.Rows(k).Selected = True
            DGVCourse.CurrentCell = DGVCourse.Rows(k).Cells(0)
            crsname = DGVCourse.Rows(k).Cells(1).Value.ToString()
            cmbcourse.Text = crsname
            LoadExamInfo(cmbcourse.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVNewCourse_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVNewCourse.CurrentRow.Index
            DGVNewCourse.Rows(k).Selected = True
            DGVNewCourse.CurrentCell = DGVNewCourse.Rows(k).Cells(0)
            crsname = DGVNewCourse.Rows(k).Cells(1).Value.ToString()
            cmbnewcourse.Text = crsname
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddToGrid()
        Try
            If cmbexamination.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select examination.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbexamination.Focus()
                End If
            ElseIf txtscore.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter score.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtscore.Focus()
                End If
            ElseIf cmbpassfail.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select pass/fail info.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbpassfail.Focus()
                End If
            Else
                If Modify = False Then
                    dgviewscore.Rows.Add()
                    dgviewscore.Rows(i).Cells(0).Value = cmbexamination.Text
                    dgviewscore.Rows(i).Cells(1).Value = txtscore.Text
                    dgviewscore.Rows(i).Cells(2).Value = cmbpassfail.Text
                    dgviewscore.Rows(i).Cells(3).Value = txtcredits.Text
                    dgviewscore.Rows(i).Cells(4).Value = txtreference.Text
                    dgviewscore.Rows(i).Cells(5).Value = txtremarks.Text
                    i = i + 1
                    cmbexamination.Text = ""
                    txtscore.Text = ""
                    cmbpassfail.Text = ""
                    txtcredits.Text = ""
                    txtreference.Text = ""
                    txtremarks.Text = ""
                    cmbexamination.Focus()
                Else
                    dgviewscore.Rows(ModifyIndex).Cells(0).Value = cmbexamination.Text
                    dgviewscore.Rows(ModifyIndex).Cells(1).Value = txtscore.Text
                    dgviewscore.Rows(ModifyIndex).Cells(2).Value = cmbpassfail.Text
                    dgviewscore.Rows(ModifyIndex).Cells(3).Value = txtcredits.Text
                    dgviewscore.Rows(ModifyIndex).Cells(4).Value = txtreference.Text
                    dgviewscore.Rows(ModifyIndex).Cells(5).Value = txtremarks.Text
                    Modify = False
                    cmbexamination.Text = ""
                    txtscore.Text = ""
                    cmbpassfail.Text = ""
                    txtcredits.Text = ""
                    txtreference.Text = ""
                    txtremarks.Text = ""
                    cmbexamination.Focus()
                End If
                dgviewscore.ClearSelection()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetForm()
        updatestudentcontrol = False
        If ISDAutoID = "Yes" Then
            GetCode()
        Else
            txtcontrolid.Text = ""
        End If
        dgviewscore.Rows.Clear()
        chkupdate.Checked = False
        cmbcourse.Text = ""
        cmbexamination.Text = ""
        cmbnewclass.Text = ""
        cmbnewcourse.Text = ""
        cmbnewtime.Text = ""
        cmbnewtuition.Text = ""
        cmbpassfail.Text = ""
        cmbregid.Text = ""
        nudnewclass.Value = 1
        txtcredits.Text = ""
        txtname.Text = ""
        txtnewrollno.Text = ""
        txtreference.Text = ""
        txtremarks.Text = ""
        txtscore.Text = ""
        Modify = False
        i = 0
        cmbregid.Focus()
    End Sub

    Private Sub AddRecord()
        Try
            If cmbregid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select student registration id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbregid.Focus()
                End If
            ElseIf txtname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter student name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtname.Focus()
                End If
            ElseIf cmbcourse.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select course.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbcourse.Focus()
                End If
            ElseIf dgviewscore.Rows.Count <= 0 Then
                Dim result As DialogResult = MessageBox.Show("Please enter score details.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbexamination.Focus()
                End If
            ElseIf chkupdate.Checked = True And cmbnewclass.Text = "" And cmbnewcourse.Text = "" And cmbnewtime.Text = "" And cmbnewtuition.Text = "" And txtnewrollno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter student update info.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    nudnewclass.Focus()
                End If
            ElseIf txtcontrolid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter control id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtcontrolid.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cStudentControl()
                    Dim alsoupdate As String = ""
                    Dim newcouse As String = ""
                    Dim newclassint As Integer = 1
                    Dim newclassstring As String = ""
                    Dim newclass As String = ""
                    Dim newroll As String = ""
                    Dim newtime As String = ""
                    Dim newtuition As String = ""
                    If chkupdate.Checked = True Then
                        alsoupdate = "Yes"
                        newcouse = cmbnewcourse.Text
                        newclassint = CInt(nudnewclass.Value.ToString())
                        newclassstring = cmbnewclass.Text
                        newclass = newclassint.ToString() + " " + newclassstring
                        newroll = txtnewrollno.Text
                        newtime = cmbnewtime.Text
                        newtuition = cmbnewtuition.Text
                    Else
                        alsoupdate = "No"
                        newcouse = ""
                        newclassint = 1
                        newclassstring = ""
                        newclass = ""
                        newroll = ""
                        newtime = ""
                        newtuition = ""
                    End If
                    For row As Integer = 0 To dgviewscore.Rows.Count - 1
                        Dim examination As String = dgviewscore.Rows(row).Cells(0).Value.ToString()
                        Dim scored As Decimal = CDec(dgviewscore.Rows(row).Cells(1).Value.ToString())
                        Dim passfail As String = dgviewscore.Rows(row).Cells(2).Value.ToString()
                        Dim credits As Decimal = CDec(dgviewscore.Rows(row).Cells(3).Value.ToString())
                        Dim reference As String = dgviewscore.Rows(row).Cells(4).Value.ToString()
                        Dim remarks As String = dgviewscore.Rows(row).Cells(5).Value.ToString()
                        cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtcontrolid.Text, cmbregid.Text, txtname.Text, cmbcourse.Text, examination, scored, passfail, credits, reference, remarks, alsoupdate, newcouse, newclassint, newclassstring, newclass, newroll, newtime, newtuition)
                    Next
                    If alsoupdate = "Yes" Then
                        cmd.CommandText = "update StudentRegistration set course='" & newcouse & "',class='" & newclass & "',classint=" & newclassint & ",classstring='" & newclassstring & "',roll='" & newroll & "',time='" & newtime & "',tuition='" & newtuition & "' where stuid='" & cmbregid.Text & "' and name='" & txtname.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                    End If
                    If cls.AddRecordOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record added successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            cmbregid.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If cmbregid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select student registration id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbregid.Focus()
                End If
            ElseIf txtname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter student name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtname.Focus()
                End If
            ElseIf cmbcourse.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select course.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbcourse.Focus()
                End If
            ElseIf dgviewscore.Rows.Count <= 0 Then
                Dim result As DialogResult = MessageBox.Show("Please enter score details.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbexamination.Focus()
                End If
            ElseIf chkupdate.Checked = True And cmbnewclass.Text = "" And cmbnewcourse.Text = "" And cmbnewtime.Text = "" And cmbnewtuition.Text = "" And txtnewrollno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter student update info.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    nudnewclass.Focus()
                End If
            ElseIf txtcontrolid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter control id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtcontrolid.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cStudentControl()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtcontrolid.Text, cmbregid.Text, txtname.Text, cmbcourse.Text)
                    If cls.DeleteRecordOk = True Then
                        Dim alsoupdate As String = ""
                        Dim newcouse As String = ""
                        Dim newclassint As Integer = 1
                        Dim newclassstring As String = ""
                        Dim newclass As String = ""
                        Dim newroll As String = ""
                        Dim newtime As String = ""
                        Dim newtuition As String = ""
                        If chkupdate.Checked = True Then
                            alsoupdate = "Yes"
                            newcouse = cmbnewcourse.Text
                            newclassint = CInt(nudnewclass.Value.ToString())
                            newclassstring = cmbnewclass.Text
                            newclass = newclassint.ToString() + " " + newclassstring
                            newroll = txtnewrollno.Text
                            newtime = cmbnewtime.Text
                            newtuition = cmbnewtuition.Text
                        Else
                            alsoupdate = "No"
                            newcouse = ""
                            newclassint = 1
                            newclassstring = ""
                            newclass = ""
                            newroll = ""
                            newtime = ""
                            newtuition = ""
                        End If
                        For row As Integer = 0 To dgviewscore.Rows.Count - 1
                            Dim examination As String = dgviewscore.Rows(row).Cells(0).Value.ToString()
                            Dim scored As Decimal = CDec(dgviewscore.Rows(row).Cells(1).Value.ToString())
                            Dim passfail As String = dgviewscore.Rows(row).Cells(2).Value.ToString()
                            Dim credits As Decimal = CDec(dgviewscore.Rows(row).Cells(3).Value.ToString())
                            Dim reference As String = dgviewscore.Rows(row).Cells(4).Value.ToString()
                            Dim remarks As String = dgviewscore.Rows(row).Cells(5).Value.ToString()
                            cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtcontrolid.Text, cmbregid.Text, txtname.Text, cmbcourse.Text, examination, scored, passfail, credits, reference, remarks, alsoupdate, newcouse, newclassint, newclassstring, newclass, newroll, newtime, newtuition)
                        Next
                        If alsoupdate = "Yes" Then
                            cmd.CommandText = "update StudentRegistration set course='" & newcouse & "',class='" & newclass & "',classint=" & newclassint & ",classstring='" & newclassstring & "',roll='" & newroll & "',time='" & newtime & "',tuition='" & newtuition & "' where stuid='" & cmbregid.Text & "' and name='" & txtname.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                        End If
                        If cls.AddRecordOk = True Then
                            Dim result1 As DialogResult = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = Windows.Forms.DialogResult.OK Then
                                cmbregid.Focus()
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If cmbregid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select student registration id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbregid.Focus()
                End If
            ElseIf txtname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter student name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtname.Focus()
                End If
            ElseIf cmbcourse.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select course.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbcourse.Focus()
                End If
            ElseIf dgviewscore.Rows.Count <= 0 Then
                Dim result As DialogResult = MessageBox.Show("Please enter score details.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbexamination.Focus()
                End If
            ElseIf txtcontrolid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter control id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtcontrolid.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cStudentControl()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtcontrolid.Text, cmbregid.Text, txtname.Text, cmbcourse.Text)
                    If cls.DeleteRecordOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record deleted successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            ResetForm()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedRecord()
        Try
            Dim row As Integer = 0
            dgviewscore.Rows.Clear()
            cmd.CommandText = "select * from StudentControl where controlid='" & controlid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                txtcontrolid.Text = dr("controlid").ToString()
                cmbregid.Text = dr("regno").ToString()
                txtname.Text = dr("name").ToString()
                cmbcourse.Text = dr("course").ToString()
                If dr("alsoupdate").ToString() = "Yes" Then
                    chkupdate.Checked = True
                Else
                    chkupdate.Checked = False
                End If
                nudnewclass.Value = CInt(dr("newclassint").ToString())
                cmbnewclass.Text = dr("newclassstring").ToString()
                cmbnewcourse.Text = dr("newcouse").ToString()
                cmbnewtime.Text = dr("newtime").ToString()
                cmbnewtuition.Text = dr("newtuition").ToString()
                txtnewrollno.Text = dr("newroll").ToString()
                dgviewscore.Rows.Add()
                dgviewscore.Rows(row).Cells(0).Value = dr("examination").ToString()
                dgviewscore.Rows(row).Cells(1).Value = dr("scored").ToString()
                dgviewscore.Rows(row).Cells(2).Value = dr("passfail").ToString()
                dgviewscore.Rows(row).Cells(3).Value = dr("credits").ToString()
                dgviewscore.Rows(row).Cells(4).Value = dr("reference").ToString()
                dgviewscore.Rows(row).Cells(5).Value = dr("remarks").ToString()
                row = row + 1
            End While
            dgviewscore.ClearSelection()
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub MoveToAlumni()
        Try
            If cmbregid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select student registration id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbregid.Focus()
                End If
            ElseIf txtname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter student name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtname.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to move this record to alumni?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cAlumni()
                    Dim regno As String = cmbregid.Text
                    Dim name As String = txtname.Text
                    Dim alumniyear As Integer = Date.Now.Year
                    cls.AddRecord(regno, name, alumniyear, UmbrellaSystemDate)
                    If cls.AddRecordOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record moved successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmStudentControlPanel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updatestudentcontrol = False Then
            ControlSetBound()
            LoadRegNo()
            LoadCourse()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadRegNo()
            LoadCourse()
            LoadSelectedRecord()
        End If
        If USstudentcontrol = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            btnmove.Enabled = False
            cmbcourse.Enabled = False
            cmbexamination.Enabled = False
            cmbnewclass.Enabled = False
            cmbnewcourse.Enabled = False
            cmbnewtime.Enabled = False
            cmbnewtuition.Enabled = False
            cmbpassfail.Enabled = False
            cmbregid.Enabled = False
            chkupdate.Enabled = False
            txtcredits.ReadOnly = False
            txtname.ReadOnly = True
            txtnewrollno.ReadOnly = True
            txtreference.ReadOnly = True
            txtremarks.ReadOnly = True
            txtscore.ReadOnly = True
            dgviewscore.Enabled = False
            nudnewclass.Enabled = False
        End If
    End Sub
#End Region
#Region "Attributes..."
    Private Sub cmbregid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbregid.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtname.Focus()
        End If
    End Sub

    Private Sub txtname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbcourse.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbregid.Focus()
        End If
    End Sub

    Private Sub cmbcourse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcourse.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbexamination.Focus()
        End If
    End Sub

    Private Sub cmbexamination_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbexamination.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtscore.Focus()
        End If
    End Sub

    Private Sub txtscore_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtscore.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbpassfail.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbexamination.Focus()
        End If
    End Sub

    Private Sub cmbpassfail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbpassfail.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcredits.Focus()
        End If
    End Sub

    Private Sub txtcredits_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcredits.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtreference.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbpassfail.Focus()
        End If
    End Sub

    Private Sub txtreference_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtreference.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtremarks.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcredits.Focus()
        End If
    End Sub

    Private Sub txtremarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtremarks.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            AddToGrid()
        ElseIf e.KeyCode = Keys.Up Then
            txtreference.Focus()
        End If
    End Sub

    Private Sub chkupdate_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkupdate.CheckedChanged
        If chkupdate.Checked = True Then
            cmbnewclass.Enabled = True
            cmbnewcourse.Enabled = True
            cmbnewtime.Enabled = True
            cmbnewtuition.Enabled = True
            nudnewclass.Enabled = True
            txtnewrollno.Enabled = True
        Else
            cmbnewclass.Enabled = False
            cmbnewcourse.Enabled = False
            cmbnewtime.Enabled = False
            cmbnewtuition.Enabled = False
            nudnewclass.Enabled = False
            txtnewrollno.Enabled = False
        End If
    End Sub

    Private Sub cmbnewcourse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbnewcourse.KeyDown
        If e.KeyCode = Keys.Enter Then
            nudnewclass.Focus()
        End If
    End Sub

    Private Sub nudnewclass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudnewclass.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbnewclass.Focus()
        End If
    End Sub

    Private Sub cmbnewclass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbnewclass.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtnewrollno.Focus()
        End If
    End Sub

    Private Sub txtnewrollno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnewrollno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbnewtime.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbnewclass.Focus()
        End If
    End Sub

    Private Sub cmbnewtime_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbnewtime.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbnewtuition.Focus()
        End If
    End Sub

    Private Sub TextBoxTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtname.TextChanged, txtreference.TextChanged, txtremarks.TextChanged
        Dim ctc As New cTextChange()
        Dim x As eTextBox = CType(sender, eTextBox)
        ctc.ConvertTextBoxValidValue(x)
    End Sub

    Private Sub ComboBoxKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcourse.KeyPress, cmbexamination.KeyPress, cmbnewclass.KeyPress, cmbnewcourse.KeyPress, cmbnewtime.KeyPress, cmbnewtuition.KeyPress, cmbpassfail.KeyPress, cmbregid.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub
#End Region
#Region "ContextMenuStrip Events..."
    Private Sub ModifyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyToolStripMenuItem.Click
        Dim row As Integer = dgviewscore.CurrentRow.Index
        cmbexamination.Text = dgviewscore.Rows(row).Cells(0).Value.ToString()
        txtscore.Text = dgviewscore.Rows(row).Cells(1).Value.ToString()
        cmbpassfail.Text = dgviewscore.Rows(row).Cells(2).Value.ToString()
        txtcredits.Text = dgviewscore.Rows(row).Cells(3).Value.ToString()
        txtreference.Text = dgviewscore.Rows(row).Cells(4).Value.ToString()
        txtremarks.Text = dgviewscore.Rows(row).Cells(5).Value.ToString()
        Modify = True
        ModifyIndex = row
        cmbexamination.Focus()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim row As Integer = dgviewscore.CurrentRow.Index
        dgviewscore.Rows.RemoveAt(row)
        i = i - 1
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnmove_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnmove.ClickButtonArea
        MoveToAlumni()
    End Sub

    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatestudentcontrol = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatestudentcontrol = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatestudentcontrol = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updatestudentcontrol = False Then
            ControlSetBound()
            LoadRegNo()
            LoadCourse()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadRegNo()
            LoadCourse()
            LoadSelectedRecord()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region