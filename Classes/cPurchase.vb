#Region "Class cPurchase..."
Public Class cPurchase
#Region "Declarations..."
    Public AddRecordOk As Boolean = False
    Public DeleteRecordOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal purchaseid As String, ByVal purchasedate As String, ByVal vendorname As String, ByVal vendoraddress As String, ByVal vendorphone As String, ByVal vendoremail As String, ByVal shipto As String, ByVal shipaddress As String, ByVal shipphone As String, ByVal shipemail As String, ByVal expenseaccount As String, ByVal taxrate As Decimal, ByVal itemid As String, ByVal itemname As String, ByVal itemclass As String, ByVal itemqnty As Decimal, ByVal itemunit As String, ByVal itemprice As Decimal, ByVal itemtax As Decimal, ByVal itemtotal As Decimal, ByVal totalprice As Decimal, ByVal totaltax As Decimal, ByVal totalamount As Decimal, ByVal purchasenote As String, ByVal duedate As String, ByVal paid As String)
        Try
            cmd.CommandText = "insert into Purchase(InsID,InsName,Period,SystemDate,purchaseid,purchasedate,vendorname,vendoraddress,vendorphone,vendoremail,shipto,shipaddress,shipphone,shipemail,expenseaccount,taxrate,itemid,itemname,itemclass,itemqnty,itemunit,itemprice,itemtax,itemtotal,totalprice,totaltax,totalamount,purchasenote,duedate,paid) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & purchaseid & "','" & purchasedate & "','" & vendorname & "','" & vendoraddress & "','" & vendorphone & "','" & vendoremail & "','" & shipto & "','" & shipaddress & "','" & shipphone & "','" & shipemail & "','" & expenseaccount & "'," & taxrate & ",'" & itemid & "','" & itemname & "','" & itemclass & "'," & itemqnty & ",'" & itemunit & "'," & itemprice & "," & itemtax & "," & itemtotal & "," & totalprice & "," & totaltax & "," & totalamount & ",'" & purchasenote & "','" & duedate & "','" & paid & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Inventory set onhandqnty=onhandqnty+" & itemqnty & ",onhandqntyunit='" & itemunit & "' where itemid='" & itemid & "' and itemname='" & itemname & "' and InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddRecordOk = True
        Catch ex As Exception
            dr.Close()
            AddRecordOk = False
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal purchaseid As String, ByVal purchasedate As String, ByVal itemid As String, ByVal itemname As String, ByVal itemclass As String)
        Try
            cmd.CommandText = "select itemqnty from Purchase where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and purchaseid='" & purchaseid & "' and purchasedate='" & purchasedate & "' and itemid='" & itemid & "' and itemname='" & itemname & "' and itemclass='" & itemclass & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim purchasedqnty As Decimal = CDec(dr("itemqnty").ToString())
            dr.Close()
            cmd.CommandText = "delete from Purchase where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and purchaseid='" & purchaseid & "' and purchasedate='" & purchasedate & "' and itemid='" & itemid & "' and itemname='" & itemname & "' and itemclass='" & itemclass & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Inventory set onhandqnty=onhandqnty-" & purchasedqnty & " where itemid='" & itemid & "' and itemname='" & itemname & "' and InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteRecordOk = True
        Catch ex As Exception
            dr.Close()
            DeleteRecordOk = False
        End Try
    End Sub
#End Region
End Class
#End Region