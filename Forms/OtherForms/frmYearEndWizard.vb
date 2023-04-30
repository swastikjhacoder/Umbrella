#Region "Imports..."
Imports System
Imports System.Data
Imports System.Data.SqlClient
#End Region
#Region "Class frmYearEndWizard..."
Public Class frmYearEndWizard
#Region "Declarations..."
    Private LanguageTexts_Next As String = "&Next"
    Private LanguageTexts_Finish As String = "&Finish"
    Private LanguageTexts_Back As String = "&Back"
    Private NextPeriod As String = ""
    Private STR(11) As String
    Private STR1(11) As String
    Private STR2(11) As String
    Private DD(11) As Integer
#End Region
#Region "Methods..."
    Friend Sub GoToTab(Optional ByVal Aantal As Integer = 1)
        ETabControlEx1.SelectedIndex = ETabControlEx1.SelectedIndex + Aantal
        CheckTabPageAndUpdateButtons()
    End Sub

    Friend Sub GoToTab(ByVal Tab As TabPage)
        ETabControlEx1.SelectedTab = Tab
        CheckTabPageAndUpdateButtons()
    End Sub

    Sub CheckTabPageAndUpdateButtons()
        If ETabControlEx1.SelectedIndex = 0 Then
            DisableBackButton()
        Else
            EnableBackButton()
        End If
        If ETabControlEx1.SelectedIndex = ETabControlEx1.TabCount - 1 Then
            SetNextButtonToFinish()
        Else
            SetNextButtonToNext()
        End If
    End Sub

    Sub DisableBackButton()
        btnback.Enabled = False
        btnback.Tag = "disabled"
        btnback.Image = Global.Umbrella.My.Resources.disabled_back
    End Sub

    Sub EnableBackButton()
        btnback.Enabled = True
        btnback.Tag = ""
        btnback.Image = Global.Umbrella.My.Resources.back
    End Sub

    Sub SetNextButtonToFinish()
        btnnext.Text = LanguageTexts_Finish
        btnnext.Tag = "finish"
    End Sub

    Sub SetNextButtonToNext()
        btnnext.Text = LanguageTexts_Next
        btnnext.Tag = ""
    End Sub

    Private Sub CurrentFiscalYear()
        lstcurrentfiscalyear1.Items.Add(My.Settings.Period)
        lstcurrentfiscalyear2.Items.Add(My.Settings.Period)
        lstcurrentfiscalyear3.Items.Add(My.Settings.Period)
    End Sub

    Private Sub CurrentPayrollTaxYear()
        lstcurraentpayrolltaxyear1.Items.Add(My.Settings.Period)
        lstcurraentpayrolltaxyear2.Items.Add(My.Settings.Period)
    End Sub

    Private Sub NewDGViewFiscalYear()
        Try
            cmd.CommandText = "select StartDate,StartingMonth from Institute where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            cstartdate = dr("StartDate").ToString()
            cstartingmonth = dr("StartingMonth").ToString()
            dr.Close()

            Dim dte As Date = CDate(cstartdate.ToString())
            Dim yy As Integer = dte.Year + 1

            Dim yy1 As Integer = yy + 1

            If cstartingmonth = "January" Then

                DD(0) = Date.DaysInMonth(yy, 1)
                STR1(0) = "01/01" + "/" + yy.ToString()
                STR2(0) = DD(0).ToString() + "/01" + "/" + yy.ToString()
                STR(0) = STR1(0) + " - " + STR2(0)

                DD(1) = Date.DaysInMonth(yy, 2)
                STR1(1) = "01/02" + "/" + yy.ToString()
                STR2(1) = DD(1).ToString() + "/02" + "/" + yy.ToString()
                STR(1) = STR1(1) + " - " + STR2(1)

                DD(2) = Date.DaysInMonth(yy, 3)
                STR1(2) = "01/03" + "/" + yy.ToString()
                STR2(2) = DD(2).ToString() + "/03" + "/" + yy.ToString()
                STR(2) = STR1(2) + " - " + STR2(2)

                DD(3) = Date.DaysInMonth(yy, 4)
                STR1(3) = "01/04" + "/" + yy.ToString()
                STR2(3) = DD(3).ToString() + "/04" + "/" + yy.ToString()
                STR(3) = STR1(3) + " - " + STR2(3)

                DD(4) = Date.DaysInMonth(yy, 5)
                STR1(4) = "01/05" + "/" + yy.ToString()
                STR2(4) = DD(4).ToString() + "/05" + "/" + yy.ToString()
                STR(4) = STR1(4) + " - " + STR2(4)

                DD(5) = Date.DaysInMonth(yy, 6)
                STR1(5) = "01/06" + "/" + yy.ToString()
                STR2(5) = DD(5).ToString() + "/06" + "/" + yy.ToString()
                STR(5) = STR1(5) + " - " + STR2(5)

                DD(6) = Date.DaysInMonth(yy, 7)
                STR1(6) = "01/07" + "/" + yy.ToString()
                STR2(6) = DD(6).ToString() + "/07" + "/" + yy.ToString()
                STR(6) = STR1(6) + " - " + STR2(6)

                DD(7) = Date.DaysInMonth(yy, 8)
                STR1(7) = "01/08" + "/" + yy.ToString()
                STR2(7) = DD(7).ToString() + "/08" + "/" + yy.ToString()
                STR(7) = STR1(7) + " - " + STR2(7)

                DD(8) = Date.DaysInMonth(yy, 9)
                STR1(8) = "01/09" + "/" + yy.ToString()
                STR2(8) = DD(8).ToString() + "/09" + "/" + yy.ToString()
                STR(8) = STR1(8) + " - " + STR2(8)

                DD(9) = Date.DaysInMonth(yy, 10)
                STR1(9) = "01/10" + "/" + yy.ToString()
                STR2(9) = DD(9).ToString() + "/10" + "/" + yy.ToString()
                STR(9) = STR1(9) + " - " + STR2(9)

                DD(10) = Date.DaysInMonth(yy, 11)
                STR1(10) = "01/11" + "/" + yy.ToString()
                STR2(10) = DD(10).ToString() + "/11" + "/" + yy.ToString()
                STR(10) = STR1(10) + " - " + STR2(10)

                DD(11) = Date.DaysInMonth(yy, 12)
                STR1(11) = "01/12" + "/" + yy.ToString()
                STR2(11) = DD(11).ToString() + "/12" + "/" + yy.ToString()
                STR(11) = STR1(11) + " - " + STR2(11)

            ElseIf cstartingmonth = "February" Then

                DD(0) = Date.DaysInMonth(yy, 2)
                STR1(0) = "01/02" + "/" + yy.ToString()
                STR2(0) = DD(0).ToString() + "/02" + "/" + yy.ToString()
                STR(0) = STR1(0) + " - " + STR2(0)

                DD(1) = Date.DaysInMonth(yy, 3)
                STR1(1) = "01/03" + "/" + yy.ToString()
                STR2(1) = DD(1).ToString() + "/03" + "/" + yy.ToString()
                STR(1) = STR1(1) + " - " + STR2(1)

                DD(2) = Date.DaysInMonth(yy, 4)
                STR1(2) = "01/04" + "/" + yy.ToString()
                STR2(2) = DD(2).ToString() + "/04" + "/" + yy.ToString()
                STR(2) = STR1(2) + " - " + STR2(2)

                DD(3) = Date.DaysInMonth(yy, 5)
                STR1(3) = "01/05" + "/" + yy.ToString()
                STR2(3) = DD(3).ToString() + "/05" + "/" + yy.ToString()
                STR(3) = STR1(3) + " - " + STR2(3)

                DD(4) = Date.DaysInMonth(yy, 6)
                STR1(4) = "01/06" + "/" + yy.ToString()
                STR2(4) = DD(4).ToString() + "/06" + "/" + yy.ToString()
                STR(4) = STR1(4) + " - " + STR2(4)

                DD(5) = Date.DaysInMonth(yy, 7)
                STR1(5) = "01/07" + "/" + yy.ToString()
                STR2(5) = DD(5).ToString() + "/07" + "/" + yy.ToString()
                STR(5) = STR1(5) + " - " + STR2(5)

                DD(6) = Date.DaysInMonth(yy, 8)
                STR1(6) = "01/08" + "/" + yy.ToString()
                STR2(6) = DD(6).ToString() + "/08" + "/" + yy.ToString()
                STR(6) = STR1(6) + " - " + STR2(6)

                DD(7) = Date.DaysInMonth(yy, 9)
                STR1(7) = "01/09" + "/" + yy.ToString()
                STR2(7) = DD(7).ToString() + "/09" + "/" + yy.ToString()
                STR(7) = STR1(7) + " - " + STR2(7)

                DD(8) = Date.DaysInMonth(yy, 10)
                STR1(8) = "01/10" + "/" + yy.ToString()
                STR2(8) = DD(8).ToString() + "/10" + "/" + yy.ToString()
                STR(8) = STR1(8) + " - " + STR2(8)

                DD(9) = Date.DaysInMonth(yy, 11)
                STR1(9) = "01/11" + "/" + yy.ToString()
                STR2(9) = DD(9).ToString() + "/11" + "/" + yy.ToString()
                STR(9) = STR1(9) + " - " + STR2(9)

                DD(10) = Date.DaysInMonth(yy, 12)
                STR1(10) = "01/12" + "/" + yy.ToString()
                STR2(10) = DD(10).ToString() + "/12" + "/" + yy.ToString()
                STR(10) = STR1(10) + " - " + STR2(10)

                DD(11) = Date.DaysInMonth((yy + 1), 1)
                STR1(11) = "01/01" + "/" + yy1.ToString()
                STR2(11) = DD(11).ToString() + "/01" + "/" + yy1.ToString()
                STR(11) = STR1(11) + " - " + STR2(11)


            ElseIf cstartingmonth = "March" Then

                DD(0) = Date.DaysInMonth(yy, 3)
                STR1(0) = "01/03" + "/" + yy.ToString()
                STR2(0) = DD(0).ToString() + "/03" + "/" + yy.ToString()
                STR(0) = STR1(0) + " - " + STR2(0)

                DD(1) = Date.DaysInMonth(yy, 4)
                STR1(1) = "01/04" + "/" + yy.ToString()
                STR2(1) = DD(1).ToString() + "/04" + "/" + yy.ToString()
                STR(1) = STR1(1) + " - " + STR2(1)

                DD(2) = Date.DaysInMonth(yy, 5)
                STR1(2) = "01/05" + "/" + yy.ToString()
                STR2(2) = DD(2).ToString() + "/05" + "/" + yy.ToString()
                STR(2) = STR1(2) + " - " + STR2(2)

                DD(3) = Date.DaysInMonth(yy, 6)
                STR1(3) = "01/06" + "/" + yy.ToString()
                STR2(3) = DD(3).ToString() + "/06" + "/" + yy.ToString()
                STR(3) = STR1(3) + " - " + STR2(3)

                DD(4) = Date.DaysInMonth(yy, 7)
                STR1(4) = "01/07" + "/" + yy.ToString()
                STR2(4) = DD(4).ToString() + "/07" + "/" + yy.ToString()
                STR(4) = STR1(4) + " - " + STR2(4)

                DD(5) = Date.DaysInMonth(yy, 8)
                STR1(5) = "01/08" + "/" + yy.ToString()
                STR2(5) = DD(5).ToString() + "/08" + "/" + yy.ToString()
                STR(5) = STR1(5) + " - " + STR2(5)

                DD(6) = Date.DaysInMonth(yy, 9)
                STR1(6) = "01/09" + "/" + yy.ToString()
                STR2(6) = DD(6).ToString() + "/09" + "/" + yy.ToString()
                STR(6) = STR1(6) + " - " + STR2(6)

                DD(7) = Date.DaysInMonth(yy, 10)
                STR1(7) = "01/10" + "/" + yy.ToString()
                STR2(7) = DD(7).ToString() + "/10" + "/" + yy.ToString()
                STR(7) = STR1(7) + " - " + STR2(7)

                DD(8) = Date.DaysInMonth(yy, 11)
                STR1(8) = "01/11" + "/" + yy.ToString()
                STR2(8) = DD(8).ToString() + "/11" + "/" + yy.ToString()
                STR(8) = STR1(8) + " - " + STR2(8)

                DD(9) = Date.DaysInMonth(yy, 12)
                STR1(9) = "01/12" + "/" + yy.ToString()
                STR2(9) = DD(9).ToString() + "/12" + "/" + yy.ToString()
                STR(9) = STR1(9) + " - " + STR2(9)

                DD(10) = Date.DaysInMonth((yy + 1), 1)
                STR1(10) = "01/01" + "/" + yy1.ToString()
                STR2(10) = DD(10).ToString() + "/01" + "/" + yy1.ToString()
                STR(10) = STR1(10) + " - " + STR2(10)

                DD(11) = Date.DaysInMonth((yy + 1), 2)
                STR1(11) = "01/02" + "/" + yy1.ToString()
                STR2(11) = DD(11).ToString() + "/02" + "/" + yy1.ToString()
                STR(11) = STR1(11) + " - " + STR2(11)


            ElseIf cstartingmonth = "April" Then

                DD(0) = Date.DaysInMonth(yy, 4)
                STR1(0) = "01/04" + "/" + yy.ToString()
                STR2(0) = DD(0).ToString() + "/04" + "/" + yy.ToString()
                STR(0) = STR1(0) + " - " + STR2(0)

                DD(1) = Date.DaysInMonth(yy, 5)
                STR1(1) = "01/05" + "/" + yy.ToString()
                STR2(1) = DD(1).ToString() + "/05" + "/" + yy.ToString()
                STR(1) = STR1(1) + " - " + STR2(1)

                DD(2) = Date.DaysInMonth(yy, 6)
                STR1(2) = "01/06" + "/" + yy.ToString()
                STR2(2) = DD(2).ToString() + "/06" + "/" + yy.ToString()
                STR(2) = STR1(2) + " - " + STR2(2)

                DD(3) = Date.DaysInMonth(yy, 7)
                STR1(3) = "01/07" + "/" + yy.ToString()
                STR2(3) = DD(3).ToString() + "/07" + "/" + yy.ToString()
                STR(3) = STR1(3) + " - " + STR2(3)

                DD(4) = Date.DaysInMonth(yy, 8)
                STR1(4) = "01/08" + "/" + yy.ToString()
                STR2(4) = DD(4).ToString() + "/08" + "/" + yy.ToString()
                STR(4) = STR1(4) + " - " + STR2(4)

                DD(5) = Date.DaysInMonth(yy, 9)
                STR1(5) = "01/09" + "/" + yy.ToString()
                STR2(5) = DD(5).ToString() + "/09" + "/" + yy.ToString()
                STR(5) = STR1(5) + " - " + STR2(5)

                DD(6) = Date.DaysInMonth(yy, 10)
                STR1(6) = "01/10" + "/" + yy.ToString()
                STR2(6) = DD(6).ToString() + "/10" + "/" + yy.ToString()
                STR(6) = STR1(6) + " - " + STR2(6)

                DD(7) = Date.DaysInMonth(yy, 11)
                STR1(7) = "01/11" + "/" + yy.ToString()
                STR2(7) = DD(7).ToString() + "/11" + "/" + yy.ToString()
                STR(7) = STR1(7) + " - " + STR2(7)

                DD(8) = Date.DaysInMonth(yy, 12)
                STR1(8) = "01/12" + "/" + yy.ToString()
                STR2(8) = DD(8).ToString() + "/12" + "/" + yy.ToString()
                STR(8) = STR1(8) + " - " + STR2(8)

                DD(9) = Date.DaysInMonth((yy + 1), 1)
                STR1(9) = "01/01" + "/" + yy1.ToString()
                STR2(9) = DD(9).ToString() + "/01" + "/" + yy1.ToString()
                STR(9) = STR1(9) + " - " + STR2(9)

                DD(10) = Date.DaysInMonth((yy + 1), 2)
                STR1(10) = "01/02" + "/" + yy1.ToString()
                STR2(10) = DD(10).ToString() + "/02" + "/" + yy1.ToString()
                STR(10) = STR1(10) + " - " + STR2(10)

                DD(11) = Date.DaysInMonth((yy + 1), 3)
                STR1(11) = "01/03" + "/" + yy1.ToString()
                STR2(11) = DD(11).ToString() + "/03" + "/" + yy1.ToString()
                STR(11) = STR1(11) + " - " + STR2(11)


            ElseIf cstartingmonth = "May" Then

                DD(0) = Date.DaysInMonth(yy, 5)
                STR1(0) = "01/05" + "/" + yy.ToString()
                STR2(0) = DD(0).ToString() + "/05" + "/" + yy.ToString()
                STR(0) = STR1(0) + " - " + STR2(0)

                DD(1) = Date.DaysInMonth(yy, 6)
                STR1(1) = "01/06" + "/" + yy.ToString()
                STR2(1) = DD(1).ToString() + "/06" + "/" + yy.ToString()
                STR(1) = STR1(1) + " - " + STR2(1)

                DD(2) = Date.DaysInMonth(yy, 7)
                STR1(2) = "01/07" + "/" + yy.ToString()
                STR2(2) = DD(2).ToString() + "/07" + "/" + yy.ToString()
                STR(2) = STR1(2) + " - " + STR2(2)

                DD(3) = Date.DaysInMonth(yy, 8)
                STR1(3) = "01/08" + "/" + yy.ToString()
                STR2(3) = DD(3).ToString() + "/08" + "/" + yy.ToString()
                STR(3) = STR1(3) + " - " + STR2(3)

                DD(4) = Date.DaysInMonth(yy, 9)
                STR1(4) = "01/09" + "/" + yy.ToString()
                STR2(4) = DD(4).ToString() + "/09" + "/" + yy.ToString()
                STR(4) = STR1(4) + " - " + STR2(4)

                DD(5) = Date.DaysInMonth(yy, 10)
                STR1(5) = "01/10" + "/" + yy.ToString()
                STR2(5) = DD(5).ToString() + "/10" + "/" + yy.ToString()
                STR(5) = STR1(5) + " - " + STR2(5)

                DD(6) = Date.DaysInMonth(yy, 11)
                STR1(6) = "01/11" + "/" + yy.ToString()
                STR2(6) = DD(6).ToString() + "/11" + "/" + yy.ToString()
                STR(6) = STR1(6) + " - " + STR2(6)

                DD(7) = Date.DaysInMonth(yy, 12)
                STR1(7) = "01/12" + "/" + yy.ToString()
                STR2(7) = DD(7).ToString() + "/12" + "/" + yy.ToString()
                STR(7) = STR1(7) + " - " + STR2(7)

                DD(8) = Date.DaysInMonth((yy + 1), 1)
                STR1(8) = "01/01" + "/" + yy1.ToString()
                STR2(8) = DD(8).ToString() + "/01" + "/" + yy1.ToString()
                STR(8) = STR1(8) + " - " + STR2(8)

                DD(9) = Date.DaysInMonth((yy + 1), 2)
                STR1(9) = "01/02" + "/" + yy1.ToString()
                STR2(9) = DD(9).ToString() + "/02" + "/" + yy1.ToString()
                STR(9) = STR1(9) + " - " + STR2(9)

                DD(10) = Date.DaysInMonth((yy + 1), 3)
                STR1(10) = "01/03" + "/" + yy1.ToString()
                STR2(10) = DD(10).ToString() + "/03" + "/" + yy1.ToString()
                STR(10) = STR1(10) + " - " + STR2(10)

                DD(11) = Date.DaysInMonth((yy + 1), 4)
                STR1(11) = "01/04" + "/" + yy1.ToString()
                STR2(11) = DD(11).ToString() + "/04" + "/" + yy1.ToString()
                STR(11) = STR1(11) + " - " + STR2(11)


            ElseIf cstartingmonth = "June" Then

                DD(0) = Date.DaysInMonth(yy, 6)
                STR1(0) = "01/06" + "/" + yy.ToString()
                STR2(0) = DD(0).ToString() + "/06" + "/" + yy.ToString()
                STR(0) = STR1(0) + " - " + STR2(0)

                DD(1) = Date.DaysInMonth(yy, 7)
                STR1(1) = "01/07" + "/" + yy.ToString()
                STR2(1) = DD(1).ToString() + "/07" + "/" + yy.ToString()
                STR(1) = STR1(1) + " - " + STR2(1)

                DD(2) = Date.DaysInMonth(yy, 8)
                STR1(2) = "01/08" + "/" + yy.ToString()
                STR2(2) = DD(2).ToString() + "/08" + "/" + yy.ToString()
                STR(2) = STR1(2) + " - " + STR2(2)

                DD(3) = Date.DaysInMonth(yy, 9)
                STR1(3) = "01/09" + "/" + yy.ToString()
                STR2(3) = DD(3).ToString() + "/09" + "/" + yy.ToString()
                STR(3) = STR1(3) + " - " + STR2(3)

                DD(4) = Date.DaysInMonth(yy, 10)
                STR1(4) = "01/10" + "/" + yy.ToString()
                STR2(4) = DD(4).ToString() + "/10" + "/" + yy.ToString()
                STR(4) = STR1(4) + " - " + STR2(4)

                DD(5) = Date.DaysInMonth(yy, 11)
                STR1(5) = "01/11" + "/" + yy.ToString()
                STR2(5) = DD(5).ToString() + "/11" + "/" + yy.ToString()
                STR(5) = STR1(5) + " - " + STR2(5)

                DD(6) = Date.DaysInMonth(yy, 12)
                STR1(6) = "01/12" + "/" + yy.ToString()
                STR2(6) = DD(6).ToString() + "/12" + "/" + yy.ToString()
                STR(6) = STR1(6) + " - " + STR2(6)

                DD(7) = Date.DaysInMonth((yy + 1), 1)
                STR1(7) = "01/01" + "/" + yy1.ToString()
                STR2(7) = DD(7).ToString() + "/01" + "/" + yy1.ToString()
                STR(7) = STR1(7) + " - " + STR2(7)

                DD(8) = Date.DaysInMonth((yy + 1), 2)
                STR1(8) = "01/02" + "/" + yy1.ToString()
                STR2(8) = DD(8).ToString() + "/02" + "/" + yy1.ToString()
                STR(8) = STR1(8) + " - " + STR2(8)

                DD(9) = Date.DaysInMonth((yy + 1), 3)
                STR1(9) = "01/03" + "/" + yy1.ToString()
                STR2(9) = DD(9).ToString() + "/03" + "/" + yy1.ToString()
                STR(9) = STR1(9) + " - " + STR2(9)

                DD(10) = Date.DaysInMonth((yy + 1), 4)
                STR1(10) = "01/04" + "/" + yy1.ToString()
                STR2(10) = DD(10).ToString() + "/04" + "/" + yy1.ToString()
                STR(10) = STR1(10) + " - " + STR2(10)

                DD(11) = Date.DaysInMonth((yy + 1), 5)
                STR1(11) = "01/05" + "/" + yy1.ToString()
                STR2(11) = DD(11).ToString() + "/05" + "/" + yy1.ToString()
                STR(11) = STR1(11) + " - " + STR2(11)


            ElseIf cstartingmonth = "July" Then

                DD(0) = Date.DaysInMonth(yy, 7)
                STR1(0) = "01/07" + "/" + yy.ToString()
                STR2(0) = DD(0).ToString() + "/07" + "/" + yy.ToString()
                STR(0) = STR1(0) + " - " + STR2(0)

                DD(1) = Date.DaysInMonth(yy, 8)
                STR1(1) = "01/08" + "/" + yy.ToString()
                STR2(1) = DD(1).ToString() + "/08" + "/" + yy.ToString()
                STR(1) = STR1(1) + " - " + STR2(1)

                DD(2) = Date.DaysInMonth(yy, 9)
                STR1(2) = "01/09" + "/" + yy.ToString()
                STR2(2) = DD(2).ToString() + "/09" + "/" + yy.ToString()
                STR(2) = STR1(2) + " - " + STR2(2)

                DD(3) = Date.DaysInMonth(yy, 10)
                STR1(3) = "01/10" + "/" + yy.ToString()
                STR2(3) = DD(3).ToString() + "/10" + "/" + yy.ToString()
                STR(3) = STR1(3) + " - " + STR2(3)

                DD(4) = Date.DaysInMonth(yy, 11)
                STR1(4) = "01/11" + "/" + yy.ToString()
                STR2(4) = DD(4).ToString() + "/11" + "/" + yy.ToString()
                STR(4) = STR1(4) + " - " + STR2(4)

                DD(5) = Date.DaysInMonth(yy, 12)
                STR1(5) = "01/12" + "/" + yy.ToString()
                STR2(5) = DD(5).ToString() + "/12" + "/" + yy.ToString()
                STR(5) = STR1(5) + " - " + STR2(5)

                DD(6) = Date.DaysInMonth((yy + 1), 1)
                STR1(6) = "01/01" + "/" + yy1.ToString()
                STR2(6) = DD(6).ToString() + "/01" + "/" + yy1.ToString()
                STR(6) = STR1(6) + " - " + STR2(6)

                DD(7) = Date.DaysInMonth((yy + 1), 2)
                STR1(7) = "01/02" + "/" + yy1.ToString()
                STR2(7) = DD(7).ToString() + "/02" + "/" + yy1.ToString()
                STR(7) = STR1(7) + " - " + STR2(7)

                DD(8) = Date.DaysInMonth((yy + 1), 3)
                STR1(8) = "01/03" + "/" + yy1.ToString()
                STR2(8) = DD(8).ToString() + "/03" + "/" + yy1.ToString()
                STR(8) = STR1(8) + " - " + STR2(8)

                DD(9) = Date.DaysInMonth((yy + 1), 4)
                STR1(9) = "01/04" + "/" + yy1.ToString()
                STR2(9) = DD(9).ToString() + "/04" + "/" + yy1.ToString()
                STR(9) = STR1(9) + " - " + STR2(9)

                DD(10) = Date.DaysInMonth((yy + 1), 5)
                STR1(10) = "01/05" + "/" + yy1.ToString()
                STR2(10) = DD(10).ToString() + "/05" + "/" + yy1.ToString()
                STR(10) = STR1(10) + " - " + STR2(10)

                DD(11) = Date.DaysInMonth((yy + 1), 6)
                STR1(11) = "01/06" + "/" + yy1.ToString()
                STR2(11) = DD(11).ToString() + "/06" + "/" + yy1.ToString()
                STR(11) = STR1(11) + " - " + STR2(11)


            ElseIf cstartingmonth = "August" Then

                DD(0) = Date.DaysInMonth(yy, 8)
                STR1(0) = "01/08" + "/" + yy.ToString()
                STR2(0) = DD(0).ToString() + "/08" + "/" + yy.ToString()
                STR(0) = STR1(0) + " - " + STR2(0)

                DD(1) = Date.DaysInMonth(yy, 9)
                STR1(1) = "01/09" + "/" + yy.ToString()
                STR2(1) = DD(1).ToString() + "/09" + "/" + yy.ToString()
                STR(1) = STR1(1) + " - " + STR2(1)

                DD(2) = Date.DaysInMonth(yy, 10)
                STR1(2) = "01/10" + "/" + yy.ToString()
                STR2(2) = DD(2).ToString() + "/10" + "/" + yy.ToString()
                STR(2) = STR1(2) + " - " + STR2(2)

                DD(3) = Date.DaysInMonth(yy, 11)
                STR1(3) = "01/11" + "/" + yy.ToString()
                STR2(3) = DD(3).ToString() + "/11" + "/" + yy.ToString()
                STR(3) = STR1(3) + " - " + STR2(3)

                DD(4) = Date.DaysInMonth(yy, 12)
                STR1(4) = "01/12" + "/" + yy.ToString()
                STR2(4) = DD(4).ToString() + "/12" + "/" + yy.ToString()
                STR(4) = STR1(4) + " - " + STR2(4)

                DD(5) = Date.DaysInMonth((yy + 1), 1)
                STR1(5) = "01/01" + "/" + yy1.ToString()
                STR2(5) = DD(5).ToString() + "/01" + "/" + yy1.ToString()
                STR(5) = STR1(5) + " - " + STR2(5)

                DD(6) = Date.DaysInMonth((yy + 1), 2)
                STR1(6) = "01/02" + "/" + yy1.ToString()
                STR2(6) = DD(6).ToString() + "/02" + "/" + yy1.ToString()
                STR(6) = STR1(6) + " - " + STR2(6)

                DD(7) = Date.DaysInMonth((yy + 1), 3)
                STR1(7) = "01/03" + "/" + yy1.ToString()
                STR2(7) = DD(7).ToString() + "/03" + "/" + yy1.ToString()
                STR(7) = STR1(7) + " - " + STR2(7)

                DD(8) = Date.DaysInMonth((yy + 1), 4)
                STR1(8) = "01/04" + "/" + yy1.ToString()
                STR2(8) = DD(8).ToString() + "/04" + "/" + yy1.ToString()
                STR(8) = STR1(8) + " - " + STR2(8)

                DD(9) = Date.DaysInMonth((yy + 1), 5)
                STR1(9) = "01/05" + "/" + yy1.ToString()
                STR2(9) = DD(9).ToString() + "/05" + "/" + yy1.ToString()
                STR(9) = STR1(9) + " - " + STR2(9)

                DD(10) = Date.DaysInMonth((yy + 1), 6)
                STR1(10) = "01/06" + "/" + yy1.ToString()
                STR2(10) = DD(10).ToString() + "/06" + "/" + yy1.ToString()
                STR(10) = STR1(10) + " - " + STR2(10)

                DD(11) = Date.DaysInMonth((yy + 1), 7)
                STR1(11) = "01/07" + "/" + yy1.ToString()
                STR2(11) = DD(11).ToString() + "/07" + "/" + yy1.ToString()
                STR(11) = STR1(11) + " - " + STR2(11)


            ElseIf cstartingmonth = "September" Then

                DD(0) = Date.DaysInMonth(yy, 9)
                STR1(0) = "01/09" + "/" + yy.ToString()
                STR2(0) = DD(0).ToString() + "/09" + "/" + yy.ToString()
                STR(0) = STR1(0) + " - " + STR2(0)

                DD(1) = Date.DaysInMonth(yy, 10)
                STR1(1) = "01/10" + "/" + yy.ToString()
                STR2(1) = DD(1).ToString() + "/10" + "/" + yy.ToString()
                STR(1) = STR1(1) + " - " + STR2(1)

                DD(2) = Date.DaysInMonth(yy, 11)
                STR1(2) = "01/11" + "/" + yy.ToString()
                STR2(2) = DD(2).ToString() + "/11" + "/" + yy.ToString()
                STR(2) = STR1(2) + " - " + STR2(2)

                DD(3) = Date.DaysInMonth(yy, 12)
                STR1(3) = "01/12" + "/" + yy.ToString()
                STR2(3) = DD(3).ToString() + "/12" + "/" + yy.ToString()
                STR(3) = STR1(3) + " - " + STR2(3)

                DD(4) = Date.DaysInMonth((yy + 1), 1)
                STR1(4) = "01/01" + "/" + yy1.ToString()
                STR2(4) = DD(4).ToString() + "/01" + "/" + yy1.ToString()
                STR(4) = STR1(4) + " - " + STR2(4)

                DD(5) = Date.DaysInMonth((yy + 1), 2)
                STR1(5) = "01/02" + "/" + yy1.ToString()
                STR2(5) = DD(5).ToString() + "/02" + "/" + yy1.ToString()
                STR(5) = STR1(5) + " - " + STR2(5)

                DD(6) = Date.DaysInMonth((yy + 1), 3)
                STR1(6) = "01/03" + "/" + yy1.ToString()
                STR2(6) = DD(6).ToString() + "/03" + "/" + yy1.ToString()
                STR(6) = STR1(6) + " - " + STR2(6)

                DD(7) = Date.DaysInMonth((yy + 1), 4)
                STR1(7) = "01/04" + "/" + yy1.ToString()
                STR2(7) = DD(7).ToString() + "/04" + "/" + yy1.ToString()
                STR(7) = STR1(7) + " - " + STR2(7)

                DD(8) = Date.DaysInMonth((yy + 1), 5)
                STR1(8) = "01/05" + "/" + yy1.ToString()
                STR2(8) = DD(8).ToString() + "/05" + "/" + yy1.ToString()
                STR(8) = STR1(8) + " - " + STR2(8)

                DD(9) = Date.DaysInMonth((yy + 1), 6)
                STR1(9) = "01/06" + "/" + yy1.ToString()
                STR2(9) = DD(9).ToString() + "/06" + "/" + yy1.ToString()
                STR(9) = STR1(9) + " - " + STR2(9)

                DD(10) = Date.DaysInMonth((yy + 1), 7)
                STR1(10) = "01/07" + "/" + yy1.ToString()
                STR2(10) = DD(10).ToString() + "/07" + "/" + yy1.ToString()
                STR(10) = STR1(10) + " - " + STR2(10)

                DD(11) = Date.DaysInMonth((yy + 1), 8)
                STR1(11) = "01/08" + "/" + yy1.ToString()
                STR2(11) = DD(11).ToString() + "/08" + "/" + yy1.ToString()
                STR(11) = STR1(11) + " - " + STR2(11)


            ElseIf cstartingmonth = "October" Then

                DD(0) = Date.DaysInMonth(yy, 10)
                STR1(0) = "01/10" + "/" + yy.ToString()
                STR2(0) = DD(0).ToString() + "/10" + "/" + yy.ToString()
                STR(0) = STR1(0) + " - " + STR2(0)

                DD(1) = Date.DaysInMonth(yy, 11)
                STR1(1) = "01/11" + "/" + yy.ToString()
                STR2(1) = DD(1).ToString() + "/11" + "/" + yy.ToString()
                STR(1) = STR1(1) + " - " + STR2(1)

                DD(2) = Date.DaysInMonth(yy, 12)
                STR1(2) = "01/12" + "/" + yy.ToString()
                STR2(2) = DD(2).ToString() + "/12" + "/" + yy.ToString()
                STR(2) = STR1(2) + " - " + STR2(2)

                DD(3) = Date.DaysInMonth((yy + 1), 1)
                STR1(3) = "01/01" + "/" + yy1.ToString()
                STR2(3) = DD(3).ToString() + "/01" + "/" + yy1.ToString()
                STR(3) = STR1(3) + " - " + STR2(3)

                DD(4) = Date.DaysInMonth((yy + 1), 2)
                STR1(4) = "01/02" + "/" + yy1.ToString()
                STR2(4) = DD(4).ToString() + "/02" + "/" + yy1.ToString()
                STR(4) = STR1(4) + " - " + STR2(4)

                DD(5) = Date.DaysInMonth((yy + 1), 3)
                STR1(5) = "01/03" + "/" + yy1.ToString()
                STR2(5) = DD(5).ToString() + "/03" + "/" + yy1.ToString()
                STR(5) = STR1(5) + " - " + STR2(5)

                DD(6) = Date.DaysInMonth((yy + 1), 4)
                STR1(6) = "01/04" + "/" + yy1.ToString()
                STR2(6) = DD(6).ToString() + "/04" + "/" + yy1.ToString()
                STR(6) = STR1(6) + " - " + STR2(6)

                DD(7) = Date.DaysInMonth((yy + 1), 5)
                STR1(7) = "01/05" + "/" + yy1.ToString()
                STR2(7) = DD(7).ToString() + "/05" + "/" + yy1.ToString()
                STR(7) = STR1(7) + " - " + STR2(7)

                DD(8) = Date.DaysInMonth((yy + 1), 6)
                STR1(8) = "01/06" + "/" + yy1.ToString()
                STR2(8) = DD(8).ToString() + "/06" + "/" + yy1.ToString()
                STR(8) = STR1(8) + " - " + STR2(8)

                DD(9) = Date.DaysInMonth((yy + 1), 7)
                STR1(9) = "01/07" + "/" + yy1.ToString()
                STR2(9) = DD(9).ToString() + "/07" + "/" + yy1.ToString()
                STR(9) = STR1(9) + " - " + STR2(9)

                DD(10) = Date.DaysInMonth((yy + 1), 8)
                STR1(10) = "01/08" + "/" + yy1.ToString()
                STR2(10) = DD(10).ToString() + "/08" + "/" + yy1.ToString()
                STR(10) = STR1(10) + " - " + STR2(10)

                DD(11) = Date.DaysInMonth((yy + 1), 9)
                STR1(11) = "01/09" + "/" + yy1.ToString()
                STR2(11) = DD(11).ToString() + "/09" + "/" + yy1.ToString()
                STR(11) = STR1(11) + " - " + STR2(11)


            ElseIf cstartingmonth = "November" Then

                DD(0) = Date.DaysInMonth(yy, 11)
                STR1(0) = "01/11" + "/" + yy.ToString()
                STR2(0) = DD(0).ToString() + "/11" + "/" + yy.ToString()
                STR(0) = STR1(0) + " - " + STR2(0)

                DD(1) = Date.DaysInMonth(yy, 12)
                STR1(1) = "01/12" + "/" + yy.ToString()
                STR2(1) = DD(1).ToString() + "/12" + "/" + yy.ToString()
                STR(1) = STR1(1) + " - " + STR2(1)

                DD(2) = Date.DaysInMonth((yy + 1), 1)
                STR1(2) = "01/01" + "/" + yy1.ToString()
                STR2(2) = DD(2).ToString() + "/01" + "/" + yy1.ToString()
                STR(2) = STR1(2) + " - " + STR2(2)

                DD(3) = Date.DaysInMonth((yy + 1), 2)
                STR1(3) = "01/02" + "/" + yy1.ToString()
                STR2(3) = DD(3).ToString() + "/02" + "/" + yy1.ToString()
                STR(3) = STR1(3) + " - " + STR2(3)

                DD(4) = Date.DaysInMonth((yy + 1), 3)
                STR1(4) = "01/03" + "/" + yy1.ToString()
                STR2(4) = DD(4).ToString() + "/03" + "/" + yy1.ToString()
                STR(4) = STR1(4) + " - " + STR2(4)

                DD(5) = Date.DaysInMonth((yy + 1), 4)
                STR1(5) = "01/04" + "/" + yy1.ToString()
                STR2(5) = DD(5).ToString() + "/04" + "/" + yy1.ToString()
                STR(5) = STR1(5) + " - " + STR2(5)

                DD(6) = Date.DaysInMonth((yy + 1), 5)
                STR1(6) = "01/05" + "/" + yy1.ToString()
                STR2(6) = DD(6).ToString() + "/05" + "/" + yy1.ToString()
                STR(6) = STR1(6) + " - " + STR2(6)

                DD(7) = Date.DaysInMonth((yy + 1), 6)
                STR1(7) = "01/06" + "/" + yy1.ToString()
                STR2(7) = DD(7).ToString() + "/06" + "/" + yy1.ToString()
                STR(7) = STR1(7) + " - " + STR2(7)

                DD(8) = Date.DaysInMonth((yy + 1), 7)
                STR1(8) = "01/07" + "/" + yy1.ToString()
                STR2(8) = DD(8).ToString() + "/07" + "/" + yy1.ToString()
                STR(8) = STR1(8) + " - " + STR2(8)

                DD(9) = Date.DaysInMonth((yy + 1), 8)
                STR1(9) = "01/08" + "/" + yy1.ToString()
                STR2(9) = DD(9).ToString() + "/08" + "/" + yy1.ToString()
                STR(9) = STR1(9) + " - " + STR2(9)

                DD(10) = Date.DaysInMonth((yy + 1), 9)
                STR1(10) = "01/09" + "/" + yy1.ToString()
                STR2(10) = DD(10).ToString() + "/09" + "/" + yy1.ToString()
                STR(10) = STR1(10) + " - " + STR2(10)

                DD(11) = Date.DaysInMonth((yy + 1), 10)
                STR1(11) = "01/10" + "/" + yy1.ToString()
                STR2(11) = DD(11).ToString() + "/10" + "/" + yy1.ToString()
                STR(11) = STR1(11) + " - " + STR2(11)


            ElseIf cstartingmonth = "December" Then

                DD(0) = Date.DaysInMonth(yy, 12)
                STR1(0) = "01/12" + "/" + yy.ToString()
                STR2(0) = DD(0).ToString() + "/12" + "/" + yy.ToString()
                STR(0) = STR1(0) + " - " + STR2(0)

                DD(1) = Date.DaysInMonth((yy + 1), 1)
                STR1(1) = "01/01" + "/" + yy1.ToString()
                STR2(1) = DD(1).ToString() + "/01" + "/" + yy1.ToString()
                STR(1) = STR1(1) + " - " + STR2(1)

                DD(2) = Date.DaysInMonth((yy + 1), 2)
                STR1(2) = "01/02" + "/" + yy1.ToString()
                STR2(2) = DD(2).ToString() + "/02" + "/" + yy1.ToString()
                STR(2) = STR1(2) + " - " + STR2(2)

                DD(3) = Date.DaysInMonth((yy + 1), 3)
                STR1(3) = "01/03" + "/" + yy1.ToString()
                STR2(3) = DD(3).ToString() + "/03" + "/" + yy1.ToString()
                STR(3) = STR1(3) + " - " + STR2(3)

                DD(4) = Date.DaysInMonth((yy + 1), 4)
                STR1(4) = "01/04" + "/" + yy1.ToString()
                STR2(4) = DD(4).ToString() + "/04" + "/" + yy1.ToString()
                STR(4) = STR1(4) + " - " + STR2(4)

                DD(5) = Date.DaysInMonth((yy + 1), 5)
                STR1(5) = "01/05" + "/" + yy1.ToString()
                STR2(5) = DD(5).ToString() + "/05" + "/" + yy1.ToString()
                STR(5) = STR1(5) + " - " + STR2(5)

                DD(6) = Date.DaysInMonth((yy + 1), 6)
                STR1(6) = "01/06" + "/" + yy1.ToString()
                STR2(6) = DD(6).ToString() + "/06" + "/" + yy1.ToString()
                STR(6) = STR1(6) + " - " + STR2(6)

                DD(7) = Date.DaysInMonth((yy + 1), 7)
                STR1(7) = "01/07" + "/" + yy1.ToString()
                STR2(7) = DD(7).ToString() + "/07" + "/" + yy1.ToString()
                STR(7) = STR1(7) + " - " + STR2(7)

                DD(8) = Date.DaysInMonth((yy + 1), 8)
                STR1(8) = "01/08" + "/" + yy1.ToString()
                STR2(8) = DD(8).ToString() + "/08" + "/" + yy1.ToString()
                STR(8) = STR1(8) + " - " + STR2(8)

                DD(9) = Date.DaysInMonth((yy + 1), 9)
                STR1(9) = "01/09" + "/" + yy1.ToString()
                STR2(9) = DD(9).ToString() + "/09" + "/" + yy1.ToString()
                STR(9) = STR1(9) + " - " + STR2(9)

                DD(10) = Date.DaysInMonth((yy + 1), 10)
                STR1(10) = "01/10" + "/" + yy1.ToString()
                STR2(10) = DD(10).ToString() + "/10" + "/" + yy1.ToString()
                STR(10) = STR1(10) + " - " + STR2(10)

                DD(11) = Date.DaysInMonth((yy + 1), 11)
                STR1(11) = "01/11" + "/" + yy1.ToString()
                STR2(11) = DD(11).ToString() + "/11" + "/" + yy1.ToString()
                STR(11) = STR1(11) + " - " + STR2(11)

            End If
            For i As Integer = 0 To 11
                dgviewnewfiscalyear.Rows.Add()
                dgviewnewfiscalyear.Rows(i).Cells(0).Value = STR1(i)
                dgviewnewfiscalyear.Rows(i).Cells(1).Value = STR2(i)
            Next
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub NewFiscalPayrollYear()
        Dim mont1 As Integer = CInt(Date.Now.Month.ToString())
        Dim mont2 As Integer
        Dim Year1 As Integer
        Dim Year2 As Integer

        cmd.CommandText = "select StartDate,StartingMonth from Institute where InsID='" & My.Settings.LastOpenedInstituteID & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        cstartdate = dr("StartDate").ToString()
        cstartingmonth = dr("StartingMonth").ToString()
        dr.Close()

        If cstartingmonth = "January" Then
            mont2 = 1
        ElseIf cstartingmonth = "February" Then
            mont2 = 2
        ElseIf cstartingmonth = "March" Then
            mont2 = 3
        ElseIf cstartingmonth = "April" Then
            mont2 = 4
        ElseIf cstartingmonth = "May" Then
            mont2 = 5
        ElseIf cstartingmonth = "June" Then
            mont2 = 6
        ElseIf cstartingmonth = "July" Then
            mont2 = 7
        ElseIf cstartingmonth = "August" Then
            mont2 = 8
        ElseIf cstartingmonth = "September" Then
            mont2 = 9
        ElseIf cstartingmonth = "October" Then
            mont2 = 10
        ElseIf cstartingmonth = "November" Then
            mont2 = 11
        ElseIf cstartingmonth = "December" Then
            mont2 = 12
        End If
        If mont1 <= mont2 Then
            Year2 = CInt(Date.Now.Year.ToString()) + 1
            Year1 = Year2 - 1
        Else
            Year1 = CInt(Date.Now.Year.ToString()) + 1
            Year2 = Year1 + 1
        End If

        Dim str As String = Year1.ToString() + " - " + Year2.ToString()
        period = Year1.ToString() + " - " + Year2.ToString()

        If cstartingmonth = "January" Then
            Dim DD As Integer = Date.DaysInMonth(Year1, 12)
            Dim st As String = "01/01/" + Year1.ToString() + " - " + DD.ToString() + "/" + "12/" + Year1.ToString()
            lstnewfiscalyear1.Items.Add(st)
            lstnewfiscalyear2.Items.Add(st)
            lblnewperiod.Text = "Your current accounting period is: " + st
            lstnewpayrolltaxyear1.Items.Add(st)
            NextPeriod = st
        ElseIf cstartingmonth = "February" Then
            Dim DD As Integer = Date.DaysInMonth(Year1, 1)
            Dim st As String = "01/02/" + Year1.ToString() + " - " + DD.ToString() + "/" + "01/" + Year2.ToString()
            lstnewfiscalyear1.Items.Add(st)
            lstnewfiscalyear2.Items.Add(st)
            lblnewperiod.Text = "Your current accounting period is: " + st
            lstnewpayrolltaxyear1.Items.Add(st)
            NextPeriod = st
        ElseIf cstartingmonth = "March" Then
            Dim DD As Integer = Date.DaysInMonth(Year1, 2)
            Dim st As String = "01/03/" + Year1.ToString() + " - " + DD.ToString() + "/" + "02/" + Year2.ToString()
            lstnewfiscalyear1.Items.Add(st)
            lstnewfiscalyear2.Items.Add(st)
            lblnewperiod.Text = "Your current accounting period is: " + st
            lstnewpayrolltaxyear1.Items.Add(st)
            NextPeriod = st
        ElseIf cstartingmonth = "April" Then
            Dim DD As Integer = Date.DaysInMonth(Year1, 3)
            Dim st As String = "01/04/" + Year1.ToString() + " - " + DD.ToString() + "/" + "03/" + Year2.ToString()
            lstnewfiscalyear1.Items.Add(st)
            lstnewfiscalyear2.Items.Add(st)
            lblnewperiod.Text = "Your current accounting period is: " + st
            lstnewpayrolltaxyear1.Items.Add(st)
            NextPeriod = st
        ElseIf cstartingmonth = "May" Then
            Dim DD As Integer = Date.DaysInMonth(Year1, 4)
            Dim st As String = "01/05/" + Year1.ToString() + " - " + DD.ToString() + "/" + "04/" + Year2.ToString()
            lstnewfiscalyear1.Items.Add(st)
            lstnewfiscalyear2.Items.Add(st)
            lblnewperiod.Text = "Your current accounting period is: " + st
            lstnewpayrolltaxyear1.Items.Add(st)
            NextPeriod = st
        ElseIf cstartingmonth = "June" Then
            Dim DD As Integer = Date.DaysInMonth(Year1, 5)
            Dim st As String = "01/06/" + Year1.ToString() + " - " + DD.ToString() + "/" + "05/" + Year2.ToString()
            lstnewfiscalyear1.Items.Add(st)
            lstnewfiscalyear2.Items.Add(st)
            lblnewperiod.Text = "Your current accounting period is: " + st
            lstnewpayrolltaxyear1.Items.Add(st)
            NextPeriod = st
        ElseIf cstartingmonth = "July" Then
            Dim DD As Integer = Date.DaysInMonth(Year1, 6)
            Dim st As String = "01/07/" + Year1.ToString() + " - " + DD.ToString() + "/" + "06/" + Year2.ToString()
            lstnewfiscalyear1.Items.Add(st)
            lstnewfiscalyear2.Items.Add(st)
            lblnewperiod.Text = "Your current accounting period is: " + st
            lstnewpayrolltaxyear1.Items.Add(st)
            NextPeriod = st
        ElseIf cstartingmonth = "August" Then
            Dim DD As Integer = Date.DaysInMonth(Year1, 7)
            Dim st As String = "01/08/" + Year1.ToString() + " - " + DD.ToString() + "/" + "07/" + Year2.ToString()
            lstnewfiscalyear1.Items.Add(st)
            lstnewfiscalyear2.Items.Add(st)
            lblnewperiod.Text = "Your current accounting period is: " + st
            lstnewpayrolltaxyear1.Items.Add(st)
            NextPeriod = st
        ElseIf cstartingmonth = "September" Then
            Dim DD As Integer = Date.DaysInMonth(Year1, 8)
            Dim st As String = "01/09/" + Year1.ToString() + " - " + DD.ToString() + "/" + "08/" + Year2.ToString()
            lstnewfiscalyear1.Items.Add(st)
            lstnewfiscalyear2.Items.Add(st)
            lblnewperiod.Text = "Your current accounting period is: " + st
            lstnewpayrolltaxyear1.Items.Add(st)
            NextPeriod = st
        ElseIf cstartingmonth = "October" Then
            Dim DD As Integer = Date.DaysInMonth(Year1, 9)
            Dim st As String = "01/10/" + Year1.ToString() + " - " + DD.ToString() + "/" + "09/" + Year2.ToString()
            lstnewfiscalyear1.Items.Add(st)
            lstnewfiscalyear2.Items.Add(st)
            lblnewperiod.Text = "Your current accounting period is: " + st
            lstnewpayrolltaxyear1.Items.Add(st)
            NextPeriod = st
        ElseIf cstartingmonth = "November" Then
            Dim DD As Integer = Date.DaysInMonth(Year1, 10)
            Dim st As String = "01/11/" + Year1.ToString() + " - " + DD.ToString() + "/" + "10/" + Year2.ToString()
            lstnewfiscalyear1.Items.Add(st)
            lstnewfiscalyear2.Items.Add(st)
            lblnewperiod.Text = "Your current accounting period is: " + st
            lstnewpayrolltaxyear1.Items.Add(st)
            NextPeriod = st
        ElseIf cstartingmonth = "December" Then
            Dim DD As Integer = Date.DaysInMonth(Year1, 11)
            Dim st As String = "01/12/" + Year1.ToString() + " - " + DD.ToString() + "/" + "11/" + Year2.ToString()
            lstnewfiscalyear1.Items.Add(st)
            lstnewfiscalyear2.Items.Add(st)
            lblnewperiod.Text = "Your current accounting period is: " + st
            lstnewpayrolltaxyear1.Items.Add(st)
            NextPeriod = st
        End If
    End Sub

    Private Sub LoadUnpaidItems()
        Try
            Dim i As Integer = 0
            cmd.CommandText = "select purchaseid,purchasedate,duedate,vendorname,shipto,totalamount,paid from Purchase where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                If dr("paid").ToString() = "Unpaid" Then
                    dgviewreport.Rows.Add()
                    dgviewreport.Rows(i).Cells(0).Value = "Purchase:" + dr("purchaseid").ToString() + ", " + "Date: " + dr("purchasedate").ToString() + ", " + "Due Date: " + dr("duedate").ToString() + ", " + "From: " + dr("vendorname").ToString() + ", " + "Ship To: " + dr("shipto").ToString() + ", " + "Amount: " + dr("totalamount").ToString()
                    dgviewreport.Rows(i).Cells(1).Value = dr("paid").ToString()
                    i = i + 1
                End If
            End While
            dr.Close()
            cmd.CommandText = "select invoiceno,invoicedate,duedate,customername,totalamount,paid from SalesInvoice where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                If dr("paid").ToString() = "Unpaid" Then
                    dgviewreport.Rows.Add()
                    dgviewreport.Rows(i).Cells(0).Value = "Invoice:" + dr("invoiceno").ToString() + ", " + "Date: " + dr("invoicedate").ToString() + ", " + "Due Date: " + dr("duedate").ToString() + ", " + "To: " + dr("customername").ToString() + ", " + "Amount: " + dr("totalamount").ToString()
                    dgviewreport.Rows(i).Cells(1).Value = dr("paid").ToString()
                    i = i + 1
                End If
            End While
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#Region "Year-End Process..."
    Private Sub YearEndProcess()
        NewYearInstitute()
        NewYearFeatures()
        NewYearAchievements()
        NewYearFinancialYear()
        NewYearAccountingPeriod()
        NewYearAccounts()
        NewYearCourse()
        NewYearCourseTermFees()
        NewYearPFRate()
        NewYearProfessionalTax()
        NewYearDefaultInstitute()
        NewYearDefaultLibrary()
        NewYearDefaultPayroll()
        NewYearDepartment()
        NewYearDesignation()
        NewYearPayScale()
        NewYearPayslipHeaders()
        NewYearEmployee()
        NewYearEmployeeAcademic()
        NewYearEmployeeActivity()
        NewYearEmployeeLanguage()
        NewYearEmployeeProficiency()
        NewYearEmployeeProgrammingLang()
        NewYearEmployeeResearchExp()
        NewYearEmployeeTeachingExp()
        NewYearPF()
        NewYearHiredEmployee()
        NewYearRetiredEmployee()
        NewYearRetiredEmployeeAcademic()
        NewYearRetiredEmployeeActivity()
        NewYearRetiredEmployeeLanguage()
        NewYearRetiredEmployeeProficiency()
        NewYearRetiredEmployeeProgrammingLang()
        NewYearRetiredEmployeeResearchExp()
        NewYearRetiredEmployeeTeachingExp()
        NewYearRetiredPF()
        NewYearPFRateIndividual()
        NewYearCloseMembership()
        NewYearStudentRegistration()
        NewYearStudentDiscount()
        NewYearAlumni()
        NewYearInventory()
        NewYearInventoryItemPriceLevel()
        NewYearSubjects()
        NewYearSyllabus()
        NewYearGroupBooks()
        NewYearSubjectBooks()
        NewYearBooks()
        NewYearBookCharges()
        NewYearUsers()
        NewYearUserCrystalReport()
        If YearEndOk = True Then
            My.Settings.Period = NextPeriod
        End If
    End Sub
