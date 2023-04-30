#Region "Class cBook..."
Public Class cBook
#Region "Declarations"
    Public AddBookOk As Boolean = False
    Public UpdateBookOk As Boolean = False
    Public DeleteBookOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal bookid As String, ByVal bookname As String, ByVal groupname As String, ByVal subject As String, ByVal publisher As String, ByVal author As String, ByVal edition As String, ByVal copies As Integer, ByVal pages As Integer, ByVal price As Decimal, ByVal particulars As String)
        Try
            cmd.CommandText = "insert into Books(InsID,InsName,Period,SystemDate,bookid,bookname,groupname,subject,publisher,author,edition,copies,pages,price,particulars) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & bookid & "','" & bookname & "','" & groupname & "','" & subject & "','" & publisher & "','" & author & "','" & edition & "'," & copies & "," & pages & "," & price & ",'" & particulars & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set bookid=bookid+1 where InsID='" & InsID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddBookOk = True
        Catch ex As Exception
            dr.Close()
            AddBookOk = False
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal bookid As String, ByVal bookname As String, ByVal groupname As String, ByVal subject As String, ByVal publisher As String, ByVal author As String, ByVal edition As String, ByVal copies As Integer, ByVal pages As Integer, ByVal price As Decimal, ByVal particulars As String)
        Try
            cmd.CommandText = "update Books set SystemDate='" & SystemDate & "',bookname='" & bookname & "',groupname='" & groupname & "',subject='" & subject & "',publisher='" & publisher & "',author='" & author & "',edition='" & edition & "',copies=" & copies & ",pages=" & pages & ",price=" & price & ",particulars='" & particulars & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and bookid='" & bookid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateBookOk = True
        Catch ex As Exception
            dr.Close()
            UpdateBookOk = False
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal bookid As String)
        Try
            cmd.CommandText = "delete from Books where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and bookid='" & bookid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteBookOk = True
        Catch ex As Exception
            dr.Close()
            DeleteBookOk = False
        End Try
    End Sub
#End Region
End Class
#End Region