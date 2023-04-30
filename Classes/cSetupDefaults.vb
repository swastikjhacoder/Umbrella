#Region "Class cSetupDefaults..."
Public Class cSetupDefaults
#Region "Declarations..."
    Public AddInstituteDefaultOk As Boolean = False
    Public UpdateInstituteDefaultOk As Boolean = False
    Public AddLibraryDefaultOk As Boolean = False
    Public UpdateLibraryDefaultOk As Boolean = False
    Public AddPayrollDefaultOk As Boolean = False
    Public UpdatePayrollDefaultOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddInstituteDefault(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal alwayspurchase As String, ByVal invoicemessage As String, ByVal ordermessage As String, ByVal gameexpense As String, ByVal customfield1 As String, ByVal customfield2 As String, ByVal customfield3 As String, ByVal customfield4 As String, ByVal customfield5 As String, ByVal checkcustomfield1 As String, ByVal checkcustomfield2 As String, ByVal checkcustomfield3 As String, ByVal checkcustomfield4 As String, ByVal checkcustomfield5 As String, ByVal costmethod As String, ByVal stockglsalesacc As String, ByVal stockglinvacc As String, ByVal stockglcostacc As String, ByVal stockcostingacc As String, ByVal masterglsalesacc As String, ByVal masterglinvacc As String, ByVal masterglcostacc As String, ByVal mastercostingacc As String, ByVal nonstockglsalesacc As String, ByVal nonstockglinvacc As String, ByVal nonstockglcostacc As String, ByVal nonstockcostingacc As String, ByVal descriptionglsalesacc As String, ByVal descriptionglinvacc As String, ByVal descriptionglcostacc As String, ByVal descriptioncostingacc As String, ByVal serviceglsalesacc As String, ByVal serviceglinvacc As String, ByVal serviceglcostacc As String, ByVal servicecostingacc As String, ByVal laborglsalesacc As String, ByVal laborglinvacc As String, ByVal laborglcostacc As String, ByVal laborcostingacc As String, ByVal assemblyglsalesacc As String, ByVal assemblyglinvacc As String, ByVal assemblyglcostacc As String, ByVal assemblycostingacc As String, ByVal activitylsalesacc As String, ByVal activityglinvacc As String, ByVal activityglcostacc As String, ByVal activitycostingacc As String, ByVal chargeglsalesacc As String, ByVal chargeglinvacc As String, ByVal chargeglcostacc As String, ByVal chargecostingacc As String, ByVal glfreightacc As String, ByVal autoid As String, ByVal feesmonth As Integer, ByVal applydiscount As String, ByVal monthlyfeesacc As String, ByVal yearlyfeesacc As String, ByVal libraryfeesacc As String, ByVal latefeesacc As String, ByVal otherfeesacc As String, ByVal examfeesacc As String, ByVal discountfeesacc As String, ByVal bankdepositacc As String, ByVal purchaseorderacc As String, ByVal salesinvoiceacc As String)
        Try
            cmd.CommandText = "insert into DefaultInstitute(InsID,InsName,Period,alwayspurchase,invoicemessage,ordermessage,gameexpense,customfield1,customfield2,customfield3,customfield4,customfield5,checkcustomfield1,checkcustomfield2,checkcustomfield3,checkcustomfield4,checkcustomfield5,costmethod,stockglsalesacc,stockglinvacc,stockglcostacc,stockcostingacc,masterglsalesacc,masterglinvacc,masterglcostacc,mastercostingacc,nonstockglsalesacc,nonstockglinvacc,nonstockglcostacc,nonstockcostingacc,descriptionglsalesacc,descriptionglinvacc,descriptionglcostacc,descriptioncostingacc,serviceglsalesacc,serviceglinvacc,serviceglcostacc,servicecostingacc,laborglsalesacc,laborglinvacc,laborglcostacc,laborcostingacc,assemblyglsalesacc,assemblyglinvacc,assemblyglcostacc,assemblycostingacc,activitylsalesacc,activityglinvacc,activityglcostacc,activitycostingacc,chargeglsalesacc,chargeglinvacc,chargeglcostacc,chargecostingacc,glfreightacc,autoid,feesmonth,applydiscount,monthlyfeesacc,yearlyfeesacc,libraryfeesacc,latefeesacc,otherfeesacc,examfeesacc,discountfeesacc,bankdepositacc,purchaseorderacc,salesinvoiceacc) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & alwayspurchase & "','" & invoicemessage & "','" & ordermessage & "','" & gameexpense & "','" & customfield1 & "','" & customfield2 & "','" & customfield3 & "','" & customfield4 & "','" & customfield5 & "','" & checkcustomfield1 & "','" & checkcustomfield2 & "','" & checkcustomfield3 & "','" & checkcustomfield4 & "','" & checkcustomfield5 & "','" & costmethod & "','" & stockglsalesacc & "','" & stockglinvacc & "','" & stockglcostacc & "','" & stockcostingacc & "','" & masterglsalesacc & "','" & masterglinvacc & "','" & masterglcostacc & "','" & mastercostingacc & "','" & nonstockglsalesacc & "','" & nonstockglinvacc & "','" & nonstockglcostacc & "','" & nonstockcostingacc & "','" & descriptionglsalesacc & "','" & descriptionglinvacc & "','" & descriptionglcostacc & "','" & descriptioncostingacc & "','" & serviceglsalesacc & "','" & serviceglinvacc & "','" & serviceglcostacc & "','" & servicecostingacc & "','" & laborglsalesacc & "','" & laborglinvacc & "','" & laborglcostacc & "','" & laborcostingacc & "','" & assemblyglsalesacc & "','" & assemblyglinvacc & "','" & assemblyglcostacc & "','" & assemblycostingacc & "','" & activitylsalesacc & "','" & activityglinvacc & "','" & activityglcostacc & "','" & activitycostingacc & "','" & chargeglsalesacc & "','" & chargeglinvacc & "','" & chargeglcostacc & "','" & chargecostingacc & "','" & glfreightacc & "','" & autoid & "'," & feesmonth & ",'" & applydiscount & "','" & monthlyfeesacc & "','" & yearlyfeesacc & "','" & libraryfeesacc & "','" & latefeesacc & "','" & otherfeesacc & "','" & examfeesacc & "','" & discountfeesacc & "','" & bankdepositacc & "','" & purchaseorderacc & "','" & salesinvoiceacc & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            AddInstituteDefaultOk = True
        Catch ex As Exception
            dr.Close()
            AddInstituteDefaultOk = False
        End Try
    End Sub

    Public Sub UpdateInstituteDefault(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal alwayspurchase As String, ByVal invoicemessage As String, ByVal ordermessage As String, ByVal gameexpense As String, ByVal customfield1 As String, ByVal customfield2 As String, ByVal customfield3 As String, ByVal customfield4 As String, ByVal customfield5 As String, ByVal checkcustomfield1 As String, ByVal checkcustomfield2 As String, ByVal checkcustomfield3 As String, ByVal checkcustomfield4 As String, ByVal checkcustomfield5 As String, ByVal costmethod As String, ByVal stockglsalesacc As String, ByVal stockglinvacc As String, ByVal stockglcostacc As String, ByVal stockcostingacc As String, ByVal masterglsalesacc As String, ByVal masterglinvacc As String, ByVal masterglcostacc As String, ByVal mastercostingacc As String, ByVal nonstockglsalesacc As String, ByVal nonstockglinvacc As String, ByVal nonstockglcostacc As String, ByVal nonstockcostingacc As String, ByVal descriptionglsalesacc As String, ByVal descriptionglinvacc As String, ByVal descriptionglcostacc As String, ByVal descriptioncostingacc As String, ByVal serviceglsalesacc As String, ByVal serviceglinvacc As String, ByVal serviceglcostacc As String, ByVal servicecostingacc As String, ByVal laborglsalesacc As String, ByVal laborglinvacc As String, ByVal laborglcostacc As String, ByVal laborcostingacc As String, ByVal assemblyglsalesacc As String, ByVal assemblyglinvacc As String, ByVal assemblyglcostacc As String, ByVal assemblycostingacc As String, ByVal activitylsalesacc As String, ByVal activityglinvacc As String, ByVal activityglcostacc As String, ByVal activitycostingacc As String, ByVal chargeglsalesacc As String, ByVal chargeglinvacc As String, ByVal chargeglcostacc As String, ByVal chargecostingacc As String, ByVal glfreightacc As String, ByVal autoid As String, ByVal feesmonth As Integer, ByVal applydiscount As String, ByVal monthlyfeesacc As String, ByVal yearlyfeesacc As String, ByVal libraryfeesacc As String, ByVal latefeesacc As String, ByVal otherfeesacc As String, ByVal examfeesacc As String, ByVal discountfeesacc As String, ByVal bankdepositacc As String, ByVal purchaseorderacc As String, ByVal salesinvoiceacc As String)
        Try
            cmd.CommandText = "update DefaultInstitute set alwayspurchase='" & alwayspurchase & "',invoicemessage='" & invoicemessage & "',ordermessage='" & ordermessage & "',gameexpense='" & gameexpense & "',customfield1='" & customfield1 & "',customfield2='" & customfield2 & "',customfield3='" & customfield3 & "',customfield4='" & customfield4 & "',customfield5='" & customfield5 & "',checkcustomfield1='" & checkcustomfield1 & "',checkcustomfield2='" & checkcustomfield2 & "',checkcustomfield3='" & checkcustomfield3 & "',checkcustomfield4='" & checkcustomfield4 & "',checkcustomfield5='" & checkcustomfield5 & "',costmethod='" & costmethod & "',stockglsalesacc='" & stockglsalesacc & "',stockglinvacc='" & stockglinvacc & "',stockglcostacc='" & stockglcostacc & "',stockcostingacc='" & stockcostingacc & "',masterglsalesacc='" & masterglsalesacc & "',masterglinvacc='" & masterglinvacc & "',masterglcostacc='" & masterglcostacc & "',mastercostingacc='" & mastercostingacc & "',nonstockglsalesacc='" & nonstockglsalesacc & "',nonstockglinvacc='" & nonstockglinvacc & "',nonstockglcostacc='" & nonstockglcostacc & "',nonstockcostingacc='" & nonstockcostingacc & "',descriptionglsalesacc='" & descriptionglsalesacc & "',descriptionglinvacc='" & descriptionglinvacc & "',descriptionglcostacc='" & descriptionglcostacc & "',descriptioncostingacc='" & descriptioncostingacc & "',serviceglsalesacc='" & serviceglsalesacc & "',serviceglinvacc='" & serviceglinvacc & "',serviceglcostacc='" & serviceglcostacc & "',servicecostingacc='" & servicecostingacc & "',laborglsalesacc='" & laborglsalesacc & "',laborglinvacc='" & laborglinvacc & "',laborglcostacc='" & laborglcostacc & "',laborcostingacc='" & laborcostingacc & "',assemblyglsalesacc='" & assemblyglsalesacc & "',assemblyglinvacc='" & assemblyglinvacc & "',assemblyglcostacc='" & assemblyglcostacc & "',assemblycostingacc='" & assemblycostingacc & "',activitylsalesacc='" & activitylsalesacc & "',activityglinvacc='" & activityglinvacc & "',activityglcostacc='" & activityglcostacc & "',activitycostingacc='" & activitycostingacc & "',chargeglsalesacc='" & chargeglsalesacc & "',chargeglinvacc='" & chargeglinvacc & "',chargeglcostacc='" & chargeglcostacc & "',chargecostingacc='" & chargecostingacc & "',glfreightacc='" & glfreightacc & "',autoid='" & autoid & "',feesmonth=" & feesmonth & ",applydiscount='" & applydiscount & "',monthlyfeesacc='" & monthlyfeesacc & "',yearlyfeesacc='" & yearlyfeesacc & "',libraryfeesacc='" & libraryfeesacc & "',latefeesacc='" & latefeesacc & "',otherfeesacc='" & otherfeesacc & "',examfeesacc='" & examfeesacc & "',discountfeesacc='" & discountfeesacc & "',bankdepositacc='" & bankdepositacc & "',purchaseorderacc='" & purchaseorderacc & "',salesinvoiceacc='" & salesinvoiceacc & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateInstituteDefaultOk = True
        Catch ex As Exception
            dr.Close()
            UpdateInstituteDefaultOk = False
        End Try
    End Sub

    Public Sub AddLibraryDefault(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal autoid As String, ByVal chargesaccount As String)
        Try
            cmd.CommandText = "insert into DefaultLibrary(InsID,InsName,Period,autoid,chargesaccount) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & autoid & "','" & chargesaccount & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            AddLibraryDefaultOk = True
        Catch ex As Exception
            AddLibraryDefaultOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateLibraryDefault(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal autoid As String, ByVal chargesaccount As String)
        Try
            cmd.CommandText = "update DefaultLibrary set autoid='" & autoid & "',chargesaccount='" & chargesaccount & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateLibraryDefaultOk = True
        Catch ex As Exception
            UpdateLibraryDefaultOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub AddPayrollDefault(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal autoid As String, ByVal salaryaccount As String, ByVal basicincr As Decimal)
        Try
            cmd.CommandText = "insert into DefaultPayroll(InsID,InsName,Period,autoid,salaryaccount,basicincr) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & autoid & "','" & salaryaccount & "'," & basicincr & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            AddPayrollDefaultOk = True
        Catch ex As Exception
            AddPayrollDefaultOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdatePayrollDefault(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal autoid As String, ByVal salaryaccount As String, ByVal basicincr As Decimal)
        Try
            cmd.CommandText = "update DefaultPayroll set autoid='" & autoid & "',salaryaccount='" & salaryaccount & "',basicincr=" & basicincr & " where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdatePayrollDefaultOk = True
        Catch ex As Exception
            UpdatePayrollDefaultOk = False
            dr.Close()
        End Try
    End Sub
#End Region
End Class
#End Region