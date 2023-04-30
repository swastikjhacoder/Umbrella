#Region "Class frmTransaction..."
Public Class frmFindTransaction
#Region "Declarations..."
    Private STR(11) As String
    Private STR1(11) As String
    Private STR2(11) As String
    Private DD(11) As Integer
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(22, 37, 48, 13)
        Label2.SetBounds(218, 37, 41, 13)
        Label3.SetBounds(392, 37, 25, 13)
        Label4.SetBounds(22, 16, 319, 13)
        Label5.SetBounds(12, 228, 452, 13)
        dgviewtransaction.SetBounds(12, 25, 720, 203)
        cmbtransaction.SetBounds(353, 13, 150, 21)
        btnfind.SetBounds(511, 11, 67, 25)
        cmbfrom.SetBounds(265, 34, 121, 21)
        cmbperiod.SetBounds(76, 34, 132, 21)
        cmbto.SetBounds(423, 34, 121, 21)
    End Sub

    Private Sub FiscalYear()
        Try
            cmd.CommandText = "select StartDate,StartingMonth from Institute where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            cstartdate = dr("StartDate").ToString()
            cstartingmonth = dr("StartingMonth").ToString()
            dr.Close()

            Dim dte As Date = CDate(cstartdate.ToString())
            Dim yy As Integer = dte.Year
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
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub FindTransaction()
        Try
            Dim i As Integer = 0
            dgviewtransaction.Rows.Clear()

            If cmbtransaction.Text = "All" Then
                cmd.CommandText = "select date,transactionid,name,paidamt from MonthlyFees where date>='" & cmbfrom.Text & "' and date<='" & cmbto.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    dgviewtransaction.Rows.Add()
                    dgviewtransaction.Rows(i).Cells(0).Value = dr("date").ToString()
                    dgviewtransaction.Rows(i).Cells(1).Value = "Monthly Fees"
                    dgviewtransaction.Rows(i).Cells(3).Value = dr("transactionid").ToString()
                    dgviewtransaction.Rows(i).Cells(4).Value = dr("name").ToString()
                    dgviewtransaction.Rows(i).Cells(5).Value = dr("paidamt").ToString()
                    i += 1
                End While
                dr.Close()
                cmd.CommandText = "select date,token,name,pay from YearlyFees where date>='" & cmbfrom.Text & "' and date<='" & cmbto.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    dgviewtransaction.Rows.Add()
                    dgviewtransaction.Rows(i).Cells(0).Value = dr("date").ToString()
                    dgviewtransaction.Rows(i).Cells(1).Value = "Yearly Fees"
                    dgviewtransaction.Rows(i).Cells(3).Value = dr("token").ToString()
                    dgviewtransaction.Rows(i).Cells(4).Value = dr("name").ToString()
                    dgviewtransaction.Rows(i).Cells(5).Value = dr("pay").ToString()
                    i += 1
                End While
                dr.Close()
                cmd.CommandText = "select date,transactionid,name,pay from LateFees where date>='" & cmbfrom.Text & "' and date<='" & cmbto.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    dgviewtransaction.Rows.Add()
                    dgviewtransaction.Rows(i).Cells(0).Value = dr("date").ToString()
                    dgviewtransaction.Rows(i).Cells(1).Value = "Late Fees"
                    dgviewtransaction.Rows(i).Cells(3).Value = dr("transactionid").ToString()
                    dgviewtransaction.Rows(i).Cells(4).Value = dr("name").ToString()
                    dgviewtransaction.Rows(i).Cells(5).Value = dr("pay").ToString()
                    i += 1
                End While
                dr.Close()
                cmd.CommandText = "select date,transactionid,name,pay from libraryFees where date>='" & cmbfrom.Text & "' and date<='" & cmbto.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    dgviewtransaction.Rows.Add()
                    dgviewtransaction.Rows(i).Cells(0).Value = dr("date").ToString()
                    dgviewtransaction.Rows(i).Cells(1).Value = "Library Fees"
                    dgviewtransaction.Rows(i).Cells(3).Value = dr("transactionid").ToString()
                    dgviewtransaction.Rows(i).Cells(4).Value = dr("name").ToString()
                    dgviewtransaction.Rows(i).Cells(5).Value = dr("pay").ToString()
                    i += 1
                End While
                dr.Close()
                cmd.CommandText = "select date,transactionid,name,pay from ExamFee where date>='" & cmbfrom.Text & "' and date<='" & cmbto.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    dgviewtransaction.Rows.Add()
                    dgviewtransaction.Rows(i).Cells(0).Value = dr("date").ToString()
                    dgviewtransaction.Rows(i).Cells(1).Value = "Exam Fees"
                    dgviewtransaction.Rows(i).Cells(3).Value = dr("transactionid").ToString()
                    dgviewtransaction.Rows(i).Cells(4).Value = dr("name").ToString()
                    dgviewtransaction.Rows(i).Cells(5).Value = dr("pay").ToString()
                    i += 1
                End While
                dr.Close()
                cmd.CommandText = "select date,transactionid,name,pay from OtherFees where date>='" & cmbfrom.Text & "' and date<='" & cmbto.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    dgviewtransaction.Rows.Add()
                    dgviewtransaction.Rows(i).Cells(0).Value = dr("date").ToString()
                    dgviewtransaction.Rows(i).Cells(1).Value = "Other Fees"
                    dgviewtransaction.Rows(i).Cells(3).Value = dr("transactionid").ToString()
                    dgviewtransaction.Rows(i).Cells(4).Value = dr("name").ToString()
                    dgviewtransaction.Rows(i).Cells(5).Value = dr("pay").ToString()
                    i += 1
                End While
                dr.Close()
                cmd.CommandText = "select date,issueid,name,totalcharges,account from LibraryCharges where date>='" & cmbfrom.Text & "' and date<='" & cmbto.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    dgviewtransaction.Rows.Add()
                    dgviewtransaction.Rows(i).Cells(0).Value = dr("date").ToString()
                    dgviewtransaction.Rows(i).Cells(1).Value = "Library Charges"
                    dgviewtransaction.Rows(i).Cells(2).Value = dr("account").ToString()
                    dgviewtransaction.Rows(i).Cells(3).Value = dr("issueid").ToString()
                    dgviewtransaction.Rows(i).Cells(4).Value = dr("name").ToString()
                    dgviewtransaction.Rows(i).Cells(5).Value = dr("totalcharges").ToString()
                    i += 1
                End While
                dr.Close()
                cmd.CommandText = "select invoicedate,invoiceno,customername,totalamount from SalesInvoice where invoicedate>='" & cmbfrom.Text & "' and invoicedate<='" & cmbto.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    dgviewtransaction.Rows.Add()
                    dgviewtransaction.Rows(i).Cells(0).Value = dr("invoicedate").ToString()
                    dgviewtransaction.Rows(i).Cells(1).Value = "Sales Invoice"
                    dgviewtransaction.Rows(i).Cells(3).Value = dr("invoiceno").ToString()
                    dgviewtransaction.Rows(i).Cells(4).Value = dr("customername").ToString()
                    dgviewtransaction.Rows(i).Cells(5).Value = dr("totalamount").ToString()
                    i += 1
                End While
                dr.Close()
                cmd.CommandText = "select purchasedate,purchaseid,vendorname,totalamount from Purchase where purchasedate>='" & cmbfrom.Text & "' and purchasedate<='" & cmbto.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    dgviewtransaction.Rows.Add()
                    dgviewtransaction.Rows(i).Cells(0).Value = dr("purchasedate").ToString()
                    dgviewtransaction.Rows(i).Cells(1).Value = "Purchase"
                    dgviewtransaction.Rows(i).Cells(3).Value = dr("purchaseid").ToString()
                    dgviewtransaction.Rows(i).Cells(4).Value = dr("vendorname").ToString()
                    dgviewtransaction.Rows(i).Cells(5).Value = dr("totalamount").ToString()
                    i += 1
                End While
                dr.Close()
                If dgviewtransaction.Rows.Count > 0 Then
                    cmd.CommandText = "select monthlyfeesacc,yearlyfeesacc,libraryfeesacc,latefeesacc,otherfeesacc,examfeesacc,purchaseorderacc,salesinvoiceacc from DefaultInstitute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    Dim monthlyfeesacc As String = dr("monthlyfeesacc").ToString()
                    Dim yearlyfeesacc As String = dr("yearlyfeesacc").ToString()
                    Dim libraryfeesacc As String = dr("libraryfeesacc").ToString()
                    Dim latefeesacc As String = dr("latefeesacc").ToString()
                    Dim otherfeesacc As String = dr("otherfeesacc").ToString()
                    Dim examfeesacc As String = dr("examfeesacc").ToString()
                    Dim purchaseorderacc As String = dr("purchaseorderacc").ToString()
                    Dim salesinvoiceacc As String = dr("salesinvoiceacc").ToString()
                    dr.Close()
                    For row As Integer = 0 To dgviewtransaction.Rows.Count - 1
                        If dgviewtransaction.Rows(row).Cells(1).Value = "Monthly Fees" Then
                            dgviewtransaction.Rows(row).Cells(2).Value = monthlyfeesacc
                        ElseIf dgviewtransaction.Rows(row).Cells(1).Value = "Yearly Fees" Then
                            dgviewtransaction.Rows(row).Cells(2).Value = yearlyfeesacc
                        ElseIf dgviewtransaction.Rows(row).Cells(1).Value = "Library Fees" Then
                            dgviewtransaction.Rows(row).Cells(2).Value = libraryfeesacc
                        ElseIf dgviewtransaction.Rows(row).Cells(1).Value = "Late Fees" Then
                            dgviewtransaction.Rows(row).Cells(2).Value = latefeesacc
                        ElseIf dgviewtransaction.Rows(row).Cells(1).Value = "Other Fees" Then
                            dgviewtransaction.Rows(row).Cells(2).Value = otherfeesacc
                        ElseIf dgviewtransaction.Rows(row).Cells(1).Value = "Exam Fees" Then
                            dgviewtransaction.Rows(row).Cells(2).Value = examfeesacc
                        ElseIf dgviewtransaction.Rows(row).Cells(1).Value = "Purchase Order" Then
                            dgviewtransaction.Rows(row).Cells(2).Value = purchaseorderacc
                        ElseIf dgviewtransaction.Rows(row).Cells(1).Value = "Sales Invoice" Then
                            dgviewtransaction.Rows(row).Cells(2).Value = salesinvoiceacc
                        End If
                    Next
                End If
            ElseIf cmbtransaction.Text = "Monthly Fees" Then
                cmd.CommandText = "select date,transactionid,name,paidamt from MonthlyFees where date>='" & cmbfrom.Text & "' and date<='" & cmbto.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    dgviewtransaction.Rows.Add()
                    dgviewtransaction.Rows(i).Cells(0).Value = dr("date").ToString()
                    dgviewtransaction.Rows(i).Cells(1).Value = "Monthly Fees"
                    dgviewtransaction.Rows(i).Cells(3).Value = dr("transactionid").ToString()
                    dgviewtransaction.Rows(i).Cells(4).Value = dr("name").ToString()
                    dgviewtransaction.Rows(i).Cells(5).Value = dr("paidamt").ToString()
                    i += 1
                End While
                dr.Close()
                If dgviewtransaction.Rows.Count > 0 Then
                    cmd.CommandText = "select monthlyfeesacc from DefaultInstitute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    Dim monthlyfeesacc As String = dr("monthlyfeesacc").ToString()
                    dr.Close()
                    For row As Integer = 0 To dgviewtransaction.Rows.Count - 1
                        dgviewtransaction.Rows(row).Cells(2).Value = monthlyfeesacc
                    Next
                End If
            ElseIf cmbtransaction.Text = "Yearly Fees" Then
                cmd.CommandText = "select date,token,name,pay from YearlyFees where date>='" & cmbfrom.Text & "' and date<='" & cmbto.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    dgviewtransaction.Rows.Add()
                    dgviewtransaction.Rows(i).Cells(0).Value = dr("date").ToString()
                    dgviewtransaction.Rows(i).Cells(1).Value = "Yearly Fees"
                    dgviewtransaction.Rows(i).Cells(3).Value = dr("token").ToString()
                    dgviewtransaction.Rows(i).Cells(4).Value = dr("name").ToString()
                    dgviewtransaction.Rows(i).Cells(5).Value = dr("pay").ToString()
                    i += 1
                End While
                dr.Close()
                If dgviewtransaction.Rows.Count > 0 Then
                    cmd.CommandText = "select yearlyfeesacc from DefaultInstitute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    Dim yearlyfeesacc As String = dr("yearlyfeesacc").ToString()
                    dr.Close()
                    For row As Integer = 0 To dgviewtransaction.Rows.Count - 1
                        dgviewtransaction.Rows(row).Cells(2).Value = yearlyfeesacc
                    Next
                End If
            ElseIf cmbtransaction.Text = "Late Fees" Then
                cmd.CommandText = "select date,transactionid,name,pay from LateFees where date>='" & cmbfrom.Text & "' and date<='" & cmbto.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    dgviewtransaction.Rows.Add()
                    dgviewtransaction.Rows(i).Cells(0).Value = dr("date").ToString()
                    dgviewtransaction.Rows(i).Cells(1).Value = "Late Fees"
                    dgviewtransaction.Rows(i).Cells(3).Value = dr("transactionid").ToString()
                    dgviewtransaction.Rows(i).Cells(4).Value = dr("name").ToString()
                    dgviewtransaction.Rows(i).Cells(5).Value = dr("pay").ToString()
                    i += 1
                End While
                dr.Close()
                If dgviewtransaction.Rows.Count > 0 Then
                    cmd.CommandText = "select latefeesacc from DefaultInstitute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    Dim latefeesacc As String = dr("latefeesacc").ToString()
                    dr.Close()
                    For row As Integer = 0 To dgviewtransaction.Rows.Count - 1
                        dgviewtransaction.Rows(row).Cells(2).Value = latefeesacc
                    Next
                End If
            ElseIf cmbtransaction.Text = "Library Fees" Then
                cmd.CommandText = "select date,transactionid,name,pay from libraryFees where date>='" & cmbfrom.Text & "' and date<='" & cmbto.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    dgviewtransaction.Rows.Add()
                    dgviewtransaction.Rows(i).Cells(0).Value = dr("date").ToString()
                    dgviewtransaction.Rows(i).Cells(1).Value = "Library Fees"
                    dgviewtransaction.Rows(i).Cells(3).Value = dr("transactionid").ToString()
                    dgviewtransaction.Rows(i).Cells(4).Value = dr("name").ToString()
                    dgviewtransaction.Rows(i).Cells(5).Value = dr("pay").ToString()
                    i += 1
                End While
                dr.Close()
                If dgviewtransaction.Rows.Count > 0 Then
                    cmd.CommandText = "select libraryfeesacc from DefaultInstitute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    Dim libraryfeesacc As String = dr("libraryfeesacc").ToString()
                    dr.Close()
                    For row As Integer = 0 To dgviewtransaction.Rows.Count - 1
                        dgviewtransaction.Rows(row).Cells(2).Value = libraryfeesacc
                    Next
                End If
            ElseIf cmbtransaction.Text = "Exam Fees" Then
                cmd.CommandText = "select date,transactionid,name,pay from ExamFee where date>='" & cmbfrom.Text & "' and date<='" & cmbto.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    dgviewtransaction.Rows.Add()
                    dgviewtransaction.Rows(i).Cells(0).Value = dr("date").ToString()
                    dgviewtransaction.Rows(i).Cells(1).Value = "Exam Fees"
                    dgviewtransaction.Rows(i).Cells(3).Value = dr("transactionid").ToString()
                    dgviewtransaction.Rows(i).Cells(4).Value = dr("name").ToString()
                    dgviewtransaction.Rows(i).Cells(5).Value = dr("pay").ToString()
                    i += 1
                End While
                dr.Close()
                If dgviewtransaction.Rows.Count > 0 Then
                    cmd.CommandText = "select examfeesacc from DefaultInstitute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    Dim examfeesacc As String = dr("examfeesacc").ToString()
                    dr.Close()
                    For row As Integer = 0 To dgviewtransaction.Rows.Count - 1
                        dgviewtransaction.Rows(row).Cells(2).Value = examfeesacc
                    Next
                End If
            ElseIf cmbtransaction.Text = "Other Fees" Then
                cmd.CommandText = "select date,transactionid,name,pay from OtherFees where date>='" & cmbfrom.Text & "' and date<='" & cmbto.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    dgviewtransaction.Rows.Add()
                    dgviewtransaction.Rows(i).Cells(0).Value = dr("date").ToString()
                    dgviewtransaction.Rows(i).Cells(1).Value = "Other Fees"
                    dgviewtransaction.Rows(i).Cells(3).Value = dr("transactionid").ToString()
                    dgviewtransaction.Rows(i).Cells(4).Value = dr("name").ToString()
                    dgviewtransaction.Rows(i).Cells(5).Value = dr("pay").ToString()
                    i += 1
                End While
                dr.Close()
                If dgviewtransaction.Rows.Count > 0 Then
                    cmd.CommandText = "select otherfeesacc from DefaultInstitute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    Dim otherfeesacc As String = dr("otherfeesacc").ToString()
                    dr.Close()
                    For row As Integer = 0 To dgviewtransaction.Rows.Count - 1
                        dgviewtransaction.Rows(row).Cells(2).Value = otherfeesacc
                    Next
                End If
            ElseIf cmbtransaction.Text = "Library Charges" Then
                cmd.CommandText = "select date,issueid,name,totalcharges,account from LibraryCharges where date>='" & cmbfrom.Text & "' and date<='" & cmbto.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    dgviewtransaction.Rows.Add()
                    dgviewtransaction.Rows(i).Cells(0).Value = dr("date").ToString()
                    dgviewtransaction.Rows(i).Cells(1).Value = "Library Charges"
                    dgviewtransaction.Rows(i).Cells(2).Value = dr("account").ToString()
                    dgviewtransaction.Rows(i).Cells(3).Value = dr("issueid").ToString()
                    dgviewtransaction.Rows(i).Cells(4).Value = dr("name").ToString()
                    dgviewtransaction.Rows(i).Cells(5).Value = dr("totalcharges").ToString()
                    i += 1
                End While
                dr.Close()
            ElseIf cmbtransaction.Text = "Sales Invoice" Then
                cmd.CommandText = "select invoicedate,invoiceno,customername,totalamount from SalesInvoice where invoicedate>='" & cmbfrom.Text & "' and invoicedate<='" & cmbto.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    dgviewtransaction.Rows.Add()
                    dgviewtransaction.Rows(i).Cells(0).Value = dr("invoicedate").ToString()
                    dgviewtransaction.Rows(i).Cells(1).Value = "Sales Invoice"
                    dgviewtransaction.Rows(i).Cells(3).Value = dr("invoiceno").ToString()
                    dgviewtransaction.Rows(i).Cells(4).Value = dr("customername").ToString()
                    dgviewtransaction.Rows(i).Cells(5).Value = dr("totalamount").ToString()
                    i += 1
                End While
                dr.Close()
                If dgviewtransaction.Rows.Count > 0 Then
                    cmd.CommandText = "select salesinvoiceacc from DefaultInstitute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    Dim salesinvoiceacc As String = dr("salesinvoiceacc").ToString()
                    dr.Close()
                    For row As Integer = 0 To dgviewtransaction.Rows.Count - 1
                        dgviewtransaction.Rows(row).Cells(2).Value = salesinvoiceacc
                    Next
                End If
            ElseIf cmbtransaction.Text = "Purchase Order" Then
                cmd.CommandText = "select purchasedate,purchaseid,vendorname,totalamount from Purchase where purchasedate>='" & cmbfrom.Text & "' and purchasedate<='" & cmbto.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    dgviewtransaction.Rows.Add()
                    dgviewtransaction.Rows(i).Cells(0).Value = dr("purchasedate").ToString()
                    dgviewtransaction.Rows(i).Cells(1).Value = "Purchase Order"
                    dgviewtransaction.Rows(i).Cells(3).Value = dr("purchaseid").ToString()
                    dgviewtransaction.Rows(i).Cells(4).Value = dr("vendorname").ToString()
                    dgviewtransaction.Rows(i).Cells(5).Value = dr("totalamount").ToString()
                    i += 1
                End While
                dr.Close()
                If dgviewtransaction.Rows.Count > 0 Then
                    cmd.CommandText = "select purchaseorderacc from DefaultInstitute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    Dim purchaseorderacc As String = dr("purchaseorderacc").ToString()
                    dr.Close()
                    For row As Integer = 0 To dgviewtransaction.Rows.Count - 1
                        dgviewtransaction.Rows(row).Cells(2).Value = purchaseorderacc
                    Next
                End If
            End If
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmTransaction_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
        'cmbperiod.Text = "This Period"
        FiscalYear()
    End Sub
