#Region "Imports..."
Imports ESAR_Controls.UIControls.ComboBox
Imports ESAR_Controls.UIControls.TextBox
#End Region
#Region "Class frmDiscount..."
Public Class frmDiscount
#Region "Declarations..."
    Private DGVCourse As New Windows.Forms.DataGridView()
    Private DGViewRecord As New DataGridView()
    Private DGViewEmp As New DataGridView()
    Private Exist As Boolean = False
    Private ACODE As String = ""
    Private TT As String = ""
    Private TotalPaid As Decimal = 0.0
    Private AppliedName As String = ""
    Private DiscountExist As Boolean = False
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        ACODE = Indx.LoadDiscountID()
        Dim var As String
        var = CodeIncrement(ACODE)
        Me.txtdiscountid.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("DCT:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        Label1.SetBounds(22, 21, 79, 13)
        Label10.SetBounds(11, 79, 61, 13)
        Label11.SetBounds(177, 79, 17, 13)
        Label12.SetBounds(177, 52, 19, 13)
        Label13.SetBounds(177, 24, 17, 13)
        Label14.SetBounds(11, 19, 55, 13)
        Label15.SetBounds(11, 47, 93, 13)
        Label16.SetBounds(319, 70, 33, 13)
        Label17.SetBounds(276, 21, 76, 13)
        Label18.SetBounds(177, 106, 17, 13)
        Label19.SetBounds(22, 21, 92, 13)
        Label2.SetBounds(638, 21, 39, 13)
        Label20.SetBounds(11, 106, 81, 13)
        Label3.SetBounds(22, 15, 83, 13)
        Label4.SetBounds(254, 15, 98, 13)
        Label5.SetBounds(22, 43, 45, 13)
        Label6.SetBounds(22, 70, 38, 13)
        Label7.SetBounds(11, 73, 63, 13)
        Label8.SetBounds(11, 24, 87, 13)
        Label9.SetBounds(11, 52, 91, 13)

        nudyear.SetBounds(358, 18, 60, 21)

        cmbauthentication.SetBounds(111, 44, 142, 21)
        cmbcourse.SetBounds(120, 18, 140, 21)
        cmbdate.SetBounds(683, 18, 100, 21)
        cmbdiscountfor.SetBounds(111, 12, 121, 21)
        cmbpayvia.SetBounds(111, 16, 60, 22)
        cmbregid.SetBounds(358, 12, 121, 21)

        txtclass.SetBounds(111, 67, 121, 21)
        txtdiscount.SetBounds(111, 76, 60, 21)
        txtdiscountid.SetBounds(111, 18, 121, 21)
        txtdiscountrate.SetBounds(111, 49, 60, 21)
        txtname.SetBounds(111, 40, 368, 21)
        txtpaidamount.SetBounds(111, 103, 60, 21)
        txtremarks.SetBounds(13, 90, 241, 84)
        txtroll.SetBounds(358, 67, 121, 21)
        txttotalamount.SetBounds(111, 21, 60, 21)
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
            Dim col4 As New DataGridViewTextBoxColumn()
            With col4
                .Name = "Col4"
                .HeaderText = "Fees"
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
            DGVCourse.Columns.Add(col4)

            DGVCourse.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select CourseCode,CourseName,Duration,CourseFees from Course where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and year='" & nudyear.Value.ToString() & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                DGVCourse.Rows.Add()

                DGVCourse.Rows(indx).Cells(0).Value = dr("CourseCode").ToString()
                DGVCourse.Rows(indx).Cells(1).Value = dr("CourseName").ToString()
                DGVCourse.Rows(indx).Cells(2).Value = dr("Duration").ToString()
                DGVCourse.Rows(indx).Cells(3).Value = dr("CourseFees").ToString()

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
            crsname = DGVCourse.Rows(k).Cells(1).Value.ToString()
            cmbcourse.Text = crsname
        Catch ex As Exception

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

            If cmbdiscountfor.Text = "Student" Then
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
            ElseIf cmbdiscountfor.Text = "Employee" Then
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

            cmbregid.AddDataGridView(DGViewRecord, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadEmployee()
        Try
            If DGViewEmp.Columns.Count > 0 Then
                DGViewEmp.Rows.Clear()
                DGViewEmp.Columns.Clear()
            End If

            Dim col3 As New DataGridViewLinkColumn()
            With col3
                .HeaderText = "Registration No."
            End With
            Dim col4 As New DataGridViewTextBoxColumn()
            With col4
                .HeaderText = "Name"
            End With

            With DGViewEmp
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
                AddHandler DGViewEmp.CellClick, AddressOf DGViewEmp_CellClick
            End With

            DGViewEmp.Columns.Clear()
            DGViewEmp.Columns.Add(col3)
            DGViewEmp.Columns.Add(col4)

            DGViewEmp.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select empid,name from Employee where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                DGViewEmp.Rows.Add()
                DGViewEmp.Rows(indx).Cells(0).Value = dr("empid").ToString()
                DGViewEmp.Rows(indx).Cells(1).Value = dr("name").ToString()
                indx = indx + 1
            End While
            dr.Close()
            DGViewEmp.ClearSelection()

            cmbauthentication.AddDataGridView(DGViewEmp, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGViewRecord_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            If cmbdiscountfor.Text = "Student" Then
                Dim k As Integer = DGViewRecord.CurrentRow.Index
                DGViewRecord.Rows(k).Selected = True
                DGViewRecord.CurrentCell = DGViewRecord.Rows(k).Cells(0)
                StuID = DGViewRecord.Rows(k).Cells(0).Value.ToString()
                StuName = DGViewRecord.Rows(k).Cells(1).Value.ToString()
                cmbregid.Text = StuID
                LoadSelectedStudent(cmbregid.Text)
                LoadDiscountCharge()
            ElseIf cmbdiscountfor.Text = "Employee" Then
                Dim k As Integer = DGViewRecord.CurrentRow.Index
                DGViewRecord.Rows(k).Selected = True
                DGViewRecord.CurrentCell = DGViewRecord.Rows(k).Cells(0)
                EmpRegNo = DGViewRecord.Rows(k).Cells(0).Value.ToString()
                EmpName = DGViewRecord.Rows(k).Cells(1).Value.ToString()
                cmbregid.Text = EmpRegNo
                LoadSelectedEmployee(cmbregid.Text)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGViewEmp_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGViewEmp.CurrentRow.Index
            DGViewEmp.Rows(k).Selected = True
            DGViewEmp.CurrentCell = DGViewEmp.Rows(k).Cells(0)
            EmpRegNo = DGViewEmp.Rows(k).Cells(0).Value.ToString()
            EmpName = DGViewEmp.Rows(k).Cells(1).Value.ToString()
            cmbauthentication.Text = EmpName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckStudents()
        Try
            cmd.CommandText = "select stuid,name,course,discount from StudentDiscount where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Year='" & nudyear.Value.ToString() & "' and course='" & cmbcourse.Text & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                Exist = True
                dr.Close()
            Else
                Exist = False
                dr.Close()
            End If
        Catch ex As Exception
            dr.Close()
            Exist = False
        End Try
    End Sub

    Private Sub LoadStudents()
        Try
            CheckStudents()
            If Exist = True Then
                Dim i As Integer = 0
                dgviewstudents.Rows.Clear()
                cmd.CommandText = "select stuid,name,class,roll,course,discount from StudentDiscount where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Year='" & nudyear.Value.ToString() & "' and course='" & cmbcourse.Text & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    dgviewstudents.Rows.Add()
                    dgviewstudents.Rows(i).Cells(0).Value = dr("stuid").ToString()
                    dgviewstudents.Rows(i).Cells(1).Value = dr("name").ToString()
                    dgviewstudents.Rows(i).Cells(2).Value = dr("class").ToString()
                    dgviewstudents.Rows(i).Cells(3).Value = dr("roll").ToString()
                    dgviewstudents.Rows(i).Cells(4).Value = dr("course").ToString()
                    dgviewstudents.Rows(i).Cells(5).Value = dr("discount").ToString()
                    i = i + 1
                End While
                dr.Close()
            Else
                Dim i As Integer = 0
                dgviewstudents.Rows.Clear()
                cmd.CommandText = "select stuid,name,class,roll,course from StudentRegistration where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and course='" & cmbcourse.Text & "'"
                dr = cmd.ExecuteReader
                While dr.Read()
                    dgviewstudents.Rows.Add()
                    dgviewstudents.Rows(i).Cells(0).Value = dr("stuid").ToString()
                    dgviewstudents.Rows(i).Cells(1).Value = dr("name").ToString()
                    dgviewstudents.Rows(i).Cells(2).Value = dr("class").ToString()
                    dgviewstudents.Rows(i).Cells(3).Value = dr("roll").ToString()
                    dgviewstudents.Rows(i).Cells(4).Value = dr("course").ToString()
                    dgviewstudents.Rows(i).Cells(5).Value = "0.00"
                    i = i + 1
                End While
                dr.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedStudent(ByVal regno As String)
        Try
            cmd.CommandText = "select name,class,roll from StudentRegistration where stuid='" & regno & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            txtname.Text = dr("name").ToString()
            txtclass.Text = dr("class").ToString()
            txtroll.Text = dr("roll").ToString()
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadSelectedEmployee(ByVal regno As String)
        Try
            cmd.CommandText = "select name from Employee where empid='" & regno & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            txtname.Text = dr("name").ToString()
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadDiscountCharge()
        Try
            Dim dt As Date = Date.Parse(cmbdate.Text)
            Dim year As Integer = dt.Year
            If cmbdiscountfor.Text = "Student" Then
                Dim exst As Boolean = False
                cmd.CommandText = "select discount from StudentDiscount where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and year=" & year & " and stuid='" & cmbregid.Text & "'"
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    exst = True
                Else
                    exst = False
                End If
                dr.Close()
                Dim disccharge As Decimal = 0.0
                If exst = True Then
                    cmd.CommandText = "select discount from StudentDiscount where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and year=" & year & " and stuid='" & cmbregid.Text & "'"
                    disccharge = cmd.ExecuteScalar
                Else
                    disccharge = 0.0
                End If
                txtdiscountrate.Text = FormatNumber(disccharge.ToString())
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddRecord()
        Try
            If cmbdate.Text.Trim() = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbdate.Focus()
                End If
            ElseIf cmbpayvia.Text.Trim() = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select pay via.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbpayvia.Focus()
                End If
            ElseIf cmbregid.Text.Trim() = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select registration id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbregid.Focus()
                End If
            ElseIf txtdiscount.Text.Trim() = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter discount.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtdiscount.Focus()
                End If
            ElseIf txtpaidamount.Text.Trim() = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter paid amount.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtpaidamount.Focus()
                End If
            ElseIf txttotalamount.Text.Trim() = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter total amount.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txttotalamount.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    CheckDiscountID()
                    If DiscountExist = False Then
                        Dim cls As New cDiscount()
                        Dim dt As Date = Date.Parse(cmbdate.Text)
                        Dim month As Integer = dt.Month
                        Dim year As Integer = dt.Year
                        Dim name1 As String = ""
                        Dim clas1 As String = ""
                        Dim roll1 As String = ""
                        If cmbdiscountfor.Text = "Student" Then
                            name1 = txtname.Text
                            clas1 = txtclass.Text
                            roll1 = txtroll.Text
                        Else
                            name1 = EmpName
                        End If
                        cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtdiscountid.Text, cmbdate.Text, month, year, cmbdiscountfor.Text, clas1, roll1, cmbregid.Text, name1, CDec(txttotalamount.Text), CDec(txtdiscountrate.Text), CDec(txtdiscount.Text), CDec(txtpaidamount.Text), cmbpayvia.Text, cmbauthentication.Text, txtremarks.Text, ISDDiscountFeesAccount)
                        If cls.AddDiscountOk = True Then
                            cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & CDec(txtpaidamount.Text) & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDDiscountFeesAccount & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                            Dim result1 As DialogResult = MessageBox.Show("Record added successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = Windows.Forms.DialogResult.OK Then
                                ETabControl1.SelectTab(TabPage1)
                            End If
                        End If
                        If cmbcourse.Text.Trim() <> "" Then
                            Dim exist As Boolean = False
                            cmd.CommandText = "select * from StudentDiscount where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and year='" & nudyear.Value.ToString() & "' and course='" & cmbcourse.Text & "'"
                            dr = cmd.ExecuteReader
                            If dr.Read() Then
                                exist = True
                            Else
                                exist = False
                            End If
                            dr.Close()
                            If exist = False Then
                                For i As Integer = 0 To dgviewstudents.Rows.Count - 1
                                    Dim regid As String = dgviewstudents.Rows(i).Cells(0).Value.ToString()
                                    Dim name As String = dgviewstudents.Rows(i).Cells(1).Value.ToString()
                                    Dim clas As String = dgviewstudents.Rows(i).Cells(2).Value.ToString()
                                    Dim roll As String = dgviewstudents.Rows(i).Cells(3).Value.ToString()
                                    Dim course As String = dgviewstudents.Rows(i).Cells(4).Value.ToString()
                                    Dim discount As Decimal = CDec(dgviewstudents.Rows(i).Cells(5).Value.ToString())
                                    cmd.CommandText = "insert into StudentDiscount(InsID,InsName,Period,year,course,class,roll,stuid,name,discount) values ('" & My.Settings.LastOpenedInstituteID & "','" & My.Settings.LastOpenedInstitute & "','" & My.Settings.Period & "','" & nudyear.Value.ToString() & "','" & course & "','" & clas & "','" & roll & "','" & regid & "','" & name & "'," & discount & ")"
                                    dr = cmd.ExecuteReader
                                    dr.Close()
                                Next
                                Dim result1 As DialogResult = MessageBox.Show("Record added successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                If result1 = Windows.Forms.DialogResult.OK Then
                                    ETabControl1.SelectTab(TabPage1)
                                End If
                            Else
                                For i As Integer = 0 To dgviewstudents.Rows.Count - 1
                                    Dim regid As String = dgviewstudents.Rows(i).Cells(0).Value.ToString()
                                    Dim name As String = dgviewstudents.Rows(i).Cells(1).Value.ToString()
                                    Dim clas As String = dgviewstudents.Rows(i).Cells(2).Value.ToString()
                                    Dim roll As String = dgviewstudents.Rows(i).Cells(3).Value.ToString()
                                    Dim course As String = dgviewstudents.Rows(i).Cells(4).Value.ToString()
                                    Dim discount As Decimal = CDec(dgviewstudents.Rows(i).Cells(5).Value.ToString())
                                    cmd.CommandText = "update StudentDiscount set discount=" & discount & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and year='" & nudyear.Value.ToString() & "' and course='" & course & "' and class='" & clas & "' and roll='" & roll & "' and stuid='" & regid & "' and name='" & name & "'"
                                    dr = cmd.ExecuteReader
                                    dr.Close()
                                Next
                                Dim result1 As DialogResult = MessageBox.Show("Record added successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                If result1 = Windows.Forms.DialogResult.OK Then
                                    ETabControl1.SelectTab(TabPage1)
                                End If
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Discount id already exist." + Environment.NewLine + "Please enter a new discount id.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            ETabControl1.SelectTab(TabPage1)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If cmbdate.Text.Trim() = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbdate.Focus()
                End If
            ElseIf cmbpayvia.Text.Trim() = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select pay via.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbpayvia.Focus()
                End If
            ElseIf cmbregid.Text.Trim() = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select registration id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbregid.Focus()
                End If
            ElseIf txtdiscount.Text.Trim() = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter discount.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtdiscount.Focus()
                End If
            ElseIf txtpaidamount.Text.Trim() = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter paid amount.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtpaidamount.Focus()
                End If
            ElseIf txttotalamount.Text.Trim() = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter total amount.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txttotalamount.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cDiscount()
                    Dim dt As Date = Date.Parse(cmbdate.Text)
                    Dim month As Integer = dt.Month
                    Dim year As Integer = dt.Year
                    Dim name1 As String = ""
                    Dim clas1 As String = ""
                    Dim roll1 As String = ""
                    If cmbdiscountfor.Text = "Student" Then
                        name1 = txtname.Text
                        clas1 = txtclass.Text
                        roll1 = txtroll.Text
                    Else
                        name1 = EmpName
                    End If
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtdiscountid.Text, cmbdate.Text, month, year, cmbdiscountfor.Text, clas1, roll1, cmbregid.Text, name1, CDec(txttotalamount.Text), CDec(txtdiscountrate.Text), CDec(txtdiscount.Text), CDec(txtpaidamount.Text), cmbpayvia.Text, cmbauthentication.Text, txtremarks.Text, ISDDiscountFeesAccount)
                    If cls.UpdateDiscountOk = True Then
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & TotalPaid & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDDiscountFeesAccount & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & CDec(txtpaidamount.Text) & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDDiscountFeesAccount & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                    End If
                    If cmbcourse.Text.Trim() <> "" Then
                        Dim exist As Boolean = False
                        cmd.CommandText = "select * from StudentDiscount where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and year='" & nudyear.Value.ToString() & "' and course='" & cmbcourse.Text & "'"
                        dr = cmd.ExecuteReader
                        If dr.Read() Then
                            exist = True
                        Else
                            exist = False
                        End If
                        dr.Close()
                        If exist = False Then
                            For i As Integer = 0 To dgviewstudents.Rows.Count - 1
                                Dim regid As String = dgviewstudents.Rows(i).Cells(0).Value.ToString()
                                Dim name As String = dgviewstudents.Rows(i).Cells(1).Value.ToString()
                                Dim clas As String = dgviewstudents.Rows(i).Cells(2).Value.ToString()
                                Dim roll As String = dgviewstudents.Rows(i).Cells(3).Value.ToString()
                                Dim course As String = dgviewstudents.Rows(i).Cells(4).Value.ToString()
                                Dim discount As Decimal = CDec(dgviewstudents.Rows(i).Cells(5).Value.ToString())
                                cmd.CommandText = "insert into StudentDiscount(InsID,InsName,Period,year,course,class,roll,stuid,name,discount) values ('" & My.Settings.LastOpenedInstituteID & "','" & My.Settings.LastOpenedInstitute & "','" & My.Settings.Period & "','" & nudyear.Value.ToString() & "','" & course & "','" & clas & "','" & roll & "','" & regid & "','" & name & "'," & discount & ")"
                                dr = cmd.ExecuteReader
                                dr.Close()
                            Next
                        Else
                            For i As Integer = 0 To dgviewstudents.Rows.Count - 1
                                Dim regid As String = dgviewstudents.Rows(i).Cells(0).Value.ToString()
                                Dim name As String = dgviewstudents.Rows(i).Cells(1).Value.ToString()
                                Dim clas As String = dgviewstudents.Rows(i).Cells(2).Value.ToString()
                                Dim roll As String = dgviewstudents.Rows(i).Cells(3).Value.ToString()
                                Dim course As String = dgviewstudents.Rows(i).Cells(4).Value.ToString()
                                Dim discount As Decimal = CDec(dgviewstudents.Rows(i).Cells(5).Value.ToString())
                                cmd.CommandText = "update StudentDiscount set discount=" & discount & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and year='" & nudyear.Value.ToString() & "' and course='" & course & "' and class='" & clas & "' and roll='" & roll & "' and stuid='" & regid & "' and name='" & name & "'"
                                dr = cmd.ExecuteReader
                                dr.Close()
                            Next
                        End If
                    End If
                End If
            End If
            Dim result1 As DialogResult = MessageBox.Show("Record added successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If result1 = Windows.Forms.DialogResult.OK Then
                ETabControl1.SelectTab(TabPage1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If cmbdate.Text.Trim() = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbdate.Focus()
                End If
            ElseIf cmbpayvia.Text.Trim() = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select pay via.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbpayvia.Focus()
                End If
            ElseIf cmbregid.Text.Trim() = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select registration id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbregid.Focus()
                End If
            ElseIf txtdiscount.Text.Trim() = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter discount.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtdiscount.Focus()
                End If
            ElseIf txtpaidamount.Text.Trim() = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter paid amount.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtpaidamount.Focus()
                End If
            ElseIf txttotalamount.Text.Trim() = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter total amount.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txttotalamount.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cDiscount()
                    Dim dt As Date = Date.Parse(cmbdate.Text)
                    Dim month As Integer = dt.Month
                    Dim year As Integer = dt.Year
                    Dim name As String = ""
                    Dim clas As String = ""
                    Dim roll As String = ""
                    If cmbdiscountfor.Text = "Student" Then
                        name = txtname.Text
                        clas = txtclass.Text
                        roll = txtroll.Text
                    Else
                        name = EmpName
                    End If
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtdiscountid.Text, cmbdate.Text, month, year, cmbregid.Text, AppliedName, clas, roll)
                    If cls.DeleteDiscountOk = True Then
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & TotalPaid & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDDiscountFeesAccount & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        Dim result1 As DialogResult = MessageBox.Show("Record deleted successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            ResetForm()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetForm()
        updatediscount = False
        dgviewstudents.Rows.Clear()
        cmbcourse.Text = ""
        Dim yy As Integer = Date.Now.Year
        nudyear.Value = yy
        If ISDAutoID = "Yes" Then
            GetCode()
        Else
            txtdiscountid.Text = ""
        End If
        txtclass.Text = ""
        txtdiscount.Text = ""
        txtdiscountrate.Text = ""
        txtname.Text = ""
        txtpaidamount.Text = ""
        txtremarks.Text = ""
        txtroll.Text = ""
        txttotalamount.Text = ""
        cmbauthentication.Text = ""
        cmbdate.Text = UmbrellaSystemDate
        cmbdiscountfor.Text = ""
        cmbpayvia.Text = ""
        cmbregid.Text = ""
        txtdiscountid.Focus()
    End Sub

    Private Sub LoadSelectedRecord()
        Try
            cmd.CommandText = "select * from Discount where transactionid='" & transactionid & "' and date='" & discountdate & "' and appliedfor='" & discountappliedfor & "' and name='" & discountname & "' and regno='" & discountregno & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                cmbauthentication.Text = dr("authentication").ToString()
                cmbdate.Text = dr("date").ToString()
                cmbdiscountfor.Text = dr("appliedfor").ToString()
                cmbpayvia.Text = dr("payvia").ToString()
                cmbregid.Text = dr("regno").ToString()
                txtclass.Text = dr("class").ToString()
                txtdiscount.Text = dr("discount").ToString()
                txtdiscountid.Text = dr("transactionid").ToString()
                txtdiscountrate.Text = dr("discountcharge").ToString()
                txtname.Text = dr("name").ToString()
                txtpaidamount.Text = dr("pay").ToString()
                txtremarks.Text = dr("remarks").ToString()
                txtroll.Text = dr("roll").ToString()
                txttotalamount.Text = dr("totalamt").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CheckDiscountID()
        Try
            cmd.CommandText = "select * from Discount where transactionid='" & txtdiscountid.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                DiscountExist = True
            Else
                DiscountExist = False
            End If
            dr.Close()
        Catch ex As Exception
            DiscountExist = False
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmDiscount_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updatediscount = False Then
            ControlSetBound()
            cmbpayvia.Items.Add(New ComboBoxIconItem("Cash", 0))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Check", 1))
            cmbdiscountfor.Items.Add(New ComboBoxIconItem("Student", 0))
            cmbdiscountfor.Items.Add(New ComboBoxIconItem("Employee", 1))
            cmbdiscountfor.Items.Add(New ComboBoxIconItem("Other", 2))
            cmbdate.Text = UmbrellaSystemDate
            Dim yy As Integer = Date.Now.Year
            nudyear.Maximum = yy
            nudyear.Minimum = yy - 1
            nudyear.Value = yy
            GroupBox1.Text = "Discount Account: "
            GroupBox1.Text += ISDDiscountFeesAccount
            LoadCourse()
            LoadEmployee()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
            If ISDApplyDiscount = "No" Then
                ETabControl1.TabPages.Remove(TabPage2)
            End If
        Else
            ControlSetBound()
            cmbpayvia.Items.Add(New ComboBoxIconItem("Cash", 0))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Check", 1))
            cmbdiscountfor.Items.Add(New ComboBoxIconItem("Student", 0))
            cmbdiscountfor.Items.Add(New ComboBoxIconItem("Employee", 1))
            cmbdiscountfor.Items.Add(New ComboBoxIconItem("Other", 2))
            Dim yy As Integer = Date.Now.Year
            nudyear.Maximum = yy
            nudyear.Minimum = yy - 1
            nudyear.Value = yy
            GroupBox1.Text = "Discount Account: "
            GroupBox1.Text += ISDDiscountFeesAccount
            LoadCourse()
            LoadEmployee()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
            If ISDApplyDiscount = "No" Then
                ETabControl1.TabPages.Remove(TabPage2)
            End If
            LoadSelectedRecord()
        End If
        If USdiscount = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbauthentication.Enabled = False
            cmbcourse.Enabled = False
            cmbdate.Enabled = False
            cmbdiscountfor.Enabled = False
            cmbpayvia.Enabled = False
            cmbregid.Enabled = False
            txtclass.ReadOnly = True
            txtdiscount.ReadOnly = True
            txtdiscountid.ReadOnly = True
            txtdiscountrate.ReadOnly = True
            txtname.ReadOnly = True
            txtpaidamount.ReadOnly = True
            txtremarks.ReadOnly = True
            txtroll.ReadOnly = True
            txttotalamount.ReadOnly = True
            dgviewstudents.Enabled = False
            nudyear.Enabled = False
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updatediscount = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updatediscount = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updatediscount = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updatediscount = False Then
            ControlSetBound()
            cmbpayvia.Items.Add(New ComboBoxIconItem("Cash", 0))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Check", 1))
            cmbdiscountfor.Items.Add(New ComboBoxIconItem("Student", 0))
            cmbdiscountfor.Items.Add(New ComboBoxIconItem("Employee", 1))
            cmbdiscountfor.Items.Add(New ComboBoxIconItem("Other", 2))
            cmbdate.Text = UmbrellaSystemDate
            Dim yy As Integer = Date.Now.Year
            nudyear.Maximum = yy
            nudyear.Minimum = yy - 1
            nudyear.Value = yy
            GroupBox1.Text = "Discount Account: "
            GroupBox1.Text += ISDDiscountFeesAccount
            LoadCourse()
            LoadEmployee()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
            If ISDApplyDiscount = "No" Then
                ETabControl1.TabPages.Remove(TabPage2)
            End If
        Else
            ControlSetBound()
            cmbpayvia.Items.Add(New ComboBoxIconItem("Cash", 0))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Check", 1))
            cmbdiscountfor.Items.Add(New ComboBoxIconItem("Student", 0))
            cmbdiscountfor.Items.Add(New ComboBoxIconItem("Employee", 1))
            cmbdiscountfor.Items.Add(New ComboBoxIconItem("Other", 2))
            Dim yy As Integer = Date.Now.Year
            nudyear.Maximum = yy
            nudyear.Minimum = yy - 1
            nudyear.Value = yy
            GroupBox1.Text = "Discount Account: "
            GroupBox1.Text += ISDDiscountFeesAccount
            LoadCourse()
            LoadEmployee()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
            If ISDApplyDiscount = "No" Then
                ETabControl1.TabPages.Remove(TabPage2)
            End If
            LoadSelectedRecord()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Attributes..."
    Private Sub txtdiscountid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdiscountid.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbdate.Focus()
        End If
    End Sub

    Private Sub cmbdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbdiscountfor.Focus()
        End If
    End Sub

    Private Sub cmbdiscountfor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdiscountfor.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbregid.Focus()
        End If
    End Sub

    Private Sub cmbdiscountfor_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbdiscountfor.TextChanged
        cmbregid.Text = ""
        txtname.Text = ""
        txtclass.Text = ""
        txtroll.Text = ""
        If cmbdiscountfor.Text <> "" Then
            If cmbdiscountfor.Text = "Student" Then
                txtclass.ReadOnly = False
                txtroll.ReadOnly = False
            Else
                txtclass.ReadOnly = True
                txtroll.ReadOnly = True
            End If
            LoadRegistration()
        End If
    End Sub

    Private Sub cmbregid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbregid.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtname.Focus()
        End If
    End Sub

    Private Sub txtname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtclass.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbregid.Focus()
        End If
    End Sub

    Private Sub txtclass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtclass.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtroll.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtname.Focus()
        End If
    End Sub

    Private Sub txtroll_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtroll.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txttotalamount.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtclass.Focus()
        End If
    End Sub

    Private Sub txttotalamount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttotalamount.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtdiscountrate.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtroll.Focus()
        End If
    End Sub

    Private Sub txtdiscountrate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdiscountrate.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtdiscount.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txttotalamount.Focus()
        End If
    End Sub

    Private Sub txtdiscount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdiscount.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtpaidamount.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtdiscountrate.Focus()
        End If
    End Sub

    Private Sub txtpaidamount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpaidamount.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbpayvia.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtdiscount.Focus()
        End If
    End Sub

    Private Sub cmbpayvia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbpayvia.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbauthentication.Focus()
        End If
    End Sub

    Private Sub cmbauthentication_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbauthentication.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtremarks.Focus()
        End If
    End Sub

    Private Sub cmbcourse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcourse.KeyDown
        If e.KeyCode = Keys.Enter Then
            nudyear.Focus()
        End If
    End Sub

    Private Sub cmbcourse_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbcourse.TextChanged
        If cmbcourse.Text <> "" Then
            LoadStudents()
        End If
    End Sub

    Private Sub TextBoxTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtname.TextChanged, txtclass.TextChanged
        Dim ctc As New cTextChange()
        Dim x As eTextBox = CType(sender, eTextBox)
        ctc.ConvertTextBoxValidValue(x)
    End Sub

    Private Sub ComboBoxKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbauthentication.KeyPress, cmbcourse.KeyPress, cmbdate.KeyPress, cmbdiscountfor.KeyPress, cmbpayvia.KeyPress, cmbregid.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxLostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttotalamount.LostFocus, txtdiscountrate.LostFocus, txtdiscount.LostFocus, txtpaidamount.LostFocus
        Dim totalamt As Decimal = 0.0
        Dim discch As Decimal = 0.0
        Dim disc As Decimal = 0.0
        Dim pay As Decimal = 0.0
        If txttotalamount.Text.Trim() <> "" Then
            totalamt = CDec(txttotalamount.Text)
        Else
            totalamt = 0.0
        End If
        If txtdiscountrate.Text.Trim() <> "" Then
            discch = CDec(txtdiscountrate.Text)
        Else
            discch = 0.0
        End If
        disc = (totalamt * discch) / 100
        disc = Decimal.Round(disc, 2, MidpointRounding.AwayFromZero)
        txtdiscount.Text = disc.ToString()
        pay = totalamt - disc
        pay = Decimal.Round(pay, 2, MidpointRounding.AwayFromZero)
        txtpaidamount.Text = pay.ToString()
    End Sub
#End Region
#Region "DGViewEvents..."
    Private Sub dgviewstudents_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgviewstudents.CellEndEdit
        If e.ColumnIndex = 5 Then
            Dim i As Integer = dgviewstudents.CurrentRow.Index
            Dim val As Decimal = CDec(dgviewstudents.Rows(i).Cells(5).Value.ToString())
            dgviewstudents.Rows(i).Cells(5).Value = FormatNumber(val.ToString())
        End If
    End Sub
#End Region
End Class
#End Region