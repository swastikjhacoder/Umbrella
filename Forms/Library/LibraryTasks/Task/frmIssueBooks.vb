#Region "Imports..."
Imports ESAR_Controls.UIControls.ComboBox
#End Region
#Region "Class frmIssueBooks..."
Public Class frmIssueBooks
#Region "Declarations..."
    Private BCODE As String = ""
    Private TT As String = ""
    Private DGViewRecord As New DataGridView()
    Private DGViewEmp As New DataGridView()
    Private issueid As Integer = 0
    Private MaxBooks As Integer = 0
    Private IssueExist As Boolean = False
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        BCODE = Indx.LoadIssuedID()
        Dim var As String
        var = CodeIncrement(BCODE)
        Me.txtbookloanno.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("ISU:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        Label1.SetBounds(14, 35, 68, 13)
        Label10.SetBounds(14, 273, 69, 13)
        Label11.SetBounds(483, 119, 24, 13)
        Label2.SetBounds(14, 63, 102, 13)
        Label3.SetBounds(569, 63, 75, 13)
        Label4.SetBounds(14, 90, 43, 13)
        Label5.SetBounds(545, 90, 99, 13)
        Label6.SetBounds(14, 119, 85, 13)
        Label7.SetBounds(14, 245, 91, 13)
        Label8.SetBounds(343, 245, 70, 13)
        Label9.SetBounds(578, 245, 66, 13)

        cmbduedate.SetBounds(663, 242, 131, 21)
        cmbissuedate.SetBounds(428, 242, 107, 21)
        cmbissuedby.SetBounds(140, 270, 395, 21)
        cmbissuedto.SetBounds(140, 32, 160, 22)
        cmbsearch.SetBounds(513, 114, 121, 21)
        cmbstudent.SetBounds(140, 60, 395, 21)

        txtbookloanno.SetBounds(140, 242, 195, 21)
        txtcontactno.SetBounds(663, 60, 131, 21)
        txtemail.SetBounds(140, 87, 395, 21)
        txtregno.SetBounds(663, 87, 131, 21)
        txtsearch.SetBounds(140, 113, 337, 21)

        dgviewbooks.SetBounds(140, 140, 654, 96)

        btnsearch.SetBounds(651, 113, 75, 21)
        btnclear.SetBounds(732, 113, 60, 21)
    End Sub

    Private Sub LoadIssuedTo()
        Try
            If DGViewRecord.Columns.Count > 0 Then
                DGViewRecord.Rows.Clear()
                DGViewRecord.Columns.Clear()
            End If

            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .HeaderText = "Registration No."
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .HeaderText = "Name"
            End With
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .HeaderText = "Course"
            End With
            Dim col4 As New DataGridViewTextBoxColumn()
            With col4
                .HeaderText = "Designation"
            End With

            With DGViewRecord
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
                AddHandler DGViewRecord.CellClick, AddressOf DGViewRecord_CellClick
            End With

            DGViewRecord.Columns.Clear()

            If cmbissuedto.Text = "Student" Then
                DGViewRecord.Columns.Add(col1)
                DGViewRecord.Columns.Add(col2)
                DGViewRecord.Columns.Add(col3)
            Else
                DGViewRecord.Columns.Add(col1)
                DGViewRecord.Columns.Add(col2)
                DGViewRecord.Columns.Add(col4)
            End If

            DGViewRecord.Rows.Clear()

            If cmbissuedto.Text = "Student" Then
                Dim indx As Integer = 0
                cmd.CommandText = "select stuid,name,course from StudentRegistration where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    DGViewRecord.Rows.Add()
                    DGViewRecord.Rows(indx).Cells(0).Value = dr("stuid").ToString()
                    DGViewRecord.Rows(indx).Cells(1).Value = dr("name").ToString()
                    DGViewRecord.Rows(indx).Cells(2).Value = dr("course").ToString()
                    indx = indx + 1
                End While
                dr.Close()
            ElseIf cmbissuedto.Text = "Employee" Then
                Dim indx As Integer = 0
                cmd.CommandText = "select empid,name,designation from Employee where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    DGViewRecord.Rows.Add()
                    DGViewRecord.Rows(indx).Cells(0).Value = dr("empid").ToString()
                    DGViewRecord.Rows(indx).Cells(1).Value = dr("name").ToString()
                    DGViewRecord.Rows(indx).Cells(2).Value = dr("designation").ToString()
                    indx = indx + 1
                End While
                dr.Close()
            End If
            DGViewRecord.ClearSelection()

            cmbstudent.AddDataGridView(DGViewRecord, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGViewRecord_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            If cmbissuedto.Text = "Student" Then
                Dim k As Integer = DGViewRecord.CurrentRow.Index
                DGViewRecord.Rows(k).Selected = True
                DGViewRecord.CurrentCell = DGViewRecord.Rows(k).Cells(0)
                StuID = DGViewRecord.Rows(k).Cells(0).Value.ToString()
                StuName = DGViewRecord.Rows(k).Cells(1).Value.ToString()
                crsname = DGViewRecord.Rows(k).Cells(2).Value.ToString()
                cmbstudent.Text = StuName
                txtregno.Text = StuID
                LoadSelectedIssuedTo(StuID, StuName)
                cmd.CommandText = "select maxbooks from BookCharges where course='" & crsname & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                MaxBooks = cmd.ExecuteScalar()

            ElseIf cmbissuedto.Text = "Employee" Then
                Dim k As Integer = DGViewRecord.CurrentRow.Index
                DGViewRecord.Rows(k).Selected = True
                DGViewRecord.CurrentCell = DGViewRecord.Rows(k).Cells(0)
                EmpRegNo = DGViewRecord.Rows(k).Cells(0).Value.ToString()
                EmpName = DGViewRecord.Rows(k).Cells(1).Value.ToString()
                cmbstudent.Text = EmpName
                txtregno.Text = EmpRegNo
                LoadSelectedIssuedTo(EmpRegNo, EmpName)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadIsseudBy()
        Try

            If DGViewEmp.Columns.Count > 0 Then
                DGViewEmp.Rows.Clear()
                DGViewEmp.Columns.Clear()
            End If

            Dim col5 As New DataGridViewLinkColumn()
            With col5
                .HeaderText = "Registration No."
            End With
            Dim col6 As New DataGridViewTextBoxColumn()
            With col6
                .HeaderText = "Name"
            End With
            Dim col7 As New DataGridViewTextBoxColumn()
            With col7
                .HeaderText = "Designation"
            End With

            With DGViewEmp
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
                AddHandler DGViewEmp.CellClick, AddressOf DGViewEmp_CellClick
            End With

            DGViewEmp.Columns.Clear()

            DGViewEmp.Columns.Add(col5)
            DGViewEmp.Columns.Add(col6)
            DGViewEmp.Columns.Add(col7)

            DGViewRecord.Rows.Clear()

            Dim indxx As Integer = 0
            cmd.CommandText = "select empid,name,designation from Employee where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                DGViewEmp.Rows.Add()
                DGViewEmp.Rows(indxx).Cells(0).Value = dr("empid").ToString()
                DGViewEmp.Rows(indxx).Cells(1).Value = dr("name").ToString()
                DGViewEmp.Rows(indxx).Cells(2).Value = dr("designation").ToString()
                indxx = indxx + 1
            End While
            dr.Close()
            DGViewEmp.ClearSelection()

            cmbissuedby.AddDataGridView(DGViewEmp, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGViewEmp_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGViewEmp.CurrentRow.Index
            DGViewEmp.Rows(k).Selected = True
            DGViewEmp.CurrentCell = DGViewEmp.Rows(k).Cells(0)
            EmpRegNo = DGViewEmp.Rows(k).Cells(0).Value.ToString()
            EmpName = DGViewEmp.Rows(k).Cells(1).Value.ToString()
            cmbissuedby.Text = EmpName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadReturnDate()
        Try
            If cmbissuedate.Text <> "" Then
                If cmbissuedto.Text = "Student" Then
                    cmd.CommandText = "select booksreturndays from BookCharges where course='" & crsname & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                    Dim returndays As Integer = cmd.ExecuteScalar()
                    Dim issueddate As Date = Date.Parse(cmbissuedate.Text)
                    Dim duedate As Date = issueddate.AddDays(returndays)
                    cmbduedate.Text = duedate.ToShortDateString()
                Else
                    Dim issueddate As Date = Date.Parse(cmbissuedate.Text)
                    Dim duedate As Date = issueddate.AddDays(15)
                    cmbduedate.Text = duedate.ToShortDateString()
                End If
            End If
        Catch ex As Exception
            cmd.Dispose()
            dr.Close()
        End Try
    End Sub

    Private Sub LoadSelectedIssueBooks()
        Try
            Dim duedate As String = ""
            Dim issdate As String = ""
            Dim issdby As String = ""
            Dim issdto As String = ""
            Dim issdtoname As String = ""
            Dim issid As String = ""
            Dim contactno As String = ""
            Dim email As String = ""
            Dim issdtoid As String = ""
            cmd.CommandText = "select duedate,issuedate,issedby,issedto,issuedtoname,issueid,contactno,email,issuedtoid from Issue where issueid='" & IssedID & "' and issuedtoid='" & IssueToID & "' and issuedate='" & IssueDate & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                duedate = dr("duedate").ToString()
                issdate = dr("issuedate").ToString()
                issdby = dr("issedby").ToString()
                issdto = dr("issedto").ToString()
                issdtoname = dr("issuedtoname").ToString()
                issid = dr("issueid").ToString()
                contactno = dr("contactno").ToString()
                email = dr("email").ToString()
                issdtoid = dr("issuedtoid").ToString()
            End If
            dr.Close()
            cmbduedate.Text = duedate
            cmbissuedate.Text = issdate
            cmbissuedby.Text = issdby
            cmbissuedto.Text = issdto
            cmbstudent.Text = issdtoname
            txtbookloanno.Text = issid
            txtcontactno.Text = contactno
            txtemail.Text = email
            txtregno.Text = issdtoid
            LoadIssuedBooks()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadIssuedBooks()
        Try
            Dim i As Integer = 0
            cmd.CommandText = "select bookname,bookid,author,edition from IssueBooks where issueid='" & IssedID & "' and issuedtoid='" & IssueToID & "' and issuedate='" & IssueDate & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewselectedbooks.Rows.Add()
                dgviewselectedbooks.Rows(i).Cells(0).Value = "Remove"
                dgviewselectedbooks.Rows(i).Cells(1).Value = dr("bookname").ToString()
                dgviewselectedbooks.Rows(i).Cells(2).Value = dr("bookid").ToString()
                dgviewselectedbooks.Rows(i).Cells(3).Value = dr("author").ToString()
                dgviewselectedbooks.Rows(i).Cells(4).Value = dr("edition").ToString()
                i = i + 1
            End While
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadDataGrid()
        Try
            Dim i As Integer = 0
            dgviewbooks.Rows.Clear()
            cmd.CommandText = "select bookid,bookname,author,edition from Books where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and copies>0"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewbooks.Rows.Add()
                dgviewbooks.Rows(i).Cells(0).Value = "Add"
                dgviewbooks.Rows(i).Cells(1).Value = dr("bookname").ToString()
                dgviewbooks.Rows(i).Cells(2).Value = dr("bookid").ToString()
                dgviewbooks.Rows(i).Cells(3).Value = dr("author").ToString()
                dgviewbooks.Rows(i).Cells(4).Value = dr("edition").ToString()
                i = i + 1
            End While
            dr.Close()
            dgviewbooks.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub SearchRecord()
        Try
            If txtsearch.Text <> "" Then
                If cmbsearch.Text = "Book ID" Then
                    Dim i As Integer
                    dgviewbooks.ClearSelection()
                    For i = 0 To dgviewbooks.Rows.Count - 1
                        If dgviewbooks.Rows(i).Cells(2).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewbooks.Rows(i).Selected = True
                            dgviewbooks.CurrentCell = dgviewbooks.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Book Name" Then
                    Dim i As Integer
                    dgviewbooks.ClearSelection()
                    For i = 0 To dgviewbooks.Rows.Count - 1
                        If dgviewbooks.Rows(i).Cells(1).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewbooks.Rows(i).Selected = True
                            dgviewbooks.CurrentCell = dgviewbooks.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Author" Then
                    Dim i As Integer
                    dgviewbooks.ClearSelection()
                    For i = 0 To dgviewbooks.Rows.Count - 1
                        If dgviewbooks.Rows(i).Cells(3).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewbooks.Rows(i).Selected = True
                            dgviewbooks.CurrentCell = dgviewbooks.Rows(i).Cells(0)
                            Exit For
                        End If
                    Next
                ElseIf cmbsearch.Text = "Edition" Then
                    Dim i As Integer
                    dgviewbooks.ClearSelection()
                    For i = 0 To dgviewbooks.Rows.Count - 1
                        If dgviewbooks.Rows(i).Cells(4).Value.ToString().ToUpper() Like UCase(txtsearch.Text) Then
                            dgviewbooks.Rows(i).Selected = True
                            dgviewbooks.CurrentCell = dgviewbooks.Rows(i).Cells(0)
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

    Private Sub LoadSelectedIssuedTo(ByVal ID As String, ByVal Name As String)
        Try
            If cmbissuedto.Text = "Student" Then
                cmd.CommandText = "select email,homephone from StudentRegistration where stuid='" & ID & "' and name='" & Name & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    txtemail.Text = dr("email").ToString()
                    txtcontactno.Text = dr("homephone").ToString()
                End If
                dr.Close()
            ElseIf cmbissuedto.Text = "Employee" Then
                cmd.CommandText = "select email,phone from Employee where empid='" & ID & "' and name='" & Name & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    txtemail.Text = dr("email").ToString()
                    txtcontactno.Text = dr("phone").ToString()
                End If
                dr.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddRecord()
        Try
            If cmbduedate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter due date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbduedate.Focus()
                End If
            ElseIf cmbissuedate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter issue date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbissuedate.Focus()
                End If
            ElseIf cmbissuedby.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select issued by.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbissuedby.Focus()
                End If
            ElseIf cmbissuedto.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select issue to.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbissuedto.Focus()
                End If
            ElseIf cmbstudent.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select issue to name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbstudent.Focus()
                End If
            ElseIf txtbookloanno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter book loan no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtbookloanno.Focus()
                End If
            ElseIf dgviewselectedbooks.Rows.Count <= 0 Then
                Dim result As DialogResult = MessageBox.Show("Please enter books to issue.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtsearch.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    CheckIssueID()
                    If IssueExist = False Then
                        Dim cls As New cIssueBooks()
                        cls.AddIssue(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbissuedto.Text, cmbstudent.Text, txtregno.Text, txtcontactno.Text, txtemail.Text, txtbookloanno.Text, cmbissuedate.Text, cmbduedate.Text, cmbissuedby.Text)
                        If cls.AddIssueOk = True Then
                            For i As Integer = 0 To dgviewselectedbooks.Rows.Count - 1
                                Dim bookname As String = dgviewselectedbooks.Rows(i).Cells(1).Value.ToString()
                                Dim bookid As String = dgviewselectedbooks.Rows(i).Cells(2).Value.ToString()
                                Dim bookauthor As String = dgviewselectedbooks.Rows(i).Cells(3).Value.ToString()
                                Dim bookedition As String = dgviewselectedbooks.Rows(i).Cells(4).Value.ToString()
                                cls.AddIssueBooks(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtbookloanno.Text, txtregno.Text, cmbissuedate.Text, bookname, bookid, bookauthor, bookedition)
                            Next
                            If cls.AddIssueBooksOk = True Then
                                Dim result1 As DialogResult = MessageBox.Show("Record added successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                If result1 = Windows.Forms.DialogResult.OK Then
                                    LoadDataGrid()
                                    cmbissuedto.Focus()
                                End If
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Book loan no. already exist." + Environment.NewLine + "Please eneter a new book loan no.", "Umbrella - Duplicate Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            txtbookloanno.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If cmbduedate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter due date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbduedate.Focus()
                End If
            ElseIf cmbissuedate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter issue date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbissuedate.Focus()
                End If
            ElseIf cmbissuedby.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select issued by.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbissuedby.Focus()
                End If
            ElseIf cmbissuedto.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select issue to.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbissuedto.Focus()
                End If
            ElseIf cmbstudent.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select issue to name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbstudent.Focus()
                End If
            ElseIf txtbookloanno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter book loan no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtbookloanno.Focus()
                End If
            ElseIf dgviewselectedbooks.Rows.Count <= 0 Then
                Dim result As DialogResult = MessageBox.Show("Please enter books to issue.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtsearch.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cIssueBooks()
                    cls.UpdateIssue(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbissuedto.Text, cmbstudent.Text, txtregno.Text, txtcontactno.Text, txtemail.Text, txtbookloanno.Text, cmbissuedate.Text, cmbduedate.Text, cmbissuedby.Text)
                    If cls.UpdateIssueOk = True Then
                        cls.DeleteIssueBooks(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtbookloanno.Text)
                        For i As Integer = 0 To dgviewselectedbooks.Rows.Count - 1
                            Dim bookname As String = dgviewselectedbooks.Rows(i).Cells(1).Value.ToString()
                            Dim bookid As String = dgviewselectedbooks.Rows(i).Cells(2).Value.ToString()
                            Dim bookauthor As String = dgviewselectedbooks.Rows(i).Cells(3).Value.ToString()
                            Dim bookedition As String = dgviewselectedbooks.Rows(i).Cells(4).Value.ToString()
                            cls.AddIssueBooks(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtbookloanno.Text, txtregno.Text, cmbissuedate.Text, bookname, bookid, bookauthor, bookedition)
                        Next
                        If cls.AddIssueBooksOk = True Then
                            Dim result1 As DialogResult = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = Windows.Forms.DialogResult.OK Then
                                cmbissuedto.Focus()
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If cmbduedate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter due date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbduedate.Focus()
                End If
            ElseIf cmbissuedate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter issue date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbissuedate.Focus()
                End If
            ElseIf cmbissuedby.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select issued by.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbissuedby.Focus()
                End If
            ElseIf cmbissuedto.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select issue to.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbissuedto.Focus()
                End If
            ElseIf cmbstudent.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select issue to name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbstudent.Focus()
                End If
            ElseIf txtbookloanno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter book loan no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtbookloanno.Focus()
                End If
            ElseIf dgviewselectedbooks.Rows.Count <= 0 Then
                Dim result As DialogResult = MessageBox.Show("Please enter books to issue.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtsearch.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cIssueBooks()
                    cls.DeleteIssue(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtbookloanno.Text)
                    If cls.DeleteIssueOk = True Then
                        cls.DeleteIssueBooks(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtbookloanno.Text)
                        If cls.DeleteIssueBooksOk = True Then
                            Dim result1 As DialogResult = MessageBox.Show("Record deleted successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = Windows.Forms.DialogResult.OK Then
                                ResetForm()
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
            cmbduedate.Text = ""
            cmbissuedate.Text = UmbrellaSystemDate
            cmbissuedby.Text = ""
            cmbissuedto.Text = ""
            cmbsearch.Text = ""
            cmbstudent.Text = ""
            txtcontactno.Text = ""
            txtemail.Text = ""
            txtregno.Text = ""
            txtsearch.Text = ""
            dgviewselectedbooks.Rows.Clear()
            dgviewbooks.ClearSelection()
            issueid = 0
            MaxBooks = 0
            If LSDAutoID = "Yes" Then
                GetCode()
            Else
                txtbookloanno.Text = ""
            End If
            cmbissuedto.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckIssueID()
        Try
            cmd.CommandText = "select * from Issue where issueid='" & txtbookloanno.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                IssueExist = True
            Else
                IssueExist = False
            End If
            dr.Close()
        Catch ex As Exception
            IssueExist = False
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmIssueBooks_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updateissebooks = False Then
            ControlSetBound()
            If LSDAutoID = "Yes" Then
                GetCode()
            End If
            cmbissuedto.Items.Add(New ComboBoxIconItem("Employee", 0))
            cmbissuedto.Items.Add(New ComboBoxIconItem("Student", 1))
            cmbissuedate.Text = UmbrellaSystemDate
            LoadIsseudBy()
            LoadDataGrid()
        Else
            ControlSetBound()
            GetCode()
            cmbissuedto.Items.Add(New ComboBoxIconItem("Employee", 0))
            cmbissuedto.Items.Add(New ComboBoxIconItem("Student", 1))
            LoadIsseudBy()
            LoadDataGrid()
            LoadSelectedIssueBooks()
        End If
        If USissuebooks = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbduedate.Enabled = False
            cmbissuedate.Enabled = False
            cmbissuedby.Enabled = False
            cmbissuedto.Enabled = False
            cmbsearch.Enabled = False
            cmbstudent.Enabled = False
            txtbookloanno.ReadOnly = True
            txtcontactno.ReadOnly = True
            txtemail.ReadOnly = True
            txtregno.ReadOnly = True
            dgviewbooks.Enabled = False
            dgviewselectedbooks.Enabled = False
        End If
    End Sub
#End Region
#Region "Attributes..."
    Private Sub cmbissuedto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbissuedto.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbstudent.Focus()
        End If
    End Sub

    Private Sub cmbissuedto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbissuedto.TextChanged
        cmbstudent.Text = ""
        txtcontactno.Text = ""
        txtregno.Text = ""
        txtemail.Text = ""
        If cmbissuedto.Text <> "" Then
            LoadIssuedTo()
        End If
    End Sub

    Private Sub cmbstudent_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbstudent.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcontactno.Focus()
        End If
    End Sub

    Private Sub cmbstudent_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbstudent.TextChanged
        txtemail.Text = ""
        txtregno.Text = ""
        txtcontactno.Text = ""
        If cmbstudent.Text <> "" Then
            LoadReturnDate()
        End If
    End Sub

    Private Sub txtcontactno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcontactno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtemail.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbstudent.Focus()
        End If
    End Sub

    Private Sub txtemail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtemail.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtregno.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcontactno.Focus()
        End If
    End Sub

    Private Sub txtregno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtregno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtbookloanno.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtemail.Focus()
        End If
    End Sub

    Private Sub txtbookloanno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbookloanno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbissuedate.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtregno.Focus()
        End If
    End Sub

    Private Sub cmbissuedate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbissuedate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbduedate.Focus()
        End If
    End Sub

    Private Sub cmbduedate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbduedate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbissuedby.Focus()
        End If
    End Sub

    Private Sub cmbissuedby_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbissuedby.KeyDown
        If e.KeyCode = Keys.Up Then
            cmbduedate.Focus()
        End If
    End Sub
#End Region
#Region "DGViewEvents..."
    Private Sub dgviewbooks_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgviewbooks.CellClick
        Try
            If e.ColumnIndex = 0 Then
                If issueid < MaxBooks Then
                    Dim i As Integer = dgviewbooks.CurrentRow.Index
                    dgviewselectedbooks.Rows.Add()
                    dgviewselectedbooks.Rows(issueid).Cells(0).Value = "Remove"
                    dgviewselectedbooks.Rows(issueid).Cells(1).Value = dgviewbooks.Rows(i).Cells(1).Value.ToString()
                    dgviewselectedbooks.Rows(issueid).Cells(2).Value = dgviewbooks.Rows(i).Cells(2).Value.ToString()
                    dgviewselectedbooks.Rows(issueid).Cells(3).Value = dgviewbooks.Rows(i).Cells(3).Value.ToString()
                    dgviewselectedbooks.Rows(issueid).Cells(4).Value = dgviewbooks.Rows(i).Cells(4).Value.ToString()
                    issueid = issueid + 1
                Else
                    Dim result As DialogResult = MessageBox.Show("You have selected maximum numbers of books.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    If result = Windows.Forms.DialogResult.OK Then
                    End If
                End If
            End If
            dgviewselectedbooks.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgviewbooks_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgviewbooks.DoubleClick
        Try
            If issueid < MaxBooks Then
                Dim i As Integer = dgviewbooks.CurrentRow.Index
                dgviewselectedbooks.Rows.Add()
                dgviewselectedbooks.Rows(issueid).Cells(0).Value = "Remove"
                dgviewselectedbooks.Rows(issueid).Cells(1).Value = dgviewbooks.Rows(i).Cells(1).Value.ToString()
                dgviewselectedbooks.Rows(issueid).Cells(2).Value = dgviewbooks.Rows(i).Cells(2).Value.ToString()
                dgviewselectedbooks.Rows(issueid).Cells(3).Value = dgviewbooks.Rows(i).Cells(3).Value.ToString()
                dgviewselectedbooks.Rows(issueid).Cells(4).Value = dgviewbooks.Rows(i).Cells(4).Value.ToString()
                issueid = issueid + 1
            Else
                Dim result As DialogResult = MessageBox.Show("You have selected maximum numbers of books.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                End If
            End If
            dgviewselectedbooks.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgviewselectedbooks_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgviewselectedbooks.CellClick
        Try
            If e.ColumnIndex = 0 Then
                Dim i As Integer = dgviewselectedbooks.CurrentRow.Index
                dgviewselectedbooks.Rows.RemoveAt(i)
                issueid = issueid - 1
            End If
            dgviewbooks.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnsearch_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsearch.ClickButtonArea
        SearchRecord()
    End Sub

    Private Sub btnclear_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnclear.ClickButtonArea
        txtsearch.Text = ""
        cmbsearch.Text = ""
        dgviewbooks.ClearSelection()
        txtsearch.Focus()
    End Sub

    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updateissebooks = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updateissebooks = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updateissebooks = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updateissebooks = False Then
            ControlSetBound()
            If LSDAutoID = "Yes" Then
                GetCode()
            End If
            cmbissuedto.Items.Add(New ComboBoxIconItem("Employee", 0))
            cmbissuedto.Items.Add(New ComboBoxIconItem("Student", 1))
            cmbissuedate.Text = UmbrellaSystemDate
            LoadIsseudBy()
            LoadDataGrid()
        Else
            ControlSetBound()
            GetCode()
            cmbissuedto.Items.Add(New ComboBoxIconItem("Employee", 0))
            cmbissuedto.Items.Add(New ComboBoxIconItem("Student", 1))
            LoadIsseudBy()
            LoadDataGrid()
            LoadSelectedIssueBooks()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region