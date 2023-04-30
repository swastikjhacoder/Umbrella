#Region "Imports..."
Imports ESAR_Controls.UIControls.ComboBox
Imports System.Data.SqlClient

#End Region
#Region "frmAccountingManagement..."
Public Class frmAccountingManagement
#Region "Declaration..."
    Private DGVAccount As New DataGridView()
    Private BCODE As String = ""
    Private TT As String = ""
    Private TotalPaid As Decimal = 0.0
    Private i As Integer = 0
    Private AccountExist As Boolean = False
    Private DepositExist As Boolean = False
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        BCODE = Indx.LoadBankDepositID()
        Dim var As String
        var = CodeIncrement(BCODE)
        Me.txtdepositid.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("BD:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        SplitContainer4.SplitterDistance = 260
        SplitContainer4.SplitterWidth = 5
        lnkaddaccount.SetBounds(613, 0, 167, 20)
        lblbalance.SetBounds(113, 192, 32, 13)
        Label1.SetBounds(10, 86, 92, 13)
        Label2.SetBounds(10, 113, 55, 13)
        Label3.SetBounds(10, 141, 67, 13)
        Label4.SetBounds(10, 168, 57, 13)
        Label5.SetBounds(10, 192, 57, 13)
        Label6.SetBounds(6, 181, 136, 13)
        Label7.SetBounds(10, 59, 39, 13)
        Label8.SetBounds(10, 32, 73, 13)

        cmbaccount.SetBounds(116, 165, 131, 21)
        cmbaccounttype.SetBounds(148, 178, 137, 21)
        cmbdate.SetBounds(116, 56, 131, 21)
        cmbpayvia.SetBounds(116, 110, 131, 22)

        txtamount.SetBounds(116, 83, 131, 21)
        txtbankaccountno.SetBounds(10, 151, 470, 21)
        txtbankaddress.SetBounds(10, 98, 470, 21)
        txtbankbranch.SetBounds(10, 71, 470, 21)
        txtbankname.SetBounds(10, 44, 470, 21)
        txtbranchcode.SetBounds(10, 123, 470, 21)
        txtcheckno.SetBounds(116, 138, 131, 21)
        txtdepositid.SetBounds(116, 29, 131, 21)
        txtelectransfer.SetBounds(10, 229, 470, 21)
        txtmicrcode.SetBounds(10, 204, 470, 21)
        txtpayeename.SetBounds(10, 17, 470, 21)
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
            AccName = DGVAccount.Rows(k).Cells(1).Value.ToString()
            AccBal = CDec(DGVAccount.Rows(k).Cells(2).Value.ToString())
            cmbaccount.Text = AccID
            lblbalance.Text = AccBal
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadAccountDetails()
        Try
            Dim i As Integer = 0
            dgviewaccounttypes.Rows.Clear()
            cmd.CommandText = "select Type,AccountID,AccountName,AccountBalance from Accounts where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewaccounttypes.Rows.Add()
                dgviewaccounttypes.Rows(i).Cells(0).Value = dr("Type").ToString()
                dgviewaccounttypes.Rows(i).Cells(1).Value = dr("AccountID").ToString()
                dgviewaccounttypes.Rows(i).Cells(2).Value = dr("AccountName").ToString()
                Dim bal As Decimal = CDec(dr("AccountBalance").ToString())
                dgviewaccounttypes.Rows(i).Cells(3).Value = FormatNumber(bal.ToString())
                i = i + 1
            End While
            dr.Close()
            dgviewaccounttypes.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub

    Private Function LoadMonthlyFees(ByVal StId As String) As Decimal
        Try
            cmd.CommandText = "select course from StudentRegistration where stuid='" & StId & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim course As String = dr("course").ToString()
            dr.Close()
            Dim dt As Date = CDate(UmbrellaSystemDate)
            Dim month As Integer = dt.Month
            Dim year As Integer = dt.Year
            cmd.CommandText = "select tuition,payvia from StudentRegistration where course='" & course & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim tuition As String = dr("tuition").ToString()
            cmbpayvia.Text = dr("payvia").ToString()
            dr.Close()
            Dim amt As Decimal = 0.0
            If tuition = "No" Then
                cmd.CommandText = "select sum(Fees) from CourseTermFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Course='" & course & "'"
                Dim totalamount As Decimal = cmd.ExecuteScalar()
                Dim TFees As String = "Tuitions Fee:"
                cmd.CommandText = "select Fees from CourseTermFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Course='" & course & "' and Terms='" & TFees & "'"
                Dim tuitionfees As Decimal = cmd.ExecuteScalar
                amt = totalamount - tuitionfees
            Else
                cmd.CommandText = "select sum(Fees) from CourseTermFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Course='" & course & "'"
                amt = cmd.ExecuteScalar()
            End If

            Dim exst As Boolean = False
            cmd.CommandText = "select discount from StudentDiscount where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and year=" & year & " and course='" & course & "' and stuid='" & StId & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                exst = True
            Else
                exst = False
            End If
            dr.Close()
            Dim disccharge As Decimal = 0.0
            If exst = True Then
                cmd.CommandText = "select discount from StudentDiscount where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and year=" & year & " and course='" & course & "' and stuid='" & StId & "'"
                disccharge = cmd.ExecuteScalar
            Else
                disccharge = 0.0
            End If

            Dim LibFees As String = "Library Caution Fee:"
            cmd.CommandText = "select Fees from CourseTermFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Course='" & course & "' and Terms='" & LibFees & "'"
            Dim libraryfees As Decimal = cmd.ExecuteScalar

            cmd.CommandText = "select sum(Fees) from CourseTermFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Course='" & course & "'"
            Dim totamount As Decimal = cmd.ExecuteScalar()

            Dim TuiFees As String = "Tuitions Fee:"
            cmd.CommandText = "select Fees from CourseTermFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Course='" & course & "' and Terms='" & TuiFees & "'"
            Dim tuitifees As Decimal = cmd.ExecuteScalar

            cmd.CommandText = "select ForMonth from CourseTermFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Course='" & course & "'"
            Dim ForMonth As Decimal = cmd.ExecuteScalar

            Dim mfees As Decimal = amt / ForMonth
            Dim librfees As Decimal = libraryfees / ForMonth
            Dim monthlyrs As Decimal = Decimal.Round(mfees, 2, MidpointRounding.AwayFromZero)
            Return monthlyrs
        Catch ex As Exception
            dr.Close()
        End Try
    End Function

    Private Sub CheckMonthlyFees(ByVal stid As String, ByVal stname As String)
        Try
            Dim dte As Date = CDate(UmbrellaSystemDate)
            Dim mm As Integer = dte.Month
            Dim yy As Integer = dte.Year
            cmd.CommandText = "select regno,name from MonthlyFees where regno='" & stid & "' and month=" & mm & " and year=" & yy & " and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                dr.Close()
            Else
                dr.Close()
                dgviewowemoney.Rows.Add()
                dgviewowemoney.Rows(i).Cells(0).Value = stid
                dgviewowemoney.Rows(i).Cells(1).Value = stname
                dgviewowemoney.Rows(i).Cells(2).Value = "Monthly Fees"
                Dim amt As Decimal = LoadMonthlyFees(stid)
                dgviewowemoney.Rows(i).Cells(3).Value = FormatNumber(amt.ToString())
                i = i + 1
            End If
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub OweMoney()
        Try
            Dim paid As String = "No"
            dgviewowemoney.Rows.Clear()
            cmd.CommandText = "select invoiceno,customername,totalamount from SalesInvoice where paid='" & paid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewowemoney.Rows.Add()
                dgviewowemoney.Rows(i).Cells(0).Value = dr("invoiceno").ToString()
                dgviewowemoney.Rows(i).Cells(1).Value = dr("customername").ToString()
                dgviewowemoney.Rows(i).Cells(2).Value = "Sales Invoice"
                Dim amt As Decimal = CDec(dr("totalamount").ToString())
                dgviewowemoney.Rows(i).Cells(3).Value = FormatNumber(amt.ToString())
                i = i + 1
            End While
            dr.Close()

            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("select * from StudentRegistration where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'", conn)
            da.Fill(dt)
            For Each dr As DataRow In dt.Rows
                CheckMonthlyFees(dr("stuid").ToString(), dr("name").ToString())
            Next
            dgviewowemoney.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub MoneyToPay()
        Try
            Dim i As Integer = 0
            Dim paid As String = "No"
            dgviewmoneytopay.Rows.Clear()
            cmd.CommandText = "select purchaseid,vendorname,totalamount from Purchase where paid='" & paid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewmoneytopay.Rows.Add()
                dgviewmoneytopay.Rows(i).Cells(0).Value = dr("purchaseid").ToString()
                dgviewmoneytopay.Rows(i).Cells(1).Value = dr("vendorname").ToString()
                dgviewmoneytopay.Rows(i).Cells(2).Value = "Purchase"
                Dim amt As Decimal = CDec(dr("totalamount").ToString())
                dgviewmoneytopay.Rows(i).Cells(3).Value = FormatNumber(amt.ToString())
                i = i + 1
            End While
            dr.Close()
            dgviewmoneytopay.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadSelectedBankDeposit()
        Try
            cmd.CommandText = "select depositid,date,amount,payvia,checkno,account,payeename,bankname,branchname,branchaddress,branchcode,bankaccountno,accounttype,micrcode,electransfer from BankDeposit where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and depositid='" & depositid & "' and date='" & depositdate & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                txtdepositid.Text = dr("depositid").ToString()
                cmbdate.Text = dr("date").ToString()
                txtamount.Text = dr("amount").ToString()
                cmbpayvia.Text = dr("payvia").ToString()
                txtcheckno.Text = dr("checkno").ToString()
                cmbaccount.Text = dr("account").ToString()
                txtpayeename.Text = dr("payeename").ToString()
                txtbankname.Text = dr("bankname").ToString()
                txtbankbranch.Text = dr("branchname").ToString()
                txtbankaddress.Text = dr("branchaddress").ToString()
                txtbranchcode.Text = dr("branchcode").ToString()
                txtbankaccountno.Text = dr("bankaccountno").ToString()
                cmbaccounttype.Text = dr("accounttype").ToString()
                txtmicrcode.Text = dr("micrcode").ToString()
                txtelectransfer.Text = dr("electransfer").ToString()
            End If
            dr.Close()
            TotalPaid = CDec(txtamount.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddRecord()
        Try
            Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                cmd.CommandText = "delete from Accounts where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                dr.Close()
                For i As Integer = 0 To dgviewaccounttypes.Rows.Count - 1
                    Dim AccType As String = dgviewaccounttypes.Rows(i).Cells(0).Value.ToString()
                    Dim AccID As String = dgviewaccounttypes.Rows(i).Cells(1).Value.ToString()
                    Dim AccName As String = dgviewaccounttypes.Rows(i).Cells(2).Value.ToString()
                    Dim AccBal As Decimal = CDec(dgviewaccounttypes.Rows(i).Cells(3).Value.ToString())
                    CheckAccountID(AccID)
                    If AccountExist = False Then
                        cmd.CommandText = "insert into Accounts(InsID,InsName,Period,Type,AccountID,AccountName,AccountBalance) values ('" & My.Settings.LastOpenedInstituteID & "','" & My.Settings.LastOpenedInstitute & "','" & My.Settings.Period & "','" & AccType & "','" & AccID & "','" & AccName & "'," & AccBal & ")"
                        dr = cmd.ExecuteReader
                        dr.Close()
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Account id already exist." + Environment.NewLine + "Please enter a new account id.", "Umbrella - Duplicate Value", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            txtamount.Focus()
                        End If
                    End If
                Next
                Dim result3 As DialogResult = MessageBox.Show("Record added successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If result3 = Windows.Forms.DialogResult.OK Then
                    txtamount.Focus()
                End If
                If txtamount.Text.Trim() <> "" Then
                    Dim result1 As DialogResult = MessageBox.Show("Want to add bank deposit also!!!", "Umbrella - Missing Value", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result1 = Windows.Forms.DialogResult.Yes Then
                        If cmbpayvia.Text.Trim() = "" Then
                            Dim result2 As DialogResult = MessageBox.Show("Please enter/select pay via.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result2 = Windows.Forms.DialogResult.OK Then
                                cmbpayvia.Focus()
                            End If
                        ElseIf cmbaccount.Text.Trim() = "" Then
                            Dim result2 As DialogResult = MessageBox.Show("Please enter/select account.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result2 = Windows.Forms.DialogResult.OK Then
                                cmbaccount.Focus()
                            End If
                        ElseIf txtpayeename.Text.Trim() = "" Then
                            Dim result2 As DialogResult = MessageBox.Show("Please enter payee name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result2 = Windows.Forms.DialogResult.OK Then
                                txtpayeename.Focus()
                            End If
                        ElseIf txtbankaccountno.Text.Trim() = "" Then
                            Dim result2 As DialogResult = MessageBox.Show("Please enter bank account no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result2 = Windows.Forms.DialogResult.OK Then
                                txtbankaccountno.Focus()
                            End If
                        ElseIf txtbankaddress.Text.Trim() = "" Then
                            Dim result2 As DialogResult = MessageBox.Show("Please enter date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result2 = Windows.Forms.DialogResult.OK Then
                                txtbankaddress.Focus()
                            End If
                        ElseIf txtbankbranch.Text.Trim() = "" Then
                            Dim result2 As DialogResult = MessageBox.Show("Please enter date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result2 = Windows.Forms.DialogResult.OK Then
                                txtbankbranch.Focus()
                            End If
                        ElseIf txtbankname.Text.Trim() = "" Then
                            Dim result2 As DialogResult = MessageBox.Show("Please enter bank name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result2 = Windows.Forms.DialogResult.OK Then
                                txtbankname.Focus()
                            End If
                        ElseIf txtdepositid.Text.Trim() = "" Then
                            Dim result2 As DialogResult = MessageBox.Show("Please enter deposit id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result2 = Windows.Forms.DialogResult.OK Then
                                txtdepositid.Focus()
                            End If
                        ElseIf cmbdate.Text.Trim() = "" Then
                            Dim result2 As DialogResult = MessageBox.Show("Please enter/select date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result2 = Windows.Forms.DialogResult.OK Then
                                cmbdate.Focus()
                            End If
                        Else
                            CheckBankDeposit()
                            If DepositExist = False Then
                                Dim cls As New cBankDeposit()
                                cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtdepositid.Text, cmbdate.Text, CDec(txtamount.Text), cmbpayvia.Text, txtcheckno.Text, cmbaccount.Text, txtpayeename.Text, txtbankname.Text, txtbankbranch.Text, txtbankaddress.Text, txtbranchcode.Text, txtbankaccountno.Text, cmbaccounttype.Text, txtmicrcode.Text, txtelectransfer.Text)
                                If cls.AddBankDepositOk = True Then
                                    cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & CDec(txtamount.Text) & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & cmbaccount.Text & "'"
                                    dr = cmd.ExecuteReader
                                    dr.Close()
                                    Dim result4 As DialogResult = MessageBox.Show("Record added successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    If result4 = Windows.Forms.DialogResult.OK Then
                                        txtamount.Focus()
                                    End If
                                End If
                            Else
                                Dim result4 As DialogResult = MessageBox.Show("Deposit id is already exist." + Environment.NewLine + "Please enter a new deposit id", "Umbrella - Duplicate Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                If result4 = Windows.Forms.DialogResult.OK Then
                                    txtdepositid.Focus()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                cmd.CommandText = "delete from Accounts where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                dr.Close()
                For i As Integer = 0 To dgviewaccounttypes.Rows.Count - 1
                    Dim AccType As String = dgviewaccounttypes.Rows(i).Cells(0).Value.ToString()
                    Dim AccID As String = dgviewaccounttypes.Rows(i).Cells(1).Value.ToString()
                    Dim AccName As String = dgviewaccounttypes.Rows(i).Cells(2).Value.ToString()
                    Dim AccBal As Decimal = CDec(dgviewaccounttypes.Rows(i).Cells(3).Value.ToString())
                    cmd.CommandText = "insert into Accounts(InsID,InsName,Period,Type,AccountID,AccountName,AccountBalance) values ('" & My.Settings.LastOpenedInstituteID & "','" & My.Settings.LastOpenedInstitute & "','" & My.Settings.Period & "','" & AccType & "','" & AccID & "','" & AccName & "'," & AccBal & ")"
                    dr = cmd.ExecuteReader
                    dr.Close()
                Next
                Dim result3 As DialogResult = MessageBox.Show("Record added successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If result3 = Windows.Forms.DialogResult.OK Then
                    txtamount.Focus()
                End If
                If txtamount.Text.Trim() <> "" Then
                    Dim result1 As DialogResult = MessageBox.Show("Want to add bank deposit also!!!", "Umbrella - Missing Value", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result1 = Windows.Forms.DialogResult.Yes Then
                        If cmbpayvia.Text.Trim() = "" Then
                            Dim result2 As DialogResult = MessageBox.Show("Please enter/select pay via.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result2 = Windows.Forms.DialogResult.OK Then
                                cmbpayvia.Focus()
                            End If
                        ElseIf cmbaccount.Text.Trim() = "" Then
                            Dim result2 As DialogResult = MessageBox.Show("Please enter/select account.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result2 = Windows.Forms.DialogResult.OK Then
                                cmbaccount.Focus()
                            End If
                        ElseIf txtpayeename.Text.Trim() = "" Then
                            Dim result2 As DialogResult = MessageBox.Show("Please enter payee name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result2 = Windows.Forms.DialogResult.OK Then
                                txtpayeename.Focus()
                            End If
                        ElseIf txtbankaccountno.Text.Trim() = "" Then
                            Dim result2 As DialogResult = MessageBox.Show("Please enter bank account no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result2 = Windows.Forms.DialogResult.OK Then
                                txtbankaccountno.Focus()
                            End If
                        ElseIf txtbankaddress.Text.Trim() = "" Then
                            Dim result2 As DialogResult = MessageBox.Show("Please enter date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result2 = Windows.Forms.DialogResult.OK Then
                                txtbankaddress.Focus()
                            End If
                        ElseIf txtbankbranch.Text.Trim() = "" Then
                            Dim result2 As DialogResult = MessageBox.Show("Please enter date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result2 = Windows.Forms.DialogResult.OK Then
                                txtbankbranch.Focus()
                            End If
                        ElseIf txtbankname.Text.Trim() = "" Then
                            Dim result2 As DialogResult = MessageBox.Show("Please enter bank name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result2 = Windows.Forms.DialogResult.OK Then
                                txtbankname.Focus()
                            End If
                        ElseIf txtdepositid.Text.Trim() = "" Then
                            Dim result2 As DialogResult = MessageBox.Show("Please enter deposit id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result2 = Windows.Forms.DialogResult.OK Then
                                txtdepositid.Focus()
                            End If
                        ElseIf cmbdate.Text.Trim() = "" Then
                            Dim result2 As DialogResult = MessageBox.Show("Please enter/select date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result2 = Windows.Forms.DialogResult.OK Then
                                cmbdate.Focus()
                            End If
                        Else
                            cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & TotalPaid & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & cmbaccount.Text & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                            Dim cls As New cBankDeposit()
                            cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtdepositid.Text, cmbdate.Text, CDec(txtamount.Text), cmbpayvia.Text, txtcheckno.Text, cmbaccount.Text, txtpayeename.Text, txtbankname.Text, txtbankbranch.Text, txtbankaddress.Text, txtbranchcode.Text, txtbankaccountno.Text, cmbaccounttype.Text, txtmicrcode.Text, txtelectransfer.Text)
                            If cls.UpdateBankDepositOk = True Then
                                cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & CDec(txtamount.Text) & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & cmbaccount.Text & "'"
                                dr = cmd.ExecuteReader
                                dr.Close()
                                Dim result4 As DialogResult = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                If result4 = Windows.Forms.DialogResult.OK Then
                                    txtamount.Focus()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Missing Value", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                If cmbpayvia.Text.Trim() = "" Then
                    Dim result2 As DialogResult = MessageBox.Show("Please enter/select pay via.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    If result2 = Windows.Forms.DialogResult.OK Then
                        cmbpayvia.Focus()
                    End If
                ElseIf cmbaccount.Text.Trim() = "" Then
                    Dim result2 As DialogResult = MessageBox.Show("Please enter/select account.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    If result2 = Windows.Forms.DialogResult.OK Then
                        cmbaccount.Focus()
                    End If
                ElseIf txtpayeename.Text.Trim() = "" Then
                    Dim result2 As DialogResult = MessageBox.Show("Please enter payee name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    If result2 = Windows.Forms.DialogResult.OK Then
                        txtpayeename.Focus()
                    End If
                ElseIf txtbankaccountno.Text.Trim() = "" Then
                    Dim result2 As DialogResult = MessageBox.Show("Please enter bank account no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    If result2 = Windows.Forms.DialogResult.OK Then
                        txtbankaccountno.Focus()
                    End If
                ElseIf txtbankaddress.Text.Trim() = "" Then
                    Dim result2 As DialogResult = MessageBox.Show("Please enter date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    If result2 = Windows.Forms.DialogResult.OK Then
                        txtbankaddress.Focus()
                    End If
                ElseIf txtbankbranch.Text.Trim() = "" Then
                    Dim result2 As DialogResult = MessageBox.Show("Please enter date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    If result2 = Windows.Forms.DialogResult.OK Then
                        txtbankbranch.Focus()
                    End If
                ElseIf txtbankname.Text.Trim() = "" Then
                    Dim result2 As DialogResult = MessageBox.Show("Please enter bank name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    If result2 = Windows.Forms.DialogResult.OK Then
                        txtbankname.Focus()
                    End If
                ElseIf txtdepositid.Text.Trim() = "" Then
                    Dim result2 As DialogResult = MessageBox.Show("Please enter deposit id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    If result2 = Windows.Forms.DialogResult.OK Then
                        txtdepositid.Focus()
                    End If
                ElseIf cmbdate.Text.Trim() = "" Then
                    Dim result2 As DialogResult = MessageBox.Show("Please enter/select date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    If result2 = Windows.Forms.DialogResult.OK Then
                        cmbdate.Focus()
                    End If
                Else
                    Dim cls As New cBankDeposit()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtdepositid.Text, cmbdate.Text)
                    If cls.DeleteBankDepositOk = True Then
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & TotalPaid & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & cmbaccount.Text & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        Dim result4 As DialogResult = MessageBox.Show("Record deleted successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result4 = Windows.Forms.DialogResult.OK Then
                            ResetForm()
                            ETabControl1.SelectTab(TabPage2)
                            txtamount.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetForm()
        Try
            updatebankdeposit = False
            GetCode()
            cmbaccount.Text = ""
            cmbaccounttype.Text = ""
            cmbdate.Text = UmbrellaSystemDate
            cmbpayvia.Text = ""
            Label3.Visible = False
            txtcheckno.Visible = False
            lblbalance.Text = "0.00"
            txtamount.Text = ""
            txtbankaccountno.Text = ""
            txtbankaddress.Text = ""
            txtbankbranch.Text = ""
            txtbankname.Text = ""
            txtbranchcode.Text = ""
            txtcheckno.Text = ""
            txtelectransfer.Text = ""
            txtmicrcode.Text = ""
            txtpayeename.Text = ""
            ETabControl1.SelectTab(TabPage1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckAccountID(ByVal acc As String)
        Try
            cmd.CommandText = "select * from Accounts where AccountID='" & acc & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                AccountExist = True
            Else
                AccountExist = False
            End If
            dr.Close()
        Catch ex As Exception
            AccountExist = False
            dr.Close()
        End Try
    End Sub

    Private Sub CheckBankDeposit()
        Try
            cmd.CommandText = "select * from BankDeposit where depositid='" & txtdepositid.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                DepositExist = True
            Else
                DepositExist = False
            End If
            dr.Close()
        Catch ex As Exception
            DepositExist = False
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmAccountingManagement_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updatebankdeposit = False Then
            ControlSetBound()
            cmbdate.Text = UmbrellaSystemDate
            cmbpayvia.Items.Add(New ComboBoxIconItem("Cash", 0))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Check", 1))
            GetCode()
            LoadAccounts()
            LoadAccountDetails()
            OweMoney()
            MoneyToPay()
        Else
            ControlSetBound()
            ETabControl1.SelectTab(TabPage2)
            cmbpayvia.Items.Add(New ComboBoxIconItem("Cash", 0))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Check", 1))
            LoadAccounts()
            LoadAccountDetails()
            OweMoney()
            MoneyToPay()
            LoadSelectedBankDeposit()
        End If
        If USaccounting = "View Only" Then
            dgviewaccounttypes.Enabled = False
            dgviewmoneytopay.Enabled = False
            dgviewowemoney.Enabled = False
            lnkaddaccount.Enabled = False
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
        End If
        If USbankinginfo = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbaccount.Enabled = False
            cmbaccounttype.Enabled = False
            cmbdate.Enabled = False
            cmbpayvia.Enabled = False
            txtamount.ReadOnly = True
            txtbankaccountno.ReadOnly = True
            txtbankaddress.ReadOnly = True
            txtbankbranch.ReadOnly = True
            txtbankname.ReadOnly = True
            txtbranchcode.ReadOnly = True
            txtcheckno.ReadOnly = True
            txtdepositid.ReadOnly = True
            txtelectransfer.ReadOnly = True
            txtmicrcode.ReadOnly = True
            txtpayeename.ReadOnly = True
        ElseIf USbankinginfo = "No Access" Then
            ETabControl1.TabPages.Remove(TabPage2)
        End If
    End Sub
#End Region
#Region "Attributes..."
    Private Sub txtdepositid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdepositid.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            cmbdate.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            ETabControl1.SelectTab(TabPage1)
        End If
    End Sub

    Private Sub cmbdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtamount.Focus()
        End If
    End Sub

    Private Sub txtamount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtamount.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbpayvia.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbdate.Focus()
        End If
    End Sub

    Private Sub cmbpayvia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbpayvia.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbpayvia.Text = "Check" Then
                txtcheckno.Focus()
            Else
                cmbaccount.Focus()
            End If
        End If
    End Sub

    Private Sub cmbpayvia_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbpayvia.TextChanged
        If cmbpayvia.Text = "Check" Then
            Label3.Visible = True
            txtcheckno.Visible = True
        Else
            Label3.Visible = False
            txtcheckno.Visible = False
        End If
    End Sub

    Private Sub txtcheckno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcheckno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbaccount.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbpayvia.Focus()
        End If
    End Sub

    Private Sub cmbaccount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbaccount.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpayeename.Focus()
        End If
    End Sub

    Private Sub txtpayeename_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpayeename.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtbankname.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbaccount.Focus()
        End If
    End Sub

    Private Sub txtbankname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbankname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtbankbranch.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtpayeename.Focus()
        End If
    End Sub

    Private Sub txtbankbranch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbankbranch.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtbankaddress.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtbankname.Focus()
        End If
    End Sub

    Private Sub txtbankaddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbankaddress.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtbranchcode.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtbankbranch.Focus()
        End If
    End Sub

    Private Sub txtbranchcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbranchcode.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtbankaccountno.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtbankaddress.Focus()
        End If
    End Sub

    Private Sub txtbankaccountno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbankaccountno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbaccounttype.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtbranchcode.Focus()
        End If
    End Sub

    Private Sub cmbaccounttype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbaccounttype.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtmicrcode.Focus()
        End If
    End Sub

    Private Sub txtmicrcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmicrcode.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtelectransfer.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbaccounttype.Focus()
        End If
    End Sub

    Private Sub txtelectransfer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtelectransfer.KeyDown
        If e.KeyCode = Keys.Up Then
            txtmicrcode.Focus()
        End If
    End Sub

    Private Sub lnkaddaccount_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkaddaccount.LinkClicked
        dgviewaccounttypes.Rows.Add()
        dgviewaccounttypes.ClearSelection()
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatebankdeposit = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatebankdeposit = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatebankdeposit = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updatebankdeposit = False Then
            ControlSetBound()
            cmbdate.Text = UmbrellaSystemDate
            cmbpayvia.Items.Add(New ComboBoxIconItem("Cash", 0))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Check", 1))
            GetCode()
            LoadAccounts()
            LoadAccountDetails()
            OweMoney()
            MoneyToPay()
        Else
            ControlSetBound()
            ETabControl1.SelectTab(TabPage2)
            cmbpayvia.Items.Add(New ComboBoxIconItem("Cash", 0))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Check", 1))
            LoadAccounts()
            LoadAccountDetails()
            OweMoney()
            MoneyToPay()
            LoadSelectedBankDeposit()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region