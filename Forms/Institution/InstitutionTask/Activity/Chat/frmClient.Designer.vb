Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClient
    Inherits ESAR_Controls.UIControls.eForms.eFadeGradientForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClient))
        Dim DesignerRectTracker2 As DesignerRectTracker = New DesignerRectTracker
        Dim DesignerRectTracker3 As DesignerRectTracker = New DesignerRectTracker
        Dim DesignerRectTracker4 As DesignerRectTracker = New DesignerRectTracker
        Dim DesignerRectTracker5 As DesignerRectTracker = New DesignerRectTracker
        Dim DesignerRectTracker6 As DesignerRectTracker = New DesignerRectTracker
        Dim DesignerRectTracker7 As DesignerRectTracker = New DesignerRectTracker
        Dim DesignerRectTracker8 As DesignerRectTracker = New DesignerRectTracker
        Me.MenuStrip1 = New Strips.eMenuStrip
        Me.EAppearanceControl1 = New Appearance.eAppearanceControl
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConnectBuddyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NotepadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PaintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculatorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SendFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UrduToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HowToUseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AbouToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.lblWelcome = New CloudToolkitN6.CloudLabel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSend = New ESAR_Controls.UIControls.Button.eButton
        Me.txtUrdu = New System.Windows.Forms.TextBox
        Me.btnColor = New System.Windows.Forms.Button
        Me.btnFont = New System.Windows.Forms.Button
        Me.txtEnglish = New System.Windows.Forms.TextBox
        Me.msgListBox = New System.Windows.Forms.ListBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnConfirm = New ESAR_Controls.UIControls.Button.eButton
        Me.txtName = New System.Windows.Forms.TextBox
        Me.ETabControl1 = New ESAR_Controls.UIControls.TabControl.eTabControl
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.btnBuddy = New CloudToolkitN6.CloudDesktopButton
        Me.btnVoiceChat = New CloudToolkitN6.CloudDesktopButton
        Me.btnNotepad = New CloudToolkitN6.CloudDesktopButton
        Me.btnPaint = New CloudToolkitN6.CloudDesktopButton
        Me.btnCalc = New CloudToolkitN6.CloudDesktopButton
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.CloudLabel1 = New CloudToolkitN6.CloudLabel
        Me.btnSendFile = New CloudToolkitN6.CloudButton
        Me.btnBrowse = New CloudToolkitN6.CloudButton
        Me.sendFileText = New System.Windows.Forms.TextBox
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.btnClose = New CloudToolkitN6.CloudDesktopButton
        Me.btnOpen = New CloudToolkitN6.CloudDesktopButton
        Me.btnOptions = New ESAR_Controls.UIControls.Button.eButton
        Me.btnConnectServer = New ESAR_Controls.UIControls.Button.eButton
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ETabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Appearance = Me.EAppearanceControl1
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.LanguageToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(340, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EAppearanceControl1
        '
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.CheckedAppearance.intBackground = -16273
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.CheckedAppearance.intBorderHighlight = -13410648
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.CheckedAppearance.intGradientBegin = -8294
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.CheckedAppearance.intGradientEnd = -22964
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.CheckedAppearance.intGradientMiddle = -15500
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.CheckedAppearance.intHighlight = -3878683
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.CheckedAppearance.intPressedBackground = -98242
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.CheckedAppearance.intSelectedBackground = -98242
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.PressedAppearance.Border = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.PressedAppearance.intBorder = -16777088
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.PressedAppearance.intBorderHighlight = -13410648
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.PressedAppearance.intGradientBegin = -98242
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.PressedAppearance.intGradientEnd = -8294
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.PressedAppearance.intGradientMiddle = -20115
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.PressedAppearance.intHighlight = -6771246
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.SelectedAppearance.Border = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.SelectedAppearance.BorderHighlight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.SelectedAppearance.intBorder = -16777088
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.SelectedAppearance.intBorderHighlight = -16777088
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.SelectedAppearance.intGradientBegin = -34
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.SelectedAppearance.intGradientEnd = -13432
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.SelectedAppearance.intGradientMiddle = -7764
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.SelectedAppearance.intHighlight = -3878683
        Me.EAppearanceControl1.CustomAppearance.GripAppearance.intDark = -14204554
        Me.EAppearanceControl1.CustomAppearance.GripAppearance.intLight = -1
        Me.EAppearanceControl1.CustomAppearance.GripAppearance.Light = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EAppearanceControl1.CustomAppearance.ImageMarginAppearance.Normal.intGradientBegin = -1839105
        Me.EAppearanceControl1.CustomAppearance.ImageMarginAppearance.Normal.intGradientEnd = -8674080
        Me.EAppearanceControl1.CustomAppearance.ImageMarginAppearance.Normal.intGradientMiddle = -3415556
        Me.EAppearanceControl1.CustomAppearance.ImageMarginAppearance.Revealed.intGradientBegin = -3416586
        Me.EAppearanceControl1.CustomAppearance.ImageMarginAppearance.Revealed.intGradientEnd = -9266217
        Me.EAppearanceControl1.CustomAppearance.ImageMarginAppearance.Revealed.intGradientMiddle = -6175239
        Me.EAppearanceControl1.CustomAppearance.MenuItemAppearance.Border = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EAppearanceControl1.CustomAppearance.MenuItemAppearance.intBorder = -16777088
        Me.EAppearanceControl1.CustomAppearance.MenuItemAppearance.intPressedGradientBegin = -1839105
        Me.EAppearanceControl1.CustomAppearance.MenuItemAppearance.intPressedGradientEnd = -8674080
        Me.EAppearanceControl1.CustomAppearance.MenuItemAppearance.intPressedGradientMiddle = -6175239
        Me.EAppearanceControl1.CustomAppearance.MenuItemAppearance.intSelected = -4414
        Me.EAppearanceControl1.CustomAppearance.MenuItemAppearance.intSelectedGradientBegin = -34
        Me.EAppearanceControl1.CustomAppearance.MenuItemAppearance.intSelectedGradientEnd = -13432
        Me.EAppearanceControl1.CustomAppearance.MenuStripAppearance.intBorder = -16765546
        Me.EAppearanceControl1.CustomAppearance.MenuStripAppearance.intGradientBegin = -6373643
        Me.EAppearanceControl1.CustomAppearance.MenuStripAppearance.intGradientEnd = -3876102
        Me.EAppearanceControl1.CustomAppearance.OverflowButtonAppearance.intGradientBegin = -8408582
        Me.EAppearanceControl1.CustomAppearance.OverflowButtonAppearance.intGradientEnd = -16763503
        Me.EAppearanceControl1.CustomAppearance.OverflowButtonAppearance.intGradientMiddle = -11370544
        Me.EAppearanceControl1.CustomAppearance.RaftingContainerAppearance.intGradientBegin = -6373643
        Me.EAppearanceControl1.CustomAppearance.RaftingContainerAppearance.intGradientEnd = -3876102
        Me.EAppearanceControl1.CustomAppearance.SeparatorAppearance.intDark = -9794357
        Me.EAppearanceControl1.CustomAppearance.SeparatorAppearance.intLight = -919041
        Me.EAppearanceControl1.CustomAppearance.StatusStripAppearance.intGradientBegin = -6373643
        Me.EAppearanceControl1.CustomAppearance.StatusStripAppearance.intGradientEnd = -3876102
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intBorder = -12885604
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intContentPanelGradientBegin = -6373643
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intContentPanelGradientEnd = -3876102
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intDropDownBackground = -592138
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intGradientBegin = -1839105
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intGradientEnd = -8674080
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intGradientMiddle = -3415556
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intPanelGradientBegin = -6373643
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intPanelGradientEnd = -3876102
        Me.EAppearanceControl1.Preset = Appearance.eAppearanceControl.enumPresetStyles.Custom
        Me.EAppearanceControl1.Renderer.RoundedEdges = True
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectBuddyToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ConnectBuddyToolStripMenuItem
        '
        Me.ConnectBuddyToolStripMenuItem.Name = "ConnectBuddyToolStripMenuItem"
        Me.ConnectBuddyToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ConnectBuddyToolStripMenuItem.Text = "Connect Buddy"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem, Me.NotepadToolStripMenuItem, Me.PaintToolStripMenuItem, Me.CalculatorToolStripMenuItem1, Me.SendFileToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.CalculatorToolStripMenuItem.Text = "Voice Chat"
        '
        'NotepadToolStripMenuItem
        '
        Me.NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem"
        Me.NotepadToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.NotepadToolStripMenuItem.Text = "Notepad"
        '
        'PaintToolStripMenuItem
        '
        Me.PaintToolStripMenuItem.Name = "PaintToolStripMenuItem"
        Me.PaintToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.PaintToolStripMenuItem.Text = "Paint"
        '
        'CalculatorToolStripMenuItem1
        '
        Me.CalculatorToolStripMenuItem1.Name = "CalculatorToolStripMenuItem1"
        Me.CalculatorToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.CalculatorToolStripMenuItem1.Text = "Calculator"
        '
        'SendFileToolStripMenuItem
        '
        Me.SendFileToolStripMenuItem.Name = "SendFileToolStripMenuItem"
        Me.SendFileToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.SendFileToolStripMenuItem.Text = "Send File"
        '
        'LanguageToolStripMenuItem
        '
        Me.LanguageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnglishToolStripMenuItem, Me.UrduToolStripMenuItem})
        Me.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem"
        Me.LanguageToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.LanguageToolStripMenuItem.Text = "Language"
        '
        'EnglishToolStripMenuItem
        '
        Me.EnglishToolStripMenuItem.Name = "EnglishToolStripMenuItem"
        Me.EnglishToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.EnglishToolStripMenuItem.Text = "English"
        '
        'UrduToolStripMenuItem
        '
        Me.UrduToolStripMenuItem.Name = "UrduToolStripMenuItem"
        Me.UrduToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.UrduToolStripMenuItem.Text = "Urdu"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HowToUseToolStripMenuItem, Me.AbouToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HowToUseToolStripMenuItem
        '
        Me.HowToUseToolStripMenuItem.Name = "HowToUseToolStripMenuItem"
        Me.HowToUseToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.HowToUseToolStripMenuItem.Text = "How To Use?"
        '
        'AbouToolStripMenuItem
        '
        Me.AbouToolStripMenuItem.Name = "AbouToolStripMenuItem"
        Me.AbouToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.AbouToolStripMenuItem.Text = "About"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblWelcome
        '
        Me.lblWelcome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Location = New System.Drawing.Point(28, -28)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(85, 16)
        Me.lblWelcome.TabIndex = 74
        Me.lblWelcome.Text = "Welcome , "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnSend)
        Me.GroupBox1.Controls.Add(Me.txtUrdu)
        Me.GroupBox1.Controls.Add(Me.lblWelcome)
        Me.GroupBox1.Controls.Add(Me.btnColor)
        Me.GroupBox1.Controls.Add(Me.btnFont)
        Me.GroupBox1.Controls.Add(Me.txtEnglish)
        Me.GroupBox1.Controls.Add(Me.msgListBox)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(5, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 322)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnSend
        '
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnSend.CenterPtTracker = DesignerRectTracker1
        Me.btnSend.ColorFillSolid = System.Drawing.Color.White
        Me.btnSend.Corners.All = CType(8, Short)
        Me.btnSend.Corners.LowerLeft = CType(8, Short)
        Me.btnSend.Corners.LowerRight = CType(8, Short)
        Me.btnSend.Corners.UpperLeft = CType(8, Short)
        Me.btnSend.Corners.UpperRight = CType(8, Short)
        Me.btnSend.FillType = ESAR_Controls.UIControls.Button.eButton.eFillType.Solid
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnSend.FocusPtTracker = DesignerRectTracker2
        Me.btnSend.ForeColor = System.Drawing.Color.Black
        Me.btnSend.ImageIndex = 0
        Me.btnSend.Location = New System.Drawing.Point(269, 254)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(53, 62)
        Me.btnSend.TabIndex = 76
        Me.btnSend.Text = "Send"
        Me.btnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSend.TextShadowShow = False
        '
        'txtUrdu
        '
        Me.txtUrdu.Location = New System.Drawing.Point(7, 254)
        Me.txtUrdu.Multiline = True
        Me.txtUrdu.Name = "txtUrdu"
        Me.txtUrdu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtUrdu.Size = New System.Drawing.Size(258, 62)
        Me.txtUrdu.TabIndex = 75
        '
        'btnColor
        '
        Me.btnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnColor.FlatAppearance.BorderSize = 0
        Me.btnColor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColor.Image = Global.Umbrella.My.Resources.Resources.color
        Me.btnColor.Location = New System.Drawing.Point(31, 228)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(23, 23)
        Me.btnColor.TabIndex = 4
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'btnFont
        '
        Me.btnFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFont.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFont.FlatAppearance.BorderSize = 0
        Me.btnFont.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnFont.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFont.Image = Global.Umbrella.My.Resources.Resources.font
        Me.btnFont.Location = New System.Drawing.Point(7, 228)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(23, 23)
        Me.btnFont.TabIndex = 3
        Me.btnFont.UseVisualStyleBackColor = True
        '
        'txtEnglish
        '
        Me.txtEnglish.Location = New System.Drawing.Point(7, 254)
        Me.txtEnglish.Multiline = True
        Me.txtEnglish.Name = "txtEnglish"
        Me.txtEnglish.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEnglish.Size = New System.Drawing.Size(258, 62)
        Me.txtEnglish.TabIndex = 1
        '
        'msgListBox
        '
        Me.msgListBox.FormattingEnabled = True
        Me.msgListBox.Location = New System.Drawing.Point(7, 13)
        Me.msgListBox.Name = "msgListBox"
        Me.msgListBox.ScrollAlwaysVisible = True
        Me.msgListBox.Size = New System.Drawing.Size(317, 212)
        Me.msgListBox.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.btnConfirm)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(7, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 40)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Your Name:"
        '
        'btnConfirm
        '
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnConfirm.CenterPtTracker = DesignerRectTracker3
        Me.btnConfirm.ColorFillSolid = System.Drawing.Color.White
        Me.btnConfirm.Corners.All = CType(8, Short)
        Me.btnConfirm.Corners.LowerLeft = CType(8, Short)
        Me.btnConfirm.Corners.LowerRight = CType(8, Short)
        Me.btnConfirm.Corners.UpperLeft = CType(8, Short)
        Me.btnConfirm.Corners.UpperRight = CType(8, Short)
        Me.btnConfirm.FillType = ESAR_Controls.UIControls.Button.eButton.eFillType.Solid
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnConfirm.FocusPtTracker = DesignerRectTracker4
        Me.btnConfirm.ForeColor = System.Drawing.Color.Black
        Me.btnConfirm.ImageIndex = 0
        Me.btnConfirm.Location = New System.Drawing.Point(185, 11)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(90, 25)
        Me.btnConfirm.TabIndex = 8
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfirm.TextShadowShow = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(27, 14)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(152, 20)
        Me.txtName.TabIndex = 0
        '
        'ETabControl1
        '
        Me.ETabControl1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ETabControl1.Controls.Add(Me.TabPage4)
        Me.ETabControl1.Controls.Add(Me.TabPage5)
        Me.ETabControl1.Controls.Add(Me.TabPage6)
        Me.ETabControl1.Location = New System.Drawing.Point(5, 450)
        Me.ETabControl1.Name = "ETabControl1"
        Me.ETabControl1.SelectedIndex = 0
        Me.ETabControl1.Size = New System.Drawing.Size(330, 119)
        Me.ETabControl1.TabIndex = 9
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage4.Controls.Add(Me.btnBuddy)
        Me.TabPage4.Controls.Add(Me.btnVoiceChat)
        Me.TabPage4.Controls.Add(Me.btnNotepad)
        Me.TabPage4.Controls.Add(Me.btnPaint)
        Me.TabPage4.Controls.Add(Me.btnCalc)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(322, 90)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Tools"
        '
        'btnBuddy
        '
        Me.btnBuddy.AnimationSpeed = 5
        Me.btnBuddy.BackColor = System.Drawing.Color.Transparent
        Me.btnBuddy.BackgroundOpacity = 100
        Me.btnBuddy.BackgroundOpacity_MouseDown = 170
        Me.btnBuddy.BorderColor = System.Drawing.Color.White
        Me.btnBuddy.BorderOpacity = 170
        Me.btnBuddy.BorderWidth = 1
        Me.btnBuddy.ControlText = "New Buddy"
        Me.btnBuddy.CornerRadius = 12
        Me.btnBuddy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuddy.DrawBlackTextBackground = True
        Me.btnBuddy.FillColor = System.Drawing.Color.Azure
        Me.btnBuddy.ForeColor = System.Drawing.Color.Black
        Me.btnBuddy.Icon = Global.Umbrella.My.Resources.Resources.buddy
        Me.btnBuddy.Location = New System.Drawing.Point(9, 15)
        Me.btnBuddy.Name = "btnBuddy"
        Me.btnBuddy.Size = New System.Drawing.Size(63, 69)
        Me.btnBuddy.TabIndex = 9
        '
        'btnVoiceChat
        '
        Me.btnVoiceChat.AnimationSpeed = 5
        Me.btnVoiceChat.BackColor = System.Drawing.Color.Transparent
        Me.btnVoiceChat.BackgroundOpacity = 100
        Me.btnVoiceChat.BackgroundOpacity_MouseDown = 170
        Me.btnVoiceChat.BorderColor = System.Drawing.Color.White
        Me.btnVoiceChat.BorderOpacity = 170
        Me.btnVoiceChat.BorderWidth = 1
        Me.btnVoiceChat.ControlText = "VoiceChat"
        Me.btnVoiceChat.CornerRadius = 12
        Me.btnVoiceChat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVoiceChat.DrawBlackTextBackground = True
        Me.btnVoiceChat.FillColor = System.Drawing.Color.Azure
        Me.btnVoiceChat.ForeColor = System.Drawing.Color.Black
        Me.btnVoiceChat.Icon = Global.Umbrella.My.Resources.Resources.voice_chat
        Me.btnVoiceChat.Location = New System.Drawing.Point(259, 15)
        Me.btnVoiceChat.Name = "btnVoiceChat"
        Me.btnVoiceChat.Size = New System.Drawing.Size(54, 69)
        Me.btnVoiceChat.TabIndex = 8
        '
        'btnNotepad
        '
        Me.btnNotepad.AnimationSpeed = 5
        Me.btnNotepad.BackColor = System.Drawing.Color.Transparent
        Me.btnNotepad.BackgroundOpacity = 100
        Me.btnNotepad.BackgroundOpacity_MouseDown = 170
        Me.btnNotepad.BorderColor = System.Drawing.Color.White
        Me.btnNotepad.BorderOpacity = 170
        Me.btnNotepad.BorderWidth = 1
        Me.btnNotepad.ControlText = "Notepad"
        Me.btnNotepad.CornerRadius = 12
        Me.btnNotepad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotepad.DrawBlackTextBackground = True
        Me.btnNotepad.FillColor = System.Drawing.Color.Azure
        Me.btnNotepad.ForeColor = System.Drawing.Color.Black
        Me.btnNotepad.Icon = Global.Umbrella.My.Resources.Resources.notepad
        Me.btnNotepad.Location = New System.Drawing.Point(198, 15)
        Me.btnNotepad.Name = "btnNotepad"
        Me.btnNotepad.Size = New System.Drawing.Size(54, 69)
        Me.btnNotepad.TabIndex = 7
        '
        'btnPaint
        '
        Me.btnPaint.AnimationSpeed = 5
        Me.btnPaint.BackColor = System.Drawing.Color.Transparent
        Me.btnPaint.BackgroundOpacity = 100
        Me.btnPaint.BackgroundOpacity_MouseDown = 170
        Me.btnPaint.BorderColor = System.Drawing.Color.White
        Me.btnPaint.BorderOpacity = 170
        Me.btnPaint.BorderWidth = 1
        Me.btnPaint.ControlText = "Paint"
        Me.btnPaint.CornerRadius = 12
        Me.btnPaint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPaint.DrawBlackTextBackground = True
        Me.btnPaint.FillColor = System.Drawing.Color.Azure
        Me.btnPaint.ForeColor = System.Drawing.Color.Black
        Me.btnPaint.Icon = Global.Umbrella.My.Resources.Resources.paint
        Me.btnPaint.Location = New System.Drawing.Point(138, 15)
        Me.btnPaint.Name = "btnPaint"
        Me.btnPaint.Size = New System.Drawing.Size(54, 69)
        Me.btnPaint.TabIndex = 6
        '
        'btnCalc
        '
        Me.btnCalc.AnimationSpeed = 5
        Me.btnCalc.BackColor = System.Drawing.Color.Transparent
        Me.btnCalc.BackgroundOpacity = 100
        Me.btnCalc.BackgroundOpacity_MouseDown = 170
        Me.btnCalc.BorderColor = System.Drawing.Color.White
        Me.btnCalc.BorderOpacity = 170
        Me.btnCalc.BorderWidth = 1
        Me.btnCalc.ControlText = "Calculator"
        Me.btnCalc.CornerRadius = 12
        Me.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalc.DrawBlackTextBackground = True
        Me.btnCalc.FillColor = System.Drawing.Color.Azure
        Me.btnCalc.ForeColor = System.Drawing.Color.Black
        Me.btnCalc.Icon = Global.Umbrella.My.Resources.Resources.calculator_blue
        Me.btnCalc.Location = New System.Drawing.Point(81, 15)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(54, 69)
        Me.btnCalc.TabIndex = 5
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage5.Controls.Add(Me.CloudLabel1)
        Me.TabPage5.Controls.Add(Me.btnSendFile)
        Me.TabPage5.Controls.Add(Me.btnBrowse)
        Me.TabPage5.Controls.Add(Me.sendFileText)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(322, 90)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "File Transfer"
        '
        'CloudLabel1
        '
        Me.CloudLabel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloudLabel1.AutoSize = True
        Me.CloudLabel1.BackColor = System.Drawing.Color.Transparent
        Me.CloudLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudLabel1.ForeColor = System.Drawing.Color.Black
        Me.CloudLabel1.Location = New System.Drawing.Point(24, 12)
        Me.CloudLabel1.Name = "CloudLabel1"
        Me.CloudLabel1.Size = New System.Drawing.Size(63, 13)
        Me.CloudLabel1.TabIndex = 66
        Me.CloudLabel1.Text = "File Name"
        '
        'btnSendFile
        '
        Me.btnSendFile.BackColor = System.Drawing.Color.Transparent
        Me.btnSendFile.ButtonText = "Send File"
        Me.btnSendFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSendFile.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.btnSendFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnSendFile.Icon = Nothing
        Me.btnSendFile.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left
        Me.btnSendFile.IconSpacingX = 5
        Me.btnSendFile.IconSpacingY = 5
        Me.btnSendFile.IconTransparency = 0.0!
        Me.btnSendFile.Location = New System.Drawing.Point(27, 54)
        Me.btnSendFile.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.btnSendFile.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.btnSendFile.Name = "btnSendFile"
        Me.btnSendFile.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.btnSendFile.Size = New System.Drawing.Size(74, 25)
        Me.btnSendFile.TabIndex = 65
        Me.btnSendFile.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage
        Me.btnSendFile.TextSpacingX = 5
        Me.btnSendFile.TextSpacingY = 5
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.Transparent
        Me.btnBrowse.ButtonText = "Browse"
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnBrowse.Icon = Nothing
        Me.btnBrowse.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left
        Me.btnBrowse.IconSpacingX = 5
        Me.btnBrowse.IconSpacingY = 5
        Me.btnBrowse.IconTransparency = 0.0!
        Me.btnBrowse.Location = New System.Drawing.Point(224, 25)
        Me.btnBrowse.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.btnBrowse.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.btnBrowse.Size = New System.Drawing.Size(74, 25)
        Me.btnBrowse.TabIndex = 64
        Me.btnBrowse.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage
        Me.btnBrowse.TextSpacingX = 5
        Me.btnBrowse.TextSpacingY = 5
        '
        'sendFileText
        '
        Me.sendFileText.Location = New System.Drawing.Point(27, 28)
        Me.sendFileText.Name = "sendFileText"
        Me.sendFileText.Size = New System.Drawing.Size(191, 20)
        Me.sendFileText.TabIndex = 63
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage6.Controls.Add(Me.btnClose)
        Me.TabPage6.Controls.Add(Me.btnOpen)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(322, 90)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "CD Rom Options"
        '
        'btnClose
        '
        Me.btnClose.AnimationSpeed = 5
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundOpacity = 100
        Me.btnClose.BackgroundOpacity_MouseDown = 170
        Me.btnClose.BorderColor = System.Drawing.Color.White
        Me.btnClose.BorderOpacity = 170
        Me.btnClose.BorderWidth = 1
        Me.btnClose.ControlText = "Close"
        Me.btnClose.CornerRadius = 12
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DrawBlackTextBackground = True
        Me.btnClose.FillColor = System.Drawing.Color.Azure
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Icon = Global.Umbrella.My.Resources.Resources.disc_cancel
        Me.btnClose.Location = New System.Drawing.Point(164, 15)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(54, 72)
        Me.btnClose.TabIndex = 5
        '
        'btnOpen
        '
        Me.btnOpen.AnimationSpeed = 5
        Me.btnOpen.BackColor = System.Drawing.Color.Transparent
        Me.btnOpen.BackgroundOpacity = 100
        Me.btnOpen.BackgroundOpacity_MouseDown = 170
        Me.btnOpen.BorderColor = System.Drawing.Color.White
        Me.btnOpen.BorderOpacity = 170
        Me.btnOpen.BorderWidth = 1
        Me.btnOpen.ControlText = "Open"
        Me.btnOpen.CornerRadius = 12
        Me.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpen.DrawBlackTextBackground = True
        Me.btnOpen.FillColor = System.Drawing.Color.Azure
        Me.btnOpen.ForeColor = System.Drawing.Color.Black
        Me.btnOpen.Icon = Global.Umbrella.My.Resources.Resources.eject
        Me.btnOpen.Location = New System.Drawing.Point(104, 15)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(54, 72)
        Me.btnOpen.TabIndex = 4
        '
        'btnOptions
        '
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnOptions.CenterPtTracker = DesignerRectTracker5
        Me.btnOptions.ColorFillSolid = System.Drawing.Color.White
        Me.btnOptions.Corners.All = CType(8, Short)
        Me.btnOptions.Corners.LowerLeft = CType(8, Short)
        Me.btnOptions.Corners.LowerRight = CType(8, Short)
        Me.btnOptions.Corners.UpperLeft = CType(8, Short)
        Me.btnOptions.Corners.UpperRight = CType(8, Short)
        Me.btnOptions.FillType = ESAR_Controls.UIControls.Button.eButton.eFillType.Solid
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnOptions.FocusPtTracker = DesignerRectTracker6
        Me.btnOptions.ForeColor = System.Drawing.Color.Black
        Me.btnOptions.ImageIndex = 0
        Me.btnOptions.Location = New System.Drawing.Point(12, 406)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(127, 25)
        Me.btnOptions.TabIndex = 10
        Me.btnOptions.Text = "Show Options >>"
        Me.btnOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOptions.TextShadowShow = False
        '
        'btnConnectServer
        '
        DesignerRectTracker7.IsActive = False
        DesignerRectTracker7.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker7.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnConnectServer.CenterPtTracker = DesignerRectTracker7
        Me.btnConnectServer.ColorFillSolid = System.Drawing.Color.White
        Me.btnConnectServer.Corners.All = CType(8, Short)
        Me.btnConnectServer.Corners.LowerLeft = CType(8, Short)
        Me.btnConnectServer.Corners.LowerRight = CType(8, Short)
        Me.btnConnectServer.Corners.UpperLeft = CType(8, Short)
        Me.btnConnectServer.Corners.UpperRight = CType(8, Short)
        Me.btnConnectServer.FillType = ESAR_Controls.UIControls.Button.eButton.eFillType.Solid
        DesignerRectTracker8.IsActive = False
        DesignerRectTracker8.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker8.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnConnectServer.FocusPtTracker = DesignerRectTracker8
        Me.btnConnectServer.ForeColor = System.Drawing.Color.Black
        Me.btnConnectServer.ImageIndex = 0
        Me.btnConnectServer.Location = New System.Drawing.Point(150, 406)
        Me.btnConnectServer.Name = "btnConnectServer"
        Me.btnConnectServer.Size = New System.Drawing.Size(181, 25)
        Me.btnConnectServer.TabIndex = 12
        Me.btnConnectServer.Text = "Connect to Main Server"
        Me.btnConnectServer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConnectServer.TextShadowShow = False
        '
        'frmClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(340, 581)
        Me.Controls.Add(Me.btnConnectServer)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.ETabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.Custom
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmClient"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chat Messanger"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ETabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As Strips.eMenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConnectBuddyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotepadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LanguageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnglishToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UrduToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HowToUseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbouToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents lblWelcome As CloudToolkitN6.CloudLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUrdu As System.Windows.Forms.TextBox
    Friend WithEvents btnColor As System.Windows.Forms.Button
    Friend WithEvents btnFont As System.Windows.Forms.Button
    Friend WithEvents txtEnglish As System.Windows.Forms.TextBox
    Friend WithEvents msgListBox As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents ETabControl1 As ESAR_Controls.UIControls.TabControl.eTabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents btnBuddy As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents btnVoiceChat As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents btnNotepad As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents btnPaint As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents btnCalc As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents CloudLabel1 As CloudToolkitN6.CloudLabel
    Friend WithEvents btnSendFile As CloudToolkitN6.CloudButton
    Friend WithEvents btnBrowse As CloudToolkitN6.CloudButton
    Friend WithEvents sendFileText As System.Windows.Forms.TextBox
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents btnClose As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents btnOpen As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents EAppearanceControl1 As Appearance.eAppearanceControl
    Friend WithEvents btnConfirm As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnSend As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnOptions As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnConnectServer As ESAR_Controls.UIControls.Button.eButton


End Class
