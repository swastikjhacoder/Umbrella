#Region "Class frmReturnBooks..."
Public Class frmReturnBookss
#Region "Declaration..."
    Private DGVBookLoan As New DataGridView()
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(27, 47, 39, 13)
        Label2.SetBounds(27, 74, 91, 13)
        Label3.SetBounds(27, 101, 57, 13)
        Label4.SetBounds(27, 128, 45, 13)
        Label5.SetBounds(27, 160, 74, 13)
        Label6.SetBounds(27, 187, 81, 13)
        Label7.SetBounds(27, 214, 83, 26)

        cmbapplylatecharge.SetBounds(190, 211, 70, 21)
        cmbdate.SetBounds(190, 44, 153, 21)
        cmbissueid.SetBounds(190, 71, 153, 21)

        txtissuedate.SetBounds(190, 160, 70, 14)
        txtreturndate.SetBounds(190, 187, 70, 14)

        txtissuename.SetBounds(190, 128, 529, 14)
        txtregno.SetBounds(190, 101, 153, 14)
    End Sub

    Private Sub LoadBookLoanNo()
        Try
            If DGVBookLoan.Columns.Count > 0 Then
                DGVBookLoan.Rows.Clear()
                DGVBookLoan.Columns.Clear()
            End If

            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .HeaderText = "Issue ID"
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .HeaderText = "Issue Date"
            End With
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .HeaderText = "Registration No"
            End With
            Dim col4 As New DataGridViewTextBoxColumn()
            With col4
                .HeaderText = "Name"
            End With

            With DGVBookLoan
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVBookLoan.CellClick, AddressOf DGVBookLoan_CellClick
            End With

            DGVBookLoan.Columns.Clear()

            DGVBookLoan.Columns.Add(col1)
            DGVBookLoan.Columns.Add(col2)
            DGVBookLoan.Columns.Add(col3)
            DGVBookLoan.Columns.Add(col4)

            DGVBookLoan.Rows.Clear()
            Dim indx As Integer = 0
            cmd.CommandText = "select issueid,issuedate,issuedtoid,issuedtoname from Issue where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                DGVBookLoan.Rows.Add()
                DGVBookLoan.Rows(indx).Cells(0).Value = dr("issueid").ToString()
                DGVBookLoan.Rows(indx).Cells(1).Value = dr("issuedate").ToString()
                DGVBookLoan.Rows(indx).Cells(2).Value = dr("issuedtoid").ToString()
                DGVBookLoan.Rows(indx).Cells(3).Value = dr("issuedtoname").ToString()
                indx = indx + 1
            End While
            dr.Close()
            DGVBookLoan.ClearSelection()

            cmbissueid.AddDataGridView(DGVBookLoan, False)
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub DGVBookLoan_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVBookLoan.CurrentRow.Index
            DGVBookLoan.Rows(k).Selected = True
            DGVBookLoan.CurrentCell = DGVBookLoan.Rows(k).Cells(0)
            IssedID = DGVBookLoan.Rows(k).Cells(0).Value.ToString()
            IssueDate = DGVBookLoan.Rows(k).Cells(1).Value.ToString()
            IssueToID = DGVBookLoan.Rows(k).Cells(2).Value.ToString()
            IssueToName = DGVBookLoan.Rows(k).Cells(3).Value.ToString()
            cmbissueid.Text = IssedID
            txtregno.Text = IssueToID
            txtissuename.Text = IssueToName
            LoadSelectedBookLoan(IssedID, IssueDate, IssueToID)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedBookLoan(ByVal issid As String, ByVal issdte As String, ByVal isstoid As String)
        Try
            Dim issedto As String = ""
            cmd.CommandText = "select issedto,issuedtoid,issuedtoname,issuedate,duedate from Issue where issueid='" & cmbissueid.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                issedto = dr("issedto").ToString()
                txtregno.Text = dr("issuedtoid").ToString()
                txtissuename.Text = dr("issuedtoname").ToString()
                txtissuedate.Text = dr("issuedate").ToString()
                txtreturndate.Text = dr("duedate").ToString()
            End If
            dr.Close()
            LoadBookLoanDetails()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadBookLoanDetails()
        Try
            dgviewbooks.Rows.Clear()
            Dim i As Integer = 0
            cmd.CommandText = "select bookname,bookid,author,edition from IssueBooks where issueid='" & IssedID & "' and issuedtoid='" & IssueToID & "' and issuedate='" & IssueDate & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewbooks.Rows.Add()
                dgviewbooks.Rows(i).Cells(0).Value = dr("bookname").ToString()
                dgviewbooks.Rows(i).Cells(1).Value = dr("bookid").ToString()
                dgviewbooks.Rows(i).Cells(2).Value = dr("author").ToString()
                dgviewbooks.Rows(i).Cells(3).Value = dr("edition").ToString()
                i = i + 1
            End While
            dr.Close()
            dgviewbooks.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub AddRecord()
        Try
            If cmbdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbdate.Focus()
                End If
            ElseIf cmbissueid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter issue id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbissueid.Focus()
                End If
            ElseIf cmbapplylatecharge.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter apply late charge.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbapplylatecharge.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cReturnBooks()
                    cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbissueid.Text, cmbdate.Text, txtissuedate.Text, txtreturndate.Text, cmbapplylatecharge.Text, txtregno.Text, txtissuename.Text)
                    If cls.AddReturnOk = True Then
                        For i As Integer = 0 To dgviewbooks.Rows.Count - 1
                            Dim bookname As String = dgviewbooks.Rows(i).Cells(0).Value.ToString()
                            Dim bookid As String = dgviewbooks.Rows(i).Cells(1).Value.ToString()
                            Dim author As String = dgviewbooks.Rows(i).Cells(2).Value.ToString()
                            Dim edition As String = dgviewbooks.Rows(i).Cells(3).Value.ToString()
                            cls.AddReturnBooks(bookid, bookname, author, edition)
                        Next
                        If cls.ReturnBookOk = True Then
                            Dim result1 As DialogResult = MessageBox.Show("Record added successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = Windows.Forms.DialogResult.OK Then
                                cmbissueid.Focus()
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If cmbdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbdate.Focus()
                End If
            ElseIf cmbissueid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter issue id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbissueid.Focus()
                End If
            ElseIf cmbapplylatecharge.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter apply late charge.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbapplylatecharge.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cReturnBooks()
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbissueid.Text, cmbdate.Text, txtissuedate.Text, txtreturndate.Text, cmbapplylatecharge.Text, txtregno.Text, txtissuename.Text)
                    If cls.UpdateReturnOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            cmbissueid.Focus()
                        End If
                    End If
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If cmbdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbdate.Focus()
                End If
            ElseIf cmbissueid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter issue id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbissueid.Focus()
                End If
            ElseIf cmbapplylatecharge.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter apply late charge.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbapplylatecharge.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cReturnBooks()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbissueid.Text, txtissuedate.Text, txtreturndate.Text, txtregno.Text, txtissuename.Text)
                    If cls.DeleteReturnOk = True Then
                        For i As Integer = 0 To dgviewbooks.Rows.Count - 1
                            Dim bookname As String = dgviewbooks.Rows(i).Cells(0).Value.ToString()
                            Dim bookid As String = dgviewbooks.Rows(i).Cells(1).Value.ToString()
                            Dim author As String = dgviewbooks.Rows(i).Cells(2).Value.ToString()
                            Dim edition As String = dgviewbooks.Rows(i).Cells(3).Value.ToString()
                            cls.DeleteReturn(bookid, bookname, author, edition)
                        Next
                        If cls.DeleteReturnBookOk = True Then
                            Dim result1 As DialogResult = MessageBox.Show("Record deleted successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = Windows.Forms.DialogResult.OK Then
                                cmbissueid.Focus()
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetForm()
        Try
            cmbdate.Text = UmbrellaSystemDate
            cmbapplylatecharge.Text = ""
            cmbissueid.Text = ""
            txtissuedate.Text = ""
            txtreturndate.Text = ""
            txtissuename.Text = ""
            txtregno.Text = ""
            dgviewbooks.Rows.Clear()
            cmbissueid.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedReturn()
        Try
            cmd.CommandText = "select date,issueid,issuedate,returndate,applylatecharge,regno,name from ReturnBooks where issueid='" & IssedID & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                cmbdate.Text = dr("date").ToString()
                cmbissueid.Text = dr("issueid").ToString()
                txtissuedate.Text = dr("issuedate").ToString()
                txtreturndate.Text = dr("returndate").ToString()
                cmbapplylatecharge.Text = dr("applylatecharge").ToString()
                txtregno.Text = dr("regno").ToString()
                txtissuename.Text = dr("name").ToString()
            End If
            dr.Close()
            IssedID = cmbissueid.Text
            IssueDate = txtissuedate.Text
            IssueToID = txtregno.Text
            LoadBookLoanDetails()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmReturnBooks_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updatereturnbooks = False Then
            cmbdate.Text = UmbrellaSystemDate
            ControlSetBound()
            LoadBookLoanNo()
        Else
            ControlSetBound()
            LoadBookLoanNo()
            LoadSelectedReturn()
        End If
        If USreturnbooks = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbapplylatecharge.Enabled = False
            cmbdate.Enabled = False
            cmbissueid.Enabled = False
            txtissuedate.ReadOnly = True
            txtissuename.ReadOnly = True
            txtregno.ReadOnly = True
            txtreturndate.ReadOnly = True
            dgviewbooks.Enabled = False
        End If
    End Sub
#End Region
#Region "Attributes..."
    Private Sub cmbdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbissueid.Focus()
        End If
    End Sub

    Private Sub cmbissueid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbissueid.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtregno.Focus()
        End If
    End Sub

    Private Sub txtregno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtregno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtissuename.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbissueid.Focus()
        End If
    End Sub

    Private Sub txtissuename_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtissuename.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtissuedate.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtregno.Focus()
        End If
    End Sub

    Private Sub txtissuedate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtissuedate.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtreturndate.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtissuename.Focus()
        End If
    End Sub

    Private Sub txtreturndate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtreturndate.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbapplylatecharge.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtissuedate.Focus()
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatereturnbooks = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatereturnbooks = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatereturnbooks = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updatereturnbooks = False Then
            cmbdate.Text = UmbrellaSystemDate
            ControlSetBound()
            LoadBookLoanNo()
        Else
            ControlSetBound()
            LoadBookLoanNo()
            LoadSelectedReturn()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region