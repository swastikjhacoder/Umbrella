Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiscount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDiscount))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DesignerRectTracker1 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
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
        Me.GradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ETabControl1 = New ESAR_Controls.UIControls.TabControl.eTabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ERoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.cmbdate = New ESAR_Controls.UIControls.ComboBox.eComboBoxDateTime
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtdiscountid = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.ERoundedPanel2 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.txtroll = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtclass = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtname = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbregid = New ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbdiscountfor = New ESAR_Controls.UIControls.ComboBox.eComboBoxIcon
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.ERoundedPanel3 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtremarks = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbauthentication = New ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmbpayvia = New ESAR_Controls.UIControls.ComboBox.eComboBoxIcon
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtpaidamount = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtdiscount = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtdiscountrate = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txttotalamount = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.ERoundedPanel4 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.nudyear = New System.Windows.Forms.NumericUpDown
        Me.Label17 = New System.Windows.Forms.Label
        Me.cmbcourse = New ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
        Me.Label19 = New System.Windows.Forms.Label
        Me.EGroupBox4 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.dgviewstudents = New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
        Me.Column5 = New System.Windows.Forms.DataGridViewLinkColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New ESAR_Controls.UIControls.DataGridView.eNumericTextBoxColumn
        Me.RoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.btnhelp = New ESAR_Controls.UIControls.Button.eButton
        Me.btnrefresh = New ESAR_Controls.UIControls.Button.eButton
        Me.btndelete = New ESAR_Controls.UIControls.Button.eButton
        Me.btnsavenew = New ESAR_Controls.UIControls.Button.eButton
        Me.btnsave = New ESAR_Controls.UIControls.Button.eButton
        Me.btnnew = New ESAR_Controls.UIControls.Button.eButton
        Me.ELabel1 = New ESAR_Controls.eLabel
        Me.GradientPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ETabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ERoundedPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ERoundedPanel2.SuspendLayout()
        Me.ERoundedPanel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.ERoundedPanel4.SuspendLayout()
        CType(Me.nudyear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EGroupBox4.SuspendLayout()
        CType(Me.dgviewstudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GradientPanel1
        '
        Me.GradientPanel1.Controls.Add(Me.Panel1)
        Me.GradientPanel1.Controls.Add(Me.RoundedPanel1)
        Me.GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GradientPanel1.EndColor = System.Drawing.Color.RoyalBlue
        Me.GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanel1.Name = "GradientPanel1"
        Me.GradientPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.GradientPanel1.Size = New System.Drawing.Size(839, 556)
        Me.GradientPanel1.StartColor = System.Drawing.Color.LightCyan
        Me.GradientPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.ETabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(819, 476)
        Me.Panel1.TabIndex = 18
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
        Me.ETabControl1.Size = New System.Drawing.Size(819, 471)
        Me.ETabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(811, 442)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Enter Discount:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ERoundedPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(805, 436)
        Me.SplitContainer1.SplitterDistance = 55
        Me.SplitContainer1.TabIndex = 0
        '
        'ERoundedPanel1
        '
        Me.ERoundedPanel1.BackColor = System.Drawing.Color.White
        Me.ERoundedPanel1.BorderRadius = 32
        Me.ERoundedPanel1.Controls.Add(Me.cmbdate)
        Me.ERoundedPanel1.Controls.Add(Me.Label2)
        Me.ERoundedPanel1.Controls.Add(Me.txtdiscountid)
        Me.ERoundedPanel1.Controls.Add(Me.Label1)
        Me.ERoundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ERoundedPanel1.Name = "ERoundedPanel1"
        Me.ERoundedPanel1.Size = New System.Drawing.Size(805, 55)
        Me.ERoundedPanel1.TabIndex = 0
        '
        'cmbdate
        '
        Me.cmbdate.FormatString = "d"
        Me.cmbdate.FormattingEnabled = True
        Me.cmbdate.Location = New System.Drawing.Point(683, 18)
        Me.cmbdate.Name = "cmbdate"
        Me.cmbdate.Size = New System.Drawing.Size(100, 21)
        Me.cmbdate.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(638, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date:"
        '
        'txtdiscountid
        '
        Me.txtdiscountid.BackColor = System.Drawing.Color.White
        Me.txtdiscountid.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtdiscountid.Location = New System.Drawing.Point(111, 18)
        Me.txtdiscountid.Name = "txtdiscountid"
        Me.txtdiscountid.Required = False
        Me.txtdiscountid.ShowErrorIcon = False
        Me.txtdiscountid.Size = New System.Drawing.Size(121, 21)
        Me.txtdiscountid.TabIndex = 0
        Me.txtdiscountid.TextBox = ""
        Me.txtdiscountid.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtdiscountid.WaterMark = "Enter Discount ID"
        Me.txtdiscountid.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtdiscountid.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiscountid.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Discount ID:"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.IsSplitterFixed = True
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.ERoundedPanel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ERoundedPanel3)
        Me.SplitContainer2.Size = New System.Drawing.Size(805, 377)
        Me.SplitContainer2.SplitterDistance = 516
        Me.SplitContainer2.TabIndex = 0
        '
        'ERoundedPanel2
        '
        Me.ERoundedPanel2.BackColor = System.Drawing.Color.White
        Me.ERoundedPanel2.BorderRadius = 32
        Me.ERoundedPanel2.Controls.Add(Me.txtroll)
        Me.ERoundedPanel2.Controls.Add(Me.Label16)
        Me.ERoundedPanel2.Controls.Add(Me.txtclass)
        Me.ERoundedPanel2.Controls.Add(Me.Label6)
        Me.ERoundedPanel2.Controls.Add(Me.txtname)
        Me.ERoundedPanel2.Controls.Add(Me.Label5)
        Me.ERoundedPanel2.Controls.Add(Me.cmbregid)
        Me.ERoundedPanel2.Controls.Add(Me.Label4)
        Me.ERoundedPanel2.Controls.Add(Me.cmbdiscountfor)
        Me.ERoundedPanel2.Controls.Add(Me.Label3)
        Me.ERoundedPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel2.Location = New System.Drawing.Point(0, 0)
        Me.ERoundedPanel2.Name = "ERoundedPanel2"
        Me.ERoundedPanel2.Size = New System.Drawing.Size(516, 377)
        Me.ERoundedPanel2.TabIndex = 0
        '
        'txtroll
        '
        Me.txtroll.BackColor = System.Drawing.Color.White
        Me.txtroll.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtroll.Location = New System.Drawing.Point(358, 67)
        Me.txtroll.Name = "txtroll"
        Me.txtroll.Required = False
        Me.txtroll.ShowErrorIcon = False
        Me.txtroll.Size = New System.Drawing.Size(121, 21)
        Me.txtroll.TabIndex = 4
        Me.txtroll.TextBox = ""
        Me.txtroll.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtroll.WaterMark = "Enter Roll"
        Me.txtroll.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtroll.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtroll.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(319, 70)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 13)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Roll:"
        '
        'txtclass
        '
        Me.txtclass.BackColor = System.Drawing.Color.White
        Me.txtclass.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtclass.Location = New System.Drawing.Point(111, 67)
        Me.txtclass.Name = "txtclass"
        Me.txtclass.Required = False
        Me.txtclass.ShowErrorIcon = False
        Me.txtclass.Size = New System.Drawing.Size(121, 21)
        Me.txtclass.TabIndex = 3
        Me.txtclass.TextBox = ""
        Me.txtclass.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtclass.WaterMark = "Enter Class"
        Me.txtclass.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtclass.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclass.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Class"
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.White
        Me.txtname.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtname.Location = New System.Drawing.Point(111, 40)
        Me.txtname.Name = "txtname"
        Me.txtname.Required = False
        Me.txtname.ShowErrorIcon = False
        Me.txtname.Size = New System.Drawing.Size(368, 21)
        Me.txtname.TabIndex = 2
        Me.txtname.TextBox = ""
        Me.txtname.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtname.WaterMark = "Enter Name"
        Me.txtname.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtname.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Name:"
        '
        'cmbregid
        '
        Me.cmbregid.FormattingEnabled = True
        Me.cmbregid.InstantBinding = True
        Me.cmbregid.Location = New System.Drawing.Point(358, 12)
        Me.cmbregid.Name = "cmbregid"
        Me.cmbregid.Size = New System.Drawing.Size(121, 21)
        Me.cmbregid.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(254, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Registration ID:"
        '
        'cmbdiscountfor
        '
        Me.cmbdiscountfor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbdiscountfor.FormattingEnabled = True
        Me.cmbdiscountfor.ImageList = Me.ImageList1
        Me.cmbdiscountfor.Location = New System.Drawing.Point(111, 12)
        Me.cmbdiscountfor.Name = "cmbdiscountfor"
        Me.cmbdiscountfor.Size = New System.Drawing.Size(121, 22)
        Me.cmbdiscountfor.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "admission-icon.png")
        Me.ImageList1.Images.SetKeyName(1, "employee.png")
        Me.ImageList1.Images.SetKeyName(2, "about-help.png")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Discount For:"
        '
        'ERoundedPanel3
        '
        Me.ERoundedPanel3.BackColor = System.Drawing.Color.White
        Me.ERoundedPanel3.BorderRadius = 32
        Me.ERoundedPanel3.Controls.Add(Me.GroupBox2)
        Me.ERoundedPanel3.Controls.Add(Me.GroupBox1)
        Me.ERoundedPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel3.Location = New System.Drawing.Point(0, 0)
        Me.ERoundedPanel3.Name = "ERoundedPanel3"
        Me.ERoundedPanel3.Padding = New System.Windows.Forms.Padding(10)
        Me.ERoundedPanel3.Size = New System.Drawing.Size(285, 377)
        Me.ERoundedPanel3.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtremarks)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmbauthentication)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.cmbpayvia)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(10, 146)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(265, 221)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'txtremarks
        '
        Me.txtremarks.BackColor = System.Drawing.Color.White
        Me.txtremarks.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtremarks.Location = New System.Drawing.Point(13, 90)
        Me.txtremarks.Multiline = True
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Required = False
        Me.txtremarks.ShowErrorIcon = False
        Me.txtremarks.Size = New System.Drawing.Size(241, 84)
        Me.txtremarks.TabIndex = 2
        Me.txtremarks.TextBox = ""
        Me.txtremarks.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtremarks.WaterMark = "Enter Remarks"
        Me.txtremarks.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtremarks.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremarks.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Remarks:"
        '
        'cmbauthentication
        '
        Me.cmbauthentication.FormattingEnabled = True
        Me.cmbauthentication.InstantBinding = True
        Me.cmbauthentication.Location = New System.Drawing.Point(111, 44)
        Me.cmbauthentication.Name = "cmbauthentication"
        Me.cmbauthentication.Size = New System.Drawing.Size(142, 21)
        Me.cmbauthentication.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Authentication:"
        '
        'cmbpayvia
        '
        Me.cmbpayvia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbpayvia.FormattingEnabled = True
        Me.cmbpayvia.ImageList = Me.ImageList2
        Me.cmbpayvia.Location = New System.Drawing.Point(111, 16)
        Me.cmbpayvia.Name = "cmbpayvia"
        Me.cmbpayvia.Size = New System.Drawing.Size(60, 22)
        Me.cmbpayvia.TabIndex = 0
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "cash.png")
        Me.ImageList2.Images.SetKeyName(1, "check.png")
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Pay Via:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtpaidamount)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtdiscount)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtdiscountrate)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txttotalamount)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 136)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Discount Account:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(177, 106)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(17, 13)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "/-"
        '
        'txtpaidamount
        '
        Me.txtpaidamount.BackColor = System.Drawing.Color.White
        Me.txtpaidamount.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtpaidamount.Location = New System.Drawing.Point(111, 103)
        Me.txtpaidamount.Name = "txtpaidamount"
        Me.txtpaidamount.Required = False
        Me.txtpaidamount.ShowErrorIcon = True
        Me.txtpaidamount.Size = New System.Drawing.Size(60, 21)
        Me.txtpaidamount.TabIndex = 3
        Me.txtpaidamount.TextBox = Nothing
        Me.txtpaidamount.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.Numbers
        Me.txtpaidamount.WaterMark = "0.00"
        Me.txtpaidamount.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtpaidamount.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpaidamount.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(11, 106)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(81, 13)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Pay Amount:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(177, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "/-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(177, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "%"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(177, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "/-"
        '
        'txtdiscount
        '
        Me.txtdiscount.BackColor = System.Drawing.Color.White
        Me.txtdiscount.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtdiscount.Location = New System.Drawing.Point(111, 76)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Required = False
        Me.txtdiscount.ShowErrorIcon = True
        Me.txtdiscount.Size = New System.Drawing.Size(60, 21)
        Me.txtdiscount.TabIndex = 2
        Me.txtdiscount.TextBox = Nothing
        Me.txtdiscount.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.Numbers
        Me.txtdiscount.WaterMark = "0.00"
        Me.txtdiscount.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtdiscount.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiscount.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Discount:"
        '
        'txtdiscountrate
        '
        Me.txtdiscountrate.BackColor = System.Drawing.Color.White
        Me.txtdiscountrate.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtdiscountrate.Location = New System.Drawing.Point(111, 49)
        Me.txtdiscountrate.Name = "txtdiscountrate"
        Me.txtdiscountrate.Required = False
        Me.txtdiscountrate.ShowErrorIcon = True
        Me.txtdiscountrate.Size = New System.Drawing.Size(60, 21)
        Me.txtdiscountrate.TabIndex = 1
        Me.txtdiscountrate.TextBox = Nothing
        Me.txtdiscountrate.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.Numbers
        Me.txtdiscountrate.WaterMark = "0.00"
        Me.txtdiscountrate.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtdiscountrate.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiscountrate.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Discount Rate:"
        '
        'txttotalamount
        '
        Me.txttotalamount.BackColor = System.Drawing.Color.White
        Me.txttotalamount.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txttotalamount.Location = New System.Drawing.Point(111, 21)
        Me.txttotalamount.Name = "txttotalamount"
        Me.txttotalamount.Required = False
        Me.txttotalamount.ShowErrorIcon = True
        Me.txttotalamount.Size = New System.Drawing.Size(60, 21)
        Me.txttotalamount.TabIndex = 0
        Me.txttotalamount.TextBox = Nothing
        Me.txttotalamount.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.Numbers
        Me.txttotalamount.WaterMark = "0.00"
        Me.txttotalamount.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txttotalamount.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalamount.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Total Amount:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage2.Controls.Add(Me.SplitContainer3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(811, 442)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Apply Discount:"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.IsSplitterFixed = True
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.ERoundedPanel4)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.EGroupBox4)
        Me.SplitContainer3.Size = New System.Drawing.Size(805, 436)
        Me.SplitContainer3.SplitterDistance = 55
        Me.SplitContainer3.TabIndex = 0
        '
        'ERoundedPanel4
        '
        Me.ERoundedPanel4.BackColor = System.Drawing.Color.White
        Me.ERoundedPanel4.BorderRadius = 32
        Me.ERoundedPanel4.Controls.Add(Me.nudyear)
        Me.ERoundedPanel4.Controls.Add(Me.Label17)
        Me.ERoundedPanel4.Controls.Add(Me.cmbcourse)
        Me.ERoundedPanel4.Controls.Add(Me.Label19)
        Me.ERoundedPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel4.Location = New System.Drawing.Point(0, 0)
        Me.ERoundedPanel4.Name = "ERoundedPanel4"
        Me.ERoundedPanel4.Size = New System.Drawing.Size(805, 55)
        Me.ERoundedPanel4.TabIndex = 1
        '
        'nudyear
        '
        Me.nudyear.Location = New System.Drawing.Point(358, 18)
        Me.nudyear.Name = "nudyear"
        Me.nudyear.Size = New System.Drawing.Size(60, 21)
        Me.nudyear.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(276, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Select Year:"
        '
        'cmbcourse
        '
        Me.cmbcourse.FormattingEnabled = True
        Me.cmbcourse.InstantBinding = True
        Me.cmbcourse.Location = New System.Drawing.Point(120, 18)
        Me.cmbcourse.Name = "cmbcourse"
        Me.cmbcourse.Size = New System.Drawing.Size(140, 21)
        Me.cmbcourse.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(22, 21)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(92, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Select Course:"
        '
        'EGroupBox4
        '
        Me.EGroupBox4.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox4.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox4.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox4.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox4.BorderThickness = 1.0!
        Me.EGroupBox4.Controls.Add(Me.dgviewstudents)
        Me.EGroupBox4.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox4.GroupImage = Nothing
        Me.EGroupBox4.GroupTitle = "Enter Discount:"
        Me.EGroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.EGroupBox4.Name = "EGroupBox4"
        Me.EGroupBox4.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.EGroupBox4.PaintGroupBox = False
        Me.EGroupBox4.RoundCorners = 10
        Me.EGroupBox4.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox4.ShadowControl = False
        Me.EGroupBox4.ShadowThickness = 3
        Me.EGroupBox4.Size = New System.Drawing.Size(805, 377)
        Me.EGroupBox4.TabIndex = 3
        '
        'dgviewstudents
        '
        Me.dgviewstudents.AllowUserToAddRows = False
        Me.dgviewstudents.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgviewstudents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgviewstudents.BackgroundColor = System.Drawing.Color.White
        Me.dgviewstudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgviewstudents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.DataGridViewTextBoxColumn1, Me.Column6, Me.Column7, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewstudents.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgviewstudents.DisplaySumRowHeader = True
        Me.dgviewstudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewstudents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgviewstudents.Location = New System.Drawing.Point(10, 25)
        Me.dgviewstudents.MultiSelect = False
        Me.dgviewstudents.Name = "dgviewstudents"
        Me.dgviewstudents.RowHeadersVisible = False
        Me.dgviewstudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgviewstudents.Size = New System.Drawing.Size(785, 342)
        Me.dgviewstudents.SummaryColumns = New String() {"Records"}
        Me.dgviewstudents.SummaryRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgviewstudents.SummaryRowSpace = 0
        Me.dgviewstudents.SummaryRowVisible = True
        Me.dgviewstudents.SumRowHeaderText = "Total Records:"
        Me.dgviewstudents.SumRowHeaderTextBold = True
        Me.dgviewstudents.TabIndex = 2
        '
        'Column5
        '
        Me.Column5.HeaderText = "Registration ID"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 120
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 160
        '
        'Column6
        '
        Me.Column6.HeaderText = "Class"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Roll"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Course"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AllowDateSep = False
        Me.DataGridViewTextBoxColumn5.AllowDecimal = True
        Me.DataGridViewTextBoxColumn5.AllowMinus = False
        Me.DataGridViewTextBoxColumn5.HeaderText = "Discount"
        Me.DataGridViewTextBoxColumn5.MaxInputLength = 0
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.RoundedPanel1.BorderRadius = 32
        Me.RoundedPanel1.Controls.Add(Me.btnhelp)
        Me.RoundedPanel1.Controls.Add(Me.btnrefresh)
        Me.RoundedPanel1.Controls.Add(Me.btndelete)
        Me.RoundedPanel1.Controls.Add(Me.btnsavenew)
        Me.RoundedPanel1.Controls.Add(Me.btnsave)
        Me.RoundedPanel1.Controls.Add(Me.btnnew)
        Me.RoundedPanel1.Controls.Add(Me.ELabel1)
        Me.RoundedPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RoundedPanel1.Location = New System.Drawing.Point(10, 10)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.RoundedPanel1.Size = New System.Drawing.Size(819, 60)
        Me.RoundedPanel1.TabIndex = 17
        '
        'btnhelp
        '
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnhelp.CenterPtTracker = DesignerRectTracker1
        Me.btnhelp.ColorFillSolid = System.Drawing.Color.White
        Me.btnhelp.Corners.All = CType(-1, Short)
        Me.btnhelp.Corners.LowerLeft = CType(20, Short)
        Me.btnhelp.Corners.LowerRight = CType(12, Short)
        Me.btnhelp.Corners.UpperLeft = CType(12, Short)
        Me.btnhelp.Corners.UpperRight = CType(20, Short)
        Me.btnhelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhelp.Dock = System.Windows.Forms.DockStyle.Left
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnhelp.FocusPtTracker = DesignerRectTracker2
        Me.btnhelp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhelp.Image = Global.Umbrella.My.Resources.Resources.help
        Me.btnhelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhelp.ImageIndex = 0
        Me.btnhelp.Location = New System.Drawing.Point(430, 10)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(63, 40)
        Me.btnhelp.TabIndex = 83
        Me.btnhelp.Text = "Help"
        Me.btnhelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhelp.TextShadowShow = False
        '
        'btnrefresh
        '
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnrefresh.CenterPtTracker = DesignerRectTracker3
        Me.btnrefresh.ColorFillSolid = System.Drawing.Color.White
        Me.btnrefresh.Corners.All = CType(-1, Short)
        Me.btnrefresh.Corners.LowerLeft = CType(20, Short)
        Me.btnrefresh.Corners.LowerRight = CType(12, Short)
        Me.btnrefresh.Corners.UpperLeft = CType(12, Short)
        Me.btnrefresh.Corners.UpperRight = CType(20, Short)
        Me.btnrefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnrefresh.FocalPoints.CenterPtX = 0.4444444!
        Me.btnrefresh.FocalPoints.CenterPtY = 0.65!
        Me.btnrefresh.FocalPoints.FocusPtX = 0.0!
        Me.btnrefresh.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnrefresh.FocusPtTracker = DesignerRectTracker4
        Me.btnrefresh.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.Image = Global.Umbrella.My.Resources.Resources.refresh_icon
        Me.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.ImageIndex = 0
        Me.btnrefresh.Location = New System.Drawing.Point(343, 10)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(87, 40)
        Me.btnrefresh.TabIndex = 82
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnrefresh.TextShadowShow = False
        '
        'btndelete
        '
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btndelete.CenterPtTracker = DesignerRectTracker5
        Me.btndelete.ColorFillSolid = System.Drawing.Color.White
        Me.btndelete.Corners.All = CType(-1, Short)
        Me.btndelete.Corners.LowerLeft = CType(20, Short)
        Me.btndelete.Corners.LowerRight = CType(12, Short)
        Me.btndelete.Corners.UpperLeft = CType(12, Short)
        Me.btndelete.Corners.UpperRight = CType(20, Short)
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndelete.Dock = System.Windows.Forms.DockStyle.Left
        Me.btndelete.FocalPoints.CenterPtX = 0.5063291!
        Me.btndelete.FocalPoints.CenterPtY = 0.4!
        Me.btndelete.FocalPoints.FocusPtX = 0.0!
        Me.btndelete.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btndelete.FocusPtTracker = DesignerRectTracker6
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Image = Global.Umbrella.My.Resources.Resources.Delete
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndelete.ImageIndex = 0
        Me.btndelete.Location = New System.Drawing.Point(264, 10)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(79, 40)
        Me.btndelete.TabIndex = 81
        Me.btndelete.Text = "Delete"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btndelete.TextShadowShow = False
        '
        'btnsavenew
        '
        DesignerRectTracker7.IsActive = False
        DesignerRectTracker7.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker7.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsavenew.CenterPtTracker = DesignerRectTracker7
        Me.btnsavenew.ColorFillSolid = System.Drawing.Color.White
        Me.btnsavenew.Corners.All = CType(-1, Short)
        Me.btnsavenew.Corners.LowerLeft = CType(20, Short)
        Me.btnsavenew.Corners.LowerRight = CType(12, Short)
        Me.btnsavenew.Corners.UpperLeft = CType(12, Short)
        Me.btnsavenew.Corners.UpperRight = CType(20, Short)
        Me.btnsavenew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsavenew.Dock = System.Windows.Forms.DockStyle.Left
        DesignerRectTracker8.IsActive = False
        DesignerRectTracker8.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker8.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsavenew.FocusPtTracker = DesignerRectTracker8
        Me.btnsavenew.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsavenew.Image = Global.Umbrella.My.Resources.Resources.SaveNew
        Me.btnsavenew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsavenew.ImageIndex = 0
        Me.btnsavenew.Location = New System.Drawing.Point(144, 10)
        Me.btnsavenew.Name = "btnsavenew"
        Me.btnsavenew.Size = New System.Drawing.Size(120, 40)
        Me.btnsavenew.TabIndex = 80
        Me.btnsavenew.Text = "Save && New"
        Me.btnsavenew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsavenew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsavenew.TextShadowShow = False
        '
        'btnsave
        '
        DesignerRectTracker9.IsActive = False
        DesignerRectTracker9.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker9.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsave.CenterPtTracker = DesignerRectTracker9
        Me.btnsave.ColorFillSolid = System.Drawing.Color.White
        Me.btnsave.Corners.All = CType(-1, Short)
        Me.btnsave.Corners.LowerLeft = CType(20, Short)
        Me.btnsave.Corners.LowerRight = CType(12, Short)
        Me.btnsave.Corners.UpperLeft = CType(12, Short)
        Me.btnsave.Corners.UpperRight = CType(20, Short)
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnsave.FocalPoints.CenterPtX = 0.0!
        Me.btnsave.FocalPoints.CenterPtY = 0.425!
        Me.btnsave.FocalPoints.FocusPtX = 0.0!
        Me.btnsave.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker10.IsActive = False
        DesignerRectTracker10.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker10.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsave.FocusPtTracker = DesignerRectTracker10
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Image = Global.Umbrella.My.Resources.Resources.save
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.ImageIndex = 0
        Me.btnsave.Location = New System.Drawing.Point(73, 10)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(71, 40)
        Me.btnsave.TabIndex = 79
        Me.btnsave.Text = "Save"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsave.TextShadowShow = False
        '
        'btnnew
        '
        DesignerRectTracker11.IsActive = False
        DesignerRectTracker11.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker11.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnnew.CenterPtTracker = DesignerRectTracker11
        Me.btnnew.ColorFillSolid = System.Drawing.Color.White
        Me.btnnew.Corners.All = CType(-1, Short)
        Me.btnnew.Corners.LowerLeft = CType(20, Short)
        Me.btnnew.Corners.LowerRight = CType(12, Short)
        Me.btnnew.Corners.UpperLeft = CType(12, Short)
        Me.btnnew.Corners.UpperRight = CType(20, Short)
        Me.btnnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnew.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnnew.FocalPoints.CenterPtX = 0.3809524!
        Me.btnnew.FocalPoints.CenterPtY = 0.475!
        Me.btnnew.FocalPoints.FocusPtX = 0.0!
        Me.btnnew.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker12.IsActive = False
        DesignerRectTracker12.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker12.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnnew.FocusPtTracker = DesignerRectTracker12
        Me.btnnew.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.Image = Global.Umbrella.My.Resources.Resources._new
        Me.btnnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnew.ImageIndex = 0
        Me.btnnew.Location = New System.Drawing.Point(10, 10)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(63, 40)
        Me.btnnew.TabIndex = 78
        Me.btnnew.Text = "New"
        Me.btnnew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnnew.TextShadowShow = False
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
        Me.ELabel1.Location = New System.Drawing.Point(606, 10)
        Me.ELabel1.MouseOverColor = System.Drawing.Color.Gray
        Me.ELabel1.Name = "ELabel1"
        Me.ELabel1.ShadowState = True
        Me.ELabel1.Size = New System.Drawing.Size(203, 40)
        Me.ELabel1.TabIndex = 34
        Me.ELabel1.Text = "Maintain Discount"
        '
        'frmDiscount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(839, 556)
        Me.ControlBox = False
        Me.Controls.Add(Me.GradientPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.Custom
        Me.Name = "frmDiscount"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maintain Discount"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GradientPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ETabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ERoundedPanel1.ResumeLayout(False)
        Me.ERoundedPanel1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.ERoundedPanel2.ResumeLayout(False)
        Me.ERoundedPanel2.PerformLayout()
        Me.ERoundedPanel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.ERoundedPanel4.ResumeLayout(False)
        Me.ERoundedPanel4.PerformLayout()
        CType(Me.nudyear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EGroupBox4.ResumeLayout(False)
        CType(Me.dgviewstudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents RoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ELabel1 As ESAR_Controls.eLabel
    Friend WithEvents btnhelp As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnrefresh As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btndelete As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnsavenew As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnsave As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnnew As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ETabControl1 As ESAR_Controls.UIControls.TabControl.eTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ERoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents cmbdate As ESAR_Controls.UIControls.ComboBox.eComboBoxDateTime
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdiscountid As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ERoundedPanel2 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbdiscountfor As ESAR_Controls.UIControls.ComboBox.eComboBoxIcon
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtclass As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtname As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbregid As ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
    Friend WithEvents ERoundedPanel3 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents txtroll As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtpaidamount As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtdiscount As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtdiscountrate As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txttotalamount As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtremarks As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbauthentication As ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbpayvia As ESAR_Controls.UIControls.ComboBox.eComboBoxIcon
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents ERoundedPanel4 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents nudyear As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmbcourse As ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents EGroupBox4 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents dgviewstudents As ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As ESAR_Controls.UIControls.DataGridView.eNumericTextBoxColumn
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
End Class
