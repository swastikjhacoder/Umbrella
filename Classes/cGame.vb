#Region "Class cGame..."
Public Class cGame
#Region "Declarations..."
    Public AddRecordOk As Boolean = False
    Public UpdateRecordOk As Boolean = False
    Public DeleteRecordOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal gameid As String, ByVal category As String, ByVal gamefor As String, ByVal department As String, ByVal dte As String, ByVal time As String, ByVal gamename As String, ByVal gameplace As String, ByVal expense As Decimal, ByVal account As String)
        Try
            cmd.CommandText = "insert into Game(InsID,InsName,Period,SystemDate,gameid,category,gamefor,department,date,time,gamename,gameplace,expense,account) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & gameid & "','" & category & "','" & gamefor & "','" & department & "','" & dte & "','" & time & "','" & gamename & "','" & gameplace & "'," & expense & ",'" & account & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set gameid=gameid+1 where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddRecordOk = True
        Catch ex As Exception
            AddRecordOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal gameid As String, ByVal category As String, ByVal gamefor As String, ByVal department As String, ByVal dte As String, ByVal time As String, ByVal gamename As String, ByVal gameplace As String, ByVal expense As Decimal, ByVal account As String)
        Try
            cmd.CommandText = "update Game set SystemDate='" & SystemDate & "',category='" & category & "',gamefor='" & gamefor & "',department='" & department & "',date='" & dte & "',time='" & time & "',gamename='" & gamename & "',gameplace='" & gameplace & "',expense=" & expense & ",account='" & account & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and gameid='" & gameid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateRecordOk = True
        Catch ex As Exception
            UpdateRecordOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal gameid As String)
        Try
            cmd.CommandText = "delete from Game where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and gameid='" & gameid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteRecordOk = True
        Catch ex As Exception
            DeleteRecordOk = False
            dr.Close()
        End Try
    End Sub
#End Region
End Class
#End Region
