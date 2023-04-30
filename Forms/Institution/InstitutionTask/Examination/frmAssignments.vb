#Region "Class frmAssignments..."
Public Class frmAssignments
#Region "Declarations..."
    Private ACODE As String = ""
    Private TT As String = ""
    Private ofd As New OpenFileDialog()
    Private DGVCourse As New Windows.Forms.DataGridView()
    Private DGVSubject As New Windows.Forms.DataGridView()
    Private AssignmentExist As Boolean = False
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        ACODE = Indx.LoadAdmissionID()
        Dim var As String
        var = CodeIncrement(ACODE)
        Me.txtassignmentid.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("ASM:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        btnselect.SetBounds(496, 66, 155, 25)

        Label2.SetBounds(23, 18, 96, 13)
        Label3.SetBounds(320, 18, 39, 13)
        Label6.SetBounds(23, 45, 92, 13)
        Label4.SetBounds(265, 45, 94, 13)
        Label5.SetBounds(23, 72, 84, 13)

        txtassignmentid.SetBounds(125, 15, 130, 21)
        txtassignment.SetBounds(125, 69, 365, 21)

        cmbdate.SetBounds(360, 15, 130, 21)
        cmbcourse.SetBounds(125, 42, 130, 21)
        cmbsubject.SetBounds(360, 42, 130, 21)
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
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSubject()
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .Name = "Col1"
                .HeaderText = "Subject Code"
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .Name = "Col2"
                .HeaderText = "Subject"
            End With
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .Name = "Col3"
                .HeaderText = "Course"
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
            DGVSubject.Columns.Add(col3)

            DGVSubject.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select gensubjectcode,gensubject,course from Subjects where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVSubject.Rows.Add()
                DGVSubject.Rows(indx).Cells(0).Value = dr("gensubjectcode").ToString()
                DGVSubject.Rows(indx).Cells(1).Value = dr("gensubject").ToString()
                DGVSubject.Rows(indx).Cells(2).Value = dr("course").ToString()

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

    Private Sub ResetForm()
        updateassignment = False
        cmbcourse.Text = ""
        cmbdate.Text = UmbrellaSystemDate
        cmbsubject.Text = ""
        txtassignment.Text = ""
        If ISDAutoID = "Yes" Then
            GetCode()
        Else
            txtassignmentid.Text = ""
        End If
        cmbcourse.Focus()
    End Sub

    Private Sub AddRecord()
        Try
            If txtassignment.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please attach assignment.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtassignment.Focus()
                End If
            ElseIf txtassignmentid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter assignment id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtassignmentid.Focus()
                End If
            ElseIf cmbcourse.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter course.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbcourse.Focus()
                End If
            ElseIf cmbdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbdate.Focus()
                End If
            ElseIf cmbsubject.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter subject.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbsubject.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    CheckAssignmentID()
                    If AssignmentExist = False Then
                        Dim cls As New cAssignment()
                        cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtassignmentid.Text, cmbdate.Text, cmbcourse.Text, cmbsubject.Text, txtassignment.Text)
                        If cls.AddOk = True Then
                            SaveAttachedCopy(ofd.FileName.ToString())
                            Dim res As DialogResult = MessageBox.Show("Record added successfully", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If res = Windows.Forms.DialogResult.OK Then
                                LoadDataGrid()
                                cmbcourse.Focus()
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Assignment id already exist." + Environment.NewLine + "Please enter a new assignment id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            txtassignmentid.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If txtassignment.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please attach assignment.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtassignment.Focus()
                End If
            ElseIf txtassignmentid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter assignment id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtassignmentid.Focus()
                End If
            ElseIf cmbcourse.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter course.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbcourse.Focus()
                End If
            ElseIf cmbdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbdate.Focus()
                End If
            ElseIf cmbsubject.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter subject.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbsubject.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cAssignment()
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtassignmentid.Text, cmbdate.Text, cmbcourse.Text, cmbsubject.Text, txtassignment.Text)
                    If cls.UpdateOk = True Then
                        Dim res As DialogResult = MessageBox.Show("Record updated successfully", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If res = Windows.Forms.DialogResult.OK Then
                            LoadDataGrid()
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
            If txtassignmentid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter assignment id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtassignmentid.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cAssignment()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtassignmentid.Text)
                    If cls.DeleteOk = True Then
                        Dim res As DialogResult = MessageBox.Show("Record deleted successfully", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If res = Windows.Forms.DialogResult.OK Then
                            ResetForm()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadDataGrid()
        Try
            Dim i As Integer = 0
            dgviewassignments.Rows.Clear()
            cmd.CommandText = "select assignmentid,date,course,subject,assignment from Assignment where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewassignments.Rows.Add()
                dgviewassignments.Rows(i).Cells(0).Value = dr("assignmentid").ToString()
                dgviewassignments.Rows(i).Cells(1).Value = dr("date").ToString()
                dgviewassignments.Rows(i).Cells(2).Value = dr("course").ToString()
                dgviewassignments.Rows(i).Cells(3).Value = dr("subject").ToString()
                dgviewassignments.Rows(i).Cells(4).Value = dr("assignment").ToString()
                i = i + 1
            End While
            dr.Close()
            dgviewassignments.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadSelectedRecord()
        Try
            cmd.CommandText = "select assignmentid,date,course,subject,assignment from Assignment where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and assignmentid='" & assignmentid & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                txtassignment.Text = dr("assignment").ToString()
                txtassignmentid.Text = dr("assignmentid").ToString()
                cmbcourse.Text = dr("course").ToString()
                cmbdate.Text = dr("date").ToString()
                cmbsubject.Text = dr("subject").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Function FileNameWithoutPath(ByVal FullPath As String) As String
        Return System.IO.Path.GetFileName(FullPath).ToString
    End Function

    Private Sub AttachCopy()
        Try
            With ofd
                Try
                    .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                    .RestoreDirectory = True
                Catch ex As Exception
                    Exit Try
                End Try
                .Filter = "All Document Files|*.doc;*.docx;*.rtf;*.pdf;*.txt|" + "MS Word 2003 or before (MSWord File)|*.doc|MS Word 2007 or later (MSWord File)|*.docx|Rich Text Files (RTF File)|*.rtf|Adobe Acrobat Files (PDF Files)|*.pdf|Text Files (TXT Files)|*.txt"
            End With
            If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtassignment.Text = FileNameWithoutPath(ofd.FileName.ToString())
            End If
        Catch eX As Exception
            MessageBox.Show(eX.Message)
        Finally
            Cursor.Current = Cursors.Default()
        End Try
    End Sub

    Private Sub SaveAttachedCopy(ByVal FullPath As String)
        System.IO.File.Copy(ofd.FileName, AppDomain.CurrentDomain.BaseDirectory + System.IO.Path.GetFileName(ofd.FileName()))
        My.Computer.FileSystem.RenameFile(AppDomain.CurrentDomain.BaseDirectory + System.IO.Path.GetFileName(ofd.FileName()), cmbcourse.Text + cmbsubject.Text + System.IO.Path.GetFileName(FullPath).ToString())
    End Sub

    Private Sub CheckAssignmentID()
        Try
            cmd.CommandText = "select * from Assignment where assignmentid='" & txtassignmentid.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                AssignmentExist = True
            Else
                AssignmentExist = False
            End If
            dr.Close()
        Catch ex As Exception
            AssignmentExist = False
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmAssignments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updateassignment = False Then
            ControlSetBound()
            LoadDataGrid()
            LoadCourse()
            LoadSubject()
            cmbdate.Text = UmbrellaSystemDate
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadDataGrid()
            LoadCourse()
            LoadSubject()
            LoadSelectedRecord()
        End If
        If UScoursesubject = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            btnselect.Enabled = False
            cmbcourse.Enabled = False
            cmbdate.Enabled = False
            cmbsubject.Enabled = False
            txtassignment.ReadOnly = True
            txtassignmentid.ReadOnly = True
            dgviewassignments.Enabled = False
        End If
    End Sub
#End Region
#Region "Attributes..."
    Private Sub txtassignmentid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtassignmentid.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbdate.Focus()
        End If
    End Sub

    Private Sub cmbdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbcourse.Focus()
        End If
    End Sub

    Private Sub cmbcourse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcourse.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbsubject.Focus()
        End If
    End Sub

    Private Sub cmbsubject_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbsubject.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtassignment.Focus()
        End If
    End Sub

    Private Sub txtassignment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtassignment.KeyDown
        If e.KeyCode = Keys.Up Then
            cmbsubject.Focus()
        End If
    End Sub

    Private Sub ComboBoxKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcourse.KeyPress, cmbdate.KeyPress, cmbsubject.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnselect_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnselect.ClickButtonArea
        AttachCopy()
    End Sub

    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updateassignment = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updateassignment = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updateassignment = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updateassignment = False Then
            ControlSetBound()
            LoadDataGrid()
            LoadCourse()
            LoadSubject()
            cmbdate.Text = UmbrellaSystemDate
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadDataGrid()
            LoadCourse()
            LoadSubject()
            LoadSelectedRecord()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region