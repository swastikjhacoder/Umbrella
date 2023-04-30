Imports Umbrella.UIControls
Imports ESAR_Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainForm
    Inherits ESAR_Controls.UIControls.eForms.eFadeGradientForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainForm))
        Me.EMenuStrip1 = New ESAR_Controls.Strips.eMenuStrip
        Me.EAppearanceControl1 = New ESAR_Controls.Appearance.eAppearanceControl
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewInstituteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenInstituteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenPreviouslyOpenedInstituteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.OpenInstituteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseInstituteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ImportYourDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExportYourDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BackupInstitutionDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RestoreInstitutionDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.SynchronizeInstitutionDataThroughTheWebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FindTransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GlobalSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DefineInternetConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.StartWithLastOpenedInstituteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MyECreativeAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.CustomerSupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UmbrellaOnTheWebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.ProductComparisonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IndustrySpecificSolutionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MidSizedBusinessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.MoreProductsServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.UmbrellaWebTransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UmbrellaSyncWizardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator
        Me.ObsolescenceInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UmbrellaHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
        Me.UmbrellaGuidedTourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UserManualsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UserGuideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GettingStartedWithCrystalReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ShowMeHowToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MakeABackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenASavedTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InstallOnlineUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangePeriodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeCloseFinancialPeriodYearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeSystemDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AllDemosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator
        Me.CustomerSupportServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UmbrellaKnowledgeCenterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LiveChatAssistanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmailProductSupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmailCustomerServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductSupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StartupConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearUserLicensesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UmbrellaOnTheWebToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductFeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearUserLicensesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.UmbrellaRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator
        Me.LicenseAgreementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutUmbrellaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EStatusStrip1 = New ESAR_Controls.Strips.eStatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.EMenuStrip1.SuspendLayout()
        Me.EStatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EMenuStrip1
        '
        Me.EMenuStrip1.Appearance = Me.EAppearanceControl1
        Me.EMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.ServicesToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.EMenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.EMenuStrip1.Name = "EMenuStrip1"
        Me.EMenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.EMenuStrip1.TabIndex = 1
        Me.EMenuStrip1.Text = "EMenuStrip1"
        '
        'EAppearanceControl1
        '
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.CheckedAppearance.intBackground = -16273
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.CheckedAppearance.intBorderHighlight = -13410648
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.CheckedAppearance.intGradientBegin = -8294
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.CheckedAppearance.intGradientEnd = -22964
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.CheckedAppearance.intGradientMiddle = -15500
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.CheckedAppearance.intHighlight = -3878683
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.CheckedAppearance.intPressedBackground = -98242
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.CheckedAppearance.intSelectedBackground = -98242
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.PressedAppearance.Border = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.PressedAppearance.intBorder = -16777088
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.PressedAppearance.intBorderHighlight = -13410648
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.PressedAppearance.intGradientBegin = -98242
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.PressedAppearance.intGradientEnd = -8294
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.PressedAppearance.intGradientMiddle = -20115
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.PressedAppearance.intHighlight = -6771246
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.SelectedAppearance.Border = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.SelectedAppearance.BorderHighlight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.SelectedAppearance.intBorder = -16777088
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.SelectedAppearance.intBorderHighlight = -16777088
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.SelectedAppearance.intGradientBegin = -34
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.SelectedAppearance.intGradientEnd = -13432
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.SelectedAppearance.intGradientMiddle = -7764
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.SelectedAppearance.intHighlight = -3878683
        Me.EAppearanceControl1.CustomAppearance.GripAppearance.intDark = -14204554
        Me.EAppearanceControl1.CustomAppearance.GripAppearance.intLight = -1
        Me.EAppearanceControl1.CustomAppearance.GripAppearance.Light = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EAppearanceControl1.CustomAppearance.ImageMarginAppearance.Normal.intGradientBegin = -1839105
        Me.EAppearanceControl1.CustomAppearance.ImageMarginAppearance.Normal.intGradientEnd = -8674080
        Me.EAppearanceControl1.CustomAppearance.ImageMarginAppearance.Normal.intGradientMiddle = -3415556
        Me.EAppearanceControl1.CustomAppearance.ImageMarginAppearance.Revealed.intGradientBegin = -3416586
        Me.EAppearanceControl1.CustomAppearance.ImageMarginAppearance.Revealed.intGradientEnd = -9266217
        Me.EAppearanceControl1.CustomAppearance.ImageMarginAppearance.Revealed.intGradientMiddle = -6175239
        Me.EAppearanceControl1.CustomAppearance.MenuItemAppearance.Border = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EAppearanceControl1.CustomAppearance.MenuItemAppearance.intBorder = -16777088
        Me.EAppearanceControl1.CustomAppearance.MenuItemAppearance.intPressedGradientBegin = -1839105
        Me.EAppearanceControl1.CustomAppearance.MenuItemAppearance.intPressedGradientEnd = -8674080
        Me.EAppearanceControl1.CustomAppearance.MenuItemAppearance.intPressedGradientMiddle = -6175239
        Me.EAppearanceControl1.CustomAppearance.MenuItemAppearance.intSelected = -4414
        Me.EAppearanceControl1.CustomAppearance.MenuItemAppearance.intSelectedGradientBegin = -34
        Me.EAppearanceControl1.CustomAppearance.MenuItemAppearance.intSelectedGradientEnd = -13432
        Me.EAppearanceControl1.CustomAppearance.MenuStripAppearance.intBorder = -16765546
        Me.EAppearanceControl1.CustomAppearance.MenuStripAppearance.intGradientBegin = -6373643
        Me.EAppearanceControl1.CustomAppearance.MenuStripAppearance.intGradientEnd = -3876102
        Me.EAppearanceControl1.CustomAppearance.OverflowButtonAppearance.intGradientBegin = -8408582
        Me.EAppearanceControl1.CustomAppearance.OverflowButtonAppearance.intGradientEnd = -16763503
        Me.EAppearanceControl1.CustomAppearance.OverflowButtonAppearance.intGradientMiddle = -11370544
        Me.EAppearanceControl1.CustomAppearance.RaftingContainerAppearance.intGradientBegin = -6373643
        Me.EAppearanceControl1.CustomAppearance.RaftingContainerAppearance.intGradientEnd = -3876102
        Me.EAppearanceControl1.CustomAppearance.SeparatorAppearance.intDark = -9794357
        Me.EAppearanceControl1.CustomAppearance.SeparatorAppearance.intLight = -919041
        Me.EAppearanceControl1.CustomAppearance.StatusStripAppearance.intGradientBegin = -6373643
        Me.EAppearanceControl1.CustomAppearance.StatusStripAppearance.intGradientEnd = -3876102
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intBorder = -12885604
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intContentPanelGradientBegin = -6373643
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intContentPanelGradientEnd = -3876102
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intDropDownBackground = -592138
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intGradientBegin = -1839105
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intGradientEnd = -8674080
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intGradientMiddle = -3415556
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intPanelGradientBegin = -6373643
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intPanelGradientEnd = -3876102
        Me.EAppearanceControl1.Preset = ESAR_Controls.Appearance.eAppearanceControl.enumPresetStyles.Custom
        Me.EAppearanceControl1.Renderer.RoundedEdges = True
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewInstituteToolStripMenuItem, Me.OpenInstituteToolStripMenuItem, Me.CloseInstituteToolStripMenuItem, Me.ToolStripSeparator2, Me.ImportYourDataToolStripMenuItem, Me.ExportYourDataToolStripMenuItem, Me.ToolStripSeparator3, Me.BackupInstitutionDataToolStripMenuItem, Me.RestoreInstitutionDataToolStripMenuItem, Me.ToolStripSeparator4, Me.SynchronizeInstitutionDataThroughTheWebToolStripMenuItem, Me.ToolStripSeparator5, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewInstituteToolStripMenuItem
        '
        Me.NewInstituteToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources._new
        Me.NewInstituteToolStripMenuItem.Name = "NewInstituteToolStripMenuItem"
        Me.NewInstituteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewInstituteToolStripMenuItem.Size = New System.Drawing.Size(318, 22)
        Me.NewInstituteToolStripMenuItem.Text = "&New Institute"
        '
        'OpenInstituteToolStripMenuItem
        '
        Me.OpenInstituteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenPreviouslyOpenedInstituteToolStripMenuItem, Me.ToolStripSeparator1, Me.OpenInstituteToolStripMenuItem1})
        Me.OpenInstituteToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources.open
        Me.OpenInstituteToolStripMenuItem.Name = "OpenInstituteToolStripMenuItem"
        Me.OpenInstituteToolStripMenuItem.Size = New System.Drawing.Size(318, 22)
        Me.OpenInstituteToolStripMenuItem.Text = "&Open Institute"
        '
        'OpenPreviouslyOpenedInstituteToolStripMenuItem
        '
        Me.OpenPreviouslyOpenedInstituteToolStripMenuItem.Image = CType(resources.GetObject("OpenPreviouslyOpenedInstituteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenPreviouslyOpenedInstituteToolStripMenuItem.Name = "OpenPreviouslyOpenedInstituteToolStripMenuItem"
        Me.OpenPreviouslyOpenedInstituteToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenPreviouslyOpenedInstituteToolStripMenuItem.Size = New System.Drawing.Size(326, 22)
        Me.OpenPreviouslyOpenedInstituteToolStripMenuItem.Text = "&Open Previously Opened Institute"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(323, 6)
        '
        'OpenInstituteToolStripMenuItem1
        '
        Me.OpenInstituteToolStripMenuItem1.Image = CType(resources.GetObject("OpenInstituteToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.OpenInstituteToolStripMenuItem1.Name = "OpenInstituteToolStripMenuItem1"
        Me.OpenInstituteToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenInstituteToolStripMenuItem1.Size = New System.Drawing.Size(326, 22)
        Me.OpenInstituteToolStripMenuItem1.Text = "Open Institute"
        '
        'CloseInstituteToolStripMenuItem
        '
        Me.CloseInstituteToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources.close
        Me.CloseInstituteToolStripMenuItem.Name = "CloseInstituteToolStripMenuItem"
        Me.CloseInstituteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CloseInstituteToolStripMenuItem.Size = New System.Drawing.Size(318, 22)
        Me.CloseInstituteToolStripMenuItem.Text = "Close Institute"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(315, 6)
        '
        'ImportYourDataToolStripMenuItem
        '
        Me.ImportYourDataToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources.import_icon
        Me.ImportYourDataToolStripMenuItem.Name = "ImportYourDataToolStripMenuItem"
        Me.ImportYourDataToolStripMenuItem.Size = New System.Drawing.Size(318, 22)
        Me.ImportYourDataToolStripMenuItem.Text = "Import Your Data"
        '
        'ExportYourDataToolStripMenuItem
        '
        Me.ExportYourDataToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources.export_icon
        Me.ExportYourDataToolStripMenuItem.Name = "ExportYourDataToolStripMenuItem"
        Me.ExportYourDataToolStripMenuItem.Size = New System.Drawing.Size(318, 22)
        Me.ExportYourDataToolStripMenuItem.Text = "Export Your Data"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(315, 6)
        '
        'BackupInstitutionDataToolStripMenuItem
        '
        Me.BackupInstitutionDataToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources.Backup
        Me.BackupInstitutionDataToolStripMenuItem.Name = "BackupInstitutionDataToolStripMenuItem"
        Me.BackupInstitutionDataToolStripMenuItem.Size = New System.Drawing.Size(318, 22)
        Me.BackupInstitutionDataToolStripMenuItem.Text = "Backup Institution Data"
        '
        'RestoreInstitutionDataToolStripMenuItem
        '
        Me.RestoreInstitutionDataToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources.Restore
        Me.RestoreInstitutionDataToolStripMenuItem.Name = "RestoreInstitutionDataToolStripMenuItem"
        Me.RestoreInstitutionDataToolStripMenuItem.Size = New System.Drawing.Size(318, 22)
        Me.RestoreInstitutionDataToolStripMenuItem.Text = "Restore Institution Data"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(315, 6)
        '
        'SynchronizeInstitutionDataThroughTheWebToolStripMenuItem
        '
        Me.SynchronizeInstitutionDataThroughTheWebToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources.synchronize
        Me.SynchronizeInstitutionDataThroughTheWebToolStripMenuItem.Name = "SynchronizeInstitutionDataThroughTheWebToolStripMenuItem"
        Me.SynchronizeInstitutionDataThroughTheWebToolStripMenuItem.Size = New System.Drawing.Size(318, 22)
        Me.SynchronizeInstitutionDataThroughTheWebToolStripMenuItem.Text = "Synchronize Institution Data Through the Web"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(315, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources._Exit
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(318, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindTransactionsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'FindTransactionsToolStripMenuItem
        '
        Me.FindTransactionsToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources.indian_rupee
        Me.FindTransactionsToolStripMenuItem.Name = "FindTransactionsToolStripMenuItem"
        Me.FindTransactionsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.FindTransactionsToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.FindTransactionsToolStripMenuItem.Text = "&Find Transactions"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GlobalSettingsToolStripMenuItem, Me.DefineInternetConnectionToolStripMenuItem, Me.ToolStripSeparator6, Me.StartWithLastOpenedInstituteToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'GlobalSettingsToolStripMenuItem
        '
        Me.GlobalSettingsToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources.settings_icon
        Me.GlobalSettingsToolStripMenuItem.Name = "GlobalSettingsToolStripMenuItem"
        Me.GlobalSettingsToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.GlobalSettingsToolStripMenuItem.Text = "&Global Settings"
        '
        'DefineInternetConnectionToolStripMenuItem
        '
        Me.DefineInternetConnectionToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources.internet_connection
        Me.DefineInternetConnectionToolStripMenuItem.Name = "DefineInternetConnectionToolStripMenuItem"
        Me.DefineInternetConnectionToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.DefineInternetConnectionToolStripMenuItem.Text = "Define Internet Connection"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(238, 6)
        '
        'StartWithLastOpenedInstituteToolStripMenuItem
        '
        Me.StartWithLastOpenedInstituteToolStripMenuItem.Checked = True
        Me.StartWithLastOpenedInstituteToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StartWithLastOpenedInstituteToolStripMenuItem.Name = "StartWithLastOpenedInstituteToolStripMenuItem"
        Me.StartWithLastOpenedInstituteToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.StartWithLastOpenedInstituteToolStripMenuItem.Text = "Start With Last Opened Institute"
        '
        'ServicesToolStripMenuItem
        '
        Me.ServicesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckForUpdatesToolStripMenuItem, Me.MyECreativeAccountToolStripMenuItem, Me.ToolStripSeparator7, Me.CustomerSupportToolStripMenuItem, Me.UmbrellaOnTheWebToolStripMenuItem, Me.ToolStripSeparator8, Me.ProductComparisonToolStripMenuItem, Me.IndustrySpecificSolutionsToolStripMenuItem, Me.MidSizedBusinessToolStripMenuItem, Me.ToolStripSeparator9, Me.MoreProductsServicesToolStripMenuItem, Me.ToolStripSeparator10, Me.UmbrellaWebTransactionsToolStripMenuItem, Me.UmbrellaSyncWizardToolStripMenuItem, Me.ToolStripSeparator14, Me.ObsolescenceInformationToolStripMenuItem})
        Me.ServicesToolStripMenuItem.Name = "ServicesToolStripMenuItem"
        Me.ServicesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ServicesToolStripMenuItem.Text = "&Services"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources.update
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for Updates"
        '
        'MyECreativeAccountToolStripMenuItem
        '
        Me.MyECreativeAccountToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources.my_account
        Me.MyECreativeAccountToolStripMenuItem.Name = "MyECreativeAccountToolStripMenuItem"
        Me.MyECreativeAccountToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.MyECreativeAccountToolStripMenuItem.Text = "My ESAR Infotech Account"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(215, 6)
        '
        'CustomerSupportToolStripMenuItem
        '
        Me.CustomerSupportToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources.customer_support
        Me.CustomerSupportToolStripMenuItem.Name = "CustomerSupportToolStripMenuItem"
        Me.CustomerSupportToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.CustomerSupportToolStripMenuItem.Text = "Customer Support"
        '
        'UmbrellaOnTheWebToolStripMenuItem
        '
        Me.UmbrellaOnTheWebToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources.Website_icon
        Me.UmbrellaOnTheWebToolStripMenuItem.Name = "UmbrellaOnTheWebToolStripMenuItem"
        Me.UmbrellaOnTheWebToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.UmbrellaOnTheWebToolStripMenuItem.Text = "Umbrella on the web"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(215, 6)
        '
        'ProductComparisonToolStripMenuItem
        '
        Me.ProductComparisonToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources.comparisons
        Me.ProductComparisonToolStripMenuItem.Name = "ProductComparisonToolStripMenuItem"
        Me.ProductComparisonToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ProductComparisonToolStripMenuItem.Text = "Product Comparison"
        '
        'IndustrySpecificSolutionsToolStripMenuItem
        '
        Me.IndustrySpecificSolutionsToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources.Solutions_Icon
        Me.IndustrySpecificSolutionsToolStripMenuItem.Name = "IndustrySpecificSolutionsToolStripMenuItem"
        Me.IndustrySpecificSolutionsToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.IndustrySpecificSolutionsToolStripMenuItem.Text = "Industry Specific Solutions"
        '
        'MidSizedBusinessToolStripMenuItem
        '
        Me.MidSizedBusinessToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources.pie_chart_icon
        Me.MidSizedBusinessToolStripMenuItem.Name = "MidSizedBusinessToolStripMenuItem"
        Me.MidSizedBusinessToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.MidSizedBusinessToolStripMenuItem.Text = "Mid-Sized Business"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(215, 6)
        '
        'MoreProductsServicesToolStripMenuItem
        '
        Me.MoreProductsServicesToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources.Product
        Me.MoreProductsServicesToolStripMenuItem.Name = "MoreProductsServicesToolStripMenuItem"
        Me.MoreProductsServicesToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.MoreProductsServicesToolStripMenuItem.Text = "More Products && Services"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(215, 6)
        '
        'UmbrellaWebTransactionsToolStripMenuItem
        '
        Me.UmbrellaWebTransactionsToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources.web_transaction
        Me.UmbrellaWebTransactionsToolStripMenuItem.Name = "UmbrellaWebTransactionsToolStripMenuItem"
        Me.UmbrellaWebTransactionsToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.UmbrellaWebTransactionsToolStripMenuItem.Text = "Umbrella Web Transactions"
        '
        'UmbrellaSyncWizardToolStripMenuItem
        '
        Me.UmbrellaSyncWizardToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources.synchronize
        Me.UmbrellaSyncWizardToolStripMenuItem.Name = "UmbrellaSyncWizardToolStripMenuItem"
        Me.UmbrellaSyncWizardToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.UmbrellaSyncWizardToolStripMenuItem.Text = "Umbrella Sync Wizard"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(215, 6)
        '
        'ObsolescenceInformationToolStripMenuItem
        '
        Me.ObsolescenceInformationToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources.Obsolescence_Information
        Me.ObsolescenceInformationToolStripMenuItem.Name = "ObsolescenceInformationToolStripMenuItem"
        Me.ObsolescenceInformationToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ObsolescenceInformationToolStripMenuItem.Text = "Obsolescence Information"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UmbrellaHelpToolStripMenuItem, Me.ToolStripSeparator11, Me.UmbrellaGuidedTourToolStripMenuItem, Me.UserManualsToolStripMenuItem, Me.ShowMeHowToToolStripMenuItem, Me.ToolStripSeparator12, Me.CustomerSupportServiceToolStripMenuItem, Me.UmbrellaOnTheWebToolStripMenuItem1, Me.UmbrellaRegistrationToolStripMenuItem, Me.ToolStripSeparator13, Me.LicenseAgreementToolStripMenuItem, Me.AboutUmbrellaToolStripMenuItem})
        Me.HelpToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources.help
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'UmbrellaHelpToolStripMenuItem
        '
        Me.UmbrellaHelpToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources.help
        Me.UmbrellaHelpToolStripMenuItem.Name = "UmbrellaHelpToolStripMenuItem"
        Me.UmbrellaHelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.UmbrellaHelpToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.UmbrellaHelpToolStripMenuItem.Text = "Umbrella Help"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(221, 6)
        '
        'UmbrellaGuidedTourToolStripMenuItem
        '
        Me.UmbrellaGuidedTourToolStripMenuItem.Image = CType(resources.GetObject("UmbrellaGuidedTourToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UmbrellaGuidedTourToolStripMenuItem.Name = "UmbrellaGuidedTourToolStripMenuItem"
        Me.UmbrellaGuidedTourToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.UmbrellaGuidedTourToolStripMenuItem.Text = "Umbrella Guided Tour"
        '
        'UserManualsToolStripMenuItem
        '
        Me.UserManualsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserGuideToolStripMenuItem, Me.GettingStartedWithCrystalReportToolStripMenuItem})
        Me.UserManualsToolStripMenuItem.Image = CType(resources.GetObject("UserManualsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UserManualsToolStripMenuItem.Name = "UserManualsToolStripMenuItem"
        Me.UserManualsToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.UserManualsToolStripMenuItem.Text = "User Manuals"
        '
        'UserGuideToolStripMenuItem
        '
        Me.UserGuideToolStripMenuItem.Image = CType(resources.GetObject("UserGuideToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UserGuideToolStripMenuItem.Name = "UserGuideToolStripMenuItem"
        Me.UserGuideToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.UserGuideToolStripMenuItem.Text = "User Guide"
        '
        'GettingStartedWithCrystalReportToolStripMenuItem
        '
        Me.GettingStartedWithCrystalReportToolStripMenuItem.Image = CType(resources.GetObject("GettingStartedWithCrystalReportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GettingStartedWithCrystalReportToolStripMenuItem.Name = "GettingStartedWithCrystalReportToolStripMenuItem"
        Me.GettingStartedWithCrystalReportToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.GettingStartedWithCrystalReportToolStripMenuItem.Text = "Getting Started With Crystal Report"
        '
        'ShowMeHowToToolStripMenuItem
        '
        Me.ShowMeHowToToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MakeABackupToolStripMenuItem, Me.OpenASavedTransactionToolStripMenuItem, Me.InstallOnlineUpdatesToolStripMenuItem, Me.ChangePeriodToolStripMenuItem, Me.ChangeCloseFinancialPeriodYearToolStripMenuItem, Me.ChangeSystemDateToolStripMenuItem, Me.AllDemosToolStripMenuItem})
        Me.ShowMeHowToToolStripMenuItem.Image = CType(resources.GetObject("ShowMeHowToToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ShowMeHowToToolStripMenuItem.Name = "ShowMeHowToToolStripMenuItem"
        Me.ShowMeHowToToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ShowMeHowToToolStripMenuItem.Text = "Show Me How To"
        '
        'MakeABackupToolStripMenuItem
        '
        Me.MakeABackupToolStripMenuItem.Image = CType(resources.GetObject("MakeABackupToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MakeABackupToolStripMenuItem.Name = "MakeABackupToolStripMenuItem"
        Me.MakeABackupToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.MakeABackupToolStripMenuItem.Text = "Make a Backup"
        '
        'OpenASavedTransactionToolStripMenuItem
        '
        Me.OpenASavedTransactionToolStripMenuItem.Image = CType(resources.GetObject("OpenASavedTransactionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenASavedTransactionToolStripMenuItem.Name = "OpenASavedTransactionToolStripMenuItem"
        Me.OpenASavedTransactionToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.OpenASavedTransactionToolStripMenuItem.Text = "Open a Saved Transaction"
        '
        'InstallOnlineUpdatesToolStripMenuItem
        '
        Me.InstallOnlineUpdatesToolStripMenuItem.Image = CType(resources.GetObject("InstallOnlineUpdatesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InstallOnlineUpdatesToolStripMenuItem.Name = "InstallOnlineUpdatesToolStripMenuItem"
        Me.InstallOnlineUpdatesToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.InstallOnlineUpdatesToolStripMenuItem.Text = "Install Online Updates"
        '
        'ChangePeriodToolStripMenuItem
        '
        Me.ChangePeriodToolStripMenuItem.Image = CType(resources.GetObject("ChangePeriodToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangePeriodToolStripMenuItem.Name = "ChangePeriodToolStripMenuItem"
        Me.ChangePeriodToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.ChangePeriodToolStripMenuItem.Text = "Change Period"
        '
        'ChangeCloseFinancialPeriodYearToolStripMenuItem
        '
        Me.ChangeCloseFinancialPeriodYearToolStripMenuItem.Image = CType(resources.GetObject("ChangeCloseFinancialPeriodYearToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangeCloseFinancialPeriodYearToolStripMenuItem.Name = "ChangeCloseFinancialPeriodYearToolStripMenuItem"
        Me.ChangeCloseFinancialPeriodYearToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.ChangeCloseFinancialPeriodYearToolStripMenuItem.Text = "Change/ Close Financial Period Year"
        '
        'ChangeSystemDateToolStripMenuItem
        '
        Me.ChangeSystemDateToolStripMenuItem.Image = CType(resources.GetObject("ChangeSystemDateToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangeSystemDateToolStripMenuItem.Name = "ChangeSystemDateToolStripMenuItem"
        Me.ChangeSystemDateToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.ChangeSystemDateToolStripMenuItem.Text = "Change System Date"
        '
        'AllDemosToolStripMenuItem
        '
        Me.AllDemosToolStripMenuItem.Image = CType(resources.GetObject("AllDemosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AllDemosToolStripMenuItem.Name = "AllDemosToolStripMenuItem"
        Me.AllDemosToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.AllDemosToolStripMenuItem.Text = "All Demos"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(221, 6)
        '
        'CustomerSupportServiceToolStripMenuItem
        '
        Me.CustomerSupportServiceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UmbrellaKnowledgeCenterToolStripMenuItem, Me.LiveChatAssistanceToolStripMenuItem, Me.EmailProductSupportToolStripMenuItem, Me.EmailCustomerServiceToolStripMenuItem, Me.ProductSupportToolStripMenuItem, Me.StartupConfigurationToolStripMenuItem, Me.ClearUserLicensesToolStripMenuItem})
        Me.CustomerSupportServiceToolStripMenuItem.Image = CType(resources.GetObject("CustomerSupportServiceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CustomerSupportServiceToolStripMenuItem.Name = "CustomerSupportServiceToolStripMenuItem"
        Me.CustomerSupportServiceToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.CustomerSupportServiceToolStripMenuItem.Text = "Customer Support && Service"
        '
        'UmbrellaKnowledgeCenterToolStripMenuItem
        '
        Me.UmbrellaKnowledgeCenterToolStripMenuItem.Image = CType(resources.GetObject("UmbrellaKnowledgeCenterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UmbrellaKnowledgeCenterToolStripMenuItem.Name = "UmbrellaKnowledgeCenterToolStripMenuItem"
        Me.UmbrellaKnowledgeCenterToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.UmbrellaKnowledgeCenterToolStripMenuItem.Text = "Umbrella Knowledge Center"
        '
        'LiveChatAssistanceToolStripMenuItem
        '
        Me.LiveChatAssistanceToolStripMenuItem.Image = CType(resources.GetObject("LiveChatAssistanceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LiveChatAssistanceToolStripMenuItem.Name = "LiveChatAssistanceToolStripMenuItem"
        Me.LiveChatAssistanceToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.LiveChatAssistanceToolStripMenuItem.Text = "Live Chat Assistance"
        '
        'EmailProductSupportToolStripMenuItem
        '
        Me.EmailProductSupportToolStripMenuItem.Image = CType(resources.GetObject("EmailProductSupportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmailProductSupportToolStripMenuItem.Name = "EmailProductSupportToolStripMenuItem"
        Me.EmailProductSupportToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.EmailProductSupportToolStripMenuItem.Text = "Email Product Support"
        '
        'EmailCustomerServiceToolStripMenuItem
        '
        Me.EmailCustomerServiceToolStripMenuItem.Image = CType(resources.GetObject("EmailCustomerServiceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmailCustomerServiceToolStripMenuItem.Name = "EmailCustomerServiceToolStripMenuItem"
        Me.EmailCustomerServiceToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.EmailCustomerServiceToolStripMenuItem.Text = "Email Customer Service"
        '
        'ProductSupportToolStripMenuItem
        '
        Me.ProductSupportToolStripMenuItem.Image = CType(resources.GetObject("ProductSupportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProductSupportToolStripMenuItem.Name = "ProductSupportToolStripMenuItem"
        Me.ProductSupportToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ProductSupportToolStripMenuItem.Text = "Product Support"
        '
        'StartupConfigurationToolStripMenuItem
        '
        Me.StartupConfigurationToolStripMenuItem.Image = CType(resources.GetObject("StartupConfigurationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StartupConfigurationToolStripMenuItem.Name = "StartupConfigurationToolStripMenuItem"
        Me.StartupConfigurationToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.StartupConfigurationToolStripMenuItem.Text = "Startup Configuration"
        '
        'ClearUserLicensesToolStripMenuItem
        '
        Me.ClearUserLicensesToolStripMenuItem.Image = CType(resources.GetObject("ClearUserLicensesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClearUserLicensesToolStripMenuItem.Name = "ClearUserLicensesToolStripMenuItem"
        Me.ClearUserLicensesToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ClearUserLicensesToolStripMenuItem.Text = "Clear User Licences"
        '
        'UmbrellaOnTheWebToolStripMenuItem1
        '
        Me.UmbrellaOnTheWebToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductFeedbackToolStripMenuItem, Me.ClearUserLicensesToolStripMenuItem1})
        Me.UmbrellaOnTheWebToolStripMenuItem1.Image = CType(resources.GetObject("UmbrellaOnTheWebToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.UmbrellaOnTheWebToolStripMenuItem1.Name = "UmbrellaOnTheWebToolStripMenuItem1"
        Me.UmbrellaOnTheWebToolStripMenuItem1.Size = New System.Drawing.Size(224, 22)
        Me.UmbrellaOnTheWebToolStripMenuItem1.Text = "Umbrella On The Web"
        '
        'ProductFeedbackToolStripMenuItem
        '
        Me.ProductFeedbackToolStripMenuItem.Image = CType(resources.GetObject("ProductFeedbackToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProductFeedbackToolStripMenuItem.Name = "ProductFeedbackToolStripMenuItem"
        Me.ProductFeedbackToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ProductFeedbackToolStripMenuItem.Text = "Product Feedback"
        '
        'ClearUserLicensesToolStripMenuItem1
        '
        Me.ClearUserLicensesToolStripMenuItem1.Image = CType(resources.GetObject("ClearUserLicensesToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ClearUserLicensesToolStripMenuItem1.Name = "ClearUserLicensesToolStripMenuItem1"
        Me.ClearUserLicensesToolStripMenuItem1.Size = New System.Drawing.Size(175, 22)
        Me.ClearUserLicensesToolStripMenuItem1.Text = "Clear User Licences"
        '
        'UmbrellaRegistrationToolStripMenuItem
        '
        Me.UmbrellaRegistrationToolStripMenuItem.Image = CType(resources.GetObject("UmbrellaRegistrationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UmbrellaRegistrationToolStripMenuItem.Name = "UmbrellaRegistrationToolStripMenuItem"
        Me.UmbrellaRegistrationToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.UmbrellaRegistrationToolStripMenuItem.Text = "Umbrella Registration"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(221, 6)
        '
        'LicenseAgreementToolStripMenuItem
        '
        Me.LicenseAgreementToolStripMenuItem.Image = CType(resources.GetObject("LicenseAgreementToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LicenseAgreementToolStripMenuItem.Name = "LicenseAgreementToolStripMenuItem"
        Me.LicenseAgreementToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.LicenseAgreementToolStripMenuItem.Text = "Licence Agreement"
        '
        'AboutUmbrellaToolStripMenuItem
        '
        Me.AboutUmbrellaToolStripMenuItem.Image = Global.Umbrella.My.Resources.Resources.about_help
        Me.AboutUmbrellaToolStripMenuItem.Name = "AboutUmbrellaToolStripMenuItem"
        Me.AboutUmbrellaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.AboutUmbrellaToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.AboutUmbrellaToolStripMenuItem.Text = "About Umbrella"
        '
        'EStatusStrip1
        '
        Me.EStatusStrip1.Appearance = Me.EAppearanceControl1
        Me.EStatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.EStatusStrip1.Location = New System.Drawing.Point(0, 595)
        Me.EStatusStrip1.Name = "EStatusStrip1"
        Me.EStatusStrip1.Size = New System.Drawing.Size(1008, 22)
        Me.EStatusStrip1.TabIndex = 2
        Me.EStatusStrip1.Text = "EStatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripStatusLabel1.Image = Global.Umbrella.My.Resources.Resources.Umbrella_icon
        Me.ToolStripStatusLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(98, 17)
        Me.ToolStripStatusLabel1.Text = "Umbrella: "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(410, 17)
        Me.ToolStripStatusLabel2.Text = "A complete institution management system is powered by: "
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.Teal
        Me.ToolStripStatusLabel3.Image = Global.Umbrella.My.Resources.Resources.favicon
        Me.ToolStripStatusLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripStatusLabel3.IsLink = True
        Me.ToolStripStatusLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.ToolStripStatusLabel3.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(124, 17)
        Me.ToolStripStatusLabel3.Text = "ESAR Infotech"
        '
        'frmMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 617)
        Me.Controls.Add(Me.EStatusStrip1)
        Me.Controls.Add(Me.EMenuStrip1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.Custom
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.EMenuStrip1
        Me.Name = "frmMainForm"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Umbrella ~"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.EMenuStrip1.ResumeLayout(False)
        Me.EMenuStrip1.PerformLayout()
        Me.EStatusStrip1.ResumeLayout(False)
        Me.EStatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EMenuStrip1 As Strips.eMenuStrip
    Friend WithEvents EAppearanceControl1 As Appearance.eAppearanceControl
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EStatusStrip1 As Strips.eStatusStrip
    Friend WithEvents NewInstituteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenInstituteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenPreviouslyOpenedInstituteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenInstituteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseInstituteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImportYourDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportYourDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BackupInstitutionDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreInstitutionDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SynchronizeInstitutionDataThroughTheWebToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindTransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GlobalSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DefineInternetConnectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StartWithLastOpenedInstituteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyECreativeAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CustomerSupportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UmbrellaOnTheWebToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProductComparisonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndustrySpecificSolutionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MidSizedBusinessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MoreProductsServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UmbrellaWebTransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UmbrellaSyncWizardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UmbrellaHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UmbrellaGuidedTourToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserManualsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserGuideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GettingStartedWithCrystalReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowMeHowToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MakeABackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenASavedTransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstallOnlineUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePeriodToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeCloseFinancialPeriodYearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeSystemDateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllDemosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CustomerSupportServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UmbrellaKnowledgeCenterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LiveChatAssistanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmailProductSupportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmailCustomerServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductSupportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartupConfigurationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearUserLicensesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UmbrellaOnTheWebToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductFeedbackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearUserLicensesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UmbrellaRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LicenseAgreementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutUmbrellaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ObsolescenceInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
