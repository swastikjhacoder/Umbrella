#Region "Class frmViewEditInventoryItems..."
Public Class frmViewEditInventoryItems
#Region "Methods..."
    Private Sub LoadDataGrid()
        Try
            Dim i As Integer = 0
            dgviewinventory.Rows.Clear()
            cmd.CommandText = "select itemid,itemname,itemclass,descripbrief,itemsize,itemshape,levelprice,onhandqnty from Inventory where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and SystemDate<='" & UmbrellaSystemDate & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewinventory.Rows.Add()
                dgviewinventory.Rows(i).Cells(0).Value = dr("itemid").ToString()
                dgviewinventory.Rows(i).Cells(1).Value = dr("itemname").ToString()
                dgviewinventory.Rows(i).Cells(2).Value = dr("itemclass").ToString()
                dgviewinventory.Rows(i).Cells(3).Value = dr("descripbrief").ToString()
                dgviewinventory.Rows(i).Cells(4).Value = dr("itemsize").ToString()
                dgviewinventory.Rows(i).Cells(5).Value = dr("itemshape").ToString()
                Dim prc As Decimal = CDec(dr("levelprice").ToString())
                dgviewinventory.Rows(i).Cells(6).Value = FormatNumber(prc.ToString())
                Dim qnty As Decimal = CDec(dr("onhandqnty").ToString())
                dgviewinventory.Rows(i).Cells(7).Value = FormatNumber(qnty.ToString())
                i = i + 1
            End While
            dr.Close()
            dgviewinventory.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub TotalInventory()
        Try
            Dim row As Integer = dgviewinventory.Rows.Count
            EGroupBox1.GroupTitle = "Inventory List: " + row.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OpenRecords()
        Try
            updateinventory = True
            Dim k As Integer = dgviewinventory.CurrentRow.Index
            itemid = dgviewinventory.Rows(k).Cells(0).Value.ToString()
            itemname = dgviewinventory.Rows(k).Cells(1).Value.ToString()
            Dim frm As New frmAddInventoryItem()
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
            If ((dgviewinventory.Columns.Count = 0) Or (dgviewinventory.Rows.Count = 0)) Then
                Dim result As DialogResult = MessageBox.Show("No record found to export!!!", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    Exit Sub
                End If
            Else
                'Dim Imagefile As String = AppDomain.CurrentDomain.BaseDirectory + "\\ESAR Report.bmp"
                Dim dset As New DataSet
                dset.Tables.Add()
                For i As Integer = 0 To dgviewinventory.ColumnCount - 1
                    dset.Tables(0).Columns.Add(dgviewinventory.Columns(i).HeaderText)
                Next
                Dim dr1 As DataRow
                For i As Integer = 0 To dgviewinventory.RowCount - 1
                    dr1 = dset.Tables(0).NewRow
                    For j As Integer = 0 To dgviewinventory.Columns.Count - 1
                        dr1(j) = dgviewinventory.Rows(i).Cells(j).Value
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
        updateinventory = False
        Dim frm As New frmAddInventoryItem()
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
        TotalInventory()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Search..."
    Private Sub SearchRecord()
        Try
            If txtsearch.Text <> "" Then
                If txtsearch.Text <> "Item ID" Then
                    Dim i As Integer
                    dgviewinventory.ClearSelection()
                    For i = 0 To dgviewinventory.Rows.Count - 1
                        If dgviewinventory.Rows(i).Cells(0).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewinventory.Rows(i).Selected = True
                            dgviewinventory.CurrentCell = dgviewinventory.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Item Name" Then
                    Dim i As Integer
                    dgviewinventory.ClearSelection()
                    For i = 0 To dgviewinventory.Rows.Count - 1
                        If dgviewinventory.Rows(i).Cells(1).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewinventory.Rows(i).Selected = True
                            dgviewinventory.CurrentCell = dgviewinventory.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Item Class" Then
                    Dim i As Integer
                    dgviewinventory.ClearSelection()
                    For i = 0 To dgviewinventory.Rows.Count - 1
                        If dgviewinventory.Rows(i).Cells(2).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewinventory.Rows(i).Selected = True
                            dgviewinventory.CurrentCell = dgviewinventory.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Description" Then
                    Dim i As Integer
                    dgviewinventory.ClearSelection()
                    For i = 0 To dgviewinventory.Rows.Count - 1
                        If dgviewinventory.Rows(i).Cells(3).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewinventory.Rows(i).Selected = True
                            dgviewinventory.CurrentCell = dgviewinventory.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Size" Then
                    Dim i As Integer
                    dgviewinventory.ClearSelection()
                    For i = 0 To dgviewinventory.Rows.Count - 1
                        If CDec(dgviewinventory.Rows(i).Cells(4).Value.ToString()) = CDec(txtsearch.Text) Then
                            dgviewinventory.Rows(i).Selected = True
                            dgviewinventory.CurrentCell = dgviewinventory.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Shape" Then
                    Dim i As Integer
                    dgviewinventory.ClearSelection()
                    For i = 0 To dgviewinventory.Rows.Count - 1
                        If CDec(dgviewinventory.Rows(i).Cells(5).Value.ToString()) = CDec(txtsearch.Text) Then
                            dgviewinventory.Rows(i).Selected = True
                            dgviewinventory.CurrentCell = dgviewinventory.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Price" Then
                    Dim i As Integer
                    dgviewinventory.ClearSelection()
                    For i = 0 To dgviewinventory.Rows.Count - 1
                        If CDec(dgviewinventory.Rows(i).Cells(6).Value.ToString()) = CDec(txtsearch.Text) Then
                            dgviewinventory.Rows(i).Selected = True
                            dgviewinventory.CurrentCell = dgviewinventory.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Available" Then
                    Dim i As Integer
                    dgviewinventory.ClearSelection()
                    For i = 0 To dgviewinventory.Rows.Count - 1
                        If CDec(dgviewinventory.Rows(i).Cells(7).Value.ToString()) = CDec(txtsearch.Text) Then
                            dgviewinventory.Rows(i).Selected = True
                            dgviewinventory.CurrentCell = dgviewinventory.Rows(i).Cells(0)
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
    Private Sub dgviewinventory_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgviewinventory.CellClick
        Try
            Dim k As Integer = dgviewinventory.CurrentRow.Index
            dgviewinventory.Rows(k).Selected = True
            dgviewinventory.CurrentCell = dgviewinventory.Rows(k).Cells(0)
            If (e.ColumnIndex) = 0 Then
                OpenRecords()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgviewinventory_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgviewinventory.DoubleClick
        Try
            Dim k As Integer = dgviewinventory.CurrentRow.Index
            dgviewinventory.Rows(k).Selected = True
            dgviewinventory.CurrentCell = dgviewinventory.Rows(k).Cells(0)
            OpenRecords()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmViewEditInventoryItems_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadDataGrid()
        TotalInventory()
    End Sub
#End Region
End Class
#End Region