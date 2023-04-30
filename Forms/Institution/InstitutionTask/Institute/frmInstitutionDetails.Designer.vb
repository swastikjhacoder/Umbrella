Imports Umbrella.UIControls
Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstitutionDetails
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim DesignerRectTracker1 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInstitutionDetails))
        Dim DesignerRectTracker2 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker3 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker4 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim CBlendItems1 As ESAR_Controls.cBlendItems = New ESAR_Controls.cBlendItems
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Grouper3 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.DataGridViewSummary3 = New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel
        Me.RoundedPanel2 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.RoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.btnhelp = New ESAR_Controls.UIControls.Button.eButton
        Me.btnrefresh = New ESAR_Controls.UIControls.Button.eButton
        Me.ELabel1 = New ESAR_Controls.eLabel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.pictab1 = New System.Windows.Forms.PictureBox
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.pictab2 = New System.Windows.Forms.PictureBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.pictab3 = New System.Windows.Forms.PictureBox
        Me.TabControl1 = New ESAR_Controls.UIControls.TabControl.eTabControlEx
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GradientPanel3 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.RoundedPanel3 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txturl2 = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txturl1 = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtemail = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtfax = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtphone = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtcountry = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtpin = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtstate = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtcity = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtaddress2 = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtaddress1 = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtname = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtregistrationid = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.cmbcategory = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GradientPanel2 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.RoundedPanel4 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.Grouper2 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.dgviewfeatures = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Grouper1 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.dgviewcourse = New System.Windows.Forms.DataGridView
        Me.clmsl = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmcoursename = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmcourseid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmduration = New ESAR_Controls.UIControls.DataGridView.eNumericTextBoxColumn
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.RoundedPanel5 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.Grouper6 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.lblfinancialperiod = New System.Windows.Forms.Label
        Me.Grouper4 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.dgviewachievements = New System.Windows.Forms.DataGridView
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Grouper5 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.dgviewaccounts = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumericTextBoxColumn1 = New ESAR_Controls.UIControls.DataGridView.eNumericTextBoxColumn
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Grouper3.SuspendLayout()
        CType(Me.DataGridViewSummary3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.RoundedPanel2.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundedPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.pictab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.pictab2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.pictab3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GradientPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.RoundedPanel3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GradientPanel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.RoundedPanel4.SuspendLayout()
        Me.Grouper2.SuspendLayout()
        CType(Me.dgviewfeatures, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grouper1.SuspendLayout()
        CType(Me.dgviewcourse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GradientPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.RoundedPanel5.SuspendLayout()
        Me.Grouper6.SuspendLayout()
        Me.Grouper4.SuspendLayout()
        CType(Me.dgviewachievements, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grouper5.SuspendLayout()
        CType(Me.dgviewaccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grouper3
        '
        Me.Grouper3.BackgroundColor = System.Drawing.Color.White
        Me.Grouper3.BackgroundGradientColor = System.Drawing.Color.White
        Me.Grouper3.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.Grouper3.BorderColor = System.Drawing.Color.Black
        Me.Grouper3.BorderThickness = 1.0!
        Me.Grouper3.Controls.Add(Me.DataGridViewSummary3)
        Me.Grouper3.Controls.Add(Me.Panel5)
        Me.Grouper3.CustomGroupBoxColor = System.Drawing.Color.White
        Me.Grouper3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grouper3.GroupImage = Global.Umbrella.My.Resources.Resources.Umbrella_icon
        Me.Grouper3.GroupTitle = "Institution Info:"
        Me.Grouper3.Location = New System.Drawing.Point(0, 0)
        Me.Grouper3.Name = "Grouper3"
        Me.Grouper3.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.Grouper3.PaintGroupBox = False
        Me.Grouper3.RoundCorners = 10
        Me.Grouper3.ShadowColor = System.Drawing.Color.DarkGray
        Me.Grouper3.ShadowControl = False
        Me.Grouper3.ShadowThickness = 3
        Me.Grouper3.Size = New System.Drawing.Size(543, 127)
        Me.Grouper3.TabIndex = 9
        '
        'DataGridViewSummary3
        '
        Me.DataGridViewSummary3.AllowUserToAddRows = False
        Me.DataGridViewSummary3.AllowUserToDeleteRows = False
        Me.DataGridViewSummary3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewSummary3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewSummary3.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewSummary3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DataGridViewSummary3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSummary3.ColumnHeadersVisible = False
        Me.DataGridViewSummary3.DisplaySumRowHeader = False
        Me.DataGridViewSummary3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewSummary3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewSummary3.Location = New System.Drawing.Point(10, 25)
        Me.DataGridViewSummary3.MultiSelect = False
        Me.DataGridViewSummary3.Name = "DataGridViewSummary3"
        Me.DataGridViewSummary3.ReadOnly = True
        Me.DataGridViewSummary3.RowHeadersVisible = False
        Me.DataGridViewSummary3.Size = New System.Drawing.Size(523, 76)
        Me.DataGridViewSummary3.SummaryColumns = Nothing
        Me.DataGridViewSummary3.SummaryRowBackColor = System.Drawing.Color.Empty
        Me.DataGridViewSummary3.SummaryRowSpace = 0
        Me.DataGridViewSummary3.SummaryRowVisible = False
        Me.DataGridViewSummary3.SumRowHeaderText = Nothing
        Me.DataGridViewSummary3.SumRowHeaderTextBold = False
        Me.DataGridViewSummary3.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.LinkLabel5)
        Me.Panel5.Controls.Add(Me.LinkLabel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(10, 101)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(523, 16)
        Me.Panel5.TabIndex = 0
        '
        'LinkLabel5
        '
        Me.LinkLabel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.LinkLabel5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel5.Image = Global.Umbrella.My.Resources.Resources.edit_icon
        Me.LinkLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel5.LinkColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LinkLabel5.Location = New System.Drawing.Point(403, 0)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(120, 16)
        Me.LinkLabel5.TabIndex = 1
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Edit Details"
        Me.LinkLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LinkLabel6
        '
        Me.LinkLabel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.LinkLabel6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel6.Image = Global.Umbrella.My.Resources.Resources.refresh_icon
        Me.LinkLabel6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel6.LinkColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LinkLabel6.Location = New System.Drawing.Point(0, 0)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(92, 16)
        Me.LinkLabel6.TabIndex = 0
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "Refresh"
        Me.LinkLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RoundedPanel2
        '
        Me.RoundedPanel2.BackColor = System.Drawing.Color.White
        Me.RoundedPanel2.BorderRadius = 32
        Me.RoundedPanel2.Controls.Add(Me.Chart2)
        Me.RoundedPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RoundedPanel2.Location = New System.Drawing.Point(0, 10)
        Me.RoundedPanel2.Name = "RoundedPanel2"
        Me.RoundedPanel2.Padding = New System.Windows.Forms.Padding(10)
        Me.RoundedPanel2.Size = New System.Drawing.Size(377, 117)
        Me.RoundedPanel2.TabIndex = 0
        '
        'Chart2
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea1)
        Me.Chart2.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend1)
        Me.Chart2.Location = New System.Drawing.Point(10, 10)
        Me.Chart2.Name = "Chart2"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart2.Series.Add(Series1)
        Me.Chart2.Size = New System.Drawing.Size(357, 97)
        Me.Chart2.TabIndex = 0
        Me.Chart2.Text = "Chart2"
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.RoundedPanel1.BorderRadius = 32
        Me.RoundedPanel1.Controls.Add(Me.btnhelp)
        Me.RoundedPanel1.Controls.Add(Me.btnrefresh)
        Me.RoundedPanel1.Controls.Add(Me.ELabel1)
        Me.RoundedPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RoundedPanel1.Location = New System.Drawing.Point(10, 10)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.RoundedPanel1.Size = New System.Drawing.Size(819, 60)
        Me.RoundedPanel1.TabIndex = 10
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
        Me.btnhelp.Location = New System.Drawing.Point(97, 10)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(63, 40)
        Me.btnhelp.TabIndex = 77
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
        Me.btnrefresh.Location = New System.Drawing.Point(10, 10)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(87, 40)
        Me.btnrefresh.TabIndex = 76
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnrefresh.TextShadowShow = False
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
        Me.ELabel1.Location = New System.Drawing.Point(593, 10)
        Me.ELabel1.MouseOverColor = System.Drawing.Color.Gray
        Me.ELabel1.Name = "ELabel1"
        Me.ELabel1.ShadowState = True
        Me.ELabel1.Size = New System.Drawing.Size(216, 40)
        Me.ELabel1.TabIndex = 35
        Me.ELabel1.Text = "Institution Details"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(10, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 50, 0)
        Me.Panel1.Size = New System.Drawing.Size(819, 20)
        Me.Panel1.TabIndex = 11
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.pictab1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(709, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel7.Size = New System.Drawing.Size(20, 20)
        Me.Panel7.TabIndex = 3
        '
        'pictab1
        '
        Me.pictab1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictab1.Dock = System.Windows.Forms.DockStyle.Right
        Me.pictab1.Image = Global.Umbrella.My.Resources.Resources.process_current
        Me.pictab1.Location = New System.Drawing.Point(5, 5)
        Me.pictab1.Name = "pictab1"
        Me.pictab1.Size = New System.Drawing.Size(10, 10)
        Me.pictab1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictab1.TabIndex = 0
        Me.pictab1.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.pictab2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(729, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel6.Size = New System.Drawing.Size(20, 20)
        Me.Panel6.TabIndex = 2
        '
        'pictab2
        '
        Me.pictab2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictab2.Dock = System.Windows.Forms.DockStyle.Right
        Me.pictab2.Image = CType(resources.GetObject("pictab2.Image"), System.Drawing.Image)
        Me.pictab2.Location = New System.Drawing.Point(5, 5)
        Me.pictab2.Name = "pictab2"
        Me.pictab2.Size = New System.Drawing.Size(10, 10)
        Me.pictab2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictab2.TabIndex = 0
        Me.pictab2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.pictab3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(749, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel3.Size = New System.Drawing.Size(20, 20)
        Me.Panel3.TabIndex = 1
        '
        'pictab3
        '
        Me.pictab3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictab3.Dock = System.Windows.Forms.DockStyle.Right
        Me.pictab3.Image = CType(resources.GetObject("pictab3.Image"), System.Drawing.Image)
        Me.pictab3.Location = New System.Drawing.Point(5, 5)
        Me.pictab3.Name = "pictab3"
        Me.pictab3.Size = New System.Drawing.Size(10, 10)
        Me.pictab3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictab3.TabIndex = 0
        Me.pictab3.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.HideTabs = True
        Me.TabControl1.Location = New System.Drawing.Point(10, 90)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(819, 456)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GradientPanel3)
        Me.TabPage1.Location = New System.Drawing.Point(0, 0)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(819, 456)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GradientPanel3
        '
        Me.GradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GradientPanel3.Controls.Add(Me.TableLayoutPanel1)
        Me.GradientPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GradientPanel3.EndColor = System.Drawing.Color.RoyalBlue
        Me.GradientPanel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GradientPanel3.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanel3.Name = "GradientPanel3"
        Me.GradientPanel3.Size = New System.Drawing.Size(819, 456)
        Me.GradientPanel3.StartColor = System.Drawing.Color.LightCyan
        Me.GradientPanel3.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(817, 454)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.RoundedPanel3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(41, 44)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(735, 366)
        Me.Panel4.TabIndex = 0
        '
        'RoundedPanel3
        '
        Me.RoundedPanel3.BackColor = System.Drawing.Color.White
        Me.RoundedPanel3.BorderRadius = 32
        Me.RoundedPanel3.Controls.Add(Me.Label6)
        Me.RoundedPanel3.Controls.Add(Me.Label5)
        Me.RoundedPanel3.Controls.Add(Me.Label4)
        Me.RoundedPanel3.Controls.Add(Me.Label3)
        Me.RoundedPanel3.Controls.Add(Me.Label1)
        Me.RoundedPanel3.Controls.Add(Me.txturl2)
        Me.RoundedPanel3.Controls.Add(Me.txturl1)
        Me.RoundedPanel3.Controls.Add(Me.txtemail)
        Me.RoundedPanel3.Controls.Add(Me.txtfax)
        Me.RoundedPanel3.Controls.Add(Me.txtphone)
        Me.RoundedPanel3.Controls.Add(Me.txtcountry)
        Me.RoundedPanel3.Controls.Add(Me.txtpin)
        Me.RoundedPanel3.Controls.Add(Me.txtstate)
        Me.RoundedPanel3.Controls.Add(Me.txtcity)
        Me.RoundedPanel3.Controls.Add(Me.txtaddress2)
        Me.RoundedPanel3.Controls.Add(Me.txtaddress1)
        Me.RoundedPanel3.Controls.Add(Me.txtname)
        Me.RoundedPanel3.Controls.Add(Me.txtregistrationid)
        Me.RoundedPanel3.Controls.Add(Me.Label20)
        Me.RoundedPanel3.Controls.Add(Me.cmbcategory)
        Me.RoundedPanel3.Controls.Add(Me.Label18)
        Me.RoundedPanel3.Controls.Add(Me.Label2)
        Me.RoundedPanel3.Controls.Add(Me.Label21)
        Me.RoundedPanel3.Controls.Add(Me.Label22)
        Me.RoundedPanel3.Controls.Add(Me.Label23)
        Me.RoundedPanel3.Controls.Add(Me.Label24)
        Me.RoundedPanel3.Controls.Add(Me.Label30)
        Me.RoundedPanel3.Controls.Add(Me.Label31)
        Me.RoundedPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RoundedPanel3.Location = New System.Drawing.Point(0, 0)
        Me.RoundedPanel3.Name = "RoundedPanel3"
        Me.RoundedPanel3.Padding = New System.Windows.Forms.Padding(10)
        Me.RoundedPanel3.Size = New System.Drawing.Size(735, 366)
        Me.RoundedPanel3.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(107, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 171
        Me.Label6.Text = "Pin Code:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(347, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 170
        Me.Label5.Text = "Country:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(404, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 169
        Me.Label4.Text = "State:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(107, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 168
        Me.Label3.Text = "City:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(107, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "Address Line 2:"
        '
        'txturl2
        '
        Me.txturl2.BackColor = System.Drawing.Color.White
        Me.txturl2.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.Http
        Me.txturl2.Location = New System.Drawing.Point(219, 291)
        Me.txturl2.Name = "txturl2"
        Me.txturl2.Required = False
        Me.txturl2.ShowErrorIcon = False
        Me.txturl2.Size = New System.Drawing.Size(404, 21)
        Me.txturl2.TabIndex = 166
        Me.txturl2.TextBox = ""
        Me.txturl2.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txturl2.WaterMark = "Enter Forum Address"
        Me.txturl2.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txturl2.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txturl2.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txturl1
        '
        Me.txturl1.BackColor = System.Drawing.Color.White
        Me.txturl1.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.Http
        Me.txturl1.Location = New System.Drawing.Point(219, 264)
        Me.txturl1.Name = "txturl1"
        Me.txturl1.Required = False
        Me.txturl1.ShowErrorIcon = False
        Me.txturl1.Size = New System.Drawing.Size(404, 21)
        Me.txturl1.TabIndex = 165
        Me.txturl1.TextBox = ""
        Me.txturl1.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txturl1.WaterMark = "Enter Website Address"
        Me.txturl1.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txturl1.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txturl1.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtemail
        '
        Me.txtemail.BackColor = System.Drawing.Color.White
        Me.txtemail.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.Email
        Me.txtemail.Location = New System.Drawing.Point(219, 237)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Required = False
        Me.txtemail.ShowErrorIcon = False
        Me.txtemail.Size = New System.Drawing.Size(404, 21)
        Me.txtemail.TabIndex = 164
        Me.txtemail.TextBox = ""
        Me.txtemail.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtemail.WaterMark = "Enter Email Address"
        Me.txtemail.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtemail.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtfax
        '
        Me.txtfax.BackColor = System.Drawing.Color.White
        Me.txtfax.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtfax.Location = New System.Drawing.Point(469, 210)
        Me.txtfax.Name = "txtfax"
        Me.txtfax.Required = False
        Me.txtfax.ShowErrorIcon = False
        Me.txtfax.Size = New System.Drawing.Size(154, 21)
        Me.txtfax.TabIndex = 163
        Me.txtfax.TextBox = ""
        Me.txtfax.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtfax.WaterMark = "Enter Fax No."
        Me.txtfax.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtfax.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfax.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtphone
        '
        Me.txtphone.BackColor = System.Drawing.Color.White
        Me.txtphone.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtphone.Location = New System.Drawing.Point(219, 210)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Required = False
        Me.txtphone.ShowErrorIcon = False
        Me.txtphone.Size = New System.Drawing.Size(179, 21)
        Me.txtphone.TabIndex = 162
        Me.txtphone.TextBox = ""
        Me.txtphone.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtphone.WaterMark = "Enter Telephone No."
        Me.txtphone.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtphone.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphone.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtcountry
        '
        Me.txtcountry.BackColor = System.Drawing.Color.White
        Me.txtcountry.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtcountry.Location = New System.Drawing.Point(411, 183)
        Me.txtcountry.Name = "txtcountry"
        Me.txtcountry.Required = False
        Me.txtcountry.ShowErrorIcon = False
        Me.txtcountry.Size = New System.Drawing.Size(212, 21)
        Me.txtcountry.TabIndex = 161
        Me.txtcountry.TextBox = ""
        Me.txtcountry.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtcountry.WaterMark = "Enter Country"
        Me.txtcountry.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtcountry.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcountry.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtpin
        '
        Me.txtpin.BackColor = System.Drawing.Color.White
        Me.txtpin.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtpin.Location = New System.Drawing.Point(219, 183)
        Me.txtpin.Name = "txtpin"
        Me.txtpin.Required = False
        Me.txtpin.ShowErrorIcon = False
        Me.txtpin.Size = New System.Drawing.Size(122, 21)
        Me.txtpin.TabIndex = 160
        Me.txtpin.TextBox = ""
        Me.txtpin.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtpin.WaterMark = "Enter Pin Code"
        Me.txtpin.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtpin.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpin.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtstate
        '
        Me.txtstate.BackColor = System.Drawing.Color.White
        Me.txtstate.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtstate.Location = New System.Drawing.Point(452, 156)
        Me.txtstate.Name = "txtstate"
        Me.txtstate.Required = False
        Me.txtstate.ShowErrorIcon = False
        Me.txtstate.Size = New System.Drawing.Size(171, 21)
        Me.txtstate.TabIndex = 159
        Me.txtstate.TextBox = ""
        Me.txtstate.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtstate.WaterMark = "Enter State"
        Me.txtstate.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtstate.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstate.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtcity
        '
        Me.txtcity.BackColor = System.Drawing.Color.White
        Me.txtcity.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtcity.Location = New System.Drawing.Point(219, 156)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Required = False
        Me.txtcity.ShowErrorIcon = False
        Me.txtcity.Size = New System.Drawing.Size(179, 21)
        Me.txtcity.TabIndex = 158
        Me.txtcity.TextBox = ""
        Me.txtcity.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtcity.WaterMark = "Enter City"
        Me.txtcity.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtcity.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcity.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtaddress2
        '
        Me.txtaddress2.BackColor = System.Drawing.Color.White
        Me.txtaddress2.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtaddress2.Location = New System.Drawing.Point(219, 129)
        Me.txtaddress2.Name = "txtaddress2"
        Me.txtaddress2.Required = False
        Me.txtaddress2.ShowErrorIcon = False
        Me.txtaddress2.Size = New System.Drawing.Size(404, 21)
        Me.txtaddress2.TabIndex = 157
        Me.txtaddress2.TextBox = ""
        Me.txtaddress2.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtaddress2.WaterMark = "Enter Address Line 2"
        Me.txtaddress2.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtaddress2.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress2.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtaddress1
        '
        Me.txtaddress1.BackColor = System.Drawing.Color.White
        Me.txtaddress1.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtaddress1.Location = New System.Drawing.Point(219, 102)
        Me.txtaddress1.Name = "txtaddress1"
        Me.txtaddress1.Required = False
        Me.txtaddress1.ShowErrorIcon = False
        Me.txtaddress1.Size = New System.Drawing.Size(404, 21)
        Me.txtaddress1.TabIndex = 156
        Me.txtaddress1.TextBox = ""
        Me.txtaddress1.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtaddress1.WaterMark = "Enter Address Line 1"
        Me.txtaddress1.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtaddress1.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress1.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.White
        Me.txtname.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtname.Location = New System.Drawing.Point(219, 75)
        Me.txtname.Name = "txtname"
        Me.txtname.Required = True
        Me.txtname.ShowErrorIcon = False
        Me.txtname.Size = New System.Drawing.Size(404, 21)
        Me.txtname.TabIndex = 155
        Me.txtname.TextBox = ""
        Me.txtname.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtname.WaterMark = "Institution Name"
        Me.txtname.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtname.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtregistrationid
        '
        Me.txtregistrationid.BackColor = System.Drawing.Color.White
        Me.txtregistrationid.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtregistrationid.Location = New System.Drawing.Point(219, 49)
        Me.txtregistrationid.Name = "txtregistrationid"
        Me.txtregistrationid.Required = True
        Me.txtregistrationid.ShowErrorIcon = False
        Me.txtregistrationid.Size = New System.Drawing.Size(172, 21)
        Me.txtregistrationid.TabIndex = 154
        Me.txtregistrationid.TextBox = ""
        Me.txtregistrationid.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtregistrationid.WaterMark = "Registration ID"
        Me.txtregistrationid.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtregistrationid.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtregistrationid.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(107, 52)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(98, 13)
        Me.Label20.TabIndex = 153
        Me.Label20.Text = "Registration ID:"
        '
        'cmbcategory
        '
        Me.cmbcategory.BackColor = System.Drawing.Color.White
        Me.cmbcategory.Enabled = False
        Me.cmbcategory.FormattingEnabled = True
        Me.cmbcategory.Items.AddRange(New Object() {"Computer Institute", "Engineering College", "Graduation College", "Management Institute", "Medical College", "Primary School", "Secondary School", "University", "Others"})
        Me.cmbcategory.Location = New System.Drawing.Point(469, 49)
        Me.cmbcategory.Name = "cmbcategory"
        Me.cmbcategory.Size = New System.Drawing.Size(154, 21)
        Me.cmbcategory.TabIndex = 126
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(398, 52)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 13)
        Me.Label18.TabIndex = 152
        Me.Label18.Text = "Category:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "Forum:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(107, 267)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 13)
        Me.Label21.TabIndex = 150
        Me.Label21.Text = "Website:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(107, 240)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 13)
        Me.Label22.TabIndex = 149
        Me.Label22.Text = "E-mail:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(432, 213)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(32, 13)
        Me.Label23.TabIndex = 148
        Me.Label23.Text = "Fax:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(107, 213)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(71, 13)
        Me.Label24.TabIndex = 147
        Me.Label24.Text = "Telephone:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(107, 105)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(96, 13)
        Me.Label30.TabIndex = 141
        Me.Label30.Text = "Address Line 1:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(107, 78)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(106, 13)
        Me.Label31.TabIndex = 140
        Me.Label31.Text = "Institution Name:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GradientPanel2)
        Me.TabPage2.Location = New System.Drawing.Point(0, 0)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(819, 456)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GradientPanel2
        '
        Me.GradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GradientPanel2.Controls.Add(Me.TableLayoutPanel2)
        Me.GradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GradientPanel2.EndColor = System.Drawing.Color.RoyalBlue
        Me.GradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanel2.Name = "GradientPanel2"
        Me.GradientPanel2.Size = New System.Drawing.Size(819, 456)
        Me.GradientPanel2.StartColor = System.Drawing.Color.LightCyan
        Me.GradientPanel2.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel8, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(817, 454)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.RoundedPanel4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(41, 44)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(735, 366)
        Me.Panel8.TabIndex = 0
        '
        'RoundedPanel4
        '
        Me.RoundedPanel4.BackColor = System.Drawing.Color.White
        Me.RoundedPanel4.BorderRadius = 32
        Me.RoundedPanel4.Controls.Add(Me.Grouper2)
        Me.RoundedPanel4.Controls.Add(Me.Grouper1)
        Me.RoundedPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RoundedPanel4.Location = New System.Drawing.Point(0, 0)
        Me.RoundedPanel4.Name = "RoundedPanel4"
        Me.RoundedPanel4.Padding = New System.Windows.Forms.Padding(10)
        Me.RoundedPanel4.Size = New System.Drawing.Size(735, 366)
        Me.RoundedPanel4.TabIndex = 1
        '
        'Grouper2
        '
        Me.Grouper2.BackgroundColor = System.Drawing.Color.White
        Me.Grouper2.BackgroundGradientColor = System.Drawing.Color.White
        Me.Grouper2.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.Grouper2.BorderColor = System.Drawing.Color.Black
        Me.Grouper2.BorderThickness = 1.0!
        Me.Grouper2.Controls.Add(Me.dgviewfeatures)
        Me.Grouper2.CustomGroupBoxColor = System.Drawing.Color.White
        Me.Grouper2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grouper2.GroupImage = Global.Umbrella.My.Resources.Resources.facility
        Me.Grouper2.GroupTitle = "Features:"
        Me.Grouper2.Location = New System.Drawing.Point(10, 156)
        Me.Grouper2.Name = "Grouper2"
        Me.Grouper2.Padding = New System.Windows.Forms.Padding(14, 25, 14, 10)
        Me.Grouper2.PaintGroupBox = False
        Me.Grouper2.RoundCorners = 10
        Me.Grouper2.ShadowColor = System.Drawing.Color.DarkGray
        Me.Grouper2.ShadowControl = False
        Me.Grouper2.ShadowThickness = 3
        Me.Grouper2.Size = New System.Drawing.Size(715, 200)
        Me.Grouper2.TabIndex = 34
        '
        'dgviewfeatures
        '
        Me.dgviewfeatures.AllowUserToAddRows = False
        Me.dgviewfeatures.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgviewfeatures.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgviewfeatures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgviewfeatures.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgviewfeatures.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgviewfeatures.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgviewfeatures.ColumnHeadersVisible = False
        Me.dgviewfeatures.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.DataGridViewTextBoxColumn1})
        Me.dgviewfeatures.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewfeatures.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgviewfeatures.Location = New System.Drawing.Point(14, 25)
        Me.dgviewfeatures.Name = "dgviewfeatures"
        Me.dgviewfeatures.ReadOnly = True
        Me.dgviewfeatures.RowHeadersVisible = False
        Me.dgviewfeatures.Size = New System.Drawing.Size(687, 165)
        Me.dgviewfeatures.TabIndex = 19
        '
        'Column1
        '
        Me.Column1.FillWeight = 5.076142!
        Me.Column1.HeaderText = "SL"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 194.9239!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Features"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Grouper1
        '
        Me.Grouper1.BackgroundColor = System.Drawing.Color.White
        Me.Grouper1.BackgroundGradientColor = System.Drawing.Color.White
        Me.Grouper1.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.Grouper1.BorderColor = System.Drawing.Color.Black
        Me.Grouper1.BorderThickness = 1.0!
        Me.Grouper1.Controls.Add(Me.dgviewcourse)
        Me.Grouper1.CustomGroupBoxColor = System.Drawing.Color.White
        Me.Grouper1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Grouper1.GroupImage = Global.Umbrella.My.Resources.Resources.course_icon
        Me.Grouper1.GroupTitle = "Courses:"
        Me.Grouper1.Location = New System.Drawing.Point(10, 10)
        Me.Grouper1.Name = "Grouper1"
        Me.Grouper1.Padding = New System.Windows.Forms.Padding(14, 25, 14, 10)
        Me.Grouper1.PaintGroupBox = False
        Me.Grouper1.RoundCorners = 10
        Me.Grouper1.ShadowColor = System.Drawing.Color.DarkGray
        Me.Grouper1.ShadowControl = False
        Me.Grouper1.ShadowThickness = 3
        Me.Grouper1.Size = New System.Drawing.Size(715, 146)
        Me.Grouper1.TabIndex = 33
        '
        'dgviewcourse
        '
        Me.dgviewcourse.AllowUserToAddRows = False
        Me.dgviewcourse.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgviewcourse.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgviewcourse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgviewcourse.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgviewcourse.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgviewcourse.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmsl, Me.clmcoursename, Me.clmcourseid, Me.clmduration})
        Me.dgviewcourse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewcourse.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgviewcourse.Location = New System.Drawing.Point(14, 25)
        Me.dgviewcourse.Name = "dgviewcourse"
        Me.dgviewcourse.ReadOnly = True
        Me.dgviewcourse.RowHeadersVisible = False
        Me.dgviewcourse.Size = New System.Drawing.Size(687, 111)
        Me.dgviewcourse.TabIndex = 18
        '
        'clmsl
        '
        Me.clmsl.HeaderText = "SL"
        Me.clmsl.Name = "clmsl"
        Me.clmsl.ReadOnly = True
        Me.clmsl.Width = 40
        '
        'clmcoursename
        '
        Me.clmcoursename.HeaderText = "Course"
        Me.clmcoursename.Name = "clmcoursename"
        Me.clmcoursename.ReadOnly = True
        Me.clmcoursename.Width = 440
        '
        'clmcourseid
        '
        Me.clmcourseid.HeaderText = "Code"
        Me.clmcourseid.Name = "clmcourseid"
        Me.clmcourseid.ReadOnly = True
        Me.clmcourseid.Width = 98
        '
        'clmduration
        '
        Me.clmduration.AllowDateSep = False
        Me.clmduration.AllowDecimal = True
        Me.clmduration.AllowMinus = False
        Me.clmduration.HeaderText = "Duration (in Months)"
        Me.clmduration.MaxInputLength = 0
        Me.clmduration.Name = "clmduration"
        Me.clmduration.ReadOnly = True
        Me.clmduration.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmduration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmduration.Width = 96
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GradientPanel1)
        Me.TabPage3.Location = New System.Drawing.Point(0, 0)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(819, 456)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GradientPanel1
        '
        Me.GradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GradientPanel1.Controls.Add(Me.TableLayoutPanel3)
        Me.GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GradientPanel1.EndColor = System.Drawing.Color.RoyalBlue
        Me.GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanel1.Name = "GradientPanel1"
        Me.GradientPanel1.Size = New System.Drawing.Size(819, 456)
        Me.GradientPanel1.StartColor = System.Drawing.Color.LightCyan
        Me.GradientPanel1.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel9, 1, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(817, 454)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.RoundedPanel5)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(41, 44)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(735, 366)
        Me.Panel9.TabIndex = 0
        '
        'RoundedPanel5
        '
        Me.RoundedPanel5.BackColor = System.Drawing.Color.White
        Me.RoundedPanel5.BorderRadius = 32
        Me.RoundedPanel5.Controls.Add(Me.Grouper6)
        Me.RoundedPanel5.Controls.Add(Me.Grouper4)
        Me.RoundedPanel5.Controls.Add(Me.Grouper5)
        Me.RoundedPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RoundedPanel5.Location = New System.Drawing.Point(0, 0)
        Me.RoundedPanel5.Name = "RoundedPanel5"
        Me.RoundedPanel5.Padding = New System.Windows.Forms.Padding(10)
        Me.RoundedPanel5.Size = New System.Drawing.Size(735, 366)
        Me.RoundedPanel5.TabIndex = 0
        '
        'Grouper6
        '
        Me.Grouper6.BackgroundColor = System.Drawing.Color.White
        Me.Grouper6.BackgroundGradientColor = System.Drawing.Color.White
        Me.Grouper6.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.Grouper6.BorderColor = System.Drawing.Color.Black
        Me.Grouper6.BorderThickness = 1.0!
        Me.Grouper6.Controls.Add(Me.lblfinancialperiod)
        Me.Grouper6.CustomGroupBoxColor = System.Drawing.Color.White
        Me.Grouper6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grouper6.GroupImage = Global.Umbrella.My.Resources.Resources.period
        Me.Grouper6.GroupTitle = "Financial Period:"
        Me.Grouper6.Location = New System.Drawing.Point(10, 266)
        Me.Grouper6.Name = "Grouper6"
        Me.Grouper6.Padding = New System.Windows.Forms.Padding(19, 25, 19, 10)
        Me.Grouper6.PaintGroupBox = False
        Me.Grouper6.RoundCorners = 10
        Me.Grouper6.ShadowColor = System.Drawing.Color.DarkGray
        Me.Grouper6.ShadowControl = False
        Me.Grouper6.ShadowThickness = 3
        Me.Grouper6.Size = New System.Drawing.Size(715, 90)
        Me.Grouper6.TabIndex = 37
        '
        'lblfinancialperiod
        '
        Me.lblfinancialperiod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblfinancialperiod.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfinancialperiod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblfinancialperiod.Location = New System.Drawing.Point(19, 25)
        Me.lblfinancialperiod.Name = "lblfinancialperiod"
        Me.lblfinancialperiod.Size = New System.Drawing.Size(677, 55)
        Me.lblfinancialperiod.TabIndex = 0
        Me.lblfinancialperiod.Text = "Financial Period: "
        Me.lblfinancialperiod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Grouper4
        '
        Me.Grouper4.BackgroundColor = System.Drawing.Color.White
        Me.Grouper4.BackgroundGradientColor = System.Drawing.Color.White
        Me.Grouper4.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.Grouper4.BorderColor = System.Drawing.Color.Black
        Me.Grouper4.BorderThickness = 1.0!
        Me.Grouper4.Controls.Add(Me.dgviewachievements)
        Me.Grouper4.CustomGroupBoxColor = System.Drawing.Color.White
        Me.Grouper4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Grouper4.GroupImage = Global.Umbrella.My.Resources.Resources.achievement
        Me.Grouper4.GroupTitle = "Achievements"
        Me.Grouper4.Location = New System.Drawing.Point(10, 156)
        Me.Grouper4.Name = "Grouper4"
        Me.Grouper4.Padding = New System.Windows.Forms.Padding(16, 25, 16, 10)
        Me.Grouper4.PaintGroupBox = False
        Me.Grouper4.RoundCorners = 10
        Me.Grouper4.ShadowColor = System.Drawing.Color.DarkGray
        Me.Grouper4.ShadowControl = False
        Me.Grouper4.ShadowThickness = 3
        Me.Grouper4.Size = New System.Drawing.Size(715, 110)
        Me.Grouper4.TabIndex = 36
        '
        'dgviewachievements
        '
        Me.dgviewachievements.AllowUserToAddRows = False
        Me.dgviewachievements.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgviewachievements.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgviewachievements.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgviewachievements.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgviewachievements.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgviewachievements.ColumnHeadersVisible = False
        Me.dgviewachievements.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.DataGridViewTextBoxColumn2})
        Me.dgviewachievements.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewachievements.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgviewachievements.Location = New System.Drawing.Point(16, 25)
        Me.dgviewachievements.Name = "dgviewachievements"
        Me.dgviewachievements.ReadOnly = True
        Me.dgviewachievements.RowHeadersVisible = False
        Me.dgviewachievements.Size = New System.Drawing.Size(683, 75)
        Me.dgviewachievements.TabIndex = 19
        '
        'Column2
        '
        Me.Column2.HeaderText = "SL"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Features"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 641
        '
        'Grouper5
        '
        Me.Grouper5.BackgroundColor = System.Drawing.Color.White
        Me.Grouper5.BackgroundGradientColor = System.Drawing.Color.White
        Me.Grouper5.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.Grouper5.BorderColor = System.Drawing.Color.Black
        Me.Grouper5.BorderThickness = 1.0!
        Me.Grouper5.Controls.Add(Me.dgviewaccounts)
        Me.Grouper5.CustomGroupBoxColor = System.Drawing.Color.White
        Me.Grouper5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Grouper5.GroupImage = Global.Umbrella.My.Resources.Resources.accounting_management_icon
        Me.Grouper5.GroupTitle = "Accounts:"
        Me.Grouper5.Location = New System.Drawing.Point(10, 10)
        Me.Grouper5.Name = "Grouper5"
        Me.Grouper5.Padding = New System.Windows.Forms.Padding(16, 25, 16, 10)
        Me.Grouper5.PaintGroupBox = False
        Me.Grouper5.RoundCorners = 10
        Me.Grouper5.ShadowColor = System.Drawing.Color.DarkGray
        Me.Grouper5.ShadowControl = False
        Me.Grouper5.ShadowThickness = 3
        Me.Grouper5.Size = New System.Drawing.Size(715, 146)
        Me.Grouper5.TabIndex = 35
        '
        'dgviewaccounts
        '
        Me.dgviewaccounts.AllowUserToAddRows = False
        Me.dgviewaccounts.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.dgviewaccounts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgviewaccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgviewaccounts.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgviewaccounts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgviewaccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.NumericTextBoxColumn1})
        Me.dgviewaccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewaccounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgviewaccounts.Location = New System.Drawing.Point(16, 25)
        Me.dgviewaccounts.Name = "dgviewaccounts"
        Me.dgviewaccounts.ReadOnly = True
        Me.dgviewaccounts.RowHeadersVisible = False
        Me.dgviewaccounts.Size = New System.Drawing.Size(683, 111)
        Me.dgviewaccounts.TabIndex = 18
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "SL"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 40
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Account ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 98
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Descriptions"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 440
        '
        'NumericTextBoxColumn1
        '
        Me.NumericTextBoxColumn1.AllowDateSep = False
        Me.NumericTextBoxColumn1.AllowDecimal = True
        Me.NumericTextBoxColumn1.AllowMinus = False
        Me.NumericTextBoxColumn1.HeaderText = "Balance"
        Me.NumericTextBoxColumn1.MaxInputLength = 0
        Me.NumericTextBoxColumn1.Name = "NumericTextBoxColumn1"
        Me.NumericTextBoxColumn1.ReadOnly = True
        Me.NumericTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NumericTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.NumericTextBoxColumn1.Width = 96
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'frmInstitutionDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(839, 556)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RoundedPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.Custom
        Me.Name = "frmInstitutionDetails"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Institution Info"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Grouper3.ResumeLayout(False)
        CType(Me.DataGridViewSummary3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.RoundedPanel2.ResumeLayout(False)
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.pictab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.pictab2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.pictab3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GradientPanel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.RoundedPanel3.ResumeLayout(False)
        Me.RoundedPanel3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GradientPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.RoundedPanel4.ResumeLayout(False)
        Me.Grouper2.ResumeLayout(False)
        CType(Me.dgviewfeatures, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grouper1.ResumeLayout(False)
        CType(Me.dgviewcourse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GradientPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.RoundedPanel5.ResumeLayout(False)
        Me.Grouper6.ResumeLayout(False)
        Me.Grouper4.ResumeLayout(False)
        CType(Me.dgviewachievements, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grouper5.ResumeLayout(False)
        CType(Me.dgviewaccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grouper3 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents DataGridViewSummary3 As ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel5 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel6 As System.Windows.Forms.LinkLabel
    Friend WithEvents RoundedPanel2 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents RoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As ESAR_Controls.UIControls.TabControl.eTabControlEx
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents pictab1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents pictab2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pictab3 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GradientPanel3 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents GradientPanel2 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents RoundedPanel4 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents Grouper2 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents dgviewfeatures As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Grouper1 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents dgviewcourse As System.Windows.Forms.DataGridView
    Friend WithEvents clmsl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmcoursename As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmcourseid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmduration As ESAR_Controls.UIControls.DataGridView.eNumericTextBoxColumn
    Friend WithEvents GradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents RoundedPanel5 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents Grouper6 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents lblfinancialperiod As System.Windows.Forms.Label
    Friend WithEvents Grouper4 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents dgviewachievements As System.Windows.Forms.DataGridView
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Grouper5 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents dgviewaccounts As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents RoundedPanel3 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmbcategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumericTextBoxColumn1 As ESAR_Controls.UIControls.DataGridView.eNumericTextBoxColumn
    Friend WithEvents txtfax As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtphone As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtcountry As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtpin As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtstate As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtcity As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtaddress2 As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtaddress1 As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtname As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtregistrationid As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txturl2 As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txturl1 As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtemail As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents ELabel1 As ESAR_Controls.eLabel
    Friend WithEvents btnhelp As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnrefresh As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
