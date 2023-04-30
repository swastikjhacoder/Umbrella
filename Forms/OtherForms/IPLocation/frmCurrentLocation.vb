Public Class frmCurrentLocation
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents ParseButton As System.Windows.Forms.Button
    Friend WithEvents MaximumDOP As System.Windows.Forms.TextBox
    Friend WithEvents MaximumDOPLabel As System.Windows.Forms.Label
    Friend WithEvents MaximumErrorLabel As System.Windows.Forms.Label
    Friend WithEvents MaximumError As System.Windows.Forms.TextBox
    Friend WithEvents NMEAData As System.Windows.Forms.TextBox
    Friend WithEvents NMEADataLabel As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ParseButton = New System.Windows.Forms.Button()
        Me.MaximumDOP = New System.Windows.Forms.TextBox()
        Me.MaximumDOPLabel = New System.Windows.Forms.Label()
        Me.MaximumErrorLabel = New System.Windows.Forms.Label()
        Me.MaximumError = New System.Windows.Forms.TextBox()
        Me.NMEAData = New System.Windows.Forms.TextBox()
        Me.NMEADataLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ParseButton
        '
        Me.ParseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ParseButton.Location = New System.Drawing.Point(213, 171)
        Me.ParseButton.Name = "ParseButton"
        Me.ParseButton.TabIndex = 1
        Me.ParseButton.Text = "Parse"
        '
        'MaximumDOP
        '
        Me.MaximumDOP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
          Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaximumDOP.Location = New System.Drawing.Point(9, 30)
        Me.MaximumDOP.Name = "MaximumDOP"
        Me.MaximumDOP.Size = New System.Drawing.Size(123, 20)
        Me.MaximumDOP.TabIndex = 2
        Me.MaximumDOP.Text = "6"
        '
        'MaximumDOPLabel
        '
        Me.MaximumDOPLabel.Location = New System.Drawing.Point(9, 9)
        Me.MaximumDOPLabel.Name = "MaximumDOPLabel"
        Me.MaximumDOPLabel.Size = New System.Drawing.Size(135, 15)
        Me.MaximumDOPLabel.TabIndex = 3
        Me.MaximumDOPLabel.Text = "Maximum Allowed HDOP:"
        '
        'MaximumErrorLabel
        '
        Me.MaximumErrorLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaximumErrorLabel.Location = New System.Drawing.Point(159, 9)
        Me.MaximumErrorLabel.Name = "MaximumErrorLabel"
        Me.MaximumErrorLabel.Size = New System.Drawing.Size(129, 15)
        Me.MaximumErrorLabel.TabIndex = 4
        Me.MaximumErrorLabel.Text = "Maximum Error (Meters):"
        '
        'MaximumError
        '
        Me.MaximumError.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaximumError.Location = New System.Drawing.Point(159, 30)
        Me.MaximumError.Name = "MaximumError"
        Me.MaximumError.Size = New System.Drawing.Size(129, 20)
        Me.MaximumError.TabIndex = 5
        Me.MaximumError.Text = "36"
        '
        'NMEAData
        '
        Me.NMEAData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
          Or System.Windows.Forms.AnchorStyles.Left) _
          Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NMEAData.Location = New System.Drawing.Point(9, 87)
        Me.NMEAData.Multiline = True
        Me.NMEAData.Name = "NMEAData"
        Me.NMEAData.Size = New System.Drawing.Size(279, 78)
        Me.NMEAData.TabIndex = 6
        Me.NMEAData.Text = "$GPGSA,A,1,,,,,,,,,,,,,50.0,50.0,50.0*05" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "$GPRMC,225233.990,V,3939.4000,N,10506.4" & _
        "000,W,0.00,51.40,280804,,*35" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "$GPGSA,A,3,11,29,07,08,19,28,26,,,,,,2.3,1.2,2.0*3" & _
        "0" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "$GPRMC,012558.584,A,3939.7000,N,10506.7000,W,0.00,198.07,290804,,*11"
        '
        'NMEADataLabel
        '
        Me.NMEADataLabel.Location = New System.Drawing.Point(9, 66)
        Me.NMEADataLabel.Name = "NMEADataLabel"
        Me.NMEADataLabel.Size = New System.Drawing.Size(129, 15)
        Me.NMEADataLabel.TabIndex = 7
        Me.NMEADataLabel.Text = "NMEA Data:"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(298, 203)
        Me.Controls.Add(Me.NMEADataLabel)
        Me.Controls.Add(Me.NMEAData)
        Me.Controls.Add(Me.MaximumError)
        Me.Controls.Add(Me.MaximumErrorLabel)
        Me.Controls.Add(Me.MaximumDOPLabel)
        Me.Controls.Add(Me.MaximumDOP)
        Me.Controls.Add(Me.ParseButton)
        Me.Name = "Form1"
        Me.Text = "High-Precision GPS Example"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents MyInterpreter As New NmeaInterpreter()
    Private CurrentHDOP As Double

    Private Sub OnHDOPReceived(ByVal value As Double) Handles MyInterpreter.HDOPReceived
        ' Remember the current HDOP value
        CurrentHDOP = value
    End Sub

    Private Sub OnPositionReceived(ByVal latitude As String, ByVal longitude As String) Handles MyInterpreter.PositionReceived
        ' Get the maximum allowable DOP value
        Dim MaximumAllowedDOP As Double = Double.Parse(MaximumDOP.Text)
        ' Is the HDOP at least six?
        If CurrentHDOP <= MaximumAllowedDOP Then
            ' Yes.  Display the current position
            MessageBox.Show("You are here: " & latitude & ", " & longitude, "Precise Position Received", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' No.  Discard this positional measurement
            MessageBox.Show("The received location is not precise enough to use: " & latitude & ", " & longitude, "Imprecise Position Received", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Parses each line of NMEA in the text box
    Private Sub ParseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParseButton.Click
        Dim Sentence As String
        For Each Sentence In NMEAData.Lines
            ' Was the sentence processsed?
            If Not MyInterpreter.Parse(Sentence) Then
                ' No.  Notify the user that processing failed
                Throw New ArgumentException("An NMEA sentence was not recognized.  Please check spelling or omit unrecognized sentences, then try again.")
            End If
        Next
    End Sub

    ' Racalculates maximum allowable error
    Private Sub MaximumDOP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaximumDOP.TextChanged
        If MaximumDOP.Text = "" Then MaximumDOP.Text = "0"
        Dim DOP As Double = Double.Parse(MaximumDOP.Text)
        MaximumError.Text = DOP * 6.0
    End Sub

    ' Racalculates maximum allowable DOP
    Private Sub MaximumError_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaximumError.TextChanged
        If MaximumError.Text = "" Then MaximumError.Text = "0"
        Dim ErrorInMeters As Double = Double.Parse(MaximumError.Text)
        MaximumDOP.Text = ErrorInMeters / 6.0
    End Sub
End Class
