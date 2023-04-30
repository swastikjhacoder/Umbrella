#Region "Import"
Imports Umbrella.UIControls
Imports ESAR_Controls.UIControls.ComboBox
#End Region
#Region "Class frmNotices..."
Public Class frmNotices
#Region "Declaration"
    Private NCODE As String = ""
    Private TT As String = ""
    Private NoticeExist As Boolean = False
#End Region
#Region "Methods"
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        NCODE = Indx.LoadNoticeID()
        Dim var As String
        var = CodeIncrement(NCODE)
        Me.txtnoticeid.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("NTC:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        Label2.SetBounds(14, 26, 70, 13)
        Label3.SetBounds(222, 26, 69, 13)
        Label4.SetBounds(509, 26, 123, 13)
        Label5.SetBounds(14, 34, 55, 13)
        Label6.SetBounds(14, 61, 43, 13)
        txtnoticeid.SetBounds(90, 23, 124, 21)
        txtsubject.SetBounds(90, 31, 704, 21)
        rtbnotice.SetBounds(90, 61, 704, 300)
        cmbdate.SetBounds(649, 23, 145, 21)
        cmbnoticefor.SetBounds(297, 23, 121, 21)
    End Sub

    Private Sub ResetForm()
        updatenotice = False
        If ISDAutoID = "Yes" Then
            GetCode()
        Else
            txtnoticeid.Text = ""
        End If
        txtsubject.Text = ""
        cmbdate.Text = UmbrellaSystemDate
        cmbnoticefor.Text = ""
        rtbnotice.rtb.Text = ""
        cmbnoticefor.Focus()
    End Sub

    Private Sub AddRecord()
        Try
            If txtnoticeid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter notice no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtnoticeid.Focus()
                End If
            ElseIf txtsubject.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter subject.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtsubject.Focus()
                End If
            ElseIf cmbdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter notice date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbdate.Focus()
                End If
            ElseIf cmbnoticefor.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter notice for.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbnoticefor.Focus()
                End If
            ElseIf rtbnotice.rtb.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter notice details.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    rtbnotice.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    CheckNoticeID()
                    If NoticeExist = False Then
                        Dim cls As New cNotice()
                        cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtnoticeid.Text, cmbnoticefor.Text, cmbdate.Text, txtsubject.Text, rtbnotice.rtb.Text)
                        If cls.AddOk = True Then
                            Dim result1 As DialogResult = MessageBox.Show("Record saved successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = DialogResult.OK Then
                                cmbnoticefor.Focus()
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Notice no already exist." + Environment.NewLine + "Please enter a new notice id", "Umbrella - Duplicate Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result1 = DialogResult.OK Then
                            txtnoticeid.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If txtnoticeid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter notice no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtnoticeid.Focus()
                End If
            ElseIf txtsubject.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter subject.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtsubject.Focus()
                End If
            ElseIf cmbdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter notice date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbdate.Focus()
                End If
            ElseIf cmbnoticefor.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter notice for.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbnoticefor.Focus()
                End If
            ElseIf rtbnotice.rtb.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter notice details.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    rtbnotice.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim cls As New cNotice()
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtnoticeid.Text, cmbnoticefor.Text, cmbdate.Text, txtsubject.Text, rtbnotice.rtb.Text)
                    If cls.UpdateOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = DialogResult.OK Then
                            cmbnoticefor.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If txtnoticeid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter notice no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtnoticeid.Focus()
                End If
            ElseIf txtsubject.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter subject.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtsubject.Focus()
                End If
            ElseIf cmbdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter notice date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbdate.Focus()
                End If
            ElseIf cmbnoticefor.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter notice for.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbnoticefor.Focus()
                End If
            ElseIf rtbnotice.rtb.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter notice details.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    rtbnotice.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim cls As New cNotice()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtnoticeid.Text)
                    If cls.DeleteOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record deleted successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = DialogResult.OK Then
                            ResetForm()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedNotice()
        Try
            cmd.CommandText = "select * from Notice where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and noticeid='" & noticeid & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                txtnoticeid.Text = dr("noticeid").ToString()
                cmbnoticefor.Text = dr("noticefor").ToString()
                cmbdate.Text = dr("noticedate").ToString()
                txtsubject.Text = dr("subject").ToString()
                rtbnotice.rtb.Text = dr("notice").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CheckNoticeID()
        Try
            cmd.CommandText = "select * from Notice where noticeid='" & txtnoticeid.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                NoticeExist = True
            Else
                NoticeExist = False
            End If
            dr.Close()
        Catch ex As Exception
            NoticeExist = False
            dr.Close()
        End Try
    End Sub
#End Region
#Region "FormEvents"
    Private Sub frmNotices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If updatenotice = False Then
            ControlSetBound()
            cmbdate.Text = UmbrellaSystemDate
            cmbnoticefor.Items.Add(New ComboBoxIconItem("Student", 0))
            cmbnoticefor.Items.Add(New ComboBoxIconItem("Employee", 1))
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            cmbnoticefor.Items.Add(New ComboBoxIconItem("Student", 0))
            cmbnoticefor.Items.Add(New ComboBoxIconItem("Employee", 1))
            LoadSelectedNotice()
        End If
        If USnotices = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbdate.Enabled = False
            cmbnoticefor.Enabled = False
            txtnoticeid.ReadOnly = True
            txtsubject.ReadOnly = True
            rtbnotice.rtb.ReadOnly = True
        End If
        cmbnoticefor.Focus()
    End Sub
#End Region
#Region "ButtonEvents"
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatenotice = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatenotice = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatenotice = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updatenotice = False Then
            ControlSetBound()
            cmbdate.Text = UmbrellaSystemDate
            cmbnoticefor.Items.Add(New ComboBoxIconItem("Student", 0))
            cmbnoticefor.Items.Add(New ComboBoxIconItem("Employee", 1))
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            cmbnoticefor.Items.Add(New ComboBoxIconItem("Student", 0))
            cmbnoticefor.Items.Add(New ComboBoxIconItem("Employee", 1))
            LoadSelectedNotice()
        End If
        cmbnoticefor.Focus()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Attribute"
    Private Sub txtnoticeid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnoticeid.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            cmbnoticefor.Focus()
        End If
    End Sub

    Private Sub cmbnoticefor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbnoticefor.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbdate.Focus()
        End If
    End Sub

    Private Sub cmbdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsubject.Focus()
        End If
    End Sub

    Private Sub txtsubject_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsubject.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtsubject.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbdate.Focus()
        End If
    End Sub
#End Region
End Class
#End Region