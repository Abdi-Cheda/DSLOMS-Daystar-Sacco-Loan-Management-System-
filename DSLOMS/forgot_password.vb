Imports System.Text.RegularExpressions
Public Class forgot_password
    Private Sub ContinueBtn_MouseEnter(sender As Object, e As EventArgs) Handles ContinueBtn.MouseEnter
        ContinueBtn.BackColor = Color.FromArgb(41, 128, 185)
        ContinueBtn.ForeColor = Color.Black
    End Sub
    Private Sub btnButton1_MouseLeave(sender As Object, e As EventArgs) Handles ContinueBtn.MouseLeave
        ContinueBtn.BackColor = Color.FromArgb(52, 152, 219)
        ContinueBtn.ForeColor = Color.White
    End Sub
    Private Sub ContinueBtn_Click(sender As Object, e As EventArgs) Handles ContinueBtn.Click
        Dim userInput As String = TextBox1.Text
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        If Regex.IsMatch(userInput, emailPattern) Then
            Dim message As String = "Reset Link sent succesfully!!!"
            Dim title As String = "Message Box"
            Dim buttons As MessageBoxButtons = MessageBoxButtons.OK
            Dim icon As MessageBoxIcon = MessageBoxIcon.Information
            MessageBox.Show(message, title, buttons, icon)
        ElseIf String.IsNullOrWhiteSpace(userInput) Then
            Dim message As String = "Email Field is Empty!!!"
            Dim title As String = "Message Box"
            Dim buttons As MessageBoxButtons = MessageBoxButtons.OK
            Dim icon As MessageBoxIcon = MessageBoxIcon.Information
            MessageBox.Show(message, title, buttons, icon)
        Else
            Dim message As String = "Invalid Email Type!!!"
            Dim title As String = "Message Box"
            Dim buttons As MessageBoxButtons = MessageBoxButtons.OK
            Dim icon As MessageBoxIcon = MessageBoxIcon.Information
            MessageBox.Show(message, title, buttons, icon)
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

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class