#Region "Imports"
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports Microsoft.Office.Interop.Excel
Imports System.IO
#End Region
#Region "Class frmProcessingInstitute"
Public Class frmProcessingInstitute
#Region "Declarations"
    Dim AddInstituteOk As Boolean = False
    Dim c1 As Integer
    Dim p1 As Integer = 1
#End Region
#Region "Functions"
    Private Function fncExcelExport(ByVal strSql As String, ByVal strAppPath As String, ByVal strExcelFile As String, ByVal strFileName As String)

        Dim dsExcelExport As New DataSet
        Dim daExcelExport As New SqlDataAdapter
        Dim Excel As New Application
        Dim intColumn, intRow, intColumnValue As Integer
        Dim conCurrent As New SqlConnection
        conCurrent = New SqlConnection("data Source=.;Initial Catalog=eSchool;Persist Security Info=True;User ID=sa;Password=123")
        daExcelExport = New SqlDataAdapter(strSql, conCurrent)
        Dim varCommand As New SqlCommand(strSql, conCurrent)
        daExcelExport = New SqlDataAdapter(varCommand)
        daExcelExport.Fill(dsExcelExport)
        With Excel
            .SheetsInNewWorkbook = 1
            .Workbooks.Add()
            .Worksheets(1).Select()
            For intColumn = 0 To dsExcelExport.Tables(0).Columns.Count - 1
                .Cells(1, intColumn + 1).Value = dsExcelExport.Tables(0).Columns(intColumn).ColumnName.ToString
            Next
            For intRow = 0 To dsExcelExport.Tables(0).Rows.Count - 1
                For intColumnValue = 0 To dsExcelExport.Tables(0).Columns.Count - 1
                    .Cells(intRow + 1, intColumnValue + 1).Value = dsExcelExport.Tables(0).Rows(intRow).ItemArray(intColumnValue).ToString
                Next
            Next
            .ActiveWorkbook().SaveAs(strExcelFile)
            .ActiveWorkbook.Close()
        End With
NormalExit:
        Excel.Quit()
        Excel = Nothing
        GC.Collect()
        Return Excel
        Exit Function
    End Function
