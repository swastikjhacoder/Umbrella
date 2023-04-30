#Region "Class frmUserRight..."
Public Class frmUserRight
#Region "Declarations..."
    Private LanguageTexts_Next As String = "&Next"
    Private LanguageTexts_Finish As String = "&Finish"
    Private LanguageTexts_Back As String = "&Back"
    Private DGVUser As New DataGridView()
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(19, 20, 38, 13)
        Label10.SetBounds(381, 20, 70, 13)
        Label105.SetBounds(10, 139, 570, 26)
        Label11.SetBounds(15, 47, 150, 13)
        Label12.SetBounds(15, 20, 139, 13)
        Label13.SetBounds(15, 74, 82, 13)
        Label14.SetBounds(15, 101, 53, 13)
        Label15.SetBounds(353, 20, 64, 13)
        Label16.SetBounds(353, 47, 108, 13)
        Label17.SetBounds(353, 74, 107, 13)
        Label18.SetBounds(353, 101, 97, 13)
        Label19.SetBounds(15, 47, 82, 13)
        Label2.SetBounds(0, 0, 590, 25)
        Label20.SetBounds(15, 74, 94, 13)
        Label21.SetBounds(15, 47, 150, 13)
        Label22.SetBounds(15, 20, 127, 13)
        Label23.SetBounds(10, 139, 570, 26)
        Label24.SetBounds(15, 20, 105, 13)
        Label25.SetBounds(303, 74, 158, 13)
        Label26.SetBounds(303, 47, 151, 13)
        Label27.SetBounds(303, 20, 132, 13)
        Label28.SetBounds(15, 101, 61, 13)
        Label29.SetBounds(15, 74, 111, 13)
        Label3.SetBounds(0, 0, 590, 25)
        Label30.SetBounds(15, 47, 129, 13)
        Label31.SetBounds(15, 20, 90, 13)
        Label32.SetBounds(10, 139, 570, 26)
        Label35.SetBounds(15, 74, 96, 13)
        Label36.SetBounds(15, 74, 97, 13)
        Label37.SetBounds(15, 47, 100, 13)
        Label38.SetBounds(15, 20, 98, 13)
        Label39.SetBounds(10, 141, 570, 26)
        Label4.SetBounds(0, 0, 590, 25)
        Label40.SetBounds(15, 47, 97, 13)
        Label41.SetBounds(10, 139, 570, 26)
        Label42.SetBounds(344, 101, 52, 13)
        Label43.SetBounds(344, 74, 89, 13)
        Label44.SetBounds(344, 47, 68, 13)
        Label45.SetBounds(344, 20, 101, 13)
        Label46.SetBounds(15, 101, 77, 13)
        Label47.SetBounds(15, 74, 51, 13)
        Label48.SetBounds(15, 47, 91, 13)
        Label49.SetBounds(15, 20, 106, 13)
        Label5.SetBounds(0, 0, 590, 25)
        Label50.SetBounds(10, 139, 570, 26)
        Label51.SetBounds(15, 20, 104, 13)
        Label52.SetBounds(15, 101, 89, 13)
        Label53.SetBounds(15, 74, 82, 13)
        Label54.SetBounds(15, 47, 60, 13)
        Label55.SetBounds(15, 20, 91, 13)
        Label56.SetBounds(10, 141, 570, 26)
        Label59.SetBounds(15, 101, 139, 13)
        Label6.SetBounds(0, 0, 590, 25)
        Label60.SetBounds(344, 20, 106, 13)
        Label7.SetBounds(303, 47, 71, 13)
        Label8.SetBounds(303, 20, 104, 13)
        Label9.SetBounds(381, 47, 80, 13)

        cmbaccounting.SetBounds(467, 44, 104, 21)
        cmbadmission.SetBounds(467, 17, 104, 21)
        cmbalumni.SetBounds(231, 71, 104, 21)
        cmbattendance.SetBounds(171, 71, 104, 21)
        cmbbackuprestore.SetBounds(467, 71, 104, 21)
        cmbbankinginfo.SetBounds(171, 44, 104, 21)
        cmbcertificates.SetBounds(231, 98, 104, 21)
        cmbcoursesubject.SetBounds(171, 17, 104, 21)
        cmbdiscount.SetBounds(171, 98, 104, 21)
        cmbemployeecard.SetBounds(171, 44, 104, 21)
        cmbemployeeinfo.SetBounds(171, 17, 104, 21)
        cmbexamination.SetBounds(171, 44, 104, 21)
        cmbfeescollection.SetBounds(171, 71, 104, 21)
        cmbfinancial.SetBounds(467, 71, 104, 21)
        cmbgames.SetBounds(467, 98, 104, 21)
        cmbglobalaccess.SetBounds(231, 44, 104, 21)
        cmbidcards.SetBounds(467, 17, 104, 21)
        cmbimportexport.SetBounds(467, 98, 104, 21)
        cmbincomeexpenditure.SetBounds(467, 17, 104, 21)
        cmbinventory.SetBounds(467, 44, 104, 21)
        cmblocalmessenger.SetBounds(231, 17, 104, 21)
        cmbmarksheet.SetBounds(467, 44, 104, 21)
        cmbnotices.SetBounds(171, 98, 104, 21)
        cmbpreadmission.SetBounds(171, 71, 104, 21)
        cmbprogressreport.SetBounds(467, 17, 104, 21)
        cmbpurchaseorder.SetBounds(467, 17, 104, 21)
        cmbregistration.SetBounds(467, 44, 104, 21)
        cmbsalesinvoice.SetBounds(467, 71, 104, 21)
        cmbstudentcard.SetBounds(171, 44, 104, 21)
        cmbstudentcontrol.SetBounds(467, 44, 104, 21)
        cmbstudentinfo.SetBounds(171, 17, 104, 21)
        cmbtermsfees.SetBounds(171, 17, 104, 21)
        cmbuser.SetBounds(63, 17, 209, 21)
        cmbbookrecord.SetBounds(231, 17, 104, 21)
        cmbcharges.SetBounds(231, 44, 104, 21)
        cmbissuebooks.SetBounds(231, 71, 104, 21)
        cmbreturnbooks.SetBounds(231, 98, 104, 21)
        cmbpayrollsystem.SetBounds(231, 17, 104, 21)
        cmbpayrollperiodic.SetBounds(231, 44, 104, 21)
        cmbpayrollpf.SetBounds(231, 71, 104, 21)
        cmbinstitutedefault.SetBounds(231, 17, 104, 21)
        cmblibrarydefault.SetBounds(231, 44, 104, 21)
        cmbpayrolldefault.SetBounds(231, 71, 104, 21)
        cmbrevenue.SetBounds(231, 98, 104, 21)
        cmbyearend.SetBounds(467, 17, 104, 21)
    End Sub

    Friend Sub GoToTab(Optional ByVal Aantal As Integer = 1)
        ETabControlEx1.SelectedIndex = ETabControlEx1.SelectedIndex + Aantal
        CheckTabPageAndUpdateButtons()
    End Sub

    Friend Sub GoToTab(ByVal Tab As TabPage)
        ETabControlEx1.SelectedTab = Tab
        CheckTabPageAndUpdateButtons()
    End Sub

    Sub CheckTabPageAndUpdateButtons()
        If ETabControlEx1.SelectedIndex = 0 Then
            DisableBackButton()
        Else
            EnableBackButton()
        End If
        If ETabControlEx1.SelectedIndex = ETabControlEx1.TabCount - 1 Then
            SetNextButtonToFinish()
        Else
            SetNextButtonToNext()
        End If
    End Sub

    Sub DisableBackButton()
        btnback.Enabled = False
        btnback.Tag = "disabled"
        btnback.Image = Global.Umbrella.My.Resources.disabled_back
    End Sub

    Sub EnableBackButton()
        btnback.Enabled = True
        btnback.Tag = ""
        btnback.Image = Global.Umbrella.My.Resources.back
    End Sub

    Sub SetNextButtonToFinish()
        btnnext.Text = LanguageTexts_Finish
        btnnext.Tag = "finish"
    End Sub

    Sub SetNextButtonToNext()
        btnnext.Text = LanguageTexts_Next
        btnnext.Tag = ""
    End Sub

    Private Sub LoadUser()
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
            LoadUserDetails(cmbuser.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadUserDetails(ByVal id As String)
        Try
            cmd.CommandText = "select * from Users where userid='" & id & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            cmbaccounting.Text = dr("accounting").ToString()
            cmbadmission.Text = dr("admission").ToString()
            cmbalumni.Text = dr("alumni").ToString()
            cmbattendance.Text = dr("attendances").ToString()
            cmbbackuprestore.Text = dr("backuprestore").ToString()
            cmbbankinginfo.Text = dr("bankinginfo").ToString()
            cmbbookrecord.Text = dr("bookrecords").ToString()
            cmbcertificates.Text = dr("certificates").ToString()
            cmbcharges.Text = dr("charges").ToString()
            cmbcoursesubject.Text = dr("coursesubject").ToString()
            cmbdiscount.Text = dr("discount").ToString()
            cmbemployeecard.Text = dr("employeecard").ToString()
            cmbemployeeinfo.Text = dr("employeeinfo").ToString()
            cmbexamination.Text = dr("examination").ToString()
            cmbfeescollection.Text = dr("feescollection").ToString()
            cmbfinancial.Text = dr("financialloan").ToString()
            cmbgames.Text = dr("games").ToString()
            cmbglobalaccess.Text = dr("globalaccess").ToString()
            cmbidcards.Text = dr("idcard").ToString()
            cmbimportexport.Text = dr("importexport").ToString()
            cmbincomeexpenditure.Text = dr("incomeexpenditure").ToString()
            cmbinventory.Text = dr("inventory").ToString()
            cmbissuebooks.Text = dr("issuebooks").ToString()
            cmblocalmessenger.Text = dr("messenger").ToString()
            cmbmarksheet.Text = dr("marksheet").ToString()
            cmbnotices.Text = dr("notices").ToString()
            cmbpayrollperiodic.Text = dr("payrollperiodic").ToString()
            cmbpayrollpf.Text = dr("payrollpf").ToString()
            cmbpayrollsystem.Text = dr("payrollsystem").ToString()
            cmbpreadmission.Text = dr("preadmission").ToString()
            cmbprogressreport.Text = dr("progressreport").ToString()
            cmbpurchaseorder.Text = dr("purchaseorder").ToString()
            cmbregistration.Text = dr("registration").ToString()
            cmbreturnbooks.Text = dr("returnbooks").ToString()
            cmbsalesinvoice.Text = dr("salesinvoice").ToString()
            cmbstudentcard.Text = dr("studentcard").ToString()
            cmbstudentcontrol.Text = dr("studentcontrol").ToString()
            cmbstudentinfo.Text = dr("studentinfo").ToString()
            cmbtermsfees.Text = dr("feesterms").ToString()
            cmbuser.Text = dr("userid").ToString()
            cmbinstitutedefault.Text = dr("institutedefault").ToString()
            cmblibrarydefault.Text = dr("librarydefault").ToString()
            cmbpayrolldefault.Text = dr("payrolldefault").ToString()
            cmbrevenue.Text = dr("revenueyeartodate").ToString()
            cmbyearend.Text = dr("yearend").ToString()
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub UpdateUser()
        Try
            If cmbuser.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select user.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbuser.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim cls As New cUser()
                    cmd.CommandText = "select userno,userrole from Users where userid='" & cmbuser.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and insName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    Dim userno As String = dr("userno").ToString()
                    userrole = dr("userrole").ToString()
                    dr.Close()
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, userno, userrole, cmbuser.Text, cmbemployeeinfo.Text, cmbemployeecard.Text, cmbattendance.Text, cmbidcards.Text, cmbnotices.Text, cmbstudentcontrol.Text, cmbbackuprestore.Text, cmbimportexport.Text, cmbstudentinfo.Text, cmbstudentcard.Text, cmbpreadmission.Text, cmbadmission.Text, cmbregistration.Text, cmbtermsfees.Text, cmbbankinginfo.Text, cmbfeescollection.Text, cmbdiscount.Text, cmbincomeexpenditure.Text, cmbaccounting.Text, cmbfinancial.Text, cmbcoursesubject.Text, cmbexamination.Text, cmbprogressreport.Text, cmbmarksheet.Text, cmblocalmessenger.Text, cmbglobalaccess.Text, cmbalumni.Text, cmbcertificates.Text, cmbpurchaseorder.Text, cmbinventory.Text, cmbsalesinvoice.Text, cmbgames.Text, cmbbookrecord.Text, cmbcharges.Text, cmbissuebooks.Text, cmbreturnbooks.Text, cmbpayrollsystem.Text, cmbpayrollperiodic.Text, cmbpayrollpf.Text, cmbinstitutedefault.Text, cmblibrarydefault.Text, cmbpayrolldefault.Text, cmbrevenue.Text, cmbyearend.Text)
                    If cls.UpdateUserOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = DialogResult.OK Then
                            ETabControlEx1.SelectTab(TabPage1)
                            cmbuser.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmUserRight_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
        btnnext.Text = LanguageTexts_Next
        btnback.Text = LanguageTexts_Back
        btnback.Enabled = False
        ETabControlEx1.HideTabs = True
        LoadUser()
        cmbuser.Text = userid
        If cmbuser.Text <> "" Then
            LoadUserDetails(cmbuser.Text)
        End If
    End Sub
