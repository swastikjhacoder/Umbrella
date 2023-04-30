#Region "Class frmMainTask..."
Public Class frmMainTask
#Region "Declarations..."
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
#End Region
#Region "Form Events..."
    Private Sub frmMainTask_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each frmApproval As Form In Me.MdiChildren
            frmApproval.Close()
        Next
        btncreate.SetBounds(10, 80, 278, 47)
        btnopen.SetBounds(10, 21, 278, 47)
        CheckUser()
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnopen_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnopen.ClickButtonArea
        MainTask = "Open"
        Dim frm As New frmOpenInstitute()
        frm.MdiParent = Me.MdiParent
        Me.Close()
        frm.Show()
    End Sub

    Private Sub btncreate_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btncreate.ClickButtonArea
        MainTask = "Create"
        If userexist = True Then
            Dim frm As New frmLogin()
            frm.MdiParent = Me.MdiParent
            Me.Close()
            frm.Show()
        Else
            Dim frm As New frmCreateInstitute()
            frm.MdiParent = Me.MdiParent
            Me.Close()
            frm.Show()
        End If
    End Sub
#End Region
End Class
#End Region