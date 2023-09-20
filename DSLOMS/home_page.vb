Imports System.Data.SqlClient
Public Class home_page
    Public Property LoggedInUserName As String
    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.BackColor = Color.Turquoise
        PictureBox4.ForeColor = Color.Turquoise
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.BackColor = Color.White
        PictureBox4.ForeColor = Color.White
    End Sub
    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        AccBtn.BackColor = Color.FromArgb(41, 128, 185)
        AccBtn.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        AccBtn.BackColor = Color.Turquoise
        AccBtn.ForeColor = Color.White
    End Sub
    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles sadmPb.MouseEnter
        sadmBtn.BackColor = Color.FromArgb(41, 128, 185)
        sadmBtn.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles sadmPb.MouseLeave
        sadmBtn.BackColor = Color.Turquoise
        sadmBtn.ForeColor = Color.White
    End Sub
    Private Sub PictureBox6_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox6.MouseEnter
        LoanBtn.BackColor = Color.FromArgb(41, 128, 185)
        LoanBtn.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave
        LoanBtn.BackColor = Color.Turquoise
        LoanBtn.ForeColor = Color.White
    End Sub
    Private Sub LoanBtn_MouseEnter(sender As Object, e As EventArgs) Handles LoanBtn.MouseEnter
        LoanBtn.BackColor = Color.FromArgb(41, 128, 185)
        LoanBtn.ForeColor = Color.Black
    End Sub

    Private Sub LoanBtn_MouseLeave(sender As Object, e As EventArgs) Handles LoanBtn.MouseLeave
        LoanBtn.BackColor = Color.Turquoise
        LoanBtn.ForeColor = Color.White
    End Sub
    Private Sub AccBtn_MouseEnter(sender As Object, e As EventArgs) Handles AccBtn.MouseEnter
        AccBtn.BackColor = Color.FromArgb(41, 128, 185)
        AccBtn.ForeColor = Color.Black
    End Sub

    Private Sub AccBtn_MouseLeave(sender As Object, e As EventArgs) Handles AccBtn.MouseLeave
        AccBtn.BackColor = Color.Turquoise
        AccBtn.ForeColor = Color.White
    End Sub
    Private Sub btnHover_MouseEnter(sender As Object, e As EventArgs) Handles sadmBtn.MouseEnter
        sadmBtn.BackColor = Color.FromArgb(41, 128, 185)
        sadmBtn.ForeColor = Color.Black
    End Sub

    Private Sub btnHover_MouseLeave(sender As Object, e As EventArgs) Handles sadmBtn.MouseLeave
        sadmBtn.BackColor = Color.Turquoise
        sadmBtn.ForeColor = Color.White
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
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        Dim login = New login_page
        login.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Dim login = New login_page
        login.Show()
    End Sub

    Private Sub home_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
        UNameLbl.Text = UserName
        UNameLbl2.Text = UserName
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LoanBtn.Click
        Me.Hide()
        Dim loan As New loan_page
        loan.UserName = UserName
        loan.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Hide()
        Dim loan As New loan_page
        loan.UserName = UserName
        loan.Show()
    End Sub

    Private Sub sadmBtn_Click(sender As Object, e As EventArgs) Handles sadmBtn.Click
        LoggedInUserName = UserName
        Dim sadm As New savings_and_deposit_management()
        sadm.UserName = UserName
        sadm.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles sadmPb.Click
        Me.Hide()
        LoggedInUserName = UserName
        Dim sadmPb As New savings_and_deposit_management()
        sadmPb.UserName = UserName
        sadmPb.Show()
    End Sub

    Private Sub AccBtn_Click(sender As Object, e As EventArgs) Handles AccBtn.Click
        Me.Hide()
        Dim userAccountForm As New UserAccountForm(UserName)
        userAccountForm.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Dim userAccountForm As New UserAccountForm(UserName)
        userAccountForm.Show()
    End Sub
End Class