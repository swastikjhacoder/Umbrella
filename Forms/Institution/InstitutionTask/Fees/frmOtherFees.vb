#Region "Imports"
Imports ESAR_Controls.UIControls.ComboBox
#End Region
#Region "Class frmOtherFees..."
Public Class frmOtherFees
#Region "Declarations..."
    Private ACODE As String = ""
    Private TT As String = ""
    Private DGVRegNo As New DataGridView()
    Private DGVCourse As New DataGridView()
    Private DGVAccount As New DataGridView()
    Private TotalPaid As Decimal = 0.0
    Private OtherFee As Decimal = 0.0
    Private Discount As Decimal = 0.0
    Private TokenExist As Boolean = False
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        ACODE = Indx.LoadOthersID()
        Dim var As String
        var = CodeIncrement(ACODE)
        Me.txttoken.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("ORF:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        SplitContainer2.SplitterWidth = 5
        SplitContainer3.SplitterWidth = 5
        SplitContainer4.SplitterWidth = 5

        btnremaining.SetBounds(10, 47, 84, 21)

        Label1.SetBounds(10, 13, 53, 13)
        Label10.SetBounds(185, 23, 17, 13)
        Label11.SetBounds(185, 50, 17, 13)
        Label12.SetBounds(10, 77, 55, 13)
        Label13.SetBounds(164, 119, 33, 13)
        Label14.SetBounds(13, 147, 71, 13)
        Label2.SetBounds(10, 40, 43, 13)
        Label3.SetBounds(10, 67, 33, 13)
        Label4.SetBounds(10, 13, 45, 13)
        Label5.SetBounds(10, 40, 40, 13)
        Label6.SetBounds(10, 105, 136, 13)
        Label7.SetBounds(20, 20, 46, 13)
        Label8.SetBounds(365, 20, 39, 13)
        Label9.SetBounds(10, 23, 84, 13)
        lblpaid.SetBounds(58, 67, 52, 16)

        cmbclass.SetBounds(69, 37, 136, 21)
        cmbcourse.SetBounds(69, 10, 136, 21)
        cmbdate.SetBounds(416, 17, 112, 21)
        cmbpayvia.SetBounds(119, 74, 60, 22)
        cmbroll.SetBounds(69, 64, 136, 21)

        txtcardaddress.SetBounds(13, 62, 246, 21)
        txtcardcity.SetBounds(265, 62, 121, 21)
        txtcardcountry.SetBounds(265, 89, 121, 21)
        txtcardholdername.SetBounds(13, 35, 373, 21)
        txtcardno.SetBounds(13, 116, 148, 21)
        txtcardpin.SetBounds(167, 89, 92, 21)
        txtcardstate.SetBounds(13, 89, 148, 21)
        txtcardtype.SetBounds(90, 144, 169, 22)
        txtexpmm.SetBounds(203, 116, 25, 21)
        txtexpyy.SetBounds(234, 116, 25, 21)
        txtname.SetBounds(61, 10, 379, 21)
        txtpaid.SetBounds(119, 20, 60, 21)
        txtreason.SetBounds(156, 105, 260, 63)
        txttime.SetBounds(61, 37, 379, 21)
        txttoken.SetBounds(79, 17, 136, 21)
        txtremaining.SetBounds(119, 47, 60, 21)
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
            DGVRegNo.Columns.Add(col3)

            DGVRegNo.Rows.Clear()

            Dim indx As Integer = 0
            cmd.CommandText = "select roll,stuid,name from StudentRegistration where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and course='" & cmbcourse.Text & "' and class='" & cmbclass.Text & "'"
            dr = cmd.ExecuteReader
            While dr.Read()

                DGVRegNo.Rows.Add()
                DGVRegNo.Rows(indx).Cells(0).Value = dr("roll").ToString()
                DGVRegNo.Rows(indx).Cells(1).Value = dr("stuid").ToString()
                DGVRegNo.Rows(indx).Cells(2).Value = dr("name").ToString()

                indx = indx + 1
            End While
            dr.Close()
            DGVRegNo.ClearSelection()

            cmbroll.AddDataGridView(DGVRegNo, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVRegNo_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVRegNo.CurrentRow.Index
            DGVRegNo.Rows(k).Selected = True
            DGVRegNo.CurrentCell = DGVRegNo.Rows(k).Cells(0)
            Dim roll As String = DGVRegNo.Rows(k).Cells(0).Value.ToString()
            StuID = DGVRegNo.Rows(k).Cells(1).Value.ToString()
            StuName = DGVRegNo.Rows(k).Cells(2).Value.ToString()
            cmbroll.Text = roll
            LoadOtherFees(StuID)
            LoadStudentDetails(StuID)
            CheckPaid()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadOtherFees(ByVal StId As String)
        Try
            dgviewmonthly.Rows.Clear()
            dgviewmonthly.Rows.Add()
            dgviewmonthly.Rows.Add()
            dgviewmonthly.Rows.Add()
            dgviewmonthly.Rows.Add()

            Dim dt As Date = Date.Parse(cmbdate.Text)
            Dim month As Integer = dt.Month
            Dim year As Integer = dt.Year
            cmd.CommandText = "select tuition,payvia from StudentRegistration where course='" & cmbcourse.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim tuition As String = dr("tuition").ToString()
            cmbpayvia.Text = dr("payvia").ToString()
            dr.Close()
            Dim amt As Decimal = 0.0
            If tuition = "No" Then
                cmd.CommandText = "select sum(Fees) from CourseTermFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Course='" & cmbcourse.Text & "'"
                Dim totalamount As Decimal = cmd.ExecuteScalar()
                Dim TFees As String = "Tuitions Fee:"
                cmd.CommandText = "select Fees from CourseTermFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Course='" & cmbcourse.Text & "' and Terms='" & TFees & "'"
                Dim tuitionfees As Decimal = cmd.ExecuteScalar
                amt = totalamount - tuitionfees
            Else
                cmd.CommandText = "select sum(Fees) from CourseTermFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Course='" & cmbcourse.Text & "'"
                amt = cmd.ExecuteScalar()
            End If

            Dim exst As Boolean = False
            cmd.CommandText = "select discount from StudentDiscount where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and year=" & year & " and course='" & cmbcourse.Text & "' and stuid='" & StId & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                exst = True
            Else
                exst = False
            End If
            dr.Close()
            Dim disccharge As Decimal = 0.0
            If exst = True Then
                cmd.CommandText = "select discount from StudentDiscount where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and year=" & year & " and course='" & cmbcourse.Text & "' and stuid='" & StId & "'"
                disccharge = cmd.ExecuteScalar
            Else
                disccharge = 0.0
            End If

            Dim LibFees As String = "Library Caution Fee:"
            cmd.CommandText = "select Fees from CourseTermFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Course='" & cmbcourse.Text & "' and Terms='" & LibFees & "'"
            Dim libraryfees As Decimal = cmd.ExecuteScalar

            cmd.CommandText = "select sum(Fees) from CourseTermFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Course='" & cmbcourse.Text & "'"
            Dim totamount As Decimal = cmd.ExecuteScalar()

            Dim TuiFees As String = "Tuitions Fee:"
            cmd.CommandText = "select Fees from CourseTermFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Course='" & cmbcourse.Text & "' and Terms='" & TuiFees & "'"
            Dim tuitifees As Decimal = cmd.ExecuteScalar

            cmd.CommandText = "select ForMonth from CourseTermFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Course='" & cmbcourse.Text & "'"
            Dim ForMonth As Decimal = cmd.ExecuteScalar

            dgviewmonthly.Rows(0).Cells(0).Value = ""
            dgviewmonthly.Rows(0).Cells(1).Value = "Other Fees:"
            dgviewmonthly.Rows(0).Cells(2).Value = "0.00"

            dgviewmonthly.Rows(1).Cells(0).Value = ""
            dgviewmonthly.Rows(1).Cells(1).Value = "Discount Rate:"
            dgviewmonthly.Rows(1).Cells(2).Value = FormatNumber(disccharge.ToString())

            Dim latefees As Decimal = 0.0

            If dgviewmonthly.Rows(0).Cells(2).Value.ToString().Trim() = "" Or CDec(dgviewmonthly.Rows(0).Cells(2).Value.ToString()) <> 0.0 Then
                latefees = 0.0
            Else
                latefees = CDec(dgviewmonthly.Rows(0).Cells(2).Value.ToString())
            End If

            Dim totalamt As Decimal = latefees

            dgviewmonthly.Rows(2).Cells(0).Value = ISDDiscountFeesAccount
            dgviewmonthly.Rows(2).Cells(1).Value = "Discount:"
            If dgviewmonthly.Rows(1).Cells(2).Value.ToString().Trim() <> "" Or CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString()) <> 0.0 Then
                Dim disc As Decimal = (totalamt * CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString())) / 100
                dgviewmonthly.Rows(2).Cells(2).Value = Decimal.Round(disc, 2, MidpointRounding.AwayFromZero)
            End If

            dgviewmonthly.Rows(3).Cells(0).Value = ISDOtherFeesAccount
            dgviewmonthly.Rows(3).Cells(1).Value = "Total:"
            If dgviewmonthly.Rows(2).Cells(2).Value.ToString().Trim() <> "" Or CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString()) <> 0.0 Then
                Dim totamt As Decimal = totalamt - CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString())
                dgviewmonthly.Rows(3).Cells(2).Value = Decimal.Round(totamt, 2, MidpointRounding.AwayFromZero)
            Else
                dgviewmonthly.Rows(3).Cells(2).Value = Decimal.Round(totalamt, 2, MidpointRounding.AwayFromZero)
            End If

            txtpaid.Text = dgviewmonthly.Rows(3).Cells(2).Value.ToString()
            txtremaining.Text = "0.00"

            For i As Integer = 0 To dgviewmonthly.Rows.Count - 1
                dgviewmonthly.Rows(i).Cells(0).Style.BackColor = Color.DimGray
                dgviewmonthly.Rows(i).Cells(0).Style.ForeColor = Color.White
                dgviewmonthly.Rows(i).Cells(0).Style.SelectionBackColor = Color.DimGray
                dgviewmonthly.Rows(i).Cells(0).Style.SelectionForeColor = Color.White
                dgviewmonthly.Rows(i).Cells(1).Style.BackColor = Color.SteelBlue
                dgviewmonthly.Rows(i).Cells(1).Style.ForeColor = Color.White
                dgviewmonthly.Rows(i).Cells(1).Style.SelectionBackColor = Color.SteelBlue
                dgviewmonthly.Rows(i).Cells(1).Style.SelectionForeColor = Color.White
            Next
            dgviewmonthly.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadOtherFees(ByVal course As String, ByVal clas As String, ByVal roll As String)
        Try
            dgviewmonthly.Rows.Clear()
            dgviewmonthly.Rows.Add()
            dgviewmonthly.Rows.Add()
            dgviewmonthly.Rows.Add()
            dgviewmonthly.Rows.Add()

            Dim dt As Date = Date.Parse(cmbdate.Text)
            Dim month As Integer = dt.Month
            Dim year As Integer = dt.Year
            cmd.CommandText = "select tuition,payvia from StudentRegistration where course='" & course & "' and class='" & clas & "' and roll='" & roll & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim tuition As String = dr("tuition").ToString()
            cmbpayvia.Text = dr("payvia").ToString()
            dr.Close()
            Dim amt As Decimal = 0.0
            If tuition = "No" Then
                cmd.CommandText = "select sum(Fees) from CourseTermFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Course='" & course & "'"
                Dim totalamount As Decimal = cmd.ExecuteScalar()
                Dim TFees As String = "Tuitions Fee:"
                cmd.CommandText = "select Fees from CourseTermFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Course='" & course & "' and Terms='" & TFees & "'"
                Dim tuitionfees As Decimal = cmd.ExecuteScalar
                amt = totalamount - tuitionfees
            Else
                cmd.CommandText = "select sum(Fees) from CourseTermFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Course='" & course & "'"
                amt = cmd.ExecuteScalar()
            End If

            Dim exst As Boolean = False
            cmd.CommandText = "select discount from StudentDiscount where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and year=" & year & " and course='" & course & "' and class='" & clas & "' and roll='" & roll & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                exst = True
            Else
                exst = False
            End If
            dr.Close()
            Dim disccharge As Decimal = 0.0
            If exst = True Then
                cmd.CommandText = "select discount from StudentDiscount where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and year=" & year & " and course='" & course & "' and class='" & clas & "' and roll='" & roll & "'"
                disccharge = cmd.ExecuteScalar
            Else
                disccharge = 0.0
            End If

            Dim LibFees As String = "Library Caution Fee:"
            cmd.CommandText = "select Fees from CourseTermFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Course='" & course & "' and Terms='" & LibFees & "'"
            Dim libraryfees As Decimal = cmd.ExecuteScalar

            cmd.CommandText = "select sum(Fees) from CourseTermFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Course='" & course & "'"
            Dim totamount As Decimal = cmd.ExecuteScalar()

            Dim TuiFees As String = "Tuitions Fee:"
            cmd.CommandText = "select Fees from CourseTermFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Course='" & course & "' and Terms='" & TuiFees & "'"
            Dim tuitifees As Decimal = cmd.ExecuteScalar

            cmd.CommandText = "select ForMonth from CourseTermFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and Course='" & course & "'"
            Dim ForMonth As Decimal = cmd.ExecuteScalar

            dgviewmonthly.Rows(0).Cells(0).Value = ""
            dgviewmonthly.Rows(0).Cells(1).Value = "Other Fees:"
            dgviewmonthly.Rows(0).Cells(2).Value = "0.00"

            dgviewmonthly.Rows(1).Cells(0).Value = ""
            dgviewmonthly.Rows(1).Cells(1).Value = "Discount Rate:"
            dgviewmonthly.Rows(1).Cells(2).Value = FormatNumber(disccharge.ToString())

            Dim latefees As Decimal = 0.0

            If dgviewmonthly.Rows(0).Cells(2).Value.ToString().Trim() = "" Or CDec(dgviewmonthly.Rows(0).Cells(2).Value.ToString()) <> 0.0 Then
                latefees = 0.0
            Else
                latefees = CDec(dgviewmonthly.Rows(0).Cells(2).Value.ToString())
            End If

            Dim totalamt As Decimal = latefees

            dgviewmonthly.Rows(2).Cells(0).Value = ISDDiscountFeesAccount
            dgviewmonthly.Rows(2).Cells(1).Value = "Discount:"
            If dgviewmonthly.Rows(1).Cells(2).Value.ToString().Trim() <> "" Or CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString()) <> 0.0 Then
                Dim disc As Decimal = (totalamt * CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString())) / 100
                dgviewmonthly.Rows(2).Cells(2).Value = Decimal.Round(disc, 2, MidpointRounding.AwayFromZero)
            End If

            dgviewmonthly.Rows(3).Cells(0).Value = ISDOtherFeesAccount
            dgviewmonthly.Rows(3).Cells(1).Value = "Total:"
            If dgviewmonthly.Rows(2).Cells(2).Value.ToString().Trim() <> "" Or CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString()) <> 0.0 Then
                Dim totamt As Decimal = totalamt - CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString())
                dgviewmonthly.Rows(3).Cells(2).Value = Decimal.Round(totamt, 2, MidpointRounding.AwayFromZero)
            Else
                dgviewmonthly.Rows(3).Cells(2).Value = Decimal.Round(totalamt, 2, MidpointRounding.AwayFromZero)
            End If

            txtpaid.Text = dgviewmonthly.Rows(3).Cells(2).Value.ToString()
            txtremaining.Text = "0.00"

            For i As Integer = 0 To dgviewmonthly.Rows.Count - 1
                dgviewmonthly.Rows(i).Cells(0).Style.BackColor = Color.DimGray
                dgviewmonthly.Rows(i).Cells(0).Style.ForeColor = Color.White
                dgviewmonthly.Rows(i).Cells(0).Style.SelectionBackColor = Color.DimGray
                dgviewmonthly.Rows(i).Cells(0).Style.SelectionForeColor = Color.White
                dgviewmonthly.Rows(i).Cells(1).Style.BackColor = Color.SteelBlue
                dgviewmonthly.Rows(i).Cells(1).Style.ForeColor = Color.White
                dgviewmonthly.Rows(i).Cells(1).Style.SelectionBackColor = Color.SteelBlue
                dgviewmonthly.Rows(i).Cells(1).Style.SelectionForeColor = Color.White
            Next
            dgviewmonthly.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadStudentDetails(ByVal stid As String)
        Try
            dgviewbankinfo.Rows.Add()
            dgviewbankinfo.Rows.Add()
            dgviewbankinfo.Rows.Add()
            dgviewbankinfo.Rows.Add()
            dgviewbankinfo.Rows.Add()
            dgviewbankinfo.Rows.Add()
            dgviewbankinfo.Rows.Add()
            dgviewbankinfo.Rows.Add()
            dgviewbankinfo.Rows.Add()
            dgviewbankinfo.Rows(0).Cells(0).Value = "Payee Name:"
            dgviewbankinfo.Rows(1).Cells(0).Value = "Bank Name:"
            dgviewbankinfo.Rows(2).Cells(0).Value = "Bank Branch:"
            dgviewbankinfo.Rows(3).Cells(0).Value = "Branch Address:"
            dgviewbankinfo.Rows(4).Cells(0).Value = "Branch Code:"
            dgviewbankinfo.Rows(5).Cells(0).Value = "Bank Account No:"
            dgviewbankinfo.Rows(6).Cells(0).Value = "Account Type:"
            dgviewbankinfo.Rows(7).Cells(0).Value = "MICR Code:"
            dgviewbankinfo.Rows(8).Cells(0).Value = "Mode of Elec Trans:"

            cmd.CommandText = "select name,time,payvia,cardaddress,cardcity,cardcountry,cardholdername,cardno,cardpin,cardstate,expmm,expyy,cardtype,payeename,bankname,bankbrach,branchaddress,branchcode,accountno,accounttype,micrcode,electronictransfer from StudentRegistration where stuid='" & stid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                txtname.Text = dr("name").ToString()
                txttime.Text = dr("time").ToString()
                cmbpayvia.Text = dr("payvia").ToString()
                txtcardaddress.Text = dr("cardaddress").ToString()
                txtcardcity.Text = dr("cardcity").ToString()
                txtcardcountry.Text = dr("cardcountry").ToString()
                txtcardholdername.Text = dr("cardholdername").ToString()
                txtcardno.Text = dr("cardno").ToString()
                txtcardpin.Text = dr("cardpin").ToString()
                txtcardstate.Text = dr("cardstate").ToString()
                txtexpmm.Text = dr("expmm").ToString()
                txtexpyy.Text = dr("expyy").ToString()
                txtcardtype.Text = dr("cardtype").ToString()
                dgviewbankinfo.Rows(0).Cells(1).Value = dr("payeename").ToString()
                dgviewbankinfo.Rows(1).Cells(1).Value = dr("bankname").ToString()
                dgviewbankinfo.Rows(2).Cells(1).Value = dr("bankbrach").ToString()
                dgviewbankinfo.Rows(3).Cells(1).Value = dr("branchaddress").ToString()
                dgviewbankinfo.Rows(4).Cells(1).Value = dr("branchcode").ToString()
                dgviewbankinfo.Rows(5).Cells(1).Value = dr("accountno").ToString()
                dgviewbankinfo.Rows(6).Cells(1).Value = dr("accounttype").ToString()
                dgviewbankinfo.Rows(7).Cells(1).Value = dr("micrcode").ToString()
                dgviewbankinfo.Rows(8).Cells(1).Value = dr("electronictransfer").ToString()
            End If
            dr.Close()
            For i As Integer = 0 To dgviewbankinfo.Rows.Count - 1
                dgviewbankinfo.Rows(i).Cells(0).Style.BackColor = Color.SteelBlue
                dgviewbankinfo.Rows(i).Cells(0).Style.ForeColor = Color.White
                dgviewbankinfo.Rows(i).Cells(0).Style.SelectionBackColor = Color.SteelBlue
                dgviewbankinfo.Rows(i).Cells(0).Style.SelectionForeColor = Color.White
            Next
            dgviewbankinfo.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadStudentDetails(ByVal course As String, ByVal clas As String, ByVal roll As String)
        Try
            dgviewbankinfo.Rows.Add()
            dgviewbankinfo.Rows.Add()
            dgviewbankinfo.Rows.Add()
            dgviewbankinfo.Rows.Add()
            dgviewbankinfo.Rows.Add()
            dgviewbankinfo.Rows.Add()
            dgviewbankinfo.Rows.Add()
            dgviewbankinfo.Rows.Add()
            dgviewbankinfo.Rows.Add()
            dgviewbankinfo.Rows(0).Cells(0).Value = "Payee Name:"
            dgviewbankinfo.Rows(1).Cells(0).Value = "Bank Name:"
            dgviewbankinfo.Rows(2).Cells(0).Value = "Bank Branch:"
            dgviewbankinfo.Rows(3).Cells(0).Value = "Branch Address:"
            dgviewbankinfo.Rows(4).Cells(0).Value = "Branch Code:"
            dgviewbankinfo.Rows(5).Cells(0).Value = "Bank Account No:"
            dgviewbankinfo.Rows(6).Cells(0).Value = "Account Type:"
            dgviewbankinfo.Rows(7).Cells(0).Value = "MICR Code:"
            dgviewbankinfo.Rows(8).Cells(0).Value = "Mode of Elec Trans:"

            cmd.CommandText = "select stuid,name,time,payvia,cardaddress,cardcity,cardcountry,cardholdername,cardno,cardpin,cardstate,expmm,expyy,cardtype,payeename,bankname,bankbrach,branchaddress,branchcode,accountno,accounttype,micrcode,electronictransfer from StudentRegistration where course='" & course & "' and class='" & clas & "' and roll='" & roll & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                StuID = dr("stuid").ToString()
                txtname.Text = dr("name").ToString()
                txttime.Text = dr("time").ToString()
                cmbpayvia.Text = dr("payvia").ToString()
                txtcardaddress.Text = dr("cardaddress").ToString()
                txtcardcity.Text = dr("cardcity").ToString()
                txtcardcountry.Text = dr("cardcountry").ToString()
                txtcardholdername.Text = dr("cardholdername").ToString()
                txtcardno.Text = dr("cardno").ToString()
                txtcardpin.Text = dr("cardpin").ToString()
                txtcardstate.Text = dr("cardstate").ToString()
                txtexpmm.Text = dr("expmm").ToString()
                txtexpyy.Text = dr("expyy").ToString()
                txtcardtype.Text = dr("cardtype").ToString()
                dgviewbankinfo.Rows(0).Cells(1).Value = dr("payeename").ToString()
                dgviewbankinfo.Rows(1).Cells(1).Value = dr("bankname").ToString()
                dgviewbankinfo.Rows(2).Cells(1).Value = dr("bankbrach").ToString()
                dgviewbankinfo.Rows(3).Cells(1).Value = dr("branchaddress").ToString()
                dgviewbankinfo.Rows(4).Cells(1).Value = dr("branchcode").ToString()
                dgviewbankinfo.Rows(5).Cells(1).Value = dr("accountno").ToString()
                dgviewbankinfo.Rows(6).Cells(1).Value = dr("accounttype").ToString()
                dgviewbankinfo.Rows(7).Cells(1).Value = dr("micrcode").ToString()
                dgviewbankinfo.Rows(8).Cells(1).Value = dr("electronictransfer").ToString()
            End If
            dr.Close()
            For i As Integer = 0 To dgviewbankinfo.Rows.Count - 1
                dgviewbankinfo.Rows(i).Cells(0).Style.BackColor = Color.SteelBlue
                dgviewbankinfo.Rows(i).Cells(0).Style.ForeColor = Color.White
                dgviewbankinfo.Rows(i).Cells(0).Style.SelectionBackColor = Color.SteelBlue
                dgviewbankinfo.Rows(i).Cells(0).Style.SelectionForeColor = Color.White
            Next
            dgviewbankinfo.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub LoadClass()
        Try
            cmbclass.Items.Clear()
            cmd.CommandText = "select distinct(class) from StudentRegistration where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                cmbclass.Items.Add(dr("class").ToString())
            End While
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CheckPaid()
        Try
            Dim dt As Date = Date.Parse(cmbdate.Text)
            Dim month As Integer = dt.Month
            Dim year As Integer = dt.Year
            cmd.CommandText = "select paid from OtherFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and date='" & cmbdate.Text & "' and month=" & month & " and year=" & year & " and course='" & cmbcourse.Text & "' and regno='" & StuID & "' and name='" & txtname.Text & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                If dr("paid").ToString().ToUpper() <> "PAID" Then
                    lblpaid.Text = "Unpaid"
                    lblpaid.ForeColor = Color.Red
                    lblpaid.Visible = True
                Else
                    lblpaid.Text = "Paid"
                    lblpaid.ForeColor = Color.Green
                    lblpaid.Visible = True
                End If
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub AddRecord()
        Try
            If cmbcourse.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter course.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbcourse.Focus()
                End If
            ElseIf cmbroll.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbroll.Focus()
                End If
            ElseIf txtpaid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter paid amount.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtpaid.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    CheckTokenNo()
                    If TokenExist = False Then
                        Dim cls As New cOtherFees()
                        Dim paid As String = ""
                        If CDec(dgviewmonthly.Rows(3).Cells(2).Value.ToString()) <= CDec(txtpaid.Text) Then
                            paid = "Paid"
                        Else
                            paid = "Unpaid"
                        End If
                        Dim otherrs As Decimal = 0.0
                        Dim discch As Decimal = 0.0
                        Dim disc As Decimal = 0.0
                        Dim totamt As Decimal = 0.0
                        Dim paidamt As Decimal = 0.0
                        Dim remainingamt As Decimal = 0.0
                        If CDec(dgviewmonthly.Rows(0).Cells(2).Value.ToString().Trim()) = 0.0 Then
                            otherrs = 0.0
                        Else
                            otherrs = CDec(dgviewmonthly.Rows(0).Cells(2).Value.ToString())
                        End If
                        If CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString()) = 0.0 Then
                            discch = 0.0
                        Else
                            discch = CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString())
                        End If
                        If CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString()) = 0.0 Then
                            disc = 0.0
                        Else
                            disc = CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString())
                        End If
                        If CDec(dgviewmonthly.Rows(3).Cells(2).Value.ToString()) = 0.0 Then
                            totamt = 0.0
                        Else
                            totamt = CDec(dgviewmonthly.Rows(3).Cells(2).Value.ToString())
                        End If
                        If txtpaid.Text.Trim() = "" Then
                            paidamt = 0.0
                        Else
                            paidamt = CDec(txtpaid.Text)
                        End If
                        remainingamt = totamt - paidamt
                        Dim dt As Date = CDate(cmbdate.Text)
                        Dim month As Integer = dt.Month
                        Dim year As Integer = dt.Year
                        cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, cmbdate.Text, month, year, cmbcourse.Text, cmbclass.Text, cmbroll.Text, StuID, txtname.Text, txttime.Text, cmbpayvia.Text, txtreason.Text, otherrs, discch, disc, totamt, paidamt, remainingamt, paid)
                        If cls.AddOtherFeesOk = True Then
                            Dim description As String = "Other Fees"
                            Dim type As String = "Income"
                            cmd.CommandText = "insert into IncomeExpenditure(InsID,InsName,Period,SystemDate,transactionid,descriptions,type,amount,class,roll,regno,name,month,year,account) values ('" & My.Settings.LastOpenedInstituteID & "','" & My.Settings.LastOpenedInstitute & "','" & My.Settings.Period & "','" & UmbrellaSystemDate & "','" & txttoken.Text & "','" & description & "','" & type & "'," & paidamt & ",'" & cmbclass.Text & "','" & cmbroll.Text & "','" & StuID & "','" & txtname.Text & "'," & month & "," & year & ",'" & ISDOtherFeesAccount & "')"
                            dr = cmd.ExecuteReader
                            dr.Close()
                            AddDiscount()
                            cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & CDec(txtpaid.Text) & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDOtherFeesAccount & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                            Dim result1 As DialogResult = MessageBox.Show("Record added successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = Windows.Forms.DialogResult.OK Then
                                CheckPaid()
                                cmbroll.Focus()
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Token no. already exist" + Environment.NewLine + "Please enter a new token no.", "Umbrella - Duplicate Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            txtpaid.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub AddDiscount()
        Try
            Dim cls As New cDiscount()
            Dim totalamt As Decimal = 0.0
            Dim discch As Decimal = 0.0
            Dim disc As Decimal = 0.0
            Dim remaining As Decimal = 0.0
            Dim appliedfor As String = "Student"
            Dim authentication As String = ""
            Dim remarks As String = ""
            If dgviewmonthly.Rows(3).Cells(2).Value.ToString().Trim() = "" Then
                totalamt = 0.0
            Else
                totalamt = CDec(dgviewmonthly.Rows(3).Cells(2).Value.ToString())
            End If
            If dgviewmonthly.Rows(1).Cells(2).Value.ToString().Trim() = "" Then
                discch = 0.0
            Else
                discch = CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString())
            End If
            If dgviewmonthly.Rows(2).Cells(2).Value.ToString().Trim() = "" Then
                disc = 0.0
            Else
                disc = CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString())
            End If
            Dim dt As Date = CDate(cmbdate.Text)
            Dim month As Integer = dt.Month
            Dim year As Integer = dt.Year
            cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, cmbdate.Text, month, year, appliedfor, cmbclass.Text, cmbroll.Text, StuID, txtname.Text, totalamt, discch, disc, disc, cmbpayvia.Text, authentication, remarks, ISDDiscountFeesAccount)
            If cls.AddDiscountOk = False Then
                MsgBox("Cannot add discount")
            Else
                cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString()) & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDDiscountFeesAccount & "'"
                dr = cmd.ExecuteReader
                dr.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If cmbcourse.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter course.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbcourse.Focus()
                End If
            ElseIf cmbroll.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbroll.Focus()
                End If
            ElseIf txtpaid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter paid amount.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtpaid.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cOtherFees()
                    Dim paid As String = ""
                    If CDec(dgviewmonthly.Rows(3).Cells(2).Value.ToString()) <= CDec(txtpaid.Text) Then
                        paid = "Paid"
                    Else
                        paid = "Unpaid"
                    End If
                    Dim otherrs As Decimal = 0.0
                    Dim discch As Decimal = 0.0
                    Dim disc As Decimal = 0.0
                    Dim totamt As Decimal = 0.0
                    Dim paidamt As Decimal = 0.0
                    Dim remainingamt As Decimal = 0.0
                    If dgviewmonthly.Rows(0).Cells(2).Value.ToString().Trim() = "" Then
                        otherrs = 0.0
                    Else
                        otherrs = CDec(dgviewmonthly.Rows(0).Cells(2).Value.ToString())
                    End If
                    If dgviewmonthly.Rows(1).Cells(2).Value.ToString().Trim() = "" Then
                        discch = 0.0
                    Else
                        discch = CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString())
                    End If
                    If dgviewmonthly.Rows(2).Cells(2).Value.ToString().Trim() = "" Then
                        disc = 0.0
                    Else
                        disc = CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString())
                    End If
                    If dgviewmonthly.Rows(3).Cells(2).Value.ToString().Trim() = "" Then
                        totamt = 0.0
                    Else
                        totamt = CDec(dgviewmonthly.Rows(3).Cells(2).Value.ToString())
                    End If
                    If txtpaid.Text.Trim() = "" Then
                        paidamt = 0.0
                    Else
                        paidamt = CDec(txtpaid.Text)
                    End If
                    remainingamt = totamt - paidamt
                    Dim dt As Date = CDate(cmbdate.Text)
                    Dim month As Integer = dt.Month
                    Dim year As Integer = dt.Year
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, cmbdate.Text, month, year, cmbcourse.Text, cmbclass.Text, cmbroll.Text, StuID, txtname.Text, txttime.Text, cmbpayvia.Text, txtreason.Text, otherrs, discch, disc, totamt, paidamt, remainingamt, paid)
                    If cls.UpdateOtherFeesOk = True Then
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & TotalPaid & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDOtherFeesAccount & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & Discount & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDDiscountFeesAccount & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & CDec(txtpaid.Text) & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDOtherFeesAccount & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        Dim description As String = "Other Fees"
                        Dim type As String = "Income"
                        cmd.CommandText = "update IncomeExpenditure set SystemDate='" & UmbrellaSystemDate & "',amount=" & paidamt & ",class='" & cmbclass.Text & "',roll='" & cmbroll.Text & "',regno='" & StuID & "',name='" & txtname.Text & "',month=" & month & ",year=" & year & ",account='" & ISDOtherFeesAccount & "' where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and transactionid='" & txttoken.Text & "' and descriptions='" & description & "' and type='" & type & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        UpdateDiscount()
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            CheckPaid()
                            cmbroll.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub UpdateDiscount()
        Try
            Dim cls As New cDiscount()
            Dim totalamt As Decimal = 0.0
            Dim discch As Decimal = 0.0
            Dim disc As Decimal = 0.0
            Dim remaining As Decimal = 0.0
            Dim appliedfor As String = "Student"
            Dim authentication As String = ""
            Dim remarks As String = ""
            If dgviewmonthly.Rows(3).Cells(2).Value.ToString().Trim() = "" Then
                totalamt = 0.0
            Else
                totalamt = CDec(dgviewmonthly.Rows(3).Cells(2).Value.ToString())
            End If
            If dgviewmonthly.Rows(1).Cells(2).Value.ToString().Trim() = "" Then
                discch = 0.0
            Else
                discch = CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString())
            End If
            If dgviewmonthly.Rows(2).Cells(2).Value.ToString().Trim() = "" Then
                disc = 0.0
            Else
                disc = CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString())
            End If
            Dim dt As Date = CDate(cmbdate.Text)
            Dim month As Integer = dt.Month
            Dim year As Integer = dt.Year
            cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, cmbdate.Text, month, year, appliedfor, cmbclass.Text, cmbroll.Text, StuID, txtname.Text, totalamt, discch, disc, CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString()), cmbpayvia.Text, authentication, remarks, ISDDiscountFeesAccount)
            If cls.UpdateDiscountOk = False Then
                MsgBox("Cannot update discount")
            Else
                cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString()) & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDDiscountFeesAccount & "'"
                dr = cmd.ExecuteReader
                dr.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If cmbcourse.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter course.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbcourse.Focus()
                End If
            ElseIf cmbroll.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbroll.Focus()
                End If
            ElseIf txtpaid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter paid amount.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtpaid.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Missing Value", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim otherrs As Decimal = 0.0
                    Dim disc As Decimal = 0.0
                    If dgviewmonthly.Rows(0).Cells(2).Value.ToString().Trim() = "" Then
                        otherrs = 0.0
                    Else
                        otherrs = CDec(dgviewmonthly.Rows(0).Cells(2).Value.ToString())
                    End If
                    If dgviewmonthly.Rows(2).Cells(2).Value.ToString().Trim() = "" Then
                        disc = 0.0
                    Else
                        disc = CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString())
                    End If
                    Dim dt As Date = Date.Parse(cmbdate.Text)
                    Dim month As Integer = dt.Month
                    Dim year As Integer = dt.Year
                    Dim cls As New cOtherFees()
                    Dim paid As String = "Paid"
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, cmbdate.Text, month, year, cmbcourse.Text, cmbclass.Text, cmbroll.Text, StuID, txtname.Text)
                    If cls.DeleteOtherFeesOk = True Then
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & TotalPaid & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDOtherFeesAccount & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & Discount & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDDiscountFeesAccount & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        Dim description As String = "Other Fees"
                        Dim type As String = "Income"
                        cmd.CommandText = "delete from IncomeExpenditure where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and transactionid='" & txttoken.Text & "' and descriptions='" & description & "' and type='" & type & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        DeleteDiscount()
                        Dim result1 As DialogResult = MessageBox.Show("Record deleted successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            ResetForm()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub DeleteDiscount()
        Try
            Dim dt As Date = Date.Parse(cmbdate.Text)
            Dim month As Integer = dt.Month
            Dim year As Integer = dt.Year
            Dim cls As New cDiscount()
            cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, cmbdate.Text, month, year, StuID, txtname.Text, cmbclass.Text, cmbroll.Text)
            If cls.DeleteDiscountOk = False Then
                MsgBox("Cannot delete discount.")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetForm()
        updatemonthlyfees = False
        lblpaid.Visible = False
        dgviewbankinfo.Rows.Clear()
        dgviewmonthly.Rows.Clear()
        ETabControl1.SelectTab(TabPage1)
        cmbdate.Text = UmbrellaSystemDate
        cmbpayvia.Text = ""
        cmbroll.Text = ""
        txtcardaddress.Text = ""
        txtcardcity.Text = ""
        txtcardcountry.Text = ""
        txtcardholdername.Text = ""
        txtcardno.Text = ""
        txtcardpin.Text = ""
        txtcardstate.Text = ""
        txtcardtype.Text = ""
        txtexpmm.Text = ""
        txtexpyy.Text = ""
        txtname.Text = ""
        txtpaid.Text = ""
        txtremaining.Text = ""
        txttime.Text = ""
        If ISDAutoID = "Yes" Then
            GetCode()
        Else
            txttoken.Text = ""
        End If
        cmbcourse.Focus()
    End Sub

    Private Sub LoadSelectedRecord()
        Try
            Dim dt As String = ""
            Dim token As String = ""
            Dim clas As String = ""
            Dim course As String = ""
            Dim reg As String = ""
            Dim roll As String = ""
            Dim payvia As String = ""

            dgviewmonthly.Rows.Clear()
            dgviewmonthly.Rows.Add()
            dgviewmonthly.Rows.Add()
            dgviewmonthly.Rows.Add()
            dgviewmonthly.Rows.Add()
            cmd.CommandText = "select * from OtherFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and regno='" & StuID & "' and date='" & otherdate & "' and totalamt=" & otheramount & " and transactionid='" & transactionid & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                dt = dr("date").ToString()
                token = dr("transactionid").ToString()
                course = dr("course").ToString()
                clas = dr("class").ToString()
                reg = dr("regno").ToString()
                roll = dr("roll").ToString()
                txtname.Text = dr("name").ToString()
                txttime.Text = dr("time").ToString()
                payvia = dr("payvia").ToString()
                txtreason.Text = dr("reason").ToString()
                Dim otherrs As Decimal = CDec(dr("otherrs").ToString())
                dgviewmonthly.Rows(0).Cells(0).Value = ""
                dgviewmonthly.Rows(0).Cells(1).Value = "Other Fees:"
                dgviewmonthly.Rows(0).Cells(2).Value = FormatNumber(otherrs.ToString())
                OtherFee = otherrs
                Dim discch As Decimal = CDec(dr("discountcharge").ToString())
                dgviewmonthly.Rows(1).Cells(0).Value = ""
                dgviewmonthly.Rows(1).Cells(1).Value = "Discount Rate:"
                dgviewmonthly.Rows(1).Cells(2).Value = FormatNumber(discch.ToString())
                Dim disc As Decimal = CDec(dr("discount").ToString())
                dgviewmonthly.Rows(2).Cells(1).Value = "Discount:"
                dgviewmonthly.Rows(2).Cells(2).Value = FormatNumber(disc.ToString())
                Discount = disc
                Dim amt As Decimal = CDec(dr("totalamt").ToString())
                dgviewmonthly.Rows(3).Cells(0).Value = ISDOtherFeesAccount
                dgviewmonthly.Rows(3).Cells(1).Value = "Total:"
                dgviewmonthly.Rows(3).Cells(2).Value = FormatNumber(amt.ToString())

                txtpaid.Text = dr("pay").ToString()
                txtremaining.Text = dr("remaining").ToString()
                TotalPaid = CDec(txtpaid.Text)

            End If
            dr.Close()
            cmbdate.Text = dt
            txttoken.Text = token
            StuID = reg
            cmbcourse.Text = course
            cmbclass.Text = clas
            cmbroll.Text = roll
            LoadStudentDetails(course, clas, roll)
            cmbpayvia.Text = payvia
            CheckPaid()

            For i As Integer = 0 To dgviewmonthly.Rows.Count - 1
                dgviewmonthly.Rows(i).Cells(0).Style.BackColor = Color.DimGray
                dgviewmonthly.Rows(i).Cells(0).Style.ForeColor = Color.White
                dgviewmonthly.Rows(i).Cells(0).Style.SelectionBackColor = Color.DimGray
                dgviewmonthly.Rows(i).Cells(0).Style.SelectionForeColor = Color.White
                dgviewmonthly.Rows(i).Cells(1).Style.BackColor = Color.SteelBlue
                dgviewmonthly.Rows(i).Cells(1).Style.ForeColor = Color.White
                dgviewmonthly.Rows(i).Cells(1).Style.SelectionBackColor = Color.SteelBlue
                dgviewmonthly.Rows(i).Cells(1).Style.SelectionForeColor = Color.White
            Next
            dgviewmonthly.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CheckTokenNo()
        Try
            cmd.CommandText = "select * from OtherFees where transactionid='" & txttoken.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                TokenExist = True
            Else
                TokenExist = False
            End If
            dr.Close()
        Catch ex As Exception
            TokenExist = False
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Attributes..."
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
            If cmbclass.Text <> "" And cmbcourse.Text <> "" And cmbroll.Text <> "" Then
                LoadOtherFees(cmbcourse.Text, cmbclass.Text, cmbroll.Text)
                LoadStudentDetails(cmbcourse.Text, cmbclass.Text, cmbroll.Text)
                CheckPaid()
            End If
            txtname.Focus()
        End If
    End Sub

    Private Sub cmbcourse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcourse.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbclass.Focus()
        End If
    End Sub

    Private Sub cmbcourse_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbcourse.TextChanged
        If cmbcourse.Text <> "" Then
            LoadClass()
        End If
    End Sub

    Private Sub txtname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txttime.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbroll.Focus()
        End If
    End Sub

    Private Sub txttime_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttime.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txttoken.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtname.Focus()
        End If
    End Sub

    Private Sub txttoken_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttoken.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbdate.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txttime.Focus()
        End If
    End Sub

    Private Sub cmbdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            dgviewmonthly.Focus()
        End If
    End Sub

    Private Sub txtpaid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpaid.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtremaining.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            dgviewmonthly.Focus()
        End If
    End Sub

    Private Sub txtremaining_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtremaining.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbpayvia.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtpaid.Focus()
        End If
    End Sub

    Private Sub cmbpayvia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbpayvia.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtreason.Focus()
        End If
    End Sub

    Private Sub txtcardholdername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcardholdername.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtcardaddress.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            dgviewbankinfo.Focus()
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
            txtcardno.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcardpin.Focus()
        End If
    End Sub

    Private Sub txtcardno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcardno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtexpmm.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtcardcountry.Focus()
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
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtcardtype.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtexpmm.Focus()
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updateotherfees = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updateotherfees = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updateotherfees = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updateotherfees = False Then
            ControlSetBound()
            LoadCourse()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
            cmbdate.Text = UmbrellaSystemDate
            cmbpayvia.Items.Add(New ComboBoxIconItem("Cash", 0))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Check", 1))
        Else
            ControlSetBound()
            LoadCourse()
            cmbpayvia.Items.Add(New ComboBoxIconItem("Cash", 0))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Check", 1))
            LoadSelectedRecord()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub

    Private Sub btnremaining_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnremaining.ClickButtonArea
        Try
            Dim total As Decimal = CDec(dgviewmonthly.Rows(3).Cells(2).Value.ToString())
            txtremaining.Text = (total - CDec(txtpaid.Text)).ToString()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "DGViewEvents..."
    Private Sub dgviewmonthly_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgviewmonthly.CellEndEdit
        If e.ColumnIndex = 2 Then
            Dim i As Integer = dgviewmonthly.CurrentRow.Index
            If dgviewmonthly.Rows(i).Cells(2).Value.ToString() = "" Then
                dgviewmonthly.Rows(i).Cells(2).Value = "0.00"
                Dim val As Decimal = CDec(dgviewmonthly.Rows(i).Cells(2).Value.ToString())
                dgviewmonthly.Rows(i).Cells(2).Value = FormatNumber(val.ToString())
                Dim late As Decimal = CDec(dgviewmonthly.Rows(0).Cells(2).Value.ToString())
                Dim discch As Decimal = CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString())
                Dim total As Decimal = late
                Dim disc As Decimal = (total * discch) / 100
                dgviewmonthly.Rows(2).Cells(2).Value = FormatNumber(disc.ToString())
                total = total - disc
                dgviewmonthly.Rows(3).Cells(2).Value = FormatNumber(total.ToString())
                txtpaid.Text = total.ToString()
                txtremaining.Text = "0.00"
            Else
                Dim val As Decimal = CDec(dgviewmonthly.Rows(i).Cells(2).Value.ToString())
                dgviewmonthly.Rows(i).Cells(2).Value = FormatNumber(val.ToString())
                Dim late As Decimal = CDec(dgviewmonthly.Rows(0).Cells(2).Value.ToString())
                Dim discch As Decimal = CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString())
                Dim total As Decimal = late
                Dim disc As Decimal = (total * discch) / 100
                dgviewmonthly.Rows(2).Cells(2).Value = FormatNumber(disc.ToString())
                total = total - disc
                dgviewmonthly.Rows(3).Cells(2).Value = FormatNumber(total.ToString())
                txtpaid.Text = total.ToString()
                txtremaining.Text = "0.00"
            End If

        End If
    End Sub

    Private Sub dgviewmonthly_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgviewmonthly.LostFocus
        dgviewmonthly.ClearSelection()
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmOtherFees_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updateotherfees = False Then
            ControlSetBound()
            LoadCourse()
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
            cmbdate.Text = UmbrellaSystemDate
            cmbpayvia.Items.Add(New ComboBoxIconItem("Cash", 0))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Check", 1))
        Else
            ControlSetBound()
            LoadCourse()
            cmbpayvia.Items.Add(New ComboBoxIconItem("Cash", 0))
            cmbpayvia.Items.Add(New ComboBoxIconItem("Check", 1))
            LoadSelectedRecord()
        End If
        If USfeescollection = "View Only" Then
            btndelete.Enabled = False
            btnremaining.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbclass.Enabled = False
            cmbcourse.Enabled = False
            cmbdate.Enabled = False
            cmbpayvia.Enabled = False
            cmbroll.Enabled = False
            txtcardaddress.ReadOnly = True
            txtcardcity.ReadOnly = True
            txtcardcountry.ReadOnly = True
            txtcardholdername.ReadOnly = True
            txtcardno.ReadOnly = True
            txtcardpin.ReadOnly = True
            txtcardstate.ReadOnly = True
            txtcardtype.ReadOnly = True
            txtexpmm.ReadOnly = True
            txtexpyy.ReadOnly = True
            txtname.ReadOnly = True
            txtpaid.ReadOnly = True
            txtremaining.ReadOnly = True
            txttime.ReadOnly = True
            txttoken.ReadOnly = False
            dgviewbankinfo.Enabled = False
            dgviewmonthly.Enabled = False
        End If
        If USstudentcard = "No Access" Then
            txtcardaddress.ReadOnly = True
            txtcardcity.ReadOnly = True
            txtcardcountry.ReadOnly = True
            txtcardholdername.ReadOnly = True
            txtcardno.ReadOnly = True
            txtcardpin.ReadOnly = True
            txtcardstate.ReadOnly = True
            txtcardtype.ReadOnly = True
            txtexpmm.ReadOnly = True
            txtexpyy.ReadOnly = True
            txtcardaddress.UseSystemPasswordChar = True
            txtcardcity.UseSystemPasswordChar = True
            txtcardcountry.UseSystemPasswordChar = True
            txtcardholdername.UseSystemPasswordChar = True
            txtcardno.UseSystemPasswordChar = True
            txtcardpin.UseSystemPasswordChar = True
            txtcardstate.UseSystemPasswordChar = True
            txtcardtype.UseSystemPasswordChar = True
            txtexpmm.UseSystemPasswordChar = True
            txtexpyy.UseSystemPasswordChar = True
        End If
    End Sub
#End Region
End Class
#End Region