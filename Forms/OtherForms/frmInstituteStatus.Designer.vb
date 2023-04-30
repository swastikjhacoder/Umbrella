Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstituteStatus
    Inherits ESAR_Controls.UIControls.eForms.eFadeGradientForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim CBlendItems1 As ESAR_Controls.cBlendItems = New ESAR_Controls.cBlendItems
        Dim DesignerRectTracker1 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInstituteStatus))
        Dim DesignerRectTracker2 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker3 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker4 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker5 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker6 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Me.EGradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.EGroupBox1 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.btndrpcheckupdates = New Elegant.Ui.DropDown
        Me.PopupMenu5 = New Elegant.Ui.PopupMenu
        Me.btncheckupdate = New Elegant.Ui.Button
        Me.btndrpyearendwizard = New Elegant.Ui.DropDown
        Me.PopupMenu4 = New Elegant.Ui.PopupMenu
        Me.btnyearendwizard = New Elegant.Ui.Button
        Me.btndrpdatamaintanance = New Elegant.Ui.DropDown
        Me.PopupMenu3 = New Elegant.Ui.PopupMenu
        Me.btnbackup = New Elegant.Ui.Button
        Me.Separator2 = New Elegant.Ui.Separator
        Me.btnrestore = New Elegant.Ui.Button
        Me.Separator3 = New Elegant.Ui.Separator
        Me.btnimportexport = New Elegant.Ui.Button
        Me.btndrpusersecurity = New Elegant.Ui.DropDown
        Me.PopupMenu2 = New Elegant.Ui.PopupMenu
        Me.btnusersecurity = New Elegant.Ui.Button
        Me.Separator1 = New Elegant.Ui.Separator
        Me.btnuserrole = New Elegant.Ui.Button
        Me.btndrpsetupguide = New Elegant.Ui.DropDown
        Me.PopupMenu1 = New Elegant.Ui.PopupMenu
        Me.btnsetupguide = New Elegant.Ui.Button
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.EGroupBox3 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.dgviewinstitute = New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lnkeditinstitute = New System.Windows.Forms.LinkLabel
        Me.EGroupBox2 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.dgviewrevenue = New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column10 = New ESAR_Controls.UIControls.DataGridView.eCurrencyColumn
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lnkbalancesheet = New System.Windows.Forms.LinkLabel
        Me.RoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.ELabel6 = New ESAR_Controls.eLabel
        Me.btnrefresh = New ESAR_Controls.UIControls.Button.eButton
        Me.btnperiod = New ESAR_Controls.UIControls.Button.eButton
        Me.btndate = New ESAR_Controls.UIControls.Button.eButton
        Me.EGradientPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.EGroupBox1.SuspendLayout()
        CType(Me.PopupMenu5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.EGroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgviewinstitute, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.EGroupBox2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.dgviewrevenue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.RoundedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EGradientPanel1
        '
        Me.EGradientPanel1.Controls.Add(Me.SplitContainer1)
        Me.EGradientPanel1.Controls.Add(Me.RoundedPanel1)
        Me.EGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGradientPanel1.EndColor = System.Drawing.Color.RoyalBlue
        Me.EGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.EGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EGradientPanel1.Name = "EGradientPanel1"
        Me.EGradientPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.EGradientPanel1.Size = New System.Drawing.Size(810, 542)
        Me.EGradientPanel1.StartColor = System.Drawing.Color.LightCyan
        Me.EGradientPanel1.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(10, 70)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EGroupBox1)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.SplitContainer1.Size = New System.Drawing.Size(790, 462)
        Me.SplitContainer1.SplitterDistance = 187
        Me.SplitContainer1.TabIndex = 4
        '
        'EGroupBox1
        '
        Me.EGroupBox1.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox1.BorderThickness = 1.0!
        Me.EGroupBox1.Controls.Add(Me.btndrpcheckupdates)
        Me.EGroupBox1.Controls.Add(Me.btndrpyearendwizard)
        Me.EGroupBox1.Controls.Add(Me.btndrpdatamaintanance)
        Me.EGroupBox1.Controls.Add(Me.btndrpusersecurity)
        Me.EGroupBox1.Controls.Add(Me.btndrpsetupguide)
        Me.EGroupBox1.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.EGroupBox1.GroupImage = Global.Umbrella.My.Resources.Resources.task_icon
        Me.EGroupBox1.GroupTitle = "Tasks:"
        Me.EGroupBox1.Location = New System.Drawing.Point(0, 5)
        Me.EGroupBox1.Name = "EGroupBox1"
        Me.EGroupBox1.Padding = New System.Windows.Forms.Padding(10, 35, 10, 10)
        Me.EGroupBox1.PaintGroupBox = False
        Me.EGroupBox1.RoundCorners = 10
        Me.EGroupBox1.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox1.ShadowControl = False
        Me.EGroupBox1.ShadowThickness = 3
        Me.EGroupBox1.Size = New System.Drawing.Size(187, 249)
        Me.EGroupBox1.TabIndex = 0
        '
        'btndrpcheckupdates
        '
        Me.btndrpcheckupdates.Dock = System.Windows.Forms.DockStyle.Top
        Me.btndrpcheckupdates.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndrpcheckupdates.Id = "310bd27b-2318-4415-b969-123f2d68f804"
        Me.btndrpcheckupdates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndrpcheckupdates.Location = New System.Drawing.Point(10, 195)
        Me.btndrpcheckupdates.Name = "btndrpcheckupdates"
        Me.btndrpcheckupdates.Popup = Me.PopupMenu5
        Me.btndrpcheckupdates.Size = New System.Drawing.Size(167, 40)
        Me.btndrpcheckupdates.SmallImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.Umbrella.My.Resources.Resources.update)})
        Me.btndrpcheckupdates.TabIndex = 4
        Me.btndrpcheckupdates.Text = "Check For Updates"
        Me.btndrpcheckupdates.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndrpcheckupdates.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'PopupMenu5
        '
        Me.PopupMenu5.Items.AddRange(New System.Windows.Forms.Control() {Me.btncheckupdate})
        Me.PopupMenu5.PlacementMode = Elegant.Ui.PopupPlacementMode.Bottom
        Me.PopupMenu5.Size = New System.Drawing.Size(100, 100)
        '
        'btncheckupdate
        '
        Me.btncheckupdate.Id = "7b68ec2a-ca91-441c-a807-0acc8edae69c"
        Me.btncheckupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncheckupdate.Location = New System.Drawing.Point(2, 2)
        Me.btncheckupdate.Name = "btncheckupdate"
        Me.btncheckupdate.Size = New System.Drawing.Size(158, 23)
        Me.btncheckupdate.SmallImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.Umbrella.My.Resources.Resources.update)})
        Me.btncheckupdate.TabIndex = 3
        Me.btncheckupdate.Text = "Check For Updates"
        Me.btncheckupdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncheckupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btndrpyearendwizard
        '
        Me.btndrpyearendwizard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btndrpyearendwizard.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndrpyearendwizard.Id = "2dd81f95-00eb-4938-b71a-337edc01793f"
        Me.btndrpyearendwizard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndrpyearendwizard.Location = New System.Drawing.Point(10, 155)
        Me.btndrpyearendwizard.Name = "btndrpyearendwizard"
        Me.btndrpyearendwizard.Popup = Me.PopupMenu4
        Me.btndrpyearendwizard.Size = New System.Drawing.Size(167, 40)
        Me.btndrpyearendwizard.SmallImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.Umbrella.My.Resources.Resources.Year_End)})
        Me.btndrpyearendwizard.TabIndex = 3
        Me.btndrpyearendwizard.Text = "Year-End Wizard"
        Me.btndrpyearendwizard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndrpyearendwizard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'PopupMenu4
        '
        Me.PopupMenu4.Items.AddRange(New System.Windows.Forms.Control() {Me.btnyearendwizard})
        Me.PopupMenu4.PlacementMode = Elegant.Ui.PopupPlacementMode.Bottom
        Me.PopupMenu4.Size = New System.Drawing.Size(100, 100)
        '
        'btnyearendwizard
        '
        Me.btnyearendwizard.Id = "47c70dfa-cdcf-4b7b-9d54-aa4879cf3a7b"
        Me.btnyearendwizard.Location = New System.Drawing.Point(2, 2)
        Me.btnyearendwizard.Name = "btnyearendwizard"
        Me.btnyearendwizard.Size = New System.Drawing.Size(145, 23)
        Me.btnyearendwizard.SmallImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.Umbrella.My.Resources.Resources.Year_End)})
        Me.btnyearendwizard.TabIndex = 3
        Me.btnyearendwizard.Text = "Year-End Wizard"
        '
        'btndrpdatamaintanance
        '
        Me.btndrpdatamaintanance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btndrpdatamaintanance.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndrpdatamaintanance.Id = "3431910c-4161-4739-9ff9-fa20a7f56b25"
        Me.btndrpdatamaintanance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndrpdatamaintanance.Location = New System.Drawing.Point(10, 115)
        Me.btndrpdatamaintanance.Name = "btndrpdatamaintanance"
        Me.btndrpdatamaintanance.Popup = Me.PopupMenu3
        Me.btndrpdatamaintanance.Size = New System.Drawing.Size(167, 40)
        Me.btndrpdatamaintanance.SmallImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.Umbrella.My.Resources.Resources.data)})
        Me.btndrpdatamaintanance.TabIndex = 2
        Me.btndrpdatamaintanance.Text = "Data Maintanance"
        Me.btndrpdatamaintanance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndrpdatamaintanance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'PopupMenu3
        '
        Me.PopupMenu3.Items.AddRange(New System.Windows.Forms.Control() {Me.btnbackup, Me.Separator2, Me.btnrestore, Me.Separator3, Me.btnimportexport})
        Me.PopupMenu3.PlacementMode = Elegant.Ui.PopupPlacementMode.Bottom
        Me.PopupMenu3.Size = New System.Drawing.Size(100, 100)
        Me.PopupMenu3.Visible = True
        '
        'btnbackup
        '
        Me.btnbackup.Id = "0d5f1953-7b80-4482-b144-829001f411b6"
        Me.btnbackup.Location = New System.Drawing.Point(2, 2)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.Size = New System.Drawing.Size(179, 35)
        Me.btnbackup.SmallImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.Umbrella.My.Resources.Resources.Backup)})
        Me.btnbackup.TabIndex = 3
        Me.btnbackup.Text = "Backup Data"
        '
        'Separator2
        '
        Me.Separator2.Id = "2bbe9db1-be10-4688-982c-43eb4068c674"
        Me.Separator2.Location = New System.Drawing.Point(2, 37)
        Me.Separator2.Name = "Separator2"
        Me.Separator2.Orientation = Elegant.Ui.SeparatorOrientation.Horizontal
        Me.Separator2.Size = New System.Drawing.Size(179, 5)
        Me.Separator2.TabIndex = 4
        Me.Separator2.Text = "Separator2"
        '
        'btnrestore
        '
        Me.btnrestore.Id = "9d472086-970a-4197-8597-e5bde5d7819a"
        Me.btnrestore.Location = New System.Drawing.Point(2, 42)
        Me.btnrestore.Name = "btnrestore"
        Me.btnrestore.Size = New System.Drawing.Size(179, 35)
        Me.btnrestore.SmallImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.Umbrella.My.Resources.Resources.Restore)})
        Me.btnrestore.TabIndex = 5
        Me.btnrestore.Text = "Restore Data"
        '
        'Separator3
        '
        Me.Separator3.Id = "66344420-35a9-4f57-b07d-786eb9fbea6f"
        Me.Separator3.Location = New System.Drawing.Point(2, 77)
        Me.Separator3.Name = "Separator3"
        Me.Separator3.Orientation = Elegant.Ui.SeparatorOrientation.Horizontal
        Me.Separator3.Size = New System.Drawing.Size(179, 5)
        Me.Separator3.TabIndex = 6
        Me.Separator3.Text = "Separator3"
        '
        'btnimportexport
        '
        Me.btnimportexport.Id = "14d3f36c-4f29-45a2-a9b8-b77f91a59800"
        Me.btnimportexport.Location = New System.Drawing.Point(2, 82)
        Me.btnimportexport.Name = "btnimportexport"
        Me.btnimportexport.Size = New System.Drawing.Size(179, 23)
        Me.btnimportexport.SmallImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.Umbrella.My.Resources.Resources.import_export_icon)})
        Me.btnimportexport.TabIndex = 7
        Me.btnimportexport.Text = "Import/ Export Data"
        '
        'btndrpusersecurity
        '
        Me.btndrpusersecurity.Dock = System.Windows.Forms.DockStyle.Top
        Me.btndrpusersecurity.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndrpusersecurity.Id = "012af452-268f-4017-9102-a8ede459b671"
        Me.btndrpusersecurity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndrpusersecurity.Location = New System.Drawing.Point(10, 75)
        Me.btndrpusersecurity.Name = "btndrpusersecurity"
        Me.btndrpusersecurity.Popup = Me.PopupMenu2
        Me.btndrpusersecurity.Size = New System.Drawing.Size(167, 40)
        Me.btndrpusersecurity.SmallImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.Umbrella.My.Resources.Resources.Unser_Secuirity_Menu)})
        Me.btndrpusersecurity.TabIndex = 1
        Me.btndrpusersecurity.Text = "User Security"
        Me.btndrpusersecurity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndrpusersecurity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'PopupMenu2
        '
        Me.PopupMenu2.Items.AddRange(New System.Windows.Forms.Control() {Me.btnusersecurity, Me.Separator1, Me.btnuserrole})
        Me.PopupMenu2.PlacementMode = Elegant.Ui.PopupPlacementMode.Bottom
        Me.PopupMenu2.Size = New System.Drawing.Size(100, 100)
        '
        'btnusersecurity
        '
        Me.btnusersecurity.Id = "18bb2395-7f42-4f93-87e9-07b2a8523915"
        Me.btnusersecurity.Location = New System.Drawing.Point(2, 2)
        Me.btnusersecurity.Name = "btnusersecurity"
        Me.btnusersecurity.Size = New System.Drawing.Size(146, 23)
        Me.btnusersecurity.SmallImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.Umbrella.My.Resources.Resources.Unser_Secuirity_Menu)})
        Me.btnusersecurity.TabIndex = 3
        Me.btnusersecurity.Text = "User Security"
        '
        'Separator1
        '
        Me.Separator1.Id = "c6e82629-05dd-4368-a5c2-0fa89f0a4e98"
        Me.Separator1.Location = New System.Drawing.Point(2, 25)
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Orientation = Elegant.Ui.SeparatorOrientation.Horizontal
        Me.Separator1.Size = New System.Drawing.Size(146, 5)
        Me.Separator1.TabIndex = 4
        Me.Separator1.Text = "Separator1"
        '
        'btnuserrole
        '
        Me.btnuserrole.Id = "1ed57031-7a92-4de3-819f-652e4d157154"
        Me.btnuserrole.Location = New System.Drawing.Point(2, 30)
        Me.btnuserrole.Name = "btnuserrole"
        Me.btnuserrole.Size = New System.Drawing.Size(146, 23)
        Me.btnuserrole.SmallImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.Umbrella.My.Resources.Resources.user_role_icon)})
        Me.btnuserrole.TabIndex = 5
        Me.btnuserrole.Text = "Assign User Role"
        '
        'btndrpsetupguide
        '
        Me.btndrpsetupguide.Dock = System.Windows.Forms.DockStyle.Top
        Me.btndrpsetupguide.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndrpsetupguide.Id = "2b4e4192-d119-4ac1-9589-13931a6a4321"
        Me.btndrpsetupguide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndrpsetupguide.Location = New System.Drawing.Point(10, 35)
        Me.btndrpsetupguide.Name = "btndrpsetupguide"
        Me.btndrpsetupguide.Popup = Me.PopupMenu1
        Me.btndrpsetupguide.Size = New System.Drawing.Size(167, 40)
        Me.btndrpsetupguide.SmallImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.Umbrella.My.Resources.Resources.Setup_Guide)})
        Me.btndrpsetupguide.TabIndex = 0
        Me.btndrpsetupguide.Text = "Setup Guide"
        Me.btndrpsetupguide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndrpsetupguide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'PopupMenu1
        '
        Me.PopupMenu1.Items.AddRange(New System.Windows.Forms.Control() {Me.btnsetupguide})
        Me.PopupMenu1.PlacementMode = Elegant.Ui.PopupPlacementMode.Bottom
        Me.PopupMenu1.Size = New System.Drawing.Size(100, 100)
        '
        'btnsetupguide
        '
        Me.btnsetupguide.Id = "a6e06537-0cec-44f7-afda-8017d72f8a8d"
        Me.btnsetupguide.Location = New System.Drawing.Point(2, 2)
        Me.btnsetupguide.Name = "btnsetupguide"
        Me.btnsetupguide.Size = New System.Drawing.Size(138, 23)
        Me.btnsetupguide.SmallImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.Umbrella.My.Resources.Resources.Setup_Guide)})
        Me.btnsetupguide.TabIndex = 3
        Me.btnsetupguide.Text = "Setup Guide"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.IsSplitterFixed = True
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 5)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EGroupBox3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EGroupBox2)
        Me.SplitContainer2.Size = New System.Drawing.Size(599, 457)
        Me.SplitContainer2.SplitterDistance = 279
        Me.SplitContainer2.TabIndex = 0
        '
        'EGroupBox3
        '
        Me.EGroupBox3.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox3.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox3.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox3.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox3.BorderThickness = 1.0!
        Me.EGroupBox3.Controls.Add(Me.Panel2)
        Me.EGroupBox3.Controls.Add(Me.Panel1)
        Me.EGroupBox3.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox3.GroupImage = Global.Umbrella.My.Resources.Resources.Umbrella_icon
        Me.EGroupBox3.GroupTitle = "Institution Info:"
        Me.EGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.EGroupBox3.Name = "EGroupBox3"
        Me.EGroupBox3.Padding = New System.Windows.Forms.Padding(12, 25, 12, 10)
        Me.EGroupBox3.PaintGroupBox = False
        Me.EGroupBox3.RoundCorners = 10
        Me.EGroupBox3.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox3.ShadowControl = False
        Me.EGroupBox3.ShadowThickness = 3
        Me.EGroupBox3.Size = New System.Drawing.Size(599, 279)
        Me.EGroupBox3.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgviewinstitute)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(12, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel2.Size = New System.Drawing.Size(575, 222)
        Me.Panel2.TabIndex = 1
        '
        'dgviewinstitute
        '
        Me.dgviewinstitute.AllowUserToAddRows = False
        Me.dgviewinstitute.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgviewinstitute.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgviewinstitute.BackgroundColor = System.Drawing.Color.White
        Me.dgviewinstitute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgviewinstitute.ColumnHeadersVisible = False
        Me.dgviewinstitute.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewinstitute.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgviewinstitute.DisplaySumRowHeader = False
        Me.dgviewinstitute.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewinstitute.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgviewinstitute.Location = New System.Drawing.Point(0, 5)
        Me.dgviewinstitute.Name = "dgviewinstitute"
        Me.dgviewinstitute.ReadOnly = True
        Me.dgviewinstitute.RowHeadersVisible = False
        Me.dgviewinstitute.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgviewinstitute.Size = New System.Drawing.Size(575, 217)
        Me.dgviewinstitute.SummaryColumns = Nothing
        Me.dgviewinstitute.SummaryRowBackColor = System.Drawing.Color.Empty
        Me.dgviewinstitute.SummaryRowSpace = 0
        Me.dgviewinstitute.SummaryRowVisible = False
        Me.dgviewinstitute.SumRowHeaderText = Nothing
        Me.dgviewinstitute.SumRowHeaderTextBold = False
        Me.dgviewinstitute.TabIndex = 0
        '
        'Column1
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "Data"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 120
        '
        'Column2
        '
        Me.Column2.HeaderText = "Value"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 452
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lnkeditinstitute)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(12, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(575, 22)
        Me.Panel1.TabIndex = 0
        '
        'lnkeditinstitute
        '
        Me.lnkeditinstitute.Dock = System.Windows.Forms.DockStyle.Right
        Me.lnkeditinstitute.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkeditinstitute.Image = Global.Umbrella.My.Resources.Resources.edit_icon
        Me.lnkeditinstitute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkeditinstitute.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkeditinstitute.Location = New System.Drawing.Point(369, 0)
        Me.lnkeditinstitute.Name = "lnkeditinstitute"
        Me.lnkeditinstitute.Size = New System.Drawing.Size(206, 22)
        Me.lnkeditinstitute.TabIndex = 0
        Me.lnkeditinstitute.TabStop = True
        Me.lnkeditinstitute.Text = "Edit Institution Info"
        Me.lnkeditinstitute.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EGroupBox2
        '
        Me.EGroupBox2.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox2.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox2.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox2.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox2.BorderThickness = 1.0!
        Me.EGroupBox2.Controls.Add(Me.SplitContainer3)
        Me.EGroupBox2.Controls.Add(Me.Panel3)
        Me.EGroupBox2.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox2.GroupImage = Global.Umbrella.My.Resources.Resources.revenue
        Me.EGroupBox2.GroupTitle = "Revenue Year To Date Report:"
        Me.EGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.EGroupBox2.Name = "EGroupBox2"
        Me.EGroupBox2.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.EGroupBox2.PaintGroupBox = False
        Me.EGroupBox2.RoundCorners = 10
        Me.EGroupBox2.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox2.ShadowControl = False
        Me.EGroupBox2.ShadowThickness = 3
        Me.EGroupBox2.Size = New System.Drawing.Size(599, 174)
        Me.EGroupBox2.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(10, 25)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.dgviewrevenue)
        Me.SplitContainer3.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.Chart1)
        Me.SplitContainer3.Panel2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.SplitContainer3.Size = New System.Drawing.Size(579, 118)
        Me.SplitContainer3.SplitterDistance = 290
        Me.SplitContainer3.SplitterWidth = 6
        Me.SplitContainer3.TabIndex = 1
        '
        'dgviewrevenue
        '
        Me.dgviewrevenue.AllowUserToAddRows = False
        Me.dgviewrevenue.AllowUserToDeleteRows = False
        Me.dgviewrevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgviewrevenue.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgviewrevenue.BackgroundColor = System.Drawing.Color.White
        Me.dgviewrevenue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgviewrevenue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgviewrevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgviewrevenue.ColumnHeadersVisible = False
        Me.dgviewrevenue.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column10})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewrevenue.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgviewrevenue.DisplaySumRowHeader = False
        Me.dgviewrevenue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewrevenue.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgviewrevenue.Location = New System.Drawing.Point(0, 5)
        Me.dgviewrevenue.Name = "dgviewrevenue"
        Me.dgviewrevenue.ReadOnly = True
        Me.dgviewrevenue.RowHeadersVisible = False
        Me.dgviewrevenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgviewrevenue.Size = New System.Drawing.Size(290, 113)
        Me.dgviewrevenue.SummaryColumns = Nothing
        Me.dgviewrevenue.SummaryRowBackColor = System.Drawing.Color.Empty
        Me.dgviewrevenue.SummaryRowSpace = 0
        Me.dgviewrevenue.SummaryRowVisible = False
        Me.dgviewrevenue.SumRowHeaderText = Nothing
        Me.dgviewrevenue.SumRowHeaderTextBold = False
        Me.dgviewrevenue.TabIndex = 8
        '
        'Column8
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column8.HeaderText = "Name"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column10
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column10.HeaderText = "Value"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 5)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(283, 113)
        Me.Chart1.TabIndex = 8
        Me.Chart1.Text = "Chart1"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lnkbalancesheet)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(10, 143)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel3.Size = New System.Drawing.Size(579, 21)
        Me.Panel3.TabIndex = 0
        '
        'lnkbalancesheet
        '
        Me.lnkbalancesheet.Dock = System.Windows.Forms.DockStyle.Right
        Me.lnkbalancesheet.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkbalancesheet.Image = Global.Umbrella.My.Resources.Resources.list
        Me.lnkbalancesheet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkbalancesheet.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkbalancesheet.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkbalancesheet.Location = New System.Drawing.Point(373, 5)
        Me.lnkbalancesheet.Name = "lnkbalancesheet"
        Me.lnkbalancesheet.Size = New System.Drawing.Size(206, 16)
        Me.lnkbalancesheet.TabIndex = 5
        Me.lnkbalancesheet.TabStop = True
        Me.lnkbalancesheet.Text = "View Balance Sheet"
        Me.lnkbalancesheet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.RoundedPanel1.BorderRadius = 32
        Me.RoundedPanel1.Controls.Add(Me.ELabel6)
        Me.RoundedPanel1.Controls.Add(Me.btnrefresh)
        Me.RoundedPanel1.Controls.Add(Me.btnperiod)
        Me.RoundedPanel1.Controls.Add(Me.btndate)
        Me.RoundedPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RoundedPanel1.Location = New System.Drawing.Point(10, 10)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.RoundedPanel1.Size = New System.Drawing.Size(790, 60)
        Me.RoundedPanel1.TabIndex = 3
        '
        'ELabel6
        '
        Me.ELabel6.AutoFit = True
        Me.ELabel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.ELabel6.Feather = 255
        Me.ELabel6.FeatherState = False
        Me.ELabel6.FillType = ESAR_Controls.eLabel.eFillType.GradientLinear
        Me.ELabel6.ForeColor = System.Drawing.Color.LightSteelBlue
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0.0!, 0.113879!, 0.6370107!, 0.9252669!, 1.0!}
        Me.ELabel6.ForeColorBlend = CBlendItems1
        Me.ELabel6.Glow = 0
        Me.ELabel6.GlowColor = System.Drawing.Color.RoyalBlue
        Me.ELabel6.Location = New System.Drawing.Point(589, 10)
        Me.ELabel6.MouseOverColor = System.Drawing.Color.Gray
        Me.ELabel6.Name = "ELabel6"
        Me.ELabel6.ShadowState = True
        Me.ELabel6.Size = New System.Drawing.Size(191, 40)
        Me.ELabel6.TabIndex = 35
        Me.ELabel6.Text = "Institute Status"
        '
        'btnrefresh
        '
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnrefresh.CenterPtTracker = DesignerRectTracker1
        Me.btnrefresh.Corners.All = CType(8, Short)
        Me.btnrefresh.Corners.LowerLeft = CType(8, Short)
        Me.btnrefresh.Corners.LowerRight = CType(8, Short)
        Me.btnrefresh.Corners.UpperLeft = CType(8, Short)
        Me.btnrefresh.Corners.UpperRight = CType(8, Short)
        Me.btnrefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnrefresh.FocalPoints.CenterPtX = 0.4444444!
        Me.btnrefresh.FocalPoints.CenterPtY = 0.4!
        Me.btnrefresh.FocalPoints.FocusPtX = 0.0!
        Me.btnrefresh.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnrefresh.FocusPtTracker = DesignerRectTracker2
        Me.btnrefresh.Image = Global.Umbrella.My.Resources.Resources.refresh_icon
        Me.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.ImageIndex = 0
        Me.btnrefresh.Location = New System.Drawing.Point(450, 10)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(76, 40)
        Me.btnrefresh.TabIndex = 14
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnperiod
        '
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnperiod.CenterPtTracker = DesignerRectTracker3
        Me.btnperiod.Corners.All = CType(8, Short)
        Me.btnperiod.Corners.LowerLeft = CType(8, Short)
        Me.btnperiod.Corners.LowerRight = CType(8, Short)
        Me.btnperiod.Corners.UpperLeft = CType(8, Short)
        Me.btnperiod.Corners.UpperRight = CType(8, Short)
        Me.btnperiod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnperiod.Dock = System.Windows.Forms.DockStyle.Left
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnperiod.FocusPtTracker = DesignerRectTracker4
        Me.btnperiod.Image = Global.Umbrella.My.Resources.Resources.period
        Me.btnperiod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnperiod.ImageIndex = 0
        Me.btnperiod.Location = New System.Drawing.Point(200, 10)
        Me.btnperiod.Name = "btnperiod"
        Me.btnperiod.Size = New System.Drawing.Size(250, 40)
        Me.btnperiod.TabIndex = 12
        Me.btnperiod.Text = "Period: "
        Me.btnperiod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnperiod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btndate
        '
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btndate.CenterPtTracker = DesignerRectTracker5
        Me.btndate.Corners.All = CType(8, Short)
        Me.btndate.Corners.LowerLeft = CType(8, Short)
        Me.btndate.Corners.LowerRight = CType(8, Short)
        Me.btndate.Corners.UpperLeft = CType(8, Short)
        Me.btndate.Corners.UpperRight = CType(8, Short)
        Me.btndate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndate.Dock = System.Windows.Forms.DockStyle.Left
        Me.btndate.FocalPoints.CenterPtX = 0.5069767!
        Me.btndate.FocalPoints.CenterPtY = 0.5!
        Me.btndate.FocalPoints.FocusPtX = 0.0!
        Me.btndate.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btndate.FocusPtTracker = DesignerRectTracker6
        Me.btndate.Image = Global.Umbrella.My.Resources.Resources._Date
        Me.btndate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndate.ImageIndex = 0
        Me.btndate.Location = New System.Drawing.Point(10, 10)
        Me.btndate.Name = "btndate"
        Me.btndate.Size = New System.Drawing.Size(190, 40)
        Me.btndate.TabIndex = 11
        Me.btndate.Text = "System Date: "
        Me.btndate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'frmInstituteStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(810, 542)
        Me.Controls.Add(Me.EGradientPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.RoyalLight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInstituteStatus"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Institute Status"
        Me.EGradientPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.EGroupBox1.ResumeLayout(False)
        CType(Me.PopupMenu5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.EGroupBox3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgviewinstitute, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.EGroupBox2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.dgviewrevenue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.RoundedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EGradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents RoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents btnrefresh As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnperiod As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btndate As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents ELabel6 As ESAR_Controls.eLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EGroupBox1 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents btndrpusersecurity As Elegant.Ui.DropDown
    Friend WithEvents PopupMenu2 As Elegant.Ui.PopupMenu
    Friend WithEvents btnusersecurity As Elegant.Ui.Button
    Friend WithEvents Separator1 As Elegant.Ui.Separator
    Friend WithEvents btnuserrole As Elegant.Ui.Button
    Friend WithEvents btndrpsetupguide As Elegant.Ui.DropDown
    Friend WithEvents PopupMenu1 As Elegant.Ui.PopupMenu
    Friend WithEvents btnsetupguide As Elegant.Ui.Button
    Friend WithEvents btndrpdatamaintanance As Elegant.Ui.DropDown
    Friend WithEvents btndrpyearendwizard As Elegant.Ui.DropDown
    Friend WithEvents PopupMenu3 As Elegant.Ui.PopupMenu
    Friend WithEvents btnbackup As Elegant.Ui.Button
    Friend WithEvents Separator2 As Elegant.Ui.Separator
    Friend WithEvents btnrestore As Elegant.Ui.Button
    Friend WithEvents Separator3 As Elegant.Ui.Separator
    Friend WithEvents btnimportexport As Elegant.Ui.Button
    Friend WithEvents btndrpcheckupdates As Elegant.Ui.DropDown
    Friend WithEvents PopupMenu5 As Elegant.Ui.PopupMenu
    Friend WithEvents btncheckupdate As Elegant.Ui.Button
    Friend WithEvents PopupMenu4 As Elegant.Ui.PopupMenu
    Friend WithEvents btnyearendwizard As Elegant.Ui.Button
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EGroupBox2 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents EGroupBox3 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgviewinstitute As ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lnkeditinstitute As System.Windows.Forms.LinkLabel
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgviewrevenue As ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As ESAR_Controls.UIControls.DataGridView.eCurrencyColumn
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lnkbalancesheet As System.Windows.Forms.LinkLabel
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
