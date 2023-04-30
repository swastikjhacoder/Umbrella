#Region "Imports..."
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
#End Region
#Region "Class frmIncomeExpenditure..."
Public Class frmIncomeExpenditure
#Region "Declarations..."
    Private dsincomeexpenditure As New DataSet()
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        lnkchart.SetBounds(313, 0, 67, 25)
        lnktable.SetBounds(246, 0, 67, 25)
    End Sub

    Private Sub LoadIncomeAccounts()
        Try
            Dim type As String = "Income"
            Dim i As Integer = 0
            dgviewincomeaccounts.Rows.Clear()
            cmd.CommandText = "select AccountID,AccountName,AccountBalance from Accounts where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Type='" & type & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewincomeaccounts.Rows.Add()
                dgviewincomeaccounts.Rows(i).Cells(0).Value = dr("AccountID").ToString()
                dgviewincomeaccounts.Rows(i).Cells(1).Value = dr("AccountName").ToString()
                Dim bal As Decimal = CDec(dr("AccountBalance").ToString())
                dgviewincomeaccounts.Rows(i).Cells(2).Value = FormatNumber(bal.ToString())
                i = i + 1
            End While
            dr.Close()
            dgviewincomeaccounts.ClearSelection()
            Grouper1.GroupTitle = "Income Accounts: "
            Grouper1.GroupTitle += dgviewincomeaccounts.Rows.Count.ToString()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadExpenseAccount()
        Try
            Dim type As String = "Expenditure"
            Dim i As Integer = 0
            dgviewexpenditureaccounts.Rows.Clear()
            cmd.CommandText = "select AccountID,AccountName,AccountBalance from Accounts where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Type='" & type & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewexpenditureaccounts.Rows.Add()
                dgviewexpenditureaccounts.Rows(i).Cells(0).Value = dr("AccountID").ToString()
                dgviewexpenditureaccounts.Rows(i).Cells(1).Value = dr("AccountName").ToString()
                Dim bal As Decimal = CDec(dr("AccountBalance").ToString())
                dgviewexpenditureaccounts.Rows(i).Cells(2).Value = FormatNumber(bal.ToString())
                i = i + 1
            End While
            dr.Close()
            dgviewexpenditureaccounts.ClearSelection()
            Grouper2.GroupTitle = "Expenditure Accounts: "
            Grouper2.GroupTitle += dgviewexpenditureaccounts.Rows.Count.ToString()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadIncomes()
        Try
            Dim desc As String = "Income"
            Dim i As Integer = 0
            dgviewincomes.Rows.Clear()
            cmd.CommandText = "select transactionid,descriptions,regno,name,amount from IncomeExpenditure where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and type='" & desc & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewincomes.Rows.Add()
                dgviewincomes.Rows(i).Cells(0).Value = dr("transactionid").ToString()
                dgviewincomes.Rows(i).Cells(1).Value = dr("descriptions").ToString()
                dgviewincomes.Rows(i).Cells(2).Value = dr("regno").ToString()
                dgviewincomes.Rows(i).Cells(3).Value = dr("name").ToString()
                Dim amt As Decimal = CDec(dr("amount").ToString())
                dgviewincomes.Rows(i).Cells(4).Value = FormatNumber(amt.ToString())
                i = i + 1
            End While
            dr.Close()
            dgviewincomes.ClearSelection()
            Grouper3.GroupTitle = "All Incomes: "
            Grouper3.GroupTitle += dgviewincomes.Rows.Count.ToString()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadExpenditures()
        Try
            Dim desc As String = "Expenditure"
            Dim i As Integer = 0
            dgviewexpenditures.Rows.Clear()
            cmd.CommandText = "select transactionid,descriptions,regno,name,amount from IncomeExpenditure where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and type='" & desc & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewexpenditures.Rows.Add()
                dgviewexpenditures.Rows(i).Cells(0).Value = dr("transactionid").ToString()
                dgviewexpenditures.Rows(i).Cells(1).Value = dr("descriptions").ToString()
                dgviewexpenditures.Rows(i).Cells(2).Value = dr("regno").ToString()
                dgviewexpenditures.Rows(i).Cells(3).Value = dr("name").ToString()
                Dim amt As Decimal = CDec(dr("amount").ToString())
                dgviewexpenditures.Rows(i).Cells(4).Value = FormatNumber(amt.ToString())
                i = i + 1
            End While
            dr.Close()
            dgviewexpenditures.ClearSelection()
            Grouper4.GroupTitle = "All Expenditures: "
            Grouper4.GroupTitle += dgviewexpenditures.Rows.Count.ToString()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub DrawChart()
        Try
            Dim desc1 As String = "Income"
            Dim desc2 As String = "Expenditure"
            Dim income As String = "All Incomes:"
            Dim expenditure As String = "All Expenditures:"
            Dim profit As String = "Net Profit:"
            Dim allincome As Decimal = 0.0
            Dim allexpenditure As Decimal = 0.0
            Dim netprofit As Decimal = 0.0
            Dim exist As Boolean = False
            cmd.CommandText = "select * from IncomeExpenditure where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                exist = True
            Else
                exist = False
            End If
            dr.Close()
            If exist = True Then
                cmd.CommandText = "select * from IncomeExpenditure where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and type='" & desc1 & "'"
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    dr.Close()
                    cmd.CommandText = "select sum(amount) from IncomeExpenditure where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and type='" & desc1 & "'"
                    allincome = cmd.ExecuteScalar
                Else
                    dr.Close()
                    allincome = 0.0
                End If
                cmd.CommandText = "select * from IncomeExpenditure where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and type='" & desc2 & "'"
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    dr.Close()
                    cmd.CommandText = "select sum(amount) from IncomeExpenditure where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and type='" & desc2 & "'"
                    allexpenditure = cmd.ExecuteScalar
                Else
                    dr.Close()
                    allexpenditure = 0.0
                End If
                netprofit = allincome - allexpenditure
            End If

            Dim year As Integer = Date.Now.Year
            dsincomeexpenditure.Clear()
            If Chart1.Series.Count > 0 Then
                Chart1.Series(0).Points.Clear()
            End If
            Chart1.Titles.Clear()
            Dim CArea As ChartArea = Chart1.ChartAreas(0)
            CArea.BackColor = Color.Transparent
            CArea.ShadowColor = Color.Red
            CArea.Area3DStyle.Enable3D = True
            CArea.AxisX.MajorGrid.Enabled = False
            CArea.AxisX.LabelStyle.Font = New System.Drawing.Font("Verdana", 8.0F, System.Drawing.FontStyle.Italic)
            CArea.AxisY.MajorGrid.Enabled = False
            CArea.AxisY.LabelStyle.Format = "0.00"
            CArea.AxisY.Interval = 0.2
            Dim T As Title = Chart1.Titles.Add("Revenue Year to Date Report:" + Environment.NewLine + "Period: " + My.Settings.FinancialPeriod)
            With T
                .ForeColor = Color.Honeydew
                .Font = New System.Drawing.Font("Verdana", 8.0F, System.Drawing.FontStyle.Bold)
                .BorderColor = Color.Black
                .BorderDashStyle = ChartDashStyle.NotSet
            End With
            Dim Series1 As Series = Chart1.Series(0)
            Series1.Name = "$"
            Dim LG As Legend = Chart1.Legends(0)
            LG.BackColor = Color.White
            LG.ForeColor = Color.DarkSlateBlue
            LG.Font = New System.Drawing.Font("Verdana", 8.0F, System.Drawing.FontStyle.Bold)

            Series1.ChartType = DataVisualization.Charting.SeriesChartType.Pie
            Series1.Points(Series1.Points.AddY(allincome)).AxisLabel = "INCOME"
            Series1.Points(Series1.Points.AddY(allexpenditure)).AxisLabel = "EXPENDITURE"
            Series1.Points(Series1.Points.AddY(netprofit)).AxisLabel = "PROFIT"

            For i As Integer = 0 To Chart1.Series.Count - 1
                For j As Integer = 0 To Chart1.Series(i).Points.Count - 1
                    Chart1.Series(i).Points(j)("PieLabelStyle") = "Disabled"
                Next
            Next
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub DrawTable()
        Try
            dgviewrevenue.Rows.Clear()
            dgviewrevenue.Rows.Add()
            dgviewrevenue.Rows.Add()
            dgviewrevenue.Rows.Add()
            dgviewrevenue.Rows.Add()
            dgviewrevenue.Rows.Add()
            dgviewrevenue.Rows.Add()
            Dim desc1 As String = "Income"
            Dim desc2 As String = "Expenditure"
            Dim income As String = "All Incomes:"
            Dim expenditure As String = "All Expenditures:"
            Dim profit As String = "Net Profit:"
            Dim allincome As Decimal = 0.0
            Dim allexpenditure As Decimal = 0.0
            Dim netprofit As Decimal = 0.0
            Dim exist As Boolean = False
            cmd.CommandText = "select * from IncomeExpenditure where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                exist = True
            Else
                exist = False
            End If
            dr.Close()
            If exist = True Then
                cmd.CommandText = "select * from IncomeExpenditure where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and type='" & desc1 & "'"
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    dr.Close()
                    cmd.CommandText = "select sum(amount) from IncomeExpenditure where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and type='" & desc1 & "'"
                    allincome = cmd.ExecuteScalar
                Else
                    dr.Close()
                    allincome = 0.0
                End If
                cmd.CommandText = "select * from IncomeExpenditure where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and type='" & desc2 & "'"
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    dr.Close()
                    cmd.CommandText = "select sum(amount) from IncomeExpenditure where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and type='" & desc2 & "'"
                    allexpenditure = cmd.ExecuteScalar
                Else
                    dr.Close()
                    allexpenditure = 0.0
                End If
                netprofit = allincome - allexpenditure
                dgviewrevenue.Rows(2).Cells(0).Value = income
                dgviewrevenue.Rows(3).Cells(0).Value = expenditure
                dgviewrevenue.Rows(4).Cells(0).Value = profit
                dgviewrevenue.Rows(2).Cells(1).Value = FormatNumber(allincome.ToString())
                dgviewrevenue.Rows(3).Cells(1).Value = FormatNumber(allexpenditure.ToString())
                dgviewrevenue.Rows(4).Cells(1).Value = FormatNumber(netprofit.ToString())
            Else
                dgviewrevenue.Rows(2).Cells(0).Value = income
                dgviewrevenue.Rows(3).Cells(0).Value = expenditure
                dgviewrevenue.Rows(4).Cells(0).Value = profit
                dgviewrevenue.Rows(2).Cells(1).Value = "0.00"
                dgviewrevenue.Rows(3).Cells(1).Value = "0.00"
                dgviewrevenue.Rows(4).Cells(1).Value = "0.00"
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmIncomeExpenditure_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ControlSetBound()
            DrawChart()
            DrawTable()
            LoadExpenditures()
            LoadExpenseAccount()
            LoadIncomeAccounts()
            LoadIncomes()
        Catch ex As Exception
            dr.Close()
        End Try
        If USincomeexpenditure = "View Only" Then
            dgviewexpenditureaccounts.Enabled = False
            dgviewexpenditures.Enabled = False
            dgviewincomeaccounts.Enabled = False
            dgviewincomes.Enabled = False
            dgviewrevenue.Enabled = False
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        Try
            DrawChart()
            DrawTable()
            LoadExpenditures()
            LoadExpenseAccount()
            LoadIncomeAccounts()
            LoadIncomes()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Attributes..."
    Private Sub lnkchart_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkchart.LinkClicked
        dgviewrevenue.Visible = False
        Chart1.Visible = True
    End Sub

    Private Sub lnktable_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnktable.LinkClicked
        dgviewrevenue.Visible = True
        Chart1.Visible = False
    End Sub
#End Region
End Class
#End Region