#Region "New Year Tables..."
    Private Sub NewYearInstitute()
        cmd.CommandText = "select FinancialYear,StartingMonth from Institute where InsID='" & My.Settings.LastOpenedInstituteID & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        Dim fy As Integer = CInt(dr("FinancialYear").ToString())
        Dim fm As String = dr("StartingMonth").ToString()
        dr.Close()
        fy += 1
        Dim sd As String
        If fm = "January" Then
            sd = "1/1/" + fy.ToString()
        ElseIf fm = "February" Then
            sd = "1/2/" + fy.ToString()
        ElseIf fm = "March" Then
            sd = "1/3/" + fy.ToString()
        ElseIf fm = "April" Then
            sd = "1/4/" + fy.ToString()
        ElseIf fm = "May" Then
            sd = "1/5/" + fy.ToString()
        ElseIf fm = "June" Then
            sd = "1/6/" + fy.ToString()
        ElseIf fm = "July" Then
            sd = "1/7/" + fy.ToString()
        ElseIf fm = "August" Then
            sd = "1/8/" + fy.ToString()
        ElseIf fm = "September" Then
            sd = "1/9/" + fy.ToString()
        ElseIf fm = "October" Then
            sd = "1/10/" + fy.ToString()
        ElseIf fm = "November" Then
            sd = "1/11/" + fy.ToString()
        ElseIf fm = "December" Then
            sd = "1/12/" + fy.ToString()
        End If
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from Institute where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessInstitute(dr("InsID").ToString(), period, dr("InsName").ToString(), dr("Address1").ToString(), dr("Address2").ToString(), dr("City").ToString(), dr("State").ToString(), dr("Pin").ToString(), dr("Country").ToString(), dr("Telephone").ToString(), dr("Fax").ToString(), dr("Email").ToString(), dr("Url1").ToString(), dr("Url2").ToString(), dr("Category").ToString(), dr("AccountingManagement").ToString(), NextPeriod, dr("FinancialMonth").ToString(), fy, sd, dr("StartingMonth").ToString())
        Next
    End Sub

    Private Sub NewYearFinancialYear()
        Dim indx As Integer
        cmd.CommandText = "select FiscalNo from FinancialYear where InsID='" & My.Settings.LastOpenedInstituteID & "'"
        indx = cmd.ExecuteScalar
        indx += 1
        For i = 0 To 11
            Dim j As Integer = i + 1
            cmd.CommandText = "insert into FinancialYear(InsID,Period,InsName,FiscalNo,Indexx,PeriodValue) values ('" & My.Settings.LastOpenedInstituteID & "','" & NextPeriod & "','" & My.Settings.LastOpenedInstitute & "'," & indx & "," & j & ",'" & STR(i) & "')"
            dr = cmd.ExecuteReader
            dr.Close()
        Next
    End Sub

    Private Sub NewYearCourse()
        Dim yy As Integer = Date.Now.Year
        yy += 1
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from Course where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessCourse(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, yy.ToString(), dr("CourseName").ToString(), dr("CourseCode").ToString(), dr("Duration").ToString(), CDec(dr("CourseFees").ToString()))
        Next
    End Sub

    Private Sub NewYearCourseTermFees()
        Dim yy As Integer = Date.Now.Year
        yy += 1
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from CourseTermFees where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessCourseTermFees(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, yy.ToString(), dr("Course").ToString(), dr("Terms").ToString(), CDec(dr("Fees").ToString()), CInt(dr("ForMonth").ToString()))
        Next
    End Sub

    Private Sub NewYearFeatures()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from Features where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessFeatures(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("Features").ToString())
        Next
    End Sub

    Private Sub NewYearAchievements()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from Achievements where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessAchievements(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("Achievements").ToString())
        Next
    End Sub

    Private Sub NewYearAccountingPeriod()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from AccountingPeriod where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessAccountingPeriod(dr("InsID").ToString(), dr("InsName").ToString(), period, NextPeriod)
        Next
    End Sub

    Private Sub NewYearAccounts()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from Accounts where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessAccounts(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("Type").ToString(), dr("AccountID").ToString(), dr("AccountName").ToString(), CDec(dr("AccountBalance").ToString()))
        Next
    End Sub

    Private Sub NewYearDefaultInstitute()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from DefaultInstitute where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessDefaultInstitute(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("alwayspurchase").ToString(), dr("invoicemessage").ToString(), dr("ordermessage").ToString(), dr("gameexpense").ToString(), dr("customfield1").ToString(), dr("customfield2").ToString(), dr("customfield3").ToString(), dr("customfield4").ToString(), dr("customfield5").ToString(), dr("checkcustomfield1").ToString(), dr("checkcustomfield2").ToString(), dr("checkcustomfield3").ToString(), dr("checkcustomfield4").ToString(), dr("checkcustomfield5").ToString(), dr("costmethod").ToString(), dr("stockglsalesacc").ToString(), dr("stockglinvacc").ToString(), dr("stockglcostacc").ToString(), dr("stockcostingacc").ToString(), dr("masterglsalesacc").ToString(), dr("masterglinvacc").ToString(), dr("masterglcostacc").ToString(), dr("mastercostingacc").ToString(), dr("nonstockglsalesacc").ToString(), dr("nonstockglinvacc").ToString(), dr("nonstockglcostacc").ToString(), dr("nonstockcostingacc").ToString(), dr("descriptionglsalesacc").ToString(), dr("descriptionglinvacc").ToString(), dr("descriptionglcostacc").ToString(), dr("descriptioncostingacc").ToString(), dr("serviceglsalesacc").ToString(), dr("serviceglinvacc").ToString(), dr("serviceglcostacc").ToString(), dr("servicecostingacc").ToString(), dr("laborglsalesacc").ToString(), dr("laborglinvacc").ToString(), dr("laborglcostacc").ToString(), dr("laborcostingacc").ToString(), dr("assemblyglsalesacc").ToString(), dr("assemblyglinvacc").ToString(), dr("assemblyglcostacc").ToString(), dr("assemblycostingacc").ToString(), dr("activitylsalesacc").ToString(), dr("activityglinvacc").ToString(), dr("activityglcostacc").ToString(), dr("activitycostingacc").ToString(), dr("chargeglsalesacc").ToString(), dr("chargeglinvacc").ToString(), dr("chargeglcostacc").ToString(), dr("chargecostingacc").ToString(), dr("glfreightacc").ToString(), dr("autoid").ToString(), CInt(dr("feesmonth").ToString()), dr("applydiscount").ToString(), dr("monthlyfeesacc").ToString(), dr("yearlyfeesacc").ToString(), dr("libraryfeesacc").ToString(), dr("latefeesacc").ToString(), dr("otherfeesacc").ToString(), dr("examfeesacc").ToString(), dr("discountfeesacc").ToString(), dr("bankdepositacc").ToString(), dr("purchaseorderacc").ToString(), dr("salesinvoiceacc").ToString())
        Next
    End Sub

    Private Sub NewYearDefaultLibrary()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from DefaultLibrary where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessDefaultLibrary(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("autoid").ToString(), dr("chargesaccount").ToString())
        Next
    End Sub

    Private Sub NewYearDefaultPayroll()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from DefaultPayroll where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessDefaultPayroll(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("autoid").ToString(), dr("salaryaccount").ToString(), CDec(dr("basicincr").ToString()))
        Next
    End Sub

    Private Sub NewYearEmployee()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from Employee where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dre As DataRow In dt.Rows
            ProcessEmployee(dre("InsID").ToString(), dre("InsName").ToString(), NextPeriod, dre("SystemDate").ToString(), dre("empid").ToString(), dre("namefirst").ToString(), dre("namemiddle").ToString(), dre("namelast").ToString(), dre("name").ToString(), dre("houseno").ToString(), dre("address").ToString(), dre("city").ToString(), dre("district").ToString(), dre("state").ToString(), dre("pin").ToString(), dre("country").ToString(), dre("phone").ToString(), dre("fax").ToString(), dre("dob").ToString(), dre("email").ToString(), dre("category").ToString(), dre("department").ToString(), dre("designation").ToString(), dre("married").ToString(), dre("sex").ToString(), dre("handicapped").ToString(), dre("presentposition").ToString(), dre("retirementdate").ToString(), dre("fulladdress").ToString(), dre("payinfo").ToString(), dre("payscale").ToString(), CDec(dre("grade").ToString()), CDec(dre("basic").ToString()), dre("joiningdate").ToString(), dre("phd").ToString(), dre("qualifiedtest").ToString(), dre("attachedcopy").ToString(), dre("incremented").ToString())
        Next
        For Each dre As DataRow In dt.Rows
            cmd.CommandText = "update Employee set picture=Employee.picture from Employee where InsID=@InsID and empid=@empid and Period=@Period"
            cmd.Parameters.AddWithValue("@InsID", dre("InsID").ToString())
            cmd.Parameters.AddWithValue("@empid", dre("empid").ToString())
            cmd.Parameters.AddWithValue("@Period", My.Settings.Period)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
        Next
    End Sub

    Private Sub NewYearEmployeeLanguage()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from EmployeeLanguage where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessEmployeeLanguage(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("empid").ToString(), dr("langname").ToString(), dr("canread").ToString(), dr("canwrite").ToString(), dr("canspeak").ToString(), dr("canconversation").ToString())
        Next
    End Sub

    Private Sub NewYearEmployeeAcademic()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from EmployeeAcademic where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessEmployeeAcademic(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("empid").ToString(), dr("degree").ToString(), CInt(dr("passingyear").ToString()), dr("subjects").ToString(), CDec(dr("percentagemarks").ToString()), dr("classdivision").ToString())
        Next
    End Sub

    Private Sub NewYearEmployeeTeachingExp()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from EmployeeTeachingExp where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessEmployeeTeachingExp(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("empid").ToString(), CInt(dr("totaltexpyear").ToString()), CInt(dr("totaltexpmonth").ToString()), dr("institution").ToString(), dr("designation").ToString(), CInt(dr("totalyears").ToString()), dr("ug").ToString(), dr("degree").ToString(), dr("pg").ToString())
        Next
    End Sub

    Private Sub NewYearEmployeeResearchExp()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from EmployeeResearchExp where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessEmployeeResearchExp(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("empid").ToString(), CInt(dr("totalrexpyear").ToString()), CInt(dr("totalrexpmonth").ToString()), dr("research").ToString(), dr("institution").ToString(), dr("topic").ToString(), dr("researchperiod").ToString())
        Next
    End Sub

    Private Sub NewYearEmployeeProficiency()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from EmployeeProficiency where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessEmployeeProficiency(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("empid").ToString(), dr("msword").ToString(), dr("msexcel").ToString(), dr("mspowerpoint").ToString(), dr("internet").ToString(), dr("knowemail").ToString(), dr("cmserp").ToString())
        Next
    End Sub

    Private Sub NewYearEmployeeProgrammingLang()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from EmployeeProgrammingLang where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessEmployeeProgrammingLang(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("empid").ToString(), dr("lang").ToString())
        Next
    End Sub

    Private Sub NewYearEmployeeActivity()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from EmployeeActivity where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessEmployeeActivity(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("empid").ToString(), dr("publishedbooks").ToString(), dr("publishedpaper").ToString(), dr("publishedarticles").ToString(), dr("seminar").ToString(), dr("adminisexp").ToString(), dr("otheractivities").ToString(), dr("poriodnotice").ToString(), dr("referee1").ToString(), dr("referee2").ToString(), dr("referee3").ToString(), dr("otherinfo").ToString())
        Next
    End Sub

    Private Sub NewYearHiredEmployee()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from HiredEmployee where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessHiredEmployee(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("empid").ToString(), dr("namefirst").ToString(), dr("namemiddle").ToString(), dr("namelast").ToString(), dr("name").ToString(), dr("houseno").ToString(), dr("address").ToString(), dr("city").ToString(), dr("district").ToString(), dr("state").ToString(), dr("pin").ToString(), dr("country").ToString(), dr("phone").ToString(), dr("fax").ToString(), dr("dob").ToString(), dr("email").ToString(), dr("category").ToString(), dr("department").ToString(), dr("designation").ToString(), dr("married").ToString(), dr("sex").ToString(), dr("handicapped").ToString(), dr("presentposition").ToString(), dr("retirementdate").ToString(), dr("fulladdress").ToString(), dr("payinfo").ToString(), CDec(dr("pay").ToString()), dr("joiningdate").ToString())
        Next
        For Each dre As DataRow In dt.Rows
            cmd.CommandText = "update HiredEmployee set picture=HiredEmployee.picture from HiredEmployee where InsID=@InsID and empid=@empid and Period=@Period"
            cmd.Parameters.AddWithValue("@InsID", dre("InsID").ToString())
            cmd.Parameters.AddWithValue("@empid", dre("empid").ToString())
            cmd.Parameters.AddWithValue("@Period", My.Settings.Period)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
        Next
    End Sub

    Private Sub NewYearRetiredEmployee()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from RetiredEmployee where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dre As DataRow In dt.Rows
            ProcessRetiredEmployee(dre("InsID").ToString(), dre("InsName").ToString(), NextPeriod, dre("SystemDate").ToString(), dre("empid").ToString(), dre("namefirst").ToString(), dre("namemiddle").ToString(), dre("namelast").ToString(), dre("name").ToString(), dre("houseno").ToString(), dre("address").ToString(), dre("city").ToString(), dre("district").ToString(), dre("state").ToString(), dre("pin").ToString(), dre("country").ToString(), dre("phone").ToString(), dre("fax").ToString(), dre("dob").ToString(), dre("email").ToString(), dre("category").ToString(), dre("department").ToString(), dre("designation").ToString(), dre("married").ToString(), dre("sex").ToString(), dre("handicapped").ToString(), dre("presentposition").ToString(), dre("retirementdate").ToString(), dre("fulladdress").ToString(), dre("payinfo").ToString(), dre("payscale").ToString(), CDec(dre("grade").ToString()), CDec(dre("basic").ToString()), dre("joiningdate").ToString(), dre("phd").ToString(), dre("qualifiedtest").ToString(), dre("attachedcopy").ToString(), dre("incremented").ToString())
        Next
        For Each dre As DataRow In dt.Rows
            cmd.CommandText = "update RetiredEmployee set picture=RetiredEmployee.picture from RetiredEmployee where InsID=@InsID and empid=@empid and Period=@Period"
            cmd.Parameters.AddWithValue("@InsID", dre("InsID").ToString())
            cmd.Parameters.AddWithValue("@empid", dre("empid").ToString())
            cmd.Parameters.AddWithValue("@Period", My.Settings.Period)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
        Next
    End Sub

    Private Sub NewYearRetiredEmployeeLanguage()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from RetiredEmployeeLanguage where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessRetiredEmployeeLanguage(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("empid").ToString(), dr("langname").ToString(), dr("canread").ToString(), dr("canwrite").ToString(), dr("canspeak").ToString(), dr("canconversation").ToString())
        Next
    End Sub

    Private Sub NewYearRetiredEmployeeAcademic()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from RetiredEmployeeAcademic where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessRetiredEmployeeAcademic(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("empid").ToString(), dr("degree").ToString(), CInt(dr("passingyear").ToString()), dr("subjects").ToString(), CDec(dr("percentagemarks").ToString()), dr("classdivision").ToString())
        Next
    End Sub

    Private Sub NewYearRetiredEmployeeTeachingExp()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from RetiredEmployeeTeachingExp where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessRetiredEmployeeTeachingExp(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("empid").ToString(), CInt(dr("totaltexpyear").ToString()), CInt(dr("totaltexpmonth").ToString()), dr("institution").ToString(), dr("designation").ToString(), CInt(dr("totalyears").ToString()), dr("ug").ToString(), dr("degree").ToString(), dr("pg").ToString())
        Next
    End Sub

    Private Sub NewYearRetiredEmployeeResearchExp()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from RetiredEmployeeResearchExp where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessRetiredEmployeeResearchExp(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("empid").ToString(), CInt(dr("totalrexpyear").ToString()), CInt(dr("totalrexpmonth").ToString()), dr("research").ToString(), dr("institution").ToString(), dr("topic").ToString(), dr("researchperiod").ToString())
        Next
    End Sub

    Private Sub NewYearRetiredEmployeeProficiency()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from RetiredEmployeeProficiency where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessRetiredEmployeeProficiency(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("empid").ToString(), dr("msword").ToString(), dr("msexcel").ToString(), dr("mspowerpoint").ToString(), dr("internet").ToString(), dr("knowemail").ToString(), dr("cmserp").ToString())
        Next
    End Sub

    Private Sub NewYearRetiredEmployeeProgrammingLang()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from RetiredEmployeeProgrammingLang where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessRetiredEmployeeProgrammingLang(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("empid").ToString(), dr("lang").ToString())
        Next
    End Sub

    Private Sub NewYearRetiredEmployeeActivity()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from RetiredEmployeeActivity where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessRetiredEmployeeActivity(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("empid").ToString(), dr("publishedbooks").ToString(), dr("publishedpaper").ToString(), dr("publishedarticles").ToString(), dr("seminar").ToString(), dr("adminisexp").ToString(), dr("otheractivities").ToString(), dr("poriodnotice").ToString(), dr("referee1").ToString(), dr("referee2").ToString(), dr("referee3").ToString(), dr("otherinfo").ToString())
        Next
    End Sub

    Private Sub NewYearStudentRegistration()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from StudentRegistration where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessStudentRegistration(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("serial").ToString(), CInt(dr("year").ToString()), dr("preadmitted").ToString(), dr("preadmissionid").ToString(), dr("course").ToString(), dr("approved").ToString(), dr("class").ToString(), CInt(dr("classint").ToString()), dr("classstring").ToString(), dr("fname").ToString(), dr("mname").ToString(), dr("lname").ToString(), dr("name").ToString(), dr("fgname").ToString(), dr("mothername").ToString(), dr("dob").ToString(), dr("sex").ToString(), CDec(dr("coursefee").ToString()), CDec(dr("annualincome").ToString()), dr("prehouseno").ToString(), dr("preaddress").ToString(), dr("precity").ToString(), dr("prepost").ToString(), dr("predist").ToString(), dr("prestate").ToString(), dr("prepin").ToString(), dr("precountry").ToString(), dr("perhouseno").ToString(), dr("peraddress").ToString(), dr("percity").ToString(), dr("perpost").ToString(), dr("perdist").ToString(), dr("perstate").ToString(), dr("perpin").ToString(), dr("percountry").ToString(), dr("profcourse").ToString(), dr("profcourseduration").ToString(), CInt(dr("profcourseyear").ToString()), dr("institute").ToString(), dr("recognized").ToString(), dr("instituteaddress").ToString(), dr("institutephone").ToString(), dr("institutefax").ToString(), dr("instituteuniv").ToString(), dr("payeename").ToString(), dr("bankname").ToString(), dr("bankbrach").ToString(), dr("branchaddress").ToString(), dr("branchcode").ToString(), dr("accountno").ToString(), dr("accounttype").ToString(), dr("micrcode").ToString(), dr("electronictransfer").ToString(), dr("cardholdername").ToString(), dr("cardaddress").ToString(), dr("cardcity").ToString(), dr("cardstate").ToString(), dr("cardpin").ToString(), dr("cardcountry").ToString(), dr("cardtype").ToString(), dr("payvia").ToString(), dr("cardno").ToString(), CInt(dr("expmm").ToString()), CInt(dr("expyy").ToString()), dr("email").ToString(), dr("homephone").ToString(), dr("workphone").ToString(), dr("fax").ToString(), dr("stuid").ToString(), dr("roll").ToString(), dr("time").ToString(), dr("tuition").ToString(), dr("emergencyname").ToString(), dr("emergencyhomeph").ToString(), dr("emergencyworkph").ToString(), dr("emergencyfax").ToString(), dr("emergencyrelation").ToString(), dr("emergencyaddress").ToString())
        Next
        For Each dre As DataRow In dt.Rows
            cmd.CommandText = "update StudentRegistration set picture=StudentRegistration.picture from StudentRegistration where InsID=@InsID and stuid=@stuid and Period=@Period"
            cmd.Parameters.AddWithValue("@InsID", dre("InsID").ToString())
            cmd.Parameters.AddWithValue("@stuid", dre("stuid").ToString())
            cmd.Parameters.AddWithValue("@Period", My.Settings.Period)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
        Next
    End Sub

    Private Sub NewYearStudentDiscount()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from StudentDiscount where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessStudentDiscount(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("year").ToString(), dr("course").ToString(), dr("class").ToString(), dr("roll").ToString(), dr("stuid").ToString(), dr("name").ToString(), CDec(dr("discountname").ToString()))
        Next
    End Sub

    Private Sub NewYearSubjects()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from Subjects where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessSubjects(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("course").ToString(), dr("coursecode").ToString(), dr("haspractical").ToString(), dr("gensubject").ToString(), dr("gensubjectduration").ToString(), dr("gensubjectcode").ToString(), CInt(dr("gensubjectyear").ToString()), dr("gensubjectsemestar").ToString(), dr("pracsubject").ToString(), dr("pracsubjectduration").ToString(), dr("pracsubjectcode").ToString(), CInt(dr("pracsubjectyear").ToString()), dr("pracsubjectsemestar").ToString())
        Next
    End Sub

    Private Sub NewYearSyllabus()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from Syllabus where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessSyllabus(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("course").ToString(), dr("coursecode").ToString(), dr("subject").ToString(), dr("subjectcode").ToString(), dr("forstudent").ToString(), dr("chapter").ToString(), dr("chapterdetails").ToString(), CInt(dr("totalmarks").ToString()), CInt(dr("marksobtained").ToString()), CInt(dr("totalclass").ToString()), CInt(dr("class").ToString()))
        Next
    End Sub

    Private Sub NewYearAlumni()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from Alumni where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessAlumni(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("serial").ToString(), CInt(dr("alumniyear").ToString()), CInt(dr("year").ToString()), dr("preadmitted").ToString(), dr("preadmissionid").ToString(), dr("course").ToString(), dr("approved").ToString(), dr("class").ToString(), CInt(dr("classint").ToString()), dr("classstring").ToString(), dr("fname").ToString(), dr("mname").ToString(), dr("lname").ToString(), dr("name").ToString(), dr("fgname").ToString(), dr("mothername").ToString(), dr("dob").ToString(), dr("sex").ToString(), CDec(dr("coursefee").ToString()), CDec(dr("annualincome").ToString()), dr("prehouseno").ToString(), dr("preaddress").ToString(), dr("precity").ToString(), dr("prepost").ToString(), dr("predist").ToString(), dr("prestate").ToString(), dr("prepin").ToString(), dr("precountry").ToString(), dr("perhouseno").ToString(), dr("peraddress").ToString(), dr("percity").ToString(), dr("perpost").ToString(), dr("perdist").ToString(), dr("perstate").ToString(), dr("perpin").ToString(), dr("percountry").ToString(), dr("profcourse").ToString(), dr("profcourseduration").ToString(), CInt(dr("profcourseyear").ToString()), dr("institute").ToString(), dr("recognized").ToString(), dr("instituteaddress").ToString(), dr("institutephone").ToString(), dr("institutefax").ToString(), dr("instituteuniv").ToString(), dr("payeename").ToString(), dr("bankname").ToString(), dr("bankbrach").ToString(), dr("branchaddress").ToString(), dr("branchcode").ToString(), dr("accountno").ToString(), dr("accounttype").ToString(), dr("micrcode").ToString(), dr("electronictransfer").ToString(), dr("cardholdername").ToString(), dr("cardaddress").ToString(), dr("cardcity").ToString(), dr("cardstate").ToString(), dr("cardpin").ToString(), dr("cardcountry").ToString(), dr("cardtype").ToString(), dr("payvia").ToString(), dr("cardno").ToString(), CInt(dr("expmm").ToString()), CInt(dr("expyy").ToString()), dr("email").ToString(), dr("homephone").ToString(), dr("workphone").ToString(), dr("fax").ToString(), dr("stuid").ToString(), dr("roll").ToString(), dr("time").ToString(), dr("tuition").ToString(), dr("emergencyname").ToString(), dr("emergencyhomeph").ToString(), dr("emergencyworkph").ToString(), dr("emergencyfax").ToString(), dr("emergencyrelation").ToString(), dr("emergencyaddress").ToString())
        Next
        For Each dre As DataRow In dt.Rows
            cmd.CommandText = "update Alumni set picture=Alumni.picture where from Alumni InsID=@InsID and stuid=@stuid and Period=@Period"
            cmd.Parameters.AddWithValue("@InsID", dre("InsID").ToString())
            cmd.Parameters.AddWithValue("@stuid", dre("stuid").ToString())
            cmd.Parameters.AddWithValue("@Period", My.Settings.Period)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
        Next
    End Sub

    Private Sub NewYearInventory()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from Inventory where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessInventory(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("itemid").ToString(), dr("itemnote").ToString(), dr("itemname").ToString(), dr("itemclass").ToString(), dr("descshort").ToString(), dr("itemsize").ToString(), dr("itemshape").ToString(), dr("itemused").ToString(), dr("descripbrief").ToString(), CDec(dr("levelprice").ToString()), CDec(dr("onhandqnty").ToString()), dr("onhandqntyunit").ToString(), CDec(dr("lastsoldprice").ToString()), dr("costmethod").ToString(), CDec(dr("minstockqnty").ToString()), dr("minstockqntyunit").ToString(), dr("itemtaxtype").ToString(), dr("itemtype").ToString(), dr("stocking").ToString(), CDec(dr("weight").ToString()), dr("weightunit").ToString(), dr("vendorname").ToString(), dr("glsalesaccountid").ToString(), dr("glinventoryaccountid").ToString(), dr("glcostsaccountid").ToString(), dr("costingaccountid").ToString(), dr("customfield1").ToString(), dr("customfield2").ToString(), dr("customfield3").ToString(), dr("customfield4").ToString(), dr("customfield5").ToString(), dr("inactive").ToString(), dr("commission").ToString(), CDec(dr("UnitPrice").ToString()))
        Next
    End Sub

    Private Sub NewYearInventoryItemPriceLevel()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from InventoryItemPriceLevel where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessInventoryItemPriceLevel(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("itemid").ToString(), dr("itemname").ToString(), dr("itemdesc").ToString(), CDec(dr("levelprice1").ToString()), CDec(dr("levelprice2").ToString()), CDec(dr("levelprice3").ToString()), CDec(dr("levelprice4").ToString()), CDec(dr("levelprice5").ToString()), CDec(dr("levelprice6").ToString()), CDec(dr("levelprice7").ToString()), CDec(dr("levelprice8").ToString()), CDec(dr("levelprice9").ToString()), CDec(dr("levelprice10").ToString()), dr("defaultlevel").ToString())
        Next
    End Sub

    Private Sub NewYearGroupBooks()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from GroupBooks where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessGroupBooks(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("groupid").ToString(), dr("groupname").ToString(), dr("groupdetails").ToString())
        Next
    End Sub

    Private Sub NewYearSubjectBooks()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from SubjectBooks where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessSubjectBooks(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("subjectid").ToString(), dr("subjectname").ToString(), dr("subjectdetails").ToString())
        Next
    End Sub

    Private Sub NewYearBooks()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from Books where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessBooks(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("bookid").ToString(), dr("bookname").ToString(), dr("groupname").ToString(), dr("subject").ToString(), dr("publisher").ToString(), dr("author").ToString(), dr("edition").ToString(), CInt(dr("copies").ToString()), CInt(dr("pages").ToString()), CDec(dr("price").ToString()), dr("particulars").ToString())
        Next
    End Sub

    Private Sub NewYearBookCharges()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from BookCharges where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessBookCharges(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("course").ToString(), dr("referencebooks").ToString(), CDec(dr("finerate").ToString()), CInt(dr("reserveperiod").ToString()), CInt(dr("maxbooks").ToString()), CInt(dr("booksreturndays").ToString()), CInt(dr("maxjournal").ToString()), CInt(dr("journalreturndays").ToString()), CInt(dr("maxcompbook").ToString()), CInt(dr("compbookreturndays").ToString()), CInt(dr("lockerperiod").ToString()), CDec(dr("lockerfees").ToString()), CDec(dr("losingcardcharge").ToString()), CDec(dr("lockerfine").ToString()), CDec(dr("losingjournalcharge").ToString()), CDec(dr("idcardcharge").ToString()))
        Next
    End Sub

    Private Sub NewYearDepartment()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from Department where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessDepartment(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("deptid").ToString(), dr("deptname").ToString())
        Next
    End Sub

    Private Sub NewYearDesignation()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from Designation where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessDesignation(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("desigid").ToString(), dr("designame").ToString())
        Next
    End Sub

    Private Sub NewYearPayScale()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from PayScale where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessPayScale(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("pbname").ToString(), CDec(dr("pblower").ToString()), CDec(dr("pbupper").ToString()), CDec(dr("pbgrade").ToString()), CDec(dr("pbbasic").ToString()), dr("payscale").ToString())
        Next
    End Sub

    Private Sub NewYearProfessionalTax()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from ProfessionalTax where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessProfessionalTax(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, CDec(dr("gross").ToString()), CDec(dr("taxrate").ToString()))
        Next
    End Sub

    Private Sub NewYearPayslipHeaders()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from PayslipHeaders where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessPayslipHeaders(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("allowancedesc1").ToString(), dr("allowanceshortdesc1").ToString(), dr("allowancedesc2").ToString(), dr("allowanceshortdesc2").ToString(), dr("allowancedesc3").ToString(), dr("allowanceshortdesc3").ToString(), dr("allowancedesc4").ToString(), dr("allowanceshortdesc4").ToString(), dr("deductiondesc1").ToString(), dr("deductionshortdesc1").ToString(), dr("deductiondesc2").ToString(), dr("deductionshortdesc2").ToString(), dr("deductiondesc3").ToString(), dr("deductionshortdesc3").ToString(), dr("signatorydesc1").ToString(), dr("signatoryshortdesc1").ToString(), dr("signatorydesc2").ToString(), dr("signatoryshortdesc2").ToString(), dr("signatorydesc3").ToString(), dr("signatoryshortdesc3").ToString())
        Next
    End Sub

    Private Sub NewYearPFRate()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from PFRate where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessPFRate(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, CInt(dr("year").ToString()), CDec(dr("rate").ToString()), CDec(dr("amount").ToString()))
        Next
    End Sub

    Private Sub NewYearPFRateIndividual()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from PFRateIndividual where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessPFRateIndividual(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, CInt(dr("year").ToString()), dr("regno").ToString(), dr("name").ToString(), CDec(dr("rate").ToString()), CDec(dr("amount").ToString()))
        Next
    End Sub

    Private Sub NewYearPF()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from PF where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessPF(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("regno").ToString(), dr("designation").ToString(), dr("name").ToString(), dr("joiningdate").ToString(), CDec(dr("openingbalance").ToString()), CDec(dr("outstandingadvance").ToString()))
        Next
    End Sub

    Private Sub NewYearRetiredPF()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from RetiredPF where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessRetiredPF(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("regno").ToString(), dr("designation").ToString(), dr("name").ToString(), dr("joiningdate").ToString(), CDec(dr("openingbalance").ToString()), CDec(dr("outstandingadvance").ToString()))
        Next
    End Sub

    Private Sub NewYearCloseMembership()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from CloseMembership where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessCloseMembership(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("regno").ToString(), dr("name").ToString(), CDec(dr("closingbal").ToString()), CDec(dr("outstanding").ToString()), dr("closingdate").ToString())
        Next
    End Sub

    Private Sub NewYearUsers()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from Users where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessUsers(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("SystemDate").ToString(), dr("userno").ToString(), dr("userrole").ToString(), dr("userid").ToString(), dr("userpasswd").ToString(), dr("useraccess").ToString(), dr("employeeinfo").ToString(), dr("employeecard").ToString(), dr("attendances").ToString(), dr("idcard").ToString(), dr("notices").ToString(), dr("studentcontrol").ToString(), dr("backuprestore").ToString(), dr("importexport").ToString(), dr("studentinfo").ToString(), dr("studentcard").ToString(), dr("preadmission").ToString(), dr("admission").ToString(), dr("registration").ToString(), dr("feesterms").ToString(), dr("bankinginfo").ToString(), dr("feescollection").ToString(), dr("discount").ToString(), dr("incomeexpenditure").ToString(), dr("accounting").ToString(), dr("financialloan").ToString(), dr("coursesubject").ToString(), dr("examination").ToString(), dr("progressreport").ToString(), dr("marksheet").ToString(), dr("messenger").ToString(), dr("globalaccess").ToString(), dr("alumni").ToString(), dr("certificates").ToString(), dr("purchaseorder").ToString(), dr("inventory").ToString(), dr("salesinvoice").ToString(), dr("games").ToString(), dr("bookrecords").ToString(), dr("charges").ToString(), dr("issuebooks").ToString(), dr("returnbooks").ToString(), dr("payrollsystem").ToString(), dr("payrollperiodic").ToString(), dr("payrollpf").ToString(), dr("institutedefault").ToString(), dr("librarydefault").ToString(), dr("payrolldefault").ToString(), dr("revenueyeartodate").ToString(), dr("yearend").ToString())
        Next
    End Sub

    Private Sub NewYearUserCrystalReport()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from UserCrystalReport where InsID='" & My.Settings.LastOpenedInstituteID & "'", conn)
        da.Fill(dt)
        For Each dr As DataRow In dt.Rows
            ProcessUserCrystalReport(dr("InsID").ToString(), dr("InsName").ToString(), NextPeriod, dr("crystalreport").ToString(), dr("crystalreportid").ToString())
        Next
    End Sub
