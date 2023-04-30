#Region "Class frmObsolescenceInformation..."
Public Class frmObsolescenceInformation
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(20, 39, 564, 13)
        Label2.SetBounds(20, 70, 701, 78)
        Label3.SetBounds(20, 420, 168, 13)
        Label4.SetBounds(322, 420, 155, 13)
        Label5.SetBounds(20, 470, 709, 26)
        lnkobsolescencepolicy.SetBounds(194, 420, 122, 13)
        chkdonotshow.SetBounds(20, 447, 239, 17)
        dgviewobsolescence.SetBounds(24, 156, 453, 261)
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmObsolescenceInformation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
    End Sub
#End Region
End Class
#End Region