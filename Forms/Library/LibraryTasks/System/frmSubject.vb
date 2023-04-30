#Region "Class frmSubject..."
Public Class frmSubject
#Region "Declarations..."
    Private DGVSubject As New DataGridView()
    Private GCODE As String = ""
    Private TT As String = ""
    Private SubjectExist As Boolean = False
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        GCODE = Indx.LoadSubjectBookID()
        Dim var As String
        var = CodeIncrement(GCODE)
        Me.cmbsubjectid.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("SUB:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        Label1.SetBounds(15, 40, 73, 13)
        Label2.SetBounds(15, 67, 92, 13)

        cmbsubjectid.SetBounds(110, 37, 121, 21)
        txtsubjectname.SetBounds(110, 64, 545, 21)
    End Sub

    Private Sub LoadSubjectID()
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .Name = "Col1"
                .HeaderText = "Subject ID"
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .Name = "Col2"
                .HeaderText = "Subject Name"
            End With
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .Name = "Col3"
                .HeaderText = "Details"
            End With

            With DGVSubject
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
                AddHandler DGVSubject.CellClick, AddressOf DGVSubject_CellClick
            End With

            DGVSubject.Columns.Clear()
            DGVSubject.Columns.Add(col1)
            DGVSubject.Columns.Add(col2)
            DGVSubject.Columns.Add(col3)

            DGVSubject.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select subjectid,subjectname,subjectdetails from SubjectBooks where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVSubject.Rows.Add()
                DGVSubject.Rows(indx).Cells(0).Value = dr("subjectid").ToString()
                DGVSubject.Rows(indx).Cells(1).Value = dr("subjectname").ToString()
                DGVSubject.Rows(indx).Cells(2).Value = dr("subjectdetails").ToString()

                indx = indx + 1
            End While
            dr.Close()
            DGVSubject.ClearSelection()

            cmbsubjectid.AddDataGridView(DGVSubject, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVSubject_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVSubject.CurrentRow.Index
            DGVSubject.Rows(k).Selected = True
            DGVSubject.CurrentCell = DGVSubject.Rows(k).Cells(0)
            SubjectID = DGVSubject.Rows(k).Cells(0).Value.ToString()
            cmbsubjectid.Text = SubjectID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetForm()
        updatesubjectbooks = False
        txtsubjectname.Text = ""
        rtbdetails.rtb.Text = ""
        If LSDAutoID = "Yes" Then
            GetCode()
        Else
            cmbsubjectid.Text = ""
        End If
        cmbsubjectid.Focus()
    End Sub

    Private Sub AddRecord()
        Try
            If cmbsubjectid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter subject id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbsubjectid.Focus()
                End If
            ElseIf txtsubjectname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter subject name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtsubjectname.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    CheckSubjectID()
                    If SubjectExist = False Then
                        Dim cls As New cSubject()
                        cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbsubjectid.Text, txtsubjectname.Text, rtbdetails.rtb.Text)
                        If cls.AddSubjectOk = True Then
                            Dim result1 As DialogResult = MessageBox.Show("Record added successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = Windows.Forms.DialogResult.OK Then
                                cmbsubjectid.Focus()
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Subject id already exist." + Environment.NewLine + "Please enter a new subject id.", "Umbrella - Duplicate Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            cmbsubjectid.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If cmbsubjectid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter group id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbsubjectid.Focus()
                End If
            ElseIf txtsubjectname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter group name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtsubjectname.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cSubject()
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbsubjectid.Text, txtsubjectname.Text, rtbdetails.rtb.Text)
                    If cls.UpdateSubjectOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            cmbsubjectid.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If cmbsubjectid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter group id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbsubjectid.Focus()
                End If
            ElseIf txtsubjectname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter group name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtsubjectname.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Missing Value", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cSubject()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbsubjectid.Text)
                    If cls.DeleteSubjectOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record deleted successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            cmbsubjectid.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedSubject()
        Try
            cmd.CommandText = "select subjectid,subjectname,subjectdetails from SubjectBooks where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and subjectid='" & SubjectID & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                cmbsubjectid.Text = dr("subjectid").ToString()
                txtsubjectname.Text = dr("subjectname").ToString()
                rtbdetails.rtb.Text = dr("subjectdetails").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CheckSubjectID()
        Try
            cmd.CommandText = "select * from SubjectBooks where subjectid='" & cmbsubjectid.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                SubjectExist = True
            Else
                SubjectExist = False
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
            SubjectExist = False
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmSubject_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updatesubjectbooks = False Then
            ControlSetBound()
            LoadSubjectID()
            If LSDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadSubjectID()
            LoadSelectedSubject()
        End If
        If USbookrecords = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbsubjectid.Enabled = False
            txtsubjectname.ReadOnly = True
        End If
    End Sub
#End Region
#Region "Attributes..."
    Private Sub cmbsubjectid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbsubjectid.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsubjectname.Focus()
        End If
    End Sub

    Private Sub txtsubjectname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsubjectname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            rtbdetails.rtb.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbsubjectid.Focus()
        End If
    End Sub

    Private Sub txtsubjectname_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsubjectname.TextChanged
        ctc.ConvertTextBoxValidValue(txtsubjectname)
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatesubjectbooks = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatesubjectbooks = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatesubjectbooks = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updatesubjectbooks = False Then
            ControlSetBound()
            LoadSubjectID()
            If LSDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadSubjectID()
            LoadSelectedSubject()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region