Imports Umbrella.UIControls
Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackupRestore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackupRestore))
        Dim DesignerRectTracker1 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker2 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker3 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker4 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker5 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker6 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker7 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker8 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DesignerRectTracker9 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker10 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim CBlendItems1 As ESAR_Controls.cBlendItems = New ESAR_Controls.cBlendItems
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.RoundedPanel2 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.btnrestoreonline = New ESAR_Controls.UIControls.Button.eButton
        Me.btnrestore = New ESAR_Controls.UIControls.Button.eButton
        Me.btnbackuponline = New ESAR_Controls.UIControls.Button.eButton
        Me.btnbackup = New ESAR_Controls.UIControls.Button.eButton
        Me.Grouper1 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dgviewtables = New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.XpProgressBar1 = New ESAR_Controls.UIControls.ProgressBar.eXpProgressBar
        Me.RoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.btnhelp = New ESAR_Controls.UIControls.Button.eButton
        Me.ELabel1 = New ESAR_Controls.eLabel
        Me.GradientPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.RoundedPanel2.SuspendLayout()
        Me.Grouper1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgviewtables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "server_database.png")
        Me.ImageList1.Images.SetKeyName(1, "database.png")
        Me.ImageList1.Images.SetKeyName(2, "authentication.png")
        '
        'Timer1
        '
        Me.Timer1.Interval = 30
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
        Me.GradientPanel1.Size = New System.Drawing.Size(767, 492)
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.RoundedPanel2)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 5, 0)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grouper1)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.SplitContainer1.Size = New System.Drawing.Size(747, 412)
        Me.SplitContainer1.SplitterDistance = 250
        Me.SplitContainer1.TabIndex = 14
        '
        'RoundedPanel2
        '
        Me.RoundedPanel2.BorderRadius = 32
        Me.RoundedPanel2.Controls.Add(Me.btnrestoreonline)
        Me.RoundedPanel2.Controls.Add(Me.btnrestore)
        Me.RoundedPanel2.Controls.Add(Me.btnbackuponline)
        Me.RoundedPanel2.Controls.Add(Me.btnbackup)
        Me.RoundedPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RoundedPanel2.Location = New System.Drawing.Point(0, 5)
        Me.RoundedPanel2.Name = "RoundedPanel2"
        Me.RoundedPanel2.Padding = New System.Windows.Forms.Padding(25)
        Me.RoundedPanel2.Size = New System.Drawing.Size(245, 407)
        Me.RoundedPanel2.TabIndex = 0
        '
        'btnrestoreonline
        '
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnrestoreonline.CenterPtTracker = DesignerRectTracker1
        Me.btnrestoreonline.ColorFillSolid = System.Drawing.Color.AliceBlue
        Me.btnrestoreonline.Corners.All = CType(-1, Short)
        Me.btnrestoreonline.Corners.LowerLeft = CType(20, Short)
        Me.btnrestoreonline.Corners.LowerRight = CType(12, Short)
        Me.btnrestoreonline.Corners.UpperLeft = CType(12, Short)
        Me.btnrestoreonline.Corners.UpperRight = CType(20, Short)
        Me.btnrestoreonline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrestoreonline.FillType = ESAR_Controls.UIControls.Button.eButton.eFillType.Solid
        Me.btnrestoreonline.FocalPoints.CenterPtX = 0.4556962!
        Me.btnrestoreonline.FocalPoints.CenterPtY = 0.4!
        Me.btnrestoreonline.FocalPoints.FocusPtX = 0.0!
        Me.btnrestoreonline.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnrestoreonline.FocusPtTracker = DesignerRectTracker2
        Me.btnrestoreonline.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrestoreonline.ForeColor = System.Drawing.Color.Black
        Me.btnrestoreonline.Image = Global.Umbrella.My.Resources.Resources.Restore_Online32
        Me.btnrestoreonline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrestoreonline.ImageIndex = 0
        Me.btnrestoreonline.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnrestoreonline.Location = New System.Drawing.Point(126, 133)
        Me.btnrestoreonline.Name = "btnrestoreonline"
        Me.btnrestoreonline.Size = New System.Drawing.Size(110, 65)
        Me.btnrestoreonline.TabIndex = 79
        Me.btnrestoreonline.Text = "Restore From Online"
        Me.btnrestoreonline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrestoreonline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnrestoreonline.TextShadowShow = False
        '
        'btnrestore
        '
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnrestore.CenterPtTracker = DesignerRectTracker3
        Me.btnrestore.ColorFillSolid = System.Drawing.Color.AliceBlue
        Me.btnrestore.Corners.All = CType(-1, Short)
        Me.btnrestore.Corners.LowerLeft = CType(20, Short)
        Me.btnrestore.Corners.LowerRight = CType(12, Short)
        Me.btnrestore.Corners.UpperLeft = CType(12, Short)
        Me.btnrestore.Corners.UpperRight = CType(20, Short)
        Me.btnrestore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrestore.FillType = ESAR_Controls.UIControls.Button.eButton.eFillType.Solid
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnrestore.FocusPtTracker = DesignerRectTracker4
        Me.btnrestore.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrestore.ForeColor = System.Drawing.Color.Black
        Me.btnrestore.Image = Global.Umbrella.My.Resources.Resources.Restore32
        Me.btnrestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrestore.ImageIndex = 0
        Me.btnrestore.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnrestore.Location = New System.Drawing.Point(10, 133)
        Me.btnrestore.Name = "btnrestore"
        Me.btnrestore.Size = New System.Drawing.Size(110, 65)
        Me.btnrestore.TabIndex = 78
        Me.btnrestore.Text = "Restore"
        Me.btnrestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnrestore.TextShadowShow = False
        '
        'btnbackuponline
        '
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnbackuponline.CenterPtTracker = DesignerRectTracker5
        Me.btnbackuponline.ColorFillSolid = System.Drawing.Color.AliceBlue
        Me.btnbackuponline.Corners.All = CType(-1, Short)
        Me.btnbackuponline.Corners.LowerLeft = CType(20, Short)
        Me.btnbackuponline.Corners.LowerRight = CType(12, Short)
        Me.btnbackuponline.Corners.UpperLeft = CType(12, Short)
        Me.btnbackuponline.Corners.UpperRight = CType(20, Short)
        Me.btnbackuponline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbackuponline.FillType = ESAR_Controls.UIControls.Button.eButton.eFillType.Solid
        Me.btnbackuponline.FocalPoints.CenterPtX = 0.4908257!
        Me.btnbackuponline.FocalPoints.CenterPtY = 0.525!
        Me.btnbackuponline.FocalPoints.FocusPtX = 0.0!
        Me.btnbackuponline.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnbackuponline.FocusPtTracker = DesignerRectTracker6
        Me.btnbackuponline.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbackuponline.ForeColor = System.Drawing.Color.Black
        Me.btnbackuponline.Image = Global.Umbrella.My.Resources.Resources.Backup_Online32
        Me.btnbackuponline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbackuponline.ImageIndex = 0
        Me.btnbackuponline.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnbackuponline.Location = New System.Drawing.Point(126, 25)
        Me.btnbackuponline.Name = "btnbackuponline"
        Me.btnbackuponline.Size = New System.Drawing.Size(110, 65)
        Me.btnbackuponline.TabIndex = 77
        Me.btnbackuponline.Text = "Backup Online"
        Me.btnbackuponline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbackuponline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnbackuponline.TextShadowShow = False
        '
        'btnbackup
        '
        DesignerRectTracker7.IsActive = False
        DesignerRectTracker7.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker7.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnbackup.CenterPtTracker = DesignerRectTracker7
        Me.btnbackup.ColorFillSolid = System.Drawing.Color.AliceBlue
        Me.btnbackup.Corners.All = CType(-1, Short)
        Me.btnbackup.Corners.LowerLeft = CType(20, Short)
        Me.btnbackup.Corners.LowerRight = CType(12, Short)
        Me.btnbackup.Corners.UpperLeft = CType(12, Short)
        Me.btnbackup.Corners.UpperRight = CType(20, Short)
        Me.btnbackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbackup.FillType = ESAR_Controls.UIControls.Button.eButton.eFillType.Solid
        Me.btnbackup.FocalPoints.CenterPtX = 0.4770642!
        Me.btnbackup.FocalPoints.CenterPtY = 0.5!
        Me.btnbackup.FocalPoints.FocusPtX = 0.0!
        Me.btnbackup.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker8.IsActive = False
        DesignerRectTracker8.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker8.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnbackup.FocusPtTracker = DesignerRectTracker8
        Me.btnbackup.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbackup.ForeColor = System.Drawing.Color.Black
        Me.btnbackup.Image = Global.Umbrella.My.Resources.Resources.Backup32
        Me.btnbackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbackup.ImageIndex = 0
        Me.btnbackup.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnbackup.Location = New System.Drawing.Point(10, 25)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.Size = New System.Drawing.Size(110, 65)
        Me.btnbackup.TabIndex = 76
        Me.btnbackup.Text = "Backup"
        Me.btnbackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnbackup.TextShadowShow = False
        '
        'Grouper1
        '
        Me.Grouper1.BackgroundColor = System.Drawing.Color.White
        Me.Grouper1.BackgroundGradientColor = System.Drawing.Color.White
        Me.Grouper1.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.Grouper1.BorderColor = System.Drawing.Color.Black
        Me.Grouper1.BorderThickness = 1.0!
        Me.Grouper1.Controls.Add(Me.Panel1)
        Me.Grouper1.Controls.Add(Me.XpProgressBar1)
        Me.Grouper1.CustomGroupBoxColor = System.Drawing.Color.White
        Me.Grouper1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grouper1.GroupImage = Global.Umbrella.My.Resources.Resources.backup_restore_icon
        Me.Grouper1.GroupTitle = "Available Data to Backup/ Restore:"
        Me.Grouper1.Location = New System.Drawing.Point(5, 5)
        Me.Grouper1.Name = "Grouper1"
        Me.Grouper1.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.Grouper1.PaintGroupBox = False
        Me.Grouper1.RoundCorners = 10
        Me.Grouper1.ShadowColor = System.Drawing.Color.DarkGray
        Me.Grouper1.ShadowControl = False
        Me.Grouper1.ShadowThickness = 3
        Me.Grouper1.Size = New System.Drawing.Size(488, 407)
        Me.Grouper1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgviewtables)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.Panel1.Size = New System.Drawing.Size(468, 347)
        Me.Panel1.TabIndex = 11
        '
        'dgviewtables
        '
        Me.dgviewtables.AllowUserToAddRows = False
        Me.dgviewtables.AllowUserToDeleteRows = False
        Me.dgviewtables.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgviewtables.BackgroundColor = System.Drawing.Color.White
        Me.dgviewtables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgviewtables.ColumnHeadersVisible = False
        Me.dgviewtables.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewtables.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgviewtables.DisplaySumRowHeader = False
        Me.dgviewtables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewtables.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgviewtables.Location = New System.Drawing.Point(0, 5)
        Me.dgviewtables.Name = "dgviewtables"
        Me.dgviewtables.ReadOnly = True
        Me.dgviewtables.RowHeadersVisible = False
        Me.dgviewtables.Size = New System.Drawing.Size(468, 337)
        Me.dgviewtables.SummaryColumns = Nothing
        Me.dgviewtables.SummaryRowBackColor = System.Drawing.Color.Empty
        Me.dgviewtables.SummaryRowSpace = 0
        Me.dgviewtables.SummaryRowVisible = False
        Me.dgviewtables.SumRowHeaderText = Nothing
        Me.dgviewtables.SumRowHeaderTextBold = False
        Me.dgviewtables.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "Select"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 40
        '
        'Column2
        '
        Me.Column2.HeaderText = "Value"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 423
        '
        'XpProgressBar1
        '
        Me.XpProgressBar1.ColorBackGround = System.Drawing.Color.White
        Me.XpProgressBar1.ColorBarBorder = System.Drawing.Color.White
        Me.XpProgressBar1.ColorBarCenter = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.XpProgressBar1.ColorText = System.Drawing.Color.Black
        Me.XpProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.XpProgressBar1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XpProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.XpProgressBar1.GradientStyle = ESAR_Controls.UIControls.ProgressBar.GradientMode.HorizontalCenter
        Me.XpProgressBar1.Location = New System.Drawing.Point(10, 372)
        Me.XpProgressBar1.Name = "XpProgressBar1"
        Me.XpProgressBar1.Position = 0
        Me.XpProgressBar1.PositionMax = 100
        Me.XpProgressBar1.PositionMin = 0
        Me.XpProgressBar1.Size = New System.Drawing.Size(468, 25)
        Me.XpProgressBar1.TabIndex = 10
        Me.XpProgressBar1.Text = "0 %"
        Me.XpProgressBar1.TextShadow = False
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.RoundedPanel1.BorderRadius = 32
        Me.RoundedPanel1.Controls.Add(Me.btnhelp)
        Me.RoundedPanel1.Controls.Add(Me.ELabel1)
        Me.RoundedPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RoundedPanel1.Location = New System.Drawing.Point(10, 10)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.RoundedPanel1.Size = New System.Drawing.Size(747, 60)
        Me.RoundedPanel1.TabIndex = 13
        '
        'btnhelp
        '
        DesignerRectTracker9.IsActive = False
        DesignerRectTracker9.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker9.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnhelp.CenterPtTracker = DesignerRectTracker9
        Me.btnhelp.ColorFillSolid = System.Drawing.Color.White
        Me.btnhelp.Corners.All = CType(-1, Short)
        Me.btnhelp.Corners.LowerLeft = CType(20, Short)
        Me.btnhelp.Corners.LowerRight = CType(12, Short)
        Me.btnhelp.Corners.UpperLeft = CType(12, Short)
        Me.btnhelp.Corners.UpperRight = CType(20, Short)
        Me.btnhelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhelp.Dock = System.Windows.Forms.DockStyle.Left
        DesignerRectTracker10.IsActive = False
        DesignerRectTracker10.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker10.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnhelp.FocusPtTracker = DesignerRectTracker10
        Me.btnhelp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhelp.Image = Global.Umbrella.My.Resources.Resources.help
        Me.btnhelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhelp.ImageIndex = 0
        Me.btnhelp.Location = New System.Drawing.Point(10, 10)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(63, 40)
        Me.btnhelp.TabIndex = 77
        Me.btnhelp.Text = "Help"
        Me.btnhelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhelp.TextShadowShow = False
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
        Me.ELabel1.Location = New System.Drawing.Point(587, 10)
        Me.ELabel1.MouseOverColor = System.Drawing.Color.Gray
        Me.ELabel1.Name = "ELabel1"
        Me.ELabel1.ShadowState = True
        Me.ELabel1.Size = New System.Drawing.Size(150, 40)
        Me.ELabel1.TabIndex = 35
        Me.ELabel1.Text = "Backup/ Restore"
        '
        'frmBackupRestore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(767, 492)
        Me.Controls.Add(Me.GradientPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.Custom
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBackupRestore"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup/ Restore"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GradientPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.RoundedPanel2.ResumeLayout(False)
        Me.Grouper1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgviewtables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents RoundedPanel2 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents Grouper1 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents XpProgressBar1 As ESAR_Controls.UIControls.ProgressBar.eXpProgressBar
    Friend WithEvents RoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents ELabel1 As ESAR_Controls.eLabel
    Friend WithEvents btnhelp As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnrestoreonline As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnrestore As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnbackuponline As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnbackup As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgviewtables As ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
