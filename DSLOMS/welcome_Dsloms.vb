Public Class welcome_Dsloms
    Private Sub StartBtn_MouseEnter(sender As Object, e As EventArgs) Handles StartBtn.MouseEnter
        StartBtn.BackColor = Color.FromArgb(41, 128, 185)
        StartBtn.ForeColor = Color.Black
    End Sub
    Private Sub btnHover_MouseLeave(sender As Object, e As EventArgs) Handles StartBtn.MouseLeave
        StartBtn.BackColor = Color.FromArgb(52, 152, 219)
        StartBtn.ForeColor = Color.White
    End Sub
    Private Sub PictureBox7_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox7.MouseEnter
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox7.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub PictureBox7_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox7.MouseLeave
        PictureBox7.BackColor = Color.White
        PictureBox7.ForeColor = Color.White
    End Sub
    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox2.ForeColor = Color.DodgerBlue
    End Sub
    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackColor = Color.White
        PictureBox2.ForeColor = Color.White
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox3.ForeColor = Color.DodgerBlue
    End Sub
    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.BackColor = Color.White
        PictureBox3.ForeColor = Color.White
    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox4.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.BackColor = Color.White
        PictureBox4.ForeColor = Color.White
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles StartBtn.Click
        Me.Hide()
        Dim start = New login_page
        start.Show()
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim twitterUrl As String = "https://www.twitter.com"

        Try
            Process.Start(twitterUrl)
        Catch ex As Exception
            MessageBox.Show($"Error opening the web browser: {ex.Message}")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim twitterUrl As String = "https://www.twitter.com"

        Try
            Process.Start(twitterUrl)
        Catch ex As Exception
            MessageBox.Show($"Error opening the web browser: {ex.Message}")
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim googleplusUrl As String = "https://plus.google.com"

        Try
            Process.Start(googleplusUrl)
        Catch ex As Exception
            MessageBox.Show($"Error opening the web browser: {ex.Message}")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim googleplusUrl As String = "https://plus.google.com"

        Try
            Process.Start(googleplusUrl)
        Catch ex As Exception
            MessageBox.Show($"Error opening the web browser: {ex.Message}")
        End Try
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim linkedinUrl As String = "https://www.linkedin.com"

        Try
            Process.Start(linkedinUrl)
        Catch ex As Exception
            MessageBox.Show($"Error opening the web browser: {ex.Message}")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim linkedinUrl As String = "https://www.linkedin.com"

        Try
            Process.Start(linkedinUrl)
        Catch ex As Exception
            MessageBox.Show($"Error opening the web browser: {ex.Message}")
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim facebookUrl As String = "https://www.facebook.com"

        Try
            Process.Start(facebookUrl)
        Catch ex As Exception
            MessageBox.Show($"Error opening the web browser: {ex.Message}")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim facebookUrl As String = "https://www.facebook.com"

        Try
            Process.Start(facebookUrl)
        Catch ex As Exception
            MessageBox.Show($"Error opening the web browser: {ex.Message}")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Dim contacts = New Dsloms
        contacts.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim aboutus = New Dsloms
        aboutus.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Dim pandt = New Dsloms
        pandt.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Dim copy = New Dsloms
        copy.Show()
    End Sub
End Class