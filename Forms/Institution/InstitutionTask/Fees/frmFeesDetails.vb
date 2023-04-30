#Region "Class frmFeesDetails"
Public Class frmFeesDetails
#Region "Methods"
    Private Sub ControlSetBound()
        Label1.SetBounds(19, 13, 37, 13)
        Label2.SetBounds(126, 13, 46, 13)
        Label3.SetBounds(595, 13, 53, 13)
        nudyear.SetBounds(62, 9, 58, 21)
        cmbmonth.SetBounds(178, 9, 119, 21)
        cmbcourse.SetBounds(654, 9, 123, 21)
    End Sub
#End Region
#Region "FormEvents"
    Private Sub frmFeesDetails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
    End Sub
#End Region
End Class
#End Region
