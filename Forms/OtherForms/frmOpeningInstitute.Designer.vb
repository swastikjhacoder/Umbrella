Imports Umbrella.UIControls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpeningInstitute
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.EGroupBox1 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.lblinstitute = New ESAR_Controls.eLabel
        Me.XpProgressBar1 = New ESAR_Controls.UIControls.ProgressBar.eXpProgressBar
        Me.EGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 70
        '
        'EGroupBox1
        '
        Me.EGroupBox1.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox1.BorderThickness = 1.0!
        Me.EGroupBox1.Controls.Add(Me.lblinstitute)
        Me.EGroupBox1.Controls.Add(Me.XpProgressBar1)
        Me.EGroupBox1.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EGroupBox1.GroupImage = Global.Umbrella.My.Resources.Resources.Umbrella_icon
        Me.EGroupBox1.GroupTitle = ""
        Me.EGroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.EGroupBox1.Name = "EGroupBox1"
        Me.EGroupBox1.Padding = New System.Windows.Forms.Padding(12, 25, 12, 10)
        Me.EGroupBox1.PaintGroupBox = False
        Me.EGroupBox1.RoundCorners = 10
        Me.EGroupBox1.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox1.ShadowControl = False
        Me.EGroupBox1.ShadowThickness = 3
        Me.EGroupBox1.Size = New System.Drawing.Size(385, 120)
        Me.EGroupBox1.TabIndex = 0
        '
        'lblinstitute
        '
        Me.lblinstitute.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblinstitute.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinstitute.ForeColor = System.Drawing.Color.Black
        Me.lblinstitute.Location = New System.Drawing.Point(12, 25)
        Me.lblinstitute.Name = "lblinstitute"
        Me.lblinstitute.Size = New System.Drawing.Size(361, 60)
        Me.lblinstitute.TabIndex = 12
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
        Me.XpProgressBar1.Location = New System.Drawing.Point(12, 85)
        Me.XpProgressBar1.Name = "XpProgressBar1"
        Me.XpProgressBar1.Position = 0
        Me.XpProgressBar1.PositionMax = 100
        Me.XpProgressBar1.PositionMin = 0
        Me.XpProgressBar1.Size = New System.Drawing.Size(361, 25)
        Me.XpProgressBar1.TabIndex = 11
        Me.XpProgressBar1.Text = "0 %"
        Me.XpProgressBar1.TextShadow = False
        '
        'frmOpeningInstitute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(405, 140)
        Me.ControlBox = False
        Me.Controls.Add(Me.EGroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.Custom
        Me.Name = "frmOpeningInstitute"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.EGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents EGroupBox1 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents lblinstitute As ESAR_Controls.eLabel
    Friend WithEvents XpProgressBar1 As ESAR_Controls.UIControls.ProgressBar.eXpProgressBar
End Class
