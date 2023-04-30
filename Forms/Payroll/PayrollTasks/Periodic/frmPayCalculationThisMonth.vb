#Region "Class frmPayCalculationThisMonth..."
Public Class frmPayCalculationThisMonth
#Region "Declarations..."
    Private DGVDesignation As New DataGridView()
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        label1.SetBounds(14, 24, 94, 13)
        nudyear.SetBounds(261, 21, 59, 21)
        cmbmonth.SetBounds(122, 20, 129, 21)
    End Sub

    Private Sub LoadDesignation()
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .Name = "Col1"
                .HeaderText = "Designation"
            End With

            With DGVDesignation
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
                AddHandler DGVDesignation.CellClick, AddressOf DGVDesignation_CellClick
            End With

            DGVDesignation.Columns.Clear()
            DGVDesignation.Columns.Add(col1)

            DGVDesignation.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select distinct(designation) from Employee where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVDesignation.Rows.Add()
                DGVDesignation.Rows(indx).Cells(0).Value = dr("designation").ToString()

                indx = indx + 1
            End While
            dr.Close()
            DGVDesignation.ClearSelection()

            cmbdesignation.AddDataGridView(DGVDesignation, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVDesignation_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVDesignation.CurrentRow.Index
            DGVDesignation.Rows(k).Selected = True
            DGVDesignation.CurrentCell = DGVDesignation.Rows(k).Cells(0)
            designame = DGVDesignation.Rows(k).Cells(0).Value.ToString()
            cmbdesignation.Text = designame
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadMonth()
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

    Public Sub Process()
        If cmbdesignation.Text <> "" Then
            Dim cls As New cSalary()
            cls.Salary_Calculation(cmbmonth.Text, CInt(nudyear.Value.ToString()), cmbdesignation.Text)
            If cls.AddSalaryOk = True Then
                MessageBox.Show("Pay Calculation done for:" + " " + cls.TotalEmployee.ToString() + " - " + cmbdesignation.Text, "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                EVistaProgressBar1.Value = 0
            Else
                MessageBox.Show("Pay calculation failed:" + " " + cls.TotalEmployee.ToString() + " - " + cmbdesignation.Text, "Umbrella - Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                EVistaProgressBar1.Value = 0
            End If
        End If
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmPayCalculationThisMonth_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
        LoadDesignation()
        LoadMonth()
        Dim yy As Integer = Date.Now.Year
        Me.nudyear.Minimum = yy - 15
        Me.nudyear.Maximum = yy + 25
        Me.nudyear.Value = yy
        If USpayrollperiodic = "View Only" Then
            btnpreceed.Enabled = False
            cmbdesignation.Enabled = False
            cmbmonth.Enabled = False
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

    Private Sub nudyear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudyear.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbdesignation.Focus()
        End If
    End Sub

    Private Sub cmbdesignation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdesignation.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnpreceed.Focus()
        End If
    End Sub

    Private Sub ComboBoxKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbdesignation.KeyPress, cmbmonth.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnpreceed_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnpreceed.ClickButtonArea
        If cmbdesignation.Text = "" Then
            Dim result As DialogResult = MessageBox.Show("Please enter/select employee designation.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = DialogResult.OK Then
                cmbdesignation.Focus()
            End If
        Else
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Timer Tick..."
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If EVistaProgressBar1.Value < 100 Then
            EVistaProgressBar1.Value += 1
        Else
            Timer1.Enabled = False
            Process()
        End If
    End Sub
#End Region
End Class
#End Region