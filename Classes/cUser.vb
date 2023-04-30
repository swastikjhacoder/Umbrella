#Region "Class cUser..."
Public Class cUser
#Region "Declarations..."
    Public AddUserOk As Boolean = False
    Public UpdateUserOk As Boolean = False
    Public DeleteUserOk As Boolean = False
    Public ChangePasswordOk As Boolean = False
    Public UpdateUserCrystalReportOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal userno As String, ByVal userrole As String, ByVal userid As String, ByVal userpasswd As String, ByVal useraccess As String, ByVal employeeinfo As String, ByVal employeecard As String, ByVal attendances As String, ByVal idcard As String, ByVal notices As String, ByVal studentcontrol As String, ByVal backuprestore As String, ByVal importexport As String, ByVal studentinfo As String, ByVal studentcard As String, ByVal preadmission As String, ByVal admission As String, ByVal registration As String, ByVal feesterms As String, ByVal bankinginfo As String, ByVal feescollection As String, ByVal discount As String, ByVal incomeexpenditure As String, ByVal accounting As String, ByVal financialloan As String, ByVal coursesubject As String, ByVal examination As String, ByVal progressreport As String, ByVal marksheet As String, ByVal messenger As String, ByVal globalaccess As String, ByVal alumni As String, ByVal certificates As String, ByVal purchaseorder As String, ByVal inventory As String, ByVal salesinvoice As String, ByVal games As String, ByVal bookrecords As String, ByVal charges As String, ByVal issuebooks As String, ByVal returnbooks As String, ByVal payrollsystem As String, ByVal payrollperiodic As String, ByVal payrollpf As String, ByVal institutedefault As String, ByVal librarydefault As String, ByVal payrolldefault As String, ByVal revenueyeartodate As String, ByVal yearend As String)
        Try
            cmd.CommandText = "insert into Users(InsID,InsName,Period,SystemDate,userno,userrole,userid,userpasswd,useraccess,employeeinfo,employeecard,attendances,idcard,notices,studentcontrol,backuprestore,importexport,studentinfo,studentcard,preadmission,admission,registration,feesterms,bankinginfo,feescollection,discount,incomeexpenditure,accounting,financialloan,coursesubject,examination,progressreport,marksheet,messenger,globalaccess,alumni,certificates,purchaseorder,inventory,salesinvoice,games,bookrecords,charges,issuebooks,returnbooks,payrollsystem,payrollperiodic,payrollpf,institutedefault,librarydefault,payrolldefault,revenueyeartodate,yearend) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & userno & "','" & userrole & "','" & userid & "','" & userpasswd & "','" & useraccess & "','" & employeeinfo & "','" & employeecard & "','" & attendances & "','" & idcard & "','" & notices & "','" & studentcontrol & "','" & backuprestore & "','" & importexport & "','" & studentinfo & "','" & studentcard & "','" & preadmission & "','" & admission & "','" & registration & "','" & feesterms & "','" & bankinginfo & "','" & feescollection & "','" & discount & "','" & incomeexpenditure & "','" & accounting & "','" & financialloan & "','" & coursesubject & "','" & examination & "','" & progressreport & "','" & marksheet & "','" & messenger & "','" & globalaccess & "','" & alumni & "','" & certificates & "','" & purchaseorder & "','" & inventory & "','" & salesinvoice & "','" & games & "','" & bookrecords & "','" & charges & "','" & issuebooks & "','" & returnbooks & "','" & payrollsystem & "','" & payrollperiodic & "','" & payrollpf & "','" & institutedefault & "','" & librarydefault & "','" & payrolldefault & "','" & revenueyeartodate & "','" & yearend & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set userid=userid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddUserOk = True
        Catch ex As Exception
            AddUserOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal userno As String, ByVal userrole As String, ByVal userid As String, ByVal employeeinfo As String, ByVal employeecard As String, ByVal attendances As String, ByVal idcard As String, ByVal notices As String, ByVal studentcontrol As String, ByVal backuprestore As String, ByVal importexport As String, ByVal studentinfo As String, ByVal studentcard As String, ByVal preadmission As String, ByVal admission As String, ByVal registration As String, ByVal feesterms As String, ByVal bankinginfo As String, ByVal feescollection As String, ByVal discount As String, ByVal incomeexpenditure As String, ByVal accounting As String, ByVal financialloan As String, ByVal coursesubject As String, ByVal examination As String, ByVal progressreport As String, ByVal marksheet As String, ByVal messenger As String, ByVal globalaccess As String, ByVal alumni As String, ByVal certificates As String, ByVal purchaseorder As String, ByVal inventory As String, ByVal salesinvoice As String, ByVal games As String, ByVal bookrecords As String, ByVal charges As String, ByVal issuebooks As String, ByVal returnbooks As String, ByVal payrollsystem As String, ByVal payrollperiodic As String, ByVal payrollpf As String, ByVal institutedefault As String, ByVal librarydefault As String, ByVal payrolldefault As String, ByVal revenueyeartodate As String, ByVal yearend As String)
        Try
            cmd.CommandText = "update Users set SystemDate='" & SystemDate & "',employeeinfo='" & employeeinfo & "',employeecard='" & employeecard & "',attendances='" & attendances & "',idcard='" & idcard & "',notices='" & notices & "',studentcontrol='" & studentcontrol & "',backuprestore='" & backuprestore & "',importexport='" & importexport & "',studentinfo='" & studentinfo & "',studentcard='" & studentcard & "',preadmission='" & preadmission & "',admission='" & admission & "',registration='" & registration & "',feesterms='" & feesterms & "',bankinginfo='" & bankinginfo & "',feescollection='" & feescollection & "',discount='" & discount & "',incomeexpenditure='" & incomeexpenditure & "',accounting='" & accounting & "',financialloan='" & financialloan & "',coursesubject='" & coursesubject & "',examination='" & examination & "',progressreport='" & progressreport & "',marksheet='" & marksheet & "',messenger='" & messenger & "',globalaccess='" & globalaccess & "',alumni='" & alumni & "',certificates='" & certificates & "',purchaseorder='" & purchaseorder & "',inventory='" & inventory & "',salesinvoice='" & salesinvoice & "',games='" & games & "',bookrecords='" & bookrecords & "',charges='" & charges & "',issuebooks='" & issuebooks & "',returnbooks='" & returnbooks & "',payrollsystem='" & payrollsystem & "',payrollperiodic='" & payrollperiodic & "',payrollpf='" & payrollpf & "',institutedefault='" & institutedefault & "',librarydefault='" & librarydefault & "',payrolldefault='" & payrolldefault & "',revenueyeartodate='" & revenueyeartodate & "',yearend='" & yearend & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and userno='" & userno & "' and userid='" & userid & "' and userrole='" & userrole & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateUserOk = True
        Catch ex As Exception
            UpdateUserOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal userid As String)
        Try
            cmd.CommandText = "delete from Users where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and userid='" & userid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteUserOk = True
        Catch ex As Exception
            DeleteUserOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub ChangeUserPassword(ByVal userpasswd As String, ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal userid As String)
        Try
            cmd.CommandText = "update Users set userpasswd='" & userpasswd & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and userid='" & userid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            ChangePasswordOk = True
        Catch ex As Exception
            ChangePasswordOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateUserCrystalReport(ByVal crystalreport As String, ByVal crystalreportid As String)
        Try
            cmd.CommandText = "update UserCrystalReport set crystalreport='" & crystalreport & "',crystalreportid='" & crystalreportid & "' where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateUserCrystalReportOk = True
        Catch ex As Exception
            UpdateUserCrystalReportOk = False
            dr.Close()
        End Try
    End Sub
#End Region
End Class
#End Region