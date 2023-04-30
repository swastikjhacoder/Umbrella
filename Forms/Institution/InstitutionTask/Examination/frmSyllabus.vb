#Region "Class frmSyllabus..."
Public Class frmSyllabus
#Region "Declarations..."
    Private DGVCourse As New Windows.Forms.DataGridView()
    Private DGVSubject As New Windows.Forms.DataGridView()
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label2.SetBounds(261, 19, 94, 13)
        Label3.SetBounds(19, 46, 58, 13)
        Label4.SetBounds(19, 73, 101, 13)
        Label5.SetBounds(488, 19, 156, 13)
        Label6.SetBounds(19, 19, 92, 13)
        Label7.SetBounds(488, 73, 101, 13)
        Label8.SetBounds(681, 73, 43, 13)
        Label9.SetBounds(512, 46, 77, 13)
        Label10.SetBounds(654, 46, 74, 13)

        cmbstudent.SetBounds(650, 16, 134, 21)
        cmbcourse.SetBounds(126, 16, 121, 21)
        cmbsubject.SetBounds(361, 16, 121, 21)

        txtchapter.SetBounds(126, 43, 356, 21)
        txttotalmarks.SetBounds(594, 43, 54, 21)
        txttotalclass.SetBounds(730, 43, 54, 21)
        txtclass.SetBounds(730, 70, 54, 21)
        txtmarksobtained.SetBounds(594, 70, 54, 21)
        txtchapterdetails.SetBounds(126, 70, 356, 21)
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

    Private Sub LoadDataGrid()
        Try
            Dim i As Integer = 0
            dgviewsyllabus.Rows.Clear()
            cmd.CommandText = "select course,subject,chapter from Syllabus where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewsyllabus.Rows.Add()
                dgviewsyllabus.Rows(i).Cells(0).Value = dr("course").ToString()
                dgviewsyllabus.Rows(i).Cells(1).Value = dr("subject").ToString()
                dgviewsyllabus.Rows(i).Cells(2).Value = dr("chapter").ToString()
                i = i + 1
            End While
            dr.Close()
            dgviewsyllabus.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetForm()
        updatesyllabus = False
        cmbcourse.Text = ""
        cmbstudent.Text = ""
        cmbsubject.Text = ""
        txtchapter.Text = ""
        txtchapterdetails.Text = ""
        txtclass.Text = ""
        txtmarksobtained.Text = ""
        txttotalclass.Text = ""
        txttotalmarks.Text = ""
        cmbcourse.Focus()
    End Sub

    Private Sub AddRecord()
        Try
            If cmbcourse.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter course.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbcourse.Focus()
                End If
            ElseIf cmbsubject.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter subject.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbsubject.Focus()
                End If
            ElseIf cmbstudent.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter for student.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbstudent.Focus()
                End If
            ElseIf txtchapter.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter chapter.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtchapter.Focus()
                End If
            ElseIf txtchapterdetails.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter chapter details.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtchapterdetails.Focus()
                End If
            ElseIf txttotalclass.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter total class.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txttotalclass.Focus()
                End If
            ElseIf txttotalmarks.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter total marks.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txttotalmarks.Focus()
                End If
            ElseIf txtclass.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter class.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtclass.Focus()
                End If
            ElseIf txtmarksobtained.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter marks obtained.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtmarksobtained.Focus()
                End If
            Else
                Dim res As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If res = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cSyllabus()
                    cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbcourse.Text, crscode, cmbsubject.Text, subjectcode, cmbstudent.Text, txtchapter.Text, txtchapterdetails.Text, CInt(txttotalmarks.Text), CInt(txtmarksobtained.Text), CInt(txttotalclass.Text), CInt(txtclass.Text))
                    If cls.AddOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record added successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            LoadDataGrid()
                            cmbcourse.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If cmbcourse.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter course.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbcourse.Focus()
                End If
            ElseIf cmbsubject.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter subject.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbsubject.Focus()
                End If
            ElseIf cmbstudent.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter for student.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbstudent.Focus()
                End If
            ElseIf txtchapter.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter chapter.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtchapter.Focus()
                End If
            ElseIf txtchapterdetails.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter chapter details.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtchapterdetails.Focus()
                End If
            ElseIf txttotalclass.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter total class.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txttotalclass.Focus()
                End If
            ElseIf txttotalmarks.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter total marks.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txttotalmarks.Focus()
                End If
            ElseIf txtclass.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter class.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtclass.Focus()
                End If
            ElseIf txtmarksobtained.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter marks obtained.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtmarksobtained.Focus()
                End If
            Else
                Dim res As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If res = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cSyllabus()
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbcourse.Text, cmbsubject.Text, cmbstudent.Text, txtchapter.Text, txtchapterdetails.Text, CInt(txttotalmarks.Text), CInt(txtmarksobtained.Text), CInt(txttotalclass.Text), CInt(txtclass.Text))
                    If cls.UpdateOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
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
            If cmbcourse.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter course.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbcourse.Focus()
                End If
            ElseIf cmbsubject.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter subject.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbsubject.Focus()
                End If
            ElseIf cmbstudent.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter for student.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbstudent.Focus()
                End If
            ElseIf txtchapter.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter chapter.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtchapter.Focus()
                End If
            ElseIf txtchapterdetails.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter chapter details.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtchapterdetails.Focus()
                End If
            ElseIf txttotalclass.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter total class.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txttotalclass.Focus()
                End If
            ElseIf txttotalmarks.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter total marks.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txttotalmarks.Focus()
                End If
            ElseIf txtclass.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter class.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtclass.Focus()
                End If
            ElseIf txtmarksobtained.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter marks obtained.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtmarksobtained.Focus()
                End If
            Else
                Dim res As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If res = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cSyllabus()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbcourse.Text, cmbsubject.Text)
                    If cls.DeleteOk = True Then
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
            cmd.CommandText = "select * from Syllabus where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and course='" & crsname & "' and subject='" & subject & "' and chapter='" & chapter & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                cmbcourse.Text = dr("course").ToString()
                cmbsubject.Text = dr("subject").ToString()
                cmbstudent.Text = dr("forstudent").ToString()
                txtchapter.Text = dr("chapter").ToString()
                txtchapterdetails.Text = dr("chapterdetails").ToString()
                txttotalmarks.Text = dr("totalmarks").ToString()
                txtmarksobtained.Text = dr("marksobtained").ToString()
                txttotalclass.Text = dr("totalclass").ToString()
                txtclass.Text = dr("class").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmSyllabus_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
        LoadCourse()
        LoadSubject()
        LoadDataGrid()
        If updatesyllabus = True Then
            LoadSelectedRecord()
        End If
        If UScoursesubject = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbcourse.Enabled = False
            cmbstudent.Enabled = False
            cmbsubject.Enabled = False
            txtchapter.ReadOnly = True
            txtchapterdetails.ReadOnly = True
            txtclass.ReadOnly = True
            txtmarksobtained.ReadOnly = True
            txttotalclass.ReadOnly = True
            txttotalmarks.ReadOnly = True
            dgviewsyllabus.Enabled = False
        End If
    End Sub
