#Region "Class frmSetupDefaultsPayroll..."
Public Class frmSetupDefaultsPayroll
#Region "Declarations..."
    Private DGVAccount As New DataGridView()
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(35, 23, 161, 13)
        Label2.SetBounds(35, 23, 130, 13)
        Label3.SetBounds(219, 23, 103, 13)
        chkautuid.SetBounds(38, 28, 398, 30)
        cmbaccount.SetBounds(202, 20, 121, 21)
        txtbasicpercent.SetBounds(171, 20, 42, 21)
    End Sub

    Private Sub LoadAccounts()
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .Name = "Col1"
                .HeaderText = "Account No."
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .Name = "Col2"
                .HeaderText = "Account Name"
            End With
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .Name = "Col3"
                .HeaderText = "Balance"
            End With

            With DGVAccount
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVAccount.CellClick, AddressOf DGVAccount_CellClick
            End With

            DGVAccount.Columns.Clear()
            DGVAccount.Columns.Add(col1)
            DGVAccount.Columns.Add(col2)
            DGVAccount.Columns.Add(col3)

            DGVAccount.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select AccountID,AccountName,AccountBalance from Accounts where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVAccount.Rows.Add()
                DGVAccount.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVAccount.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVAccount.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                indx = indx + 1
            End While
            dr.Close()
            DGVAccount.ClearSelection()

            cmbaccount.AddDataGridView(DGVAccount, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVAccount_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVAccount.CurrentRow.Index
            DGVAccount.Rows(k).Selected = True
            DGVAccount.CurrentCell = DGVAccount.Rows(k).Cells(0)
            AccID = DGVAccount.Rows(k).Cells(0).Value.ToString()
            cmbaccount.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadRecord()
        Try
            cmd.CommandText = "select autoid,salaryaccount,basicincr from DefaultPayroll where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr("autoid").ToString() = "Yes" Then
                chkautuid.Checked = True
            Else
                chkautuid.Checked = False
            End If
            cmbaccount.Text = dr("salaryaccount").ToString()
            txtbasicpercent.Text = dr("basicincr").ToString()
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If cmbaccount.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter charges account.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbaccount.Focus()
                End If
            ElseIf txtbasicpercent.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter basic increment percentage value.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtbasicpercent.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim autoid As String
                    If chkautuid.Checked = True Then
                        autoid = "Yes"
                    Else
                        autoid = "No"
                    End If
                    Dim cls As New cSetupDefaults()
                    cls.UpdatePayrollDefault(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, autoid, cmbaccount.Text, CDec(txtbasicpercent.Text))
                    If cls.UpdatePayrollDefaultOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            PSDAutoID = autoid
                            PSDBasicIncrement = CDec(txtbasicpercent.Text)
                            PSDSalaryAccount = cmbaccount.Text
                            Me.Close()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmSetupDefaultsPayroll_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
        LoadAccounts()
        LoadRecord()
        If USPayrollDefault = "View Only" Then
            btnsave.Enabled = False
            chkautuid.Enabled = False
            txtbasicpercent.ReadOnly = True
            cmbaccount.Enabled = False
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        UpdateRecord()
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        ControlSetBound()
        LoadAccounts()
        LoadRecord()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region