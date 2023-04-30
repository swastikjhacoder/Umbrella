#Region "Class cPayEmployee..."
Public Class cPayEmployee
#Region "Declarations..."
    Public AddRecordOk As Boolean = False
    Public DeleteRecordOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal payslipno As String, ByVal salarymonth As String, ByVal salaryyear As Integer, ByVal salarydate As String, ByVal regno As String, ByVal name As String, ByVal designation As String, ByVal payinfo As String, ByVal getda As Decimal, ByVal getarrier As Decimal, ByVal gethra As Decimal, ByVal tax As Decimal, ByVal deduct As Decimal, ByVal gain As Decimal, ByVal newbasic As Decimal, ByVal netpay As Decimal, ByVal stopincrement As String, ByVal paywithheld As String)
        Try
            cmd.CommandText = "insert into PayEmployee(InsID,InsName,Period,payslipno,salarymonth,salaryyear,salarydate,regno,name,designation,payinfo,getda,getarrier,gethra,tax,deduct,gain,newbasic,netpay,stopincrement,paywithheld) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & payslipno & "','" & salarymonth & "'," & salaryyear & ",'" & salarydate & "','" & regno & "','" & name & "','" & designation & "','" & payinfo & "'," & getda & "," & getarrier & "," & gethra & "," & tax & "," & deduct & "," & gain & "," & newbasic & "," & netpay & ",'" & stopincrement & "','" & paywithheld & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            AddRecordOk = True
        Catch ex As Exception
            AddRecordOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal payslipno As String)
        Try
            cmd.CommandText = "delete from PayEmployee where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and payslipno='" & payslipno & "'"
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