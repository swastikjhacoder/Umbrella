Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainSelect))
        Dim DesignerRectTracker2 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker3 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker4 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker5 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker6 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Me.EGradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.RoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.btninstitute = New ESAR_Controls.UIControls.Button.eButton
        Me.btnlibrary = New ESAR_Controls.UIControls.Button.eButton
        Me.btnpayroll = New ESAR_Controls.UIControls.Button.eButton
        Me.btnclose = New System.Windows.Forms.Button
        Me.EGradientPanel1.SuspendLayout()
        Me.RoundedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EGradientPanel1
        '
        Me.EGradientPanel1.Controls.Add(Me.RoundedPanel1)
        Me.EGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGradientPanel1.EndColor = System.Drawing.Color.RoyalBlue
        Me.EGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.EGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EGradientPanel1.Name = "EGradientPanel1"
        Me.EGradientPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.EGradientPanel1.Size = New System.Drawing.Size(338, 255)
        Me.EGradientPanel1.StartColor = System.Drawing.Color.LightCyan
        Me.EGradientPanel1.TabIndex = 0
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.RoundedPanel1.BorderRadius = 32
        Me.RoundedPanel1.Controls.Add(Me.btninstitute)
        Me.RoundedPanel1.Controls.Add(Me.btnlibrary)
        Me.RoundedPanel1.Controls.Add(Me.btnpayroll)
        Me.RoundedPanel1.Controls.Add(Me.btnclose)
        Me.RoundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RoundedPanel1.Location = New System.Drawing.Point(10, 10)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Padding = New System.Windows.Forms.Padding(25)
        Me.RoundedPanel1.Size = New System.Drawing.Size(318, 235)
        Me.RoundedPanel1.TabIndex = 1
        '
        'btninstitute
        '
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btninstitute.CenterPtTracker = DesignerRectTracker1
        Me.btninstitute.ColorFillSolid = System.Drawing.Color.AliceBlue
        Me.btninstitute.Corners.All = CType(-1, Short)
        Me.btninstitute.Corners.LowerLeft = CType(25, Short)
        Me.btninstitute.Corners.LowerRight = CType(12, Short)
        Me.btninstitute.Corners.UpperLeft = CType(12, Short)
        Me.btninstitute.Corners.UpperRight = CType(25, Short)
        Me.btninstitute.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btninstitute.FillType = ESAR_Controls.UIControls.Button.eButton.eFillType.Solid
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btninstitute.FocusPtTracker = DesignerRectTracker2
        Me.btninstitute.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninstitute.ForeColor = System.Drawing.Color.Black
        Me.btninstitute.Image = Global.Umbrella.My.Resources.Resources.Umbrella_icon
        Me.btninstitute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btninstitute.ImageIndex = 0
        Me.btninstitute.ImageSize = New System.Drawing.Size(20, 20)
        Me.btninstitute.Location = New System.Drawing.Point(25, 34)
        Me.btninstitute.Name = "btninstitute"
        Me.btninstitute.SideImageSize = New System.Drawing.Size(16, 16)
        Me.btninstitute.Size = New System.Drawing.Size(266, 50)
        Me.btninstitute.TabIndex = 0
        Me.btninstitute.Text = "Institution Management System"
        Me.btninstitute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btninstitute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btninstitute.TextShadowShow = False
        '
        'btnlibrary
        '
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnlibrary.CenterPtTracker = DesignerRectTracker3
        Me.btnlibrary.ColorFillSolid = System.Drawing.Color.AliceBlue
        Me.btnlibrary.Corners.All = CType(-1, Short)
        Me.btnlibrary.Corners.LowerLeft = CType(25, Short)
        Me.btnlibrary.Corners.LowerRight = CType(12, Short)
        Me.btnlibrary.Corners.UpperLeft = CType(12, Short)
        Me.btnlibrary.Corners.UpperRight = CType(25, Short)
        Me.btnlibrary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlibrary.FillType = ESAR_Controls.UIControls.Button.eButton.eFillType.Solid
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnlibrary.FocusPtTracker = DesignerRectTracker4
        Me.btnlibrary.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlibrary.ForeColor = System.Drawing.Color.Black
        Me.btnlibrary.Image = Global.Umbrella.My.Resources.Resources.library_icon
        Me.btnlibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlibrary.ImageIndex = 0
        Me.btnlibrary.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnlibrary.Location = New System.Drawing.Point(25, 90)
        Me.btnlibrary.Name = "btnlibrary"
        Me.btnlibrary.SideImageSize = New System.Drawing.Size(16, 16)
        Me.btnlibrary.Size = New System.Drawing.Size(266, 50)
        Me.btnlibrary.TabIndex = 1
        Me.btnlibrary.Text = "Library Management System"
        Me.btnlibrary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlibrary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnlibrary.TextShadowShow = False
        '
        'btnpayroll
        '
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnpayroll.CenterPtTracker = DesignerRectTracker5
        Me.btnpayroll.ColorFillSolid = System.Drawing.Color.AliceBlue
        Me.btnpayroll.Corners.All = CType(-1, Short)
        Me.btnpayroll.Corners.LowerLeft = CType(25, Short)
        Me.btnpayroll.Corners.LowerRight = CType(12, Short)
        Me.btnpayroll.Corners.UpperLeft = CType(12, Short)
        Me.btnpayroll.Corners.UpperRight = CType(25, Short)
        Me.btnpayroll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpayroll.FillType = ESAR_Controls.UIControls.Button.eButton.eFillType.Solid
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnpayroll.FocusPtTracker = DesignerRectTracker6
        Me.btnpayroll.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpayroll.ForeColor = System.Drawing.Color.Black
        Me.btnpayroll.Image = Global.Umbrella.My.Resources.Resources.payroll_icon
        Me.btnpayroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpayroll.ImageIndex = 0
        Me.btnpayroll.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnpayroll.Location = New System.Drawing.Point(25, 146)
        Me.btnpayroll.Name = "btnpayroll"
        Me.btnpayroll.SideImageSize = New System.Drawing.Size(16, 16)
        Me.btnpayroll.Size = New System.Drawing.Size(266, 50)
        Me.btnpayroll.TabIndex = 2
        Me.btnpayroll.Text = "Payroll Management System"
        Me.btnpayroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpayroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnpayroll.TextShadowShow = False
        '
        'btnclose
        '
        Me.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Location = New System.Drawing.Point(238, 215)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(1, 1)
        Me.btnclose.TabIndex = 3
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'frmMainSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(338, 255)
        Me.ControlBox = False
        Me.Controls.Add(Me.EGradientPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.Custom
        Me.Name = "frmMainSelect"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.EGradientPanel1.ResumeLayout(False)
        Me.RoundedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EGradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents RoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents btninstitute As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnlibrary As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnpayroll As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnclose As System.Windows.Forms.Button
End Class
