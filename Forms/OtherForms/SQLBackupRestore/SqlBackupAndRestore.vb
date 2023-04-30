Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class SqlBackupAndRestore
    ' Should be more configurable (Instance)
    Const ConnectionString As String = "data Source=.;Initial Catalog=Umbrella;Persist Security Info=True;User ID=sa;Password=123;Integrated Security=SSPI;"

    Private InfoContext As String

    Public Sub BackupDatabase(ByVal databaseName As String, ByVal backupFilename As String)
        Try
            InfoContext = "BACKUP " & databaseName
            Using connection As New SqlConnection(ConnectionString)
                connection.FireInfoMessageEventOnUserErrors = True
                AddHandler connection.InfoMessage, New SqlInfoMessageEventHandler(AddressOf InfoMessage)
                connection.Open()

                Dim backupCommand As New SqlCommand()
                backupCommand.Connection = connection

                backupCommand.CommandText = "SET NOCOUNT ON;"
                backupCommand.ExecuteNonQuery()

                backupCommand.CommandText = String.Format("BACKUP DATABASE {0} TO DISK = '{1}' WITH INIT, NOFORMAT, STATS=10;", databaseName, backupFilename)
                backupCommand.CommandTimeout = 0
                backupCommand.ExecuteNonQuery()
            End Using
        Catch ex As SqlException
            Console.WriteLine("Backup failed - {0}: {1}", ex.Number, ex.Message)
            Throw
        End Try
    End Sub

    Public Sub RestoreDatabase(ByVal databaseName As String, ByVal backupFilename As String, Optional ByVal asSingleUser As Boolean = False, Optional ByVal replaceDatabase As Boolean = False)
        Try
            InfoContext = "RESTORE " & databaseName
            Using connection As New SqlConnection(ConnectionString)
                connection.FireInfoMessageEventOnUserErrors = True
                AddHandler connection.InfoMessage, New SqlInfoMessageEventHandler(AddressOf InfoMessage)
                connection.Open()

                Dim restoreCommand As New SqlCommand()
                restoreCommand.Connection = connection

                If asSingleUser Then
                    restoreCommand.CommandText = String.Format("ALTER DATABASE {0} SET SINGLE_USER WITH ROLLBACK IMMEDIATE;", databaseName)
                    restoreCommand.ExecuteNonQuery()
                End If

                Dim options As String = "STATS=10"
                If replaceDatabase Then
                    options = "REPLACE, " & options
                End If
                restoreCommand.CommandText = String.Format("RESTORE DATABASE {0} FROM DISK = N'{1}' WITH {2};", databaseName, backupFilename, options)
                restoreCommand.CommandTimeout = 0
                restoreCommand.ExecuteNonQuery()
            End Using
        Catch ex As SqlException
            Console.WriteLine("Restore failed - {0}: {1}", ex.Number, ex.Message)
            Throw
        End Try
    End Sub

    Sub InfoMessage(ByVal sender As Object, ByVal e As SqlInfoMessageEventArgs)
        Console.WriteLine("{0}: {1}", InfoContext, e.Message)
    End Sub
End Class