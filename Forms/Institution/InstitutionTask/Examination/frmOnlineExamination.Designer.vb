Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOnlineExamination
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOnlineExamination))
        Dim DesignerRectTracker2 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker3 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker4 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker5 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker6 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Me.EGradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.EGroupBox1 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ERoundedPanel2 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.btnstart = New ESAR_Controls.UIControls.Button.eButton
        Me.lblduration = New System.Windows.Forms.Label
        Me.lblexamtime = New System.Windows.Forms.Label
        Me.lblexamdate = New System.Windows.Forms.Label
        Me.lblexamcode = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnprev = New ESAR_Controls.UIControls.Button.eButton
        Me.btnnext = New ESAR_Controls.UIControls.Button.eButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.ERoundedPanel3 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.rbtnans4 = New System.Windows.Forms.RadioButton
        Me.rbtnans3 = New System.Windows.Forms.RadioButton
        Me.rbtnans2 = New System.Windows.Forms.RadioButton
        Me.rbtnans1 = New System.Windows.Forms.RadioButton
        Me.lblqsn = New System.Windows.Forms.Label
        Me.ERoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.lblregno = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbltime = New System.Windows.Forms.Label
        Me.tmrCountdown = New System.Windows.Forms.Timer(Me.components)
        Me.EGradientPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.EGroupBox1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ERoundedPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ERoundedPanel3.SuspendLayout()
        Me.ERoundedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EGradientPanel1
        '
        Me.EGradientPanel1.Controls.Add(Me.Panel1)
        Me.EGradientPanel1.Controls.Add(Me.ERoundedPanel1)
        Me.EGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGradientPanel1.EndColor = System.Drawing.Color.RoyalBlue
        Me.EGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.EGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EGradientPanel1.Name = "EGradientPanel1"
        Me.EGradientPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.EGradientPanel1.Size = New System.Drawing.Size(1125, 548)
        Me.EGradientPanel1.StartColor = System.Drawing.Color.LightCyan
        Me.EGradientPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.EGroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(1105, 474)
        Me.Panel1.TabIndex = 1
        '
        'EGroupBox1
        '
        Me.EGroupBox1.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox1.BorderThickness = 1.0!
        Me.EGroupBox1.Controls.Add(Me.SplitContainer1)
        Me.EGroupBox1.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox1.GroupImage = Global.Umbrella.My.Resources.Resources.online_exam
        Me.EGroupBox1.GroupTitle = "Exam Code: "
        Me.EGroupBox1.Location = New System.Drawing.Point(0, 10)
        Me.EGroupBox1.Name = "EGroupBox1"
        Me.EGroupBox1.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.EGroupBox1.PaintGroupBox = False
        Me.EGroupBox1.RoundCorners = 10
        Me.EGroupBox1.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox1.ShadowControl = False
        Me.EGroupBox1.ShadowThickness = 3
        Me.EGroupBox1.Size = New System.Drawing.Size(1105, 464)
        Me.EGroupBox1.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(10, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ERoundedPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1085, 429)
        Me.SplitContainer1.SplitterDistance = 120
        Me.SplitContainer1.TabIndex = 0
        '
        'ERoundedPanel2
        '
        Me.ERoundedPanel2.BorderRadius = 32
        Me.ERoundedPanel2.Controls.Add(Me.btnstart)
        Me.ERoundedPanel2.Controls.Add(Me.lblduration)
        Me.ERoundedPanel2.Controls.Add(Me.lblexamtime)
        Me.ERoundedPanel2.Controls.Add(Me.lblexamdate)
        Me.ERoundedPanel2.Controls.Add(Me.lblexamcode)
        Me.ERoundedPanel2.Controls.Add(Me.Label4)
        Me.ERoundedPanel2.Controls.Add(Me.Label3)
        Me.ERoundedPanel2.Controls.Add(Me.Label2)
        Me.ERoundedPanel2.Controls.Add(Me.Label1)
        Me.ERoundedPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel2.Location = New System.Drawing.Point(0, 0)
        Me.ERoundedPanel2.Name = "ERoundedPanel2"
        Me.ERoundedPanel2.Size = New System.Drawing.Size(1085, 120)
        Me.ERoundedPanel2.TabIndex = 0
        '
        'btnstart
        '
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnstart.CenterPtTracker = DesignerRectTracker1
        Me.btnstart.Corners.All = CType(20, Short)
        Me.btnstart.Corners.LowerLeft = CType(20, Short)
        Me.btnstart.Corners.LowerRight = CType(20, Short)
        Me.btnstart.Corners.UpperLeft = CType(20, Short)
        Me.btnstart.Corners.UpperRight = CType(20, Short)
        Me.btnstart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnstart.FocalPoints.CenterPtX = 0.4888889!
        Me.btnstart.FocalPoints.CenterPtY = 0.625!
        Me.btnstart.FocalPoints.FocusPtX = 0.0!
        Me.btnstart.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnstart.FocusPtTracker = DesignerRectTracker2
        Me.btnstart.Image = Global.Umbrella.My.Resources.Resources.start
        Me.btnstart.ImageIndex = 0
        Me.btnstart.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnstart.Location = New System.Drawing.Point(924, 70)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(122, 40)
        Me.btnstart.TabIndex = 11
        Me.btnstart.Text = "START"
        Me.btnstart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnstart.TextShadowShow = False
        '
        'lblduration
        '
        Me.lblduration.AutoSize = True
        Me.lblduration.Location = New System.Drawing.Point(142, 97)
        Me.lblduration.Name = "lblduration"
        Me.lblduration.Size = New System.Drawing.Size(0, 13)
        Me.lblduration.TabIndex = 10
        '
        'lblexamtime
        '
        Me.lblexamtime.AutoSize = True
        Me.lblexamtime.Location = New System.Drawing.Point(142, 70)
        Me.lblexamtime.Name = "lblexamtime"
        Me.lblexamtime.Size = New System.Drawing.Size(0, 13)
        Me.lblexamtime.TabIndex = 9
        '
        'lblexamdate
        '
        Me.lblexamdate.AutoSize = True
        Me.lblexamdate.Location = New System.Drawing.Point(142, 43)
        Me.lblexamdate.Name = "lblexamdate"
        Me.lblexamdate.Size = New System.Drawing.Size(0, 13)
        Me.lblexamdate.TabIndex = 8
        '
        'lblexamcode
        '
        Me.lblexamcode.AutoSize = True
        Me.lblexamcode.Location = New System.Drawing.Point(142, 16)
        Me.lblexamcode.Name = "lblexamcode"
        Me.lblexamcode.Size = New System.Drawing.Size(0, 13)
        Me.lblexamcode.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Duration:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Exam Time:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Exam Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Exam Code:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnprev)
        Me.Panel3.Controls.Add(Me.btnnext)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 260)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(0, 5, 27, 5)
        Me.Panel3.Size = New System.Drawing.Size(1085, 45)
        Me.Panel3.TabIndex = 1
        '
        'btnprev
        '
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnprev.CenterPtTracker = DesignerRectTracker3
        Me.btnprev.Corners.All = CType(12, Short)
        Me.btnprev.Corners.LowerLeft = CType(12, Short)
        Me.btnprev.Corners.LowerRight = CType(12, Short)
        Me.btnprev.Corners.UpperLeft = CType(12, Short)
        Me.btnprev.Corners.UpperRight = CType(12, Short)
        Me.btnprev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprev.FocalPoints.CenterPtX = 0.522388!
        Me.btnprev.FocalPoints.CenterPtY = 0.44!
        Me.btnprev.FocalPoints.FocusPtX = 0.0!
        Me.btnprev.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnprev.FocusPtTracker = DesignerRectTracker4
        Me.btnprev.Image = Global.Umbrella.My.Resources.Resources._next
        Me.btnprev.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnprev.ImageIndex = 0
        Me.btnprev.Location = New System.Drawing.Point(1206, 5)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(101, 32)
        Me.btnprev.TabIndex = 3
        Me.btnprev.Text = "Prev"
        Me.btnprev.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnprev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnprev.Visible = False
        '
        'btnnext
        '
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnnext.CenterPtTracker = DesignerRectTracker5
        Me.btnnext.Corners.All = CType(12, Short)
        Me.btnnext.Corners.LowerLeft = CType(12, Short)
        Me.btnnext.Corners.LowerRight = CType(12, Short)
        Me.btnnext.Corners.UpperLeft = CType(12, Short)
        Me.btnnext.Corners.UpperRight = CType(12, Short)
        Me.btnnext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnext.FocalPoints.CenterPtX = 0.4814815!
        Me.btnnext.FocalPoints.CenterPtY = 0.88!
        Me.btnnext.FocalPoints.FocusPtX = 0.0!
        Me.btnnext.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnnext.FocusPtTracker = DesignerRectTracker6
        Me.btnnext.Image = Global.Umbrella.My.Resources.Resources._next
        Me.btnnext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnnext.ImageIndex = 0
        Me.btnnext.Location = New System.Drawing.Point(1316, 5)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(101, 32)
        Me.btnnext.TabIndex = 2
        Me.btnnext.Text = "Next"
        Me.btnnext.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnnext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnnext.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ERoundedPanel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1085, 260)
        Me.Panel2.TabIndex = 0
        '
        'ERoundedPanel3
        '
        Me.ERoundedPanel3.BorderRadius = 32
        Me.ERoundedPanel3.Controls.Add(Me.rbtnans4)
        Me.ERoundedPanel3.Controls.Add(Me.rbtnans3)
        Me.ERoundedPanel3.Controls.Add(Me.rbtnans2)
        Me.ERoundedPanel3.Controls.Add(Me.rbtnans1)
        Me.ERoundedPanel3.Controls.Add(Me.lblqsn)
        Me.ERoundedPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel3.Location = New System.Drawing.Point(0, 0)
        Me.ERoundedPanel3.Name = "ERoundedPanel3"
        Me.ERoundedPanel3.Size = New System.Drawing.Size(1085, 260)
        Me.ERoundedPanel3.TabIndex = 0
        '
        'rbtnans4
        '
        Me.rbtnans4.AutoSize = True
        Me.rbtnans4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnans4.Location = New System.Drawing.Point(125, 174)
        Me.rbtnans4.Name = "rbtnans4"
        Me.rbtnans4.Size = New System.Drawing.Size(14, 13)
        Me.rbtnans4.TabIndex = 4
        Me.rbtnans4.TabStop = True
        Me.rbtnans4.UseVisualStyleBackColor = True
        Me.rbtnans4.Visible = False
        '
        'rbtnans3
        '
        Me.rbtnans3.AutoSize = True
        Me.rbtnans3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnans3.Location = New System.Drawing.Point(125, 145)
        Me.rbtnans3.Name = "rbtnans3"
        Me.rbtnans3.Size = New System.Drawing.Size(14, 13)
        Me.rbtnans3.TabIndex = 3
        Me.rbtnans3.TabStop = True
        Me.rbtnans3.UseVisualStyleBackColor = True
        Me.rbtnans3.Visible = False
        '
        'rbtnans2
        '
        Me.rbtnans2.AutoSize = True
        Me.rbtnans2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnans2.Location = New System.Drawing.Point(125, 116)
        Me.rbtnans2.Name = "rbtnans2"
        Me.rbtnans2.Size = New System.Drawing.Size(14, 13)
        Me.rbtnans2.TabIndex = 2
        Me.rbtnans2.TabStop = True
        Me.rbtnans2.UseVisualStyleBackColor = True
        Me.rbtnans2.Visible = False
        '
        'rbtnans1
        '
        Me.rbtnans1.AutoSize = True
        Me.rbtnans1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnans1.Location = New System.Drawing.Point(125, 87)
        Me.rbtnans1.Name = "rbtnans1"
        Me.rbtnans1.Size = New System.Drawing.Size(14, 13)
        Me.rbtnans1.TabIndex = 1
        Me.rbtnans1.TabStop = True
        Me.rbtnans1.UseVisualStyleBackColor = True
        Me.rbtnans1.Visible = False
        '
        'lblqsn
        '
        Me.lblqsn.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqsn.Location = New System.Drawing.Point(28, 16)
        Me.lblqsn.Name = "lblqsn"
        Me.lblqsn.Size = New System.Drawing.Size(1419, 54)
        Me.lblqsn.TabIndex = 0
        Me.lblqsn.Visible = False
        '
        'ERoundedPanel1
        '
        Me.ERoundedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.ERoundedPanel1.BorderRadius = 32
        Me.ERoundedPanel1.Controls.Add(Me.lblregno)
        Me.ERoundedPanel1.Controls.Add(Me.Label5)
        Me.ERoundedPanel1.Controls.Add(Me.lbltime)
        Me.ERoundedPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ERoundedPanel1.Location = New System.Drawing.Point(10, 10)
        Me.ERoundedPanel1.Name = "ERoundedPanel1"
        Me.ERoundedPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.ERoundedPanel1.Size = New System.Drawing.Size(1105, 54)
        Me.ERoundedPanel1.TabIndex = 0
        '
        'lblregno
        '
        Me.lblregno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblregno.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblregno.Image = Global.Umbrella.My.Resources.Resources.student_registration
        Me.lblregno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblregno.Location = New System.Drawing.Point(10, 10)
        Me.lblregno.Name = "lblregno"
        Me.lblregno.Size = New System.Drawing.Size(920, 34)
        Me.lblregno.TabIndex = 4
        Me.lblregno.Text = "   Registration No: "
        Me.lblregno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(930, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 34)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Time: "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbltime
        '
        Me.lbltime.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbltime.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbltime.Location = New System.Drawing.Point(1006, 10)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(89, 34)
        Me.lbltime.TabIndex = 1
        Me.lbltime.Text = "00:00"
        Me.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrCountdown
        '
        Me.tmrCountdown.Interval = 1000
        '
        'frmOnlineExamination
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1125, 548)
        Me.ControlBox = False
        Me.Controls.Add(Me.EGradientPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.RoyalLight
        Me.Name = "frmOnlineExamination"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Online Examination"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.EGradientPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.EGroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ERoundedPanel2.ResumeLayout(False)
        Me.ERoundedPanel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ERoundedPanel3.ResumeLayout(False)
        Me.ERoundedPanel3.PerformLayout()
        Me.ERoundedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EGradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents ERoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents EGroupBox1 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ERoundedPanel2 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tmrCountdown As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblduration As System.Windows.Forms.Label
    Friend WithEvents lblexamtime As System.Windows.Forms.Label
    Friend WithEvents lblexamdate As System.Windows.Forms.Label
    Friend WithEvents lblexamcode As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnstart As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents lblregno As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ERoundedPanel3 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents btnprev As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnnext As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents rbtnans4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnans3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnans2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnans1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblqsn As System.Windows.Forms.Label
End Class
