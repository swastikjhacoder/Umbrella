#Region "Class frmOnlineExamResult..."
Public Class frmOnlineExamResult
#Region "Functions..."
    Public Function ConvertBytesToMemoryStream(ByVal ImageData As Byte()) As IO.MemoryStream
        Try
            If IsNothing(ImageData) = True Then
                Return Nothing
            End If
            Return New System.IO.MemoryStream(ImageData)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        EProfilePic1.SetBounds(20, 33, 100, 111)
        Label1.SetBounds(6, 17, 78, 13)
        Label2.SetBounds(6, 43, 75, 13)
        Label3.SetBounds(6, 70, 76, 13)
        Label4.SetBounds(6, 97, 61, 13)
        Label5.SetBounds(6, 17, 65, 13)
        Label6.SetBounds(6, 43, 97, 13)
        Label7.SetBounds(6, 70, 66, 13)
        lblduration.SetBounds(109, 97, 0, 13)
        lblexamcode.SetBounds(109, 17, 0, 13)
        lblexamdate.SetBounds(109, 43, 0, 13)
        lblexamtime.SetBounds(109, 70, 0, 13)
        lblname.SetBounds(17, 185, 103, 90)
        lblqsnattempted.SetBounds(109, 43, 0, 13)
        lblregno.SetBounds(17, 158, 0, 13)
        lblrightans.SetBounds(109, 70, 0, 13)
        lbltotalqsn.SetBounds(109, 17, 0, 13)
    End Sub

    Private Sub LoadExamInfo()
        Try
            cmd.CommandText = "select * from OnlineExam where examid='" & examcode & "' and stuid='" & StuID & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            lblduration.Text = dr("examduration").ToString() + " Minutes"
            lblexamcode.Text = dr("examid").ToString()
            lblexamdate.Text = dr("examdate").ToString()
            lblexamtime.Text = dr("examtime").ToString()
            lblname.Text = dr("name").ToString()
            lblqsnattempted.Text = dr("totalqsnanswered").ToString()
            lblregno.Text = dr("stuid").ToString()
            lblrightans.Text = dr("rightanswered").ToString()
            lbltotalqsn.Text = dr("totalqsn").ToString()
            dr.Close()
            Dim totalqsn As Integer = CInt(lbltotalqsn.Text)
            Dim rightans As Integer = CInt(lblrightans.Text)
            Dim score As Decimal = CDec((rightans * 100) / totalqsn)
            EXpProgressBar1.Position = score
            EXpProgressBar1.Text = score + " %"
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadPicture()
        Try
            cmd.CommandText = "select picture from StudentRegistration where stuid='" & StuID & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                Dim img As Image = Image.FromStream(ConvertBytesToMemoryStream(dr("picture")))
                Dim newBMP As New Bitmap(95, 124)
                Dim gt_dest As Graphics = Graphics.FromImage(newBMP)
                gt_dest.Clear(Color.White)
                Dim newWidth As Integer = newBMP.Width - 2 * 93
                gt_dest.DrawImage(img, 93, 0, newWidth, newBMP.Height)
                gt_dest.Dispose()
                EProfilePic1.SizeMode = PictureBoxSizeMode.StretchImage
                EProfilePic1.Image = newBMP
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmOnlineExamResult_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
        LoadExamInfo()
        LoadPicture()
    End Sub
#End Region
End Class
#End Region