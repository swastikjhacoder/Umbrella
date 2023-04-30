#Region "Class cDiscount..."
Public Class cDiscount
#Region "Declarations..."
    Public AddDiscountOk As Boolean = False
    Public UpdateDiscountOk As Boolean = False
    Public DeleteDiscountOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal transactionid As String, ByVal dates As String, ByVal month As Integer, ByVal year As Integer, ByVal appliedfor As String, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String, ByVal totalamt As Decimal, ByVal discountcharge As Decimal, ByVal discount As Decimal, ByVal pay As Decimal, ByVal payvia As String, ByVal authentication As String, ByVal remarks As String, ByVal account As String)
        Try
            cmd.CommandText = "insert into Discount(InsID,InsName,Period,SystemDate,transactionid,date,month,year,appliedfor,class,roll,regno,name,totalamt,discountcharge,discount,pay,payvia,authentication,remarks,account) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & transactionid & "','" & dates & "'," & month & "," & year & ",'" & appliedfor & "','" & clas & "','" & roll & "','" & regno & "','" & name & "'," & totalamt & "," & discountcharge & "," & discount & "," & pay & ",'" & payvia & "','" & authentication & "','" & remarks & "','" & account & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            Dim description As String = "Discount"
            Dim type As String = "Expenditure"
            cmd.CommandText = "insert into IncomeExpenditure(InsID,InsName,Period,SystemDate,transactionid,descriptions,type,amount,class,roll,regno,name,month,year,account) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & transactionid & "','" & description & "','" & type & "'," & discount & ",'" & clas & "','" & roll & "','" & regno & "','" & name & "'," & month & "," & year & ",'" & account & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set discountid=discountid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddDiscountOk = True
        Catch ex As Exception
            dr.Close()
            AddDiscountOk = False
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal transactionid As String, ByVal dates As String, ByVal month As Integer, ByVal year As Integer, ByVal appliedfor As String, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String, ByVal totalamt As Decimal, ByVal discountcharge As Decimal, ByVal discount As Decimal, ByVal pay As Decimal, ByVal payvia As String, ByVal authentication As String, ByVal remarks As String, ByVal account As String)
        Try
            cmd.CommandText = "update Discount set SystemDate='" & SystemDate & "',appliedfor='" & appliedfor & "',class='" & clas & "',roll='" & roll & "',totalamt=" & totalamt & ",discountcharge=" & discountcharge & ",discount=" & discount & ",pay=" & pay & ",payvia='" & payvia & "',authentication='" & authentication & "',remarks='" & remarks & "',account='" & account & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and date='" & dates & "' and month=" & month & " and year=" & year & " and regno='" & regno & "' and name='" & name & "' and transactionid='" & transactionid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            Dim description As String = "Discount"
            Dim type As String = "Expenditure"
            cmd.CommandText = "update IncomeExpenditure set SystemDate='" & SystemDate & "',amount=" & discount & ",regno='" & regno & "',name='" & name & "',month=" & month & ",year=" & year & ",account='" & account & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and transactionid='" & transactionid & "' and descriptions='" & description & "' and type='" & type & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateDiscountOk = True
        Catch ex As Exception
            dr.Close()
            UpdateDiscountOk = False
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal transactionid As String, ByVal dates As String, ByVal month As Integer, ByVal year As Integer, ByVal regno As String, ByVal name As String, ByVal clas As String, ByVal roll As String)
        Try
            cmd.CommandText = "delete from Discount where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and date='" & dates & "' and month=" & month & " and year=" & year & " and regno='" & regno & "' and name='" & name & "' and transactionid='" & transactionid & "' and class='" & clas & "' and roll='" & roll & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            Dim description As String = "Discount"
            Dim type As String = "Expenditure"
            cmd.CommandText = "delete from IncomeExpenditure where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and transactionid='" & transactionid & "' and descriptions='" & description & "' and type='" & type & "' and class='" & clas & "' and roll='" & roll & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteDiscountOk = True
        Catch ex As Exception
            dr.Close()
            DeleteDiscountOk = False
        End Try
    End Sub
#End Region
End Class
#End Region