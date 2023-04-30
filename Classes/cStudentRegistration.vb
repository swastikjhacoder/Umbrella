#Region "Class cStudentRegistration..."
Public Class cStudentRegistration
#Region "Declarations..."
    Public AddOk As String = ""
    Public UpdateOk As String = ""
    Public DeleteOk As String = ""
#End Region
#Region "Functions..."
    Public Function ConvertBytesToMemoryStream(ByVal ImageData As Byte()) As IO.MemoryStream
        Try
            If IsNothing(ImageData) = True Then
                Return Nothing
            End If
            Return New System.IO.MemoryStream(ImageData)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal SystemDate As String, ByVal serial As String, ByVal stuid As String, ByVal roll As String, ByVal time As String, ByVal tuition As String, ByVal emergencyname As String, ByVal emergencyhomeph As String, ByVal emergencyworkph As String, ByVal emergencyfax As String, ByVal emergencyrelation As String, ByVal emergencyaddress As String)
        Try
            cmd.CommandText = "insert into StudentRegistration(InsID,InsName,Period,serial,year,preadmitted,preadmissionid,course,approved,class,classint,classstring,picture,fname,mname,lname,name ,fgname,mothername,dob,sex,coursefee,annualincome,prehouseno,preaddress,precity,prepost,predist,prestate,prepin,precountry,perhouseno,peraddress,percity,perpost,perdist,perstate,perpin,percountry,profcourse,profcourseduration,profcourseyear,institute,recognized,instituteaddress,institutephone,institutefax,instituteuniv,payeename,bankname,bankbrach,branchaddress,branchcode,accountno,accounttype,micrcode,electronictransfer,cardholdername,cardaddress,cardcity,cardstate,cardpin,cardcountry,cardtype,payvia,cardno,expmm,expyy,email,homephone,workphone,fax) select StudentAdmision.InsID,StudentAdmision.InsName,StudentAdmision.Period,StudentAdmision.serial,StudentAdmision.year,StudentAdmision.preadmitted,StudentAdmision.preadmissionid,StudentAdmision.course,StudentAdmision.approved,StudentAdmision.class,StudentAdmision.classint,StudentAdmision.classstring,StudentAdmision.picture,StudentAdmision.fname,StudentAdmision.mname,StudentAdmision.lname,StudentAdmision.name ,StudentAdmision.fgname,StudentAdmision.mothername,StudentAdmision.dob,StudentAdmision.sex,StudentAdmision.coursefee,StudentAdmision.annualincome,StudentAdmision.prehouseno,StudentAdmision.preaddress,StudentAdmision.precity,StudentAdmision.prepost,StudentAdmision.predist,StudentAdmision.prestate,StudentAdmision.prepin,StudentAdmision.precountry,StudentAdmision.perhouseno,StudentAdmision.peraddress,StudentAdmision.percity,StudentAdmision.perpost,StudentAdmision.perdist,StudentAdmision.perstate,StudentAdmision.perpin,StudentAdmision.percountry,StudentAdmision.profcourse,StudentAdmision.profcourseduration,StudentAdmision.profcourseyear,StudentAdmision.institute,StudentAdmision.recognized,StudentAdmision.instituteaddress,StudentAdmision.institutephone,StudentAdmision.institutefax,StudentAdmision.instituteuniv,StudentAdmision.payeename,StudentAdmision.bankname,StudentAdmision.bankbrach,StudentAdmision.branchaddress,StudentAdmision.branchcode,StudentAdmision.accountno,StudentAdmision.accounttype,StudentAdmision.micrcode,StudentAdmision.electronictransfer,StudentAdmision.cardholdername,StudentAdmision.cardaddress,StudentAdmision.cardcity,StudentAdmision.cardstate,StudentAdmision.cardpin,StudentAdmision.cardcountry,StudentAdmision.cardtype,StudentAdmision.payvia,StudentAdmision.cardno,StudentAdmision.expmm,StudentAdmision.expyy,StudentAdmision.email,StudentAdmision.homephone,StudentAdmision.workphone,StudentAdmision.fax from StudentAdmision where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and serial='" & serial & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update StudentRegistration set SystemDate='" & SystemDate & "',stuid='" & stuid & "',roll='" & roll & "',time='" & time & "',tuition='" & tuition & "',emergencyname='" & emergencyname & "',emergencyhomeph='" & emergencyhomeph & "',emergencyworkph='" & emergencyworkph & "',emergencyfax='" & emergencyfax & "',emergencyrelation='" & emergencyrelation & "',emergencyaddress='" & emergencyaddress & "' where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and serial='" & serial & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set sturegid=sturegid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddOk = True
        Catch ex As Exception
            AddOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal SystemDate As String, ByVal serial As String, ByVal stuid As String, ByVal roll As String, ByVal time As String, ByVal tuition As String, ByVal emergencyname As String, ByVal emergencyhomeph As String, ByVal emergencyworkph As String, ByVal emergencyfax As String, ByVal emergencyrelation As String, ByVal emergencyaddress As String)
        Try
            cmd.CommandText = "update StudentRegistration set SystemDate='" & SystemDate & "',roll='" & roll & "',time='" & time & "',tuition='" & tuition & "',emergencyname='" & emergencyname & "',emergencyhomeph='" & emergencyhomeph & "',emergencyworkph='" & emergencyworkph & "',emergencyfax='" & emergencyfax & "',emergencyrelation='" & emergencyrelation & "',emergencyaddress='" & emergencyaddress & "' where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and serial='" & serial & "' and stuid='" & stuid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateOk = True
        Catch ex As Exception
            UpdateOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal stuid As String, ByVal serial As String, ByVal roll As Integer)
        Try
            cmd.CommandText = "delete from StudentRegistration where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & periodd & "' and stuid='" & stuid & "' and serial='" & serial & "' and roll=" & roll & ""
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteOk = True
        Catch ex As Exception
            DeleteOk = False
            dr.Close()
        End Try
    End Sub
#End Region
End Class
#End Region