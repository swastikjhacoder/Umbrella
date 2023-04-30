#Region "Imports..."
Imports ESAR_Controls.UIControls.ComboBox
#End Region
#Region "Class frmPFAdvanceWithdrawal..."
Public Class frmPFAdvanceWithdrawal
#Region "Declarations..."
    Private DGVEmpRegNo As New DataGridView()
    Private options As String = ""
    Private advance As Decimal = 0.0
    Private withdrawal As Decimal = 0.0
    Private PFBal As Decimal = 0.0
    Private AmtOk As Boolean = False
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        lblopeningbalance.SetBounds(130, 37, 32, 13)
        Label1.SetBounds(25, 17, 102, 13)
        Label2.SetBounds(25, 43, 45, 13)
        Label3.SetBounds(25, 71, 48, 13)
        Label4.SetBounds(25, 37, 74, 13)
        Label5.SetBounds(25, 67, 46, 13)
        Label6.SetBounds(25, 93, 88, 13)
        Label7.SetBounds(265, 93, 35, 13)

        cmbmonth.SetBounds(132, 64, 265, 21)
        cmboption.SetBounds(132, 90, 127, 21)
        cmbperiod.SetBounds(133, 68, 264, 22)
        cmbregno.SetBounds(133, 14, 126, 21)

        txtamount.SetBounds(310, 91, 87, 21)
        txtname.SetBounds(133, 41, 264, 21)
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
            cmd.CommandText = "select openingbalance from PF where regno='" & regno & "' and name='" & name & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            PFBal = CDec(dr("openingbalance").ToString())
            dr.Close()
            lblopeningbalance.Text = FormatNumber(PFBal.ToString())
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadMonth()
        Dim mm As Integer = Date.Now.Month
        If mm = 1 Then
            cmbmonth.Text = "January"
        ElseIf mm = 2 Then
            cmbmonth.Text = "February"
        ElseIf mm = 3 Then
            cmbmonth.Text = "March"
        ElseIf mm = 4 Then
            cmbmonth.Text = "April"
        ElseIf mm = 5 Then
            cmbmonth.Text = "May"
        ElseIf mm = 6 Then
            cmbmonth.Text = "June"
        ElseIf mm = 7 Then
            cmbmonth.Text = "July"
        ElseIf mm = 8 Then
            cmbmonth.Text = "August"
        ElseIf mm = 9 Then
            cmbmonth.Text = "September"
        ElseIf mm = 10 Then
            cmbmonth.Text = "October"
        ElseIf mm = 11 Then
            cmbmonth.Text = "November"
        ElseIf mm = 12 Then
            cmbmonth.Text = "December"
        End If
    End Sub

    Private Sub ResetForm()
        lblopeningbalance.Text = "0.00"
        rtbparticulars.rtb.Text = ""
        LoadMonth()
        cmboption.Text = ""
        cmbperiod.Text = My.Settings.FinancialPeriod
        cmbregno.Text = ""
        txtamount.Text = ""
        txtname.Text = ""
        updatepfadvwith = False
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
            ElseIf cmbmonth.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select month.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbmonth.Focus()
                End If
            ElseIf cmboption.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select option.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmboption.Focus()
                End If
            ElseIf txtamount.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter amount.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtamount.Focus()
                End If
            ElseIf AmtOk = False Then
                Dim result As DialogResult = MessageBox.Show("Please withdrawal amount." + Environment.NewLine + "Withdrawal amount must be less or equal to PF balance.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtamount.Focus()
                    AmtOk = False
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim cls As New cPFAdvanceWithdrawal()
                    cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, cmbmonth.Text, cmbregno.Text, txtname.Text, CDec(lblopeningbalance.Text), cmboption.Text, CDec(txtamount.Text), rtbparticulars.rtb.Text)
                    If cls.AddRecordOk = True Then
                        If cmboption.Text = "Advance" Then
                            cmd.CommandText = "update PF set openingbalance=openingbalance+" & CDec(txtamount.Text) & " where regno='" & cmbregno.Text & "' and name='" & txtname.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                        ElseIf cmboption.Text = "Withdrawal" Then
                            cmd.CommandText = "update PF set openingbalance=openingbalance-" & CDec(txtamount.Text) & ",outstandingadvance=outstandingadvance+" & CDec(txtamount.Text) & " where regno='" & cmbregno.Text & "' and name='" & txtname.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                        End If
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
            ElseIf cmbmonth.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select month.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbmonth.Focus()
                End If
            ElseIf cmboption.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select option.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmboption.Focus()
                End If
            ElseIf txtamount.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter amount.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtamount.Focus()
                End If
            ElseIf AmtOk = False Then
                Dim result As DialogResult = MessageBox.Show("Please withdrawal amount." + Environment.NewLine + "Withdrawal amount must be less or equal to PF balance.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtamount.Focus()
                    AmtOk = False
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim cls As New cPFAdvanceWithdrawal()
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, cmbmonth.Text, cmbregno.Text, txtname.Text, CDec(lblopeningbalance.Text), cmboption.Text, CDec(txtamount.Text), rtbparticulars.rtb.Text)
                    If cls.UpdateRecordOk = True Then
                        If options = "Advance" Then
                            cmd.CommandText = "update PF set openingbalance=openingbalance-" & advance & " where regno='" & cmbregno.Text & "' and name='" & txtname.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                        ElseIf options = "Withdrawal" Then
                            cmd.CommandText = "update PF set openingbalance=openingbalance+" & withdrawal & ",outstandingadvance=outstandingadvance-" & withdrawal & " where regno='" & cmbregno.Text & "' and name='" & txtname.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                        End If
                        If cmboption.Text = "Advance" Then
                            cmd.CommandText = "update PF set openingbalance=openingbalance+" & CDec(txtamount.Text) & " where regno='" & cmbregno.Text & "' and name='" & txtname.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                        ElseIf cmboption.Text = "Withdrawal" Then
                            cmd.CommandText = "update PF set openingbalance=openingbalance-" & CDec(txtamount.Text) & ",outstandingadvance=outstandingadvance+" & CDec(txtamount.Text) & " where regno='" & cmbregno.Text & "' and name='" & txtname.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                        End If
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
            ElseIf cmbmonth.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select month.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbmonth.Focus()
                End If
            ElseIf cmboption.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select option.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmboption.Focus()
                End If
            ElseIf txtamount.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter amount.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtamount.Focus()
                End If
            ElseIf AmtOk = False Then
                Dim result As DialogResult = MessageBox.Show("Please withdrawal amount." + Environment.NewLine + "Withdrawal amount must be less or equal to PF balance.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtamount.Focus()
                    AmtOk = False
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim cls As New cPFAdvanceWithdrawal()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, cmbmonth.Text, cmbregno.Text, txtname.Text)
                    If cls.DeleteRecordOk = True Then
                        If options = "Advance" Then
                            cmd.CommandText = "update PF set openingbalance=openingbalance-" & advance & " where regno='" & cmbregno.Text & "' and name='" & txtname.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                        ElseIf options = "Withdrawal" Then
                            cmd.CommandText = "update PF set openingbalance=openingbalance+" & withdrawal & ",outstandingadvance=outstandingadvance-" & withdrawal & " where regno='" & cmbregno.Text & "' and name='" & txtname.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                        End If
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
            cmd.CommandText = "select regno,name,openingbalance,month,options,amount,particulars from PFAdvanceWithdrawal where month='" & pfadvwithmonth & "' and regno='" & EmpRegNo & "' and name='" & EmpName & "' and options='" & pfoptions & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read Then
                cmbregno.Text = dr("regno").ToString()
                txtname.Text = dr("name").ToString()
                cmbperiod.Text = My.Settings.FinancialPeriod
                cmbmonth.Text = dr("month").ToString()
                cmboption.Text = dr("options").ToString()
                txtamount.Text = dr("amount").ToString()
                rtbparticulars.rtb.Text = dr("particulars").ToString()
                options = dr("options").ToString()
                If options = "Advance" Then
                    advance = CDec(dr("amount").ToString())
                ElseIf options = "Withdrawal" Then
                    withdrawal = CDec(dr("amount").ToString())
                End If
            End If
            dr.Close()
            LoadBalance(cmbregno.Text, txtname.Text)
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmPFAdvanceWithdrawal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updatepfadvwith = False Then
            ControlSetBound()
            LoadMonth()
            LoadEmpRegNo()
            cmbperiod.Items.Add(New ComboBoxIconItem(My.Settings.FinancialPeriod, 0))
            cmbperiod.Text = My.Settings.FinancialPeriod
        Else
            ControlSetBound()
            LoadMonth()
            LoadEmpRegNo()
            cmbperiod.Items.Add(New ComboBoxIconItem(My.Settings.FinancialPeriod, 0))
            cmbperiod.Text = My.Settings.FinancialPeriod
            LoadSelectedRecord()
        End If
        If USpayrollpf = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbmonth.Enabled = False
            cmboption.Enabled = False
            cmbperiod.Enabled = False
            cmbregno.Enabled = False
            txtamount.ReadOnly = True
            txtname.ReadOnly = True
        End If
    End Sub
