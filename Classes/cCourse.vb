#Region "Class cCourse..."
Public Class cCourse
#Region "Declarations..."
    Public AddSubjectOk As Boolean = False
    Public UpdateSubjectOk As Boolean = False
    Public DeleteSubjectOk As Boolean = False
    Public UpdateCourseOk As Boolean = False
    Public AddFeesTermsOk As Boolean = False
    Public AddDiscountOk As Boolean = False
#End Region
#Region "Methods..."
    Public Sub AddRecord(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal course As String, ByVal coursecode As String, ByVal haspractical As String, ByVal gensubject As String, ByVal gensubjectduration As String, ByVal gensubjectcode As String, ByVal gensubjectyear As Integer, ByVal gensubjectsemestar As String, ByVal pracsubject As String, ByVal pracsubjectduration As String, ByVal pracsubjectcode As String, ByVal pracsubjectyear As Integer, ByVal pracsubjectsemestar As String)
        Try
            cmd.CommandText = "insert into Subjects(InsID,InsName,Period,course,coursecode,haspractical,gensubject,gensubjectduration,gensubjectcode,gensubjectyear,gensubjectsemestar,pracsubject,pracsubjectduration,pracsubjectcode,pracsubjectyear,pracsubjectsemestar) values ('" & InsID & "','" & InsName & "','" & periodd & "','" & course & "','" & coursecode & "','" & haspractical & "','" & gensubject & "','" & gensubjectduration & "','" & gensubjectcode & "'," & gensubjectyear & ",'" & gensubjectsemestar & "','" & pracsubject & "','" & pracsubjectduration & "','" & pracsubjectcode & "'," & pracsubjectyear & ",'" & pracsubjectsemestar & "')"
            dr = cmd.ExecuteReader
            dr.Close()
            AddSubjectOk = True
        Catch ex As Exception
            AddSubjectOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateRecord(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal course As String, ByVal coursecode As String, ByVal haspractical As String, ByVal gensubject As String, ByVal gensubjectduration As String, ByVal gensubjectcode As String, ByVal gensubjectyear As Integer, ByVal gensubjectsemestar As String, ByVal pracsubject As String, ByVal pracsubjectduration As String, ByVal pracsubjectcode As String, ByVal pracsubjectyear As Integer, ByVal pracsubjectsemestar As String)
        Try
            cmd.CommandText = "update Subjects set haspractical='" & haspractical & "',gensubject='" & gensubject & "',gensubjectduration='" & gensubjectduration & "',gensubjectyear=" & gensubjectyear & ",gensubjectsemestar='" & gensubjectsemestar & "',pracsubject='" & pracsubject & "',pracsubjectduration='" & pracsubjectduration & "',pracsubjectcode='" & pracsubjectcode & "',pracsubjectyear=" & pracsubjectyear & ",pracsubjectsemestar='" & pracsubjectsemestar & "' where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & periodd & "' and course='" & course & "' and gensubjectcode='" & gensubjectcode & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateSubjectOk = True
        Catch ex As Exception
            UpdateSubjectOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub DeleteRecord(ByVal InsID As String, ByVal InsName As String, ByVal periodd As String, ByVal course As String, ByVal coursecode As String, ByVal gensubjectcode As String)
        Try
            cmd.CommandText = "delete from Subjects where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & periodd & "' and course='" & course & "' and coursecode='" & coursecode & "' and gensubjectcode='" & gensubjectcode & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            DeleteSubjectOk = True
        Catch ex As Exception
            DeleteSubjectOk = False
            dr.Close()
        End Try
    End Sub

    Public Sub UpdateCourse(ByVal InsID As String, ByVal InsName As String, ByVal period As String, ByVal year As String, ByVal CourseName As String, ByVal CourseCode As String, ByVal CourseFees As Decimal)
        Try
            cmd.CommandText = "update Course set CourseFees=" & CourseFees & " where InsID='" & InsID & "' and InsName='" & InsName & "' and period='" & period & "' and year='" & year & "' and CourseName='" & CourseName & "' and CourseCode='" & CourseCode & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            UpdateCourseOk = True
        Catch ex As Exception
            UpdateCourseOk = False
        End Try
    End Sub

    Public Sub UpdateFeesTerms(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal year As String, ByVal Course As String, ByVal Terms As String, ByVal Fees As Decimal, ByVal ForMonth As Integer)
        Try
            cmd.CommandText = "update CourseTermFees set Fees=" & Fees & ",ForMonth=" & ForMonth & " where InsID='" & InsID & "' and InsName='" & InsName & "' and Period='" & Period & "' and year='" & year & "' and Course='" & Course & "' and Terms='" & Terms & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddFeesTermsOk = True
        Catch ex As Exception
            AddFeesTermsOk = False
        End Try
    End Sub

    Public Sub AddDiscount(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal year As String, ByVal course As String, ByVal stuid As String, ByVal name As String, ByVal discount As Decimal)
        Try
            cmd.CommandText = "insert into StudentDiscount(InsID,InsName,Period,year,course,stuid,name,discount) values ('" & InsID & "','" & InsName & "','" & Period & "','" & year & "','" & course & "','" & stuid & "','" & name & "'," & discount & ")"
            dr = cmd.ExecuteReader
            dr.Close()
            AddDiscountOk = True
        Catch ex As Exception
            AddDiscountOk = False
        End Try
    End Sub

    Public Sub UpdateDiscount(ByVal InsID As String, ByVal InsName As String, ByVal Period As String, ByVal year As String, ByVal course As String, ByVal stuid As String, ByVal name As String, ByVal discount As Decimal)
        Try
            cmd.CommandText = "update StudentDiscount set discount=" & discount & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and year='" & year & "' and course='" & course & "' and stuid='" & stuid & "' and name='" & name & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            AddDiscountOk = True
        Catch ex As Exception
            AddDiscountOk = False
        End Try
    End Sub
#End Region
End Class
#End Region