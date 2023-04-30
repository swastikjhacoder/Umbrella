#Region "Class frmViewEditOtherFees..."
Public Class frmViewEditOtherFees
#Region "Methods..."
    Private Sub LoadDataGrid()
        Try
            Dim i As Integer = 0
            dgviewotherfees.Rows.Clear()
            cmd.CommandText = "select transactionid,date,regno,name,course,totalamt,remaining,paid from OtherFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and SystemDate<='" & UmbrellaSystemDate & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewotherfees.Rows.Add()
                dgviewotherfees.Rows(i).Cells(0).Value = dr("transactionid").ToString()
                dgviewotherfees.Rows(i).Cells(1).Value = dr("date").ToString()
                dgviewotherfees.Rows(i).Cells(2).Value = dr("regno").ToString()
                dgviewotherfees.Rows(i).Cells(3).Value = dr("name").ToString()
                dgviewotherfees.Rows(i).Cells(4).Value = dr("course").ToString()
                Dim amt As Decimal = CDec(dr("totalamt").ToString())
                dgviewotherfees.Rows(i).Cells(5).Value = FormatNumber(amt.ToString())
                Dim remain As Decimal = CDec(dr("remaining").ToString())
                dgviewotherfees.Rows(i).Cells(6).Value = FormatNumber(remain.ToString())
                dgviewotherfees.Rows(i).Cells(7).Value = dr("paid").ToString()
                i = i + 1
            End While
            dr.Close()
            dgviewotherfees.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub TotalFees()
        Try
            Dim row As Integer = dgviewotherfees.Rows.Count
            EGroupBox1.GroupTitle = "Fees List: " + row.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OpenRecords()
        Try
            updateotherfees = True
            Dim k As Integer = dgviewotherfees.CurrentRow.Index
            transactionid = dgviewotherfees.Rows(k).Cells(0).Value.ToString()
            otherdate = dgviewotherfees.Rows(k).Cells(1).Value.ToString()
            StuID = dgviewotherfees.Rows(k).Cells(2).Value.ToString()
            otheramount = CDec(dgviewotherfees.Rows(k).Cells(5).Value.ToString())
            Dim frm As New frmOtherFees()
            frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            frm.WindowState = FormWindowState.Normal
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ControlBox = True
            frm.Show()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmViewEditOtherFees_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadDataGrid()
        TotalFees()
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnexportexcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnexportexcel.ClickButtonArea
        Try
            If ((dgviewotherfees.Columns.Count = 0) Or (dgviewotherfees.Rows.Count = 0)) Then
                Dim result As DialogResult = MessageBox.Show("No record found to export!!!", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    Exit Sub
                End If
            Else
                'Dim Imagefile As String = AppDomain.CurrentDomain.BaseDirectory + "\\ESAR Report.bmp"
                Dim dset As New DataSet
                dset.Tables.Add()
                For i As Integer = 0 To dgviewotherfees.ColumnCount - 1
                    dset.Tables(0).Columns.Add(dgviewotherfees.Columns(i).HeaderText)
                Next
                Dim dr1 As DataRow
                For i As Integer = 0 To dgviewotherfees.RowCount - 1
                    dr1 = dset.Tables(0).NewRow
                    For j As Integer = 0 To dgviewotherfees.Columns.Count - 1
                        dr1(j) = dgviewotherfees.Rows(i).Cells(j).Value
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
        updateotherfees = False
        Dim frm As New frmOtherFees()
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
        TotalFees()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Search..."
    Private Sub SearchRecord()
        Try
            If txtsearch.Text <> "" Then
                If cmbsearch.Text = "Transaction ID" Then
                    Dim i As Integer
                    dgviewotherfees.ClearSelection()
                    For i = 0 To dgviewotherfees.Rows.Count - 1
                        If dgviewotherfees.Rows(i).Cells(1).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewotherfees.Rows(i).Selected = True
                            dgviewotherfees.CurrentCell = dgviewotherfees.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Date" Then
                    Dim i As Integer
                    dgviewotherfees.ClearSelection()
                    For i = 0 To dgviewotherfees.Rows.Count - 1
                        If dgviewotherfees.Rows(i).Cells(0).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewotherfees.Rows(i).Selected = True
                            dgviewotherfees.CurrentCell = dgviewotherfees.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Reg. No." Then
                    Dim i As Integer
                    dgviewotherfees.ClearSelection()
                    For i = 0 To dgviewotherfees.Rows.Count - 1
                        If dgviewotherfees.Rows(i).Cells(1).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewotherfees.Rows(i).Selected = True
                            dgviewotherfees.CurrentCell = dgviewotherfees.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Name" Then
                    Dim i As Integer
                    dgviewotherfees.ClearSelection()
                    For i = 0 To dgviewotherfees.Rows.Count - 1
                        If dgviewotherfees.Rows(i).Cells(2).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewotherfees.Rows(i).Selected = True
                            dgviewotherfees.CurrentCell = dgviewotherfees.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Course" Then
                    Dim i As Integer
                    dgviewotherfees.ClearSelection()
                    For i = 0 To dgviewotherfees.Rows.Count - 1
                        If dgviewotherfees.Rows(i).Cells(3).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewotherfees.Rows(i).Selected = True
                            dgviewotherfees.CurrentCell = dgviewotherfees.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Total Paid" Then
                    Dim i As Integer
                    dgviewotherfees.ClearSelection()
                    For i = 0 To dgviewotherfees.Rows.Count - 1
                        If dgviewotherfees.Rows(i).Cells(4).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewotherfees.Rows(i).Selected = True
                            dgviewotherfees.CurrentCell = dgviewotherfees.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Remaining" Then
                    Dim i As Integer
                    dgviewotherfees.ClearSelection()
                    For i = 0 To dgviewotherfees.Rows.Count - 1
                        If dgviewotherfees.Rows(i).Cells(5).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewotherfees.Rows(i).Selected = True
                            dgviewotherfees.CurrentCell = dgviewotherfees.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Paid" Then
                    Dim i As Integer
                    dgviewotherfees.ClearSelection()
                    For i = 0 To dgviewotherfees.Rows.Count - 1
                        If dgviewotherfees.Rows(i).Cells(6).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewotherfees.Rows(i).Selected = True
                            dgviewotherfees.CurrentCell = dgviewotherfees.Rows(i).Cells(0)
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
    Private Sub dgviewotherfees_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgviewotherfees.CellClick
        Try
            Dim k As Integer = dgviewotherfees.CurrentRow.Index
            dgviewotherfees.Rows(k).Selected = True
            dgviewotherfees.CurrentCell = dgviewotherfees.Rows(k).Cells(0)
            If (e.ColumnIndex) = 0 Then
                OpenRecords()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgviewotherfees_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgviewotherfees.DoubleClick
        Try
            Dim k As Integer = dgviewotherfees.CurrentRow.Index
            dgviewotherfees.Rows(k).Selected = True
            dgviewotherfees.CurrentCell = dgviewotherfees.Rows(k).Cells(0)
            OpenRecords()
        Catch ex As Exception

        End Try
    End Sub
#End Region
End Class
#End Region