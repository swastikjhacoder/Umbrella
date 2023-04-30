#Region "Imports..."
Imports ESAR_Controls.UIControls.TextBox
#End Region
#Region "Class frmWorkingHours..."
Public Class frmWorkingHours
#Region "Declarations..."
    Private DGVRegNo As New DataGridView()
    Private PayInfo As String = ""
    Private Dates(6) As String
    Private StartTime(6) As String
    Private EndTime(6) As String
    Private TotalMinutes(6) As Integer
    Private DT(6) As TimeSpan
    Private PresentAbsent(6) As String
#End Region
#Region "Methods..."
    Private Sub ControlSetBound()
        Label1.SetBounds(261, 16, 53, 13)
        Label10.SetBounds(14, 144, 55, 13)
        Label11.SetBounds(214, 171, 75, 13)
        Label12.SetBounds(14, 171, 51, 13)
        Label13.SetBounds(14, 16, 41, 13)
        Label14.SetBounds(247, 8, 65, 13)
        Label15.SetBounds(247, 34, 65, 13)
        Label16.SetBounds(247, 60, 65, 13)
        Label17.SetBounds(99, 165, 72, 13)
        Label18.SetBounds(247, 165, 65, 13)
        Label19.SetBounds(391, 165, 174, 13)
        Label2.SetBounds(14, 36, 45, 13)
        Label20.SetBounds(391, 139, 174, 13)
        Label21.SetBounds(391, 113, 174, 13)
        Label22.SetBounds(391, 86, 174, 13)
        Label23.SetBounds(247, 86, 65, 13)
        Label24.SetBounds(247, 113, 65, 13)
        Label25.SetBounds(247, 139, 65, 13)
        Label26.SetBounds(99, 139, 72, 13)
        Label27.SetBounds(99, 113, 72, 13)
        Label28.SetBounds(99, 86, 72, 13)
        Label29.SetBounds(99, 60, 72, 13)
        Label3.SetBounds(14, 63, 34, 13)
        Label30.SetBounds(99, 34, 72, 13)
        Label31.SetBounds(99, 8, 72, 13)
        Label32.SetBounds(391, 60, 174, 13)
        Label33.SetBounds(391, 34, 174, 13)
        Label34.SetBounds(391, 8, 174, 13)
        Label4.SetBounds(214, 63, 38, 13)
        Label44.SetBounds(141, 16, 25, 13)
        Label5.SetBounds(14, 90, 47, 13)
        Label6.SetBounds(214, 90, 65, 13)
        Label7.SetBounds(214, 117, 79, 13)
        Label8.SetBounds(14, 117, 80, 13)
        Label9.SetBounds(214, 144, 85, 13)
        lblfriday.SetBounds(14, 113, 79, 13)
        lblmonday.SetBounds(14, 8, 79, 13)
        lblsaturday.SetBounds(14, 139, 79, 13)
        lblsunday.SetBounds(14, 165, 79, 13)
        lblthursday.SetBounds(14, 86, 79, 13)
        lbltuesday.SetBounds(14, 34, 79, 13)
        lblwednesday.SetBounds(14, 60, 79, 13)
        lbldaily1.SetBounds(12, 5, 79, 13)
        lbldaily2.SetBounds(12, 31, 79, 13)
        lbldaily3.SetBounds(12, 57, 79, 13)
        lbldaily4.SetBounds(12, 83, 79, 13)
        lbldaily5.SetBounds(12, 108, 79, 13)
        lbldaily6.SetBounds(12, 136, 79, 13)
        lbldaily7.SetBounds(12, 162, 79, 13)
        lblfrom.SetBounds(61, 16, 79, 13)
        lblto.SetBounds(172, 16, 79, 13)

        cmbfriday.SetBounds(100, 107, 123, 21)
        cmbmonday.SetBounds(100, 2, 123, 21)
        cmbregno.SetBounds(320, 13, 147, 21)
        cmbsaturday.SetBounds(100, 132, 123, 21)
        cmbsunday.SetBounds(100, 159, 123, 21)
        cmbthursday.SetBounds(100, 80, 123, 21)
        cmbtuesday.SetBounds(100, 28, 123, 21)
        cmbwednesday.SetBounds(100, 54, 123, 21)

        txtaddress.SetBounds(82, 33, 307, 21)
        txtcategory.SetBounds(295, 87, 105, 21)
        txtcity.SetBounds(13, 60, 192, 21)
        txtcountry.SetBounds(243, 87, 146, 21)
        txtdepartment.SetBounds(100, 114, 108, 21)
        txtdesignation.SetBounds(295, 114, 105, 21)
        txtdistrict.SetBounds(211, 60, 178, 21)
        txtdob.SetBounds(295, 60, 105, 21)
        txthouseno.SetBounds(13, 33, 63, 21)
        txtjoiningdate.SetBounds(100, 168, 108, 21)
        txtmarried.SetBounds(100, 141, 108, 21)
        txtname.SetBounds(100, 33, 300, 21)
        txtph.SetBounds(295, 141, 105, 21)
        txtphone.SetBounds(100, 87, 108, 21)
        txtpin.SetBounds(163, 87, 74, 21)
        txtretirementdate.SetBounds(295, 168, 105, 21)
        txtsex.SetBounds(100, 60, 108, 21)
        txtstate.SetBounds(13, 87, 144, 21)

        mskfriend.SetBounds(321, 113, 40, 14)
        mskfristart.SetBounds(177, 113, 40, 14)
        mskmonend.SetBounds(321, 8, 40, 14)
        mskmonstart.SetBounds(177, 8, 40, 14)
        msksatend.SetBounds(321, 139, 40, 14)
        msksatstart.SetBounds(177, 139, 40, 14)
        msksunend.SetBounds(321, 165, 40, 14)
        msksunstart.SetBounds(177, 165, 40, 14)
        mskthuend.SetBounds(321, 86, 40, 14)
        mskthustart.SetBounds(177, 86, 40, 14)
        msktueend.SetBounds(321, 34, 40, 14)
        msktuestart.SetBounds(177, 34, 40, 14)
        mskwedend.SetBounds(321, 60, 40, 14)
        mskwedstart.SetBounds(177, 60, 40, 14)

        btnprev.SetBounds(505, 11, 107, 25)
        btnnext.SetBounds(618, 11, 107, 25)
    End Sub

    Private Sub LoadDate()
        Dim today As Date = Date.Today
        Dim dayIndex As Integer = today.DayOfWeek
        If dayIndex < DayOfWeek.Monday Then
            dayIndex += 7
        End If
        Dim dayDiff As Integer = dayIndex - DayOfWeek.Monday
        Dim monday As Date = today.AddDays(-dayDiff)
        Dim startdate As String = monday.ToShortDateString()
        Dim tuesday As Date = monday.AddDays(1)
        Dim wednesday As Date = monday.AddDays(2)
        Dim thursday As Date = monday.AddDays(3)
        Dim friday As Date = monday.AddDays(4)
        Dim saturday As Date = monday.AddDays(5)
        Dim sunday As Date = monday.AddDays(6)
        Dim enddate As String = sunday.ToShortDateString()
        lblfrom.Text = startdate
        lblto.Text = enddate
    End Sub

    Private Sub LoadRegNo()
        Try
            Dim col1 As New DataGridViewTextBoxColumn()
            With col1
                .Name = "Col1"
                .HeaderText = "Reg. No."
            End With
            Dim col2 As New DataGridViewLinkColumn()
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
            cmd.CommandText = "select empid,name,designation from HiredEmployee where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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

            cmbregno.AddDataGridView(DGVRegNo, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVRegNo_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVRegNo.CurrentRow.Index
            DGVRegNo.Rows(k).Selected = True
            DGVRegNo.CurrentCell = DGVRegNo.Rows(k).Cells(0)
            EmpRegNo = DGVRegNo.Rows(k).Cells(0).Value.ToString()
            cmbregno.Text = EmpRegNo
            LoadEmployeeDetails(EmpRegNo)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadEmployeeDetails(ByVal regno As String)
        Try
            cmd.CommandText = "select address,category,city,country,department,designation,district,dob,houseno,joiningdate,married,name,handicapped,phone,pin,retirementdate,sex,state,payinfo from HiredEmployee where empid='" & regno & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            txtaddress.Text = dr("address").ToString()
            txtcategory.Text = dr("category").ToString()
            txtcity.Text = dr("city").ToString()
            txtcountry.Text = dr("country").ToString()
            txtdepartment.Text = dr("department").ToString()
            txtdesignation.Text = dr("designation").ToString()
            txtdistrict.Text = dr("district").ToString()
            txtdob.Text = dr("dob").ToString()
            txthouseno.Text = dr("houseno").ToString()
            txtjoiningdate.Text = dr("joiningdate").ToString()
            txtmarried.Text = dr("married").ToString()
            txtname.Text = dr("name").ToString()
            txtph.Text = dr("handicapped").ToString()
            txtphone.Text = dr("phone").ToString()
            txtpin.Text = dr("pin").ToString()
            txtretirementdate.Text = dr("retirementdate").ToString()
            txtsex.Text = dr("sex").ToString()
            txtstate.Text = dr("state").ToString()
            PayInfo = dr("payinfo").ToString()
            dr.Close()
            If PayInfo = "Hourly Based Pay" Then
                PanelDaily.Visible = False
                PanelHourly.Visible = True
                LoadHourlyRecord()
            ElseIf PayInfo = "Daily Pay" Then
                PanelDaily.Visible = True
                PanelHourly.Visible = False
                LoadDailyRecord()
            Else
                PanelDaily.Visible = False
                PanelHourly.Visible = False
            End If
            btnnext.Enabled = True
            btnprev.Enabled = True
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadDateHourly()
        Try
            Dim today As Date = Date.Now.ToShortDateString()
            Dim monday As Date = Date.Parse(lblfrom.Text)
            Dim tuesday As Date = monday.AddDays(1)
            Dim wednesday As Date = monday.AddDays(2)
            Dim thursday As Date = monday.AddDays(3)
            Dim friday As Date = monday.AddDays(4)
            Dim saturday As Date = monday.AddDays(5)
            Dim sunday As Date = monday.AddDays(6)

            lblmonday.Text = monday.ToShortDateString() + ": "
            lbltuesday.Text = tuesday.ToShortDateString() + ": "
            lblwednesday.Text = wednesday.ToShortDateString() + ": "
            lblthursday.Text = thursday.ToShortDateString() + ": "
            lblfriday.Text = friday.ToShortDateString() + ": "
            lblsaturday.Text = saturday.ToShortDateString() + ": "
            lblsunday.Text = sunday.ToShortDateString() + ": "

            Dates(0) = monday.ToShortDateString()
            Dates(1) = tuesday.ToShortDateString()
            Dates(2) = wednesday.ToShortDateString()
            Dates(3) = thursday.ToShortDateString()
            Dates(4) = friday.ToShortDateString()
            Dates(5) = saturday.ToShortDateString()
            Dates(6) = sunday.ToShortDateString()

            If today = monday Then
                mskmonend.Text = ""
                mskmonstart.Text = ""
            ElseIf today = tuesday Then
                msktueend.Text = ""
                msktuestart.Text = ""
            ElseIf today = wednesday Then
                mskwedend.Text = ""
                mskwedstart.Text = ""
            ElseIf today = thursday Then
                mskthuend.Text = ""
                mskthustart.Text = ""
            ElseIf today = friday Then
                mskfriend.Text = ""
                mskfristart.Text = ""
            ElseIf today = saturday Then
                msksatend.Text = ""
                msksatstart.Text = ""
            ElseIf today = sunday Then
                msksunend.Text = ""
                msksunstart.Text = ""
            Else
                mskmonend.Text = "0000"
                mskmonstart.Text = "0000"
                msktueend.Text = "0000"
                msktuestart.Text = "0000"
                mskwedend.Text = "0000"
                mskwedstart.Text = "0000"
                mskthuend.Text = "0000"
                mskthustart.Text = "0000"
                mskfriend.Text = "0000"
                mskfristart.Text = "0000"
                msksatend.Text = "0000"
                msksatstart.Text = "0000"
                msksunend.Text = "0000"
                msksunstart.Text = "0000"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadDateDaily()
        Try
            Dim today As Date = Date.Now.ToShortDateString()
            Dim monday As Date = Date.Parse(lblfrom.Text)
            Dim tuesday As Date = monday.AddDays(1)
            Dim wednesday As Date = monday.AddDays(2)
            Dim thursday As Date = monday.AddDays(3)
            Dim friday As Date = monday.AddDays(4)
            Dim saturday As Date = monday.AddDays(5)
            Dim sunday As Date = monday.AddDays(6)

            lbldaily1.Text = monday.ToShortDateString() + ": "
            lbldaily2.Text = tuesday.ToShortDateString() + ": "
            lbldaily3.Text = wednesday.ToShortDateString() + ": "
            lbldaily4.Text = thursday.ToShortDateString() + ": "
            lbldaily5.Text = friday.ToShortDateString() + ": "
            lbldaily6.Text = saturday.ToShortDateString() + ": "
            lbldaily7.Text = sunday.ToShortDateString() + ": "

            Dates(0) = monday.ToShortDateString()
            Dates(1) = tuesday.ToShortDateString()
            Dates(2) = wednesday.ToShortDateString()
            Dates(3) = thursday.ToShortDateString()
            Dates(4) = friday.ToShortDateString()
            Dates(5) = saturday.ToShortDateString()
            Dates(6) = sunday.ToShortDateString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadHourlyRecord()
        Try
            Dim Time1(6) As Date
            Dim Time2(6) As Date
            For i As Integer = 0 To 6
                cmd.CommandText = "select starttime,endtime from workinghourly where date='" & Dates(i) & "' and empid='" & cmbregno.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    Time1(i) = Date.Parse(dr("starttime").ToString())
                    Time2(i) = Date.Parse(dr("endtime").ToString())
                End If
                dr.Close()
            Next
            mskmonstart.Text = Time1(0).ToShortTimeString()
            mskmonend.Text = Time2(0).ToShortTimeString()
            msktuestart.Text = Time1(1).ToShortTimeString()
            msktueend.Text = Time2(1).ToShortTimeString()
            mskwedstart.Text = Time1(2).ToShortTimeString()
            mskwedend.Text = Time2(2).ToShortTimeString()
            mskthustart.Text = Time1(3).ToShortTimeString()
            mskthuend.Text = Time2(3).ToShortTimeString()
            mskfristart.Text = Time1(4).ToShortTimeString()
            mskfriend.Text = Time2(4).ToShortTimeString()
            msksatstart.Text = Time1(5).ToShortTimeString()
            msksatend.Text = Time2(5).ToShortTimeString()
            msksunstart.Text = Time1(6).ToShortTimeString()
            msksunend.Text = Time2(6).ToShortTimeString()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadDailyRecord()
        Try
            Dim PrAb(6) As String
            For i As Integer = 0 To 6
                cmd.CommandText = "select presentabsent from workingdaily where date='" & Dates(i) & "' and empid='" & cmbregno.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    PrAb(i) = dr("presentabsent").ToString()
                End If
                dr.Close()
            Next
            cmbmonday.Text = PrAb(0)
            cmbtuesday.Text = PrAb(1)
            cmbwednesday.Text = PrAb(2)
            cmbthursday.Text = PrAb(3)
            cmbfriday.Text = PrAb(4)
            cmbsaturday.Text = PrAb(5)
            cmbsunday.Text = PrAb(6)
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Sub ResetForm()
        PayInfo = ""
        cmbregno.Text = ""
        txtaddress.Text = ""
        txtcategory.Text = ""
        txtcity.Text = ""
        txtcountry.Text = ""
        txtdepartment.Text = ""
        txtdesignation.Text = ""
        txtdistrict.Text = ""
        txtdob.Text = ""
        txthouseno.Text = ""
        txtjoiningdate.Text = ""
        txtmarried.Text = ""
        txtname.Text = ""
        txtph.Text = ""
        txtphone.Text = ""
        txtpin.Text = ""
        txtretirementdate.Text = ""
        txtsex.Text = ""
        txtstate.Text = ""
        mskmonend.Text = ""
        mskmonstart.Text = ""
        msktueend.Text = ""
        msktuestart.Text = ""
        mskwedend.Text = ""
        mskwedstart.Text = ""
        mskthuend.Text = ""
        mskthustart.Text = ""
        mskfriend.Text = ""
        mskfristart.Text = ""
        msksatend.Text = ""
        msksatstart.Text = ""
        msksunend.Text = ""
        msksunstart.Text = ""
        cmbmonday.Text = ""
        cmbtuesday.Text = ""
        cmbwednesday.Text = ""
        cmbthursday.Text = ""
        cmbfriday.Text = ""
        cmbsaturday.Text = ""
        cmbsunday.Text = ""
        PanelDaily.Visible = False
        PanelHourly.Visible = False
        cmbregno.Focus()
    End Sub

    Private Sub AddRecord()
        Try
            If cmbregno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter employee reg. no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    cmbregno.Focus()
                End If
            ElseIf txtname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter employee name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtname.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    If PayInfo = "Hourly Based Pay" Then
                        Dim cls As New cWorkingPeriod()
                        StartTime(0) = Dates(0) + " " + mskmonstart.Text + ":00"
                        StartTime(1) = Dates(1) + " " + msktuestart.Text + ":00"
                        StartTime(2) = Dates(2) + " " + mskwedstart.Text + ":00"
                        StartTime(3) = Dates(3) + " " + mskthustart.Text + ":00"
                        StartTime(4) = Dates(4) + " " + mskfristart.Text + ":00"
                        StartTime(5) = Dates(5) + " " + msksatstart.Text + ":00"
                        StartTime(6) = Dates(6) + " " + msksunstart.Text + ":00"
                        EndTime(0) = Dates(0) + " " + mskmonend.Text + ":00"
                        EndTime(1) = Dates(1) + " " + msktueend.Text + ":00"
                        EndTime(2) = Dates(2) + " " + mskwedend.Text + ":00"
                        EndTime(3) = Dates(3) + " " + mskthuend.Text + ":00"
                        EndTime(4) = Dates(4) + " " + mskfriend.Text + ":00"
                        EndTime(5) = Dates(5) + " " + msksatend.Text + ":00"
                        EndTime(6) = Dates(6) + " " + msksunend.Text + ":00"
                        DT(0) = DateTime.Parse(EndTime(0)) - DateTime.Parse(StartTime(0))
                        TotalMinutes(0) = DT(0).TotalMinutes
                        DT(1) = DateTime.Parse(EndTime(1)) - DateTime.Parse(StartTime(1))
                        TotalMinutes(1) = DT(1).TotalMinutes
                        DT(2) = DateTime.Parse(EndTime(2)) - DateTime.Parse(StartTime(2))
                        TotalMinutes(2) = DT(2).TotalMinutes
                        DT(3) = DateTime.Parse(EndTime(3)) - DateTime.Parse(StartTime(3))
                        TotalMinutes(3) = DT(3).TotalMinutes
                        DT(4) = DateTime.Parse(EndTime(4)) - DateTime.Parse(StartTime(4))
                        TotalMinutes(4) = DT(4).TotalMinutes
                        DT(5) = DateTime.Parse(EndTime(5)) - DateTime.Parse(StartTime(5))
                        TotalMinutes(5) = DT(5).TotalMinutes
                        DT(6) = DateTime.Parse(EndTime(6)) - DateTime.Parse(StartTime(6))
                        TotalMinutes(6) = DT(6).TotalMinutes
                        For i As Integer = 0 To 6
                            cls.AddHourlyRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, cmbregno.Text, txtname.Focus, Dates(i), StartTime(i), EndTime(i), TotalMinutes(i))
                        Next
                        If cls.AddHourlyOk = True Then
                            Dim result1 As DialogResult = MessageBox.Show("Record added successfully....", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = DialogResult.OK Then
                                cmbregno.Focus()
                            End If
                        End If
                    ElseIf PayInfo = "Daily Pay" Then
                        Dim cls As New cWorkingPeriod()
                        PresentAbsent(0) = cmbmonday.Text
                        PresentAbsent(1) = cmbtuesday.Text
                        PresentAbsent(2) = cmbwednesday.Text
                        PresentAbsent(3) = cmbthursday.Text
                        PresentAbsent(4) = cmbfriday.Text
                        PresentAbsent(5) = cmbsaturday.Text
                        PresentAbsent(6) = cmbsunday.Text
                        For i As Integer = 0 To 6
                            cls.AddDailyRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, cmbregno.Text, txtname.Text, Dates(i), PresentAbsent(i))
                        Next
                        If cls.AddDailyOk = True Then
                            Dim result1 As DialogResult = MessageBox.Show("Record added successfully....", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = DialogResult.OK Then
                                cmbregno.Focus()
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedRecord()
        Try

        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmWorkingHours_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updateworking = False Then
            ControlSetBound()
            LoadDate()
            LoadRegNo()
            LoadDateHourly()
            LoadDateDaily()
        Else
            ControlSetBound()
            LoadDate()
            LoadRegNo()
            LoadDateHourly()
            LoadDateDaily()
            LoadSelectedRecord()
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updateworking = False Then
            AddRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updateworking = False Then
            AddRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updateworking = False Then
            ControlSetBound()
            LoadDate()
            LoadRegNo()
            LoadDateDaily()
            LoadDateHourly()
        Else
            ControlSetBound()
            LoadDate()
            LoadRegNo()
            LoadDateDaily()
            LoadDateHourly()
            LoadSelectedRecord()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub

    Private Sub btnnext_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnext.ClickButtonArea
        If cmbregno.Text <> "" Then
            cmd.CommandText = "select retirementdate from HiredEmployee where empid='" & cmbregno.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim enddt As Date = Date.Parse(dr("retirementdate").ToString())
            dr.Close()
            Dim sdt As Date = Date.Parse(lblfrom.Text)
            Dim edt As Date = Date.Parse(lblto.Text)
            Dim nsdt As Date = sdt.AddDays(7)
            Dim nsto As Date = edt.AddDays(7)
            lblfrom.Text = nsdt.ToShortDateString()
            lblto.Text = nsto.ToShortDateString()
            LoadDateDaily()
            LoadDateHourly()
            LoadHourlyRecord()
            LoadDailyRecord()

            Dim today As Date = enddt
            Dim monday As Date = Date.Parse(lblfrom.Text)
            Dim tuesday As Date = monday.AddDays(1)
            Dim wednesday As Date = monday.AddDays(2)
            Dim thursday As Date = monday.AddDays(3)
            Dim friday As Date = monday.AddDays(4)
            Dim saturday As Date = monday.AddDays(5)
            Dim sunday As Date = monday.AddDays(6)


            btnprev.Enabled = True
            If nsto > enddt Then
                btnnext.Enabled = False
            Else
                btnnext.Enabled = True
            End If

            mskmonstart.Enabled = True
            mskmonend.Enabled = True
            msktuestart.Enabled = True
            msktueend.Enabled = True
            mskwedstart.Enabled = True
            mskwedend.Enabled = True
            mskthustart.Enabled = True
            mskthuend.Enabled = True
            mskfristart.Enabled = True
            mskfriend.Enabled = True
            msksatstart.Enabled = True
            msksatend.Enabled = True
            msksunstart.Enabled = True
            msksunend.Enabled = True

            If today = monday Then
                mskmonstart.Enabled = True
                mskmonend.Enabled = True
                msktuestart.Enabled = False
                msktueend.Enabled = False
                mskwedstart.Enabled = False
                mskwedend.Enabled = False
                mskthustart.Enabled = False
                mskthuend.Enabled = False
                mskfristart.Enabled = False
                mskfriend.Enabled = False
                msksatstart.Enabled = False
                msksatend.Enabled = False
                msksunstart.Enabled = False
                msksunend.Enabled = False
            ElseIf today = tuesday Then
                mskmonstart.Enabled = True
                mskmonend.Enabled = True
                msktuestart.Enabled = True
                msktueend.Enabled = True
                mskwedstart.Enabled = False
                mskwedend.Enabled = False
                mskthustart.Enabled = False
                mskthuend.Enabled = False
                mskfristart.Enabled = False
                mskfriend.Enabled = False
                msksatstart.Enabled = False
                msksatend.Enabled = False
                msksunstart.Enabled = False
                msksunend.Enabled = False
            ElseIf today = wednesday Then
                mskmonstart.Enabled = True
                mskmonend.Enabled = True
                msktuestart.Enabled = True
                msktueend.Enabled = True
                mskwedstart.Enabled = True
                mskwedend.Enabled = True
                mskthustart.Enabled = False
                mskthuend.Enabled = False
                mskfristart.Enabled = False
                mskfriend.Enabled = False
                msksatstart.Enabled = False
                msksatend.Enabled = False
                msksunstart.Enabled = False
                msksunend.Enabled = False
            ElseIf today = thursday Then
                mskmonstart.Enabled = True
                mskmonend.Enabled = True
                msktuestart.Enabled = True
                msktueend.Enabled = True
                mskwedstart.Enabled = True
                mskwedend.Enabled = True
                mskthustart.Enabled = True
                mskthuend.Enabled = True
                mskfristart.Enabled = False
                mskfriend.Enabled = False
                msksatstart.Enabled = False
                msksatend.Enabled = False
                msksunstart.Enabled = False
                msksunend.Enabled = False
            ElseIf today = friday Then
                mskmonstart.Enabled = True
                mskmonend.Enabled = True
                msktuestart.Enabled = True
                msktueend.Enabled = True
                mskwedstart.Enabled = True
                mskwedend.Enabled = True
                mskthustart.Enabled = True
                mskthuend.Enabled = True
                mskfristart.Enabled = True
                mskfriend.Enabled = True
                msksatstart.Enabled = False
                msksatend.Enabled = False
                msksunstart.Enabled = False
                msksunend.Enabled = False
            ElseIf today = saturday Then
                mskmonstart.Enabled = True
                mskmonend.Enabled = True
                msktuestart.Enabled = True
                msktueend.Enabled = True
                mskwedstart.Enabled = True
                mskwedend.Enabled = True
                mskthustart.Enabled = True
                mskthuend.Enabled = True
                mskfristart.Enabled = True
                mskfriend.Enabled = True
                msksatstart.Enabled = True
                msksatend.Enabled = True
                msksunstart.Enabled = False
                msksunend.Enabled = False
            ElseIf today = sunday Then
                mskmonstart.Enabled = True
                mskmonend.Enabled = True
                msktuestart.Enabled = True
                msktueend.Enabled = True
                mskwedstart.Enabled = True
                mskwedend.Enabled = True
                mskthustart.Enabled = True
                mskthuend.Enabled = True
                mskfristart.Enabled = True
                mskfriend.Enabled = True
                msksatstart.Enabled = True
                msksatend.Enabled = True
                msksunstart.Enabled = True
                msksunend.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnprev_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnprev.ClickButtonArea
        If cmbregno.Text <> "" Then
            cmd.CommandText = "select joiningdate from HiredEmployee where empid='" & cmbregno.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim startdt As Date = Date.Parse(dr("joiningdate").ToString())
            dr.Close()
            Dim sdt As Date = Date.Parse(lblfrom.Text)
            Dim edt As Date = Date.Parse(lblto.Text)
            Dim nsdt As Date = sdt.AddDays(-7)
            Dim nsto As Date = edt.AddDays(-7)
            lblfrom.Text = nsdt.ToShortDateString()
            lblto.Text = nsto.ToShortDateString()
            LoadDateDaily()
            LoadDateHourly()
            LoadHourlyRecord()
            LoadDailyRecord()

            Dim today As Date = startdt
            Dim monday As Date = Date.Parse(lblfrom.Text)
            Dim tuesday As Date = monday.AddDays(1)
            Dim wednesday As Date = monday.AddDays(2)
            Dim thursday As Date = monday.AddDays(3)
            Dim friday As Date = monday.AddDays(4)
            Dim saturday As Date = monday.AddDays(5)
            Dim sunday As Date = monday.AddDays(6)


            btnnext.Enabled = True
            If nsdt < startdt Then
                btnprev.Enabled = False
            Else
                btnprev.Enabled = True
            End If

            mskmonstart.Enabled = True
            mskmonend.Enabled = True
            msktuestart.Enabled = True
            msktueend.Enabled = True
            mskwedstart.Enabled = True
            mskwedend.Enabled = True
            mskthustart.Enabled = True
            mskthuend.Enabled = True
            mskfristart.Enabled = True
            mskfriend.Enabled = True
            msksatstart.Enabled = True
            msksatend.Enabled = True
            msksunstart.Enabled = True
            msksunend.Enabled = True

            If today = monday Then
                mskmonstart.Enabled = True
                mskmonend.Enabled = True
                msktuestart.Enabled = True
                msktueend.Enabled = True
                mskwedstart.Enabled = True
                mskwedend.Enabled = True
                mskthustart.Enabled = True
                mskthuend.Enabled = True
                mskfristart.Enabled = True
                mskfriend.Enabled = True
                msksatstart.Enabled = True
                msksatend.Enabled = True
                msksunstart.Enabled = True
                msksunend.Enabled = True
            ElseIf today = tuesday Then
                mskmonstart.Enabled = False
                mskmonend.Enabled = False
                msktuestart.Enabled = True
                msktueend.Enabled = True
                mskwedstart.Enabled = True
                mskwedend.Enabled = True
                mskthustart.Enabled = True
                mskthuend.Enabled = True
                mskfristart.Enabled = True
                mskfriend.Enabled = True
                msksatstart.Enabled = True
                msksatend.Enabled = True
                msksunstart.Enabled = True
                msksunend.Enabled = True
            ElseIf today = wednesday Then
                mskmonstart.Enabled = False
                mskmonend.Enabled = False
                msktuestart.Enabled = False
                msktueend.Enabled = False
                mskwedstart.Enabled = True
                mskwedend.Enabled = True
                mskthustart.Enabled = True
                mskthuend.Enabled = True
                mskfristart.Enabled = True
                mskfriend.Enabled = True
                msksatstart.Enabled = True
                msksatend.Enabled = True
                msksunstart.Enabled = True
                msksunend.Enabled = True
            ElseIf today = thursday Then
                mskmonstart.Enabled = False
                mskmonend.Enabled = False
                msktuestart.Enabled = False
                msktueend.Enabled = False
                mskwedstart.Enabled = False
                mskwedend.Enabled = False
                mskthustart.Enabled = True
                mskthuend.Enabled = True
                mskfristart.Enabled = True
                mskfriend.Enabled = True
                msksatstart.Enabled = True
                msksatend.Enabled = True
                msksunstart.Enabled = True
                msksunend.Enabled = True
            ElseIf today = friday Then
                mskmonstart.Enabled = False
                mskmonend.Enabled = False
                msktuestart.Enabled = False
                msktueend.Enabled = False
                mskwedstart.Enabled = False
                mskwedend.Enabled = False
                mskthustart.Enabled = False
                mskthuend.Enabled = False
                mskfristart.Enabled = True
                mskfriend.Enabled = True
                msksatstart.Enabled = True
                msksatend.Enabled = True
                msksunstart.Enabled = True
                msksunend.Enabled = True
            ElseIf today = saturday Then
                mskmonstart.Enabled = False
                mskmonend.Enabled = False
                msktuestart.Enabled = False
                msktueend.Enabled = False
                mskwedstart.Enabled = False
                mskwedend.Enabled = False
                mskthustart.Enabled = False
                mskthuend.Enabled = False
                mskfristart.Enabled = False
                mskfriend.Enabled = False
                msksatstart.Enabled = True
                msksatend.Enabled = True
                msksunstart.Enabled = True
                msksunend.Enabled = True
            ElseIf today = sunday Then
                mskmonstart.Enabled = False
                mskmonend.Enabled = False
                msktuestart.Enabled = False
                msktueend.Enabled = False
                mskwedstart.Enabled = False
                mskwedend.Enabled = False
                mskthustart.Enabled = False
                mskthuend.Enabled = False
                mskfristart.Enabled = False
                mskfriend.Enabled = False
                msksatstart.Enabled = False
                msksatend.Enabled = False
                msksunstart.Enabled = False
                msksunend.Enabled = False
            End If
        End If
    End Sub
#End Region
#Region "Attributes..."
    Private Sub cmbregno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbregno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtname.Focus()
        End If
    End Sub

    Private Sub txtname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtsex.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbregno.Focus()
        End If
    End Sub

    Private Sub txtsex_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsex.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtdob.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtname.Focus()
        End If
    End Sub

    Private Sub txtdob_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdob.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtphone.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtsex.Focus()
        End If
    End Sub

    Private Sub txtphone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtphone.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtcategory.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtdob.Focus()
        End If
    End Sub

    Private Sub txtcategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcategory.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtdepartment.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtphone.Focus()
        End If
    End Sub

    Private Sub txtdepartment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdepartment.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtdesignation.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcategory.Focus()
        End If
    End Sub

    Private Sub txtdesignation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdesignation.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtmarried.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtdepartment.Focus()
        End If
    End Sub

    Private Sub txtmarried_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmarried.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtph.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtdesignation.Focus()
        End If
    End Sub

    Private Sub txtph_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtph.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtjoiningdate.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtmarried.Focus()
        End If
    End Sub

    Private Sub txtjoiningdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtjoiningdate.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtretirementdate.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtph.Focus()
        End If
    End Sub

    Private Sub txtretirementdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtretirementdate.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txthouseno.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtjoiningdate.Focus()
        End If
    End Sub

    Private Sub txthouseno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txthouseno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtaddress.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtretirementdate.Focus()
        End If
    End Sub

    Private Sub txtaddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtaddress.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtcity.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txthouseno.Focus()
        End If
    End Sub

    Private Sub txtcity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcity.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtdistrict.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtaddress.Focus()
        End If
    End Sub

    Private Sub txtdistrict_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdistrict.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtstate.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcity.Focus()
        End If
    End Sub

    Private Sub txtstate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtstate.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtpin.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtdistrict.Focus()
        End If
    End Sub

    Private Sub txtpin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpin.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtcountry.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtstate.Focus()
        End If
    End Sub

    Private Sub txtcountry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcountry.KeyDown
        If e.KeyCode = Keys.Up Then
            txtpin.Focus()
        ElseIf e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            If PayInfo = "Hourly Based Pay" Then
                If mskfristart.Enabled = True Then
                    mskfristart.Focus()
                ElseIf mskmonstart.Enabled = True Then
                    mskmonstart.Focus()
                ElseIf msksatstart.Enabled = True Then
                    msksatstart.Focus()
                ElseIf msksunstart.Enabled = True Then
                    msksunstart.Focus()
                ElseIf mskthustart.Enabled = True Then
                    mskthustart.Focus()
                ElseIf msktuestart.Enabled = True Then
                    msktuestart.Focus()
                ElseIf mskwedstart.Enabled = True Then
                    mskwedstart.Focus()
                End If
            ElseIf PayInfo = "Daily Pay" Then
                If cmbmonday.Enabled = True Then
                    cmbmonday.Focus()
                ElseIf cmbtuesday.Enabled = True Then
                    cmbtuesday.Focus()
                ElseIf cmbwednesday.Enabled = True Then
                    cmbwednesday.Focus()
                ElseIf cmbthursday.Enabled = True Then
                    cmbthursday.Focus()
                ElseIf cmbfriday.Enabled = True Then
                    cmbfriday.Focus()
                ElseIf cmbsaturday.Enabled = True Then
                    cmbsaturday.Focus()
                ElseIf cmbsunday.Enabled = True Then
                    cmbsunday.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub TextBoxTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtaddress.TextChanged, txtcategory.TextChanged, txtcity.TextChanged, txtcountry.TextChanged, txtdepartment.TextChanged, txtdesignation.TextChanged, txtdistrict.TextChanged, txthouseno.TextChanged, txtmarried.TextChanged, txtname.TextChanged, txtph.TextChanged, txtsex.TextChanged, txtstate.TextChanged
        Dim ctc As New cTextChange()
        Dim x As eTextBox = CType(sender, eTextBox)
        ctc.ConvertTextBoxValidValue(x)
    End Sub

    Private Sub mskmonend_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskmonend.KeyDown
        If e.KeyCode = Keys.Up Then
            mskmonstart.Focus()
        End If
    End Sub

    Private Sub mskmonstart_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskmonstart.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            mskmonend.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcountry.Focus()
        End If
    End Sub

    Private Sub msktueend_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles msktueend.KeyDown
        If e.KeyCode = Keys.Up Then
            msktuestart.Focus()
        End If
    End Sub

    Private Sub msktuestart_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles msktuestart.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            msktueend.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcountry.Focus()
        End If
    End Sub

    Private Sub mskwedend_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskwedend.KeyDown
        If e.KeyCode = Keys.Up Then
            mskwedstart.Focus()
        End If
    End Sub

    Private Sub mskwedstart_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskwedstart.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            mskwedend.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcountry.Focus()
        End If
    End Sub

    Private Sub mskthuend_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskthuend.KeyDown
        If e.KeyCode = Keys.Up Then
            mskthustart.Focus()
        End If
    End Sub

    Private Sub mskthustart_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskthustart.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            mskthuend.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcountry.Focus()
        End If
    End Sub

    Private Sub mskfriend_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskfriend.KeyDown
        If e.KeyCode = Keys.Up Then
            mskfristart.Focus()
        End If
    End Sub

    Private Sub mskfristart_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskfristart.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            mskfriend.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcountry.Focus()
        End If
    End Sub

    Private Sub msksatend_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles msksatend.KeyDown
        If e.KeyCode = Keys.Up Then
            msksatstart.Focus()
        End If
    End Sub

    Private Sub msksatstart_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles msksatstart.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            msksatend.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcountry.Focus()
        End If
    End Sub

    Private Sub msksunend_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles msksunend.KeyDown
        If e.KeyCode = Keys.Up Then
            msksunstart.Focus()
        End If
    End Sub

    Private Sub msksunstart_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles msksunstart.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            msksunend.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcountry.Focus()
        End If
    End Sub

    Private Sub ComboBoxKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbmonday.KeyPress, cmbtuesday.KeyPress, cmbwednesday.KeyPress, cmbthursday.KeyPress, cmbfriday.KeyPress, cmbsaturday.KeyPress, cmbsunday.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub
#End Region
End Class
#End Region