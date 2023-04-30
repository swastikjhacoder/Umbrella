#Region "Imports..."
Imports System.Data
Imports System.Data.SqlClient
Imports Umbrella.UIControls
Imports System.IO
Imports ESAR_Controls.UIControls.ComboBox
Imports ESAR_Controls.UIControls.TextBox
Imports System.Drawing.Imaging

#End Region
#Region "Class frmEnrollEmployee..."
Public Class frmEnrollEmployee
#Region "Declarations..."
    Private ACODE As String = ""
    Private TT As String = ""
    Private DGVDepartment As New Windows.Forms.DataGridView()
    Private DGVDesignation As New Windows.Forms.DataGridView()
    Private DGVPayscale As New Windows.Forms.DataGridView()
    Private ofd As New OpenFileDialog()
    Private EmpExist As Boolean = False
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        ACODE = Indx.LoadEmpID()
        Dim var As String
        var = CodeIncrement(ACODE)
        Me.txtregistrationno.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("EMP:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        Label2.SetBounds(121, 33, 45, 13)
        Label3.SetBounds(15, 60, 81, 13)
        Label4.SetBounds(15, 141, 75, 13)
        Label5.SetBounds(337, 141, 85, 13)
        Label6.SetBounds(15, 168, 46, 13)
        Label7.SetBounds(337, 168, 65, 13)
        Label24.SetBounds(15, 195, 79, 13)
        Label25.SetBounds(337, 195, 80, 13)
        Label22.SetBounds(15, 223, 55, 13)
        Label26.SetBounds(227, 223, 34, 13)
        Label27.SetBounds(382, 223, 85, 13)
        cmbcategory.SetBounds(441, 165, 147, 21)
        cmbdepartment.SetBounds(441, 192, 123, 21)
        btndepartment.SetBounds(567, 191, 21, 21)
        cmbdesignation.SetBounds(122, 192, 186, 21)
        btndesignation.SetBounds(312, 191, 21, 21)
        cmbdob.SetBounds(441, 138, 147, 21)
        cmbmarried.SetBounds(122, 220, 101, 21)
        cmbph.SetBounds(486, 220, 101, 21)
        cmbsex.SetBounds(269, 220, 101, 21)
        txtaddress.SetBounds(193, 57, 395, 21)
        txtcity.SetBounds(122, 84, 313, 21)
        txtcountry.SetBounds(441, 111, 147, 21)
        txtdistrict.SetBounds(441, 84, 147, 21)
        txtemail.SetBounds(122, 165, 211, 21)
        txtfax.SetBounds(228, 138, 105, 21)
        txtfirst.SetBounds(170, 30, 162, 21)
        txthouseno.SetBounds(122, 57, 63, 21)
        txtlast.SetBounds(418, 30, 170, 21)
        txtmiddle.SetBounds(338, 30, 74, 21)
        txtphone.SetBounds(122, 138, 100, 21)
        txtpin.SetBounds(339, 111, 96, 21)
        txtregistrationno.SetBounds(15, 30, 93, 21)
        txtstate.SetBounds(122, 111, 211, 21)
        ProfilePic1.SetBounds(645, 33, 100, 111)
        btnupload.SetBounds(645, 156, 112, 25)

        Grouper2.Height = 157
        Label8.SetBounds(15, 37, 103, 13)
        Label9.SetBounds(374, 37, 118, 13)
        Label10.SetBounds(15, 64, 81, 13)
        Label11.SetBounds(15, 91, 60, 13)
        Label12.SetBounds(15, 119, 96, 13)
        Label23.SetBounds(262, 91, 69, 13)
        cmbjoining.SetBounds(122, 116, 135, 21)
        cmbpayinfo.SetBounds(122, 88, 135, 21)
        cmbpayscale.SetBounds(335, 88, 109, 21)
        btnpayscale.SetBounds(450, 87, 21, 21)
        cmbretirement.SetBounds(498, 34, 112, 21)
        txtfulladdress.SetBounds(122, 61, 488, 21)
        txtgrade.SetBounds(476, 88, 64, 21)
        txtpresentposition.SetBounds(122, 34, 224, 21)
        txtbasic.SetBounds(546, 88, 64, 21)

        Label40.SetBounds(13, 14, 263, 13)
        Label41.SetBounds(13, 40, 228, 13)
        Label42.SetBounds(359, 40, 400, 13)
        lnkremove.SetBounds(202, 70, 74, 16)
        btnattach.SetBounds(282, 64, 75, 25)
        lblattached.SetBounds(359, 70, 65, 13)
        txtphdthesis.SetBounds(282, 11, 493, 21)
        cmbqualifiedtest.SetBounds(282, 37, 71, 21)

        Label28.SetBounds(15, 12, 106, 13)
        Label29.SetBounds(191, 12, 50, 13)
        Label30.SetBounds(311, 12, 47, 13)
        Label16.SetBounds(15, 12, 106, 13)
        Label15.SetBounds(191, 12, 50, 13)
        Label14.SetBounds(311, 12, 47, 13)
        nudtexpyear.SetBounds(127, 10, 57, 21)
        nudtexpmonth.SetBounds(247, 10, 57, 21)
        nudrexpyear.SetBounds(127, 10, 57, 21)
        nudrexpmonth.SetBounds(247, 10, 57, 21)

        Label45.SetBounds(21, 38, 747, 26)
        Label46.SetBounds(21, 117, 160, 13)
        Label54.SetBounds(21, 201, 517, 13)
        txtpapers.SetBounds(187, 87, 72, 21)
        txtbooks.SetBounds(187, 114, 72, 21)
        txtarticles.SetBounds(187, 141, 72, 21)
        txtdetails1.SetBounds(328, 87, 440, 21)
        txtdetails2.SetBounds(328, 114, 440, 21)
        txtdetails3.SetBounds(328, 141, 440, 21)
        txtdetails4.SetBounds(328, 168, 440, 21)
        txtreferee1.SetBounds(24, 221, 744, 21)
        txtreferee2.SetBounds(24, 249, 744, 21)
        txtreferee3.SetBounds(24, 276, 744, 21)
        txtotherdetails.SetBounds(24, 340, 744, 52)

        lnkaddaca.SetBounds(593, 0, 166, 18)
        lnkaddlang.SetBounds(651, 0, 120, 18)
        lnkaddprog.SetBounds(536, 0, 209, 18)
        lnkaddresearch.SetBounds(626, 0, 145, 18)
        lnkaddteach.SetBounds(628, 0, 143, 18)
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
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadState()
        Try
            If txtcountry.Text.ToUpper().Trim() = "INDIA" Then
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
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadDepartment()
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .HeaderText = "Code"
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .HeaderText = "Department"
            End With

            With DGVDepartment
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
                AddHandler DGVDepartment.CellClick, AddressOf DGVDepartment_CellClick
            End With

            DGVDepartment.Columns.Clear()
            DGVDepartment.Columns.Add(col1)
            DGVDepartment.Columns.Add(col2)

            DGVDepartment.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select deptid,deptname from Department where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVDepartment.Rows.Add()
                DGVDepartment.Rows(indx).Cells(0).Value = dr("deptid").ToString()
                DGVDepartment.Rows(indx).Cells(1).Value = dr("deptname").ToString()

                indx = indx + 1
            End While
            dr.Close()
            DGVDepartment.ClearSelection()

            cmbdepartment.AddDataGridView(DGVDepartment, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVDepartment_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVDepartment.CurrentRow.Index
            DGVDepartment.Rows(k).Selected = True
            DGVDepartment.CurrentCell = DGVDepartment.Rows(k).Cells(0)
            deptcode = DGVDepartment.Rows(k).Cells(0).Value.ToString()
            deptname = DGVDepartment.Rows(k).Cells(1).Value.ToString()
            cmbdepartment.Text = deptname
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadDesignation()
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .HeaderText = "Code"
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .HeaderText = "Designation"
            End With

            With DGVDesignation
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
                AddHandler DGVDesignation.CellClick, AddressOf DGVDesignation_CellClick
            End With

            DGVDesignation.Columns.Clear()
            DGVDesignation.Columns.Add(col1)
            DGVDesignation.Columns.Add(col2)

            DGVDesignation.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select desigid,designame from Designation where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVDesignation.Rows.Add()
                DGVDesignation.Rows(indx).Cells(0).Value = dr("desigid").ToString()
                DGVDesignation.Rows(indx).Cells(1).Value = dr("designame").ToString()

                indx = indx + 1
            End While
            dr.Close()
            DGVDesignation.ClearSelection()

            cmbdesignation.AddDataGridView(DGVDesignation, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVDesignation_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVDesignation.CurrentRow.Index
            DGVDesignation.Rows(k).Selected = True
            DGVDesignation.CurrentCell = DGVDesignation.Rows(k).Cells(0)
            desigcode = DGVDesignation.Rows(k).Cells(0).Value.ToString()
            designame = DGVDesignation.Rows(k).Cells(1).Value.ToString()
            cmbdesignation.Text = designame
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadPayScale()
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .HeaderText = "PB Name"
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .HeaderText = "Pay-Scale"
            End With

            With DGVPayscale
                .DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
                .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
                .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.White
                .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .RowHeadersVisible = False
                AddHandler DGVPayscale.CellClick, AddressOf DGVPayscale_CellClick
            End With

            DGVPayscale.Columns.Clear()
            DGVPayscale.Columns.Add(col1)
            DGVPayscale.Columns.Add(col2)

            DGVPayscale.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select pbname,payscale from PayScale where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVPayscale.Rows.Add()
                DGVPayscale.Rows(indx).Cells(0).Value = dr("pbname").ToString()
                DGVPayscale.Rows(indx).Cells(1).Value = dr("payscale").ToString()

                indx = indx + 1
            End While
            dr.Close()

            cmbpayscale.AddDataGridView(DGVPayscale, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVPayscale_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVPayscale.CurrentRow.Index
            DGVPayscale.Rows(k).Selected = True
            DGVPayscale.CurrentCell = DGVPayscale.Rows(k).Cells(0)
            pbname = DGVPayscale.Rows(k).Cells(0).Value.ToString()
            pbscale = DGVPayscale.Rows(k).Cells(1).Value.ToString()
            cmbpayscale.Text = pbscale
            LoadSelectedPayscale(pbname, pbscale)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedPayscale(ByVal pbname As String, ByVal pbscale As String)
        Try
            cmd.CommandText = "select pbgrade,pbbasic from PayScale where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and pbname='" & pbname & "' and payscale='" & pbscale & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            txtgrade.Text = dr("pbgrade").ToString()
            txtbasic.Text = dr("pbbasic").ToString()
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadImage()
        Try
            cmd.CommandText = "select picture from Employee where empid='" & EmpRegNo & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadSelectedEmployee()
        Try
            cmd.CommandText = "select * from Employee where empid='" & EmpRegNo & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                txtaddress.Text = dr("address").ToString()
                txtbasic.Text = dr("basic").ToString()
                txtcity.Text = dr("city").ToString()
                txtcountry.Text = dr("country").ToString()
                txtdistrict.Text = dr("district").ToString()
                txtemail.Text = dr("email").ToString()
                txtfax.Text = dr("fax").ToString()
                txtfirst.Text = dr("namefirst").ToString()
                txtfulladdress.Text = dr("fulladdress").ToString()
                txthouseno.Text = dr("houseno").ToString()
                txtlast.Text = dr("namelast").ToString()
                txtmiddle.Text = dr("namemiddle").ToString()
                txtgrade.Text = dr("grade").ToString()
                txtphone.Text = dr("phone").ToString()
                txtpin.Text = dr("pin").ToString()
                txtpresentposition.Text = dr("presentposition").ToString()
                txtregistrationno.Text = dr("empid").ToString()
                txtstate.Text = dr("state").ToString()
                cmbcategory.Text = dr("category").ToString()
                cmbdepartment.Text = dr("department").ToString()
                cmbdesignation.Text = dr("designation").ToString()
                cmbdob.Text = dr("dob").ToString()
                cmbjoining.Text = dr("joiningdate").ToString()
                cmbmarried.Text = dr("married").ToString()
                cmbpayinfo.Text = dr("payinfo").ToString()
                cmbpayscale.Text = dr("payscale").ToString()
                cmbph.Text = dr("handicapped").ToString()
                cmbretirement.Text = dr("retirementdate").ToString()
                cmbsex.Text = dr("sex").ToString()
                txtphdthesis.Text = dr("phd").ToString()
                cmbqualifiedtest.Text = dr("qualifiedtest").ToString()
                If cmbqualifiedtest.Text = "Yes" Then
                    lblattached.Text = dr("attachedcopy").ToString()
                    lblattached.Visible = True
                    lnkremove.Visible = True
                Else
                    lnkremove.Visible = False
                    lblattached.Visible = False
                End If
                txtregistrationno.Focus()
            End If
            dr.Close()
            LoadImage()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadSelectedEmployeeLanguage()
        Try
            dgviewlanguage.Rows.Clear()
            Dim indx As Integer = 0
            cmd.CommandText = "select * from EmployeeLanguage where empid='" & EmpRegNo & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewlanguage.Rows.Add()
                dgviewlanguage.Rows(indx).Cells(0).Value = dr("langname").ToString()
                dgviewlanguage.Rows(indx).Cells(1).Value = dr("canread").ToString()
                dgviewlanguage.Rows(indx).Cells(2).Value = dr("canwrite").ToString()
                dgviewlanguage.Rows(indx).Cells(3).Value = dr("canspeak").ToString()
                dgviewlanguage.Rows(indx).Cells(4).Value = dr("canconversation").ToString()
                indx += 1
            End While
            dr.Close()
            dgviewlanguage.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadSelectedEmployeeAcademic()
        Try
            dgviewacademic.Rows.Clear()
            Dim indx As Integer = 0
            cmd.CommandText = "select * from EmployeeAcademic where empid='" & EmpRegNo & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewacademic.Rows.Add()
                dgviewacademic.Rows(indx).Cells(0).Value = dr("degree").ToString()
                dgviewacademic.Rows(indx).Cells(1).Value = dr("passingyear").ToString()
                dgviewacademic.Rows(indx).Cells(2).Value = dr("subjects").ToString()
                Dim marks As Decimal = CDec(dr("percentagemarks").ToString())
                dgviewacademic.Rows(indx).Cells(3).Value = FormatNumber(marks.ToString())
                dgviewacademic.Rows(indx).Cells(4).Value = dr("classdivision").ToString()
                indx += 1
            End While
            dr.Close()
            dgviewacademic.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadSelectedEmployeeTeachingExp()
        Try
            dgviewteachingexp.Rows.Clear()
            Dim indx As Integer = 0
            cmd.CommandText = "select * from EmployeeTeachingExp where empid='" & EmpRegNo & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewteachingexp.Rows.Add()
                dgviewteachingexp.Rows(indx).Cells(0).Value = dr("institution").ToString()
                dgviewteachingexp.Rows(indx).Cells(1).Value = dr("designation").ToString()
                dgviewteachingexp.Rows(indx).Cells(2).Value = dr("totalyears").ToString()
                dgviewteachingexp.Rows(indx).Cells(3).Value = dr("ug").ToString()
                dgviewteachingexp.Rows(indx).Cells(4).Value = dr("degree").ToString()
                dgviewteachingexp.Rows(indx).Cells(5).Value = dr("pg").ToString()
                nudtexpmonth.Value = CInt(dr("totaltexpmonth").ToString())
                nudtexpyear.Value = CInt(dr("totaltexpyear").ToString())
                indx += 1
            End While
            dgviewteachingexp.ClearSelection()
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadSelectedEmployeeResearchExp()
        Try
            dgviewexpreaserch.Rows.Clear()
            Dim indx As Integer = 0
            cmd.CommandText = "select * from EmployeeResearchExp where empid='" & EmpRegNo & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewexpreaserch.Rows.Add()
                dgviewexpreaserch.Rows(indx).Cells(0).Value = dr("research").ToString()
                dgviewexpreaserch.Rows(indx).Cells(1).Value = dr("institution").ToString()
                dgviewexpreaserch.Rows(indx).Cells(2).Value = dr("topic").ToString()
                dgviewexpreaserch.Rows(indx).Cells(3).Value = dr("researchperiod").ToString()
                nudrexpmonth.Value = CInt(dr("totalrexpmonth").ToString())
                nudrexpyear.Value = CInt(dr("totalrexpyear").ToString())
                indx += 1
            End While
            dgviewexpreaserch.ClearSelection()
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadSelectedEmployeeProciency()
        Try
            cmd.CommandText = "select * from EmployeeProficiency where empid='" & EmpRegNo & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If rbtncmserpexpert.Text = dr("cmserp").ToString() Then
                rbtncmserpexpert.Checked = True
            ElseIf rbtncmserpno.Text = dr("cmserp").ToString() Then
                rbtncmserpno.Checked = True
            ElseIf rbtncmserpworking.Text = dr("cmserp").ToString() Then
                rbtncmserpworking.Checked = True
            End If
            If rbtnemailexpert.Text = dr("knowemail").ToString() Then
                rbtnemailexpert.Checked = True
            ElseIf rbtnemailno.Text = dr("knowemail").ToString() Then
                rbtnemailno.Checked = True
            ElseIf rbtnemailworking.Text = dr("knowemail").ToString() Then
                rbtnemailworking.Checked = True
            End If
            If rbtninternetexpert.Text = dr("internet").ToString() Then
                rbtninternetexpert.Checked = True
            ElseIf rbtninternetno.Text = dr("internet").ToString() Then
                rbtninternetno.Checked = True
            ElseIf rbtninternetworking.Text = dr("internet").ToString() Then
                rbtninternetworking.Checked = True
            End If
            If rbtnmsexcelexpert.Text = dr("msexcel").ToString() Then
                rbtnmsexcelexpert.Checked = True
            ElseIf rbtnmsexcelno.Text = dr("msexcel").ToString() Then
                rbtnmsexcelno.Checked = True
            ElseIf rbtnmsexcelworking.Text = dr("msexcel").ToString() Then
                rbtnmsexcelworking.Checked = True
            End If
            If rbtnmspptno.Text = dr("mspowerpoint").ToString() Then
                rbtnmspptno.Checked = True
            ElseIf rbtnmspptexpert.Text = dr("mspowerpoint").ToString() Then
                rbtnmspptexpert.Checked = True
            ElseIf rbtnmspptworking.Text = dr("mspowerpoint").ToString() Then
                rbtnmspptworking.Checked = True
            End If
            If rbtnmswordexpert.Text = dr("msword").ToString() Then
                rbtnmswordexpert.Checked = True
            ElseIf rbtnmswordno.Text = dr("msword").ToString() Then
                rbtnmswordno.Checked = True
            ElseIf rbtnmswordworking.Text = dr("msword").ToString() Then
                rbtnmswordworking.Checked = True
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadSelectedEmployeeProgrammingLang()
        Try
            dgviewprogramming.Rows.Clear()
            Dim indx As Integer = 0
            cmd.CommandText = "select * from EmployeeProgrammingLang where empid='" & EmpRegNo & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewprogramming.Rows.Add()
                dgviewprogramming.Rows(indx).Cells(0).Value = dr("lang").ToString()
                indx += 1
            End While
            dgviewprogramming.ClearSelection()
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedEmployeeActivity()
        Try
            cmd.CommandText = "select * from EmployeeActivity where empid='" & EmpRegNo & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            txtarticles.Text = dr("publishedarticles").ToString()
            txtbooks.Text = dr("publishedbooks").ToString()
            txtdetails1.Text = dr("seminar").ToString()
            txtdetails2.Text = dr("adminisexp").ToString()
            txtdetails3.Text = dr("otheractivities").ToString()
            txtdetails4.Text = dr("poriodnotice").ToString()
            txtotherdetails.Text = dr("otherinfo").ToString()
            txtpapers.Text = dr("publishedpaper").ToString()
            txtreferee1.Text = dr("referee1").ToString()
            txtreferee2.Text = dr("referee2").ToString()
            txtreferee3.Text = dr("referee3").ToString()
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub AddRecord()
        Try
            If txtregistrationno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtregistrationno.Focus()
                End If
            ElseIf txtfirst.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter first name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtfirst.Focus()
                End If
            ElseIf txtlast.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter last name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtlast.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    CheckEmployeeID()
                    If EmpExist = False Then
                        Dim msword As String = ""
                        If rbtnmswordexpert.Checked = True Then
                            msword = rbtnmswordexpert.Text
                        ElseIf rbtnmswordno.Checked = True Then
                            msword = rbtnmswordno.Text
                        ElseIf rbtnmswordworking.Checked = True Then
                            msword = rbtnmswordworking.Text
                        End If
                        Dim msexcel As String = ""
                        If rbtnmsexcelexpert.Checked = True Then
                            msexcel = rbtnmsexcelexpert.Text
                        ElseIf rbtnmsexcelno.Checked = True Then
                            msexcel = rbtnmsexcelno.Text
                        ElseIf rbtnmsexcelworking.Checked = True Then
                            msexcel = rbtnmsexcelworking.Text
                        End If
                        Dim msppt As String = ""
                        If rbtnmspptexpert.Checked = True Then
                            msppt = rbtnmspptexpert.Text
                        ElseIf rbtnmspptno.Checked = True Then
                            msppt = rbtnmspptno.Text
                        ElseIf rbtnmspptworking.Checked = True Then
                            msppt = rbtnmspptworking.Text
                        End If
                        Dim internet As String = ""
                        If rbtninternetexpert.Checked = True Then
                            internet = rbtninternetexpert.Text
                        ElseIf rbtninternetno.Checked = True Then
                            internet = rbtninternetno.Text
                        ElseIf rbtninternetworking.Checked = True Then
                            internet = rbtninternetworking.Text
                        End If
                        Dim email As String = ""
                        If rbtnemailexpert.Checked = True Then
                            email = rbtnemailexpert.Text
                        ElseIf rbtnemailno.Checked = True Then
                            email = rbtnemailno.Text
                        ElseIf rbtnemailworking.Checked = True Then
                            email = rbtnemailworking.Text
                        End If
                        Dim cmserp As String = ""
                        If rbtncmserpexpert.Checked = True Then
                            cmserp = rbtncmserpexpert.Text
                        ElseIf rbtncmserpno.Checked = True Then
                            cmserp = rbtncmserpno.Text
                        ElseIf rbtncmserpworking.Checked = True Then
                            cmserp = rbtncmserpworking.Text
                        End If

                        cmd.CommandText = "insert into Employee(InsID,InsName,Period,empid,picture) values (@InsID,@InsName,@Period,@empid,@picture)"
                        cmd.Parameters.AddWithValue("@InsID", My.Settings.LastOpenedInstituteID)
                        cmd.Parameters.AddWithValue("@InsName", My.Settings.LastOpenedInstitute)
                        cmd.Parameters.AddWithValue("@Period", My.Settings.Period)
                        cmd.Parameters.AddWithValue("@empid", txtregistrationno.Text)
                        Dim ms As New MemoryStream()
                        ProfilePic1.Image.Save(ms, ProfilePic1.Image.RawFormat)
                        Dim data As Byte() = ms.GetBuffer()
                        Dim p As New SqlParameter("@picture", SqlDbType.Image)
                        p.Value = data
                        cmd.Parameters.Add(p)
                        cmd.ExecuteNonQuery()
                        cmd.Parameters.Clear()

                        Dim cls As New cEmployee()
                        Dim incremented As String = "No"
                        cls.AddEmployee(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtregistrationno.Text, txtfirst.Text, txtmiddle.Text, txtlast.Text, txthouseno.Text, txtaddress.Text, txtcity.Text, txtdistrict.Text, txtstate.Text, txtpin.Text, txtcountry.Text, txtphone.Text, txtfax.Text, cmbdob.Text, txtemail.Text, cmbcategory.Text, cmbdepartment.Text, cmbdesignation.Text, cmbmarried.Text, cmbsex.Text, cmbph.Text, txtpresentposition.Text, cmbretirement.Text, txtfulladdress.Text, cmbpayinfo.Text, cmbpayscale.Text, CDec(txtgrade.Text), CDec(txtbasic.Text), cmbjoining.Text, txtphdthesis.Text, cmbqualifiedtest.Text, lblattached.Text, msword, msexcel, msppt, internet, email, cmserp, txtbooks.Text, txtpapers.Text, txtarticles.Text, txtdetails1.Text, txtdetails2.Text, txtdetails3.Text, txtdetails4.Text, txtreferee1.Text, txtreferee2.Text, txtreferee3.Text, txtotherdetails.Text, incremented)

                        If dgviewacademic.Rows.Count > 0 Then
                            For acarow As Integer = 0 To dgviewacademic.Rows.Count - 1
                                cls.AddEmployeeAcademic(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtregistrationno.Text, dgviewacademic.Rows(acarow).Cells(0).Value.ToString(), CInt(dgviewacademic.Rows(acarow).Cells(1).Value.ToString()), dgviewacademic.Rows(acarow).Cells(2).Value.ToString(), dgviewacademic.Rows(acarow).Cells(3).Value.ToString(), dgviewacademic.Rows(acarow).Cells(4).Value.ToString())
                            Next
                        End If

                        If dgviewlanguage.Rows.Count > 0 Then
                            For langrow As Integer = 0 To dgviewlanguage.Rows.Count - 1
                                cls.AddEmployeeLanguage(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtregistrationno.Text, dgviewlanguage.Rows(langrow).Cells(0).Value.ToString(), dgviewlanguage.Rows(langrow).Cells(1).Value.ToString(), dgviewlanguage.Rows(langrow).Cells(2).Value.ToString(), dgviewlanguage.Rows(langrow).Cells(3).Value.ToString(), dgviewlanguage.Rows(langrow).Cells(4).Value.ToString())
                            Next
                        End If

                        If dgviewteachingexp.Rows.Count > 0 Then
                            For texp As Integer = 0 To dgviewteachingexp.Rows.Count - 1
                                cls.AddEmployeeTeachingExp(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtregistrationno.Text, CInt(nudtexpyear.Value.ToString()), CInt(nudtexpmonth.Value.ToString()), dgviewteachingexp.Rows(texp).Cells(0).Value.ToString(), dgviewteachingexp.Rows(texp).Cells(1).Value.ToString(), CInt(dgviewteachingexp.Rows(texp).Cells(2).Value.ToString()), dgviewteachingexp.Rows(texp).Cells(3).Value.ToString(), dgviewteachingexp.Rows(texp).Cells(4).Value.ToString(), dgviewteachingexp.Rows(texp).Cells(5).Value.ToString())
                            Next
                        End If

                        If dgviewexpreaserch.Rows.Count > 0 Then
                            For rexp As Integer = 0 To dgviewexpreaserch.Rows.Count - 1
                                cls.AddEmployeeResearchExp(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtregistrationno.Text, CInt(nudrexpyear.Value.ToString()), CInt(nudrexpmonth.Value.ToString()), dgviewexpreaserch.Rows(rexp).Cells(0).Value.ToString(), dgviewexpreaserch.Rows(rexp).Cells(1).Value.ToString(), dgviewexpreaserch.Rows(rexp).Cells(2).Value.ToString(), dgviewexpreaserch.Rows(rexp).Cells(3).Value.ToString())
                            Next
                        End If

                        If dgviewprogramming.Rows.Count > 0 Then
                            For prog As Integer = 0 To dgviewprogramming.Rows.Count - 1
                                cls.AddEmployeeProgrammingLang(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtregistrationno.Text, dgviewprogramming.Rows(prog).Cells(0).Value.ToString())
                            Next
                        End If

                        If cls.AddEmployeeok = True Then
                            If lblattached.Visible = True And lnkremove.Visible = True Then
                                SaveAttachedCopy(ofd.FileName.ToString())
                            End If
                            cmd.CommandText = "update Indexx set empid=empid+1 where InsID='" & My.Settings.LastOpenedInstituteID & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                            Dim result1 As DialogResult = MessageBox.Show("Record saved successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = DialogResult.OK Then
                                ETabControl1.SelectTab(TabPage1)
                                txtfirst.Focus()
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Registration no. already exist." + Environment.NewLine + "Please enter new registration no.", "Umbrella - Duplicate Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result1 = DialogResult.OK Then
                            txtregistrationno.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If txtregistrationno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtregistrationno.Focus()
                End If
            ElseIf txtfirst.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter first name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtfirst.Focus()
                End If
            ElseIf txtlast.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter last name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtlast.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim msword As String = ""
                    If rbtnmswordexpert.Checked = True Then
                        msword = rbtnmswordexpert.Text
                    ElseIf rbtnmswordno.Checked = True Then
                        msword = rbtnmswordno.Text
                    ElseIf rbtnmswordworking.Checked = True Then
                        msword = rbtnmswordworking.Text
                    End If
                    Dim msexcel As String = ""
                    If rbtnmsexcelexpert.Checked = True Then
                        msexcel = rbtnmsexcelexpert.Text
                    ElseIf rbtnmsexcelno.Checked = True Then
                        msexcel = rbtnmsexcelno.Text
                    ElseIf rbtnmsexcelworking.Checked = True Then
                        msexcel = rbtnmsexcelworking.Text
                    End If
                    Dim msppt As String = ""
                    If rbtnmspptexpert.Checked = True Then
                        msppt = rbtnmspptexpert.Text
                    ElseIf rbtnmspptno.Checked = True Then
                        msppt = rbtnmspptno.Text
                    ElseIf rbtnmspptworking.Checked = True Then
                        msppt = rbtnmspptworking.Text
                    End If
                    Dim internet As String = ""
                    If rbtninternetexpert.Checked = True Then
                        internet = rbtninternetexpert.Text
                    ElseIf rbtninternetno.Checked = True Then
                        internet = rbtninternetno.Text
                    ElseIf rbtninternetworking.Checked = True Then
                        internet = rbtninternetworking.Text
                    End If
                    Dim email As String = ""
                    If rbtnemailexpert.Checked = True Then
                        email = rbtnemailexpert.Text
                    ElseIf rbtnemailno.Checked = True Then
                        email = rbtnemailno.Text
                    ElseIf rbtnemailworking.Checked = True Then
                        email = rbtnemailworking.Text
                    End If
                    Dim cmserp As String = ""
                    If rbtncmserpexpert.Checked = True Then
                        cmserp = rbtncmserpexpert.Text
                    ElseIf rbtncmserpno.Checked = True Then
                        cmserp = rbtncmserpno.Text
                    ElseIf rbtncmserpworking.Checked = True Then
                        cmserp = rbtncmserpworking.Text
                    End If

                    cmd.CommandText = "update Employee set picture=@picture where InsID=@InsID and empid=@empid"
                    cmd.Parameters.AddWithValue("@InsID", My.Settings.LastOpenedInstituteID)
                    cmd.Parameters.AddWithValue("@empid", txtregistrationno.Text)
                    Dim ms As New MemoryStream()
                    ProfilePic1.Image.Save(ms, ImageFormat.Jpeg)
                    Dim photo_aray As Byte() = New Byte(ms.Length - 1) {}
                    ms.Position = 0
                    ms.Read(photo_aray, 0, photo_aray.Length)
                    cmd.Parameters.AddWithValue("@picture", photo_aray)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()

                    Dim cls As New cEmployee()
                    cls.UpdateEmployee(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtregistrationno.Text, txtfirst.Text, txtmiddle.Text, txtlast.Text, txthouseno.Text, txtaddress.Text, txtcity.Text, txtdistrict.Text, txtstate.Text, txtpin.Text, txtcountry.Text, txtphone.Text, txtfax.Text, cmbdob.Text, txtemail.Text, cmbcategory.Text, cmbdepartment.Text, cmbdesignation.Text, cmbmarried.Text, cmbsex.Text, cmbph.Text, txtpresentposition.Text, cmbretirement.Text, txtfulladdress.Text, cmbpayinfo.Text, cmbpayscale.Text, CDec(txtgrade.Text), CDec(txtbasic.Text), cmbjoining.Text, txtphdthesis.Text, cmbqualifiedtest.Text, lblattached.Text, msword, msexcel, msppt, internet, email, cmserp, txtbooks.Text, txtpapers.Text, txtarticles.Text, txtdetails1.Text, txtdetails2.Text, txtdetails3.Text, txtdetails4.Text, txtreferee1.Text, txtreferee2.Text, txtreferee3.Text, txtotherdetails.Text)

                    If dgviewacademic.Rows.Count > 0 Then
                        For acarow As Integer = 0 To dgviewacademic.Rows.Count - 1
                            cls.UpdateEmployeeAcademic(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtregistrationno.Text, dgviewacademic.Rows(acarow).Cells(0).Value.ToString(), CInt(dgviewacademic.Rows(acarow).Cells(1).Value.ToString()), dgviewacademic.Rows(acarow).Cells(2).Value.ToString(), dgviewacademic.Rows(acarow).Cells(3).Value.ToString(), dgviewacademic.Rows(acarow).Cells(4).Value.ToString())
                        Next
                    End If

                    If dgviewlanguage.Rows.Count > 0 Then
                        For langrow As Integer = 0 To dgviewlanguage.Rows.Count - 1
                            cls.UpdateEmployeeLanguage(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtregistrationno.Text, dgviewlanguage.Rows(langrow).Cells(0).Value.ToString(), dgviewlanguage.Rows(langrow).Cells(1).Value.ToString(), dgviewlanguage.Rows(langrow).Cells(2).Value.ToString(), dgviewlanguage.Rows(langrow).Cells(3).Value.ToString(), dgviewlanguage.Rows(langrow).Cells(4).Value.ToString())
                        Next
                    End If

                    If dgviewteachingexp.Rows.Count > 0 Then
                        For texp As Integer = 0 To dgviewteachingexp.Rows.Count - 1
                            cls.UpdateEmployeeTeachingExp(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtregistrationno.Text, CInt(nudtexpyear.Value.ToString()), CInt(nudtexpmonth.Value.ToString()), dgviewteachingexp.Rows(texp).Cells(0).Value.ToString(), dgviewteachingexp.Rows(texp).Cells(1).Value.ToString(), CInt(dgviewteachingexp.Rows(texp).Cells(2).Value.ToString()), dgviewteachingexp.Rows(texp).Cells(3).Value.ToString(), dgviewteachingexp.Rows(texp).Cells(4).Value.ToString(), dgviewteachingexp.Rows(texp).Cells(5).Value.ToString())
                        Next
                    End If

                    If dgviewexpreaserch.Rows.Count > 0 Then
                        For rexp As Integer = 0 To dgviewexpreaserch.Rows.Count - 1
                            cls.UpdateEmployeeResearchExp(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtregistrationno.Text, CInt(nudrexpyear.Value.ToString()), CInt(nudrexpmonth.Value.ToString()), dgviewexpreaserch.Rows(rexp).Cells(0).Value.ToString(), dgviewexpreaserch.Rows(rexp).Cells(1).Value.ToString(), dgviewexpreaserch.Rows(rexp).Cells(2).Value.ToString(), dgviewexpreaserch.Rows(rexp).Cells(3).Value.ToString())
                        Next
                    End If

                    If dgviewprogramming.Rows.Count > 0 Then
                        For prog As Integer = 0 To dgviewprogramming.Rows.Count - 1
                            cls.UpdateEmployeeProgrammingLang(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtregistrationno.Text, dgviewprogramming.Rows(prog).Cells(0).Value.ToString())
                        Next
                    End If

                    If cls.UpdateEmployeeok = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record Updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = DialogResult.OK Then
                            ETabControl1.SelectTab(TabPage1)
                            txtregistrationno.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If txtregistrationno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    txtregistrationno.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim cls As New cEmployee()
                    cls.DeleteEmployeeRecord(txtregistrationno.Text)
                    If cls.DeleteEmployeeok = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record Deleted successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = DialogResult.OK Then
                            ETabControl1.SelectTab(TabPage1)
                            ResetForm()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetForm()
        ProfilePic1.Image = Global.Umbrella.My.Resources.people
        dgviewacademic.Rows.Clear()
        dgviewexpreaserch.Rows.Clear()
        dgviewlanguage.Rows.Clear()
        dgviewprogramming.Rows.Clear()
        dgviewteachingexp.Rows.Clear()
        cmbcategory.Text = ""
        cmbdepartment.Text = ""
        cmbdesignation.Text = ""
        cmbdob.Text = ""
        cmbjoining.Text = ""
        cmbmarried.Text = ""
        cmbpayinfo.Text = ""
        cmbpayscale.Text = ""
        cmbph.Text = ""
        cmbqualifiedtest.Text = ""
        cmbretirement.Text = ""
        cmbsex.Text = ""
        txtaddress.Text = ""
        txtarticles.Text = ""
        txtbooks.Text = ""
        txtcity.Text = ""
        txtcountry.Text = "India"
        txtdetails1.Text = ""
        txtdetails2.Text = ""
        txtdetails3.Text = ""
        txtdetails4.Text = ""
        txtdistrict.Text = ""
        txtemail.Text = ""
        txtfax.Text = ""
        txtfirst.Text = ""
        txtfulladdress.Text = ""
        txthouseno.Text = ""
        txtlast.Text = ""
        txtphdthesis.Text = ""
        txtmiddle.Text = ""
        txtgrade.Text = ""
        txtotherdetails.Text = ""
        txtpapers.Text = ""
        txtphone.Text = ""
        txtpin.Text = ""
        txtpresentposition.Text = ""
        txtreferee1.Text = ""
        txtreferee2.Text = ""
        txtreferee3.Text = ""
        txtstate.Text = ""
        txtbasic.Text = ""
        nudrexpmonth.Value = 0
        nudrexpyear.Value = 0
        nudtexpmonth.Value = 0
        nudtexpyear.Value = 0
        ETabControl1.SelectTab(TabPage1)
        rbtncmserpexpert.Checked = False
        rbtncmserpno.Checked = False
        rbtncmserpworking.Checked = False
        rbtnemailexpert.Checked = False
        rbtnemailno.Checked = False
        rbtnemailworking.Checked = False
        rbtninternetexpert.Checked = False
        rbtninternetno.Checked = False
        rbtninternetworking.Checked = False
        rbtnmsexcelexpert.Checked = False
        rbtnmsexcelno.Checked = False
        rbtnmsexcelworking.Checked = False
        rbtnmspptexpert.Checked = False
        rbtnmspptno.Checked = False
        rbtnmspptworking.Checked = False
        rbtnmswordexpert.Checked = False
        rbtnmswordno.Checked = False
        rbtnmswordworking.Checked = False
        lnkremove.Visible = False
        Label42.Visible = False
        lblattached.Text = ""
        lblattached.Visible = False
        btnattach.Visible = False
        updateemployee = False
        If ISDAutoID = "Yes" Then
            GetCode()
        Else
            txtregistrationno.Text = ""
        End If
        txtfirst.Focus()
    End Sub

    Private Sub LoadImage(ByVal sourceControl As Control, ByVal fileSizeLimit As Long)
        Dim openFileDLG As New OpenFileDialog()
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

    Public Function FileNameWithoutPath(ByVal FullPath As String) As String
        Return System.IO.Path.GetFileName(FullPath).ToString
    End Function

    Private Sub AttachCopy()
        Try
            With ofd
                Try
                    .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                    .RestoreDirectory = True
                Catch ex As Exception
                    Exit Try
                End Try
                .Filter = "All Document Files|*.doc;*.docx;*.rtf;*.pdf;*.txt|" + "MS Word 2003 or before (MSWord File)|*.doc|MS Word 2007 or later (MSWord File)|*.docx|Rich Text Files (RTF File)|*.rtf|Adobe Acrobat Files (PDF Files)|*.pdf|Text Files (TXT Files)|*.txt"
            End With
            If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                lblattached.Text = FileNameWithoutPath(ofd.FileName.ToString())
                lblattached.Visible = True
                lnkremove.Visible = True
            End If
        Catch eX As Exception
            MessageBox.Show(eX.Message)
        Finally
            Cursor.Current = Cursors.Default()
        End Try
    End Sub

    Private Sub SaveAttachedCopy(ByVal FullPath As String)
        System.IO.File.Copy(ofd.FileName, AppDomain.CurrentDomain.BaseDirectory + System.IO.Path.GetFileName(ofd.FileName()))
        My.Computer.FileSystem.RenameFile(AppDomain.CurrentDomain.BaseDirectory + System.IO.Path.GetFileName(ofd.FileName()), txtphone.Text + "_PHD_" + System.IO.Path.GetFileName(FullPath).ToString())
    End Sub

    Private Sub CheckEmployeeID()
        Try
            cmd.CommandText = "select * from Employee where empid='" & txtregistrationno.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                EmpExist = True
            Else
                EmpExist = False
            End If
            dr.Close()
        Catch ex As Exception
            EmpExist = False
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Attributes..."
    Private Sub txtregistrationno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtregistrationno.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            txtfirst.Focus()
        End If
    End Sub

    Private Sub txtfirst_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfirst.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            txtmiddle.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtregistrationno.Focus()
        End If
    End Sub

    Private Sub txtmiddle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmiddle.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            txtlast.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtfirst.Focus()
        End If
    End Sub

    Private Sub txtlast_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlast.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            txthouseno.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtmiddle.Focus()
        End If
    End Sub

    Private Sub txthouseno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txthouseno.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            txtaddress.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtlast.Focus()
        End If
    End Sub

    Private Sub txtaddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtaddress.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            txtcity.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txthouseno.Focus()
        End If
    End Sub

    Private Sub txtcity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcity.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            txtdistrict.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtaddress.Focus()
        End If
    End Sub

    Private Sub txtdistrict_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdistrict.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            txtstate.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtcity.Focus()
        End If
    End Sub

    Private Sub txtstate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtstate.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            txtpin.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtdistrict.Focus()
        End If
    End Sub

    Private Sub txtpin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpin.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            txtcountry.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtstate.Focus()
        End If
    End Sub

    Private Sub txtcountry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcountry.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            LoadState()
            txtphone.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtpin.Focus()
        End If
    End Sub

    Private Sub txtphone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtphone.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            txtfax.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtcountry.Focus()
        End If
    End Sub

    Private Sub txtfax_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfax.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            cmbdob.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtphone.Focus()
        End If
    End Sub

    Private Sub txtemail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtemail.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            cmbcategory.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            cmbdob.Focus()
        End If
    End Sub

    Private Sub txtpresentposition_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpresentposition.GotFocus
        txtpresentposition.Text = cmbdesignation.Text
    End Sub

    Private Sub txtpresentposition_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpresentposition.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            cmbretirement.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            cmbph.Focus()
        End If
    End Sub

    Private Sub txtfulladdress_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfulladdress.GotFocus
        txtfulladdress.Text = txthouseno.Text + ", " + txtaddress.Text + ", " + txtcity.Text + ", " + txtdistrict.Text + ", " + txtstate.Text + ", " + txtpin.Text + ", " + txtcountry.Text
    End Sub

    Private Sub txtfulladdress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfulladdress.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            cmbpayinfo.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            cmbretirement.Focus()
        End If
    End Sub

    Private Sub txtgrade_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtgrade.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            txtbasic.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            cmbpayscale.Focus()
        End If
    End Sub

    Private Sub txtbasic_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbasic.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            cmbjoining.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtgrade.Focus()
        End If
    End Sub

    Private Sub txtphdthesis_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtphdthesis.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            cmbqualifiedtest.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            dgviewacademic.Focus()
        End If
    End Sub

    Private Sub txtpapers_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpapers.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            txtbooks.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            ETabControl1.SelectTab(TabPage4)
        End If
    End Sub

    Private Sub txtbooks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbooks.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            txtarticles.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtpapers.Focus()
        End If
    End Sub

    Private Sub txtarticles_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtarticles.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            txtdetails1.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtbooks.Focus()
        End If
    End Sub

    Private Sub cmbqualifiedtest_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbqualifiedtest.KeyDown
        If (e.KeyCode) = Keys.Enter Then
            If btnattach.Visible = True Then
                btnattach.Focus()
            Else
                ETabControl1.SelectTab(TabPage3)
            End If
        End If
    End Sub

    Private Sub cmbqualifiedtest_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbqualifiedtest.SelectedIndexChanged
        If cmbqualifiedtest.Text = "Yes" Then
            Label42.Visible = True
            btnattach.Visible = True
        Else
            Label42.Visible = False
            btnattach.Visible = False
        End If
    End Sub

    Private Sub cmbcategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcategory.KeyDown
        If (e.KeyCode) = Keys.Enter Then
            cmbdesignation.Focus()
        End If
    End Sub

    Private Sub cmbmarried_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbmarried.KeyDown
        If (e.KeyCode) = Keys.Enter Then
            cmbsex.Focus()
        End If
    End Sub

    Private Sub cmbsex_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbsex.KeyDown
        If (e.KeyCode) = Keys.Enter Then
            cmbph.Focus()
        End If
    End Sub

    Private Sub cmbph_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbph.KeyDown
        If (e.KeyCode) = Keys.Enter Then
            txtpresentposition.Focus()
        End If
    End Sub

    Private Sub cmbpayinfo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbpayinfo.KeyDown
        If (e.KeyCode) = Keys.Enter Then
            cmbpayscale.Focus()
        End If
    End Sub

    Private Sub cmbdesignation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdesignation.KeyDown
        If (e.KeyCode) = Keys.Enter Then
            cmbdepartment.Focus()
        End If
    End Sub

    Private Sub cmbdepartment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdepartment.KeyDown
        If (e.KeyCode) = Keys.Enter Then
            cmbmarried.Focus()
        End If
    End Sub

    Private Sub cmbpayscale_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbpayscale.KeyDown
        If (e.KeyCode) = Keys.Enter Then
            txtgrade.Focus()
        End If
    End Sub

    Private Sub cmbdob_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdob.KeyDown
        If (e.KeyCode) = Keys.Enter Then
            txtemail.Focus()
        End If
    End Sub

    Private Sub cmbretirement_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbretirement.KeyDown
        If (e.KeyCode) = Keys.Enter Then
            txtfulladdress.Focus()
        End If
    End Sub

    Private Sub cmbjoining_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbjoining.KeyDown
        If (e.KeyCode) = Keys.Enter Then
            ETabControl1.SelectTab(TabPage2)
        End If
    End Sub

    Private Sub btndesignation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndesignation.Click
        Dim frm As New frmDesignation()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.Show()
    End Sub

    Private Sub btndepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndepartment.Click
        Dim frm As New frmDepartments()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.Show()
    End Sub

    Private Sub btnpayscale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpayscale.Click
        Dim frm As New frmPayScale()
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        frm.WindowState = FormWindowState.Normal
        frm.ControlBox = True
        frm.Show()
    End Sub

    Private Sub lnkaddlang_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkaddlang.LinkClicked
        dgviewlanguage.Rows.Add()
        dgviewlanguage.ClearSelection()
    End Sub

    Private Sub lnkaddaca_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkaddaca.LinkClicked
        dgviewacademic.Rows.Add()
        dgviewacademic.ClearSelection()
    End Sub

    Private Sub lnkaddteach_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkaddteach.LinkClicked
        dgviewteachingexp.Rows.Add()
        dgviewteachingexp.ClearSelection()
    End Sub

    Private Sub lnkaddresearch_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkaddresearch.LinkClicked
        dgviewexpreaserch.Rows.Add()
        dgviewexpreaserch.ClearSelection()
    End Sub

    Private Sub lnkaddprog_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkaddprog.LinkClicked
        dgviewprogramming.Rows.Add()
        dgviewprogramming.ClearSelection()
    End Sub

    Private Sub DeleteSelectedRowToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSelectedRowToolStripMenuItem4.Click
        Dim k As Integer = dgviewlanguage.CurrentRow.Index
        dgviewlanguage.Rows.RemoveAt(k)
    End Sub

    Private Sub DeleteSelectedRowToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSelectedRowToolStripMenuItem3.Click
        Dim k As Integer = dgviewacademic.CurrentRow.Index
        dgviewacademic.Rows.RemoveAt(k)
    End Sub

    Private Sub DeleteSelectedRowToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSelectedRowToolStripMenuItem2.Click
        Dim k As Integer = dgviewteachingexp.CurrentRow.Index
        dgviewteachingexp.Rows.RemoveAt(k)
    End Sub

    Private Sub DeleteSelectedRowToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSelectedRowToolStripMenuItem1.Click
        Dim k As Integer = dgviewexpreaserch.CurrentRow.Index
        dgviewexpreaserch.Rows.RemoveAt(k)
    End Sub

    Private Sub DeleteSelectedRowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSelectedRowToolStripMenuItem.Click
        Dim k As Integer = dgviewprogramming.CurrentRow.Index
        dgviewprogramming.Rows.RemoveAt(k)
    End Sub

    Private Sub txtdetails1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdetails1.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            txtdetails2.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtarticles.Focus()
        End If
    End Sub

    Private Sub txtdetails2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdetails2.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            txtdetails3.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtdetails1.Focus()
        End If
    End Sub

    Private Sub txtdetails3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdetails3.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            txtdetails4.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtdetails2.Focus()
        End If
    End Sub

    Private Sub txtdetails4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdetails4.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            txtreferee1.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtdetails3.Focus()
        End If
    End Sub

    Private Sub txtreferee1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtreferee1.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            txtreferee2.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtdetails4.Focus()
        End If
    End Sub

    Private Sub txtreferee2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtreferee2.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            txtreferee3.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtreferee1.Focus()
        End If
    End Sub

    Private Sub txtreferee3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtreferee3.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            txtotherdetails.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtreferee2.Focus()
        End If
    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbasic.KeyPress, txtemail.KeyPress, txtfax.KeyPress, txtfirst.KeyPress, txtgrade.KeyPress, txtlast.KeyPress, txtmiddle.KeyPress, txtphone.KeyPress, txtpin.KeyPress
        If Asc(e.KeyChar) = 32 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txthouseno.TextChanged, txtaddress.TextChanged, txtcity.TextChanged, txtcountry.TextChanged, txtdistrict.TextChanged, txtfirst.TextChanged, txtfulladdress.TextChanged, txtlast.TextChanged, txtmiddle.TextChanged, txtpresentposition.TextChanged, txtstate.TextChanged, txtdetails1.TextChanged, txtdetails2.TextChanged, txtdetails3.TextChanged, txtdetails4.TextChanged, txtreferee1.TextChanged, txtreferee2.TextChanged, txtreferee3.TextChanged, txtphdthesis.TextChanged
        Dim ctc As New cTextChange()
        Dim x As eTextBox = CType(sender, eTextBox)
        ctc.ConvertTextBoxValidValue(x)
    End Sub

    Private Sub ComboBoxKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcategory.KeyPress, cmbdepartment.KeyPress, cmbdesignation.KeyPress, cmbdob.KeyPress, cmbjoining.KeyPress, cmbmarried.KeyPress, cmbpayinfo.KeyPress, cmbpayscale.KeyPress, cmbph.KeyPress, cmbqualifiedtest.KeyPress, cmbretirement.KeyPress, cmbsex.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub

    Private Sub lnkremove_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkremove.LinkClicked
        lblattached.Text = ""
        Label42.Visible = False
        lblattached.Visible = False
        lnkremove.Visible = False
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmEnrollSuperAdmin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updateemployee = False Then
            ControlSetBound()
            LoadCountry()
            LoadState()
            LoadDepartment()
            LoadDesignation()
            LoadPayScale()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadCountry()
            LoadState()
            LoadDepartment()
            LoadDesignation()
            LoadPayScale()
            LoadSelectedEmployee()
            LoadSelectedEmployeeProgrammingLang()
            LoadSelectedEmployeeAcademic()
            LoadSelectedEmployeeTeachingExp()
            LoadSelectedEmployeeResearchExp()
            LoadSelectedEmployeeLanguage()
            LoadSelectedEmployeeProciency()
            LoadSelectedEmployeeActivity()
            txtregistrationno.Focus()
        End If
        If USemployeeinfo = "View Only" Then
            btnattach.Enabled = False
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbcategory.Enabled = False
            cmbdepartment.Enabled = False
            cmbdesignation.Enabled = False
            cmbdob.Enabled = False
            cmbjoining.Enabled = False
            cmbmarried.Enabled = False
            cmbpayinfo.Enabled = False
            cmbpayscale.Enabled = False
            cmbph.Enabled = False
            cmbqualifiedtest.Enabled = False
            cmbretirement.Enabled = False
            cmbsex.Enabled = False
            txtaddress.ReadOnly = True
            txtarticles.ReadOnly = True
            txtbasic.ReadOnly = True
            txtbooks.ReadOnly = True
            txtcity.ReadOnly = True
            txtcountry.ReadOnly = True
            txtdetails1.ReadOnly = True
            txtdetails2.ReadOnly = True
            txtdetails3.ReadOnly = True
            txtdetails4.ReadOnly = True
            txtdistrict.ReadOnly = True
            txtemail.ReadOnly = True
            txtfax.ReadOnly = True
            txtfirst.ReadOnly = True
            txtfulladdress.ReadOnly = True
            txtgrade.ReadOnly = True
            txthouseno.ReadOnly = True
            txtlast.ReadOnly = True
            txtmiddle.ReadOnly = True
            txtotherdetails.ReadOnly = True
            txtpapers.ReadOnly = True
            txtphdthesis.ReadOnly = True
            txtphone.ReadOnly = True
            txtpin.ReadOnly = True
            txtpresentposition.ReadOnly = True
            txtreferee1.ReadOnly = True
            txtreferee2.ReadOnly = True
            txtreferee3.ReadOnly = True
            txtregistrationno.ReadOnly = True
            txtstate.ReadOnly = True
            lnkaddaca.Enabled = False
            lnkaddlang.Enabled = False
            lnkaddprog.Enabled = False
            lnkaddresearch.Enabled = False
            lnkaddteach.Enabled = False
            lnkremove.Enabled = False
            dgviewacademic.Enabled = False
            dgviewexpreaserch.Enabled = False
            dgviewlanguage.Enabled = False
            dgviewprogramming.Enabled = False
            dgviewteachingexp.Enabled = False
            ProfilePic1.Enabled = False
            nudrexpmonth.Enabled = False
            nudrexpyear.Enabled = False
            nudtexpmonth.Enabled = False
            nudtexpyear.Enabled = False
            rbtncmserpexpert.Enabled = False
            rbtncmserpno.Enabled = False
            rbtncmserpworking.Enabled = False
            rbtnemailexpert.Enabled = False
            rbtnemailno.Enabled = False
            rbtnemailworking.Enabled = False
            rbtninternetexpert.Enabled = False
            rbtninternetno.Enabled = False
            rbtninternetworking.Enabled = False
            rbtnmsexcelexpert.Enabled = False
            rbtnmsexcelno.Enabled = False
            rbtnmsexcelworking.Enabled = False
            rbtnmspptexpert.Enabled = False
            rbtnmspptno.Enabled = False
            rbtnmspptworking.Enabled = False
            rbtnmswordexpert.Enabled = False
            rbtnmswordno.Enabled = False
            rbtnmswordworking.Enabled = False
        End If
        txtfirst.Focus()
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
#Region "Button Events..."
    Private Sub btnupload_ClickButtonArea(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnupload.ClickButtonArea
        LoadImage(ProfilePic1, 999999999)
    End Sub

    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updateemployee = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updateemployee = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updateemployee = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updateemployee = False Then
            ControlSetBound()
            LoadCountry()
            LoadState()
            LoadDepartment()
            LoadDesignation()
            LoadPayScale()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadCountry()
            LoadState()
            LoadDepartment()
            LoadDesignation()
            LoadPayScale()
            LoadSelectedEmployee()
            LoadSelectedEmployeeProgrammingLang()
            LoadSelectedEmployeeAcademic()
            LoadSelectedEmployeeTeachingExp()
            LoadSelectedEmployeeResearchExp()
            LoadSelectedEmployeeLanguage()
            LoadSelectedEmployeeProciency()
            LoadSelectedEmployeeActivity()
            txtregistrationno.Focus()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub

    Private Sub btnattach_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnattach.ClickButtonArea
        AttachCopy()
    End Sub
#End Region
#Region "DGViewEvents..."
    Private Sub dgviewacademic_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgviewacademic.LostFocus
        dgviewacademic.ClearSelection()
    End Sub

    Private Sub dgviewexpreaserch_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgviewexpreaserch.LostFocus
        dgviewexpreaserch.ClearSelection()
    End Sub

    Private Sub dgviewlanguage_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgviewlanguage.LostFocus
        dgviewlanguage.ClearSelection()
    End Sub

    Private Sub dgviewprogramming_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgviewprogramming.LostFocus
        dgviewprogramming.ClearSelection()
    End Sub

    Private Sub dgviewteachingexp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgviewteachingexp.LostFocus
        dgviewteachingexp.ClearSelection()
    End Sub
#End Region
End Class
#End Region
