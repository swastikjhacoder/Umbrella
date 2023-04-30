#Region "Class cAssignment..."
Public Class cAssignment
#Region "Declarations..."
    Public AddOk As Boolean = False
    Public UpdateOk As Boolean = False
    Public DeleteOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal assignmentid As String, ByVal dates As String, ByVal course As String, ByVal subject As String, ByVal assignment As String)
        Try
            cmd.CommandText = "insert into Assignment(InsID,InsName,Period,SystemDate,assignmentid,date,course,subject,assignment) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & SystemDate & "','" & assignmentid & "','" & dates & "','" & course & "','" & subject & "','" & assignment & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set assignmentid=assignmentid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddOk = True
        Catch ex As Exception
            AddOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal assignmentid As String, ByVal dates As String, ByVal course As String, ByVal subject As String, ByVal assignment As String)
        Try
            cmd.CommandText = "update Assignment set SystemDate='" & SystemDate & "',date='" & dates & "',course='" & course & "',subject='" & subject & "',assignment='" & assignment & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & periodd & "' and assignmentid='" & assignmentid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateOk = True
        Catch ex As Exception
            UpdateOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal assignmentid As String)
        Try
            cmd.CommandText = "delete from Assignment where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & periodd & "' and assignmentid='" & assignmentid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteOk = True
        Catch ex As Exception
            DeleteOk = False
            dr.Close()
        End Try
    End Sub
#End Region
End Class
#End Region