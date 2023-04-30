﻿#Region "Class frmViewEditPFRate..."
Public Class frmViewEditPFRate
#Region "Methods..."
    Private Sub LoadDataGrid()
        Try
            Dim i As Integer = 0
            dgviewpfrate.Rows.Clear()
            cmd.CommandText = "select regno,name,year,rate,amount from PFRateIndividual where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewpfrate.Rows.Add()
                dgviewpfrate.Rows(i).Cells(0).Value = dr("regno").ToString()
                dgviewpfrate.Rows(i).Cells(1).Value = dr("name").ToString()
                dgviewpfrate.Rows(i).Cells(2).Value = dr("year").ToString()
                Dim rate As Decimal = CDec(dr("rate").ToString())
                dgviewpfrate.Rows(i).Cells(3).Value = FormatNumber(rate.ToString())
                Dim amt As Decimal = CDec(dr("amount").ToString())
                dgviewpfrate.Rows(i).Cells(4).Value = FormatNumber(amt.ToString())
                i = i + 1
            End While
            dr.Close()
            dgviewpfrate.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub TotalRate()
        Try
            Dim row As Integer = dgviewpfrate.Rows.Count
            EGroupBox1.GroupTitle = "PF Rate List: " + row.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OpenRecords()
        Try
            updatepfrateindividual = True
            Dim k As Integer = dgviewpfrate.CurrentRow.Index
            EmpRegNo = dgviewpfrate.Rows(k).Cells(0).Value.ToString()
            Dim frm As New frmPFModifyPFRate()
            frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            frm.WindowState = FormWindowState.Normal
            frm.ControlBox = True
            frm.Show()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnexportexcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnexportexcel.ClickButtonArea
        Try
            If ((dgviewpfrate.Columns.Count = 0) Or (dgviewpfrate.Rows.Count = 0)) Then
                Dim result As DialogResult = MessageBox.Show("No record found to export!!!", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    Exit Sub
                End If
            Else
                'Dim Imagefile As String = AppDomain.CurrentDomain.BaseDirectory + "\\ESAR Report.bmp"
                Dim dset As New DataSet
                dset.Tables.Add()
                For i As Integer = 0 To dgviewpfrate.ColumnCount - 1
                    dset.Tables(0).Columns.Add(dgviewpfrate.Columns(i).HeaderText)
                Next
                Dim dr1 As DataRow
                For i As Integer = 0 To dgviewpfrate.RowCount - 1
                    dr1 = dset.Tables(0).NewRow
                    For j As Integer = 0 To dgviewpfrate.Columns.Count - 1
                        dr1(j) = dgviewpfrate.Rows(i).Cells(j).Value
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
        updatepfrateindividual = False
        Dim frm As New frmPFModifyPFRate()
        frm.ControlBox = True
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.Show()
    End Sub

    Private Sub btnopen_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnopen.ClickButtonArea
        OpenRecords()
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        LoadDataGrid()
        TotalRate()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Search..."
    Private Sub SearchRecord()
        Try
            If txtsearch.Text <> "" Then
                If cmbsearch.Text = "Registration ID" Then
                    Dim i As Integer
                    dgviewpfrate.ClearSelection()
                    For i = 0 To dgviewpfrate.Rows.Count - 1
                        If dgviewpfrate.Rows(i).Cells(0).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewpfrate.Rows(i).Selected = True
                            dgviewpfrate.CurrentCell = dgviewpfrate.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Name" Then
                    Dim i As Integer
                    dgviewpfrate.ClearSelection()
                    For i = 0 To dgviewpfrate.Rows.Count - 1
                        If dgviewpfrate.Rows(i).Cells(1).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewpfrate.Rows(i).Selected = True
                            dgviewpfrate.CurrentCell = dgviewpfrate.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Year" Then
                    Dim i As Integer
                    dgviewpfrate.ClearSelection()
                    For i = 0 To dgviewpfrate.Rows.Count - 1
                        If dgviewpfrate.Rows(i).Cells(2).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewpfrate.Rows(i).Selected = True
                            dgviewpfrate.CurrentCell = dgviewpfrate.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Rate" Then
                    Dim i As Integer
                    dgviewpfrate.ClearSelection()
                    For i = 0 To dgviewpfrate.Rows.Count - 1
                        If dgviewpfrate.Rows(i).Cells(3).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewpfrate.Rows(i).Selected = True
                            dgviewpfrate.CurrentCell = dgviewpfrate.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Amount" Then
                    Dim i As Integer
                    dgviewpfrate.ClearSelection()
                    For i = 0 To dgviewpfrate.Rows.Count - 1
                        If dgviewpfrate.Rows(i).Cells(4).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewpfrate.Rows(i).Selected = True
                            dgviewpfrate.CurrentCell = dgviewpfrate.Rows(i).Cells(0)
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
    Private Sub dgviewpfrate_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgviewpfrate.CellClick
        Try
            Dim k As Integer = dgviewpfrate.CurrentRow.Index
            dgviewpfrate.Rows(k).Selected = True
            dgviewpfrate.CurrentCell = dgviewpfrate.Rows(k).Cells(0)
            If (e.ColumnIndex) = 0 Then
                OpenRecords()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgviewpfrate_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgviewpfrate.DoubleClick
        Try
            Dim k As Integer = dgviewpfrate.CurrentRow.Index
            dgviewpfrate.Rows(k).Selected = True
            dgviewpfrate.CurrentCell = dgviewpfrate.Rows(k).Cells(0)
            OpenRecords()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmViewEditPFRate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadDataGrid()
        TotalRate()
    End Sub
#End Region
End Class
#End Region