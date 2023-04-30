Imports System
Imports System.data
Imports System.data.SqlClient

Module mGlobalConnection

    Public conn As New SqlConnection
    Public cmd As New SqlCommand
    Public dr As SqldataReader

    Public Sub Connect()
        Try
            conn.ConnectionString = "data Source=.;Initial Catalog=Umbrella;Persist Security Info=True;User ID=sa;Password=123"
            cmd.Connection = conn
            conn.Open()
        Catch ex As Exception

        End Try
    End Sub


End Module
