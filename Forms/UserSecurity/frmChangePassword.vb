#Region "Class frmChangePassword..."
Public Class frmChangePassword
#Region "Declarations..."
    Private UsernameOK As Boolean = False
    Private OldPasswordOK As Boolean = False
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(80, 35, 70, 13)
        Label2.SetBounds(80, 62, 89, 13)
        Label3.SetBounds(80, 89, 94, 13)
        Label4.SetBounds(80, 116, 86, 13)
        Label5.SetBounds(12, 16, 356, 26)
        Label6.SetBounds(12, 56, 288, 26)
        Label7.SetBounds(12, 96, 343, 65)
        txtconfirm.SetBounds(174, 113, 200, 21)
        txtnewpassword.SetBounds(174, 86, 200, 21)
        txtoldpassword.SetBounds(174, 59, 200, 21)
        txtusername.SetBounds(174, 32, 200, 21)
        PictureBox1.SetBounds(15, 58, 57, 50)
    End Sub

    Private Sub CheckUsername()
        Try
            cmd.CommandText = "select * from Users where userid='" & txtusername.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                UsernameOK = True
            Else
                UsernameOK = False
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CheckPassword()
        Try
            Dim pwd As String
            cmd.CommandText = "select userpasswd from Users where userid='" & txtusername.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                pwd = dr("userpasswd").ToString()
            Else
                OldPasswordOK = False
                pwd = ""
            End If
            dr.Close()
            If txtoldpassword.Text = pwd Then
                OldPasswordOK = True
            Else
                OldPasswordOK = False
            End If
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub ChangePassword()
        Try
            CheckUsername()
            If UsernameOK = True Then
                CheckPassword()
                If OldPasswordOK = True Then
                    If txtusername.Text = "" Then
                        Dim result As DialogResult = MessageBox.Show("Please enter username.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result = DialogResult.OK Then
                            txtusername.Focus()
                        End If
                    ElseIf txtoldpassword.Text = "" Then
                        Dim result As DialogResult = MessageBox.Show("Please enter user old password.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result = DialogResult.OK Then
                            txtoldpassword.Focus()
                        End If
                    ElseIf txtnewpassword.Text <> txtconfirm.Text Then
                        Dim result As DialogResult = MessageBox.Show("New user password doesn't match" + Environment.NewLine + "Please correct the new password.", "Umbrella - Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result = DialogResult.OK Then
                            txtnewpassword.Focus()
                        End If
                    Else
                        Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If result = DialogResult.Yes Then
                            Dim cls As New cUser()
                            cls.ChangeUserPassword(txtconfirm.Text, My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, txtusername.Text)
                            If cls.ChangePasswordOk = True Then
                                Dim result1 As DialogResult = MessageBox.Show("Password changed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                If result1 = DialogResult.OK Then
                                    txtusername.Focus()
                                End If
                            End If
                        End If
                    End If
                Else
                    Dim result As DialogResult = MessageBox.Show("This user password doesn't match." + Environment.NewLine + "Please enter correct user password.", "Umbrella - Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    If result = DialogResult.OK Then
                        txtoldpassword.Focus()
                    End If
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Umbrella doesn't found this user." + Environment.NewLine + "Please enter correct username.", "Umbrella - Username Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtusername.Focus()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Events...    "
    Private Sub frmChangePassword_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
        txtusername.Text = userid
    End Sub
#End Region
#Region "Attributes..."
    Private Sub txtusername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtusername.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtoldpassword.Focus()
        End If
    End Sub

    Private Sub txtoldpassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtoldpassword.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtnewpassword.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtusername.Focus()
        End If
    End Sub

    Private Sub txtnewpassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnewpassword.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtconfirm.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtoldpassword.Focus()
        End If
    End Sub

    Private Sub txtconfirm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtconfirm.KeyDown
        If e.KeyCode = Keys.Enter Then

        ElseIf e.KeyCode = Keys.Up Then
            txtnewpassword.Focus()
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        ChangePassword()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region