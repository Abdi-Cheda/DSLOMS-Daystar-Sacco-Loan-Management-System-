Imports System.Data.SqlClient
Public Class loan_page
    Private Sub Button7_MouseEnter(sender As Object, e As EventArgs) Handles Button7.MouseEnter
        Button7.BackColor = Color.FromArgb(41, 128, 185)
        Button7.ForeColor = Color.Black
    End Sub
    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs) Handles Button7.MouseLeave
        Button7.BackColor = Color.FromArgb(52, 152, 219)
        Button7.ForeColor = Color.White
    End Sub
    Private Sub PictureBox8_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox8.MouseEnter
        Button7.BackColor = Color.FromArgb(41, 128, 185)
        Button7.ForeColor = Color.Black
    End Sub
    Private Sub PictureBox8_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox8.MouseLeave
        Button7.BackColor = Color.FromArgb(52, 152, 219)
        Button7.ForeColor = Color.White
    End Sub
    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox4.ForeColor = Color.DodgerBlue
    End Sub
    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.BackColor = Color.White
        PictureBox4.ForeColor = Color.White
    End Sub
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.FromArgb(41, 128, 185)
        Button1.ForeColor = Color.Black
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.FromArgb(52, 152, 219)
        Button1.ForeColor = Color.White
    End Sub
    Private Sub PictureBox6_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox6.MouseEnter
        Button1.BackColor = Color.FromArgb(41, 128, 185)
        Button1.ForeColor = Color.Black
    End Sub
    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave
        Button1.BackColor = Color.FromArgb(52, 152, 219)
        Button1.ForeColor = Color.White
    End Sub
    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = Color.FromArgb(41, 128, 185)
        Button2.ForeColor = Color.Black
    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.FromArgb(52, 152, 219)
        Button2.ForeColor = Color.White
    End Sub
    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        Button2.BackColor = Color.FromArgb(41, 128, 185)
        Button2.ForeColor = Color.Black
    End Sub
    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Button2.BackColor = Color.FromArgb(52, 152, 219)
        Button2.ForeColor = Color.White
    End Sub
    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.BackColor = Color.FromArgb(41, 128, 185)
        Button3.ForeColor = Color.Black
    End Sub
    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.FromArgb(52, 152, 219)
        Button3.ForeColor = Color.White
    End Sub
    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        Button3.BackColor = Color.FromArgb(41, 128, 185)
        Button3.ForeColor = Color.Black
    End Sub
    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        Button3.BackColor = Color.FromArgb(52, 152, 219)
        Button3.ForeColor = Color.White
    End Sub
    Private Sub Button6_MouseEnter(sender As Object, e As EventArgs) Handles Button6.MouseEnter
        Button6.BackColor = Color.FromArgb(41, 128, 185)
        Button6.ForeColor = Color.Black
    End Sub
    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles Button6.MouseLeave
        Button6.BackColor = Color.FromArgb(52, 152, 219)
        Button6.ForeColor = Color.White
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
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Dim start = New login_page
        start.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        Dim start = New login_page
        start.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Dim home As home_page = New home_page()
        home.UserName = UserName
        home.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim deduct As deduct_vary_authority = New deduct_vary_authority()
        deduct.UserName = UserName
        deduct.Show()
    End Sub

    Private Sub loan_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
        UNameLbl3.Text = UserName
        UNameLbl4.Text = UserName
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Dim deduct As deduct_vary_authority = New deduct_vary_authority()
        deduct.UserName = UserName
        deduct.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Dim loanManagementForm As New loan_management(UserName)
        loanManagementForm.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Me.Hide()
        Dim loanManagementForm As New loan_management(UserName)
        loanManagementForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim loanStatementForm As New loan_statement(UserName)
        loanStatementForm.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Hide()
        Dim loanStatementForm As New loan_statement(UserName)
        loanStatementForm.Show()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim salaryAdvanceForm As New salary_advance(UserName)
        salaryAdvanceForm.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Dim salaryAdvanceForm As New salary_advance(UserName)
        salaryAdvanceForm.Show()
    End Sub
End Class