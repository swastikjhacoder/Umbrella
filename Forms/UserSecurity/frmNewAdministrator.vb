#Region "Class frmNewAdministrator..."
Public Class frmNewAdministrator
#Region "Declarations..."
    Private UserExist As Boolean = False
#End Region
#Region "Events..."
    Public Event ValueUpdated(ByVal sender As Object, ByVal e As ValueUpdatedEventArgs)
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(30, 44, 393, 26)
        Label2.SetBounds(30, 78, 275, 13)
        Label3.SetBounds(84, 123, 70, 13)
        Label4.SetBounds(84, 150, 66, 13)
        txtpassword.SetBounds(173, 147, 253, 21)
        txtusername.SetBounds(173, 120, 253, 21)
        PictureBox1.SetBounds(36, 120, 37, 48)
    End Sub

    Private Sub CreateAdministrator()
        Try
            If txtusername.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter administrator username.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtusername.Focus()
                End If
            ElseIf txtpassword.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter administrator password.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                        Dim userrole As String = "Administrator"
                        Dim access As String = "Full Access"
                        Dim crystalreportall As String = ""
                        Dim crystalreportid As String = ""
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
#Region "Button Events..."
    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        CreateAdministrator()
        Dim newValue As String
        newValue = ""
        Dim valueArgs As ValueUpdatedEventArgs
        valueArgs = New ValueUpdatedEventArgs(newValue)
        RaiseEvent ValueUpdated(Me, valueArgs)
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmNewAdministrator_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
    End Sub
#End Region
#Region "Attributes..."
    Private Sub txtusername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtusername.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtpassword.Text <> "" And txtusername.Text <> "" Then
                CreateAdministrator()
            Else
                txtpassword.Focus()
            End If
        ElseIf e.KeyCode = Keys.Down Then
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtpassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            CreateAdministrator()
        ElseIf e.KeyCode = Keys.Up Then
            txtusername.Focus()
        End If
    End Sub
#End Region
End Class
#End Region