#Region "Class cClosingMembership..."
Public Class cClosingMembership
#Region "Declarations..."
    Public AddRecordOk As Boolean = False
    Public UpdateRecordOk As Boolean = False
    Public DeleteRecordOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal regno As String, ByVal name As String, ByVal closingbal As Decimal, ByVal outstanding As Decimal, ByVal closingdate As String)
        Try
            cmd.CommandText = "insert into CloseMembership(InsID,InsName,Period,regno,name,closingbal,outstanding,closingdate) values ('" & InsID & "','" & InsName & "','" & Periodd & "','" & regno & "','" & name & "'," & closingbal & "," & outstanding & ",'" & closingdate & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            AddRecordOk = True
        Catch ex As Exception
            AddRecordOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal regno As String, ByVal name As String, ByVal closingbal As Decimal, ByVal outstanding As Decimal, ByVal closingdate As String)
        Try
            cmd.CommandText = "update CloseMembership set closingbal=" & closingbal & ",outstanding=" & outstanding & ",closingdate='" & closingdate & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and regno='" & regno & "' and name='" & name & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateRecordOk = True
        Catch ex As Exception
            UpdateRecordOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal regno As String, ByVal name As String)
        Try
            cmd.CommandText = "delete from CloseMembership where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and regno='" & regno & "' and name='" & name & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteRecordOk = True
        Catch ex As Exception
            DeleteRecordOk = False
            dr.Close()
        End Try
    End Sub
#End Region
End Class
#End Region