#End Region
#Region "Attributes..."
    Private Sub cmbperiod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbperiod.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbfrom.Focus()
        End If
    End Sub

    Private Sub cmbperiod_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbperiod.TextChanged
        If cmbperiod.Text = "All" Then
            cmbfrom.Text = STR1(0).ToString()
            cmbto.Text = STR2(11).ToString()

        ElseIf cmbperiod.Text = "Range" Then
            cmbfrom.Text = ""
            cmbto.Text = ""

        ElseIf cmbperiod.Text = "Today" Then
            cmbfrom.Text = UmbrellaSystemDate
            cmbto.Text = UmbrellaSystemDate

        ElseIf cmbperiod.Text = "This Period" Then
            cmbfrom.Text = STR1(0).ToString()
            cmbto.Text = STR2(11).ToString()

        ElseIf cmbperiod.Text = "This Year" Then
            Dim today As Date = CDate(UmbrellaSystemDate)
            Dim yy As Integer = today.Year
            Dim st1 As String = "1/1/" + yy.ToString()
            cmbfrom.Text = st1
            Dim st2 As String = "31/12/" + yy.ToString()
            cmbto.Text = st2

        ElseIf cmbperiod.Text = "This Week to Date" Then
            Dim today As Date = CDate(UmbrellaSystemDate)
            Dim dayIndex As Integer = today.DayOfWeek
            If dayIndex < DayOfWeek.Monday Then
                dayIndex += 7
            End If
            Dim dayDiff As Integer = dayIndex - DayOfWeek.Monday
            Dim monday As Date = today.AddDays(-dayDiff)
            Dim startdate As String = monday.ToShortDateString()
            Dim sunday As Date = monday.AddDays(6)
            Dim enddate As String = sunday.ToShortDateString()
            cmbfrom.Text = startdate
            cmbto.Text = UmbrellaSystemDate

        ElseIf cmbperiod.Text = "This Month to Date" Then
            Dim today As Date = CDate(UmbrellaSystemDate)
            Dim mm As Integer = today.Month
            Dim yy As Integer = today.Year
            Dim st As String = "1/" + mm.ToString() + "/" + yy.ToString()
            cmbfrom.Text = st
            cmbto.Text = UmbrellaSystemDate

        ElseIf cmbperiod.Text = "This Period to Date" Then
            cmbfrom.Text = STR1(0).ToString()
            cmbto.Text = UmbrellaSystemDate

        ElseIf cmbperiod.Text = "This Year to Date" Then
            Dim today As Date = CDate(UmbrellaSystemDate)
            Dim yy As Integer = today.Year
            Dim st1 As String = "1/1/" + yy.ToString()
            cmbfrom.Text = st1
            cmbto.Text = UmbrellaSystemDate
        End If
    End Sub

    Private Sub cmbfrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbfrom.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbto.Focus()
        End If
    End Sub

    Private Sub cmbto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbto.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbtransaction.Focus()
        End If
    End Sub

    Private Sub cmbtransaction_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbtransaction.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnfind.Focus()
        End If
    End Sub

    Private Sub ComboBoxKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbfrom.KeyPress, cmbperiod.KeyPress, cmbto.KeyPress, cmbtransaction.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnfind_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If cmbperiod.Text = "" Then
            Dim result = MessageBox.Show("Please enter/select time period.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                cmbperiod.Focus()
            End If
        ElseIf cmbfrom.Text = "" Then
            Dim result = MessageBox.Show("Please enter/select from date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                cmbfrom.Focus()
            End If
        ElseIf cmbto.Text = "" Then
            Dim result = MessageBox.Show("Please enter/select to date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                cmbto.Focus()
            End If
        ElseIf cmbtransaction.Text = "" Then
            Dim result = MessageBox.Show("Please enter/select transaction.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                cmbtransaction.Focus()
            End If
        Else
            FindTransaction()
        End If
    End Sub

    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        dgviewtransaction.Rows.Clear()
        cmbperiod.Text = ""
        cmbfrom.Text = ""
        cmbto.Text = ""
        cmbtransaction.Text = "All"
    End Sub

    Private Sub btnprint_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnprint.ClickButtonArea

    End Sub

    Private Sub btndetail_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndetail.ClickButtonArea

    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region