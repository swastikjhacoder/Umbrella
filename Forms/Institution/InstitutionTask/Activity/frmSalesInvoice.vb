#Region "Imports..."
Imports ESAR_Controls.UIControls.TextBox
#End Region
#Region "Class frmSalesInvoice..."
Public Class frmSalesInvoice
#Region "Declarations..."
    Private DGVItem As New DataGridView()
    Private ACODE As String = ""
    Private TT As String = ""
    Private UnitPrice As Decimal = 0.0
    Private TaxRrate As Decimal = 0.0
    Private i As Integer = 0
    Private Modify As Boolean = False
    Private ModifyIndex As Integer = 0
    Private InvoicePaid As String = ""
    Private InvoiceAmount As Decimal = 0.0
    Private Unit As String = ""
    Private Qnty As Decimal = 0.0
    Private Taxable As String = ""
    Private InvoiceExist As Boolean = False
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        ACODE = Indx.LoadInvoiceID()
        Dim var As String
        var = CodeIncrement(ACODE)
        Me.txtinvoiceid.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("INVOICE:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        Label1.SetBounds(13, 49, 39, 13)
        Label10.SetBounds(13, 76, 66, 13)
        Label2.SetBounds(13, 103, 62, 13)
        Label3.SetBounds(199, 103, 19, 13)
        Label4.SetBounds(0, 0, 39, 21)
        Label5.SetBounds(209, 0, 39, 21)
        Label6.SetBounds(333, 0, 34, 21)
        Label7.SetBounds(545, 0, 40, 21)
        Label8.SetBounds(13, 22, 26, 13)
        lblaccount.SetBounds(22, 10, 0, 13)

        chkpaid.SetBounds(478, 9, 50, 17)

        cmbdate.SetBounds(103, 46, 115, 21)
        cmbduedate.SetBounds(103, 73, 115, 21)
        cmbitemname.SetBounds(39, 0, 170, 21)
        cmbunit.SetBounds(367, 0, 178, 21)

        txtaddress.SetBounds(25, 61, 409, 21)
        txtemail.SetBounds(187, 88, 247, 21)
        txtinvoiceid.SetBounds(103, 19, 115, 21)
        txtname.SetBounds(25, 34, 409, 21)
        txtphone.SetBounds(25, 88, 156, 21)
        txtprice.SetBounds(585, 0, 85, 21)
        txtqnty.SetBounds(248, 0, 85, 21)
        txttaxrate.SetBounds(103, 100, 90, 21)
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
            cmd.CommandText = "select itemid,itemname,itemclass from Inventory where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and onhandqnty>0"
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
            Dim r As Integer = dgviewinvoice.Rows.Count
            Dim j As Integer
            For j = 0 To r - 1
                Amount += CDec(dgviewinvoice.Rows(j).Cells(7).Value.ToString())
                Price += CDec(dgviewinvoice.Rows(j).Cells(5).Value.ToString())
                tr += CDec(dgviewinvoice.Rows(j).Cells(6).Value.ToString())
            Next
            dgviewtotal.Rows(0).Cells(7).Value = "Total Price:"
            dgviewtotal.Rows(0).Cells(8).Value = FormatNumber(Price).ToString()
            dgviewtotal.Rows(1).Cells(7).Value = "Total Tax:"
            dgviewtotal.Rows(1).Cells(8).Value = FormatNumber(tr).ToString()
            dgviewtotal.Rows(2).Cells(7).Value = "Total Amount:"
            dgviewtotal.Rows(2).Cells(8).Value = FormatNumber(Amount).ToString()
            dgviewtotal.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CalculateTax()
        Try
            If Modify = False Then
                TaxRrate = CDec(txttaxrate.Text)
                Dim tax As Decimal = CDec(((CDec(txtprice.Text) * TaxRrate) / 100))
                dgviewinvoice.Rows(i).Cells(6).Value = FormatNumber(tax.ToString())
            Else
                TaxRrate = CDec(txttaxrate.Text)
                Dim tax As Decimal = CDec(((CDec(txtprice.Text) * TaxRrate) / 100))
                dgviewinvoice.Rows(ModifyIndex).Cells(6).Value = FormatNumber(tax.ToString())
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
                    dgviewinvoice.Rows(ModifyIndex).Cells(0).Value = itemid
                    dgviewinvoice.Rows(ModifyIndex).Cells(1).Value = itemname
                    dgviewinvoice.Rows(ModifyIndex).Cells(2).Value = itemclass
                    Dim qnt As Decimal = CDec(txtqnty.Text)
                    dgviewinvoice.Rows(ModifyIndex).Cells(3).Value = FormatNumber(qnt.ToString())
                    dgviewinvoice.Rows(ModifyIndex).Cells(4).Value = cmbunit.Text
                    Dim a As Decimal = CDec(txtprice.Text)
                    dgviewinvoice.Rows(ModifyIndex).Cells(5).Value = FormatNumber(a.ToString())
                    CalculateTax()
                    Dim b As Decimal = (CDec(dgviewinvoice.Rows(ModifyIndex).Cells(5).Value.ToString()) + CDec(dgviewinvoice.Rows(ModifyIndex).Cells(6).Value.ToString()))
                    dgviewinvoice.Rows(ModifyIndex).Cells(7).Value = FormatNumber(b.ToString())
                    dgviewinvoice.ClearSelection()
                    TotalAmount()
                    cmbitemname.Text = ""
                    lblitemid.Text = ""
                    txtqnty.Text = ""
                    txtprice.Text = ""
                    cmbunit.Text = ""
                    Modify = False
                    cmbitemname.Focus()
                Else
                    dgviewinvoice.Rows.Add()
                    dgviewinvoice.Rows(i).Cells(0).Value = itemid
                    dgviewinvoice.Rows(i).Cells(1).Value = itemname
                    dgviewinvoice.Rows(i).Cells(2).Value = itemclass
                    Dim qnt As Decimal = CDec(txtqnty.Text)
                    dgviewinvoice.Rows(i).Cells(3).Value = FormatNumber(qnt.ToString())
                    dgviewinvoice.Rows(i).Cells(4).Value = cmbunit.Text
                    Dim a As Decimal = CDec(txtprice.Text)
                    dgviewinvoice.Rows(i).Cells(5).Value = FormatNumber(a.ToString())
                    CalculateTax()
                    Dim b As Decimal = (CDec(dgviewinvoice.Rows(i).Cells(5).Value.ToString()) + CDec(dgviewinvoice.Rows(i).Cells(6).Value.ToString()))
                    dgviewinvoice.Rows(i).Cells(7).Value = FormatNumber(b.ToString())
                    i = i + 1
                    dgviewinvoice.ClearSelection()
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
        updateinvoice = False
        Modify = False
        i = 0
        UnitPrice = 0.0
        TaxRrate = 0.0
        dgviewinvoice.Rows.Clear()
        dgviewtotal.Rows.Clear()
        If ISDAutoID = "Yes" Then
            GetCode()
        Else
            txtinvoiceid.Text = ""
        End If
        cmbdate.Text = UmbrellaSystemDate
        cmbduedate.Text = UmbrellaSystemDate
        txtaddress.Text = ""
        txtemail.Text = ""
        txtname.Text = ""
        txtphone.Text = ""
        txtprice.Text = ""
        txtqnty.Text = ""
        txttaxrate.Text = ""
        lblaccount.Text = "Sales Invoice Account: " + ISDSalesInvoiceAccount
        cmbitemname.Text = ""
        cmbunit.Text = ""
        chkpaid.Checked = False
        InvoiceAmount = 0.0
        InvoiceNote = ""
        InvoicePaid = ""
        txtname.Focus()
    End Sub

    Private Sub AddRecord()
        Try
            If txtname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter customer name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtname.Focus()
                End If
            ElseIf txtinvoiceid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter invoice id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtinvoiceid.Focus()
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
            ElseIf dgviewinvoice.Rows.Count <= 0 Then
                Dim result As DialogResult = MessageBox.Show("Please enter invoice item.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbitemname.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    CheckInvoiceNo()
                    If InvoiceExist = False Then
                        Dim cls As New cInvoice()
                        Dim paid As String = ""
                        If chkpaid.Checked = True Then
                            paid = "Yes"
                        Else
                            paid = "No"
                        End If
                        Dim TotalPrice As Decimal = CDec(dgviewtotal.Rows(0).Cells(8).Value.ToString())
                        Dim TotalTax As Decimal = CDec(dgviewtotal.Rows(1).Cells(8).Value.ToString())
                        Dim TotalAmount As Decimal = CDec(dgviewtotal.Rows(2).Cells(8).Value.ToString())
                        For row As Integer = 0 To dgviewinvoice.Rows.Count - 1
                            Dim id As String = dgviewinvoice.Rows(row).Cells(0).Value.ToString()
                            Dim name As String = dgviewinvoice.Rows(row).Cells(1).Value.ToString()
                            Dim clas As String = dgviewinvoice.Rows(row).Cells(2).Value.ToString()
                            Dim qnt As Decimal = CDec(dgviewinvoice.Rows(row).Cells(3).Value.ToString())
                            Dim unt As String = dgviewinvoice.Rows(row).Cells(4).Value.ToString()
                            ConvertQnty(unt, qnt)
                            Dim prc As Decimal = CDec(dgviewinvoice.Rows(row).Cells(5).Value.ToString())
                            Dim tax As Decimal = CDec(dgviewinvoice.Rows(row).Cells(6).Value.ToString())
                            Dim amt As Decimal = CDec(dgviewinvoice.Rows(row).Cells(7).Value.ToString())
                            cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtinvoiceid.Text, cmbdate.Text, txtname.Text, txtaddress.Text, txtphone.Text, txtemail.Text, ISDSalesInvoiceAccount, CDec(txttaxrate.Text), id, name, clas, Qnty, Unit, prc, tax, amt, TotalPrice, TotalTax, TotalAmount, InvoiceNote, cmbduedate.Text, paid)
                        Next
                        If cls.AddRecordOk = True Then
                            cmd.CommandText = "update Indexx set invoiceid=invoiceid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                            If paid = "Yes" Then
                                cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & TotalAmount & " where AccountID='" & ISDSalesInvoiceAccount & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                                dr = cmd.ExecuteReader
                                dr.Close()
                                Dim dt As Date = Date.Parse(cmbdate.Text)
                                Dim month As Integer = dt.Month
                                Dim year As Integer = dt.Year
                                Dim description As String = "Sales Invoice"
                                Dim type As String = "Income"
                                Dim clas As String = ""
                                Dim roll As String = ""
                                Dim name As String = ""
                                Dim regno As String = ""
                                cmd.CommandText = "insert into IncomeExpenditure(InsID,InsName,Period,SystemDate,transactionid,descriptions,type,amount,class,roll,regno,name,month,year,account) values ('" & My.Settings.LastOpenedInstituteID & "','" & My.Settings.LastOpenedInstitute & "','" & My.Settings.Period & "','" & UmbrellaSystemDate & "','" & txtinvoiceid.Text & "','" & description & "','" & type & "'," & TotalAmount & ",'" & clas & "','" & roll & "','" & regno & "','" & name & "'," & month & "," & year & ",'" & ISDSalesInvoiceAccount & "')"
                                dr = cmd.ExecuteReader
                                dr.Close()
                            Else
                                Dim dt As Date = Date.Parse(cmbdate.Text)
                                Dim month As Integer = dt.Month
                                Dim year As Integer = dt.Year
                                Dim description As String = "Sales Invoice"
                                Dim type As String = "Income"
                                Dim clas As String = ""
                                Dim roll As String = ""
                                Dim name As String = ""
                                Dim regno As String = ""
                                Dim Amount As Decimal = 0.0
                                cmd.CommandText = "insert into IncomeExpenditure(InsID,InsName,Period,SystemDate,transactionid,descriptions,type,amount,class,roll,regno,name,month,year,account) values ('" & My.Settings.LastOpenedInstituteID & "','" & My.Settings.LastOpenedInstitute & "','" & My.Settings.Period & "','" & UmbrellaSystemDate & "','" & txtinvoiceid.Text & "','" & description & "','" & type & "'," & Amount & ",'" & clas & "','" & roll & "','" & regno & "','" & name & "'," & month & "," & year & ",'" & ISDSalesInvoiceAccount & "')"
                                dr = cmd.ExecuteReader
                                dr.Close()
                            End If
                            Dim result1 As DialogResult = MessageBox.Show("Record added successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = Windows.Forms.DialogResult.OK Then
                                txtname.Focus()
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Invoice id already exist." + Environment.NewLine + "Please enter a new invoice id.", "Umbrella - Duplicate Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            txtinvoiceid.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If txtname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter customer name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtname.Focus()
                End If
            ElseIf txtinvoiceid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter invoice id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtinvoiceid.Focus()
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
            ElseIf dgviewinvoice.Rows.Count <= 0 Then
                Dim result As DialogResult = MessageBox.Show("Please enter invoice item.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbitemname.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cInvoice()
                    For indx As Integer = 0 To dgviewinvoice.Rows.Count - 1
                        Dim id As String = dgviewinvoice.Rows(indx).Cells(0).Value.ToString()
                        Dim name As String = dgviewinvoice.Rows(indx).Cells(1).Value.ToString()
                        Dim clas As String = dgviewinvoice.Rows(indx).Cells(2).Value.ToString()
                        cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtinvoiceid.Text, cmbdate.Text, id, name, clas)
                    Next
                    If InvoicePaid = "Yes" Then
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & InvoiceAmount & " where AccountID='" & ISDSalesInvoiceAccount & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                    End If
                    Dim paid As String = ""
                    If chkpaid.Checked = True Then
                        paid = "Yes"
                    Else
                        paid = "No"
                    End If
                    Dim TotalPrice As Decimal = CDec(dgviewtotal.Rows(0).Cells(8).Value.ToString())
                    Dim TotalTax As Decimal = CDec(dgviewtotal.Rows(1).Cells(8).Value.ToString())
                    Dim TotalAmount As Decimal = CDec(dgviewtotal.Rows(2).Cells(8).Value.ToString())
                    For row As Integer = 0 To dgviewinvoice.Rows.Count - 1
                        Dim id As String = dgviewinvoice.Rows(row).Cells(0).Value.ToString()
                        Dim name As String = dgviewinvoice.Rows(row).Cells(1).Value.ToString()
                        Dim clas As String = dgviewinvoice.Rows(row).Cells(2).Value.ToString()
                        Dim qnt As Decimal = CDec(dgviewinvoice.Rows(row).Cells(3).Value.ToString())
                        Dim unt As String = dgviewinvoice.Rows(row).Cells(4).Value.ToString()
                        ConvertQnty(unt, qnt)
                        Dim prc As Decimal = CDec(dgviewinvoice.Rows(row).Cells(5).Value.ToString())
                        Dim tax As Decimal = CDec(dgviewinvoice.Rows(row).Cells(6).Value.ToString())
                        Dim amt As Decimal = CDec(dgviewinvoice.Rows(row).Cells(7).Value.ToString())
                        cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtinvoiceid.Text, cmbdate.Text, txtname.Text, txtaddress.Text, txtphone.Text, txtemail.Text, ISDSalesInvoiceAccount, CDec(txttaxrate.Text), id, name, clas, Qnty, Unit, prc, tax, amt, TotalPrice, TotalTax, TotalAmount, InvoiceNote, cmbduedate.Text, paid)
                    Next
                    If cls.AddRecordOk = True Then
                        If paid = "Yes" Then
                            cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & TotalAmount & " where AccountID='" & ISDSalesInvoiceAccount & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                            Dim dt As Date = Date.Parse(cmbdate.Text)
                            Dim month As Integer = dt.Month
                            Dim year As Integer = dt.Year
                            Dim description As String = "Sales Invoice"
                            Dim type As String = "Income"
                            Dim clas As String = ""
                            Dim roll As String = ""
                            Dim name As String = ""
                            Dim regno As String = ""
                            cmd.CommandText = "update IncomeExpenditure set SystemDate='" & UmbrellaSystemDate & "',amount=" & TotalAmount & ",regno='" & regno & "',name='" & name & "',month=" & month & ",year=" & year & ",account='" & ISDSalesInvoiceAccount & "' where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and transactionid='" & txtinvoiceid.Text & "' and descriptions='" & description & "' and type='" & type & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                        Else
                            Dim dt As Date = Date.Parse(cmbdate.Text)
                            Dim month As Integer = dt.Month
                            Dim year As Integer = dt.Year
                            Dim description As String = "Sales Invoice"
                            Dim type As String = "Income"
                            Dim clas As String = ""
                            Dim roll As String = ""
                            Dim name As String = ""
                            Dim regno As String = ""
                            cmd.CommandText = "update IncomeExpenditure set SystemDate='" & UmbrellaSystemDate & "',amount=" & TotalAmount & ",regno='" & regno & "',name='" & name & "',month=" & month & ",year=" & year & ",account='" & ISDSalesInvoiceAccount & "' where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and transactionid='" & txtinvoiceid.Text & "' and descriptions='" & description & "' and type='" & type & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                        End If
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            txtname.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If txtinvoiceid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter invoice id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtinvoiceid.Focus()
                End If
            ElseIf cmbdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbdate.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cInvoice()
                    For indx As Integer = 0 To dgviewinvoice.Rows.Count - 1
                        Dim id As String = dgviewinvoice.Rows(indx).Cells(0).Value.ToString()
                        Dim name As String = dgviewinvoice.Rows(indx).Cells(1).Value.ToString()
                        Dim clas As String = dgviewinvoice.Rows(indx).Cells(2).Value.ToString()
                        cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtinvoiceid.Text, cmbdate.Text, id, name, clas)
                    Next
                    If cls.DeleteRecordOk = True Then
                        If InvoicePaid = "Yes" Then
                            cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & InvoiceAmount & " where AccountID='" & ISDSalesInvoiceAccount & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                            Dim dt As Date = Date.Parse(cmbdate.Text)
                            Dim month As Integer = dt.Month
                            Dim year As Integer = dt.Year
                            Dim description As String = "Sales Invoice"
                            Dim type As String = "Income"
                            Dim clas As String = ""
                            Dim roll As String = ""
                            Dim name As String = ""
                            Dim regno As String = ""
                            cmd.CommandText = "delete from IncomeExpenditure where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and transactionid='" & txtinvoiceid.Text & "' and descriptions='" & description & "' and type='" & type & "' and class='" & clas & "' and roll='" & roll & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                        Else
                            Dim dt As Date = Date.Parse(cmbdate.Text)
                            Dim month As Integer = dt.Month
                            Dim year As Integer = dt.Year
                            Dim description As String = "Sales Invoice"
                            Dim type As String = "Income"
                            Dim clas As String = ""
                            Dim roll As String = ""
                            Dim name As String = ""
                            Dim regno As String = ""
                            cmd.CommandText = "delete from IncomeExpenditure where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and transactionid='" & txtinvoiceid.Text & "' and descriptions='" & description & "' and type='" & type & "' and class='" & clas & "' and roll='" & roll & "'"
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
            cmd.CommandText = "select customeraddress,customeremail,customername,customerphone,invoiceno,invoicedate,taxrate,glsalesaccount,duedate,invoicenote,paid from SalesInvoice where invoiceno='" & invoiceid & "' and invoicedate='" & invoicedate & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read Then
                txtaddress.Text = dr("customeraddress").ToString()
                txtemail.Text = dr("customeremail").ToString()
                txtname.Text = dr("customername").ToString()
                txtphone.Text = dr("customerphone").ToString()
                txtinvoiceid.Text = dr("invoiceno").ToString()
                cmbdate.Text = dr("invoicedate").ToString()
                txttaxrate.Text = dr("taxrate").ToString()
                cmbduedate.Text = dr("duedate").ToString()
                If dr("paid").ToString() = "Yes" Then
                    chkpaid.Checked = True
                Else
                    chkpaid.Checked = False
                End If
                InvoicePaid = dr("paid").ToString()
                PurchaseNote = dr("invoicenote").ToString()
            End If
            dr.Close()
            dgviewtotal.Rows.Clear()
            dgviewtotal.Rows.Add()
            dgviewtotal.Rows.Add()
            dgviewtotal.Rows.Add()
            dgviewinvoice.Rows.Clear()
            i = 0
            cmd.CommandText = "select itemid,itemname,itemclass,qnty,unit,itemprice,itemtax,itemamount,totalprice,totaltax,totalamount from SalesInvoice where invoiceno='" & invoiceid & "' and invoicedate='" & invoicedate & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewinvoice.Rows.Add()
                dgviewinvoice.Rows(i).Cells(0).Value = dr("itemid").ToString()
                dgviewinvoice.Rows(i).Cells(1).Value = dr("itemname").ToString()
                dgviewinvoice.Rows(i).Cells(2).Value = dr("itemclass").ToString()
                dgviewinvoice.Rows(i).Cells(3).Value = dr("qnty").ToString()
                dgviewinvoice.Rows(i).Cells(4).Value = dr("unit").ToString()
                dgviewinvoice.Rows(i).Cells(5).Value = dr("itemprice").ToString()
                dgviewinvoice.Rows(i).Cells(6).Value = dr("itemtax").ToString()
                dgviewinvoice.Rows(i).Cells(7).Value = dr("itemamount").ToString()
                i = i + 1
                Dim price As Decimal = CDec(dr("totalprice").ToString())
                Dim tr As Decimal = CDec(dr("totaltax").ToString())
                Dim amount As Decimal = CDec(dr("totalamount").ToString())
                InvoiceAmount = CDec(dr("totalamount").ToString())
                dgviewtotal.Rows(0).Cells(7).Value = "Total Price:"
                dgviewtotal.Rows(0).Cells(8).Value = FormatNumber(price).ToString()
                dgviewtotal.Rows(1).Cells(7).Value = "Total Tax:"
                dgviewtotal.Rows(1).Cells(8).Value = FormatNumber(tr).ToString()
                dgviewtotal.Rows(2).Cells(7).Value = "Total Amount:"
                dgviewtotal.Rows(2).Cells(8).Value = FormatNumber(amount).ToString()
            End While
            dr.Close()
            dgviewinvoice.ClearSelection()
            dgviewtotal.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CheckInvoiceNo()
        Try
            cmd.CommandText = "select * from SalesInvoice where invoiceno='" & txtinvoiceid.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                InvoiceExist = True
            Else
                InvoiceExist = False
            End If
            dr.Close()
        Catch ex As Exception
            InvoiceExist = False
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmSalesInvoice_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updateinvoice = False Then
            ControlSetBound()
            lblaccount.Text = "Sales Invoice Account: " + ISDSalesInvoiceAccount
            LoadItem()
            cmbdate.Text = UmbrellaSystemDate
            cmbduedate.Text = UmbrellaSystemDate
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            lblaccount.Text = "Sales Invoice Account: " + ISDSalesInvoiceAccount
            LoadItem()
            LoadSelectedRecord()
        End If
        If USsalesinvoice = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbdate.Enabled = False
            cmbduedate.Enabled = False
            cmbitemname.Enabled = False
            cmbunit.Enabled = False
            txtaddress.ReadOnly = True
            txtemail.ReadOnly = True
            txtinvoiceid.ReadOnly = True
            txtname.ReadOnly = True
            txtphone.ReadOnly = True
            txtprice.ReadOnly = True
            txtqnty.ReadOnly = True
            txttaxrate.ReadOnly = True
            dgviewinvoice.Enabled = False
            dgviewtotal.Enabled = False
            chkpaid.Enabled = False
        End If
    End Sub
