#Region "Class frmGlobalSettings..."
Public Class frmGlobalSettings
#Region "Methods..."
    Private Sub ControlSetBound()
        lnkstandard.SetBounds(214, 74, 187, 13)
        Label1.SetBounds(17, 41, 96, 13)
        Label2.SetBounds(17, 76, 100, 13)
        Label3.SetBounds(214, 41, 102, 13)
        btnreset.SetBounds(48, 54, 100, 40)
        cmbprice.SetBounds(322, 38, 40, 21)
        cmbqnty.SetBounds(123, 40, 40, 21)
        cmbstandard.SetBounds(123, 73, 40, 21)
        rbtndecimalentry1.SetBounds(38, 39, 82, 17)
        rbtndecimalentry2.SetBounds(38, 74, 65, 17)
        rbtnitementry1.SetBounds(20, 39, 59, 17)
        rbtnitementry2.SetBounds(20, 84, 59, 17)
        rbtnsecurity1.SetBounds(40, 45, 321, 17)
        rbtnsecurity2.SetBounds(40, 68, 465, 17)
        rbtnsecurity3.SetBounds(40, 91, 348, 17)
        chkdataentry1.SetBounds(31, 40, 181, 17)
        chkdataentry2.SetBounds(31, 63, 313, 17)
        chkdataentry3.SetBounds(31, 86, 197, 17)
        chkoption1.SetBounds(38, 49, 269, 17)
        chkoption2.SetBounds(38, 72, 150, 17)
        chkoption3.SetBounds(38, 95, 472, 17)
        chkoption4.SetBounds(38, 118, 467, 17)
        chkoption5.SetBounds(38, 141, 359, 17)
        chkperformance1.SetBounds(20, 32, 361, 17)
        chkperformance2.SetBounds(20, 55, 335, 17)
        chkperformance3.SetBounds(20, 78, 429, 17)
        chkperformance4.SetBounds(20, 101, 349, 17)
    End Sub

    Private Sub LoadGlobalSettings()
        If DecimalEntry = rbtndecimalentry1.Text Then
            rbtndecimalentry1.Checked = True
        ElseIf DecimalEntry = rbtndecimalentry2.Text Then
            rbtndecimalentry2.Checked = True
        End If
        cmbprice.Text = PriceField.ToString()
        cmbqnty.Text = QntyField.ToString()
        cmbstandard.Text = StandardField.ToString()
        If Option1 = "Yes" Then
            chkoption1.Checked = True
        Else
            chkoption1.Checked = False
        End If
        If Option2 = "Yes" Then
            chkoption2.Checked = True
        Else
            chkoption2.Checked = False
        End If
        If Option3 = "Yes" Then
            chkoption3.Checked = True
        Else
            chkoption3.Checked = False
        End If
        If Option4 = "Yes" Then
            chkoption4.Checked = True
        Else
            chkoption4.Checked = False
        End If
        If Option5 = "Yes" Then
            chkoption5.Checked = True
        Else
            chkoption5.Checked = False
        End If
        If Performance1 = "Yes" Then
            chkperformance1.Checked = True
        Else
            chkperformance1.Checked = False
        End If
        If Performance2 = "Yes" Then
            chkperformance2.Checked = True
        Else
            chkperformance2.Checked = False
        End If
        If Performance3 = "Yes" Then
            chkperformance3.Checked = True
        Else
            chkperformance3.Checked = False
        End If
        If Performance4 = "Yes" Then
            chkperformance4.Checked = True
        Else
            chkperformance4.Checked = False
        End If
        If ItemEntry = rbtnitementry1.Text Then
            rbtnitementry1.Checked = True
        ElseIf ItemEntry = rbtnitementry2.Text Then
            rbtnitementry2.Checked = True
        End If
        If DataEntry1 = "Yes" Then
            chkdataentry1.Checked = True
        Else
            chkdataentry1.Checked = False
        End If
        If DataEntry2 = "Yes" Then
            chkdataentry2.Checked = True
        Else
            chkdataentry2.Checked = False
        End If
        If DataEntry3 = "Yes" Then
            chkdataentry3.Checked = True
        Else
            chkdataentry3.Checked = False
        End If
        If PartnerSecurity = rbtnsecurity1.Text Then
            rbtnsecurity1.Checked = True
        ElseIf PartnerSecurity = rbtnsecurity2.Text Then
            rbtnsecurity2.Checked = True
        ElseIf PartnerSecurity = rbtnsecurity3.Text Then
            rbtnsecurity3.Checked = True
        End If
    End Sub

    Private Sub UpdateGlobalSettings()
        Try
            Dim result As DialogResult = MessageBox.Show("Accept all these !!!", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                cmd.CommandText = "delete from GlobalSettings"
                dr = cmd.ExecuteReader
                dr.Close()
                If rbtndecimalentry1.Checked = True Then
                    DecimalEntry = rbtndecimalentry1.Text
                ElseIf rbtndecimalentry2.Checked = True Then
                    DecimalEntry = rbtndecimalentry2.Text
                End If
                PriceField = CInt(cmbprice.Text)
                QntyField = CInt(cmbqnty.Text)
                StandardField = CInt(cmbstandard.Text)
                If chkoption1.Checked = True Then
                    Option1 = "Yes"
                Else
                    Option1 = "No"
                End If
                If chkoption2.Checked = True Then
                    Option2 = "Yes"
                Else
                    Option2 = "No"
                End If
                If chkoption3.Checked = True Then
                    Option3 = "Yes"
                Else
                    Option3 = "No"
                End If
                If chkoption4.Checked = True Then
                    Option4 = "Yes"
                Else
                    Option4 = "No"
                End If
                If chkoption5.Checked = True Then
                    Option5 = "Yes"
                Else
                    Option5 = "No"
                End If
                If chkperformance1.Checked = True Then
                    Performance1 = "Yes"
                Else
                    Performance1 = "No"
                End If
                If chkperformance2.Checked = True Then
                    Performance2 = "Yes"
                Else
                    Performance2 = "No"
                End If
                If chkperformance3.Checked = True Then
                    Performance3 = "Yes"
                Else
                    Performance3 = "No"
                End If
                If chkperformance4.Checked = True Then
                    Performance4 = "Yes"
                Else
                    Performance4 = "No"
                End If
                If rbtnitementry1.Checked = True Then
                    ItemEntry = rbtnitementry1.Text
                ElseIf rbtnitementry2.Checked = True Then
                    ItemEntry = rbtnitementry2.Text
                End If
                If chkdataentry1.Checked = True Then
                    DataEntry1 = "Yes"
                Else
                    DataEntry1 = "No"
                End If
                If chkdataentry2.Checked = True Then
                    DataEntry2 = "Yes"
                Else
                    DataEntry2 = "No"
                End If
                If chkdataentry3.Checked = True Then
                    DataEntry3 = "Yes"
                Else
                    DataEntry3 = "No"
                End If
                If rbtnsecurity1.Checked = True Then
                    PartnerSecurity = rbtnsecurity1.Text
                ElseIf rbtnsecurity2.Checked = True Then
                    PartnerSecurity = rbtnsecurity2.Text
                ElseIf rbtnsecurity3.Checked = True Then
                    PartnerSecurity = rbtnsecurity3.Text
                End If
                cmd.CommandText = "insert into GlobalSettings(decimalentry,qntyfield,pricefield,standardfield,option1,option2,option3,option4,option5,performance1,performance2,performance3,performance4,itementry,dataentry1,dataentry2,dataentry3,partnersecurity) values ('" & DecimalEntry & "'," & QntyField & "," & PriceField & "," & StandardField & ",'" & Option1 & "','" & Option2 & "','" & Option3 & "','" & Option4 & "','" & Option5 & "','" & Performance1 & "','" & Performance2 & "','" & Performance3 & "','" & Performance4 & "','" & ItemEntry & "','" & DataEntry1 & "','" & DataEntry2 & "','" & DataEntry3 & "','" & PartnerSecurity & "')"
                dr = cmd.ExecuteReader
                dr.Close()
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetGlobalSettings()
        Try
            Dim result As DialogResult = MessageBox.Show("Are you sure want to reset global settings?", "Umbrella - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                cmd.CommandText = "delete from GlobalSettings"
                dr = cmd.ExecuteReader
                dr.Close()

                DecimalEntry = "Manual"
                QntyField = 2
                PriceField = 2
                StandardField = 2
                Option1 = "Yes"
                Option2 = "No"
                Option3 = "No"
                Option4 = "No"
                Option5 = "No"
                Performance1 = "Yes"
                Performance2 = "No"
                Performance3 = "No"
                Performance4 = "No"
                ItemEntry = "Line 1"
                DataEntry1 = "Yes"
                DataEntry2 = "Yes"
                DataEntry3 = "Yes"
                PartnerSecurity = "Medium - Warn before Umbrella partner applications to run (Recommended)."

                cmd.CommandText = "insert into GlobalSettings(decimalentry,qntyfield,pricefield,standardfield,option1,option2,option3,option4,option5,performance1,performance2,performance3,performance4,itementry,dataentry1,dataentry2,dataentry3,partnersecurity) values ('" & DecimalEntry & "'," & QntyField & "," & PriceField & "," & StandardField & ",'" & Option1 & "','" & Option2 & "','" & Option3 & "','" & Option4 & "','" & Option5 & "','" & Performance1 & "','" & Performance2 & "','" & Performance3 & "','" & Performance4 & "','" & ItemEntry & "','" & DataEntry1 & "','" & DataEntry2 & "','" & DataEntry3 & "','" & PartnerSecurity & "')"
                dr = cmd.ExecuteReader
                dr.Close()
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Events..."
    Private Sub frmGlobalSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlSetBound()
        LoadGlobalSettings()
    End Sub
#End Region
#Region "Button Events..."
    Private Sub btnsave_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsave.ClickButtonArea
        UpdateGlobalSettings()
    End Sub

    Private Sub btnhelp_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhelp.ClickButtonArea

    End Sub

    Private Sub btnreset_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnreset.ClickButtonArea
        ResetGlobalSettings()
    End Sub
#End Region
End Class
#End Region