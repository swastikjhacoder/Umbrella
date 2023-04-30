#Region "Imports..."
Imports ESAR_Controls.UIControls.TextBox
#End Region
#Region "Class frmMarksheets..."
Public Class frmMarksheets
#Region "Declarations..."
    Private indx As Integer = 0
    Private ACODE As String = ""
    Private TT As String = ""
    Private DGVRegNo As New DataGridView()
    Private DGVExam As New DataGridView()
    Private Modify As Boolean = False
    Private ModifyIndex As Integer = 0
    Private DeleteIndex As Integer = 0
    Private MarksheetExist As Boolean = False
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        ACODE = Indx.LoadMarksheetCode()
        Dim var As String
        var = CodeIncrement(ACODE)
        Me.txtmarksheetid.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("MRK:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        Label1.SetBounds(15, 14, 89, 13)
        Label10.SetBounds(13, 92, 75, 13)
        Label11.SetBounds(246, 92, 76, 13)
        Label13.SetBounds(13, 115, 69, 13)
        Label14.SetBounds(246, 115, 52, 13)
        Label2.SetBounds(15, 38, 57, 13)
        Label3.SetBounds(15, 67, 56, 13)
        Label5.SetBounds(15, 94, 53, 13)
        Label6.SetBounds(291, 120, 52, 13)
        Label7.SetBounds(15, 120, 43, 13)
        Label8.SetBounds(13, 38, 71, 13)
        Label9.SetBounds(13, 65, 55, 13)
        lblexamdate.SetBounds(105, 92, 73, 13)
        lblexamtime.SetBounds(339, 92, 40, 13)

        btnadd.SetBounds(297, 144, 95, 25)
        btngeneratemarksheet.SetBounds(638, 0, 161, 25)

        cmbexaminfo.SetBounds(108, 35, 284, 21)
        cmbregid.SetBounds(110, 35, 131, 21)

        txtclass.SetBounds(110, 117, 131, 21)
        txtcourse.SetBounds(110, 91, 288, 21)
        txtfullmarks.SetBounds(108, 112, 50, 21)
        txtmarksheetid.SetBounds(129, 11, 151, 21)
        txtname.SetBounds(110, 64, 288, 21)
        txtrollno.SetBounds(349, 117, 49, 21)
        txtscored.SetBounds(342, 112, 50, 21)
        txtsubject.SetBounds(108, 62, 284, 21)
    End Sub

    Private Sub LoadRegNo()
        Try
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

            With DGVRegNo
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
                AddHandler DGVRegNo.CellClick, AddressOf DGVRegNo_CellClick
            End With

            DGVRegNo.Columns.Clear()
            DGVRegNo.Columns.Add(col1)
            DGVRegNo.Columns.Add(col2)
            DGVRegNo.Columns.Add(col3)

            DGVRegNo.Rows.Clear()
            Dim i As Integer = 0
            cmd.CommandText = "select stuid,name,course from StudentRegistration where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                DGVRegNo.Rows.Add()
                DGVRegNo.Rows(i).Cells(0).Value = dr("stuid").ToString()
                DGVRegNo.Rows(i).Cells(1).Value = dr("name").ToString()
                DGVRegNo.Rows(i).Cells(2).Value = dr("course").ToString()
                i = i + 1
            End While
            dr.Close()
            DGVRegNo.ClearSelection()

            cmbregid.AddDataGridView(DGVRegNo, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVRegNo_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVRegNo.CurrentRow.Index
            DGVRegNo.Rows(k).Selected = True
            DGVRegNo.CurrentCell = DGVRegNo.Rows(k).Cells(0)
            StuID = DGVRegNo.Rows(k).Cells(0).Value.ToString()
            StuName = DGVRegNo.Rows(k).Cells(1).Value.ToString()
            crsname = DGVRegNo.Rows(k).Cells(2).Value.ToString()
            cmbregid.Text = StuID
            txtname.Text = StuName
            txtcourse.Text = crsname
            LoadStudent(StuID)
            LoadExamInfo(StuID, StuName, crsname)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadExamInfo(ByVal regno As String, ByVal name As String, ByVal course As String)
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .HeaderText = "Exam Code"
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .HeaderText = "Course"
            End With

            With DGVExam
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
                AddHandler DGVExam.CellClick, AddressOf DGVExam_CellClick
            End With

            DGVExam.Columns.Clear()
            DGVExam.Columns.Add(col1)
            DGVExam.Columns.Add(col2)

            DGVExam.Rows.Clear()
            Dim i As Integer = 0
            cmd.CommandText = "select examcode,course from ExamStudents where stuid='" & regno & "' and name='" & name & "' and course='" & course & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                DGVExam.Rows.Add()
                DGVExam.Rows(i).Cells(0).Value = dr("examcode").ToString()
                DGVExam.Rows(i).Cells(1).Value = dr("course").ToString()
                i = i + 1
            End While
            dr.Close()
            DGVExam.ClearSelection()

            cmbexaminfo.AddDataGridView(DGVExam, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVExam_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVExam.CurrentRow.Index
            DGVExam.Rows(k).Selected = True
            DGVExam.CurrentCell = DGVExam.Rows(k).Cells(0)
            examcode = DGVExam.Rows(k).Cells(0).Value.ToString()
            cmbexaminfo.Text = examcode
            LoadExamDetails(examcode)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadExamDetails(ByVal examid As String)
        Try
            cmd.CommandText = "select subject,examdate,examtime from Examination where examcode='" & examid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            txtsubject.Text = dr("subject").ToString()
            lblexamdate.Text = dr("examdate").ToString()
            lblexamtime.Text = dr("examtime").ToString()
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadStudent(ByVal regno As String)
        Try
            cmd.CommandText = "select class,roll from StudentRegistration where stuid='" & regno & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            txtclass.Text = dr("class").ToString()
            txtrollno.Text = dr("roll").ToString()
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub AddToGrid()
        Try
            If cmbexaminfo.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter exam info.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbexaminfo.Focus()
                End If
            ElseIf txtsubject.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter exam subject.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtsubject.Focus()
                End If
            ElseIf txtfullmarks.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter subject full marks.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtfullmarks.Focus()
                End If
            ElseIf txtscored.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter exam score.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtscored.Focus()
                End If
            Else
                If Modify = False Then
                    dgviewmarks.Rows.Add()
                    dgviewmarks.Rows(indx).Cells(0).Value = cmbexaminfo.Text
                    dgviewmarks.Rows(indx).Cells(1).Value = lblexamdate.Text
                    dgviewmarks.Rows(indx).Cells(2).Value = lblexamtime.Text
                    dgviewmarks.Rows(indx).Cells(3).Value = txtsubject.Text
                    dgviewmarks.Rows(indx).Cells(4).Value = txtfullmarks.Text
                    dgviewmarks.Rows(indx).Cells(5).Value = txtscored.Text
                    indx = indx + 1
                Else
                    dgviewmarks.Rows(ModifyIndex).Cells(0).Value = cmbexaminfo.Text
                    dgviewmarks.Rows(ModifyIndex).Cells(1).Value = lblexamdate.Text
                    dgviewmarks.Rows(ModifyIndex).Cells(2).Value = lblexamtime.Text
                    dgviewmarks.Rows(ModifyIndex).Cells(3).Value = txtsubject.Text
                    dgviewmarks.Rows(ModifyIndex).Cells(4).Value = txtfullmarks.Text
                    dgviewmarks.Rows(ModifyIndex).Cells(5).Value = txtscored.Text
                    Modify = False
                End If
                cmbexaminfo.Text = ""
                lblexamdate.Text = "00-00-0000"
                lblexamtime.Text = "00:00"
                txtsubject.Text = ""
                txtfullmarks.Text = ""
                txtscored.Text = ""
                cmbexaminfo.Focus()
            End If
            dgviewmarks.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetForm()
        updatemarksheet = False
        dgviewmarks.Rows.Clear()
        txtclass.Text = ""
        cmbexaminfo.Text = ""
        cmbregid.Text = ""
        lblexamdate.Text = "00-00-0000"
        lblexamtime.Text = "00:00"
        txtcourse.Text = ""
        txtfullmarks.Text = ""
        txtname.Text = ""
        txtrollno.Text = ""
        txtscored.Text = ""
        txtsubject.Text = ""
        Modify = False
        indx = 0
        If ISDAutoID = "Yes" Then
            GetCode()
        Else
            txtmarksheetid.Text = ""
        End If
        cmbregid.Focus()
    End Sub

    Private Sub AddRecord()
        Try
            If txtmarksheetid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter marksheet id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtmarksheetid.Focus()
                End If
            ElseIf cmbregid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbregid.Focus()
                End If
            ElseIf dgviewmarks.Rows.Count = 0 Then
                Dim result As DialogResult = MessageBox.Show("Please enter marksheet details.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbexaminfo.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    CheckMarksheetID()
                    If MarksheetExist = False Then
                        Dim cls As New cMarksheet()
                        For i As Integer = 0 To dgviewmarks.Rows.Count - 1
                            Dim examcode As String = dgviewmarks.Rows(i).Cells(0).Value.ToString()
                            Dim examdate As String = dgviewmarks.Rows(i).Cells(1).Value.ToString()
                            Dim examtime As String = dgviewmarks.Rows(i).Cells(2).Value.ToString()
                            Dim subject As String = dgviewmarks.Rows(i).Cells(3).Value.ToString()
                            Dim fullmarks As Decimal = CDec(dgviewmarks.Rows(i).Cells(4).Value.ToString())
                            Dim scored As Decimal = CDec(dgviewmarks.Rows(i).Cells(5).Value.ToString())
                            cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtmarksheetid.Text, cmbregid.Text, txtname.Text, txtcourse.Text, txtclass.Text, txtrollno.Text, examcode, examdate, examtime, subject, fullmarks, scored)
                            If cls.AddOk = True Then
                                cmd.CommandText = "update Indexx set markid=markid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
                                dr = cmd.ExecuteReader
                                dr.Close()
                                Dim result1 As DialogResult = MessageBox.Show("Record added successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                If result1 = Windows.Forms.DialogResult.OK Then
                                    cmbregid.Focus()
                                End If
                            End If
                        Next
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Marksheet id already exist." + Environment.NewLine + "Please enter a new marksheet id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            txtmarksheetid.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If txtmarksheetid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter marksheet id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtmarksheetid.Focus()
                End If
            ElseIf cmbregid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbregid.Focus()
                End If
            ElseIf dgviewmarks.Rows.Count = 0 Then
                Dim result As DialogResult = MessageBox.Show("Please enter marksheet details.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbexaminfo.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cMarksheet()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtmarksheetid.Text)
                    If cls.DeleteOk = True Then
                        For i As Integer = 0 To dgviewmarks.Rows.Count - 1
                            Dim examcode As String = dgviewmarks.Rows(i).Cells(0).Value.ToString()
                            Dim examdate As String = dgviewmarks.Rows(i).Cells(1).Value.ToString()
                            Dim examtime As String = dgviewmarks.Rows(i).Cells(2).Value.ToString()
                            Dim subject As String = dgviewmarks.Rows(i).Cells(3).Value.ToString()
                            Dim fullmarks As Decimal = CDec(dgviewmarks.Rows(i).Cells(4).Value.ToString())
                            Dim scored As Decimal = CDec(dgviewmarks.Rows(i).Cells(5).Value.ToString())
                            cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtmarksheetid.Text, cmbregid.Text, txtname.Text, txtcourse.Text, txtclass.Text, txtrollno.Text, examcode, examdate, examtime, subject, fullmarks, scored)
                            If cls.AddOk = True Then
                                Dim result1 As DialogResult = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                If result1 = Windows.Forms.DialogResult.OK Then
                                    cmbregid.Focus()
                                End If
                            End If
                        Next
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If txtmarksheetid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter marksheet id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtmarksheetid.Focus()
                End If
            ElseIf cmbregid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbregid.Focus()
                End If
            ElseIf dgviewmarks.Rows.Count = 0 Then
                Dim result As DialogResult = MessageBox.Show("Please enter marksheet details.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbexaminfo.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cMarksheet()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtmarksheetid.Text)
                    If cls.DeleteOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record deleted successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            ResetForm()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedRecord()
        Try
            cmd.CommandText = "select markid,stuid,name,course,class,roll from Marksheet where markid='" & markid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            txtmarksheetid.Text = dr("markid").ToString()
            cmbregid.Text = dr("stuid").ToString()
            txtname.Text = dr("name").ToString()
            txtcourse.Text = dr("course").ToString()
            txtclass.Text = dr("class").ToString()
            txtrollno.Text = dr("roll").ToString()
            dr.Close()
            Dim i As Integer = 0
            dgviewmarks.Rows.Clear()
            cmd.CommandText = "select examinfo,examdate,examtime,subject,fullmarks,scored from Marksheet where markid='" & markid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewmarks.Rows.Add()
                dgviewmarks.Rows(i).Cells(0).Value = dr("examinfo").ToString()
                dgviewmarks.Rows(i).Cells(1).Value = dr("examdate").ToString()
                dgviewmarks.Rows(i).Cells(2).Value = dr("examtime").ToString()
                dgviewmarks.Rows(i).Cells(3).Value = dr("subject").ToString()
                dgviewmarks.Rows(i).Cells(4).Value = dr("fullmarks").ToString()
                dgviewmarks.Rows(i).Cells(5).Value = dr("scored").ToString()
                i = i + 1
            End While
            dr.Close()
            dgviewmarks.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CheckMarksheetID()
        Try
            cmd.CommandText = "select * from Marksheet where markid='" & txtmarksheetid.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                MarksheetExist = True
            Else
                MarksheetExist = False
            End If
            dr.Close()
        Catch ex As Exception
            MarksheetExist = False
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Attributes..."
    Private Sub txtmarksheetid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmarksheetid.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbregid.Focus()
        End If
    End Sub

    Private Sub cmbregid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbregid.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtname.Focus()
        End If
    End Sub

    Private Sub txtname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtcourse.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbregid.Focus()
        End If
    End Sub

    Private Sub txtcourse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcourse.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtclass.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtname.Focus()
        End If
    End Sub

    Private Sub txtclass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtclass.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtrollno.Focus()
        End If
    End Sub

    Private Sub txtrollno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtrollno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbexaminfo.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtclass.Focus()
        End If
    End Sub

    Private Sub cmbexaminfo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbexaminfo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsubject.Focus()
        End If
    End Sub

    Private Sub txtsubject_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsubject.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtfullmarks.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbexaminfo.Focus()
        End If
    End Sub

    Private Sub txtfullmarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfullmarks.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtscored.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtsubject.Focus()
        End If
    End Sub

    Private Sub txtscored_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtscored.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddToGrid()
        ElseIf e.KeyCode = Keys.Up Then
            txtfullmarks.Focus()
        End If
    End Sub

    Private Sub txtcourse_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcourse.TextChanged, txtname.TextChanged, txtsubject.TextChanged
        Dim ctc As New cTextChange()
        Dim x As eTextBox = CType(sender, eTextBox)
        ctc.ConvertTextBoxValidValue(x)
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmMarksheets_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updatemarksheet = False Then
            ControlSetBound()
            LoadRegNo()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadRegNo()
            LoadSelectedRecord()
        End If
        If USmarksheet = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbexaminfo.Enabled = False
            cmbregid.Enabled = False
            txtclass.ReadOnly = True
            txtcourse.ReadOnly = True
            txtfullmarks.ReadOnly = True
            txtmarksheetid.ReadOnly = True
            txtname.ReadOnly = True
            txtrollno.ReadOnly = True
            txtscored.ReadOnly = True
            txtsubject.ReadOnly = True
            dgviewmarks.Enabled = False
            btngeneratemarksheet.Enabled = False
            btnadd.Enabled = False
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatemarksheet = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatemarksheet = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatemarksheet = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updatemarksheet = False Then
            ControlSetBound()
            LoadRegNo()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadRegNo()
            LoadSelectedRecord()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub

    Private Sub btnadd_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnadd.ClickButtonArea
        AddToGrid()
    End Sub

    Private Sub btngeneratemarksheet_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btngeneratemarksheet.ClickButtonArea

    End Sub
#End Region
#Region "DGView Events..."
    Private Sub ModifyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyToolStripMenuItem.Click
        Dim i As Integer = dgviewmarks.CurrentRow.Index
        cmbexaminfo.Text = dgviewmarks.Rows(i).Cells(0).Value.ToString()
        lblexamdate.Text = dgviewmarks.Rows(i).Cells(1).Value.ToString()
        lblexamtime.Text = dgviewmarks.Rows(i).Cells(2).Value.ToString()
        txtsubject.Text = dgviewmarks.Rows(i).Cells(3).Value.ToString()
        txtfullmarks.Text = dgviewmarks.Rows(i).Cells(4).Value.ToString()
        txtscored.Text = dgviewmarks.Rows(i).Cells(5).Value.ToString()
        Modify = True
        ModifyIndex = i
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim i As Integer = dgviewmarks.CurrentRow.Index
        dgviewmarks.Rows.RemoveAt(i)
        indx = indx - 1
    End Sub
#End Region
End Class
#End Region