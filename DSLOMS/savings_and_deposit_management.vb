Imports System.Data.SqlClient
Public Class savings_and_deposit_management
    Public Property LoggedInUserName As String
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.FromArgb(41, 128, 185)
        Button1.ForeColor = Color.Black
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Turquoise
        Button1.ForeColor = Color.White
    End Sub
    Private Sub nxtkinBtn_MouseEnter(sender As Object, e As EventArgs) Handles nxtkinBtn.MouseEnter
        nxtkinBtn.BackColor = Color.FromArgb(41, 128, 185)
        nxtkinBtn.ForeColor = Color.Black
    End Sub

    Private Sub nxtkinBtn_MouseLeave(sender As Object, e As EventArgs) Handles nxtkinBtn.MouseLeave
        nxtkinBtn.BackColor = Color.Turquoise
        nxtkinBtn.ForeColor = Color.White
    End Sub
    Private Sub sadmBtn_MouseEnter(sender As Object, e As EventArgs) Handles sadmBtn.MouseEnter
        sadmBtn.BackColor = Color.FromArgb(41, 128, 185)
        sadmBtn.ForeColor = Color.Black
    End Sub

    Private Sub sadmBtn_MouseLeave(sender As Object, e As EventArgs) Handles sadmBtn.MouseLeave
        sadmBtn.BackColor = Color.Turquoise
        sadmBtn.ForeColor = Color.White
    End Sub
    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        nxtkinBtn.BackColor = Color.FromArgb(41, 128, 185)
        nxtkinBtn.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        nxtkinBtn.BackColor = Color.Turquoise
        nxtkinBtn.ForeColor = Color.White
    End Sub
    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        sadmBtn.BackColor = Color.FromArgb(41, 128, 185)
        sadmBtn.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        sadmBtn.BackColor = Color.Turquoise
        sadmBtn.ForeColor = Color.White
    End Sub
    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.BackColor = Color.Turquoise
        PictureBox4.ForeColor = Color.Turquoise
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.BackColor = Color.White
        PictureBox4.ForeColor = Color.White
    End Sub
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30")
    Public Property UserName As String
    Private Sub Populate()
        con.Open()
        Dim Query = "select * from MembershipTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(Query, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        con.Close()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Dim login = New login_page
        login.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        Dim login = New login_page
        login.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim home = New home_page
        home.UserName = UserName
        home.Show()
    End Sub

    Private Sub nxtkinBtn_Click(sender As Object, e As EventArgs) Handles nxtkinBtn.Click
        LoggedInUserName = UserName
        Dim nextOfKinForm As New next_of_kin()
        nextOfKinForm.UserName = UserName
        nextOfKinForm.Show()
        Me.Hide()
    End Sub

    Private Sub sadmBtn_Click(sender As Object, e As EventArgs) Handles sadmBtn.Click
        Me.Hide()
        Dim viewStatementForm As New view_statement(UserName)
        viewStatementForm.Show()
    End Sub

    Private Sub savings_and_deposit_management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
        UNameLbl1.Text = UserName
        UNameLbl2.Text = UserName
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Dim viewStatementForm As New view_statement(UserName)
        viewStatementForm.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        LoggedInUserName = UserName
        Dim nxtkin = New next_of_kin
        nxtkin.UserName = UserName
        nxtkin.Show()
    End Sub
End Class