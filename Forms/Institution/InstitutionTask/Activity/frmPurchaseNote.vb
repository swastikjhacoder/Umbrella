#Region "Class frmPurchaseNote..."
Public Class frmPurchaseNote
#Region "Form Events..."
    Private Sub frmPurchaseNote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If updatepurchase = False Then
            Me.EGroupBox1.GroupTitle = "Note for Purchase No: "
            Me.EGroupBox1.GroupTitle += purchaseid
        Else
            Me.EGroupBox1.GroupTitle = "Note for Purchase No: "
            Me.EGroupBox1.GroupTitle += purchaseid
            rtbnote.rtb.Text = PurchaseNote
        End If
        If USpurchaseorder = "View Only" Then
            btnsave.Enabled = False
            rtbnote.rtb.ReadOnly = True
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnsave_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        PurchaseNote = rtbnote.rtb.Text
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region