#Region "Class cLibraryFees..."
Public Class cLibraryFees
#Region "Declarations..."
    Public AddLibraryFeeOk As Boolean = False
    Public UpdateLibraryFeeOk As Boolean = False
    Public DeleteLibraryFeeOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal transactionid As String, ByVal dates As String, ByVal month As Integer, ByVal year As Integer, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String, ByVal time As String, ByVal payvia As String, ByVal libraryfee As Decimal, ByVal laters As Decimal, ByVal discountcharge As Decimal, ByVal discount As Decimal, ByVal totalamt As Decimal, ByVal pay As Decimal, ByVal remaining As Decimal, ByVal paid As String)
        Try
            cmd.CommandText = "insert into libraryFees(InsID,InsName,Period,SystemDate,transactionid,date,month,year,course,class,roll,regno,name,time,payvia,libraryfee,laters,discountcharge,discount,totalamt,pay,remaining,paid) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & transactionid & "','" & dates & "'," & month & "," & year & ",'" & course & "','" & clas & "','" & roll & "','" & regno & "','" & name & "','" & time & "','" & payvia & "'," & libraryfee & "," & laters & "," & discountcharge & "," & discount & "," & totalamt & "," & pay & "," & remaining & ",'" & paid & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set libraryid=libraryid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddLibraryFeeOk = True
        Catch ex As Exception
            dr.Close()
            AddLibraryFeeOk = False
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal transactionid As String, ByVal dates As String, ByVal month As Integer, ByVal year As Integer, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String, ByVal time As String, ByVal payvia As String, ByVal libraryfee As Decimal, ByVal laters As Decimal, ByVal discountcharge As Decimal, ByVal discount As Decimal, ByVal totalamt As Decimal, ByVal pay As Decimal, ByVal remaining As Decimal, ByVal paid As String)
        Try
            cmd.CommandText = "update libraryFees set SystemDate='" & SystemDate & "',payvia='" & payvia & "',libraryfee=" & libraryfee & ",laters=" & laters & ",discountcharge=" & discountcharge & ",discount=" & discount & ",totalamt=" & totalamt & ",pay=" & pay & ",remaining=" & remaining & ",paid='" & paid & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and date='" & dates & "' and month=" & month & " and year=" & year & " and course='" & course & "' and class='" & clas & "' and roll='" & roll & "' and regno='" & regno & "' and name='" & name & "' and transactionid='" & transactionid & "' and time='" & time & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateLibraryFeeOk = True
        Catch ex As Exception
            dr.Close()
            UpdateLibraryFeeOk = False
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal transactionid As String, ByVal dates As String, ByVal month As Integer, ByVal year As Integer, ByVal course As String, ByVal clas As String, ByVal roll As String, ByVal regno As String, ByVal name As String)
        Try
            cmd.CommandText = "delete from libraryFees where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and date='" & dates & "' and month=" & month & " and year=" & year & " and course='" & course & "' and class='" & clas & "' and roll='" & roll & "' and regno='" & regno & "' and name='" & name & "' and transactionid='" & transactionid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            Dim description As String = "Library Fees"
            Dim type As String = "Income"
            cmd.CommandText = "delete from IncomeExpenditure where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and transactionid='" & transactionid & "' and descriptions='" & description & "' and type='" & type & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteLibraryFeeOk = True
        Catch ex As Exception
            dr.Close()
            DeleteLibraryFeeOk = False
        End Try
    End Sub
#End Region
End Class
#End Region