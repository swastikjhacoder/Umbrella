#Region "Class frmStaffAttendance..."
Public Class frmStaffAttendance
#Region "Methods..."
    Private Sub LoadDate()
        Dim today As Date = CDate(UmbrellaSystemDate)
        Dim dayIndex As Integer = today.DayOfWeek
        If dayIndex < DayOfWeek.Monday Then
            dayIndex += 7
        End If
        Dim dayDiff As Integer = dayIndex - DayOfWeek.Monday
        Dim monday As Date = today.AddDays(-dayDiff)
        Dim startdate As String = monday.ToShortDateString()
        Dim sunday As Date = monday.AddDays(6)
        Dim enddate As String = sunday.ToShortDateString()
        cmbdate.Text = startdate
    End Sub

    Private Sub CreateDataGridViewColumn()
        dgviewattendance.Rows.Clear()
        dgviewattendance.Columns.Clear()
        Dim monday As Date = CDate(cmbdate.Text)
        Dim tuesday As Date = monday.AddDays(1)
        Dim wednesday As Date = monday.AddDays(2)
        Dim thursday As Date = monday.AddDays(3)
        Dim friday As Date = monday.AddDays(4)
        Dim saturday As Date = monday.AddDays(5)
        Dim sunday As Date = monday.AddDays(6)
        Dim day1 As String = "Monday: " + monday.ToShortDateString()
        Dim day2 As String = "Tuesday: " + tuesday.ToShortDateString()
        Dim day3 As String = "Wednesday: " + wednesday.ToShortDateString()
        Dim day4 As String = "Thursday: " + thursday.ToShortDateString()
        Dim day5 As String = "Friday: " + friday.ToShortDateString()
        Dim day6 As String = "Saturday: " + saturday.ToShortDateString()
        Dim day7 As String = "Sunday: " + sunday.ToShortDateString()

        Dim col1 As New DataGridViewLinkColumn()
        With col1
            .Name = "col1"
            .HeaderText = "Registration No."
            .ReadOnly = True
            .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Info
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
        Dim col2 As New DataGridViewTextBoxColumn()
        With col2
            .Name = "col2"
            .HeaderText = "Employee Name"
            .ReadOnly = True
            .DefaultCellStyle.BackColor = Color.GhostWhite
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.SelectionBackColor = Color.GhostWhite
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
        dgviewattendance.Columns.Add(col1)
        dgviewattendance.Columns.Add(col2)

        Dim today As Date = Date.Today
        If today = monday Then
            Dim col3 As New DataGridViewComboBoxColumn()
            With col3
                .Name = "col3"
                .HeaderText = day1
                .ReadOnly = False
                .Items.Add("Present")
                .Items.Add("Absent")
            End With
            dgviewattendance.Columns.Add(col3)
        Else
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .Name = "col3"
                .HeaderText = day1
                .ReadOnly = True
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.SelectionForeColor = Color.Black
            End With
            dgviewattendance.Columns.Add(col3)
        End If
        If today = tuesday Then
            Dim col4 As New DataGridViewComboBoxColumn()
            With col4
                .Name = "col4"
                .HeaderText = day2
                .ReadOnly = False
                .Items.Add("Present")
                .Items.Add("Absent")
            End With
            dgviewattendance.Columns.Add(col4)
        Else
            Dim col4 As New DataGridViewTextBoxColumn()
            With col4
                .Name = "col4"
                .HeaderText = day2
                .ReadOnly = True
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.SelectionForeColor = Color.Black
            End With
            dgviewattendance.Columns.Add(col4)
        End If
        If today = wednesday Then
            Dim col5 As New DataGridViewComboBoxColumn()
            With col5
                .Name = "col5"
                .HeaderText = day3
                .ReadOnly = False
                .Items.Add("Present")
                .Items.Add("Absent")
            End With
            dgviewattendance.Columns.Add(col5)
        Else
            Dim col5 As New DataGridViewTextBoxColumn()
            With col5
                .Name = "col5"
                .HeaderText = day3
                .ReadOnly = True
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.SelectionForeColor = Color.Black
            End With
            dgviewattendance.Columns.Add(col5)
        End If
        If today = thursday Then
            Dim col6 As New DataGridViewComboBoxColumn()
            With col6
                .Name = "col6"
                .HeaderText = day4
                .ReadOnly = False
                .Items.Add("Present")
                .Items.Add("Absent")
            End With
            dgviewattendance.Columns.Add(col6)
        Else
            Dim col6 As New DataGridViewTextBoxColumn()
            With col6
                .Name = "col6"
                .HeaderText = day4
                .ReadOnly = True
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.SelectionForeColor = Color.Black
            End With
            dgviewattendance.Columns.Add(col6)
        End If
        If today = friday Then
            Dim col7 As New DataGridViewComboBoxColumn()
            With col7
                .Name = "col7"
                .HeaderText = day5
                .ReadOnly = False
                .Items.Add("Present")
                .Items.Add("Absent")
            End With
            dgviewattendance.Columns.Add(col7)
        Else
            Dim col7 As New DataGridViewTextBoxColumn()
            With col7
                .Name = "col7"
                .HeaderText = day5
                .ReadOnly = True
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.SelectionForeColor = Color.Black
            End With
            dgviewattendance.Columns.Add(col7)
        End If
        If today = saturday Then
            Dim col8 As New DataGridViewComboBoxColumn()
            With col8
                .Name = "col8"
                .HeaderText = day6
                .ReadOnly = False
                .Items.Add("Present")
                .Items.Add("Absent")
            End With
            dgviewattendance.Columns.Add(col8)
        Else
            Dim col8 As New DataGridViewTextBoxColumn()
            With col8
                .Name = "col8"
                .HeaderText = day6
                .ReadOnly = True
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.SelectionForeColor = Color.Black
            End With
            dgviewattendance.Columns.Add(col8)
        End If
        If today = sunday Then
            Dim col9 As New DataGridViewComboBoxColumn()
            With col9
                .Name = "col9"
                .HeaderText = day7
                .ReadOnly = False
                .Items.Add("Present")
                .Items.Add("Absent")
            End With
            dgviewattendance.Columns.Add(col9)
        Else
            Dim col9 As New DataGridViewTextBoxColumn()
            With col9
                .Name = "col9"
                .HeaderText = day7
                .ReadOnly = True
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.SelectionForeColor = Color.Black
            End With
            dgviewattendance.Columns.Add(col9)
        End If

    End Sub

    Private Sub LoadDataGrid()
        Try
            Dim i As Integer = 0
            dgviewattendance.Rows.Clear()
            cmd.CommandText = "select empid,name from Employee where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewattendance.Rows.Add()
                dgviewattendance.Rows(i).Cells(0).Value = dr("empid").ToString()
                dgviewattendance.Rows(i).Cells(1).Value = dr("name").ToString()
                i = i + 1
            End While
            dr.Close()
            dgviewattendance.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadAttendance()
        Try
            Dim row As Integer = dgviewattendance.Rows.Count
            For i As Integer = 0 To row - 1
                cmd.CommandText = "select * from EmployeeAttendance where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and empid='" & dgviewattendance.Rows(i).Cells(0).Value.ToString() & "' and name='" & dgviewattendance.Rows(i).Cells(1).Value.ToString() & "' and day1name='" & dgviewattendance.Columns(2).HeaderText & "'"
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    Dim day1 As String = dr("day1name").ToString()
                    Dim day2 As String = dr("day2name").ToString()
                    Dim day3 As String = dr("day3name").ToString()
                    Dim day4 As String = dr("day4name").ToString()
                    Dim day5 As String = dr("day5name").ToString()
                    Dim day6 As String = dr("day6name").ToString()
                    Dim day7 As String = dr("day7name").ToString()
                    If day1 = dgviewattendance.Columns(2).HeaderText Then
                        dgviewattendance.Rows(i).Cells(2).Value = dr("day1atten").ToString()
                        'dgviewattendance.Rows(i).Cells(2).ReadOnly = True
                    End If
                    If day2 = dgviewattendance.Columns(3).HeaderText Then
                        dgviewattendance.Rows(i).Cells(3).Value = dr("day2atten").ToString()
                        'dgviewattendance.Rows(i).Cells(3).ReadOnly = True
                    End If
                    If day3 = dgviewattendance.Columns(4).HeaderText Then
                        dgviewattendance.Rows(i).Cells(4).Value = dr("day3atten").ToString()
                        'dgviewattendance.Rows(i).Cells(4).ReadOnly = True
                    End If
                    If day4 = dgviewattendance.Columns(5).HeaderText Then
                        dgviewattendance.Rows(i).Cells(5).Value = dr("day4atten").ToString()
                        'dgviewattendance.Rows(i).Cells(5).ReadOnly = True
                    End If
                    If day5 = dgviewattendance.Columns(6).HeaderText Then
                        dgviewattendance.Rows(i).Cells(6).Value = dr("day5atten").ToString()
                        'dgviewattendance.Rows(i).Cells(6).ReadOnly = True
                    End If
                    If day6 = dgviewattendance.Columns(7).HeaderText Then
                        dgviewattendance.Rows(i).Cells(7).Value = dr("day6atten").ToString()
                        'dgviewattendance.Rows(i).Cells(7).ReadOnly = True
                    End If
                    If day7 = dgviewattendance.Columns(8).HeaderText Then
                        dgviewattendance.Rows(i).Cells(8).Value = dr("day7atten").ToString()
                        'dgviewattendance.Rows(i).Cells(8).ReadOnly = True
                    End If
                Else
                    dgviewattendance.Rows(i).Cells(2).Value = ""
                    dgviewattendance.Rows(i).Cells(3).Value = ""
                    dgviewattendance.Rows(i).Cells(4).Value = ""
                    dgviewattendance.Rows(i).Cells(5).Value = ""
                    dgviewattendance.Rows(i).Cells(6).Value = ""
                    dgviewattendance.Rows(i).Cells(7).Value = ""
                    dgviewattendance.Rows(i).Cells(8).Value = ""
                End If
                dr.Close()
            Next
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub SaveRecord()
        Try
            Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim cls As New cAttendance()
                For i As Integer = 0 To dgviewattendance.Rows.Count - 1
                    Dim InsID As String = My.Settings.LastOpenedInstituteID
                    Dim InsName As String = My.Settings.LastOpenedInstitute
                    Dim periodd As String = My.Settings.Period
                    Dim empid As String = dgviewattendance.Rows(i).Cells(0).Value.ToString()
                    Dim name As String = dgviewattendance.Rows(i).Cells(1).Value.ToString()
                    Dim day1name As String = dgviewattendance.Columns(2).HeaderText
                    Dim day2name As String = dgviewattendance.Columns(3).HeaderText
                    Dim day3name As String = dgviewattendance.Columns(4).HeaderText
                    Dim day4name As String = dgviewattendance.Columns(5).HeaderText
                    Dim day5name As String = dgviewattendance.Columns(6).HeaderText
                    Dim day6name As String = dgviewattendance.Columns(7).HeaderText
                    Dim day7name As String = dgviewattendance.Columns(8).HeaderText
                    Dim day1atten As String = dgviewattendance.Rows(i).Cells(2).Value.ToString()
                    Dim day2atten As String = dgviewattendance.Rows(i).Cells(3).Value.ToString()
                    Dim day3atten As String = dgviewattendance.Rows(i).Cells(4).Value.ToString()
                    Dim day4atten As String = dgviewattendance.Rows(i).Cells(5).Value.ToString()
                    Dim day5atten As String = dgviewattendance.Rows(i).Cells(6).Value.ToString()
                    Dim day6atten As String = dgviewattendance.Rows(i).Cells(7).Value.ToString()
                    Dim day7atten As String = dgviewattendance.Rows(i).Cells(8).Value.ToString()
                    cls.SaveEmployeeAttendace(InsID, InsName, periodd, UmbrellaSystemDate, empid, name, day1name, day1atten, day2name, day2atten, day3name, day3atten, day4name, day4atten, day5name, day5atten, day6name, day6atten, day7name, day7atten)
                Next
                If cls.SaveOk = True Then
                    Dim result1 As DialogResult = MessageBox.Show("Record saved successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If result1 = DialogResult.OK Then
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmStaffAttendance_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadDate()
        EGroupBox1.GroupTitle = "Staff Attendance from " + cmbdate.Text
        CreateDataGridViewColumn()
        LoadDataGrid()
        LoadAttendance()
        If USattendances = "View Only" Then
            btnnextweek.Enabled = False
            btnpreweek.Enabled = False
            btnsave.Enabled = False
            cmbdate.Enabled = False
            dgviewattendance.Enabled = False
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnextweek_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnextweek.ClickButtonArea
        Dim sdt As Date = CDate(cmbdate.Text)
        Dim nsdt As Date = sdt.AddDays(7)
        cmbdate.Text = nsdt.ToShortDateString()
        CreateDataGridViewColumn()
        LoadDataGrid()
        LoadAttendance()
        EGroupBox1.GroupTitle = "Staff Attendance from " + cmbdate.Text
    End Sub

    Private Sub btnpreweek_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnpreweek.ClickButtonArea
        Dim sdt As Date = CDate(cmbdate.Text)
        Dim nsdt As Date = sdt.AddDays(-7)
        cmbdate.Text = nsdt.ToShortDateString()
        CreateDataGridViewColumn()
        LoadDataGrid()
        LoadAttendance()
        EGroupBox1.GroupTitle = "Staff Attendance from " + cmbdate.Text
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        SaveRecord()
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        LoadDate()
        EGroupBox1.GroupTitle = "Staff Attendance from " + cmbdate.Text
        CreateDataGridViewColumn()
        LoadDataGrid()
        LoadAttendance()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Attributes..."
    Private Sub cmbdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbdate.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbdate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbdate.TextChanged
        Dim today As Date = CDate(cmbdate.Text)
        Dim dayIndex As Integer = today.DayOfWeek
        If dayIndex < DayOfWeek.Monday Then
            dayIndex += 7
        End If
        Dim dayDiff As Integer = dayIndex - DayOfWeek.Monday
        Dim monday As Date = today.AddDays(-dayDiff)
        Dim startdate As String = monday.ToShortDateString()
        Dim sunday As Date = monday.AddDays(6)
        Dim enddate As String = sunday.ToShortDateString()
        cmbdate.Text = startdate
        CreateDataGridViewColumn()
        LoadDataGrid()
        LoadAttendance()
        EGroupBox1.GroupTitle = "Staff Attendance from " + cmbdate.Text
    End Sub
#End Region
End Class
#End Region