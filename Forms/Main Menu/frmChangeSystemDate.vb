#Region "Class frmChangeSystemDate..."
Public Class frmChangeSystemDate
#Region "Events..."
    Public Event ValueUpdated(ByVal sender As Object, ByVal e As ValueUpdatedEventArgs)
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        btncancel.SetBounds(16, 55, 75, 25)
        btnhelp.SetBounds(16, 86, 75, 25)
        btnok.SetBounds(16, 24, 75, 25)
        Label1.SetBounds(107, 60, 39, 13)
        cmbdate.SetBounds(152, 57, 120, 21)
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmChangeSystemDate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
        cmbdate.Text = UmbrellaSystemDate
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btncancel_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btncancel.ClickButtonArea
        Me.Close()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub

    Private Sub btnok_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnok.ClickButtonArea
        UmbrellaSystemDate = cmbdate.Text
        Dim newValue As String
        newValue = Me.cmbdate.Text
        Dim valueArgs As ValueUpdatedEventArgs
        valueArgs = New ValueUpdatedEventArgs(newValue)
        RaiseEvent ValueUpdated(Me, valueArgs)
        Me.Close()
    End Sub
#End Region
End Class
#End Region