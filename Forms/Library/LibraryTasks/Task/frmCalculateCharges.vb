#Region "Imports..."
Imports ESAR_Controls.UIControls.ComboBox
#End Region
#Region "Class frmCalculateCharges..."
Public Class frmCalculateCharges
#Region "Declarations..."
    Private DGVBookLoan As New DataGridView()
    Private DGVRegNo As New DataGridView()
    Private Total As Decimal = 0.0
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(14, 17, 91, 13)
        Label10.SetBounds(24, 280, 55, 13)
        Label11.SetBounds(25, 17, 57, 13)
        Label12.SetBounds(25, 44, 39, 13)
        Label2.SetBounds(14, 44, 99, 13)
        Label3.SetBounds(14, 71, 45, 13)
        Label4.SetBounds(14, 94, 70, 13)
        Label5.SetBounds(14, 34, 138, 13)
        Label6.SetBounds(262, 34, 38, 13)
        Label7.SetBounds(14, 61, 154, 13)
        Label8.SetBounds(14, 277, 146, 13)
        Label9.SetBounds(24, 199, 136, 13)
        lblchargesaccount.SetBounds(119, 17, 0, 13)

        chklockerfees.SetBounds(17, 222, 139, 17)
        chklockerfine.SetBounds(17, 249, 173, 17)
        chklosingbooks.SetBounds(17, 87, 147, 17)
        chklosingcompbooks.SetBounds(17, 141, 182, 17)
        chklosingidcard.SetBounds(17, 195, 156, 17)
        chklosingjournal.SetBounds(17, 114, 159, 17)
        chknewidcard.SetBounds(17, 168, 146, 17)

        cmbaccounttype.SetBounds(160, 196, 134, 21)
        cmbdate.SetBounds(119, 41, 134, 21)
        cmbissueid.SetBounds(119, 14, 134, 21)
        cmbpayvia.SetBounds(79, 277, 134, 22)
        cmbregno.SetBounds(119, 41, 134, 21)

        txtissuedate.SetBounds(119, 94, 70, 14)

        txtbankaccountno.SetBounds(21, 170, 357, 21)
        txtbankaddress.SetBounds(21, 117, 357, 21)
        txtbankbranch.SetBounds(21, 90, 357, 21)
        txtbankname.SetBounds(21, 63, 357, 21)
        txtbranchcode.SetBounds(21, 142, 357, 21)
        txtelectransfer.SetBounds(21, 250, 357, 21)
        txtlatedays.SetBounds(199, 31, 60, 21)
        txtlatefees.SetBounds(199, 58, 60, 21)
        txtlockerfees.SetBounds(199, 220, 60, 21)
        txtlockerfine.SetBounds(199, 247, 60, 21)
        txtlosingbooks.SetBounds(199, 85, 60, 21)
        txtlosingcompbooks.SetBounds(199, 139, 60, 21)
        txtlosingidcard.SetBounds(199, 193, 60, 21)
        txtlosingjournal.SetBounds(199, 112, 60, 21)
        txtmicrcode.SetBounds(21, 223, 357, 21)
        txtname.SetBounds(119, 71, 258, 14)
        txtnewidcard.SetBounds(199, 166, 60, 21)
        txtotherfees.SetBounds(199, 274, 60, 21)
        txtpayeename.SetBounds(21, 36, 357, 21)
        txtreason.SetBounds(265, 274, 112, 21)
    End Sub

    Private Sub LoadBookLoanNo()
        Try
            If DGVBookLoan.Columns.Count > 0 Then
                DGVBookLoan.Rows.Clear()
                DGVBookLoan.Columns.Clear()
            End If

            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .HeaderText = "Issue ID"
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .HeaderText = "Issue Date"
            End With
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .HeaderText = "Registration No"
            End With
            Dim col4 As New DataGridViewTextBoxColumn()
            With col4
                .HeaderText = "Name"
            End With

            With DGVBookLoan
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
                AddHandler DGVBookLoan.CellClick, AddressOf DGVBookLoan_CellClick
            End With

            DGVBookLoan.Columns.Clear()

            DGVBookLoan.Columns.Add(col1)
            DGVBookLoan.Columns.Add(col2)
            DGVBookLoan.Columns.Add(col3)
            DGVBookLoan.Columns.Add(col4)

            DGVBookLoan.Rows.Clear()
            Dim returned As String = "No"
            Dim indx As Integer = 0
            cmd.CommandText = "select issueid,issuedate,issuedtoid,issuedtoname from Issue where returned='" & returned & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                DGVBookLoan.Rows.Add()
                DGVBookLoan.Rows(indx).Cells(0).Value = dr("issueid").ToString()
                DGVBookLoan.Rows(indx).Cells(1).Value = dr("issuedate").ToString()
                DGVBookLoan.Rows(indx).Cells(2).Value = dr("issuedtoid").ToString()
                DGVBookLoan.Rows(indx).Cells(3).Value = dr("issuedtoname").ToString()
                indx = indx + 1
            End While
            dr.Close()
            DGVBookLoan.ClearSelection()

            cmbissueid.AddDataGridView(DGVBookLoan, False)
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub DGVBookLoan_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVBookLoan.CurrentRow.Index
            DGVBookLoan.Rows(k).Selected = True
            DGVBookLoan.CurrentCell = DGVBookLoan.Rows(k).Cells(0)
            IssedID = DGVBookLoan.Rows(k).Cells(0).Value.ToString()
            IssueDate = DGVBookLoan.Rows(k).Cells(1).Value.ToString()
            IssueToID = DGVBookLoan.Rows(k).Cells(2).Value.ToString()
            IssueToName = DGVBookLoan.Rows(k).Cells(3).Value.ToString()
            cmbissueid.Text = IssedID
            cmbregno.Text = IssueToID
            txtname.Text = IssueToName
            txtissuedate.Text = IssueDate
            CalculateLateFees()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadRegNo()
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .Name = "Col1"
                .HeaderText = "Serial No."
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .Name = "Col2"
                .HeaderText = "Name"
            End With
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .Name = "Col3"
                .HeaderText = "Course"
            End With
            Dim col4 As New DataGridViewTextBoxColumn()
            With col4
                .Name = "Col4"
                .HeaderText = "Roll No."
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
            DGVRegNo.Columns.Add(col4)

            DGVRegNo.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select roll,stuid,name,course from StudentRegistration where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVRegNo.Rows.Add()
                DGVRegNo.Rows(indx).Cells(0).Value = dr("stuid").ToString()
                DGVRegNo.Rows(indx).Cells(1).Value = dr("name").ToString()
                DGVRegNo.Rows(indx).Cells(2).Value = dr("course").ToString()
                DGVRegNo.Rows(indx).Cells(3).Value = dr("roll").ToString()

                indx = indx + 1
            End While
            dr.Close()
            DGVRegNo.ClearSelection()

            cmbregno.AddDataGridView(DGVRegNo, False)
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
            crsname = DGVRegNo.Rows(k).Cells(2).Value.ToString()
            cmbregno.Text = StuID
            LoadPaymentDetails(StuID)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadPaymentDetails(ByVal stid As String)
        Try
            cmd.CommandText = "select course,payvia,payeename,bankname,bankbrach,branchaddress,branchcode,accountno,accounttype,micrcode,electronictransfer from StudentRegistration where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and stuid='" & stid & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                crsname = dr("course").ToString()
                txtpayeename.Text = dr("payeename").ToString()
                txtbankname.Text = dr("bankname").ToString()
                txtbankbranch.Text = dr("bankbrach").ToString()
                txtbankaddress.Text = dr("branchaddress").ToString()
                txtbranchcode.Text = dr("branchcode").ToString()
                txtbankaccountno.Text = dr("accountno").ToString()
                cmbaccounttype.Text = dr("accounttype").ToString()
                txtmicrcode.Text = dr("micrcode").ToString()
                txtelectransfer.Text = dr("electronictransfer").ToString()
                cmbpayvia.Text = dr("payvia").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CalculateLateFees()
        Try
            Dim dt As TimeSpan
            dt = Date.Parse(cmbdate.Text) - Date.Parse(txtissuedate.Text)
            txtlatedays.Text = dt.TotalDays.ToString()
            If CInt(txtlatedays.Text) > 0 Then
                cmd.CommandText = "select finerate from BookCharges where course='" & crsname & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                Dim rate As Decimal = cmd.ExecuteScalar
                Dim latefee As Decimal = CDec(txtlatedays.Text) * rate
                txtlatefees.Text = latefee.ToString()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetForm()
        updatecalculatecharge = False
        cmbaccounttype.Text = ""
        cmbdate.Text = UmbrellaSystemDate
        cmbissueid.Text = ""
        cmbpayvia.Text = ""
        cmbregno.Text = ""
        txtissuedate.Text = ""
        txtbankaccountno.Text = ""
        txtbankaddress.Text = ""
        txtbankbranch.Text = ""
        txtbankname.Text = ""
        txtbranchcode.Text = ""
        txtelectransfer.Text = ""
        txtlatedays.Text = ""
        txtlatefees.Text = ""
        txtlockerfees.Text = ""
        txtlockerfine.Text = ""
        txtlosingbooks.Text = ""
        txtlosingcompbooks.Text = ""
        txtlosingidcard.Text = ""
        txtlosingjournal.Text = ""
        txtmicrcode.Text = ""
        txtname.Text = ""
        txtnewidcard.Text = ""
        txtotherfees.Text = ""
        txtpayeename.Text = ""
        txtreason.Text = ""
        cmbissueid.Focus()
    End Sub

    Private Sub AddRecord()
        Try
            Dim latedays As Integer = 0
            Dim TotalCharges As Decimal = 0.0
            Dim latefees As Decimal = 0.0
            Dim losingbooks As Decimal = 0.0
            Dim losingjournal As Decimal = 0.0
            Dim losingcompbooks As Decimal = 0.0
            Dim newidcard As Decimal = 0.0
            Dim losingidcard As Decimal = 0.0
            Dim lockerfees As Decimal = 0.0
            Dim lockerfine As Decimal = 0.0
            Dim otherfees As Decimal = 0.0

            If txtlatedays.Text = "" Then
                latedays = 0
            Else
                latedays = CInt(txtlatedays.Text)
            End If
            If txtlatefees.Text = "" Then
                latefees = 0.0
            Else
                latefees = CDec(txtlatefees.Text)
            End If
            If txtlosingbooks.Text = "" Then
                losingbooks = 0.0
            Else
                losingbooks = CDec(txtlosingbooks.Text)
            End If
            If txtlosingjournal.Text = "" Then
                losingjournal = 0.0
            Else
                losingjournal = CDec(txtlosingjournal.Text)
            End If
            If txtlosingcompbooks.Text = "" Then
                losingcompbooks = 0.0
            Else
                losingcompbooks = CDec(txtlosingcompbooks.Text)
            End If
            If txtnewidcard.Text = "" Then
                newidcard = 0.0
            Else
                newidcard = CDec(txtnewidcard.Text)
            End If
            If txtlosingidcard.Text = "" Then
                losingidcard = 0.0
            Else
                losingidcard = CDec(txtlosingidcard.Text)
            End If
            If txtlockerfees.Text = "" Then
                lockerfees = 0.0
            Else
                lockerfees = CDec(txtlockerfees.Text)
            End If
            If txtlockerfine.Text = "" Then
                lockerfine = 0.0
            Else
                lockerfine = CDec(txtlockerfine.Text)
            End If
            If txtotherfees.Text = "" Then
                otherfees = 0.0
            Else
                otherfees = CDec(txtotherfees.Text)
            End If

            TotalCharges = latefees + losingbooks + losingjournal + losingcompbooks + newidcard + losingidcard + lockerfees + lockerfine + otherfees

            If cmbregno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbregno.Focus()
                End If
            ElseIf cmbdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbdate.Focus()
                End If
            ElseIf TotalCharges <= 0 Then
                Dim result As DialogResult = MessageBox.Show("Please enter charges.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cCharges()
                    cls.AddLibraryCharges(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbdate.Text, cmbissueid.Text, txtissuedate.Text, cmbregno.Text, txtname.Text, latedays, latefees, losingbooks, losingjournal, losingcompbooks, newidcard, losingidcard, lockerfees, lockerfine, otherfees, txtreason.Text, TotalCharges, txtpayeename.Text, txtbankname.Text, txtbankbranch.Text, txtbankaddress.Text, txtbranchcode.Text, txtbankaccountno.Text, cmbaccounttype.Text, txtmicrcode.Text, txtelectransfer.Text, cmbpayvia.Text, LSDChargesAccount)
                    If cls.AddLibraryChargesOk = True Then
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & TotalCharges & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & LSDChargesAccount & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        Dim result1 As DialogResult = MessageBox.Show("Record added successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            cmbissueid.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            Dim latedays As Integer = 0
            Dim TotalCharges As Decimal = 0.0
            Dim latefees As Decimal = 0.0
            Dim losingbooks As Decimal = 0.0
            Dim losingjournal As Decimal = 0.0
            Dim losingcompbooks As Decimal = 0.0
            Dim newidcard As Decimal = 0.0
            Dim losingidcard As Decimal = 0.0
            Dim lockerfees As Decimal = 0.0
            Dim lockerfine As Decimal = 0.0
            Dim otherfees As Decimal = 0.0

            If txtlatedays.Text = "" Then
                latedays = 0
            Else
                latedays = CInt(txtlatedays.Text)
            End If
            If txtlatefees.Text = "" Then
                latefees = 0.0
            Else
                latefees = CDec(txtlatefees.Text)
            End If
            If txtlosingbooks.Text = "" Then
                losingbooks = 0.0
            Else
                losingbooks = CDec(txtlosingbooks.Text)
            End If
            If txtlosingjournal.Text = "" Then
                losingjournal = 0.0
            Else
                losingjournal = CDec(txtlosingjournal.Text)
            End If
            If txtlosingcompbooks.Text = "" Then
                losingcompbooks = 0.0
            Else
                losingcompbooks = CDec(txtlosingcompbooks.Text)
            End If
            If txtnewidcard.Text = "" Then
                newidcard = 0.0
            Else
                newidcard = CDec(txtnewidcard.Text)
            End If
            If txtlosingidcard.Text = "" Then
                losingidcard = 0.0
            Else
                losingidcard = CDec(txtlosingidcard.Text)
            End If
            If txtlockerfees.Text = "" Then
                lockerfees = 0.0
            Else
                lockerfees = CDec(txtlockerfees.Text)
            End If
            If txtlockerfine.Text = "" Then
                lockerfine = 0.0
            Else
                lockerfine = CDec(txtlockerfine.Text)
            End If
            If txtotherfees.Text = "" Then
                otherfees = 0.0
            Else
                otherfees = CDec(txtotherfees.Text)
            End If

            TotalCharges = latefees + losingbooks + losingjournal + losingcompbooks + newidcard + losingidcard + lockerfees + lockerfine + otherfees

            If cmbregno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbregno.Focus()
                End If
            ElseIf cmbdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbdate.Focus()
                End If
            ElseIf TotalCharges <= 0 Then
                Dim result As DialogResult = MessageBox.Show("Please enter charges.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cCharges()
                    cls.UpdateLibraryCharges(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbdate.Text, cmbissueid.Text, txtissuedate.Text, cmbregno.Text, txtname.Text, latedays, latefees, losingbooks, losingjournal, losingcompbooks, newidcard, losingidcard, lockerfees, lockerfine, otherfees, txtreason.Text, TotalCharges, txtpayeename.Text, txtbankname.Text, txtbankbranch.Text, txtbankaddress.Text, txtbranchcode.Text, txtbankaccountno.Text, cmbaccounttype.Text, txtmicrcode.Text, txtelectransfer.Text, cmbpayvia.Text, LSDChargesAccount, Total)
                    If cls.UpdateLibraryChargesOk = True Then
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & Total & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & LSDChargesAccount & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & TotalCharges & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & LSDChargesAccount & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            totallibrarycharge = TotalCharges
                            LoadSelectedCharges()
                            cmbissueid.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            Dim latedays As Integer = 0
            Dim TotalCharges As Decimal = 0.0
            Dim latefees As Decimal = 0.0
            Dim losingbooks As Decimal = 0.0
            Dim losingjournal As Decimal = 0.0
            Dim losingcompbooks As Decimal = 0.0
            Dim newidcard As Decimal = 0.0
            Dim losingidcard As Decimal = 0.0
            Dim lockerfees As Decimal = 0.0
            Dim lockerfine As Decimal = 0.0
            Dim otherfees As Decimal = 0.0

            If txtlatedays.Text = "" Then
                latedays = 0
            Else
                latedays = CInt(txtlatedays.Text)
            End If
            If txtlatefees.Text = "" Then
                latefees = 0.0
            Else
                latefees = CDec(txtlatefees.Text)
            End If
            If txtlosingbooks.Text = "" Then
                losingbooks = 0.0
            Else
                losingbooks = CDec(txtlosingbooks.Text)
            End If
            If txtlosingjournal.Text = "" Then
                losingjournal = 0.0
            Else
                losingjournal = CDec(txtlosingjournal.Text)
            End If
            If txtlosingcompbooks.Text = "" Then
                losingcompbooks = 0.0
            Else
                losingcompbooks = CDec(txtlosingcompbooks.Text)
            End If
            If txtnewidcard.Text = "" Then
                newidcard = 0.0
            Else
                newidcard = CDec(txtnewidcard.Text)
            End If
            If txtlosingidcard.Text = "" Then
                losingidcard = 0.0
            Else
                losingidcard = CDec(txtlosingidcard.Text)
            End If
            If txtlockerfees.Text = "" Then
                lockerfees = 0.0
            Else
                lockerfees = CDec(txtlockerfees.Text)
            End If
            If txtlockerfine.Text = "" Then
                lockerfine = 0.0
            Else
                lockerfine = CDec(txtlockerfine.Text)
            End If
            If txtotherfees.Text = "" Then
                otherfees = 0.0
            Else
                otherfees = CDec(txtotherfees.Text)
            End If

            TotalCharges = latefees + losingbooks + losingjournal + losingcompbooks + newidcard + losingidcard + lockerfees + lockerfine + otherfees

            If cmbregno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbregno.Focus()
                End If
            ElseIf cmbdate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbdate.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cCharges()
                    cls.DeleteLibraryCharges(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbdate.Text, cmbissueid.Text, txtissuedate.Text, cmbregno.Text, txtname.Text, TotalCharges)
                    If cls.DeleteLibraryChargesOk = True Then
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & Total & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & LSDChargesAccount & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        Dim result1 As DialogResult = MessageBox.Show("Record deleted successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            ResetForm()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedCharges()
        Try
            Dim account As String = ""
            Dim accounttype As String = ""
            Dim dte As String = ""
            Dim issid As String = ""
            Dim payvia As String = ""
            Dim regno As String = ""
            Dim issuedte As String = ""
            cmd.CommandText = "select * from LibraryCharges where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and date='" & chargedate & "' and issueid='" & IssedID & "' and regno='" & StuID & "' and name='" & StuName & "' and totalcharges=" & totallibrarycharge & ""
            dr = cmd.ExecuteReader
            If dr.Read() Then
                account = dr("account").ToString()
                accounttype = dr("accounttype").ToString()
                dte = dr("date").ToString()
                issid = dr("issueid").ToString()
                payvia = dr("payvia").ToString()
                regno = dr("regno").ToString()
                issuedte = dr("issuedate").ToString()
                txtbankaccountno.Text = dr("bankaccountno").ToString()
                txtbankaddress.Text = dr("branchaddress").ToString()
                txtbankbranch.Text = dr("bankbranch").ToString()
                txtbankname.Text = dr("bankname").ToString()
                txtbranchcode.Text = dr("branchcode").ToString()
                txtelectransfer.Text = dr("electransfer").ToString()
                Dim latedays As Integer = CInt(dr("latedays").ToString())
                If latedays = 0 Then
                    txtlatedays.Text = ""
                Else
                    txtlatedays.Text = latedays
                End If
                Dim latefees As Decimal = CDec(dr("latefees").ToString())
                If latefees = 0.0 Then
                    txtlatefees.Text = ""
                Else
                    txtlatefees.Text = latefees
                End If
                Dim lockerfees As Decimal = CDec(dr("lockerfees").ToString())
                If lockerfees = 0.0 Then
                    txtlockerfees.Text = ""
                Else
                    txtlockerfees.Text = lockerfees
                End If
                Dim lockerfine As Decimal = CDec(dr("lockerfine").ToString())
                If lockerfine = 0.0 Then
                    txtlockerfine.Text = ""
                Else
                    txtlockerfine.Text = lockerfine
                End If
                Dim losingbooks As Decimal = CDec(dr("losingbooks").ToString())
                If losingbooks = 0.0 Then
                    txtlosingbooks.Text = ""
                Else
                    txtlosingbooks.Text = losingbooks
                End If
                Dim losingcompbooks As Decimal = CDec(dr("losingcompbooks").ToString())
                If losingcompbooks = 0.0 Then
                    txtlosingcompbooks.Text = ""
                Else
                    txtlosingcompbooks.Text = losingcompbooks
                End If
                Dim losingidcard As Decimal = CDec(dr("losingidcard").ToString())
                If losingidcard = 0.0 Then
                    txtlosingidcard.Text = ""
                Else
                    txtlosingidcard.Text = losingidcard
                End If
                Dim losingjournal As Decimal = CDec(dr("losingjournal").ToString())
                If losingjournal = 0.0 Then
                    txtlosingjournal.Text = ""
                Else
                    txtlosingjournal.Text = losingjournal
                End If
                txtmicrcode.Text = dr("micrcode").ToString()
                txtname.Text = dr("name").ToString()
                Dim newidcard As Decimal = CDec(dr("newidcard").ToString())
                If newidcard = 0.0 Then
                    txtnewidcard.Text = ""
                Else
                    txtnewidcard.Text = newidcard
                End If
                Dim otherfees As Decimal = CDec(dr("otherfees").ToString())
                If otherfees = 0.0 Then
                    txtotherfees.Text = ""
                Else
                    txtotherfees.Text = otherfees
                End If
                txtpayeename.Text = dr("payeename").ToString()
                txtreason.Text = dr("reason").ToString()
                Total = latefees + lockerfees + lockerfine + losingbooks + losingcompbooks + losingidcard + losingjournal + newidcard + otherfees
            End If
            dr.Close()
            cmbaccounttype.Text = accounttype
            cmbdate.Text = dte
            cmbissueid.Text = issid
            cmbpayvia.Text = payvia
            cmbregno.Text = regno
            txtissuedate.Text = issuedte
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmCalculateCharges_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updatecalculatecharge = False Then
            cmbdate.Text = UmbrellaSystemDate
            ControlSetBound()
            lblchargesaccount.Text = LSDChargesAccount
            LoadBookLoanNo()
            LoadRegNo()
            cmbpayvia.Items.Add(New ComboBoxIconItem("Cash", 0))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Check", 1))
        Else
            ControlSetBound()
            lblchargesaccount.Text = LSDChargesAccount
            LoadBookLoanNo()
            LoadRegNo()
            cmbpayvia.Items.Add(New ComboBoxIconItem("Cash", 0))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Check", 1))
            LoadSelectedCharges()
        End If
        If UScharges = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbaccounttype.Enabled = False
            cmbdate.Enabled = False
            cmbissueid.Enabled = False
            cmbpayvia.Enabled = False
            cmbregno.Enabled = False
            txtbankaccountno.ReadOnly = True
            txtbankaddress.ReadOnly = True
            txtbankbranch.ReadOnly = True
            txtbankname.ReadOnly = True
            txtbranchcode.ReadOnly = True
            txtelectransfer.ReadOnly = True
            txtissuedate.ReadOnly = True
            txtlatedays.ReadOnly = True
            txtlatefees.ReadOnly = True
            txtlockerfees.ReadOnly = True
            txtlockerfine.ReadOnly = True
            txtlosingbooks.ReadOnly = True
            txtlosingcompbooks.ReadOnly = True
            txtlosingidcard.ReadOnly = True
            txtlosingjournal.ReadOnly = True
            txtmicrcode.ReadOnly = True
            txtname.ReadOnly = True
            txtnewidcard.ReadOnly = True
            txtotherfees.ReadOnly = True
            txtpayeename.ReadOnly = True
            txtreason.ReadOnly = True
            chklockerfees.Enabled = False
            chklockerfine.Enabled = False
            chklosingbooks.Enabled = False
            chklosingcompbooks.Enabled = False
            chklosingidcard.Enabled = False
            chklosingjournal.Enabled = False
            chknewidcard.Enabled = False
        End If
    End Sub
#End Region
#Region "Attributes..."
    Private Sub cmbissueid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbissueid.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbregno.Focus()
        End If
    End Sub

    Private Sub cmbregno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbregno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtname.Focus()
        End If
    End Sub

    Private Sub cmbregno_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbregno.TextChanged
        If cmbregno.Text <> "" Then
            LoadPaymentDetails(cmbregno.Text)
        End If
    End Sub

    Private Sub txtname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtissuedate.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbregno.Focus()
        End If
    End Sub

    Private Sub txtissuedate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtissuedate.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtlatedays.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtname.Focus()
        End If
    End Sub

    Private Sub txtlatedays_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlatedays.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtlatefees.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtissuedate.Focus()
        End If
    End Sub

    Private Sub txtlatefees_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlatefees.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtlosingbooks.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtlatedays.Focus()
        End If
    End Sub

    Private Sub txtlosingbooks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlosingbooks.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtlosingjournal.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtlatefees.Focus()
        End If
    End Sub

    Private Sub txtlosingjournal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlosingjournal.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtlosingcompbooks.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtlosingbooks.Focus()
        End If
    End Sub

    Private Sub txtlosingcompbooks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlosingcompbooks.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtnewidcard.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtlosingjournal.Focus()
        End If
    End Sub

    Private Sub txtnewidcard_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnewidcard.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtlosingidcard.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtlosingcompbooks.Focus()
        End If
    End Sub

    Private Sub txtlosingidcard_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlosingidcard.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtlockerfees.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtnewidcard.Focus()
        End If
    End Sub

    Private Sub txtlockerfees_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlockerfees.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtlockerfine.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtlosingidcard.Focus()
        End If
    End Sub

    Private Sub txtlockerfine_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlockerfine.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtotherfees.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtlockerfees.Focus()
        End If
    End Sub

    Private Sub txtotherfees_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtotherfees.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtreason.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtlockerfine.Focus()
        End If
    End Sub

    Private Sub txtreason_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtreason.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtpayeename.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtotherfees.Focus()
        End If
    End Sub

    Private Sub txtpayeename_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpayeename.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtbankname.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtreason.Focus()
        End If
    End Sub

    Private Sub txtbankname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbankname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtbankbranch.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtpayeename.Focus()
        End If
    End Sub

    Private Sub txtbankbranch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbankbranch.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtbankaddress.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtbankname.Focus()
        End If
    End Sub

    Private Sub txtbankaddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbankaddress.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtbranchcode.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtbankbranch.Focus()
        End If
    End Sub

    Private Sub txtbranchcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbranchcode.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtbankaccountno.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtbankaddress.Focus()
        End If
    End Sub

    Private Sub txtbankaccountno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbankaccountno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbaccounttype.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtbranchcode.Focus()
        End If
    End Sub

    Private Sub cmbaccounttype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbaccounttype.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtmicrcode.Focus()
        End If
    End Sub

    Private Sub txtmicrcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmicrcode.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtelectransfer.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbaccounttype.Focus()
        End If
    End Sub

    Private Sub txtelectransfer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtelectransfer.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbpayvia.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtmicrcode.Focus()
        End If
    End Sub

    Private Sub cmbpayvia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbpayvia.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbdate.Focus()
        End If
    End Sub

    Private Sub chklosingbooks_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklosingbooks.CheckedChanged
        If chklosingbooks.Checked = False Then
            txtlosingbooks.Text = ""
        End If
    End Sub

    Private Sub chklosingjournal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklosingjournal.CheckedChanged
        Try
            If chklosingjournal.Checked = True Then
                cmd.CommandText = "select losingjournalcharge from BookCharges where course='" & crsname & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                Dim val As Decimal = cmd.ExecuteScalar
                txtlosingjournal.Text = val.ToString()
                cmd.Dispose()
            Else
                txtlosingjournal.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chklosingcompbooks_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklosingcompbooks.CheckedChanged
        If chklosingcompbooks.Checked = False Then
            txtlosingcompbooks.Text = ""
        End If
    End Sub

    Private Sub chknewidcard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chknewidcard.CheckedChanged
        Try
            If chknewidcard.Checked = True Then
                cmd.CommandText = "select idcardcharge from BookCharges where course='" & crsname & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                Dim val As Decimal = cmd.ExecuteScalar
                txtnewidcard.Text = val.ToString()
                cmd.Dispose()
            Else
                txtnewidcard.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chklosingidcard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklosingidcard.CheckedChanged
        Try
            If chklosingidcard.Checked = True Then
                cmd.CommandText = "select losingcardcharge from BookCharges where course='" & crsname & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                Dim val As Decimal = cmd.ExecuteScalar
                txtlosingidcard.Text = val.ToString()
                cmd.Dispose()
            Else
                txtlosingidcard.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chklockerfees_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklockerfees.CheckedChanged
        Try
            If chklockerfees.Checked = True Then
                cmd.CommandText = "select lockerfees from BookCharges where course='" & crsname & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                Dim val As Decimal = cmd.ExecuteScalar
                txtlockerfees.Text = val.ToString()
                cmd.Dispose()
            Else
                txtlockerfees.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chklockerfine_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklockerfine.CheckedChanged
        Try
            If chklockerfine.Checked = True Then
                cmd.CommandText = "select lockerfine from BookCharges where course='" & crsname & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                Dim val As Decimal = cmd.ExecuteScalar
                txtlockerfine.Text = val.ToString()
                cmd.Dispose()
            Else
                txtlockerfine.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtlosingbooks_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlosingbooks.TextChanged
        If txtlosingbooks.Text.Trim() <> "" Then
            If CDec(txtlosingbooks.Text) > 0 Then
                chklosingbooks.Checked = True
            Else
                chklosingbooks.Checked = False
            End If
        End If
    End Sub

    Private Sub txtlosingjournal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlosingjournal.TextChanged
        If txtlosingjournal.Text.Trim() <> "" Then
            If CDec(txtlosingjournal.Text) > 0 Then
                chklosingjournal.Checked = True
            Else
                chklosingjournal.Checked = False
            End If
        End If
    End Sub

    Private Sub txtlosingcompbooks_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlosingcompbooks.TextChanged
        If txtlosingcompbooks.Text.Trim() <> "" Then
            If CDec(txtlosingcompbooks.Text) > 0 Then
                chklosingcompbooks.Checked = True
            Else
                chklosingcompbooks.Checked = False
            End If
        End If
    End Sub

    Private Sub txtnewidcard_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnewidcard.TextChanged
        If txtnewidcard.Text.Trim() <> "" Then
            If CDec(txtnewidcard.Text) > 0 Then
                chknewidcard.Checked = True
            Else
                chknewidcard.Checked = False
            End If
        End If
    End Sub

    Private Sub txtlosingidcard_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlosingidcard.TextChanged
        If txtlosingidcard.Text.Trim() <> "" Then
            If CDec(txtlosingidcard.Text) > 0 Then
                chklosingidcard.Checked = True
            Else
                chklosingidcard.Checked = False
            End If
        End If
    End Sub

    Private Sub txtlockerfees_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlockerfees.TextChanged
        If txtlockerfees.Text.Trim() <> "" Then
            If CDec(txtlockerfees.Text) > 0 Then
                chklockerfees.Checked = True
            Else
                chklockerfees.Checked = False
            End If
        End If
    End Sub

    Private Sub txtlockerfine_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlockerfine.TextChanged
        If txtlockerfine.Text.Trim() <> "" Then
            If CDec(txtlockerfine.Text) > 0 Then
                chklockerfine.Checked = True
            Else
                chklockerfine.Checked = False
            End If
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatecalculatecharge = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatecalculatecharge = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatecalculatecharge = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updatecalculatecharge = False Then
            cmbdate.Text = UmbrellaSystemDate
            ControlSetBound()
            lblchargesaccount.Text = LSDChargesAccount
            LoadBookLoanNo()
            LoadRegNo()
        Else
            ControlSetBound()
            lblchargesaccount.Text = LSDChargesAccount
            LoadBookLoanNo()
            LoadRegNo()
            LoadSelectedCharges()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region