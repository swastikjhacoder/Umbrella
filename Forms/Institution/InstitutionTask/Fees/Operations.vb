#Region "Imports..."
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
#End Region
#Region "Class Operations..."
Class Operations
#Region "Declarations..."
    Private Shared result As Double
#End Region
#Region "Shared Methods..."
    Public Sub New()
        result = 0
    End Sub

    Public Shared Sub add(ByVal num As Double)
        If result = 0 Then
            result = num
        Else
            result += num
        End If
    End Sub

    Public Shared Sub [sub](ByVal num As Double)
        If result = 0 Then
            result = num
        Else
            result -= num
        End If
    End Sub

    Public Shared Sub Ssub(ByVal num As Double)
        If result = 0 Then
            result = num
        Else
            result -= num
        End If
    End Sub

    Public Shared Sub mult(ByVal num As Double)
        If result = 0 Then
            result = num
        Else
            result *= num
        End If
    End Sub

    Public Shared Sub div(ByVal num As Double)
        If result <> 0 AndAlso num = 0 Then
            MessageBox.Show("Cannot divide by 0")
        End If
        If result = 0 Then
            result = num
        Else
            result /= num
        End If
    End Sub

    Public Shared Sub sin(ByVal num As Double)
        If result = 0 Then
            result = Math.Sin(num)
        Else
            result = Math.Sin(result)
        End If
    End Sub

    Public Shared Sub cos(ByVal num As Double)
        If result = 0 Then
            result = Math.Cos(num)
        Else
            result = Math.Cos(result)
        End If
    End Sub

    Public Shared Sub tan(ByVal num As Double)
        If result = 0 Then
            result = Math.Tan(num)
        Else
            result = Math.Tan(result)
        End If
    End Sub

    Public Shared Sub sqrt(ByVal num As Double)
        If result = 0 Then
            result = Math.Sqrt(num)
        Else
            result = Math.Sqrt(result)
        End If
    End Sub

    Public Shared Sub modulo(ByVal num As Double)
        If result = 0 Then
            result = num
        Else
            result = result Mod num
        End If
    End Sub

    Public Shared Sub square(ByVal num As Double)
        result = num * num
    End Sub

    Public Shared Sub cube(ByVal num As Double)
        result = num * num * num
    End Sub

    Public Shared Function factorial(ByVal num As Long) As Long
        If num >= 21 OrElse num < 0 Then
            MessageBox.Show("Enter number between 0 & 20", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return 0
        Else
            If num <= 1 Then
                Return 1
            Else
                Return num * factorial(num - 1)
            End If
        End If
    End Function

    Public Shared Function fibonacci(ByVal num As Long) As Long
        If num >= 40 OrElse num < 0 Then
            MessageBox.Show("Enter number between 0 & 40", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return 0
        Else
            If num = 0 OrElse num = 1 Then
                Return num
            Else
                Return fibonacci(num - 1) + fibonacci(num - 2)
            End If
        End If
    End Function

    Public Shared Sub clear()
        result = 0
    End Sub

    Public Shared Function getResult() As Double
        Return result
    End Function
#End Region
End Class
#End Region