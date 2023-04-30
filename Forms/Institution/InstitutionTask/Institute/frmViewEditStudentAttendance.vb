#Region "Class frmViewEditStudentAttendance..."
Public Class frmViewEditStudentAttendance
#Region "Methods..."
    Private Sub LoadDate()
        Dim today As Date = Date.Today
        Dim dayIndex As Integer = today.DayOfWeek
        If dayIndex < DayOfWeek.Monday Then
            dayIndex += 7
        End If
        Dim dayDiff As Integer = dayIndex - DayOfWeek.Monday
        Dim monday As Date = today.AddDays(-dayDiff)
        Dim startdate As String = monday.ToShortDateString()
        Dim sunday As Date = monday.AddDays(6)
        Dim enddate As String = sunday.ToShortDateString()
        cmbfrom.Text = startdate
        cmbto.Text = enddate
    End Sub

    Private Sub CreateDataGridViewColumn()
        dgviewattendance.Rows.Clear()
        dgviewattendance.Columns.Clear()
        Dim monday As Date = CDate(cmbfrom.Text)
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
        End With
        Dim col2 As New DataGridViewTextBoxColumn()
        With col2
            .Name = "col2"
            .HeaderText = "Student Name"
            .ReadOnly = True
        End With
        Dim col3 As New DataGridViewComboBoxColumn()
        With col3
            .Name = "col3"
            .HeaderText = day1
            .Items.Add("Present")
            .Items.Add("Absent")
            .ReadOnly = False
        End With
        Dim col4 As New DataGridViewComboBoxColumn()
        With col4
            .Name = "col4"
            .HeaderText = day2
            .Items.Add("Present")
            .Items.Add("Absent")
            .ReadOnly = False
        End With
        Dim col5 As New DataGridViewComboBoxColumn()
        With col5
            .Name = "col5"
            .HeaderText = day3
            .Items.Add("Present")
            .Items.Add("Absent")
            .ReadOnly = False
        End With
        Dim col6 As New DataGridViewComboBoxColumn()
        With col6
            .Name = "col6"
            .HeaderText = day4
            .Items.Add("Present")
            .Items.Add("Absent")
            .ReadOnly = False
        End With
        Dim col7 As New DataGridViewComboBoxColumn()
        With col7
            .Name = "col7"
            .HeaderText = day5
            .Items.Add("Present")
            .Items.Add("Absent")
            .ReadOnly = False
        End With
        Dim col8 As New DataGridViewComboBoxColumn()
        With col8
            .Name = "col8"
            .HeaderText = day6
            .Items.Add("Present")
            .Items.Add("Absent")
            .ReadOnly = False
        End With
        Dim col9 As New DataGridViewComboBoxColumn()
        With col9
            .Name = "col9"
            .HeaderText = day7
            .Items.Add("Present")
            .Items.Add("Absent")
            .ReadOnly = False
        End With

        dgviewattendance.Columns.Add(col1)
        dgviewattendance.Columns.Add(col2)
        dgviewattendance.Columns.Add(col3)
        dgviewattendance.Columns.Add(col4)
        dgviewattendance.Columns.Add(col5)
        dgviewattendance.Columns.Add(col6)
        dgviewattendance.Columns.Add(col7)
        dgviewattendance.Columns.Add(col8)
        dgviewattendance.Columns.Add(col9)
    End Sub

    Private Sub LoadDataGrid()
        Try
            Dim i As Integer = 0
            dgviewattendance.Rows.Clear()
            cmd.CommandText = "select stuid,name from StudentRegistration where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and SystemDate<='" & UmbrellaSystemDate & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewattendance.Rows.Add()
                dgviewattendance.Rows(i).Cells(0).Value = dr("stuid").ToString()
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
                cmd.CommandText = "select * from StudentAttendance where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and stuid='" & dgviewattendance.Rows(i).Cells(0).Value.ToString() & "' and name='" & dgviewattendance.Rows(i).Cells(1).Value.ToString() & "' and day1name='" & dgviewattendance.Columns(2).HeaderText & "' and SystemDate<='" & UmbrellaSystemDate & "'"
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
                    End If
                    If day2 = dgviewattendance.Columns(3).HeaderText Then
                        dgviewattendance.Rows(i).Cells(3).Value = dr("day2atten").ToString()
                    End If
                    If day3 = dgviewattendance.Columns(4).HeaderText Then
                        dgviewattendance.Rows(i).Cells(4).Value = dr("day3atten").ToString()
                    End If
                    If day4 = dgviewattendance.Columns(5).HeaderText Then
                        dgviewattendance.Rows(i).Cells(5).Value = dr("day4atten").ToString()
                    End If
                    If day5 = dgviewattendance.Columns(6).HeaderText Then
                        dgviewattendance.Rows(i).Cells(6).Value = dr("day5atten").ToString()
                    End If
                    If day6 = dgviewattendance.Columns(7).HeaderText Then
                        dgviewattendance.Rows(i).Cells(7).Value = dr("day6atten").ToString()
                    End If
                    If day7 = dgviewattendance.Columns(8).HeaderText Then
                        dgviewattendance.Rows(i).Cells(8).Value = dr("day7atten").ToString()
                    End If
                End If
                dr.Close()
            Next
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim cls As New cAttendance()
                For i As Integer = 0 To dgviewattendance.Rows.Count - 1
                    Dim InsID As String = My.Settings.LastOpenedInstituteID
                    Dim InsName As String = My.Settings.LastOpenedInstitute
                    Dim periodd As String = My.Settings.Period
                    Dim studentid As String = dgviewattendance.Rows(i).Cells(0).Value.ToString()
                    Dim name As String = dgviewattendance.Rows(i).Cells(1).Value.ToString()
                    Dim day1name As String = dgviewattendance.Columns(2).HeaderText
                    Dim day1atten As String = dgviewattendance.Rows(i).Cells(2).Value.ToString()
                    Dim day2name As String = dgviewattendance.Columns(3).HeaderText
                    Dim day2atten As String = dgviewattendance.Rows(i).Cells(3).Value.ToString()
                    Dim day3name As String = dgviewattendance.Columns(4).HeaderText
                    Dim day3atten As String = dgviewattendance.Rows(i).Cells(4).Value.ToString()
                    Dim day4name As String = dgviewattendance.Columns(5).HeaderText
                    Dim day4atten As String = dgviewattendance.Rows(i).Cells(5).Value.ToString()
                    Dim day5name As String = dgviewattendance.Columns(6).HeaderText
                    Dim day5atten As String = dgviewattendance.Rows(i).Cells(6).Value.ToString()
                    Dim day6name As String = dgviewattendance.Columns(7).HeaderText
                    Dim day6atten As String = dgviewattendance.Rows(i).Cells(7).Value.ToString()
                    Dim day7name As String = dgviewattendance.Columns(8).HeaderText
                    Dim day7atten As String = dgviewattendance.Rows(i).Cells(8).Value.ToString()
                    cls.UpdateStudentAttendace(InsID, InsName, periodd, My.Settings.FinancialPeriod, studentid, name, day1name, day1atten, day2name, day2atten, day3name, day3atten, day4name, day4atten, day5name, day5atten, day6name, day6atten, day7name, day7atten)
                Next
                If cls.UpdateStuOk = True Then
                    Dim result1 As DialogResult = MessageBox.Show("Record updated successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If result1 = DialogResult.OK Then
                        LoadDate()
                        EGroupBox1.GroupTitle = "Student Attendance from " + cmbfrom.Text + " to " + cmbto.Text
                        CreateDataGridViewColumn()
                        LoadDataGrid()
                        LoadAttendance()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            Dim result As DialogResult = MessageBox.Show("Are you sure to delete these record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim cls As New cAttendance()
                For i As Integer = 0 To dgviewattendance.Rows.Count - 1
                    Dim InsID As String = My.Settings.LastOpenedInstituteID
                    Dim InsName As String = My.Settings.LastOpenedInstitute
                    Dim periodd As String = My.Settings.Period
                    Dim day1name As String = dgviewattendance.Columns(2).HeaderText
                    cls.DeleteEmployeeAttendace(InsID, InsName, periodd, My.Settings.FinancialPeriod, day1name)
                Next
                If cls.DeleteOk = True Then
                    Dim result1 As DialogResult = MessageBox.Show("Record deleted successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If result1 = DialogResult.OK Then
                        LoadDate()
                        EGroupBox1.GroupTitle = "Student Attendance from " + cmbfrom.Text + " to " + cmbto.Text
                        CreateDataGridViewColumn()
                        LoadDataGrid()
                        LoadAttendance()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnextweek_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnextweek.ClickButtonArea
        Dim sdt As Date = CDate(cmbfrom.Text)
        Dim edt As Date = CDate(cmbto.Text)
        Dim nsdt As Date = sdt.AddDays(7)
        Dim nedt As Date = edt.AddDays(7)
        cmbfrom.Text = nsdt.ToShortDateString()
        cmbto.Text = nedt.ToShortDateString()
        CreateDataGridViewColumn()
        LoadDataGrid()
        LoadAttendance()
        EGroupBox1.GroupTitle = "Student Attendance from " + cmbfrom.Text + " to " + cmbto.Text
    End Sub

    Private Sub btnpreweek_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnpreweek.ClickButtonArea
        Dim sdt As Date = CDate(cmbfrom.Text)
        Dim edt As Date = CDate(cmbto.Text)
        Dim nsdt As Date = sdt.AddDays(-7)
        Dim nedt As Date = edt.AddDays(-7)
        cmbfrom.Text = nsdt.ToShortDateString()
        cmbto.Text = nedt.ToShortDateString()
        CreateDataGridViewColumn()
        LoadDataGrid()
        LoadAttendance()
        EGroupBox1.GroupTitle = "Student Attendance from " + cmbfrom.Text + " to " + cmbto.Text
    End Sub

    Private Sub btnupdate_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnupdate.ClickButtonArea
        UpdateRecord()
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        DeleteRecord()
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        LoadDate()
        EGroupBox1.GroupTitle = "Student Attendance from " + cmbfrom.Text + " to " + cmbto.Text
        CreateDataGridViewColumn()
        LoadDataGrid()
        LoadAttendance()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub
#End Region
#Region "Attributes..."
    Private Sub cmbfrom_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbfrom.TextChanged
        Dim today As Date = CDate(cmbfrom.Text)
        Dim dayIndex As Integer = today.DayOfWeek
        If dayIndex < DayOfWeek.Monday Then
            dayIndex += 7
        End If
        Dim dayDiff As Integer = dayIndex - DayOfWeek.Monday
        Dim monday As Date = today.AddDays(-dayDiff)
        Dim startdate As String = monday.ToShortDateString()
        Dim sunday As Date = monday.AddDays(6)
        Dim enddate As String = sunday.ToShortDateString()
        cmbfrom.Text = startdate
        cmbto.Text = enddate
        CreateDataGridViewColumn()
        LoadDataGrid()
        LoadAttendance()
        EGroupBox1.GroupTitle = "Student Attendance from " + cmbfrom.Text + " to " + cmbto.Text
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmViewEditStudentAttendance_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadDate()
        EGroupBox1.GroupTitle = "Student Attendance from " + cmbfrom.Text + " to " + cmbto.Text
        CreateDataGridViewColumn()
        LoadDataGrid()
        LoadAttendance()
        If USattendances = "View Only" Then
            btndelete.Enabled = False
            btnnextweek.Enabled = False
            btnpreweek.Enabled = False
            btnupdate.Enabled = False
            cmbfrom.Enabled = False
            cmbto.Enabled = False
            dgviewattendance.Enabled = False
        End If
    End Sub
#End Region
End Class
#End Region