#Region "Imports..."
Imports System
Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports ESAR_Controls.UIControls.TextBox

#End Region
#Region "Class frmHiredEmployee..."
Public Class frmHiredEmployee
#Region "Declarations..."
    Private HCODE As String = ""
    Private TT As String = ""
    Private DGVDepartment As New Windows.Forms.DataGridView()
    Private DGVDesignation As New Windows.Forms.DataGridView()
    Private DGVPayscale As New Windows.Forms.DataGridView()
    Private ofd As New OpenFileDialog()
    Private EmpExist As Boolean = False
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
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        HCODE = Indx.LoadHiredEmpID()
        Dim var As String
        var = CodeIncrement(HCODE)
        Me.txtregistrationno.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("HEMP:{0:00000000}", Temp)
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
        txtregistrationno.SetBounds(15, 30, 100, 21)
        txtstate.SetBounds(122, 111, 211, 21)
        ProfilePic1.SetBounds(645, 33, 100, 111)
        btnupload.SetBounds(645, 156, 112, 25)

        Grouper2.Height = 157
        Label8.SetBounds(15, 37, 103, 13)
        Label9.SetBounds(374, 37, 118, 13)
        Label10.SetBounds(15, 64, 81, 13)
        Label11.SetBounds(15, 91, 60, 13)
        Label12.SetBounds(15, 119, 96, 13)
        lblpayinfo.SetBounds(262, 91, 86, 13)
        cmbjoining.SetBounds(122, 116, 135, 21)
        cmbpayinfo.SetBounds(122, 88, 135, 21)
        cmbretirement.SetBounds(498, 34, 112, 21)
        txtfulladdress.SetBounds(122, 61, 488, 21)
        txtpresentposition.SetBounds(122, 34, 224, 21)
        txtpay.SetBounds(354, 88, 64, 21)
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
                    CheckHiredEmployee()
                    If EmpExist = False Then
                        cmd.CommandText = "insert into HiredEmployee(InsID,InsName,Period,empid,picture) values (@InsID,@InsName,@Period,@empid,@picture)"
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

                        Dim cls As New cHiredEmployee()
                        cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtregistrationno.Text, txtfirst.Text, txtmiddle.Text, txtlast.Text, txthouseno.Text, txtaddress.Text, txtcity.Text, txtdistrict.Text, txtstate.Text, txtpin.Text, txtcountry.Text, txtphone.Text, txtfax.Text, cmbdob.Text, txtemail.Text, cmbcategory.Text, cmbdepartment.Text, cmbdesignation.Text, cmbmarried.Text, cmbsex.Text, cmbph.Text, txtpresentposition.Text, cmbretirement.Text, txtfulladdress.Text, cmbpayinfo.Text, CDec(txtpay.Text), cmbjoining.Text)
                        If cls.AddRecordOk = True Then
                            Dim result1 As DialogResult = MessageBox.Show("Record saved successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = DialogResult.OK Then
                                txtfirst.Focus()
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Registration no. already exist." + Environment.NewLine + "Please enter a new registration no.", "Umbrella - Duplicate Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                    cmd.CommandText = "update HiredEmployee set picture=@picture where InsID=@InsID and empid=@empid"
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

                    Dim cls As New cHiredEmployee()
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtregistrationno.Text, txtfirst.Text, txtmiddle.Text, txtlast.Text, txthouseno.Text, txtaddress.Text, txtcity.Text, txtdistrict.Text, txtstate.Text, txtpin.Text, txtcountry.Text, txtphone.Text, txtfax.Text, cmbdob.Text, txtemail.Text, cmbcategory.Text, cmbdepartment.Text, cmbdesignation.Text, cmbmarried.Text, cmbsex.Text, cmbph.Text, txtpresentposition.Text, cmbretirement.Text, txtfulladdress.Text, cmbpayinfo.Text, CDec(txtpay.Text), cmbjoining.Text)
                    If cls.UpdateRecordOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record saved successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = DialogResult.OK Then
                            txtfirst.Focus()
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
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim cls As New cHiredEmployee()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, txtregistrationno.Text)
                    If cls.AddRecordOk = True Then
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

    Private Sub LoadSelectedRecord()
        Try
            cmd.CommandText = "select * from HiredEmployee where empid='" & EmpRegNo & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
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
                txtaddress.Text = dr("address").ToString()
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
                txtpay.Text = dr("pay").ToString()
                cmbph.Text = dr("handicapped").ToString()
                cmbretirement.Text = dr("retirementdate").ToString()
                cmbsex.Text = dr("sex").ToString()
                txtregistrationno.Focus()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub ResetForm()
        updatehiredemployee = False
        cmbcategory.Text = ""
        cmbdepartment.Text = ""
        cmbdesignation.Text = ""
        cmbdob.Text = ""
        cmbjoining.Text = ""
        cmbmarried.Text = ""
        cmbpayinfo.Text = ""
        cmbph.Text = ""
        cmbretirement.Text = ""
        cmbsex.Text = ""
        txtaddress.Text = ""
        txtcity.Text = ""
        txtcountry.Text = ""
        txtdistrict.Text = ""
        txtemail.Text = ""
        txtfax.Text = ""
        txtfirst.Text = ""
        txtfulladdress.Text = ""
        txthouseno.Text = ""
        txtlast.Text = ""
        txtmiddle.Text = ""
        txtpay.Text = ""
        txtphone.Text = ""
        txtpin.Text = ""
        txtpresentposition.Text = ""
        txtstate.Text = ""
        If ISDAutoID = "Yes" Then
            GetCode()
        Else
            txtregistrationno.Text = ""
        End If
        ProfilePic1.Image = Global.Umbrella.My.Resources.people
        txtfirst.Focus()
    End Sub

    Private Sub CheckHiredEmployee()
        Try
            cmd.CommandText = "select * from HiredEmployee where empid='" & txtregistrationno.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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
