#Region "Imports..."
Imports System.IO
Imports System.Data.SqlClient

#End Region
#Region "Class cPreAdmission..."
Public Class cPreAdmission
#Region "Declarations..."
    Public AddOk As Boolean = False
    Public UpdateOk As Boolean = False
    Public DeleteOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal serial As String, ByVal year As Integer, ByVal fname As String, ByVal mname As String, ByVal lname As String, ByVal name As String, ByVal dob As String, ByVal sex As String, ByVal fgname As String, ByVal mothername As String, ByVal picture As PictureBox, ByVal houseno As String, ByVal address As String, ByVal city As String, ByVal post As String, ByVal dist As String, ByVal state As String, ByVal pin As String, ByVal country As String, ByVal email As String, ByVal homephone As String, ByVal workphone As String, ByVal fax As String, ByVal clas As String, ByVal classint As Integer, ByVal classstring As String, ByVal course As String, ByVal testfee As Decimal, ByVal othertestfee As Decimal, ByVal coursefee As Decimal, ByVal annualincome As Decimal, ByVal payeename As String, ByVal bankname As String, ByVal bankbrach As String, ByVal branchaddress As String, ByVal branchcode As String, ByVal accountno As String, ByVal accounttype As String, ByVal micrcode As String, ByVal electronictransfer As String, ByVal cardholdername As String, ByVal cardaddress As String, ByVal cardcity As String, ByVal cardstate As String, ByVal cardpin As String, ByVal cardcountry As String, ByVal cardtype As String, ByVal payvia As String, ByVal cardno As String, ByVal expmm As Integer, ByVal expyy As Integer)
        Try
            cmd.CommandText = "insert into StudentPreAdmission(InsID,InsName,Period,SystemDate,serial,year,fname,mname,lname,name,dob,sex,fgname,mothername,picture,houseno,address,city,post,dist,state,pin,country,email,homephone,workphone,fax,class,classint,classstring,course,testfee,othertestfee,coursefee,annualincome,payeename,bankname,bankbrach,branchaddress,branchcode,accountno,accounttype,micrcode,electronictransfer,cardholdername,cardaddress,cardcity,cardstate,cardpin,cardcountry,cardtype,payvia,cardno,expmm,expyy) values(@InsID,@InsName,@Period,@SystemDate,@serial,@year,@fname,@mname,@lname,@name,@dob,@sex,@fgname,@mothername,@picture,@houseno,@address,@city,@post,@dist,@state,@pin,@country,@email,@homephone,@workphone,@fax,@class,@classint,@classstring,@course,@testfee,@othertestfee,@coursefee,@annualincome,@payeename,@bankname,@bankbrach,@branchaddress,@branchcode,@accountno,@accounttype,@micrcode,@electronictransfer,@cardholdername,@cardaddress,@cardcity,@cardstate,@cardpin,@cardcountry,@cardtype,@payvia,@cardno,@expmm,@expyy)"
            cmd.Parameters.AddWithValue("@InsID", InsID)
            cmd.Parameters.AddWithValue("@InsName", InsName)
            cmd.Parameters.AddWithValue("@Period", Periodd)
            cmd.Parameters.AddWithValue("@SystemDate", SystemDate)
            cmd.Parameters.AddWithValue("@serial", serial)
            cmd.Parameters.AddWithValue("@year", year)
            cmd.Parameters.AddWithValue("@fname", fname)
            cmd.Parameters.AddWithValue("@mname", mname)
            cmd.Parameters.AddWithValue("@lname", lname)
            cmd.Parameters.AddWithValue("@name", name)
            cmd.Parameters.AddWithValue("@dob", dob)
            cmd.Parameters.AddWithValue("@sex", sex)
            cmd.Parameters.AddWithValue("@fgname", fgname)
            cmd.Parameters.AddWithValue("@mothername", mothername)
            cmd.Parameters.AddWithValue("@houseno", houseno)
            cmd.Parameters.AddWithValue("@address", address)
            cmd.Parameters.AddWithValue("@city", city)
            cmd.Parameters.AddWithValue("@post", post)
            cmd.Parameters.AddWithValue("@dist", dist)
            cmd.Parameters.AddWithValue("@state", state)
            cmd.Parameters.AddWithValue("@pin", pin)
            cmd.Parameters.AddWithValue("@country", country)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@homephone", homephone)
            cmd.Parameters.AddWithValue("@workphone", workphone)
            cmd.Parameters.AddWithValue("@fax", fax)
            cmd.Parameters.AddWithValue("@class", clas)
            cmd.Parameters.AddWithValue("@classint", classint)
            cmd.Parameters.AddWithValue("@classstring", classstring)
            cmd.Parameters.AddWithValue("@course", course)
            cmd.Parameters.AddWithValue("@testfee", testfee)
            cmd.Parameters.AddWithValue("@othertestfee", othertestfee)
            cmd.Parameters.AddWithValue("@coursefee", coursefee)
            cmd.Parameters.AddWithValue("@annualincome", annualincome)
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
            Dim ms As New MemoryStream()
            picture.Image.Save(ms, picture.Image.RawFormat)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@picture", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
            cmd.CommandText = "update Indexx set preadmissionsl=preadmissionsl+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddOk = True
        Catch ex As Exception
            AddOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal serial As String, ByVal year As Integer, ByVal fname As String, ByVal mname As String, ByVal lname As String, ByVal name As String, ByVal dob As String, ByVal sex As String, ByVal fgname As String, ByVal mothername As String, ByVal picture As String, ByVal houseno As String, ByVal address As String, ByVal city As String, ByVal post As String, ByVal dist As String, ByVal state As String, ByVal pin As String, ByVal country As String, ByVal email As String, ByVal homephone As String, ByVal workphone As String, ByVal fax As String, ByVal clas As String, ByVal classint As Integer, ByVal classstring As String, ByVal course As String, ByVal testfee As Decimal, ByVal othertestfee As Decimal, ByVal coursefee As Decimal, ByVal annualincome As Decimal, ByVal payeename As String, ByVal bankname As String, ByVal bankbrach As String, ByVal branchaddress As String, ByVal branchcode As String, ByVal accountno As String, ByVal accounttype As String, ByVal micrcode As String, ByVal electronictransfer As String, ByVal cardholdername As String, ByVal cardaddress As String, ByVal cardcity As String, ByVal cardstate As String, ByVal cardpin As String, ByVal cardcountry As String, ByVal cardtype As String, ByVal payvia As String, ByVal cardno As String, ByVal expmm As Integer, ByVal expyy As Integer)
        Try
            cmd.CommandText = "update StudentPreAdmission set SystemDate='" & SystemDate & "',year=" & year & ",fname='" & fname & "',mname='" & mname & "',lname='" & lname & "',name='" & name & "',dob='" & dob & "',sex='" & sex & "',fgname='" & fgname & "',mothername='" & mothername & "',houseno='" & houseno & "',address='" & address & "',city='" & city & "',post='" & post & "',dist='" & dist & "',state='" & state & "',pin='" & pin & "',country='" & country & "',email='" & email & "',homephone='" & homephone & "',workphone='" & workphone & "',fax='" & fax & "',class='" & clas & "',classint=" & classint & ",classstring='" & classstring & "',course='" & course & "',testfee=" & testfee & ",othertestfee=" & othertestfee & ",coursefee=" & coursefee & ",annualincome=" & annualincome & ",payeename='" & payeename & "',bankname='" & bankname & "',bankbrach='" & bankbrach & "',branchaddress='" & branchaddress & "',branchcode='" & branchcode & "',accountno='" & accountno & "',accounttype='" & accounttype & "',micrcode='" & micrcode & "',electronictransfer='" & electronictransfer & "',cardholdername='" & cardholdername & "',cardaddress='" & cardaddress & "',cardcity='" & cardcity & "',cardstate='" & cardstate & "',cardpin='" & cardpin & "',cardcountry='" & cardcountry & "',cardtype='" & cardtype & "',payvia='" & payvia & "',cardno='" & cardno & "',expmm=" & expmm & ",expyy=" & expyy & " where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and serial='" & serial & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateOk = True
        Catch ex As Exception
            UpdateOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal serial As String)
        Try
            cmd.CommandText = "delete from StudentPreAdmission where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & periodd & "' and serial='" & serial & "'"
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