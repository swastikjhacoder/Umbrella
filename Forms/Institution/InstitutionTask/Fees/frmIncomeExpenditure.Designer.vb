Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncomeExpenditure
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim DesignerRectTracker1 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIncomeExpenditure))
        Dim DesignerRectTracker2 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker3 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker4 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim CBlendItems1 As ESAR_Controls.cBlendItems = New ESAR_Controls.cBlendItems
        Me.GradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Grouper2 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.dgviewexpenditureaccounts = New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
        Me.DataGridViewLinkColumn1 = New System.Windows.Forms.DataGridViewLinkColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CurrencyColumn1 = New ESAR_Controls.UIControls.DataGridView.eCurrencyColumn
        Me.Grouper1 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.dgviewincomeaccounts = New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
        Me.Column1 = New System.Windows.Forms.DataGridViewLinkColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New ESAR_Controls.UIControls.DataGridView.eCurrencyColumn
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Grouper4 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.dgviewexpenditures = New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
        Me.DataGridViewLinkColumn2 = New System.Windows.Forms.DataGridViewLinkColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewLinkColumn3 = New System.Windows.Forms.DataGridViewLinkColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ECurrencyColumn1 = New ESAR_Controls.UIControls.DataGridView.eCurrencyColumn
        Me.Grouper3 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.dgviewincomes = New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
        Me.Column4 = New System.Windows.Forms.DataGridViewLinkColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewLinkColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New ESAR_Controls.UIControls.DataGridView.eCurrencyColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.lnktable = New System.Windows.Forms.LinkLabel
        Me.lnkchart = New System.Windows.Forms.LinkLabel
        Me.dgviewrevenue = New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column10 = New ESAR_Controls.UIControls.DataGridView.eCurrencyColumn
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.RoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.btnhelp = New ESAR_Controls.UIControls.Button.eButton
        Me.btnrefresh = New ESAR_Controls.UIControls.Button.eButton
        Me.ELabel1 = New ESAR_Controls.eLabel
        Me.GradientPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Grouper2.SuspendLayout()
        CType(Me.dgviewexpenditureaccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grouper1.SuspendLayout()
        CType(Me.dgviewincomeaccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Grouper4.SuspendLayout()
        CType(Me.dgviewexpenditures, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grouper3.SuspendLayout()
        CType(Me.dgviewincomes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.dgviewrevenue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GradientPanel1
        '
        Me.GradientPanel1.Controls.Add(Me.SplitContainer1)
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Grouper1)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 5, 0)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grouper3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.SplitContainer1.Size = New System.Drawing.Size(819, 476)
        Me.SplitContainer1.SplitterDistance = 430
        Me.SplitContainer1.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Grouper2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 251)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(425, 225)
        Me.Panel1.TabIndex = 1
        '
        'Grouper2
        '
        Me.Grouper2.BackgroundColor = System.Drawing.Color.White
        Me.Grouper2.BackgroundGradientColor = System.Drawing.Color.White
        Me.Grouper2.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.Grouper2.BorderColor = System.Drawing.Color.Black
        Me.Grouper2.BorderThickness = 1.0!
        Me.Grouper2.Controls.Add(Me.dgviewexpenditureaccounts)
        Me.Grouper2.CustomGroupBoxColor = System.Drawing.Color.White
        Me.Grouper2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grouper2.GroupImage = Nothing
        Me.Grouper2.GroupTitle = "Expenditure Accounts:"
        Me.Grouper2.Location = New System.Drawing.Point(0, 5)
        Me.Grouper2.Name = "Grouper2"
        Me.Grouper2.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.Grouper2.PaintGroupBox = False
        Me.Grouper2.RoundCorners = 10
        Me.Grouper2.ShadowColor = System.Drawing.Color.DarkGray
        Me.Grouper2.ShadowControl = False
        Me.Grouper2.ShadowThickness = 3
        Me.Grouper2.Size = New System.Drawing.Size(425, 220)
        Me.Grouper2.TabIndex = 0
        '
        'dgviewexpenditureaccounts
        '
        Me.dgviewexpenditureaccounts.AllowUserToAddRows = False
        Me.dgviewexpenditureaccounts.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgviewexpenditureaccounts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgviewexpenditureaccounts.BackgroundColor = System.Drawing.Color.White
        Me.dgviewexpenditureaccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgviewexpenditureaccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewLinkColumn1, Me.DataGridViewTextBoxColumn1, Me.CurrencyColumn1})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewexpenditureaccounts.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgviewexpenditureaccounts.DisplaySumRowHeader = True
        Me.dgviewexpenditureaccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewexpenditureaccounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgviewexpenditureaccounts.Location = New System.Drawing.Point(10, 25)
        Me.dgviewexpenditureaccounts.MultiSelect = False
        Me.dgviewexpenditureaccounts.Name = "dgviewexpenditureaccounts"
        Me.dgviewexpenditureaccounts.ReadOnly = True
        Me.dgviewexpenditureaccounts.RowHeadersVisible = False
        Me.dgviewexpenditureaccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgviewexpenditureaccounts.Size = New System.Drawing.Size(405, 185)
        Me.dgviewexpenditureaccounts.SummaryColumns = Nothing
        Me.dgviewexpenditureaccounts.SummaryRowBackColor = System.Drawing.Color.Empty
        Me.dgviewexpenditureaccounts.SummaryRowSpace = 0
        Me.dgviewexpenditureaccounts.SummaryRowVisible = True
        Me.dgviewexpenditureaccounts.SumRowHeaderText = Nothing
        Me.dgviewexpenditureaccounts.SumRowHeaderTextBold = True
        Me.dgviewexpenditureaccounts.TabIndex = 2
        '
        'DataGridViewLinkColumn1
        '
        Me.DataGridViewLinkColumn1.HeaderText = "Account ID"
        Me.DataGridViewLinkColumn1.Name = "DataGridViewLinkColumn1"
        Me.DataGridViewLinkColumn1.ReadOnly = True
        Me.DataGridViewLinkColumn1.Width = 90
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 210
        '
        'CurrencyColumn1
        '
        Me.CurrencyColumn1.HeaderText = "Balance"
        Me.CurrencyColumn1.Name = "CurrencyColumn1"
        Me.CurrencyColumn1.ReadOnly = True
        '
        'Grouper1
        '
        Me.Grouper1.BackgroundColor = System.Drawing.Color.White
        Me.Grouper1.BackgroundGradientColor = System.Drawing.Color.White
        Me.Grouper1.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.Grouper1.BorderColor = System.Drawing.Color.Black
        Me.Grouper1.BorderThickness = 1.0!
        Me.Grouper1.Controls.Add(Me.dgviewincomeaccounts)
        Me.Grouper1.CustomGroupBoxColor = System.Drawing.Color.White
        Me.Grouper1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Grouper1.GroupImage = Nothing
        Me.Grouper1.GroupTitle = "Income Accounts:"
        Me.Grouper1.Location = New System.Drawing.Point(0, 5)
        Me.Grouper1.Name = "Grouper1"
        Me.Grouper1.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.Grouper1.PaintGroupBox = False
        Me.Grouper1.RoundCorners = 10
        Me.Grouper1.ShadowColor = System.Drawing.Color.DarkGray
        Me.Grouper1.ShadowControl = False
        Me.Grouper1.ShadowThickness = 3
        Me.Grouper1.Size = New System.Drawing.Size(425, 246)
        Me.Grouper1.TabIndex = 0
        '
        'dgviewincomeaccounts
        '
        Me.dgviewincomeaccounts.AllowUserToAddRows = False
        Me.dgviewincomeaccounts.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgviewincomeaccounts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgviewincomeaccounts.BackgroundColor = System.Drawing.Color.White
        Me.dgviewincomeaccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgviewincomeaccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewincomeaccounts.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgviewincomeaccounts.DisplaySumRowHeader = True
        Me.dgviewincomeaccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewincomeaccounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgviewincomeaccounts.Location = New System.Drawing.Point(10, 25)
        Me.dgviewincomeaccounts.MultiSelect = False
        Me.dgviewincomeaccounts.Name = "dgviewincomeaccounts"
        Me.dgviewincomeaccounts.ReadOnly = True
        Me.dgviewincomeaccounts.RowHeadersVisible = False
        Me.dgviewincomeaccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgviewincomeaccounts.Size = New System.Drawing.Size(405, 211)
        Me.dgviewincomeaccounts.SummaryColumns = Nothing
        Me.dgviewincomeaccounts.SummaryRowBackColor = System.Drawing.Color.Empty
        Me.dgviewincomeaccounts.SummaryRowSpace = 0
        Me.dgviewincomeaccounts.SummaryRowVisible = True
        Me.dgviewincomeaccounts.SumRowHeaderText = Nothing
        Me.dgviewincomeaccounts.SumRowHeaderTextBold = True
        Me.dgviewincomeaccounts.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Account ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 90
        '
        'Column2
        '
        Me.Column2.HeaderText = "Description"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 210
        '
        'Column3
        '
        Me.Column3.HeaderText = "Balance"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Grouper4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(5, 318)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel3.Size = New System.Drawing.Size(380, 158)
        Me.Panel3.TabIndex = 2
        '
        'Grouper4
        '
        Me.Grouper4.BackgroundColor = System.Drawing.Color.White
        Me.Grouper4.BackgroundGradientColor = System.Drawing.Color.White
        Me.Grouper4.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.Grouper4.BorderColor = System.Drawing.Color.Black
        Me.Grouper4.BorderThickness = 1.0!
        Me.Grouper4.Controls.Add(Me.dgviewexpenditures)
        Me.Grouper4.CustomGroupBoxColor = System.Drawing.Color.White
        Me.Grouper4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grouper4.GroupImage = Nothing
        Me.Grouper4.GroupTitle = "All Expenditures:"
        Me.Grouper4.Location = New System.Drawing.Point(0, 5)
        Me.Grouper4.Name = "Grouper4"
        Me.Grouper4.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.Grouper4.PaintGroupBox = False
        Me.Grouper4.RoundCorners = 10
        Me.Grouper4.ShadowColor = System.Drawing.Color.DarkGray
        Me.Grouper4.ShadowControl = False
        Me.Grouper4.ShadowThickness = 3
        Me.Grouper4.Size = New System.Drawing.Size(380, 153)
        Me.Grouper4.TabIndex = 0
        '
        'dgviewexpenditures
        '
        Me.dgviewexpenditures.AllowUserToAddRows = False
        Me.dgviewexpenditures.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgviewexpenditures.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgviewexpenditures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgviewexpenditures.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgviewexpenditures.BackgroundColor = System.Drawing.Color.White
        Me.dgviewexpenditures.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewLinkColumn2, Me.DataGridViewTextBoxColumn2, Me.DataGridViewLinkColumn3, Me.DataGridViewTextBoxColumn3, Me.ECurrencyColumn1})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewexpenditures.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgviewexpenditures.DisplaySumRowHeader = False
        Me.dgviewexpenditures.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewexpenditures.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgviewexpenditures.Location = New System.Drawing.Point(10, 25)
        Me.dgviewexpenditures.MultiSelect = False
        Me.dgviewexpenditures.Name = "dgviewexpenditures"
        Me.dgviewexpenditures.ReadOnly = True
        Me.dgviewexpenditures.RowHeadersVisible = False
        Me.dgviewexpenditures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgviewexpenditures.Size = New System.Drawing.Size(360, 118)
        Me.dgviewexpenditures.SummaryColumns = Nothing
        Me.dgviewexpenditures.SummaryRowBackColor = System.Drawing.Color.Empty
        Me.dgviewexpenditures.SummaryRowSpace = 0
        Me.dgviewexpenditures.SummaryRowVisible = False
        Me.dgviewexpenditures.SumRowHeaderText = Nothing
        Me.dgviewexpenditures.SumRowHeaderTextBold = False
        Me.dgviewexpenditures.TabIndex = 1
        '
        'DataGridViewLinkColumn2
        '
        Me.DataGridViewLinkColumn2.HeaderText = "Transaction ID"
        Me.DataGridViewLinkColumn2.Name = "DataGridViewLinkColumn2"
        Me.DataGridViewLinkColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewLinkColumn3
        '
        Me.DataGridViewLinkColumn3.HeaderText = "Reg No"
        Me.DataGridViewLinkColumn3.Name = "DataGridViewLinkColumn3"
        Me.DataGridViewLinkColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'ECurrencyColumn1
        '
        Me.ECurrencyColumn1.HeaderText = "Amount"
        Me.ECurrencyColumn1.Name = "ECurrencyColumn1"
        Me.ECurrencyColumn1.ReadOnly = True
        '
        'Grouper3
        '
        Me.Grouper3.BackgroundColor = System.Drawing.Color.White
        Me.Grouper3.BackgroundGradientColor = System.Drawing.Color.White
        Me.Grouper3.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.Grouper3.BorderColor = System.Drawing.Color.Black
        Me.Grouper3.BorderThickness = 1.0!
        Me.Grouper3.Controls.Add(Me.dgviewincomes)
        Me.Grouper3.CustomGroupBoxColor = System.Drawing.Color.White
        Me.Grouper3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Grouper3.GroupImage = Nothing
        Me.Grouper3.GroupTitle = "All Incomes:"
        Me.Grouper3.Location = New System.Drawing.Point(5, 160)
        Me.Grouper3.Name = "Grouper3"
        Me.Grouper3.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.Grouper3.PaintGroupBox = False
        Me.Grouper3.RoundCorners = 10
        Me.Grouper3.ShadowColor = System.Drawing.Color.DarkGray
        Me.Grouper3.ShadowControl = False
        Me.Grouper3.ShadowThickness = 3
        Me.Grouper3.Size = New System.Drawing.Size(380, 158)
        Me.Grouper3.TabIndex = 1
        '
        'dgviewincomes
        '
        Me.dgviewincomes.AllowUserToAddRows = False
        Me.dgviewincomes.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.dgviewincomes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgviewincomes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgviewincomes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgviewincomes.BackgroundColor = System.Drawing.Color.White
        Me.dgviewincomes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column9})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewincomes.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgviewincomes.DisplaySumRowHeader = False
        Me.dgviewincomes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewincomes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgviewincomes.Location = New System.Drawing.Point(10, 25)
        Me.dgviewincomes.MultiSelect = False
        Me.dgviewincomes.Name = "dgviewincomes"
        Me.dgviewincomes.ReadOnly = True
        Me.dgviewincomes.RowHeadersVisible = False
        Me.dgviewincomes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgviewincomes.Size = New System.Drawing.Size(360, 123)
        Me.dgviewincomes.SummaryColumns = Nothing
        Me.dgviewincomes.SummaryRowBackColor = System.Drawing.Color.Empty
        Me.dgviewincomes.SummaryRowSpace = 0
        Me.dgviewincomes.SummaryRowVisible = False
        Me.dgviewincomes.SumRowHeaderText = Nothing
        Me.dgviewincomes.SumRowHeaderTextBold = False
        Me.dgviewincomes.TabIndex = 0
        '
        'Column4
        '
        Me.Column4.HeaderText = "Transaction ID"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Description"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Reg No"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Name"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Amount"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SplitContainer2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(5, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(380, 155)
        Me.Panel2.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.IsSplitterFixed = True
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.lnktable)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lnkchart)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgviewrevenue)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Chart1)
        Me.SplitContainer2.Panel2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.SplitContainer2.Size = New System.Drawing.Size(380, 155)
        Me.SplitContainer2.SplitterDistance = 25
        Me.SplitContainer2.TabIndex = 0
        '
        'lnktable
        '
        Me.lnktable.Dock = System.Windows.Forms.DockStyle.Right
        Me.lnktable.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnktable.Image = Global.Umbrella.My.Resources.Resources.table
        Me.lnktable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnktable.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnktable.LinkColor = System.Drawing.Color.Honeydew
        Me.lnktable.Location = New System.Drawing.Point(246, 0)
        Me.lnktable.Name = "lnktable"
        Me.lnktable.Size = New System.Drawing.Size(67, 25)
        Me.lnktable.TabIndex = 1
        Me.lnktable.TabStop = True
        Me.lnktable.Text = "Table"
        Me.lnktable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lnkchart
        '
        Me.lnkchart.Dock = System.Windows.Forms.DockStyle.Right
        Me.lnkchart.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkchart.Image = Global.Umbrella.My.Resources.Resources.chart
        Me.lnkchart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkchart.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkchart.LinkColor = System.Drawing.Color.Honeydew
        Me.lnkchart.Location = New System.Drawing.Point(313, 0)
        Me.lnkchart.Name = "lnkchart"
        Me.lnkchart.Size = New System.Drawing.Size(67, 25)
        Me.lnkchart.TabIndex = 0
        Me.lnkchart.TabStop = True
        Me.lnkchart.Text = "Chart"
        Me.lnkchart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgviewrevenue
        '
        Me.dgviewrevenue.AllowUserToAddRows = False
        Me.dgviewrevenue.AllowUserToDeleteRows = False
        Me.dgviewrevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgviewrevenue.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgviewrevenue.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dgviewrevenue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgviewrevenue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgviewrevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgviewrevenue.ColumnHeadersVisible = False
        Me.dgviewrevenue.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column10})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewrevenue.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgviewrevenue.DisplaySumRowHeader = False
        Me.dgviewrevenue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewrevenue.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgviewrevenue.Location = New System.Drawing.Point(0, 0)
        Me.dgviewrevenue.Name = "dgviewrevenue"
        Me.dgviewrevenue.ReadOnly = True
        Me.dgviewrevenue.RowHeadersVisible = False
        Me.dgviewrevenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgviewrevenue.Size = New System.Drawing.Size(380, 121)
        Me.dgviewrevenue.SummaryColumns = Nothing
        Me.dgviewrevenue.SummaryRowBackColor = System.Drawing.Color.Empty
        Me.dgviewrevenue.SummaryRowSpace = 0
        Me.dgviewrevenue.SummaryRowVisible = False
        Me.dgviewrevenue.SumRowHeaderText = Nothing
        Me.dgviewrevenue.SumRowHeaderTextBold = False
        Me.dgviewrevenue.TabIndex = 4
        Me.dgviewrevenue.Visible = False
        '
        'Column8
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column8.HeaderText = "Name"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column10
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle10
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
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(380, 121)
        Me.Chart1.TabIndex = 3
        Me.Chart1.Text = "Chart1"
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
        Me.RoundedPanel1.TabIndex = 22
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
        Me.btnrefresh.Location = New System.Drawing.Point(10, 10)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(87, 40)
        Me.btnrefresh.TabIndex = 82
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
        Me.ELabel1.Location = New System.Drawing.Point(466, 10)
        Me.ELabel1.MouseOverColor = System.Drawing.Color.Gray
        Me.ELabel1.Name = "ELabel1"
        Me.ELabel1.ShadowState = True
        Me.ELabel1.Size = New System.Drawing.Size(343, 40)
        Me.ELabel1.TabIndex = 39
        Me.ELabel1.Text = "Income & Expenditure Account Details"
        '
        'frmIncomeExpenditure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
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
        Me.Name = "frmIncomeExpenditure"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Income & Expenditure Account Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GradientPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Grouper2.ResumeLayout(False)
        CType(Me.dgviewexpenditureaccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grouper1.ResumeLayout(False)
        CType(Me.dgviewincomeaccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Grouper4.ResumeLayout(False)
        CType(Me.dgviewexpenditures, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grouper3.ResumeLayout(False)
        CType(Me.dgviewincomes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.dgviewrevenue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents RoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Grouper2 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents Grouper1 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents dgviewincomeaccounts As ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
    Friend WithEvents dgviewexpenditureaccounts As ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
    Friend WithEvents DataGridViewLinkColumn1 As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencyColumn1 As ESAR_Controls.UIControls.DataGridView.eCurrencyColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As ESAR_Controls.UIControls.DataGridView.eCurrencyColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Grouper4 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents Grouper3 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents dgviewincomes As ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
    Friend WithEvents ELabel1 As ESAR_Controls.eLabel
    Friend WithEvents btnhelp As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnrefresh As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents dgviewexpenditures As ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
    Friend WithEvents DataGridViewLinkColumn2 As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewLinkColumn3 As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ECurrencyColumn1 As ESAR_Controls.UIControls.DataGridView.eCurrencyColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As ESAR_Controls.UIControls.DataGridView.eCurrencyColumn
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents lnkchart As System.Windows.Forms.LinkLabel
    Friend WithEvents lnktable As System.Windows.Forms.LinkLabel
    Friend WithEvents dgviewrevenue As ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As ESAR_Controls.UIControls.DataGridView.eCurrencyColumn
End Class
