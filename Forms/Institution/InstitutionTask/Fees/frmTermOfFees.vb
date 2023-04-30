#Region "Class frmTermOfFees..."
Public Class frmTermOfFees
#Region "Declarations..."
    Private DGVCourse As New Windows.Forms.DataGridView()
    Private Exist As Boolean = False
    Private ccCourseCode As String = ""
    Private ccCourseName As String = ""
    Private ccCourseDuration As String = ""
#End Region
#Region "Button Menu..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        Try
            Dim cls As New cCourse()
            Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                AddUpdateRecord()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        Try
            Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                AddUpdateRecord()
                ResetForm()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        ControlSetBound()
        EGroupBox1.GroupTitle = "Course fees for the year: "
        EGroupBox1.GroupTitle += Date.Now.Year.ToString()
        Dim yy As Integer = Date.Now.Year
        nudfeesyear.Minimum = yy - 25
        nudfeesyear.Maximum = yy + 25
        nudfeesyear.Value = yy
        LoadCourse()
        LoadCourseFees()
        nudfeesmonth.Value = ISDFeesMonth
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmTermOfFees_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
        EGroupBox1.GroupTitle = "Course fees for the year: "
        EGroupBox1.GroupTitle += Date.Now.Year.ToString()
        Dim yy As Integer = Date.Now.Year
        nudfeesyear.Minimum = yy - 25
        nudfeesyear.Maximum = yy + 25
        nudfeesyear.Value = yy
        LoadCourse()
        LoadCourseFees()
        nudfeesmonth.Value = ISDFeesMonth
        If USfeesterms = "View Only" Then
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbcourse.Enabled = False
            dgviewcourse.Enabled = False
            dgviewfeesterms.Enabled = False
            nudfeesmonth.Enabled = False
            nudfeesyear.Enabled = False
        End If
    End Sub
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(0, 0, 47, 13)
        cmbcourse.SetBounds(47, 0, 133, 21)
        lnkaddterms.SetBounds(676, 0, 115, 25)
        Label2.SetBounds(180, 0, 38, 13)
        nudfeesyear.SetBounds(218, 0, 60, 21)
        Label3.SetBounds(278, 0, 126, 13)
        nudfeesmonth.SetBounds(404, 0, 60, 21)
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
            Dim col4 As New DataGridViewTextBoxColumn()
            With col4
                .Name = "Col4"
                .HeaderText = "Fees"
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
            DGVCourse.Columns.Add(col4)

            DGVCourse.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select CourseCode,CourseName,Duration,CourseFees from Course where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and year='" & nudfeesyear.Value.ToString() & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                DGVCourse.Rows.Add()

                DGVCourse.Rows(indx).Cells(0).Value = dr("CourseCode").ToString()
                DGVCourse.Rows(indx).Cells(1).Value = dr("CourseName").ToString()
                DGVCourse.Rows(indx).Cells(2).Value = dr("Duration").ToString()
                DGVCourse.Rows(indx).Cells(3).Value = dr("CourseFees").ToString()

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
            ccCourseCode = DGVCourse.Rows(k).Cells(0).Value.ToString()
            ccCourseName = DGVCourse.Rows(k).Cells(1).Value.ToString()
            ccCourseDuration = DGVCourse.Rows(k).Cells(2).Value.ToString()
            crsfees = CDec(DGVCourse.Rows(k).Cells(3).Value.ToString())
            cmbcourse.Text = ccCourseName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadCourseFees()
        Try
            dgviewcourse.Rows.Clear()
            Dim i As Integer = 0
            cmd.CommandText = "select CourseName,CourseCode,Duration,CourseFees from Course where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and year='" & nudfeesyear.Value.ToString() & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewcourse.Rows.Add()
                dgviewcourse.Rows(i).Cells(0).Value = dr("CourseName").ToString()
                dgviewcourse.Rows(i).Cells(1).Value = dr("CourseCode").ToString()
                dgviewcourse.Rows(i).Cells(2).Value = dr("Duration").ToString()
                dgviewcourse.Rows(i).Cells(3).Value = dr("CourseFees").ToString()
                Dim val As Decimal = CDec(dgviewcourse.Rows(i).Cells(3).Value.ToString())
                If val = 0.0 And dgviewcourse.Rows(i).Cells(0).Value.ToString = "" Then
                    dgviewcourse.Rows(i).Cells(3).Value = "0.00"
                Else
                    dgviewcourse.Rows(i).Cells(3).Value = FormatNumber(val.ToString())
                End If
                i = i + 1
                dgviewcourse.ClearSelection()
            End While
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadFeesTerms()
        Try
            If cmbcourse.Text <> "" Then
                Dim i As Integer = 0
                cmd.CommandText = "select * from CourseTermFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Course='" & cmbcourse.Text & "' and year='" & nudfeesyear.Value.ToString() & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    dgviewfeesterms.Rows.Add()
                    dgviewfeesterms.Rows(i).Cells(0).Value = dr("Terms").ToString()
                    Dim fees As Decimal = CDec(dr("Fees").ToString())
                    dgviewfeesterms.Rows(i).Cells(1).Value = FormatNumber(fees.ToString())
                    nudfeesmonth.Value = CDec(dr("ForMonth").ToString())
                    i = i + 1
                End While
                dr.Close()
            End If
            dgviewfeesterms.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddUpdateRecord()
        Try
            Dim totalamt As Decimal = 0.0
            For i As Integer = 0 To dgviewfeesterms.Rows.Count - 1
                totalamt = totalamt + CDec(dgviewfeesterms.Rows(i).Cells(1).Value.ToString())
            Next
            Dim year As String = Date.Now.Year.ToString()
            cmd.CommandText = "update Course set CourseFees=" & totalamt & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & My.Settings.Period & "' and year='" & nudfeesyear.Value.ToString() & "' and CourseName='" & cmbcourse.Text & "' and CourseCode='" & ccCourseCode & "'"
            dr = cmd.ExecuteReader
            dr.Close()

            For i As Integer = 0 To dgviewfeesterms.Rows.Count - 1
                Dim course As String = cmbcourse.Text
                Dim terms As String = dgviewfeesterms.Rows(i).Cells(0).Value.ToString()
                Dim fees As Decimal = CDec(dgviewfeesterms.Rows(i).Cells(1).Value.ToString())
                cmd.CommandText = "update CourseTermFees set Fees=" & fees & ",ForMonth=" & nudfeesmonth.Value.ToString() & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and year='" & nudfeesyear.Value.ToString() & "' and Course='" & course & "' and Terms='" & terms & "'"
                dr = cmd.ExecuteReader
                dr.Close()
            Next

            Dim result1 As DialogResult = MessageBox.Show("Record added/updated successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If result1 = Windows.Forms.DialogResult.OK Then
                LoadCourseFees()
                ETabControl1.SelectTab(TabPage1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RefreshForm()
        ControlSetBound()
        EGroupBox1.GroupTitle = "Course fees for the year: "
        EGroupBox1.GroupTitle += Date.Now.Year.ToString()
        Dim yy As Integer = Date.Now.Year
        nudfeesyear.Minimum = yy - 25
        nudfeesyear.Maximum = yy + 25
        nudfeesyear.Value = yy
        LoadCourse()
        LoadCourseFees()
        nudfeesmonth.Value = ISDFeesMonth
        If ISDApplyDiscount = "No" Then
            ETabControl1.TabPages.Remove(TabPage2)
        End If
    End Sub

    Private Sub ResetForm()
        Try
            cmbcourse.Text = ""
            dgviewfeesterms.Rows.Clear()
            dgviewcourse.Rows.Clear()
            EGroupBox1.GroupTitle = "Course fees for the year: "
            EGroupBox1.GroupTitle += Date.Now.Year.ToString()
            nudfeesmonth.Value = 12
            Dim yy As Integer = Date.Now.Year
            nudfeesyear.Minimum = yy - 25
            nudfeesyear.Maximum = yy + 25
            nudfeesyear.Value = yy
            LoadCourse()
            LoadCourseFees()
            ETabControl1.SelectTab(TabPage1)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Attributes..."
    Private Sub lnkaddterms_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        dgviewfeesterms.Rows.Add()
    End Sub

    Private Sub cmbcourse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcourse.KeyDown
        If (e.KeyCode) = Keys.Enter Then
            If cmbcourse.Text <> "" Then
                LoadFeesTerms()
            End If
            nudfeesyear.Focus()
        End If
    End Sub

    Private Sub cmbcourse_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbcourse.TextChanged
        If cmbcourse.Text <> "" Then
            LoadFeesTerms()
        Else
            dgviewfeesterms.Rows.Clear()
        End If
    End Sub

    Private Sub nudfeesyear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudfeesyear.KeyDown
        If e.KeyCode = Keys.Enter Then
            EGroupBox1.GroupTitle = "Course fees for the year: "
            EGroupBox1.GroupTitle += Date.Now.ToString()
            LoadCourse()
            LoadCourseFees()
            nudfeesmonth.Focus()
        End If
    End Sub
#End Region
#Region "DGViewEvents..."
    Private Sub dgviewfeesterms_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgviewfeesterms.CellEndEdit
        If e.ColumnIndex = 1 Then
            Dim i As Integer = dgviewfeesterms.CurrentRow.Index
            Dim val As Decimal = CDec(dgviewfeesterms.Rows(i).Cells(1).Value.ToString())
            dgviewfeesterms.Rows(i).Cells(1).Value = FormatNumber(val.ToString())
        End If
    End Sub
#End Region
End Class
#End Region