#Region "Imports..."
Imports ESAR_Controls.UIControls.eForms
#End Region
#Region "Class frmMainForm..."
Public Class frmMainForm
#Region "WithEvents..."
    Private WithEvents childA As frmChangeSystemDate
#End Region
#Region "Declarations..."
    Dim Docker As New FormDocker(Me, FormDocker.FormDockMode.TopRight, New Padding(5))
    Private userexist As Boolean = False
#End Region
#Region "Methods..."
    Private Sub CheckUser()
        Try
            cmd.CommandText = "select * from Users where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                userexist = True
            Else
                userexist = False
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
            userexist = False
        End Try
    End Sub

    Private Sub VisibleMenus()
        ToolStripSeparator2.Visible = False
        ToolStripSeparator3.Visible = False
        ToolStripSeparator4.Visible = False
        CloseInstituteToolStripMenuItem.Visible = False
        ImportYourDataToolStripMenuItem.Visible = False
        ExportYourDataToolStripMenuItem.Visible = False
        BackupInstitutionDataToolStripMenuItem.Visible = False
        RestoreInstitutionDataToolStripMenuItem.Visible = False
        SynchronizeInstitutionDataThroughTheWebToolStripMenuItem.Visible = False
        EditToolStripMenuItem.Visible = False
    End Sub

    Private Sub GlobalSettings()
        Try
            cmd.CommandText = "select * from GlobalSettings"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                DecimalEntry = dr("decimalentry").ToString()
                QntyField = CInt(dr("qntyfield").ToString())
                PriceField = CInt(dr("pricefield").ToString())
                StandardField = CInt(dr("standardfield").ToString())
                Option1 = dr("option1").ToString()
                Option2 = dr("option2").ToString()
                Option3 = dr("option3").ToString()
                Option4 = dr("option4").ToString()
                Option5 = dr("option5").ToString()
                Performance1 = dr("performance1").ToString()
                Performance2 = dr("performance2").ToString()
                Performance3 = dr("performance3").ToString()
                Performance4 = dr("performance4").ToString()
                ItemEntry = dr("itementry").ToString()
                DataEntry1 = dr("dataentry1").ToString()
                DataEntry2 = dr("dataentry2").ToString()
                DataEntry3 = dr("dataentry3").ToString()
                PartnerSecurity = dr("partnersecurity").ToString()
                dr.Close()
            Else
                dr.Close()
                DecimalEntry = "Manual"
                QntyField = 2
                PriceField = 2
                StandardField = 2
                Option1 = "Yes"
                Option2 = "No"
                Option3 = "No"
                Option4 = "No"
                Option5 = "No"
                Performance1 = "Yes"
                Performance2 = "No"
                Performance3 = "No"
                Performance4 = "No"
                ItemEntry = "Line 1"
                DataEntry1 = "Yes"
                DataEntry2 = "Yes"
                DataEntry3 = "Yes"
                PartnerSecurity = "Medium - Warn before Umbrella partner applications to run (Recommended)."

                cmd.CommandText = "insert into GlobalSettings(decimalentry,qntyfield,pricefield,standardfield,option1,option2,option3,option4,option5,performance1,performance2,performance3,performance4,itementry,dataentry1,dataentry2,dataentry3,partnersecurity) values ('" & DecimalEntry & "'," & QntyField & "," & PriceField & "," & StandardField & ",'" & Option1 & "','" & Option2 & "','" & Option3 & "','" & Option4 & "','" & Option5 & "','" & Performance1 & "','" & Performance2 & "','" & Performance3 & "','" & Performance4 & "','" & ItemEntry & "','" & DataEntry1 & "','" & DataEntry2 & "','" & DataEntry3 & "','" & PartnerSecurity & "')"
                dr = cmd.ExecuteReader
                dr.Close()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmMainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        conn.Close()
    End Sub

    Private Sub frmMainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'My.Settings.Reset()
        Docker.DockForm()
        Docker.UndockForm()
        Docker.DockForm()
        Connect()
        CheckUser()
        GlobalSettings()
        VisibleMenus()
        UmbrellaSystemDate = Date.Now.ToShortDateString()
        Dim frm As New frmMainTask()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub frmMainForm_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        Docker.Refresh()
    End Sub

    Private Sub frmMainForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Docker.Refresh()
    End Sub
#End Region
#Region "Menu Events..."
#Region "File Menu..."
    Private Sub NewInstituteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewInstituteToolStripMenuItem.Click
        For Each frmApproval As Form In Me.MdiChildren
            frmApproval.Close()
        Next
        MainTask = "Create"
        If userexist = True Then
            Dim frm As New frmLogin()
            frm.MdiParent = Me
            frm.Show()
        Else
            Dim frm As New frmCreateInstitute()
            frm.MdiParent = Me
            frm.Show()
        End If
    End Sub

    Private Sub OpenPreviouslyOpenedInstituteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenPreviouslyOpenedInstituteToolStripMenuItem.Click
        For Each frmApproval As Form In Me.MdiChildren
            frmApproval.Close()
        Next
        MainTask = "Open"
        If userexist = True Then
            Dim frm As New frmLogin()
            frm.MdiParent = Me
            frm.Show()
        Else
            Dim frm As New frmMainSelect()
            frm.MdiParent = Me
            frm.Show()
        End If

    End Sub

    Private Sub OpenInstituteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenInstituteToolStripMenuItem1.Click
        For Each frmApproval As Form In Me.MdiChildren
            frmApproval.Close()
        Next
        MainTask = "Open"
        Dim frm As New frmOpenInstitute()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CloseInstituteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseInstituteToolStripMenuItem.Click
        For Each frmApproval As Form In Me.MdiChildren
            frmApproval.Close()
        Next
    End Sub

    Private Sub ImportYourDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportYourDataToolStripMenuItem.Click
        Dim frm As New frmImportExportInstitute()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub ExportYourDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportYourDataToolStripMenuItem.Click
        Dim frm As New frmImportExportInstitute()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub BackupInstitutionDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupInstitutionDataToolStripMenuItem.Click
        Dim frm As New frmBackupRestore()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub RestoreInstitutionDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreInstitutionDataToolStripMenuItem.Click
        Dim frm As New frmBackupRestore()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub SynchronizeInstitutionDataThroughTheWebToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SynchronizeInstitutionDataThroughTheWebToolStripMenuItem.Click
        Dim frm As New frmSynchronize()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        For Each frmApproval As Form In Me.MdiChildren
            frmApproval.Close()
        Next
        Me.Close()
    End Sub
