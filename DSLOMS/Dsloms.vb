Public Class Dsloms
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Application.Exit()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Dim signin = New login_page
        signin.Show()
    End Sub
End Class