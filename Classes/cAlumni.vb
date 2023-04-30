#Region "Class cAlumni..."
Public Class cAlumni
#Region "Declarations..."
    Public AddRecordOk As Boolean = False
    Public DeleteRecordOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal regno As String, ByVal name As String, ByVal alumniyear As Integer, ByVal SystemDate As String)
        Try
            cmd.CommandText = "insert into Alumni(InsID,InsName,Period,serial,year,preadmitted,preadmissionid,course,approved,class,classint,classstring,picture,fname,mname,lname,name,fgname,mothername,dob,sex,coursefee,annualincome,prehouseno,preaddress,precity,prepost,predist,prestate,prepin,precountry,perhouseno,peraddress,percity,perpost,perdist,perstate,perpin,percountry,profcourse,profcourseduration,profcourseyear,institute,recognized,instituteaddress,institutephone,institutefax,instituteuniv,payeename,bankname,bankbrach,branchaddress,branchcode,accountno,accounttype,micrcode,electronictransfer,cardholdername,cardaddress,cardcity,cardstate,cardpin,cardcountry,cardtype,payvia,cardno,expmm,expyy,email,homephone,workphone,fax,stuid,roll,time,tuition,emergencyname,emergencyhomeph,emergencyworkph,emergencyfax,emergencyrelation,emergencyaddress) select StudentRegistration.InsID,StudentRegistration.InsName,StudentRegistration.Period,StudentRegistration.serial,StudentRegistration.year,StudentRegistration.preadmitted,StudentRegistration.preadmissionid,StudentRegistration.course,StudentRegistration.approved,StudentRegistration.class,StudentRegistration.classint,StudentRegistration.classstring,StudentRegistration.picture,StudentRegistration.fname,StudentRegistration.mname,StudentRegistration.lname,StudentRegistration.name,StudentRegistration.fgname,StudentRegistration.mothername,StudentRegistration.dob,StudentRegistration.sex,StudentRegistration.coursefee,StudentRegistration.annualincome,StudentRegistration.prehouseno,StudentRegistration.preaddress,StudentRegistration.precity,StudentRegistration.prepost,StudentRegistration.predist,StudentRegistration.prestate,StudentRegistration.prepin,StudentRegistration.precountry,StudentRegistration.perhouseno,StudentRegistration.peraddress,StudentRegistration.percity,StudentRegistration.perpost,StudentRegistration.perdist,StudentRegistration.perstate,StudentRegistration.perpin,StudentRegistration.percountry,StudentRegistration.profcourse,StudentRegistration.profcourseduration,StudentRegistration.profcourseyear,StudentRegistration.institute,StudentRegistration.recognized,StudentRegistration.instituteaddress,StudentRegistration.institutephone,StudentRegistration.institutefax,StudentRegistration.instituteuniv,StudentRegistration.payeename,StudentRegistration.bankname,StudentRegistration.bankbrach,StudentRegistration.branchaddress,StudentRegistration.branchcode,StudentRegistration.accountno,StudentRegistration.accounttype,StudentRegistration.micrcode,StudentRegistration.electronictransfer,StudentRegistration.cardholdername,StudentRegistration.cardaddress,StudentRegistration.cardcity,StudentRegistration.cardstate,StudentRegistration.cardpin,StudentRegistration.cardcountry,StudentRegistration.cardtype,StudentRegistration.payvia,StudentRegistration.cardno,StudentRegistration.expmm,StudentRegistration.expyy,StudentRegistration.email,StudentRegistration.homephone,StudentRegistration.workphone,StudentRegistration.fax,StudentRegistration.stuid,StudentRegistration.roll,StudentRegistration.time,StudentRegistration.tuition,StudentRegistration.emergencyname,StudentRegistration.emergencyhomeph,StudentRegistration.emergencyworkph,StudentRegistration.emergencyfax,StudentRegistration.emergencyrelation,StudentRegistration.emergencyaddress from StudentRegistration where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and stuid='" & regno & "' and name='" & name & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Alumni set SystemDate='" & SystemDate & "',alumniyear=" & alumniyear & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and stuid='" & regno & "' and name='" & name & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "delete from StudentRegistration where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and stuid='" & regno & "' and name='" & name & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddRecordOk = True
        Catch ex As Exception
            dr.Close()
            AddRecordOk = False
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal regno As String, ByVal name As String)
        Try
            cmd.CommandText = "insert into StudentRegistration(InsID,InsName,Period,serial,year,preadmitted,preadmissionid,course,approved,class,classint,classstring,picture,fname,mname,lname,name,fgname,mothername,dob,sex,coursefee,annualincome,prehouseno,preaddress,precity,prepost,predist,prestate,prepin,precountry,perhouseno,peraddress,percity,perpost,perdist,perstate,perpin,percountry,profcourse,profcourseduration,profcourseyear,institute,recognized,instituteaddress,institutephone,institutefax,instituteuniv,payeename,bankname,bankbrach,branchaddress,branchcode,accountno,accounttype,micrcode,electronictransfer,cardholdername,cardaddress,cardcity,cardstate,cardpin,cardcountry,cardtype,payvia,cardno,expmm,expyy,email,homephone,workphone,fax,stuid,roll,time,tuition,emergencyname,emergencyhomeph,emergencyworkph,emergencyfax,emergencyrelation,emergencyaddress) select Alumni.InsID,Alumni.InsName,Alumni.Period,Alumni.serial,Alumni.year,Alumni.preadmitted,Alumni.preadmissionid,Alumni.course,Alumni.approved,Alumni.class,Alumni.classint,Alumni.classstring,Alumni.picture,Alumni.fname,Alumni.mname,Alumni.lname,Alumni.name,Alumni.fgname,Alumni.mothername,Alumni.dob,Alumni.sex,Alumni.coursefee,Alumni.annualincome,Alumni.prehouseno,Alumni.preaddress,Alumni.precity,Alumni.prepost,Alumni.predist,Alumni.prestate,Alumni.prepin,Alumni.precountry,Alumni.perhouseno,Alumni.peraddress,Alumni.percity,Alumni.perpost,Alumni.perdist,Alumni.perstate,Alumni.perpin,Alumni.percountry,Alumni.profcourse,Alumni.profcourseduration,Alumni.profcourseyear,Alumni.institute,Alumni.recognized,Alumni.instituteaddress,Alumni.institutephone,Alumni.institutefax,Alumni.instituteuniv,Alumni.payeename,Alumni.bankname,Alumni.bankbrach,Alumni.branchaddress,Alumni.branchcode,Alumni.accountno,Alumni.accounttype,Alumni.micrcode,Alumni.electronictransfer,Alumni.cardholdername,Alumni.cardaddress,Alumni.cardcity,Alumni.cardstate,Alumni.cardpin,Alumni.cardcountry,Alumni.cardtype,Alumni.payvia,Alumni.cardno,Alumni.expmm,Alumni.expyy,Alumni.email,Alumni.homephone,Alumni.workphone,Alumni.fax,Alumni.stuid,Alumni.roll,Alumni.time,Alumni.tuition,Alumni.emergencyname,Alumni.emergencyhomeph,Alumni.emergencyworkph,Alumni.emergencyfax,Alumni.emergencyrelation,Alumni.emergencyaddress from Alumni where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and stuid='" & regno & "' and name='" & name & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "delete from Alumni where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and stuid='" & regno & "' and name='" & name & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteRecordOk = True
        Catch ex As Exception
            dr.Close()
            DeleteRecordOk = False
        End Try
    End Sub
#End Region
End Class
#End Region