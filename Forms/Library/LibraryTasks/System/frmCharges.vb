#Region "Class frmCharges..."
Public Class frmCharges
#Region "Declarations..."
    Private DGVCourse As New DataGridView()
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(169, 38, 53, 13)
        Label10.SetBounds(70, 201, 152, 13)
        Label11.SetBounds(434, 201, 80, 13)
        Label12.SetBounds(81, 229, 141, 13)
        Label13.SetBounds(407, 229, 107, 13)
        Label14.SetBounds(68, 256, 154, 13)
        Label15.SetBounds(368, 256, 148, 13)
        Label2.SetBounds(102, 66, 120, 13)
        Label3.SetBounds(345, 66, 169, 13)
        Label4.SetBounds(68, 120, 154, 13)
        Label5.SetBounds(372, 120, 142, 13)
        Label6.SetBounds(62, 147, 160, 13)
        Label7.SetBounds(360, 147, 154, 13)
        Label8.SetBounds(30, 174, 192, 13)
        Label9.SetBounds(334, 174, 180, 13)

        chkreference.SetBounds(228, 93, 165, 17)
        cmbcourse.SetBounds(228, 35, 369, 21)

        nudreserveperiod.SetBounds(520, 63, 77, 21)
        nudmaxbook.SetBounds(228, 118, 77, 21)
        nudreturndaysbooks.SetBounds(520, 118, 77, 21)
        nudreturndeysjournals.SetBounds(520, 145, 77, 21)
        nudmaxjournal.SetBounds(228, 145, 77, 21)
        nudreturndayscomp.SetBounds(520, 172, 77, 21)
        nudmaxcomp.SetBounds(228, 172, 77, 21)
        nudlockerperiod.SetBounds(228, 199, 77, 21)

        txtfineperday.SetBounds(228, 63, 77, 21)
        txtlosingcardcharge.SetBounds(228, 226, 77, 21)
        txtlockerfees.SetBounds(520, 198, 77, 21)
        txtlockerfine.SetBounds(520, 226, 77, 21)
        txtidcardcharge.SetBounds(520, 253, 77, 21)
        txtlosingjournal.SetBounds(228, 253, 77, 21)
    End Sub

    Private Sub LoadCourse()
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .Name = "Col1"
                .HeaderText = "Code"
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .Name = "Col2"
                .HeaderText = "Course"
            End With
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .Name = "Col3"
                .HeaderText = "Duration"
            End With

            With DGVCourse
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
                AddHandler DGVCourse.CellClick, AddressOf DGVCourse_CellClick
            End With

            DGVCourse.Columns.Clear()
            DGVCourse.Columns.Add(col1)
            DGVCourse.Columns.Add(col2)
            DGVCourse.Columns.Add(col3)

            DGVCourse.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select CourseCode,CourseName,Duration from Course where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVCourse.Rows.Add()
                DGVCourse.Rows(indx).Cells(0).Value = dr("CourseCode").ToString()
                DGVCourse.Rows(indx).Cells(1).Value = dr("CourseName").ToString()
                DGVCourse.Rows(indx).Cells(2).Value = dr("Duration").ToString()

                indx = indx + 1
            End While
            dr.Close()
            DGVCourse.ClearSelection()

            cmbcourse.AddDataGridView(DGVCourse, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVCourse_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVCourse.CurrentRow.Index
            DGVCourse.Rows(k).Selected = True
            DGVCourse.CurrentCell = DGVCourse.Rows(k).Cells(0)
            crscode = DGVCourse.Rows(k).Cells(0).Value.ToString()
            crsname = DGVCourse.Rows(k).Cells(1).Value.ToString()
            crsduration = DGVCourse.Rows(k).Cells(2).Value.ToString()
            cmbcourse.Text = crsname
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedCharge()
        Try
            cmd.CommandText = "select * from BookCharges where course='" & CourseCharge & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                cmbcourse.Text = dr("course").ToString()
                txtfineperday.Text = dr("finerate").ToString()
                nudreserveperiod.Value = CInt(dr("reserveperiod").ToString())
                If dr("referencebooks").ToString() = "Yes" Then
                    chkreference.Checked = True
                Else
                    chkreference.Checked = False
                End If
                nudmaxbook.Value = CInt(dr("maxbooks").ToString())
                nudreturndaysbooks.Value = CInt(dr("booksreturndays").ToString())
                nudmaxjournal.Value = CInt(dr("maxjournal").ToString())
                nudreturndeysjournals.Value = CInt(dr("journalreturndays").ToString())
                nudmaxcomp.Value = CInt(dr("maxcompbook").ToString())
                nudreturndayscomp.Value = CInt(dr("compbookreturndays").ToString())
                nudlockerperiod.Value = CInt(dr("lockerperiod").ToString())
                txtlockerfees.Text = dr("lockerfees").ToString()
                txtlosingcardcharge.Text = dr("losingcardcharge").ToString()
                txtlockerfine.Text = dr("lockerfine").ToString()
                txtlosingjournal.Text = dr("losingjournalcharge").ToString()
                txtidcardcharge.Text = dr("idcardcharge").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub ResetForm()
        Try
            chkreference.Checked = True
            cmbcourse.Text = ""
            txtfineperday.Text = ""
            txtidcardcharge.Text = ""
            txtlockerfees.Text = ""
            txtlockerfine.Text = ""
            txtlosingcardcharge.Text = ""
            txtlosingjournal.Text = ""
            nudlockerperiod.Value = 0
            nudmaxbook.Value = 0
            nudmaxcomp.Value = 0
            nudmaxjournal.Value = 0
            nudreserveperiod.Value = 0
            nudreturndaysbooks.Value = 0
            nudreturndayscomp.Value = 0
            nudreturndeysjournals.Value = 0
            cmbcourse.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddRecord()
        Try
            If cmbcourse.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select course.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbcourse.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim course As String = cmbcourse.Text
                    Dim referencebooks As String = ""
                    If chkreference.Checked = True Then
                        referencebooks = "Yes"
                    Else
                        referencebooks = "No"
                    End If
                    Dim finerate As Decimal = 0.0
                    If txtfineperday.Text = "" Then
                        finerate = 0.0
                    Else
                        finerate = CDec(txtfineperday.Text)
                    End If
                    Dim reserveperiod As Integer = CInt(nudreserveperiod.Value.ToString())
                    Dim maxbooks As Integer = CInt(nudmaxbook.Value.ToString())
                    Dim booksreturndays As Integer = CInt(nudreturndaysbooks.Value.ToString())
                    Dim maxjournal As Integer = CInt(nudmaxjournal.Value.ToString())
                    Dim journalreturndays As Integer = CInt(nudreturndeysjournals.Value.ToString())
                    Dim maxcompbook As Integer = CInt(nudmaxcomp.Value.ToString())
                    Dim compbookreturndays As Integer = CInt(nudreturndayscomp.Value.ToString())
                    Dim lockerperiod As Integer = CInt(nudlockerperiod.Value.ToString())
                    Dim lockerfees As Decimal = 0.0
                    If txtlockerfees.Text = "" Then
                        lockerfees = 0.0
                    Else
                        lockerfees = CDec(txtlockerfees.Text)
                    End If
                    Dim losingcardcharge As Decimal = 0.0
                    If txtlosingcardcharge.Text = "" Then
                        losingcardcharge = 0.0
                    Else
                        losingcardcharge = CDec(txtlosingcardcharge.Text)
                    End If
                    Dim lockerfine As Decimal = 0.0
                    If txtlockerfine.Text = "" Then
                        lockerfine = 0.0
                    Else
                        lockerfine = CDec(txtlockerfine.Text)
                    End If
                    Dim losingjournalcharge As Decimal = 0.0
                    If txtlosingjournal.Text = "" Then
                        losingjournalcharge = 0.0
                    Else
                        losingjournalcharge = CDec(txtlosingjournal.Text)
                    End If
                    Dim idcardcharge As Decimal = 0.0
                    If txtidcardcharge.Text = "" Then
                        idcardcharge = 0.0
                    Else
                        idcardcharge = CDec(txtidcardcharge.Text)
                    End If
                    Dim cls As New cCharges()
                    cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbcourse.Text, referencebooks, finerate, reserveperiod, maxbooks, booksreturndays, maxjournal, journalreturndays, maxcompbook, compbookreturndays, lockerperiod, lockerfees, losingcardcharge, lockerfine, losingjournalcharge, idcardcharge)
                    If cls.AddChargeOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record added successfully", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            cmbcourse.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If cmbcourse.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select course.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbcourse.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim course As String = cmbcourse.Text
                    Dim referencebooks As String = ""
                    If chkreference.Checked = True Then
                        referencebooks = "Yes"
                    Else
                        referencebooks = "No"
                    End If
                    Dim finerate As Decimal = 0.0
                    If txtfineperday.Text = "" Then
                        finerate = 0.0
                    Else
                        finerate = CDec(txtfineperday.Text)
                    End If
                    Dim reserveperiod As Integer = CInt(nudreserveperiod.Value.ToString())
                    Dim maxbooks As Integer = CInt(nudmaxbook.Value.ToString())
                    Dim booksreturndays As Integer = CInt(nudreturndaysbooks.Value.ToString())
                    Dim maxjournal As Integer = CInt(nudmaxjournal.Value.ToString())
                    Dim journalreturndays As Integer = CInt(nudreturndeysjournals.Value.ToString())
                    Dim maxcompbook As Integer = CInt(nudmaxcomp.Value.ToString())
                    Dim compbookreturndays As Integer = CInt(nudreturndayscomp.Value.ToString())
                    Dim lockerperiod As Integer = CInt(nudlockerperiod.Value.ToString())
                    Dim lockerfees As Decimal = 0.0
                    If txtlockerfees.Text = "" Then
                        lockerfees = 0.0
                    Else
                        lockerfees = CDec(txtlockerfees.Text)
                    End If
                    Dim losingcardcharge As Decimal = 0.0
                    If txtlosingcardcharge.Text = "" Then
                        losingcardcharge = 0.0
                    Else
                        losingcardcharge = CDec(txtlosingcardcharge.Text)
                    End If
                    Dim lockerfine As Decimal = 0.0
                    If txtlockerfine.Text = "" Then
                        lockerfine = 0.0
                    Else
                        lockerfine = CDec(txtlockerfine.Text)
                    End If
                    Dim losingjournalcharge As Decimal = 0.0
                    If txtlosingjournal.Text = "" Then
                        losingjournalcharge = 0.0
                    Else
                        losingjournalcharge = CDec(txtlosingjournal.Text)
                    End If
                    Dim idcardcharge As Decimal = 0.0
                    If txtidcardcharge.Text = "" Then
                        idcardcharge = 0.0
                    Else
                        idcardcharge = CDec(txtidcardcharge.Text)
                    End If
                    Dim cls As New cCharges()
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbcourse.Text, referencebooks, finerate, reserveperiod, maxbooks, booksreturndays, maxjournal, journalreturndays, maxcompbook, compbookreturndays, lockerperiod, lockerfees, losingcardcharge, lockerfine, losingjournalcharge, idcardcharge)
                    If cls.UpdateChargeOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            cmbcourse.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If cmbcourse.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select course.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbcourse.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cCharges()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbcourse.Text)
                    If cls.DeleteChargeOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record deleted successfully", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            ResetForm()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmCharges_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updatebookcharge = False Then
            ControlSetBound()
            LoadCourse()
        Else
            ControlSetBound()
            LoadCourse()
            LoadSelectedCharge()
        End If
        If UScharges = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbcourse.Enabled = False
            chkreference.Enabled = False
            txtfineperday.ReadOnly = True
            txtidcardcharge.ReadOnly = True
            txtlockerfees.ReadOnly = True
            txtlockerfine.ReadOnly = True
            txtlosingcardcharge.ReadOnly = True
            txtlosingjournal.ReadOnly = True
            nudlockerperiod.Enabled = False
            nudmaxbook.Enabled = False
            nudmaxcomp.Enabled = False
            nudmaxjournal.Enabled = False
            nudreserveperiod.Enabled = False
            nudreturndaysbooks.Enabled = False
            nudreturndayscomp.Enabled = False
            nudreturndeysjournals.Enabled = False
        End If
    End Sub
