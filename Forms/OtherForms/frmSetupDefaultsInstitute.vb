#Region "Class frmSetupDefaultsInstitute..."
Public Class frmSetupDefaultsInstitute
#Region "Declarations..."
    Private DGVGame As New DataGridView()
    Private DGVGLFreight As New DataGridView()
    Private DGVStockGLSales As New DataGridView()
    Private DGVStockGLInv As New DataGridView()
    Private DGVStockGLCost As New DataGridView()
    Private DGVStockCosting As New DataGridView()
    Private DGVMasterGLSales As New DataGridView()
    Private DGVMasterGLInv As New DataGridView()
    Private DGVMasterGLCost As New DataGridView()
    Private DGVMasterCosting As New DataGridView()
    Private DGVNonStockGLSales As New DataGridView()
    Private DGVNonStockGLInv As New DataGridView()
    Private DGVNonStockGLCost As New DataGridView()
    Private DGVNonStockCosting As New DataGridView()
    Private DGVDescriptionGLSales As New DataGridView()
    Private DGVDescriptionGLInv As New DataGridView()
    Private DGVDescriptionGLCost As New DataGridView()
    Private DGVDescriptionCosting As New DataGridView()
    Private DGVServiceGLSales As New DataGridView()
    Private DGVServiceGLInv As New DataGridView()
    Private DGVServiceGLCost As New DataGridView()
    Private DGVServiceCosting As New DataGridView()
    Private DGVLaborGLSales As New DataGridView()
    Private DGVLaborGLInv As New DataGridView()
    Private DGVLaborGLCost As New DataGridView()
    Private DGVLaborCosting As New DataGridView()
    Private DGVAssemblyGLSales As New DataGridView()
    Private DGVAssemblyGLInv As New DataGridView()
    Private DGVAssemblyGLCost As New DataGridView()
    Private DGVAssemblyCosting As New DataGridView()
    Private DGVActivityGLSales As New DataGridView()
    Private DGVActivityGLInv As New DataGridView()
    Private DGVActivityGLCost As New DataGridView()
    Private DGVActivityCosting As New DataGridView()
    Private DGVChargeGLSales As New DataGridView()
    Private DGVChargeGLInv As New DataGridView()
    Private DGVChargeGLCost As New DataGridView()
    Private DGVChargeCosting As New DataGridView()
    Private DGVMonthlyFees As New DataGridView()
    Private DGVYearlyFees As New DataGridView()
    Private DGVLibraryFees As New DataGridView()
    Private DGVLateFees As New DataGridView()
    Private DGVOtherFees As New DataGridView()
    Private DGVExamFees As New DataGridView()
    Private DGVDiscount As New DataGridView()
    Private DGVBankDeposit As New DataGridView()
    Private DGVPurchaseOrder As New DataGridView()
    Private DGVSalesInvoice As New DataGridView()
    Private alwayspurchase As String = ""
    Private invoicemessage As String = ""
    Private ordermessage As String = ""
    Private gameexpense As String = ""
    Private customfield1 As String = ""
    Private customfield2 As String = ""
    Private customfield3 As String = ""
    Private customfield4 As String = ""
    Private customfield5 As String = ""
    Private checkcustomfield1 As String = ""
    Private checkcustomfield2 As String = ""
    Private checkcustomfield3 As String = ""
    Private checkcustomfield4 As String = ""
    Private checkcustomfield5 As String = ""
    Private costmethod As String = ""
    Private stockglsalesacc As String = ""
    Private stockglinvacc As String = ""
    Private stockglcostacc As String = ""
    Private stockcostingacc As String = ""
    Private masterglsalesacc As String = ""
    Private masterglinvacc As String = ""
    Private masterglcostacc As String = ""
    Private mastercostingacc As String = ""
    Private nonstockglsalesacc As String = ""
    Private nonstockglinvacc As String = ""
    Private nonstockglcostacc As String = ""
    Private nonstockcostingacc As String = ""
    Private descriptionglsalesacc As String = ""
    Private descriptionglinvacc As String = ""
    Private descriptionglcostacc As String = ""
    Private descriptioncostingacc As String = ""
    Private serviceglsalesacc As String = ""
    Private serviceglinvacc As String = ""
    Private serviceglcostacc As String = ""
    Private servicecostingacc As String = ""
    Private laborglsalesacc As String = ""
    Private laborglinvacc As String = ""
    Private laborglcostacc As String = ""
    Private laborcostingacc As String = ""
    Private assemblyglsalesacc As String = ""
    Private assemblyglinvacc As String = ""
    Private assemblyglcostacc As String = ""
    Private assemblycostingacc As String = ""
    Private activitylsalesacc As String = ""
    Private activityglinvacc As String = ""
    Private activityglcostacc As String = ""
    Private activitycostingacc As String = ""
    Private chargeglsalesacc As String = ""
    Private chargeglinvacc As String = ""
    Private chargeglcostacc As String = ""
    Private chargecostingacc As String = ""
    Private glfreightacc As String = ""
    Private autoid As String = ""
    Private feesmonth As Integer = 1
    Private applydiscount As String = ""
    Private monthlyfeesacc As String = ""
    Private yearlyfeesacc As String = ""
    Private libraryfeesacc As String = ""
    Private latefeesacc As String = ""
    Private otherfeesacc As String = ""
    Private examfeesacc As String = ""
    Private discountfeesacc As String = ""
    Private bankdepositacc As String = ""
    Private purchaseorderacc As String = ""
    Private salesinvoiceacc As String = ""
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(41, 19, 73, 13)
        Label10.SetBounds(233, 32, 97, 13)
        Label11.SetBounds(337, 32, 87, 13)
        Label12.SetBounds(441, 32, 50, 13)
        Label13.SetBounds(8, 54, 75, 13)
        Label14.SetBounds(8, 81, 117, 13)
        Label15.SetBounds(8, 108, 101, 13)
        Label16.SetBounds(8, 135, 106, 13)
        Label17.SetBounds(8, 162, 55, 13)
        Label18.SetBounds(8, 189, 44, 13)
        Label19.SetBounds(8, 216, 67, 13)
        Label2.SetBounds(211, 19, 52, 13)
        Label20.SetBounds(8, 243, 54, 13)
        Label21.SetBounds(8, 270, 85, 13)
        Label22.SetBounds(8, 322, 98, 13)
        Label23.SetBounds(218, 322, 312, 13)
        Label24.SetBounds(543, 99, 136, 130)
        Label26.SetBounds(21, 90, 419, 13)
        Label25.SetBounds(41, 59, 83, 13)
        Label27.SetBounds(44, 47, 104, 13)
        Label28.SetBounds(314, 47, 331, 13)
        Label29.SetBounds(26, 40, 239, 13)
        Label3.SetBounds(21, 41, 18, 13)
        Label30.SetBounds(26, 68, 302, 13)
        Label31.SetBounds(36, 34, 203, 13)
        Label32.SetBounds(36, 61, 194, 13)
        Label33.SetBounds(36, 88, 199, 13)
        Label34.SetBounds(36, 115, 183, 13)
        Label35.SetBounds(36, 142, 191, 13)
        Label36.SetBounds(36, 169, 208, 13)
        Label37.SetBounds(36, 196, 191, 13)
        Label38.SetBounds(36, 223, 205, 13)
        Label39.SetBounds(36, 250, 147, 13)
        Label4.SetBounds(21, 68, 18, 13)
        Label40.SetBounds(36, 277, 135, 13)
        Label5.SetBounds(21, 95, 18, 13)
        Label6.SetBounds(21, 122, 18, 13)
        Label7.SetBounds(21, 149, 18, 13)
        Label8.SetBounds(17, 196, 544, 26)
        Label9.SetBounds(129, 32, 84, 13)

        nudfeesmonth.SetBounds(361, 38, 58, 21)

        chkautuid.SetBounds(29, 34, 487, 17)
        chkpurchaseorder.SetBounds(20, 32, 372, 17)
        chkcustomfield1.SetBounds(217, 41, 15, 14)
        chkcustomfield2.SetBounds(217, 67, 15, 14)
        chkcustomfield3.SetBounds(217, 95, 15, 14)
        chkcustomfield4.SetBounds(217, 122, 15, 14)
        chkcustomfield5.SetBounds(217, 149, 15, 14)

        rbtnsalesinvoice1.SetBounds(20, 31, 117, 17)
        rbtnsalesinvoice2.SetBounds(20, 54, 396, 17)
        rbtnsalesinvoice3.SetBounds(20, 77, 401, 17)
        rbtnsalesorder3.SetBounds(20, 31, 117, 17)
        rbtnsalesorder2.SetBounds(20, 54, 396, 17)
        rbtnsalesorder1.SetBounds(20, 77, 401, 17)

        txtcustomfield1.SetBounds(44, 38, 165, 21)
        txtcustomfield2.SetBounds(44, 65, 165, 21)
        txtcustomfield3.SetBounds(44, 92, 165, 21)
        txtcustomfield4.SetBounds(44, 119, 165, 21)
        txtcustomfield5.SetBounds(44, 146, 165, 21)

        cmbapplydiscount.SetBounds(361, 65, 58, 21)
        cmbcostmethod.SetBounds(130, 56, 102, 21)
        cmbgameaccount.SetBounds(174, 44, 121, 21)
        cmbstockglsales.SetBounds(127, 51, 86, 21)
        cmbstockglinv.SetBounds(236, 51, 86, 21)
        cmbstockglcost.SetBounds(338, 51, 86, 21)
        cmbstockcosting.SetBounds(444, 51, 86, 21)
        cmbnonglcost.SetBounds(338, 105, 86, 21)
        cmbnonglinv.SetBounds(236, 105, 86, 21)
        cmbnonglsales.SetBounds(127, 105, 86, 21)
        cmbdesccosting.SetBounds(444, 132, 86, 21)
        cmbdescglcost.SetBounds(338, 132, 86, 21)
        cmbdescglinv.SetBounds(236, 132, 86, 21)
        cmbdescglsales.SetBounds(127, 132, 86, 21)
        cmbservicecosting.SetBounds(444, 159, 86, 21)
        cmbserviceglcost.SetBounds(338, 159, 86, 21)
        cmbserviceglinv.SetBounds(236, 159, 86, 21)
        cmbserviceglsales.SetBounds(127, 159, 86, 21)
        cmblaborcosting.SetBounds(444, 186, 86, 21)
        cmblaborglcost.SetBounds(338, 186, 86, 21)
        cmblaborglinv.SetBounds(236, 186, 86, 21)
        cmblaborglsales.SetBounds(127, 186, 86, 21)
        cmbassemblycosting.SetBounds(444, 213, 86, 21)
        cmbassemblyglcost.SetBounds(338, 213, 86, 21)
        cmbassemblyglinv.SetBounds(236, 213, 86, 21)
        cmbassemblyglsales.SetBounds(127, 213, 86, 21)
        cmbactivitycosting.SetBounds(444, 240, 86, 21)
        cmbactivityglcost.SetBounds(338, 240, 86, 21)
        cmbactivityglinv.SetBounds(236, 240, 86, 21)
        cmbactivityglsales.SetBounds(127, 240, 86, 21)
        cmbchargecosting.SetBounds(444, 267, 86, 21)
        cmbchargeglcost.SetBounds(338, 267, 86, 21)
        cmbchargeglinv.SetBounds(236, 267, 86, 21)
        cmbchargeglsales.SetBounds(127, 267, 86, 21)
        cmbglfreight.SetBounds(127, 319, 86, 21)
        cmbmastercosting.SetBounds(444, 78, 86, 21)
        cmbmasterglcost.SetBounds(338, 78, 86, 21)
        cmbmasterglinv.SetBounds(236, 78, 86, 21)
        cmbmasterglsales.SetBounds(127, 78, 86, 21)
        cmbnoncosting.SetBounds(444, 105, 86, 21)
        cmbmonthlyfeesacc.SetBounds(250, 31, 86, 21)
        cmbyearlyfeesacc.SetBounds(250, 58, 86, 21)
        cmblibraryfeesacc.SetBounds(250, 85, 86, 21)
        cmblatefeesacc.SetBounds(250, 112, 86, 21)
        cmbotherfeesacc.SetBounds(250, 139, 86, 21)
        cmbexamfeesacc.SetBounds(250, 193, 86, 21)
        cmbdiscountfeesacc.SetBounds(250, 166, 86, 21)
        cmbbankdepositacc.SetBounds(250, 220, 86, 21)
        cmbpurchaseorderacc.SetBounds(250, 247, 86, 21)
        cmbsalesinvoiceacc.SetBounds(250, 274, 86, 21)
    End Sub

    Private Sub LoadAccounts()
        Try

            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .Name = "Col1"
                .HeaderText = "Account No."
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .Name = "Col2"
                .HeaderText = "Account Name"
            End With
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .Name = "Col3"
                .HeaderText = "Balance"
            End With

            Dim col4 As New DataGridViewLinkColumn()
            With col4
                .Name = "Col4"
                .HeaderText = "Account No."
            End With
            Dim col5 As New DataGridViewTextBoxColumn()
            With col5
                .Name = "Col5"
                .HeaderText = "Account Name"
            End With
            Dim col6 As New DataGridViewTextBoxColumn()
            With col6
                .Name = "Col6"
                .HeaderText = "Balance"
            End With

            Dim col7 As New DataGridViewLinkColumn()
            With col7
                .Name = "Col7"
                .HeaderText = "Account No."
            End With
            Dim col8 As New DataGridViewTextBoxColumn()
            With col8
                .Name = "Col8"
                .HeaderText = "Account Name"
            End With
            Dim col9 As New DataGridViewTextBoxColumn()
            With col9
                .Name = "Col9"
                .HeaderText = "Balance"
            End With

            Dim col10 As New DataGridViewLinkColumn()
            With col10
                .Name = "Col10"
                .HeaderText = "Account No."
            End With
            Dim col11 As New DataGridViewTextBoxColumn()
            With col11
                .Name = "Col11"
                .HeaderText = "Account Name"
            End With
            Dim col12 As New DataGridViewTextBoxColumn()
            With col12
                .Name = "Col12"
                .HeaderText = "Balance"
            End With

            Dim col13 As New DataGridViewLinkColumn()
            With col13
                .Name = "Col13"
                .HeaderText = "Account No."
            End With
            Dim col14 As New DataGridViewTextBoxColumn()
            With col14
                .Name = "Col14"
                .HeaderText = "Account Name"
            End With
            Dim col15 As New DataGridViewTextBoxColumn()
            With col15
                .Name = "Col15"
                .HeaderText = "Balance"
            End With

            Dim col16 As New DataGridViewLinkColumn()
            With col16
                .Name = "Col16"
                .HeaderText = "Account No."
            End With
            Dim col17 As New DataGridViewTextBoxColumn()
            With col17
                .Name = "Col17"
                .HeaderText = "Account Name"
            End With
            Dim col18 As New DataGridViewTextBoxColumn()
            With col18
                .Name = "Col18"
                .HeaderText = "Balance"
            End With

            Dim col19 As New DataGridViewLinkColumn()
            With col19
                .Name = "Col19"
                .HeaderText = "Account No."
            End With
            Dim col20 As New DataGridViewTextBoxColumn()
            With col20
                .Name = "Col20"
                .HeaderText = "Account Name"
            End With
            Dim col21 As New DataGridViewTextBoxColumn()
            With col21
                .Name = "Col21"
                .HeaderText = "Balance"
            End With

            Dim col22 As New DataGridViewLinkColumn()
            With col22
                .Name = "Col22"
                .HeaderText = "Account No."
            End With
            Dim col23 As New DataGridViewTextBoxColumn()
            With col23
                .Name = "Col23"
                .HeaderText = "Account Name"
            End With
            Dim col24 As New DataGridViewTextBoxColumn()
            With col24
                .Name = "Col24"
                .HeaderText = "Balance"
            End With

            Dim col25 As New DataGridViewLinkColumn()
            With col25
                .Name = "Col25"
                .HeaderText = "Account No."
            End With
            Dim col26 As New DataGridViewTextBoxColumn()
            With col26
                .Name = "Col26"
                .HeaderText = "Account Name"
            End With
            Dim col27 As New DataGridViewTextBoxColumn()
            With col27
                .Name = "Col27"
                .HeaderText = "Balance"
            End With

            Dim col28 As New DataGridViewLinkColumn()
            With col28
                .Name = "Col28"
                .HeaderText = "Account No."
            End With
            Dim col29 As New DataGridViewTextBoxColumn()
            With col29
                .Name = "Col29"
                .HeaderText = "Account Name"
            End With
            Dim col30 As New DataGridViewTextBoxColumn()
            With col30
                .Name = "Col30"
                .HeaderText = "Balance"
            End With

            Dim col31 As New DataGridViewLinkColumn()
            With col31
                .Name = "Col31"
                .HeaderText = "Account No."
            End With
            Dim col32 As New DataGridViewTextBoxColumn()
            With col32
                .Name = "Col32"
                .HeaderText = "Account Name"
            End With
            Dim col33 As New DataGridViewTextBoxColumn()
            With col33
                .Name = "Col33"
                .HeaderText = "Balance"
            End With

            Dim col34 As New DataGridViewLinkColumn()
            With col34
                .Name = "Col34"
                .HeaderText = "Account No."
            End With
            Dim col35 As New DataGridViewTextBoxColumn()
            With col35
                .Name = "Col35"
                .HeaderText = "Account Name"
            End With
            Dim col36 As New DataGridViewTextBoxColumn()
            With col36
                .Name = "Col36"
                .HeaderText = "Balance"
            End With

            Dim col37 As New DataGridViewLinkColumn()
            With col37
                .Name = "Col37"
                .HeaderText = "Account No."
            End With
            Dim col38 As New DataGridViewTextBoxColumn()
            With col38
                .Name = "Col38"
                .HeaderText = "Account Name"
            End With
            Dim col39 As New DataGridViewTextBoxColumn()
            With col39
                .Name = "Col39"
                .HeaderText = "Balance"
            End With

            Dim col40 As New DataGridViewLinkColumn()
            With col40
                .Name = "Col40"
                .HeaderText = "Account No."
            End With
            Dim col41 As New DataGridViewTextBoxColumn()
            With col41
                .Name = "Col41"
                .HeaderText = "Account Name"
            End With
            Dim col42 As New DataGridViewTextBoxColumn()
            With col42
                .Name = "Col42"
                .HeaderText = "Balance"
            End With

            Dim col43 As New DataGridViewLinkColumn()
            With col43
                .Name = "Col43"
                .HeaderText = "Account No."
            End With
            Dim col44 As New DataGridViewTextBoxColumn()
            With col44
                .Name = "Col44"
                .HeaderText = "Account Name"
            End With
            Dim col45 As New DataGridViewTextBoxColumn()
            With col45
                .Name = "Col45"
                .HeaderText = "Balance"
            End With

            Dim col46 As New DataGridViewLinkColumn()
            With col46
                .Name = "Col46"
                .HeaderText = "Account No."
            End With
            Dim col47 As New DataGridViewTextBoxColumn()
            With col47
                .Name = "Col47"
                .HeaderText = "Account Name"
            End With
            Dim col48 As New DataGridViewTextBoxColumn()
            With col48
                .Name = "Col48"
                .HeaderText = "Balance"
            End With

            Dim col49 As New DataGridViewLinkColumn()
            With col49
                .Name = "Col49"
                .HeaderText = "Account No."
            End With
            Dim col50 As New DataGridViewTextBoxColumn()
            With col50
                .Name = "Col50"
                .HeaderText = "Account Name"
            End With
            Dim col51 As New DataGridViewTextBoxColumn()
            With col51
                .Name = "Col51"
                .HeaderText = "Balance"
            End With

            Dim col52 As New DataGridViewLinkColumn()
            With col52
                .Name = "Col52"
                .HeaderText = "Account No."
            End With
            Dim col53 As New DataGridViewTextBoxColumn()
            With col53
                .Name = "Col53"
                .HeaderText = "Account Name"
            End With
            Dim col54 As New DataGridViewTextBoxColumn()
            With col54
                .Name = "Col54"
                .HeaderText = "Balance"
            End With

            Dim col55 As New DataGridViewLinkColumn()
            With col55
                .Name = "Col55"
                .HeaderText = "Account No."
            End With
            Dim col56 As New DataGridViewTextBoxColumn()
            With col56
                .Name = "Col56"
                .HeaderText = "Account Name"
            End With
            Dim col57 As New DataGridViewTextBoxColumn()
            With col57
                .Name = "Col57"
                .HeaderText = "Balance"
            End With

            Dim col58 As New DataGridViewLinkColumn()
            With col58
                .Name = "Col58"
                .HeaderText = "Account No."
            End With
            Dim col59 As New DataGridViewTextBoxColumn()
            With col59
                .Name = "Col59"
                .HeaderText = "Account Name"
            End With
            Dim col60 As New DataGridViewTextBoxColumn()
            With col60
                .Name = "Col60"
                .HeaderText = "Balance"
            End With

            Dim col61 As New DataGridViewLinkColumn()
            With col61
                .Name = "Col61"
                .HeaderText = "Account No."
            End With
            Dim col62 As New DataGridViewTextBoxColumn()
            With col62
                .Name = "Col62"
                .HeaderText = "Account Name"
            End With
            Dim col63 As New DataGridViewTextBoxColumn()
            With col63
                .Name = "Col63"
                .HeaderText = "Balance"
            End With

            Dim col64 As New DataGridViewLinkColumn()
            With col64
                .Name = "Col64"
                .HeaderText = "Account No."
            End With
            Dim col65 As New DataGridViewTextBoxColumn()
            With col65
                .Name = "Col65"
                .HeaderText = "Account Name"
            End With
            Dim col66 As New DataGridViewTextBoxColumn()
            With col66
                .Name = "Col66"
                .HeaderText = "Balance"
            End With

            Dim col67 As New DataGridViewLinkColumn()
            With col67
                .Name = "Col67"
                .HeaderText = "Account No."
            End With
            Dim col68 As New DataGridViewTextBoxColumn()
            With col68
                .Name = "Col68"
                .HeaderText = "Account Name"
            End With
            Dim col69 As New DataGridViewTextBoxColumn()
            With col69
                .Name = "Col69"
                .HeaderText = "Balance"
            End With

            Dim col70 As New DataGridViewLinkColumn()
            With col70
                .Name = "Col70"
                .HeaderText = "Account No."
            End With
            Dim col71 As New DataGridViewTextBoxColumn()
            With col71
                .Name = "Col71"
                .HeaderText = "Account Name"
            End With
            Dim col72 As New DataGridViewTextBoxColumn()
            With col72
                .Name = "Col72"
                .HeaderText = "Balance"
            End With

            Dim col73 As New DataGridViewLinkColumn()
            With col73
                .Name = "Col73"
                .HeaderText = "Account No."
            End With
            Dim col74 As New DataGridViewTextBoxColumn()
            With col74
                .Name = "Col74"
                .HeaderText = "Account Name"
            End With
            Dim col75 As New DataGridViewTextBoxColumn()
            With col75
                .Name = "Col75"
                .HeaderText = "Balance"
            End With

            Dim col76 As New DataGridViewLinkColumn()
            With col76
                .Name = "Col76"
                .HeaderText = "Account No."
            End With
            Dim col77 As New DataGridViewTextBoxColumn()
            With col77
                .Name = "Col77"
                .HeaderText = "Account Name"
            End With
            Dim col78 As New DataGridViewTextBoxColumn()
            With col78
                .Name = "Col78"
                .HeaderText = "Balance"
            End With

            Dim col79 As New DataGridViewLinkColumn()
            With col79
                .Name = "Col79"
                .HeaderText = "Account No."
            End With
            Dim col80 As New DataGridViewTextBoxColumn()
            With col80
                .Name = "Col80"
                .HeaderText = "Account Name"
            End With
            Dim col81 As New DataGridViewTextBoxColumn()
            With col81
                .Name = "Col81"
                .HeaderText = "Balance"
            End With

            Dim col82 As New DataGridViewLinkColumn()
            With col82
                .Name = "Col82"
                .HeaderText = "Account No."
            End With
            Dim col83 As New DataGridViewTextBoxColumn()
            With col83
                .Name = "Col83"
                .HeaderText = "Account Name"
            End With
            Dim col84 As New DataGridViewTextBoxColumn()
            With col84
                .Name = "Col84"
                .HeaderText = "Balance"
            End With

            Dim col85 As New DataGridViewLinkColumn()
            With col85
                .Name = "Col85"
                .HeaderText = "Account No."
            End With
            Dim col86 As New DataGridViewTextBoxColumn()
            With col86
                .Name = "Col86"
                .HeaderText = "Account Name"
            End With
            Dim col87 As New DataGridViewTextBoxColumn()
            With col87
                .Name = "Col87"
                .HeaderText = "Balance"
            End With

            Dim col88 As New DataGridViewLinkColumn()
            With col88
                .Name = "Col88"
                .HeaderText = "Account No."
            End With
            Dim col89 As New DataGridViewTextBoxColumn()
            With col89
                .Name = "Col89"
                .HeaderText = "Account Name"
            End With
            Dim col90 As New DataGridViewTextBoxColumn()
            With col90
                .Name = "Col90"
                .HeaderText = "Balance"
            End With

            Dim col91 As New DataGridViewLinkColumn()
            With col91
                .Name = "Col91"
                .HeaderText = "Account No."
            End With
            Dim col92 As New DataGridViewTextBoxColumn()
            With col92
                .Name = "Col92"
                .HeaderText = "Account Name"
            End With
            Dim col93 As New DataGridViewTextBoxColumn()
            With col93
                .Name = "Col93"
                .HeaderText = "Balance"
            End With

            Dim col94 As New DataGridViewLinkColumn()
            With col94
                .Name = "Col94"
                .HeaderText = "Account No."
            End With
            Dim col95 As New DataGridViewTextBoxColumn()
            With col95
                .Name = "Col95"
                .HeaderText = "Account Name"
            End With
            Dim col96 As New DataGridViewTextBoxColumn()
            With col96
                .Name = "Col96"
                .HeaderText = "Balance"
            End With

            Dim col97 As New DataGridViewLinkColumn()
            With col97
                .Name = "Col97"
                .HeaderText = "Account No."
            End With
            Dim col98 As New DataGridViewTextBoxColumn()
            With col98
                .Name = "Col98"
                .HeaderText = "Account Name"
            End With
            Dim col99 As New DataGridViewTextBoxColumn()
            With col99
                .Name = "Col99"
                .HeaderText = "Balance"
            End With

            Dim col100 As New DataGridViewLinkColumn()
            With col100
                .Name = "Col100"
                .HeaderText = "Account No."
            End With
            Dim col101 As New DataGridViewTextBoxColumn()
            With col101
                .Name = "Col101"
                .HeaderText = "Account Name"
            End With
            Dim col102 As New DataGridViewTextBoxColumn()
            With col102
                .Name = "Col102"
                .HeaderText = "Balance"
            End With

            Dim col103 As New DataGridViewLinkColumn()
            With col103
                .Name = "Col103"
                .HeaderText = "Account No."
            End With
            Dim col104 As New DataGridViewTextBoxColumn()
            With col104
                .Name = "Col104"
                .HeaderText = "Account Name"
            End With
            Dim col105 As New DataGridViewTextBoxColumn()
            With col105
                .Name = "Col105"
                .HeaderText = "Balance"
            End With

            Dim col106 As New DataGridViewLinkColumn()
            With col106
                .Name = "Col106"
                .HeaderText = "Account No."
            End With
            Dim col107 As New DataGridViewTextBoxColumn()
            With col107
                .Name = "Col107"
                .HeaderText = "Account Name"
            End With
            Dim col108 As New DataGridViewTextBoxColumn()
            With col108
                .Name = "Col108"
                .HeaderText = "Balance"
            End With

            Dim col109 As New DataGridViewLinkColumn()
            With col109
                .Name = "Col109"
                .HeaderText = "Account No."
            End With
            Dim col110 As New DataGridViewTextBoxColumn()
            With col110
                .Name = "Col110"
                .HeaderText = "Account Name"
            End With
            Dim col111 As New DataGridViewTextBoxColumn()
            With col111
                .Name = "Col111"
                .HeaderText = "Balance"
            End With

            Dim col112 As New DataGridViewLinkColumn()
            With col112
                .Name = "Col112"
                .HeaderText = "Account No."
            End With
            Dim col113 As New DataGridViewTextBoxColumn()
            With col113
                .Name = "Col113"
                .HeaderText = "Account Name"
            End With
            Dim col114 As New DataGridViewTextBoxColumn()
            With col114
                .Name = "Col114"
                .HeaderText = "Balance"
            End With

            Dim col115 As New DataGridViewLinkColumn()
            With col115
                .Name = "Col115"
                .HeaderText = "Account No."
            End With
            Dim col116 As New DataGridViewTextBoxColumn()
            With col116
                .Name = "Col116"
                .HeaderText = "Account Name"
            End With
            Dim col117 As New DataGridViewTextBoxColumn()
            With col117
                .Name = "Col117"
                .HeaderText = "Balance"
            End With

            Dim col118 As New DataGridViewLinkColumn()
            With col118
                .Name = "Col118"
                .HeaderText = "Account No."
            End With
            Dim col119 As New DataGridViewTextBoxColumn()
            With col119
                .Name = "Col119"
                .HeaderText = "Account Name"
            End With
            Dim col120 As New DataGridViewTextBoxColumn()
            With col120
                .Name = "Col120"
                .HeaderText = "Balance"
            End With

            Dim col121 As New DataGridViewLinkColumn()
            With col121
                .Name = "Col121"
                .HeaderText = "Account No."
            End With
            Dim col122 As New DataGridViewTextBoxColumn()
            With col122
                .Name = "Col122"
                .HeaderText = "Account Name"
            End With
            Dim col123 As New DataGridViewTextBoxColumn()
            With col123
                .Name = "Col123"
                .HeaderText = "Balance"
            End With

            Dim col124 As New DataGridViewLinkColumn()
            With col124
                .Name = "Col124"
                .HeaderText = "Account No."
            End With
            Dim col125 As New DataGridViewTextBoxColumn()
            With col125
                .Name = "Col125"
                .HeaderText = "Account Name"
            End With
            Dim col126 As New DataGridViewTextBoxColumn()
            With col126
                .Name = "Col126"
                .HeaderText = "Balance"
            End With

            Dim col127 As New DataGridViewLinkColumn()
            With col127
                .Name = "Col127"
                .HeaderText = "Account No."
            End With
            Dim col128 As New DataGridViewTextBoxColumn()
            With col128
                .Name = "Col128"
                .HeaderText = "Account Name"
            End With
            Dim col129 As New DataGridViewTextBoxColumn()
            With col129
                .Name = "Col129"
                .HeaderText = "Balance"
            End With

            Dim col130 As New DataGridViewLinkColumn()
            With col130
                .Name = "Col130"
                .HeaderText = "Account No."
            End With
            Dim col131 As New DataGridViewTextBoxColumn()
            With col131
                .Name = "Col131"
                .HeaderText = "Account Name"
            End With
            Dim col132 As New DataGridViewTextBoxColumn()
            With col132
                .Name = "Col132"
                .HeaderText = "Balance"
            End With

            Dim col133 As New DataGridViewLinkColumn()
            With col133
                .Name = "Col133"
                .HeaderText = "Account No."
            End With
            Dim col134 As New DataGridViewTextBoxColumn()
            With col134
                .Name = "Col134"
                .HeaderText = "Account Name"
            End With
            Dim col135 As New DataGridViewTextBoxColumn()
            With col135
                .Name = "Col135"
                .HeaderText = "Balance"
            End With

            Dim col136 As New DataGridViewLinkColumn()
            With col136
                .Name = "Col136"
                .HeaderText = "Account No."
            End With
            Dim col137 As New DataGridViewTextBoxColumn()
            With col137
                .Name = "Col137"
                .HeaderText = "Account Name"
            End With
            Dim col138 As New DataGridViewTextBoxColumn()
            With col138
                .Name = "Col138"
                .HeaderText = "Balance"
            End With

            Dim col139 As New DataGridViewLinkColumn()
            With col139
                .Name = "Col139"
                .HeaderText = "Account No."
            End With
            Dim col140 As New DataGridViewTextBoxColumn()
            With col140
                .Name = "Col140"
                .HeaderText = "Account Name"
            End With
            Dim col141 As New DataGridViewTextBoxColumn()
            With col141
                .Name = "Col141"
                .HeaderText = "Balance"
            End With

            Dim col142 As New DataGridViewLinkColumn()
            With col142
                .Name = "Col142"
                .HeaderText = "Account No."
            End With
            Dim col143 As New DataGridViewTextBoxColumn()
            With col143
                .Name = "Col143"
                .HeaderText = "Account Name"
            End With
            Dim col144 As New DataGridViewTextBoxColumn()
            With col144
                .Name = "Col144"
                .HeaderText = "Balance"
            End With

            With DGVGame
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVGame.CellClick, AddressOf DGVGame_CellClick
            End With

            With DGVGLFreight
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVGLFreight.CellClick, AddressOf DGVGLFreight_CellClick
            End With

            With DGVStockGLSales
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVStockGLSales.CellClick, AddressOf DGVStockGLSales_CellClick
            End With

            With DGVStockGLInv
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVStockGLInv.CellClick, AddressOf DGVStockGLInv_CellClick
            End With

            With DGVStockGLCost
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVStockGLCost.CellClick, AddressOf DGVStockGLCost_CellClick
            End With

            With DGVStockCosting
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVStockCosting.CellClick, AddressOf DGVStockCosting_CellClick
            End With

            With DGVMasterGLSales
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVMasterGLSales.CellClick, AddressOf DGVMasterGLSales_CellClick
            End With

            With DGVMasterGLInv
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVMasterGLInv.CellClick, AddressOf DGVMasterGLInv_CellClick
            End With

            With DGVMasterGLCost
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVMasterGLCost.CellClick, AddressOf DGVMasterGLCost_CellClick
            End With

            With DGVMasterCosting
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVMasterCosting.CellClick, AddressOf DGVMasterCosting_CellClick
            End With

            With DGVNonStockGLSales
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVNonStockGLSales.CellClick, AddressOf DGVNonStockGLSales_CellClick
            End With

            With DGVNonStockGLInv
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVNonStockGLInv.CellClick, AddressOf DGVNonStockGLInv_CellClick
            End With

            With DGVNonStockGLCost
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVNonStockGLCost.CellClick, AddressOf DGVNonStockGLCost_CellClick
            End With

            With DGVNonStockCosting
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVNonStockCosting.CellClick, AddressOf DGVNonStockCosting_CellClick
            End With

            With DGVDescriptionGLSales
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVDescriptionGLSales.CellClick, AddressOf DGVDescriptionGLSales_CellClick
            End With

            With DGVDescriptionGLInv
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVDescriptionGLInv.CellClick, AddressOf DGVDescriptionGLInv_CellClick
            End With

            With DGVDescriptionGLCost
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVDescriptionGLCost.CellClick, AddressOf DGVDescriptionGLCost_CellClick
            End With

            With DGVDescriptionCosting
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVDescriptionCosting.CellClick, AddressOf DGVDescriptionCosting_CellClick
            End With

            With DGVServiceGLSales
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVServiceGLSales.CellClick, AddressOf DGVServiceGLSales_CellClick
            End With

            With DGVServiceGLInv
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVServiceGLInv.CellClick, AddressOf DGVServiceGLInv_CellClick
            End With

            With DGVServiceGLCost
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVServiceGLCost.CellClick, AddressOf DGVServiceGLCost_CellClick
            End With

            With DGVServiceCosting
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVServiceCosting.CellClick, AddressOf DGVServiceCosting_CellClick
            End With

            With DGVLaborGLSales
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVLaborGLSales.CellClick, AddressOf DGVLaborGLSales_CellClick
            End With

            With DGVLaborGLInv
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVLaborGLInv.CellClick, AddressOf DGVLaborGLInv_CellClick
            End With

            With DGVLaborGLCost
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVLaborGLCost.CellClick, AddressOf DGVLaborGLCost_CellClick
            End With

            With DGVLaborCosting
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVLaborCosting.CellClick, AddressOf DGVLaborCosting_CellClick
            End With

            With DGVAssemblyGLSales
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVAssemblyGLSales.CellClick, AddressOf DGVAssemblyGLSales_CellClick
            End With

            With DGVAssemblyGLInv
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVAssemblyGLInv.CellClick, AddressOf DGVAssemblyGLInv_CellClick
            End With

            With DGVAssemblyGLCost
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVAssemblyGLCost.CellClick, AddressOf DGVAssemblyGLCost_CellClick
            End With

            With DGVAssemblyCosting
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVAssemblyCosting.CellClick, AddressOf DGVAssemblyCosting_CellClick
            End With

            With DGVActivityGLSales
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVActivityGLSales.CellClick, AddressOf DGVActivityGLSales_CellClick
            End With

            With DGVActivityGLInv
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVActivityGLInv.CellClick, AddressOf DGVActivityGLInv_CellClick
            End With

            With DGVActivityGLCost
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVActivityGLCost.CellClick, AddressOf DGVActivityGLCost_CellClick
            End With

            With DGVActivityCosting
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVActivityCosting.CellClick, AddressOf DGVActivityCosting_CellClick
            End With

            With DGVChargeGLSales
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVChargeGLSales.CellClick, AddressOf DGVChargeGLSales_CellClick
            End With

            With DGVChargeGLInv
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVChargeGLInv.CellClick, AddressOf DGVChargeGLInv_CellClick
            End With

            With DGVChargeGLCost
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVChargeGLCost.CellClick, AddressOf DGVChargeGLCost_CellClick
            End With

            With DGVChargeCosting
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVChargeCosting.CellClick, AddressOf DGVChargeCosting_CellClick
            End With

            With DGVMonthlyFees
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVMonthlyFees.CellClick, AddressOf DGVMonthlyFees_CellClick
            End With

            With DGVYearlyFees
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVYearlyFees.CellClick, AddressOf DGVYearlyFees_CellClick
            End With

            With DGVLibraryFees
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVLibraryFees.CellClick, AddressOf DGVLibraryFees_CellClick
            End With

            With DGVLateFees
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVLateFees.CellClick, AddressOf DGVLateFees_CellClick
            End With

            With DGVOtherFees
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVOtherFees.CellClick, AddressOf DGVOtherFees_CellClick
            End With

            With DGVExamFees
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVExamFees.CellClick, AddressOf DGVExamFees_CellClick
            End With

            With DGVDiscount
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVDiscount.CellClick, AddressOf DGVDiscount_CellClick
            End With

            With DGVBankDeposit
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVBankDeposit.CellClick, AddressOf DGVBankDeposit_CellClick
            End With

            With DGVPurchaseOrder
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVPurchaseOrder.CellClick, AddressOf DGVPurchaseOrder_CellClick
            End With

            With DGVSalesInvoice
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVSalesInvoice.CellClick, AddressOf DGVSalesInvoice_CellClick
            End With

            DGVGLFreight.Columns.Clear()
            DGVGLFreight.Columns.Add(col1)
            DGVGLFreight.Columns.Add(col2)
            DGVGLFreight.Columns.Add(col3)
            DGVGLFreight.Rows.Clear()

            DGVStockGLSales.Columns.Clear()
            DGVStockGLSales.Columns.Add(col4)
            DGVStockGLSales.Columns.Add(col5)
            DGVStockGLSales.Columns.Add(col6)
            DGVStockGLSales.Rows.Clear()

            DGVStockGLInv.Columns.Clear()
            DGVStockGLInv.Columns.Add(col7)
            DGVStockGLInv.Columns.Add(col8)
            DGVStockGLInv.Columns.Add(col9)
            DGVStockGLInv.Rows.Clear()

            DGVStockGLCost.Columns.Clear()
            DGVStockGLCost.Columns.Add(col10)
            DGVStockGLCost.Columns.Add(col11)
            DGVStockGLCost.Columns.Add(col12)
            DGVStockGLCost.Rows.Clear()

            DGVStockCosting.Columns.Clear()
            DGVStockCosting.Columns.Add(col13)
            DGVStockCosting.Columns.Add(col14)
            DGVStockCosting.Columns.Add(col15)
            DGVStockCosting.Rows.Clear()

            DGVMasterGLSales.Columns.Clear()
            DGVMasterGLSales.Columns.Add(col16)
            DGVMasterGLSales.Columns.Add(col17)
            DGVMasterGLSales.Columns.Add(col18)
            DGVMasterGLSales.Rows.Clear()

            DGVMasterGLInv.Columns.Clear()
            DGVMasterGLInv.Columns.Add(col19)
            DGVMasterGLInv.Columns.Add(col20)
            DGVMasterGLInv.Columns.Add(col21)
            DGVMasterGLInv.Rows.Clear()

            DGVMasterGLCost.Columns.Clear()
            DGVMasterGLCost.Columns.Add(col22)
            DGVMasterGLCost.Columns.Add(col23)
            DGVMasterGLCost.Columns.Add(col24)
            DGVMasterGLCost.Rows.Clear()

            DGVMasterCosting.Columns.Clear()
            DGVMasterCosting.Columns.Add(col25)
            DGVMasterCosting.Columns.Add(col26)
            DGVMasterCosting.Columns.Add(col27)
            DGVMasterCosting.Rows.Clear()

            DGVNonStockGLSales.Columns.Clear()
            DGVNonStockGLSales.Columns.Add(col28)
            DGVNonStockGLSales.Columns.Add(col29)
            DGVNonStockGLSales.Columns.Add(col30)
            DGVNonStockGLSales.Rows.Clear()

            DGVNonStockGLInv.Columns.Clear()
            DGVNonStockGLInv.Columns.Add(col31)
            DGVNonStockGLInv.Columns.Add(col32)
            DGVNonStockGLInv.Columns.Add(col33)
            DGVNonStockGLInv.Rows.Clear()

            DGVNonStockGLCost.Columns.Clear()
            DGVNonStockGLCost.Columns.Add(col34)
            DGVNonStockGLCost.Columns.Add(col35)
            DGVNonStockGLCost.Columns.Add(col36)
            DGVNonStockGLCost.Rows.Clear()

            DGVNonStockCosting.Columns.Clear()
            DGVNonStockCosting.Columns.Add(col37)
            DGVNonStockCosting.Columns.Add(col38)
            DGVNonStockCosting.Columns.Add(col39)
            DGVNonStockCosting.Rows.Clear()

            DGVDescriptionGLSales.Columns.Clear()
            DGVDescriptionGLSales.Columns.Add(col40)
            DGVDescriptionGLSales.Columns.Add(col41)
            DGVDescriptionGLSales.Columns.Add(col42)
            DGVDescriptionGLSales.Rows.Clear()

            DGVDescriptionGLInv.Columns.Clear()
            DGVDescriptionGLInv.Columns.Add(col43)
            DGVDescriptionGLInv.Columns.Add(col44)
            DGVDescriptionGLInv.Columns.Add(col45)
            DGVDescriptionGLInv.Rows.Clear()

            DGVDescriptionGLCost.Columns.Clear()
            DGVDescriptionGLCost.Columns.Add(col46)
            DGVDescriptionGLCost.Columns.Add(col47)
            DGVDescriptionGLCost.Columns.Add(col48)
            DGVDescriptionGLCost.Rows.Clear()

            DGVDescriptionCosting.Columns.Clear()
            DGVDescriptionCosting.Columns.Add(col49)
            DGVDescriptionCosting.Columns.Add(col50)
            DGVDescriptionCosting.Columns.Add(col51)
            DGVDescriptionCosting.Rows.Clear()

            DGVServiceGLSales.Columns.Clear()
            DGVServiceGLSales.Columns.Add(col52)
            DGVServiceGLSales.Columns.Add(col53)
            DGVServiceGLSales.Columns.Add(col54)
            DGVServiceGLSales.Rows.Clear()

            DGVServiceGLInv.Columns.Clear()
            DGVServiceGLInv.Columns.Add(col55)
            DGVServiceGLInv.Columns.Add(col56)
            DGVServiceGLInv.Columns.Add(col57)
            DGVServiceGLInv.Rows.Clear()

            DGVServiceGLCost.Columns.Clear()
            DGVServiceGLCost.Columns.Add(col58)
            DGVServiceGLCost.Columns.Add(col59)
            DGVServiceGLCost.Columns.Add(col60)
            DGVServiceGLCost.Rows.Clear()

            DGVServiceCosting.Columns.Clear()
            DGVServiceCosting.Columns.Add(col61)
            DGVServiceCosting.Columns.Add(col62)
            DGVServiceCosting.Columns.Add(col63)
            DGVServiceCosting.Rows.Clear()

            DGVLaborGLSales.Columns.Clear()
            DGVLaborGLSales.Columns.Add(col64)
            DGVLaborGLSales.Columns.Add(col65)
            DGVLaborGLSales.Columns.Add(col66)
            DGVLaborGLSales.Rows.Clear()

            DGVLaborGLInv.Columns.Clear()
            DGVLaborGLInv.Columns.Add(col67)
            DGVLaborGLInv.Columns.Add(col68)
            DGVLaborGLInv.Columns.Add(col69)
            DGVLaborGLInv.Rows.Clear()

            DGVLaborGLCost.Columns.Clear()
            DGVLaborGLCost.Columns.Add(col70)
            DGVLaborGLCost.Columns.Add(col71)
            DGVLaborGLCost.Columns.Add(col72)
            DGVLaborGLCost.Rows.Clear()

            DGVLaborCosting.Columns.Clear()
            DGVLaborCosting.Columns.Add(col73)
            DGVLaborCosting.Columns.Add(col74)
            DGVLaborCosting.Columns.Add(col75)
            DGVLaborCosting.Rows.Clear()

            DGVAssemblyGLSales.Columns.Clear()
            DGVAssemblyGLSales.Columns.Add(col76)
            DGVAssemblyGLSales.Columns.Add(col77)
            DGVAssemblyGLSales.Columns.Add(col78)
            DGVAssemblyGLSales.Rows.Clear()

            DGVAssemblyGLInv.Columns.Clear()
            DGVAssemblyGLInv.Columns.Add(col79)
            DGVAssemblyGLInv.Columns.Add(col80)
            DGVAssemblyGLInv.Columns.Add(col81)
            DGVAssemblyGLInv.Rows.Clear()

            DGVAssemblyGLCost.Columns.Clear()
            DGVAssemblyGLCost.Columns.Add(col82)
            DGVAssemblyGLCost.Columns.Add(col83)
            DGVAssemblyGLCost.Columns.Add(col84)
            DGVAssemblyGLCost.Rows.Clear()

            DGVAssemblyCosting.Columns.Clear()
            DGVAssemblyCosting.Columns.Add(col85)
            DGVAssemblyCosting.Columns.Add(col86)
            DGVAssemblyCosting.Columns.Add(col87)
            DGVAssemblyCosting.Rows.Clear()

            DGVActivityGLSales.Columns.Clear()
            DGVActivityGLSales.Columns.Add(col88)
            DGVActivityGLSales.Columns.Add(col89)
            DGVActivityGLSales.Columns.Add(col90)
            DGVActivityGLSales.Rows.Clear()

            DGVActivityGLInv.Columns.Clear()
            DGVActivityGLInv.Columns.Add(col91)
            DGVActivityGLInv.Columns.Add(col92)
            DGVActivityGLInv.Columns.Add(col93)
            DGVActivityGLInv.Rows.Clear()

            DGVActivityGLCost.Columns.Clear()
            DGVActivityGLCost.Columns.Add(col94)
            DGVActivityGLCost.Columns.Add(col95)
            DGVActivityGLCost.Columns.Add(col96)
            DGVActivityGLCost.Rows.Clear()

            DGVActivityCosting.Columns.Clear()
            DGVActivityCosting.Columns.Add(col97)
            DGVActivityCosting.Columns.Add(col98)
            DGVActivityCosting.Columns.Add(col99)
            DGVActivityCosting.Rows.Clear()

            DGVChargeGLSales.Columns.Clear()
            DGVChargeGLSales.Columns.Add(col100)
            DGVChargeGLSales.Columns.Add(col101)
            DGVChargeGLSales.Columns.Add(col102)
            DGVChargeGLSales.Rows.Clear()

            DGVChargeGLInv.Columns.Clear()
            DGVChargeGLInv.Columns.Add(col103)
            DGVChargeGLInv.Columns.Add(col104)
            DGVChargeGLInv.Columns.Add(col105)
            DGVChargeGLInv.Rows.Clear()

            DGVChargeGLCost.Columns.Clear()
            DGVChargeGLCost.Columns.Add(col106)
            DGVChargeGLCost.Columns.Add(col107)
            DGVChargeGLCost.Columns.Add(col108)
            DGVChargeGLCost.Rows.Clear()

            DGVChargeCosting.Columns.Clear()
            DGVChargeCosting.Columns.Add(col109)
            DGVChargeCosting.Columns.Add(col110)
            DGVChargeCosting.Columns.Add(col111)
            DGVChargeCosting.Rows.Clear()

            DGVGame.Columns.Clear()
            DGVGame.Columns.Add(col112)
            DGVGame.Columns.Add(col113)
            DGVGame.Columns.Add(col114)
            DGVGame.Rows.Clear()

            DGVMonthlyFees.Columns.Clear()
            DGVMonthlyFees.Columns.Add(col115)
            DGVMonthlyFees.Columns.Add(col116)
            DGVMonthlyFees.Columns.Add(col117)
            DGVMonthlyFees.Rows.Clear()

            DGVYearlyFees.Columns.Clear()
            DGVYearlyFees.Columns.Add(col118)
            DGVYearlyFees.Columns.Add(col119)
            DGVYearlyFees.Columns.Add(col120)
            DGVYearlyFees.Rows.Clear()

            DGVLibraryFees.Columns.Clear()
            DGVLibraryFees.Columns.Add(col121)
            DGVLibraryFees.Columns.Add(col122)
            DGVLibraryFees.Columns.Add(col123)
            DGVLibraryFees.Rows.Clear()

            DGVLateFees.Columns.Clear()
            DGVLateFees.Columns.Add(col124)
            DGVLateFees.Columns.Add(col125)
            DGVLateFees.Columns.Add(col126)
            DGVLateFees.Rows.Clear()

            DGVOtherFees.Columns.Clear()
            DGVOtherFees.Columns.Add(col127)
            DGVOtherFees.Columns.Add(col128)
            DGVOtherFees.Columns.Add(col129)
            DGVOtherFees.Rows.Clear()

            DGVExamFees.Columns.Clear()
            DGVExamFees.Columns.Add(col130)
            DGVExamFees.Columns.Add(col131)
            DGVExamFees.Columns.Add(col132)
            DGVExamFees.Rows.Clear()

            DGVDiscount.Columns.Clear()
            DGVDiscount.Columns.Add(col133)
            DGVDiscount.Columns.Add(col134)
            DGVDiscount.Columns.Add(col135)
            DGVDiscount.Rows.Clear()

            DGVBankDeposit.Columns.Clear()
            DGVBankDeposit.Columns.Add(col136)
            DGVBankDeposit.Columns.Add(col137)
            DGVBankDeposit.Columns.Add(col138)
            DGVBankDeposit.Rows.Clear()

            DGVPurchaseOrder.Columns.Clear()
            DGVPurchaseOrder.Columns.Add(col139)
            DGVPurchaseOrder.Columns.Add(col140)
            DGVPurchaseOrder.Columns.Add(col141)
            DGVPurchaseOrder.Rows.Clear()

            DGVSalesInvoice.Columns.Clear()
            DGVSalesInvoice.Columns.Add(col142)
            DGVSalesInvoice.Columns.Add(col143)
            DGVSalesInvoice.Columns.Add(col144)
            DGVSalesInvoice.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select AccountID,AccountName,AccountBalance from Accounts where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVGLFreight.Rows.Add()
                DGVGLFreight.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVGLFreight.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVGLFreight.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVStockGLSales.Rows.Add()
                DGVStockGLSales.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVStockGLSales.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVStockGLSales.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVStockGLInv.Rows.Add()
                DGVStockGLInv.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVStockGLInv.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVStockGLInv.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVStockGLCost.Rows.Add()
                DGVStockGLCost.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVStockGLCost.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVStockGLCost.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVStockCosting.Rows.Add()
                DGVStockCosting.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVStockCosting.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVStockCosting.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVMasterGLSales.Rows.Add()
                DGVMasterGLSales.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVMasterGLSales.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVMasterGLSales.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVMasterGLInv.Rows.Add()
                DGVMasterGLInv.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVMasterGLInv.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVMasterGLInv.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVMasterGLCost.Rows.Add()
                DGVMasterGLCost.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVMasterGLCost.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVMasterGLCost.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVMasterCosting.Rows.Add()
                DGVMasterCosting.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVMasterCosting.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVMasterCosting.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVNonStockGLSales.Rows.Add()
                DGVNonStockGLSales.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVNonStockGLSales.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVNonStockGLSales.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVNonStockGLInv.Rows.Add()
                DGVNonStockGLInv.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVNonStockGLInv.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVNonStockGLInv.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVNonStockGLCost.Rows.Add()
                DGVNonStockGLCost.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVNonStockGLCost.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVNonStockGLCost.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVNonStockCosting.Rows.Add()
                DGVNonStockCosting.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVNonStockCosting.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVNonStockCosting.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVDescriptionGLSales.Rows.Add()
                DGVDescriptionGLSales.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVDescriptionGLSales.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVDescriptionGLSales.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVDescriptionGLInv.Rows.Add()
                DGVDescriptionGLInv.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVDescriptionGLInv.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVDescriptionGLInv.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVDescriptionGLCost.Rows.Add()
                DGVDescriptionGLCost.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVDescriptionGLCost.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVDescriptionGLCost.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVDescriptionCosting.Rows.Add()
                DGVDescriptionCosting.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVDescriptionCosting.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVDescriptionCosting.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVServiceGLSales.Rows.Add()
                DGVServiceGLSales.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVServiceGLSales.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVServiceGLSales.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVServiceGLInv.Rows.Add()
                DGVServiceGLInv.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVServiceGLInv.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVServiceGLInv.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVServiceGLCost.Rows.Add()
                DGVServiceGLCost.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVServiceGLCost.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVServiceGLCost.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVServiceCosting.Rows.Add()
                DGVServiceCosting.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVServiceCosting.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVServiceCosting.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVLaborGLSales.Rows.Add()
                DGVLaborGLSales.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVLaborGLSales.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVLaborGLSales.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVLaborGLInv.Rows.Add()
                DGVLaborGLInv.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVLaborGLInv.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVLaborGLInv.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVLaborGLCost.Rows.Add()
                DGVLaborGLCost.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVLaborGLCost.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVLaborGLCost.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVLaborCosting.Rows.Add()
                DGVLaborCosting.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVLaborCosting.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVLaborCosting.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVAssemblyGLSales.Rows.Add()
                DGVAssemblyGLSales.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVAssemblyGLSales.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVAssemblyGLSales.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVAssemblyGLInv.Rows.Add()
                DGVAssemblyGLInv.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVAssemblyGLInv.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVAssemblyGLInv.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVAssemblyGLCost.Rows.Add()
                DGVAssemblyGLCost.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVAssemblyGLCost.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVAssemblyGLCost.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVAssemblyCosting.Rows.Add()
                DGVAssemblyCosting.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVAssemblyCosting.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVAssemblyCosting.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVActivityGLSales.Rows.Add()
                DGVActivityGLSales.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVActivityGLSales.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVActivityGLSales.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVActivityGLInv.Rows.Add()
                DGVActivityGLInv.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVActivityGLInv.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVActivityGLInv.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVActivityGLCost.Rows.Add()
                DGVActivityGLCost.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVActivityGLCost.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVActivityGLCost.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVActivityCosting.Rows.Add()
                DGVActivityCosting.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVActivityCosting.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVActivityCosting.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVChargeGLSales.Rows.Add()
                DGVChargeGLSales.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVChargeGLSales.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVChargeGLSales.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVChargeGLInv.Rows.Add()
                DGVChargeGLInv.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVChargeGLInv.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVChargeGLInv.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVChargeGLCost.Rows.Add()
                DGVChargeGLCost.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVChargeGLCost.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVChargeGLCost.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVChargeCosting.Rows.Add()
                DGVChargeCosting.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVChargeCosting.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVChargeCosting.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVGame.Rows.Add()
                DGVGame.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVGame.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVGame.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVMonthlyFees.Rows.Add()
                DGVMonthlyFees.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVMonthlyFees.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVMonthlyFees.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVYearlyFees.Rows.Add()
                DGVYearlyFees.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVYearlyFees.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVYearlyFees.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVLibraryFees.Rows.Add()
                DGVLibraryFees.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVLibraryFees.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVLibraryFees.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVLateFees.Rows.Add()
                DGVLateFees.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVLateFees.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVLateFees.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVOtherFees.Rows.Add()
                DGVOtherFees.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVOtherFees.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVOtherFees.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVExamFees.Rows.Add()
                DGVExamFees.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVExamFees.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVExamFees.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVDiscount.Rows.Add()
                DGVDiscount.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVDiscount.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVDiscount.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVBankDeposit.Rows.Add()
                DGVBankDeposit.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVBankDeposit.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVBankDeposit.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVPurchaseOrder.Rows.Add()
                DGVPurchaseOrder.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVPurchaseOrder.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVPurchaseOrder.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                DGVSalesInvoice.Rows.Add()
                DGVSalesInvoice.Rows(indx).Cells(0).Value = dr("AccountID").ToString()
                DGVSalesInvoice.Rows(indx).Cells(1).Value = dr("AccountName").ToString()
                DGVSalesInvoice.Rows(indx).Cells(2).Value = dr("AccountBalance").ToString()

                indx = indx + 1
            End While
            dr.Close()

            DGVGLFreight.ClearSelection()
            DGVStockGLSales.ClearSelection()
            DGVStockGLInv.ClearSelection()
            DGVStockGLCost.ClearSelection()
            DGVStockCosting.ClearSelection()
            DGVMasterGLSales.ClearSelection()
            DGVMasterGLInv.ClearSelection()
            DGVMasterGLCost.ClearSelection()
            DGVMasterCosting.ClearSelection()
            DGVNonStockGLSales.ClearSelection()
            DGVNonStockGLInv.ClearSelection()
            DGVNonStockGLCost.ClearSelection()
            DGVNonStockCosting.ClearSelection()
            DGVDescriptionGLSales.ClearSelection()
            DGVDescriptionGLInv.ClearSelection()
            DGVDescriptionGLCost.ClearSelection()
            DGVDescriptionCosting.ClearSelection()
            DGVServiceGLSales.ClearSelection()
            DGVServiceGLInv.ClearSelection()
            DGVServiceGLCost.ClearSelection()
            DGVServiceCosting.ClearSelection()
            DGVLaborGLSales.ClearSelection()
            DGVLaborGLInv.ClearSelection()
            DGVLaborGLCost.ClearSelection()
            DGVLaborCosting.ClearSelection()
            DGVAssemblyGLSales.ClearSelection()
            DGVAssemblyGLInv.ClearSelection()
            DGVAssemblyGLCost.ClearSelection()
            DGVAssemblyCosting.ClearSelection()
            DGVActivityGLSales.ClearSelection()
            DGVActivityGLInv.ClearSelection()
            DGVActivityGLCost.ClearSelection()
            DGVActivityCosting.ClearSelection()
            DGVChargeGLSales.ClearSelection()
            DGVChargeGLInv.ClearSelection()
            DGVChargeGLCost.ClearSelection()
            DGVChargeCosting.ClearSelection()
            DGVGame.ClearSelection()
            DGVMonthlyFees.ClearSelection()
            DGVYearlyFees.ClearSelection()
            DGVLibraryFees.ClearSelection()
            DGVLateFees.ClearSelection()
            DGVOtherFees.ClearSelection()
            DGVExamFees.ClearSelection()
            DGVDiscount.ClearSelection()
            DGVBankDeposit.ClearSelection()
            DGVPurchaseOrder.ClearSelection()
            DGVSalesInvoice.ClearSelection()

            cmbglfreight.AddDataGridView(DGVGLFreight, False)
            cmbstockglsales.AddDataGridView(DGVStockGLSales, False)
            cmbstockglinv.AddDataGridView(DGVStockGLInv, False)
            cmbstockglcost.AddDataGridView(DGVStockGLCost, False)
            cmbstockcosting.AddDataGridView(DGVStockCosting, False)
            cmbmasterglsales.AddDataGridView(DGVMasterGLSales, False)
            cmbmasterglinv.AddDataGridView(DGVMasterGLInv, False)
            cmbmasterglcost.AddDataGridView(DGVMasterGLCost, False)
            cmbmastercosting.AddDataGridView(DGVMasterCosting, False)
            cmbnonglsales.AddDataGridView(DGVNonStockGLSales, False)
            cmbnonglinv.AddDataGridView(DGVNonStockGLInv, False)
            cmbnonglcost.AddDataGridView(DGVNonStockGLCost, False)
            cmbnoncosting.AddDataGridView(DGVNonStockCosting, False)
            cmbdescglsales.AddDataGridView(DGVDescriptionGLSales, False)
            cmbdescglinv.AddDataGridView(DGVDescriptionGLInv, False)
            cmbdescglcost.AddDataGridView(DGVDescriptionGLCost, False)
            cmbdesccosting.AddDataGridView(DGVDescriptionCosting, False)
            cmbserviceglsales.AddDataGridView(DGVServiceGLSales, False)
            cmbserviceglinv.AddDataGridView(DGVServiceGLInv, False)
            cmbserviceglcost.AddDataGridView(DGVServiceGLCost, False)
            cmbservicecosting.AddDataGridView(DGVServiceCosting, False)
            cmblaborglsales.AddDataGridView(DGVLaborGLSales, False)
            cmblaborglinv.AddDataGridView(DGVLaborGLInv, False)
            cmblaborglcost.AddDataGridView(DGVLaborGLCost, False)
            cmblaborcosting.AddDataGridView(DGVLaborCosting, False)
            cmbassemblyglsales.AddDataGridView(DGVAssemblyGLSales, False)
            cmbassemblyglinv.AddDataGridView(DGVAssemblyGLInv, False)
            cmbassemblyglcost.AddDataGridView(DGVAssemblyGLCost, False)
            cmbassemblycosting.AddDataGridView(DGVAssemblyCosting, False)
            cmbactivityglsales.AddDataGridView(DGVActivityGLSales, False)
            cmbactivityglinv.AddDataGridView(DGVActivityGLInv, False)
            cmbactivityglcost.AddDataGridView(DGVActivityGLCost, False)
            cmbactivitycosting.AddDataGridView(DGVActivityCosting, False)
            cmbchargeglsales.AddDataGridView(DGVChargeGLSales, False)
            cmbchargeglinv.AddDataGridView(DGVChargeGLInv, False)
            cmbchargeglcost.AddDataGridView(DGVChargeGLCost, False)
            cmbchargecosting.AddDataGridView(DGVChargeCosting, False)
            cmbgameaccount.AddDataGridView(DGVGame, False)
            cmbmonthlyfeesacc.AddDataGridView(DGVMonthlyFees, False)
            cmbyearlyfeesacc.AddDataGridView(DGVYearlyFees, False)
            cmblibraryfeesacc.AddDataGridView(DGVLibraryFees, False)
            cmblatefeesacc.AddDataGridView(DGVLateFees, False)
            cmbotherfeesacc.AddDataGridView(DGVOtherFees, False)
            cmbexamfeesacc.AddDataGridView(DGVExamFees, False)
            cmbdiscountfeesacc.AddDataGridView(DGVDiscount, False)
            cmbbankdepositacc.AddDataGridView(DGVBankDeposit, False)
            cmbpurchaseorderacc.AddDataGridView(DGVPurchaseOrder, False)
            cmbsalesinvoiceacc.AddDataGridView(DGVSalesInvoice, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVGLFreight_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVGLFreight.CurrentRow.Index
            DGVGLFreight.Rows(k).Selected = True
            DGVGLFreight.CurrentCell = DGVGLFreight.Rows(k).Cells(0)
            AccID = DGVGLFreight.Rows(k).Cells(0).Value.ToString()
            cmbglfreight.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVStockGLSales_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVStockGLSales.CurrentRow.Index
            DGVStockGLSales.Rows(k).Selected = True
            DGVStockGLSales.CurrentCell = DGVStockGLSales.Rows(k).Cells(0)
            AccID = DGVStockGLSales.Rows(k).Cells(0).Value.ToString()
            cmbstockglsales.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVStockGLInv_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVStockGLInv.CurrentRow.Index
            DGVStockGLInv.Rows(k).Selected = True
            DGVStockGLInv.CurrentCell = DGVStockGLInv.Rows(k).Cells(0)
            AccID = DGVStockGLInv.Rows(k).Cells(0).Value.ToString()
            cmbstockglinv.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVStockGLCost_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVStockGLCost.CurrentRow.Index
            DGVStockGLCost.Rows(k).Selected = True
            DGVStockGLCost.CurrentCell = DGVStockGLCost.Rows(k).Cells(0)
            AccID = DGVStockGLCost.Rows(k).Cells(0).Value.ToString()
            cmbstockglcost.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVStockCosting_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVStockCosting.CurrentRow.Index
            DGVStockCosting.Rows(k).Selected = True
            DGVStockCosting.CurrentCell = DGVStockCosting.Rows(k).Cells(0)
            AccID = DGVStockCosting.Rows(k).Cells(0).Value.ToString()
            cmbstockcosting.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVMasterGLSales_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVMasterGLSales.CurrentRow.Index
            DGVMasterGLSales.Rows(k).Selected = True
            DGVMasterGLSales.CurrentCell = DGVMasterGLSales.Rows(k).Cells(0)
            AccID = DGVMasterGLSales.Rows(k).Cells(0).Value.ToString()
            cmbmasterglsales.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVMasterGLInv_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVMasterGLInv.CurrentRow.Index
            DGVMasterGLInv.Rows(k).Selected = True
            DGVMasterGLInv.CurrentCell = DGVMasterGLInv.Rows(k).Cells(0)
            AccID = DGVMasterGLInv.Rows(k).Cells(0).Value.ToString()
            cmbmasterglinv.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVMasterGLCost_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVMasterGLCost.CurrentRow.Index
            DGVMasterGLCost.Rows(k).Selected = True
            DGVMasterGLCost.CurrentCell = DGVMasterGLCost.Rows(k).Cells(0)
            AccID = DGVMasterGLCost.Rows(k).Cells(0).Value.ToString()
            cmbmasterglcost.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVMasterCosting_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVMasterCosting.CurrentRow.Index
            DGVMasterCosting.Rows(k).Selected = True
            DGVMasterCosting.CurrentCell = DGVMasterCosting.Rows(k).Cells(0)
            AccID = DGVMasterCosting.Rows(k).Cells(0).Value.ToString()
            cmbmastercosting.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVNonStockGLSales_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVNonStockGLSales.CurrentRow.Index
            DGVNonStockGLSales.Rows(k).Selected = True
            DGVNonStockGLSales.CurrentCell = DGVNonStockGLSales.Rows(k).Cells(0)
            AccID = DGVNonStockGLSales.Rows(k).Cells(0).Value.ToString()
            cmbnonglsales.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVNonStockGLInv_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVNonStockGLInv.CurrentRow.Index
            DGVNonStockGLInv.Rows(k).Selected = True
            DGVNonStockGLInv.CurrentCell = DGVNonStockGLInv.Rows(k).Cells(0)
            AccID = DGVNonStockGLInv.Rows(k).Cells(0).Value.ToString()
            cmbnonglinv.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVNonStockGLCost_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVNonStockGLCost.CurrentRow.Index
            DGVNonStockGLCost.Rows(k).Selected = True
            DGVNonStockGLCost.CurrentCell = DGVNonStockGLCost.Rows(k).Cells(0)
            AccID = DGVNonStockGLCost.Rows(k).Cells(0).Value.ToString()
            cmbnonglcost.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVNonStockCosting_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVNonStockCosting.CurrentRow.Index
            DGVNonStockCosting.Rows(k).Selected = True
            DGVNonStockCosting.CurrentCell = DGVNonStockCosting.Rows(k).Cells(0)
            AccID = DGVNonStockCosting.Rows(k).Cells(0).Value.ToString()
            cmbnoncosting.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVDescriptionGLSales_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVDescriptionGLSales.CurrentRow.Index
            DGVDescriptionGLSales.Rows(k).Selected = True
            DGVDescriptionGLSales.CurrentCell = DGVDescriptionGLSales.Rows(k).Cells(0)
            AccID = DGVDescriptionGLSales.Rows(k).Cells(0).Value.ToString()
            cmbdescglsales.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVDescriptionGLInv_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVDescriptionGLInv.CurrentRow.Index
            DGVDescriptionGLInv.Rows(k).Selected = True
            DGVDescriptionGLInv.CurrentCell = DGVDescriptionGLInv.Rows(k).Cells(0)
            AccID = DGVDescriptionGLInv.Rows(k).Cells(0).Value.ToString()
            cmbdescglinv.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVDescriptionGLCost_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVDescriptionGLCost.CurrentRow.Index
            DGVDescriptionGLCost.Rows(k).Selected = True
            DGVDescriptionGLCost.CurrentCell = DGVDescriptionGLCost.Rows(k).Cells(0)
            AccID = DGVDescriptionGLCost.Rows(k).Cells(0).Value.ToString()
            cmbdescglcost.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVDescriptionCosting_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVDescriptionCosting.CurrentRow.Index
            DGVDescriptionCosting.Rows(k).Selected = True
            DGVDescriptionCosting.CurrentCell = DGVDescriptionCosting.Rows(k).Cells(0)
            AccID = DGVDescriptionCosting.Rows(k).Cells(0).Value.ToString()
            cmbdesccosting.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVServiceGLSales_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVServiceGLSales.CurrentRow.Index
            DGVServiceGLSales.Rows(k).Selected = True
            DGVServiceGLSales.CurrentCell = DGVServiceGLSales.Rows(k).Cells(0)
            AccID = DGVServiceGLSales.Rows(k).Cells(0).Value.ToString()
            cmbserviceglsales.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVServiceGLInv_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVServiceGLInv.CurrentRow.Index
            DGVServiceGLInv.Rows(k).Selected = True
            DGVServiceGLInv.CurrentCell = DGVServiceGLInv.Rows(k).Cells(0)
            AccID = DGVServiceGLInv.Rows(k).Cells(0).Value.ToString()
            cmbserviceglinv.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVServiceGLCost_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVServiceGLCost.CurrentRow.Index
            DGVServiceGLCost.Rows(k).Selected = True
            DGVServiceGLCost.CurrentCell = DGVServiceGLCost.Rows(k).Cells(0)
            AccID = DGVServiceGLCost.Rows(k).Cells(0).Value.ToString()
            cmbserviceglcost.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVServiceCosting_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVServiceCosting.CurrentRow.Index
            DGVServiceCosting.Rows(k).Selected = True
            DGVServiceCosting.CurrentCell = DGVServiceCosting.Rows(k).Cells(0)
            AccID = DGVServiceCosting.Rows(k).Cells(0).Value.ToString()
            cmbservicecosting.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVLaborGLSales_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVLaborGLSales.CurrentRow.Index
            DGVLaborGLSales.Rows(k).Selected = True
            DGVLaborGLSales.CurrentCell = DGVLaborGLSales.Rows(k).Cells(0)
            AccID = DGVLaborGLSales.Rows(k).Cells(0).Value.ToString()
            cmblaborglsales.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVLaborGLInv_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVLaborGLInv.CurrentRow.Index
            DGVLaborGLInv.Rows(k).Selected = True
            DGVLaborGLInv.CurrentCell = DGVLaborGLInv.Rows(k).Cells(0)
            AccID = DGVLaborGLInv.Rows(k).Cells(0).Value.ToString()
            cmblaborglinv.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVLaborGLCost_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVLaborGLCost.CurrentRow.Index
            DGVLaborGLCost.Rows(k).Selected = True
            DGVLaborGLCost.CurrentCell = DGVLaborGLCost.Rows(k).Cells(0)
            AccID = DGVLaborGLCost.Rows(k).Cells(0).Value.ToString()
            cmblaborglcost.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVLaborCosting_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVLaborCosting.CurrentRow.Index
            DGVLaborCosting.Rows(k).Selected = True
            DGVLaborCosting.CurrentCell = DGVLaborCosting.Rows(k).Cells(0)
            AccID = DGVLaborCosting.Rows(k).Cells(0).Value.ToString()
            cmblaborcosting.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVAssemblyGLSales_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVAssemblyGLSales.CurrentRow.Index
            DGVAssemblyGLSales.Rows(k).Selected = True
            DGVAssemblyGLSales.CurrentCell = DGVAssemblyGLSales.Rows(k).Cells(0)
            AccID = DGVAssemblyGLSales.Rows(k).Cells(0).Value.ToString()
            cmbassemblyglsales.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVAssemblyGLInv_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVAssemblyGLInv.CurrentRow.Index
            DGVAssemblyGLInv.Rows(k).Selected = True
            DGVAssemblyGLInv.CurrentCell = DGVAssemblyGLInv.Rows(k).Cells(0)
            AccID = DGVAssemblyGLInv.Rows(k).Cells(0).Value.ToString()
            cmbassemblyglinv.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVAssemblyGLCost_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVAssemblyGLCost.CurrentRow.Index
            DGVAssemblyGLCost.Rows(k).Selected = True
            DGVAssemblyGLCost.CurrentCell = DGVAssemblyGLCost.Rows(k).Cells(0)
            AccID = DGVAssemblyGLCost.Rows(k).Cells(0).Value.ToString()
            cmbassemblyglcost.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVAssemblyCosting_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVAssemblyCosting.CurrentRow.Index
            DGVAssemblyCosting.Rows(k).Selected = True
            DGVAssemblyCosting.CurrentCell = DGVAssemblyCosting.Rows(k).Cells(0)
            AccID = DGVAssemblyCosting.Rows(k).Cells(0).Value.ToString()
            cmbassemblycosting.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVActivityGLSales_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVActivityGLSales.CurrentRow.Index
            DGVActivityGLSales.Rows(k).Selected = True
            DGVActivityGLSales.CurrentCell = DGVActivityGLSales.Rows(k).Cells(0)
            AccID = DGVActivityGLSales.Rows(k).Cells(0).Value.ToString()
            cmbactivityglsales.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVActivityGLInv_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVActivityGLInv.CurrentRow.Index
            DGVActivityGLInv.Rows(k).Selected = True
            DGVActivityGLInv.CurrentCell = DGVActivityGLInv.Rows(k).Cells(0)
            AccID = DGVActivityGLInv.Rows(k).Cells(0).Value.ToString()
            cmbactivityglinv.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVActivityGLCost_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVActivityGLCost.CurrentRow.Index
            DGVActivityGLCost.Rows(k).Selected = True
            DGVActivityGLCost.CurrentCell = DGVActivityGLCost.Rows(k).Cells(0)
            AccID = DGVActivityGLCost.Rows(k).Cells(0).Value.ToString()
            cmbactivityglcost.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVActivityCosting_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVActivityCosting.CurrentRow.Index
            DGVActivityCosting.Rows(k).Selected = True
            DGVActivityCosting.CurrentCell = DGVActivityCosting.Rows(k).Cells(0)
            AccID = DGVActivityCosting.Rows(k).Cells(0).Value.ToString()
            cmbactivitycosting.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVChargeGLSales_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVChargeGLSales.CurrentRow.Index
            DGVChargeGLSales.Rows(k).Selected = True
            DGVChargeGLSales.CurrentCell = DGVChargeGLSales.Rows(k).Cells(0)
            AccID = DGVChargeGLSales.Rows(k).Cells(0).Value.ToString()
            cmbchargeglsales.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVChargeGLInv_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVChargeGLInv.CurrentRow.Index
            DGVChargeGLInv.Rows(k).Selected = True
            DGVChargeGLInv.CurrentCell = DGVChargeGLInv.Rows(k).Cells(0)
            AccID = DGVChargeGLInv.Rows(k).Cells(0).Value.ToString()
            cmbchargeglinv.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVChargeGLCost_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVChargeGLCost.CurrentRow.Index
            DGVChargeGLCost.Rows(k).Selected = True
            DGVChargeGLCost.CurrentCell = DGVChargeGLCost.Rows(k).Cells(0)
            AccID = DGVChargeGLCost.Rows(k).Cells(0).Value.ToString()
            cmbchargeglcost.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVChargeCosting_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVChargeCosting.CurrentRow.Index
            DGVChargeCosting.Rows(k).Selected = True
            DGVChargeCosting.CurrentCell = DGVChargeCosting.Rows(k).Cells(0)
            AccID = DGVChargeCosting.Rows(k).Cells(0).Value.ToString()
            cmbchargecosting.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVGame_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVGame.CurrentRow.Index
            DGVGame.Rows(k).Selected = True
            DGVGame.CurrentCell = DGVGame.Rows(k).Cells(0)
            AccID = DGVGame.Rows(k).Cells(0).Value.ToString()
            cmbgameaccount.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVMonthlyFees_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVMonthlyFees.CurrentRow.Index
            DGVMonthlyFees.Rows(k).Selected = True
            DGVMonthlyFees.CurrentCell = DGVMonthlyFees.Rows(k).Cells(0)
            AccID = DGVMonthlyFees.Rows(k).Cells(0).Value.ToString()
            cmbmonthlyfeesacc.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVYearlyFees_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVYearlyFees.CurrentRow.Index
            DGVYearlyFees.Rows(k).Selected = True
            DGVYearlyFees.CurrentCell = DGVYearlyFees.Rows(k).Cells(0)
            AccID = DGVYearlyFees.Rows(k).Cells(0).Value.ToString()
            cmbyearlyfeesacc.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVLibraryFees_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVLibraryFees.CurrentRow.Index
            DGVLibraryFees.Rows(k).Selected = True
            DGVLibraryFees.CurrentCell = DGVLibraryFees.Rows(k).Cells(0)
            AccID = DGVLibraryFees.Rows(k).Cells(0).Value.ToString()
            cmblibraryfeesacc.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVLateFees_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVLateFees.CurrentRow.Index
            DGVLateFees.Rows(k).Selected = True
            DGVLateFees.CurrentCell = DGVLateFees.Rows(k).Cells(0)
            AccID = DGVLateFees.Rows(k).Cells(0).Value.ToString()
            cmblatefeesacc.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVOtherFees_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVOtherFees.CurrentRow.Index
            DGVOtherFees.Rows(k).Selected = True
            DGVOtherFees.CurrentCell = DGVOtherFees.Rows(k).Cells(0)
            AccID = DGVOtherFees.Rows(k).Cells(0).Value.ToString()
            cmbotherfeesacc.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVExamFees_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVExamFees.CurrentRow.Index
            DGVExamFees.Rows(k).Selected = True
            DGVExamFees.CurrentCell = DGVExamFees.Rows(k).Cells(0)
            AccID = DGVExamFees.Rows(k).Cells(0).Value.ToString()
            cmbexamfeesacc.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVDiscount_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVDiscount.CurrentRow.Index
            DGVDiscount.Rows(k).Selected = True
            DGVDiscount.CurrentCell = DGVDiscount.Rows(k).Cells(0)
            AccID = DGVDiscount.Rows(k).Cells(0).Value.ToString()
            cmbdiscountfeesacc.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVBankDeposit_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVBankDeposit.CurrentRow.Index
            DGVBankDeposit.Rows(k).Selected = True
            DGVBankDeposit.CurrentCell = DGVBankDeposit.Rows(k).Cells(0)
            AccID = DGVBankDeposit.Rows(k).Cells(0).Value.ToString()
            cmbbankdepositacc.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVPurchaseOrder_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVPurchaseOrder.CurrentRow.Index
            DGVPurchaseOrder.Rows(k).Selected = True
            DGVPurchaseOrder.CurrentCell = DGVPurchaseOrder.Rows(k).Cells(0)
            AccID = DGVPurchaseOrder.Rows(k).Cells(0).Value.ToString()
            cmbpurchaseorderacc.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVSalesInvoice_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVSalesInvoice.CurrentRow.Index
            DGVSalesInvoice.Rows(k).Selected = True
            DGVSalesInvoice.CurrentCell = DGVSalesInvoice.Rows(k).Cells(0)
            AccID = DGVSalesInvoice.Rows(k).Cells(0).Value.ToString()
            cmbsalesinvoiceacc.Text = AccID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateInstituteDefaultRecord()
        Try
            Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                If chkpurchaseorder.Checked = True Then
                    alwayspurchase = "Yes"
                Else
                    alwayspurchase = "No"
                End If
                If rbtnsalesinvoice1.Checked = True Then
                    invoicemessage = rbtnsalesinvoice1.Text
                ElseIf rbtnsalesinvoice2.Checked = True Then
                    invoicemessage = rbtnsalesinvoice2.Text
                ElseIf rbtnsalesinvoice3.Checked = True Then
                    invoicemessage = rbtnsalesinvoice3.Text
                End If
                If rbtnsalesorder1.Checked = True Then
                    ordermessage = rbtnsalesorder1.Text
                ElseIf rbtnsalesorder2.Checked = True Then
                    ordermessage = rbtnsalesorder2.Text
                ElseIf rbtnsalesorder3.Checked = True Then
                    ordermessage = rbtnsalesorder3.Text
                End If
                gameexpense = cmbgameaccount.Text
                customfield1 = txtcustomfield1.Text
                customfield2 = txtcustomfield2.Text
                customfield3 = txtcustomfield3.Text
                customfield4 = txtcustomfield4.Text
                customfield5 = txtcustomfield5.Text
                If chkcustomfield1.Checked = True Then
                    checkcustomfield1 = "Yes"
                Else
                    checkcustomfield1 = "No"
                End If
                If chkcustomfield2.Checked = True Then
                    checkcustomfield2 = "Yes"
                Else
                    checkcustomfield2 = "No"
                End If
                If chkcustomfield3.Checked = True Then
                    checkcustomfield3 = "Yes"
                Else
                    checkcustomfield3 = "No"
                End If
                If chkcustomfield4.Checked = True Then
                    checkcustomfield4 = "Yes"
                Else
                    checkcustomfield4 = "No"
                End If
                If chkcustomfield5.Checked = True Then
                    checkcustomfield5 = "Yes"
                Else
                    checkcustomfield5 = "No"
                End If
                costmethod = cmbcostmethod.Text
                stockglsalesacc = cmbstockglsales.Text
                stockglinvacc = cmbstockglinv.Text
                stockglcostacc = cmbstockglcost.Text
                stockcostingacc = cmbstockcosting.Text
                masterglsalesacc = cmbmasterglsales.Text
                masterglinvacc = cmbmasterglinv.Text
                masterglcostacc = cmbmasterglcost.Text
                mastercostingacc = cmbmastercosting.Text
                nonstockglsalesacc = cmbnonglsales.Text
                nonstockglinvacc = cmbnonglinv.Text
                nonstockglcostacc = cmbnonglcost.Text
                nonstockcostingacc = cmbnoncosting.Text
                descriptionglsalesacc = cmbdescglsales.Text
                descriptionglinvacc = cmbdescglinv.Text
                descriptionglcostacc = cmbdescglcost.Text
                descriptioncostingacc = cmbdesccosting.Text
                serviceglsalesacc = cmbserviceglsales.Text
                serviceglinvacc = cmbserviceglinv.Text
                serviceglcostacc = cmbserviceglcost.Text
                servicecostingacc = cmbservicecosting.Text
                laborglsalesacc = cmblaborglsales.Text
                laborglinvacc = cmblaborglinv.Text
                laborglcostacc = cmblaborglcost.Text
                laborcostingacc = cmblaborcosting.Text
                assemblyglsalesacc = cmbassemblyglsales.Text
                assemblyglinvacc = cmbassemblyglinv.Text
                assemblyglcostacc = cmbassemblyglcost.Text
                assemblycostingacc = cmbassemblycosting.Text
                activitylsalesacc = cmbactivityglsales.Text
                activityglinvacc = cmbactivityglinv.Text
                activityglcostacc = cmbactivityglcost.Text
                activitycostingacc = cmbactivitycosting.Text
                chargeglsalesacc = cmbchargeglsales.Text
                chargeglinvacc = cmbchargeglinv.Text
                chargeglcostacc = cmbchargeglcost.Text
                chargecostingacc = cmbchargecosting.Text
                glfreightacc = cmbglfreight.Text
                If chkautuid.Checked = True Then
                    autoid = "Yes"
                Else
                    autoid = "No"
                End If
                feesmonth = CInt(nudfeesmonth.Value.ToString())
                applydiscount = cmbapplydiscount.Text
                monthlyfeesacc = cmbmonthlyfeesacc.Text
                yearlyfeesacc = cmbyearlyfeesacc.Text
                libraryfeesacc = cmblibraryfeesacc.Text
                latefeesacc = cmblatefeesacc.Text
                otherfeesacc = cmbotherfeesacc.Text
                examfeesacc = cmbexamfeesacc.Text
                discountfeesacc = cmbdiscountfeesacc.Text
                bankdepositacc = cmbbankdepositacc.Text
                purchaseorderacc = cmbpurchaseorderacc.Text
                salesinvoiceacc = cmbsalesinvoiceacc.Text
                Dim cls As New cSetupDefaults()
                cls.UpdateInstituteDefault(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, alwayspurchase, invoicemessage, ordermessage, gameexpense, customfield1, customfield2, customfield3, customfield4, customfield5, checkcustomfield1, checkcustomfield2, checkcustomfield3, checkcustomfield4, checkcustomfield5, costmethod, stockglsalesacc, stockglinvacc, stockglcostacc, stockcostingacc, masterglsalesacc, masterglinvacc, masterglcostacc, mastercostingacc, nonstockglsalesacc, nonstockglinvacc, nonstockglcostacc, nonstockcostingacc, descriptionglsalesacc, descriptionglinvacc, descriptionglcostacc, descriptioncostingacc, serviceglsalesacc, serviceglinvacc, serviceglcostacc, servicecostingacc, laborglsalesacc, laborglinvacc, laborglcostacc, laborcostingacc, assemblyglsalesacc, assemblyglinvacc, assemblyglcostacc, assemblycostingacc, activitylsalesacc, activityglinvacc, activityglcostacc, activitycostingacc, chargeglsalesacc, chargeglinvacc, chargeglcostacc, chargecostingacc, glfreightacc, autoid, feesmonth, applydiscount, monthlyfeesacc, yearlyfeesacc, libraryfeesacc, latefeesacc, otherfeesacc, examfeesacc, discountfeesacc, bankdepositacc, purchaseorderacc, salesinvoiceacc)
                If cls.UpdateInstituteDefaultOk = True Then
                    Dim result1 As DialogResult = MessageBox.Show("Record updated successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If result1 = Windows.Forms.DialogResult.OK Then
                        cmd.CommandText = "select * from DefaultInstitute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                        dr = cmd.ExecuteReader
                        If dr.Read() Then
                            If dr("autoid").ToString() = "Yes" Then
                                ISDAutoID = "Yes"
                            Else
                                ISDAutoID = "No"
                            End If
                            ISDFeesMonth = CInt(dr("feesmonth").ToString())
                            ISDApplyDiscount = dr("applydiscount").ToString()
                            If dr("alwayspurchase").ToString() = "Yes" Then
                                ISDAlwaysPurchase = "Yes"
                            Else
                                ISDAlwaysPurchase = "No"
                            End If
                            ISDInvoiceMessage = dr("invoicemessage").ToString()
                            ISDOrderMessage = dr("ordermessage").ToString()
                            ISDGameExpense = dr("gameexpense").ToString()
                            ISDCustomField1 = dr("customfield1").ToString()
                            ISDCustomField2 = dr("customfield2").ToString()
                            ISDCustomField3 = dr("customfield3").ToString()
                            ISDCustomField4 = dr("customfield4").ToString()
                            ISDCustomField5 = dr("customfield5").ToString()
                            If dr("checkcustomfield1").ToString() = "Yes" Then
                                ISDCheckCustomField1 = "Yes"
                            Else
                                ISDCheckCustomField1 = "No"
                            End If
                            If dr("checkcustomfield2").ToString() = "Yes" Then
                                ISDCheckCustomField2 = "Yes"
                            Else
                                ISDCheckCustomField2 = "No"
                            End If
                            If dr("checkcustomfield3").ToString() = "Yes" Then
                                ISDCheckCustomField3 = "Yes"
                            Else
                                ISDCheckCustomField3 = "No"
                            End If
                            If dr("checkcustomfield4").ToString() = "Yes" Then
                                ISDCheckCustomField4 = "Yes"
                            Else
                                ISDCheckCustomField4 = "No"
                            End If
                            If dr("checkcustomfield5").ToString() = "Yes" Then
                                ISDCheckCustomField5 = "Yes"
                            Else
                                ISDCheckCustomField5 = "No"
                            End If
                            ISDCostMethod = dr("costmethod").ToString()
                            ISDStockGLSalesAccount = dr("stockglsalesacc").ToString()
                            ISDStockGLInvAccount = dr("stockglinvacc").ToString()
                            ISDStockGLCostAccount = dr("stockglcostacc").ToString()
                            ISDStockCostingAccount = dr("stockcostingacc").ToString()
                            ISDMasterGLSalesAccount = dr("masterglsalesacc").ToString()
                            ISDMasterGLInvAccount = dr("masterglinvacc").ToString()
                            ISDMasterGLCostAccount = dr("masterglcostacc").ToString()
                            ISDMasterCostingAccount = dr("mastercostingacc").ToString()
                            ISDNonStockGLSalesAccount = dr("nonstockglsalesacc").ToString()
                            ISDNonStockGLInvAccount = dr("nonstockglinvacc").ToString()
                            ISDNonStockGLCostAccount = dr("nonstockglcostacc").ToString()
                            ISDNonStockCostingAccount = dr("nonstockcostingacc").ToString()
                            ISDDescriptionGLSalesAccount = dr("descriptionglsalesacc").ToString()
                            ISDDescriptionGLInvAccount = dr("descriptionglinvacc").ToString()
                            ISDDescriptionGLCostAccount = dr("descriptionglcostacc").ToString()
                            ISDDescriptionCostingAccount = dr("descriptioncostingacc").ToString()
                            ISDServiceGLSalesAccount = dr("serviceglsalesacc").ToString()
                            ISDServiceGLInvAccount = dr("serviceglinvacc").ToString()
                            ISDServiceGLCostAccount = dr("serviceglcostacc").ToString()
                            ISDServiceCostingAccount = dr("servicecostingacc").ToString()
                            ISDLaborGLSalesAccount = dr("laborglsalesacc").ToString()
                            ISDLaborGLInvAccount = dr("laborglinvacc").ToString()
                            ISDLaborGLCostAccount = dr("laborglcostacc").ToString()
                            ISDLaborCostingAccount = dr("laborcostingacc").ToString()
                            ISDAssemblyGLSalesAccount = dr("assemblyglsalesacc").ToString()
                            ISDAssemblyGLInvAccount = dr("assemblyglinvacc").ToString()
                            ISDAssemblyGLCostAccount = dr("assemblyglcostacc").ToString()
                            ISDAssemblyCostingAccount = dr("assemblycostingacc").ToString()
                            ISDActivityGLSalesAccount = dr("activitylsalesacc").ToString()
                            ISDActivityGLInvAccount = dr("activityglinvacc").ToString()
                            ISDActivityGLCostAccount = dr("activityglcostacc").ToString()
                            ISDActivityCostingAccount = dr("activitycostingacc").ToString()
                            ISDChargeGLSalesAccount = dr("chargeglsalesacc").ToString()
                            ISDChargeGLInvAccount = dr("chargeglinvacc").ToString()
                            ISDChargeGLCostAccount = dr("chargeglcostacc").ToString()
                            ISDChargeCostingAccount = dr("chargecostingacc").ToString()
                            ISDGLFreightAccount = dr("glfreightacc").ToString()
                            ISDMonthlyFeesAccount = dr("monthlyfeesacc").ToString()
                            ISDYearlyFeesAccount = dr("yearlyfeesacc").ToString()
                            ISDLibraryFeesAccount = dr("libraryfeesacc").ToString()
                            ISDLateFeesAccount = dr("latefeesacc").ToString()
                            ISDOtherFeesAccount = dr("otherfeesacc").ToString()
                            ISDExamFeesAccount = dr("examfeesacc").ToString()
                            ISDDiscountFeesAccount = dr("discountfeesacc").ToString()
                            ISDBankDepositAccount = dr("bankdepositacc").ToString()
                            ISDPurchaseOrderAccount = dr("purchaseorderacc").ToString()
                            ISDSalesInvoiceAccount = dr("salesinvoiceacc").ToString()
                        End If
                        dr.Close()
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadInstituteDefault()
        Try
            cmd.CommandText = "select * from DefaultInstitute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                If dr("autoid").ToString() = "Yes" Then
                    chkautuid.Checked = True
                Else
                    chkautuid.Checked = False
                End If
                nudfeesmonth.Value = CInt(dr("feesmonth").ToString())
                cmbapplydiscount.Text = dr("applydiscount").ToString()
                If dr("alwayspurchase").ToString() = "Yes" Then
                    chkpurchaseorder.Checked = True
                Else
                    chkpurchaseorder.Checked = False
                End If
                If dr("invoicemessage").ToString() = rbtnsalesinvoice1.Text Then
                    rbtnsalesinvoice1.Checked = True
                ElseIf dr("invoicemessage").ToString() = rbtnsalesinvoice2.Text Then
                    rbtnsalesinvoice2.Checked = True
                ElseIf dr("invoicemessage").ToString() = rbtnsalesinvoice3.Text Then
                    rbtnsalesinvoice3.Checked = True
                End If
                If dr("ordermessage").ToString() = rbtnsalesorder1.Text Then
                    rbtnsalesorder1.Checked = True
                ElseIf dr("ordermessage").ToString() = rbtnsalesorder2.Text Then
                    rbtnsalesorder2.Checked = True
                ElseIf dr("ordermessage").ToString() = rbtnsalesorder3.Text Then
                    rbtnsalesorder3.Checked = True
                End If
                cmbgameaccount.Text = dr("gameexpense").ToString()
                txtcustomfield1.Text = dr("customfield1").ToString()
                txtcustomfield2.Text = dr("customfield2").ToString()
                txtcustomfield3.Text = dr("customfield3").ToString()
                txtcustomfield4.Text = dr("customfield4").ToString()
                txtcustomfield5.Text = dr("customfield5").ToString()
                If dr("checkcustomfield1").ToString() = "Yes" Then
                    chkcustomfield1.Checked = True
                Else
                    chkcustomfield1.Checked = False
                End If
                If dr("checkcustomfield2").ToString() = "Yes" Then
                    chkcustomfield2.Checked = True
                Else
                    chkcustomfield2.Checked = False
                End If
                If dr("checkcustomfield3").ToString() = "Yes" Then
                    chkcustomfield3.Checked = True
                Else
                    chkcustomfield3.Checked = False
                End If
                If dr("checkcustomfield4").ToString() = "Yes" Then
                    chkcustomfield4.Checked = True
                Else
                    chkcustomfield4.Checked = False
                End If
                If dr("checkcustomfield5").ToString() = "Yes" Then
                    chkcustomfield5.Checked = True
                Else
                    chkcustomfield5.Checked = False
                End If
                cmbcostmethod.Text = dr("costmethod").ToString()
                cmbstockglsales.Text = dr("stockglsalesacc").ToString()
                cmbstockglinv.Text = dr("stockglinvacc").ToString()
                cmbstockglcost.Text = dr("stockglcostacc").ToString()
                cmbstockcosting.Text = dr("stockcostingacc").ToString()
                cmbmasterglsales.Text = dr("masterglsalesacc").ToString()
                cmbmasterglinv.Text = dr("masterglinvacc").ToString()
                cmbmasterglcost.Text = dr("masterglcostacc").ToString()
                cmbmastercosting.Text = dr("mastercostingacc").ToString()
                cmbnonglsales.Text = dr("nonstockglsalesacc").ToString()
                cmbnonglinv.Text = dr("nonstockglinvacc").ToString()
                cmbnonglcost.Text = dr("nonstockglcostacc").ToString()
                cmbnoncosting.Text = dr("nonstockcostingacc").ToString()
                cmbdescglsales.Text = dr("descriptionglsalesacc").ToString()
                cmbdescglinv.Text = dr("descriptionglinvacc").ToString()
                cmbdescglcost.Text = dr("descriptionglcostacc").ToString()
                cmbdesccosting.Text = dr("descriptioncostingacc").ToString()
                cmbserviceglsales.Text = dr("serviceglsalesacc").ToString()
                cmbserviceglinv.Text = dr("serviceglinvacc").ToString()
                cmbserviceglcost.Text = dr("serviceglcostacc").ToString()
                cmbservicecosting.Text = dr("servicecostingacc").ToString()
                cmblaborglsales.Text = dr("laborglsalesacc").ToString()
                cmblaborglinv.Text = dr("laborglinvacc").ToString()
                cmblaborglcost.Text = dr("laborglcostacc").ToString()
                cmblaborcosting.Text = dr("laborcostingacc").ToString()
                cmbassemblyglsales.Text = dr("assemblyglsalesacc").ToString()
                cmbassemblyglinv.Text = dr("assemblyglinvacc").ToString()
                cmbassemblyglcost.Text = dr("assemblyglcostacc").ToString()
                cmbassemblycosting.Text = dr("assemblycostingacc").ToString()
                cmbactivityglsales.Text = dr("activitylsalesacc").ToString()
                cmbactivityglinv.Text = dr("activityglinvacc").ToString()
                cmbactivityglcost.Text = dr("activityglcostacc").ToString()
                cmbactivitycosting.Text = dr("activitycostingacc").ToString()
                cmbchargeglsales.Text = dr("chargeglsalesacc").ToString()
                cmbchargeglinv.Text = dr("chargeglinvacc").ToString()
                cmbchargeglcost.Text = dr("chargeglcostacc").ToString()
                cmbchargecosting.Text = dr("chargecostingacc").ToString()
                cmbglfreight.Text = dr("glfreightacc").ToString()
                cmbmonthlyfeesacc.Text = dr("monthlyfeesacc").ToString()
                cmbyearlyfeesacc.Text = dr("yearlyfeesacc").ToString()
                cmblibraryfeesacc.Text = dr("libraryfeesacc").ToString()
                cmblatefeesacc.Text = dr("latefeesacc").ToString()
                cmbotherfeesacc.Text = dr("otherfeesacc").ToString()
                cmbexamfeesacc.Text = dr("examfeesacc").ToString()
                cmbdiscountfeesacc.Text = dr("discountfeesacc").ToString()
                cmbbankdepositacc.Text = dr("bankdepositacc").ToString()
                cmbpurchaseorderacc.Text = dr("purchaseorderacc").ToString()
                cmbsalesinvoiceacc.Text = dr("salesinvoiceacc").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmSetupDefaultsInstitute_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
        LoadAccounts()
        LoadInstituteDefault()
        If USInstituteDefault = "View Only" Then
            btnsave.Enabled = False
            chkautuid.Enabled = False
            chkcustomfield1.Enabled = False
            chkcustomfield2.Enabled = False
            chkcustomfield3.Enabled = False
            chkcustomfield4.Enabled = False
            chkcustomfield5.Enabled = False
            chkpurchaseorder.Enabled = False
            txtcustomfield1.ReadOnly = True
            txtcustomfield2.ReadOnly = True
            txtcustomfield3.ReadOnly = True
            txtcustomfield4.ReadOnly = True
            txtcustomfield5.ReadOnly = True
            cmbactivitycosting.Enabled = False
            cmbactivityglcost.Enabled = False
            cmbactivityglinv.Enabled = False
            cmbactivityglsales.Enabled = False
            cmbapplydiscount.Enabled = False
            cmbassemblycosting.Enabled = False
            cmbassemblyglcost.Enabled = False
            cmbassemblyglinv.Enabled = False
            cmbassemblyglsales.Enabled = False
            cmbbankdepositacc.Enabled = False
            cmbchargecosting.Enabled = False
            cmbchargeglcost.Enabled = False
            cmbchargeglinv.Enabled = False
            cmbchargeglsales.Enabled = False
            cmbcostmethod.Enabled = False
            cmbdesccosting.Enabled = False
            cmbdescglcost.Enabled = False
            cmbdescglinv.Enabled = False
            cmbdescglsales.Enabled = False
            cmbdiscountfeesacc.Enabled = False
            cmbexamfeesacc.Enabled = False
            cmbgameaccount.Enabled = False
            cmbglfreight.Enabled = False
            cmblaborcosting.Enabled = False
            cmblaborglcost.Enabled = False
            cmblaborglinv.Enabled = False
            cmblaborglsales.Enabled = False
            cmblatefeesacc.Enabled = False
            cmblibraryfeesacc.Enabled = False
            cmbmastercosting.Enabled = False
            cmbmasterglcost.Enabled = False
            cmbmasterglinv.Enabled = False
            cmbmasterglsales.Enabled = False
            cmbmonthlyfeesacc.Enabled = False
            cmbnoncosting.Enabled = False
            cmbnonglcost.Enabled = False
            cmbnonglinv.Enabled = False
            cmbnonglsales.Enabled = False
            cmbotherfeesacc.Enabled = False
            cmbpurchaseorderacc.Enabled = False
            cmbservicecosting.Enabled = False
            cmbserviceglcost.Enabled = False
            cmbserviceglinv.Enabled = False
            cmbserviceglsales.Enabled = False
            cmbstockcosting.Enabled = False
            cmbstockglcost.Enabled = False
            cmbstockglinv.Enabled = False
            cmbstockglsales.Enabled = False
            cmbyearlyfeesacc.Enabled = False
            cmbsalesinvoiceacc.Enabled = False
            nudfeesmonth.Enabled = False
        End If
    End Sub
#End Region
#Region "Attributes..."
    Private Sub txtcustomfield1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtcustomfield2.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            ETabControl1.SelectTab(TabPage2)
        End If
    End Sub

    Private Sub txtcustomfield2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtcustomfield3.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcustomfield1.Focus()
        End If
    End Sub

    Private Sub txtcustomfield3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtcustomfield4.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcustomfield2.Focus()
        End If
    End Sub

    Private Sub txtcustomfield4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtcustomfield5.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcustomfield3.Focus()
        End If
    End Sub

    Private Sub txtcustomfield5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            cmbcostmethod.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcustomfield4.Focus()
        End If
    End Sub

    Private Sub txtcustomfield5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbcostmethod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ETabControl1.SelectTab(TabPage4)
            cmbstockglsales.Focus()
        End If
    End Sub

    Private Sub cmbstockglsales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbstockglinv.Focus()
        End If
    End Sub

    Private Sub cmbstockglinv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbstockglcost.Focus()
        End If
    End Sub

    Private Sub cmbstockglcost_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbstockcosting.Focus()
        End If
    End Sub

    Private Sub cmbstockcosting_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbmasterglsales.Focus()
        End If
    End Sub

    Private Sub cmbmasterglsales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbmasterglinv.Focus()
        End If
    End Sub

    Private Sub cmbmasterglinv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbmasterglcost.Focus()
        End If
    End Sub

    Private Sub cmbmasterglcost_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbmastercosting.Focus()
        End If
    End Sub

    Private Sub cmbmastercosting_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbnonglsales.Focus()
        End If
    End Sub

    Private Sub cmbnonglsales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbnonglinv.Focus()
        End If
    End Sub

    Private Sub cmbnonglinv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbnonglcost.Focus()
        End If
    End Sub

    Private Sub cmbnonglcost_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbnoncosting.Focus()
        End If
    End Sub

    Private Sub cmbnoncosting_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbdescglsales.Focus()
        End If
    End Sub

    Private Sub cmbdescglsales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbdescglinv.Focus()
        End If
    End Sub

    Private Sub cmbdescglinv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbdescglcost.Focus()
        End If
    End Sub

    Private Sub cmbdescglcost_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbdesccosting.Focus()
        End If
    End Sub

    Private Sub cmbdesccosting_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbserviceglsales.Focus()
        End If
    End Sub

    Private Sub cmbserviceglsales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbserviceglinv.Focus()
        End If
    End Sub

    Private Sub cmbserviceglinv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbserviceglcost.Focus()
        End If
    End Sub

    Private Sub cmbserviceglcost_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbservicecosting.Focus()
        End If
    End Sub

    Private Sub cmbservicecosting_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmblaborglsales.Focus()
        End If
    End Sub

    Private Sub cmblaborglsales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmblaborglinv.Focus()
        End If
    End Sub

    Private Sub cmblaborglinv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmblaborglcost.Focus()
        End If
    End Sub

    Private Sub cmblaborglcost_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmblaborcosting.Focus()
        End If
    End Sub

    Private Sub cmblaborcosting_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbassemblyglsales.Focus()
        End If
    End Sub

    Private Sub cmbassemblyglsales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbassemblyglinv.Focus()
        End If
    End Sub

    Private Sub cmbassemblyglinv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbassemblyglcost.Focus()
        End If
    End Sub

    Private Sub cmbassemblyglcost_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbassemblycosting.Focus()
        End If
    End Sub

    Private Sub cmbassemblycosting_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbactivityglsales.Focus()
        End If
    End Sub

    Private Sub cmbactivityglsales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbactivityglinv.Focus()
        End If
    End Sub

    Private Sub cmbactivityglinv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbactivityglcost.Focus()
        End If
    End Sub

    Private Sub cmbactivityglcost_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbactivitycosting.Focus()
        End If
    End Sub

    Private Sub cmbactivitycosting_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbchargeglsales.Focus()
        End If
    End Sub

    Private Sub cmbchargeglsales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbchargeglinv.Focus()
        End If
    End Sub

    Private Sub cmbchargeglinv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbchargeglcost.Focus()
        End If
    End Sub

    Private Sub cmbchargeglcost_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbchargecosting.Focus()
        End If
    End Sub

    Private Sub cmbchargecosting_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbglfreight.Focus()
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        UpdateInstituteDefaultRecord()
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        LoadInstituteDefault()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region