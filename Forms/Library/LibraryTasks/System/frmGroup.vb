#Region "Class frmGroup..."
Public Class frmGroup
#Region "Declarations..."
    Private DGVGroupID As New DataGridView()
    Private GCODE As String = ""
    Private TT As String = ""
    Private GroupExist As Boolean = False
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        GCODE = Indx.LoadGroupID()
        Dim var As String
        var = CodeIncrement(GCODE)
        Me.cmbgroupid.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("GRP:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        Label1.SetBounds(15, 40, 65, 13)
        Label2.SetBounds(15, 67, 84, 13)

        cmbgroupid.SetBounds(105, 37, 121, 21)
        txtgroupname.SetBounds(105, 64, 545, 21)
    End Sub

    Private Sub LoadGroupID()
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .Name = "Col1"
                .HeaderText = "Group ID"
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .Name = "Col2"
                .HeaderText = "Group Name"
            End With
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .Name = "Col3"
                .HeaderText = "Details"
            End With

            With DGVGroupID
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVGroupID.CellClick, AddressOf DGVGroupID_CellClick
            End With

            DGVGroupID.Columns.Clear()
            DGVGroupID.Columns.Add(col1)
            DGVGroupID.Columns.Add(col2)
            DGVGroupID.Columns.Add(col3)

            DGVGroupID.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select groupid,groupname,groupdetails from GroupBooks where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVGroupID.Rows.Add()
                DGVGroupID.Rows(indx).Cells(0).Value = dr("groupid").ToString()
                DGVGroupID.Rows(indx).Cells(1).Value = dr("groupname").ToString()
                DGVGroupID.Rows(indx).Cells(2).Value = dr("groupdetails").ToString()

                indx = indx + 1
            End While
            dr.Close()
            DGVGroupID.ClearSelection()

            cmbgroupid.AddDataGridView(DGVGroupID, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVGroupID_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVGroupID.CurrentRow.Index
            DGVGroupID.Rows(k).Selected = True
            DGVGroupID.CurrentCell = DGVGroupID.Rows(k).Cells(0)
            GroupID = DGVGroupID.Rows(k).Cells(0).Value.ToString()
            cmbgroupid.Text = GroupID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetForm()
        updategroup = False
        txtgroupname.Text = ""
        rtbdetails.rtb.Text = ""
        If LSDAutoID = "Yes" Then
            GetCode()
        Else
            cmbgroupid.Text = ""
        End If
        cmbgroupid.Focus()
    End Sub

    Private Sub AddRecord()
        Try
            If cmbgroupid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter group id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbgroupid.Focus()
                End If
            ElseIf txtgroupname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter group name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtgroupname.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    CheckGroupID()
                    If GroupExist = False Then
                        Dim cls As New cGroup()
                        cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbgroupid.Text, txtgroupname.Text, rtbdetails.rtb.Text)
                        If cls.AddGroupOk = True Then
                            Dim result1 As DialogResult = MessageBox.Show("Record added successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = Windows.Forms.DialogResult.OK Then
                                cmbgroupid.Focus()
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Group id already exist." + Environment.NewLine + "Please enter a new group id.", "Umbrella - Duplicate Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            cmbgroupid.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If cmbgroupid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter group id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbgroupid.Focus()
                End If
            ElseIf txtgroupname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter group name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtgroupname.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cGroup()
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbgroupid.Text, txtgroupname.Text, rtbdetails.rtb.Text)
                    If cls.UpdateGroupOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            cmbgroupid.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If cmbgroupid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter group id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbgroupid.Focus()
                End If
            ElseIf txtgroupname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter group name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtgroupname.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Missing Value", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cGroup()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbgroupid.Text)
                    If cls.DeleteGroupOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record deleted successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            cmbgroupid.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedGroup()
        Try
            cmd.CommandText = "select groupid,groupname,groupdetails from GroupBooks where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and groupid='" & GroupID & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                cmbgroupid.Text = dr("groupid").ToString()
                txtgroupname.Text = dr("groupname").ToString()
                rtbdetails.rtb.Text = dr("groupdetails").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CheckGroupID()
        Try
            cmd.CommandText = "select * from GroupBooks where groupid='" & cmbgroupid.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                GroupExist = True
            Else
                GroupExist = False
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
            GroupExist = False
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmGroup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updategroup = False Then
            ControlSetBound()
            LoadGroupID()
            If LSDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadGroupID()
            LoadSelectedGroup()
        End If
        If USbookrecords = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbgroupid.Enabled = False
            txtgroupname.ReadOnly = True
        End If
    End Sub
#End Region
#Region "Attributes..."
    Private Sub cmbgroupid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbgroupid.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtgroupname.Focus()
        End If
    End Sub

    Private Sub txtgroupname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtgroupname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            rtbdetails.rtb.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbgroupid.Focus()
        End If
    End Sub

    Private Sub txtgroupname_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtgroupname.TextChanged
        ctc.ConvertTextBoxValidValue(txtgroupname)
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updategroup = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updategroup = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updategroup = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updategroup = False Then
            ControlSetBound()
            LoadGroupID()
            If LSDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadGroupID()
            LoadSelectedGroup()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region