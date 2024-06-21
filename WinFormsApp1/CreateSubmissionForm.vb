Imports System.IO
Imports System.Net
Imports System.Text

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Private isRunning As Boolean = False
    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnStopwatch_Click(sender As Object, e As EventArgs) Handles btnStopwatch.Click
        If Not isRunning Then
            stopwatch.Start()
            isRunning = True
            btnStopwatch.Text = "Pause"
        Else
            stopwatch.Stop()
            isRunning = False
            btnStopwatch.Text = "Resume"
        End If
    End Sub
    Public Class CreateSubmissionForm
        Private WithEvents Timer1 As New Timer

        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            ' Your code here
        End Sub

        ' Rest of your code
    End Class
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs)
        Dim submitRequest As WebRequest = WebRequest.Create("http://localhost:5000")
        submitRequest.Method = "POST"
        Dim submitData As String = "name=" & txtName.Text & "&email=" & txtEmail.Text & "&phone=" & txtPhone.Text & "&github_link=" & txtGithub.Text & "&stopwatch_time=" & lblStopwatch.Text
        submitRequest.ContentType = "application/x-www-form-urlencoded"
        Dim submitBytes As Byte() = Encoding.UTF8.GetBytes(submitData)
        submitRequest.ContentLength = submitBytes.Length
        Using submitStream As Stream = submitRequest.GetRequestStream()
            submitStream.Write(submitBytes, 0, submitBytes.Length)
        End Using
        Dim submitResponse As WebResponse = submitRequest.GetResponse()
        Dim name = txtName.Text
        Dim email = txtEmail.Text
        Dim phone = txtPhone.Text
        Dim githubLink = txtGithub.Text
        Dim stopwatchTime = stopwatch.Elapsed.ToString("mm\:ss\.fff")

        ' Implement API call to submit data to the backend

        ' Reset the form
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtGithub.Clear()
        stopwatch.Reset()
        btnSubmit.Text = "00:00.000"
        isRunning = False
        btnStopwatch.Text = "Resume"

        Close()
    End Sub

    Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub
End Class