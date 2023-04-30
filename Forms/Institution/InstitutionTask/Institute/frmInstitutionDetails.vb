Public Class frmInstitutionDetails

    Private Sub LoadInstitutionDetails()
        Try
            cmd.CommandText = "select * from Institute where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            txtregistrationid.Text = dr("InsID").ToString()
            cmbcategory.Text = dr("Category").ToString()
            txtname.Text = dr("InsName").ToString()
            txtaddress1.Text = dr("Address1").ToString()
            txtaddress2.Text = dr("Address2").ToString()
            txtcity.Text = dr("City").ToString()
            txtstate.Text = dr("State").ToString()
            txtpin.Text = dr("Pin").ToString()
            txtcountry.Text = dr("Country").ToString()
            txtphone.Text = dr("Telephone").ToString()
            txtfax.Text = dr("Fax").ToString()
            txtemail.Text = dr("Email").ToString()
            txturl1.Text = dr("Url1").ToString()
            txturl2.Text = dr("Url2").ToString()
            lblfinancialperiod.Text += dr("FinancialPeriod").ToString()
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadCourseDetails()
        Try
            dgviewcourse.Rows.Clear()
            Dim row As Integer = 0
            cmd.CommandText = "select CourseName,CourseCode,Duration from Course where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewcourse.Rows.Add()
                dgviewcourse.Rows(row).Cells(0).Value = (row + 1).ToString()
                dgviewcourse.Rows(row).Cells(0).Style.BackColor = System.Drawing.SystemColors.Control
                dgviewcourse.Rows(row).Cells(1).Value = dr("CourseName").ToString()
                dgviewcourse.Rows(row).Cells(2).Value = dr("CourseCode").ToString()
                dgviewcourse.Rows(row).Cells(3).Value = dr("Duration").ToString()
                row += 1
            End While
            dr.Close()
            dgviewcourse.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadFeaturesDetails()
        Try
            dgviewfeatures.Rows.Clear()
            Dim row As Integer = 0
            cmd.CommandText = "select Features from Features where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewfeatures.Rows.Add()
                dgviewfeatures.Rows(row).Cells(0).Value = (row + 1).ToString()
                dgviewfeatures.Rows(row).Cells(0).Style.BackColor = System.Drawing.SystemColors.Control
                dgviewfeatures.Rows(row).Cells(1).Value = dr("Features").ToString()
                row += 1
            End While
            dr.Close()
            dgviewfeatures.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadAchievementsDetails()
        Try
            dgviewachievements.Rows.Clear()
            Dim row As Integer = 0
            cmd.CommandText = "select Achievements from Achievements where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewachievements.Rows.Add()
                dgviewachievements.Rows(row).Cells(0).Value = (row + 1).ToString()
                dgviewachievements.Rows(row).Cells(0).Style.BackColor = System.Drawing.SystemColors.Control
                dgviewachievements.Rows(row).Cells(1).Value = dr("Achievements").ToString()
                row += 1
            End While
            dr.Close()
            dgviewachievements.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadAccountsDetails()
        Try
            dgviewaccounts.Rows.Clear()
            Dim row As Integer = 0
            cmd.CommandText = "select AccountID,AccountName,AccountBalance from Accounts where InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewaccounts.Rows.Add()
                dgviewaccounts.Rows(row).Cells(0).Value = (row + 1).ToString()
                dgviewaccounts.Rows(row).Cells(0).Style.BackColor = System.Drawing.SystemColors.Control
                dgviewaccounts.Rows(row).Cells(1).Value = dr("AccountID").ToString()
                dgviewaccounts.Rows(row).Cells(2).Value = dr("AccountName").ToString()
                Dim bal As Decimal = CDec(dr("AccountBalance").ToString())
                dgviewaccounts.Rows(row).Cells(3).Value = FormatNumber(bal.ToString())
                row += 1
            End While
            dr.Close()
            dgviewaccounts.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub frmInstitutionDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadInstitutionDetails()
        LoadAccountsDetails()
        LoadAchievementsDetails()
        LoadCourseDetails()
        LoadFeaturesDetails()
        dgviewaccounts.ClearSelection()
        dgviewachievements.ClearSelection()
        dgviewcourse.ClearSelection()
        dgviewfeatures.ClearSelection()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If TabControl1.SelectedIndex = TabControl1.TabCount - 1 Then
            TabControl1.SelectedIndex = 0
        Else
            TabControl1.SelectedIndex = TabControl1.SelectedIndex + 1
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            pictab1.Image = Global.Umbrella.My.Resources.process_current
            pictab2.Image = Global.Umbrella.My.Resources.process_done
            pictab3.Image = Global.Umbrella.My.Resources.process_done
        ElseIf TabControl1.SelectedIndex = 1 Then
            pictab1.Image = Global.Umbrella.My.Resources.process_done
            pictab2.Image = Global.Umbrella.My.Resources.process_current
            pictab3.Image = Global.Umbrella.My.Resources.process_done
        ElseIf TabControl1.SelectedIndex = 2 Then
            pictab1.Image = Global.Umbrella.My.Resources.process_done
            pictab2.Image = Global.Umbrella.My.Resources.process_done
            pictab3.Image = Global.Umbrella.My.Resources.process_current
        End If
    End Sub

    Private Sub pictab1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictab1.Click
        TabControl1.SelectTab(TabPage1)
        TableLayoutPanel1.Focus()
    End Sub

    Private Sub pictab2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictab2.Click
        TabControl1.SelectTab(TabPage2)
        TableLayoutPanel2.Focus()
    End Sub

    Private Sub pictab3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictab3.Click
        TabControl1.SelectTab(TabPage3)
        TableLayoutPanel3.Focus()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
End Class