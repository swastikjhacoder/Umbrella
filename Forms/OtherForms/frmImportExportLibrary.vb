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
#Region "Class frmImportExportLibrary..."
Public Class frmImportExportLibrary
#Region "Methods..."
    Private Sub LoadSystemList()
        lstlist.Items.Clear()
        lstlist.Items.Add("Books Records")
        lstlist.Items.Add("Subject Records")
        lstlist.Items.Add("Group Records")
        lstlist.Items.Add("Submitted Charges Records")
    End Sub

    Private Sub LoadTaskList()
        lstlist.Items.Clear()
        lstlist.Items.Add("Issued Books Records")
        lstlist.Items.Add("Returned Books Records")
        lstlist.Items.Add("Charge Calculations Records")
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
#Region "Export Books..."
    Private Sub ExportBooks()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Books where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Books")
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

                Dim fileName As String = "\Books\Books" + ".xls"
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

                My.Computer.FileSystem.RenameFile(finalPath, "Books.umx")

                Zip(f.SelectedPath + "\Books")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Subjects..."
    Private Sub ExportSubjects()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from SubjectBooks where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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
#Region "Export Groups..."
    Private Sub ExportGroups()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from GroupBooks where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Groups")
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

                Dim fileName As String = "\Groups\Groups" + ".xls"
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

                My.Computer.FileSystem.RenameFile(finalPath, "Groups.umx")

                Zip(f.SelectedPath + "\Groups")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Library Charges..."
    Private Sub ExportLibraryCharges()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from BookCharges where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Library Charges")
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

                Dim fileName As String = "\Library Charges\Library Charges" + ".xls"
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

                My.Computer.FileSystem.RenameFile(finalPath, "Library Charges.umx")

                Zip(f.SelectedPath + "\Library Charges")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Issue Books..."
    Private Sub ExportIssueBooks()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from Issue where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Issue Books")
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

                Dim fileName As String = "\Issue Books\Issue" + ".xls"
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

                My.Computer.FileSystem.RenameFile(finalPath, "Issue.umx")

                ExportIssueBooks(f.SelectedPath + "\Issue Books")

                Zip(f.SelectedPath + "\Issue Books")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ExportIssueBooks(ByVal path As String)
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from IssueBooks where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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
#Region "Export Return Books..."
    Private Sub ExportReturnBooks()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from ReturnBooks where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Return Books")
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

                Dim fileName As String = "\Return Books\Return Books" + ".xls"
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

                My.Computer.FileSystem.RenameFile(finalPath, "Return Books.umx")

                Zip(f.SelectedPath + "\Return Books")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Calculated Library Charges..."
    Private Sub ExportCalculatedLibraryCharges()
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim datatableMain As New System.Data.DataTable()

        cmd.CommandText = "Select * from LibraryCharges where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
        dataAdapter.SelectCommand = cmd

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                IO.Directory.CreateDirectory(f.SelectedPath + "\Calculated Library Charges")
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

                Dim fileName As String = "\Calculated Library Charges\Calculated Library Charges" + ".xls"
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

                My.Computer.FileSystem.RenameFile(finalPath, "Calculated Library Charges.umx")

                Zip(f.SelectedPath + "\Calculated Library Charges")
                MessageBox.Show("Data exported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Export Tables..."
    Private Sub Export()
        If lstlist.SelectedItem.ToString() = "Books Records" Then
            ExportBooks()
        ElseIf lstlist.SelectedItem.ToString() = "Subject Records" Then
            ExportSubjects()
        ElseIf lstlist.SelectedItem.ToString() = "Group Records" Then
            ExportGroups()
        ElseIf lstlist.SelectedItem.ToString() = "Submitted Charges Records" Then
            ExportLibraryCharges()
        ElseIf lstlist.SelectedItem.ToString() = "Issued Books Records" Then
            ExportIssueBooks()
        ElseIf lstlist.SelectedItem.ToString() = "Returned Books Records" Then
            ExportReturnBooks()
        ElseIf lstlist.SelectedItem.ToString() = "Charge Calculations Records" Then
            ExportCalculatedLibraryCharges()
        End If
    End Sub
#End Region
#End Region
#Region "Import..."
#Region "Import Books..."
    Private Sub ImportBooks()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\Books.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteBook()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportBook(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), CInt(dtExcel.Rows(i)(11).ToString()), CInt(dtExcel.Rows(i)(12).ToString()), CDec(dtExcel.Rows(i)(13).ToString()), dtExcel.Rows(i)(14).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
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
                cls.DeleteSubjectBook()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportSubjectBook(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Groups..."
    Private Sub ImportGroups()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\Groups.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteGroup()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportGroup(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Library Charges..."
    Private Sub ImportLibraryCharges()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\Library Charges.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteBookCharges()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportBookCharges(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), CDec(dtExcel.Rows(i)(6).ToString()), CInt(dtExcel.Rows(i)(7).ToString()), CInt(dtExcel.Rows(i)(8).ToString()), CInt(dtExcel.Rows(i)(9).ToString()), CInt(dtExcel.Rows(i)(10).ToString()), CInt(dtExcel.Rows(i)(11).ToString()), CInt(dtExcel.Rows(i)(12).ToString()), CInt(dtExcel.Rows(i)(13).ToString()), CInt(dtExcel.Rows(i)(14).ToString()), CDec(dtExcel.Rows(i)(15).ToString()), CDec(dtExcel.Rows(i)(16).ToString()), CDec(dtExcel.Rows(i)(17).ToString()), CDec(dtExcel.Rows(i)(18).ToString()), CDec(dtExcel.Rows(i)(19).ToString()))
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Issue Books..."
    Private Sub ImportIssueBooks()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname1, fname2 As String
                fname1 = fBrowse.SelectedPath + "\Issue.xls"
                fname2 = fBrowse.SelectedPath + "\IssueBooks.xls"
                ImportIssue(fname1)
                ImportIssueBooks(fname2)
                My.Computer.FileSystem.DeleteFile(fname1)
                My.Computer.FileSystem.DeleteFile(fname2)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportIssue(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteIssue()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportIssue(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString(), dtExcel.Rows(i)(11).ToString(), dtExcel.Rows(i)(12).ToString(), dtExcel.Rows(i)(13).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ImportIssueBooks(ByVal fname As String)
        Try
            Dim dtExcel As New System.Data.DataTable()
            Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
            Dim query As String = "Select * from [Sheet1$]"
            Dim data As New OleDbDataAdapter(query, oconn)
            data.Fill(dtExcel)
            Dim cls As New cImport()
            cls.DeleteIssueBook()
            For i As Integer = 0 To dtExcel.Rows.Count - 1
                cls.ImportIssueBook(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Return Books..."
    Private Sub ImportReturnBooks()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\Return Books.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteReturnBook()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportReturnBook(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), dtExcel.Rows(i)(9).ToString(), dtExcel.Rows(i)(10).ToString())
                Next
                My.Computer.FileSystem.DeleteFile(fname)
                MessageBox.Show("Data imported successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
#End Region
#Region "Import Calculated Library Charges..."
    Private Sub ImportCalculatedLibraryCharges()
        Try
            Dim fBrowse As New FolderBrowserDialog
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                UnZip(fBrowse.SelectedPath)
                RenameFile(fBrowse.SelectedPath)
                Dim fname As String
                fname = fBrowse.SelectedPath + "\Calculated Library Charges.xls"
                Dim dtExcel As New System.Data.DataTable()
                Dim oconn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fname + "';Extended Properties= 'Excel 8.0;HDR=Yes;IMEX=1'")
                Dim query As String = "Select * from [Sheet1$]"
                Dim data As New OleDbDataAdapter(query, oconn)
                data.Fill(dtExcel)
                Dim cls As New cImport()
                cls.DeleteCalculateCharges()
                For i As Integer = 0 To dtExcel.Rows.Count - 1
                    cls.ImportCalculateCharges(dtExcel.Rows(i)(0).ToString(), dtExcel.Rows(i)(1).ToString(), dtExcel.Rows(i)(2).ToString(), UmbrellaSystemDate, dtExcel.Rows(i)(4).ToString(), dtExcel.Rows(i)(5).ToString(), dtExcel.Rows(i)(6).ToString(), dtExcel.Rows(i)(7).ToString(), dtExcel.Rows(i)(8).ToString(), CInt(dtExcel.Rows(i)(9).ToString()), CDec(dtExcel.Rows(i)(10).ToString()), CDec(dtExcel.Rows(i)(11).ToString()), CDec(dtExcel.Rows(i)(12).ToString()), CDec(dtExcel.Rows(i)(13).ToString()), CDec(dtExcel.Rows(i)(14).ToString()), CDec(dtExcel.Rows(i)(15).ToString()), CDec(dtExcel.Rows(i)(16).ToString()), CDec(dtExcel.Rows(i)(17).ToString()), CDec(dtExcel.Rows(i)(18).ToString()), dtExcel.Rows(i)(19).ToString(), CDec(dtExcel.Rows(i)(20).ToString()), dtExcel.Rows(i)(21).ToString(), dtExcel.Rows(i)(22).ToString(), dtExcel.Rows(i)(23).ToString(), dtExcel.Rows(i)(24).ToString(), dtExcel.Rows(i)(25).ToString(), dtExcel.Rows(i)(26).ToString(), dtExcel.Rows(i)(27).ToString(), dtExcel.Rows(i)(28).ToString(), dtExcel.Rows(i)(29).ToString(), dtExcel.Rows(i)(30).ToString(), dtExcel.Rows(i)(31).ToString())
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
        If lstlist.SelectedItem.ToString() = "Books Records" Then
            ImportBooks()
        ElseIf lstlist.SelectedItem.ToString() = "Subject Records" Then
            ImportSubjects()
        ElseIf lstlist.SelectedItem.ToString() = "Group Records" Then
            ImportGroups()
        ElseIf lstlist.SelectedItem.ToString() = "Submitted Charges Records" Then
            ImportLibraryCharges()
        ElseIf lstlist.SelectedItem.ToString() = "Issued Books Records" Then
            ImportIssueBooks()
        ElseIf lstlist.SelectedItem.ToString() = "Returned Books Records" Then
            ImportReturnBooks()
        ElseIf lstlist.SelectedItem.ToString() = "Charge Calculations Records" Then
            ImportCalculatedLibraryCharges()
        End If
    End Sub
#End Region
#End Region
#End Region
#Region "Attributes..."
    Private Sub lblselected_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblselected.TextChanged
        If lblselected.Text = btnsystem.Text Then
            Panel2.BackColor = Color.Lavender
            lstlist.BackColor = Color.Lavender
            ERoundedPanel2.BackColor = Color.Lavender
            btnsystem.BackColor = Color.Lavender
            LoadSystemList()
            btntask.BackColor = Color.Transparent
            lstlist.Focus()
        ElseIf lblselected.Text = btntask.Text Then
            Panel2.BackColor = System.Drawing.SystemColors.Info
            lstlist.BackColor = System.Drawing.SystemColors.Info
            ERoundedPanel2.BackColor = System.Drawing.SystemColors.Info
            btntask.BackColor = System.Drawing.SystemColors.Info
            LoadTaskList()
            btnsystem.BackColor = Color.Transparent
            lstlist.Focus()
        Else
            btnsystem.BackColor = Color.Transparent
            btntask.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub lstlist_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstlist.SelectedValueChanged
        If lstlist.SelectedItem.ToString() = "Books Records" Then
            lblselecteddetails.Text = "Records of all books."
        ElseIf lstlist.SelectedItem.ToString() = "Subject Records" Then
            lblselecteddetails.Text = "Records of all collections of subjects or topics."
        ElseIf lstlist.SelectedItem.ToString() = "Group Records" Then
            lblselecteddetails.Text = "Records of all books group."
        ElseIf lstlist.SelectedItem.ToString() = "Submitted Charges Records" Then
            lblselecteddetails.Text = "Records of all library charges."
        ElseIf lstlist.SelectedItem.ToString() = "Issued Books Records" Then
            lblselecteddetails.Text = "Records of all issued books."
        ElseIf lstlist.SelectedItem.ToString() = "Returned Books Records" Then
            lblselecteddetails.Text = "Records of all returned books."
        ElseIf lstlist.SelectedItem.ToString() = "Charge Calculations Records" Then
            lblselecteddetails.Text = "Records of all library charge calculations."
        Else
            lblselecteddetails.Text = ""
        End If
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmImportExportLibrary_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblselected.Text = btnsystem.Text
        lstlist.Focus()
        lstlist.SelectedIndex = 0
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnsystem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsystem.MouseHover
        lblselected.Text = btnsystem.Text
    End Sub

    Private Sub btntask_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btntask.MouseHover
        lblselected.Text = btntask.Text
    End Sub

    Private Sub btnsystem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsystem.Click
        lblselected.Text = btnsystem.Text
    End Sub

    Private Sub btntask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntask.Click
        lblselected.Text = btntask.Text
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