#End Region
#Region "Attributes..."
    Private Sub cmbcourse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcourse.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtfineperday.Focus()
        End If
    End Sub

    Private Sub txtfineperday_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfineperday.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            nudreserveperiod.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbcourse.Focus()
        End If
    End Sub

    Private Sub nudreserveperiod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudreserveperiod.KeyDown
        If e.KeyCode = Keys.Enter Then
            nudmaxbook.Focus()
        End If
    End Sub

    Private Sub nudmaxbook_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudmaxbook.KeyDown
        If e.KeyCode = Keys.Enter Then
            nudreturndaysbooks.Focus()
        End If
    End Sub

    Private Sub nudreturndaysbooks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudreturndaysbooks.KeyDown
        If e.KeyCode = Keys.Enter Then
            nudmaxjournal.Focus()
        End If
    End Sub

    Private Sub nudmaxjournal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudmaxjournal.KeyDown
        If e.KeyCode = Keys.Enter Then
            nudreturndeysjournals.Focus()
        End If
    End Sub

    Private Sub nudreturndeysjournals_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudreturndeysjournals.KeyDown
        If e.KeyCode = Keys.Enter Then
            nudmaxcomp.Focus()
        End If
    End Sub

    Private Sub nudmaxcomp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudmaxcomp.KeyDown
        If e.KeyCode = Keys.Enter Then
            nudreturndayscomp.Focus()
        End If
    End Sub

    Private Sub nudreturndayscomp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudreturndayscomp.KeyDown
        If e.KeyCode = Keys.Enter Then
            nudlockerperiod.Focus()
        End If
    End Sub

    Private Sub nudlockerperiod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudlockerperiod.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtlockerfees.Focus()
        End If
    End Sub

    Private Sub txtlockerfees_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlockerfees.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtlosingcardcharge.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            nudlockerperiod.Focus()
        End If
    End Sub

    Private Sub txtlosingcardcharge_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlosingcardcharge.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtlockerfine.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtlockerfees.Focus()
        End If
    End Sub

    Private Sub txtlockerfine_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlockerfine.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtlosingjournal.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtlosingcardcharge.Focus()
        End If
    End Sub

    Private Sub txtlosingjournal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlosingjournal.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtidcardcharge.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtlockerfine.Focus()
        End If
    End Sub

    Private Sub txtidcardcharge_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtidcardcharge.KeyDown
        If e.KeyCode = Keys.Up Then
            txtlosingjournal.Focus()
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatebookcharge = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatebookcharge = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatebookcharge = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updatebookcharge = False Then
            ControlSetBound()
            LoadCourse()
        Else
            ControlSetBound()
            LoadCourse()
            LoadSelectedCharge()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region