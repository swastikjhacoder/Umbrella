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
#Region "Class frmImportExportPayroll..."
Public Class frmImportExportPayroll
#Region "Methods..."
    Private Sub LoadSystemList()
        lstlist.Items.Clear()
        lstlist.Items.Add("Department Record")
        lstlist.Items.Add("Designation Record")
        lstlist.Items.Add("Professional Tax Record")
        lstlist.Items.Add("DA/HRA Record")
        lstlist.Items.Add("Pay-Scale Record")
        lstlist.Items.Add("Pay Slip Headers")
    End Sub

    Private Sub LoadPeriodicList()
        lstlist.Items.Clear()
        lstlist.Items.Add("Adjustments/ Deductions Records of Employees")
        lstlist.Items.Add("Working Hours/Day Record")
        lstlist.Items.Add("Salary Calculation Record")
        lstlist.Items.Add("Pay Employee Record")
    End Sub

    Private Sub LoadPFList()
        lstlist.Items.Clear()
        lstlist.Items.Add("Advance/ Withdrawal Records")
        lstlist.Items.Add("Individual PF Rate Record")
        lstlist.Items.Add("Membership Record")
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

#Region "Export..."
#Region "Export Department..."
    Private Sub ExportDepartments()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Department"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Department")
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

                Dim fileName As String = "\Department\Department" + ".xls"
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

                My.Computer.FileSystem.RenameFile(finalPath, "Department.umx")

                Zip(f.SelectedPath + "\Department")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Designation..."
    Private Sub ExportDesignations()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Designation"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Designation")
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

                Dim fileName As String = "\Designation\Designation" + ".xls"
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

                My.Computer.FileSystem.RenameFile(finalPath, "Designation.umx")

                Zip(f.SelectedPath + "\Designation")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Professional Tax..."
    Private Sub ExportProfessionalTax()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from ProfessionalTax"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Professional Tax")
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

                Dim fileName As String = "\Professional Tax\Professional Tax" + ".xls"
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

                My.Computer.FileSystem.RenameFile(finalPath, "Professional Tax.umx")

                Zip(f.SelectedPath + "\Professional Tax")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export DA/HRA..."
    Private Sub ExportDAHRA()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from DaHra"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\DaHra")
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

                Dim fileName As String = "\DaHra\DaHra" + ".xls"
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

                My.Computer.FileSystem.RenameFile(finalPath, "DaHra.umx")

                Zip(f.SelectedPath + "\DaHra")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Pay-Scale..."
    Private Sub ExportPayScale()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from PayScale"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\PayScale")
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

                Dim fileName As String = "\PayScale\PayScale" + ".xls"
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

                My.Computer.FileSystem.RenameFile(finalPath, "PayScale.umx")

                Zip(f.SelectedPath + "\PayScale")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Pay Slip Headers..."
    Private Sub ExportPaySlipHeaders()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from PayslipHeaders"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\PayslipHeaders")
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

                Dim fileName As String = "\PayslipHeaders\PayslipHeaders" + ".xls"
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

                My.Computer.FileSystem.RenameFile(finalPath, "PayslipHeaders.umx")

                Zip(f.SelectedPath + "\PayslipHeaders")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Adjustment/ Deductions..."
    Private Sub ExportAdjustmentDeductions()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from AdjustmentDeductions"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\AdjustmentDeductions")
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

                Dim fileName As String = "\AdjustmentDeductions\AdjustmentDeductions" + ".xls"
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

                My.Computer.FileSystem.RenameFile(finalPath, "AdjustmentDeductions.umx")

                Zip(f.SelectedPath + "\AdjustmentDeductions")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Working Hours/ Day..."
    Private Sub ExportWorkingHoursDay()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from WorkingHourly"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\WorkingHourDay")
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

                Dim fileName As String = "\WorkingHourDay\WorkingHourly" + ".xls"
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

                My.Computer.FileSystem.RenameFile(finalPath, "WorkingHourly.umx")

                WorkingDaily(f.SelectedPath + "\WorkingHourDay")

                Zip(f.SelectedPath + "\WorkingHourDay")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
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
#Region "Export Salary Calculations..."
    Private Sub ExportSalaryCalculations()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Salary"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Salary")
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

                Dim fileName As String = "\Salary\Salary" + ".xls"
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

                My.Computer.FileSystem.RenameFile(finalPath, "Salary.umx")

                Zip(f.SelectedPath + "\Salary")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Pay Employee..."
    Private Sub ExportPayEmployee()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from PayEmployee"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\PayEmployee")
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

                Dim fileName As String = "\PayEmployee\PayEmployee" + ".xls"
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

                My.Computer.FileSystem.RenameFile(finalPath, "PayEmployee.umx")

                Zip(f.SelectedPath + "\PayEmployee")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Advance/ Withdrawal..."
    Private Sub ExportAdvanceWithdrawal()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from PFAdvanceWithdrawal"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\PFAdvanceWithdrawal")
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

                Dim fileName As String = "\PFAdvanceWithdrawal\PFAdvanceWithdrawal" + ".xls"
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

                My.Computer.FileSystem.RenameFile(finalPath, "PFAdvanceWithdrawal.umx")

                Zip(f.SelectedPath + "\PFAdvanceWithdrawal")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Individual PF Rate..."
    Private Sub ExportIndividualPFRate()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from PFRateIndividual"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\PFRateIndividual")
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

                Dim fileName As String = "\PFRateIndividual\PFRateIndividual" + ".xls"
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

                My.Computer.FileSystem.RenameFile(finalPath, "PFRateIndividual.umx")

                Zip(f.SelectedPath + "\PFRateIndividual")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Membership..."
    Private Sub ExportMembershipRecord()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from CloseMembership"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\CloseMembership")
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

                Dim fileName As String = "\CloseMembership\CloseMembership" + ".xls"
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

                My.Computer.FileSystem.RenameFile(finalPath, "CloseMembership.umx")

                Zip(f.SelectedPath + "\CloseMembership")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Table..."
    Private Sub Export()
        If lstlist.SelectedItem.ToString() = "Department Record" Then
            ExportDepartments()
        ElseIf lstlist.SelectedItem.ToString() = "Designation Record" Then
            ExportDesignations()
        ElseIf lstlist.SelectedItem.ToString() = "Professional Tax Record" Then
            ExportProfessionalTax()
        ElseIf lstlist.SelectedItem.ToString() = "DA/HRA Record" Then
            ExportDAHRA()
        ElseIf lstlist.SelectedItem.ToString() = "Pay-Scale Record" Then
            ExportPayScale()
        ElseIf lstlist.SelectedItem.ToString() = "Pay Slip Headers" Then
            ExportPaySlipHeaders()
        ElseIf lstlist.SelectedItem.ToString() = "Adjustments/ Deductions Records of Employees" Then
            ExportAdjustmentDeductions()
        ElseIf lstlist.SelectedItem.ToString() = "Working Hours/Day Record" Then
            ExportWorkingHoursDay()
        ElseIf lstlist.SelectedItem.ToString() = "Salary Calculation Record" Then
            ExportSalaryCalculations()
        ElseIf lstlist.SelectedItem.ToString() = "Pay Employee Record" Then
            ExportPayEmployee()
        ElseIf lstlist.SelectedItem.ToString() = "Advance/ Withdrawal Records" Then
            ExportAdvanceWithdrawal()
        ElseIf lstlist.SelectedItem.ToString() = "Individual PF Rate Record" Then
            ExportIndividualPFRate()
        ElseIf lstlist.SelectedItem.ToString() = "Membership Record" Then
            ExportMembershipRecord()
        End If
    End Sub
