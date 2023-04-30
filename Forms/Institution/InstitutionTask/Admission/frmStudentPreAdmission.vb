#Region "Imports"
Imports ESAR_Controls.UIControls.ComboBox
Imports ESAR_Controls
Imports System.IO
Imports System.Drawing.Imaging

#End Region
#Region "Class frmStudentPreAdmission"
Public Class frmStudentPreAdmission
#Region "Declarations..."
    Private ACODE As String = ""
    Private TT As String = ""
    Private DGVCourse As New DataGridView()
    Private openFileDLG As New OpenFileDialog()
    Private serialexist As Boolean = False
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        ACODE = Indx.LoadPreAdmissionID()
        Dim var As String
        var = CodeIncrement(ACODE)
        Me.txtregno.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("PADM:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        Label1.SetBounds(13, 48, 43, 13)
        Label10.SetBounds(350, 40, 38, 13)
        Label11.SetBounds(20, 119, 38, 13)
        Label12.SetBounds(303, 119, 34, 13)
        Label13.SetBounds(236, 113, 55, 13)
        Label2.SetBounds(13, 75, 53, 13)
        Label3.SetBounds(13, 102, 163, 13)
        Label4.SetBounds(13, 129, 168, 13)
        Label5.SetBounds(13, 156, 120, 13)
        Label6.SetBounds(13, 183, 112, 26)
        Label7.SetBounds(16, 205, 136, 13)
        Label8.SetBounds(13, 113, 72, 13)
        Label9.SetBounds(267, 138, 33, 13)

        cmbaccounttype.SetBounds(158, 202, 145, 21)
        cmbcardtype.SetBounds(91, 108, 142, 22)
        cmbclass.SetBounds(141, 45, 109, 21)
        cmbcourse.SetBounds(83, 72, 167, 21)
        cmbdob.SetBounds(74, 116, 126, 21)
        cmbpayvia.SetBounds(297, 108, 75, 22)
        cmbsex.SetBounds(343, 116, 121, 22)

        nudclass.SetBounds(83, 44, 49, 21)
        nudyear.SetBounds(394, 37, 70, 21)

        txtaccountno.SetBounds(19, 175, 361, 21)
        txtaddress.SetBounds(100, 45, 378, 21)
        txtannualincome.SetBounds(187, 188, 63, 21)
        txtanualcoursefee.SetBounds(187, 153, 63, 21)
        txtbankbranch.SetBounds(19, 95, 361, 21)
        txtbankname.SetBounds(19, 68, 361, 21)
        txtbranchaddress.SetBounds(19, 122, 361, 21)
        txtbranchcode.SetBounds(19, 147, 361, 21)
        txtcardaddress.SetBounds(15, 56, 218, 21)
        txtcardcity.SetBounds(239, 56, 133, 21)
        txtcardcountry.SetBounds(239, 83, 133, 21)
        txtcardholdername.SetBounds(15, 29, 357, 21)
        txtcardno.SetBounds(15, 135, 218, 21)
        txtcardpin.SetBounds(172, 83, 61, 21)
        txtcardstate.SetBounds(15, 83, 151, 21)
        txtcity.SetBounds(20, 72, 232, 21)
        txtcountry.SetBounds(261, 126, 217, 21)
        txtdistrict.SetBounds(20, 99, 232, 21)
        txtelectransfer.SetBounds(19, 254, 361, 21)
        txtemail.SetBounds(20, 153, 458, 21)
        txtexpmm.SetBounds(306, 135, 30, 21)
        txtexpyy.SetBounds(342, 135, 30, 21)
        txtfax.SetBounds(322, 180, 156, 21)
        txtfgname.SetBounds(20, 91, 235, 21)
        txtfirstname.SetBounds(20, 64, 144, 21)
        txthomephone.SetBounds(20, 180, 148, 21)
        txthouseno.SetBounds(20, 44, 74, 21)
        txtlastname.SetBounds(320, 64, 144, 21)
        txtmicrcode.SetBounds(19, 229, 361, 21)
        txtmiddlename.SetBounds(170, 64, 144, 21)
        txtmothername.SetBounds(261, 91, 203, 21)
        txtothertestamount.SetBounds(187, 126, 63, 21)
        txtpayeename.SetBounds(19, 41, 361, 21)
        txtpin.SetBounds(20, 126, 232, 21)
        txtpost.SetBounds(261, 72, 217, 21)
        txtregno.SetBounds(20, 37, 206, 21)
        txtstate.SetBounds(261, 99, 217, 21)
        txttestamount.SetBounds(187, 99, 63, 21)
        txtworkphone.SetBounds(174, 180, 140, 21)

        ProfilePic1.SetBounds(525, 44, 78, 95)
        btnupload.SetBounds(622, 112, 121, 25)
    End Sub

    Private Sub LoadCountry()
        Try
            Dim Country As New AutoCompleteStringCollection
            Country.Add("Afghanistan")
            Country.Add("Albania")
            Country.Add("Algeria")
            Country.Add("American Samoa")
            Country.Add("Andorra")
            Country.Add("Angola")
            Country.Add("Anguilla")
            Country.Add("Antigua and Barbuda")
            Country.Add("Argentina")
            Country.Add("Armenia")
            Country.Add("Aruba")
            Country.Add("Australia")
            Country.Add("Austria")
            Country.Add("Azerbaijan")
            Country.Add("Bahamas")
            Country.Add("Bahrain")
            Country.Add("Bangladesh")
            Country.Add("Barbados")
            Country.Add("Belarus")
            Country.Add("Belgium")
            Country.Add("Belize")
            Country.Add("Benin")
            Country.Add("Bermuda")
            Country.Add("Bhutan")
            Country.Add("Bolivia")
            Country.Add("Bosnia-Herzegovina")
            Country.Add("Botswana")
            Country.Add("Bouvet Island")
            Country.Add("Brazil")
            Country.Add("Brunei")
            Country.Add("Bulgaria")
            Country.Add("Burkina Faso")
            Country.Add("Burundi")
            Country.Add("Cambodia")
            Country.Add("Cameroon")
            Country.Add("Canada")
            Country.Add("Cape Verde")
            Country.Add("Cayman Islands")
            Country.Add("Central African Republic")
            Country.Add("Chad")
            Country.Add("Chile")
            Country.Add("China")
            Country.Add("Christmas Island")
            Country.Add("Cocos (Keeling) Islands")
            Country.Add("Colombia")
            Country.Add("Comoros")
            Country.Add("Congo, Democratic Republic of the (Zaire) Africa")
            Country.Add("Congo, Republic of	Africa")
            Country.Add("Cook Islands")
            Country.Add("Costa Rica")
            Country.Add("Croatia")
            Country.Add("Cuba")
            Country.Add("Cyprus")
            Country.Add("Czech Republic")
            Country.Add("Denmark")
            Country.Add("Djibouti")
            Country.Add("Dominica")
            Country.Add("Dominican Republic")
            Country.Add("Ecuador")
            Country.Add("Egypt")
            Country.Add("El Salvador")
            Country.Add("Equatorial Guinea")
            Country.Add("Eritrea")
            Country.Add("Estonia")
            Country.Add("Ethiopia")
            Country.Add("Falkland Islands")
            Country.Add("Faroe Islands")
            Country.Add("Fiji")
            Country.Add("Finland")
            Country.Add("France")
            Country.Add("French Guiana")
            Country.Add("Gabon")
            Country.Add("Gambia")
            Country.Add("Georgia")
            Country.Add("Germany")
            Country.Add("Ghana")
            Country.Add("Gibraltar")
            Country.Add("Greece")
            Country.Add("Greenland")
            Country.Add("Grenada")
            Country.Add("Guadeloupe")
            Country.Add("Guam (USA)")
            Country.Add("Guatemala")
            Country.Add("Guinea")
            Country.Add("Guinea Bissau")
            Country.Add("Guyana")
            Country.Add("Haiti")
            Country.Add("Holy See")
            Country.Add("Honduras")
            Country.Add("Hong Kong")
            Country.Add("Hungary")
            Country.Add("Iceland")
            Country.Add("India")
            Country.Add("Indonesia")
            Country.Add("Iran")
            Country.Add("Iraq")
            Country.Add("Ireland")
            Country.Add("Israel")
            Country.Add("Italy")
            Country.Add("Ivory Coast (Cote D`Ivoire)")
            Country.Add("Jamaica")
            Country.Add("Japan")
            Country.Add("Jordan")
            Country.Add("Kazakhstan")
            Country.Add("Kenya")
            Country.Add("Kiribati")
            Country.Add("Kuwait")
            Country.Add("Kyrgyzstan")
            Country.Add("Laos")
            Country.Add("Latvia")
            Country.Add("Lebanon")
            Country.Add("Lesotho")
            Country.Add("Liberia")
            Country.Add("Libya")
            Country.Add("Liechtenstein")
            Country.Add("Lithuania")
            Country.Add("Luxembourg")
            Country.Add("Macau")
            Country.Add("Macedonia")
            Country.Add("Madagascar")
            Country.Add("Malawi")
            Country.Add("Malaysia")
            Country.Add("Maldives")
            Country.Add("Mali")
            Country.Add("Malta")
            Country.Add("Marshall Islands")
            Country.Add("Martinique (French)")
            Country.Add("Mauritania")
            Country.Add("Mauritius")
            Country.Add("Mayotte")
            Country.Add("Mexico")
            Country.Add("Micronesia")
            Country.Add("Moldova")
            Country.Add("Monaco")
            Country.Add("Mongolia")
            Country.Add("Montenegro")
            Country.Add("Montserrat")
            Country.Add("Morocco")
            Country.Add("Mozambique")
            Country.Add("Myanmar")
            Country.Add("Namibia")
            Country.Add("Nauru")
            Country.Add("Nepal")
            Country.Add("Netherlands")
            Country.Add("Netherlands Antilles")
            Country.Add("New Caledonia (French)")
            Country.Add("New Zealand")
            Country.Add("Nicaragua")
            Country.Add("Niger")
            Country.Add("Nigeria")
            Country.Add("Niue")
            Country.Add("Norfolk Island")
            Country.Add("North Korea")
            Country.Add("Northern Mariana Islands")
            Country.Add("Norway")
            Country.Add("Oman")
            Country.Add("Pakistan")
            Country.Add("Palau")
            Country.Add("Panama")
            Country.Add("Papua New Guinea")
            Country.Add("Paraguay")
            Country.Add("Peru")
            Country.Add("Philippines")
            Country.Add("Pitcairn Island")
            Country.Add("Poland")
            Country.Add("Polynesia (French)")
            Country.Add("Portugal")
            Country.Add("Puerto Rico")
            Country.Add("Qatar")
            Country.Add("Reunion")
            Country.Add("Romania")
            Country.Add("Russia")
            Country.Add("Rwanda")
            Country.Add("Saint Helena")
            Country.Add("Saint Kitts and Nevis")
            Country.Add("Saint Lucia")
            Country.Add("Saint Pierre and Miquelon")
            Country.Add("Saint Vincent and Grenadines")
            Country.Add("Samoa")
            Country.Add("San Marino")
            Country.Add("Sao Tome and Principe")
            Country.Add("Saudi Arabia")
            Country.Add("Senegal")
            Country.Add("Serbia")
            Country.Add("Seychelles")
            Country.Add("Sierra Leone")
            Country.Add("Singapore")
            Country.Add("Slovakia")
            Country.Add("Slovenia")
            Country.Add("Solomon Islands")
            Country.Add("Somalia")
            Country.Add("South Africa")
            Country.Add("South Georgia and South Sandwich Islands")
            Country.Add("South Korea")
            Country.Add("Spain")
            Country.Add("Sri Lanka")
            Country.Add("Sudan")
            Country.Add("Suriname")
            Country.Add("Svalbard and Jan Mayen Islands")
            Country.Add("Swaziland")
            Country.Add("Sweden")
            Country.Add("Switzerland")
            Country.Add("Syria")
            Country.Add("Taiwan")
            Country.Add("Tajikistan")
            Country.Add("Tanzania")
            Country.Add("Thailand")
            Country.Add("Timor-Leste (East Timor)")
            Country.Add("Togo")
            Country.Add("Tokelau")
            Country.Add("Tonga")
            Country.Add("Trinidad and Tobago")
            Country.Add("Tunisia")
            Country.Add("Turkey")
            Country.Add("Turkmenistan")
            Country.Add("Turks and Caicos Islands")
            Country.Add("Tuvalu")
            Country.Add("Uganda")
            Country.Add("Ukraine")
            Country.Add("United Arab Emirates")
            Country.Add("United Kingdom")
            Country.Add("United States")
            Country.Add("Uruguay")
            Country.Add("Uzbekistan")
            Country.Add("Vanuatu")
            Country.Add("Venezuela")
            Country.Add("Vietnam")
            Country.Add("Virgin Islands")
            Country.Add("Wallis and Futuna Islands")
            Country.Add("Yemen")
            Country.Add("Zambia")
            Country.Add("Zimbabwe")
            txtcountry.AutoCompleteMode = AutoCompleteMode.Suggest
            txtcountry.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtcountry.AutoCompleteCustomSource = Country
            txtcardcountry.AutoCompleteMode = AutoCompleteMode.Suggest
            txtcardcountry.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtcardcountry.AutoCompleteCustomSource = Country
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadCourse()
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .Name = "Col1"
                .HeaderText = "Code"
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .Name = "Col2"
                .HeaderText = "Course"
            End With
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .Name = "Col3"
                .HeaderText = "Duration"
            End With

            With DGVCourse
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
                AddHandler DGVCourse.CellClick, AddressOf DGVCourse_CellClick
            End With

            DGVCourse.Columns.Clear()
            DGVCourse.Columns.Add(col1)
            DGVCourse.Columns.Add(col2)
            DGVCourse.Columns.Add(col3)

            DGVCourse.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select CourseCode,CourseName,Duration from Course where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVCourse.Rows.Add()
                DGVCourse.Rows(indx).Cells(0).Value = dr("CourseCode").ToString()
                DGVCourse.Rows(indx).Cells(1).Value = dr("CourseName").ToString()
                DGVCourse.Rows(indx).Cells(2).Value = dr("Duration").ToString()

                indx = indx + 1
            End While
            dr.Close()
            DGVCourse.ClearSelection()

            cmbcourse.AddDataGridView(DGVCourse, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVCourse_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVCourse.CurrentRow.Index
            DGVCourse.Rows(k).Selected = True
            DGVCourse.CurrentCell = DGVCourse.Rows(k).Cells(0)
            crscode = DGVCourse.Rows(k).Cells(0).Value.ToString()
            crsname = DGVCourse.Rows(k).Cells(1).Value.ToString()
            crsduration = DGVCourse.Rows(k).Cells(2).Value.ToString()
            cmbcourse.Text = crsname
            cmd.CommandText = "select CourseFees from Course where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and year=" & CInt(nudyear.Value.ToString()) & " and CourseName='" & cmbcourse.Text & "' and CourseCode='" & crscode & "' and Duration='" & crsduration & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            txtanualcoursefee.Text = dr("CourseFees").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadState()
        Try
            Dim State As New AutoCompleteStringCollection
            State.Add("Delhi")
            State.Add("Andhra Pradesh")
            State.Add("Arunachal Pradesh")
            State.Add("Asom (Assam)")
            State.Add("Bihar")
            State.Add("Chhattisgarh")
            State.Add("Goa")
            State.Add("Gujarat")
            State.Add("Haryana")
            State.Add("Himachal Pradesh")
            State.Add("Jammu and Kashmir")
            State.Add("Srinagar")
            State.Add("Jharkhand")
            State.Add("Karnataka")
            State.Add("Kerala")
            State.Add("Madhya Pradesh")
            State.Add("Maharashtra")
            State.Add("Manipur")
            State.Add("Meghalaya")
            State.Add("Mizoram")
            State.Add("Nagaland")
            State.Add("Odisha (Orissa)")
            State.Add("Punjab")
            State.Add("Rajasthan")
            State.Add("Sikkim")
            State.Add("Tamil Nadu")
            State.Add("Tripura")
            State.Add("Uttar Pradesh")
            State.Add("Uttarakhand (Uttaranchal)")
            State.Add("West Bengal")
            txtstate.AutoCompleteMode = AutoCompleteMode.Suggest
            txtstate.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtstate.AutoCompleteCustomSource = State
            txtcardstate.AutoCompleteMode = AutoCompleteMode.Suggest
            txtcardstate.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtcardstate.AutoCompleteCustomSource = State
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetForm()
        updatestudentpreadm = False
        If ISDAutoID = "Yes" Then
            GetCode()
        Else
            txtregno.Text = ""
        End If
        ProfilePic1.Image = Global.Umbrella.My.Resources.people
        cmbaccounttype.Text = ""
        cmbcardtype.Text = ""
        cmbclass.Text = ""
        cmbcourse.Text = ""
        cmbdob.Text = ""
        cmbsex.Text = ""
        nudclass.Value = 1
        Dim yy As Integer = Date.Now.Year
        nudyear.Minimum = yy - 25
        nudyear.Maximum = yy + 25
        nudyear.Value = yy
        txtaccountno.Text = ""
        txtaddress.Text = ""
        txtannualincome.Text = ""
        txtanualcoursefee.Text = ""
        txtbankbranch.Text = ""
        txtbankname.Text = ""
        txtbranchaddress.Text = ""
        txtbranchcode.Text = ""
        txtcardaddress.Text = ""
        txtcardcity.Text = ""
        txtcardcountry.Text = ""
        txtcardholdername.Text = ""
        txtcardno.Text = ""
        txtcardpin.Text = ""
        txtcardstate.Text = ""
        txtcity.Text = ""
        txtcountry.Text = ""
        txtdistrict.Text = ""
        txtelectransfer.Text = ""
        txtemail.Text = ""
        txtexpmm.Text = ""
        txtexpyy.Text = ""
        txtfax.Text = ""
        txtfgname.Text = ""
        txtfirstname.Text = ""
        txthomephone.Text = ""
        txthouseno.Text = ""
        txtlastname.Text = ""
        txtmicrcode.Text = ""
        txtmiddlename.Text = ""
        txtmothername.Text = ""
        txtothertestamount.Text = ""
        txtpayeename.Text = ""
        txtpin.Text = ""
        txtpost.Text = ""
        txtstate.Text = ""
        txttestamount.Text = ""
        txtworkphone.Text = ""
        ETabControl1.SelectTab(TabPage1)
        txtregno.Focus()
    End Sub

    Private Sub CheckSerial()
        Try
            cmd.CommandText = "select * from StudentPreAdmission where serial='" & txtregno.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                serialexist = True
            Else
                serialexist = False
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub AddRecord()
        Try
            CheckSerial()
            If serialexist = False Then
                If txtregno.Text = "" Then
                    Dim result As DialogResult = MessageBox.Show("Please enter registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    If result = Windows.Forms.DialogResult.OK Then
                        txtregno.Focus()
                    End If
                ElseIf txtfirstname.Text = "" Then
                    Dim result As DialogResult = MessageBox.Show("Please enter name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    If result = Windows.Forms.DialogResult.OK Then
                        txtfirstname.Focus()
                    End If
                Else
                    Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result = Windows.Forms.DialogResult.Yes Then
                        Dim cls As New cPreAdmission()
                        Dim clas As String = nudclass.Value.ToString() + " " + cmbclass.Text
                        Dim name As String = txtfirstname.Text + " " + txtmiddlename.Text + " " + txtlastname.Text
                        cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtregno.Text, CInt(nudyear.Value.ToString()), txtfirstname.Text, txtmiddlename.Text, txtlastname.Text, name, cmbdob.Text, cmbsex.Text, txtfgname.Text, txtmothername.Text, ProfilePic1, txthouseno.Text, txtaddress.Text, txtcity.Text, txtpost.Text, txtdistrict.Text, txtstate.Text, txtpin.Text, txtcountry.Text, txtemail.Text, txthomephone.Text, txtworkphone.Text, txtfax.Text, clas, CInt(nudclass.Value.ToString()), cmbclass.Text, cmbcourse.Text, CDec(txttestamount.Text), CDec(txtothertestamount.Text), CDec(txtanualcoursefee.Text), CDec(txtannualincome.Text), txtpayeename.Text, txtbankname.Text, txtbankbranch.Text, txtbranchaddress.Text, txtbranchcode.Text, txtaccountno.Text, cmbaccounttype.Text, txtmicrcode.Text, txtelectransfer.Text, txtcardholdername.Text, txtcardaddress.Text, txtcardcity.Text, txtcardstate.Text, txtcardpin.Text, txtcardcountry.Text, cmbcardtype.Text, cmbpayvia.Text, txtcardno.Text, CInt(txtexpmm.Text), CInt(txtexpyy.Text))
                        If cls.AddOk = True Then
                            Dim rs As DialogResult = MessageBox.Show("Record added successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If rs = Windows.Forms.DialogResult.OK Then
                                txtfirstname.Focus()
                            End If
                        End If
                    End If
                End If
            Else
                Dim result1 As DialogResult = MessageBox.Show("This record is already exist." + Environment.NewLine + "Please search another serial no...", "Umbrella - Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If result1 = Windows.Forms.DialogResult.OK Then
                    txtregno.Focus()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If txtregno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtregno.Focus()
                End If
            ElseIf txtfirstname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtfirstname.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cPreAdmission()
                    cmd.CommandText = "update StudentPreAdmission set picture=@picture where InsID=@InsID and InsName=@InsName and Period=@Period and serial=@serial"
                    cmd.Parameters.AddWithValue("@InsID", My.Settings.LastOpenedInstituteID)
                    cmd.Parameters.AddWithValue("@InsName", My.Settings.LastOpenedInstitute)
                    cmd.Parameters.AddWithValue("@Period", My.Settings.Period)
                    cmd.Parameters.AddWithValue("@serial", txtregno.Text)
                    Dim ms As New MemoryStream()
                    ProfilePic1.Image.Save(ms, ImageFormat.Jpeg)
                    Dim photo_aray As Byte() = New Byte(ms.Length - 1) {}
                    ms.Position = 0
                    ms.Read(photo_aray, 0, photo_aray.Length)
                    cmd.Parameters.AddWithValue("@picture", photo_aray)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()

                    Dim clas As String = nudclass.Value.ToString() + " " + cmbclass.Text
                    Dim name As String = txtfirstname.Text + " " + txtmiddlename.Text + " " + txtlastname.Text
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtregno.Text, CInt(nudyear.Value.ToString()), txtfirstname.Text, txtmiddlename.Text, txtlastname.Text, name, cmbdob.Text, cmbsex.Text, txtfgname.Text, txtmothername.Text, openFileDLG.FileName, txthouseno.Text, txtaddress.Text, txtcity.Text, txtpost.Text, txtdistrict.Text, txtstate.Text, txtpin.Text, txtcountry.Text, txtemail.Text, txthomephone.Text, txtworkphone.Text, txtfax.Text, clas, CInt(nudclass.Value.ToString()), cmbclass.Text, cmbcourse.Text, CDec(txttestamount.Text), CDec(txtothertestamount.Text), CDec(txtanualcoursefee.Text), CDec(txtannualincome.Text), txtpayeename.Text, txtbankname.Text, txtbankbranch.Text, txtbranchaddress.Text, txtbranchcode.Text, txtaccountno.Text, cmbaccounttype.Text, txtmicrcode.Text, txtelectransfer.Text, txtcardholdername.Text, txtcardaddress.Text, txtcardcity.Text, txtcardstate.Text, txtcardpin.Text, txtcardcountry.Text, cmbcardtype.Text, cmbpayvia.Text, txtcardno.Text, CInt(txtexpmm.Text), CInt(txtexpyy.Text))
                    If cls.UpdateOk = True Then
                        Dim rs As DialogResult = MessageBox.Show("Record updated successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If rs = Windows.Forms.DialogResult.OK Then
                            txtfirstname.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If txtregno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtregno.Focus()
                End If
            ElseIf txtfirstname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtfirstname.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cPreAdmission()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtregno.Text)
                    If cls.DeleteOk = True Then
                        Dim rs As DialogResult = MessageBox.Show("Record deleted successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If rs = Windows.Forms.DialogResult.OK Then
                            ResetForm()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedPreAdmission()
        Try
            cmd.CommandText = "select * from StudentPreAdmission where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and serial='" & StuID & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                cmbaccounttype.Text = dr("accounttype").ToString()
                cmbcardtype.Text = dr("cardtype").ToString()
                cmbclass.Text = dr("classstring").ToString()
                cmbcourse.Text = dr("course").ToString()
                cmbdob.Text = dr("dob").ToString()
                cmbsex.Text = dr("sex").ToString()
                nudclass.Value = CInt(dr("classint").ToString())
                nudyear.Value = CInt(dr("year").ToString())
                txtaccountno.Text = dr("accountno").ToString()
                txtaddress.Text = dr("address").ToString()
                txtannualincome.Text = dr("annualincome").ToString()
                txtanualcoursefee.Text = dr("coursefee").ToString()
                txtbankbranch.Text = dr("bankbrach").ToString()
                txtbankname.Text = dr("bankname").ToString()
                txtbranchaddress.Text = dr("branchaddress").ToString()
                txtbranchcode.Text = dr("branchcode").ToString()
                txtcardaddress.Text = dr("cardaddress").ToString()
                txtcardcity.Text = dr("cardcity").ToString()
                txtcardcountry.Text = dr("cardcountry").ToString()
                txtcardholdername.Text = dr("cardholdername").ToString()
                txtcardno.Text = dr("cardno").ToString()
                txtcardpin.Text = dr("cardpin").ToString()
                txtcardstate.Text = dr("cardstate").ToString()
                txtcity.Text = dr("city").ToString()
                txtcountry.Text = dr("country").ToString()
                txtdistrict.Text = dr("dist").ToString()
                txtelectransfer.Text = dr("electronictransfer").ToString()
                txtemail.Text = dr("email").ToString()
                txtexpmm.Text = dr("expmm").ToString()
                txtexpyy.Text = dr("expyy").ToString()
                txtfax.Text = dr("fax").ToString()
                txtfgname.Text = dr("fgname").ToString()
                txtfirstname.Text = dr("fname").ToString()
                txthomephone.Text = dr("homephone").ToString()
                txthouseno.Text = dr("houseno").ToString()
                txtlastname.Text = dr("lname").ToString()
                txtmicrcode.Text = dr("micrcode").ToString()
                txtmiddlename.Text = dr("mname").ToString()
                txtmothername.Text = dr("mothername").ToString()
                txtothertestamount.Text = dr("othertestfee").ToString()
                txtpayeename.Text = dr("payeename").ToString()
                txtpin.Text = dr("pin").ToString()
                txtpost.Text = dr("post").ToString()
                txtregno.Text = dr("serial").ToString()
                txtstate.Text = dr("state").ToString()
                txttestamount.Text = dr("testfee").ToString()
                txtworkphone.Text = dr("workphone").ToString()
            End If
            dr.Close()
            LoadSelectedPicture(txtregno.Text)
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadSelectedPicture(ByVal stid As String)
        Try
            cmd.CommandText = "select picture from StudentPreAdmission where serial='" & stid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim img As Image = Image.FromStream(ConvertBytesToMemoryStream(dr("picture")))
            Dim newBMP As New Bitmap(95, 124)
            Dim gt_dest As Graphics = Graphics.FromImage(newBMP)
            gt_dest.Clear(Color.White)
            Dim newWidth As Integer = newBMP.Width - 2 * 93
            gt_dest.DrawImage(img, 93, 0, newWidth, newBMP.Height)
            gt_dest.Dispose()
            ProfilePic1.SizeMode = PictureBoxSizeMode.StretchImage
            ProfilePic1.Image = newBMP
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadImage(ByVal sourceControl As Control, ByVal fileSizeLimit As Long)
        Try
            With openFileDLG
                Try
                    .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
                Catch ex As Exception
                    Exit Try
                End Try
                .Filter = "All Image Files|*.bmp;*.jpeg;*.jpg;*.gif;*.png|" + "Bitmap Image (Bitmap Image)|*.bmp|Jpeg Images (Jpeg Images)|*.jpeg|Jpg Images (Jpg Images)|*.jpg|Gif Images (Gif Images)|*.gif|Png Images (Png Images)|*.png"
            End With
            If openFileDLG.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim data() As Byte = ReadBytes(openFileDLG.FileName.ToString())
                If fileSizeLimit > 0 AndAlso data.LongLength > fileSizeLimit Then
                    Throw New ArgumentException("Image is bigger than allowed maximum size!")
                Else
                    Dim ms As New MemoryStream(CType(data, Byte()))
                    If TypeOf sourceControl Is Windows.Forms.PictureBox Then
                        CType(sourceControl, Windows.Forms.PictureBox).Image = Image.FromStream(ms)
                    End If
                End If
            End If
        Catch eX As Exception
            MessageBox.Show(eX.Message)
        Finally
            Cursor.Current = Cursors.Default()
        End Try
    End Sub
#End Region
#Region "Functions..."
    Private Function ReadBytes(ByVal path As String) As Byte()
        Try
            Dim fs As FileStream = New FileStream(path, FileMode.Open, FileAccess.Read)
            Dim reader As BinaryReader = New BinaryReader(fs)
            Dim data() As Byte = reader.ReadBytes(CInt(fs.Length))
            fs.Close()
            reader.Close()
            Return data
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ReadBytes(ByVal data As Image) As Byte()
        Try
            Dim ms As New IO.MemoryStream()
            data.Save(ms, Imaging.ImageFormat.Jpeg)
            Return ms.ToArray()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ConvertBytesToMemoryStream(ByVal ImageData As Byte()) As IO.MemoryStream
        Try
            If IsNothing(ImageData) = True Then
                Return Nothing
            End If
            Return New System.IO.MemoryStream(ImageData)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
#End Region
#Region "Form Events..."
    Private Sub frmStudentPreAdmission_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updatestudentpreadm = False Then
            ControlSetBound()
            LoadCountry()
            LoadState()
            LoadCourse()
            Dim yy As Integer = Date.Now.Year
            nudyear.Minimum = yy - 25
            nudyear.Maximum = yy + 25
            nudyear.Value = yy
            cmbsex.Items.Add(New ComboBoxIconItem("Male", 0))
            cmbsex.Items.Add(New ComboBoxIconItem("Female", 1))
            cmbcardtype.Items.Add(New ComboBoxIconItem("Amex", 0))
            cmbcardtype.Items.Add(New ComboBoxIconItem("Discover", 1))
            cmbcardtype.Items.Add(New ComboBoxIconItem("Mastercard", 2))
            cmbcardtype.Items.Add(New ComboBoxIconItem("Visa", 3))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Cash", 0))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Check", 1))
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadCountry()
            LoadState()
            LoadCourse()
            Dim yy As Integer = Date.Now.Year
            nudyear.Minimum = yy - 25
            nudyear.Maximum = yy + 25
            nudyear.Value = yy
            cmbsex.Items.Add(New ComboBoxIconItem("Male", 0))
            cmbsex.Items.Add(New ComboBoxIconItem("Female", 1))
            cmbcardtype.Items.Add(New ComboBoxIconItem("Amex", 0))
            cmbcardtype.Items.Add(New ComboBoxIconItem("Discover", 1))
            cmbcardtype.Items.Add(New ComboBoxIconItem("Mastercard", 2))
            cmbcardtype.Items.Add(New ComboBoxIconItem("Visa", 3))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Cash", 0))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Check", 1))
            LoadSelectedPreAdmission()
        End If
        If USpreadmission = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbaccounttype.Enabled = False
            cmbcardtype.Enabled = False
            cmbclass.Enabled = False
            cmbcourse.Enabled = False
            cmbdob.Enabled = False
            cmbpayvia.Enabled = False
            cmbsex.Enabled = False
            txtaccountno.ReadOnly = True
            txtaddress.ReadOnly = True
            txtannualincome.ReadOnly = True
            txtanualcoursefee.ReadOnly = True
            txtbankbranch.ReadOnly = True
            txtbankname.ReadOnly = True
            txtbranchaddress.ReadOnly = True
            txtbranchcode.ReadOnly = True
            txtcardaddress.ReadOnly = True
            txtcardcity.ReadOnly = True
            txtcardcountry.ReadOnly = True
            txtcardholdername.ReadOnly = True
            txtcardno.ReadOnly = True
            txtcardpin.ReadOnly = True
            txtcardstate.ReadOnly = True
            txtcity.ReadOnly = True
            txtcountry.ReadOnly = True
            txtdistrict.ReadOnly = True
            txtelectransfer.ReadOnly = True
            txtemail.ReadOnly = True
            txtexpmm.ReadOnly = True
            txtexpyy.ReadOnly = True
            txtfax.ReadOnly = True
            txtfgname.ReadOnly = True
            txtfirstname.ReadOnly = True
            txthomephone.ReadOnly = True
            txthouseno.ReadOnly = True
            txtlastname.ReadOnly = True
            txtmicrcode.ReadOnly = True
            txtmiddlename.ReadOnly = True
            txtmothername.ReadOnly = True
            txtothertestamount.ReadOnly = True
            txtpayeename.ReadOnly = True
            txtpin.ReadOnly = True
            txtpost.ReadOnly = True
            txtregno.ReadOnly = True
            txtstate.ReadOnly = True
            txttestamount.ReadOnly = True
            txtworkphone.ReadOnly = True
            nudclass.Enabled = False
            nudyear.Enabled = False
        End If
        If USstudentcard = "No Access" Then
            cmbcardtype.Enabled = False
            txtcardaddress.PasswordChar = "X"
            txtcardcity.PasswordChar = "X"
            txtcardcountry.PasswordChar = "X"
            txtcardholdername.PasswordChar = "X"
            txtcardno.PasswordChar = "X"
            txtcardpin.PasswordChar = "X"
            txtcardstate.PasswordChar = "X"
            txtexpmm.PasswordChar = "X"
            txtexpyy.PasswordChar = "X"
            txtcardaddress.ReadOnly = True
            txtcardcity.ReadOnly = True
            txtcardcountry.ReadOnly = True
            txtcardholdername.ReadOnly = True
            txtcardno.ReadOnly = True
            txtcardpin.ReadOnly = True
            txtcardstate.ReadOnly = True
            txtexpmm.ReadOnly = True
            txtexpyy.ReadOnly = True
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnupload_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnupload.ClickButtonArea
        LoadImage(ProfilePic1, 999999999)
    End Sub

    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatestudentpreadm = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatestudentpreadm = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatestudentpreadm = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updatestudentpreadm = False Then
            ControlSetBound()
            LoadCountry()
            LoadState()
            LoadCourse()
            Dim yy As Integer = Date.Now.Year
            nudyear.Minimum = yy - 25
            nudyear.Maximum = yy + 25
            nudyear.Value = yy
            cmbsex.Items.Add(New ComboBoxIconItem("Male", 0))
            cmbsex.Items.Add(New ComboBoxIconItem("Female", 1))
            cmbcardtype.Items.Add(New ComboBoxIconItem("Amex", 0))
            cmbcardtype.Items.Add(New ComboBoxIconItem("Discover", 1))
            cmbcardtype.Items.Add(New ComboBoxIconItem("Mastercard", 2))
            cmbcardtype.Items.Add(New ComboBoxIconItem("Visa", 3))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Cash", 0))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Check", 1))
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadCountry()
            LoadState()
            LoadCourse()
            Dim yy As Integer = Date.Now.Year
            nudyear.Minimum = yy - 25
            nudyear.Maximum = yy + 25
            nudyear.Value = yy
            cmbsex.Items.Add(New ComboBoxIconItem("Male", 0))
            cmbsex.Items.Add(New ComboBoxIconItem("Female", 1))
            cmbcardtype.Items.Add(New ComboBoxIconItem("Amex", 0))
            cmbcardtype.Items.Add(New ComboBoxIconItem("Discover", 1))
            cmbcardtype.Items.Add(New ComboBoxIconItem("Mastercard", 2))
            cmbcardtype.Items.Add(New ComboBoxIconItem("Visa", 3))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Cash", 0))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Check", 1))
            LoadSelectedPreAdmission()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Attributes..."
    Private Sub TextBoxKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtaccountno.KeyPress, txtannualincome.KeyPress, txtanualcoursefee.KeyPress, txtbranchcode.KeyPress, txtcardno.KeyPress, txtcardpin.KeyPress, txtemail.KeyPress, txtexpmm.KeyPress, txtexpyy.KeyPress, txtfax.KeyPress, txthomephone.KeyPress, txtmicrcode.KeyPress, txtfirstname.KeyPress, txtmiddlename.KeyPress, txtlastname.KeyPress, txtothertestamount.KeyPress, txtpin.KeyPress, txttestamount.KeyPress, txtworkphone.KeyPress
        If Asc(e.KeyChar) = 32 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtaddress.TextChanged, txtbankbranch.TextChanged, txtbankname.TextChanged, txtbranchaddress.TextChanged, txtcardaddress.TextChanged, txtcardcity.TextChanged, txtcardcountry.TextChanged, txtcardholdername.TextChanged, txtcardstate.TextChanged, txtcity.TextChanged, txtcountry.TextChanged, txtdistrict.TextChanged, txtelectransfer.TextChanged, txtfgname.TextChanged, txtfirstname.TextChanged, txtlastname.TextChanged, txtmiddlename.TextChanged, txtmothername.TextChanged, txtpayeename.TextChanged, txtpost.TextChanged, txtstate.TextChanged, txthouseno.TextChanged
        Dim x As ESAR_Controls.UIControls.TextBox.eTextBox = CType(sender, ESAR_Controls.UIControls.TextBox.eTextBox)
        ctc.ConvertTextBoxValidValue(x)
    End Sub

    Private Sub ComboBoxKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbaccounttype.KeyPress, cmbcardtype.KeyPress, cmbdob.KeyPress, cmbsex.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtregno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtregno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            nudyear.Focus()
        End If
    End Sub

    Private Sub nudyear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudyear.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtfirstname.Focus()
        End If
    End Sub

    Private Sub txtfirstname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfirstname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtmiddlename.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            nudyear.Focus()
        End If
    End Sub

    Private Sub txtmiddlename_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmiddlename.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtlastname.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtfirstname.Focus()
        End If
    End Sub

    Private Sub txtlastname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlastname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtfgname.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtmiddlename.Focus()
        End If
    End Sub

    Private Sub txtfgname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfgname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtmothername.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtlastname.Focus()
        End If
    End Sub

    Private Sub txtmothername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmothername.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbdob.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtfgname.Focus()
        End If
    End Sub

    Private Sub cmbdob_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdob.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbsex.Focus()
        End If
    End Sub

    Private Sub cmbsex_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbsex.KeyDown
        If e.KeyCode = Keys.Enter Then
            txthouseno.Focus()
        End If
    End Sub

    Private Sub txthouseno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txthouseno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtaddress.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbsex.Focus()
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
            txtpost.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtaddress.Focus()
        End If
    End Sub

    Private Sub txtpost_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpost.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtdistrict.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcity.Focus()
        End If
    End Sub

    Private Sub txtdistrict_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdistrict.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtstate.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtpost.Focus()
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
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtemail.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtpin.Focus()
        End If
    End Sub

    Private Sub txtemail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtemail.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txthomephone.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcountry.Focus()
        End If
    End Sub

    Private Sub txthomephone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txthomephone.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtworkphone.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtemail.Focus()
        End If
    End Sub

    Private Sub txtworkphone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtworkphone.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtfax.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txthomephone.Focus()
        End If
    End Sub

    Private Sub txtfax_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfax.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            nudclass.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtworkphone.Focus()
        End If
    End Sub

    Private Sub nudclass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudclass.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbclass.Focus()
        End If
    End Sub

    Private Sub cmbclass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbclass.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbcourse.Focus()
        End If
    End Sub

    Private Sub cmbcourse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcourse.KeyDown
        If e.KeyCode = Keys.Enter Then
            txttestamount.Focus()
        End If
    End Sub

    Private Sub txttestamount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttestamount.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtothertestamount.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbcourse.Focus()
        End If
    End Sub

    Private Sub txtothertestamount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtothertestamount.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtanualcoursefee.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txttestamount.Focus()
        End If
    End Sub

    Private Sub txtanualcoursefee_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtanualcoursefee.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtannualincome.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtothertestamount.Focus()
        End If
    End Sub

    Private Sub txtannualincome_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtannualincome.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            ETabControl1.SelectTab(TabPage2)
            txtpayeename.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtanualcoursefee.Focus()
        End If
    End Sub

    Private Sub txtpayeename_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpayeename.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtbankname.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            ETabControl1.SelectTab(TabPage1)
            txtannualincome.Focus()
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
            txtbranchaddress.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtbankname.Focus()
        End If
    End Sub

    Private Sub txtbranchaddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbranchaddress.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtbranchcode.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtbankbranch.Focus()
        End If
    End Sub

    Private Sub txtbranchcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbranchcode.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtaccountno.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtbranchaddress.Focus()
        End If
    End Sub

    Private Sub txtaccountno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtaccountno.KeyDown
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
            txtcardholdername.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtmicrcode.Focus()
        End If
    End Sub

    Private Sub txtcardholdername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcardholdername.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtcardaddress.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtelectransfer.Focus()
        End If
    End Sub

    Private Sub txtcardaddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcardaddress.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtcardcity.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcardholdername.Focus()
        End If
    End Sub

    Private Sub txtcardcity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcardcity.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtcardstate.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcardaddress.Focus()
        End If
    End Sub

    Private Sub txtcardstate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcardstate.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtcardpin.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcardcity.Focus()
        End If
    End Sub

    Private Sub txtcardpin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcardpin.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtcardcountry.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcardstate.Focus()
        End If
    End Sub

    Private Sub txtcardcountry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcardcountry.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbcardtype.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcardpin.Focus()
        End If
    End Sub

    Private Sub cmbcardtype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcardtype.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbpayvia.Focus()
        End If
    End Sub

    Private Sub cmbpayvia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbpayvia.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcardno.Focus()
        End If
    End Sub

    Private Sub txtcardno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcardno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtexpmm.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbpayvia.Focus()
        End If
    End Sub

    Private Sub txtexpmm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtexpmm.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtexpyy.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcardno.Focus()
        End If
    End Sub

    Private Sub txtexpyy_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtexpyy.KeyDown
        If e.KeyCode = Keys.Up Then
            txtexpmm.Focus()
        End If
    End Sub
#End Region
End Class
#End Region