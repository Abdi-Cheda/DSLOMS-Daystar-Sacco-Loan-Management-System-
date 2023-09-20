Public Class admin_page
    Private Sub PictureBox5_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox5.MouseEnter
        Button1.BackColor = Color.FromArgb(41, 128, 185)
        Button1.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        Button1.BackColor = Color.Turquoise
        Button1.ForeColor = Color.White
    End Sub
    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        Button2.BackColor = Color.FromArgb(41, 128, 185)
        Button2.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Button2.BackColor = Color.Turquoise
        Button2.ForeColor = Color.White
    End Sub
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.FromArgb(41, 128, 185)
        Button1.ForeColor = Color.Black
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Turquoise
        Button1.ForeColor = Color.White
    End Sub
    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = Color.FromArgb(41, 128, 185)
        Button2.ForeColor = Color.Black
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.Turquoise
        Button2.ForeColor = Color.White
    End Sub
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
    Private Sub sadmPb_MouseEnter(sender As Object, e As EventArgs) Handles sadmPb.MouseEnter
        sadmBtn.BackColor = Color.FromArgb(41, 128, 185)
        sadmBtn.ForeColor = Color.Black
    End Sub

    Private Sub sadmPb_MouseLeave(sender As Object, e As EventArgs) Handles sadmPb.MouseLeave
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
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Dim login = New admin_login
        login.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        Dim login = New admin_login
        login.Show()
    End Sub

    Private Sub sadmBtn_Click(sender As Object, e As EventArgs) Handles sadmBtn.Click
        Me.Hide()
        Dim add = New add_transactions
        add.Show()
    End Sub

    Private Sub sadmPb_Click(sender As Object, e As EventArgs) Handles sadmPb.Click
        Me.Hide()
        Dim add = New add_transactions
        add.Show()
    End Sub

    Private Sub LoanBtn_Click(sender As Object, e As EventArgs) Handles LoanBtn.Click
        Me.Hide()
        Dim loan = New admin_loan_approval
        loan.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Hide()
        Dim loan = New admin_loan_approval
        loan.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim back = New member_management
        back.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Dim back = New member_management
        back.Show()
    End Sub

    Private Sub AccBtn_Click(sender As Object, e As EventArgs) Handles AccBtn.Click
        Me.Hide()
        Dim loan = New loan_repayment
        loan.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Dim loan = New loan_repayment
        loan.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim reports = New reports_and_statements
        reports.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        Dim reports = New reports_and_statements
        reports.Show()
    End Sub
End Class