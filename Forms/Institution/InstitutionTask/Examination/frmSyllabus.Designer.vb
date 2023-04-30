Imports Umbrella.UIControls
Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSyllabus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSyllabus))
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
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewNumericTextBoxColumn1 = New ESAR_Controls.UIControls.DataGridView.eNumericTextBoxColumn
        Me.DataGridViewNumericTextBoxColumn2 = New ESAR_Controls.UIControls.DataGridView.eNumericTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewNumericTextBoxColumn3 = New ESAR_Controls.UIControls.DataGridView.eNumericTextBoxColumn
        Me.DataGridViewNumericTextBoxColumn4 = New ESAR_Controls.UIControls.DataGridView.eNumericTextBoxColumn
        Me.GradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Grouper1 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.dgviewsyllabus = New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RoundedPanel2 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.txtclass = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtmarksobtained = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtchapterdetails = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txttotalclass = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txttotalmarks = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtchapter = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.cmbsubject = New ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
        Me.cmbcourse = New ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbstudent = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
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
        Me.Panel2.SuspendLayout()
        Me.Grouper1.SuspendLayout()
        CType(Me.dgviewsyllabus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundedPanel2.SuspendLayout()
        Me.RoundedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Course"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 115
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Subject"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 116
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Chapter"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 115
        '
        'DataGridViewNumericTextBoxColumn1
        '
        Me.DataGridViewNumericTextBoxColumn1.AllowDateSep = False
        Me.DataGridViewNumericTextBoxColumn1.AllowDecimal = True
        Me.DataGridViewNumericTextBoxColumn1.AllowMinus = False
        Me.DataGridViewNumericTextBoxColumn1.HeaderText = "Total Marks"
        Me.DataGridViewNumericTextBoxColumn1.MaxInputLength = 0
        Me.DataGridViewNumericTextBoxColumn1.Name = "DataGridViewNumericTextBoxColumn1"
        Me.DataGridViewNumericTextBoxColumn1.ReadOnly = True
        Me.DataGridViewNumericTextBoxColumn1.Width = 115
        '
        'DataGridViewNumericTextBoxColumn2
        '
        Me.DataGridViewNumericTextBoxColumn2.AllowDateSep = False
        Me.DataGridViewNumericTextBoxColumn2.AllowDecimal = True
        Me.DataGridViewNumericTextBoxColumn2.AllowMinus = False
        Me.DataGridViewNumericTextBoxColumn2.HeaderText = "Total Class"
        Me.DataGridViewNumericTextBoxColumn2.MaxInputLength = 0
        Me.DataGridViewNumericTextBoxColumn2.Name = "DataGridViewNumericTextBoxColumn2"
        Me.DataGridViewNumericTextBoxColumn2.ReadOnly = True
        Me.DataGridViewNumericTextBoxColumn2.Width = 115
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Details"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 116
        '
        'DataGridViewNumericTextBoxColumn3
        '
        Me.DataGridViewNumericTextBoxColumn3.AllowDateSep = False
        Me.DataGridViewNumericTextBoxColumn3.AllowDecimal = True
        Me.DataGridViewNumericTextBoxColumn3.AllowMinus = False
        Me.DataGridViewNumericTextBoxColumn3.HeaderText = "Marks Obtained"
        Me.DataGridViewNumericTextBoxColumn3.MaxInputLength = 0
        Me.DataGridViewNumericTextBoxColumn3.Name = "DataGridViewNumericTextBoxColumn3"
        Me.DataGridViewNumericTextBoxColumn3.ReadOnly = True
        Me.DataGridViewNumericTextBoxColumn3.Width = 115
        '
        'DataGridViewNumericTextBoxColumn4
        '
        Me.DataGridViewNumericTextBoxColumn4.AllowDateSep = False
        Me.DataGridViewNumericTextBoxColumn4.AllowDecimal = True
        Me.DataGridViewNumericTextBoxColumn4.AllowMinus = False
        Me.DataGridViewNumericTextBoxColumn4.HeaderText = "Class"
        Me.DataGridViewNumericTextBoxColumn4.MaxInputLength = 0
        Me.DataGridViewNumericTextBoxColumn4.Name = "DataGridViewNumericTextBoxColumn4"
        Me.DataGridViewNumericTextBoxColumn4.ReadOnly = True
        Me.DataGridViewNumericTextBoxColumn4.Width = 115
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
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.RoundedPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(819, 476)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Grouper1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 107)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel2.Size = New System.Drawing.Size(819, 369)
        Me.Panel2.TabIndex = 1
        '
        'Grouper1
        '
        Me.Grouper1.BackgroundColor = System.Drawing.Color.White
        Me.Grouper1.BackgroundGradientColor = System.Drawing.Color.White
        Me.Grouper1.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.Grouper1.BorderColor = System.Drawing.Color.Black
        Me.Grouper1.BorderThickness = 1.0!
        Me.Grouper1.Controls.Add(Me.dgviewsyllabus)
        Me.Grouper1.CustomGroupBoxColor = System.Drawing.Color.White
        Me.Grouper1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grouper1.GroupImage = Global.Umbrella.My.Resources.Resources.syllabus
        Me.Grouper1.GroupTitle = "Syllabus for the Course: "
        Me.Grouper1.Location = New System.Drawing.Point(0, 5)
        Me.Grouper1.Name = "Grouper1"
        Me.Grouper1.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.Grouper1.PaintGroupBox = False
        Me.Grouper1.RoundCorners = 10
        Me.Grouper1.ShadowColor = System.Drawing.Color.DarkGray
        Me.Grouper1.ShadowControl = False
        Me.Grouper1.ShadowThickness = 3
        Me.Grouper1.Size = New System.Drawing.Size(819, 364)
        Me.Grouper1.TabIndex = 0
        '
        'dgviewsyllabus
        '
        Me.dgviewsyllabus.AllowUserToAddRows = False
        Me.dgviewsyllabus.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgviewsyllabus.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgviewsyllabus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgviewsyllabus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgviewsyllabus.BackgroundColor = System.Drawing.Color.White
        Me.dgviewsyllabus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewsyllabus.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgviewsyllabus.DisplaySumRowHeader = False
        Me.dgviewsyllabus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewsyllabus.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgviewsyllabus.Location = New System.Drawing.Point(10, 25)
        Me.dgviewsyllabus.Name = "dgviewsyllabus"
        Me.dgviewsyllabus.ReadOnly = True
        Me.dgviewsyllabus.RowHeadersVisible = False
        Me.dgviewsyllabus.Size = New System.Drawing.Size(799, 329)
        Me.dgviewsyllabus.SummaryColumns = Nothing
        Me.dgviewsyllabus.SummaryRowBackColor = System.Drawing.Color.Empty
        Me.dgviewsyllabus.SummaryRowSpace = 0
        Me.dgviewsyllabus.SummaryRowVisible = False
        Me.dgviewsyllabus.SumRowHeaderText = Nothing
        Me.dgviewsyllabus.SumRowHeaderTextBold = False
        Me.dgviewsyllabus.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Course"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Subject"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Chapter"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'RoundedPanel2
        '
        Me.RoundedPanel2.BackColor = System.Drawing.Color.White
        Me.RoundedPanel2.BorderRadius = 32
        Me.RoundedPanel2.Controls.Add(Me.txtclass)
        Me.RoundedPanel2.Controls.Add(Me.txtmarksobtained)
        Me.RoundedPanel2.Controls.Add(Me.txtchapterdetails)
        Me.RoundedPanel2.Controls.Add(Me.txttotalclass)
        Me.RoundedPanel2.Controls.Add(Me.txttotalmarks)
        Me.RoundedPanel2.Controls.Add(Me.txtchapter)
        Me.RoundedPanel2.Controls.Add(Me.cmbsubject)
        Me.RoundedPanel2.Controls.Add(Me.cmbcourse)
        Me.RoundedPanel2.Controls.Add(Me.Label10)
        Me.RoundedPanel2.Controls.Add(Me.Label9)
        Me.RoundedPanel2.Controls.Add(Me.Label8)
        Me.RoundedPanel2.Controls.Add(Me.Label7)
        Me.RoundedPanel2.Controls.Add(Me.cmbstudent)
        Me.RoundedPanel2.Controls.Add(Me.Label5)
        Me.RoundedPanel2.Controls.Add(Me.Label4)
        Me.RoundedPanel2.Controls.Add(Me.Label3)
        Me.RoundedPanel2.Controls.Add(Me.Label2)
        Me.RoundedPanel2.Controls.Add(Me.Label6)
        Me.RoundedPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.RoundedPanel2.Location = New System.Drawing.Point(0, 0)
        Me.RoundedPanel2.Name = "RoundedPanel2"
        Me.RoundedPanel2.Size = New System.Drawing.Size(819, 107)
        Me.RoundedPanel2.TabIndex = 0
        '
        'txtclass
        '
        Me.txtclass.BackColor = System.Drawing.Color.White
        Me.txtclass.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtclass.Location = New System.Drawing.Point(730, 70)
        Me.txtclass.Name = "txtclass"
        Me.txtclass.Required = False
        Me.txtclass.ShowErrorIcon = True
        Me.txtclass.Size = New System.Drawing.Size(54, 21)
        Me.txtclass.TabIndex = 8
        Me.txtclass.TextBox = Nothing
        Me.txtclass.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.Numbers
        Me.txtclass.WaterMark = "0"
        Me.txtclass.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtclass.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclass.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtmarksobtained
        '
        Me.txtmarksobtained.BackColor = System.Drawing.Color.White
        Me.txtmarksobtained.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtmarksobtained.Location = New System.Drawing.Point(594, 70)
        Me.txtmarksobtained.Name = "txtmarksobtained"
        Me.txtmarksobtained.Required = False
        Me.txtmarksobtained.ShowErrorIcon = True
        Me.txtmarksobtained.Size = New System.Drawing.Size(54, 21)
        Me.txtmarksobtained.TabIndex = 6
        Me.txtmarksobtained.TextBox = Nothing
        Me.txtmarksobtained.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.Numbers
        Me.txtmarksobtained.WaterMark = "0"
        Me.txtmarksobtained.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtmarksobtained.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmarksobtained.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtchapterdetails
        '
        Me.txtchapterdetails.BackColor = System.Drawing.Color.White
        Me.txtchapterdetails.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtchapterdetails.Location = New System.Drawing.Point(126, 70)
        Me.txtchapterdetails.Name = "txtchapterdetails"
        Me.txtchapterdetails.Required = False
        Me.txtchapterdetails.ShowErrorIcon = False
        Me.txtchapterdetails.Size = New System.Drawing.Size(356, 21)
        Me.txtchapterdetails.TabIndex = 4
        Me.txtchapterdetails.TextBox = ""
        Me.txtchapterdetails.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtchapterdetails.WaterMark = "Enter Chapter Details"
        Me.txtchapterdetails.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtchapterdetails.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchapterdetails.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txttotalclass
        '
        Me.txttotalclass.BackColor = System.Drawing.Color.White
        Me.txttotalclass.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txttotalclass.Location = New System.Drawing.Point(730, 43)
        Me.txttotalclass.Name = "txttotalclass"
        Me.txttotalclass.Required = False
        Me.txttotalclass.ShowErrorIcon = True
        Me.txttotalclass.Size = New System.Drawing.Size(54, 21)
        Me.txttotalclass.TabIndex = 7
        Me.txttotalclass.TextBox = Nothing
        Me.txttotalclass.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.Numbers
        Me.txttotalclass.WaterMark = "0"
        Me.txttotalclass.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txttotalclass.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalclass.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txttotalmarks
        '
        Me.txttotalmarks.BackColor = System.Drawing.Color.White
        Me.txttotalmarks.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txttotalmarks.Location = New System.Drawing.Point(594, 43)
        Me.txttotalmarks.Name = "txttotalmarks"
        Me.txttotalmarks.Required = False
        Me.txttotalmarks.ShowErrorIcon = True
        Me.txttotalmarks.Size = New System.Drawing.Size(54, 21)
        Me.txttotalmarks.TabIndex = 5
        Me.txttotalmarks.TextBox = Nothing
        Me.txttotalmarks.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.Numbers
        Me.txttotalmarks.WaterMark = "0"
        Me.txttotalmarks.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txttotalmarks.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalmarks.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtchapter
        '
        Me.txtchapter.BackColor = System.Drawing.Color.White
        Me.txtchapter.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtchapter.Location = New System.Drawing.Point(126, 43)
        Me.txtchapter.Name = "txtchapter"
        Me.txtchapter.Required = False
        Me.txtchapter.ShowErrorIcon = False
        Me.txtchapter.Size = New System.Drawing.Size(356, 21)
        Me.txtchapter.TabIndex = 3
        Me.txtchapter.TextBox = ""
        Me.txtchapter.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtchapter.WaterMark = "Enter Chapter"
        Me.txtchapter.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtchapter.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchapter.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'cmbsubject
        '
        Me.cmbsubject.BackColor = System.Drawing.Color.White
        Me.cmbsubject.FormattingEnabled = True
        Me.cmbsubject.InstantBinding = True
        Me.cmbsubject.Location = New System.Drawing.Point(361, 16)
        Me.cmbsubject.Name = "cmbsubject"
        Me.cmbsubject.Size = New System.Drawing.Size(121, 21)
        Me.cmbsubject.TabIndex = 1
        '
        'cmbcourse
        '
        Me.cmbcourse.BackColor = System.Drawing.Color.White
        Me.cmbcourse.FormattingEnabled = True
        Me.cmbcourse.InstantBinding = True
        Me.cmbcourse.Location = New System.Drawing.Point(126, 16)
        Me.cmbcourse.Name = "cmbcourse"
        Me.cmbcourse.Size = New System.Drawing.Size(121, 21)
        Me.cmbcourse.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(654, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "Total Class:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(512, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Total Marks:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(681, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Class:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(488, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Marks Obtained:"
        '
        'cmbstudent
        '
        Me.cmbstudent.BackColor = System.Drawing.Color.White
        Me.cmbstudent.FormattingEnabled = True
        Me.cmbstudent.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year", "5th Year", "6th Year", "7th Year", "8th Year", "9th Year", "10th Year", "11th Year", "12th Year"})
        Me.cmbstudent.Location = New System.Drawing.Point(650, 16)
        Me.cmbstudent.Name = "cmbstudent"
        Me.cmbstudent.Size = New System.Drawing.Size(134, 21)
        Me.cmbstudent.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(488, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 13)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Course for the student of:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Chapter Details:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Chapter:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(261, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Select Subject:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Select Course:"
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
        Me.RoundedPanel1.TabIndex = 19
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
        Me.ELabel1.Location = New System.Drawing.Point(616, 10)
        Me.ELabel1.MouseOverColor = System.Drawing.Color.Gray
        Me.ELabel1.Name = "ELabel1"
        Me.ELabel1.ShadowState = True
        Me.ELabel1.Size = New System.Drawing.Size(193, 40)
        Me.ELabel1.TabIndex = 34
        Me.ELabel1.Text = "Maintain Syllabus"
        '
        'frmSyllabus
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
        Me.Name = "frmSyllabus"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maintain Syllabus"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GradientPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Grouper1.ResumeLayout(False)
        CType(Me.dgviewsyllabus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPanel2.ResumeLayout(False)
        Me.RoundedPanel2.PerformLayout()
        Me.RoundedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewNumericTextBoxColumn1 As ESAR_Controls.UIControls.DataGridView.eNumericTextBoxColumn
    Friend WithEvents DataGridViewNumericTextBoxColumn2 As ESAR_Controls.UIControls.DataGridView.eNumericTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewNumericTextBoxColumn3 As ESAR_Controls.UIControls.DataGridView.eNumericTextBoxColumn
    Friend WithEvents DataGridViewNumericTextBoxColumn4 As ESAR_Controls.UIControls.DataGridView.eNumericTextBoxColumn
    Friend WithEvents GradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents RoundedPanel2 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents txtclass As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtmarksobtained As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtchapterdetails As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txttotalclass As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txttotalmarks As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtchapter As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents cmbsubject As ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
    Friend WithEvents cmbcourse As ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbstudent As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Grouper1 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents ELabel1 As ESAR_Controls.eLabel
    Friend WithEvents btnhelp As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnrefresh As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btndelete As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnsavenew As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnsave As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnnew As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents dgviewsyllabus As ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
