#Region "Imports..."
Imports ESAR_Controls.UIControls.ComboBox
Imports ESAR_Controls.UIControls.TextBox
#End Region
#Region "Class frmAddInventoryItem..."
Public Class frmAddInventoryItem
#Region "Declarations..."
    Private ACODE As String = ""
    Private TT As String = ""
    Private GLSalesAccount As String = ""
    Private GLInventoryAccount As String = ""
    Private HistI As Boolean = False
    Private UnitPrice As Decimal = 0.0
    Private Unit As String = ""
    Private Qnty As Decimal = 0.0
    Private InventoryPriceLevelExist As Boolean = False
    Private DGVGLInventoryAccount As New DataGridView()
    Private DGVGLSalesAccount As New DataGridView()
    Private Price(9) As Decimal
    Private ItemExist As Boolean = False
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        ACODE = Indx.LoadInventoryID()
        Dim var As String
        var = CodeIncrement(ACODE)
        Me.txtitemid.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("INV:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        Label2.SetBounds(13, 58, 76, 13)
        Label3.SetBounds(13, 31, 57, 13)
        Label4.SetBounds(263, 31, 74, 13)
        Label5.SetBounds(20, 31, 36, 13)
        Label6.SetBounds(20, 58, 48, 13)
        Label7.SetBounds(13, 85, 76, 13)
        Label8.SetBounds(9, 12, 76, 13)
        lblcostmethod.SetBounds(9, 66, 83, 13)
        lblpricelevel.SetBounds(9, 39, 74, 13)
        lblqntyonhand.SetBounds(405, 66, 32, 13)
        lblqntyonhandhead.SetBounds(288, 66, 111, 13)
        lblqntyunit.SetBounds(513, 66, 90, 13)
        lblitemtype.SetBounds(11, 12, 70, 13)
        lblstocking.SetBounds(197, 12, 87, 13)
        lblweight.SetBounds(9, 39, 50, 13)
        lblminimumstockhead.SetBounds(9, 66, 67, 13)
        lbllastunitcost.SetBounds(265, 39, 65, 13)
        lblpreferredvendor.SetBounds(18, 12, 110, 13)
        lblglsalesacchead.SetBounds(18, 40, 111, 13)
        lblglinvtryacchead.SetBounds(18, 66, 136, 13)
        lblcostingacchead.SetBounds(18, 120, 104, 13)
        lblglcostacchead.SetBounds(18, 93, 106, 13)
        lblglsalesacc.SetBounds(157, 40, 111, 13)
        lblglinvtryacc.SetBounds(157, 66, 136, 13)
        lblcostingacc.SetBounds(157, 120, 104, 13)
        lblglcostacc.SetBounds(157, 93, 106, 13)

        btnpricelevel.SetBounds(225, 35, 20, 20)
        chkinactive.SetBounds(74, 89, 72, 17)
        chkcommission.SetBounds(152, 89, 155, 17)

        cmbcostmethod.SetBounds(106, 63, 78, 21)
        cmbdescription.SetBounds(106, 9, 139, 21)
        cmbitemclass.SetBounds(343, 28, 116, 21)
        cmbsize.SetBounds(74, 28, 210, 21)
        cmbtaxtype.SetBounds(190, 63, 92, 21)
        cmbshape.SetBounds(74, 55, 210, 22)
        cmbitemtype.SetBounds(106, 9, 85, 22)
        cmbstocking.SetBounds(285, 9, 109, 22)
        cmbweight.SetBounds(183, 36, 76, 22)
        cmbminstockunit.SetBounds(181, 63, 109, 22)

        txtitemid.SetBounds(111, 28, 138, 21)
        txtitemname.SetBounds(111, 55, 348, 21)
        txtitemshort.SetBounds(111, 82, 348, 21)
        txtpricelevel.SetBounds(106, 36, 116, 21)
        txtitemlong.SetBounds(251, 9, 508, 48)
        txtweight.SetBounds(107, 36, 70, 21)
        txtlastprice.SetBounds(329, 36, 65, 21)
        txtminstock.SetBounds(107, 62, 70, 48)
        txtvendor.SetBounds(160, 9, 185, 48)
    End Sub

    Private Sub LoadShape()
        cmbshape.Items.Add(New ComboBoxIconItem("Polygon", 0))
        cmbshape.Items.Add(New ComboBoxIconItem("Quadrilateral", 1))
        cmbshape.Items.Add(New ComboBoxIconItem("Square", 2))
        cmbshape.Items.Add(New ComboBoxIconItem("Triangle", 3))
        cmbshape.Items.Add(New ComboBoxIconItem("Rectangle", 4))
        cmbshape.Items.Add(New ComboBoxIconItem("Parallelogram", 5))
        cmbshape.Items.Add(New ComboBoxIconItem("Pentagon", 6))
        cmbshape.Items.Add(New ComboBoxIconItem("Hexagon", 7))
        cmbshape.Items.Add(New ComboBoxIconItem("Heptagon", 8))
        cmbshape.Items.Add(New ComboBoxIconItem("Octagon", 9))
        cmbshape.Items.Add(New ComboBoxIconItem("Nonagon", 10))
        cmbshape.Items.Add(New ComboBoxIconItem("Decagon", 11))
        cmbshape.Items.Add(New ComboBoxIconItem("Cube", 12))
        cmbshape.Items.Add(New ComboBoxIconItem("Cuboid", 13))
        cmbshape.Items.Add(New ComboBoxIconItem("Sphere", 14))
        cmbshape.Items.Add(New ComboBoxIconItem("Cylinder", 15))
        cmbshape.Items.Add(New ComboBoxIconItem("Cone", 16))
        cmbshape.Items.Add(New ComboBoxIconItem("Triangular Prism", 17))
        cmbshape.Items.Add(New ComboBoxIconItem("Hexagonal Prism", 18))
        cmbshape.Items.Add(New ComboBoxIconItem("Triangular-based Pyramid", 19))
        cmbshape.Items.Add(New ComboBoxIconItem("Square-based Pyramid", 20))
        cmbshape.Items.Add(New ComboBoxIconItem("Hexagonal Pyramid", 21))
        cmbshape.Items.Add(New ComboBoxIconItem("Trapezium", 22))
        cmbshape.Items.Add(New ComboBoxIconItem("Kite", 23))
        cmbshape.Items.Add(New ComboBoxIconItem("Trapezoid", 24))
        cmbshape.Items.Add(New ComboBoxIconItem("Parallelogram", 25))
        cmbshape.Items.Add(New ComboBoxIconItem("Rhombus", 26))
        cmbshape.Items.Add(New ComboBoxIconItem("Other", 27))
    End Sub

    Private Sub MinStockUnit(ByVal Unt As String)
        Try
            If Unt = "Gram" Or Unt = "Kilogram" Or Unt = "Milligram" Or Unt = "Quintal" Or Unt = "Tonne" Then
                cmbminstockunit.Items.Clear()
                cmbminstockunit.Items.Add("Kilogram")
                cmbminstockunit.Items.Add("Gram")
                cmbminstockunit.Items.Add("Milligram")
                cmbminstockunit.Items.Add("Quintal")
                cmbminstockunit.Items.Add("Tonne")
            ElseIf Unt = "Milliliter" Or Unt = "Liter" Or Unt = "Barrel" Or Unt = "Gallon" Then
                cmbminstockunit.Items.Clear()
                cmbminstockunit.Items.Add("Liter")
                cmbminstockunit.Items.Add("Milliliter")
                cmbminstockunit.Items.Add("Barrel")
                cmbminstockunit.Items.Add("Gallon")
            ElseIf Unt = "Square foot" Or Unt = "Square inch" Or Unt = "Square kilometer" Or Unt = "Square mile" Or Unt = "Square meter" Or Unt = "Square centimeter" Or Unt = "Square millimeter" Or Unt = "Hectare" Or Unt = "Square Yard" Or Unt = "Acre" Then
                cmbminstockunit.Items.Clear()
                cmbminstockunit.Items.Add("Square foot")
                cmbminstockunit.Items.Add("Square inch")
                cmbminstockunit.Items.Add("Square kilometer")
                cmbminstockunit.Items.Add("Square mile")
                cmbminstockunit.Items.Add("Square meter")
                cmbminstockunit.Items.Add("Square centimeter")
                cmbminstockunit.Items.Add("Square millimeter")
                cmbminstockunit.Items.Add("Hectare")
                cmbminstockunit.Items.Add("Square Yard")
                cmbminstockunit.Items.Add("Acre")
            ElseIf Unt = "Meter" Or Unt = "Centi Meter" Or Unt = "Kilometer" Or Unt = "Foot" Or Unt = "Inch" Then
                cmbminstockunit.Items.Clear()
                cmbminstockunit.Items.Add("Meter")
                cmbminstockunit.Items.Add("Centi Meter")
                cmbminstockunit.Items.Add("Kilometer")
                cmbminstockunit.Items.Add("Foot")
                cmbminstockunit.Items.Add("Inch")
            ElseIf Unt = "Pieces" Or Unt = "Dozen" Then
                cmbminstockunit.Items.Clear()
                cmbminstockunit.Items.Add("Pieces")
                cmbminstockunit.Items.Add("Dozen")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadDefaultField()
        Try
            Dim i As Integer = 0
            cmd.CommandText = "select customfield1,customfield2,customfield3,customfield4,customfield5,checkcustomfield1,checkcustomfield2,checkcustomfield3,checkcustomfield4,checkcustomfield5,costmethod from DefaultInstitute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            cmbcostmethod.Text = dr("costmethod").ToString()
            If dr("checkcustomfield1").ToString() = "Yes" Then
                dgviewcustomfield.Rows.Add()
                dgviewcustomfield.Rows(i).Cells(1).ReadOnly = False
                dgviewcustomfield.Rows(i).Cells(0).Value = "1"
                dgviewcustomfield.Rows(i).Cells(1).Value = dr("customfield1").ToString() + ":"
                dgviewcustomfield.Rows(i).Cells(2).Value = ""
                i = i + 1
            End If
            If dr("checkcustomfield2").ToString() = "Yes" Then
                dgviewcustomfield.Rows.Add()
                dgviewcustomfield.Rows(i).Cells(1).ReadOnly = False
                dgviewcustomfield.Rows(i).Cells(0).Value = "2"
                dgviewcustomfield.Rows(i).Cells(1).Value = dr("customfield2").ToString() + ":"
                dgviewcustomfield.Rows(i).Cells(2).Value = ""
                i = i + 1 
            End If
            If dr("checkcustomfield3").ToString() = "Yes" Then
                dgviewcustomfield.Rows.Add()
                dgviewcustomfield.Rows(i).Cells(1).ReadOnly = False
                dgviewcustomfield.Rows(i).Cells(0).Value = "3"
                dgviewcustomfield.Rows(i).Cells(1).Value = dr("customfield3").ToString() + ":"
                dgviewcustomfield.Rows(i).Cells(2).Value = ""
                i = i + 1 
            End If
            If dr("checkcustomfield4").ToString() = "Yes" Then
                dgviewcustomfield.Rows.Add()
                dgviewcustomfield.Rows(i).Cells(1).ReadOnly = False
                dgviewcustomfield.Rows(i).Cells(0).Value = "4"
                dgviewcustomfield.Rows(i).Cells(1).Value = dr("customfield4").ToString() + ":"
                dgviewcustomfield.Rows(i).Cells(2).Value = ""
                i = i + 1 
            End If
            If dr("checkcustomfield5").ToString() = "Yes" Then
                dgviewcustomfield.Rows.Add()
                dgviewcustomfield.Rows(i).Cells(1).ReadOnly = False
                dgviewcustomfield.Rows(i).Cells(0).Value = "5"
                dgviewcustomfield.Rows(i).Cells(1).Value = dr("customfield5").ToString() + ":"
                dgviewcustomfield.Rows(i).Cells(2).Value = ""
                i = i + 1 
            End If
            dr.Close()
            For j As Integer = 0 To dgviewcustomfield.Rows.Count - 1
                dgviewcustomfield.Rows(j).Cells(0).Style.BackColor = Color.DimGray
                dgviewcustomfield.Rows(j).Cells(0).Style.ForeColor = Color.White
                dgviewcustomfield.Rows(j).Cells(0).Style.SelectionBackColor = Color.DimGray
                dgviewcustomfield.Rows(j).Cells(0).Style.SelectionForeColor = Color.White
                dgviewcustomfield.Rows(j).Cells(1).Style.BackColor = Color.DimGray
                dgviewcustomfield.Rows(j).Cells(1).Style.ForeColor = Color.White
                dgviewcustomfield.Rows(j).Cells(1).Style.SelectionBackColor = Color.DimGray
                dgviewcustomfield.Rows(j).Cells(1).Style.SelectionForeColor = Color.White
            Next
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CheckHistory(ByVal ID As String)
        Try
            cmd.CommandText = "select * from ItemHistory where itemid='" & ID & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                HistI = True
            Else
                HistI = False
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadHistory(ByVal ITID As String)
        Try
            CheckHistory(ITID)
            If HistI = True Then
                Dim indx As Integer = 0
                dgviewitemhistory.Rows.Clear()
                cmd.CommandText = "select * from ItemHistory where itemid='" & ITID & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    dgviewitemhistory.Rows.Add()
                    dgviewitemhistory.Rows(indx).Cells(0).Value = dr("itemid").ToString()
                    dgviewitemhistory.Rows(indx).Cells(1).Value = dr("itemname").ToString()
                    dgviewitemhistory.Rows(indx).Cells(2).Value = dr("itemclass").ToString()
                    dgviewitemhistory.Rows(indx).Cells(3).Value = dr("id").ToString()
                    dgviewitemhistory.Rows(indx).Cells(4).Value = dr("date").ToString()
                    Dim prc As Decimal = CDec(dr("soldprice").ToString())
                    dgviewitemhistory.Rows(indx).Cells(5).Value = FormatNumber(prc.ToString())
                    dgviewitemhistory.Rows(indx).Cells(6).Value = dr("qunatity").ToString() + " " + dr("unit").ToString()
                    dgviewitemhistory.Rows(indx).Cells(7).Value = dr("purpose").ToString()
                    indx = indx + 1
                End While
                dr.Close()
                dgviewitemhistory.ClearSelection()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadItemPriceLevel()
        Try
            cmd.CommandText = "select * from InventoryItemPriceLevel where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and itemid='" & txtitemid.Text & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                If dr("defaultlevel").ToString() = "Price Level 1" Then
                    Dim a1 As Decimal = CDec(dr("levelprice1").ToString())
                    txtpricelevel.Text = FormatNumber(a1.ToString())
                ElseIf dr("defaultlevel").ToString() = "Price Level 2" Then
                    Dim a1 As Decimal = CDec(dr("levelprice2").ToString())
                    txtpricelevel.Text = FormatNumber(a1.ToString())
                ElseIf dr("defaultlevel").ToString() = "Price Level 3" Then
                    Dim a1 As Decimal = CDec(dr("levelprice3").ToString())
                    txtpricelevel.Text = FormatNumber(a1.ToString())
                ElseIf dr("defaultlevel").ToString() = "Price Level 4" Then
                    Dim a1 As Decimal = CDec(dr("levelprice4").ToString())
                    txtpricelevel.Text = FormatNumber(a1.ToString())
                ElseIf dr("defaultlevel").ToString() = "Price Level 5" Then
                    Dim a1 As Decimal = CDec(dr("levelprice5").ToString())
                    txtpricelevel.Text = FormatNumber(a1.ToString())
                ElseIf dr("defaultlevel").ToString() = "Price Level 6" Then
                    Dim a1 As Decimal = CDec(dr("levelprice6").ToString())
                    txtpricelevel.Text = FormatNumber(a1.ToString())
                ElseIf dr("defaultlevel").ToString() = "Price Level 7" Then
                    Dim a1 As Decimal = CDec(dr("levelprice7").ToString())
                    txtpricelevel.Text = FormatNumber(a1.ToString())
                ElseIf dr("defaultlevel").ToString() = "Price Level 8" Then
                    Dim a1 As Decimal = CDec(dr("levelprice8").ToString())
                    txtpricelevel.Text = FormatNumber(a1.ToString())
                ElseIf dr("defaultlevel").ToString() = "Price Level 9" Then
                    Dim a1 As Decimal = CDec(dr("levelprice9").ToString())
                    txtpricelevel.Text = FormatNumber(a1.ToString())
                ElseIf dr("defaultlevel").ToString() = "Price Level 10" Then
                    Dim a1 As Decimal = CDec(dr("levelprice10").ToString())
                    txtpricelevel.Text = FormatNumber(a1.ToString())
                End If
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadSelectedItemVendor()
        Try
            cmd.CommandText = "select vendorname from Purchase where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and itemid='" & txtitemid.Text & "' and itemname='" & txtitemname.Text & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                txtvendor.Text = dr("vendorname").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub ItemPriceCalculation()
        Try
            If cmbweight.Text = "Kilogram" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Gram"
                Qnty = weight * 1000
                UnitPrice = (totprc / Qnty)
            ElseIf cmbweight.Text = "Gram" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Gram"
                Qnty = weight
                UnitPrice = (totprc / Qnty)
            ElseIf cmbweight.Text = "Milligram" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Gram"
                Qnty = weight / 1000
                UnitPrice = (totprc / Qnty)
            ElseIf cmbweight.Text = "Quintal" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Gram"
                Qnty = weight * 100000
                UnitPrice = (totprc / Qnty)
            ElseIf cmbweight.Text = "Tonne" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Gram"
                Qnty = weight * 1000000
                UnitPrice = (totprc / Qnty)
            ElseIf cmbweight.Text = "Liter" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Milliliter"
                Qnty = weight * 1000
                UnitPrice = (totprc / Qnty)
            ElseIf cmbweight.Text = "Milliliter" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Milliliter"
                Qnty = weight
                UnitPrice = totprc / Qnty
            ElseIf cmbweight.Text = "Barrel" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Milliliter"
                Qnty = weight * 117347.765
                UnitPrice = (totprc / Qnty)
            ElseIf cmbweight.Text = "Gallon" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Milliliter"
                Qnty = weight * 3785.41178
                UnitPrice = (totprc / Qnty)
            ElseIf cmbweight.Text = "Square foot" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Square meter"
                Qnty = weight * 0.092903
                UnitPrice = (totprc / Qnty)
            ElseIf cmbweight.Text = "Square inch" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Square meter"
                Qnty = weight * 0.00064516
                UnitPrice = (totprc / Qnty)
            ElseIf cmbweight.Text = "Square kilometer" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Square meter"
                Qnty = weight * 1000000
                UnitPrice = (totprc / Qnty)
            ElseIf cmbweight.Text = "Square mile" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Square meter"
                Qnty = weight * 2589988.11
                UnitPrice = (totprc / Qnty)
            ElseIf cmbweight.Text = "Square meter" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Square meter"
                Qnty = weight
                UnitPrice = (totprc / Qnty)
            ElseIf cmbweight.Text = "Square centimeter" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Square meter"
                Qnty = weight * 0.0001
                UnitPrice = (totprc / Qnty)
            ElseIf cmbweight.Text = "Square millimeter" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Square meter"
                Qnty = weight * 0.000001
                UnitPrice = (totprc / Qnty)
            ElseIf cmbweight.Text = "Hectare" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Square meter"
                Qnty = weight * 10000
                UnitPrice = (totprc / Qnty)
            ElseIf cmbweight.Text = "Square Yard" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Square meter"
                Qnty = weight * 0.836127
                UnitPrice = (totprc / Qnty)
            ElseIf cmbweight.Text = "Acre" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Square meter"
                Qnty = weight * 4046.86
                UnitPrice = (totprc / Qnty)
            ElseIf cmbweight.Text = "Meter" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Meter"
                Qnty = weight
                UnitPrice = (totprc / Qnty)
            ElseIf cmbweight.Text = "Centi Meter" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Meter"
                Qnty = weight * 0.01
                UnitPrice = (totprc / Qnty)
            ElseIf cmbweight.Text = "Kilometer" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Meter"
                Qnty = weight * 1000
                UnitPrice = (totprc / Qnty)
            ElseIf cmbweight.Text = "Foot" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Meter"
                Qnty = weight * 0.3048
                UnitPrice = (totprc / Qnty)
            ElseIf cmbweight.Text = "Inch" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Meter"
                Qnty = weight * 0.0254
                UnitPrice = (totprc / Qnty)
            ElseIf cmbweight.Text = "Pieces" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Pieces"
                Qnty = weight
                UnitPrice = (totprc / Qnty)
            ElseIf cmbweight.Text = "Dozen" Then
                Dim weight As Decimal = CDec(txtweight.Text)
                Dim totprc As Decimal = CDec(txtpricelevel.Text)
                Unit = "Pieces"
                Qnty = weight * 12
                UnitPrice = (totprc / Qnty)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddRecord()
        Try
            If txtitemid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter serial no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtitemid.Focus()
                End If
            ElseIf cmbitemclass.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter serial no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbitemclass.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    CheckItemID()
                    If ItemExist = False Then
                        Dim Inactive As String = ""
                        Dim Commission As String = ""

                        If chkinactive.Checked = True Then
                            Inactive = "Yes"
                        Else
                            Inactive = "No"
                        End If
                        If chkcommission.Checked = True Then
                            Commission = "Yes"
                        Else
                            Commission = "No"
                        End If
                        Dim cls As New cInventory()
                        ItemPriceCalculation()
                        If cmbitemclass.Text = "Description Only" Then
                            Dim itemid As String = txtitemid.Text
                            Dim itemnt As String = ItemNote
                            Dim itemname As String = txtitemname.Text
                            Dim itemclass As String = cmbitemclass.Text
                            Dim descshort As String = txtitemshort.Text
                            Dim itemsize As String = cmbsize.Text
                            Dim itemshape As String = cmbshape.Text
                            Dim itemused As String = cmbdescription.Text
                            Dim descripbrief As String = txtitemlong.Text
                            Dim glsalesaccountid As String = lblglsalesacc.Text
                            Dim glinventoryaccountid As String = lblglinvtryacc.Text
                            Dim glcostsaccountid As String = lblglcostacc.Text
                            Dim costingaccountid As String = lblcostingacc.Text
                            Dim levelprice As Decimal = 0.0
                            Dim onhandqnty As Decimal = 0.0
                            Dim onhandqntyunit As String = ""
                            Dim lastsoldprice As Decimal = 0.0
                            Dim costmethod As String = ""
                            Dim minstockqnty As Decimal = 0.0
                            Dim minstockqntyunit As String = ""
                            Dim itemtaxtype As String = ""
                            Dim itemtype As String = ""
                            Dim stocking As String = ""
                            Dim weight As Decimal = 0.0
                            Dim weightunit As String = ""
                            Dim vendorname As String = ""
                            Dim customfield1 As String = ""
                            Dim customfield2 As String = ""
                            Dim customfield3 As String = ""
                            Dim customfield4 As String = ""
                            Dim customfield5 As String = ""
                            UnitPrice = 0.0
                            cls.AddInventoryItem(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, itemid, itemnt, itemname, itemclass, descshort, itemsize, itemshape, itemused, descripbrief, levelprice, onhandqnty, onhandqntyunit, lastsoldprice, costmethod, minstockqnty, minstockqntyunit, itemtaxtype, itemtype, stocking, weight, weightunit, vendorname, glsalesaccountid, glinventoryaccountid, glcostsaccountid, costingaccountid, customfield1, customfield2, customfield3, customfield4, customfield5, Inactive, Commission, UnitPrice)
                            Dim pricelevel As Decimal = 0.0
                            Dim LevelName As String = "Price Level 1"
                            cls.AddInventoryItemPriceLevel(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtitemid.Text, txtitemname.Text, txtitemlong.Text, pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, LevelName)
                        ElseIf cmbitemclass.Text = "Labor Item" Then
                            Dim itemid As String = txtitemid.Text
                            Dim itemnt As String = ItemNote
                            Dim itemname As String = txtitemname.Text
                            Dim itemclass As String = cmbitemclass.Text
                            Dim descshort As String = txtitemshort.Text
                            Dim itemsize As String = cmbsize.Text
                            Dim itemshape As String = cmbshape.Text
                            Dim itemused As String = cmbdescription.Text
                            Dim descripbrief As String = txtitemlong.Text
                            Dim glsalesaccountid As String = lblglsalesacc.Text
                            Dim glinventoryaccountid As String = lblglinvtryacc.Text
                            Dim glcostsaccountid As String = lblglcostacc.Text
                            Dim costingaccountid As String = lblcostingacc.Text
                            Dim levelprice As Decimal = CDec(txtpricelevel.Text)
                            Dim onhandqnty As Decimal = CDec(lblqntyonhand.Text)
                            Dim onhandqntyunit As String = lblqntyunit.Text
                            Dim lastsoldprice As Decimal = CDec(txtlastprice.Text)
                            Dim costmethod As String = cmbcostmethod.Text
                            Dim minstockqnty As Decimal = CDec(txtminstock.Text)
                            Dim minstockqntyunit As String = cmbminstockunit.Text
                            Dim itemtaxtype As String = cmbtaxtype.Text
                            Dim itemtype As String = cmbitemtype.Text
                            Dim stocking As String = cmbstocking.Text
                            Dim weight As Decimal = CDec(txtweight.Text)
                            Dim weightunit As String = cmbweight.Text
                            Dim vendorname As String = txtvendor.Text
                            Dim customfield1 As String = ""
                            Dim customfield2 As String = ""
                            Dim customfield3 As String = ""
                            Dim customfield4 As String = ""
                            Dim customfield5 As String = ""
                            cls.AddInventoryItem(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, itemid, itemnt, itemname, itemclass, descshort, itemsize, itemshape, itemused, descripbrief, levelprice, onhandqnty, onhandqntyunit, lastsoldprice, costmethod, minstockqnty, minstockqntyunit, itemtaxtype, itemtype, stocking, weight, weightunit, vendorname, glsalesaccountid, glinventoryaccountid, glcostsaccountid, costingaccountid, customfield1, customfield2, customfield3, customfield4, customfield5, Inactive, Commission, UnitPrice)
                            Dim pricelevel As Decimal = 0.0
                            Dim LevelName As String = "Price Level 1"
                            cls.AddInventoryItemPriceLevel(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtitemid.Text, txtitemname.Text, txtitemlong.Text, CDec(txtpricelevel.Text), pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, LevelName)
                        ElseIf cmbitemclass.Text = "Assembly Item" Then
                            Dim itemid As String = txtitemid.Text
                            Dim itemnt As String = ItemNote
                            Dim itemname As String = txtitemname.Text
                            Dim itemclass As String = cmbitemclass.Text
                            Dim descshort As String = txtitemshort.Text
                            Dim itemsize As String = cmbsize.Text
                            Dim itemshape As String = cmbshape.Text
                            Dim itemused As String = cmbdescription.Text
                            Dim descripbrief As String = txtitemlong.Text
                            Dim glsalesaccountid As String = lblglsalesacc.Text
                            Dim glinventoryaccountid As String = lblglinvtryacc.Text
                            Dim glcostsaccountid As String = lblglcostacc.Text
                            Dim costingaccountid As String = lblcostingacc.Text
                            Dim levelprice As Decimal = CDec(txtpricelevel.Text)
                            Dim onhandqnty As Decimal = CDec(lblqntyonhand.Text)
                            Dim onhandqntyunit As String = lblqntyunit.Text
                            Dim lastsoldprice As Decimal = CDec(txtlastprice.Text)
                            Dim costmethod As String = cmbcostmethod.Text
                            Dim minstockqnty As Decimal = CDec(txtminstock.Text)
                            Dim minstockqntyunit As String = cmbminstockunit.Text
                            Dim itemtaxtype As String = cmbtaxtype.Text
                            Dim itemtype As String = cmbitemtype.Text
                            Dim stocking As String = cmbstocking.Text
                            Dim weight As Decimal = CDec(txtweight.Text)
                            Dim weightunit As String = cmbweight.Text
                            Dim vendorname As String = txtvendor.Text
                            Dim customfield1 As String = ""
                            Dim customfield2 As String = ""
                            Dim customfield3 As String = ""
                            Dim customfield4 As String = ""
                            Dim customfield5 As String = ""
                            cls.AddInventoryItem(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, itemid, itemnt, itemname, itemclass, descshort, itemsize, itemshape, itemused, descripbrief, levelprice, onhandqnty, onhandqntyunit, lastsoldprice, costmethod, minstockqnty, minstockqntyunit, itemtaxtype, itemtype, stocking, weight, weightunit, vendorname, glsalesaccountid, glinventoryaccountid, glcostsaccountid, costingaccountid, customfield1, customfield2, customfield3, customfield4, customfield5, Inactive, Commission, UnitPrice)
                            Dim pricelevel As Decimal = 0.0
                            Dim LevelName As String = "Price Level 1"
                            cls.AddInventoryItemPriceLevel(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtitemid.Text, txtitemname.Text, txtitemlong.Text, CDec(txtpricelevel.Text), pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, LevelName)
                        ElseIf cmbitemclass.Text = "Activity Item" Then
                            Dim itemid As String = txtitemid.Text
                            Dim itemnt As String = ItemNote
                            Dim itemname As String = txtitemname.Text
                            Dim itemclass As String = cmbitemclass.Text
                            Dim descshort As String = txtitemshort.Text
                            Dim itemsize As String = cmbsize.Text
                            Dim itemshape As String = cmbshape.Text
                            Dim itemused As String = cmbdescription.Text
                            Dim descripbrief As String = txtitemlong.Text
                            Dim glsalesaccountid As String = lblglsalesacc.Text
                            Dim glinventoryaccountid As String = lblglinvtryacc.Text
                            Dim glcostsaccountid As String = lblglcostacc.Text
                            Dim costingaccountid As String = lblcostingacc.Text
                            Dim levelprice As Decimal = CDec(txtpricelevel.Text)
                            Dim itemtype As String = cmbitemtype.Text
                            Dim vendorname As String = txtvendor.Text
                            Dim onhandqnty As Decimal = 0.0
                            Dim onhandqntyunit As String = ""
                            Dim minstockqnty As Decimal = 0.0
                            Dim minstockqntyunit As String = ""
                            Dim lastsoldprice As Decimal = 0.0
                            Dim costmethod As String = ""
                            Dim itemtaxtype As String = ""
                            Dim stocking As String = ""
                            Dim weight As Decimal = 0.0
                            Dim weightunit As String = ""
                            Dim customfield1 As String = ""
                            Dim customfield2 As String = ""
                            Dim customfield3 As String = ""
                            Dim customfield4 As String = ""
                            Dim customfield5 As String = ""
                            UnitPrice = 0.0
                            cls.AddInventoryItem(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, itemid, itemnt, itemname, itemclass, descshort, itemsize, itemshape, itemused, descripbrief, levelprice, onhandqnty, onhandqntyunit, lastsoldprice, costmethod, minstockqnty, minstockqntyunit, itemtaxtype, itemtype, stocking, weight, weightunit, vendorname, glsalesaccountid, glinventoryaccountid, glcostsaccountid, costingaccountid, customfield1, customfield2, customfield3, customfield4, customfield5, Inactive, Commission, UnitPrice)
                            Dim pricelevel As Decimal = 0.0
                            Dim LevelName As String = "Price Level 1"
                            cls.AddInventoryItemPriceLevel(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtitemid.Text, txtitemname.Text, txtitemlong.Text, CDec(txtpricelevel.Text), pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, LevelName)
                        Else
                            Dim itemid As String = txtitemid.Text
                            Dim itemnt As String = ItemNote
                            Dim itemname As String = txtitemname.Text
                            Dim itemclass As String = cmbitemclass.Text
                            Dim descshort As String = txtitemshort.Text
                            Dim itemsize As String = cmbsize.Text
                            Dim itemshape As String = cmbshape.Text
                            Dim itemused As String = cmbdescription.Text
                            Dim descripbrief As String = txtitemlong.Text
                            Dim glsalesaccountid As String = lblglsalesacc.Text
                            Dim glinventoryaccountid As String = lblglinvtryacc.Text
                            Dim glcostsaccountid As String = lblglcostacc.Text
                            Dim costingaccountid As String = lblcostingacc.Text
                            Dim levelprice As Decimal = CDec(txtpricelevel.Text)
                            Dim onhandqnty As Decimal = CDec(lblqntyonhand.Text)
                            Dim onhandqntyunit As String = lblqntyunit.Text
                            Dim lastsoldprice As Decimal = CDec(txtlastprice.Text)
                            Dim costmethod As String = cmbcostmethod.Text
                            Dim minstockqnty As Decimal = CDec(txtminstock.Text)
                            Dim minstockqntyunit As String = cmbminstockunit.Text
                            Dim itemtaxtype As String = cmbtaxtype.Text
                            Dim itemtype As String = cmbitemtype.Text
                            Dim stocking As String = cmbstocking.Text
                            Dim weight As Decimal = CDec(txtweight.Text)
                            Dim weightunit As String = cmbweight.Text
                            Dim vendorname As String = txtvendor.Text
                            Dim customfield1 As String = ""
                            Dim customfield2 As String = ""
                            Dim customfield3 As String = ""
                            Dim customfield4 As String = ""
                            Dim customfield5 As String = ""
                            If dgviewcustomfield.Rows.Count > 0 Then
                                Dim row As Integer = dgviewcustomfield.Rows.Count
                                If row = 1 Then
                                    customfield1 = dgviewcustomfield.Rows(0).Cells(2).Value.ToString()
                                ElseIf row = 2 Then
                                    customfield1 = dgviewcustomfield.Rows(0).Cells(2).Value.ToString()
                                    customfield2 = dgviewcustomfield.Rows(1).Cells(2).Value.ToString()
                                ElseIf row = 3 Then
                                    customfield1 = dgviewcustomfield.Rows(0).Cells(2).Value.ToString()
                                    customfield2 = dgviewcustomfield.Rows(1).Cells(2).Value.ToString()
                                    customfield3 = dgviewcustomfield.Rows(2).Cells(2).Value.ToString()
                                ElseIf row = 4 Then
                                    customfield1 = dgviewcustomfield.Rows(0).Cells(2).Value.ToString()
                                    customfield2 = dgviewcustomfield.Rows(1).Cells(2).Value.ToString()
                                    customfield3 = dgviewcustomfield.Rows(2).Cells(2).Value.ToString()
                                    customfield4 = dgviewcustomfield.Rows(3).Cells(2).Value.ToString()
                                ElseIf row = 5 Then
                                    customfield1 = dgviewcustomfield.Rows(0).Cells(2).Value.ToString()
                                    customfield2 = dgviewcustomfield.Rows(1).Cells(2).Value.ToString()
                                    customfield3 = dgviewcustomfield.Rows(2).Cells(2).Value.ToString()
                                    customfield4 = dgviewcustomfield.Rows(3).Cells(2).Value.ToString()
                                    customfield5 = dgviewcustomfield.Rows(4).Cells(2).Value.ToString()
                                End If
                            End If
                            cls.AddInventoryItem(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, itemid, itemnt, itemname, itemclass, descshort, itemsize, itemshape, itemused, descripbrief, levelprice, onhandqnty, onhandqntyunit, lastsoldprice, costmethod, minstockqnty, minstockqntyunit, itemtaxtype, itemtype, stocking, weight, weightunit, vendorname, glsalesaccountid, glinventoryaccountid, glcostsaccountid, costingaccountid, customfield1, customfield2, customfield3, customfield4, customfield5, Inactive, Commission, UnitPrice)
                            Dim pricelevel As Decimal = 0.0
                            Dim LevelName As String = "Price Level 1"
                            cls.AddInventoryItemPriceLevel(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtitemid.Text, txtitemname.Text, txtitemlong.Text, CDec(txtpricelevel.Text), pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, pricelevel, LevelName)
                        End If
                        If cls.AddItemOk = True Then
                            Dim result1 As DialogResult = MessageBox.Show("Record added successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = Windows.Forms.DialogResult.OK Then
                                txtitemname.Focus()
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Serial no already exist." + Environment.NewLine + "Please enter a new serial no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            txtitemid.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateInventoryPriceLevel(ByVal id As String, ByVal name As String)
        Try
            If itempricelevel = "Price Level 1" Then
                Price(0) = CDec(txtpricelevel.Text)
            ElseIf itempricelevel = "Price Level 2" Then
                Price(1) = CDec(txtpricelevel.Text)
            ElseIf itempricelevel = "Price Level 3" Then
                Price(2) = CDec(txtpricelevel.Text)
            ElseIf itempricelevel = "Price Level 4" Then
                Price(3) = CDec(txtpricelevel.Text)
            ElseIf itempricelevel = "Price Level 5" Then
                Price(4) = CDec(txtpricelevel.Text)
            ElseIf itempricelevel = "Price Level 6" Then
                Price(5) = CDec(txtpricelevel.Text)
            ElseIf itempricelevel = "Price Level 7" Then
                Price(6) = CDec(txtpricelevel.Text)
            ElseIf itempricelevel = "Price Level 8" Then
                Price(7) = CDec(txtpricelevel.Text)
            ElseIf itempricelevel = "Price Level 9" Then
                Price(8) = CDec(txtpricelevel.Text)
            ElseIf itempricelevel = "Price Level 10" Then
                Price(9) = CDec(txtpricelevel.Text)
            End If
            Dim cls As New cInventory()
            cls.UpdateInventoryItemPriceLevel(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtitemid.Text, txtitemname.Text, txtitemshort.Text, Price(0), Price(1), Price(2), Price(3), Price(4), Price(5), Price(6), Price(7), Price(8), Price(9), itempricelevel)
            If cls.UpdateItemPriceLevel = True Then
                cls.UpdateItemOk = True
            Else
                cls.UpdateItemOk = False
            End If
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If txtitemid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter serial no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtitemid.Focus()
                End If
            ElseIf cmbitemclass.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter serial no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbitemclass.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim Inactive As String = ""
                    If chkinactive.Checked = True Then
                        Inactive = "Yes"
                    Else
                        Inactive = "No"
                    End If
                    Dim Commission As String = ""
                    If chkcommission.Checked = True Then
                        Commission = "Yes"
                    Else
                        Commission = "No"
                    End If
                    Dim cls As New cInventory()
                    ItemPriceCalculation()
                    If cmbitemclass.Text = "Description Only" Then
                        Dim itemid As String = txtitemid.Text
                        Dim itemnt As String = ItemNote
                        Dim itemname As String = txtitemname.Text
                        Dim itemclass As String = cmbitemclass.Text
                        Dim descshort As String = txtitemshort.Text
                        Dim itemsize As String = cmbsize.Text
                        Dim itemshape As String = cmbshape.Text
                        Dim itemused As String = cmbdescription.Text
                        Dim descripbrief As String = txtitemlong.Text
                        Dim glsalesaccountid As String = lblglsalesacc.Text
                        Dim glinventoryaccountid As String = lblglinvtryacc.Text
                        Dim glcostsaccountid As String = lblglcostacc.Text
                        Dim costingaccountid As String = lblcostingacc.Text
                        Dim levelprice As Decimal = 0.0
                        Dim onhandqnty As Decimal = 0.0
                        Dim onhandqntyunit As String = ""
                        Dim lastsoldprice As Decimal = 0.0
                        Dim costmethod As String = ""
                        Dim minstockqnty As Decimal = 0.0
                        Dim minstockqntyunit As String = ""
                        Dim itemtaxtype As String = ""
                        Dim itemtype As String = ""
                        Dim stocking As String = ""
                        Dim weight As Decimal = 0.0
                        Dim weightunit As String = ""
                        Dim vendorname As String = ""
                        Dim customfield1 As String = ""
                        Dim customfield2 As String = ""
                        Dim customfield3 As String = ""
                        Dim customfield4 As String = ""
                        Dim customfield5 As String = ""
                        UnitPrice = 0.0
                        cls.UpdateInventoryItem(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, itemid, itemnt, itemname, itemclass, descshort, itemsize, itemshape, itemused, descripbrief, levelprice, onhandqnty, onhandqntyunit, lastsoldprice, costmethod, minstockqnty, minstockqntyunit, itemtaxtype, itemtype, stocking, weight, weightunit, vendorname, glsalesaccountid, glinventoryaccountid, glcostsaccountid, costingaccountid, customfield1, customfield2, customfield3, customfield4, customfield5, Inactive, Commission, UnitPrice)
                        UpdateInventoryPriceLevel(txtitemid.Text, txtitemname.Text)
                    ElseIf cmbitemclass.Text = "Labor Item" Then
                        Dim itemid As String = txtitemid.Text
                        Dim itemnt As String = ItemNote
                        Dim itemname As String = txtitemname.Text
                        Dim itemclass As String = cmbitemclass.Text
                        Dim descshort As String = txtitemshort.Text
                        Dim itemsize As String = cmbsize.Text
                        Dim itemshape As String = cmbshape.Text
                        Dim itemused As String = cmbdescription.Text
                        Dim descripbrief As String = txtitemlong.Text
                        Dim glsalesaccountid As String = lblglsalesacc.Text
                        Dim glinventoryaccountid As String = lblglinvtryacc.Text
                        Dim glcostsaccountid As String = lblglcostacc.Text
                        Dim costingaccountid As String = lblcostingacc.Text
                        Dim levelprice As Decimal = CDec(txtpricelevel.Text)
                        Dim onhandqnty As Decimal = CDec(lblqntyonhand.Text)
                        Dim onhandqntyunit As String = lblqntyunit.Text
                        Dim lastsoldprice As Decimal = CDec(txtlastprice.Text)
                        Dim costmethod As String = cmbcostmethod.Text
                        Dim minstockqnty As Decimal = CDec(txtminstock.Text)
                        Dim minstockqntyunit As String = cmbminstockunit.Text
                        Dim itemtaxtype As String = cmbtaxtype.Text
                        Dim itemtype As String = cmbitemtype.Text
                        Dim stocking As String = cmbstocking.Text
                        Dim weight As Decimal = CDec(txtweight.Text)
                        Dim weightunit As String = cmbweight.Text
                        Dim vendorname As String = txtvendor.Text
                        Dim customfield1 As String = ""
                        Dim customfield2 As String = ""
                        Dim customfield3 As String = ""
                        Dim customfield4 As String = ""
                        Dim customfield5 As String = ""
                        cls.UpdateInventoryItem(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, itemid, itemnt, itemname, itemclass, descshort, itemsize, itemshape, itemused, descripbrief, levelprice, onhandqnty, onhandqntyunit, lastsoldprice, costmethod, minstockqnty, minstockqntyunit, itemtaxtype, itemtype, stocking, weight, weightunit, vendorname, glsalesaccountid, glinventoryaccountid, glcostsaccountid, costingaccountid, customfield1, customfield2, customfield3, customfield4, customfield5, Inactive, Commission, UnitPrice)
                        UpdateInventoryPriceLevel(txtitemid.Text, txtitemname.Text)
                    ElseIf cmbitemclass.Text = "Assembly Item" Then
                        Dim itemid As String = txtitemid.Text
                        Dim itemnt As String = ItemNote
                        Dim itemname As String = txtitemname.Text
                        Dim itemclass As String = cmbitemclass.Text
                        Dim descshort As String = txtitemshort.Text
                        Dim itemsize As String = cmbsize.Text
                        Dim itemshape As String = cmbshape.Text
                        Dim itemused As String = cmbdescription.Text
                        Dim descripbrief As String = txtitemlong.Text
                        Dim glsalesaccountid As String = lblglsalesacc.Text
                        Dim glinventoryaccountid As String = lblglinvtryacc.Text
                        Dim glcostsaccountid As String = lblglcostacc.Text
                        Dim costingaccountid As String = lblcostingacc.Text
                        Dim levelprice As Decimal = CDec(txtpricelevel.Text)
                        Dim onhandqnty As Decimal = CDec(lblqntyonhand.Text)
                        Dim onhandqntyunit As String = lblqntyunit.Text
                        Dim lastsoldprice As Decimal = CDec(txtlastprice.Text)
                        Dim costmethod As String = cmbcostmethod.Text
                        Dim minstockqnty As Decimal = CDec(txtminstock.Text)
                        Dim minstockqntyunit As String = cmbminstockunit.Text
                        Dim itemtaxtype As String = cmbtaxtype.Text
                        Dim itemtype As String = cmbitemtype.Text
                        Dim stocking As String = cmbstocking.Text
                        Dim weight As Decimal = CDec(txtweight.Text)
                        Dim weightunit As String = cmbweight.Text
                        Dim vendorname As String = txtvendor.Text
                        Dim customfield1 As String = ""
                        Dim customfield2 As String = ""
                        Dim customfield3 As String = ""
                        Dim customfield4 As String = ""
                        Dim customfield5 As String = ""
                        cls.UpdateInventoryItem(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, itemid, itemnt, itemname, itemclass, descshort, itemsize, itemshape, itemused, descripbrief, levelprice, onhandqnty, onhandqntyunit, lastsoldprice, costmethod, minstockqnty, minstockqntyunit, itemtaxtype, itemtype, stocking, weight, weightunit, vendorname, glsalesaccountid, glinventoryaccountid, glcostsaccountid, costingaccountid, customfield1, customfield2, customfield3, customfield4, customfield5, Inactive, Commission, UnitPrice)
                        UpdateInventoryPriceLevel(txtitemid.Text, txtitemname.Text)
                    ElseIf cmbitemclass.Text = "Activity Item" Then
                        Dim itemid As String = txtitemid.Text
                        Dim itemnt As String = ItemNote
                        Dim itemname As String = txtitemname.Text
                        Dim itemclass As String = cmbitemclass.Text
                        Dim descshort As String = txtitemshort.Text
                        Dim itemsize As String = cmbsize.Text
                        Dim itemshape As String = cmbshape.Text
                        Dim itemused As String = cmbdescription.Text
                        Dim descripbrief As String = txtitemlong.Text
                        Dim glsalesaccountid As String = lblglsalesacc.Text
                        Dim glinventoryaccountid As String = lblglinvtryacc.Text
                        Dim glcostsaccountid As String = lblglcostacc.Text
                        Dim costingaccountid As String = lblcostingacc.Text
                        Dim levelprice As Decimal = CDec(txtpricelevel.Text)
                        Dim itemtype As String = cmbitemtype.Text
                        Dim vendorname As String = txtvendor.Text
                        Dim onhandqnty As Decimal = 0.0
                        Dim onhandqntyunit As String = ""
                        Dim minstockqnty As Decimal = 0.0
                        Dim minstockqntyunit As String = ""
                        Dim lastsoldprice As Decimal = 0.0
                        Dim costmethod As String = ""
                        Dim itemtaxtype As String = ""
                        Dim stocking As String = ""
                        Dim weight As Decimal = 0.0
                        Dim weightunit As String = ""
                        Dim customfield1 As String = ""
                        Dim customfield2 As String = ""
                        Dim customfield3 As String = ""
                        Dim customfield4 As String = ""
                        Dim customfield5 As String = ""
                        UnitPrice = 0.0
                        cls.UpdateInventoryItem(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, itemid, itemnt, itemname, itemclass, descshort, itemsize, itemshape, itemused, descripbrief, levelprice, onhandqnty, onhandqntyunit, lastsoldprice, costmethod, minstockqnty, minstockqntyunit, itemtaxtype, itemtype, stocking, weight, weightunit, vendorname, glsalesaccountid, glinventoryaccountid, glcostsaccountid, costingaccountid, customfield1, customfield2, customfield3, customfield4, customfield5, Inactive, Commission, UnitPrice)
                        UpdateInventoryPriceLevel(txtitemid.Text, txtitemname.Text)
                    Else
                        Dim itemid As String = txtitemid.Text
                        Dim itemnt As String = ItemNote
                        Dim itemname As String = txtitemname.Text
                        Dim itemclass As String = cmbitemclass.Text
                        Dim descshort As String = txtitemshort.Text
                        Dim itemsize As String = cmbsize.Text
                        Dim itemshape As String = cmbshape.Text
                        Dim itemused As String = cmbdescription.Text
                        Dim descripbrief As String = txtitemlong.Text
                        Dim glsalesaccountid As String = lblglsalesacc.Text
                        Dim glinventoryaccountid As String = lblglinvtryacc.Text
                        Dim glcostsaccountid As String = lblglcostacc.Text
                        Dim costingaccountid As String = lblcostingacc.Text
                        Dim levelprice As Decimal = CDec(txtpricelevel.Text)
                        Dim onhandqnty As Decimal = CDec(lblqntyonhand.Text)
                        Dim onhandqntyunit As String = lblqntyunit.Text
                        Dim lastsoldprice As Decimal = CDec(txtlastprice.Text)
                        Dim costmethod As String = cmbcostmethod.Text
                        Dim minstockqnty As Decimal = CDec(txtminstock.Text)
                        Dim minstockqntyunit As String = cmbminstockunit.Text
                        Dim itemtaxtype As String = cmbtaxtype.Text
                        Dim itemtype As String = cmbitemtype.Text
                        Dim stocking As String = cmbstocking.Text
                        Dim weight As Decimal = CDec(txtweight.Text)
                        Dim weightunit As String = cmbweight.Text
                        Dim vendorname As String = txtvendor.Text
                        Dim customfield1 As String = ""
                        Dim customfield2 As String = ""
                        Dim customfield3 As String = ""
                        Dim customfield4 As String = ""
                        Dim customfield5 As String = ""
                        If dgviewcustomfield.Rows.Count > 0 Then
                            Dim row As Integer = dgviewcustomfield.Rows.Count
                            If row = 1 Then
                                customfield1 = dgviewcustomfield.Rows(0).Cells(2).Value.ToString()
                            ElseIf row = 2 Then
                                customfield1 = dgviewcustomfield.Rows(0).Cells(2).Value.ToString()
                                customfield2 = dgviewcustomfield.Rows(1).Cells(2).Value.ToString()
                            ElseIf row = 3 Then
                                customfield1 = dgviewcustomfield.Rows(0).Cells(2).Value.ToString()
                                customfield2 = dgviewcustomfield.Rows(1).Cells(2).Value.ToString()
                                customfield3 = dgviewcustomfield.Rows(2).Cells(2).Value.ToString()
                            ElseIf row = 4 Then
                                customfield1 = dgviewcustomfield.Rows(0).Cells(2).Value.ToString()
                                customfield2 = dgviewcustomfield.Rows(1).Cells(2).Value.ToString()
                                customfield3 = dgviewcustomfield.Rows(2).Cells(2).Value.ToString()
                                customfield4 = dgviewcustomfield.Rows(3).Cells(2).Value.ToString()
                            ElseIf row = 5 Then
                                customfield1 = dgviewcustomfield.Rows(0).Cells(2).Value.ToString()
                                customfield2 = dgviewcustomfield.Rows(1).Cells(2).Value.ToString()
                                customfield3 = dgviewcustomfield.Rows(2).Cells(2).Value.ToString()
                                customfield4 = dgviewcustomfield.Rows(3).Cells(2).Value.ToString()
                                customfield5 = dgviewcustomfield.Rows(4).Cells(2).Value.ToString()
                            End If
                        End If
                        cls.UpdateInventoryItem(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, itemid, itemnt, itemname, itemclass, descshort, itemsize, itemshape, itemused, descripbrief, levelprice, onhandqnty, onhandqntyunit, lastsoldprice, costmethod, minstockqnty, minstockqntyunit, itemtaxtype, itemtype, stocking, weight, weightunit, vendorname, glsalesaccountid, glinventoryaccountid, glcostsaccountid, costingaccountid, customfield1, customfield2, customfield3, customfield4, customfield5, Inactive, Commission, UnitPrice)
                        UpdateInventoryPriceLevel(txtitemid.Text, txtitemname.Text)
                    End If
                    If cls.UpdateItemOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            txtitemname.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If txtitemid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter serial no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtitemid.Focus()
                End If
            ElseIf cmbitemclass.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter serial no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbitemclass.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cInventory()
                    cls.DeleteInventoryItem(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtitemid.Text, txtitemname.Text)
                    If cls.DeleteItemOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            txtitemname.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedRecord()
        Try
            cmd.CommandText = "select * from Inventory where itemid='" & itemid & "' and itemname='" & itemname & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                ItemNote = dr("itemnote").ToString()
                cmbcostmethod.Text = dr("costmethod").ToString()
                cmbdescription.Text = dr("itemused").ToString()
                cmbitemclass.Text = dr("itemclass").ToString()
                cmbitemtype.Text = dr("itemtype").ToString()
                cmbminstockunit.Text = dr("minstockqntyunit").ToString()
                cmbshape.Text = dr("itemshape").ToString()
                cmbsize.Text = dr("itemsize").ToString()
                cmbstocking.Text = dr("stocking").ToString()
                cmbtaxtype.Text = dr("itemtaxtype").ToString()
                cmbweight.Text = dr("weightunit").ToString()
                lblqntyonhand.Text = dr("onhandqnty").ToString()
                lblqntyunit.Text = dr("onhandqntyunit").ToString()
                lblcostingacc.Text = dr("costingaccountid").ToString()
                lblglcostacc.Text = dr("glcostsaccountid").ToString()
                lblglinvtryacc.Text = dr("glinventoryaccountid").ToString()
                lblglsalesacc.Text = dr("glsalesaccountid").ToString()
                txtitemlong.Text = dr("descripbrief").ToString()
                txtitemname.Text = dr("itemname").ToString()
                txtitemshort.Text = dr("descshort").ToString()
                txtlastprice.Text = dr("lastsoldprice").ToString()
                txtminstock.Text = dr("minstockqnty").ToString()
                txtvendor.Text = dr("vendorname").ToString()
                txtweight.Text = dr("weight").ToString()
                If dgviewcustomfield.Rows.Count > 0 Then
                    Dim row As Integer = dgviewcustomfield.Rows.Count
                    If row = 1 Then
                        dgviewcustomfield.Rows(0).Cells(2).Value = dr("customfield1").ToString()
                    ElseIf row = 2 Then
                        dgviewcustomfield.Rows(0).Cells(2).Value = dr("customfield1").ToString()
                        dgviewcustomfield.Rows(1).Cells(2).Value = dr("customfield2").ToString()
                    ElseIf row = 3 Then
                        dgviewcustomfield.Rows(0).Cells(2).Value = dr("customfield1").ToString()
                        dgviewcustomfield.Rows(1).Cells(2).Value = dr("customfield2").ToString()
                        dgviewcustomfield.Rows(2).Cells(2).Value = dr("customfield3").ToString()
                    ElseIf row = 4 Then
                        dgviewcustomfield.Rows(0).Cells(2).Value = dr("customfield1").ToString()
                        dgviewcustomfield.Rows(1).Cells(2).Value = dr("customfield2").ToString()
                        dgviewcustomfield.Rows(2).Cells(2).Value = dr("customfield3").ToString()
                        dgviewcustomfield.Rows(3).Cells(2).Value = dr("customfield4").ToString()
                    ElseIf row = 5 Then
                        dgviewcustomfield.Rows(0).Cells(2).Value = dr("customfield1").ToString()
                        dgviewcustomfield.Rows(1).Cells(2).Value = dr("customfield2").ToString()
                        dgviewcustomfield.Rows(2).Cells(2).Value = dr("customfield3").ToString()
                        dgviewcustomfield.Rows(3).Cells(2).Value = dr("customfield4").ToString()
                        dgviewcustomfield.Rows(4).Cells(2).Value = dr("customfield5").ToString()
                    End If
                End If
                If dr("inactive").ToString() = "Yes" Then
                    chkinactive.Checked = True
                Else
                    chkinactive.Checked = False
                End If
                If dr("commission").ToString() = "Yes" Then
                    chkcommission.Checked = True
                Else
                    chkcommission.Checked = False
                End If
            End If
            dr.Close()
            txtitemid.Text = itemid
            LoadSelectedPriceLevel(txtitemid.Text, txtitemname.Text)
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadSelectedPriceLevel(ByVal id As String, ByVal name As String)
        Try
            cmd.CommandText = "select * from InventoryItemPriceLevel where itemid='" & id & "' and itemname='" & name & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Price(0) = CDec(dr("levelprice1").ToString())
            Price(1) = CDec(dr("levelprice2").ToString())
            Price(2) = CDec(dr("levelprice3").ToString())
            Price(3) = CDec(dr("levelprice4").ToString())
            Price(4) = CDec(dr("levelprice5").ToString())
            Price(5) = CDec(dr("levelprice6").ToString())
            Price(6) = CDec(dr("levelprice7").ToString())
            Price(7) = CDec(dr("levelprice8").ToString())
            Price(8) = CDec(dr("levelprice9").ToString())
            Price(9) = CDec(dr("levelprice10").ToString())
            itempricelevel = dr("defaultlevel").ToString()
            dr.Close()
            If itempricelevel = "Price Level 1" Then
                txtpricelevel.Text = Price(0).ToString()
            ElseIf itempricelevel = "Price Level 2" Then
                txtpricelevel.Text = Price(1).ToString()
            ElseIf itempricelevel = "Price Level 3" Then
                txtpricelevel.Text = Price(2).ToString()
            ElseIf itempricelevel = "Price Level 4" Then
                txtpricelevel.Text = Price(3).ToString()
            ElseIf itempricelevel = "Price Level 5" Then
                txtpricelevel.Text = Price(4).ToString()
            ElseIf itempricelevel = "Price Level 6" Then
                txtpricelevel.Text = Price(5).ToString()
            ElseIf itempricelevel = "Price Level 7" Then
                txtpricelevel.Text = Price(6).ToString()
            ElseIf itempricelevel = "Price Level 8" Then
                txtpricelevel.Text = Price(7).ToString()
            ElseIf itempricelevel = "Price Level 9" Then
                txtpricelevel.Text = Price(8).ToString()
            ElseIf itempricelevel = "Price Level 10" Then
                txtpricelevel.Text = Price(9).ToString()
            End If
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub ResetForm()
        updateinventory = False
        ETabControl1.TabPages.Remove(TabPage2)
        ETabControl1.TabPages.Remove(TabPage3)
        ETabControl1.TabPages.Add(TabPage2)
        ETabControl1.TabPages.Add(TabPage3)
        dgviewitemhistory.Rows.Clear()
        dgviewcustomfield.Rows.Clear()
        LoadDefaultField()
        itempricelevel = ""
        itemprice = 0.0
        ItemNote = ""
        itemname = ""
        itemid = ""
        itemdescription = ""
        cmbdescription.Text = ""
        lblglinvtryacc.Text = ""
        lblglsalesacc.Text = ""
        cmbitemclass.Text = ""
        cmbitemtype.Text = ""
        cmbminstockunit.Text = ""
        cmbshape.Text = ""
        cmbsize.Text = ""
        cmbstocking.Text = ""
        cmbtaxtype.Text = ""
        cmbweight.Text = ""
        txtitemlong.Text = ""
        txtitemname.Text = ""
        txtitemshort.Text = ""
        txtlastprice.Text = ""
        txtminstock.Text = ""
        txtpricelevel.Text = ""
        txtvendor.Text = ""
        txtweight.Text = ""
        If ISDAutoID = "Yes" Then
            GetCode()
        Else
            txtitemid.Text = ""
        End If
        txtitemid.Focus()
    End Sub

    Private Sub CheckItemID()
        Try
            cmd.CommandText = "select * from Inventory where itemid='" & My.Settings.LastOpenedInstituteID & "' and insName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                ItemExist = True
            Else
                ItemExist = False
            End If
            dr.Close()
        Catch ex As Exception
            ItemExist = False
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmAddInventoryItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updateinventory = False Then
            ControlSetBound()
            LoadShape()
            LoadDefaultField()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadShape()
            LoadDefaultField()
            LoadSelectedRecord()
        End If
        If USinventory = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbcostmethod.Enabled = False
            cmbdescription.Enabled = False
            cmbitemclass.Enabled = False
            cmbitemtype.Enabled = False
            cmbminstockunit.Enabled = False
            cmbshape.Enabled = False
            cmbsize.Enabled = False
            cmbstocking.Enabled = False
            cmbtaxtype.Enabled = False
            cmbweight.Enabled = False
            txtitemid.ReadOnly = True
            txtitemlong.ReadOnly = True
            txtitemname.ReadOnly = True
            txtitemshort.ReadOnly = True
            txtlastprice.ReadOnly = True
            txtminstock.ReadOnly = True
            txtpricelevel.ReadOnly = True
            txtvendor.ReadOnly = True
            txtweight.ReadOnly = True
            dgviewcustomfield.Enabled = False
            dgviewitemhistory.Enabled = False
            chkcommission.Enabled = False
            chkinactive.Enabled = False
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updateinventory = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updateinventory = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updateinventory = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnnote_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnote.ClickButtonArea
        itemid = txtitemid.Text
        Dim frm As New frmItemNote()
        frm.ShowDialog()
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updateinventory = False Then
            ControlSetBound()
            LoadShape()
            LoadDefaultField()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadShape()
            LoadDefaultField()
            LoadSelectedRecord()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub

    Private Sub btnpricelevel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpricelevel.Click
        itemid = txtitemid.Text
        itemname = txtitemname.Text
        itemdescription = txtitemshort.Text
        If txtpricelevel.Text <> "" Then
            itemprice = CDec(txtpricelevel.Text)
        Else
            itemprice = 0.0
        End If
        Dim frm As New frmInventoryPriceLevel()
        frm.ControlBox = True
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.WindowState = FormWindowState.Normal
        frm.ShowDialog()
    End Sub
#End Region
#Region "Attributes..."
    Private Sub txtitemid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtitemid.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            cmbitemclass.Focus()
        End If
    End Sub

    Private Sub txtitemid_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtitemid.TextChanged
        If txtitemid.Text <> "" Then
            LoadHistory(txtitemid.Text)
        End If
    End Sub

    Private Sub cmbitemclass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbitemclass.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtitemname.Focus()
        End If
    End Sub

    Private Sub cmbitemclass_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbitemclass.TextChanged
        If cmbitemclass.Text = "Stock Item" Then
            ETabControl1.TabPages.Remove(TabPage2)
            ETabControl1.TabPages.Remove(TabPage3)
            ETabControl1.TabPages.Add(TabPage2)
            ETabControl1.TabPages.Add(TabPage3)
            btnpricelevel.Visible = True
            lblcostmethod.Visible = True
            lblitemtype.Visible = True
            lbllastunitcost.Visible = True
            lblminimumstockhead.Visible = True
            lblpreferredvendor.Visible = True
            lblpricelevel.Visible = True
            lblqntyonhand.Visible = True
            lblqntyonhandhead.Visible = True
            lblqntyunit.Visible = True
            lblsoldunit.Visible = True
            lblstocking.Visible = True
            lblweight.Visible = True
            cmbcostmethod.Visible = True
            cmbitemtype.Visible = True
            txtlastprice.Visible = True
            txtminstock.Visible = True
            cmbminstockunit.Visible = True
            txtvendor.Visible = True
            txtpricelevel.Visible = True
            txtlastprice.Visible = True
            cmbitemtype.Text = "Admin"
            cmbstocking.Visible = True
            cmbtaxtype.Visible = True
            txtweight.Visible = True
            cmbweight.Visible = True
            lblglsalesacc.Text = ISDStockGLSalesAccount
            lblglinvtryacc.Text = ISDStockGLInvAccount
            lblglcostacc.Text = ISDStockGLCostAccount
            lblcostingacc.Text = ISDStockCostingAccount
        ElseIf cmbitemclass.Text = "Master Item" Then
            ETabControl1.TabPages.Remove(TabPage2)
            ETabControl1.TabPages.Remove(TabPage3)
            ETabControl1.TabPages.Add(TabPage2)
            ETabControl1.TabPages.Add(TabPage3)
            btnpricelevel.Visible = True
            lblcostmethod.Visible = True
            lblitemtype.Visible = True
            lbllastunitcost.Visible = True
            lblminimumstockhead.Visible = True
            lblpreferredvendor.Visible = True
            lblpricelevel.Visible = True
            lblqntyonhand.Visible = True
            lblqntyonhandhead.Visible = True
            lblqntyunit.Visible = True
            lblsoldunit.Visible = True
            lblstocking.Visible = True
            lblweight.Visible = True
            cmbcostmethod.Visible = True
            cmbitemtype.Visible = True
            txtlastprice.Visible = True
            txtminstock.Visible = True
            cmbminstockunit.Visible = True
            txtvendor.Visible = True
            txtpricelevel.Visible = True
            txtlastprice.Visible = True
            cmbitemtype.Text = "Admin"
            cmbstocking.Visible = True
            cmbtaxtype.Visible = True
            txtweight.Visible = True
            cmbweight.Visible = True
            lblglsalesacc.Text = ISDMasterGLSalesAccount
            lblglinvtryacc.Text = ISDMasterGLInvAccount
            lblglcostacc.Text = ISDMasterGLCostAccount
            lblcostingacc.Text = ISDMasterCostingAccount
        ElseIf cmbitemclass.Text = "Non Stock Item" Then
            ETabControl1.TabPages.Remove(TabPage2)
            ETabControl1.TabPages.Remove(TabPage3)
            ETabControl1.TabPages.Add(TabPage2)
            ETabControl1.TabPages.Add(TabPage3)
            btnpricelevel.Visible = True
            lblcostmethod.Visible = True
            lblitemtype.Visible = True
            lbllastunitcost.Visible = True
            lblminimumstockhead.Visible = True
            lblpreferredvendor.Visible = True
            lblpricelevel.Visible = True
            lblqntyonhand.Visible = True
            lblqntyonhandhead.Visible = True
            lblqntyunit.Visible = True
            lblsoldunit.Visible = True
            lblstocking.Visible = True
            lblweight.Visible = True
            cmbcostmethod.Visible = True
            cmbitemtype.Visible = True
            txtlastprice.Visible = True
            txtminstock.Visible = True
            cmbminstockunit.Visible = True
            txtvendor.Visible = True
            txtpricelevel.Visible = True
            txtlastprice.Visible = True
            cmbitemtype.Text = "Comment"
            cmbstocking.Visible = True
            cmbtaxtype.Visible = True
            txtweight.Visible = True
            cmbweight.Visible = True
            lblglsalesacc.Text = ISDNonStockGLSalesAccount
            lblglinvtryacc.Text = ISDNonStockGLInvAccount
            lblglcostacc.Text = ISDNonStockGLCostAccount
            lblcostingacc.Text = ISDNonStockCostingAccount
        ElseIf cmbitemclass.Text = "Description Only" Then
            ETabControl1.TabPages.Remove(TabPage2)
            ETabControl1.TabPages.Remove(TabPage3)
            btnpricelevel.Visible = False
            lblcostmethod.Visible = False
            lblitemtype.Visible = False
            lbllastunitcost.Visible = False
            lblminimumstockhead.Visible = False
            lblpreferredvendor.Visible = False
            lblpricelevel.Visible = False
            lblqntyonhand.Visible = False
            lblqntyonhandhead.Visible = False
            lblqntyunit.Visible = False
            lblsoldunit.Visible = False
            lblstocking.Visible = False
            lblweight.Visible = False
            cmbcostmethod.Visible = False
            cmbitemtype.Visible = False
            txtlastprice.Visible = False
            txtminstock.Visible = False
            cmbminstockunit.Visible = False
            txtvendor.Visible = False
            txtpricelevel.Visible = False
            txtlastprice.Visible = False
            cmbstocking.Visible = False
            cmbtaxtype.Visible = False
            txtweight.Visible = False
            cmbweight.Visible = False
            lblglsalesacc.Text = ISDDescriptionGLSalesAccount
            lblglinvtryacc.Text = ISDDescriptionGLInvAccount
            lblglcostacc.Text = ISDDescriptionGLCostAccount
            lblcostingacc.Text = ISDDescriptionCostingAccount
        ElseIf cmbitemclass.Text = "Service Item" Then
            ETabControl1.TabPages.Remove(TabPage2)
            ETabControl1.TabPages.Remove(TabPage3)
            ETabControl1.TabPages.Add(TabPage2)
            ETabControl1.TabPages.Add(TabPage3)
            btnpricelevel.Visible = True
            lblcostmethod.Visible = True
            lblitemtype.Visible = True
            lbllastunitcost.Visible = True
            lblminimumstockhead.Visible = True
            lblpreferredvendor.Visible = True
            lblpricelevel.Visible = True
            lblqntyonhand.Visible = True
            lblqntyonhandhead.Visible = True
            lblqntyunit.Visible = True
            lblsoldunit.Visible = True
            lblstocking.Visible = True
            lblweight.Visible = True
            cmbcostmethod.Visible = True
            cmbitemtype.Visible = True
            txtlastprice.Visible = True
            txtminstock.Visible = True
            cmbminstockunit.Visible = True
            txtvendor.Visible = True
            txtpricelevel.Visible = True
            txtlastprice.Visible = True
            cmbitemtype.Text = "Service"
            cmbstocking.Visible = True
            cmbtaxtype.Visible = True
            txtweight.Visible = True
            cmbweight.Visible = True
            lblglsalesacc.Text = ISDServiceGLSalesAccount
            lblglinvtryacc.Text = ISDServiceGLInvAccount
            lblglcostacc.Text = ISDServiceGLCostAccount
            lblcostingacc.Text = ISDServiceCostingAccount
        ElseIf cmbitemclass.Text = "Labor Item" Then
            ETabControl1.TabPages.Remove(TabPage2)
            ETabControl1.TabPages.Remove(TabPage3)
            btnpricelevel.Visible = True
            lblcostmethod.Visible = True
            lblitemtype.Visible = True
            lbllastunitcost.Visible = True
            lblminimumstockhead.Visible = True
            lblpreferredvendor.Visible = True
            lblpricelevel.Visible = True
            lblqntyonhand.Visible = True
            lblqntyonhandhead.Visible = True
            lblqntyunit.Visible = True
            lblsoldunit.Visible = True
            lblstocking.Visible = True
            lblweight.Visible = True
            cmbcostmethod.Visible = True
            cmbitemtype.Visible = True
            txtlastprice.Visible = True
            txtminstock.Visible = True
            cmbminstockunit.Visible = True
            txtvendor.Visible = True
            txtpricelevel.Visible = True
            txtlastprice.Visible = True
            cmbitemtype.Text = "Labor"
            cmbstocking.Visible = True
            cmbtaxtype.Visible = True
            txtweight.Visible = True
            cmbweight.Visible = True
            lblglsalesacc.Text = ISDLaborGLSalesAccount
            lblglinvtryacc.Text = ISDLaborGLInvAccount
            lblglcostacc.Text = ISDLaborGLCostAccount
            lblcostingacc.Text = ISDLaborCostingAccount
        ElseIf cmbitemclass.Text = "Assembly Item" Then
            ETabControl1.TabPages.Remove(TabPage2)
            ETabControl1.TabPages.Remove(TabPage3)
            btnpricelevel.Visible = True
            lblcostmethod.Visible = True
            lblitemtype.Visible = True
            lbllastunitcost.Visible = True
            lblminimumstockhead.Visible = True
            lblpreferredvendor.Visible = True
            lblpricelevel.Visible = True
            lblqntyonhand.Visible = True
            lblqntyonhandhead.Visible = True
            lblqntyunit.Visible = True
            lblsoldunit.Visible = True
            lblstocking.Visible = True
            lblweight.Visible = True
            cmbcostmethod.Visible = True
            cmbitemtype.Visible = True
            txtlastprice.Visible = True
            txtminstock.Visible = True
            cmbminstockunit.Visible = True
            txtvendor.Visible = True
            txtpricelevel.Visible = True
            txtlastprice.Visible = True
            cmbitemtype.Text = "Admin"
            cmbstocking.Visible = True
            cmbtaxtype.Visible = True
            txtweight.Visible = True
            cmbweight.Visible = True
            lblglsalesacc.Text = ISDAssemblyGLSalesAccount
            lblglinvtryacc.Text = ISDAssemblyGLInvAccount
            lblglcostacc.Text = ISDAssemblyGLCostAccount
            lblcostingacc.Text = ISDAssemblyCostingAccount
        ElseIf cmbitemclass.Text = "Activity Item" Then
            ETabControl1.TabPages.Remove(TabPage2)
            ETabControl1.TabPages.Remove(TabPage3)
            btnpricelevel.Visible = True
            lblcostmethod.Visible = False
            lblitemtype.Visible = True
            lbllastunitcost.Visible = False
            lblminimumstockhead.Visible = True
            lblpreferredvendor.Visible = True
            lblpricelevel.Visible = True
            lblqntyonhand.Visible = True
            lblqntyonhandhead.Visible = False
            lblqntyunit.Visible = False
            lblsoldunit.Visible = False
            lblstocking.Visible = False
            lblweight.Visible = False
            cmbcostmethod.Visible = False
            cmbitemtype.Visible = True
            txtlastprice.Visible = False
            txtminstock.Visible = False
            cmbminstockunit.Visible = False
            txtvendor.Visible = True
            txtpricelevel.Visible = True
            txtlastprice.Visible = False
            cmbitemtype.Text = "Admin"
            cmbstocking.Visible = False
            cmbtaxtype.Visible = False
            txtweight.Visible = False
            cmbweight.Visible = False
            lblglsalesacc.Text = ISDActivityGLSalesAccount
            lblglinvtryacc.Text = ISDActivityGLInvAccount
            lblglcostacc.Text = ISDActivityGLCostAccount
            lblcostingacc.Text = ISDActivityCostingAccount
        ElseIf cmbitemclass.Text = "Charge Item" Then
            ETabControl1.TabPages.Remove(TabPage2)
            ETabControl1.TabPages.Remove(TabPage3)
            ETabControl1.TabPages.Add(TabPage2)
            ETabControl1.TabPages.Add(TabPage3)
            btnpricelevel.Visible = True
            lblcostmethod.Visible = True
            lblitemtype.Visible = True
            lbllastunitcost.Visible = True
            lblminimumstockhead.Visible = True
            lblpreferredvendor.Visible = True
            lblpricelevel.Visible = True
            lblqntyonhand.Visible = True
            lblqntyonhandhead.Visible = True
            lblqntyunit.Visible = True
            lblsoldunit.Visible = True
            lblstocking.Visible = True
            lblweight.Visible = True
            cmbcostmethod.Visible = True
            cmbitemtype.Visible = True
            txtlastprice.Visible = True
            txtminstock.Visible = True
            cmbminstockunit.Visible = True
            txtvendor.Visible = True
            txtpricelevel.Visible = True
            txtlastprice.Visible = True
            cmbitemtype.Text = "Supply"
            cmbstocking.Visible = True
            cmbtaxtype.Visible = True
            txtweight.Visible = True
            cmbweight.Visible = True
            lblglsalesacc.Text = ISDChargeGLSalesAccount
            lblglinvtryacc.Text = ISDChargeGLInvAccount
            lblglcostacc.Text = ISDChargeGLCostAccount
            lblcostingacc.Text = ISDChargeCostingAccount
        End If
    End Sub

    Private Sub txtitemname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtitemname.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtitemshort.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbitemclass.Focus()
        End If
    End Sub

    Private Sub txtitemshort_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtitemshort.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            cmbsize.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtitemname.Focus()
        End If
    End Sub

    Private Sub cmbsize_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbsize.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbshape.Focus()
        End If
    End Sub

    Private Sub cmbshape_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbshape.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbdescription.Focus()
        End If
    End Sub

    Private Sub cmbdescription_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdescription.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtitemlong.Focus()
        End If
    End Sub

    Private Sub txtitemlong_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtitemlong.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtpricelevel.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbdescription.Focus()
        End If
    End Sub

    Private Sub txtpricelevel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpricelevel.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            cmbcostmethod.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtitemlong.Focus()
        End If
    End Sub

    Private Sub cmbcostmethod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcostmethod.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbtaxtype.Focus()
        End If
    End Sub

    Private Sub cmbtaxtype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbtaxtype.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbitemtype.Focus()
        End If
    End Sub

    Private Sub cmbitemtype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbitemtype.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbstocking.Focus()
        End If
    End Sub

    Private Sub cmbstocking_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbstocking.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtweight.Focus()
        End If
    End Sub

    Private Sub txtweight_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtweight.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            cmbweight.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbstocking.Focus()
        End If
    End Sub

    Private Sub cmbweight_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbweight.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbweight.Text <> "" Then
                MinStockUnit(cmbweight.Text)
            End If
            txtlastprice.Focus()
        End If
    End Sub

    Private Sub txtlastprice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlastprice.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtminstock.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbweight.Focus()
        End If
    End Sub

    Private Sub txtminstock_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtminstock.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            cmbminstockunit.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtlastprice.Focus()
        End If
    End Sub

    Private Sub cmbminstockunit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbminstockunit.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtvendor.Focus()
        End If
    End Sub

    Private Sub ComboBoxKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcostmethod.KeyPress, cmbdescription.KeyPress, cmbitemclass.KeyPress, cmbitemtype.KeyPress, cmbminstockunit.KeyPress, cmbshape.KeyPress, cmbsize.KeyPress, cmbstocking.KeyPress, cmbtaxtype.KeyPress, cmbweight.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtitemname.TextChanged, txtitemshort.TextChanged, txtvendor.TextChanged
        Dim ctc As New cTextChange()
        Dim x As eTextBox = CType(sender, eTextBox)
        ctc.ConvertTextBoxValidValue(x)
    End Sub
#End Region
End Class
#End Region