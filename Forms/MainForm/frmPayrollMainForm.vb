#Region "frmPayrollMainForm...."
#Region "Imports..."
Imports ESAR_Controls
#End Region
#Region "Class frmPayrollMainForm..."
Public Class frmPayrollMainForm
#Region "WithEvents..."
    Private WithEvents childA As frmChangeSystemDate
    Private WithEvents childB As frmAccountingPeriod
#End Region
#Region "Task Menu..."
    Private Sub btnsystem_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsystem.ClickButtonArea
        TabControl1.SelectTab(TabPageSystem)
        TabPageSystem.Focus()
    End Sub

    Private Sub btnperiodic_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnperiodic.ClickButtonArea
        TabControl1.SelectTab(TabPagePeriodic)
        TabPagePeriodic.Focus()
    End Sub

    Private Sub btnprovidentfund_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnprovidentfund.ClickButtonArea
        TabControl1.SelectTab(TabPageProvidentFund)
        TabPageProvidentFund.Focus()
    End Sub
#End Region
#Region "Header Menu..."
#Region "System Header..."
    Private Sub btndefaultsystem_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndefaultsystem.ClickButtonArea
        My.Settings.PayrollDefaultPage = TabPageSystem.Text
        My.Settings.Save()
        Me.btndefaultsystem.Text = "This is your default page"
        Me.btndefaultpf.Text = "Make this your default page"
        Me.btndefaultperiodic.Text = "Make this your default page"
        Me.btndefaultperiodic.ForeColor = Color.White
        Me.btndefaultpf.ForeColor = Color.White
        Me.btndefaultsystem.ForeColor = Color.Yellow
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
            My.Settings.PayrollSystemPanel = "Hide"
            My.Settings.Save()
        Else
            SplitContainerSystem.Visible = True
            btnhidesystem.Text = "Hide"
            btnhidesystem.Image = Global.Umbrella.My.Resources.collapseIcon
            My.Settings.PayrollSystemPanel = "Show"
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
#Region "Periodic Header..."
    Private Sub btndefaultperiodic_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndefaultperiodic.ClickButtonArea
        My.Settings.PayrollDefaultPage = TabPagePeriodic.Text
        My.Settings.Save()
        Me.btndefaultperiodic.Text = "This is your default page"
        Me.btndefaultpf.Text = "Make this your default page"
        Me.btndefaultsystem.Text = "Make this your default page"
        Me.btndefaultperiodic.ForeColor = Color.Yellow
        Me.btndefaultpf.ForeColor = Color.White
        Me.btndefaultsystem.ForeColor = Color.White
    End Sub

    Private Sub btndateperiodic_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndateperiodic.ClickButtonArea
        Me.childA = New frmChangeSystemDate
        AddHandler childA.ValueUpdated, AddressOf DateValueUpdated

        Me.childA.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.childA.WindowState = FormWindowState.Normal
        Me.childA.StartPosition = FormStartPosition.CenterScreen
        Me.childA.ControlBox = True
        Me.childA.ShowDialog()
    End Sub

    Private Sub btnperiodperiodic_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnperiodperiodic.ClickButtonArea
        Me.childB = New frmAccountingPeriod
        AddHandler childB.ValueUpdated, AddressOf PeriodValueUpdated

        Me.childB.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.childB.WindowState = FormWindowState.Normal
        Me.childB.StartPosition = FormStartPosition.CenterScreen
        Me.childB.ControlBox = True
        Me.childB.ShowDialog()
    End Sub

    Private Sub btnhideperiodic_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhideperiodic.ClickButtonArea
        If btnhideperiodic.Text = "Hide" Then
            SplitContainerperiodic.Visible = False
            btnhideperiodic.Text = "Show"
            btnhideperiodic.Image = Global.Umbrella.My.Resources.expandIcon
            My.Settings.PayrollPeriodicPanel = "Hide"
            My.Settings.Save()
        Else
            SplitContainerperiodic.Visible = True
            btnhideperiodic.Text = "Hide"
            btnhideperiodic.Image = Global.Umbrella.My.Resources.collapseIcon
            My.Settings.PayrollPeriodicPanel = "Show"
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnlogoutperiodic_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnlogoutperiodic.ClickButtonArea
        Dim result As DialogResult = MessageBox.Show("Are you sure to logout?", "Umbrella - Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
#End Region
#Region "Provident Fund Header..."
    Private Sub btndefaultpf_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndefaultpf.ClickButtonArea
        My.Settings.PayrollDefaultPage = TabPageProvidentFund.Text
        My.Settings.Save()
        Me.btndefaultpf.Text = "This is your default page"
        Me.btndefaultsystem.Text = "Make this your default page"
        Me.btndefaultperiodic.Text = "Make this your default page"
        Me.btndefaultperiodic.ForeColor = Color.White
        Me.btndefaultpf.ForeColor = Color.Yellow
        Me.btndefaultsystem.ForeColor = Color.White
    End Sub

    Private Sub btndatepf_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndatepf.ClickButtonArea
        Me.childA = New frmChangeSystemDate
        AddHandler childA.ValueUpdated, AddressOf DateValueUpdated

        Me.childA.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.childA.WindowState = FormWindowState.Normal
        Me.childA.StartPosition = FormStartPosition.CenterScreen
        Me.childA.ControlBox = True
        Me.childA.ShowDialog()
    End Sub

    Private Sub btnperiodpf_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnperiodpf.ClickButtonArea
        Me.childB = New frmAccountingPeriod
        AddHandler childB.ValueUpdated, AddressOf PeriodValueUpdated

        Me.childB.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.childB.WindowState = FormWindowState.Normal
        Me.childB.StartPosition = FormStartPosition.CenterScreen
        Me.childB.ControlBox = True
        Me.childB.ShowDialog()
    End Sub

    Private Sub btnhidepf_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhidepf.ClickButtonArea
        If btnhidepf.Text = "Hide" Then
            SplitContainerpf.Visible = False
            btnhidepf.Text = "Show"
            btnhidepf.Image = Global.Umbrella.My.Resources.expandIcon
            My.Settings.PayrollProvidentFundPanel = "Hide"
            My.Settings.Save()
        Else
            SplitContainerpf.Visible = True
            btnhidepf.Text = "Hide"
            btnhidepf.Image = Global.Umbrella.My.Resources.collapseIcon
            My.Settings.PayrollProvidentFundPanel = "Show"
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnlogoutpf_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnlogoutpf.ClickButtonArea
        Dim result As DialogResult = MessageBox.Show("Are you sure to logout?", "Umbrella - Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
#End Region
#End Region
#Region "Menu Events..."
#Region "System Menu..."
    Private Sub btninstitutiondetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmnode As New frmInstitutionDetails()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.Umbrella_icon
    End Sub

    Private Sub btnreportssystem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreportssystem.Click

    End Sub

    Private Sub btndepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndepartment.Click
        updatedept = False
        Dim frmnode As New frmDepartments()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.Department_Icon
    End Sub

    Private Sub btnvieweditdepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditdepartment.Click
        Dim frmnode As New frmViewEditDepartments()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btndesignation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndesignation.Click
        updatedesig = False
        Dim frmnode As New frmDesignation()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.Designation_Icon
    End Sub

    Private Sub btnvieweditdesignation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditdesignation.Click
        Dim frmnode As New frmViewEditDesignation()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btndahra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndahra.Click
        Dim frmnode As New frmDA_HRA()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.DA_HRA_Icon
    End Sub

    Private Sub btnpayscale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpayscale.Click
        updatepayscale = False
        Dim frmnode As New frmPayScale()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.payscale_icon
    End Sub

    Private Sub btnvieweditpayscale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditpayscale.Click
        Dim frmnode As New frmViewEditPayScale()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnheaders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnheaders.Click
        Dim frmnode As New frmPayslipHeaders()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.header
    End Sub

    Private Sub btnproftax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproftax.Click
        updateprofessionaltax = False
        Dim frmnode As New frmProfessionalTax()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.tax_icon
    End Sub

    Private Sub btnvieweditproftax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditproftax.Click
        Dim frmnode As New frmViewEditProfessionalTax()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnempinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnempinfo.Click
        Dim frmnode As New frmViewEditEmployee()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.employee
    End Sub
#End Region
#Region "Periodic Menu..."
    Private Sub btnpfrate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpfrate.Click
        Dim frmnode As New frmPFRate()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripPeriodic.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripPeriodic.SelectedItem = item
        ETabStripPeriodic.SelectedItem.Image = Global.Umbrella.My.Resources.tax_icon
    End Sub

    Private Sub btnworkinghours_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnworkinghours.Click
        Dim frmnode As New frmWorkingHours()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripPeriodic.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripPeriodic.SelectedItem = item
        ETabStripPeriodic.SelectedItem.Image = Global.Umbrella.My.Resources.working_hours
    End Sub

    Private Sub btnadjust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadjust.Click
        updateadjustmentsdeductions = False
        Dim frmnode As New frmADDEmployeeDetailsAdjust_Deduc_for_a_Month()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripPeriodic.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripPeriodic.SelectedItem = item
        ETabStripPeriodic.SelectedItem.Image = Global.Umbrella.My.Resources.adjustment_deduction_icon
    End Sub

    Private Sub btnvieweditadjust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditadjust.Click
        Dim frmnode As New frmViewEditAdjustmentsDeductions()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripPeriodic.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripPeriodic.SelectedItem = item
        ETabStripPeriodic.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnpaycalculationthis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpaycalculationthis.Click
        Dim frmnode As New frmPayCalculationThisMonth()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripPeriodic.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripPeriodic.SelectedItem = item
        ETabStripPeriodic.SelectedItem.Image = Global.Umbrella.My.Resources.pay_calculation_icon
    End Sub

    Private Sub btnpaycalculationforemployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpaycalculationforemployee.Click
        Dim frmnode As New frmPayCalculationSpecific()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripPeriodic.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripPeriodic.SelectedItem = item
        ETabStripPeriodic.SelectedItem.Image = Global.Umbrella.My.Resources.pay_calculation_icon
    End Sub

    Private Sub btnpayemployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpayemployee.Click
        updatepayemployee = False
        Dim frmnode As New frmPayEmployee()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripPeriodic.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripPeriodic.SelectedItem = item
        ETabStripPeriodic.SelectedItem.Image = Global.Umbrella.My.Resources.pay_money
    End Sub

    Private Sub btnvieweditpayemployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditpayemployee.Click
        Dim frmnode As New frmViewEditPayEmployee()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripPeriodic.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripPeriodic.SelectedItem = item
        ETabStripPeriodic.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnreportsperiodic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreportsperiodic.Click

    End Sub
#End Region
#Region "Provident Fund Menu..."
    Private Sub btnopeningoutstanding_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnopeningoutstanding.Click
        Dim frmnode As New frmPFAddOpeningOutsourcingBalance()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripPF.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripPF.SelectedItem = item
        ETabStripPF.SelectedItem.Image = Global.Umbrella.My.Resources.PF_Icon
    End Sub

    Private Sub btnpfstatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpfstatus.Click
        updatepfrateindividual = False
        Dim frmnode As New frmPFModifyPFRate()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripPF.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripPF.SelectedItem = item
        ETabStripPF.SelectedItem.Image = Global.Umbrella.My.Resources.tax_icon
    End Sub

    Private Sub btnvieweditindivualpfrate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditindivualpfrate.Click
        Dim frmnode As New frmViewEditPFRate()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripPF.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripPF.SelectedItem = item
        ETabStripPF.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnadvancewithdrawal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadvancewithdrawal.Click
        updatepfadvwith = False
        Dim frmnode As New frmPFAdvanceWithdrawal()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripPF.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripPF.SelectedItem = item
        ETabStripPF.SelectedItem.Image = Global.Umbrella.My.Resources.PF_Icon
    End Sub

    Private Sub btnvieweditadvancewithdrawal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditadvancewithdrawal.Click
        Dim frmnode As New frmViewEditPFAdvanceWithdrawal()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripPF.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripPF.SelectedItem = item
        ETabStripPF.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnsubscriptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubscriptions.Click
        Dim frmnode As New frmPFSubscriptionAdvanceRecovery()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripPF.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripPF.SelectedItem = item
        ETabStripPF.SelectedItem.Image = Global.Umbrella.My.Resources.PF_Icon
    End Sub

    Private Sub btndefinepartinterest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndefinepartinterest.Click
        Dim frmnode As New frmPFDefinePartInterest()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripPF.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripPF.SelectedItem = item
        ETabStripPF.SelectedItem.Image = Global.Umbrella.My.Resources.PF_Icon
    End Sub

    Private Sub btnvieweditmembership_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditmembership.Click
        updatepfmembership = False
        Dim frmnode As New frmViewEditMembership()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripPF.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripPF.SelectedItem = item
        ETabStripPF.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnopeningclosing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnopeningclosing.Click
        Dim frmnode As New frmPFOpeningClosingBalanace()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripPF.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripPF.SelectedItem = item
        ETabStripPF.SelectedItem.Image = Global.Umbrella.My.Resources.PF_Icon
    End Sub

    Private Sub btnreportspf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreportspf.Click

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
        Dim frm As New frmSetupDefaultsPayroll()
        frm.ShowDialog()
    End Sub

    Private Sub btnpayrollstatus_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnpayrollstatus.ClickButtonArea
        Dim frm As New frmPayrollStatus()
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
        If My.Settings.PayrollDefaultPage = TabPagePeriodic.Text Then
            TabControl1.SelectTab(TabPagePeriodic)
            btndefaultperiodic.ForeColor = Color.Yellow
            btndefaultperiodic.Text = "This Is Your Default Page"
        ElseIf My.Settings.PayrollDefaultPage = TabPageProvidentFund.Text Then
            TabControl1.SelectTab(TabPageProvidentFund)
            btndefaultpf.ForeColor = Color.Yellow
            btndefaultpf.Text = "This Is Your Default Page"
        ElseIf My.Settings.PayrollDefaultPage = TabPageSystem.Text Then
            TabControl1.SelectTab(TabPageSystem)
            btndefaultsystem.ForeColor = Color.Yellow
            btndefaultsystem.Text = "This Is Your Default Page"
        Else
            btndefaultperiodic.Text = "Make This Your Default Page"
            btndefaultperiodic.ForeColor = Color.Black
            btndefaultpf.Text = "Make This Your Default Page"
            btndefaultpf.ForeColor = Color.Black
            btndefaultsystem.Text = "Make This Your Default Page"
            btndefaultsystem.ForeColor = Color.Black
        End If
    End Sub

    Private Sub LoadPanel()
        If My.Settings.PayrollPeriodicPanel = "Show" Then
            SplitContainerperiodic.Visible = True
            btnhideperiodic.ForeColor = Color.White
            btnhideperiodic.Text = "Hide"
            btnhideperiodic.Image = Global.Umbrella.My.Resources.collapseIcon
        Else
            SplitContainerperiodic.Visible = False
            btnhideperiodic.ForeColor = Color.SteelBlue
            btnhideperiodic.Text = "Show"
            btnhideperiodic.Image = Global.Umbrella.My.Resources.expandIcon
        End If
        If My.Settings.PayrollProvidentFundPanel = "Show" Then
            SplitContainerpf.Visible = True
            btnhidepf.ForeColor = Color.White
            btnhidepf.Text = "Hide"
            btnhidepf.Image = Global.Umbrella.My.Resources.collapseIcon
        Else
            SplitContainerpf.Visible = False
            btnhidepf.ForeColor = Color.SteelBlue
            btnhidepf.Text = "Show"
            btnhidepf.Image = Global.Umbrella.My.Resources.expandIcon
        End If
        If My.Settings.PayrollSystemPanel = "Show" Then
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
        btndateperiodic.Text = "System Date: " + UmbrellaSystemDate
        btndatepf.Text = "System Date: " + UmbrellaSystemDate
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

            btnperiodperiodic.Text += periodvalue.ToString()
            btnperiodpf.Text += periodvalue.ToString()
            btnperiodsystem.Text += periodvalue.ToString()

            My.Settings.FinancialPeriod = periodvalue.ToString()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadPayrollDefaults()
        Try
            cmd.CommandText = "select autoid,salaryaccount,basicincr from DefaultPayroll where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            PSDAutoID = dr("autoid").ToString()
            PSDSalaryAccount = dr("salaryaccount").ToString()
            PSDBasicIncrement = CDec(dr("basicincr").ToString())
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadUserSecurity()
        If USpayrollsystem = "No Access" Then
            btndrpdepartment.Enabled = False
            btndrpdesignation.Enabled = False
            btndrpproftax.Enabled = False
            btndrpdahra.Enabled = False
            btndrppayscale.Enabled = False
            btndrppayslipheaders.Enabled = False
        End If
        If USemployeeinfo = "No Access" Then
            btndrpempinfo.Enabled = False
        End If
        If USpayrollperiodic = "No Access" Then
            btndrpadjust.Enabled = False
            btndrppaycalculation.Enabled = False
            btndrppfrate.Enabled = False
            btndrppayemployee.Enabled = False
            btndrpworkinghours.Enabled = False
        End If
        If USpayrollpf = "No Access" Then
            btndrpopeningoutstanding.Enabled = False
            btndrpsubscription.Enabled = False
            btndrpadvancewithdrawal.Enabled = False
            btndrppfstatus.Enabled = False
            btndrpopeningclosing.Enabled = False
            btndrpmembership.Enabled = False
        End If
        If USPayrollDefault = "No Access" Then
            btnsetupdefaults.Enabled = False
        End If
    End Sub

    Private Sub DateValueUpdated(ByVal sender As Object, ByVal e As ValueUpdatedEventArgs) Handles childA.ValueUpdated
        Me.btndateperiodic.Text = "System Date: " + e.NewValue
        Me.btndatepf.Text = "System Date: " + e.NewValue
        Me.btndatesystem.Text = "System Date: " + e.NewValue
    End Sub

    Private Sub PeriodValueUpdated(ByVal sender As Object, ByVal e As ValueUpdatedEventArgs) Handles childB.ValueUpdated
        Me.btnperiodperiodic.Text = "Period: " + e.NewValue
        Me.btnperiodpf.Text = "Period: " + e.NewValue
        Me.btnperiodsystem.Text = "Period: " + e.NewValue
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmPayrollMainForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        My.Settings.Save()
    End Sub

    Private Sub frmPayrollMainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim frm As New frmMainTask()
        frm.MdiParent = Me.MdiParent
        frm.Show()
    End Sub

    Private Sub frmPayrollMainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each frmApproval As Form In Me.MdiChildren
            frmApproval.Close()
        Next
        TabControl1.HideTabs = True
        LoadDefaultPage()
        LoadPanel()
        LoadDate()
        LoadPeriod()
        LoadPayrollDefaults()
        LoadUserSecurity()
        PanelTask.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
    End Sub
#End Region
#Region "TabStrip Events..."
    Private Sub ETabStripSystem_TabStripItemClosing(ByVal e As ESAR_Controls.UIControls.TabControl.TabStripItemClosingEventArgs) Handles ETabStripSystem.TabStripItemClosing
        Dim count As Integer = ETabStripSystem.Controls.Count
        For i As Integer = 0 To count - 1
            Dim str As String = ETabStripSystem.Items(i).Title.ToString()
            If str = frmInstitutionDetails.Text Then
                e.Cancel = True
            Else
                Exit For
            End If
        Next
    End Sub

    Private Sub ETabStripperiodic_TabStripItemClosing(ByVal e As ESAR_Controls.UIControls.TabControl.TabStripItemClosingEventArgs) Handles ETabStripPeriodic.TabStripItemClosing

    End Sub

    Private Sub ETabStripPF_TabStripItemClosing(ByVal e As ESAR_Controls.UIControls.TabControl.TabStripItemClosingEventArgs) Handles ETabStripPF.TabStripItemClosing

    End Sub
#End Region
End Class
#End Region
#End Region
