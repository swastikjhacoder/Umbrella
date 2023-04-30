#Region "Import..."
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports Outlook = Microsoft.Office.Interop.Outlook
Imports System.Data
Imports System.Data.SqlClient
#End Region
#Region "Class frmCreateInstitute..."
Public Class frmCreateInstitute
#Region "Configuration variables..."
    Dim LanguageTexts_Next As String = "&Next"
    Dim LanguageTexts_Finish As String = "&Finish"
    Dim LanguageTexts_Cancel As String = "&Cancel"
    Dim LanguageTexts_Back As String = "&Back"
    Dim ApplicationTitle As String = "Create Your Institute ~"
#End Region
#Region "Other variables..."
    Private emailok As Boolean = True
    Private websiteok1 As Boolean = True
    Private websiteok2 As Boolean = True
    Private ICODE As String = ""
    Private TT As String = ""
    Dim retVal As String = String.Empty
    Private PRD As String = ""
#End Region
#Region "Attributes..."
    Private Sub cmbmonth_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbmonth.KeyDown
        If (e.KeyCode) = Keys.Enter Then
            nudyear.Focus()
        End If
    End Sub

    Private Sub cmbmonth_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbmonth.KeyPress
        If Asc(e.KeyChar) = 13 Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub nudyear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudyear.KeyDown
        If (e.KeyCode) = Keys.Enter Then
            btncancel.Focus()
        End If
    End Sub

    Private Sub lnkaddachievements_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkaddachievements.LinkClicked
        dgviewachievements.Rows.Add()
        dgviewachievements.ClearSelection()
    End Sub

    Private Sub dgviewachievements_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgviewachievements.LostFocus
        dgviewachievements.ClearSelection()
    End Sub

    Private Sub dgviewachievements_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgviewachievements.RowsAdded
        Dim i As Integer = dgviewachievements.Rows.Count
        dgviewachievements.Rows(i - 1).Cells(0).Value = i.ToString()
        dgviewachievements.Rows(i - 1).Cells(0).Style.BackColor = System.Drawing.SystemColors.Control
    End Sub

    Private Sub lnkaddcourse_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkaddcourse.LinkClicked
        dgviewcourse.Rows.Add()
        dgviewcourse.ClearSelection()
    End Sub

    Private Sub dgviewcourse_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgviewcourse.LostFocus
        dgviewcourse.ClearSelection()
    End Sub

    Private Sub dgviewcourse_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgviewcourse.RowsAdded
        Dim i As Integer = dgviewcourse.Rows.Count
        dgviewcourse.Rows(i - 1).Cells(0).Value = i.ToString()
        dgviewcourse.Rows(i - 1).Cells(0).Style.BackColor = System.Drawing.SystemColors.Control
    End Sub

    Private Sub ETabControlEx1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ETabControlEx1.SelectedIndexChanged
        If ETabControlEx1.SelectedIndex = 0 Then
            Header.GroupTitle = "Create Your Institute: General Info ~"
            cmbcategory.Focus()
        ElseIf ETabControlEx1.SelectedIndex = 1 Then
            Header.GroupTitle = "Create Your Institute: Course && Features Details ~"
            dgviewcourse.Focus()
        ElseIf ETabControlEx1.SelectedIndex = 2 Then
            Header.GroupTitle = "Create Your Institute: Achievements ~"
            dgviewachievements.Focus()
        ElseIf ETabControlEx1.SelectedIndex = 3 Then
            Header.GroupTitle = "Create Your Institute: Financial Period ~"
            cmbmonth.Focus()
        ElseIf ETabControlEx1.SelectedIndex = 4 Then
            Header.GroupTitle = "Create Your Institute: Congratulations ~"
        End If
    End Sub

    Private Sub txtaddress1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaddress1.TextChanged
        ctc.ConvertTextBoxValidValue(txtaddress1)
    End Sub

    Private Sub txtaddress2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaddress2.TextChanged
        ctc.ConvertTextBoxValidValue(txtaddress2)
    End Sub

    Private Sub txtcity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcity.TextChanged
        ctc.ConvertTextBoxValidValue(txtcity)
    End Sub

    Private Sub txtstate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstate.TextChanged
        ctc.ConvertTextBoxValidValue(txtstate)
    End Sub

    Private Sub txtcountry_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcountry.TextChanged
        ctc.ConvertTextBoxValidValue(txtcountry)
    End Sub

    Private Sub txtpin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpin.KeyDown
        If (e.KeyCode) = Keys.Down Or (e.KeyCode) = Keys.Enter Then
            txtcountry.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtstate.Focus()
        End If
    End Sub

    Private Sub txtphone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtphone.KeyDown
        If (e.KeyCode) = Keys.Down Or (e.KeyCode) = Keys.Enter Then
            txtfax.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtcountry.Focus()
        End If
    End Sub

    Private Sub txtfax_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfax.KeyDown
        If (e.KeyCode) = Keys.Down Or (e.KeyCode) = Keys.Enter Then
            txtemail.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtphone.Focus()
        End If
    End Sub

    Private Sub txtemail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtemail.KeyDown
        If (e.KeyCode) = Keys.Down Or (e.KeyCode) = Keys.Enter Then
            txturl1.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtfax.Focus()
        End If
    End Sub

    Private Sub txturl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txturl1.KeyDown
        If (e.KeyCode) = Keys.Down Or (e.KeyCode) = Keys.Enter Then
            txturl2.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtemail.Focus()
        End If
    End Sub

    Private Sub txturl2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txturl2.KeyDown
        If (e.KeyCode) = Keys.Down Or (e.KeyCode) = Keys.Enter Then
            btnnext.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txturl1.Focus()
        End If
    End Sub

    Private Sub txtemail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtemail.KeyPress
        Select Case Asc(e.KeyChar)
            Case 32
                e.Handled = True
            Case Else
        End Select
    End Sub

    Private Sub txtname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtname.KeyDown
        If (e.KeyCode) = Keys.Down Or (e.KeyCode) = Keys.Enter Then
            txtaddress1.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            cmbcategory.Focus()
        End If
    End Sub

    Private Sub cmbcategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcategory.KeyDown
        If (e.KeyCode) = Keys.Enter Then
            txtname.Focus()
        End If
    End Sub

    Private Sub cmbcategory_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcategory.KeyPress
        If Asc(e.KeyChar) = 13 Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtaddress1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtaddress1.KeyDown
        If (e.KeyCode) = Keys.Down Or (e.KeyCode) = Keys.Enter Then
            txtaddress2.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtname.Focus()
        End If
    End Sub

    Private Sub txtaddress2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtaddress2.KeyDown
        If (e.KeyCode) = Keys.Down Or (e.KeyCode) = Keys.Enter Then
            txtcity.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtaddress1.Focus()
        End If
    End Sub

    Private Sub txtcity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcity.KeyDown
        If (e.KeyCode) = Keys.Down Or (e.KeyCode) = Keys.Enter Then
            txtstate.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtaddress2.Focus()
        End If
    End Sub

    Private Sub txtstate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtstate.KeyDown
        If (e.KeyCode) = Keys.Down Or (e.KeyCode) = Keys.Enter Then
            txtpin.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtcity.Focus()
        End If
    End Sub

    Private Sub txtcountry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcountry.KeyDown
        If (e.KeyCode) = Keys.Down Or (e.KeyCode) = Keys.Enter Then
            txtphone.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txtpin.Focus()
        End If
    End Sub

    Private Sub txtregistrationid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtregistrationid.KeyDown
        If (e.KeyCode) = Keys.Down Or (e.KeyCode) = Keys.Enter Then
            cmbcategory.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            txturl2.Focus()
        End If
    End Sub
