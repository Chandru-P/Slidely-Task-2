Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lblEmail.SelectedIndexChanged

    End Sub

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplaySubmission(0)
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        Dim url As String = $"http://localhost:5000/read?index={index}"
        ' Use WebClient or similar to make a GET request to the URL and display the response in lblDetails
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs)
        currentIndex -= 1
        If currentIndex < 0 Then
            currentIndex = 0
        End If
        DisplaySubmission(currentIndex)
    End Sub

    Private Function lt() As Integer
        Throw New NotImplementedException()
    End Function

    Private Sub btnNext_Click(sender As Object, e As EventArgs)
        currentIndex += 1
        DisplaySubmission(currentIndex)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class