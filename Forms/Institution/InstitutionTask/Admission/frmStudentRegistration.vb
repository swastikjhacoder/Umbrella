#Region "Imports..."
Imports ESAR_Controls.UIControls.ComboBox
#End Region
#Region "Class frmStudentRegistration..."
Public Class frmStudentRegistration
#Region "Declarations..."
    Private ACODE As String = ""
    Private TT As String = ""
    Private DGVRegNo As New DataGridView()
    Private rollexist As Boolean = False
    Private stuidexist As Boolean = False
    Private admissionexist As Boolean = False
    Private CourseName As String = ""
    Private ClassName As String = ""
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
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        ACODE = Indx.LoadStudentRegID()
        Dim var As String
        var = CodeIncrement(ACODE)
        Me.txtregno.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("STU:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        Label1.SetBounds(12, 80, 88, 13)
        Label10.SetBounds(207, 22, 34, 13)
        Label11.SetBounds(15, 83, 280, 26)
        Label12.SetBounds(218, 42, 77, 13)
        Label13.SetBounds(12, 201, 135, 13)
        Label2.SetBounds(12, 160, 43, 13)
        Label3.SetBounds(175, 160, 53, 13)
        Label4.SetBounds(12, 187, 33, 13)
        Label5.SetBounds(114, 187, 40, 13)
        Label6.SetBounds(234, 187, 49, 13)
        Label7.SetBounds(12, 88, 380, 13)
        Label8.SetBounds(12, 42, 98, 13)
        Label9.SetBounds(22, 22, 38, 13)

        cmbregno.SetBounds(116, 77, 143, 21)
        cmbtime.SetBounds(154, 184, 74, 21)
        cmbtuition.SetBounds(293, 184, 109, 21)

        txtclass.SetBounds(61, 157, 97, 21)
        txtcourse.SetBounds(234, 157, 168, 21)
        txtemergencyaddress.SetBounds(141, 167, 261, 52)
        txtemergencyfax.SetBounds(268, 140, 134, 21)
        txtemergencyhomephone.SetBounds(15, 140, 120, 21)
        txtemergencyname.SetBounds(15, 113, 387, 21)
        txtemergencyrelationship.SetBounds(15, 167, 120, 21)
        txtemergencyworkphone.SetBounds(141, 140, 121, 21)
        txtfax.SetBounds(268, 57, 134, 21)
        txtfgname.SetBounds(15, 30, 387, 21)
        txtfirstname.SetBounds(15, 130, 143, 21)
        txthomephone.SetBounds(15, 57, 120, 21)
        txtlastname.SetBounds(234, 130, 168, 21)
        txtmiddlename.SetBounds(164, 130, 64, 21)
        txtregno.SetBounds(116, 39, 143, 21)
        txtrollno.SetBounds(61, 184, 47, 21)
        txtworkphone.SetBounds(141, 57, 121, 21)

        ProfilePic1.SetBounds(308, 29, 78, 95)

        txtdob.SetBounds(66, 19, 100, 21)
        txtsex.SetBounds(247, 19, 100, 21)
        txtpreaddress.SetBounds(99, 31, 248, 21)
        txtprecity.SetBounds(25, 58, 141, 21)
        txtprecountry.SetBounds(99, 112, 248, 21)
        txtpredist.SetBounds(25, 85, 141, 21)
        txtprehouseno.SetBounds(25, 31, 68, 21)
        txtprepin.SetBounds(25, 112, 68, 21)
        txtprepost.SetBounds(172, 58, 175, 21)
        txtprestate.SetBounds(172, 85, 175, 21)
        txtperaddress.SetBounds(99, 31, 248, 21)
        txtpercity.SetBounds(25, 58, 141, 21)
        txtpercountry.SetBounds(99, 112, 248, 21)
        txtperdist.SetBounds(25, 85, 141, 21)
        txtperhouseno.SetBounds(25, 31, 68, 21)
        txtperpin.SetBounds(25, 112, 68, 21)
        txtperpost.SetBounds(172, 58, 175, 21)
        txtperstate.SetBounds(172, 85, 175, 21)
        txtprofcourse.SetBounds(9, 29, 352, 21)
        txtprofcourseduration.SetBounds(9, 56, 286, 21)
        txtprofcourseyear.SetBounds(301, 56, 60, 21)
        txtcompetitivexm.SetBounds(301, 83, 60, 21)
        txtinstitute.SetBounds(9, 39, 203, 21)
        txtrecognized.SetBounds(302, 39, 60, 21)
        txtinstituteaddress.SetBounds(9, 66, 353, 21)
        txtinstitutefax.SetBounds(115, 93, 100, 21)
        txtinstitutephone.SetBounds(9, 93, 100, 21)
        txtinstituteuniv.SetBounds(221, 93, 141, 21)
        txtpayeename.SetBounds(13, 37, 344, 21)
        txtbankname.SetBounds(13, 64, 344, 21)
        txtbankbranch.SetBounds(13, 91, 344, 21)
        txtbranchaddress.SetBounds(13, 118, 344, 21)
        txtbranchcode.SetBounds(13, 143, 344, 21)
        txtaccountno.SetBounds(13, 171, 344, 21)
        txtaccounttype.SetBounds(153, 198, 100, 21)
        txtmicrcode.SetBounds(13, 225, 344, 21)
        txtelectransfer.SetBounds(13, 250, 344, 21)
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
            cmd.CommandText = "select serial,name from StudentAdmision where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and approved='" & approved & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVRegNo.Rows.Add()
                DGVRegNo.Rows(indx).Cells(0).Value = dr("serial").ToString()
                DGVRegNo.Rows(indx).Cells(1).Value = dr("name").ToString()

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
            cmbregno.Text = StuID
            LoadSelectedAdmission(StuID, StuName)
            LoadSelectedAdmission(StuID)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetForm()
        updatestudentreg = False
        If ISDAutoID = "Yes" Then
            GetCode()
        Else
            txtregno.Text = ""
        End If
        ProfilePic1.Image = Global.Umbrella.My.Resources.people
        txtclass.Text = ""
        txtcourse.Text = ""
        cmbregno.Text = ""
        cmbtime.Text = ""
        cmbtuition.Text = ""
        txtemergencyaddress.Text = ""
        txtemergencyfax.Text = ""
        txtemergencyhomephone.Text = ""
        txtemergencyname.Text = ""
        txtemergencyrelationship.Text = ""
        txtemergencyworkphone.Text = ""
        txtfax.Text = ""
        txtfgname.Text = ""
        txtfirstname.Text = ""
        txthomephone.Text = ""
        txtlastname.Text = ""
        txtmiddlename.Text = ""
        txtrollno.Text = ""
        txtworkphone.Text = ""
    End Sub

    Private Sub CheckRoll()
        Try
            cmd.CommandText = "select * from StudentRegistration where roll='" & txtrollno.Text & "' and course='" & CourseName & "' and class='" & ClassName & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                rollexist = True
            Else
                rollexist = False
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CheckAdmission()
        Try
            cmd.CommandText = "select * from StudentRegistration where serial='" & cmbregno.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                admissionexist = True
            Else
                admissionexist = False
            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckStuID()
        Try
            cmd.CommandText = "select * from StudentRegistration where stuid='" & txtregno.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                stuidexist = True
            Else
                stuidexist = False
            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddRecord()
        Try
            CheckAdmission()
            If admissionexist = False Then
                CheckRoll()
                If rollexist = False Then
                    CheckStuID()
                    If stuidexist = False Then
                        If txtregno.Text = "" Then
                            Dim result As DialogResult = MessageBox.Show("Please enter registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result = Windows.Forms.DialogResult.OK Then
                                txtregno.Focus()
                            End If
                        ElseIf cmbregno.Text = "" Then
                            Dim result As DialogResult = MessageBox.Show("Please enter admission serial no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result = Windows.Forms.DialogResult.OK Then
                                cmbregno.Focus()
                            End If
                        ElseIf txtrollno.Text = "" Then
                            Dim result As DialogResult = MessageBox.Show("Please enter roll no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result = Windows.Forms.DialogResult.OK Then
                                txtrollno.Focus()
                            End If
                        ElseIf txtfirstname.Text = "" Then
                            Dim result As DialogResult = MessageBox.Show("Please enter name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result = Windows.Forms.DialogResult.OK Then
                                txtfirstname.Focus()
                            End If
                        ElseIf txtfgname.Text = "" Then
                            Dim result As DialogResult = MessageBox.Show("Please enter father's/ guardian's no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result = Windows.Forms.DialogResult.OK Then
                                txtfgname.Focus()
                            End If
                        ElseIf txtemergencyname.Text = "" Then
                            Dim result As DialogResult = MessageBox.Show("Please enter emergency contact name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            If result = Windows.Forms.DialogResult.OK Then
                                txtemergencyname.Focus()
                            End If
                        Else
                            Dim result As DialogResult = MessageBox.Show("Accept all these!!!.", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            If result = Windows.Forms.DialogResult.Yes Then
                                Dim cls As New cStudentRegistration()
                                cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbregno.Text, txtregno.Text, txtrollno.Text, cmbtime.Text, cmbtuition.Text, txtemergencyname.Text, txtemergencyhomephone.Text, txtemergencyworkphone.Text, txtemergencyfax.Text, txtemergencyrelationship.Text, txtemergencyaddress.Text)
                                If cls.AddOk = True Then
                                    Dim rs As DialogResult = MessageBox.Show("Record added successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    If rs = Windows.Forms.DialogResult.OK Then
                                        cmbregno.Focus()
                                    End If
                                End If
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("This record is already exist." + Environment.NewLine + "Please search another student id...", "Umbrella - Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            txtregno.Focus()
                        End If
                    End If
                Else
                    Dim result1 As DialogResult = MessageBox.Show("This record is already exist." + Environment.NewLine + "Please search another roll no...", "Umbrella - Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If result1 = Windows.Forms.DialogResult.OK Then
                        txtrollno.Focus()
                    End If
                End If
            Else
                Dim result1 As DialogResult = MessageBox.Show("This record is already exist." + Environment.NewLine + "Please search another admission id...", "Umbrella - Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If result1 = Windows.Forms.DialogResult.OK Then
                    cmbregno.Focus()
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
            ElseIf cmbregno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter admission serial no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbregno.Focus()
                End If
            ElseIf txtrollno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter roll no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtrollno.Focus()
                End If
            ElseIf txtfirstname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtfirstname.Focus()
                End If
            ElseIf txtfgname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter father's/ guardian's no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtfgname.Focus()
                End If
            ElseIf txtemergencyname.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter emergency contact name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtemergencyname.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!.", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cStudentRegistration()
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, cmbregno.Text, txtregno.Text, txtrollno.Text, cmbtime.Text, cmbtuition.Text, txtemergencyname.Text, txtemergencyhomephone.Text, txtemergencyworkphone.Text, txtemergencyfax.Text, txtemergencyrelationship.Text, txtemergencyaddress.Text)
                    If cls.UpdateOk = True Then
                        Dim rs As DialogResult = MessageBox.Show("Record updated successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If rs = Windows.Forms.DialogResult.OK Then
                            cmbregno.Focus()
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
            ElseIf cmbregno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter admission serial no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbregno.Focus()
                End If
            ElseIf txtrollno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter roll no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtrollno.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?.", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cStudentRegistration()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtregno.Text, cmbregno.Text, CInt(txtrollno.Text))
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

    Private Sub LoadSelectedRegistration()
        Try
            cmd.CommandText = "select serial,stuid,fname,mname,lname,course,classint,class,picture,roll,time,tuition,fgname,homephone,workphone,fax,emergencyname,emergencyhomeph,emergencyworkph,emergencyfax,emergencyrelation,emergencyaddress from StudentRegistration where stuid='" & StuID & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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
                txtclass.Text = dr("class").ToString()
                txtcourse.Text = dr("course").ToString()
                cmbregno.Text = dr("serial").ToString()
                cmbtime.Text = dr("time").ToString()
                cmbtuition.Text = dr("tuition").ToString()
                txtemergencyaddress.Text = dr("emergencyaddress").ToString()
                txtemergencyfax.Text = dr("emergencyfax").ToString()
                txtemergencyhomephone.Text = dr("emergencyhomeph").ToString()
                txtemergencyname.Text = dr("emergencyname").ToString()
                txtemergencyrelationship.Text = dr("emergencyrelation").ToString()
                txtemergencyworkphone.Text = dr("emergencyworkph").ToString()
                txtfax.Text = dr("fax").ToString()
                txtfgname.Text = dr("fgname").ToString()
                txtfirstname.Text = dr("fname").ToString()
                txthomephone.Text = dr("homephone").ToString()
                txtlastname.Text = dr("lname").ToString()
                txtmiddlename.Text = dr("mname").ToString()
                txtregno.Text = dr("stuid").ToString()
                txtrollno.Text = dr("roll").ToString()
                txtworkphone.Text = dr("workphone").ToString()
            End If
            dr.Close()
            LoadSelectedAdmission(cmbregno.Text)
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadSelectedPicture(ByVal stid As String, ByVal stnm As String)
        Try
            cmd.CommandText = "select picture from StudentRegistration where stuid='" & txtregno.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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

    Private Sub LoadSelectedAdmission(ByVal stid As String, ByVal stnm As String)
        Try
            cmd.CommandText = "select picture,fax,fgname,fname,homephone,lname,mname,workphone,class,class,course from StudentAdmision where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and serial='" & stid & "' and name='" & stnm & "'"
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
                txtfax.Text = dr("fax").ToString()
                txtfgname.Text = dr("fgname").ToString()
                txtfirstname.Text = dr("fname").ToString()
                txthomephone.Text = dr("homephone").ToString()
                txtlastname.Text = dr("lname").ToString()
                txtmiddlename.Text = dr("mname").ToString()
                txtworkphone.Text = dr("workphone").ToString()
                txtclass.Text = dr("class").ToString()
                txtcourse.Text = dr("course").ToString()
                CourseName = dr("course").ToString()
                ClassName = dr("class").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadSelectedAdmission(ByVal regno As String)
        Try
            cmd.CommandText = "select * from StudentAdmision where serial='" & regno & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            txtdob.Text = dr("dob").ToString()
            txtsex.Text = dr("sex").ToString()
            txtpreaddress.Text = dr("preaddress").ToString()
            txtprecity.Text = dr("precity").ToString()
            txtprecountry.Text = dr("precountry").ToString()
            txtpredist.Text = dr("predist").ToString()
            txtprehouseno.Text = dr("prehouseno").ToString()
            txtprepin.Text = dr("prepin").ToString()
            txtprepost.Text = dr("prepost").ToString()
            txtprestate.Text = dr("prestate").ToString()
            txtperaddress.Text = dr("peraddress").ToString()
            txtpercity.Text = dr("percity").ToString()
            txtpercountry.Text = dr("percountry").ToString()
            txtperdist.Text = dr("perdist").ToString()
            txtperhouseno.Text = dr("perhouseno").ToString()
            txtperpin.Text = dr("perpin").ToString()
            txtperpost.Text = dr("perpost").ToString()
            txtperstate.Text = dr("perstate").ToString()
            txtprofcourse.Text = dr("profcourse").ToString()
            txtprofcourseduration.Text = dr("profcourseduration").ToString()
            txtprofcourseyear.Text = dr("profcourseyear").ToString()
            txtcompetitivexm.Text = dr("competitiveexam").ToString()
            txtinstitute.Text = dr("institute").ToString()
            txtrecognized.Text = dr("recognized").ToString()
            txtinstituteaddress.Text = dr("instituteaddress").ToString()
            txtinstitutefax.Text = dr("institutefax").ToString()
            txtinstitutephone.Text = dr("institutephone").ToString()
            txtinstituteuniv.Text = dr("instituteuniv").ToString()
            txtpayeename.Text = dr("payeename").ToString()
            txtbankname.Text = dr("bankname").ToString()
            txtbankbranch.Text = dr("bankbrach").ToString()
            txtbranchaddress.Text = dr("branchaddress").ToString()
            txtbranchcode.Text = dr("branchcode").ToString()
            txtaccountno.Text = dr("accountno").ToString()
            txtaccounttype.Text = dr("accounttype").ToString()
            txtmicrcode.Text = dr("micrcode").ToString()
            txtelectransfer.Text = dr("electronictransfer").ToString()
            dr.Close()
            LoadAdmissionExam(regno)
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadAdmissionExam(ByVal regno As String)
        Try
            dgviewxm.Rows.Clear()
            Dim i As Integer = 0
            cmd.CommandText = "select * from StudentAdmisionExam where stuid='" & regno & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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
#End Region
#Region "Form Events..."
    Private Sub frmStudentRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If updatestudentreg = False Then
            ControlSetBound()
            LoadRegNo()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadRegNo()
            LoadSelectedRegistration()
        End If
        If USregistration = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbregno.Enabled = False
            cmbtime.Enabled = False
            cmbtuition.Enabled = False
            txtclass.ReadOnly = True
            txtcourse.ReadOnly = True
            txtemergencyaddress.ReadOnly = True
            txtemergencyhomephone.ReadOnly = True
            txtemergencyfax.ReadOnly = True
            txtemergencyhomephone.ReadOnly = True
            txtemergencyname.ReadOnly = True
            txtemergencyrelationship.ReadOnly = True
            txtemergencyworkphone.ReadOnly = True
            txtregno.ReadOnly = True
            txtrollno.ReadOnly = True
            ProfilePic1.Enabled = False
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatestudentreg = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatestudentreg = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatestudentreg = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updatestudentreg = False Then
            ControlSetBound()
            LoadRegNo()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadRegNo()
            LoadSelectedRegistration()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Attributes..."
    Private Sub TextBoxKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 32 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxTextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim x As ESAR_Controls.UIControls.TextBox.eTextBox = CType(sender, ESAR_Controls.UIControls.TextBox.eTextBox)
        ctc.ConvertTextBoxValidValue(x)
    End Sub

    Private Sub ComboBoxKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbregno.KeyPress, cmbtime.KeyPress, cmbtuition.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtregno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtregno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbregno.Focus()
        End If
    End Sub

    Private Sub cmbregno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbregno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtfirstname.Focus()
        End If
    End Sub

    Private Sub txtfirstname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfirstname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtmiddlename.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbregno.Focus()
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
            txtclass.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtmiddlename.Focus()
        End If
    End Sub

    Private Sub txtclass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtclass.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtcourse.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtlastname.Focus()
        End If
    End Sub

    Private Sub txtcourse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcourse.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtrollno.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtclass.Focus()
        End If
    End Sub

    Private Sub txtrollno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtrollno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbtime.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcourse.Focus()
        End If
    End Sub

    Private Sub cmbtime_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbtime.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbtuition.Focus()
        End If
    End Sub

    Private Sub cmbtuition_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbtuition.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtfgname.Focus()
        End If
    End Sub

    Private Sub txtfgname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfgname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txthomephone.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbtuition.Focus()
        End If
    End Sub

    Private Sub txthomephone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txthomephone.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtworkphone.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtfgname.Focus()
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
            txtemergencyname.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtworkphone.Focus()
        End If
    End Sub

    Private Sub txtemergencyname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtemergencyname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtemergencyhomephone.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtfax.Focus()
        End If
    End Sub

    Private Sub txtemergencyhomephone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtemergencyhomephone.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtemergencyworkphone.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtemergencyname.Focus()
        End If
    End Sub

    Private Sub txtemergencyworkphone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtemergencyworkphone.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtemergencyfax.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtemergencyhomephone.Focus()
        End If
    End Sub

    Private Sub txtemergencyfax_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtemergencyfax.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtemergencyrelationship.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtemergencyworkphone.Focus()
        End If
    End Sub

    Private Sub txtemergencyrelationship_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtemergencyrelationship.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtemergencyaddress.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtemergencyfax.Focus()
        End If
    End Sub

    Private Sub txtemergencyaddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtemergencyaddress.KeyDown
        If e.KeyCode = Keys.Up Then
            txtemergencyrelationship.Focus()
        End If
    End Sub

    Private Sub txtdob_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdob.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtsex.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            ETabControl1.SelectTab(TabPage3)
            txtelectransfer.Focus()
        End If
    End Sub

    Private Sub txtsex_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsex.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtprehouseno.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtdob.Focus()
        End If
    End Sub

    Private Sub txtprehouseno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtprehouseno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtpreaddress.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtsex.Focus()
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
            txtcompetitivexm.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtprofcourseduration.Focus()
        End If
    End Sub

    Private Sub txtcompetitivexm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcompetitivexm.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtinstitute.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtprofcourseyear.Focus()
        End If
    End Sub

    Private Sub txtinstitute_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtinstitute.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtrecognized.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcompetitivexm.Focus()
        End If
    End Sub

    Private Sub txtrecognized_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtrecognized.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtinstituteaddress.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtinstitute.Focus()
        End If
    End Sub

    Private Sub txtinstituteaddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtinstituteaddress.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtinstitutephone.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtrecognized.Focus()
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
            txtaccounttype.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtbranchcode.Focus()
        End If
    End Sub

    Private Sub txtaccounttype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtaccounttype.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtmicrcode.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtaccountno.Focus()
        End If
    End Sub

    Private Sub txtmicrcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmicrcode.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtelectransfer.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtaccounttype.Focus()
        End If
    End Sub

    Private Sub txtelectransfer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtelectransfer.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            ETabControl1.SelectTab(TabPage1)
            txtdob.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtmicrcode.Focus()
        End If
    End Sub
#End Region
End Class
#End Region
