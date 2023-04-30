#Region "Class frmPayEmployee..."
Public Class frmPayEmployee
#Region "Declarations..."
    Private DGVRegNo As New DataGridView()
    Private ACODE As String = ""
    Private TT As String = ""
    Private Emp As Boolean = False
    Private HEmp As Boolean = False
    Private PaySlipNoExist As Boolean = False
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        ACODE = Indx.LoadSalaryID()
        Dim var As String
        var = CodeIncrement(ACODE)
        Me.txtsalaryno.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("SAL:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        Label1.SetBounds(17, 22, 68, 13)
        Label2.SetBounds(266, 22, 46, 13)
        Label3.SetBounds(445, 22, 37, 13)
        Label4.SetBounds(556, 22, 80, 13)
        Label5.SetBounds(17, 38, 98, 13)
        Label6.SetBounds(17, 65, 45, 13)
        Label7.SetBounds(17, 92, 79, 13)
        Label8.SetBounds(17, 119, 60, 13)

        btnprint.SetBounds(121, 155, 121, 36)

        cmbdate.SetBounds(642, 19, 121, 21)
        cmbmonth.SetBounds(318, 19, 121, 21)
        cmbregno.SetBounds(121, 35, 121, 21)

        nudyear.SetBounds(488, 20, 60, 21)

        txtdesignation.SetBounds(121, 89, 276, 21)
        txtname.SetBounds(121, 62, 276, 21)
        txtpayinfo.SetBounds(121, 116, 276, 21)
        txtsalaryno.SetBounds(121, 19, 121, 21)
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

    Private Sub LoadRegno()
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
            Dim col4 As New DataGridViewTextBoxColumn()
            With col4
                .Name = "Col4"
                .HeaderText = "Pay Info"
            End With

            With DGVRegNo
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
                AddHandler DGVRegNo.CellClick, AddressOf DGVRegNo_CellClick
            End With

            DGVRegNo.Columns.Clear()
            DGVRegNo.Columns.Add(col1)
            DGVRegNo.Columns.Add(col2)
            DGVRegNo.Columns.Add(col3)
            DGVRegNo.Columns.Add(col4)

            DGVRegNo.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select empid,name,designation,payinfo from Employee where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                DGVRegNo.Rows.Add()
                DGVRegNo.Rows(indx).Cells(0).Value = dr("empid").ToString()
                DGVRegNo.Rows(indx).Cells(1).Value = dr("name").ToString()
                DGVRegNo.Rows(indx).Cells(2).Value = dr("designation").ToString()
                DGVRegNo.Rows(indx).Cells(3).Value = dr("payinfo").ToString()
                indx = indx + 1
            End While
            dr.Close()
            cmd.CommandText = "select empid,name,designation,payinfo from HiredEmployee where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                DGVRegNo.Rows.Add()
                DGVRegNo.Rows(indx).Cells(0).Value = dr("empid").ToString()
                DGVRegNo.Rows(indx).Cells(1).Value = dr("name").ToString()
                DGVRegNo.Rows(indx).Cells(2).Value = dr("designation").ToString()
                DGVRegNo.Rows(indx).Cells(3).Value = dr("payinfo").ToString()
                indx = indx + 1
            End While
            dr.Close()
            DGVRegNo.ClearSelection()

            cmbregno.AddDataGridView(DGVRegNo, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVRegNo_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVRegNo.CurrentRow.Index
            DGVRegNo.Rows(k).Selected = True
            DGVRegNo.CurrentCell = DGVRegNo.Rows(k).Cells(0)
            EmpRegNo = DGVRegNo.Rows(k).Cells(0).Value.ToString()
            EmpName = DGVRegNo.Rows(k).Cells(1).Value.ToString()
            EmpDesignation = DGVRegNo.Rows(k).Cells(2).Value.ToString()
            Dim payinfo As String = DGVRegNo.Rows(k).Cells(3).Value.ToString()
            cmbregno.Text = EmpRegNo
            txtname.Text = EmpName
            txtdesignation.Text = EmpDesignation
            txtpayinfo.Text = payinfo
            LoadSalaryDetails(cmbregno.Text, txtname.Text, txtdesignation.Text, txtpayinfo.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadDataGridValues()
        Try
            dgviewsalary.Rows.Clear()
            For i As Integer = 0 To 9
                dgviewsalary.Rows.Add()
            Next
            dgviewsalary.Rows(0).Cells(0).Value = "Get DA:"
            dgviewsalary.Rows(1).Cells(0).Value = "Get Arrier:"
            dgviewsalary.Rows(2).Cells(0).Value = "Get HRA:"
            dgviewsalary.Rows(3).Cells(0).Value = "Tax:"
            dgviewsalary.Rows(4).Cells(0).Value = "Total Deductions:"
            dgviewsalary.Rows(5).Cells(0).Value = "Total Gain:"
            dgviewsalary.Rows(6).Cells(0).Value = "New Basic:"
            dgviewsalary.Rows(7).Cells(0).Value = "Net Pay:"
            dgviewsalary.Rows(8).Cells(0).Value = "Stop Increment:"
            dgviewsalary.Rows(9).Cells(0).Value = "Pay With Held:"
            For i As Integer = 0 To 9
                dgviewsalary.Rows(i).Cells(0).Style.BackColor = Color.SteelBlue
                dgviewsalary.Rows(i).Cells(0).Style.ForeColor = Color.White
                dgviewsalary.Rows(i).Cells(0).Style.SelectionBackColor = Color.SteelBlue
                dgviewsalary.Rows(i).Cells(0).Style.SelectionForeColor = Color.White
            Next
            dgviewsalary.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckEmployee(ByVal empid As String)
        Try
            cmd.CommandText = "select * from Employee where empid='" & empid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                Emp = True
                HEmp = False
            Else
                Emp = False
                HEmp = False
            End If
            dr.Close()
            cmd.CommandText = "select * from HiredEmployee where empid='" & empid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                HEmp = True
                Emp = False
            Else
                Emp = False
                HEmp = False
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadSelectedEmployee(ByVal empid As String)
        Try
            CheckEmployee(empid)
            If Emp = True Then
                cmd.CommandText = "select name,designation,payinfo from Employee where empid='" & empid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                dr.Read()
                txtdesignation.Text = dr("designation").ToString()
                txtname.Text = dr("name").ToString()
                txtpayinfo.Text = dr("payinfo").ToString()
                dr.Close()
            ElseIf HEmp = True Then
                cmd.CommandText = "select name,designation,payinfo from HiredEmployee where empid='" & empid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                dr.Read()
                txtdesignation.Text = dr("designation").ToString()
                txtname.Text = dr("name").ToString()
                txtpayinfo.Text = dr("payinfo").ToString()
                dr.Close()
            End If
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadSalaryDetails(ByVal empid As String, ByVal name As String, ByVal designation As String, ByVal payinfo As String)
        Try
            cmd.CommandText = "select GetDA,GetArrier,GetHRA,ProfessionTax,TotalDeduction,TotalGain,NewBasic,NetPay,stopincrement,paywithheld from Salary where month='" & cmbmonth.Text & "' and year=" & CInt(nudyear.Value) & " and regno='" & empid & "' and designation='" & designation & "' and name='" & name & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                Dim getda As Decimal = CDec(dr("GetDA").ToString())
                dgviewsalary.Rows(0).Cells(1).Value = FormatNumber(getda.ToString())
                Dim getarrier As Decimal = CDec(dr("GetArrier").ToString())
                dgviewsalary.Rows(1).Cells(1).Value = FormatNumber(getarrier.ToString())
                Dim gethra As Decimal = CDec(dr("GetHRA").ToString())
                dgviewsalary.Rows(2).Cells(1).Value = FormatNumber(gethra.ToString())
                Dim tax As Decimal = CDec(dr("ProfessionTax").ToString())
                dgviewsalary.Rows(3).Cells(1).Value = FormatNumber(tax.ToString())
                Dim deduct As Decimal = CDec(dr("TotalDeduction").ToString())
                dgviewsalary.Rows(4).Cells(1).Value = FormatNumber(deduct.ToString())
                Dim gain As Decimal = CDec(dr("TotalGain").ToString())
                dgviewsalary.Rows(5).Cells(1).Value = FormatNumber(gain.ToString())
                Dim basic As Decimal = CDec(dr("NewBasic").ToString())
                dgviewsalary.Rows(6).Cells(1).Value = FormatNumber(basic.ToString())
                Dim pay As Decimal = CDec(dr("NetPay").ToString())
                dgviewsalary.Rows(7).Cells(1).Value = FormatNumber(pay.ToString())
                dgviewsalary.Rows(8).Cells(1).Value = dr("stopincrement").ToString()
                dgviewsalary.Rows(9).Cells(1).Value = dr("paywithheld").ToString()
            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetForm()
        updatepayemployee = False
        dgviewsalary.Rows.Clear()
        LoadDataGridValues()
        LoadMonth()
        Dim yy As Integer = Date.Now.Year
        nudyear.Maximum = yy + 25
        nudyear.Minimum = yy - 25
        nudyear.Value = yy
        cmbdate.Text = UmbrellaSystemDate
        If PSDAutoID = "Yes" Then
            GetCode()
        Else
            txtsalaryno.Text = ""
        End If
        cmbregno.Text = ""
        txtdesignation.Text = ""
        txtname.Text = ""
        txtpayinfo.Text = ""
        txtsalaryno.Focus()
    End Sub

    Private Sub AddRecord()
        Try
            If txtsalaryno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter pay slip no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtsalaryno.Focus()
                End If
            ElseIf cmbmonth.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select month.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbmonth.Focus()
                End If
            ElseIf cmbdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select salary date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbdate.Focus()
                End If
            ElseIf cmbregno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select employee reg id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbregno.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    CheckPaySlipNo()
                    If PaySlipNoExist = False Then
                        Dim cls As New cPayEmployee()
                        Dim getda As Decimal = CDec(dgviewsalary.Rows(0).Cells(1).Value.ToString())
                        Dim getarrier As Decimal = CDec(dgviewsalary.Rows(1).Cells(1).Value.ToString())
                        Dim gethra As Decimal = CDec(dgviewsalary.Rows(2).Cells(1).Value.ToString())
                        Dim tax As Decimal = CDec(dgviewsalary.Rows(3).Cells(1).Value.ToString())
                        Dim deduct As Decimal = CDec(dgviewsalary.Rows(4).Cells(1).Value.ToString())
                        Dim gain As Decimal = CDec(dgviewsalary.Rows(5).Cells(1).Value.ToString())
                        Dim newbasic As Decimal = CDec(dgviewsalary.Rows(6).Cells(1).Value.ToString())
                        Dim netpay As Decimal = CDec(dgviewsalary.Rows(7).Cells(1).Value.ToString())
                        Dim stopincrement As String = dgviewsalary.Rows(8).Cells(1).Value.ToString()
                        Dim paywithheld As String = dgviewsalary.Rows(9).Cells(1).Value.ToString()
                        cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, txtsalaryno.Text, cmbmonth.Text, CInt(nudyear.Value.ToString()), cmbdate.Text, cmbregno.Text, txtname.Text, txtdesignation.Text, txtpayinfo.Text, getda, getarrier, gethra, tax, deduct, gain, newbasic, netpay, stopincrement, paywithheld)
                        If cls.AddRecordOk = True Then
                            cmd.CommandText = "update Indexx set salaryid=salaryid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                            Dim result1 As DialogResult = MessageBox.Show("Record added successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = DialogResult.OK Then
                                txtsalaryno.Focus()
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Pay slip no already exist." + Environment.NewLine + "Please enter new pay slip no.", "Umbrella - Duplicate Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result1 = DialogResult.OK Then
                            txtsalaryno.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If txtsalaryno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter pay slip no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtsalaryno.Focus()
                End If
            ElseIf cmbmonth.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select month.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbmonth.Focus()
                End If
            ElseIf cmbdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select salary date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbdate.Focus()
                End If
            ElseIf cmbregno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select employee reg id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbregno.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim cls As New cPayEmployee()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, txtsalaryno.Text)
                    If cls.DeleteRecordOk = True Then
                        Dim getda As Decimal = CDec(dgviewsalary.Rows(0).Cells(1).Value.ToString())
                        Dim getarrier As Decimal = CDec(dgviewsalary.Rows(1).Cells(1).Value.ToString())
                        Dim gethra As Decimal = CDec(dgviewsalary.Rows(2).Cells(1).Value.ToString())
                        Dim tax As Decimal = CDec(dgviewsalary.Rows(3).Cells(1).Value.ToString())
                        Dim deduct As Decimal = CDec(dgviewsalary.Rows(4).Cells(1).Value.ToString())
                        Dim gain As Decimal = CDec(dgviewsalary.Rows(5).Cells(1).Value.ToString())
                        Dim newbasic As Decimal = CDec(dgviewsalary.Rows(6).Cells(1).Value.ToString())
                        Dim netpay As Decimal = CDec(dgviewsalary.Rows(7).Cells(1).Value.ToString())
                        Dim stopincrement As String = dgviewsalary.Rows(8).Cells(1).Value.ToString()
                        Dim paywithheld As String = dgviewsalary.Rows(9).Cells(1).Value.ToString()
                        cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, txtsalaryno.Text, cmbmonth.Text, CInt(nudyear.Value.ToString()), cmbdate.Text, cmbregno.Text, txtname.Text, txtdesignation.Text, txtpayinfo.Text, getda, getarrier, gethra, tax, deduct, gain, newbasic, netpay, stopincrement, paywithheld)
                        If cls.AddRecordOk = True Then
                            Dim result1 As DialogResult = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = DialogResult.OK Then
                                txtsalaryno.Focus()
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
            If txtsalaryno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter pay slip no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtsalaryno.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim cls As New cPayEmployee()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, txtsalaryno.Text)
                    If cls.DeleteRecordOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record deleted successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            cmd.CommandText = "select * from PayEmployee where payslipno='" & salaryid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                txtdesignation.Text = dr("designation").ToString()
                txtname.Text = dr("name").ToString()
                txtpayinfo.Text = dr("payinfo").ToString()
                txtsalaryno.Text = dr("payslipno").ToString()
                nudyear.Value = CInt(dr("salaryyear").ToString())
                cmbdate.Text = dr("salarydate").ToString()
                cmbmonth.Text = dr("salarymonth").ToString()
                cmbregno.Text = dr("regno").ToString()
                Dim getda As Decimal = CDec(dr("getda").ToString())
                dgviewsalary.Rows(0).Cells(1).Value = FormatNumber(getda.ToString())
                Dim getarrier As Decimal = CDec(dr("getarrier").ToString())
                dgviewsalary.Rows(1).Cells(1).Value = FormatNumber(getarrier.ToString())
                Dim gethra As Decimal = CDec(dr("gethra").ToString())
                dgviewsalary.Rows(2).Cells(1).Value = FormatNumber(gethra.ToString())
                Dim tax As Decimal = CDec(dr("tax").ToString())
                dgviewsalary.Rows(3).Cells(1).Value = FormatNumber(tax.ToString())
                Dim deduct As Decimal = CDec(dr("deduct").ToString())
                dgviewsalary.Rows(4).Cells(1).Value = FormatNumber(deduct.ToString())
                Dim gain As Decimal = CDec(dr("gain").ToString())
                dgviewsalary.Rows(5).Cells(1).Value = FormatNumber(gain.ToString())
                Dim basic As Decimal = CDec(dr("newbasic").ToString())
                dgviewsalary.Rows(6).Cells(1).Value = FormatNumber(basic.ToString())
                Dim pay As Decimal = CDec(dr("netpay").ToString())
                dgviewsalary.Rows(7).Cells(1).Value = FormatNumber(pay.ToString())
                dgviewsalary.Rows(8).Cells(1).Value = dr("stopincrement").ToString()
                dgviewsalary.Rows(9).Cells(1).Value = dr("paywithheld").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CheckPaySlipNo()
        Try
            cmd.CommandText = "select * from PayEmployee where payslipno='" & txtsalaryno.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                PaySlipNoExist = True
            Else
                PaySlipNoExist = False
            End If
            dr.Close()
        Catch ex As Exception
            PaySlipNoExist = False
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmPayEmployee_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updatepayemployee = False Then
            ControlSetBound()
            LoadMonth()
            LoadRegno()
            LoadDataGridValues()
            Dim yy As Integer = Date.Now.Year
            nudyear.Maximum = yy + 25
            nudyear.Minimum = yy - 25
            nudyear.Value = yy
            cmbdate.Text = UmbrellaSystemDate
            If PSDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadMonth()
            LoadRegno()
            LoadDataGridValues()
            Dim yy As Integer = Date.Now.Year
            nudyear.Maximum = yy + 25
            nudyear.Minimum = yy - 25
            nudyear.Value = yy
            LoadSelectedRecord()
        End If
        If USpayrollperiodic = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            btnprint.Enabled = False
            cmbdate.Enabled = False
            cmbmonth.Enabled = False
            cmbregno.Enabled = False
            txtdesignation.ReadOnly = True
            txtname.ReadOnly = True
            txtpayinfo.ReadOnly = True
            txtsalaryno.ReadOnly = True
            dgviewsalary.Enabled = False
            nudyear.Enabled = False
        End If
    End Sub
