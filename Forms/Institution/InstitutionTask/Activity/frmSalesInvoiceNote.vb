#Region "Class frmSalesInvoiceNote..."
Public Class frmSalesInvoiceNote
#Region "Form Events..."
    Private Sub frmSalesInvoiceNote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If updateinvoice = False Then
            Me.EGroupBox1.GroupTitle = "Note for Invoice No: "
            Me.EGroupBox1.GroupTitle += invoiceid
        Else
            Me.EGroupBox1.GroupTitle = "Note for Invoice No: "
            Me.EGroupBox1.GroupTitle += invoiceid
            rtbnote.rtb.Text = InvoiceNote
        End If
        If USsalesinvoice = "View Only" Then
            btnsave.Enabled = False
            rtbnote.rtb.ReadOnly = True
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnsave_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        InvoiceNote = rtbnote.rtb.Text
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region