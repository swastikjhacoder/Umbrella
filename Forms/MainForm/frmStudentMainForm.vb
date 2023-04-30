#Region "Class frmStudentMainForm..."
Public Class frmStudentMainForm
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(12, 10, 113, 13)
        Label2.SetBounds(12, 50, 116, 13)
        cmbdate.SetBounds(15, 26, 110, 21)
        txtexamcode.SetBounds(15, 68, 110, 21)
    End Sub

    Private Sub LoadSubPages()
        Dim frmnode As New frmStudentInfo()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripStudentInfo.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripStudentInfo.SelectedItem = item
        ETabStripStudentInfo.SelectedItem.Image = Global.Umbrella.My.Resources.student_registration
    End Sub

    Private Sub LoadExamInfo()
        Try
            cmd.CommandText = "select examid,examdate from OnlineExamQsn where examdate='" & cmbdate.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                txtexamcode.Text = dr("examid").ToString()
                examdate = dr("examdate").ToString()
                examcode = txtexamcode.Text
            Else
                txtexamcode.Text = ""
                examcode = txtexamcode.Text
                examdate = ""
            End If
            dr.Close()
            If txtexamcode.Text.Trim() = "" Then
                btnonlineexamination.Enabled = False
            Else
                btnonlineexamination.Enabled = True
            End If
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Menu Events..."
#Region "Side Menu Events..."
    Private Sub btnstudentinfo_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnstudentinfo.ClickButtonArea
        ETabControlEx1.SelectTab(TabPage1)
        TabPage1.Focus()
    End Sub

    Private Sub btnonlineexamination_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnonlineexamination.ClickButtonArea
        ETabControlEx1.SelectTab(TabPage2)
        TabPage2.Focus()
        Dim frmnode As New frmOnlineExamination()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripOnlineExamination.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripOnlineExamination.SelectedItem = item
        ETabStripOnlineExamination.SelectedItem.Image = Global.Umbrella.My.Resources.online_exam
    End Sub
#End Region
#Region "Header Menu Events..."
    Private Sub btnlogoutstudentinfo_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnlogoutstudentinfo.ClickButtonArea
        Dim result As DialogResult = MessageBox.Show("Are you sure to logout?", "Umbrella - Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnhidestudentinfo_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhidestudentinfo.ClickButtonArea
        If btnhidestudentinfo.Text = "Hide" Then
            PanelStudentInfo.Visible = False
            btnhidestudentinfo.Text = "Show"
            btnhidestudentinfo.Image = Global.Umbrella.My.Resources.expandIcon
        Else
            PanelStudentInfo.Visible = True
            btnhidestudentinfo.Text = "Hide"
            btnhidestudentinfo.Image = Global.Umbrella.My.Resources.collapseIcon
        End If
    End Sub

    Private Sub btnlogoutexam_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnlogoutexam.ClickButtonArea
        Dim result As DialogResult = MessageBox.Show("Are you sure to logout?", "Umbrella - Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnhideexam_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhideexam.ClickButtonArea
        If btnhideexam.Text = "Hide" Then
            PanelExam.Visible = False
            btnhideexam.Text = "Show"
            btnhideexam.Image = Global.Umbrella.My.Resources.expandIcon
        Else
            PanelExam.Visible = True
            btnhideexam.Text = "Hide"
            btnhideexam.Image = Global.Umbrella.My.Resources.collapseIcon
        End If
    End Sub
#End Region
#End Region
#Region "Form Events..."
    Private Sub frmStudentMainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim frm As New frmMainTask()
        frm.MdiParent = Me.MdiParent
        frm.Show()
    End Sub

    Private Sub frmStudentMainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
        For Each frmApproval As Form In Me.MdiChildren
            frmApproval.Close()
        Next
        ETabControlEx1.HideTabs = True
        cmbdate.Text = UmbrellaSystemDate
        LoadSubPages()
        LoadExamInfo()
    End Sub
#End Region
#Region "Attributes..."
    Private Sub cmbdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadExamInfo()
            txtexamcode.Focus()
        End If
    End Sub

    Private Sub cmbdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbdate.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbdate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbdate.TextChanged
        If cmbdate.Text <> "" Then
            LoadExamInfo()
        End If
    End Sub

    Private Sub txtexamcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtexamcode.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            btnonlineexamination.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbdate.Focus()
        End If
    End Sub
#End Region
#Region "TabStrip Events..."
    Private Sub ETabStripOnlineExamination_TabStripItemClosing(ByVal e As ESAR_Controls.UIControls.TabControl.TabStripItemClosingEventArgs) Handles ETabStripOnlineExamination.TabStripItemClosing
        If ETabStripOnlineExamination.SelectedItem.Title = frmOnlineExamination.Text Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ETabStripStudentInfo_TabStripItemClosing(ByVal e As ESAR_Controls.UIControls.TabControl.TabStripItemClosingEventArgs) Handles ETabStripStudentInfo.TabStripItemClosing
        If ETabStripStudentInfo.SelectedItem.Title = frmStudentInfo.Text Then
            e.Cancel = True
        End If
    End Sub
#End Region
End Class
#End Region