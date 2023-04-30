#Region "Class cExamFees..."
Public Class cExamFees
#Region "Declarations..."
    Public AddExamFeeOk As Boolean = False
    Public UpdateExamFeeOk As Boolean = False
    Public DeleteExamFeeOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal transactionid As String, ByVal dates As String, ByVal month As Integer, ByVal year As Integer, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String, ByVal time As String, ByVal payvia As String, ByVal exam As String, ByVal examfee As Decimal, ByVal laters As Decimal, ByVal libraryrs As Decimal, ByVal discountcharge As Decimal, ByVal discount As Decimal, ByVal totalamt As Decimal, ByVal pay As Decimal, ByVal remaining As Decimal, ByVal paid As String)
        Try
            cmd.CommandText = "insert into ExamFee(InsID,InsName,Period,SystemDate,transactionid,date,month,year,course,class,roll,regno,name,time,payvia,exam,examfee,laters,libraryrs,discountcharge,discount,totalamt,pay,remaining,paid) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & transactionid & "','" & dates & "'," & month & "," & year & ",'" & course & "','" & clas & "','" & roll & "','" & regno & "','" & name & "','" & time & "','" & payvia & "','" & exam & "'," & examfee & "," & laters & "," & libraryrs & "," & discountcharge & "," & discount & "," & totalamt & "," & pay & "," & remaining & ",'" & paid & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set examfeesid=examfeesid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddExamFeeOk = True
        Catch ex As Exception
            dr.Close()
            AddExamFeeOk = False
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal transactionid As String, ByVal dates As String, ByVal month As Integer, ByVal year As Integer, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String, ByVal time As String, ByVal payvia As String, ByVal exam As String, ByVal examfee As Decimal, ByVal laters As Decimal, ByVal libraryrs As Decimal, ByVal discountcharge As Decimal, ByVal discount As Decimal, ByVal totalamt As Decimal, ByVal pay As Decimal, ByVal remaining As Decimal, ByVal paid As String)
        Try
            cmd.CommandText = "update ExamFee set SystemDate='" & SystemDate & "',payvia='" & payvia & "',exam='" & exam & "',examfee=" & examfee & ",laters=" & laters & ",libraryrs=" & libraryrs & ",discountcharge=" & discountcharge & ",discount=" & discount & ",totalamt=" & totalamt & ",pay=" & pay & ",remaining=" & remaining & ",paid='" & paid & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and date='" & dates & "' and month=" & month & " and year=" & year & " and course='" & course & "' and class='" & clas & "' and roll='" & roll & "' and regno='" & regno & "' and name='" & name & "' and time='" & time & "' and transactionid='" & transactionid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateExamFeeOk = True
        Catch ex As Exception
            dr.Close()
            UpdateExamFeeOk = False
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal transactionid As String, ByVal dates As String, ByVal month As Integer, ByVal year As Integer, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String)
        Try
            cmd.CommandText = "delete from ExamFee where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and date='" & dates & "' and month=" & month & " and year=" & year & " and course='" & course & "' and class='" & clas & "' and roll='" & roll & "' and regno='" & regno & "' and name='" & name & "' and transactionid='" & transactionid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteExamFeeOk = True
        Catch ex As Exception
            dr.Close()
            DeleteExamFeeOk = False
        End Try
    End Sub
#End Region
End Class
#End Region