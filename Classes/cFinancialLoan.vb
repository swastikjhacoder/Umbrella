#Region "Class cFinancialLoan..."
Public Class cFinancialLoan
#Region "Declarations..."
    Public AddFinancialLoanOk As Boolean = False
    Public UpdateFinancialLoanOk As Boolean = False
    Public DeleteFinancialLoanOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal regno As String, ByVal applicantno As String, ByVal nationality As String, ByVal religion As String, ByVal attachmentname As String, ByVal attachmentsize As String, ByVal attachmentpath As String, ByVal attachmentnote As String)
        Try
            cmd.CommandText = "insert into FinancialLoan(InsID,InsName,Period,course,picture,class,roll,name,regno,fgname,dob,sex,email,homeph,workph,houseno,address,city,post,district,state,pincode,country) select StudentRegistration.InsID,StudentRegistration.InsName,StudentRegistration.Period,StudentRegistration.course,StudentRegistration.picture,StudentRegistration.class,StudentRegistration.roll,StudentRegistration.name,StudentRegistration.stuid,StudentRegistration.fgname,StudentRegistration.dob,StudentRegistration.sex,StudentRegistration.email,StudentRegistration.homephone,StudentRegistration.workphone,StudentRegistration.prehouseno,StudentRegistration.preaddress,StudentRegistration.precity,StudentRegistration.prepost,StudentRegistration.predist,StudentRegistration.prestate,StudentRegistration.prepin,StudentRegistration.precountry from StudentRegistration where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and stuid='" & regno & "'"
            dr = cmd.ExecuteReader
            dr.Close()

            cmd.CommandText = "update FinancialLoan set SystemDate='" & SystemDate & "',applicantno='" & applicantno & "',nationality='" & nationality & "',religion='" & religion & "',attachmentname='" & attachmentname & "',attachmentsize='" & attachmentsize & "',attachmentpath='" & attachmentpath & "',attachmentnote='" & attachmentnote & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and regno='" & regno & "'"
            dr = cmd.ExecuteReader
            dr.Close()

            cmd.CommandText = "update Indexx set financialid=financialid+1 where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddFinancialLoanOk = True
        Catch ex As Exception
            dr.Close()
            AddFinancialLoanOk = False
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal regno As String, ByVal applicantno As String, ByVal nationality As String, ByVal religion As String, ByVal attachmentname As String, ByVal attachmentsize As String, ByVal attachmentpath As String, ByVal attachmentnote As String)
        Try
            cmd.CommandText = "update FinancialLoan set SystemDate='" & SystemDate & "',nationality='" & nationality & "',religion='" & religion & "',attachmentname='" & attachmentname & "',attachmentsize='" & attachmentsize & "',attachmentpath='" & attachmentpath & "',attachmentnote='" & attachmentnote & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and regno='" & regno & "' and applicantno='" & applicantno & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateFinancialLoanOk = True
        Catch ex As Exception
            dr.Close()
            UpdateFinancialLoanOk = False
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal regno As String, ByVal applicantno As String)
        Try
            cmd.CommandText = "delete from FinancialLoan where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and regno='" & regno & "' and applicantno='" & applicantno & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteFinancialLoanOk = True
        Catch ex As Exception
            dr.Close()
            DeleteFinancialLoanOk = False
        End Try
    End Sub
#End Region
End Class
#End Region