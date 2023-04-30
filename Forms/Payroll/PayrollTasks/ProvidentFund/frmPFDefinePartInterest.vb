#Region "Imports..."
Imports ESAR_Controls.UIControls.ComboBox
#End Region
#Region "Class frmPFDefinePartInterest..."
Public Class frmPFDefinePartInterest
#Region "Declarations..."
    Private DGVEmpRegNo As New DataGridView()
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(17, 20, 102, 13)
        Label2.SetBounds(17, 46, 45, 13)
        Label3.SetBounds(17, 74, 48, 13)
        Label4.SetBounds(17, 102, 103, 13)
        Label5.SetBounds(254, 102, 80, 13)
        Label6.SetBounds(17, 129, 85, 13)

        cmbclosingdate.SetBounds(125, 126, 126, 21)
        cmbperiod.SetBounds(125, 71, 305, 21)
        cmbregno.SetBounds(125, 17, 126, 21)

        txtclosingbalance.SetBounds(125, 99, 126, 21)
        txtname.SetBounds(125, 44, 305, 21)
        txtoutstanding.SetBounds(340, 99, 90, 21)
    End Sub

    Private Sub LoadEmpRegNo()
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .Name = "Col1"
                .HeaderText = "Employee ID"
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .Name = "Col2"
                .HeaderText = "Name"
            End With
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .Name = "Col3"
                .HeaderText = "Designation"
            End With

            With DGVEmpRegNo
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
                AddHandler DGVEmpRegNo.CellClick, AddressOf DGVEmpRegNo_CellClick
            End With

            DGVEmpRegNo.Columns.Clear()
            DGVEmpRegNo.Columns.Add(col1)
            DGVEmpRegNo.Columns.Add(col2)
            DGVEmpRegNo.Columns.Add(col3)

            DGVEmpRegNo.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select empid,name,designation from Employee where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVEmpRegNo.Rows.Add()
                DGVEmpRegNo.Rows(indx).Cells(0).Value = dr("empid").ToString()
                DGVEmpRegNo.Rows(indx).Cells(1).Value = dr("name").ToString()
                DGVEmpRegNo.Rows(indx).Cells(2).Value = dr("designation").ToString()

                indx = indx + 1
            End While
            dr.Close()
            DGVEmpRegNo.ClearSelection()

            cmbregno.AddDataGridView(DGVEmpRegNo, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVEmpRegNo_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVEmpRegNo.CurrentRow.Index
            DGVEmpRegNo.Rows(k).Selected = True
            DGVEmpRegNo.CurrentCell = DGVEmpRegNo.Rows(k).Cells(0)
            EmpRegNo = DGVEmpRegNo.Rows(k).Cells(0).Value.ToString()
            EmpName = DGVEmpRegNo.Rows(k).Cells(1).Value.ToString()
            cmbregno.Text = EmpRegNo
            txtname.Text = EmpName
            LoadBalance(EmpRegNo, EmpName)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadBalance(ByVal regno As String, ByVal name As String)
        Try
            cmd.CommandText = "select openingbalance,outstandingadvance from PF where regno='" & regno & "' and name='" & name & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            txtclosingbalance.Text = dr("openingbalance").ToString()
            txtoutstanding.Text = dr("outstandingadvance").ToString()
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub ResetForm()
        updatepfmembership = False
        cmbclosingdate.Text = UmbrellaSystemDate
        cmbperiod.Text = My.Settings.FinancialPeriod
        cmbregno.Text = ""
        txtclosingbalance.Text = ""
        txtname.Text = ""
        txtoutstanding.Text = ""
        cmbregno.Focus()
    End Sub

    Private Sub AddRecord()
        Try
            If cmbregno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select employee regno.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbregno.Focus()
                End If
            ElseIf txtname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter employee name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtname.Focus()
                End If
            ElseIf cmbperiod.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select period.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbperiod.Focus()
                End If
            ElseIf cmbclosingdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select closing date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbclosingdate.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim cls As New cClosingMembership()
                    Dim bal As Decimal
                    Dim outstanding As Decimal
                    If txtclosingbalance.Text <> "" Then
                        bal = CDec(txtclosingbalance.Text)
                    Else
                        bal = 0.0
                    End If
                    If txtoutstanding.Text <> "" Then
                        outstanding = CDec(txtoutstanding.Text)
                    Else
                        outstanding = 0.0
                    End If
                    cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, cmbregno.Text, txtname.Text, bal, outstanding, cmbclosingdate.Text)
                    If cls.AddRecordOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Is this employee retired?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If result1 = DialogResult.Yes Then

                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If cmbregno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select employee regno.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbregno.Focus()
                End If
            ElseIf txtname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter employee name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtname.Focus()
                End If
            ElseIf cmbperiod.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select period.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbperiod.Focus()
                End If
            ElseIf cmbclosingdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select closing date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbclosingdate.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim cls As New cClosingMembership()
                    Dim bal As Decimal
                    Dim outstanding As Decimal
                    If txtclosingbalance.Text <> "" Then
                        bal = CDec(txtclosingbalance.Text)
                    Else
                        bal = 0.0
                    End If
                    If txtoutstanding.Text <> "" Then
                        outstanding = CDec(txtoutstanding.Text)
                    Else
                        outstanding = 0.0
                    End If
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, cmbregno.Text, txtname.Text, bal, outstanding, cmbclosingdate.Text)
                    If cls.UpdateRecordOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully!!!", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = DialogResult.OK Then
                            cmbregno.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If cmbregno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select employee regno.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbregno.Focus()
                End If
            ElseIf txtname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter employee name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtname.Focus()
                End If
            ElseIf cmbperiod.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select period.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbperiod.Focus()
                End If
            ElseIf cmbclosingdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select closing date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbclosingdate.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim cls As New cClosingMembership()
                    Dim bal As Decimal
                    Dim outstanding As Decimal
                    If txtclosingbalance.Text <> "" Then
                        bal = CDec(txtclosingbalance.Text)
                    Else
                        bal = 0.0
                    End If
                    If txtoutstanding.Text <> "" Then
                        outstanding = CDec(txtoutstanding.Text)
                    Else
                        outstanding = 0.0
                    End If
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, cmbregno.Text, txtname.Text)
                    If cls.DeleteRecordOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record deleted successfully!!!", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            cmd.CommandText = "select closingdate,regno,closingbal,name,outstanding from CloseMembership where regno='" & EmpRegNo & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                cmbclosingdate.Text = dr("closingdate").ToString()
                cmbperiod.Text = My.Settings.FinancialPeriod
                cmbregno.Text = dr("regno").ToString()
                txtclosingbalance.Text = dr("closingbal").ToString()
                txtname.Text = dr("name").ToString()
                txtoutstanding.Text = dr("outstanding").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmPFDefinePartInterest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updatepfmembership = False Then
            ControlSetBound()
            cmbclosingdate.Text = UmbrellaSystemDate
            cmbperiod.Items.Add(New ComboBoxIconItem(My.Settings.FinancialPeriod, 0))
            cmbperiod.Text = My.Settings.FinancialPeriod
            LoadEmpRegNo()
        Else
            ControlSetBound()
            cmbperiod.Items.Add(New ComboBoxIconItem(My.Settings.FinancialPeriod, 0))
            cmbperiod.Text = My.Settings.FinancialPeriod
            LoadEmpRegNo()
            LoadSelectedRecord()
        End If
        If USpayrollpf = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbclosingdate.Enabled = False
            cmbperiod.Enabled = False
            cmbregno.Enabled = False
            txtclosingbalance.ReadOnly = True
            txtname.ReadOnly = True
            txtoutstanding.ReadOnly = True
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatepfmembership = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatepfmembership = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatepfmembership = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updatepfmembership = False Then
            ControlSetBound()
            cmbclosingdate.Text = UmbrellaSystemDate
            cmbperiod.Items.Add(New ComboBoxIconItem(My.Settings.FinancialPeriod, 0))
            cmbperiod.Text = My.Settings.FinancialPeriod
            LoadEmpRegNo()
        Else
            ControlSetBound()
            cmbperiod.Items.Add(New ComboBoxIconItem(My.Settings.FinancialPeriod, 0))
            cmbperiod.Text = My.Settings.FinancialPeriod
            LoadEmpRegNo()
            LoadSelectedRecord()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region