#End Region
#Region "Process Tables..."
    Private Sub ProcessInstitute(ByVal InsID As String, ByVal periodd As String, ByVal InsName As String, ByVal Address1 As String, ByVal Address2 As String, ByVal City As String, ByVal State As String, ByVal Pin As String, ByVal Country As String, ByVal Telephone As String, ByVal Fax As String, ByVal Email As String, ByVal Url1 As String, ByVal Url2 As String, ByVal Category As String, ByVal AccountingManagement As String, ByVal FinancialPeriod As String, ByVal FinancialMonth As String, ByVal FinancialYear As Integer, ByVal StartDate As String, ByVal StartingMonth As String)
        Try
            cmd.CommandText = "insert into Institute(InsID,period,InsName,Address1,Address2,City,State,Pin,Country,Telephone,Fax,Email,Url1,Url2,Category,AccountingManagement,FinancialPeriod,FinancialMonth,FinancialYear,StartDate,StartingMonth) values ('" & InsID & "','" & periodd & "','" & InsName & "','" & Address1 & "','" & Address2 & "','" & City & "','" & State & "','" & Pin & "','" & Country & "','" & Telephone & "','" & Fax & "','" & Email & "','" & Url1 & "','" & Url2 & "','" & Category & "','" & AccountingManagement & "','" & FinancialPeriod & "','" & FinancialMonth & "'," & FinancialYear & ",'" & StartDate & "','" & StartingMonth & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessFinancialYear(ByVal InsID As String, ByVal Periodd As String, ByVal InsName As String, ByVal FiscalNo As Integer, ByVal Indexx As Integer, ByVal PeriodValue As String)
        Try
            cmd.CommandText = "insert into FinancialYear(InsID,Period,InsName,FiscalNo,Indexx,PeriodValue) values ('" & InsID & "','" & Periodd & "','" & InsName & "'," & FiscalNo & "," & Indexx & ",'" & PeriodValue & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessCourse(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal year As String, ByVal CourseName As String, ByVal CourseCode As String, ByVal Duration As String, ByVal CFees As Decimal)
        Try
            cmd.CommandText = "insert into Course(InsID,InsName,Period,year,CourseName,CourseCode,Duration,CourseFees) values ('" & InsID & "','" & InsName & "','" & Periodd & "'," & year & ",'" & CourseName & "','" & CourseCode & "','" & Duration & "'," & CFees & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessCourseTermFees(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal year As String, ByVal Course As String, ByVal Terms As String, ByVal CFees As Decimal, ByVal ForMonth As Integer)
        Try
            cmd.CommandText = "insert into CourseTermFees(InsID,InsName,Period,year,Course,Terms,Fees,ForMonth) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & year & "','" & Course & "','" & Terms & "'," & CFees & "," & ForMonth & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessFeatures(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal Features As String)
        Try
            cmd.CommandText = "insert into Features(InsID,InsName,Period,Features) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & Features & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessAchievements(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal Achievements As String)
        Try
            cmd.CommandText = "insert into Achievements(InsID,InsName,Period,Achievements) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & Achievements & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessAccountingPeriod(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal FinancialPeriod As String)
        Try
            cmd.CommandText = "insert into AccountingPeriod(InsID,InsName,Period,FinancialPeriod) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & FinancialPeriod & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessAccounts(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal AccountID As String, ByVal AccountName As String, ByVal AccountType As String, ByVal AccountBalance As Decimal)
        Try
            cmd.CommandText = "insert into Accounts(InsID,InsName,Period,Type,AccountID,AccountName,AccountBalance) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & AccountType & "','" & AccountID & "','" & AccountName & "'," & AccountBalance & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessDefaultInstitute(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal alwayspurchase As String, ByVal invoicemessage As String, ByVal ordermessage As String, ByVal gameexpense As String, ByVal customfield1 As String, ByVal customfield2 As String, ByVal customfield3 As String, ByVal customfield4 As String, ByVal customfield5 As String, ByVal checkcustomfield1 As String, ByVal checkcustomfield2 As String, ByVal checkcustomfield3 As String, ByVal checkcustomfield4 As String, ByVal checkcustomfield5 As String, ByVal costmethod As String, ByVal stockglsalesacc As String, ByVal stockglinvacc As String, ByVal stockglcostacc As String, ByVal stockcostingacc As String, ByVal masterglsalesacc As String, ByVal masterglinvacc As String, ByVal masterglcostacc As String, ByVal mastercostingacc As String, ByVal nonstockglsalesacc As String, ByVal nonstockglinvacc As String, ByVal nonstockglcostacc As String, ByVal nonstockcostingacc As String, ByVal descriptionglsalesacc As String, ByVal descriptionglinvacc As String, ByVal descriptionglcostacc As String, ByVal descriptioncostingacc As String, ByVal serviceglsalesacc As String, ByVal serviceglinvacc As String, ByVal serviceglcostacc As String, ByVal servicecostingacc As String, ByVal laborglsalesacc As String, ByVal laborglinvacc As String, ByVal laborglcostacc As String, ByVal laborcostingacc As String, ByVal assemblyglsalesacc As String, ByVal assemblyglinvacc As String, ByVal assemblyglcostacc As String, ByVal assemblycostingacc As String, ByVal activitylsalesacc As String, ByVal activityglinvacc As String, ByVal activityglcostacc As String, ByVal activitycostingacc As String, ByVal chargeglsalesacc As String, ByVal chargeglinvacc As String, ByVal chargeglcostacc As String, ByVal chargecostingacc As String, ByVal glfreightacc As String, ByVal autoid As String, ByVal feesmonth As Integer, ByVal applydiscount As String, ByVal monthlyfeesacc As String, ByVal yearlyfeesacc As String, ByVal libraryfeesacc As String, ByVal latefeesacc As String, ByVal otherfeesacc As String, ByVal examfeesacc As String, ByVal discountfeesacc As String, ByVal bankdepositacc As String, ByVal purchaseorderacc As String, ByVal salesinvoiceacc As String)
        Try
            cmd.CommandText = "insert into DefaultInstitute(InsID,InsName,Period,alwayspurchase,invoicemessage,ordermessage,gameexpense,customfield1,customfield2,customfield3,customfield4,customfield5,checkcustomfield1,checkcustomfield2,checkcustomfield3,checkcustomfield4,checkcustomfield5,costmethod,stockglsalesacc,stockglinvacc,stockglcostacc,stockcostingacc,masterglsalesacc,masterglinvacc,masterglcostacc,mastercostingacc,nonstockglsalesacc,nonstockglinvacc,nonstockglcostacc,nonstockcostingacc,descriptionglsalesacc,descriptionglinvacc,descriptionglcostacc,descriptioncostingacc,serviceglsalesacc,serviceglinvacc,serviceglcostacc,servicecostingacc,laborglsalesacc,laborglinvacc,laborglcostacc,laborcostingacc,assemblyglsalesacc,assemblyglinvacc,assemblyglcostacc,assemblycostingacc,activitylsalesacc,activityglinvacc,activityglcostacc,activitycostingacc,chargeglsalesacc,chargeglinvacc,chargeglcostacc,chargecostingacc,glfreightacc,autoid,feesmonth,applydiscount,monthlyfeesacc,yearlyfeesacc,libraryfeesacc,latefeesacc,otherfeesacc,examfeesacc,discountfeesacc,bankdepositacc,purchaseorderacc,salesinvoiceacc) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & alwayspurchase & "','" & invoicemessage & "','" & ordermessage & "','" & gameexpense & "','" & customfield1 & "','" & customfield2 & "','" & customfield3 & "','" & customfield4 & "','" & customfield5 & "','" & checkcustomfield1 & "','" & checkcustomfield2 & "','" & checkcustomfield3 & "','" & checkcustomfield4 & "','" & checkcustomfield5 & "','" & costmethod & "','" & stockglsalesacc & "','" & stockglinvacc & "','" & stockglcostacc & "','" & stockcostingacc & "','" & masterglsalesacc & "','" & masterglinvacc & "','" & masterglcostacc & "','" & mastercostingacc & "','" & nonstockglsalesacc & "','" & nonstockglinvacc & "','" & nonstockglcostacc & "','" & nonstockcostingacc & "','" & descriptionglsalesacc & "','" & descriptionglinvacc & "','" & descriptionglcostacc & "','" & descriptioncostingacc & "','" & serviceglsalesacc & "','" & serviceglinvacc & "','" & serviceglcostacc & "','" & servicecostingacc & "','" & laborglsalesacc & "','" & laborglinvacc & "','" & laborglcostacc & "','" & laborcostingacc & "','" & assemblyglsalesacc & "','" & assemblyglinvacc & "','" & assemblyglcostacc & "','" & assemblycostingacc & "','" & activitylsalesacc & "','" & activityglinvacc & "','" & activityglcostacc & "','" & activitycostingacc & "','" & chargeglsalesacc & "','" & chargeglinvacc & "','" & chargeglcostacc & "','" & chargecostingacc & "','" & glfreightacc & "','" & autoid & "'," & feesmonth & ",'" & applydiscount & "','" & monthlyfeesacc & "','" & yearlyfeesacc & "','" & libraryfeesacc & "','" & latefeesacc & "','" & otherfeesacc & "','" & examfeesacc & "','" & discountfeesacc & "','" & bankdepositacc & "','" & purchaseorderacc & "','" & salesinvoiceacc & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessDefaultLibrary(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal autoid As String, ByVal chargesaccount As String)
        Try
            cmd.CommandText = "insert into DefaultLibrary(InsID,InsName,Period,autoid,chargesaccount) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & autoid & "','" & chargesaccount & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessDefaultPayroll(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal autoid As String, ByVal salaryaccount As String, ByVal basicincr As Decimal)
        Try
            cmd.CommandText = "insert into DefaultPayroll(InsID,InsName,Period,autoid,salaryaccount,basicincr) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & autoid & "','" & salaryaccount & "'," & basicincr & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessEmployee(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal namefirst As String, ByVal namemiddle As String, ByVal namelast As String, ByVal name As String, ByVal houseno As String, ByVal address As String, ByVal city As String, ByVal district As String, ByVal state As String, ByVal pin As String, ByVal country As String, ByVal phone As String, ByVal fax As String, ByVal dob As String, ByVal email As String, ByVal category As String, ByVal department As String, ByVal designation As String, ByVal married As String, ByVal sex As String, ByVal handicapped As String, ByVal presentposition As String, ByVal retirementdate As String, ByVal fulladdress As String, ByVal payinfo As String, ByVal payscale As String, ByVal grade As Decimal, ByVal basic As Decimal, ByVal joiningdate As String, ByVal phd As String, ByVal qualifiedtest As String, ByVal attachedcopy As String, ByVal incremented As String)
        Try
            cmd.CommandText = "insert into Employee(InsID,InsName,Period,SystemDate,empid,namefirst,namemiddle,namelast,name,houseno,address,city,district,state,pin,country,phone,fax,dob,email,category,department,designation,married,sex,handicapped,presentposition,retirementdate,fulladdress,payinfo,payscale,grade,basic,joiningdate,phd,qualifiedtest,attachedcopy,incremented) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & namefirst & "','" & namemiddle & "','" & namelast & "','" & name & "','" & houseno & "','" & address & "','" & city & "','" & district & "','" & state & "','" & pin & "','" & country & "','" & phone & "','" & fax & "','" & dob & "','" & email & "','" & category & "','" & department & "','" & designation & "','" & married & "','" & sex & "','" & handicapped & "','" & presentposition & "','" & retirementdate & "','" & fulladdress & "','" & payinfo & "','" & payscale & "'," & grade & "," & basic & ",'" & joiningdate & "','" & phd & "','" & qualifiedtest & "','" & attachedcopy & "','" & incremented & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessEmployeeLanguage(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal langname As String, ByVal canread As String, ByVal canwrite As String, ByVal canspeak As String, ByVal canconversation As String)
        Try
            cmd.CommandText = "insert into EmployeeLanguage(InsID,InsName,Period,SystemDate,empid,langname,canread,canwrite,canspeak,canconversation) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & langname & "','" & canread & "','" & canwrite & "','" & canspeak & "','" & canconversation & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessEmployeeAcademic(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal degree As String, ByVal passingyear As Integer, ByVal subjects As String, ByVal percentagemarks As Decimal, ByVal classdivision As String)
        Try
            cmd.CommandText = "insert into EmployeeAcademic(InsID,InsName,Period,SystemDate,empid,degree,passingyear,subjects,percentagemarks,classdivision) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & degree & "'," & passingyear & ",'" & subjects & "'," & percentagemarks & ",'" & classdivision & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessEmployeeTeachingExp(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal totaltexpyear As Integer, ByVal totaltexpmonth As Integer, ByVal institution As String, ByVal designation As String, ByVal totalyears As Integer, ByVal ug As String, ByVal degree As String, ByVal pg As String)
        Try
            cmd.CommandText = "insert into EmployeeTeachingExp(InsID,InsName,Period,SystemDate,empid,totaltexpyear,totaltexpmonth,institution,designation,totalyears,ug,degree,pg) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "'," & totaltexpyear & "," & totaltexpmonth & ",'" & institution & "','" & designation & "'," & totalyears & ",'" & ug & "','" & degree & "','" & pg & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessEmployeeResearchExp(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal totalrexpyear As Integer, ByVal totalrexpmonth As Integer, ByVal research As String, ByVal institution As String, ByVal topic As String, ByVal researchperiod As String)
        Try
            cmd.CommandText = "insert into EmployeeResearchExp(InsID,InsName,Period,SystemDate,empid,totalrexpyear,totalrexpmonth,research,institution,topic,researchperiod) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "'," & totalrexpyear & "," & totalrexpmonth & ",'" & research & "','" & institution & "','" & topic & "','" & researchperiod & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessEmployeeProficiency(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal msword As String, ByVal msexcel As String, ByVal mspowerpoint As String, ByVal internet As String, ByVal knowemail As String, ByVal cmserp As String)
        Try
            cmd.CommandText = "insert into EmployeeProficiency(InsID,InsName,Period,SystemDate,empid,msword,msexcel,mspowerpoint,internet,knowemail,cmserp) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & msword & "','" & msexcel & "','" & mspowerpoint & "','" & internet & "','" & knowemail & "','" & cmserp & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessEmployeeProgrammingLang(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal lang As String)
        Try
            cmd.CommandText = "insert into EmployeeProgrammingLang(InsID,InsName,Period,SystemDate,empid,lang) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & lang & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessEmployeeActivity(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal publishedbooks As String, ByVal publishedpaper As String, ByVal publishedarticles As String, ByVal seminar As String, ByVal adminisexp As String, ByVal otheractivities As String, ByVal poriodnotice As String, ByVal referee1 As String, ByVal referee2 As String, ByVal referee3 As String, ByVal otherinfo As String)
        Try
            cmd.CommandText = "insert into EmployeeActivity(InsID,InsName,Period,SystemDate,empid,publishedbooks,publishedpaper,publishedarticles,seminar,adminisexp,otheractivities,poriodnotice,referee1,referee2,referee3,otherinfo) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & publishedbooks & "','" & publishedpaper & "','" & publishedarticles & "','" & seminar & "','" & adminisexp & "','" & otheractivities & "','" & poriodnotice & "','" & referee1 & "','" & referee2 & "','" & referee3 & "','" & otherinfo & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessHiredEmployee(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal namefirst As String, ByVal namemiddle As String, ByVal namelast As String, ByVal name As String, ByVal houseno As String, ByVal address As String, ByVal city As String, ByVal district As String, ByVal state As String, ByVal pin As String, ByVal country As String, ByVal phone As String, ByVal fax As String, ByVal dob As String, ByVal email As String, ByVal category As String, ByVal department As String, ByVal designation As String, ByVal married As String, ByVal sex As String, ByVal handicapped As String, ByVal presentposition As String, ByVal retirementdate As String, ByVal fulladdress As String, ByVal payinfo As String, ByVal pay As Decimal, ByVal joiningdate As String)
        Try
            cmd.CommandText = "insert into HiredEmployee(InsID,InsName,Period,SystemDate,empid,namefirst,namemiddle,namelast,name,houseno,address,city,district,state,pin,country,phone,fax,dob,email,category,department,designation,married,sex,handicapped,presentposition,retirementdate,fulladdress,payinfo,pay,joiningdate) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & namefirst & "','" & namemiddle & "','" & namelast & "','" & name & "','" & houseno & "','" & address & "','" & city & "','" & district & "','" & state & "','" & pin & "','" & country & "','" & phone & "','" & fax & "','" & dob & "','" & email & "','" & category & "','" & department & "','" & designation & "','" & married & "','" & sex & "','" & handicapped & "','" & presentposition & "','" & retirementdate & "','" & fulladdress & "','" & payinfo & "'," & pay & ",'" & joiningdate & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessRetiredEmployee(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal namefirst As String, ByVal namemiddle As String, ByVal namelast As String, ByVal name As String, ByVal houseno As String, ByVal address As String, ByVal city As String, ByVal district As String, ByVal state As String, ByVal pin As String, ByVal country As String, ByVal phone As String, ByVal fax As String, ByVal dob As String, ByVal email As String, ByVal category As String, ByVal department As String, ByVal designation As String, ByVal married As String, ByVal sex As String, ByVal handicapped As String, ByVal presentposition As String, ByVal retirementdate As String, ByVal fulladdress As String, ByVal payinfo As String, ByVal payscale As String, ByVal grade As Decimal, ByVal basic As Decimal, ByVal joiningdate As String, ByVal phd As String, ByVal qualifiedtest As String, ByVal attachedcopy As String, ByVal incremented As String)
        Try
            cmd.CommandText = "insert into RetiredEmployee(InsID,InsName,Period,SystemDate,empid,namefirst,namemiddle,namelast,name,houseno,address,city,district,state,pin,country,phone,fax,dob,email,category,department,designation,married,sex,handicapped,presentposition,retirementdate,fulladdress,payinfo,payscale,grade,basic,joiningdate,phd,qualifiedtest,attachedcopy,incremented) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & namefirst & "','" & namemiddle & "','" & namelast & "','" & name & "','" & houseno & "','" & address & "','" & city & "','" & district & "','" & state & "','" & pin & "','" & country & "','" & phone & "','" & fax & "','" & dob & "','" & email & "','" & category & "','" & department & "','" & designation & "','" & married & "','" & sex & "','" & handicapped & "','" & presentposition & "','" & retirementdate & "','" & fulladdress & "','" & payinfo & "','" & payscale & "'," & grade & "," & basic & ",'" & joiningdate & "','" & phd & "','" & qualifiedtest & "','" & attachedcopy & "','" & incremented & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessRetiredEmployeeLanguage(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal langname As String, ByVal canread As String, ByVal canwrite As String, ByVal canspeak As String, ByVal canconversation As String)
        Try
            cmd.CommandText = "insert into RetiredEmployeeLanguage(InsID,InsName,Period,SystemDate,empid,langname,canread,canwrite,canspeak,canconversation) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & langname & "','" & canread & "','" & canwrite & "','" & canspeak & "','" & canconversation & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessRetiredEmployeeAcademic(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal degree As String, ByVal passingyear As Integer, ByVal subjects As String, ByVal percentagemarks As Decimal, ByVal classdivision As String)
        Try
            cmd.CommandText = "insert into RetiredEmployeeAcademic(InsID,InsName,Period,SystemDate,empid,degree,passingyear,subjects,percentagemarks,classdivision) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & degree & "'," & passingyear & ",'" & subjects & "'," & percentagemarks & ",'" & classdivision & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessRetiredEmployeeTeachingExp(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal totaltexpyear As Integer, ByVal totaltexpmonth As Integer, ByVal institution As String, ByVal designation As String, ByVal totalyears As Integer, ByVal ug As String, ByVal degree As String, ByVal pg As String)
        Try
            cmd.CommandText = "insert into RetiredEmployeeTeachingExp(InsID,InsName,Period,SystemDate,empid,totaltexpyear,totaltexpmonth,institution,designation,totalyears,ug,degree,pg) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "'," & totaltexpyear & "," & totaltexpmonth & ",'" & institution & "','" & designation & "'," & totalyears & ",'" & ug & "','" & degree & "','" & pg & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessRetiredEmployeeResearchExp(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal totalrexpyear As Integer, ByVal totalrexpmonth As Integer, ByVal research As String, ByVal institution As String, ByVal topic As String, ByVal researchperiod As String)
        Try
            cmd.CommandText = "insert into RetiredEmployeeResearchExp(InsID,InsName,Period,SystemDate,empid,totalrexpyear,totalrexpmonth,research,institution,topic,researchperiod) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "'," & totalrexpyear & "," & totalrexpmonth & ",'" & research & "','" & institution & "','" & topic & "','" & researchperiod & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessRetiredEmployeeProficiency(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal msword As String, ByVal msexcel As String, ByVal mspowerpoint As String, ByVal internet As String, ByVal knowemail As String, ByVal cmserp As String)
        Try
            cmd.CommandText = "insert into RetiredEmployeeProficiency(InsID,InsName,Period,SystemDate,empid,msword,msexcel,mspowerpoint,internet,knowemail,cmserp) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & msword & "','" & msexcel & "','" & mspowerpoint & "','" & internet & "','" & knowemail & "','" & cmserp & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessRetiredEmployeeProgrammingLang(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal lang As String)
        Try
            cmd.CommandText = "insert into RetiredEmployeeProgrammingLang(InsID,InsName,Period,SystemDate,empid,lang) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & lang & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessRetiredEmployeeActivity(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal publishedbooks As String, ByVal publishedpaper As String, ByVal publishedarticles As String, ByVal seminar As String, ByVal adminisexp As String, ByVal otheractivities As String, ByVal poriodnotice As String, ByVal referee1 As String, ByVal referee2 As String, ByVal referee3 As String, ByVal otherinfo As String)
        Try
            cmd.CommandText = "insert into RetiredEmployeeActivity(InsID,InsName,Period,SystemDate,empid,publishedbooks,publishedpaper,publishedarticles,seminar,adminisexp,otheractivities,poriodnotice,referee1,referee2,referee3,otherinfo) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & publishedbooks & "','" & publishedpaper & "','" & publishedarticles & "','" & seminar & "','" & adminisexp & "','" & otheractivities & "','" & poriodnotice & "','" & referee1 & "','" & referee2 & "','" & referee3 & "','" & otherinfo & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessStudentRegistration(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal serial As String, ByVal year As Integer, ByVal preadmitted As String, ByVal preadmissionid As String, ByVal course As String, ByVal approved As String, ByVal clas As String, ByVal classint As Integer, ByVal classstring As String, ByVal fname As String, ByVal mname As String, ByVal lname As String, ByVal name As String, ByVal fgname As String, ByVal mothername As String, ByVal dob As String, ByVal sex As String, ByVal coursefee As Decimal, ByVal annualincome As Decimal, ByVal prehouseno As String, ByVal preaddress As String, ByVal precity As String, ByVal prepost As String, ByVal predist As String, ByVal prestate As String, ByVal prepin As String, ByVal precountry As String, ByVal perhouseno As String, ByVal peraddress As String, ByVal percity As String, ByVal perpost As String, ByVal perdist As String, ByVal perstate As String, ByVal perpin As String, ByVal percountry As String, ByVal profcourse As String, ByVal profcourseduration As String, ByVal profcourseyear As Integer, ByVal institute As String, ByVal recognized As String, ByVal instituteaddress As String, ByVal institutephone As String, ByVal institutefax As String, ByVal instituteuniv As String, ByVal payeename As String, ByVal bankname As String, ByVal bankbrach As String, ByVal branchaddress As String, ByVal branchcode As String, ByVal accountno As String, ByVal accounttype As String, ByVal micrcode As String, ByVal electronictransfer As String, ByVal cardholdername As String, ByVal cardaddress As String, ByVal cardcity As String, ByVal cardstate As String, ByVal cardpin As String, ByVal cardcountry As String, ByVal cardtype As String, ByVal payvia As String, ByVal cardno As String, ByVal expmm As Integer, ByVal expyy As Integer, ByVal email As String, ByVal homephone As String, ByVal workphone As String, ByVal fax As String, ByVal stuid As String, ByVal roll As String, ByVal time As String, ByVal tuition As String, ByVal emergencyname As String, ByVal emergencyhomeph As String, ByVal emergencyworkph As String, ByVal emergencyfax As String, ByVal emergencyrelation As String, ByVal emergencyaddress As String)
        Try
            cmd.CommandText = "insert into StudentRegistration(InsID,InsName,Period,SystemDate,serial,year,preadmitted,preadmissionid,course,approved,class,classint,classstring,fname,mname,lname,name,fgname,mothername,dob,sex,coursefee,annualincome,prehouseno,preaddress,precity,prepost,predist,prestate,prepin,precountry,perhouseno,peraddress,percity,perpost,perdist,perstate,perpin,percountry,profcourse,profcourseduration,profcourseyear,institute,recognized,instituteaddress,institutephone,institutefax,instituteuniv,payeename,bankname,bankbrach,branchaddress,branchcode,accountno,accounttype,micrcode,electronictransfer,cardholdername,cardaddress,cardcity,cardstate,cardpin,cardcountry,cardtype,payvia,cardno,expmm,expyy,email,homephone,workphone,fax,stuid,roll,time,tuition,emergencyname,emergencyhomeph,emergencyworkph,emergencyfax,emergencyrelation,emergencyaddress) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & serial & "'," & year & ",'" & preadmitted & "','" & preadmissionid & "','" & course & "','" & approved & "','" & clas & "'," & classint & ",'" & classstring & "','" & fname & "','" & mname & "','" & lname & "','" & name & "','" & fgname & "','" & mothername & "','" & dob & "','" & sex & "'," & coursefee & "," & annualincome & ",'" & prehouseno & "','" & preaddress & "','" & precity & "','" & prepost & "','" & predist & "','" & prestate & "','" & prepin & "','" & precountry & "','" & perhouseno & "','" & peraddress & "','" & percity & "','" & perpost & "','" & perdist & "','" & perstate & "','" & perpin & "','" & percountry & "','" & profcourse & "','" & profcourseduration & "'," & profcourseyear & ",'" & institute & "','" & recognized & "','" & instituteaddress & "','" & institutephone & "','" & institutefax & "','" & instituteuniv & "','" & payeename & "','" & bankname & "','" & bankbrach & "','" & branchaddress & "','" & branchcode & "','" & accountno & "','" & accounttype & "','" & micrcode & "','" & electronictransfer & "','" & cardholdername & "','" & cardaddress & "','" & cardcity & "','" & cardstate & "','" & cardpin & "','" & cardcountry & "','" & cardtype & "','" & payvia & "','" & cardno & "'," & expmm & "," & expyy & ",'" & email & "','" & homephone & "','" & workphone & "','" & fax & "','" & stuid & "','" & roll & "','" & time & "','" & tuition & "','" & emergencyname & "','" & emergencyhomeph & "','" & emergencyworkph & "','" & emergencyfax & "','" & emergencyrelation & "','" & emergencyaddress & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessStudentDiscount(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal year As String, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal stuid As String, ByVal name As String, ByVal discount As Decimal)
        Try
            cmd.CommandText = "insert into StudentDiscount(InsID,InsName,Period,SystemDate,year,course,class,roll,stuid,name,discount) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & year & "','" & course & "','" & clas & "','" & roll & "','" & stuid & "','" & name & "'," & discount & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessSubjects(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal course As String, ByVal coursecode As String, ByVal haspractical As String, ByVal gensubject As String, ByVal gensubjectduration As String, ByVal gensubjectcode As String, ByVal gensubjectyear As Integer, ByVal gensubjectsemestar As String, ByVal pracsubject As String, ByVal pracsubjectduration As String, ByVal pracsubjectcode As String, ByVal pracsubjectyear As Integer, ByVal pracsubjectsemestar As String)
        Try
            cmd.CommandText = "insert into Subjects(InsID,InsName,Period,course,coursecode,haspractical,gensubject,gensubjectduration,gensubjectcode,gensubjectyear,gensubjectsemestar,pracsubject,pracsubjectduration,pracsubjectcode,pracsubjectyear,pracsubjectsemestar) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & course & "','" & coursecode & "','" & haspractical & "','" & gensubject & "','" & gensubjectduration & "','" & gensubjectcode & "'," & gensubjectyear & ",'" & gensubjectsemestar & "','" & pracsubject & "','" & pracsubjectduration & "','" & pracsubjectcode & "'," & pracsubjectyear & ",'" & pracsubjectsemestar & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessSyllabus(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal course As String, ByVal coursecode As String, ByVal subject As String, ByVal subjectcode As String, ByVal forstudent As String, ByVal chapter As String, ByVal chapterdetails As String, ByVal totalmarks As Integer, ByVal marksobtained As Integer, ByVal totalclass As Integer, ByVal classes As Integer)
        Try
            cmd.CommandText = "insert into Syllabus(InsID,InsName,Period,SystemDate,course,coursecode,subject,subjectcode,forstudent,chapter,chapterdetails,totalmarks,marksobtained,totalclass,class) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & SystemDate & "','" & course & "','" & coursecode & "','" & subject & "','" & subjectcode & "','" & forstudent & "','" & chapter & "','" & chapterdetails & "'," & totalmarks & "," & marksobtained & "," & totalclass & "," & classes & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessAlumni(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal serial As String, ByVal alumniyear As Integer, ByVal year As Integer, ByVal preadmitted As String, ByVal preadmissionid As String, ByVal course As String, ByVal approved As String, ByVal clas As String, ByVal classint As Integer, ByVal classstring As String, ByVal fname As String, ByVal mname As String, ByVal lname As String, ByVal name As String, ByVal fgname As String, ByVal mothername As String, ByVal dob As String, ByVal sex As String, ByVal coursefee As Decimal, ByVal annualincome As Decimal, ByVal prehouseno As String, ByVal preaddress As String, ByVal precity As String, ByVal prepost As String, ByVal predist As String, ByVal prestate As String, ByVal prepin As String, ByVal precountry As String, ByVal perhouseno As String, ByVal peraddress As String, ByVal percity As String, ByVal perpost As String, ByVal perdist As String, ByVal perstate As String, ByVal perpin As String, ByVal percountry As String, ByVal profcourse As String, ByVal profcourseduration As String, ByVal profcourseyear As Integer, ByVal institute As String, ByVal recognized As String, ByVal instituteaddress As String, ByVal institutephone As String, ByVal institutefax As String, ByVal instituteuniv As String, ByVal payeename As String, ByVal bankname As String, ByVal bankbrach As String, ByVal branchaddress As String, ByVal branchcode As String, ByVal accountno As String, ByVal accounttype As String, ByVal micrcode As String, ByVal electronictransfer As String, ByVal cardholdername As String, ByVal cardaddress As String, ByVal cardcity As String, ByVal cardstate As String, ByVal cardpin As String, ByVal cardcountry As String, ByVal cardtype As String, ByVal payvia As String, ByVal cardno As String, ByVal expmm As Integer, ByVal expyy As Integer, ByVal email As String, ByVal homephone As String, ByVal workphone As String, ByVal fax As String, ByVal stuid As String, ByVal roll As String, ByVal time As String, ByVal tuition As String, ByVal emergencyname As String, ByVal emergencyhomeph As String, ByVal emergencyworkph As String, ByVal emergencyfax As String, ByVal emergencyrelation As String, ByVal emergencyaddress As String)
        Try
            cmd.CommandText = "insert into Alumni(InsID,InsName,Period,SystemDate,serial,alumniyear,year,preadmitted,preadmissionid,course,approved,class,classint,classstring,fname,mname,lname,name,fgname,mothername,dob,sex,coursefee,annualincome,prehouseno,preaddress,precity,prepost,predist,prestate,prepin,precountry,perhouseno,peraddress,percity,perpost,perdist,perstate,perpin,percountry,profcourse,profcourseduration,profcourseyear,institute,recognized,instituteaddress,institutephone,institutefax,instituteuniv,payeename,bankname,bankbrach,branchaddress,branchcode,accountno,accounttype,micrcode,electronictransfer,cardholdername,cardaddress,cardcity,cardstate,cardpin,cardcountry,cardtype,payvia,cardno,expmm,expyy,email,homephone,workphone,fax,stuid,roll,time,tuition,emergencyname,emergencyhomeph,emergencyworkph,emergencyfax,emergencyrelation,emergencyaddress) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & serial & "'," & alumniyear & "," & year & ",'" & preadmitted & "','" & preadmissionid & "','" & course & "','" & approved & "','" & clas & "'," & classint & ",'" & classstring & "','" & fname & "','" & mname & "','" & lname & "','" & name & "','" & fgname & "','" & mothername & "','" & dob & "','" & sex & "'," & coursefee & "," & annualincome & ",'" & prehouseno & "','" & preaddress & "','" & precity & "','" & prepost & "','" & predist & "','" & prestate & "','" & prepin & "','" & precountry & "','" & perhouseno & "','" & peraddress & "','" & percity & "','" & perpost & "','" & perdist & "','" & perstate & "','" & perpin & "','" & percountry & "','" & profcourse & "','" & profcourseduration & "'," & profcourseyear & ",'" & institute & "','" & recognized & "','" & instituteaddress & "','" & institutephone & "','" & institutefax & "','" & instituteuniv & "','" & payeename & "','" & bankname & "','" & bankbrach & "','" & branchaddress & "','" & branchcode & "','" & accountno & "','" & accounttype & "','" & micrcode & "','" & electronictransfer & "','" & cardholdername & "','" & cardaddress & "','" & cardcity & "','" & cardstate & "','" & cardpin & "','" & cardcountry & "','" & cardtype & "','" & payvia & "','" & cardno & "'," & expmm & "," & expyy & ",'" & email & "','" & homephone & "','" & workphone & "','" & fax & "','" & stuid & "','" & roll & "','" & time & "','" & tuition & "','" & emergencyname & "','" & emergencyhomeph & "','" & emergencyworkph & "','" & emergencyfax & "','" & emergencyrelation & "','" & emergencyaddress & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessInventory(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal itemid As String, ByVal itemnote As String, ByVal itemname As String, ByVal itemclass As String, ByVal descshort As String, ByVal itemsize As String, ByVal itemshape As String, ByVal itemused As String, ByVal descripbrief As String, ByVal levelprice As Decimal, ByVal onhandqnty As Decimal, ByVal onhandqntyunit As String, ByVal lastsoldprice As Decimal, ByVal costmethod As String, ByVal minstockqnty As Decimal, ByVal minstockqntyunit As String, ByVal itemtaxtype As String, ByVal itemtype As String, ByVal stocking As String, ByVal weight As Decimal, ByVal weightunit As String, ByVal vendorname As String, ByVal glsalesaccountid As String, ByVal glinventoryaccountid As String, ByVal glcostsaccountid As String, ByVal costingaccountid As String, ByVal customfield1 As String, ByVal customfield2 As String, ByVal customfield3 As String, ByVal customfield4 As String, ByVal customfield5 As String, ByVal inactive As String, ByVal commission As String, ByVal UnitPrice As Decimal)
        Try
            cmd.CommandText = "insert into Inventory(InsID,InsName,Period,SystemDate,itemid,itemnote,itemname,itemclass,descshort,itemsize,itemshape,itemused,descripbrief,levelprice,onhandqnty,onhandqntyunit,lastsoldprice,costmethod,minstockqnty,minstockqntyunit,itemtaxtype,itemtype,stocking,weight,weightunit,vendorname,glsalesaccountid,glinventoryaccountid,glcostsaccountid,costingaccountid,customfield1,customfield2,customfield3,customfield4,customfield5,inactive,commission,UnitPrice) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & itemid & "','" & itemnote & "','" & itemname & "','" & itemclass & "','" & descshort & "','" & itemsize & "','" & itemshape & "','" & itemused & "','" & descripbrief & "'," & levelprice & "," & onhandqnty & ",'" & onhandqntyunit & "'," & lastsoldprice & ",'" & costmethod & "'," & minstockqnty & ",'" & minstockqntyunit & "','" & itemtaxtype & "','" & itemtype & "','" & stocking & "'," & weight & ",'" & weightunit & "','" & vendorname & "','" & glsalesaccountid & "','" & glinventoryaccountid & "','" & glcostsaccountid & "','" & costingaccountid & "','" & customfield1 & "','" & customfield2 & "','" & customfield3 & "','" & customfield4 & "','" & customfield5 & "','" & inactive & "','" & commission & "'," & UnitPrice & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessInventoryItemPriceLevel(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal SystemDate As String, ByVal itemid As String, ByVal itemname As String, ByVal itemdesc As String, ByVal levelprice1 As Decimal, ByVal levelprice2 As Decimal, ByVal levelprice3 As Decimal, ByVal levelprice4 As Decimal, ByVal levelprice5 As Decimal, ByVal levelprice6 As Decimal, ByVal levelprice7 As Decimal, ByVal levelprice8 As Decimal, ByVal levelprice9 As Decimal, ByVal levelprice10 As Decimal, ByVal defaultlevel As String)
        Try
            cmd.CommandText = "insert into InventoryItemPriceLevel(InsID,InsName,Period,SystemDate,itemid,itemname,itemdesc,levelprice1,levelprice2,levelprice3,levelprice4,levelprice5,levelprice6,levelprice7,levelprice8,levelprice9,levelprice10,defaultlevel) values ('" & InsID & "','" & InsName & "','" & Period & "','" & SystemDate & "','" & itemid & "','" & itemname & "','" & itemdesc & "'," & levelprice1 & "," & levelprice2 & "," & levelprice3 & "," & levelprice4 & "," & levelprice5 & "," & levelprice6 & "," & levelprice7 & "," & levelprice8 & "," & levelprice9 & "," & levelprice10 & ",'" & defaultlevel & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessGroupBooks(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal groupid As String, ByVal groupname As String, ByVal groupdetails As String)
        Try
            cmd.CommandText = "insert into GroupBooks(InsID,InsName,Period,SystemDate,groupid,groupname,groupdetails) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & groupid & "','" & groupname & "','" & groupdetails & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            dr.Close()
            YearEndOk = False
        End Try
    End Sub

    Private Sub ProcessSubjectBooks(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal subjectidd As String, ByVal subjectname As String, ByVal subjectdetails As String)
        Try
            cmd.CommandText = "insert into SubjectBooks(InsID,InsName,Period,SystemDate,subjectid,subjectname,subjectdetails) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & subjectidd & "','" & subjectname & "','" & subjectdetails & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            dr.Close()
            YearEndOk = False
        End Try
    End Sub

    Private Sub ProcessBooks(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal bookid As String, ByVal bookname As String, ByVal groupname As String, ByVal subject As String, ByVal publisher As String, ByVal author As String, ByVal edition As String, ByVal copies As Integer, ByVal pages As Integer, ByVal price As Decimal, ByVal particulars As String)
        Try
            cmd.CommandText = "insert into Books(InsID,InsName,Period,SystemDate,bookid,bookname,groupname,subject,publisher,author,edition,copies,pages,price,particulars) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & bookid & "','" & bookname & "','" & groupname & "','" & subject & "','" & publisher & "','" & author & "','" & edition & "'," & copies & "," & pages & "," & price & ",'" & particulars & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            dr.Close()
            YearEndOk = False
        End Try
    End Sub

    Private Sub ProcessBookCharges(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal course As String, ByVal referencebooks As String, ByVal finerate As Decimal, ByVal reserveperiod As Integer, ByVal maxbooks As Integer, ByVal booksreturndays As Integer, ByVal maxjournal As Integer, ByVal journalreturndays As Integer, ByVal maxcompbook As Integer, ByVal compbookreturndays As Integer, ByVal lockerperiod As Integer, ByVal lockerfees As Decimal, ByVal losingcardcharge As Decimal, ByVal lockerfine As Decimal, ByVal losingjournalcharge As Decimal, ByVal idcardcharge As Decimal)
        Try
            cmd.CommandText = "insert into BookCharges(InsID,InsName,Period,SystemDate,course,referencebooks,finerate,reserveperiod,maxbooks,booksreturndays,maxjournal,journalreturndays,maxcompbook,compbookreturndays,lockerperiod,lockerfees,losingcardcharge,lockerfine,losingjournalcharge,idcardcharge) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & course & "','" & referencebooks & "'," & finerate & "," & reserveperiod & "," & maxbooks & "," & booksreturndays & "," & maxjournal & "," & journalreturndays & "," & maxcompbook & "," & compbookreturndays & "," & lockerperiod & "," & lockerfees & "," & losingcardcharge & "," & lockerfine & "," & losingjournalcharge & "," & idcardcharge & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            dr.Close()
            YearEndOk = False
        End Try
    End Sub

    Private Sub ProcessDepartment(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal deptid As String, ByVal deptname As String)
        Try
            cmd.CommandText = "insert into Department(InsID,InsName,Period,deptid,deptname) values ('" & InsID & "','" & InsName & "','" & Period & "','" & deptid & "','" & deptname & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
        End Try
    End Sub

    Private Sub ProcessDesignation(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal desigid As String, ByVal designame As String)
        Try
            cmd.CommandText = "insert into Designation(InsID,InsName,Period,desigid,designame) values ('" & InsID & "','" & InsName & "','" & Period & "','" & desigid & "','" & designame & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
        End Try
    End Sub

    Private Sub ProcessPayScale(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal pbname As String, ByVal pblower As Decimal, ByVal pbupper As Decimal, ByVal pbgrade As Decimal, ByVal pbbasic As Decimal, ByVal payscale As String)
        Try
            cmd.CommandText = "insert into PayScale(InsID,InsName,period,pbname,pblower,pbupper,pbgrade,pbbasic,payscale) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & pbname & "'," & pblower & "," & pbupper & "," & pbgrade & "," & pbbasic & ",'" & payscale & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
        End Try
    End Sub

    Private Sub ProcessProfessionalTax(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal gross As Decimal, ByVal taxrate As Decimal)
        Try
            cmd.CommandText = "insert into ProfessionalTax(InsID,InsName,Period,gross,taxrate) values ('" & InsID & "','" & InsName & "','" & Periodd & "'," & gross & "," & taxrate & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            dr.Close()
            YearEndOk = False
        End Try
    End Sub

    Private Sub ProcessPayslipHeaders(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal allowancedesc1 As String, ByVal allowanceshortdesc1 As String, ByVal allowancedesc2 As String, ByVal allowanceshortdesc2 As String, ByVal allowancedesc3 As String, ByVal allowanceshortdesc3 As String, ByVal allowancedesc4 As String, ByVal allowanceshortdesc4 As String, ByVal deductiondesc1 As String, ByVal deductionshortdesc1 As String, ByVal deductiondesc2 As String, ByVal deductionshortdesc2 As String, ByVal deductiondesc3 As String, ByVal deductionshortdesc3 As String, ByVal signatorydesc1 As String, ByVal signatoryshortdesc1 As String, ByVal signatorydesc2 As String, ByVal signatoryshortdesc2 As String, ByVal signatorydesc3 As String, ByVal signatoryshortdesc3 As String)
        Try
            cmd.CommandText = "update PayslipHeaders set allowancedesc1='" & allowancedesc1 & "',allowanceshortdesc1='" & allowanceshortdesc1 & "',allowancedesc2='" & allowancedesc2 & "',allowanceshortdesc2='" & allowanceshortdesc2 & "',allowancedesc3='" & allowancedesc3 & "',allowanceshortdesc3='" & allowanceshortdesc3 & "',allowancedesc4='" & allowancedesc4 & "',allowanceshortdesc4='" & allowanceshortdesc4 & "',deductiondesc1='" & deductiondesc1 & "',deductionshortdesc1='" & deductionshortdesc1 & "',deductiondesc2='" & deductiondesc2 & "',deductionshortdesc2='" & deductionshortdesc2 & "',deductiondesc3='" & deductiondesc3 & "',deductionshortdesc3='" & deductionshortdesc3 & "',signatorydesc1='" & signatorydesc1 & "',signatoryshortdesc1='" & signatoryshortdesc1 & "',signatorydesc2='" & signatorydesc2 & "',signatoryshortdesc2='" & signatoryshortdesc2 & "',signatorydesc3='" & signatorydesc3 & "',signatoryshortdesc3 ='" & signatoryshortdesc3 & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessPFRate(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal year As Integer, ByVal rate As Decimal, ByVal amount As Decimal)
        Try
            cmd.CommandText = "insert into PFRate(InsID,InsName,Period,year,rate,amount) values ('" & InsID & "','" & InsName & "','" & Periodd & "'," & year & "," & rate & "," & amount & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessPFRateIndividual(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal year As Integer, ByVal regno As String, ByVal name As String, ByVal rate As Decimal, ByVal amount As Decimal)
        Try
            cmd.CommandText = "insert into PFRateIndividual(InsID,InsName,Period,year,regno,name,rate,amount) values ('" & InsID & "','" & InsName & "','" & Periodd & "'," & year & ",'" & regno & "','" & name & "'," & rate & "," & amount & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessPF(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal empid As String, ByVal designation As String, ByVal name As String, ByVal joiningdate As String, ByVal openingbalance As Decimal, ByVal outstandingadvance As Decimal)
        Try
            cmd.CommandText = "insert into PF(InsID,InsName,Period,regno,designation,name,joiningdate,openingbalance,outstandingadvance) values ('" & InsID & "','" & InsName & "','" & period & "','" & empid & "','" & designation & "','" & name & "','" & joiningdate & "'," & openingbalance & "," & outstandingadvance & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessRetiredPF(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal empid As String, ByVal designation As String, ByVal name As String, ByVal joiningdate As String, ByVal openingbalance As Decimal, ByVal outstandingadvance As Decimal)
        Try
            cmd.CommandText = "insert into RetiredPF(InsID,InsName,Period,regno,designation,name,joiningdate,openingbalance,outstandingadvance) values ('" & InsID & "','" & InsName & "','" & period & "','" & empid & "','" & designation & "','" & name & "','" & joiningdate & "'," & openingbalance & "," & outstandingadvance & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessCloseMembership(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal regno As String, ByVal name As String, ByVal closingbal As Decimal, ByVal outstanding As Decimal, ByVal closingdate As String)
        Try
            cmd.CommandText = "insert into CloseMembership(InsID,InsName,Period,regno,name,closingbal,outstanding,closingdate) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & regno & "','" & name & "'," & closingbal & "," & outstanding & ",'" & closingdate & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessUsers(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal userno As String, ByVal userrole As String, ByVal userid As String, ByVal userpasswd As String, ByVal useraccess As String, ByVal employeeinfo As String, ByVal employeecard As String, ByVal attendances As String, ByVal idcard As String, ByVal notices As String, ByVal studentcontrol As String, ByVal backuprestore As String, ByVal importexport As String, ByVal studentinfo As String, ByVal studentcard As String, ByVal preadmission As String, ByVal admission As String, ByVal registration As String, ByVal feesterms As String, ByVal bankinginfo As String, ByVal feescollection As String, ByVal discount As String, ByVal incomeexpenditure As String, ByVal accounting As String, ByVal financialloan As String, ByVal coursesubject As String, ByVal examination As String, ByVal progressreport As String, ByVal marksheet As String, ByVal messenger As String, ByVal globalaccess As String, ByVal alumni As String, ByVal certificates As String, ByVal purchaseorder As String, ByVal inventory As String, ByVal salesinvoice As String, ByVal games As String, ByVal bookrecords As String, ByVal charges As String, ByVal issuebooks As String, ByVal returnbooks As String, ByVal payrollsystem As String, ByVal payrollperiodic As String, ByVal payrollpf As String, ByVal institutedefault As String, ByVal librarydefault As String, ByVal payrolldefault As String, ByVal revenueyeartodate As String, ByVal yearend As String)
        Try
            cmd.CommandText = "insert into Users(InsID,InsName,Period,SystemDate,userno,userrole,userid,userpasswd,useraccess,employeeinfo,employeecard,attendances,idcard,notices,studentcontrol,backuprestore,importexport,studentinfo,studentcard,preadmission,admission,registration,feesterms,bankinginfo,feescollection,discount,incomeexpenditure,accounting,financialloan,coursesubject,examination,progressreport,marksheet,messenger,globalaccess,alumni,certificates,purchaseorder,inventory,salesinvoice,games,bookrecords,charges,issuebooks,returnbooks,payrollsystem,payrollperiodic,payrollpf,institutedefault,librarydefault,payrolldefault,revenueyeartodate,yearend) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & userno & "','" & userrole & "','" & userid & "','" & userpasswd & "','" & useraccess & "','" & employeeinfo & "','" & employeecard & "','" & attendances & "','" & idcard & "','" & notices & "','" & studentcontrol & "','" & backuprestore & "','" & importexport & "','" & studentinfo & "','" & studentcard & "','" & preadmission & "','" & admission & "','" & registration & "','" & feesterms & "','" & bankinginfo & "','" & feescollection & "','" & discount & "','" & incomeexpenditure & "','" & accounting & "','" & financialloan & "','" & coursesubject & "','" & examination & "','" & progressreport & "','" & marksheet & "','" & messenger & "','" & globalaccess & "','" & alumni & "','" & certificates & "','" & purchaseorder & "','" & inventory & "','" & salesinvoice & "','" & games & "','" & bookrecords & "','" & charges & "','" & issuebooks & "','" & returnbooks & "','" & payrollsystem & "','" & payrollperiodic & "','" & payrollpf & "','" & institutedefault & "','" & librarydefault & "','" & payrolldefault & "','" & revenueyeartodate & "','" & yearend & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub

    Private Sub ProcessUserCrystalReport(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal crystalreport As String, ByVal crystalreportid As String)
        Try
            cmd.CommandText = "insert into UserCrystalReport(InsID,InsName,Period,crystalreport,crystalreportid) values('" & InsID & "','" & InsName & "','" & Periodd & "','" & crystalreport & "','" & crystalreportid & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            YearEndOk = True
        Catch ex As Exception
            YearEndOk = False
            dr.Close()
        End Try
    End Sub
