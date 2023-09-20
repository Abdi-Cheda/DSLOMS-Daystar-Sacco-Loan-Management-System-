Public Class admin_login
    Private Sub ContBtn_MouseEnter(sender As Object, e As EventArgs) Handles ContBtn.MouseEnter
        ContBtn.BackColor = Color.FromArgb(41, 128, 185)
        ContBtn.ForeColor = Color.Black
    End Sub
    Private Sub ContBtn_MouseLeave(sender As Object, e As EventArgs) Handles ContBtn.MouseLeave
        ContBtn.BackColor = Color.FromArgb(52, 152, 219)
        ContBtn.ForeColor = Color.White
    End Sub
    Private Sub ContBtn_Click(sender As Object, e As EventArgs) Handles ContBtn.Click
        If PassTb.Text = "SuperAdmin" Then
            Dim adminPage As New admin_page
            adminPage.Show()
            Me.Hide()
        Else
            MessageBox.Show("Incorrect password. Please try again.")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim login = New login_page
        login.Show()
    End Sub
End Class