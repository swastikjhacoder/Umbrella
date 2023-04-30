﻿#Region "Class frmCertificateEmployee..."
Public Class frmCertificateEmployee
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
        Label4.SetBounds(43, 17, 84, 13)
        Label5.SetBounds(43, 44, 165, 13)
        Label6.SetBounds(43, 71, 74, 13)
        Label7.SetBounds(26, 17, 89, 13)
        Label8.SetBounds(43, 98, 80, 13)

        cmbdate.SetBounds(139, 14, 143, 21)
        cmbfor.SetBounds(132, 95, 318, 21)
        cmbregid.SetBounds(132, 41, 136, 21)
        cmbverified.SetBounds(220, 41, 62, 21)
        cmbverifiedby.SetBounds(129, 68, 153, 21)

        txtcertificateid.SetBounds(132, 14, 136, 21)
        txtname.SetBounds(132, 68, 318, 21)
        txtworkingfor.SetBounds(129, 95, 153, 21)
    End Sub

    Private Sub LoadRegNo()
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

            Dim indx As Integer = 0
            cmd.CommandText = "select empid,name,designation from Employee where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVRegNo.Rows.Add()
                DGVRegNo.Rows(indx).Cells(0).Value = dr("empid").ToString()
                DGVRegNo.Rows(indx).Cells(1).Value = dr("name").ToString()
                DGVRegNo.Rows(indx).Cells(2).Value = dr("designation").ToString()

                indx = indx + 1
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
            EmpRegNo = DGVRegNo.Rows(k).Cells(0).Value.ToString()
            EmpName = DGVRegNo.Rows(k).Cells(1).Value.ToString()
            cmbregid.Text = EmpRegNo
            txtname.Text = EmpName
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
        dgviewschooltype.Rows.Clear()
        dgviewtype.Rows.Clear()
        LoadDataGridValues()
        txtname.Text = ""
        txtworkingfor.Text = ""
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

    Private Sub LoadDataGridValues()
        Try
            dgviewschooltype.Rows.Clear()
            dgviewschooltype.Rows.Add()
            dgviewschooltype.Rows.Add()
            dgviewschooltype.Rows.Add()
            dgviewschooltype.Rows.Add()
            dgviewschooltype.Rows.Add()
            dgviewschooltype.Rows.Add()
            dgviewschooltype.Rows(0).Cells(0).Value = "Kindergarten:"
            dgviewschooltype.Rows(1).Cells(0).Value = "Elementary School:"
            dgviewschooltype.Rows(2).Cells(0).Value = "Lower Secondary School:"
            dgviewschooltype.Rows(3).Cells(0).Value = "Higher Secondary School:"
            dgviewschooltype.Rows(4).Cells(0).Value = "College:"
            dgviewschooltype.Rows(5).Cells(0).Value = "University:"
            dgviewschooltype.Rows(0).Cells(1).Value = ""
            dgviewschooltype.Rows(1).Cells(1).Value = ""
            dgviewschooltype.Rows(2).Cells(1).Value = ""
            dgviewschooltype.Rows(3).Cells(1).Value = ""
            dgviewschooltype.Rows(4).Cells(1).Value = ""
            dgviewschooltype.Rows(5).Cells(1).Value = ""

            dgviewtype.Rows.Clear()
            dgviewtype.Rows.Add()
            dgviewtype.Rows.Add()
            dgviewtype.Rows.Add()
            dgviewtype.Rows(0).Cells(0).Value = "Special Needs School:"
            dgviewtype.Rows(1).Cells(0).Value = "Special Needs College:"
            dgviewtype.Rows(2).Cells(0).Value = "Special Needs University:"
            dgviewtype.Rows(0).Cells(1).Value = ""
            dgviewtype.Rows(1).Cells(1).Value = ""
            dgviewtype.Rows(2).Cells(1).Value = ""

            For row1 As Integer = 0 To dgviewschooltype.Rows.Count - 1
                dgviewschooltype.Rows(row1).Cells(0).Style.BackColor = Color.DimGray
                dgviewschooltype.Rows(row1).Cells(0).Style.ForeColor = Color.White
                dgviewschooltype.Rows(row1).Cells(0).Style.SelectionBackColor = Color.DimGray
                dgviewschooltype.Rows(row1).Cells(0).Style.SelectionForeColor = Color.White
            Next

            For row2 As Integer = 0 To dgviewtype.Rows.Count - 1
                dgviewtype.Rows(row2).Cells(0).Style.BackColor = Color.DimGray
                dgviewtype.Rows(row2).Cells(0).Style.ForeColor = Color.White
                dgviewtype.Rows(row2).Cells(0).Style.SelectionBackColor = Color.DimGray
                dgviewtype.Rows(row2).Cells(0).Style.SelectionForeColor = Color.White
            Next
            dgviewschooltype.ClearSelection()
            dgviewtype.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CalculateWorkingFor(ByVal regno As String)
        Try
            Dim WorkingFor As String
            cmd.CommandText = "select joiningdate from Employee where empid='" & regno & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            WorkingFor = dr("joiningdate").ToString()
            dr.Close()
            Dim str As String = WorkingFor + " 00:00:00"
            Dim doj As Date = Date.Parse(str)
            Dim dob As DateTime
            dob = New DateTime(doj.Year, doj.Month, doj.Day)
            Dim tday As TimeSpan = DateTime.Now.Subtract(dob)
            Dim years As Integer, months As Integer, days As Integer
            months = 12 * (DateTime.Now.Year - dob.Year) + (DateTime.Now.Month - dob.Month)

            If DateTime.Now.Day < dob.Day Then
                months -= 1
                days = DateTime.DaysInMonth(dob.Year, dob.Month) - dob.Day + DateTime.Now.Day
            Else
                days = DateTime.Now.Day - dob.Day
            End If
            years = Math.Floor(months / 12)
            months -= years * 12
            txtworkingfor.Text = years.ToString() + " Years, " + months.ToString() + " Months"
        Catch ex As Exception

        End Try
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
                        Dim shoolltype1 As String = dgviewschooltype.Rows(0).Cells(1).Value.ToString()
                        Dim shoolltype2 As String = dgviewschooltype.Rows(1).Cells(1).Value.ToString()
                        Dim shoolltype3 As String = dgviewschooltype.Rows(2).Cells(1).Value.ToString()
                        Dim shoolltype4 As String = dgviewschooltype.Rows(3).Cells(1).Value.ToString()
                        Dim shoolltype5 As String = dgviewschooltype.Rows(4).Cells(1).Value.ToString()
                        Dim shoolltype6 As String = dgviewschooltype.Rows(5).Cells(1).Value.ToString()
                        Dim typee1 As String = dgviewtype.Rows(0).Cells(1).Value.ToString()
                        Dim typee2 As String = dgviewtype.Rows(1).Cells(1).Value.ToString()
                        Dim typee3 As String = dgviewtype.Rows(2).Cells(1).Value.ToString()
                        cls.AddEmployeeRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtcertificateid.Text, cmbregid.Text, txtname.Text, cmbfor.Text, cmbdate.Text, cmbverified.Text, cmbverifiedby.Text, shoolltype1, shoolltype2, shoolltype3, shoolltype4, shoolltype5, shoolltype6, typee1, typee2, typee3, txtworkingfor.Text)
                        If cls.AddEmployeeRecordOk = True Then
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
                    Dim shoolltype1 As String = dgviewschooltype.Rows(0).Cells(1).Value.ToString()
                    Dim shoolltype2 As String = dgviewschooltype.Rows(1).Cells(1).Value.ToString()
                    Dim shoolltype3 As String = dgviewschooltype.Rows(2).Cells(1).Value.ToString()
                    Dim shoolltype4 As String = dgviewschooltype.Rows(3).Cells(1).Value.ToString()
                    Dim shoolltype5 As String = dgviewschooltype.Rows(4).Cells(1).Value.ToString()
                    Dim shoolltype6 As String = dgviewschooltype.Rows(5).Cells(1).Value.ToString()
                    Dim typee1 As String = dgviewtype.Rows(0).Cells(1).Value.ToString()
                    Dim typee2 As String = dgviewtype.Rows(1).Cells(1).Value.ToString()
                    Dim typee3 As String = dgviewtype.Rows(2).Cells(1).Value.ToString()
                    cls.UpdateEmployeeRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtcertificateid.Text, cmbregid.Text, txtname.Text, cmbfor.Text, cmbdate.Text, cmbverified.Text, cmbverifiedby.Text, shoolltype1, shoolltype2, shoolltype3, shoolltype4, shoolltype5, shoolltype6, typee1, typee2, typee3, txtworkingfor.Text)
                    If cls.UpdateEmployeeRecordOk = True Then
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
                    cls.DeleteEmployeeRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtcertificateid.Text)
                    If cls.DeleteEmployeeRecordOk = True Then
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
            cmd.CommandText = "select certificateid,regno,name,certificatefor,issuedate,verified,verifiedby,workingfor,schooltype1,schooltype2,schooltype3,schooltype4,schooltype5,schooltype6,type1,type2,type3 from EmployeeCertificate where certificateid='" & certificateid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                txtcertificateid.Text = dr("certificateid").ToString()
                cmbregid.Text = dr("regno").ToString()
                txtname.Text = dr("name").ToString()
                cmbfor.Text = dr("certificatefor").ToString()
                cmbdate.Text = dr("issuedate").ToString()
                cmbverified.Text = dr("verified").ToString()
                cmbverifiedby.Text = dr("verifiedby").ToString()
                txtworkingfor.Text = dr("workingfor").ToString()
                dgviewschooltype.Rows(0).Cells(1).Value = dr("schooltype1").ToString()
                dgviewschooltype.Rows(1).Cells(1).Value = dr("schooltype2").ToString()
                dgviewschooltype.Rows(2).Cells(1).Value = dr("schooltype3").ToString()
                dgviewschooltype.Rows(3).Cells(1).Value = dr("schooltype4").ToString()
                dgviewschooltype.Rows(4).Cells(1).Value = dr("schooltype5").ToString()
                dgviewschooltype.Rows(5).Cells(1).Value = dr("schooltype6").ToString()
                dgviewtype.Rows(0).Cells(1).Value = dr("type1").ToString()
                dgviewtype.Rows(1).Cells(1).Value = dr("type2").ToString()
                dgviewtype.Rows(2).Cells(1).Value = dr("type3").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CheckCertificateID()
        Try
            cmd.CommandText = "select * from EmployeeCertificate where certificateid='" & txtcertificateid.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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

    Private Sub cmbregid_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbregid.TextChanged
        If cmbregid.Text <> "" Then
            CalculateWorkingFor(cmbregid.Text)
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
            txtworkingfor.Focus()
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
            LoadDataGridValues()
            LoadRegNo()
            LoadVerifiedBy()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadDataGridValues()
            GetCode()
            LoadRegNo()
            LoadVerifiedBy()
            LoadSelectedRecord()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmCertificateEmployee_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updatecertificate = False Then
            ControlSetBound()
            LoadDataGridValues()
            LoadRegNo()
            LoadVerifiedBy()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadDataGridValues()
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
            txtworkingfor.ReadOnly = True
            dgviewschooltype.Enabled = False
            dgviewtype.Enabled = False
        End If
    End Sub
#End Region
End Class
#End Region