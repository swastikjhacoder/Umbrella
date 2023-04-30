Imports Umbrella.UIControls
Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculateCharges
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalculateCharges))
        Dim DesignerRectTracker1 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
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
        Dim CBlendItems1 As ESAR_Controls.cBlendItems = New ESAR_Controls.cBlendItems
        Me.EGradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.EGroupBox1 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.chklockerfine = New System.Windows.Forms.CheckBox
        Me.chklockerfees = New System.Windows.Forms.CheckBox
        Me.chklosingidcard = New System.Windows.Forms.CheckBox
        Me.chknewidcard = New System.Windows.Forms.CheckBox
        Me.chklosingcompbooks = New System.Windows.Forms.CheckBox
        Me.chklosingjournal = New System.Windows.Forms.CheckBox
        Me.chklosingbooks = New System.Windows.Forms.CheckBox
        Me.txtreason = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtotherfees = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtlockerfine = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtlockerfees = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtlosingidcard = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtnewidcard = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtlosingcompbooks = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtlosingjournal = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtlosingbooks = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtlatefees = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtlatedays = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.ERoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.txtissuedate = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtname = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbregno = New ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbissueid = New ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ERoundedPanel2 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.lblchargesaccount = New System.Windows.Forms.Label
        Me.cmbdate = New ESAR_Controls.UIControls.ComboBox.eComboBoxDateTime
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.EGroupBox2 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.cmbpayvia = New ESAR_Controls.UIControls.ComboBox.eComboBoxIcon
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmbaccounttype = New System.Windows.Forms.ComboBox
        Me.txtelectransfer = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtmicrcode = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtbankaccountno = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtbranchcode = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtbankaddress = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtbankbranch = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtbankname = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtpayeename = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.RoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.btnhelp = New ESAR_Controls.UIControls.Button.eButton
        Me.btnrefresh = New ESAR_Controls.UIControls.Button.eButton
        Me.btndelete = New ESAR_Controls.UIControls.Button.eButton
        Me.btnsavenew = New ESAR_Controls.UIControls.Button.eButton
        Me.btnsave = New ESAR_Controls.UIControls.Button.eButton
        Me.btnnew = New ESAR_Controls.UIControls.Button.eButton
        Me.ELabel1 = New ESAR_Controls.eLabel
        Me.EGradientPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.EGroupBox1.SuspendLayout()
        Me.ERoundedPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ERoundedPanel2.SuspendLayout()
        Me.EGroupBox2.SuspendLayout()
        Me.RoundedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EGradientPanel1
        '
        Me.EGradientPanel1.Controls.Add(Me.SplitContainer1)
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
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(10, 70)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ERoundedPanel1)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(5)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EGroupBox2)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.SplitContainer1.Size = New System.Drawing.Size(819, 476)
        Me.SplitContainer1.SplitterDistance = 400
        Me.SplitContainer1.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.EGroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(5, 127)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Panel2.Size = New System.Drawing.Size(390, 344)
        Me.Panel2.TabIndex = 3
        '
        'EGroupBox1
        '
        Me.EGroupBox1.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox1.BorderThickness = 1.0!
        Me.EGroupBox1.Controls.Add(Me.chklockerfine)
        Me.EGroupBox1.Controls.Add(Me.chklockerfees)
        Me.EGroupBox1.Controls.Add(Me.chklosingidcard)
        Me.EGroupBox1.Controls.Add(Me.chknewidcard)
        Me.EGroupBox1.Controls.Add(Me.chklosingcompbooks)
        Me.EGroupBox1.Controls.Add(Me.chklosingjournal)
        Me.EGroupBox1.Controls.Add(Me.chklosingbooks)
        Me.EGroupBox1.Controls.Add(Me.txtreason)
        Me.EGroupBox1.Controls.Add(Me.Label8)
        Me.EGroupBox1.Controls.Add(Me.txtotherfees)
        Me.EGroupBox1.Controls.Add(Me.Label5)
        Me.EGroupBox1.Controls.Add(Me.txtlockerfine)
        Me.EGroupBox1.Controls.Add(Me.txtlockerfees)
        Me.EGroupBox1.Controls.Add(Me.txtlosingidcard)
        Me.EGroupBox1.Controls.Add(Me.txtnewidcard)
        Me.EGroupBox1.Controls.Add(Me.txtlosingcompbooks)
        Me.EGroupBox1.Controls.Add(Me.txtlosingjournal)
        Me.EGroupBox1.Controls.Add(Me.txtlosingbooks)
        Me.EGroupBox1.Controls.Add(Me.txtlatefees)
        Me.EGroupBox1.Controls.Add(Me.Label7)
        Me.EGroupBox1.Controls.Add(Me.Label6)
        Me.EGroupBox1.Controls.Add(Me.txtlatedays)
        Me.EGroupBox1.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox1.GroupImage = Nothing
        Me.EGroupBox1.GroupTitle = "Charges:"
        Me.EGroupBox1.Location = New System.Drawing.Point(0, 10)
        Me.EGroupBox1.Name = "EGroupBox1"
        Me.EGroupBox1.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.EGroupBox1.PaintGroupBox = False
        Me.EGroupBox1.RoundCorners = 10
        Me.EGroupBox1.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox1.ShadowControl = False
        Me.EGroupBox1.ShadowThickness = 3
        Me.EGroupBox1.Size = New System.Drawing.Size(390, 334)
        Me.EGroupBox1.TabIndex = 1
        '
        'chklockerfine
        '
        Me.chklockerfine.AutoSize = True
        Me.chklockerfine.Location = New System.Drawing.Point(27, 249)
        Me.chklockerfine.Name = "chklockerfine"
        Me.chklockerfine.Size = New System.Drawing.Size(173, 17)
        Me.chklockerfine.TabIndex = 41
        Me.chklockerfine.Text = "Cost of losing locker fine:"
        Me.chklockerfine.UseVisualStyleBackColor = True
        '
        'chklockerfees
        '
        Me.chklockerfees.AutoSize = True
        Me.chklockerfees.Location = New System.Drawing.Point(27, 222)
        Me.chklockerfees.Name = "chklockerfees"
        Me.chklockerfees.Size = New System.Drawing.Size(139, 17)
        Me.chklockerfees.TabIndex = 40
        Me.chklockerfees.Text = "Cost of locker fees:"
        Me.chklockerfees.UseVisualStyleBackColor = True
        '
        'chklosingidcard
        '
        Me.chklosingidcard.AutoSize = True
        Me.chklosingidcard.Location = New System.Drawing.Point(27, 195)
        Me.chklosingidcard.Name = "chklosingidcard"
        Me.chklosingidcard.Size = New System.Drawing.Size(156, 17)
        Me.chklosingidcard.TabIndex = 39
        Me.chklosingidcard.Text = "Cost of losing ID card:"
        Me.chklosingidcard.UseVisualStyleBackColor = True
        '
        'chknewidcard
        '
        Me.chknewidcard.AutoSize = True
        Me.chknewidcard.Location = New System.Drawing.Point(27, 168)
        Me.chknewidcard.Name = "chknewidcard"
        Me.chknewidcard.Size = New System.Drawing.Size(146, 17)
        Me.chknewidcard.TabIndex = 38
        Me.chknewidcard.Text = "Cost of new ID card:"
        Me.chknewidcard.UseVisualStyleBackColor = True
        '
        'chklosingcompbooks
        '
        Me.chklosingcompbooks.AutoSize = True
        Me.chklosingcompbooks.Location = New System.Drawing.Point(27, 141)
        Me.chklosingcompbooks.Name = "chklosingcompbooks"
        Me.chklosingcompbooks.Size = New System.Drawing.Size(182, 17)
        Me.chklosingcompbooks.TabIndex = 37
        Me.chklosingcompbooks.Text = "Cost of losing comp books:"
        Me.chklosingcompbooks.UseVisualStyleBackColor = True
        '
        'chklosingjournal
        '
        Me.chklosingjournal.AutoSize = True
        Me.chklosingjournal.Location = New System.Drawing.Point(27, 114)
        Me.chklosingjournal.Name = "chklosingjournal"
        Me.chklosingjournal.Size = New System.Drawing.Size(159, 17)
        Me.chklosingjournal.TabIndex = 36
        Me.chklosingjournal.Text = "Cost of losing journals:"
        Me.chklosingjournal.UseVisualStyleBackColor = True
        '
        'chklosingbooks
        '
        Me.chklosingbooks.AutoSize = True
        Me.chklosingbooks.Location = New System.Drawing.Point(27, 87)
        Me.chklosingbooks.Name = "chklosingbooks"
        Me.chklosingbooks.Size = New System.Drawing.Size(147, 17)
        Me.chklosingbooks.TabIndex = 35
        Me.chklosingbooks.Text = "Cost of losing books:"
        Me.chklosingbooks.UseVisualStyleBackColor = True
        '
        'txtreason
        '
        Me.txtreason.BackColor = System.Drawing.Color.White
        Me.txtreason.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtreason.Location = New System.Drawing.Point(420, 274)
        Me.txtreason.Name = "txtreason"
        Me.txtreason.Required = False
        Me.txtreason.ShowErrorIcon = False
        Me.txtreason.Size = New System.Drawing.Size(175, 21)
        Me.txtreason.TabIndex = 10
        Me.txtreason.TextBox = ""
        Me.txtreason.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtreason.WaterMark = "Enter Reason"
        Me.txtreason.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtreason.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreason.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "If other fees is charged:"
        '
        'txtotherfees
        '
        Me.txtotherfees.BackColor = System.Drawing.Color.White
        Me.txtotherfees.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtotherfees.Location = New System.Drawing.Point(316, 274)
        Me.txtotherfees.Name = "txtotherfees"
        Me.txtotherfees.ReadOnly = True
        Me.txtotherfees.Required = False
        Me.txtotherfees.ShowErrorIcon = True
        Me.txtotherfees.Size = New System.Drawing.Size(93, 21)
        Me.txtotherfees.TabIndex = 9
        Me.txtotherfees.TextBox = Nothing
        Me.txtotherfees.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.Numbers
        Me.txtotherfees.WaterMark = "0.00"
        Me.txtotherfees.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtotherfees.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtotherfees.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Calculate late fees for:"
        '
        'txtlockerfine
        '
        Me.txtlockerfine.BackColor = System.Drawing.Color.White
        Me.txtlockerfine.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtlockerfine.Location = New System.Drawing.Point(316, 247)
        Me.txtlockerfine.Name = "txtlockerfine"
        Me.txtlockerfine.ReadOnly = True
        Me.txtlockerfine.Required = False
        Me.txtlockerfine.ShowErrorIcon = True
        Me.txtlockerfine.Size = New System.Drawing.Size(93, 21)
        Me.txtlockerfine.TabIndex = 8
        Me.txtlockerfine.TextBox = Nothing
        Me.txtlockerfine.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.Numbers
        Me.txtlockerfine.WaterMark = "0.00"
        Me.txtlockerfine.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtlockerfine.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlockerfine.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtlockerfees
        '
        Me.txtlockerfees.BackColor = System.Drawing.Color.White
        Me.txtlockerfees.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtlockerfees.Location = New System.Drawing.Point(316, 220)
        Me.txtlockerfees.Name = "txtlockerfees"
        Me.txtlockerfees.ReadOnly = True
        Me.txtlockerfees.Required = False
        Me.txtlockerfees.ShowErrorIcon = True
        Me.txtlockerfees.Size = New System.Drawing.Size(93, 21)
        Me.txtlockerfees.TabIndex = 7
        Me.txtlockerfees.TextBox = Nothing
        Me.txtlockerfees.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.Numbers
        Me.txtlockerfees.WaterMark = "0.00"
        Me.txtlockerfees.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtlockerfees.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlockerfees.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtlosingidcard
        '
        Me.txtlosingidcard.BackColor = System.Drawing.Color.White
        Me.txtlosingidcard.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtlosingidcard.Location = New System.Drawing.Point(316, 193)
        Me.txtlosingidcard.Name = "txtlosingidcard"
        Me.txtlosingidcard.ReadOnly = True
        Me.txtlosingidcard.Required = False
        Me.txtlosingidcard.ShowErrorIcon = True
        Me.txtlosingidcard.Size = New System.Drawing.Size(93, 21)
        Me.txtlosingidcard.TabIndex = 6
        Me.txtlosingidcard.TextBox = Nothing
        Me.txtlosingidcard.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.Numbers
        Me.txtlosingidcard.WaterMark = "0.00"
        Me.txtlosingidcard.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtlosingidcard.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlosingidcard.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtnewidcard
        '
        Me.txtnewidcard.BackColor = System.Drawing.Color.White
        Me.txtnewidcard.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtnewidcard.Location = New System.Drawing.Point(316, 166)
        Me.txtnewidcard.Name = "txtnewidcard"
        Me.txtnewidcard.ReadOnly = True
        Me.txtnewidcard.Required = False
        Me.txtnewidcard.ShowErrorIcon = True
        Me.txtnewidcard.Size = New System.Drawing.Size(93, 21)
        Me.txtnewidcard.TabIndex = 5
        Me.txtnewidcard.TextBox = Nothing
        Me.txtnewidcard.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.Numbers
        Me.txtnewidcard.WaterMark = "0.00"
        Me.txtnewidcard.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtnewidcard.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewidcard.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtlosingcompbooks
        '
        Me.txtlosingcompbooks.BackColor = System.Drawing.Color.White
        Me.txtlosingcompbooks.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtlosingcompbooks.Location = New System.Drawing.Point(316, 139)
        Me.txtlosingcompbooks.Name = "txtlosingcompbooks"
        Me.txtlosingcompbooks.ReadOnly = True
        Me.txtlosingcompbooks.Required = False
        Me.txtlosingcompbooks.ShowErrorIcon = True
        Me.txtlosingcompbooks.Size = New System.Drawing.Size(93, 21)
        Me.txtlosingcompbooks.TabIndex = 4
        Me.txtlosingcompbooks.TextBox = Nothing
        Me.txtlosingcompbooks.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.Numbers
        Me.txtlosingcompbooks.WaterMark = "0.00"
        Me.txtlosingcompbooks.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtlosingcompbooks.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlosingcompbooks.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtlosingjournal
        '
        Me.txtlosingjournal.BackColor = System.Drawing.Color.White
        Me.txtlosingjournal.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtlosingjournal.Location = New System.Drawing.Point(316, 112)
        Me.txtlosingjournal.Name = "txtlosingjournal"
        Me.txtlosingjournal.ReadOnly = True
        Me.txtlosingjournal.Required = False
        Me.txtlosingjournal.ShowErrorIcon = True
        Me.txtlosingjournal.Size = New System.Drawing.Size(93, 21)
        Me.txtlosingjournal.TabIndex = 3
        Me.txtlosingjournal.TextBox = Nothing
        Me.txtlosingjournal.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.Numbers
        Me.txtlosingjournal.WaterMark = "0.00"
        Me.txtlosingjournal.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtlosingjournal.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlosingjournal.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtlosingbooks
        '
        Me.txtlosingbooks.BackColor = System.Drawing.Color.White
        Me.txtlosingbooks.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtlosingbooks.Location = New System.Drawing.Point(316, 85)
        Me.txtlosingbooks.Name = "txtlosingbooks"
        Me.txtlosingbooks.ReadOnly = True
        Me.txtlosingbooks.Required = False
        Me.txtlosingbooks.ShowErrorIcon = True
        Me.txtlosingbooks.Size = New System.Drawing.Size(93, 21)
        Me.txtlosingbooks.TabIndex = 2
        Me.txtlosingbooks.TextBox = Nothing
        Me.txtlosingbooks.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.Numbers
        Me.txtlosingbooks.WaterMark = "0.00"
        Me.txtlosingbooks.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtlosingbooks.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlosingbooks.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtlatefees
        '
        Me.txtlatefees.BackColor = System.Drawing.Color.White
        Me.txtlatefees.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtlatefees.Location = New System.Drawing.Point(316, 58)
        Me.txtlatefees.Name = "txtlatefees"
        Me.txtlatefees.ReadOnly = True
        Me.txtlatefees.Required = False
        Me.txtlatefees.ShowErrorIcon = True
        Me.txtlatefees.Size = New System.Drawing.Size(93, 21)
        Me.txtlatefees.TabIndex = 1
        Me.txtlatefees.TextBox = Nothing
        Me.txtlatefees.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.Numbers
        Me.txtlatefees.WaterMark = "0.00"
        Me.txtlatefees.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtlatefees.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlatefees.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Total late fees calculated:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(416, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "days."
        '
        'txtlatedays
        '
        Me.txtlatedays.BackColor = System.Drawing.Color.White
        Me.txtlatedays.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtlatedays.Location = New System.Drawing.Point(316, 31)
        Me.txtlatedays.Name = "txtlatedays"
        Me.txtlatedays.ReadOnly = True
        Me.txtlatedays.Required = False
        Me.txtlatedays.ShowErrorIcon = True
        Me.txtlatedays.Size = New System.Drawing.Size(93, 21)
        Me.txtlatedays.TabIndex = 0
        Me.txtlatedays.TextBox = Nothing
        Me.txtlatedays.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.Numbers
        Me.txtlatedays.WaterMark = "0"
        Me.txtlatedays.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtlatedays.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlatedays.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'ERoundedPanel1
        '
        Me.ERoundedPanel1.BackColor = System.Drawing.Color.White
        Me.ERoundedPanel1.BorderRadius = 32
        Me.ERoundedPanel1.Controls.Add(Me.txtissuedate)
        Me.ERoundedPanel1.Controls.Add(Me.Label4)
        Me.ERoundedPanel1.Controls.Add(Me.txtname)
        Me.ERoundedPanel1.Controls.Add(Me.Label3)
        Me.ERoundedPanel1.Controls.Add(Me.cmbregno)
        Me.ERoundedPanel1.Controls.Add(Me.Label2)
        Me.ERoundedPanel1.Controls.Add(Me.cmbissueid)
        Me.ERoundedPanel1.Controls.Add(Me.Label1)
        Me.ERoundedPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ERoundedPanel1.Location = New System.Drawing.Point(5, 5)
        Me.ERoundedPanel1.Name = "ERoundedPanel1"
        Me.ERoundedPanel1.Size = New System.Drawing.Size(390, 122)
        Me.ERoundedPanel1.TabIndex = 2
        '
        'txtissuedate
        '
        Me.txtissuedate.BackColor = System.Drawing.Color.White
        Me.txtissuedate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtissuedate.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtissuedate.Location = New System.Drawing.Point(119, 94)
        Me.txtissuedate.Name = "txtissuedate"
        Me.txtissuedate.ReadOnly = True
        Me.txtissuedate.Required = False
        Me.txtissuedate.ShowErrorIcon = False
        Me.txtissuedate.Size = New System.Drawing.Size(258, 14)
        Me.txtissuedate.TabIndex = 7
        Me.txtissuedate.TextBox = ""
        Me.txtissuedate.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtissuedate.WaterMark = "Loan Date"
        Me.txtissuedate.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtissuedate.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtissuedate.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Loan Date:"
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.White
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtname.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtname.Location = New System.Drawing.Point(119, 71)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Required = False
        Me.txtname.ShowErrorIcon = False
        Me.txtname.Size = New System.Drawing.Size(258, 14)
        Me.txtname.TabIndex = 2
        Me.txtname.TextBox = ""
        Me.txtname.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtname.WaterMark = "Enter Name"
        Me.txtname.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtname.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name:"
        '
        'cmbregno
        '
        Me.cmbregno.FormattingEnabled = True
        Me.cmbregno.InstantBinding = True
        Me.cmbregno.Location = New System.Drawing.Point(119, 41)
        Me.cmbregno.Name = "cmbregno"
        Me.cmbregno.Size = New System.Drawing.Size(134, 21)
        Me.cmbregno.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Registration No:"
        '
        'cmbissueid
        '
        Me.cmbissueid.FormattingEnabled = True
        Me.cmbissueid.InstantBinding = True
        Me.cmbissueid.Location = New System.Drawing.Point(119, 14)
        Me.cmbissueid.Name = "cmbissueid"
        Me.cmbissueid.Size = New System.Drawing.Size(134, 21)
        Me.cmbissueid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book Loan No:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ERoundedPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(5, 319)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(405, 152)
        Me.Panel1.TabIndex = 3
        '
        'ERoundedPanel2
        '
        Me.ERoundedPanel2.BackColor = System.Drawing.Color.White
        Me.ERoundedPanel2.BorderRadius = 32
        Me.ERoundedPanel2.Controls.Add(Me.lblchargesaccount)
        Me.ERoundedPanel2.Controls.Add(Me.cmbdate)
        Me.ERoundedPanel2.Controls.Add(Me.Label12)
        Me.ERoundedPanel2.Controls.Add(Me.Label11)
        Me.ERoundedPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel2.Location = New System.Drawing.Point(0, 10)
        Me.ERoundedPanel2.Name = "ERoundedPanel2"
        Me.ERoundedPanel2.Size = New System.Drawing.Size(405, 142)
        Me.ERoundedPanel2.TabIndex = 0
        '
        'lblchargesaccount
        '
        Me.lblchargesaccount.AutoSize = True
        Me.lblchargesaccount.Location = New System.Drawing.Point(116, 17)
        Me.lblchargesaccount.Name = "lblchargesaccount"
        Me.lblchargesaccount.Size = New System.Drawing.Size(0, 13)
        Me.lblchargesaccount.TabIndex = 6
        '
        'cmbdate
        '
        Me.cmbdate.FormatString = "d"
        Me.cmbdate.FormattingEnabled = True
        Me.cmbdate.Location = New System.Drawing.Point(119, 41)
        Me.cmbdate.Name = "cmbdate"
        Me.cmbdate.Size = New System.Drawing.Size(134, 21)
        Me.cmbdate.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Date:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Account:"
        '
        'EGroupBox2
        '
        Me.EGroupBox2.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox2.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox2.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox2.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox2.BorderThickness = 1.0!
        Me.EGroupBox2.Controls.Add(Me.cmbpayvia)
        Me.EGroupBox2.Controls.Add(Me.Label10)
        Me.EGroupBox2.Controls.Add(Me.cmbaccounttype)
        Me.EGroupBox2.Controls.Add(Me.txtelectransfer)
        Me.EGroupBox2.Controls.Add(Me.txtmicrcode)
        Me.EGroupBox2.Controls.Add(Me.txtbankaccountno)
        Me.EGroupBox2.Controls.Add(Me.txtbranchcode)
        Me.EGroupBox2.Controls.Add(Me.txtbankaddress)
        Me.EGroupBox2.Controls.Add(Me.txtbankbranch)
        Me.EGroupBox2.Controls.Add(Me.txtbankname)
        Me.EGroupBox2.Controls.Add(Me.txtpayeename)
        Me.EGroupBox2.Controls.Add(Me.Label9)
        Me.EGroupBox2.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.EGroupBox2.GroupImage = Nothing
        Me.EGroupBox2.GroupTitle = "Payment Details:"
        Me.EGroupBox2.Location = New System.Drawing.Point(5, 5)
        Me.EGroupBox2.Name = "EGroupBox2"
        Me.EGroupBox2.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.EGroupBox2.PaintGroupBox = False
        Me.EGroupBox2.RoundCorners = 10
        Me.EGroupBox2.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox2.ShadowControl = False
        Me.EGroupBox2.ShadowThickness = 3
        Me.EGroupBox2.Size = New System.Drawing.Size(405, 314)
        Me.EGroupBox2.TabIndex = 1
        '
        'cmbpayvia
        '
        Me.cmbpayvia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbpayvia.FormattingEnabled = True
        Me.cmbpayvia.ImageList = Me.ImageList1
        Me.cmbpayvia.Location = New System.Drawing.Point(427, 277)
        Me.cmbpayvia.Name = "cmbpayvia"
        Me.cmbpayvia.Size = New System.Drawing.Size(640, 22)
        Me.cmbpayvia.TabIndex = 9
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "cash.png")
        Me.ImageList1.Images.SetKeyName(1, "check.png")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(93, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Pay Via:"
        '
        'cmbaccounttype
        '
        Me.cmbaccounttype.FormattingEnabled = True
        Me.cmbaccounttype.Location = New System.Drawing.Point(868, 196)
        Me.cmbaccounttype.Name = "cmbaccounttype"
        Me.cmbaccounttype.Size = New System.Drawing.Size(640, 21)
        Me.cmbaccounttype.TabIndex = 6
        '
        'txtelectransfer
        '
        Me.txtelectransfer.BackColor = System.Drawing.Color.White
        Me.txtelectransfer.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtelectransfer.Location = New System.Drawing.Point(108, 250)
        Me.txtelectransfer.Name = "txtelectransfer"
        Me.txtelectransfer.Required = False
        Me.txtelectransfer.ShowErrorIcon = False
        Me.txtelectransfer.Size = New System.Drawing.Size(1927, 21)
        Me.txtelectransfer.TabIndex = 8
        Me.txtelectransfer.TextBox = ""
        Me.txtelectransfer.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtelectransfer.WaterMark = "Mode of Electronic transfer available in the Bank"
        Me.txtelectransfer.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtelectransfer.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtelectransfer.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtmicrcode
        '
        Me.txtmicrcode.BackColor = System.Drawing.Color.White
        Me.txtmicrcode.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtmicrcode.Location = New System.Drawing.Point(108, 223)
        Me.txtmicrcode.Name = "txtmicrcode"
        Me.txtmicrcode.Required = False
        Me.txtmicrcode.ShowErrorIcon = True
        Me.txtmicrcode.Size = New System.Drawing.Size(1927, 21)
        Me.txtmicrcode.TabIndex = 7
        Me.txtmicrcode.TextBox = ""
        Me.txtmicrcode.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.Numbers
        Me.txtmicrcode.WaterMark = "MI CR code of the Bank:"
        Me.txtmicrcode.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtmicrcode.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmicrcode.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtbankaccountno
        '
        Me.txtbankaccountno.BackColor = System.Drawing.Color.White
        Me.txtbankaccountno.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtbankaccountno.Location = New System.Drawing.Point(108, 170)
        Me.txtbankaccountno.Name = "txtbankaccountno"
        Me.txtbankaccountno.Required = False
        Me.txtbankaccountno.ShowErrorIcon = False
        Me.txtbankaccountno.Size = New System.Drawing.Size(1927, 21)
        Me.txtbankaccountno.TabIndex = 5
        Me.txtbankaccountno.TextBox = ""
        Me.txtbankaccountno.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtbankaccountno.WaterMark = "Bank Account Number"
        Me.txtbankaccountno.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtbankaccountno.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbankaccountno.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtbranchcode
        '
        Me.txtbranchcode.BackColor = System.Drawing.Color.White
        Me.txtbranchcode.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtbranchcode.Location = New System.Drawing.Point(108, 142)
        Me.txtbranchcode.Name = "txtbranchcode"
        Me.txtbranchcode.Required = False
        Me.txtbranchcode.ShowErrorIcon = True
        Me.txtbranchcode.Size = New System.Drawing.Size(1927, 21)
        Me.txtbranchcode.TabIndex = 4
        Me.txtbranchcode.TextBox = ""
        Me.txtbranchcode.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.Numbers
        Me.txtbranchcode.WaterMark = "Branch Code number"
        Me.txtbranchcode.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtbranchcode.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbranchcode.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtbankaddress
        '
        Me.txtbankaddress.BackColor = System.Drawing.Color.White
        Me.txtbankaddress.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtbankaddress.Location = New System.Drawing.Point(108, 117)
        Me.txtbankaddress.Name = "txtbankaddress"
        Me.txtbankaddress.Required = False
        Me.txtbankaddress.ShowErrorIcon = False
        Me.txtbankaddress.Size = New System.Drawing.Size(1927, 21)
        Me.txtbankaddress.TabIndex = 3
        Me.txtbankaddress.TextBox = ""
        Me.txtbankaddress.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtbankaddress.WaterMark = "Bank Branch Full Address"
        Me.txtbankaddress.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtbankaddress.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbankaddress.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtbankbranch
        '
        Me.txtbankbranch.BackColor = System.Drawing.Color.White
        Me.txtbankbranch.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtbankbranch.Location = New System.Drawing.Point(108, 90)
        Me.txtbankbranch.Name = "txtbankbranch"
        Me.txtbankbranch.Required = False
        Me.txtbankbranch.ShowErrorIcon = False
        Me.txtbankbranch.Size = New System.Drawing.Size(1927, 21)
        Me.txtbankbranch.TabIndex = 2
        Me.txtbankbranch.TextBox = ""
        Me.txtbankbranch.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtbankbranch.WaterMark = "Bank Branch"
        Me.txtbankbranch.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtbankbranch.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbankbranch.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtbankname
        '
        Me.txtbankname.BackColor = System.Drawing.Color.White
        Me.txtbankname.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtbankname.Location = New System.Drawing.Point(108, 63)
        Me.txtbankname.Name = "txtbankname"
        Me.txtbankname.Required = False
        Me.txtbankname.ShowErrorIcon = False
        Me.txtbankname.Size = New System.Drawing.Size(1927, 21)
        Me.txtbankname.TabIndex = 1
        Me.txtbankname.TextBox = ""
        Me.txtbankname.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtbankname.WaterMark = "Name of the Bank"
        Me.txtbankname.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtbankname.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbankname.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtpayeename
        '
        Me.txtpayeename.BackColor = System.Drawing.Color.White
        Me.txtpayeename.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtpayeename.Location = New System.Drawing.Point(108, 36)
        Me.txtpayeename.Name = "txtpayeename"
        Me.txtpayeename.Required = False
        Me.txtpayeename.ShowErrorIcon = False
        Me.txtpayeename.Size = New System.Drawing.Size(1927, 21)
        Me.txtpayeename.TabIndex = 0
        Me.txtpayeename.TextBox = ""
        Me.txtpayeename.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtpayeename.WaterMark = "Name of the payee"
        Me.txtpayeename.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtpayeename.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpayeename.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(93, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 13)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Type of bank Account:"
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.RoundedPanel1.BorderRadius = 32
        Me.RoundedPanel1.Controls.Add(Me.btnhelp)
        Me.RoundedPanel1.Controls.Add(Me.btnrefresh)
        Me.RoundedPanel1.Controls.Add(Me.btndelete)
        Me.RoundedPanel1.Controls.Add(Me.btnsavenew)
        Me.RoundedPanel1.Controls.Add(Me.btnsave)
        Me.RoundedPanel1.Controls.Add(Me.btnnew)
        Me.RoundedPanel1.Controls.Add(Me.ELabel1)
        Me.RoundedPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RoundedPanel1.Location = New System.Drawing.Point(10, 10)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.RoundedPanel1.Size = New System.Drawing.Size(819, 60)
        Me.RoundedPanel1.TabIndex = 18
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
        Me.btnhelp.Location = New System.Drawing.Point(430, 10)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(63, 40)
        Me.btnhelp.TabIndex = 83
        Me.btnhelp.Text = "Help"
        Me.btnhelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhelp.TextShadowShow = False
        '
        'btnrefresh
        '
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnrefresh.CenterPtTracker = DesignerRectTracker3
        Me.btnrefresh.ColorFillSolid = System.Drawing.Color.White
        Me.btnrefresh.Corners.All = CType(-1, Short)
        Me.btnrefresh.Corners.LowerLeft = CType(20, Short)
        Me.btnrefresh.Corners.LowerRight = CType(12, Short)
        Me.btnrefresh.Corners.UpperLeft = CType(12, Short)
        Me.btnrefresh.Corners.UpperRight = CType(20, Short)
        Me.btnrefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnrefresh.FocalPoints.CenterPtX = 0.4444444!
        Me.btnrefresh.FocalPoints.CenterPtY = 0.65!
        Me.btnrefresh.FocalPoints.FocusPtX = 0.0!
        Me.btnrefresh.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnrefresh.FocusPtTracker = DesignerRectTracker4
        Me.btnrefresh.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.Image = Global.Umbrella.My.Resources.Resources.refresh_icon
        Me.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.ImageIndex = 0
        Me.btnrefresh.Location = New System.Drawing.Point(343, 10)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(87, 40)
        Me.btnrefresh.TabIndex = 82
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnrefresh.TextShadowShow = False
        '
        'btndelete
        '
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btndelete.CenterPtTracker = DesignerRectTracker5
        Me.btndelete.ColorFillSolid = System.Drawing.Color.White
        Me.btndelete.Corners.All = CType(-1, Short)
        Me.btndelete.Corners.LowerLeft = CType(20, Short)
        Me.btndelete.Corners.LowerRight = CType(12, Short)
        Me.btndelete.Corners.UpperLeft = CType(12, Short)
        Me.btndelete.Corners.UpperRight = CType(20, Short)
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndelete.Dock = System.Windows.Forms.DockStyle.Left
        Me.btndelete.FocalPoints.CenterPtX = 0.4556962!
        Me.btndelete.FocalPoints.CenterPtY = 0.4!
        Me.btndelete.FocalPoints.FocusPtX = 0.0!
        Me.btndelete.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btndelete.FocusPtTracker = DesignerRectTracker6
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Image = Global.Umbrella.My.Resources.Resources.Delete
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndelete.ImageIndex = 0
        Me.btndelete.Location = New System.Drawing.Point(264, 10)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(79, 40)
        Me.btndelete.TabIndex = 81
        Me.btndelete.Text = "Delete"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btndelete.TextShadowShow = False
        '
        'btnsavenew
        '
        DesignerRectTracker7.IsActive = False
        DesignerRectTracker7.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker7.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsavenew.CenterPtTracker = DesignerRectTracker7
        Me.btnsavenew.ColorFillSolid = System.Drawing.Color.White
        Me.btnsavenew.Corners.All = CType(-1, Short)
        Me.btnsavenew.Corners.LowerLeft = CType(20, Short)
        Me.btnsavenew.Corners.LowerRight = CType(12, Short)
        Me.btnsavenew.Corners.UpperLeft = CType(12, Short)
        Me.btnsavenew.Corners.UpperRight = CType(20, Short)
        Me.btnsavenew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsavenew.Dock = System.Windows.Forms.DockStyle.Left
        DesignerRectTracker8.IsActive = False
        DesignerRectTracker8.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker8.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsavenew.FocusPtTracker = DesignerRectTracker8
        Me.btnsavenew.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsavenew.Image = Global.Umbrella.My.Resources.Resources.SaveNew
        Me.btnsavenew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsavenew.ImageIndex = 0
        Me.btnsavenew.Location = New System.Drawing.Point(144, 10)
        Me.btnsavenew.Name = "btnsavenew"
        Me.btnsavenew.Size = New System.Drawing.Size(120, 40)
        Me.btnsavenew.TabIndex = 80
        Me.btnsavenew.Text = "Save && New"
        Me.btnsavenew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsavenew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsavenew.TextShadowShow = False
        '
        'btnsave
        '
        DesignerRectTracker9.IsActive = False
        DesignerRectTracker9.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker9.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsave.CenterPtTracker = DesignerRectTracker9
        Me.btnsave.ColorFillSolid = System.Drawing.Color.White
        Me.btnsave.Corners.All = CType(-1, Short)
        Me.btnsave.Corners.LowerLeft = CType(20, Short)
        Me.btnsave.Corners.LowerRight = CType(12, Short)
        Me.btnsave.Corners.UpperLeft = CType(12, Short)
        Me.btnsave.Corners.UpperRight = CType(20, Short)
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnsave.FocalPoints.CenterPtX = 0.4788733!
        Me.btnsave.FocalPoints.CenterPtY = 0.425!
        Me.btnsave.FocalPoints.FocusPtX = 0.0!
        Me.btnsave.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker10.IsActive = False
        DesignerRectTracker10.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker10.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsave.FocusPtTracker = DesignerRectTracker10
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Image = Global.Umbrella.My.Resources.Resources.save
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.ImageIndex = 0
        Me.btnsave.Location = New System.Drawing.Point(73, 10)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(71, 40)
        Me.btnsave.TabIndex = 79
        Me.btnsave.Text = "Save"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsave.TextShadowShow = False
        '
        'btnnew
        '
        DesignerRectTracker11.IsActive = False
        DesignerRectTracker11.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker11.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnnew.CenterPtTracker = DesignerRectTracker11
        Me.btnnew.ColorFillSolid = System.Drawing.Color.White
        Me.btnnew.Corners.All = CType(-1, Short)
        Me.btnnew.Corners.LowerLeft = CType(20, Short)
        Me.btnnew.Corners.LowerRight = CType(12, Short)
        Me.btnnew.Corners.UpperLeft = CType(12, Short)
        Me.btnnew.Corners.UpperRight = CType(20, Short)
        Me.btnnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnew.Dock = System.Windows.Forms.DockStyle.Left
        DesignerRectTracker12.IsActive = False
        DesignerRectTracker12.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker12.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnnew.FocusPtTracker = DesignerRectTracker12
        Me.btnnew.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.Image = Global.Umbrella.My.Resources.Resources._new
        Me.btnnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnew.ImageIndex = 0
        Me.btnnew.Location = New System.Drawing.Point(10, 10)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(63, 40)
        Me.btnnew.TabIndex = 78
        Me.btnnew.Text = "New"
        Me.btnnew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnnew.TextShadowShow = False
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
        Me.ELabel1.Location = New System.Drawing.Point(547, 10)
        Me.ELabel1.MouseOverColor = System.Drawing.Color.Gray
        Me.ELabel1.Name = "ELabel1"
        Me.ELabel1.ShadowState = True
        Me.ELabel1.Size = New System.Drawing.Size(262, 40)
        Me.ELabel1.TabIndex = 34
        Me.ELabel1.Text = "Maintain Charge Calculation"
        '
        'frmCalculateCharges
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
        Me.Name = "frmCalculateCharges"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maintain Charge Calculation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.EGradientPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.EGroupBox1.ResumeLayout(False)
        Me.EGroupBox1.PerformLayout()
        Me.ERoundedPanel1.ResumeLayout(False)
        Me.ERoundedPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ERoundedPanel2.ResumeLayout(False)
        Me.ERoundedPanel2.PerformLayout()
        Me.EGroupBox2.ResumeLayout(False)
        Me.EGroupBox2.PerformLayout()
        Me.RoundedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EGradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents RoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents ELabel1 As ESAR_Controls.eLabel
    Friend WithEvents btnhelp As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnrefresh As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btndelete As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnsavenew As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnsave As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnnew As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EGroupBox2 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents EGroupBox1 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents ERoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtname As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbissueid As ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtlatedays As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtlosingbooks As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtlatefees As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtlosingidcard As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtnewidcard As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtlosingcompbooks As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtlosingjournal As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtlockerfees As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtlockerfine As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtelectransfer As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtmicrcode As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtbankaccountno As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtbranchcode As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtbankaddress As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtbankbranch As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtbankname As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtpayeename As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbaccounttype As System.Windows.Forms.ComboBox
    Friend WithEvents cmbpayvia As ESAR_Controls.UIControls.ComboBox.eComboBoxIcon
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ERoundedPanel2 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtreason As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtotherfees As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents cmbregno As ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
    Friend WithEvents cmbdate As ESAR_Controls.UIControls.ComboBox.eComboBoxDateTime
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtissuedate As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents chklockerfine As System.Windows.Forms.CheckBox
    Friend WithEvents chklockerfees As System.Windows.Forms.CheckBox
    Friend WithEvents chklosingidcard As System.Windows.Forms.CheckBox
    Friend WithEvents chknewidcard As System.Windows.Forms.CheckBox
    Friend WithEvents chklosingcompbooks As System.Windows.Forms.CheckBox
    Friend WithEvents chklosingjournal As System.Windows.Forms.CheckBox
    Friend WithEvents chklosingbooks As System.Windows.Forms.CheckBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents lblchargesaccount As System.Windows.Forms.Label
End Class
