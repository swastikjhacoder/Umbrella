#Region "Imports..."
Imports System.IO
Imports System.Net
#End Region
#Region "Class frmInstitutionCreated..."
Public Class frmInstitutionCreated
#Region "Methods..."
    Public Shared Function GetIPAddress() As String
        strHostName = System.Net.Dns.GetHostName()
        strIPAddress = System.Net.Dns.GetHostEntry(strHostName).AddressList(0).ToString()
        Dim oAddr As System.Net.IPAddress = Dns.GetHostEntry(My.Computer.Name).AddressList(0)
        Return oAddr.ToString()
    End Function
#End Region
#Region "Form Events..."
    Private Sub frmCompanyCreated_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim frm As New frmMainSelect()
        frm.MdiParent = Me.MdiParent
        frm.Show()
    End Sub

    Private Sub frmCompanyCreated_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Settings.IPAddress = GetIPAddress()
        Label3.SetBounds(6, 30, 376, 26)
        Label5.SetBounds(50, 69, 288, 65)
        LinkLabel1.SetBounds(22, 150, 344, 13)
        btnok.SetBounds(177, 214, 55, 25)
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnok_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnok.ClickButtonArea
        Me.Close()
    End Sub
#End Region
End Class
#End Region