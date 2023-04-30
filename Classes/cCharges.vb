#Region "Class cCharges..."
Public Class cCharges
#Region "Declarations..."
    Public AddChargeOk As Boolean = False
    Public UpdateChargeOk As Boolean = False
    Public DeleteChargeOk As Boolean = False
    Public AddLibraryChargesOk As Boolean = False
    Public UpdateLibraryChargesOk As Boolean = False
    Public DeleteLibraryChargesOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal course As String, ByVal referencebooks As String, ByVal finerate As Decimal, ByVal reserveperiod As Integer, ByVal maxbooks As Integer, ByVal booksreturndays As Integer, ByVal maxjournal As Integer, ByVal journalreturndays As Integer, ByVal maxcompbook As Integer, ByVal compbookreturndays As Integer, ByVal lockerperiod As Integer, ByVal lockerfees As Decimal, ByVal losingcardcharge As Decimal, ByVal lockerfine As Decimal, ByVal losingjournalcharge As Decimal, ByVal idcardcharge As Decimal)
        Try
            cmd.CommandText = "insert into BookCharges(InsID,InsName,Period,SystemDate,course,referencebooks,finerate,reserveperiod,maxbooks,booksreturndays,maxjournal,journalreturndays,maxcompbook,compbookreturndays,lockerperiod,lockerfees,losingcardcharge,lockerfine,losingjournalcharge,idcardcharge) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & course & "','" & referencebooks & "'," & finerate & "," & reserveperiod & "," & maxbooks & "," & booksreturndays & "," & maxjournal & "," & journalreturndays & "," & maxcompbook & "," & compbookreturndays & "," & lockerperiod & "," & lockerfees & "," & losingcardcharge & "," & lockerfine & "," & losingjournalcharge & "," & idcardcharge & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            AddChargeOk = True
        Catch ex As Exception
            dr.Close()
            AddChargeOk = False
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal course As String, ByVal referencebooks As String, ByVal finerate As Decimal, ByVal reserveperiod As Integer, ByVal maxbooks As Integer, ByVal booksreturndays As Integer, ByVal maxjournal As Integer, ByVal journalreturndays As Integer, ByVal maxcompbook As Integer, ByVal compbookreturndays As Integer, ByVal lockerperiod As Integer, ByVal lockerfees As Decimal, ByVal losingcardcharge As Decimal, ByVal lockerfine As Decimal, ByVal losingjournalcharge As Decimal, ByVal idcardcharge As Decimal)
        Try
            cmd.CommandText = "update BookCharges set SystemDate='" & SystemDate & "',referencebooks='" & referencebooks & "',finerate=" & finerate & ",reserveperiod=" & reserveperiod & ",maxbooks=" & maxbooks & ",booksreturndays=" & booksreturndays & ",maxjournal=" & maxjournal & ",journalreturndays=" & journalreturndays & ",maxcompbook=" & maxcompbook & ",compbookreturndays=" & compbookreturndays & ",lockerperiod=" & lockerperiod & ",lockerfees=" & lockerfees & ",losingcardcharge=" & losingcardcharge & ",lockerfine=" & lockerfine & ",losingjournalcharge=" & losingjournalcharge & ",idcardcharge=" & idcardcharge & " where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and SystemDate='" & SystemDate & "' and course='" & course & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateChargeOk = True
        Catch ex As Exception
            dr.Close()
            UpdateChargeOk = False
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal course As String)
        Try
            cmd.CommandText = "delete from BookCharges where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and course='" & course & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteChargeOk = True
        Catch ex As Exception
            dr.Close()
            DeleteChargeOk = False
        End Try
    End Sub

    Public Sub AddLibraryCharges(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal dates As String, ByVal issueid As String, ByVal issuedate As String, ByVal regno As String, ByVal name As String, ByVal latedays As Integer, ByVal latefees As Decimal, ByVal losingbooks As Decimal, ByVal losingjournal As Decimal, ByVal losingcompbooks As Decimal, ByVal newidcard As Decimal, ByVal losingidcard As Decimal, ByVal lockerfees As Decimal, ByVal lockerfine As Decimal, ByVal otherfees As Decimal, ByVal reason As String, ByVal totalcharges As Decimal, ByVal payeename As String, ByVal bankname As String, ByVal bankbranch As String, ByVal branchaddress As String, ByVal branchcode As String, ByVal bankaccountno As String, ByVal accounttype As String, ByVal micrcode As String, ByVal electransfer As String, ByVal payvia As String, ByVal account As String)
        Try
            cmd.CommandText = "insert into LibraryCharges(InsID,InsName,Period,SystemDate,date,issueid,issuedate,regno,name,latedays,latefees,losingbooks,losingjournal,losingcompbooks,newidcard,losingidcard,lockerfees,lockerfine,otherfees,reason,totalcharges,payeename,bankname,bankbranch,branchaddress,branchcode,bankaccountno,accounttype,micrcode,electransfer,payvia,account) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & dates & "','" & issueid & "','" & issuedate & "','" & regno & "','" & name & "'," & latedays & "," & latefees & "," & losingbooks & "," & losingjournal & "," & losingcompbooks & "," & newidcard & "," & losingidcard & "," & lockerfees & "," & lockerfine & "," & otherfees & ",'" & reason & "'," & totalcharges & ",'" & payeename & "','" & bankname & "','" & bankbranch & "','" & branchaddress & "','" & branchcode & "','" & bankaccountno & "','" & accounttype & "','" & micrcode & "','" & electransfer & "','" & payvia & "','" & account & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            Dim description As String = "Library Charges"
            Dim type As String = "Income"
            Dim clas As String = ""
            Dim roll As String = ""
            Dim dt As Date = Date.Parse(dates)
            Dim month As Integer = dt.Month
            Dim year As Integer = dt.Year
            cmd.CommandText = "insert into IncomeExpenditure(InsID,InsName,Period,SystemDate,transactionid,descriptions,type,amount,class,roll,regno,name,month,year,account) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & issueid & "','" & description & "','" & type & "'," & totalcharges & ",'" & clas & "','" & roll & "','" & regno & "','" & name & "'," & month & "," & year & ",'" & account & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            AddLibraryChargesOk = True
        Catch ex As Exception
            AddLibraryChargesOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateLibraryCharges(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal dates As String, ByVal issueid As String, ByVal issuedate As String, ByVal regno As String, ByVal name As String, ByVal latedays As Integer, ByVal latefees As Decimal, ByVal losingbooks As Decimal, ByVal losingjournal As Decimal, ByVal losingcompbooks As Decimal, ByVal newidcard As Decimal, ByVal losingidcard As Decimal, ByVal lockerfees As Decimal, ByVal lockerfine As Decimal, ByVal otherfees As Decimal, ByVal reason As String, ByVal totalcharges As Decimal, ByVal payeename As String, ByVal bankname As String, ByVal bankbranch As String, ByVal branchaddress As String, ByVal branchcode As String, ByVal bankaccountno As String, ByVal accounttype As String, ByVal micrcode As String, ByVal electransfer As String, ByVal payvia As String, ByVal account As String, ByVal total As Decimal)
        Try
            cmd.CommandText = "update LibraryCharges set SystemDate='" & SystemDate & "',totalcharges=" & totalcharges & ",latedays=" & latedays & ",latefees=" & latefees & ",losingbooks=" & losingbooks & ",losingjournal=" & losingjournal & ",losingcompbooks=" & losingcompbooks & ",newidcard=" & newidcard & ",losingidcard=" & losingidcard & ",lockerfees=" & lockerfees & ",lockerfine=" & lockerfine & ",otherfees=" & otherfees & ",reason='" & reason & "',payeename='" & payeename & "',bankname='" & bankname & "',bankbranch='" & bankbranch & "',branchaddress='" & branchaddress & "',branchcode='" & branchcode & "',bankaccountno='" & bankaccountno & "',accounttype='" & accounttype & "',micrcode='" & micrcode & "',electransfer='" & electransfer & "',payvia='" & payvia & "',account='" & account & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and date='" & dates & "' and issueid='" & issueid & "' and issuedate='" & issuedate & "' and regno='" & regno & "' and name='" & name & "' and totalcharges=" & total & ""
            dr = cmd.ExecuteReader
            dr.Close()
            Dim description As String = "Library Charges"
            Dim type As String = "Income"
            Dim clas As String = ""
            Dim roll As String = ""
            Dim dt As Date = Date.Parse(dates)
            Dim month As Integer = dt.Month
            Dim year As Integer = dt.Year
            cmd.CommandText = "update IncomeExpenditure set SystemDate='" & SystemDate & "',amount=" & totalcharges & ",class='" & clas & "',roll='" & roll & "',regno='" & regno & "',name='" & name & "',month=" & month & ",year=" & year & ",account='" & account & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and transactionid='" & issueid & "' and descriptions='" & description & "' and type='" & type & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateLibraryChargesOk = True
        Catch ex As Exception
            UpdateLibraryChargesOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteLibraryCharges(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal dates As String, ByVal issueid As String, ByVal issuedate As String, ByVal regno As String, ByVal name As String, ByVal totalcharges As Decimal)
        Try
            cmd.CommandText = "delete from LibraryCharges where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and date='" & dates & "' and issueid='" & issueid & "' and issuedate='" & issuedate & "' and regno='" & regno & "' and name='" & name & "' and totalcharges=" & totalcharges & ""
            dr = cmd.ExecuteReader
            dr.Close()
            Dim description As String = "Library Charges"
            Dim type As String = "Income"
            Dim clas As String = ""
            Dim roll As String = ""
            Dim dt As Date = Date.Parse(dates)
            Dim month As Integer = dt.Month
            Dim year As Integer = dt.Year
            cmd.CommandText = "delete from IncomeExpenditure where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and transactionid='" & issueid & "' and descriptions='" & description & "' and type='" & type & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteLibraryChargesOk = True
        Catch ex As Exception
            DeleteLibraryChargesOk = False
            dr.Close()
        End Try
    End Sub
#End Region
End Class
#End Region