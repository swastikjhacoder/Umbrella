#Region "Class cStudentControl..."
Public Class cStudentControl
#Region "Declarations..."
    Public AddRecordOk As Boolean = False
    Public UpdateRecordOk As Boolean = False
    Public DeleteRecordOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal controlid As String, ByVal regno As String, ByVal name As String, ByVal course As String, ByVal examination As String, ByVal scored As Decimal, ByVal passfail As String, ByVal credits As Decimal, ByVal reference As String, ByVal remarks As String, ByVal alsoupdate As String, ByVal newcouse As String, ByVal newclassint As Integer, ByVal newclassstring As String, ByVal newclass As String, ByVal newroll As String, ByVal newtime As String, ByVal newtuition As String)
        Try
            cmd.CommandText = "insert into StudentControl(InsID,InsName,Period,SystemDate,controlid,regno,name,course,examination,scored,passfail,credits,reference,remarks,alsoupdate,newcouse,newclassint,newclassstring,newclass,newroll,newtime,newtuition) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & controlid & "','" & regno & "','" & name & "','" & course & "','" & examination & "'," & scored & ",'" & passfail & "'," & credits & ",'" & reference & "','" & remarks & "','" & alsoupdate & "','" & newcouse & "'," & newclassint & ",'" & newclassstring & "','" & newclass & "','" & newroll & "','" & newtime & "','" & newtuition & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set controlid=controlid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddRecordOk = True
        Catch ex As Exception
            dr.Close()
            AddRecordOk = False
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal controlid As String, ByVal regno As String, ByVal name As String, ByVal course As String)
        Try
            cmd.CommandText = "delete from StudentControl where controlid='" & controlid & "' and InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and regno='" & regno & "' and name='" & name & "' and course='" & course & "'"
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
