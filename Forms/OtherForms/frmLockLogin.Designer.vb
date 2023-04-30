Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLockLogin
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
        Dim DesignerRectTracker5 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLockLogin))
        Dim DesignerRectTracker6 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker1 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker2 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Me.RoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.btnclose = New ESAR_Controls.UIControls.Button.eButton
        Me.txtpassword = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtusername = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.btnlogin = New ESAR_Controls.UIControls.Button.eButton
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.RoundedPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.BackColor = System.Drawing.Color.White
        Me.RoundedPanel1.BorderRadius = 32
        Me.RoundedPanel1.Controls.Add(Me.btnclose)
        Me.RoundedPanel1.Controls.Add(Me.txtpassword)
        Me.RoundedPanel1.Controls.Add(Me.txtusername)
        Me.RoundedPanel1.Controls.Add(Me.btnlogin)
        Me.RoundedPanel1.Controls.Add(Me.PictureBox2)
        Me.RoundedPanel1.Location = New System.Drawing.Point(205, 200)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Size = New System.Drawing.Size(320, 125)
        Me.RoundedPanel1.TabIndex = 0
        '
        'btnclose
        '
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnclose.CenterPtTracker = DesignerRectTracker5
        Me.btnclose.ColorFillSolid = System.Drawing.Color.White
        Me.btnclose.Corners.All = CType(-1, Short)
        Me.btnclose.Corners.LowerLeft = CType(12, Short)
        Me.btnclose.Corners.LowerRight = CType(4, Short)
        Me.btnclose.Corners.UpperLeft = CType(4, Short)
        Me.btnclose.Corners.UpperRight = CType(12, Short)
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnclose.FocusPtTracker = DesignerRectTracker6
        Me.btnclose.Image = Global.Umbrella.My.Resources.Resources.close
        Me.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclose.ImageIndex = 0
        Me.btnclose.ImageSize = New System.Drawing.Size(22, 22)
        Me.btnclose.Location = New System.Drawing.Point(214, 81)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(74, 26)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "Close"
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnclose.TextShadowShow = False
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.White
        Me.txtpassword.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtpassword.Location = New System.Drawing.Point(106, 55)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Required = False
        Me.txtpassword.ShowErrorIcon = False
        Me.txtpassword.Size = New System.Drawing.Size(182, 20)
        Me.txtpassword.TabIndex = 1
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
        Me.txtusername.Location = New System.Drawing.Point(106, 26)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Required = False
        Me.txtusername.ShowErrorIcon = False
        Me.txtusername.Size = New System.Drawing.Size(182, 20)
        Me.txtusername.TabIndex = 0
        Me.txtusername.TextBox = ""
        Me.txtusername.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtusername.WaterMark = "Enter Username"
        Me.txtusername.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtusername.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'btnlogin
        '
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnlogin.CenterPtTracker = DesignerRectTracker1
        Me.btnlogin.ColorFillSolid = System.Drawing.Color.White
        Me.btnlogin.Corners.All = CType(-1, Short)
        Me.btnlogin.Corners.LowerLeft = CType(12, Short)
        Me.btnlogin.Corners.LowerRight = CType(4, Short)
        Me.btnlogin.Corners.UpperLeft = CType(4, Short)
        Me.btnlogin.Corners.UpperRight = CType(12, Short)
        Me.btnlogin.FocalPoints.CenterPtX = 0.472973!
        Me.btnlogin.FocalPoints.CenterPtY = 0.3461539!
        Me.btnlogin.FocalPoints.FocusPtX = 0.0!
        Me.btnlogin.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnlogin.FocusPtTracker = DesignerRectTracker2
        Me.btnlogin.Image = Global.Umbrella.My.Resources.Resources._next
        Me.btnlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogin.ImageIndex = 0
        Me.btnlogin.ImageSize = New System.Drawing.Size(22, 22)
        Me.btnlogin.Location = New System.Drawing.Point(106, 81)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(74, 26)
        Me.btnlogin.TabIndex = 2
        Me.btnlogin.Text = "Login"
        Me.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnlogin.TextShadowShow = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Umbrella.My.Resources.Resources.Login
        Me.PictureBox2.Location = New System.Drawing.Point(21, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(66, 72)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'frmLockLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(731, 525)
        Me.Controls.Add(Me.RoundedPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLockLogin"
        Me.Opacity = 0.25
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form4"
        Me.RoundedPanel1.ResumeLayout(False)
        Me.RoundedPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents btnclose As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents txtpassword As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtusername As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents btnlogin As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
