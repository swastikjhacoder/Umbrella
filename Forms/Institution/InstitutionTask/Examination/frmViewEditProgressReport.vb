#Region "Class frmViewEditProgressReport..."
Public Class frmViewEditProgressReport
#Region "Methods..."
    Private Sub LoadDataGrid()
        Try
            Dim i As Integer = 0
            dgviewprogressreport.Rows.Clear()
            cmd.CommandText = "select progressid,stuid,attendance,preparation,homework,takerisk,goals,plans,respect,cooperation,interest,motivation,outcomes,quality,keyterms,newconcept from ProgressReport where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and SystemDate<='" & UmbrellaSystemDate & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewprogressreport.Rows.Add()
                dgviewprogressreport.Rows(i).Cells(0).Value = dr("progressid").ToString()
                dgviewprogressreport.Rows(i).Cells(1).Value = dr("stuid").ToString()
                dgviewprogressreport.Rows(i).Cells(2).Value = dr("attendance").ToString()
                dgviewprogressreport.Rows(i).Cells(3).Value = dr("preparation").ToString()
                dgviewprogressreport.Rows(i).Cells(4).Value = dr("homework").ToString()
                dgviewprogressreport.Rows(i).Cells(5).Value = dr("takerisk").ToString()
                dgviewprogressreport.Rows(i).Cells(6).Value = dr("goals").ToString()
                dgviewprogressreport.Rows(i).Cells(7).Value = dr("plans").ToString()
                dgviewprogressreport.Rows(i).Cells(8).Value = dr("respect").ToString()
                dgviewprogressreport.Rows(i).Cells(9).Value = dr("cooperation").ToString()
                dgviewprogressreport.Rows(i).Cells(10).Value = dr("interest").ToString()
                dgviewprogressreport.Rows(i).Cells(11).Value = dr("motivation").ToString()
                dgviewprogressreport.Rows(i).Cells(12).Value = dr("outcomes").ToString()
                dgviewprogressreport.Rows(i).Cells(13).Value = dr("quality").ToString()
                dgviewprogressreport.Rows(i).Cells(14).Value = dr("keyterms").ToString()
                dgviewprogressreport.Rows(i).Cells(15).Value = dr("newconcept").ToString()
                i = i + 1
            End While
            dr.Close()
            dgviewprogressreport.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub TotalProgressReport()
        Try
            Dim row As Integer = dgviewprogressreport.Rows.Count
            EGroupBox1.GroupTitle = "Progress Report List: " + row.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OpenRecords()
        Try
            updateprogessreport = True
            Dim k As Integer = dgviewprogressreport.CurrentRow.Index
            progessid = dgviewprogressreport.Rows(k).Cells(0).Value.ToString()
            StuID = dgviewprogressreport.Rows(k).Cells(1).Value.ToString()
            Dim frm As New frmProgressReport()
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
            If ((dgviewprogressreport.Columns.Count = 0) Or (dgviewprogressreport.Rows.Count = 0)) Then
                Dim result As DialogResult = MessageBox.Show("No record found to export!!!", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    Exit Sub
                End If
            Else
                'Dim Imagefile As String = AppDomain.CurrentDomain.BaseDirectory + "\\ESAR Report.bmp"
                Dim dset As New DataSet
                dset.Tables.Add()
                For i As Integer = 0 To dgviewprogressreport.ColumnCount - 1
                    dset.Tables(0).Columns.Add(dgviewprogressreport.Columns(i).HeaderText)
                Next
                Dim dr1 As DataRow
                For i As Integer = 0 To dgviewprogressreport.RowCount - 1
                    dr1 = dset.Tables(0).NewRow
                    For j As Integer = 0 To dgviewprogressreport.Columns.Count - 1
                        dr1(j) = dgviewprogressreport.Rows(i).Cells(j).Value
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
        updateprogessreport = False
        Dim frm As New frmProgressReport()
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
        TotalProgressReport()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Search..."
    Private Sub SearchRecord()
        Try
            If txtsearch.Text <> "" Then
                If cmbsearch.Text = "Progress ID" Then
                    Dim i As Integer
                    dgviewprogressreport.ClearSelection()
                    For i = 0 To dgviewprogressreport.Rows.Count - 1
                        If dgviewprogressreport.Rows(i).Cells(0).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewprogressreport.Rows(i).Selected = True
                            dgviewprogressreport.CurrentCell = dgviewprogressreport.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Reg. No." Then
                    Dim i As Integer
                    dgviewprogressreport.ClearSelection()
                    For i = 0 To dgviewprogressreport.Rows.Count - 1
                        If dgviewprogressreport.Rows(i).Cells(1).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewprogressreport.Rows(i).Selected = True
                            dgviewprogressreport.CurrentCell = dgviewprogressreport.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Attendance" Then
                    Dim i As Integer
                    dgviewprogressreport.ClearSelection()
                    For i = 0 To dgviewprogressreport.Rows.Count - 1
                        If dgviewprogressreport.Rows(i).Cells(2).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewprogressreport.Rows(i).Selected = True
                            dgviewprogressreport.CurrentCell = dgviewprogressreport.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Preparation" Then
                    Dim i As Integer
                    dgviewprogressreport.ClearSelection()
                    For i = 0 To dgviewprogressreport.Rows.Count - 1
                        If dgviewprogressreport.Rows(i).Cells(3).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewprogressreport.Rows(i).Selected = True
                            dgviewprogressreport.CurrentCell = dgviewprogressreport.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Home Work" Then
                    Dim i As Integer
                    dgviewprogressreport.ClearSelection()
                    For i = 0 To dgviewprogressreport.Rows.Count - 1
                        If dgviewprogressreport.Rows(i).Cells(4).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewprogressreport.Rows(i).Selected = True
                            dgviewprogressreport.CurrentCell = dgviewprogressreport.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Take Risk" Then
                    Dim i As Integer
                    dgviewprogressreport.ClearSelection()
                    For i = 0 To dgviewprogressreport.Rows.Count - 1
                        If dgviewprogressreport.Rows(i).Cells(5).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewprogressreport.Rows(i).Selected = True
                            dgviewprogressreport.CurrentCell = dgviewprogressreport.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Goals" Then
                    Dim i As Integer
                    dgviewprogressreport.ClearSelection()
                    For i = 0 To dgviewprogressreport.Rows.Count - 1
                        If dgviewprogressreport.Rows(i).Cells(6).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewprogressreport.Rows(i).Selected = True
                            dgviewprogressreport.CurrentCell = dgviewprogressreport.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Plans" Then
                    Dim i As Integer
                    dgviewprogressreport.ClearSelection()
                    For i = 0 To dgviewprogressreport.Rows.Count - 1
                        If dgviewprogressreport.Rows(i).Cells(7).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewprogressreport.Rows(i).Selected = True
                            dgviewprogressreport.CurrentCell = dgviewprogressreport.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Respect" Then
                    Dim i As Integer
                    dgviewprogressreport.ClearSelection()
                    For i = 0 To dgviewprogressreport.Rows.Count - 1
                        If dgviewprogressreport.Rows(i).Cells(8).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewprogressreport.Rows(i).Selected = True
                            dgviewprogressreport.CurrentCell = dgviewprogressreport.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Cooperations" Then
                    Dim i As Integer
                    dgviewprogressreport.ClearSelection()
                    For i = 0 To dgviewprogressreport.Rows.Count - 1
                        If dgviewprogressreport.Rows(i).Cells(9).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewprogressreport.Rows(i).Selected = True
                            dgviewprogressreport.CurrentCell = dgviewprogressreport.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Interest" Then
                    Dim i As Integer
                    dgviewprogressreport.ClearSelection()
                    For i = 0 To dgviewprogressreport.Rows.Count - 1
                        If dgviewprogressreport.Rows(i).Cells(10).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewprogressreport.Rows(i).Selected = True
                            dgviewprogressreport.CurrentCell = dgviewprogressreport.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Motivation" Then
                    Dim i As Integer
                    dgviewprogressreport.ClearSelection()
                    For i = 0 To dgviewprogressreport.Rows.Count - 1
                        If dgviewprogressreport.Rows(i).Cells(11).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewprogressreport.Rows(i).Selected = True
                            dgviewprogressreport.CurrentCell = dgviewprogressreport.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Outcomes" Then
                    Dim i As Integer
                    dgviewprogressreport.ClearSelection()
                    For i = 0 To dgviewprogressreport.Rows.Count - 1
                        If dgviewprogressreport.Rows(i).Cells(12).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewprogressreport.Rows(i).Selected = True
                            dgviewprogressreport.CurrentCell = dgviewprogressreport.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Quality" Then
                    Dim i As Integer
                    dgviewprogressreport.ClearSelection()
                    For i = 0 To dgviewprogressreport.Rows.Count - 1
                        If dgviewprogressreport.Rows(i).Cells(13).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewprogressreport.Rows(i).Selected = True
                            dgviewprogressreport.CurrentCell = dgviewprogressreport.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Key Terms" Then
                    Dim i As Integer
                    dgviewprogressreport.ClearSelection()
                    For i = 0 To dgviewprogressreport.Rows.Count - 1
                        If dgviewprogressreport.Rows(i).Cells(14).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewprogressreport.Rows(i).Selected = True
                            dgviewprogressreport.CurrentCell = dgviewprogressreport.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "New Concept" Then
                    Dim i As Integer
                    dgviewprogressreport.ClearSelection()
                    For i = 0 To dgviewprogressreport.Rows.Count - 1
                        If dgviewprogressreport.Rows(i).Cells(15).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewprogressreport.Rows(i).Selected = True
                            dgviewprogressreport.CurrentCell = dgviewprogressreport.Rows(i).Cells(0)
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
    Private Sub dgviewprogressreport_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgviewprogressreport.CellClick
        Try
            Dim k As Integer = dgviewprogressreport.CurrentRow.Index
            dgviewprogressreport.Rows(k).Selected = True
            dgviewprogressreport.CurrentCell = dgviewprogressreport.Rows(k).Cells(0)
            If (e.ColumnIndex) = 0 Then
                OpenRecords()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgviewprogressreport_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgviewprogressreport.DoubleClick
        Try
            Dim k As Integer = dgviewprogressreport.CurrentRow.Index
            dgviewprogressreport.Rows(k).Selected = True
            dgviewprogressreport.CurrentCell = dgviewprogressreport.Rows(k).Cells(0)
            OpenRecords()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmViewEditProgressReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadDataGrid()
        TotalProgressReport()
    End Sub
#End Region
End Class
#End Region