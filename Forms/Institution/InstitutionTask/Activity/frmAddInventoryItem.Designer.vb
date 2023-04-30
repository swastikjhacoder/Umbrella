Imports Umbrella.UIControls
Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddInventoryItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddInventoryItem))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
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
        Dim DesignerRectTracker13 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker14 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim CBlendItems1 As ESAR_Controls.cBlendItems = New ESAR_Controls.cBlendItems
        Me.EGradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.EGroupBox1 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.txtitemid = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtitemshort = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtitemname = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbitemclass = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.EGroupBox2 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.chkcommission = New System.Windows.Forms.CheckBox
        Me.cmbshape = New ESAR_Controls.UIControls.ComboBox.eComboBoxIcon
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.chkinactive = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbsize = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ETabControl1 = New ESAR_Controls.UIControls.TabControl.eTabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.ERoundedPanel2 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.txtminstock = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtlastprice = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtweight = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.cmbminstockunit = New System.Windows.Forms.ComboBox
        Me.lblminimumstockhead = New System.Windows.Forms.Label
        Me.lblsoldunit = New System.Windows.Forms.Label
        Me.cmbweight = New System.Windows.Forms.ComboBox
        Me.lbllastunitcost = New System.Windows.Forms.Label
        Me.lblweight = New System.Windows.Forms.Label
        Me.cmbstocking = New System.Windows.Forms.ComboBox
        Me.lblstocking = New System.Windows.Forms.Label
        Me.cmbitemtype = New System.Windows.Forms.ComboBox
        Me.lblitemtype = New System.Windows.Forms.Label
        Me.ERoundedPanel3 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.lblcostingacc = New System.Windows.Forms.Label
        Me.lblglcostacc = New System.Windows.Forms.Label
        Me.lblglinvtryacc = New System.Windows.Forms.Label
        Me.lblglsalesacc = New System.Windows.Forms.Label
        Me.lblcostingacchead = New System.Windows.Forms.Label
        Me.lblglcostacchead = New System.Windows.Forms.Label
        Me.txtvendor = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.lblglinvtryacchead = New System.Windows.Forms.Label
        Me.lblglsalesacchead = New System.Windows.Forms.Label
        Me.lblpreferredvendor = New System.Windows.Forms.Label
        Me.ERoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.txtitemlong = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtpricelevel = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.btnpricelevel = New System.Windows.Forms.Button
        Me.lblqntyunit = New System.Windows.Forms.Label
        Me.lblqntyonhand = New System.Windows.Forms.Label
        Me.lblqntyonhandhead = New System.Windows.Forms.Label
        Me.cmbtaxtype = New System.Windows.Forms.ComboBox
        Me.cmbcostmethod = New System.Windows.Forms.ComboBox
        Me.lblcostmethod = New System.Windows.Forms.Label
        Me.lblpricelevel = New System.Windows.Forms.Label
        Me.cmbdescription = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.dgviewcustomfield = New System.Windows.Forms.DataGridView
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.dgviewitemhistory = New System.Windows.Forms.DataGridView
        Me.clmassitemid = New System.Windows.Forms.DataGridViewLinkColumn
        Me.clmassitemname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmassitemcls = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmassiteminvno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New ESAR_Controls.UIControls.DataGridView.eCalendarColumn
        Me.Column1 = New ESAR_Controls.UIControls.DataGridView.eNumericTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.btnhelp = New ESAR_Controls.UIControls.Button.eButton
        Me.btnrefresh = New ESAR_Controls.UIControls.Button.eButton
        Me.btnnote = New ESAR_Controls.UIControls.Button.eButton
        Me.btndelete = New ESAR_Controls.UIControls.Button.eButton
        Me.btnsavenew = New ESAR_Controls.UIControls.Button.eButton
        Me.btnsave = New ESAR_Controls.UIControls.Button.eButton
        Me.btnnew = New ESAR_Controls.UIControls.Button.eButton
        Me.ELabel1 = New ESAR_Controls.eLabel
        Me.EGradientPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.EGroupBox1.SuspendLayout()
        Me.EGroupBox2.SuspendLayout()
        Me.ETabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ERoundedPanel2.SuspendLayout()
        Me.ERoundedPanel3.SuspendLayout()
        Me.ERoundedPanel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgviewcustomfield, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgviewitemhistory, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.EGradientPanel1.Size = New System.Drawing.Size(839, 556)
        Me.EGradientPanel1.StartColor = System.Drawing.Color.LightCyan
        Me.EGradientPanel1.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(10, 70)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ETabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(819, 476)
        Me.SplitContainer1.SplitterDistance = 125
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.IsSplitterFixed = True
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.EGroupBox1)
        Me.SplitContainer3.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.EGroupBox2)
        Me.SplitContainer3.Panel2.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.SplitContainer3.Size = New System.Drawing.Size(819, 125)
        Me.SplitContainer3.SplitterDistance = 470
        Me.SplitContainer3.TabIndex = 0
        '
        'EGroupBox1
        '
        Me.EGroupBox1.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox1.BorderThickness = 1.0!
        Me.EGroupBox1.Controls.Add(Me.txtitemid)
        Me.EGroupBox1.Controls.Add(Me.txtitemshort)
        Me.EGroupBox1.Controls.Add(Me.txtitemname)
        Me.EGroupBox1.Controls.Add(Me.Label7)
        Me.EGroupBox1.Controls.Add(Me.cmbitemclass)
        Me.EGroupBox1.Controls.Add(Me.Label4)
        Me.EGroupBox1.Controls.Add(Me.Label2)
        Me.EGroupBox1.Controls.Add(Me.Label3)
        Me.EGroupBox1.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox1.GroupImage = Nothing
        Me.EGroupBox1.GroupTitle = "General Info:"
        Me.EGroupBox1.Location = New System.Drawing.Point(0, 5)
        Me.EGroupBox1.Name = "EGroupBox1"
        Me.EGroupBox1.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.EGroupBox1.PaintGroupBox = False
        Me.EGroupBox1.RoundCorners = 10
        Me.EGroupBox1.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox1.ShadowControl = False
        Me.EGroupBox1.ShadowThickness = 3
        Me.EGroupBox1.Size = New System.Drawing.Size(470, 120)
        Me.EGroupBox1.TabIndex = 0
        '
        'txtitemid
        '
        Me.txtitemid.BackColor = System.Drawing.Color.White
        Me.txtitemid.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtitemid.Location = New System.Drawing.Point(742, 31)
        Me.txtitemid.Name = "txtitemid"
        Me.txtitemid.Required = False
        Me.txtitemid.ShowErrorIcon = False
        Me.txtitemid.Size = New System.Drawing.Size(795, 21)
        Me.txtitemid.TabIndex = 0
        Me.txtitemid.TextBox = ""
        Me.txtitemid.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtitemid.WaterMark = "Enter Item ID"
        Me.txtitemid.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtitemid.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitemid.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtitemshort
        '
        Me.txtitemshort.BackColor = System.Drawing.Color.White
        Me.txtitemshort.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtitemshort.Location = New System.Drawing.Point(742, 85)
        Me.txtitemshort.Name = "txtitemshort"
        Me.txtitemshort.Required = False
        Me.txtitemshort.ShowErrorIcon = False
        Me.txtitemshort.Size = New System.Drawing.Size(4048, 21)
        Me.txtitemshort.TabIndex = 3
        Me.txtitemshort.TextBox = ""
        Me.txtitemshort.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtitemshort.WaterMark = "Enter item short description"
        Me.txtitemshort.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtitemshort.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitemshort.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtitemname
        '
        Me.txtitemname.BackColor = System.Drawing.Color.White
        Me.txtitemname.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtitemname.Location = New System.Drawing.Point(742, 58)
        Me.txtitemname.Name = "txtitemname"
        Me.txtitemname.Required = False
        Me.txtitemname.ShowErrorIcon = False
        Me.txtitemname.Size = New System.Drawing.Size(4048, 21)
        Me.txtitemname.TabIndex = 2
        Me.txtitemname.TextBox = ""
        Me.txtitemname.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtitemname.WaterMark = "Enter Item Name"
        Me.txtitemname.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtitemname.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitemname.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(142, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Description:"
        '
        'cmbitemclass
        '
        Me.cmbitemclass.BackColor = System.Drawing.Color.White
        Me.cmbitemclass.FormattingEnabled = True
        Me.cmbitemclass.Items.AddRange(New Object() {"Stock Item", "Master Item", "Non Stock Item", "Description Only", "Service Item", "Labor Item", "Assembly Item", "Activity Item", "Charge Item"})
        Me.cmbitemclass.Location = New System.Drawing.Point(2183, 31)
        Me.cmbitemclass.Name = "cmbitemclass"
        Me.cmbitemclass.Size = New System.Drawing.Size(1326, 21)
        Me.cmbitemclass.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1632, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Item Class:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(142, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Item Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Item ID:"
        '
        'EGroupBox2
        '
        Me.EGroupBox2.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox2.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox2.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox2.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox2.BorderThickness = 1.0!
        Me.EGroupBox2.Controls.Add(Me.chkcommission)
        Me.EGroupBox2.Controls.Add(Me.cmbshape)
        Me.EGroupBox2.Controls.Add(Me.chkinactive)
        Me.EGroupBox2.Controls.Add(Me.Label6)
        Me.EGroupBox2.Controls.Add(Me.cmbsize)
        Me.EGroupBox2.Controls.Add(Me.Label5)
        Me.EGroupBox2.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox2.GroupImage = Nothing
        Me.EGroupBox2.GroupTitle = "Item Attribute:"
        Me.EGroupBox2.Location = New System.Drawing.Point(5, 5)
        Me.EGroupBox2.Name = "EGroupBox2"
        Me.EGroupBox2.Padding = New System.Windows.Forms.Padding(12, 25, 12, 10)
        Me.EGroupBox2.PaintGroupBox = False
        Me.EGroupBox2.RoundCorners = 10
        Me.EGroupBox2.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox2.ShadowControl = False
        Me.EGroupBox2.ShadowThickness = 3
        Me.EGroupBox2.Size = New System.Drawing.Size(340, 120)
        Me.EGroupBox2.TabIndex = 1
        '
        'chkcommission
        '
        Me.chkcommission.AutoSize = True
        Me.chkcommission.Location = New System.Drawing.Point(518, 89)
        Me.chkcommission.Name = "chkcommission"
        Me.chkcommission.Size = New System.Drawing.Size(155, 17)
        Me.chkcommission.TabIndex = 39
        Me.chkcommission.Text = "Subject to commission"
        Me.chkcommission.UseVisualStyleBackColor = True
        '
        'cmbshape
        '
        Me.cmbshape.BackColor = System.Drawing.Color.White
        Me.cmbshape.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbshape.FormattingEnabled = True
        Me.cmbshape.ImageList = Me.ImageList1
        Me.cmbshape.Location = New System.Drawing.Point(252, 55)
        Me.cmbshape.Name = "cmbshape"
        Me.cmbshape.Size = New System.Drawing.Size(709, 22)
        Me.cmbshape.TabIndex = 1
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "1 Polygon.png")
        Me.ImageList1.Images.SetKeyName(1, "2 Quadrilaterals.png")
        Me.ImageList1.Images.SetKeyName(2, "3 Square.png")
        Me.ImageList1.Images.SetKeyName(3, "4 Triangle.png")
        Me.ImageList1.Images.SetKeyName(4, "5 Rectangle.png")
        Me.ImageList1.Images.SetKeyName(5, "6 Parallelogram.png")
        Me.ImageList1.Images.SetKeyName(6, "7 Pentagon.png")
        Me.ImageList1.Images.SetKeyName(7, "8 Hexagon.png")
        Me.ImageList1.Images.SetKeyName(8, "9 Heptagon.png")
        Me.ImageList1.Images.SetKeyName(9, "10 Octagon.png")
        Me.ImageList1.Images.SetKeyName(10, "11 Nonagon.png")
        Me.ImageList1.Images.SetKeyName(11, "12 Decagon.png")
        Me.ImageList1.Images.SetKeyName(12, "13 Cube.png")
        Me.ImageList1.Images.SetKeyName(13, "14 Cuboid.png")
        Me.ImageList1.Images.SetKeyName(14, "15 Sphere.png")
        Me.ImageList1.Images.SetKeyName(15, "16 Cylinder.png")
        Me.ImageList1.Images.SetKeyName(16, "17 Cone.png")
        Me.ImageList1.Images.SetKeyName(17, "18 Triangular Prism.png")
        Me.ImageList1.Images.SetKeyName(18, "19 Hexagonal Prism.png")
        Me.ImageList1.Images.SetKeyName(19, "20 Triangular-based Pyramid.png")
        Me.ImageList1.Images.SetKeyName(20, "21 Square-based Pyramid.png")
        Me.ImageList1.Images.SetKeyName(21, "22 Hexagonal Pyramid.PNG")
        Me.ImageList1.Images.SetKeyName(22, "23 Trapezium.png")
        Me.ImageList1.Images.SetKeyName(23, "24 Kite.png")
        Me.ImageList1.Images.SetKeyName(24, "25 Trapezoid.png")
        Me.ImageList1.Images.SetKeyName(25, "26 Parallelogram.png")
        Me.ImageList1.Images.SetKeyName(26, "27 Rhombus.png")
        Me.ImageList1.Images.SetKeyName(27, "help.png")
        '
        'chkinactive
        '
        Me.chkinactive.AutoSize = True
        Me.chkinactive.Location = New System.Drawing.Point(252, 89)
        Me.chkinactive.Name = "chkinactive"
        Me.chkinactive.Size = New System.Drawing.Size(72, 17)
        Me.chkinactive.TabIndex = 35
        Me.chkinactive.Text = "Inactive"
        Me.chkinactive.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(66, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Shape:"
        '
        'cmbsize
        '
        Me.cmbsize.BackColor = System.Drawing.Color.White
        Me.cmbsize.FormattingEnabled = True
        Me.cmbsize.Items.AddRange(New Object() {"Large", "Small", "Average"})
        Me.cmbsize.Location = New System.Drawing.Point(252, 28)
        Me.cmbsize.Name = "cmbsize"
        Me.cmbsize.Size = New System.Drawing.Size(709, 21)
        Me.cmbsize.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Size:"
        '
        'ETabControl1
        '
        Me.ETabControl1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ETabControl1.Controls.Add(Me.TabPage1)
        Me.ETabControl1.Controls.Add(Me.TabPage2)
        Me.ETabControl1.Controls.Add(Me.TabPage3)
        Me.ETabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ETabControl1.Location = New System.Drawing.Point(0, 0)
        Me.ETabControl1.Name = "ETabControl1"
        Me.ETabControl1.SelectedIndex = 0
        Me.ETabControl1.Size = New System.Drawing.Size(819, 347)
        Me.ETabControl1.TabIndex = 23
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(811, 318)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General:"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.Controls.Add(Me.SplitContainer2)
        Me.Panel3.Controls.Add(Me.ERoundedPanel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(811, 318)
        Me.Panel3.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 91)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.ERoundedPanel2)
        Me.SplitContainer2.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ERoundedPanel3)
        Me.SplitContainer2.Panel2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.SplitContainer2.Size = New System.Drawing.Size(811, 227)
        Me.SplitContainer2.SplitterDistance = 426
        Me.SplitContainer2.TabIndex = 2
        '
        'ERoundedPanel2
        '
        Me.ERoundedPanel2.BackColor = System.Drawing.Color.White
        Me.ERoundedPanel2.BorderRadius = 32
        Me.ERoundedPanel2.Controls.Add(Me.txtminstock)
        Me.ERoundedPanel2.Controls.Add(Me.txtlastprice)
        Me.ERoundedPanel2.Controls.Add(Me.txtweight)
        Me.ERoundedPanel2.Controls.Add(Me.cmbminstockunit)
        Me.ERoundedPanel2.Controls.Add(Me.lblminimumstockhead)
        Me.ERoundedPanel2.Controls.Add(Me.lblsoldunit)
        Me.ERoundedPanel2.Controls.Add(Me.cmbweight)
        Me.ERoundedPanel2.Controls.Add(Me.lbllastunitcost)
        Me.ERoundedPanel2.Controls.Add(Me.lblweight)
        Me.ERoundedPanel2.Controls.Add(Me.cmbstocking)
        Me.ERoundedPanel2.Controls.Add(Me.lblstocking)
        Me.ERoundedPanel2.Controls.Add(Me.cmbitemtype)
        Me.ERoundedPanel2.Controls.Add(Me.lblitemtype)
        Me.ERoundedPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel2.Location = New System.Drawing.Point(0, 5)
        Me.ERoundedPanel2.Name = "ERoundedPanel2"
        Me.ERoundedPanel2.Size = New System.Drawing.Size(426, 222)
        Me.ERoundedPanel2.TabIndex = 2
        '
        'txtminstock
        '
        Me.txtminstock.BackColor = System.Drawing.Color.White
        Me.txtminstock.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtminstock.Location = New System.Drawing.Point(107, 62)
        Me.txtminstock.Name = "txtminstock"
        Me.txtminstock.Required = False
        Me.txtminstock.ShowErrorIcon = True
        Me.txtminstock.Size = New System.Drawing.Size(70, 21)
        Me.txtminstock.TabIndex = 5
        Me.txtminstock.TextBox = Nothing
        Me.txtminstock.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.Numbers
        Me.txtminstock.WaterMark = "0.00"
        Me.txtminstock.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtminstock.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtminstock.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtlastprice
        '
        Me.txtlastprice.BackColor = System.Drawing.Color.White
        Me.txtlastprice.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtlastprice.Location = New System.Drawing.Point(329, 36)
        Me.txtlastprice.Name = "txtlastprice"
        Me.txtlastprice.Required = False
        Me.txtlastprice.ShowErrorIcon = True
        Me.txtlastprice.Size = New System.Drawing.Size(65, 21)
        Me.txtlastprice.TabIndex = 4
        Me.txtlastprice.TextBox = Nothing
        Me.txtlastprice.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.Numbers
        Me.txtlastprice.WaterMark = "0.00"
        Me.txtlastprice.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtlastprice.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlastprice.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtweight
        '
        Me.txtweight.BackColor = System.Drawing.Color.White
        Me.txtweight.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtweight.Location = New System.Drawing.Point(107, 36)
        Me.txtweight.Name = "txtweight"
        Me.txtweight.Required = False
        Me.txtweight.ShowErrorIcon = True
        Me.txtweight.Size = New System.Drawing.Size(70, 21)
        Me.txtweight.TabIndex = 2
        Me.txtweight.TextBox = Nothing
        Me.txtweight.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.Numbers
        Me.txtweight.WaterMark = "0.00"
        Me.txtweight.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtweight.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtweight.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'cmbminstockunit
        '
        Me.cmbminstockunit.BackColor = System.Drawing.Color.White
        Me.cmbminstockunit.FormattingEnabled = True
        Me.cmbminstockunit.Location = New System.Drawing.Point(181, 63)
        Me.cmbminstockunit.Name = "cmbminstockunit"
        Me.cmbminstockunit.Size = New System.Drawing.Size(109, 21)
        Me.cmbminstockunit.TabIndex = 6
        '
        'lblminimumstockhead
        '
        Me.lblminimumstockhead.AutoSize = True
        Me.lblminimumstockhead.Location = New System.Drawing.Point(9, 66)
        Me.lblminimumstockhead.Name = "lblminimumstockhead"
        Me.lblminimumstockhead.Size = New System.Drawing.Size(67, 13)
        Me.lblminimumstockhead.TabIndex = 132
        Me.lblminimumstockhead.Text = "Min Stock:"
        '
        'lblsoldunit
        '
        Me.lblsoldunit.Location = New System.Drawing.Point(178, 65)
        Me.lblsoldunit.Name = "lblsoldunit"
        Me.lblsoldunit.Size = New System.Drawing.Size(112, 13)
        Me.lblsoldunit.TabIndex = 131
        '
        'cmbweight
        '
        Me.cmbweight.BackColor = System.Drawing.Color.White
        Me.cmbweight.FormattingEnabled = True
        Me.cmbweight.Items.AddRange(New Object() {"Pieces", "Dozen", "Kilogram", "Gram", "Milligram", "Quintal", "Tonne", "Liter", "Milliliter", "Barrel", "Gallon", "Square foot", "Square inch", "Square kilometer", "Square mile", "Square meter", "Square centimeter", "Square millimeter", "Hectare", "Square Yard", "Acre", "Meter", "Centi Meter", "Kilometer", "Foot", "Inch"})
        Me.cmbweight.Location = New System.Drawing.Point(183, 36)
        Me.cmbweight.Name = "cmbweight"
        Me.cmbweight.Size = New System.Drawing.Size(76, 21)
        Me.cmbweight.TabIndex = 3
        '
        'lbllastunitcost
        '
        Me.lbllastunitcost.AutoSize = True
        Me.lbllastunitcost.Location = New System.Drawing.Point(265, 39)
        Me.lbllastunitcost.Name = "lbllastunitcost"
        Me.lbllastunitcost.Size = New System.Drawing.Size(65, 13)
        Me.lbllastunitcost.TabIndex = 128
        Me.lbllastunitcost.Text = "Last Cost:"
        '
        'lblweight
        '
        Me.lblweight.AutoSize = True
        Me.lblweight.Location = New System.Drawing.Point(9, 39)
        Me.lblweight.Name = "lblweight"
        Me.lblweight.Size = New System.Drawing.Size(50, 13)
        Me.lblweight.TabIndex = 118
        Me.lblweight.Text = "Weight:"
        '
        'cmbstocking
        '
        Me.cmbstocking.BackColor = System.Drawing.Color.White
        Me.cmbstocking.FormattingEnabled = True
        Me.cmbstocking.Items.AddRange(New Object() {"Bag", "Bottle", "Each - Bag & Bottle", "Packet", "Box"})
        Me.cmbstocking.Location = New System.Drawing.Point(285, 9)
        Me.cmbstocking.Name = "cmbstocking"
        Me.cmbstocking.Size = New System.Drawing.Size(109, 21)
        Me.cmbstocking.TabIndex = 1
        '
        'lblstocking
        '
        Me.lblstocking.AutoSize = True
        Me.lblstocking.Location = New System.Drawing.Point(197, 12)
        Me.lblstocking.Name = "lblstocking"
        Me.lblstocking.Size = New System.Drawing.Size(87, 13)
        Me.lblstocking.TabIndex = 117
        Me.lblstocking.Text = "Stocking U/M:"
        '
        'cmbitemtype
        '
        Me.cmbitemtype.BackColor = System.Drawing.Color.White
        Me.cmbitemtype.FormattingEnabled = True
        Me.cmbitemtype.Items.AddRange(New Object() {"Admin", "Comment", "Labor", "Service", "Supply"})
        Me.cmbitemtype.Location = New System.Drawing.Point(106, 9)
        Me.cmbitemtype.Name = "cmbitemtype"
        Me.cmbitemtype.Size = New System.Drawing.Size(85, 21)
        Me.cmbitemtype.TabIndex = 0
        '
        'lblitemtype
        '
        Me.lblitemtype.AutoSize = True
        Me.lblitemtype.Location = New System.Drawing.Point(11, 12)
        Me.lblitemtype.Name = "lblitemtype"
        Me.lblitemtype.Size = New System.Drawing.Size(70, 13)
        Me.lblitemtype.TabIndex = 116
        Me.lblitemtype.Text = "Item Type:"
        '
        'ERoundedPanel3
        '
        Me.ERoundedPanel3.BackColor = System.Drawing.Color.White
        Me.ERoundedPanel3.BorderRadius = 32
        Me.ERoundedPanel3.Controls.Add(Me.lblcostingacc)
        Me.ERoundedPanel3.Controls.Add(Me.lblglcostacc)
        Me.ERoundedPanel3.Controls.Add(Me.lblglinvtryacc)
        Me.ERoundedPanel3.Controls.Add(Me.lblglsalesacc)
        Me.ERoundedPanel3.Controls.Add(Me.lblcostingacchead)
        Me.ERoundedPanel3.Controls.Add(Me.lblglcostacchead)
        Me.ERoundedPanel3.Controls.Add(Me.txtvendor)
        Me.ERoundedPanel3.Controls.Add(Me.lblglinvtryacchead)
        Me.ERoundedPanel3.Controls.Add(Me.lblglsalesacchead)
        Me.ERoundedPanel3.Controls.Add(Me.lblpreferredvendor)
        Me.ERoundedPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel3.Location = New System.Drawing.Point(0, 5)
        Me.ERoundedPanel3.Name = "ERoundedPanel3"
        Me.ERoundedPanel3.Size = New System.Drawing.Size(381, 222)
        Me.ERoundedPanel3.TabIndex = 2
        '
        'lblcostingacc
        '
        Me.lblcostingacc.AutoSize = True
        Me.lblcostingacc.Location = New System.Drawing.Point(157, 119)
        Me.lblcostingacc.Name = "lblcostingacc"
        Me.lblcostingacc.Size = New System.Drawing.Size(0, 13)
        Me.lblcostingacc.TabIndex = 105
        '
        'lblglcostacc
        '
        Me.lblglcostacc.AutoSize = True
        Me.lblglcostacc.Location = New System.Drawing.Point(157, 92)
        Me.lblglcostacc.Name = "lblglcostacc"
        Me.lblglcostacc.Size = New System.Drawing.Size(0, 13)
        Me.lblglcostacc.TabIndex = 104
        '
        'lblglinvtryacc
        '
        Me.lblglinvtryacc.AutoSize = True
        Me.lblglinvtryacc.Location = New System.Drawing.Point(157, 65)
        Me.lblglinvtryacc.Name = "lblglinvtryacc"
        Me.lblglinvtryacc.Size = New System.Drawing.Size(0, 13)
        Me.lblglinvtryacc.TabIndex = 103
        '
        'lblglsalesacc
        '
        Me.lblglsalesacc.AutoSize = True
        Me.lblglsalesacc.Location = New System.Drawing.Point(157, 39)
        Me.lblglsalesacc.Name = "lblglsalesacc"
        Me.lblglsalesacc.Size = New System.Drawing.Size(0, 13)
        Me.lblglsalesacc.TabIndex = 102
        '
        'lblcostingacchead
        '
        Me.lblcostingacchead.AutoSize = True
        Me.lblcostingacchead.Location = New System.Drawing.Point(18, 120)
        Me.lblcostingacchead.Name = "lblcostingacchead"
        Me.lblcostingacchead.Size = New System.Drawing.Size(104, 13)
        Me.lblcostingacchead.TabIndex = 101
        Me.lblcostingacchead.Text = "Costing Account:"
        '
        'lblglcostacchead
        '
        Me.lblglcostacchead.AutoSize = True
        Me.lblglcostacchead.Location = New System.Drawing.Point(18, 93)
        Me.lblglcostacchead.Name = "lblglcostacchead"
        Me.lblglcostacchead.Size = New System.Drawing.Size(106, 13)
        Me.lblglcostacchead.TabIndex = 99
        Me.lblglcostacchead.Text = "GL Cost Account:"
        '
        'txtvendor
        '
        Me.txtvendor.BackColor = System.Drawing.Color.White
        Me.txtvendor.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtvendor.Location = New System.Drawing.Point(160, 9)
        Me.txtvendor.Name = "txtvendor"
        Me.txtvendor.Required = False
        Me.txtvendor.ShowErrorIcon = False
        Me.txtvendor.Size = New System.Drawing.Size(185, 21)
        Me.txtvendor.TabIndex = 0
        Me.txtvendor.TextBox = ""
        Me.txtvendor.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtvendor.WaterMark = "Enter Vendor Name"
        Me.txtvendor.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtvendor.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvendor.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'lblglinvtryacchead
        '
        Me.lblglinvtryacchead.AutoSize = True
        Me.lblglinvtryacchead.Location = New System.Drawing.Point(18, 66)
        Me.lblglinvtryacchead.Name = "lblglinvtryacchead"
        Me.lblglinvtryacchead.Size = New System.Drawing.Size(136, 13)
        Me.lblglinvtryacchead.TabIndex = 97
        Me.lblglinvtryacchead.Text = "GL Inventory Account:"
        '
        'lblglsalesacchead
        '
        Me.lblglsalesacchead.AutoSize = True
        Me.lblglsalesacchead.Location = New System.Drawing.Point(18, 40)
        Me.lblglsalesacchead.Name = "lblglsalesacchead"
        Me.lblglsalesacchead.Size = New System.Drawing.Size(111, 13)
        Me.lblglsalesacchead.TabIndex = 96
        Me.lblglsalesacchead.Text = "GL Sales Account:"
        '
        'lblpreferredvendor
        '
        Me.lblpreferredvendor.AutoSize = True
        Me.lblpreferredvendor.Location = New System.Drawing.Point(18, 12)
        Me.lblpreferredvendor.Name = "lblpreferredvendor"
        Me.lblpreferredvendor.Size = New System.Drawing.Size(110, 13)
        Me.lblpreferredvendor.TabIndex = 95
        Me.lblpreferredvendor.Text = "Preferred Vendor:"
        '
        'ERoundedPanel1
        '
        Me.ERoundedPanel1.BackColor = System.Drawing.Color.White
        Me.ERoundedPanel1.BorderRadius = 32
        Me.ERoundedPanel1.Controls.Add(Me.txtitemlong)
        Me.ERoundedPanel1.Controls.Add(Me.txtpricelevel)
        Me.ERoundedPanel1.Controls.Add(Me.btnpricelevel)
        Me.ERoundedPanel1.Controls.Add(Me.lblqntyunit)
        Me.ERoundedPanel1.Controls.Add(Me.lblqntyonhand)
        Me.ERoundedPanel1.Controls.Add(Me.lblqntyonhandhead)
        Me.ERoundedPanel1.Controls.Add(Me.cmbtaxtype)
        Me.ERoundedPanel1.Controls.Add(Me.cmbcostmethod)
        Me.ERoundedPanel1.Controls.Add(Me.lblcostmethod)
        Me.ERoundedPanel1.Controls.Add(Me.lblpricelevel)
        Me.ERoundedPanel1.Controls.Add(Me.cmbdescription)
        Me.ERoundedPanel1.Controls.Add(Me.Label8)
        Me.ERoundedPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ERoundedPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ERoundedPanel1.Name = "ERoundedPanel1"
        Me.ERoundedPanel1.Size = New System.Drawing.Size(811, 91)
        Me.ERoundedPanel1.TabIndex = 0
        '
        'txtitemlong
        '
        Me.txtitemlong.BackColor = System.Drawing.Color.White
        Me.txtitemlong.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtitemlong.Location = New System.Drawing.Point(251, 9)
        Me.txtitemlong.Multiline = True
        Me.txtitemlong.Name = "txtitemlong"
        Me.txtitemlong.Required = False
        Me.txtitemlong.ShowErrorIcon = False
        Me.txtitemlong.Size = New System.Drawing.Size(508, 48)
        Me.txtitemlong.TabIndex = 1
        Me.txtitemlong.TextBox = ""
        Me.txtitemlong.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtitemlong.WaterMark = "Enter Description in Details"
        Me.txtitemlong.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtitemlong.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitemlong.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtpricelevel
        '
        Me.txtpricelevel.BackColor = System.Drawing.Color.White
        Me.txtpricelevel.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtpricelevel.Location = New System.Drawing.Point(106, 36)
        Me.txtpricelevel.Name = "txtpricelevel"
        Me.txtpricelevel.Required = False
        Me.txtpricelevel.ShowErrorIcon = True
        Me.txtpricelevel.Size = New System.Drawing.Size(116, 21)
        Me.txtpricelevel.TabIndex = 2
        Me.txtpricelevel.TextBox = Nothing
        Me.txtpricelevel.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.Numbers
        Me.txtpricelevel.WaterMark = "0.00"
        Me.txtpricelevel.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtpricelevel.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpricelevel.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'btnpricelevel
        '
        Me.btnpricelevel.BackColor = System.Drawing.Color.Transparent
        Me.btnpricelevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnpricelevel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpricelevel.FlatAppearance.BorderSize = 0
        Me.btnpricelevel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnpricelevel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnpricelevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpricelevel.Image = Global.Umbrella.My.Resources.Resources.open_dot
        Me.btnpricelevel.Location = New System.Drawing.Point(225, 35)
        Me.btnpricelevel.Name = "btnpricelevel"
        Me.btnpricelevel.Size = New System.Drawing.Size(20, 20)
        Me.btnpricelevel.TabIndex = 125
        Me.btnpricelevel.UseVisualStyleBackColor = False
        '
        'lblqntyunit
        '
        Me.lblqntyunit.Location = New System.Drawing.Point(516, 66)
        Me.lblqntyunit.Name = "lblqntyunit"
        Me.lblqntyunit.Size = New System.Drawing.Size(90, 13)
        Me.lblqntyunit.TabIndex = 123
        '
        'lblqntyonhand
        '
        Me.lblqntyonhand.AutoSize = True
        Me.lblqntyonhand.Location = New System.Drawing.Point(405, 66)
        Me.lblqntyonhand.Name = "lblqntyonhand"
        Me.lblqntyonhand.Size = New System.Drawing.Size(32, 13)
        Me.lblqntyonhand.TabIndex = 122
        Me.lblqntyonhand.Text = "0.00"
        Me.lblqntyonhand.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblqntyonhandhead
        '
        Me.lblqntyonhandhead.AutoSize = True
        Me.lblqntyonhandhead.Location = New System.Drawing.Point(288, 66)
        Me.lblqntyonhandhead.Name = "lblqntyonhandhead"
        Me.lblqntyonhandhead.Size = New System.Drawing.Size(111, 13)
        Me.lblqntyonhandhead.TabIndex = 121
        Me.lblqntyonhandhead.Text = "Quantity on Hand:"
        '
        'cmbtaxtype
        '
        Me.cmbtaxtype.BackColor = System.Drawing.Color.White
        Me.cmbtaxtype.FormattingEnabled = True
        Me.cmbtaxtype.Items.AddRange(New Object() {"Taxable", "Tax Free"})
        Me.cmbtaxtype.Location = New System.Drawing.Point(190, 63)
        Me.cmbtaxtype.Name = "cmbtaxtype"
        Me.cmbtaxtype.Size = New System.Drawing.Size(92, 21)
        Me.cmbtaxtype.TabIndex = 4
        '
        'cmbcostmethod
        '
        Me.cmbcostmethod.BackColor = System.Drawing.Color.White
        Me.cmbcostmethod.FormattingEnabled = True
        Me.cmbcostmethod.Items.AddRange(New Object() {"FIFO", "LIFO", "Average"})
        Me.cmbcostmethod.Location = New System.Drawing.Point(106, 63)
        Me.cmbcostmethod.Name = "cmbcostmethod"
        Me.cmbcostmethod.Size = New System.Drawing.Size(78, 21)
        Me.cmbcostmethod.TabIndex = 3
        '
        'lblcostmethod
        '
        Me.lblcostmethod.AutoSize = True
        Me.lblcostmethod.Location = New System.Drawing.Point(9, 66)
        Me.lblcostmethod.Name = "lblcostmethod"
        Me.lblcostmethod.Size = New System.Drawing.Size(83, 13)
        Me.lblcostmethod.TabIndex = 119
        Me.lblcostmethod.Text = "Cost Method:"
        '
        'lblpricelevel
        '
        Me.lblpricelevel.AutoSize = True
        Me.lblpricelevel.Location = New System.Drawing.Point(9, 39)
        Me.lblpricelevel.Name = "lblpricelevel"
        Me.lblpricelevel.Size = New System.Drawing.Size(74, 13)
        Me.lblpricelevel.TabIndex = 118
        Me.lblpricelevel.Text = "Price Level:"
        '
        'cmbdescription
        '
        Me.cmbdescription.BackColor = System.Drawing.Color.White
        Me.cmbdescription.FormattingEnabled = True
        Me.cmbdescription.Items.AddRange(New Object() {"For Sale", "For Purchase"})
        Me.cmbdescription.Location = New System.Drawing.Point(106, 9)
        Me.cmbdescription.Name = "cmbdescription"
        Me.cmbdescription.Size = New System.Drawing.Size(139, 21)
        Me.cmbdescription.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 117
        Me.Label8.Text = "Description:"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(811, 318)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Custom Fields:"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.Controls.Add(Me.dgviewcustomfield)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(811, 318)
        Me.Panel4.TabIndex = 1
        '
        'dgviewcustomfield
        '
        Me.dgviewcustomfield.AllowUserToAddRows = False
        Me.dgviewcustomfield.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgviewcustomfield.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgviewcustomfield.BackgroundColor = System.Drawing.Color.White
        Me.dgviewcustomfield.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgviewcustomfield.ColumnHeadersVisible = False
        Me.dgviewcustomfield.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column5, Me.Column6})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewcustomfield.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgviewcustomfield.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewcustomfield.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgviewcustomfield.Location = New System.Drawing.Point(0, 0)
        Me.dgviewcustomfield.Name = "dgviewcustomfield"
        Me.dgviewcustomfield.RowHeadersVisible = False
        Me.dgviewcustomfield.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgviewcustomfield.Size = New System.Drawing.Size(811, 318)
        Me.dgviewcustomfield.TabIndex = 6
        '
        'Column7
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column7.HeaderText = "Serial"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 20
        '
        'Column5
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.HeaderText = "Custom Field"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 204
        '
        'Column6
        '
        Me.Column6.HeaderText = "Value"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 584
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage3.Controls.Add(Me.Panel2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(811, 318)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "History:"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgviewitemhistory)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.Panel2.Size = New System.Drawing.Size(811, 318)
        Me.Panel2.TabIndex = 0
        '
        'dgviewitemhistory
        '
        Me.dgviewitemhistory.AllowUserToAddRows = False
        Me.dgviewitemhistory.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgviewitemhistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgviewitemhistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgviewitemhistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgviewitemhistory.BackgroundColor = System.Drawing.Color.White
        Me.dgviewitemhistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgviewitemhistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmassitemid, Me.clmassitemname, Me.clmassitemcls, Me.clmassiteminvno, Me.Column3, Me.Column1, Me.Column4, Me.Column2})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewitemhistory.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgviewitemhistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewitemhistory.Location = New System.Drawing.Point(5, 5)
        Me.dgviewitemhistory.Name = "dgviewitemhistory"
        Me.dgviewitemhistory.ReadOnly = True
        Me.dgviewitemhistory.RowHeadersVisible = False
        Me.dgviewitemhistory.Size = New System.Drawing.Size(806, 313)
        Me.dgviewitemhistory.TabIndex = 5
        '
        'clmassitemid
        '
        Me.clmassitemid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.clmassitemid.Frozen = True
        Me.clmassitemid.HeaderText = "Item ID"
        Me.clmassitemid.Name = "clmassitemid"
        Me.clmassitemid.ReadOnly = True
        '
        'clmassitemname
        '
        Me.clmassitemname.HeaderText = "Item Name"
        Me.clmassitemname.Name = "clmassitemname"
        Me.clmassitemname.ReadOnly = True
        '
        'clmassitemcls
        '
        Me.clmassitemcls.HeaderText = "Item Class"
        Me.clmassitemcls.Name = "clmassitemcls"
        Me.clmassitemcls.ReadOnly = True
        '
        'clmassiteminvno
        '
        Me.clmassiteminvno.HeaderText = "Invoice No"
        Me.clmassiteminvno.Name = "clmassiteminvno"
        Me.clmassiteminvno.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Invoice Date"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AllowDateSep = False
        Me.Column1.AllowDecimal = True
        Me.Column1.AllowMinus = False
        Me.Column1.HeaderText = "Qnty"
        Me.Column1.MaxInputLength = 0
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column4
        '
        Me.Column4.HeaderText = "Unit"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Purpose"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.RoundedPanel1.BorderRadius = 32
        Me.RoundedPanel1.Controls.Add(Me.btnhelp)
        Me.RoundedPanel1.Controls.Add(Me.btnrefresh)
        Me.RoundedPanel1.Controls.Add(Me.btnnote)
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
        Me.RoundedPanel1.TabIndex = 20
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
        Me.btnhelp.Location = New System.Drawing.Point(493, 10)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(63, 40)
        Me.btnhelp.TabIndex = 86
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
        Me.btnrefresh.Location = New System.Drawing.Point(406, 10)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(87, 40)
        Me.btnrefresh.TabIndex = 85
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnrefresh.TextShadowShow = False
        '
        'btnnote
        '
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnnote.CenterPtTracker = DesignerRectTracker5
        Me.btnnote.ColorFillSolid = System.Drawing.Color.White
        Me.btnnote.Corners.All = CType(-1, Short)
        Me.btnnote.Corners.LowerLeft = CType(20, Short)
        Me.btnnote.Corners.LowerRight = CType(12, Short)
        Me.btnnote.Corners.UpperLeft = CType(12, Short)
        Me.btnnote.Corners.UpperRight = CType(20, Short)
        Me.btnnote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnote.Dock = System.Windows.Forms.DockStyle.Left
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnnote.FocusPtTracker = DesignerRectTracker6
        Me.btnnote.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnote.Image = Global.Umbrella.My.Resources.Resources.note
        Me.btnnote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnote.ImageIndex = 0
        Me.btnnote.Location = New System.Drawing.Point(343, 10)
        Me.btnnote.Name = "btnnote"
        Me.btnnote.Size = New System.Drawing.Size(63, 40)
        Me.btnnote.TabIndex = 84
        Me.btnnote.Text = "Note"
        Me.btnnote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnnote.TextShadowShow = False
        '
        'btndelete
        '
        DesignerRectTracker7.IsActive = False
        DesignerRectTracker7.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker7.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btndelete.CenterPtTracker = DesignerRectTracker7
        Me.btndelete.ColorFillSolid = System.Drawing.Color.White
        Me.btndelete.Corners.All = CType(-1, Short)
        Me.btndelete.Corners.LowerLeft = CType(20, Short)
        Me.btndelete.Corners.LowerRight = CType(12, Short)
        Me.btndelete.Corners.UpperLeft = CType(12, Short)
        Me.btndelete.Corners.UpperRight = CType(20, Short)
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndelete.Dock = System.Windows.Forms.DockStyle.Left
        Me.btndelete.FocalPoints.CenterPtX = 0.4936709!
        Me.btndelete.FocalPoints.CenterPtY = 0.35!
        Me.btndelete.FocalPoints.FocusPtX = 0.0!
        Me.btndelete.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker8.IsActive = False
        DesignerRectTracker8.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker8.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btndelete.FocusPtTracker = DesignerRectTracker8
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
        DesignerRectTracker9.IsActive = False
        DesignerRectTracker9.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker9.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsavenew.CenterPtTracker = DesignerRectTracker9
        Me.btnsavenew.ColorFillSolid = System.Drawing.Color.White
        Me.btnsavenew.Corners.All = CType(-1, Short)
        Me.btnsavenew.Corners.LowerLeft = CType(20, Short)
        Me.btnsavenew.Corners.LowerRight = CType(12, Short)
        Me.btnsavenew.Corners.UpperLeft = CType(12, Short)
        Me.btnsavenew.Corners.UpperRight = CType(20, Short)
        Me.btnsavenew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsavenew.Dock = System.Windows.Forms.DockStyle.Left
        DesignerRectTracker10.IsActive = True
        DesignerRectTracker10.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker10.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsavenew.FocusPtTracker = DesignerRectTracker10
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
        DesignerRectTracker11.IsActive = False
        DesignerRectTracker11.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker11.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsave.CenterPtTracker = DesignerRectTracker11
        Me.btnsave.ColorFillSolid = System.Drawing.Color.White
        Me.btnsave.Corners.All = CType(-1, Short)
        Me.btnsave.Corners.LowerLeft = CType(20, Short)
        Me.btnsave.Corners.LowerRight = CType(12, Short)
        Me.btnsave.Corners.UpperLeft = CType(12, Short)
        Me.btnsave.Corners.UpperRight = CType(20, Short)
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnsave.FocalPoints.CenterPtX = 0.4788733!
        Me.btnsave.FocalPoints.CenterPtY = 0.425!
        Me.btnsave.FocalPoints.FocusPtX = 0.0!
        Me.btnsave.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker12.IsActive = False
        DesignerRectTracker12.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker12.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsave.FocusPtTracker = DesignerRectTracker12
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
        DesignerRectTracker13.IsActive = False
        DesignerRectTracker13.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker13.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnnew.CenterPtTracker = DesignerRectTracker13
        Me.btnnew.ColorFillSolid = System.Drawing.Color.White
        Me.btnnew.Corners.All = CType(-1, Short)
        Me.btnnew.Corners.LowerLeft = CType(20, Short)
        Me.btnnew.Corners.LowerRight = CType(12, Short)
        Me.btnnew.Corners.UpperLeft = CType(12, Short)
        Me.btnnew.Corners.UpperRight = CType(20, Short)
        Me.btnnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnew.Dock = System.Windows.Forms.DockStyle.Left
        DesignerRectTracker14.IsActive = False
        DesignerRectTracker14.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker14.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnnew.FocusPtTracker = DesignerRectTracker14
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
        Me.ELabel1.Location = New System.Drawing.Point(594, 10)
        Me.ELabel1.MouseOverColor = System.Drawing.Color.Gray
        Me.ELabel1.Name = "ELabel1"
        Me.ELabel1.ShadowState = True
        Me.ELabel1.Size = New System.Drawing.Size(215, 40)
        Me.ELabel1.TabIndex = 36
        Me.ELabel1.Text = "Maintain Inventory Item"
        '
        'frmAddInventoryItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(839, 556)
        Me.ControlBox = False
        Me.Controls.Add(Me.EGradientPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.Custom
        Me.Name = "frmAddInventoryItem"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maintain Inventory Item"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.EGradientPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.EGroupBox1.ResumeLayout(False)
        Me.EGroupBox1.PerformLayout()
        Me.EGroupBox2.ResumeLayout(False)
        Me.EGroupBox2.PerformLayout()
        Me.ETabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.ERoundedPanel2.ResumeLayout(False)
        Me.ERoundedPanel2.PerformLayout()
        Me.ERoundedPanel3.ResumeLayout(False)
        Me.ERoundedPanel3.PerformLayout()
        Me.ERoundedPanel1.ResumeLayout(False)
        Me.ERoundedPanel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgviewcustomfield, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgviewitemhistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EGradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents RoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents ELabel1 As ESAR_Controls.eLabel
    Friend WithEvents btndelete As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnsavenew As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnsave As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnnew As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents EGroupBox1 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents txtitemid As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtitemshort As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtitemname As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbitemclass As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EGroupBox2 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents cmbshape As ESAR_Controls.UIControls.ComboBox.eComboBoxIcon
    Friend WithEvents chkinactive As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbsize As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ETabControl1 As ESAR_Controls.UIControls.TabControl.eTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ERoundedPanel2 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents txtminstock As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtlastprice As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtweight As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents cmbminstockunit As System.Windows.Forms.ComboBox
    Friend WithEvents lblminimumstockhead As System.Windows.Forms.Label
    Friend WithEvents lblsoldunit As System.Windows.Forms.Label
    Friend WithEvents cmbweight As System.Windows.Forms.ComboBox
    Friend WithEvents lbllastunitcost As System.Windows.Forms.Label
    Friend WithEvents lblweight As System.Windows.Forms.Label
    Friend WithEvents cmbstocking As System.Windows.Forms.ComboBox
    Friend WithEvents lblstocking As System.Windows.Forms.Label
    Friend WithEvents cmbitemtype As System.Windows.Forms.ComboBox
    Friend WithEvents lblitemtype As System.Windows.Forms.Label
    Friend WithEvents ERoundedPanel3 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents txtvendor As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents lblglinvtryacchead As System.Windows.Forms.Label
    Friend WithEvents lblglsalesacchead As System.Windows.Forms.Label
    Friend WithEvents lblpreferredvendor As System.Windows.Forms.Label
    Friend WithEvents ERoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents txtitemlong As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtpricelevel As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents btnpricelevel As System.Windows.Forms.Button
    Friend WithEvents lblqntyunit As System.Windows.Forms.Label
    Friend WithEvents lblqntyonhand As System.Windows.Forms.Label
    Friend WithEvents lblqntyonhandhead As System.Windows.Forms.Label
    Friend WithEvents cmbtaxtype As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcostmethod As System.Windows.Forms.ComboBox
    Friend WithEvents lblcostmethod As System.Windows.Forms.Label
    Friend WithEvents lblpricelevel As System.Windows.Forms.Label
    Friend WithEvents cmbdescription As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgviewitemhistory As System.Windows.Forms.DataGridView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents chkcommission As System.Windows.Forms.CheckBox
    Friend WithEvents clmassitemid As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents clmassitemname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmassitemcls As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmassiteminvno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As ESAR_Controls.UIControls.DataGridView.eCalendarColumn
    Friend WithEvents Column1 As ESAR_Controls.UIControls.DataGridView.eNumericTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnhelp As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnrefresh As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnnote As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents lblcostingacchead As System.Windows.Forms.Label
    Friend WithEvents lblglcostacchead As System.Windows.Forms.Label
    Friend WithEvents dgviewcustomfield As System.Windows.Forms.DataGridView
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblcostingacc As System.Windows.Forms.Label
    Friend WithEvents lblglcostacc As System.Windows.Forms.Label
    Friend WithEvents lblglinvtryacc As System.Windows.Forms.Label
    Friend WithEvents lblglsalesacc As System.Windows.Forms.Label
End Class
