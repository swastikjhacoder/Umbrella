#Region "Import"
Imports ESAR_Controls.UIControls.ComboBox
#End Region
#Region "Class frmSubmitIDCard"
Public Class frmSubmitIDCard
#Region "Declaration"
    Private IDCODE As String = ""
    Private TT As String = ""
    Private DGViewRecord As New DataGridView()
    Private IDCardExist As Boolean = False
#End Region
#Region "Methods"
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        IDCODE = Indx.LoadIDSerial()
        Dim var As String
        var = CodeIncrement(IDCODE)
        Me.txtserial.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("ID:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        SplitContainer1.SplitterDistance = 486
        SplitContainer1.SplitterWidth = 5
        SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(0, 10, 10, 0)
        SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(10, 10, 10, 0)
        btnprint.SetBounds(74, 272, 174, 25)
        Label1.SetBounds(21, 26, 68, 13)
        Label2.SetBounds(11, 38, 142, 13)
        Label3.SetBounds(278, 26, 80, 13)
        Label4.SetBounds(520, 26, 123, 13)
        Label5.SetBounds(12, 75, 45, 13)
        Label6.SetBounds(11, 102, 38, 13)
        Label7.SetBounds(205, 102, 34, 13)
        lblcoursedesig.SetBounds(11, 129, 53, 13)
        Label9.SetBounds(12, 160, 58, 13)
        txtaddress.SetBounds(76, 157, 369, 84)
        txtcoursedesig.SetBounds(76, 126, 369, 21)
        txtname.SetBounds(76, 72, 369, 21)
        txtserial.SetBounds(95, 23, 156, 21)
        txtsex.SetBounds(245, 99, 200, 21)
        cmbidfor.SetBounds(364, 23, 121, 22)
        cmbdate.SetBounds(649, 23, 145, 21)
        txtdob.SetBounds(76, 99, 123, 21)
        cmbreg.SetBounds(159, 35, 145, 21)
        btngo.SetBounds(309, 35, 21, 21)
        lbladdress.SetBounds(10, 189, 283, 70)
        lblcourse.SetBounds(10, 157, 283, 13)
        lbldob.SetBounds(10, 132, 107, 13)
        lblname.SetBounds(10, 10, 283, 21)
        lblregno.SetBounds(32, 41, 173, 13)
        lblsex.SetBounds(133, 132, 108, 13)
        PictureBox1.SetBounds(200, 38, 69, 82)
    End Sub

    Private Sub LoadStudent()
        Try
            cmd.CommandText = "select stuid,name,dob,sex,course,prehouseno,preaddress,precity,prepost,predist,prestate,prepin,precountry from StudentRegistration where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and stuid='" & StuID & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                cmbreg.Text = dr("stuid").ToString()
                txtname.Text = dr("name").ToString()
                txtdob.Text = dr("dob").ToString()
                txtsex.Text = dr("sex").ToString()
                txtcoursedesig.Text = dr("course").ToString()
                txtaddress.Text = dr("prehouseno").ToString() + ", " + dr("preaddress").ToString() + ", " + dr("precity").ToString() + ", " + dr("prepost").ToString() + ", " + dr("predist").ToString() + ", " + dr("prestate").ToString() + ", " + dr("prepin").ToString() + ", " + dr("precountry").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadEmployee()
        Try
            cmd.CommandText = "select empid,name,dob,sex,designation,fulladdress from Employee where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and empid='" & EmpRegNo & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                cmbreg.Text = dr("empid").ToString()
                txtname.Text = dr("name").ToString()
                txtdob.Text = dr("dob").ToString()
                txtsex.Text = dr("sex").ToString()
                txtcoursedesig.Text = dr("designation").ToString()
                txtaddress.Text = dr("fulladdress").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadRegistration()
        Try
            If DGViewRecord.Columns.Count > 0 Then
                DGViewRecord.Rows.Clear()
                DGViewRecord.Columns.Clear()
            End If

            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .HeaderText = "Registration No."
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .HeaderText = "Name"
            End With

            With DGViewRecord
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
                AddHandler DGViewRecord.CellClick, AddressOf DGViewRecord_CellClick
            End With

            DGViewRecord.Columns.Clear()
            DGViewRecord.Columns.Add(col1)
            DGViewRecord.Columns.Add(col2)

            DGViewRecord.Rows.Clear()

            If cmbidfor.Text = "Student" Then
                Dim indx As Integer = 0
                cmd.CommandText = "select stuid,name from StudentRegistration where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    DGViewRecord.Rows.Add()
                    DGViewRecord.Rows(indx).Cells(0).Value = dr("stuid").ToString()
                    DGViewRecord.Rows(indx).Cells(1).Value = dr("name").ToString()
                    indx = indx + 1
                End While
                dr.Close()
            ElseIf cmbidfor.Text = "Employee" Then
                Dim indx As Integer = 0
                cmd.CommandText = "select empid,name from Employee where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    DGViewRecord.Rows.Add()
                    DGViewRecord.Rows(indx).Cells(0).Value = dr("empid").ToString()
                    DGViewRecord.Rows(indx).Cells(1).Value = dr("name").ToString()
                    indx = indx + 1
                End While
                dr.Close()
            End If
            DGViewRecord.ClearSelection()

            cmbreg.AddDataGridView(DGViewRecord, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGViewRecord_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            If cmbidfor.Text = "Student" Then
                Dim k As Integer = DGViewRecord.CurrentRow.Index
                DGViewRecord.Rows(k).Selected = True
                DGViewRecord.CurrentCell = DGViewRecord.Rows(k).Cells(0)
                StuID = DGViewRecord.Rows(k).Cells(0).Value.ToString()
                StuName = DGViewRecord.Rows(k).Cells(1).Value.ToString()
                DGViewRecord.Text = StuID
                LoadStudent()
                DrawIDCard()
            ElseIf cmbidfor.Text = "Employee" Then
                Dim k As Integer = DGViewRecord.CurrentRow.Index
                DGViewRecord.Rows(k).Selected = True
                DGViewRecord.CurrentCell = DGViewRecord.Rows(k).Cells(0)
                EmpRegNo = DGViewRecord.Rows(k).Cells(0).Value.ToString()
                EmpName = DGViewRecord.Rows(k).Cells(1).Value.ToString()
                DGViewRecord.Text = EmpRegNo
                LoadEmployee()
                DrawIDCard()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetForm()
        updateidcard = False
        If ISDAutoID = "Yes" Then
            GetCode()
        Else
            txtserial.Text = ""
        End If
        cmbdate.Text = UmbrellaSystemDate
        cmbidfor.Text = ""
        cmbreg.Text = ""
        txtaddress.Text = ""
        txtcoursedesig.Text = ""
        txtdob.Text = ""
        txtname.Text = ""
        txtsex.Text = ""
        lbladdress.Text = ""
        lblcourse.Text = ""
        lbldob.Text = ""
        lblname.Text = ""
        lblregno.Text = ""
        lblsex.Text = ""
        PictureBox1.Image = Global.Umbrella.My.Resources.people
        ERoundedPanel1.Visible = False
        cmbidfor.Focus()
    End Sub

    Private Sub AddRecord()
        If txtserial.Text = "" Then
            Dim result = MessageBox.Show("Please enter serial no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                txtserial.Focus()
            End If
        ElseIf cmbidfor.Text = "" Then
            Dim result = MessageBox.Show("Please enter generate id card for.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                cmbidfor.Focus()
            End If
        ElseIf cmbdate.Text = "" Then
            Dim result = MessageBox.Show("Please enter date of generate id card.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                cmbdate.Focus()
            End If
        ElseIf cmbreg.Text = "" Then
            Dim result = MessageBox.Show("Please enter registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                cmbreg.Focus()
            End If
        ElseIf txtname.Text = "" Then
            Dim result = MessageBox.Show("Please enter name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                txtname.Focus()
            End If
        ElseIf txtdob.Text = "" Then
            Dim result = MessageBox.Show("Please enter date of birth.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                txtdob.Focus()
            End If
        ElseIf txtsex.Text = "" Then
            Dim result = MessageBox.Show("Please enter sex.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                txtsex.Focus()
            End If
        ElseIf txtcoursedesig.Text = "" Then
            If cmbidfor.Text = "Student" Then
                Dim result = MessageBox.Show("Please enter course.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtcoursedesig.Focus()
                End If
            ElseIf cmbidfor.Text = "Employee" Then
                Dim result = MessageBox.Show("Please enter designation.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtcoursedesig.Focus()
                End If
            End If
        ElseIf txtaddress.Text = "" Then
            Dim result = MessageBox.Show("Please enter address.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                txtaddress.Focus()
            End If
        Else
            Dim result = MessageBox.Show("Accept all these!!!.", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                CheckIDCard()
                If IDCardExist = False Then
                    Dim cls As New cIDCard()
                    cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtserial.Text, cmbidfor.Text, cmbdate.Text, cmbreg.Text, txtname.Text, txtdob.Text, txtsex.Text, txtcoursedesig.Text, txtaddress.Text)
                    If cls.AddOk = True Then
                        Dim result1 = MessageBox.Show("Record added successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            GetCode()
                            cmbidfor.Focus()
                        End If
                    End If
                Else
                    Dim result1 = MessageBox.Show("Serial no already exist." + Environment.NewLine + "Please enter a new serial no.", "Umbrella - Duplicate Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    If result1 = Windows.Forms.DialogResult.OK Then
                        txtserial.Focus()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub UpdateRecord()
        If txtserial.Text = "" Then
            Dim result = MessageBox.Show("Please enter serial no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                txtserial.Focus()
            End If
        ElseIf cmbidfor.Text = "" Then
            Dim result = MessageBox.Show("Please enter generate id card for.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                cmbidfor.Focus()
            End If
        ElseIf cmbdate.Text = "" Then
            Dim result = MessageBox.Show("Please enter date of generate id card.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                cmbdate.Focus()
            End If
        ElseIf cmbreg.Text = "" Then
            Dim result = MessageBox.Show("Please enter registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                cmbreg.Focus()
            End If
        ElseIf txtname.Text = "" Then
            Dim result = MessageBox.Show("Please enter name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                txtname.Focus()
            End If
        ElseIf txtdob.Text = "" Then
            Dim result = MessageBox.Show("Please enter date of birth.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                txtdob.Focus()
            End If
        ElseIf txtsex.Text = "" Then
            Dim result = MessageBox.Show("Please enter sex.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                txtsex.Focus()
            End If
        ElseIf txtcoursedesig.Text = "" Then
            If cmbidfor.Text = "Student" Then
                Dim result = MessageBox.Show("Please enter course.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtcoursedesig.Focus()
                End If
            ElseIf cmbidfor.Text = "Employee" Then
                Dim result = MessageBox.Show("Please enter designation.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtcoursedesig.Focus()
                End If
            End If
        ElseIf txtaddress.Text = "" Then
            Dim result = MessageBox.Show("Please enter address.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                txtaddress.Focus()
            End If
        Else
            Dim result = MessageBox.Show("Accept all these!!!.", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                Dim cls As New cIDCard()
                cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtserial.Text, cmbidfor.Text, cmbdate.Text, cmbreg.Text, txtname.Text, txtdob.Text, txtsex.Text, txtcoursedesig.Text, txtaddress.Text)
                If cls.UpdateOk = True Then
                    Dim result1 = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If result1 = Windows.Forms.DialogResult.OK Then
                        cmbidfor.Focus()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub DeleteRecord()
        If txtserial.Text = "" Then
            Dim result = MessageBox.Show("Please enter serial no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                txtserial.Focus()
            End If
        ElseIf cmbidfor.Text = "" Then
            Dim result = MessageBox.Show("Please enter generate id card for.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                cmbidfor.Focus()
            End If
        ElseIf cmbdate.Text = "" Then
            Dim result = MessageBox.Show("Please enter date of generate id card.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                cmbdate.Focus()
            End If
        ElseIf cmbreg.Text = "" Then
            Dim result = MessageBox.Show("Please enter registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                cmbreg.Focus()
            End If
        ElseIf txtname.Text = "" Then
            Dim result = MessageBox.Show("Please enter name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                txtname.Focus()
            End If
        ElseIf txtdob.Text = "" Then
            Dim result = MessageBox.Show("Please enter date of birth.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                txtdob.Focus()
            End If
        ElseIf txtsex.Text = "" Then
            Dim result = MessageBox.Show("Please enter sex.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                txtsex.Focus()
            End If
        ElseIf txtcoursedesig.Text = "" Then
            If cmbidfor.Text = "Student" Then
                Dim result = MessageBox.Show("Please enter course.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtcoursedesig.Focus()
                End If
            ElseIf cmbidfor.Text = "Employee" Then
                Dim result = MessageBox.Show("Please enter designation.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtcoursedesig.Focus()
                End If
            End If
        ElseIf txtaddress.Text = "" Then
            Dim result = MessageBox.Show("Please enter address.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.OK Then
                txtaddress.Focus()
            End If
        Else
            Dim result = MessageBox.Show("Are you sure want to delete this record?.", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                Dim cls As New cIDCard()
                cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtserial.Text)
                If cls.DeleteOk = True Then
                    Dim result1 = MessageBox.Show("Record deleted successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If result1 = Windows.Forms.DialogResult.OK Then
                        ResetForm()
                    End If
                End If
            End If
        End If
    End Sub

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

    Private Sub DrawIDCard()
        Try
            If txtserial.Text = "" Then
                Dim result = MessageBox.Show("Please enter serial no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtserial.Focus()
                End If
            ElseIf cmbidfor.Text = "" Then
                Dim result = MessageBox.Show("Please enter generate id card for.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbidfor.Focus()
                End If
            ElseIf cmbdate.Text = "" Then
                Dim result = MessageBox.Show("Please enter date of generate id card.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbdate.Focus()
                End If
            ElseIf cmbreg.Text = "" Then
                Dim result = MessageBox.Show("Please enter registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbreg.Focus()
                End If
            ElseIf txtname.Text = "" Then
                Dim result = MessageBox.Show("Please enter name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtname.Focus()
                End If
            ElseIf txtdob.Text = "" Then
                Dim result = MessageBox.Show("Please enter date of birth.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtdob.Focus()
                End If
            ElseIf txtsex.Text = "" Then
                Dim result = MessageBox.Show("Please enter sex.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtsex.Focus()
                End If
            ElseIf txtcoursedesig.Text = "" Then
                If cmbidfor.Text = "Student" Then
                    Dim result = MessageBox.Show("Please enter course.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    If result = Windows.Forms.DialogResult.OK Then
                        txtcoursedesig.Focus()
                    End If
                ElseIf cmbidfor.Text = "Employee" Then
                    Dim result = MessageBox.Show("Please enter designation.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    If result = Windows.Forms.DialogResult.OK Then
                        txtcoursedesig.Focus()
                    End If
                End If
            ElseIf txtaddress.Text = "" Then
                Dim result = MessageBox.Show("Please enter address.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtaddress.Focus()
                End If
            Else
                lbladdress.Text = "Address: " + txtaddress.Text
                If cmbidfor.Text = "Student" Then
                    lblcourse.Text = "Course: " + txtcoursedesig.Text
                ElseIf cmbidfor.Text = "Employee" Then
                    lblcourse.Text = "Designation: " + txtcoursedesig.Text
                End If
                lbldob.Text = "Dob: " + txtdob.Text
                lblname.Text = txtname.Text
                lblregno.Text = cmbreg.Text
                lblsex.Text = "Sex: " + txtsex.Text
                Try
                    If cmbidfor.Text = "Student" Then
                        cmd.CommandText = "select picture from StudentRegistration where stuid='" & cmbreg.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                        dr = cmd.ExecuteReader
                        If dr.Read() Then
                            Dim img As Image = Image.FromStream(ConvertBytesToMemoryStream(dr("picture")))
                            Dim newBMP As New Bitmap(95, 124)
                            Dim gt_dest As Graphics = Graphics.FromImage(newBMP)
                            gt_dest.Clear(Color.White)
                            Dim newWidth As Integer = newBMP.Width - 2 * 93
                            gt_dest.DrawImage(img, 93, 0, newWidth, newBMP.Height)
                            gt_dest.Dispose()
                            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                            PictureBox1.Image = newBMP
                        End If
                        dr.Close()
                    ElseIf cmbidfor.Text = "Employee" Then
                        cmd.CommandText = "select picture from Employee where empid='" & cmbreg.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                        dr = cmd.ExecuteReader
                        If dr.Read() Then
                            Dim img As Image = Image.FromStream(ConvertBytesToMemoryStream(dr("picture")))
                            Dim newBMP As New Bitmap(95, 124)
                            Dim gt_dest As Graphics = Graphics.FromImage(newBMP)
                            gt_dest.Clear(Color.White)
                            Dim newWidth As Integer = newBMP.Width - 2 * 93
                            gt_dest.DrawImage(img, 93, 0, newWidth, newBMP.Height)
                            gt_dest.Dispose()
                            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                            PictureBox1.Image = newBMP
                        End If
                        dr.Close()
                    End If
                Catch ex As Exception
                    dr.Close()
                End Try
                ERoundedPanel1.Visible = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedIDCard()
        Try
            cmd.CommandText = "select * from IDCard where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and idserial='" & idserial & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                txtserial.Text = dr("idserial").ToString()
                cmbidfor.Text = dr("idfor").ToString()
                cmbdate.Text = dr("date").ToString()
                cmbreg.Text = dr("regno").ToString()
                txtname.Text = dr("name").ToString()
                txtdob.Text = dr("dob").ToString()
                txtsex.Text = dr("sex").ToString()
                txtcoursedesig.Text = dr("coursedesig").ToString()
                txtaddress.Text = dr("address").ToString()
            End If
            dr.Close()
            DrawIDCard()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CheckIDCard()
        Try
            cmd.CommandText = "select * from IDCard where idserial='" & txtserial.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                IDCardExist = True
            Else
                IDCardExist = False
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
            IDCardExist = False
        End Try
    End Sub
#End Region
#Region "FormEvents"
    Private Sub frmSubmitIDCard_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updateidcard = False Then
            ControlSetBound()
            cmbidfor.Items.Add(New ComboBoxIconItem("Student", 1))
            cmbidfor.Items.Add(New ComboBoxIconItem("Employee", 0))
            cmbdate.Text = UmbrellaSystemDate
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            cmbidfor.Items.Add(New ComboBoxIconItem("Student", 1))
            cmbidfor.Items.Add(New ComboBoxIconItem("Employee", 0))
            LoadSelectedIDCard()
        End If
        If USidcard = "View Only" Then
            btndelete.Enabled = False
            btngo.Enabled = False
            btnprint.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbdate.Enabled = False
            cmbidfor.Enabled = False
            cmbreg.Enabled = False
            txtaddress.ReadOnly = True
            txtcoursedesig.ReadOnly = True
            txtdob.ReadOnly = True
            txtname.ReadOnly = True
            txtserial.ReadOnly = True
            txtsex.ReadOnly = True
        End If
    End Sub
#End Region
#Region "ButtonEvents"
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updateidcard = False Then
            AddRecord()
        ElseIf updateidcard = True Then
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updateidcard = False Then
            AddRecord()
            ResetForm()
        ElseIf updateidcard = True Then
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updateidcard = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updateidcard = False Then
            ControlSetBound()
            cmbidfor.Items.Add(New ComboBoxIconItem("Student", 1))
            cmbidfor.Items.Add(New ComboBoxIconItem("Employee", 0))
            cmbdate.Text = Date.Now.ToShortDateString()
            cmbdate.Text = UmbrellaSystemDate
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            cmbidfor.Items.Add(New ComboBoxIconItem("Student", 1))
            cmbidfor.Items.Add(New ComboBoxIconItem("Employee", 0))
            LoadSelectedIDCard()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub

    Private Sub btnprint_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnprint.ClickButtonArea

    End Sub

    Private Sub btngo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngo.Click
        If cmbreg.Text <> "" Then
            DrawIDCard()
        End If
    End Sub
#End Region
#Region "Attributes"
    Private Sub txtserial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtserial.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            cmbidfor.Focus()
        End If
    End Sub

    Private Sub cmbidfor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbidfor.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbdate.Focus()
        End If
    End Sub

    Private Sub cmbdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbreg.Focus()
        End If
    End Sub

    Private Sub cmbidfor_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbidfor.TextChanged
        If cmbidfor.Text = "Student" Then
            EGroupBox2.GroupTitle = "Select Student Record"
            EGroupBox2.GroupImage = Global.Umbrella.My.Resources.admission_icon
            lblcoursedesig.Text = "Course:"
            LoadRegistration()
        ElseIf cmbidfor.Text = "Employee" Then
            EGroupBox2.GroupTitle = "Select Employee Record"
            EGroupBox2.GroupImage = Global.Umbrella.My.Resources.employee
            lblcoursedesig.Text = "Desig:"
            LoadRegistration()
        End If
    End Sub

    Private Sub cmbreg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbreg.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbreg.Text <> "" Then
                If cmbidfor.Text = "Student" Then
                    LoadStudent()
                    DrawIDCard()
                ElseIf cmbidfor.Text = "Employee" Then
                    LoadEmployee()
                    DrawIDCard()
                End If
            End If
            txtname.Focus()
        End If
    End Sub

    Private Sub txtname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtdob.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbreg.Focus()
        End If
    End Sub

    Private Sub txtdob_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdob.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtsex.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtname.Focus()
        End If
    End Sub

    Private Sub txtsex_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsex.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtcoursedesig.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtdob.Focus()
        End If
    End Sub

    Private Sub txtcoursedesig_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcoursedesig.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtaddress.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtsex.Focus()
        End If
    End Sub

    Private Sub txtaddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtaddress.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            btnprint.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcoursedesig.Focus()
        End If
    End Sub
#End Region
End Class
#End Region