#Region "Class frmPayScale..."
Public Class frmPayScale
#Region "Declaration..."
    Private ACODE As String = ""
    Private TT As String = ""
    Private PBNameExist As Boolean = False
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        ACODE = Indx.LoadPBCode()
        Dim var As String
        var = CodeIncrement(ACODE)
        Me.txtpbname.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("PB:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        Label1.SetBounds(26, 38, 98, 13)
        label2.SetBounds(43, 65, 81, 13)
        Label3.SetBounds(43, 92, 81, 13)
        label4.SetBounds(77, 119, 47, 13)
        label5.SetBounds(82, 146, 42, 13)

        txtpbname.SetBounds(130, 35, 279, 21)
        txtlower.SetBounds(130, 62, 78, 21)
        txtupper.SetBounds(130, 89, 78, 21)
        txtgrade.SetBounds(130, 116, 78, 21)
        txtbasic.SetBounds(130, 143, 78, 21)
    End Sub

    Private Sub LoadDataGrid()
        Try
            dgviewpayscale.Rows.Clear()
            Dim indx As Integer = 0
            cmd.CommandText = "select pbname,pblower,pbupper,pbgrade,pbbasic from PayScale where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewpayscale.Rows.Add()
                dgviewpayscale.Rows(indx).Cells(0).Value = dr("pbname").ToString()
                Dim lower As Decimal = CDec(dr("pblower").ToString())
                dgviewpayscale.Rows(indx).Cells(1).Value = FormatNumber(lower.ToString())
                Dim upper As Decimal = CDec(dr("pbupper").ToString())
                dgviewpayscale.Rows(indx).Cells(2).Value = FormatNumber(upper.ToString())
                Dim grade As Decimal = CDec(dr("pbgrade").ToString())
                dgviewpayscale.Rows(indx).Cells(3).Value = FormatNumber(grade.ToString())
                Dim basic As Decimal = CDec(dr("pbbasic").ToString())
                dgviewpayscale.Rows(indx).Cells(4).Value = FormatNumber(basic.ToString())
                indx = indx + 1
            End While
            dr.Close()
            dgviewpayscale.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetForm()
        If PSDAutoID = "Yes" Then
            GetCode()
        Else
            txtpbname.Text = ""
        End If
        LoadDataGrid()
        txtbasic.Text = ""
        txtgrade.Text = ""
        txtlower.Text = ""
        txtupper.Text = ""
        txtpbname.Focus()
    End Sub

    Private Sub AddRecord()
        Try
            If txtpbname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter payband name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtpbname.Focus()
                End If
            ElseIf txtlower.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter lower scale.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtlower.Focus()
                End If
            ElseIf txtupper.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter upper scale.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtupper.Focus()
                End If
            ElseIf txtgrade.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter grade pay.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtgrade.Focus()
                End If
            ElseIf txtbasic.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter basic pay.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtbasic.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    CheckPBName()
                    If PBNameExist = False Then
                        Dim cls As New cPayScale()
                        Dim payscale As String = txtlower.Text + " - " + txtupper.Text
                        cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, txtpbname.Text, CDec(txtlower.Text), CDec(txtupper.Text), CDec(txtgrade.Text), CDec(txtbasic.Text), payscale)
                        If cls.AddOk = True Then
                            Dim result1 As DialogResult = MessageBox.Show("Record added successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = DialogResult.OK Then
                                LoadDataGrid()
                                txtpbname.Focus()
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("PB name already exist." + Environment.NewLine + "Please enter a new pb-name", "Umbrella - Duplicate Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result1 = DialogResult.OK Then
                            txtpbname.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If txtpbname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter payband name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtpbname.Focus()
                End If
            ElseIf txtlower.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter lower scale.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtlower.Focus()
                End If
            ElseIf txtupper.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter upper scale.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtupper.Focus()
                End If
            ElseIf txtgrade.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter grade pay.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtgrade.Focus()
                End If
            ElseIf txtbasic.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter basic pay.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtbasic.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim cls As New cPayScale()
                    Dim payscale As String = txtlower.Text + " - " + txtupper.Text
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, txtpbname.Text, CDec(txtlower.Text), CDec(txtupper.Text), CDec(txtgrade.Text), CDec(txtbasic.Text), payscale)
                    If cls.UpdateOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = DialogResult.OK Then
                            LoadDataGrid()
                            txtpbname.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If txtpbname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter payband name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtpbname.Focus()
                End If
            ElseIf txtlower.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter lower scale.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtlower.Focus()
                End If
            ElseIf txtupper.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter upper scale.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtupper.Focus()
                End If
            ElseIf txtgrade.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter grade pay.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtgrade.Focus()
                End If
            ElseIf txtbasic.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter basic pay.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtbasic.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim cls As New cPayScale()
                    Dim payscale As String = txtlower.Text + " - " + txtupper.Text
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, txtpbname.Text)
                    If cls.DeleteOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record deleted successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = DialogResult.OK Then
                            ResetForm()
                            txtpbname.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedPayScale()
        Try
            cmd.CommandText = "select pbname,pblower,pbupper,pbgrade,pbbasic from PayScale where pbname='" & pbname & "' and payscale='" & pbscale & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                txtbasic.Text = dr("pbbasic").ToString()
                txtgrade.Text = dr("pbgrade").ToString()
                txtlower.Text = dr("pblower").ToString()
                txtpbname.Text = dr("pbname").ToString()
                txtupper.Text = dr("pbupper").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CheckPBName()
        Try
            cmd.CommandText = "select * from PayScale where pbname='" & txtpbname.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                PBNameExist = True
            Else
                PBNameExist = False
            End If
            dr.Close()
        Catch ex As Exception
            PBNameExist = False
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmPayScale_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updatepayscale = False Then
            ControlSetBound()
            If PSDAutoID = "Yes" Then
                GetCode()
            End If
            LoadDataGrid()
        Else
            ControlSetBound()
            LoadDataGrid()
            LoadSelectedPayScale()
        End If
        If USpayrollsystem = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            txtbasic.ReadOnly = True
            txtgrade.ReadOnly = True
            txtlower.ReadOnly = True
            txtpbname.ReadOnly = True
            txtupper.ReadOnly = True
            dgviewpayscale.Enabled = False
        End If
    End Sub
#End Region
#Region "Attributes..."
    Private Sub txtpbname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpbname.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtlower.Focus()
        End If
    End Sub

    Private Sub txtlower_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlower.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtupper.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtpbname.Focus()
        End If
    End Sub

    Private Sub txtupper_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtupper.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtgrade.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtlower.Focus()
        End If
    End Sub

    Private Sub txtgrade_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtgrade.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtbasic.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtupper.Focus()
        End If
    End Sub

    Private Sub txtbasic_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbasic.GotFocus
        Dim lower As Decimal
        Dim grade As Decimal
        Dim basic As Decimal
        If txtlower.Text <> "" Then
            lower = CDec(txtlower.Text)
        Else
            lower = 0.0
        End If
        If txtgrade.Text <> "" Then
            grade = CDec(txtgrade.Text)
        Else
            grade = 0.0
        End If
        basic = lower + grade
        txtbasic.Text = basic.ToString()
    End Sub

    Private Sub txtbasic_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbasic.KeyDown
        If e.KeyCode = Keys.Up Then
            txtgrade.Focus()
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatepayscale = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatepayscale = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatepayscale = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updatepayscale = False Then
            ControlSetBound()
            If PSDAutoID = "Yes" Then
                GetCode()
            End If
            LoadDataGrid()
        Else
            ControlSetBound()
            LoadDataGrid()
            LoadSelectedPayScale()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region
