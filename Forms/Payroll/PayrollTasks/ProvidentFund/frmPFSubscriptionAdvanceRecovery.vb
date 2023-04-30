#Region "Imports..."
Imports ESAR_Controls.UIControls.ComboBox
#End Region
#Region "Class frmPFSubscriptionAdvanceRecovery..."
Public Class frmPFSubscriptionAdvanceRecovery
#Region "Declarations..."
    Private DGVEmpRegNo As New DataGridView()
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(23, 17, 102, 13)
        Label2.SetBounds(23, 44, 105, 13)
        Label3.SetBounds(23, 71, 48, 13)
        cmbperiod.SetBounds(134, 68, 339, 22)
        cmbregno.SetBounds(134, 14, 148, 21)
        txtname.SetBounds(134, 41, 339, 21)
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
            LoadSubscriptions(EmpRegNo)
            dgviewsubscriptions.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSubscriptions(ByVal regno As String)
        Try
            dgviewsubscriptions.Rows.Clear()
            Dim i As Integer = 0
            cmd.CommandText = "select month,pfdeduction,pfdeductionrs,pfadvancerecovery from AdjustmentDeductions where regno='" & regno & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewsubscriptions.Rows.Add()
                dgviewsubscriptions.Rows(i).Cells(0).Value = dr("month").ToString()
                Dim rte As Decimal = CDec(dr("pfdeduction").ToString())
                Dim rs As Decimal = CDec(dr("pfdeductionrs").ToString())
                If rte = 0.0 Then
                    dgviewsubscriptions.Rows(i).Cells(3).Value = FormatNumber(rs.ToString())
                Else
                    dgviewsubscriptions.Rows(i).Cells(3).Value = FormatNumber(rte.ToString())
                End If
                Dim rec As Decimal = CDec(dr("pfadvancerecovery").ToString())
                dgviewsubscriptions.Rows(i).Cells(4).Value = FormatNumber(rec.ToString())
                i = i + 1
            End While
            dr.Close()
            cmd.CommandText = "select rate,amount from PFRate where year=" & Date.Now.Year & " and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim rate As Decimal = CDec(dr("rate").ToString())
            Dim amount As Decimal = CDec(dr("rate").ToString())
            dr.Close()
            For row As Integer = 0 To dgviewsubscriptions.Rows.Count - 1
                If rate = 0.0 Then
                    dgviewsubscriptions.Rows(row).Cells(1).Value = FormatNumber(amount.ToString())
                Else
                    dgviewsubscriptions.Rows(row).Cells(1).Value = FormatNumber(rate.ToString())
                End If
            Next
            For indx As Integer = 0 To dgviewsubscriptions.Rows.Count - 1
                Dim mm As String = dgviewsubscriptions.Rows(indx).Cells(0).Value.ToString()
                DGVRemain(indx, cmbregno.Text, mm)
            Next
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub DGVRemain(ByVal indx As Integer, ByVal regno As String, ByVal month As String)
        Try
            cmd.CommandText = "select EmployerPFDeduct from Salary where regno='" & regno & "' and month='" & month & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                Dim pf As Decimal = CDec(dr("EmployerPFDeduct").ToString())
                dgviewsubscriptions.Rows(indx).Cells(2).Value = FormatNumber(pf.ToString())
            Else
                dgviewsubscriptions.Rows(indx).Cells(2).Value = "0.00"
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmPFSubscriptionAdvanceRecovery_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
        LoadEmpRegNo()
        cmbperiod.Items.Add(New ComboBoxIconItem(My.Settings.FinancialPeriod, 0))
        cmbperiod.Text = My.Settings.FinancialPeriod
        If USpayrollpf = "View Only" Then
            cmbperiod.Enabled = False
            cmbregno.Enabled = False
            txtname.ReadOnly = True
            dgviewsubscriptions.Enabled = False
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
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbperiod.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbregno.Focus()
        End If
    End Sub
#End Region
End Class
#End Region