﻿#Region "Imports"
Imports ESAR_Controls.UIControls.ComboBox
#End Region
#Region "Class frmYearlyFees..."
Public Class frmYearlyFees
#Region "Declarations..."
    Private ACODE As String = ""
    Private TT As String = ""
    Private DGVRegNo As New DataGridView()
    Private DGVCourse As New DataGridView()
    Private DGVAccount As New DataGridView()
    Private TotalPaid As Decimal = 0.0
    Private YearlyFee As Decimal = 0.0
    Private LibraryFee As Decimal = 0.0
    Private LateFee As Decimal = 0.0
    Private OtherFee As Decimal = 0.0
    Private Discount As Decimal = 0.0
    Private TokenExist As Boolean = False
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        ACODE = Indx.LoadYearlyID()
        Dim var As String
        var = CodeIncrement(ACODE)
        Me.txttoken.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("YRF:{0:00000000}", Temp)
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
            txtname.Text = DGVRegNo.Rows(k).Cells(2).Value.ToString()
            cmbroll.Text = roll
            LoadYearlyFees(StuID)
            LoadStudentDetails(StuID)
            CheckPaid()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadYearlyFees(ByVal StId As String)
        Try
            dgviewmonthly.Rows.Clear()
            dgviewmonthly.Rows.Add()
            dgviewmonthly.Rows.Add()
            dgviewmonthly.Rows.Add()
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

            Dim mfees As Decimal = amt
            Dim librfees As Decimal = libraryfees
            Dim monthlyrs As Decimal = Decimal.Round(mfees, 2, MidpointRounding.AwayFromZero)

            dgviewmonthly.Rows(0).Cells(0).Value = ""
            dgviewmonthly.Rows(0).Cells(1).Value = "Yearly Fees:"
            dgviewmonthly.Rows(0).Cells(2).Value = FormatNumber(monthlyrs.ToString())

            dgviewmonthly.Rows(1).Cells(0).Value = ISDLibraryFeesAccount
            dgviewmonthly.Rows(1).Cells(1).Value = "Library Fees:"
            dgviewmonthly.Rows(1).Cells(2).Value = FormatNumber(librfees.ToString())

            dgviewmonthly.Rows(2).Cells(0).Value = ISDLateFeesAccount
            dgviewmonthly.Rows(2).Cells(1).Value = "Late Fees:"
            dgviewmonthly.Rows(2).Cells(2).Value = "0.00"

            dgviewmonthly.Rows(3).Cells(0).Value = ISDOtherFeesAccount
            dgviewmonthly.Rows(3).Cells(1).Value = "Other Fees:"
            dgviewmonthly.Rows(3).Cells(2).Value = "0.00"

            dgviewmonthly.Rows(4).Cells(0).Value = ""
            dgviewmonthly.Rows(4).Cells(1).Value = "Discount Rate:"
            dgviewmonthly.Rows(4).Cells(2).Value = FormatNumber(disccharge.ToString())

            Dim latefees As Decimal = 0.0
            Dim monrs As Decimal = 0.0
            Dim otherrs As Decimal = 0.0
            Dim librs As Decimal = 0.0

            If dgviewmonthly.Rows(2).Cells(2).Value.ToString().Trim() = "" Or CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString()) <> 0.0 Then
                latefees = 0.0
            Else
                latefees = CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString())
            End If


            If dgviewmonthly.Rows(0).Cells(2).Value.ToString().Trim() <> "" Or CDec(dgviewmonthly.Rows(0).Cells(2).Value.ToString()) <> 0.0 Then
                monrs = CDec(dgviewmonthly.Rows(0).Cells(2).Value.ToString())
            Else
                monrs = 0.0
            End If

            If dgviewmonthly.Rows(3).Cells(2).Value.ToString().Trim() <> "" Or CDec(dgviewmonthly.Rows(3).Cells(2).Value.ToString()) <> 0.0 Then
                otherrs = CDec(dgviewmonthly.Rows(3).Cells(2).Value.ToString())
            Else
                otherrs = 0.0
            End If

            If dgviewmonthly.Rows(1).Cells(2).Value.ToString().Trim() <> "" Or CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString()) <> 0.0 Then
                librs = CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString())
            Else
                librs = 0.0
            End If

            Dim totalamt As Decimal = monrs + otherrs + latefees + librs

            dgviewmonthly.Rows(5).Cells(0).Value = ISDDiscountFeesAccount
            dgviewmonthly.Rows(5).Cells(1).Value = "Discount:"
            If dgviewmonthly.Rows(4).Cells(2).Value.ToString().Trim() <> "" Or CDec(dgviewmonthly.Rows(4).Cells(2).Value.ToString()) <> 0.0 Then
                Dim disc As Decimal = (totalamt * CDec(dgviewmonthly.Rows(4).Cells(2).Value.ToString())) / 100
                dgviewmonthly.Rows(5).Cells(2).Value = Decimal.Round(disc, 2, MidpointRounding.AwayFromZero)
            End If

            dgviewmonthly.Rows(6).Cells(0).Value = ISDYearlyFeesAccount
            dgviewmonthly.Rows(6).Cells(1).Value = "Total:"
            If dgviewmonthly.Rows(5).Cells(2).Value.ToString().Trim() <> "" Or CDec(dgviewmonthly.Rows(5).Cells(2).Value.ToString()) <> 0.0 Then
                Dim totamt As Decimal = totalamt - CDec(dgviewmonthly.Rows(5).Cells(2).Value.ToString())
                dgviewmonthly.Rows(6).Cells(2).Value = Decimal.Round(totamt, 2, MidpointRounding.AwayFromZero)
            Else
                dgviewmonthly.Rows(6).Cells(2).Value = Decimal.Round(totalamt, 2, MidpointRounding.AwayFromZero)
            End If

            txtpaid.Text = dgviewmonthly.Rows(6).Cells(2).Value.ToString()
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

    Private Sub LoadYearlyFees(ByVal course As String, ByVal clas As String, ByVal roll As String)
        Try
            dgviewmonthly.Rows.Clear()
            dgviewmonthly.Rows.Add()
            dgviewmonthly.Rows.Add()
            dgviewmonthly.Rows.Add()
            dgviewmonthly.Rows.Add()
            dgviewmonthly.Rows.Add()
            dgviewmonthly.Rows.Add()
            dgviewmonthly.Rows.Add()

            Dim dt As Date = Date.Parse(cmbdate.Text)
            Dim month As Integer = dt.Month
            Dim year As Integer = dt.Year
            cmd.CommandText = "select tuition,payvia from StudentRegistration where course='" & course & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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

            Dim mfees As Decimal = amt
            Dim librfees As Decimal = libraryfees
            Dim monthlyrs As Decimal = Decimal.Round(mfees, 2, MidpointRounding.AwayFromZero)

            dgviewmonthly.Rows(0).Cells(0).Value = ""
            dgviewmonthly.Rows(0).Cells(1).Value = "Yearly Fees:"
            dgviewmonthly.Rows(0).Cells(2).Value = FormatNumber(monthlyrs.ToString())

            dgviewmonthly.Rows(1).Cells(0).Value = ISDLibraryFeesAccount
            dgviewmonthly.Rows(1).Cells(1).Value = "Library Fees:"
            dgviewmonthly.Rows(1).Cells(2).Value = FormatNumber(librfees.ToString())

            dgviewmonthly.Rows(2).Cells(0).Value = ISDLateFeesAccount
            dgviewmonthly.Rows(2).Cells(1).Value = "Late Fees:"
            dgviewmonthly.Rows(2).Cells(2).Value = "0.00"

            dgviewmonthly.Rows(3).Cells(0).Value = ISDOtherFeesAccount
            dgviewmonthly.Rows(3).Cells(1).Value = "Other Fees:"
            dgviewmonthly.Rows(3).Cells(2).Value = "0.00"

            dgviewmonthly.Rows(4).Cells(0).Value = ""
            dgviewmonthly.Rows(4).Cells(1).Value = "Discount Rate:"
            dgviewmonthly.Rows(4).Cells(2).Value = FormatNumber(disccharge.ToString())

            Dim latefees As Decimal = 0.0
            Dim monrs As Decimal = 0.0
            Dim otherrs As Decimal = 0.0
            Dim librs As Decimal = 0.0

            If dgviewmonthly.Rows(2).Cells(2).Value.ToString().Trim() = "" Or CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString()) <> 0.0 Then
                latefees = 0.0
            Else
                latefees = CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString())
            End If


            If dgviewmonthly.Rows(0).Cells(2).Value.ToString().Trim() <> "" Or CDec(dgviewmonthly.Rows(0).Cells(2).Value.ToString()) <> 0.0 Then
                monrs = CDec(dgviewmonthly.Rows(0).Cells(2).Value.ToString())
            Else
                monrs = 0.0
            End If

            If dgviewmonthly.Rows(3).Cells(2).Value.ToString().Trim() <> "" Or CDec(dgviewmonthly.Rows(3).Cells(2).Value.ToString()) <> 0.0 Then
                otherrs = CDec(dgviewmonthly.Rows(3).Cells(2).Value.ToString())
            Else
                otherrs = 0.0
            End If

            If dgviewmonthly.Rows(1).Cells(2).Value.ToString().Trim() <> "" Or CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString()) <> 0.0 Then
                librs = CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString())
            Else
                librs = 0.0
            End If

            Dim totalamt As Decimal = monrs + otherrs + latefees + librs

            dgviewmonthly.Rows(5).Cells(0).Value = ISDDiscountFeesAccount
            dgviewmonthly.Rows(5).Cells(1).Value = "Discount:"
            If dgviewmonthly.Rows(4).Cells(2).Value.ToString().Trim() <> "" Or CDec(dgviewmonthly.Rows(4).Cells(2).Value.ToString()) <> 0.0 Then
                Dim disc As Decimal = (totalamt * CDec(dgviewmonthly.Rows(4).Cells(2).Value.ToString())) / 100
                dgviewmonthly.Rows(5).Cells(2).Value = Decimal.Round(disc, 2, MidpointRounding.AwayFromZero)
            End If

            dgviewmonthly.Rows(6).Cells(0).Value = ISDYearlyFeesAccount
            dgviewmonthly.Rows(6).Cells(1).Value = "Total:"
            If dgviewmonthly.Rows(5).Cells(2).Value.ToString().Trim() <> "" Or CDec(dgviewmonthly.Rows(5).Cells(2).Value.ToString()) <> 0.0 Then
                Dim totamt As Decimal = totalamt - CDec(dgviewmonthly.Rows(5).Cells(2).Value.ToString())
                dgviewmonthly.Rows(6).Cells(2).Value = Decimal.Round(totamt, 2, MidpointRounding.AwayFromZero)
            Else
                dgviewmonthly.Rows(6).Cells(2).Value = Decimal.Round(totalamt, 2, MidpointRounding.AwayFromZero)
            End If

            txtpaid.Text = dgviewmonthly.Rows(6).Cells(2).Value.ToString()
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
            cmd.CommandText = "select paid from MonthlyFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and date='" & cmbdate.Text & "' and month=" & month & " and year=" & year & " and course='" & cmbcourse.Text & "' and regno='" & StuID & "' and name='" & txtname.Text & "'"
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
                Dim result As DialogResult = MessageBox.Show("Please enter roll no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbroll.Focus()
                End If
            ElseIf cmbclass.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter class.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbclass.Focus()
                End If
            ElseIf txtpaid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter paid amount.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtpaid.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    CheckTokenID()
                    If TokenExist = False Then
                        Dim cls As New cYearlyFees()
                        Dim paid As String = ""
                        If CDec(CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString()) <= CDec(txtpaid.Text)) Then
                            paid = "Paid"
                        Else
                            paid = "Unpaid"
                        End If
                        Dim yearrs As Decimal = 0.0
                        Dim otherrs As Decimal = 0.0
                        Dim laters As Decimal = 0.0
                        Dim librs As Decimal = 0.0
                        Dim discch As Decimal = 0.0
                        Dim disc As Decimal = 0.0
                        Dim totamt As Decimal = 0.0
                        Dim paidamt As Decimal = 0.0
                        Dim remainingamt As Decimal = 0.0
                        If dgviewmonthly.Rows(6).Cells(2).Value.ToString().Trim() = "" Or CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString()) = 0.0 Then
                            yearrs = 0.0
                        Else
                            yearrs = CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString())
                        End If
                        If dgviewmonthly.Rows(3).Cells(2).Value.ToString().Trim() = "" Or CDec(dgviewmonthly.Rows(3).Cells(2).Value.ToString()) = 0.0 Then
                            otherrs = 0.0
                        Else
                            otherrs = CDec(dgviewmonthly.Rows(3).Cells(2).Value.ToString())
                        End If
                        If dgviewmonthly.Rows(2).Cells(2).Value.ToString().Trim() = "" Or CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString()) = 0.0 Then
                            laters = 0.0
                        Else
                            laters = CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString())
                        End If
                        If dgviewmonthly.Rows(1).Cells(2).Value.ToString().Trim() = "" Or CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString()) = 0.0 Then
                            librs = 0.0
                        Else
                            librs = CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString())
                        End If
                        If dgviewmonthly.Rows(4).Cells(2).Value.ToString().Trim() = "" Or CDec(dgviewmonthly.Rows(4).Cells(2).Value.ToString()) = 0.0 Then
                            discch = 0.0
                        Else
                            discch = CDec(dgviewmonthly.Rows(4).Cells(2).Value.ToString())
                        End If
                        If dgviewmonthly.Rows(5).Cells(2).Value.ToString().Trim() = "" Or CDec(dgviewmonthly.Rows(5).Cells(2).Value.ToString()) = 0.0 Then
                            disc = 0.0
                        Else
                            disc = CDec(dgviewmonthly.Rows(5).Cells(2).Value.ToString())
                        End If
                        If dgviewmonthly.Rows(6).Cells(2).Value.ToString().Trim() = "" Or CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString()) = 0.0 Then
                            totamt = 0.0
                        Else
                            totamt = CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString())
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
                        cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, dt.ToShortDateString(), month, year, cmbcourse.Text, cmbclass.Text, cmbroll.Text, StuID, txtname.Text, txttime.Text, cmbpayvia.Text, yearrs, laters, otherrs, librs, discch, disc, totamt, paidamt, remainingamt, paid)
                        If cls.AddYearlyFeesOk = True Then
                            If yearrs > 0 Then
                                AddMonthlyRs()
                            End If
                            AddDiscount()
                            AddLateRs()
                            AddLibraryRs()
                            AddOtherRs()
                            Dim result1 As DialogResult = MessageBox.Show("Record added successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = Windows.Forms.DialogResult.OK Then
                                cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString()) & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDYearlyFeesAccount & "'"
                                dr = cmd.ExecuteReader
                                dr.Close()
                                CheckPaid()
                                cmbroll.Focus()
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Token no already exist." + Environment.NewLine + "Please enter a new token no.", "Umbrella - Duplicate Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

    Private Sub AddMonthlyRs()
        Try
            Dim cls As New cMonthlyFees()
            Dim monrs As Decimal = 0.0
            Dim otherrs As Decimal = 0.0
            Dim laters As Decimal = 0.0
            Dim librs As Decimal = 0.0
            Dim discch As Decimal = 0.0
            Dim disc As Decimal = 0.0
            Dim totalamt As Decimal = 0.0
            Dim pay As Decimal = 0.0
            Dim remaining As Decimal = 0.0
            If dgviewmonthly.Rows(6).Cells(2).Value.ToString().Trim() = "" Then
                monrs = 0.0
            Else
                monrs = CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(3).Cells(2).Value.ToString().Trim() = "" Then
                otherrs = 0.0
            Else
                otherrs = CDec(dgviewmonthly.Rows(3).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(2).Cells(2).Value.ToString().Trim() = "" Then
                laters = 0.0
            Else
                laters = CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(1).Cells(2).Value.ToString().Trim() = "" Then
                librs = 0.0
            Else
                librs = CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(4).Cells(2).Value.ToString().Trim() = "" Then
                discch = 0.0
            Else
                discch = CDec(dgviewmonthly.Rows(4).Cells(2).Value.ToString())
            End If
            If dgviewmonthly.Rows(5).Cells(2).Value.ToString().Trim() = "" Then
                disc = 0.0
            Else
                disc = CDec(dgviewmonthly.Rows(5).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(6).Cells(2).Value.ToString().Trim() = "" Then
                totalamt = 0.0
            Else
                totalamt = CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString()) / 12
            End If
            If txtpaid.Text.Trim() = "" Then
                pay = 0.0
            Else
                pay = CDec(txtpaid.Text) / 12
            End If
            remaining = totalamt - pay
            Dim paid As String = ""
            If CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString()) <= CDec(txtpaid.Text) Then
                paid = "Paid"
            Else
                paid = "Unpaid"
            End If
            Dim dt As Date = CDate(cmbdate.Text)
            Dim year As Integer = dt.Year
            cmd.CommandText = "select FinancialMonth from Institute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim financialmonth As String = dr("FinancialMonth").ToString()
            dr.Close()
            Dim fmonth As Integer = 0
            If financialmonth = "January" Then
                fmonth = 1
            ElseIf financialmonth = "February" Then
                fmonth = 2
            ElseIf financialmonth = "March" Then
                fmonth = 3
            ElseIf financialmonth = "April" Then
                fmonth = 4
            ElseIf financialmonth = "May" Then
                fmonth = 5
            ElseIf financialmonth = "June" Then
                fmonth = 6
            ElseIf financialmonth = "July" Then
                fmonth = 7
            ElseIf financialmonth = "August" Then
                fmonth = 8
            ElseIf financialmonth = "September" Then
                fmonth = 9
            ElseIf financialmonth = "October" Then
                fmonth = 10
            ElseIf financialmonth = "November" Then
                fmonth = 11
            ElseIf financialmonth = "December" Then
                fmonth = 12
            End If
            Dim i As Integer = 0
            For j As Integer = fmonth To fmonth + 11
                i = j
                If j = 13 Then
                    i = 1
                    year = year + 1
                ElseIf j = 14 Then
                    i = 2
                    year = year + 1
                ElseIf j = 15 Then
                    i = 3
                    year = year + 1
                ElseIf j = 16 Then
                    i = 4
                    year = year + 1
                ElseIf j = 17 Then
                    i = 5
                    year = year + 1
                ElseIf j = 18 Then
                    i = 6
                    year = year + 1
                ElseIf j = 19 Then
                    i = 7
                    year = year + 1
                ElseIf j = 20 Then
                    i = 8
                    year = year + 1
                ElseIf j = 21 Then
                    i = 9
                    year = year + 1
                ElseIf j = 22 Then
                    i = 10
                    year = year + 1
                ElseIf j = 23 Then
                    i = 11
                    year = year + 1
                ElseIf j = 24 Then
                    i = 12
                    year = year + 1
                End If
                cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, cmbdate.Text, i, year, cmbcourse.Text, cmbclass.Text, cmbroll.Text, StuID, txtname.Text, txttime.Text, monrs, otherrs, laters, librs, discch, disc, totalamt, pay, cmbpayvia.Text, remaining, paid)
                Dim description As String = "Monthly Fees"
                Dim type As String = "Income"
                cmd.CommandText = "insert into IncomeExpenditure(InsID,InsName,Period,SystemDate,transactionid,descriptions,type,amount,class,roll,regno,name,month,year,account) values ('" & My.Settings.LastOpenedInstituteID & "','" & My.Settings.LastOpenedInstitute & "','" & My.Settings.Period & "','" & UmbrellaSystemDate & "','" & txttoken.Text & "','" & description & "','" & type & "'," & monrs & ",'" & cmbclass.Text & "','" & cmbroll.Text & "','" & StuID & "','" & txtname.Text & "'," & i & "," & year & ",'" & ISDMonthlyFeesAccount & "')"
                dr = cmd.ExecuteReader
                dr.Close()
            Next
            If cls.AddMonthlyOk = False Then
                MsgBox("Cannot add other fees.")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddOtherRs()
        Try
            Dim cls As New cOtherFees()
            Dim reason As String = ""
            Dim otherrs As Decimal = 0.0
            Dim discch As Decimal = 0.0
            Dim disc As Decimal = 0.0
            Dim totalamt As Decimal = 0.0
            Dim pay As Decimal = 0.0
            Dim remaining As Decimal = 0.0
            If dgviewmonthly.Rows(3).Cells(2).Value.ToString().Trim() = "" Then
                otherrs = 0.0
            Else
                otherrs = CDec(dgviewmonthly.Rows(3).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(4).Cells(2).Value.ToString().Trim() = "" Then
                discch = 0.0
            Else
                discch = CDec(dgviewmonthly.Rows(4).Cells(2).Value.ToString())
            End If
            If dgviewmonthly.Rows(5).Cells(2).Value.ToString().Trim() = "" Then
                disc = 0.0
            Else
                disc = CDec(dgviewmonthly.Rows(5).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(6).Cells(2).Value.ToString().Trim() = "" Then
                totalamt = 0.0
            Else
                totalamt = CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString()) / 12
            End If
            If txtpaid.Text.Trim() = "" Then
                pay = 0.0
            Else
                pay = CDec(txtpaid.Text) / 12
            End If
            remaining = totalamt - pay
            Dim paid As String = ""
            If CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString()) <= CDec(txtpaid.Text) Then
                paid = "Paid"
            Else
                paid = "Unpaid"
            End If
            Dim dt As Date = CDate(cmbdate.Text)
            Dim month As Integer = dt.Month
            Dim year As Integer = dt.Year
            cmd.CommandText = "select FinancialMonth from Institute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim financialmonth As String = dr("FinancialMonth").ToString()
            dr.Close()
            Dim fmonth As Integer = 0
            If financialmonth = "January" Then
                fmonth = 1
            ElseIf financialmonth = "February" Then
                fmonth = 2
            ElseIf financialmonth = "March" Then
                fmonth = 3
            ElseIf financialmonth = "April" Then
                fmonth = 4
            ElseIf financialmonth = "May" Then
                fmonth = 5
            ElseIf financialmonth = "June" Then
                fmonth = 6
            ElseIf financialmonth = "July" Then
                fmonth = 7
            ElseIf financialmonth = "August" Then
                fmonth = 8
            ElseIf financialmonth = "September" Then
                fmonth = 9
            ElseIf financialmonth = "October" Then
                fmonth = 10
            ElseIf financialmonth = "November" Then
                fmonth = 11
            ElseIf financialmonth = "December" Then
                fmonth = 12
            End If
            Dim i As Integer = 0
            For j As Integer = fmonth To fmonth + 11
                i = j
                If j = 13 Then
                    i = 1
                    year = year + 1
                ElseIf j = 14 Then
                    i = 2
                    year = year + 1
                ElseIf j = 15 Then
                    i = 3
                    year = year + 1
                ElseIf j = 16 Then
                    i = 4
                    year = year + 1
                ElseIf j = 17 Then
                    i = 5
                    year = year + 1
                ElseIf j = 18 Then
                    i = 6
                    year = year + 1
                ElseIf j = 19 Then
                    i = 7
                    year = year + 1
                ElseIf j = 20 Then
                    i = 8
                    year = year + 1
                ElseIf j = 21 Then
                    i = 9
                    year = year + 1
                ElseIf j = 22 Then
                    i = 10
                    year = year + 1
                ElseIf j = 23 Then
                    i = 11
                    year = year + 1
                ElseIf j = 24 Then
                    i = 12
                    year = year + 1
                End If
                cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, cmbdate.Text, i, year, cmbcourse.Text, cmbclass.Text, cmbroll.Text, StuID, txtname.Text, txttime.Text, cmbpayvia.Text, reason, otherrs, discch, disc, totalamt, pay, remaining, paid)
                Dim description As String = "Other Fees"
                Dim type As String = "Income"
                cmd.CommandText = "insert into IncomeExpenditure(InsID,InsName,Period,SystemDate,transactionid,descriptions,type,amount,class,roll,regno,name,month,year,account) values ('" & My.Settings.LastOpenedInstituteID & "','" & My.Settings.LastOpenedInstitute & "','" & My.Settings.Period & "','" & UmbrellaSystemDate & "','" & txttoken.Text & "','" & description & "','" & type & "'," & otherrs & ",'" & cmbclass.Text & "','" & cmbroll.Text & "','" & StuID & "','" & txtname.Text & "'," & i & "," & year & ",'" & ISDOtherFeesAccount & "')"
                dr = cmd.ExecuteReader
                dr.Close()
                cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & otherrs & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDOtherFeesAccount & "'"
                dr = cmd.ExecuteReader
                dr.Close()
            Next
            If cls.AddOtherFeesOk = False Then
                MsgBox("Cannot add other fees.")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddLateRs()
        Try
            Dim cls As New cLateFees()
            Dim reason As String = ""
            Dim laters As Decimal = 0.0
            Dim discch As Decimal = 0.0
            Dim disc As Decimal = 0.0
            Dim totalamt As Decimal = 0.0
            Dim pay As Decimal = 0.0
            Dim remaining As Decimal = 0.0
            If dgviewmonthly.Rows(2).Cells(2).Value.ToString().Trim() = "" Then
                laters = 0.0
            Else
                laters = CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(4).Cells(2).Value.ToString().Trim() = "" Then
                discch = 0.0
            Else
                discch = CDec(dgviewmonthly.Rows(4).Cells(2).Value.ToString())
            End If
            If dgviewmonthly.Rows(5).Cells(2).Value.ToString().Trim() = "" Then
                disc = 0.0
            Else
                disc = CDec(dgviewmonthly.Rows(5).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(6).Cells(2).Value.ToString().Trim() = "" Then
                totalamt = 0.0
            Else
                totalamt = CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString()) / 12
            End If
            If txtpaid.Text.Trim() = "" Then
                pay = 0.0
            Else
                pay = CDec(txtpaid.Text) / 12
            End If
            remaining = totalamt - pay
            Dim paid As String = ""
            If CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString()) <= CDec(txtpaid.Text) Then
                paid = "Paid"
            Else
                paid = "Unpaid"
            End If
            Dim dt As Date = CDate(cmbdate.Text)
            Dim month As Integer = dt.Month
            Dim year As Integer = dt.Year
            cmd.CommandText = "select FinancialMonth from Institute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim financialmonth As String = dr("FinancialMonth").ToString()
            dr.Close()
            Dim fmonth As Integer = 0
            If financialmonth = "January" Then
                fmonth = 1
            ElseIf financialmonth = "February" Then
                fmonth = 2
            ElseIf financialmonth = "March" Then
                fmonth = 3
            ElseIf financialmonth = "April" Then
                fmonth = 4
            ElseIf financialmonth = "May" Then
                fmonth = 5
            ElseIf financialmonth = "June" Then
                fmonth = 6
            ElseIf financialmonth = "July" Then
                fmonth = 7
            ElseIf financialmonth = "August" Then
                fmonth = 8
            ElseIf financialmonth = "September" Then
                fmonth = 9
            ElseIf financialmonth = "October" Then
                fmonth = 10
            ElseIf financialmonth = "November" Then
                fmonth = 11
            ElseIf financialmonth = "December" Then
                fmonth = 12
            End If
            Dim i As Integer = 0
            For j As Integer = fmonth To fmonth + 11
                i = j
                If j = 13 Then
                    i = 1
                    year = year + 1
                ElseIf j = 14 Then
                    i = 2
                    year = year + 1
                ElseIf j = 15 Then
                    i = 3
                    year = year + 1
                ElseIf j = 16 Then
                    i = 4
                    year = year + 1
                ElseIf j = 17 Then
                    i = 5
                    year = year + 1
                ElseIf j = 18 Then
                    i = 6
                    year = year + 1
                ElseIf j = 19 Then
                    i = 7
                    year = year + 1
                ElseIf j = 20 Then
                    i = 8
                    year = year + 1
                ElseIf j = 21 Then
                    i = 9
                    year = year + 1
                ElseIf j = 22 Then
                    i = 10
                    year = year + 1
                ElseIf j = 23 Then
                    i = 11
                    year = year + 1
                ElseIf j = 24 Then
                    i = 12
                    year = year + 1
                End If
                cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, dt.ToShortDateString(), i, year, cmbcourse.Text, cmbclass.Text, cmbroll.Text, StuID, txtname.Text, txttime.Text, cmbpayvia.Text, reason, laters, discch, disc, totalamt, pay, remaining, paid)
                Dim description As String = "Late Fees"
                Dim type As String = "Income"
                cmd.CommandText = "insert into IncomeExpenditure(InsID,InsName,Period,SystemDate,transactionid,descriptions,type,amount,class,roll,regno,name,month,year,account) values ('" & My.Settings.LastOpenedInstituteID & "','" & My.Settings.LastOpenedInstitute & "','" & My.Settings.Period & "','" & UmbrellaSystemDate & "','" & txttoken.Text & "','" & description & "','" & type & "'," & laters & ",'" & cmbclass.Text & "','" & cmbroll.Text & "','" & StuID & "','" & txtname.Text & "'," & i & "," & year & ",'" & ISDLateFeesAccount & "')"
                dr = cmd.ExecuteReader
                dr.Close()
                cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & laters & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDLateFeesAccount & "'"
                dr = cmd.ExecuteReader
                dr.Close()
            Next
            If cls.AddLateFeesOk = False Then
                MsgBox("Cannot add late fees.")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddLibraryRs()
        Try
            Dim cls As New cLibraryFees()
            Dim reason As String = ""
            Dim librs As Decimal = 0.0
            Dim laters As Decimal = 0.0
            Dim discch As Decimal = 0.0
            Dim disc As Decimal = 0.0
            Dim totalamt As Decimal = 0.0
            Dim pay As Decimal = 0.0
            Dim remaining As Decimal = 0.0
            If dgviewmonthly.Rows(1).Cells(2).Value.ToString().Trim() = "" Then
                librs = 0.0
            Else
                librs = CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(2).Cells(2).Value.ToString().Trim() = "" Then
                laters = 0.0
            Else
                laters = CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(4).Cells(2).Value.ToString().Trim() = "" Then
                discch = 0.0
            Else
                discch = CDec(dgviewmonthly.Rows(4).Cells(2).Value.ToString())
            End If
            If dgviewmonthly.Rows(5).Cells(2).Value.ToString().Trim() = "" Then
                disc = 0.0
            Else
                disc = CDec(dgviewmonthly.Rows(5).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(6).Cells(2).Value.ToString().Trim() = "" Then
                totalamt = 0.0
            Else
                totalamt = CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString()) / 12
            End If
            If txtpaid.Text.Trim() = "" Then
                pay = 0.0
            Else
                pay = CDec(txtpaid.Text) / 12
            End If
            remaining = totalamt - pay
            Dim paid As String = ""
            If CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString()) <= CDec(txtpaid.Text) Then
                paid = "Paid"
            Else
                paid = "Unpaid"
            End If
            Dim dt As Date = CDate(cmbdate.Text)
            Dim month As Integer = dt.Month
            Dim year As Integer = dt.Year
            cmd.CommandText = "select FinancialMonth from Institute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim financialmonth As String = dr("FinancialMonth").ToString()
            dr.Close()
            Dim fmonth As Integer = 0
            If financialmonth = "January" Then
                fmonth = 1
            ElseIf financialmonth = "February" Then
                fmonth = 2
            ElseIf financialmonth = "March" Then
                fmonth = 3
            ElseIf financialmonth = "April" Then
                fmonth = 4
            ElseIf financialmonth = "May" Then
                fmonth = 5
            ElseIf financialmonth = "June" Then
                fmonth = 6
            ElseIf financialmonth = "July" Then
                fmonth = 7
            ElseIf financialmonth = "August" Then
                fmonth = 8
            ElseIf financialmonth = "September" Then
                fmonth = 9
            ElseIf financialmonth = "October" Then
                fmonth = 10
            ElseIf financialmonth = "November" Then
                fmonth = 11
            ElseIf financialmonth = "December" Then
                fmonth = 12
            End If
            Dim i As Integer = 0
            For j As Integer = fmonth To fmonth + 11
                i = j
                If j = 13 Then
                    i = 1
                    year = year + 1
                ElseIf j = 14 Then
                    i = 2
                    year = year + 1
                ElseIf j = 15 Then
                    i = 3
                    year = year + 1
                ElseIf j = 16 Then
                    i = 4
                    year = year + 1
                ElseIf j = 17 Then
                    i = 5
                    year = year + 1
                ElseIf j = 18 Then
                    i = 6
                    year = year + 1
                ElseIf j = 19 Then
                    i = 7
                    year = year + 1
                ElseIf j = 20 Then
                    i = 8
                    year = year + 1
                ElseIf j = 21 Then
                    i = 9
                    year = year + 1
                ElseIf j = 22 Then
                    i = 10
                    year = year + 1
                ElseIf j = 23 Then
                    i = 11
                    year = year + 1
                ElseIf j = 24 Then
                    i = 12
                    year = year + 1
                End If
                cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, dt.ToShortDateString(), i, year, cmbcourse.Text, cmbclass.Text, cmbroll.Text, StuID, txtname.Text, txttime.Text, cmbpayvia.Text, librs, laters, discch, disc, totalamt, pay, remaining, paid)
                Dim description As String = "Library Fees"
                Dim type As String = "Income"
                cmd.CommandText = "insert into IncomeExpenditure(InsID,InsName,Period,SystemDate,transactionid,descriptions,type,amount,class,roll,regno,name,month,year,account) values ('" & My.Settings.LastOpenedInstituteID & "','" & My.Settings.LastOpenedInstitute & "','" & My.Settings.Period & "','" & UmbrellaSystemDate & "','" & txttoken.Text & "','" & description & "','" & type & "'," & librs & ",'" & cmbclass.Text & "','" & cmbroll.Text & "','" & StuID & "','" & txtname.Text & "'," & i & "," & year & ",'" & ISDLibraryFeesAccount & "')"
                dr = cmd.ExecuteReader
                dr.Close()
                cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & librs & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDLibraryFeesAccount & "'"
                dr = cmd.ExecuteReader
                dr.Close()
            Next
            If cls.AddLibraryFeeOk = False Then
                MsgBox("Cannot add library fees.")
            End If
        Catch ex As Exception

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
            If dgviewmonthly.Rows(6).Cells(2).Value.ToString().Trim() = "" Then
                totalamt = 0.0
            Else
                totalamt = CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(4).Cells(2).Value.ToString().Trim() = "" Then
                discch = 0.0
            Else
                discch = CDec(dgviewmonthly.Rows(4).Cells(2).Value.ToString())
            End If
            If dgviewmonthly.Rows(5).Cells(2).Value.ToString().Trim() = "" Then
                disc = 0.0
            Else
                disc = CDec(dgviewmonthly.Rows(5).Cells(2).Value.ToString()) / 12
            End If
            Dim dt As Date = CDate(cmbdate.Text)
            Dim month As Integer = dt.Month
            Dim year As Integer = dt.Year
            cmd.CommandText = "select FinancialMonth from Institute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim financialmonth As String = dr("FinancialMonth").ToString()
            dr.Close()
            Dim fmonth As Integer = 0
            If financialmonth = "January" Then
                fmonth = 1
            ElseIf financialmonth = "February" Then
                fmonth = 2
            ElseIf financialmonth = "March" Then
                fmonth = 3
            ElseIf financialmonth = "April" Then
                fmonth = 4
            ElseIf financialmonth = "May" Then
                fmonth = 5
            ElseIf financialmonth = "June" Then
                fmonth = 6
            ElseIf financialmonth = "July" Then
                fmonth = 7
            ElseIf financialmonth = "August" Then
                fmonth = 8
            ElseIf financialmonth = "September" Then
                fmonth = 9
            ElseIf financialmonth = "October" Then
                fmonth = 10
            ElseIf financialmonth = "November" Then
                fmonth = 11
            ElseIf financialmonth = "December" Then
                fmonth = 12
            End If
            Dim i As Integer = 0
            For j As Integer = fmonth To fmonth + 11
                i = j
                If j = 13 Then
                    i = 1
                    year = year + 1
                ElseIf j = 14 Then
                    i = 2
                    year = year + 1
                ElseIf j = 15 Then
                    i = 3
                    year = year + 1
                ElseIf j = 16 Then
                    i = 4
                    year = year + 1
                ElseIf j = 17 Then
                    i = 5
                    year = year + 1
                ElseIf j = 18 Then
                    i = 6
                    year = year + 1
                ElseIf j = 19 Then
                    i = 7
                    year = year + 1
                ElseIf j = 20 Then
                    i = 8
                    year = year + 1
                ElseIf j = 21 Then
                    i = 9
                    year = year + 1
                ElseIf j = 22 Then
                    i = 10
                    year = year + 1
                ElseIf j = 23 Then
                    i = 11
                    year = year + 1
                ElseIf j = 24 Then
                    i = 12
                    year = year + 1
                End If
                cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, dt.ToShortDateString(), i, year, appliedfor, cmbclass.Text, cmbroll.Text, StuID, txtname.Text, totalamt, discch, disc, CDec(dgviewmonthly.Rows(5).Cells(2).Value.ToString()), cmbpayvia.Text, authentication, remarks, ISDDiscountFeesAccount)
                cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & disc & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDDiscountFeesAccount & "'"
                dr = cmd.ExecuteReader
                dr.Close()
            Next
            If cls.AddDiscountOk = False Then
                MsgBox("Cannot add discount")
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
                Dim result As DialogResult = MessageBox.Show("Please enter roll no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbroll.Focus()
                End If
            ElseIf cmbclass.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter class.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbclass.Focus()
                End If
            ElseIf txtpaid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter paid amount.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtpaid.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cYearlyFees()
                    Dim paid As String = ""
                    If CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString()) <= CDec(txtpaid.Text) Then
                        paid = "Paid"
                    Else
                        paid = "Unpaid"
                    End If
                    Dim yearrs As Decimal = 0.0
                    Dim otherrs As Decimal = 0.0
                    Dim laters As Decimal = 0.0
                    Dim librs As Decimal = 0.0
                    Dim discch As Decimal = 0.0
                    Dim disc As Decimal = 0.0
                    Dim totamt As Decimal = 0.0
                    Dim paidamt As Decimal = 0.0
                    Dim remainingamt As Decimal = 0.0
                    If dgviewmonthly.Rows(6).Cells(2).Value.ToString().Trim() = "" Then
                        yearrs = 0.0
                    Else
                        yearrs = CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString())
                    End If
                    If dgviewmonthly.Rows(3).Cells(2).Value.ToString().Trim() = "" Then
                        otherrs = 0.0
                    Else
                        otherrs = CDec(dgviewmonthly.Rows(3).Cells(2).Value.ToString())
                    End If
                    If dgviewmonthly.Rows(2).Cells(2).Value.ToString().Trim() = "" Then
                        laters = 0.0
                    Else
                        laters = CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString())
                    End If
                    If dgviewmonthly.Rows(1).Cells(2).Value.ToString().Trim() = "" Then
                        librs = 0.0
                    Else
                        librs = CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString())
                    End If
                    If dgviewmonthly.Rows(4).Cells(2).Value.ToString().Trim() = "" Then
                        discch = 0.0
                    Else
                        discch = CDec(dgviewmonthly.Rows(4).Cells(2).Value.ToString())
                    End If
                    If dgviewmonthly.Rows(5).Cells(2).Value.ToString().Trim() = "" Then
                        disc = 0.0
                    Else
                        disc = CDec(dgviewmonthly.Rows(5).Cells(2).Value.ToString())
                    End If
                    If dgviewmonthly.Rows(6).Cells(2).Value.ToString().Trim() = "" Then
                        totamt = 0.0
                    Else
                        totamt = CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString())
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
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, cmbdate.Text, month, year, cmbcourse.Text, cmbclass.Text, cmbroll.Text, StuID, txtname.Text, txttime.Text, cmbpayvia.Text, yearrs, laters, otherrs, librs, discch, disc, totamt, paidamt, remainingamt, paid)
                    If cls.UpdateYearlyFeesOk = True Then
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & TotalPaid & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDYearlyFeesAccount & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & LibraryFee & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDLibraryFeesAccount & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & LateFee & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDLateFeesAccount & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & OtherFee & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDOtherFeesAccount & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & Discount & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDDiscountFeesAccount & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & CDec(txtpaid.Text) & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDYearlyFeesAccount & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        UpdateMonthlyRs()
                        UpdateDiscount()
                        UpdateLateRs()
                        UpdateLibraryRs()
                        UpdateOtherRs()
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

    Private Sub UpdateMonthlyRs()
        Try
            Dim cls As New cMonthlyFees()
            Dim monrs As Decimal = 0.0
            Dim otherrs As Decimal = 0.0
            Dim laters As Decimal = 0.0
            Dim librs As Decimal = 0.0
            Dim discch As Decimal = 0.0
            Dim disc As Decimal = 0.0
            Dim totalamt As Decimal = 0.0
            Dim pay As Decimal = 0.0
            Dim remaining As Decimal = 0.0
            If dgviewmonthly.Rows(6).Cells(2).Value.ToString().Trim() = "" Then
                monrs = 0.0
            Else
                monrs = CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(3).Cells(2).Value.ToString().Trim() = "" Then
                otherrs = 0.0
            Else
                otherrs = CDec(dgviewmonthly.Rows(3).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(2).Cells(2).Value.ToString().Trim() = "" Then
                laters = 0.0
            Else
                laters = CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(1).Cells(2).Value.ToString().Trim() = "" Then
                librs = 0.0
            Else
                librs = CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(4).Cells(2).Value.ToString().Trim() = "" Then
                discch = 0.0
            Else
                discch = CDec(dgviewmonthly.Rows(4).Cells(2).Value.ToString())
            End If
            If dgviewmonthly.Rows(5).Cells(2).Value.ToString().Trim() = "" Then
                disc = 0.0
            Else
                disc = CDec(dgviewmonthly.Rows(5).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(6).Cells(2).Value.ToString().Trim() = "" Then
                totalamt = 0.0
            Else
                totalamt = CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString()) / 12
            End If
            If txtpaid.Text.Trim() = "" Then
                pay = 0.0
            Else
                pay = CDec(txtpaid.Text) / 12
            End If
            remaining = totalamt - pay
            Dim paid As String = ""
            If CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString()) <= CDec(txtpaid.Text) Then
                paid = "Paid"
            Else
                paid = "Unpaid"
            End If
            Dim dt As Date = CDate(cmbdate.Text)
            Dim year As Integer = dt.Year
            cmd.CommandText = "select FinancialMonth from Institute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim financialmonth As String = dr("FinancialMonth").ToString()
            dr.Close()
            Dim fmonth As Integer = 0
            If financialmonth = "January" Then
                fmonth = 1
            ElseIf financialmonth = "February" Then
                fmonth = 2
            ElseIf financialmonth = "March" Then
                fmonth = 3
            ElseIf financialmonth = "April" Then
                fmonth = 4
            ElseIf financialmonth = "May" Then
                fmonth = 5
            ElseIf financialmonth = "June" Then
                fmonth = 6
            ElseIf financialmonth = "July" Then
                fmonth = 7
            ElseIf financialmonth = "August" Then
                fmonth = 8
            ElseIf financialmonth = "September" Then
                fmonth = 9
            ElseIf financialmonth = "October" Then
                fmonth = 10
            ElseIf financialmonth = "November" Then
                fmonth = 11
            ElseIf financialmonth = "December" Then
                fmonth = 12
            End If
            Dim i As Integer = 0
            For j As Integer = fmonth To fmonth + 11
                i = j
                If j = 13 Then
                    i = 1
                    year = year + 1
                ElseIf j = 14 Then
                    i = 2
                    year = year + 1
                ElseIf j = 15 Then
                    i = 3
                    year = year + 1
                ElseIf j = 16 Then
                    i = 4
                    year = year + 1
                ElseIf j = 17 Then
                    i = 5
                    year = year + 1
                ElseIf j = 18 Then
                    i = 6
                    year = year + 1
                ElseIf j = 19 Then
                    i = 7
                    year = year + 1
                ElseIf j = 20 Then
                    i = 8
                    year = year + 1
                ElseIf j = 21 Then
                    i = 9
                    year = year + 1
                ElseIf j = 22 Then
                    i = 10
                    year = year + 1
                ElseIf j = 23 Then
                    i = 11
                    year = year + 1
                ElseIf j = 24 Then
                    i = 12
                    year = year + 1
                End If
                cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, cmbdate.Text, i, year, cmbcourse.Text, cmbclass.Text, cmbroll.Text, StuID, txtname.Text, txttime.Text, monrs, otherrs, laters, librs, discch, disc, totalamt, pay, cmbpayvia.Text, remaining, paid)
                Dim description As String = "Monthly Fees"
                Dim type As String = "Income"
                cmd.CommandText = "update IncomeExpenditure set SystemDate='" & UmbrellaSystemDate & "',amount=" & monrs & ",class='" & cmbclass.Text & "',roll='" & cmbroll.Text & "',regno='" & StuID & "',name='" & txtname.Text & "',month=" & i & ",year=" & year & ",account='" & ISDMonthlyFeesAccount & "' where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and transactionid='" & txttoken.Text & "' and descriptions='" & description & "' and type='" & type & "'"
                dr = cmd.ExecuteReader
                dr.Close()
            Next
            If cls.UpdateMonthlyOk = False Then
                MsgBox("Cannot add other fees.")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateOtherRs()
        Try
            Dim cls As New cOtherFees()
            Dim reason As String = ""
            Dim otherrs As Decimal = 0.0
            Dim discch As Decimal = 0.0
            Dim disc As Decimal = 0.0
            Dim totalamt As Decimal = 0.0
            Dim pay As Decimal = 0.0
            Dim remaining As Decimal = 0.0
            If dgviewmonthly.Rows(3).Cells(2).Value.ToString().Trim() = "" Then
                otherrs = 0.0
            Else
                otherrs = CDec(dgviewmonthly.Rows(3).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(4).Cells(2).Value.ToString().Trim() = "" Then
                discch = 0.0
            Else
                discch = CDec(dgviewmonthly.Rows(4).Cells(2).Value.ToString())
            End If
            If dgviewmonthly.Rows(5).Cells(2).Value.ToString().Trim() = "" Then
                disc = 0.0
            Else
                disc = CDec(dgviewmonthly.Rows(5).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(6).Cells(2).Value.ToString().Trim() = "" Then
                totalamt = 0.0
            Else
                totalamt = CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString()) / 12
            End If
            If txtpaid.Text.Trim() = "" Then
                pay = 0.0
            Else
                pay = CDec(txtpaid.Text) / 12
            End If
            remaining = totalamt - pay
            Dim paid As String = ""
            If CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString()) <= CDec(txtpaid.Text) Then
                paid = "Paid"
            Else
                paid = "Unpaid"
            End If
            Dim dt As Date = CDate(cmbdate.Text)
            Dim month As Integer = dt.Month
            Dim year As Integer = dt.Year
            cmd.CommandText = "select FinancialMonth from Institute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim financialmonth As String = dr("FinancialMonth").ToString()
            dr.Close()
            Dim fmonth As Integer = 0
            If financialmonth = "January" Then
                fmonth = 1
            ElseIf financialmonth = "February" Then
                fmonth = 2
            ElseIf financialmonth = "March" Then
                fmonth = 3
            ElseIf financialmonth = "April" Then
                fmonth = 4
            ElseIf financialmonth = "May" Then
                fmonth = 5
            ElseIf financialmonth = "June" Then
                fmonth = 6
            ElseIf financialmonth = "July" Then
                fmonth = 7
            ElseIf financialmonth = "August" Then
                fmonth = 8
            ElseIf financialmonth = "September" Then
                fmonth = 9
            ElseIf financialmonth = "October" Then
                fmonth = 10
            ElseIf financialmonth = "November" Then
                fmonth = 11
            ElseIf financialmonth = "December" Then
                fmonth = 12
            End If
            Dim i As Integer = 0
            For j As Integer = fmonth To fmonth + 11
                i = j
                If j = 13 Then
                    i = 1
                    year = year + 1
                ElseIf j = 14 Then
                    i = 2
                    year = year + 1
                ElseIf j = 15 Then
                    i = 3
                    year = year + 1
                ElseIf j = 16 Then
                    i = 4
                    year = year + 1
                ElseIf j = 17 Then
                    i = 5
                    year = year + 1
                ElseIf j = 18 Then
                    i = 6
                    year = year + 1
                ElseIf j = 19 Then
                    i = 7
                    year = year + 1
                ElseIf j = 20 Then
                    i = 8
                    year = year + 1
                ElseIf j = 21 Then
                    i = 9
                    year = year + 1
                ElseIf j = 22 Then
                    i = 10
                    year = year + 1
                ElseIf j = 23 Then
                    i = 11
                    year = year + 1
                ElseIf j = 24 Then
                    i = 12
                    year = year + 1
                End If
                cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, dt.ToShortDateString(), i, year, cmbcourse.Text, cmbclass.Text, cmbroll.Text, StuID, txtname.Text, txttime.Text, cmbpayvia.Text, reason, otherrs, discch, disc, totalamt, pay, remaining, paid)
                Dim description As String = "Other Fees"
                Dim type As String = "Income"
                cmd.CommandText = "update IncomeExpenditure set SystemDate='" & UmbrellaSystemDate & "',descriptions='" & description & "',type='" & type & "',amount=" & otherrs & ",class='" & cmbclass.Text & "',roll='" & cmbroll.Text & "',regno='" & StuID & "',name='" & txtname.Text & "',month=" & month & ",year=" & year & ",account='" & ISDOtherFeesAccount & "' where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and transactionid='" & txttoken.Text & "' and descriptions='" & description & "' and type='" & type & "'"
                dr = cmd.ExecuteReader
                dr.Close()
                cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & otherrs & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDOtherFeesAccount & "'"
                dr = cmd.ExecuteReader
                dr.Close()
            Next
            If cls.UpdateOtherFeesOk = False Then
                MsgBox("Cannot update other fees.")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateLateRs()
        Try
            Dim cls As New cLateFees()
            Dim reason As String = ""
            Dim laters As Decimal = 0.0
            Dim discch As Decimal = 0.0
            Dim disc As Decimal = 0.0
            Dim totalamt As Decimal = 0.0
            Dim pay As Decimal = 0.0
            Dim remaining As Decimal = 0.0
            If dgviewmonthly.Rows(2).Cells(2).Value.ToString().Trim() = "" Then
                laters = 0.0
            Else
                laters = CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(4).Cells(2).Value.ToString().Trim() = "" Then
                discch = 0.0
            Else
                discch = CDec(dgviewmonthly.Rows(4).Cells(2).Value.ToString())
            End If
            If dgviewmonthly.Rows(5).Cells(2).Value.ToString().Trim() = "" Then
                disc = 0.0
            Else
                disc = CDec(dgviewmonthly.Rows(5).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(6).Cells(2).Value.ToString().Trim() = "" Then
                totalamt = 0.0
            Else
                totalamt = CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString()) / 12
            End If
            If txtpaid.Text.Trim() = "" Then
                pay = 0.0
            Else
                pay = CDec(txtpaid.Text) / 12
            End If
            remaining = totalamt - pay
            Dim paid As String = ""
            If CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString()) <= CDec(txtpaid.Text) Then
                paid = "Paid"
            Else
                paid = "Unpaid"
            End If
            Dim dt As Date = CDate(cmbdate.Text)
            Dim month As Integer = dt.Month
            Dim year As Integer = dt.Year
            cmd.CommandText = "select FinancialMonth from Institute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim financialmonth As String = dr("FinancialMonth").ToString()
            dr.Close()
            Dim fmonth As Integer = 0
            If financialmonth = "January" Then
                fmonth = 1
            ElseIf financialmonth = "February" Then
                fmonth = 2
            ElseIf financialmonth = "March" Then
                fmonth = 3
            ElseIf financialmonth = "April" Then
                fmonth = 4
            ElseIf financialmonth = "May" Then
                fmonth = 5
            ElseIf financialmonth = "June" Then
                fmonth = 6
            ElseIf financialmonth = "July" Then
                fmonth = 7
            ElseIf financialmonth = "August" Then
                fmonth = 8
            ElseIf financialmonth = "September" Then
                fmonth = 9
            ElseIf financialmonth = "October" Then
                fmonth = 10
            ElseIf financialmonth = "November" Then
                fmonth = 11
            ElseIf financialmonth = "December" Then
                fmonth = 12
            End If
            Dim i As Integer = 0
            For j As Integer = fmonth To fmonth + 11
                i = j
                If j = 13 Then
                    i = 1
                    year = year + 1
                ElseIf j = 14 Then
                    i = 2
                    year = year + 1
                ElseIf j = 15 Then
                    i = 3
                    year = year + 1
                ElseIf j = 16 Then
                    i = 4
                    year = year + 1
                ElseIf j = 17 Then
                    i = 5
                    year = year + 1
                ElseIf j = 18 Then
                    i = 6
                    year = year + 1
                ElseIf j = 19 Then
                    i = 7
                    year = year + 1
                ElseIf j = 20 Then
                    i = 8
                    year = year + 1
                ElseIf j = 21 Then
                    i = 9
                    year = year + 1
                ElseIf j = 22 Then
                    i = 10
                    year = year + 1
                ElseIf j = 23 Then
                    i = 11
                    year = year + 1
                ElseIf j = 24 Then
                    i = 12
                    year = year + 1
                End If
                cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, dt.ToShortDateString(), i, year, cmbcourse.Text, cmbclass.Text, cmbroll.Text, StuID, txtname.Text, txttime.Text, cmbpayvia.Text, reason, laters, discch, disc, totalamt, pay, remaining, paid)
                Dim description As String = "Late Fees"
                Dim type As String = "Income"
                cmd.CommandText = "update IncomeExpenditure set SystemDate='" & UmbrellaSystemDate & "',amount=" & laters & ",class='" & cmbclass.Text & "',roll='" & cmbroll.Text & "',regno='" & StuID & "',name='" & txtname.Text & "',month=" & month & ",year=" & year & ",account='" & ISDLateFeesAccount & "' where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and transactionid='" & txttoken.Text & "' and descriptions='" & description & "' and type='" & type & "'"
                dr = cmd.ExecuteReader
                dr.Close()
                cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & laters & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDLateFeesAccount & "'"
                dr = cmd.ExecuteReader
                dr.Close()
            Next
            If cls.UpdateLateFeesOk = False Then
                MsgBox("Cannot update late fees.")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateLibraryRs()
        Try
            Dim cls As New cLibraryFees()
            Dim reason As String = ""
            Dim librs As Decimal = 0.0
            Dim laters As Decimal = 0.0
            Dim discch As Decimal = 0.0
            Dim disc As Decimal = 0.0
            Dim totalamt As Decimal = 0.0
            Dim pay As Decimal = 0.0
            Dim remaining As Decimal = 0.0
            If dgviewmonthly.Rows(1).Cells(2).Value.ToString().Trim() = "" Then
                librs = 0.0
            Else
                librs = CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(2).Cells(2).Value.ToString().Trim() = "" Then
                laters = 0.0
            Else
                laters = CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(4).Cells(2).Value.ToString().Trim() = "" Then
                discch = 0.0
            Else
                discch = CDec(dgviewmonthly.Rows(4).Cells(2).Value.ToString())
            End If
            If dgviewmonthly.Rows(5).Cells(2).Value.ToString().Trim() = "" Then
                disc = 0.0
            Else
                disc = CDec(dgviewmonthly.Rows(5).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(6).Cells(2).Value.ToString().Trim() = "" Then
                totalamt = 0.0
            Else
                totalamt = CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString())
            End If
            If txtpaid.Text.Trim() = "" Then
                pay = 0.0
            Else
                pay = CDec(txtpaid.Text) / 12
            End If
            remaining = totalamt - pay
            Dim paid As String = ""
            If CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString()) <= CDec(txtpaid.Text) Then
                paid = "Paid"
            Else
                paid = "Unpaid"
            End If
            Dim dt As Date = CDate(cmbdate.Text)
            Dim month As Integer = dt.Month
            Dim year As Integer = dt.Year
            cmd.CommandText = "select FinancialMonth from Institute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim financialmonth As String = dr("FinancialMonth").ToString()
            dr.Close()
            Dim fmonth As Integer = 0
            If financialmonth = "January" Then
                fmonth = 1
            ElseIf financialmonth = "February" Then
                fmonth = 2
            ElseIf financialmonth = "March" Then
                fmonth = 3
            ElseIf financialmonth = "April" Then
                fmonth = 4
            ElseIf financialmonth = "May" Then
                fmonth = 5
            ElseIf financialmonth = "June" Then
                fmonth = 6
            ElseIf financialmonth = "July" Then
                fmonth = 7
            ElseIf financialmonth = "August" Then
                fmonth = 8
            ElseIf financialmonth = "September" Then
                fmonth = 9
            ElseIf financialmonth = "October" Then
                fmonth = 10
            ElseIf financialmonth = "November" Then
                fmonth = 11
            ElseIf financialmonth = "December" Then
                fmonth = 12
            End If
            Dim i As Integer = 0
            For j As Integer = fmonth To fmonth + 11
                i = j
                If j = 13 Then
                    i = 1
                    year = year + 1
                ElseIf j = 14 Then
                    i = 2
                    year = year + 1
                ElseIf j = 15 Then
                    i = 3
                    year = year + 1
                ElseIf j = 16 Then
                    i = 4
                    year = year + 1
                ElseIf j = 17 Then
                    i = 5
                    year = year + 1
                ElseIf j = 18 Then
                    i = 6
                    year = year + 1
                ElseIf j = 19 Then
                    i = 7
                    year = year + 1
                ElseIf j = 20 Then
                    i = 8
                    year = year + 1
                ElseIf j = 21 Then
                    i = 9
                    year = year + 1
                ElseIf j = 22 Then
                    i = 10
                    year = year + 1
                ElseIf j = 23 Then
                    i = 11
                    year = year + 1
                ElseIf j = 24 Then
                    i = 12
                    year = year + 1
                End If
                cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, dt.ToShortDateString(), i, year, cmbcourse.Text, cmbclass.Text, cmbroll.Text, StuID, txtname.Text, txttime.Text, cmbpayvia.Text, librs, laters, discch, disc, totalamt, pay, remaining, paid)
                Dim description As String = "Library Fees"
                Dim type As String = "Income"
                cmd.CommandText = "update IncomeExpenditure set SystemDate='" & UmbrellaSystemDate & "',amount=" & librs & ",class='" & cmbclass.Text & "',roll='" & cmbroll.Text & "',regno='" & StuID & "',name='" & txtname.Text & "',month=" & month & ",year=" & year & ",account='" & ISDLibraryFeesAccount & "' where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and transactionid='" & txttoken.Text & "' and descriptions='" & description & "' and type='" & type & "'"
                dr = cmd.ExecuteReader
                dr.Close()
                cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & librs & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDLibraryFeesAccount & "'"
                dr = cmd.ExecuteReader
                dr.Close()
            Next
            If cls.UpdateLibraryFeeOk = False Then
                MsgBox("Cannot update library fees.")
            End If
        Catch ex As Exception

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
            If dgviewmonthly.Rows(6).Cells(2).Value.ToString().Trim() = "" Then
                totalamt = 0.0
            Else
                totalamt = CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString()) / 12
            End If
            If dgviewmonthly.Rows(4).Cells(2).Value.ToString().Trim() = "" Then
                discch = 0.0
            Else
                discch = CDec(dgviewmonthly.Rows(4).Cells(2).Value.ToString())
            End If
            If dgviewmonthly.Rows(5).Cells(2).Value.ToString().Trim() = "" Then
                disc = 0.0
            Else
                disc = CDec(dgviewmonthly.Rows(5).Cells(2).Value.ToString()) / 12
            End If
            Dim dt As Date = CDate(cmbdate.Text)
            Dim month As Integer = dt.Month
            Dim year As Integer = dt.Year
            cmd.CommandText = "select FinancialMonth from Institute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim financialmonth As String = dr("FinancialMonth").ToString()
            dr.Close()
            Dim fmonth As Integer = 0
            If financialmonth = "January" Then
                fmonth = 1
            ElseIf financialmonth = "February" Then
                fmonth = 2
            ElseIf financialmonth = "March" Then
                fmonth = 3
            ElseIf financialmonth = "April" Then
                fmonth = 4
            ElseIf financialmonth = "May" Then
                fmonth = 5
            ElseIf financialmonth = "June" Then
                fmonth = 6
            ElseIf financialmonth = "July" Then
                fmonth = 7
            ElseIf financialmonth = "August" Then
                fmonth = 8
            ElseIf financialmonth = "September" Then
                fmonth = 9
            ElseIf financialmonth = "October" Then
                fmonth = 10
            ElseIf financialmonth = "November" Then
                fmonth = 11
            ElseIf financialmonth = "December" Then
                fmonth = 12
            End If
            Dim i As Integer = 0
            For j As Integer = fmonth To fmonth + 11
                i = j
                If j = 13 Then
                    i = 1
                    year = year + 1
                ElseIf j = 14 Then
                    i = 2
                    year = year + 1
                ElseIf j = 15 Then
                    i = 3
                    year = year + 1
                ElseIf j = 16 Then
                    i = 4
                    year = year + 1
                ElseIf j = 17 Then
                    i = 5
                    year = year + 1
                ElseIf j = 18 Then
                    i = 6
                    year = year + 1
                ElseIf j = 19 Then
                    i = 7
                    year = year + 1
                ElseIf j = 20 Then
                    i = 8
                    year = year + 1
                ElseIf j = 21 Then
                    i = 9
                    year = year + 1
                ElseIf j = 22 Then
                    i = 10
                    year = year + 1
                ElseIf j = 23 Then
                    i = 11
                    year = year + 1
                ElseIf j = 24 Then
                    i = 12
                    year = year + 1
                End If
                cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, dt.ToShortDateString(), i, year, appliedfor, cmbclass.Text, cmbroll.Text, StuID, txtname.Text, totalamt, discch, disc, CDec(dgviewmonthly.Rows(5).Cells(2).Value.ToString()), cmbpayvia.Text, authentication, remarks, ISDDiscountFeesAccount)
            Next
            If cls.UpdateDiscountOk = False Then
                MsgBox("Cannot update discount")
            Else
                cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, dt.ToShortDateString(), i, year, appliedfor, cmbclass.Text, cmbroll.Text, StuID, txtname.Text, totalamt, discch, disc, CDec(dgviewmonthly.Rows(5).Cells(2).Value.ToString()), cmbpayvia.Text, authentication, remarks, ISDDiscountFeesAccount)
                cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & CDec(dgviewmonthly.Rows(5).Cells(2).Value.ToString()) & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDDiscountFeesAccount & "'"
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
                Dim result As DialogResult = MessageBox.Show("Please enter roll no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbroll.Focus()
                End If
            ElseIf cmbclass.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter class.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbclass.Focus()
                End If
            ElseIf txtpaid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter paid amount.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtpaid.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Missing Value", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim dt As Date = Date.Parse(cmbdate.Text)
                    Dim month As Integer = dt.Month
                    Dim year As Integer = dt.Year
                    Dim cls As New cYearlyFees()
                    Dim paid As String = "Paid"
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, cmbdate.Text, month, year, cmbcourse.Text, cmbclass.Text, cmbroll.Text, StuID, txtname.Text, txttime.Text)
                    If cls.DeleteYearlyFeesOk = True Then
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & TotalPaid & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDYearlyFeesAccount & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & LibraryFee & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDLibraryFeesAccount & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & LateFee & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDLateFeesAccount & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & OtherFee & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDOtherFeesAccount & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & Discount & " where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and AccountID='" & ISDDiscountFeesAccount & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        Dim yearrs As Decimal = 0.0
                        Dim otherrs As Decimal = 0.0
                        Dim laters As Decimal = 0.0
                        Dim librs As Decimal = 0.0
                        Dim disc As Decimal = 0.0
                        If dgviewmonthly.Rows(6).Cells(2).Value.ToString().Trim() = "" Then
                            yearrs = 0.0
                        Else
                            yearrs = CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString())
                        End If
                        If dgviewmonthly.Rows(3).Cells(2).Value.ToString().Trim() = "" Then
                            otherrs = 0.0
                        Else
                            otherrs = CDec(dgviewmonthly.Rows(3).Cells(2).Value.ToString())
                        End If
                        If dgviewmonthly.Rows(2).Cells(2).Value.ToString().Trim() = "" Then
                            laters = 0.0
                        Else
                            laters = CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString())
                        End If
                        If dgviewmonthly.Rows(1).Cells(2).Value.ToString().Trim() = "" Then
                            librs = 0.0
                        Else
                            librs = CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString())
                        End If
                        If dgviewmonthly.Rows(5).Cells(2).Value.ToString().Trim() = "" Then
                            disc = 0.0
                        Else
                            disc = CDec(dgviewmonthly.Rows(5).Cells(2).Value.ToString())
                        End If
                        DeleteMonthlyRs()
                        DeleteDiscount()
                        DeleteLateRs()
                        DeleteLibraryRs()
                        DeleteOtherRs()
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

    Private Sub DeleteMonthlyRs()
        Try
            Dim cls As New cMonthlyFees()
            Dim dt As Date = Date.Parse(cmbdate.Text)
            Dim year As Integer = dt.Year
            cmd.CommandText = "select FinancialMonth from Institute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim financialmonth As String = dr("FinancialMonth").ToString()
            dr.Close()
            Dim fmonth As Integer = 0
            If financialmonth = "January" Then
                fmonth = 1
            ElseIf financialmonth = "February" Then
                fmonth = 2
            ElseIf financialmonth = "March" Then
                fmonth = 3
            ElseIf financialmonth = "April" Then
                fmonth = 4
            ElseIf financialmonth = "May" Then
                fmonth = 5
            ElseIf financialmonth = "June" Then
                fmonth = 6
            ElseIf financialmonth = "July" Then
                fmonth = 7
            ElseIf financialmonth = "August" Then
                fmonth = 8
            ElseIf financialmonth = "September" Then
                fmonth = 9
            ElseIf financialmonth = "October" Then
                fmonth = 10
            ElseIf financialmonth = "November" Then
                fmonth = 11
            ElseIf financialmonth = "December" Then
                fmonth = 12
            End If
            Dim i As Integer = 0
            For j As Integer = fmonth To fmonth + 11
                i = j
                If j = 13 Then
                    i = 1
                    year = year + 1
                ElseIf j = 14 Then
                    i = 2
                    year = year + 1
                ElseIf j = 15 Then
                    i = 3
                    year = year + 1
                ElseIf j = 16 Then
                    i = 4
                    year = year + 1
                ElseIf j = 17 Then
                    i = 5
                    year = year + 1
                ElseIf j = 18 Then
                    i = 6
                    year = year + 1
                ElseIf j = 19 Then
                    i = 7
                    year = year + 1
                ElseIf j = 20 Then
                    i = 8
                    year = year + 1
                ElseIf j = 21 Then
                    i = 9
                    year = year + 1
                ElseIf j = 22 Then
                    i = 10
                    year = year + 1
                ElseIf j = 23 Then
                    i = 11
                    year = year + 1
                ElseIf j = 24 Then
                    i = 12
                    year = year + 1
                End If
                cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, cmbdate.Text, i, year, cmbcourse.Text, cmbclass.Text, cmbroll.Text, StuID, txtname.Text)
            Next
            Dim description As String = "Monthly Fees"
            Dim type As String = "Income"
            cmd.CommandText = "delete from IncomeExpenditure where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and transactionid='" & txttoken.Text & "' and descriptions='" & description & "' and type='" & type & "'"
            dr = cmd.ExecuteReader
            dr.Close()
            If cls.DeleteMonthlyOk = False Then
                MsgBox("Cannot delete other fees.")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteOtherRs()
        Try
            Dim dt As Date = Date.Parse(cmbdate.Text)
            Dim month As Integer = dt.Month
            Dim year As Integer = dt.Year
            Dim cls As New cOtherFees()
            cmd.CommandText = "select FinancialMonth from Institute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim financialmonth As String = dr("FinancialMonth").ToString()
            dr.Close()
            Dim fmonth As Integer = 0
            If financialmonth = "January" Then
                fmonth = 1
            ElseIf financialmonth = "February" Then
                fmonth = 2
            ElseIf financialmonth = "March" Then
                fmonth = 3
            ElseIf financialmonth = "April" Then
                fmonth = 4
            ElseIf financialmonth = "May" Then
                fmonth = 5
            ElseIf financialmonth = "June" Then
                fmonth = 6
            ElseIf financialmonth = "July" Then
                fmonth = 7
            ElseIf financialmonth = "August" Then
                fmonth = 8
            ElseIf financialmonth = "September" Then
                fmonth = 9
            ElseIf financialmonth = "October" Then
                fmonth = 10
            ElseIf financialmonth = "November" Then
                fmonth = 11
            ElseIf financialmonth = "December" Then
                fmonth = 12
            End If
            Dim i As Integer = 0
            For j As Integer = fmonth To fmonth + 11
                i = j
                If j = 13 Then
                    i = 1
                    year = year + 1
                ElseIf j = 14 Then
                    i = 2
                    year = year + 1
                ElseIf j = 15 Then
                    i = 3
                    year = year + 1
                ElseIf j = 16 Then
                    i = 4
                    year = year + 1
                ElseIf j = 17 Then
                    i = 5
                    year = year + 1
                ElseIf j = 18 Then
                    i = 6
                    year = year + 1
                ElseIf j = 19 Then
                    i = 7
                    year = year + 1
                ElseIf j = 20 Then
                    i = 8
                    year = year + 1
                ElseIf j = 21 Then
                    i = 9
                    year = year + 1
                ElseIf j = 22 Then
                    i = 10
                    year = year + 1
                ElseIf j = 23 Then
                    i = 11
                    year = year + 1
                ElseIf j = 24 Then
                    i = 12
                    year = year + 1
                End If
                cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, dt.ToShortDateString(), i, year, cmbcourse.Text, cmbclass.Text, cmbroll.Text, StuID, txtname.Text)
            Next
            If cls.DeleteOtherFeesOk = False Then
                MsgBox("Cannot delete other fees")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteLateRs()
        Try
            Dim dt As Date = Date.Parse(cmbdate.Text)
            Dim month As Integer = dt.Month
            Dim year As Integer = dt.Year
            Dim cls As New cLateFees()
            cmd.CommandText = "select FinancialMonth from Institute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim financialmonth As String = dr("FinancialMonth").ToString()
            dr.Close()
            Dim fmonth As Integer = 0
            If financialmonth = "January" Then
                fmonth = 1
            ElseIf financialmonth = "February" Then
                fmonth = 2
            ElseIf financialmonth = "March" Then
                fmonth = 3
            ElseIf financialmonth = "April" Then
                fmonth = 4
            ElseIf financialmonth = "May" Then
                fmonth = 5
            ElseIf financialmonth = "June" Then
                fmonth = 6
            ElseIf financialmonth = "July" Then
                fmonth = 7
            ElseIf financialmonth = "August" Then
                fmonth = 8
            ElseIf financialmonth = "September" Then
                fmonth = 9
            ElseIf financialmonth = "October" Then
                fmonth = 10
            ElseIf financialmonth = "November" Then
                fmonth = 11
            ElseIf financialmonth = "December" Then
                fmonth = 12
            End If
            Dim i As Integer = 0
            For j As Integer = fmonth To fmonth + 11
                i = j
                If j = 13 Then
                    i = 1
                    year = year + 1
                ElseIf j = 14 Then
                    i = 2
                    year = year + 1
                ElseIf j = 15 Then
                    i = 3
                    year = year + 1
                ElseIf j = 16 Then
                    i = 4
                    year = year + 1
                ElseIf j = 17 Then
                    i = 5
                    year = year + 1
                ElseIf j = 18 Then
                    i = 6
                    year = year + 1
                ElseIf j = 19 Then
                    i = 7
                    year = year + 1
                ElseIf j = 20 Then
                    i = 8
                    year = year + 1
                ElseIf j = 21 Then
                    i = 9
                    year = year + 1
                ElseIf j = 22 Then
                    i = 10
                    year = year + 1
                ElseIf j = 23 Then
                    i = 11
                    year = year + 1
                ElseIf j = 24 Then
                    i = 12
                    year = year + 1
                End If
                cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, dt.ToShortDateString(), i, year, cmbcourse.Text, cmbclass.Text, cmbroll.Text, StuID, txtname.Text)
            Next
            If cls.DeleteLateFeesOk = False Then
                MsgBox("Cannot delete late fees")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteLibraryRs()
        Try
            Dim dt As Date = Date.Parse(cmbdate.Text)
            Dim month As Integer = dt.Month
            Dim year As Integer = dt.Year
            Dim cls As New cLibraryFees()
            cmd.CommandText = "select FinancialMonth from Institute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim financialmonth As String = dr("FinancialMonth").ToString()
            dr.Close()
            Dim fmonth As Integer = 0
            If financialmonth = "January" Then
                fmonth = 1
            ElseIf financialmonth = "February" Then
                fmonth = 2
            ElseIf financialmonth = "March" Then
                fmonth = 3
            ElseIf financialmonth = "April" Then
                fmonth = 4
            ElseIf financialmonth = "May" Then
                fmonth = 5
            ElseIf financialmonth = "June" Then
                fmonth = 6
            ElseIf financialmonth = "July" Then
                fmonth = 7
            ElseIf financialmonth = "August" Then
                fmonth = 8
            ElseIf financialmonth = "September" Then
                fmonth = 9
            ElseIf financialmonth = "October" Then
                fmonth = 10
            ElseIf financialmonth = "November" Then
                fmonth = 11
            ElseIf financialmonth = "December" Then
                fmonth = 12
            End If
            Dim i As Integer = 0
            For j As Integer = fmonth To fmonth + 11
                i = j
                If j = 13 Then
                    i = 1
                    year = year + 1
                ElseIf j = 14 Then
                    i = 2
                    year = year + 1
                ElseIf j = 15 Then
                    i = 3
                    year = year + 1
                ElseIf j = 16 Then
                    i = 4
                    year = year + 1
                ElseIf j = 17 Then
                    i = 5
                    year = year + 1
                ElseIf j = 18 Then
                    i = 6
                    year = year + 1
                ElseIf j = 19 Then
                    i = 7
                    year = year + 1
                ElseIf j = 20 Then
                    i = 8
                    year = year + 1
                ElseIf j = 21 Then
                    i = 9
                    year = year + 1
                ElseIf j = 22 Then
                    i = 10
                    year = year + 1
                ElseIf j = 23 Then
                    i = 11
                    year = year + 1
                ElseIf j = 24 Then
                    i = 12
                    year = year + 1
                End If
                cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, dt.ToShortDateString(), i, year, cmbcourse.Text, cmbclass.Text, cmbroll.Text, StuID, txtname.Text)
            Next
            If cls.DeleteLibraryFeeOk = False Then
                MsgBox("Cannot delete library fees.")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteDiscount()
        Try
            Dim dt As Date = Date.Parse(cmbdate.Text)
            Dim month As Integer = dt.Month
            Dim year As Integer = dt.Year
            Dim cls As New cDiscount()
            cmd.CommandText = "select FinancialMonth from Institute where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            Dim financialmonth As String = dr("FinancialMonth").ToString()
            dr.Close()
            Dim fmonth As Integer = 0
            If financialmonth = "January" Then
                fmonth = 1
            ElseIf financialmonth = "February" Then
                fmonth = 2
            ElseIf financialmonth = "March" Then
                fmonth = 3
            ElseIf financialmonth = "April" Then
                fmonth = 4
            ElseIf financialmonth = "May" Then
                fmonth = 5
            ElseIf financialmonth = "June" Then
                fmonth = 6
            ElseIf financialmonth = "July" Then
                fmonth = 7
            ElseIf financialmonth = "August" Then
                fmonth = 8
            ElseIf financialmonth = "September" Then
                fmonth = 9
            ElseIf financialmonth = "October" Then
                fmonth = 10
            ElseIf financialmonth = "November" Then
                fmonth = 11
            ElseIf financialmonth = "December" Then
                fmonth = 12
            End If
            Dim i As Integer = 0
            For j As Integer = fmonth To fmonth + 11
                i = j
                If j = 13 Then
                    i = 1
                    year = year + 1
                ElseIf j = 14 Then
                    i = 2
                    year = year + 1
                ElseIf j = 15 Then
                    i = 3
                    year = year + 1
                ElseIf j = 16 Then
                    i = 4
                    year = year + 1
                ElseIf j = 17 Then
                    i = 5
                    year = year + 1
                ElseIf j = 18 Then
                    i = 6
                    year = year + 1
                ElseIf j = 19 Then
                    i = 7
                    year = year + 1
                ElseIf j = 20 Then
                    i = 8
                    year = year + 1
                ElseIf j = 21 Then
                    i = 9
                    year = year + 1
                ElseIf j = 22 Then
                    i = 10
                    year = year + 1
                ElseIf j = 23 Then
                    i = 11
                    year = year + 1
                ElseIf j = 24 Then
                    i = 12
                    year = year + 1
                End If
                cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txttoken.Text, dt.ToShortDateString(), i, year, StuID, txtname.Text, cmbclass.Text, cmbroll.Text)
            Next
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
            dgviewmonthly.Rows.Add()
            dgviewmonthly.Rows.Add()
            dgviewmonthly.Rows.Add()
            cmd.CommandText = "select * from YearlyFees where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and regno='" & StuID & "' and date='" & yaerlyfeesdate & "' and totalamt=" & yaerlyfeesamount & ""
            dr = cmd.ExecuteReader
            If dr.Read() Then
                dt = dr("date").ToString()
                token = dr("token").ToString()
                course = dr("course").ToString()
                clas = dr("class").ToString()
                reg = dr("regno").ToString()
                roll = dr("roll").ToString()
                txtname.Text = dr("name").ToString()
                txttime.Text = dr("time").ToString()
                payvia = dr("payvia").ToString()
                Dim yearly As Decimal = CDec(dr("yearlyfee").ToString())
                dgviewmonthly.Rows(0).Cells(0).Value = ""
                dgviewmonthly.Rows(0).Cells(1).Value = "Yearly Fees:"
                dgviewmonthly.Rows(0).Cells(2).Value = FormatNumber(yearly.ToString())
                YearlyFee = yearly
                dgviewmonthly.Rows(1).Cells(0).Value = ISDLibraryFeesAccount
                Dim librs As Decimal = CDec(dr("libraryrs").ToString())
                dgviewmonthly.Rows(1).Cells(1).Value = "Library Fees:"
                dgviewmonthly.Rows(1).Cells(2).Value = FormatNumber(librs.ToString())
                LibraryFee = librs
                dgviewmonthly.Rows(2).Cells(0).Value = ISDLateFeesAccount
                Dim late As Decimal = CDec(dr("laters").ToString())
                dgviewmonthly.Rows(2).Cells(1).Value = "Late Fees:"
                dgviewmonthly.Rows(2).Cells(2).Value = FormatNumber(late.ToString())
                LateFee = late
                dgviewmonthly.Rows(3).Cells(0).Value = ISDOtherFeesAccount
                Dim other As Decimal = CDec(dr("otherrs").ToString())
                dgviewmonthly.Rows(3).Cells(1).Value = "Other Fees:"
                dgviewmonthly.Rows(3).Cells(2).Value = FormatNumber(other.ToString())
                OtherFee = other
                Dim discch As Decimal = CDec(dr("discountcharge").ToString())
                dgviewmonthly.Rows(4).Cells(0).Value = ""
                dgviewmonthly.Rows(4).Cells(1).Value = "Discount Rate:"
                dgviewmonthly.Rows(4).Cells(2).Value = FormatNumber(discch.ToString())
                dgviewmonthly.Rows(5).Cells(0).Value = ISDDiscountFeesAccount
                Dim disc As Decimal = CDec(dr("discount").ToString())
                dgviewmonthly.Rows(5).Cells(1).Value = "Discount:"
                dgviewmonthly.Rows(5).Cells(2).Value = FormatNumber(disc.ToString())
                Discount = disc
                dgviewmonthly.Rows(6).Cells(0).Value = ISDYearlyFeesAccount
                Dim amt As Decimal = CDec(dr("totalamt").ToString())
                dgviewmonthly.Rows(6).Cells(1).Value = "Total:"
                dgviewmonthly.Rows(6).Cells(2).Value = FormatNumber(amt.ToString())
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

    Private Sub CheckTokenID()
        Try
            cmd.CommandText = "select * from YearlyFees where token='" & txttoken.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
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
                LoadYearlyFees(cmbcourse.Text, cmbclass.Text, cmbroll.Text)
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
            ETabControl1.SelectTab(TabPage2)
            dgviewbankinfo.Focus()
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
        If updateyaerlyfees = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updateyaerlyfees = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updateyaerlyfees = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updateyaerlyfees = False Then
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
            Dim total As Decimal = CDec(dgviewmonthly.Rows(6).Cells(2).Value.ToString())
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
                Dim monthly As Decimal = CDec(dgviewmonthly.Rows(0).Cells(2).Value.ToString())
                Dim library As Decimal = CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString())
                Dim late As Decimal = CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString())
                Dim other As Decimal = CDec(dgviewmonthly.Rows(3).Cells(2).Value.ToString())
                Dim discch As Decimal = CDec(dgviewmonthly.Rows(4).Cells(2).Value.ToString())
                Dim total As Decimal = monthly + library + late + other
                Dim disc As Decimal = (total * discch) / 100
                dgviewmonthly.Rows(5).Cells(2).Value = FormatNumber(disc.ToString())
                total = total - disc
                dgviewmonthly.Rows(6).Cells(2).Value = FormatNumber(total.ToString())
                txtpaid.Text = total.ToString()
                txtremaining.Text = "0.00"
            Else
                Dim val As Decimal = CDec(dgviewmonthly.Rows(i).Cells(2).Value.ToString())
                dgviewmonthly.Rows(i).Cells(2).Value = FormatNumber(val.ToString())
                Dim monthly As Decimal = CDec(dgviewmonthly.Rows(0).Cells(2).Value.ToString())
                Dim library As Decimal = CDec(dgviewmonthly.Rows(1).Cells(2).Value.ToString())
                Dim late As Decimal = CDec(dgviewmonthly.Rows(2).Cells(2).Value.ToString())
                Dim other As Decimal = CDec(dgviewmonthly.Rows(3).Cells(2).Value.ToString())
                Dim discch As Decimal = CDec(dgviewmonthly.Rows(4).Cells(2).Value.ToString())
                Dim total As Decimal = monthly + library + late + other
                Dim disc As Decimal = (total * discch) / 100
                dgviewmonthly.Rows(5).Cells(2).Value = FormatNumber(disc.ToString())
                total = total - disc
                dgviewmonthly.Rows(6).Cells(2).Value = FormatNumber(total.ToString())
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
    Private Sub frmYearlyFees_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updateyaerlyfees = False Then
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