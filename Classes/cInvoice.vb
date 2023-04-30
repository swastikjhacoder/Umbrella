#Region "Class cInvoice..."
Public Class cInvoice
#Region "Declarations..."
    Public AddRecordOk As Boolean = False
    Public DeleteRecordOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal invoiceno As String, ByVal invoicedate As String, ByVal customername As String, ByVal customeraddress As String, ByVal customerphone As String, ByVal customeremail As String, ByVal glsalesaccount As String, ByVal taxrate As Decimal, ByVal itemid As String, ByVal itemname As String, ByVal itemclass As String, ByVal qnty As Decimal, ByVal unit As String, ByVal itemprice As Decimal, ByVal itemtax As Decimal, ByVal itemamount As Decimal, ByVal totalprice As Decimal, ByVal totaltax As Decimal, ByVal totalamount As Decimal, ByVal invoicenote As String, ByVal duedate As String, ByVal paid As String)
        Try
            cmd.CommandText = "insert into SalesInvoice(InsID,InsName,Period,SystemDate,invoiceno,invoicedate,customername,customeraddress,customerphone,customeremail,glsalesaccount,taxrate,itemid,itemname,itemclass,qnty,unit,itemprice,itemtax,itemamount,totalprice,totaltax,totalamount,invoicenote,duedate,paid) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & invoiceno & "','" & invoicedate & "','" & customername & "','" & customeraddress & "','" & customerphone & "','" & customeremail & "','" & glsalesaccount & "'," & taxrate & ",'" & itemid & "','" & itemname & "','" & itemclass & "'," & qnty & ",'" & unit & "'," & itemprice & "," & itemtax & "," & itemamount & "," & totalprice & "," & totaltax & "," & totalamount & ",'" & invoicenote & "','" & duedate & "','" & paid & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Inventory set onhandqnty=onhandqnty-" & qnty & " where itemid='" & itemid & "' and itemname='" & itemname & "' and InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddRecordOk = True
        Catch ex As Exception
            dr.Close()
            AddRecordOk = False
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal invoiceno As String, ByVal invoicedate As String, ByVal itemid As String, ByVal itemname As String, ByVal itemclass As String)
        Try
            cmd.CommandText = "select qnty from SalesInvoice where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and invoiceno='" & invoiceno & "' and invoicedate='" & invoicedate & "' and itemid='" & itemid & "' and itemname='" & itemname & "' and itemclass='" & itemclass & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim invoicedqnty As Decimal = CDec(dr("qnty").ToString())
            dr.Close()
            cmd.CommandText = "delete from SalesInvoice where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and invoiceno='" & invoiceno & "' and invoicedate='" & invoicedate & "' and itemid='" & itemid & "' and itemname='" & itemname & "' and itemclass='" & itemclass & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Inventory set onhandqnty=onhandqnty+" & invoicedqnty & " where itemid='" & itemid & "' and itemname='" & itemname & "' and InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "'"
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
