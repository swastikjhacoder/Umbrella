#Region "Imports..."
Imports System.Data
Imports System.Data.SqlClient
Imports Umbrella.UIControls
Imports System.IO
Imports ESAR_Controls.UIControls.ComboBox
Imports ESAR_Controls.UIControls.TextBox
Imports System.Drawing.Imaging
#End Region
#Region "Class frmRetiredEmployee..."
Public Class frmRetiredEmployee
#Region "Declarations..."
    Private DGVDepartment As New Windows.Forms.DataGridView()
    Private DGVDesignation As New Windows.Forms.DataGridView()
    Private DGVPayscale As New Windows.Forms.DataGridView()
#End Region
#Region "Methods..."
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
        cmbdesignation.SetBounds(122, 192, 186, 21)
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
        cmbretirement.SetBounds(498, 34, 112, 21)
        txtfulladdress.SetBounds(122, 61, 488, 21)
        txtgrade.SetBounds(476, 88, 64, 21)
        txtpresentposition.SetBounds(122, 34, 224, 21)
        txtbasic.SetBounds(546, 88, 64, 21)

        Label40.SetBounds(13, 14, 263, 13)
        Label41.SetBounds(13, 40, 228, 13)
        Label42.SetBounds(359, 40, 400, 13)
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
            cmd.CommandText = "select * from RetiredEmployee where empid='" & EmpRegNo & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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
                Else
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
            cmd.CommandText = "select * from RetiredEmployeeLanguage where empid='" & EmpRegNo & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
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
            cmd.CommandText = "select * from RetiredEmployeeAcademic where empid='" & EmpRegNo & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
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
            cmd.CommandText = "select * from RetiredEmployeeTeachingExp where empid='" & EmpRegNo & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
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
            cmd.CommandText = "select * from RetiredEmployeeResearchExp where empid='" & EmpRegNo & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
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
            cmd.CommandText = "select * from RetiredEmployeeProficiency where empid='" & EmpRegNo & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
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
            cmd.CommandText = "select * from RetiredEmployeeProgrammingLang where empid='" & EmpRegNo & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
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
            cmd.CommandText = "select * from RetiredEmployeeActivity where empid='" & EmpRegNo & "' and InsID='" & My.Settings.LastOpenedInstituteID & "'"
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

    Private Sub txtpresentposition_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpresentposition.KeyDown
        If (e.KeyCode) = Keys.Enter Or (e.KeyCode) = Keys.Down Then
            cmbretirement.Focus()
        ElseIf (e.KeyCode) = Keys.Up Then
            cmbph.Focus()
        End If
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
            ETabControl1.SelectTab(TabPage3)
        End If
    End Sub

    Private Sub cmbqualifiedtest_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbqualifiedtest.SelectedIndexChanged
        If cmbqualifiedtest.Text = "Yes" Then
            Label42.Visible = True
        Else
            Label42.Visible = False
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
#End Region
#Region "Form Events..."
    Private Sub frmRetiredEmployee_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlSetBound()
        LoadSelectedEmployee()
        LoadSelectedEmployeeProgrammingLang()
        LoadSelectedEmployeeAcademic()
        LoadSelectedEmployeeTeachingExp()
        LoadSelectedEmployeeResearchExp()
        LoadSelectedEmployeeLanguage()
        LoadSelectedEmployeeProciency()
        LoadSelectedEmployeeActivity()
        txtregistrationno.Focus()
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnmove_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnmove.ClickButtonArea

    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        ControlSetBound()
        LoadSelectedEmployee()
        LoadSelectedEmployeeProgrammingLang()
        LoadSelectedEmployeeAcademic()
        LoadSelectedEmployeeTeachingExp()
        LoadSelectedEmployeeResearchExp()
        LoadSelectedEmployeeLanguage()
        LoadSelectedEmployeeProciency()
        LoadSelectedEmployeeActivity()
        txtregistrationno.Focus()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region