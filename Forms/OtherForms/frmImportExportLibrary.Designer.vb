Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportExportLibrary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImportExportLibrary))
        Dim DesignerRectTracker2 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker3 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker4 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker5 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker6 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim CBlendItems1 As ESAR_Controls.cBlendItems = New ESAR_Controls.cBlendItems
        Me.GradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.btntask = New System.Windows.Forms.Button
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.btnsystem = New System.Windows.Forms.Button
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
        Me.GradientPanel1.TabIndex = 1
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
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btntask)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 30)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel6.Size = New System.Drawing.Size(143, 30)
        Me.Panel6.TabIndex = 16
        '
        'btntask
        '
        Me.btntask.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntask.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btntask.FlatAppearance.BorderSize = 0
        Me.btntask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btntask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btntask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntask.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntask.Image = Global.Umbrella.My.Resources.Resources.task_icon
        Me.btntask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntask.Location = New System.Drawing.Point(0, 5)
        Me.btntask.Name = "btntask"
        Me.btntask.Size = New System.Drawing.Size(143, 25)
        Me.btntask.TabIndex = 1
        Me.btntask.Text = "Task"
        Me.btntask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btntask.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.btnsystem)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel10.Size = New System.Drawing.Size(143, 30)
        Me.Panel10.TabIndex = 15
        '
        'btnsystem
        '
        Me.btnsystem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsystem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnsystem.FlatAppearance.BorderSize = 0
        Me.btnsystem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnsystem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnsystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsystem.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsystem.Image = Global.Umbrella.My.Resources.Resources.Umbrella_icon
        Me.btnsystem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsystem.Location = New System.Drawing.Point(0, 5)
        Me.btnsystem.Name = "btnsystem"
        Me.btnsystem.Size = New System.Drawing.Size(143, 25)
        Me.btnsystem.TabIndex = 1
        Me.btnsystem.Text = "System"
        Me.btnsystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsystem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsystem.UseVisualStyleBackColor = True
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
        'frmImportExportLibrary
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
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.RoyalLight
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImportExportLibrary"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GradientPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
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
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btntask As System.Windows.Forms.Button
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents btnsystem As System.Windows.Forms.Button
    Friend WithEvents ERoundedPanel2 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblselecteddetails As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lstlist As System.Windows.Forms.ListBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblselected As System.Windows.Forms.Label
    Friend WithEvents RoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents btnhelp As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnexport As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnimport As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents ELabel1 As ESAR_Controls.eLabel
End Class
