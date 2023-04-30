#Region "Class frmLockLogin..."
Public Class frmLockLogin
    '#Region "Property..."
    '    Public Property ControlBounds() As Rectangle
    '        Get
    '            Return m_ControlBounds
    '        End Get
    '        Set(ByVal value As Rectangle)
    '            m_ControlBounds = value
    '        End Set
    '    End Property
    '#End Region
    '#Region "Declaration..."
    '    Private m_ControlBounds As Rectangle
    '#End Region
    '#Region "Overrides Sub..."
    '    Protected Overrides Sub OnPaintBackground(ByVal e As PaintEventArgs)
    '        Using brush As Brush = New SolidBrush(Color.FromArgb(45, Color.Black))
    '            e.Graphics.FillRectangle(brush, e.ClipRectangle)
    '        End Using
    '        Me.Opacity = 25
    '    End Sub
    '#End Region
#Region "Methods..."
    Private Sub Login()
        If txtusername.Text = USuserid And txtpassword.Text = USuserpasswd Then
            Me.Close()
        Else
            Dim result As DialogResult = MessageBox.Show("Username/ Password doesn't match" + Environment.NewLine + "Please enter correct Username & Password.", "Umbrella - Username/ Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = DialogResult.OK Then
                txtusername.Focus()
            End If
        End If
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmLockLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.RoundedPanel1.SetBounds((Me.Width - RoundedPanel1.Width) / 2, (Me.Height - RoundedPanel1.Height) / 2, 400, 125)
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnlogin_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnlogin.ClickButtonArea
        Login()
    End Sub

    Private Sub btnclose_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnclose.ClickButtonArea
        conn.Close()
        Application.Exit()
    End Sub
#End Region
#Region "Attributes..."
    Private Sub txtusername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtusername.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtpassword.Text <> "" And txtusername.Text <> "" Then
                Login()
            Else
                txtpassword.Focus()
            End If
        ElseIf e.KeyCode = Keys.Down Then
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtpassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtpassword.Text <> "" And txtusername.Text <> "" Then
                Login()
            End If
        ElseIf e.KeyCode = Keys.Up Then
            txtusername.Focus()
        End If
    End Sub
#End Region
End Class
#End Region