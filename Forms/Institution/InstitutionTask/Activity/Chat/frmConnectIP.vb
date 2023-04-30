Imports ESAR_Controls.UIControls.eForms

Public Class frmConnectIP
    Dim Docker As New FormDocker(Me, FormDocker.FormDockMode.BottomRight, New Padding(5))

    Private Sub frmConnectIP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Docker.DockForm()
        Docker.UndockForm()
        Docker.DockForm()
    End Sub

    Private Sub frmConnectIP_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        Docker.Refresh()
    End Sub

    Private Sub frmConnectIP_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Docker.Refresh()
    End Sub
End Class