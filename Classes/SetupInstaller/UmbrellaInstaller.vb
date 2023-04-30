Imports System.IO
Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Windows
Imports System.ComponentModel
Imports System.Configuration.Install

Public Class UmbrellaInstaller
    Inherits System.Configuration.Install.Installer
    Private masterConnection As New SqlConnection()

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Function GetSql(ByVal Name As String) As String
        Try
            Dim Asm As Assembly = Assembly.GetExecutingAssembly()
            Dim strm As Stream = Asm.GetManifestResourceStream(Convert.ToString(Asm.GetName().Name + ".") & Name)
            Dim reader As New StreamReader(strm)
            Return reader.ReadToEnd()
        Catch ex As Exception
            MessageBox.Show("In GetSQL: " + ex.Message)
            Throw ex
        End Try
    End Function

    Private Sub ExecuteSql(ByVal DatabaseName As String, ByVal Sql As String)
        Dim Command As New System.Data.SqlClient.SqlCommand(Sql, masterConnection)
        masterConnection.ConnectionString = "data Source=.;Initial Catalog=Master;Persist Security Info=True;User ID=sa;Password=123"
        Command.Connection.Open()
        Command.Connection.ChangeDatabase(DatabaseName)
        Try
            Command.ExecuteNonQuery()
        Finally
            Command.Connection.Close()
        End Try
    End Sub

    Protected Sub AddDBTable(ByVal strDBName As String)
        Try
            ExecuteSql("master", Convert.ToString("CREATE DATABASE ") & strDBName)
            ExecuteSql(strDBName, GetSql("Tables.txt"))
        Catch ex As Exception
            MessageBox.Show("In exception handler: " + ex.Message)
            Throw ex
        End Try
    End Sub


    Public Overrides Sub Install(ByVal stateSaver As System.Collections.IDictionary)
        MyBase.Install(stateSaver)
        AddDBTable("Umbrella")
    End Sub

    <System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)> _
    Public Overrides Sub Uninstall(ByVal savedState As IDictionary)
        MyBase.Uninstall(savedState)
        ExecuteSql("master", "DROP DATABASE Umbrella")
    End Sub
End Class
