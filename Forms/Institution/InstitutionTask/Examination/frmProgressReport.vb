#Region "Class frmProgressReport..."
Public Class frmProgressReport
#Region "Declarations..."
    Private ACODE As String = ""
    Private TT As String = ""
    Private DGVRegNo As New DataGridView()
    Private LanguageTexts_Next As String = "&Next"
    Private LanguageTexts_Finish As String = "&Finish"
    Private LanguageTexts_Back As String = "&Back"
    Private ProgressExist As Boolean = False
#End Region
#Region "Variables..."
    Private attendance As String = ""
    Private preparation As String = ""
    Private homework As String = ""
    Private takerisk As String = ""
    Private goals As String = ""
    Private plans As String = ""
    Private respect As String = ""
    Private cooperation As String = ""
    Private interest As String = ""
    Private motivation As String = ""
    Private outcomes As String = ""
    Private quality As String = ""
    Private keyterms As String = ""
    Private newconcept As String = ""
#End Region
#Region "Methods..."
    Public Sub GetCode()
        Dim Indx As New cIndexx()
        ACODE = Indx.LoadProgressCode()
        Dim var As String
        var = CodeIncrement(ACODE)
        Me.txtprogressid.Text = var
    End Sub

    Public Function CodeIncrement(ByVal CODE As String) As String
        Dim Temp As Integer = CInt(CODE)
        Temp += 1
        TT = String.Format("PRG:{0:00000000}", Temp)
        Return TT
    End Function

    Private Sub ControlSetBound()
        Label1.SetBounds(17, 56, 169, 13)
        Label10.SetBounds(13, 23, 106, 39)
        Label11.SetBounds(15, 34, 62, 13)
        Label12.SetBounds(15, 27, 114, 26)
        Label13.SetBounds(24, 35, 80, 13)
        Label14.SetBounds(31, 27, 167, 26)
        Label15.SetBounds(17, 18, 99, 13)
        Label16.SetBounds(594, 18, 80, 13)
        Label2.SetBounds(11, 89, 140, 13)
        Label3.SetBounds(15, 82, 152, 65)
        Label4.SetBounds(19, 38, 149, 13)
        Label5.SetBounds(27, 87, 144, 26)
        Label6.SetBounds(28, 53, 127, 13)
        Label7.SetBounds(23, 34, 92, 13)
        Label8.SetBounds(28, 34, 67, 13)
        Label9.SetBounds(15, 18, 113, 52)

        cmbregno.SetBounds(122, 15, 140, 21)
        txtprogressid.SetBounds(680, 15, 120, 21)

        btnback.SetBounds(619, 0, 90, 30)
        btnnext.SetBounds(709, 0, 90, 30)

        rbtnatten1.SetBounds(249, 42, 136, 17)
        rbtnatten2.SetBounds(249, 65, 135, 17)
        rbtnatten3.SetBounds(448, 42, 127, 17)
        rbtnatten4.SetBounds(448, 65, 158, 17)
        rbtnatten5.SetBounds(645, 42, 142, 17)
        rbtnatten6.SetBounds(645, 65, 141, 17)

        rbtnpreparation1.SetBounds(243, 23, 147, 17)
        rbtnpreparation2.SetBounds(243, 46, 158, 56)
        rbtnpreparation3.SetBounds(243, 107, 174, 17)
        rbtnpreparation4.SetBounds(243, 128, 185, 43)
        rbtnpreparation5.SetBounds(448, 45, 165, 17)
        rbtnpreparation6.SetBounds(448, 68, 136, 56)
        rbtnpreparation7.SetBounds(639, 42, 147, 30)
        rbtnpreparation8.SetBounds(639, 77, 154, 56)

        rbtnhomework1.SetBounds(210, 18, 188, 17)
        rbtnhomework2.SetBounds(210, 41, 151, 30)
        rbtnhomework3.SetBounds(440, 29, 142, 30)
        rbtnhomework4.SetBounds(629, 29, 157, 30)

        rbtntakerisk1.SetBounds(206, 16, 196, 30)
        rbtntakerisk10.SetBounds(625, 63, 164, 30)
        rbtntakerisk11.SetBounds(625, 98, 131, 30)
        rbtntakerisk12.SetBounds(625, 135, 143, 30)
        rbtntakerisk2.SetBounds(206, 48, 210, 30)
        rbtntakerisk3.SetBounds(206, 85, 183, 17)
        rbtntakerisk4.SetBounds(206, 110, 183, 30)
        rbtntakerisk5.SetBounds(206, 145, 175, 30)
        rbtntakerisk6.SetBounds(206, 182, 170, 30)
        rbtntakerisk7.SetBounds(436, 63, 151, 30)
        rbtntakerisk8.SetBounds(436, 99, 166, 30)
        rbtntakerisk9.SetBounds(436, 135, 168, 30)

        rbtngoal1.SetBounds(229, 41, 123, 17)
        rbtngoal2.SetBounds(229, 64, 150, 17)
        rbtngoal3.SetBounds(438, 46, 166, 30)
        rbtngoal4.SetBounds(627, 46, 156, 30)

        rbtnplan1.SetBounds(228, 80, 170, 17)
        rbtnplan2.SetBounds(228, 103, 197, 17)
        rbtnplan3.SetBounds(437, 85, 137, 30)
        rbtnplan4.SetBounds(626, 85, 157, 30)

        rbtnrespect1.SetBounds(224, 20, 122, 17)
        rbtnrespect2.SetBounds(224, 43, 149, 17)
        rbtnrespect3.SetBounds(433, 30, 140, 17)
        rbtnrespect4.SetBounds(630, 32, 155, 17)

        rbtncooperation1.SetBounds(224, 20, 133, 17)
        rbtncooperation2.SetBounds(224, 43, 160, 17)
        rbtncooperation3.SetBounds(433, 32, 151, 17)
        rbtncooperation4.SetBounds(630, 32, 166, 17)

        rbtninterest1.SetBounds(224, 25, 192, 30)
        rbtninterest2.SetBounds(433, 25, 175, 30)
        rbtninterest3.SetBounds(630, 25, 149, 30)

        rbtnmotivation1.SetBounds(224, 8, 164, 30)
        rbtnmotivation2.SetBounds(224, 44, 186, 30)
        rbtnmotivation3.SetBounds(433, 26, 182, 30)
        rbtnmotivation4.SetBounds(630, 20, 163, 43)

        rbtnoutcome1.SetBounds(131, 25, 101, 30)
        rbtnoutcome2.SetBounds(312, 25, 128, 30)
        rbtnoutcome3.SetBounds(459, 25, 119, 30)
        rbtnoutcome4.SetBounds(629, 25, 134, 30)

        rbtnquality1.SetBounds(131, 12, 139, 56)
        rbtnquality2.SetBounds(312, 12, 117, 56)
        rbtnquality3.SetBounds(459, 12, 124, 56)
        rbtnquality4.SetBounds(629, 12, 144, 56)

        rbtnkeyterms1.SetBounds(131, 19, 144, 43)
        rbtnkeyterms2.SetBounds(278, 21, 175, 43)
        rbtnkeyterms3.SetBounds(459, 19, 164, 43)
        rbtnkeyterms4.SetBounds(629, 19, 177, 43)

        rbtnnewconcept1.SetBounds(131, 22, 173, 43)
        rbtnnewconcept2.SetBounds(312, 13, 133, 56)
        rbtnnewconcept3.SetBounds(459, 13, 128, 56)
        rbtnnewconcept4.SetBounds(629, 14, 152, 56)
    End Sub

    Private Sub LoadRegNo()
        Try
            Dim col1 As New DataGridViewLinkColumn()
            With col1
                .HeaderText = "Registration No."
            End With
            Dim col2 As New DataGridViewTextBoxColumn()
            With col2
                .HeaderText = "Name"
            End With
            Dim col3 As New DataGridViewTextBoxColumn()
            With col3
                .HeaderText = "Course"
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
            Dim i As Integer = 0
            cmd.CommandText = "select stuid,name,course from StudentRegistration where InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            While dr.Read()
                DGVRegNo.Rows.Add()
                DGVRegNo.Rows(i).Cells(0).Value = dr("stuid").ToString()
                DGVRegNo.Rows(i).Cells(1).Value = dr("name").ToString()
                DGVRegNo.Rows(i).Cells(2).Value = dr("course").ToString()
                i = i + 1
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
            cmbregno.Text = StuID
        Catch ex As Exception

        End Try
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

    Private Sub AddRecord()
        Try
            If cmbregno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbregno.Focus()
                End If
            ElseIf txtprogressid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter progress report id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtprogressid.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    CheckProgressID()
                    If ProgressExist = False Then
                        If rbtnatten1.Checked = True Then
                            attendance = rbtnatten1.Text
                        ElseIf rbtnatten2.Checked = True Then
                            attendance = rbtnatten2.Text
                        ElseIf rbtnatten3.Checked = True Then
                            attendance = rbtnatten3.Text
                        ElseIf rbtnatten4.Checked = True Then
                            attendance = rbtnatten4.Text
                        ElseIf rbtnatten5.Checked = True Then
                            attendance = rbtnatten5.Text
                        ElseIf rbtnatten6.Checked = True Then
                            attendance = rbtnatten6.Text
                        Else
                            attendance = ""
                        End If

                        If rbtnpreparation1.Checked = True Then
                            preparation = rbtnpreparation1.Text
                        ElseIf rbtnpreparation2.Checked = True Then
                            preparation = rbtnpreparation2.Text
                        ElseIf rbtnpreparation3.Checked = True Then
                            preparation = rbtnpreparation3.Text
                        ElseIf rbtnpreparation4.Checked = True Then
                            preparation = rbtnpreparation4.Text
                        ElseIf rbtnpreparation5.Checked = True Then
                            preparation = rbtnpreparation5.Text
                        ElseIf rbtnpreparation6.Checked = True Then
                            preparation = rbtnpreparation6.Text
                        ElseIf rbtnpreparation7.Checked = True Then
                            preparation = rbtnpreparation7.Text
                        ElseIf rbtnpreparation8.Checked = True Then
                            preparation = rbtnpreparation8.Text
                        Else
                            preparation = ""
                        End If

                        If rbtnhomework1.Checked = True Then
                            homework = rbtnhomework1.Text
                        ElseIf rbtnhomework2.Checked = True Then
                            homework = rbtnhomework2.Text
                        ElseIf rbtnhomework3.Checked = True Then
                            homework = rbtnhomework3.Text
                        ElseIf rbtnhomework4.Checked = True Then
                            homework = rbtnhomework4.Text
                        Else
                            homework = ""
                        End If

                        If rbtntakerisk1.Checked = True Then
                            takerisk = rbtntakerisk1.Text
                        ElseIf rbtntakerisk2.Checked = True Then
                            takerisk = rbtntakerisk2.Text
                        ElseIf rbtntakerisk3.Checked = True Then
                            takerisk = rbtntakerisk3.Text
                        ElseIf rbtntakerisk4.Checked = True Then
                            takerisk = rbtntakerisk4.Text
                        ElseIf rbtntakerisk5.Checked = True Then
                            takerisk = rbtntakerisk5.Text
                        ElseIf rbtntakerisk6.Checked = True Then
                            takerisk = rbtntakerisk6.Text
                        ElseIf rbtntakerisk7.Checked = True Then
                            takerisk = rbtntakerisk7.Text
                        ElseIf rbtntakerisk8.Checked = True Then
                            takerisk = rbtntakerisk8.Text
                        ElseIf rbtntakerisk9.Checked = True Then
                            takerisk = rbtntakerisk9.Text
                        ElseIf rbtntakerisk10.Checked = True Then
                            takerisk = rbtntakerisk10.Text
                        ElseIf rbtntakerisk11.Checked = True Then
                            takerisk = rbtntakerisk11.Text
                        ElseIf rbtntakerisk12.Checked = True Then
                            takerisk = rbtntakerisk12.Text
                        Else
                            takerisk = ""
                        End If

                        If rbtngoal1.Checked = True Then
                            goals = rbtngoal1.Text
                        ElseIf rbtngoal2.Checked = True Then
                            goals = rbtngoal2.Text
                        ElseIf rbtngoal3.Checked = True Then
                            goals = rbtngoal3.Text
                        ElseIf rbtngoal4.Checked = True Then
                            goals = rbtngoal4.Text
                        Else
                            goals = ""
                        End If

                        If rbtnplan1.Checked = True Then
                            plans = rbtnplan1.Text
                        ElseIf rbtnplan2.Checked = True Then
                            plans = rbtnplan2.Text
                        ElseIf rbtnplan3.Checked = True Then
                            plans = rbtnplan3.Text
                        ElseIf rbtnplan4.Checked = True Then
                            plans = rbtnplan4.Text
                        Else
                            plans = ""
                        End If

                        If rbtnrespect1.Checked = True Then
                            respect = rbtnrespect1.Text
                        ElseIf rbtnrespect2.Checked = True Then
                            respect = rbtnrespect2.Text
                        ElseIf rbtnrespect3.Checked = True Then
                            respect = rbtnrespect3.Text
                        ElseIf rbtnrespect4.Checked = True Then
                            respect = rbtnrespect4.Text
                        Else
                            respect = ""
                        End If

                        If rbtncooperation1.Checked = True Then
                            cooperation = rbtncooperation1.Text
                        ElseIf rbtncooperation2.Checked = True Then
                            cooperation = rbtncooperation2.Text
                        ElseIf rbtncooperation3.Checked = True Then
                            cooperation = rbtncooperation3.Text
                        ElseIf rbtncooperation4.Checked = True Then
                            cooperation = rbtncooperation4.Text
                        Else
                            cooperation = ""
                        End If

                        If rbtninterest1.Checked = True Then
                            interest = rbtninterest1.Text
                        ElseIf rbtninterest2.Checked = True Then
                            interest = rbtninterest2.Text
                        ElseIf rbtninterest3.Checked = True Then
                            interest = rbtninterest3.Text
                        Else
                            interest = ""
                        End If

                        If rbtnmotivation1.Checked = True Then
                            motivation = rbtnmotivation1.Text
                        ElseIf rbtnmotivation2.Checked = True Then
                            motivation = rbtnmotivation2.Text
                        ElseIf rbtnmotivation3.Checked = True Then
                            motivation = rbtnmotivation3.Text
                        ElseIf rbtnmotivation4.Checked = True Then
                            motivation = rbtnmotivation4.Text
                        Else
                            motivation = ""
                        End If

                        If rbtnoutcome1.Checked = True Then
                            outcomes = rbtnoutcome1.Text
                        ElseIf rbtnoutcome2.Checked = True Then
                            outcomes = rbtnoutcome2.Text
                        ElseIf rbtnoutcome3.Checked = True Then
                            outcomes = rbtnoutcome3.Text
                        ElseIf rbtnoutcome4.Checked = True Then
                            outcomes = rbtnoutcome4.Text
                        Else
                            outcomes = ""
                        End If

                        If rbtnquality1.Checked = True Then
                            quality = rbtnquality1.Text
                        ElseIf rbtnquality2.Checked = True Then
                            quality = rbtnquality2.Text
                        ElseIf rbtnquality3.Checked = True Then
                            quality = rbtnquality3.Text
                        ElseIf rbtnquality4.Checked = True Then
                            quality = rbtnquality4.Text
                        Else
                            quality = ""
                        End If

                        If rbtnkeyterms1.Checked = True Then
                            keyterms = rbtnkeyterms1.Text
                        ElseIf rbtnkeyterms2.Checked = True Then
                            keyterms = rbtnkeyterms2.Text
                        ElseIf rbtnkeyterms3.Checked = True Then
                            keyterms = rbtnkeyterms3.Text
                        ElseIf rbtnkeyterms4.Checked = True Then
                            keyterms = rbtnkeyterms4.Text
                        Else
                            keyterms = ""
                        End If

                        If rbtnnewconcept1.Checked = True Then
                            newconcept = rbtnnewconcept1.Text
                        ElseIf rbtnnewconcept2.Checked = True Then
                            newconcept = rbtnnewconcept2.Text
                        ElseIf rbtnnewconcept3.Checked = True Then
                            newconcept = rbtnnewconcept3.Text
                        ElseIf rbtnnewconcept4.Checked = True Then
                            newconcept = rbtnnewconcept4.Text
                        Else
                            newconcept = ""
                        End If

                        Dim cls As New cProgressReport()
                        cls.AddRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtprogressid.Text, cmbregno.Text, attendance, preparation, homework, takerisk, goals, plans, respect, cooperation, interest, motivation, outcomes, quality, keyterms, newconcept)
                        If cls.AddRecordOk = True Then
                            Dim result1 As DialogResult = MessageBox.Show("Record added successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If result1 = Windows.Forms.DialogResult.OK Then
                                cmbregno.Focus()
                            End If
                        End If
                    Else
                        Dim result1 As DialogResult = MessageBox.Show("Progress report id already exist." + Environment.NewLine + "Please enter a new progress report id.", "Umbrella - Duplicate Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            txtprogressid.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            If cmbregno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbregno.Focus()
                End If
            ElseIf txtprogressid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter progress report id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtprogressid.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Accept all these!!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    If rbtnatten1.Checked = True Then
                        attendance = rbtnatten1.Text
                    ElseIf rbtnatten2.Checked = True Then
                        attendance = rbtnatten2.Text
                    ElseIf rbtnatten3.Checked = True Then
                        attendance = rbtnatten3.Text
                    ElseIf rbtnatten4.Checked = True Then
                        attendance = rbtnatten4.Text
                    ElseIf rbtnatten5.Checked = True Then
                        attendance = rbtnatten5.Text
                    ElseIf rbtnatten6.Checked = True Then
                        attendance = rbtnatten6.Text
                    Else
                        attendance = ""
                    End If

                    If rbtnpreparation1.Checked = True Then
                        preparation = rbtnpreparation1.Text
                    ElseIf rbtnpreparation2.Checked = True Then
                        preparation = rbtnpreparation2.Text
                    ElseIf rbtnpreparation3.Checked = True Then
                        preparation = rbtnpreparation3.Text
                    ElseIf rbtnpreparation4.Checked = True Then
                        preparation = rbtnpreparation4.Text
                    ElseIf rbtnpreparation5.Checked = True Then
                        preparation = rbtnpreparation5.Text
                    ElseIf rbtnpreparation6.Checked = True Then
                        preparation = rbtnpreparation6.Text
                    ElseIf rbtnpreparation7.Checked = True Then
                        preparation = rbtnpreparation7.Text
                    ElseIf rbtnpreparation8.Checked = True Then
                        preparation = rbtnpreparation8.Text
                    Else
                        preparation = ""
                    End If

                    If rbtnhomework1.Checked = True Then
                        homework = rbtnhomework1.Text
                    ElseIf rbtnhomework2.Checked = True Then
                        homework = rbtnhomework2.Text
                    ElseIf rbtnhomework3.Checked = True Then
                        homework = rbtnhomework3.Text
                    ElseIf rbtnhomework4.Checked = True Then
                        homework = rbtnhomework4.Text
                    Else
                        homework = ""
                    End If

                    If rbtntakerisk1.Checked = True Then
                        takerisk = rbtntakerisk1.Text
                    ElseIf rbtntakerisk2.Checked = True Then
                        takerisk = rbtntakerisk2.Text
                    ElseIf rbtntakerisk3.Checked = True Then
                        takerisk = rbtntakerisk3.Text
                    ElseIf rbtntakerisk4.Checked = True Then
                        takerisk = rbtntakerisk4.Text
                    ElseIf rbtntakerisk5.Checked = True Then
                        takerisk = rbtntakerisk5.Text
                    ElseIf rbtntakerisk6.Checked = True Then
                        takerisk = rbtntakerisk6.Text
                    ElseIf rbtntakerisk7.Checked = True Then
                        takerisk = rbtntakerisk7.Text
                    ElseIf rbtntakerisk8.Checked = True Then
                        takerisk = rbtntakerisk8.Text
                    ElseIf rbtntakerisk9.Checked = True Then
                        takerisk = rbtntakerisk9.Text
                    ElseIf rbtntakerisk10.Checked = True Then
                        takerisk = rbtntakerisk10.Text
                    ElseIf rbtntakerisk11.Checked = True Then
                        takerisk = rbtntakerisk11.Text
                    ElseIf rbtntakerisk12.Checked = True Then
                        takerisk = rbtntakerisk12.Text
                    Else
                        takerisk = ""
                    End If

                    If rbtngoal1.Checked = True Then
                        goals = rbtngoal1.Text
                    ElseIf rbtngoal2.Checked = True Then
                        goals = rbtngoal2.Text
                    ElseIf rbtngoal3.Checked = True Then
                        goals = rbtngoal3.Text
                    ElseIf rbtngoal4.Checked = True Then
                        goals = rbtngoal4.Text
                    Else
                        goals = ""
                    End If

                    If rbtnplan1.Checked = True Then
                        plans = rbtnplan1.Text
                    ElseIf rbtnplan2.Checked = True Then
                        plans = rbtnplan2.Text
                    ElseIf rbtnplan3.Checked = True Then
                        plans = rbtnplan3.Text
                    ElseIf rbtnplan4.Checked = True Then
                        plans = rbtnplan4.Text
                    Else
                        plans = ""
                    End If

                    If rbtnrespect1.Checked = True Then
                        respect = rbtnrespect1.Text
                    ElseIf rbtnrespect2.Checked = True Then
                        respect = rbtnrespect2.Text
                    ElseIf rbtnrespect3.Checked = True Then
                        respect = rbtnrespect3.Text
                    ElseIf rbtnrespect4.Checked = True Then
                        respect = rbtnrespect4.Text
                    Else
                        respect = ""
                    End If

                    If rbtncooperation1.Checked = True Then
                        cooperation = rbtncooperation1.Text
                    ElseIf rbtncooperation2.Checked = True Then
                        cooperation = rbtncooperation2.Text
                    ElseIf rbtncooperation3.Checked = True Then
                        cooperation = rbtncooperation3.Text
                    ElseIf rbtncooperation4.Checked = True Then
                        cooperation = rbtncooperation4.Text
                    Else
                        cooperation = ""
                    End If

                    If rbtninterest1.Checked = True Then
                        interest = rbtninterest1.Text
                    ElseIf rbtninterest2.Checked = True Then
                        interest = rbtninterest2.Text
                    ElseIf rbtninterest3.Checked = True Then
                        interest = rbtninterest3.Text
                    Else
                        interest = ""
                    End If

                    If rbtnmotivation1.Checked = True Then
                        motivation = rbtnmotivation1.Text
                    ElseIf rbtnmotivation2.Checked = True Then
                        motivation = rbtnmotivation2.Text
                    ElseIf rbtnmotivation3.Checked = True Then
                        motivation = rbtnmotivation3.Text
                    ElseIf rbtnmotivation4.Checked = True Then
                        motivation = rbtnmotivation4.Text
                    Else
                        motivation = ""
                    End If

                    If rbtnoutcome1.Checked = True Then
                        outcomes = rbtnoutcome1.Text
                    ElseIf rbtnoutcome2.Checked = True Then
                        outcomes = rbtnoutcome2.Text
                    ElseIf rbtnoutcome3.Checked = True Then
                        outcomes = rbtnoutcome3.Text
                    ElseIf rbtnoutcome4.Checked = True Then
                        outcomes = rbtnoutcome4.Text
                    Else
                        outcomes = ""
                    End If

                    If rbtnquality1.Checked = True Then
                        quality = rbtnquality1.Text
                    ElseIf rbtnquality2.Checked = True Then
                        quality = rbtnquality2.Text
                    ElseIf rbtnquality3.Checked = True Then
                        quality = rbtnquality3.Text
                    ElseIf rbtnquality4.Checked = True Then
                        quality = rbtnquality4.Text
                    Else
                        quality = ""
                    End If

                    If rbtnkeyterms1.Checked = True Then
                        keyterms = rbtnkeyterms1.Text
                    ElseIf rbtnkeyterms2.Checked = True Then
                        keyterms = rbtnkeyterms2.Text
                    ElseIf rbtnkeyterms3.Checked = True Then
                        keyterms = rbtnkeyterms3.Text
                    ElseIf rbtnkeyterms4.Checked = True Then
                        keyterms = rbtnkeyterms4.Text
                    Else
                        keyterms = ""
                    End If

                    If rbtnnewconcept1.Checked = True Then
                        newconcept = rbtnnewconcept1.Text
                    ElseIf rbtnnewconcept2.Checked = True Then
                        newconcept = rbtnnewconcept2.Text
                    ElseIf rbtnnewconcept3.Checked = True Then
                        newconcept = rbtnnewconcept3.Text
                    ElseIf rbtnnewconcept4.Checked = True Then
                        newconcept = rbtnnewconcept4.Text
                    Else
                        newconcept = ""
                    End If

                    Dim cls As New cProgressReport()
                    cls.UpdateRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtprogressid.Text, cmbregno.Text, attendance, preparation, homework, takerisk, goals, plans, respect, cooperation, interest, motivation, outcomes, quality, keyterms, newconcept)
                    If cls.UpdateRecordOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record updated successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
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
            If cmbregno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter registration no.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    cmbregno.Focus()
                End If
            ElseIf txtprogressid.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Please enter progress report id.", "Umbrella - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.OK Then
                    txtprogressid.Focus()
                End If
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure want to delete this record?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.Yes Then
                    Dim cls As New cProgressReport()
                    cls.DeleteRecord(My.Settings.LastOpenedInstituteID, My.Settings.LastOpenedInstitute, My.Settings.Period, UmbrellaSystemDate, txtprogressid.Text)
                    If cls.DeleteRecordOk = True Then
                        Dim result1 As DialogResult = MessageBox.Show("Record deleted successfully.", "Umbrella - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result1 = Windows.Forms.DialogResult.OK Then
                            cmbregno.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadSelectedRecord()
        Try
            cmd.CommandText = "select stuid,progressid,attendance,preparation,homework,takerisk,goals,plans,respect,cooperation,interest,motivation,outcomes,quality,keyterms,newconcept from ProgressReport where progressid='" & progessid & "' and stuid='" & StuID & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            cmbregno.Text = dr("stuid").ToString()
            txtprogressid.Text = dr("progressid").ToString()
            If rbtnatten1.Text = dr("attendance").ToString() Then
                rbtnatten1.Checked = True
            ElseIf rbtnatten2.Text = dr("attendance").ToString() Then
                rbtnatten2.Checked = True
            ElseIf rbtnatten3.Text = dr("attendance").ToString() Then
                rbtnatten3.Checked = True
            ElseIf rbtnatten4.Text = dr("attendance").ToString() Then
                rbtnatten4.Checked = True
            ElseIf rbtnatten5.Text = dr("attendance").ToString() Then
                rbtnatten5.Checked = True
            ElseIf rbtnatten6.Text = dr("attendance").ToString() Then
                rbtnatten6.Checked = True
            End If
            If rbtncooperation1.Text = dr("cooperation").ToString() Then
                rbtncooperation1.Checked = True
            ElseIf rbtncooperation2.Text = dr("cooperation").ToString() Then
                rbtncooperation2.Checked = True
            ElseIf rbtncooperation3.Text = dr("cooperation").ToString() Then
                rbtncooperation3.Checked = True
            ElseIf rbtncooperation4.Text = dr("cooperation").ToString() Then
                rbtncooperation4.Checked = True
            End If
            If rbtngoal1.Text = dr("goals").ToString() Then
                rbtngoal1.Checked = True
            ElseIf rbtngoal2.Text = dr("goals").ToString() Then
                rbtngoal2.Checked = True
            ElseIf rbtngoal3.Text = dr("goals").ToString() Then
                rbtngoal3.Checked = True
            ElseIf rbtngoal4.Text = dr("goals").ToString() Then
                rbtngoal4.Checked = True
            End If
            If rbtnhomework1.Text = dr("homework").ToString() Then
                rbtnhomework1.Checked = True
            ElseIf rbtnhomework2.Text = dr("homework").ToString() Then
                rbtnhomework2.Checked = True
            ElseIf rbtnhomework3.Text = dr("homework").ToString() Then
                rbtnhomework3.Checked = True
            ElseIf rbtnhomework4.Text = dr("homework").ToString() Then
                rbtnhomework4.Checked = True
            End If
            If rbtninterest1.Text = dr("interest").ToString() Then
                rbtninterest1.Checked = True
            ElseIf rbtninterest2.Text = dr("interest").ToString() Then
                rbtninterest2.Checked = True
            ElseIf rbtninterest3.Text = dr("interest").ToString() Then
                rbtninterest3.Checked = True
            End If
            If rbtnkeyterms1.Text = dr("keyterms").ToString() Then
                rbtnkeyterms1.Checked = True
            ElseIf rbtnkeyterms2.Text = dr("keyterms").ToString() Then
                rbtnkeyterms2.Checked = True
            ElseIf rbtnkeyterms3.Text = dr("keyterms").ToString() Then
                rbtnkeyterms3.Checked = True
            ElseIf rbtnkeyterms4.Text = dr("keyterms").ToString() Then
                rbtnkeyterms4.Checked = True
            End If
            If rbtnmotivation1.Text = dr("motivation").ToString() Then
                rbtnmotivation1.Checked = True
            ElseIf rbtnmotivation2.Text = dr("motivation").ToString() Then
                rbtnmotivation2.Checked = True
            ElseIf rbtnmotivation3.Text = dr("motivation").ToString() Then
                rbtnmotivation3.Checked = True
            ElseIf rbtnmotivation4.Text = dr("motivation").ToString() Then
                rbtnmotivation4.Checked = True
            End If
            If rbtnnewconcept1.Text = dr("newconcept").ToString() Then
                rbtnnewconcept1.Checked = True
            ElseIf rbtnnewconcept2.Text = dr("newconcept").ToString() Then
                rbtnnewconcept2.Checked = True
            ElseIf rbtnnewconcept3.Text = dr("newconcept").ToString() Then
                rbtnnewconcept3.Checked = True
            ElseIf rbtnnewconcept4.Text = dr("newconcept").ToString() Then
                rbtnnewconcept4.Checked = True
            End If
            If rbtnoutcome1.Text = dr("outcomes").ToString() Then
                rbtnoutcome1.Checked = True
            ElseIf rbtnoutcome2.Text = dr("outcomes").ToString() Then
                rbtnoutcome2.Checked = True
            ElseIf rbtnoutcome3.Text = dr("outcomes").ToString() Then
                rbtnoutcome3.Checked = True
            ElseIf rbtnoutcome4.Text = dr("outcomes").ToString() Then
                rbtnoutcome4.Checked = True
            End If
            If rbtnplan1.Text = dr("plans").ToString() Then
                rbtnplan1.Checked = True
            ElseIf rbtnplan2.Text = dr("plans").ToString() Then
                rbtnplan2.Checked = True
            ElseIf rbtnplan3.Text = dr("plans").ToString() Then
                rbtnplan3.Checked = True
            ElseIf rbtnplan4.Text = dr("plans").ToString() Then
                rbtnplan4.Checked = True
            End If
            If rbtnpreparation1.Text = dr("preparation").ToString() Then
                rbtnpreparation1.Checked = True
            ElseIf rbtnpreparation2.Text = dr("preparation").ToString() Then
                rbtnpreparation2.Checked = True
            ElseIf rbtnpreparation3.Text = dr("preparation").ToString() Then
                rbtnpreparation3.Checked = True
            ElseIf rbtnpreparation4.Text = dr("preparation").ToString() Then
                rbtnpreparation4.Checked = True
            ElseIf rbtnpreparation5.Text = dr("preparation").ToString() Then
                rbtnpreparation5.Checked = True
            ElseIf rbtnpreparation6.Text = dr("preparation").ToString() Then
                rbtnpreparation6.Checked = True
            ElseIf rbtnpreparation7.Text = dr("preparation").ToString() Then
                rbtnpreparation7.Checked = True
            ElseIf rbtnpreparation8.Text = dr("preparation").ToString() Then
                rbtnpreparation8.Checked = True
            End If
            If rbtnquality1.Text = dr("quality").ToString() Then
                rbtnquality1.Checked = True
            ElseIf rbtnquality2.Text = dr("quality").ToString() Then
                rbtnquality2.Checked = True
            ElseIf rbtnquality3.Text = dr("quality").ToString() Then
                rbtnquality3.Checked = True
            ElseIf rbtnquality4.Text = dr("quality").ToString() Then
                rbtnquality4.Checked = True
            End If
            If rbtnrespect1.Text = dr("respect").ToString() Then
                rbtnrespect1.Checked = True
            ElseIf rbtnrespect2.Text = dr("respect").ToString() Then
                rbtnrespect2.Checked = True
            ElseIf rbtnrespect3.Text = dr("respect").ToString() Then
                rbtnrespect3.Checked = True
            ElseIf rbtnrespect4.Text = dr("respect").ToString() Then
                rbtnrespect4.Checked = True
            End If
            If rbtntakerisk1.Text = dr("takerisk").ToString() Then
                rbtntakerisk1.Checked = True
            ElseIf rbtntakerisk2.Text = dr("takerisk").ToString() Then
                rbtntakerisk2.Checked = True
            ElseIf rbtntakerisk3.Text = dr("takerisk").ToString() Then
                rbtntakerisk3.Checked = True
            ElseIf rbtntakerisk4.Text = dr("takerisk").ToString() Then
                rbtntakerisk4.Checked = True
            ElseIf rbtntakerisk5.Text = dr("takerisk").ToString() Then
                rbtntakerisk5.Checked = True
            ElseIf rbtntakerisk6.Text = dr("takerisk").ToString() Then
                rbtntakerisk6.Checked = True
            ElseIf rbtntakerisk7.Text = dr("takerisk").ToString() Then
                rbtntakerisk7.Checked = True
            ElseIf rbtntakerisk8.Text = dr("takerisk").ToString() Then
                rbtntakerisk8.Checked = True
            ElseIf rbtntakerisk9.Text = dr("takerisk").ToString() Then
                rbtntakerisk9.Checked = True
            ElseIf rbtntakerisk10.Text = dr("takerisk").ToString() Then
                rbtntakerisk10.Checked = True
            ElseIf rbtntakerisk11.Text = dr("takerisk").ToString() Then
                rbtntakerisk11.Checked = True
            ElseIf rbtntakerisk12.Text = dr("takerisk").ToString() Then
                rbtntakerisk12.Checked = True
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub ResetForm()
        updateprogessreport = False
        cmbregno.Text = ""
        If ISDAutoID = "Yes" Then
            GetCode()
        Else
            txtprogressid.Text = ""
        End If
        rbtnatten1.Checked = False
        rbtnatten2.Checked = False
        rbtnatten3.Checked = False
        rbtnatten4.Checked = False
        rbtnatten5.Checked = False
        rbtnatten6.Checked = False
        rbtncooperation1.Checked = False
        rbtncooperation2.Checked = False
        rbtncooperation3.Checked = False
        rbtncooperation4.Checked = False
        rbtngoal1.Checked = False
        rbtngoal2.Checked = False
        rbtngoal3.Checked = False
        rbtngoal4.Checked = False
        rbtnhomework1.Checked = False
        rbtnhomework2.Checked = False
        rbtnhomework3.Checked = False
        rbtnhomework4.Checked = False
        rbtninterest1.Checked = False
        rbtninterest2.Checked = False
        rbtninterest3.Checked = False
        rbtnkeyterms1.Checked = False
        rbtnkeyterms2.Checked = False
        rbtnkeyterms3.Checked = False
        rbtnkeyterms4.Checked = False
        rbtnmotivation1.Checked = False
        rbtnmotivation2.Checked = False
        rbtnmotivation3.Checked = False
        rbtnmotivation4.Checked = False
        rbtnnewconcept1.Checked = False
        rbtnnewconcept2.Checked = False
        rbtnnewconcept3.Checked = False
        rbtnnewconcept4.Checked = False
        rbtnoutcome1.Checked = False
        rbtnoutcome2.Checked = False
        rbtnoutcome3.Checked = False
        rbtnoutcome4.Checked = False
        rbtnplan1.Checked = False
        rbtnplan2.Checked = False
        rbtnplan3.Checked = False
        rbtnplan4.Checked = False
        rbtnpreparation1.Checked = False
        rbtnpreparation2.Checked = False
        rbtnpreparation3.Checked = False
        rbtnpreparation4.Checked = False
        rbtnpreparation5.Checked = False
        rbtnpreparation6.Checked = False
        rbtnpreparation7.Checked = False
        rbtnpreparation8.Checked = False
        rbtnquality1.Checked = False
        rbtnquality2.Checked = False
        rbtnquality3.Checked = False
        rbtnquality4.Checked = False
        rbtnrespect1.Checked = False
        rbtnrespect2.Checked = False
        rbtnrespect3.Checked = False
        rbtnrespect4.Checked = False
        rbtntakerisk1.Checked = False
        rbtntakerisk10.Checked = False
        rbtntakerisk11.Checked = False
        rbtntakerisk12.Checked = False
        rbtntakerisk2.Checked = False
        rbtntakerisk3.Checked = False
        rbtntakerisk4.Checked = False
        rbtntakerisk5.Checked = False
        rbtntakerisk6.Checked = False
        rbtntakerisk7.Checked = False
        rbtntakerisk8.Checked = False
        rbtntakerisk9.Checked = False
        cmbregno.Focus()
    End Sub

    Private Sub CheckProgressID()
        Try
            cmd.CommandText = "select * from ProgressReport where progressid='" & txtprogressid.Text & "' and InsID='" & My.Settings.LastOpenedInstituteID & "' and InsName='" & My.Settings.LastOpenedInstitute & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                ProgressExist = True
            Else
                ProgressExist = False
            End If
            dr.Close()
        Catch ex As Exception
            ProgressExist = False
            dr.Close()
        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmProgressReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If updateprogessreport = False Then
            ControlSetBound()
            LoadRegNo()
            btnnext.Text = LanguageTexts_Next
            btnback.Text = LanguageTexts_Back
            btnback.Enabled = False
            ETabControlEx1.HideTabs = True
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadRegNo()
            btnnext.Text = LanguageTexts_Next
            btnback.Text = LanguageTexts_Back
            btnback.Enabled = False
            ETabControlEx1.HideTabs = True
            LoadSelectedRecord()
        End If
        If USprogressreport = "View Only" Then
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnsavenew.Enabled = False
            cmbregno.Enabled = False
            txtprogressid.ReadOnly = True
            rbtnatten1.Enabled = False
            rbtnatten2.Enabled = False
            rbtnatten3.Enabled = False
            rbtnatten4.Enabled = False
            rbtnatten5.Enabled = False
            rbtnatten6.Enabled = False
            rbtncooperation1.Enabled = False
            rbtncooperation2.Enabled = False
            rbtncooperation3.Enabled = False
            rbtncooperation4.Enabled = False
            rbtngoal1.Enabled = False
            rbtngoal2.Enabled = False
            rbtngoal3.Enabled = False
            rbtngoal4.Enabled = False
            rbtnhomework1.Enabled = False
            rbtnhomework2.Enabled = False
            rbtnhomework3.Enabled = False
            rbtnhomework4.Enabled = False
            rbtninterest1.Enabled = False
            rbtninterest2.Enabled = False
            rbtninterest3.Enabled = False
            rbtnkeyterms1.Enabled = False
            rbtnkeyterms2.Enabled = False
            rbtnkeyterms3.Enabled = False
            rbtnkeyterms4.Enabled = False
            rbtnmotivation1.Enabled = False
            rbtnmotivation2.Enabled = False
            rbtnmotivation3.Enabled = False
            rbtnmotivation4.Enabled = False
            rbtnnewconcept1.Enabled = False
            rbtnnewconcept2.Enabled = False
            rbtnnewconcept3.Enabled = False
            rbtnnewconcept4.Enabled = False
            rbtnoutcome1.Enabled = False
            rbtnoutcome2.Enabled = False
            rbtnoutcome3.Enabled = False
            rbtnoutcome4.Enabled = False
            rbtnplan1.Enabled = False
            rbtnplan2.Enabled = False
            rbtnplan3.Enabled = False
            rbtnplan4.Enabled = False
            rbtnpreparation1.Enabled = False
            rbtnpreparation2.Enabled = False
            rbtnpreparation3.Enabled = False
            rbtnpreparation4.Enabled = False
            rbtnpreparation5.Enabled = False
            rbtnpreparation6.Enabled = False
            rbtnpreparation7.Enabled = False
            rbtnpreparation8.Enabled = False
            rbtnquality1.Enabled = False
            rbtnquality2.Enabled = False
            rbtnquality3.Enabled = False
            rbtnquality4.Enabled = False
            rbtnrespect1.Enabled = False
            rbtnrespect2.Enabled = False
            rbtnrespect3.Enabled = False
            rbtnrespect4.Enabled = False
            rbtntakerisk1.Enabled = False
            rbtntakerisk10.Enabled = False
            rbtntakerisk11.Enabled = False
            rbtntakerisk12.Enabled = False
            rbtntakerisk2.Enabled = False
            rbtntakerisk3.Enabled = False
            rbtntakerisk4.Enabled = False
            rbtntakerisk5.Enabled = False
            rbtntakerisk6.Enabled = False
            rbtntakerisk7.Enabled = False
            rbtntakerisk8.Enabled = False
            rbtntakerisk9.Enabled = False
        End If
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnnext_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnext.ClickButtonArea
        If btnnext.Tag = "finish" Then
            ETabControlEx1.SelectedIndex = 0
            btnnext.Text = LanguageTexts_Next
            CheckTabPageAndUpdateButtons()
        Else
            GoToTab()
        End If
    End Sub

    Private Sub btnback_ClickButtonArea(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnback.ClickButtonArea
        If btnback.Tag = "" Then
            GoToTab(-1)
        End If
    End Sub

    Private Sub btnnew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnew.ClickButtonArea
        ResetForm()
    End Sub

    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        If updateprogessreport = False Then
            AddRecord()
        Else
            UpdateRecord()
        End If
    End Sub

    Private Sub btnsavenew_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsavenew.ClickButtonArea
        If updateprogessreport = False Then
            AddRecord()
            ResetForm()
        Else
            UpdateRecord()
            ResetForm()
        End If
    End Sub

    Private Sub btndelete_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndelete.ClickButtonArea
        If updateprogessreport = True Then
            DeleteRecord()
        End If
    End Sub

    Private Sub btnrefresh_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrefresh.ClickButtonArea
        If updateprogessreport = False Then
            ControlSetBound()
            LoadRegNo()
            btnnext.Text = LanguageTexts_Next
            btnback.Text = LanguageTexts_Back
            btnback.Enabled = False
            ETabControlEx1.HideTabs = True
            If ISDAutoID = "Yes" Then
                GetCode()
            End If
        Else
            ControlSetBound()
            LoadRegNo()
            btnnext.Text = LanguageTexts_Next
            btnback.Text = LanguageTexts_Back
            btnback.Enabled = False
            ETabControlEx1.HideTabs = True
            LoadSelectedRecord()
        End If
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub
#End Region
End Class
#End Region