#End Region
#Region "TriStateTreeView Events..."
    Private Sub node_AfterCheck(ByVal sender As Object, ByVal e As TreeViewEventArgs) Handles TriStateTreeView1.AfterCheck
        If e.Action <> TreeViewAction.Unknown Then
            If e.Node.Nodes.Count > 0 Then
                Me.CheckAllChildNodes(e.Node, e.Node.Checked)
            End If
        End If
    End Sub

    Private Sub TriStateTreeView2_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TriStateTreeView2.AfterCheck
        If e.Action <> TreeViewAction.Unknown Then
            If e.Node.Nodes.Count > 0 Then
                Me.CheckAllChildNodes(e.Node, e.Node.Checked)
            End If
        End If
    End Sub
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        ICODE = Indx.LoadInstitutionID()
        Dim var As String
        var = CodeIncrement(ICODE)
        Me.txtregistrationid.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("INS:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlsSetBounds()
        Label1.SetBounds(14, 30, 14, 13)
        Label10.SetBounds(35, 245, 56, 13)
        Label11.SetBounds(35, 272, 48, 13)
        Label12.SetBounds(515, 0, 14, 13)
        Label13.SetBounds(529, 0, 101, 13)
        Label14.SetBounds(0, 0, 317, 13)
        Label15.SetBounds(12, 123, 618, 13)
        Label16.SetBounds(20, 49, 608, 39)
        Label17.SetBounds(250, 120, 209, 13)
        Label18.SetBounds(30, 222, 448, 13)
        Label19.SetBounds(46, 140, 550, 39)
        Label2.SetBounds(35, 30, 98, 13)
        Label20.SetBounds(355, 30, 14, 13)
        Label3.SetBounds(370, 30, 65, 13)
        Label4.SetBounds(14, 56, 14, 13)
        Label5.SetBounds(35, 56, 106, 13)
        Label6.SetBounds(35, 83, 81, 13)
        Label7.SetBounds(35, 191, 70, 13)
        Label8.SetBounds(355, 190, 31, 13)
        Label9.SetBounds(35, 218, 48, 13)

        lnkaddachievements.SetBounds(542, 0, 80, 16)
        lnkaddcourse.SetBounds(531, 0, 81, 16)

        nudyear.SetBounds(184, 118, 60, 21)

        cmbcategory.SetBounds(438, 26, 179, 21)
        cmbmonth.SetBounds(57, 117, 121, 21)

        txtaddress1.SetBounds(147, 79, 469, 21)
        txtaddress2.SetBounds(147, 106, 469, 21)
        txtcity.SetBounds(147, 133, 199, 21)
        txtcountry.SetBounds(356, 160, 258, 21)
        txtemail.SetBounds(147, 214, 469, 21)
        txtfax.SetBounds(397, 187, 217, 21)
        txtname.SetBounds(147, 53, 469, 21)
        txtphone.SetBounds(147, 187, 199, 21)
        txtpin.SetBounds(147, 160, 199, 21)
        txtregistrationid.SetBounds(147, 26, 199, 21)
        txtstate.SetBounds(356, 133, 258, 21)
        txturl1.SetBounds(147, 241, 469, 21)
        txturl2.SetBounds(147, 268, 469, 21)
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
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Create()
        Try
            If txtregistrationid.Text.Trim() = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter a institution registration id !!", "eSchool: Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    ETabControlEx1.SelectTab(0)
                    txtregistrationid.Focus()
                End If
            ElseIf cmbcategory.Text.Trim() = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter institution category !!", "eSchool: Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    ETabControlEx1.SelectTab(0)
                    cmbcategory.Focus()
                End If
            ElseIf txtname.Text.Trim() = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter institution name !!", "eSchool: Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    ETabControlEx1.SelectTab(0)
                    txtname.Focus()
                End If
            Else
                Dim mont1 As Integer = CInt(Date.Now.Month.ToString())
                Dim mont2 As Integer
                Dim Year1 As Integer
                Dim Year2 As Integer

                If cmbmonth.Text = "January" Then
                    mont2 = 1
                ElseIf cmbmonth.Text = "February" Then
                    mont2 = 2
                ElseIf cmbmonth.Text = "March" Then
                    mont2 = 3
                ElseIf cmbmonth.Text = "April" Then
                    mont2 = 4
                ElseIf cmbmonth.Text = "May" Then
                    mont2 = 5
                ElseIf cmbmonth.Text = "June" Then
                    mont2 = 6
                ElseIf cmbmonth.Text = "July" Then
                    mont2 = 7
                ElseIf cmbmonth.Text = "August" Then
                    mont2 = 8
                ElseIf cmbmonth.Text = "September" Then
                    mont2 = 9
                ElseIf cmbmonth.Text = "October" Then
                    mont2 = 10
                ElseIf cmbmonth.Text = "November" Then
                    mont2 = 11
                ElseIf cmbmonth.Text = "December" Then
                    mont2 = 12
                End If
                If mont1 <= mont2 Then
                    Year2 = CInt(Date.Now.Year.ToString())
                    Year1 = Year2 - 1
                Else
                    Year1 = CInt(Date.Now.Year.ToString())
                    Year2 = Year1 + 1
                End If

                My.Settings.LastOpenedInstitute = txtname.Text

                Dim str As String = Year1.ToString() + " - " + Year2.ToString()
                PRD = str
                period = PRD

                If cmbmonth.Text = "January" Then
                    Dim DD As Integer = Date.DaysInMonth(Year1, 12)
                    Dim st As String = "01/01/" + Year1.ToString() + " - " + DD.ToString() + "/" + "12/" + Year1.ToString()
                    FinancialPeriod = st
                ElseIf cmbmonth.Text = "February" Then
                    Dim DD As Integer = Date.DaysInMonth(Year1, 1)
                    Dim st As String = "01/02/" + Year1.ToString() + " - " + DD.ToString() + "/" + "01/" + Year2.ToString()
                    FinancialPeriod = st
                ElseIf cmbmonth.Text = "March" Then
                    Dim DD As Integer = Date.DaysInMonth(Year1, 2)
                    Dim st As String = "01/03/" + Year1.ToString() + " - " + DD.ToString() + "/" + "02/" + Year2.ToString()
                    FinancialPeriod = st
                ElseIf cmbmonth.Text = "April" Then
                    Dim DD As Integer = Date.DaysInMonth(Year1, 3)
                    Dim st As String = "01/04/" + Year1.ToString() + " - " + DD.ToString() + "/" + "03/" + Year2.ToString()
                    FinancialPeriod = st
                ElseIf cmbmonth.Text = "May" Then
                    Dim DD As Integer = Date.DaysInMonth(Year1, 4)
                    Dim st As String = "01/05/" + Year1.ToString() + " - " + DD.ToString() + "/" + "04/" + Year2.ToString()
                    FinancialPeriod = st
                ElseIf cmbmonth.Text = "June" Then
                    Dim DD As Integer = Date.DaysInMonth(Year1, 5)
                    Dim st As String = "01/06/" + Year1.ToString() + " - " + DD.ToString() + "/" + "05/" + Year2.ToString()
                    FinancialPeriod = st
                ElseIf cmbmonth.Text = "July" Then
                    Dim DD As Integer = Date.DaysInMonth(Year1, 6)
                    Dim st As String = "01/07/" + Year1.ToString() + " - " + DD.ToString() + "/" + "06/" + Year2.ToString()
                    FinancialPeriod = st
                ElseIf cmbmonth.Text = "August" Then
                    Dim DD As Integer = Date.DaysInMonth(Year1, 7)
                    Dim st As String = "01/08/" + Year1.ToString() + " - " + DD.ToString() + "/" + "07/" + Year2.ToString()
                    FinancialPeriod = st
                ElseIf cmbmonth.Text = "September" Then
                    Dim DD As Integer = Date.DaysInMonth(Year1, 8)
                    Dim st As String = "01/09/" + Year1.ToString() + " - " + DD.ToString() + "/" + "08/" + Year2.ToString()
                    FinancialPeriod = st
                ElseIf cmbmonth.Text = "October" Then
                    Dim DD As Integer = Date.DaysInMonth(Year1, 9)
                    Dim st As String = "01/10/" + Year1.ToString() + " - " + DD.ToString() + "/" + "09/" + Year2.ToString()
                    FinancialPeriod = st
                ElseIf cmbmonth.Text = "November" Then
                    Dim DD As Integer = Date.DaysInMonth(Year1, 10)
                    Dim st As String = "01/11/" + Year1.ToString() + " - " + DD.ToString() + "/" + "10/" + Year2.ToString()
                    FinancialPeriod = st
                ElseIf cmbmonth.Text = "December" Then
                    Dim DD As Integer = Date.DaysInMonth(Year1, 11)
                    Dim st As String = "01/12/" + Year1.ToString() + " - " + DD.ToString() + "/" + "11/" + Year2.ToString()
                    FinancialPeriod = st
                End If

                If cmbmonth.Text = "January" Then
                    mnths = 1
                    cstartingmonth = "January"
                ElseIf cmbmonth.Text = "February" Then
                    mnths = 2
                    cstartingmonth = "February"
                ElseIf cmbmonth.Text = "March" Then
                    mnths = 3
                    cstartingmonth = "March"
                ElseIf cmbmonth.Text = "April" Then
                    mnths = 4
                    cstartingmonth = "April"
                ElseIf cmbmonth.Text = "May" Then
                    mnths = 5
                    cstartingmonth = "May"
                ElseIf cmbmonth.Text = "June" Then
                    mnths = 6
                    cstartingmonth = "June"
                ElseIf cmbmonth.Text = "July" Then
                    mnths = 7
                    cstartingmonth = "July"
                ElseIf cmbmonth.Text = "August" Then
                    mnths = 8
                    cstartingmonth = "August"
                ElseIf cmbmonth.Text = "September" Then
                    mnths = 9
                    cstartingmonth = "September"
                ElseIf cmbmonth.Text = "October" Then
                    mnths = 10
                    cstartingmonth = "October"
                ElseIf cmbmonth.Text = "November" Then
                    mnths = 11
                    cstartingmonth = "November"
                ElseIf cmbmonth.Text = "December" Then
                    mnths = 12
                    cstartingmonth = "December"
                End If
                cstartdate = "1/" + mnths.ToString() + "/" + nudyear.Value.ToString()

                TotalCourses = 0
                For row As Integer = 0 To dgviewcourse.Rows.Count - 1
                    If dgviewcourse.Rows(0).Cells(1).Value.ToString().Trim() <> "" Then
                        CourseName(row) = dgviewcourse.Rows(row).Cells(1).Value.ToString()
                        CourseCode(row) = dgviewcourse.Rows(row).Cells(2).Value.ToString()
                        Dim cduration As String = dgviewcourse.Rows(row).Cells(3).Value.ToString()
                        If cduration <> "" Then
                            CourseDuaration(row) = cduration + " Months"
                        Else
                            CourseDuaration(row) = ""
                        End If
                        If CourseName(row) <> "" Then
                            TotalCourses = TotalCourses + 1
                        End If
                    End If
                Next

                Me.CopySelectedFeatureNodes(Me.TriStateTreeView2.Nodes)

                TotalAchievements = 0
                For row As Integer = 0 To dgviewachievements.Rows.Count - 1
                    If dgviewachievements.Rows(0).Cells(1).Value.ToString().Trim() <> "" Then
                        Achievements(row) = dgviewachievements.Rows(row).Cells(1).Value.ToString()
                        TotalAchievements = TotalAchievements + 1
                    End If
                Next

                Me.CopySelectedAccountNodes(Me.TriStateTreeView1.Nodes)

                InstitutionID = txtregistrationid.Text
                InstitutionCategory = cmbcategory.Text
                InstitutionName = txtname.Text
                InstitutionAddress1 = txtaddress1.Text
                InstitutionAddress2 = txtaddress2.Text
                InstitutionCity = txtcity.Text
                InstitutionState = txtstate.Text
                InstitutionPinCode = txtpin.Text
                InstitutionCountry = txtcountry.Text
                InstitutionPhone = txtphone.Text
                InstitutionFax = txtfax.Text
                InstitutionEmail = txtemail.Text
                InstitutionUrl1 = txturl1.Text
                InstitutionUrl2 = txturl2.Text
                FinancialMonth = cmbmonth.Text
                FinancialYear = CInt(nudyear.Value.ToString())

                Dim frm As New frmProcessingInstitute()
                frm.MdiParent = Me.MdiParent
                Me.Hide()
                frm.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CopySelectedFeatureNodes(ByVal nodes As TreeNodeCollection)
        For Each node As TreeNode In nodes
            If node.Checked Then
                If node.Text <> "Features" Then
                    SelectedFeatures(TotalFeatures) = node.Text
                    'MessageBox.Show(TotalFeatures.ToString() + ":" + SelectedFeatures(TotalFeatures))
                    TotalFeatures += 1
                End If
                Me.CopySelectedFeatureNodes(node.Nodes)
            End If
        Next node
    End Sub

    Private Sub CopySelectedAccountNodes(ByVal nodes As TreeNodeCollection)
        Dim id As Long = 100029
        For Each node As TreeNode In nodes
            If node.Checked Then
                If node.Text <> "Accounts" Then
                    Accounts(TotalAccounts) = node.Text
                    AccountsID(TotalAccounts) = id.ToString()
                    'MessageBox.Show(TotalAccounts.ToString() + ":  " + AccountsID(TotalAccounts) + ":  " + Accounts(TotalAccounts))
                    TotalAccounts += 1
                    id += 1
                End If
                Me.CopySelectedAccountNodes(node.Nodes)
            End If
        Next node
    End Sub

    Private Sub CheckAllChildNodes(ByVal treeNode As TreeNode, ByVal nodeChecked As Boolean)
        Dim node As TreeNode
        For Each node In treeNode.Nodes
            node.Checked = nodeChecked
            If node.Nodes.Count > 0 Then
                Me.CheckAllChildNodes(node, nodeChecked)
            End If
        Next node
    End Sub

    Friend Sub GoToTab(Optional ByVal Aantal As Integer = 1)
        ETabControlEx1.SelectedIndex = ETabControlEx1.SelectedIndex + Aantal
        CheckTabPageAndUpdateButtons()
    End Sub

    Friend Sub GoToTab(ByVal Tab As TabPage)
        ETabControlEx1.SelectedTab = Tab
        CheckTabPageAndUpdateButtons()
    End Sub

    Sub CheckTabPageAndUpdateButtons()
        If ETabControlEx1.SelectedIndex = 0 Then
            DisableBackButton()
        Else
            EnableBackButton()
        End If
        If ETabControlEx1.SelectedIndex = ETabControlEx1.TabCount - 1 Then
            SetNextButtonToFinish()
        Else
            SetNextButtonToNext()
        End If
    End Sub

    Sub DisableBackButton()
        btnback.Enabled = False
        btnback.Tag = "disabled"
        btnback.Image = Global.Umbrella.My.Resources.disabled_back
    End Sub

    Sub EnableBackButton()
        btnback.Enabled = True
        btnback.Tag = ""
        btnback.Image = Global.Umbrella.My.Resources.back
    End Sub

    Sub SetNextButtonToFinish()
        btnnext.Text = LanguageTexts_Finish
        btnnext.Tag = "finish"
    End Sub

    Sub SetNextButtonToNext()
        btnnext.Text = LanguageTexts_Next
        btnnext.Tag = ""
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmCreateInstitute_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim result As DialogResult = MessageBox.Show("Are you sure to cancel this institution setup wizard?", "Umbrella - Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim frm As New frmMainTask()
            frm.MdiParent = Me.MdiParent
            frm.Show()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub frmCreateInstitute_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TriStateTreeView1.ExpandAll()
        TriStateTreeView2.ExpandAll()

        Dim node1 As TreeNode
        For Each node1 In TriStateTreeView1.Nodes
            node1.Checked = True
            If node1.Nodes.Count > 0 Then
                Me.CheckAllChildNodes(node1, True)
            End If
        Next node1

        Dim node2 As TreeNode
        For Each node2 In TriStateTreeView2.Nodes
            node2.Checked = True
            If node2.Nodes.Count > 0 Then
                Me.CheckAllChildNodes(node2, True)
            End If
        Next node2

        ETabControlEx1.HideTabs = True
        Header.GroupTitle = ApplicationTitle

        btnnext.Text = LanguageTexts_Next
        btncancel.Text = LanguageTexts_Cancel
        btnback.Text = LanguageTexts_Back
        btnback.Enabled = False

        ControlsSetBounds()
        LoadCountry()
        LoadState()
        GetCode()

        Dim val As Integer = 0
        For i As Integer = 0 To 49
            dgviewcourse.Rows.Add()
            dgviewcourse.Rows(i).Cells(0).Value = (i + 1).ToString()
            dgviewcourse.Rows(i).Cells(0).Style.BackColor = System.Drawing.SystemColors.Control
            dgviewcourse.Rows(i).Cells(1).Value = ""
            dgviewcourse.Rows(i).Cells(2).Value = ""
            dgviewcourse.Rows(i).Cells(3).Value = ""
        Next
        dgviewcourse.ClearSelection()

        For i As Integer = 0 To 99
            dgviewachievements.Rows.Add()
            dgviewachievements.Rows(i).Cells(0).Value = (i + 1).ToString()
            dgviewachievements.Rows(i).Cells(0).Style.BackColor = System.Drawing.SystemColors.Control
            dgviewachievements.Rows(i).Cells(1).Value = ""
        Next
        dgviewachievements.ClearSelection()

        mnths = CInt(Date.Now.Month.ToString())
        If mnths = 1 Then
            cmbmonth.Text = "January"
        ElseIf mnths = 2 Then
            cmbmonth.Text = "February"
        ElseIf mnths = 3 Then
            cmbmonth.Text = "March"
        ElseIf mnths = 4 Then
            cmbmonth.Text = "April"
        ElseIf mnths = 5 Then
            cmbmonth.Text = "May"
        ElseIf mnths = 6 Then
            cmbmonth.Text = "June"
        ElseIf mnths = 7 Then
            cmbmonth.Text = "July"
        ElseIf mnths = 8 Then
            cmbmonth.Text = "August"
        ElseIf mnths = 9 Then
            cmbmonth.Text = "September"
        ElseIf mnths = 10 Then
            cmbmonth.Text = "October"
        ElseIf mnths = 11 Then
            cmbmonth.Text = "November"
        ElseIf mnths = 12 Then
            cmbmonth.Text = "December"
        Else
            cmbmonth.Text = "January"
        End If
        Dim yy As Integer = CInt(DateTime.Now.Year.ToString())
        Me.nudyear.Minimum = yy - 100
        Me.nudyear.Maximum = yy + 100
        Me.nudyear.Value = yy

        ETabControlEx1.SelectedIndex = 0
        Panel4.TabIndex = 0
        cmbcategory.Focus()
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btncancel_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btncancel.ClickButtonArea
        Me.Close()
    End Sub

    Private Sub btnnext_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnext.ClickButtonArea
        If btnnext.Tag = "finish" Then
            Create()
        Else
            GoToTab()
        End If
    End Sub

    Private Sub btnback_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnback.ClickButtonArea
        If btnback.Tag = "" Then
            GoToTab(-1)
        End If
    End Sub
#End Region
End Class
#End Region