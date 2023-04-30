#Region "Class cNotice..."
Public Class cNotice
#Region "Declarations..."
    Public AddOk As Boolean = False
    Public UpdateOk As Boolean = False
    Public DeleteOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal noticeid As String, ByVal noticefor As String, ByVal noticedate As String, ByVal subject As String, ByVal notice As String)
        Try
            cmd.CommandText = "insert into Notice(InsID,InsName,Period,SystemDate,noticeid,noticefor,noticedate,subject,notice) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & SystemDate & "','" & noticeid & "','" & noticefor & "','" & noticedate & "','" & subject & "','" & notice & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set noticeid=noticeid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddOk = True
        Catch ex As Exception
            dr.Close()
            AddOk = False
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal noticeid As String, ByVal noticefor As String, ByVal noticedate As String, ByVal subject As String, ByVal notice As String)
        Try
            cmd.CommandText = "update Notice set SystemDate='" & SystemDate & "',noticefor='" & noticefor & "',noticedate='" & noticedate & "',subject='" & subject & "',notice='" & notice & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & periodd & "' and noticeid='" & noticeid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateOk = True
        Catch ex As Exception
            dr.Close()
            UpdateOk = False
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal noticeid As String)
        Try
            cmd.CommandText = "delete from Notice where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & periodd & "' and noticeid='" & noticeid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteOk = True
        Catch ex As Exception
            dr.Close()
            DeleteOk = False
        End Try
    End Sub
#End Region
End Class
#End Region
