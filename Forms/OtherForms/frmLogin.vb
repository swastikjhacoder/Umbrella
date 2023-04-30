#Region "Class frmLogin..."
Public Class frmLogin
#Region "Methods..."
    Private Sub ControlSetBound()
        ELabel1.SetBounds(0, 0, 277, 21)
        btnclose.SetBounds(210, 161, 70, 32)
        btnhelp.SetBounds(277, 0, 21, 21)
        btnlogin.SetBounds(108, 161, 70, 32)
        PictureBox1.SetBounds(39, 92, 46, 48)
        btnstudentlogin.SetBounds(108, 48, 167, 32)
        txtpassword.SetBounds(108, 119, 167, 21)
        txtusername.SetBounds(108, 92, 167, 21)
    End Sub

    Private Sub Login()
        Try
            cmd.CommandText = "select * from Users where userid='" & txtusername.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            USuserno = dr("userno").ToString()
            USuserrole = dr("userrole").ToString()
            USuserid = dr("userid").ToString()
            USuserpasswd = dr("userpasswd").ToString()
            USuseraccess = dr("useraccess").ToString()
            USemployeeinfo = dr("employeeinfo").ToString()
            USemployeecard = dr("employeecard").ToString()
            USattendances = dr("attendances").ToString()
            USidcard = dr("idcard").ToString()
            USnotices = dr("notices").ToString()
            USstudentcontrol = dr("studentcontrol").ToString()
            USbackuprestore = dr("backuprestore").ToString()
            USimportexport = dr("importexport").ToString()
            USstudentinfo = dr("studentinfo").ToString()
            USstudentcard = dr("studentcard").ToString()
            USpreadmission = dr("preadmission").ToString()
            USadmission = dr("admission").ToString()
            USregistration = dr("registration").ToString()
            USfeesterms = dr("feesterms").ToString()
            USbankinginfo = dr("bankinginfo").ToString()
            USfeescollection = dr("feescollection").ToString()
            USdiscount = dr("discount").ToString()
            USincomeexpenditure = dr("incomeexpenditure").ToString()
            USaccounting = dr("accounting").ToString()
            USfinancialloan = dr("financialloan").ToString()
            UScoursesubject = dr("coursesubject").ToString()
            USexamination = dr("examination").ToString()
            USprogressreport = dr("progressreport").ToString()
            USmarksheet = dr("marksheet").ToString()
            USmessenger = dr("messenger").ToString()
            USglobalaccess = dr("globalaccess").ToString()
            USalumni = dr("alumni").ToString()
            UScertificates = dr("certificates").ToString()
            USpurchaseorder = dr("purchaseorder").ToString()
            USinventory = dr("inventory").ToString()
            USsalesinvoice = dr("salesinvoice").ToString()
            USgames = dr("games").ToString()
            USbookrecords = dr("bookrecords").ToString()
            UScharges = dr("charges").ToString()
            USissuebooks = dr("issuebooks").ToString()
            USreturnbooks = dr("returnbooks").ToString()
            USpayrollsystem = dr("payrollsystem").ToString()
            USpayrollperiodic = dr("payrollperiodic").ToString()
            USpayrollpf = dr("payrollpf").ToString()
            USInstituteDefault = dr("institutedefault").ToString()
            USLibraryDefault = dr("librarydefault").ToString()
            USPayrollDefault = dr("payrolldefault").ToString()
            USRevenue = dr("revenueyeartodate").ToString()
            USYearEnd = dr("yearend").ToString()
            dr.Close()
            If txtpassword.Text = USuserpasswd And txtusername.Text = USuserid Then
                If MainTask = "Create" Then
                    If USuserrole = "Administrator" Then
                        Dim frm As New frmCreateInstitute()
                        frm.MdiParent = Me.MdiParent
                        Me.Hide()
                        frm.Show()
                    Else
                        Dim result As DialogResult = MessageBox.Show("You are not an authorized user to create new Institute." + Environment.NewLine + "Please contact with the Administrator...", "Umbrella - Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result = DialogResult.OK Then
                            txtusername.Focus()
                        End If
                    End If
                Else
                    Dim frm As New frmMainSelect()
                    frm.MdiParent = Me.MdiParent
                    Me.Hide()
                    frm.Show()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Username/ Password doesn't match" + Environment.NewLine + "Please enter correct Username & Password.", "Umbrella - Username/ Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtusername.Focus()
                End If
            End If
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmLogin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim frm As New frmMainTask()
        frm.MdiParent = Me.MdiParent
        frm.Show()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
        For Each frmApproval As Form In Me.MdiChildren
            frmApproval.Close()
        Next
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnlogin_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnlogin.ClickButtonArea
        Login()
    End Sub

    Private Sub btnclose_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnclose.ClickButtonArea
        Me.Close()
    End Sub

    Private Sub btnstudentlogin_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnstudentlogin.ClickButtonArea
        Dim frm As New frmLoginStudent()
        frm.MdiParent = Me.MdiParent
        Me.Hide()
        frm.Show()
    End Sub

    Private Sub btnhelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhelp.Click

    End Sub
#End Region
#Region "Attributes..."
    Private Sub txtusername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtusername.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtpassword.Text <> "" And txtusername.Text <> "" Then
                Login()
            Else
                txtpassword.Focus()
            End If
        ElseIf e.KeyCode = Keys.Down Then
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtpassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtpassword.Text <> "" And txtusername.Text <> "" Then
                Login()
            End If
        ElseIf e.KeyCode = Keys.Up Then
            txtusername.Focus()
        End If
    End Sub
#End Region
End Class
#End Region