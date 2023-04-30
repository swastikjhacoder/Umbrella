#Region "Imports..."
Imports System.Windows.Forms.DataVisualization.Charting
#End Region
#Region "Class frmLibraryStatus..."
Public Class frmLibraryStatus
#Region "WithEvents..."
    Private WithEvents childA As frmChangeSystemDate
    Private WithEvents childB As frmAccountingPeriod
#End Region
#Region "Declarations..."
    Private dsincomeexpenditure As New DataSet()
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        lnkeditinstitute.SetBounds(423, 0, 152, 22)
        lnkbalancesheet.SetBounds(427, 5, 152, 16)
    End Sub

    Private Sub LoadDate()
        btndate.Text = "System Date: "
        btndate.Text += Date.Now.ToShortDateString()
    End Sub

    Private Sub LoadPeriod()
        Try
            Dim index As Integer = 0

            cmd.CommandText = "select StartingMonth from Institute where InsName='" & My.Settings.LastOpenedInstitute & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            cstartingmonth = dr("StartingMonth").ToString()
            dr.Close()

            If cstartingmonth = "January" Then

                Dim mm As Integer = Date.Now.Month

                If mm = 1 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=1"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 2 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=2"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 3 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=3"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 4 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=4"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 5 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=5"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 6 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=6"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 7 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=7"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 8 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=8"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 9 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=9"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 10 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=10"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 11 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=11"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 12 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=12"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                End If
            ElseIf cstartingmonth = "February" Then

                Dim mm As Integer = Date.Now.Month

                If mm = 1 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=12"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 2 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=1"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 3 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=2"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 4 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=3"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 5 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=4"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 6 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=5"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 7 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=6"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 8 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=7"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 9 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=8"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 10 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=9"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 11 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=10"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 12 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=11"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                End If
            ElseIf cstartingmonth = "March" Then

                Dim mm As Integer = Date.Now.Month

                If mm = 1 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=11"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 2 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=12"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 3 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=1"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 4 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=2"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 5 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=3"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 6 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=4"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 7 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=5"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 8 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=6"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 9 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=7"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 10 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=8"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 11 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=9"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 12 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=10"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                End If
            ElseIf cstartingmonth = "April" Then

                Dim mm As Integer = Date.Now.Month

                If mm = 1 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=10"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 2 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=11"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 3 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=12"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 4 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=1"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 5 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=2"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 6 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=3"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 7 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=4"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 8 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=5"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 9 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=6"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 10 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=7"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 11 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=8"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 12 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=9"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                End If
            ElseIf cstartingmonth = "May" Then

                Dim mm As Integer = Date.Now.Month

                If mm = 1 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=9"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 2 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=10"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 3 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=11"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 4 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=12"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 5 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=1"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 6 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=2"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 7 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=3"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 8 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=4"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 9 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=5"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 10 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=6"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 11 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=7"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 12 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=8"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                End If

            ElseIf cstartingmonth = "June" Then

                Dim mm As Integer = Date.Now.Month

                If mm = 1 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=8"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 2 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=9"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 3 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=10"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 4 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=11"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 5 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=12"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 6 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=1"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 7 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=2"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 8 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=3"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 9 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=4"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 10 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=5"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 11 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=6"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 12 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=7"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                End If

            ElseIf cstartingmonth = "July" Then

                Dim mm As Integer = Date.Now.Month

                If mm = 1 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=7"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 2 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=8"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 3 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=9"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 4 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=10"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 5 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=11"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 6 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=12"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 7 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=1"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 8 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=2"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 9 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=3"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 10 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=4"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 11 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=5"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 12 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=6"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                End If
            ElseIf cstartingmonth = "August" Then

                Dim mm As Integer = Date.Now.Month

                If mm = 1 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=6"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 2 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=7"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 3 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=8"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 4 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=9"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 5 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=10"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 6 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=11"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 7 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=12"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 8 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=1"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 9 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=2"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 10 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=3"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 11 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=4"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 12 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=5"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                End If

            ElseIf cstartingmonth = "September" Then

                Dim mm As Integer = Date.Now.Month

                If mm = 1 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=5"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 2 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=6"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 3 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=7"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 4 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=8"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 5 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=9"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 6 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=10"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 7 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=11"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 8 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=12"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 9 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=1"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 10 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=2"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 11 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=3"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 12 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=4"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                End If

            ElseIf cstartingmonth = "October" Then

                Dim mm As Integer = Date.Now.Month

                If mm = 1 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=4"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 2 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=5"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 3 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=6"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 4 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=7"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 5 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=8"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 6 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=9"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 7 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=10"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 8 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=11"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 9 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=12"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 10 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=1"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 11 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=2"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 12 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=3"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                End If

            ElseIf cstartingmonth = "November" Then

                Dim mm As Integer = Date.Now.Month

                If mm = 1 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=3"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 2 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=4"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 3 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=5"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 4 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=6"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 5 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=7"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 6 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=8"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 7 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=9"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 8 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=10"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 9 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=11"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 10 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=12"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 11 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=1"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 12 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=2"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                End If

            ElseIf cstartingmonth = "December" Then

                Dim mm As Integer = Date.Now.Month

                If mm = 1 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=2"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 2 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=3"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 3 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=4"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 4 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=5"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 5 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=6"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 6 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=7"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 7 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=8"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 8 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=9"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 9 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=10"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 10 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=11"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 11 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=12"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                ElseIf mm = 12 Then
                    cmd.CommandText = "select indexx,periodvalue from FinancialYear where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "' and indexx=1"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    index = dr("indexx").ToString()
                    periodvalue = index.ToString() + ": " + dr("periodvalue").ToString()
                    dr.Close()
                End If

            End If

            btnperiod.Text += periodvalue.ToString()

        Catch ex As Exception

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

    Private Sub LoadInstitute()
        Try
            dgviewinstitute.Rows.Clear()
            For indx As Integer = 0 To 13
                dgviewinstitute.Rows.Add()
            Next
            dgviewinstitute.Rows(0).Cells(0).Value = "Institution:"
            dgviewinstitute.Rows(1).Cells(0).Value = "Category:"
            dgviewinstitute.Rows(2).Cells(0).Value = "Financial Period:"
            dgviewinstitute.Rows(3).Cells(0).Value = "Address Line 1:"
            dgviewinstitute.Rows(4).Cells(0).Value = "Address Line 2:"
            dgviewinstitute.Rows(5).Cells(0).Value = "City:"
            dgviewinstitute.Rows(6).Cells(0).Value = "State:"
            dgviewinstitute.Rows(7).Cells(0).Value = "Pin Code:"
            dgviewinstitute.Rows(8).Cells(0).Value = "Country:"
            dgviewinstitute.Rows(9).Cells(0).Value = "Telephone:"
            dgviewinstitute.Rows(10).Cells(0).Value = "Fax:"
            dgviewinstitute.Rows(11).Cells(0).Value = "Website:"
            dgviewinstitute.Rows(12).Cells(0).Value = "Email:"
            dgviewinstitute.Rows(13).Cells(0).Value = "Forum:"

            cmd.CommandText = "select * from Institute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            dgviewinstitute.Rows(0).Cells(1).Value = dr("InsName").ToString()
            dgviewinstitute.Rows(1).Cells(1).Value = dr("Category").ToString()
            dgviewinstitute.Rows(2).Cells(1).Value = dr("FinancialPeriod").ToString()
            dgviewinstitute.Rows(3).Cells(1).Value = dr("Address1").ToString()
            dgviewinstitute.Rows(4).Cells(1).Value = dr("Address2").ToString()
            dgviewinstitute.Rows(5).Cells(1).Value = dr("City").ToString()
            dgviewinstitute.Rows(6).Cells(1).Value = dr("State").ToString()
            dgviewinstitute.Rows(7).Cells(1).Value = dr("Pin").ToString()
            dgviewinstitute.Rows(8).Cells(1).Value = dr("Country").ToString()
            dgviewinstitute.Rows(9).Cells(1).Value = dr("Telephone").ToString()
            dgviewinstitute.Rows(10).Cells(1).Value = dr("Fax").ToString()
            dgviewinstitute.Rows(11).Cells(1).Value = dr("Url1").ToString()
            dgviewinstitute.Rows(12).Cells(1).Value = dr("Email").ToString()
            dgviewinstitute.Rows(13).Cells(1).Value = dr("Url2").ToString()
            dr.Close()
            For row As Integer = 0 To dgviewinstitute.Rows.Count - 1
                dgviewinstitute.Rows(row).Cells(0).Style.BackColor = Color.SteelBlue
                dgviewinstitute.Rows(row).Cells(0).Style.ForeColor = Color.White
                dgviewinstitute.Rows(row).Cells(0).Style.SelectionBackColor = Color.SteelBlue
                dgviewinstitute.Rows(row).Cells(0).Style.SelectionForeColor = Color.White
            Next
            dgviewinstitute.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub DateValueUpdated(ByVal sender As Object, ByVal e As ValueUpdatedEventArgs) Handles childA.ValueUpdated
        Me.btndate.Text = "System Date: " + e.NewValue
    End Sub

    Private Sub PeriodValueUpdated(ByVal sender As Object, ByVal e As ValueUpdatedEventArgs) Handles childB.ValueUpdated
        Me.btnperiod.Text = "Period: " + e.NewValue
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmLibraryStatus_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadDate()
        LoadPeriod()
        ControlSetBound()
        LoadInstitute()
        DrawChart()
        DrawTable()
        If USbackuprestore = "No Access" Then
            btnbackup.Enabled = False
            btnrestore.Enabled = False
        End If
        If USimportexport = "No Access" Then
            btnimportexport.Enabled = False
        End If
        If USRevenue = "No Access" Then
            Chart1.Visible = False
            dgviewrevenue.Visible = False
        End If
        If USuserrole = "Administrator" Then
            lnkeditinstitute.Enabled = True
        Else
            lnkeditinstitute.Enabled = False
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btndate_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndate.ClickButtonArea
        Me.childA = New frmChangeSystemDate
        AddHandler childA.ValueUpdated, AddressOf DateValueUpdated

        Me.childA.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.childA.WindowState = FormWindowState.Normal
        Me.childA.StartPosition = FormStartPosition.CenterScreen
        Me.childA.ControlBox = True
        Me.childA.ShowDialog()
    End Sub

    Private Sub btnperiod_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnperiod.ClickButtonArea
        Me.childB = New frmAccountingPeriod
        AddHandler childB.ValueUpdated, AddressOf PeriodValueUpdated

        Me.childB.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.childB.WindowState = FormWindowState.Normal
        Me.childB.StartPosition = FormStartPosition.CenterScreen
        Me.childB.ControlBox = True
        Me.childB.ShowDialog()
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        LoadDate()
        LoadPeriod()
        ControlSetBound()
        LoadInstitute()
        DrawChart()
        DrawTable()
    End Sub

    Private Sub btnsetupguide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsetupguide.Click

    End Sub

    Private Sub btnusersecurity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnusersecurity.Click
        Dim frm As New frmUserSecurity()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub btnuserrole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnassignuserrole.Click
        Dim frm As New frmUserRole()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub btnbackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbackup.Click
        Dim frm As New frmBackupRestore()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub btnrestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrestore.Click
        Dim frm As New frmBackupRestore()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub btnimportexport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimportexport.Click
        Dim frm As New frmImportExportLibrary()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub btncheckupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncheckforupdate.Click

    End Sub
#End Region
#Region "Attributes..."
    Private Sub lnkeditinstitute_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkeditinstitute.LinkClicked
        Dim frm As New frmInstitute()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.WindowState = FormWindowState.Normal
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub lnkbalancesheet_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkbalancesheet.LinkClicked

    End Sub
#End Region
End Class
#End Region