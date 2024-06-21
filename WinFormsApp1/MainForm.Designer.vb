<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Label1 = New Label()
        btnViewSubmissions = New Button()
        btnCreateSubmission = New Button()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(369, 126)
        Label1.Name = "Label1"
        Label1.Size = New Size(282, 42)
        Label1.TabIndex = 0
        Label1.Text = "Chandru ,Slidely Task 2- Slidely Form App" & vbCrLf
        Label1.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.Gold
        btnViewSubmissions.Location = New Point(369, 201)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(282, 39)
        btnViewSubmissions.TabIndex = 1
        btnViewSubmissions.Text = "VEIW SUBMISSIONS (CTRL +V)"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnCreateSubmission
        ' 
        btnCreateSubmission.BackColor = Color.LightSkyBlue
        btnCreateSubmission.Location = New Point(369, 275)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(282, 41)
        btnCreateSubmission.TabIndex = 2
        btnCreateSubmission.Text = "CREATE NEW SUBMISSION (CTRL +N)"
        btnCreateSubmission.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonHighlight
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(1, 1)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1087, 37)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.LightCoral
        Label2.Location = New Point(998, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 38)
        Label2.TabIndex = 4
        Label2.Text = "X"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1086, 450)
        Controls.Add(GroupBox1)
        Controls.Add(btnCreateSubmission)
        Controls.Add(btnViewSubmissions)
        Controls.Add(Label1)
        Name = "MainForm"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label

End Class
