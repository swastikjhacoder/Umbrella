Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainTask
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainTask))
        Dim DesignerRectTracker2 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker3 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker4 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Me.EGradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.RoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lnkonlinetutorial = New System.Windows.Forms.LinkLabel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnopen = New ESAR_Controls.UIControls.Button.eButton
        Me.btncreate = New ESAR_Controls.UIControls.Button.eButton
        Me.EGradientPanel1.SuspendLayout()
        Me.RoundedPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.EGradientPanel1.TabIndex = 0
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.RoundedPanel1.BorderRadius = 32
        Me.RoundedPanel1.Controls.Add(Me.GroupBox1)
        Me.RoundedPanel1.Controls.Add(Me.GroupBox2)
        Me.RoundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RoundedPanel1.Location = New System.Drawing.Point(10, 10)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.RoundedPanel1.Size = New System.Drawing.Size(318, 235)
        Me.RoundedPanel1.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lnkonlinetutorial)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(10, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(10, 5, 10, 10)
        Me.GroupBox1.Size = New System.Drawing.Size(298, 76)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Other Task:"
        '
        'lnkonlinetutorial
        '
        Me.lnkonlinetutorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lnkonlinetutorial.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkonlinetutorial.Image = Global.Umbrella.My.Resources.Resources.file_pdf
        Me.lnkonlinetutorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkonlinetutorial.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkonlinetutorial.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkonlinetutorial.Location = New System.Drawing.Point(10, 19)
        Me.lnkonlinetutorial.Name = "lnkonlinetutorial"
        Me.lnkonlinetutorial.Size = New System.Drawing.Size(278, 47)
        Me.lnkonlinetutorial.TabIndex = 0
        Me.lnkonlinetutorial.TabStop = True
        Me.lnkonlinetutorial.Text = "         Umbrella Online Tutorial"
        Me.lnkonlinetutorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnopen)
        Me.GroupBox2.Controls.Add(Me.btncreate)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(298, 139)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tasks:"
        '
        'btnopen
        '
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnopen.CenterPtTracker = DesignerRectTracker1
        Me.btnopen.ColorFillSolid = System.Drawing.Color.AliceBlue
        Me.btnopen.Corners.All = CType(-1, Short)
        Me.btnopen.Corners.LowerLeft = CType(25, Short)
        Me.btnopen.Corners.LowerRight = CType(12, Short)
        Me.btnopen.Corners.UpperLeft = CType(12, Short)
        Me.btnopen.Corners.UpperRight = CType(25, Short)
        Me.btnopen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnopen.FillType = ESAR_Controls.UIControls.Button.eButton.eFillType.Solid
        Me.btnopen.FocalPoints.CenterPtX = 0.5!
        Me.btnopen.FocalPoints.CenterPtY = 0.4339623!
        Me.btnopen.FocalPoints.FocusPtX = 0.0!
        Me.btnopen.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnopen.FocusPtTracker = DesignerRectTracker2
        Me.btnopen.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnopen.ForeColor = System.Drawing.Color.Black
        Me.btnopen.Image = Global.Umbrella.My.Resources.Resources.open
        Me.btnopen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnopen.ImageIndex = 0
        Me.btnopen.Location = New System.Drawing.Point(10, 21)
        Me.btnopen.Name = "btnopen"
        Me.btnopen.SideImageSize = New System.Drawing.Size(32, 32)
        Me.btnopen.Size = New System.Drawing.Size(278, 47)
        Me.btnopen.TabIndex = 15
        Me.btnopen.Text = "Open Your Institution"
        Me.btnopen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnopen.TextShadowShow = False
        '
        'btncreate
        '
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btncreate.CenterPtTracker = DesignerRectTracker3
        Me.btncreate.ColorFillSolid = System.Drawing.Color.AliceBlue
        Me.btncreate.Corners.All = CType(-1, Short)
        Me.btncreate.Corners.LowerLeft = CType(25, Short)
        Me.btncreate.Corners.LowerRight = CType(12, Short)
        Me.btncreate.Corners.UpperLeft = CType(12, Short)
        Me.btncreate.Corners.UpperRight = CType(25, Short)
        Me.btncreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncreate.FillType = ESAR_Controls.UIControls.Button.eButton.eFillType.Solid
        Me.btncreate.FocalPoints.CenterPtX = 0.4895105!
        Me.btncreate.FocalPoints.CenterPtY = 0.5319149!
        Me.btncreate.FocalPoints.FocusPtX = 0.0!
        Me.btncreate.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btncreate.FocusPtTracker = DesignerRectTracker4
        Me.btncreate.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncreate.ForeColor = System.Drawing.Color.Black
        Me.btncreate.Image = Global.Umbrella.My.Resources.Resources.Umbrella_icon
        Me.btncreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncreate.ImageIndex = 0
        Me.btncreate.Location = New System.Drawing.Point(10, 80)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.SideImageSize = New System.Drawing.Size(25, 25)
        Me.btncreate.Size = New System.Drawing.Size(278, 47)
        Me.btncreate.TabIndex = 16
        Me.btncreate.Text = "Create Your Institution"
        Me.btncreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncreate.TextShadowShow = False
        '
        'frmMainTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(338, 255)
        Me.ControlBox = False
        Me.Controls.Add(Me.EGradientPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.Custom
        Me.Name = "frmMainTask"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.EGradientPanel1.ResumeLayout(False)
        Me.RoundedPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EGradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents RoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnopen As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btncreate As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents lnkonlinetutorial As System.Windows.Forms.LinkLabel
End Class
