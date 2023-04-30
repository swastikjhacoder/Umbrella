#Region "frmLibraryMainForm..."
#Region "Imports..."

#End Region
#Region "Class frmLibraryMainForm..."
Public Class frmLibraryMainForm
#Region "WithEvents..."
    Private WithEvents childA As frmChangeSystemDate
    Private WithEvents childB As frmAccountingPeriod
#End Region
#Region "Task Menu..."
    Private Sub btnsystem_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsystem.ClickButtonArea
        TabControl1.SelectTab(TabPageSystem)
        TabPageSystem.Focus()
    End Sub

    Private Sub btntask_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btntask.ClickButtonArea
        TabControl1.SelectTab(TabPageTask)
        TabPageTask.Focus()
    End Sub
#End Region
#Region "Header Menu..."
#Region "System Header..."
    Private Sub btndefaultsystem_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndefaultsystem.ClickButtonArea
        My.Settings.LibraryDefaultPage = TabPageSystem.Text
        My.Settings.Save()
        Me.btndefaultsystem.Text = "This is your default page"
        Me.btndefaulttask.Text = "Make this your default page"
        Me.btndefaultsystem.ForeColor = Color.Yellow
        Me.btndefaulttask.ForeColor = Color.White
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
#Region "Task Header..."
    Private Sub btndefaulttask_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndefaulttask.ClickButtonArea
        My.Settings.LibraryDefaultPage = TabPageTask.Text
        My.Settings.Save()
        Me.btndefaulttask.Text = "This is your default page"
        Me.btndefaultsystem.Text = "Make this your default page"
        Me.btndefaultsystem.ForeColor = Color.White
        Me.btndefaulttask.ForeColor = Color.Yellow
    End Sub

    Private Sub btndatetask_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndatetask.ClickButtonArea
        Me.childA = New frmChangeSystemDate
        AddHandler childA.ValueUpdated, AddressOf DateValueUpdated

        Me.childA.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.childA.WindowState = FormWindowState.Normal
        Me.childA.StartPosition = FormStartPosition.CenterScreen
        Me.childA.ControlBox = True
        Me.childA.ShowDialog()
    End Sub

    Private Sub btnperiodtask_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnperiodtask.ClickButtonArea
        Me.childB = New frmAccountingPeriod
        AddHandler childB.ValueUpdated, AddressOf PeriodValueUpdated

        Me.childB.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.childB.WindowState = FormWindowState.Normal
        Me.childB.StartPosition = FormStartPosition.CenterScreen
        Me.childB.ControlBox = True
        Me.childB.ShowDialog()
    End Sub

    Private Sub btnhidetask_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhidetask.ClickButtonArea
        If btnhidetask.Text = "Hide" Then
            SplitContainerTask.Visible = False
            btnhidetask.Text = "Show"
            btnhidetask.Image = Global.Umbrella.My.Resources.expandIcon
            My.Settings.InstituteSystemPanel = "Hide"
            My.Settings.Save()
        Else
            SplitContainerTask.Visible = True
            btnhidetask.Text = "Hide"
            btnhidetask.Image = Global.Umbrella.My.Resources.collapseIcon
            My.Settings.InstituteSystemPanel = "Show"
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnlogouttask_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnlogouttask.ClickButtonArea
        Dim result As DialogResult = MessageBox.Show("Are you sure to logout?", "Umbrella - Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
#End Region
#End Region
#Region "Menu Events..."
#Region "System Menu..."
    Private Sub btnreportssystem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreportssystem.Click

    End Sub

    Private Sub btnbooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbooks.Click
        updatebook = False
        Dim frmnode As New frmBooks()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.book_add
    End Sub

    Private Sub btnvieweditbooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditbooks.Click
        Dim frmnode As New frmViewEditBooks()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnsubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubject.Click
        updatesubjectbooks = False
        Dim frmnode As New frmSubject()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.subject
    End Sub

    Private Sub btnvieweditsubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditsubject.Click
        Dim frmnode As New frmViewEditSubject()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btngroups_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngroups.Click
        updategroup = False
        Dim frmnode As New frmGroup()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.group
    End Sub

    Private Sub btnvieweditgroups_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditgroups.Click
        Dim frmnode As New frmViewEditGroup()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.list
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

    Private Sub btnvieweditstudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditstudent.Click
        Dim frmnode As New frmViewEditStudentRegistration()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnidcard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnidcard.Click
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

    Private Sub btncharges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncharges.Click
        updatebookcharge = False
        Dim frmnode As New frmCharges()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.charges_icon
    End Sub

    Private Sub btnvieweditcharges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditcharges.Click
        Dim frmnode As New frmViewEditCharges()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripSystem.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripSystem.SelectedItem = item
        ETabStripSystem.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub
#End Region
#Region "Task Menu..."
    Private Sub btnquerybooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnquerybooks.Click
        Dim frmnode As New frmQueryBooks()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripTask.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripTask.SelectedItem = item
        ETabStripTask.SelectedItem.Image = Global.Umbrella.My.Resources.query_book
    End Sub

    Private Sub btnreportstask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreportstask.Click

    End Sub

    Private Sub btncalculatecharges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculatecharges.Click
        updatecalculatecharge = False
        Dim frmnode As New frmCalculateCharges()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripTask.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripTask.SelectedItem = item
        ETabStripTask.SelectedItem.Image = Global.Umbrella.My.Resources.other_fees_icon
    End Sub

    Private Sub btnvieweditcalculatecharges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditcalculatecharges.Click
        Dim frmnode As New frmViewEditCalculateCharges()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripTask.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripTask.SelectedItem = item
        ETabStripTask.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnreturnbooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreturnbooks.Click
        updatereturnbooks = False
        Dim frmnode As New frmReturnBookss()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripTask.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripTask.SelectedItem = item
        ETabStripTask.SelectedItem.Image = Global.Umbrella.My.Resources.return_book
    End Sub

    Private Sub btnvieweditreturnbooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditreturnbooks.Click
        Dim frmnode As New frmViewEditReturnBooks()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripTask.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripTask.SelectedItem = item
        ETabStripTask.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub

    Private Sub btnissuebooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnissuebooks.Click
        updateissebooks = False
        Dim frmnode As New frmIssueBooks()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripTask.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripTask.SelectedItem = item
        ETabStripTask.SelectedItem.Image = Global.Umbrella.My.Resources.issue_book
    End Sub

    Private Sub btnvieweditissuebooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvieweditissuebooks.Click
        Dim frmnode As New frmViewEditIssueBooks()
        frmnode.TopLevel = False
        Dim item As New ESAR_Controls.UIControls.TabControl.eTabStripItem(frmnode.Text, frmnode)
        ETabStripTask.AddTab(item)
        frmnode.Location = New Point(0, 0)
        frmnode.Show()
        ETabStripTask.SelectedItem = item
        ETabStripTask.SelectedItem.Image = Global.Umbrella.My.Resources.list
    End Sub
#End Region
#End Region
#Region "Methods..."
    Private Sub LoadDefaultPage()
        If My.Settings.LibraryDefaultPage = TabPageTask.Text Then
            TabControl1.SelectTab(TabPageTask)
            btndefaulttask.ForeColor = Color.Yellow
            btndefaulttask.Text = "This Is Your Default Page"
        ElseIf My.Settings.LibraryDefaultPage = TabPageSystem.Text Then
            TabControl1.SelectTab(TabPageSystem)
            btndefaultsystem.ForeColor = Color.Yellow
            btndefaultsystem.Text = "This Is Your Default Page"
        Else
            btndefaulttask.Text = "Make This Your Default Page"
            btndefaulttask.ForeColor = Color.White
            btndefaultsystem.Text = "Make This Your Default Page"
            btndefaultsystem.ForeColor = Color.White
        End If
    End Sub

    Private Sub LoadPanel()
        If My.Settings.LibraryTaskPanel = "Show" Then
            SplitContainerTask.Visible = True
            btnhidetask.ForeColor = Color.White
            btnhidetask.Text = "Hide"
            btnhidetask.Image = Global.Umbrella.My.Resources.collapseIcon
        Else
            SplitContainerTask.Visible = False
            btnhidetask.ForeColor = Color.SteelBlue
            btnhidetask.Text = "Show"
            btnhidetask.Image = Global.Umbrella.My.Resources.expandIcon
        End If
        If My.Settings.LibrarySystemPanel = "Show" Then
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
        btndatetask.Text = "System Date: " + UmbrellaSystemDate
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

            btnperiodtask.Text += periodvalue.ToString()
            btnperiodsystem.Text += periodvalue.ToString()

            My.Settings.FinancialPeriod = periodvalue.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadLibraryDefaults()
        Try
            cmd.CommandText = "select autoid,chargesaccount from DefaultLibrary where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            LSDAutoID = dr("autoid").ToString()
            LSDChargesAccount = dr("chargesaccount").ToString()
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadUserSecurity()
        If USbookrecords = "No Access" Then
            btndrpbooks.Enabled = False
            btndrpgroups.Enabled = False
            btndrpsubject.Enabled = False
            btnquerybooks.Enabled = False
        End If
        If USidcard = "No Access" Then
            btndrpidcard.Enabled = False
        End If
        If UScharges = "No Access" Then
            btncharges.Enabled = False
            btnvieweditcharges.Enabled = False
            btncalculatecharges.Enabled = False
            btnvieweditcalculatecharges.Enabled = False
        End If
        If USissuebooks = "No Access" Then
            btnissuebooks.Enabled = False
            btnvieweditissuebooks.Enabled = False
        End If
        If USreturnbooks = "No Access" Then
            btnreturnbooks.Enabled = False
            btnvieweditreturnbooks.Enabled = False
        End If
        If USLibraryDefault = "No Access" Then
            btnsetupdefaults.Enabled = False
        End If
    End Sub

    Private Sub DateValueUpdated(ByVal sender As Object, ByVal e As ValueUpdatedEventArgs) Handles childA.ValueUpdated
        Me.btndatetask.Text = "System Date: " + e.NewValue
        Me.btndatesystem.Text = "System Date: " + e.NewValue
    End Sub

    Private Sub PeriodValueUpdated(ByVal sender As Object, ByVal e As ValueUpdatedEventArgs) Handles childB.ValueUpdated
        Me.btnperiodsystem.Text = "Period: " + e.NewValue
        Me.btnperiodtask.Text = "Period: " + e.NewValue
    End Sub
#End Region
#Region "Form Event..."
    Private Sub frmLibraryMainForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        My.Settings.Save()
    End Sub

    Private Sub frmLibraryMainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim frm As New frmMainTask()
        frm.MdiParent = Me.MdiParent
        frm.Show()
    End Sub

    Private Sub frmLibraryMainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each frmApproval As Form In Me.MdiChildren
            frmApproval.Close()
        Next
        TabControl1.HideTabs = True
        LoadDefaultPage()
        LoadPanel()
        LoadDate()
        LoadPeriod()
        LoadLibraryDefaults()
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

    Private Sub ETabStripTask_TabStripItemClosing(ByVal e As ESAR_Controls.UIControls.TabControl.TabStripItemClosingEventArgs) Handles ETabStripTask.TabStripItemClosing

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
        Dim frm As New frmSetupDefaultsLibrary()
        frm.ShowDialog()
    End Sub

    Private Sub btnlibrarystatus_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnlibrarystatus.ClickButtonArea
        Dim frm As New frmLibraryStatus()
        frm.WindowState = FormWindowState.Normal
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ControlBox = True
        frm.Show()
    End Sub
#End Region
End Class
#End Region
#End Region
