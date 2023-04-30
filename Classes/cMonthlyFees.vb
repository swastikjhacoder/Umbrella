#Region "Class cMonthlyFees..."
Public Class cMonthlyFees
#Region "Declarations..."
    Public AddMonthlyOk As Boolean = False
    Public UpdateMonthlyOk As Boolean = False
    Public DeleteMonthlyOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal transactionid As String, ByVal dates As String, ByVal month As Integer, ByVal year As Integer, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String, ByVal time As String, ByVal monthlyrs As Decimal, ByVal othersrs As Decimal, ByVal laters As Decimal, ByVal libraryrs As Decimal, ByVal discountcharge As Decimal, ByVal discount As Decimal, ByVal totalamt As Decimal, ByVal paidamt As Decimal, ByVal payvia As String, ByVal remainingamt As Decimal, ByVal paid As String)
        Try
            cmd.CommandText = "insert into MonthlyFees(InsID,InsName,Period,SystemDate,transactionid,date,month,year,course,class,roll,regno,name,time,monthlyrs,othersrs,laters,libraryrs,discountcharge,discount,totalamt,paidamt,payvia,remainingamt,paid) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & transactionid & "','" & dates & "'," & month & "," & year & ",'" & course & "','" & clas & "','" & roll & "','" & regno & "','" & name & "','" & time & "'," & monthlyrs & "," & othersrs & "," & laters & "," & libraryrs & "," & discountcharge & "," & discount & "," & totalamt & "," & paidamt & ",'" & payvia & "'," & remainingamt & ",'" & paid & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set monthlyid=monthlyid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddMonthlyOk = True
        Catch ex As Exception
            AddMonthlyOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal transactionid As String, ByVal dates As String, ByVal month As Integer, ByVal year As Integer, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String, ByVal time As String, ByVal monthlyrs As Decimal, ByVal othersrs As Decimal, ByVal laters As Decimal, ByVal libraryrs As Decimal, ByVal discountcharge As Decimal, ByVal discount As Decimal, ByVal totalamt As Decimal, ByVal paidamt As Decimal, ByVal payvia As String, ByVal remainingamt As Decimal, ByVal paid As String)
        Try
            cmd.CommandText = "update MonthlyFees set SystemDate='" & SystemDate & "',monthlyrs=" & monthlyrs & ",othersrs=" & othersrs & ",laters=" & laters & ",libraryrs=" & libraryrs & ",discountcharge=" & discountcharge & ",discount=" & discount & ",totalamt=" & totalamt & ",paidamt=" & paidamt & ",payvia='" & payvia & "',remainingamt=" & remainingamt & ",paid='" & paid & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and date='" & dates & "' and month=" & month & " and year=" & year & " and course='" & course & "' and class='" & clas & "' and roll='" & roll & "' and regno='" & regno & "' and name='" & name & "' and time='" & time & "' and transactionid='" & transactionid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateMonthlyOk = True
        Catch ex As Exception
            UpdateMonthlyOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal transactionid As String, ByVal dates As String, ByVal month As Integer, ByVal year As Integer, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String)
        Try
            cmd.CommandText = "delete from MonthlyFees where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and date='" & dates & "' and month=" & month & " and year=" & year & " and course='" & course & "' and class='" & clas & "' and roll='" & roll & "' and regno='" & regno & "' and name='" & name & "' and transactionid='" & transactionid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteMonthlyOk = True
        Catch ex As Exception
            DeleteMonthlyOk = False
            dr.Close()
        End Try
    End Sub
#End Region
End Class
#End Region