#Region "Class frmPFRate..."
Public Class frmPFRate
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(15, 44, 37, 13)
        Label2.SetBounds(120, 44, 55, 13)
        Label3.SetBounds(242, 44, 105, 13)
        Label4.SetBounds(414, 44, 17, 13)

        nudyear.SetBounds(59, 42, 55, 21)

        txtpfrate.SetBounds(181, 41, 55, 21)
        txtamount.SetBounds(353, 41, 55, 21)
    End Sub

    Private Sub LoadRecord()
        Try
            cmd.CommandText = "select year,rate,amount from PFRate where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                nudyear.Value = CInt(dr("year").ToString())
                txtpfrate.Text = dr("rate").ToString()
                txtamount.Text = dr("amount").ToString()
            End If
            dr.Close()
            nudyear.Focus()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If txtpfrate.Text.Trim() = "" Or txtamount.Text.Trim() = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter PF rate or amount.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtpfrate.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    cmd.CommandText = "update PFRate set rate=" & CDec(txtpfrate.Text) & ",amount=" & CDec(txtamount.Text) & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                    dr = cmd.ExecuteReader
                    dr.Close()
                    Dim result1 As DialogResult = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If result1 = DialogResult.OK Then
                        LoadRecord()
                        nudyear.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmPFRate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlSetBound()
        Dim yy As Integer = Date.Now.Year
        nudyear.Maximum = yy + 100
        nudyear.Minimum = yy - 100
        nudyear.Value = yy
        LoadRecord()
        If USpayrollperiodic = "View Only" Then
            btnsave.Enabled = False
            txtamount.ReadOnly = True
            txtpfrate.ReadOnly = True
            nudyear.Enabled = False
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        UpdateRecord()
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        ControlSetBound()
        LoadRecord()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Attributes..."
    Private Sub nudyear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudyear.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpfrate.Focus()
        End If
    End Sub

    Private Sub txtpfrate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpfrate.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtamount.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            nudyear.Focus()
        End If
    End Sub

    Private Sub txtamount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtamount.KeyDown
        If e.KeyCode = Keys.Up Then
            txtpfrate.Focus()
        End If
    End Sub
#End Region
End Class
#End Region