#End Region
#Region "Edit Menu..."
    Private Sub FindTransactionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindTransactionsToolStripMenuItem.Click
        Dim frm As New frmFindTransaction()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub
#End Region
#Region "Options Menu..."
    Private Sub GlobalSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlobalSettingsToolStripMenuItem.Click
        Dim frm As New frmGlobalSettings()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub DefineInternetConnectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefineInternetConnectionToolStripMenuItem.Click
        Dim frm As New frmInternetConnection()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub StartWithLastOpenedInstituteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartWithLastOpenedInstituteToolStripMenuItem.Click

    End Sub
#End Region
#Region "Services Menu..."
    Private Sub CheckForUpdatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        Dim frm As New frmCheckUpdates()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub MyECreativeAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyECreativeAccountToolStripMenuItem.Click

    End Sub

    Private Sub CustomerSupportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerSupportToolStripMenuItem.Click
        Dim frm As New frmCustomerSupport()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub UmbrellaOnTheWebToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UmbrellaOnTheWebToolStripMenuItem.Click

    End Sub

    Private Sub ProductComparisonToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductComparisonToolStripMenuItem.Click
        Dim frm As New frmProductComparison()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub IndustrySpecificSolutionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndustrySpecificSolutionsToolStripMenuItem.Click
        Dim frm As New frmIndustrySpecificSolution()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub MidSizedBusinessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MidSizedBusinessToolStripMenuItem.Click
        Dim frm As New frmMidSizedBusiness()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub MoreProductsServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoreProductsServicesToolStripMenuItem.Click

    End Sub

    Private Sub UmbrellaWebTransactionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UmbrellaWebTransactionsToolStripMenuItem.Click
        Dim frm As New frmWebTransaction()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub UmbrellaSyncWizardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UmbrellaSyncWizardToolStripMenuItem.Click
        Dim frm As New frmSynchronize()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub ObsolescenceInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObsolescenceInformationToolStripMenuItem.Click
        Dim frm As New frmObsolescenceInformation()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub
#End Region
#Region "Help Menu..."
    Private Sub UmbrellaHelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UmbrellaHelpToolStripMenuItem.Click

    End Sub

    Private Sub UmbrellaGuidedTourToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UmbrellaGuidedTourToolStripMenuItem.Click

    End Sub

    Private Sub UserGuideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserGuideToolStripMenuItem.Click

    End Sub

    Private Sub GettingStartedWithCrystalReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GettingStartedWithCrystalReportToolStripMenuItem.Click

    End Sub

    Private Sub MakeABackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MakeABackupToolStripMenuItem.Click

    End Sub

    Private Sub OpenASavedTransactionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenASavedTransactionToolStripMenuItem.Click

    End Sub

    Private Sub InstallOnlineUpdatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstallOnlineUpdatesToolStripMenuItem.Click

    End Sub

    Private Sub ChangePeriodToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePeriodToolStripMenuItem.Click

    End Sub

    Private Sub ChangeCloseFinancialPeriodYearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeCloseFinancialPeriodYearToolStripMenuItem.Click

    End Sub

    Private Sub ChangeSystemDateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeSystemDateToolStripMenuItem.Click

    End Sub

    Private Sub AllDemosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllDemosToolStripMenuItem.Click

    End Sub

    Private Sub UmbrellaKnowledgeCenterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UmbrellaKnowledgeCenterToolStripMenuItem.Click

    End Sub

    Private Sub LiveChatAssistanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LiveChatAssistanceToolStripMenuItem.Click

    End Sub

    Private Sub EmailProductSupportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailProductSupportToolStripMenuItem.Click

    End Sub

    Private Sub EmailCustomerServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailCustomerServiceToolStripMenuItem.Click

    End Sub

    Private Sub ProductSupportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductSupportToolStripMenuItem.Click

    End Sub

    Private Sub StartupConfigurationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartupConfigurationToolStripMenuItem.Click

    End Sub

    Private Sub ClearUserLicensesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearUserLicensesToolStripMenuItem.Click

    End Sub

    Private Sub ProductFeedbackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductFeedbackToolStripMenuItem.Click

    End Sub

    Private Sub ClearUserLicensesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearUserLicensesToolStripMenuItem1.Click

    End Sub

    Private Sub UmbrellaRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UmbrellaRegistrationToolStripMenuItem.Click

    End Sub

    Private Sub LicenseAgreementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LicenseAgreementToolStripMenuItem.Click

    End Sub

    Private Sub AboutUmbrellaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutUmbrellaToolStripMenuItem.Click

    End Sub
#End Region
#End Region
End Class
#End Region