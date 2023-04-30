Imports Umbrella.UIControls
Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Dim DesignerRectTracker3 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker4 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker5 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker6 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker1 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker2 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.EGradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.ERoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.btnclose = New ESAR_Controls.UIControls.Button.eButton
        Me.btnlogin = New ESAR_Controls.UIControls.Button.eButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ELabel1 = New ESAR_Controls.eLabel
        Me.btnhelp = New System.Windows.Forms.Button
        Me.txtpassword = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtusername = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnstudentlogin = New ESAR_Controls.UIControls.Button.eButton
        Me.EGradientPanel1.SuspendLayout()
        Me.ERoundedPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "administrator-icon.png")
        Me.ImageList1.Images.SetKeyName(1, "employee.png")
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
        Me.ERoundedPanel1.Controls.Add(Me.btnstudentlogin)
        Me.ERoundedPanel1.Controls.Add(Me.btnclose)
        Me.ERoundedPanel1.Controls.Add(Me.btnlogin)
        Me.ERoundedPanel1.Controls.Add(Me.Panel1)
        Me.ERoundedPanel1.Controls.Add(Me.txtpassword)
        Me.ERoundedPanel1.Controls.Add(Me.txtusername)
        Me.ERoundedPanel1.Controls.Add(Me.PictureBox1)
        Me.ERoundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel1.Location = New System.Drawing.Point(10, 10)
        Me.ERoundedPanel1.Name = "ERoundedPanel1"
        Me.ERoundedPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.ERoundedPanel1.Size = New System.Drawing.Size(318, 235)
        Me.ERoundedPanel1.TabIndex = 0
        '
        'btnclose
        '
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnclose.CenterPtTracker = DesignerRectTracker3
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
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnclose.FocusPtTracker = DesignerRectTracker4
        Me.btnclose.ImageIndex = 0
        Me.btnclose.Location = New System.Drawing.Point(205, 161)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.SideImage = Global.Umbrella.My.Resources.Resources.close
        Me.btnclose.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnclose.SideImageSize = New System.Drawing.Size(16, 16)
        Me.btnclose.Size = New System.Drawing.Size(70, 32)
        Me.btnclose.TabIndex = 4
        Me.btnclose.Text = "Close"
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnlogin
        '
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnlogin.CenterPtTracker = DesignerRectTracker5
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
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnlogin.FocusPtTracker = DesignerRectTracker6
        Me.btnlogin.ImageIndex = 0
        Me.btnlogin.Location = New System.Drawing.Point(108, 161)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.SideImage = Global.Umbrella.My.Resources.Resources._next
        Me.btnlogin.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlogin.SideImageSize = New System.Drawing.Size(20, 20)
        Me.btnlogin.Size = New System.Drawing.Size(70, 32)
        Me.btnlogin.TabIndex = 3
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
        Me.ELabel1.Text = "Login to Umbrella System"
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
        Me.btnhelp.TabIndex = 5
        Me.btnhelp.UseVisualStyleBackColor = True
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.White
        Me.txtpassword.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtpassword.Location = New System.Drawing.Point(108, 119)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Required = False
        Me.txtpassword.ShowErrorIcon = False
        Me.txtpassword.Size = New System.Drawing.Size(167, 21)
        Me.txtpassword.TabIndex = 2
        Me.txtpassword.TextBox = ""
        Me.txtpassword.UseSystemPasswordChar = True
        Me.txtpassword.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtpassword.WaterMark = "Enter Password"
        Me.txtpassword.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtpassword.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.White
        Me.txtusername.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtusername.Location = New System.Drawing.Point(108, 92)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Required = False
        Me.txtusername.ShowErrorIcon = False
        Me.txtusername.Size = New System.Drawing.Size(167, 21)
        Me.txtusername.TabIndex = 1
        Me.txtusername.TextBox = ""
        Me.txtusername.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtusername.WaterMark = "Enter Username"
        Me.txtusername.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtusername.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Umbrella.My.Resources.Resources.Login
        Me.PictureBox1.Location = New System.Drawing.Point(39, 92)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnstudentlogin
        '
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnstudentlogin.CenterPtTracker = DesignerRectTracker1
        Me.btnstudentlogin.Corners.All = CType(12, Short)
        Me.btnstudentlogin.Corners.LowerLeft = CType(12, Short)
        Me.btnstudentlogin.Corners.LowerRight = CType(12, Short)
        Me.btnstudentlogin.Corners.UpperLeft = CType(12, Short)
        Me.btnstudentlogin.Corners.UpperRight = CType(12, Short)
        Me.btnstudentlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnstudentlogin.FocalPoints.CenterPtX = 0.4790419!
        Me.btnstudentlogin.FocalPoints.CenterPtY = 0.4375!
        Me.btnstudentlogin.FocalPoints.FocusPtX = 0.0!
        Me.btnstudentlogin.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnstudentlogin.FocusPtTracker = DesignerRectTracker2
        Me.btnstudentlogin.Image = Global.Umbrella.My.Resources.Resources.student_registration
        Me.btnstudentlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnstudentlogin.ImageIndex = 0
        Me.btnstudentlogin.Location = New System.Drawing.Point(108, 48)
        Me.btnstudentlogin.Name = "btnstudentlogin"
        Me.btnstudentlogin.Size = New System.Drawing.Size(167, 32)
        Me.btnstudentlogin.TabIndex = 7
        Me.btnstudentlogin.Text = "Student Login"
        Me.btnstudentlogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnstudentlogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnstudentlogin.TextShadowShow = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
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
        Me.Name = "frmLogin"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.EGradientPanel1.ResumeLayout(False)
        Me.ERoundedPanel1.ResumeLayout(False)
        Me.ERoundedPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents EGradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents ERoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents btnclose As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnlogin As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ELabel1 As ESAR_Controls.eLabel
    Friend WithEvents btnhelp As System.Windows.Forms.Button
    Friend WithEvents txtpassword As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtusername As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnstudentlogin As ESAR_Controls.UIControls.Button.eButton
End Class
