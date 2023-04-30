#Region "Imports..."
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
#End Region
#Region "Class frmCalculator..."
Public Class frmCalculator
#Region "Declarations..."
    Private isOperation As Boolean
    Private tempSign As String
#End Region
#Region "Shared Function..."
    <DllImport("winmm.dll", EntryPoint:="mciSendStringA", CharSet:=CharSet.Ansi)> _
    Protected Shared Function ppp(ByVal lpstrCommand As String, ByVal lpstrReturnString As StringBuilder, ByVal uReturnLength As Integer, ByVal hwndCallback As IntPtr) As Integer
    End Function
#End Region
#Region "Methods..."
    Public Sub New()
        Text = "Calculator 1.0"
        MaximizeBox = False
        InitializeComponent()
    End Sub

    Private Sub btn1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn1.Click
        btnbackspace.Enabled = True
        btnbackspace.BackColor = Color.LightCoral
        If isOperation = True Then
            textoutput.Text = ""
        End If
        If tempSign = "Sminus" Then
            textoutput.Text += "-1"
        Else

            textoutput.Text += "1"
        End If
        isOperation = False
    End Sub

    Private Sub btn2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn2.Click
        btnbackspace.Enabled = True
        btnbackspace.BackColor = Color.LightCoral
        If isOperation = True Then
            textoutput.Text = ""
        End If
        If tempSign = "Sminus" Then
            textoutput.Text += "-2"
        Else

            textoutput.Text += "2"
        End If
        isOperation = False
    End Sub

    Private Sub btn3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn3.Click
        btnbackspace.Enabled = True
        btnbackspace.BackColor = Color.LightCoral
        If isOperation = True Then
            textoutput.Text = ""
        End If
        If tempSign = "Sminus" Then
            textoutput.Text += "-3"
        Else
            textoutput.Text += "3"
        End If
        isOperation = False
    End Sub

    Private Sub btn4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn4.Click
        btnbackspace.Enabled = True
        btnbackspace.BackColor = Color.LightCoral
        If isOperation = True Then
            textoutput.Text = ""
        End If
        If tempSign = "Sminus" Then
            textoutput.Text += "-4"
        Else
            textoutput.Text += "4"
        End If
        isOperation = False
    End Sub

    Private Sub btn5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn5.Click
        btnbackspace.Enabled = True
        btnbackspace.BackColor = Color.LightCoral
        If isOperation = True Then
            textoutput.Text = ""
        End If
        If tempSign = "Sminus" Then
            textoutput.Text += "-5"
        Else
            textoutput.Text += "5"
        End If
        isOperation = False
    End Sub

    Private Sub btn6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn6.Click
        btnbackspace.Enabled = True
        btnbackspace.BackColor = Color.LightCoral
        If isOperation = True Then
            textoutput.Text = ""
        End If
        If tempSign = "Sminus" Then
            textoutput.Text += "-6"
        Else
            textoutput.Text += "6"
        End If
        isOperation = False
    End Sub

    Private Sub btn7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn7.Click
        btnbackspace.Enabled = True
        btnbackspace.BackColor = Color.LightCoral
        If isOperation = True Then
            textoutput.Text = ""
        End If
        If tempSign = "Sminus" Then
            textoutput.Text += "-7"
        Else
            textoutput.Text += "7"
        End If
        isOperation = False
    End Sub

    Private Sub btn8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn8.Click
        btnbackspace.Enabled = True
        btnbackspace.BackColor = Color.LightCoral
        If isOperation = True Then
            textoutput.Text = ""
        End If
        If tempSign = "Sminus" Then
            textoutput.Text += "-8"
        Else
            textoutput.Text += "8"
        End If
        isOperation = False
    End Sub

    Private Sub btn9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn9.Click
        btnbackspace.Enabled = True
        btnbackspace.BackColor = Color.LightCoral
        If isOperation = True Then
            textoutput.Text = ""
        End If
        If tempSign = "Sminus" Then
            textoutput.Text += "-9"
        Else
            textoutput.Text += "9"
        End If
        isOperation = False
    End Sub

    Private Sub btn0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn0.Click
        btnbackspace.Enabled = True
        btnbackspace.BackColor = Color.LightCoral
        If isOperation = True Then
            textoutput.Text = ""
        End If
        If textoutput.Text.StartsWith("0") Then
            If textoutput.Text.Contains(".") Then
                textoutput.Text += "0"
            Else

            End If
        Else
            textoutput.Text += "0"
        End If
        isOperation = False
    End Sub

    Private Sub btnpoint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnpoint.Click
        btnbackspace.Enabled = True
        btnbackspace.BackColor = Color.LightCoral
        If textoutput.Text.StartsWith(".") Then
            textoutput.Text = ("0.")
        End If
        If textoutput.Text.Contains(".") Then
        ElseIf textoutput.Text.StartsWith("") Then
            textoutput.Text += "."
        Else
            textoutput.Text += "."
        End If
    End Sub

    Private Sub btnclear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnclear.Click
        textoutput.Text = ""
        Operations.clear()
        tempSign = ""
        btnbackspace.Enabled = False
        btnbackspace.BackColor = Color.GhostWhite
    End Sub

    Private Sub btnequal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnequal.Click
        If textoutput.Text = "" Then
        Else
            Select Case tempSign
                Case "plus"
                    Operations.add(Double.Parse(textoutput.Text))
                    tempSign = ""
                    Exit Select

                Case "minus"
                    Operations.[sub](Double.Parse(textoutput.Text))
                    tempSign = ""
                    Exit Select

                Case "Sminus"
                    ' ex: '-3 ='
                    Operations.Ssub([Double].Parse(textoutput.Text))
                    tempSign = ""
                    Exit Select

                Case "mult"
                    Operations.mult(Double.Parse(textoutput.Text))
                    tempSign = ""
                    Exit Select

                Case "div"
                    Operations.div(Double.Parse(textoutput.Text))
                    tempSign = ""
                    Exit Select

                Case "modulo"
                    Operations.modulo(Double.Parse(textoutput.Text))
                    tempSign = ""
                    Exit Select
            End Select

            textoutput.Text = Convert.ToString(Operations.getResult())
        End If
        btnbackspace.Enabled = False
        btnbackspace.BackColor = Color.GhostWhite
    End Sub

    Private Sub btnplus_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnplus.Click
        If textoutput.Text = "" Then
        Else
            Operations.add(Double.Parse(textoutput.Text))
            textoutput.Text = Convert.ToString(Operations.getResult())
            isOperation = True
            tempSign = "plus"
        End If
    End Sub

    Private Sub btnminus_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnminus.Click
        If textoutput.Text.Length = 0 Then
            tempSign = "Sminus"
        Else
            Operations.[sub]([Double].Parse(textoutput.Text))
            textoutput.Text = Convert.ToString(Operations.getResult())
            isOperation = True
            tempSign = "minus"
        End If
    End Sub

    Private Sub btnmult_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnmult.Click
        If textoutput.Text = "" Then
        Else
            Operations.mult([Double].Parse(textoutput.Text))
            textoutput.Text = Convert.ToString(Operations.getResult())
            isOperation = True
            tempSign = "mult"
        End If
    End Sub

    Private Sub btndiv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btndiv.Click
        tempSign = "div"
        If textoutput.Text = "" Then
        Else
            Try
                Operations.div([Double].Parse(textoutput.Text))
                textoutput.Text = Convert.ToString(Operations.getResult())
                isOperation = True

            Catch ee As DivideByZeroException
                Console.WriteLine(ee.Message)
            End Try
        End If
    End Sub

    Private Sub menuexit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuexit.Click
        Me.Close()
    End Sub

    Private Sub menuabout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuabout.Click
        MessageBox.Show("Calculator 1.0" + Environment.NewLine + "Developped by ESAR Infotech" & vbLf)
    End Sub

    Private Sub btnbackspace_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnbackspace.Click
        textoutput.Text = textoutput.Text.Remove(textoutput.Text.Length - 1)
        If textoutput.Text = "" Then
            btnbackspace.Enabled = False
            btnbackspace.BackColor = Color.GhostWhite
        End If
    End Sub

    Private Sub btnsin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnsin.Click
        If textoutput.Text = "" Then
        Else
            Operations.sin([Double].Parse(textoutput.Text))
            textoutput.Text = Convert.ToString(Operations.getResult())
        End If
    End Sub

    Private Sub btncos_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btncos.Click
        If textoutput.Text = "" Then
        Else
            Operations.cos([Double].Parse(textoutput.Text))
            textoutput.Text = Convert.ToString(Operations.getResult())
        End If
    End Sub

    Private Sub btntan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btntan.Click
        If textoutput.Text = "" Then
        Else
            Operations.cos([Double].Parse(textoutput.Text))
            textoutput.Text = Convert.ToString(Operations.getResult())
        End If
    End Sub

    Private Sub btnsqrt_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnsqrt.Click
        If textoutput.Text = "" Then
        Else
            Operations.sqrt([Double].Parse(textoutput.Text))
            textoutput.Text = Convert.ToString(Operations.getResult())
        End If
    End Sub

    Private Sub btnmodulo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnmodulo.Click
        tempSign = "modulo"
        If textoutput.Text = "" Then
        Else
            Operations.modulo([Double].Parse(textoutput.Text))
            textoutput.Text = Convert.ToString(Operations.getResult())
            isOperation = True
        End If
    End Sub

    Private Sub rbtnstandard_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbtnstandard.CheckedChanged
        btnsin.Visible = False
        btncos.Visible = False
        btntan.Visible = False
        btnsqrt.Visible = False
        btnmodulo.Visible = False
        btnpi.Visible = False
        btnsquare.Visible = False
        btncube.Visible = False
        btnfactorial.Visible = False
        btnfibonacci.Visible = False
        label_image.Visible = True
    End Sub

    Private Sub rbtnscientific_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbtnscientific.CheckedChanged
        btnsin.Visible = True
        btncos.Visible = True
        btntan.Visible = True
        btnsqrt.Visible = True
        btnmodulo.Visible = True
        btnpi.Visible = True
        btnsquare.Visible = True
        btncube.Visible = True
        btnfactorial.Visible = True
        btnfibonacci.Visible = True
        label_image.Visible = False
    End Sub

    Private Sub btnpi_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnpi.Click
        btnbackspace.Enabled = True
        btnbackspace.BackColor = Color.LightCoral
        If isOperation = True OrElse textoutput.Text <> "" Then
            textoutput.Text = ""
        End If
        textoutput.Text += Math.PI
        isOperation = False
    End Sub

    Private Sub btnsquare_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnsquare.Click
        If textoutput.Text = "" Then
        Else
            Operations.square([Double].Parse(textoutput.Text))
            textoutput.Text = Convert.ToString(Operations.getResult())
        End If
    End Sub

    Private Sub btncube_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btncube.Click
        If textoutput.Text = "" Then
        Else
            Operations.cube([Double].Parse(textoutput.Text))
            textoutput.Text = Convert.ToString(Operations.getResult())
        End If
    End Sub

    Private Sub btnfactorial_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnfactorial.Click
        If textoutput.Text = "" Then
        Else
            Try
                textoutput.Text = Convert.ToString(Operations.factorial(Long.Parse(textoutput.Text)))
            Catch generatedExceptionName As Exception
                MessageBox.Show("Factorial are only for integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                textoutput.Text = ""
                btnbackspace.Enabled = False
                btnbackspace.BackColor = Color.GhostWhite
            End Try
        End If
    End Sub

    Private Sub menufontcolor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menufontcolor.Click
        Dim colorChooser As New ColorDialog()
        Dim result As DialogResult

        result = colorChooser.ShowDialog()

        If result = DialogResult.Cancel Then
            Return
        End If

        textoutput.ForeColor = colorChooser.Color
    End Sub

    Private Sub btnfibonacci_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnfibonacci.Click
        If textoutput.Text = "" Then
        Else
            Try
                Operations.fibonacci(Long.Parse(textoutput.Text))
                textoutput.Text = Convert.ToString(Operations.fibonacci(Long.Parse(textoutput.Text)))
            Catch generatedExceptionName As Exception
                MessageBox.Show("Fibonnaci are for integers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                textoutput.Text = ""
                btnbackspace.Enabled = False
                btnbackspace.BackColor = Color.GhostWhite
            End Try
        End If
    End Sub

    Private Sub bmenuwhite_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuwhite.Click
        btn0.BackColor = Color.White
        btn1.BackColor = Color.White
        btn2.BackColor = Color.White
        btn3.BackColor = Color.White
        btn4.BackColor = Color.White
        btn5.BackColor = Color.White
        btn6.BackColor = Color.White
        btn7.BackColor = Color.White
        btn8.BackColor = Color.White
        btn9.BackColor = Color.White
        btnpoint.BackColor = Color.White
        menuwhite.Checked = True
        menured.Checked = False
    End Sub

    Private Sub menured_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menured.Click
        btn0.BackColor = Color.Red
        btn1.BackColor = Color.Red
        btn2.BackColor = Color.Red
        btn3.BackColor = Color.Red
        btn4.BackColor = Color.Red
        btn5.BackColor = Color.Red
        btn6.BackColor = Color.Red
        btn7.BackColor = Color.Red
        btn8.BackColor = Color.Red
        btn9.BackColor = Color.Red
        btnpoint.BackColor = Color.Red
        menuwhite.Checked = False
        menured.Checked = True
    End Sub

    Private Sub menublack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menublack.Click
        btn0.ForeColor = Color.Black
        btn1.ForeColor = Color.Black
        btn2.ForeColor = Color.Black
        btn3.ForeColor = Color.Black
        btn4.ForeColor = Color.Black
        btn5.ForeColor = Color.Black
        btn6.ForeColor = Color.Black
        btn7.ForeColor = Color.Black
        btn8.ForeColor = Color.Black
        btn9.ForeColor = Color.Black
        btnpoint.ForeColor = Color.Black
        menublack.Checked = True
        menucyan.Checked = False

    End Sub

    Private Sub menucyan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menucyan.Click
        btn0.ForeColor = Color.Cyan
        btn1.ForeColor = Color.Cyan
        btn2.ForeColor = Color.Cyan
        btn3.ForeColor = Color.Cyan
        btn4.ForeColor = Color.Cyan
        btn5.ForeColor = Color.Cyan
        btn6.ForeColor = Color.Cyan
        btn7.ForeColor = Color.Cyan
        btn8.ForeColor = Color.Cyan
        btn9.ForeColor = Color.Cyan
        btnpoint.ForeColor = Color.Cyan
        menublack.Checked = False
        menucyan.Checked = True
    End Sub
#End Region
End Class
#End Region