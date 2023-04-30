#Region "Class cIndexx..."
Public Class cIndexx
#Region "Declarations..."
    Public ICode As String = ""
    Public AdminCode As String = ""
    Public DeptCode As String = ""
    Public DesigCode As String = ""
    Public PBCode As String = ""
    Public NCode As String = ""
    Public IDCode As String = ""
    Public AdmCode As String = ""
    Public PAdmCode As String = ""
    Public StuCode As String = ""
    Public XMCode As String = ""
    Public ASMCode As String = ""
    Public MarkID As String = ""
    Public ProgID As String = ""
    Public CtrlID As String = ""
    Public FCode As String = ""
    Public BCode As String = ""
    Public MCode As String = ""
    Public LCode As String = ""
    Public LiCode As String = ""
    Public OCode As String = ""
    Public YCode As String = ""
    Public DCode As String = ""
    Public EXFID As String = ""
    Public GRPID As String = ""
    Public SUBID As String = ""
    Public BKID As String = ""
    Public IID As String = ""
    Public InvID As String = ""
    Public PurID As String = ""
    Public InvoiID As String = ""
    Public GMID As String = ""
    Public CertID As String = ""
    Public SalID As String = ""
#End Region
#Region "Methods..."
    Public Function LoadInstitutionID() As String
        Try
            cmd.CommandText = "select InsID from InstituteIndex"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                ICode = dr("InsID").ToString()
                instituteindex = True
            Else
                ICode = "0"
                instituteindex = False
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
        Return ICode
    End Function

    Public Function LoadEmpID() As String
        Try
            cmd.CommandText = "select empid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            AdminCode = dr("empid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return AdminCode
    End Function

    Public Function LoadHiredEmpID() As String
        Try
            cmd.CommandText = "select hiredempid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            AdminCode = dr("hiredempid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return AdminCode
    End Function

    Public Function LoadDeptCode() As String
        Try
            cmd.CommandText = "select deptid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            DeptCode = dr("deptid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return DeptCode
    End Function

    Public Function LoadDesigCode() As String
        Try
            cmd.CommandText = "select desigid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            DesigCode = dr("desigid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return DesigCode
    End Function

    Public Function LoadPBCode() As String
        Try
            cmd.CommandText = "select pbid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            PBCode = dr("pbid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return PBCode
    End Function

    Public Function LoadNoticeID() As String
        Try
            cmd.CommandText = "select noticeid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            NCode = dr("noticeid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return NCode
    End Function

    Public Function LoadIDSerial() As String
        Try
            cmd.CommandText = "select idserial from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            IDCode = dr("idserial").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return IDCode
    End Function

    Public Function LoadAdmissionID() As String
        Try
            cmd.CommandText = "select admissionsl from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            AdmCode = dr("admissionsl").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return AdmCode
    End Function

    Public Function LoadPreAdmissionID() As String
        Try
            cmd.CommandText = "select preadmissionsl from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            PAdmCode = dr("preadmissionsl").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return PAdmCode
    End Function

    Public Function LoadStudentRegID() As String
        Try
            cmd.CommandText = "select sturegid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            StuCode = dr("sturegid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return StuCode
    End Function

    Public Function LoadExamCode() As String
        Try
            cmd.CommandText = "select examid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            XMCode = dr("examid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return XMCode
    End Function

    Public Function LoadOnlineExamID() As String
        Try
            cmd.CommandText = "select onlinexmid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            XMCode = dr("onlinexmid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return XMCode
    End Function

    Public Function LoadAssignmentID() As String
        Try
            cmd.CommandText = "select assignmentid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            ASMCode = dr("assignmentid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return ASMCode
    End Function

    Public Function LoadMarksheetCode() As String
        Try
            cmd.CommandText = "select markid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            MarkID = dr("markid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return MarkID
    End Function

    Public Function LoadProgressCode() As String
        Try
            cmd.CommandText = "select progressid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            ProgID = dr("progressid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return ProgID
    End Function

    Public Function LoadControlID() As String
        Try
            cmd.CommandText = "select controlid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            CtrlID = dr("controlid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return CtrlID
    End Function

    Public Function LoadFinancialNo() As String
        Try
            cmd.CommandText = "select financialid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            FCode = dr("financialid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return FCode
    End Function

    Public Function LoadBankDepositID() As String
        Try
            cmd.CommandText = "select depositid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            BCode = dr("depositid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return BCode
    End Function

    Public Function LoadMonthlyID() As String
        Try
            cmd.CommandText = "select monthlyid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            MCode = dr("monthlyid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return MCode
    End Function

    Public Function LoadLateID() As String
        Try
            cmd.CommandText = "select lateid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            BCode = dr("lateid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return BCode
    End Function

    Public Function LoadLibraryID() As String
        Try
            cmd.CommandText = "select libraryid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            LiCode = dr("libraryid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return LiCode
    End Function

    Public Function LoadOthersID() As String
        Try
            cmd.CommandText = "select othersid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            OCode = dr("othersid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return OCode
    End Function

    Public Function LoadYearlyID() As String
        Try
            cmd.CommandText = "select yearlyid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            YCode = dr("yearlyid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return YCode
    End Function

    Public Function LoadExamFeesID() As String
        Try
            cmd.CommandText = "select examfeesid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            EXFID = dr("examfeesid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return EXFID
    End Function

    Public Function LoadDiscountID() As String
        Try
            cmd.CommandText = "select discountid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            DCode = dr("discountid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return DCode
    End Function

    Public Function LoadGroupID() As String
        Try
            cmd.CommandText = "select groupid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            GRPID = dr("groupid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return GRPID
    End Function

    Public Function LoadSubjectBookID() As String
        Try
            cmd.CommandText = "select subjectid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            SUBID = dr("subjectid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return SUBID
    End Function

    Public Function LoadBookID() As String
        Try
            cmd.CommandText = "select bookid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            BKID = dr("bookid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return BKID
    End Function

    Public Function LoadIssuedID() As String
        Try
            cmd.CommandText = "select issueid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            IID = dr("issueid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return IID
    End Function

    Public Function LoadInventoryID() As String
        Try
            cmd.CommandText = "select inventoryid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            InvID = dr("inventoryid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return InvID
    End Function

    Public Function LoadPurchaseID() As String
        Try
            cmd.CommandText = "select purchaseid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            PurID = dr("purchaseid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return PurID
    End Function

    Public Function LoadInvoiceID() As String
        Try
            cmd.CommandText = "select invoiceid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            InvoiID = dr("invoiceid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return InvoiID
    End Function

    Public Function LoadGameID() As String
        Try
            cmd.CommandText = "select gameid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            GMID = dr("gameid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return GMID
    End Function

    Public Function LoadCertificateD() As String
        Try
            cmd.CommandText = "select certificateid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            CertID = dr("certificateid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return CertID
    End Function

    Public Function LoadSalaryID() As String
        Try
            cmd.CommandText = "select salaryid from Indexx where InsID='" & My.Settings.LastOpenedInstituteID & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            SalID = dr("salaryid").ToString()
            dr.Close()
        Catch ex As Exception

        End Try
        Return SalID
    End Function
#End Region
End Class
#End Region