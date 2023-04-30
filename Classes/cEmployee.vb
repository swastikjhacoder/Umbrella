#Region "Class cEmployee..."
Public Class cEmployee
#Region "Declarations..."
    Public AddEmployeeok As Boolean = False
    Public AddEmployeeLang As Boolean = False
    Public AddEmployeeAca As Boolean = False
    Public AddEmployeeTeachingEX As Boolean = False
    Public AddEmployeeResearchEX As Boolean = False
    Public AddEmployeeProg As Boolean = False
    Public UpdateEmployeeok As Boolean = False
    Public UpdateEmployeeLang As Boolean = False
    Public UpdateEmployeeAca As Boolean = False
    Public UpdateEmployeeTeachingEX As Boolean = False
    Public UpdateEmployeeResearchEX As Boolean = False
    Public UpdateEmployeeProg As Boolean = False
    Public DeleteEmployeeok As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddEmployee(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal adminid As String, ByVal namefirst As String, ByVal namemiddle As String, ByVal namelast As String, ByVal houseno As String, ByVal address As String, ByVal city As String, ByVal district As String, ByVal state As String, ByVal pin As String, ByVal country As String, ByVal phone As String, ByVal fax As String, ByVal dob As String, ByVal email As String, ByVal category As String, ByVal department As String, ByVal designation As String, ByVal married As String, ByVal sex As String, ByVal handicapped As String, ByVal presentposition As String, ByVal retirementdate As String, ByVal fulladdress As String, ByVal payinfo As String, ByVal payscale As String, ByVal grade As Decimal, ByVal basic As Decimal, ByVal joiningdate As String, ByVal phd As String, ByVal qualifiedtest As String, ByVal attachedcopy As String, ByVal msword As String, ByVal msexcel As String, ByVal mspowerpoint As String, ByVal internet As String, ByVal knowemail As String, ByVal cmserp As String, ByVal publishedbooks As String, ByVal publishedpaper As String, ByVal publishedarticles As String, ByVal seminar As String, ByVal adminisexp As String, ByVal otheractivities As String, ByVal poriodnotice As String, ByVal referee1 As String, ByVal referee2 As String, ByVal referee3 As String, ByVal otherinfo As String, ByVal incremented As String)
        Try
            Dim name As String = namefirst + " " + namemiddle + " " + namelast
            Dim pfbalance As Decimal = 0.0
            cmd.CommandText = "update Employee set SystemDate='" & SystemDate & "',namefirst='" & namefirst & "',namemiddle='" & namemiddle & "',namelast='" & namelast & "',name='" & name & "',houseno='" & houseno & "',address='" & address & "',city='" & city & "',district='" & district & "',state='" & state & "',pin='" & pin & "',country='" & country & "',phone='" & phone & "',fax='" & fax & "',dob='" & dob & "',email='" & email & "',category='" & category & "',department='" & department & "',designation='" & designation & "',married='" & married & "',sex='" & sex & "',handicapped='" & handicapped & "',presentposition='" & presentposition & "',retirementdate='" & retirementdate & "',fulladdress='" & fulladdress & "',payinfo='" & payinfo & "',payscale='" & payscale & "',grade=" & grade & ",basic=" & basic & ",joiningdate='" & joiningdate & "',phd='" & phd & "',qualifiedtest='" & qualifiedtest & "',attachedcopy='" & attachedcopy & "',incremented='" & incremented & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and empid='" & adminid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "insert into PF(InsID,InsName,Period,regno,designation,name,joiningdate,openingbalance,outstandingadvance) values ('" & InsID & "','" & InsName & "','" & period & "','" & adminid & "','" & designation & "','" & name & "','" & joiningdate & "'," & pfbalance & "," & pfbalance & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "insert into EmployeeProficiency(InsID,InsName,Period,SystemDate,empid,msword,msexcel,mspowerpoint,internet,knowemail,cmserp) values ('" & InsID & "','" & InsName & "','" & period & "','" & SystemDate & "','" & adminid & "','" & msword & "','" & msexcel & "','" & mspowerpoint & "','" & internet & "','" & knowemail & "','" & cmserp & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "insert into EmployeeActivity(InsID,InsName,Period,SystemDate,empid,publishedbooks,publishedpaper,publishedarticles,seminar,adminisexp,otheractivities,poriodnotice,referee1,referee2,referee3,otherinfo) values ('" & InsID & "','" & InsName & "','" & period & "','" & SystemDate & "','" & adminid & "','" & publishedbooks & "','" & publishedpaper & "','" & publishedarticles & "','" & seminar & "','" & adminisexp & "','" & otheractivities & "','" & poriodnotice & "','" & referee1 & "','" & referee2 & "','" & referee3 & "','" & otherinfo & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            AddEmployeeok = True
        Catch ex As Exception
            AddEmployeeok = False
            dr.Close()
        End Try
    End Sub

    Public Sub AddEmployeeLanguage(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal SystemDate As String, ByVal adminid As String, ByVal langname As String, ByVal canread As String, ByVal canwrite As String, ByVal canspeak As String, ByVal canconversation As String)
        Try
            cmd.CommandText = "insert into EmployeeLanguage(InsID,InsName,Period,SystemDate,empid,langname,canread,canwrite,canspeak,canconversation) values ('" & InsID & "','" & InsName & "','" & Period & "','" & SystemDate & "','" & adminid & "','" & langname & "','" & canread & "','" & canwrite & "','" & canspeak & "','" & canconversation & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            AddEmployeeLang = True
        Catch ex As Exception
            AddEmployeeLang = False
            dr.Close()
        End Try
    End Sub

    Public Sub AddEmployeeAcademic(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal SystemDate As String, ByVal adminid As String, ByVal degree As String, ByVal passingyear As Integer, ByVal subjects As String, ByVal percentagemarks As Decimal, ByVal classdivision As String)
        Try
            cmd.CommandText = "insert into EmployeeAcademic(InsID,InsName,Period,SystemDate,empid,degree,passingyear,subjects,percentagemarks,classdivision) values ('" & InsID & "','" & InsName & "','" & Period & "','" & SystemDate & "','" & adminid & "','" & degree & "'," & passingyear & ",'" & subjects & "'," & percentagemarks & ",'" & classdivision & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            AddEmployeeAca = True
        Catch ex As Exception
            AddEmployeeAca = False
            dr.Close()
        End Try
    End Sub

    Public Sub AddEmployeeTeachingExp(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal SystemDate As String, ByVal adminid As String, ByVal totaltexpyear As Integer, ByVal totaltexpmonth As Integer, ByVal institution As String, ByVal designation As String, ByVal totalyears As Integer, ByVal ug As String, ByVal degree As String, ByVal pg As String)
        Try
            cmd.CommandText = "insert into EmployeeTeachingExp(InsID,InsName,Period,SystemDate,empid,totaltexpyear,totaltexpmonth,institution,designation,totalyears,ug,degree,pg) values ('" & InsID & "','" & InsName & "','" & Period & "','" & SystemDate & "','" & adminid & "'," & totaltexpyear & "," & totaltexpmonth & ",'" & institution & "','" & designation & "'," & totalyears & ",'" & ug & "','" & degree & "','" & pg & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            AddEmployeeTeachingEX = True
        Catch ex As Exception
            AddEmployeeTeachingEX = False
            dr.Close()
        End Try
    End Sub

    Public Sub AddEmployeeResearchExp(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal SystemDate As String, ByVal adminid As String, ByVal totalrexpyear As Integer, ByVal totalrexpmonth As Integer, ByVal research As String, ByVal institution As String, ByVal topic As String, ByVal researchperiod As String)
        Try
            cmd.CommandText = "insert into EmployeeResearchExp(InsID,InsName,Period,SystemDate,empid,totalrexpyear,totalrexpmonth,research,institution,topic,researchperiod) values ('" & InsID & "','" & InsName & "','" & Period & "','" & SystemDate & "','" & adminid & "'," & totalrexpyear & "," & totalrexpmonth & ",'" & research & "','" & institution & "','" & topic & "','" & researchperiod & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            AddEmployeeResearchEX = True
        Catch ex As Exception
            AddEmployeeResearchEX = False
            dr.Close()
        End Try
    End Sub

    Public Sub AddEmployeeProgrammingLang(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal SystemDate As String, ByVal adminid As String, ByVal lang As String)
        Try
            cmd.CommandText = "insert into EmployeeProgrammingLang(InsID,InsName,Period,SystemDate,empid,lang) values ('" & InsID & "','" & InsName & "','" & Period & "','" & SystemDate & "','" & adminid & "','" & lang & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            AddEmployeeProg = True
        Catch ex As Exception
            AddEmployeeProg = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateEmployee(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal SystemDate As String, ByVal adminid As String, ByVal namefirst As String, ByVal namemiddle As String, ByVal namelast As String, ByVal houseno As String, ByVal address As String, ByVal city As String, ByVal district As String, ByVal state As String, ByVal pin As String, ByVal country As String, ByVal phone As String, ByVal fax As String, ByVal dob As String, ByVal email As String, ByVal category As String, ByVal department As String, ByVal designation As String, ByVal married As String, ByVal sex As String, ByVal handicapped As String, ByVal presentposition As String, ByVal retirementdate As String, ByVal fulladdress As String, ByVal payinfo As String, ByVal payscale As String, ByVal grade As Decimal, ByVal basic As Decimal, ByVal joiningdate As String, ByVal phd As String, ByVal qualifiedtest As String, ByVal attachedcopy As String, ByVal msword As String, ByVal msexcel As String, ByVal mspowerpoint As String, ByVal internet As String, ByVal knowemail As String, ByVal cmserp As String, ByVal publishedbooks As String, ByVal publishedpaper As String, ByVal publishedarticles As String, ByVal seminar As String, ByVal adminisexp As String, ByVal otheractivities As String, ByVal poriodnotice As String, ByVal referee1 As String, ByVal referee2 As String, ByVal referee3 As String, ByVal otherinfo As String)
        Try
            Dim name As String = namefirst + " " + namemiddle + " " + namelast
            cmd.CommandText = "update Employee set SystemDate='" & SystemDate & "',namefirst='" & namefirst & "',namemiddle='" & namemiddle & "',namelast='" & namelast & "',name='" & name & "',houseno='" & houseno & "',address='" & address & "',city='" & city & "',district='" & district & "',state='" & state & "',pin='" & pin & "',country='" & country & "',phone='" & phone & "',fax='" & fax & "',dob='" & dob & "',email='" & email & "',category='" & category & "',department='" & department & "',designation='" & designation & "',married='" & married & "',sex='" & sex & "',handicapped='" & handicapped & "',presentposition='" & presentposition & "',retirementdate='" & retirementdate & "',fulladdress='" & fulladdress & "',payinfo='" & payinfo & "',payscale='" & payscale & "',grade=" & grade & ",basic=" & basic & ",joiningdate='" & joiningdate & "',phd='" & phd & "',qualifiedtest='" & qualifiedtest & "',attachedcopy='" & attachedcopy & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and empid='" & adminid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update PF set designation='" & designation & "',name='" & name & "',joiningdate='" & joiningdate & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Period & "' and regno='" & adminid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update EmployeeProficiency set SystemDate='" & SystemDate & "',msword='" & msword & "',msexcel='" & msexcel & "',mspowerpoint='" & mspowerpoint & "',internet='" & internet & "',knowemail='" & knowemail & "',cmserp='" & cmserp & "' where InsID='" & InsID & "' and empid='" & adminid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update EmployeeActivity set SystemDate='" & SystemDate & "',publishedbooks='" & publishedbooks & "',publishedpaper='" & publishedpaper & "',publishedarticles='" & publishedarticles & "',seminar='" & seminar & "',adminisexp='" & adminisexp & "',otheractivities='" & otheractivities & "',poriodnotice='" & poriodnotice & "',referee1='" & referee1 & "',referee2='" & referee2 & "',referee3='" & referee3 & "',otherinfo='" & otherinfo & "' where InsID='" & InsID & "' and empid='" & adminid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateEmployeeok = True
        Catch ex As Exception
            UpdateEmployeeok = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateEmployeeLanguage(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal SystemDate As String, ByVal adminid As String, ByVal langname As String, ByVal canread As String, ByVal canwrite As String, ByVal canspeak As String, ByVal canconversation As String)
        Try
            cmd.CommandText = "update EmployeeLanguage set SystemDate='" & SystemDate & "',langname='" & langname & "',canread='" & canread & "',canwrite='" & canwrite & "',canspeak='" & canspeak & "',canconversation='" & canconversation & "' where InsID='" & InsID & "' and empid='" & adminid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateEmployeeLang = True
        Catch ex As Exception
            UpdateEmployeeLang = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateEmployeeAcademic(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal SystemDate As String, ByVal adminid As String, ByVal degree As String, ByVal passingyear As Integer, ByVal subjects As String, ByVal percentagemarks As Decimal, ByVal classdivision As String)
        Try
            cmd.CommandText = "update EmployeeAcademic set SystemDate='" & SystemDate & "',degree='" & degree & "',passingyear=" & passingyear & ",subjects='" & subjects & "',percentagemarks=" & percentagemarks & ",classdivision='" & classdivision & "' where InsID='" & InsID & "' and empid='" & adminid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateEmployeeAca = True
        Catch ex As Exception
            UpdateEmployeeAca = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateEmployeeTeachingExp(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal SystemDate As String, ByVal adminid As String, ByVal totaltexpyear As Integer, ByVal totaltexpmonth As Integer, ByVal institution As String, ByVal designation As String, ByVal totalyears As Integer, ByVal ug As String, ByVal degree As String, ByVal pg As String)
        Try
            cmd.CommandText = "update EmployeeTeachingExp set SystemDate='" & SystemDate & "',totaltexpyear=" & totaltexpyear & ",totaltexpmonth=" & totaltexpmonth & ",institution='" & institution & "',designation='" & designation & "',totalyears=" & totalyears & ",ug='" & ug & "',degree='" & degree & "',pg='" & pg & "' where InsID='" & InsID & "' and empid='" & adminid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateEmployeeTeachingEX = True
        Catch ex As Exception
            UpdateEmployeeTeachingEX = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateEmployeeResearchExp(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal SystemDate As String, ByVal adminid As String, ByVal totalrexpyear As Integer, ByVal totalrexpmonth As Integer, ByVal research As String, ByVal institution As String, ByVal topic As String, ByVal researchperiod As String)
        Try
            cmd.CommandText = "update EmployeeResearchExp set SystemDate='" & SystemDate & "',totalrexpyear=" & totalrexpyear & ",totalrexpmonth=" & totalrexpmonth & ",research='" & research & "',institution='" & institution & "',topic='" & topic & "',researchperiod='" & researchperiod & "' where InsID='" & InsID & "' and empid='" & adminid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateEmployeeResearchEX = True
        Catch ex As Exception
            UpdateEmployeeResearchEX = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateEmployeeProgrammingLang(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal SystemDate As String, ByVal adminid As String, ByVal lang As String)
        Try
            cmd.CommandText = "update EmployeeProgrammingLang set SystemDate='" & SystemDate & "',lang='" & lang & "' where InsID='" & InsID & "' and empid='" & adminid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateEmployeeProg = True
        Catch ex As Exception
            UpdateEmployeeProg = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteEmployeeRecord(ByVal adminid As String)
        Try
            cmd.CommandText = "delete from Employee where empid='" & adminid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "delete from EmployeeLanguage where empid='" & adminid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "delete from EmployeeAcademic where empid='" & adminid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "delete from EmployeeTeachingExp where empid='" & adminid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "delete from EmployeeResearchExp where empid='" & adminid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "delete from EmployeeProficiency where empid='" & adminid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "delete from EmployeeProgrammingLang where empid='" & adminid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "delete from EmployeeActivity where empid='" & adminid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "delete from PF where regno='" & adminid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteEmployeeok = True
        Catch ex As Exception
            DeleteEmployeeok = False
        End Try
    End Sub
#End Region
End Class
#End Region