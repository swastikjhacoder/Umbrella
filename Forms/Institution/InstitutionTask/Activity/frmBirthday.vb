#Region "Imports..."
Imports Outlook = Microsoft.Office.Interop.Outlook
#End Region
#Region "Class frmBirthday..."
Public Class frmBirthday
#Region "Declarations..."
    Private STID As String = ""
    Private STNM As String = ""
    Private STDB As Date
    Private STCR As String = ""
    Private STPH As String = ""
    Private STEM As String = ""

    Private EMID As String = ""
    Private EMNM As String = ""
    Private EMDB As Date
    Private EMCR As String = ""
    Private EMPH As String = ""
    Private EMEM As String = ""
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(20, 21, 46, 13)
        cmbmonth.SetBounds(72, 18, 121, 21)
    End Sub

    Private Sub LoadMonth()
        Dim mm As Integer = Date.Now.Month
        If mm = 1 Then
            cmbmonth.Text = "January"
        ElseIf mm = 2 Then
            cmbmonth.Text = "February"
        ElseIf mm = 3 Then
            cmbmonth.Text = "March"
        ElseIf mm = 4 Then
            cmbmonth.Text = "April"
        ElseIf mm = 5 Then
            cmbmonth.Text = "May"
        ElseIf mm = 6 Then
            cmbmonth.Text = "June"
        ElseIf mm = 7 Then
            cmbmonth.Text = "July"
        ElseIf mm = 8 Then
            cmbmonth.Text = "August"
        ElseIf mm = 9 Then
            cmbmonth.Text = "September"
        ElseIf mm = 10 Then
            cmbmonth.Text = "October"
        ElseIf mm = 11 Then
            cmbmonth.Text = "November"
        ElseIf mm = 12 Then
            cmbmonth.Text = "December"
        End If
    End Sub

    Private Sub LoadBirthDays()
        Try
            Dim i As Integer = 0
            dgviewbirthday.Rows.Clear()
            cmd.CommandText = "select stuid,name,dob,homephone,email from StudentRegistration where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                STID = dr("stuid").ToString()
                STNM = dr("name").ToString()
                STDB = Date.Parse(dr("dob").ToString())
                STCR = "Student"
                STPH = dr("homephone").ToString()
                STEM = dr("email").ToString()
                Dim dd As Integer = STDB.Day
                Dim mm As Integer = STDB.Month
                If dd = Date.Now.Day And mm = Date.Now.Month Then
                    dgviewbirthday.Rows.Add()
                    dgviewbirthday.Rows(i).Cells(0).Value = STID
                    dgviewbirthday.Rows(i).Cells(1).Value = STNM
                    dgviewbirthday.Rows(i).Cells(2).Value = STDB
                    dgviewbirthday.Rows(i).Cells(3).Value = STCR
                    dgviewbirthday.Rows(i).Cells(4).Value = STPH
                    dgviewbirthday.Rows(i).Cells(5).Value = STEM
                    dgviewbirthday.Rows(i).Cells(6).Value = "Wish"
                    i = i + 1
                End If
            End While
            dr.Close()
            cmd.CommandText = "select empid,name,dob,designation,phone,email from Employee where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                EMID = dr("empid").ToString()
                EMNM = dr("name").ToString()
                EMDB = Date.Parse(dr("dob").ToString())
                EMCR = dr("designation").ToString()
                EMPH = dr("phone").ToString()
                EMEM = dr("email").ToString()
                Dim ddd As Integer = EMDB.Day
                Dim mmm As Integer = EMDB.Month
                If ddd = Date.Now.Day And mmm = Date.Now.Month Then
                    dgviewbirthday.Rows.Add()
                    dgviewbirthday.Rows(i).Cells(0).Value = EMID
                    dgviewbirthday.Rows(i).Cells(1).Value = EMNM
                    dgviewbirthday.Rows(i).Cells(2).Value = EMDB
                    dgviewbirthday.Rows(i).Cells(3).Value = EMCR
                    dgviewbirthday.Rows(i).Cells(4).Value = EMPH
                    dgviewbirthday.Rows(i).Cells(5).Value = EMEM
                    dgviewbirthday.Rows(i).Cells(6).Value = "Wish"
                    i = i + 1
                End If
            End While
            dr.Close()
            dgviewbirthday.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadMonthBirthday()
        Try
            Dim mon As Integer
            If cmbmonth.Text = "January" Then
                mon = 1
            ElseIf cmbmonth.Text = "February" Then
                mon = 2
            ElseIf cmbmonth.Text = "March" Then
                mon = 3
            ElseIf cmbmonth.Text = "April" Then
                mon = 4
            ElseIf cmbmonth.Text = "May" Then
                mon = 5
            ElseIf cmbmonth.Text = "June" Then
                mon = 6
            ElseIf cmbmonth.Text = "July" Then
                mon = 7
            ElseIf cmbmonth.Text = "August" Then
                mon = 8
            ElseIf cmbmonth.Text = "September" Then
                mon = 9
            ElseIf cmbmonth.Text = "October" Then
                mon = 10
            ElseIf cmbmonth.Text = "November" Then
                mon = 11
            ElseIf cmbmonth.Text = "December" Then
                mon = 12
            End If
            Dim row As Integer = 0
            dgviewmonthbirthday.Rows.Clear()
            cmd.CommandText = "select stuid,name,dob,homephone,email from StudentRegistration where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                STID = dr("stuid").ToString()
                STNM = dr("name").ToString()
                STDB = Date.Parse(dr("dob").ToString())
                STCR = "Student"
                STPH = dr("homephone").ToString()
                STEM = dr("email").ToString()
                Dim mm As Integer = STDB.Month
                If mm = mon Then
                    dgviewmonthbirthday.Rows.Add()
                    dgviewmonthbirthday.Rows(row).Cells(0).Value = STID
                    dgviewmonthbirthday.Rows(row).Cells(1).Value = STNM
                    dgviewmonthbirthday.Rows(row).Cells(2).Value = STDB
                    dgviewmonthbirthday.Rows(row).Cells(3).Value = STCR
                    dgviewmonthbirthday.Rows(row).Cells(4).Value = STPH
                    dgviewmonthbirthday.Rows(row).Cells(5).Value = STEM
                    row = row + 1
                End If
            End While
            dr.Close()
            cmd.CommandText = "select empid,name,dob,designation,phone,email from Employee where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                EMID = dr("empid").ToString()
                EMNM = dr("name").ToString()
                EMDB = Date.Parse(dr("dob").ToString())
                EMCR = dr("designation").ToString()
                EMPH = dr("phone").ToString()
                EMEM = dr("email").ToString()
                Dim mmm As Integer = EMDB.Month
                If mmm = mon Then
                    dgviewmonthbirthday.Rows.Add()
                    dgviewmonthbirthday.Rows(row).Cells(0).Value = EMID
                    dgviewmonthbirthday.Rows(row).Cells(1).Value = EMNM
                    dgviewmonthbirthday.Rows(row).Cells(2).Value = EMDB
                    dgviewmonthbirthday.Rows(row).Cells(3).Value = EMCR
                    dgviewmonthbirthday.Rows(row).Cells(4).Value = EMPH
                    dgviewmonthbirthday.Rows(row).Cells(5).Value = EMEM
                    row = row + 1
                End If
            End While
            dr.Close()
            dgviewmonthbirthday.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmBirthday_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
        LoadMonth()
        LoadBirthDays()
        LoadMonthBirthday()
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        ControlSetBound()
        LoadMonth()
        LoadBirthDays()
        LoadMonthBirthday()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Attributes..."
    Private Sub cmbmonth_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbmonth.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadMonthBirthday()
        End If
    End Sub

    Private Sub cmbmonth_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbmonth.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbmonth_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbmonth.TextChanged
        If cmbmonth.Text <> "" Then
            EGroupBox2.GroupTitle = "Birthdays of this month: "
            EGroupBox2.GroupTitle += cmbmonth.Text
            LoadMonthBirthday()
        End If
    End Sub
