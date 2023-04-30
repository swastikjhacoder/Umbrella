#Region "Class frmDesignation..."
Public Class frmDesignation
#Region "Declarations..."
    Private ACODE As String = ""
    Private TT As String = ""
    Private DesigExist As Boolean = False
#End Region
#Region "Attributes..."
    Private Sub txtdesigcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdesigcode.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtdesignation.Focus()
        End If
    End Sub

    Private Sub txtdesignation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdesignation.KeyDown
        If e.KeyCode = Keys.Up Then
            txtdesigcode.Focus()
        End If
    End Sub

    Private Sub txtdesignation_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdesignation.TextChanged
        ctc.ConvertTextBoxValidValue(txtdesignation)
    End Sub
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        ACODE = Indx.LoadDesigCode()
        Dim var As String
        var = CodeIncrement(ACODE)
        Me.txtdesigcode.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("DSG:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ConreolSetBound()
        Label3.SetBounds(70, 45, 113, 13)
        Label2.SetBounds(104, 19, 79, 13)

        txtdesigcode.SetBounds(190, 16, 177, 21)
        txtdesignation.SetBounds(190, 42, 177, 21)
    End Sub

    Private Sub LoadDataGrid()
        Try
            dgviewdesignation.Rows.Clear()
            Dim indx As Integer = 0
            cmd.CommandText = "select desigid,designame from Designation where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewdesignation.Rows.Add()
                dgviewdesignation.Rows(indx).Cells(0).Value = dr("desigid").ToString()
                dgviewdesignation.Rows(indx).Cells(1).Value = dr("designame").ToString()
                indx = indx + 1
            End While
            dr.Close()
            dgviewdesignation.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetForm()
        If PSDAutoID = "Yes" Then
            GetCode()
        Else
            txtdesigcode.Text = ""
        End If
        LoadDataGrid()
        txtdesignation.Text = ""
        txtdesignation.Focus()
    End Sub

    Private Sub AddRecord()
        Try
            If txtdesigcode.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter designation code.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtdesigcode.Focus()
                End If
            ElseIf txtdesignation.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter designation.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtdesignation.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    CheckDesignation()
                    If DesigExist = False Then
                        Dim cls As New cDesignation()
                        cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, txtdesigcode.Text, txtdesignation.Text)
                        If cls.AddOk = True Then
                            Dim result1 As DialogResult = MessageBox.Show("Record added successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = DialogResult.OK Then
                                LoadDataGrid()
                                txtdesignation.Focus()
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Designation ID already exist." + Environment.NewLine + "Please enter a new designation id.", "Umbrella - Duplicate Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result1 = DialogResult.OK Then
                            txtdesigcode.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If txtdesigcode.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter designation code.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtdesigcode.Focus()
                End If
            ElseIf txtdesignation.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter designation.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtdesignation.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim cls As New cDesignation()
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, txtdesigcode.Text, txtdesignation.Text)
                    If cls.UpdateOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = DialogResult.OK Then
                            LoadDataGrid()
                            txtdesignation.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If txtdesigcode.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter designation code.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtdesigcode.Focus()
                End If
            ElseIf txtdesignation.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter designation.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtdesignation.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim cls As New cDesignation()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, txtdesigcode.Text)
                    If cls.DeleteOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record deleted successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = DialogResult.OK Then
                            ResetForm()
                            txtdesignation.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedDesignation()
        Try
            cmd.CommandText = "select desigid,designame from Designation where desigid='" & desigcode & "' and designame='" & designame & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                txtdesigcode.Text = dr("desigid").ToString()
                txtdesignation.Text = dr("designame").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CheckDesignation()
        Try
            cmd.CommandText = "select * from Designation where desigid='" & txtdesigcode.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read Then
                DesigExist = True
            Else
                DesigExist = False
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
            DesigExist = False
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmDesignation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updatedesig = False Then
            ConreolSetBound()
            If PSDAutoID = "Yes" Then
                GetCode()
            End If
            LoadDataGrid()
        Else
            ConreolSetBound()
            LoadDataGrid()
            LoadSelectedDesignation()
        End If
        If USpayrollsystem = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            txtdesigcode.ReadOnly = True
            txtdesignation.ReadOnly = True
            dgviewdesignation.Enabled = False
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatedesig = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatedesig = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatedesig = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updatedesig = False Then
            ConreolSetBound()
            If PSDAutoID = "Yes" Then
                GetCode()
            End If
            LoadDataGrid()
        Else
            ConreolSetBound()
            LoadDataGrid()
            LoadSelectedDesignation()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region