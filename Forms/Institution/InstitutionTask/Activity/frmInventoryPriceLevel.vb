#Region "Class frmInventoryPriceLevel..."
Public Class frmInventoryPriceLevel
#Region "Declaration..."
    Private CheckItem As Boolean = False
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(12, 28, 57, 13)
        Label2.SetBounds(12, 52, 76, 13)
        Label3.SetBounds(12, 77, 76, 13)
        Label4.SetBounds(12, 23, 87, 13)
        lblitemdescription.SetBounds(95, 77, 0, 13)
        lblitemid.SetBounds(95, 28, 0, 13)
        lblitemname.SetBounds(95, 52, 0, 13)
        cmbselectlevel.SetBounds(105, 20, 168, 21)
    End Sub

    Private Sub LoadDataGridValues()
        Try
            Dim j As Integer = 9
            Dim i As Integer
            For i = 0 To j
                Dim k As Integer = i + 1
                dgviewpricelevel.Rows.Add()
                dgviewpricelevel.Rows(i).Cells(0).Value = "Price Level " + k.ToString()
                dgviewpricelevel.Rows(i).Cells(0).Style.BackColor = Color.DimGray
                dgviewpricelevel.Rows(i).Cells(0).Style.ForeColor = Color.White
                dgviewpricelevel.Rows(i).Cells(0).Style.SelectionBackColor = Color.DimGray
                dgviewpricelevel.Rows(i).Cells(0).Style.SelectionForeColor = Color.White
            Next
            cmd.CommandText = "select * from InventoryItemPriceLevel where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and itemid='" & lblitemid.Text & "' and itemname='" & lblitemname.Text & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                Dim a1 As Decimal = CDec(dr("levelprice1").ToString())
                Dim a2 As Decimal = CDec(dr("levelprice2").ToString())
                Dim a3 As Decimal = CDec(dr("levelprice3").ToString())
                Dim a4 As Decimal = CDec(dr("levelprice4").ToString())
                Dim a5 As Decimal = CDec(dr("levelprice5").ToString())
                Dim a6 As Decimal = CDec(dr("levelprice6").ToString())
                Dim a7 As Decimal = CDec(dr("levelprice7").ToString())
                Dim a8 As Decimal = CDec(dr("levelprice8").ToString())
                Dim a9 As Decimal = CDec(dr("levelprice9").ToString())
                Dim a10 As Decimal = CDec(dr("levelprice10").ToString())
                dgviewpricelevel.Rows(0).Cells(1).Value = FormatNumber(a1.ToString())
                dgviewpricelevel.Rows(1).Cells(1).Value = FormatNumber(a2.ToString())
                dgviewpricelevel.Rows(2).Cells(1).Value = FormatNumber(a3.ToString())
                dgviewpricelevel.Rows(3).Cells(1).Value = FormatNumber(a4.ToString())
                dgviewpricelevel.Rows(4).Cells(1).Value = FormatNumber(a5.ToString())
                dgviewpricelevel.Rows(5).Cells(1).Value = FormatNumber(a6.ToString())
                dgviewpricelevel.Rows(6).Cells(1).Value = FormatNumber(a7.ToString())
                dgviewpricelevel.Rows(7).Cells(1).Value = FormatNumber(a8.ToString())
                dgviewpricelevel.Rows(8).Cells(1).Value = FormatNumber(a9.ToString())
                dgviewpricelevel.Rows(9).Cells(1).Value = FormatNumber(a10.ToString())
            Else
                Dim b As Integer = 9
                Dim a As Integer
                For a = 1 To b
                    If dgviewpricelevel.Rows(a).Cells(1).Value = "" Then
                        dgviewpricelevel.Rows(a).Cells(1).Value = "0.00"
                    End If
                Next
                dgviewpricelevel.Rows(0).Cells(1).Value = FormatNumber(itemprice.ToString())
            End If
            cmbselectlevel.Text = dr("defaultlevel").ToString()
            dr.Close()
            dgviewpricelevel.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadDefaultLevel()
        Try
            Dim j As Integer = 9
            Dim i As Integer
            For i = 0 To j
                If dgviewpricelevel.Rows(i).Cells(1).Value <> "0.00" Then
                    cmbselectlevel.SelectedIndex = i
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ItemExist()
        Try
            cmd.CommandText = "select * from InventoryItemPriceLevel where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and itemid='" & lblitemid.Text & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                CheckItem = True
            Else
                CheckItem = False
            End If
            dr.Close()
        Catch ex As Exception
            CheckItem = False
        End Try
    End Sub

    Private Sub AddRecord()
        Try
            If cmbselectlevel.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter serial no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbselectlevel.Focus()
                End If
            ElseIf lblitemid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter serial no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim LevelName1 As String = ""
                    Dim LevelName2 As String = ""
                    Dim LevelName3 As String = ""
                    Dim LevelName4 As String = ""
                    Dim LevelName5 As String = ""
                    Dim LevelName6 As String = ""
                    Dim LevelName7 As String = ""
                    Dim LevelName8 As String = ""
                    Dim LevelName9 As String = ""
                    Dim LevelName10 As String = ""
                    Dim Level1Price As Decimal = 0.0
                    Dim Level2Price As Decimal = 0.0
                    Dim Level3Price As Decimal = 0.0
                    Dim Level4Price As Decimal = 0.0
                    Dim Level5Price As Decimal = 0.0
                    Dim Level6Price As Decimal = 0.0
                    Dim Level7Price As Decimal = 0.0
                    Dim Level8Price As Decimal = 0.0
                    Dim Level9Price As Decimal = 0.0
                    Dim Level10Price As Decimal = 0.0
                    LevelName1 = dgviewpricelevel.Rows(0).Cells(0).Value.ToString()
                    LevelName2 = dgviewpricelevel.Rows(1).Cells(0).Value.ToString()
                    LevelName3 = dgviewpricelevel.Rows(2).Cells(0).Value.ToString()
                    LevelName4 = dgviewpricelevel.Rows(3).Cells(0).Value.ToString()
                    LevelName5 = dgviewpricelevel.Rows(4).Cells(0).Value.ToString()
                    LevelName6 = dgviewpricelevel.Rows(5).Cells(0).Value.ToString()
                    LevelName7 = dgviewpricelevel.Rows(6).Cells(0).Value.ToString()
                    LevelName8 = dgviewpricelevel.Rows(7).Cells(0).Value.ToString()
                    LevelName9 = dgviewpricelevel.Rows(8).Cells(0).Value.ToString()
                    LevelName10 = dgviewpricelevel.Rows(9).Cells(0).Value.ToString()
                    Level1Price = CDec(dgviewpricelevel.Rows(0).Cells(1).Value.ToString())
                    Level2Price = CDec(dgviewpricelevel.Rows(1).Cells(1).Value.ToString())
                    Level3Price = CDec(dgviewpricelevel.Rows(2).Cells(1).Value.ToString())
                    Level4Price = CDec(dgviewpricelevel.Rows(3).Cells(1).Value.ToString())
                    Level5Price = CDec(dgviewpricelevel.Rows(4).Cells(1).Value.ToString())
                    Level6Price = CDec(dgviewpricelevel.Rows(5).Cells(1).Value.ToString())
                    Level7Price = CDec(dgviewpricelevel.Rows(6).Cells(1).Value.ToString())
                    Level8Price = CDec(dgviewpricelevel.Rows(7).Cells(1).Value.ToString())
                    Level9Price = CDec(dgviewpricelevel.Rows(8).Cells(1).Value.ToString())
                    Level10Price = CDec(dgviewpricelevel.Rows(9).Cells(1).Value.ToString())
                    Dim cls As New cInventory()
                    ItemExist()
                    If CheckItem = False Then
                        cls.AddInventoryItemPriceLevel(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, lblitemid.Text, lblitemname.Text, lblitemdescription.Text, Level1Price, Level2Price, Level3Price, Level4Price, Level5Price, Level6Price, Level7Price, Level8Price, Level9Price, Level10Price, cmbselectlevel.Text)
                        If cmbselectlevel.Text = "Price Level 1" Then
                            itemprice = CDec(dgviewpricelevel.Rows(0).Cells(1).Value.ToString())
                        ElseIf cmbselectlevel.Text = "Price Level 2" Then
                            itemprice = CDec(dgviewpricelevel.Rows(1).Cells(1).Value.ToString())
                        ElseIf cmbselectlevel.Text = "Price Level 3" Then
                            itemprice = CDec(dgviewpricelevel.Rows(2).Cells(1).Value.ToString())
                        ElseIf cmbselectlevel.Text = "Price Level 4" Then
                            itemprice = CDec(dgviewpricelevel.Rows(3).Cells(1).Value.ToString())
                        ElseIf cmbselectlevel.Text = "Price Level 5" Then
                            itemprice = CDec(dgviewpricelevel.Rows(4).Cells(1).Value.ToString())
                        ElseIf cmbselectlevel.Text = "Price Level 6" Then
                            itemprice = CDec(dgviewpricelevel.Rows(5).Cells(1).Value.ToString())
                        ElseIf cmbselectlevel.Text = "Price Level 7" Then
                            itemprice = CDec(dgviewpricelevel.Rows(6).Cells(1).Value.ToString())
                        ElseIf cmbselectlevel.Text = "Price Level 8" Then
                            itemprice = CDec(dgviewpricelevel.Rows(7).Cells(1).Value.ToString())
                        ElseIf cmbselectlevel.Text = "Price Level 9" Then
                            itemprice = CDec(dgviewpricelevel.Rows(8).Cells(1).Value.ToString())
                        ElseIf cmbselectlevel.Text = "Price Level 10" Then
                            itemprice = CDec(dgviewpricelevel.Rows(9).Cells(1).Value.ToString())
                        End If
                        If cls.AddItemPriceLevel = True Then
                            Dim result1 As DialogResult = MessageBox.Show("Record added successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = Windows.Forms.DialogResult.OK Then
                            End If
                        End If
                    Else
                        cls.UpdateInventoryItemPriceLevel(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, lblitemid.Text, lblitemname.Text, lblitemdescription.Text, Level1Price, Level2Price, Level3Price, Level4Price, Level5Price, Level6Price, Level7Price, Level8Price, Level9Price, Level10Price, cmbselectlevel.Text)
                        If cmbselectlevel.Text = "Price Level 1" Then
                            itemprice = CDec(dgviewpricelevel.Rows(0).Cells(1).Value.ToString())
                        ElseIf cmbselectlevel.Text = "Price Level 2" Then
                            itemprice = CDec(dgviewpricelevel.Rows(1).Cells(1).Value.ToString())
                        ElseIf cmbselectlevel.Text = "Price Level 3" Then
                            itemprice = CDec(dgviewpricelevel.Rows(2).Cells(1).Value.ToString())
                        ElseIf cmbselectlevel.Text = "Price Level 4" Then
                            itemprice = CDec(dgviewpricelevel.Rows(3).Cells(1).Value.ToString())
                        ElseIf cmbselectlevel.Text = "Price Level 5" Then
                            itemprice = CDec(dgviewpricelevel.Rows(4).Cells(1).Value.ToString())
                        ElseIf cmbselectlevel.Text = "Price Level 6" Then
                            itemprice = CDec(dgviewpricelevel.Rows(5).Cells(1).Value.ToString())
                        ElseIf cmbselectlevel.Text = "Price Level 7" Then
                            itemprice = CDec(dgviewpricelevel.Rows(6).Cells(1).Value.ToString())
                        ElseIf cmbselectlevel.Text = "Price Level 8" Then
                            itemprice = CDec(dgviewpricelevel.Rows(7).Cells(1).Value.ToString())
                        ElseIf cmbselectlevel.Text = "Price Level 9" Then
                            itemprice = CDec(dgviewpricelevel.Rows(8).Cells(1).Value.ToString())
                        ElseIf cmbselectlevel.Text = "Price Level 10" Then
                            itemprice = CDec(dgviewpricelevel.Rows(9).Cells(1).Value.ToString())
                        End If
                        If cls.UpdateItemPriceLevel = True Then
                            Dim result1 As DialogResult = MessageBox.Show("Record added successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = Windows.Forms.DialogResult.OK Then
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmInventoryPriceLevel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlSetBound()
        lblitemdescription.Text = itemdescription
        lblitemid.Text = itemid
        lblitemname.Text = itemname
        LoadDataGridValues()
        LoadDefaultLevel()
        If USinventory = "View Only" Then
            btnsave.Enabled = False
            cmbselectlevel.Enabled = False
            dgviewpricelevel.Enabled = False
        End If
    End Sub
#End Region
#Region "DGView Events..."
    Private Sub dgviewpricelevel_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgviewpricelevel.CellEndEdit
        Try
            Dim i As Integer = dgviewpricelevel.CurrentRow.Index
            Dim a As Decimal = CDec(dgviewpricelevel.Rows(i).Cells(1).Value.ToString())
            dgviewpricelevel.Rows(i).Cells(1).Value = FormatNumber(a.ToString())
            LoadDefaultLevel()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgviewpricelevel_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgviewpricelevel.RowLeave
        Try
            Dim i As Integer = dgviewpricelevel.CurrentRow.Index
            Dim a As Decimal = CDec(dgviewpricelevel.Rows(i).Cells(1).Value.ToString())
            dgviewpricelevel.Rows(i).Cells(1).Value = FormatNumber(a.ToString())
            LoadDefaultLevel()
        Catch ex As Exception

        End Try
    End Sub
#End Region
End Class
#End Region