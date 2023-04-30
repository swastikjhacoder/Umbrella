Imports Umbrella.UIControls
Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayCalculationThisMonth
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayCalculationThisMonth))
        Dim DesignerRectTracker2 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker3 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker4 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim CBlendItems1 As ESAR_Controls.cBlendItems = New ESAR_Controls.cBlendItems
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.EGradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ERoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.EGroupBox1 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.EVistaProgressBar1 = New ESAR_Controls.UIControls.ProgressBar.eVistaProgressBar
        Me.cmbdesignation = New ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbmonth = New System.Windows.Forms.ComboBox
        Me.nudyear = New System.Windows.Forms.NumericUpDown
        Me.label1 = New System.Windows.Forms.Label
        Me.RoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.btnhelp = New ESAR_Controls.UIControls.Button.eButton
        Me.btnpreceed = New ESAR_Controls.UIControls.Button.eButton
        Me.ELabel1 = New ESAR_Controls.eLabel
        Me.EGradientPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ERoundedPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.EGroupBox1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.nudyear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'EGradientPanel1
        '
        Me.EGradientPanel1.Controls.Add(Me.Panel1)
        Me.EGradientPanel1.Controls.Add(Me.RoundedPanel1)
        Me.EGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGradientPanel1.EndColor = System.Drawing.Color.RoyalBlue
        Me.EGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.EGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EGradientPanel1.Name = "EGradientPanel1"
        Me.EGradientPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.EGradientPanel1.Size = New System.Drawing.Size(839, 556)
        Me.EGradientPanel1.StartColor = System.Drawing.Color.LightCyan
        Me.EGradientPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.ERoundedPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(10, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(819, 170)
        Me.Panel1.TabIndex = 27
        '
        'ERoundedPanel1
        '
        Me.ERoundedPanel1.BackColor = System.Drawing.Color.White
        Me.ERoundedPanel1.BorderRadius = 32
        Me.ERoundedPanel1.Controls.Add(Me.Panel2)
        Me.ERoundedPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ERoundedPanel1.Location = New System.Drawing.Point(0, 5)
        Me.ERoundedPanel1.Name = "ERoundedPanel1"
        Me.ERoundedPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.ERoundedPanel1.Size = New System.Drawing.Size(367, 165)
        Me.ERoundedPanel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.groupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(10, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(347, 145)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.EGroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 53)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.Panel3.Size = New System.Drawing.Size(347, 92)
        Me.Panel3.TabIndex = 15
        '
        'EGroupBox1
        '
        Me.EGroupBox1.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox1.BorderThickness = 1.0!
        Me.EGroupBox1.Controls.Add(Me.EVistaProgressBar1)
        Me.EGroupBox1.Controls.Add(Me.cmbdesignation)
        Me.EGroupBox1.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox1.GroupImage = Nothing
        Me.EGroupBox1.GroupTitle = "Payslip For:"
        Me.EGroupBox1.Location = New System.Drawing.Point(0, 5)
        Me.EGroupBox1.Name = "EGroupBox1"
        Me.EGroupBox1.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.EGroupBox1.PaintGroupBox = False
        Me.EGroupBox1.RoundCorners = 10
        Me.EGroupBox1.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox1.ShadowControl = False
        Me.EGroupBox1.ShadowThickness = 3
        Me.EGroupBox1.Size = New System.Drawing.Size(347, 82)
        Me.EGroupBox1.TabIndex = 17
        '
        'EVistaProgressBar1
        '
        Me.EVistaProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.EVistaProgressBar1.DisplayText = ""
        Me.EVistaProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.EVistaProgressBar1.Location = New System.Drawing.Point(10, 52)
        Me.EVistaProgressBar1.Name = "EVistaProgressBar1"
        Me.EVistaProgressBar1.ShowPercentage = ESAR_Controls.UIControls.ProgressBar.eVistaProgressBar.TextShowFormats.None
        Me.EVistaProgressBar1.Size = New System.Drawing.Size(327, 20)
        Me.EVistaProgressBar1.TabIndex = 2
        '
        'cmbdesignation
        '
        Me.cmbdesignation.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmbdesignation.FormattingEnabled = True
        Me.cmbdesignation.InstantBinding = True
        Me.cmbdesignation.Location = New System.Drawing.Point(10, 25)
        Me.cmbdesignation.Name = "cmbdesignation"
        Me.cmbdesignation.Size = New System.Drawing.Size(327, 21)
        Me.cmbdesignation.TabIndex = 0
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.Controls.Add(Me.cmbmonth)
        Me.groupBox1.Controls.Add(Me.nudyear)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.groupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(0, 0)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(347, 53)
        Me.groupBox1.TabIndex = 13
        Me.groupBox1.TabStop = False
        '
        'cmbmonth
        '
        Me.cmbmonth.BackColor = System.Drawing.Color.White
        Me.cmbmonth.FormattingEnabled = True
        Me.cmbmonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", " "})
        Me.cmbmonth.Location = New System.Drawing.Point(122, 20)
        Me.cmbmonth.Name = "cmbmonth"
        Me.cmbmonth.Size = New System.Drawing.Size(129, 21)
        Me.cmbmonth.TabIndex = 0
        '
        'nudyear
        '
        Me.nudyear.BackColor = System.Drawing.Color.White
        Me.nudyear.Location = New System.Drawing.Point(261, 21)
        Me.nudyear.Name = "nudyear"
        Me.nudyear.Size = New System.Drawing.Size(59, 21)
        Me.nudyear.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(14, 24)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(94, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "For this month:"
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.RoundedPanel1.BorderRadius = 32
        Me.RoundedPanel1.Controls.Add(Me.btnhelp)
        Me.RoundedPanel1.Controls.Add(Me.btnpreceed)
        Me.RoundedPanel1.Controls.Add(Me.ELabel1)
        Me.RoundedPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RoundedPanel1.Location = New System.Drawing.Point(10, 10)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.RoundedPanel1.Size = New System.Drawing.Size(819, 60)
        Me.RoundedPanel1.TabIndex = 26
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
        Me.btnhelp.Location = New System.Drawing.Point(102, 10)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(63, 40)
        Me.btnhelp.TabIndex = 89
        Me.btnhelp.Text = "Help"
        Me.btnhelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhelp.TextShadowShow = False
        '
        'btnpreceed
        '
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnpreceed.CenterPtTracker = DesignerRectTracker3
        Me.btnpreceed.ColorFillSolid = System.Drawing.Color.White
        Me.btnpreceed.Corners.All = CType(-1, Short)
        Me.btnpreceed.Corners.LowerLeft = CType(20, Short)
        Me.btnpreceed.Corners.LowerRight = CType(12, Short)
        Me.btnpreceed.Corners.UpperLeft = CType(12, Short)
        Me.btnpreceed.Corners.UpperRight = CType(20, Short)
        Me.btnpreceed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpreceed.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnpreceed.FocalPoints.CenterPtX = 0.4444444!
        Me.btnpreceed.FocalPoints.CenterPtY = 0.65!
        Me.btnpreceed.FocalPoints.FocusPtX = 0.0!
        Me.btnpreceed.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnpreceed.FocusPtTracker = DesignerRectTracker4
        Me.btnpreceed.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpreceed.Image = Global.Umbrella.My.Resources.Resources.run_icon
        Me.btnpreceed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpreceed.ImageIndex = 0
        Me.btnpreceed.Location = New System.Drawing.Point(10, 10)
        Me.btnpreceed.Name = "btnpreceed"
        Me.btnpreceed.Size = New System.Drawing.Size(92, 40)
        Me.btnpreceed.TabIndex = 88
        Me.btnpreceed.Text = "Proceed"
        Me.btnpreceed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpreceed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnpreceed.TextShadowShow = False
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
        Me.ELabel1.Location = New System.Drawing.Point(489, 10)
        Me.ELabel1.MouseOverColor = System.Drawing.Color.Gray
        Me.ELabel1.Name = "ELabel1"
        Me.ELabel1.ShadowState = True
        Me.ELabel1.Size = New System.Drawing.Size(320, 40)
        Me.ELabel1.TabIndex = 34
        Me.ELabel1.Text = "Pay Calculation for This Month"
        '
        'frmPayCalculationThisMonth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
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
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPayCalculationThisMonth"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pay Calculation for This Month"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.EGradientPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ERoundedPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.EGroupBox1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.nudyear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents EGradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents RoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents ELabel1 As ESAR_Controls.eLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ERoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents cmbmonth As System.Windows.Forms.ComboBox
    Private WithEvents nudyear As System.Windows.Forms.NumericUpDown
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents EGroupBox1 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents btnhelp As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnpreceed As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents cmbdesignation As ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
    Friend WithEvents EVistaProgressBar1 As ESAR_Controls.UIControls.ProgressBar.eVistaProgressBar
End Class
