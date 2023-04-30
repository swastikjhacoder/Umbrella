#Region "Class frmAccountingPeriod..."
Public Class frmAccountingPeriod
#Region "Events..."
    Public Event ValueUpdated(ByVal sender As Object, ByVal e As ValueUpdatedEventArgs)
#End Region
#Region "Methods..."
    Private Sub LoadAccountingPeriods()
        Try
            Dim index As Integer = 0
            cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                index = dr("indexx").ToString()
                periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                lstfinancialperiod.Items.Add(periodvalue)
            End While
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadFiscalYeard()
        Try
            cmd.CommandText = "select FinancialPeriod from AccountingPeriod where InsName='" & My.Settings.LastOpenedInstitute & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                lstfiscalyears.Items.Add(dr("FinancialPeriod").ToString())
            End While
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadPayrollTaxYears()
        Try
            cmd.CommandText = "select FinancialPeriod from AccountingPeriod where InsName='" & My.Settings.LastOpenedInstitute & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                lstpayrolltaxyears.Items.Add(dr("FinancialPeriod").ToString())
            End While
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmAccountingPeriod_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadAccountingPeriods()
        LoadFiscalYeard()
        LoadPayrollTaxYears()
        lblperiodvalues.Text = My.Settings.FinancialPeriod
        For i As Integer = 0 To lstfinancialperiod.Items.Count - 1
            If My.Settings.FinancialPeriod = lstfinancialperiod.Items(i).ToString() Then
                lstfinancialperiod.SelectedIndex = i
            End If
        Next
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnok_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnok.ClickButtonArea
        Dim newValue As String
        newValue = Me.lstfinancialperiod.SelectedItem.ToString()
        Dim valueArgs As ValueUpdatedEventArgs
        valueArgs = New ValueUpdatedEventArgs(newValue)
        RaiseEvent ValueUpdated(Me, valueArgs)
        Me.Close()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region