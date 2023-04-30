#Region "Class cProgressReport..."
Public Class cProgressReport
#Region "Declarations..."
    Public AddRecordOk As Boolean = False
    Public UpdateRecordOk As Boolean = False
    Public DeleteRecordOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal progressid As String, ByVal stuid As String, ByVal attendance As String, ByVal preparation As String, ByVal homework As String, ByVal takerisk As String, ByVal goals As String, ByVal plans As String, ByVal respect As String, ByVal cooperation As String, ByVal interest As String, ByVal motivation As String, ByVal outcomes As String, ByVal quality As String, ByVal keyterms As String, ByVal newconcept As String)
        Try
            cmd.CommandText = "insert into ProgressReport(InsID,InsName,Period,SystemDate,progressid,stuid,attendance,preparation,homework,takerisk,goals,plans,respect,cooperation,interest,motivation,outcomes,quality,keyterms,newconcept) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & progressid & "','" & stuid & "','" & attendance & "','" & preparation & "','" & homework & "','" & takerisk & "','" & goals & "','" & plans & "','" & respect & "','" & cooperation & "','" & interest & "','" & motivation & "','" & outcomes & "','" & quality & "','" & keyterms & "','" & newconcept & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set progressid=progressid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddRecordOk = True
        Catch ex As Exception
            dr.Close()
            AddRecordOk = False
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal progressid As String, ByVal stuid As String, ByVal attendance As String, ByVal preparation As String, ByVal homework As String, ByVal takerisk As String, ByVal goals As String, ByVal plans As String, ByVal respect As String, ByVal cooperation As String, ByVal interest As String, ByVal motivation As String, ByVal outcomes As String, ByVal quality As String, ByVal keyterms As String, ByVal newconcept As String)
        Try
            cmd.CommandText = "update ProgressReport set SystemDate='" & SystemDate & "',stuid='" & stuid & "',attendance='" & attendance & "',preparation='" & preparation & "',homework='" & homework & "',takerisk='" & takerisk & "',goals='" & goals & "',plans='" & plans & "',respect='" & respect & "',cooperation='" & cooperation & "',interest='" & interest & "',motivation='" & motivation & "',outcomes='" & outcomes & "',quality='" & quality & "',keyterms='" & keyterms & "',newconcept='" & newconcept & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and progressid='" & progressid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateRecordOk = True
        Catch ex As Exception
            dr.Close()
            UpdateRecordOk = False
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal progressid As String)
        Try
            cmd.CommandText = "delete from ProgressReport where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and progressid='" & progressid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteRecordOk = True
        Catch ex As Exception
            dr.Close()
            DeleteRecordOk = False
        End Try
    End Sub
#End Region
End Class
#End Region