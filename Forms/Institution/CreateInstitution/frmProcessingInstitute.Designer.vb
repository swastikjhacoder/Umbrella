Imports Umbrella.UIControls
Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcessingInstitute
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
        Dim DesignerRectTracker1 As DesignerRectTracker = New DesignerRectTracker
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcessingInstitute))
        Dim DesignerRectTracker2 As DesignerRectTracker = New DesignerRectTracker
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AniEasyProgressTaskManager2 = New ESAR_Controls.UIControls.ProgressBar.Components.eAniEasyProgressTaskManager(Me.components)
        Me.AniEasyProgressTaskManager1 = New ESAR_Controls.UIControls.ProgressBar.Components.eAniEasyProgressTaskManager(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.EButton1 = New ESAR_Controls.UIControls.Button.eButton
        Me.XpProgressBar1 = New ESAR_Controls.UIControls.ProgressBar.eXpProgressBar
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripAnimatedEasyProgressBarItem1 = New ESAR_Controls.UIControls.ProgressBar.ToolStripAnimatedEasyProgressBarItem
        Me.status = New System.Windows.Forms.ToolStripStatusLabel
        Me.label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.RoundedPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.statusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 40
        '
        'AniEasyProgressTaskManager2
        '
        Me.AniEasyProgressTaskManager2.AnimatedGif = Global.Umbrella.My.Resources.Resources.loader
        Me.AniEasyProgressTaskManager2.FPS = 17
        '
        'AniEasyProgressTaskManager1
        '
        Me.AniEasyProgressTaskManager1.AnimatedGif = Global.Umbrella.My.Resources.Resources.Triangles_indicator
        Me.AniEasyProgressTaskManager1.FPS = 17
        '
        'Timer2
        '
        Me.Timer2.Interval = 40
        '
        'Timer3
        '
        Me.Timer3.Interval = 40
        '
        'Timer4
        '
        Me.Timer4.Interval = 40
        '
        'Timer5
        '
        Me.Timer5.Interval = 40
        '
        'Timer6
        '
        Me.Timer6.Interval = 40
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RoundedPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel1.Size = New System.Drawing.Size(434, 219)
        Me.Panel1.TabIndex = 0
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.RoundedPanel1.BorderRadius = 32
        Me.RoundedPanel1.Controls.Add(Me.Panel2)
        Me.RoundedPanel1.Controls.Add(Me.label1)
        Me.RoundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RoundedPanel1.Location = New System.Drawing.Point(10, 10)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.RoundedPanel1.Size = New System.Drawing.Size(412, 197)
        Me.RoundedPanel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.statusStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(10, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(392, 122)
        Me.Panel2.TabIndex = 30
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.EButton1)
        Me.Panel3.Controls.Add(Me.XpProgressBar1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(50, 10, 50, 10)
        Me.Panel3.Size = New System.Drawing.Size(392, 95)
        Me.Panel3.TabIndex = 32
        '
        'EButton1
        '
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.EButton1.CenterPtTracker = DesignerRectTracker1
        Me.EButton1.ColorFillSolid = System.Drawing.Color.Transparent
        Me.EButton1.Corners.All = CType(15, Short)
        Me.EButton1.Corners.LowerLeft = CType(15, Short)
        Me.EButton1.Corners.LowerRight = CType(15, Short)
        Me.EButton1.Corners.UpperLeft = CType(15, Short)
        Me.EButton1.Corners.UpperRight = CType(15, Short)
        Me.EButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EButton1.FillType = ESAR_Controls.UIControls.Button.eButton.eFillType.Solid
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.EButton1.FocusPtTracker = DesignerRectTracker2
        Me.EButton1.ForeColor = System.Drawing.Color.Black
        Me.EButton1.ImageIndex = 0
        Me.EButton1.Location = New System.Drawing.Point(50, 10)
        Me.EButton1.Name = "EButton1"
        Me.EButton1.Size = New System.Drawing.Size(292, 50)
        Me.EButton1.TabIndex = 30
        Me.EButton1.Text = ""
        Me.EButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EButton1.TextShadowShow = False
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
        Me.XpProgressBar1.Location = New System.Drawing.Point(50, 60)
        Me.XpProgressBar1.Name = "XpProgressBar1"
        Me.XpProgressBar1.Position = 0
        Me.XpProgressBar1.PositionMax = 100
        Me.XpProgressBar1.PositionMin = 0
        Me.XpProgressBar1.Size = New System.Drawing.Size(292, 25)
        Me.XpProgressBar1.TabIndex = 29
        Me.XpProgressBar1.Text = "0 %"
        Me.XpProgressBar1.TextShadow = False
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripAnimatedEasyProgressBarItem1, Me.status})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 95)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(392, 27)
        Me.statusStrip1.SizingGrip = False
        Me.statusStrip1.TabIndex = 31
        Me.statusStrip1.Text = "statusStrip1"
        '
        'ToolStripAnimatedEasyProgressBarItem1
        '
        Me.ToolStripAnimatedEasyProgressBarItem1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripAnimatedEasyProgressBarItem1.EasyProgressTaskManager = Me.AniEasyProgressTaskManager1
        Me.ToolStripAnimatedEasyProgressBarItem1.Name = "ToolStripAnimatedEasyProgressBarItem1"
        Me.ToolStripAnimatedEasyProgressBarItem1.Size = New System.Drawing.Size(21, 21)
        '
        'status
        '
        Me.status.BackColor = System.Drawing.SystemColors.Control
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(0, 22)
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.Brown
        Me.label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(10, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(392, 55)
        Me.label1.TabIndex = 28
        Me.label1.Text = "Processing Your Institution Details..."
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmProcessingInstitute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(434, 219)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.Custom
        Me.Name = "frmProcessingInstitute"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.RoundedPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents AniEasyProgressTaskManager1 As ESAR_Controls.UIControls.ProgressBar.Components.eAniEasyProgressTaskManager
    Friend WithEvents AniEasyProgressTaskManager2 As ESAR_Controls.UIControls.ProgressBar.Components.eAniEasyProgressTaskManager
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents Timer6 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripAnimatedEasyProgressBarItem1 As ESAR_Controls.UIControls.ProgressBar.ToolStripAnimatedEasyProgressBarItem
    Private WithEvents status As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents XpProgressBar1 As ESAR_Controls.UIControls.ProgressBar.eXpProgressBar
    Friend WithEvents EButton1 As ESAR_Controls.UIControls.Button.eButton
End Class
