#Region "Class cPFRateIndividual..."
Public Class cPFRateIndividual
#Region "Declarations..."
    Public AddRecordOk As Boolean = False
    Public UpdateRecordOk As Boolean = False
    Public DeleteRecordOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal year As Integer, ByVal regno As String, ByVal name As String, ByVal rate As Decimal, ByVal amount As Decimal)
        Try
            cmd.CommandText = "insert into PFRateIndividual(InsID,InsName,Period,year,regno,name,rate,amount) values ('" & InsID & "','" & InsName & "','" & Periodd & "'," & year & ",'" & regno & "','" & name & "'," & rate & "," & amount & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            AddRecordOk = True
        Catch ex As Exception
            AddRecordOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal year As Integer, ByVal regno As String, ByVal name As String, ByVal rate As Decimal, ByVal amount As Decimal)
        Try
            cmd.CommandText = "update PFRateIndividual set rate=" & rate & ",amount=" & amount & " where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and year=" & year & " and regno='" & regno & "' and name='" & name & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateRecordOk = True
        Catch ex As Exception
            UpdateRecordOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal year As Integer, ByVal regno As String, ByVal name As String)
        Try
            cmd.CommandText = "delete from PFRateIndividual where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and year=" & year & " and regno='" & regno & "' and name='" & name & "'"
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