#End Region
#Region "Attributes..."
    Private Sub txtsalaryno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsalaryno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbmonth.Focus()
        End If
    End Sub

    Private Sub cmbmonth_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbmonth.KeyDown
        If e.KeyCode = Keys.Enter Then
            nudyear.Focus()
        End If
    End Sub

    Private Sub nudyear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudyear.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbdate.Focus()
        End If
    End Sub

    Private Sub cmbdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbregno.Focus()
        End If
    End Sub

    Private Sub cmbregno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbregno.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbregno.Text.Trim() <> "" Then
                LoadSelectedEmployee(cmbregno.Text)
                LoadSalaryDetails(cmbregno.Text, txtname.Text, txtdesignation.Text, txtpayinfo.Text)
            End If
            txtname.Focus()
        End If
    End Sub

    Private Sub txtname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtdesignation.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbregno.Focus()
        End If
    End Sub

    Private Sub txtdesignation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdesignation.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtpayinfo.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtname.Focus()
        End If
    End Sub

    Private Sub txtpayinfo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpayinfo.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            btnprint.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtdesignation.Focus()
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatepayemployee = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatepayemployee = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatepayemployee = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updatepayemployee = False Then
            ControlSetBound()
            LoadMonth()
            LoadRegno()
            LoadDataGridValues()
            Dim yy As Integer = Date.Now.Year
            nudyear.Maximum = yy + 25
            nudyear.Minimum = yy - 25
            nudyear.Value = yy
            cmbdate.Text = UmbrellaSystemDate
            If PSDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadMonth()
            LoadRegno()
            LoadDataGridValues()
            Dim yy As Integer = Date.Now.Year
            nudyear.Maximum = yy + 25
            nudyear.Minimum = yy - 25
            nudyear.Value = yy
            LoadSelectedRecord()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub

    Private Sub btnprint_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnprint.ClickButtonArea

    End Sub
#End Region
End Class
#End Region