#End Region
#End Region
#Region "Import..."
#Region "Import Department..."
    Private Sub ImportDepartment()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\Department.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteDepartment()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportDepartment(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Designation..."
    Private Sub ImportDesignation()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\Designation.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteDesignation()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportDesignation(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Professional Tax..."
    Private Sub ImportProfessionalTax()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\Professional Tax.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteProfTax()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportProfTax(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), CDec(dtExcel.Rows(i)(3).ToString()), CDec(dtExcel.Rows(i)(4).ToString()))
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import DA/ HRA..."
    Private Sub ImportDAHRA()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\DaHra.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteDAHRA()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportDAHRA(CInt(dtExcel.Rows(i)(3).ToString()), dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), CInt(dtExcel.Rows(i)(4).ToString()), CInt(dtExcel.Rows(i)(5).ToString()), CDec(dtExcel.Rows(i)(6).ToString()), CDec(dtExcel.Rows(i)(7).ToString()), CDec(dtExcel.Rows(i)(8).ToString()), CDec(dtExcel.Rows(i)(9).ToString()))
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Pay-Scale..."
    Private Sub ImportPayScale()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\PayScale.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeletePayScale()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportPayScale(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), CDec(dtExcel.Rows(i)(4).ToString()), CDec(dtExcel.Rows(i)(5).ToString()), CDec(dtExcel.Rows(i)(6).ToString()), CDec(dtExcel.Rows(i)(7).ToString()), dtExcel.Rows(i)(8).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Pay Slip Headers..."
    Private Sub ImportPaySlipHeaders()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\PayslipHeaders.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeletePaySlipHeaders()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportPaySlipHeaders(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString(), dtExcel.Rows(i)(14).ToString(), dtExcel.Rows(i)(15).ToString(), dtExcel.Rows(i)(16).ToString(), dtExcel.Rows(i)(17).ToString(), dtExcel.Rows(i)(18).ToString(), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString(), dtExcel.Rows(i)(21).ToString(), dtExcel.Rows(i)(22).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Adjustment/ Deduction..."
    Private Sub ImportAdjustmentDeductions()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\AdjustmentDeductions.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteAdjustmentDeduction()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportAdjustmentDeduction(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), CInt(dtExcel.Rows(i)(4).ToString()), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), CInt(dtExcel.Rows(i)(8).ToString()), CInt(dtExcel.Rows(i)(9).ToString()), CDec(dtExcel.Rows(i)(10).ToString()), CDec(dtExcel.Rows(i)(11).ToString()), CDec(dtExcel.Rows(i)(12).ToString()), CDec(dtExcel.Rows(i)(13).ToString()), CDec(dtExcel.Rows(i)(14).ToString()), CDec(dtExcel.Rows(i)(15).ToString()), CDec(dtExcel.Rows(i)(16).ToString()), CDec(dtExcel.Rows(i)(17).ToString()), CDec(dtExcel.Rows(i)(18).ToString()), CDec(dtExcel.Rows(i)(19).ToString()), CDec(dtExcel.Rows(i)(20).ToString()), CDec(dtExcel.Rows(i)(21).ToString()), CDec(dtExcel.Rows(i)(22).ToString()), CDec(dtExcel.Rows(i)(23).ToString()), CDec(dtExcel.Rows(i)(24).ToString()), CDec(dtExcel.Rows(i)(25).ToString()), CDec(dtExcel.Rows(i)(26).ToString()), CDec(dtExcel.Rows(i)(27).ToString()), CDec(dtExcel.Rows(i)(28).ToString()), CDec(dtExcel.Rows(i)(29).ToString()), CDec(dtExcel.Rows(i)(30).ToString()), CDec(dtExcel.Rows(i)(31).ToString()), CDec(dtExcel.Rows(i)(32).ToString()), CDec(dtExcel.Rows(i)(33).ToString()), CDec(dtExcel.Rows(i)(34).ToString()), CDec(dtExcel.Rows(i)(35).ToString()), dtExcel.Rows(i)(36).ToString(), dtExcel.Rows(i)(37).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Working Hours/ Day..."
    Private Sub ImportWorkingHoursDay()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname1, fname2 As String
                fname1 = fBrowse.SelectedPath + "\WorkingHourly.xls"
                fname2 = fBrowse.SelectedPath + "\WorkingDaily.xls"
                ImportWorkingHours(fname1)
                ImportWorkingDay(fname2)
                My.Computer.FileSystem.DeleteFile(fname1)
                My.Computer.FileSystem.DeleteFile(fname2)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportWorkingHours(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteWorkingHours()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportWorkingHours(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), CInt(dtExcel.Rows(i)(8).ToString()))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportWorkingDay(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteWorkingDay()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportWorkingDay(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Salary Calculations..."
    Private Sub ImportSalaryCalculations()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\Salary.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteSalaryCalculation()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportSalaryCalculation(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), CInt(dtExcel.Rows(i)(4).ToString()), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), CInt(dtExcel.Rows(i)(9).ToString()), CInt(dtExcel.Rows(i)(10).ToString()), CDec(dtExcel.Rows(i)(11).ToString()), CDec(dtExcel.Rows(i)(12).ToString()), CDec(dtExcel.Rows(i)(13).ToString()), CDec(dtExcel.Rows(i)(14).ToString()), CDec(dtExcel.Rows(i)(15).ToString()), CDec(dtExcel.Rows(i)(16).ToString()), CDec(dtExcel.Rows(i)(17).ToString()), CDec(dtExcel.Rows(i)(18).ToString()), CDec(dtExcel.Rows(i)(19).ToString()), CDec(dtExcel.Rows(i)(20).ToString()), CDec(dtExcel.Rows(i)(21).ToString()), CDec(dtExcel.Rows(i)(22).ToString()), CDec(dtExcel.Rows(i)(23).ToString()), CDec(dtExcel.Rows(i)(24).ToString()), CDec(dtExcel.Rows(i)(25).ToString()), CDec(dtExcel.Rows(i)(26).ToString()), CDec(dtExcel.Rows(i)(27).ToString()), CDec(dtExcel.Rows(i)(28).ToString()), CDec(dtExcel.Rows(i)(29).ToString()), CDec(dtExcel.Rows(i)(30).ToString()), CDec(dtExcel.Rows(i)(31).ToString()), CDec(dtExcel.Rows(i)(32).ToString()), CDec(dtExcel.Rows(i)(33).ToString()), CDec(dtExcel.Rows(i)(34).ToString()), CDec(dtExcel.Rows(i)(35).ToString()), CDec(dtExcel.Rows(i)(36).ToString()), CDec(dtExcel.Rows(i)(37).ToString()), CDec(dtExcel.Rows(i)(38).ToString()), CDec(dtExcel.Rows(i)(39).ToString()), CDec(dtExcel.Rows(i)(40).ToString()), CDec(dtExcel.Rows(i)(41).ToString()), CDec(dtExcel.Rows(i)(42).ToString()), CDec(dtExcel.Rows(i)(43).ToString()), CDec(dtExcel.Rows(i)(44).ToString()), CDec(dtExcel.Rows(i)(45).ToString()), CDec(dtExcel.Rows(i)(46).ToString()), CDec(dtExcel.Rows(i)(47).ToString()), CDec(dtExcel.Rows(i)(48).ToString()), CDec(dtExcel.Rows(i)(49).ToString()), CDec(dtExcel.Rows(i)(50).ToString()), CDec(dtExcel.Rows(i)(51).ToString()), CDec(dtExcel.Rows(i)(52).ToString()), dtExcel.Rows(i)(53).ToString(), dtExcel.Rows(i)(54).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Pay Employee..."
    Private Sub ImportPayEmployee()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\PayEmployee.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeletePayEmployee()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportPayEmployee(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), CInt(dtExcel.Rows(i)(5).ToString()), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), CDec(dtExcel.Rows(i)(11).ToString()), CDec(dtExcel.Rows(i)(12).ToString()), CDec(dtExcel.Rows(i)(13).ToString()), CDec(dtExcel.Rows(i)(14).ToString()), CDec(dtExcel.Rows(i)(15).ToString()), CDec(dtExcel.Rows(i)(16).ToString()), CDec(dtExcel.Rows(i)(17).ToString()), CDec(dtExcel.Rows(i)(18).ToString()), dtExcel.Rows(i)(19).ToString(), dtExcel.Rows(i)(20).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Advance/ Withdrawal..."
    Private Sub ImportAdvanceWithdrawal()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\PFAdvanceWithdrawal.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteAdvanceWithdrawal()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportAdvanceWithdrawal(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CDec(dtExcel.Rows(i)(6).ToString()), dtExcel.Rows(i)(7).ToString(), CDec(dtExcel.Rows(i)(8).ToString()), dtExcel.Rows(i)(9).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Individual PF Rate..."
    Private Sub ImportIndividualPFRate()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\PFRateIndividual.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteIndividualPFRate()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportIndividualPFRate(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), CInt(dtExcel.Rows(i)(3).ToString()), dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CDec(dtExcel.Rows(i)(6).ToString()), CDec(dtExcel.Rows(i)(7).ToString()))
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Membership..."
    Private Sub ImportMembership()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\CloseMembership.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteMembership()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportMembership(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), dtExcel.Rows(i)(3).ToString(), dtExcel.Rows(i)(4).ToString(), CDec(dtExcel.Rows(i)(5).ToString()), CDec(dtExcel.Rows(i)(6).ToString()), dtExcel.Rows(i)(7).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Table..."
    Private Sub Import()
        If lstlist.SelectedItem.ToString() = "Department Record" Then
            ImportDepartment()
        ElseIf lstlist.SelectedItem.ToString() = "Designation Record" Then
            ImportDesignation()
        ElseIf lstlist.SelectedItem.ToString() = "Professional Tax Record" Then
            ImportProfessionalTax()
        ElseIf lstlist.SelectedItem.ToString() = "DA/HRA Record" Then
            ImportDAHRA()
        ElseIf lstlist.SelectedItem.ToString() = "Pay-Scale Record" Then
            ImportPayScale()
        ElseIf lstlist.SelectedItem.ToString() = "Pay Slip Headers" Then
            ImportPaySlipHeaders()
        ElseIf lstlist.SelectedItem.ToString() = "Adjustments/ Deductions Records of Employees" Then
            ImportAdjustmentDeductions()
        ElseIf lstlist.SelectedItem.ToString() = "Working Hours/Day Record" Then
            ImportWorkingHoursDay()
        ElseIf lstlist.SelectedItem.ToString() = "Salary Calculation Record" Then
            ImportSalaryCalculations()
        ElseIf lstlist.SelectedItem.ToString() = "Pay Employee Record" Then
            ImportPayEmployee()
        ElseIf lstlist.SelectedItem.ToString() = "Advance/ Withdrawal Records" Then
            ImportAdvanceWithdrawal()
        ElseIf lstlist.SelectedItem.ToString() = "Individual PF Rate Record" Then
            ImportIndividualPFRate()
        ElseIf lstlist.SelectedItem.ToString() = "Membership Record" Then
            ImportMembership()
        End If
    End Sub
