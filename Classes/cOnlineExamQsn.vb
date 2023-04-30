#Region "Class cOnlineExamQsn..."
Public Class cOnlineExamQsn
#Region "Declarations..."
    Public AddRecordOk As Boolean = False
    Public DeleteRecordOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal examid As String, ByVal examdate As String, ByVal examtime As String, ByVal examduration As Integer, ByVal qsn As String, ByVal ans1 As String, ByVal ans2 As String, ByVal ans3 As String, ByVal ans4 As String, ByVal rightans As String)
        Try
            cmd.CommandText = "insert into OnlineExamQsn(InsID,InsName,Period,SystemDate,examid,examdate,examtime,examduration,qsn,ans1,ans2,ans3,ans4,rightans) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & examid & "','" & examdate & "','" & examtime & "'," & examduration & ",'" & qsn & "','" & ans1 & "','" & ans2 & "','" & ans3 & "','" & ans4 & "','" & rightans & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            AddRecordOk = True
        Catch ex As Exception
            AddRecordOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal examid As String, ByVal examdate As String)
        Try
            cmd.CommandText = "delete from OnlineExamQsn where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and examid='" & examid & "' and examdate='" & examdate & "'"
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