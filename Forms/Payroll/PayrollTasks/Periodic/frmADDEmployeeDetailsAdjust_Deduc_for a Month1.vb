#Region "Class frmADDEmployeeDetailsAdjust_Deduc_for_a_Month..."
Public Class frmADDEmployeeDetailsAdjust_Deduc_for_a_Month
#Region "Declarations..."
    Private DGVEmpRegNo As New DataGridView()
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label3.SetBounds(20, 61, 68, 13)
        label1.SetBounds(20, 34, 92, 13)
        label2.SetBounds(281, 34, 37, 13)
        lbldesignation.SetBounds(20, 88, 79, 13)
        lblempname.SetBounds(20, 115, 45, 13)

        nudyear.SetBounds(333, 32, 67, 21)

        cmbmonth.SetBounds(118, 31, 157, 21)
        cmbemployee.SetBounds(118, 58, 282, 21)

        txtdesignation.SetBounds(118, 85, 282, 21)
        txtname.SetBounds(118, 112, 282, 21)
    End Sub

    Private Sub LoadDataGrid1()
        Try
            dgviewsubscriptions.Rows(0).Cells(0).Value = "Conveyance Alw."
            dgviewsubscriptions.Rows(0).Cells(0).Style.BackColor = Color.SteelBlue
            dgviewsubscriptions.Rows(0).Cells(0).Style.ForeColor = Color.White
            dgviewsubscriptions.Rows(0).Cells(0).Style.SelectionBackColor = Color.SteelBlue
            dgviewsubscriptions.Rows(0).Cells(0).Style.SelectionForeColor = Color.White
            dgviewsubscriptions.Rows(0).Cells(0).ReadOnly = True
            dgviewsubscriptions.Rows(1).Cells(0).Value = "Handicapped Alw."
            dgviewsubscriptions.Rows(1).Cells(0).Style.BackColor = Color.SteelBlue
            dgviewsubscriptions.Rows(1).Cells(0).Style.ForeColor = Color.White
            dgviewsubscriptions.Rows(1).Cells(0).Style.SelectionBackColor = Color.SteelBlue
            dgviewsubscriptions.Rows(1).Cells(0).Style.SelectionForeColor = Color.White
            dgviewsubscriptions.Rows(1).Cells(0).ReadOnly = True
            dgviewsubscriptions.Rows(2).Cells(0).Value = "Washing Alw."
            dgviewsubscriptions.Rows(2).Cells(0).Style.BackColor = Color.SteelBlue
            dgviewsubscriptions.Rows(2).Cells(0).Style.ForeColor = Color.White
            dgviewsubscriptions.Rows(2).Cells(0).Style.SelectionBackColor = Color.SteelBlue
            dgviewsubscriptions.Rows(2).Cells(0).Style.SelectionForeColor = Color.White
            dgviewsubscriptions.Rows(2).Cells(0).ReadOnly = True
            dgviewsubscriptions.Rows(3).Cells(0).Value = "PF Deductions"
            dgviewsubscriptions.Rows(3).Cells(0).Style.BackColor = Color.SteelBlue
            dgviewsubscriptions.Rows(3).Cells(0).Style.ForeColor = Color.White
            dgviewsubscriptions.Rows(3).Cells(0).Style.SelectionBackColor = Color.SteelBlue
            dgviewsubscriptions.Rows(3).Cells(0).Style.SelectionForeColor = Color.White
            dgviewsubscriptions.Rows(3).Cells(0).ReadOnly = True
            dgviewsubscriptions.Rows(4).Cells(0).Value = "Special Pay"
            dgviewsubscriptions.Rows(4).Cells(0).Style.BackColor = Color.SteelBlue
            dgviewsubscriptions.Rows(4).Cells(0).Style.ForeColor = Color.White
            dgviewsubscriptions.Rows(4).Cells(0).Style.SelectionBackColor = Color.SteelBlue
            dgviewsubscriptions.Rows(4).Cells(0).Style.SelectionForeColor = Color.White
            dgviewsubscriptions.Rows(4).Cells(0).ReadOnly = True
            dgviewsubscriptions.Rows(5).Cells(0).Value = "G.S.L.I. Deductions"
            dgviewsubscriptions.Rows(5).Cells(0).Style.BackColor = Color.SteelBlue
            dgviewsubscriptions.Rows(5).Cells(0).Style.ForeColor = Color.White
            dgviewsubscriptions.Rows(5).Cells(0).Style.SelectionBackColor = Color.SteelBlue
            dgviewsubscriptions.Rows(5).Cells(0).Style.SelectionForeColor = Color.White
            dgviewsubscriptions.Rows(5).Cells(0).ReadOnly = True
            dgviewsubscriptions.Rows(6).Cells(0).Value = "House Rent"
            dgviewsubscriptions.Rows(6).Cells(0).Style.BackColor = Color.SteelBlue
            dgviewsubscriptions.Rows(6).Cells(0).Style.ForeColor = Color.White
            dgviewsubscriptions.Rows(6).Cells(0).Style.SelectionBackColor = Color.SteelBlue
            dgviewsubscriptions.Rows(6).Cells(0).Style.SelectionForeColor = Color.White
            dgviewsubscriptions.Rows(6).Cells(0).ReadOnly = True
            Dim j As Integer
            For i = 4 To 6
                For j = 2 To 2
                    dgviewsubscriptions.Rows(i).Cells(j).Style.BackColor = Color.Gray
                    dgviewsubscriptions.Rows(i).Cells(j).ReadOnly = True
                    dgviewsubscriptions.Rows(i).Cells(j).Style.SelectionBackColor = Color.Gray
                Next
            Next
            For i = 0 To 3
                For j = 1 To 2
                    dgviewsubscriptions.Rows(i).Cells(j).ReadOnly = False
                    dgviewsubscriptions.Rows(i).Cells(j).Value = "0.00"
                    dgviewsubscriptions.Rows(i).Cells(j).Style.Alignment = DataGridViewContentAlignment.MiddleRight
                Next
            Next
            For i = 4 To 6
                For j = 1 To 1
                    dgviewsubscriptions.Rows(i).Cells(j).ReadOnly = False
                    dgviewsubscriptions.Rows(i).Cells(j).Value = "0.00"
                    dgviewsubscriptions.Rows(i).Cells(j).Style.Alignment = DataGridViewContentAlignment.MiddleRight
                Next
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadDataGrid2()
        Try
            dgviewadjustments.Rows(0).Cells(0).Value = "Basic Adjustments"
            dgviewadjustments.Rows(0).Cells(0).Style.BackColor = Color.SteelBlue
            dgviewadjustments.Rows(0).Cells(0).Style.ForeColor = Color.White
            dgviewadjustments.Rows(0).Cells(0).Style.SelectionBackColor = Color.SteelBlue
            dgviewadjustments.Rows(0).Cells(0).Style.SelectionForeColor = Color.White
            dgviewadjustments.Rows(0).Cells(0).ReadOnly = True
            dgviewadjustments.Rows(1).Cells(0).Value = "D.A. Adjustments"
            dgviewadjustments.Rows(1).Cells(0).Style.BackColor = Color.SteelBlue
            dgviewadjustments.Rows(1).Cells(0).Style.ForeColor = Color.White
            dgviewadjustments.Rows(1).Cells(0).Style.SelectionBackColor = Color.SteelBlue
            dgviewadjustments.Rows(1).Cells(0).Style.SelectionForeColor = Color.White
            dgviewadjustments.Rows(1).Cells(0).ReadOnly = True
            dgviewadjustments.Rows(2).Cells(0).Value = "H.R.A. Adjustments"
            dgviewadjustments.Rows(2).Cells(0).Style.BackColor = Color.SteelBlue
            dgviewadjustments.Rows(2).Cells(0).Style.ForeColor = Color.White
            dgviewadjustments.Rows(2).Cells(0).Style.SelectionBackColor = Color.SteelBlue
            dgviewadjustments.Rows(2).Cells(0).Style.SelectionForeColor = Color.White
            dgviewadjustments.Rows(2).Cells(0).ReadOnly = True
            dgviewadjustments.Rows(3).Cells(0).Value = "Other Adjustments"
            dgviewadjustments.Rows(3).Cells(0).Style.BackColor = Color.SteelBlue
            dgviewadjustments.Rows(3).Cells(0).Style.ForeColor = Color.White
            dgviewadjustments.Rows(3).Cells(0).Style.SelectionBackColor = Color.SteelBlue
            dgviewadjustments.Rows(3).Cells(0).Style.SelectionForeColor = Color.White
            dgviewadjustments.Rows(3).Cells(0).ReadOnly = True
            dgviewadjustments.Rows(4).Cells(0).Value = "C.C.S. Contributions"
            dgviewadjustments.Rows(4).Cells(0).Style.BackColor = Color.SteelBlue
            dgviewadjustments.Rows(4).Cells(0).Style.ForeColor = Color.White
            dgviewadjustments.Rows(4).Cells(0).Style.SelectionBackColor = Color.SteelBlue
            dgviewadjustments.Rows(4).Cells(0).Style.SelectionForeColor = Color.White
            dgviewadjustments.Rows(4).Cells(0).ReadOnly = True
            dgviewadjustments.Rows(5).Cells(0).Value = "Income Tax"
            dgviewadjustments.Rows(5).Cells(0).Style.BackColor = Color.SteelBlue
            dgviewadjustments.Rows(5).Cells(0).Style.ForeColor = Color.White
            dgviewadjustments.Rows(5).Cells(0).Style.SelectionBackColor = Color.SteelBlue
            dgviewadjustments.Rows(5).Cells(0).Style.SelectionForeColor = Color.White
            dgviewadjustments.Rows(5).Cells(0).ReadOnly = True
            dgviewadjustments.Rows(6).Cells(0).Value = "Salary Savings (L.I.C.)"
            dgviewadjustments.Rows(6).Cells(0).Style.BackColor = Color.SteelBlue
            dgviewadjustments.Rows(6).Cells(0).Style.ForeColor = Color.White
            dgviewadjustments.Rows(6).Cells(0).Style.SelectionBackColor = Color.SteelBlue
            dgviewadjustments.Rows(6).Cells(0).Style.SelectionForeColor = Color.White
            dgviewadjustments.Rows(6).Cells(0).ReadOnly = True
            Dim i As Integer
            Dim j As Integer
            For i = 0 To 6
                For j = 1 To 1
                    dgviewadjustments.Rows(i).Cells(j).Value = "0.00"
                    dgviewadjustments.Rows(i).Cells(j).Style.Alignment = DataGridViewContentAlignment.MiddleRight
                Next
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadDataGrid3()
        Try
            dgviewdeductions.Rows(0).Cells(0).Value = "P.F. Advance Recovery"
            dgviewdeductions.Rows(0).Cells(0).Style.BackColor = Color.SteelBlue
            dgviewdeductions.Rows(0).Cells(0).Style.ForeColor = Color.White
            dgviewdeductions.Rows(0).Cells(0).Style.SelectionBackColor = Color.SteelBlue
            dgviewdeductions.Rows(0).Cells(0).Style.SelectionForeColor = Color.White
            dgviewdeductions.Rows(0).Cells(0).ReadOnly = True
            dgviewdeductions.Rows(1).Cells(0).Value = "C.C.S. Loan"
            dgviewdeductions.Rows(1).Cells(0).Style.BackColor = Color.SteelBlue
            dgviewdeductions.Rows(1).Cells(0).Style.ForeColor = Color.White
            dgviewdeductions.Rows(1).Cells(0).Style.SelectionBackColor = Color.SteelBlue
            dgviewdeductions.Rows(1).Cells(0).Style.SelectionForeColor = Color.White
            dgviewdeductions.Rows(1).Cells(0).ReadOnly = True
            dgviewdeductions.Rows(2).Cells(0).Value = "Other Bank Loan"
            dgviewdeductions.Rows(2).Cells(0).Style.BackColor = Color.SteelBlue
            dgviewdeductions.Rows(2).Cells(0).Style.ForeColor = Color.White
            dgviewdeductions.Rows(2).Cells(0).Style.SelectionBackColor = Color.SteelBlue
            dgviewdeductions.Rows(2).Cells(0).Style.SelectionForeColor = Color.White
            dgviewdeductions.Rows(2).Cells(0).ReadOnly = True
            dgviewdeductions.Rows(3).Cells(0).Value = "Festival Advance"
            dgviewdeductions.Rows(3).Cells(0).Style.BackColor = Color.SteelBlue
            dgviewdeductions.Rows(3).Cells(0).Style.ForeColor = Color.White
            dgviewdeductions.Rows(3).Cells(0).Style.SelectionBackColor = Color.SteelBlue
            dgviewdeductions.Rows(3).Cells(0).Style.SelectionForeColor = Color.White
            dgviewdeductions.Rows(3).Cells(0).ReadOnly = True
            dgviewdeductions.Rows(4).Cells(0).Value = "C.C.S.P.O. - 1"
            dgviewdeductions.Rows(4).Cells(0).Style.BackColor = Color.SteelBlue
            dgviewdeductions.Rows(4).Cells(0).Style.ForeColor = Color.White
            dgviewdeductions.Rows(4).Cells(0).Style.SelectionBackColor = Color.SteelBlue
            dgviewdeductions.Rows(4).Cells(0).Style.SelectionForeColor = Color.White
            dgviewdeductions.Rows(4).Cells(0).ReadOnly = True
            dgviewdeductions.Rows(5).Cells(0).Value = "C.C.S.P.O. - 2"
            dgviewdeductions.Rows(5).Cells(0).Style.BackColor = Color.SteelBlue
            dgviewdeductions.Rows(5).Cells(0).Style.ForeColor = Color.White
            dgviewdeductions.Rows(5).Cells(0).Style.SelectionBackColor = Color.SteelBlue
            dgviewdeductions.Rows(5).Cells(0).Style.SelectionForeColor = Color.White
            dgviewdeductions.Rows(5).Cells(0).ReadOnly = True
            dgviewdeductions.Rows(6).Cells(0).Value = "Bank Loan"
            dgviewdeductions.Rows(6).Cells(0).Style.BackColor = Color.SteelBlue
            dgviewdeductions.Rows(6).Cells(0).Style.ForeColor = Color.White
            dgviewdeductions.Rows(6).Cells(0).Style.SelectionBackColor = Color.SteelBlue
            dgviewdeductions.Rows(6).Cells(0).Style.SelectionForeColor = Color.White
            dgviewdeductions.Rows(6).Cells(0).ReadOnly = True
            dgviewdeductions.Rows(7).Cells(0).Value = "P.P.F."
            dgviewdeductions.Rows(7).Cells(0).Style.BackColor = Color.SteelBlue
            dgviewdeductions.Rows(7).Cells(0).Style.ForeColor = Color.White
            dgviewdeductions.Rows(7).Cells(0).Style.SelectionBackColor = Color.SteelBlue
            dgviewdeductions.Rows(7).Cells(0).Style.SelectionForeColor = Color.White
            dgviewdeductions.Rows(7).Cells(0).ReadOnly = True
            Dim i As Integer
            Dim j As Integer
            For i = 0 To 7
                For j = 1 To 1
                    dgviewdeductions.Rows(i).Cells(j).Value = "0.00"
                    dgviewdeductions.Rows(i).Cells(j).Style.Alignment = DataGridViewContentAlignment.MiddleRight
                Next
            Next
            For i = 0 To 7
                For j = 2 To 3
                    dgviewdeductions.Rows(i).Cells(j).Value = "0.00"
                    dgviewdeductions.Rows(i).Cells(j).ReadOnly = True
                    dgviewdeductions.Rows(i).Cells(j).Style.BackColor = Color.Gray
                    dgviewdeductions.Rows(i).Cells(j).Style.ForeColor = Color.White
                    dgviewdeductions.Rows(i).Cells(j).Style.SelectionBackColor = Color.Gray
                    dgviewdeductions.Rows(i).Cells(j).Style.SelectionForeColor = Color.White
                    dgviewdeductions.Rows(i).Cells(j).Style.Alignment = DataGridViewContentAlignment.MiddleRight
                Next
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadDataGrid4()
        Try
            dgviewleaves.Rows(0).Cells(0).Value = "Leave Without Pay"
            dgviewleaves.Rows(0).Cells(0).Style.BackColor = Color.SteelBlue
            dgviewleaves.Rows(0).Cells(0).Style.ForeColor = Color.White
            dgviewleaves.Rows(0).Cells(0).Style.SelectionBackColor = Color.SteelBlue
            dgviewleaves.Rows(0).Cells(0).Style.SelectionForeColor = Color.White
            dgviewleaves.Rows(0).Cells(0).ReadOnly = True
            dgviewleaves.Rows(0).Cells(1).Value = "0.00"
            dgviewleaves.Rows(0).Cells(2).Value = "0.00"
            dgviewleaves.Rows(0).Cells(1).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgviewleaves.Rows(0).Cells(2).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadDataGridValues()
        Try
            dgviewadjustments.Rows.Clear()
            dgviewdeductions.Rows.Clear()
            dgviewleaves.Rows.Clear()
            dgviewsubscriptions.Rows.Clear()
            Dim i As Integer
            For i = 0 To 6
                dgviewsubscriptions.Rows.Add()
                dgviewadjustments.Rows.Add()
            Next
            For i = 0 To 7
                dgviewdeductions.Rows.Add()
            Next
            dgviewleaves.Rows.Add()
            LoadDataGrid1()
            LoadDataGrid2()
            LoadDataGrid3()
            LoadDataGrid4()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub LaadMonth()
        Try
            Dim mm As Integer = DateTime.Now.Month
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
        Catch ex As Exception

        End Try
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

            cmbemployee.AddDataGridView(DGVEmpRegNo, False)
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
            EmpDesignation = DGVEmpRegNo.Rows(k).Cells(2).Value.ToString()
            cmbemployee.Text = EmpRegNo
            txtdesignation.Text = EmpDesignation
            txtname.Text = EmpName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetForm()
        updateadjustmentsdeductions = False
        cmbemployee.Text = ""
        txtdesignation.Text = ""
        txtname.Text = ""
        chkpaywithheld.Checked = False
        chkstopincrement.Checked = False
        ControlSetBound()
        LoadDataGridValues()
        Dim yy As Integer = Int32.Parse(DateTime.Now.Year.ToString())
        Me.nudyear.Minimum = yy - 15
        Me.nudyear.Maximum = yy + 25
        Me.nudyear.Value = yy
        LaadMonth()
        cmbmonth.Focus()
    End Sub

    Private Sub AddRecord()
        Try
            If cmbemployee.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select employee regno.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbemployee.Focus()
                End If
            ElseIf txtdesignation.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter designation.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtdesignation.Focus()
                End If
            ElseIf txtname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter employee name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtname.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim InsID As String = My.Settings.LastOpenedInstituteID
                    Dim InsName As String = My.Settings.LastOpenedInstitute
                    Dim Periodd As String = My.Settings.Period
                    Dim month As String = cmbmonth.Text
                    Dim year As Integer = CInt(nudyear.Value.ToString())
                    Dim regno As String = cmbemployee.Text
                    Dim designation As String = txtdesignation.Text
                    Dim name As String = txtname.Text
                    Dim thismonth As Integer = CInt(dgviewleaves.Rows(0).Cells(1).Value.ToString())
                    Dim lastmonth As Integer = CInt(dgviewleaves.Rows(0).Cells(2).Value.ToString())
                    Dim basicadjust As Decimal = CDec(dgviewadjustments.Rows(0).Cells(1).Value.ToString())
                    Dim daadjust As Decimal = CDec(dgviewadjustments.Rows(1).Cells(1).Value.ToString())
                    Dim hraadjust As Decimal = CDec(dgviewadjustments.Rows(2).Cells(1).Value.ToString())
                    Dim otheradjust As Decimal = CDec(dgviewadjustments.Rows(3).Cells(1).Value.ToString())
                    Dim ccsadjust As Decimal = CDec(dgviewadjustments.Rows(4).Cells(1).Value.ToString())
                    Dim incometaxadjust As Decimal = CDec(dgviewadjustments.Rows(5).Cells(1).Value.ToString())
                    Dim salaryadjust As Decimal = CDec(dgviewadjustments.Rows(6).Cells(1).Value.ToString())
                    Dim conveyancealw As Decimal = CDec(dgviewsubscriptions.Rows(0).Cells(1).Value.ToString())
                    Dim handicappedalw As Decimal = CDec(dgviewsubscriptions.Rows(1).Cells(1).Value.ToString())
                    Dim washingalw As Decimal = CDec(dgviewsubscriptions.Rows(2).Cells(1).Value.ToString())
                    Dim pfdeduction As Decimal = CDec(dgviewsubscriptions.Rows(3).Cells(1).Value.ToString())
                    Dim conveyancealwrs As Decimal = CDec(dgviewsubscriptions.Rows(0).Cells(2).Value.ToString())
                    Dim handicappedalwrs As Decimal = CDec(dgviewsubscriptions.Rows(1).Cells(2).Value.ToString())
                    Dim washingalwrs As Decimal = CDec(dgviewsubscriptions.Rows(2).Cells(2).Value.ToString())
                    Dim pfdeductionrs As Decimal = CDec(dgviewsubscriptions.Rows(3).Cells(2).Value.ToString())
                    Dim specialpay As Decimal = CDec(dgviewsubscriptions.Rows(4).Cells(1).Value.ToString())
                    Dim gslideduction As Decimal = CDec(dgviewsubscriptions.Rows(5).Cells(1).Value.ToString())
                    Dim houserent As Decimal = CDec(dgviewsubscriptions.Rows(6).Cells(1).Value.ToString())
                    Dim pfadvancerecovery As Decimal = CDec(dgviewdeductions.Rows(0).Cells(1).Value.ToString())
                    Dim ccsloan As Decimal = CDec(dgviewdeductions.Rows(1).Cells(1).Value.ToString())
                    Dim otherbankloan As Decimal = CDec(dgviewdeductions.Rows(2).Cells(1).Value.ToString())
                    Dim festivaladvance As Decimal = CDec(dgviewdeductions.Rows(3).Cells(1).Value.ToString())
                    Dim ccspo1loan As Decimal = CDec(dgviewdeductions.Rows(4).Cells(1).Value.ToString())
                    Dim ccspo2loan As Decimal = CDec(dgviewdeductions.Rows(5).Cells(1).Value.ToString())
                    Dim bankloan As Decimal = CDec(dgviewdeductions.Rows(6).Cells(1).Value.ToString())
                    Dim ppfloan As Decimal = CDec(dgviewdeductions.Rows(7).Cells(1).Value.ToString())
                    Dim stopincrement As String
                    Dim paywithheld As String
                    If chkstopincrement.Checked = True Then
                        stopincrement = "Yes"
                    Else
                        stopincrement = "No"
                    End If
                    If chkpaywithheld.Checked = True Then
                        paywithheld = "Yes"
                    Else
                        paywithheld = "No"
                    End If
                    Dim cls As New cAdjustmentDeductions()
                    cls.AddRecord(InsID, InsName, Periodd, My.Settings.FinancialPeriod, month, year, regno, designation, name, thismonth, lastmonth, basicadjust, daadjust, hraadjust, otheradjust, ccsadjust, incometaxadjust, salaryadjust, conveyancealw, handicappedalw, washingalw, pfdeduction, conveyancealwrs, handicappedalwrs, washingalwrs, pfdeductionrs, specialpay, gslideduction, houserent, pfadvancerecovery, ccsloan, otherbankloan, festivaladvance, ccspo1loan, ccspo2loan, bankloan, ppfloan, stopincrement, paywithheld)
                    If cls.AddRecordOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record added successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = DialogResult.OK Then
                            cmbemployee.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If cmbemployee.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select employee regno.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbemployee.Focus()
                End If
            ElseIf txtdesignation.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter designation.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtdesignation.Focus()
                End If
            ElseIf txtname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter employee name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtname.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim InsID As String = My.Settings.LastOpenedInstituteID
                    Dim InsName As String = My.Settings.LastOpenedInstitute
                    Dim Periodd As String = My.Settings.Period
                    Dim month As String = cmbmonth.Text
                    Dim year As Integer = CInt(nudyear.Value.ToString())
                    Dim regno As String = cmbemployee.Text
                    Dim designation As String = txtdesignation.Text
                    Dim name As String = txtname.Text
                    Dim thismonth As Integer = CInt(dgviewleaves.Rows(0).Cells(1).Value.ToString())
                    Dim lastmonth As Integer = CInt(dgviewleaves.Rows(0).Cells(2).Value.ToString())
                    Dim basicadjust As Decimal = CDec(dgviewadjustments.Rows(0).Cells(1).Value.ToString())
                    Dim daadjust As Decimal = CDec(dgviewadjustments.Rows(1).Cells(1).Value.ToString())
                    Dim hraadjust As Decimal = CDec(dgviewadjustments.Rows(2).Cells(1).Value.ToString())
                    Dim otheradjust As Decimal = CDec(dgviewadjustments.Rows(3).Cells(1).Value.ToString())
                    Dim ccsadjust As Decimal = CDec(dgviewadjustments.Rows(4).Cells(1).Value.ToString())
                    Dim incometaxadjust As Decimal = CDec(dgviewadjustments.Rows(5).Cells(1).Value.ToString())
                    Dim salaryadjust As Decimal = CDec(dgviewadjustments.Rows(6).Cells(1).Value.ToString())
                    Dim conveyancealw As Decimal = CDec(dgviewsubscriptions.Rows(0).Cells(1).Value.ToString())
                    Dim handicappedalw As Decimal = CDec(dgviewsubscriptions.Rows(1).Cells(1).Value.ToString())
                    Dim washingalw As Decimal = CDec(dgviewsubscriptions.Rows(2).Cells(1).Value.ToString())
                    Dim pfdeduction As Decimal = CDec(dgviewsubscriptions.Rows(3).Cells(1).Value.ToString())
                    Dim conveyancealwrs As Decimal = CDec(dgviewsubscriptions.Rows(0).Cells(2).Value.ToString())
                    Dim handicappedalwrs As Decimal = CDec(dgviewsubscriptions.Rows(1).Cells(2).Value.ToString())
                    Dim washingalwrs As Decimal = CDec(dgviewsubscriptions.Rows(2).Cells(2).Value.ToString())
                    Dim pfdeductionrs As Decimal = CDec(dgviewsubscriptions.Rows(3).Cells(2).Value.ToString())
                    Dim specialpay As Decimal = CDec(dgviewsubscriptions.Rows(4).Cells(1).Value.ToString())
                    Dim gslideduction As Decimal = CDec(dgviewsubscriptions.Rows(5).Cells(1).Value.ToString())
                    Dim houserent As Decimal = CDec(dgviewsubscriptions.Rows(6).Cells(1).Value.ToString())
                    Dim pfadvancerecovery As Decimal = CDec(dgviewdeductions.Rows(0).Cells(1).Value.ToString())
                    Dim ccsloan As Decimal = CDec(dgviewdeductions.Rows(1).Cells(1).Value.ToString())
                    Dim otherbankloan As Decimal = CDec(dgviewdeductions.Rows(2).Cells(1).Value.ToString())
                    Dim festivaladvance As Decimal = CDec(dgviewdeductions.Rows(3).Cells(1).Value.ToString())
                    Dim ccspo1loan As Decimal = CDec(dgviewdeductions.Rows(4).Cells(1).Value.ToString())
                    Dim ccspo2loan As Decimal = CDec(dgviewdeductions.Rows(5).Cells(1).Value.ToString())
                    Dim bankloan As Decimal = CDec(dgviewdeductions.Rows(6).Cells(1).Value.ToString())
                    Dim ppfloan As Decimal = CDec(dgviewdeductions.Rows(7).Cells(1).Value.ToString())
                    Dim stopincrement As String
                    Dim paywithheld As String
                    If chkstopincrement.Checked = True Then
                        stopincrement = "Yes"
                    Else
                        stopincrement = "No"
                    End If
                    If chkpaywithheld.Checked = True Then
                        paywithheld = "Yes"
                    Else
                        paywithheld = "No"
                    End If
                    Dim cls As New cAdjustmentDeductions()
                    cls.UpdateRecord(InsID, InsName, Periodd, My.Settings.FinancialPeriod, month, year, regno, designation, name, thismonth, lastmonth, basicadjust, daadjust, hraadjust, otheradjust, ccsadjust, incometaxadjust, salaryadjust, conveyancealw, handicappedalw, washingalw, pfdeduction, conveyancealwrs, handicappedalwrs, washingalwrs, pfdeductionrs, specialpay, gslideduction, houserent, pfadvancerecovery, ccsloan, otherbankloan, festivaladvance, ccspo1loan, ccspo2loan, bankloan, ppfloan, stopincrement, paywithheld)
                    If cls.UpdateRecordOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = DialogResult.OK Then
                            cmbemployee.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If cmbemployee.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select employee regno.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbemployee.Focus()
                End If
            ElseIf txtdesignation.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter designation.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtdesignation.Focus()
                End If
            ElseIf txtname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter employee name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtname.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim InsID As String = My.Settings.LastOpenedInstituteID
                    Dim InsName As String = My.Settings.LastOpenedInstitute
                    Dim Periodd As String = My.Settings.Period
                    Dim month As String = cmbmonth.Text
                    Dim year As Integer = CInt(nudyear.Value.ToString())
                    Dim regno As String = cmbemployee.Text
                    Dim designation As String = txtdesignation.Text
                    Dim name As String = txtname.Text
                    Dim cls As New cAdjustmentDeductions()
                    cls.DeleteRecord(InsID, InsName, Periodd, My.Settings.FinancialPeriod, month, year, regno, designation, name)
                    If cls.DeleteRecordOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record deleted successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = DialogResult.OK Then
                            cmbemployee.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedRecord()
        Try
            cmd.CommandText = "select * from AdjustmentDeductions where month='" & adjustmentmonth & "' and year=" & adjustmentyear & " and regno='" & EmpRegNo & "' and designation='" & designame & "' and name='" & EmpName & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                cmbmonth.Text = dr("month").ToString()
                nudyear.Value = CInt(dr("year").ToString())
                cmbemployee.Text = dr("regno").ToString()
                txtdesignation.Text = dr("designation").ToString()
                txtname.Text = dr("name").ToString()
                Dim thismonth As Integer = CInt(dr("thismonth").ToString())
                Dim lastmonth As Integer = CInt(dr("lastmonth").ToString())
                Dim basicadjust As Decimal = CDec(dr("basicadjust").ToString())
                Dim daadjust As Decimal = CDec(dr("daadjust").ToString())
                Dim hraadjust As Decimal = CDec(dr("hraadjust").ToString())
                Dim otheradjust As Decimal = CDec(dr("otheradjust").ToString())
                Dim ccsadjust As Decimal = CDec(dr("ccsadjust").ToString())
                Dim incometaxadjust As Decimal = CDec(dr("incometaxadjust").ToString())
                Dim salaryadjust As Decimal = CDec(dr("salaryadjust").ToString())
                Dim conveyancealw As Decimal = CDec(dr("conveyancealw").ToString())
                Dim handicappedalw As Decimal = CDec(dr("handicappedalw").ToString())
                Dim washingalw As Decimal = CDec(dr("washingalw").ToString())
                Dim pfdeduction As Decimal = CDec(dr("pfdeduction").ToString())
                Dim conveyancealwrs As Decimal = CDec(dr("conveyancealwrs").ToString())
                Dim handicappedalwrs As Decimal = CDec(dr("handicappedalwrs").ToString())
                Dim washingalwrs As Decimal = CDec(dr("washingalwrs").ToString())
                Dim pfdeductionrs As Decimal = CDec(dr("pfdeductionrs").ToString())
                Dim specialpay As Decimal = CDec(dr("specialpay").ToString())
                Dim gslideduction As Decimal = CDec(dr("gslideduction").ToString())
                Dim houserent As Decimal = CDec(dr("houserent").ToString())
                Dim pfadvancerecovery As Decimal = CDec(dr("pfadvancerecovery").ToString())
                Dim ccsloan As Decimal = CDec(dr("ccsloan").ToString())
                Dim otherbankloan As Decimal = CDec(dr("otherbankloan").ToString())
                Dim festivaladvance As Decimal = CDec(dr("festivaladvance").ToString())
                Dim ccspo1loan As Decimal = CDec(dr("ccspo1loan").ToString())
                Dim ccspo2loan As Decimal = CDec(dr("ccspo2loan").ToString())
                Dim bankloan As Decimal = CDec(dr("bankloan").ToString())
                Dim ppfloan As Decimal = CDec(dr("ppfloan").ToString())
                dgviewleaves.Rows(0).Cells(1).Value = FormatNumber(thismonth.ToString())
                dgviewleaves.Rows(0).Cells(2).Value = FormatNumber(lastmonth.ToString())
                dgviewadjustments.Rows(0).Cells(1).Value = FormatNumber(basicadjust.ToString())
                dgviewadjustments.Rows(1).Cells(1).Value = FormatNumber(daadjust.ToString())
                dgviewadjustments.Rows(2).Cells(1).Value = FormatNumber(hraadjust.ToString())
                dgviewadjustments.Rows(3).Cells(1).Value = FormatNumber(otheradjust.ToString())
                dgviewadjustments.Rows(4).Cells(1).Value = FormatNumber(ccsadjust.ToString())
                dgviewadjustments.Rows(5).Cells(1).Value = FormatNumber(incometaxadjust.ToString())
                dgviewadjustments.Rows(6).Cells(1).Value = FormatNumber(salaryadjust.ToString())
                dgviewsubscriptions.Rows(0).Cells(1).Value = FormatNumber(conveyancealw.ToString())
                dgviewsubscriptions.Rows(1).Cells(1).Value = FormatNumber(handicappedalw.ToString())
                dgviewsubscriptions.Rows(2).Cells(1).Value = FormatNumber(washingalw.ToString())
                dgviewsubscriptions.Rows(3).Cells(1).Value = FormatNumber(pfdeduction.ToString())
                dgviewsubscriptions.Rows(0).Cells(2).Value = FormatNumber(conveyancealwrs.ToString())
                dgviewsubscriptions.Rows(1).Cells(2).Value = FormatNumber(handicappedalwrs.ToString())
                dgviewsubscriptions.Rows(2).Cells(2).Value = FormatNumber(washingalwrs.ToString())
                dgviewsubscriptions.Rows(3).Cells(2).Value = FormatNumber(pfdeductionrs.ToString())
                dgviewsubscriptions.Rows(4).Cells(1).Value = FormatNumber(specialpay.ToString())
                dgviewsubscriptions.Rows(5).Cells(1).Value = FormatNumber(gslideduction.ToString())
                dgviewsubscriptions.Rows(6).Cells(1).Value = FormatNumber(houserent.ToString())
                dgviewdeductions.Rows(0).Cells(1).Value = FormatNumber(pfadvancerecovery.ToString())
                dgviewdeductions.Rows(1).Cells(1).Value = FormatNumber(ccsloan.ToString())
                dgviewdeductions.Rows(2).Cells(1).Value = FormatNumber(otherbankloan.ToString())
                dgviewdeductions.Rows(3).Cells(1).Value = FormatNumber(festivaladvance.ToString())
                dgviewdeductions.Rows(4).Cells(1).Value = FormatNumber(ccspo1loan.ToString())
                dgviewdeductions.Rows(5).Cells(1).Value = FormatNumber(ccspo2loan.ToString())
                dgviewdeductions.Rows(6).Cells(1).Value = FormatNumber(bankloan.ToString())
                dgviewdeductions.Rows(7).Cells(1).Value = FormatNumber(ppfloan.ToString())
                If dr("stopincrement").ToString() = "Yes" Then
                    chkstopincrement.Checked = True
                Else
                    chkstopincrement.Checked = False
                End If
                If dr("paywithheld").ToString() = "Yes" Then
                    chkpaywithheld.Checked = True
                Else
                    chkpaywithheld.Checked = False
                End If
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmADDEmployeeDetailsAdjust_Deduc_for_a_Month_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updateadjustmentsdeductions = False Then
            ControlSetBound()
            LoadDataGridValues()
            LoadEmpRegNo()
            Dim yy As Integer = Int32.Parse(DateTime.Now.Year.ToString())
            Me.nudyear.Minimum = yy - 15
            Me.nudyear.Maximum = yy + 25
            Me.nudyear.Value = yy
            LaadMonth()
            cmbmonth.Focus()
        Else
            ControlSetBound()
            LoadDataGridValues()
            LoadEmpRegNo()
            Dim yy As Integer = Int32.Parse(DateTime.Now.Year.ToString())
            Me.nudyear.Minimum = yy - 15
            Me.nudyear.Maximum = yy + 25
            Me.nudyear.Value = yy
            LaadMonth()
            cmbmonth.Focus()
            LoadSelectedRecord()
        End If
        If USpayrollperiodic = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbemployee.Enabled = False
            cmbmonth.Enabled = False
            chkpaywithheld.Enabled = False
            chkstopincrement.Enabled = False
            nudyear.Enabled = False
            dgviewadjustments.Enabled = False
            dgviewdeductions.Enabled = False
            dgviewleaves.Enabled = False
            dgviewsubscriptions.Enabled = False
            nudyear.Enabled = False
        End If
    End Sub
