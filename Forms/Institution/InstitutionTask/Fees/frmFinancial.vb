#Region "Class frmFinancial..."
Public Class frmFinancial
#Region "Declaration..."
    Private FCODE As String = ""
    Private TT As String = ""
    Private DGVRollNo As New DataGridView()
    Private DGVCourse As New DataGridView()
    Private FileChooser As New OpenFileDialog()
    Private DoubleBytes As Long
    Private AttachmentName As String = ""
    Private AttachmentSize As String = ""
    Private AttachmentPath As String = ""
    Private AttachmentNote As String = ""
    Private WithEvents printDoc1 As New Printing.PrintDocument()
    Private WithEvents printDoc2 As New Printing.PrintDocument()
    Private WithEvents printDoc3 As New Printing.PrintDocument()
    Private WithEvents printDoc4 As New Printing.PrintDocument()
    Private WithEvents printDoc5 As New Printing.PrintDocument()
    Private WithEvents printDoc6 As New Printing.PrintDocument()
    Private WithEvents printDoc7 As New Printing.PrintDocument()
    Private WithEvents printDoc8 As New Printing.PrintDocument()
    Private WithEvents printDoc9 As New Printing.PrintDocument()
    Private WithEvents printDoc10 As New Printing.PrintDocument()
    Private WithEvents printDoc11 As New Printing.PrintDocument()
    Private WithEvents printDoc12 As New Printing.PrintDocument()
    Private FinancialExist As Boolean = False
