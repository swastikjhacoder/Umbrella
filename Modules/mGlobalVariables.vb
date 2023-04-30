Module mGlobalVariables
    Public MainTask As String

    Public UmbrellaSystemDate As String

    Public InstituteReports As String
    Public LibraryReports As String
    Public PayrollReports As String

    Public ctc As New cTextChange()

    Public InstitutionID As String
    Public InstitutionCategory As String
    Public InstitutionName As String
    Public InstitutionAddress1 As String
    Public InstitutionAddress2 As String
    Public InstitutionCity As String
    Public InstitutionState As String
    Public InstitutionPinCode As String
    Public InstitutionCountry As String
    Public InstitutionPhone As String
    Public InstitutionFax As String
    Public InstitutionEmail As String
    Public InstitutionUrl1 As String
    Public InstitutionUrl2 As String
    Public AccountingManagement As String
    Public mnths As Integer = 0
    Public FinancialPeriod As String
    Public FinancialMonth As String
    Public FinancialYear As Integer

    Public updatecourse As String
    Public crscode As String
    Public crsname As String
    Public crsduration As String
    Public crsfees As Decimal = 0.0
    Public CourseName(100) As String
    Public CourseCode(100) As String
    Public CourseDuaration(100) As String
    Public TotalCourses As Integer
    Public Terms(100) As String

    Public SelectedFeatures(100) As String

    Public Achievements(100) As String
    Public TotalAchievements As Integer
    Public TotalFeatures As Integer

    Public Accounts(100) As String
    Public AccountsID(100) As String
    Public TotalAccounts As Integer

    Public openselectedinstitute As String
    Public openselectedform As String
    Public period As String
    Public periodvalue As String

    Public Attachments(1000) As String
    Public strHostName As String
    Public strIPAddress As String
    Public ServerStarted As Boolean = False

    Public cstartingmonth As String
    Public cperiods As Integer
    Public cstartdate As String
    Public instituteindex As Boolean = False

    Public updateemployee As Boolean = False
    Public updatehiredemployee As Boolean = False
    Public EmpRegNo As String
    Public EmpName As String
    Public EmpDesignation As String

    Public backupdatabase As Boolean = False
    Public restoredatabase As Boolean = False

    Public updatedept As Boolean = False
    Public deptcode As String
    Public deptname As String

    Public updatedesig As Boolean = False
    Public desigcode As String
    Public designame As String

    Public updatepayscale As Boolean = False
    Public pbname As String
    Public pbscale As String

    Public updatenotice As Boolean = False
    Public noticeid As String

    Public updateidcard As Boolean = False
    Public idserial As String
    Public idcardfor As String
    Public idregno As String
    Public idname As String
    Public iddob As String
    Public idsex As String
    Public idcoursedesid As String
    Public idaddress As String
    Public submitidcardregno As String

    Public updatestudentadm As Boolean = False
    Public updatestudentpreadm As Boolean = False
    Public updatestudentreg As Boolean = False
    Public StuID As String
    Public StuName As String
    Public StuClass As String
    Public StuRoll As String

    Public updatemonthlyfees As Boolean = False
    Public monthlydate As String
    Public monthlyamount As Decimal = 0.0

    Public updateotherfees As Boolean = False
    Public otherdate As String
    Public otheramount As Decimal = 0.0

    Public updateexamfees As Boolean = False
    Public examfeesdate As String
    Public examfeesamount As Decimal = 0.0

    Public updateyaerlyfees As Boolean = False
    Public yaerlyfeesdate As String
    Public yaerlyfeesamount As Decimal = 0.0

    Public updatelatefees As Boolean = False
    Public latefeesdate As String
    Public latefeesamount As Decimal = 0.0

    Public AccID As String
    Public AccName As String
    Public AccBal As String = 0.0

    Public updateuser As Boolean = False
    Public userid As String
    Public userrole As String
    Public UserLogin As Boolean = False
    Public CurrentUser As String

    Public updateexamination As Boolean = False
    Public examcode As String
    Public examcourse As String
    Public examdate As String

    Public updatesubject As Boolean = False
    Public subjectcode As String
    Public subject As String

    Public updatesyllabus As Boolean = False
    Public chapter As String

    Public updateassignment As Boolean = False
    Public assignmentid As String

    Public updatemarksheet As Boolean = False
    Public markid As String
    Public totalmarks As Integer = 0

    Public updatediscount As Boolean = False
    Public discountdate As String
    Public discountappliedfor As String
    Public discountname As String
    Public discountregno As String

    Public updatefinancial As Boolean = False
    Public financialid As String

    Public updatebankdeposit As Boolean = False
    Public depositid As String
    Public depositdate As String

    Public transactionid As String

    Public updategroup As Boolean = False
    Public GroupID As String
    Public GroupName As String

    Public updatesubjectbooks As Boolean = False
    Public SubjectID As String
    Public SubjectName As String

    Public updatebook As Boolean = False
    Public BookID As String
    Public BookName As String

    Public updatebookcharge As Boolean = False
    Public CourseCharge As String

    Public updateissebooks As Boolean = False
    Public IssedID As String
    Public IssueToID As String
    Public IssueToName As String
    Public IssueDate As String
    Public updatereturnbooks As Boolean = False

    Public updatecalculatecharge As Boolean = False
    Public chargedate As String
    Public totallibrarycharge As Decimal = 0.0

    Public updateprofessionaltax As Boolean = False
    Public professionalgross As Decimal = 0.0
    Public professionaltaxrate As Decimal = 0.0

    Public updateadjustmentsdeductions As Boolean = False
    Public adjustmentmonth As String
    Public adjustmentyear As Integer = 0

    Public updatepfadvwith As Boolean = False
    Public pfadvwithmonth As String
    Public pfoptions As String

    Public updatepfrateindividual As Boolean = False

    Public updatepfmembership As Boolean = False
    Public updateworking As Boolean = False

    Public updateprogessreport As Boolean = False
    Public progessid As String

    Public updateinventory As Boolean = False
    Public itemid As String
    Public itemdescription As String
    Public itemname As String
    Public itemclass As String
    Public itemprice As Decimal = 0.0
    Public itempricelevel As String
    Public ItemNote As String

    Public updatepurchase As Boolean = False
    Public purchaseid As String
    Public purchasedate As String
    Public PurchaseNote As String

    Public updateinvoice As Boolean = False
    Public invoiceid As String
    Public invoicedate As String
    Public InvoiceNote As String

    Public updategame As Boolean = False
    Public gameid As String

    Public updatecertificate As Boolean = False
    Public certificateid As String

    Public updatestudentcontrol As Boolean = False
    Public controlid As String

    Public updateonlineqsn As Boolean = False
    Public qsnid As String
    Public qsndate As String

    Public updatepayemployee As Boolean = False
    Public salaryid As String

    Public YearEndOk As Boolean = False
End Module
