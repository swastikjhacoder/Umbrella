Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoginStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoginStudent))
        Dim DesignerRectTracker2 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker3 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker4 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Me.EGradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.ERoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.cmbdob = New ESAR_Controls.UIControls.ComboBox.eComboBoxDateTime
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtregistrationno = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnclose = New ESAR_Controls.UIControls.Button.eButton
        Me.btnlogin = New ESAR_Controls.UIControls.Button.eButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ELabel1 = New ESAR_Controls.eLabel
        Me.btnhelp = New System.Windows.Forms.Button
        Me.EGradientPanel1.SuspendLayout()
        Me.ERoundedPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EGradientPanel1
        '
        Me.EGradientPanel1.Controls.Add(Me.ERoundedPanel1)
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
        'ERoundedPanel1
        '
        Me.ERoundedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.ERoundedPanel1.BorderRadius = 32
        Me.ERoundedPanel1.Controls.Add(Me.cmbdob)
        Me.ERoundedPanel1.Controls.Add(Me.Label1)
        Me.ERoundedPanel1.Controls.Add(Me.txtregistrationno)
        Me.ERoundedPanel1.Controls.Add(Me.PictureBox1)
        Me.ERoundedPanel1.Controls.Add(Me.btnclose)
        Me.ERoundedPanel1.Controls.Add(Me.btnlogin)
        Me.ERoundedPanel1.Controls.Add(Me.Panel1)
        Me.ERoundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel1.Location = New System.Drawing.Point(10, 10)
        Me.ERoundedPanel1.Name = "ERoundedPanel1"
        Me.ERoundedPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.ERoundedPanel1.Size = New System.Drawing.Size(318, 235)
        Me.ERoundedPanel1.TabIndex = 0
        '
        'cmbdob
        '
        Me.cmbdob.FormatString = "d"
        Me.cmbdob.FormattingEnabled = True
        Me.cmbdob.Location = New System.Drawing.Point(175, 120)
        Me.cmbdob.Name = "cmbdob"
        Me.cmbdob.Size = New System.Drawing.Size(121, 21)
        Me.cmbdob.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Date of birth:"
        '
        'txtregistrationno
        '
        Me.txtregistrationno.BackColor = System.Drawing.Color.White
        Me.txtregistrationno.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtregistrationno.Location = New System.Drawing.Point(87, 93)
        Me.txtregistrationno.Name = "txtregistrationno"
        Me.txtregistrationno.Required = False
        Me.txtregistrationno.ShowErrorIcon = False
        Me.txtregistrationno.Size = New System.Drawing.Size(209, 21)
        Me.txtregistrationno.TabIndex = 0
        Me.txtregistrationno.TextBox = ""
        Me.txtregistrationno.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtregistrationno.WaterMark = "Enter Registration ID..."
        Me.txtregistrationno.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtregistrationno.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtregistrationno.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Umbrella.My.Resources.Resources.login_icon
        Me.PictureBox1.Location = New System.Drawing.Point(22, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'btnclose
        '
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnclose.CenterPtTracker = DesignerRectTracker1
        Me.btnclose.Corners.All = CType(12, Short)
        Me.btnclose.Corners.LowerLeft = CType(12, Short)
        Me.btnclose.Corners.LowerRight = CType(12, Short)
        Me.btnclose.Corners.UpperLeft = CType(12, Short)
        Me.btnclose.Corners.UpperRight = CType(12, Short)
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnclose.FocalPoints.CenterPtX = 1.0!
        Me.btnclose.FocalPoints.CenterPtY = 0.4!
        Me.btnclose.FocalPoints.FocusPtX = 0.0!
        Me.btnclose.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnclose.FocusPtTracker = DesignerRectTracker2
        Me.btnclose.ImageIndex = 0
        Me.btnclose.Location = New System.Drawing.Point(226, 161)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.SideImage = Global.Umbrella.My.Resources.Resources.close
        Me.btnclose.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnclose.SideImageSize = New System.Drawing.Size(16, 16)
        Me.btnclose.Size = New System.Drawing.Size(70, 32)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "Close"
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnlogin
        '
        DesignerRectTracker3.IsActive = True
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnlogin.CenterPtTracker = DesignerRectTracker3
        Me.btnlogin.Corners.All = CType(12, Short)
        Me.btnlogin.Corners.LowerLeft = CType(12, Short)
        Me.btnlogin.Corners.LowerRight = CType(12, Short)
        Me.btnlogin.Corners.UpperLeft = CType(12, Short)
        Me.btnlogin.Corners.UpperRight = CType(12, Short)
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.FocalPoints.CenterPtX = 1.0!
        Me.btnlogin.FocalPoints.CenterPtY = 0.4!
        Me.btnlogin.FocalPoints.FocusPtX = 0.0!
        Me.btnlogin.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnlogin.FocusPtTracker = DesignerRectTracker4
        Me.btnlogin.ImageIndex = 0
        Me.btnlogin.Location = New System.Drawing.Point(87, 161)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.SideImage = Global.Umbrella.My.Resources.Resources._next
        Me.btnlogin.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlogin.SideImageSize = New System.Drawing.Size(20, 20)
        Me.btnlogin.Size = New System.Drawing.Size(70, 32)
        Me.btnlogin.TabIndex = 2
        Me.btnlogin.Text = "Login"
        Me.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ELabel1)
        Me.Panel1.Controls.Add(Me.btnhelp)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(298, 21)
        Me.Panel1.TabIndex = 6
        '
        'ELabel1
        '
        Me.ELabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ELabel1.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ELabel1.GlowColor = System.Drawing.Color.DeepSkyBlue
        Me.ELabel1.Location = New System.Drawing.Point(0, 0)
        Me.ELabel1.Name = "ELabel1"
        Me.ELabel1.Size = New System.Drawing.Size(277, 21)
        Me.ELabel1.TabIndex = 3
        Me.ELabel1.Text = "Login System For Students"
        '
        'btnhelp
        '
        Me.btnhelp.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnhelp.FlatAppearance.BorderSize = 0
        Me.btnhelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnhelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnhelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhelp.Image = Global.Umbrella.My.Resources.Resources.help
        Me.btnhelp.Location = New System.Drawing.Point(277, 0)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(21, 21)
        Me.btnhelp.TabIndex = 4
        Me.btnhelp.UseVisualStyleBackColor = True
        '
        'frmLoginStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(338, 255)
        Me.ControlBox = False
        Me.Controls.Add(Me.EGradientPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.RoyalLight
        Me.Name = "frmLoginStudent"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.EGradientPanel1.ResumeLayout(False)
        Me.ERoundedPanel1.ResumeLayout(False)
        Me.ERoundedPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EGradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents ERoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents btnclose As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnlogin As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ELabel1 As ESAR_Controls.eLabel
    Friend WithEvents btnhelp As System.Windows.Forms.Button
    Friend WithEvents cmbdob As ESAR_Controls.UIControls.ComboBox.eComboBoxDateTime
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtregistrationno As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
