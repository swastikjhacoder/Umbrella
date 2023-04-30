#Region "Class frmInstituteDetails..."
Public Class frmInstitute
#Region "Declarations..."
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Private grpgeneral As New ESAR_Controls.UIControls.GroupBox.eGroupBox()
    Private dgviewgeneral As New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary()
    Private grpcourse As New ESAR_Controls.UIControls.GroupBox.eGroupBox()
    Private dgviewcourse As New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary()
    Private grpfeatures As New ESAR_Controls.UIControls.GroupBox.eGroupBox()
    Private dgviewfeatures As New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary()
    Private clmf1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Private clmf2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Private clmgenhead As New DataGridViewTextBoxColumn()
    Private clmgendetails As New DataGridViewTextBoxColumn()
    Private clmsl As New DataGridViewTextBoxColumn()
    Private clmcoursename As New DataGridViewTextBoxColumn()
    Private clmcourseid As New DataGridViewTextBoxColumn()
    Private clmduration As New DataGridViewTextBoxColumn()
    Private grpachievements As New ESAR_Controls.UIControls.GroupBox.eGroupBox()
    Private dgviewachievements As New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary()
    Private clmslachieve As New DataGridViewTextBoxColumn()
    Private clmachieve As New DataGridViewTextBoxColumn()
    Private grpaccounts As New ESAR_Controls.UIControls.GroupBox.eGroupBox()
    Private dgviewaccounts As New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary()
    Private clml As New DataGridViewTextBoxColumn()
    Private clm2 As New DataGridViewTextBoxColumn()
    Private clm3 As New DataGridViewTextBoxColumn()
    Private clm4 As New ESAR_Controls.UIControls.DataGridView.eNumericTextBoxColumn()
    Private rndpnlfinancial As New ESAR_Controls.UIControls.Panel.eRoundedPanel()
    Private lblfinancialperiod As New ESAR_Controls.eLabel()
    Private InsExist As Boolean = False
    Private UpdateInstituteOk As Boolean = False
    Private UpdateAchievementsOk As Boolean = False
    Private UpdateAllTablesOk As Boolean = False
