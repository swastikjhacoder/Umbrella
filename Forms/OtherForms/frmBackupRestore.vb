#Region "Imports..."
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO.Directory
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop.Excel
Imports System.Collections
Imports System.Configuration
Imports System.Data.OleDb
Imports System.Linq
Imports System.IO
Imports System.IO.Compression
#End Region
#Region "Class frmBackupRestore..."
Public Class frmBackupRestore
#Region "Methods..."
    Private Sub ControlSetBound()
        btnbackup.SetBounds(10, 25, 110, 65)
        btnbackuponline.SetBounds(126, 25, 110, 65)
        btnrestore.SetBounds(10, 133, 110, 65)
        btnrestoreonline.SetBounds(126, 133, 110, 65)
    End Sub

    Private Sub LoadDataGridValues()
        Try
            For i As Integer = 0 To 65
                dgviewtables.Rows.Add()
            Next
            dgviewtables.Rows(0).Cells(1).Value = "Institute Record"
            dgviewtables.Rows(1).Cells(1).Value = "Financial Year Values"
            dgviewtables.Rows(2).Cells(1).Value = "Accounting Period Record"
            dgviewtables.Rows(3).Cells(1).Value = "Accounts"
            dgviewtables.Rows(4).Cells(1).Value = "Achievements"
            dgviewtables.Rows(5).Cells(1).Value = "Features"
            dgviewtables.Rows(6).Cells(1).Value = "Index Values"
            dgviewtables.Rows(7).Cells(1).Value = "Institute Defaults Values"
            dgviewtables.Rows(8).Cells(1).Value = "Library Default Values"
            dgviewtables.Rows(9).Cells(1).Value = "Payroll Default Values"
            dgviewtables.Rows(10).Cells(1).Value = "Employee Records"
            dgviewtables.Rows(11).Cells(1).Value = "Hired Employee Records"
            dgviewtables.Rows(12).Cells(1).Value = "Attendance Records"
            dgviewtables.Rows(13).Cells(1).Value = "Submitted Notices"
            dgviewtables.Rows(14).Cells(1).Value = "Submitted ID Cards"
            dgviewtables.Rows(15).Cells(1).Value = "Student Admission Record"
            dgviewtables.Rows(16).Cells(1).Value = "Student Pre-Admission Record"
            dgviewtables.Rows(17).Cells(1).Value = "Student Registration Record"
            dgviewtables.Rows(18).Cells(1).Value = "Collected Monthly Fees Record"
            dgviewtables.Rows(19).Cells(1).Value = "Collected Yearly Fees Record"
            dgviewtables.Rows(20).Cells(1).Value = "Collected Late Fees Record"
            dgviewtables.Rows(21).Cells(1).Value = "Collected Exam Fees Record"
            dgviewtables.Rows(22).Cells(1).Value = "Collected Library Fees Record"
            dgviewtables.Rows(23).Cells(1).Value = "Collected Other Fees Record"
            dgviewtables.Rows(24).Cells(1).Value = "Applied Discount Record"
            dgviewtables.Rows(25).Cells(1).Value = "Applied Discount For Students Record"
            dgviewtables.Rows(26).Cells(1).Value = "Applied Financial Loan Record"
            dgviewtables.Rows(27).Cells(1).Value = "All Incomes & Expenditures"
            dgviewtables.Rows(28).Cells(1).Value = "All Bank Deposits"
            dgviewtables.Rows(29).Cells(1).Value = "Examination Records"
            dgviewtables.Rows(30).Cells(1).Value = "Online Examination Records"
            dgviewtables.Rows(31).Cells(1).Value = "Course Term Fees Records"
            dgviewtables.Rows(32).Cells(1).Value = "All Subjects"
            dgviewtables.Rows(33).Cells(1).Value = "All Syllabuses"
            dgviewtables.Rows(34).Cells(1).Value = "All Assignments"
            dgviewtables.Rows(35).Cells(1).Value = "Submitted Marksheets"
            dgviewtables.Rows(36).Cells(1).Value = "Student Progress Report"
            dgviewtables.Rows(37).Cells(1).Value = "Student Control Panel"
            dgviewtables.Rows(38).Cells(1).Value = "Alumni Ex-Students Record"
            dgviewtables.Rows(39).Cells(1).Value = "Submitted Student Certificates"
            dgviewtables.Rows(40).Cells(1).Value = "Submitted Employee Certificates"
            dgviewtables.Rows(41).Cells(1).Value = "Inventory Record"
            dgviewtables.Rows(42).Cells(1).Value = "Purchase Order Record"
            dgviewtables.Rows(43).Cells(1).Value = "Sales Invoice Record"
            dgviewtables.Rows(44).Cells(1).Value = "Games Record"
            dgviewtables.Rows(45).Cells(1).Value = "Books Record"
            dgviewtables.Rows(46).Cells(1).Value = "Book Groups Record"
            dgviewtables.Rows(47).Cells(1).Value = "Book Subjects Record"
            dgviewtables.Rows(48).Cells(1).Value = "Library Charges Record"
            dgviewtables.Rows(49).Cells(1).Value = "Issue Books Record"
            dgviewtables.Rows(50).Cells(1).Value = "Return Books Record"
            dgviewtables.Rows(51).Cells(1).Value = "Library Charge Calculation Record"
            dgviewtables.Rows(52).Cells(1).Value = "Departments Record"
            dgviewtables.Rows(53).Cells(1).Value = "Employee Designations"
            dgviewtables.Rows(54).Cells(1).Value = "Employee Pay-Sclae Record"
            dgviewtables.Rows(55).Cells(1).Value = "Announce DA/HRA Record"
            dgviewtables.Rows(56).Cells(1).Value = "Professional Tax Record"
            dgviewtables.Rows(57).Cells(1).Value = "Pay-Slip Headers"
            dgviewtables.Rows(58).Cells(1).Value = "Individual Employee PF Rate"
            dgviewtables.Rows(59).Cells(1).Value = "Adjustment/ Deduction Of An Employee For A Specific Month Record"
            dgviewtables.Rows(60).Cells(1).Value = "Working Times Of Hired Employees"
            dgviewtables.Rows(61).Cells(1).Value = "Salary Record"
            dgviewtables.Rows(62).Cells(1).Value = "Pay Employees Record"
            dgviewtables.Rows(63).Cells(1).Value = "Provident Fund Record"
            dgviewtables.Rows(64).Cells(1).Value = "Advance/ Withdrawal From PF Record"
            dgviewtables.Rows(65).Cells(1).Value = "Provident Fund Close Membership Record"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReleaseObject(ByVal o As Object)
        Try
            While (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0)
            End While
        Catch
        Finally
            o = Nothing
        End Try
    End Sub

    Private Sub Zip(ByVal dirpath As String)
        Dim di As DirectoryInfo = New DirectoryInfo(dirpath)
        For Each fi As FileInfo In di.GetFiles()
            Compress(fi)
            fi.Delete()
        Next
    End Sub

    Private Sub UnZip(ByVal dirpath As String)
        Dim di As DirectoryInfo = New DirectoryInfo(dirpath)
        For Each fi As FileInfo In di.GetFiles("*.gz")
            Decompress(fi)
        Next
    End Sub

    Private Sub Compress(ByVal fi As FileInfo)
        Using inFile As FileStream = fi.OpenRead()
            If (File.GetAttributes(fi.FullName) And FileAttributes.Hidden) <> FileAttributes.Hidden And fi.Extension <> ".gz" Then
                Using outFile As FileStream = File.Create(fi.FullName + ".gz")
                    Using Compress As GZipStream = New GZipStream(outFile, CompressionMode.Compress)
                        Dim buffer As Byte() = New Byte(4096) {}
                        Dim numRead As Integer
                        numRead = inFile.Read(buffer, 0, buffer.Length)
                        Do While numRead <> 0
                            Compress.Write(buffer, 0, numRead)
                            numRead = inFile.Read(buffer, 0, buffer.Length)
                        Loop
                        Console.WriteLine("Compressed {0} from {1} to {2} bytes.", fi.Name, fi.Length.ToString(), outFile.Length.ToString())
                    End Using
                End Using
            End If
        End Using
    End Sub

    Private Sub Decompress(ByVal fi As FileInfo)
        Using inFile As FileStream = fi.OpenRead()
            Dim curFile As String = fi.FullName
            Dim origName = curFile.Remove(curFile.Length - fi.Extension.Length)
            Using outFile As FileStream = File.Create(origName)
                Using Decompress As GZipStream = New GZipStream(inFile, CompressionMode.Decompress)
                    Dim buffer As Byte() = New Byte(4096) {}
                    Dim numRead As Integer
                    numRead = Decompress.Read(buffer, 0, buffer.Length)
                    Do While numRead <> 0
                        outFile.Write(buffer, 0, numRead)
                        numRead = Decompress.Read(buffer, 0, buffer.Length)
                    Loop
                    Console.WriteLine("Decompressed: {0}", fi.Name)
                End Using
            End Using
        End Using
    End Sub

    Private Sub RenameFile(ByVal filepath As String)
        Dim sourcePath As String = filepath
        Dim searchPattern As String = "*.umx"
        Dim i As Integer = 0
        For Each fileName As String In Directory.GetFiles(sourcePath, searchPattern, SearchOption.AllDirectories)
            Dim xlName = fileName.Remove(fileName.Length - 4)
            Dim fnPeices() As String = xlName.Split("\")
            xlName = fnPeices(fnPeices.Length - 1)
            File.Move(Path.Combine(sourcePath, fileName), Path.Combine(sourcePath, xlName + ".xls"))
            i += 1
        Next
    End Sub
#Region "Backup..."
#Region "Backup Employee..."
    Private Sub BackupEmployee(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select InsID,InsName,Period,SystemDate,empid,namefirst,namemiddle,namelast,name,houseno,address,city,district,state,pin,country,phone,fax,dob,email,category,department,designation,married,sex,handicapped,presentposition,retirementdate,fulladdress,payinfo,payscale,grade,basic,joiningdate,phd,qualifiedtest,attachedcopy,incremented from Employee"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Employee" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Employee.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupEmployeeLanguage(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from EmployeeLanguage"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\EmployeeLanguage" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "EmployeeLanguage.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupEmployeeAcademic(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from EmployeeAcademic"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\EmployeeAcademic" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "EmployeeAcademic.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupEmployeeTeachingExp(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from EmployeeTeachingExp"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\EmployeeTeachingExp" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "EmployeeTeachingExp.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupEmployeeResearchExp(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from EmployeeResearchExp"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\EmployeeResearchExp" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "EmployeeResearchExp.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupEmployeeProficiency(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from EmployeeProficiency"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\EmployeeProficiency" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "EmployeeProficiency.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupEmployeeProgrammingLang(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from EmployeeProgrammingLang"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\EmployeeProgrammingLang" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "EmployeeProgrammingLang.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupEmployeeActivity(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from EmployeeActivity"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\EmployeeActivity" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "EmployeeActivity.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupEmployeePF(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from PF"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\PF" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "PF.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Hired Employee..."
    Private Sub BackupHiredEmployee(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select InsID,InsName,Period,SystemDate,empid,namefirst,namemiddle,namelast,name,houseno,address,city,district,state,pin,country,phone,fax,dob,email,category,department,designation,married,sex,handicapped,presentposition,retirementdate,fulladdress,payinfo,pay,joiningdate from HiredEmployee"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\HiredEmployee" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "HiredEmployee.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Retired Employee..."
    Private Sub BackupRetiredEmployee(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select InsID,InsName,Period,SystemDate,empid,namefirst,namemiddle,namelast,name,houseno,address,city,district,state,pin,country,phone,fax,dob,email,category,department,designation,married,sex,handicapped,presentposition,retirementdate,fulladdress,payinfo,payscale,grade,basic,joiningdate,phd,qualifiedtest,attachedcopy,incremented from RetiredEmployee"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\RetiredEmployee" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "RetiredEmployee.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupRetiredEmployeeLanguage(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from RetiredEmployeeLanguage"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\RetiredEmployeeLanguage" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "RetiredEmployeeLanguage.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupRetiredEmployeeAcademic(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from RetiredEmployeeAcademic"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\RetiredEmployeeAcademic" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "RetiredEmployeeAcademic.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupRetiredEmployeeTeachingExp(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from RetiredEmployeeTeachingExp"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\RetiredEmployeeTeachingExp" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "RetiredEmployeeTeachingExp.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupRetiredEmployeeResearchExp(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from RetiredEmployeeResearchExp"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\RetiredEmployeeResearchExp" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "RetiredEmployeeResearchExp.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupRetiredEmployeeProficiency(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from RetiredEmployeeProficiency"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\RetiredEmployeeProficiency" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "RetiredEmployeeProficiency.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupRetiredEmployeeProgrammingLang(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from RetiredEmployeeProgrammingLang"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\RetiredEmployeeProgrammingLang" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "RetiredEmployeeProgrammingLang.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupRetiredEmployeeActivity(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from RetiredEmployeeActivity"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\RetiredEmployeeActivity" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "RetiredEmployeeActivity.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupRetiredEmployeePF(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from RetiredPF"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\RetiredPF" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "RetiredPF.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Student Attendance..."
    Private Sub BackupStudentAtendance(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from StudentAttendance"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\StudentAttendance" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "StudentAttendance.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Employee Attendance..."
    Private Sub BackupEmployeeAttendance(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from EmployeeAttendance"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\EmployeeAttendance" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "EmployeeAttendance.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Notices..."
    Private Sub BackupNotices(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Notice"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Notice" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Notice.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup ID Card..."
    Private Sub BackupIDCard(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from IDCard"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\IDCard" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "IDCard.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup User Security..."
    Private Sub BackupUserSecurity(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Users"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Users" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Users.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupUserCrystalReport(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from UserCrystalReport"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\UserCrystalReport" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "UserCrystalReport.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Student Admission..."
    Private Sub BackupStudentAdmission(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select InsID,InsName,Period,SystemDate,serial,year,preadmitted,preadmissionid,course,approved,class,classint,classstring,fname,mname,lname,name ,dob,sex,fgname,mothername,coursefee,annualincome,prehouseno,preaddress,precity,prepost,predist,prestate,prepin,precountry,perhouseno,peraddress,percity,perpost,perdist,perstate,perpin,percountry,profcourse,profcourseduration,profcourseyear,competitiveexam,institute,recognized,instituteaddress,institutephone,institutefax,instituteuniv,payeename,bankname,bankbrach,branchaddress,branchcode,accountno,accounttype,micrcode,electronictransfer,cardholdername,cardaddress,cardcity,cardstate,cardpin,cardcountry,cardtype,payvia,cardno,expmm,expyy,email,homephone,workphone,fax from StudentAdmision"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\StudentAdmision" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "StudentAdmision.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupStudentAdmissionExam(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from StudentAdmisionExam"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\StudentAdmissionExam" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "StudentAdmissionExam.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Student Pre Admission..."
    Private Sub BackupStudentPreAdmission(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select InsID,InsName,Period,SystemDate,serial,year,fname,mname,lname,name ,dob,sex,fgname,mothername,houseno,address,city,post,dist,state,pin,country,email,homephone,workphone,fax,class,classint,classstring,course,testfee,othertestfee,coursefee,annualincome,payeename,bankname,bankbrach,branchaddress,branchcode,accountno,accounttype,micrcode,electronictransfer,cardholdername,cardaddress,cardcity,cardstate,cardpin,cardcountry,cardtype,payvia,cardno,expmm,expyy from StudentPreAdmission"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\StudentPreAdmission" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "StudentPreAdmission.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Student Registration..."
    Private Sub BackupStudentRegistration(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select InsID,InsName,Period,SystemDate,serial,year,preadmitted,preadmissionid,course,approved,class,classint,classstring,fname,mname,lname,name,fgname,mothername,dob,sex,coursefee,annualincome,prehouseno,preaddress,precity,prepost,predist,prestate,prepin,precountry,perhouseno,peraddress,percity,perpost,perdist,perstate,perpin,percountry,profcourse,profcourseduration,profcourseyear,institute,recognized,instituteaddress,institutephone,institutefax,instituteuniv,payeename,bankname,bankbrach,branchaddress,branchcode,accountno,accounttype,micrcode,electronictransfer,cardholdername,cardaddress,cardcity,cardstate,cardpin,cardcountry,cardtype,payvia,cardno,expmm,expyy,email,homephone,workphone,fax,stuid,roll,time,tuition,emergencyname,emergencyhomeph,emergencyworkph,emergencyfax,emergencyrelation,emergencyaddress from StudentRegistration"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\StudentRegistration" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "StudentRegistration.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Terms & Fees..."
    Private Sub BackupCourseTermsFees(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Course"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Course" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Course.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupTermsFees(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from CourseTermFees"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\CourseTermFees" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "CourseTermFees.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Yearly Fees..."
    Private Sub BackupYearlyFees(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from YearlyFees"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\YearlyFees" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "YearlyFees.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Monthly Fees..."
    Private Sub BackupMonthlyFees(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from MonthlyFees"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\MonthlyFees" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "MonthlyFees.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Late Fees..."
    Private Sub BackupLateFees(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from LateFees"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\LateFees" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "LateFees.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Library Fees..."
    Private Sub BackupLibraryFees(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from libraryFees"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\libraryFees" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "libraryFees.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Exam Fees..."
    Private Sub BackupExamFees(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from ExamFee"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\ExamFee" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "ExamFee.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Other Fees..."
    Private Sub BackupOtherFees(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from OtherFees"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\OtherFees" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "OtherFees.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Discount..."
    Private Sub BackupDiscount(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Discount"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Discount" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Discount.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupStudentDiscount(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from StudentDiscount"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\StudentDiscount" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "StudentDiscount.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Financial Loan"
    Private Sub BackupFinancialLoan(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select InsID,InsName,Period,SystemDate,course,class,roll,name,regno,applicantno,fgname,dob,sex,nationality,religion,email,homeph,workph,houseno,address,city,post,district,state,pincode,country,attachmentname,attachmentsize,attachmentpath,attachmentnote from FinancialLoan"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\FinancialLoan" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "FinancialLoan.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Income Expenditure..."
    Private Sub BackupIncomeExpenditure(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from IncomeExpenditure"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\IncomeExpenditure" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "IncomeExpenditure.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Accounting Management..."
    Private Sub BackupAccountingManagement(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Accounts"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Accounts" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Accounts.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupBankDeposit(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from BankDeposit"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\BankDeposit" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "BankDeposit.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Subjects..."
    Private Sub Backupsubject(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Subjects"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Subjects" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Subjects.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Syllabus..."
    Private Sub BackupSyllabus(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Syllabus"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Syllabus" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Syllabus.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Assignments..."
    Private Sub BackupAssignments(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Assignment"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Assignment" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Assignment.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Examination..."
    Private Sub BackupExamination(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Examination"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Examination" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Examination.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupExamStudent(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from ExamStudents"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\ExamStudents" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "ExamStudents.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupExamGuard(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from ExamGuard"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\ExamGuard" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "ExamGuard.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Online Examination..."
    Private Sub BackupOnlineExamQsn(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from OnlineExamQsn"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\OnlineExamQsn" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "OnlineExamQsn.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupOnlineExam(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from OnlineExam"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\OnlineExam" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "OnlineExam.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Progress Report..."
    Private Sub BackupProgressReport(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from ProgressReport"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\ProgressReport" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "ProgressReport.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Marksheet..."
    Private Sub BackupMarksheet(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Marksheet"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Marksheet" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Marksheet.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Alumni..."
    Private Sub BackupAlumni(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select InsID,InsName,Period,SystemDate,serial,alumniyear,year,preadmitted,preadmissionid,course,approved,class,classint,classstring,fname,mname,lname,name,fgname,mothername,dob,sex,coursefee,annualincome,prehouseno,preaddress,precity,prepost,predist,prestate,prepin,precountry,perhouseno,peraddress,percity,perpost,perdist,perstate,perpin,percountry,profcourse,profcourseduration,profcourseyear,institute,recognized,instituteaddress,institutephone,institutefax,instituteuniv,payeename,bankname,bankbrach,branchaddress,branchcode,accountno,accounttype,micrcode,electronictransfer,cardholdername,cardaddress,cardcity,cardstate,cardpin,cardcountry,cardtype,payvia,cardno,expmm,expyy,email,homephone,workphone,fax,stuid,roll,time,tuition,emergencyname,emergencyhomeph,emergencyworkph,emergencyfax,emergencyrelation,emergencyaddress from Alumni"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Alumni" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Alumni.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Student Certificates..."
    Private Sub BackupStudentCertificates(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from StudentCertificate"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\StudentCertificate" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "StudentCertificate.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Employee Certificates..."
    Private Sub BackupEmployeeCertificates(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from EmployeeCertificate"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\EmployeeCertificate" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "EmployeeCertificate.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Inventory..."
    Private Sub BackupInventory(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Inventory"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Inventory" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Inventory.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupInventoryHistory(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from InventoryHistory"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\InventoryHistory" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "InventoryHistory.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupInventoryItemPriceLevel(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from InventoryItemPriceLevel"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\InventoryItemPriceLevel" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "InventoryItemPriceLevel.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Purchase Order..."
    Private Sub BackupPurchaseOrder(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Purchase"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Purchase" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Purchase.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Sales Invoice..."
    Private Sub BackupSalesInvoice(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from SalesInvoice"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\SalesInvoice" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "SalesInvoice.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Games..."
    Private Sub BackupGames(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Game"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Game" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Game.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Books..."
    Private Sub BackupBooks(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Books"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Books" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Books.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Subjects..."
    Private Sub BackupSubjects(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from SubjectBooks"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\BookSubjects" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "BookSubjects.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Groups..."
    Private Sub BackupGroups(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from GroupBooks"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Groups" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Groups.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Library Charges..."
    Private Sub BackupLibraryCharges(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from BookCharges"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Library Charges" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Library Charges.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Issue Books..."
    Private Sub BackupIssue(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Issue"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Issue" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Issue.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BackupIssueBooks(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from IssueBooks"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\IssueBooks" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "IssueBooks.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Return Books..."
    Private Sub BackupReturnBooks(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from ReturnBooks"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Return Books" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Return Books.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Calculated Library Charges..."
    Private Sub BackupCalculatedLibraryCharges(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from LibraryCharges"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Calculated Library Charges" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Calculated Library Charges.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Department..."
    Private Sub BackupDepartments(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Department"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Department" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Department.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Designation..."
    Private Sub BackupDesignations(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Designation"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Designation" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Designation.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Professional Tax..."
    Private Sub BackupProfessionalTax(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from ProfessionalTax"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Professional Tax" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Professional Tax.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup DA/HRA..."
    Private Sub BackupDAHRA(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from DaHra"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\DaHra" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "DaHra.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Pay-Scale..."
    Private Sub BackupPayScale(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from PayScale"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\PayScale" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "PayScale.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Pay Slip Headers..."
    Private Sub BackupPaySlipHeaders(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from PayslipHeaders"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\PayslipHeaders" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "PayslipHeaders.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Adjustment/ Deductions..."
    Private Sub BackupAdjustmentDeductions(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from AdjustmentDeductions"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\AdjustmentDeductions" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "AdjustmentDeductions.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Working Hours/ Day..."
    Private Sub BackupWorkingHoursDay(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from WorkingHourly"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\WorkingHourly" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "WorkingHourly.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub WorkingDaily(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from WorkingDaily"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\WorkingDaily" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "WorkingDaily.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Salary Calculations..."
    Private Sub BackupSalaryCalculations(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Salary"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Salary" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Salary.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Pay Employee..."
    Private Sub BackupPayEmployee(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from PayEmployee"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\PayEmployee" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "PayEmployee.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Advance/ Withdrawal..."
    Private Sub BackupAdvanceWithdrawal(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from PFAdvanceWithdrawal"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\PFAdvanceWithdrawal" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "PFAdvanceWithdrawal.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Individual PF Rate..."
    Private Sub BackupIndividualPFRate(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from PFRateIndividual"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\PFRateIndividual" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "PFRateIndividual.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Membership..."
    Private Sub BackupMembershipRecord(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from CloseMembership"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\CloseMembership" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "CloseMembership.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Institute Index..."
    Private Sub BackupInstituteIndexRecord(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from InstituteIndex"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\InstituteIndex" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "InstituteIndex.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Indexx..."
    Private Sub BackupIndexxRecord(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Indexx"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Indexx" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Indexx.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Institute..."
    Private Sub BackupInstituteRecord(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Institute"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Institute" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Institute.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Financial Year..."
    Private Sub BackupFinancialYearRecord(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from FinancialYear"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\FinancialYear" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "FinancialYear.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Features..."
    Private Sub BackupFeaturesRecord(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Features"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Features" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Features.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Achievements..."
    Private Sub BackupAchievementsRecord(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Achievements"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\Achievements" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "Achievements.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Accounting Period..."
    Private Sub BackupAccountingPeriodRecord(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from AccountingPeriod"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\AccountingPeriod" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "AccountingPeriod.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Default Institute..."
    Private Sub BackupDefaultInstituteRecord(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from DefaultInstitute"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\DefaultInstitute" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "DefaultInstitute.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Default Library..."
    Private Sub BackupDefaultLibraryRecord(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from DefaultLibrary"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\DefaultLibrary" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "DefaultLibrary.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Default Payroll..."
    Private Sub BackupDefaultPayrollRecord(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from DefaultPayroll"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\DefaultPayroll" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "DefaultPayroll.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Student Control..."
    Private Sub BackupStudentControlRecord(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from StudentControl"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\StudentControl" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "StudentControl.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup PF Rate..."
    Private Sub BackupPFRateRecord(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from PFRate"
        dataAdapter.SelectCommand = cmd

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            dataAdapter.Fill(datatableMain)

            For Each dc In datatableMain.Columns
                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            Dim fileName As String = "\PFRate" + ".xls"
            Dim finalPath = path + fileName
            oSheet.Columns.AutoFit()
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            GC.Collect()

            My.Computer.FileSystem.RenameFile(finalPath, "PFRate.umx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Backup Table..."
    Private Sub Backup()
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        If f.ShowDialog() = DialogResult.OK Then
            IO.Directory.CreateDirectory(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupAccountingManagement(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupAdjustmentDeductions(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupAdvanceWithdrawal(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupAlumni(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupAssignments(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupBankDeposit(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupBooks(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupCalculatedLibraryCharges(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupCourseTermsFees(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupDAHRA(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupDepartments(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupDesignations(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupDiscount(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupEmployee(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupEmployeeAcademic(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupEmployeeActivity(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupEmployeeAttendance(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupEmployeeCertificates(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupEmployeeLanguage(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupEmployeePF(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupEmployeeProficiency(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupEmployeeProgrammingLang(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupEmployeeResearchExp(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupEmployeeTeachingExp(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupExamFees(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupExamGuard(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupExamination(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupExamStudent(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupFinancialLoan(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupGames(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupGroups(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupHiredEmployee(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupRetiredEmployee(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupRetiredEmployeeAcademic(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupRetiredEmployeeActivity(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupRetiredEmployeeLanguage(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupRetiredEmployeePF(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupRetiredEmployeeProficiency(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupRetiredEmployeeProgrammingLang(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupRetiredEmployeeResearchExp(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupRetiredEmployeeTeachingExp(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupIDCard(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupIncomeExpenditure(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupIndividualPFRate(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupInventory(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupInventoryHistory(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupInventoryItemPriceLevel(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupIssue(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupIssueBooks(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupLateFees(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupLibraryCharges(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupLibraryFees(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupMarksheet(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupMembershipRecord(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupMonthlyFees(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupNotices(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupOnlineExam(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupOnlineExamQsn(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupOtherFees(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupPayEmployee(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupPayScale(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupPaySlipHeaders(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupProfessionalTax(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupProgressReport(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupPurchaseOrder(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupReturnBooks(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupSalaryCalculations(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupSalesInvoice(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupStudentAdmission(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupStudentAdmissionExam(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupStudentAtendance(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupStudentCertificates(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupStudentDiscount(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupStudentPreAdmission(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupStudentRegistration(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            Backupsubject(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupSubjects(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupSyllabus(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupTermsFees(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupUserCrystalReport(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupUserSecurity(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupWorkingHoursDay(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupYearlyFees(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupInstituteIndexRecord(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupIndexxRecord(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupInstituteRecord(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupFinancialYearRecord(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupFeaturesRecord(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupAchievementsRecord(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupAccountingPeriodRecord(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupDefaultInstituteRecord(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupDefaultLibraryRecord(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupDefaultPayrollRecord(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupStudentControlRecord(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            BackupPFRateRecord(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            Zip(f.SelectedPath + "\" + My.Settings.LastOpenedInstitute)
            MessageBox.Show("Data backed up successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region
#End Region
#Region "Restore..."
#Region "Restore Employee..."
    Private Sub RestoreEmployee(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname1, fname2, fname3, fname4, fname5, fname6, fname7, fname8, fname9 As String
            fname1 = path + "\Employee.xls"
            fname2 = path + "\EmployeeLanguage.xls"
            fname3 = path + "\EmployeeAcademic.xls"
            fname4 = path + "\EmployeeTeachingExp.xls"
            fname5 = path + "\EmployeeResearchExp.xls"
            fname6 = path + "\EmployeeProficiency.xls"
            fname7 = path + "\EmployeeProgrammingLang.xls"
            fname8 = path + "\EmployeeActivity.xls"
            fname9 = path + "\PF.xls"
            RestoreEmployee(fname1)
            RestoreEmployeeLanguage(fname2)
            RestoreEmployeeAcademic(fname3)
            RestoreEmployeeTeachingExp(fname4)
            RestoreEmployeeResearchExp(fname5)
            RestoreEmployeeProficiency(fname6)
            RestoreEmployeeProgrammingLang(fname7)
            RestoreEmployeeActivity(fname8)
            RestoreEmployeePF(fname9)
            My.Computer.FileSystem.DeleteFile(fname1)
            My.Computer.FileSystem.DeleteFile(fname2)
            My.Computer.FileSystem.DeleteFile(fname3)
            My.Computer.FileSystem.DeleteFile(fname4)
            My.Computer.FileSystem.DeleteFile(fname5)
            My.Computer.FileSystem.DeleteFile(fname6)
            My.Computer.FileSystem.DeleteFile(fname7)
            My.Computer.FileSystem.DeleteFile(fname8)
            My.Computer.FileSystem.DeleteFile(fname9)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreEmployee(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteEmployee()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportEmployee(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), dtExcel.Rows(i)(21).ToString(), dtExcel.Rows(i)(22).ToString(), dtExcel.Rows(i)(23).ToString(), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString(), dtExcel.Rows(i)(26).ToString(), dtExcel.Rows(i)(27).ToString(), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString(), dtExcel.Rows(i)(30).ToString(), CDec(dtExcel.Rows(i)(31).ToString()), CDec(dtExcel.Rows(i)(32).ToString()), dtExcel.Rows(i)(33).ToString(), dtExcel.Rows(i)(34).ToString(), dtExcel.Rows(i)(35).ToString(), dtExcel.Rows(i)(36).ToString(), dtExcel.Rows(i)(37).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreEmployeeLanguage(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteEmployeeLanguage()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportEmployeeLanguage(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreEmployeeAcademic(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteEmployeeAcademic()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportEmployeeAcademic(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CInt(dtExcel.Rows(i)(6).ToString()), dtExcel.Rows(i)(7).ToString(), CDec(dtExcel.Rows(i)(8).ToString()), dtExcel.Rows(i)(9).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreEmployeeTeachingExp(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteEmployeeTeachingExp()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportEmployeeTeachingExp(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), CInt(dtExcel.Rows(i)(5).ToString()), CInt(dtExcel.Rows(i)(6).ToString()), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), CInt(dtExcel.Rows(i)(9).ToString()), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreEmployeeResearchExp(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteEmployeeReaserchExp()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportEmployeeReaserchExp(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), CInt(dtExcel.Rows(i)(5).ToString()), CInt(dtExcel.Rows(i)(6).ToString()), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreEmployeeProficiency(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteEmployeeProficiency()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportEmployeeProficiency(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreEmployeeProgrammingLang(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteEmployeeProgrammingLang()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportEmployeeProgrammingLang(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreEmployeeActivity(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteEmployeeActivity()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportEmployeeActivity(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreEmployeePF(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteEmployeePF()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportEmployeePF(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), CDec(dtExcel.Rows(i)(7).ToString()), CDec(dtExcel.Rows(i)(8).ToString()))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Hired Employee..."
    Private Sub RestoreHiredEmployee(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\HiredEmployee.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteHiredEmployee()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportHiredEmployee(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), dtExcel.Rows(i)(21).ToString(), dtExcel.Rows(i)(22).ToString(), dtExcel.Rows(i)(23).ToString(), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString(), dtExcel.Rows(i)(26).ToString(), dtExcel.Rows(i)(27).ToString(), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString(), CDec(dtExcel.Rows(i)(30).ToString()), dtExcel.Rows(i)(31).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Retired Employee..."
    Private Sub RestoreRetiredEmployee(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname1, fname2, fname3, fname4, fname5, fname6, fname7, fname8, fname9 As String
            fname1 = path + "\RetiredEmployee.xls"
            fname2 = path + "\RetiredEmployeeLanguage.xls"
            fname3 = path + "\RetiredEmployeeAcademic.xls"
            fname4 = path + "\RetiredEmployeeTeachingExp.xls"
            fname5 = path + "\RetiredEmployeeResearchExp.xls"
            fname6 = path + "\RetiredEmployeeProficiency.xls"
            fname7 = path + "\RetiredEmployeeProgrammingLang.xls"
            fname8 = path + "\RetiredEmployeeActivity.xls"
            fname9 = path + "\RetiredPF.xls"
            RestoreRetiredEmployee(fname1)
            RestoreRetiredEmployeeLanguage(fname2)
            RestoreRetiredEmployeeAcademic(fname3)
            RestoreRetiredEmployeeTeachingExp(fname4)
            RestoreRetiredEmployeeResearchExp(fname5)
            RestoreRetiredEmployeeProficiency(fname6)
            RestoreRetiredEmployeeProgrammingLang(fname7)
            RestoreRetiredEmployeeActivity(fname8)
            RestoreRetiredEmployeePF(fname9)
            My.Computer.FileSystem.DeleteFile(fname1)
            My.Computer.FileSystem.DeleteFile(fname2)
            My.Computer.FileSystem.DeleteFile(fname3)
            My.Computer.FileSystem.DeleteFile(fname4)
            My.Computer.FileSystem.DeleteFile(fname5)
            My.Computer.FileSystem.DeleteFile(fname6)
            My.Computer.FileSystem.DeleteFile(fname7)
            My.Computer.FileSystem.DeleteFile(fname8)
            My.Computer.FileSystem.DeleteFile(fname9)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreRetiredEmployee(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteRetiredEmployee()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportRetiredEmployee(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), dtExcel.Rows(i)(21).ToString(), dtExcel.Rows(i)(22).ToString(), dtExcel.Rows(i)(23).ToString(), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString(), dtExcel.Rows(i)(26).ToString(), dtExcel.Rows(i)(27).ToString(), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString(), dtExcel.Rows(i)(30).ToString(), CDec(dtExcel.Rows(i)(31).ToString()), CDec(dtExcel.Rows(i)(32).ToString()), dtExcel.Rows(i)(33).ToString(), dtExcel.Rows(i)(34).ToString(), dtExcel.Rows(i)(35).ToString(), dtExcel.Rows(i)(36).ToString(), dtExcel.Rows(i)(37).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreRetiredEmployeeLanguage(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteRetiredEmployeeLanguage()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportRetiredEmployeeLanguage(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreRetiredEmployeeAcademic(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteRetiredEmployeeAcademic()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportRetiredEmployeeAcademic(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CInt(dtExcel.Rows(i)(6).ToString()), dtExcel.Rows(i)(7).ToString(), CDec(dtExcel.Rows(i)(8).ToString()), dtExcel.Rows(i)(9).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreRetiredEmployeeTeachingExp(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteRetiredEmployeeTeachingExp()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportRetiredEmployeeTeachingExp(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), CInt(dtExcel.Rows(i)(5).ToString()), CInt(dtExcel.Rows(i)(6).ToString()), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), CInt(dtExcel.Rows(i)(9).ToString()), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreRetiredEmployeeResearchExp(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteRetiredEmployeeReaserchExp()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportRetiredEmployeeReaserchExp(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), CInt(dtExcel.Rows(i)(5).ToString()), CInt(dtExcel.Rows(i)(6).ToString()), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreRetiredEmployeeProficiency(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteRetiredEmployeeProficiency()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportRetiredEmployeeProficiency(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreRetiredEmployeeProgrammingLang(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteRetiredEmployeeProgrammingLang()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportRetiredEmployeeProgrammingLang(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreRetiredEmployeeActivity(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteRetiredEmployeeActivity()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportRetiredEmployeeActivity(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreRetiredEmployeePF(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteRetiredEmployeePF()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportRetiredEmployeePF(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), CDec(dtExcel.Rows(i)(7).ToString()), CDec(dtExcel.Rows(i)(8).ToString()))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Student Attendance..."
    Private Sub RestoreStudentAttendance(ByVal indx As Integer, ByVal path As String)
        Try 
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\StudentAttendance.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteStudentAttendance()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportStudentAttendance(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Employee Attendance..."
    Private Sub RestoreEmployeeAttendance(ByVal indx As Integer, ByVal path As String)
        Try 
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\EmployeeAttendance.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteEmployeeAttendance()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportEmployeeAttendance(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Notices..."
    Private Sub RestoreNotices(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\Notice.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteNotice()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportNotice(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore ID Card..."
    Private Sub RestoreIDCard(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\IDCard.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteIDCard()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportIDCard(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore User Security..."
    Private Sub RestoreUsers(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname1, fname2 As String
            fname1 = path + "\Users.xls"
            fname2 = path + "\UserCrystalReport.xls"
            RestoreUsers(fname1)
            RestoreUserCrystalReport(fname2)
            My.Computer.FileSystem.DeleteFile(fname1)
            My.Computer.FileSystem.DeleteFile(fname2)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreUsers(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteUsers()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportUsers(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), dtExcel.Rows(i)(21).ToString(), dtExcel.Rows(i)(22).ToString(), dtExcel.Rows(i)(23).ToString(), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString(), dtExcel.Rows(i)(26).ToString(), dtExcel.Rows(i)(27).ToString(), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString(), dtExcel.Rows(i)(30).ToString(), dtExcel.Rows(i)(31).ToString(), dtExcel.Rows(i)(32).ToString(), dtExcel.Rows(i)(33).ToString(), dtExcel.Rows(i)(34).ToString(), dtExcel.Rows(i)(35).ToString(), dtExcel.Rows(i)(36).ToString(), dtExcel.Rows(i)(37).ToString(), dtExcel.Rows(i)(38).ToString(), dtExcel.Rows(i)(39).ToString(), dtExcel.Rows(i)(40).ToString(), dtExcel.Rows(i)(41).ToString(), dtExcel.Rows(i)(42).ToString(), dtExcel.Rows(i)(43).ToString(), dtExcel.Rows(i)(44).ToString(), dtExcel.Rows(i)(45).ToString(), dtExcel.Rows(i)(46).ToString(), dtExcel.Rows(i)(47).ToString(), dtExcel.Rows(i)(48).ToString(), dtExcel.Rows(i)(49).ToString(), dtExcel.Rows(i)(50).ToString(), dtExcel.Rows(i)(51).ToString(), dtExcel.Rows(i)(52).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreUserCrystalReport(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteUserCrystalReport()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportUserCrystalReport(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Student Admission..."
    Private Sub RestoreStudentAdmission(ByVal indx As Integer, ByVal path As String)
        Try 
            UnZip(path)
            RenameFile(path)
            Dim fname1, fname2 As String
            fname1 = path + "\StudentAdmision.xls"
            fname2 = path + "\StudentAdmissionExam.xls"
            RestoreStudentAdmission(fname1)
            RestoreStudentAdmissionExam(fname2)
            My.Computer.FileSystem.DeleteFile(fname1)
            My.Computer.FileSystem.DeleteFile(fname2)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreStudentAdmission(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteStudentAdmision()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportStudentAdmision(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), CInt(dtExcel.Rows(i)(5).ToString()), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), CInt(dtExcel.Rows(i)(11).ToString()), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), CDec(dtExcel.Rows(i)(21).ToString()), CDec(dtExcel.Rows(i)(22).ToString()), dtExcel.Rows(i)(23).ToString(), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString(), dtExcel.Rows(i)(26).ToString(), dtExcel.Rows(i)(27).ToString(), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString(), dtExcel.Rows(i)(30).ToString(), dtExcel.Rows(i)(31).ToString(), dtExcel.Rows(i)(32).ToString(), dtExcel.Rows(i)(33).ToString(), dtExcel.Rows(i)(34).ToString(), dtExcel.Rows(i)(35).ToString(), dtExcel.Rows(i)(36).ToString(), dtExcel.Rows(i)(37).ToString(), dtExcel.Rows(i)(38).ToString(), dtExcel.Rows(i)(39).ToString(), dtExcel.Rows(i)(40).ToString(), CInt(dtExcel.Rows(i)(41).ToString()), dtExcel.Rows(i)(42).ToString(), dtExcel.Rows(i)(43).ToString(), dtExcel.Rows(i)(44).ToString(), dtExcel.Rows(i)(45).ToString(), dtExcel.Rows(i)(46).ToString(), dtExcel.Rows(i)(47).ToString(), dtExcel.Rows(i)(48).ToString(), dtExcel.Rows(i)(49).ToString(), dtExcel.Rows(i)(50).ToString(), dtExcel.Rows(i)(51).ToString(), dtExcel.Rows(i)(52).ToString(), dtExcel.Rows(i)(53).ToString(), dtExcel.Rows(i)(54).ToString(), dtExcel.Rows(i)(55).ToString(), dtExcel.Rows(i)(56).ToString(), dtExcel.Rows(i)(57).ToString(), dtExcel.Rows(i)(58).ToString(), dtExcel.Rows(i)(59).ToString(), dtExcel.Rows(i)(60).ToString(), dtExcel.Rows(i)(61).ToString(), dtExcel.Rows(i)(62).ToString(), dtExcel.Rows(i)(63).ToString(), dtExcel.Rows(i)(64).ToString(), dtExcel.Rows(i)(65).ToString(), dtExcel.Rows(i)(66).ToString(), CInt(dtExcel.Rows(i)(67).ToString()), CInt(dtExcel.Rows(i)(68).ToString()), dtExcel.Rows(i)(69).ToString(), dtExcel.Rows(i)(70).ToString(), dtExcel.Rows(i)(71).ToString(), dtExcel.Rows(i)(72).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreStudentAdmissionExam(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteStudentAdmisionExam()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportStudentAdmisionExam(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), CInt(dtExcel.Rows(i)(12).ToString()), CDec(dtExcel.Rows(i)(13).ToString()), dtExcel.Rows(i)(14).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Student Pre-Admission..."
    Private Sub RestoreStudentPreAdmission(ByVal indx As Integer, ByVal path As String)
        Try 
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\StudentPreAdmission.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteStudentPreAdmision()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportStudentPreAdmission(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), CInt(dtExcel.Rows(i)(5).ToString()), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), dtExcel.Rows(i)(21).ToString(), dtExcel.Rows(i)(22).ToString(), dtExcel.Rows(i)(23).ToString(), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString(), dtExcel.Rows(i)(26).ToString(), CInt(dtExcel.Rows(i)(27).ToString()), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString(), CDec(dtExcel.Rows(i)(30).ToString()), CDec(dtExcel.Rows(i)(31).ToString()), CDec(dtExcel.Rows(i)(32).ToString()), CDec(dtExcel.Rows(i)(33).ToString()), dtExcel.Rows(i)(34).ToString(), dtExcel.Rows(i)(35).ToString(), dtExcel.Rows(i)(36).ToString(), dtExcel.Rows(i)(37).ToString(), dtExcel.Rows(i)(38).ToString(), dtExcel.Rows(i)(39).ToString(), dtExcel.Rows(i)(40).ToString(), dtExcel.Rows(i)(41).ToString(), dtExcel.Rows(i)(42).ToString(), dtExcel.Rows(i)(43).ToString(), dtExcel.Rows(i)(44).ToString(), dtExcel.Rows(i)(45).ToString(), dtExcel.Rows(i)(46).ToString(), dtExcel.Rows(i)(47).ToString(), dtExcel.Rows(i)(48).ToString(), dtExcel.Rows(i)(49).ToString(), dtExcel.Rows(i)(50).ToString(), dtExcel.Rows(i)(51).ToString(), CInt(dtExcel.Rows(i)(52).ToString()), CInt(dtExcel.Rows(i)(53).ToString()))
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Student Registration..."
    Private Sub RestoreStudentRegistration(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\StudentRegistration.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteStudentRegistration()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportStudentRegistration(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), CInt(dtExcel.Rows(i)(5).ToString()), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), CInt(dtExcel.Rows(i)(11).ToString()), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), CDec(dtExcel.Rows(i)(21).ToString()), CDec(dtExcel.Rows(i)(22).ToString()), dtExcel.Rows(i)(23).ToString(), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString(), dtExcel.Rows(i)(26).ToString(), dtExcel.Rows(i)(27).ToString(), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString(), dtExcel.Rows(i)(30).ToString(), dtExcel.Rows(i)(31).ToString(), dtExcel.Rows(i)(32).ToString(), dtExcel.Rows(i)(33).ToString(), dtExcel.Rows(i)(34).ToString(), dtExcel.Rows(i)(35).ToString(), dtExcel.Rows(i)(36).ToString(), dtExcel.Rows(i)(37).ToString(), dtExcel.Rows(i)(38).ToString(), dtExcel.Rows(i)(39).ToString(), dtExcel.Rows(i)(40).ToString(), CInt(dtExcel.Rows(i)(41).ToString()), dtExcel.Rows(i)(42).ToString(), dtExcel.Rows(i)(43).ToString(), dtExcel.Rows(i)(44).ToString(), dtExcel.Rows(i)(45).ToString(), dtExcel.Rows(i)(46).ToString(), dtExcel.Rows(i)(47).ToString(), dtExcel.Rows(i)(48).ToString(), dtExcel.Rows(i)(49).ToString(), dtExcel.Rows(i)(50).ToString(), dtExcel.Rows(i)(51).ToString(), dtExcel.Rows(i)(52).ToString(), dtExcel.Rows(i)(53).ToString(), dtExcel.Rows(i)(54).ToString(), dtExcel.Rows(i)(55).ToString(), dtExcel.Rows(i)(56).ToString(), dtExcel.Rows(i)(57).ToString(), dtExcel.Rows(i)(58).ToString(), dtExcel.Rows(i)(59).ToString(), dtExcel.Rows(i)(60).ToString(), dtExcel.Rows(i)(61).ToString(), dtExcel.Rows(i)(62).ToString(), dtExcel.Rows(i)(63).ToString(), dtExcel.Rows(i)(64).ToString(), dtExcel.Rows(i)(65).ToString(), CInt(dtExcel.Rows(i)(66).ToString()), CInt(dtExcel.Rows(i)(67).ToString()), dtExcel.Rows(i)(68).ToString(), dtExcel.Rows(i)(69).ToString(), dtExcel.Rows(i)(70).ToString(), dtExcel.Rows(i)(71).ToString(), dtExcel.Rows(i)(72).ToString(), dtExcel.Rows(i)(73).ToString(), dtExcel.Rows(i)(74).ToString(), dtExcel.Rows(i)(75).ToString(), dtExcel.Rows(i)(76).ToString(), dtExcel.Rows(i)(77).ToString(), dtExcel.Rows(i)(78).ToString(), dtExcel.Rows(i)(79).ToString(), dtExcel.Rows(i)(80).ToString(), dtExcel.Rows(i)(81).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Terms & Fees..."
    Private Sub RestoreCourseTermsFees(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname1, fname2 As String
            fname1 = path + "\Course.xls"
            fname2 = path + "\CourseTermFees.xls"
            RestoreCourseTermsFees(fname1)
            RestoreTermsFees(fname2)
            My.Computer.FileSystem.DeleteFile(fname1)
            My.Computer.FileSystem.DeleteFile(fname2)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreCourseTermsFees(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteCourse()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportCourse(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), CDec(dtExcel.Rows(i)(7).ToString()))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreTermsFees(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteTermsFees()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportTermsFees(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CDec(dtExcel.Rows(i)(6).ToString()), CInt(dtExcel.Rows(i)(7).ToString()))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Yearly Fees..."
    Private Sub RestoreYearlyFees(ByVal indx As Integer, ByVal path As String)
        Try 
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\YearlyFees.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteYearlyFees()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportYearlyFees(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), CInt(dtExcel.Rows(i)(7).ToString()), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), CDec(dtExcel.Rows(i)(15).ToString()), CDec(dtExcel.Rows(i)(16).ToString()), CDec(dtExcel.Rows(i)(17).ToString()), CDec(dtExcel.Rows(i)(18).ToString()), CDec(dtExcel.Rows(i)(19).ToString()), CDec(dtExcel.Rows(i)(20).ToString()), CDec(dtExcel.Rows(i)(21).ToString()), CDec(dtExcel.Rows(i)(22).ToString()), CDec(dtExcel.Rows(i)(23).ToString()), dtExcel.Rows(i)(24).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Monthly Fees..."
    Private Sub RestoreMonthlyFees(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\MonthlyFees.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteMonthlyFees()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportMonthlyFees(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CInt(dtExcel.Rows(i)(6).ToString()), CInt(dtExcel.Rows(i)(7).ToString()), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), CDec(dtExcel.Rows(i)(14).ToString()), CDec(dtExcel.Rows(i)(15).ToString()), CDec(dtExcel.Rows(i)(16).ToString()), CDec(dtExcel.Rows(i)(17).ToString()), CDec(dtExcel.Rows(i)(18).ToString()), CDec(dtExcel.Rows(i)(19).ToString()), CDec(dtExcel.Rows(i)(20).ToString()), CDec(dtExcel.Rows(i)(21).ToString()), dtExcel.Rows(i)(22).ToString(), CDec(dtExcel.Rows(i)(23).ToString()), dtExcel.Rows(i)(24).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Late Fees..."
    Private Sub RestoreLateFees(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\LateFees.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteLateFees()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportLateFees(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CInt(dtExcel.Rows(i)(6).ToString()), CInt(dtExcel.Rows(i)(7).ToString()), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), CDec(dtExcel.Rows(i)(16).ToString()), CDec(dtExcel.Rows(i)(17).ToString()), CDec(dtExcel.Rows(i)(18).ToString()), CDec(dtExcel.Rows(i)(19).ToString()), CDec(dtExcel.Rows(i)(20).ToString()), CDec(dtExcel.Rows(i)(21).ToString()), dtExcel.Rows(i)(22).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Library Fees..."
    Private Sub RestoreLibraryFees(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\libraryFees.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteLibraryFees()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportLibraryFees(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CInt(dtExcel.Rows(i)(6).ToString()), CInt(dtExcel.Rows(i)(7).ToString()), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), CDec(dtExcel.Rows(i)(15).ToString()), CDec(dtExcel.Rows(i)(16).ToString()), CDec(dtExcel.Rows(i)(17).ToString()), CDec(dtExcel.Rows(i)(18).ToString()), CDec(dtExcel.Rows(i)(19).ToString()), CDec(dtExcel.Rows(i)(20).ToString()), CDec(dtExcel.Rows(i)(21).ToString()), dtExcel.Rows(i)(22).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Exam Fees..."
    Private Sub RestoreExamFees(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\ExamFee.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteExamFees()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportExamFees(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CInt(dtExcel.Rows(i)(6).ToString()), CInt(dtExcel.Rows(i)(7).ToString()), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), CDec(dtExcel.Rows(i)(16).ToString()), CDec(dtExcel.Rows(i)(17).ToString()), CDec(dtExcel.Rows(i)(18).ToString()), CDec(dtExcel.Rows(i)(19).ToString()), CDec(dtExcel.Rows(i)(20).ToString()), CDec(dtExcel.Rows(i)(21).ToString()), CDec(dtExcel.Rows(i)(22).ToString()), CDec(dtExcel.Rows(i)(23).ToString()), dtExcel.Rows(i)(24).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Other Fees..."
    Private Sub RestoreOtherFees(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\OtherFees.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteOtherFees()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportOtherFees(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CInt(dtExcel.Rows(i)(6).ToString()), CInt(dtExcel.Rows(i)(7).ToString()), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), CDec(dtExcel.Rows(i)(16).ToString()), CDec(dtExcel.Rows(i)(17).ToString()), CDec(dtExcel.Rows(i)(18).ToString()), CDec(dtExcel.Rows(i)(19).ToString()), CDec(dtExcel.Rows(i)(20).ToString()), CDec(dtExcel.Rows(i)(21).ToString()), dtExcel.Rows(i)(22).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Discount..."
    Private Sub RestoreDiscount(ByVal indx As Integer, ByVal path As String)
        Try 
            UnZip(path)
            RenameFile(path)
            Dim fname1, fname2 As String
            fname1 = path + "\Discount.xls"
            fname2 = path + "\StudentDiscount.xls"
            RestoreDiscount(fname1)
            RestoreStudentDiscount(fname2)
            My.Computer.FileSystem.DeleteFile(fname1)
            My.Computer.FileSystem.DeleteFile(fname2)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreDiscount(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteDiscount()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportDiscount(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CInt(dtExcel.Rows(i)(6).ToString()), CInt(dtExcel.Rows(i)(7).ToString()), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), CDec(dtExcel.Rows(i)(13).ToString()), CDec(dtExcel.Rows(i)(14).ToString()), CDec(dtExcel.Rows(i)(15).ToString()), CDec(dtExcel.Rows(i)(16).ToString()), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreStudentDiscount(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteDiscountStudent()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportDiscountStudent(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), CDec(dtExcel.Rows(i)(10).ToString()))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Financial Loan..."
    Private Sub RestoreFinancialLoan(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\FinancialLoan.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteFinancialLoan()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportFinancialLoan(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), dtExcel.Rows(i)(21).ToString(), dtExcel.Rows(i)(22).ToString(), dtExcel.Rows(i)(23).ToString(), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString(), dtExcel.Rows(i)(26).ToString(), dtExcel.Rows(i)(27).ToString(), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Income Expenditure..."
    Private Sub RestoreIncomeExpenditure(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\IncomeExpenditure.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteIncomeExpenditure()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportIncomeExpenditure(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), CDec(dtExcel.Rows(i)(7).ToString()), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), CInt(dtExcel.Rows(i)(12).ToString()), CInt(dtExcel.Rows(i)(13).ToString()), dtExcel.Rows(i)(14).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Accounting Management..."
    Private Sub RestoreAccountingManagement(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname1, fname2 As String
            fname1 = path + "\Accounts.xls"
            fname2 = path + "\BankDeposit.xls"
            RestoreAccountingManagement(fname1)
            RestoreBankDeposit(fname2)
            My.Computer.FileSystem.DeleteFile(fname1)
            My.Computer.FileSystem.DeleteFile(fname2)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreAccountingManagement(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteAccounts()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportAccounts(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CDec(dtExcel.Rows(i)(6).ToString()))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreBankDeposit(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteBankDeposit()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportBankDeposit(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CDec(dtExcel.Rows(i)(6).ToString()), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Subjects..."
    Private Sub RestoreSubjects(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\Subjects.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteSubject()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportSubject(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), CInt(dtExcel.Rows(i)(9).ToString()), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), CInt(dtExcel.Rows(i)(14).ToString()), dtExcel.Rows(i)(15).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Syllabus..."
    Private Sub RestoreSyllabus(ByVal indx As Integer, ByVal path As String)
        Try 
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\Syllabus.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteSyllabus()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportSyllabus(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), CInt(dtExcel.Rows(i)(11).ToString()), CInt(dtExcel.Rows(i)(12).ToString()), CInt(dtExcel.Rows(i)(13).ToString()), CInt(dtExcel.Rows(i)(14).ToString()))
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Assignments..."
    Private Sub RestoreAssignments(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\Assignment.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteAssignment()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportAssignment(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Examination..."
    Private Sub RestoreExamination(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname1, fname2, fname3 As String
            fname1 = path + "\Examination.xls"
            fname2 = path + "\ExamStudents.xls"
            fname3 = path + "\ExamGuard.xls"
            RestoreExamination(fname1)
            RestoreExaminationStudent(fname2)
            RestoreExaminationGuard(fname3)
            My.Computer.FileSystem.DeleteFile(fname1)
            My.Computer.FileSystem.DeleteFile(fname2)
            My.Computer.FileSystem.DeleteFile(fname3)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreExamination(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteExamination()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportExamination(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreExaminationStudent(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteExaminationStudent()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportExaminationStudent(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreExaminationGuard(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteExaminationGuard()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportExaminationGuard(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Online Examination..."
    Private Sub RestoreOnlineExamQsn(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname1, fname2 As String
            fname1 = path + "\OnlineExamQsn.xls"
            fname2 = path + "\OnlineExam.xls"
            RestoreDiscount(fname1)
            RestoreStudentDiscount(fname2)
            My.Computer.FileSystem.DeleteFile(fname1)
            My.Computer.FileSystem.DeleteFile(fname2)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreOnlineExamQsn(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteOnlineExaminationQsn()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportOnlineExaminationQsn(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), CInt(dtExcel.Rows(i)(7).ToString()), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreOnlineExam(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteOnlineExamination()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportOnlineExamination(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), CInt(dtExcel.Rows(i)(7).ToString()), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), CInt(dtExcel.Rows(i)(13).ToString()), CInt(dtExcel.Rows(i)(14).ToString()), CInt(dtExcel.Rows(i)(15).ToString()))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Progress Report..."
    Private Sub RestoreProgressReport(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\ProgressReport.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteProgressReport()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportProgressReport(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Marksheets..."
    Private Sub RestoreMarksheets(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\Marksheet.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteMarksheet()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportMarksheet(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), CDec(dtExcel.Rows(i)(14).ToString()), CDec(dtExcel.Rows(i)(15).ToString()))
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Alumni..."
    Private Sub RestoreAlumni(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\Alumni.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteAlumni()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportAlumni(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), CInt(dtExcel.Rows(i)(5).ToString()), CInt(dtExcel.Rows(i)(6).ToString()), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), CInt(dtExcel.Rows(i)(12).ToString()), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), dtExcel.Rows(i)(21).ToString(), CDec(dtExcel.Rows(i)(22).ToString()), CDec(dtExcel.Rows(i)(23).ToString()), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString(), dtExcel.Rows(i)(26).ToString(), dtExcel.Rows(i)(27).ToString(), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString(), dtExcel.Rows(i)(30).ToString(), dtExcel.Rows(i)(31).ToString(), dtExcel.Rows(i)(32).ToString(), dtExcel.Rows(i)(33).ToString(), dtExcel.Rows(i)(34).ToString(), dtExcel.Rows(i)(35).ToString(), dtExcel.Rows(i)(36).ToString(), dtExcel.Rows(i)(37).ToString(), dtExcel.Rows(i)(38).ToString(), dtExcel.Rows(i)(39).ToString(), dtExcel.Rows(i)(40).ToString(), dtExcel.Rows(i)(41).ToString(), CInt(dtExcel.Rows(i)(42).ToString()), dtExcel.Rows(i)(43).ToString(), dtExcel.Rows(i)(44).ToString(), dtExcel.Rows(i)(45).ToString(), dtExcel.Rows(i)(46).ToString(), dtExcel.Rows(i)(47).ToString(), dtExcel.Rows(i)(48).ToString(), dtExcel.Rows(i)(49).ToString(), dtExcel.Rows(i)(50).ToString(), dtExcel.Rows(i)(51).ToString(), dtExcel.Rows(i)(52).ToString(), dtExcel.Rows(i)(53).ToString(), dtExcel.Rows(i)(54).ToString(), dtExcel.Rows(i)(55).ToString(), dtExcel.Rows(i)(56).ToString(), dtExcel.Rows(i)(57).ToString(), dtExcel.Rows(i)(58).ToString(), dtExcel.Rows(i)(59).ToString(), dtExcel.Rows(i)(60).ToString(), dtExcel.Rows(i)(61).ToString(), dtExcel.Rows(i)(62).ToString(), dtExcel.Rows(i)(63).ToString(), dtExcel.Rows(i)(64).ToString(), dtExcel.Rows(i)(65).ToString(), dtExcel.Rows(i)(66).ToString(), CInt(dtExcel.Rows(i)(67).ToString()), CInt(dtExcel.Rows(i)(68).ToString()), dtExcel.Rows(i)(69).ToString(), dtExcel.Rows(i)(70).ToString(), dtExcel.Rows(i)(71).ToString(), dtExcel.Rows(i)(72).ToString(), dtExcel.Rows(i)(73).ToString(), dtExcel.Rows(i)(74).ToString(), dtExcel.Rows(i)(75).ToString(), dtExcel.Rows(i)(76).ToString(), dtExcel.Rows(i)(77).ToString(), dtExcel.Rows(i)(78).ToString(), dtExcel.Rows(i)(79).ToString(), dtExcel.Rows(i)(80).ToString(), dtExcel.Rows(i)(81).ToString(), dtExcel.Rows(i)(82).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Student Certificates..."
    Private Sub RestoreStudentCertificates(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\StudentCertificate.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteStudentCertificate()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportStudentCertificate(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Employee Certificates..."
    Private Sub RestoreEmployeeCertificates(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\EmployeeCertificate.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteEmployeeCertificate()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportEmployeeCertificate(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Inventory..."
    Private Sub RestoreInventory(ByVal indx As Integer, ByVal path As String)
        Try 
            UnZip(path)
            RenameFile(path)
            Dim fname1, fname2, fname3 As String
            fname1 = path + "\Inventory.xls"
            fname2 = path + "\InventoryHistory.xls"
            fname3 = path + "\InventoryItemPriceLevel.xls"
            RestoreInventory(fname1)
            RestoreInventoryHistory(fname2)
            RestoreInventoryItemPriceLevel(fname3)
            My.Computer.FileSystem.DeleteFile(fname1)
            My.Computer.FileSystem.DeleteFile(fname2)
            My.Computer.FileSystem.DeleteFile(fname3)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreInventory(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteInventory()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportInventory(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), CDec(dtExcel.Rows(i)(13).ToString()), CDec(dtExcel.Rows(i)(14).ToString()), dtExcel.Rows(i)(15).ToString(), CDec(dtExcel.Rows(i)(16).ToString()), dtExcel.Rows(i)(17).ToString(), CDec(dtExcel.Rows(i)(18).ToString()), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), dtExcel.Rows(i)(21).ToString(), dtExcel.Rows(i)(22).ToString(), CDec(dtExcel.Rows(i)(23).ToString()), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString(), dtExcel.Rows(i)(26).ToString(), dtExcel.Rows(i)(27).ToString(), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString(), dtExcel.Rows(i)(30).ToString(), dtExcel.Rows(i)(31).ToString(), dtExcel.Rows(i)(32).ToString(), dtExcel.Rows(i)(33).ToString(), dtExcel.Rows(i)(34).ToString(), dtExcel.Rows(i)(35).ToString(), dtExcel.Rows(i)(36).ToString(), CDec(dtExcel.Rows(i)(37).ToString()))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreInventoryHistory(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteInventoryHistory()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportInventoryHistory(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), CDec(dtExcel.Rows(i)(8).ToString()), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), CDec(dtExcel.Rows(i)(11).ToString()), dtExcel.Rows(i)(12).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreInventoryItemPriceLevel(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteInventoryPriceLevel()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportInventoryPriceLevel(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), CDec(dtExcel.Rows(i)(7).ToString()), CDec(dtExcel.Rows(i)(8).ToString()), CDec(dtExcel.Rows(i)(9).ToString()), CDec(dtExcel.Rows(i)(10).ToString()), CDec(dtExcel.Rows(i)(11).ToString()), CDec(dtExcel.Rows(i)(12).ToString()), CDec(dtExcel.Rows(i)(13).ToString()), CDec(dtExcel.Rows(i)(14).ToString()), CDec(dtExcel.Rows(i)(15).ToString()), CDec(dtExcel.Rows(i)(16).ToString()), dtExcel.Rows(i)(17).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Purchase Order..."
    Private Sub RestorePurchaseOrder(ByVal indx As Integer, ByVal path As String)
        Try 
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\Purchase.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeletePurchaseOrder()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportPurchaseOrder(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), CDec(dtExcel.Rows(i)(15).ToString()), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), CDec(dtExcel.Rows(i)(19).ToString()), dtExcel.Rows(i)(20).ToString(), CDec(dtExcel.Rows(i)(21).ToString()), CDec(dtExcel.Rows(i)(22).ToString()), CDec(dtExcel.Rows(i)(23).ToString()), CDec(dtExcel.Rows(i)(24).ToString()), CDec(dtExcel.Rows(i)(25).ToString()), CDec(dtExcel.Rows(i)(26).ToString()), dtExcel.Rows(i)(27).ToString(), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Sales Invoice..."
    Private Sub RestoreSalesInvoice(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(Path)
            RenameFile(Path)
            Dim fname As String
            fname = Path + "\SalesInvoice.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteSalesInvoice()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportSalesInvoice(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), CDec(dtExcel.Rows(i)(11).ToString()), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), CDec(dtExcel.Rows(i)(15).ToString()), dtExcel.Rows(i)(16).ToString(), CDec(dtExcel.Rows(i)(17).ToString()), CDec(dtExcel.Rows(i)(18).ToString()), CDec(dtExcel.Rows(i)(19).ToString()), CDec(dtExcel.Rows(i)(20).ToString()), CDec(dtExcel.Rows(i)(21).ToString()), CDec(dtExcel.Rows(i)(22).ToString()), dtExcel.Rows(i)(23).ToString(), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Games..."
    Private Sub RestoreGames(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\Game.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteGame()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportGame(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), CDec(dtExcel.Rows(i)(12).ToString()), dtExcel.Rows(i)(13).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Books..."
    Private Sub RestoreBooks(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\Books.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteBook()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportBook(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), CInt(dtExcel.Rows(i)(11).ToString()), CInt(dtExcel.Rows(i)(12).ToString()), CDec(dtExcel.Rows(i)(13).ToString()), dtExcel.Rows(i)(14).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Subject Books..."
    Private Sub RestoreSubjectBooks(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\Subjects.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteSubjectBook()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportSubjectBook(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Groups..."
    Private Sub RestoreGroups(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\Groups.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteGroup()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportGroup(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Library Charges..."
    Private Sub RestoreLibraryCharges(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\Library Charges.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteBookCharges()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportBookCharges(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CDec(dtExcel.Rows(i)(6).ToString()), CInt(dtExcel.Rows(i)(7).ToString()), CInt(dtExcel.Rows(i)(8).ToString()), CInt(dtExcel.Rows(i)(9).ToString()), CInt(dtExcel.Rows(i)(10).ToString()), CInt(dtExcel.Rows(i)(11).ToString()), CInt(dtExcel.Rows(i)(12).ToString()), CInt(dtExcel.Rows(i)(13).ToString()), CInt(dtExcel.Rows(i)(14).ToString()), CDec(dtExcel.Rows(i)(15).ToString()), CDec(dtExcel.Rows(i)(16).ToString()), CDec(dtExcel.Rows(i)(17).ToString()), CDec(dtExcel.Rows(i)(18).ToString()), CDec(dtExcel.Rows(i)(19).ToString()))
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Issue Books..."
    Private Sub RestoreIssueBooks(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname1, fname2 As String
            fname1 = path + "\Issue.xls"
            fname2 = path + "\IssueBooks.xls"
            RestoreIssue(fname1)
            RestoreIssueBooks(fname2)
            My.Computer.FileSystem.DeleteFile(fname1)
            My.Computer.FileSystem.DeleteFile(fname2)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreIssue(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteIssue()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportIssue(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreIssueBooks(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteIssueBook()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportIssueBook(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Return Books..."
    Private Sub RestoreReturnBooks(ByVal indx As Integer, ByVal path As String)
        Try 
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\Return Books.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteReturnBook()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportReturnBook(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Calculated Library Charges..."
    Private Sub RestoreCalculatedLibraryCharges(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\Calculated Library Charges.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteCalculateCharges()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportCalculateCharges(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), CInt(dtExcel.Rows(i)(9).ToString()), CDec(dtExcel.Rows(i)(10).ToString()), CDec(dtExcel.Rows(i)(11).ToString()), CDec(dtExcel.Rows(i)(12).ToString()), CDec(dtExcel.Rows(i)(13).ToString()), CDec(dtExcel.Rows(i)(14).ToString()), CDec(dtExcel.Rows(i)(15).ToString()), CDec(dtExcel.Rows(i)(16).ToString()), CDec(dtExcel.Rows(i)(17).ToString()), CDec(dtExcel.Rows(i)(18).ToString()), dtExcel.Rows(i)(19).ToString(), CDec(dtExcel.Rows(i)(20).ToString()), dtExcel.Rows(i)(21).ToString(), dtExcel.Rows(i)(22).ToString(), dtExcel.Rows(i)(23).ToString(), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString(), dtExcel.Rows(i)(26).ToString(), dtExcel.Rows(i)(27).ToString(), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString(), dtExcel.Rows(i)(30).ToString(), dtExcel.Rows(i)(31).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Department..."
    Private Sub RestoreDepartment(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\Department.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteDepartment()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportDepartment(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Designation..."
    Private Sub RestoreDesignation(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\Designation.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteDesignation()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportDesignation(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Professional Tax..."
    Private Sub RestoreProfessionalTax(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\Professional Tax.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteProfTax()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportProfTax(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), CDec(dtExcel.Rows(i)(3).ToString()), CDec(dtExcel.Rows(i)(4).ToString()))
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore DA/ HRA..."
    Private Sub RestoreDAHRA(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(Path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\DaHra.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteDAHRA()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportDAHRA(CInt(dtExcel.Rows(i)(3).ToString()), dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), CInt(dtExcel.Rows(i)(4).ToString()), CInt(dtExcel.Rows(i)(5).ToString()), CDec(dtExcel.Rows(i)(6).ToString()), CDec(dtExcel.Rows(i)(7).ToString()), CDec(dtExcel.Rows(i)(8).ToString()), CDec(dtExcel.Rows(i)(9).ToString()))
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Pay-Scale..."
    Private Sub RestorePayScale(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(Path)
            RenameFile(Path)
            Dim fname As String
            fname = Path + "\PayScale.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeletePayScale()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportPayScale(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), CDec(dtExcel.Rows(i)(4).ToString()), CDec(dtExcel.Rows(i)(5).ToString()), CDec(dtExcel.Rows(i)(6).ToString()), CDec(dtExcel.Rows(i)(7).ToString()), dtExcel.Rows(i)(8).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Pay Slip Headers..."
    Private Sub RestorePaySlipHeaders(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\PayslipHeaders.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeletePaySlipHeaders()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportPaySlipHeaders(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), dtExcel.Rows(i)(21).ToString(), dtExcel.Rows(i)(22).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Adjustment/ Deduction..."
    Private Sub RestoreAdjustmentDeductions(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(Path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\AdjustmentDeductions.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteAdjustmentDeduction()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportAdjustmentDeduction(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), CInt(dtExcel.Rows(i)(4).ToString()), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), CInt(dtExcel.Rows(i)(8).ToString()), CInt(dtExcel.Rows(i)(9).ToString()), CDec(dtExcel.Rows(i)(10).ToString()), CDec(dtExcel.Rows(i)(11).ToString()), CDec(dtExcel.Rows(i)(12).ToString()), CDec(dtExcel.Rows(i)(13).ToString()), CDec(dtExcel.Rows(i)(14).ToString()), CDec(dtExcel.Rows(i)(15).ToString()), CDec(dtExcel.Rows(i)(16).ToString()), CDec(dtExcel.Rows(i)(17).ToString()), CDec(dtExcel.Rows(i)(18).ToString()), CDec(dtExcel.Rows(i)(19).ToString()), CDec(dtExcel.Rows(i)(20).ToString()), CDec(dtExcel.Rows(i)(21).ToString()), CDec(dtExcel.Rows(i)(22).ToString()), CDec(dtExcel.Rows(i)(23).ToString()), CDec(dtExcel.Rows(i)(24).ToString()), CDec(dtExcel.Rows(i)(25).ToString()), CDec(dtExcel.Rows(i)(26).ToString()), CDec(dtExcel.Rows(i)(27).ToString()), CDec(dtExcel.Rows(i)(28).ToString()), CDec(dtExcel.Rows(i)(29).ToString()), CDec(dtExcel.Rows(i)(30).ToString()), CDec(dtExcel.Rows(i)(31).ToString()), CDec(dtExcel.Rows(i)(32).ToString()), CDec(dtExcel.Rows(i)(33).ToString()), CDec(dtExcel.Rows(i)(34).ToString()), CDec(dtExcel.Rows(i)(35).ToString()), dtExcel.Rows(i)(36).ToString(), dtExcel.Rows(i)(37).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Working Hours/ Day..."
    Private Sub RestoreWorkingHoursDay(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(Path)
            RenameFile(path)
            Dim fname1, fname2 As String
            fname1 = path + "\WorkingHourly.xls"
            fname2 = path + "\WorkingDaily.xls"
            RestoreWorkingHours(fname1)
            RestoreWorkingDay(fname2)
            My.Computer.FileSystem.DeleteFile(fname1)
            My.Computer.FileSystem.DeleteFile(fname2)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreWorkingHours(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteWorkingHours()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportWorkingHours(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), CInt(dtExcel.Rows(i)(8).ToString()))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RestoreWorkingDay(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteWorkingDay()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportWorkingDay(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Salary Calculations..."
    Private Sub RestoreSalaryCalculations(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(Path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\Salary.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteSalaryCalculation()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportSalaryCalculation(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), CInt(dtExcel.Rows(i)(4).ToString()), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), CInt(dtExcel.Rows(i)(9).ToString()), CInt(dtExcel.Rows(i)(10).ToString()), CDec(dtExcel.Rows(i)(11).ToString()), CDec(dtExcel.Rows(i)(12).ToString()), CDec(dtExcel.Rows(i)(13).ToString()), CDec(dtExcel.Rows(i)(14).ToString()), CDec(dtExcel.Rows(i)(15).ToString()), CDec(dtExcel.Rows(i)(16).ToString()), CDec(dtExcel.Rows(i)(17).ToString()), CDec(dtExcel.Rows(i)(18).ToString()), CDec(dtExcel.Rows(i)(19).ToString()), CDec(dtExcel.Rows(i)(20).ToString()), CDec(dtExcel.Rows(i)(21).ToString()), CDec(dtExcel.Rows(i)(22).ToString()), CDec(dtExcel.Rows(i)(23).ToString()), CDec(dtExcel.Rows(i)(24).ToString()), CDec(dtExcel.Rows(i)(25).ToString()), CDec(dtExcel.Rows(i)(26).ToString()), CDec(dtExcel.Rows(i)(27).ToString()), CDec(dtExcel.Rows(i)(28).ToString()), CDec(dtExcel.Rows(i)(29).ToString()), CDec(dtExcel.Rows(i)(30).ToString()), CDec(dtExcel.Rows(i)(31).ToString()), CDec(dtExcel.Rows(i)(32).ToString()), CDec(dtExcel.Rows(i)(33).ToString()), CDec(dtExcel.Rows(i)(34).ToString()), CDec(dtExcel.Rows(i)(35).ToString()), CDec(dtExcel.Rows(i)(36).ToString()), CDec(dtExcel.Rows(i)(37).ToString()), CDec(dtExcel.Rows(i)(38).ToString()), CDec(dtExcel.Rows(i)(39).ToString()), CDec(dtExcel.Rows(i)(40).ToString()), CDec(dtExcel.Rows(i)(41).ToString()), CDec(dtExcel.Rows(i)(42).ToString()), CDec(dtExcel.Rows(i)(43).ToString()), CDec(dtExcel.Rows(i)(44).ToString()), CDec(dtExcel.Rows(i)(45).ToString()), CDec(dtExcel.Rows(i)(46).ToString()), CDec(dtExcel.Rows(i)(47).ToString()), CDec(dtExcel.Rows(i)(48).ToString()), CDec(dtExcel.Rows(i)(49).ToString()), CDec(dtExcel.Rows(i)(50).ToString()), CDec(dtExcel.Rows(i)(51).ToString()), CDec(dtExcel.Rows(i)(52).ToString()), dtExcel.Rows(i)(53).ToString(), dtExcel.Rows(i)(54).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Pay Employee..."
    Private Sub RestorePayEmployee(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(Path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\PayEmployee.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeletePayEmployee()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportPayEmployee(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), CInt(dtExcel.Rows(i)(5).ToString()), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), CDec(dtExcel.Rows(i)(11).ToString()), CDec(dtExcel.Rows(i)(12).ToString()), CDec(dtExcel.Rows(i)(13).ToString()), CDec(dtExcel.Rows(i)(14).ToString()), CDec(dtExcel.Rows(i)(15).ToString()), CDec(dtExcel.Rows(i)(16).ToString()), CDec(dtExcel.Rows(i)(17).ToString()), CDec(dtExcel.Rows(i)(18).ToString()), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Advance/ Withdrawal..."
    Private Sub RestoreAdvanceWithdrawal(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(Path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\PFAdvanceWithdrawal.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteAdvanceWithdrawal()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportAdvanceWithdrawal(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CDec(dtExcel.Rows(i)(6).ToString()), dtExcel.Rows(i)(7).ToString(), CDec(dtExcel.Rows(i)(8).ToString()), dtExcel.Rows(i)(9).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Individual PF Rate..."
    Private Sub RestoreIndividualPFRate(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(Path)
            RenameFile(Path)
            Dim fname As String
            fname = Path + "\PFRateIndividual.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteIndividualPFRate()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportIndividualPFRate(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), CInt(dtExcel.Rows(i)(3).ToString()), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CDec(dtExcel.Rows(i)(6).ToString()), CDec(dtExcel.Rows(i)(7).ToString()))
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Membership..."
    Private Sub RestoreMembership(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(Path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\CloseMembership.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteMembership()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportMembership(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), CDec(dtExcel.Rows(i)(5).ToString()), CDec(dtExcel.Rows(i)(6).ToString()), dtExcel.Rows(i)(7).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Institute Index..."
    Private Sub RestoreInstituteIndex(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(Path)
            RenameFile(Path)
            Dim fname As String
            fname = Path + "\InstituteIndex.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteInstituteIndex()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportInstituteIndex(dtExcel.Rows(i)(0).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Indexx..."
    Private Sub RestoreIndexx(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(Path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\Indexx.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteIndexx()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportIndexx(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), dtExcel.Rows(i)(21).ToString(), dtExcel.Rows(i)(22).ToString(), dtExcel.Rows(i)(23).ToString(), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString(), dtExcel.Rows(i)(26).ToString(), dtExcel.Rows(i)(27).ToString(), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString(), dtExcel.Rows(i)(30).ToString(), dtExcel.Rows(i)(31).ToString(), dtExcel.Rows(i)(32).ToString(), dtExcel.Rows(i)(33).ToString(), dtExcel.Rows(i)(34).ToString(), dtExcel.Rows(i)(35).ToString(), dtExcel.Rows(i)(36).ToString(), dtExcel.Rows(i)(37).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Institute..."
    Private Sub RestoreInstitute(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(Path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\Institute.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteInstitute()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportInstitute(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), CInt(dtExcel.Rows(i)(18).ToString()), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Rescore Financial Year..."
    Private Sub RestoreFinancialYear(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(Path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\FinancialYear.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteFinancialYear()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportFinancialYear(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), CInt(dtExcel.Rows(i)(3).ToString()), CInt(dtExcel.Rows(i)(4).ToString()), dtExcel.Rows(i)(5).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Features..."
    Private Sub RestoreFeatures(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(Path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\Features.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteFeatures()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportFeatures(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Achievements..."
    Private Sub RestoreAchievements(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(Path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\Achievements.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteAchievements()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportAchievements(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Accounting Period..."
    Private Sub RestoreAccountingPeriod(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(Path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\AccountingPeriod.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteAccountingPeriod()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportAccountingPeriod(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Defailt Institute..."
    Private Sub RestoreDefaultInstitute(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(Path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\DefaultInstitute.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteDefaultInstitute()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportDefaultInstitute(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), dtExcel.Rows(i)(21).ToString(), dtExcel.Rows(i)(22).ToString(), dtExcel.Rows(i)(23).ToString(), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString(), dtExcel.Rows(i)(26).ToString(), dtExcel.Rows(i)(27).ToString(), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString(), dtExcel.Rows(i)(30).ToString(), dtExcel.Rows(i)(31).ToString(), dtExcel.Rows(i)(32).ToString(), dtExcel.Rows(i)(33).ToString(), dtExcel.Rows(i)(34).ToString(), dtExcel.Rows(i)(35).ToString(), dtExcel.Rows(i)(36).ToString(), dtExcel.Rows(i)(37).ToString(), dtExcel.Rows(i)(38).ToString(), dtExcel.Rows(i)(39).ToString(), dtExcel.Rows(i)(40).ToString(), dtExcel.Rows(i)(41).ToString(), dtExcel.Rows(i)(42).ToString(), dtExcel.Rows(i)(43).ToString(), dtExcel.Rows(i)(44).ToString(), dtExcel.Rows(i)(45).ToString(), dtExcel.Rows(i)(46).ToString(), dtExcel.Rows(i)(47).ToString(), dtExcel.Rows(i)(48).ToString(), dtExcel.Rows(i)(49).ToString(), dtExcel.Rows(i)(50).ToString(), dtExcel.Rows(i)(51).ToString(), dtExcel.Rows(i)(52).ToString(), dtExcel.Rows(i)(53).ToString(), dtExcel.Rows(i)(54).ToString(), CInt(dtExcel.Rows(i)(55).ToString()), dtExcel.Rows(i)(56).ToString(), dtExcel.Rows(i)(57).ToString(), dtExcel.Rows(i)(58).ToString(), dtExcel.Rows(i)(59).ToString(), dtExcel.Rows(i)(60).ToString(), dtExcel.Rows(i)(61).ToString(), dtExcel.Rows(i)(62).ToString(), dtExcel.Rows(i)(63).ToString(), dtExcel.Rows(i)(64).ToString(), dtExcel.Rows(i)(65).ToString(), dtExcel.Rows(i)(66).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Defailt Library..."
    Private Sub RestoreDefaultLibrary(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(Path)
            RenameFile(Path)
            Dim fname As String
            fname = Path + "\DefaultLibrary.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteDefaultLibrary()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportDefaultLibrary(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Defailt Payroll..."
    Private Sub RestoreDefaultPayroll(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(Path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\DefaultPayroll.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteDefaultPayroll()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportDefaultPayroll(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), CDec(dtExcel.Rows(i)(5).ToString()))
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Student Control..."
    Private Sub RestoreStudentControl(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(Path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\StudentControl.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeleteStudentControl()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportStudentControl(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), CDec(dtExcel.Rows(i)(9).ToString()), dtExcel.Rows(i)(10).ToString(), CDec(dtExcel.Rows(i)(11).ToString()), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), CInt(dtExcel.Rows(i)(16).ToString()), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), dtExcel.Rows(i)(21).ToString())
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore PFRate..."
    Private Sub RestorePFRate(ByVal indx As Integer, ByVal path As String)
        Try
            UnZip(Path)
            RenameFile(path)
            Dim fname As String
            fname = path + "\PFRate.xls"
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport
            cls.DeletePFRate()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportPFRate(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), CInt(dtExcel.Rows(i)(3).ToString()), CDec(dtExcel.Rows(i)(4).ToString()), CDec(dtExcel.Rows(i)(5).ToString()))
            Next
            My.Computer.FileSystem.DeleteFile(fname)
            MessageBox.Show("Data Restoreed successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Restore Tables..."
    Private Sub Restore()
        Dim fBrowse As New FolderBrowserDialog
        If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            RestoreInstitute(0, fBrowse.SelectedPath)
            RestoreInstituteIndex(0, fBrowse.SelectedPath)
            RestoreIndexx(0, fBrowse.SelectedPath)
            RestoreAccountingPeriod(0, fBrowse.SelectedPath)
            RestoreDAHRA(0, fBrowse.SelectedPath)
            RestorePaySlipHeaders(0, fBrowse.SelectedPath)
            RestorePFRate(0, fBrowse.SelectedPath)
            RestoreDefaultInstitute(0, fBrowse.SelectedPath)
            RestoreDefaultLibrary(0, fBrowse.SelectedPath)
            RestoreDefaultPayroll(0, fBrowse.SelectedPath)
            RestoreFeatures(0, fBrowse.SelectedPath)
            RestoreAchievements(0, fBrowse.SelectedPath)
            RestoreFinancialYear(0, fBrowse.SelectedPath)
            RestoreUsers(0, fBrowse.SelectedPath)
            RestoreCourseTermsFees(0, fBrowse.SelectedPath)
            RestoreAccountingManagement(0, fBrowse.SelectedPath)
            RestoreAdjustmentDeductions(0, fBrowse.SelectedPath)
            RestoreAdvanceWithdrawal(0, fBrowse.SelectedPath)
            RestoreAlumni(0, fBrowse.SelectedPath)
            RestoreAssignments(0, fBrowse.SelectedPath)
            RestoreBooks(0, fBrowse.SelectedPath)
            RestoreCalculatedLibraryCharges(0, fBrowse.SelectedPath)
            RestoreDAHRA(0, fBrowse.SelectedPath)
            RestoreDepartment(0, fBrowse.SelectedPath)
            RestoreDesignation(0, fBrowse.SelectedPath)
            RestoreDiscount(0, fBrowse.SelectedPath)
            RestoreEmployee(0, fBrowse.SelectedPath)
            RestoreEmployeeAttendance(0, fBrowse.SelectedPath)
            RestoreEmployeeCertificates(0, fBrowse.SelectedPath)
            RestoreExamFees(0, fBrowse.SelectedPath)
            RestoreExamination(0, fBrowse.SelectedPath)
            RestoreFinancialLoan(0, fBrowse.SelectedPath)
            RestoreGames(0, fBrowse.SelectedPath)
            RestoreGroups(0, fBrowse.SelectedPath)
            RestoreHiredEmployee(0, fBrowse.SelectedPath)
            RestoreRetiredEmployee(0, fBrowse.SelectedPath)
            RestoreIDCard(0, fBrowse.SelectedPath)
            RestoreIncomeExpenditure(0, fBrowse.SelectedPath)
            RestoreIndividualPFRate(0, fBrowse.SelectedPath)
            RestoreInventory(0, fBrowse.SelectedPath)
            RestoreIssueBooks(0, fBrowse.SelectedPath)
            RestoreLateFees(0, fBrowse.SelectedPath)
            RestoreLibraryCharges(0, fBrowse.SelectedPath)
            RestoreMarksheets(0, fBrowse.SelectedPath)
            RestoreMembership(0, fBrowse.SelectedPath)
            RestoreMonthlyFees(0, fBrowse.SelectedPath)
            RestoreNotices(0, fBrowse.SelectedPath)
            RestoreOnlineExamQsn(0, fBrowse.SelectedPath)
            RestoreOtherFees(0, fBrowse.SelectedPath)
            RestorePayEmployee(0, fBrowse.SelectedPath)
            RestorePayScale(0, fBrowse.SelectedPath)
            RestorePaySlipHeaders(0, fBrowse.SelectedPath)
            RestoreProfessionalTax(0, fBrowse.SelectedPath)
            RestoreProgressReport(0, fBrowse.SelectedPath)
            RestorePurchaseOrder(0, fBrowse.SelectedPath)
            RestoreReturnBooks(0, fBrowse.SelectedPath)
            RestoreSalaryCalculations(0, fBrowse.SelectedPath)
            RestoreSalesInvoice(0, fBrowse.SelectedPath)
            RestoreStudentAdmission(0, fBrowse.SelectedPath)
            RestoreStudentAttendance(0, fBrowse.SelectedPath)
            RestoreStudentCertificates(0, fBrowse.SelectedPath)
            RestoreStudentControl(0, fBrowse.SelectedPath)
            RestoreStudentPreAdmission(0, fBrowse.SelectedPath)
            RestoreStudentRegistration(0, fBrowse.SelectedPath)
            RestoreSubjectBooks(0, fBrowse.SelectedPath)
            RestoreSubjects(0, fBrowse.SelectedPath)
            RestoreSyllabus(0, fBrowse.SelectedPath)
            RestoreWorkingHoursDay(0, fBrowse.SelectedPath)
            RestoreYearlyFees(0, fBrowse.SelectedPath)
        End If
    End Sub
#End Region
#End Region
#End Region
#Region "Form Events..."
    Private Sub frmBackupRestore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlSetBound()
        LoadDataGridValues()
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnbackup_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnbackup.ClickButtonArea
        Backup()
    End Sub

    Private Sub btnbackuponline_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnbackuponline.ClickButtonArea

    End Sub

    Private Sub btnrestore_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrestore.ClickButtonArea
        Restore()
    End Sub

    Private Sub btnrestoreonline_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrestoreonline.ClickButtonArea

    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region