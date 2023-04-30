Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInternetConnection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInternetConnection))
        Dim DesignerRectTracker2 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker3 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker4 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker5 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker6 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker7 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker8 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim CBlendItems1 As ESAR_Controls.cBlendItems = New ESAR_Controls.cBlendItems
        Me.EGradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.EGroupBox1 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.rbtnnotconnected = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnadvance = New ESAR_Controls.UIControls.Button.eButton
        Me.txtport = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtaddress = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.chkproxy = New System.Windows.Forms.CheckBox
        Me.rbtndirect = New System.Windows.Forms.RadioButton
        Me.chkprompt = New System.Windows.Forms.CheckBox
        Me.btnaddnew = New ESAR_Controls.UIControls.Button.eButton
        Me.cmbdialup = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.rbtndialup = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.ERoundedPanel6 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.btnhelp = New ESAR_Controls.UIControls.Button.eButton
        Me.btnsave = New ESAR_Controls.UIControls.Button.eButton
        Me.ELabel6 = New ESAR_Controls.eLabel
        Me.EGradientPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.EGroupBox1.SuspendLayout()
        Me.ERoundedPanel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'EGradientPanel1
        '
        Me.EGradientPanel1.Controls.Add(Me.Panel1)
        Me.EGradientPanel1.Controls.Add(Me.ERoundedPanel6)
        Me.EGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGradientPanel1.EndColor = System.Drawing.Color.RoyalBlue
        Me.EGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.EGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EGradientPanel1.Name = "EGradientPanel1"
        Me.EGradientPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.EGradientPanel1.Size = New System.Drawing.Size(522, 411)
        Me.EGradientPanel1.StartColor = System.Drawing.Color.LightCyan
        Me.EGradientPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.EGroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(502, 331)
        Me.Panel1.TabIndex = 27
        '
        'EGroupBox1
        '
        Me.EGroupBox1.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox1.BorderThickness = 1.0!
        Me.EGroupBox1.Controls.Add(Me.rbtnnotconnected)
        Me.EGroupBox1.Controls.Add(Me.Label5)
        Me.EGroupBox1.Controls.Add(Me.btnadvance)
        Me.EGroupBox1.Controls.Add(Me.txtport)
        Me.EGroupBox1.Controls.Add(Me.Label4)
        Me.EGroupBox1.Controls.Add(Me.txtaddress)
        Me.EGroupBox1.Controls.Add(Me.Label3)
        Me.EGroupBox1.Controls.Add(Me.chkproxy)
        Me.EGroupBox1.Controls.Add(Me.rbtndirect)
        Me.EGroupBox1.Controls.Add(Me.chkprompt)
        Me.EGroupBox1.Controls.Add(Me.btnaddnew)
        Me.EGroupBox1.Controls.Add(Me.cmbdialup)
        Me.EGroupBox1.Controls.Add(Me.Label2)
        Me.EGroupBox1.Controls.Add(Me.rbtndialup)
        Me.EGroupBox1.Controls.Add(Me.Label1)
        Me.EGroupBox1.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox1.GroupImage = Global.Umbrella.My.Resources.Resources.internet_connection
        Me.EGroupBox1.GroupTitle = "Internet Connection Setup:"
        Me.EGroupBox1.Location = New System.Drawing.Point(0, 5)
        Me.EGroupBox1.Name = "EGroupBox1"
        Me.EGroupBox1.Padding = New System.Windows.Forms.Padding(12, 25, 12, 10)
        Me.EGroupBox1.PaintGroupBox = False
        Me.EGroupBox1.RoundCorners = 10
        Me.EGroupBox1.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox1.ShadowControl = False
        Me.EGroupBox1.ShadowThickness = 3
        Me.EGroupBox1.Size = New System.Drawing.Size(502, 326)
        Me.EGroupBox1.TabIndex = 0
        '
        'rbtnnotconnected
        '
        Me.rbtnnotconnected.AutoSize = True
        Me.rbtnnotconnected.Checked = True
        Me.rbtnnotconnected.Location = New System.Drawing.Point(38, 292)
        Me.rbtnnotconnected.Name = "rbtnnotconnected"
        Me.rbtnnotconnected.Size = New System.Drawing.Size(292, 17)
        Me.rbtnnotconnected.TabIndex = 14
        Me.rbtnnotconnected.TabStop = True
        Me.rbtnnotconnected.Text = "This computer is not connected to the internet."
        Me.rbtnnotconnected.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(280, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "If you use AOL, click help for more information."
        '
        'btnadvance
        '
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnadvance.CenterPtTracker = DesignerRectTracker1
        Me.btnadvance.Corners.All = CType(12, Short)
        Me.btnadvance.Corners.LowerLeft = CType(12, Short)
        Me.btnadvance.Corners.LowerRight = CType(12, Short)
        Me.btnadvance.Corners.UpperLeft = CType(12, Short)
        Me.btnadvance.Corners.UpperRight = CType(12, Short)
        Me.btnadvance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadvance.FocalPoints.CenterPtX = 1.0!
        Me.btnadvance.FocalPoints.CenterPtY = 1.0!
        Me.btnadvance.FocalPoints.FocusPtX = 0.0!
        Me.btnadvance.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnadvance.FocusPtTracker = DesignerRectTracker2
        Me.btnadvance.ImageIndex = 0
        Me.btnadvance.Location = New System.Drawing.Point(415, 231)
        Me.btnadvance.Name = "btnadvance"
        Me.btnadvance.Size = New System.Drawing.Size(97, 25)
        Me.btnadvance.TabIndex = 12
        Me.btnadvance.Text = "Advance"
        Me.btnadvance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnadvance.TextShadowShow = False
        '
        'txtport
        '
        Me.txtport.BackColor = System.Drawing.Color.White
        Me.txtport.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtport.Location = New System.Drawing.Point(346, 235)
        Me.txtport.Name = "txtport"
        Me.txtport.Required = False
        Me.txtport.ShowErrorIcon = False
        Me.txtport.Size = New System.Drawing.Size(48, 21)
        Me.txtport.TabIndex = 11
        Me.txtport.TextBox = ""
        Me.txtport.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtport.WaterMark = "Port..."
        Me.txtport.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtport.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtport.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(299, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Port:"
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.Color.White
        Me.txtaddress.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtaddress.Location = New System.Drawing.Point(153, 235)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Required = False
        Me.txtaddress.ShowErrorIcon = False
        Me.txtaddress.Size = New System.Drawing.Size(135, 21)
        Me.txtaddress.TabIndex = 9
        Me.txtaddress.TextBox = ""
        Me.txtaddress.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtaddress.WaterMark = "Address..."
        Me.txtaddress.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtaddress.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Address:"
        '
        'chkproxy
        '
        Me.chkproxy.AutoSize = True
        Me.chkproxy.Location = New System.Drawing.Point(82, 214)
        Me.chkproxy.Name = "chkproxy"
        Me.chkproxy.Size = New System.Drawing.Size(127, 17)
        Me.chkproxy.TabIndex = 7
        Me.chkproxy.Text = "Use proxy server."
        Me.chkproxy.UseVisualStyleBackColor = True
        '
        'rbtndirect
        '
        Me.rbtndirect.AutoSize = True
        Me.rbtndirect.Location = New System.Drawing.Point(38, 191)
        Me.rbtndirect.Name = "rbtndirect"
        Me.rbtndirect.Size = New System.Drawing.Size(383, 17)
        Me.rbtndirect.TabIndex = 6
        Me.rbtndirect.Text = "Use a direct internet connection (LAN, ISDN, ADSL, AOL, etc. )"
        Me.rbtndirect.UseVisualStyleBackColor = True
        '
        'chkprompt
        '
        Me.chkprompt.AutoSize = True
        Me.chkprompt.Location = New System.Drawing.Point(82, 151)
        Me.chkprompt.Name = "chkprompt"
        Me.chkprompt.Size = New System.Drawing.Size(292, 17)
        Me.chkprompt.TabIndex = 5
        Me.chkprompt.Text = "Prompt before opening an internet connection."
        Me.chkprompt.UseVisualStyleBackColor = True
        '
        'btnaddnew
        '
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnaddnew.CenterPtTracker = DesignerRectTracker3
        Me.btnaddnew.Corners.All = CType(12, Short)
        Me.btnaddnew.Corners.LowerLeft = CType(12, Short)
        Me.btnaddnew.Corners.LowerRight = CType(12, Short)
        Me.btnaddnew.Corners.UpperLeft = CType(12, Short)
        Me.btnaddnew.Corners.UpperRight = CType(12, Short)
        Me.btnaddnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaddnew.FocalPoints.CenterPtX = 0.5473684!
        Me.btnaddnew.FocalPoints.CenterPtY = 0.4!
        Me.btnaddnew.FocalPoints.FocusPtX = 0.0!
        Me.btnaddnew.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnaddnew.FocusPtTracker = DesignerRectTracker4
        Me.btnaddnew.Image = Global.Umbrella.My.Resources.Resources.add
        Me.btnaddnew.ImageIndex = 0
        Me.btnaddnew.Location = New System.Drawing.Point(285, 120)
        Me.btnaddnew.Name = "btnaddnew"
        Me.btnaddnew.Size = New System.Drawing.Size(111, 25)
        Me.btnaddnew.TabIndex = 4
        Me.btnaddnew.Text = "Add New"
        Me.btnaddnew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnaddnew.TextShadowShow = False
        '
        'cmbdialup
        '
        Me.cmbdialup.FormattingEnabled = True
        Me.cmbdialup.Location = New System.Drawing.Point(82, 124)
        Me.cmbdialup.Name = "cmbdialup"
        Me.cmbdialup.Size = New System.Drawing.Size(195, 21)
        Me.cmbdialup.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(352, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select the dial-up connection that you want Umbrella to use."
        '
        'rbtndialup
        '
        Me.rbtndialup.AutoSize = True
        Me.rbtndialup.Location = New System.Drawing.Point(38, 82)
        Me.rbtndialup.Name = "rbtndialup"
        Me.rbtndialup.Size = New System.Drawing.Size(272, 17)
        Me.rbtndialup.TabIndex = 1
        Me.rbtndialup.Text = "Use an existing dial-up internet connection."
        Me.rbtndialup.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(461, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "You must have an internet connection to use certain features in Umbrella. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Selec" & _
            "t a method for umbrella to connect to the internet from the options below."
        '
        'ERoundedPanel6
        '
        Me.ERoundedPanel6.BackColor = System.Drawing.Color.Transparent
        Me.ERoundedPanel6.BorderRadius = 32
        Me.ERoundedPanel6.Controls.Add(Me.btnhelp)
        Me.ERoundedPanel6.Controls.Add(Me.btnsave)
        Me.ERoundedPanel6.Controls.Add(Me.ELabel6)
        Me.ERoundedPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.ERoundedPanel6.Location = New System.Drawing.Point(10, 10)
        Me.ERoundedPanel6.Name = "ERoundedPanel6"
        Me.ERoundedPanel6.Padding = New System.Windows.Forms.Padding(10)
        Me.ERoundedPanel6.Size = New System.Drawing.Size(502, 60)
        Me.ERoundedPanel6.TabIndex = 26
        '
        'btnhelp
        '
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnhelp.CenterPtTracker = DesignerRectTracker5
        Me.btnhelp.ColorFillSolid = System.Drawing.Color.White
        Me.btnhelp.Corners.All = CType(-1, Short)
        Me.btnhelp.Corners.LowerLeft = CType(20, Short)
        Me.btnhelp.Corners.LowerRight = CType(12, Short)
        Me.btnhelp.Corners.UpperLeft = CType(12, Short)
        Me.btnhelp.Corners.UpperRight = CType(20, Short)
        Me.btnhelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhelp.Dock = System.Windows.Forms.DockStyle.Left
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnhelp.FocusPtTracker = DesignerRectTracker6
        Me.btnhelp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhelp.Image = Global.Umbrella.My.Resources.Resources.help
        Me.btnhelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhelp.ImageIndex = 0
        Me.btnhelp.Location = New System.Drawing.Point(81, 10)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(63, 40)
        Me.btnhelp.TabIndex = 83
        Me.btnhelp.Text = "Help"
        Me.btnhelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhelp.TextShadowShow = False
        '
        'btnsave
        '
        DesignerRectTracker7.IsActive = False
        DesignerRectTracker7.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker7.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsave.CenterPtTracker = DesignerRectTracker7
        Me.btnsave.ColorFillSolid = System.Drawing.Color.White
        Me.btnsave.Corners.All = CType(-1, Short)
        Me.btnsave.Corners.LowerLeft = CType(20, Short)
        Me.btnsave.Corners.LowerRight = CType(12, Short)
        Me.btnsave.Corners.UpperLeft = CType(12, Short)
        Me.btnsave.Corners.UpperRight = CType(20, Short)
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnsave.FocalPoints.CenterPtX = 0.4366197!
        Me.btnsave.FocalPoints.CenterPtY = 0.375!
        Me.btnsave.FocalPoints.FocusPtX = 0.0!
        Me.btnsave.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker8.IsActive = False
        DesignerRectTracker8.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker8.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsave.FocusPtTracker = DesignerRectTracker8
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Image = Global.Umbrella.My.Resources.Resources.save
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.ImageIndex = 0
        Me.btnsave.Location = New System.Drawing.Point(10, 10)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(71, 40)
        Me.btnsave.TabIndex = 79
        Me.btnsave.Text = "Save"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsave.TextShadowShow = False
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
        Me.ELabel6.Location = New System.Drawing.Point(189, 10)
        Me.ELabel6.MouseOverColor = System.Drawing.Color.Gray
        Me.ELabel6.Name = "ELabel6"
        Me.ELabel6.ShadowState = True
        Me.ELabel6.Size = New System.Drawing.Size(303, 40)
        Me.ELabel6.TabIndex = 34
        Me.ELabel6.Text = "Define Internet Connection"
        '
        'frmInternetConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(522, 411)
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
        Me.Name = "frmInternetConnection"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Define Internet Connection"
        Me.EGradientPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.EGroupBox1.ResumeLayout(False)
        Me.EGroupBox1.PerformLayout()
        Me.ERoundedPanel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EGradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents EGroupBox1 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents ERoundedPanel6 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents btnhelp As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnsave As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents ELabel6 As ESAR_Controls.eLabel
    Friend WithEvents btnaddnew As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents cmbdialup As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbtndialup As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkproxy As System.Windows.Forms.CheckBox
    Friend WithEvents rbtndirect As System.Windows.Forms.RadioButton
    Friend WithEvents chkprompt As System.Windows.Forms.CheckBox
    Friend WithEvents rbtnnotconnected As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnadvance As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents txtport As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As ESAR_Controls.UIControls.TextBox.eTextBox
End Class
