#Region "Imports..."
Imports System.IO
#End Region
#Region "Class frmOpeningInstitute..."
Public Class frmOpeningInstitute
#Region "Declarations..."
    Dim c1 As Integer
    Dim p1 As Integer = 1
#End Region
#Region "Methods..."
    Private Sub VisibleMenus()
        frmMainForm.ToolStripSeparator2.Visible = True
        frmMainForm.ToolStripSeparator3.Visible = True
        frmMainForm.ToolStripSeparator4.Visible = True
        frmMainForm.CloseInstituteToolStripMenuItem.Visible = True
        frmMainForm.ImportYourDataToolStripMenuItem.Visible = True
        frmMainForm.ExportYourDataToolStripMenuItem.Visible = True
        frmMainForm.BackupInstitutionDataToolStripMenuItem.Visible = True
        frmMainForm.RestoreInstitutionDataToolStripMenuItem.Visible = True
        frmMainForm.SynchronizeInstitutionDataThroughTheWebToolStripMenuItem.Visible = True
        frmMainForm.EditToolStripMenuItem.Visible = True
    End Sub
#End Region
#Region "Timer Tick..."
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If c1 = XpProgressBar1.PositionMin Then
            p1 = 1
        End If
        c1 += p1
        XpProgressBar1.Text = c1.ToString() + " %"
        XpProgressBar1.Position = c1
        If c1 = XpProgressBar1.PositionMax Then
            Me.Timer1.Enabled = False
            Me.Close()
        End If
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmOpeningInstitute_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMainForm.Enabled = True
        VisibleMenus()
        If openselectedform = "Institute" Then
            Dim frm As New frmInstitutionMainForm()
            frm.MdiParent = Me.MdiParent
            frm.Show()
        ElseIf openselectedform = "Library" Then
            Dim frm As New frmLibraryMainForm()
            frm.MdiParent = Me.MdiParent
            frm.Show()
        ElseIf openselectedform = "Payroll" Then
            Dim frm As New frmPayrollMainForm()
            frm.MdiParent = Me.MdiParent
            frm.Show()
        End If
        frmMainForm.Text = "Umbrella ~ "
        frmMainForm.Text += My.Settings.LastOpenedInstitute
    End Sub

    Private Sub frmOpeningInstitute_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        frmMainForm.Enabled = False
        c1 = XpProgressBar1.Position
        lblinstitute.Text = My.Settings.LastOpenedInstitute
        openselectedinstitute = My.Settings.LastOpenedInstitute
        If openselectedform = "Institute" Then
            EGroupBox1.GroupTitle = "Opening ~ Institution Management System..."
        ElseIf openselectedform = "Library" Then
            EGroupBox1.GroupTitle = "Opening ~ Library Management System..."
        ElseIf openselectedform = "Payroll" Then
            EGroupBox1.GroupTitle = "Opening ~ Payroll Management System..."
        End If
        Try
            cmd.CommandText = "select FinancialPeriod from AccountingPeriod where InsName='" & openselectedinstitute & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                period = dr("FinancialPeriod").ToString()
            End While
            dr.Close()
            My.Settings.Period = period
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
End Class
#End Region