#End Region
#Region "Design..."
    Private Sub LoadDesign()
        grpgeneral.BackgroundColor = System.Drawing.Color.White
        grpgeneral.BackgroundGradientColor = System.Drawing.Color.White
        grpgeneral.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        grpgeneral.BorderColor = System.Drawing.Color.Black
        grpgeneral.BorderThickness = 1.0!
        grpgeneral.Controls.Add(dgviewgeneral)
        grpgeneral.CustomGroupBoxColor = System.Drawing.Color.White
        grpgeneral.Dock = System.Windows.Forms.DockStyle.Top
        grpgeneral.GroupImage = Nothing
        grpgeneral.GroupTitle = "General Info:"
        grpgeneral.Location = New System.Drawing.Point(0, 5)
        grpgeneral.Name = "EGroupBox1"
        grpgeneral.Padding = New System.Windows.Forms.Padding(12, 25, 12, 12)
        grpgeneral.PaintGroupBox = False
        grpgeneral.RoundCorners = 10
        grpgeneral.ShadowColor = System.Drawing.Color.DarkGray
        grpgeneral.ShadowControl = False
        grpgeneral.ShadowThickness = 3
        grpgeneral.Size = New System.Drawing.Size(819, 346)
        grpgeneral.TabIndex = 1

        dgviewgeneral.AllowUserToAddRows = False
        dgviewgeneral.AllowUserToDeleteRows = False
        dgviewgeneral.BackgroundColor = System.Drawing.Color.White
        dgviewgeneral.ColumnHeadersVisible = False
        dgviewgeneral.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {clmgenhead, clmgendetails})
        dgviewgeneral.DisplaySumRowHeader = False
        dgviewgeneral.Dock = System.Windows.Forms.DockStyle.Left
        dgviewgeneral.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        dgviewgeneral.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgviewgeneral.Location = New System.Drawing.Point(12, 25)
        dgviewgeneral.Name = "dgviewgeneral"
        dgviewgeneral.ReadOnly = False
        dgviewgeneral.RowHeadersVisible = False
        dgviewgeneral.Size = New System.Drawing.Size(750, 311)
        dgviewgeneral.SummaryColumns = Nothing
        dgviewgeneral.SummaryRowBackColor = System.Drawing.Color.Empty
        dgviewgeneral.SummaryRowSpace = 0
        dgviewgeneral.SummaryRowVisible = False
        dgviewgeneral.SumRowHeaderText = Nothing
        dgviewgeneral.SumRowHeaderTextBold = False
        dgviewgeneral.TabIndex = 0
        dgviewgeneral.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
        dgviewgeneral.DefaultCellStyle.ForeColor = Color.Black
        dgviewgeneral.DefaultCellStyle.SelectionBackColor = Color.White
        dgviewgeneral.DefaultCellStyle.SelectionForeColor = Color.Black
        dgviewgeneral.AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
        dgviewgeneral.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
        dgviewgeneral.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
        dgviewgeneral.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black

        clmgenhead.HeaderText = "Column1"
        clmgenhead.Name = "Column1"
        clmgenhead.ReadOnly = True
        clmgenhead.Width = 200

        clmgendetails.HeaderText = "Column2"
        clmgendetails.Name = "Column2"
        clmgendetails.ReadOnly = False
        clmgendetails.Width = 575

        grpcourse.BackgroundColor = System.Drawing.Color.White
        grpcourse.BackgroundGradientColor = System.Drawing.Color.White
        grpcourse.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        grpcourse.BorderColor = System.Drawing.Color.Black
        grpcourse.BorderThickness = 1.0!
        grpcourse.Controls.Add(dgviewcourse)
        grpcourse.CustomGroupBoxColor = System.Drawing.Color.White
        grpcourse.Dock = System.Windows.Forms.DockStyle.Top
        grpcourse.GroupImage = Global.Umbrella.My.Resources.Resources.course_icon
        grpcourse.GroupTitle = "Courses:"
        grpcourse.Location = New System.Drawing.Point(0, 5)
        grpcourse.Name = "grpcourse"
        grpcourse.Padding = New System.Windows.Forms.Padding(12, 25, 12, 10)
        grpcourse.PaintGroupBox = False
        grpcourse.RoundCorners = 10
        grpcourse.ShadowColor = System.Drawing.Color.DarkGray
        grpcourse.ShadowControl = False
        grpcourse.ShadowThickness = 3
        grpcourse.Size = New System.Drawing.Size(819, 146)
        grpcourse.TabIndex = 32

        dgviewcourse.AllowUserToAddRows = False
        dgviewcourse.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        dgviewcourse.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgviewcourse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        dgviewcourse.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        dgviewcourse.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgviewcourse.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {clmsl, clmcoursename, clmcourseid, clmduration})
        dgviewcourse.Dock = System.Windows.Forms.DockStyle.Fill
        dgviewcourse.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        dgviewcourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgviewcourse.Location = New System.Drawing.Point(12, 25)
        dgviewcourse.Name = "dgviewcourse"
        dgviewcourse.RowHeadersVisible = False
        dgviewcourse.ReadOnly = True
        dgviewcourse.Size = New System.Drawing.Size(795, 111)
        dgviewcourse.TabIndex = 18
        dgviewcourse.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
        dgviewcourse.DefaultCellStyle.ForeColor = Color.Black
        dgviewcourse.DefaultCellStyle.SelectionBackColor = Color.White
        dgviewcourse.DefaultCellStyle.SelectionForeColor = Color.Black
        dgviewcourse.AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
        dgviewcourse.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
        dgviewcourse.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
        dgviewcourse.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black

        clmsl.HeaderText = "SL"
        clmsl.Name = "clmsl"
        clmsl.ReadOnly = True
        clmsl.Width = 40

        clmcoursename.HeaderText = "Course"
        clmcoursename.Name = "clmcoursename"
        clmcoursename.Width = 500
        clmcoursename.ReadOnly = False

        clmcourseid.HeaderText = "Code"
        clmcourseid.Name = "clmcourseid"
        clmcourseid.ReadOnly = False

        clmduration.HeaderText = "Duration (in Months)"
        clmduration.MaxInputLength = 0
        clmduration.Name = "clmduration"
        clmduration.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        clmduration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        clmduration.Width = 150
        clmduration.ReadOnly = False

        grpfeatures.BackgroundColor = System.Drawing.Color.White
        grpfeatures.BackgroundGradientColor = System.Drawing.Color.White
        grpfeatures.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        grpfeatures.BorderColor = System.Drawing.Color.Black
        grpfeatures.BorderThickness = 1.0!
        grpfeatures.Controls.Add(dgviewfeatures)
        grpfeatures.CustomGroupBoxColor = System.Drawing.Color.White
        grpfeatures.Dock = System.Windows.Forms.DockStyle.Top
        grpfeatures.GroupImage = Global.Umbrella.My.Resources.Resources.facility
        grpfeatures.GroupTitle = "Features:"
        grpfeatures.Location = New System.Drawing.Point(0, 5)
        grpfeatures.Name = "grpfeatures"
        grpfeatures.Padding = New System.Windows.Forms.Padding(12, 25, 12, 10)
        grpfeatures.PaintGroupBox = False
        grpfeatures.RoundCorners = 10
        grpfeatures.ShadowColor = System.Drawing.Color.DarkGray
        grpfeatures.ShadowControl = False
        grpfeatures.ShadowThickness = 3
        grpfeatures.Size = New System.Drawing.Size(819, 138)
        grpfeatures.TabIndex = 33

        Me.dgviewfeatures.AllowUserToAddRows = False
        Me.dgviewfeatures.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgviewfeatures.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgviewfeatures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgviewfeatures.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgviewfeatures.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgviewfeatures.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgviewfeatures.ColumnHeadersVisible = False
        Me.dgviewfeatures.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {clmf1, clmf2})
        Me.dgviewfeatures.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewfeatures.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        dgviewfeatures.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgviewfeatures.Location = New System.Drawing.Point(14, 25)
        Me.dgviewfeatures.Name = "dgviewfeatures"
        Me.dgviewfeatures.ReadOnly = True
        Me.dgviewfeatures.RowHeadersVisible = False
        Me.dgviewfeatures.Size = New System.Drawing.Size(679, 138)
        Me.dgviewfeatures.TabIndex = 19
        Me.dgviewfeatures.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
        Me.dgviewfeatures.DefaultCellStyle.ForeColor = Color.Black
        Me.dgviewfeatures.DefaultCellStyle.SelectionBackColor = Color.White
        Me.dgviewfeatures.DefaultCellStyle.SelectionForeColor = Color.Black
        Me.dgviewfeatures.AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
        Me.dgviewfeatures.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
        Me.dgviewfeatures.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
        Me.dgviewfeatures.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black

        clmf1.FillWeight = 5.076142!
        clmf1.HeaderText = "SL"
        clmf1.Name = "Column1"
        clmf1.ReadOnly = True

        clmf2.FillWeight = 194.9239!
        clmf2.HeaderText = "Features"
        clmf2.Name = "DataGridViewTextBoxColumn1"
        clmf2.ReadOnly = False

        grpachievements.BackgroundColor = System.Drawing.Color.White
        grpachievements.BackgroundGradientColor = System.Drawing.Color.White
        grpachievements.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        grpachievements.BorderColor = System.Drawing.Color.Black
        grpachievements.BorderThickness = 1.0!
        grpachievements.Controls.Add(dgviewachievements)
        grpachievements.CustomGroupBoxColor = System.Drawing.Color.White
        grpachievements.Dock = System.Windows.Forms.DockStyle.Top
        grpachievements.GroupImage = Global.Umbrella.My.Resources.Resources.achievement
        grpachievements.GroupTitle = "Academic Achievements:"
        grpachievements.Location = New System.Drawing.Point(0, 5)
        grpachievements.Name = "grpachievements"
        grpachievements.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        grpachievements.PaintGroupBox = False
        grpachievements.RoundCorners = 10
        grpachievements.ShadowColor = System.Drawing.Color.DarkGray
        grpachievements.ShadowControl = False
        grpachievements.ShadowThickness = 3
        grpachievements.Size = New System.Drawing.Size(819, 167)
        grpachievements.TabIndex = 39

        Me.dgviewachievements.AllowUserToAddRows = False
        Me.dgviewachievements.AllowUserToDeleteRows = False
        Me.dgviewachievements.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgviewachievements.BackgroundColor = System.Drawing.Color.White
        Me.dgviewachievements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgviewachievements.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {clmslachieve, clmachieve})
        Me.dgviewachievements.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewachievements.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgviewachievements.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgviewachievements.Location = New System.Drawing.Point(10, 25)
        Me.dgviewachievements.Name = "dgviewachievements"
        Me.dgviewachievements.ReadOnly = False
        Me.dgviewachievements.RowHeadersVisible = False
        Me.dgviewachievements.Size = New System.Drawing.Size(799, 132)
        Me.dgviewachievements.TabIndex = 34
        Me.dgviewachievements.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
        Me.dgviewachievements.DefaultCellStyle.ForeColor = Color.Black
        Me.dgviewachievements.DefaultCellStyle.SelectionBackColor = Color.White
        Me.dgviewachievements.DefaultCellStyle.SelectionForeColor = Color.Black
        Me.dgviewachievements.AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
        Me.dgviewachievements.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
        Me.dgviewachievements.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
        Me.dgviewachievements.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black

        clmslachieve.HeaderText = "SL"
        clmslachieve.Name = "DataGridViewTextBoxColumn1"
        clmslachieve.ReadOnly = True
        clmslachieve.Width = 45

        clmachieve.HeaderText = "Achievements"
        clmachieve.Name = "DataGridViewTextBoxColumn2"
        clmachieve.ReadOnly = False
        clmachieve.Width = 750

        grpaccounts.BackgroundColor = System.Drawing.Color.White
        grpaccounts.BackgroundGradientColor = System.Drawing.Color.White
        grpaccounts.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        grpaccounts.BorderColor = System.Drawing.Color.Black
        grpaccounts.BorderThickness = 1.0!
        grpaccounts.Controls.Add(dgviewaccounts)
        grpaccounts.CustomGroupBoxColor = System.Drawing.Color.White
        grpaccounts.Dock = System.Windows.Forms.DockStyle.Top
        grpaccounts.GroupImage = Global.Umbrella.My.Resources.Resources.accounting_management_icon
        grpaccounts.GroupTitle = "Account Details:"
        grpaccounts.Location = New System.Drawing.Point(0, 5)
        grpaccounts.Name = "grpaccounts"
        grpaccounts.Padding = New System.Windows.Forms.Padding(12, 25, 12, 10)
        grpaccounts.PaintGroupBox = False
        grpaccounts.RoundCorners = 10
        grpaccounts.ShadowColor = System.Drawing.Color.DarkGray
        grpaccounts.ShadowControl = False
        grpaccounts.ShadowThickness = 3
        grpaccounts.Size = New System.Drawing.Size(819, 130)
        grpaccounts.TabIndex = 40

        Me.dgviewaccounts.AllowUserToAddRows = False
        Me.dgviewaccounts.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.dgviewaccounts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgviewaccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgviewaccounts.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgviewaccounts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgviewaccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {clml, clm2, clm3, clm4})
        Me.dgviewaccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewaccounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgviewaccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgviewaccounts.Location = New System.Drawing.Point(16, 25)
        Me.dgviewaccounts.Name = "dgviewaccounts"
        Me.dgviewaccounts.ReadOnly = True
        Me.dgviewaccounts.RowHeadersVisible = False
        Me.dgviewaccounts.Size = New System.Drawing.Size(675, 111)
        Me.dgviewaccounts.TabIndex = 18
        Me.dgviewaccounts.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
        Me.dgviewaccounts.DefaultCellStyle.ForeColor = Color.Black
        Me.dgviewaccounts.DefaultCellStyle.SelectionBackColor = Color.White
        Me.dgviewaccounts.DefaultCellStyle.SelectionForeColor = Color.Black
        Me.dgviewaccounts.AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
        Me.dgviewaccounts.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
        Me.dgviewaccounts.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
        Me.dgviewaccounts.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black

        clml.HeaderText = "SL"
        clml.Name = "DataGridViewTextBoxColumn3"
        clml.ReadOnly = True
        clml.Width = 40

        clm2.HeaderText = "Account ID"
        clm2.Name = "DataGridViewTextBoxColumn4"
        clm2.ReadOnly = False
        clm2.Width = 148

        clm3.HeaderText = "Descriptions"
        clm3.Name = "DataGridViewTextBoxColumn5"
        clm3.ReadOnly = False
        clm3.Width = 490

        clm4.AllowDateSep = False
        clm4.AllowDecimal = True
        clm4.AllowMinus = False
        clm4.HeaderText = "Balance"
        clm4.MaxInputLength = 0
        clm4.Name = "NumericTextBoxColumn1"
        clm4.ReadOnly = False
        clm4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        clm4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        clm4.Width = 96

        Me.rndpnlfinancial.BackColor = System.Drawing.Color.White
        Me.rndpnlfinancial.BorderRadius = 32
        Me.rndpnlfinancial.Controls.Add(lblfinancialperiod)
        Me.rndpnlfinancial.Dock = System.Windows.Forms.DockStyle.Top
        Me.rndpnlfinancial.Location = New System.Drawing.Point(0, 5)
        Me.rndpnlfinancial.Name = "rndpnlfinancial"
        Me.rndpnlfinancial.Padding = New System.Windows.Forms.Padding(10)
        Me.rndpnlfinancial.Size = New System.Drawing.Size(819, 75)
        Me.rndpnlfinancial.TabIndex = 0

        lblfinancialperiod.Dock = System.Windows.Forms.DockStyle.Fill
        lblfinancialperiod.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblfinancialperiod.Location = New System.Drawing.Point(10, 10)
        lblfinancialperiod.Name = "lblfinancialperiod"
        lblfinancialperiod.Size = New System.Drawing.Size(799, 55)
        lblfinancialperiod.TabIndex = 0
        lblfinancialperiod.Text = "ELabel2"

        Me.Panel1.Controls.Add(rndpnlfinancial)
        Me.Panel1.Controls.Add(grpaccounts)
        Me.Panel1.Controls.Add(grpachievements)
        Me.Panel1.Controls.Add(grpfeatures)
        Me.Panel1.Controls.Add(grpcourse)
        Me.Panel1.Controls.Add(grpgeneral)
    End Sub
