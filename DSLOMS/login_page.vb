Imports System.Data.SqlClient
Public Class login_page
    Public Property LoggedInUserName As String
    Private Sub AdminBtn_MouseEnter(sender As Object, e As EventArgs) Handles AdminBtn.MouseEnter
        AdminBtn.BackColor = Color.FromArgb(41, 128, 185)
        AdminBtn.ForeColor = Color.Black
    End Sub
    Private Sub AdminBtn_MouseLeave(sender As Object, e As EventArgs) Handles AdminBtn.MouseLeave
        AdminBtn.BackColor = Color.FromArgb(52, 152, 219)
        AdminBtn.ForeColor = Color.White
    End Sub
    Private Sub LogInBtn_MouseEnter(sender As Object, e As EventArgs) Handles LoginBtn.MouseEnter
        LoginBtn.BackColor = Color.FromArgb(41, 128, 185)
        LoginBtn.ForeColor = Color.Black
    End Sub
    Private Sub btnButton1_MouseLeave(sender As Object, e As EventArgs) Handles LoginBtn.MouseLeave
        LoginBtn.BackColor = Color.FromArgb(52, 152, 219)
        LoginBtn.ForeColor = Color.White
    End Sub
    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.BackColor = Color.FromArgb(41, 128, 185)
        Button3.ForeColor = Color.Black
    End Sub
    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.FromArgb(52, 152, 219)
        Button3.ForeColor = Color.White
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

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox1.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.BackColor = Color.White
        PictureBox1.ForeColor = Color.White
    End Sub
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30")
    Dim cmd As SqlCommand
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If UNameTb.Text = "" Or PassTb.Text = "" Then
            MsgBox("Enter UserName and Password")
        Else
            Con.Open()
            Dim Query = "select * from MembershipTbl where MemUserName= '" & UNameTb.Text & "' and MemPass = '" & PassTb.Text & "'"
            cmd = New SqlCommand(Query, Con)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            sda.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a > 0 Then
                LoggedInUserName = UNameTb.Text
                Dim homepage = New home_page
                homepage.UserName = UNameTb.Text
                homepage.Show()

                Me.Hide()
            Else
                MsgBox("Wrong UserName or Password")
            End If
            Con.Close()
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim facebookUrl As String = "https://www.facebook.com"

        Try
            Process.Start(facebookUrl)
        Catch ex As Exception
            MessageBox.Show($"Error opening the web browser: {ex.Message}")
        End Try
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim twitterUrl As String = "https://www.twitter.com"

        Try
            Process.Start(twitterUrl)
        Catch ex As Exception
            MessageBox.Show($"Error opening the web browser: {ex.Message}")
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim googleplusUrl As String = "https://plus.google.com"

        Try
            Process.Start(googleplusUrl)
        Catch ex As Exception
            MessageBox.Show($"Error opening the web browser: {ex.Message}")
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim linkedinUrl As String = "https://www.linkedin.com"

        Try
            Process.Start(linkedinUrl)
        Catch ex As Exception
            MessageBox.Show($"Error opening the web browser: {ex.Message}")
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UNameTb.Clear()
        PassTb.Clear()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Dim Pass = New forgot_password
        Pass.Show()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Dim contacts = New Dsloms
        contacts.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim signup = New membership_application
        signup.Show()
    End Sub

    Private Sub AdminBtn_Click(sender As Object, e As EventArgs) Handles AdminBtn.Click
        Me.Hide()
        Dim admin = New admin_login
        admin.Show()
    End Sub
End Class
