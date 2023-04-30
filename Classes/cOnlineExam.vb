#Region "Class cOnlineExam..."
Public Class cOnlineExam
#Region "Declarations..."
    Public AddRecordOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal examid As String, ByVal examdate As String, ByVal examtime As String, ByVal examduration As Integer, ByVal stuid As String, ByVal name As String, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal totalqsn As Integer, ByVal totalqsnanswered As Integer, ByVal rightanswered As Integer)
        Try
            cmd.CommandText = "insert into OnlineExam(InsID,InsName,Period,SystemDate,examid,examdate,examtime,examduration,stuid,name,course,class,roll,totalqsn,totalqsnanswered,rightanswered) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & examid & "','" & examdate & "','" & examtime & "'," & examduration & ",'" & stuid & "','" & name & "','" & course & "','" & clas & "','" & roll & "'," & totalqsn & "," & totalqsnanswered & "," & rightanswered & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            AddRecordOk = True
        Catch ex As Exception
            AddRecordOk = False
            dr.Close()
        End Try
    End Sub
#End Region
End Class
#End Region