#End Region
#Region "Attributes..."
    Private Sub cmbcourse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcourse.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbsubject.Focus()
        End If
    End Sub

    Private Sub cmbsubject_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbsubject.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbstudent.Focus()
        End If
    End Sub

    Private Sub cmbstudent_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbstudent.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtchapter.Focus()
        End If
    End Sub

    Private Sub txtchapter_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtchapter.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtchapterdetails.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbstudent.Focus()
        End If
    End Sub

    Private Sub txtchapterdetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtchapterdetails.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txttotalmarks.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtchapter.Focus()
        End If
    End Sub

    Private Sub txttotalmarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttotalmarks.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtmarksobtained.Focus()
        ElseIf e.KeyCode = Keys.Up Then

        End If
    End Sub

    Private Sub txtmarksobtained_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmarksobtained.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txttotalclass.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txttotalmarks.Focus()
        End If
    End Sub

    Private Sub txttotalclass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttotalclass.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtclass.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtmarksobtained.Focus()
        End If
    End Sub

    Private Sub txtclass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtclass.KeyDown
        If e.KeyCode = Keys.Up Then
            txttotalclass.Focus()
        End If
    End Sub

    Private Sub ComboBoxKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcourse.KeyPress, cmbstudent.KeyPress, cmbsubject.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtchapter.TextChanged, txtchapterdetails.TextChanged
        Dim x As TextBox = CType(sender, TextBox)
        ctc.ConvertTextBoxValidValue(x)
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatesyllabus = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatesyllabus = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatesyllabus = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        ControlSetBound()
        LoadCourse()
        LoadSubject()
        LoadDataGrid()
        If updatesyllabus = True Then
            LoadSelectedRecord()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region