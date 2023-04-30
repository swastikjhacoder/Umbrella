#Region "Class frmPFOpeningClosingBalanace..."
Public Class frmPFOpeningClosingBalanace
#Region "Form Events..."
    Private Sub frmPFOpeningClosingBalanace_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim yy As Integer = Date.Now.Year
        nudyear.Maximum = yy + 25
        nudyear.Minimum = yy - 25
        nudyear.Value = yy
        txtyear.Text = (yy - 1).ToString()
        If USpayrollpf = "View Only" Then
            nudyear.Enabled = False
            txtstartpage.ReadOnly = True
            txtyear.ReadOnly = True
            rbtnclosing.Enabled = False
            rbtnopening.Enabled = False
        End If
    End Sub
#End Region
End Class
#End Region