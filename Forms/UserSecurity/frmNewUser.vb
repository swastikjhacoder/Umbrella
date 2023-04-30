#Region "Class frmMaintainUser..."
Public Class frmNewUser
#Region "Declarations..."
    Private UserExist As Boolean = False
#End Region
#Region "Events..."
    Public Event ValueUpdated(ByVal sender As Object, ByVal e As ValueUpdatedEventArgs)
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(67, 32, 70, 13)
        Label2.SetBounds(67, 59, 66, 13)
        PictureBox1.SetBounds(24, 30, 37, 48)
        rbtnadministrator.SetBounds(24, 30, 351, 17)
        rbtnfullaccess.SetBounds(24, 53, 87, 17)
        rbtnnoaccess.SetBounds(24, 99, 54, 17)
        rbtnviewonly.SetBounds(24, 76, 117, 17)
        txtpassword.SetBounds(151, 56, 285, 21)
        txtusername.SetBounds(151, 29, 285, 21)
    End Sub

    Private Sub CreateUser()
        Try
            If txtusername.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter username.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtusername.Focus()
                End If
            ElseIf txtpassword.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter user password.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtpassword.Focus()
                End If
            ElseIf rbtnadministrator.Checked = False And rbtnfullaccess.Checked = False And rbtnnoaccess.Checked = False And rbtnviewonly.Checked = False Then
                Dim result As DialogResult = MessageBox.Show("Please select user access.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtpassword.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    CheckUser()
                    If UserExist = False Then
                        cmd.CommandText = "select userid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
                        dr = cmd.ExecuteReader
                        dr.Read()
                        Dim userno As Integer = CInt(dr("userid").ToString())
                        dr.Close()
                        userno = userno + 1
                        Dim userrole As String = ""
                        Dim access As String = ""
                        If rbtnadministrator.Checked = True Then
                            userrole = "Administrator"
                            access = "Full Access"
                        ElseIf rbtnfullaccess.Checked = True Then
                            userrole = "Employee"
                            access = "Full Access"
                        ElseIf rbtnnoaccess.Checked = True Then
                            userrole = "Employee"
                            access = "No Access"
                        ElseIf rbtnviewonly.Checked = True Then
                            userrole = "Employee"
                            access = "View Only"
                        End If
                        Dim cls As New cUser()
                        cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, userno, userrole, txtusername.Text, txtpassword.Text, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access, access)
                        If cls.AddUserOk = True Then
                            Dim result1 As DialogResult = MessageBox.Show("Record added successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = DialogResult.OK Then
                                txtusername.Focus()
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("User already exist." + Environment.NewLine + "Please enter a new username.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result1 = DialogResult.OK Then
                            txtusername.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckUser()
        Try
            cmd.CommandText = "select * from Users where userid='" & txtusername.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                UserExist = True
            Else
                UserExist = False
            End If
            dr.Close()
        Catch ex As Exception
            UserExist = False
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmNewUser_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
    End Sub
#End Region
#Region "Attributes..."
    Private Sub txtusername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtusername.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtpassword.Text <> "" And txtusername.Text <> "" Then
                CreateUser()
            Else
                txtpassword.Focus()
            End If
        ElseIf e.KeyCode = Keys.Down Then
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtpassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            CreateUser()
        ElseIf e.KeyCode = Keys.Up Then
            txtusername.Focus()
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        CreateUser()
        Dim newValue As String
        newValue = ""
        Dim valueArgs As ValueUpdatedEventArgs
        valueArgs = New ValueUpdatedEventArgs(newValue)
        RaiseEvent ValueUpdated(Me, valueArgs)
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region