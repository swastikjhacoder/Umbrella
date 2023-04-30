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
#Region "Class frmImportExport..."
Public Class frmImportExportInstitute
#Region "Declarations..."
    Dim shObj As Object = Activator.CreateInstance(Type.GetTypeFromProgID("Shell.Application"))
#End Region
#Region "Methods..."
    Private Sub LoadActivityList()
        lstlist.Items.Clear()
        lstlist.Items.Add("Alumni Records")
        lstlist.Items.Add("Student Certificates")
        lstlist.Items.Add("Employee Certificates")
        lstlist.Items.Add("Inventory Records")
        lstlist.Items.Add("Purchase Records")
        lstlist.Items.Add("Sales Invoice Records")
        lstlist.Items.Add("Games Records")
    End Sub

    Private Sub LoadAdmissionList()
        lstlist.Items.Clear()
        lstlist.Items.Add("Student Admission Records")
        lstlist.Items.Add("Student Pre-Admission Records")
        lstlist.Items.Add("Student Registration Records")
    End Sub

    Private Sub LoadExaminationList()
        lstlist.Items.Clear()
        lstlist.Items.Add("Courses")
        lstlist.Items.Add("Subjects")
        lstlist.Items.Add("Syllabus")
        lstlist.Items.Add("Assignments")
        lstlist.Items.Add("Examinations")
        lstlist.Items.Add("Online Examinations")
        lstlist.Items.Add("Progress Report")
        lstlist.Items.Add("Marksheets")
    End Sub

    Private Sub LoadFeesList()
        lstlist.Items.Clear()
        lstlist.Items.Add("Terms & Fees")
        lstlist.Items.Add("Yearly Fees")
        lstlist.Items.Add("Monthly Fees")
        lstlist.Items.Add("Late Fees")
        lstlist.Items.Add("Library Fees")
        lstlist.Items.Add("Examination Fees")
        lstlist.Items.Add("Other Fees")
        lstlist.Items.Add("Discount Records")
        lstlist.Items.Add("Financial Loan Application Records")
        lstlist.Items.Add("Incomes & Expenditures")
        lstlist.Items.Add("Accounting Managements")
        lstlist.Items.Add("Bank Deposits")
    End Sub

    Private Sub LoadInstituteList()
        lstlist.Items.Clear()
        lstlist.Items.Add("Employee Records")
        lstlist.Items.Add("Hired Employee Records")
        lstlist.Items.Add("Retired Employee Records")
        lstlist.Items.Add("Student Attendance Record")
        lstlist.Items.Add("Employee Attendance Record")
        lstlist.Items.Add("Notices")
        lstlist.Items.Add("Submitted ID Cords")
        lstlist.Items.Add("User Records")
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
            If (File.GetAttributes(fi.FullName) And FileAttributes.Hidden)<> FileAttributes.Hidden And fi.Extension <> ".gz" Then
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
#Region "Export..."
#Region "Export Employee..."
    Private Sub ExportEmployee()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select InsID,InsName,Period,SystemDate,empid,namefirst,namemiddle,namelast,name,houseno,address,city,district,state,pin,country,phone,fax,dob,email,category,department,designation,married,sex,handicapped,presentposition,retirementdate,fulladdress,payinfo,payscale,grade,basic,joiningdate,phd,qualifiedtest,attachedcopy,incremented from Employee where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Employee")
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

                Dim fileName As String = "\Employee\Employee" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                ExportEmployeeAcademic(f.SelectedPath + "\Employee")
                ExportEmployeeActivity(f.SelectedPath + "\Employee")
                ExportEmployeeLanguage(f.SelectedPath + "\Employee")
                ExportEmployeePF(f.SelectedPath + "\Employee")
                ExportEmployeeProficiency(f.SelectedPath + "\Employee")
                ExportEmployeeProgrammingLang(f.SelectedPath + "\Employee")
                ExportEmployeeResearchExp(f.SelectedPath + "\Employee")
                ExportEmployeeTeachingExp(f.SelectedPath + "\Employee")

                Zip(f.SelectedPath + "\Employee")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ExportEmployeeLanguage(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from EmployeeLanguage where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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

    Private Sub ExportEmployeeAcademic(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from EmployeeAcademic where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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

    Private Sub ExportEmployeeTeachingExp(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from EmployeeTeachingExp where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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

    Private Sub ExportEmployeeResearchExp(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from EmployeeResearchExp where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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

    Private Sub ExportEmployeeProficiency(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from EmployeeProficiency where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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

    Private Sub ExportEmployeeProgrammingLang(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from EmployeeProgrammingLang where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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

    Private Sub ExportEmployeeActivity(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from EmployeeActivity where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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

    Private Sub ExportEmployeePF(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from PF where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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
#Region "Export Hired Employee..."
    Private Sub ExportHiredEmployee()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select InsID,InsName,Period,SystemDate,empid,namefirst,namemiddle,namelast,name,houseno,address,city,district,state,pin,country,phone,fax,dob,email,category,department,designation,married,sex,handicapped,presentposition,retirementdate,fulladdress,payinfo,pay,joiningdate from HiredEmployee where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\HiredEmployee")
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

                Dim fileName As String = "\HiredEmployee\HiredEmployee" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\HiredEmployee")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Retired Employee..."
    Private Sub ExportRetiredEmployee()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select InsID,InsName,Period,SystemDate,empid,namefirst,namemiddle,namelast,name,houseno,address,city,district,state,pin,country,phone,fax,dob,email,category,department,designation,married,sex,handicapped,presentposition,retirementdate,fulladdress,payinfo,payscale,grade,basic,joiningdate,phd,qualifiedtest,attachedcopy,incremented from RetiredEmployee where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\RetiredEmployee")
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

                Dim fileName As String = "\RetiredEmployee\RetiredEmployee" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                ExportRetiredEmployeeAcademic(f.SelectedPath + "\RetiredEmployee")
                ExportRetiredEmployeeActivity(f.SelectedPath + "\RetiredEmployee")
                ExportRetiredEmployeeLanguage(f.SelectedPath + "\RetiredEmployee")
                ExportRetiredEmployeePF(f.SelectedPath + "\RetiredEmployee")
                ExportRetiredEmployeeProficiency(f.SelectedPath + "\RetiredEmployee")
                ExportRetiredEmployeeProgrammingLang(f.SelectedPath + "\RetiredEmployee")
                ExportRetiredEmployeeResearchExp(f.SelectedPath + "\RetiredEmployee")
                ExportRetiredEmployeeTeachingExp(f.SelectedPath + "\RetiredEmployee")

                Zip(f.SelectedPath + "\RetiredEmployee")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ExportRetiredEmployeeLanguage(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from RetiredEmployeeLanguage where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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

    Private Sub ExportRetiredEmployeeAcademic(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from RetiredEmployeeAcademic where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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

    Private Sub ExportRetiredEmployeeTeachingExp(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from RetiredEmployeeTeachingExp where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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

    Private Sub ExportRetiredEmployeeResearchExp(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from RetiredEmployeeResearchExp where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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

    Private Sub ExportRetiredEmployeeProficiency(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from RetiredEmployeeProficiency where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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

    Private Sub ExportRetiredEmployeeProgrammingLang(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from RetiredEmployeeProgrammingLang where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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

    Private Sub ExportRetiredEmployeeActivity(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from RetiredEmployeeActivity where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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

    Private Sub ExportRetiredEmployeePF(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from RetiredPF where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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
#Region "Export Student Attendance..."
    Private Sub ExportStudentAtendance()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from StudentAttendance where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\StudentAttendance")
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

                Dim fileName As String = "\StudentAttendance\StudentAttendance" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\StudentAttendance")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Employee Attendance..."
    Private Sub ExportEmployeeAttendance()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from EmployeeAttendance where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\EmployeeAttendance")
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

                Dim fileName As String = "\EmployeeAttendance\EmployeeAttendance" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\EmployeeAttendance")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Notices..."
    Private Sub ExportNotices()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Notice where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Notice")
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

                Dim fileName As String = "\Notice\Notice" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\Notice")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export ID Card..."
    Private Sub ExportIDCard()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from IDCard where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\IDCard")
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

                Dim fileName As String = "\IDCard\IDCard" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\IDCard")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export User Security..."
    Private Sub ExportUserSecurity()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Users where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Users")
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

                Dim fileName As String = "\Users\Users" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                ExportUserCrystalReport(f.SelectedPath + "\Users")

                Zip(f.SelectedPath + "\Users")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ExportUserCrystalReport(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from UserCrystalReport where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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
#Region "Export Student Admission..."
    Private Sub ExportStudentAdmission()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select InsID,InsName,Period,SystemDate,serial,year,preadmitted,preadmissionid,course,approved,class,classint,classstring,fname,mname,lname,name ,dob,sex,fgname,mothername,coursefee,annualincome,prehouseno,preaddress,precity,prepost,predist,prestate,prepin,precountry,perhouseno,peraddress,percity,perpost,perdist,perstate,perpin,percountry,profcourse,profcourseduration,profcourseyear,competitiveexam,institute,recognized,instituteaddress,institutephone,institutefax,instituteuniv,payeename,bankname,bankbrach,branchaddress,branchcode,accountno,accounttype,micrcode,electronictransfer,cardholdername,cardaddress,cardcity,cardstate,cardpin,cardcountry,cardtype,payvia,cardno,expmm,expyy,email,homephone,workphone,fax from StudentAdmision where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\StudentAdmision")
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

                Dim fileName As String = "\StudentAdmision\StudentAdmision" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                ExportStudentAdmissionExam(f.SelectedPath + "\StudentAdmision")

                Zip(f.SelectedPath + "\StudentAdmision")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ExportStudentAdmissionExam(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from StudentAdmisionExam where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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
#Region "Export Student Pre Admission..."
    Private Sub ExportStudentPreAdmission()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select InsID,InsName,Period,SystemDate,serial,year,fname,mname,lname,name ,dob,sex,fgname,mothername,houseno,address,city,post,dist,state,pin,country,email,homephone,workphone,fax,class,classint,classstring,course,testfee,othertestfee,coursefee,annualincome,payeename,bankname,bankbrach,branchaddress,branchcode,accountno,accounttype,micrcode,electronictransfer,cardholdername,cardaddress,cardcity,cardstate,cardpin,cardcountry,cardtype,payvia,cardno,expmm,expyy from StudentPreAdmission where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\StudentPreAdmission")
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

                Dim fileName As String = "\StudentPreAdmission\StudentPreAdmission" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\StudentPreAdmission")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Student Registration..."
    Private Sub ExportStudentRegistration()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select InsID,InsName,Period,SystemDate,serial,year,preadmitted,preadmissionid,course,approved,class,classint,classstring,fname,mname,lname,name,fgname,mothername,dob,sex,coursefee,annualincome,prehouseno,preaddress,precity,prepost,predist,prestate,prepin,precountry,perhouseno,peraddress,percity,perpost,perdist,perstate,perpin,percountry,profcourse,profcourseduration,profcourseyear,institute,recognized,instituteaddress,institutephone,institutefax,instituteuniv,payeename,bankname,bankbrach,branchaddress,branchcode,accountno,accounttype,micrcode,electronictransfer,cardholdername,cardaddress,cardcity,cardstate,cardpin,cardcountry,cardtype,payvia,cardno,expmm,expyy,email,homephone,workphone,fax,stuid,roll,time,tuition,emergencyname,emergencyhomeph,emergencyworkph,emergencyfax,emergencyrelation,emergencyaddress from StudentRegistration where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\StudentRegistration")
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

                Dim fileName As String = "\StudentRegistration\StudentRegistration" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\StudentRegistration")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Terms & Fees..."
    Private Sub ExportCourseTermsFees()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Course where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Course")
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

                Dim fileName As String = "\Course\Course" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                ExportTermsFees(f.SelectedPath + "\Course")

                Zip(f.SelectedPath + "\Course")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ExportTermsFees(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from CourseTermFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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
#Region "Export Yearly Fees..."
    Private Sub ExportYearlyFees()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from YearlyFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\YearlyFees")
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

                Dim fileName As String = "\YearlyFees\YearlyFees" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\YearlyFees")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Monthly Fees..."
    Private Sub ExportMonthlyFees()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from MonthlyFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\MonthlyFees")
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

                Dim fileName As String = "\MonthlyFees\MonthlyFees" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\MonthlyFees")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Late Fees..."
    Private Sub ExportLateFees()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from LateFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\LateFees")
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

                Dim fileName As String = "\LateFees\LateFees" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\LateFees")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Library Fees..."
    Private Sub ExportLibraryFees()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from libraryFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\libraryFees")
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

                Dim fileName As String = "\libraryFees\libraryFees" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\libraryFees")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Exam Fees..."
    Private Sub ExportExamFees()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from ExamFee where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\ExamFee")
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

                Dim fileName As String = "\ExamFee\ExamFee" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\ExamFee")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Other Fees..."
    Private Sub ExportOtherFees()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from OtherFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\OtherFees")
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

                Dim fileName As String = "\OtherFees\OtherFees" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\OtherFees")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Discount..."
    Private Sub ExportDiscount()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Discount where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Discount")
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

                Dim fileName As String = "\Discount\Discount" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                ExportStudentDiscount(f.SelectedPath + "\Discount")

                Zip(f.SelectedPath + "\Discount")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ExportStudentDiscount(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from StudentDiscount where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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
#Region "Export Financial Loan"
    Private Sub ExportFinancialLoan()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select InsID,InsName,Period,SystemDate,course,class,roll,name,regno,applicantno,fgname,dob,sex,nationality,religion,email,homeph,workph,houseno,address,city,post,district,state,pincode,country,attachmentname,attachmentsize,attachmentpath,attachmentnote from FinancialLoan where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\FinancialLoan")
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

                Dim fileName As String = "\FinancialLoan\FinancialLoan" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\FinancialLoan")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Income Expenditure..."
    Private Sub ExportIncomeExpenditure()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from IncomeExpenditure where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\IncomeExpenditure")
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

                Dim fileName As String = "\IncomeExpenditure\IncomeExpenditure" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\IncomeExpenditure")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Accounting Management..."
    Private Sub ExportAccountingManagement()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Accounts where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Accounts")
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

                Dim fileName As String = "\Accounts\Accounts" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                ExportBankDeposit(f.SelectedPath + "\Accounts")

                Zip(f.SelectedPath + "\Accounts")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ExportBankDeposit(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from BankDeposit where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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
#Region "Export Subjects..."
    Private Sub Exportsubjects()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Subjects where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Subjects")
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

                Dim fileName As String = "\Subjects\Subjects" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\Subjects")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Syllabus..."
    Private Sub ExportSyllabus()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Syllabus where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Syllabus")
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

                Dim fileName As String = "\Syllabus\Syllabus" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\Syllabus")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Assignments..."
    Private Sub ExportAssignments()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Assignment where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Assignment")
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

                Dim fileName As String = "\Assignment\Assignment" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\Assignment")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Examination..."
    Private Sub ExportExamination()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Examination where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Examination")
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

                Dim fileName As String = "\Examination\Examination" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                ExportExamStudent(f.SelectedPath + "\Examination")
                ExportExamGuard(f.SelectedPath + "\Examination")

                Zip(f.SelectedPath + "\Examination")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ExportExamStudent(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from ExamStudents where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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

    Private Sub ExportExamGuard(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from ExamGuard where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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
#Region "Export Online Examination..."
    Private Sub ExportOnlineExamQsn()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from OnlineExamQsn where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\OnlineExamQsn")
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

                Dim fileName As String = "\OnlineExamQsn\OnlineExamQsn" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                ExportOnlineExam(f.SelectedPath + "\OnlineExamQsn")

                Zip(f.SelectedPath + "\OnlineExamQsn")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ExportOnlineExam(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from OnlineExam where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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
#Region "Export Progress Report..."
    Private Sub ExportProgressReport()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from ProgressReport where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\ProgressReport")
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

                Dim fileName As String = "\ProgressReport\ProgressReport" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\ProgressReport")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Marksheet..."
    Private Sub ExportMarksheet()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Marksheet where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Marksheet")
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

                Dim fileName As String = "\Marksheet\Marksheet" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\Marksheet")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Alumni..."
    Private Sub ExportAlumni()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select InsID,InsName,Period,SystemDate,serial,alumniyear,year,preadmitted,preadmissionid,course,approved,class,classint,classstring,fname,mname,lname,name,fgname,mothername,dob,sex,coursefee,annualincome,prehouseno,preaddress,precity,prepost,predist,prestate,prepin,precountry,perhouseno,peraddress,percity,perpost,perdist,perstate,perpin,percountry,profcourse,profcourseduration,profcourseyear,institute,recognized,instituteaddress,institutephone,institutefax,instituteuniv,payeename,bankname,bankbrach,branchaddress,branchcode,accountno,accounttype,micrcode,electronictransfer,cardholdername,cardaddress,cardcity,cardstate,cardpin,cardcountry,cardtype,payvia,cardno,expmm,expyy,email,homephone,workphone,fax,stuid,roll,time,tuition,emergencyname,emergencyhomeph,emergencyworkph,emergencyfax,emergencyrelation,emergencyaddress from Alumni where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Alumni")
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

                Dim fileName As String = "\Alumni\Alumni" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\Alumni")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Student Certificates..."
    Private Sub ExportStudentCertificates()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from StudentCertificate where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\StudentCertificate")
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

                Dim fileName As String = "\StudentCertificate\StudentCertificate" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\StudentCertificate")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Employee Certificates..."
    Private Sub ExportEmployeeCertificates()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from EmployeeCertificate where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\EmployeeCertificate")
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

                Dim fileName As String = "\EmployeeCertificate\EmployeeCertificate" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\EmployeeCertificate")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Inventory..."
    Private Sub ExportInventory()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Inventory where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Inventory")
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

                Dim fileName As String = "\Inventory\Inventory" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                ExportInventoryHistory(f.SelectedPath + "\Inventory")
                ExportInventoryItemPriceLevel(f.SelectedPath + "\Inventory")

                Zip(f.SelectedPath + "\Inventory")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ExportInventoryHistory(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from InventoryHistory where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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

    Private Sub ExportInventoryItemPriceLevel(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from InventoryItemPriceLevel where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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
#Region "Export Purchase Order..."
    Private Sub ExportPurchaseOrder()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Purchase where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Purchase")
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

                Dim fileName As String = "\Purchase\Purchase" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\Purchase")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Sales Invoice..."
    Private Sub ExportSalesInvoice()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from SalesInvoice where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\SalesInvoice")
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

                Dim fileName As String = "\SalesInvoice\SalesInvoice" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\SalesInvoice")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Games..."
    Private Sub ExportGames()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Game where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Game")
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

                Dim fileName As String = "\Game\Game" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
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

                Zip(f.SelectedPath + "\Game")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Tables..."
    Private Sub Export()
        If lstlist.SelectedItem.ToString() = "Employee Records" Then
            ExportEmployee()
        ElseIf lstlist.SelectedItem.ToString() = "Hired Employee Records" Then
            ExportHiredEmployee()
        ElseIf lstlist.SelectedItem.ToString() = "Retired Employee Records" Then
            ExportRetiredEmployee()
        ElseIf lstlist.SelectedItem.ToString() = "Student Attendance Record" Then
            ExportStudentAtendance()
        ElseIf lstlist.SelectedItem.ToString() = "Employee Attendance Record" Then
            ExportEmployeeAttendance()
        ElseIf lstlist.SelectedItem.ToString() = "Notices" Then
            ExportNotices()
        ElseIf lstlist.SelectedItem.ToString() = "Submitted ID Cords" Then
            ExportIDCard()
        ElseIf lstlist.SelectedItem.ToString() = "User Records" Then
            ExportUserSecurity()
        ElseIf lstlist.SelectedItem.ToString() = "Student Admission Records" Then
            ExportStudentAdmission()
        ElseIf lstlist.SelectedItem.ToString() = "Student Pre-Admission Records" Then
            ExportStudentPreAdmission()
        ElseIf lstlist.SelectedItem.ToString() = "Student Registration Records" Then
            ExportStudentRegistration()
        ElseIf lstlist.SelectedItem.ToString() = "Terms & Fees" Then
            ExportCourseTermsFees()
        ElseIf lstlist.SelectedItem.ToString() = "Yearly Fees" Then
            ExportYearlyFees()
        ElseIf lstlist.SelectedItem.ToString() = "Monthly Fees" Then
            ExportMonthlyFees()
        ElseIf lstlist.SelectedItem.ToString() = "Late Fees" Then
            ExportLateFees()
        ElseIf lstlist.SelectedItem.ToString() = "Library Fees" Then
            ExportLibraryFees()
        ElseIf lstlist.SelectedItem.ToString() = "Examination Fees" Then
            ExportExamFees()
        ElseIf lstlist.SelectedItem.ToString() = "Other Fees" Then
            ExportOtherFees()
        ElseIf lstlist.SelectedItem.ToString() = "Discount Records" Then
            ExportDiscount()
        ElseIf lstlist.SelectedItem.ToString() = "Financial Loan Application Records" Then
            ExportFinancialLoan()
        ElseIf lstlist.SelectedItem.ToString() = "Incomes & Expenditures" Then
            ExportIncomeExpenditure()
        ElseIf lstlist.SelectedItem.ToString() = "Accounting Managements" Then
            ExportAccountingManagement()
        ElseIf lstlist.SelectedItem.ToString() = "Bank Deposits" Then
            ExportAccountingManagement()
        ElseIf lstlist.SelectedItem.ToString() = "Courses" Then
            ExportCourseTermsFees()
        ElseIf lstlist.SelectedItem.ToString() = "Subjects" Then
            Exportsubjects()
        ElseIf lstlist.SelectedItem.ToString() = "Syllabus" Then
            ExportSyllabus()
        ElseIf lstlist.SelectedItem.ToString() = "Assignments" Then
            ExportAssignments()
        ElseIf lstlist.SelectedItem.ToString() = "Examinations" Then
            ExportExamination()
        ElseIf lstlist.SelectedItem.ToString() = "Online Examinations" Then
            ExportOnlineExamQsn()
        ElseIf lstlist.SelectedItem.ToString() = "Progress Report" Then
            ExportProgressReport()
        ElseIf lstlist.SelectedItem.ToString() = "Marksheets" Then
            ExportMarksheet()
        ElseIf lstlist.SelectedItem.ToString() = "Alumni Records" Then
            ExportAlumni()
        ElseIf lstlist.SelectedItem.ToString() = "Student Certificates" Then
            ExportStudentCertificates()
        ElseIf lstlist.SelectedItem.ToString() = "Employee Certificates" Then
            ExportEmployeeCertificates()
        ElseIf lstlist.SelectedItem.ToString() = "Inventory Records" Then
            ExportInventory()
        ElseIf lstlist.SelectedItem.ToString() = "Purchase Records" Then
            ExportPurchaseOrder()
        ElseIf lstlist.SelectedItem.ToString() = "Sales Invoice Records" Then
            ExportSalesInvoice()
        ElseIf lstlist.SelectedItem.ToString() = "Games Records" Then
            ExportGames()
        End If
    End Sub
#End Region
#End Region
#Region "Import..."
#Region "Import Employee..."
    Private Sub ImportEmployee()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname1, fname2, fname3, fname4, fname5, fname6, fname7, fname8, fname9 As String
                fname1 = fBrowse.SelectedPath + "\Employee.xls"
                fname2 = fBrowse.SelectedPath + "\EmployeeLanguage.xls"
                fname3 = fBrowse.SelectedPath + "\EmployeeAcademic.xls"
                fname4 = fBrowse.SelectedPath + "\EmployeeTeachingExp.xls"
                fname5 = fBrowse.SelectedPath + "\EmployeeResearchExp.xls"
                fname6 = fBrowse.SelectedPath + "\EmployeeProficiency.xls"
                fname7 = fBrowse.SelectedPath + "\EmployeeProgrammingLang.xls"
                fname8 = fBrowse.SelectedPath + "\EmployeeActivity.xls"
                fname9 = fBrowse.SelectedPath + "\PF.xls"
                ImportEmployee(fname1)
                ImportEmployeeLanguage(fname2)
                ImportEmployeeAcademic(fname3)
                ImportEmployeeTeachingExp(fname4)
                ImportEmployeeResearchExp(fname5)
                ImportEmployeeProficiency(fname6)
                ImportEmployeeProgrammingLang(fname7)
                ImportEmployeeActivity(fname8)
                ImportEmployeePF(fname9)
                My.Computer.FileSystem.DeleteFile(fname1)
                My.Computer.FileSystem.DeleteFile(fname2)
                My.Computer.FileSystem.DeleteFile(fname3)
                My.Computer.FileSystem.DeleteFile(fname4)
                My.Computer.FileSystem.DeleteFile(fname5)
                My.Computer.FileSystem.DeleteFile(fname6)
                My.Computer.FileSystem.DeleteFile(fname7)
                My.Computer.FileSystem.DeleteFile(fname8)
                My.Computer.FileSystem.DeleteFile(fname9)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportEmployee(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteEmployee()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
               cls.ImportEmployee(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), dtExcel.Rows(i)(21).ToString(), dtExcel.Rows(i)(22).ToString(), dtExcel.Rows(i)(23).ToString(), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString(), dtExcel.Rows(i)(26).ToString(), dtExcel.Rows(i)(27).ToString(), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString(), dtExcel.Rows(i)(30).ToString(), CDec(dtExcel.Rows(i)(31).ToString()), CDec(dtExcel.Rows(i)(32).ToString()), dtExcel.Rows(i)(33).ToString(), dtExcel.Rows(i)(34).ToString(), dtExcel.Rows(i)(35).ToString(), dtExcel.Rows(i)(36).ToString(), dtExcel.Rows(i)(37).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportEmployeeLanguage(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteEmployeeLanguage()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportEmployeeLanguage(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportEmployeeAcademic(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteEmployeeAcademic()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportEmployeeAcademic(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CInt(dtExcel.Rows(i)(6).ToString()), dtExcel.Rows(i)(7).ToString(), CDec(dtExcel.Rows(i)(8).ToString()), dtExcel.Rows(i)(9).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportEmployeeTeachingExp(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteEmployeeTeachingExp()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
            cls.ImportEmployeeTeachingExp(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), CInt(dtExcel.Rows(i)(5).ToString()), CInt(dtExcel.Rows(i)(6).ToString()), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), CInt(dtExcel.Rows(i)(9).ToString()), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportEmployeeResearchExp(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteEmployeeReaserchExp()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
            cls.ImportEmployeeReaserchExp(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), CInt(dtExcel.Rows(i)(5).ToString()), CInt(dtExcel.Rows(i)(6).ToString()), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportEmployeeProficiency(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteEmployeeProficiency()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportEmployeeProficiency(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportEmployeeProgrammingLang(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteEmployeeProgrammingLang()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportEmployeeProgrammingLang(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportEmployeeActivity(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteEmployeeActivity()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportEmployeeActivity(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportEmployeePF(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteEmployeePF()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportEmployeePF(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), CDec(dtExcel.Rows(i)(7).ToString()), CDec(dtExcel.Rows(i)(8).ToString()))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Hired Employee..."
    Private Sub ImportHiredEmployee()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\HiredEmployee.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteHiredEmployee()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportHiredEmployee(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), dtExcel.Rows(i)(21).ToString(), dtExcel.Rows(i)(22).ToString(), dtExcel.Rows(i)(23).ToString(), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString(), dtExcel.Rows(i)(26).ToString(), dtExcel.Rows(i)(27).ToString(), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString(), CDec(dtExcel.Rows(i)(30).ToString()), dtExcel.Rows(i)(31).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Retired Employee..."
    Private Sub ImportRetiredEmployee()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname1, fname2, fname3, fname4, fname5, fname6, fname7, fname8, fname9 As String
                fname1 = fBrowse.SelectedPath + "\RetiredEmployee.xls"
                fname2 = fBrowse.SelectedPath + "\RetiredEmployeeLanguage.xls"
                fname3 = fBrowse.SelectedPath + "\RetiredEmployeeAcademic.xls"
                fname4 = fBrowse.SelectedPath + "\RetiredEmployeeTeachingExp.xls"
                fname5 = fBrowse.SelectedPath + "\RetiredEmployeeResearchExp.xls"
                fname6 = fBrowse.SelectedPath + "\RetiredEmployeeProficiency.xls"
                fname7 = fBrowse.SelectedPath + "\RetiredEmployeeProgrammingLang.xls"
                fname8 = fBrowse.SelectedPath + "\RetiredEmployeeActivity.xls"
                fname9 = fBrowse.SelectedPath + "\RetiredPF.xls"
                ImportEmployee(fname1)
                ImportEmployeeLanguage(fname2)
                ImportEmployeeAcademic(fname3)
                ImportEmployeeTeachingExp(fname4)
                ImportEmployeeResearchExp(fname5)
                ImportEmployeeProficiency(fname6)
                ImportEmployeeProgrammingLang(fname7)
                ImportEmployeeActivity(fname8)
                ImportEmployeePF(fname9)
                My.Computer.FileSystem.DeleteFile(fname1)
                My.Computer.FileSystem.DeleteFile(fname2)
                My.Computer.FileSystem.DeleteFile(fname3)
                My.Computer.FileSystem.DeleteFile(fname4)
                My.Computer.FileSystem.DeleteFile(fname5)
                My.Computer.FileSystem.DeleteFile(fname6)
                My.Computer.FileSystem.DeleteFile(fname7)
                My.Computer.FileSystem.DeleteFile(fname8)
                My.Computer.FileSystem.DeleteFile(fname9)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportRetiredEmployee(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteRetiredEmployee()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportRetiredEmployee(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), dtExcel.Rows(i)(21).ToString(), dtExcel.Rows(i)(22).ToString(), dtExcel.Rows(i)(23).ToString(), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString(), dtExcel.Rows(i)(26).ToString(), dtExcel.Rows(i)(27).ToString(), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString(), dtExcel.Rows(i)(30).ToString(), CDec(dtExcel.Rows(i)(31).ToString()), CDec(dtExcel.Rows(i)(32).ToString()), dtExcel.Rows(i)(33).ToString(), dtExcel.Rows(i)(34).ToString(), dtExcel.Rows(i)(35).ToString(), dtExcel.Rows(i)(36).ToString(), dtExcel.Rows(i)(37).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportRetiredEmployeeLanguage(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteRetiredEmployeeLanguage()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportRetiredEmployeeLanguage(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportRetiredEmployeeAcademic(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteRetiredEmployeeAcademic()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportRetiredEmployeeAcademic(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CInt(dtExcel.Rows(i)(6).ToString()), dtExcel.Rows(i)(7).ToString(), CDec(dtExcel.Rows(i)(8).ToString()), dtExcel.Rows(i)(9).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportRetiredEmployeeTeachingExp(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteRetiredEmployeeTeachingExp()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportRetiredEmployeeTeachingExp(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), CInt(dtExcel.Rows(i)(5).ToString()), CInt(dtExcel.Rows(i)(6).ToString()), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), CInt(dtExcel.Rows(i)(9).ToString()), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportRetiredEmployeeResearchExp(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteRetiredEmployeeReaserchExp()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportRetiredEmployeeReaserchExp(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), CInt(dtExcel.Rows(i)(5).ToString()), CInt(dtExcel.Rows(i)(6).ToString()), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportRetiredEmployeeProficiency(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteRetiredEmployeeProficiency()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportRetiredEmployeeProficiency(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportRetiredEmployeeProgrammingLang(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteRetiredEmployeeProgrammingLang()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportRetiredEmployeeProgrammingLang(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportRetiredEmployeeActivity(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteRetiredEmployeeActivity()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportRetiredEmployeeActivity(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportRetiredEmployeePF(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteRetiredEmployeePF()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportRetiredEmployeePF(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), CDec(dtExcel.Rows(i)(7).ToString()), CDec(dtExcel.Rows(i)(8).ToString()))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Student Attendance..."
    Private Sub ImportStudentAttendance()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\StudentAttendance.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteStudentAttendance()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportStudentAttendance(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Employee Attendance..."
    Private Sub ImportEmployeeAttendance()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\EmployeeAttendance.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteEmployeeAttendance()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportEmployeeAttendance(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Notices..."
    Private Sub ImportNotices()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\Notice.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteNotice()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportNotice(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import ID Card..."
    Private Sub ImportIDCard()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\IDCard.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteIDCard()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportIDCard(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import User Security..."
    Private Sub ImportUsers()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname1, fname2 As String
                fname1 = fBrowse.SelectedPath + "\Users.xls"
                fname2 = fBrowse.SelectedPath + "\UserCrystalReport.xls"
                ImportUsers(fname1)
                ImportUserCrystalReport(fname2)
                My.Computer.FileSystem.DeleteFile(fname1)
                My.Computer.FileSystem.DeleteFile(fname2)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportUsers(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteUsers()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportUsers(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), dtExcel.Rows(i)(21).ToString(), dtExcel.Rows(i)(22).ToString(), dtExcel.Rows(i)(23).ToString(), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString(), dtExcel.Rows(i)(26).ToString(), dtExcel.Rows(i)(27).ToString(), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString(), dtExcel.Rows(i)(30).ToString(), dtExcel.Rows(i)(31).ToString(), dtExcel.Rows(i)(32).ToString(), dtExcel.Rows(i)(33).ToString(), dtExcel.Rows(i)(34).ToString(), dtExcel.Rows(i)(35).ToString(), dtExcel.Rows(i)(36).ToString(), dtExcel.Rows(i)(37).ToString(), dtExcel.Rows(i)(38).ToString(), dtExcel.Rows(i)(39).ToString(), dtExcel.Rows(i)(40).ToString(), dtExcel.Rows(i)(41).ToString(), dtExcel.Rows(i)(42).ToString(), dtExcel.Rows(i)(43).ToString(), dtExcel.Rows(i)(44).ToString(), dtExcel.Rows(i)(45).ToString(), dtExcel.Rows(i)(46).ToString(), dtExcel.Rows(i)(47).ToString(), dtExcel.Rows(i)(48).ToString(), dtExcel.Rows(i)(49).ToString(), dtExcel.Rows(i)(50).ToString(), dtExcel.Rows(i)(51).ToString(), dtExcel.Rows(i)(52).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportUserCrystalReport(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteUserCrystalReport()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportUserCrystalReport(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Student Admission..."
    Private Sub ImportStudentAdmission()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname1, fname2 As String
                fname1 = fBrowse.SelectedPath + "\StudentAdmision.xls"
                fname2 = fBrowse.SelectedPath + "\StudentAdmissionExam.xls"
                ImportStudentAdmission(fname1)
                ImportStudentAdmissionExam(fname2)
                My.Computer.FileSystem.DeleteFile(fname1)
                My.Computer.FileSystem.DeleteFile(fname2)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportStudentAdmission(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteStudentAdmision()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportStudentAdmision(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), CInt(dtExcel.Rows(i)(5).ToString()), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), CInt(dtExcel.Rows(i)(11).ToString()), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), CDec(dtExcel.Rows(i)(21).ToString()), CDec(dtExcel.Rows(i)(22).ToString()), dtExcel.Rows(i)(23).ToString(), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString(), dtExcel.Rows(i)(26).ToString(), dtExcel.Rows(i)(27).ToString(), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString(), dtExcel.Rows(i)(30).ToString(), dtExcel.Rows(i)(31).ToString(), dtExcel.Rows(i)(32).ToString(), dtExcel.Rows(i)(33).ToString(), dtExcel.Rows(i)(34).ToString(), dtExcel.Rows(i)(35).ToString(), dtExcel.Rows(i)(36).ToString(), dtExcel.Rows(i)(37).ToString(), dtExcel.Rows(i)(38).ToString(), dtExcel.Rows(i)(39).ToString(), dtExcel.Rows(i)(40).ToString(), CInt(dtExcel.Rows(i)(41).ToString()), dtExcel.Rows(i)(42).ToString(), dtExcel.Rows(i)(43).ToString(), dtExcel.Rows(i)(44).ToString(), dtExcel.Rows(i)(45).ToString(), dtExcel.Rows(i)(46).ToString(), dtExcel.Rows(i)(47).ToString(), dtExcel.Rows(i)(48).ToString(), dtExcel.Rows(i)(49).ToString(), dtExcel.Rows(i)(50).ToString(), dtExcel.Rows(i)(51).ToString(), dtExcel.Rows(i)(52).ToString(), dtExcel.Rows(i)(53).ToString(), dtExcel.Rows(i)(54).ToString(), dtExcel.Rows(i)(55).ToString(), dtExcel.Rows(i)(56).ToString(), dtExcel.Rows(i)(57).ToString(), dtExcel.Rows(i)(58).ToString(), dtExcel.Rows(i)(59).ToString(), dtExcel.Rows(i)(60).ToString(), dtExcel.Rows(i)(61).ToString(), dtExcel.Rows(i)(62).ToString(), dtExcel.Rows(i)(63).ToString(), dtExcel.Rows(i)(64).ToString(), dtExcel.Rows(i)(65).ToString(), dtExcel.Rows(i)(66).ToString(), CInt(dtExcel.Rows(i)(67).ToString()), CInt(dtExcel.Rows(i)(68).ToString()), dtExcel.Rows(i)(69).ToString(), dtExcel.Rows(i)(70).ToString(), dtExcel.Rows(i)(71).ToString(), dtExcel.Rows(i)(72).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportStudentAdmissionExam(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteStudentAdmisionExam()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportStudentAdmisionExam(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), CInt(dtExcel.Rows(i)(12).ToString()), CDec(dtExcel.Rows(i)(13).ToString()), dtExcel.Rows(i)(14).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Student Pre-Admission..."
    Private Sub ImportStudentPreAdmission()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\StudentPreAdmission.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteStudentPreAdmision()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportStudentPreAdmission(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), CInt(dtExcel.Rows(i)(5).ToString()), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), dtExcel.Rows(i)(21).ToString(), dtExcel.Rows(i)(22).ToString(), dtExcel.Rows(i)(23).ToString(), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString(), dtExcel.Rows(i)(26).ToString(), CInt(dtExcel.Rows(i)(27).ToString()), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString(), CDec(dtExcel.Rows(i)(30).ToString()), CDec(dtExcel.Rows(i)(31).ToString()), CDec(dtExcel.Rows(i)(32).ToString()), CDec(dtExcel.Rows(i)(33).ToString()), dtExcel.Rows(i)(34).ToString(), dtExcel.Rows(i)(35).ToString(), dtExcel.Rows(i)(36).ToString(), dtExcel.Rows(i)(37).ToString(), dtExcel.Rows(i)(38).ToString(), dtExcel.Rows(i)(39).ToString(), dtExcel.Rows(i)(40).ToString(), dtExcel.Rows(i)(41).ToString(), dtExcel.Rows(i)(42).ToString(), dtExcel.Rows(i)(43).ToString(), dtExcel.Rows(i)(44).ToString(), dtExcel.Rows(i)(45).ToString(), dtExcel.Rows(i)(46).ToString(), dtExcel.Rows(i)(47).ToString(), dtExcel.Rows(i)(48).ToString(), dtExcel.Rows(i)(49).ToString(), dtExcel.Rows(i)(50).ToString(), dtExcel.Rows(i)(51).ToString(), CInt(dtExcel.Rows(i)(52).ToString()), CInt(dtExcel.Rows(i)(53).ToString()))
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Student Registration..."
    Private Sub ImportStudentRegistration()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\StudentRegistration.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteStudentRegistration()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportStudentRegistration(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), CInt(dtExcel.Rows(i)(5).ToString()), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), CInt(dtExcel.Rows(i)(11).ToString()), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), CDec(dtExcel.Rows(i)(21).ToString()), CDec(dtExcel.Rows(i)(22).ToString()), dtExcel.Rows(i)(23).ToString(), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString(), dtExcel.Rows(i)(26).ToString(), dtExcel.Rows(i)(27).ToString(), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString(), dtExcel.Rows(i)(30).ToString(), dtExcel.Rows(i)(31).ToString(), dtExcel.Rows(i)(32).ToString(), dtExcel.Rows(i)(33).ToString(), dtExcel.Rows(i)(34).ToString(), dtExcel.Rows(i)(35).ToString(), dtExcel.Rows(i)(36).ToString(), dtExcel.Rows(i)(37).ToString(), dtExcel.Rows(i)(38).ToString(), dtExcel.Rows(i)(39).ToString(), dtExcel.Rows(i)(40).ToString(), CInt(dtExcel.Rows(i)(41).ToString()), dtExcel.Rows(i)(42).ToString(), dtExcel.Rows(i)(43).ToString(), dtExcel.Rows(i)(44).ToString(), dtExcel.Rows(i)(45).ToString(), dtExcel.Rows(i)(46).ToString(), dtExcel.Rows(i)(47).ToString(), dtExcel.Rows(i)(48).ToString(), dtExcel.Rows(i)(49).ToString(), dtExcel.Rows(i)(50).ToString(), dtExcel.Rows(i)(51).ToString(), dtExcel.Rows(i)(52).ToString(), dtExcel.Rows(i)(53).ToString(), dtExcel.Rows(i)(54).ToString(), dtExcel.Rows(i)(55).ToString(), dtExcel.Rows(i)(56).ToString(), dtExcel.Rows(i)(57).ToString(), dtExcel.Rows(i)(58).ToString(), dtExcel.Rows(i)(59).ToString(), dtExcel.Rows(i)(60).ToString(), dtExcel.Rows(i)(61).ToString(), dtExcel.Rows(i)(62).ToString(), dtExcel.Rows(i)(63).ToString(), dtExcel.Rows(i)(64).ToString(), dtExcel.Rows(i)(65).ToString(), CInt(dtExcel.Rows(i)(66).ToString()), CInt(dtExcel.Rows(i)(67).ToString()), dtExcel.Rows(i)(68).ToString(), dtExcel.Rows(i)(69).ToString(), dtExcel.Rows(i)(70).ToString(), dtExcel.Rows(i)(71).ToString(), dtExcel.Rows(i)(72).ToString(), dtExcel.Rows(i)(73).ToString(), dtExcel.Rows(i)(74).ToString(), dtExcel.Rows(i)(75).ToString(), dtExcel.Rows(i)(76).ToString(), dtExcel.Rows(i)(77).ToString(), dtExcel.Rows(i)(78).ToString(), dtExcel.Rows(i)(79).ToString(), dtExcel.Rows(i)(80).ToString(), dtExcel.Rows(i)(81).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Terms & Fees..."
    Private Sub ImportCourseTermsFees()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname1, fname2 As String
                fname1 = fBrowse.SelectedPath + "\Course.xls"
                fname2 = fBrowse.SelectedPath + "\CourseTermFees.xls"
                ImportCourseTermsFees(fname1)
                ImportTermsFees(fname2)
                My.Computer.FileSystem.DeleteFile(fname1)
                My.Computer.FileSystem.DeleteFile(fname2)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportCourseTermsFees(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteCourse()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
               cls.ImportCourse(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), CDec(dtExcel.Rows(i)(7).ToString()))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportTermsFees(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteTermsFees()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportTermsFees(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CDec(dtExcel.Rows(i)(6).ToString()), CInt(dtExcel.Rows(i)(7).ToString()))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Yearly Fees..."
    Private Sub ImportYearlyFees()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\YearlyFees.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteYearlyFees()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportYearlyFees(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), CInt(dtExcel.Rows(i)(7).ToString()), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), CDec(dtExcel.Rows(i)(15).ToString()), CDec(dtExcel.Rows(i)(16).ToString()), CDec(dtExcel.Rows(i)(17).ToString()), CDec(dtExcel.Rows(i)(18).ToString()), CDec(dtExcel.Rows(i)(19).ToString()), CDec(dtExcel.Rows(i)(20).ToString()), CDec(dtExcel.Rows(i)(21).ToString()), CDec(dtExcel.Rows(i)(22).ToString()), CDec(dtExcel.Rows(i)(23).ToString()), dtExcel.Rows(i)(24).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Monthly Fees..."
    Private Sub ImportMonthlyFees()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\MonthlyFees.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteMonthlyFees()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportMonthlyFees(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CInt(dtExcel.Rows(i)(6).ToString()), CInt(dtExcel.Rows(i)(7).ToString()), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), CDec(dtExcel.Rows(i)(14).ToString()), CDec(dtExcel.Rows(i)(15).ToString()), CDec(dtExcel.Rows(i)(16).ToString()), CDec(dtExcel.Rows(i)(17).ToString()), CDec(dtExcel.Rows(i)(18).ToString()), CDec(dtExcel.Rows(i)(19).ToString()), CDec(dtExcel.Rows(i)(20).ToString()), CDec(dtExcel.Rows(i)(21).ToString()), dtExcel.Rows(i)(22).ToString(), CDec(dtExcel.Rows(i)(23).ToString()), dtExcel.Rows(i)(24).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Late Fees..."
    Private Sub ImportLateFees()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\LateFees.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteLateFees()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportLateFees(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CInt(dtExcel.Rows(i)(6).ToString()), CInt(dtExcel.Rows(i)(7).ToString()), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), CDec(dtExcel.Rows(i)(16).ToString()), CDec(dtExcel.Rows(i)(17).ToString()), CDec(dtExcel.Rows(i)(18).ToString()), CDec(dtExcel.Rows(i)(19).ToString()), CDec(dtExcel.Rows(i)(20).ToString()), CDec(dtExcel.Rows(i)(21).ToString()), dtExcel.Rows(i)(22).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Library Fees..."
    Private Sub ImportLibraryFees()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\libraryFees.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteLibraryFees()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportLibraryFees(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CInt(dtExcel.Rows(i)(6).ToString()), CInt(dtExcel.Rows(i)(7).ToString()), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), CDec(dtExcel.Rows(i)(15).ToString()), CDec(dtExcel.Rows(i)(16).ToString()), CDec(dtExcel.Rows(i)(17).ToString()), CDec(dtExcel.Rows(i)(18).ToString()), CDec(dtExcel.Rows(i)(19).ToString()), CDec(dtExcel.Rows(i)(20).ToString()), CDec(dtExcel.Rows(i)(21).ToString()), dtExcel.Rows(i)(22).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Exam Fees..."
    Private Sub ImportExamFees()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\ExamFee.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteExamFees()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportExamFees(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CInt(dtExcel.Rows(i)(6).ToString()), CInt(dtExcel.Rows(i)(7).ToString()), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), CDec(dtExcel.Rows(i)(16).ToString()), CDec(dtExcel.Rows(i)(17).ToString()), CDec(dtExcel.Rows(i)(18).ToString()), CDec(dtExcel.Rows(i)(19).ToString()), CDec(dtExcel.Rows(i)(20).ToString()), CDec(dtExcel.Rows(i)(21).ToString()), CDec(dtExcel.Rows(i)(22).ToString()), CDec(dtExcel.Rows(i)(23).ToString()), dtExcel.Rows(i)(24).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Other Fees..."
    Private Sub ImportOtherFees()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\OtherFees.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteOtherFees()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportOtherFees(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CInt(dtExcel.Rows(i)(6).ToString()), CInt(dtExcel.Rows(i)(7).ToString()), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), CDec(dtExcel.Rows(i)(16).ToString()), CDec(dtExcel.Rows(i)(17).ToString()), CDec(dtExcel.Rows(i)(18).ToString()), CDec(dtExcel.Rows(i)(19).ToString()), CDec(dtExcel.Rows(i)(20).ToString()), CDec(dtExcel.Rows(i)(21).ToString()), dtExcel.Rows(i)(22).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Discount..."
    Private Sub ImportDiscount()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname1, fname2 As String
                fname1 = fBrowse.SelectedPath + "\Discount.xls"
                fname2 = fBrowse.SelectedPath + "\StudentDiscount.xls"
                ImportDiscount(fname1)
                ImportStudentDiscount(fname2)
                My.Computer.FileSystem.DeleteFile(fname1)
                My.Computer.FileSystem.DeleteFile(fname2)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportDiscount(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteDiscount()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportDiscount(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CInt(dtExcel.Rows(i)(6).ToString()), CInt(dtExcel.Rows(i)(7).ToString()), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), CDec(dtExcel.Rows(i)(13).ToString()), CDec(dtExcel.Rows(i)(14).ToString()), CDec(dtExcel.Rows(i)(15).ToString()), CDec(dtExcel.Rows(i)(16).ToString()), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportStudentDiscount(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteDiscountStudent()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportDiscountStudent(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), CDec(dtExcel.Rows(i)(10).ToString()))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Financial Loan..."
    Private Sub ImportFinancialLoan()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\FinancialLoan.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteFinancialLoan()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportFinancialLoan(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), dtExcel.Rows(i)(21).ToString(), dtExcel.Rows(i)(22).ToString(), dtExcel.Rows(i)(23).ToString(), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString(), dtExcel.Rows(i)(26).ToString(), dtExcel.Rows(i)(27).ToString(), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Income Expenditure..."
    Private Sub ImportIncomeExpenditure()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\IncomeExpenditure.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteIncomeExpenditure()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportIncomeExpenditure(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), CDec(dtExcel.Rows(i)(7).ToString()), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), CInt(dtExcel.Rows(i)(12).ToString()), CInt(dtExcel.Rows(i)(13).ToString()), dtExcel.Rows(i)(14).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Accounting Management..."
    Private Sub ImportAccountingManagement()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname1, fname2 As String
                fname1 = fBrowse.SelectedPath + "\Accounts.xls"
                fname2 = fBrowse.SelectedPath + "\BankDeposit.xls"
                ImportAccountingManagement(fname1)
                ImportBankDeposit(fname2)
                My.Computer.FileSystem.DeleteFile(fname1)
                My.Computer.FileSystem.DeleteFile(fname2)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportAccountingManagement(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteAccounts()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportAccounts(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CDec(dtExcel.Rows(i)(6).ToString()))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportBankDeposit(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteBankDeposit()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportBankDeposit(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CDec(dtExcel.Rows(i)(6).ToString()), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Subjects..."
    Private Sub ImportSubjects()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\Subjects.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteSubject()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportSubject(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), CInt(dtExcel.Rows(i)(9).ToString()), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), CInt(dtExcel.Rows(i)(14).ToString()), dtExcel.Rows(i)(15).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Syllabus..."
    Private Sub ImportSyllabus()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\Syllabus.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteSyllabus()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                   cls.ImportSyllabus(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), CInt(dtExcel.Rows(i)(11).ToString()), CInt(dtExcel.Rows(i)(12).ToString()), CInt(dtExcel.Rows(i)(13).ToString()), CInt(dtExcel.Rows(i)(14).ToString()))
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Assignments..."
    Private Sub ImportAssignments()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\Assignment.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteAssignment()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportAssignment(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Examination..."
    Private Sub ImportExamination()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname1, fname2, fname3 As String
                fname1 = fBrowse.SelectedPath + "\Examination.xls"
                fname2 = fBrowse.SelectedPath + "\ExamStudents.xls"
                fname3 = fBrowse.SelectedPath + "\ExamGuard.xls"
                ImportExamination(fname1)
                ImportExaminationStudent(fname2)
                ImportExaminationGuard(fname3)
                My.Computer.FileSystem.DeleteFile(fname1)
                My.Computer.FileSystem.DeleteFile(fname2)
                My.Computer.FileSystem.DeleteFile(fname3)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportExamination(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteExamination()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportExamination(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportExaminationStudent(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteExaminationStudent()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportExaminationStudent(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportExaminationGuard(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteExaminationGuard()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportExaminationGuard(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Online Examination..."
    Private Sub ImportOnlineExamQsn()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname1, fname2 As String
                fname1 = fBrowse.SelectedPath + "\OnlineExamQsn.xls"
                fname2 = fBrowse.SelectedPath + "\OnlineExam.xls"
                ImportDiscount(fname1)
                ImportStudentDiscount(fname2)
                My.Computer.FileSystem.DeleteFile(fname1)
                My.Computer.FileSystem.DeleteFile(fname2)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportOnlineExamQsn(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteOnlineExaminationQsn()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportOnlineExaminationQsn(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), CInt(dtExcel.Rows(i)(7).ToString()), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportOnlineExam(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteOnlineExamination()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportOnlineExamination(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), CInt(dtExcel.Rows(i)(7).ToString()), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), CInt(dtExcel.Rows(i)(13).ToString()), CInt(dtExcel.Rows(i)(14).ToString()), CInt(dtExcel.Rows(i)(15).ToString()))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Progress Report..."
    Private Sub ImportProgressReport()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\ProgressReport.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteProgressReport()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportProgressReport(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Marksheets..."
    Private Sub ImportMarksheets()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\Marksheet.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteMarksheet()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportMarksheet(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), CDec(dtExcel.Rows(i)(14).ToString()), CDec(dtExcel.Rows(i)(15).ToString()))
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Alumni..."
    Private Sub ImportAlumni()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\Alumni.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteAlumni()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportAlumni(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), CInt(dtExcel.Rows(i)(5).ToString()), CInt(dtExcel.Rows(i)(6).ToString()), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), CInt(dtExcel.Rows(i)(12).ToString()), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), dtExcel.Rows(i)(21).ToString(), CDec(dtExcel.Rows(i)(22).ToString()), CDec(dtExcel.Rows(i)(23).ToString()), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString(), dtExcel.Rows(i)(26).ToString(), dtExcel.Rows(i)(27).ToString(), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString(), dtExcel.Rows(i)(30).ToString(), dtExcel.Rows(i)(31).ToString(), dtExcel.Rows(i)(32).ToString(), dtExcel.Rows(i)(33).ToString(), dtExcel.Rows(i)(34).ToString(), dtExcel.Rows(i)(35).ToString(), dtExcel.Rows(i)(36).ToString(), dtExcel.Rows(i)(37).ToString(), dtExcel.Rows(i)(38).ToString(), dtExcel.Rows(i)(39).ToString(), dtExcel.Rows(i)(40).ToString(), dtExcel.Rows(i)(41).ToString(), CInt(dtExcel.Rows(i)(42).ToString()), dtExcel.Rows(i)(43).ToString(), dtExcel.Rows(i)(44).ToString(), dtExcel.Rows(i)(45).ToString(), dtExcel.Rows(i)(46).ToString(), dtExcel.Rows(i)(47).ToString(), dtExcel.Rows(i)(48).ToString(), dtExcel.Rows(i)(49).ToString(), dtExcel.Rows(i)(50).ToString(), dtExcel.Rows(i)(51).ToString(), dtExcel.Rows(i)(52).ToString(), dtExcel.Rows(i)(53).ToString(), dtExcel.Rows(i)(54).ToString(), dtExcel.Rows(i)(55).ToString(), dtExcel.Rows(i)(56).ToString(), dtExcel.Rows(i)(57).ToString(), dtExcel.Rows(i)(58).ToString(), dtExcel.Rows(i)(59).ToString(), dtExcel.Rows(i)(60).ToString(), dtExcel.Rows(i)(61).ToString(), dtExcel.Rows(i)(62).ToString(), dtExcel.Rows(i)(63).ToString(), dtExcel.Rows(i)(64).ToString(), dtExcel.Rows(i)(65).ToString(), dtExcel.Rows(i)(66).ToString(), CInt(dtExcel.Rows(i)(67).ToString()), CInt(dtExcel.Rows(i)(68).ToString()), dtExcel.Rows(i)(69).ToString(), dtExcel.Rows(i)(70).ToString(), dtExcel.Rows(i)(71).ToString(), dtExcel.Rows(i)(72).ToString(), dtExcel.Rows(i)(73).ToString(), dtExcel.Rows(i)(74).ToString(), dtExcel.Rows(i)(75).ToString(), dtExcel.Rows(i)(76).ToString(), dtExcel.Rows(i)(77).ToString(), dtExcel.Rows(i)(78).ToString(), dtExcel.Rows(i)(79).ToString(), dtExcel.Rows(i)(80).ToString(), dtExcel.Rows(i)(81).ToString(), dtExcel.Rows(i)(82).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Student Certificates..."
    Private Sub ImportStudentCertificates()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\StudentCertificate.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteStudentCertificate()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportStudentCertificate(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Employee Certificates..."
    Private Sub ImportEmployeeCertificates()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\EmployeeCertificate.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteEmployeeCertificate()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportEmployeeCertificate(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Inventory..."
    Private Sub ImportInventory()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname1, fname2, fname3 As String
                fname1 = fBrowse.SelectedPath + "\Inventory.xls"
                fname2 = fBrowse.SelectedPath + "\InventoryHistory.xls"
                fname3 = fBrowse.SelectedPath + "\InventoryItemPriceLevel.xls"
                ImportInventory(fname1)
                ImportInventoryHistory(fname2)
                ImportInventoryItemPriceLevel(fname3)
                My.Computer.FileSystem.DeleteFile(fname1)
                My.Computer.FileSystem.DeleteFile(fname2)
                My.Computer.FileSystem.DeleteFile(fname3)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportInventory(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteInventory()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportInventory(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), CDec(dtExcel.Rows(i)(13).ToString()), CDec(dtExcel.Rows(i)(14).ToString()), dtExcel.Rows(i)(15).ToString(), CDec(dtExcel.Rows(i)(16).ToString()), dtExcel.Rows(i)(17).ToString(), CDec(dtExcel.Rows(i)(18).ToString()), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), dtExcel.Rows(i)(21).ToString(), dtExcel.Rows(i)(22).ToString(), CDec(dtExcel.Rows(i)(23).ToString()), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString(), dtExcel.Rows(i)(26).ToString(), dtExcel.Rows(i)(27).ToString(), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString(), dtExcel.Rows(i)(30).ToString(), dtExcel.Rows(i)(31).ToString(), dtExcel.Rows(i)(32).ToString(), dtExcel.Rows(i)(33).ToString(), dtExcel.Rows(i)(34).ToString(), dtExcel.Rows(i)(35).ToString(), dtExcel.Rows(i)(36).ToString(), CDec(dtExcel.Rows(i)(37).ToString()))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportInventoryHistory(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteInventoryHistory()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportInventoryHistory(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), CDec(dtExcel.Rows(i)(8).ToString()), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), CDec(dtExcel.Rows(i)(11).ToString()), dtExcel.Rows(i)(12).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportInventoryItemPriceLevel(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteInventoryPriceLevel()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportInventoryPriceLevel(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), CDec(dtExcel.Rows(i)(7).ToString()), CDec(dtExcel.Rows(i)(8).ToString()), CDec(dtExcel.Rows(i)(9).ToString()), CDec(dtExcel.Rows(i)(10).ToString()), CDec(dtExcel.Rows(i)(11).ToString()), CDec(dtExcel.Rows(i)(12).ToString()), CDec(dtExcel.Rows(i)(13).ToString()), CDec(dtExcel.Rows(i)(14).ToString()), CDec(dtExcel.Rows(i)(15).ToString()), CDec(dtExcel.Rows(i)(16).ToString()), dtExcel.Rows(i)(17).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Purchase Order..."
    Private Sub ImportPurchaseOrder()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\Purchase.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeletePurchaseOrder()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportPurchaseOrder(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), CDec(dtExcel.Rows(i)(15).ToString()), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), CDec(dtExcel.Rows(i)(19).ToString()), dtExcel.Rows(i)(20).ToString(), CDec(dtExcel.Rows(i)(21).ToString()), CDec(dtExcel.Rows(i)(22).ToString()), CDec(dtExcel.Rows(i)(23).ToString()), CDec(dtExcel.Rows(i)(24).ToString()), CDec(dtExcel.Rows(i)(25).ToString()), CDec(dtExcel.Rows(i)(26).ToString()), dtExcel.Rows(i)(27).ToString(), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Sales Invoice..."
    Private Sub ImportSalesInvoice()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\SalesInvoice.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteSalesInvoice()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportSalesInvoice(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), CDec(dtExcel.Rows(i)(11).ToString()), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), CDec(dtExcel.Rows(i)(15).ToString()), dtExcel.Rows(i)(16).ToString(), CDec(dtExcel.Rows(i)(17).ToString()), CDec(dtExcel.Rows(i)(18).ToString()), CDec(dtExcel.Rows(i)(19).ToString()), CDec(dtExcel.Rows(i)(20).ToString()), CDec(dtExcel.Rows(i)(21).ToString()), CDec(dtExcel.Rows(i)(22).ToString()), dtExcel.Rows(i)(23).ToString(), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Games..."
    Private Sub ImportGames()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\Game.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteGame()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportGame(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), CDec(dtExcel.Rows(i)(12).ToString()), dtExcel.Rows(i)(13).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Tables..."
    Private Sub Import()
        If lstlist.SelectedItem.ToString() = "Employee Records" Then
            ImportEmployee()
        ElseIf lstlist.SelectedItem.ToString() = "Hired Employee Records" Then
            ImportHiredEmployee()
        ElseIf lstlist.SelectedItem.ToString() = "Retired Employee Records" Then
            ImportRetiredEmployee()
        ElseIf lstlist.SelectedItem.ToString() = "Student Attendance Record" Then
            ImportStudentAttendance()
        ElseIf lstlist.SelectedItem.ToString() = "Employee Attendance Record" Then
            ImportEmployeeAttendance()
        ElseIf lstlist.SelectedItem.ToString() = "Notices" Then
            ImportNotices()
        ElseIf lstlist.SelectedItem.ToString() = "Submitted ID Cords" Then
            ImportIDCard()
        ElseIf lstlist.SelectedItem.ToString() = "User Records" Then
            ImportUsers()
        ElseIf lstlist.SelectedItem.ToString() = "Student Admission Records" Then
            ImportStudentAdmission()
        ElseIf lstlist.SelectedItem.ToString() = "Student Pre-Admission Records" Then
            ImportStudentPreAdmission()
        ElseIf lstlist.SelectedItem.ToString() = "Student Registration Records" Then
            ImportStudentRegistration()
        ElseIf lstlist.SelectedItem.ToString() = "Terms & Fees" Then
            ImportCourseTermsFees()
        ElseIf lstlist.SelectedItem.ToString() = "Yearly Fees" Then
            ImportYearlyFees()
        ElseIf lstlist.SelectedItem.ToString() = "Monthly Fees" Then
            ImportMonthlyFees()
        ElseIf lstlist.SelectedItem.ToString() = "Late Fees" Then
            ImportLateFees()
        ElseIf lstlist.SelectedItem.ToString() = "Library Fees" Then
            ImportLibraryFees()
        ElseIf lstlist.SelectedItem.ToString() = "Examination Fees" Then
            ImportExamFees()
        ElseIf lstlist.SelectedItem.ToString() = "Other Fees" Then
            ImportOtherFees()
        ElseIf lstlist.SelectedItem.ToString() = "Discount Records" Then
            ImportDiscount()
        ElseIf lstlist.SelectedItem.ToString() = "Financial Loan Application Records" Then
            ImportFinancialLoan()
        ElseIf lstlist.SelectedItem.ToString() = "Incomes & Expenditures" Then
            ImportIncomeExpenditure()
        ElseIf lstlist.SelectedItem.ToString() = "Accounting Managements" Then
            ImportAccountingManagement()
        ElseIf lstlist.SelectedItem.ToString() = "Bank Deposits" Then
            ImportAccountingManagement()
        ElseIf lstlist.SelectedItem.ToString() = "Courses" Then
            ImportCourseTermsFees()
        ElseIf lstlist.SelectedItem.ToString() = "Subjects" Then
            ImportSubjects()
        ElseIf lstlist.SelectedItem.ToString() = "Syllabus" Then
            ImportSyllabus()
        ElseIf lstlist.SelectedItem.ToString() = "Assignments" Then
            ImportAssignments()
        ElseIf lstlist.SelectedItem.ToString() = "Examinations" Then
            ImportExamination()
        ElseIf lstlist.SelectedItem.ToString() = "Online Examinations" Then
            ImportOnlineExamQsn()
        ElseIf lstlist.SelectedItem.ToString() = "Progress Report" Then
            ImportProgressReport()
        ElseIf lstlist.SelectedItem.ToString() = "Marksheets" Then
            ImportMarksheets()
        ElseIf lstlist.SelectedItem.ToString() = "Alumni Records" Then
            ImportAlumni()
        ElseIf lstlist.SelectedItem.ToString() = "Student Certificates" Then
            ImportStudentCertificates()
        ElseIf lstlist.SelectedItem.ToString() = "Employee Certificates" Then
            ImportEmployeeCertificates()
        ElseIf lstlist.SelectedItem.ToString() = "Inventory Records" Then
            ImportInventory()
        ElseIf lstlist.SelectedItem.ToString() = "Purchase Records" Then
            ImportPurchaseOrder()
        ElseIf lstlist.SelectedItem.ToString() = "Sales Invoice Records" Then
            ImportSalesInvoice()
        ElseIf lstlist.SelectedItem.ToString() = "Games Records" Then
            ImportGames()
        End If
    End Sub
#End Region
#End Region
#End Region
#Region "Attributes..."
    Private Sub lblselected_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblselected.TextChanged
        If lblselected.Text = btnactivity.Text Then
            Panel2.BackColor = Color.LightCyan
            lstlist.BackColor = Color.LightCyan
            ERoundedPanel2.BackColor = Color.LightCyan
            btnactivity.BackColor = Color.LightCyan
            LoadActivityList()
            btnadmission.BackColor = Color.Transparent
            btnexamination.BackColor = Color.Transparent
            btnfees.BackColor = Color.Transparent
            btninstitute.BackColor = Color.Transparent
            lstlist.Focus()
        ElseIf lblselected.Text = btnadmission.Text Then
            Panel2.BackColor = Color.Snow
            lstlist.BackColor = Color.Snow
            ERoundedPanel2.BackColor = Color.Snow
            btnadmission.BackColor = Color.Snow
            LoadAdmissionList()
            btnactivity.BackColor = Color.Transparent
            btnexamination.BackColor = Color.Transparent
            btnfees.BackColor = Color.Transparent
            btninstitute.BackColor = Color.Transparent
            lstlist.Focus()
        ElseIf lblselected.Text = btnexamination.Text Then
            Panel2.BackColor = Color.MintCream
            lstlist.BackColor = Color.MintCream
            ERoundedPanel2.BackColor = Color.MintCream
            btnexamination.BackColor = Color.MintCream
            LoadExaminationList()
            btnactivity.BackColor = Color.Transparent
            btnadmission.BackColor = Color.Transparent
            btnfees.BackColor = Color.Transparent
            btninstitute.BackColor = Color.Transparent
            lstlist.Focus()
        ElseIf lblselected.Text = btnfees.Text Then
            Panel2.BackColor = Color.Lavender
            lstlist.BackColor = Color.Lavender
            ERoundedPanel2.BackColor = Color.Lavender
            btnfees.BackColor = Color.Lavender
            LoadFeesList()
            btnactivity.BackColor = Color.Transparent
            btnadmission.BackColor = Color.Transparent
            btnexamination.BackColor = Color.Transparent
            btninstitute.BackColor = Color.Transparent
            lstlist.Focus()
        ElseIf lblselected.Text = btninstitute.Text Then
            Panel2.BackColor = System.Drawing.SystemColors.Info
            lstlist.BackColor = System.Drawing.SystemColors.Info
            ERoundedPanel2.BackColor = System.Drawing.SystemColors.Info
            btninstitute.BackColor = System.Drawing.SystemColors.Info
            LoadInstituteList()
            btnactivity.BackColor = Color.Transparent
            btnadmission.BackColor = Color.Transparent
            btnexamination.BackColor = Color.Transparent
            btnfees.BackColor = Color.Transparent
            lstlist.Focus()
        Else
            btnactivity.BackColor = Color.Transparent
            btnadmission.BackColor = Color.Transparent
            btnexamination.BackColor = Color.Transparent
            btnfees.BackColor = Color.Transparent
            btninstitute.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub lstlist_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstlist.SelectedValueChanged
        If lstlist.SelectedItem.ToString() = "Alumni Records" Then
            lblselecteddetails.Text = "Records of those students who have allready completed their courses i.e. list of past students."
        ElseIf lstlist.SelectedItem.ToString() = "Student Certificates" Then
            lblselecteddetails.Text = "The certificates which are provided by this institute to students."
        ElseIf lstlist.SelectedItem.ToString() = "Employee Certificates" Then
            lblselecteddetails.Text = "The certificates which are provided by this institute to employees."
        ElseIf lstlist.SelectedItem.ToString() = "Inventory Records" Then
            lblselecteddetails.Text = "Records of all inventory items."
        ElseIf lstlist.SelectedItem.ToString() = "Purchase Records" Then
            lblselecteddetails.Text = "Records of all purchase records."
        ElseIf lstlist.SelectedItem.ToString() = "Sales Invoice Records" Then
            lblselecteddetails.Text = "Records of all sales invoices."
        ElseIf lstlist.SelectedItem.ToString() = "Games Records" Then
            lblselecteddetails.Text = "Records of games activity."
        ElseIf lstlist.SelectedItem.ToString() = "Student Admission Records" Then
            lblselecteddetails.Text = "Records of all students took admission, whether they are approved or not."
        ElseIf lstlist.SelectedItem.ToString() = "Student Pre-Admission Records" Then
            lblselecteddetails.Text = "Records of all students took pre-admissions, whether the are approved or not."
        ElseIf lstlist.SelectedItem.ToString() = "Student Registration Records" Then
            lblselecteddetails.Text = "Records of all registered students."
        ElseIf lstlist.SelectedItem.ToString() = "Courses" Then
            lblselecteddetails.Text = "Records of all courses."
        ElseIf lstlist.SelectedItem.ToString() = "Subjects" Then
            lblselecteddetails.Text = "Records of all subjects."
        ElseIf lstlist.SelectedItem.ToString() = "Syllabus" Then
            lblselecteddetails.Text = "Records of all syllabuses."
        ElseIf lstlist.SelectedItem.ToString() = "Assignments" Then
            lblselecteddetails.Text = "Recordds of all assignments."
        ElseIf lstlist.SelectedItem.ToString() = "Examinations" Then
            lblselecteddetails.Text = "Records of examinations."
        ElseIf lstlist.SelectedItem.ToString() = "Online Examinations" Then
            lblselecteddetails.Text = "Records of online examinations."
        ElseIf lstlist.SelectedItem.ToString() = "Progress Report" Then
            lblselecteddetails.Text = "Records of progress reports."
        ElseIf lstlist.SelectedItem.ToString() = "Marksheets" Then
            lblselecteddetails.Text = "Records of submitted marksheets."
        ElseIf lstlist.SelectedItem.ToString() = "Terms & Fees" Then
            lblselecteddetails.Text = "Records of courses and thier corresponding fees."
        ElseIf lstlist.SelectedItem.ToString() = "Yearly Fees" Then
            lblselecteddetails.Text = "Records of collected yearly fees."
        ElseIf lstlist.SelectedItem.ToString() = "Monthly Fees" Then
            lblselecteddetails.Text = "Records of collected monthly fees."
        ElseIf lstlist.SelectedItem.ToString() = "Late Fees" Then
            lblselecteddetails.Text = "Records of collected late fees."
        ElseIf lstlist.SelectedItem.ToString() = "Library Fees" Then
            lblselecteddetails.Text = "Records of collected library fees."
        ElseIf lstlist.SelectedItem.ToString() = "Examination Fees" Then
            lblselecteddetails.Text = "Records of collected examination fees."
        ElseIf lstlist.SelectedItem.ToString() = "Other Fees" Then
            lblselecteddetails.Text = "Records of collected other fees."
        ElseIf lstlist.SelectedItem.ToString() = "Discount Records" Then
            lblselecteddetails.Text = "Records of given discounts."
        ElseIf lstlist.SelectedItem.ToString() = "Financial Loan Application Records" Then
            lblselecteddetails.Text = "Records of students who took education loans."
        ElseIf lstlist.SelectedItem.ToString() = "Incomes & Expenditures" Then
            lblselecteddetails.Text = "Records of revenue year to date."
        ElseIf lstlist.SelectedItem.ToString() = "Accounting Managements" Then
            lblselecteddetails.Text = "Records of all accounts."
        ElseIf lstlist.SelectedItem.ToString() = "Bank Deposits" Then
            lblselecteddetails.Text = "Records of all bank deposits."
        ElseIf lstlist.SelectedItem.ToString() = "Employee Records" Then
            lblselecteddetails.Text = "Records of all employees."
        ElseIf lstlist.SelectedItem.ToString() = "Hired Employee Records" Then
            lblselecteddetails.Text = "Records of all hired employees."
        ElseIf lstlist.SelectedItem.ToString() = "Student Attendance Record" Then
            lblselecteddetails.Text = "Records of student attendances."
        ElseIf lstlist.SelectedItem.ToString() = "Employee Attendance Record" Then
            lblselecteddetails.Text = "Records of employee attendances."
        ElseIf lstlist.SelectedItem.ToString() = "Notices" Then
            lblselecteddetails.Text = "Records of all submitted notices."
        ElseIf lstlist.SelectedItem.ToString() = "Submitted ID Cords" Then
            lblselecteddetails.Text = "Records of all submitted ID cards."
        ElseIf lstlist.SelectedItem.ToString() = "User Records" Then
            lblselecteddetails.Text = "Records of all users."
        Else
            lblselecteddetails.Text = ""
        End If
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmImportExport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblselected.Text = btninstitute.Text
        lstlist.Focus()
        lstlist.SelectedIndex = 0
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btninstitute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninstitute.Click
        lblselected.Text = btninstitute.Text
    End Sub

    Private Sub btnadmission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadmission.Click
        lblselected.Text = btnadmission.Text
    End Sub

    Private Sub btnfees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfees.Click
        lblselected.Text = btnfees.Text
    End Sub

    Private Sub btnexamination_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexamination.Click
        lblselected.Text = btnexamination.Text
    End Sub

    Private Sub btnactivity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnactivity.Click
        lblselected.Text = btnactivity.Text
    End Sub

    Private Sub btnactivity_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnactivity.MouseHover
        lblselected.Text = btnactivity.Text
    End Sub

    Private Sub btnadmission_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnadmission.MouseHover
        lblselected.Text = btnadmission.Text
    End Sub

    Private Sub btnexamination_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnexamination.MouseHover
        lblselected.Text = btnexamination.Text
    End Sub

    Private Sub btnfees_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnfees.MouseHover
        lblselected.Text = btnfees.Text
    End Sub

    Private Sub btninstitute_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btninstitute.MouseHover
        lblselected.Text = btninstitute.Text
    End Sub

    Private Sub btnimport_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnimport.ClickButtonArea
        Import()
    End Sub

    Private Sub btnexport_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnexport.ClickButtonArea
        Export()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region