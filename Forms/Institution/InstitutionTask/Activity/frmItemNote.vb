#Region "Class frmItemNote..."
Public Class frmItemNote
#Region "Button Events..."
    Private Sub btnsave_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        ItemNote = rtbnote.rtb.Text
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmItemNote_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updateinventory = False Then
            Me.EGroupBox1.GroupTitle = "Note for Item No: "
            Me.EGroupBox1.GroupTitle += itemid
        Else
            Me.EGroupBox1.GroupTitle = "Note for Item No: "
            Me.EGroupBox1.GroupTitle += itemid
            rtbnote.rtb.Text = ItemNote
        End If
        If USinventory = "View Only" Then
            btnsave.Enabled = False
            rtbnote.rtb.ReadOnly = True
        End If
    End Sub
#End Region
End Class
#End Region