#Region "Class frmCourse..."
Public Class frmCourse
#Region "Declarations..."
    Private CourseExist As Boolean = False
#End Region
#Region "Methods..."
    Private Sub LoadDataGrid()
        Try
            Dim i As Integer = 0
            dgviewcourse.Rows.Clear()
            cmd.CommandText = "select * from Course where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewcourse.Rows.Add()
                dgviewcourse.Rows(i).Cells(1).Value = dr("CourseName").ToString()
                dgviewcourse.Rows(i).Cells(2).Value = dr("CourseCode").ToString()
                dgviewcourse.Rows(i).Cells(3).Value = dr("Duration").ToString()
                dgviewcourse.Rows(i).Cells(4).Value = dr("CourseFees").ToString()
                i = i + 1
            End While
            dr.Close()
            dgviewcourse.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckCourse(ByVal code As String)
        Try
            cmd.CommandText = "select * from Course where CourseCode='" & code & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                CourseExist = True
            Else
                CourseExist = False
            End If
            dr.Close()
        Catch ex As Exception
            CourseExist = False
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Attributes..."
    Private Sub dgviewcourse_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgviewcourse.RowsAdded
        Dim i As Integer = dgviewcourse.Rows.Count
        dgviewcourse.Rows(i - 1).Cells(0).Value = i.ToString()
        dgviewcourse.Rows(i - 1).Cells(0).Style.BackColor = System.Drawing.SystemColors.Control
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmCourse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDataGrid()
        If UScoursesubject = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            dgviewcourse.Enabled = False
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        dgviewcourse.Rows.Add()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        Try
            cmd.CommandText = "delete from Course where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            For i As Integer = 0 To dgviewcourse.Rows.Count - 1
                Dim coursename As String = dgviewcourse.Rows(i).Cells(1).Value.ToString()
                Dim coursecode As String = dgviewcourse.Rows(i).Cells(2).Value.ToString()
                Dim duration As String = dgviewcourse.Rows(i).Cells(3).Value.ToString()
                Dim fees As Decimal = CDec(dgviewcourse.Rows(i).Cells(4).Value.ToString())
                CheckCourse(coursecode)
                If CourseExist = False Then
                    cmd.CommandText = "insert into Course(InsID,InsName,Period,CourseName,CourseCode,Duration,CourseFees) values ('" & My.Settings.LastOpenedInstitute & "','" & My.Settings.LastOpenedInstituteID & "','" & My.Settings.Period & "','" & coursename & "','" & coursecode & "','" & duration & "'," & fees & ")"
                    dr = cmd.ExecuteReader
                    dr.Close()
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        Try
            Dim i As Integer = dgviewcourse.CurrentRow.Index
            cmd.CommandText = "delete from Course where CourseName='" & dgviewcourse.Rows(i).Cells(1).Value.ToString() & "' and CourseCode='" & dgviewcourse.Rows(i).Cells(2).Value.ToString() & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        LoadDataGrid()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region