#End Region
#Region "Methods..."
    Private Sub LoadDataGridGeneral()
        dgviewgeneral.Rows.Clear()
        For i As Integer = 0 To 13
            dgviewgeneral.Rows.Add()
        Next
        dgviewgeneral.Rows(0).Cells(0).Value = "Institution ID:"
        dgviewgeneral.Rows(1).Cells(0).Value = "Category:"
        dgviewgeneral.Rows(2).Cells(0).Value = "Institution Name:"
        dgviewgeneral.Rows(3).Cells(0).Value = "Address Line 1:"
        dgviewgeneral.Rows(4).Cells(0).Value = "Address Line 2:"
        dgviewgeneral.Rows(5).Cells(0).Value = "City:"
        dgviewgeneral.Rows(6).Cells(0).Value = "State:"
        dgviewgeneral.Rows(7).Cells(0).Value = "Pin Code:"
        dgviewgeneral.Rows(8).Cells(0).Value = "Country:"
        dgviewgeneral.Rows(9).Cells(0).Value = "Telephone:"
        dgviewgeneral.Rows(10).Cells(0).Value = "Fax:"
        dgviewgeneral.Rows(11).Cells(0).Value = "Email:"
        dgviewgeneral.Rows(12).Cells(0).Value = "Website:"
        dgviewgeneral.Rows(13).Cells(0).Value = "Forum:"

        Dim comboBoxCell As New DataGridViewComboBoxCell
        comboBoxCell.Items.Add("Computer Institute")
        comboBoxCell.Items.Add("Engineering College")
        comboBoxCell.Items.Add("Graduation College")
        comboBoxCell.Items.Add("Management Institute")
        comboBoxCell.Items.Add("Medical College")
        comboBoxCell.Items.Add("Primary School")
        comboBoxCell.Items.Add("Secondary School")
        comboBoxCell.Items.Add("University")
        comboBoxCell.Items.Add("Others")
        comboBoxCell.FlatStyle = FlatStyle.Flat
        dgviewgeneral(1, 1) = comboBoxCell
        LoadGenValues()
    End Sub

    Private Sub LoadGenValues()
        Try
            cmd.CommandText = "select * from Institute where InsName='" & My.Settings.LastOpenedInstitute & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                dgviewgeneral.Rows(0).Cells(1).Value = dr("InsID").ToString()
                dgviewgeneral.Rows(1).Cells(1).Value = dr("Category").ToString()
                dgviewgeneral.Rows(2).Cells(1).Value = dr("InsName").ToString()
                dgviewgeneral.Rows(3).Cells(1).Value = dr("Address1").ToString()
                dgviewgeneral.Rows(4).Cells(1).Value = dr("Address2").ToString()
                dgviewgeneral.Rows(5).Cells(1).Value = dr("City").ToString()
                dgviewgeneral.Rows(6).Cells(1).Value = dr("State").ToString()
                dgviewgeneral.Rows(7).Cells(1).Value = dr("Pin").ToString()
                dgviewgeneral.Rows(8).Cells(1).Value = dr("Country").ToString()
                dgviewgeneral.Rows(9).Cells(1).Value = dr("Telephone").ToString()
                dgviewgeneral.Rows(10).Cells(1).Value = dr("Fax").ToString()
                dgviewgeneral.Rows(11).Cells(1).Value = dr("Email").ToString()
                dgviewgeneral.Rows(12).Cells(1).Value = dr("Url1").ToString()
                dgviewgeneral.Rows(13).Cells(1).Value = dr("Url2").ToString()
                lblfinancialperiod.Text = "Financial Period: " + dr("FinancialPeriod").ToString()
            End If
            dr.Close()
            For row As Integer = 0 To dgviewgeneral.Rows.Count - 1
                dgviewgeneral.Rows(row).Cells(0).Style.BackColor = Color.SteelBlue
                dgviewgeneral.Rows(row).Cells(0).Style.ForeColor = Color.White
                dgviewgeneral.Rows(row).Cells(0).Style.SelectionBackColor = Color.SteelBlue
                dgviewgeneral.Rows(row).Cells(0).Style.SelectionForeColor = Color.White
            Next
            dgviewgeneral.Rows(0).Cells(1).ReadOnly = True
            dgviewgeneral.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadCourseDetails()
        Try
            dgviewcourse.Rows.Clear()
            Dim row As Integer = 0
            cmd.CommandText = "select CourseName,CourseCode,Duration from Course where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewcourse.Rows.Add()
                dgviewcourse.Rows(row).Cells(0).Value = (row + 1).ToString()
                dgviewcourse.Rows(row).Cells(0).Style.BackColor = System.Drawing.SystemColors.Control
                dgviewcourse.Rows(row).Cells(1).Value = dr("CourseName").ToString()
                dgviewcourse.Rows(row).Cells(2).Value = dr("CourseCode").ToString()
                dgviewcourse.Rows(row).Cells(3).Value = dr("Duration").ToString()
                row += 1
            End While
            dr.Close()
            For i As Integer = 0 To dgviewcourse.Rows.Count - 1
                dgviewcourse.Rows(i).Cells(0).Style.BackColor = Color.SteelBlue
                dgviewcourse.Rows(i).Cells(0).Style.ForeColor = Color.White
                dgviewcourse.Rows(i).Cells(0).Style.SelectionBackColor = Color.SteelBlue
                dgviewcourse.Rows(i).Cells(0).Style.SelectionForeColor = Color.White
            Next
            dgviewcourse.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadFeaturesDetails()
        Try
            dgviewfeatures.Rows.Clear()
            Dim row As Integer = 0
            cmd.CommandText = "select Features from Features where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewfeatures.Rows.Add()
                dgviewfeatures.Rows(row).Cells(0).Value = (row + 1).ToString()
                dgviewfeatures.Rows(row).Cells(0).Style.BackColor = System.Drawing.SystemColors.Control
                dgviewfeatures.Rows(row).Cells(1).Value = dr("Features").ToString()
                row += 1
            End While
            dr.Close()
            For i As Integer = 0 To dgviewfeatures.Rows.Count - 1
                dgviewfeatures.Rows(i).Cells(0).Style.BackColor = Color.SteelBlue
                dgviewfeatures.Rows(i).Cells(0).Style.ForeColor = Color.White
                dgviewfeatures.Rows(i).Cells(0).Style.SelectionBackColor = Color.SteelBlue
                dgviewfeatures.Rows(i).Cells(0).Style.SelectionForeColor = Color.White
            Next
            dgviewfeatures.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadAchievementsDetails()
        Try
            dgviewachievements.Rows.Clear()
            Dim row As Integer = 0
            cmd.CommandText = "select Achievements from Achievements where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewachievements.Rows.Add()
                dgviewachievements.Rows(row).Cells(0).Value = (row + 1).ToString()
                dgviewachievements.Rows(row).Cells(0).Style.BackColor = System.Drawing.SystemColors.Control
                dgviewachievements.Rows(row).Cells(1).Value = dr("Achievements").ToString()
                row += 1
            End While
            dr.Close()
            For i As Integer = 0 To dgviewachievements.Rows.Count - 1
                dgviewachievements.Rows(i).Cells(0).Style.BackColor = Color.SteelBlue
                dgviewachievements.Rows(i).Cells(0).Style.ForeColor = Color.White
                dgviewachievements.Rows(i).Cells(0).Style.SelectionBackColor = Color.SteelBlue
                dgviewachievements.Rows(i).Cells(0).Style.SelectionForeColor = Color.White
            Next
            dgviewachievements.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadAccountsDetails()
        Try
            dgviewaccounts.Rows.Clear()
            Dim row As Integer = 0
            cmd.CommandText = "select AccountID,AccountName,AccountBalance from Accounts where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewaccounts.Rows.Add()
                dgviewaccounts.Rows(row).Cells(0).Value = (row + 1).ToString()
                dgviewaccounts.Rows(row).Cells(0).Style.BackColor = System.Drawing.SystemColors.Control
                dgviewaccounts.Rows(row).Cells(1).Value = dr("AccountID").ToString()
                dgviewaccounts.Rows(row).Cells(2).Value = dr("AccountName").ToString()
                Dim bal As Decimal = CDec(dr("AccountBalance").ToString())
                dgviewaccounts.Rows(row).Cells(3).Value = FormatNumber(bal.ToString())
                row += 1
            End While
            dr.Close()
            For i As Integer = 0 To dgviewaccounts.Rows.Count - 1
                dgviewaccounts.Rows(i).Cells(0).Style.BackColor = Color.SteelBlue
                dgviewaccounts.Rows(i).Cells(0).Style.ForeColor = Color.White
                dgviewaccounts.Rows(i).Cells(0).Style.SelectionBackColor = Color.SteelBlue
                dgviewaccounts.Rows(i).Cells(0).Style.SelectionForeColor = Color.White
            Next
            dgviewaccounts.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadDataGrids()
        LoadDataGridGeneral()
    End Sub

    Private Sub CheckInstituteName(ByVal insname As String)
        Try
            cmd.CommandText = "select * from Institute where InsName='" & insname & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                InsExist = True
            Else
                InsExist = False
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub UpdateInstitute(ByVal InsID As String, ByVal InsName As String, ByVal Address1 As String, ByVal Address2 As String, ByVal City As String, ByVal State As String, ByVal Pin As String, ByVal Country As String, ByVal Telephone As String, ByVal Fax As String, ByVal Email As String, ByVal Url1 As String, ByVal Url2 As String, ByVal Category As String)
        Try
            cmd.CommandText = "update Institute set InsName='" & InsName & "',Address1='" & Address1 & "',Address2='" & Address2 & "',City='" & City & "',State='" & State & "',Pin='" & Pin & "',Country='" & Country & "',Telephone='" & Telephone & "',Fax='" & Fax & "',Email='" & Email & "',Url1='" & Url1 & "',Url2='" & Url2 & "',Category='" & Category & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateInstituteOk = True
        Catch ex As Exception
            UpdateInstituteOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub UpdateAchievements(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal Achievements As String)
        Try
            cmd.CommandText = "insert into Achievements(InsID,InsName,Period,Achievements) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & Achievements & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateAchievementsOk = True
        Catch ex As Exception
            UpdateAchievementsOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub UpdateAllTables(ByVal InsID As String, ByVal InsName As String)
        Try
            cmd.CommandText = "update Users set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update UserCrystalReport set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update FinancialYear set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Course set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update CourseTermFees set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Features set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Achievements set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Accounts set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update AccountingPeriod set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update DefaultInstitute set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update DefaultLibrary set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update DefaultPayroll set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Employee set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update EmployeeLanguage set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update EmployeeAcademic set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update EmployeeTeachingExp set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update EmployeeResearchExp set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update EmployeeProficiency set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update EmployeeProgrammingLang set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update EmployeeActivity set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update HiredEmployee set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update EmployeeAttendance set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update StudentAttendance set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Notice set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update IDCard set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update StudentAdmision set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update StudentAdmisionExam set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update StudentPreAdmission set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update StudentRegistration set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update MonthlyFees set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update OtherFees set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update LateFees set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update ExamFee set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update libraryFees set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update YearlyFees set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Discount set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update StudentDiscount set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update FinancialLoan set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update IncomeExpenditure set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update BankDeposit set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Examination set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update ExamStudents set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update ExamGuard set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update OnlineExamQsn set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update OnlineExam set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Subjects set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Syllabus set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Assignment set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Marksheet set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update ProgressReport set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update StudentControl set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Alumni set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update StudentCertificate set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update EmployeeCertificate set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update InventoryHistory set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Inventory set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update InventoryItemPriceLevel set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Purchase set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update SalesInvoice set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Game set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update GroupBooks set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update SubjectBooks set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Books set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update BookCharges set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Issue set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update IssueBooks set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update ReturnBooks set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update LibraryCharges set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Department set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Designation set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update PayScale set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update DaHra set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update ProfessionalTax set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update PayslipHeaders set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update PFRate set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update PFRateIndividual set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update AdjustmentDeductions set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update WorkingHourly set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update WorkingDaily set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Salary set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update PayEmployee set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update PF set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update PFAdvanceWithdrawal set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update CloseMembership set InsName='" & InsName & "' where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateAllTablesOk = True
        Catch ex As Exception
            UpdateAllTablesOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            Dim InsID As String = dgviewgeneral.Rows(0).Cells(1).Value.ToString()
            Dim Category As String = dgviewgeneral.Rows(1).Cells(1).Value.ToString()
            Dim InsName As String = dgviewgeneral.Rows(2).Cells(1).Value.ToString()
            Dim Address1 As String = dgviewgeneral.Rows(3).Cells(1).Value.ToString()
            Dim Address2 As String = dgviewgeneral.Rows(4).Cells(1).Value.ToString()
            Dim City As String = dgviewgeneral.Rows(5).Cells(1).Value.ToString()
            Dim State As String = dgviewgeneral.Rows(6).Cells(1).Value.ToString()
            Dim Pin As String = dgviewgeneral.Rows(7).Cells(1).Value.ToString()
            Dim Country As String = dgviewgeneral.Rows(8).Cells(1).Value.ToString()
            Dim Telephone As String = dgviewgeneral.Rows(9).Cells(1).Value.ToString()
            Dim Fax As String = dgviewgeneral.Rows(10).Cells(1).Value.ToString()
            Dim Email As String = dgviewgeneral.Rows(11).Cells(1).Value.ToString()
            Dim Website As String = dgviewgeneral.Rows(12).Cells(1).Value.ToString()
            Dim Forum As String = dgviewgeneral.Rows(13).Cells(1).Value.ToString()

            CheckInstituteName(InsName)

            If InsExist = True Then
                UpdateInstitute(InsID, InsName, Address1, Address2, City, State, Pin, Country, Telephone, Fax, Email, Website, Forum, Category)
                cmd.CommandText = "delete from Achievements where InsID='" & InsID & "'"
                dr = cmd.ExecuteReader
                dr.Close()
                For i As Integer = 0 To dgviewachievements.Rows.Count - 1
                    Dim Achievement As String = dgviewachievements.Rows(i).Cells(1).Value.ToString()
                    If Achievement <> "" Then
                        UpdateAchievements(InsID, InsName, My.Settings.Period, Achievement)
                    End If
                Next
                If UpdateInstituteOk = True And UpdateAchievementsOk = True Then
                    Dim result As DialogResult = MessageBox.Show("Record Updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If result = DialogResult.OK Then
                        My.Settings.LastOpenedInstitute = InsName
                        frmMainForm.Text = "Umbrella ~ "
                        frmMainForm.Text += My.Settings.LastOpenedInstitute
                    End If
                End If
            Else
                UpdateInstitute(InsID, InsName, Address1, Address2, City, State, Pin, Country, Telephone, Fax, Email, Website, Forum, Category)
                UpdateAllTables(InsID, InsName)
                If UpdateInstituteOk = True And UpdateAllTablesOk = True Then
                    Dim result As DialogResult = MessageBox.Show("Record Updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If result = DialogResult.OK Then
                        My.Settings.LastOpenedInstitute = InsName
                        frmMainForm.Text = "Umbrella ~ "
                        frmMainForm.Text += My.Settings.LastOpenedInstitute
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            Dim result As DialogResult = MessageBox.Show("Are you sure to delete this Institution record?" + Environment.NewLine + "All data associated with this Institute will be deleted." + Environment.NewLine + "Do you want to proceed?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim InsID As String = dgviewgeneral.Rows(0).Cells(1).Value.ToString()
                cmd.CommandText = "delete from Institute where InsID='" & InsID & "'"
                dr = cmd.ExecuteReader
                dr.Close()
                Dim cls As New cImport()
                cls.DeleteAccountingPeriod()
                cls.DeleteAccounts()
                cls.DeleteAchievements()
                cls.DeleteAdjustmentDeduction()
                cls.DeleteAdvanceWithdrawal()
                cls.DeleteAlumni()
                cls.DeleteAssignment()
                cls.DeleteBankDeposit()
                cls.DeleteBook()
                cls.DeleteBookCharges()
                cls.DeleteCalculateCharges()
                cls.DeleteCourse()
                cls.DeleteDAHRA()
                cls.DeleteDefaultInstitute()
                cls.DeleteDefaultLibrary()
                cls.DeleteDefaultPayroll()
                cls.DeleteDepartment()
                cls.DeleteDesignation()
                cls.DeleteDiscount()
                cls.DeleteDiscountStudent()
                cls.DeleteEmployee()
                cls.DeleteEmployeeAcademic()
                cls.DeleteEmployeeActivity()
                cls.DeleteEmployeeAttendance()
                cls.DeleteEmployeeCertificate()
                cls.DeleteEmployeeLanguage()
                cls.DeleteEmployeePF()
                cls.DeleteEmployeeProficiency()
                cls.DeleteEmployeeProgrammingLang()
                cls.DeleteEmployeeReaserchExp()
                cls.DeleteEmployeeTeachingExp()
                cls.DeleteExamFees()
                cls.DeleteExamination()
                cls.DeleteExaminationGuard()
                cls.DeleteExaminationStudent()
                cls.DeleteFeatures()
                cls.DeleteFinancialLoan()
                cls.DeleteFinancialYear()
                cls.DeleteGame()
                cls.DeleteGroup()
                cls.DeleteHiredEmployee()
                cls.DeleteIDCard()
                cls.DeleteIncomeExpenditure()
                cls.DeleteIndexx()
                cls.DeleteIndividualPFRate()
                cls.DeleteInstitute()
                cls.DeleteInventory()
                cls.DeleteInventoryHistory()
                cls.DeleteInventoryPriceLevel()
                cls.DeleteIssue()
                cls.DeleteIssueBook()
                cls.DeleteLateFees()
                cls.DeleteLibraryFees()
                cls.DeleteMarksheet()
                cls.DeleteMembership()
                cls.DeleteMonthlyFees()
                cls.DeleteNotice()
                cls.DeleteOnlineExamination()
                cls.DeleteOnlineExaminationQsn()
                cls.DeleteOtherFees()
                cls.DeletePayEmployee()
                cls.DeletePayScale()
                cls.DeletePaySlipHeaders()
                cls.DeletePFRate()
                cls.DeleteProfTax()
                cls.DeleteProgressReport()
                cls.DeletePurchaseOrder()
                cls.DeleteReturnBook()
                cls.DeleteSalaryCalculation()
                cls.DeleteSalesInvoice()
                cls.DeleteStudentAdmision()
                cls.DeleteStudentAdmisionExam()
                cls.DeleteStudentAttendance()
                cls.DeleteStudentCertificate()
                cls.DeleteStudentControl()
                cls.DeleteStudentPreAdmision()
                cls.DeleteStudentRegistration()
                cls.DeleteSubject()
                cls.DeleteSubjectBook()
                cls.DeleteSyllabus()
                cls.DeleteTermsFees()
                cls.DeleteUserCrystalReport()
                cls.DeleteUsers()
                cls.DeleteWorkingDay()
                cls.DeleteWorkingHours()
                cls.DeleteYearlyFees()
                Dim result1 As DialogResult = MessageBox.Show("Record deleted successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If result1 = DialogResult.OK Then
                    My.Settings.LastOpenedInstitute = ""
                    My.Settings.LastOpenedInstituteID = ""
                    My.Settings.Period = ""
                    My.Settings.FinancialPeriod = ""
                    frmMainForm.Text = "Umbrella ~ "
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmInstitute_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadDesign()
        LoadDataGrids()
        LoadAccountsDetails()
        LoadAchievementsDetails()
        LoadCourseDetails()
        LoadFeaturesDetails()
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnupdate_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnupdate.ClickButtonArea
        Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            UpdateRecord()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        DeleteRecord()
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        LoadDataGrids()
        LoadAccountsDetails()
        LoadAchievementsDetails()
        LoadCourseDetails()
        LoadFeaturesDetails()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region