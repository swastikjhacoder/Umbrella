#Region "Class frmUserSecurity..."
Public Class frmUserControl
#Region "Declarations..."
    Private DGVUser As New DataGridView()
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(15, 22, 455, 13)
        Label2.SetBounds(15, 139, 549, 39)
        GroupBox1.SetBounds(76, 49, 390, 71)
        rbtnalluser.SetBounds(33, 14, 75, 17)
        rbtnoneuser.SetBounds(33, 37, 108, 17)
        cmbuser.SetBounds(147, 36, 121, 21)
        btnsave.SetBounds(296, 39, 75, 25)
    End Sub

    Private Sub LoadUsers()
        Try
            Dim i As Integer = 0
            dgviewusers.Rows.Clear()
            cmd.CommandText = "select userrole,userid from Users where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewusers.Rows.Add()
                dgviewusers.Rows(i).Cells(0).Value = dr("userrole").ToString()
                dgviewusers.Rows(i).Cells(1).Value = dr("userid").ToString()
                i = i + 1
            End While
            dr.Close()
            dgviewusers.ClearSelection()
            cmd.CommandText = "select crystalreport,crystalreportid from UserCrystalReport where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr("crystalreport").ToString() = "All" Then
                rbtnalluser.Checked = True
            Else
                rbtnoneuser.Checked = True
                cmbuser.Text = dr("crystalreportid").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadCmbUser()
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .HeaderText = "User Role"
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .HeaderText = "Username"
            End With

            With DGVUser
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
                AddHandler DGVUser.CellClick, AddressOf DGVUser_CellClick
            End With

            DGVUser.Columns.Clear()
            DGVUser.Columns.Add(col1)
            DGVUser.Columns.Add(col2)

            DGVUser.Rows.Clear()
            Dim CmbUserRole As String = "Employee"
            Dim i As Integer = 0
            cmd.CommandText = "select userrole,userid from Users where userrole='" & CmbUserRole & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                DGVUser.Rows.Add()
                DGVUser.Rows(i).Cells(0).Value = dr("userrole").ToString()
                DGVUser.Rows(i).Cells(1).Value = dr("userid").ToString()
                i = i + 1
            End While
            dr.Close()
            DGVUser.ClearSelection()

            cmbuser.AddDataGridView(DGVUser, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVUser_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVUser.CurrentRow.Index
            DGVUser.Rows(k).Selected = True
            DGVUser.CurrentCell = DGVUser.Rows(k).Cells(0)
            userrole = DGVUser.Rows(k).Cells(0).Value.ToString()
            userid = DGVUser.Rows(k).Cells(1).Value.ToString()
            cmbuser.Text = userid
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaveUserCrystalReport()
        Try
            If rbtnalluser.Checked = False And rbtnoneuser.Checked = False Then
                Dim result As DialogResult = MessageBox.Show("Please select any one option.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbuser.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim cls As New cUser()
                    If rbtnalluser.Checked = True Then
                        Dim crystalreport As String = "All"
                        Dim crystalreportid As String = ""
                        cls.UpdateUserCrystalReport(crystalreport, crystalreportid)
                        If cls.UpdateUserCrystalReportOk = True Then
                            Dim res As DialogResult = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If res = DialogResult.OK Then
                            End If
                        End If
                    ElseIf rbtnoneuser.Checked = True Then
                        If cmbuser.Text = "" Then
                            Dim result1 As DialogResult = MessageBox.Show("Please enter/select user.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result1 = DialogResult.OK Then
                                cmbuser.Focus()
                            End If
                        Else
                            Dim crystalreport As String = "One"
                            Dim crystalreportid As String = cmbuser.Text
                            cls.UpdateUserCrystalReport(crystalreport, crystalreportid)
                            If cls.UpdateUserCrystalReportOk = True Then
                                Dim res As DialogResult = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                If res = DialogResult.OK Then
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub DeleteUser()
        Try
            Dim i As Integer = dgviewusers.CurrentRow.Index
            userrole = dgviewusers.Rows(i).Cells(0).Value.ToString()
            userid = dgviewusers.Rows(i).Cells(1).Value.ToString()
            Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this user?" + Environment.NewLine + "Username: '" & userid & "'", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim cls As New cUser()
                cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, userid)
                If cls.DeleteUserOk = True Then
                    Dim res As DialogResult = MessageBox.Show("Record deleted successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If res = DialogResult.OK Then
                        LoadUsers()
                        LoadCmbUser()
                    End If
                End If
            End If
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmUserSecurity_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
        LoadUsers()
        LoadCmbUser()
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnewuser_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnewuser.ClickButtonArea
        Try
            Dim user As String = ""
            cmd.CommandText = "select * from Users where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                user = dr("userrole").ToString()
                If user = "Administrator" Then
                    Exit While
                End If
            End While
            dr.Close()
            If user = "Administrator" Then
                Dim frm As New frmNewUser()
                frm.ControlBox = True
                frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                frm.WindowState = FormWindowState.Normal
                frm.ControlBox = True
                frm.ShowDialog()
            Else
                Dim frm As New frmNewAdministrator()
                frm.ControlBox = True
                frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                frm.WindowState = FormWindowState.Normal
                frm.ControlBox = True
                frm.ShowDialog()
            End If
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub btnedituserright_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnedituserright.ClickButtonArea
        Dim i As Integer = dgviewusers.CurrentRow.Index
        userid = dgviewusers.Rows(i).Cells(1).Value.ToString()
        Dim frm As New frmUserRight()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.Show()
    End Sub

    Private Sub btndeleteuser_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndeleteuser.ClickButtonArea
        DeleteUser()
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        ControlSetBound()
        LoadUsers()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        SaveUserCrystalReport()
    End Sub
#End Region
#Region "Attributes..."
    Private Sub rbtnalluser_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnalluser.CheckedChanged
        cmbuser.Enabled = False
    End Sub

    Private Sub rbtnoneuser_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnoneuser.CheckedChanged
        cmbuser.Enabled = True
    End Sub
#End Region
End Class
#End Region