#Region "Imports..."
Imports System
Imports System.Data
Imports System.Data.SqlClient
#End Region
#Region "Class cSalary..."
Public Class cSalary
#Region "Declarations..."
    Public TotalEmployee As Integer = 0
    Private STOK As Boolean = False
    Private PWH As Boolean = False
    Private PT As Boolean = False
    Private AD As Boolean = False
    Private IndividualPF As Boolean = False
    Private empIncr As Boolean = False
    Private CPF As Decimal = 0.0
    Private OldBasic As Decimal = 0.0
    Private Arierr As Decimal = 0.0
    Private hscale As Decimal = 0.0
    Private pblscale As Decimal = 0.0
    Private bpay As Decimal = 0.0
    Private gradepay As Decimal = 0.0
    Private thismonth As Integer = 0
    Private lastmonth As Integer = 0
    Private basicadjust As Decimal = 0.0
    Private daadjust As Decimal = 0.0
    Private hraadjust As Decimal = 0.0
    Private otheradjust As Decimal = 0.0
    Private ccsadjust As Decimal = 0.0
    Private incometaxadjust As Decimal = 0.0
    Private salaryadjust As Decimal = 0.0
    Private conveyancealw As Decimal = 0.0
    Private handicappedalw As Decimal = 0.0
    Private washingalw As Decimal = 0.0
    Private pfdeduction As Decimal = 0.0
    Private conveyancealwrs As Decimal = 0.0
    Private handicappedalwrs As Decimal = 0.0
    Private washingalwrs As Decimal = 0.0
    Private pfdeductionrs As Decimal = 0.0
    Private specialpay As Decimal = 0.0
    Private gslideduction As Decimal = 0.0
    Private houserent As Decimal = 0.0
    Private pfadvancerecovery As Decimal = 0.0
    Private ccsloan As Decimal = 0.0
    Private otherbankloan As Decimal = 0.0
    Private festivaladvance As Decimal = 0.0
    Private ccspo1loan As Decimal = 0.0
    Private ccspo2loan As Decimal = 0.0
    Private bankloan As Decimal = 0.0
    Private ppfloan As Decimal = 0.0
    Private stopincrement As String = ""
    Private paywithheld As String = ""
    Private DaDeductThis As Decimal = 0.0
    Private DaDeductLast As Decimal = 0.0
    Private MedicalDeductThis As Decimal = 0.0
    Private MedicalDeductLast As Decimal = 0.0
    Private HRADeductThis As Decimal = 0.0
    Private HRADeductLast As Decimal = 0.0
    Private DAGet As Decimal = 0.0
    Private HRAGet As Decimal = 0.0
    Private DeductedDA As Decimal = 0.0
    Private DeductedHRA As Decimal = 0.0
    Private DeductedMedical As Decimal = 0.0
    Private Medical As Decimal = 0.0
    Private PF As Decimal = 0.0
    Private RsAll As Decimal = 0.0
    Private Allowances As Decimal = 0.0
    Private da1 As Decimal = 0.0
    Private da2 As Decimal = 0.0
    Private TaxRate As Decimal = 0.0
    Private TaxD As Decimal = 0.0
    Private Deduct As Decimal = 0.0
    Private Gain As Decimal = 0.0
    Private NetPay As Decimal = 0.0
    Private TotalMinutes As Integer = 0
    Private TotalDays As Integer = 0
    Public AddSalaryOk As Boolean = False
