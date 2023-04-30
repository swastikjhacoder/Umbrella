#Region "Class frmCourseSubjects..."
Public Class frmSubjects
#Region "Declarations..."
    Private DGVCourse As New Windows.Forms.DataGridView()
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label10.SetBounds(16, 90, 37, 13)
        Label11.SetBounds(270, 63, 42, 13)
        Label12.SetBounds(148, 63, 34, 13)
        Label13.SetBounds(16, 63, 61, 13)
        Label14.SetBounds(16, 36, 55, 13)
        Label2.SetBounds(19, 36, 92, 13)
        Label3.SetBounds(19, 63, 55, 13)
        Label4.SetBounds(151, 63, 61, 13)
        Label5.SetBounds(249, 63, 34, 13)
        Label6.SetBounds(19, 21, 92, 13)
        Label7.SetBounds(19, 90, 37, 13)
        Label8.SetBounds(249, 90, 63, 13)
        Label9.SetBounds(246, 90, 63, 13)

        chkpractical.SetBounds(251, 20, 171, 17)

        txtgeneralsubject.SetBounds(85, 33, 296, 21)
        txtgeneralduration.SetBounds(85, 60, 60, 21)
        txtgeneralsubjectcode.SetBounds(321, 60, 60, 21)
        txtpracsubjectcode.SetBounds(318, 60, 60, 21)
        txtpracduration.SetBounds(82, 60, 60, 21)
        txtpracsubject.SetBounds(82, 33, 296, 21)

        nudgenealyear.SetBounds(85, 87, 60, 21)
        cmbgeneralsemestar.SetBounds(321, 87, 60, 21)
        cmbpracsemestar.SetBounds(318, 87, 60, 21)
        nudpracyear.SetBounds(82, 87, 60, 21)
        cmbcourse.SetBounds(117, 18, 121, 21)
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

    Private Sub ResetForm()
        updatesubject = False
        cmbcourse.Text = ""
        chkpractical.Checked = False
        cmbgeneralsemestar.Text = ""
        cmbpracsemestar.Text = ""
        txtgeneralduration.Text = ""
        txtgeneralsubject.Text = ""
        txtgeneralsubjectcode.Text = ""
        txtpracduration.Text = ""
        txtpracsubject.Text = ""
        txtpracsubjectcode.Text = ""
        Dim yy As Integer = Date.Now.Year
        nudgenealyear.Maximum = yy + 50
        nudgenealyear.Minimum = yy - 50
        nudpracyear.Maximum = yy + 50
        nudpracyear.Minimum = yy - 50
        nudgenealyear.Value = yy
        nudpracyear.Value = yy
        cmbcourse.Focus()
    End Sub

    Private Sub AddRecord()
        Try
            If cmbcourse.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter course.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbcourse.Focus()
                End If
            ElseIf txtgeneralsubject.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please subject.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtgeneralsubject.Focus()
                End If
            ElseIf txtgeneralduration.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please subject duration.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtgeneralduration.Focus()
                End If
            ElseIf txtgeneralsubjectcode.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter subject code.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtgeneralsubjectcode.Focus()
                End If
            ElseIf cmbgeneralsemestar.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter semestar.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbgeneralsemestar.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", " Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cCourse()
                    Dim haspractical As String = ""
                    If chkpractical.Checked = True Then
                        haspractical = "Yes"
                    Else
                        haspractical = "No"
                        txtpracduration.Text = ""
                        txtpracsubject.Text = ""
                        txtpracsubjectcode.Text = ""
                        nudpracyear.Value = Date.Now.Year
                        cmbpracsemestar.Text = ""
                    End If
                    Dim pracsubject As String = txtpracsubject.Text
                    Dim pracduration As String = txtpracduration.Text
                    Dim pracsubjectcode As String = txtpracsubjectcode.Text
                    Dim pracsubjectyear As Integer
                    If chkpractical.Checked = True Then
                        pracsubjectyear = CInt(nudpracyear.Value.ToString())
                    Else
                        pracsubjectyear = 0
                    End If
                    Dim pracsemestar As String = cmbpracsemestar.Text
                    cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, cmbcourse.Text, crscode, haspractical, txtgeneralsubject.Text, txtgeneralduration.Text, txtgeneralsubjectcode.Text, CInt(nudgenealyear.Value.ToString()), cmbgeneralsemestar.Text, pracsubject, pracduration, pracsubjectcode, pracsubjectyear, pracsemestar)
                    If cls.AddSubjectOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record added successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
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
            ElseIf txtgeneralsubject.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please subject.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtgeneralsubject.Focus()
                End If
            ElseIf txtgeneralduration.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please subject duration.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtgeneralduration.Focus()
                End If
            ElseIf txtgeneralsubjectcode.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter subject code.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtgeneralsubjectcode.Focus()
                End If
            ElseIf cmbgeneralsemestar.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please semestar.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbgeneralsemestar.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", " Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cCourse()
                    Dim haspractical As String = ""
                    If chkpractical.Checked = True Then
                        haspractical = "Yes"
                    Else
                        haspractical = "No"
                        txtpracduration.Text = ""
                        txtpracsubject.Text = ""
                        txtpracsubjectcode.Text = ""
                        nudpracyear.Value = Date.Now.Year
                        cmbpracsemestar.Text = ""
                    End If
                    Dim pracsubject As String = txtpracsubject.Text
                    Dim pracduration As String = txtpracduration.Text
                    Dim pracsubjectcode As String = txtpracsubjectcode.Text
                    Dim pracsubjectyear As Integer
                    If chkpractical.Checked = True Then
                        pracsubjectyear = CInt(nudpracyear.Value.ToString())
                    Else
                        pracsubjectyear = 0
                    End If
                    Dim pracsemestar As String = cmbpracsemestar.Text
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, cmbcourse.Text, crscode, haspractical, txtgeneralsubject.Text, txtgeneralduration.Text, txtgeneralsubjectcode.Text, CInt(nudgenealyear.Value.ToString()), cmbgeneralsemestar.Text, pracsubject, pracduration, pracsubjectcode, pracsubjectyear, pracsemestar)
                    If cls.UpdateSubjectOk = True Then
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
            If cmbcourse.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter course.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbcourse.Focus()
                End If
            ElseIf txtgeneralsubject.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please subject.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtgeneralsubject.Focus()
                End If
            ElseIf txtgeneralsubjectcode.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter subject code.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtgeneralsubjectcode.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", " Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cCourse()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, cmbcourse.Text, crscode, txtgeneralsubjectcode.Text)
                    If cls.DeleteSubjectOk = True Then
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
            cmd.CommandText = "select * from Subjects where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and gensubjectcode='" & subjectcode & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                cmbcourse.Text = dr("course").ToString()
                If dr("haspractical").ToString() = "Yes" Then
                    chkpractical.Checked = True
                Else
                    chkpractical.Checked = False
                End If
                txtgeneralsubject.Text = dr("gensubject").ToString()
                txtgeneralduration.Text = dr("gensubjectduration").ToString()
                txtgeneralsubjectcode.Text = dr("gensubjectcode").ToString()
                nudgenealyear.Value = CInt(dr("gensubjectyear").ToString())
                cmbgeneralsemestar.Text = dr("gensubjectsemestar").ToString()
                txtpracsubject.Text = dr("pracsubject").ToString()
                txtpracduration.Text = dr("pracsubjectduration").ToString()
                txtpracsubjectcode.Text = dr("pracsubjectcode").ToString()
                nudpracyear.Value = CInt(dr("pracsubjectyear").ToString())
                cmbpracsemestar.Text = dr("pracsubjectsemestar").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmCourseSubjects_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
        LoadCourse()
        Dim yy As Integer = Date.Now.Year
        nudgenealyear.Maximum = yy + 50
        nudgenealyear.Minimum = yy - 50
        nudpracyear.Maximum = yy + 50
        nudpracyear.Minimum = yy - 50
        nudgenealyear.Value = yy
        nudpracyear.Value = yy
        If updatesubject = True Then
            LoadSelectedRecord()
        End If
        If UScoursesubject = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbcourse.Enabled = False
            cmbgeneralsemestar.Enabled = False
            cmbpracsemestar.Enabled = False
            txtgeneralduration.ReadOnly = True
            txtgeneralsubject.ReadOnly = True
            txtgeneralsubjectcode.ReadOnly = True
            txtpracduration.ReadOnly = True
            txtpracsubject.ReadOnly = True
            txtpracsubjectcode.ReadOnly = True
            chkpractical.Enabled = False
            nudgenealyear.Enabled = False
            nudpracyear.Enabled = False
        End If
    End Sub
