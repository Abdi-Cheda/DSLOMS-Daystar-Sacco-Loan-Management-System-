Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class membership_application
    Private Sub SignUpBtn_MouseEnter(sender As Object, e As EventArgs) Handles SignUpBtn.MouseEnter
        SignUpBtn.BackColor = Color.FromArgb(41, 128, 185)
        SignUpBtn.ForeColor = Color.Black
    End Sub
    Private Sub btnButton1_MouseLeave(sender As Object, e As EventArgs) Handles SignUpBtn.MouseLeave
        SignUpBtn.BackColor = Color.FromArgb(52, 152, 219)
        SignUpBtn.ForeColor = Color.White
    End Sub
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.FromArgb(41, 128, 185)
        Button1.ForeColor = Color.Black
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.FromArgb(52, 152, 219)
        Button1.ForeColor = Color.White
    End Sub
    Private Sub MemPassPicB_MouseEnter(sender As Object, e As EventArgs) Handles MemPassPicB.MouseEnter
        MemPassPicB.BackColor = Color.DimGray
        MemPassPicB.ForeColor = Color.DimGray
    End Sub

    Private Sub MemPassPicB_MouseLeave(sender As Object, e As EventArgs) Handles MemPassPicB.MouseLeave
        MemPassPicB.BackColor = Color.White
        MemPassPicB.ForeColor = Color.White
    End Sub
    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox4.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.BackColor = Color.White
        PictureBox4.ForeColor = Color.White
    End Sub
    Private Sub Label24_MouseEnter(sender As Object, e As EventArgs) Handles Label24.MouseEnter
        Label24.BackColor = Color.White
        Label24.ForeColor = Color.Gray
    End Sub

    Private Sub Label24_MouseLeave(sender As Object, e As EventArgs) Handles Label24.MouseLeave
        Label24.BackColor = Color.White
        Label24.ForeColor = Color.DodgerBlue
    End Sub
    Private Sub Label26_MouseEnter(sender As Object, e As EventArgs) Handles Label26.MouseEnter
        Label26.BackColor = Color.White
        Label26.ForeColor = Color.Gray
    End Sub

    Private Sub Label26_MouseLeave(sender As Object, e As EventArgs) Handles Label26.MouseLeave
        Label26.BackColor = Color.White
        Label26.ForeColor = Color.DodgerBlue
    End Sub
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30")
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click
        Dim facebookUrl As String = "https://www.facebook.com/@daystarsacco"

        Try
            Process.Start(facebookUrl)
        Catch ex As Exception
            MessageBox.Show($"Error opening the web browser: {ex.Message}")
        End Try
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
        Dim emailUrl As String = "https://daystarmultipurpose@daystar.ac.ke"

        Try
            Process.Start(emailUrl)
        Catch ex As Exception
            MessageBox.Show($"Error opening the web browser: {ex.Message}")
        End Try
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim facebookUrl As String = "https://www.facebook.com/@daystarsacco"

        Try
            Process.Start(facebookUrl)
        Catch ex As Exception
            MessageBox.Show($"Error opening the web browser: {ex.Message}")
        End Try
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Dim login = New login_page
        login.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim contacts = New Dsloms
        contacts.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim aboutus = New Dsloms
        aboutus.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Dim pandt = New Dsloms
        pandt.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Dim copy = New Dsloms
        copy.Show()
    End Sub

    Private Sub SignUpBtn_Click(sender As Object, e As EventArgs) Handles SignUpBtn.Click
        If MemGenderCb.SelectedIndex = -1 OrElse
       MemStatusCb.SelectedIndex = -1 OrElse
       MemIntroCb.SelectedIndex = -1 OrElse
       String.IsNullOrEmpty(MemNameTb.Text) OrElse
       String.IsNullOrEmpty(MemUserNameTb.Text) OrElse
       String.IsNullOrEmpty(MemIdPassNoTb.Text) OrElse
       String.IsNullOrEmpty(MemAddTb.Text) OrElse
       String.IsNullOrEmpty(MemEmailTb.Text) OrElse
       String.IsNullOrEmpty(MemMobileTb.Text) OrElse
       String.IsNullOrEmpty(MemPostTb.Text) OrElse
       String.IsNullOrEmpty(MemCompanyTb.Text) OrElse
       String.IsNullOrEmpty(MemProfTb.Text) OrElse
       String.IsNullOrEmpty(MemDepTb.Text) OrElse
       String.IsNullOrEmpty(MemPassTb.Text) OrElse
       String.IsNullOrEmpty(MemOtherTb.Text) OrElse
       String.IsNullOrEmpty(MemRePassTb.Text) OrElse
       MemDOB.Value = DateTime.Now Then
            MessageBox.Show("Please fill in all fields to sign up.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MemPassTb.Text <> MemRePassTb.Text Then
            MessageBox.Show("Password and re-typed password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim email As String = MemEmailTb.Text
        If Not IsValidEmail(email) Then
            MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            Con.Open()
            Dim Query As String
            Query = "insert into MembershipTbl values('" & MemNameTb.Text & "','" & MemUserNameTb.Text & "','" & MemDOB.Value & "','" & MemGenderCb.SelectedItem.ToString() & "','" & MemIdPassNoTb.Text & "','" & MemStatusCb.SelectedItem.ToString() & "','" & MemAddTb.Text & "','" & MemEmailTb.Text & "','" & MemMobileTb.Text & "','" & MemPostTb.Text & "','" & MemCompanyTb.Text & "','" & MemProfTb.Text & "','" & MemDepTb.Text & "','" & MemIntroCb.SelectedItem.ToString() & "','" & MemOtherTb.Text & "','" & MemPassTb.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, Con)
            cmd.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("Sign up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Con.Close()
        End Try
    End Sub
    Private Function IsValidEmail(email As String) As Boolean
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Dim regex As New Regex(emailPattern)
        Return regex.IsMatch(email)
    End Function
    Private Sub MemPassPicB_Click(sender As Object, e As EventArgs) Handles MemPassPicB.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                MemPassPicB.Image = Image.FromFile(openFileDialog.FileName)
                MemPassPicB.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MemNameTb.Clear()
        MemUserNameTb.Clear()
        MemIdPassNoTb.Clear()
        MemAddTb.Clear()
        MemEmailTb.Clear()
        MemMobileTb.Clear()
        MemPostTb.Clear()
        MemCompanyTb.Clear()
        MemProfTb.Clear()
        MemDepTb.Clear()
        MemOtherTb.Clear()
        MemPassTb.Clear()
        MemRePassTb.Clear()
        MemGenderCb.SelectedIndex = -1
        MemStatusCb.SelectedIndex = -1
        MemIntroCb.SelectedIndex = -1
        MemDOB.Value = DateTime.Now
        MemPassPicB.SizeMode = PictureBoxSizeMode.Zoom
        MemPassPicB.Image = Image.FromFile("C:\Users\Abdi Cheda\Desktop\VbImages\PASSPIC.PNG")
    End Sub
End Class