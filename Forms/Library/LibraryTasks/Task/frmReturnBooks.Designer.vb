Imports Umbrella.UIControls
Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturnBookss
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReturnBookss))
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.EGroupBox1 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.txtreturndate = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtissuedate = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtregno = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtissuename = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbdate = New ESAR_Controls.UIControls.ComboBox.eComboBoxDateTime
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbissueid = New ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
        Me.cmbapplylatecharge = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.EGroupBox3 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.dgviewbooks = New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewLinkColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.btnhelp = New ESAR_Controls.UIControls.Button.eButton
        Me.btnrefresh = New ESAR_Controls.UIControls.Button.eButton
        Me.btndelete = New ESAR_Controls.UIControls.Button.eButton
        Me.btnsavenew = New ESAR_Controls.UIControls.Button.eButton
        Me.btnsave = New ESAR_Controls.UIControls.Button.eButton
        Me.btnnew = New ESAR_Controls.UIControls.Button.eButton
        Me.ELabel1 = New ESAR_Controls.eLabel
        Me.EGradientPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.EGroupBox1.SuspendLayout()
        Me.EGroupBox3.SuspendLayout()
        CType(Me.dgviewbooks, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.EGradientPanel1.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(10, 70)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EGroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EGroupBox3)
        Me.SplitContainer1.Size = New System.Drawing.Size(819, 476)
        Me.SplitContainer1.SplitterDistance = 275
        Me.SplitContainer1.TabIndex = 22
        '
        'EGroupBox1
        '
        Me.EGroupBox1.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox1.BorderThickness = 1.0!
        Me.EGroupBox1.Controls.Add(Me.txtreturndate)
        Me.EGroupBox1.Controls.Add(Me.txtissuedate)
        Me.EGroupBox1.Controls.Add(Me.txtregno)
        Me.EGroupBox1.Controls.Add(Me.txtissuename)
        Me.EGroupBox1.Controls.Add(Me.Label3)
        Me.EGroupBox1.Controls.Add(Me.Label4)
        Me.EGroupBox1.Controls.Add(Me.cmbdate)
        Me.EGroupBox1.Controls.Add(Me.Label1)
        Me.EGroupBox1.Controls.Add(Me.cmbissueid)
        Me.EGroupBox1.Controls.Add(Me.cmbapplylatecharge)
        Me.EGroupBox1.Controls.Add(Me.Label7)
        Me.EGroupBox1.Controls.Add(Me.Label6)
        Me.EGroupBox1.Controls.Add(Me.Label5)
        Me.EGroupBox1.Controls.Add(Me.Label2)
        Me.EGroupBox1.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox1.GroupImage = Nothing
        Me.EGroupBox1.GroupTitle = "Return Book:"
        Me.EGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.EGroupBox1.Name = "EGroupBox1"
        Me.EGroupBox1.Padding = New System.Windows.Forms.Padding(16, 25, 16, 10)
        Me.EGroupBox1.PaintGroupBox = False
        Me.EGroupBox1.RoundCorners = 10
        Me.EGroupBox1.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox1.ShadowControl = False
        Me.EGroupBox1.ShadowThickness = 3
        Me.EGroupBox1.Size = New System.Drawing.Size(819, 275)
        Me.EGroupBox1.TabIndex = 4
        '
        'txtreturndate
        '
        Me.txtreturndate.BackColor = System.Drawing.Color.White
        Me.txtreturndate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtreturndate.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtreturndate.Location = New System.Drawing.Point(352, 187)
        Me.txtreturndate.Name = "txtreturndate"
        Me.txtreturndate.ReadOnly = True
        Me.txtreturndate.Required = False
        Me.txtreturndate.ShowErrorIcon = False
        Me.txtreturndate.Size = New System.Drawing.Size(136, 14)
        Me.txtreturndate.TabIndex = 5
        Me.txtreturndate.TextBox = ""
        Me.txtreturndate.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtreturndate.WaterMark = "Return Date"
        Me.txtreturndate.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtreturndate.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreturndate.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtissuedate
        '
        Me.txtissuedate.BackColor = System.Drawing.Color.White
        Me.txtissuedate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtissuedate.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtissuedate.Location = New System.Drawing.Point(352, 160)
        Me.txtissuedate.Name = "txtissuedate"
        Me.txtissuedate.ReadOnly = True
        Me.txtissuedate.Required = False
        Me.txtissuedate.ShowErrorIcon = False
        Me.txtissuedate.Size = New System.Drawing.Size(136, 14)
        Me.txtissuedate.TabIndex = 4
        Me.txtissuedate.TextBox = ""
        Me.txtissuedate.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtissuedate.WaterMark = "Issue Date"
        Me.txtissuedate.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtissuedate.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtissuedate.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtregno
        '
        Me.txtregno.BackColor = System.Drawing.Color.White
        Me.txtregno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtregno.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtregno.Location = New System.Drawing.Point(352, 101)
        Me.txtregno.Name = "txtregno"
        Me.txtregno.ReadOnly = True
        Me.txtregno.Required = False
        Me.txtregno.ShowErrorIcon = False
        Me.txtregno.Size = New System.Drawing.Size(283, 14)
        Me.txtregno.TabIndex = 2
        Me.txtregno.TextBox = ""
        Me.txtregno.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtregno.WaterMark = "Registration No."
        Me.txtregno.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtregno.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtregno.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtissuename
        '
        Me.txtissuename.BackColor = System.Drawing.Color.White
        Me.txtissuename.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtissuename.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtissuename.Location = New System.Drawing.Point(352, 128)
        Me.txtissuename.Name = "txtissuename"
        Me.txtissuename.ReadOnly = True
        Me.txtissuename.Required = False
        Me.txtissuename.ShowErrorIcon = False
        Me.txtissuename.Size = New System.Drawing.Size(883, 14)
        Me.txtissuename.TabIndex = 3
        Me.txtissuename.TextBox = ""
        Me.txtissuename.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtissuename.WaterMark = "Enter Name"
        Me.txtissuename.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtissuename.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtissuename.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Reg No.:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Name:"
        '
        'cmbdate
        '
        Me.cmbdate.FormatString = "d"
        Me.cmbdate.FormattingEnabled = True
        Me.cmbdate.Location = New System.Drawing.Point(352, 44)
        Me.cmbdate.Name = "cmbdate"
        Me.cmbdate.Size = New System.Drawing.Size(280, 21)
        Me.cmbdate.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Date:"
        '
        'cmbissueid
        '
        Me.cmbissueid.FormattingEnabled = True
        Me.cmbissueid.InstantBinding = True
        Me.cmbissueid.Location = New System.Drawing.Point(352, 71)
        Me.cmbissueid.Name = "cmbissueid"
        Me.cmbissueid.Size = New System.Drawing.Size(280, 21)
        Me.cmbissueid.TabIndex = 1
        '
        'cmbapplylatecharge
        '
        Me.cmbapplylatecharge.BackColor = System.Drawing.Color.White
        Me.cmbapplylatecharge.FormattingEnabled = True
        Me.cmbapplylatecharge.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbapplylatecharge.Location = New System.Drawing.Point(352, 211)
        Me.cmbapplylatecharge.Name = "cmbapplylatecharge"
        Me.cmbapplylatecharge.Size = New System.Drawing.Size(126, 21)
        Me.cmbapplylatecharge.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 26)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Late Charges" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Apply:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Return Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Issue Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Book Loan No:"
        '
        'EGroupBox3
        '
        Me.EGroupBox3.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox3.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox3.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox3.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox3.BorderThickness = 1.0!
        Me.EGroupBox3.Controls.Add(Me.dgviewbooks)
        Me.EGroupBox3.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox3.GroupImage = Nothing
        Me.EGroupBox3.GroupTitle = "Book Details:"
        Me.EGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.EGroupBox3.Name = "EGroupBox3"
        Me.EGroupBox3.Padding = New System.Windows.Forms.Padding(14, 25, 14, 10)
        Me.EGroupBox3.PaintGroupBox = False
        Me.EGroupBox3.RoundCorners = 10
        Me.EGroupBox3.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox3.ShadowControl = False
        Me.EGroupBox3.ShadowThickness = 3
        Me.EGroupBox3.Size = New System.Drawing.Size(819, 197)
        Me.EGroupBox3.TabIndex = 2
        '
        'dgviewbooks
        '
        Me.dgviewbooks.AllowUserToAddRows = False
        Me.dgviewbooks.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgviewbooks.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgviewbooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgviewbooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgviewbooks.BackgroundColor = System.Drawing.Color.White
        Me.dgviewbooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgviewbooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewbooks.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgviewbooks.DisplaySumRowHeader = True
        Me.dgviewbooks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewbooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgviewbooks.Location = New System.Drawing.Point(14, 25)
        Me.dgviewbooks.MultiSelect = False
        Me.dgviewbooks.Name = "dgviewbooks"
        Me.dgviewbooks.ReadOnly = True
        Me.dgviewbooks.RowHeadersVisible = False
        Me.dgviewbooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgviewbooks.Size = New System.Drawing.Size(791, 162)
        Me.dgviewbooks.SummaryColumns = Nothing
        Me.dgviewbooks.SummaryRowBackColor = System.Drawing.Color.Empty
        Me.dgviewbooks.SummaryRowSpace = 0
        Me.dgviewbooks.SummaryRowVisible = True
        Me.dgviewbooks.SumRowHeaderText = Nothing
        Me.dgviewbooks.SumRowHeaderTextBold = True
        Me.dgviewbooks.TabIndex = 2
        '
        'Column7
        '
        Me.Column7.HeaderText = "Book Name"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Book ID"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Author"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "Edition"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
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
        Me.RoundedPanel1.TabIndex = 18
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
        Me.btndelete.FocalPoints.CenterPtX = 0.4556962!
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
        Me.btnsavenew.FocalPoints.CenterPtX = 0.4583333!
        Me.btnsavenew.FocalPoints.CenterPtY = 0.425!
        Me.btnsavenew.FocalPoints.FocusPtX = 0.0!
        Me.btnsavenew.FocalPoints.FocusPtY = 0.0!
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
        Me.btnsave.FocalPoints.CenterPtX = 0.4788733!
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
        Me.ELabel1.Location = New System.Drawing.Point(541, 10)
        Me.ELabel1.MouseOverColor = System.Drawing.Color.Gray
        Me.ELabel1.Name = "ELabel1"
        Me.ELabel1.ShadowState = True
        Me.ELabel1.Size = New System.Drawing.Size(268, 40)
        Me.ELabel1.TabIndex = 34
        Me.ELabel1.Text = "Maintain Return Books"
        '
        'frmReturnBookss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
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
        Me.Name = "frmReturnBookss"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maintain Return Books"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.EGradientPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.EGroupBox1.ResumeLayout(False)
        Me.EGroupBox1.PerformLayout()
        Me.EGroupBox3.ResumeLayout(False)
        CType(Me.dgviewbooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EGradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents RoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents ELabel1 As ESAR_Controls.eLabel
    Friend WithEvents btnhelp As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnrefresh As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btndelete As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnsavenew As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnsave As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnnew As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EGroupBox3 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents dgviewbooks As ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EGroupBox1 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents txtregno As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtissuename As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbdate As ESAR_Controls.UIControls.ComboBox.eComboBoxDateTime
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbissueid As ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
    Friend WithEvents cmbapplylatecharge As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtreturndate As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtissuedate As ESAR_Controls.UIControls.TextBox.eTextBox
End Class
