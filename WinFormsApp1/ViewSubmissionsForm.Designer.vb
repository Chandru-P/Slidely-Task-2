<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewSubmissionsForm))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        lblName = New ListView()
        lblEmail = New ListView()
        lblGithub = New ListView()
        lblStopwatch = New ListView()
        lblPhone = New ListView()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(185, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(443, 42)
        Label1.TabIndex = 0
        Label1.Text = "Chandru slidely task 2 - Veiw Submission"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.BackColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(185, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 42)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.BackColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(185, 162)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 39)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.BackColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(185, 218)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 42)
        Label4.TabIndex = 3
        Label4.Text = "Phone Num"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(185, 278)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 40)
        Label5.TabIndex = 4
        Label5.Text = "GitHub Link" & vbCrLf & "for task 2" & vbCrLf
        ' 
        ' Label6
        ' 
        Label6.BackColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(185, 345)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 40)
        Label6.TabIndex = 5
        Label6.Text = "Stopwatch " & vbCrLf & "   time" & vbCrLf
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Gold
        btnPrevious.Location = New Point(185, 421)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(194, 42)
        btnPrevious.TabIndex = 6
        btnPrevious.Text = "PREVIOUS (CTRL +P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.DeepSkyBlue
        btnNext.Location = New Point(405, 421)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(226, 42)
        btnNext.TabIndex = 7
        btnNext.Text = "NEXT (CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' lblName
        ' 
        lblName.BackColor = Color.LightGray
        lblName.Location = New Point(315, 101)
        lblName.Name = "lblName"
        lblName.Size = New Size(313, 42)
        lblName.TabIndex = 8
        lblName.UseCompatibleStateImageBehavior = False
        ' 
        ' lblEmail
        ' 
        lblEmail.BackColor = Color.LightGray
        lblEmail.Location = New Point(315, 162)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(313, 39)
        lblEmail.TabIndex = 9
        lblEmail.UseCompatibleStateImageBehavior = False
        ' 
        ' lblGithub
        ' 
        lblGithub.BackColor = Color.LightGray
        lblGithub.Location = New Point(315, 278)
        lblGithub.Name = "lblGithub"
        lblGithub.Size = New Size(316, 40)
        lblGithub.TabIndex = 10
        lblGithub.UseCompatibleStateImageBehavior = False
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.BackColor = Color.LightGray
        lblStopwatch.Location = New Point(315, 345)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(316, 40)
        lblStopwatch.TabIndex = 11
        lblStopwatch.UseCompatibleStateImageBehavior = False
        ' 
        ' lblPhone
        ' 
        lblPhone.BackColor = Color.LightGray
        lblPhone.Location = New Point(315, 218)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(316, 42)
        lblPhone.TabIndex = 13
        lblPhone.UseCompatibleStateImageBehavior = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 521)
        Controls.Add(lblPhone)
        Controls.Add(lblStopwatch)
        Controls.Add(lblGithub)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblName As ListView
    Friend WithEvents lblEmail As ListView
    Friend WithEvents lblGithub As ListView
    Friend WithEvents lblStopwatch As ListView
    Friend WithEvents lblPhone As ListView
End Class
