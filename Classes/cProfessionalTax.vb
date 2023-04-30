#Region "Class cProfessionalTax..."
Public Class cProfessionalTax
#Region "Declarations..."
    Public AddRecordOk As Boolean = False
    Public UpdateRecordOk As Boolean = False
    Public DeleteRecordOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal gross As Decimal, ByVal taxrate As Decimal)
        Try
            cmd.CommandText = "insert into ProfessionalTax(InsID,InsName,Period,gross,taxrate) values ('" & InsID & "','" & InsName & "','" & Periodd & "'," & gross & "," & taxrate & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            AddRecordOk = True
        Catch ex As Exception
            dr.Close()
            AddRecordOk = False
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal gross As Decimal, ByVal taxrate As Decimal, ByVal oldgross As Decimal, ByVal oldtaxrate As Decimal)
        Try
            cmd.CommandText = "update ProfessionalTax set gross=" & gross & ",taxrate=" & taxrate & " where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and gross=" & oldgross & " and taxrate=" & oldtaxrate & ""
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateRecordOk = True
        Catch ex As Exception
            dr.Close()
            UpdateRecordOk = False
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal Periodd As String, ByVal oldgross As Decimal, ByVal oldtaxrate As Decimal)
        Try
            cmd.CommandText = "delete from ProfessionalTax where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Periodd & "' and gross=" & oldgross & " and taxrate=" & oldtaxrate & ""
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