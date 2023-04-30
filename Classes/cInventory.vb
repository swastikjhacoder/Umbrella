#Region "Class cInventory..."
Public Class cInventory
#Region "Declarations..."
    Public AddItemPriceLevel As Boolean = False
    Public UpdateItemPriceLevel As Boolean = False
    Public AddItemOk As Boolean = False
    Public UpdateItemOk As Boolean = False
    Public DeleteItemOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddInventoryItemPriceLevel(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal SystemDate As String, ByVal itemid As String, ByVal itemname As String, ByVal itemdesc As String, ByVal levelprice1 As Decimal, ByVal levelprice2 As Decimal, ByVal levelprice3 As Decimal, ByVal levelprice4 As Decimal, ByVal levelprice5 As Decimal, ByVal levelprice6 As Decimal, ByVal levelprice7 As Decimal, ByVal levelprice8 As Decimal, ByVal levelprice9 As Decimal, ByVal levelprice10 As Decimal, ByVal defaultlevel As String)
        Try
            cmd.CommandText = "insert into InventoryItemPriceLevel(InsID,InsName,Period,SystemDate,itemid,itemname,itemdesc,levelprice1,levelprice2,levelprice3,levelprice4,levelprice5,levelprice6,levelprice7,levelprice8,levelprice9,levelprice10,defaultlevel) values ('" & InsID & "','" & InsName & "','" & Period & "','" & SystemDate & "','" & itemid & "','" & itemname & "','" & itemdesc & "'," & levelprice1 & "," & levelprice2 & "," & levelprice3 & "," & levelprice4 & "," & levelprice5 & "," & levelprice6 & "," & levelprice7 & "," & levelprice8 & "," & levelprice9 & "," & levelprice10 & ",'" & defaultlevel & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            AddItemPriceLevel = True
        Catch ex As Exception
            AddItemPriceLevel = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateInventoryItemPriceLevel(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal SystemDate As String, ByVal itemid As String, ByVal itemname As String, ByVal itemdesc As String, ByVal levelprice1 As Decimal, ByVal levelprice2 As Decimal, ByVal levelprice3 As Decimal, ByVal levelprice4 As Decimal, ByVal levelprice5 As Decimal, ByVal levelprice6 As Decimal, ByVal levelprice7 As Decimal, ByVal levelprice8 As Decimal, ByVal levelprice9 As Decimal, ByVal levelprice10 As Decimal, ByVal defaultlevel As String)
        Try
            cmd.CommandText = "update InventoryItemPriceLevel set SystemDate='" & SystemDate & "',levelprice1=" & levelprice1 & ",levelprice2=" & levelprice2 & ",levelprice3=" & levelprice3 & ",levelprice4=" & levelprice4 & ",levelprice5=" & levelprice5 & ",levelprice6=" & levelprice6 & ",levelprice7=" & levelprice7 & ",levelprice8=" & levelprice8 & ",levelprice9=" & levelprice9 & ",levelprice10=" & levelprice10 & ",defaultlevel='" & defaultlevel & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Period & "' and SystemDate='" & SystemDate & "' and itemid='" & itemid & "' and itemname='" & itemname & "' and itemdesc='" & itemdesc & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateItemPriceLevel = True
        Catch ex As Exception
            UpdateItemPriceLevel = False
            dr.Close()
        End Try
    End Sub

    Public Sub AddInventoryItem(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal itemid As String, ByVal itemnote As String, ByVal itemname As String, ByVal itemclass As String, ByVal descshort As String, ByVal itemsize As String, ByVal itemshape As String, ByVal itemused As String, ByVal descripbrief As String, ByVal levelprice As Decimal, ByVal onhandqnty As Decimal, ByVal onhandqntyunit As String, ByVal lastsoldprice As Decimal, ByVal costmethod As String, ByVal minstockqnty As Decimal, ByVal minstockqntyunit As String, ByVal itemtaxtype As String, ByVal itemtype As String, ByVal stocking As String, ByVal weight As Decimal, ByVal weightunit As String, ByVal vendorname As String, ByVal glsalesaccountid As String, ByVal glinventoryaccountid As String, ByVal glcostsaccountid As String, ByVal costingaccountid As String, ByVal customfield1 As String, ByVal customfield2 As String, ByVal customfield3 As String, ByVal customfield4 As String, ByVal customfield5 As String, ByVal inactive As String, ByVal commission As String, ByVal UnitPrice As Decimal)
        Try
            cmd.CommandText = "insert into Inventory(InsID,InsName,Period,SystemDate,itemid,itemnote,itemname,itemclass,descshort,itemsize,itemshape,itemused,descripbrief,levelprice,onhandqnty,onhandqntyunit,lastsoldprice,costmethod,minstockqnty,minstockqntyunit,itemtaxtype,itemtype,stocking,weight,weightunit,vendorname,glsalesaccountid,glinventoryaccountid,glcostsaccountid,costingaccountid,customfield1,customfield2,customfield3,customfield4,customfield5,inactive,commission,UnitPrice) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & itemid & "','" & itemnote & "','" & itemname & "','" & itemclass & "','" & descshort & "','" & itemsize & "','" & itemshape & "','" & itemused & "','" & descripbrief & "'," & levelprice & "," & onhandqnty & ",'" & onhandqntyunit & "'," & lastsoldprice & ",'" & costmethod & "'," & minstockqnty & ",'" & minstockqntyunit & "','" & itemtaxtype & "','" & itemtype & "','" & stocking & "'," & weight & ",'" & weightunit & "','" & vendorname & "','" & glsalesaccountid & "','" & glinventoryaccountid & "','" & glcostsaccountid & "','" & costingaccountid & "','" & customfield1 & "','" & customfield2 & "','" & customfield3 & "','" & customfield4 & "','" & customfield5 & "','" & inactive & "','" & commission & "'," & UnitPrice & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set inventoryid=inventoryid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddItemOk = True
        Catch ex As Exception
            AddItemOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateInventoryItem(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal itemid As String, ByVal itemnote As String, ByVal itemname As String, ByVal itemclass As String, ByVal descshort As String, ByVal itemsize As String, ByVal itemshape As String, ByVal itemused As String, ByVal descripbrief As String, ByVal levelprice As Decimal, ByVal onhandqnty As Decimal, ByVal onhandqntyunit As String, ByVal lastsoldprice As Decimal, ByVal costmethod As String, ByVal minstockqnty As Decimal, ByVal minstockqntyunit As String, ByVal itemtaxtype As String, ByVal itemtype As String, ByVal stocking As String, ByVal weight As Decimal, ByVal weightunit As String, ByVal vendorname As String, ByVal glsalesaccountid As String, ByVal glinventoryaccountid As String, ByVal glcostsaccountid As String, ByVal costingaccountid As String, ByVal customfield1 As String, ByVal customfield2 As String, ByVal customfield3 As String, ByVal customfield4 As String, ByVal customfield5 As String, ByVal inactive As String, ByVal commission As String, ByVal UnitPrice As Decimal)
        Try
            cmd.CommandText = "update Inventory set SystemDate='" & SystemDate & "',itemnote='" & itemnote & "',itemclass='" & itemclass & "',descshort='" & descshort & "',itemsize='" & itemsize & "',itemshape='" & itemshape & "',itemused='" & itemused & "',descripbrief='" & descripbrief & "',levelprice=" & levelprice & ",onhandqnty=" & onhandqnty & ",onhandqntyunit='" & onhandqntyunit & "',lastsoldprice=" & lastsoldprice & ",costmethod='" & costmethod & "',minstockqnty=" & minstockqnty & ",minstockqntyunit='" & minstockqntyunit & "',itemtaxtype='" & itemtaxtype & "',itemtype='" & itemtype & "',stocking='" & stocking & "',weight=" & weight & ",weightunit='" & weightunit & "',vendorname='" & vendorname & "',glsalesaccountid='" & glsalesaccountid & "',glinventoryaccountid='" & glinventoryaccountid & "',glcostsaccountid='" & glcostsaccountid & "',costingaccountid='" & costingaccountid & "',customfield1='" & customfield1 & "',customfield2='" & customfield2 & "',customfield3='" & customfield3 & "',customfield4='" & customfield4 & "',customfield5='" & customfield5 & "',inactive='" & inactive & "',commission='" & commission & "',UnitPrice=" & UnitPrice & " where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and itemid='" & itemid & "' and itemname='" & itemname & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateItemOk = True
        Catch ex As Exception
            UpdateItemOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteInventoryItem(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal itemid As String, ByVal itemname As String)
        Try
            cmd.CommandText = "delete from Inventory where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and itemid='" & itemid & "' and itemname='" & itemname & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "delete from InventoryItemPriceLevel where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & period & "' and itemid='" & itemid & "' and itemname='" & itemname & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteItemOk = True
        Catch ex As Exception
            DeleteItemOk = False
            dr.Close()
        End Try
    End Sub
#End Region
End Class
#End Region