#End Region
#End Region
#End Region
#Region "Form Events..."
    Private Sub frmYearEndWizard_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If YearEndOk = True Then
            Dim frm As New frmYearEndClosed()
            frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            frm.WindowState = FormWindowState.Normal
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ControlBox = False
            frm.ShowDialog()
        End If
    End Sub

    Private Sub frmYearEndWizard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ETabControlEx1.HideTabs = True
        btnnext.Text = LanguageTexts_Next
        btnback.Text = LanguageTexts_Back
        btnback.Enabled = False
        CurrentFiscalYear()
        CurrentPayrollTaxYear()
        NewDGViewFiscalYear()
        NewFiscalPayrollYear()
        LoadUnpaidItems()
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnext_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnext.ClickButtonArea
        If btnnext.Tag = "finish" Then
            YearEndProcess()
        Else
            GoToTab()
        End If
    End Sub

    Private Sub btnback_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnback.ClickButtonArea
        If btnback.Tag = "" Then
            GoToTab(-1)
        End If
    End Sub

    Private Sub btnbackup_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnbackup.ClickButtonArea
        Dim frm As New frmBackupRestore()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub
#End Region
#Region "TabControl Events..."
    Private Sub ETabControlEx1_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ETabControlEx1.TabIndexChanged
        If ETabControlEx1.SelectedIndex = 3 Then
            If dgviewreport.Rows.Count > 0 Then
                btnnext.Enabled = False
            End If
        End If
    End Sub
#End Region
End Class
#End Region