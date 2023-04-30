Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportExportInstitute
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImportExportInstitute))
        Dim DesignerRectTracker2 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker3 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker4 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker5 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker6 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim CBlendItems1 As ESAR_Controls.cBlendItems = New ESAR_Controls.cBlendItems
        Me.GradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.btnactivity = New System.Windows.Forms.Button
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.btnexamination = New System.Windows.Forms.Button
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.btnfees = New System.Windows.Forms.Button
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.btnadmission = New System.Windows.Forms.Button
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.btninstitute = New System.Windows.Forms.Button
        Me.ERoundedPanel2 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.lblselecteddetails = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.lstlist = New System.Windows.Forms.ListBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblselected = New System.Windows.Forms.Label
        Me.RoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.btnhelp = New ESAR_Controls.UIControls.Button.eButton
        Me.btnexport = New ESAR_Controls.UIControls.Button.eButton
        Me.btnimport = New ESAR_Controls.UIControls.Button.eButton
        Me.ELabel1 = New ESAR_Controls.eLabel
        Me.GradientPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.ERoundedPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.RoundedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GradientPanel1
        '
        Me.GradientPanel1.Controls.Add(Me.SplitContainer1)
        Me.GradientPanel1.Controls.Add(Me.RoundedPanel1)
        Me.GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GradientPanel1.EndColor = System.Drawing.Color.RoyalBlue
        Me.GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanel1.Name = "GradientPanel1"
        Me.GradientPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.GradientPanel1.Size = New System.Drawing.Size(449, 364)
        Me.GradientPanel1.StartColor = System.Drawing.Color.LightCyan
        Me.GradientPanel1.TabIndex = 0
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel10)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ERoundedPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(429, 284)
        Me.SplitContainer1.SplitterDistance = 143
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 15
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.btnactivity)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 120)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel9.Size = New System.Drawing.Size(143, 30)
        Me.Panel9.TabIndex = 19
        '
        'btnactivity
        '
        Me.btnactivity.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnactivity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnactivity.FlatAppearance.BorderSize = 0
        Me.btnactivity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnactivity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnactivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnactivity.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactivity.Image = Global.Umbrella.My.Resources.Resources.activity_icon
        Me.btnactivity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnactivity.Location = New System.Drawing.Point(0, 5)
        Me.btnactivity.Name = "btnactivity"
        Me.btnactivity.Size = New System.Drawing.Size(143, 25)
        Me.btnactivity.TabIndex = 1
        Me.btnactivity.Text = "Activity"
        Me.btnactivity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnactivity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnactivity.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.btnexamination)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 90)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel8.Size = New System.Drawing.Size(143, 30)
        Me.Panel8.TabIndex = 18
        '
        'btnexamination
        '
        Me.btnexamination.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexamination.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnexamination.FlatAppearance.BorderSize = 0
        Me.btnexamination.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnexamination.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnexamination.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexamination.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexamination.Image = Global.Umbrella.My.Resources.Resources.examination_icon
        Me.btnexamination.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnexamination.Location = New System.Drawing.Point(0, 5)
        Me.btnexamination.Name = "btnexamination"
        Me.btnexamination.Size = New System.Drawing.Size(143, 25)
        Me.btnexamination.TabIndex = 1
        Me.btnexamination.Text = "Examination"
        Me.btnexamination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnexamination.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnexamination.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnfees)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 60)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel7.Size = New System.Drawing.Size(143, 30)
        Me.Panel7.TabIndex = 17
        '
        'btnfees
        '
        Me.btnfees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnfees.FlatAppearance.BorderSize = 0
        Me.btnfees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnfees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnfees.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfees.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfees.Image = Global.Umbrella.My.Resources.Resources.fees_icon
        Me.btnfees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnfees.Location = New System.Drawing.Point(0, 5)
        Me.btnfees.Name = "btnfees"
        Me.btnfees.Size = New System.Drawing.Size(143, 25)
        Me.btnfees.TabIndex = 1
        Me.btnfees.Text = "Fees"
        Me.btnfees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnfees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnfees.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnadmission)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 30)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel6.Size = New System.Drawing.Size(143, 30)
        Me.Panel6.TabIndex = 16
        '
        'btnadmission
        '
        Me.btnadmission.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadmission.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnadmission.FlatAppearance.BorderSize = 0
        Me.btnadmission.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnadmission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnadmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadmission.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadmission.Image = Global.Umbrella.My.Resources.Resources.admission_icon
        Me.btnadmission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnadmission.Location = New System.Drawing.Point(0, 5)
        Me.btnadmission.Name = "btnadmission"
        Me.btnadmission.Size = New System.Drawing.Size(143, 25)
        Me.btnadmission.TabIndex = 1
        Me.btnadmission.Text = "Admission"
        Me.btnadmission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnadmission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnadmission.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.btninstitute)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel10.Size = New System.Drawing.Size(143, 30)
        Me.Panel10.TabIndex = 15
        '
        'btninstitute
        '
        Me.btninstitute.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btninstitute.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btninstitute.FlatAppearance.BorderSize = 0
        Me.btninstitute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btninstitute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btninstitute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninstitute.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninstitute.Image = Global.Umbrella.My.Resources.Resources.Umbrella_icon
        Me.btninstitute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btninstitute.Location = New System.Drawing.Point(0, 5)
        Me.btninstitute.Name = "btninstitute"
        Me.btninstitute.Size = New System.Drawing.Size(143, 25)
        Me.btninstitute.TabIndex = 1
        Me.btninstitute.Text = "Institute"
        Me.btninstitute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btninstitute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btninstitute.UseVisualStyleBackColor = True
        '
        'ERoundedPanel2
        '
        Me.ERoundedPanel2.BackColor = System.Drawing.Color.White
        Me.ERoundedPanel2.BorderRadius = 32
        Me.ERoundedPanel2.Controls.Add(Me.Panel2)
        Me.ERoundedPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel2.Location = New System.Drawing.Point(0, 0)
        Me.ERoundedPanel2.Name = "ERoundedPanel2"
        Me.ERoundedPanel2.Padding = New System.Windows.Forms.Padding(10)
        Me.ERoundedPanel2.Size = New System.Drawing.Size(281, 284)
        Me.ERoundedPanel2.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(10, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(261, 264)
        Me.Panel2.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lblselecteddetails)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 188)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel5.Size = New System.Drawing.Size(261, 76)
        Me.Panel5.TabIndex = 2
        '
        'lblselecteddetails
        '
        Me.lblselecteddetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblselecteddetails.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblselecteddetails.Location = New System.Drawing.Point(0, 5)
        Me.lblselecteddetails.Name = "lblselecteddetails"
        Me.lblselecteddetails.Size = New System.Drawing.Size(261, 71)
        Me.lblselecteddetails.TabIndex = 1
        Me.lblselecteddetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lstlist)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 26)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel4.Size = New System.Drawing.Size(261, 162)
        Me.Panel4.TabIndex = 1
        '
        'lstlist
        '
        Me.lstlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstlist.FormattingEnabled = True
        Me.lstlist.Location = New System.Drawing.Point(0, 5)
        Me.lstlist.Name = "lstlist"
        Me.lstlist.Size = New System.Drawing.Size(261, 147)
        Me.lstlist.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblselected)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel3.Size = New System.Drawing.Size(261, 26)
        Me.Panel3.TabIndex = 0
        '
        'lblselected
        '
        Me.lblselected.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblselected.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblselected.Location = New System.Drawing.Point(0, 5)
        Me.lblselected.Name = "lblselected"
        Me.lblselected.Size = New System.Drawing.Size(261, 21)
        Me.lblselected.TabIndex = 0
        Me.lblselected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.RoundedPanel1.BorderRadius = 32
        Me.RoundedPanel1.Controls.Add(Me.btnhelp)
        Me.RoundedPanel1.Controls.Add(Me.btnexport)
        Me.RoundedPanel1.Controls.Add(Me.btnimport)
        Me.RoundedPanel1.Controls.Add(Me.ELabel1)
        Me.RoundedPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RoundedPanel1.Location = New System.Drawing.Point(10, 10)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.RoundedPanel1.Size = New System.Drawing.Size(429, 60)
        Me.RoundedPanel1.TabIndex = 14
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
        Me.btnhelp.Location = New System.Drawing.Point(177, 10)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(63, 40)
        Me.btnhelp.TabIndex = 80
        Me.btnhelp.Text = "Help"
        Me.btnhelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhelp.TextShadowShow = False
        '
        'btnexport
        '
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnexport.CenterPtTracker = DesignerRectTracker3
        Me.btnexport.ColorFillSolid = System.Drawing.Color.White
        Me.btnexport.Corners.All = CType(-1, Short)
        Me.btnexport.Corners.LowerLeft = CType(20, Short)
        Me.btnexport.Corners.LowerRight = CType(12, Short)
        Me.btnexport.Corners.UpperLeft = CType(12, Short)
        Me.btnexport.Corners.UpperRight = CType(20, Short)
        Me.btnexport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexport.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnexport.FocalPoints.CenterPtX = 0.4578313!
        Me.btnexport.FocalPoints.CenterPtY = 0.375!
        Me.btnexport.FocalPoints.FocusPtX = 0.0!
        Me.btnexport.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnexport.FocusPtTracker = DesignerRectTracker4
        Me.btnexport.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexport.Image = Global.Umbrella.My.Resources.Resources.export_icon
        Me.btnexport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnexport.ImageIndex = 0
        Me.btnexport.Location = New System.Drawing.Point(94, 10)
        Me.btnexport.Name = "btnexport"
        Me.btnexport.Size = New System.Drawing.Size(83, 40)
        Me.btnexport.TabIndex = 79
        Me.btnexport.Text = "Export"
        Me.btnexport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnexport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnexport.TextShadowShow = False
        '
        'btnimport
        '
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnimport.CenterPtTracker = DesignerRectTracker5
        Me.btnimport.ColorFillSolid = System.Drawing.Color.White
        Me.btnimport.Corners.All = CType(-1, Short)
        Me.btnimport.Corners.LowerLeft = CType(20, Short)
        Me.btnimport.Corners.LowerRight = CType(12, Short)
        Me.btnimport.Corners.UpperLeft = CType(12, Short)
        Me.btnimport.Corners.UpperRight = CType(20, Short)
        Me.btnimport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnimport.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnimport.FocalPoints.CenterPtX = 0.4642857!
        Me.btnimport.FocalPoints.CenterPtY = 0.425!
        Me.btnimport.FocalPoints.FocusPtX = 0.0!
        Me.btnimport.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnimport.FocusPtTracker = DesignerRectTracker6
        Me.btnimport.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimport.Image = Global.Umbrella.My.Resources.Resources.import_icon
        Me.btnimport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnimport.ImageIndex = 0
        Me.btnimport.Location = New System.Drawing.Point(10, 10)
        Me.btnimport.Name = "btnimport"
        Me.btnimport.Size = New System.Drawing.Size(84, 40)
        Me.btnimport.TabIndex = 78
        Me.btnimport.Text = "Import"
        Me.btnimport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnimport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnimport.TextShadowShow = False
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
        Me.ELabel1.Location = New System.Drawing.Point(266, 10)
        Me.ELabel1.MouseOverColor = System.Drawing.Color.Gray
        Me.ELabel1.Name = "ELabel1"
        Me.ELabel1.ShadowState = True
        Me.ELabel1.Size = New System.Drawing.Size(153, 40)
        Me.ELabel1.TabIndex = 35
        Me.ELabel1.Text = "Import & Export"
        '
        'frmImportExportInstitute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(449, 364)
        Me.Controls.Add(Me.GradientPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.Custom
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImportExportInstitute"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GradientPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.ERoundedPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.RoundedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents RoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents ELabel1 As ESAR_Controls.eLabel
    Friend WithEvents btnhelp As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnexport As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnimport As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ERoundedPanel2 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblselecteddetails As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lstlist As System.Windows.Forms.ListBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblselected As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents btnactivity As System.Windows.Forms.Button
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents btnexamination As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnfees As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnadmission As System.Windows.Forms.Button
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents btninstitute As System.Windows.Forms.Button
End Class
