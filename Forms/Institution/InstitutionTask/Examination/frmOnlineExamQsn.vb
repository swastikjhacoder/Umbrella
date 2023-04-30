#Region "Class frmOnlineExamQsn..."
Public Class frmOnlineExamQsn
#Region "Declarations..."
    Private ACODE As String = ""
    Private TT As String = ""
    Private Modify As Boolean = False
    Private i As Integer = 0
    Private modifyindex As Integer = 0
    Private QsnIDExist As Boolean = False
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        ACODE = Indx.LoadOnlineExamID()
        Dim var As String
        var = CodeIncrement(ACODE)
        Me.txtexamcode.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("OXM:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        Label1.SetBounds(12, 20, 78, 13)
        Label10.SetBounds(553, 20, 50, 13)
        Label11.SetBounds(620, 20, 76, 13)
        Label2.SetBounds(226, 20, 75, 13)
        Label3.SetBounds(12, 17, 62, 13)
        Label4.SetBounds(12, 44, 65, 13)
        Label5.SetBounds(12, 71, 65, 13)
        Label6.SetBounds(12, 98, 65, 13)
        Label7.SetBounds(12, 125, 65, 13)
        Label8.SetBounds(12, 152, 54, 26)
        Label9.SetBounds(420, 20, 61, 13)

        btnreset.SetBounds(648, 149, 70, 25)
        btnnext.SetBounds(724, 149, 65, 25)

        cmbdate.SetBounds(307, 17, 107, 21)
        cmbrightans.SetBounds(86, 149, 124, 21)
        nudminutes.SetBounds(487, 18, 60, 21)

        txtans1.SetBounds(86, 41, 703, 21)
        txtans2.SetBounds(86, 68, 703, 21)
        txtans3.SetBounds(86, 95, 703, 21)
        txtans4.SetBounds(86, 122, 703, 21)
        txtqsn.SetBounds(86, 14, 703, 21)
        txtexamcode.SetBounds(96, 17, 124, 21)
        mskexamtime.SetBounds(702, 20, 40, 14)
    End Sub

    Private Sub AddToGrid()
        Try
            If txtqsn.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter question.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtqsn.Focus()
                End If
            ElseIf txtans1.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter first answer.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtans1.Focus()
                End If
            ElseIf txtans2.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter second answer.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtans2.Focus()
                End If
            ElseIf cmbrightans.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select right answer.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbrightans.Focus()
                End If
            Else
                Dim rightans As String = ""
                If cmbrightans.Text = "Answer 1" Then
                    rightans = txtans1.Text
                ElseIf cmbrightans.Text = "Answer 2" Then
                    rightans = txtans2.Text
                ElseIf cmbrightans.Text = "Answer 3" Then
                    rightans = txtans3.Text
                ElseIf cmbrightans.Text = "Answer 4" Then
                    rightans = txtans4.Text
                End If
                If Modify = False Then
                    dgviewqsn.Rows.Add()
                    dgviewqsn.Rows(i).Cells(1).Value = txtqsn.Text
                    dgviewqsn.Rows(i).Cells(2).Value = txtans1.Text
                    dgviewqsn.Rows(i).Cells(3).Value = txtans2.Text
                    dgviewqsn.Rows(i).Cells(4).Value = txtans3.Text
                    dgviewqsn.Rows(i).Cells(5).Value = txtans4.Text
                    dgviewqsn.Rows(i).Cells(6).Value = rightans
                    i = i + 1
                Else
                    dgviewqsn.Rows(modifyindex).Cells(1).Value = txtqsn.Text
                    dgviewqsn.Rows(modifyindex).Cells(2).Value = txtans1.Text
                    dgviewqsn.Rows(modifyindex).Cells(3).Value = txtans2.Text
                    dgviewqsn.Rows(modifyindex).Cells(4).Value = txtans3.Text
                    dgviewqsn.Rows(modifyindex).Cells(5).Value = txtans4.Text
                    dgviewqsn.Rows(modifyindex).Cells(6).Value = rightans
                    Modify = False
                End If
                For indx As Integer = 0 To dgviewqsn.Rows.Count - 1
                    dgviewqsn.Rows(indx).Cells(0).Value = (indx + 1).ToString()
                    dgviewqsn.Rows(indx).Cells(0).Style.BackColor = Color.DimGray
                    dgviewqsn.Rows(indx).Cells(0).Style.ForeColor = Color.White
                    dgviewqsn.Rows(indx).Cells(0).Style.SelectionBackColor = Color.DimGray
                    dgviewqsn.Rows(indx).Cells(0).Style.SelectionForeColor = Color.White
                Next
                dgviewqsn.ClearSelection()
                txtqsn.Text = ""
                txtans1.Text = ""
                txtans2.Text = ""
                txtans3.Text = ""
                txtans4.Text = ""
                cmbrightans.Text = ""
                txtqsn.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetForm()
        updateonlineqsn = False
        dgviewqsn.Rows.Clear()
        Modify = False
        i = 0
        cmbdate.Text = UmbrellaSystemDate
        cmbrightans.Text = ""
        txtans1.Text = ""
        txtans2.Text = ""
        txtans3.Text = ""
        txtans4.Text = ""
        txtqsn.Text = ""
        nudminutes.Value = nudminutes.Minimum
        mskexamtime.Text = Date.Now.ToShortTimeString()
        If ISDAutoID = "Yes" Then
            GetCode()
        Else
            txtexamcode.Text = ""
        End If
        txtexamcode.Focus()
    End Sub

    Private Sub AddRecord()
        Try
            If txtexamcode.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter online exam id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtexamcode.Focus()
                End If
            ElseIf cmbdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter online exam date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbdate.Focus()
                End If
            ElseIf dgviewqsn.Rows.Count <= 0 Then
                Dim result As DialogResult = MessageBox.Show("Please create online exam question paper.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtqsn.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    CheckQsnID()
                    If QsnIDExist = False Then
                        Dim cls As New cOnlineExamQsn()
                        For row As Integer = 0 To dgviewqsn.Rows.Count - 1
                            Dim qsn As String = dgviewqsn.Rows(row).Cells(1).Value.ToString()
                            Dim ans1 As String = dgviewqsn.Rows(row).Cells(2).Value.ToString()
                            Dim ans2 As String = dgviewqsn.Rows(row).Cells(3).Value.ToString()
                            Dim ans3 As String = dgviewqsn.Rows(row).Cells(4).Value.ToString()
                            Dim ans4 As String = dgviewqsn.Rows(row).Cells(5).Value.ToString()
                            Dim rightans As String = dgviewqsn.Rows(row).Cells(6).Value.ToString()
                            cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtexamcode.Text, cmbdate.Text, mskexamtime.Text, CInt(nudminutes.Value.ToString()), qsn, ans1, ans2, ans3, ans4, rightans)
                        Next
                        If cls.AddRecordOk = True Then
                            cmd.CommandText = "update Indexx set onlinexmid=onlinexmid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                            Dim result1 As DialogResult = MessageBox.Show("Record added successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = Windows.Forms.DialogResult.OK Then
                                txtexamcode.Focus()
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Online exam id already exist." + Environment.NewLine + "Please enter a new online exam id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            txtexamcode.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If txtexamcode.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter online exam id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtexamcode.Focus()
                End If
            ElseIf cmbdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter online exam date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbdate.Focus()
                End If
            ElseIf dgviewqsn.Rows.Count <= 0 Then
                Dim result As DialogResult = MessageBox.Show("Please create online exam question paper.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtqsn.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cOnlineExamQsn()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, txtexamcode.Text, cmbdate.Text)
                    If cls.DeleteRecordOk = True Then
                        For row As Integer = 0 To dgviewqsn.Rows.Count - 1
                            Dim qsn As String = dgviewqsn.Rows(row).Cells(1).Value.ToString()
                            Dim ans1 As String = dgviewqsn.Rows(row).Cells(2).Value.ToString()
                            Dim ans2 As String = dgviewqsn.Rows(row).Cells(3).Value.ToString()
                            Dim ans3 As String = dgviewqsn.Rows(row).Cells(4).Value.ToString()
                            Dim ans4 As String = dgviewqsn.Rows(row).Cells(5).Value.ToString()
                            Dim rightans As String = dgviewqsn.Rows(row).Cells(6).Value.ToString()
                            cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtexamcode.Text, cmbdate.Text, mskexamtime.Text, CInt(nudminutes.Value.ToString()), qsn, ans1, ans2, ans3, ans4, rightans)
                        Next
                        If cls.AddRecordOk = True Then
                            Dim result1 As DialogResult = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = Windows.Forms.DialogResult.OK Then
                                txtexamcode.Focus()
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
            If txtexamcode.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter online exam id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtexamcode.Focus()
                End If
            ElseIf cmbdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter online exam date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbdate.Focus()
                End If
            ElseIf dgviewqsn.Rows.Count <= 0 Then
                Dim result As DialogResult = MessageBox.Show("Please create online exam question paper.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtqsn.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cOnlineExamQsn()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, txtexamcode.Text, cmbdate.Text)
                    If cls.DeleteRecordOk = True Then
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
            Dim indx As Integer = 0
            dgviewqsn.Rows.Clear()
            cmd.CommandText = "select examid,examdate,examtime,examduration,qsn,ans1,ans2,ans3,ans4,rightans from OnlineExamQsn where examid='" & qsnid & "' and examdate='" & qsndate & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                txtexamcode.Text = dr("examid").ToString()
                cmbdate.Text = dr("examdate").ToString()
                mskexamtime.Text = dr("examtime").ToString()
                nudminutes.Value = CInt(dr("examduration").ToString())
                dgviewqsn.Rows.Add()
                dgviewqsn.Rows(indx).Cells(1).Value = dr("qsn").ToString()
                dgviewqsn.Rows(indx).Cells(2).Value = dr("ans1").ToString()
                dgviewqsn.Rows(indx).Cells(3).Value = dr("ans2").ToString()
                dgviewqsn.Rows(indx).Cells(4).Value = dr("ans3").ToString()
                dgviewqsn.Rows(indx).Cells(5).Value = dr("ans4").ToString()
                dgviewqsn.Rows(indx).Cells(6).Value = dr("rightans").ToString()
                indx = indx + 1
                i = indx
            End While
            dr.Close()
            For row As Integer = 0 To dgviewqsn.Rows.Count - 1
                dgviewqsn.Rows(row).Cells(0).Value = (row + 1).ToString()
                dgviewqsn.Rows(row).Cells(0).Style.BackColor = Color.DimGray
                dgviewqsn.Rows(row).Cells(0).Style.ForeColor = Color.White
                dgviewqsn.Rows(row).Cells(0).Style.SelectionBackColor = Color.DimGray
                dgviewqsn.Rows(row).Cells(0).Style.SelectionForeColor = Color.White
            Next
            dgviewqsn.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CheckQsnID()
        Try
            cmd.CommandText = "select * from OnlineExamQsn where examid='" & txtexamcode.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                QsnIDExist = True
            Else
                QsnIDExist = False
            End If
            dr.Close()
        Catch ex As Exception
            QsnIDExist = False
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmOnlineExamQsn_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updateonlineqsn = False Then
            ControlSetBound()
            cmbdate.Text = UmbrellaSystemDate
            mskexamtime.Text = Date.Now.ToShortTimeString()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadSelectedRecord()
        End If
        If USexamination = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbdate.Enabled = False
            cmbrightans.Enabled = False
            txtans1.ReadOnly = True
            txtans2.ReadOnly = True
            txtans3.ReadOnly = True
            txtans4.ReadOnly = True
            txtqsn.ReadOnly = True
            mskexamtime.ReadOnly = True
            txtexamcode.ReadOnly = True
            nudminutes.Enabled = False
            dgviewqsn.Enabled = False
            btnnext.Enabled = False
            btnreset.Enabled = False
        End If
    End Sub
#End Region
#Region "Attributes..."
    Private Sub txtexamcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtexamcode.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbdate.Focus()
        End If
    End Sub

    Private Sub cmbdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            nudminutes.Focus()
        End If
    End Sub

    Private Sub nudminutes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudminutes.KeyDown
        If e.KeyCode = Keys.Enter Then
            mskexamtime.Focus()
        End If
    End Sub

    Private Sub mskexamtime_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskexamtime.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtqsn.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            nudminutes.Focus()
        End If
    End Sub

    Private Sub mskexamtime_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskexamtime.TextChanged
        If mskexamtime.Text = "" Then
            mskexamtime.Text = Date.Now.ToShortTimeString()
        End If
    End Sub

    Private Sub txtqsn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtqsn.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtans1.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            mskexamtime.Focus()
        End If
    End Sub

    Private Sub txtans1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtans1.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtans2.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtqsn.Focus()
        End If
    End Sub

    Private Sub txtans2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtans2.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtans3.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtans1.Focus()
        End If
    End Sub

    Private Sub txtans3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtans3.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtans4.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtans2.Focus()
        End If
    End Sub

    Private Sub txtans4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtans4.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbrightans.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtans3.Focus()
        End If
    End Sub

    Private Sub cmbrightans_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbrightans.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnnext.Focus()
        End If
    End Sub

    Private Sub ComboBoxKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbrightans.KeyPress, cmbdate.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub
#End Region
#Region "ContextMenuStrip Events..."
    Private Sub ModifyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyToolStripMenuItem.Click
        Dim row As Integer = dgviewqsn.CurrentRow.Index
        txtqsn.Text = dgviewqsn.Rows(row).Cells(1).Value.ToString()
        txtans1.Text = dgviewqsn.Rows(row).Cells(2).Value.ToString()
        txtans2.Text = dgviewqsn.Rows(row).Cells(3).Value.ToString()
        txtans3.Text = dgviewqsn.Rows(row).Cells(4).Value.ToString()
        txtans4.Text = dgviewqsn.Rows(row).Cells(5).Value.ToString()
        If dgviewqsn.Rows(row).Cells(6).Value.ToString() = txtans1.Text Then
            cmbrightans.Text = "Answer 1"
        ElseIf dgviewqsn.Rows(row).Cells(6).Value.ToString() = txtans2.Text Then
            cmbrightans.Text = "Answer 2"
        ElseIf dgviewqsn.Rows(row).Cells(6).Value.ToString() = txtans3.Text Then
            cmbrightans.Text = "Answer 3"
        ElseIf dgviewqsn.Rows(row).Cells(6).Value.ToString() = txtans4.Text Then
            cmbrightans.Text = "Answer 4"
        End If
        Modify = True
        modifyindex = row
        dgviewqsn.ClearSelection()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim row As Integer = dgviewqsn.CurrentRow.Index
        dgviewqsn.Rows.RemoveAt(row)
        i = i - 1
        For indx As Integer = 0 To dgviewqsn.Rows.Count - 1
            dgviewqsn.Rows(indx).Cells(0).Value = (indx + 1).ToString()
        Next
        dgviewqsn.ClearSelection()
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updateonlineqsn = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updateonlineqsn = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updateonlineqsn = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updateonlineqsn = False Then
            ControlSetBound()
            cmbdate.Text = UmbrellaSystemDate
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadSelectedRecord()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub

    Private Sub btnnext_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnext.ClickButtonArea
        AddToGrid()
    End Sub

    Private Sub btnreset_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnreset.ClickButtonArea
        txtqsn.Text = ""
        txtans1.Text = ""
        txtans2.Text = ""
        txtans3.Text = ""
        txtans4.Text = ""
        cmbrightans.Text = ""
        txtqsn.Focus()
    End Sub
#End Region
End Class
#End Region