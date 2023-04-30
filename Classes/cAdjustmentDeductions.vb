#Region "Class cAdjustmentDeductions..."
Public Class cAdjustmentDeductions
#Region "Declarations..."
    Public AddRecordOk As Boolean = False
    Public UpdateRecordOk As Boolean = False
    Public DeleteRecordOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal month As String, ByVal year As Integer, ByVal regno As String, ByVal designation As String, ByVal name As String, ByVal thismonth As Integer, ByVal lastmonth As Integer, ByVal basicadjust As Decimal, ByVal daadjust As Decimal, ByVal hraadjust As Decimal, ByVal otheradjust As Decimal, ByVal ccsadjust As Decimal, ByVal incometaxadjust As Decimal, ByVal salaryadjust As Decimal, ByVal conveyancealw As Decimal, ByVal handicappedalw As Decimal, ByVal washingalw As Decimal, ByVal pfdeduction As Decimal, ByVal conveyancealwrs As Decimal, ByVal handicappedalwrs As Decimal, ByVal washingalwrs As Decimal, ByVal pfdeductionrs As Decimal, ByVal specialpay As Decimal, ByVal gslideduction As Decimal, ByVal houserent As Decimal, ByVal pfadvancerecovery As Decimal, ByVal ccsloan As Decimal, ByVal otherbankloan As Decimal, ByVal festivaladvance As Decimal, ByVal ccspo1loan As Decimal, ByVal ccspo2loan As Decimal, ByVal bankloan As Decimal, ByVal ppfloan As Decimal, ByVal stopincrement As String, ByVal paywithheld As String)
        Try
            cmd.CommandText = "insert into AdjustmentDeductions(InsID,InsName,Period,month,year,regno,designation,name,thismonth,lastmonth,basicadjust,daadjust,hraadjust,otheradjust,ccsadjust,incometaxadjust,salaryadjust,conveyancealw,handicappedalw,washingalw,pfdeduction,conveyancealwrs,handicappedalwrs,washingalwrs,pfdeductionrs,specialpay,gslideduction,houserent,pfadvancerecovery,ccsloan,otherbankloan,festivaladvance,ccspo1loan,ccspo2loan,bankloan,ppfloan,stopincrement,paywithheld) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & month & "'," & year & ",'" & regno & "','" & designation & "','" & name & "'," & thismonth & "," & lastmonth & "," & basicadjust & "," & daadjust & "," & hraadjust & "," & otheradjust & "," & ccsadjust & "," & incometaxadjust & "," & salaryadjust & "," & conveyancealw & "," & handicappedalw & "," & washingalw & "," & pfdeduction & "," & conveyancealwrs & "," & handicappedalwrs & "," & washingalwrs & "," & pfdeductionrs & "," & specialpay & "," & gslideduction & "," & houserent & "," & pfadvancerecovery & "," & ccsloan & "," & otherbankloan & "," & festivaladvance & "," & ccspo1loan & "," & ccspo2loan & "," & bankloan & "," & ppfloan & ",'" & stopincrement & "','" & paywithheld & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            AddRecordOk = True
        Catch ex As Exception
            AddRecordOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal month As String, ByVal year As Integer, ByVal regno As String, ByVal designation As String, ByVal name As String, ByVal thismonth As Integer, ByVal lastmonth As Integer, ByVal basicadjust As Decimal, ByVal daadjust As Decimal, ByVal hraadjust As Decimal, ByVal otheradjust As Decimal, ByVal ccsadjust As Decimal, ByVal incometaxadjust As Decimal, ByVal salaryadjust As Decimal, ByVal conveyancealw As Decimal, ByVal handicappedalw As Decimal, ByVal washingalw As Decimal, ByVal pfdeduction As Decimal, ByVal conveyancealwrs As Decimal, ByVal handicappedalwrs As Decimal, ByVal washingalwrs As Decimal, ByVal pfdeductionrs As Decimal, ByVal specialpay As Decimal, ByVal gslideduction As Decimal, ByVal houserent As Decimal, ByVal pfadvancerecovery As Decimal, ByVal ccsloan As Decimal, ByVal otherbankloan As Decimal, ByVal festivaladvance As Decimal, ByVal ccspo1loan As Decimal, ByVal ccspo2loan As Decimal, ByVal bankloan As Decimal, ByVal ppfloan As Decimal, ByVal stopincrement As String, ByVal paywithheld As String)
        Try
            cmd.CommandText = "update AdjustmentDeductions set thismonth=" & thismonth & ",lastmonth=" & lastmonth & ",basicadjust=" & basicadjust & ",daadjust=" & daadjust & ",hraadjust=" & hraadjust & ",otheradjust=" & otheradjust & ",ccsadjust=" & ccsadjust & ",incometaxadjust=" & incometaxadjust & ",salaryadjust=" & salaryadjust & ",conveyancealw=" & conveyancealw & ",handicappedalw=" & handicappedalw & ",washingalw=" & washingalw & ",pfdeduction=" & pfdeduction & ",conveyancealwrs=" & conveyancealwrs & ",handicappedalwrs=" & handicappedalwrs & ",washingalwrs=" & washingalwrs & ",pfdeductionrs=" & pfdeductionrs & ",specialpay=" & specialpay & ",gslideduction=" & gslideduction & ",houserent=" & houserent & ",pfadvancerecovery=" & pfadvancerecovery & ",ccsloan=" & ccsloan & ",otherbankloan=" & otherbankloan & ",festivaladvance=" & festivaladvance & ",ccspo1loan=" & ccspo1loan & ",ccspo2loan=" & ccspo2loan & ",bankloan=" & bankloan & ",ppfloan=" & ppfloan & ",stopincrement='" & stopincrement & "',paywithheld='" & paywithheld & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and month='" & month & "' and year=" & year & " and regno='" & regno & "' and designation='" & designation & "' and name='" & name & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateRecordOk = True
        Catch ex As Exception
            UpdateRecordOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal month As String, ByVal year As Integer, ByVal regno As String, ByVal designation As String, ByVal name As String)
        Try
            cmd.CommandText = "delete from AdjustmentDeductions where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and month='" & month & "' and year=" & year & " and regno='" & regno & "' and designation='" & designation & "' and name='" & name & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteRecordOk = True
        Catch ex As Exception
            DeleteRecordOk = False
            dr.Close()
        End Try
    End Sub
#End Region
End Class
#End Region