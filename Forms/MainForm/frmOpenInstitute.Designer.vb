Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpenInstitute
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpenInstitute))
        Dim DesignerRectTracker2 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker3 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker4 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker5 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker6 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.EGradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.RoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.btnhelp = New ESAR_Controls.UIControls.Button.eButton
        Me.btnclose = New ESAR_Controls.UIControls.Button.eButton
        Me.btnopen = New ESAR_Controls.UIControls.Button.eButton
        Me.lblselected = New ESAR_Controls.eLabel
        Me.dgviewinstitute = New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
        Me.clminsname = New System.Windows.Forms.DataGridViewLinkColumn
        Me.EGradientPanel1.SuspendLayout()
        Me.RoundedPanel1.SuspendLayout()
        CType(Me.dgviewinstitute, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel1.Size = New System.Drawing.Size(338, 255)
        Me.Panel1.TabIndex = 0
        '
        'EGradientPanel1
        '
        Me.EGradientPanel1.Controls.Add(Me.RoundedPanel1)
        Me.EGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGradientPanel1.EndColor = System.Drawing.Color.RoyalBlue
        Me.EGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.EGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EGradientPanel1.Name = "EGradientPanel1"
        Me.EGradientPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.EGradientPanel1.Size = New System.Drawing.Size(338, 255)
        Me.EGradientPanel1.StartColor = System.Drawing.Color.LightCyan
        Me.EGradientPanel1.TabIndex = 1
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.RoundedPanel1.BorderRadius = 32
        Me.RoundedPanel1.Controls.Add(Me.btnhelp)
        Me.RoundedPanel1.Controls.Add(Me.btnclose)
        Me.RoundedPanel1.Controls.Add(Me.btnopen)
        Me.RoundedPanel1.Controls.Add(Me.lblselected)
        Me.RoundedPanel1.Controls.Add(Me.dgviewinstitute)
        Me.RoundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RoundedPanel1.Location = New System.Drawing.Point(10, 10)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Size = New System.Drawing.Size(318, 235)
        Me.RoundedPanel1.TabIndex = 1
        '
        'btnhelp
        '
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnhelp.CenterPtTracker = DesignerRectTracker1
        Me.btnhelp.ColorFillSolid = System.Drawing.Color.AliceBlue
        Me.btnhelp.Corners.All = CType(-1, Short)
        Me.btnhelp.Corners.LowerLeft = CType(12, Short)
        Me.btnhelp.Corners.LowerRight = CType(6, Short)
        Me.btnhelp.Corners.UpperLeft = CType(6, Short)
        Me.btnhelp.Corners.UpperRight = CType(12, Short)
        Me.btnhelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhelp.FillType = ESAR_Controls.UIControls.Button.eButton.eFillType.Solid
        Me.btnhelp.FocalPoints.CenterPtX = 1.0!
        Me.btnhelp.FocalPoints.CenterPtY = 0.52!
        Me.btnhelp.FocalPoints.FocusPtX = 0.0!
        Me.btnhelp.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnhelp.FocusPtTracker = DesignerRectTracker2
        Me.btnhelp.ForeColor = System.Drawing.Color.Black
        Me.btnhelp.Image = Global.Umbrella.My.Resources.Resources.help
        Me.btnhelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhelp.ImageIndex = 0
        Me.btnhelp.Location = New System.Drawing.Point(230, 94)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(69, 25)
        Me.btnhelp.TabIndex = 17
        Me.btnhelp.Text = "Help"
        Me.btnhelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhelp.TextShadowShow = False
        '
        'btnclose
        '
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnclose.CenterPtTracker = DesignerRectTracker3
        Me.btnclose.ColorFillSolid = System.Drawing.Color.AliceBlue
        Me.btnclose.Corners.All = CType(-1, Short)
        Me.btnclose.Corners.LowerLeft = CType(12, Short)
        Me.btnclose.Corners.LowerRight = CType(6, Short)
        Me.btnclose.Corners.UpperLeft = CType(6, Short)
        Me.btnclose.Corners.UpperRight = CType(12, Short)
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnclose.FillType = ESAR_Controls.UIControls.Button.eButton.eFillType.Solid
        Me.btnclose.FocalPoints.CenterPtX = 0.5217391!
        Me.btnclose.FocalPoints.CenterPtY = 0.52!
        Me.btnclose.FocalPoints.FocusPtX = 0.0!
        Me.btnclose.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnclose.FocusPtTracker = DesignerRectTracker4
        Me.btnclose.ForeColor = System.Drawing.Color.Black
        Me.btnclose.Image = Global.Umbrella.My.Resources.Resources.close
        Me.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclose.ImageIndex = 0
        Me.btnclose.Location = New System.Drawing.Point(230, 63)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(69, 25)
        Me.btnclose.TabIndex = 16
        Me.btnclose.Text = "Close"
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnclose.TextShadowShow = False
        '
        'btnopen
        '
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnopen.CenterPtTracker = DesignerRectTracker5
        Me.btnopen.ColorFillSolid = System.Drawing.Color.AliceBlue
        Me.btnopen.Corners.All = CType(-1, Short)
        Me.btnopen.Corners.LowerLeft = CType(12, Short)
        Me.btnopen.Corners.LowerRight = CType(6, Short)
        Me.btnopen.Corners.UpperLeft = CType(6, Short)
        Me.btnopen.Corners.UpperRight = CType(12, Short)
        Me.btnopen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnopen.FillType = ESAR_Controls.UIControls.Button.eButton.eFillType.Solid
        Me.btnopen.FocalPoints.CenterPtX = 0.5217391!
        Me.btnopen.FocalPoints.CenterPtY = 0.52!
        Me.btnopen.FocalPoints.FocusPtX = 0.0!
        Me.btnopen.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnopen.FocusPtTracker = DesignerRectTracker6
        Me.btnopen.ForeColor = System.Drawing.Color.Black
        Me.btnopen.Image = Global.Umbrella.My.Resources.Resources.open
        Me.btnopen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnopen.ImageIndex = 0
        Me.btnopen.Location = New System.Drawing.Point(230, 32)
        Me.btnopen.Name = "btnopen"
        Me.btnopen.Size = New System.Drawing.Size(69, 25)
        Me.btnopen.TabIndex = 15
        Me.btnopen.Text = "Open"
        Me.btnopen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnopen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnopen.TextShadowShow = False
        '
        'lblselected
        '
        Me.lblselected.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblselected.ForeColor = System.Drawing.Color.Black
        Me.lblselected.Glow = 6
        Me.lblselected.Location = New System.Drawing.Point(10, 161)
        Me.lblselected.Name = "lblselected"
        Me.lblselected.Size = New System.Drawing.Size(289, 59)
        Me.lblselected.TabIndex = 14
        Me.lblselected.Text = "Selected Institute:"
        Me.lblselected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgviewinstitute
        '
        Me.dgviewinstitute.AllowUserToAddRows = False
        Me.dgviewinstitute.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgviewinstitute.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgviewinstitute.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgviewinstitute.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgviewinstitute.BackgroundColor = System.Drawing.Color.White
        Me.dgviewinstitute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgviewinstitute.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clminsname})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewinstitute.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgviewinstitute.DisplaySumRowHeader = False
        Me.dgviewinstitute.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgviewinstitute.Location = New System.Drawing.Point(10, 10)
        Me.dgviewinstitute.MultiSelect = False
        Me.dgviewinstitute.Name = "dgviewinstitute"
        Me.dgviewinstitute.ReadOnly = True
        Me.dgviewinstitute.RowHeadersVisible = False
        Me.dgviewinstitute.Size = New System.Drawing.Size(199, 139)
        Me.dgviewinstitute.SummaryColumns = Nothing
        Me.dgviewinstitute.SummaryRowBackColor = System.Drawing.Color.Empty
        Me.dgviewinstitute.SummaryRowSpace = 0
        Me.dgviewinstitute.SummaryRowVisible = False
        Me.dgviewinstitute.SumRowHeaderText = Nothing
        Me.dgviewinstitute.SumRowHeaderTextBold = False
        Me.dgviewinstitute.TabIndex = 10
        '
        'clminsname
        '
        Me.clminsname.HeaderText = "Open Your Institute"
        Me.clminsname.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.clminsname.LinkColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.clminsname.Name = "clminsname"
        Me.clminsname.ReadOnly = True
        Me.clminsname.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clminsname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clminsname.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'frmOpenInstitute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(338, 255)
        Me.ControlBox = False
        Me.Controls.Add(Me.EGradientPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.Custom
        Me.Name = "frmOpenInstitute"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.EGradientPanel1.ResumeLayout(False)
        Me.RoundedPanel1.ResumeLayout(False)
        CType(Me.dgviewinstitute, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents EGradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents RoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents btnhelp As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnclose As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnopen As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents lblselected As ESAR_Controls.eLabel
    Friend WithEvents dgviewinstitute As ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
    Friend WithEvents clminsname As System.Windows.Forms.DataGridViewLinkColumn
End Class
