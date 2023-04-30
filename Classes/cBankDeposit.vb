#Region "Class cBankDeposit..."
Public Class cBankDeposit
#Region "Declarations..."
    Public AddBankDepositOk As Boolean = False
    Public UpdateBankDepositOk As Boolean = False
    Public DeleteBankDepositOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal depositid As String, ByVal dates As String, ByVal amount As Decimal, ByVal payvia As String, ByVal checkno As String, ByVal account As String, ByVal payeename As String, ByVal bankname As String, ByVal branchname As String, ByVal branchaddress As String, ByVal branchcode As String, ByVal bankaccountno As String, ByVal accounttype As String, ByVal micrcode As String, ByVal electransfer As String)
        Try
            cmd.CommandText = "insert into BankDeposit(InsID,InsName,Period,SystemDate,depositid,date,amount,payvia,checkno,account,payeename,bankname,branchname,branchaddress,branchcode,bankaccountno,accounttype,micrcode,electransfer) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & depositid & "','" & dates & "'," & amount & ",'" & payvia & "','" & checkno & "','" & account & "','" & payeename & "','" & bankname & "','" & branchname & "','" & branchaddress & "','" & branchcode & "','" & bankaccountno & "','" & accounttype & "','" & micrcode & "','" & electransfer & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set depositid=depositid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddBankDepositOk = True
        Catch ex As Exception
            AddBankDepositOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal depositid As String, ByVal dates As String, ByVal amount As Decimal, ByVal payvia As String, ByVal checkno As String, ByVal account As String, ByVal payeename As String, ByVal bankname As String, ByVal branchname As String, ByVal branchaddress As String, ByVal branchcode As String, ByVal bankaccountno As String, ByVal accounttype As String, ByVal micrcode As String, ByVal electransfer As String)
        Try
            cmd.CommandText = "update BankDeposit set SystemDate='" & SystemDate & "',amount=" & amount & ",payvia='" & payvia & "',checkno='" & checkno & "',account='" & account & "',payeename='" & payeename & "',bankname='" & bankname & "',branchname='" & branchname & "',branchaddress='" & branchaddress & "',branchcode='" & branchcode & "',bankaccountno='" & bankaccountno & "',accounttype='" & accounttype & "',micrcode='" & micrcode & "',electransfer='" & electransfer & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and depositid='" & depositid & "' and date='" & dates & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateBankDepositOk = True
        Catch ex As Exception
            UpdateBankDepositOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal depositid As String, ByVal dates As String)
        Try
            cmd.CommandText = "delete from BankDeposit where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and depositid='" & depositid & "' and date='" & dates & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteBankDepositOk = True
        Catch ex As Exception
            DeleteBankDepositOk = False
            dr.Close()
        End Try
    End Sub
#End Region
End Class
#End Region