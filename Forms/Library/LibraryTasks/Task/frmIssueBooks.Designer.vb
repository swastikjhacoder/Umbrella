Imports Umbrella.UIControls
Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIssueBooks
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
        Dim DesignerRectTracker1 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIssueBooks))
        Dim DesignerRectTracker2 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker3 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker4 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
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
        Dim DesignerRectTracker15 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker16 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim CBlendItems1 As ESAR_Controls.cBlendItems = New ESAR_Controls.cBlendItems
        Me.EGradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.EGroupBox1 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.cmbsearch = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnclear = New ESAR_Controls.UIControls.Button.eButton
        Me.btnsearch = New ESAR_Controls.UIControls.Button.eButton
        Me.cmbissuedto = New ESAR_Controls.UIControls.ComboBox.eComboBoxIcon
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbissuedby = New ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
        Me.cmbduedate = New ESAR_Controls.UIControls.ComboBox.eComboBoxDateTime
        Me.cmbissuedate = New ESAR_Controls.UIControls.ComboBox.eComboBoxDateTime
        Me.txtbookloanno = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtsearch = New ESAR_Controls.UIControls.TextBox.eSearchTextBox
        Me.txtregno = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtcontactno = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtemail = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.cmbstudent = New ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.dgviewbooks = New System.Windows.Forms.DataGridView
        Me.Column5 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewLinkColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.EGroupBox2 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.dgviewselectedbooks = New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
        Me.Column6 = New System.Windows.Forms.DataGridViewButtonColumn
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
        CType(Me.dgviewbooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EGroupBox2.SuspendLayout()
        CType(Me.dgviewselectedbooks, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EGroupBox2)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.SplitContainer1.Size = New System.Drawing.Size(819, 476)
        Me.SplitContainer1.SplitterDistance = 310
        Me.SplitContainer1.TabIndex = 19
        '
        'EGroupBox1
        '
        Me.EGroupBox1.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox1.BorderThickness = 1.0!
        Me.EGroupBox1.Controls.Add(Me.cmbsearch)
        Me.EGroupBox1.Controls.Add(Me.Label11)
        Me.EGroupBox1.Controls.Add(Me.btnclear)
        Me.EGroupBox1.Controls.Add(Me.btnsearch)
        Me.EGroupBox1.Controls.Add(Me.cmbissuedto)
        Me.EGroupBox1.Controls.Add(Me.Label1)
        Me.EGroupBox1.Controls.Add(Me.cmbissuedby)
        Me.EGroupBox1.Controls.Add(Me.cmbduedate)
        Me.EGroupBox1.Controls.Add(Me.cmbissuedate)
        Me.EGroupBox1.Controls.Add(Me.txtbookloanno)
        Me.EGroupBox1.Controls.Add(Me.txtsearch)
        Me.EGroupBox1.Controls.Add(Me.txtregno)
        Me.EGroupBox1.Controls.Add(Me.txtcontactno)
        Me.EGroupBox1.Controls.Add(Me.txtemail)
        Me.EGroupBox1.Controls.Add(Me.cmbstudent)
        Me.EGroupBox1.Controls.Add(Me.Label10)
        Me.EGroupBox1.Controls.Add(Me.Label9)
        Me.EGroupBox1.Controls.Add(Me.Label8)
        Me.EGroupBox1.Controls.Add(Me.Label7)
        Me.EGroupBox1.Controls.Add(Me.dgviewbooks)
        Me.EGroupBox1.Controls.Add(Me.Label6)
        Me.EGroupBox1.Controls.Add(Me.Label5)
        Me.EGroupBox1.Controls.Add(Me.Label4)
        Me.EGroupBox1.Controls.Add(Me.Label3)
        Me.EGroupBox1.Controls.Add(Me.Label2)
        Me.EGroupBox1.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox1.GroupImage = Nothing
        Me.EGroupBox1.GroupTitle = "Issue Book:"
        Me.EGroupBox1.Location = New System.Drawing.Point(0, 5)
        Me.EGroupBox1.Name = "EGroupBox1"
        Me.EGroupBox1.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.EGroupBox1.PaintGroupBox = False
        Me.EGroupBox1.RoundCorners = 10
        Me.EGroupBox1.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox1.ShadowControl = False
        Me.EGroupBox1.ShadowThickness = 3
        Me.EGroupBox1.Size = New System.Drawing.Size(819, 305)
        Me.EGroupBox1.TabIndex = 0
        '
        'cmbsearch
        '
        Me.cmbsearch.FormattingEnabled = True
        Me.cmbsearch.Items.AddRange(New Object() {"Book Name", "Book ID", "Author", "Edition"})
        Me.cmbsearch.Location = New System.Drawing.Point(1266, 110)
        Me.cmbsearch.Name = "cmbsearch"
        Me.cmbsearch.Size = New System.Drawing.Size(347, 21)
        Me.cmbsearch.TabIndex = 54
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1177, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 13)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "In:"
        '
        'btnclear
        '
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnclear.CenterPtTracker = DesignerRectTracker1
        Me.btnclear.ColorFillSolid = System.Drawing.Color.White
        Me.btnclear.Corners.All = CType(11, Short)
        Me.btnclear.Corners.LowerLeft = CType(11, Short)
        Me.btnclear.Corners.LowerRight = CType(11, Short)
        Me.btnclear.Corners.UpperLeft = CType(11, Short)
        Me.btnclear.Corners.UpperRight = CType(11, Short)
        Me.btnclear.Cursor = System.Windows.Forms.Cursors.Hand
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnclear.FocusPtTracker = DesignerRectTracker2
        Me.btnclear.Image = Global.Umbrella.My.Resources.Resources.clear
        Me.btnclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclear.ImageIndex = 0
        Me.btnclear.Location = New System.Drawing.Point(2154, 113)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(178, 21)
        Me.btnclear.TabIndex = 52
        Me.btnclear.Text = "Clear"
        Me.btnclear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnclear.TextShadowShow = False
        '
        'btnsearch
        '
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsearch.CenterPtTracker = DesignerRectTracker3
        Me.btnsearch.ColorFillSolid = System.Drawing.Color.White
        Me.btnsearch.Corners.All = CType(11, Short)
        Me.btnsearch.Corners.LowerLeft = CType(11, Short)
        Me.btnsearch.Corners.LowerRight = CType(11, Short)
        Me.btnsearch.Corners.UpperLeft = CType(11, Short)
        Me.btnsearch.Corners.UpperRight = CType(11, Short)
        Me.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsearch.FocalPoints.CenterPtX = 0.4933333!
        Me.btnsearch.FocalPoints.CenterPtY = 0.3333333!
        Me.btnsearch.FocalPoints.FocusPtX = 0.0!
        Me.btnsearch.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsearch.FocusPtTracker = DesignerRectTracker4
        Me.btnsearch.Image = Global.Umbrella.My.Resources.Resources.find
        Me.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsearch.ImageIndex = 0
        Me.btnsearch.Location = New System.Drawing.Point(1912, 113)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(219, 21)
        Me.btnsearch.TabIndex = 51
        Me.btnsearch.Text = "Search"
        Me.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsearch.TextShadowShow = False
        '
        'cmbissuedto
        '
        Me.cmbissuedto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbissuedto.FormattingEnabled = True
        Me.cmbissuedto.ImageList = Me.ImageList1
        Me.cmbissuedto.Location = New System.Drawing.Point(168, 28)
        Me.cmbissuedto.Name = "cmbissuedto"
        Me.cmbissuedto.Size = New System.Drawing.Size(461, 22)
        Me.cmbissuedto.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "employee.png")
        Me.ImageList1.Images.SetKeyName(1, "student-registration.png")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Issued To:"
        '
        'cmbissuedby
        '
        Me.cmbissuedby.FormattingEnabled = True
        Me.cmbissuedby.InstantBinding = True
        Me.cmbissuedby.Location = New System.Drawing.Point(316, 266)
        Me.cmbissuedby.Name = "cmbissuedby"
        Me.cmbissuedby.Size = New System.Drawing.Size(1570, 21)
        Me.cmbissuedby.TabIndex = 10
        '
        'cmbduedate
        '
        Me.cmbduedate.FormatString = "d"
        Me.cmbduedate.FormattingEnabled = True
        Me.cmbduedate.Location = New System.Drawing.Point(2649, 242)
        Me.cmbduedate.Name = "cmbduedate"
        Me.cmbduedate.Size = New System.Drawing.Size(513, 21)
        Me.cmbduedate.TabIndex = 9
        '
        'cmbissuedate
        '
        Me.cmbissuedate.FormatString = "d"
        Me.cmbissuedate.FormattingEnabled = True
        Me.cmbissuedate.Location = New System.Drawing.Point(1713, 242)
        Me.cmbissuedate.Name = "cmbissuedate"
        Me.cmbissuedate.Size = New System.Drawing.Size(415, 21)
        Me.cmbissuedate.TabIndex = 8
        '
        'txtbookloanno
        '
        Me.txtbookloanno.BackColor = System.Drawing.Color.White
        Me.txtbookloanno.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtbookloanno.Location = New System.Drawing.Point(316, 238)
        Me.txtbookloanno.Name = "txtbookloanno"
        Me.txtbookloanno.Required = False
        Me.txtbookloanno.ShowErrorIcon = False
        Me.txtbookloanno.Size = New System.Drawing.Size(767, 21)
        Me.txtbookloanno.TabIndex = 7
        Me.txtbookloanno.TextBox = ""
        Me.txtbookloanno.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtbookloanno.WaterMark = "Enter Book Loan No."
        Me.txtbookloanno.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtbookloanno.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbookloanno.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtsearch
        '
        Me.txtsearch.ActiveFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtsearch.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtsearch.InactiveFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtsearch.Location = New System.Drawing.Point(168, 109)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(988, 21)
        Me.txtsearch.TabIndex = 5
        '
        'txtregno
        '
        Me.txtregno.BackColor = System.Drawing.Color.White
        Me.txtregno.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtregno.Location = New System.Drawing.Point(1947, 87)
        Me.txtregno.Name = "txtregno"
        Me.txtregno.Required = False
        Me.txtregno.ShowErrorIcon = False
        Me.txtregno.Size = New System.Drawing.Size(378, 21)
        Me.txtregno.TabIndex = 4
        Me.txtregno.TextBox = ""
        Me.txtregno.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtregno.WaterMark = "Enter Reg. No."
        Me.txtregno.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtregno.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtregno.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtcontactno
        '
        Me.txtcontactno.BackColor = System.Drawing.Color.White
        Me.txtcontactno.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtcontactno.Location = New System.Drawing.Point(1947, 60)
        Me.txtcontactno.Name = "txtcontactno"
        Me.txtcontactno.Required = False
        Me.txtcontactno.ShowErrorIcon = False
        Me.txtcontactno.Size = New System.Drawing.Size(378, 21)
        Me.txtcontactno.TabIndex = 2
        Me.txtcontactno.TextBox = ""
        Me.txtcontactno.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtcontactno.WaterMark = "Enter Contact No."
        Me.txtcontactno.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtcontactno.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontactno.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtemail
        '
        Me.txtemail.BackColor = System.Drawing.Color.White
        Me.txtemail.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtemail.Location = New System.Drawing.Point(168, 83)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Required = False
        Me.txtemail.ShowErrorIcon = False
        Me.txtemail.Size = New System.Drawing.Size(1154, 21)
        Me.txtemail.TabIndex = 3
        Me.txtemail.TextBox = ""
        Me.txtemail.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtemail.WaterMark = "Enter Email"
        Me.txtemail.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtemail.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'cmbstudent
        '
        Me.cmbstudent.FormattingEnabled = True
        Me.cmbstudent.InstantBinding = True
        Me.cmbstudent.Location = New System.Drawing.Point(168, 56)
        Me.cmbstudent.Name = "cmbstudent"
        Me.cmbstudent.Size = New System.Drawing.Size(1154, 21)
        Me.cmbstudent.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(56, 273)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Issued By:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(2312, 245)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Due Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1132, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Loan Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Book Loan No:"
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
        Me.dgviewbooks.BackgroundColor = System.Drawing.Color.White
        Me.dgviewbooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgviewbooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewbooks.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgviewbooks.Location = New System.Drawing.Point(168, 136)
        Me.dgviewbooks.Name = "dgviewbooks"
        Me.dgviewbooks.ReadOnly = True
        Me.dgviewbooks.RowHeadersVisible = False
        Me.dgviewbooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgviewbooks.Size = New System.Drawing.Size(1923, 96)
        Me.dgviewbooks.TabIndex = 6
        '
        'Column5
        '
        Me.Column5.HeaderText = "Issue"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 50
        '
        'Column1
        '
        Me.Column1.HeaderText = "Book Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 210
        '
        'Column2
        '
        Me.Column2.HeaderText = "Book ID"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column2.Width = 127
        '
        'Column3
        '
        Me.Column3.HeaderText = "Author"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 132
        '
        'Column4
        '
        Me.Column4.HeaderText = "Edition"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 131
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Search Book:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1603, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Registration No:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1675, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Contact No:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Name:"
        '
        'EGroupBox2
        '
        Me.EGroupBox2.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox2.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox2.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox2.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox2.BorderThickness = 1.0!
        Me.EGroupBox2.Controls.Add(Me.dgviewselectedbooks)
        Me.EGroupBox2.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox2.GroupImage = Nothing
        Me.EGroupBox2.GroupTitle = "Selected Books:"
        Me.EGroupBox2.Location = New System.Drawing.Point(0, 5)
        Me.EGroupBox2.Name = "EGroupBox2"
        Me.EGroupBox2.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.EGroupBox2.PaintGroupBox = False
        Me.EGroupBox2.RoundCorners = 10
        Me.EGroupBox2.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox2.ShadowControl = False
        Me.EGroupBox2.ShadowThickness = 3
        Me.EGroupBox2.Size = New System.Drawing.Size(819, 157)
        Me.EGroupBox2.TabIndex = 0
        '
        'dgviewselectedbooks
        '
        Me.dgviewselectedbooks.AllowUserToAddRows = False
        Me.dgviewselectedbooks.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgviewselectedbooks.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgviewselectedbooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgviewselectedbooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgviewselectedbooks.BackgroundColor = System.Drawing.Color.White
        Me.dgviewselectedbooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgviewselectedbooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewselectedbooks.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgviewselectedbooks.DisplaySumRowHeader = True
        Me.dgviewselectedbooks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewselectedbooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgviewselectedbooks.Location = New System.Drawing.Point(10, 25)
        Me.dgviewselectedbooks.MultiSelect = False
        Me.dgviewselectedbooks.Name = "dgviewselectedbooks"
        Me.dgviewselectedbooks.ReadOnly = True
        Me.dgviewselectedbooks.RowHeadersVisible = False
        Me.dgviewselectedbooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgviewselectedbooks.Size = New System.Drawing.Size(799, 122)
        Me.dgviewselectedbooks.SummaryColumns = Nothing
        Me.dgviewselectedbooks.SummaryRowBackColor = System.Drawing.Color.Empty
        Me.dgviewselectedbooks.SummaryRowSpace = 0
        Me.dgviewselectedbooks.SummaryRowVisible = True
        Me.dgviewselectedbooks.SumRowHeaderText = Nothing
        Me.dgviewselectedbooks.SumRowHeaderTextBold = True
        Me.dgviewselectedbooks.TabIndex = 1
        '
        'Column6
        '
        Me.Column6.HeaderText = "Issue"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
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
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnhelp.CenterPtTracker = DesignerRectTracker5
        Me.btnhelp.ColorFillSolid = System.Drawing.Color.White
        Me.btnhelp.Corners.All = CType(-1, Short)
        Me.btnhelp.Corners.LowerLeft = CType(20, Short)
        Me.btnhelp.Corners.LowerRight = CType(12, Short)
        Me.btnhelp.Corners.UpperLeft = CType(12, Short)
        Me.btnhelp.Corners.UpperRight = CType(20, Short)
        Me.btnhelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhelp.Dock = System.Windows.Forms.DockStyle.Left
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnhelp.FocusPtTracker = DesignerRectTracker6
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
        DesignerRectTracker7.IsActive = False
        DesignerRectTracker7.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker7.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnrefresh.CenterPtTracker = DesignerRectTracker7
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
        DesignerRectTracker8.IsActive = False
        DesignerRectTracker8.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker8.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnrefresh.FocusPtTracker = DesignerRectTracker8
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
        DesignerRectTracker9.IsActive = False
        DesignerRectTracker9.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker9.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btndelete.CenterPtTracker = DesignerRectTracker9
        Me.btndelete.ColorFillSolid = System.Drawing.Color.White
        Me.btndelete.Corners.All = CType(-1, Short)
        Me.btndelete.Corners.LowerLeft = CType(20, Short)
        Me.btndelete.Corners.LowerRight = CType(12, Short)
        Me.btndelete.Corners.UpperLeft = CType(12, Short)
        Me.btndelete.Corners.UpperRight = CType(20, Short)
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndelete.Dock = System.Windows.Forms.DockStyle.Left
        Me.btndelete.FocalPoints.CenterPtX = 0.4936709!
        Me.btndelete.FocalPoints.CenterPtY = 0.45!
        Me.btndelete.FocalPoints.FocusPtX = 0.0!
        Me.btndelete.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker10.IsActive = False
        DesignerRectTracker10.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker10.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btndelete.FocusPtTracker = DesignerRectTracker10
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
        DesignerRectTracker11.IsActive = False
        DesignerRectTracker11.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker11.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsavenew.CenterPtTracker = DesignerRectTracker11
        Me.btnsavenew.ColorFillSolid = System.Drawing.Color.White
        Me.btnsavenew.Corners.All = CType(-1, Short)
        Me.btnsavenew.Corners.LowerLeft = CType(20, Short)
        Me.btnsavenew.Corners.LowerRight = CType(12, Short)
        Me.btnsavenew.Corners.UpperLeft = CType(12, Short)
        Me.btnsavenew.Corners.UpperRight = CType(20, Short)
        Me.btnsavenew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsavenew.Dock = System.Windows.Forms.DockStyle.Left
        DesignerRectTracker12.IsActive = False
        DesignerRectTracker12.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker12.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsavenew.FocusPtTracker = DesignerRectTracker12
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
        DesignerRectTracker13.IsActive = False
        DesignerRectTracker13.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker13.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsave.CenterPtTracker = DesignerRectTracker13
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
        DesignerRectTracker14.IsActive = False
        DesignerRectTracker14.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker14.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsave.FocusPtTracker = DesignerRectTracker14
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
        DesignerRectTracker15.IsActive = False
        DesignerRectTracker15.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker15.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnnew.CenterPtTracker = DesignerRectTracker15
        Me.btnnew.ColorFillSolid = System.Drawing.Color.White
        Me.btnnew.Corners.All = CType(-1, Short)
        Me.btnnew.Corners.LowerLeft = CType(20, Short)
        Me.btnnew.Corners.LowerRight = CType(12, Short)
        Me.btnnew.Corners.UpperLeft = CType(12, Short)
        Me.btnnew.Corners.UpperRight = CType(20, Short)
        Me.btnnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnew.Dock = System.Windows.Forms.DockStyle.Left
        DesignerRectTracker16.IsActive = False
        DesignerRectTracker16.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker16.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnnew.FocusPtTracker = DesignerRectTracker16
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
        Me.ELabel1.Location = New System.Drawing.Point(578, 10)
        Me.ELabel1.MouseOverColor = System.Drawing.Color.Gray
        Me.ELabel1.Name = "ELabel1"
        Me.ELabel1.ShadowState = True
        Me.ELabel1.Size = New System.Drawing.Size(231, 40)
        Me.ELabel1.TabIndex = 34
        Me.ELabel1.Text = "Maintain Issue Books"
        '
        'frmIssueBooks
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
        Me.Name = "frmIssueBooks"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maintain Issue Books"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.EGradientPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.EGroupBox1.ResumeLayout(False)
        Me.EGroupBox1.PerformLayout()
        CType(Me.dgviewbooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EGroupBox2.ResumeLayout(False)
        CType(Me.dgviewselectedbooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EGradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents RoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents ELabel1 As ESAR_Controls.eLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EGroupBox1 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents cmbstudent As ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgviewbooks As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbissuedby As ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
    Friend WithEvents cmbduedate As ESAR_Controls.UIControls.ComboBox.eComboBoxDateTime
    Friend WithEvents cmbissuedate As ESAR_Controls.UIControls.ComboBox.eComboBoxDateTime
    Friend WithEvents txtbookloanno As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtsearch As ESAR_Controls.UIControls.TextBox.eSearchTextBox
    Friend WithEvents txtregno As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtcontactno As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtemail As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents EGroupBox2 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents dgviewselectedbooks As ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
    Friend WithEvents btnhelp As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnrefresh As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btndelete As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnsavenew As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnsave As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnnew As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents cmbissuedto As ESAR_Controls.UIControls.ComboBox.eComboBoxIcon
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnclear As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnsearch As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents cmbsearch As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents Validator1 As Itboy.Components.Validator
    'Friend WithEvents MergedDataGridView1 As KMS.MergedDataGridView
End Class
