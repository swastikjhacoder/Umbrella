#Region "Class frmUserSecurityWizard..."
Public Class frmUserSecurity
#Region "WithEvents..."
    Private WithEvents childA As frmNewAdministrator
    Private WithEvents childB As frmNewUser
#End Region
#Region "Declarations..."
    Dim LanguageTexts_Next As String = "&Next"
    Dim LanguageTexts_Finish As String = "&Finish"
    Dim LanguageTexts_Back As String = "&Back"
    Private userexist As Boolean = False
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(35, 234, 107, 13)
        Label10.SetBounds(37, 105, 350, 26)
        Label11.SetBounds(37, 51, 532, 26)
        Label2.SetBounds(35, 174, 110, 13)
        Label3.SetBounds(35, 234, 107, 13)
        Label4.SetBounds(35, 174, 110, 13)
        Label5.SetBounds(37, 268, 229, 13)
        Label7.SetBounds(57, 193, 207, 13)
        Label8.SetBounds(57, 121, 492, 26)
        Label9.SetBounds(57, 93, 429, 13)

        rbtnsetupuser.SetBounds(96, 230, 200, 17)
        btnedituser.SetBounds(393, 256, 100, 33)
        btnsetupuser.SetBounds(393, 105, 100, 33)

        dgviewusers.SetBounds(40, 144, 381, 106)
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
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub AdministratorValueUpdated(ByVal sender As Object, ByVal e As ValueUpdatedEventArgs) Handles childA.ValueUpdated
        LoadUsers()
    End Sub

    Private Sub UserValueUpdated(ByVal sender As Object, ByVal e As ValueUpdatedEventArgs) Handles childB.ValueUpdated
        LoadUsers()
    End Sub

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
#End Region
#Region "Form Events..."
    Private Sub frmUserSecurityWizard_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
        btnnext.Text = LanguageTexts_Next
        btnback.Text = LanguageTexts_Back
        btnback.Enabled = False
        ETabControlEx1.HideTabs = True
        LoadUsers()
        CheckUser()
        If userexist = True Then
            If USuserrole = "Administrator" Then
                btnedituser.Enabled = True
                btnsetupuser.Enabled = True
            Else
                btnedituser.Enabled = False
                btnsetupuser.Enabled = False
            End If
        End If
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

    Private Sub btnsetupuser_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsetupuser.ClickButtonArea
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
                Me.childB = New frmNewUser()
                AddHandler childB.ValueUpdated, AddressOf UserValueUpdated

                Me.childB.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                Me.childB.WindowState = FormWindowState.Normal
                Me.childB.StartPosition = FormStartPosition.CenterScreen
                Me.childB.ControlBox = True
                Me.childB.ShowDialog()
            Else
                Me.childA = New frmNewAdministrator()
                AddHandler childA.ValueUpdated, AddressOf AdministratorValueUpdated

                Me.childA.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                Me.childA.WindowState = FormWindowState.Normal
                Me.childA.StartPosition = FormStartPosition.CenterScreen
                Me.childA.ControlBox = True
                Me.childA.ShowDialog()
            End If
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub btnedituser_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnedituser.ClickButtonArea
        Dim frm As New frmUserControl()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.Show()
    End Sub
#End Region
End Class
#End Region