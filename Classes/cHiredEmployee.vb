#Region "Class cHiredEmployee..."
Public Class cHiredEmployee
#Region "Declarations..."
    Public AddRecordOk As Boolean = False
    Public UpdateRecordOk As Boolean = False
    Public DeleteRecordOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal namefirst As String, ByVal namemiddle As String, ByVal namelast As String, ByVal houseno As String, ByVal address As String, ByVal city As String, ByVal district As String, ByVal state As String, ByVal pin As String, ByVal country As String, ByVal phone As String, ByVal fax As String, ByVal dob As String, ByVal email As String, ByVal category As String, ByVal department As String, ByVal designation As String, ByVal married As String, ByVal sex As String, ByVal handicapped As String, ByVal presentposition As String, ByVal retirementdate As String, ByVal fulladdress As String, ByVal payinfo As String, ByVal pay As Decimal, ByVal joiningdate As String)
        Try
            Dim name As String = namefirst + " " + namemiddle + " " + namelast
            cmd.CommandText = "update HiredEmployee set SystemDate='" & SystemDate & "',namefirst='" & namefirst & "',namemiddle='" & namemiddle & "',namelast='" & namelast & "',name='" & name & "',houseno='" & houseno & "',address='" & address & "',city='" & city & "',district='" & district & "',state='" & state & "',pin='" & pin & "',country='" & country & "',phone='" & phone & "',fax='" & fax & "',dob='" & dob & "',email='" & email & "',category='" & category & "',department='" & department & "',designation='" & designation & "',married='" & married & "',sex='" & sex & "',handicapped='" & handicapped & "',presentposition='" & presentposition & "',retirementdate='" & retirementdate & "',fulladdress='" & fulladdress & "',payinfo='" & payinfo & "',pay=" & pay & ",joiningdate='" & joiningdate & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and empid='" & empid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set hiredempid=hiredempid+1 where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddRecordOk = True
        Catch ex As Exception
            AddRecordOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal namefirst As String, ByVal namemiddle As String, ByVal namelast As String, ByVal houseno As String, ByVal address As String, ByVal city As String, ByVal district As String, ByVal state As String, ByVal pin As String, ByVal country As String, ByVal phone As String, ByVal fax As String, ByVal dob As String, ByVal email As String, ByVal category As String, ByVal department As String, ByVal designation As String, ByVal married As String, ByVal sex As String, ByVal handicapped As String, ByVal presentposition As String, ByVal retirementdate As String, ByVal fulladdress As String, ByVal payinfo As String, ByVal pay As Decimal, ByVal joiningdate As String)
        Try
            Dim name As String = namefirst + " " + namemiddle + " " + namelast
            cmd.CommandText = "update HiredEmployee set SystemDate='" & SystemDate & "',namefirst='" & namefirst & "',namemiddle='" & namemiddle & "',namelast='" & namelast & "',name='" & name & "',houseno='" & houseno & "',address='" & address & "',city='" & city & "',district='" & district & "',state='" & state & "',pin='" & pin & "',country='" & country & "',phone='" & phone & "',fax='" & fax & "',dob='" & dob & "',email='" & email & "',category='" & category & "',department='" & department & "',designation='" & designation & "',married='" & married & "',sex='" & sex & "',handicapped='" & handicapped & "',presentposition='" & presentposition & "',retirementdate='" & retirementdate & "',fulladdress='" & fulladdress & "',payinfo='" & payinfo & "',pay=" & pay & ",joiningdate='" & joiningdate & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and empid='" & empid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateRecordOk = True
        Catch ex As Exception
            UpdateRecordOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal empid As String)
        Try
            cmd.CommandText = "delete from HiredEmployee where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and empid='" & empid & "'"
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