#Region "Form Events..."
    Private Sub frmHiredEmployee_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updatehiredemployee = False Then
            ControlSetBound()
            LoadCountry()
            LoadState()
            LoadDepartment()
            LoadDesignation()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadCountry()
            LoadState()
            LoadDepartment()
            LoadDesignation()
            LoadSelectedRecord()
            txtregistrationno.Focus()
        End If
        If USemployeeinfo = "View Only" Then
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
            cmbph.Enabled = False
            cmbretirement.Enabled = False
            cmbsex.Enabled = False
            txtaddress.ReadOnly = True
            txtcity.ReadOnly = True
            txtcountry.ReadOnly = True
            txtdistrict.ReadOnly = True
            txtemail.ReadOnly = True
            txtfax.ReadOnly = True
            txtfirst.ReadOnly = True
            txtfulladdress.ReadOnly = True
            txthouseno.ReadOnly = True
            txtlast.ReadOnly = True
            txtmiddle.ReadOnly = True
            txtpay.ReadOnly = True
            txtphone.ReadOnly = True
            txtpin.ReadOnly = True
            txtpresentposition.ReadOnly = True
            txtregistrationno.ReadOnly = True
            txtstate.ReadOnly = True
            ProfilePic1.Enabled = False
        End If
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

    Private Sub txtpay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpay.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            cmbjoining.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            cmbpayinfo.Focus()
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
            txtpay.Focus()
        End If
    End Sub

    Private Sub cmbpayinfo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbpayinfo.TextChanged
        If cmbpayinfo.Text = "Hourly Based Pay" Then
            lblpayinfo.Text = "Pay per hour:"
            lblpayinfo.Visible = True
            txtpay.Visible = True
        ElseIf cmbpayinfo.Text = "Daily Pay" Then
            lblpayinfo.Text = "Pay per day:"
            lblpayinfo.Visible = True
            txtpay.Visible = True
        Else
            lblpayinfo.Text = ""
            lblpayinfo.Visible = False
            txtpay.Visible = False
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
        If (e.KeyCode) = Keys.Up Then
            txtpay.Focus()
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

    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpay.KeyPress, txtemail.KeyPress, txtfax.KeyPress, txtfirst.KeyPress, txtlast.KeyPress, txtmiddle.KeyPress, txtphone.KeyPress, txtpin.KeyPress
        If Asc(e.KeyChar) = 32 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtaddress.TextChanged, txtcity.TextChanged, txtcountry.TextChanged, txtdistrict.TextChanged, txtfirst.TextChanged, txtfulladdress.TextChanged, txthouseno.TextChanged, txtlast.TextChanged, txtmiddle.TextChanged, txtpresentposition.TextChanged, txtstate.TextChanged
        Dim ctc As New cTextChange()
        Dim x As eTextBox = CType(sender, eTextBox)
        ctc.ConvertTextBoxValidValue(x)
    End Sub

    Private Sub ComboBoxKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcategory.KeyPress, cmbdepartment.KeyPress, cmbdesignation.KeyPress, cmbdob.KeyPress, cmbjoining.KeyPress, cmbmarried.KeyPress, cmbpayinfo.KeyPress, cmbph.KeyPress, cmbretirement.KeyPress, cmbsex.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnupload_ClickButtonArea(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnupload.ClickButtonArea
        LoadImage(ProfilePic1, 999999999)
    End Sub

    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatehiredemployee = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatehiredemployee = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatehiredemployee = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updatehiredemployee = False Then
            ControlSetBound()
            LoadCountry()
            LoadState()
            LoadDepartment()
            LoadDesignation()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadCountry()
            LoadState()
            LoadDepartment()
            LoadDesignation()
            LoadSelectedRecord()
            txtregistrationno.Focus()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region