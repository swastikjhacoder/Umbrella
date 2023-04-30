#Region "Class cPayScale..."
Public Class cPayScale
#Region "Declarations..."
    Public AddOk As Boolean = False
    Public UpdateOk As Boolean = False
    Public DeleteOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal pbname As String, ByVal pblower As Decimal, ByVal pbupper As Decimal, ByVal pbgrade As Decimal, ByVal pbbasic As Decimal, ByVal payscale As String)
        Try
            cmd.CommandText = "insert into PayScale(InsID,InsName,period,pbname,pblower,pbupper,pbgrade,pbbasic,payscale) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & pbname & "'," & pblower & "," & pbupper & "," & pbgrade & "," & pbbasic & ",'" & payscale & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set pbid=pbid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddOk = True
        Catch ex As Exception
            AddOk = False
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal pbname As String, ByVal pblower As Decimal, ByVal pbupper As Decimal, ByVal pbgrade As Decimal, ByVal pbbasic As Decimal, ByVal payscale As String)
        Try
            cmd.CommandText = "update PayScale set pblower=" & pblower & ",pbupper=" & pbupper & ",pbgrade=" & pbgrade & ",pbbasic=" & pbbasic & ",payscale='" & payscale & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and period='" & periodd & "' and pbname='" & pbname & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateOk = True
        Catch ex As Exception
            UpdateOk = False
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal pbname As String)
        Try
            cmd.CommandText = "delete from PayScale where InsID='" & InsID & "' and InsName='" & InsName & "' and period='" & periodd & "' and pbname='" & pbname & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteOk = True
        Catch ex As Exception
            DeleteOk = False
        End Try
    End Sub
#End Region
End Class
#End Region