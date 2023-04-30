#Region "Class frmViewEditCertificateStudent..."
Public Class frmViewEditCertificateStudent
#Region "Methods..."
    Private Sub LoadDataGrid()
        Try
            Dim i As Integer = 0
            dgviewcertificate.Rows.Clear()
            cmd.CommandText = "select certificateid,regno,name,certificatefor,issuedate from StudentCertificate where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and SystemDate<='" & UmbrellaSystemDate & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewcertificate.Rows.Add()
                dgviewcertificate.Rows(i).Cells(0).Value = dr("certificateid").ToString()
                dgviewcertificate.Rows(i).Cells(1).Value = dr("regno").ToString()
                dgviewcertificate.Rows(i).Cells(2).Value = dr("name").ToString()
                dgviewcertificate.Rows(i).Cells(3).Value = dr("certificatefor").ToString()
                dgviewcertificate.Rows(i).Cells(4).Value = dr("issuedate").ToString()
                i = i + 1
            End While
            dr.Close()
            dgviewcertificate.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub TotalCertificates()
        Try
            Dim row As Integer = dgviewcertificate.Rows.Count
            EGroupBox1.GroupTitle = "Certificate List: " + row.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OpenRecords()
        Try
            updatecertificate = True
            Dim k As Integer = dgviewcertificate.CurrentRow.Index
            certificateid = dgviewcertificate.Rows(k).Cells(0).Value.ToString()
            Dim frm As New frmCertificateStudent()
            frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            frm.WindowState = FormWindowState.Normal
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ControlBox = True
            frm.Show()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnexportexcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnexportexcel.ClickButtonArea
        Try
            If ((dgviewcertificate.Columns.Count = 0) Or (dgviewcertificate.Rows.Count = 0)) Then
                Dim result As DialogResult = MessageBox.Show("No record found to export!!!", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    Exit Sub
                End If
            Else
                'Dim Imagefile As String = AppDomain.CurrentDomain.BaseDirectory + "\\ESAR Report.bmp"
                Dim dset As New DataSet
                dset.Tables.Add()
                For i As Integer = 0 To dgviewcertificate.ColumnCount - 1
                    dset.Tables(0).Columns.Add(dgviewcertificate.Columns(i).HeaderText)
                Next
                Dim dr1 As DataRow
                For i As Integer = 0 To dgviewcertificate.RowCount - 1
                    dr1 = dset.Tables(0).NewRow
                    For j As Integer = 0 To dgviewcertificate.Columns.Count - 1
                        dr1(j) = dgviewcertificate.Rows(i).Cells(j).Value
                    Next
                    dset.Tables(0).Rows.Add(dr1)
                Next
                Dim excel As New Microsoft.Office.Interop.Excel.Application
                Dim wBook As Microsoft.Office.Interop.Excel.Workbook
                Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet
                wBook = excel.Workbooks.Add()
                wSheet = wBook.ActiveSheet()
                Dim dt As System.Data.DataTable = dset.Tables(0)
                Dim dc As System.Data.DataColumn
                Dim dr As System.Data.DataRow
                Dim colIndex As Integer = 0
                Dim rowIndex As Integer = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    excel.Cells(1, colIndex) = dc.ColumnName
                Next
                For Each dr In dt.Rows
                    rowIndex = rowIndex + 1
                    colIndex = 0
                    For Each dc In dt.Columns
                        colIndex = colIndex + 1
                        excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                    Next
                Next
                wSheet.Columns.AutoFit()
                Dim strFileName As String = Date.Now.Day.ToString() + Date.Now.Month.ToString() + Date.Now.Year.ToString() + ".xls"
                Dim blnFileOpen As Boolean = False
                Try
                    Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
                    fileTemp.Close()
                Catch ex As Exception
                    blnFileOpen = False
                End Try
                If System.IO.File.Exists(strFileName) Then
                    System.IO.File.Delete(strFileName)
                End If
                'wSheet.SetBackgroundPicture(Imagefile)
                wBook.SaveAs(strFileName)
                excel.Workbooks.Open(strFileName)
                excel.Visible = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        updatecertificate = False
        Dim frm As New frmCertificateStudent()
        frm.ControlBox = True
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub btnopen_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnopen.ClickButtonArea
        OpenRecords()
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        LoadDataGrid()
        TotalCertificates()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Search..."
    Private Sub SearchRecord()
        Try
            If txtsearch.Text <> "" Then
                If txtsearch.Text <> "Certificate ID" Then
                    Dim i As Integer
                    dgviewcertificate.ClearSelection()
                    For i = 0 To dgviewcertificate.Rows.Count - 1
                        If dgviewcertificate.Rows(i).Cells(0).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewcertificate.Rows(i).Selected = True
                            dgviewcertificate.CurrentCell = dgviewcertificate.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Registration ID" Then
                    Dim i As Integer
                    dgviewcertificate.ClearSelection()
                    For i = 0 To dgviewcertificate.Rows.Count - 1
                        If dgviewcertificate.Rows(i).Cells(1).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewcertificate.Rows(i).Selected = True
                            dgviewcertificate.CurrentCell = dgviewcertificate.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Name" Then
                    Dim i As Integer
                    dgviewcertificate.ClearSelection()
                    For i = 0 To dgviewcertificate.Rows.Count - 1
                        If dgviewcertificate.Rows(i).Cells(2).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewcertificate.Rows(i).Selected = True
                            dgviewcertificate.CurrentCell = dgviewcertificate.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Purpose" Then
                    Dim i As Integer
                    dgviewcertificate.ClearSelection()
                    For i = 0 To dgviewcertificate.Rows.Count - 1
                        If dgviewcertificate.Rows(i).Cells(3).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewcertificate.Rows(i).Selected = True
                            dgviewcertificate.CurrentCell = dgviewcertificate.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Issue Date" Then
                    Dim i As Integer
                    dgviewcertificate.ClearSelection()
                    For i = 0 To dgviewcertificate.Rows.Count - 1
                        If CDec(dgviewcertificate.Rows(i).Cells(4).Value.ToString()) = CDec(txtsearch.Text) Then
                            dgviewcertificate.Rows(i).Selected = True
                            dgviewcertificate.CurrentCell = dgviewcertificate.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Please enter search text!!!", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtsearch.Focus()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Try
            SearchRecord()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnclear_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnclear.ClickButtonArea
        txtsearch.Text = ""
        cmbsearch.Text = ""
        txtsearch.Focus()
    End Sub

    Private Sub cmbsearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnsearch.Focus()
        End If
    End Sub

    Private Sub txtsearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            cmbsearch.Focus()
        End If
    End Sub
#End Region
#Region "DGViewEvents..."
    Private Sub dgviewcertificate_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgviewcertificate.CellClick
        Try
            Dim k As Integer = dgviewcertificate.CurrentRow.Index
            dgviewcertificate.Rows(k).Selected = True
            dgviewcertificate.CurrentCell = dgviewcertificate.Rows(k).Cells(0)
            If (e.ColumnIndex) = 0 Then
                OpenRecords()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgviewcertificate_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgviewcertificate.DoubleClick
        Try
            Dim k As Integer = dgviewcertificate.CurrentRow.Index
            dgviewcertificate.Rows(k).Selected = True
            dgviewcertificate.CurrentCell = dgviewcertificate.Rows(k).Cells(0)
            OpenRecords()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmViewEditCertificateStudent_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadDataGrid()
        TotalCertificates()
    End Sub
#End Region
End Class
#End Region