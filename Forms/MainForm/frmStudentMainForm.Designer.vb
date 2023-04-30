Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentMainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentMainForm))
        Dim DesignerRectTracker2 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker3 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker4 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker5 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker6 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker7 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker8 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker9 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker10 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker11 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker12 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Grouper1 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.PanelTask = New System.Windows.Forms.Panel
        Me.txtexamcode = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbdate = New ESAR_Controls.UIControls.ComboBox.eComboBoxDateTime
        Me.Label1 = New System.Windows.Forms.Label
        Me.EGroupBox1 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnonlineexamination = New ESAR_Controls.UIControls.Button.eButton
        Me.btnstudentinfo = New ESAR_Controls.UIControls.Button.eButton
        Me.ETabControlEx1 = New ESAR_Controls.UIControls.TabControl.eTabControlEx
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.EGradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.PanelStudentInfo = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.ETabStripStudentInfo = New ESAR_Controls.UIControls.TabControl.eTabStrip
        Me.RoundedPanel2 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnlogoutstudentinfo = New ESAR_Controls.UIControls.Button.eButton
        Me.btnhidestudentinfo = New ESAR_Controls.UIControls.Button.eButton
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.EGradientPanel2 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.PanelExam = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.ETabStripOnlineExamination = New ESAR_Controls.UIControls.TabControl.eTabStrip
        Me.ERoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnlogoutexam = New ESAR_Controls.UIControls.Button.eButton
        Me.btnhideexam = New ESAR_Controls.UIControls.Button.eButton
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Grouper1.SuspendLayout()
        Me.PanelTask.SuspendLayout()
        Me.EGroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ETabControlEx1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.EGradientPanel1.SuspendLayout()
        Me.PanelStudentInfo.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.RoundedPanel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.EGradientPanel2.SuspendLayout()
        Me.PanelExam.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.ERoundedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EGroupBox1)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(10, 10, 5, 10)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ETabControlEx1)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(5, 10, 10, 10)
        Me.SplitContainer1.Size = New System.Drawing.Size(1360, 680)
        Me.SplitContainer1.SplitterDistance = 188
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Grouper1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(10, 145)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Panel2.Size = New System.Drawing.Size(173, 147)
        Me.Panel2.TabIndex = 3
        '
        'Grouper1
        '
        Me.Grouper1.BackgroundColor = System.Drawing.Color.White
        Me.Grouper1.BackgroundGradientColor = System.Drawing.Color.White
        Me.Grouper1.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.Grouper1.BorderColor = System.Drawing.Color.Black
        Me.Grouper1.BorderThickness = 1.0!
        Me.Grouper1.Controls.Add(Me.PanelTask)
        Me.Grouper1.CustomGroupBoxColor = System.Drawing.Color.White
        Me.Grouper1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grouper1.GroupImage = Global.Umbrella.My.Resources.Resources.online_exam
        Me.Grouper1.GroupTitle = "Exam Info:"
        Me.Grouper1.Location = New System.Drawing.Point(0, 10)
        Me.Grouper1.Name = "Grouper1"
        Me.Grouper1.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.Grouper1.PaintGroupBox = False
        Me.Grouper1.RoundCorners = 10
        Me.Grouper1.ShadowColor = System.Drawing.Color.DarkGray
        Me.Grouper1.ShadowControl = False
        Me.Grouper1.ShadowThickness = 3
        Me.Grouper1.Size = New System.Drawing.Size(173, 137)
        Me.Grouper1.TabIndex = 2
        '
        'PanelTask
        '
        Me.PanelTask.Controls.Add(Me.txtexamcode)
        Me.PanelTask.Controls.Add(Me.Label2)
        Me.PanelTask.Controls.Add(Me.cmbdate)
        Me.PanelTask.Controls.Add(Me.Label1)
        Me.PanelTask.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTask.Location = New System.Drawing.Point(10, 25)
        Me.PanelTask.Name = "PanelTask"
        Me.PanelTask.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.PanelTask.Size = New System.Drawing.Size(153, 102)
        Me.PanelTask.TabIndex = 0
        '
        'txtexamcode
        '
        Me.txtexamcode.BackColor = System.Drawing.Color.White
        Me.txtexamcode.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtexamcode.Location = New System.Drawing.Point(23, 68)
        Me.txtexamcode.Name = "txtexamcode"
        Me.txtexamcode.ReadOnly = True
        Me.txtexamcode.Required = False
        Me.txtexamcode.ShowErrorIcon = False
        Me.txtexamcode.Size = New System.Drawing.Size(173, 21)
        Me.txtexamcode.TabIndex = 3
        Me.txtexamcode.TextBox = ""
        Me.txtexamcode.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtexamcode.WaterMark = "Examination Code..."
        Me.txtexamcode.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtexamcode.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexamcode.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Examination Code:"
        '
        'cmbdate
        '
        Me.cmbdate.FormatString = "d"
        Me.cmbdate.FormattingEnabled = True
        Me.cmbdate.Location = New System.Drawing.Point(23, 26)
        Me.cmbdate.Name = "cmbdate"
        Me.cmbdate.Size = New System.Drawing.Size(173, 21)
        Me.cmbdate.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Examination Date:"
        '
        'EGroupBox1
        '
        Me.EGroupBox1.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox1.BorderThickness = 1.0!
        Me.EGroupBox1.Controls.Add(Me.Panel1)
        Me.EGroupBox1.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.EGroupBox1.GroupImage = Global.Umbrella.My.Resources.Resources.task_icon
        Me.EGroupBox1.GroupTitle = "Tasks:"
        Me.EGroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.EGroupBox1.Name = "EGroupBox1"
        Me.EGroupBox1.Padding = New System.Windows.Forms.Padding(10, 30, 10, 10)
        Me.EGroupBox1.PaintGroupBox = False
        Me.EGroupBox1.RoundCorners = 10
        Me.EGroupBox1.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox1.ShadowControl = False
        Me.EGroupBox1.ShadowThickness = 3
        Me.EGroupBox1.Size = New System.Drawing.Size(173, 135)
        Me.EGroupBox1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnonlineexamination)
        Me.Panel1.Controls.Add(Me.btnstudentinfo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(153, 95)
        Me.Panel1.TabIndex = 0
        '
        'btnonlineexamination
        '
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnonlineexamination.CenterPtTracker = DesignerRectTracker1
        Me.btnonlineexamination.ColorFillSolid = System.Drawing.Color.AliceBlue
        Me.btnonlineexamination.Corners.All = CType(12, Short)
        Me.btnonlineexamination.Corners.LowerLeft = CType(12, Short)
        Me.btnonlineexamination.Corners.LowerRight = CType(12, Short)
        Me.btnonlineexamination.Corners.UpperLeft = CType(12, Short)
        Me.btnonlineexamination.Corners.UpperRight = CType(12, Short)
        Me.btnonlineexamination.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnonlineexamination.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnonlineexamination.FillType = ESAR_Controls.UIControls.Button.eButton.eFillType.Solid
        Me.btnonlineexamination.FocalPoints.CenterPtX = 0.5490196!
        Me.btnonlineexamination.FocalPoints.CenterPtY = 0.4468085!
        Me.btnonlineexamination.FocalPoints.FocusPtX = 0.0!
        Me.btnonlineexamination.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnonlineexamination.FocusPtTracker = DesignerRectTracker2
        Me.btnonlineexamination.ForeColor = System.Drawing.Color.Black
        Me.btnonlineexamination.Image = Global.Umbrella.My.Resources.Resources.online_exam
        Me.btnonlineexamination.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnonlineexamination.ImageIndex = 0
        Me.btnonlineexamination.Location = New System.Drawing.Point(0, 50)
        Me.btnonlineexamination.Name = "btnonlineexamination"
        Me.btnonlineexamination.Size = New System.Drawing.Size(153, 45)
        Me.btnonlineexamination.TabIndex = 1
        Me.btnonlineexamination.Text = "Online Examination"
        Me.btnonlineexamination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnonlineexamination.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnonlineexamination.TextShadowShow = False
        '
        'btnstudentinfo
        '
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnstudentinfo.CenterPtTracker = DesignerRectTracker3
        Me.btnstudentinfo.ColorFillSolid = System.Drawing.Color.AliceBlue
        Me.btnstudentinfo.Corners.All = CType(12, Short)
        Me.btnstudentinfo.Corners.LowerLeft = CType(12, Short)
        Me.btnstudentinfo.Corners.LowerRight = CType(12, Short)
        Me.btnstudentinfo.Corners.UpperLeft = CType(12, Short)
        Me.btnstudentinfo.Corners.UpperRight = CType(12, Short)
        Me.btnstudentinfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnstudentinfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnstudentinfo.FillType = ESAR_Controls.UIControls.Button.eButton.eFillType.Solid
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnstudentinfo.FocusPtTracker = DesignerRectTracker4
        Me.btnstudentinfo.ForeColor = System.Drawing.Color.Black
        Me.btnstudentinfo.Image = Global.Umbrella.My.Resources.Resources.student_registration
        Me.btnstudentinfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnstudentinfo.ImageIndex = 0
        Me.btnstudentinfo.Location = New System.Drawing.Point(0, 0)
        Me.btnstudentinfo.Name = "btnstudentinfo"
        Me.btnstudentinfo.Size = New System.Drawing.Size(153, 45)
        Me.btnstudentinfo.TabIndex = 0
        Me.btnstudentinfo.Text = "Student Info"
        Me.btnstudentinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnstudentinfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnstudentinfo.TextShadowShow = False
        '
        'ETabControlEx1
        '
        Me.ETabControlEx1.Controls.Add(Me.TabPage1)
        Me.ETabControlEx1.Controls.Add(Me.TabPage2)
        Me.ETabControlEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ETabControlEx1.Location = New System.Drawing.Point(5, 10)
        Me.ETabControlEx1.Name = "ETabControlEx1"
        Me.ETabControlEx1.SelectedIndex = 0
        Me.ETabControlEx1.Size = New System.Drawing.Size(1153, 660)
        Me.ETabControlEx1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.EGradientPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1145, 633)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'EGradientPanel1
        '
        Me.EGradientPanel1.Controls.Add(Me.PanelStudentInfo)
        Me.EGradientPanel1.Controls.Add(Me.RoundedPanel2)
        Me.EGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGradientPanel1.EndColor = System.Drawing.Color.RoyalBlue
        Me.EGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.EGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EGradientPanel1.Name = "EGradientPanel1"
        Me.EGradientPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.EGradientPanel1.Size = New System.Drawing.Size(1145, 633)
        Me.EGradientPanel1.StartColor = System.Drawing.Color.LightCyan
        Me.EGradientPanel1.TabIndex = 0
        '
        'PanelStudentInfo
        '
        Me.PanelStudentInfo.Controls.Add(Me.Panel4)
        Me.PanelStudentInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelStudentInfo.Location = New System.Drawing.Point(10, 70)
        Me.PanelStudentInfo.Name = "PanelStudentInfo"
        Me.PanelStudentInfo.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.PanelStudentInfo.Size = New System.Drawing.Size(1125, 553)
        Me.PanelStudentInfo.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel4.Controls.Add(Me.ETabStripStudentInfo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1125, 548)
        Me.Panel4.TabIndex = 0
        '
        'ETabStripStudentInfo
        '
        Me.ETabStripStudentInfo.AlwaysShowClose = False
        Me.ETabStripStudentInfo.AutoScroll = True
        Me.ETabStripStudentInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ETabStripStudentInfo.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ETabStripStudentInfo.Location = New System.Drawing.Point(0, 0)
        Me.ETabStripStudentInfo.Name = "ETabStripStudentInfo"
        Me.ETabStripStudentInfo.SelectedItem = Nothing
        Me.ETabStripStudentInfo.Size = New System.Drawing.Size(1125, 548)
        Me.ETabStripStudentInfo.TabIndex = 3
        '
        'RoundedPanel2
        '
        Me.RoundedPanel2.BorderRadius = 32
        Me.RoundedPanel2.Controls.Add(Me.Label3)
        Me.RoundedPanel2.Controls.Add(Me.btnlogoutstudentinfo)
        Me.RoundedPanel2.Controls.Add(Me.btnhidestudentinfo)
        Me.RoundedPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.RoundedPanel2.Location = New System.Drawing.Point(10, 10)
        Me.RoundedPanel2.Name = "RoundedPanel2"
        Me.RoundedPanel2.Padding = New System.Windows.Forms.Padding(10)
        Me.RoundedPanel2.Size = New System.Drawing.Size(1125, 60)
        Me.RoundedPanel2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = Global.Umbrella.My.Resources.Resources.student_registration
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(10, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(966, 40)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "    Student Info"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnlogoutstudentinfo
        '
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnlogoutstudentinfo.CenterPtTracker = DesignerRectTracker5
        Me.btnlogoutstudentinfo.Corners.All = CType(8, Short)
        Me.btnlogoutstudentinfo.Corners.LowerLeft = CType(8, Short)
        Me.btnlogoutstudentinfo.Corners.LowerRight = CType(8, Short)
        Me.btnlogoutstudentinfo.Corners.UpperLeft = CType(8, Short)
        Me.btnlogoutstudentinfo.Corners.UpperRight = CType(8, Short)
        Me.btnlogoutstudentinfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogoutstudentinfo.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnlogoutstudentinfo.FocalPoints.CenterPtX = 0.4444444!
        Me.btnlogoutstudentinfo.FocalPoints.CenterPtY = 0.4!
        Me.btnlogoutstudentinfo.FocalPoints.FocusPtX = 0.0!
        Me.btnlogoutstudentinfo.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnlogoutstudentinfo.FocusPtTracker = DesignerRectTracker6
        Me.btnlogoutstudentinfo.Image = Global.Umbrella.My.Resources.Resources.logout
        Me.btnlogoutstudentinfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogoutstudentinfo.ImageIndex = 0
        Me.btnlogoutstudentinfo.Location = New System.Drawing.Point(976, 10)
        Me.btnlogoutstudentinfo.Name = "btnlogoutstudentinfo"
        Me.btnlogoutstudentinfo.Size = New System.Drawing.Size(76, 40)
        Me.btnlogoutstudentinfo.TabIndex = 19
        Me.btnlogoutstudentinfo.Text = "Logout"
        Me.btnlogoutstudentinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogoutstudentinfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnhidestudentinfo
        '
        DesignerRectTracker7.IsActive = False
        DesignerRectTracker7.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker7.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnhidestudentinfo.CenterPtTracker = DesignerRectTracker7
        Me.btnhidestudentinfo.Corners.All = CType(8, Short)
        Me.btnhidestudentinfo.Corners.LowerLeft = CType(8, Short)
        Me.btnhidestudentinfo.Corners.LowerRight = CType(8, Short)
        Me.btnhidestudentinfo.Corners.UpperLeft = CType(8, Short)
        Me.btnhidestudentinfo.Corners.UpperRight = CType(8, Short)
        Me.btnhidestudentinfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhidestudentinfo.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnhidestudentinfo.FocalPoints.CenterPtX = 0.4444444!
        Me.btnhidestudentinfo.FocalPoints.CenterPtY = 0.4!
        Me.btnhidestudentinfo.FocalPoints.FocusPtX = 0.0!
        Me.btnhidestudentinfo.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker8.IsActive = False
        DesignerRectTracker8.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker8.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnhidestudentinfo.FocusPtTracker = DesignerRectTracker8
        Me.btnhidestudentinfo.Image = Global.Umbrella.My.Resources.Resources.collapseIcon
        Me.btnhidestudentinfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhidestudentinfo.ImageIndex = 0
        Me.btnhidestudentinfo.Location = New System.Drawing.Point(1052, 10)
        Me.btnhidestudentinfo.Name = "btnhidestudentinfo"
        Me.btnhidestudentinfo.Size = New System.Drawing.Size(63, 40)
        Me.btnhidestudentinfo.TabIndex = 18
        Me.btnhidestudentinfo.Text = "Hide"
        Me.btnhidestudentinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhidestudentinfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.EGradientPanel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1145, 633)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'EGradientPanel2
        '
        Me.EGradientPanel2.Controls.Add(Me.PanelExam)
        Me.EGradientPanel2.Controls.Add(Me.ERoundedPanel1)
        Me.EGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGradientPanel2.EndColor = System.Drawing.Color.RoyalBlue
        Me.EGradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.EGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EGradientPanel2.Name = "EGradientPanel2"
        Me.EGradientPanel2.Padding = New System.Windows.Forms.Padding(10)
        Me.EGradientPanel2.Size = New System.Drawing.Size(1145, 633)
        Me.EGradientPanel2.StartColor = System.Drawing.Color.LightCyan
        Me.EGradientPanel2.TabIndex = 1
        '
        'PanelExam
        '
        Me.PanelExam.Controls.Add(Me.Panel6)
        Me.PanelExam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelExam.Location = New System.Drawing.Point(10, 70)
        Me.PanelExam.Name = "PanelExam"
        Me.PanelExam.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.PanelExam.Size = New System.Drawing.Size(1125, 553)
        Me.PanelExam.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel6.Controls.Add(Me.ETabStripOnlineExamination)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1125, 548)
        Me.Panel6.TabIndex = 0
        '
        'ETabStripOnlineExamination
        '
        Me.ETabStripOnlineExamination.AlwaysShowClose = False
        Me.ETabStripOnlineExamination.AutoScroll = True
        Me.ETabStripOnlineExamination.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ETabStripOnlineExamination.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ETabStripOnlineExamination.Location = New System.Drawing.Point(0, 0)
        Me.ETabStripOnlineExamination.Name = "ETabStripOnlineExamination"
        Me.ETabStripOnlineExamination.SelectedItem = Nothing
        Me.ETabStripOnlineExamination.Size = New System.Drawing.Size(1125, 548)
        Me.ETabStripOnlineExamination.TabIndex = 3
        '
        'ERoundedPanel1
        '
        Me.ERoundedPanel1.BorderRadius = 32
        Me.ERoundedPanel1.Controls.Add(Me.Label4)
        Me.ERoundedPanel1.Controls.Add(Me.btnlogoutexam)
        Me.ERoundedPanel1.Controls.Add(Me.btnhideexam)
        Me.ERoundedPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ERoundedPanel1.Location = New System.Drawing.Point(10, 10)
        Me.ERoundedPanel1.Name = "ERoundedPanel1"
        Me.ERoundedPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.ERoundedPanel1.Size = New System.Drawing.Size(1125, 60)
        Me.ERoundedPanel1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Image = Global.Umbrella.My.Resources.Resources.online_exam
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(10, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(966, 40)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "    Online Examination"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnlogoutexam
        '
        DesignerRectTracker9.IsActive = False
        DesignerRectTracker9.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker9.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnlogoutexam.CenterPtTracker = DesignerRectTracker9
        Me.btnlogoutexam.Corners.All = CType(8, Short)
        Me.btnlogoutexam.Corners.LowerLeft = CType(8, Short)
        Me.btnlogoutexam.Corners.LowerRight = CType(8, Short)
        Me.btnlogoutexam.Corners.UpperLeft = CType(8, Short)
        Me.btnlogoutexam.Corners.UpperRight = CType(8, Short)
        Me.btnlogoutexam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogoutexam.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnlogoutexam.FocalPoints.CenterPtX = 0.4444444!
        Me.btnlogoutexam.FocalPoints.CenterPtY = 0.4!
        Me.btnlogoutexam.FocalPoints.FocusPtX = 0.0!
        Me.btnlogoutexam.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker10.IsActive = False
        DesignerRectTracker10.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker10.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnlogoutexam.FocusPtTracker = DesignerRectTracker10
        Me.btnlogoutexam.Image = Global.Umbrella.My.Resources.Resources.logout
        Me.btnlogoutexam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogoutexam.ImageIndex = 0
        Me.btnlogoutexam.Location = New System.Drawing.Point(976, 10)
        Me.btnlogoutexam.Name = "btnlogoutexam"
        Me.btnlogoutexam.Size = New System.Drawing.Size(76, 40)
        Me.btnlogoutexam.TabIndex = 19
        Me.btnlogoutexam.Text = "Logout"
        Me.btnlogoutexam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogoutexam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnhideexam
        '
        DesignerRectTracker11.IsActive = False
        DesignerRectTracker11.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker11.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnhideexam.CenterPtTracker = DesignerRectTracker11
        Me.btnhideexam.Corners.All = CType(8, Short)
        Me.btnhideexam.Corners.LowerLeft = CType(8, Short)
        Me.btnhideexam.Corners.LowerRight = CType(8, Short)
        Me.btnhideexam.Corners.UpperLeft = CType(8, Short)
        Me.btnhideexam.Corners.UpperRight = CType(8, Short)
        Me.btnhideexam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhideexam.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnhideexam.FocalPoints.CenterPtX = 0.4444444!
        Me.btnhideexam.FocalPoints.CenterPtY = 0.4!
        Me.btnhideexam.FocalPoints.FocusPtX = 0.0!
        Me.btnhideexam.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker12.IsActive = False
        DesignerRectTracker12.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker12.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnhideexam.FocusPtTracker = DesignerRectTracker12
        Me.btnhideexam.Image = Global.Umbrella.My.Resources.Resources.collapseIcon
        Me.btnhideexam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhideexam.ImageIndex = 0
        Me.btnhideexam.Location = New System.Drawing.Point(1052, 10)
        Me.btnhideexam.Name = "btnhideexam"
        Me.btnhideexam.Size = New System.Drawing.Size(63, 40)
        Me.btnhideexam.TabIndex = 18
        Me.btnhideexam.Text = "Hide"
        Me.btnhideexam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhideexam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'frmStudentMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 680)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.RoyalLight
        Me.Name = "frmStudentMainForm"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Grouper1.ResumeLayout(False)
        Me.PanelTask.ResumeLayout(False)
        Me.PanelTask.PerformLayout()
        Me.EGroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ETabControlEx1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.EGradientPanel1.ResumeLayout(False)
        Me.PanelStudentInfo.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.RoundedPanel2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.EGradientPanel2.ResumeLayout(False)
        Me.PanelExam.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ERoundedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Grouper1 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents PanelTask As System.Windows.Forms.Panel
    Friend WithEvents txtexamcode As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbdate As ESAR_Controls.UIControls.ComboBox.eComboBoxDateTime
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EGroupBox1 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnonlineexamination As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnstudentinfo As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents ETabControlEx1 As ESAR_Controls.UIControls.TabControl.eTabControlEx
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents EGradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents EGradientPanel2 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents RoundedPanel2 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents btnlogoutstudentinfo As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnhidestudentinfo As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents ERoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents btnlogoutexam As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnhideexam As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents PanelStudentInfo As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ETabStripStudentInfo As ESAR_Controls.UIControls.TabControl.eTabStrip
    Friend WithEvents PanelExam As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents ETabStripOnlineExamination As ESAR_Controls.UIControls.TabControl.eTabStrip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
