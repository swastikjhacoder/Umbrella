#Region "Class frmCertificateStudent..."
Public Class frmCertificateStudent
#Region "Declarations..."
    Private ACODE As String = ""
    Private TT As String = ""
    Private DGVRegNo As New DataGridView()
    Private DGVVerifiedBy As New DataGridView()
    Private CertificateExist As Boolean = False
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        ACODE = Indx.LoadCertificateD()
        Dim var As String
        var = CodeIncrement(ACODE)
        Me.txtcertificateid.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("CERT:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        Label1.SetBounds(26, 44, 98, 13)
        Label2.SetBounds(26, 71, 45, 13)
        Label3.SetBounds(26, 98, 93, 13)
        Label4.SetBounds(49, 17, 84, 13)
        Label5.SetBounds(49, 44, 165, 13)
        Label6.SetBounds(49, 71, 74, 13)
        Label7.SetBounds(26, 17, 89, 13)

        cmbdate.SetBounds(139, 14, 143, 21)
        cmbfor.SetBounds(132, 95, 318, 21)
        cmbregid.SetBounds(132, 41, 136, 21)
        cmbverified.SetBounds(220, 41, 62, 21)
        cmbverifiedby.SetBounds(129, 68, 153, 21)

        txtcertificateid.SetBounds(132, 14, 136, 21)
        txtname.SetBounds(132, 68, 318, 21)
    End Sub

    Private Sub LoadRegNo()
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .HeaderText = "Registration No."
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .HeaderText = "Name"
            End With
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .HeaderText = "Course"
            End With

            With DGVRegNo
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
                AddHandler DGVRegNo.CellClick, AddressOf DGVRegNo_CellClick
            End With

            DGVRegNo.Columns.Clear()
            DGVRegNo.Columns.Add(col1)
            DGVRegNo.Columns.Add(col2)
            DGVRegNo.Columns.Add(col3)

            DGVRegNo.Rows.Clear()
            Dim i As Integer = 0
            cmd.CommandText = "select stuid,name,course from StudentRegistration where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                DGVRegNo.Rows.Add()
                DGVRegNo.Rows(i).Cells(0).Value = dr("stuid").ToString()
                DGVRegNo.Rows(i).Cells(1).Value = dr("name").ToString()
                DGVRegNo.Rows(i).Cells(2).Value = dr("course").ToString()
                i = i + 1
            End While
            dr.Close()
            DGVRegNo.ClearSelection()

            cmbregid.AddDataGridView(DGVRegNo, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVRegNo_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVRegNo.CurrentRow.Index
            DGVRegNo.Rows(k).Selected = True
            DGVRegNo.CurrentCell = DGVRegNo.Rows(k).Cells(0)
            StuID = DGVRegNo.Rows(k).Cells(0).Value.ToString()
            StuName = DGVRegNo.Rows(k).Cells(1).Value.ToString()
            cmbregid.Text = StuID
            txtname.Text = StuName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadVerifiedBy()
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .Name = "Col1"
                .HeaderText = "Employee ID"
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .Name = "Col2"
                .HeaderText = "Name"
            End With
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .Name = "Col3"
                .HeaderText = "Designation"
            End With

            With DGVVerifiedBy
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
                AddHandler DGVVerifiedBy.CellClick, AddressOf DGVVerifiedBy_CellClick
            End With

            DGVVerifiedBy.Columns.Clear()
            DGVVerifiedBy.Columns.Add(col1)
            DGVVerifiedBy.Columns.Add(col2)
            DGVVerifiedBy.Columns.Add(col3)

            DGVVerifiedBy.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select empid,name,designation from Employee where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVVerifiedBy.Rows.Add()
                DGVVerifiedBy.Rows(indx).Cells(0).Value = dr("empid").ToString()
                DGVVerifiedBy.Rows(indx).Cells(1).Value = dr("name").ToString()
                DGVVerifiedBy.Rows(indx).Cells(2).Value = dr("designation").ToString()

                indx = indx + 1
            End While
            dr.Close()
            DGVVerifiedBy.ClearSelection()

            cmbverifiedby.AddDataGridView(DGVVerifiedBy, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVVerifiedBy_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVVerifiedBy.CurrentRow.Index
            DGVVerifiedBy.Rows(k).Selected = True
            DGVVerifiedBy.CurrentCell = DGVVerifiedBy.Rows(k).Cells(0)
            EmpName = DGVVerifiedBy.Rows(k).Cells(1).Value.ToString()
            cmbverifiedby.Text = EmpName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetForm()
        updatecertificate = False
        rtbremarks.rtb.Text = ""
        txtname.Text = ""
        cmbdate.Text = ""
        cmbfor.Text = ""
        cmbregid.Text = ""
        cmbverified.Text = ""
        cmbverifiedby.Text = ""
        If ISDAutoID = "Yes" Then
            GetCode()
        Else
            txtcertificateid.Text = ""
        End If
        txtcertificateid.Focus()
    End Sub

    Private Sub AddRecord()
        Try
            If txtcertificateid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter certificate id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtcertificateid.Focus()
                End If
            ElseIf cmbregid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter registration id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbregid.Focus()
                End If
            ElseIf txtname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtname.Focus()
                End If
            ElseIf cmbfor.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select certificate for.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbfor.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    CheckCertificateID()
                    If CertificateExist = False Then
                        Dim cls As New cCertificates()
                        cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtcertificateid.Text, cmbregid.Text, txtname.Text, cmbfor.Text, cmbdate.Text, cmbverified.Text, cmbverifiedby.Text, rtbremarks.rtb.Text)
                        If cls.AddRecordOk = True Then
                            Dim res As DialogResult = MessageBox.Show("Record added successfully", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If res = Windows.Forms.DialogResult.OK Then
                                txtcertificateid.Focus()
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Certificate id already exist." + Environment.NewLine + "Please enter a new certificate id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            txtcertificateid.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If txtcertificateid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter certificate id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtcertificateid.Focus()
                End If
            ElseIf cmbregid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter registration id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbregid.Focus()
                End If
            ElseIf txtname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtname.Focus()
                End If
            ElseIf cmbfor.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select certificate for.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbfor.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cCertificates()
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtcertificateid.Text, cmbregid.Text, txtname.Text, cmbfor.Text, cmbdate.Text, cmbverified.Text, cmbverifiedby.Text, rtbremarks.rtb.Text)
                    If cls.UpdateRecordOk = True Then
                        Dim res As DialogResult = MessageBox.Show("Record updated successfully", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If res = Windows.Forms.DialogResult.OK Then
                            txtcertificateid.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If txtcertificateid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter certificate id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtcertificateid.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cCertificates()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtcertificateid.Text)
                    If cls.DeleteRecordOk = True Then
                        Dim res As DialogResult = MessageBox.Show("Record deleted successfully", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If res = Windows.Forms.DialogResult.OK Then
                            txtcertificateid.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedRecord()
        Try
            cmd.CommandText = "select certificateid,regno,name,certificatefor,issuedate,verified,verifiedby,remarks from StudentCertificate where certificateid='" & certificateid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                txtcertificateid.Text = dr("certificateid").ToString()
                cmbregid.Text = dr("regno").ToString()
                txtname.Text = dr("name").ToString()
                cmbfor.Text = dr("certificatefor").ToString()
                cmbdate.Text = dr("issuedate").ToString()
                cmbverified.Text = dr("verified").ToString()
                cmbverifiedby.Text = dr("verifiedby").ToString()
                rtbremarks.rtb.Text = dr("remarks").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CheckCertificateID()
        Try
            cmd.CommandText = "select * from StudentCertificate where certificateid='" & txtcertificateid.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                CertificateExist = True
            Else
                CertificateExist = False
            End If
            dr.Close()
        Catch ex As Exception
            CertificateExist = False
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmCertificates_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updatecertificate = False Then
            ControlSetBound()
            LoadRegNo()
            LoadVerifiedBy()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            GetCode()
            LoadRegNo()
            LoadVerifiedBy()
            LoadSelectedRecord()
        End If
        If UScertificates = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbdate.Enabled = False
            cmbfor.Enabled = False
            cmbregid.Enabled = False
            cmbverified.Enabled = False
            cmbverifiedby.Enabled = False
            txtcertificateid.ReadOnly = True
            txtname.ReadOnly = True
        End If
    End Sub
#End Region
#Region "Attributes..."
    Private Sub txtcertificateid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcertificateid.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbregid.Focus()
        End If
    End Sub

    Private Sub cmbregid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbregid.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtname.Focus()
        End If
    End Sub

    Private Sub txtname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbfor.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbregid.Focus()
        End If
    End Sub

    Private Sub txtname_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtname.TextChanged
        Dim ctc As New cTextChange()
        ctc.ConvertTextBoxValidValue(txtname)
    End Sub

    Private Sub cmbfor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbfor.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbdate.Focus()
        End If
    End Sub

    Private Sub cmbdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbverified.Focus()
        End If
    End Sub

    Private Sub cmbverified_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbverified.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbverifiedby.Focus()
        End If
    End Sub

    Private Sub cmbverifiedby_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbverifiedby.KeyDown
        If e.KeyCode = Keys.Enter Then
            rtbremarks.rtb.Focus()
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatecertificate = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatecertificate = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatecertificate = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updatecertificate = False Then
            ControlSetBound()
            LoadRegNo()
            LoadVerifiedBy()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            GetCode()
            LoadRegNo()
            LoadVerifiedBy()
            LoadSelectedRecord()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region