#Region "Class cPFAdvanceWithdrawal..."
Public Class cPFAdvanceWithdrawal
#Region "Declarations..."
    Public AddRecordOk As Boolean = False
    Public UpdateRecordOk As Boolean = False
    Public DeleteRecordOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal month As String, ByVal regno As String, ByVal name As String, ByVal openingbalance As Decimal, ByVal options As String, ByVal amount As Decimal, ByVal particulars As String)
        Try
            cmd.CommandText = "insert into PFAdvanceWithdrawal(InsID,InsName,Period,month,regno,name,openingbalance,options,amount,particulars) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & month & "','" & regno & "','" & name & "'," & openingbalance & ",'" & options & "'," & amount & ",'" & particulars & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            AddRecordOk = True
        Catch ex As Exception
            AddRecordOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal month As String, ByVal regno As String, ByVal name As String, ByVal openingbalance As Decimal, ByVal options As String, ByVal amount As Decimal, ByVal particulars As String)
        Try
            cmd.CommandText = "update PFAdvanceWithdrawal set options='" & options & "',amount=" & amount & ",particulars='" & particulars & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and month='" & month & "' and regno='" & regno & "' and name='" & name & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateRecordOk = True
        Catch ex As Exception
            UpdateRecordOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal month As String, ByVal regno As String, ByVal name As String)
        Try
            cmd.CommandText = "delete from PFAdvanceWithdrawal where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and month='" & month & "' and regno='" & regno & "' and name='" & name & "'"
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