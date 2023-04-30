#Region "Class cIssueBooks..."
Public Class cIssueBooks
#Region "Declarations..."
    Public AddIssueOk As Boolean = False
    Public UpdateIssueOk As Boolean = False
    Public DeleteIssueOk As Boolean = False
    Public AddIssueBooksOk As Boolean = False
    Public UpdateIssueBooksOk As Boolean = False
    Public DeleteIssueBooksOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddIssue(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal issedto As String, ByVal issuedtoname As String, ByVal issuedtoid As String, ByVal contactno As String, ByVal email As String, ByVal issueid As String, ByVal issuedate As String, ByVal duedate As String, ByVal issedby As String)
        Try
            Dim returned As String = "No"
            cmd.CommandText = "insert into Issue(InsID,InsName,Period,SystemDate,issedto,issuedtoname,issuedtoid,contactno,email,issueid,issuedate,duedate,issedby,returned) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & issedto & "','" & issuedtoname & "','" & issuedtoid & "','" & contactno & "','" & email & "','" & issueid & "','" & issuedate & "','" & duedate & "','" & issedby & "','" & returned & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Indexx set issueid=issueid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddIssueOk = True
        Catch ex As Exception
            dr.Close()
            AddIssueOk = False
        End Try
    End Sub

    Public Sub AddIssueBooks(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal issueid As String, ByVal issuedtoid As String, ByVal issuedate As String, ByVal bookname As String, ByVal bookid As String, ByVal author As String, ByVal edition As String)
        Try
            cmd.CommandText = "insert into IssueBooks(InsID,InsName,Period,SystemDate,issueid,issuedtoid,issuedate,bookname,bookid,author,edition) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & issueid & "','" & issuedtoid & "','" & issuedate & "','" & bookname & "','" & bookid & "','" & author & "','" & edition & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Books set copies=copies-1 where bookid='" & bookid & "' and bookname='" & bookname & "' and author='" & author & "' and edition='" & edition & "' and InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddIssueBooksOk = True
        Catch ex As Exception
            dr.Close()
            AddIssueBooksOk = False
        End Try
    End Sub

    Public Sub UpdateIssue(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal issedto As String, ByVal issuedtoname As String, ByVal issuedtoid As String, ByVal contactno As String, ByVal email As String, ByVal issueid As String, ByVal issuedate As String, ByVal duedate As String, ByVal issedby As String)
        Try
            Dim returned As String = "No"
            cmd.CommandText = "update Issue set SystemDate='" & SystemDate & "',issedto='" & issedto & "',issuedtoname='" & issuedtoname & "',issuedtoid='" & issuedtoid & "',contactno='" & contactno & "',email='" & email & "',issuedate='" & issuedate & "',duedate='" & duedate & "',issedby='" & issedby & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and issueid='" & issueid & "' and returned='" & returned & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateIssueOk = True
        Catch ex As Exception
            dr.Close()
            UpdateIssueOk = False
        End Try
    End Sub

    Public Sub DeleteIssue(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal issueid As String)
        Try
            Dim returned As String = "No"
            cmd.CommandText = "delete from Issue where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and issueid='" & issueid & "' and returned='" & returned & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteIssueOk = True
        Catch ex As Exception
            dr.Close()
            DeleteIssueOk = False
        End Try
    End Sub

    Public Sub DeleteIssueBooks(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal issueid As String)
        Try
            cmd.CommandText = "delete from IssueBooks where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and issueid='" & issueid & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteIssueBooksOk = True
        Catch ex As Exception
            dr.Close()
            DeleteIssueBooksOk = False
        End Try
    End Sub
#End Region
End Class
#End Region