#Region "Class cImport..."
Public Class cImport
#Region "Declarations..."
    Public ImportEmployeeOk As Boolean = False
    Public ImportEmployeeLanguageOk As Boolean = False
    Public ImportEmployeeAcademicOk As Boolean = False
    Public ImportEmployeeReaserchExpOk As Boolean = False
    Public ImportEmployeeTeachingExpOk As Boolean = False
    Public ImportEmployeeProficiencyOk As Boolean = False
    Public ImportEmployeeProgrammingLangOk As Boolean = False
    Public ImportEmployeeActivityOk As Boolean = False
    Public ImportEmployeePFOk As Boolean = False
    Public ImportHiredEmployeeOk As Boolean = False
    Public ImportRetiredEmployeeOk As Boolean = False
    Public ImportRetiredEmployeeLanguageOk As Boolean = False
    Public ImportRetiredEmployeeAcademicOk As Boolean = False
    Public ImportRetiredEmployeeReaserchExpOk As Boolean = False
    Public ImportRetiredEmployeeTeachingExpOk As Boolean = False
    Public ImportRetiredEmployeeProficiencyOk As Boolean = False
    Public ImportRetiredEmployeeProgrammingLangOk As Boolean = False
    Public ImportRetiredEmployeeActivityOk As Boolean = False
    Public ImportRetiredEmployeePFOk As Boolean = False
    Public ImportEmployeeAttendanceOk As Boolean = False
    Public ImportStudentAttendanceOk As Boolean = False
    Public ImportNoticeOk As Boolean = False
    Public ImportIDCardOk As Boolean = False
    Public ImportUsersOk As Boolean = False
    Public ImportUserCrystalReportOk As Boolean = False
    Public ImportStudentAdmisionOk As Boolean = False
    Public ImportStudentAdmisionExamOk As Boolean = False
    Public ImportStudentPreAdmissionOk As Boolean = False
    Public ImportStudentRegistrationOk As Boolean = False
    Public ImportCourseOk As Boolean = False
    Public ImportTermsFeesOk As Boolean = False
    Public ImportYearlyFeesOk As Boolean = False
    Public ImportMonthlyFeesOk As Boolean = False
    Public ImportLateFeesOk As Boolean = False
    Public ImportLibraryFeesOk As Boolean = False
    Public ImportExamFeesOk As Boolean = False
    Public ImportOtherFeesOk As Boolean = False
    Public ImportDiscountOk As Boolean = False
    Public ImportDiscountStudentOk As Boolean = False
    Public ImportFinancialLoanOk As Boolean = False
    Public ImportIncomeExpenditureOk As Boolean = False
    Public ImportAccountsOk As Boolean = False
    Public ImportBankDepositOk As Boolean = False
    Public ImportSubjectOk As Boolean = False
    Public ImportSyllabusOk As Boolean = False
    Public ImportAssignmentOk As Boolean = False
    Public ImportExaminationOk As Boolean = False
    Public ImportExaminationStudentOk As Boolean = False
    Public ImportExaminationGuardOk As Boolean = False
    Public ImportOnlineExaminationQsnOk As Boolean = False
    Public ImportOnlineExaminationOk As Boolean = False
    Public ImportProgressReportOk As Boolean = False
    Public ImportMarksheetOk As Boolean = False
    Public ImportAlumniOk As Boolean = False
    Public ImportStudentCertificateOk As Boolean = False
    Public ImportEmployeeCertificateOk As Boolean = False
    Public ImportInventoryOk As Boolean = False
    Public ImportInventoryHistoryOk As Boolean = False
    Public ImportInventoryPriceLevelOk As Boolean = False
    Public ImportSalesInvoiceOk As Boolean = False
    Public ImportPurchaseOrderOk As Boolean = False
    Public ImportGameOk As Boolean = False
    Public ImportBookOk As Boolean = False
    Public ImportGroupOk As Boolean = False
    Public ImportSubjectBookOk As Boolean = False
    Public ImportBookChargesOk As Boolean = False
    Public ImportCalculateChargesOk As Boolean = False
    Public ImportIssueOk As Boolean = False
    Public ImportIssueBookOk As Boolean = False
    Public ImportReturnBookOk As Boolean = False
    Public ImportDepartmentOk As Boolean = False
    Public ImportDesignationOk As Boolean = False
    Public ImportProfTaxOk As Boolean = False
    Public ImportDAHRAOk As Boolean = False
    Public ImportPayScaleOk As Boolean = False
    Public ImportPaySlipHeadersOk As Boolean = False
    Public ImportAdjustmentDeductionOk As Boolean = False
    Public ImportWorkingHoursDayOk As Boolean = False
    Public ImportSalaryCalculationOk As Boolean = False
    Public ImportPayEmployeeOk As Boolean = False
    Public ImportAdvanceWithdrawalOk As Boolean = False
    Public ImportIndividualPFRateOk As Boolean = False
    Public ImportMembershipOk As Boolean = False
    Public ImportInstituteIndexOk As Boolean = False
    Public ImportIndexxOk As Boolean = False
    Public ImportInstituteOk As Boolean = False
    Public ImportFinancialYearOk As Boolean = False
    Public ImportFeaturesOk As Boolean = False
    Public ImportAchievementsOk As Boolean = False
    Public ImportAccountingPeriodOk As Boolean = False
    Public ImportDefaultInstituteOk As Boolean = False
    Public ImportDefaultLibraryOk As Boolean = False
    Public ImportDefaultPayrollOk As Boolean = False
    Public ImportStudentControlOk As Boolean = False
    Public ImportPFRateOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub DeleteEmployee()
        Try
            cmd.CommandText = "delete from Employee"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportEmployee(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal namefirst As String, ByVal namemiddle As String, ByVal namelast As String, ByVal name As String, ByVal houseno As String, ByVal address As String, ByVal city As String, ByVal district As String, ByVal state As String, ByVal pin As String, ByVal country As String, ByVal phone As String, ByVal fax As String, ByVal dob As String, ByVal email As String, ByVal category As String, ByVal department As String, ByVal designation As String, ByVal married As String, ByVal sex As String, ByVal handicapped As String, ByVal presentposition As String, ByVal retirementdate As String, ByVal fulladdress As String, ByVal payinfo As String, ByVal payscale As String, ByVal grade As Decimal, ByVal basic As Decimal, ByVal joiningdate As String, ByVal phd As String, ByVal qualifiedtest As String, ByVal attachedcopy As String, ByVal incremented As String)
        Try
            cmd.CommandText = "insert into Employee(InsID,InsName,Period,SystemDate,empid,namefirst,namemiddle,namelast,name,houseno,address,city,district,state,pin,country,phone,fax,dob,email,category,department,designation,married,sex,handicapped,presentposition,retirementdate,fulladdress,payinfo,payscale,grade,basic,joiningdate,phd,qualifiedtest,attachedcopy,incremented) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & namefirst & "','" & namemiddle & "','" & namelast & "','" & name & "','" & houseno & "','" & address & "','" & city & "','" & district & "','" & state & "','" & pin & "','" & country & "','" & phone & "','" & fax & "','" & dob & "','" & email & "','" & category & "','" & department & "','" & designation & "','" & married & "','" & sex & "','" & handicapped & "','" & presentposition & "','" & retirementdate & "','" & fulladdress & "','" & payinfo & "','" & payscale & "'," & grade & "," & basic & ",'" & joiningdate & "','" & phd & "','" & qualifiedtest & "','" & attachedcopy & "','" & incremented & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportEmployeeOk = True
        Catch ex As Exception
            ImportEmployeeOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteEmployeeLanguage()
        Try
            cmd.CommandText = "delete from EmployeeLanguage"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportEmployeeLanguage(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal langname As String, ByVal canread As String, ByVal canwrite As String, ByVal canspeak As String, ByVal canconversation As String)
        Try
            cmd.CommandText = "insert into EmployeeLanguage(InsID,InsName,Period,SystemDate,empid,langname,canread,canwrite,canspeak,canconversation) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & langname & "','" & canread & "','" & canwrite & "','" & canspeak & "','" & canconversation & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportEmployeeLanguageOk = True
        Catch ex As Exception
            ImportEmployeeLanguageOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteEmployeeAcademic()
        Try
            cmd.CommandText = "delete from EmployeeAcademic"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportEmployeeAcademic(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal degree As String, ByVal passingyear As Integer, ByVal subjects As String, ByVal percentagemarks As Decimal, ByVal classdivision As String)
        Try
            cmd.CommandText = "insert into EmployeeAcademic(InsID,InsName,Period,SystemDate,empid,degree,passingyear,subjects,percentagemarks,classdivision) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & degree & "'," & passingyear & ",'" & subjects & "'," & percentagemarks & ",'" & classdivision & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportEmployeeAcademicOk = True
        Catch ex As Exception
            ImportEmployeeAcademicOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteEmployeeReaserchExp()
        Try
            cmd.CommandText = "delete from EmployeeResearchExp"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportEmployeeReaserchExp(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal totalrexpyear As Integer, ByVal totalrexpmonth As Integer, ByVal research As String, ByVal institution As String, ByVal topic As String, ByVal researchperiod As String)
        Try
            cmd.CommandText = "insert into EmployeeResearchExp(InsID,InsName,Period,SystemDate,empid,totalrexpyear,totalrexpmonth,research,institution,topic,researchperiod) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "'," & totalrexpyear & "," & totalrexpmonth & ",'" & research & "','" & institution & "','" & topic & "','" & researchperiod & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportEmployeeReaserchExpOk = True
        Catch ex As Exception
            ImportEmployeeReaserchExpOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteEmployeeTeachingExp()
        Try
            cmd.CommandText = "delete from EmployeeTeachingExp"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportEmployeeTeachingExp(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal totaltexpyear As Integer, ByVal totaltexpmonth As Integer, ByVal institution As String, ByVal designation As String, ByVal totalyears As Integer, ByVal ug As String, ByVal degree As String, ByVal pg As String)
        Try
            cmd.CommandText = "insert into EmployeeTeachingExp(InsID,InsName,Period,SystemDate,empid,totaltexpyear,totaltexpmonth,institution,designation,totalyears,ug,degree,pg) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "'," & totaltexpyear & "," & totaltexpmonth & ",'" & institution & "','" & designation & "'," & totalyears & ",'" & ug & "','" & degree & "','" & pg & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportEmployeeTeachingExpOk = True
        Catch ex As Exception
            ImportEmployeeTeachingExpOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteEmployeeProficiency()
        Try
            cmd.CommandText = "delete from EmployeeProficiency"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportEmployeeProficiency(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal msword As String, ByVal msexcel As String, ByVal mspowerpoint As String, ByVal internet As String, ByVal knowemail As String, ByVal cmserp As String)
        Try
            cmd.CommandText = "insert into EmployeeProficiency(InsID,InsName,Period,SystemDate,empid,msword,msexcel,mspowerpoint,internet,knowemail,cmserp) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & msword & "','" & msexcel & "','" & mspowerpoint & "','" & internet & "','" & knowemail & "','" & cmserp & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportEmployeeProficiencyOk = True
        Catch ex As Exception
            ImportEmployeeProficiencyOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteEmployeeProgrammingLang()
        Try
            cmd.CommandText = "delete from EmployeeProgrammingLang"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportEmployeeProgrammingLang(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal lang As String)
        Try
            cmd.CommandText = "insert into EmployeeProgrammingLang(InsID,InsName,Period,SystemDate,empid,lang) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & lang & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportEmployeeProgrammingLangOk = True
        Catch ex As Exception
            ImportEmployeeProgrammingLangOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteEmployeeActivity()
        Try
            cmd.CommandText = "delete from EmployeeActivity"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportEmployeeActivity(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal publishedbooks As String, ByVal publishedpaper As String, ByVal publishedarticles As String, ByVal seminar As String, ByVal adminisexp As String, ByVal otheractivities As String, ByVal poriodnotice As String, ByVal referee1 As String, ByVal referee2 As String, ByVal referee3 As String, ByVal otherinfo As String)
        Try
            cmd.CommandText = "insert into EmployeeActivity(InsID,InsName,Period,SystemDate,empid,publishedbooks,publishedpaper,publishedarticles,seminar,adminisexp,otheractivities,poriodnotice,referee1,referee2,referee3,otherinfo) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & publishedbooks & "','" & publishedpaper & "','" & publishedarticles & "','" & seminar & "','" & adminisexp & "','" & otheractivities & "','" & poriodnotice & "','" & referee1 & "','" & referee2 & "','" & referee3 & "','" & otherinfo & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportEmployeeActivityOk = True
        Catch ex As Exception
            ImportEmployeeActivityOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteEmployeePF()
        Try
            cmd.CommandText = "delete from PF"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportEmployeePF(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal empid As String, ByVal designation As String, ByVal name As String, ByVal joiningdate As String, ByVal openingbalance As Decimal, ByVal outstandingadvance As Decimal)
        Try
            cmd.CommandText = "insert into PF(InsID,InsName,Period,regno,designation,name,joiningdate,openingbalance,outstandingadvance) values ('" & InsID & "','" & InsName & "','" & period & "','" & empid & "','" & designation & "','" & name & "','" & joiningdate & "'," & openingbalance & "," & outstandingadvance & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportEmployeePFOk = True
        Catch ex As Exception
            ImportEmployeePFOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteHiredEmployee()
        Try
            cmd.CommandText = "delete from HiredEmployee"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportHiredEmployee(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal namefirst As String, ByVal namemiddle As String, ByVal namelast As String, ByVal name As String, ByVal houseno As String, ByVal address As String, ByVal city As String, ByVal district As String, ByVal state As String, ByVal pin As String, ByVal country As String, ByVal phone As String, ByVal fax As String, ByVal dob As String, ByVal email As String, ByVal category As String, ByVal department As String, ByVal designation As String, ByVal married As String, ByVal sex As String, ByVal handicapped As String, ByVal presentposition As String, ByVal retirementdate As String, ByVal fulladdress As String, ByVal payinfo As String, ByVal pay As Decimal, ByVal joiningdate As String)
        Try
            cmd.CommandText = "insert into HiredEmployee(InsID,InsName,Period,SystemDate,empid,namefirst,namemiddle,namelast,name,houseno,address,city,district,state,pin,country,phone,fax,dob,email,category,department,designation,married,sex,handicapped,presentposition,retirementdate,fulladdress,payinfo,pay,joiningdate) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & namefirst & "','" & namemiddle & "','" & namelast & "','" & name & "','" & houseno & "','" & address & "','" & city & "','" & district & "','" & state & "','" & pin & "','" & country & "','" & phone & "','" & fax & "','" & dob & "','" & email & "','" & category & "','" & department & "','" & designation & "','" & married & "','" & sex & "','" & handicapped & "','" & presentposition & "','" & retirementdate & "','" & fulladdress & "','" & payinfo & "'," & pay & ",'" & joiningdate & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportHiredEmployeeOk = True
        Catch ex As Exception
            ImportHiredEmployeeOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRetiredEmployee()
        Try
            cmd.CommandText = "delete from RetiredEmployee"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportRetiredEmployee(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal namefirst As String, ByVal namemiddle As String, ByVal namelast As String, ByVal name As String, ByVal houseno As String, ByVal address As String, ByVal city As String, ByVal district As String, ByVal state As String, ByVal pin As String, ByVal country As String, ByVal phone As String, ByVal fax As String, ByVal dob As String, ByVal email As String, ByVal category As String, ByVal department As String, ByVal designation As String, ByVal married As String, ByVal sex As String, ByVal handicapped As String, ByVal presentposition As String, ByVal retirementdate As String, ByVal fulladdress As String, ByVal payinfo As String, ByVal payscale As String, ByVal grade As Decimal, ByVal basic As Decimal, ByVal joiningdate As String, ByVal phd As String, ByVal qualifiedtest As String, ByVal attachedcopy As String, ByVal incremented As String)
        Try
            cmd.CommandText = "insert into RetiredEmployee(InsID,InsName,Period,SystemDate,empid,namefirst,namemiddle,namelast,name,houseno,address,city,district,state,pin,country,phone,fax,dob,email,category,department,designation,married,sex,handicapped,presentposition,retirementdate,fulladdress,payinfo,payscale,grade,basic,joiningdate,phd,qualifiedtest,attachedcopy,incremented) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & namefirst & "','" & namemiddle & "','" & namelast & "','" & name & "','" & houseno & "','" & address & "','" & city & "','" & district & "','" & state & "','" & pin & "','" & country & "','" & phone & "','" & fax & "','" & dob & "','" & email & "','" & category & "','" & department & "','" & designation & "','" & married & "','" & sex & "','" & handicapped & "','" & presentposition & "','" & retirementdate & "','" & fulladdress & "','" & payinfo & "','" & payscale & "'," & grade & "," & basic & ",'" & joiningdate & "','" & phd & "','" & qualifiedtest & "','" & attachedcopy & "','" & incremented & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportRetiredEmployeeOk = True
        Catch ex As Exception
            ImportRetiredEmployeeOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRetiredEmployeeLanguage()
        Try
            cmd.CommandText = "delete from RetiredEmployeeLanguage"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportRetiredEmployeeLanguage(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal langname As String, ByVal canread As String, ByVal canwrite As String, ByVal canspeak As String, ByVal canconversation As String)
        Try
            cmd.CommandText = "insert into RetiredEmployeeLanguage(InsID,InsName,Period,SystemDate,empid,langname,canread,canwrite,canspeak,canconversation) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & langname & "','" & canread & "','" & canwrite & "','" & canspeak & "','" & canconversation & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportRetiredEmployeeLanguageOk = True
        Catch ex As Exception
            ImportRetiredEmployeeLanguageOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRetiredEmployeeAcademic()
        Try
            cmd.CommandText = "delete from RetiredEmployeeAcademic"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportRetiredEmployeeAcademic(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal degree As String, ByVal passingyear As Integer, ByVal subjects As String, ByVal percentagemarks As Decimal, ByVal classdivision As String)
        Try
            cmd.CommandText = "insert into RetiredEmployeeAcademic(InsID,InsName,Period,SystemDate,empid,degree,passingyear,subjects,percentagemarks,classdivision) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & degree & "'," & passingyear & ",'" & subjects & "'," & percentagemarks & ",'" & classdivision & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportRetiredEmployeeAcademicOk = True
        Catch ex As Exception
            ImportRetiredEmployeeAcademicOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRetiredEmployeeReaserchExp()
        Try
            cmd.CommandText = "delete from RetiredEmployeeResearchExp"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportRetiredEmployeeReaserchExp(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal totalrexpyear As Integer, ByVal totalrexpmonth As Integer, ByVal research As String, ByVal institution As String, ByVal topic As String, ByVal researchperiod As String)
        Try
            cmd.CommandText = "insert into RetiredEmployeeResearchExp(InsID,InsName,Period,SystemDate,empid,totalrexpyear,totalrexpmonth,research,institution,topic,researchperiod) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "'," & totalrexpyear & "," & totalrexpmonth & ",'" & research & "','" & institution & "','" & topic & "','" & researchperiod & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportRetiredEmployeeReaserchExpOk = True
        Catch ex As Exception
            ImportRetiredEmployeeReaserchExpOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRetiredEmployeeTeachingExp()
        Try
            cmd.CommandText = "delete from RetiredEmployeeTeachingExp"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportRetiredEmployeeTeachingExp(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal totaltexpyear As Integer, ByVal totaltexpmonth As Integer, ByVal institution As String, ByVal designation As String, ByVal totalyears As Integer, ByVal ug As String, ByVal degree As String, ByVal pg As String)
        Try
            cmd.CommandText = "insert into RetiredEmployeeTeachingExp(InsID,InsName,Period,SystemDate,empid,totaltexpyear,totaltexpmonth,institution,designation,totalyears,ug,degree,pg) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "'," & totaltexpyear & "," & totaltexpmonth & ",'" & institution & "','" & designation & "'," & totalyears & ",'" & ug & "','" & degree & "','" & pg & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportRetiredEmployeeTeachingExpOk = True
        Catch ex As Exception
            ImportRetiredEmployeeTeachingExpOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRetiredEmployeeProficiency()
        Try
            cmd.CommandText = "delete from RetiredEmployeeProficiency"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportRetiredEmployeeProficiency(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal msword As String, ByVal msexcel As String, ByVal mspowerpoint As String, ByVal internet As String, ByVal knowemail As String, ByVal cmserp As String)
        Try
            cmd.CommandText = "insert into RetiredEmployeeProficiency(InsID,InsName,Period,SystemDate,empid,msword,msexcel,mspowerpoint,internet,knowemail,cmserp) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & msword & "','" & msexcel & "','" & mspowerpoint & "','" & internet & "','" & knowemail & "','" & cmserp & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportRetiredEmployeeProficiencyOk = True
        Catch ex As Exception
            ImportRetiredEmployeeProficiencyOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRetiredEmployeeProgrammingLang()
        Try
            cmd.CommandText = "delete from RetiredEmployeeProgrammingLang"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportRetiredEmployeeProgrammingLang(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal lang As String)
        Try
            cmd.CommandText = "insert into RetiredEmployeeProgrammingLang(InsID,InsName,Period,SystemDate,empid,lang) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & lang & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportRetiredEmployeeProgrammingLangOk = True
        Catch ex As Exception
            ImportRetiredEmployeeProgrammingLangOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRetiredEmployeeActivity()
        Try
            cmd.CommandText = "delete from RetiredEmployeeActivity"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportRetiredEmployeeActivity(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal publishedbooks As String, ByVal publishedpaper As String, ByVal publishedarticles As String, ByVal seminar As String, ByVal adminisexp As String, ByVal otheractivities As String, ByVal poriodnotice As String, ByVal referee1 As String, ByVal referee2 As String, ByVal referee3 As String, ByVal otherinfo As String)
        Try
            cmd.CommandText = "insert into RetiredEmployeeActivity(InsID,InsName,Period,SystemDate,empid,publishedbooks,publishedpaper,publishedarticles,seminar,adminisexp,otheractivities,poriodnotice,referee1,referee2,referee3,otherinfo) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & empid & "','" & publishedbooks & "','" & publishedpaper & "','" & publishedarticles & "','" & seminar & "','" & adminisexp & "','" & otheractivities & "','" & poriodnotice & "','" & referee1 & "','" & referee2 & "','" & referee3 & "','" & otherinfo & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportRetiredEmployeeActivityOk = True
        Catch ex As Exception
            ImportRetiredEmployeeActivityOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRetiredEmployeePF()
        Try
            cmd.CommandText = "delete from RetiredPF"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportRetiredEmployeePF(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal empid As String, ByVal designation As String, ByVal name As String, ByVal joiningdate As String, ByVal openingbalance As Decimal, ByVal outstandingadvance As Decimal)
        Try
            cmd.CommandText = "insert into RetiredPF(InsID,InsName,Period,regno,designation,name,joiningdate,openingbalance,outstandingadvance) values ('" & InsID & "','" & InsName & "','" & period & "','" & empid & "','" & designation & "','" & name & "','" & joiningdate & "'," & openingbalance & "," & outstandingadvance & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportRetiredEmployeePFOk = True
        Catch ex As Exception
            ImportRetiredEmployeePFOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteStudentAttendance()
        Try
            cmd.CommandText = "delete from StudentAttendance"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportStudentAttendance(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal name As String, ByVal day1name As String, ByVal day1atten As String, ByVal day2name As String, ByVal day2atten As String, ByVal day3name As String, ByVal day3atten As String, ByVal day4name As String, ByVal day4atten As String, ByVal day5name As String, ByVal day5atten As String, ByVal day6name As String, ByVal day6atten As String, ByVal day7name As String, ByVal day7atten As String)
        Try
            cmd.CommandText = "insert into StudentAttendance(InsID,InsName,Period,SystemDate,stuid,name,day1name,day1atten,day2name,day2atten,day3name,day3atten,day4name,day4atten,day5name,day5atten,day6name,day6atten,day7name,day7atten) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & SystemDate & "','" & empid & "','" & name & "','" & day1name & "','" & day1atten & "','" & day2name & "','" & day2atten & "','" & day3name & "','" & day3atten & "','" & day4name & "','" & day4atten & "','" & day5name & "','" & day5atten & "','" & day6name & "','" & day6atten & "','" & day7name & "','" & day7atten & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportStudentAttendanceOk = True
        Catch ex As Exception
            dr.Close()
            ImportStudentAttendanceOk = False
        End Try
    End Sub

    Public Sub DeleteEmployeeAttendance()
        Try
            cmd.CommandText = "delete from EmployeeAttendance"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportEmployeeAttendance(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal name As String, ByVal day1name As String, ByVal day1atten As String, ByVal day2name As String, ByVal day2atten As String, ByVal day3name As String, ByVal day3atten As String, ByVal day4name As String, ByVal day4atten As String, ByVal day5name As String, ByVal day5atten As String, ByVal day6name As String, ByVal day6atten As String, ByVal day7name As String, ByVal day7atten As String)
        Try
            cmd.CommandText = "insert into EmployeeAttendance(InsID,InsName,Period,SystemDate,empid,name,day1name,day1atten,day2name,day2atten,day3name,day3atten,day4name,day4atten,day5name,day5atten,day6name,day6atten,day7name,day7atten) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & SystemDate & "','" & empid & "','" & name & "','" & day1name & "','" & day1atten & "','" & day2name & "','" & day2atten & "','" & day3name & "','" & day3atten & "','" & day4name & "','" & day4atten & "','" & day5name & "','" & day5atten & "','" & day6name & "','" & day6atten & "','" & day7name & "','" & day7atten & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportEmployeeAttendanceOk = True
        Catch ex As Exception
            dr.Close()
            ImportEmployeeAttendanceOk = False
        End Try
    End Sub

    Public Sub DeleteNotice()
        Try
            cmd.CommandText = "delete from Notice"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportNotice(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal noticeid As String, ByVal noticefor As String, ByVal noticedate As String, ByVal subject As String, ByVal notice As String)
        Try
            cmd.CommandText = "insert into Notice(InsID,InsName,Period,SystemDate,noticeid,noticefor,noticedate,subject,notice) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & SystemDate & "','" & noticeid & "','" & noticefor & "','" & noticedate & "','" & subject & "','" & notice & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportNoticeOk = True
        Catch ex As Exception
            dr.Close()
            ImportNoticeOk = False
        End Try
    End Sub

    Public Sub DeleteIDCard()
        Try
            cmd.CommandText = "delete from IDCard"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportIDCard(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal idserial As String, ByVal idfor As String, ByVal dates As String, ByVal regno As String, ByVal name As String, ByVal dob As String, ByVal sex As String, ByVal coursedesig As String, ByVal address As String)
        Try
            cmd.CommandText = "insert into IDCard(InsID,InsName,Period,SystemDate,idserial,idfor,date,regno,name,dob,sex,coursedesig,address) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & SystemDate & "','" & idserial & "','" & idfor & "','" & dates & "','" & regno & "','" & name & "','" & dob & "','" & sex & "','" & coursedesig & "','" & address & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportIDCardOk = True
        Catch ex As Exception
            dr.Close()
            ImportIDCardOk = False
        End Try
    End Sub

    Public Sub DeleteUsers()
        Try
            cmd.CommandText = "delete from Users"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportUsers(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal userno As String, ByVal userrole As String, ByVal userid As String, ByVal userpasswd As String, ByVal useraccess As String, ByVal employeeinfo As String, ByVal employeecard As String, ByVal attendances As String, ByVal idcard As String, ByVal notices As String, ByVal studentcontrol As String, ByVal backuprestore As String, ByVal importexport As String, ByVal studentinfo As String, ByVal studentcard As String, ByVal preadmission As String, ByVal admission As String, ByVal registration As String, ByVal feesterms As String, ByVal bankinginfo As String, ByVal feescollection As String, ByVal discount As String, ByVal incomeexpenditure As String, ByVal accounting As String, ByVal financialloan As String, ByVal coursesubject As String, ByVal examination As String, ByVal progressreport As String, ByVal marksheet As String, ByVal messenger As String, ByVal globalaccess As String, ByVal alumni As String, ByVal certificates As String, ByVal purchaseorder As String, ByVal inventory As String, ByVal salesinvoice As String, ByVal games As String, ByVal bookrecords As String, ByVal charges As String, ByVal issuebooks As String, ByVal returnbooks As String, ByVal payrollsystem As String, ByVal payrollperiodic As String, ByVal payrollpf As String, ByVal institutedefault As String, ByVal librarydefault As String, ByVal payrolldefault As String, ByVal revenueyeartodate As String, ByVal yearend As String)
        Try
            cmd.CommandText = "insert into Users(InsID,InsName,Period,SystemDate,userno,userrole,userid,userpasswd,useraccess,employeeinfo,employeecard,attendances,idcard,notices,studentcontrol,backuprestore,importexport,studentinfo,studentcard,preadmission,admission,registration,feesterms,bankinginfo,feescollection,discount,incomeexpenditure,accounting,financialloan,coursesubject,examination,progressreport,marksheet,messenger,globalaccess,alumni,certificates,purchaseorder,inventory,salesinvoice,games,bookrecords,charges,issuebooks,returnbooks,payrollsystem,payrollperiodic,payrollpf,institutedefault,librarydefault,payrolldefault,revenueyeartodate,yearend) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & userno & "','" & userrole & "','" & userid & "','" & userpasswd & "','" & useraccess & "','" & employeeinfo & "','" & employeecard & "','" & attendances & "','" & idcard & "','" & notices & "','" & studentcontrol & "','" & backuprestore & "','" & importexport & "','" & studentinfo & "','" & studentcard & "','" & preadmission & "','" & admission & "','" & registration & "','" & feesterms & "','" & bankinginfo & "','" & feescollection & "','" & discount & "','" & incomeexpenditure & "','" & accounting & "','" & financialloan & "','" & coursesubject & "','" & examination & "','" & progressreport & "','" & marksheet & "','" & messenger & "','" & globalaccess & "','" & alumni & "','" & certificates & "','" & purchaseorder & "','" & inventory & "','" & salesinvoice & "','" & games & "','" & bookrecords & "','" & charges & "','" & issuebooks & "','" & returnbooks & "','" & payrollsystem & "','" & payrollperiodic & "','" & payrollpf & "','" & institutedefault & "','" & librarydefault & "','" & payrolldefault & "','" & revenueyeartodate & "','" & yearend & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportUsersOk = True
        Catch ex As Exception
            ImportUsersOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteUserCrystalReport()
        Try
            cmd.CommandText = "delete from UserCrystalReport"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportUserCrystalReport(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal crystalreport As String, ByVal crystalreportid As String)
        Try
            cmd.CommandText = "insert into UserCrystalReport(InsID,InsName,Period,crystalreport,crystalreportid) values('" & InsID & "','" & InsName & "','" & Periodd & "','" & crystalreport & "','" & crystalreportid & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportUserCrystalReportOk = True
        Catch ex As Exception
            ImportUserCrystalReportOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteStudentAdmision()
        Try
            cmd.CommandText = "delete from StudentAdmision"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportStudentAdmision(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal serial As String, ByVal year As Integer, ByVal preadmitted As String, ByVal preadmissionid As String, ByVal course As String, ByVal approved As String, ByVal clas As String, ByVal classint As Integer, ByVal classstring As String, ByVal fname As String, ByVal mname As String, ByVal lname As String, ByVal name As String, ByVal dob As String, ByVal sex As String, ByVal fgname As String, ByVal mothername As String, ByVal coursefee As Decimal, ByVal annualincome As Decimal, ByVal prehouseno As String, ByVal preaddress As String, ByVal precity As String, ByVal prepost As String, ByVal predist As String, ByVal prestate As String, ByVal prepin As String, ByVal precountry As String, ByVal perhouseno As String, ByVal peraddress As String, ByVal percity As String, ByVal perpost As String, ByVal perdist As String, ByVal perstate As String, ByVal perpin As String, ByVal percountry As String, ByVal profcourse As String, ByVal profcourseduration As String, ByVal profcourseyear As Integer, ByVal competitiveexam As String, ByVal institute As String, ByVal recognized As String, ByVal instituteaddress As String, ByVal institutephone As String, ByVal institutefax As String, ByVal instituteuniv As String, ByVal payeename As String, ByVal bankname As String, ByVal bankbrach As String, ByVal branchaddress As String, ByVal branchcode As String, ByVal accountno As String, ByVal accounttype As String, ByVal micrcode As String, ByVal electronictransfer As String, ByVal cardholdername As String, ByVal cardaddress As String, ByVal cardcity As String, ByVal cardstate As String, ByVal cardpin As String, ByVal cardcountry As String, ByVal cardtype As String, ByVal payvia As String, ByVal cardno As String, ByVal expmm As Integer, ByVal expyy As Integer, ByVal email As String, ByVal homephone As String, ByVal workphone As String, ByVal fax As String)
        Try
            cmd.CommandText = "insert into StudentAdmision(InsID,InsName,Period,SystemDate,serial,year,preadmitted,preadmissionid,course,approved,class,classint,classstring,fname,mname,lname,name,dob,sex,fgname,mothername,coursefee,annualincome,prehouseno,preaddress,precity,prepost,predist,prestate,prepin,precountry,perhouseno,peraddress,percity,perpost,perdist,perstate,perpin,percountry,profcourse,profcourseduration,profcourseyear,competitiveexam,institute,recognized,instituteaddress,institutephone,institutefax,instituteuniv,payeename,bankname,bankbrach,branchaddress,branchcode,accountno,accounttype,micrcode,electronictransfer,cardholdername,cardaddress,cardcity,cardstate,cardpin,cardcountry,cardtype,payvia,cardno,expmm,expyy,email,homephone,workphone,fax) values(@InsID,@InsName,@Period,@SystemDate,@serial,@year,@preadmitted,@preadmissionid,@course,@approved,@class,@classint,@classstring,@fname,@mname,@lname,@name,@dob,@sex,@fgname,@mothername,@coursefee,@annualincome,@prehouseno,@preaddress,@precity,@prepost,@predist,@prestate,@prepin,@precountry,@perhouseno,@peraddress,@percity,@perpost,@perdist,@perstate,@perpin,@percountry,@profcourse,@profcourseduration,@profcourseyear,@competitiveexam,@institute,@recognized,@instituteaddress,@institutephone,@institutefax,@instituteuniv,@payeename,@bankname,@bankbrach,@branchaddress,@branchcode,@accountno,@accounttype,@micrcode,@electronictransfer,@cardholdername,@cardaddress,@cardcity,@cardstate,@cardpin,@cardcountry,@cardtype,@payvia,@cardno,@expmm,@expyy,@email,@homephone,@workphone,@fax)"
            cmd.Parameters.AddWithValue("@InsID", InsID)
            cmd.Parameters.AddWithValue("@InsName", InsName)
            cmd.Parameters.AddWithValue("@Period", Periodd)
            cmd.Parameters.AddWithValue("@SystemDate", SystemDate)
            cmd.Parameters.AddWithValue("@serial", serial)
            cmd.Parameters.AddWithValue("@year", year)
            cmd.Parameters.AddWithValue("@preadmitted", preadmitted)
            cmd.Parameters.AddWithValue("@preadmissionid", preadmissionid)
            cmd.Parameters.AddWithValue("@course", course)
            cmd.Parameters.AddWithValue("@approved", approved)
            cmd.Parameters.AddWithValue("@class", clas)
            cmd.Parameters.AddWithValue("@classint", classint)
            cmd.Parameters.AddWithValue("@classstring", classstring)
            cmd.Parameters.AddWithValue("@fname", fname)
            cmd.Parameters.AddWithValue("@mname", mname)
            cmd.Parameters.AddWithValue("@lname", lname)
            cmd.Parameters.AddWithValue("@name", name)
            cmd.Parameters.AddWithValue("@dob", dob)
            cmd.Parameters.AddWithValue("@sex", sex)
            cmd.Parameters.AddWithValue("@fgname", fgname)
            cmd.Parameters.AddWithValue("@mothername", mothername)
            cmd.Parameters.AddWithValue("@coursefee", coursefee)
            cmd.Parameters.AddWithValue("@annualincome", annualincome)
            cmd.Parameters.AddWithValue("@prehouseno", prehouseno)
            cmd.Parameters.AddWithValue("@preaddress", preaddress)
            cmd.Parameters.AddWithValue("@precity", precity)
            cmd.Parameters.AddWithValue("@prepost", prepost)
            cmd.Parameters.AddWithValue("@predist", predist)
            cmd.Parameters.AddWithValue("@prestate", prestate)
            cmd.Parameters.AddWithValue("@prepin", prepin)
            cmd.Parameters.AddWithValue("@precountry", precountry)
            cmd.Parameters.AddWithValue("@perhouseno", perhouseno)
            cmd.Parameters.AddWithValue("@peraddress", peraddress)
            cmd.Parameters.AddWithValue("@percity", percity)
            cmd.Parameters.AddWithValue("@perpost", perpost)
            cmd.Parameters.AddWithValue("@perdist", perdist)
            cmd.Parameters.AddWithValue("@perstate", perstate)
            cmd.Parameters.AddWithValue("@perpin", perpin)
            cmd.Parameters.AddWithValue("@percountry", percountry)
            cmd.Parameters.AddWithValue("@profcourse", profcourse)
            cmd.Parameters.AddWithValue("@profcourseduration", profcourseduration)
            cmd.Parameters.AddWithValue("@profcourseyear", profcourseyear)
            cmd.Parameters.AddWithValue("@competitiveexam", competitiveexam)
            cmd.Parameters.AddWithValue("@institute", institute)
            cmd.Parameters.AddWithValue("@recognized", recognized)
            cmd.Parameters.AddWithValue("@instituteaddress", instituteaddress)
            cmd.Parameters.AddWithValue("@institutephone", institutephone)
            cmd.Parameters.AddWithValue("@institutefax", institutefax)
            cmd.Parameters.AddWithValue("@instituteuniv", instituteuniv)
            cmd.Parameters.AddWithValue("@payeename", payeename)
            cmd.Parameters.AddWithValue("@bankname", bankname)
            cmd.Parameters.AddWithValue("@bankbrach", bankbrach)
            cmd.Parameters.AddWithValue("@branchaddress", branchaddress)
            cmd.Parameters.AddWithValue("@branchcode", branchcode)
            cmd.Parameters.AddWithValue("@accountno", accountno)
            cmd.Parameters.AddWithValue("@accounttype", accounttype)
            cmd.Parameters.AddWithValue("@micrcode", micrcode)
            cmd.Parameters.AddWithValue("@electronictransfer", electronictransfer)
            cmd.Parameters.AddWithValue("@cardholdername", cardholdername)
            cmd.Parameters.AddWithValue("@cardaddress", cardaddress)
            cmd.Parameters.AddWithValue("@cardcity", cardcity)
            cmd.Parameters.AddWithValue("@cardstate", cardstate)
            cmd.Parameters.AddWithValue("@cardpin", cardpin)
            cmd.Parameters.AddWithValue("@cardcountry", cardcountry)
            cmd.Parameters.AddWithValue("@cardtype", cardtype)
            cmd.Parameters.AddWithValue("@payvia", payvia)
            cmd.Parameters.AddWithValue("@cardno", cardno)
            cmd.Parameters.AddWithValue("@expmm", expmm)
            cmd.Parameters.AddWithValue("@expyy", expyy)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@homephone", homephone)
            cmd.Parameters.AddWithValue("@workphone", workphone)
            cmd.Parameters.AddWithValue("@fax", fax)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
            ImportStudentAdmisionOk = True
        Catch ex As Exception
            ImportStudentAdmisionOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteStudentAdmisionExam()
        Try
            cmd.CommandText = "delete from StudentAdmisionExam"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportStudentAdmisionExam(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal stuid As String, ByVal firstname As String, ByVal middlename As String, ByVal lastname As String, ByVal name As String, ByVal exam As String, ByVal board As String, ByVal subject As String, ByVal passingyear As Integer, ByVal marks As Decimal, ByVal division As String)
        Try
            cmd.CommandText = "insert into StudentAdmisionExam(InsID,InsName,Period,SystemDate,stuid,fname,mname,lname,name,exam,board,subject,passingyear,marks,division) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & SystemDate & "','" & stuid & "','" & firstname & "','" & middlename & "','" & lastname & "','" & name & "','" & exam & "','" & board & "','" & subject & "'," & passingyear & "," & marks & ",'" & division & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportStudentAdmisionExamOk = True
        Catch ex As Exception
            ImportStudentAdmisionExamOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteStudentPreAdmision()
        Try
            cmd.CommandText = "delete from StudentPreAdmission"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportStudentPreAdmission(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal serial As String, ByVal year As Integer, ByVal fname As String, ByVal mname As String, ByVal lname As String, ByVal name As String, ByVal dob As String, ByVal sex As String, ByVal fgname As String, ByVal mothername As String, ByVal houseno As String, ByVal address As String, ByVal city As String, ByVal post As String, ByVal dist As String, ByVal state As String, ByVal pin As String, ByVal country As String, ByVal email As String, ByVal homephone As String, ByVal workphone As String, ByVal fax As String, ByVal clas As String, ByVal classint As Integer, ByVal classstring As String, ByVal course As String, ByVal testfee As Decimal, ByVal othertestfee As Decimal, ByVal coursefee As Decimal, ByVal annualincome As Decimal, ByVal payeename As String, ByVal bankname As String, ByVal bankbrach As String, ByVal branchaddress As String, ByVal branchcode As String, ByVal accountno As String, ByVal accounttype As String, ByVal micrcode As String, ByVal electronictransfer As String, ByVal cardholdername As String, ByVal cardaddress As String, ByVal cardcity As String, ByVal cardstate As String, ByVal cardpin As String, ByVal cardcountry As String, ByVal cardtype As String, ByVal payvia As String, ByVal cardno As String, ByVal expmm As Integer, ByVal expyy As Integer)
        Try
            cmd.CommandText = "insert into StudentPreAdmission(InsID,InsName,Period,SystemDate,serial,year,fname,mname,lname,name,dob,sex,fgname,mothername,houseno,address,city,post,dist,state,pin,country,email,homephone,workphone,fax,class,classint,classstring,course,testfee,othertestfee,coursefee,annualincome,payeename,bankname,bankbrach,branchaddress,branchcode,accountno,accounttype,micrcode,electronictransfer,cardholdername,cardaddress,cardcity,cardstate,cardpin,cardcountry,cardtype,payvia,cardno,expmm,expyy) values(@InsID,@InsName,@Period,@SystemDate,@serial,@year,@fname,@mname,@lname,@name,@dob,@sex,@fgname,@mothername,@houseno,@address,@city,@post,@dist,@state,@pin,@country,@email,@homephone,@workphone,@fax,@class,@classint,@classstring,@course,@testfee,@othertestfee,@coursefee,@annualincome,@payeename,@bankname,@bankbrach,@branchaddress,@branchcode,@accountno,@accounttype,@micrcode,@electronictransfer,@cardholdername,@cardaddress,@cardcity,@cardstate,@cardpin,@cardcountry,@cardtype,@payvia,@cardno,@expmm,@expyy)"
            cmd.Parameters.AddWithValue("@InsID", InsID)
            cmd.Parameters.AddWithValue("@InsName", InsName)
            cmd.Parameters.AddWithValue("@Period", Periodd)
            cmd.Parameters.AddWithValue("@SystemDate", SystemDate)
            cmd.Parameters.AddWithValue("@serial", serial)
            cmd.Parameters.AddWithValue("@year", year)
            cmd.Parameters.AddWithValue("@fname", fname)
            cmd.Parameters.AddWithValue("@mname", mname)
            cmd.Parameters.AddWithValue("@lname", lname)
            cmd.Parameters.AddWithValue("@name", name)
            cmd.Parameters.AddWithValue("@dob", dob)
            cmd.Parameters.AddWithValue("@sex", sex)
            cmd.Parameters.AddWithValue("@fgname", fgname)
            cmd.Parameters.AddWithValue("@mothername", mothername)
            cmd.Parameters.AddWithValue("@houseno", houseno)
            cmd.Parameters.AddWithValue("@address", address)
            cmd.Parameters.AddWithValue("@city", city)
            cmd.Parameters.AddWithValue("@post", post)
            cmd.Parameters.AddWithValue("@dist", dist)
            cmd.Parameters.AddWithValue("@state", state)
            cmd.Parameters.AddWithValue("@pin", pin)
            cmd.Parameters.AddWithValue("@country", country)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@homephone", homephone)
            cmd.Parameters.AddWithValue("@workphone", workphone)
            cmd.Parameters.AddWithValue("@fax", fax)
            cmd.Parameters.AddWithValue("@class", clas)
            cmd.Parameters.AddWithValue("@classint", classint)
            cmd.Parameters.AddWithValue("@classstring", classstring)
            cmd.Parameters.AddWithValue("@course", course)
            cmd.Parameters.AddWithValue("@testfee", testfee)
            cmd.Parameters.AddWithValue("@othertestfee", othertestfee)
            cmd.Parameters.AddWithValue("@coursefee", coursefee)
            cmd.Parameters.AddWithValue("@annualincome", annualincome)
            cmd.Parameters.AddWithValue("@payeename", payeename)
            cmd.Parameters.AddWithValue("@bankname", bankname)
            cmd.Parameters.AddWithValue("@bankbrach", bankbrach)
            cmd.Parameters.AddWithValue("@branchaddress", branchaddress)
            cmd.Parameters.AddWithValue("@branchcode", branchcode)
            cmd.Parameters.AddWithValue("@accountno", accountno)
            cmd.Parameters.AddWithValue("@accounttype", accounttype)
            cmd.Parameters.AddWithValue("@micrcode", micrcode)
            cmd.Parameters.AddWithValue("@electronictransfer", electronictransfer)
            cmd.Parameters.AddWithValue("@cardholdername", cardholdername)
            cmd.Parameters.AddWithValue("@cardaddress", cardaddress)
            cmd.Parameters.AddWithValue("@cardcity", cardcity)
            cmd.Parameters.AddWithValue("@cardstate", cardstate)
            cmd.Parameters.AddWithValue("@cardpin", cardpin)
            cmd.Parameters.AddWithValue("@cardcountry", cardcountry)
            cmd.Parameters.AddWithValue("@cardtype", cardtype)
            cmd.Parameters.AddWithValue("@payvia", payvia)
            cmd.Parameters.AddWithValue("@cardno", cardno)
            cmd.Parameters.AddWithValue("@expmm", expmm)
            cmd.Parameters.AddWithValue("@expyy", expyy)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
            ImportStudentPreAdmissionOk = True
        Catch ex As Exception
            ImportStudentPreAdmissionOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteStudentRegistration()
        Try
            cmd.CommandText = "delete from StudentRegistration"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportStudentRegistration(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal serial As String, ByVal year As Integer, ByVal preadmitted As String, ByVal preadmissionid As String, ByVal course As String, ByVal approved As String, ByVal clas As String, ByVal classint As Integer, ByVal classstring As String, ByVal fname As String, ByVal mname As String, ByVal lname As String, ByVal name As String, ByVal fgname As String, ByVal mothername As String, ByVal dob As String, ByVal sex As String, ByVal coursefee As Decimal, ByVal annualincome As Decimal, ByVal prehouseno As String, ByVal preaddress As String, ByVal precity As String, ByVal prepost As String, ByVal predist As String, ByVal prestate As String, ByVal prepin As String, ByVal precountry As String, ByVal perhouseno As String, ByVal peraddress As String, ByVal percity As String, ByVal perpost As String, ByVal perdist As String, ByVal perstate As String, ByVal perpin As String, ByVal percountry As String, ByVal profcourse As String, ByVal profcourseduration As String, ByVal profcourseyear As Integer, ByVal institute As String, ByVal recognized As String, ByVal instituteaddress As String, ByVal institutephone As String, ByVal institutefax As String, ByVal instituteuniv As String, ByVal payeename As String, ByVal bankname As String, ByVal bankbrach As String, ByVal branchaddress As String, ByVal branchcode As String, ByVal accountno As String, ByVal accounttype As String, ByVal micrcode As String, ByVal electronictransfer As String, ByVal cardholdername As String, ByVal cardaddress As String, ByVal cardcity As String, ByVal cardstate As String, ByVal cardpin As String, ByVal cardcountry As String, ByVal cardtype As String, ByVal payvia As String, ByVal cardno As String, ByVal expmm As Integer, ByVal expyy As Integer, ByVal email As String, ByVal homephone As String, ByVal workphone As String, ByVal fax As String, ByVal stuid As String, ByVal roll As String, ByVal time As String, ByVal tuition As String, ByVal emergencyname As String, ByVal emergencyhomeph As String, ByVal emergencyworkph As String, ByVal emergencyfax As String, ByVal emergencyrelation As String, ByVal emergencyaddress As String)
        Try
            cmd.CommandText = "insert into StudentRegistration(InsID,InsName,Period,SystemDate,serial,year,preadmitted,preadmissionid,course,approved,class,classint,classstring,fname,mname,lname,name,fgname,mothername,dob,sex,coursefee,annualincome,prehouseno,preaddress,precity,prepost,predist,prestate,prepin,precountry,perhouseno,peraddress,percity,perpost,perdist,perstate,perpin,percountry,profcourse,profcourseduration,profcourseyear,institute,recognized,instituteaddress,institutephone,institutefax,instituteuniv,payeename,bankname,bankbrach,branchaddress,branchcode,accountno,accounttype,micrcode,electronictransfer,cardholdername,cardaddress,cardcity,cardstate,cardpin,cardcountry,cardtype,payvia,cardno,expmm,expyy,email,homephone,workphone,fax,stuid,roll,time,tuition,emergencyname,emergencyhomeph,emergencyworkph,emergencyfax,emergencyrelation,emergencyaddress) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & serial & "'," & year & ",'" & preadmitted & "','" & preadmissionid & "','" & course & "','" & approved & "','" & clas & "'," & classint & ",'" & classstring & "','" & fname & "','" & mname & "','" & lname & "','" & name & "','" & fgname & "','" & mothername & "','" & dob & "','" & sex & "'," & coursefee & "," & annualincome & ",'" & prehouseno & "','" & preaddress & "','" & precity & "','" & prepost & "','" & predist & "','" & prestate & "','" & prepin & "','" & precountry & "','" & perhouseno & "','" & peraddress & "','" & percity & "','" & perpost & "','" & perdist & "','" & perstate & "','" & perpin & "','" & percountry & "','" & profcourse & "','" & profcourseduration & "'," & profcourseyear & ",'" & institute & "','" & recognized & "','" & instituteaddress & "','" & institutephone & "','" & institutefax & "','" & instituteuniv & "','" & payeename & "','" & bankname & "','" & bankbrach & "','" & branchaddress & "','" & branchcode & "','" & accountno & "','" & accounttype & "','" & micrcode & "','" & electronictransfer & "','" & cardholdername & "','" & cardaddress & "','" & cardcity & "','" & cardstate & "','" & cardpin & "','" & cardcountry & "','" & cardtype & "','" & payvia & "','" & cardno & "'," & expmm & "," & expyy & ",'" & email & "','" & homephone & "','" & workphone & "','" & fax & "','" & stuid & "','" & roll & "','" & time & "','" & tuition & "','" & emergencyname & "','" & emergencyhomeph & "','" & emergencyworkph & "','" & emergencyfax & "','" & emergencyrelation & "','" & emergencyaddress & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportStudentRegistrationOk = True
        Catch ex As Exception
            ImportStudentRegistrationOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteCourse()
        Try
            cmd.CommandText = "delete from Course"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportCourse(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal year As String, ByVal CourseName As String, ByVal CourseCode As String, ByVal Duration As String, ByVal CFees As Decimal)
        Try
            cmd.CommandText = "insert into Course(InsID,InsName,Period,year,CourseName,CourseCode,Duration,CourseFees) values ('" & InsID & "','" & InsName & "','" & Periodd & "'," & year & ",'" & CourseName & "','" & CourseCode & "','" & Duration & "'," & CFees & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportCourseOk = True
        Catch ex As Exception
            ImportCourseOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteTermsFees()
        Try
            cmd.CommandText = "delete from CourseTermFees"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportTermsFees(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal year As String, ByVal Course As String, ByVal Terms As String, ByVal CFees As Decimal, ByVal ForMonth As Integer)
        Try
            cmd.CommandText = "insert into CourseTermFees(InsID,InsName,Period,year,Course,Terms,Fees,ForMonth) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & year & "','" & Course & "','" & Terms & "'," & CFees & "," & ForMonth & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportTermsFeesOk = True
        Catch ex As Exception
            ImportTermsFeesOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteYearlyFees()
        Try
            cmd.CommandText = "delete from YearlyFees"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportYearlyFees(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal token As String, ByVal dates As String, ByVal month As String, ByVal year As Integer, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String, ByVal time As String, ByVal payvia As String, ByVal yearlyfee As Decimal, ByVal laters As Decimal, ByVal otherrs As Decimal, ByVal libraryrs As Decimal, ByVal discountcharge As Decimal, ByVal discount As Decimal, ByVal totalamt As Decimal, ByVal pay As Decimal, ByVal remaining As Decimal, ByVal paid As String)
        Try
            cmd.CommandText = "insert into YearlyFees(InsID,InsName,Period,SystemDate,token,date,month,year,course,class,roll,regno,name,time,payvia,yearlyfee,laters,otherrs,libraryrs,discountcharge,discount,totalamt,pay,remaining,paid) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & token & "','" & dates & "','" & month & "'," & year & ",'" & course & "','" & clas & "','" & roll & "','" & regno & "','" & name & "','" & time & "','" & payvia & "'," & yearlyfee & "," & laters & "," & otherrs & "," & libraryrs & "," & discountcharge & "," & discount & "," & totalamt & "," & pay & "," & remaining & ",'" & paid & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportYearlyFeesOk = True
        Catch ex As Exception
            ImportYearlyFeesOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteMonthlyFees()
        Try
            cmd.CommandText = "delete from MonthlyFees"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportMonthlyFees(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal transactionid As String, ByVal dates As String, ByVal month As Integer, ByVal year As Integer, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String, ByVal time As String, ByVal monthlyrs As Decimal, ByVal othersrs As Decimal, ByVal laters As Decimal, ByVal libraryrs As Decimal, ByVal discountcharge As Decimal, ByVal discount As Decimal, ByVal totalamt As Decimal, ByVal paidamt As Decimal, ByVal payvia As String, ByVal remainingamt As Decimal, ByVal paid As String)
        Try
            cmd.CommandText = "insert into MonthlyFees(InsID,InsName,Period,SystemDate,transactionid,date,month,year,course,class,roll,regno,name,time,monthlyrs,othersrs,laters,libraryrs,discountcharge,discount,totalamt,paidamt,payvia,remainingamt,paid) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & transactionid & "','" & dates & "'," & month & "," & year & ",'" & course & "','" & clas & "','" & roll & "','" & regno & "','" & name & "','" & time & "'," & monthlyrs & "," & othersrs & "," & laters & "," & libraryrs & "," & discountcharge & "," & discount & "," & totalamt & "," & paidamt & ",'" & payvia & "'," & remainingamt & ",'" & paid & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportMonthlyFeesOk = True
        Catch ex As Exception
            ImportMonthlyFeesOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteLateFees()
        Try
            cmd.CommandText = "delete from LateFees"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportLateFees(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal transactionid As String, ByVal dates As String, ByVal month As Integer, ByVal year As Integer, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String, ByVal time As String, ByVal payvia As String, ByVal reason As String, ByVal laters As Decimal, ByVal discountcharge As Decimal, ByVal discount As Decimal, ByVal totalamt As Decimal, ByVal pay As Decimal, ByVal remaining As Decimal, ByVal paid As String)
        Try
            cmd.CommandText = "insert into LateFees(InsID,InsName,Period,SystemDate,transactionid,date,month,year,course,class,roll,regno,name,time,payvia,reason,laters,discountcharge,discount,totalamt,pay,remaining,paid) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & transactionid & "','" & dates & "'," & month & "," & year & ",'" & course & "','" & clas & "','" & roll & "','" & regno & "','" & name & "','" & time & "','" & payvia & "','" & reason & "'," & laters & "," & discountcharge & "," & discount & "," & totalamt & "," & pay & "," & remaining & ",'" & paid & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportLateFeesOk = True
        Catch ex As Exception
            dr.Close()
            ImportLateFeesOk = False
        End Try
    End Sub

    Public Sub DeleteLibraryFees()
        Try
            cmd.CommandText = "delete from libraryFees"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportLibraryFees(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal transactionid As String, ByVal dates As String, ByVal month As Integer, ByVal year As Integer, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String, ByVal time As String, ByVal payvia As String, ByVal libraryfee As Decimal, ByVal laters As Decimal, ByVal discountcharge As Decimal, ByVal discount As Decimal, ByVal totalamt As Decimal, ByVal pay As Decimal, ByVal remaining As Decimal, ByVal paid As String)
        Try
            cmd.CommandText = "insert into libraryFees(InsID,InsName,Period,SystemDate,transactionid,date,month,year,course,class,roll,regno,name,time,payvia,libraryfee,laters,discountcharge,discount,totalamt,pay,remaining,paid) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & transactionid & "','" & dates & "'," & month & "," & year & ",'" & course & "','" & clas & "','" & roll & "','" & regno & "','" & name & "','" & time & "','" & payvia & "'," & libraryfee & "," & laters & "," & discountcharge & "," & discount & "," & totalamt & "," & pay & "," & remaining & ",'" & paid & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportLibraryFeesOk = True
        Catch ex As Exception
            dr.Close()
            ImportLibraryFeesOk = False
        End Try
    End Sub

    Public Sub DeleteExamFees()
        Try
            cmd.CommandText = "delete from ExamFee"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportExamFees(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal transactionid As String, ByVal dates As String, ByVal month As Integer, ByVal year As Integer, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String, ByVal time As String, ByVal payvia As String, ByVal exam As String, ByVal examfee As Decimal, ByVal laters As Decimal, ByVal libraryrs As Decimal, ByVal discountcharge As Decimal, ByVal discount As Decimal, ByVal totalamt As Decimal, ByVal pay As Decimal, ByVal remaining As Decimal, ByVal paid As String)
        Try
            cmd.CommandText = "insert into ExamFee(InsID,InsName,Period,SystemDate,transactionid,date,month,year,course,class,roll,regno,name,time,payvia,exam,examfee,laters,libraryrs,discountcharge,discount,totalamt,pay,remaining,paid) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & transactionid & "','" & dates & "'," & month & "," & year & ",'" & course & "','" & clas & "','" & roll & "','" & regno & "','" & name & "','" & time & "','" & payvia & "','" & exam & "'," & examfee & "," & laters & "," & libraryrs & "," & discountcharge & "," & discount & "," & totalamt & "," & pay & "," & remaining & ",'" & paid & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportExamFeesOk = True
        Catch ex As Exception
            dr.Close()
            ImportExamFeesOk = False
        End Try
    End Sub

    Public Sub DeleteOtherFees()
        Try
            cmd.CommandText = "delete from OtherFees"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportOtherFees(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal transactionid As String, ByVal dates As String, ByVal month As Integer, ByVal year As Integer, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String, ByVal time As String, ByVal payvia As String, ByVal reason As String, ByVal otherrs As Decimal, ByVal discountcharge As Decimal, ByVal discount As Decimal, ByVal totalamt As Decimal, ByVal pay As Decimal, ByVal remaining As Decimal, ByVal paid As String)
        Try
            cmd.CommandText = "insert into OtherFees(InsID,InsName,Period,SystemDate,transactionid,date,month,year,course,class,roll,regno,name,time,payvia,reason,otherrs,discountcharge,discount,totalamt,pay,remaining,paid) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & transactionid & "','" & dates & "'," & month & "," & year & ",'" & course & "','" & clas & "','" & roll & "','" & regno & "','" & name & "','" & time & "','" & payvia & "','" & reason & "'," & otherrs & "," & discountcharge & "," & discount & "," & totalamt & "," & pay & "," & remaining & ",'" & paid & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportOtherFeesOk = True
        Catch ex As Exception
            dr.Close()
            ImportOtherFeesOk = False
        End Try
    End Sub

    Public Sub DeleteDiscount()
        Try
            cmd.CommandText = "delete from Discount"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportDiscount(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal transactionid As String, ByVal dates As String, ByVal month As Integer, ByVal year As Integer, ByVal appliedfor As String, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String, ByVal totalamt As Decimal, ByVal discountcharge As Decimal, ByVal discount As Decimal, ByVal pay As Decimal, ByVal payvia As String, ByVal authentication As String, ByVal remarks As String, ByVal account As String)
        Try
            cmd.CommandText = "insert into Discount(InsID,InsName,Period,SystemDate,transactionid,date,month,year,appliedfor,class,roll,regno,name,totalamt,discountcharge,discount,pay,payvia,authentication,remarks,account) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & transactionid & "','" & dates & "'," & month & "," & year & ",'" & appliedfor & "','" & clas & "','" & roll & "','" & regno & "','" & name & "'," & totalamt & "," & discountcharge & "," & discount & "," & pay & ",'" & payvia & "','" & authentication & "','" & remarks & "','" & account & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportDiscountOk = True
        Catch ex As Exception
            dr.Close()
            ImportDiscountOk = False
        End Try
    End Sub

    Public Sub DeleteDiscountStudent()
        Try
            cmd.CommandText = "delete from StudentDiscount"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportDiscountStudent(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal year As String, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal stuid As String, ByVal name As String, ByVal discount As Decimal)
        Try
            cmd.CommandText = "insert into StudentDiscount(InsID,InsName,Period,SystemDate,year,course,class,roll,stuid,name,discount) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & year & "','" & course & "','" & clas & "','" & roll & "','" & stuid & "','" & name & "'," & discount & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportDiscountStudentOk = True
        Catch ex As Exception
            ImportDiscountStudentOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteFinancialLoan()
        Try
            cmd.CommandText = "delete from FinancialLoan"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportFinancialLoan(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal name As String, ByVal regno As String, ByVal applicantno As String, ByVal fgname As String, ByVal dob As String, ByVal sex As String, ByVal nationality As String, ByVal religion As String, ByVal email As String, ByVal homeph As String, ByVal workph As String, ByVal houseno As String, ByVal address As String, ByVal city As String, ByVal post As String, ByVal district As String, ByVal state As String, ByVal pincode As String, ByVal country As String, ByVal attachmentname As String, ByVal attachmentsize As String, ByVal attachmentpath As String, ByVal attachmentnote As String)
        Try
            cmd.CommandText = "insert into FinancialLoan(InsID,InsName,Period,SystemDate,course,class,roll,name,regno,applicantno,fgname,dob,sex,nationality,religion,email,homeph,workph,houseno,address,city,post,district,state,pincode,country,attachmentname,attachmentsize,attachmentpath,attachmentnote) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & course & "','" & clas & "','" & roll & "','" & name & "','" & regno & "','" & applicantno & "','" & fgname & "','" & dob & "','" & sex & "','" & nationality & "','" & religion & "','" & email & "','" & homeph & "','" & workph & "','" & houseno & "','" & address & "','" & city & "','" & post & "','" & district & "','" & state & "','" & pincode & "','" & country & "','" & attachmentname & "','" & attachmentsize & "','" & attachmentpath & "','" & attachmentnote & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportFinancialLoanOk = True
        Catch ex As Exception
            ImportFinancialLoanOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteIncomeExpenditure()
        Try
            cmd.CommandText = "delete from IncomeExpenditure"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportIncomeExpenditure(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal transactionid As String, ByVal descriptions As String, ByVal type As String, ByVal amount As Decimal, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String, ByVal month As Integer, ByVal year As Integer, ByVal account As String)
        Try
            cmd.CommandText = "insert into IncomeExpenditure(InsID,InsName,Period,SystemDate,transactionid,descriptions,type,amount,class,roll,regno,name,month,year,account) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & transactionid & "','" & descriptions & "','" & type & "'," & amount & ",'" & clas & "','" & roll & "','" & regno & "','" & name & "'," & month & "," & year & ",'" & account & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportIncomeExpenditureOk = True
        Catch ex As Exception
            ImportIncomeExpenditureOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteAccounts()
        Try
            cmd.CommandText = "delete from Accounts"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportAccounts(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal AccountID As String, ByVal AccountName As String, ByVal AccountType As String, ByVal AccountBalance As Decimal)
        Try
            cmd.CommandText = "insert into Accounts(InsID,InsName,Period,Type,AccountID,AccountName,AccountBalance) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & AccountType & "','" & AccountID & "','" & AccountName & "'," & AccountBalance & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportAccountsOk = True
        Catch ex As Exception
            ImportAccountsOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteBankDeposit()
        Try
            cmd.CommandText = "delete from BankDeposit"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportBankDeposit(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal depositid As String, ByVal dates As String, ByVal amount As Decimal, ByVal payvia As String, ByVal checkno As String, ByVal account As String, ByVal payeename As String, ByVal bankname As String, ByVal branchname As String, ByVal branchaddress As String, ByVal branchcode As String, ByVal bankaccountno As String, ByVal accounttype As String, ByVal micrcode As String, ByVal electransfer As String)
        Try
            cmd.CommandText = "insert into BankDeposit(InsID,InsName,Period,SystemDate,depositid,date,amount,payvia,checkno,account,payeename,bankname,branchname,branchaddress,branchcode,bankaccountno,accounttype,micrcode,electransfer) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & depositid & "','" & dates & "'," & amount & ",'" & payvia & "','" & checkno & "','" & account & "','" & payeename & "','" & bankname & "','" & branchname & "','" & branchaddress & "','" & branchcode & "','" & bankaccountno & "','" & accounttype & "','" & micrcode & "','" & electransfer & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportBankDepositOk = True
        Catch ex As Exception
            ImportBankDepositOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteSubject()
        Try
            cmd.CommandText = "delete from Subjects"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportSubject(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal course As String, ByVal coursecode As String, ByVal haspractical As String, ByVal gensubject As String, ByVal gensubjectduration As String, ByVal gensubjectcode As String, ByVal gensubjectyear As Integer, ByVal gensubjectsemestar As String, ByVal pracsubject As String, ByVal pracsubjectduration As String, ByVal pracsubjectcode As String, ByVal pracsubjectyear As Integer, ByVal pracsubjectsemestar As String)
        Try
            cmd.CommandText = "insert into Subjects(InsID,InsName,Period,course,coursecode,haspractical,gensubject,gensubjectduration,gensubjectcode,gensubjectyear,gensubjectsemestar,pracsubject,pracsubjectduration,pracsubjectcode,pracsubjectyear,pracsubjectsemestar) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & course & "','" & coursecode & "','" & haspractical & "','" & gensubject & "','" & gensubjectduration & "','" & gensubjectcode & "'," & gensubjectyear & ",'" & gensubjectsemestar & "','" & pracsubject & "','" & pracsubjectduration & "','" & pracsubjectcode & "'," & pracsubjectyear & ",'" & pracsubjectsemestar & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportSubjectOk = True
        Catch ex As Exception
            ImportSubjectOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteSyllabus()
        Try
            cmd.CommandText = "delete from Syllabus"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportSyllabus(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal course As String, ByVal coursecode As String, ByVal subject As String, ByVal subjectcode As String, ByVal forstudent As String, ByVal chapter As String, ByVal chapterdetails As String, ByVal totalmarks As Integer, ByVal marksobtained As Integer, ByVal totalclass As Integer, ByVal classes As Integer)
        Try
            cmd.CommandText = "insert into Syllabus(InsID,InsName,Period,SystemDate,course,coursecode,subject,subjectcode,forstudent,chapter,chapterdetails,totalmarks,marksobtained,totalclass,class) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & SystemDate & "','" & course & "','" & coursecode & "','" & subject & "','" & subjectcode & "','" & forstudent & "','" & chapter & "','" & chapterdetails & "'," & totalmarks & "," & marksobtained & "," & totalclass & "," & classes & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportSyllabusOk = True
        Catch ex As Exception
            ImportSyllabusOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteAssignment()
        Try
            cmd.CommandText = "delete from Assignment"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportAssignment(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal assignmentid As String, ByVal dates As String, ByVal course As String, ByVal subject As String, ByVal assignment As String)
        Try
            cmd.CommandText = "insert into Assignment(InsID,InsName,Period,SystemDate,assignmentid,date,course,subject,assignment) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & SystemDate & "','" & assignmentid & "','" & dates & "','" & course & "','" & subject & "','" & assignment & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportAssignmentOk = True
        Catch ex As Exception
            ImportAssignmentOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteExamination()
        Try
            cmd.CommandText = "delete from Examination"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportExamination(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal examcode As String, ByVal course As String, ByVal subject As String, ByVal examdate As String, ByVal branch As String, ByVal examcenter As String, ByVal examfor As String, ByVal examinstitute As String, ByVal examtime As String, ByVal roomno As String)
        Try
            cmd.CommandText = "insert into Examination(InsID,InsName,Period,SystemDate,examcode,course,subject,examdate,branch,examcenter,examfor,examinstitute,examtime,roomno) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & SystemDate & "','" & examcode & "','" & course & "','" & subject & "','" & examdate & "','" & branch & "','" & examcenter & "','" & examfor & "','" & examinstitute & "','" & examtime & "','" & roomno & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportExaminationOk = True
        Catch ex As Exception
            ImportExaminationOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteExaminationStudent()
        Try
            cmd.CommandText = "delete from ExamStudents"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportExaminationStudent(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal examcode As String, ByVal stuid As String, ByVal name As String, ByVal course As String)
        Try
            cmd.CommandText = "insert into ExamStudents(InsID,InsName,Period,SystemDate,examcode,stuid,name,course) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & SystemDate & "','" & examcode & "','" & stuid & "','" & name & "','" & course & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportExaminationStudentOk = True
        Catch ex As Exception
            ImportExaminationStudentOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteExaminationGuard()
        Try
            cmd.CommandText = "delete from ExamGuard"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportExaminationGuard(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal examcode As String, ByVal guard As String)
        Try
            cmd.CommandText = "insert into ExamGuard(InsID,InsName,Period,SystemDate,examcode,guard) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & SystemDate & "','" & examcode & "','" & guard & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportExaminationGuardOk = True
        Catch ex As Exception
            ImportExaminationGuardOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteOnlineExaminationQsn()
        Try
            cmd.CommandText = "delete from OnlineExamQsn"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportOnlineExaminationQsn(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal examid As String, ByVal examdate As String, ByVal examtime As String, ByVal examduration As Integer, ByVal qsn As String, ByVal ans1 As String, ByVal ans2 As String, ByVal ans3 As String, ByVal ans4 As String, ByVal rightans As String)
        Try
            cmd.CommandText = "insert into OnlineExamQsn(InsID,InsName,Period,SystemDate,examid,examdate,examtime,examduration,qsn,ans1,ans2,ans3,ans4,rightans) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & examid & "','" & examdate & "','" & examtime & "'," & examduration & ",'" & qsn & "','" & ans1 & "','" & ans2 & "','" & ans3 & "','" & ans4 & "','" & rightans & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportOnlineExaminationQsnOk = True
        Catch ex As Exception
            ImportOnlineExaminationQsnOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteOnlineExamination()
        Try
            cmd.CommandText = "delete from OnlineExam"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportOnlineExamination(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal examid As String, ByVal examdate As String, ByVal examtime As String, ByVal examduration As Integer, ByVal stuid As String, ByVal name As String, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal totalqsn As Integer, ByVal totalqsnanswered As Integer, ByVal rightanswered As Integer)
        Try
            cmd.CommandText = "insert into OnlineExam(InsID,InsName,Period,SystemDate,examid,examdate,examtime,examduration,stuid,name,course,class,roll,totalqsn,totalqsnanswered,rightanswered) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & examid & "','" & examdate & "','" & examtime & "'," & examduration & ",'" & stuid & "','" & name & "','" & course & "','" & clas & "','" & roll & "'," & totalqsn & "," & totalqsnanswered & "," & rightanswered & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportOnlineExaminationOk = True
        Catch ex As Exception
            ImportOnlineExaminationOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteProgressReport()
        Try
            cmd.CommandText = "delete from ProgressReport"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportProgressReport(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal progressid As String, ByVal stuid As String, ByVal attendance As String, ByVal preparation As String, ByVal homework As String, ByVal takerisk As String, ByVal goals As String, ByVal plans As String, ByVal respect As String, ByVal cooperation As String, ByVal interest As String, ByVal motivation As String, ByVal outcomes As String, ByVal quality As String, ByVal keyterms As String, ByVal newconcept As String)
        Try
            cmd.CommandText = "insert into ProgressReport(InsID,InsName,Period,SystemDate,progressid,stuid,attendance,preparation,homework,takerisk,goals,plans,respect,cooperation,interest,motivation,outcomes,quality,keyterms,newconcept) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & progressid & "','" & stuid & "','" & attendance & "','" & preparation & "','" & homework & "','" & takerisk & "','" & goals & "','" & plans & "','" & respect & "','" & cooperation & "','" & interest & "','" & motivation & "','" & outcomes & "','" & quality & "','" & keyterms & "','" & newconcept & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportProgressReportOk = True
        Catch ex As Exception
            dr.Close()
            ImportProgressReportOk = False
        End Try
    End Sub

    Public Sub DeleteMarksheet()
        Try
            cmd.CommandText = "delete from Marksheet"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportMarksheet(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal markid As String, ByVal stuid As String, ByVal name As String, ByVal course As String, ByVal clss As String, ByVal roll As String, ByVal examinfo As String, ByVal examdate As String, ByVal examtime As String, ByVal subject As String, ByVal fullmarks As Decimal, ByVal scored As Decimal)
        Try
            cmd.CommandText = "insert into Marksheet(InsID,InsName,Period,SystemDate,markid,stuid,name,course,class,roll,examinfo,examdate,examtime,subject,fullmarks,scored) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & markid & "','" & stuid & "','" & name & "','" & course & "','" & clss & "','" & roll & "','" & examinfo & "','" & examdate & "','" & examtime & "','" & subject & "'," & fullmarks & "," & scored & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportMarksheetOk = True
        Catch ex As Exception
            ImportMarksheetOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteAlumni()
        Try
            cmd.CommandText = "delete from Alumni"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportAlumni(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal serial As String, ByVal alumniyear As Integer, ByVal year As Integer, ByVal preadmitted As String, ByVal preadmissionid As String, ByVal course As String, ByVal approved As String, ByVal clas As String, ByVal classint As Integer, ByVal classstring As String, ByVal fname As String, ByVal mname As String, ByVal lname As String, ByVal name As String, ByVal fgname As String, ByVal mothername As String, ByVal dob As String, ByVal sex As String, ByVal coursefee As Decimal, ByVal annualincome As Decimal, ByVal prehouseno As String, ByVal preaddress As String, ByVal precity As String, ByVal prepost As String, ByVal predist As String, ByVal prestate As String, ByVal prepin As String, ByVal precountry As String, ByVal perhouseno As String, ByVal peraddress As String, ByVal percity As String, ByVal perpost As String, ByVal perdist As String, ByVal perstate As String, ByVal perpin As String, ByVal percountry As String, ByVal profcourse As String, ByVal profcourseduration As String, ByVal profcourseyear As Integer, ByVal institute As String, ByVal recognized As String, ByVal instituteaddress As String, ByVal institutephone As String, ByVal institutefax As String, ByVal instituteuniv As String, ByVal payeename As String, ByVal bankname As String, ByVal bankbrach As String, ByVal branchaddress As String, ByVal branchcode As String, ByVal accountno As String, ByVal accounttype As String, ByVal micrcode As String, ByVal electronictransfer As String, ByVal cardholdername As String, ByVal cardaddress As String, ByVal cardcity As String, ByVal cardstate As String, ByVal cardpin As String, ByVal cardcountry As String, ByVal cardtype As String, ByVal payvia As String, ByVal cardno As String, ByVal expmm As Integer, ByVal expyy As Integer, ByVal email As String, ByVal homephone As String, ByVal workphone As String, ByVal fax As String, ByVal stuid As String, ByVal roll As String, ByVal time As String, ByVal tuition As String, ByVal emergencyname As String, ByVal emergencyhomeph As String, ByVal emergencyworkph As String, ByVal emergencyfax As String, ByVal emergencyrelation As String, ByVal emergencyaddress As String)
        Try
            cmd.CommandText = "insert into Alumni(InsID,InsName,Period,SystemDate,serial,alumniyear,year,preadmitted,preadmissionid,course,approved,class,classint,classstring,fname,mname,lname,name,fgname,mothername,dob,sex,coursefee,annualincome,prehouseno,preaddress,precity,prepost,predist,prestate,prepin,precountry,perhouseno,peraddress,percity,perpost,perdist,perstate,perpin,percountry,profcourse,profcourseduration,profcourseyear,institute,recognized,instituteaddress,institutephone,institutefax,instituteuniv,payeename,bankname,bankbrach,branchaddress,branchcode,accountno,accounttype,micrcode,electronictransfer,cardholdername,cardaddress,cardcity,cardstate,cardpin,cardcountry,cardtype,payvia,cardno,expmm,expyy,email,homephone,workphone,fax,stuid,roll,time,tuition,emergencyname,emergencyhomeph,emergencyworkph,emergencyfax,emergencyrelation,emergencyaddress) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & serial & "'," & alumniyear & "," & year & ",'" & preadmitted & "','" & preadmissionid & "','" & course & "','" & approved & "','" & clas & "'," & classint & ",'" & classstring & "','" & fname & "','" & mname & "','" & lname & "','" & name & "','" & fgname & "','" & mothername & "','" & dob & "','" & sex & "'," & coursefee & "," & annualincome & ",'" & prehouseno & "','" & preaddress & "','" & precity & "','" & prepost & "','" & predist & "','" & prestate & "','" & prepin & "','" & precountry & "','" & perhouseno & "','" & peraddress & "','" & percity & "','" & perpost & "','" & perdist & "','" & perstate & "','" & perpin & "','" & percountry & "','" & profcourse & "','" & profcourseduration & "'," & profcourseyear & ",'" & institute & "','" & recognized & "','" & instituteaddress & "','" & institutephone & "','" & institutefax & "','" & instituteuniv & "','" & payeename & "','" & bankname & "','" & bankbrach & "','" & branchaddress & "','" & branchcode & "','" & accountno & "','" & accounttype & "','" & micrcode & "','" & electronictransfer & "','" & cardholdername & "','" & cardaddress & "','" & cardcity & "','" & cardstate & "','" & cardpin & "','" & cardcountry & "','" & cardtype & "','" & payvia & "','" & cardno & "'," & expmm & "," & expyy & ",'" & email & "','" & homephone & "','" & workphone & "','" & fax & "','" & stuid & "','" & roll & "','" & time & "','" & tuition & "','" & emergencyname & "','" & emergencyhomeph & "','" & emergencyworkph & "','" & emergencyfax & "','" & emergencyrelation & "','" & emergencyaddress & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportAlumniOk = True
        Catch ex As Exception
            ImportAlumniOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteStudentCertificate()
        Try
            cmd.CommandText = "delete from StudentCertificate"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportStudentCertificate(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal certificateid As String, ByVal regno As String, ByVal name As String, ByVal certificatefor As String, ByVal issuedate As String, ByVal verified As String, ByVal verifiedby As String, ByVal remarks As String)
        Try
            cmd.CommandText = "insert into StudentCertificate(InsID,InsName,Period,SystemDate,certificateid,regno,name,certificatefor,issuedate,verified,verifiedby,remarks) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & certificateid & "','" & regno & "','" & name & "','" & certificatefor & "','" & issuedate & "','" & verified & "','" & verifiedby & "','" & remarks & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportStudentCertificateOk = True
        Catch ex As Exception
            dr.Close()
            ImportStudentCertificateOk = False
        End Try
    End Sub

    Public Sub DeleteEmployeeCertificate()
        Try
            cmd.CommandText = "delete from EmployeeCertificate"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportEmployeeCertificate(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal certificateid As String, ByVal regno As String, ByVal name As String, ByVal certificatefor As String, ByVal issuedate As String, ByVal verified As String, ByVal verifiedby As String, ByVal schooltype1 As String, ByVal schooltype2 As String, ByVal schooltype3 As String, ByVal schooltype4 As String, ByVal schooltype5 As String, ByVal schooltype6 As String, ByVal type1 As String, ByVal type2 As String, ByVal type3 As String, ByVal workingfor As String)
        Try
            cmd.CommandText = "insert into EmployeeCertificate(InsID,InsName,Period,SystemDate,certificateid,regno,name,certificatefor,issuedate,verified,verifiedby,schooltype1,schooltype2,schooltype3,schooltype4,schooltype5,schooltype6,type1,type2,type3,workingfor) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & certificateid & "','" & regno & "','" & name & "','" & certificatefor & "','" & issuedate & "','" & verified & "','" & verifiedby & "','" & schooltype1 & "','" & schooltype2 & "','" & schooltype3 & "','" & schooltype4 & "','" & schooltype5 & "','" & schooltype6 & "','" & type1 & "','" & type2 & "','" & type3 & "','" & workingfor & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportEmployeeCertificateOk = True
        Catch ex As Exception
            dr.Close()
            ImportEmployeeCertificateOk = False
        End Try
    End Sub

    Public Sub DeleteInventory()
        Try
            cmd.CommandText = "delete from Inventory"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportInventory(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal itemid As String, ByVal itemnote As String, ByVal itemname As String, ByVal itemclass As String, ByVal descshort As String, ByVal itemsize As String, ByVal itemshape As String, ByVal itemused As String, ByVal descripbrief As String, ByVal levelprice As Decimal, ByVal onhandqnty As Decimal, ByVal onhandqntyunit As String, ByVal lastsoldprice As Decimal, ByVal costmethod As String, ByVal minstockqnty As Decimal, ByVal minstockqntyunit As String, ByVal itemtaxtype As String, ByVal itemtype As String, ByVal stocking As String, ByVal weight As Decimal, ByVal weightunit As String, ByVal vendorname As String, ByVal glsalesaccountid As String, ByVal glinventoryaccountid As String, ByVal glcostsaccountid As String, ByVal costingaccountid As String, ByVal customfield1 As String, ByVal customfield2 As String, ByVal customfield3 As String, ByVal customfield4 As String, ByVal customfield5 As String, ByVal inactive As String, ByVal commission As String, ByVal UnitPrice As Decimal)
        Try
            cmd.CommandText = "insert into Inventory(InsID,InsName,Period,SystemDate,itemid,itemnote,itemname,itemclass,descshort,itemsize,itemshape,itemused,descripbrief,levelprice,onhandqnty,onhandqntyunit,lastsoldprice,costmethod,minstockqnty,minstockqntyunit,itemtaxtype,itemtype,stocking,weight,weightunit,vendorname,glsalesaccountid,glinventoryaccountid,glcostsaccountid,costingaccountid,customfield1,customfield2,customfield3,customfield4,customfield5,inactive,commission,UnitPrice) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & itemid & "','" & itemnote & "','" & itemname & "','" & itemclass & "','" & descshort & "','" & itemsize & "','" & itemshape & "','" & itemused & "','" & descripbrief & "'," & levelprice & "," & onhandqnty & ",'" & onhandqntyunit & "'," & lastsoldprice & ",'" & costmethod & "'," & minstockqnty & ",'" & minstockqntyunit & "','" & itemtaxtype & "','" & itemtype & "','" & stocking & "'," & weight & ",'" & weightunit & "','" & vendorname & "','" & glsalesaccountid & "','" & glinventoryaccountid & "','" & glcostsaccountid & "','" & costingaccountid & "','" & customfield1 & "','" & customfield2 & "','" & customfield3 & "','" & customfield4 & "','" & customfield5 & "','" & inactive & "','" & commission & "'," & UnitPrice & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportInventoryOk = True
        Catch ex As Exception
            ImportInventoryOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteInventoryHistory()
        Try
            cmd.CommandText = "delete from InventoryHistory"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportInventoryHistory(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal itemid As String, ByVal itemname As String, ByVal itemclass As String, ByVal purpose As String, ByVal price As Decimal, ByVal id As String, ByVal dates As String, ByVal qunatity As Decimal, ByVal unit As String)
        Try
            cmd.CommandText = "insert into InventoryHistory(InsID,InsName,Period,SystemDate,itemid,itemname,itemclass,purpose,price,id,date,qunatity,unit) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & itemid & "','" & itemname & "','" & itemclass & "','" & purpose & "'," & price & ",'" & id & "','" & dates & "'," & qunatity & ",'" & unit & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportInventoryHistoryOk = True
        Catch ex As Exception
            ImportInventoryHistoryOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteInventoryPriceLevel()
        Try
            cmd.CommandText = "delete from InventoryItemPriceLevel"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportInventoryPriceLevel(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal SystemDate As String, ByVal itemid As String, ByVal itemname As String, ByVal itemdesc As String, ByVal levelprice1 As Decimal, ByVal levelprice2 As Decimal, ByVal levelprice3 As Decimal, ByVal levelprice4 As Decimal, ByVal levelprice5 As Decimal, ByVal levelprice6 As Decimal, ByVal levelprice7 As Decimal, ByVal levelprice8 As Decimal, ByVal levelprice9 As Decimal, ByVal levelprice10 As Decimal, ByVal defaultlevel As String)
        Try
            cmd.CommandText = "insert into InventoryItemPriceLevel(InsID,InsName,Period,SystemDate,itemid,itemname,itemdesc,levelprice1,levelprice2,levelprice3,levelprice4,levelprice5,levelprice6,levelprice7,levelprice8,levelprice9,levelprice10,defaultlevel) values ('" & InsID & "','" & InsName & "','" & Period & "','" & SystemDate & "','" & itemid & "','" & itemname & "','" & itemdesc & "'," & levelprice1 & "," & levelprice2 & "," & levelprice3 & "," & levelprice4 & "," & levelprice5 & "," & levelprice6 & "," & levelprice7 & "," & levelprice8 & "," & levelprice9 & "," & levelprice10 & ",'" & defaultlevel & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportInventoryPriceLevelOk = True
        Catch ex As Exception
            ImportInventoryPriceLevelOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteSalesInvoice()
        Try
            cmd.CommandText = "delete from SalesInvoice"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportSalesInvoice(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal invoiceno As String, ByVal invoicedate As String, ByVal customername As String, ByVal customeraddress As String, ByVal customerphone As String, ByVal customeremail As String, ByVal glsalesaccount As String, ByVal taxrate As Decimal, ByVal itemid As String, ByVal itemname As String, ByVal itemclass As String, ByVal qnty As Decimal, ByVal unit As String, ByVal itemprice As Decimal, ByVal itemtax As Decimal, ByVal itemamount As Decimal, ByVal totalprice As Decimal, ByVal totaltax As Decimal, ByVal totalamount As Decimal, ByVal invoicenote As String, ByVal duedate As String, ByVal paid As String)
        Try
            cmd.CommandText = "insert into SalesInvoice(InsID,InsName,Period,SystemDate,invoiceno,invoicedate,customername,customeraddress,customerphone,customeremail,glsalesaccount,taxrate,itemid,itemname,itemclass,qnty,unit,itemprice,itemtax,itemamount,totalprice,totaltax,totalamount,invoicenote,duedate,paid) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & invoiceno & "','" & invoicedate & "','" & customername & "','" & customeraddress & "','" & customerphone & "','" & customeremail & "','" & glsalesaccount & "'," & taxrate & ",'" & itemid & "','" & itemname & "','" & itemclass & "'," & qnty & ",'" & unit & "'," & itemprice & "," & itemtax & "," & itemamount & "," & totalprice & "," & totaltax & "," & totalamount & ",'" & invoicenote & "','" & duedate & "','" & paid & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportSalesInvoiceOk = True
        Catch ex As Exception
            dr.Close()
            ImportSalesInvoiceOk = False
        End Try
    End Sub

    Public Sub DeletePurchaseOrder()
        Try
            cmd.CommandText = "delete from Purchase"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportPurchaseOrder(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal purchaseid As String, ByVal purchasedate As String, ByVal vendorname As String, ByVal vendoraddress As String, ByVal vendorphone As String, ByVal vendoremail As String, ByVal shipto As String, ByVal shipaddress As String, ByVal shipphone As String, ByVal shipemail As String, ByVal expenseaccount As String, ByVal taxrate As Decimal, ByVal itemid As String, ByVal itemname As String, ByVal itemclass As String, ByVal itemqnty As Decimal, ByVal itemunit As String, ByVal itemprice As Decimal, ByVal itemtax As Decimal, ByVal itemtotal As Decimal, ByVal totalprice As Decimal, ByVal totaltax As Decimal, ByVal totalamount As Decimal, ByVal purchasenote As String, ByVal duedate As String, ByVal paid As String)
        Try
            cmd.CommandText = "insert into Purchase(InsID,InsName,Period,SystemDate,purchaseid,purchasedate,vendorname,vendoraddress,vendorphone,vendoremail,shipto,shipaddress,shipphone,shipemail,expenseaccount,taxrate,itemid,itemname,itemclass,itemqnty,itemunit,itemprice,itemtax,itemtotal,totalprice,totaltax,totalamount,purchasenote,duedate,paid) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & purchaseid & "','" & purchasedate & "','" & vendorname & "','" & vendoraddress & "','" & vendorphone & "','" & vendoremail & "','" & shipto & "','" & shipaddress & "','" & shipphone & "','" & shipemail & "','" & expenseaccount & "'," & taxrate & ",'" & itemid & "','" & itemname & "','" & itemclass & "'," & itemqnty & ",'" & itemunit & "'," & itemprice & "," & itemtax & "," & itemtotal & "," & totalprice & "," & totaltax & "," & totalamount & ",'" & purchasenote & "','" & duedate & "','" & paid & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportPurchaseOrderOk = True
        Catch ex As Exception
            dr.Close()
            ImportPurchaseOrderOk = False
        End Try
    End Sub

    Public Sub DeleteGame()
        Try
            cmd.CommandText = "delete from Game"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportGame(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal gameid As String, ByVal category As String, ByVal gamefor As String, ByVal department As String, ByVal dte As String, ByVal time As String, ByVal gamename As String, ByVal gameplace As String, ByVal expense As Decimal, ByVal account As String)
        Try
            cmd.CommandText = "insert into Game(InsID,InsName,Period,SystemDate,gameid,category,gamefor,department,date,time,gamename,gameplace,expense,account) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & gameid & "','" & category & "','" & gamefor & "','" & department & "','" & dte & "','" & time & "','" & gamename & "','" & gameplace & "'," & expense & ",'" & account & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportGameOk = True
        Catch ex As Exception
            ImportGameOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteBook()
        Try
            cmd.CommandText = "delete from Books"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportBook(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal bookid As String, ByVal bookname As String, ByVal groupname As String, ByVal subject As String, ByVal publisher As String, ByVal author As String, ByVal edition As String, ByVal copies As Integer, ByVal pages As Integer, ByVal price As Decimal, ByVal particulars As String)
        Try
            cmd.CommandText = "insert into Books(InsID,InsName,Period,SystemDate,bookid,bookname,groupname,subject,publisher,author,edition,copies,pages,price,particulars) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & bookid & "','" & bookname & "','" & groupname & "','" & subject & "','" & publisher & "','" & author & "','" & edition & "'," & copies & "," & pages & "," & price & ",'" & particulars & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportBookOk = True
        Catch ex As Exception
            dr.Close()
            ImportBookOk = False
        End Try
    End Sub

    Public Sub DeleteGroup()
        Try
            cmd.CommandText = "delete from GroupBooks"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportGroup(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal groupid As String, ByVal groupname As String, ByVal groupdetails As String)
        Try
            cmd.CommandText = "insert into GroupBooks(InsID,InsName,Period,SystemDate,groupid,groupname,groupdetails) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & groupid & "','" & groupname & "','" & groupdetails & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportGroupOk = True
        Catch ex As Exception
            dr.Close()
            ImportGroupOk = False
        End Try
    End Sub

    Public Sub DeleteSubjectBook()
        Try
            cmd.CommandText = "delete from SubjectBooks"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportSubjectBook(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal subjectidd As String, ByVal subjectname As String, ByVal subjectdetails As String)
        Try
            cmd.CommandText = "insert into SubjectBooks(InsID,InsName,Period,SystemDate,subjectid,subjectname,subjectdetails) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & subjectidd & "','" & subjectname & "','" & subjectdetails & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportSubjectBookOk = True
        Catch ex As Exception
            dr.Close()
            ImportSubjectBookOk = False
        End Try
    End Sub

    Public Sub DeleteBookCharges()
        Try
            cmd.CommandText = "delete from BookCharges"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportBookCharges(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal course As String, ByVal referencebooks As String, ByVal finerate As Decimal, ByVal reserveperiod As Integer, ByVal maxbooks As Integer, ByVal booksreturndays As Integer, ByVal maxjournal As Integer, ByVal journalreturndays As Integer, ByVal maxcompbook As Integer, ByVal compbookreturndays As Integer, ByVal lockerperiod As Integer, ByVal lockerfees As Decimal, ByVal losingcardcharge As Decimal, ByVal lockerfine As Decimal, ByVal losingjournalcharge As Decimal, ByVal idcardcharge As Decimal)
        Try
            cmd.CommandText = "insert into BookCharges(InsID,InsName,Period,SystemDate,course,referencebooks,finerate,reserveperiod,maxbooks,booksreturndays,maxjournal,journalreturndays,maxcompbook,compbookreturndays,lockerperiod,lockerfees,losingcardcharge,lockerfine,losingjournalcharge,idcardcharge) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & course & "','" & referencebooks & "'," & finerate & "," & reserveperiod & "," & maxbooks & "," & booksreturndays & "," & maxjournal & "," & journalreturndays & "," & maxcompbook & "," & compbookreturndays & "," & lockerperiod & "," & lockerfees & "," & losingcardcharge & "," & lockerfine & "," & losingjournalcharge & "," & idcardcharge & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportBookChargesOk = True
        Catch ex As Exception
            dr.Close()
            ImportBookChargesOk = False
        End Try
    End Sub

    Public Sub DeleteCalculateCharges()
        Try
            cmd.CommandText = "delete from LibraryCharges"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportCalculateCharges(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal dates As String, ByVal issueid As String, ByVal issuedate As String, ByVal regno As String, ByVal name As String, ByVal latedays As Integer, ByVal latefees As Decimal, ByVal losingbooks As Decimal, ByVal losingjournal As Decimal, ByVal losingcompbooks As Decimal, ByVal newidcard As Decimal, ByVal losingidcard As Decimal, ByVal lockerfees As Decimal, ByVal lockerfine As Decimal, ByVal otherfees As Decimal, ByVal reason As String, ByVal totalcharges As Decimal, ByVal payeename As String, ByVal bankname As String, ByVal bankbranch As String, ByVal branchaddress As String, ByVal branchcode As String, ByVal bankaccountno As String, ByVal accounttype As String, ByVal micrcode As String, ByVal electransfer As String, ByVal payvia As String, ByVal account As String)
        Try
            cmd.CommandText = "insert into LibraryCharges(InsID,InsName,Period,SystemDate,date,issueid,issuedate,regno,name,latedays,latefees,losingbooks,losingjournal,losingcompbooks,newidcard,losingidcard,lockerfees,lockerfine,otherfees,reason,totalcharges,payeename,bankname,bankbranch,branchaddress,branchcode,bankaccountno,accounttype,micrcode,electransfer,payvia,account) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & dates & "','" & issueid & "','" & issuedate & "','" & regno & "','" & name & "'," & latedays & "," & latefees & "," & losingbooks & "," & losingjournal & "," & losingcompbooks & "," & newidcard & "," & losingidcard & "," & lockerfees & "," & lockerfine & "," & otherfees & ",'" & reason & "'," & totalcharges & ",'" & payeename & "','" & bankname & "','" & bankbranch & "','" & branchaddress & "','" & branchcode & "','" & bankaccountno & "','" & accounttype & "','" & micrcode & "','" & electransfer & "','" & payvia & "','" & account & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportCalculateChargesOk = True
        Catch ex As Exception
            ImportCalculateChargesOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteIssue()
        Try
            cmd.CommandText = "delete from Issue"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportIssue(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal issedto As String, ByVal issuedtoname As String, ByVal issuedtoid As String, ByVal contactno As String, ByVal email As String, ByVal issueid As String, ByVal issuedate As String, ByVal duedate As String, ByVal issedby As String, ByVal returned As String)
        Try
            cmd.CommandText = "insert into Issue(InsID,InsName,Period,SystemDate,issedto,issuedtoname,issuedtoid,contactno,email,issueid,issuedate,duedate,issedby,returned) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & issedto & "','" & issuedtoname & "','" & issuedtoid & "','" & contactno & "','" & email & "','" & issueid & "','" & issuedate & "','" & duedate & "','" & issedby & "','" & returned & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportIssueOk = True
        Catch ex As Exception
            dr.Close()
            ImportIssueOk = False
        End Try
    End Sub

    Public Sub DeleteIssueBook()
        Try
            cmd.CommandText = "delete from IssueBooks"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportIssueBook(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal issueid As String, ByVal issuedtoid As String, ByVal issuedate As String, ByVal bookname As String, ByVal bookid As String, ByVal author As String, ByVal edition As String)
        Try
            cmd.CommandText = "insert into IssueBooks(InsID,InsName,Period,SystemDate,issueid,issuedtoid,issuedate,bookname,bookid,author,edition) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & issueid & "','" & issuedtoid & "','" & issuedate & "','" & bookname & "','" & bookid & "','" & author & "','" & edition & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportIssueBookOk = True
        Catch ex As Exception
            dr.Close()
            ImportIssueBookOk = False
        End Try
    End Sub

    Public Sub DeleteReturnBook()
        Try
            cmd.CommandText = "delete from ReturnBooks"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportReturnBook(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal issueid As String, ByVal dates As String, ByVal issuedate As String, ByVal returndate As String, ByVal applylatecharge As String, ByVal regno As String, ByVal name As String)
        Try
            cmd.CommandText = "insert into ReturnBooks(InsID,InsName,Period,SystemDate,issueid,date,issuedate,returndate,applylatecharge,regno,name) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & issueid & "','" & dates & "','" & issuedate & "','" & returndate & "','" & applylatecharge & "','" & regno & "','" & name & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportReturnBookOk = True
        Catch ex As Exception
            ImportReturnBookOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteDepartment()
        Try
            cmd.CommandText = "delete from Department"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportDepartment(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal deptid As String, ByVal deptname As String)
        Try
            cmd.CommandText = "insert into Department(InsID,InsName,Period,deptid,deptname) values ('" & InsID & "','" & InsName & "','" & Period & "','" & deptid & "','" & deptname & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportDepartmentOk = True
        Catch ex As Exception
            ImportDepartmentOk = False
        End Try
    End Sub

    Public Sub DeleteDesignation()
        Try
            cmd.CommandText = "delete from Designation"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportDesignation(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal desigid As String, ByVal designame As String)
        Try
            cmd.CommandText = "insert into Designation(InsID,InsName,Period,desigid,designame) values ('" & InsID & "','" & InsName & "','" & Period & "','" & desigid & "','" & designame & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportDesignationOk = True
        Catch ex As Exception
            ImportDesignationOk = False
        End Try
    End Sub

    Public Sub DeleteProfTax()
        Try
            cmd.CommandText = "delete from ProfessionalTax"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportProfTax(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal gross As Decimal, ByVal taxrate As Decimal)
        Try
            cmd.CommandText = "insert into ProfessionalTax(InsID,InsName,Period,gross,taxrate) values ('" & InsID & "','" & InsName & "','" & Periodd & "'," & gross & "," & taxrate & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportProfTaxOk = True
        Catch ex As Exception
            dr.Close()
            ImportProfTaxOk = False
        End Try
    End Sub

    Public Sub DeleteDAHRA()
        Try
            cmd.CommandText = "delete from DaHra"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportDAHRA(ByVal ID As Integer, ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal effectmonth As Integer, ByVal effectyear As Integer, ByVal darate As Decimal, ByVal hrarate As Decimal, ByVal maximum As Decimal, ByVal medical As Decimal)
        Try
            cmd.CommandText = "update DaHra set effectmonth=" & effectmonth & ",effectyear=" & effectyear & ",darate=" & darate & ",hrarate=" & hrarate & ",maximum=" & maximum & ",medical=" & medical & " where ID=" & ID & " and InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportDAHRAOk = True
        Catch ex As Exception
            dr.Close()
            ImportDAHRAOk = False
        End Try
    End Sub

    Public Sub DeletePayScale()
        Try
            cmd.CommandText = "delete from PayScale"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportPayScale(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal pbname As String, ByVal pblower As Decimal, ByVal pbupper As Decimal, ByVal pbgrade As Decimal, ByVal pbbasic As Decimal, ByVal payscale As String)
        Try
            cmd.CommandText = "insert into PayScale(InsID,InsName,period,pbname,pblower,pbupper,pbgrade,pbbasic,payscale) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & pbname & "'," & pblower & "," & pbupper & "," & pbgrade & "," & pbbasic & ",'" & payscale & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportPayScaleOk = True
        Catch ex As Exception
            ImportPayScaleOk = False
        End Try
    End Sub

    Public Sub DeletePaySlipHeaders()
        Try
            cmd.CommandText = "delete from PayslipHeaders"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportPaySlipHeaders(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal allowancedesc1 As String, ByVal allowanceshortdesc1 As String, ByVal allowancedesc2 As String, ByVal allowanceshortdesc2 As String, ByVal allowancedesc3 As String, ByVal allowanceshortdesc3 As String, ByVal allowancedesc4 As String, ByVal allowanceshortdesc4 As String, ByVal deductiondesc1 As String, ByVal deductionshortdesc1 As String, ByVal deductiondesc2 As String, ByVal deductionshortdesc2 As String, ByVal deductiondesc3 As String, ByVal deductionshortdesc3 As String, ByVal signatorydesc1 As String, ByVal signatoryshortdesc1 As String, ByVal signatorydesc2 As String, ByVal signatoryshortdesc2 As String, ByVal signatorydesc3 As String, ByVal signatoryshortdesc3 As String)
        Try
            cmd.CommandText = "update PayslipHeaders set allowancedesc1='" & allowancedesc1 & "',allowanceshortdesc1='" & allowanceshortdesc1 & "',allowancedesc2='" & allowancedesc2 & "',allowanceshortdesc2='" & allowanceshortdesc2 & "',allowancedesc3='" & allowancedesc3 & "',allowanceshortdesc3='" & allowanceshortdesc3 & "',allowancedesc4='" & allowancedesc4 & "',allowanceshortdesc4='" & allowanceshortdesc4 & "',deductiondesc1='" & deductiondesc1 & "',deductionshortdesc1='" & deductionshortdesc1 & "',deductiondesc2='" & deductiondesc2 & "',deductionshortdesc2='" & deductionshortdesc2 & "',deductiondesc3='" & deductiondesc3 & "',deductionshortdesc3='" & deductionshortdesc3 & "',signatorydesc1='" & signatorydesc1 & "',signatoryshortdesc1='" & signatoryshortdesc1 & "',signatorydesc2='" & signatorydesc2 & "',signatoryshortdesc2='" & signatoryshortdesc2 & "',signatorydesc3='" & signatorydesc3 & "',signatoryshortdesc3 ='" & signatoryshortdesc3 & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportPaySlipHeadersOk = True
        Catch ex As Exception
            ImportPaySlipHeadersOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteAdjustmentDeduction()
        Try
            cmd.CommandText = "delete from AdjustmentDeductions"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportAdjustmentDeduction(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal month As String, ByVal year As Integer, ByVal regno As String, ByVal designation As String, ByVal name As String, ByVal thismonth As Integer, ByVal lastmonth As Integer, ByVal basicadjust As Decimal, ByVal daadjust As Decimal, ByVal hraadjust As Decimal, ByVal otheradjust As Decimal, ByVal ccsadjust As Decimal, ByVal incometaxadjust As Decimal, ByVal salaryadjust As Decimal, ByVal conveyancealw As Decimal, ByVal handicappedalw As Decimal, ByVal washingalw As Decimal, ByVal pfdeduction As Decimal, ByVal conveyancealwrs As Decimal, ByVal handicappedalwrs As Decimal, ByVal washingalwrs As Decimal, ByVal pfdeductionrs As Decimal, ByVal specialpay As Decimal, ByVal gslideduction As Decimal, ByVal houserent As Decimal, ByVal pfadvancerecovery As Decimal, ByVal ccsloan As Decimal, ByVal otherbankloan As Decimal, ByVal festivaladvance As Decimal, ByVal ccspo1loan As Decimal, ByVal ccspo2loan As Decimal, ByVal bankloan As Decimal, ByVal ppfloan As Decimal, ByVal stopincrement As String, ByVal paywithheld As String)
        Try
            cmd.CommandText = "insert into AdjustmentDeductions(InsID,InsName,Period,month,year,regno,designation,name,thismonth,lastmonth,basicadjust,daadjust,hraadjust,otheradjust,ccsadjust,incometaxadjust,salaryadjust,conveyancealw,handicappedalw,washingalw,pfdeduction,conveyancealwrs,handicappedalwrs,washingalwrs,pfdeductionrs,specialpay,gslideduction,houserent,pfadvancerecovery,ccsloan,otherbankloan,festivaladvance,ccspo1loan,ccspo2loan,bankloan,ppfloan,stopincrement,paywithheld) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & month & "'," & year & ",'" & regno & "','" & designation & "','" & name & "'," & thismonth & "," & lastmonth & "," & basicadjust & "," & daadjust & "," & hraadjust & "," & otheradjust & "," & ccsadjust & "," & incometaxadjust & "," & salaryadjust & "," & conveyancealw & "," & handicappedalw & "," & washingalw & "," & pfdeduction & "," & conveyancealwrs & "," & handicappedalwrs & "," & washingalwrs & "," & pfdeductionrs & "," & specialpay & "," & gslideduction & "," & houserent & "," & pfadvancerecovery & "," & ccsloan & "," & otherbankloan & "," & festivaladvance & "," & ccspo1loan & "," & ccspo2loan & "," & bankloan & "," & ppfloan & ",'" & stopincrement & "','" & paywithheld & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportAdjustmentDeductionOk = True
        Catch ex As Exception
            ImportAdjustmentDeductionOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteWorkingHours()
        Try
            cmd.CommandText = "delete from WorkingHourly"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportWorkingHours(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal empid As String, ByVal name As String, ByVal dates As String, ByVal starttime As String, ByVal endtime As String, ByVal totalminutes As Integer)
        Try
            cmd.CommandText = "insert into workinghourly(InsID,InsName,Period,empid,name,date,starttime,endtime,totalminutes) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & empid & "','" & name & "','" & dates & "','" & starttime & "','" & endtime & "'," & totalminutes & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportWorkingHoursDayOk = True
        Catch ex As Exception
            dr.Close()
            ImportWorkingHoursDayOk = False
        End Try
    End Sub

    Public Sub DeleteWorkingDay()
        Try
            cmd.CommandText = "delete from WorkingDaily"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportWorkingDay(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal empid As String, ByVal name As String, ByVal dates As String, ByVal presentabsent As String)
        Try
            cmd.CommandText = "insert into workingdaily(InsID,InsName,Period,empid,name,date,presentabsent) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & empid & "','" & name & "','" & dates & "','" & presentabsent & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportWorkingHoursDayOk = True
        Catch ex As Exception
            dr.Close()
            ImportWorkingHoursDayOk = False
        End Try
    End Sub

    Public Sub DeleteSalaryCalculation()
        Try
            cmd.CommandText = "delete from Salary"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportSalaryCalculation(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal month As String, ByVal year As Integer, ByVal regno As String, ByVal designation As String, ByVal name As String, ByVal doj As String, ByVal thismonth As Integer, ByVal lastmonth As Integer, ByVal basicadjust As Decimal, ByVal daadjust As Decimal, ByVal hraadjust As Decimal, ByVal otheradjust As Decimal, ByVal ccsadjust As Decimal, ByVal incometaxadjust As Decimal, ByVal salaryadjust As Decimal, ByVal conveyancealw As Decimal, ByVal handicappedalw As Decimal, ByVal washingalw As Decimal, ByVal pfdeduction As Decimal, ByVal conveyancealwrs As Decimal, ByVal handicappedalwrs As Decimal, ByVal washingalwrs As Decimal, ByVal pfdeductionrs As Decimal, ByVal specialpay As Decimal, ByVal gslideduction As Decimal, ByVal houserent As Decimal, ByVal pfadvancerecovery As Decimal, ByVal ccsloan As Decimal, ByVal otherbankloan As Decimal, ByVal festivaladvance As Decimal, ByVal ccspo1loan As Decimal, ByVal ccspo2loan As Decimal, ByVal bankloan As Decimal, ByVal ppfloan As Decimal, ByVal GetDA As Decimal, ByVal GetArrier As Decimal, ByVal GetHRA As Decimal, ByVal DADeductThis As Decimal, ByVal DADeductLast As Decimal, ByVal DADeductionTotal As Decimal, ByVal HRADeductThis As Decimal, ByVal HRADeductLast As Decimal, ByVal HRADeductTotal As Decimal, ByVal DeductedMedical As Decimal, ByVal ProfessionTax As Decimal, ByVal TotalDeduction As Decimal, ByVal TotalGain As Decimal, ByVal NewBasic As Decimal, ByVal EmployerPFDeduct As Decimal, ByVal NetPay As Decimal, ByVal stopincrement As String, ByVal paywithheld As String)
        Try
            cmd.CommandText = "insert into Salary(InsID,InsName,Period,month,year,regno,designation,name,thismonth,lastmonth,basicadjust,daadjust,hraadjust,otheradjust,ccsadjust,incometaxadjust,salaryadjust,conveyancealw,handicappedalw,washingalw,pfdeduction,conveyancealwrs,handicappedalwrs,washingalwrs,pfdeductionrs,specialpay,gslideduction,houserent,pfadvancerecovery,ccsloan,otherbankloan,festivaladvance,ccspo1loan,ccspo2loan,bankloan,ppfloan,GetDA,GetArrier,GetHRA,DADeductThis,DADeductLast,DADeductionTotal,HRADeductThis,HRADeductLast,HRADeductTotal,DeductedMedical,ProfessionTax,TotalDeduction,TotalGain,NewBasic,EmployerPFDeduct,NetPay,stopincrement,paywithheld) values('" & InsID & "','" & InsName & "','" & Periodd & "','" & month & "'," & year & ",'" & regno & "','" & designation & "','" & name & "'," & thismonth & "," & lastmonth & "," & basicadjust & "," & daadjust & "," & hraadjust & "," & otheradjust & "," & ccsadjust & "," & incometaxadjust & "," & salaryadjust & "," & conveyancealw & "," & handicappedalw & "," & washingalw & "," & pfdeduction & "," & conveyancealwrs & "," & handicappedalwrs & "," & washingalwrs & "," & pfdeductionrs & "," & specialpay & "," & gslideduction & "," & houserent & "," & pfadvancerecovery & "," & ccsloan & "," & otherbankloan & "," & festivaladvance & "," & ccspo1loan & "," & ccspo2loan & "," & bankloan & "," & ppfloan & "," & GetDA & "," & GetArrier & "," & GetHRA & "," & DADeductThis & "," & DADeductLast & "," & DADeductionTotal & "," & HRADeductThis & "," & HRADeductLast & "," & HRADeductTotal & "," & DeductedMedical & "," & ProfessionTax & "," & TotalDeduction & "," & TotalGain & "," & NewBasic & "," & EmployerPFDeduct & "," & NetPay & ",'" & stopincrement & "','" & paywithheld & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportSalaryCalculationOk = True
        Catch ex As Exception
            ImportSalaryCalculationOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeletePayEmployee()
        Try
            cmd.CommandText = "delete from PayEmployee"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportPayEmployee(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal payslipno As String, ByVal salarymonth As String, ByVal salaryyear As Integer, ByVal salarydate As String, ByVal regno As String, ByVal name As String, ByVal designation As String, ByVal payinfo As String, ByVal getda As Decimal, ByVal getarrier As Decimal, ByVal gethra As Decimal, ByVal tax As Decimal, ByVal deduct As Decimal, ByVal gain As Decimal, ByVal newbasic As Decimal, ByVal netpay As Decimal, ByVal stopincrement As String, ByVal paywithheld As String)
        Try
            cmd.CommandText = "insert into PayEmployee(InsID,InsName,Period,payslipno,salarymonth,salaryyear,salarydate,regno,name,designation,payinfo,getda,getarrier,gethra,tax,deduct,gain,newbasic,netpay,stopincrement,paywithheld) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & payslipno & "','" & salarymonth & "'," & salaryyear & ",'" & salarydate & "','" & regno & "','" & name & "','" & designation & "','" & payinfo & "'," & getda & "," & getarrier & "," & gethra & "," & tax & "," & deduct & "," & gain & "," & newbasic & "," & netpay & ",'" & stopincrement & "','" & paywithheld & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportPayEmployeeOk = True
        Catch ex As Exception
            ImportPayEmployeeOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteAdvanceWithdrawal()
        Try
            cmd.CommandText = "delete from PFAdvanceWithdrawal"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportAdvanceWithdrawal(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal month As String, ByVal regno As String, ByVal name As String, ByVal openingbalance As Decimal, ByVal options As String, ByVal amount As Decimal, ByVal particulars As String)
        Try
            cmd.CommandText = "insert into PFAdvanceWithdrawal(InsID,InsName,Period,month,regno,name,openingbalance,options,amount,particulars) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & month & "','" & regno & "','" & name & "'," & openingbalance & ",'" & options & "'," & amount & ",'" & particulars & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportAdvanceWithdrawalOk = True
        Catch ex As Exception
            ImportAdvanceWithdrawalOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteIndividualPFRate()
        Try
            cmd.CommandText = "delete from PFRateIndividual"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportIndividualPFRate(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal year As Integer, ByVal regno As String, ByVal name As String, ByVal rate As Decimal, ByVal amount As Decimal)
        Try
            cmd.CommandText = "insert into PFRateIndividual(InsID,InsName,Period,year,regno,name,rate,amount) values ('" & InsID & "','" & InsName & "','" & Periodd & "'," & year & ",'" & regno & "','" & name & "'," & rate & "," & amount & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportIndividualPFRateOk = True
        Catch ex As Exception
            ImportIndividualPFRateOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteMembership()
        Try
            cmd.CommandText = "delete from CloseMembership"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportMembership(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal regno As String, ByVal name As String, ByVal closingbal As Decimal, ByVal outstanding As Decimal, ByVal closingdate As String)
        Try
            cmd.CommandText = "insert into CloseMembership(InsID,InsName,Period,regno,name,closingbal,outstanding,closingdate) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & regno & "','" & name & "'," & closingbal & "," & outstanding & ",'" & closingdate & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportMembershipOk = True
        Catch ex As Exception
            ImportMembershipOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteInstituteIndex()
        Try
            cmd.CommandText = "delete from InstituteIndex"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportInstituteIndex(ByVal iid As String)
        Try
            cmd.CommandText = "insert into InstituteIndex(InsID) values ('" & iid & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportInstituteIndexOk = True
        Catch ex As Exception
            ImportInstituteIndexOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteIndexx()
        Try
            cmd.CommandText = "delete from Indexx"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportIndexx(ByVal InsID As String, ByVal empid As String, ByVal hiredempid As String, ByVal deptid As String, ByVal desigid As String, ByVal pbid As String, ByVal noticeid As String, ByVal idserial As String, ByVal admissionsl As String, ByVal preadmissionsl As String, ByVal sturegid As String, ByVal monthlyid As String, ByVal lateid As String, ByVal othersid As String, ByVal libraryid As String, ByVal examfeesid As String, ByVal yearlyid As String, ByVal discountid As String, ByVal financialid As String, ByVal depositid As String, ByVal examid As String, ByVal onlinexmid As String, ByVal assignmentid As String, ByVal markid As String, ByVal progressid As String, ByVal controlid As String, ByVal groupid As String, ByVal subjectid As String, ByVal bookid As String, ByVal issueid As String, ByVal daid As String, ByVal inventoryid As String, ByVal purchaseid As String, ByVal invoiceid As String, ByVal gameid As String, ByVal certificateid As String, ByVal salaryid As String, ByVal userid As String)
        Try
            cmd.CommandText = "insert into Indexx(InsID,empid,hiredempid,deptid,desigid,pbid,noticeid,idserial,admissionsl,preadmissionsl,sturegid,monthlyid,lateid,othersid,libraryid,examfeesid,yearlyid,discountid,financialid,depositid,examid,onlinexmid,assignmentid,markid,progressid,controlid,groupid,subjectid,bookid,issueid,daid,inventoryid,purchaseid,invoiceid,gameid,certificateid,salaryid,userid) values ('" & InsID & "','" & empid & "','" & hiredempid & "','" & deptid & "','" & desigid & "','" & pbid & "','" & noticeid & "','" & idserial & "','" & admissionsl & "','" & preadmissionsl & "','" & sturegid & "','" & monthlyid & "','" & lateid & "','" & othersid & "','" & libraryid & "','" & examfeesid & "','" & yearlyid & "','" & discountid & "','" & financialid & "','" & depositid & "','" & examid & "','" & onlinexmid & "','" & assignmentid & "','" & markid & "','" & progressid & "','" & controlid & "','" & groupid & "','" & subjectid & "','" & bookid & "','" & issueid & "','" & daid & "','" & inventoryid & "','" & purchaseid & "','" & invoiceid & "','" & gameid & "','" & certificateid & "','" & salaryid & "','" & userid & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportIndexxOk = True
        Catch ex As Exception
            ImportIndexxOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteInstitute()
        Try
            cmd.CommandText = "delete from Institute"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportInstitute(ByVal InsID As String, ByVal periodd As String, ByVal InsName As String, ByVal Address1 As String, ByVal Address2 As String, ByVal City As String, ByVal State As String, ByVal Pin As String, ByVal Country As String, ByVal Telephone As String, ByVal Fax As String, ByVal Email As String, ByVal Url1 As String, ByVal Url2 As String, ByVal Category As String, ByVal AccountingManagement As String, ByVal FinancialPeriod As String, ByVal FinancialMonth As String, ByVal FinancialYear As Integer, ByVal StartDate As String, ByVal StartingMonth As String)
        Try
            cmd.CommandText = "insert into Institute(InsID,period,InsName,Address1,Address2,City,State,Pin,Country,Telephone,Fax,Email,Url1,Url2,Category,AccountingManagement,FinancialPeriod,FinancialMonth,FinancialYear,StartDate,StartingMonth) values ('" & InsID & "','" & periodd & "','" & InsName & "','" & Address1 & "','" & Address2 & "','" & City & "','" & State & "','" & Pin & "','" & Country & "','" & Telephone & "','" & Fax & "','" & Email & "','" & Url1 & "','" & Url2 & "','" & Category & "','" & AccountingManagement & "','" & FinancialPeriod & "','" & FinancialMonth & "'," & FinancialYear & ",'" & StartDate & "','" & StartingMonth & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportInstituteOk = True
        Catch ex As Exception
            ImportInstituteOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteFinancialYear()
        Try
            cmd.CommandText = "delete from FinancialYear"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportFinancialYear(ByVal InsID As String, ByVal Periodd As String, ByVal InsName As String, ByVal FiscalNo As Integer, ByVal Indexx As Integer, ByVal PeriodValue As String)
        Try
            cmd.CommandText = "insert into FinancialYear(InsID,Period,InsName,FiscalNo,Indexx,PeriodValue) values ('" & InsID & "','" & Periodd & "','" & InsName & "'," & FiscalNo & "," & Indexx & ",'" & PeriodValue & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportFinancialYearOk = True
        Catch ex As Exception
            ImportFinancialYearOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteFeatures()
        Try
            cmd.CommandText = "delete from Features"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportFeatures(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal Features As String)
        Try
            cmd.CommandText = "insert into Features(InsID,InsName,Period,Features) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & Features & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportFeaturesOk = True
        Catch ex As Exception
            ImportFeaturesOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteAchievements()
        Try
            cmd.CommandText = "delete from Achievements"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportAchievements(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal Achievements As String)
        Try
            cmd.CommandText = "insert into Achievements(InsID,InsName,Period,Achievements) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & Achievements & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportAchievementsOk = True
        Catch ex As Exception
            ImportAchievementsOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteAccountingPeriod()
        Try
            cmd.CommandText = "delete from AccountingPeriod"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportAccountingPeriod(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal FinancialPeriod As String)
        Try
            cmd.CommandText = "insert into AccountingPeriod(InsID,InsName,Period,FinancialPeriod) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & FinancialPeriod & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportAccountingPeriodOk = True
        Catch ex As Exception
            ImportAccountingPeriodOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteDefaultInstitute()
        Try
            cmd.CommandText = "delete from DefaultInstitute"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportDefaultInstitute(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal alwayspurchase As String, ByVal invoicemessage As String, ByVal ordermessage As String, ByVal gameexpense As String, ByVal customfield1 As String, ByVal customfield2 As String, ByVal customfield3 As String, ByVal customfield4 As String, ByVal customfield5 As String, ByVal checkcustomfield1 As String, ByVal checkcustomfield2 As String, ByVal checkcustomfield3 As String, ByVal checkcustomfield4 As String, ByVal checkcustomfield5 As String, ByVal costmethod As String, ByVal stockglsalesacc As String, ByVal stockglinvacc As String, ByVal stockglcostacc As String, ByVal stockcostingacc As String, ByVal masterglsalesacc As String, ByVal masterglinvacc As String, ByVal masterglcostacc As String, ByVal mastercostingacc As String, ByVal nonstockglsalesacc As String, ByVal nonstockglinvacc As String, ByVal nonstockglcostacc As String, ByVal nonstockcostingacc As String, ByVal descriptionglsalesacc As String, ByVal descriptionglinvacc As String, ByVal descriptionglcostacc As String, ByVal descriptioncostingacc As String, ByVal serviceglsalesacc As String, ByVal serviceglinvacc As String, ByVal serviceglcostacc As String, ByVal servicecostingacc As String, ByVal laborglsalesacc As String, ByVal laborglinvacc As String, ByVal laborglcostacc As String, ByVal laborcostingacc As String, ByVal assemblyglsalesacc As String, ByVal assemblyglinvacc As String, ByVal assemblyglcostacc As String, ByVal assemblycostingacc As String, ByVal activitylsalesacc As String, ByVal activityglinvacc As String, ByVal activityglcostacc As String, ByVal activitycostingacc As String, ByVal chargeglsalesacc As String, ByVal chargeglinvacc As String, ByVal chargeglcostacc As String, ByVal chargecostingacc As String, ByVal glfreightacc As String, ByVal autoid As String, ByVal feesmonth As Integer, ByVal applydiscount As String, ByVal monthlyfeesacc As String, ByVal yearlyfeesacc As String, ByVal libraryfeesacc As String, ByVal latefeesacc As String, ByVal otherfeesacc As String, ByVal examfeesacc As String, ByVal discountfeesacc As String, ByVal bankdepositacc As String, ByVal purchaseorderacc As String, ByVal salesinvoiceacc As String)
        Try
            cmd.CommandText = "insert into DefaultInstitute(InsID,InsName,Period,alwayspurchase,invoicemessage,ordermessage,gameexpense,customfield1,customfield2,customfield3,customfield4,customfield5,checkcustomfield1,checkcustomfield2,checkcustomfield3,checkcustomfield4,checkcustomfield5,costmethod,stockglsalesacc,stockglinvacc,stockglcostacc,stockcostingacc,masterglsalesacc,masterglinvacc,masterglcostacc,mastercostingacc,nonstockglsalesacc,nonstockglinvacc,nonstockglcostacc,nonstockcostingacc,descriptionglsalesacc,descriptionglinvacc,descriptionglcostacc,descriptioncostingacc,serviceglsalesacc,serviceglinvacc,serviceglcostacc,servicecostingacc,laborglsalesacc,laborglinvacc,laborglcostacc,laborcostingacc,assemblyglsalesacc,assemblyglinvacc,assemblyglcostacc,assemblycostingacc,activitylsalesacc,activityglinvacc,activityglcostacc,activitycostingacc,chargeglsalesacc,chargeglinvacc,chargeglcostacc,chargecostingacc,glfreightacc,autoid,feesmonth,applydiscount,monthlyfeesacc,yearlyfeesacc,libraryfeesacc,latefeesacc,otherfeesacc,examfeesacc,discountfeesacc,bankdepositacc,purchaseorderacc,salesinvoiceacc) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & alwayspurchase & "','" & invoicemessage & "','" & ordermessage & "','" & gameexpense & "','" & customfield1 & "','" & customfield2 & "','" & customfield3 & "','" & customfield4 & "','" & customfield5 & "','" & checkcustomfield1 & "','" & checkcustomfield2 & "','" & checkcustomfield3 & "','" & checkcustomfield4 & "','" & checkcustomfield5 & "','" & costmethod & "','" & stockglsalesacc & "','" & stockglinvacc & "','" & stockglcostacc & "','" & stockcostingacc & "','" & masterglsalesacc & "','" & masterglinvacc & "','" & masterglcostacc & "','" & mastercostingacc & "','" & nonstockglsalesacc & "','" & nonstockglinvacc & "','" & nonstockglcostacc & "','" & nonstockcostingacc & "','" & descriptionglsalesacc & "','" & descriptionglinvacc & "','" & descriptionglcostacc & "','" & descriptioncostingacc & "','" & serviceglsalesacc & "','" & serviceglinvacc & "','" & serviceglcostacc & "','" & servicecostingacc & "','" & laborglsalesacc & "','" & laborglinvacc & "','" & laborglcostacc & "','" & laborcostingacc & "','" & assemblyglsalesacc & "','" & assemblyglinvacc & "','" & assemblyglcostacc & "','" & assemblycostingacc & "','" & activitylsalesacc & "','" & activityglinvacc & "','" & activityglcostacc & "','" & activitycostingacc & "','" & chargeglsalesacc & "','" & chargeglinvacc & "','" & chargeglcostacc & "','" & chargecostingacc & "','" & glfreightacc & "','" & autoid & "'," & feesmonth & ",'" & applydiscount & "','" & monthlyfeesacc & "','" & yearlyfeesacc & "','" & libraryfeesacc & "','" & latefeesacc & "','" & otherfeesacc & "','" & examfeesacc & "','" & discountfeesacc & "','" & bankdepositacc & "','" & purchaseorderacc & "','" & salesinvoiceacc & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportDefaultInstituteOk = True
        Catch ex As Exception
            ImportDefaultInstituteOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteDefaultLibrary()
        Try
            cmd.CommandText = "delete from DefaultLibrary"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportDefaultLibrary(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal autoid As String, ByVal chargesaccount As String)
        Try
            cmd.CommandText = "insert into DefaultLibrary(InsID,InsName,Period,autoid,chargesaccount) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & autoid & "','" & chargesaccount & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportDefaultLibraryOk = True
        Catch ex As Exception
            ImportDefaultLibraryOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteDefaultPayroll()
        Try
            cmd.CommandText = "delete from DefaultPayroll"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportDefaultPayroll(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal autoid As String, ByVal salaryaccount As String, ByVal basicincr As Decimal)
        Try
            cmd.CommandText = "insert into DefaultPayroll(InsID,InsName,Period,autoid,salaryaccount,basicincr) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & autoid & "','" & salaryaccount & "'," & basicincr & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportDefaultPayrollOk = True
        Catch ex As Exception
            ImportDefaultPayrollOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteStudentControl()
        Try
            cmd.CommandText = "delete from StudentControl"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportStudentControl(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal controlid As String, ByVal regno As String, ByVal name As String, ByVal course As String, ByVal examination As String, ByVal scored As Decimal, ByVal passfail As String, ByVal credits As Decimal, ByVal reference As String, ByVal remarks As String, ByVal alsoupdate As String, ByVal newcouse As String, ByVal newclassint As Integer, ByVal newclassstring As String, ByVal newclass As String, ByVal newroll As String, ByVal newtime As String, ByVal newtuition As String)
        Try
            cmd.CommandText = "insert into StudentControl(InsID,InsName,Period,SystemDate,controlid,regno,name,course,examination,scored,passfail,credits,reference,remarks,alsoupdate,newcouse,newclassint,newclassstring,newclass,newroll,newtime,newtuition) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & controlid & "','" & regno & "','" & name & "','" & course & "','" & examination & "'," & scored & ",'" & passfail & "'," & credits & ",'" & reference & "','" & remarks & "','" & alsoupdate & "','" & newcouse & "'," & newclassint & ",'" & newclassstring & "','" & newclass & "','" & newroll & "','" & newtime & "','" & newtuition & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportStudentControlOk = True
        Catch ex As Exception
            dr.Close()
            ImportStudentControlOk = False
        End Try
    End Sub

    Public Sub DeletePFRate()
        Try
            cmd.CommandText = "delete from PFRate"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ImportPFRate(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal year As Integer, ByVal rate As Decimal, ByVal amount As Decimal)
        Try
            cmd.CommandText = "insert into PFRate(InsID,InsName,Period,year,rate,amount) values ('" & InsID & "','" & InsName & "','" & Periodd & "'," & year & "," & rate & "," & amount & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            ImportPFRateOk = True
        Catch ex As Exception
            ImportPFRateOk = False
            dr.Close()
        End Try
    End Sub
#End Region
End Class
#End Region