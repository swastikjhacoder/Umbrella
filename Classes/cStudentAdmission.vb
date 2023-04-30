#Region "Imports..."
Imports System.IO
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
#End Region
#Region "Class cStudentAdmission..."
Public Class cStudentAdmission
#Region "Declarations..."
    Public AddOk As Boolean = False
    Public AddXMOk As Boolean = False
    Public UpdateOk As Boolean = False
    Public UpdateXMOk As Boolean = False
    Public DeleteOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal serial As String, ByVal year As Integer, ByVal preadmitted As String, ByVal preadmissionid As String, ByVal course As String, ByVal approved As String, ByVal clas As String, ByVal classint As Integer, ByVal classstring As String, ByVal picture As PictureBox, ByVal fname As String, ByVal mname As String, ByVal lname As String, ByVal name As String, ByVal dob As String, ByVal sex As String, ByVal fgname As String, ByVal mothername As String, ByVal coursefee As Decimal, ByVal annualincome As Decimal, ByVal prehouseno As String, ByVal preaddress As String, ByVal precity As String, ByVal prepost As String, ByVal predist As String, ByVal prestate As String, ByVal prepin As String, ByVal precountry As String, ByVal perhouseno As String, ByVal peraddress As String, ByVal percity As String, ByVal perpost As String, ByVal perdist As String, ByVal perstate As String, ByVal perpin As String, ByVal percountry As String, ByVal profcourse As String, ByVal profcourseduration As String, ByVal profcourseyear As Integer, ByVal competitiveexam As String, ByVal institute As String, ByVal recognized As String, ByVal instituteaddress As String, ByVal institutephone As String, ByVal institutefax As String, ByVal instituteuniv As String, ByVal payeename As String, ByVal bankname As String, ByVal bankbrach As String, ByVal branchaddress As String, ByVal branchcode As String, ByVal accountno As String, ByVal accounttype As String, ByVal micrcode As String, ByVal electronictransfer As String, ByVal cardholdername As String, ByVal cardaddress As String, ByVal cardcity As String, ByVal cardstate As String, ByVal cardpin As String, ByVal cardcountry As String, ByVal cardtype As String, ByVal payvia As String, ByVal cardno As String, ByVal expmm As Integer, ByVal expyy As Integer, ByVal email As String, ByVal homephone As String, ByVal workphone As String, ByVal fax As String)
        Try
            If preadmitted = "No" Then
                cmd.CommandText = "insert into StudentAdmision(InsID,InsName,Period,SystemDate,serial,year,preadmitted,preadmissionid,course,approved,class,classint,classstring,picture,fname,mname,lname,name,dob,sex,fgname,mothername,coursefee,annualincome,prehouseno,preaddress,precity,prepost,predist,prestate,prepin,precountry,perhouseno,peraddress,percity,perpost,perdist,perstate,perpin,percountry,profcourse,profcourseduration,profcourseyear,competitiveexam,institute,recognized,instituteaddress,institutephone,institutefax,instituteuniv,payeename,bankname,bankbrach,branchaddress,branchcode,accountno,accounttype,micrcode,electronictransfer,cardholdername,cardaddress,cardcity,cardstate,cardpin,cardcountry,cardtype,payvia,cardno,expmm,expyy,email,homephone,workphone,fax) values(@InsID,@InsName,@Period,@SystemDate,@serial,@year,@preadmitted,@preadmissionid,@course,@approved,@class,@classint,@classstring,@picture,@fname,@mname,@lname,@name,@dob,@sex,@fgname,@mothername,@coursefee,@annualincome,@prehouseno,@preaddress,@precity,@prepost,@predist,@prestate,@prepin,@precountry,@perhouseno,@peraddress,@percity,@perpost,@perdist,@perstate,@perpin,@percountry,@profcourse,@profcourseduration,@profcourseyear,@competitiveexam,@institute,@recognized,@instituteaddress,@institutephone,@institutefax,@instituteuniv,@payeename,@bankname,@bankbrach,@branchaddress,@branchcode,@accountno,@accounttype,@micrcode,@electronictransfer,@cardholdername,@cardaddress,@cardcity,@cardstate,@cardpin,@cardcountry,@cardtype,@payvia,@cardno,@expmm,@expyy,@email,@homephone,@workphone,@fax)"
                cmd.Parameters.AddWithValue("@InsID", InsID)
                cmd.Parameters.AddWithValue("@InsName", InsName)
                cmd.Parameters.AddWithValue("@Period", Periodd)
                cmd.Parameters.AddWithValue("@SystemDate", SystemDate)
                cmd.Parameters.AddWithValue("@serial", serial)
                cmd.Parameters.AddWithValue("@year", year)
                cmd.Parameters.AddWithValue("@preadmitted", preadmitted)
                cmd.Parameters.AddWithValue("@preadmissionid", preadmissionid)
                cmd.Parameters.AddWithValue("@course", course)
                cmd.Parameters.AddWithValue("@approved", approved)
                cmd.Parameters.AddWithValue("@class", clas)
                cmd.Parameters.AddWithValue("@classint", classint)
                cmd.Parameters.AddWithValue("@classstring", classstring)
                cmd.Parameters.AddWithValue("@fname", fname)
                cmd.Parameters.AddWithValue("@mname", mname)
                cmd.Parameters.AddWithValue("@lname", lname)
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@dob", dob)
                cmd.Parameters.AddWithValue("@sex", sex)
                cmd.Parameters.AddWithValue("@fgname", fgname)
                cmd.Parameters.AddWithValue("@mothername", mothername)
                cmd.Parameters.AddWithValue("@coursefee", coursefee)
                cmd.Parameters.AddWithValue("@annualincome", annualincome)
                cmd.Parameters.AddWithValue("@prehouseno", prehouseno)
                cmd.Parameters.AddWithValue("@preaddress", preaddress)
                cmd.Parameters.AddWithValue("@precity", precity)
                cmd.Parameters.AddWithValue("@prepost", prepost)
                cmd.Parameters.AddWithValue("@predist", predist)
                cmd.Parameters.AddWithValue("@prestate", prestate)
                cmd.Parameters.AddWithValue("@prepin", prepin)
                cmd.Parameters.AddWithValue("@precountry", precountry)
                cmd.Parameters.AddWithValue("@perhouseno", perhouseno)
                cmd.Parameters.AddWithValue("@peraddress", peraddress)
                cmd.Parameters.AddWithValue("@percity", percity)
                cmd.Parameters.AddWithValue("@perpost", perpost)
                cmd.Parameters.AddWithValue("@perdist", perdist)
                cmd.Parameters.AddWithValue("@perstate", perstate)
                cmd.Parameters.AddWithValue("@perpin", perpin)
                cmd.Parameters.AddWithValue("@percountry", percountry)
                cmd.Parameters.AddWithValue("@profcourse", profcourse)
                cmd.Parameters.AddWithValue("@profcourseduration", profcourseduration)
                cmd.Parameters.AddWithValue("@profcourseyear", profcourseyear)
                cmd.Parameters.AddWithValue("@competitiveexam", competitiveexam)
                cmd.Parameters.AddWithValue("@institute", institute)
                cmd.Parameters.AddWithValue("@recognized", recognized)
                cmd.Parameters.AddWithValue("@instituteaddress", instituteaddress)
                cmd.Parameters.AddWithValue("@institutephone", institutephone)
                cmd.Parameters.AddWithValue("@institutefax", institutefax)
                cmd.Parameters.AddWithValue("@instituteuniv", instituteuniv)
                cmd.Parameters.AddWithValue("@payeename", payeename)
                cmd.Parameters.AddWithValue("@bankname", bankname)
                cmd.Parameters.AddWithValue("@bankbrach", bankbrach)
                cmd.Parameters.AddWithValue("@branchaddress", branchaddress)
                cmd.Parameters.AddWithValue("@branchcode", branchcode)
                cmd.Parameters.AddWithValue("@accountno", accountno)
                cmd.Parameters.AddWithValue("@accounttype", accounttype)
                cmd.Parameters.AddWithValue("@micrcode", micrcode)
                cmd.Parameters.AddWithValue("@electronictransfer", electronictransfer)
                cmd.Parameters.AddWithValue("@cardholdername", cardholdername)
                cmd.Parameters.AddWithValue("@cardaddress", cardaddress)
                cmd.Parameters.AddWithValue("@cardcity", cardcity)
                cmd.Parameters.AddWithValue("@cardstate", cardstate)
                cmd.Parameters.AddWithValue("@cardpin", cardpin)
                cmd.Parameters.AddWithValue("@cardcountry", cardcountry)
                cmd.Parameters.AddWithValue("@cardtype", cardtype)
                cmd.Parameters.AddWithValue("@payvia", payvia)
                cmd.Parameters.AddWithValue("@cardno", cardno)
                cmd.Parameters.AddWithValue("@expmm", expmm)
                cmd.Parameters.AddWithValue("@expyy", expyy)
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@homephone", homephone)
                cmd.Parameters.AddWithValue("@workphone", workphone)
                cmd.Parameters.AddWithValue("@fax", fax)
                Dim ms As New MemoryStream()
                picture.Image.Save(ms, picture.Image.RawFormat)
                Dim data As Byte() = ms.GetBuffer()
                Dim p As New SqlParameter("@picture", SqlDbType.Image)
                p.Value = data
                cmd.Parameters.Add(p)
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
            Else
                cmd.CommandText = "insert into StudentAdmision(InsID,InsName,Period,serial,picture) select StudentPreAdmission.InsID,StudentPreAdmission.InsName,StudentPreAdmission.Period,StudentPreAdmission.serial,StudentPreAdmission.picture from StudentPreAdmission where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and serial='" & preadmissionid & "'"
                dr = cmd.ExecuteReader
                dr.Close()
                cmd.CommandText = "update StudentAdmision set year=@year,preadmitted=@preadmitted,preadmissionid=@preadmissionid,course=@course,approved=@approved,class=@class,classint=@classint,classstring=@classstring,fname=@fname,mname=@mname,lname=@lname,name=@name,dob=@dob,sex=@sex,fgname=@fgname,mothername=@mothername,coursefee=@coursefee,annualincome=@annualincome,prehouseno=@prehouseno,preaddress=@preaddress,precity=@precity,prepost=@prepost,predist=@predist,prestate=@prestate,prepin=@prepin,precountry=@precountry,perhouseno=@perhouseno,peraddress=@peraddress,percity=@percity,perpost=@perpost,perdist=@perdist,perstate=@perstate,perpin=@perpin,percountry=@percountry,profcourse=@profcourse,profcourseduration=@profcourseduration,profcourseyear=@profcourseyear,competitiveexam=@competitiveexam,institute=@institute,recognized=@recognized,instituteaddress=@instituteaddress,institutephone=@institutephone,institutefax=@institutefax,instituteuniv=@instituteuniv,payeename=@payeename,bankname=@bankname,bankbrach=@bankbrach,branchaddress=@branchaddress,branchcode=@branchcode,accountno=@accountno,accounttype=@accounttype,micrcode=@micrcode,electronictransfer=@electronictransfer,cardholdername=@cardholdername,cardaddress=@cardaddress,cardcity=@cardcity,cardstate=@cardstate,cardpin=@cardpin,cardcountry=@cardcountry,cardtype=@cardtype,payvia=@payvia,cardno=@cardno,expmm=@expmm,expyy=@expyy,email=@email,homephone=@homephone,workphone=@workphone,fax=@fax where InsID=@InsID and InsName=@InsName and Period=@Period and serial=@serial"
                cmd.Parameters.AddWithValue("@InsID", InsID)
                cmd.Parameters.AddWithValue("@InsName", InsName)
                cmd.Parameters.AddWithValue("@Period", Periodd)
                cmd.Parameters.AddWithValue("@serial", preadmissionid)
                cmd.Parameters.AddWithValue("@year", year)
                cmd.Parameters.AddWithValue("@preadmitted", preadmitted)
                cmd.Parameters.AddWithValue("@preadmissionid", preadmissionid)
                cmd.Parameters.AddWithValue("@course", course)
                cmd.Parameters.AddWithValue("@approved", approved)
                cmd.Parameters.AddWithValue("@class", clas)
                cmd.Parameters.AddWithValue("@classint", classint)
                cmd.Parameters.AddWithValue("@classstring", classstring)
                cmd.Parameters.AddWithValue("@fname", fname)
                cmd.Parameters.AddWithValue("@mname", mname)
                cmd.Parameters.AddWithValue("@lname", lname)
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@dob", dob)
                cmd.Parameters.AddWithValue("@sex", sex)
                cmd.Parameters.AddWithValue("@fgname", fgname)
                cmd.Parameters.AddWithValue("@mothername", mothername)
                cmd.Parameters.AddWithValue("@coursefee", coursefee)
                cmd.Parameters.AddWithValue("@annualincome", annualincome)
                cmd.Parameters.AddWithValue("@prehouseno", prehouseno)
                cmd.Parameters.AddWithValue("@preaddress", preaddress)
                cmd.Parameters.AddWithValue("@precity", precity)
                cmd.Parameters.AddWithValue("@prepost", prepost)
                cmd.Parameters.AddWithValue("@predist", predist)
                cmd.Parameters.AddWithValue("@prestate", prestate)
                cmd.Parameters.AddWithValue("@prepin", prepin)
                cmd.Parameters.AddWithValue("@precountry", precountry)
                cmd.Parameters.AddWithValue("@perhouseno", perhouseno)
                cmd.Parameters.AddWithValue("@peraddress", peraddress)
                cmd.Parameters.AddWithValue("@percity", percity)
                cmd.Parameters.AddWithValue("@perpost", perpost)
                cmd.Parameters.AddWithValue("@perdist", perdist)
                cmd.Parameters.AddWithValue("@perstate", perstate)
                cmd.Parameters.AddWithValue("@perpin", perpin)
                cmd.Parameters.AddWithValue("@percountry", percountry)
                cmd.Parameters.AddWithValue("@profcourse", profcourse)
                cmd.Parameters.AddWithValue("@profcourseduration", profcourseduration)
                cmd.Parameters.AddWithValue("@profcourseyear", profcourseyear)
                cmd.Parameters.AddWithValue("@competitiveexam", competitiveexam)
                cmd.Parameters.AddWithValue("@institute", institute)
                cmd.Parameters.AddWithValue("@recognized", recognized)
                cmd.Parameters.AddWithValue("@instituteaddress", instituteaddress)
                cmd.Parameters.AddWithValue("@institutephone", institutephone)
                cmd.Parameters.AddWithValue("@institutefax", institutefax)
                cmd.Parameters.AddWithValue("@instituteuniv", instituteuniv)
                cmd.Parameters.AddWithValue("@payeename", payeename)
                cmd.Parameters.AddWithValue("@bankname", bankname)
                cmd.Parameters.AddWithValue("@bankbrach", bankbrach)
                cmd.Parameters.AddWithValue("@branchaddress", branchaddress)
                cmd.Parameters.AddWithValue("@branchcode", branchcode)
                cmd.Parameters.AddWithValue("@accountno", accountno)
                cmd.Parameters.AddWithValue("@accounttype", accounttype)
                cmd.Parameters.AddWithValue("@micrcode", micrcode)
                cmd.Parameters.AddWithValue("@electronictransfer", electronictransfer)
                cmd.Parameters.AddWithValue("@cardholdername", cardholdername)
                cmd.Parameters.AddWithValue("@cardaddress", cardaddress)
                cmd.Parameters.AddWithValue("@cardcity", cardcity)
                cmd.Parameters.AddWithValue("@cardstate", cardstate)
                cmd.Parameters.AddWithValue("@cardpin", cardpin)
                cmd.Parameters.AddWithValue("@cardcountry", cardcountry)
                cmd.Parameters.AddWithValue("@cardtype", cardtype)
                cmd.Parameters.AddWithValue("@payvia", payvia)
                cmd.Parameters.AddWithValue("@cardno", cardno)
                cmd.Parameters.AddWithValue("@expmm", expmm)
                cmd.Parameters.AddWithValue("@expyy", expyy)
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@homephone", homephone)
                cmd.Parameters.AddWithValue("@workphone", workphone)
                cmd.Parameters.AddWithValue("@fax", fax)
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
                cmd.CommandText = "update StudentAdmision set SystemDate=@SystemDate,serial=@serial where InsID=@InsID and InsName=@InsName and Period=@Period and preadmissionid=@preadmissionid"
                cmd.Parameters.AddWithValue("@InsID", InsID)
                cmd.Parameters.AddWithValue("@InsName", InsName)
                cmd.Parameters.AddWithValue("@Period", Periodd)
                cmd.Parameters.AddWithValue("@SystemDate", SystemDate)
                cmd.Parameters.AddWithValue("@serial", serial)
                cmd.Parameters.AddWithValue("@preadmissionid", preadmissionid)
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
            End If
            cmd.CommandText = "update Indexx set admissionsl=admissionsl+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddOk = True
        Catch ex As Exception
            AddOk = False
            dr.Close()
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Public Sub AddAdmissionExam(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal stuid As String, ByVal firstname As String, ByVal middlename As String, ByVal lastname As String, ByVal name As String, ByVal exam As String, ByVal board As String, ByVal subject As String, ByVal passingyear As Integer, ByVal marks As Decimal, ByVal division As String)
        Try
            cmd.CommandText = "insert into StudentAdmisionExam(InsID,InsName,Period,SystemDate,stuid,fname,mname,lname,name,exam,board,subject,passingyear,marks,division) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & SystemDate & "','" & stuid & "','" & firstname & "','" & middlename & "','" & lastname & "','" & name & "','" & exam & "','" & board & "','" & subject & "'," & passingyear & "," & marks & ",'" & division & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            AddXMOk = True
        Catch ex As Exception
            AddXMOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal serial As String, ByVal year As Integer, ByVal preadmitted As String, ByVal preadmissionid As String, ByVal course As String, ByVal approved As String, ByVal clas As String, ByVal classint As Integer, ByVal classstring As String, ByVal picture As String, ByVal fname As String, ByVal mname As String, ByVal lname As String, ByVal name As String, ByVal dob As String, ByVal sex As String, ByVal fgname As String, ByVal mothername As String, ByVal coursefee As Decimal, ByVal annualincome As Decimal, ByVal prehouseno As String, ByVal preaddress As String, ByVal precity As String, ByVal prepost As String, ByVal predist As String, ByVal prestate As String, ByVal prepin As String, ByVal precountry As String, ByVal perhouseno As String, ByVal peraddress As String, ByVal percity As String, ByVal perpost As String, ByVal perdist As String, ByVal perstate As String, ByVal perpin As String, ByVal percountry As String, ByVal profcourse As String, ByVal profcourseduration As Integer, ByVal profcourseyear As Integer, ByVal competitiveexam As String, ByVal institute As String, ByVal recognized As String, ByVal instituteaddress As String, ByVal institutephone As String, ByVal institutefax As String, ByVal instituteuniv As String, ByVal payeename As String, ByVal bankname As String, ByVal bankbrach As String, ByVal branchaddress As String, ByVal branchcode As String, ByVal accountno As String, ByVal accounttype As String, ByVal micrcode As String, ByVal electronictransfer As String, ByVal cardholdername As String, ByVal cardaddress As String, ByVal cardcity As String, ByVal cardstate As String, ByVal cardpin As String, ByVal cardcountry As String, ByVal cardtype As String, ByVal payvia As String, ByVal cardno As String, ByVal expmm As Integer, ByVal expyy As Integer, ByVal email As String, ByVal homephone As String, ByVal workphone As String, ByVal fax As String)
        Try
            cmd.CommandText = "update StudentAdmision set SystemDate='" & SystemDate & "',year=" & year & ",preadmitted='" & preadmitted & "',preadmissionid='" & preadmissionid & "',course='" & course & "',approved='" & approved & "',class='" & clas & "',classint=" & classint & ",classstring='" & classstring & "',fname='" & fname & "',mname='" & mname & "',lname='" & lname & "',name='" & name & "',dob='" & dob & "',sex='" & sex & "',fgname='" & fgname & "',mothername='" & mothername & "',coursefee=" & coursefee & ",annualincome=" & annualincome & ",prehouseno='" & prehouseno & "',preaddress='" & preaddress & "',precity='" & precity & "',prepost='" & prepost & "',predist='" & predist & "',prestate='" & prestate & "',prepin='" & prepin & "',precountry='" & precountry & "',perhouseno='" & perhouseno & "',peraddress='" & peraddress & "',percity='" & percity & "',perpost='" & perpost & "',perdist='" & perdist & "',perstate='" & perstate & "',perpin='" & perpin & "',percountry='" & percountry & "',profcourse='" & profcourse & "',profcourseduration='" & profcourseduration & "',profcourseyear=" & profcourseyear & ",competitiveexam='" & competitiveexam & "',institute='" & institute & "',recognized='" & recognized & "',instituteaddress='" & instituteaddress & "',institutephone='" & institutephone & "',institutefax='" & institutefax & "',instituteuniv='" & instituteuniv & "',payeename='" & payeename & "',bankname='" & bankname & "',bankbrach='" & bankbrach & "',branchaddress='" & branchaddress & "',branchcode='" & branchcode & "',accountno='" & accountno & "',accounttype='" & accounttype & "',micrcode='" & micrcode & "',electronictransfer='" & electronictransfer & "',cardholdername='" & cardholdername & "',cardaddress='" & cardaddress & "',cardcity='" & cardcity & "',cardstate='" & cardstate & "',cardpin='" & cardpin & "',cardcountry='" & cardcountry & "',cardtype='" & cardtype & "',payvia='" & payvia & "',cardno='" & cardno & "',expmm=" & expmm & ",expyy=" & expyy & ",email='" & email & "',homephone='" & homephone & "',workphone='" & workphone & "',fax='" & fax & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and serial='" & serial & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateOk = True
        Catch ex As Exception
            UpdateOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateAdmissionExam(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal stuid As String, ByVal firstname As String, ByVal middlename As String, ByVal lastname As String, ByVal name As String, ByVal exam As String, ByVal board As String, ByVal subject As String, ByVal passingyear As Integer, ByVal marks As Decimal, ByVal division As String)
        Try
            cmd.CommandText = "insert into StudentAdmisionExam(InsID,InsName,Period,SystemDate,stuid,fname,mname,lname,name,exam,board,subject,passingyear,marks,division) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & SystemDate & "','" & stuid & "','" & firstname & "','" & middlename & "','" & lastname & "','" & name & "','" & exam & "','" & board & "','" & subject & "'," & passingyear & "," & marks & ",'" & division & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateXMOk = True
        Catch ex As Exception
            UpdateXMOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal stuid As String)
        Try
            cmd.CommandText = "delete from StudentAdmision where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & periodd & "' and serial='" & stuid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "delete from StudentAdmisionExam where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & periodd & "' and stuid='" & stuid & "'"
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