#End Region
#Region "DGView Events..."
    Private Sub dgviewbirthday_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgviewbirthday.CellClick
        If e.ColumnIndex = 0 Then
            Dim i As Integer = dgviewbirthday.CurrentRow.Index
            Dim DES As String = dgviewbirthday.Rows(i).Cells(3).Value.ToString()
            If DES = "Student" Then
                updatestudentreg = True
                StuID = dgviewbirthday.Rows(i).Cells(0).Value.ToString()
                Dim frm As New frmStudentRegistration()
                frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                frm.WindowState = FormWindowState.Normal
                frm.ControlBox = True
                frm.Show()
            Else
                updateemployee = True
                EmpRegNo = dgviewbirthday.Rows(i).Cells(0).Value.ToString()
                Dim frm As New frmEnrollEmployee()
                frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                frm.WindowState = FormWindowState.Normal
                frm.ControlBox = True
                frm.Show()
            End If
        ElseIf e.ColumnIndex = 6 Then
            Dim i As Integer = dgviewbirthday.CurrentRow.Index
            Dim EMAIL As String = dgviewbirthday.Rows(i).Cells(5).Value.ToString()
            If EMAIL <> "" Then
                Try
                    Dim objOutlk As New Outlook.Application
                    Const olMailItem As Integer = 0
                    Dim objMail As New System.Object
                    objMail = objOutlk.CreateItem(olMailItem)
                    objMail.To = EMAIL
                    objMail.cc = ""
                    objMail.subject = "Happy Birthday Wishes From " + My.Settings.LastOpenedInstitute + Environment.NewLine + "Powered by Umbrella"
                    Dim msg As String
                    msg = ""
                    objMail.body = msg
                    objMail.display()
                    objMail = Nothing
                    objOutlk = Nothing
                Catch ex As Exception
                    MsgBox(ex.Message.ToString())
                End Try
            Else
                Dim result As DialogResult = MessageBox.Show("Email id not found.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                End If
            End If
        End If
    End Sub

    Private Sub dgviewmonthbirthday_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgviewmonthbirthday.CellClick
        If e.ColumnIndex = 0 Then
            Dim i As Integer = dgviewmonthbirthday.CurrentRow.Index
            Dim DES As String = dgviewmonthbirthday.Rows(i).Cells(3).Value.ToString()
            If DES = "Student" Then
                updatestudentreg = True
                StuID = dgviewmonthbirthday.Rows(i).Cells(0).Value.ToString()
                Dim frm As New frmStudentRegistration()
                frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                frm.WindowState = FormWindowState.Normal
                frm.ControlBox = True
                frm.Show()
            Else
                updateemployee = True
                EmpRegNo = dgviewmonthbirthday.Rows(i).Cells(0).Value.ToString()
                Dim frm As New frmEnrollEmployee()
                frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                frm.WindowState = FormWindowState.Normal
                frm.ControlBox = True
                frm.Show()
            End If
        End If
    End Sub
#End Region
End Class
#End Region