Imports Umbrella.UIControls
Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssignments
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DesignerRectTracker1 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAssignments))
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
        Dim DesignerRectTracker13 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker14 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim CBlendItems1 As ESAR_Controls.cBlendItems = New ESAR_Controls.cBlendItems
        Me.GradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.dgviewassignments = New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
        Me.Column6 = New System.Windows.Forms.DataGridViewLinkColumn
        Me.Column7 = New ESAR_Controls.UIControls.DataGridView.eCalendarColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RoundedPanel2 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.btnselect = New ESAR_Controls.UIControls.Button.eButton
        Me.txtassignment = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.txtassignmentid = New ESAR_Controls.UIControls.TextBox.eTextBox
        Me.cmbsubject = New ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
        Me.cmbcourse = New ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
        Me.cmbdate = New ESAR_Controls.UIControls.ComboBox.eComboBoxDateTime
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.RoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.btnhelp = New ESAR_Controls.UIControls.Button.eButton
        Me.btnrefresh = New ESAR_Controls.UIControls.Button.eButton
        Me.btndelete = New ESAR_Controls.UIControls.Button.eButton
        Me.btnsavenew = New ESAR_Controls.UIControls.Button.eButton
        Me.btnsave = New ESAR_Controls.UIControls.Button.eButton
        Me.btnnew = New ESAR_Controls.UIControls.Button.eButton
        Me.ELabel1 = New ESAR_Controls.eLabel
        Me.GradientPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgviewassignments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundedPanel2.SuspendLayout()
        Me.RoundedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GradientPanel1
        '
        Me.GradientPanel1.Controls.Add(Me.Panel1)
        Me.GradientPanel1.Controls.Add(Me.RoundedPanel1)
        Me.GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GradientPanel1.EndColor = System.Drawing.Color.RoyalBlue
        Me.GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanel1.Name = "GradientPanel1"
        Me.GradientPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.GradientPanel1.Size = New System.Drawing.Size(839, 556)
        Me.GradientPanel1.StartColor = System.Drawing.Color.LightCyan
        Me.GradientPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.RoundedPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(819, 476)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgviewassignments)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 105)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(819, 371)
        Me.Panel2.TabIndex = 1
        '
        'dgviewassignments
        '
        Me.dgviewassignments.AllowUserToAddRows = False
        Me.dgviewassignments.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgviewassignments.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgviewassignments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgviewassignments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgviewassignments.BackgroundColor = System.Drawing.Color.White
        Me.dgviewassignments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewassignments.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgviewassignments.DisplaySumRowHeader = False
        Me.dgviewassignments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewassignments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgviewassignments.Location = New System.Drawing.Point(5, 5)
        Me.dgviewassignments.Name = "dgviewassignments"
        Me.dgviewassignments.ReadOnly = True
        Me.dgviewassignments.RowHeadersVisible = False
        Me.dgviewassignments.Size = New System.Drawing.Size(809, 361)
        Me.dgviewassignments.SummaryColumns = Nothing
        Me.dgviewassignments.SummaryRowBackColor = System.Drawing.Color.Empty
        Me.dgviewassignments.SummaryRowSpace = 0
        Me.dgviewassignments.SummaryRowVisible = False
        Me.dgviewassignments.SumRowHeaderText = Nothing
        Me.dgviewassignments.SumRowHeaderTextBold = False
        Me.dgviewassignments.TabIndex = 2
        '
        'Column6
        '
        Me.Column6.HeaderText = "ID"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Date"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Course"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Subject"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "Assignments"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'RoundedPanel2
        '
        Me.RoundedPanel2.BackColor = System.Drawing.Color.White
        Me.RoundedPanel2.BorderRadius = 32
        Me.RoundedPanel2.Controls.Add(Me.btnselect)
        Me.RoundedPanel2.Controls.Add(Me.txtassignment)
        Me.RoundedPanel2.Controls.Add(Me.txtassignmentid)
        Me.RoundedPanel2.Controls.Add(Me.cmbsubject)
        Me.RoundedPanel2.Controls.Add(Me.cmbcourse)
        Me.RoundedPanel2.Controls.Add(Me.cmbdate)
        Me.RoundedPanel2.Controls.Add(Me.Label5)
        Me.RoundedPanel2.Controls.Add(Me.Label4)
        Me.RoundedPanel2.Controls.Add(Me.Label6)
        Me.RoundedPanel2.Controls.Add(Me.Label3)
        Me.RoundedPanel2.Controls.Add(Me.Label2)
        Me.RoundedPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.RoundedPanel2.Location = New System.Drawing.Point(0, 5)
        Me.RoundedPanel2.Name = "RoundedPanel2"
        Me.RoundedPanel2.Padding = New System.Windows.Forms.Padding(10)
        Me.RoundedPanel2.Size = New System.Drawing.Size(819, 100)
        Me.RoundedPanel2.TabIndex = 0
        '
        'btnselect
        '
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnselect.CenterPtTracker = DesignerRectTracker1
        Me.btnselect.ColorFillSolid = System.Drawing.Color.White
        Me.btnselect.Corners.All = CType(11, Short)
        Me.btnselect.Corners.LowerLeft = CType(11, Short)
        Me.btnselect.Corners.LowerRight = CType(11, Short)
        Me.btnselect.Corners.UpperLeft = CType(11, Short)
        Me.btnselect.Corners.UpperRight = CType(11, Short)
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnselect.FocusPtTracker = DesignerRectTracker2
        Me.btnselect.Image = Global.Umbrella.My.Resources.Resources.assignment
        Me.btnselect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnselect.ImageIndex = 0
        Me.btnselect.Location = New System.Drawing.Point(496, 65)
        Me.btnselect.Name = "btnselect"
        Me.btnselect.Size = New System.Drawing.Size(153, 25)
        Me.btnselect.TabIndex = 3
        Me.btnselect.Text = "Select Assignment"
        Me.btnselect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnselect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnselect.TextShadowShow = False
        '
        'txtassignment
        '
        Me.txtassignment.BackColor = System.Drawing.Color.White
        Me.txtassignment.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtassignment.Location = New System.Drawing.Point(125, 69)
        Me.txtassignment.Name = "txtassignment"
        Me.txtassignment.ReadOnly = True
        Me.txtassignment.Required = True
        Me.txtassignment.ShowErrorIcon = False
        Me.txtassignment.Size = New System.Drawing.Size(365, 21)
        Me.txtassignment.TabIndex = 2
        Me.txtassignment.TextBox = ""
        Me.txtassignment.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtassignment.WaterMark = "Select Assignment"
        Me.txtassignment.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtassignment.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtassignment.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'txtassignmentid
        '
        Me.txtassignmentid.BackColor = System.Drawing.Color.White
        Me.txtassignmentid.LinkType = ESAR_Controls.UIControls.TextBox.LinkTypes.None
        Me.txtassignmentid.Location = New System.Drawing.Point(125, 15)
        Me.txtassignmentid.Name = "txtassignmentid"
        Me.txtassignmentid.Required = False
        Me.txtassignmentid.ShowErrorIcon = False
        Me.txtassignmentid.Size = New System.Drawing.Size(130, 21)
        Me.txtassignmentid.TabIndex = 4
        Me.txtassignmentid.TextBox = ""
        Me.txtassignmentid.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.txtassignmentid.WaterMark = "Enter Assignment ID"
        Me.txtassignmentid.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.txtassignmentid.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtassignmentid.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'cmbsubject
        '
        Me.cmbsubject.FormattingEnabled = True
        Me.cmbsubject.InstantBinding = True
        Me.cmbsubject.Location = New System.Drawing.Point(360, 42)
        Me.cmbsubject.Name = "cmbsubject"
        Me.cmbsubject.Size = New System.Drawing.Size(130, 21)
        Me.cmbsubject.TabIndex = 1
        '
        'cmbcourse
        '
        Me.cmbcourse.FormattingEnabled = True
        Me.cmbcourse.InstantBinding = True
        Me.cmbcourse.Location = New System.Drawing.Point(125, 42)
        Me.cmbcourse.Name = "cmbcourse"
        Me.cmbcourse.Size = New System.Drawing.Size(130, 21)
        Me.cmbcourse.TabIndex = 0
        '
        'cmbdate
        '
        Me.cmbdate.FormatString = "d"
        Me.cmbdate.FormattingEnabled = True
        Me.cmbdate.Location = New System.Drawing.Point(360, 15)
        Me.cmbdate.Name = "cmbdate"
        Me.cmbdate.Size = New System.Drawing.Size(130, 21)
        Me.cmbdate.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Assignments:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(265, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Select Subject:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Select Course:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(320, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Assignment ID:"
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
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnhelp.CenterPtTracker = DesignerRectTracker3
        Me.btnhelp.ColorFillSolid = System.Drawing.Color.White
        Me.btnhelp.Corners.All = CType(-1, Short)
        Me.btnhelp.Corners.LowerLeft = CType(20, Short)
        Me.btnhelp.Corners.LowerRight = CType(12, Short)
        Me.btnhelp.Corners.UpperLeft = CType(12, Short)
        Me.btnhelp.Corners.UpperRight = CType(20, Short)
        Me.btnhelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhelp.Dock = System.Windows.Forms.DockStyle.Left
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnhelp.FocusPtTracker = DesignerRectTracker4
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
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnrefresh.CenterPtTracker = DesignerRectTracker5
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
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnrefresh.FocusPtTracker = DesignerRectTracker6
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
        DesignerRectTracker7.IsActive = False
        DesignerRectTracker7.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker7.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btndelete.CenterPtTracker = DesignerRectTracker7
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
        DesignerRectTracker8.IsActive = False
        DesignerRectTracker8.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker8.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btndelete.FocusPtTracker = DesignerRectTracker8
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
        DesignerRectTracker9.IsActive = False
        DesignerRectTracker9.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker9.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsavenew.CenterPtTracker = DesignerRectTracker9
        Me.btnsavenew.ColorFillSolid = System.Drawing.Color.White
        Me.btnsavenew.Corners.All = CType(-1, Short)
        Me.btnsavenew.Corners.LowerLeft = CType(20, Short)
        Me.btnsavenew.Corners.LowerRight = CType(12, Short)
        Me.btnsavenew.Corners.UpperLeft = CType(12, Short)
        Me.btnsavenew.Corners.UpperRight = CType(20, Short)
        Me.btnsavenew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsavenew.Dock = System.Windows.Forms.DockStyle.Left
        DesignerRectTracker10.IsActive = False
        DesignerRectTracker10.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker10.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsavenew.FocusPtTracker = DesignerRectTracker10
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
        DesignerRectTracker11.IsActive = False
        DesignerRectTracker11.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker11.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsave.CenterPtTracker = DesignerRectTracker11
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
        DesignerRectTracker12.IsActive = False
        DesignerRectTracker12.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker12.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnsave.FocusPtTracker = DesignerRectTracker12
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
        DesignerRectTracker13.IsActive = False
        DesignerRectTracker13.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker13.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnnew.CenterPtTracker = DesignerRectTracker13
        Me.btnnew.ColorFillSolid = System.Drawing.Color.White
        Me.btnnew.Corners.All = CType(-1, Short)
        Me.btnnew.Corners.LowerLeft = CType(20, Short)
        Me.btnnew.Corners.LowerRight = CType(12, Short)
        Me.btnnew.Corners.UpperLeft = CType(12, Short)
        Me.btnnew.Corners.UpperRight = CType(20, Short)
        Me.btnnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnew.Dock = System.Windows.Forms.DockStyle.Left
        DesignerRectTracker14.IsActive = False
        DesignerRectTracker14.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker14.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnnew.FocusPtTracker = DesignerRectTracker14
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
        Me.ELabel1.Location = New System.Drawing.Point(574, 10)
        Me.ELabel1.MouseOverColor = System.Drawing.Color.Gray
        Me.ELabel1.Name = "ELabel1"
        Me.ELabel1.ShadowState = True
        Me.ELabel1.Size = New System.Drawing.Size(235, 40)
        Me.ELabel1.TabIndex = 34
        Me.ELabel1.Text = "Maintain Assignment"
        '
        'frmAssignments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(839, 556)
        Me.ControlBox = False
        Me.Controls.Add(Me.GradientPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.Custom
        Me.Name = "frmAssignments"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maintain Assignment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GradientPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgviewassignments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPanel2.ResumeLayout(False)
        Me.RoundedPanel2.PerformLayout()
        Me.RoundedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents RoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RoundedPanel2 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents cmbsubject As ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
    Friend WithEvents cmbcourse As ESAR_Controls.UIControls.ComboBox.eComboBoxDataGridView
    Friend WithEvents cmbdate As ESAR_Controls.UIControls.ComboBox.eComboBoxDateTime
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtassignment As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents txtassignmentid As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents ELabel1 As ESAR_Controls.eLabel
    Friend WithEvents btnhelp As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnrefresh As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btndelete As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnsavenew As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnsave As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnnew As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnselect As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents dgviewassignments As ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Column7 As ESAR_Controls.UIControls.DataGridView.eCalendarColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
