Public Delegate Sub ValueUpdatedEventHandler(ByVal sender As Object, ByVal e As ValueUpdatedEventArgs)

Public Class ValueUpdatedEventArgs
    Inherits System.EventArgs

    Dim _newValue As String

    Public Sub New(ByVal newValue As String)
        MyBase.New()

        Me._newValue = newValue

    End Sub

    ReadOnly Property NewValue() As String
        Get
            Return Me._newValue
        End Get
    End Property

End Class
