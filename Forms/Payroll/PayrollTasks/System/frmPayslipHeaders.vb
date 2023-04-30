#Region "Class frmPayslipHeaders..."
Public Class frmPayslipHeaders
#Region "Methods..."
    Private Sub ControlSetBound()
        txtallowancedesc1.SetBounds(24, 31, 320, 21)
        txtallowanceshortdesc1.SetBounds(350, 31, 162, 21)
        txtallowanceshortdesc2.SetBounds(350, 58, 162, 21)
        txtallowancedesc2.SetBounds(24, 58, 320, 21)
        txtallowanceshortdesc3.SetBounds(350, 85, 162, 21)
        txtallowancedesc3.SetBounds(24, 85, 320, 21)
        txtallowanceshortdesc4.SetBounds(350, 112, 162, 21)
        txtallowancedesc4.SetBounds(24, 112, 320, 21)
        txtdeductionshortdesc1.SetBounds(350, 31, 162, 21)
        txtdeductiondesc1.SetBounds(24, 31, 320, 21)
        txtdeductionshortdesc2.SetBounds(350, 58, 162, 21)
        txtdeductiondesc2.SetBounds(24, 58, 320, 21)
        txtdeductionshortdesc3.SetBounds(350, 85, 162, 21)
        txtdeductiondesc3.SetBounds(24, 85, 320, 21)
        txtsignatoryshortdesc3.SetBounds(350, 86, 162, 21)
        txtsignatorydesc3.SetBounds(24, 86, 320, 21)
        txtsignatoryshortdesc2.SetBounds(350, 59, 162, 21)
        txtsignatorydesc2.SetBounds(24, 59, 320, 21)
        txtsignatoryshortdesc1.SetBounds(350, 32, 162, 21)
        txtsignatorydesc1.SetBounds(24, 32, 320, 21)
    End Sub

    Private Sub LoadRecord()
        Try
            cmd.CommandText = "select * from PayslipHeaders where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            txtallowancedesc1.Text = dr("allowancedesc1").ToString()
            txtallowancedesc2.Text = dr("allowancedesc2").ToString()
            txtallowancedesc3.Text = dr("allowancedesc3").ToString()
            txtallowancedesc4.Text = dr("allowancedesc4").ToString()
            txtallowanceshortdesc1.Text = dr("allowanceshortdesc1").ToString()
            txtallowanceshortdesc2.Text = dr("allowanceshortdesc2").ToString()
            txtallowanceshortdesc3.Text = dr("allowanceshortdesc3").ToString()
            txtallowanceshortdesc4.Text = dr("allowanceshortdesc4").ToString()
            txtdeductiondesc1.Text = dr("deductiondesc1").ToString()
            txtdeductiondesc2.Text = dr("deductiondesc2").ToString()
            txtdeductiondesc3.Text = dr("deductiondesc3").ToString()
            txtdeductionshortdesc1.Text = dr("deductionshortdesc1").ToString()
            txtdeductionshortdesc2.Text = dr("deductionshortdesc2").ToString()
            txtdeductionshortdesc3.Text = dr("deductionshortdesc3").ToString()
            txtsignatorydesc1.Text = dr("signatorydesc1").ToString()
            txtsignatorydesc2.Text = dr("signatorydesc2").ToString()
            txtsignatorydesc3.Text = dr("signatorydesc3").ToString()
            txtsignatoryshortdesc1.Text = dr("signatoryshortdesc1").ToString()
            txtsignatoryshortdesc2.Text = dr("signatoryshortdesc2").ToString()
            txtsignatoryshortdesc3.Text = dr("signatoryshortdesc3").ToString()
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                cmd.CommandText = "update PayslipHeaders set allowancedesc1='" & txtallowancedesc1.Text & "',allowanceshortdesc1='" & txtallowanceshortdesc1.Text & "',allowancedesc2='" & txtallowancedesc2.Text & "',allowanceshortdesc2='" & txtallowanceshortdesc2.Text & "',allowancedesc3='" & txtallowancedesc3.Text & "',allowanceshortdesc3='" & txtallowanceshortdesc3.Text & "',allowancedesc4='" & txtallowancedesc4.Text & "',allowanceshortdesc4='" & txtallowanceshortdesc4.Text & "',deductiondesc1='" & txtdeductiondesc1.Text & "',deductionshortdesc1='" & txtdeductionshortdesc1.Text & "',deductiondesc2='" & txtdeductiondesc2.Text & "',deductionshortdesc2='" & txtdeductionshortdesc2.Text & "',deductiondesc3='" & txtdeductiondesc3.Text & "',deductionshortdesc3='" & txtdeductionshortdesc3.Text & "',signatorydesc1='" & txtsignatorydesc1.Text & "',signatoryshortdesc1='" & txtsignatoryshortdesc1.Text & "',signatorydesc2='" & txtsignatorydesc2.Text & "',signatoryshortdesc2='" & txtsignatoryshortdesc2.Text & "',signatorydesc3='" & txtsignatorydesc3.Text & "',signatoryshortdesc3 ='" & txtsignatoryshortdesc3.Text & "' where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                dr.Close()
                Dim result1 As DialogResult = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If result1 = DialogResult.OK Then
                    LoadRecord()
                    txtallowancedesc1.Focus()
                End If
            End If
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmPayslipHeaders_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
        LoadRecord()
        If USpayrollsystem = "View Only" Then
            btnsave.Enabled = False
            txtallowancedesc1.ReadOnly = True
            txtallowancedesc2.ReadOnly = True
            txtallowancedesc3.ReadOnly = True
            txtallowancedesc4.ReadOnly = True
            txtallowanceshortdesc1.ReadOnly = True
            txtallowanceshortdesc2.ReadOnly = True
            txtallowanceshortdesc3.ReadOnly = True
            txtallowanceshortdesc4.ReadOnly = True
            txtdeductiondesc1.ReadOnly = True
            txtdeductiondesc2.ReadOnly = True
            txtdeductiondesc3.ReadOnly = True
            txtdeductionshortdesc1.ReadOnly = True
            txtdeductionshortdesc2.ReadOnly = True
            txtdeductionshortdesc3.ReadOnly = True
            txtsignatorydesc1.ReadOnly = True
            txtsignatorydesc2.ReadOnly = True
            txtsignatorydesc3.ReadOnly = True
            txtsignatoryshortdesc1.ReadOnly = True
            txtsignatoryshortdesc2.ReadOnly = True
            txtsignatoryshortdesc3.ReadOnly = True
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        UpdateRecord()
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        LoadRecord()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Attributes..."
    Private Sub txtallowancedesc1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtallowancedesc1.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtallowanceshortdesc1.Focus()
        End If
    End Sub

    Private Sub txtallowanceshortdesc1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtallowanceshortdesc1.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtallowancedesc2.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtallowancedesc1.Focus()
        End If
    End Sub

    Private Sub txtallowancedesc2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtallowancedesc2.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtallowanceshortdesc2.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtallowanceshortdesc1.Focus()
        End If
    End Sub

    Private Sub txtallowanceshortdesc2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtallowanceshortdesc2.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtallowancedesc3.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtallowancedesc2.Focus()
        End If
    End Sub

    Private Sub txtallowancedesc3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtallowancedesc3.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtallowanceshortdesc3.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtallowanceshortdesc2.Focus()
        End If
    End Sub

    Private Sub txtallowanceshortdesc3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtallowanceshortdesc3.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtallowancedesc4.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtallowancedesc3.Focus()
        End If
    End Sub

    Private Sub txtallowancedesc4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtallowancedesc4.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtallowanceshortdesc4.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtallowanceshortdesc3.Focus()
        End If
    End Sub

    Private Sub txtallowanceshortdesc4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtallowanceshortdesc4.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtdeductiondesc1.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtallowancedesc4.Focus()
        End If
    End Sub

    Private Sub txtdeductiondesc1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdeductiondesc1.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtdeductionshortdesc1.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtallowanceshortdesc4.Focus()
        End If
    End Sub

    Private Sub txtdeductionshortdesc1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdeductionshortdesc1.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtdeductiondesc2.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtdeductiondesc1.Focus()
        End If
    End Sub

    Private Sub txtdeductiondesc2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdeductiondesc2.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtdeductionshortdesc2.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtdeductionshortdesc1.Focus()
        End If
    End Sub

    Private Sub txtdeductionshortdesc2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdeductionshortdesc2.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtdeductiondesc3.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtdeductiondesc2.Focus()
        End If
    End Sub

    Private Sub txtdeductiondesc3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdeductiondesc3.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtdeductionshortdesc3.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtdeductionshortdesc2.Focus()
        End If
    End Sub

    Private Sub txtdeductionshortdesc3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdeductionshortdesc3.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtsignatorydesc1.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtdeductiondesc3.Focus()
        End If
    End Sub

    Private Sub txtsignatorydesc1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsignatorydesc1.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtsignatoryshortdesc1.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtdeductionshortdesc3.Focus()
        End If
    End Sub

    Private Sub txtsignatoryshortdesc1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsignatoryshortdesc1.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtsignatorydesc2.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtsignatorydesc1.Focus()
        End If
    End Sub

    Private Sub txtsignatorydesc2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsignatorydesc2.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtsignatoryshortdesc2.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtsignatoryshortdesc1.Focus()
        End If
    End Sub

    Private Sub txtsignatoryshortdesc2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsignatoryshortdesc2.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtsignatorydesc3.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtsignatorydesc2.Focus()
        End If
    End Sub

    Private Sub txtsignatorydesc3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsignatorydesc3.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtsignatoryshortdesc3.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtsignatoryshortdesc2.Focus()
        End If
    End Sub

    Private Sub txtsignatoryshortdesc3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsignatoryshortdesc3.KeyDown
        If e.KeyCode = Keys.Up Then
            txtsignatorydesc3.Focus()
        End If
    End Sub

    Private Sub TextBoxTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtallowancedesc1.TextChanged, txtallowancedesc2.TextChanged, txtallowancedesc3.TextChanged, txtallowancedesc4.TextChanged, txtallowanceshortdesc1.TextChanged, txtallowanceshortdesc2.TextChanged, txtallowanceshortdesc3.TextChanged, txtallowanceshortdesc4.TextChanged, txtdeductiondesc1.TextChanged, txtdeductiondesc2.TextChanged, txtdeductiondesc3.TextChanged, txtdeductionshortdesc1.TextChanged, txtdeductionshortdesc2.TextChanged, txtdeductionshortdesc3.TextChanged, txtsignatorydesc1.TextChanged, txtsignatorydesc2.TextChanged, txtsignatorydesc3.TextChanged, txtsignatoryshortdesc1.TextChanged, txtsignatoryshortdesc2.TextChanged, txtsignatoryshortdesc3.TextChanged
        Dim x As ESAR_Controls.UIControls.TextBox.eTextBox = CType(sender, ESAR_Controls.UIControls.TextBox.eTextBox)
        ctc.ConvertTextBoxValidValue(x)
    End Sub
#End Region
End Class
#End Region