#Region "Class frmMainSelect..."
Public Class frmMainSelect
#Region "Methods..."
    Private Sub ControlSetBound()
        btninstitute.SetBounds(25, 34, 266, 50)
        btnlibrary.SetBounds(25, 90, 266, 50)
        btnpayroll.SetBounds(25, 146, 266, 50)
        btnclose.SetBounds(238, 215, 1, 1)
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmMainSelect_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim frm As New frmOpenInstitute()
        frm.MdiParent = Me.MdiParent
        frm.Show()
    End Sub

    Private Sub frmMainSelect_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
        For Each frmApproval As Form In Me.MdiChildren
            frmApproval.Close()
        Next
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnclose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btninstitute_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btninstitute.ClickButtonArea
        openselectedform = "Institute"
        Dim frm As New frmOpeningInstitute()
        frm.MdiParent = Me.MdiParent
        Me.Hide()
        frm.Show()
    End Sub

    Private Sub btnlibrary_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnlibrary.ClickButtonArea
        openselectedform = "Library"
        Dim frm As New frmOpeningInstitute()
        frm.MdiParent = Me.MdiParent
        Me.Hide()
        frm.Show()
    End Sub

    Private Sub btnpayroll_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnpayroll.ClickButtonArea
        openselectedform = "Payroll"
        Dim frm As New frmOpeningInstitute()
        frm.MdiParent = Me.MdiParent
        Me.Hide()
        frm.Show()
    End Sub

    Private Sub btninstitute_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btninstitute.KeyDown
        If e.KeyCode = Keys.Down Then
            btnlibrary.Focus()
        End If
    End Sub

    Private Sub btnlibrary_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnlibrary.KeyDown
        If e.KeyCode = Keys.Down Then
            btnpayroll.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            btninstitute.Focus()
        End If
    End Sub

    Private Sub btnpayroll_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnpayroll.KeyDown
        If e.KeyCode = Keys.Up Then
            btnlibrary.Focus()
        End If
    End Sub
#End Region
End Class
#End Region