#End Region
#Region "Attributes..."
    Private Sub chkpractical_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkpractical.CheckedChanged
        If chkpractical.Checked = False Then
            SplitContainer1.Panel2Collapsed = True
        Else
            SplitContainer1.Panel2Collapsed = False
        End If
    End Sub

    Private Sub chkpractical_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkpractical.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtgeneralsubject.Focus()
        End If
    End Sub

    Private Sub cmbcourse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcourse.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtgeneralsubject.Focus()
        End If
    End Sub

    Private Sub txtgeneralsubject_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtgeneralsubject.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtgeneralduration.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbcourse.Focus()
        End If
    End Sub

    Private Sub txtgeneralduration_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtgeneralduration.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtgeneralsubjectcode.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtgeneralsubject.Focus()
        End If
    End Sub

    Private Sub txtgeneralsubjectcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtgeneralsubjectcode.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            nudgenealyear.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtgeneralduration.Focus()
        End If
    End Sub

    Private Sub nudgenealyear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudgenealyear.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbgeneralsemestar.Focus()
        End If
    End Sub

    Private Sub cmbgeneralsemestar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbgeneralsemestar.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chkpractical.Checked = True Then
                txtpracsubject.Focus()
            End If
        End If
    End Sub

    Private Sub txtpracsubject_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpracsubject.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtpracduration.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbgeneralsemestar.Focus()
        End If
    End Sub

    Private Sub txtpracduration_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpracduration.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtpracsubjectcode.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtpracsubject.Focus()
        End If
    End Sub

    Private Sub txtpracsubjectcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpracsubjectcode.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            nudpracyear.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtpracduration.Focus()
        End If
    End Sub

    Private Sub nudpracyear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudpracyear.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbpracsemestar.Focus()
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatesubject = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatesubject = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatesubject = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        ControlSetBound()
        LoadCourse()
        If updatesubject = True Then
            LoadSelectedRecord()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region