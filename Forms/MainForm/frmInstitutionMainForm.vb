#Region "frmInstitutionMainForm..."
#Region "Import..."
Imports Microsoft.Win32
#End Region
#Region "Class frmInstitutionMainForm..."
Public Class frmInstitutionMainForm
#Region "WithEvents..."
    Private WithEvents childA As frmChangeSystemDate
    Private WithEvents childB As frmAccountingPeriod
#End Region
#Region "Declaration"
    Dim retVal As String = "IEXPLORE.EXE"
#End Region
#Region "Task Menu..."
    Private Sub btnsystem_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsystem.ClickButtonArea
        TabControl1.SelectTab(TabPageInstitute)
        TabPageInstitute.Focus()
    End Sub

    Private Sub btnadmission_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnadmission.ClickButtonArea
        TabControl1.SelectTab(TabPageAdmission)
        TabPageAdmission.Focus()
    End Sub

    Private Sub btnfees_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnfees.ClickButtonArea
        TabControl1.SelectTab(TabPageFees)
        TabPageFees.Focus()
    End Sub

    Private Sub btnexamination_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnexamination.ClickButtonArea
        TabControl1.SelectTab(TabPageExamination)
        TabPageExamination.Focus()
    End Sub

    Private Sub btnactivity_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnactivity.ClickButtonArea
        TabControl1.SelectTab(TabPageActivity)
        TabPageActivity.Focus()
    End Sub
