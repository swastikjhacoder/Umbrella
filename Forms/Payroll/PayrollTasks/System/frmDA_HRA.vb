#Region "Class frmDA_HRA..."
Public Class frmDA_HRA
#Region "Methods..."
    Private Sub UpdateRecord()
        Try
            Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim cls As New cDaHra()
                Dim effectmonth As Integer
                For i As Integer = 0 To dgviewdahra.Rows.Count - 1
                    Dim month As String = dgviewdahra.Rows(i).Cells(1).Value.ToString()
                    If month = "January" Then
                        effectmonth = 1
                    ElseIf month = "February" Then
                        effectmonth = 2
                    ElseIf month = "March" Then
                        effectmonth = 3
                    ElseIf month = "April" Then
                        effectmonth = 4
                    ElseIf month = "May" Then
                        effectmonth = 5
                    ElseIf month = "June" Then
                        effectmonth = 6
                    ElseIf month = "July" Then
                        effectmonth = 7
                    ElseIf month = "August" Then
                        effectmonth = 8
                    ElseIf month = "September" Then
                        effectmonth = 9
                    ElseIf month = "October" Then
                        effectmonth = 10
                    ElseIf month = "November" Then
                        effectmonth = 11
                    ElseIf month = "December" Then
                        effectmonth = 12
                    End If
                    Dim effectyear As Integer = CInt(dgviewdahra.Rows(i).Cells(2).Value.ToString())
                    Dim darate As Decimal = CDec(dgviewdahra.Rows(i).Cells(3).Value.ToString())
                    Dim hrarate As Decimal = CDec(dgviewdahra.Rows(i).Cells(4).Value.ToString())
                    Dim maximum As Decimal = CDec(dgviewdahra.Rows(i).Cells(5).Value.ToString())
                    Dim medical As Decimal = CDec(dgviewdahra.Rows(i).Cells(6).Value.ToString())

                    cls.UpdateDaHra(i, My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, effectmonth, effectyear, darate, hrarate, maximum, medical)
                Next
                If cls.UpdateRecordOk = True Then
                    Dim result1 As DialogResult = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If result1 = DialogResult.OK Then
                        dgviewdahra.Focus()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadRecord()
        Try
            dgviewdahra.Rows.Clear()
            Dim i As Integer = 0
            cmd.CommandText = "select effectmonth,effectyear,darate,hrarate,maximum,medical from DaHra where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewdahra.Rows.Add()
                dgviewdahra.Rows(i).Cells(0).Value = (i + 1).ToString()
                dgviewdahra.Rows(i).Cells(0).Style.BackColor = Color.DimGray
                dgviewdahra.Rows(i).Cells(0).Style.ForeColor = Color.White
                dgviewdahra.Rows(i).Cells(0).Style.SelectionBackColor = Color.DimGray
                dgviewdahra.Rows(i).Cells(0).Style.SelectionForeColor = Color.White
                Dim mm As Integer = CInt(dr("effectmonth").ToString())
                If mm = 1 Then
                    dgviewdahra.Rows(i).Cells(1).Value = "January"
                ElseIf mm = 2 Then
                    dgviewdahra.Rows(i).Cells(1).Value = "February"
                ElseIf mm = 3 Then
                    dgviewdahra.Rows(i).Cells(1).Value = "March"
                ElseIf mm = 4 Then
                    dgviewdahra.Rows(i).Cells(1).Value = "April"
                ElseIf mm = 5 Then
                    dgviewdahra.Rows(i).Cells(1).Value = "May"
                ElseIf mm = 6 Then
                    dgviewdahra.Rows(i).Cells(1).Value = "June"
                ElseIf mm = 7 Then
                    dgviewdahra.Rows(i).Cells(1).Value = "July"
                ElseIf mm = 8 Then
                    dgviewdahra.Rows(i).Cells(1).Value = "August"
                ElseIf mm = 9 Then
                    dgviewdahra.Rows(i).Cells(1).Value = "September"
                ElseIf mm = 10 Then
                    dgviewdahra.Rows(i).Cells(1).Value = "October"
                ElseIf mm = 11 Then
                    dgviewdahra.Rows(i).Cells(1).Value = "November"
                ElseIf mm = 12 Then
                    dgviewdahra.Rows(i).Cells(1).Value = "December"
                End If
                dgviewdahra.Rows(i).Cells(2).Value = dr("effectyear").ToString()
                dgviewdahra.Rows(i).Cells(2).Style.BackColor = Color.DimGray
                dgviewdahra.Rows(i).Cells(2).Style.ForeColor = Color.White
                dgviewdahra.Rows(i).Cells(2).Style.SelectionBackColor = Color.DimGray
                dgviewdahra.Rows(i).Cells(2).Style.SelectionForeColor = Color.White
                Dim darate As Decimal = CDec(dr("darate").ToString())
                dgviewdahra.Rows(i).Cells(3).Value = FormatNumber(darate.ToString())
                Dim hrarate As Decimal = CDec(dr("hrarate").ToString())
                dgviewdahra.Rows(i).Cells(4).Value = FormatNumber(hrarate.ToString())
                Dim maximum As Decimal = CDec(dr("maximum").ToString())
                dgviewdahra.Rows(i).Cells(5).Value = FormatNumber(maximum.ToString())
                Dim medical As Decimal = CDec(dr("medical").ToString())
                dgviewdahra.Rows(i).Cells(6).Value = FormatNumber(medical.ToString())
                i = i + 1
            End While
            dr.Close()
            dgviewdahra.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmDA_HRA_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadRecord()
        If USpayrollsystem = "View Only" Then
            btnsave.Enabled = False
            dgviewdahra.Enabled = False
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        UpdateRecord()
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        LoadRecord()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Attributes..."
    Private Sub dgviewdahra_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgviewdahra.CellEndEdit
        If e.ColumnIndex <> 1 Then
            Dim val As Decimal = CDec(dgviewdahra.CurrentCell.Value.ToString())
            dgviewdahra.CurrentCell.Value = FormatNumber(val.ToString())
        End If
    End Sub
#End Region
End Class
#End Region