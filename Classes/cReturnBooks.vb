#Region "Class cReturnBooks..."
Public Class cReturnBooks
#Region "Declarations..."
    Public AddReturnOk As Boolean = False
    Public ReturnBookOk As Boolean = False
    Public DeleteReturnBookOk As Boolean = False
    Public UpdateReturnOk As Boolean = False
    Public DeleteReturnOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal issueid As String, ByVal dates As String, ByVal issuedate As String, ByVal returndate As String, ByVal applylatecharge As String, ByVal regno As String, ByVal name As String)
        Try
            Dim returned As String = "Yes"
            cmd.CommandText = "insert into ReturnBooks(InsID,InsName,Period,SystemDate,issueid,date,issuedate,returndate,applylatecharge,regno,name) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & SystemDate & "','" & issueid & "','" & dates & "','" & issuedate & "','" & returndate & "','" & applylatecharge & "','" & regno & "','" & name & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Issue set returned='" & returned & "' where issueid='" & issueid & "' and issuedate='" & issuedate & "' and issuedtoid='" & regno & "' and issuedtoname='" & name & "' and InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddReturnOk = True
        Catch ex As Exception
            AddReturnOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub AddReturnBooks(ByVal bookid As String, ByVal bookname As String, ByVal author As String, ByVal edition As String)
        Try
            cmd.CommandText = "update Books set copies=copies+1 where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and bookid='" & bookid & "' and bookname='" & bookname & "' and author='" & author & "' and edition='" & edition & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            ReturnBookOk = True
        Catch ex As Exception
            ReturnBookOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal issueid As String, ByVal dates As String, ByVal issuedate As String, ByVal returndate As String, ByVal applylatecharge As String, ByVal regno As String, ByVal name As String)
        Try
            Dim returned As String = "Yes"
            cmd.CommandText = "update ReturnBooks set SystemDate='" & SystemDate & "',date='" & dates & "',applylatecharge='" & applylatecharge & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and issueid='" & issueid & "' and issuedate='" & issuedate & "' and returndate='" & returndate & "' and regno='" & regno & "' and name='" & name & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Issue set returned='" & returned & "' where issueid='" & issueid & "' and issuedate='" & issuedate & "' and issuedtoid='" & regno & "' and issuedtoname='" & name & "' and InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateReturnOk = True
        Catch ex As Exception
            dr.Close()
            UpdateReturnOk = False
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal SystemDate As String, ByVal issueid As String, ByVal issuedate As String, ByVal returndate As String, ByVal regno As String, ByVal name As String)
        Try
            Dim returned As String = "No"
            cmd.CommandText = "delete from ReturnBooks where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and issueid='" & issueid & "' and issuedate='" & issuedate & "' and returndate='" & returndate & "' and regno='" & regno & "' and name='" & name & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            cmd.CommandText = "update Issue set returned='" & returned & "' where issueid='" & issueid & "' and issuedate='" & issuedate & "' and issuedtoid='" & regno & "' and issuedtoname='" & name & "' and InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteReturnOk = True
        Catch ex As Exception
            dr.Close()
            DeleteReturnOk = False
        End Try
    End Sub

    Public Sub DeleteReturn(ByVal bookid As String, ByVal bookname As String, ByVal author As String, ByVal edition As String)
        Try
            cmd.CommandText = "update Books set copies=copies-1 where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and bookid='" & bookid & "' and bookname='" & bookname & "' and author='" & author & "' and edition='" & edition & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteReturnBookOk = True
        Catch ex As Exception
            dr.Close()
            DeleteReturnBookOk = False
        End Try
    End Sub
#End Region
End Class
#End Region