#End Region
#Region "Header Menu..."
#Region "System Header..."
    Private Sub btndefaultsystem_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndefaultsystem.ClickButtonArea
        My.Settings.InstituteDefaultPage = TabPageInstitute.Text
        My.Settings.Save()
        Me.btndefaultsystem.Text = "This is your default page"
        btndefaultsystem.ForeColor = Color.Yellow
        Me.btndefaultactivity.Text = "Make this your default page"
        btndefaultactivity.ForeColor = Color.White
        Me.btndefaultadmission.Text = "Make this your default page"
        btndefaultadmission.ForeColor = Color.White
        Me.btndefaultfees.Text = "Make this your default page"
        btndefaultfees.ForeColor = Color.White
        Me.btndefaultexam.Text = "Make this your default page"
        btndefaultexam.ForeColor = Color.White
    End Sub

    Private Sub btndatesystem_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndatesystem.ClickButtonArea
        Me.childA = New frmChangeSystemDate
        AddHandler childA.ValueUpdated, AddressOf DateValueUpdated

        Me.childA.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.childA.WindowState = FormWindowState.Normal
        Me.childA.StartPosition = FormStartPosition.CenterScreen
        Me.childA.ControlBox = True
        Me.childA.ShowDialog()
    End Sub

    Private Sub btnperiodsystem_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnperiodsystem.ClickButtonArea
        Me.childB = New frmAccountingPeriod
        AddHandler childB.ValueUpdated, AddressOf PeriodValueUpdated

        Me.childB.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.childB.WindowState = FormWindowState.Normal
        Me.childB.StartPosition = FormStartPosition.CenterScreen
        Me.childB.ControlBox = True
        Me.childB.ShowDialog()
    End Sub

    Private Sub btnhidesystem_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhidesystem.ClickButtonArea
        If btnhidesystem.Text = "Hide" Then
            SplitContainerSystem.Visible = False
            btnhidesystem.Text = "Show"
            btnhidesystem.Image = Global.Umbrella.My.Resources.expandIcon
            My.Settings.InstituteSystemPanel = "Hide"
            My.Settings.Save()
        Else
            SplitContainerSystem.Visible = True
            btnhidesystem.Text = "Hide"
            btnhidesystem.Image = Global.Umbrella.My.Resources.collapseIcon
            My.Settings.InstituteSystemPanel = "Show"
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnlogoutsystem_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnlogoutsystem.ClickButtonArea
        Dim result As DialogResult = MessageBox.Show("Are you sure to logout?", "Umbrella - Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
#End Region
#Region "Admission Header..."
    Private Sub btndefaultadmission_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndefaultadmission.ClickButtonArea
        My.Settings.InstituteDefaultPage = TabPageAdmission.Text
        My.Settings.Save()
        Me.btndefaultadmission.Text = "This is your default page"
        btndefaultadmission.ForeColor = Color.Yellow
        Me.btndefaultsystem.Text = "Make this your default page"
        btndefaultsystem.ForeColor = Color.White
        Me.btndefaultfees.Text = "Make this your default page"
        btndefaultfees.ForeColor = Color.White
        Me.btndefaultexam.Text = "Make this your default page"
        btndefaultexam.ForeColor = Color.White
        Me.btndefaultactivity.Text = "Make this your default page"
        btndefaultactivity.ForeColor = Color.SteelBlue
    End Sub

    Private Sub btndateadmission_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndateadmission.ClickButtonArea
        Me.childA = New frmChangeSystemDate
        AddHandler childA.ValueUpdated, AddressOf DateValueUpdated

        Me.childA.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.childA.WindowState = FormWindowState.Normal
        Me.childA.StartPosition = FormStartPosition.CenterScreen
        Me.childA.ControlBox = True
        Me.childA.ShowDialog()
    End Sub

    Private Sub btnperiodadmission_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnperiodadmission.ClickButtonArea
        Me.childB = New frmAccountingPeriod
        AddHandler childB.ValueUpdated, AddressOf PeriodValueUpdated

        Me.childB.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.childB.WindowState = FormWindowState.Normal
        Me.childB.StartPosition = FormStartPosition.CenterScreen
        Me.childB.ControlBox = True
        Me.childB.ShowDialog()
    End Sub

    Private Sub btnhideadmission_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhideadmission.ClickButtonArea
        If btnhideadmission.Text = "Hide" Then
            SplitContainerAdmission.Visible = False
            btnhideadmission.Text = "Show"
            btnhideadmission.Image = Global.Umbrella.My.Resources.expandIcon
            My.Settings.InstituteAdmissionPanel = "Hide"
            My.Settings.Save()
        Else
            SplitContainerAdmission.Visible = True
            btnhideadmission.Text = "Hide"
            btnhideadmission.Image = Global.Umbrella.My.Resources.collapseIcon
            My.Settings.InstituteAdmissionPanel = "Show"
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnlogoutadmission_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnlogoutadmission.ClickButtonArea
        Dim result As DialogResult = MessageBox.Show("Are you sure to logout?", "Umbrella - Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
#End Region
#Region "Fees Header..."
    Private Sub btndefaultfees_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndefaultfees.ClickButtonArea
        My.Settings.InstituteDefaultPage = TabPageFees.Text
        My.Settings.Save()
        Me.btndefaultfees.Text = "This is your default page"
        btndefaultfees.ForeColor = Color.Yellow
        Me.btndefaultsystem.Text = "Make this your default page"
        btndefaultsystem.ForeColor = Color.White
        Me.btndefaultadmission.Text = "Make this your default page"
        btndefaultadmission.ForeColor = Color.White
        Me.btndefaultexam.Text = "Make this your default page"
        btndefaultexam.ForeColor = Color.White
        Me.btndefaultactivity.Text = "Make this your default page"
        btndefaultactivity.ForeColor = Color.White
    End Sub

    Private Sub btndatefees_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndatefees.ClickButtonArea
        Me.childA = New frmChangeSystemDate
        AddHandler childA.ValueUpdated, AddressOf DateValueUpdated

        Me.childA.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.childA.WindowState = FormWindowState.Normal
        Me.childA.StartPosition = FormStartPosition.CenterScreen
        Me.childA.ControlBox = True
        Me.childA.ShowDialog()
    End Sub

    Private Sub btnperiodfees_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnperiodfees.ClickButtonArea
        Me.childB = New frmAccountingPeriod
        AddHandler childB.ValueUpdated, AddressOf PeriodValueUpdated

        Me.childB.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.childB.WindowState = FormWindowState.Normal
        Me.childB.StartPosition = FormStartPosition.CenterScreen
        Me.childB.ControlBox = True
        Me.childB.ShowDialog()
    End Sub

    Private Sub btnhidefees_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhidefees.ClickButtonArea
        If btnhidefees.Text = "Hide" Then
            SplitContainerFees.Visible = False
            btnhidefees.Text = "Show"
            btnhidefees.Image = Global.Umbrella.My.Resources.expandIcon
            My.Settings.InstituteFeesPanel = "Hide"
            My.Settings.Save()
        Else
            SplitContainerFees.Visible = True
            btnhidefees.Text = "Hide"
            btnhidefees.Image = Global.Umbrella.My.Resources.collapseIcon
            My.Settings.InstituteFeesPanel = "Show"
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnlogoutfees_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnlogoutfees.ClickButtonArea
        Dim result As DialogResult = MessageBox.Show("Are you sure to logout?", "Umbrella - Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
#End Region
#Region "Examination Header..."
    Private Sub btndefaultexam_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndefaultexam.ClickButtonArea
        My.Settings.InstituteDefaultPage = TabPageExamination.Text
        My.Settings.Save()
        Me.btndefaultexam.Text = "This is your default page"
        btndefaultexam.ForeColor = Color.Yellow
        Me.btndefaultsystem.Text = "Make this your default page"
        btndefaultsystem.ForeColor = Color.White
        Me.btndefaultadmission.Text = "Make this your default page"
        btndefaultadmission.ForeColor = Color.White
        Me.btndefaultfees.Text = "Make this your default page"
        btndefaultfees.ForeColor = Color.White
        Me.btndefaultactivity.Text = "Make this your default page"
        btndefaultactivity.ForeColor = Color.White
    End Sub

    Private Sub btndateexam_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndateexam.ClickButtonArea
        Me.childA = New frmChangeSystemDate
        AddHandler childA.ValueUpdated, AddressOf DateValueUpdated

        Me.childA.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.childA.WindowState = FormWindowState.Normal
        Me.childA.StartPosition = FormStartPosition.CenterScreen
        Me.childA.ControlBox = True
        Me.childA.ShowDialog()
    End Sub

    Private Sub btnperiodexam_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnperiodexam.ClickButtonArea
        Me.childB = New frmAccountingPeriod
        AddHandler childB.ValueUpdated, AddressOf PeriodValueUpdated

        Me.childB.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.childB.WindowState = FormWindowState.Normal
        Me.childB.StartPosition = FormStartPosition.CenterScreen
        Me.childB.ControlBox = True
        Me.childB.ShowDialog()
    End Sub

    Private Sub btnhideexam_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhideexam.ClickButtonArea
        If btnhideexam.Text = "Hide" Then
            SplitContainerExam.Visible = False
            btnhideexam.Text = "Show"
            btnhideexam.Image = Global.Umbrella.My.Resources.expandIcon
            My.Settings.InstituteExaminationPanel = "Hide"
            My.Settings.Save()
        Else
            SplitContainerExam.Visible = True
            btnhideexam.Text = "Hide"
            btnhideexam.Image = Global.Umbrella.My.Resources.collapseIcon
            My.Settings.InstituteExaminationPanel = "Show"
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnlogoutexam_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnlogoutexam.ClickButtonArea
        Dim result As DialogResult = MessageBox.Show("Are you sure to logout?", "Umbrella - Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
#End Region
#Region "Activity Header..."
    Private Sub btndefaultactivity_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndefaultactivity.ClickButtonArea
        My.Settings.InstituteDefaultPage = TabPageActivity.Text
        My.Settings.Save()
        Me.btndefaultactivity.Text = "This is your default page"
        btndefaultactivity.ForeColor = Color.Yellow
        Me.btndefaultsystem.Text = "Make this your default page"
        btndefaultsystem.ForeColor = Color.White
        Me.btndefaultadmission.Text = "Make this your default page"
        btndefaultadmission.ForeColor = Color.White
        Me.btndefaultfees.Text = "Make this your default page"
        btndefaultfees.ForeColor = Color.White
        Me.btndefaultexam.Text = "Make this your default page"
        btndefaultexam.ForeColor = Color.White
    End Sub

    Private Sub btndateactivity_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndateactivity.ClickButtonArea
        Me.childA = New frmChangeSystemDate
        AddHandler childA.ValueUpdated, AddressOf DateValueUpdated

        Me.childA.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.childA.WindowState = FormWindowState.Normal
        Me.childA.StartPosition = FormStartPosition.CenterScreen
        Me.childA.ControlBox = True
        Me.childA.ShowDialog()
    End Sub

    Private Sub btnperiodactivity_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnperiodactivity.ClickButtonArea
        Me.childB = New frmAccountingPeriod
        AddHandler childB.ValueUpdated, AddressOf PeriodValueUpdated

        Me.childB.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.childB.WindowState = FormWindowState.Normal
        Me.childB.StartPosition = FormStartPosition.CenterScreen
        Me.childB.ControlBox = True
        Me.childB.ShowDialog()
    End Sub

    Private Sub btnhideactivity_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhideactivity.ClickButtonArea
        If btnhideactivity.Text = "Hide" Then
            SplitContainerActivity.Visible = False
            btnhideactivity.Text = "Show"
            btnhideactivity.Image = Global.Umbrella.My.Resources.expandIcon
            My.Settings.InstituteActivityPanel = "Hide"
            My.Settings.Save()
        Else
            SplitContainerActivity.Visible = True
            btnhideactivity.Text = "Hide"
            btnhideactivity.Image = Global.Umbrella.My.Resources.collapseIcon
            My.Settings.InstituteActivityPanel = "Show"
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnlogoutactivity_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnlogoutactivity.ClickButtonArea
        Dim result As DialogResult = MessageBox.Show("Are you sure to logout?", "Umbrella - Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
#End Region
#End Region
#Region "Menu Events..."
#Region "Institute Menu..."
    Private Sub btnemployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnemployee.Click
        updateemployee = False
        Dim frmnode As New frmEnrollEmployee()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.administrator_icon
    End Sub

    Private Sub btnvieweditemployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditemployee.Click
        Dim frmnode As New frmViewEditEmployee()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnhiredemployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhiredemployee.Click
        updatehiredemployee = False
        Dim frmnode As New frmHiredEmployee()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.staff
    End Sub

    Private Sub btnviewedithiredemployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnviewedithiredemployee.Click
        Dim frmnode As New frmViewEditHiredEmployee()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnretiredemployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnretiredemployee.Click
        Dim frmnode As New frmRetiredEmployeeList()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnstaffattendance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstaffattendance.Click
        Dim frmnode As New frmStaffAttendance()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.staff_attendance
    End Sub

    Private Sub btnvieweditstaffattendance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditstaffattendance.Click
        Dim frmnode As New frmViewEditStaffAttendance()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnstudentattendance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstudentattendance.Click
        Dim frmnode As New frmStudentAttendance()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.Student_Attendance
    End Sub

    Private Sub btnvieweditstudentattendance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditstudentattendance.Click
        Dim frmnode As New frmViewEditStudentAttendance()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnnotice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnotice.Click
        updatenotice = False
        Dim frmnode As New frmNotices()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.notice_icon
    End Sub

    Private Sub btnvieweditnotice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditnotice.Click
        Dim frmnode As New frmViewEditNotices()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnidcard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnidcard.Click
        updateidcard = False
        Dim frmnode As New frmSubmitIDCard()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.ID_icon
    End Sub

    Private Sub btnvieweditidcard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditidcard.Click
        Dim frmnode As New frmViewEditIDCard()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnusersecurity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnusersecurity.Click
        Dim frmnode As New frmUserSecurity()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.User_Secuirity_Menu
    End Sub

    Private Sub btnuserrole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnuserrole.Click
        Dim frm As New frmUserRole()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.Show()
    End Sub

    Private Sub btnreportssystem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreportssystem.Click
        InstituteReports = "Institute"
        Dim frm As New frmShowReports()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.Show()
    End Sub
#End Region
#Region "Admission Menu..."
    Private Sub btnstudentadmission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstudentadmission.Click
        updatestudentadm = False
        Dim frmnode As New frmStudentAdmission()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripAdmission.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripAdmission.SelectedItem = item
        ETabStripAdmission.SelectedItem.Image = Global.Umbrella.My.Resources.admission_icon
    End Sub

    Private Sub btnvieweditstudentadmission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditstudentadmission.Click
        Dim frmnode As New frmViewEditStudentAdmission()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripAdmission.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripAdmission.SelectedItem = item
        ETabStripAdmission.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnstudentpreadmission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstudentpreadmission.Click
        updatestudentpreadm = False
        Dim frmnode As New frmStudentPreAdmission()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripAdmission.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripAdmission.SelectedItem = item
        ETabStripAdmission.SelectedItem.Image = Global.Umbrella.My.Resources.admission_icon
    End Sub

    Private Sub btnvieweditstudentpreadmission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditstudentpreadmission.Click
        Dim frmnode As New frmViewEditStudentPreAdmission()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripAdmission.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripAdmission.SelectedItem = item
        ETabStripAdmission.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnstudentregistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstudentregistration.Click
        updatestudentreg = False
        Dim frmnode As New frmStudentRegistration()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripAdmission.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripAdmission.SelectedItem = item
        ETabStripAdmission.SelectedItem.Image = Global.Umbrella.My.Resources.student_registration
    End Sub

    Private Sub btnvieweditstudentregistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditstudentregistration.Click
        Dim frmnode As New frmViewEditStudentRegistration()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripAdmission.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripAdmission.SelectedItem = item
        ETabStripAdmission.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnadmissionreports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadmissionreports.Click
        InstituteReports = "Admission"
        Dim frm As New frmShowReports()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.Show()
    End Sub
#End Region
#Region "Fees Menu..."
    Private Sub btntermsfees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntermsfees.Click
        Dim frmnode As New frmTermOfFees()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripFees.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripFees.SelectedItem = item
        ETabStripFees.SelectedItem.Image = Global.Umbrella.My.Resources.terms_of_fees
    End Sub

    Private Sub btnmonthlyfees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmonthlyfees.Click
        updatemonthlyfees = False
        Dim frmnode As New frmMonthlyFees()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripFees.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripFees.SelectedItem = item
        ETabStripFees.SelectedItem.Image = Global.Umbrella.My.Resources.monthly
    End Sub

    Private Sub btnvieweditmonthlyfees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditmonthlyfees.Click
        Dim frmnode As New frmViewEditMonthlyFees()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripFees.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripFees.SelectedItem = item
        ETabStripFees.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnyearlyfees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnyearlyfees.Click
        updateyaerlyfees = False
        Dim frmnode As New frmYearlyFees()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripFees.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripFees.SelectedItem = item
        ETabStripFees.SelectedItem.Image = Global.Umbrella.My.Resources.yearly
    End Sub

    Private Sub btnviewdityearlyfees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnviewdityearlyfees.Click
        Dim frmnode As New frmViewEditYearlyFees()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripFees.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripFees.SelectedItem = item
        ETabStripFees.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnlatefees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlatefees.Click
        updatelatefees = False
        Dim frmnode As New frmLateFees()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripFees.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripFees.SelectedItem = item
        ETabStripFees.SelectedItem.Image = Global.Umbrella.My.Resources.Late_Fees
    End Sub

    Private Sub btnvieweditlatefees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditlatefees.Click
        Dim frmnode As New frmViewEditLateFees()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripFees.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripFees.SelectedItem = item
        ETabStripFees.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnexamfees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexamfees.Click
        updateexamfees = False
        Dim frmnode As New frmExamFees()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripFees.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripFees.SelectedItem = item
        ETabStripFees.SelectedItem.Image = Global.Umbrella.My.Resources.examination_fees_icon
    End Sub

    Private Sub btnvieweditexamfees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditexamfees.Click
        Dim frmnode As New frmViewEditExamFees()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripFees.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripFees.SelectedItem = item
        ETabStripFees.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnotherfees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnotherfees.Click
        updateotherfees = False
        Dim frmnode As New frmOtherFees()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripFees.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripFees.SelectedItem = item
        ETabStripFees.SelectedItem.Image = Global.Umbrella.My.Resources.other_fees_icon
    End Sub

    Private Sub btnvieweditotherfees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditotherfees.Click
        Dim frmnode As New frmViewEditOtherFees()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripFees.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripFees.SelectedItem = item
        ETabStripFees.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btndiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndiscount.Click
        updatediscount = False
        Dim frmnode As New frmDiscount()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripFees.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripFees.SelectedItem = item
        ETabStripFees.SelectedItem.Image = Global.Umbrella.My.Resources.discount_offer
    End Sub

    Private Sub btnvieweditdiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditdiscount.Click
        Dim frmnode As New frmViewEditDiscount()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripFees.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripFees.SelectedItem = item
        ETabStripFees.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnfinancialloan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfinancialloan.Click
        updatefinancial = False
        Dim frmnode As New frmFinancial()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripFees.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripFees.SelectedItem = item
        ETabStripFees.SelectedItem.Image = Global.Umbrella.My.Resources.financial_loan_icon
    End Sub

    Private Sub btnvieweditfinancialloan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditfinancialloan.Click
        Dim frmnode As New frmViewEditFinancialLoan()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripFees.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripFees.SelectedItem = item
        ETabStripFees.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnincomeexpenditure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnincomeexpenditure.Click
        Dim frmnode As New frmIncomeExpenditure()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripFees.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripFees.SelectedItem = item
        ETabStripFees.SelectedItem.Image = Global.Umbrella.My.Resources.income_expenditure_icon
    End Sub

    Private Sub btnaccountingmanagement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaccountingmanagement.Click
        updatebankdeposit = False
        Dim frmnode As New frmAccountingManagement()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripFees.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripFees.SelectedItem = item
        ETabStripFees.SelectedItem.Image = Global.Umbrella.My.Resources.accounting_management_icon
    End Sub

    Private Sub btnvieweditbankdeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditbankdeposit.Click
        Dim frmnode As New frmViewEditBankDeposit()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripFees.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripFees.SelectedItem = item
        ETabStripFees.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btncalculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculator.Click
        Dim frm As New frmCalculator()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.Show()
    End Sub

    Private Sub btnreportsfees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreportsfees.Click
        InstituteReports = "Fees"
        Dim frm As New frmShowReports()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.Show()
    End Sub
#End Region
#Region "Examination Menu..."
    Private Sub btncoursesubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncoursesubject.Click
        updatesubject = False
        Dim frmnode As New frmSubjects()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripExam.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripExam.SelectedItem = item
        ETabStripExam.SelectedItem.Image = Global.Umbrella.My.Resources.course_icon
    End Sub

    Private Sub btnvieweditcoursesubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditcoursesubject.Click
        Dim frmnode As New frmViewEditSubjects()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripExam.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripExam.SelectedItem = item
        ETabStripExam.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnsyllabus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsyllabus.Click
        updatesyllabus = False
        Dim frmnode As New frmSyllabus()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripExam.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripExam.SelectedItem = item
        ETabStripExam.SelectedItem.Image = Global.Umbrella.My.Resources.syllabus
    End Sub

    Private Sub btnvieweditsyllabus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditsyllabus.Click
        Dim frmnode As New frmViewEditSyllabus()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripExam.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripExam.SelectedItem = item
        ETabStripExam.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnvieweditassignment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditassignment.Click
        updateassignment = False
        Dim frmnode As New frmAssignments()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripExam.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripExam.SelectedItem = item
        ETabStripExam.SelectedItem.Image = Global.Umbrella.My.Resources.assignment
    End Sub

    Private Sub btnvieweditasignment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditasignment.Click
        Dim frmnode As New frmViewEditAssignment()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripExam.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripExam.SelectedItem = item
        ETabStripExam.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btncourse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncourse.Click
        Dim frmnode As New frmCourse()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripExam.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripExam.SelectedItem = item
        ETabStripExam.SelectedItem.Image = Global.Umbrella.My.Resources.course_icon
    End Sub

    Private Sub btnexam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexam.Click
        updateexamination = False
        Dim frmnode As New frmExaminations()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripExam.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripExam.SelectedItem = item
        ETabStripExam.SelectedItem.Image = Global.Umbrella.My.Resources.examination_icon
    End Sub

    Private Sub btnvieweditexam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditexam.Click
        Dim frmnode As New frmViewEditExaminations()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripExam.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripExam.SelectedItem = item
        ETabStripExam.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnonlineexam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnonlineexam.Click
        updateonlineqsn = False
        Dim frmnode As New frmOnlineExamQsn()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripExam.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripExam.SelectedItem = item
        ETabStripExam.SelectedItem.Image = Global.Umbrella.My.Resources.examination_icon
    End Sub

    Private Sub btnvieweditonlineexam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditonlineexam.Click
        Dim frmnode As New frmViewEditOnlineExamQsn()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripExam.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripExam.SelectedItem = item
        ETabStripExam.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnviewonlineexamresult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnviewonlineexamresult.Click
        Dim frmnode As New frmViewEditOnlineExamination()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripExam.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripExam.SelectedItem = item
        ETabStripExam.SelectedItem.Image = Global.Umbrella.My.Resources.online_exam
    End Sub

    Private Sub btnprogressreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprogressreport.Click
        updateprogessreport = False
        Dim frmnode As New frmProgressReport()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripExam.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripExam.SelectedItem = item
        ETabStripExam.SelectedItem.Image = Global.Umbrella.My.Resources.progress_bar
    End Sub

    Private Sub btnvieweditprogressreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditprogressreport.Click
        Dim frmnode As New frmViewEditProgressReport()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripExam.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripExam.SelectedItem = item
        ETabStripExam.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnmarksheets_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmarksheets.Click
        updatemarksheet = False
        Dim frmnode As New frmMarksheets()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripExam.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripExam.SelectedItem = item
        ETabStripExam.SelectedItem.Image = Global.Umbrella.My.Resources.marksheets
    End Sub

    Private Sub btnvieweditmarksheets_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditmarksheets.Click
        Dim frmnode As New frmViewEditMarksheets()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripExam.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripExam.SelectedItem = item
        ETabStripExam.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnstudentcontrol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstudentcontrol.Click
        updatestudentcontrol = False
        Dim frmnode As New frmStudentControlPanel()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripExam.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripExam.SelectedItem = item
        ETabStripExam.SelectedItem.Image = Global.Umbrella.My.Resources.control_panel_icon
    End Sub

    Private Sub btnvieweditstudentcontrol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditstudentcontrol.Click
        Dim frmnode As New frmViewEditStudentControl()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripExam.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripExam.SelectedItem = item
        ETabStripExam.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnreportsexam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreportsexam.Click
        InstituteReports = "Examination"
        Dim frm As New frmShowReports()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.Show()
    End Sub
#End Region
#Region "Activity Menu"
    Private Sub btnaccesswebsite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaccesswebsite.Click
        Try
            cmd.CommandText = "select url1 from institute where insid='" & My.Settings.LastOpenedInstituteID & "' and insname='" & My.Settings.LastOpenedInstitute & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                System.Diagnostics.Process.Start(retVal, dr("url1").ToString())
            Else
                System.Diagnostics.Process.Start(retVal, "http://www.google.co.in/")
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub btnaccessforum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaccessforum.Click
        Try
            cmd.CommandText = "select url2 from institute where insid='" & My.Settings.LastOpenedInstituteID & "' and insname='" & My.Settings.LastOpenedInstitute & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                System.Diagnostics.Process.Start(retVal, dr("url2").ToString())
            Else
                System.Diagnostics.Process.Start(retVal, "http://www.google.co.in/")
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub btnlocalchat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlocalchat.Click
        Dim frm As New frmClient()
        frm.Show()
    End Sub

    Private Sub btnalumni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalumni.Click
        Dim frmnode As New frmAlumni()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripActivity.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripActivity.SelectedItem = item
        ETabStripActivity.SelectedItem.Image = Global.Umbrella.My.Resources.alumni_icon
    End Sub

    Private Sub btncertificatestudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncertificatestudent.Click
        updatecertificate = False
        Dim frmnode As New frmCertificateStudent()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripActivity.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripActivity.SelectedItem = item
        ETabStripActivity.SelectedItem.Image = Global.Umbrella.My.Resources.certificate
    End Sub

    Private Sub btnvieweditcertificates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditcertificates.Click
        Dim frmnode As New frmViewEditCertificateStudent()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripActivity.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripActivity.SelectedItem = item
        ETabStripActivity.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btncertificateemployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncertificateemployee.Click
        updatecertificate = False
        Dim frmnode As New frmCertificateEmployee()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripActivity.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripActivity.SelectedItem = item
        ETabStripActivity.SelectedItem.Image = Global.Umbrella.My.Resources.certificate
    End Sub

    Private Sub btnvieweditcertificateemployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditcertificateemployee.Click
        Dim frmnode As New frmViewEdit_CertificateEmployee()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripActivity.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripActivity.SelectedItem = item
        ETabStripActivity.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnaddinventoryitems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddinventoryitems.Click
        updateinventory = False
        Dim frmnode As New frmAddInventoryItem()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripActivity.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripActivity.SelectedItem = item
        ETabStripActivity.SelectedItem.Image = Global.Umbrella.My.Resources.inventory_icon
    End Sub

    Private Sub btnvieweditinventoryitems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditinventoryitems.Click
        Dim frmnode As New frmViewEditInventoryItems()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripActivity.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripActivity.SelectedItem = item
        ETabStripActivity.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnpurchaseorders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpurchaseorders.Click
        updatepurchase = False
        Dim frmnode As New frmPurchase()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripActivity.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripActivity.SelectedItem = item
        ETabStripActivity.SelectedItem.Image = Global.Umbrella.My.Resources.purchase_orders
    End Sub

    Private Sub btnvieweditpurchaseorders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditpurchaseorders.Click
        Dim frmnode As New frmViewEditPurchaseOrder()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripActivity.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripActivity.SelectedItem = item
        ETabStripActivity.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btninventorycount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninventorycount.Click
        Dim frmnode As New frmInventoryCount()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripActivity.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripActivity.SelectedItem = item
        ETabStripActivity.SelectedItem.Image = Global.Umbrella.My.Resources.inventory_count
    End Sub

    Private Sub btnsalesinvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalesinvoice.Click
        updateinvoice = False
        Dim frmnode As New frmSalesInvoice()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripActivity.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripActivity.SelectedItem = item
        ETabStripActivity.SelectedItem.Image = Global.Umbrella.My.Resources.Sales_Invoice
    End Sub

    Private Sub btnvieweditsalesinvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditsalesinvoice.Click
        Dim frmnode As New frmViewEditSalesInvoice()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripActivity.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripActivity.SelectedItem = item
        ETabStripActivity.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btngames_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngames.Click
        updategame = False
        Dim frmnode As New frmGames()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripActivity.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripActivity.SelectedItem = item
        ETabStripActivity.SelectedItem.Image = Global.Umbrella.My.Resources.games_icon
    End Sub

    Private Sub btnvieweditgames_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditgames.Click
        Dim frmnode As New frmViewEditGames()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripActivity.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripActivity.SelectedItem = item
        ETabStripActivity.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnbirthday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbirthday.Click
        Dim frmnode As New frmBirthday()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripActivity.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripActivity.SelectedItem = item
        ETabStripActivity.SelectedItem.Image = Global.Umbrella.My.Resources.birthday_icon
    End Sub

    Private Sub btnreportactivity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreportactivity.Click
        InstituteReports = "Activity"
        Dim frm As New frmShowReports()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.Show()
    End Sub
#End Region
#Region "Side Menu..."
    Private Sub btnsettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsettings.Click
        Dim frm As New frmGlobalSettings()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub btntransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntransaction.Click
        Dim frm As New frmFindTransaction()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub btnlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlock.Click
        Dim frm As New frmLockScreen()
        frm.ShowDialog()
    End Sub

    Private Sub btnsetupdefaults_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsetupdefaults.ClickButtonArea
        Dim frm As New frmSetupDefaultsInstitute()
        frm.ShowDialog()
    End Sub

    Private Sub btninstitutestatus_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btninstitutestatus.ClickButtonArea
        Dim frm As New frmInstituteStatus()
        frm.WindowState = FormWindowState.Normal
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ControlBox = True
        frm.Show()
    End Sub
#End Region
#End Region
#Region "Methods..."
    Private Sub LoadDefaultPage()
        If My.Settings.InstituteDefaultPage = TabPageActivity.Text Then
            TabControl1.SelectTab(TabPageActivity)
            btndefaultactivity.ForeColor = Color.Yellow
            btndefaultactivity.Text = "This Is Your Default Page"
        ElseIf My.Settings.InstituteDefaultPage = TabPageAdmission.Text Then
            TabControl1.SelectTab(TabPageAdmission)
            btndefaultadmission.ForeColor = Color.Yellow
            btndefaultadmission.Text = "This Is Your Default Page"
        ElseIf My.Settings.InstituteDefaultPage = TabPageFees.Text Then
            TabControl1.SelectTab(TabPageFees)
            btndefaultfees.ForeColor = Color.Yellow
            btndefaultfees.Text = "This Is Your Default Page"
        ElseIf My.Settings.InstituteDefaultPage = TabPageExamination.Text Then
            TabControl1.SelectTab(TabPageExamination)
            btndefaultexam.ForeColor = Color.Yellow
            btndefaultexam.Text = "This Is Your Default Page"
        ElseIf My.Settings.InstituteDefaultPage = TabPageInstitute.Text Then
            TabControl1.SelectTab(TabPageInstitute)
            btndefaultsystem.ForeColor = Color.Yellow
            btndefaultsystem.Text = "This Is Your Default Page"
        Else
            btndefaultactivity.Text = "Make This Your Default Page"
            btndefaultactivity.ForeColor = Color.White
            btndefaultadmission.Text = "Make This Your Default Page"
            btndefaultadmission.ForeColor = Color.White
            btndefaultfees.Text = "Make This Your Default Page"
            btndefaultfees.ForeColor = Color.White
            btndefaultexam.Text = "Make This Your Default Page"
            btndefaultexam.ForeColor = Color.White
            btndefaultsystem.Text = "Make This Your Default Page"
            btndefaultsystem.ForeColor = Color.White
        End If
    End Sub

    Private Sub LoadPanel()
        If My.Settings.InstituteActivityPanel = "Show" Then
            SplitContainerActivity.Visible = True
            btnhideactivity.ForeColor = Color.White
            btnhideactivity.Text = "Hide"
            btnhideactivity.Image = Global.Umbrella.My.Resources.collapseIcon
        Else
            SplitContainerActivity.Visible = False
            btnhideactivity.ForeColor = Color.SteelBlue
            btnhideactivity.Text = "Show"
            btnhideactivity.Image = Global.Umbrella.My.Resources.expandIcon
        End If
        If My.Settings.InstituteExaminationPanel = "Show" Then
            SplitContainerExam.Visible = True
            btnhideexam.ForeColor = Color.White
            btnhideexam.Text = "Hide"
            btnhideexam.Image = Global.Umbrella.My.Resources.collapseIcon
        Else
            SplitContainerExam.Visible = False
            btnhideexam.ForeColor = Color.SteelBlue
            btnhideexam.Text = "Show"
            btnhideexam.Image = Global.Umbrella.My.Resources.expandIcon
        End If
        If My.Settings.InstituteFeesPanel = "Show" Then
            SplitContainerFees.Visible = True
            btnhidefees.ForeColor = Color.White
            btnhidefees.Text = "Hide"
            btnhidefees.Image = Global.Umbrella.My.Resources.collapseIcon
        Else
            SplitContainerFees.Visible = False
            btnhidefees.ForeColor = Color.SteelBlue
            btnhidefees.Text = "Show"
            btnhidefees.Image = Global.Umbrella.My.Resources.expandIcon
        End If
        If My.Settings.InstituteAdmissionPanel = "Show" Then
            SplitContainerAdmission.Visible = True
            btnhideadmission.ForeColor = Color.White
            btnhideadmission.Text = "Hide"
            btnhideadmission.Image = Global.Umbrella.My.Resources.collapseIcon
        Else
            SplitContainerAdmission.Visible = False
            btnhideadmission.ForeColor = Color.SteelBlue
            btnhideadmission.Text = "Show"
            btnhideadmission.Image = Global.Umbrella.My.Resources.expandIcon
        End If
        If My.Settings.InstituteSystemPanel = "Show" Then
            SplitContainerSystem.Visible = True
            btnhidesystem.ForeColor = Color.White
            btnhidesystem.Text = "Hide"
            btnhidesystem.Image = Global.Umbrella.My.Resources.collapseIcon
        Else
            SplitContainerSystem.Visible = False
            btnhidesystem.ForeColor = Color.SteelBlue
            btnhidesystem.Text = "Show"
            btnhidesystem.Image = Global.Umbrella.My.Resources.expandIcon
        End If
    End Sub

    Private Sub LoadDate()
        btndateactivity.Text = "System Date: " + UmbrellaSystemDate
        btndateadmission.Text = "System Date: " + UmbrellaSystemDate
        btndateexam.Text = "System Date: " + UmbrellaSystemDate
        btndatefees.Text = "System Date: " + UmbrellaSystemDate
        btndatesystem.Text = "System Date: " + UmbrellaSystemDate
    End Sub

    Private Sub LoadPeriod()
        Try
            Dim index As Integer = 0

            cmd.CommandText = "select StartingMonth from Institute where InsName='" & My.Settings.LastOpenedInstitute & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            cstartingmonth = dr("StartingMonth").ToString()
            dr.Close()

            If cstartingmonth = "January" Then

                Dim mm As Integer = Date.Now.Month

                If mm = 1 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=1"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 2 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=2"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 3 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=3"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 4 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=4"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 5 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=5"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 6 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=6"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 7 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=7"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 8 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=8"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 9 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=9"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 10 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=10"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 11 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=11"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 12 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=12"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                End If
            ElseIf cstartingmonth = "February" Then

                Dim mm As Integer = Date.Now.Month

                If mm = 1 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=12"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 2 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=1"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 3 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=2"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 4 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=3"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 5 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=4"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 6 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=5"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 7 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=6"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 8 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=7"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 9 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=8"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 10 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=9"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 11 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=10"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 12 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=11"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                End If
            ElseIf cstartingmonth = "March" Then

                Dim mm As Integer = Date.Now.Month

                If mm = 1 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=11"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 2 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=12"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 3 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=1"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 4 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=2"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 5 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=3"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 6 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=4"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 7 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=5"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 8 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=6"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 9 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=7"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 10 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=8"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 11 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=9"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 12 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=10"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                End If
            ElseIf cstartingmonth = "April" Then

                Dim mm As Integer = Date.Now.Month

                If mm = 1 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=10"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 2 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=11"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 3 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=12"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 4 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=1"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 5 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=2"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 6 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=3"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 7 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=4"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 8 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=5"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 9 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=6"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 10 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=7"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 11 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=8"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 12 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=9"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                End If
            ElseIf cstartingmonth = "May" Then

                Dim mm As Integer = Date.Now.Month

                If mm = 1 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=9"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 2 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=10"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 3 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=11"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 4 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=12"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 5 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=1"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 6 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=2"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 7 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=3"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 8 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=4"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 9 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=5"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 10 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=6"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 11 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=7"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 12 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=8"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                End If

            ElseIf cstartingmonth = "June" Then

                Dim mm As Integer = Date.Now.Month

                If mm = 1 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=8"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 2 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=9"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 3 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=10"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 4 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=11"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 5 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=12"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 6 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=1"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 7 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=2"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 8 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=3"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 9 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=4"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 10 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=5"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 11 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=6"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 12 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=7"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                End If

            ElseIf cstartingmonth = "July" Then

                Dim mm As Integer = Date.Now.Month

                If mm = 1 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=7"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 2 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=8"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 3 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=9"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 4 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=10"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 5 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=11"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 6 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=12"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 7 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=1"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 8 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=2"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 9 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=3"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 10 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=4"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 11 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=5"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 12 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=6"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                End If
            ElseIf cstartingmonth = "August" Then

                Dim mm As Integer = Date.Now.Month

                If mm = 1 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=6"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 2 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=7"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 3 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=8"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 4 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=9"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 5 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=10"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 6 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=11"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 7 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=12"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 8 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=1"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 9 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=2"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 10 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=3"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 11 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=4"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 12 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=5"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                End If

            ElseIf cstartingmonth = "September" Then

                Dim mm As Integer = Date.Now.Month

                If mm = 1 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=5"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 2 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=6"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 3 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=7"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 4 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=8"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 5 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=9"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 6 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=10"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 7 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=11"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 8 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=12"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 9 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=1"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 10 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=2"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 11 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=3"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 12 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=4"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                End If

            ElseIf cstartingmonth = "October" Then

                Dim mm As Integer = Date.Now.Month

                If mm = 1 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=4"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 2 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=5"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 3 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=6"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 4 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=7"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 5 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=8"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 6 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=9"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 7 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=10"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 8 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=11"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 9 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=12"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 10 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=1"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 11 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=2"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 12 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=3"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                End If

            ElseIf cstartingmonth = "November" Then

                Dim mm As Integer = Date.Now.Month

                If mm = 1 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=3"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 2 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=4"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 3 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=5"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 4 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=6"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 5 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=7"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 6 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=8"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 7 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=9"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 8 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=10"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 9 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=11"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 10 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=12"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 11 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=1"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 12 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=2"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                End If

            ElseIf cstartingmonth = "December" Then

                Dim mm As Integer = Date.Now.Month

                If mm = 1 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=2"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 2 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=3"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 3 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=4"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 4 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=5"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 5 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=6"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 6 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=7"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 7 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=8"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 8 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=9"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 9 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=10"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 10 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=11"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 11 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=12"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 12 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=1"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                End If

            End If

            btnperiodactivity.Text += periodvalue.ToString()
            btnperiodadmission.Text += periodvalue.ToString()
            btnperiodexam.Text += periodvalue.ToString()
            btnperiodfees.Text += periodvalue.ToString()
            btnperiodsystem.Text += periodvalue.ToString()

            My.Settings.FinancialPeriod = periodvalue.ToString()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadInstituteDefault()
        Try
            cmd.CommandText = "select * from DefaultInstitute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                If dr("autoid").ToString() = "Yes" Then
                    ISDAutoID = "Yes"
                Else
                    ISDAutoID = "No"
                End If
                ISDFeesMonth = CInt(dr("feesmonth").ToString())
                ISDApplyDiscount = dr("applydiscount").ToString()
                If dr("alwayspurchase").ToString() = "Yes" Then
                    ISDAlwaysPurchase = "Yes"
                Else
                    ISDAlwaysPurchase = "No"
                End If
                ISDInvoiceMessage = dr("invoicemessage").ToString()
                ISDOrderMessage = dr("ordermessage").ToString()
                ISDGameExpense = dr("gameexpense").ToString()
                ISDCustomField1 = dr("customfield1").ToString()
                ISDCustomField2 = dr("customfield2").ToString()
                ISDCustomField3 = dr("customfield3").ToString()
                ISDCustomField4 = dr("customfield4").ToString()
                ISDCustomField5 = dr("customfield5").ToString()
                If dr("checkcustomfield1").ToString() = "Yes" Then
                    ISDCheckCustomField1 = "Yes"
                Else
                    ISDCheckCustomField1 = "No"
                End If
                If dr("checkcustomfield2").ToString() = "Yes" Then
                    ISDCheckCustomField2 = "Yes"
                Else
                    ISDCheckCustomField2 = "No"
                End If
                If dr("checkcustomfield3").ToString() = "Yes" Then
                    ISDCheckCustomField3 = "Yes"
                Else
                    ISDCheckCustomField3 = "No"
                End If
                If dr("checkcustomfield4").ToString() = "Yes" Then
                    ISDCheckCustomField4 = "Yes"
                Else
                    ISDCheckCustomField4 = "No"
                End If
                If dr("checkcustomfield5").ToString() = "Yes" Then
                    ISDCheckCustomField5 = "Yes"
                Else
                    ISDCheckCustomField5 = "No"
                End If
                ISDCostMethod = dr("costmethod").ToString()
                ISDStockGLSalesAccount = dr("stockglsalesacc").ToString()
                ISDStockGLInvAccount = dr("stockglinvacc").ToString()
                ISDStockGLCostAccount = dr("stockglcostacc").ToString()
                ISDStockCostingAccount = dr("stockcostingacc").ToString()
                ISDMasterGLSalesAccount = dr("masterglsalesacc").ToString()
                ISDMasterGLInvAccount = dr("masterglinvacc").ToString()
                ISDMasterGLCostAccount = dr("masterglcostacc").ToString()
                ISDMasterCostingAccount = dr("mastercostingacc").ToString()
                ISDNonStockGLSalesAccount = dr("nonstockglsalesacc").ToString()
                ISDNonStockGLInvAccount = dr("nonstockglinvacc").ToString()
                ISDNonStockGLCostAccount = dr("nonstockglcostacc").ToString()
                ISDNonStockCostingAccount = dr("nonstockcostingacc").ToString()
                ISDDescriptionGLSalesAccount = dr("descriptionglsalesacc").ToString()
                ISDDescriptionGLInvAccount = dr("descriptionglinvacc").ToString()
                ISDDescriptionGLCostAccount = dr("descriptionglcostacc").ToString()
                ISDDescriptionCostingAccount = dr("descriptioncostingacc").ToString()
                ISDServiceGLSalesAccount = dr("serviceglsalesacc").ToString()
                ISDServiceGLInvAccount = dr("serviceglinvacc").ToString()
                ISDServiceGLCostAccount = dr("serviceglcostacc").ToString()
                ISDServiceCostingAccount = dr("servicecostingacc").ToString()
                ISDLaborGLSalesAccount = dr("laborglsalesacc").ToString()
                ISDLaborGLInvAccount = dr("laborglinvacc").ToString()
                ISDLaborGLCostAccount = dr("laborglcostacc").ToString()
                ISDLaborCostingAccount = dr("laborcostingacc").ToString()
                ISDAssemblyGLSalesAccount = dr("assemblyglsalesacc").ToString()
                ISDAssemblyGLInvAccount = dr("assemblyglinvacc").ToString()
                ISDAssemblyGLCostAccount = dr("assemblyglcostacc").ToString()
                ISDAssemblyCostingAccount = dr("assemblycostingacc").ToString()
                ISDActivityGLSalesAccount = dr("activitylsalesacc").ToString()
                ISDActivityGLInvAccount = dr("activityglinvacc").ToString()
                ISDActivityGLCostAccount = dr("activityglcostacc").ToString()
                ISDActivityCostingAccount = dr("activitycostingacc").ToString()
                ISDChargeGLSalesAccount = dr("chargeglsalesacc").ToString()
                ISDChargeGLInvAccount = dr("chargeglinvacc").ToString()
                ISDChargeGLCostAccount = dr("chargeglcostacc").ToString()
                ISDChargeCostingAccount = dr("chargecostingacc").ToString()
                ISDGLFreightAccount = dr("glfreightacc").ToString()
                ISDMonthlyFeesAccount = dr("monthlyfeesacc").ToString()
                ISDYearlyFeesAccount = dr("yearlyfeesacc").ToString()
                ISDLibraryFeesAccount = dr("libraryfeesacc").ToString()
                ISDLateFeesAccount = dr("latefeesacc").ToString()
                ISDOtherFeesAccount = dr("otherfeesacc").ToString()
                ISDExamFeesAccount = dr("examfeesacc").ToString()
                ISDDiscountFeesAccount = dr("discountfeesacc").ToString()
                ISDBankDepositAccount = dr("bankdepositacc").ToString()
                ISDPurchaseOrderAccount = dr("purchaseorderacc").ToString()
                ISDSalesInvoiceAccount = dr("salesinvoiceacc").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadUserSecurity()
        If USemployeeinfo = "No Access" Then
            btnemployee.Enabled = False
            btnhiredemployee.Enabled = False
            btnvieweditemployee.Enabled = False
            btnviewedithiredemployee.Enabled = False
        End If
        If USattendances = "No Access" Then
            btnstudentattendance.Enabled = False
            btnstaffattendance.Enabled = False
            btnvieweditstaffattendance.Enabled = False
            btnvieweditstudentattendance.Enabled = False
        End If
        If USnotices = "No Access" Then
            btnnotice.Enabled = False
            btnvieweditnotice.Enabled = False
        End If
        If USidcard = "No Access" Then
            btnidcard.Enabled = False
            btnvieweditidcard.Enabled = False
        End If
        If USadmission = "No Access" Then
            btnstudentadmission.Enabled = False
            btnvieweditstudentadmission.Enabled = False
        End If
        If USpreadmission = "No Access" Then
            btnstudentpreadmission.Enabled = False
            btnvieweditstudentpreadmission.Enabled = False
        End If
        If USregistration = "No Access" Then
            btnstudentregistration.Enabled = False
            btnvieweditstudentregistration.Enabled = False
        End If
        If USfeesterms = "No Access" Then
            btntermsfees.Enabled = False
        End If
        If USfeescollection = "No Access" Then
            btndrpfeescollection.Enabled = False
        End If
        If USdiscount = "No Access" Then
            btndiscount.Enabled = False
            btnvieweditdiscount.Enabled = False
        End If
        If USfinancialloan = "No Access" Then
            btnfinancialloan.Enabled = False
            btnvieweditfinancialloan.Enabled = False
        End If
        If USincomeexpenditure = "No Access" Then
            btnincomeexpenditure.Enabled = False
        End If
        If USaccounting = "No Access" Then
            btnaccountingmanagement.Enabled = False
            btnvieweditbankdeposit.Enabled = False
        End If
        If UScoursesubject = "No Access" Then
            btndrpcoursesubject.Enabled = False
        End If
        If USexamination = "No Access" Then
            btndrpexam.Enabled = False
        End If
        If USprogressreport = "No Access" Then
            btnprogressreport.Enabled = False
            btnvieweditprogressreport.Enabled = False
        End If
        If USmarksheet = "No Access" Then
            btnmarksheets.Enabled = False
            btnvieweditmarksheets.Enabled = False
        End If
        If USstudentcontrol = "No Access" Then
            btnstudentcontrol.Enabled = False
            btnvieweditstudentcontrol.Enabled = False
        End If
        If USglobalaccess = "No Access" Then
            btndrpglobalaccess.Enabled = False
        End If
        If USmessenger = "No Access" Then
            btnlocalchat.Enabled = False
        End If
        If USalumni = "No Access" Then
            btnalumni.Enabled = False
        End If
        If UScertificates = "No Access" Then
            btncertificateemployee.Enabled = False
            btncertificatestudent.Enabled = False
            btnvieweditcertificateemployee.Enabled = False
            btnvieweditcertificates.Enabled = False
        End If
        If USinventory = "No Access" Then
            btnaddinventoryitems.Enabled = False
            btnvieweditinventoryitems.Enabled = False
            btninventorycount.Enabled = False
        End If
        If USpurchaseorder = "No Access" Then
            btnpurchaseorders.Enabled = False
            btnvieweditpurchaseorders.Enabled = False
        End If
        If USsalesinvoice = "No Access" Then
            btnsalesinvoice.Enabled = False
            btnvieweditsalesinvoice.Enabled = False
        End If
        If USgames = "No Access" Then
            btngames.Enabled = False
            btnvieweditgames.Enabled = False
        End If
        If USInstituteDefault = "No Access" Then
            btnsetupdefaults.Enabled = False
        End If
    End Sub

    Private Sub DateValueUpdated(ByVal sender As Object, ByVal e As ValueUpdatedEventArgs) Handles childA.ValueUpdated
        Me.btndateactivity.Text = "System Date: " + e.NewValue
        Me.btndateadmission.Text = "System Date: " + e.NewValue
        Me.btndateexam.Text = "System Date: " + e.NewValue
        Me.btndatefees.Text = "System Date: " + e.NewValue
        Me.btndatesystem.Text = "System Date: " + e.NewValue
    End Sub

    Private Sub PeriodValueUpdated(ByVal sender As Object, ByVal e As ValueUpdatedEventArgs) Handles childB.ValueUpdated
        Me.btnperiodactivity.Text = "Period: " + e.NewValue
        Me.btnperiodadmission.Text = "Period: " + e.NewValue
        Me.btnperiodexam.Text = "Period: " + e.NewValue
        Me.btnperiodfees.Text = "Period: " + e.NewValue
        Me.btnperiodsystem.Text = "Period: " + e.NewValue
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmInstitutionMainForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        My.Settings.Save()
    End Sub

    Private Sub frmInstitutionMainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim frm As New frmMainTask()
        frm.MdiParent = Me.MdiParent
        frm.Show()
    End Sub

    Private Sub frmInstitutionMainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each frmApproval As Form In Me.MdiChildren
            frmApproval.Close()
        Next
        TabControl1.HideTabs = True
        LoadDefaultPage()
        LoadPanel()
        LoadDate()
        LoadPeriod()
        LoadInstituteDefault()
        LoadUserSecurity()
        PanelTask.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
    End Sub
#End Region
#Region "TabStrip Events..."
    'Private Sub ETabStripActivity_TabStripItemClosing(ByVal e As ESAR_Controls.UIControls.TabControl.TabStripItemClosingEventArgs) Handles ETabStripActivity.TabStripItemClosing
    '    If ETabStripActivity.SelectedItem.Title = frmActivityDetails.Text Then
    '        e.Cancel = True
    '    End If
    'End Sub

    'Private Sub ETabStripAdmission_TabStripItemClosing(ByVal e As ESAR_Controls.UIControls.TabControl.TabStripItemClosingEventArgs) Handles ETabStripAdmission.TabStripItemClosing
    '    If ETabStripAdmission.SelectedItem.Title = frmAdmissionDetails.Text Then
    '        e.Cancel = True
    '    End If
    'End Sub

    'Private Sub ETabStripExam_TabStripItemClosing(ByVal e As ESAR_Controls.UIControls.TabControl.TabStripItemClosingEventArgs) Handles ETabStripExam.TabStripItemClosing
    '    If ETabStripExam.SelectedItem.Title = frmExaminationDetails.Text Then
    '        e.Cancel = True
    '    End If
    'End Sub

    'Private Sub ETabStripFees_TabStripItemClosing(ByVal e As ESAR_Controls.UIControls.TabControl.TabStripItemClosingEventArgs) Handles ETabStripFees.TabStripItemClosing
    '    If ETabStripFees.SelectedItem.Title = frmFeesDetails.Text Then
    '        e.Cancel = True
    '    End If
    'End Sub

    'Private Sub ETabStripSystem_TabStripItemClosing(ByVal e As ESAR_Controls.UIControls.TabControl.TabStripItemClosingEventArgs) Handles ETabStripSystem.TabStripItemClosing
    '    If ETabStripSystem.SelectedItem.Title = frmInstitutionDetails.Text Then
    '        e.Cancel = True
    '    End If
    'End Sub
#End Region
End Class
#End Region
#End Region
