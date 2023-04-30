#Region "Class cSyllabus..."
Public Class cSyllabus
#Region "Declarations..."
    Public AddOk As Boolean = False
    Public UpdateOk As Boolean = False
    Public DeleteOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal course As String, ByVal coursecode As String, ByVal subject As String, ByVal subjectcode As String, ByVal forstudent As String, ByVal chapter As String, ByVal chapterdetails As String, ByVal totalmarks As Integer, ByVal marksobtained As Integer, ByVal totalclass As Integer, ByVal classes As Integer)
        Try
            cmd.CommandText = "insert into Syllabus(InsID,InsName,Period,SystemDate,course,coursecode,subject,subjectcode,forstudent,chapter,chapterdetails,totalmarks,marksobtained,totalclass,class) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & SystemDate & "','" & course & "','" & coursecode & "','" & subject & "','" & subjectcode & "','" & forstudent & "','" & chapter & "','" & chapterdetails & "'," & totalmarks & "," & marksobtained & "," & totalclass & "," & classes & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            AddOk = True
        Catch ex As Exception
            AddOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal course As String, ByVal subject As String, ByVal forstudent As String, ByVal chapter As String, ByVal chapterdetails As String, ByVal totalmarks As Integer, ByVal marksobtained As Integer, ByVal totalclass As Integer, ByVal classes As Integer)
        Try
            cmd.CommandText = "update Syllabus set SystemDate='" & SystemDate & "',forstudent='" & forstudent & "',chapter='" & chapter & "',chapterdetails='" & chapterdetails & "',totalmarks=" & totalmarks & ",marksobtained=" & marksobtained & ",totalclass=" & totalclass & ",class=" & classes & " where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & periodd & "' and course='" & course & "' and subject='" & subject & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateOk = True
        Catch ex As Exception
            UpdateOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal course As String, ByVal subject As String)
        Try
            cmd.CommandText = "delete from Syllabus where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & periodd & "' and course='" & course & "' and subject='" & subject & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteOk = True
        Catch ex As Exception
            DeleteOk = False
            dr.Close()
        End Try
    End Sub
#End Region
End Class
#End Region