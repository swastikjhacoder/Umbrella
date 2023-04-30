Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountingPeriod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccountingPeriod))
        Dim DesignerRectTracker2 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker3 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker4 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim CBlendItems1 As ESAR_Controls.cBlendItems = New ESAR_Controls.cBlendItems
        Me.EGradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ERoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.lstfinancialperiod = New System.Windows.Forms.ListBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.EGroupBox3 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.lstpayrolltaxyears = New System.Windows.Forms.ListBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.EGroupBox2 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.lstfiscalyears = New System.Windows.Forms.ListBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.EGroupBox1 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.lblperiodvalues = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ERoundedPanel2 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.ERoundedPanel6 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.btnhelp = New ESAR_Controls.UIControls.Button.eButton
        Me.btnok = New ESAR_Controls.UIControls.Button.eButton
        Me.ELabel6 = New ESAR_Controls.eLabel
        Me.EGradientPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ERoundedPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.EGroupBox3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.EGroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.EGroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ERoundedPanel2.SuspendLayout()
        Me.ERoundedPanel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'EGradientPanel1
        '
        Me.EGradientPanel1.Controls.Add(Me.SplitContainer1)
        Me.EGradientPanel1.Controls.Add(Me.Panel1)
        Me.EGradientPanel1.Controls.Add(Me.ERoundedPanel6)
        Me.EGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGradientPanel1.EndColor = System.Drawing.Color.RoyalBlue
        Me.EGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.EGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EGradientPanel1.Name = "EGradientPanel1"
        Me.EGradientPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.EGradientPanel1.Size = New System.Drawing.Size(602, 389)
        Me.EGradientPanel1.StartColor = System.Drawing.Color.LightCyan
        Me.EGradientPanel1.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(10, 126)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ERoundedPanel1)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.SplitContainer1.Size = New System.Drawing.Size(582, 253)
        Me.SplitContainer1.SplitterDistance = 253
        Me.SplitContainer1.TabIndex = 27
        '
        'ERoundedPanel1
        '
        Me.ERoundedPanel1.BackColor = System.Drawing.Color.White
        Me.ERoundedPanel1.BorderRadius = 32
        Me.ERoundedPanel1.Controls.Add(Me.lstfinancialperiod)
        Me.ERoundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel1.Location = New System.Drawing.Point(0, 5)
        Me.ERoundedPanel1.Name = "ERoundedPanel1"
        Me.ERoundedPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.ERoundedPanel1.Size = New System.Drawing.Size(253, 248)
        Me.ERoundedPanel1.TabIndex = 0
        '
        'lstfinancialperiod
        '
        Me.lstfinancialperiod.BackColor = System.Drawing.Color.White
        Me.lstfinancialperiod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstfinancialperiod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstfinancialperiod.FormattingEnabled = True
        Me.lstfinancialperiod.Location = New System.Drawing.Point(10, 10)
        Me.lstfinancialperiod.Name = "lstfinancialperiod"
        Me.lstfinancialperiod.Size = New System.Drawing.Size(233, 221)
        Me.lstfinancialperiod.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.EGroupBox3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 174)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel4.Size = New System.Drawing.Size(325, 79)
        Me.Panel4.TabIndex = 2
        '
        'EGroupBox3
        '
        Me.EGroupBox3.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox3.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox3.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox3.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox3.BorderThickness = 1.0!
        Me.EGroupBox3.Controls.Add(Me.lstpayrolltaxyears)
        Me.EGroupBox3.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox3.GroupImage = Nothing
        Me.EGroupBox3.GroupTitle = "Open Payroll Tax Years:"
        Me.EGroupBox3.Location = New System.Drawing.Point(0, 5)
        Me.EGroupBox3.Name = "EGroupBox3"
        Me.EGroupBox3.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.EGroupBox3.PaintGroupBox = False
        Me.EGroupBox3.RoundCorners = 10
        Me.EGroupBox3.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox3.ShadowControl = False
        Me.EGroupBox3.ShadowThickness = 3
        Me.EGroupBox3.Size = New System.Drawing.Size(325, 74)
        Me.EGroupBox3.TabIndex = 0
        '
        'lstpayrolltaxyears
        '
        Me.lstpayrolltaxyears.BackColor = System.Drawing.Color.White
        Me.lstpayrolltaxyears.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstpayrolltaxyears.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstpayrolltaxyears.FormattingEnabled = True
        Me.lstpayrolltaxyears.Location = New System.Drawing.Point(10, 25)
        Me.lstpayrolltaxyears.Name = "lstpayrolltaxyears"
        Me.lstpayrolltaxyears.Size = New System.Drawing.Size(305, 39)
        Me.lstpayrolltaxyears.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.EGroupBox2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 85)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel3.Size = New System.Drawing.Size(325, 89)
        Me.Panel3.TabIndex = 1
        '
        'EGroupBox2
        '
        Me.EGroupBox2.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox2.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox2.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox2.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox2.BorderThickness = 1.0!
        Me.EGroupBox2.Controls.Add(Me.lstfiscalyears)
        Me.EGroupBox2.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox2.GroupImage = Nothing
        Me.EGroupBox2.GroupTitle = "Open Fiscal Years:"
        Me.EGroupBox2.Location = New System.Drawing.Point(0, 5)
        Me.EGroupBox2.Name = "EGroupBox2"
        Me.EGroupBox2.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.EGroupBox2.PaintGroupBox = False
        Me.EGroupBox2.RoundCorners = 10
        Me.EGroupBox2.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox2.ShadowControl = False
        Me.EGroupBox2.ShadowThickness = 3
        Me.EGroupBox2.Size = New System.Drawing.Size(325, 84)
        Me.EGroupBox2.TabIndex = 0
        '
        'lstfiscalyears
        '
        Me.lstfiscalyears.BackColor = System.Drawing.Color.White
        Me.lstfiscalyears.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstfiscalyears.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstfiscalyears.FormattingEnabled = True
        Me.lstfiscalyears.Location = New System.Drawing.Point(10, 25)
        Me.lstfiscalyears.Name = "lstfiscalyears"
        Me.lstfiscalyears.Size = New System.Drawing.Size(305, 39)
        Me.lstfiscalyears.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.EGroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(325, 80)
        Me.Panel2.TabIndex = 0
        '
        'EGroupBox1
        '
        Me.EGroupBox1.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox1.BorderThickness = 1.0!
        Me.EGroupBox1.Controls.Add(Me.lblperiodvalues)
        Me.EGroupBox1.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox1.GroupImage = Nothing
        Me.EGroupBox1.GroupTitle = "Current Accounting Period:"
        Me.EGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.EGroupBox1.Name = "EGroupBox1"
        Me.EGroupBox1.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.EGroupBox1.PaintGroupBox = False
        Me.EGroupBox1.RoundCorners = 10
        Me.EGroupBox1.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox1.ShadowControl = False
        Me.EGroupBox1.ShadowThickness = 3
        Me.EGroupBox1.Size = New System.Drawing.Size(325, 80)
        Me.EGroupBox1.TabIndex = 0
        '
        'lblperiodvalues
        '
        Me.lblperiodvalues.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblperiodvalues.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblperiodvalues.Location = New System.Drawing.Point(10, 25)
        Me.lblperiodvalues.Name = "lblperiodvalues"
        Me.lblperiodvalues.Size = New System.Drawing.Size(305, 45)
        Me.lblperiodvalues.TabIndex = 3
        Me.lblperiodvalues.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.ERoundedPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(10, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(582, 56)
        Me.Panel1.TabIndex = 26
        '
        'ERoundedPanel2
        '
        Me.ERoundedPanel2.BackColor = System.Drawing.Color.White
        Me.ERoundedPanel2.BorderRadius = 32
        Me.ERoundedPanel2.Controls.Add(Me.Label1)
        Me.ERoundedPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel2.Location = New System.Drawing.Point(0, 5)
        Me.ERoundedPanel2.Name = "ERoundedPanel2"
        Me.ERoundedPanel2.Padding = New System.Windows.Forms.Padding(10)
        Me.ERoundedPanel2.Size = New System.Drawing.Size(582, 51)
        Me.ERoundedPanel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(562, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "To change your current accounting period, from the list select the period you wan" & _
            "t to operate in. Moving forward, you should do this at the begining of each new " & _
            "accounting period. "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ERoundedPanel6
        '
        Me.ERoundedPanel6.BackColor = System.Drawing.Color.Transparent
        Me.ERoundedPanel6.BorderRadius = 32
        Me.ERoundedPanel6.Controls.Add(Me.btnhelp)
        Me.ERoundedPanel6.Controls.Add(Me.btnok)
        Me.ERoundedPanel6.Controls.Add(Me.ELabel6)
        Me.ERoundedPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.ERoundedPanel6.Location = New System.Drawing.Point(10, 10)
        Me.ERoundedPanel6.Name = "ERoundedPanel6"
        Me.ERoundedPanel6.Padding = New System.Windows.Forms.Padding(10)
        Me.ERoundedPanel6.Size = New System.Drawing.Size(582, 60)
        Me.ERoundedPanel6.TabIndex = 25
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
        Me.btnhelp.Location = New System.Drawing.Point(61, 10)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(63, 40)
        Me.btnhelp.TabIndex = 83
        Me.btnhelp.Text = "Help"
        Me.btnhelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhelp.TextShadowShow = False
        '
        'btnok
        '
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnok.CenterPtTracker = DesignerRectTracker3
        Me.btnok.ColorFillSolid = System.Drawing.Color.White
        Me.btnok.Corners.All = CType(-1, Short)
        Me.btnok.Corners.LowerLeft = CType(20, Short)
        Me.btnok.Corners.LowerRight = CType(12, Short)
        Me.btnok.Corners.UpperLeft = CType(12, Short)
        Me.btnok.Corners.UpperRight = CType(20, Short)
        Me.btnok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnok.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnok.FocalPoints.CenterPtX = 0.4313726!
        Me.btnok.FocalPoints.CenterPtY = 0.45!
        Me.btnok.FocalPoints.FocusPtX = 0.0!
        Me.btnok.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnok.FocusPtTracker = DesignerRectTracker4
        Me.btnok.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.Image = Global.Umbrella.My.Resources.Resources.ok
        Me.btnok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnok.ImageIndex = 0
        Me.btnok.Location = New System.Drawing.Point(10, 10)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(51, 40)
        Me.btnok.TabIndex = 79
        Me.btnok.Text = "Ok"
        Me.btnok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnok.TextShadowShow = False
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
        Me.ELabel6.Location = New System.Drawing.Point(270, 10)
        Me.ELabel6.MouseOverColor = System.Drawing.Color.Gray
        Me.ELabel6.Name = "ELabel6"
        Me.ELabel6.ShadowState = True
        Me.ELabel6.Size = New System.Drawing.Size(302, 40)
        Me.ELabel6.TabIndex = 34
        Me.ELabel6.Text = "Change Your Accounting Period"
        '
        'frmAccountingPeriod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(602, 389)
        Me.Controls.Add(Me.EGradientPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.RoyalLight
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAccountingPeriod"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Accounting Period"
        Me.EGradientPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ERoundedPanel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.EGroupBox3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.EGroupBox2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.EGroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ERoundedPanel2.ResumeLayout(False)
        Me.ERoundedPanel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EGradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents ERoundedPanel6 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents btnhelp As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnok As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents ELabel6 As ESAR_Controls.eLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ERoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents EGroupBox3 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents lstpayrolltaxyears As System.Windows.Forms.ListBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents EGroupBox2 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents lstfiscalyears As System.Windows.Forms.ListBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents EGroupBox1 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents lblperiodvalues As System.Windows.Forms.Label
    Friend WithEvents lstfinancialperiod As System.Windows.Forms.ListBox
    Friend WithEvents ERoundedPanel2 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
