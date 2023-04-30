#Region "Class frmInternetConnection..."
Public Class frmInternetConnection
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(15, 39, 461, 26)
        Label2.SetBounds(67, 102, 352, 13)
        Label3.SetBounds(67, 238, 58, 13)
        Label4.SetBounds(256, 238, 35, 13)
        Label5.SetBounds(64, 261, 280, 13)

        cmbdialup.SetBounds(70, 124, 168, 21)

        chkprompt.SetBounds(70, 151, 292, 17)
        chkproxy.SetBounds(70, 214, 127, 17)

        btnaddnew.SetBounds(244, 120, 95, 25)
        btnadvance.SetBounds(356, 231, 83, 25)

        rbtndialup.SetBounds(33, 82, 272, 17)
        rbtndirect.SetBounds(33, 191, 383, 17)
        rbtnnotconnected.SetBounds(33, 292, 292, 17)

        txtaddress.SetBounds(131, 235, 116, 21)
        txtport.SetBounds(297, 235, 42, 21)
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmInternetConnection_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnadvance_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnadvance.ClickButtonArea

    End Sub

    Private Sub btnaddnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnaddnew.ClickButtonArea

    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea

    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region