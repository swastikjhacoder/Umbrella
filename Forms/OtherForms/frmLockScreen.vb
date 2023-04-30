#Region "Class frmLockScreen..."
Public Class frmLockScreen
    '#Region "Protected Overrides Sub..."
    '    Protected Overrides Sub OnPaintBackground(ByVal e As PaintEventArgs)
    '        Using brush As Brush = New SolidBrush(Color.FromArgb(65, Color.Cornsilk))
    '            e.Graphics.FillRectangle(brush, e.ClipRectangle)
    '        End Using
    '    End Sub
    '#End Region
#Region "Form Events..."
    Private Sub frmLockScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SetBounds(5, 20, frmInstitutionMainForm.ClientRectangle.Width, frmInstitutionMainForm.ClientRectangle.Height)
        Me.Grouper1.SetBounds((Me.Width - Grouper1.Width) / 2, (Me.Height - Grouper1.Height) / 2, 265, 88)
    End Sub
#End Region
#Region "Attributes..."
    Private Sub ELabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ELabel1.Click
        Me.Close()
        Dim LightBox As New frmLockLogin()
        LightBox.SetBounds(5, 20, frmInstitutionMainForm.ClientRectangle.Width, frmInstitutionMainForm.ClientRectangle.Height)
        LightBox.Owner = Me
        LightBox.ShowDialog()
    End Sub
#End Region
End Class
#End Region