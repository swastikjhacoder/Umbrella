#Region "Class cIDCard..."
Public Class cIDCard
#Region "Declarations..."
    Public AddOk As Boolean = False
    Public UpdateOk As Boolean = False
    Public DeleteOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal idserial As String, ByVal idfor As String, ByVal dates As String, ByVal regno As String, ByVal name As String, ByVal dob As String, ByVal sex As String, ByVal coursedesig As String, ByVal address As String)
        Try
            cmd.CommandText = "insert into IDCard(InsID,InsName,Period,SystemDate,idserial,idfor,date,regno,name,dob,sex,coursedesig,address) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & SystemDate & "','" & idserial & "','" & idfor & "','" & dates & "','" & regno & "','" & name & "','" & dob & "','" & sex & "','" & coursedesig & "','" & address & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set idserial=idserial+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddOk = True
        Catch ex As Exception
            dr.Close()
            AddOk = False
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal idserial As String, ByVal idfor As String, ByVal dates As String, ByVal regno As String, ByVal name As String, ByVal dob As String, ByVal sex As String, ByVal coursedesig As String, ByVal address As String)
        Try
            cmd.CommandText = "update IDCard set SystemDate='" & SystemDate & "',idfor='" & idfor & "',date='" & dates & "',regno='" & regno & "',name='" & name & "',dob='" & dob & "',sex='" & sex & "',coursedesig='" & coursedesig & "',address='" & address & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & periodd & "' and idserial='" & idserial & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateOk = True
        Catch ex As Exception
            dr.Close()
            UpdateOk = False
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal idserial As String)
        Try
            cmd.CommandText = "delete from IDCard where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & periodd & "' and idserial='" & idserial & "'"
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