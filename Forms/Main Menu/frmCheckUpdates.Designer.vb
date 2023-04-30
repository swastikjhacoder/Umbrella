Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckUpdates
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
        Dim DesignerRectTracker5 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker6 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker3 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker4 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim DesignerRectTracker1 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCheckUpdates))
        Dim DesignerRectTracker2 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker
        Me.EGradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.ERoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkremindme = New System.Windows.Forms.CheckBox
        Me.nuddays = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnchecknow = New ESAR_Controls.UIControls.Button.eButton
        Me.btnclose = New ESAR_Controls.UIControls.Button.eButton
        Me.btnhelp = New ESAR_Controls.UIControls.Button.eButton
        Me.EGradientPanel1.SuspendLayout()
        Me.ERoundedPanel1.SuspendLayout()
        CType(Me.nuddays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EGradientPanel1
        '
        Me.EGradientPanel1.Controls.Add(Me.ERoundedPanel1)
        Me.EGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGradientPanel1.EndColor = System.Drawing.Color.RoyalBlue
        Me.EGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.EGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EGradientPanel1.Name = "EGradientPanel1"
        Me.EGradientPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.EGradientPanel1.Size = New System.Drawing.Size(465, 149)
        Me.EGradientPanel1.StartColor = System.Drawing.Color.LightCyan
        Me.EGradientPanel1.TabIndex = 0
        '
        'ERoundedPanel1
        '
        Me.ERoundedPanel1.BackColor = System.Drawing.Color.White
        Me.ERoundedPanel1.BorderRadius = 32
        Me.ERoundedPanel1.Controls.Add(Me.btnhelp)
        Me.ERoundedPanel1.Controls.Add(Me.btnclose)
        Me.ERoundedPanel1.Controls.Add(Me.btnchecknow)
        Me.ERoundedPanel1.Controls.Add(Me.Label2)
        Me.ERoundedPanel1.Controls.Add(Me.nuddays)
        Me.ERoundedPanel1.Controls.Add(Me.chkremindme)
        Me.ERoundedPanel1.Controls.Add(Me.Label1)
        Me.ERoundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel1.Location = New System.Drawing.Point(10, 10)
        Me.ERoundedPanel1.Name = "ERoundedPanel1"
        Me.ERoundedPanel1.Size = New System.Drawing.Size(445, 129)
        Me.ERoundedPanel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Would you like to connect to the internet and check for updates now?"
        '
        'chkremindme
        '
        Me.chkremindme.AutoSize = True
        Me.chkremindme.Location = New System.Drawing.Point(23, 46)
        Me.chkremindme.Name = "chkremindme"
        Me.chkremindme.Size = New System.Drawing.Size(249, 17)
        Me.chkremindme.TabIndex = 2
        Me.chkremindme.Text = "Remind me to check for updates every"
        Me.chkremindme.UseVisualStyleBackColor = True
        '
        'nuddays
        '
        Me.nuddays.Location = New System.Drawing.Point(278, 45)
        Me.nuddays.Name = "nuddays"
        Me.nuddays.Size = New System.Drawing.Size(44, 21)
        Me.nuddays.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(328, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "day(s)."
        '
        'btnchecknow
        '
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnchecknow.CenterPtTracker = DesignerRectTracker5
        Me.btnchecknow.Corners.All = CType(12, Short)
        Me.btnchecknow.Corners.LowerLeft = CType(12, Short)
        Me.btnchecknow.Corners.LowerRight = CType(12, Short)
        Me.btnchecknow.Corners.UpperLeft = CType(12, Short)
        Me.btnchecknow.Corners.UpperRight = CType(12, Short)
        Me.btnchecknow.Cursor = System.Windows.Forms.Cursors.Hand
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnchecknow.FocusPtTracker = DesignerRectTracker6
        Me.btnchecknow.Image = Global.Umbrella.My.Resources.Resources.update
        Me.btnchecknow.ImageIndex = 0
        Me.btnchecknow.Location = New System.Drawing.Point(44, 86)
        Me.btnchecknow.Name = "btnchecknow"
        Me.btnchecknow.Size = New System.Drawing.Size(102, 25)
        Me.btnchecknow.TabIndex = 5
        Me.btnchecknow.Text = "Check Now"
        Me.btnchecknow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnchecknow.TextShadowShow = False
        '
        'btnclose
        '
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnclose.CenterPtTracker = DesignerRectTracker3
        Me.btnclose.Corners.All = CType(12, Short)
        Me.btnclose.Corners.LowerLeft = CType(12, Short)
        Me.btnclose.Corners.LowerRight = CType(12, Short)
        Me.btnclose.Corners.UpperLeft = CType(12, Short)
        Me.btnclose.Corners.UpperRight = CType(12, Short)
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnclose.FocalPoints.CenterPtX = 0.5466667!
        Me.btnclose.FocalPoints.CenterPtY = 0.48!
        Me.btnclose.FocalPoints.FocusPtX = 0.0!
        Me.btnclose.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnclose.FocusPtTracker = DesignerRectTracker4
        Me.btnclose.Image = Global.Umbrella.My.Resources.Resources.close
        Me.btnclose.ImageIndex = 0
        Me.btnclose.Location = New System.Drawing.Point(197, 86)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 25)
        Me.btnclose.TabIndex = 6
        Me.btnclose.Text = "Close"
        Me.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnclose.TextShadowShow = False
        '
        'btnhelp
        '
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnhelp.CenterPtTracker = DesignerRectTracker1
        Me.btnhelp.Corners.All = CType(12, Short)
        Me.btnhelp.Corners.LowerLeft = CType(12, Short)
        Me.btnhelp.Corners.LowerRight = CType(12, Short)
        Me.btnhelp.Corners.UpperLeft = CType(12, Short)
        Me.btnhelp.Corners.UpperRight = CType(12, Short)
        Me.btnhelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhelp.FocalPoints.CenterPtX = 0.5660377!
        Me.btnhelp.FocalPoints.CenterPtY = 0.6!
        Me.btnhelp.FocalPoints.FocusPtX = 0.0!
        Me.btnhelp.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnhelp.FocusPtTracker = DesignerRectTracker2
        Me.btnhelp.Image = Global.Umbrella.My.Resources.Resources.help
        Me.btnhelp.ImageIndex = 0
        Me.btnhelp.Location = New System.Drawing.Point(323, 86)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(64, 25)
        Me.btnhelp.TabIndex = 7
        Me.btnhelp.Text = "Help"
        Me.btnhelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhelp.TextShadowShow = False
        '
        'frmCheckUpdates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(465, 149)
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
        Me.Name = "frmCheckUpdates"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check For Updates"
        Me.EGradientPanel1.ResumeLayout(False)
        Me.ERoundedPanel1.ResumeLayout(False)
        Me.ERoundedPanel1.PerformLayout()
        CType(Me.nuddays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EGradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents ERoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents btnhelp As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnclose As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btnchecknow As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nuddays As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkremindme As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
