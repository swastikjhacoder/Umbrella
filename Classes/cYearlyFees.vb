#Region "Class cYearlyFees..."
Public Class cYearlyFees
#Region "Declarations..."
    Public AddYearlyFeesOk As Boolean = False
    Public UpdateYearlyFeesOk As Boolean = False
    Public DeleteYearlyFeesOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal token As String, ByVal dates As String, ByVal month As String, ByVal year As Integer, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String, ByVal time As String, ByVal payvia As String, ByVal yearlyfee As Decimal, ByVal laters As Decimal, ByVal otherrs As Decimal, ByVal libraryrs As Decimal, ByVal discountcharge As Decimal, ByVal discount As Decimal, ByVal totalamt As Decimal, ByVal pay As Decimal, ByVal remaining As Decimal, ByVal paid As String)
        Try
            cmd.CommandText = "insert into YearlyFees(InsID,InsName,Period,SystemDate,token,date,month,year,course,class,roll,regno,name,time,payvia,yearlyfee,laters,otherrs,libraryrs,discountcharge,discount,totalamt,pay,remaining,paid) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & token & "','" & dates & "','" & month & "'," & year & ",'" & course & "','" & clas & "','" & roll & "','" & regno & "','" & name & "','" & time & "','" & payvia & "'," & yearlyfee & "," & laters & "," & otherrs & "," & libraryrs & "," & discountcharge & "," & discount & "," & totalamt & "," & pay & "," & remaining & ",'" & paid & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set yearlyid=yearlyid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddYearlyFeesOk = True
        Catch ex As Exception
            AddYearlyFeesOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal token As String, ByVal dates As String, ByVal month As String, ByVal year As Integer, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String, ByVal time As String, ByVal payvia As String, ByVal yearlyfee As Decimal, ByVal laters As Decimal, ByVal otherrs As Decimal, ByVal libraryrs As Decimal, ByVal discountcharge As Decimal, ByVal discount As Decimal, ByVal totalamt As Decimal, ByVal pay As Decimal, ByVal remaining As Decimal, ByVal paid As String)
        Try
            cmd.CommandText = "update YearlyFees set SystemDate='" & SystemDate & "',payvia='" & payvia & "',yearlyfee=" & yearlyfee & ",laters=" & laters & ",otherrs=" & otherrs & ",libraryrs=" & libraryrs & ",discountcharge=" & discountcharge & ",discount=" & discount & ",totalamt=" & totalamt & ",pay=" & pay & ",remaining=" & remaining & ",paid='" & paid & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and token='" & token & "' and date='" & dates & "' and month='" & month & "' and year=" & year & " and course='" & course & "' and class='" & clas & "' and roll='" & roll & "' and regno='" & regno & "' and name='" & name & "' and time='" & time & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateYearlyFeesOk = True
        Catch ex As Exception
            UpdateYearlyFeesOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal token As String, ByVal dates As String, ByVal month As String, ByVal year As Integer, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String, ByVal time As String)
        Try
            cmd.CommandText = "delete from YearlyFees where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and token='" & token & "' and date='" & dates & "' and month='" & month & "' and year=" & year & " and course='" & course & "' and class='" & clas & "' and roll='" & roll & "' and regno='" & regno & "' and name='" & name & "' and time='" & time & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteYearlyFeesOk = True
        Catch ex As Exception
            DeleteYearlyFeesOk = False
            dr.Close()
        End Try
    End Sub
#End Region
End Class
#End Region