#End Region
#Region "Attributes..."
    Private Sub cmbuser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbuser.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbuser.Text <> "" Then
                LoadUserDetails(cmbuser.Text)
            End If
            ETabControlEx1.SelectTab(TabPage1)
            cmbemployeeinfo.Focus()
        End If
    End Sub

    Private Sub cmbemployeeinfo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbemployeeinfo.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbemployeecard.Focus()
        End If
    End Sub

    Private Sub cmbemployeecard_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbemployeecard.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbattendance.Focus()
        End If
    End Sub

    Private Sub cmbattendance_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbattendance.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbnotices.Focus()
        End If
    End Sub

    Private Sub cmbnotices_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbnotices.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbidcards.Focus()
        End If
    End Sub

    Private Sub cmbidcards_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbidcards.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbstudentcontrol.Focus()
        End If
    End Sub

    Private Sub cmbstudentcontrol_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbstudentcontrol.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbbackuprestore.Focus()
        End If
    End Sub

    Private Sub cmbbackuprestore_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbbackuprestore.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbimportexport.Focus()
        End If
    End Sub

    Private Sub cmbimportexport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbimportexport.KeyDown
        If e.KeyCode = Keys.Enter Then
            ETabControlEx1.SelectTab(TabPage2)
            CheckTabPageAndUpdateButtons()
            cmbstudentinfo.Focus()
        End If
    End Sub

    Private Sub cmbstudentinfo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbstudentinfo.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbstudentcard.Focus()
        End If
    End Sub

    Private Sub cmbstudentcard_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbstudentcard.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbpreadmission.Focus()
        End If
    End Sub

    Private Sub cmbpreadmission_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbpreadmission.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbadmission.Focus()
        End If
    End Sub

    Private Sub cmbadmission_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbadmission.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbregistration.Focus()
        End If
    End Sub

    Private Sub cmbregistration_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbregistration.KeyDown
        If e.KeyCode = Keys.Enter Then
            ETabControlEx1.SelectTab(TabPage3)
            CheckTabPageAndUpdateButtons()
            cmbtermsfees.Focus()
        End If
    End Sub

    Private Sub cmbtermsfees_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbtermsfees.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbbankinginfo.Focus()
        End If
    End Sub

    Private Sub cmbbankinginfo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbbankinginfo.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbfeescollection.Focus()
        End If
    End Sub

    Private Sub cmbfeescollection_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbfeescollection.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbdiscount.Focus()
        End If
    End Sub

    Private Sub cmbdiscount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdiscount.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbincomeexpenditure.Focus()
        End If
    End Sub

    Private Sub cmbincomeexpenditure_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbincomeexpenditure.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbaccounting.Focus()
        End If
    End Sub

    Private Sub cmbaccounting_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbaccounting.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbfinancial.Focus()
        End If
    End Sub

    Private Sub cmbfinancial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbfinancial.KeyDown
        If e.KeyCode = Keys.Enter Then
            ETabControlEx1.SelectTab(TabPage4)
            CheckTabPageAndUpdateButtons()
            cmbcoursesubject.Focus()
        End If
    End Sub

    Private Sub cmbcoursesubject_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcoursesubject.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbexamination.Focus()
        End If
    End Sub

    Private Sub cmbexamination_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbexamination.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbprogressreport.Focus()
        End If
    End Sub

    Private Sub cmbprogressreport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbprogressreport.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbmarksheet.Focus()
        End If
    End Sub

    Private Sub cmbmarksheet_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbmarksheet.KeyDown
        If e.KeyCode = Keys.Enter Then
            ETabControlEx1.SelectTab(TabPage5)
            CheckTabPageAndUpdateButtons()
            cmblocalmessenger.Focus()
        End If
    End Sub

    Private Sub cmblocalmessenger_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmblocalmessenger.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbglobalaccess.Focus()
        End If
    End Sub

    Private Sub cmbglobalaccess_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbglobalaccess.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbalumni.Focus()
        End If
    End Sub

    Private Sub cmbalumni_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbalumni.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbcertificates.Focus()
        End If
    End Sub

    Private Sub cmbcertificates_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcertificates.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbpurchaseorder.Focus()
        End If
    End Sub

    Private Sub cmbpurchaseorder_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbpurchaseorder.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbinventory.Focus()
        End If
    End Sub

    Private Sub cmbinventory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbinventory.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbsalesinvoice.Focus()
        End If
    End Sub

    Private Sub cmbsalesinvoice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbsalesinvoice.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbgames.Focus()
        End If
    End Sub

    Private Sub cmbgames_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbgames.KeyDown
        If e.KeyCode = Keys.Enter Then
            ETabControlEx1.SelectTab(TabPage6)
            CheckTabPageAndUpdateButtons()
            cmbbookrecord.Focus()
        End If
    End Sub

    Private Sub cmbbookrecord_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbbookrecord.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbcharges.Focus()
        End If
    End Sub

    Private Sub cmbcharges_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcharges.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbissuebooks.Focus()
        End If
    End Sub

    Private Sub cmbissuebooks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbissuebooks.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbreturnbooks.Focus()
        End If
    End Sub

    Private Sub cmbreturnbooks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbreturnbooks.KeyDown
        If e.KeyCode = Keys.Enter Then
            ETabControlEx1.SelectTab(TabPage7)
            CheckTabPageAndUpdateButtons()
            cmbpayrollsystem.Focus()
        End If
    End Sub

    Private Sub cmbpayrollsystem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbpayrollsystem.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbpayrollperiodic.Focus()
        End If
    End Sub

    Private Sub cmbpayrollperiodic_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbpayrollperiodic.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbpayrollpf.Focus()
        End If
    End Sub

    Private Sub cmbpayrollpf_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbpayrollpf.KeyDown
        If e.KeyCode = Keys.Enter Then
            ETabControlEx1.SelectTab(TabPage8)
            cmbinstitutedefault.Focus()
        End If
    End Sub

    Private Sub cmbinstitutedefault_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbinstitutedefault.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmblibrarydefault.Focus()
        End If
    End Sub

    Private Sub cmblibrarydefault_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmblibrarydefault.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbpayrolldefault.Focus()
        End If
    End Sub

    Private Sub cmbpayrolldefault_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbpayrolldefault.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbrevenue.Focus()
        End If
    End Sub

    Private Sub cmbrevenue_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbrevenue.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbyearend.Focus()
        End If
    End Sub

    Private Sub cmbyearend_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbyearend.KeyDown
        If e.KeyCode = Keys.Enter Then
            ETabControlEx1.SelectTab(TabPage1)
            CheckTabPageAndUpdateButtons()
            cmbemployeeinfo.Focus()
        End If
    End Sub

    Private Sub ComboBoxKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbaccounting.KeyPress, cmbadmission.KeyPress, cmbalumni.KeyPress, cmbattendance.KeyPress, cmbbackuprestore.KeyPress, cmbbankinginfo.KeyPress, cmbcertificates.KeyPress, cmbcoursesubject.KeyPress, cmbcoursesubject.KeyPress, cmbdiscount.KeyPress, cmbemployeecard.KeyPress, cmbemployeeinfo.KeyPress, cmbexamination.KeyPress, cmbfeescollection.KeyPress, cmbfinancial.KeyPress, cmbgames.KeyPress, cmbglobalaccess.KeyPress, cmbidcards.KeyPress, cmbimportexport.KeyPress, cmbincomeexpenditure.KeyPress, cmbinventory.KeyPress, cmblocalmessenger.KeyPress, cmbmarksheet.KeyPress, cmbnotices.KeyPress, cmbpreadmission.KeyPress, cmbprogressreport.KeyPress, cmbpurchaseorder.KeyPress, cmbregistration.KeyPress, cmbsalesinvoice.KeyPress, cmbstudentcard.KeyPress, cmbstudentcontrol.KeyPress, cmbstudentinfo.KeyPress, cmbtermsfees.KeyPress, cmbuser.KeyPress, cmbbookrecord.KeyPress, cmbcharges.KeyPress, cmbissuebooks.KeyPress, cmbreturnbooks.KeyPress, cmbpayrollperiodic.KeyPress, cmbpayrollpf.KeyPress, cmbpayrollsystem.KeyPress, cmbinstitutedefault.KeyPress, cmblibrarydefault.KeyPress, cmbpayrolldefault.KeyPress, cmbrevenue.KeyPress, cmbyearend.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub

    Private Sub lnkchangepassword_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkchangepassword.LinkClicked
        userid = cmbuser.Text
        Dim frm As New frmChangePassword()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.WindowState = FormWindowState.Normal
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnback_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnback.ClickButtonArea
        If btnback.Tag = "" Then
            GoToTab(-1)
        End If
    End Sub

    Private Sub btnnext_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnext.ClickButtonArea
        If btnnext.Tag = "finish" Then
            ETabControlEx1.SelectedIndex = 0
            btnnext.Text = LanguageTexts_Next
            CheckTabPageAndUpdateButtons()
        Else
            GoToTab()
        End If
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        UpdateUser()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region