#End Region
#Region "Salary Calculations..."
#Region "Monthly Salary Calculation..."
    Public Sub Salary_Calculation(ByVal MNTH As String, ByVal YR As Integer, ByVal DESGN As String)
        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("select * from Employee where designation='" & DESGN & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'", conn)
            da.Fill(dt)
            For Each dr As DataRow In dt.Rows
                EmpName = dr("name").ToString()
                BasicIncr(MNTH, YR, dr("name").ToString(), dr("joiningdate").ToString(), dr("empid").ToString(), CDec(dr("basic").ToString()), CDec(dr("grade").ToString()))
                DAHRAMedicalDeduct(dr("empid").ToString(), MNTH, YR)
                CalculateDAHRAMedical(dr("empid").ToString(), MNTH, YR)
                PFDeductionAll(dr("empid").ToString(), YR, dr("joiningdate").ToString())
                GrossPay(dr("empid").ToString(), dr("designation").ToString(), dr("name").ToString(), dr("joiningdate").ToString(), MNTH, YR)
                UpdateEmployee(dr("empid").ToString())
                TotalEmployee = TotalEmployee + 1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub EmpIncrement(ByVal empid As String)
        Try
            cmd.CommandText = "select incremented from Employee where empid='" & empid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr("incremented").ToString() = "Yes" Then
                empIncr = True
            Else
                empIncr = False
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub BasicIncr(ByVal month As String, ByVal year As Integer, ByVal empname As String, ByVal doj As String, ByVal empid As String, ByVal basicpay As Decimal, ByVal grade As Decimal)
        Try
            OldBasic = basicpay
            Dim DTE As TimeSpan
            Dim mmdte As Date = Date.Parse(doj)
            Dim mm As Integer = mmdte.Month
            Dim mon As Integer = Date.Now.Month
            DTE = Date.Parse((Date.Today).ToShortDateString) - Date.Parse(doj)
            Dim Days As Integer = CInt(DTE.TotalDays)
            Dim YY As Integer
            Dim dt As Date = Date.Parse(doj.ToString())
            YY = dt.Year
            Dim Incr As Decimal = 0.0
            If Days > 365 Then
                If mm = mon Then
                    EmpIncrement(empid)
                    If empIncr = False Then
                        Dim ty As Integer = Days / 365
                        For i As Integer = 0 To ty - 1
                            basicpay = basicpay + ((basicpay * PSDBasicIncrement) / 100)
                        Next
                        If basicpay Mod 10 <> 0 Then
                            Dim dig As Integer
                            dig = basicpay Mod 10
                            basicpay -= dig
                            basicpay += 10
                        End If
                        empIncr = True
                    Else
                        basicpay = basicpay + ((basicpay * PSDBasicIncrement) / 100)
                        If basicpay Mod 10 <> 0 Then
                            Dim dig As Integer
                            dig = basicpay Mod 10
                            basicpay -= dig
                            basicpay += 10
                        End If
                    End If
                End If
            End If
            bpay = basicpay
            StopIncrementThis(empid, year)
            If STOK = True Then
                bpay = OldBasic
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub StopIncrementThis(ByVal regno As String, ByVal yr As Integer)
        Try
            cmd.CommandText = "select stopincrement from AdjustmentDeductions where regno='" & regno & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr("stopincrement").ToString() = "No" Then
                STOK = False
                stopincrement = "No"
            Else
                STOK = True
                stopincrement = "Yes"
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
            STOK = False
        End Try
    End Sub

    Public Sub CheckLeave(ByVal regno As String, ByVal month As String, ByVal year As Integer)
        Try
            cmd.CommandText = "select thismonth,lastmonth from AdjustmentDeductions where regno='" & regno & "' and month='" & month & "' and year=" & year & ""
            dr = cmd.ExecuteReader
            If dr.Read() Then
                thismonth = Val(dr("thismonth").ToString())
                lastmonth = Val(dr("lastmonth").ToString())
            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub DAHRAMedicalDeduct(ByVal Code As String, ByVal Month As String, ByVal Year As Integer)
        Try
            Month = Month.ToUpper().ToString()
            CheckLeave(Code, Month, Year)
            Dim mm As Integer = 0
            If Month = "JANUARY" Then
                mm = 1
            ElseIf Month = "FEBRUARY" Then
                mm = 2
            ElseIf Month = "MARCH" Then
                mm = 3
            ElseIf Month = "APRIL" Then
                mm = 4
            ElseIf Month = "MAY" Then
                mm = 5
            ElseIf Month = "JUNE" Then
                mm = 6
            ElseIf Month = "JULY" Then
                mm = 7
            ElseIf Month = "AUGUST" Then
                mm = 8
            ElseIf Month = "SEPTEMBER" Then
                mm = 9
            ElseIf Month = "OCTOBER" Then
                mm = 10
            ElseIf Month = "NOVEMBER" Then
                mm = 11
            ElseIf Month = "DECEMBER" Then
                mm = 12
            End If
            Dim ID As Integer
            Dim EM(2) As Integer
            Dim i As Integer = 0
            cmd.CommandText = "select effectmonth from DaHra where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                EM(i) = CInt(dr("effectmonth").ToString())
                i = i + 1
            End While
            dr.Close()
            For j As Integer = 0 To 1
                If mm >= EM(j) Then
                    ID = EM(j)
                End If
            Next

            cmd.CommandText = "select darate,hrarate,medical from DaHra where effectmonth=" & ID & " and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                Dim DaRate As Decimal = CDec(dr("darate").ToString())
                Dim HRARate As Decimal = CDec(dr("hrarate").ToString())
                Dim Med As Decimal = CDec(dr("medical").ToString())

                Dim td As Integer = 0
                td = CInt(Date.DaysInMonth(Year, mm))
                Dim dinm As Decimal = CDec(DaRate / td)
                Dim Medi As Decimal = CDec(Med / td)
                Dim hinm As Decimal = CDec(HRARate / td)

                Dim tda As Decimal = CDec(thismonth * dinm)
                DaDeductThis = CDec((bpay * tda) / 100)
                Dim tdb As Decimal = CDec(lastmonth * dinm)
                DaDeductLast = CDec((bpay * tdb) / 100)

                Dim tha As Decimal = CDec(thismonth * hinm)
                HRADeductThis = CDec((bpay * tha) / 100)
                Dim thb As Decimal = CDec(lastmonth * hinm)
                HRADeductLast = CDec((bpay * thb) / 100)

                MedicalDeductThis = Medi * thismonth
                MedicalDeductLast = Medi * lastmonth
            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub CalculateDAHRAMedical(ByVal code As String, ByVal MONTH As String, ByVal YEAR As Integer)
        Try
            cmd.CommandText = "select darate,hrarate,medical,maximum from DaHra where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim DaRate As Decimal = CDec(dr("darate").ToString())
            Dim HRARate As Decimal = CDec(dr("hrarate").ToString())
            Dim Med As Decimal = CDec(dr("medical").ToString())
            Dim Maximum As Decimal = CDec(dr("maximum").ToString())

            DAGet = CDec((bpay * DaRate) / 100)
            If DAGet > Maximum Then
                DAGet = Maximum
            End If
            HRAGet = Val((bpay * HRARate) / 100)
            If HRAGet > Maximum Then
                HRAGet = Maximum
            End If
            DeductedDA = DaDeductLast + DaDeductThis
            DeductedHRA = HRADeductLast + HRADeductThis
            DeductedMedical = MedicalDeductLast + MedicalDeductThis
            DAGet = DAGet - DeductedDA
            HRAGet = HRAGet - DeductedHRA
            Medical = Medical - DeductedMedical
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckIndividualPF(ByVal empid As String, ByVal year As Integer, ByVal DOJ As String)
        Try
            cmd.CommandText = "select * from PFRateIndividual where regno='" & empid & "' and year=" & year & " and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                IndividualPF = True
            Else
                IndividualPF = False
            End If
            dr.Close()
        Catch ex As Exception
            IndividualPF = False
            dr.Close()
        End Try
    End Sub

    Public Sub PFDeductionAll(ByVal empid As String, ByVal year As Integer, ByVal DOJ As String)
        CheckIndividualPF(empid, year, DOJ)
        If IndividualPF = True Then
            Dim DTE As TimeSpan
            DTE = Date.Parse((Date.Today).ToShortDateString) - Date.Parse(DOJ)
            Dim Days As Integer = CInt(DTE.TotalDays)
            cmd.CommandText = "select rate,amount from PFRateIndividual where regno='" & empid & "' and year=" & year & " and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim cPFrate As Decimal = CDec(dr("rate").ToString())
            Dim cPFRupees As Decimal = CDec(dr("amount").ToString())
            dr.Close()
            If Days > 365 Then
                CPF = ((bpay * cPFrate) / 100)
            Else
                CPF = 0
            End If
            If cPFRupees <> 0 Then
                If CPF > cPFRupees Then
                    CPF = cPFRupees
                End If
            End If
        Else
            Dim DTE As TimeSpan
            DTE = Date.Parse((Date.Today).ToShortDateString) - Date.Parse(DOJ)
            Dim Days As Integer = CInt(DTE.TotalDays)
            cmd.CommandText = "select rate,amount from PFRate where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim cPFrate As Decimal = CDec(dr("rate").ToString())
            Dim cPFRupees As Decimal = CDec(dr("amount").ToString())
            dr.Close()
            If Days > 365 Then
                CPF = ((bpay * cPFrate) / 100)
            Else
                CPF = 0
            End If
            If cPFRupees <> 0 Then
                If CPF > cPFRupees Then
                    CPF = cPFRupees
                End If
            End If
        End If
    End Sub

    Public Sub GrossPay(ByVal empid As String, ByVal desig As String, ByVal name As String, ByVal DOJ As String, ByVal Month As String, ByVal Year As Integer)
        Try
            Dim DTE As TimeSpan
            DTE = Date.Parse((Date.Today).ToShortDateString) - Date.Parse(DOJ)
            Dim Days As Integer = CInt(DTE.TotalDays)
            AdjustmentDeduction(empid, Month, Year)
            Arrier(bpay)
            Tax(empid)

            Deduct = basicadjust + daadjust + hraadjust + otheradjust + ccsadjust + incometaxadjust + pfadvancerecovery + otherbankloan + festivaladvance + ccspo1loan + ccspo2loan + bankloan + ppfloan + gslideduction + PF + CPF + DeductedDA + TaxD
            Gain = specialpay + houserent + DAGet + HRAGet + Arierr + Allowances + RsAll + Medical
            NetPay = ((bpay - Deduct) + Gain)

            PayWithHeldThis(empid, Month, Year)

            If PWH = True Then
                NetPay = 0
            End If
            Dim totalpay As Integer = CInt(NetPay.ToString())
            NetPay = totalpay
            dr.Close()
            InsertSalary(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, Month, Year, empid, desig, name, DOJ, thismonth, lastmonth, basicadjust, daadjust, hraadjust, otheradjust, ccsadjust, incometaxadjust, salaryadjust, conveyancealw, handicappedalw, washingalw, pfdeduction, conveyancealwrs, handicappedalwrs, washingalwrs, pfdeductionrs, specialpay, gslideduction, houserent, pfadvancerecovery, ccsloan, otherbankloan, festivaladvance, ccspo1loan, ccspo2loan, bankloan, ppfloan, DAGet, Arierr, HRAGet, DaDeductThis, DaDeductLast, DeductedDA, HRADeductThis, HRADeductLast, DeductedHRA, DeductedMedical, TaxD, Deduct, Gain, bpay, CPF, NetPay, stopincrement, paywithheld)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub AdjustmentDeduction(ByVal regno As String, ByVal Month As String, ByVal Year As Integer)
        Try
            cmd.CommandText = "select * from AdjustmentDeductions where regno='" & regno & "' and month='" & Month & "' and year=" & Year & " and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            pfdeduction = CDec(dr("pfdeduction").ToString())
            pfdeductionrs = CDec(dr("pfdeductionrs").ToString())
            PF = (bpay * pfdeduction) / 100
            If pfdeductionrs <> 0 Then
                PF = pfdeductionrs
            End If
            specialpay = CDec(dr("specialpay").ToString())
            gslideduction = CDec(dr("gslideduction").ToString())
            houserent = CDec(dr("houserent").ToString())
            conveyancealw = CDec(dr("conveyancealw").ToString())
            conveyancealwrs = CDec(dr("conveyancealwrs").ToString())
            handicappedalw = CDec(dr("handicappedalw").ToString())
            handicappedalwrs = CDec(dr("handicappedalwrs").ToString())
            washingalw = CDec(dr("washingalw").ToString())
            washingalwrs = CDec(dr("washingalwrs").ToString())
            RsAll = conveyancealwrs + handicappedalwrs + washingalwrs
            Allowances = conveyancealw + handicappedalw + washingalw
            basicadjust = CDec(dr("basicadjust").ToString())
            daadjust = CDec(dr("daadjust").ToString())
            hraadjust = CDec(dr("hraadjust").ToString())
            otheradjust = CDec(dr("otheradjust").ToString())
            ccsadjust = CDec(dr("ccsadjust").ToString())
            incometaxadjust = CDec(dr("incometaxadjust").ToString())
            pfadvancerecovery = CDec(dr("pfadvancerecovery").ToString())
            ccsloan = CDec(dr("ccsloan").ToString())
            otherbankloan = CDec(dr("otherbankloan").ToString())
            festivaladvance = CDec(dr("festivaladvance").ToString())
            ccspo1loan = CDec(dr("ccspo1loan").ToString())
            ccspo2loan = CDec(dr("ccspo2loan").ToString())
            bankloan = CDec(dr("bankloan").ToString())
            ppfloan = CDec(dr("ppfloan").ToString())
            dr.Close()
            cmd.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Arrier(ByVal basic As Decimal)
        Try
            Dim ID1 As Integer = 0
            Dim ID2 As Integer = 1

            cmd.CommandText = "select darate,effectmonth from DaHra where ID=" & ID1 & " and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            da1 = CDec(dr("darate").ToString())
            Dim effectmonth1 As Integer = CInt(dr("effectmonth").ToString())
            dr.Close()

            cmd.CommandText = "select darate,effectmonth from DaHra where ID=" & ID2 & " and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            da2 = CDec(dr("darate").ToString())
            Dim effectmonth2 As Integer = CInt(dr("effectmonth").ToString())
            dr.Close()

            Dim exda As Decimal = 0
            If da2 >= da1 Then
                exda = da2 - da1
            Else
                exda = da1
            End If

            Dim mon As Integer = CInt(DateTime.Now.Month)
            If mon >= effectmonth1 And mon <= effectmonth2 Then
                Arierr = ((basic * exda) / 100)
                Arierr *= mon
            ElseIf mon > effectmonth2 And mon <= 12 Then
                Dim subm As Integer = mon - effectmonth2
                Arierr = ((basic * exda) / 100)
                Arierr *= subm
            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Tax(ByVal empid As String)
        Try
            cmd.CommandText = "select gross,taxrate from ProfessionalTax where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If bpay > CDec(dr("gross").ToString()) Then
                TaxRate = CDec(dr("taxrate").ToString())
            End If
            TaxD = CDec((bpay * TaxRate) / 100)
            dr.Close()
            Dim ph As String = ""
            cmd.CommandText = "select * from Employee where empid='" & empid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            ph = dr("handicapped").ToString()
            dr.Close()
            If ph = "Yes" Then
                TaxD = 0.0
            End If
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub PayWithHeldThis(ByVal code As String, ByVal month As String, ByVal year As Integer)
        Try
            cmd.CommandText = "select paywithheld from AdjustmentDeductions where regno='" & code & "' and month='" & month & "' and year= " & year & " and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr("paywithheld").ToString() = "No" Then
                PWH = False
                paywithheld = "No"
            Else
                PWH = True
                paywithheld = "yes"
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
            PWH = False
        End Try
    End Sub

    Public Sub UpdateEmployee(ByVal empid As String)
        Try
            Dim incremented As String
            If empIncr = True Then
                incremented = "Yes"
            Else
                incremented = "No"
            End If
            cmd.CommandText = "update Employee set basic='" & bpay & "',incremented='" & incremented & "' where empid='" & empid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub InsertSalary(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal month As String, ByVal year As Integer, ByVal regno As String, ByVal designation As String, ByVal name As String, ByVal doj As String, ByVal thismonth As Integer, ByVal lastmonth As Integer, ByVal basicadjust As Decimal, ByVal daadjust As Decimal, ByVal hraadjust As Decimal, ByVal otheradjust As Decimal, ByVal ccsadjust As Decimal, ByVal incometaxadjust As Decimal, ByVal salaryadjust As Decimal, ByVal conveyancealw As Decimal, ByVal handicappedalw As Decimal, ByVal washingalw As Decimal, ByVal pfdeduction As Decimal, ByVal conveyancealwrs As Decimal, ByVal handicappedalwrs As Decimal, ByVal washingalwrs As Decimal, ByVal pfdeductionrs As Decimal, ByVal specialpay As Decimal, ByVal gslideduction As Decimal, ByVal houserent As Decimal, ByVal pfadvancerecovery As Decimal, ByVal ccsloan As Decimal, ByVal otherbankloan As Decimal, ByVal festivaladvance As Decimal, ByVal ccspo1loan As Decimal, ByVal ccspo2loan As Decimal, ByVal bankloan As Decimal, ByVal ppfloan As Decimal, ByVal GetDA As Decimal, ByVal GetArrier As Decimal, ByVal GetHRA As Decimal, ByVal DADeductThis As Decimal, ByVal DADeductLast As Decimal, ByVal DADeductionTotal As Decimal, ByVal HRADeductThis As Decimal, ByVal HRADeductLast As Decimal, ByVal HRADeductTotal As Decimal, ByVal DeductedMedical As Decimal, ByVal ProfessionTax As Decimal, ByVal TotalDeduction As Decimal, ByVal TotalGain As Decimal, ByVal NewBasic As Decimal, ByVal EmployerPFDeduct As Decimal, ByVal NetPay As Decimal, ByVal stopincrement As String, ByVal paywithheld As String)
        Try
            cmd.CommandText = "insert into Salary(InsID,InsName,Period,month,year,regno,designation,name,thismonth,lastmonth,basicadjust,daadjust,hraadjust,otheradjust,ccsadjust,incometaxadjust,salaryadjust,conveyancealw,handicappedalw,washingalw,pfdeduction,conveyancealwrs,handicappedalwrs,washingalwrs,pfdeductionrs,specialpay,gslideduction,houserent,pfadvancerecovery,ccsloan,otherbankloan,festivaladvance,ccspo1loan,ccspo2loan,bankloan,ppfloan,GetDA,GetArrier,GetHRA,DADeductThis,DADeductLast,DADeductionTotal,HRADeductThis,HRADeductLast,HRADeductTotal,DeductedMedical,ProfessionTax,TotalDeduction,TotalGain,NewBasic,EmployerPFDeduct,NetPay,stopincrement,paywithheld) values('" & InsID & "','" & InsName & "','" & Periodd & "','" & month & "'," & year & ",'" & regno & "','" & designation & "','" & name & "'," & thismonth & "," & lastmonth & "," & basicadjust & "," & daadjust & "," & hraadjust & "," & otheradjust & "," & ccsadjust & "," & incometaxadjust & "," & salaryadjust & "," & conveyancealw & "," & handicappedalw & "," & washingalw & "," & pfdeduction & "," & conveyancealwrs & "," & handicappedalwrs & "," & washingalwrs & "," & pfdeductionrs & "," & specialpay & "," & gslideduction & "," & houserent & "," & pfadvancerecovery & "," & ccsloan & "," & otherbankloan & "," & festivaladvance & "," & ccspo1loan & "," & ccspo2loan & "," & bankloan & "," & ppfloan & "," & GetDA & "," & GetArrier & "," & GetHRA & "," & DADeductThis & "," & DADeductLast & "," & DADeductionTotal & "," & HRADeductThis & "," & HRADeductLast & "," & HRADeductTotal & "," & DeductedMedical & "," & ProfessionTax & "," & TotalDeduction & "," & TotalGain & "," & NewBasic & "," & EmployerPFDeduct & "," & NetPay & ",'" & stopincrement & "','" & paywithheld & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update PF set openingbalance=openingbalance+" & EmployerPFDeduct & " where InsID='" & InsID & "' and InsName='" & InsName & "' and period='" & Periodd & "' and regno='" & regno & "' and designation='" & designation & "' and name='" & name & "' and joiningdate='" & doj & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddSalaryOk = True
        Catch ex As Exception
            AddSalaryOk = False
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Annual Salary Calculation..."
    Public Sub Annual_Salary_Calculation(ByVal MNTH As String, ByVal YR As Integer, ByVal DESGN As String)
        Try
            Dim MonT(11) As String
            Dim YrT(11) As Integer
            Dim mon As Integer = Date.Now.Month
            If mon = 1 Then
                MonT(0) = "January"
                YrT(0) = YR
                MonT(1) = "February"
                YrT(1) = YR
                MonT(2) = "March"
                YrT(2) = YR
                MonT(3) = "April"
                YrT(3) = YR
                MonT(4) = "May"
                YrT(4) = YR
                MonT(5) = "June"
                YrT(5) = YR
                MonT(6) = "July"
                YrT(6) = YR
                MonT(7) = "August"
                YrT(7) = YR
                MonT(8) = "September"
                YrT(8) = YR
                MonT(9) = "October"
                YrT(9) = YR
                MonT(10) = "November"
                YrT(10) = YR
                MonT(11) = "December"
                YrT(11) = YR
            ElseIf mon = 2 Then
                MonT(0) = "February"
                YrT(0) = YR
                MonT(1) = "March"
                YrT(1) = YR
                MonT(2) = "April"
                YrT(2) = YR
                MonT(3) = "May"
                YrT(3) = YR
                MonT(4) = "June"
                YrT(4) = YR
                MonT(5) = "July"
                YrT(5) = YR
                MonT(6) = "August"
                YrT(6) = YR
                MonT(7) = "September"
                YrT(7) = YR
                MonT(8) = "October"
                YrT(8) = YR
                MonT(9) = "November"
                YrT(9) = YR
                MonT(10) = "December"
                YrT(10) = YR
                MonT(11) = "January"
                YrT(11) = YR + 1
            ElseIf mon = 3 Then
                MonT(0) = "March"
                YrT(0) = YR
                MonT(1) = "April"
                YrT(1) = YR
                MonT(2) = "May"
                YrT(2) = YR
                MonT(3) = "June"
                YrT(3) = YR
                MonT(4) = "July"
                YrT(4) = YR
                MonT(5) = "August"
                YrT(5) = YR
                MonT(6) = "September"
                YrT(6) = YR
                MonT(7) = "October"
                YrT(7) = YR
                MonT(8) = "November"
                YrT(8) = YR
                MonT(9) = "December"
                YrT(9) = YR
                MonT(10) = "January"
                YrT(10) = YR + 1
                MonT(11) = "February"
                YrT(11) = YR + 1
            ElseIf mon = 4 Then
                MonT(0) = "April"
                YrT(0) = YR
                MonT(1) = "May"
                YrT(1) = YR
                MonT(2) = "June"
                YrT(2) = YR
                MonT(3) = "July"
                YrT(3) = YR
                MonT(4) = "August"
                YrT(4) = YR
                MonT(5) = "September"
                YrT(5) = YR
                MonT(6) = "October"
                YrT(6) = YR
                MonT(7) = "November"
                YrT(7) = YR
                MonT(8) = "December"
                YrT(8) = YR
                MonT(9) = "January"
                YrT(9) = YR + 1
                MonT(10) = "February"
                YrT(10) = YR + 1
                MonT(11) = "March"
                YrT(11) = YR + 1
            ElseIf mon = 5 Then
                MonT(0) = "May"
                YrT(0) = YR
                MonT(1) = "June"
                YrT(1) = YR
                MonT(2) = "July"
                YrT(2) = YR
                MonT(3) = "August"
                YrT(3) = YR
                MonT(4) = "September"
                YrT(4) = YR
                MonT(5) = "October"
                YrT(5) = YR
                MonT(6) = "November"
                YrT(6) = YR
                MonT(7) = "December"
                YrT(7) = YR
                MonT(8) = "January"
                YrT(8) = YR + 1
                MonT(9) = "February"
                YrT(9) = YR + 1
                MonT(10) = "March"
                YrT(10) = YR + 1
                MonT(11) = "April"
                YrT(11) = YR + 1
            ElseIf mon = 6 Then
                MonT(0) = "June"
                YrT(0) = YR
                MonT(1) = "July"
                YrT(1) = YR
                MonT(2) = "August"
                YrT(2) = YR
                MonT(3) = "September"
                YrT(3) = YR
                MonT(4) = "October"
                YrT(4) = YR
                MonT(5) = "November"
                YrT(5) = YR
                MonT(6) = "December"
                YrT(6) = YR
                MonT(7) = "January"
                YrT(7) = YR + 1
                MonT(8) = "February"
                YrT(8) = YR + 1
                MonT(9) = "March"
                YrT(9) = YR + 1
                MonT(10) = "April"
                YrT(10) = YR + 1
                MonT(11) = "May"
                YrT(11) = YR + 1
            ElseIf mon = 7 Then
                MonT(0) = "July"
                YrT(0) = YR
                MonT(1) = "August"
                YrT(1) = YR
                MonT(2) = "September"
                YrT(2) = YR
                MonT(3) = "October"
                YrT(3) = YR
                MonT(4) = "November"
                YrT(4) = YR
                MonT(5) = "December"
                YrT(5) = YR
                MonT(6) = "January"
                YrT(6) = YR + 1
                MonT(7) = "February"
                YrT(7) = YR + 1
                MonT(8) = "March"
                YrT(8) = YR + 1
                MonT(9) = "April"
                YrT(9) = YR + 1
                MonT(10) = "May"
                YrT(10) = YR + 1
                MonT(11) = "June"
                YrT(11) = YR + 1
            ElseIf mon = 8 Then
                MonT(0) = "August"
                YrT(0) = YR
                MonT(1) = "September"
                YrT(1) = YR
                MonT(2) = "October"
                YrT(2) = YR
                MonT(3) = "November"
                YrT(3) = YR
                MonT(4) = "December"
                YrT(4) = YR
                MonT(5) = "January"
                YrT(5) = YR + 1
                MonT(6) = "February"
                YrT(6) = YR + 1
                MonT(7) = "March"
                YrT(7) = YR + 1
                MonT(8) = "April"
                YrT(8) = YR + 1
                MonT(9) = "May"
                YrT(9) = YR + 1
                MonT(10) = "June"
                YrT(10) = YR + 1
                MonT(11) = "July"
                YrT(11) = YR + 1
            ElseIf mon = 9 Then
                MonT(0) = "September"
                YrT(0) = YR
                MonT(1) = "October"
                YrT(1) = YR
                MonT(2) = "November"
                YrT(2) = YR
                MonT(3) = "December"
                YrT(3) = YR
                MonT(4) = "January"
                YrT(4) = YR + 1
                MonT(5) = "February"
                YrT(5) = YR + 1
                MonT(6) = "March"
                YrT(6) = YR + 1
                MonT(7) = "April"
                YrT(7) = YR + 1
                MonT(8) = "May"
                YrT(8) = YR + 1
                MonT(9) = "June"
                YrT(9) = YR + 1
                MonT(10) = "July"
                YrT(10) = YR + 1
                MonT(11) = "August"
                YrT(11) = YR + 1
            ElseIf mon = 10 Then
                MonT(0) = "October"
                YrT(0) = YR
                MonT(1) = "November"
                YrT(1) = YR
                MonT(2) = "December"
                YrT(2) = YR
                MonT(3) = "January"
                YrT(3) = YR + 1
                MonT(4) = "February"
                YrT(4) = YR + 1
                MonT(5) = "March"
                YrT(5) = YR + 1
                MonT(6) = "April"
                YrT(6) = YR + 1
                MonT(7) = "May"
                YrT(7) = YR + 1
                MonT(8) = "June"
                YrT(8) = YR + 1
                MonT(9) = "July"
                YrT(9) = YR + 1
                MonT(10) = "August"
                YrT(10) = YR + 1
                MonT(11) = "September"
                YrT(11) = YR + 1
            ElseIf mon = 11 Then
                MonT(0) = "November"
                YrT(0) = YR
                MonT(1) = "December"
                YrT(1) = YR
                MonT(2) = "January"
                YrT(2) = YR + 1
                MonT(3) = "February"
                YrT(3) = YR + 1
                MonT(4) = "March"
                YrT(4) = YR + 1
                MonT(5) = "April"
                YrT(5) = YR + 1
                MonT(6) = "May"
                YrT(6) = YR + 1
                MonT(7) = "June"
                YrT(7) = YR + 1
                MonT(8) = "July"
                YrT(8) = YR + 1
                MonT(9) = "August"
                YrT(9) = YR + 1
                MonT(10) = "September"
                YrT(10) = YR + 1
                MonT(11) = "October"
                YrT(11) = YR + 1
            ElseIf mon = 12 Then
                MonT(0) = "December"
                YrT(0) = YR
                MonT(1) = "January"
                YrT(1) = YR + 1
                MonT(2) = "February"
                YrT(2) = YR + 1
                MonT(3) = "March"
                YrT(3) = YR + 1
                MonT(4) = "April"
                YrT(4) = YR + 1
                MonT(5) = "May"
                YrT(5) = YR + 1
                MonT(6) = "June"
                YrT(6) = YR + 1
                MonT(7) = "July"
                YrT(7) = YR + 1
                MonT(8) = "August"
                YrT(8) = YR + 1
                MonT(9) = "September"
                YrT(9) = YR + 1
                MonT(10) = "October"
                YrT(10) = YR + 1
                MonT(11) = "November"
                YrT(11) = YR + 1
            End If
            For i As Integer = 0 To 11
                Salary_Calculation(MonT(i), YrT(i), DESGN)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub
#End Region
#Region "Hourly Salary Calculation..."
    Public Sub Hourly_Salary_Calculation(ByVal MNTH As String, ByVal YR As Integer, ByVal DESGN As String, ByVal PAYINFO As String)
        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("select * from HiredEmployee where payinfo='" & PAYINFO & "' and designation='" & DESGN & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'", conn)
            da.Fill(dt)
            For Each dr As DataRow In dt.Rows
                EmpName = dr("name").ToString()
                PayTotalMinutes(MNTH, YR, dr("empid").ToString())
                PayHours(MNTH, YR, dr("empid").ToString(), CDec(dr("pay").ToString()), dr("designation").ToString(), EmpName)
                TotalEmployee = TotalEmployee + 1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub PayTotalMinutes(ByVal MNTH As String, ByVal YR As Integer, ByVal empid As String)
        Try
            Dim dates(1000) As String
            Dim min(1000) As Integer
            Dim i As Integer = 0
            cmd.CommandText = "select date,totalminutes from workinghourly where empid='" & empid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dates(i) = dr("date").ToString()
                min(i) = CInt(dr("totalminutes").ToString())
                i = i + 1
            End While
            dr.Close()

            Dim mm As Integer
            If MNTH = "January" Then
                mm = 1
            ElseIf MNTH = "February" Then
                mm = 2
            ElseIf MNTH = "March" Then
                mm = 3
            ElseIf MNTH = "April" Then
                mm = 4
            ElseIf MNTH = "May" Then
                mm = 5
            ElseIf MNTH = "June" Then
                mm = 6
            ElseIf MNTH = "July" Then
                mm = 7
            ElseIf MNTH = "August" Then
                mm = 8
            ElseIf MNTH = "September" Then
                mm = 9
            ElseIf MNTH = "October" Then
                mm = 10
            ElseIf MNTH = "November" Then
                mm = 11
            ElseIf MNTH = "December" Then
                mm = 12
            End If
            Dim dte(1000) As Date
            Dim mon(1000) As Integer
            For indx As Integer = 0 To i - 1
                dte(indx) = Date.Parse(dates(indx))
                mon(indx) = dte(indx).Month
                If mm = mon(indx) Then
                    TotalMinutes = TotalMinutes + min(indx)
                End If
            Next
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub PayHours(ByVal MNTH As String, ByVal YR As Integer, ByVal empid As String, ByVal payrate As Decimal, ByVal designation As String, ByVal name As String)
        Try
            Dim paypermin As Decimal = payrate / 60
            NetPay = paypermin * TotalMinutes
            cmd.CommandText = "insert into Salary(InsID,InsName,Period,month,year,regno,designation,name,thismonth,lastmonth,basicadjust,daadjust,hraadjust,otheradjust,ccsadjust,incometaxadjust,salaryadjust,conveyancealw,handicappedalw,washingalw,pfdeduction,conveyancealwrs,handicappedalwrs,washingalwrs,pfdeductionrs,specialpay,gslideduction,houserent,pfadvancerecovery,ccsloan,otherbankloan,festivaladvance,ccspo1loan,ccspo2loan,bankloan,ppfloan,GetDA,GetArrier,GetHRA,DADeductThis,DADeductLast,DADeductionTotal,HRADeductThis,HRADeductLast,HRADeductTotal,DeductedMedical,ProfessionTax,TotalDeduction,TotalGain,NewBasic,EmployerPFDeduct,NetPay,stopincrement,paywithheld) values('" & My.Settings.LastOpenedInstituteID & "','" & My.Settings.LastOpenedInstitute & "','" & My.Settings.Period & "','" & MNTH & "'," & YR & ",'" & empid & "','" & designation & "','" & name & "'," & thismonth & "," & lastmonth & "," & basicadjust & "," & daadjust & "," & hraadjust & "," & otheradjust & "," & ccsadjust & "," & incometaxadjust & "," & salaryadjust & "," & conveyancealw & "," & handicappedalw & "," & washingalw & "," & pfdeduction & "," & conveyancealwrs & "," & handicappedalwrs & "," & washingalwrs & "," & pfdeductionrs & "," & specialpay & "," & gslideduction & "," & houserent & "," & pfadvancerecovery & "," & ccsloan & "," & otherbankloan & "," & festivaladvance & "," & ccspo1loan & "," & ccspo2loan & "," & bankloan & "," & ppfloan & "," & DAGet & "," & Arierr & "," & HRAGet & "," & DaDeductThis & "," & DaDeductLast & "," & DeductedDA & "," & HRADeductThis & "," & HRADeductLast & "," & DeductedHRA & "," & DeductedMedical & "," & TaxD & "," & Deduct & "," & Gain & "," & bpay & "," & CPF & "," & NetPay & ",'" & stopincrement & "','" & paywithheld & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            AddSalaryOk = True
        Catch ex As Exception
            dr.Close()
            AddSalaryOk = False
        End Try
    End Sub
#End Region
#Region "Daily Salary Calculation..."
    Public Sub Daily_Salary_Calculation(ByVal MNTH As String, ByVal YR As Integer, ByVal DESGN As String, ByVal PAYINFO As String)
        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("select * from HiredEmployee where payinfo='" & PAYINFO & "' and designation='" & DESGN & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'", conn)
            da.Fill(dt)
            For Each dr As DataRow In dt.Rows
                EmpName = dr("name").ToString()
                PayTotalDays(MNTH, YR, dr("empid").ToString())
                PayDays(MNTH, YR, dr("empid").ToString(), CDec(dr("pay").ToString()), dr("designation").ToString(), EmpName)
                TotalEmployee = TotalEmployee + 1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub PayTotalDays(ByVal MNTH As String, ByVal YR As Integer, ByVal empid As String)
        Try
            Dim dates(1000) As String
            Dim prab(1000) As String
            Dim i As Integer = 0
            cmd.CommandText = "select date,presentabsent from workingdaily where empid='" & empid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dates(i) = dr("date").ToString()
                prab(i) = dr("presentabsent").ToString()
                i = i + 1
            End While
            dr.Close()

            Dim mm As Integer
            If MNTH = "January" Then
                mm = 1
            ElseIf MNTH = "February" Then
                mm = 2
            ElseIf MNTH = "March" Then
                mm = 3
            ElseIf MNTH = "April" Then
                mm = 4
            ElseIf MNTH = "May" Then
                mm = 5
            ElseIf MNTH = "June" Then
                mm = 6
            ElseIf MNTH = "July" Then
                mm = 7
            ElseIf MNTH = "August" Then
                mm = 8
            ElseIf MNTH = "September" Then
                mm = 9
            ElseIf MNTH = "October" Then
                mm = 10
            ElseIf MNTH = "November" Then
                mm = 11
            ElseIf MNTH = "December" Then
                mm = 12
            End If
            Dim dte(1000) As Date
            Dim mon(1000) As Integer
            For indx As Integer = 0 To i - 1
                dte(indx) = Date.Parse(dates(indx))
                mon(indx) = dte(indx).Month
                If mm = mon(indx) Then
                    If prab(indx) = "Present" Then
                        TotalDays = TotalDays + 1
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PayDays(ByVal MNTH As String, ByVal YR As Integer, ByVal empid As String, ByVal payrate As Decimal, ByVal designation As String, ByVal name As String)
        Try
            NetPay = payrate * TotalDays
            cmd.CommandText = "insert into Salary(InsID,InsName,Period,month,year,regno,designation,name,thismonth,lastmonth,basicadjust,daadjust,hraadjust,otheradjust,ccsadjust,incometaxadjust,salaryadjust,conveyancealw,handicappedalw,washingalw,pfdeduction,conveyancealwrs,handicappedalwrs,washingalwrs,pfdeductionrs,specialpay,gslideduction,houserent,pfadvancerecovery,ccsloan,otherbankloan,festivaladvance,ccspo1loan,ccspo2loan,bankloan,ppfloan,GetDA,GetArrier,GetHRA,DADeductThis,DADeductLast,DADeductionTotal,HRADeductThis,HRADeductLast,HRADeductTotal,DeductedMedical,ProfessionTax,TotalDeduction,TotalGain,NewBasic,EmployerPFDeduct,NetPay,stopincrement,paywithheld) values('" & My.Settings.LastOpenedInstituteID & "','" & My.Settings.LastOpenedInstitute & "','" & My.Settings.Period & "','" & MNTH & "'," & YR & ",'" & empid & "','" & designation & "','" & name & "'," & thismonth & "," & lastmonth & "," & basicadjust & "," & daadjust & "," & hraadjust & "," & otheradjust & "," & ccsadjust & "," & incometaxadjust & "," & salaryadjust & "," & conveyancealw & "," & handicappedalw & "," & washingalw & "," & pfdeduction & "," & conveyancealwrs & "," & handicappedalwrs & "," & washingalwrs & "," & pfdeductionrs & "," & specialpay & "," & gslideduction & "," & houserent & "," & pfadvancerecovery & "," & ccsloan & "," & otherbankloan & "," & festivaladvance & "," & ccspo1loan & "," & ccspo2loan & "," & bankloan & "," & ppfloan & "," & DAGet & "," & Arierr & "," & HRAGet & "," & DaDeductThis & "," & DaDeductLast & "," & DeductedDA & "," & HRADeductThis & "," & HRADeductLast & "," & DeductedHRA & "," & DeductedMedical & "," & TaxD & "," & Deduct & "," & Gain & "," & bpay & "," & CPF & "," & NetPay & ",'" & stopincrement & "','" & paywithheld & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            AddSalaryOk = True
        Catch ex As Exception
            dr.Close()
            AddSalaryOk = False
        End Try
    End Sub
#End Region
#End Region
End Class
#End Region