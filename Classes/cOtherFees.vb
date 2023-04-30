#Region "Class cOtherFees..."
Public Class cOtherFees
#Region "Declarations..."
    Public AddOtherFeesOk As Boolean = False
    Public UpdateOtherFeesOk As Boolean = False
    Public DeleteOtherFeesOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal transactionid As String, ByVal dates As String, ByVal month As Integer, ByVal year As Integer, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String, ByVal time As String, ByVal payvia As String, ByVal reason As String, ByVal otherrs As Decimal, ByVal discountcharge As Decimal, ByVal discount As Decimal, ByVal totalamt As Decimal, ByVal pay As Decimal, ByVal remaining As Decimal, ByVal paid As String)
        Try
            cmd.CommandText = "insert into OtherFees(InsID,InsName,Period,SystemDate,transactionid,date,month,year,course,class,roll,regno,name,time,payvia,reason,otherrs,discountcharge,discount,totalamt,pay,remaining,paid) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & transactionid & "','" & dates & "'," & month & "," & year & ",'" & course & "','" & clas & "','" & roll & "','" & regno & "','" & name & "','" & time & "','" & payvia & "','" & reason & "'," & otherrs & "," & discountcharge & "," & discount & "," & totalamt & "," & pay & "," & remaining & ",'" & paid & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set othersid=othersid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddOtherFeesOk = True
        Catch ex As Exception
            dr.Close()
            AddOtherFeesOk = False
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal transactionid As String, ByVal dates As String, ByVal month As Integer, ByVal year As Integer, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String, ByVal time As String, ByVal payvia As String, ByVal reason As String, ByVal otherrs As Decimal, ByVal discountcharge As Decimal, ByVal discount As Decimal, ByVal totalamt As Decimal, ByVal pay As Decimal, ByVal remaining As Decimal, ByVal paid As String)
        Try
            cmd.CommandText = "update OtherFees set SystemDate='" & SystemDate & "',payvia='" & payvia & "',reason='" & reason & "',otherrs=" & otherrs & ",discountcharge=" & discountcharge & ",discount=" & discount & ",totalamt=" & totalamt & ",pay=" & pay & ",remaining=" & remaining & ",paid='" & paid & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and date='" & dates & "' and month=" & month & " and year=" & year & " and course='" & course & "' and class='" & clas & "' and roll='" & roll & "' and regno='" & regno & "' and name='" & name & "' and time='" & time & "' and transactionid='" & transactionid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateOtherFeesOk = True
        Catch ex As Exception
            dr.Close()
            UpdateOtherFeesOk = False
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal transactionid As String, ByVal dates As String, ByVal month As Integer, ByVal year As Integer, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String)
        Try
            cmd.CommandText = "delete from OtherFees where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and date='" & dates & "' and month=" & month & " and year=" & year & " and course='" & course & "' and class='" & clas & "' and roll='" & roll & "' and regno='" & regno & "' and name='" & name & "' and transactionid='" & transactionid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            Dim description As String = "Other Fees"
            Dim type As String = "Income"
            cmd.CommandText = "delete from IncomeExpenditure where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and transactionid='" & transactionid & "' and descriptions='" & description & "' and type='" & type & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteOtherFeesOk = True
        Catch ex As Exception
            dr.Close()
            DeleteOtherFeesOk = False
        End Try
    End Sub
#End Region
End Class
#End Region