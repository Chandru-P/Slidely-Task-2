<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateSubmissionForm))
        Label1 = New Label()
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGithub = New Label()
        btnStopwatch = New Button()
        btnSubmit = New Button()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithub = New TextBox()
        Timer1 = New Timer(components)
        lblStopwatch = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(161, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(403, 47)
        Label1.TabIndex = 0
        Label1.Text = "Chandru , slidely Task 2 - Create Submission"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblName
        ' 
        lblName.Location = New Point(161, 109)
        lblName.Name = "lblName"
        lblName.Size = New Size(119, 27)
        lblName.TabIndex = 1
        lblName.Text = "Name"
        lblName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblEmail
        ' 
        lblEmail.Location = New Point(161, 151)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(119, 27)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email"
        lblEmail.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPhone
        ' 
        lblPhone.Location = New Point(161, 193)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(119, 27)
        lblPhone.TabIndex = 3
        lblPhone.Text = "Phone Num"
        lblPhone.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblGithub
        ' 
        lblGithub.Location = New Point(161, 236)
        lblGithub.Name = "lblGithub"
        lblGithub.Size = New Size(119, 40)
        lblGithub.TabIndex = 4
        lblGithub.Text = "GitHub Link " & vbCrLf & "For Task 2 " & vbCrLf
        lblGithub.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnStopwatch
        ' 
        btnStopwatch.BackColor = Color.Gold
        btnStopwatch.Location = New Point(161, 300)
        btnStopwatch.Name = "btnStopwatch"
        btnStopwatch.Size = New Size(237, 40)
        btnStopwatch.TabIndex = 5
        btnStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        btnStopwatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.LightSkyBlue
        btnSubmit.Location = New Point(161, 368)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(403, 43)
        btnSubmit.TabIndex = 6
        btnSubmit.Text = "SUBMIT (CTRL+S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(320, 109)
        txtName.Name = "txtName"
        txtName.Size = New Size(244, 27)
        txtName.TabIndex = 7
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(320, 151)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(244, 27)
        txtEmail.TabIndex = 8
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(320, 193)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(244, 27)
        txtPhone.TabIndex = 9
        ' 
        ' txtGithub
        ' 
        txtGithub.Location = New Point(320, 236)
        txtGithub.Name = "txtGithub"
        txtGithub.Size = New Size(244, 27)
        txtGithub.TabIndex = 10
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.BackColor = SystemColors.ButtonHighlight
        lblStopwatch.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblStopwatch.Location = New Point(404, 303)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(160, 35)
        lblStopwatch.TabIndex = 12
        lblStopwatch.Text = "00:00:00"
        lblStopwatch.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1122, 644)
        Controls.Add(lblStopwatch)
        Controls.Add(txtGithub)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(btnSubmit)
        Controls.Add(btnStopwatch)
        Controls.Add(lblGithub)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(Label1)
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGithub As Label
    Friend WithEvents btnStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblStopwatch As Label
End Class
