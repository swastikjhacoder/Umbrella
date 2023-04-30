#Region "Class cInstitute..."
Public Class cInstitute
#Region "Declarations..."
    Public AddInstituteOk As Boolean = False
    Public UpdateInstituteOk As Boolean = False
    Public DeleteInstituteOk As Boolean = False
    Public AddCourseOk As Boolean = False
    Public AddCourseFeesOk As Boolean = False
    Public DeleteCourseOk As Boolean = False
    Public AddFeatureOk As Boolean = False
    Public DeleteFeatureOk As Boolean = False
    Public AddAchievementsOk As Boolean = False
    Public DeleteAchievementsOk As Boolean = False
    Public AddAccountsOk As Boolean = False
    Public UpdateAccountsOk As Boolean = False
    Public DeleteAccountsOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddInstitute(ByVal InsID As String, ByVal periodd As String, ByVal InsName As String, ByVal Address1 As String, ByVal Address2 As String, ByVal City As String, ByVal State As String, ByVal Pin As String, ByVal Country As String, ByVal Telephone As String, ByVal Fax As String, ByVal Email As String, ByVal Url1 As String, ByVal Url2 As String, ByVal Category As String, ByVal AccountingManagement As String, ByVal FinancialPeriod As String, ByVal FinancialMonth As String, ByVal FinancialYear As Integer, ByVal StartDate As String, ByVal StartingMonth As String)
        Try
            cmd.CommandText = "insert into Institute(InsID,period,InsName,Address1,Address2,City,State,Pin,Country,Telephone,Fax,Email,Url1,Url2,Category,AccountingManagement,FinancialPeriod,FinancialMonth,FinancialYear,StartDate,StartingMonth) values ('" & InsID & "','" & periodd & "','" & InsName & "','" & Address1 & "','" & Address2 & "','" & City & "','" & State & "','" & Pin & "','" & Country & "','" & Telephone & "','" & Fax & "','" & Email & "','" & Url1 & "','" & Url2 & "','" & Category & "','" & AccountingManagement & "','" & FinancialPeriod & "','" & FinancialMonth & "'," & FinancialYear & ",'" & StartDate & "','" & StartingMonth & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            If instituteindex = True Then
                cmd.CommandText = "update InstituteIndex set InsID=InsID+1"
                dr = cmd.ExecuteReader
                dr.Close()
            Else
                Dim iid As String = "1"
                Dim id As String = "0"
                cmd.CommandText = "insert into InstituteIndex(InsID) values ('" & iid & "')"
                dr = cmd.ExecuteReader
                dr.Close()
                cmd.CommandText = "insert into Indexx(InsID,empid,hiredempid,deptid,desigid,pbid,noticeid,idserial,admissionsl,preadmissionsl,sturegid,monthlyid,lateid,othersid,libraryid,examfeesid,yearlyid,discountid,financialid,depositid,examid,onlinexmid,assignmentid,markid,progressid,controlid,groupid,subjectid,bookid,issueid,daid,inventoryid,purchaseid,invoiceid,gameid,certificateid,salaryid,userid) values ('" & InsID & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "','" & id & "')"
                dr = cmd.ExecuteReader
                dr.Close()
            End If
            cmd.CommandText = "insert into AccountingPeriod(InsID,InsName,Period,FinancialPeriod) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & FinancialPeriod & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            Dim rate As Decimal = 0.0
            Dim mm As Integer = 1
            Dim yy As Integer = Date.Now.Year
            For i As Integer = 0 To 1
                cmd.CommandText = "insert into DaHra(InsID,InsName,Period,ID,effectmonth,effectyear,darate,hrarate,maximum,medical) values ('" & InsID & "','" & InsName & "','" & FinancialPeriod & "'," & i & "," & mm & "," & yy & "," & rate & "," & rate & "," & rate & "," & rate & ")"
                dr = cmd.ExecuteReader
                dr.Close()
                cmd.CommandText = "update Indexx set daid=daid+1 where InsID='" & InsID & "'"
                dr = cmd.ExecuteReader
                dr.Close()
            Next
            Dim val As String = ""
            cmd.CommandText = "insert into PayslipHeaders(InsID,InsName,Period,allowancedesc1,allowanceshortdesc1,allowancedesc2,allowanceshortdesc2,allowancedesc3,allowanceshortdesc3,allowancedesc4,allowanceshortdesc4,deductiondesc1,deductionshortdesc1,deductiondesc2,deductionshortdesc2,deductiondesc3,deductionshortdesc3,signatorydesc1,signatoryshortdesc1,signatorydesc2,signatoryshortdesc2,signatorydesc3,signatoryshortdesc3) values ('" & InsID & "','" & InsName & "','" & FinancialPeriod & "','" & val & "','" & val & "','" & val & "','" & val & "','" & val & "','" & val & "','" & val & "','" & val & "','" & val & "','" & val & "','" & val & "','" & val & "','" & val & "','" & val & "','" & val & "','" & val & "','" & val & "','" & val & "','" & val & "','" & val & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "insert into PFRate(InsID,InsName,Period,year,rate,amount) values ('" & InsID & "','" & InsName & "','" & FinancialPeriod & "'," & yy & "," & rate & "," & rate & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            Dim alwayspurchase As String = "Yes"
            Dim invoicemessage As String = "Warn if inventory item is out of stock based on quantity on hand."
            Dim ordermessage As String = "Warn if inventory item is out of stock based on quantity on hand."
            Dim gameexpense As String = "100040"
            Dim customfield1 As String = "Alternate Vendor"
            Dim customfield2 As String = "Substitution"
            Dim customfield3 As String = "Special Note"
            Dim customfield4 As String = "Special Order"
            Dim customfield5 As String = ""
            Dim checkcustomfield1 As String = "Yes"
            Dim checkcustomfield2 As String = "Yes"
            Dim checkcustomfield3 As String = "Yes"
            Dim checkcustomfield4 As String = "Yes"
            Dim checkcustomfield5 As String = "No"
            Dim costmethod As String = "LIFO"
            Dim stockglsalesacc As String = "100055"
            Dim stockglinvacc As String = "100056"
            Dim stockglcostacc As String = "100057"
            Dim stockcostingacc As String = "100058"
            Dim masterglsalesacc As String = "100059"
            Dim masterglinvacc As String = "100060"
            Dim masterglcostacc As String = "100061"
            Dim mastercostingacc As String = "100062"
            Dim nonstockglsalesacc As String = "100063"
            Dim nonstockglinvacc As String = "100064"
            Dim nonstockglcostacc As String = "100065"
            Dim nonstockcostingacc As String = "100066"
            Dim descriptionglsalesacc As String = "100067"
            Dim descriptionglinvacc As String = "100068"
            Dim descriptionglcostacc As String = "100069"
            Dim descriptioncostingacc As String = "100070"
            Dim serviceglsalesacc As String = "100071"
            Dim serviceglinvacc As String = "100072"
            Dim serviceglcostacc As String = "100073"
            Dim servicecostingacc As String = "100074"
            Dim laborglsalesacc As String = "100075"
            Dim laborglinvacc As String = "100076"
            Dim laborglcostacc As String = "100077"
            Dim laborcostingacc As String = "100078"
            Dim assemblyglsalesacc As String = "100079"
            Dim assemblyglinvacc As String = "100080"
            Dim assemblyglcostacc As String = "100081"
            Dim assemblycostingacc As String = "100082"
            Dim activitylsalesacc As String = "100083"
            Dim activityglinvacc As String = "100084"
            Dim activityglcostacc As String = "100085"
            Dim activitycostingacc As String = "100086"
            Dim chargeglsalesacc As String = "100087"
            Dim chargeglinvacc As String = "100088"
            Dim chargeglcostacc As String = "100089"
            Dim chargecostingacc As String = "100090"
            Dim glfreightacc As String = "100091"
            Dim autoid As String = "Yes"
            Dim feesmonth As Integer = 12
            Dim applydiscount As String = "Yes"
            Dim monthlyfeesacc As String = "100029"
            Dim yearlyfeesacc As String = "100029"
            Dim libraryfeesacc As String = "100092"
            Dim latefeesacc As String = "100093"
            Dim otherfeesacc As String = "100030"
            Dim examfeesacc As String = "100094"
            Dim discountfeesacc As String = "100095"
            Dim bankdepositacc As String = "100054"
            Dim purchaseorderacc As String = "100096"
            Dim salesinvoiceacc As String = "100097"
            Dim salaryacc As String = "100032"
            Dim basicincr As Decimal = 3.0
            cmd.CommandText = "insert into DefaultInstitute(InsID,InsName,Period,alwayspurchase,invoicemessage,ordermessage,gameexpense,customfield1,customfield2,customfield3,customfield4,customfield5,checkcustomfield1,checkcustomfield2,checkcustomfield3,checkcustomfield4,checkcustomfield5,costmethod,stockglsalesacc,stockglinvacc,stockglcostacc,stockcostingacc,masterglsalesacc,masterglinvacc,masterglcostacc,mastercostingacc,nonstockglsalesacc,nonstockglinvacc,nonstockglcostacc,nonstockcostingacc,descriptionglsalesacc,descriptionglinvacc,descriptionglcostacc,descriptioncostingacc,serviceglsalesacc,serviceglinvacc,serviceglcostacc,servicecostingacc,laborglsalesacc,laborglinvacc,laborglcostacc,laborcostingacc,assemblyglsalesacc,assemblyglinvacc,assemblyglcostacc,assemblycostingacc,activitylsalesacc,activityglinvacc,activityglcostacc,activitycostingacc,chargeglsalesacc,chargeglinvacc,chargeglcostacc,chargecostingacc,glfreightacc,autoid,feesmonth,applydiscount,monthlyfeesacc,yearlyfeesacc,libraryfeesacc,latefeesacc,otherfeesacc,examfeesacc,discountfeesacc,bankdepositacc,purchaseorderacc,salesinvoiceacc) values ('" & InsID & "','" & InsName & "','" & FinancialPeriod & "','" & alwayspurchase & "','" & invoicemessage & "','" & ordermessage & "','" & gameexpense & "','" & customfield1 & "','" & customfield2 & "','" & customfield3 & "','" & customfield4 & "','" & customfield5 & "','" & checkcustomfield1 & "','" & checkcustomfield2 & "','" & checkcustomfield3 & "','" & checkcustomfield4 & "','" & checkcustomfield5 & "','" & costmethod & "','" & stockglsalesacc & "','" & stockglinvacc & "','" & stockglcostacc & "','" & stockcostingacc & "','" & masterglsalesacc & "','" & masterglinvacc & "','" & masterglcostacc & "','" & mastercostingacc & "','" & nonstockglsalesacc & "','" & nonstockglinvacc & "','" & nonstockglcostacc & "','" & nonstockcostingacc & "','" & descriptionglsalesacc & "','" & descriptionglinvacc & "','" & descriptionglcostacc & "','" & descriptioncostingacc & "','" & serviceglsalesacc & "','" & serviceglinvacc & "','" & serviceglcostacc & "','" & servicecostingacc & "','" & laborglsalesacc & "','" & laborglinvacc & "','" & laborglcostacc & "','" & laborcostingacc & "','" & assemblyglsalesacc & "','" & assemblyglinvacc & "','" & assemblyglcostacc & "','" & assemblycostingacc & "','" & activitylsalesacc & "','" & activityglinvacc & "','" & activityglcostacc & "','" & activitycostingacc & "','" & chargeglsalesacc & "','" & chargeglinvacc & "','" & chargeglcostacc & "','" & chargecostingacc & "','" & glfreightacc & "','" & autoid & "'," & feesmonth & ",'" & applydiscount & "','" & monthlyfeesacc & "','" & yearlyfeesacc & "','" & libraryfeesacc & "','" & latefeesacc & "','" & otherfeesacc & "','" & examfeesacc & "','" & discountfeesacc & "','" & bankdepositacc & "','" & purchaseorderacc & "','" & salesinvoiceacc & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "insert into DefaultLibrary(InsID,InsName,Period,autoid,chargesaccount) values ('" & InsID & "','" & InsName & "','" & FinancialPeriod & "','" & autoid & "','" & libraryfeesacc & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "insert into DefaultPayroll(InsID,InsName,Period,autoid,salaryaccount,basicincr) values ('" & InsID & "','" & InsName & "','" & FinancialPeriod & "','" & autoid & "','" & salaryacc & "'," & basicincr & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            Dim crystalreport As String = "All"
            Dim crystalreportid As String = ""
            cmd.CommandText = "insert into UserCrystalReport(InsID,InsName,Period,crystalreport,crystalreportid) values('" & InsID & "','" & InsName & "','" & FinancialPeriod & "','" & crystalreport & "','" & crystalreportid & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            AddInstituteOk = True
        Catch ex As Exception

        End Try
    End Sub

    Public Sub UpdateInstitute(ByVal InsID As String, ByVal InsName As String, ByVal Address1 As String, ByVal Address2 As String, ByVal City As String, ByVal State As String, ByVal Pin As String, ByVal Country As String, ByVal Telephone As String, ByVal Fax As String, ByVal Email As String, ByVal Url1 As String, ByVal Url2 As String, ByVal Category As String)
        Try
            cmd.CommandText = "update Institute set InsName='" & InsName & "',Address1='" & Address1 & "',Address2='" & Address2 & "',City='" & City & "',State='" & State & "',Pin='" & Pin & "',Country='" & Country & "',Telephone='" & Telephone & "',Fax='" & Fax & "',Email='" & Email & "',Url1='" & Url1 & "',Url2='" & Url2 & "',Category='" & Category & "' where InsID='" & InsID & "' and FinancialPeriod='" & FinancialPeriod & "' and period='" & period & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateInstituteOk = True
        Catch ex As Exception

        End Try
    End Sub

    Public Sub DeleteInstitute(ByVal InsID As String, ByVal FinancialMonth As String, ByVal FinancialYear As Integer)
        Try
            cmd.CommandText = "delete from Institute where InsID='" & InsID & "' and FinancialPeriod='" & FinancialPeriod & "' and period='" & period & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteInstituteOk = True
        Catch ex As Exception

        End Try
    End Sub

    Public Sub AddCourse(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal year As String, ByVal CourseName As String, ByVal CourseCode As String, ByVal Duration As String)
        Try
            Dim CFees As Decimal = 0.0
            cmd.CommandText = "insert into Course(InsID,InsName,Period,year,CourseName,CourseCode,Duration,CourseFees) values ('" & InsID & "','" & InsName & "','" & Periodd & "'," & year & ",'" & CourseName & "','" & CourseCode & "','" & Duration & "'," & CFees & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            AddCourseOk = True
        Catch ex As Exception

        End Try
    End Sub

    Public Sub AddCourseFees(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal year As String, ByVal Course As String, ByVal Terms As String)
        Try
            Dim CFees As Decimal = 0.0
            Dim ForMonth As Integer = 12
            cmd.CommandText = "insert into CourseTermFees(InsID,InsName,Period,year,Course,Terms,Fees,ForMonth) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & year & "','" & Course & "','" & Terms & "'," & CFees & "," & ForMonth & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            AddCourseFeesOk = True
        Catch ex As Exception

        End Try
    End Sub

    Public Sub DeleteCourse(ByVal InsID As String, ByVal InsName As String)
        Try
            Dim CFees As Decimal = 0.0
            cmd.CommandText = "delete from Course where InsID='" & InsID & "' and InsName='" & InsName & "' and period='" & period & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteCourseOk = True
        Catch ex As Exception

        End Try
    End Sub

    Public Sub AddFeatures(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal Features As String)
        Try
            cmd.CommandText = "insert into Features(InsID,InsName,Period,Features) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & Features & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            AddFeatureOk = True
        Catch ex As Exception

        End Try
    End Sub

    Public Sub DeleteFeatures(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String)
        Try
            cmd.CommandText = "delete from Features where InsID='" & InsID & "' and InsName='" & InsName & "' and period='" & period & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteFeatureOk = True
        Catch ex As Exception

        End Try
    End Sub

    Public Sub AddAchievements(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal Achievements As String)
        Try
            cmd.CommandText = "insert into Achievements(InsID,InsName,Period,Achievements) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & Achievements & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            AddAchievementsOk = True
        Catch ex As Exception

        End Try
    End Sub

    Public Sub DeleteAchievements(ByVal InsID As String, ByVal InsName As String)
        Try
            cmd.CommandText = "delete from Achievements where InsID='" & InsID & "' and InsName='" & InsName & "' and period='" & period & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteAchievementsOk = True
        Catch ex As Exception

        End Try
    End Sub

    Public Sub AddAccounts(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal AccountID As String, ByVal AccountName As String, ByVal AccountType As String)
        Try
            Dim AccountBalance As Decimal = 0.0
            cmd.CommandText = "insert into Accounts(InsID,InsName,Period,Type,AccountID,AccountName,AccountBalance) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & AccountType & "','" & AccountID & "','" & AccountName & "'," & AccountBalance & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            AddAccountsOk = True
        Catch ex As Exception

        End Try
    End Sub
#End Region
End Class
#End Region