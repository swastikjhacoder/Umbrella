Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmObsolescenceInformation
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmObsolescenceInformation))
        Dim CBlendItems1 As ESAR_Controls.cBlendItems = New ESAR_Controls.cBlendItems
        Me.EGradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.EGroupBox1 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkdonotshow = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lnkobsolescencepolicy = New System.Windows.Forms.LinkLabel
        Me.Label3 = New System.Windows.Forms.Label
        Me.dgviewobsolescence = New System.Windows.Forms.DataGridView
        Me.clmservices = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmdate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ERoundedPanel6 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.ELabel6 = New ESAR_Controls.eLabel
        Me.EGradientPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.EGroupBox1.SuspendLayout()
        CType(Me.dgviewobsolescence, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.EGradientPanel1.Size = New System.Drawing.Size(769, 597)
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
        Me.Panel1.Size = New System.Drawing.Size(749, 517)
        Me.Panel1.TabIndex = 29
        '
        'EGroupBox1
        '
        Me.EGroupBox1.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox1.BorderThickness = 1.0!
        Me.EGroupBox1.Controls.Add(Me.Label5)
        Me.EGroupBox1.Controls.Add(Me.chkdonotshow)
        Me.EGroupBox1.Controls.Add(Me.Label4)
        Me.EGroupBox1.Controls.Add(Me.lnkobsolescencepolicy)
        Me.EGroupBox1.Controls.Add(Me.Label3)
        Me.EGroupBox1.Controls.Add(Me.dgviewobsolescence)
        Me.EGroupBox1.Controls.Add(Me.Label2)
        Me.EGroupBox1.Controls.Add(Me.Label1)
        Me.EGroupBox1.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox1.GroupImage = Nothing
        Me.EGroupBox1.GroupTitle = "Obsolescence Information:"
        Me.EGroupBox1.Location = New System.Drawing.Point(0, 5)
        Me.EGroupBox1.Name = "EGroupBox1"
        Me.EGroupBox1.Padding = New System.Windows.Forms.Padding(12, 25, 12, 10)
        Me.EGroupBox1.PaintGroupBox = False
        Me.EGroupBox1.RoundCorners = 10
        Me.EGroupBox1.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox1.ShadowControl = False
        Me.EGroupBox1.ShadowThickness = 3
        Me.EGroupBox1.Size = New System.Drawing.Size(749, 512)
        Me.EGroupBox1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 470)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(709, 26)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Checking this box will prevent this message appearing upon your daily login, howe" & _
            "ver, we will still see this message again " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "at 30 and 15 days prior to the disco" & _
            "ntinuous of these services."
        '
        'chkdonotshow
        '
        Me.chkdonotshow.AutoSize = True
        Me.chkdonotshow.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkdonotshow.Location = New System.Drawing.Point(20, 447)
        Me.chkdonotshow.Name = "chkdonotshow"
        Me.chkdonotshow.Size = New System.Drawing.Size(239, 17)
        Me.chkdonotshow.TabIndex = 53
        Me.chkdonotshow.Text = "Do not show this message again."
        Me.chkdonotshow.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(322, 420)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "for additional information."
        '
        'lnkobsolescencepolicy
        '
        Me.lnkobsolescencepolicy.AutoSize = True
        Me.lnkobsolescencepolicy.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkobsolescencepolicy.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkobsolescencepolicy.Location = New System.Drawing.Point(194, 420)
        Me.lnkobsolescencepolicy.Name = "lnkobsolescencepolicy"
        Me.lnkobsolescencepolicy.Size = New System.Drawing.Size(122, 13)
        Me.lnkobsolescencepolicy.TabIndex = 51
        Me.lnkobsolescencepolicy.TabStop = True
        Me.lnkobsolescencepolicy.Text = "Obsolescence Policy"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 420)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Please refer to the Umbrella"
        '
        'dgviewobsolescence
        '
        Me.dgviewobsolescence.AllowUserToAddRows = False
        Me.dgviewobsolescence.AllowUserToDeleteRows = False
        Me.dgviewobsolescence.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgviewobsolescence.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgviewobsolescence.BackgroundColor = System.Drawing.Color.White
        Me.dgviewobsolescence.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgviewobsolescence.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.dgviewobsolescence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgviewobsolescence.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmservices, Me.clmdate})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewobsolescence.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgviewobsolescence.Enabled = False
        Me.dgviewobsolescence.Location = New System.Drawing.Point(24, 156)
        Me.dgviewobsolescence.Name = "dgviewobsolescence"
        Me.dgviewobsolescence.ReadOnly = True
        Me.dgviewobsolescence.RowHeadersVisible = False
        Me.dgviewobsolescence.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgviewobsolescence.Size = New System.Drawing.Size(453, 261)
        Me.dgviewobsolescence.TabIndex = 45
        '
        'clmservices
        '
        Me.clmservices.FillWeight = 121.8274!
        Me.clmservices.HeaderText = "Services"
        Me.clmservices.Name = "clmservices"
        Me.clmservices.ReadOnly = True
        '
        'clmdate
        '
        Me.clmdate.FillWeight = 78.17259!
        Me.clmdate.HeaderText = "Date Obsolesced"
        Me.clmdate.Name = "clmdate"
        Me.clmdate.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(701, 78)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(564, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Please review this important information cocerning availability of Umbrella  Serv" & _
            "ices."
        '
        'ERoundedPanel6
        '
        Me.ERoundedPanel6.BackColor = System.Drawing.Color.Transparent
        Me.ERoundedPanel6.BorderRadius = 32
        Me.ERoundedPanel6.Controls.Add(Me.ELabel6)
        Me.ERoundedPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.ERoundedPanel6.Location = New System.Drawing.Point(10, 10)
        Me.ERoundedPanel6.Name = "ERoundedPanel6"
        Me.ERoundedPanel6.Padding = New System.Windows.Forms.Padding(10)
        Me.ERoundedPanel6.Size = New System.Drawing.Size(749, 60)
        Me.ERoundedPanel6.TabIndex = 28
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
        Me.ELabel6.Location = New System.Drawing.Point(446, 10)
        Me.ELabel6.MouseOverColor = System.Drawing.Color.Gray
        Me.ELabel6.Name = "ELabel6"
        Me.ELabel6.ShadowState = True
        Me.ELabel6.Size = New System.Drawing.Size(293, 40)
        Me.ELabel6.TabIndex = 34
        Me.ELabel6.Text = "Obsolescence Information"
        '
        'frmObsolescenceInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(769, 597)
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
        Me.Name = "frmObsolescenceInformation"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Obsolescence Information"
        Me.EGradientPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.EGroupBox1.ResumeLayout(False)
        Me.EGroupBox1.PerformLayout()
        CType(Me.dgviewobsolescence, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ERoundedPanel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EGradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents EGroupBox1 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ERoundedPanel6 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents ELabel6 As ESAR_Controls.eLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkdonotshow As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lnkobsolescencepolicy As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgviewobsolescence As System.Windows.Forms.DataGridView
    Friend WithEvents clmservices As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
