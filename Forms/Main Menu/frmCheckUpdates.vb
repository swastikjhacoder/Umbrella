#Region "Class frmCheckUpdates..."
Public Class frmCheckUpdates
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(20, 15, 402, 13)
        Label2.SetBounds(328, 47, 48, 13)
        chkremindme.SetBounds(23, 46, 249, 17)
        btnchecknow.SetBounds(44, 86, 102, 25)
        btnclose.SetBounds(197, 86, 75, 25)
        btnhelp.SetBounds(323, 86, 64, 25)
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmCheckUpdates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlSetBound()
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnchecknow_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnchecknow.ClickButtonArea
        Dim frm As New frmInternetConnection()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.Show()
    End Sub

    Private Sub btnclose_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnclose.ClickButtonArea
        Me.Close()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region