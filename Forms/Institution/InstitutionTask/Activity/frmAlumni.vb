#Region "Class frmAlumni..."
Public Class frmAlumni
#Region "Declarations..."
    Private DGVCourse As New Windows.Forms.DataGridView()
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(32, 26, 166, 13)
        Label2.SetBounds(269, 26, 18, 13)
        Label3.SetBounds(407, 26, 175, 13)
        Label4.SetBounds(22, 18, 52, 13)
        Label5.SetBounds(333, 18, 24, 13)

        nudfrom.SetBounds(203, 24, 60, 21)
        nudto.SetBounds(293, 24, 60, 21)

        cmbcourse.SetBounds(588, 23, 181, 21)
        cmbsearch.SetBounds(363, 14, 121, 21)

        txtsearch.SetBounds(85, 14, 244, 21)

        btnsearch.SetBounds(490, 12, 79, 25)
        btnclear.SetBounds(575, 12, 67, 25)
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
            crsduration = DGVCourse.Rows(k).Cells(2).Value.ToString()
            cmbcourse.Text = crsname
            LoadDataGrid(cmbcourse.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadDataGrid(ByVal course As String)
        Try
            Dim i As Integer = 0
            dgviewregistration.Rows.Clear()
            cmd.CommandText = "select stuid,name,course,roll from Alumni where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and course='" & cmbcourse.Text & "' and year between " & CInt(nudfrom.Value.ToString()) & " and " & CInt(nudto.Value.ToString()) & ""
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewregistration.Rows.Add()
                dgviewregistration.Rows(i).Cells(0).Value = dr("stuid").ToString()
                dgviewregistration.Rows(i).Cells(1).Value = dr("name").ToString()
                dgviewregistration.Rows(i).Cells(2).Value = dr("course").ToString()
                dgviewregistration.Rows(i).Cells(3).Value = dr("roll").ToString()
                i = i + 1
            End While
            dr.Close()
            dgviewregistration.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub MoveToRegistration()
        Try
            Dim result As DialogResult = MessageBox.Show("Are you sure want to move this record to alumni?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                Dim cls As New cAlumni()
                Dim i As Integer = dgviewregistration.CurrentRow.Index
                Dim regno As String = dgviewregistration.Rows(i).Cells(0).Value.ToString()
                Dim name As String = dgviewregistration.Rows(i).Cells(1).Value.ToString()
                Dim alumniyear As Integer = Date.Now.Year
                cls.DeleteRecord(regno, name)
                If cls.DeleteRecordOk = True Then
                    Dim result1 As DialogResult = MessageBox.Show("Record added successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If result1 = Windows.Forms.DialogResult.OK Then
                        LoadDataGrid(cmbcourse.Text)
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmAlumni_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
        Dim yy As Integer = Date.Now.Year
        nudfrom.Maximum = yy + 100
        nudfrom.Minimum = yy - 100
        nudto.Maximum = yy + 55
        nudto.Minimum = yy - 95
        nudfrom.Value = yy - 5
        nudto.Value = yy
        LoadCourse()
        If USalumni = "View Only" Then
            btndelete.Enabled = False
            cmbcourse.Enabled = False
            dgviewregistration.Enabled = False
            nudfrom.Enabled = False
            nudto.Enabled = False
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        MoveToRegistration()
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        ControlSetBound()
        Dim yy As Integer = Date.Now.Year
        nudfrom.Maximum = yy + 100
        nudfrom.Minimum = yy - 100
        nudto.Maximum = yy + 55
        nudto.Minimum = yy - 95
        nudfrom.Value = yy - 5
        nudto.Value = yy
        LoadCourse()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Search..."
    Private Sub SearchRecord()
        Try
            If txtsearch.Text <> "" Then
                If cmbsearch.Text = "Registration ID" Then
                    Dim i As Integer
                    dgviewregistration.ClearSelection()
                    For i = 0 To dgviewregistration.Rows.Count - 1
                        If dgviewregistration.Rows(i).Cells(0).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewregistration.Rows(i).Selected = True
                            dgviewregistration.CurrentCell = dgviewregistration.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Name" Then
                    Dim i As Integer
                    dgviewregistration.ClearSelection()
                    For i = 0 To dgviewregistration.Rows.Count - 1
                        If dgviewregistration.Rows(i).Cells(1).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewregistration.Rows(i).Selected = True
                            dgviewregistration.CurrentCell = dgviewregistration.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Course" Then
                    Dim i As Integer
                    dgviewregistration.ClearSelection()
                    For i = 0 To dgviewregistration.Rows.Count - 1
                        If dgviewregistration.Rows(i).Cells(2).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewregistration.Rows(i).Selected = True
                            dgviewregistration.CurrentCell = dgviewregistration.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Roll" Then
                    Dim i As Integer
                    dgviewregistration.ClearSelection()
                    For i = 0 To dgviewregistration.Rows.Count - 1
                        If dgviewregistration.Rows(i).Cells(3).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewregistration.Rows(i).Selected = True
                            dgviewregistration.CurrentCell = dgviewregistration.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Please enter search text!!!", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtsearch.Focus()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Try
            SearchRecord()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnclear_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnclear.ClickButtonArea
        txtsearch.Text = ""
        cmbsearch.Text = ""
        txtsearch.Focus()
    End Sub

    Private Sub cmbsearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnsearch.Focus()
        End If
    End Sub

    Private Sub txtsearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            cmbsearch.Focus()
        End If
    End Sub
#End Region
#Region "ContextMenuStrip Event..."
    Private Sub MoveThisRecordToStudentRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveThisRecordToStudentRegistrationToolStripMenuItem.Click
        MoveToRegistration()
    End Sub
#End Region
#Region "Attributes..."
    Private Sub nudfrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudfrom.KeyDown
        If e.KeyCode = Keys.Enter Then
            nudto.Focus()
        End If
    End Sub

    Private Sub nudto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudto.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbcourse.Focus()
        End If
    End Sub

    Private Sub nudfrom_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudfrom.ValueChanged
        If cmbcourse.Text <> "" Then
            LoadDataGrid(cmbcourse.Text)
        End If
    End Sub

    Private Sub nudto_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudto.ValueChanged
        If cmbcourse.Text <> "" Then
            LoadDataGrid(cmbcourse.Text)
        End If
    End Sub
#End Region
End Class
#End Region
