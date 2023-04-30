Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindTransaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFindTransaction))
        Dim DesignerRectTracker2 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker3 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker4 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker5 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker6 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker7 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker8 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker9 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker10 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim CBlendItems1 As ESAR_Controls.cBlendItems = New ESAR_Controls.cBlendItems
        Me.EGradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.EGroupBox2 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.dgviewtransaction = New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewLinkColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewLinkColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column10 = New ESAR_Controls.UIControls.DataGridView.eNumericTextBoxColumn
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.ERoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.btnfind = New ESAR_Controls.UIControls.Button.eButton
        Me.cmbtransaction = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.EGroupBox1 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.cmbto = New ESAR_Controls.UIControls.ComboBox.eComboBoxDateTime
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbfrom = New ESAR_Controls.UIControls.ComboBox.eComboBoxDateTime
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbperiod = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ERoundedPanel6 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.btnhelp = New ESAR_Controls.UIControls.Button.eButton
        Me.btndetail = New ESAR_Controls.UIControls.Button.eButton
        Me.btnprint = New ESAR_Controls.UIControls.Button.eButton
        Me.btnnew = New ESAR_Controls.UIControls.Button.eButton
        Me.ELabel6 = New ESAR_Controls.eLabel
        Me.EGradientPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.EGroupBox2.SuspendLayout()
        CType(Me.dgviewtransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.ERoundedPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.EGroupBox1.SuspendLayout()
        Me.ERoundedPanel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'EGradientPanel1
        '
        Me.EGradientPanel1.Controls.Add(Me.Panel4)
        Me.EGradientPanel1.Controls.Add(Me.Panel3)
        Me.EGradientPanel1.Controls.Add(Me.Panel1)
        Me.EGradientPanel1.Controls.Add(Me.ERoundedPanel6)
        Me.EGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGradientPanel1.EndColor = System.Drawing.Color.RoyalBlue
        Me.EGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.EGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EGradientPanel1.Name = "EGradientPanel1"
        Me.EGradientPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.EGradientPanel1.Size = New System.Drawing.Size(764, 585)
        Me.EGradientPanel1.StartColor = System.Drawing.Color.LightCyan
        Me.EGradientPanel1.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.EGroupBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(10, 196)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel4.Size = New System.Drawing.Size(744, 379)
        Me.Panel4.TabIndex = 30
        '
        'EGroupBox2
        '
        Me.EGroupBox2.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox2.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox2.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox2.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox2.BorderThickness = 1.0!
        Me.EGroupBox2.Controls.Add(Me.dgviewtransaction)
        Me.EGroupBox2.Controls.Add(Me.Label5)
        Me.EGroupBox2.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox2.GroupImage = Nothing
        Me.EGroupBox2.GroupTitle = "Transactions:"
        Me.EGroupBox2.Location = New System.Drawing.Point(0, 5)
        Me.EGroupBox2.Name = "EGroupBox2"
        Me.EGroupBox2.Padding = New System.Windows.Forms.Padding(12, 25, 12, 10)
        Me.EGroupBox2.PaintGroupBox = False
        Me.EGroupBox2.RoundCorners = 10
        Me.EGroupBox2.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox2.ShadowControl = False
        Me.EGroupBox2.ShadowThickness = 3
        Me.EGroupBox2.Size = New System.Drawing.Size(744, 374)
        Me.EGroupBox2.TabIndex = 0
        '
        'dgviewtransaction
        '
        Me.dgviewtransaction.AllowUserToAddRows = False
        Me.dgviewtransaction.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgviewtransaction.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgviewtransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgviewtransaction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgviewtransaction.BackgroundColor = System.Drawing.Color.White
        Me.dgviewtransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgviewtransaction.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewtransaction.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgviewtransaction.DisplaySumRowHeader = False
        Me.dgviewtransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewtransaction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgviewtransaction.Location = New System.Drawing.Point(12, 25)
        Me.dgviewtransaction.Name = "dgviewtransaction"
        Me.dgviewtransaction.ReadOnly = True
        Me.dgviewtransaction.RowHeadersVisible = False
        Me.dgviewtransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgviewtransaction.Size = New System.Drawing.Size(720, 326)
        Me.dgviewtransaction.SummaryColumns = Nothing
        Me.dgviewtransaction.SummaryRowBackColor = System.Drawing.Color.Empty
        Me.dgviewtransaction.SummaryRowSpace = 0
        Me.dgviewtransaction.SummaryRowVisible = False
        Me.dgviewtransaction.SumRowHeaderText = Nothing
        Me.dgviewtransaction.SumRowHeaderTextBold = False
        Me.dgviewtransaction.TabIndex = 2
        '
        'Column5
        '
        Me.Column5.HeaderText = "Date"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Type"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Account"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "ID"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Name"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.AllowDateSep = False
        Me.Column10.AllowDecimal = True
        Me.Column10.AllowMinus = False
        Me.Column10.HeaderText = "Amount"
        Me.Column10.MaxInputLength = 0
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label5.Location = New System.Drawing.Point(12, 351)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(452, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "To display the transaction, double click it or click the detail button from menu." & _
            ""
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.ERoundedPanel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(10, 144)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel3.Size = New System.Drawing.Size(744, 52)
        Me.Panel3.TabIndex = 29
        '
        'ERoundedPanel1
        '
        Me.ERoundedPanel1.BackColor = System.Drawing.Color.White
        Me.ERoundedPanel1.BorderRadius = 32
        Me.ERoundedPanel1.Controls.Add(Me.btnfind)
        Me.ERoundedPanel1.Controls.Add(Me.cmbtransaction)
        Me.ERoundedPanel1.Controls.Add(Me.Label4)
        Me.ERoundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel1.Location = New System.Drawing.Point(0, 5)
        Me.ERoundedPanel1.Name = "ERoundedPanel1"
        Me.ERoundedPanel1.Size = New System.Drawing.Size(744, 47)
        Me.ERoundedPanel1.TabIndex = 0
        '
        'btnfind
        '
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnfind.CenterPtTracker = DesignerRectTracker1
        Me.btnfind.Corners.All = CType(12, Short)
        Me.btnfind.Corners.LowerLeft = CType(12, Short)
        Me.btnfind.Corners.LowerRight = CType(12, Short)
        Me.btnfind.Corners.UpperLeft = CType(12, Short)
        Me.btnfind.Corners.UpperRight = CType(12, Short)
        Me.btnfind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfind.FocalPoints.CenterPtX = 1.0!
        Me.btnfind.FocalPoints.CenterPtY = 0.48!
        Me.btnfind.FocalPoints.FocusPtX = 0.0!
        Me.btnfind.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnfind.FocusPtTracker = DesignerRectTracker2
        Me.btnfind.Image = Global.Umbrella.My.Resources.Resources.find
        Me.btnfind.ImageIndex = 0
        Me.btnfind.Location = New System.Drawing.Point(511, 11)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(67, 25)
        Me.btnfind.TabIndex = 4
        Me.btnfind.Text = "Find"
        Me.btnfind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnfind.TextShadowShow = False
        '
        'cmbtransaction
        '
        Me.cmbtransaction.FormattingEnabled = True
        Me.cmbtransaction.Items.AddRange(New Object() {"All", "Monthly Fees", "Yearly Fees", "Late Fees", "Library Fees", "Exam Fees", "Other Fees", "Library Charges", "Sales Invoice", "Purchase Order"})
        Me.cmbtransaction.Location = New System.Drawing.Point(353, 13)
        Me.cmbtransaction.Name = "cmbtransaction"
        Me.cmbtransaction.Size = New System.Drawing.Size(150, 21)
        Me.cmbtransaction.TabIndex = 3
        Me.cmbtransaction.Text = "All"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(319, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Click the find button to search the specific transaction:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.EGroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(10, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(744, 74)
        Me.Panel1.TabIndex = 27
        '
        'EGroupBox1
        '
        Me.EGroupBox1.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox1.BorderThickness = 1.0!
        Me.EGroupBox1.Controls.Add(Me.cmbto)
        Me.EGroupBox1.Controls.Add(Me.Label3)
        Me.EGroupBox1.Controls.Add(Me.cmbfrom)
        Me.EGroupBox1.Controls.Add(Me.Label2)
        Me.EGroupBox1.Controls.Add(Me.cmbperiod)
        Me.EGroupBox1.Controls.Add(Me.Label1)
        Me.EGroupBox1.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox1.GroupImage = Nothing
        Me.EGroupBox1.GroupTitle = "Select a filter range:"
        Me.EGroupBox1.Location = New System.Drawing.Point(0, 5)
        Me.EGroupBox1.Name = "EGroupBox1"
        Me.EGroupBox1.Padding = New System.Windows.Forms.Padding(12, 25, 12, 10)
        Me.EGroupBox1.PaintGroupBox = False
        Me.EGroupBox1.RoundCorners = 10
        Me.EGroupBox1.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox1.ShadowControl = False
        Me.EGroupBox1.ShadowThickness = 3
        Me.EGroupBox1.Size = New System.Drawing.Size(744, 69)
        Me.EGroupBox1.TabIndex = 0
        '
        'cmbto
        '
        Me.cmbto.FormatString = "d"
        Me.cmbto.FormattingEnabled = True
        Me.cmbto.Location = New System.Drawing.Point(2301, 34)
        Me.cmbto.Name = "cmbto"
        Me.cmbto.Size = New System.Drawing.Size(640, 21)
        Me.cmbto.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2135, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "To:"
        '
        'cmbfrom
        '
        Me.cmbfrom.FormatString = "d"
        Me.cmbfrom.FormattingEnabled = True
        Me.cmbfrom.Location = New System.Drawing.Point(1441, 34)
        Me.cmbfrom.Name = "cmbfrom"
        Me.cmbfrom.Size = New System.Drawing.Size(640, 21)
        Me.cmbfrom.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1182, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "From:"
        '
        'cmbperiod
        '
        Me.cmbperiod.FormattingEnabled = True
        Me.cmbperiod.Items.AddRange(New Object() {"All", "Range", "Today", "This Period", "This Year", "This Week to Date", "This Month to Date", "This Period to Date", "This Year to Date"})
        Me.cmbperiod.Location = New System.Drawing.Point(412, 38)
        Me.cmbperiod.Name = "cmbperiod"
        Me.cmbperiod.Size = New System.Drawing.Size(726, 21)
        Me.cmbperiod.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Period:"
        '
        'ERoundedPanel6
        '
        Me.ERoundedPanel6.BackColor = System.Drawing.Color.Transparent
        Me.ERoundedPanel6.BorderRadius = 32
        Me.ERoundedPanel6.Controls.Add(Me.btnhelp)
        Me.ERoundedPanel6.Controls.Add(Me.btndetail)
        Me.ERoundedPanel6.Controls.Add(Me.btnprint)
        Me.ERoundedPanel6.Controls.Add(Me.btnnew)
        Me.ERoundedPanel6.Controls.Add(Me.ELabel6)
        Me.ERoundedPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.ERoundedPanel6.Location = New System.Drawing.Point(10, 10)
        Me.ERoundedPanel6.Name = "ERoundedPanel6"
        Me.ERoundedPanel6.Padding = New System.Windows.Forms.Padding(10)
        Me.ERoundedPanel6.Size = New System.Drawing.Size(744, 60)
        Me.ERoundedPanel6.TabIndex = 26
        '
        'btnhelp
        '
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnhelp.CenterPtTracker = DesignerRectTracker3
        Me.btnhelp.ColorFillSolid = System.Drawing.Color.White
        Me.btnhelp.Corners.All = CType(-1, Short)
        Me.btnhelp.Corners.LowerLeft = CType(20, Short)
        Me.btnhelp.Corners.LowerRight = CType(12, Short)
        Me.btnhelp.Corners.UpperLeft = CType(12, Short)
        Me.btnhelp.Corners.UpperRight = CType(20, Short)
        Me.btnhelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhelp.Dock = System.Windows.Forms.DockStyle.Left
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnhelp.FocusPtTracker = DesignerRectTracker4
        Me.btnhelp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhelp.Image = Global.Umbrella.My.Resources.Resources.help
        Me.btnhelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhelp.ImageIndex = 0
        Me.btnhelp.Location = New System.Drawing.Point(221, 10)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(63, 40)
        Me.btnhelp.TabIndex = 89
        Me.btnhelp.Text = "Help"
        Me.btnhelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhelp.TextShadowShow = False
        '
        'btndetail
        '
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btndetail.CenterPtTracker = DesignerRectTracker5
        Me.btndetail.ColorFillSolid = System.Drawing.Color.White
        Me.btndetail.Corners.All = CType(-1, Short)
        Me.btndetail.Corners.LowerLeft = CType(20, Short)
        Me.btndetail.Corners.LowerRight = CType(12, Short)
        Me.btndetail.Corners.UpperLeft = CType(12, Short)
        Me.btndetail.Corners.UpperRight = CType(20, Short)
        Me.btndetail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndetail.Dock = System.Windows.Forms.DockStyle.Left
        Me.btndetail.FocalPoints.CenterPtX = 0.4078947!
        Me.btndetail.FocalPoints.CenterPtY = 0.375!
        Me.btndetail.FocalPoints.FocusPtX = 0.0!
        Me.btndetail.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btndetail.FocusPtTracker = DesignerRectTracker6
        Me.btndetail.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndetail.Image = Global.Umbrella.My.Resources.Resources.find
        Me.btndetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndetail.ImageIndex = 0
        Me.btndetail.Location = New System.Drawing.Point(145, 10)
        Me.btndetail.Name = "btndetail"
        Me.btndetail.Size = New System.Drawing.Size(76, 40)
        Me.btndetail.TabIndex = 88
        Me.btndetail.Text = "Detail"
        Me.btndetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btndetail.TextShadowShow = False
        '
        'btnprint
        '
        DesignerRectTracker7.IsActive = True
        DesignerRectTracker7.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker7.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnprint.CenterPtTracker = DesignerRectTracker7
        Me.btnprint.ColorFillSolid = System.Drawing.Color.White
        Me.btnprint.Corners.All = CType(-1, Short)
        Me.btnprint.Corners.LowerLeft = CType(20, Short)
        Me.btnprint.Corners.LowerRight = CType(12, Short)
        Me.btnprint.Corners.UpperLeft = CType(12, Short)
        Me.btnprint.Corners.UpperRight = CType(20, Short)
        Me.btnprint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprint.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnprint.FocalPoints.CenterPtX = 0.5217391!
        Me.btnprint.FocalPoints.CenterPtY = 0.475!
        Me.btnprint.FocalPoints.FocusPtX = 0.0!
        Me.btnprint.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker8.IsActive = False
        DesignerRectTracker8.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker8.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnprint.FocusPtTracker = DesignerRectTracker8
        Me.btnprint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Image = Global.Umbrella.My.Resources.Resources.printicon
        Me.btnprint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnprint.ImageIndex = 0
        Me.btnprint.Location = New System.Drawing.Point(76, 10)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(69, 40)
        Me.btnprint.TabIndex = 87
        Me.btnprint.Text = "Print"
        Me.btnprint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnprint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnprint.TextShadowShow = False
        '
        'btnnew
        '
        DesignerRectTracker9.IsActive = False
        DesignerRectTracker9.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker9.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnnew.CenterPtTracker = DesignerRectTracker9
        Me.btnnew.ColorFillSolid = System.Drawing.Color.White
        Me.btnnew.Corners.All = CType(-1, Short)
        Me.btnnew.Corners.LowerLeft = CType(20, Short)
        Me.btnnew.Corners.LowerRight = CType(12, Short)
        Me.btnnew.Corners.UpperLeft = CType(12, Short)
        Me.btnnew.Corners.UpperRight = CType(20, Short)
        Me.btnnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnew.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnnew.FocalPoints.CenterPtX = 0.5151515!
        Me.btnnew.FocalPoints.CenterPtY = 0.525!
        Me.btnnew.FocalPoints.FocusPtX = 0.0!
        Me.btnnew.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker10.IsActive = False
        DesignerRectTracker10.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker10.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnnew.FocusPtTracker = DesignerRectTracker10
        Me.btnnew.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.Image = Global.Umbrella.My.Resources.Resources._new
        Me.btnnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnew.ImageIndex = 0
        Me.btnnew.Location = New System.Drawing.Point(10, 10)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(66, 40)
        Me.btnnew.TabIndex = 86
        Me.btnnew.Text = "New"
        Me.btnnew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnnew.TextShadowShow = False
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
        Me.ELabel6.Location = New System.Drawing.Point(545, 10)
        Me.ELabel6.MouseOverColor = System.Drawing.Color.Gray
        Me.ELabel6.Name = "ELabel6"
        Me.ELabel6.ShadowState = True
        Me.ELabel6.Size = New System.Drawing.Size(189, 40)
        Me.ELabel6.TabIndex = 34
        Me.ELabel6.Text = "Find Transaction"
        '
        'frmFindTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(764, 585)
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
        Me.Name = "frmFindTransaction"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find Transaction"
        Me.EGradientPanel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.EGroupBox2.ResumeLayout(False)
        Me.EGroupBox2.PerformLayout()
        CType(Me.dgviewtransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ERoundedPanel1.ResumeLayout(False)
        Me.ERoundedPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.EGroupBox1.ResumeLayout(False)
        Me.EGroupBox1.PerformLayout()
        Me.ERoundedPanel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EGradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents ERoundedPanel6 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents ELabel6 As ESAR_Controls.eLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents EGroupBox1 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents cmbperiod As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnhelp As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btndetail As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnprint As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnnew As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents cmbto As ESAR_Controls.UIControls.ComboBox.eComboBoxDateTime
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbfrom As ESAR_Controls.UIControls.ComboBox.eComboBoxDateTime
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents EGroupBox2 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ERoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgviewtransaction As ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As ESAR_Controls.UIControls.DataGridView.eNumericTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnfind As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents cmbtransaction As System.Windows.Forms.ComboBox
End Class
