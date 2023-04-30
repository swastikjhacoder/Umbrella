#Region "Class cCertificates..."
Public Class cCertificates
#Region "Declarations..."
    Public AddRecordOk As Boolean = False
    Public UpdateRecordOk As Boolean = False
    Public DeleteRecordOk As Boolean = False
    Public AddEmployeeRecordOk As Boolean = False
    Public UpdateEmployeeRecordOk As Boolean = False
    Public DeleteEmployeeRecordOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal certificateid As String, ByVal regno As String, ByVal name As String, ByVal certificatefor As String, ByVal issuedate As String, ByVal verified As String, ByVal verifiedby As String, ByVal remarks As String)
        Try
            cmd.CommandText = "insert into StudentCertificate(InsID,InsName,Period,SystemDate,certificateid,regno,name,certificatefor,issuedate,verified,verifiedby,remarks) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & certificateid & "','" & regno & "','" & name & "','" & certificatefor & "','" & issuedate & "','" & verified & "','" & verifiedby & "','" & remarks & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set certificateid=certificateid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddRecordOk = True
        Catch ex As Exception
            dr.Close()
            AddRecordOk = False
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal certificateid As String, ByVal regno As String, ByVal name As String, ByVal certificatefor As String, ByVal issuedate As String, ByVal verified As String, ByVal verifiedby As String, ByVal remarks As String)
        Try
            cmd.CommandText = "update StudentCertificate set SystemDate='" & SystemDate & "',regno='" & regno & "',name='" & name & "',certificatefor='" & certificatefor & "',issuedate='" & issuedate & "',verified='" & verified & "',verifiedby='" & verifiedby & "',remarks='" & remarks & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and certificateid='" & certificateid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateRecordOk = True
        Catch ex As Exception
            dr.Close()
            UpdateRecordOk = False
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal certificateid As String)
        Try
            cmd.CommandText = "delete from StudentCertificate where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and certificateid='" & certificateid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteRecordOk = True
        Catch ex As Exception
            dr.Close()
            DeleteRecordOk = False
        End Try
    End Sub

    Public Sub AddEmployeeRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal certificateid As String, ByVal regno As String, ByVal name As String, ByVal certificatefor As String, ByVal issuedate As String, ByVal verified As String, ByVal verifiedby As String, ByVal schooltype1 As String, ByVal schooltype2 As String, ByVal schooltype3 As String, ByVal schooltype4 As String, ByVal schooltype5 As String, ByVal schooltype6 As String, ByVal type1 As String, ByVal type2 As String, ByVal type3 As String, ByVal workingfor As String)
        Try
            cmd.CommandText = "insert into EmployeeCertificate(InsID,InsName,Period,SystemDate,certificateid,regno,name,certificatefor,issuedate,verified,verifiedby,schooltype1,schooltype2,schooltype3,schooltype4,schooltype5,schooltype6,type1,type2,type3,workingfor) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & certificateid & "','" & regno & "','" & name & "','" & certificatefor & "','" & issuedate & "','" & verified & "','" & verifiedby & "','" & schooltype1 & "','" & schooltype2 & "','" & schooltype3 & "','" & schooltype4 & "','" & schooltype5 & "','" & schooltype6 & "','" & type1 & "','" & type2 & "','" & type3 & "','" & workingfor & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set certificateid=certificateid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddEmployeeRecordOk = True
        Catch ex As Exception
            dr.Close()
            AddEmployeeRecordOk = False
        End Try
    End Sub

    Public Sub UpdateEmployeeRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal certificateid As String, ByVal regno As String, ByVal name As String, ByVal certificatefor As String, ByVal issuedate As String, ByVal verified As String, ByVal verifiedby As String, ByVal schooltype1 As String, ByVal schooltype2 As String, ByVal schooltype3 As String, ByVal schooltype4 As String, ByVal schooltype5 As String, ByVal schooltype6 As String, ByVal type1 As String, ByVal type2 As String, ByVal type3 As String, ByVal workingfor As String)
        Try
            cmd.CommandText = "update EmployeeCertificate set regno='" & regno & "',name='" & name & "',certificatefor='" & certificatefor & "',issuedate='" & issuedate & "',verified='" & verified & "',verifiedby='" & verifiedby & "',schooltype1='" & schooltype1 & "',schooltype2='" & schooltype2 & "',schooltype3='" & schooltype3 & "',schooltype4='" & schooltype4 & "',schooltype5='" & schooltype5 & "',schooltype6='" & schooltype6 & "',type1='" & type1 & "',type2='" & type2 & "',type3='" & type3 & "',workingfor='" & workingfor & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and certificateid='" & certificateid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateEmployeeRecordOk = True
        Catch ex As Exception
            dr.Close()
            UpdateEmployeeRecordOk = False
        End Try
    End Sub

    Public Sub DeleteEmployeeRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal certificateid As String)
        Try
            cmd.CommandText = "delete from EmployeeCertificate where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and certificateid='" & certificateid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteEmployeeRecordOk = True
        Catch ex As Exception
            dr.Close()
            DeleteEmployeeRecordOk = False
        End Try
    End Sub
#End Region
End Class
#End Region