#End Region
#Region "ContextMenuStrip Events..."
    Private Sub ModifyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyToolStripMenuItem.Click
        Dim row As Integer = dgviewinvoice.CurrentRow.Index
        cmbitemname.Text = dgviewinvoice.Rows(row).Cells(1).Value.ToString()
        txtqnty.Text = dgviewinvoice.Rows(row).Cells(3).Value.ToString()
        cmbunit.Text = dgviewinvoice.Rows(row).Cells(4).Value.ToString()
        txtprice.Text = dgviewinvoice.Rows(row).Cells(5).Value.ToString()
        Modify = True
        ModifyIndex = row
        LoadItemUnit(dgviewinvoice.Rows(row).Cells(0).Value.ToString())
        LoadItemUnitPrice(dgviewinvoice.Rows(row).Cells(0).Value.ToString())
        cmbitemname.Focus()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim row As Integer = dgviewinvoice.CurrentRow.Index
        dgviewinvoice.Rows.RemoveAt(row)
        i = i - 1
        TotalAmount()
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updateinvoice = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updateinvoice = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updateinvoice = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updateinvoice = False Then
            ControlSetBound()
            lblaccount.Text = "Sales Invoice Account: " + ISDSalesInvoiceAccount
            LoadItem()
            cmbdate.Text = UmbrellaSystemDate
            cmbduedate.Text = UmbrellaSystemDate
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            lblaccount.Text = "Sales Invoice Account: " + ISDSalesInvoiceAccount
            LoadItem()
            LoadSelectedRecord()
        End If
    End Sub

    Private Sub btnnote_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnote.ClickButtonArea
        invoiceid = txtinvoiceid.Text
        Dim frm As New frmSalesInvoiceNote()
        frm.ShowDialog()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Attributes..."
    Private Sub txtname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtaddress.Focus()
        End If
    End Sub

    Private Sub txtaddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtaddress.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtphone.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtname.Focus()
        End If
    End Sub

    Private Sub txtphone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtphone.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtemail.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtaddress.Focus()
        End If
    End Sub

    Private Sub txtemail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtemail.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtinvoiceid.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtphone.Focus()
        End If
    End Sub

    Private Sub txtinvoiceid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtinvoiceid.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbdate.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtemail.Focus()
        End If
    End Sub

    Private Sub cmbdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbduedate.Focus()
        End If
    End Sub

    Private Sub cmbduedate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbduedate.KeyDown
        If e.KeyCode = Keys.Enter Then
            txttaxrate.Focus()
        End If
    End Sub

    Private Sub txttaxrate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttaxrate.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbitemname.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbduedate.Focus()
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

    Private Sub TextBoxTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtaddress.TextChanged, txtname.TextChanged
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
End Class
#End Region