#End Region
#Region "Functions..."
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

    Public Function GetFileSize(ByVal TheFile As String) As String
        If TheFile.Length = 0 Then Return ""
        If Not System.IO.File.Exists(TheFile) Then Return ""

        Dim TheSize As ULong = My.Computer.FileSystem.GetFileInfo(TheFile).Length
        Dim SizeType As String = ""

        Try
            Select Case TheSize
                Case Is >= 1099511627776
                    DoubleBytes = CDbl(TheSize / 1099511627776)
                    Return FormatNumber(DoubleBytes, 2) & " TB"
                Case 1073741824 To 1099511627775
                    DoubleBytes = CDbl(TheSize / 1073741824)
                    Return FormatNumber(DoubleBytes, 2) & " GB"
                Case 1048576 To 1073741823
                    DoubleBytes = CDbl(TheSize / 1048576)
                    Return FormatNumber(DoubleBytes, 2) & " MB"
                Case 1024 To 1048575
                    DoubleBytes = CDbl(TheSize / 1024)
                    Return FormatNumber(DoubleBytes, 2) & " KB"
                Case 0 To 1023
                    DoubleBytes = TheSize
                    Return FormatNumber(DoubleBytes, 2) & " bytes"
                Case Else
                    Return ""
            End Select
        Catch
            Return ""
        End Try
    End Function
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        FCODE = Indx.LoadFinancialNo()
        Dim var As String
        var = CodeIncrement(FCODE)
        Me.txtapplicantno.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("FCL:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        btnprint.SetBounds(0, 0, 75, 25)

        Label1.SetBounds(15, 36, 53, 13)
        Label10.SetBounds(15, 92, 72, 13)
        Label11.SetBounds(247, 92, 57, 13)
        Label12.SetBounds(15, 119, 46, 13)
        Label13.SetBounds(15, 146, 47, 13)
        Label2.SetBounds(290, 36, 43, 13)
        Label3.SetBounds(444, 36, 33, 13)
        Label4.SetBounds(15, 63, 93, 13)
        Label5.SetBounds(15, 90, 99, 13)
        Label6.SetBounds(290, 90, 83, 13)
        Label7.SetBounds(15, 33, 107, 26)
        Label8.SetBounds(15, 69, 38, 13)
        Label9.SetBounds(249, 65, 34, 13)

        cmbclass.SetBounds(347, 33, 91, 21)
        cmbcourse.SetBounds(120, 33, 163, 21)
        cmbdob.SetBounds(125, 62, 116, 21)
        cmbroll.SetBounds(483, 33, 85, 21)
        cmbsex.SetBounds(307, 62, 69, 21)

        txtaddress.SetBounds(80, 34, 295, 21)
        txtapplicantno.SetBounds(379, 87, 189, 21)
        txtcity.SetBounds(15, 62, 360, 21)
        txtcountry.SetBounds(242, 116, 133, 21)
        txtdistrict.SetBounds(191, 89, 184, 21)
        txtemail.SetBounds(125, 116, 251, 21)
        txtguardian.SetBounds(125, 34, 251, 21)
        txthomephone.SetBounds(125, 143, 116, 21)
        txthouseno.SetBounds(15, 34, 59, 21)
        txtname.SetBounds(120, 60, 448, 21)
        txtnationality.SetBounds(125, 89, 116, 21)
        txtpincode.SetBounds(162, 116, 74, 21)
        txtpost.SetBounds(15, 90, 170, 21)
        txtregno.SetBounds(120, 87, 160, 21)
        txtreligion.SetBounds(307, 89, 69, 21)
        txtstate.SetBounds(15, 116, 141, 21)
        txtworkphone.SetBounds(252, 143, 124, 21)

        ProfilePic1.SetBounds(692, 28, 73, 84)
    End Sub

    Private Sub LoadNationality()
        Try
            Dim Nationality As New AutoCompleteStringCollection
            Nationality.Add("Afghans")
            Nationality.Add("Albanians")
            Nationality.Add("Algerians")
            Nationality.Add("Americans")
            Nationality.Add("Andorrans")
            Nationality.Add("Angolans")
            Nationality.Add("Argentines")
            Nationality.Add("Armenians")
            Nationality.Add("Aromanians")
            Nationality.Add("Arubans")
            Nationality.Add("Australians")
            Nationality.Add("Austrians")
            Nationality.Add("Azeris")
            Nationality.Add("Bahamians")
            Nationality.Add("Bahrainis")
            Nationality.Add("Bangladeshis")
            Nationality.Add("Barbadians")
            Nationality.Add("Belarusians")
            Nationality.Add("Belgians")
            Nationality.Add("Belizeans")
            Nationality.Add("Bermudians")
            Nationality.Add("Boers")
            Nationality.Add("Bosniaks")
            Nationality.Add("Brazilians")
            Nationality.Add("Bretons")
            Nationality.Add("British")
            Nationality.Add("British Virgin Islanders")
            Nationality.Add("Bulgarians")
            Nationality.Add("Burmeses")
            Nationality.Add("Macedonian Bulgarians")
            Nationality.Add("Burkinabès")
            Nationality.Add("Burundians")
            Nationality.Add("Cambodians")
            Nationality.Add("Cameroonians")
            Nationality.Add("Canadians")
            Nationality.Add("Catalans")
            Nationality.Add("Cape Verdeans")
            Nationality.Add("Chadians")
            Nationality.Add("Chileans")
            Nationality.Add("Chinese")
            Nationality.Add("Colombians")
            Nationality.Add("Comorians")
            Nationality.Add("Congolese")
            Nationality.Add("Croatians")
            Nationality.Add("Cubans")
            Nationality.Add("Cypriots")
            Nationality.Add("Turkish Cypriots")
            Nationality.Add("Czechs")
            Nationality.Add("Danes")
            Nationality.Add("Dominicans (Republic)")
            Nationality.Add("Dominicans (Commonwealth)")
            Nationality.Add("Dutch")
            Nationality.Add("East Timorese")
            Nationality.Add("Ecuadorians")
            Nationality.Add("Egyptians")
            Nationality.Add("Emiratis")
            Nationality.Add("English")
            Nationality.Add("Eritreans")
            Nationality.Add("Estonians")
            Nationality.Add("Ethiopians")
            Nationality.Add("Faroese")
            Nationality.Add("Finns")
            Nationality.Add("Finnish Swedish")
            Nationality.Add("Fijians")
            Nationality.Add("Filipinos")
            Nationality.Add("French citizens")
            Nationality.Add("Georgians")
            Nationality.Add("Germans")
            Nationality.Add("Baltic Germans")
            Nationality.Add("Ghanaians")
            Nationality.Add("Gibraltar")
            Nationality.Add("Greeks")
            Nationality.Add("Greek Macedonians")
            Nationality.Add("Grenadians")
            Nationality.Add("Guatemalans")
            Nationality.Add("Guianese (French)")
            Nationality.Add("Guineans")
            Nationality.Add("Guinea-Bissau nationals")
            Nationality.Add("Guyanese")
            Nationality.Add("Haitians")
            Nationality.Add("Hondurans")
            Nationality.Add("Hong Kong")
            Nationality.Add("Hungarians")
            Nationality.Add("Icelanders")
            Nationality.Add("Indians")
            Nationality.Add("Indonesians")
            Nationality.Add("Iranians (Persians)")
            Nationality.Add("Iraqis")
            Nationality.Add("Irish")
            Nationality.Add("Israelis")
            Nationality.Add("Italians")
            Nationality.Add("Ivoirians")
            Nationality.Add("Jamaicans")
            Nationality.Add("Japanese")
            Nationality.Add("Jordanians")
            Nationality.Add("Kazakhs")
            Nationality.Add("Kenyans")
            Nationality.Add("Koreans")
            Nationality.Add("Kosovo Albanians")
            Nationality.Add("Kurds")
            Nationality.Add("Kuwaitis")
            Nationality.Add("Lao")
            Nationality.Add("Latvians")
            Nationality.Add("Lebanese")
            Nationality.Add("Liberians")
            Nationality.Add("Libyans")
            Nationality.Add("Liechtensteiners")
            Nationality.Add("Lithuanians")
            Nationality.Add("Luxembourgers")
            Nationality.Add("Macedonians")
            Nationality.Add("Malagasy")
            Nationality.Add("Malaysians")
            Nationality.Add("Malawians")
            Nationality.Add("Maldivians")
            Nationality.Add("Malians")
            Nationality.Add("Maltese")
            Nationality.Add("Manx")
            Nationality.Add("Mauritians")
            Nationality.Add("Mexicans")
            Nationality.Add("Moldovans")
            Nationality.Add("Moroccans")
            Nationality.Add("Mongolians")
            Nationality.Add("Montenegrins")
            Nationality.Add("Namibians")
            Nationality.Add("Nepalese")
            Nationality.Add("New Zealanders")
            Nationality.Add("Nicaraguans")
            Nationality.Add("Nigeriens")
            Nationality.Add("Nigerians")
            Nationality.Add("Norwegians")
            Nationality.Add("Pakistanis")
            Nationality.Add("Palauans")
            Nationality.Add("Palestinians")
            Nationality.Add("Panamanians")
            Nationality.Add("Papua New Guineans")
            Nationality.Add("Paraguayans")
            Nationality.Add("Peruvians")
            Nationality.Add("Poles")
            Nationality.Add("Portuguese")
            Nationality.Add("Puerto Ricans")
            Nationality.Add("Quebecers")
            Nationality.Add("Réunionnais")
            Nationality.Add("Romanians")
            Nationality.Add("Russians")
            Nationality.Add("Baltic Russians")
            Nationality.Add("Rwandans")
            Nationality.Add("Salvadorans")
            Nationality.Add("São Tomé and Príncipe")
            Nationality.Add("Saudis")
            Nationality.Add("Scots")
            Nationality.Add("Senegalese")
            Nationality.Add("Serbs")
            Nationality.Add("Sierra Leoneans")
            Nationality.Add("Singaporeans")
            Nationality.Add("Sindhian")
            Nationality.Add("Slovaks")
            Nationality.Add("Slovenes")
            Nationality.Add("Somalis")
            Nationality.Add("South Africans")
            Nationality.Add("Spaniards")
            Nationality.Add("Sri Lankans")
            Nationality.Add("St Lucians")
            Nationality.Add("Sudanese")
            Nationality.Add("Surinamese")
            Nationality.Add("Swedes")
            Nationality.Add("Swiss")
            Nationality.Add("Syrians")
            Nationality.Add("Taiwanese")
            Nationality.Add("Tanzanians")
            Nationality.Add("Thais")
            Nationality.Add("Tibetans")
            Nationality.Add("Tobagonians")
            Nationality.Add("Trinidadians")
            Nationality.Add("Tunisians")
            Nationality.Add("Turks")
            Nationality.Add("Tuvaluans")
            Nationality.Add("Ugandans")
            Nationality.Add("Ukrainians")
            Nationality.Add("Uruguayans")
            Nationality.Add("Uzbeks")
            Nationality.Add("Vanuatuans")
            Nationality.Add("Venezuelans")
            Nationality.Add("Vietnamese")
            Nationality.Add("Welsh")
            Nationality.Add("Yemenis")
            Nationality.Add("Zambians")
            Nationality.Add("Zimbabweans")
            txtnationality.AutoCompleteMode = AutoCompleteMode.Suggest
            txtnationality.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtnationality.AutoCompleteCustomSource = Nationality
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadReligion()
        Try
            Dim Religion As New AutoCompleteStringCollection
            Religion.Add("Agnosticism")
            Religion.Add("Amish")
            Religion.Add("Ancestor Worship")
            Religion.Add("Animism")
            Religion.Add("Asatrú")
            Religion.Add("Atheism")
            Religion.Add("Aum Shinrikyo")
            Religion.Add("Bahá'í Faith")
            Religion.Add("Brahma Kumari")
            Religion.Add("Branch Davidians")
            Religion.Add("Buddhism")
            Religion.Add("Celtic Paganism ")
            Religion.Add("Chen Tao")
            Religion.Add("Chinese Religion")
            Religion.Add("Christadelphians")
            Religion.Add("Christian Apostolic Church in Zion")
            Religion.Add("Christianity")
            Religion.Add("Concerned Christians")
            Religion.Add("Confucianism")
            Religion.Add("Dami Xuanjiao")
            Religion.Add("Deism")
            Religion.Add("Divine Lightmission")
            Religion.Add("Druidism")
            Religion.Add("Druze")
            Religion.Add("Dualism")
            Religion.Add("Ebionites")
            Religion.Add("Eckankar")
            Religion.Add("Gnosticism")
            Religion.Add("Hare Krishna")
            Religion.Add("Heathenism ")
            Religion.Add("Heaven's Gate")
            Religion.Add("Hinduism")
            Religion.Add("Hookers for Jesus / The Family of God")
            Religion.Add("Humanism")
            Religion.Add("Islam")
            Religion.Add("Jain")
            Religion.Add("Jedi Knights")
            Religion.Add("Jehovah's Witnesses")
            Religion.Add("Judaism")
            Religion.Add("Mennonite")
            Religion.Add("Mithraism")
            Religion.Add("Monotheism")
            Religion.Add("MysticismNative American Church")
            Religion.Add("New Age")
            Religion.Add("No Religion")
            Religion.Add("Occultism")
            Religion.Add("Order of the Solar Temple")
            Religion.Add("Paganism")
            Religion.Add("Pantheism")
            Religion.Add("People's Temple")
            Religion.Add("Polytheism")
            Religion.Add("Raja Yoga")
            Religion.Add("Rastafarian")
            Religion.Add("Ravidassia")
            Religion.Add("Salvation Army")
            Religion.Add("Santería")
            Religion.Add("Satanism")
            Religion.Add("Scientology")
            Religion.Add("Shamanism")
            Religion.Add("Shinto")
            Religion.Add("Sikhism")
            Religion.Add("Spiritualism")
            Religion.Add("Taoism")
            Religion.Add("Theism")
            Religion.Add("Thelema")
            Religion.Add("Theosophy")
            Religion.Add("Traditional African Church")
            Religion.Add("Unification Church")
            Religion.Add("Unitarianism")
            Religion.Add("Unitarian-Universalism")
            Religion.Add("Unitas Fratrum")
            Religion.Add("Universalism")
            Religion.Add("Vodun/Voodoo")
            Religion.Add("Wicca")
            Religion.Add("Witchcraft")
            Religion.Add("Yezidism")
            Religion.Add("Zhu Shen Jiao")
            Religion.Add("Zoroastrianism")
            txtreligion.AutoCompleteMode = AutoCompleteMode.Suggest
            txtreligion.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtreligion.AutoCompleteCustomSource = Religion
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
            LoadClass()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadRollNo()
        Try
            Dim col1 As New DataGridViewTextBoxColumn()
            With col1
                .Name = "Col1"
                .HeaderText = "Roll No."
            End With
            Dim col2 As New DataGridViewLinkColumn()
            With col2
                .Name = "Col2"
                .HeaderText = "Serial No."
            End With
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .Name = "Col3"
                .HeaderText = "Name"
            End With

            With DGVRollNo
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
                AddHandler DGVRollNo.CellClick, AddressOf DGVRollNo_CellClick
            End With

            DGVRollNo.Columns.Clear()
            DGVRollNo.Columns.Add(col1)
            DGVRollNo.Columns.Add(col2)
            DGVRollNo.Columns.Add(col3)

            DGVRollNo.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select roll,stuid,name from StudentRegistration where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and course='" & cmbcourse.Text & "' and class='" & cmbclass.Text & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVRollNo.Rows.Add()
                DGVRollNo.Rows(indx).Cells(0).Value = dr("roll").ToString()
                DGVRollNo.Rows(indx).Cells(1).Value = dr("stuid").ToString()
                DGVRollNo.Rows(indx).Cells(2).Value = dr("name").ToString()

                indx = indx + 1
            End While
            dr.Close()
            DGVRollNo.ClearSelection()

            cmbroll.AddDataGridView(DGVRollNo, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVRollNo_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVRollNo.CurrentRow.Index
            DGVRollNo.Rows(k).Selected = True
            DGVRollNo.CurrentCell = DGVRollNo.Rows(k).Cells(0)
            Dim roll As String = DGVRollNo.Rows(k).Cells(0).Value.ToString()
            StuID = DGVRollNo.Rows(k).Cells(1).Value.ToString()
            StuName = DGVRollNo.Rows(k).Cells(2).Value.ToString()
            cmbroll.Text = roll
            LoadSelectedStudent()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadClass()
        Try
            cmbclass.Items.Clear()
            cmd.CommandText = "select distinct(class) from StudentRegistration where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and course='" & cmbcourse.Text & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                cmbclass.Items.Add(dr("class").ToString())
            End While
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadSelectedStudent()
        Try
            cmd.CommandText = "select stuid,dob,sex,email,preaddress,precity,prepost,precountry,predist,fgname,homephone,prehouseno,name,perpin,perstate,workphone from StudentRegistration where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and course='" & cmbcourse.Text & "' and class='" & cmbclass.Text & "' and roll='" & cmbroll.Text & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                txtname.Text = dr("name").ToString()
                txtregno.Text = dr("stuid").ToString()
                txtguardian.Text = dr("fgname").ToString()
                cmbdob.Text = dr("dob").ToString()
                cmbsex.Text = dr("sex").ToString()
                txtemail.Text = dr("email").ToString()
                txthomephone.Text = dr("homephone").ToString()
                txtworkphone.Text = dr("workphone").ToString()
                txthouseno.Text = dr("prehouseno").ToString()
                txtaddress.Text = dr("preaddress").ToString()
                txtcity.Text = dr("precity").ToString()
                txtpost.Text = dr("prepost").ToString()
                txtdistrict.Text = dr("predist").ToString()
                txtstate.Text = dr("perstate").ToString()
                txtpincode.Text = dr("perpin").ToString()
                txtcountry.Text = dr("precountry").ToString()
            End If
            dr.Close()
            LoadSelectedPicture(cmbcourse.Text, txtname.Text)
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadSelectedPicture(ByVal stid As String, ByVal stnm As String)
        Try
            cmd.CommandText = "select picture from StudentRegistration where stuid='" & txtregno.Text & "' and class='" & cmbclass.Text & "' and roll='" & cmbroll.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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
        Try
            ETabControl1.TabPages.Remove(TabPage3)
            updatefinancial = False
            ProfilePic1.Image = Global.Umbrella.My.Resources.people
            FileChooser.FileName = ""
            AttachmentName = ""
            AttachmentNote = ""
            AttachmentPath = ""
            AttachmentSize = ""
            rtbattachment.rtb.Text = ""
            txtaddress.Text = ""
            txtcity.Text = ""
            cmbclass.Text = ""
            txtpost.Text = ""
            txtcountry.Text = ""
            cmbcourse.Text = ""
            txtdistrict.Text = ""
            txtemail.Text = ""
            txtguardian.Text = ""
            txthomephone.Text = ""
            txthouseno.Text = ""
            txtname.Text = ""
            txtnationality.Text = ""
            txtpincode.Text = ""
            txtreligion.Text = ""
            cmbroll.Text = ""
            txtregno.Text = ""
            txtstate.Text = ""
            txtworkphone.Text = ""
            cmbdob.Text = ""
            cmbsex.Text = ""
            cmbcourse.Text = ""
            If ISDAutoID = "Yes" Then
                GetCode()
            Else
                txtapplicantno.Text = ""
            End If
            cmbcourse.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedFinancial()
        Try
            Dim regno As String = ""
            cmd.CommandText = "select * from FinancialLoan where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and regno='" & StuID & "' and applicantno='" & financialid & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                cmbclass.Text = dr("class").ToString()
                cmbcourse.Text = dr("course").ToString()
                cmbroll.Text = dr("roll").ToString()
                regno = dr("regno").ToString()
                txtapplicantno.Text = dr("applicantno").ToString()
                txtnationality.Text = dr("nationality").ToString()
                txtreligion.Text = dr("religion").ToString()
                txtcity.Text = dr("city").ToString()
                lblattachment.Text = dr("attachmentname").ToString() + " (Size: " + dr("attachmentsize").ToString() + ")"
                rtbattachment.rtb.Text = dr("attachmentnote").ToString()
                AttachmentName = dr("attachmentname").ToString()
                AttachmentPath = dr("attachmentpath").ToString()
                AttachmentSize = dr("attachmentsize").ToString()
                AttachmentNote = dr("attachmentnote").ToString()
            End If
            dr.Close()
            LoadSelectedStudent()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub AddRecord()
        Try
            If cmbcourse.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbcourse.Focus()
                End If
            ElseIf txtapplicantno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter applicant no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtapplicantno.Focus()
                End If
            ElseIf txtnationality.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter nationality.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtnationality.Focus()
                End If
            ElseIf txtreligion.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter religion.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtreligion.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    CheckFinancial()
                    If FinancialExist = False Then
                        Dim cls As New cFinancialLoan()
                        AttachmentNote = rtbattachment.rtb.Text
                        cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtregno.Text, txtapplicantno.Text, txtnationality.Text, txtreligion.Text, AttachmentName, AttachmentSize, AttachmentPath, AttachmentNote)
                        If cls.AddFinancialLoanOk = True Then
                            Dim result1 As DialogResult = MessageBox.Show("Record added successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = Windows.Forms.DialogResult.OK Then
                                cmbcourse.Focus()
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Applicant no. already exist." + Environment.NewLine + "Please enter a new applicant no.", "Umbrella - Duplicate Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            txtapplicantno.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If cmbcourse.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbcourse.Focus()
                End If
            ElseIf txtapplicantno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter applicant no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtapplicantno.Focus()
                End If
            ElseIf txtnationality.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter nationality.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtnationality.Focus()
                End If
            ElseIf txtreligion.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter religion.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtreligion.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cFinancialLoan()
                    AttachmentNote = rtbattachment.rtb.Text
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtregno.Text, txtapplicantno.Text, txtnationality.Text, txtreligion.Text, AttachmentName, AttachmentSize, AttachmentPath, AttachmentNote)
                    If cls.UpdateFinancialLoanOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            cmbcourse.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If cmbcourse.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbcourse.Focus()
                End If
            ElseIf txtapplicantno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter applicant no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtapplicantno.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Missing Value", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cFinancialLoan()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtregno.Text, txtapplicantno.Text)
                    If cls.DeleteFinancialLoanOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record deleted successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            ResetForm()
                            cmbcourse.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    
    Private Sub PrintImage1(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDoc1.PrintPage
        e.Graphics.DrawImage(PictureBox1.Image, e.MarginBounds.Left, e.MarginBounds.Top)
    End Sub

    Private Sub PrintImage2(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDoc2.PrintPage
        e.Graphics.DrawImage(PictureBox2.Image, e.MarginBounds.Left, e.MarginBounds.Top)
    End Sub

    Private Sub PrintImage3(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDoc3.PrintPage
        e.Graphics.DrawImage(PictureBox3.Image, e.MarginBounds.Left, e.MarginBounds.Top)
    End Sub

    Private Sub PrintImage4(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDoc4.PrintPage
        e.Graphics.DrawImage(PictureBox4.Image, e.MarginBounds.Left, e.MarginBounds.Top)
    End Sub

    Private Sub PrintImage5(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDoc5.PrintPage
        e.Graphics.DrawImage(PictureBox5.Image, e.MarginBounds.Left, e.MarginBounds.Top)
    End Sub

    Private Sub PrintImage6(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDoc6.PrintPage
        e.Graphics.DrawImage(PictureBox6.Image, e.MarginBounds.Left, e.MarginBounds.Top)
    End Sub

    Private Sub PrintImage7(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDoc7.PrintPage
        e.Graphics.DrawImage(PictureBox7.Image, e.MarginBounds.Left, e.MarginBounds.Top)
    End Sub

    Private Sub PrintImage8(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDoc8.PrintPage
        e.Graphics.DrawImage(PictureBox8.Image, e.MarginBounds.Left, e.MarginBounds.Top)
    End Sub

    Private Sub PrintImage9(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDoc9.PrintPage
        e.Graphics.DrawImage(PictureBox9.Image, e.MarginBounds.Left, e.MarginBounds.Top)
    End Sub

    Private Sub PrintImage10(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDoc10.PrintPage
        e.Graphics.DrawImage(PictureBox10.Image, e.MarginBounds.Left, e.MarginBounds.Top)
    End Sub

    Private Sub PrintImage11(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDoc11.PrintPage
        e.Graphics.DrawImage(PictureBox11.Image, e.MarginBounds.Left, e.MarginBounds.Top)
    End Sub

    Private Sub PrintImage12(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDoc12.PrintPage
        e.Graphics.DrawImage(PictureBox12.Image, e.MarginBounds.Left, e.MarginBounds.Top)
    End Sub

    Private Sub CheckFinancial()
        Try
            cmd.CommandText = "select * from FinancialLoan where applicantno='" & txtapplicantno.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                FinancialExist = True
            Else
                FinancialExist = False
            End If
            dr.Close()
        Catch ex As Exception
            FinancialExist = False
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmFinancial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If updatefinancial = False Then
            ControlSetBound()
            LoadNationality()
            LoadReligion()
            LoadCourse()
            ETabControl1.TabPages.Remove(TabPage3)
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadNationality()
            LoadReligion()
            LoadCourse()
            LoadSelectedFinancial()
            ETabControl1.TabPages.Remove(TabPage3)
        End If
        If USfinancialloan = "View Only" Then
            btnattachfile.Enabled = False
            btndelete.Enabled = False
            btnprint.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbclass.Enabled = False
            cmbcourse.Enabled = False
            cmbdob.Enabled = False
            cmbroll.Enabled = False
            cmbsex.Enabled = False
            txtaddress.ReadOnly = True
            txtapplicantno.ReadOnly = True
            txtcity.ReadOnly = True
            txtcountry.ReadOnly = True
            txtdistrict.ReadOnly = True
            txtemail.ReadOnly = True
            txtguardian.ReadOnly = True
            txthomephone.ReadOnly = True
            txthouseno.ReadOnly = True
            txtname.ReadOnly = True
            txtnationality.ReadOnly = True
            txtpincode.ReadOnly = True
            txtpost.ReadOnly = True
            txtregno.ReadOnly = True
            txtreligion.ReadOnly = True
            txtstate.ReadOnly = True
            txtworkphone.ReadOnly = True
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatefinancial = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatefinancial = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatefinancial = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updatefinancial = False Then
            ControlSetBound()
            LoadNationality()
            LoadReligion()
            LoadCourse()
            ETabControl1.TabPages.Remove(TabPage3)
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadNationality()
            LoadReligion()
            LoadCourse()
            LoadSelectedFinancial()
            ETabControl1.TabPages.Remove(TabPage3)
        End If
    End Sub

    Private Sub btnattach_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnattach.ClickButtonArea
        ETabControl1.TabPages.Add(TabPage3)
        ETabControl1.SelectTab(TabPage3)
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub

    Private Sub btnclose_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnclose.ClickButtonArea
        ETabControl1.TabPages.Remove(TabPage3)
    End Sub

    Private Sub btnattachfile_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnattachfile.ClickButtonArea
        Try
            FileChooser.Multiselect = False
            FileChooser.Filter = "Microsoft Word File (*.doc)|*.doc|Microsoft Word 2007 or Later File (*.docx)|*.docx|Microsoft Excel File (*.xls)|*.xls|Microsoft Excel 2007 or Later File (*.xlsx)|*.xlsx|Microsoft Power Point File (*.ppt)|*.ppt|Microsoft Power Point 2007 or Later File (*.pptx)|*.pptx|Rich Text File (*.rtf)|*.rtf|Adobe PDF Document (*.pdf)|*.pdf|Winrar Archirve (*.rar)|*.rar|Winzip Archieve (*.zip)|*.zip"
            Dim result As DialogResult = FileChooser.ShowDialog()
            If result = Windows.Forms.DialogResult.Cancel Then
                lblattachment.Visible = False
            Else
                AttachmentPath = FileChooser.FileName
                Dim fnPeices() As String = AttachmentPath.Split("\")
                AttachmentName = fnPeices(fnPeices.Length - 1)
                Dim fnExten() As String = AttachmentPath.Split(".")
                AttachmentSize = GetFileSize(AttachmentPath)
                lblattachment.Text = AttachmentName + " (Size: " + AttachmentSize + ")"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnprint_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnprint.ClickButtonArea
        printDoc1.Print()
        printDoc2.Print()
        printDoc3.Print()
        printDoc4.Print()
        printDoc5.Print()
        printDoc6.Print()
        printDoc7.Print()
        printDoc8.Print()
        printDoc9.Print()
        printDoc10.Print()
        printDoc11.Print()
        printDoc12.Print()
    End Sub
#End Region
#Region "Attributes..."
    Private Sub cmbcourse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcourse.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbclass.Focus()
        End If
    End Sub

    Private Sub cmbclass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbclass.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbroll.Focus()
        End If
    End Sub

    Private Sub cmbclass_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbclass.TextChanged
        If cmbclass.Text <> "" Then
            LoadRollNo()
        End If
    End Sub

    Private Sub cmbroll_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbroll.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtname.Focus()
        End If
    End Sub

    Private Sub txtname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtregno.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbroll.Focus()
        End If
    End Sub

    Private Sub txtregno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtregno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtapplicantno.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtname.Focus()
        End If
    End Sub

    Private Sub txtapplicantno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtapplicantno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtguardian.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtregno.Focus()
        End If
    End Sub

    Private Sub txtguardian_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtguardian.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtnationality.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtapplicantno.Focus()
        End If
    End Sub

    Private Sub txtnationality_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnationality.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtreligion.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtguardian.Focus()
        End If
    End Sub

    Private Sub txtreligion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtreligion.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtemail.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtnationality.Focus()
        End If
    End Sub

    Private Sub txtemail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtemail.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txthomephone.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtreligion.Focus()
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
            txthouseno.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txthomephone.Focus()
        End If
    End Sub

    Private Sub txthouseno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txthouseno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtaddress.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtworkphone.Focus()
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
            txtpincode.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtdistrict.Focus()
        End If
    End Sub

    Private Sub txtpincode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpincode.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtcountry.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtstate.Focus()
        End If
    End Sub

    Private Sub txtcountry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcountry.KeyDown
        If e.KeyCode = Keys.Up Then
            txtpincode.Focus()
        End If
    End Sub

    Private Sub TextBoxTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtaddress.TextChanged, txtcity.TextChanged, txtcountry.TextChanged, txtdistrict.TextChanged, txtguardian.TextChanged, txtname.TextChanged, txtnationality.TextChanged, txtpost.TextChanged, txtreligion.TextChanged, txtstate.TextChanged
        Dim x As ESAR_Controls.UIControls.TextBox.eTextBox = CType(sender, ESAR_Controls.UIControls.TextBox.eTextBox)
        ctc.ConvertTextBoxValidValue(x)
    End Sub

    Private Sub TextBoxKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtemail.KeyPress, txthomephone.KeyPress, txtpincode.KeyPress, txtworkphone.KeyPress
        If Asc(e.KeyChar) = 32 Then
            e.Handled = True
        End If
    End Sub
#End Region
End Class
#End Region