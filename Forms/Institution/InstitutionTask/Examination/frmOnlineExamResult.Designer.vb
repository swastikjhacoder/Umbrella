Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOnlineExamResult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOnlineExamResult))
        Me.EGradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.EGroupBox2 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.lblname = New System.Windows.Forms.Label
        Me.lblregno = New System.Windows.Forms.Label
        Me.EProfilePic1 = New ESAR_Controls.UIControls.PictureBox.eProfilePic
        Me.EGroupBox1 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.EXpProgressBar1 = New ESAR_Controls.UIControls.ProgressBar.eXpProgressBar
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblrightans = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblqsnattempted = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbltotalqsn = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblduration = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblexamtime = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblexamdate = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblexamcode = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.EGradientPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.EGroupBox2.SuspendLayout()
        CType(Me.EProfilePic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EGroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EGradientPanel1
        '
        Me.EGradientPanel1.Controls.Add(Me.SplitContainer1)
        Me.EGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGradientPanel1.EndColor = System.Drawing.Color.RoyalBlue
        Me.EGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.EGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EGradientPanel1.Name = "EGradientPanel1"
        Me.EGradientPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.EGradientPanel1.Size = New System.Drawing.Size(442, 320)
        Me.EGradientPanel1.StartColor = System.Drawing.Color.LightCyan
        Me.EGradientPanel1.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(10, 10)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EGroupBox2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EGroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(422, 300)
        Me.SplitContainer1.SplitterDistance = 140
        Me.SplitContainer1.TabIndex = 0
        '
        'EGroupBox2
        '
        Me.EGroupBox2.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox2.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox2.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox2.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox2.BorderThickness = 1.0!
        Me.EGroupBox2.Controls.Add(Me.lblname)
        Me.EGroupBox2.Controls.Add(Me.lblregno)
        Me.EGroupBox2.Controls.Add(Me.EProfilePic1)
        Me.EGroupBox2.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox2.GroupImage = Global.Umbrella.My.Resources.Resources.student_registration
        Me.EGroupBox2.GroupTitle = "Student:"
        Me.EGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.EGroupBox2.Name = "EGroupBox2"
        Me.EGroupBox2.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.EGroupBox2.PaintGroupBox = False
        Me.EGroupBox2.RoundCorners = 10
        Me.EGroupBox2.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox2.ShadowControl = False
        Me.EGroupBox2.ShadowThickness = 3
        Me.EGroupBox2.Size = New System.Drawing.Size(140, 300)
        Me.EGroupBox2.TabIndex = 0
        '
        'lblname
        '
        Me.lblname.Location = New System.Drawing.Point(23, 185)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(140, 90)
        Me.lblname.TabIndex = 3
        '
        'lblregno
        '
        Me.lblregno.AutoSize = True
        Me.lblregno.Location = New System.Drawing.Point(23, 158)
        Me.lblregno.Name = "lblregno"
        Me.lblregno.Size = New System.Drawing.Size(0, 13)
        Me.lblregno.TabIndex = 2
        '
        'EProfilePic1
        '
        Me.EProfilePic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EProfilePic1.Image = CType(resources.GetObject("EProfilePic1.Image"), System.Drawing.Image)
        Me.EProfilePic1.ImageSizeLimit = CType(-1, Long)
        Me.EProfilePic1.Location = New System.Drawing.Point(27, 33)
        Me.EProfilePic1.Name = "EProfilePic1"
        Me.EProfilePic1.ReadOnly = False
        Me.EProfilePic1.Size = New System.Drawing.Size(135, 111)
        Me.EProfilePic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EProfilePic1.TabIndex = 1
        Me.EProfilePic1.TabStop = False
        '
        'EGroupBox1
        '
        Me.EGroupBox1.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox1.BorderThickness = 1.0!
        Me.EGroupBox1.Controls.Add(Me.GroupBox3)
        Me.EGroupBox1.Controls.Add(Me.GroupBox2)
        Me.EGroupBox1.Controls.Add(Me.GroupBox1)
        Me.EGroupBox1.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox1.GroupImage = Global.Umbrella.My.Resources.Resources.online_exam
        Me.EGroupBox1.GroupTitle = "Result:"
        Me.EGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.EGroupBox1.Name = "EGroupBox1"
        Me.EGroupBox1.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.EGroupBox1.PaintGroupBox = False
        Me.EGroupBox1.RoundCorners = 10
        Me.EGroupBox1.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox1.ShadowControl = False
        Me.EGroupBox1.ShadowThickness = 3
        Me.EGroupBox1.Size = New System.Drawing.Size(278, 300)
        Me.EGroupBox1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.EXpProgressBar1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(10, 244)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(12, 3, 12, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(258, 46)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Score:"
        '
        'EXpProgressBar1
        '
        Me.EXpProgressBar1.ColorBackGround = System.Drawing.Color.White
        Me.EXpProgressBar1.ColorBarBorder = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EXpProgressBar1.ColorBarCenter = System.Drawing.Color.MediumPurple
        Me.EXpProgressBar1.ColorText = System.Drawing.Color.Black
        Me.EXpProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EXpProgressBar1.GradientStyle = ESAR_Controls.UIControls.ProgressBar.GradientMode.VerticalCenter
        Me.EXpProgressBar1.Location = New System.Drawing.Point(12, 17)
        Me.EXpProgressBar1.Name = "EXpProgressBar1"
        Me.EXpProgressBar1.Position = 50
        Me.EXpProgressBar1.PositionMax = 100
        Me.EXpProgressBar1.PositionMin = 0
        Me.EXpProgressBar1.Size = New System.Drawing.Size(234, 26)
        Me.EXpProgressBar1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblrightans)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblqsnattempted)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lbltotalqsn)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(10, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'lblrightans
        '
        Me.lblrightans.AutoSize = True
        Me.lblrightans.Location = New System.Drawing.Point(148, 70)
        Me.lblrightans.Name = "lblrightans"
        Me.lblrightans.Size = New System.Drawing.Size(0, 13)
        Me.lblrightans.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Right Ans:"
        '
        'lblqsnattempted
        '
        Me.lblqsnattempted.AutoSize = True
        Me.lblqsnattempted.Location = New System.Drawing.Point(148, 43)
        Me.lblqsnattempted.Name = "lblqsnattempted"
        Me.lblqsnattempted.Size = New System.Drawing.Size(0, 13)
        Me.lblqsnattempted.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Qsn Attempted:"
        '
        'lbltotalqsn
        '
        Me.lbltotalqsn.AutoSize = True
        Me.lbltotalqsn.Location = New System.Drawing.Point(148, 17)
        Me.lbltotalqsn.Name = "lbltotalqsn"
        Me.lbltotalqsn.Size = New System.Drawing.Size(0, 13)
        Me.lbltotalqsn.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Total Qsn:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblduration)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblexamtime)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblexamdate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblexamcode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(10, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblduration
        '
        Me.lblduration.AutoSize = True
        Me.lblduration.Location = New System.Drawing.Point(148, 97)
        Me.lblduration.Name = "lblduration"
        Me.lblduration.Size = New System.Drawing.Size(0, 13)
        Me.lblduration.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Duration:"
        '
        'lblexamtime
        '
        Me.lblexamtime.AutoSize = True
        Me.lblexamtime.Location = New System.Drawing.Point(148, 70)
        Me.lblexamtime.Name = "lblexamtime"
        Me.lblexamtime.Size = New System.Drawing.Size(0, 13)
        Me.lblexamtime.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Exam Time:"
        '
        'lblexamdate
        '
        Me.lblexamdate.AutoSize = True
        Me.lblexamdate.Location = New System.Drawing.Point(148, 43)
        Me.lblexamdate.Name = "lblexamdate"
        Me.lblexamdate.Size = New System.Drawing.Size(0, 13)
        Me.lblexamdate.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Exam Date:"
        '
        'lblexamcode
        '
        Me.lblexamcode.AutoSize = True
        Me.lblexamcode.Location = New System.Drawing.Point(148, 17)
        Me.lblexamcode.Name = "lblexamcode"
        Me.lblexamcode.Size = New System.Drawing.Size(0, 13)
        Me.lblexamcode.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Exam Code:"
        '
        'frmOnlineExamResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(442, 320)
        Me.Controls.Add(Me.EGradientPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.RoyalLight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOnlineExamResult"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Online Examination Result"
        Me.EGradientPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.EGroupBox2.ResumeLayout(False)
        Me.EGroupBox2.PerformLayout()
        CType(Me.EProfilePic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EGroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EGradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EGroupBox2 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblregno As System.Windows.Forms.Label
    Friend WithEvents EProfilePic1 As ESAR_Controls.UIControls.PictureBox.eProfilePic
    Friend WithEvents EGroupBox1 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblrightans As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblqsnattempted As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltotalqsn As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblduration As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblexamtime As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblexamdate As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblexamcode As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents EXpProgressBar1 As ESAR_Controls.UIControls.ProgressBar.eXpProgressBar
End Class
