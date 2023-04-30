#Region "Class frmLoginStudent..."
Public Class frmLoginStudent
#Region "Methods..."
    Private Sub ControlSetBound()
        ELabel1.SetBounds(0, 0, 277, 21)
        Label1.SetBounds(84, 123, 84, 13)
        btnclose.SetBounds(226, 161, 70, 32)
        btnhelp.SetBounds(277, 0, 21, 21)
        btnlogin.SetBounds(87, 161, 70, 32)
        PictureBox1.SetBounds(22, 93, 46, 48)
        cmbdob.SetBounds(175, 120, 121, 21)
        txtregistrationno.SetBounds(87, 93, 209, 21)
    End Sub

    Private Sub Login()
        Try
            Dim dob As String = ""
            Dim regno As String = ""
            cmd.CommandText = "select stuid,dob from StudentRegistration where stuid='" & txtregistrationno.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read Then
                regno = dr("stuid").ToString()
                dob = dr("dob").ToString()
            End If
            dr.Close()
            If dob = cmbdob.Text And regno = txtregistrationno.Text.Trim() Then
                StuID = regno
                Dim frm As New frmStudentMainForm()
                frm.MdiParent = Me.MdiParent
                Me.Hide()
                frm.Show()
            End If
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmLoginStudent_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim frm As New frmMainTask()
        frm.MdiParent = Me.MdiParent
        frm.Show()
    End Sub

    Private Sub frmLoginStudent_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
        For Each frmApproval As Form In Me.MdiChildren
            frmApproval.Close()
        Next
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnlogin_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnlogin.ClickButtonArea
        Login()
    End Sub

    Private Sub btnclose_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnclose.ClickButtonArea
        Me.Close()
    End Sub
#End Region
#Region "Attributes..."
    Private Sub txtregistrationno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtregistrationno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbdob.Focus()
        End If
        If e.Control AndAlso (e.KeyCode = Keys.V OrElse e.KeyCode = Keys.C) Then e.SuppressKeyPress = True
    End Sub

    Private Sub cmbdob_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdob.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnlogin.Focus()
        End If
    End Sub

    Private Sub cmbdob_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbdob.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub
#End Region
End Class
#End Region