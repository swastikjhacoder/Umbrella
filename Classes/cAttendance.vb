#Region "Class cAttendance..."
Public Class cAttendance
#Region "Declarations..."
    Public SaveOk As Boolean = False
    Public UpdateOk As Boolean = False
    Public DeleteOk As Boolean = False
    Public SaveStuOk As Boolean = False
    Public UpdateStuOk As Boolean = False
    Public DeleteStuOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub SaveEmployeeAttendace(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal name As String, ByVal day1name As String, ByVal day1atten As String, ByVal day2name As String, ByVal day2atten As String, ByVal day3name As String, ByVal day3atten As String, ByVal day4name As String, ByVal day4atten As String, ByVal day5name As String, ByVal day5atten As String, ByVal day6name As String, ByVal day6atten As String, ByVal day7name As String, ByVal day7atten As String)
        Try
            cmd.CommandText = "insert into EmployeeAttendance(InsID,InsName,Period,SystemDate,empid,name,day1name,day1atten,day2name,day2atten,day3name,day3atten,day4name,day4atten,day5name,day5atten,day6name,day6atten,day7name,day7atten) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & SystemDate & "','" & empid & "','" & name & "','" & day1name & "','" & day1atten & "','" & day2name & "','" & day2atten & "','" & day3name & "','" & day3atten & "','" & day4name & "','" & day4atten & "','" & day5name & "','" & day5atten & "','" & day6name & "','" & day6atten & "','" & day7name & "','" & day7atten & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            SaveOk = True
        Catch ex As Exception
            dr.Close()
            SaveOk = False
        End Try
    End Sub

    Public Sub UpdateEmployeeAttendace(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal name As String, ByVal day1name As String, ByVal day1atten As String, ByVal day2name As String, ByVal day2atten As String, ByVal day3name As String, ByVal day3atten As String, ByVal day4name As String, ByVal day4atten As String, ByVal day5name As String, ByVal day5atten As String, ByVal day6name As String, ByVal day6atten As String, ByVal day7name As String, ByVal day7atten As String)
        Try
            cmd.CommandText = "update EmployeeAttendance set SystemDate='" & SystemDate & "',day1atten='" & day1atten & "',day2name='" & day2name & "',day2atten='" & day2atten & "',day3name='" & day3name & "',day3atten='" & day3atten & "',day4name='" & day4name & "',day4atten='" & day4atten & "',day5name='" & day5name & "',day5atten='" & day5atten & "',day6name='" & day6name & "',day6atten='" & day6atten & "',day7name='" & day7name & "',day7atten='" & day7atten & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & periodd & "' and day1name='" & day1name & "' and empid='" & empid & "' and name='" & name & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateOk = True
        Catch ex As Exception
            dr.Close()
            UpdateOk = False
        End Try
    End Sub

    Public Sub DeleteEmployeeAttendace(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal day1name As String)
        Try
            cmd.CommandText = "delete from EmployeeAttendance where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & periodd & "' and day1name='" & day1name & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteOk = True
        Catch ex As Exception
            dr.Close()
            DeleteOk = False
        End Try
    End Sub

    Public Sub SaveStudentAttendace(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal name As String, ByVal day1name As String, ByVal day1atten As String, ByVal day2name As String, ByVal day2atten As String, ByVal day3name As String, ByVal day3atten As String, ByVal day4name As String, ByVal day4atten As String, ByVal day5name As String, ByVal day5atten As String, ByVal day6name As String, ByVal day6atten As String, ByVal day7name As String, ByVal day7atten As String)
        Try
            cmd.CommandText = "insert into StudentAttendance(InsID,InsName,Period,SystemDate,stuid,name,day1name,day1atten,day2name,day2atten,day3name,day3atten,day4name,day4atten,day5name,day5atten,day6name,day6atten,day7name,day7atten) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & SystemDate & "','" & empid & "','" & name & "','" & day1name & "','" & day1atten & "','" & day2name & "','" & day2atten & "','" & day3name & "','" & day3atten & "','" & day4name & "','" & day4atten & "','" & day5name & "','" & day5atten & "','" & day6name & "','" & day6atten & "','" & day7name & "','" & day7atten & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            SaveStuOk = True
        Catch ex As Exception
            dr.Close()
            SaveStuOk = False
        End Try
    End Sub

    Public Sub UpdateStudentAttendace(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal empid As String, ByVal name As String, ByVal day1name As String, ByVal day1atten As String, ByVal day2name As String, ByVal day2atten As String, ByVal day3name As String, ByVal day3atten As String, ByVal day4name As String, ByVal day4atten As String, ByVal day5name As String, ByVal day5atten As String, ByVal day6name As String, ByVal day6atten As String, ByVal day7name As String, ByVal day7atten As String)
        Try
            cmd.CommandText = "update StudentAttendance set SystemDate='" & SystemDate & "',day1atten='" & day1atten & "',day2name='" & day2name & "',day2atten='" & day2atten & "',day3name='" & day3name & "',day3atten='" & day3atten & "',day4name='" & day4name & "',day4atten='" & day4atten & "',day5name='" & day5name & "',day5atten='" & day5atten & "',day6name='" & day6name & "',day6atten='" & day6atten & "',day7name='" & day7name & "',day7atten='" & day7atten & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & periodd & "' and day1name='" & day1name & "' and stuid='" & empid & "' and name='" & name & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateStuOk = True
        Catch ex As Exception
            dr.Close()
            UpdateStuOk = False
        End Try
    End Sub

    Public Sub DeleteStudentAttendace(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal SystemDate As String, ByVal day1name As String)
        Try
            cmd.CommandText = "delete from StudentAttendance where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & periodd & "' and day1name='" & day1name & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteStuOk = True
        Catch ex As Exception
            dr.Close()
            DeleteStuOk = False
        End Try
    End Sub
#End Region
End Class
#End Region