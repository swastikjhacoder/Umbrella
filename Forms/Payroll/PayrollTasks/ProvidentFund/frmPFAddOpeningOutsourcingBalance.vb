#Region "Imports..."
Imports ESAR_Controls.UIControls.ComboBox
#End Region
#Region "Class frmPFAddOpeningOutsourcingBalance..."
Public Class frmPFAddOpeningOutsourcingBalance
#Region "Declarations..."
    Private DGVEmpRegNo As New DataGridView()
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(20, 22, 102, 13)
        Label2.SetBounds(20, 48, 45, 13)
        Label3.SetBounds(20, 76, 48, 13)
        Label4.SetBounds(20, 103, 108, 13)
        Label5.SetBounds(20, 131, 133, 13)

        cmbregno.SetBounds(175, 19, 126, 21)
        cmbperiod.SetBounds(175, 73, 245, 22)

        txtname.SetBounds(175, 46, 245, 21)
        txtopeningbal.SetBounds(175, 101, 80, 21)
        txtoutstandingbal.SetBounds(175, 128, 80, 21)
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
            LoadPFDetails(EmpRegNo)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadPFDetails(ByVal regno As String)
        Try
            cmd.CommandText = "select openingbalance,outstandingadvance from PF where regno='" & regno & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim openingbal As Decimal = CDec(dr("openingbalance").ToString())
            Dim outstandingadv As Decimal = CDec(dr("outstandingadvance").ToString())
            txtopeningbal.Text = FormatNumber(openingbal.ToString())
            txtoutstandingbal.Text = FormatNumber(outstandingadv.ToString())
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmPFAddOpeningOutsourcingBalance_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
        LoadEmpRegNo()
        cmbperiod.Items.Add(New ComboBoxIconItem(My.Settings.FinancialPeriod, 0))
        cmbperiod.Text = My.Settings.FinancialPeriod
        If USpayrollpf = "View Only" Then
            cmbperiod.Enabled = False
            cmbregno.Enabled = False
            txtname.ReadOnly = True
            txtopeningbal.ReadOnly = True
            txtoutstandingbal.ReadOnly = True
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

    Private Sub cmbperiod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbperiod.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtopeningbal.Focus()
        End If
    End Sub

    Private Sub txtopeningbal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtopeningbal.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtoutstandingbal.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbperiod.Focus()
        End If
    End Sub

    Private Sub txtoutstandingbal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtoutstandingbal.KeyDown
        If e.KeyCode = Keys.Up Then
            txtopeningbal.Focus()
        End If
    End Sub
#End Region
End Class
#End Region