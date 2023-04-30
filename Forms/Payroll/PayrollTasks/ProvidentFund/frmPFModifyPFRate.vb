﻿#Region "Imports..."
Imports ESAR_Controls.UIControls.ComboBox
#End Region
#Region "Class frmPFModifyPFRate..."
Public Class frmPFModifyPFRate
#Region "Declarations..."
    Private DGVEmpRegNo As New DataGridView()
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(21, 22, 102, 13)
        Label2.SetBounds(21, 48, 45, 13)
        Label3.SetBounds(21, 76, 48, 13)
        Label4.SetBounds(21, 104, 87, 13)
        Label5.SetBounds(192, 104, 100, 13)
        Label6.SetBounds(376, 104, 17, 13)
        Label7.SetBounds(271, 22, 37, 13)

        nudyear.SetBounds(314, 19, 79, 21)

        cmbperiod.SetBounds(129, 73, 264, 22)
        cmbregno.SetBounds(129, 19, 126, 21)

        txtname.SetBounds(129, 46, 264, 21)
        txtrate.SetBounds(129, 101, 57, 21)
        txtrs.SetBounds(298, 101, 72, 21)
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
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetForm()
        updatepfrateindividual = False
        cmbperiod.Text = My.Settings.FinancialPeriod
        cmbregno.Text = ""
        txtname.Text = ""
        txtrate.Text = ""
        txtrs.Text = ""
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
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim rate As Decimal
                    Dim rs As Decimal
                    If txtrate.Text <> "" Then
                        rate = CDec(txtrate.Text)
                    Else
                        rate = 0.0
                    End If
                    If txtrs.Text <> "" Then
                        rs = CDec(txtrs.Text)
                    Else
                        rs = 0.0
                    End If
                    Dim cls As New cPFRateIndividual()
                    cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, CInt(nudyear.Value.ToString()), cmbregno.Text, txtname.Text, rate, rs)
                    If cls.AddRecordOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record added successfully!!!", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = DialogResult.OK Then
                            cmbregno.Focus()
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
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim rate As Decimal
                    Dim rs As Decimal
                    If txtrate.Text <> "" Then
                        rate = CDec(txtrate.Text)
                    Else
                        rate = 0.0
                    End If
                    If txtrs.Text <> "" Then
                        rs = CDec(txtrs.Text)
                    Else
                        rs = 0.0
                    End If
                    Dim cls As New cPFRateIndividual()
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, CInt(nudyear.Value.ToString()), cmbregno.Text, txtname.Text, rate, rs)
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
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim cls As New cPFRateIndividual()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, CInt(nudyear.Value.ToString()), cmbregno.Text, txtname.Text)
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
            cmd.CommandText = "select regno,year,name,rate,amount from PFRateIndividual where regno='" & EmpRegNo & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                cmbregno.Text = dr("regno").ToString()
                nudyear.Value = CInt(dr("year").ToString())
                txtname.Text = dr("name").ToString()
                cmbperiod.Text = My.Settings.FinancialPeriod
                txtrate.Text = dr("rate").ToString()
                txtrs.Text = dr("amount").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmPFModifyPFRate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updatepfrateindividual = False Then
            ControlSetBound()
            cmbperiod.Items.Add(New ComboBoxIconItem(My.Settings.FinancialPeriod, 0))
            cmbperiod.Text = My.Settings.FinancialPeriod
            LoadEmpRegNo()
            nudyear.Maximum = Date.Now.Year
            nudyear.Minimum = Date.Now.Year
            nudyear.Value = Date.Now.Year
        Else
            ControlSetBound()
            cmbperiod.Items.Add(New ComboBoxIconItem(My.Settings.FinancialPeriod, 0))
            cmbperiod.Text = My.Settings.FinancialPeriod
            LoadEmpRegNo()
            nudyear.Maximum = Date.Now.Year
            nudyear.Minimum = Date.Now.Year
            nudyear.Value = Date.Now.Year
            LoadSelectedRecord()
        End If
        If USpayrollpf = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbperiod.Enabled = False
            cmbregno.Enabled = False
            txtname.ReadOnly = True
            txtrate.ReadOnly = True
            txtrs.ReadOnly = True
            nudyear.Enabled = False
        End If
    End Sub
#End Region
#Region "Attributes..."
    Private Sub cmbregno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbregno.KeyDown
        If e.KeyCode = Keys.Enter Then
            nudyear.Focus()
        End If
    End Sub

    Private Sub nudyear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudyear.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtname.Focus()
        End If
    End Sub

    Private Sub txtname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbperiod.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbregno.Focus()
        End If
    End Sub

    Private Sub cmbperiod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbperiod.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtrate.Focus()
        End If
    End Sub

    Private Sub txtrate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtrate.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtrs.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbperiod.Focus()
        End If
    End Sub

    Private Sub txtrs_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtrs.KeyDown
        If e.KeyCode = Keys.Up Then
            txtrate.Focus()
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatepfrateindividual = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatepfrateindividual = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatepfrateindividual = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updatepfrateindividual = False Then
            ControlSetBound()
            cmbperiod.Items.Add(New ComboBoxIconItem(My.Settings.FinancialPeriod, 0))
            cmbperiod.Text = My.Settings.FinancialPeriod
            LoadEmpRegNo()
            nudyear.Maximum = Date.Now.Year
            nudyear.Minimum = Date.Now.Year
            nudyear.Value = Date.Now.Year
        Else
            ControlSetBound()
            cmbperiod.Items.Add(New ComboBoxIconItem(My.Settings.FinancialPeriod, 0))
            cmbperiod.Text = My.Settings.FinancialPeriod
            LoadEmpRegNo()
            nudyear.Maximum = Date.Now.Year
            nudyear.Minimum = Date.Now.Year
            nudyear.Value = Date.Now.Year
            LoadSelectedRecord()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region