Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports System.Drawing
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text.Encoder
Imports ESAR_Controls.UIControls.eForms

Public Class frmClient

    Dim flag As Integer = 0
    Dim flagLang As Integer = 0
    Dim checkConnection As Integer = 0
    Dim socketHandler As Socket
    Dim ipHostEntry As IPHostEntry
    Dim ipAddress As IPAddress
    Dim localEndPoint As IPEndPoint
    Dim sendMsg() As Byte
    Dim receiveMsg As String
    Dim chatName As String
    Dim urduString As String
    Dim thread1 As Thread
    Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" _
    (ByVal lpCommandString As String, ByVal lpReturnString As String, _
    ByVal uReturnLength As Long, ByVal hwndCallback As Long) As Long
    Dim Docker As New FormDocker(Me, FormDocker.FormDockMode.BottomRight, New Padding(5))

    Delegate Sub SetDisplay(ByVal [Text] As String)

    Private Sub btnOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.Click
        If flag = 0 Then
            Me.btnOptions.Text = "<<Hide Options"
            Dim height As Integer = Me.Size.Height
            height = 480
            While height <= 615
                Me.Size = New Size(Me.Size.Width, height)
                Me.Refresh()
                height += 15
            End While
            flag = 1
        ElseIf flag = 1 Then
            Me.btnOptions.Text = "Show Options>>"
            Dim height As Integer = Me.Size.Height
            height = 480
            Me.Size = New Size(Me.Size.Width, height)
            flag = 0
        End If
    End Sub

    Private Sub frmClient_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If checkConnection = 1 Then
            thread1.Abort()
            socketHandler.Shutdown(SocketShutdown.Both)
            socketHandler.Close()
        End If

        Dim processToKill As Process
        Dim processQueue As Process() = Process.GetProcessesByName("ChatClient.exe")
        For Each processToKill In processQueue
            processToKill.Kill()
        Next
    End Sub

    Private Sub frmClient_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Save()
    End Sub

    Private Sub frmClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Docker.DockForm()
        Docker.UndockForm()
        Docker.DockForm()
        Me.Size = New Size(355, 480)
        Me.socketHandler = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Me.GroupBox1.Enabled = False
        Me.btnOptions.Enabled = False
        Me.btnConnectServer.Enabled = False
        Me.txtEnglish.Visible = True
        Me.txtUrdu.Visible = False
        Dim toolTipFont As New ToolTip()
        toolTipFont.SetToolTip(btnFont, "Change Font")
        Dim toolTipColor As New ToolTip()
        toolTipColor.SetToolTip(btnColor, "Change Text Color")
        Me.txtName.Text = My.Settings.ChatName
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Process.Start("calc.exe")
    End Sub

    Private Sub btnPaint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaint.Click
        Process.Start("mspaint.exe")
    End Sub

    Private Sub btnNotepad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotepad.Click
        Process.Start("notepad.exe")
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Try
            With OpenFileDialog1
                .Filter = "All files (*.*)|*.*"
                .FileName = ""
                .Multiselect = False
                .Title = "Select A File To Send"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    sendFileText.Text = .FileName
                Else
                    Return
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        mciSendString("set CDAudio door open", "", 0, 0)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        mciSendString("set CDAudio door closed", "", 0, 0)
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Try
            If flagLang = 0 Then
                Dim chatNameIp As String = chatName.ToUpper() & " (" & ipAddress.ToString() & ")" & " Says : "
                sendMsg = Encoding.ASCII.GetBytes(chatNameIp & txtEnglish.Text)
                Me.socketHandler.Send(sendMsg)
                Me.msgListBox.Items.Add("Me Says : ".ToUpper() & txtEnglish.Text)
                txtEnglish.Text = ""
            ElseIf flagLang = 1 Then
                sendMsg = Nothing
                sendMsg = Encoding.ASCII.GetBytes(chatName.ToUpper() & " Says : ".ToUpper() & txtUrdu.Text)
                Me.socketHandler.Send(sendMsg)
                Me.msgListBox.Items.Add("Me Says : ".ToUpper() & txtUrdu.Text)
                txtUrdu.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Receive()
        Try
            Dim bytes(100000) As Byte
            Dim bytesRec As Integer
            While True
                bytes = New Byte(100000) {}
                bytesRec = socketHandler.Receive(bytes)
                If bytesRec > 0 Then
                    receiveMsg = Encoding.ASCII.GetString(bytes, 0, bytesRec)
                    Exit While
                End If
            End While
            proccessData(receiveMsg)
            'ActionData(Data)
            'GoTo A
        Catch ex As Exception
            MsgBox("Server Is Not Responding")
        End Try
    End Sub

    Public Sub Connect()
        Try
            ipHostEntry = Dns.GetHostEntry(Dns.GetHostName())
            ipAddress = ipHostEntry.AddressList(0)
            localEndPoint = New IPEndPoint(ipAddress, 1100)
            socketHandler.Connect(localEndPoint)
            thread1 = New Thread(AddressOf Receive)
            thread1.Start()
            checkConnection = 1
            MessageBox.Show(chatName.ToUpper() & " Connected With Main Server ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub proccessData(ByVal str As String)
        If Me.msgListBox.InvokeRequired Then
            Dim d As New SetDisplay(AddressOf proccessData)
            Me.Invoke(d, New Object() {str})
        Else
            Me.msgListBox.Items.Add(str)
        End If
    End Sub

    Private Sub btnConnectServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnectServer.Click
        Connect()
        btnConnectServer.Enabled = False
    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        If txtName.Text.Equals("") Then
            MessageBox.Show("Must Enter Chat Name To Start Chatting", "Important Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Not txtName.Text.Equals("") Then
            My.Settings.ChatName = txtName.Text
            chatName = txtName.Text
            txtName.Text = String.Empty
            GroupBox1.Enabled = True
            btnOptions.Enabled = True
            btnConnectServer.Enabled = True
            GroupBox2.Enabled = False
            Me.Text = "Welcome , " + chatName.ToUpper()
        End If
    End Sub

    Private Sub btnFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFont.Click
        With FontDialog1
            .ShowDialog()
            txtEnglish.Font = .Font
        End With
    End Sub

    Private Sub btnColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColor.Click
        With ColorDialog1
            .ShowDialog()
            txtEnglish.ForeColor = .Color
        End With
    End Sub

    Private Sub btnBuddy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuddy.Click
        frmConnectIP.Show()
    End Sub

    Private Sub ConnectBuddyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectBuddyToolStripMenuItem.Click
        frmConnectIP.Show()
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadToolStripMenuItem.Click
        Process.Start("notepad.exe")
    End Sub

    Private Sub PaintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaintToolStripMenuItem.Click
        Process.Start("mspaint.exe")
    End Sub

    Private Sub CalculatorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem1.Click
        Process.Start("calc.exe")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub txtName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnConfirm_Click(sender, e)
        End If
    End Sub

    Public Sub changeToUrdu()
        Me.txtUrdu.TextAlign = HorizontalAlignment.Right
        Me.txtUrdu.Visible = True
        Me.txtEnglish.Visible = False
        flagLang = 1
    End Sub

    Public Sub changeToEnglish()
        Me.txtEnglish.TextAlign = HorizontalAlignment.Left
        Me.txtEnglish.Visible = True
        Me.txtUrdu.Visible = False
        flagLang = 0
    End Sub

    Private Sub EnglishToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnglishToolStripMenuItem.Click
        changeToEnglish()
    End Sub

    Private Sub UrduToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UrduToolStripMenuItem.Click
        changeToUrdu()
    End Sub

    Private Sub txtUrdu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUrdu.KeyPress
        If flagLang = 1 Then
            If e.KeyChar >= "A"c And e.KeyChar <= "Z"c Or (e.KeyChar >= "a"c And e.KeyChar <= "z"c) Then
                urduString &= Urdu.ToUrdu(e.KeyChar.ToString())
            Else
                If Asc(e.KeyChar) = 8 And Not (urduString Is Nothing) Then
                    If urduString.Length >= 1 And Not (urduString Is Nothing) Then
                        urduString = urduString.Remove((urduString.Length - 1))
                    End If
                Else
                    If Asc(e.KeyChar) = 32 Then
                        If urduString.Length >= 1 Then
                            urduString &= e.KeyChar.ToString()
                        End If
                    End If
                End If
            End If
        End If
        txtUrdu.Text = urduString
    End Sub

    Private Sub txtUrdu_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUrdu.TextChanged
        txtUrdu.Text = urduString
    End Sub

    Private Sub frmClient_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        Docker.Refresh()
    End Sub

    Private Sub frmClient_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Docker.Refresh()
    End Sub
End Class
