<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmissionDetails
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.EGradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.EGroupBox2 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.dgviewadmission = New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
        Me.EGroupBox3 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.dgviewpreadmission = New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
        Me.EGroupBox1 = New ESAR_Controls.UIControls.GroupBox.eGroupBox
        Me.dgviewregistered = New ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
        'Me.UmbrellaDataSet = New Umbrella.UmbrellaDataSet
        Me.StudentPreAdmissionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        'Me.StudentPreAdmissionTableAdapter = New Umbrella.UmbrellaDataSetTableAdapters.StudentPreAdmissionTableAdapter
        Me.PictureDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn
        Me.EGradientPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.EGroupBox2.SuspendLayout()
        CType(Me.dgviewadmission, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EGroupBox3.SuspendLayout()
        CType(Me.dgviewpreadmission, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EGroupBox1.SuspendLayout()
        CType(Me.dgviewregistered, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.UmbrellaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentPreAdmissionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EGradientPanel1
        '
        Me.EGradientPanel1.Controls.Add(Me.Panel1)
        Me.EGradientPanel1.Controls.Add(Me.EGroupBox1)
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
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 338)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(819, 208)
        Me.Panel1.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 5)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EGroupBox2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EGroupBox3)
        Me.SplitContainer1.Size = New System.Drawing.Size(819, 203)
        Me.SplitContainer1.SplitterDistance = 400
        Me.SplitContainer1.TabIndex = 0
        '
        'EGroupBox2
        '
        Me.EGroupBox2.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox2.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox2.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox2.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox2.BorderThickness = 1.0!
        Me.EGroupBox2.Controls.Add(Me.dgviewadmission)
        Me.EGroupBox2.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox2.GroupImage = Nothing
        Me.EGroupBox2.GroupTitle = "Student Admitted:"
        Me.EGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.EGroupBox2.Name = "EGroupBox2"
        Me.EGroupBox2.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.EGroupBox2.PaintGroupBox = False
        Me.EGroupBox2.RoundCorners = 10
        Me.EGroupBox2.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox2.ShadowControl = False
        Me.EGroupBox2.ShadowThickness = 3
        Me.EGroupBox2.Size = New System.Drawing.Size(400, 203)
        Me.EGroupBox2.TabIndex = 0
        '
        'dgviewadmission
        '
        Me.dgviewadmission.AllowUserToAddRows = False
        Me.dgviewadmission.AllowUserToDeleteRows = False
        Me.dgviewadmission.BackgroundColor = System.Drawing.Color.White
        Me.dgviewadmission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewadmission.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgviewadmission.DisplaySumRowHeader = False
        Me.dgviewadmission.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewadmission.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgviewadmission.Location = New System.Drawing.Point(10, 25)
        Me.dgviewadmission.Name = "dgviewadmission"
        Me.dgviewadmission.ReadOnly = True
        Me.dgviewadmission.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgviewadmission.Size = New System.Drawing.Size(380, 168)
        Me.dgviewadmission.SummaryColumns = Nothing
        Me.dgviewadmission.SummaryRowBackColor = System.Drawing.Color.Empty
        Me.dgviewadmission.SummaryRowSpace = 0
        Me.dgviewadmission.SummaryRowVisible = False
        Me.dgviewadmission.SumRowHeaderText = Nothing
        Me.dgviewadmission.SumRowHeaderTextBold = False
        Me.dgviewadmission.TabIndex = 1
        '
        'EGroupBox3
        '
        Me.EGroupBox3.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox3.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox3.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox3.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox3.BorderThickness = 1.0!
        Me.EGroupBox3.Controls.Add(Me.dgviewpreadmission)
        Me.EGroupBox3.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox3.GroupImage = Nothing
        Me.EGroupBox3.GroupTitle = "Student Pre-Admitted:"
        Me.EGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.EGroupBox3.Name = "EGroupBox3"
        Me.EGroupBox3.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.EGroupBox3.PaintGroupBox = False
        Me.EGroupBox3.RoundCorners = 10
        Me.EGroupBox3.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox3.ShadowControl = False
        Me.EGroupBox3.ShadowThickness = 3
        Me.EGroupBox3.Size = New System.Drawing.Size(415, 203)
        Me.EGroupBox3.TabIndex = 0
        '
        'dgviewpreadmission
        '
        Me.dgviewpreadmission.AllowUserToAddRows = False
        Me.dgviewpreadmission.AllowUserToDeleteRows = False
        Me.dgviewpreadmission.BackgroundColor = System.Drawing.Color.White
        Me.dgviewpreadmission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewpreadmission.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgviewpreadmission.DisplaySumRowHeader = False
        Me.dgviewpreadmission.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewpreadmission.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgviewpreadmission.Location = New System.Drawing.Point(10, 25)
        Me.dgviewpreadmission.Name = "dgviewpreadmission"
        Me.dgviewpreadmission.ReadOnly = True
        Me.dgviewpreadmission.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgviewpreadmission.Size = New System.Drawing.Size(395, 168)
        Me.dgviewpreadmission.SummaryColumns = Nothing
        Me.dgviewpreadmission.SummaryRowBackColor = System.Drawing.Color.Empty
        Me.dgviewpreadmission.SummaryRowSpace = 0
        Me.dgviewpreadmission.SummaryRowVisible = False
        Me.dgviewpreadmission.SumRowHeaderText = Nothing
        Me.dgviewpreadmission.SumRowHeaderTextBold = False
        Me.dgviewpreadmission.TabIndex = 1
        '
        'EGroupBox1
        '
        Me.EGroupBox1.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox1.BorderThickness = 1.0!
        Me.EGroupBox1.Controls.Add(Me.dgviewregistered)
        Me.EGroupBox1.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.EGroupBox1.GroupImage = Nothing
        Me.EGroupBox1.GroupTitle = "Registered Students:"
        Me.EGroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.EGroupBox1.Name = "EGroupBox1"
        Me.EGroupBox1.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.EGroupBox1.PaintGroupBox = False
        Me.EGroupBox1.RoundCorners = 10
        Me.EGroupBox1.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox1.ShadowControl = False
        Me.EGroupBox1.ShadowThickness = 3
        Me.EGroupBox1.Size = New System.Drawing.Size(819, 328)
        Me.EGroupBox1.TabIndex = 0
        '
        'dgviewregistered
        '
        Me.dgviewregistered.AllowUserToAddRows = False
        Me.dgviewregistered.AllowUserToDeleteRows = False
        Me.dgviewregistered.AutoGenerateColumns = False
        Me.dgviewregistered.BackgroundColor = System.Drawing.Color.White
        Me.dgviewregistered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgviewregistered.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PictureDataGridViewImageColumn})
        Me.dgviewregistered.DataSource = Me.StudentPreAdmissionBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewregistered.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgviewregistered.DisplaySumRowHeader = False
        Me.dgviewregistered.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgviewregistered.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgviewregistered.Location = New System.Drawing.Point(10, 25)
        Me.dgviewregistered.Name = "dgviewregistered"
        Me.dgviewregistered.ReadOnly = True
        Me.dgviewregistered.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgviewregistered.Size = New System.Drawing.Size(799, 293)
        Me.dgviewregistered.SummaryColumns = Nothing
        Me.dgviewregistered.SummaryRowBackColor = System.Drawing.Color.Empty
        Me.dgviewregistered.SummaryRowSpace = 0
        Me.dgviewregistered.SummaryRowVisible = False
        Me.dgviewregistered.SumRowHeaderText = Nothing
        Me.dgviewregistered.SumRowHeaderTextBold = False
        Me.dgviewregistered.TabIndex = 0
        '
        'UmbrellaDataSet
        '
        'Me.UmbrellaDataSet.DataSetName = "UmbrellaDataSet"
        'Me.UmbrellaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        ''
        ''StudentPreAdmissionBindingSource
        ''
        'Me.StudentPreAdmissionBindingSource.DataMember = "StudentPreAdmission"
        'Me.StudentPreAdmissionBindingSource.DataSource = Me.UmbrellaDataSet
        ''
        ''StudentPreAdmissionTableAdapter
        ''
        'Me.StudentPreAdmissionTableAdapter.ClearBeforeFill = True
        '
        'PictureDataGridViewImageColumn
        '
        Me.PictureDataGridViewImageColumn.DataPropertyName = "picture"
        Me.PictureDataGridViewImageColumn.HeaderText = "picture"
        Me.PictureDataGridViewImageColumn.Name = "PictureDataGridViewImageColumn"
        Me.PictureDataGridViewImageColumn.ReadOnly = True
        '
        'frmAdmissionDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(839, 556)
        Me.ControlBox = False
        Me.Controls.Add(Me.EGradientPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.RoyalLight
        Me.Name = "frmAdmissionDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admission Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.EGradientPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.EGroupBox2.ResumeLayout(False)
        CType(Me.dgviewadmission, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EGroupBox3.ResumeLayout(False)
        CType(Me.dgviewpreadmission, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EGroupBox1.ResumeLayout(False)
        CType(Me.dgviewregistered, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.UmbrellaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentPreAdmissionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EGradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents EGroupBox1 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EGroupBox2 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents EGroupBox3 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents dgviewregistered As ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
    Friend WithEvents dgviewadmission As ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
    Friend WithEvents dgviewpreadmission As ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
    'Friend WithEvents UmbrellaDataSet As Umbrella.UmbrellaDataSet
    Friend WithEvents StudentPreAdmissionBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents StudentPreAdmissionTableAdapter As Umbrella.UmbrellaDataSetTableAdapters.StudentPreAdmissionTableAdapter
    Friend WithEvents PictureDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
End Class
