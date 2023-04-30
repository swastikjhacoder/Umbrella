#Region "Class frmBooks..."
Public Class frmBooks
#Region "Declarations..."
    Private BCODE As String = ""
    Private TT As String = ""
    Private DGVBookID As New DataGridView()
    Private DGVGroupID As New DataGridView()
    Private DGVSubject As New DataGridView()
    Private BookExist As Boolean = False
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        BCODE = Indx.LoadBookID()
        Dim var As String
        var = CodeIncrement(BCODE)
        Me.cmbbookid.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("BK:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        Label1.SetBounds(15, 35, 59, 13)
        Label3.SetBounds(15, 62, 78, 13)
        Label4.SetBounds(15, 89, 86, 13)
        Label5.SetBounds(15, 116, 94, 13)
        Label6.SetBounds(15, 143, 70, 13)
        Label7.SetBounds(15, 170, 56, 13)
        Label8.SetBounds(15, 197, 50, 13)
        Label9.SetBounds(15, 224, 82, 13)
        Label10.SetBounds(199, 224, 77, 13)
        Label11.SetBounds(351, 224, 40, 13)

        nudcopies.SetBounds(132, 222, 61, 21)
        nudpages.SetBounds(282, 222, 61, 21)

        cmbbookid.SetBounds(132, 32, 140, 21)
        cmbgroup.SetBounds(132, 86, 285, 21)
        cmbsubject.SetBounds(132, 113, 285, 21)

        txtbookname.SetBounds(132, 59, 560, 21)
        txtpublisher.SetBounds(132, 140, 285, 21)
        txtauthor.SetBounds(132, 167, 285, 21)
        txtedition.SetBounds(132, 194, 95, 21)
        txtprice.SetBounds(397, 222, 55, 21)
    End Sub

    Private Sub LoadSubjectID()
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .Name = "Col1"
                .HeaderText = "Subject ID"
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .Name = "Col2"
                .HeaderText = "Subject Name"
            End With
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .Name = "Col3"
                .HeaderText = "Details"
            End With

            With DGVSubject
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
                AddHandler DGVSubject.CellClick, AddressOf DGVSubject_CellClick
            End With

            DGVSubject.Columns.Clear()
            DGVSubject.Columns.Add(col1)
            DGVSubject.Columns.Add(col2)
            DGVSubject.Columns.Add(col3)

            DGVSubject.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select subjectid,subjectname,subjectdetails from SubjectBooks where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVSubject.Rows.Add()
                DGVSubject.Rows(indx).Cells(0).Value = dr("subjectid").ToString()
                DGVSubject.Rows(indx).Cells(1).Value = dr("subjectname").ToString()
                DGVSubject.Rows(indx).Cells(2).Value = dr("subjectdetails").ToString()

                indx = indx + 1
            End While
            dr.Close()
            DGVSubject.ClearSelection()

            cmbsubject.AddDataGridView(DGVSubject, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVSubject_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVSubject.CurrentRow.Index
            DGVSubject.Rows(k).Selected = True
            DGVSubject.CurrentCell = DGVSubject.Rows(k).Cells(0)
            SubjectName = DGVSubject.Rows(k).Cells(1).Value.ToString()
            cmbsubject.Text = SubjectName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadGroupID()
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .Name = "Col1"
                .HeaderText = "Group ID"
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .Name = "Col2"
                .HeaderText = "Group Name"
            End With
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .Name = "Col3"
                .HeaderText = "Details"
            End With

            With DGVGroupID
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
                AddHandler DGVGroupID.CellClick, AddressOf DGVGroupID_CellClick
            End With

            DGVGroupID.Columns.Clear()
            DGVGroupID.Columns.Add(col1)
            DGVGroupID.Columns.Add(col2)
            DGVGroupID.Columns.Add(col3)

            DGVGroupID.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select groupid,groupname,groupdetails from GroupBooks where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVGroupID.Rows.Add()
                DGVGroupID.Rows(indx).Cells(0).Value = dr("groupid").ToString()
                DGVGroupID.Rows(indx).Cells(1).Value = dr("groupname").ToString()
                DGVGroupID.Rows(indx).Cells(2).Value = dr("groupdetails").ToString()

                indx = indx + 1
            End While
            dr.Close()
            DGVGroupID.ClearSelection()

            cmbgroup.AddDataGridView(DGVGroupID, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVGroupID_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVGroupID.CurrentRow.Index
            DGVGroupID.Rows(k).Selected = True
            DGVGroupID.CurrentCell = DGVGroupID.Rows(k).Cells(0)
            GroupName = DGVGroupID.Rows(k).Cells(1).Value.ToString()
            cmbgroup.Text = GroupName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedBook()
        Try
            cmd.CommandText = "select bookid,bookname,groupname,subject,publisher,author,edition,copies,pages,price,particulars from Books where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and bookid='" & BookID & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                cmbbookid.Text = dr("bookid").ToString()
                txtbookname.Text = dr("bookname").ToString()
                cmbgroup.Text = dr("groupname").ToString()
                cmbsubject.Text = dr("subject").ToString()
                txtpublisher.Text = dr("publisher").ToString()
                txtauthor.Text = dr("author").ToString()
                txtedition.Text = dr("edition").ToString()
                nudcopies.Value = CInt(dr("copies").ToString())
                nudpages.Value = CInt(dr("pages").ToString())
                txtprice.Text = dr("price").ToString()
                rtbparticulars.rtb.Text = dr("particulars").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub AddRecord()
        Try
            If cmbbookid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter book id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbbookid.Focus()
                End If
            ElseIf cmbgroup.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter group.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbgroup.Focus()
                End If
            ElseIf cmbsubject.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter subject.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbsubject.Focus()
                End If
            ElseIf txtauthor.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter author name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtauthor.Focus()
                End If
            ElseIf txtbookname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter book name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtbookname.Focus()
                End If
            ElseIf txtedition.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter book edition.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtedition.Focus()
                End If
            ElseIf txtprice.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter book price.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtprice.Focus()
                End If
            ElseIf txtpublisher.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter publisher name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtpublisher.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    If BookExist = False Then
                        Dim cls As New cBook()
                        cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbbookid.Text, txtbookname.Text, cmbgroup.Text, cmbsubject.Text, txtpublisher.Text, txtauthor.Text, txtedition.Text, CInt(nudcopies.Value.ToString()), CInt(nudpages.Value.ToString()), CDec(txtprice.Text), rtbparticulars.rtb.Text)
                        If cls.AddBookOk = True Then
                            Dim result1 As DialogResult = MessageBox.Show("Record added successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = Windows.Forms.DialogResult.OK Then
                                cmbbookid.Focus()
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Book id already exist." + Environment.NewLine + "Please enter a new book id.", "Umbrella - Duplicate Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            cmbbookid.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If cmbbookid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter book id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbbookid.Focus()
                End If
            ElseIf cmbgroup.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter group.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbgroup.Focus()
                End If
            ElseIf cmbsubject.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter subject.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbsubject.Focus()
                End If
            ElseIf txtauthor.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter author name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtauthor.Focus()
                End If
            ElseIf txtbookname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter book name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtbookname.Focus()
                End If
            ElseIf txtedition.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter book edition.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtedition.Focus()
                End If
            ElseIf txtprice.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter book price.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtprice.Focus()
                End If
            ElseIf txtpublisher.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter publisher name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtpublisher.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cBook()
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbbookid.Text, txtbookname.Text, cmbgroup.Text, cmbsubject.Text, txtpublisher.Text, txtauthor.Text, txtedition.Text, CInt(nudcopies.Value.ToString()), CInt(nudpages.Value.ToString()), CDec(txtprice.Text), rtbparticulars.rtb.Text)
                    If cls.UpdateBookOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            cmbbookid.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If cmbbookid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter book id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbbookid.Focus()
                End If
            ElseIf cmbgroup.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter group.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbgroup.Focus()
                End If
            ElseIf cmbsubject.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter subject.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbsubject.Focus()
                End If
            ElseIf txtauthor.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter author name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtauthor.Focus()
                End If
            ElseIf txtbookname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter book name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtbookname.Focus()
                End If
            ElseIf txtedition.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter book edition.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtedition.Focus()
                End If
            ElseIf txtprice.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter book price.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtprice.Focus()
                End If
            ElseIf txtpublisher.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter publisher name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtpublisher.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cBook()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbbookid.Text)
                    If cls.DeleteBookOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record added successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            ResetForm()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetForm()
        updatebook = False
        nudcopies.Value = nudcopies.Minimum
        nudpages.Value = nudpages.Minimum
        cmbgroup.Text = ""
        cmbsubject.Text = ""
        txtauthor.Text = ""
        txtbookname.Text = ""
        txtedition.Text = ""
        txtprice.Text = ""
        txtpublisher.Text = ""
        rtbparticulars.rtb.Text = ""
        If LSDAutoID = "Yes" Then
            GetCode()
        Else
            cmbbookid.Text = ""
        End If
        cmbbookid.Focus()
    End Sub

    Private Sub CheckBookID()
        Try
            cmd.CommandText = "select * from Books where bookid='" & cmbbookid.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                BookExist = True
            Else
                BookExist = False
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
            BookExist = False
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If updatebook = False Then
            ControlSetBound()
            LoadGroupID()
            LoadSubjectID()
            If LSDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadGroupID()
            LoadSubjectID()
            LoadSelectedBook()
        End If
        If USbookrecords = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbbookid.Enabled = False
            cmbgroup.Enabled = False
            cmbsubject.Enabled = False
            txtauthor.ReadOnly = True
            txtbookname.ReadOnly = True
            txtedition.ReadOnly = True
            txtprice.ReadOnly = True
            txtpublisher.ReadOnly = True
            nudcopies.Enabled = False
            nudpages.Enabled = False
        End If
    End Sub
#End Region
#Region "Attributes..."
    Private Sub cmbbookid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbbookid.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtbookname.Focus()
        End If
    End Sub

    Private Sub txtbookname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbookname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbgroup.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtbookname.Focus()
        End If
    End Sub

    Private Sub cmbgroup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbgroup.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbsubject.Focus()
        End If
    End Sub

    Private Sub cmbsubject_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbsubject.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpublisher.Focus()
        End If
    End Sub

    Private Sub txtpublisher_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpublisher.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtauthor.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbsubject.Focus()
        End If
    End Sub

    Private Sub txtauthor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtauthor.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtedition.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtpublisher.Focus()
        End If
    End Sub

    Private Sub txtedition_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtedition.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            nudcopies.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtauthor.Focus()
        End If
    End Sub

    Private Sub nudcopies_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudcopies.KeyDown
        If e.KeyCode = Keys.Enter Then
            nudpages.Focus()
        End If
    End Sub

    Private Sub nudpages_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudpages.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtprice.Focus()
        End If
    End Sub

    Private Sub txtprice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtprice.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            rtbparticulars.rtb.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            nudpages.Focus()
        End If
    End Sub

    Private Sub txtprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprice.KeyPress
        If Asc(e.KeyChar) = 32 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtauthor.TextChanged, txtbookname.TextChanged, txtedition.TextChanged, txtpublisher.TextChanged
        Dim x As ESAR_Controls.UIControls.TextBox.eTextBox = CType(sender, ESAR_Controls.UIControls.TextBox.eTextBox)
        ctc.ConvertTextBoxValidValue(x)
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatebook = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatebook = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatebook = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updatebook = False Then
            ControlSetBound()
            LoadGroupID()
            LoadSubjectID()
            If LSDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadGroupID()
            LoadSubjectID()
            LoadSelectedBook()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region