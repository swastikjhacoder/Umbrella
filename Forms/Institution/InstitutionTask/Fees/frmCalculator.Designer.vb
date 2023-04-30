Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculator
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
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip
        Me.menu_file = New System.Windows.Forms.ToolStripMenuItem
        Me.menuexit = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_edit = New System.Windows.Forms.ToolStripMenuItem
        Me.menufontcolor = New System.Windows.Forms.ToolStripMenuItem
        Me.changeButtonsColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.backgroudToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.menuwhite = New System.Windows.Forms.ToolStripMenuItem
        Me.menured = New System.Windows.Forms.ToolStripMenuItem
        Me.foregroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.menublack = New System.Windows.Forms.ToolStripMenuItem
        Me.menucyan = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_help = New System.Windows.Forms.ToolStripMenuItem
        Me.menuabout = New System.Windows.Forms.ToolStripMenuItem
        Me.label_image = New System.Windows.Forms.Label
        Me.btnfibonacci = New System.Windows.Forms.Button
        Me.btnfactorial = New System.Windows.Forms.Button
        Me.btncube = New System.Windows.Forms.Button
        Me.btnsquare = New System.Windows.Forms.Button
        Me.btnpi = New System.Windows.Forms.Button
        Me.rbtnscientific = New System.Windows.Forms.RadioButton
        Me.rbtnstandard = New System.Windows.Forms.RadioButton
        Me.btnmodulo = New System.Windows.Forms.Button
        Me.btnsqrt = New System.Windows.Forms.Button
        Me.btntan = New System.Windows.Forms.Button
        Me.btncos = New System.Windows.Forms.Button
        Me.btnsin = New System.Windows.Forms.Button
        Me.btnbackspace = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btnequal = New System.Windows.Forms.Button
        Me.btndiv = New System.Windows.Forms.Button
        Me.btnmult = New System.Windows.Forms.Button
        Me.btnminus = New System.Windows.Forms.Button
        Me.btnplus = New System.Windows.Forms.Button
        Me.btnpoint = New System.Windows.Forms.Button
        Me.btn0 = New System.Windows.Forms.Button
        Me.btn9 = New System.Windows.Forms.Button
        Me.btn8 = New System.Windows.Forms.Button
        Me.btn7 = New System.Windows.Forms.Button
        Me.btn6 = New System.Windows.Forms.Button
        Me.btn5 = New System.Windows.Forms.Button
        Me.btn4 = New System.Windows.Forms.Button
        Me.btn3 = New System.Windows.Forms.Button
        Me.btn2 = New System.Windows.Forms.Button
        Me.btn1 = New System.Windows.Forms.Button
        Me.textoutput = New System.Windows.Forms.TextBox
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_file, Me.menu_edit, Me.menu_help})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(308, 24)
        Me.menuStrip1.TabIndex = 19
        Me.menuStrip1.Text = "menuStrip1"
        '
        'menu_file
        '
        Me.menu_file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuexit})
        Me.menu_file.Name = "menu_file"
        Me.menu_file.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.menu_file.Size = New System.Drawing.Size(37, 20)
        Me.menu_file.Text = "File"
        '
        'menuexit
        '
        Me.menuexit.Name = "menuexit"
        Me.menuexit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.menuexit.Size = New System.Drawing.Size(152, 22)
        Me.menuexit.Text = "Exit"
        '
        'menu_edit
        '
        Me.menu_edit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menufontcolor, Me.changeButtonsColorToolStripMenuItem})
        Me.menu_edit.Name = "menu_edit"
        Me.menu_edit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.menu_edit.Size = New System.Drawing.Size(39, 20)
        Me.menu_edit.Text = "Edit"
        '
        'menufontcolor
        '
        Me.menufontcolor.Name = "menufontcolor"
        Me.menufontcolor.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.menufontcolor.Size = New System.Drawing.Size(211, 22)
        Me.menufontcolor.Text = "Change Font Color"
        '
        'changeButtonsColorToolStripMenuItem
        '
        Me.changeButtonsColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.backgroudToolStripMenuItem, Me.foregroundToolStripMenuItem})
        Me.changeButtonsColorToolStripMenuItem.Name = "changeButtonsColorToolStripMenuItem"
        Me.changeButtonsColorToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.changeButtonsColorToolStripMenuItem.Text = "Change Buttons Color"
        '
        'backgroudToolStripMenuItem
        '
        Me.backgroudToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuwhite, Me.menured})
        Me.backgroudToolStripMenuItem.Name = "backgroudToolStripMenuItem"
        Me.backgroudToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.backgroudToolStripMenuItem.Text = "Background"
        '
        'menuwhite
        '
        Me.menuwhite.Checked = True
        Me.menuwhite.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menuwhite.Name = "menuwhite"
        Me.menuwhite.Size = New System.Drawing.Size(105, 22)
        Me.menuwhite.Text = "White"
        '
        'menured
        '
        Me.menured.Name = "menured"
        Me.menured.Size = New System.Drawing.Size(105, 22)
        Me.menured.Text = "Red"
        '
        'foregroundToolStripMenuItem
        '
        Me.foregroundToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menublack, Me.menucyan})
        Me.foregroundToolStripMenuItem.Name = "foregroundToolStripMenuItem"
        Me.foregroundToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.foregroundToolStripMenuItem.Text = "Foreground"
        '
        'menublack
        '
        Me.menublack.Checked = True
        Me.menublack.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menublack.Name = "menublack"
        Me.menublack.Size = New System.Drawing.Size(102, 22)
        Me.menublack.Text = "Black"
        '
        'menucyan
        '
        Me.menucyan.Name = "menucyan"
        Me.menucyan.Size = New System.Drawing.Size(102, 22)
        Me.menucyan.Text = "Cyan"
        '
        'menu_help
        '
        Me.menu_help.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuabout})
        Me.menu_help.Name = "menu_help"
        Me.menu_help.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.menu_help.Size = New System.Drawing.Size(44, 20)
        Me.menu_help.Text = "Help"
        '
        'menuabout
        '
        Me.menuabout.Name = "menuabout"
        Me.menuabout.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.menuabout.Size = New System.Drawing.Size(152, 22)
        Me.menuabout.Text = "About"
        '
        'label_image
        '
        Me.label_image.BackColor = System.Drawing.Color.Transparent
        Me.label_image.Location = New System.Drawing.Point(150, 58)
        Me.label_image.Name = "label_image"
        Me.label_image.Size = New System.Drawing.Size(149, 177)
        Me.label_image.TabIndex = 61
        '
        'btnfibonacci
        '
        Me.btnfibonacci.BackColor = System.Drawing.Color.Transparent
        Me.btnfibonacci.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfibonacci.Location = New System.Drawing.Point(229, 202)
        Me.btnfibonacci.Name = "btnfibonacci"
        Me.btnfibonacci.Size = New System.Drawing.Size(70, 33)
        Me.btnfibonacci.TabIndex = 65
        Me.btnfibonacci.Text = "Fibonacci"
        Me.btnfibonacci.UseVisualStyleBackColor = False
        Me.btnfibonacci.Visible = False
        '
        'btnfactorial
        '
        Me.btnfactorial.BackColor = System.Drawing.Color.Transparent
        Me.btnfactorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfactorial.Location = New System.Drawing.Point(153, 202)
        Me.btnfactorial.Name = "btnfactorial"
        Me.btnfactorial.Size = New System.Drawing.Size(70, 33)
        Me.btnfactorial.TabIndex = 64
        Me.btnfactorial.Text = "X !"
        Me.btnfactorial.UseVisualStyleBackColor = False
        Me.btnfactorial.Visible = False
        '
        'btncube
        '
        Me.btncube.BackColor = System.Drawing.Color.Transparent
        Me.btncube.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncube.Location = New System.Drawing.Point(229, 166)
        Me.btncube.Name = "btncube"
        Me.btncube.Size = New System.Drawing.Size(70, 33)
        Me.btncube.TabIndex = 63
        Me.btncube.Text = "X^3"
        Me.btncube.UseVisualStyleBackColor = False
        Me.btncube.Visible = False
        '
        'btnsquare
        '
        Me.btnsquare.BackColor = System.Drawing.Color.Transparent
        Me.btnsquare.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsquare.Location = New System.Drawing.Point(153, 166)
        Me.btnsquare.Name = "btnsquare"
        Me.btnsquare.Size = New System.Drawing.Size(70, 33)
        Me.btnsquare.TabIndex = 62
        Me.btnsquare.Text = "X^2"
        Me.btnsquare.UseVisualStyleBackColor = False
        Me.btnsquare.Visible = False
        '
        'btnpi
        '
        Me.btnpi.BackColor = System.Drawing.Color.Transparent
        Me.btnpi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpi.Location = New System.Drawing.Point(229, 130)
        Me.btnpi.Name = "btnpi"
        Me.btnpi.Size = New System.Drawing.Size(70, 33)
        Me.btnpi.TabIndex = 60
        Me.btnpi.Text = "Pi"
        Me.btnpi.UseVisualStyleBackColor = False
        Me.btnpi.Visible = False
        '
        'rbtnscientific
        '
        Me.rbtnscientific.AutoSize = True
        Me.rbtnscientific.BackColor = System.Drawing.Color.Transparent
        Me.rbtnscientific.Location = New System.Drawing.Point(227, 34)
        Me.rbtnscientific.Name = "rbtnscientific"
        Me.rbtnscientific.Size = New System.Drawing.Size(76, 17)
        Me.rbtnscientific.TabIndex = 59
        Me.rbtnscientific.Text = "Scientific"
        Me.rbtnscientific.UseVisualStyleBackColor = False
        '
        'rbtnstandard
        '
        Me.rbtnstandard.AutoSize = True
        Me.rbtnstandard.BackColor = System.Drawing.Color.Transparent
        Me.rbtnstandard.Checked = True
        Me.rbtnstandard.Location = New System.Drawing.Point(153, 35)
        Me.rbtnstandard.Name = "rbtnstandard"
        Me.rbtnstandard.Size = New System.Drawing.Size(77, 17)
        Me.rbtnstandard.TabIndex = 58
        Me.rbtnstandard.TabStop = True
        Me.rbtnstandard.Text = "Standard"
        Me.rbtnstandard.UseVisualStyleBackColor = False
        '
        'btnmodulo
        '
        Me.btnmodulo.BackColor = System.Drawing.Color.Transparent
        Me.btnmodulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodulo.Location = New System.Drawing.Point(153, 130)
        Me.btnmodulo.Name = "btnmodulo"
        Me.btnmodulo.Size = New System.Drawing.Size(70, 33)
        Me.btnmodulo.TabIndex = 57
        Me.btnmodulo.Text = "Modulo"
        Me.btnmodulo.UseVisualStyleBackColor = False
        Me.btnmodulo.Visible = False
        '
        'btnsqrt
        '
        Me.btnsqrt.BackColor = System.Drawing.Color.Transparent
        Me.btnsqrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsqrt.Location = New System.Drawing.Point(229, 94)
        Me.btnsqrt.Name = "btnsqrt"
        Me.btnsqrt.Size = New System.Drawing.Size(70, 33)
        Me.btnsqrt.TabIndex = 56
        Me.btnsqrt.Text = "Sqrt"
        Me.btnsqrt.UseVisualStyleBackColor = False
        Me.btnsqrt.Visible = False
        '
        'btntan
        '
        Me.btntan.BackColor = System.Drawing.Color.Transparent
        Me.btntan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntan.Location = New System.Drawing.Point(153, 94)
        Me.btntan.Name = "btntan"
        Me.btntan.Size = New System.Drawing.Size(70, 33)
        Me.btntan.TabIndex = 55
        Me.btntan.Text = "Tan"
        Me.btntan.UseVisualStyleBackColor = False
        Me.btntan.Visible = False
        '
        'btncos
        '
        Me.btncos.BackColor = System.Drawing.Color.Transparent
        Me.btncos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncos.Location = New System.Drawing.Point(229, 58)
        Me.btncos.Name = "btncos"
        Me.btncos.Size = New System.Drawing.Size(70, 33)
        Me.btncos.TabIndex = 54
        Me.btncos.Text = "Cos"
        Me.btncos.UseVisualStyleBackColor = False
        Me.btncos.Visible = False
        '
        'btnsin
        '
        Me.btnsin.BackColor = System.Drawing.Color.Transparent
        Me.btnsin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsin.Location = New System.Drawing.Point(153, 58)
        Me.btnsin.Name = "btnsin"
        Me.btnsin.Size = New System.Drawing.Size(70, 33)
        Me.btnsin.TabIndex = 53
        Me.btnsin.Text = "Sin"
        Me.btnsin.UseVisualStyleBackColor = False
        Me.btnsin.Visible = False
        '
        'btnbackspace
        '
        Me.btnbackspace.BackColor = System.Drawing.Color.GhostWhite
        Me.btnbackspace.Enabled = False
        Me.btnbackspace.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbackspace.Location = New System.Drawing.Point(62, 204)
        Me.btnbackspace.Name = "btnbackspace"
        Me.btnbackspace.Size = New System.Drawing.Size(85, 31)
        Me.btnbackspace.TabIndex = 52
        Me.btnbackspace.Text = "Backspace"
        Me.btnbackspace.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.LightCoral
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(6, 204)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(54, 31)
        Me.btnclear.TabIndex = 51
        Me.btnclear.Text = "C"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnequal
        '
        Me.btnequal.BackColor = System.Drawing.Color.Silver
        Me.btnequal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnequal.Location = New System.Drawing.Point(78, 166)
        Me.btnequal.Name = "btnequal"
        Me.btnequal.Size = New System.Drawing.Size(33, 33)
        Me.btnequal.TabIndex = 50
        Me.btnequal.Text = "="
        Me.btnequal.UseVisualStyleBackColor = False
        '
        'btndiv
        '
        Me.btndiv.BackColor = System.Drawing.Color.Silver
        Me.btndiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndiv.Location = New System.Drawing.Point(114, 58)
        Me.btndiv.Name = "btndiv"
        Me.btndiv.Size = New System.Drawing.Size(33, 33)
        Me.btndiv.TabIndex = 49
        Me.btndiv.Text = "/"
        Me.btndiv.UseVisualStyleBackColor = False
        '
        'btnmult
        '
        Me.btnmult.BackColor = System.Drawing.Color.Silver
        Me.btnmult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmult.Location = New System.Drawing.Point(114, 94)
        Me.btnmult.Name = "btnmult"
        Me.btnmult.Size = New System.Drawing.Size(33, 33)
        Me.btnmult.TabIndex = 48
        Me.btnmult.Text = "*"
        Me.btnmult.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnmult.UseVisualStyleBackColor = False
        '
        'btnminus
        '
        Me.btnminus.BackColor = System.Drawing.Color.Silver
        Me.btnminus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnminus.Location = New System.Drawing.Point(114, 130)
        Me.btnminus.Name = "btnminus"
        Me.btnminus.Size = New System.Drawing.Size(33, 33)
        Me.btnminus.TabIndex = 47
        Me.btnminus.Text = "-"
        Me.btnminus.UseVisualStyleBackColor = False
        '
        'btnplus
        '
        Me.btnplus.BackColor = System.Drawing.Color.Silver
        Me.btnplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnplus.Location = New System.Drawing.Point(114, 166)
        Me.btnplus.Name = "btnplus"
        Me.btnplus.Size = New System.Drawing.Size(33, 33)
        Me.btnplus.TabIndex = 46
        Me.btnplus.Text = "+"
        Me.btnplus.UseVisualStyleBackColor = False
        '
        'btnpoint
        '
        Me.btnpoint.BackColor = System.Drawing.Color.White
        Me.btnpoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpoint.Location = New System.Drawing.Point(42, 166)
        Me.btnpoint.Name = "btnpoint"
        Me.btnpoint.Size = New System.Drawing.Size(33, 33)
        Me.btnpoint.TabIndex = 45
        Me.btnpoint.Text = "."
        Me.btnpoint.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.Color.White
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(6, 166)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(33, 33)
        Me.btn0.TabIndex = 44
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.Color.White
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(78, 58)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(33, 33)
        Me.btn9.TabIndex = 43
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.Color.White
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(42, 58)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(33, 33)
        Me.btn8.TabIndex = 42
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.Color.White
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(6, 58)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(33, 33)
        Me.btn7.TabIndex = 41
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.Color.White
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(78, 94)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(33, 33)
        Me.btn6.TabIndex = 40
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.White
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(42, 94)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(33, 33)
        Me.btn5.TabIndex = 39
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.White
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(6, 94)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(33, 33)
        Me.btn4.TabIndex = 38
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.White
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(78, 130)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(33, 33)
        Me.btn3.TabIndex = 37
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.White
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(42, 130)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(33, 33)
        Me.btn2.TabIndex = 36
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.White
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(6, 130)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(33, 33)
        Me.btn1.TabIndex = 35
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'textoutput
        '
        Me.textoutput.ForeColor = System.Drawing.Color.Black
        Me.textoutput.Location = New System.Drawing.Point(6, 34)
        Me.textoutput.Name = "textoutput"
        Me.textoutput.Size = New System.Drawing.Size(138, 21)
        Me.textoutput.TabIndex = 34
        Me.textoutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(308, 255)
        Me.Controls.Add(Me.label_image)
        Me.Controls.Add(Me.btnfibonacci)
        Me.Controls.Add(Me.btnfactorial)
        Me.Controls.Add(Me.btncube)
        Me.Controls.Add(Me.btnsquare)
        Me.Controls.Add(Me.btnpi)
        Me.Controls.Add(Me.rbtnscientific)
        Me.Controls.Add(Me.rbtnstandard)
        Me.Controls.Add(Me.btnmodulo)
        Me.Controls.Add(Me.btnsqrt)
        Me.Controls.Add(Me.btntan)
        Me.Controls.Add(Me.btncos)
        Me.Controls.Add(Me.btnsin)
        Me.Controls.Add(Me.btnbackspace)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnequal)
        Me.Controls.Add(Me.btndiv)
        Me.Controls.Add(Me.btnmult)
        Me.Controls.Add(Me.btnminus)
        Me.Controls.Add(Me.btnplus)
        Me.Controls.Add(Me.btnpoint)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.textoutput)
        Me.Controls.Add(Me.menuStrip1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.RoyalLight
        Me.Name = "frmCalculator"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents timer1 As System.Windows.Forms.Timer
    Private WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Private WithEvents menu_file As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuexit As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menu_edit As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menufontcolor As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents changeButtonsColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents backgroudToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuwhite As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menured As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents foregroundToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menublack As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menucyan As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menu_help As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuabout As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents label_image As System.Windows.Forms.Label
    Private WithEvents btnfibonacci As System.Windows.Forms.Button
    Private WithEvents btnfactorial As System.Windows.Forms.Button
    Private WithEvents btncube As System.Windows.Forms.Button
    Private WithEvents btnsquare As System.Windows.Forms.Button
    Private WithEvents btnpi As System.Windows.Forms.Button
    Private WithEvents rbtnscientific As System.Windows.Forms.RadioButton
    Private WithEvents rbtnstandard As System.Windows.Forms.RadioButton
    Private WithEvents btnmodulo As System.Windows.Forms.Button
    Private WithEvents btnsqrt As System.Windows.Forms.Button
    Private WithEvents btntan As System.Windows.Forms.Button
    Private WithEvents btncos As System.Windows.Forms.Button
    Private WithEvents btnsin As System.Windows.Forms.Button
    Private WithEvents btnbackspace As System.Windows.Forms.Button
    Private WithEvents btnclear As System.Windows.Forms.Button
    Private WithEvents btnequal As System.Windows.Forms.Button
    Private WithEvents btndiv As System.Windows.Forms.Button
    Private WithEvents btnmult As System.Windows.Forms.Button
    Private WithEvents btnminus As System.Windows.Forms.Button
    Private WithEvents btnplus As System.Windows.Forms.Button
    Private WithEvents btnpoint As System.Windows.Forms.Button
    Private WithEvents btn0 As System.Windows.Forms.Button
    Private WithEvents btn9 As System.Windows.Forms.Button
    Private WithEvents btn8 As System.Windows.Forms.Button
    Private WithEvents btn7 As System.Windows.Forms.Button
    Private WithEvents btn6 As System.Windows.Forms.Button
    Private WithEvents btn5 As System.Windows.Forms.Button
    Private WithEvents btn4 As System.Windows.Forms.Button
    Private WithEvents btn3 As System.Windows.Forms.Button
    Private WithEvents btn2 As System.Windows.Forms.Button
    Private WithEvents btn1 As System.Windows.Forms.Button
    Private WithEvents textoutput As System.Windows.Forms.TextBox
End Class
