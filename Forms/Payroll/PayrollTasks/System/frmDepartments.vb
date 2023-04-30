#Region "Class frmDepartments..."
Public Class frmDepartments
#Region "Declarations..."
    Private ACODE As String = ""
    Private TT As String = ""
    Private DeptCodeExist As Boolean = False
#End Region
#Region "Attributes..."
    Private Sub txtdeptcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdeptcode.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtdeptname.Focus()
        End If
    End Sub

    Private Sub txtdeptname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdeptname.KeyDown
        If e.KeyCode = Keys.Up Then
            txtdeptcode.Focus()
        End If
    End Sub

    Private Sub txtdeptname_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdeptname.TextChanged
        ctc.ConvertTextBoxValidValue(txtdeptname)
    End Sub
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        ACODE = Indx.LoadDeptCode()
        Dim var As String
        var = CodeIncrement(ACODE)
        Me.txtdeptcode.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("DPT:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ConreolSetBound()
        Label2.SetBounds(70, 45, 117, 13)
        Label3.SetBounds(70, 19, 114, 13)

        txtdeptcode.SetBounds(190, 16, 177, 21)
        txtdeptname.SetBounds(190, 42, 177, 21)
    End Sub

    Private Sub LoadDataGrid()
        Try
            dgviewdepartment.Rows.Clear()
            Dim indx As Integer = 0
            cmd.CommandText = "select deptid,deptname from Department where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewdepartment.Rows.Add()
                dgviewdepartment.Rows(indx).Cells(0).Value = dr("deptid").ToString()
                dgviewdepartment.Rows(indx).Cells(1).Value = dr("deptname").ToString()
                indx = indx + 1
            End While
            dr.Close()
            dgviewdepartment.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetForm()
        If PSDAutoID = "Yes" Then
            GetCode()
        Else
            txtdeptcode.Text = ""
        End If
        LoadDataGrid()
        txtdeptname.Text = ""
        txtdeptname.Focus()
    End Sub

    Private Sub AddRecord()
        Try
            If txtdeptcode.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter department code.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtdeptcode.Focus()
                End If
            ElseIf txtdeptname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter department name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtdeptname.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    CheckDeptCode()
                    If DeptCodeExist = False Then
                        Dim cls As New cDepartment()
                        cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, txtdeptcode.Text, txtdeptname.Text)
                        If cls.AddOk = True Then
                            Dim result1 As DialogResult = MessageBox.Show("Record added successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = DialogResult.OK Then
                                LoadDataGrid()
                                txtdeptname.Focus()
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Department code already exist." + Environment.NewLine + "Please enter a new Department code.", "Umbrella - Duplicate Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result1 = DialogResult.OK Then
                            txtdeptcode.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If txtdeptcode.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter department code.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtdeptcode.Focus()
                End If
            ElseIf txtdeptname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter department name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtdeptname.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim cls As New cDepartment()
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, txtdeptcode.Text, txtdeptname.Text)
                    If cls.UpdateOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = DialogResult.OK Then
                            LoadDataGrid()
                            txtdeptname.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If txtdeptcode.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter department code.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtdeptcode.Focus()
                End If
            ElseIf txtdeptname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter department name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtdeptname.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim cls As New cDepartment()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, txtdeptcode.Text)
                    If cls.DeleteOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record deleted successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = DialogResult.OK Then
                            ResetForm()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedDepartment()
        Try
            cmd.CommandText = "select deptid,deptname from Department where deptid='" & deptcode & "' and deptname='" & deptname & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                txtdeptcode.Text = dr("deptid").ToString()
                txtdeptname.Text = dr("deptname").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CheckDeptCode()
        Try
            cmd.CommandText = "select * from Department where deptid='" & txtdeptcode.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                DeptCodeExist = True
            Else
                DeptCodeExist = False
            End If
            dr.Close()
        Catch ex As Exception
            DeptCodeExist = False
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmDepartments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updatedept = False Then
            ConreolSetBound()
            If PSDAutoID = "Yes" Then
                GetCode()
            End If
            LoadDataGrid()
        Else
            ConreolSetBound()
            LoadDataGrid()
            LoadSelectedDepartment()
        End If
        If USpayrollsystem = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            txtdeptcode.ReadOnly = True
            txtdeptname.ReadOnly = True
            dgviewdepartment.Enabled = False
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatedept = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatedept = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatedept = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updatedept = False Then
            ConreolSetBound()
            If PSDAutoID = "Yes" Then
                GetCode()
            End If
            LoadDataGrid()
        Else
            ConreolSetBound()
            LoadDataGrid()
            LoadSelectedDepartment()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region