#End Region
#End Region
#End Region
#Region "Attributes..."
    Private Sub lblselected_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblselected.TextChanged
        If lblselected.Text = btnperiodic.Text Then
            Panel2.BackColor = Color.MintCream
            lstlist.BackColor = Color.MintCream
            ERoundedPanel2.BackColor = Color.MintCream
            btnperiodic.BackColor = Color.MintCream
            LoadPeriodicList()
            btnpf.BackColor = Color.Transparent
            btnsystem.BackColor = Color.Transparent
            lstlist.Focus()
        ElseIf lblselected.Text = btnpf.Text Then
            Panel2.BackColor = Color.Lavender
            lstlist.BackColor = Color.Lavender
            ERoundedPanel2.BackColor = Color.Lavender
            btnpf.BackColor = Color.Lavender
            LoadPFList()
            btnperiodic.BackColor = Color.Transparent
            btnsystem.BackColor = Color.Transparent
            lstlist.Focus()
        ElseIf lblselected.Text = btnsystem.Text Then
            Panel2.BackColor = System.Drawing.SystemColors.Info
            lstlist.BackColor = System.Drawing.SystemColors.Info
            ERoundedPanel2.BackColor = System.Drawing.SystemColors.Info
            btnsystem.BackColor = System.Drawing.SystemColors.Info
            LoadSystemList()
            btnperiodic.BackColor = Color.Transparent
            btnpf.BackColor = Color.Transparent
            lstlist.Focus()
        Else
            btnperiodic.BackColor = Color.Transparent
            btnpf.BackColor = Color.Transparent
            btnsystem.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub lstlist_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstlist.SelectedValueChanged
        If lstlist.SelectedItem.ToString() = "Department Record" Then
            lblselecteddetails.Text = "Records of all departments."
        ElseIf lstlist.SelectedItem.ToString() = "Designation Record" Then
            lblselecteddetails.Text = "Records of all employee designations."
        ElseIf lstlist.SelectedItem.ToString() = "Professional Tax Record" Then
            lblselecteddetails.Text = "Records of announced professional tax."
        ElseIf lstlist.SelectedItem.ToString() = "DA/HRA Record" Then
            lblselecteddetails.Text = "Records of all announced DA/HRA."
        ElseIf lstlist.SelectedItem.ToString() = "Pay-Scale Record" Then
            lblselecteddetails.Text = "Records of all employee pay-scales."
        ElseIf lstlist.SelectedItem.ToString() = "Pay Slip Headers" Then
            lblselecteddetails.Text = "Records of headers printed on pay-slip."
        ElseIf lstlist.SelectedItem.ToString() = "Adjustments/ Deductions Records of Employees" Then
            lblselecteddetails.Text = "Records of all adjustments and deductions of employees of a specific month."
        ElseIf lstlist.SelectedItem.ToString() = "Working Hours/Day Record" Then
            lblselecteddetails.Text = "Records of all hired-employees working hours."
        ElseIf lstlist.SelectedItem.ToString() = "Salary Calculation Record" Then
            lblselecteddetails.Text = "Records of employee salary calculations."
        ElseIf lstlist.SelectedItem.ToString() = "Pay Employee Record" Then
            lblselecteddetails.Text = "Records of employee payments."
        ElseIf lstlist.SelectedItem.ToString() = "Advance/ Withdrawal Records" Then
            lblselecteddetails.Text = "Records of advances and withdrawal amounts from pf."
        ElseIf lstlist.SelectedItem.ToString() = "Individual PF Rate Record" Then
            lblselecteddetails.Text = "Records of own subscribed pf rate."
        ElseIf lstlist.SelectedItem.ToString() = "Membership Record" Then
            lblselecteddetails.Text = "Records of all pf memberships."
        Else
            lblselecteddetails.Text = ""
        End If
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmImportExportPayroll_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblselected.Text = btnsystem.Text
        lstlist.Focus()
        lstlist.SelectedIndex = 0
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnsystem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsystem.Click
        lblselected.Text = btnsystem.Text
    End Sub

    Private Sub btnperiodic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnperiodic.Click
        lblselected.Text = btnperiodic.Text
    End Sub

    Private Sub btnpf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpf.Click
        lblselected.Text = btnpf.Text
    End Sub

    Private Sub btnsystem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsystem.MouseHover
        lblselected.Text = btnsystem.Text
    End Sub

    Private Sub btnperiodic_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnperiodic.MouseHover
        lblselected.Text = btnperiodic.Text
    End Sub

    Private Sub btnpf_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnpf.MouseHover
        lblselected.Text = btnpf.Text
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