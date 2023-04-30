#Region "Class frmProfessionalTax..."
Public Class frmProfessionalTax
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(13, 40, 45, 13)
        Label2.SetBounds(153, 40, 63, 13)

        txtgross.SetBounds(64, 37, 60, 21)
        txtrate.SetBounds(222, 37, 60, 21)
    End Sub

    Private Sub LoadDataGrid()
        Try
            dgviewtaxrate.Rows.Clear()
            Dim i As Integer = 0
            cmd.CommandText = "select gross,taxrate from ProfessionalTax where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewtaxrate.Rows.Add()
                dgviewtaxrate.Rows(i).Cells(0).Value = dr("gross").ToString()
                dgviewtaxrate.Rows(i).Cells(1).Value = dr("taxrate").ToString()
                i = i + 1
            End While
            dr.Close()
            dgviewtaxrate.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub AddRecord()
        Try
            If txtgross.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter gross salary.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtgross.Focus()
                End If
            ElseIf txtrate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter tax rate.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtrate.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim cls As New cProfessionalTax()
                    cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, CDec(txtgross.Text), CDec(txtrate.Text))
                    If cls.AddRecordOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record added successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = DialogResult.OK Then
                            LoadDataGrid()
                            txtrate.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If txtgross.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter gross salary.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtgross.Focus()
                End If
            ElseIf txtrate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter tax rate.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtrate.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim cls As New cProfessionalTax()
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, CDec(txtgross.Text), CDec(txtrate.Text), professionalgross, professionaltaxrate)
                    If cls.UpdateRecordOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = DialogResult.OK Then
                            LoadDataGrid()
                            txtrate.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If txtgross.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter gross salary.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtgross.Focus()
                End If
            ElseIf txtrate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter tax rate.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtrate.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim cls As New cProfessionalTax()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, CDec(txtgross.Text), CDec(txtrate.Text))
                    If cls.DeleteRecordOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record deleted successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = DialogResult.OK Then
                            ResetForm()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedRecord()
        Try
            cmd.CommandText = "select gross,taxrate from ProfessionalTax where gross=" & professionalgross & " and taxrate=" & professionaltaxrate & " and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                txtgross.Text = dr("gross").ToString()
                txtrate.Text = dr("taxrate").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub ResetForm()
        txtgross.Text = ""
        txtrate.Text = ""
        LoadDataGrid()
        dgviewtaxrate.ClearSelection()
        txtgross.Focus()
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmProfessionalTax_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updateprofessionaltax = False Then
            ControlSetBound()
            LoadDataGrid()
            txtgross.Focus()
        Else
            ControlSetBound()
            LoadDataGrid()
            LoadSelectedRecord()
            txtgross.Focus()
        End If
        If USpayrollsystem = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            txtgross.ReadOnly = True
            txtrate.ReadOnly = True
            dgviewtaxrate.Enabled = False
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updateprofessionaltax = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updateprofessionaltax = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updateprofessionaltax = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updateprofessionaltax = False Then
            ControlSetBound()
            LoadDataGrid()
        Else
            ControlSetBound()
            LoadDataGrid()
            LoadSelectedRecord()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Attributes..."
    Private Sub txtgross_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtgross.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtrate.Focus()
        End If
    End Sub

    Private Sub txtrate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtrate.KeyDown
        If e.KeyCode = Keys.Up Then
            txtgross.Focus()
        End If
    End Sub
#End Region
End Class
#End Region