#End Region
#Region "Attributes..."
    Private Sub cmbregno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbregno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtname.Focus()
        End If
    End Sub

    Private Sub txtname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbperiod.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbregno.Focus()
        End If
    End Sub

    Private Sub cmbperiod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbperiod.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbmonth.Focus()
        End If
    End Sub

    Private Sub cmbmonth_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbmonth.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmboption.Focus()
        End If
    End Sub

    Private Sub cmboption_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmboption.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtamount.Focus()
        End If
    End Sub

    Private Sub txtamount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtamount.KeyDown
        If e.KeyCode = Keys.Enter Then
            rtbparticulars.rtb.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmboption.Focus()
        End If
    End Sub

    Private Sub txtamount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtamount.LostFocus
        If cmboption.Text <> "" Then
            If txtamount.Text <> "" Then
                If cmbregno.Text <> "" Then
                    If cmboption.Text = "Withdrawal" Then
                        If CDec(txtamount.Text) > PFBal Then
                            Dim result As DialogResult = MessageBox.Show("Please withdrawal amount." + Environment.NewLine + "Withdrawal amount must be less or equal to PF balance.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result = DialogResult.OK Then
                                txtamount.Focus()
                                AmtOk = False
                            End If
                        Else
                            AmtOk = True
                        End If
                    Else
                        AmtOk = True
                    End If
                End If
            End If
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatepfadvwith = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatepfadvwith = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatepfadvwith = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updatepfadvwith = False Then
            ControlSetBound()
            LoadMonth()
            LoadEmpRegNo()
            cmbperiod.Items.Add(New ComboBoxIconItem(My.Settings.FinancialPeriod, 0))
            cmbperiod.Text = My.Settings.FinancialPeriod
        Else
            ControlSetBound()
            LoadMonth()
            LoadEmpRegNo()
            cmbperiod.Items.Add(New ComboBoxIconItem(My.Settings.FinancialPeriod, 0))
            cmbperiod.Text = My.Settings.FinancialPeriod
            LoadSelectedRecord()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region