#End Region
#Region "Attributes..."
    Private Sub cmbmonth_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbmonth.KeyDown
        If e.KeyCode = Keys.Enter Then
            nudyear.Focus()
        End If
    End Sub

    Private Sub ComboBoxKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbmonth.KeyPress, cmbemployee.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub

    Private Sub nudyear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudyear.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbemployee.Focus()
        End If
    End Sub

    Private Sub cmbemployee_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbemployee.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtdesignation.Focus()
        End If
    End Sub

    Private Sub txtdesignation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdesignation.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtname.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbemployee.Focus()
        End If
    End Sub

    Private Sub txtname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            dgviewleaves.Focus()
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
        If updateadjustmentsdeductions = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updateadjustmentsdeductions = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updateadjustmentsdeductions = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updateadjustmentsdeductions = False Then
            ControlSetBound()
            LoadDataGridValues()
            LoadEmpRegNo()
            Dim yy As Integer = Int32.Parse(DateTime.Now.Year.ToString())
            Me.nudyear.Minimum = yy - 15
            Me.nudyear.Maximum = yy + 25
            Me.nudyear.Value = yy
            LaadMonth()
            cmbmonth.Focus()
        Else
            ControlSetBound()
            LoadDataGridValues()
            LoadEmpRegNo()
            Dim yy As Integer = Int32.Parse(DateTime.Now.Year.ToString())
            Me.nudyear.Minimum = yy - 15
            Me.nudyear.Maximum = yy + 25
            Me.nudyear.Value = yy
            LaadMonth()
            cmbmonth.Focus()
            LoadSelectedRecord()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "DGViewEvents..."
    Private Sub DGViewCellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgviewadjustments.CellEndEdit, dgviewdeductions.CellEndEdit, dgviewleaves.CellEndEdit, dgviewsubscriptions.CellEndEdit
        Dim x As DataGridView = CType(sender, DataGridView)
        Dim val As Decimal = CDec(x.CurrentCell.Value.ToString())
        x.CurrentCell.Value = FormatNumber(val.ToString())
    End Sub
#End Region
End Class
#End Region