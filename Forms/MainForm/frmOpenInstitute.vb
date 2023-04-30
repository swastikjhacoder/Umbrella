#Region "Imports..."
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
#End Region
#Region "Class OpenInstitute..."
Public Class frmOpenInstitute
#Region "Declarations..."
    Private userexist As Boolean = False
    Private lstcomp As String = ""
#End Region
#Region "Methods..."
    Private Sub CheckUser()
        Try
            cmd.CommandText = "select * from Users where InsID='" & My.Settings.LastOpenedInstituteID & "' and insname='" & dgviewinstitute.CurrentRow.Cells(0).Value.ToString() & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                userexist = True
                Dim frm As New frmLogin()
                frm.MdiParent = Me.MdiParent
                Me.Hide()
                frm.Show()
            Else
                userexist = False
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
            userexist = False
        End Try
    End Sub

    Private Sub LoaddataGrid()
        Try
            Dim indx As Integer = 0
            dgviewinstitute.Rows.Clear()
            cmd.CommandText = "select distinct(InsName),InsID from Institute"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewinstitute.Rows.Add()
                dgviewinstitute.Rows(indx).Cells(0).Tag = dr("InsID").ToString()
                dgviewinstitute.Rows(indx).Cells(0).Value = dr("InsName").ToString()
                indx = indx + 1
            End While
            dr.Close()
            dgviewinstitute.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Attributes..."
    Private Sub dgviewinstitute_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgviewinstitute.CellClick
        Dim i As Integer
        i = dgviewinstitute.CurrentRow.Index
        lblselected.Text = "Selected Institute: "
        lblselected.Text += dgviewinstitute.Rows(i).Cells(0).Value.ToString()
        My.Settings.LastOpenedInstitute = dgviewinstitute.Rows(i).Cells(0).Value.ToString()
        My.Settings.Save()
    End Sub

    Private Sub dgviewinstitute_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgviewinstitute.DoubleClick
        Dim i As Integer
        i = dgviewinstitute.CurrentRow.Index
        My.Settings.LastOpenedInstitute = dgviewinstitute.Rows(i).Cells(0).Value.ToString()
        My.Settings.LastOpenedInstituteID = dgviewinstitute.Rows(i).Cells(0).Tag.ToString()
        My.Settings.Save()
        lblselected.Text = "Selected Institute: "
        lblselected.Text += dgviewinstitute.Rows(i).Cells(0).Value.ToString()
        CheckUser()
        If userexist = False Then
            Dim frm As New frmMainSelect()
            frm.MdiParent = Me.MdiParent
            Me.Hide()
            frm.Show()
        End If
    End Sub

    Private Sub dgviewinstitute_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgviewinstitute.KeyDown
        If dgviewinstitute.Rows.Count > 0 Then
            If (e.KeyCode) = Keys.Enter Then
                Dim i As Integer
                i = dgviewinstitute.CurrentRow.Index
                My.Settings.LastOpenedInstitute = dgviewinstitute.Rows(i).Cells(0).Value.ToString()
                My.Settings.LastOpenedInstituteID = dgviewinstitute.Rows(i).Cells(0).Tag.ToString()
                My.Settings.Save()
                CheckUser()
                If userexist = False Then
                    Dim frm As New frmMainSelect()
                    frm.MdiParent = Me.MdiParent
                    Me.Hide()
                    frm.Show()
                End If
            End If
        End If
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmOpenInstitute_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For Each frmApproval As Form In Me.MdiChildren
            frmApproval.Close()
        Next
        Dim frm As New frmMainTask()
        frm.MdiParent = Me.MdiParent
        frm.Show()
    End Sub

    Private Sub frmOpenInstitute_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each frmApproval As Form In Me.MdiChildren
            frmApproval.Close()
        Next
        LoaddataGrid()
        lblselected.Text = "Selected Institute: "
        Dim x As Integer = 0
        lblselected.Text += My.Settings.LastOpenedInstitute
        dgviewinstitute.SetBounds(10, 10, 199, 139)
        lblselected.SetBounds(10, 161, 289, 59)
        btnclose.SetBounds(230, 63, 69, 25)
        btnhelp.SetBounds(230, 94, 69, 25)
        btnopen.SetBounds(230, 32, 69, 25)
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnopen_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnopen.ClickButtonArea
        Dim i As Integer
        i = dgviewinstitute.CurrentRow.Index
        My.Settings.LastOpenedInstitute = dgviewinstitute.Rows(i).Cells(0).Value.ToString()
        My.Settings.LastOpenedInstituteID = dgviewinstitute.Rows(i).Cells(0).Tag.ToString()
        CheckUser()
        If userexist = False Then
            Dim frm As New frmMainSelect()
            frm.MdiParent = Me.MdiParent
            Me.Hide()
            frm.Show()
        End If
    End Sub

    Private Sub btnclose_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnclose.ClickButtonArea
        Me.Close()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region