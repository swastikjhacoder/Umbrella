#Region "Class frmQueryBooks..."
Public Class frmQueryBooks
#Region "Methods..."
    Private Sub LoadDataGrid()
        Try
            Dim i As Integer = 0
            dgvbooks.Rows.Clear()
            cmd.CommandText = "select bookid,bookname,groupname,subject,publisher,author,edition,copies,pages,price from Books where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgvbooks.Rows.Add()
                dgvbooks.Rows(i).Cells(0).Value = dr("bookid").ToString()
                dgvbooks.Rows(i).Cells(1).Value = dr("bookname").ToString()
                dgvbooks.Rows(i).Cells(2).Value = dr("groupname").ToString()
                dgvbooks.Rows(i).Cells(3).Value = dr("subject").ToString()
                dgvbooks.Rows(i).Cells(4).Value = dr("publisher").ToString()
                dgvbooks.Rows(i).Cells(5).Value = dr("author").ToString()
                dgvbooks.Rows(i).Cells(6).Value = dr("edition").ToString()
                dgvbooks.Rows(i).Cells(7).Value = dr("copies").ToString()
                dgvbooks.Rows(i).Cells(8).Value = dr("pages").ToString()
                Dim prc As Decimal = CDec(dr("price").ToString())
                dgvbooks.Rows(i).Cells(9).Value = FormatNumber(prc.ToString())
                i = i + 1
            End While
            dr.Close()
            dgvbooks.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub TotalBooks()
        Try
            Dim row As Integer = dgvbooks.Rows.Count
            EGroupBox1.GroupTitle = "Book List: " + row.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OpenRecords()
        Try
            updatebook = True
            Dim k As Integer = dgvbooks.CurrentRow.Index
            BookID = dgvbooks.Rows(k).Cells(0).Value.ToString()
            Dim frm As New frmBooks()
            frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            frm.WindowState = FormWindowState.Normal
            frm.ControlBox = True
            frm.Show()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        LoadDataGrid()
        TotalBooks()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Search..."
    Private Sub SearchRecord()
        Try
            If txtsearch.Text <> "" Then
                If cmbsearch.Text = "Book ID" Then
                    Dim i As Integer
                    dgvbooks.ClearSelection()
                    For i = 0 To dgvbooks.Rows.Count - 1
                        If dgvbooks.Rows(i).Cells(0).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgvbooks.Rows(i).Selected = True
                            dgvbooks.CurrentCell = dgvbooks.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Book Name" Then
                    Dim i As Integer
                    dgvbooks.ClearSelection()
                    For i = 0 To dgvbooks.Rows.Count - 1
                        If dgvbooks.Rows(i).Cells(1).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgvbooks.Rows(i).Selected = True
                            dgvbooks.CurrentCell = dgvbooks.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Group" Then
                    Dim i As Integer
                    dgvbooks.ClearSelection()
                    For i = 0 To dgvbooks.Rows.Count - 1
                        If dgvbooks.Rows(i).Cells(2).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgvbooks.Rows(i).Selected = True
                            dgvbooks.CurrentCell = dgvbooks.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Subject" Then
                    Dim i As Integer
                    dgvbooks.ClearSelection()
                    For i = 0 To dgvbooks.Rows.Count - 1
                        If dgvbooks.Rows(i).Cells(3).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgvbooks.Rows(i).Selected = True
                            dgvbooks.CurrentCell = dgvbooks.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Publisher" Then
                    Dim i As Integer
                    dgvbooks.ClearSelection()
                    For i = 0 To dgvbooks.Rows.Count - 1
                        If dgvbooks.Rows(i).Cells(4).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgvbooks.Rows(i).Selected = True
                            dgvbooks.CurrentCell = dgvbooks.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Author" Then
                    Dim i As Integer
                    dgvbooks.ClearSelection()
                    For i = 0 To dgvbooks.Rows.Count - 1
                        If dgvbooks.Rows(i).Cells(5).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgvbooks.Rows(i).Selected = True
                            dgvbooks.CurrentCell = dgvbooks.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Edition" Then
                    Dim i As Integer
                    dgvbooks.ClearSelection()
                    For i = 0 To dgvbooks.Rows.Count - 1
                        If dgvbooks.Rows(i).Cells(6).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgvbooks.Rows(i).Selected = True
                            dgvbooks.CurrentCell = dgvbooks.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Availability" Then
                    Dim i As Integer
                    dgvbooks.ClearSelection()
                    For i = 0 To dgvbooks.Rows.Count - 1
                        If dgvbooks.Rows(i).Cells(7).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgvbooks.Rows(i).Selected = True
                            dgvbooks.CurrentCell = dgvbooks.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Pages" Then
                    Dim i As Integer
                    dgvbooks.ClearSelection()
                    For i = 0 To dgvbooks.Rows.Count - 1
                        If dgvbooks.Rows(i).Cells(8).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgvbooks.Rows(i).Selected = True
                            dgvbooks.CurrentCell = dgvbooks.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Price" Then
                    Dim i As Integer
                    dgvbooks.ClearSelection()
                    For i = 0 To dgvbooks.Rows.Count - 1
                        If dgvbooks.Rows(i).Cells(9).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgvbooks.Rows(i).Selected = True
                            dgvbooks.CurrentCell = dgvbooks.Rows(i).Cells(0)
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
    Private Sub dgvbooks_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvbooks.CellClick
        Try
            Dim k As Integer = dgvbooks.CurrentRow.Index
            dgvbooks.Rows(k).Selected = True
            dgvbooks.CurrentCell = dgvbooks.Rows(k).Cells(0)
            If (e.ColumnIndex) = 0 Then
                OpenRecords()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvbooks_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvbooks.DoubleClick
        Try
            Dim k As Integer = dgvbooks.CurrentRow.Index
            dgvbooks.Rows(k).Selected = True
            dgvbooks.CurrentCell = dgvbooks.Rows(k).Cells(0)
            OpenRecords()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmQueryBooks_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadDataGrid()
        TotalBooks()
        If USbookrecords = "View Only" Then
            dgvbooks.Enabled = False
        End If
    End Sub
#End Region
End Class
#End Region