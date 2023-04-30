#Region "Imports..."
Imports ESAR_Controls.UIControls.TextBox
#End Region
#Region "Class frmGames..."
Public Class frmGames
#Region "Declarations..."
    Private ACODE As String = ""
    Private TT As String = ""
    Private DGVCourse As New DataGridView()
    Private GameExpense As Decimal = 0.0
    Private GameExist As Boolean = False
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        ACODE = Indx.LoadGameID()
        Dim var As String
        var = CodeIncrement(ACODE)
        Me.txtgameid.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("GM:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        Label1.SetBounds(495, 138, 134, 13)
        Label10.SetBounds(11, 106, 80, 13)
        Label11.SetBounds(11, 22, 64, 13)
        Label2.SetBounds(11, 49, 103, 13)
        Label3.SetBounds(321, 49, 98, 13)
        Label4.SetBounds(11, 76, 68, 13)
        Label5.SetBounds(321, 76, 80, 13)
        Label6.SetBounds(11, 138, 77, 13)
        Label7.SetBounds(321, 138, 78, 13)
        Label8.SetBounds(321, 106, 60, 13)
        lblaccount.SetBounds(509, 106, 0, 13)

        cmbdepartment.SetBounds(120, 103, 189, 21)
        cmbgamecategory.SetBounds(120, 46, 189, 21)
        cmbgamedate.SetBounds(120, 135, 108, 21)
        cmbgamefor.SetBounds(120, 73, 189, 21)

        txtexpense.SetBounds(425, 103, 71, 21)
        txtgameid.SetBounds(120, 19, 108, 21)
        txtgamename.SetBounds(425, 46, 379, 21)
        txtgameplace.SetBounds(425, 73, 379, 21)

        mskgametime.SetBounds(425, 138, 40, 14)
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

            cmbdepartment.AddDataGridView(DGVCourse, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVCourse_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Try
            Dim k As Integer = DGVCourse.CurrentRow.Index
            DGVCourse.Rows(k).Selected = True
            DGVCourse.CurrentCell = DGVCourse.Rows(k).Cells(0)
            crsname = DGVCourse.Rows(k).Cells(1).Value.ToString()
            cmbdepartment.Text = crsname
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadDataGrid()
        Try
            Dim i As Integer = 0
            dgviewgame.Rows.Clear()
            cmd.CommandText = "select gameid,gamename,category,gamefor,date,time,gameplace from Game where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                dgviewgame.Rows.Add()
                dgviewgame.Rows(i).Cells(0).Value = dr("gameid").ToString()
                dgviewgame.Rows(i).Cells(1).Value = dr("gamename").ToString()
                dgviewgame.Rows(i).Cells(2).Value = dr("category").ToString()
                dgviewgame.Rows(i).Cells(3).Value = dr("gamefor").ToString()
                dgviewgame.Rows(i).Cells(4).Value = dr("date").ToString()
                dgviewgame.Rows(i).Cells(5).Value = dr("time").ToString()
                dgviewgame.Rows(i).Cells(6).Value = dr("gameplace").ToString()
                i = i + 1
            End While
            dr.Close()
            dgviewgame.ClearSelection()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub ResetForm()
        updategame = False
        gameid = ""
        cmbgamedate.Text = UmbrellaSystemDate
        mskgametime.Text = Date.Now.ToShortTimeString()
        LoadDataGrid()
        lblaccount.Text = "Expense Account: " + ISDGameExpense
        cmbdepartment.Text = ""
        cmbgamecategory.Text = ""
        cmbgamefor.Text = ""
        txtexpense.Text = ""
        txtgamename.Text = ""
        txtgameplace.Text = ""
        If ISDAutoID = "Yes" Then
            GetCode()
        Else
            txtgameid.Text = ""
        End If
        txtgameid.Focus()
    End Sub

    Private Sub AddRecord()
        Try
            If txtgameid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter game id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtgameid.Focus()
                End If
            ElseIf cmbgamecategory.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select game category.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbgamecategory.Focus()
                End If
            ElseIf cmbgamedate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbgamedate.Focus()
                End If
            ElseIf cmbgamefor.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select game for.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbgamefor.Focus()
                End If
            ElseIf txtexpense.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter expense amount.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtexpense.Focus()
                End If
            ElseIf txtgamename.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter game name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtgamename.Focus()
                End If
            ElseIf txtgameplace.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter game place.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtgameplace.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    CheckGameID()
                    If GameExist = False Then
                        Dim gameid As String = txtgameid.Text
                        Dim category As String = cmbgamecategory.Text
                        Dim gamefor As String = cmbgamefor.Text
                        Dim department As String = ""
                        If cmbdepartment.Visible = True Then
                            department = cmbdepartment.Text
                        Else
                            department = ""
                        End If
                        Dim dte As String = cmbgamedate.Text
                        Dim time As String = mskgametime.Text
                        Dim gamename As String = txtgamename.Text
                        Dim gameplace As String = txtgameplace.Text
                        Dim expense As Decimal = CDec(txtexpense.Text)
                        Dim account As String = ISDGameExpense
                        Dim cls As New cGame()
                        cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, gameid, category, gamefor, department, dte, time, gamename, gameplace, expense, account)
                        If cls.AddRecordOk = True Then
                            cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & expense & " where AccountID='" & ISDGameExpense & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                            dr = cmd.ExecuteReader
                            dr.Close()
                            Dim dt As Date = Date.Parse(cmbgamedate.Text)
                            Dim month As Integer = dt.Month
                            Dim year As Integer = dt.Year
                            Dim description As String = "Game Expense"
                            Dim type As String = "Expenditure"
                            Dim clas As String = ""
                            Dim roll As String = ""
                            Dim name As String = ""
                            Dim regno As String = ""
                            cmd.CommandText = "insert into IncomeExpenditure(InsID,InsName,Period,SystemDate,transactionid,descriptions,type,amount,class,roll,regno,name,month,year,account) values ('" & My.Settings.LastOpenedInstituteID & "','" & My.Settings.LastOpenedInstitute & "','" & My.Settings.Period & "','" & UmbrellaSystemDate & "','" & txtgameid.Text & "','" & description & "','" & type & "'," & CDec(txtexpense.Text) & ",'" & clas & "','" & roll & "','" & regno & "','" & name & "'," & month & "," & year & ",'" & ISDGameExpense & "')"
                            dr = cmd.ExecuteReader
                            dr.Close()
                            Dim result1 As DialogResult = MessageBox.Show("Record added successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = Windows.Forms.DialogResult.OK Then
                                LoadDataGrid()
                                txtgameid.Focus()
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Game id already exist." + Environment.NewLine + "Please enter a new game id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            txtgameid.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If txtgameid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter game id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtgameid.Focus()
                End If
            ElseIf cmbgamecategory.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select game category.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbgamecategory.Focus()
                End If
            ElseIf cmbgamedate.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select date.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbgamedate.Focus()
                End If
            ElseIf cmbgamefor.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter/select game for.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbgamefor.Focus()
                End If
            ElseIf txtexpense.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter expense amount.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtexpense.Focus()
                End If
            ElseIf txtgamename.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter game name.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtgamename.Focus()
                End If
            ElseIf txtgameplace.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter game place.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtgameplace.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & GameExpense & " where AccountID='" & ISDGameExpense & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                    dr = cmd.ExecuteReader
                    dr.Close()
                    Dim gameid As String = txtgameid.Text
                    Dim category As String = cmbgamecategory.Text
                    Dim gamefor As String = cmbgamefor.Text
                    Dim department As String = ""
                    If cmbdepartment.Visible = True Then
                        department = cmbdepartment.Text
                    Else
                        department = ""
                    End If
                    Dim dte As String = cmbgamedate.Text
                    Dim time As String = mskgametime.Text
                    Dim gamename As String = txtgamename.Text
                    Dim gameplace As String = txtgameplace.Text
                    Dim expense As Decimal = CDec(txtexpense.Text)
                    Dim account As String = ISDGameExpense
                    Dim cls As New cGame()
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, gameid, category, gamefor, department, dte, time, gamename, gameplace, expense, account)
                    If cls.UpdateRecordOk = True Then
                        Dim dt As Date = Date.Parse(cmbgamedate.Text)
                        Dim month As Integer = dt.Month
                        Dim year As Integer = dt.Year
                        Dim description As String = "Game Expense"
                        Dim type As String = "Expenditure"
                        Dim clas As String = ""
                        Dim roll As String = ""
                        Dim name As String = ""
                        Dim regno As String = ""
                        cmd.CommandText = "update IncomeExpenditure set SystemDate='" & UmbrellaSystemDate & "',amount=" & CDec(txtexpense.Text) & ",regno='" & regno & "',name='" & name & "',month=" & month & ",year=" & year & ",account='" & ISDGameExpense & "' where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and transactionid='" & txtgameid.Text & "' and descriptions='" & description & "' and type='" & type & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance-" & expense & " where AccountID='" & ISDGameExpense & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            LoadDataGrid()
                            txtgameid.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            If txtgameid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter game id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtgameid.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cGame()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtgameid.Text)
                    If cls.DeleteRecordOk = True Then
                        Dim dt As Date = Date.Parse(cmbgamedate.Text)
                        Dim month As Integer = dt.Month
                        Dim year As Integer = dt.Year
                        Dim description As String = "Game Expense"
                        Dim type As String = "Expenditure"
                        Dim clas As String = ""
                        Dim roll As String = ""
                        Dim name As String = ""
                        Dim regno As String = ""
                        cmd.CommandText = "delete from IncomeExpenditure where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "' and transactionid='" & txtgameid.Text & "' and descriptions='" & description & "' and type='" & type & "' and class='" & clas & "' and roll='" & roll & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        cmd.CommandText = "update Accounts set AccountBalance=AccountBalance+" & GameExpense & " where AccountID='" & ISDGameExpense & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
                        dr = cmd.ExecuteReader
                        dr.Close()
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully...", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
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
            cmd.CommandText = "select account,department,category,date,gamefor,expense,gameid,gamename,gameplace,time from Game where gameid='" & gameid & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                cmbdepartment.Text = dr("department").ToString()
                cmbgamecategory.Text = dr("category").ToString()
                cmbgamedate.Text = dr("date").ToString()
                cmbgamefor.Text = dr("gamefor").ToString()
                txtexpense.Text = dr("expense").ToString()
                GameExpense = CDec(dr("expense").ToString())
                txtgameid.Text = dr("gameid").ToString()
                txtgamename.Text = dr("gamename").ToString()
                txtgameplace.Text = dr("gameplace").ToString()
                mskgametime.Text = dr("time").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CheckGameID()
        Try
            cmd.CommandText = "select * from Game where gameid='" & txtgameid.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                GameExist = True
            Else
                GameExist = False
            End If
            dr.Close()
        Catch ex As Exception
            GameExist = False
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmGames_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updategame = False Then
            ControlSetBound()
            LoadCourse()
            LoadDataGrid()
            cmbgamedate.Text = UmbrellaSystemDate
            mskgametime.Text = Date.Now.ToShortTimeString()
            lblaccount.Text = "Expense Account: " + ISDGameExpense
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadCourse()
            LoadDataGrid()
            LoadSelectedRecord()
            lblaccount.Text = "Expense Account: " + ISDGameExpense
        End If
        If USgames = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbdepartment.Enabled = False
            cmbgamecategory.Enabled = False
            cmbgamedate.Enabled = False
            cmbgamefor.Enabled = False
            txtexpense.ReadOnly = True
            txtgameid.ReadOnly = True
            txtgamename.ReadOnly = True
            txtgameplace.ReadOnly = True
            mskgametime.ReadOnly = True
            dgviewgame.Enabled = False
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updategame = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updategame = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updategame = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updategame = False Then
            ControlSetBound()
            LoadCourse()
            LoadDataGrid()
            cmbgamedate.Text = UmbrellaSystemDate
            mskgametime.Text = Date.Now.ToShortTimeString()
            lblaccount.Text = "Expense Account: " + ISDGameExpense
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadCourse()
            LoadDataGrid()
            LoadSelectedRecord()
            lblaccount.Text = "Expense Account: " + ISDGameExpense
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
#Region "Attributes..."
    Private Sub txtgameid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtgameid.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            cmbgamecategory.Focus()
        End If
    End Sub

    Private Sub cmbgamecategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbgamecategory.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbgamefor.Focus()
        End If
    End Sub

    Private Sub cmbgamefor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbgamefor.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbgamefor.Text <> "" Then
                If cmbgamefor.Text = "Selected Departments" Then
                    Label10.Visible = True
                    cmbdepartment.Visible = True
                    cmbdepartment.Focus()
                Else
                    Label10.Visible = False
                    cmbdepartment.Visible = False
                    cmbgamedate.Focus()
                End If
            Else
                cmbgamedate.Focus()
            End If
        End If
    End Sub

    Private Sub cmbgamefor_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbgamefor.TextChanged
        If cmbgamefor.Text <> "" Then
            If cmbgamefor.Text = "Selected Departments" Then
                Label10.Visible = True
                cmbdepartment.Visible = True
            Else
                Label10.Visible = False
                cmbdepartment.Visible = False
            End If
        End If
    End Sub

    Private Sub cmbdepartment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdepartment.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbgamedate.Focus()
        End If
    End Sub

    Private Sub cmbgamedate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbgamedate.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtgamename.Focus()
        End If
    End Sub

    Private Sub txtgamename_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtgamename.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtgameplace.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbgamedate.Focus()
        End If
    End Sub

    Private Sub txtgameplace_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtgameplace.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtexpense.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtgamename.Focus()
        End If
    End Sub

    Private Sub txtexpense_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtexpense.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            mskgametime.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtgameplace.Focus()
        End If
    End Sub

    Private Sub mskgametime_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskgametime.KeyDown
        If e.KeyCode = Keys.Up Then
            txtexpense.Focus()
        End If
    End Sub

    Private Sub ComboBoxKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbdepartment.KeyPress, cmbgamecategory.KeyPress, cmbgamedate.KeyPress, cmbgamefor.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtgamename.TextChanged, txtgameplace.TextChanged
        Dim ctc As New cTextChange()
        Dim x As eTextBox = CType(sender, eTextBox)
        ctc.ConvertTextBoxValidValue(x)
    End Sub
#End Region
End Class
#End Region