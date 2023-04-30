#Region "Imports..."
Imports System.IO
Imports ESAR_Controls.UIControls.ComboBox
Imports System.Drawing.Imaging

#End Region
#Region "Class frmStudentAdmission..."
Public Class frmStudentAdmission
#Region "Declaration..."
    Private ACODE As String = ""
    Private TT As String = ""
    Private DGVCourse As New DataGridView()
    Private DGVRegNo As New DataGridView()
    Private ofd As New OpenFileDialog()
    Private openFileDLG As New OpenFileDialog()
    Private serialexist As Boolean = False
    Private preadmissionexist As Boolean = False
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        ACODE = Indx.LoadAdmissionID()
        Dim var As String
        var = CodeIncrement(ACODE)
        Me.txtserialno.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("ADM:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        chksameadd.SetBounds(202, 136, 172, 17)

        Label1.SetBounds(183, 38, 38, 13)
        Label10.SetBounds(299, 11, 17, 13)
        Label11.SetBounds(14, 80, 280, 26)
        Label12.SetBounds(217, 31, 77, 13)
        Label13.SetBounds(15, 193, 136, 13)
        Label14.SetBounds(12, 113, 72, 13)
        Label15.SetBounds(257, 138, 33, 13)
        Label16.SetBounds(216, 44, 34, 13)
        Label17.SetBounds(13, 44, 38, 13)
        Label18.SetBounds(228, 113, 55, 13)
        Label2.SetBounds(22, 66, 86, 13)
        Label3.SetBounds(22, 95, 111, 13)
        Label4.SetBounds(296, 38, 53, 13)
        Label5.SetBounds(296, 66, 67, 13)
        Label6.SetBounds(296, 95, 43, 13)
        Label7.SetBounds(18, 11, 138, 13)
        Label8.SetBounds(233, 11, 17, 13)
        Label9.SetBounds(18, 11, 209, 13)

        cmbaccounttype.SetBounds(181, 190, 136, 21)
        cmbapproved.SetBounds(369, 63, 163, 21)
        cmbcardtype.SetBounds(95, 108, 130, 22)
        cmbclass.SetBounds(424, 91, 108, 21)
        cmbcompetitivexm.SetBounds(311, 80, 66, 21)
        cmbcourse.SetBounds(369, 35, 163, 21)
        cmbdob.SetBounds(57, 41, 121, 21)
        cmbpayvia.SetBounds(290, 109, 87, 22)
        cmbpreadmissionid.SetBounds(143, 92, 147, 21)
        cmbpreadmitted.SetBounds(143, 63, 147, 21)
        cmbrecognized.SetBounds(311, 28, 61, 21)
        cmbsex.SetBounds(259, 40, 113, 22)

        nudclass.SetBounds(369, 92, 49, 21)
        nudyear.SetBounds(227, 37, 63, 21)

        txtaccountno.SetBounds(19, 163, 355, 21)
        txtannualcoursefee.SetBounds(167, 8, 60, 21)
        txtannualincome.SetBounds(233, 8, 60, 21)
        txtbankbranch.SetBounds(19, 83, 355, 21)
        txtbankname.SetBounds(19, 56, 355, 21)
        txtbranchaddress.SetBounds(19, 110, 355, 21)
        txtbranchcode.SetBounds(19, 135, 355, 21)
        txtcardaddress.SetBounds(15, 56, 210, 21)
        txtcardcity.SetBounds(231, 56, 146, 21)
        txtcardcountry.SetBounds(231, 83, 146, 21)
        txtcardholdername.SetBounds(15, 29, 362, 21)
        txtcardno.SetBounds(15, 135, 210, 21)
        txtcardpin.SetBounds(152, 83, 73, 21)
        txtcardstate.SetBounds(15, 83, 131, 21)
        txtelectransfer.SetBounds(19, 242, 355, 21)
        txtemail.SetBounds(15, 33, 361, 21)
        txtexpmm.SetBounds(311, 135, 30, 21)
        txtexpyy.SetBounds(347, 135, 30, 21)
        txtfax.SetBounds(262, 60, 114, 21)
        txtfgname.SetBounds(14, 14, 360, 21)
        txtfirstname.SetBounds(16, 14, 119, 21)
        txthomephone.SetBounds(15, 60, 114, 21)
        txtinstitute.SetBounds(10, 28, 201, 21)
        txtinstituteaddress.SetBounds(10, 55, 362, 21)
        txtinstitutefax.SetBounds(126, 82, 101, 21)
        txtinstitutephone.SetBounds(10, 82, 110, 21)
        txtinstituteuniv.SetBounds(233, 82, 139, 21)
        txtlastname.SetBounds(259, 14, 113, 21)
        txtmicrcode.SetBounds(19, 217, 355, 21)
        txtmiddlename.SetBounds(141, 14, 112, 21)
        txtmothername.SetBounds(14, 41, 360, 21)
        txtpayeename.SetBounds(19, 29, 355, 21)
        txtperaddress.SetBounds(96, 28, 278, 21)
        txtpercity.SetBounds(15, 55, 171, 21)
        txtpercountry.SetBounds(134, 109, 240, 21)
        txtperdist.SetBounds(15, 82, 171, 21)
        txtperhouseno.SetBounds(15, 28, 73, 21)
        txtperpin.SetBounds(15, 109, 113, 21)
        txtperpost.SetBounds(192, 55, 182, 21)
        txtperstate.SetBounds(192, 82, 182, 21)
        txtpreaddress.SetBounds(96, 28, 278, 21)
        txtprecity.SetBounds(15, 55, 169, 21)
        txtprecountry.SetBounds(135, 109, 239, 21)
        txtpredist.SetBounds(15, 82, 169, 21)
        txtprehouseno.SetBounds(15, 28, 73, 21)
        txtprepin.SetBounds(15, 109, 113, 21)
        txtprepost.SetBounds(190, 55, 184, 21)
        txtprestate.SetBounds(190, 82, 184, 21)
        txtprofcourse.SetBounds(17, 28, 360, 21)
        txtprofcourseduration.SetBounds(17, 55, 288, 21)
        txtprofcourseyear.SetBounds(311, 55, 66, 21)
        txtserialno.SetBounds(25, 36, 152, 21)
        txtworkphone.SetBounds(139, 60, 114, 21)

        ProfilePic1.SetBounds(566, 19, 78, 95)
        btnupload.SetBounds(658, 89, 117, 25)
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
            txtcardcountry.AutoCompleteMode = AutoCompleteMode.Suggest
            txtcardcountry.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtcardcountry.AutoCompleteCustomSource = Country
            txtpercountry.AutoCompleteMode = AutoCompleteMode.Suggest
            txtpercountry.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtpercountry.AutoCompleteCustomSource = Country
            txtprecountry.AutoCompleteMode = AutoCompleteMode.Suggest
            txtprecountry.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtprecountry.AutoCompleteCustomSource = Country
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
            txtcardstate.AutoCompleteMode = AutoCompleteMode.Suggest
            txtcardstate.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtcardstate.AutoCompleteCustomSource = State
            txtperstate.AutoCompleteMode = AutoCompleteMode.Suggest
            txtperstate.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtperstate.AutoCompleteCustomSource = State
            txtprestate.AutoCompleteMode = AutoCompleteMode.Suggest
            txtprestate.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtprestate.AutoCompleteCustomSource = State
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
            cmd.CommandText = "select CourseFees from Course where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and CourseName='" & crsname & "' and CourseCode='" & crscode & "' and Duration='" & crsduration & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                txtannualcoursefee.Text = dr("CourseFees").ToString()
            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadDGVRegNo()
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

            DGVRegNo.Rows.Clear()

            Dim indx As Integer = 0
            Dim approved As String = "Yes"
            cmd.CommandText = "select serial,fname,mname,lname from StudentPreAdmission where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVRegNo.Rows.Add()
                DGVRegNo.Rows(indx).Cells(0).Value = dr("serial").ToString()
                DGVRegNo.Rows(indx).Cells(1).Value = dr("fname").ToString() + " " + dr("mname").ToString() + " " + dr("lname").ToString()

                indx = indx + 1
            End While
            dr.Close()
            DGVRegNo.ClearSelection()

            cmbpreadmissionid.AddDataGridView(DGVRegNo, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVRegNo_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVRegNo.CurrentRow.Index
            DGVRegNo.Rows(k).Selected = True
            DGVRegNo.CurrentCell = DGVRegNo.Rows(k).Cells(0)
            StuID = DGVRegNo.Rows(k).Cells(0).Value.ToString()
            cmbpreadmissionid.Text = StuID
            LoadSelectedPreAdmission(cmbpreadmissionid.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedPreAdmission(ByVal StID As String)
        Try
            cmd.CommandText = "select * from StudentPreAdmission where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and serial='" & StID & "'"
            dr = cmd.ExecuteReader
            If dr.Read Then
                cmbaccounttype.Text = dr("accounttype").ToString()
                cmbcardtype.Text = dr("cardtype").ToString()
                cmbclass.Text = dr("classstring").ToString()
                cmbcourse.Text = dr("course").ToString()
                cmbdob.Text = dr("dob").ToString()
                cmbpreadmissionid.Text = dr("serial").ToString()
                cmbsex.Text = dr("sex").ToString()
                nudclass.Value = CInt(dr("classint").ToString())
                nudyear.Value = CInt(dr("year").ToString())
                txtaccountno.Text = dr("accountno").ToString()
                txtannualcoursefee.Text = dr("coursefee").ToString()
                txtannualincome.Text = dr("annualincome").ToString()
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
                txtelectransfer.Text = dr("electronictransfer").ToString()
                txtemail.Text = dr("email").ToString()
                txtexpmm.Text = dr("expmm").ToString()
                txtexpyy.Text = dr("expyy").ToString()
                txtfax.Text = dr("fax").ToString()
                txtfgname.Text = dr("fgname").ToString()
                txtfirstname.Text = dr("fname").ToString()
                txthomephone.Text = dr("homephone").ToString()
                txtlastname.Text = dr("lname").ToString()
                txtmicrcode.Text = dr("micrcode").ToString()
                txtmiddlename.Text = dr("mname").ToString()
                txtmothername.Text = dr("mothername").ToString()
                txtpayeename.Text = dr("payeename").ToString()
                txtpreaddress.Text = dr("address").ToString()
                txtprecity.Text = dr("city").ToString()
                txtprecountry.Text = dr("country").ToString()
                txtpredist.Text = dr("dist").ToString()
                txtprehouseno.Text = dr("houseno").ToString()
                txtprepin.Text = dr("pin").ToString()
                txtprepost.Text = dr("post").ToString()
                txtprestate.Text = dr("state").ToString()
                txtworkphone.Text = dr("workphone").ToString()
            End If
            dr.Close()
            LoadSelectedPicture(cmbpreadmissionid.Text)
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

    Private Sub ResetForm()
        updatestudentadm = False
        ProfilePic1.Image = Global.Umbrella.My.Resources.people
        dgviewxm.Rows.Clear()
        If ISDAutoID = "Yes" Then
            GetCode()
        Else
            txtserialno.Text = ""
        End If
        nudclass.Value = 1
        Dim yy As Integer = Date.Now.Year
        nudyear.Maximum = yy + 50
        nudyear.Minimum = yy - 50
        nudyear.Value = yy
        cmbaccounttype.Text = ""
        cmbapproved.Text = ""
        cmbcardtype.Text = ""
        cmbclass.Text = ""
        cmbcompetitivexm.Text = ""
        cmbcourse.Text = ""
        cmbdob.Text = ""
        cmbpreadmissionid.Text = ""
        cmbpreadmitted.Text = ""
        cmbrecognized.Text = ""
        cmbsex.Text = ""
        txtaccountno.Text = ""
        txtannualcoursefee.Text = ""
        txtannualincome.Text = ""
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
        txtelectransfer.Text = ""
        txtemail.Text = ""
        txtexpmm.Text = ""
        txtexpyy.Text = ""
        txtfax.Text = ""
        txtfgname.Text = ""
        txtfirstname.Text = ""
        txthomephone.Text = ""
        txtinstitute.Text = ""
        txtinstituteaddress.Text = ""
        txtinstitutefax.Text = ""
        txtinstitutephone.Text = ""
        txtinstituteuniv.Text = ""
        txtlastname.Text = ""
        txtmicrcode.Text = ""
        txtmiddlename.Text = ""
        txtmothername.Text = ""
        txtpayeename.Text = ""
        txtperaddress.Text = ""
        txtpercity.Text = ""
        txtpercountry.Text = ""
        txtperdist.Text = ""
        txtperhouseno.Text = ""
        txtperpin.Text = ""
        txtperpost.Text = ""
        txtperstate.Text = ""
        txtpreaddress.Text = ""
        txtprecity.Text = ""
        txtprecountry.Text = ""
        txtpredist.Text = ""
        txtprehouseno.Text = ""
        txtprepin.Text = ""
        txtprepost.Text = ""
        txtprestate.Text = ""
        txtprofcourse.Text = ""
        txtprofcourseduration.Text = ""
        txtprofcourseyear.Text = ""
        txtworkphone.Text = ""
        chksameadd.Checked = False
        ETabControl1.SelectTab(TabPage1)
        txtserialno.Focus()
    End Sub

    Private Sub CheckSerial()
        Try
            cmd.CommandText = "select * from StudentAdmision where serial='" & txtserialno.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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

    Private Sub CheckPreAdmissionID()
        Try
            If cmbpreadmitted.Text = "Yes" Then
                cmd.CommandText = "select * from StudentAdmision where preadmissionid='" & cmbpreadmissionid.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    preadmissionexist = True
                Else
                    preadmissionexist = False
                End If
                dr.Close()
            End If
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub AddRecord()
        Try
            CheckSerial()
            If serialexist = False Then
                CheckPreAdmissionID()
                If preadmissionexist = False Then
                    If txtserialno.Text = "" Then
                        Dim result As DialogResult = MessageBox.Show("Please enter serial no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result = Windows.Forms.DialogResult.OK Then
                            txtserialno.Focus()
                        End If
                    ElseIf cmbcourse.Text = "" Then
                        Dim result As DialogResult = MessageBox.Show("Please enter course name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result = Windows.Forms.DialogResult.OK Then
                            cmbcourse.Focus()
                        End If
                    ElseIf txtfirstname.Text = "" Then
                        Dim result As DialogResult = MessageBox.Show("Please enter first name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result = Windows.Forms.DialogResult.OK Then
                            txtfirstname.Focus()
                        End If
                    ElseIf txtlastname.Text = "" Then
                        Dim result As DialogResult = MessageBox.Show("Please enter last name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result = Windows.Forms.DialogResult.OK Then
                            txtlastname.Focus()
                        End If
                    ElseIf dgviewxm.Rows.Count <= 0 Then
                        Dim result As DialogResult = MessageBox.Show("Please enter candidate's last exam record.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result = Windows.Forms.DialogResult.OK Then
                            ETabControl1.SelectTab(TabPage2)
                            dgviewxm.Focus()
                        End If
                    Else
                        Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If result = Windows.Forms.DialogResult.Yes Then
                            Dim cls As New cStudentAdmission()
                            Dim clas As String = nudclass.Value.ToString() + " " + cmbclass.Text
                            Dim name As String = txtfirstname.Text + " " + txtmiddlename.Text + " " + txtlastname.Text
                            cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtserialno.Text, CInt(nudyear.Value.ToString()), cmbpreadmitted.Text, cmbpreadmissionid.Text, cmbcourse.Text, cmbapproved.Text, clas, CInt(nudclass.Value.ToString()), cmbclass.Text, ProfilePic1, txtfirstname.Text, txtmiddlename.Text, txtlastname.Text, name, cmbdob.Text, cmbsex.Text, txtfgname.Text, txtmothername.Text, CDec(txtannualcoursefee.Text), CDec(txtannualincome.Text), txtprehouseno.Text, txtpreaddress.Text, txtprecity.Text, txtprepost.Text, txtpredist.Text, txtprestate.Text, txtprepin.Text, txtprecountry.Text, txtperhouseno.Text, txtperaddress.Text, txtpercity.Text, txtperpost.Text, txtperdist.Text, txtperstate.Text, txtperpin.Text, txtpercountry.Text, txtprofcourse.Text, txtprofcourseduration.Text, CInt(txtprofcourseyear.Text), cmbcompetitivexm.Text, txtinstitute.Text, cmbrecognized.Text, txtinstituteaddress.Text, txtinstitutephone.Text, txtinstitutefax.Text, txtinstituteuniv.Text, txtpayeename.Text, txtbankname.Text, txtbankbranch.Text, txtbranchaddress.Text, txtbranchcode.Text, txtaccountno.Text, cmbaccounttype.Text, txtmicrcode.Text, txtelectransfer.Text, txtcardholdername.Text, txtcardaddress.Text, txtcardcity.Text, txtcardstate.Text, txtcardpin.Text, txtcardcountry.Text, cmbcardtype.Text, cmbpayvia.Text, txtcardno.Text, CInt(txtexpmm.Text), CInt(txtexpyy.Text), txtemail.Text, txthomephone.Text, txtworkphone.Text, txtfax.Text)
                            If dgviewxm.Rows.Count > 0 Then
                                For i As Integer = 0 To dgviewxm.Rows.Count - 1
                                    Dim exam As String = dgviewxm.Rows(i).Cells(0).Value.ToString()
                                    Dim board As String = dgviewxm.Rows(i).Cells(1).Value.ToString()
                                    Dim subjects As String = dgviewxm.Rows(i).Cells(2).Value.ToString()
                                    Dim year As Integer = CInt(dgviewxm.Rows(i).Cells(3).Value.ToString())
                                    Dim marks As Decimal = CDec(dgviewxm.Rows(i).Cells(4).Value.ToString())
                                    Dim division As String = dgviewxm.Rows(i).Cells(5).Value.ToString()
                                    cls.AddAdmissionExam(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtserialno.Text, txtfirstname.Text, txtmiddlename.Text, txtlastname.Text, name, exam, board, subjects, year, marks, division)
                                Next
                            End If
                            If cls.AddOk = True And cls.AddXMOk = True Then
                                Dim result1 As DialogResult = MessageBox.Show("Record added successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                If result1 = Windows.Forms.DialogResult.OK Then
                                    nudyear.Focus()
                                End If
                            End If
                        End If
                    End If
                Else
                    Dim result1 As DialogResult = MessageBox.Show("This record is already exist." + Environment.NewLine + "Please search another preadmission record...", "Umbrella - Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If result1 = Windows.Forms.DialogResult.OK Then
                        cmbpreadmissionid.Focus()
                    End If
                End If
            Else
                Dim result1 As DialogResult = MessageBox.Show("This record is already exist." + Environment.NewLine + "Please search another serial no...", "Umbrella - Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If result1 = Windows.Forms.DialogResult.OK Then
                    txtserialno.Focus()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If txtserialno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter serial no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtserialno.Focus()
                End If
            ElseIf cmbcourse.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter course name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbcourse.Focus()
                End If
            ElseIf txtfirstname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter first name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtfirstname.Focus()
                End If
            ElseIf txtlastname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter last name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtlastname.Focus()
                End If
            ElseIf dgviewxm.Rows.Count <= 0 Then
                Dim result As DialogResult = MessageBox.Show("Please enter candidate's last exam record.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    ETabControl1.SelectTab(TabPage2)
                    dgviewxm.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cStudentAdmission()
                    Dim clas As String = nudclass.Value.ToString() + " " + cmbclass.Text
                    Dim name As String = txtfirstname.Text + " " + txtmiddlename.Text + " " + txtlastname.Text
                    cmd.CommandText = "update StudentAdmision set picture=@picture where InsID=@InsID and InsName=@InsName and Period=@Period and serial=@serial"
                    cmd.Parameters.AddWithValue("@InsID", My.Settings.LastOpenedInstituteID)
                    cmd.Parameters.AddWithValue("@InsName", My.Settings.LastOpenedInstitute)
                    cmd.Parameters.AddWithValue("@Period", My.Settings.Period)
                    cmd.Parameters.AddWithValue("@serial", txtserialno.Text)
                    Dim ms As New MemoryStream()
                    ProfilePic1.Image.Save(ms, ImageFormat.Jpeg)
                    Dim photo_aray As Byte() = New Byte(ms.Length - 1) {}
                    ms.Position = 0
                    ms.Read(photo_aray, 0, photo_aray.Length)
                    cmd.Parameters.AddWithValue("@picture", photo_aray)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()

                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtserialno.Text, CInt(nudyear.Value.ToString()), cmbpreadmitted.Text, cmbpreadmissionid.Text, cmbcourse.Text, cmbapproved.Text, clas, CInt(nudclass.Value.ToString()), cmbclass.Text, openFileDLG.FileName, txtfirstname.Text, txtmiddlename.Text, txtlastname.Text, name, cmbdob.Text, cmbsex.Text, txtfgname.Text, txtmothername.Text, CDec(txtannualcoursefee.Text), CDec(txtannualincome.Text), txtprehouseno.Text, txtpreaddress.Text, txtprecity.Text, txtprepost.Text, txtpredist.Text, txtprestate.Text, txtprepin.Text, txtprecountry.Text, txtperhouseno.Text, txtperaddress.Text, txtpercity.Text, txtperpost.Text, txtperdist.Text, txtperstate.Text, txtperpin.Text, txtpercountry.Text, txtprofcourse.Text, txtprofcourseduration.Text, CInt(txtprofcourseyear.Text), cmbcompetitivexm.Text, txtinstitute.Text, cmbrecognized.Text, txtinstituteaddress.Text, txtinstitutephone.Text, txtinstitutefax.Text, txtinstituteuniv.Text, txtpayeename.Text, txtbankname.Text, txtbankbranch.Text, txtbranchaddress.Text, txtbranchcode.Text, txtaccountno.Text, cmbaccounttype.Text, txtmicrcode.Text, txtelectransfer.Text, txtcardholdername.Text, txtcardaddress.Text, txtcardcity.Text, txtcardstate.Text, txtcardpin.Text, txtcardcountry.Text, cmbcardtype.Text, cmbpayvia.Text, txtcardno.Text, CInt(txtexpmm.Text), CInt(txtexpyy.Text), txtemail.Text, txthomephone.Text, txtworkphone.Text, txtfax.Text)
                    If dgviewxm.Rows.Count > 0 Then
                        cmd.CommandText = "delete from StudentAdmisionExam where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and stuid='" & txtserialno.Text & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        For i As Integer = 0 To dgviewxm.Rows.Count - 1
                            Dim exam As String = dgviewxm.Rows(i).Cells(0).Value.ToString()
                            Dim board As String = dgviewxm.Rows(i).Cells(1).Value.ToString()
                            Dim subjects As String = dgviewxm.Rows(i).Cells(2).Value.ToString()
                            Dim year As Integer = CInt(dgviewxm.Rows(i).Cells(3).Value.ToString())
                            Dim marks As Decimal = CDec(dgviewxm.Rows(i).Cells(4).Value.ToString())
                            Dim division As String = dgviewxm.Rows(i).Cells(5).Value.ToString()
                            cls.UpdateAdmissionExam(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtserialno.Text, txtfirstname.Text, txtmiddlename.Text, txtlastname.Text, name, exam, board, subjects, year, marks, division)
                        Next
                    End If
                    If cls.UpdateOk = True And cls.UpdateXMOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            nudyear.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If txtserialno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter serial no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtserialno.Focus()
                End If
            ElseIf cmbcourse.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter course name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbcourse.Focus()
                End If
            ElseIf txtfirstname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter first name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtfirstname.Focus()
                End If
            ElseIf txtlastname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter last name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtlastname.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cStudentAdmission()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtserialno.Text)
                    If cls.DeleteOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record deleted successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            txtlastname.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedAdmission()
        Try
            cmd.CommandText = "select * from StudentAdmision where serial='" & StuID & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                Dim img As Image = Image.FromStream(ConvertBytesToMemoryStream(dr("picture")))
                Dim newBMP As New Bitmap(95, 124)
                Dim gt_dest As Graphics = Graphics.FromImage(newBMP)
                gt_dest.Clear(Color.White)
                Dim newWidth As Integer = newBMP.Width - 2 * 93
                gt_dest.DrawImage(img, 93, 0, newWidth, newBMP.Height)
                gt_dest.Dispose()
                ProfilePic1.SizeMode = PictureBoxSizeMode.StretchImage
                ProfilePic1.Image = newBMP
                nudclass.Value = CInt(dr("classint").ToString())
                nudyear.Value = CInt(dr("year").ToString())
                cmbaccounttype.Text = dr("accounttype").ToString()
                cmbapproved.Text = dr("approved").ToString()
                cmbcardtype.Text = dr("cardtype").ToString()
                cmbclass.Text = dr("classstring").ToString()
                cmbcompetitivexm.Text = dr("competitiveexam").ToString()
                cmbcourse.Text = dr("course").ToString()
                cmbdob.Text = dr("dob").ToString()
                cmbpreadmissionid.Text = dr("preadmissionid").ToString()
                cmbpreadmitted.Text = dr("preadmitted").ToString()
                cmbrecognized.Text = dr("recognized").ToString()
                cmbsex.Text = dr("sex").ToString()
                txtaccountno.Text = dr("accountno").ToString()
                txtannualcoursefee.Text = dr("coursefee").ToString()
                txtannualincome.Text = dr("annualincome").ToString()
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
                txtelectransfer.Text = dr("electronictransfer").ToString()
                txtemail.Text = dr("email").ToString()
                txtexpmm.Text = dr("expmm").ToString()
                txtexpyy.Text = dr("expyy").ToString()
                txtfax.Text = dr("fax").ToString()
                txtfgname.Text = dr("fgname").ToString()
                txtfirstname.Text = dr("fname").ToString()
                txthomephone.Text = dr("homephone").ToString()
                txtinstitute.Text = dr("institute").ToString()
                txtinstituteaddress.Text = dr("instituteaddress").ToString()
                txtinstitutefax.Text = dr("institutefax").ToString()
                txtinstitutephone.Text = dr("institutephone").ToString()
                txtinstituteuniv.Text = dr("instituteuniv").ToString()
                txtlastname.Text = dr("lname").ToString()
                txtmicrcode.Text = dr("micrcode").ToString()
                txtmiddlename.Text = dr("mname").ToString()
                txtmothername.Text = dr("mothername").ToString()
                txtpayeename.Text = dr("payeename").ToString()
                txtperaddress.Text = dr("peraddress").ToString()
                txtpercity.Text = dr("percity").ToString()
                txtpercountry.Text = dr("percountry").ToString()
                txtperdist.Text = dr("perdist").ToString()
                txtperhouseno.Text = dr("perhouseno").ToString()
                txtperpin.Text = dr("perpin").ToString()
                txtperpost.Text = dr("perpost").ToString()
                txtperstate.Text = dr("perstate").ToString()
                txtpreaddress.Text = dr("preaddress").ToString()
                txtprecity.Text = dr("precity").ToString()
                txtprecountry.Text = dr("precountry").ToString()
                txtpredist.Text = dr("predist").ToString()
                txtprehouseno.Text = dr("prehouseno").ToString()
                txtprepin.Text = dr("prepin").ToString()
                txtprepost.Text = dr("prepost").ToString()
                txtprestate.Text = dr("prestate").ToString()
                txtprofcourse.Text = dr("profcourse").ToString()
                txtprofcourseduration.Text = dr("profcourseduration").ToString()
                txtprofcourseyear.Text = dr("profcourseyear").ToString()
                txtserialno.Text = dr("serial").ToString()
                txtworkphone.Text = dr("workphone").ToString()
            End If
            dr.Close()
            LoadSelectedAdmissionExam(txtserialno.Text)
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadSelectedAdmissionExam(ByVal SerialNo As String)
        Try
            Dim i As Integer = 0
            cmd.CommandText = "select * from StudentAdmisionExam where stuid='" & SerialNo & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewxm.Rows.Add()
                dgviewxm.Rows(i).Cells(0).Value = dr("exam").ToString()
                dgviewxm.Rows(i).Cells(1).Value = dr("board").ToString()
                dgviewxm.Rows(i).Cells(2).Value = dr("subject").ToString()
                dgviewxm.Rows(i).Cells(3).Value = dr("passingyear").ToString()
                dgviewxm.Rows(i).Cells(4).Value = dr("marks").ToString()
                dgviewxm.Rows(i).Cells(5).Value = dr("division").ToString()
                i = i + 1
            End While
            dr.Close()
        Catch ex As Exception
            dr.Close()
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
#Region "Function..."
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
    Private Sub frmStudentAdmission_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        updatestudentadm = False
        StuID = ""
        StuName = ""
    End Sub

    Private Sub frmStudentAdmission_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updatestudentadm = False Then
            ControlSetBound()
            LoadCountry()
            LoadState()
            LoadCourse()
            LoadDGVRegNo()
            Dim yy As Integer = Date.Now.Year
            nudyear.Maximum = yy + 50
            nudyear.Minimum = yy - 50
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
            LoadDGVRegNo()
            Dim yy As Integer = Date.Now.Year
            nudyear.Maximum = yy + 50
            nudyear.Minimum = yy - 50
            nudyear.Value = yy
            cmbsex.Items.Add(New ComboBoxIconItem("Male", 0))
            cmbsex.Items.Add(New ComboBoxIconItem("Female", 1))
            cmbcardtype.Items.Add(New ComboBoxIconItem("Amex", 0))
            cmbcardtype.Items.Add(New ComboBoxIconItem("Discover", 1))
            cmbcardtype.Items.Add(New ComboBoxIconItem("Mastercard", 2))
            cmbcardtype.Items.Add(New ComboBoxIconItem("Visa", 3))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Cash", 0))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Check", 1))
            LoadSelectedAdmission()
        End If
        If USadmission = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbaccounttype.Enabled = False
            cmbapproved.Enabled = False
            cmbcardtype.Enabled = False
            cmbclass.Enabled = False
            cmbcompetitivexm.Enabled = False
            cmbcourse.Enabled = False
            cmbdob.Enabled = False
            cmbpayvia.Enabled = False
            cmbpreadmissionid.Enabled = False
            cmbpreadmitted.Enabled = False
            cmbrecognized.Enabled = False
            cmbsex.Enabled = False
            txtaccountno.ReadOnly = True
            txtannualcoursefee.ReadOnly = True
            txtannualincome.ReadOnly = True
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
            txtelectransfer.ReadOnly = True
            txtemail.ReadOnly = True
            txtexpmm.ReadOnly = True
            txtexpyy.ReadOnly = True
            txtfax.ReadOnly = True
            txtfgname.ReadOnly = True
            txtfirstname.ReadOnly = True
            txthomephone.ReadOnly = True
            txtinstitute.ReadOnly = True
            txtinstituteaddress.ReadOnly = True
            txtinstitutefax.ReadOnly = True
            txtinstitutephone.ReadOnly = True
            txtinstituteuniv.ReadOnly = True
            txtlastname.ReadOnly = True
            txtmicrcode.ReadOnly = True
            txtmiddlename.ReadOnly = True
            txtmothername.ReadOnly = True
            txtpayeename.ReadOnly = True
            txtperaddress.ReadOnly = True
            txtpercity.ReadOnly = True
            txtpercountry.ReadOnly = True
            txtperdist.ReadOnly = True
            txtperhouseno.ReadOnly = True
            txtperpin.ReadOnly = True
            txtperpost.ReadOnly = True
            txtperstate.ReadOnly = True
            txtpreaddress.ReadOnly = True
            txtprecity.ReadOnly = True
            txtprecountry.ReadOnly = True
            txtpredist.ReadOnly = True
            txtprehouseno.ReadOnly = True
            txtprepin.ReadOnly = True
            txtprepost.ReadOnly = True
            txtprestate.ReadOnly = True
            txtprofcourse.ReadOnly = True
            txtprofcourseduration.ReadOnly = True
            txtprofcourseyear.ReadOnly = True
            txtserialno.ReadOnly = True
            txtworkphone.ReadOnly = True
            dgviewxm.Enabled = False
            lnkexam.Enabled = False
            chksameadd.Enabled = False
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
    Private Sub btnupload_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnupload.ClickButtonArea
        LoadImage(ProfilePic1, 999999999)
    End Sub

    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatestudentadm = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatestudentadm = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatestudentadm = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updatestudentadm = False Then
            ControlSetBound()
            LoadCountry()
            LoadState()
            LoadCourse()
            LoadDGVRegNo()
            Dim yy As Integer = Date.Now.Year
            nudyear.Maximum = yy + 50
            nudyear.Minimum = yy - 50
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
            LoadDGVRegNo()
            Dim yy As Integer = Date.Now.Year
            nudyear.Maximum = yy + 50
            nudyear.Minimum = yy - 50
            nudyear.Value = yy
            cmbsex.Items.Add(New ComboBoxIconItem("Male", 0))
            cmbsex.Items.Add(New ComboBoxIconItem("Female", 1))
            cmbcardtype.Items.Add(New ComboBoxIconItem("Amex", 0))
            cmbcardtype.Items.Add(New ComboBoxIconItem("Discover", 1))
            cmbcardtype.Items.Add(New ComboBoxIconItem("Mastercard", 2))
            cmbcardtype.Items.Add(New ComboBoxIconItem("Visa", 3))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Cash", 0))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Check", 1))
            LoadSelectedAdmission()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Attributes..."
    Private Sub TextBoxKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtannualcoursefee.KeyPress, txtannualincome.KeyPress, txtbranchcode.KeyPress, txtcardno.KeyPress, txtcardpin.KeyPress, txtexpmm.KeyPress, txtexpyy.KeyPress, txtfirstname.KeyPress, txtinstitutefax.KeyPress, txtinstitutephone.KeyPress, txtlastname.KeyPress, txtmiddlename.KeyPress, txtperpin.KeyPress, txtprepin.KeyPress, txtprofcourseyear.KeyPress
        If Asc(e.KeyChar) = 32 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtprehouseno.TextChanged, txtperhouseno.TextChanged, txtbankbranch.TextChanged, txtbankname.TextChanged, txtbranchaddress.TextChanged, txtcardaddress.TextChanged, txtcardcity.TextChanged, txtcardcountry.TextChanged, txtcardholdername.TextChanged, txtcardstate.TextChanged, txtelectransfer.TextChanged, txtfgname.TextChanged, txtfirstname.TextChanged, txtinstitute.TextChanged, txtinstituteaddress.TextChanged, txtinstituteuniv.TextChanged, txtlastname.TextChanged, txtmicrcode.TextChanged, txtmiddlename.TextChanged, txtmothername.TextChanged, txtpayeename.TextChanged, txtperaddress.TextChanged, txtpercity.TextChanged, txtpercountry.TextChanged, txtperdist.TextChanged, txtperpost.TextChanged, txtperstate.TextChanged, txtpreaddress.TextChanged, txtprecity.TextChanged, txtprecountry.TextChanged, txtpredist.TextChanged, txtprepost.TextChanged, txtprestate.TextChanged, txtprofcourse.TextChanged
        Dim x As ESAR_Controls.UIControls.TextBox.eTextBox = CType(sender, ESAR_Controls.UIControls.TextBox.eTextBox)
        ctc.ConvertTextBoxValidValue(x)
    End Sub

    Private Sub ComboBoxKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbaccounttype.KeyPress, cmbapproved.KeyPress, cmbclass.KeyPress, cmbcompetitivexm.KeyPress, cmbcourse.KeyPress, cmbpreadmissionid.KeyPress, cmbpreadmitted.KeyPress, cmbrecognized.KeyPress, cmbcardtype.KeyPress, cmbdob.KeyPress, cmbsex.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtserialno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtserialno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            nudyear.Focus()
        End If
    End Sub

    Private Sub nudyear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudyear.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbpreadmitted.Focus()
        End If
    End Sub

    Private Sub cmbpreadmitted_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbpreadmitted.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbpreadmitted.Text = "Yes" Then
                cmbpreadmissionid.Focus()
            Else
                cmbcourse.Focus()
            End If
        End If
    End Sub

    Private Sub cmbpreadmitted_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbpreadmitted.TextChanged
        If cmbpreadmitted.Text = "Yes" Then
            Label3.Visible = True
            cmbpreadmissionid.Visible = True
        Else
            Label3.Visible = False
            cmbpreadmissionid.Visible = False
        End If
    End Sub

    Private Sub cmbpreadmissionid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbpreadmissionid.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbcourse.Focus()
        End If
    End Sub

    Private Sub cmbcourse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcourse.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbapproved.Focus()
        End If
    End Sub

    Private Sub cmbapproved_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbapproved.KeyDown
        If e.KeyCode = Keys.Enter Then
            nudclass.Focus()
        End If
    End Sub

    Private Sub nudclass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudclass.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbclass.Focus()
        End If
    End Sub

    Private Sub cmbclass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbclass.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtfirstname.Focus()
        End If
    End Sub

    Private Sub txtfirstname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfirstname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtmiddlename.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbclass.Focus()
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
            cmbdob.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtmiddlename.Focus()
        End If
    End Sub

    Private Sub cmbdob_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdob.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbsex.Focus()
        End If
    End Sub

    Private Sub cmbsex_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbsex.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtfgname.Focus()
        End If
    End Sub

    Private Sub txtfgname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfgname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtmothername.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbsex.Focus()
        End If
    End Sub

    Private Sub txtmothername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmothername.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtannualcoursefee.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtfgname.Focus()
        End If
    End Sub

    Private Sub txtannualcoursefee_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtannualcoursefee.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtannualincome.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtmothername.Focus()
        End If
    End Sub

    Private Sub txtannualincome_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtannualincome.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtprehouseno.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtannualcoursefee.Focus()
        End If
    End Sub

    Private Sub txtprehouseno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtprehouseno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtpreaddress.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtannualincome.Focus()
        End If
    End Sub

    Private Sub txtpreaddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpreaddress.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtprecity.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtprehouseno.Focus()
        End If
    End Sub

    Private Sub txtprecity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtprecity.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtprepost.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtpreaddress.Focus()
        End If
    End Sub

    Private Sub txtprepost_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtprepost.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtpredist.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtprecity.Focus()
        End If
    End Sub

    Private Sub txtpredist_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpredist.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtprestate.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtprepost.Focus()
        End If
    End Sub

    Private Sub txtprestate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtprestate.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtprepin.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtpredist.Focus()
        End If
    End Sub

    Private Sub txtprepin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtprepin.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtprecountry.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtprestate.Focus()
        End If
    End Sub

    Private Sub txtprecountry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtprecountry.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtperhouseno.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtprepin.Focus()
        End If
    End Sub

    Private Sub txtperhouseno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtperhouseno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtperaddress.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtprecountry.Focus()
        End If
    End Sub

    Private Sub txtperaddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtperaddress.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtpercity.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtperhouseno.Focus()
        End If
    End Sub

    Private Sub txtpercity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpercity.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtperpost.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtperaddress.Focus()
        End If
    End Sub

    Private Sub txtperpost_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtperpost.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtperdist.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtpercity.Focus()
        End If
    End Sub

    Private Sub txtperdist_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtperdist.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtperstate.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtperpost.Focus()
        End If
    End Sub

    Private Sub txtperstate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtperstate.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtperpin.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtperdist.Focus()
        End If
    End Sub

    Private Sub txtperpin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtperpin.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtpercountry.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtperstate.Focus()
        End If
    End Sub

    Private Sub txtpercountry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpercountry.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            ETabControl1.SelectTab(TabPage2)
            txtprofcourse.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtperpin.Focus()
        End If
    End Sub

    Private Sub txtprofcourse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtprofcourse.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtprofcourseduration.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            ETabControl1.SelectTab(TabPage1)
            txtpercountry.Focus()
        End If
    End Sub

    Private Sub txtprofcourseduration_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtprofcourseduration.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtprofcourseyear.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtprofcourse.Focus()
        End If
    End Sub

    Private Sub txtprofcourseyear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtprofcourseyear.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbcompetitivexm.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtprofcourseduration.Focus()
        End If
    End Sub

    Private Sub cmbcompetitivexm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcompetitivexm.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtinstitute.Focus()
        End If
    End Sub

    Private Sub txtinstitute_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtinstitute.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbrecognized.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbcompetitivexm.Focus()
        End If
    End Sub

    Private Sub cmbrecognized_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbrecognized.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtinstituteaddress.Focus()
        End If
    End Sub

    Private Sub txtinstituteaddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtinstituteaddress.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtinstitutephone.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbrecognized.Focus()
        End If
    End Sub

    Private Sub txtinstitutephone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtinstitutephone.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtinstitutefax.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtinstituteaddress.Focus()
        End If
    End Sub

    Private Sub txtinstitutefax_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtinstitutefax.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtinstituteuniv.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtinstitutephone.Focus()
        End If
    End Sub

    Private Sub txtinstituteuniv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtinstituteuniv.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            ETabControl1.SelectTab(TabPage3)
            txtpayeename.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtinstitutefax.Focus()
        End If
    End Sub

    Private Sub txtpayeename_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpayeename.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtbankname.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            ETabControl1.SelectTab(TabPage2)
            txtinstituteuniv.Focus()
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
        ElseIf e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtemail.Focus()
        End If
    End Sub

    Private Sub txtemail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtemail.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txthomephone.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtexpyy.Focus()
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
        If e.KeyCode = Keys.Up Then
            txtworkphone.Focus()
        End If
    End Sub

    Private Sub chksameadd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksameadd.CheckedChanged
        If chksameadd.Checked = True Then
            txtperaddress.Text = txtpreaddress.Text
            txtpercity.Text = txtprecity.Text
            txtpercountry.Text = txtprecountry.Text
            txtperdist.Text = txtpredist.Text
            txtperhouseno.Text = txtprehouseno.Text
            txtperpin.Text = txtprepin.Text
            txtperpost.Text = txtprepost.Text
            txtperstate.Text = txtprestate.Text
        Else
            txtperaddress.Text = ""
            txtpercity.Text = ""
            txtpercountry.Text = ""
            txtperdist.Text = ""
            txtperhouseno.Text = ""
            txtperpin.Text = ""
            txtperpost.Text = ""
            txtperstate.Text = ""
        End If
    End Sub

    Private Sub lnkexam_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkexam.LinkClicked
        dgviewxm.Rows.Add()
        dgviewxm.ClearSelection()
    End Sub
#End Region
#Region "DGViewEvents..."
    Private Sub dgviewxm_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgviewxm.LostFocus
        dgviewxm.ClearSelection()
    End Sub
#End Region
End Class
#End Region