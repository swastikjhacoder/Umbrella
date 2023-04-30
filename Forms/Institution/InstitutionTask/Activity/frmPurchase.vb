#Region "Imports..."
Imports ESAR_Controls.UIControls.TextBox
#End Region
#Region "Class frmPurchase..."
Public Class frmPurchase
#Region "Declarations..."
    Private DGVItem As New DataGridView()
    Private ACODE As String = ""
    Private TT As String = ""
    Private UnitPrice As Decimal = 0.0
    Private TaxRrate As Decimal = 0.0
    Private i As Integer = 0
    Private Modify As Boolean = False
    Private ModifyIndex As Integer = 0
    Private PurchasePaid As String = ""
    Private PurchaseAmount As Decimal = 0.0
    Private Unit As String = ""
    Private Qnty As Decimal = 0.0
    Private Taxable As String = ""
    Private PurID As Boolean = False
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        ACODE = Indx.LoadPurchaseID()
        Dim var As String
        var = CodeIncrement(ACODE)
        Me.txtpurchaseid.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("PUR:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        Label1.SetBounds(17, 49, 39, 13)
        Label10.SetBounds(229, 19, 66, 13)
        Label2.SetBounds(17, 76, 62, 13)
        Label3.SetBounds(181, 76, 19, 13)
        Label4.SetBounds(0, 0, 39, 21)
        Label5.SetBounds(209, 0, 39, 21)
        Label6.SetBounds(333, 0, 34, 21)
        Label7.SetBounds(545, 0, 40, 21)
        Label8.SetBounds(17, 22, 26, 13)
        lblaccount.SetBounds(14, 19, 0, 13)

        txtvendorname.SetBounds(14, 29, 233, 21)
        txtqnty.SetBounds(248, 0, 85, 21)
        txtprice.SetBounds(585, 0, 85, 21)
        txtvendoraddress.SetBounds(14, 56, 233, 21)
        txtvendorphone.SetBounds(14, 83, 90, 21)
        txtvendoremail.SetBounds(111, 83, 137, 21)
        txtshipemail.SetBounds(106, 83, 137, 21)
        txtshipphone.SetBounds(10, 83, 90, 21)
        txtshipaddress.SetBounds(10, 56, 233, 21)
        txtshipname.SetBounds(10, 29, 233, 21)
        txttaxrate.SetBounds(85, 73, 90, 21)
        txtpurchaseid.SetBounds(85, 19, 115, 21)

        cmbdate.SetBounds(85, 46, 115, 21)
        cmbduedate.SetBounds(301, 16, 115, 21)
        cmbitemname.SetBounds(39, 0, 170, 21)
        cmbunit.SetBounds(367, 0, 178, 21)

        chkpaid.SetBounds(433, 18, 50, 17)
    End Sub

    Private Sub LoadShippingTo()
        Try
            cmd.CommandText = "select InsName,Address1,Address2,City,State,Pin,Country,Telephone,Email from Institute where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            txtshipaddress.Text = dr("Address1").ToString() + ", " + dr("Address2").ToString() + ", " + dr("City").ToString() + ", " + dr("State").ToString() + ", " + dr("Pin").ToString() + ", " + dr("Country").ToString()
            txtshipemail.Text = dr("Email").ToString()
            txtshipname.Text = dr("InsName").ToString()
            txtshipphone.Text = dr("Telephone").ToString()
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadItem()
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .Name = "Col1"
                .HeaderText = "Item ID"
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .Name = "Col2"
                .HeaderText = "Item Name"
            End With
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .Name = "Col3"
                .HeaderText = "Item Class"
            End With

            With DGVItem
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
                AddHandler DGVItem.CellClick, AddressOf DGVItem_CellClick
            End With

            DGVItem.Columns.Clear()
            DGVItem.Columns.Add(col1)
            DGVItem.Columns.Add(col2)
            DGVItem.Columns.Add(col3)

            DGVItem.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select itemid,itemname,itemclass from Inventory where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVItem.Rows.Add()
                DGVItem.Rows(indx).Cells(0).Value = dr("itemid").ToString()
                DGVItem.Rows(indx).Cells(1).Value = dr("itemname").ToString()
                DGVItem.Rows(indx).Cells(2).Value = dr("itemclass").ToString()

                indx = indx + 1
            End While
            dr.Close()
            DGVItem.ClearSelection()

            cmbitemname.AddDataGridView(DGVItem, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVItem_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVItem.CurrentRow.Index
            DGVItem.Rows(k).Selected = True
            DGVItem.CurrentCell = DGVItem.Rows(k).Cells(0)
            itemid = DGVItem.Rows(k).Cells(0).Value.ToString()
            itemname = DGVItem.Rows(k).Cells(1).Value.ToString()
            itemclass = DGVItem.Rows(k).Cells(2).Value.ToString()
            cmbitemname.Text = itemname
            LoadItemUnit(itemid)
            LoadItemUnitPrice(itemid)
            ItemTaxable(itemid)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ItemTaxable(ByVal itemno As String)
        Try
            cmd.CommandText = "select itemtaxtype from Inventory where itemid='" & itemno & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Taxable = dr("itemtaxtype").ToString()
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadItemUnit(ByVal ID As String)
        Try
            cmd.CommandText = "select weightunit from Inventory where itemid='" & ID & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim unt As String = dr("weightunit").ToString()
            dr.Close()
            If unt = "Gram" Or unt = "Kilogram" Or unt = "Milligram" Or unt = "Quintal" Or unt = "Tonne" Then
                cmbunit.Items.Clear()
                cmbunit.Items.Add("Kilogram")
                cmbunit.Items.Add("Gram")
                cmbunit.Items.Add("Milligram")
                cmbunit.Items.Add("Quintal")
                cmbunit.Items.Add("Tonne")
            ElseIf unt = "Milliliter" Or unt = "Liter" Or unt = "Barrel" Or unt = "Gallon" Then
                cmbunit.Items.Clear()
                cmbunit.Items.Add("Liter")
                cmbunit.Items.Add("Milliliter")
                cmbunit.Items.Add("Barrel")
                cmbunit.Items.Add("Gallon")
            ElseIf unt = "Square foot" Or unt = "Square inch" Or unt = "Square kilometer" Or unt = "Square mile" Or unt = "Square meter" Or unt = "Square centimeter" Or unt = "Square millimeter" Or unt = "Hectare" Or unt = "Square Yard" Or unt = "Acre" Then
                cmbunit.Items.Clear()
                cmbunit.Items.Add("Square foot")
                cmbunit.Items.Add("Square inch")
                cmbunit.Items.Add("Square kilometer")
                cmbunit.Items.Add("Square mile")
                cmbunit.Items.Add("Square meter")
                cmbunit.Items.Add("Square centimeter")
                cmbunit.Items.Add("Square millimeter")
                cmbunit.Items.Add("Hectare")
                cmbunit.Items.Add("Square Yard")
                cmbunit.Items.Add("Acre")
            ElseIf unt = "Meter" Or unt = "Centi Meter" Or unt = "Kilometer" Or unt = "Foot" Or unt = "Inch" Then
                cmbunit.Items.Clear()
                cmbunit.Items.Add("Meter")
                cmbunit.Items.Add("Centi Meter")
                cmbunit.Items.Add("Kilometer")
                cmbunit.Items.Add("Foot")
                cmbunit.Items.Add("Inch")
            ElseIf unt = "Pieces" Or unt = "Dozen" Then
                cmbunit.Items.Clear()
                cmbunit.Items.Add("Pieces")
                cmbunit.Items.Add("Dozen")
            End If
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadItemUnitPrice(ByVal ID As String)
        Try
            cmd.CommandText = "select UnitPrice from Inventory where itemid='" & ID & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            UnitPrice = CDec(dr("UnitPrice").ToString())
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub ItemPriceCalculation()
        Try
            If cmbunit.Text = "Kilogram" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight * 1000
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Gram" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Milligram" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight / 1000
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Quintal" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight * 100000
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Tonne" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight * 1000000
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Liter" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight * 1000
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Milliliter" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Barrel" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight * 117347.765
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Gallon" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight * 3785.41178
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Square foot" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight * 0.092903
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Square inch" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight * 0.00064516
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Square kilometer" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight * 1000000
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Square mile" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight * 2589988.11
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Square meter" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Square centimeter" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight * 0.0001
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Square millimeter" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight * 0.000001
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Hectare" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight * 10000
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Square Yard" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight * 0.836127
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Acre" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight * 4046.86
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Meter" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Centi Meter" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight * 0.01
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Kilometer" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight * 1000
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Foot" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight * 0.3048
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Inch" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight * 0.0254
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Pieces" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            ElseIf cmbunit.Text = "Dozen" Then
                Dim weight As Decimal = CDec(txtqnty.Text)
                Dim totprc As Decimal = UnitPrice
                Dim Qnty As Decimal = weight * 12
                Dim prc As Decimal = Qnty * UnitPrice
                txtprice.Text = prc.ToString()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TotalAmount()
        Try
            dgviewtotal.Rows.Clear()
            dgviewtotal.Rows.Add()
            dgviewtotal.Rows.Add()
            dgviewtotal.Rows.Add()
            Dim Amount As Decimal = 0.0
            Dim Price As Decimal = 0.0
            Dim tr As Decimal = 0.0
            Dim r As Integer = dgviewpurchase.Rows.Count
            Dim j As Integer
            For j = 0 To r - 1
                Amount += CDec(dgviewpurchase.Rows(j).Cells(7).Value.ToString())
                Price += CDec(dgviewpurchase.Rows(j).Cells(5).Value.ToString())
                tr += CDec(dgviewpurchase.Rows(j).Cells(6).Value.ToString())
            Next
            dgviewtotal.Rows(0).Cells(5).Value = "Total Price:"
            dgviewtotal.Rows(0).Cells(6).Value = FormatNumber(Price).ToString()
            dgviewtotal.Rows(1).Cells(5).Value = "Total Tax:"
            dgviewtotal.Rows(1).Cells(6).Value = FormatNumber(tr).ToString()
            dgviewtotal.Rows(2).Cells(5).Value = "Total Amount:"
            dgviewtotal.Rows(2).Cells(6).Value = FormatNumber(Amount).ToString()
            dgviewtotal.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CalculateTax()
        Try
            If Modify = False Then
                TaxRrate = CDec(txttaxrate.Text)
                Dim tax As Decimal = CDec(((CDec(txtprice.Text) * TaxRrate) / 100))
                dgviewpurchase.Rows(i).Cells(6).Value = FormatNumber(tax.ToString())
            Else
                TaxRrate = CDec(txttaxrate.Text)
                Dim tax As Decimal = CDec(((CDec(txtprice.Text) * TaxRrate) / 100))
                dgviewpurchase.Rows(ModifyIndex).Cells(6).Value = FormatNumber(tax.ToString())
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddToGrid()
        Try
            If cmbitemname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select item.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbitemname.Focus()
                End If
            ElseIf txtqnty.Text.Trim() = "" Or txtqnty.Text.Trim() = "0.00" Then
                Dim result As DialogResult = MessageBox.Show("Please enter qnty.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtqnty.Focus()
                End If
            ElseIf txtprice.Text.Trim = "" Or txtprice.Text.Trim() = "0.00" Then
                Dim result As DialogResult = MessageBox.Show("Please enter price.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtprice.Focus()
                End If
            ElseIf Taxable = "Taxable" And txttaxrate.Text.Trim() = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter tax rate.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txttaxrate.Focus()
                End If
            Else
                If Modify = True Then
                    dgviewpurchase.Rows(ModifyIndex).Cells(0).Value = itemid
                    dgviewpurchase.Rows(ModifyIndex).Cells(1).Value = itemname
                    dgviewpurchase.Rows(ModifyIndex).Cells(2).Value = itemclass
                    Dim qnt As Decimal = CDec(txtqnty.Text)
                    dgviewpurchase.Rows(ModifyIndex).Cells(3).Value = FormatNumber(qnt.ToString())
                    dgviewpurchase.Rows(ModifyIndex).Cells(4).Value = cmbunit.Text
                    Dim a As Decimal = CDec(txtprice.Text)
                    dgviewpurchase.Rows(ModifyIndex).Cells(5).Value = FormatNumber(a.ToString())
                    CalculateTax()
                    Dim b As Decimal = (CDec(dgviewpurchase.Rows(ModifyIndex).Cells(5).Value.ToString()) + CDec(dgviewpurchase.Rows(ModifyIndex).Cells(6).Value.ToString()))
                    dgviewpurchase.Rows(ModifyIndex).Cells(7).Value = FormatNumber(b.ToString())
                    dgviewpurchase.ClearSelection()
                    TotalAmount()
                    cmbitemname.Text = ""
                    lblitemid.Text = ""
                    txtqnty.Text = ""
                    txtprice.Text = ""
                    cmbunit.Text = ""
                    Modify = False
                    cmbitemname.Focus()
                Else
                    dgviewpurchase.Rows.Add()
                    dgviewpurchase.Rows(i).Cells(0).Value = itemid
                    dgviewpurchase.Rows(i).Cells(1).Value = itemname
                    dgviewpurchase.Rows(i).Cells(2).Value = itemclass
                    Dim qnt As Decimal = CDec(txtqnty.Text)
                    dgviewpurchase.Rows(i).Cells(3).Value = FormatNumber(qnt.ToString())
                    dgviewpurchase.Rows(i).Cells(4).Value = cmbunit.Text
                    Dim a As Decimal = CDec(txtprice.Text)
                    dgviewpurchase.Rows(i).Cells(5).Value = FormatNumber(a.ToString())
                    CalculateTax()
                    Dim b As Decimal = (CDec(dgviewpurchase.Rows(i).Cells(5).Value.ToString()) + CDec(dgviewpurchase.Rows(i).Cells(6).Value.ToString()))
                    dgviewpurchase.Rows(i).Cells(7).Value = FormatNumber(b.ToString())
                    i = i + 1
                    dgviewpurchase.ClearSelection()
                    TotalAmount()
                    cmbitemname.Text = ""
                    lblitemid.Text = ""
                    txtqnty.Text = ""
                    txtprice.Text = ""
                    cmbunit.Text = ""
                    cmbitemname.Focus()
                End If
                End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ConvertQnty(ByVal Unito As String, ByVal Qntyo As Decimal)
        Try
            If Unito = "Kilogram" Then
                Unit = "Gram"
                Qnty = Qntyo * 1000
            ElseIf Unito = "Gram" Then
                Unit = "Gram"
                Qnty = Qntyo
            ElseIf Unito = "Milligram" Then
                Unit = "Gram"
                Qnty = Qntyo / 1000
            ElseIf Unito = "Quintal" Then
                Unit = "Gram"
                Qnty = Qntyo * 100000
            ElseIf Unito = "Tonne" Then
                Unit = "Gram"
                Qnty = Qntyo * 1000000
            ElseIf Unito = "Liter" Then
                Unit = "Milliliter"
                Qnty = Qntyo * 1000
            ElseIf Unito = "Milliliter" Then
                Unit = "Milliliter"
                Qnty = Qntyo
            ElseIf Unito = "Barrel" Then
                Unit = "Milliliter"
                Qnty = Qntyo * 117347.765
            ElseIf Unito = "Gallon" Then
                Unit = "Milliliter"
                Qnty = Qntyo * 3785.41178
            ElseIf Unito = "Square foot" Then
                Unit = "Square meter"
                Qnty = Qntyo * 0.092903
            ElseIf Unito = "Square inch" Then
                Unit = "Square meter"
                Qnty = Qntyo * 0.00064516
            ElseIf Unito = "Square kilometer" Then
                Unit = "Square meter"
                Qnty = Qntyo * 1000000
            ElseIf Unito = "Square mile" Then
                Unit = "Square meter"
                Qnty = Qntyo * 2589988.11
            ElseIf Unito = "Square meter" Then
                Unit = "Square meter"
                Qnty = Qntyo
            ElseIf Unito = "Square centimeter" Then
                Unit = "Square meter"
                Qnty = Qntyo * 0.0001
            ElseIf Unito = "Square millimeter" Then
                Unit = "Square meter"
                Qnty = Qntyo * 0.000001
            ElseIf Unito = "Hectare" Then
                Unit = "Square meter"
                Qnty = Qntyo * 10000
            ElseIf Unito = "Square Yard" Then
                Unit = "Square meter"
                Qnty = Qntyo * 0.836127
            ElseIf Unito = "Acre" Then
                Unit = "Square meter"
                Qnty = Qntyo * 4046.86
            ElseIf Unito = "Meter" Then
                Unit = "Meter"
                Qnty = Qntyo
            ElseIf Unito = "Centi Meter" Then
                Unit = "Meter"
                Qnty = Qntyo * 0.01
            ElseIf Unito = "Kilometer" Then
                Unit = "Meter"
                Qnty = Qntyo * 1000
            ElseIf Unito = "Foot" Then
                Unit = "Meter"
                Qnty = Qntyo * 0.3048
            ElseIf Unito = "Inch" Then
                Unit = "Meter"
                Qnty = Qntyo * 0.0254
            ElseIf Unito = "Pieces" Then
                Unit = "Pieces"
                Qnty = Qntyo
            ElseIf Unito = "Dozen" Then
                Unit = "Pieces"
                Qnty = Qntyo * 12
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetForm()
        updatepurchase = False
        Modify = False
        i = 0
        UnitPrice = 0.0
        TaxRrate = 0.0
        dgviewpurchase.Rows.Clear()
        dgviewtotal.Rows.Clear()
        If ISDAutoID = "Yes" Then
            GetCode()
        Else
            txtpurchaseid.Text = ""
        End If
        LoadShippingTo()
        txtprice.Text = ""
        txtqnty.Text = ""
        txttaxrate.Text = ""
        txtvendoraddress.Text = ""
        txtvendoremail.Text = ""
        txtvendorname.Text = ""
        txtvendorphone.Text = ""
        lblaccount.Text = "Purchase Account: " + ISDPurchaseOrderAccount
        cmbdate.Text = UmbrellaSystemDate
        cmbduedate.Text = UmbrellaSystemDate
        cmbitemname.Text = ""
        cmbunit.Text = ""
        chkpaid.Checked = False
        PurchaseAmount = 0.0
        PurchaseNote = ""
        PurchasePaid = ""
        txtvendorname.Focus()
    End Sub

    Private Sub AddRecord()
        Try
            If txtvendorname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter vendor name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtvendorname.Focus()
                End If
            ElseIf txtshipname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter ship to name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtshipname.Focus()
                End If
            ElseIf txtpurchaseid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter purchase id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtpurchaseid.Focus()
                End If
            ElseIf cmbdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbdate.Focus()
                End If
            ElseIf cmbduedate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter due date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbduedate.Focus()
                End If
            ElseIf txttaxrate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter tax rate.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txttaxrate.Focus()
                End If
            ElseIf dgviewpurchase.Rows.Count <= 0 Then
                Dim result As DialogResult = MessageBox.Show("Please enter purchase item.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbitemname.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    CheckPurchaseID()
                    If PurID = False Then
                        Dim cls As New cPurchase()
                        Dim paid As String = ""
                        If chkpaid.Checked = True Then
                            paid = "Yes"
                        Else
                            paid = "No"
                        End If
                        Dim TotalPrice As Decimal = CDec(dgviewtotal.Rows(0).Cells(6).Value.ToString())
                        Dim TotalTax As Decimal = CDec(dgviewtotal.Rows(1).Cells(6).Value.ToString())
                        Dim TotalAmount As Decimal = CDec(dgviewtotal.Rows(2).Cells(6).Value.ToString())
                        For row As Integer = 0 To dgviewpurchase.Rows.Count - 1
                            Dim id As String = dgviewpurchase.Rows(row).Cells(0).Value.ToString()
                            Dim name As String = dgviewpurchase.Rows(row).Cells(1).Value.ToString()
                            Dim clas As String = dgviewpurchase.Rows(row).Cells(2).Value.ToString()
                            Dim qnt As Decimal = CDec(dgviewpurchase.Rows(row).Cells(3).Value.ToString())
                            Dim unt As String = dgviewpurchase.Rows(row).Cells(4).Value.ToString()
                            ConvertQnty(unt, qnt)
                            Dim prc As Decimal = CDec(dgviewpurchase.Rows(row).Cells(5).Value.ToString())
                            Dim tax As Decimal = CDec(dgviewpurchase.Rows(row).Cells(6).Value.ToString())
                            Dim amt As Decimal = CDec(dgviewpurchase.Rows(row).Cells(7).Value.ToString())
                            cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtpurchaseid.Text, cmbdate.Text, txtvendorname.Text, txtvendoraddress.Text, txtvendorphone.Text, txtvendoremail.Text, txtshipname.Text, txtshipaddress.Text, txtshipphone.Text, txtshipemail.Text, ISDPurchaseOrderAccount, CDec(txttaxrate.Text), id, name, clas, Qnty, Unit, prc, tax, amt, TotalPrice, TotalTax, TotalAmount, PurchaseNote, cmbduedate.Text, paid)
                        Next
                        If cls.AddRecordOk = True Then
                            cmd.CommandText = "update Indexx set purchaseid=purchaseid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                            If paid = "Yes" Then
                                cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & TotalAmount & " where AccountID='" & ISDPurchaseOrderAccount & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                                dr = cmd.ExecuteReader
                                dr.Close()
                                Dim dt As Date = Date.Parse(cmbdate.Text)
                                Dim month As Integer = dt.Month
                                Dim year As Integer = dt.Year
                                Dim description As String = "Purchase Order"
                                Dim type As String = "Expenditure"
                                Dim clas As String = ""
                                Dim roll As String = ""
                                Dim name As String = ""
                                Dim regno As String = ""
                                cmd.CommandText = "insert into IncomeExpenditure(InsID,InsName,Period,SystemDate,transactionid,descriptions,type,amount,class,roll,regno,name,month,year,account) values ('" & My.Settings.LastOpenedInstituteID & "','" & My.Settings.LastOpenedInstitute & "','" & My.Settings.Period & "','" & UmbrellaSystemDate & "','" & txtpurchaseid.Text & "','" & description & "','" & type & "'," & TotalAmount & ",'" & clas & "','" & roll & "','" & regno & "','" & name & "'," & month & "," & year & ",'" & ISDPurchaseOrderAccount & "')"
                                dr = cmd.ExecuteReader
                                dr.Close()
                            Else
                                Dim dt As Date = Date.Parse(cmbdate.Text)
                                Dim month As Integer = dt.Month
                                Dim year As Integer = dt.Year
                                Dim description As String = "Purchase Order"
                                Dim type As String = "Expenditure"
                                Dim clas As String = ""
                                Dim roll As String = ""
                                Dim name As String = ""
                                Dim regno As String = ""
                                cmd.CommandText = "insert into IncomeExpenditure(InsID,InsName,Period,SystemDate,transactionid,descriptions,type,amount,class,roll,regno,name,month,year,account) values ('" & My.Settings.LastOpenedInstituteID & "','" & My.Settings.LastOpenedInstitute & "','" & My.Settings.Period & "','" & UmbrellaSystemDate & "','" & txtpurchaseid.Text & "','" & description & "','" & type & "'," & TotalAmount & ",'" & clas & "','" & roll & "','" & regno & "','" & name & "'," & month & "," & year & ",'" & ISDPurchaseOrderAccount & "')"
                                dr = cmd.ExecuteReader
                                dr.Close()
                            End If
                            Dim result1 As DialogResult = MessageBox.Show("Record added successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = Windows.Forms.DialogResult.OK Then
                                txtvendorname.Focus()
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Purchase id already exist." + Environment.NewLine + "Please enter a new purchase id.", "Umbrella - Duplicate Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            txtpurchaseid.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If txtvendorname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter vendor name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtvendorname.Focus()
                End If
            ElseIf txtshipname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter ship to name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtshipname.Focus()
                End If
            ElseIf txtpurchaseid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter purchase id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtpurchaseid.Focus()
                End If
            ElseIf cmbdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbdate.Focus()
                End If
            ElseIf cmbduedate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter due date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbduedate.Focus()
                End If
            ElseIf txttaxrate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter tax rate.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txttaxrate.Focus()
                End If
            ElseIf dgviewpurchase.Rows.Count <= 0 Then
                Dim result As DialogResult = MessageBox.Show("Please enter purchase item.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbitemname.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cPurchase()
                    For indx As Integer = 0 To dgviewpurchase.Rows.Count - 1
                        Dim id As String = dgviewpurchase.Rows(indx).Cells(0).Value.ToString()
                        Dim name As String = dgviewpurchase.Rows(indx).Cells(1).Value.ToString()
                        Dim clas As String = dgviewpurchase.Rows(indx).Cells(2).Value.ToString()
                        cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtpurchaseid.Text, cmbdate.Text, id, name, clas)
                    Next
                    If PurchasePaid = "Yes" Then
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & PurchaseAmount & " where AccountID='" & ISDPurchaseOrderAccount & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                    End If
                    Dim paid As String = ""
                    If chkpaid.Checked = True Then
                        paid = "Yes"
                    Else
                        paid = "No"
                    End If
                    Dim TotalPrice As Decimal = CDec(dgviewtotal.Rows(0).Cells(6).Value.ToString())
                    Dim TotalTax As Decimal = CDec(dgviewtotal.Rows(1).Cells(6).Value.ToString())
                    Dim TotalAmount As Decimal = CDec(dgviewtotal.Rows(2).Cells(6).Value.ToString())
                    For row As Integer = 0 To dgviewpurchase.Rows.Count - 1
                        Dim id As String = dgviewpurchase.Rows(row).Cells(0).Value.ToString()
                        Dim name As String = dgviewpurchase.Rows(row).Cells(1).Value.ToString()
                        Dim clas As String = dgviewpurchase.Rows(row).Cells(2).Value.ToString()
                        Dim qnt As Decimal = CDec(dgviewpurchase.Rows(row).Cells(3).Value.ToString())
                        Dim unt As String = dgviewpurchase.Rows(row).Cells(4).Value.ToString()
                        ConvertQnty(unt, qnt)
                        Dim prc As Decimal = CDec(dgviewpurchase.Rows(row).Cells(5).Value.ToString())
                        Dim tax As Decimal = CDec(dgviewpurchase.Rows(row).Cells(6).Value.ToString())
                        Dim amt As Decimal = CDec(dgviewpurchase.Rows(row).Cells(7).Value.ToString())
                        cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtpurchaseid.Text, cmbdate.Text, txtvendorname.Text, txtvendoraddress.Text, txtvendorphone.Text, txtvendoremail.Text, txtshipname.Text, txtshipaddress.Text, txtshipphone.Text, txtshipemail.Text, ISDPurchaseOrderAccount, CDec(txttaxrate.Text), id, name, clas, Qnty, Unit, prc, tax, amt, TotalPrice, TotalTax, TotalAmount, PurchaseNote, cmbduedate.Text, paid)
                    Next
                    If cls.AddRecordOk = True Then
                        If paid = "Yes" Then
                            cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & TotalAmount & " where AccountID='" & ISDPurchaseOrderAccount & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                            Dim dt As Date = Date.Parse(cmbdate.Text)
                            Dim month As Integer = dt.Month
                            Dim year As Integer = dt.Year
                            Dim description As String = "Purchase Order"
                            Dim type As String = "Expenditure"
                            Dim clas As String = ""
                            Dim roll As String = ""
                            Dim name As String = ""
                            Dim regno As String = ""
                            cmd.CommandText = "update IncomeExpenditure set SystemDate='" & UmbrellaSystemDate & "',amount=" & TotalAmount & ",regno='" & regno & "',name='" & name & "',month=" & month & ",year=" & year & ",account='" & ISDPurchaseOrderAccount & "' where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and transactionid='" & txtpurchaseid.Text & "' and descriptions='" & description & "' and type='" & type & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                        Else
                            Dim dt As Date = Date.Parse(cmbdate.Text)
                            Dim month As Integer = dt.Month
                            Dim year As Integer = dt.Year
                            Dim description As String = "Purchase Order"
                            Dim type As String = "Expenditure"
                            Dim clas As String = ""
                            Dim roll As String = ""
                            Dim name As String = ""
                            Dim regno As String = ""
                            Dim Amount As Decimal = 0.0
                            cmd.CommandText = "update IncomeExpenditure set SystemDate='" & UmbrellaSystemDate & "',amount=" & Amount & ",regno='" & regno & "',name='" & name & "',month=" & month & ",year=" & year & ",account='" & ISDPurchaseOrderAccount & "' where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and transactionid='" & txtpurchaseid.Text & "' and descriptions='" & description & "' and type='" & type & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                        End If
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            txtvendorname.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If txtpurchaseid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter purchase id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtpurchaseid.Focus()
                End If
            ElseIf cmbdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbdate.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cPurchase()
                    For indx As Integer = 0 To dgviewpurchase.Rows.Count - 1
                        Dim id As String = dgviewpurchase.Rows(indx).Cells(0).Value.ToString()
                        Dim name As String = dgviewpurchase.Rows(indx).Cells(1).Value.ToString()
                        Dim clas As String = dgviewpurchase.Rows(indx).Cells(2).Value.ToString()
                        cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtpurchaseid.Text, cmbdate.Text, id, name, clas)
                    Next
                    If cls.DeleteRecordOk = True Then
                        If PurchasePaid = "Yes" Then
                            cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & PurchaseAmount & " where AccountID='" & ISDPurchaseOrderAccount & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                            Dim dt As Date = Date.Parse(cmbdate.Text)
                            Dim month As Integer = dt.Month
                            Dim year As Integer = dt.Year
                            Dim description As String = "Purchase Order"
                            Dim type As String = "Expenditure"
                            Dim clas As String = ""
                            Dim roll As String = ""
                            Dim name As String = ""
                            Dim regno As String = ""
                            cmd.CommandText = "delete from IncomeExpenditure where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and transactionid='" & txtpurchaseid.Text & "' and descriptions='" & description & "' and type='" & type & "' and class='" & clas & "' and roll='" & roll & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                        Else
                            Dim dt As Date = Date.Parse(cmbdate.Text)
                            Dim month As Integer = dt.Month
                            Dim year As Integer = dt.Year
                            Dim description As String = "Purchase Order"
                            Dim type As String = "Expenditure"
                            Dim clas As String = ""
                            Dim roll As String = ""
                            Dim name As String = ""
                            Dim regno As String = ""
                            cmd.CommandText = "delete from IncomeExpenditure where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and transactionid='" & txtpurchaseid.Text & "' and descriptions='" & description & "' and type='" & type & "' and class='" & clas & "' and roll='" & roll & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                        End If
                        Dim result1 As DialogResult = MessageBox.Show("Record deleted successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            ResetForm()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedRecord()
        Try
            cmd.CommandText = "select vendoraddress,vendoremail,vendorname,vendorphone,shipaddress,shipemail,shipto,shipphone,purchaseid,purchasedate,taxrate,expenseaccount,duedate,purchasenote,paid from Purchase where purchaseid='" & purchaseid & "' and purchasedate='" & purchasedate & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read Then
                txtvendoraddress.Text = dr("vendoraddress").ToString()
                txtvendoremail.Text = dr("vendoremail").ToString()
                txtvendorname.Text = dr("vendorname").ToString()
                txtvendorphone.Text = dr("vendorphone").ToString()
                txtshipaddress.Text = dr("shipaddress").ToString()
                txtshipemail.Text = dr("shipemail").ToString()
                txtshipname.Text = dr("shipto").ToString()
                txtshipphone.Text = dr("shipphone").ToString()
                txtpurchaseid.Text = dr("purchaseid").ToString()
                cmbdate.Text = dr("purchasedate").ToString()
                txttaxrate.Text = dr("taxrate").ToString()
                cmbduedate.Text = dr("duedate").ToString()
                If dr("paid").ToString() = "Yes" Then
                    chkpaid.Checked = True
                Else
                    chkpaid.Checked = False
                End If
                PurchasePaid = dr("paid").ToString()
                PurchaseNote = dr("purchasenote").ToString()
            End If
            dr.Close()
            dgviewtotal.Rows.Clear()
            dgviewtotal.Rows.Add()
            dgviewtotal.Rows.Add()
            dgviewtotal.Rows.Add()
            dgviewpurchase.Rows.Clear()
            i = 0
            cmd.CommandText = "select itemid,itemname,itemclass,itemqnty,itemunit,itemprice,itemtax,itemtotal,totalprice,totaltax,totalamount from Purchase where purchaseid='" & purchaseid & "' and purchasedate='" & purchasedate & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewpurchase.Rows.Add()
                dgviewpurchase.Rows(i).Cells(0).Value = dr("itemid").ToString()
                dgviewpurchase.Rows(i).Cells(1).Value = dr("itemname").ToString()
                dgviewpurchase.Rows(i).Cells(2).Value = dr("itemclass").ToString()
                dgviewpurchase.Rows(i).Cells(3).Value = dr("itemqnty").ToString()
                dgviewpurchase.Rows(i).Cells(4).Value = dr("itemunit").ToString()
                dgviewpurchase.Rows(i).Cells(5).Value = dr("itemprice").ToString()
                dgviewpurchase.Rows(i).Cells(6).Value = dr("itemtax").ToString()
                dgviewpurchase.Rows(i).Cells(7).Value = dr("itemtotal").ToString()
                i = i + 1
                Dim price As Decimal = CDec(dr("totalprice").ToString())
                Dim tr As Decimal = CDec(dr("totaltax").ToString())
                Dim amount As Decimal = CDec(dr("totalamount").ToString())
                PurchaseAmount = CDec(dr("totalamount").ToString())
                dgviewtotal.Rows(0).Cells(5).Value = "Total Price:"
                dgviewtotal.Rows(0).Cells(6).Value = FormatNumber(price).ToString()
                dgviewtotal.Rows(1).Cells(5).Value = "Total Tax:"
                dgviewtotal.Rows(1).Cells(6).Value = FormatNumber(tr).ToString()
                dgviewtotal.Rows(2).Cells(5).Value = "Total Amount:"
                dgviewtotal.Rows(2).Cells(6).Value = FormatNumber(amount).ToString()
            End While
            dr.Close()
            dgviewpurchase.ClearSelection()
            dgviewtotal.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CheckPurchaseID()
        Try
            cmd.CommandText = "select * from Purchase where purchaseid='" & txtpurchaseid.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                PurID = True
            Else
                PurID = False
            End If
            dr.Close()
        Catch ex As Exception
            PurID = False
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmPurchase_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updatepurchase = False Then
            ControlSetBound()
            LoadShippingTo()
            lblaccount.Text = "Purchase Account: " + ISDPurchaseOrderAccount
            LoadItem()
            cmbdate.Text = UmbrellaSystemDate
            cmbduedate.Text = UmbrellaSystemDate
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            lblaccount.Text = "Purchase Account: " + ISDPurchaseOrderAccount
            LoadItem()
            LoadSelectedRecord()
        End If
        If USpurchaseorder = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbdate.Enabled = False
            cmbduedate.Enabled = False
            cmbitemname.Enabled = False
            cmbunit.Enabled = False
            txtprice.ReadOnly = True
            txtpurchaseid.ReadOnly = True
            txtqnty.ReadOnly = True
            txtshipaddress.ReadOnly = True
            txtshipemail.ReadOnly = True
            txtshipname.ReadOnly = True
            txtshipphone.ReadOnly = True
            txttaxrate.ReadOnly = True
            txtvendoraddress.ReadOnly = True
            txtvendoremail.ReadOnly = True
            txtvendorname.ReadOnly = True
            txtvendorphone.ReadOnly = True
            dgviewpurchase.Enabled = False
            dgviewtotal.Enabled = False
            chkpaid.Enabled = False
        End If
    End Sub
#End Region
#Region "Attributes..."
    Private Sub txtvendorname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtvendorname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtvendoraddress.Focus()
        End If
    End Sub

    Private Sub txtvendoraddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtvendoraddress.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtvendorphone.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtvendorname.Focus()
        End If
    End Sub

    Private Sub txtvendorphone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtvendorphone.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtvendoremail.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtvendoraddress.Focus()
        End If
    End Sub

    Private Sub txtvendoremail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtvendoremail.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtshipname.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtvendorphone.Focus()
        End If
    End Sub

    Private Sub txtshipname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtshipname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtshipaddress.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtvendoremail.Focus()
        End If
    End Sub

    Private Sub txtshipaddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtshipaddress.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtshipphone.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtshipname.Focus()
        End If
    End Sub

    Private Sub txtshipphone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtshipphone.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtshipemail.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtshipaddress.Focus()
        End If
    End Sub

    Private Sub txtshipemail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtshipemail.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtpurchaseid.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtshipphone.Focus()
        End If
    End Sub

    Private Sub txtpurchaseid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpurchaseid.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbdate.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtshipemail.Focus()
        End If
    End Sub

    Private Sub cmbdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            txttaxrate.Focus()
        End If
    End Sub

    Private Sub txttaxrate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttaxrate.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbduedate.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbdate.Focus()
        End If
    End Sub

    Private Sub cmbduedate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbduedate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbitemname.Focus()
        End If
    End Sub

    Private Sub cmbitemname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbitemname.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtqnty.Focus()
        End If
    End Sub

    Private Sub txtqnty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtqnty.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbunit.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbitemname.Focus()
        End If
    End Sub

    Private Sub cmbunit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbunit.KeyDown
        If e.KeyCode = Keys.Enter Then
            ItemPriceCalculation()
            txtprice.Focus()
        End If
    End Sub

    Private Sub txtprice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtprice.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            AddToGrid()
        ElseIf e.KeyCode = Keys.Up Then
            cmbunit.Focus()
        End If
    End Sub

    Private Sub TextBoxTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtvendoraddress.TextChanged, txtvendorname.TextChanged, txtshipaddress.TextChanged, txtshipname.TextChanged
        Dim ctc As New cTextChange()
        Dim x As eTextBox = CType(sender, eTextBox)
        ctc.ConvertTextBoxValidValue(x)
    End Sub

    Private Sub ComboBoxKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbitemname.KeyPress, cmbunit.KeyPress, cmbdate.KeyPress, cmbduedate.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub
#End Region
#Region "ContextMenuStrip Events..."
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim row As Integer = dgviewpurchase.CurrentRow.Index
        dgviewpurchase.Rows.RemoveAt(row)
        i = i - 1
        TotalAmount()
    End Sub

    Private Sub ModifyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyToolStripMenuItem.Click
        Dim row As Integer = dgviewpurchase.CurrentRow.Index
        cmbitemname.Text = dgviewpurchase.Rows(row).Cells(1).Value.ToString()
        txtqnty.Text = dgviewpurchase.Rows(row).Cells(3).Value.ToString()
        cmbunit.Text = dgviewpurchase.Rows(row).Cells(4).Value.ToString()
        txtprice.Text = dgviewpurchase.Rows(row).Cells(5).Value.ToString()
        Modify = True
        ModifyIndex = row
        LoadItemUnit(dgviewpurchase.Rows(row).Cells(0).Value.ToString())
        LoadItemUnitPrice(dgviewpurchase.Rows(row).Cells(0).Value.ToString())
        cmbitemname.Focus()
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatepurchase = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatepurchase = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatepurchase = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updatepurchase = False Then
            ControlSetBound()
            LoadShippingTo()
            lblaccount.Text = "Purchase Account: " + ISDPurchaseOrderAccount
            LoadItem()
            cmbdate.Text = UmbrellaSystemDate
            cmbduedate.Text = UmbrellaSystemDate
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            lblaccount.Text = "Purchase Account: " + ISDPurchaseOrderAccount
            LoadItem()
            LoadSelectedRecord()
        End If
    End Sub

    Private Sub btnnote_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnote.ClickButtonArea
        purchaseid = txtpurchaseid.Text
        Dim frm As New frmPurchaseNote()
        frm.ShowDialog()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region