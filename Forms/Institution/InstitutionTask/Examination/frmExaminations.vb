#Region "Imports..."
Imports ESAR_Controls.UIControls.ComboBox
#End Region
#Region "Class frmOnlineExamination..."
Public Class frmExaminations
#Region "Declarations..."
    Private ACODE As String = ""
    Private TT As String = ""
    Private DGVCourse As New Windows.Forms.DataGridView()
    Private DGVSubject As New Windows.Forms.DataGridView()
    Private DGVVisitors As New Windows.Forms.DataGridView()
    Private ExamExist As Boolean = False
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        ACODE = Indx.LoadExamCode()
        Dim var As String
        var = CodeIncrement(ACODE)
        Me.txtexamcode.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("XM:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        btnadd.SetBounds(695, 5, 56, 25)

        Label1.SetBounds(16, 15, 78, 13)
        Label2.SetBounds(16, 45, 53, 13)
        Label3.SetBounds(314, 45, 55, 13)
        Label4.SetBounds(16, 72, 52, 13)
        Label5.SetBounds(235, 72, 87, 13)
        Label6.SetBounds(513, 45, 75, 13)
        Label7.SetBounds(513, 72, 66, 13)
        Label9.SetBounds(13, 38, 76, 13)
        Label10.SetBounds(176, 38, 138, 13)
        lblroomno.SetBounds(13, 63, 64, 13)
        lblroomenter.SetBounds(13, 86, 329, 13)
        lblvisitors.SetBounds(415, 11, 47, 13)
        Label17.SetBounds(13, 11, 87, 13)

        mskexamtime.SetBounds(120, 35, 49, 14)

        lstvisitors.SetBounds(475, 34, 276, 65)

        txtexamcode.SetBounds(100, 12, 208, 21)
        cmbsubject.SetBounds(372, 42, 135, 21)
        txtexamcenter.SetBounds(119, 8, 276, 21)
        txtroomno.SetBounds(119, 60, 276, 21)

        cmbexamcenter.SetBounds(328, 69, 179, 21)
        cmbbranch.SetBounds(100, 69, 129, 21)
        cmbcourse.SetBounds(100, 42, 208, 21)
        cmbexamdate.SetBounds(594, 42, 141, 21)
        cmbexamfor.SetBounds(594, 69, 141, 22)
        cmbguard.SetBounds(475, 8, 214, 22)
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

            DGVCourse.Columns.Clear()
            DGVCourse.Columns.Add(col1)
            DGVCourse.Columns.Add(col2)
            DGVCourse.Columns.Add(col3)

            DGVCourse.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select CourseCode,CourseName,Duration from Course where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVCourse.Rows.Add()
                DGVCourse.Rows(indx).Cells(0).Value = dr("CourseCode").ToString()
                DGVCourse.Rows(indx).Cells(1).Value = dr("CourseName").ToString()
                DGVCourse.Rows(indx).Cells(2).Value = dr("Duration").ToString()

                indx = indx + 1
            End While
            dr.Close()
            DGVCourse.ClearSelection()

            cmbcourse.AddDataGridView(DGVCourse, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVCourse_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVCourse.CurrentRow.Index
            DGVCourse.Rows(k).Selected = True
            DGVCourse.CurrentCell = DGVCourse.Rows(k).Cells(0)
            crscode = DGVCourse.Rows(k).Cells(0).Value.ToString()
            crsname = DGVCourse.Rows(k).Cells(1).Value.ToString()
            cmbcourse.Text = crsname
            LoadSubject()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSubject()
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .Name = "Col1"
                .HeaderText = "Code"
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .Name = "Col2"
                .HeaderText = "Subject"
            End With

            With DGVSubject
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
                AddHandler DGVSubject.CellClick, AddressOf DGVSubject_CellClick
            End With

            DGVSubject.Columns.Clear()
            DGVSubject.Columns.Add(col1)
            DGVSubject.Columns.Add(col2)

            DGVSubject.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select gensubjectcode,gensubject from Subjects where course='" & cmbcourse.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                DGVSubject.Rows.Add()
                DGVSubject.Rows(indx).Cells(0).Value = dr("gensubjectcode").ToString()
                DGVSubject.Rows(indx).Cells(1).Value = dr("gensubject").ToString()
                indx = indx + 1
            End While
            dr.Close()
            cmd.CommandText = "select pracsubjectcode,pracsubject from Subjects where course='" & cmbcourse.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                DGVSubject.Rows.Add()
                DGVSubject.Rows(indx).Cells(0).Value = dr("pracsubjectcode").ToString()
                DGVSubject.Rows(indx).Cells(1).Value = dr("pracsubject").ToString()
                indx = indx + 1
            End While
            dr.Close()
            DGVSubject.ClearSelection()

            cmbsubject.AddDataGridView(DGVSubject, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVSubject_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVSubject.CurrentRow.Index
            DGVSubject.Rows(k).Selected = True
            DGVSubject.CurrentCell = DGVSubject.Rows(k).Cells(0)
            subjectcode = DGVSubject.Rows(k).Cells(0).Value.ToString()
            subject = DGVSubject.Rows(k).Cells(1).Value.ToString()
            cmbsubject.Text = subject
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadVisitors()
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .Name = "Col1"
                .HeaderText = "Employee ID"
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .Name = "Col2"
                .HeaderText = "Name"
            End With
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .Name = "Col3"
                .HeaderText = "Designation"
            End With

            With DGVVisitors
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
                AddHandler DGVVisitors.CellClick, AddressOf DGVVisitors_CellClick
            End With

            DGVVisitors.Columns.Clear()
            DGVVisitors.Columns.Add(col1)
            DGVVisitors.Columns.Add(col2)
            DGVVisitors.Columns.Add(col3)

            DGVVisitors.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select empid,name,designation from Employee where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVVisitors.Rows.Add()
                DGVVisitors.Rows(indx).Cells(0).Value = dr("empid").ToString()
                DGVVisitors.Rows(indx).Cells(1).Value = dr("name").ToString()
                DGVVisitors.Rows(indx).Cells(2).Value = dr("designation").ToString()

                indx = indx + 1
            End While
            dr.Close()
            DGVVisitors.ClearSelection()

            cmbguard.AddDataGridView(DGVVisitors, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVVisitors_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVVisitors.CurrentRow.Index
            DGVVisitors.Rows(k).Selected = True
            DGVVisitors.CurrentCell = DGVVisitors.Rows(k).Cells(0)
            EmpRegNo = DGVVisitors.Rows(k).Cells(0).Value.ToString()
            EmpName = DGVVisitors.Rows(k).Cells(1).Value.ToString()
            EmpDesignation = DGVVisitors.Rows(k).Cells(2).Value.ToString()
            cmbguard.Text = EmpName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadBranch()
        Try
            cmd.CommandText = "select branch from Examination where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                cmbbranch.Items.Add(dr("branch").ToString())
            End While
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadStudentsSelected()
        Try
            dgviewstudents.Rows.Clear()
            dgviewstudents.Columns.Clear()

            Dim col1 As New DataGridViewCheckBoxColumn()
            With col1
                .Name = "col1"
                .HeaderText = ""
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .FlatStyle = FlatStyle.Standard
                .CellTemplate = New DataGridViewCheckBoxCell()
                .CellTemplate.Style.BackColor = Color.Beige
                .Width = 40
                .ReadOnly = False
            End With
            Dim col2 As New DataGridViewLinkColumn()
            With col2
                .Name = "col2"
                .HeaderText = "Student ID"
                .Width = 150
            End With
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .Name = "col3"
                .HeaderText = "Student Name"
                .Width = 350
            End With
            Dim col4 As New DataGridViewTextBoxColumn()
            With col4
                .Name = "col4"
                .HeaderText = "Course"
                .Width = 255
            End With

            dgviewstudents.Columns.Add(col1)
            dgviewstudents.Columns.Add(col2)
            dgviewstudents.Columns.Add(col3)
            dgviewstudents.Columns.Add(col4)

            Dim i As Integer = 0
            cmd.CommandText = "select stuid,name,course from StudentRegistration where course='" & cmbcourse.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewstudents.Rows.Add()
                dgviewstudents.Rows(i).Cells(0).Value = True
                dgviewstudents.Rows(i).Cells(1).Value = dr("stuid").ToString()
                dgviewstudents.Rows(i).Cells(2).Value = dr("name").ToString()
                dgviewstudents.Rows(i).Cells(3).Value = dr("course").ToString()
                i = i + 1
            End While
            dr.Close()
            dgviewstudents.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadStudentsAll()
        Try
            dgviewstudents.Rows.Clear()
            dgviewstudents.Columns.Clear()

            Dim col2 As New DataGridViewLinkColumn()
            With col2
                .Name = "col2"
                .HeaderText = "Student ID"
                .Width = 150
            End With
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .Name = "col3"
                .HeaderText = "Student Name"
                .Width = 350
            End With
            Dim col4 As New DataGridViewTextBoxColumn()
            With col4
                .Name = "col4"
                .HeaderText = "Course"
                .Width = 255
            End With

            dgviewstudents.Columns.Add(col2)
            dgviewstudents.Columns.Add(col3)
            dgviewstudents.Columns.Add(col4)

            Dim i As Integer = 0
            cmd.CommandText = "select stuid,name,course from StudentRegistration where course='" & cmbcourse.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewstudents.Rows.Add()
                dgviewstudents.Rows(i).Cells(0).Value = dr("stuid").ToString()
                dgviewstudents.Rows(i).Cells(1).Value = dr("name").ToString()
                dgviewstudents.Rows(i).Cells(2).Value = dr("course").ToString()
                i = i + 1
            End While
            dr.Close()
            dgviewstudents.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub ResetForm()
        updateexamination = False
        Panel5.Visible = False
        lblroomenter.Visible = False
        lblroomno.Visible = False
        txtroomno.Visible = False
        lblvisitors.Text = "Guard:"
        cmbsubject.Text = ""
        txtexamcenter.Text = ""
        txtroomno.Text = ""
        cmbbranch.Text = ""
        cmbcourse.Text = ""
        cmbexamcenter.Text = ""
        cmbexamdate.Text = ""
        cmbexamfor.Text = ""
        cmbguard.Text = ""
        mskexamtime.Text = ""
        lstvisitors.Items.Clear()
        dgviewstudents.Rows.Clear()
        dgviewstudents.Columns.Clear()
        If ISDAutoID = "Yes" Then
            GetCode()
        Else
            txtexamcode.Text = ""
        End If
        cmbcourse.Focus()
    End Sub

    Private Sub AddRecord()
        Try
            If txtexamcode.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter exam code.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtexamcode.Focus()
                End If
            ElseIf cmbcourse.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter course name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbcourse.Focus()
                End If
            ElseIf cmbsubject.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter subject.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbsubject.Focus()
                End If
            ElseIf cmbexamdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter exam date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbexamdate.Focus()
                End If
            ElseIf cmbexamcenter.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter exam center.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbexamcenter.Focus()
                End If
            ElseIf cmbexamfor.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter exam for.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbexamfor.Focus()
                End If
            ElseIf cmbexamfor.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter exam for.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbexamfor.Focus()
                End If
            ElseIf mskexamtime.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter exam time.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    mskexamtime.Focus()
                End If
            ElseIf txtexamcenter.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter exam center name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtexamcenter.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    CheckExamID()
                    If ExamExist = False Then
                        Dim cls As New cExamination()
                        cls.AddExamination(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtexamcode.Text, cmbcourse.Text, cmbsubject.Text, cmbexamdate.Text, cmbbranch.Text, cmbexamcenter.Text, cmbexamfor.Text, txtexamcenter.Text, mskexamtime.Text, txtroomno.Text)
                        If cmbexamfor.Text = "All Students" Then
                            For i As Integer = 0 To dgviewstudents.Rows.Count - 1
                                cls.AddExaminationStudent(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtexamcode.Text, dgviewstudents.Rows(i).Cells(0).Value.ToString(), dgviewstudents.Rows(i).Cells(1).Value.ToString(), dgviewstudents.Rows(i).Cells(2).Value.ToString())
                            Next
                        Else
                            For i As Integer = 0 To dgviewstudents.Rows.Count - 1
                                If dgviewstudents.Rows(i).Cells(0).Value = True Then
                                    cls.AddExaminationStudent(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtexamcode.Text, dgviewstudents.Rows(i).Cells(1).Value.ToString(), dgviewstudents.Rows(i).Cells(2).Value.ToString(), dgviewstudents.Rows(i).Cells(3).Value.ToString())
                                End If
                            Next
                        End If
                        For i As Integer = 0 To lstvisitors.Items.Count - 1
                            cls.AddExaminationGuard(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtexamcode.Text, lstvisitors.Items(i).ToString())
                        Next
                        If cls.AddExamOk = True And cls.AddExamStuOk = True And cls.AddExamGuardOk = True Then
                            Dim result1 As DialogResult = MessageBox.Show("Record added successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = Windows.Forms.DialogResult.OK Then
                                cmbcourse.Focus()
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Exam code already exist." + Environment.NewLine + "Please enter a new exam code.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            txtexamcode.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If txtexamcode.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter exam code.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtexamcode.Focus()
                End If
            ElseIf cmbcourse.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter course name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbcourse.Focus()
                End If
            ElseIf cmbsubject.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter subject.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbsubject.Focus()
                End If
            ElseIf cmbexamdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter exam date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbexamdate.Focus()
                End If
            ElseIf cmbexamcenter.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter exam center.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbexamcenter.Focus()
                End If
            ElseIf cmbexamfor.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter exam for.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbexamfor.Focus()
                End If
            ElseIf cmbexamfor.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter exam for.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbexamfor.Focus()
                End If
            ElseIf mskexamtime.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter exam time.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    mskexamtime.Focus()
                End If
            ElseIf txtexamcenter.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter exam center name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtexamcenter.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    cmd.CommandText = "delete from ExamStudents where examcode='" & txtexamcode.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                    dr = cmd.ExecuteReader
                    dr.Close()
                    cmd.CommandText = "delete from ExamGuard where examcode='" & txtexamcode.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                    dr = cmd.ExecuteReader
                    dr.Close()
                    Dim cls As New cExamination()
                    cls.UpdateExamination(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtexamcode.Text, cmbcourse.Text, cmbsubject.Text, cmbexamdate.Text, cmbbranch.Text, cmbexamcenter.Text, cmbexamfor.Text, txtexamcenter.Text, mskexamtime.Text, txtroomno.Text)
                    If cmbexamfor.Text = "All Students" Then
                        For i As Integer = 0 To dgviewstudents.Rows.Count - 1
                            cls.AddExaminationStudent(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtexamcode.Text, dgviewstudents.Rows(i).Cells(0).Value.ToString(), dgviewstudents.Rows(i).Cells(1).Value.ToString(), dgviewstudents.Rows(i).Cells(2).Value.ToString())
                        Next
                    Else
                        For i As Integer = 0 To dgviewstudents.Rows.Count - 1
                            If dgviewstudents.Rows(i).Cells(0).Value = True Then
                                cls.AddExaminationStudent(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtexamcode.Text, dgviewstudents.Rows(i).Cells(1).Value.ToString(), dgviewstudents.Rows(i).Cells(2).Value.ToString(), dgviewstudents.Rows(i).Cells(3).Value.ToString())
                            End If
                        Next
                    End If
                    For i As Integer = 0 To lstvisitors.Items.Count - 1
                        cls.AddExaminationGuard(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtexamcode.Text, lstvisitors.Items(i).ToString())
                    Next
                    If cls.UpdateExamOk = True And cls.AddExamStuOk = True And cls.AddExamGuardOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            cmbcourse.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If txtexamcode.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter exam code.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtexamcode.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cExamination()
                    cls.DeleteExamination(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtexamcode.Text)
                    If cls.DeleteExamOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Please deleted successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            ResetForm()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedExam()
        Try
            Dim examfor As String = ""
            cmd.CommandText = "select * from Examination where examcode='" & examcode & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                txtexamcode.Text = dr("examcode").ToString()
                cmbcourse.Text = dr("course").ToString()
                cmbsubject.Text = dr("subject").ToString()
                cmbexamdate.Text = dr("examdate").ToString()
                cmbbranch.Text = dr("branch").ToString()
                cmbexamcenter.Text = dr("examcenter").ToString()
                examfor = dr("examfor").ToString()
                txtexamcenter.Text = dr("examinstitute").ToString()
                mskexamtime.Text = dr("examtime").ToString()
                txtroomno.Text = dr("roomno").ToString()
            End If
            dr.Close()
            cmbexamfor.Text = examfor
            LoadSelectedExamStudents(examcode)
            LoadSelectedExamGuards(examcode)
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadSelectedExamStudents(ByVal examcode As String)
        Try
            If cmbexamfor.Text = "All Students" Then
                LoadStudentsAll()
            Else
                dgviewstudents.Rows.Clear()
                dgviewstudents.Columns.Clear()

                Dim col1 As New DataGridViewCheckBoxColumn()
                With col1
                    .Name = "col1"
                    .HeaderText = ""
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .FlatStyle = FlatStyle.Standard
                    .CellTemplate = New DataGridViewCheckBoxCell()
                    .CellTemplate.Style.BackColor = Color.Beige
                    .Width = 40
                    .ReadOnly = False
                End With
                Dim col2 As New DataGridViewLinkColumn()
                With col2
                    .Name = "col2"
                    .HeaderText = "Student ID"
                    .Width = 150
                End With
                Dim col3 As New DataGridViewTextBoxColumn()
                With col3
                    .Name = "col3"
                    .HeaderText = "Student Name"
                    .Width = 350
                End With
                Dim col4 As New DataGridViewTextBoxColumn()
                With col4
                    .Name = "col4"
                    .HeaderText = "Course"
                    .Width = 255
                End With

                dgviewstudents.Columns.Add(col1)
                dgviewstudents.Columns.Add(col2)
                dgviewstudents.Columns.Add(col3)
                dgviewstudents.Columns.Add(col4)

                Dim i As Integer = 0
                cmd.CommandText = "select stuid,name,course from ExamStudents where examcode='" & examcode & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    dgviewstudents.Rows.Add()
                    dgviewstudents.Rows(i).Cells(0).Value = True
                    dgviewstudents.Rows(i).Cells(1).Value = dr("stuid").ToString()
                    dgviewstudents.Rows(i).Cells(2).Value = dr("name").ToString()
                    dgviewstudents.Rows(i).Cells(3).Value = dr("course").ToString()
                    i = i + 1
                End While
                dr.Close()
                dgviewstudents.ClearSelection()
                cmd.CommandText = ""
                dr = cmd.ExecuteReader
                While dr.Read()

                End While
                dr.Close()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadSelectedExamGuards(ByVal examcode As String)
        Try
            cmd.CommandText = "select guard from ExamGuard where examcode='" & examcode & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                lstvisitors.Items.Add(dr("guard").ToString())
            End While
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CheckExamID()
        Try
            cmd.CommandText = "select * from Examination where examcode='" & txtexamcode.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                ExamExist = True
            Else
                ExamExist = False
            End If
            dr.Close()
        Catch ex As Exception
            ExamExist = False
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmOnlineExamination_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updateexamination = False Then
            ControlSetBound()
            cmbexamfor.Items.Add(New ComboBoxIconItem("All Students", 0))
            cmbexamfor.Items.Add(New ComboBoxIconItem("Selected Student", 1))
            LoadCourse()
            LoadVisitors()
            LoadBranch()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            cmbexamfor.Items.Add(New ComboBoxIconItem("All Students", 0))
            cmbexamfor.Items.Add(New ComboBoxIconItem("Selected Student", 1))
            LoadCourse()
            LoadVisitors()
            LoadBranch()
            LoadSelectedExam()
        End If
        If USexamination = "View Only" Then
            btnadd.Enabled = False
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbbranch.Enabled = False
            cmbcourse.Enabled = False
            cmbexamcenter.Enabled = False
            cmbexamdate.Enabled = False
            cmbexamfor.Enabled = False
            cmbguard.Enabled = False
            cmbsubject.Enabled = False
            mskexamtime.ReadOnly = True
            txtexamcenter.ReadOnly = True
            txtexamcode.ReadOnly = True
            txtroomno.ReadOnly = True
            dgviewstudents.Enabled = False
        End If
    End Sub
#End Region
#Region "Attributes..."
    Private Sub cmbexamcenter_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbexamcenter.TextChanged
        If cmbexamcenter.SelectedText = "In House" Then
            txtexamcenter.Text = cmbexamcenter.Text
            Panel5.Visible = True
            lblroomenter.Visible = True
            lblroomno.Visible = True
            lblvisitors.Text = "Guard:"
            txtroomno.Visible = True
        ElseIf cmbexamcenter.Text = "Outside" Then
            txtexamcenter.Text = cmbexamcenter.Text
            Panel5.Visible = True
            lblroomenter.Visible = False
            lblroomno.Visible = False
            lblvisitors.Text = "Visitors:"
            txtroomno.Visible = False
        End If
    End Sub

    Private Sub cmbcourse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcourse.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbsubject.Focus()
        End If
    End Sub

    Private Sub cmbsubject_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbsubject.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbexamdate.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbcourse.Focus()
        End If
    End Sub

    Private Sub cmbexamdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbexamdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbbranch.Focus()
        End If
    End Sub

    Private Sub cmbbranch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbbranch.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbexamcenter.Focus()
        End If
    End Sub

    Private Sub cmbexamcenter_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbexamcenter.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbexamcenter.Text <> "" Then
                If cmbexamcenter.SelectedText = "In House" Then
                    txtexamcenter.Text = cmbexamcenter.Text
                    Panel5.Visible = True
                    lblroomenter.Visible = True
                    lblroomno.Visible = True
                    lblvisitors.Text = "Guard:"
                    txtroomno.Visible = True
                ElseIf cmbexamcenter.Text = "Outside" Then
                    txtexamcenter.Text = cmbexamcenter.Text
                    Panel5.Visible = True
                    lblroomenter.Visible = False
                    lblroomno.Visible = False
                    lblvisitors.Text = "Visitors:"
                    txtroomno.Visible = False
                End If
            End If
            cmbexamfor.Focus()
        End If
    End Sub

    Private Sub cmbexamfor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbexamfor.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtexamcenter.Focus()
        End If
    End Sub

    Private Sub txtexamcenter_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtexamcenter.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            mskexamtime.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbexamfor.Focus()
        End If
    End Sub

    Private Sub mskexamtime_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskexamtime.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtroomno.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtexamcenter.Focus()
        End If
    End Sub

    Private Sub txtroomno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtroomno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbguard.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            mskexamtime.Focus()
        End If
    End Sub

    Private Sub cmbguard_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbguard.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbguard.Text <> "" Then
                Dim sItemTemp As String
                sItemTemp = String.Format("{0},{1},{2}", EmpRegNo, EmpName, EmpDesignation)
                lstvisitors.Items.Add(sItemTemp)
            End If
        End If
    End Sub

    Private Sub DeleteOutsideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteOutsideToolStripMenuItem.Click
        Dim i As Integer = lstvisitors.SelectedIndex
        lstvisitors.Items.RemoveAt(i)
    End Sub

    Private Sub btnadd_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnadd.ClickButtonArea
        If cmbguard.Text <> "" Then
            Dim sItemTemp As String
            sItemTemp = String.Format("{0},{1},{2}", EmpRegNo, EmpName, EmpDesignation)
            lstvisitors.Items.Add(sItemTemp)
        End If
    End Sub

    Private Sub TextBoxTextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim x As ESAR_Controls.UIControls.TextBox.eTextBox = CType(sender, ESAR_Controls.UIControls.TextBox.eTextBox)
        ctc.ConvertTextBoxValidValue(x)
    End Sub

    Private Sub cmbcourse_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcourse.KeyPress, cmbexamcenter.KeyPress, cmbexamdate.KeyPress, cmbexamfor.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbexamfor_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbexamfor.TextChanged
        If cmbexamfor.Text = "Selected Student" Then
            LoadStudentsSelected()
        ElseIf cmbexamfor.Text = "All Students" Then
            LoadStudentsAll()
        Else
            dgviewstudents.Rows.Clear()
            dgviewstudents.Columns.Clear()
        End If
    End Sub

    Private Sub dgviewstudents_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgviewstudents.CellClick
        If e.ColumnIndex = 0 Then
            Dim row As Integer = dgviewstudents.CurrentRow.Index
            If dgviewstudents.Rows(row).Cells(0).Value = True Then
                dgviewstudents.Rows(row).Cells(0).Value = False
            Else
                dgviewstudents.Rows(row).Cells(0).Value = True
            End If
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updateexamination = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updateexamination = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updateexamination = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updateexamination = False Then
            ControlSetBound()
            cmbexamfor.Items.Add(New ComboBoxIconItem("All Students", 0))
            cmbexamfor.Items.Add(New ComboBoxIconItem("Selected Student", 1))
            LoadCourse()
            LoadVisitors()
            LoadBranch()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            cmbexamfor.Items.Add(New ComboBoxIconItem("All Students", 0))
            cmbexamfor.Items.Add(New ComboBoxIconItem("Selected Student", 1))
            LoadCourse()
            LoadVisitors()
            LoadBranch()
            LoadSelectedExam()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region