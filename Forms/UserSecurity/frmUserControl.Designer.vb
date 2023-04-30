Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserControl
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DesignerRectTracker1 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserControl))
        Dim DesignerRectTracker2 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker3 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker4 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker5 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker6 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker7 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker8 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker9 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker10 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker11 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker12 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim CBlendItems1 As ESAR_Controls.cBlendItems = New ESAR_Controls.cBlendItems
        Me.EGradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ETabControl1 = New ESAR_Controls.UIControls.TabControl.eTabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.EGroupBox1 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.dgviewusers = New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.ERoundedPanel2 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnsave = New ESAR_Controls.UIControls.Button.eButton
        Me.cmbuser = New ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
        Me.rbtnoneuser = New System.Windows.Forms.RadioButton
        Me.rbtnalluser = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ERoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.btnhelp = New ESAR_Controls.UIControls.Button.eButton
        Me.btnrefresh = New ESAR_Controls.UIControls.Button.eButton
        Me.btndeleteuser = New ESAR_Controls.UIControls.Button.eButton
        Me.btnedituserright = New ESAR_Controls.UIControls.Button.eButton
        Me.btnnewuser = New ESAR_Controls.UIControls.Button.eButton
        Me.ELabel1 = New ESAR_Controls.eLabel
        Me.EGradientPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ETabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.EGroupBox1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgviewusers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.ERoundedPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ERoundedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EGradientPanel1
        '
        Me.EGradientPanel1.Controls.Add(Me.Panel1)
        Me.EGradientPanel1.Controls.Add(Me.ERoundedPanel1)
        Me.EGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGradientPanel1.EndColor = System.Drawing.Color.LightCyan
        Me.EGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.EGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EGradientPanel1.Name = "EGradientPanel1"
        Me.EGradientPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.EGradientPanel1.Size = New System.Drawing.Size(704, 321)
        Me.EGradientPanel1.StartColor = System.Drawing.Color.RoyalBlue
        Me.EGradientPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.ETabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(684, 241)
        Me.Panel1.TabIndex = 3
        '
        'ETabControl1
        '
        Me.ETabControl1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ETabControl1.Controls.Add(Me.TabPage1)
        Me.ETabControl1.Controls.Add(Me.TabPage2)
        Me.ETabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ETabControl1.Location = New System.Drawing.Point(0, 5)
        Me.ETabControl1.Name = "ETabControl1"
        Me.ETabControl1.SelectedIndex = 0
        Me.ETabControl1.Size = New System.Drawing.Size(684, 236)
        Me.ETabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage1.Controls.Add(Me.EGroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(676, 207)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "User:"
        '
        'EGroupBox1
        '
        Me.EGroupBox1.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox1.BorderThickness = 1.0!
        Me.EGroupBox1.Controls.Add(Me.SplitContainer1)
        Me.EGroupBox1.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox1.GroupImage = Global.Umbrella.My.Resources.Resources.user_secuirity
        Me.EGroupBox1.GroupTitle = "User List: "
        Me.EGroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.EGroupBox1.Name = "EGroupBox1"
        Me.EGroupBox1.Padding = New System.Windows.Forms.Padding(12, 25, 12, 10)
        Me.EGroupBox1.PaintGroupBox = False
        Me.EGroupBox1.RoundCorners = 10
        Me.EGroupBox1.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox1.ShadowControl = False
        Me.EGroupBox1.ShadowThickness = 3
        Me.EGroupBox1.Size = New System.Drawing.Size(670, 201)
        Me.EGroupBox1.TabIndex = 3
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgviewusers)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Size = New System.Drawing.Size(646, 166)
        Me.SplitContainer1.SplitterDistance = 125
        Me.SplitContainer1.TabIndex = 0
        '
        'dgviewusers
        '
        Me.dgviewusers.AllowUserToAddRows = False
        Me.dgviewusers.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgviewusers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgviewusers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgviewusers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgviewusers.BackgroundColor = System.Drawing.Color.White
        Me.dgviewusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgviewusers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewusers.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgviewusers.DisplaySumRowHeader = False
        Me.dgviewusers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewusers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgviewusers.Location = New System.Drawing.Point(0, 0)
        Me.dgviewusers.MultiSelect = False
        Me.dgviewusers.Name = "dgviewusers"
        Me.dgviewusers.ReadOnly = True
        Me.dgviewusers.RowHeadersVisible = False
        Me.dgviewusers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgviewusers.Size = New System.Drawing.Size(646, 125)
        Me.dgviewusers.SummaryColumns = Nothing
        Me.dgviewusers.SummaryRowBackColor = System.Drawing.Color.Empty
        Me.dgviewusers.SummaryRowSpace = 0
        Me.dgviewusers.SummaryRowVisible = False
        Me.dgviewusers.SumRowHeaderText = Nothing
        Me.dgviewusers.SumRowHeaderTextBold = False
        Me.dgviewusers.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Roll"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Username"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(646, 37)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Users who are not licenced cannot log into Umbrella. The number of Umbrella licen" & _
            "ses available depends on the serial number(s) used to register."
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage2.Controls.Add(Me.ERoundedPanel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(676, 207)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Crystal Reports:"
        '
        'ERoundedPanel2
        '
        Me.ERoundedPanel2.BackColor = System.Drawing.Color.White
        Me.ERoundedPanel2.BorderRadius = 32
        Me.ERoundedPanel2.Controls.Add(Me.GroupBox1)
        Me.ERoundedPanel2.Controls.Add(Me.Label1)
        Me.ERoundedPanel2.Controls.Add(Me.Label2)
        Me.ERoundedPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel2.Location = New System.Drawing.Point(3, 3)
        Me.ERoundedPanel2.Name = "ERoundedPanel2"
        Me.ERoundedPanel2.Size = New System.Drawing.Size(670, 201)
        Me.ERoundedPanel2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.cmbuser)
        Me.GroupBox1.Controls.Add(Me.rbtnoneuser)
        Me.GroupBox1.Controls.Add(Me.rbtnalluser)
        Me.GroupBox1.Location = New System.Drawing.Point(76, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 71)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'btnsave
        '
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsave.CenterPtTracker = DesignerRectTracker1
        Me.btnsave.Corners.All = CType(-1, Short)
        Me.btnsave.Corners.LowerLeft = CType(12, Short)
        Me.btnsave.Corners.LowerRight = CType(6, Short)
        Me.btnsave.Corners.UpperLeft = CType(6, Short)
        Me.btnsave.Corners.UpperRight = CType(12, Short)
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.FocalPoints.CenterPtX = 0.4533333!
        Me.btnsave.FocalPoints.CenterPtY = 0.48!
        Me.btnsave.FocalPoints.FocusPtX = 0.0!
        Me.btnsave.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsave.FocusPtTracker = DesignerRectTracker2
        Me.btnsave.Image = Global.Umbrella.My.Resources.Resources.save
        Me.btnsave.ImageIndex = 0
        Me.btnsave.Location = New System.Drawing.Point(296, 39)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 25)
        Me.btnsave.TabIndex = 21
        Me.btnsave.Text = "Save"
        Me.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsave.TextShadowShow = False
        '
        'cmbuser
        '
        Me.cmbuser.Enabled = False
        Me.cmbuser.FormattingEnabled = True
        Me.cmbuser.InstantBinding = True
        Me.cmbuser.Location = New System.Drawing.Point(147, 36)
        Me.cmbuser.Name = "cmbuser"
        Me.cmbuser.Size = New System.Drawing.Size(121, 21)
        Me.cmbuser.TabIndex = 20
        '
        'rbtnoneuser
        '
        Me.rbtnoneuser.AutoSize = True
        Me.rbtnoneuser.Location = New System.Drawing.Point(33, 37)
        Me.rbtnoneuser.Name = "rbtnoneuser"
        Me.rbtnoneuser.Size = New System.Drawing.Size(108, 17)
        Me.rbtnoneuser.TabIndex = 19
        Me.rbtnoneuser.Text = "Only One User"
        Me.rbtnoneuser.UseVisualStyleBackColor = True
        '
        'rbtnalluser
        '
        Me.rbtnalluser.AutoSize = True
        Me.rbtnalluser.Location = New System.Drawing.Point(33, 14)
        Me.rbtnalluser.Name = "rbtnalluser"
        Me.rbtnalluser.Size = New System.Drawing.Size(75, 17)
        Me.rbtnalluser.TabIndex = 18
        Me.rbtnalluser.Text = "All Users"
        Me.rbtnalluser.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(455, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Who should have access to this company's current data from Crystal Reports?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(15, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(549, 39)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'ERoundedPanel1
        '
        Me.ERoundedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.ERoundedPanel1.BorderRadius = 32
        Me.ERoundedPanel1.Controls.Add(Me.btnhelp)
        Me.ERoundedPanel1.Controls.Add(Me.btnrefresh)
        Me.ERoundedPanel1.Controls.Add(Me.btndeleteuser)
        Me.ERoundedPanel1.Controls.Add(Me.btnedituserright)
        Me.ERoundedPanel1.Controls.Add(Me.btnnewuser)
        Me.ERoundedPanel1.Controls.Add(Me.ELabel1)
        Me.ERoundedPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ERoundedPanel1.Location = New System.Drawing.Point(10, 10)
        Me.ERoundedPanel1.Name = "ERoundedPanel1"
        Me.ERoundedPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.ERoundedPanel1.Size = New System.Drawing.Size(684, 60)
        Me.ERoundedPanel1.TabIndex = 2
        '
        'btnhelp
        '
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnhelp.CenterPtTracker = DesignerRectTracker3
        Me.btnhelp.Corners.All = CType(-1, Short)
        Me.btnhelp.Corners.LowerLeft = CType(20, Short)
        Me.btnhelp.Corners.LowerRight = CType(12, Short)
        Me.btnhelp.Corners.UpperLeft = CType(12, Short)
        Me.btnhelp.Corners.UpperRight = CType(20, Short)
        Me.btnhelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhelp.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnhelp.FocalPoints.CenterPtX = 0.5147059!
        Me.btnhelp.FocalPoints.CenterPtY = 0.525!
        Me.btnhelp.FocalPoints.FocusPtX = 0.0!
        Me.btnhelp.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnhelp.FocusPtTracker = DesignerRectTracker4
        Me.btnhelp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhelp.Image = Global.Umbrella.My.Resources.Resources.help
        Me.btnhelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhelp.ImageIndex = 0
        Me.btnhelp.Location = New System.Drawing.Point(465, 10)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(68, 40)
        Me.btnhelp.TabIndex = 41
        Me.btnhelp.Text = "Help"
        Me.btnhelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnrefresh
        '
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnrefresh.CenterPtTracker = DesignerRectTracker5
        Me.btnrefresh.Corners.All = CType(-1, Short)
        Me.btnrefresh.Corners.LowerLeft = CType(20, Short)
        Me.btnrefresh.Corners.LowerRight = CType(12, Short)
        Me.btnrefresh.Corners.UpperLeft = CType(12, Short)
        Me.btnrefresh.Corners.UpperRight = CType(20, Short)
        Me.btnrefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrefresh.Dock = System.Windows.Forms.DockStyle.Left
        DesignerRectTracker6.IsActive = True
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnrefresh.FocusPtTracker = DesignerRectTracker6
        Me.btnrefresh.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.Image = Global.Umbrella.My.Resources.Resources.refresh_icon
        Me.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.ImageIndex = 0
        Me.btnrefresh.Location = New System.Drawing.Point(373, 10)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(92, 40)
        Me.btnrefresh.TabIndex = 40
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btndeleteuser
        '
        DesignerRectTracker7.IsActive = False
        DesignerRectTracker7.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker7.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btndeleteuser.CenterPtTracker = DesignerRectTracker7
        Me.btndeleteuser.Corners.All = CType(-1, Short)
        Me.btndeleteuser.Corners.LowerLeft = CType(20, Short)
        Me.btndeleteuser.Corners.LowerRight = CType(12, Short)
        Me.btndeleteuser.Corners.UpperLeft = CType(12, Short)
        Me.btndeleteuser.Corners.UpperRight = CType(20, Short)
        Me.btndeleteuser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndeleteuser.Dock = System.Windows.Forms.DockStyle.Left
        Me.btndeleteuser.FocalPoints.CenterPtX = 0.5294118!
        Me.btndeleteuser.FocalPoints.CenterPtY = 0.475!
        Me.btndeleteuser.FocalPoints.FocusPtX = 0.0!
        Me.btndeleteuser.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker8.IsActive = False
        DesignerRectTracker8.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker8.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btndeleteuser.FocusPtTracker = DesignerRectTracker8
        Me.btndeleteuser.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeleteuser.Image = Global.Umbrella.My.Resources.Resources.Delete
        Me.btndeleteuser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndeleteuser.ImageIndex = 0
        Me.btndeleteuser.Location = New System.Drawing.Point(253, 10)
        Me.btndeleteuser.Name = "btndeleteuser"
        Me.btndeleteuser.Size = New System.Drawing.Size(120, 40)
        Me.btndeleteuser.TabIndex = 38
        Me.btndeleteuser.Text = "Delete User"
        Me.btndeleteuser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndeleteuser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnedituserright
        '
        DesignerRectTracker9.IsActive = False
        DesignerRectTracker9.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker9.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnedituserright.CenterPtTracker = DesignerRectTracker9
        Me.btnedituserright.Corners.All = CType(-1, Short)
        Me.btnedituserright.Corners.LowerLeft = CType(20, Short)
        Me.btnedituserright.Corners.LowerRight = CType(12, Short)
        Me.btnedituserright.Corners.UpperLeft = CType(12, Short)
        Me.btnedituserright.Corners.UpperRight = CType(20, Short)
        Me.btnedituserright.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnedituserright.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnedituserright.FocalPoints.CenterPtX = 0.4878049!
        Me.btnedituserright.FocalPoints.CenterPtY = 0.475!
        Me.btnedituserright.FocalPoints.FocusPtX = 0.0!
        Me.btnedituserright.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker10.IsActive = False
        DesignerRectTracker10.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker10.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnedituserright.FocusPtTracker = DesignerRectTracker10
        Me.btnedituserright.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedituserright.Image = Global.Umbrella.My.Resources.Resources.edit_icon
        Me.btnedituserright.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnedituserright.ImageIndex = 0
        Me.btnedituserright.Location = New System.Drawing.Point(112, 10)
        Me.btnedituserright.Name = "btnedituserright"
        Me.btnedituserright.Size = New System.Drawing.Size(141, 40)
        Me.btnedituserright.TabIndex = 37
        Me.btnedituserright.Text = "Edit User Right"
        Me.btnedituserright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnedituserright.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnnewuser
        '
        DesignerRectTracker11.IsActive = False
        DesignerRectTracker11.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker11.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnnewuser.CenterPtTracker = DesignerRectTracker11
        Me.btnnewuser.Corners.All = CType(-1, Short)
        Me.btnnewuser.Corners.LowerLeft = CType(20, Short)
        Me.btnnewuser.Corners.LowerRight = CType(12, Short)
        Me.btnnewuser.Corners.UpperLeft = CType(12, Short)
        Me.btnnewuser.Corners.UpperRight = CType(20, Short)
        Me.btnnewuser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnewuser.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnnewuser.FocalPoints.CenterPtX = 0.4558823!
        Me.btnnewuser.FocalPoints.CenterPtY = 0.4!
        Me.btnnewuser.FocalPoints.FocusPtX = 0.0!
        Me.btnnewuser.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker12.IsActive = False
        DesignerRectTracker12.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker12.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnnewuser.FocusPtTracker = DesignerRectTracker12
        Me.btnnewuser.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewuser.Image = Global.Umbrella.My.Resources.Resources._new
        Me.btnnewuser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnewuser.ImageIndex = 0
        Me.btnnewuser.Location = New System.Drawing.Point(10, 10)
        Me.btnnewuser.Name = "btnnewuser"
        Me.btnnewuser.Size = New System.Drawing.Size(102, 40)
        Me.btnnewuser.TabIndex = 36
        Me.btnnewuser.Text = "New User"
        Me.btnnewuser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnewuser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'ELabel1
        '
        Me.ELabel1.AutoFit = True
        Me.ELabel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ELabel1.Feather = 255
        Me.ELabel1.FeatherState = False
        Me.ELabel1.FillType = ESAR_Controls.eLabel.eFillType.GradientLinear
        Me.ELabel1.ForeColor = System.Drawing.Color.LightSteelBlue
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0.0!, 0.113879!, 0.6370107!, 0.9252669!, 1.0!}
        Me.ELabel1.ForeColorBlend = CBlendItems1
        Me.ELabel1.Glow = 0
        Me.ELabel1.GlowColor = System.Drawing.Color.RoyalBlue
        Me.ELabel1.Location = New System.Drawing.Point(541, 10)
        Me.ELabel1.MouseOverColor = System.Drawing.Color.Gray
        Me.ELabel1.Name = "ELabel1"
        Me.ELabel1.ShadowState = True
        Me.ELabel1.Size = New System.Drawing.Size(133, 40)
        Me.ELabel1.TabIndex = 35
        Me.ELabel1.Text = "User Control"
        '
        'frmUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(704, 321)
        Me.Controls.Add(Me.EGradientPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.RoyalLight
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserControl"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Control"
        Me.EGradientPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ETabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.EGroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgviewusers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.ERoundedPanel2.ResumeLayout(False)
        Me.ERoundedPanel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ERoundedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EGradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents ERoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents ELabel1 As ESAR_Controls.eLabel
    Friend WithEvents btnhelp As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnrefresh As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btndeleteuser As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnedituserright As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnnewuser As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ETabControl1 As ESAR_Controls.UIControls.TabControl.eTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents EGroupBox1 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgviewusers As ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ERoundedPanel2 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbuser As ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
    Friend WithEvents rbtnoneuser As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnalluser As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnsave As ESAR_Controls.UIControls.Button.eButton
End Class
