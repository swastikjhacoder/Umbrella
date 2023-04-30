#Region "Class frmViewEditCalculateCharges..."
Public Class frmViewEditCalculateCharges
#Region "Methods..."
    Private Sub LoadDataGrid()
        Try
            Dim i As Integer = 0
            dgviewcharges.Rows.Clear()
            cmd.CommandText = "select issueid,date,regno,name,totalcharges from LibraryCharges where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and SystemDate<='" & UmbrellaSystemDate & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewcharges.Rows.Add()
                dgviewcharges.Rows(i).Cells(0).Value = dr("issueid").ToString()
                dgviewcharges.Rows(i).Cells(1).Value = dr("date").ToString()
                dgviewcharges.Rows(i).Cells(2).Value = dr("regno").ToString()
                dgviewcharges.Rows(i).Cells(3).Value = dr("name").ToString()
                Dim chr As Decimal = CDec(dr("totalcharges").ToString())
                dgviewcharges.Rows(i).Cells(4).Value = FormatNumber(chr.ToString())
                i = i + 1
            End While
            dr.Close()
            dgviewcharges.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub TotalCharges()
        Try
            Dim row As Integer = dgviewcharges.Rows.Count
            EGroupBox1.GroupTitle = "Charge List: " + row.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OpenRecords()
        Try
            updatecalculatecharge = True
            Dim k As Integer = dgviewcharges.CurrentRow.Index
            IssedID = dgviewcharges.Rows(k).Cells(0).Value.ToString()
            chargedate = dgviewcharges.Rows(k).Cells(1).Value.ToString()
            StuID = dgviewcharges.Rows(k).Cells(2).Value.ToString()
            StuName = dgviewcharges.Rows(k).Cells(3).Value.ToString()
            totallibrarycharge = CDec(dgviewcharges.Rows(k).Cells(4).Value.ToString())
            Dim frm As New frmCalculateCharges()
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
            If ((dgviewcharges.Columns.Count = 0) Or (dgviewcharges.Rows.Count = 0)) Then
                Dim result As DialogResult = MessageBox.Show("No record found to export!!!", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    Exit Sub
                End If
            Else
                'Dim Imagefile As String = AppDomain.CurrentDomain.BaseDirectory + "\\ESAR Report.bmp"
                Dim dset As New DataSet
                dset.Tables.Add()
                For i As Integer = 0 To dgviewcharges.ColumnCount - 1
                    dset.Tables(0).Columns.Add(dgviewcharges.Columns(i).HeaderText)
                Next
                Dim dr1 As DataRow
                For i As Integer = 0 To dgviewcharges.RowCount - 1
                    dr1 = dset.Tables(0).NewRow
                    For j As Integer = 0 To dgviewcharges.Columns.Count - 1
                        dr1(j) = dgviewcharges.Rows(i).Cells(j).Value
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
        updatecalculatecharge = False
        Dim frm As New frmCalculateCharges()
        frm.ControlBox = True
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.WindowState = FormWindowState.Normal
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ControlBox = True
        frm.Show()
    End Sub

    Private Sub btnopen_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnopen.ClickButtonArea
        OpenRecords()
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        LoadDataGrid()
        TotalCharges()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Search..."
    Private Sub SearchRecord()
        Try
            If txtsearch.Text <> "" Then
                If cmbsearch.Text = "Issue ID" Then
                    Dim i As Integer
                    dgviewcharges.ClearSelection()
                    For i = 0 To dgviewcharges.Rows.Count - 1
                        If dgviewcharges.Rows(i).Cells(0).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewcharges.Rows(i).Selected = True
                            dgviewcharges.CurrentCell = dgviewcharges.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Date" Then
                    Dim i As Integer
                    dgviewcharges.ClearSelection()
                    For i = 0 To dgviewcharges.Rows.Count - 1
                        If dgviewcharges.Rows(i).Cells(1).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewcharges.Rows(i).Selected = True
                            dgviewcharges.CurrentCell = dgviewcharges.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Registration No" Then
                    Dim i As Integer
                    dgviewcharges.ClearSelection()
                    For i = 0 To dgviewcharges.Rows.Count - 1
                        If dgviewcharges.Rows(i).Cells(2).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewcharges.Rows(i).Selected = True
                            dgviewcharges.CurrentCell = dgviewcharges.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Name" Then
                    Dim i As Integer
                    dgviewcharges.ClearSelection()
                    For i = 0 To dgviewcharges.Rows.Count - 1
                        If dgviewcharges.Rows(i).Cells(3).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewcharges.Rows(i).Selected = True
                            dgviewcharges.CurrentCell = dgviewcharges.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Amount" Then
                    Dim i As Integer
                    dgviewcharges.ClearSelection()
                    For i = 0 To dgviewcharges.Rows.Count - 1
                        If dgviewcharges.Rows(i).Cells(4).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewcharges.Rows(i).Selected = True
                            dgviewcharges.CurrentCell = dgviewcharges.Rows(i).Cells(0)
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
    Private Sub dgviewcharges_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgviewcharges.CellClick
        Try
            Dim k As Integer = dgviewcharges.CurrentRow.Index
            dgviewcharges.Rows(k).Selected = True
            dgviewcharges.CurrentCell = dgviewcharges.Rows(k).Cells(0)
            If (e.ColumnIndex) = 0 Then
                OpenRecords()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgviewcharges_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgviewcharges.DoubleClick
        Try
            Dim k As Integer = dgviewcharges.CurrentRow.Index
            dgviewcharges.Rows(k).Selected = True
            dgviewcharges.CurrentCell = dgviewcharges.Rows(k).Cells(0)
            OpenRecords()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmViewEditCalculateCharges_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadDataGrid()
        TotalCharges()
    End Sub
#End Region
End Class
#End Region