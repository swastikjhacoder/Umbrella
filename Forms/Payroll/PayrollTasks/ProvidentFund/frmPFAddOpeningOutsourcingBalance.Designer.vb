Imports Umbrella.UIControls
Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPFAddOpeningOutsourcingBalance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPFAddOpeningOutsourcingBalance))
        Dim DesignerRectTracker1 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker2 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim CBlendItems1 As ESAR_Controls.cBlendItems = New ESAR_Controls.cBlendItems
        Me.EGradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ERoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.cmbperiod = New ESAR_Controls.UIControls.ComboBox.eComboBoxIcon
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtoutstandingbal = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtopeningbal = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtname = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.cmbregno = New ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.RoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.btnhelp = New ESAR_Controls.UIControls.Button.eButton
        Me.ELabel1 = New ESAR_Controls.eLabel
        Me.EGradientPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ERoundedPanel1.SuspendLayout()
        Me.RoundedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EGradientPanel1
        '
        Me.EGradientPanel1.Controls.Add(Me.Panel1)
        Me.EGradientPanel1.Controls.Add(Me.RoundedPanel1)
        Me.EGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGradientPanel1.EndColor = System.Drawing.Color.RoyalBlue
        Me.EGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.EGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EGradientPanel1.Name = "EGradientPanel1"
        Me.EGradientPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.EGradientPanel1.Size = New System.Drawing.Size(839, 556)
        Me.EGradientPanel1.StartColor = System.Drawing.Color.LightCyan
        Me.EGradientPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.ERoundedPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(819, 476)
        Me.Panel1.TabIndex = 27
        '
        'ERoundedPanel1
        '
        Me.ERoundedPanel1.BackColor = System.Drawing.Color.White
        Me.ERoundedPanel1.BorderRadius = 32
        Me.ERoundedPanel1.Controls.Add(Me.cmbperiod)
        Me.ERoundedPanel1.Controls.Add(Me.txtoutstandingbal)
        Me.ERoundedPanel1.Controls.Add(Me.txtopeningbal)
        Me.ERoundedPanel1.Controls.Add(Me.Label5)
        Me.ERoundedPanel1.Controls.Add(Me.Label4)
        Me.ERoundedPanel1.Controls.Add(Me.txtname)
        Me.ERoundedPanel1.Controls.Add(Me.cmbregno)
        Me.ERoundedPanel1.Controls.Add(Me.Label2)
        Me.ERoundedPanel1.Controls.Add(Me.Label1)
        Me.ERoundedPanel1.Controls.Add(Me.Label3)
        Me.ERoundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel1.Location = New System.Drawing.Point(0, 5)
        Me.ERoundedPanel1.Name = "ERoundedPanel1"
        Me.ERoundedPanel1.Size = New System.Drawing.Size(819, 471)
        Me.ERoundedPanel1.TabIndex = 2
        '
        'cmbperiod
        '
        Me.cmbperiod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbperiod.FormattingEnabled = True
        Me.cmbperiod.ImageList = Me.ImageList1
        Me.cmbperiod.Location = New System.Drawing.Point(175, 73)
        Me.cmbperiod.Name = "cmbperiod"
        Me.cmbperiod.Size = New System.Drawing.Size(245, 22)
        Me.cmbperiod.TabIndex = 2
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "financial.png")
        '
        'txtoutstandingbal
        '
        Me.txtoutstandingbal.BackColor = System.Drawing.Color.White
        Me.txtoutstandingbal.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtoutstandingbal.Location = New System.Drawing.Point(175, 128)
        Me.txtoutstandingbal.Name = "txtoutstandingbal"
        Me.txtoutstandingbal.Required = False
        Me.txtoutstandingbal.ShowErrorIcon = False
        Me.txtoutstandingbal.Size = New System.Drawing.Size(79, 21)
        Me.txtoutstandingbal.TabIndex = 4
        Me.txtoutstandingbal.TextBox = ""
        Me.txtoutstandingbal.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtoutstandingbal.WaterMark = "0.00"
        Me.txtoutstandingbal.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtoutstandingbal.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoutstandingbal.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtopeningbal
        '
        Me.txtopeningbal.BackColor = System.Drawing.Color.White
        Me.txtopeningbal.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtopeningbal.Location = New System.Drawing.Point(175, 101)
        Me.txtopeningbal.Name = "txtopeningbal"
        Me.txtopeningbal.Required = False
        Me.txtopeningbal.ShowErrorIcon = False
        Me.txtopeningbal.Size = New System.Drawing.Size(79, 21)
        Me.txtopeningbal.TabIndex = 3
        Me.txtopeningbal.TextBox = ""
        Me.txtopeningbal.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtopeningbal.WaterMark = "0.00"
        Me.txtopeningbal.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtopeningbal.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtopeningbal.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Outstanding Advance:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Opening Balance:"
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.White
        Me.txtname.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtname.Location = New System.Drawing.Point(175, 46)
        Me.txtname.Name = "txtname"
        Me.txtname.Required = False
        Me.txtname.ShowErrorIcon = False
        Me.txtname.Size = New System.Drawing.Size(245, 21)
        Me.txtname.TabIndex = 1
        Me.txtname.TextBox = ""
        Me.txtname.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtname.WaterMark = "Employee Name"
        Me.txtname.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtname.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'cmbregno
        '
        Me.cmbregno.FormattingEnabled = True
        Me.cmbregno.InstantBinding = True
        Me.cmbregno.Location = New System.Drawing.Point(175, 19)
        Me.cmbregno.Name = "cmbregno"
        Me.cmbregno.Size = New System.Drawing.Size(126, 21)
        Me.cmbregno.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Employee Code:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Period:"
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.RoundedPanel1.BorderRadius = 32
        Me.RoundedPanel1.Controls.Add(Me.btnhelp)
        Me.RoundedPanel1.Controls.Add(Me.ELabel1)
        Me.RoundedPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RoundedPanel1.Location = New System.Drawing.Point(10, 10)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.RoundedPanel1.Size = New System.Drawing.Size(819, 60)
        Me.RoundedPanel1.TabIndex = 26
        '
        'btnhelp
        '
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnhelp.CenterPtTracker = DesignerRectTracker1
        Me.btnhelp.ColorFillSolid = System.Drawing.Color.White
        Me.btnhelp.Corners.All = CType(-1, Short)
        Me.btnhelp.Corners.LowerLeft = CType(20, Short)
        Me.btnhelp.Corners.LowerRight = CType(12, Short)
        Me.btnhelp.Corners.UpperLeft = CType(12, Short)
        Me.btnhelp.Corners.UpperRight = CType(20, Short)
        Me.btnhelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhelp.Dock = System.Windows.Forms.DockStyle.Left
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnhelp.FocusPtTracker = DesignerRectTracker2
        Me.btnhelp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhelp.Image = Global.Umbrella.My.Resources.Resources.help
        Me.btnhelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhelp.ImageIndex = 0
        Me.btnhelp.Location = New System.Drawing.Point(10, 10)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(63, 40)
        Me.btnhelp.TabIndex = 89
        Me.btnhelp.Text = "Help"
        Me.btnhelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhelp.TextShadowShow = False
        '
        'ELabel1
        '
        Me.ELabel1.AutoFit = True
        Me.ELabel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ELabel1.Feather = 255
        Me.ELabel1.FeatherState = False
        Me.ELabel1.FillType = ESAR_Controls.eLabel.eFillType.GradientLinear
        Me.ELabel1.ForeColor = System.Drawing.Color.LightSteelBlue
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0.0!, 0.113879!, 0.6370107!, 0.9252669!, 1.0!}
        Me.ELabel1.ForeColorBlend = CBlendItems1
        Me.ELabel1.Glow = 0
        Me.ELabel1.GlowColor = System.Drawing.Color.RoyalBlue
        Me.ELabel1.Location = New System.Drawing.Point(389, 10)
        Me.ELabel1.MouseOverColor = System.Drawing.Color.Gray
        Me.ELabel1.Name = "ELabel1"
        Me.ELabel1.ShadowState = True
        Me.ELabel1.Size = New System.Drawing.Size(420, 40)
        Me.ELabel1.TabIndex = 34
        Me.ELabel1.Text = "Opening Balance/ Outstanding Advance"
        '
        'frmPFAddOpeningOutsourcingBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(839, 556)
        Me.ControlBox = False
        Me.Controls.Add(Me.EGradientPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.Custom
        Me.Name = "frmPFAddOpeningOutsourcingBalance"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opening Balance/ Outstanding Advance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.EGradientPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ERoundedPanel1.ResumeLayout(False)
        Me.ERoundedPanel1.PerformLayout()
        Me.RoundedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EGradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents RoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents ELabel1 As ESAR_Controls.eLabel
    Friend WithEvents btnhelp As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ERoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents txtoutstandingbal As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtopeningbal As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtname As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents cmbregno As ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbperiod As ESAR_Controls.UIControls.ComboBox.eComboBoxIcon
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