#End Region
#Region "Methods"
    Private Sub CreateFolder(ByVal Path As String, ByVal FolderName As String, Optional ByVal Attributes As System.IO.FileAttributes = IO.FileAttributes.Normal)
        If My.Computer.FileSystem.DirectoryExists(Path) = False Then
            Throw New Exception("The specified path does not exist. Make sure the specified path has been spelled correctly.")
        ElseIf My.Computer.FileSystem.DirectoryExists(Path & "\" & FolderName) Then
            Throw New Exception("Could not create the folder" + FolderName + " because it already exists.")
        Else
            My.Computer.FileSystem.CreateDirectory(Path & "\" & FolderName)
            If Not Attributes = IO.FileAttributes.Normal Then
                My.Computer.FileSystem.GetDirectoryInfo(Path & "\" & FolderName).Attributes = Attributes
            End If
        End If
    End Sub

    Private Sub CreateDirectories()
        CreateFolder(AppDomain.CurrentDomain.BaseDirectory + "\" + "bin" + "\" + "data", InstitutionName, FileAttributes.System)
        CreateFolder(AppDomain.CurrentDomain.BaseDirectory + "\" + "bin" + "\" + "data" + "\" + InstitutionName, InstitutionName, FileAttributes.System)
        CreateFolder(AppDomain.CurrentDomain.BaseDirectory + "\" + "bin" + "\" + "data" + "\" + InstitutionName, "Backup", FileAttributes.System)
        CreateFolder(AppDomain.CurrentDomain.BaseDirectory + "\" + "bin" + "\" + "data" + "\" + InstitutionName, "System", FileAttributes.System)
        CreateFolder(AppDomain.CurrentDomain.BaseDirectory + "\" + "bin" + "\" + "data" + "\" + InstitutionName, "Admission", FileAttributes.System)
        CreateFolder(AppDomain.CurrentDomain.BaseDirectory + "\" + "bin" + "\" + "data" + "\" + InstitutionName, "Fees", FileAttributes.System)
        CreateFolder(AppDomain.CurrentDomain.BaseDirectory + "\" + "bin" + "\" + "data" + "\" + InstitutionName, "Examination", FileAttributes.System)
        CreateFolder(AppDomain.CurrentDomain.BaseDirectory + "\" + "bin" + "\" + "data" + "\" + InstitutionName, "Activity", FileAttributes.System)
        CreateFolder(AppDomain.CurrentDomain.BaseDirectory + "\" + "bin" + "\" + "data" + "\" + InstitutionName, "Users", FileAttributes.System)
        CreateFolder(AppDomain.CurrentDomain.BaseDirectory + "\" + "bin" + "\" + "data" + "\" + InstitutionName, "Thrush", FileAttributes.System)

        Dim StrPath1 As String = AppDomain.CurrentDomain.BaseDirectory + "bin" + "\" + "data" + "\" + InstitutionName + "\" + InstitutionName + "\"
        Dim ExcelObject1 As Object
        Dim strFileName1 As String = InstitutionName + ".xlsx"
        Dim strExcelFile1 As String = StrPath1 & InstitutionName & "_" & "data"
        Dim sqlcmd1 As String = "select * from Institute where InsName='" & InstitutionName & "'"
        ExcelObject1 = fncExcelExport(sqlcmd1, StrPath1, strExcelFile1, strFileName1)
        Dim ExcelObject2 As Object
        Dim strFileName2 As String = "Course.xlsx"
        Dim strExcelFile2 As String = StrPath1 & InstitutionName & "_" & "Course"
        Dim sqlcmd2 As String = "select * from Course where InsName='" & InstitutionName & "'"
        ExcelObject2 = fncExcelExport(sqlcmd2, StrPath1, strExcelFile2, strFileName2)
        Dim ExcelObject3 As Object
        Dim strFileName3 As String = "Features.xlsx"
        Dim strExcelFile3 As String = StrPath1 & InstitutionName & "_" & "Features"
        Dim sqlcmd3 As String = "select * from Features where InsName='" & InstitutionName & "'"
        ExcelObject3 = fncExcelExport(sqlcmd3, StrPath1, strExcelFile3, strFileName3)
        Dim ExcelObject4 As Object
        Dim strFileName4 As String = "Achievements.xlsx"
        Dim strExcelFile4 As String = StrPath1 & InstitutionName & "_" & "Achievements"
        Dim sqlcmd4 As String = "select * from Achievements where InsName='" & InstitutionName & "'"
        ExcelObject4 = fncExcelExport(sqlcmd4, StrPath1, strExcelFile4, strFileName4)
        Dim ExcelObject5 As Object
        Dim strFileName5 As String = "Accounts.xlsx"
        Dim strExcelFile5 As String = StrPath1 & InstitutionName & "_" & "Accounts"
        Dim sqlcmd5 As String = "select * from Accounts where InsName='" & InstitutionName & "'"
        ExcelObject5 = fncExcelExport(sqlcmd5, StrPath1, strExcelFile5, strFileName5)

        My.Computer.FileSystem.RenameFile(AppDomain.CurrentDomain.BaseDirectory + "bin" + "\" + "data" + "\" + InstitutionName + "\" + InstitutionName + "\" + InstitutionName + "_" + "data.xlsx", InstitutionName + "_" + "data.data")
        My.Computer.FileSystem.RenameFile(AppDomain.CurrentDomain.BaseDirectory + "bin" + "\" + "data" + "\" + InstitutionName + "\" + InstitutionName + "\" + InstitutionName + "_" + "Course.xlsx", InstitutionName + "_" + "Course.data")
        My.Computer.FileSystem.RenameFile(AppDomain.CurrentDomain.BaseDirectory + "bin" + "\" + "data" + "\" + InstitutionName + "\" + InstitutionName + "\" + InstitutionName + "_" + "Features.xlsx", InstitutionName + "_" + "Features.data")
        My.Computer.FileSystem.RenameFile(AppDomain.CurrentDomain.BaseDirectory + "bin" + "\" + "data" + "\" + InstitutionName + "\" + InstitutionName + "\" + InstitutionName + "_" + "Achievements.xlsx", InstitutionName + "_" + "Achievements.data")
        My.Computer.FileSystem.RenameFile(AppDomain.CurrentDomain.BaseDirectory + "bin" + "\" + "data" + "\" + InstitutionName + "\" + InstitutionName + "\" + InstitutionName + "_" + "Accounts.xlsx", InstitutionName + "_" + "Accounts.data")
    End Sub

    Private Sub CreateInstitute()
        Dim cls As New cInstitute()
        cls.AddInstitute(InstitutionID, period, InstitutionName, InstitutionAddress1, InstitutionAddress2, InstitutionCity, InstitutionState, InstitutionPinCode, InstitutionCountry, InstitutionPhone, InstitutionFax, InstitutionEmail, InstitutionUrl1, InstitutionUrl2, InstitutionCategory, AccountingManagement, FinancialPeriod, FinancialMonth, FinancialYear, cstartdate, cstartingmonth)
        If cls.AddInstituteOk = True Then
            My.Settings.LastOpenedInstitute = InstitutionName
            My.Settings.LastOpenedInstituteID = InstitutionID
            My.Settings.Period = period
            AddInstituteOk = True
        End If
    End Sub

    Private Sub CreateCourse()
        Dim cls As New cInstitute()
        If AddInstituteOk = True Then
            If TotalCourses > 0 Then
                Dim year As String = Date.Now.Year.ToString()
                For l As Integer = 0 To TotalCourses - 1
                    cls.AddCourse(InstitutionID, InstitutionName, FinancialPeriod, year, CourseName(l), CourseCode(l), CourseDuaration(l))
                Next
            End If
        End If
    End Sub

    Private Sub CreateCourseFees()
        Dim cls As New cInstitute()

        Terms(0) = "Admission Fee:"
        Terms(1) = "Tuitions Fee:"
        Terms(2) = "Development Fee:"
        Terms(3) = "Sessional Fee:"
        Terms(4) = "Registration Fee:"
        Terms(5) = "Examination Fee:"
        Terms(6) = "Library Caution Fee:"
        Terms(7) = "Lab Caution Fee:"
        Terms(8) = "Lab Maintenance Fee:"
        Terms(9) = "Lab Fee:"
        Terms(10) = "System Development Fee:"
        Terms(11) = "ID Card Fee:"
        Terms(12) = "Student Health Home Fee:"
        Terms(13) = "Miscellaneous Fee:"
        Terms(14) = "Migration Fee:"
        Terms(15) = "Student Ext. Activity Fee:"
        Terms(16) = "Sports Fee:"
        Terms(17) = "Transfer Fee:"
        Terms(18) = "Book Bank Fee:"
        Terms(19) = "Practical Fee:"
        Terms(20) = "Cost of Exam Form:"
        Terms(21) = "Centre Fee:"
        Terms(22) = "Suppl. Exam Fee:"
        Terms(23) = "Service Charge:"
        Terms(24) = "Change of Subject Fee:"
        Terms(25) = "Fine:"
        Terms(26) = "Syllabus Fee:"
        Terms(27) = "Academic Calendar Fee:"
        Terms(28) = "Diploma Fee:"
        Terms(29) = "Donation Fee:"
        Terms(30) = "Health Services Fee:"
        Terms(31) = "Student Representation Fee:"
        Terms(32) = "Nonresident Capital Outlay Fee:"
        Terms(33) = "International Student Application Fee:"
        Terms(34) = "International Student Tuition Fee:"
        Terms(35) = "International Student Capital Outlay Fee:"
        Terms(36) = "International Student (F-1 Visa):"
        Terms(37) = "Health Insurance:"
        Terms(38) = "Insurance Website:"
        Terms(39) = "Student Body Fee:"
        Terms(40) = "Parking Fee:"
        Terms(41) = "Audit Fee:"
        Terms(42) = "Instructional Materials Fee:"
        Terms(43) = "Duplicate Diploma Fee:"
        Terms(44) = "Returned Check Fee:"
        Terms(45) = "Transcript Fee:"

        Dim Course As String = ""
        Dim year As String = Date.Now.Year.ToString()

        For l As Integer = 0 To TotalCourses - 1
            For i As Integer = 0 To 45
                cls.AddCourseFees(InstitutionID, InstitutionName, FinancialPeriod, year, CourseName(l), Terms(i))
            Next
        Next
    End Sub

    Private Sub CreateFeatures()
        Dim cls As New cInstitute()
        If AddInstituteOk = True Then
            If TotalFeatures > 0 Then
                For l As Integer = 0 To TotalFeatures - 1
                    cls.AddFeatures(InstitutionID, InstitutionName, FinancialPeriod, SelectedFeatures(l))
                Next
            End If
        End If
    End Sub

    Private Sub CreateAchievements()
        Dim cls As New cInstitute()
        If AddInstituteOk = True Then
            For l As Integer = 0 To 99
                cls.AddAchievements(InstitutionID, InstitutionName, FinancialPeriod, Achievements(l))
            Next
        End If
    End Sub

    Private Sub CreateAccounts()
        Dim cls As New cInstitute()
        Dim AccoutnTypeP(68) As String
        AccoutnTypeP(0) = "Income"
        AccoutnTypeP(1) = "Income"
        AccoutnTypeP(2) = "Expenditure"
        AccoutnTypeP(3) = "Expenditure"
        AccoutnTypeP(4) = "Expenditure"
        AccoutnTypeP(5) = "Expenditure"
        AccoutnTypeP(6) = "Expenditure"
        AccoutnTypeP(7) = "Expenditure"
        AccoutnTypeP(8) = "Expenditure"
        AccoutnTypeP(9) = "Expenditure"
        AccoutnTypeP(10) = "Expenditure"
        AccoutnTypeP(11) = "Expenditure"
        AccoutnTypeP(12) = "Expenditure"
        AccoutnTypeP(13) = "Expenditure"
        AccoutnTypeP(14) = "Expenditure"
        AccoutnTypeP(15) = "Expenditure"
        AccoutnTypeP(16) = "Expenditure"
        AccoutnTypeP(17) = "Expenditure"
        AccoutnTypeP(18) = "Expenditure"
        AccoutnTypeP(19) = "Expenditure"
        AccoutnTypeP(20) = "Stock"
        AccoutnTypeP(21) = "Income"
        AccoutnTypeP(22) = "Income"
        AccoutnTypeP(23) = "Expenditure"
        AccoutnTypeP(24) = "Income"
        AccoutnTypeP(25) = "Income"
        
        If AddInstituteOk = True Then
            If TotalAccounts > 0 Then
                For l As Integer = 0 To TotalAccounts - 1
                    cls.AddAccounts(InstitutionID, InstitutionName, FinancialPeriod, AccountsID(l), Accounts(l), AccoutnTypeP(l))
                Next
                Dim AccID(42) As String
                Dim AccName(42) As String
                Dim AccountTypeL(42) As String

                AccID(0) = "100055"
                AccName(0) = "Stock GL Sales"
                AccountTypeL(0) = "Income"

                AccID(1) = "100056"
                AccName(1) = "Stock GL Inventory"
                AccountTypeL(1) = "Stock"

                AccID(2) = "100057"
                AccName(2) = "Stock GL Cost"
                AccountTypeL(2) = "Expenditure"

                AccID(3) = "100058"
                AccName(3) = "Stock Costing"
                AccountTypeL(3) = "Expenditure"

                AccID(4) = "100059"
                AccName(4) = "Master GL Sales"
                AccountTypeL(4) = "Income"

                AccID(5) = "100060"
                AccName(5) = "Master GL Inventory"
                AccountTypeL(5) = "Stock"

                AccID(6) = "100061"
                AccName(6) = "Master GL Cost"
                AccountTypeL(6) = "Expenditure"

                AccID(7) = "100062"
                AccName(7) = "Master Costing"
                AccountTypeL(7) = "Expenditure"

                AccID(8) = "100063"
                AccName(8) = "Non Stock GL Sales"
                AccountTypeL(8) = "Income"

                AccID(9) = "100064"
                AccName(9) = "Non Stock GL Inventory"
                AccountTypeL(9) = "Stock"

                AccID(10) = "100065"
                AccName(10) = "Non Stock GL Cost"
                AccountTypeL(10) = "Expenditure"

                AccID(11) = "100066"
                AccName(11) = "Non Stock Costing"
                AccountTypeL(11) = "Expenditure"

                AccID(12) = "100067"
                AccName(12) = "Description GL Sales"
                AccountTypeL(12) = "Income"

                AccID(13) = "100068"
                AccName(13) = "Description GL Inventory"
                AccountTypeL(13) = "Stock"

                AccID(14) = "100069"
                AccName(14) = "Description GL Cost"
                AccountTypeL(14) = "Expenditure"

                AccID(15) = "100070"
                AccName(15) = "Description Costing"
                AccountTypeL(15) = "Expenditure"

                AccID(16) = "100071"
                AccName(16) = "Service GL Sales"
                AccountTypeL(16) = "Income"

                AccID(17) = "100072"
                AccName(17) = "Service GL Inventory"
                AccountTypeL(17) = "Stock"

                AccID(18) = "100073"
                AccName(18) = "Service GL Cost"
                AccountTypeL(18) = "Expenditure"

                AccID(19) = "100074"
                AccName(19) = "Service Costing"
                AccountTypeL(19) = "Expenditure"

                AccID(20) = "100075"
                AccName(20) = "Labor GL Sales"
                AccountTypeL(20) = "Income"

                AccID(21) = "100076"
                AccName(21) = "Labor GL Inventory"
                AccountTypeL(21) = "Stock"

                AccID(22) = "100077"
                AccName(22) = "Labor GL Cost"
                AccountTypeL(22) = "Expenditure"

                AccID(23) = "100078"
                AccName(23) = "Labor Costing"
                AccountTypeL(23) = "Expenditure"

                AccID(24) = "100079"
                AccName(24) = "Assembly GL Sales"
                AccountTypeL(24) = "Income"

                AccID(25) = "100080"
                AccName(25) = "Assembly GL Inventory"
                AccountTypeL(25) = "Stock"

                AccID(26) = "100081"
                AccName(26) = "Assembly GL Cost"
                AccountTypeL(26) = "Expenditure"

                AccID(27) = "100082"
                AccName(27) = "Assembly Costing"
                AccountTypeL(27) = "Expenditure"

                AccID(28) = "100083"
                AccName(28) = "Activity GL Sales"
                AccountTypeL(28) = "Income"

                AccID(29) = "100084"
                AccName(29) = "Activity GL Inventory"
                AccountTypeL(29) = "Stock"

                AccID(30) = "100085"
                AccName(30) = "Activity GL Cost"
                AccountTypeL(30) = "Expenditure"

                AccID(31) = "100086"
                AccName(31) = "Activity Costing"
                AccountTypeL(31) = "Expenditure"

                AccID(32) = "100087"
                AccName(32) = "Charge GL Sales"
                AccountTypeL(32) = "Income"

                AccID(33) = "100088"
                AccName(33) = "Charge GL Inventory"
                AccountTypeL(33) = "Stock"

                AccID(34) = "100089"
                AccName(34) = "Charge GL Cost"
                AccountTypeL(34) = "Expenditure"

                AccID(35) = "100090"
                AccName(35) = "Charge Costing"
                AccountTypeL(35) = "Expenditure"

                AccID(36) = "100091"
                AccName(36) = "GL Freight"
                AccountTypeL(36) = "Expenditure"

                AccID(37) = "100092"
                AccName(37) = "Library Fees"
                AccountTypeL(37) = "Income"

                AccID(38) = "100093"
                AccName(38) = "Late Fees"
                AccountTypeL(38) = "Income"

                AccID(39) = "100094"
                AccName(39) = "Exam Fees"
                AccountTypeL(39) = "Income"

                AccID(40) = "100095"
                AccName(40) = "Discount"
                AccountTypeL(40) = "Expenditure"

                AccID(41) = "100096"
                AccName(41) = "Purchase Order"
                AccountTypeL(41) = "Expenditure"

                AccID(42) = "100097"
                AccName(42) = "Sales Invoice"
                AccountTypeL(42) = "Income"

                For i As Integer = 0 To 42
                    cls.AddAccounts(InstitutionID, InstitutionName, FinancialPeriod, AccID(i), AccName(i), AccountTypeL(i))
                Next
            End If
        End If
    End Sub

    Private Sub CreateFinancialYear(ByVal Periodd As String)
        Try
            Dim STR(11) As String
            Dim STR1(11) As String
            Dim STR2(11) As String
            Dim DD(11) As Integer

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

            Dim i As Integer
            Dim j As Integer

            For i = 0 To 11
                j = i + 1
                Dim indx As Integer = 1
                cmd.CommandText = "insert into FinancialYear(InsID,Period,InsName,FiscalNo,Indexx,PeriodValue) values ('" & InstitutionID & "','" & FinancialPeriod & "','" & InstitutionName & "'," & indx & "," & j & ",'" & STR(i) & "')"
                dr = cmd.ExecuteReader
                dr.Close()
            Next
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Timer Events"
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Not AniEasyProgressTaskManager1.IsWorking Then
            AniEasyProgressTaskManager1.Start(ToolStripAnimatedEasyProgressBarItem1.Control)
        End If
        If Not AniEasyProgressTaskManager2.IsWorking Then
            AniEasyProgressTaskManager2.Start(ToolStripAnimatedEasyProgressBarItem1.Control)
        End If
        If c1 = XpProgressBar1.PositionMin Then
            Me.EButton1.Image = Global.Umbrella.My.Resources.directory_create_icon
            Me.EButton1.Text = "Processing Directories && Data Files..."
            Me.status.Text = "Please Wait"
            p1 = 1
        End If
        c1 += p1
        XpProgressBar1.Text = c1.ToString() + " %"
        XpProgressBar1.Position = c1
        If c1 = XpProgressBar1.PositionMax Then
            c1 = p1 = 0
            Me.Timer1.Enabled = False
            Me.status.Text = "Done Processing Directories && Data Files..."
            'CreateDirectories()
            Me.Timer2.Enabled = True
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Not AniEasyProgressTaskManager1.IsWorking Then
            AniEasyProgressTaskManager1.Start(ToolStripAnimatedEasyProgressBarItem1.Control)
        End If
        If Not AniEasyProgressTaskManager2.IsWorking Then
            AniEasyProgressTaskManager2.Start(ToolStripAnimatedEasyProgressBarItem1.Control)
        End If
        If c1 = XpProgressBar1.PositionMin Then
            Me.EButton1.Image = Global.Umbrella.My.Resources.Umbrella_icon
            Me.EButton1.Text = "Processing Institution Details..."
            p1 = 1
        End If
        c1 += p1
        XpProgressBar1.Text = c1.ToString() + " %"
        XpProgressBar1.Position = c1
        If c1 = XpProgressBar1.PositionMax Then
            c1 = p1 = 0
            Me.Timer2.Enabled = False
            CreateInstitute()
            CreateFinancialYear(period)
            Me.status.Text = "Done Processing Institution Details..."
            Me.Timer3.Enabled = True
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Not AniEasyProgressTaskManager1.IsWorking Then
            AniEasyProgressTaskManager1.Start(ToolStripAnimatedEasyProgressBarItem1.Control)
        End If
        If Not AniEasyProgressTaskManager2.IsWorking Then
            AniEasyProgressTaskManager2.Start(ToolStripAnimatedEasyProgressBarItem1.Control)
        End If
        If c1 = XpProgressBar1.PositionMin Then
            Me.EButton1.Image = Global.Umbrella.My.Resources.course_icon
            Me.EButton1.Text = "Processing Course Details..."
            p1 = 1
        End If
        c1 += p1
        XpProgressBar1.Text = c1.ToString() + " %"
        XpProgressBar1.Position = c1
        If c1 = XpProgressBar1.PositionMax Then
            c1 = p1 = 0
            Me.Timer3.Enabled = False
            CreateCourse()
            CreateCourseFees()
            Me.status.Text = "Done Processing Course Details..."
            Me.Timer4.Enabled = True
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If Not AniEasyProgressTaskManager1.IsWorking Then
            AniEasyProgressTaskManager1.Start(ToolStripAnimatedEasyProgressBarItem1.Control)
        End If
        If Not AniEasyProgressTaskManager2.IsWorking Then
            AniEasyProgressTaskManager2.Start(ToolStripAnimatedEasyProgressBarItem1.Control)
        End If
        If c1 = XpProgressBar1.PositionMin Then
            Me.EButton1.Image = Global.Umbrella.My.Resources.facility
            Me.EButton1.Text = "Processing Feature Details..."
            p1 = 1
        End If
        c1 += p1
        XpProgressBar1.Text = c1.ToString() + " %"
        XpProgressBar1.Position = c1
        If c1 = XpProgressBar1.PositionMax Then
            c1 = p1 = 0
            Me.Timer4.Enabled = False
            CreateFeatures()
            Me.status.Text = "Done Processing Feature Details..."
            Me.Timer5.Enabled = True
        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        If Not AniEasyProgressTaskManager1.IsWorking Then
            AniEasyProgressTaskManager1.Start(ToolStripAnimatedEasyProgressBarItem1.Control)
        End If
        If Not AniEasyProgressTaskManager2.IsWorking Then
            AniEasyProgressTaskManager2.Start(ToolStripAnimatedEasyProgressBarItem1.Control)
        End If
        If c1 = XpProgressBar1.PositionMin Then
            Me.EButton1.Image = Global.Umbrella.My.Resources.achievement
            Me.EButton1.Text = "Processing Achivement Details..."
            p1 = 1
        End If
        c1 += p1
        XpProgressBar1.Text = c1.ToString() + " %"
        XpProgressBar1.Position = c1
        If c1 = XpProgressBar1.PositionMax Then
            c1 = p1 = 0
            Me.Timer5.Enabled = False
            CreateAchievements()
            Me.status.Text = "Done Processing Achivement Details..."
            Me.Timer6.Enabled = True
        End If
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        If Not AniEasyProgressTaskManager1.IsWorking Then
            AniEasyProgressTaskManager1.Start(ToolStripAnimatedEasyProgressBarItem1.Control)
        End If
        If Not AniEasyProgressTaskManager2.IsWorking Then
            AniEasyProgressTaskManager2.Start(ToolStripAnimatedEasyProgressBarItem1.Control)
        End If
        If c1 = XpProgressBar1.PositionMin Then
            Me.EButton1.Image = Global.Umbrella.My.Resources.accounting_management_icon
            Me.EButton1.Text = "Processing Account Details..."
            p1 = 1
        End If
        c1 += p1
        XpProgressBar1.Text = c1.ToString() + " %"
        XpProgressBar1.Position = c1
        If c1 = XpProgressBar1.PositionMax Then
            c1 = p1 = 0
            Me.Timer6.Enabled = False
            CreateAccounts()
            Me.status.Text = "Done Processing Account Details..."
            Me.Close()
        End If
    End Sub
#End Region
#Region "Form Events"
    Private Sub frmProcessingInstitute_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RoundedPanel1.SetBounds((Me.Width - RoundedPanel1.Width) / 2, (Me.Height - RoundedPanel1.Height) / 2, 453, 283)
    End Sub

    Private Sub frmProcessingInstitute1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim frm As New frmInstitutionCreated()
        frm.MdiParent = Me.MdiParent
        frm.Show()
    End Sub
#End Region
End Class
#End Region