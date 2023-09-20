Imports System.Data.SqlClient
Public Class loan_statement
    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox4.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.BackColor = Color.White
        PictureBox4.ForeColor = Color.White
    End Sub
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30")

    Private loggedInUserName As String

    Public Sub New(userName As String)
        InitializeComponent()
        loggedInUserName = userName
    End Sub
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
    Private Sub Button4_Click(sender As Object, e As EventArgs) 
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim back = New loan_page
        back.UserName = loggedInUserName
        back.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim home = New home_page
        home.UserName = loggedInUserName
        home.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        Dim start = New login_page
        start.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Dim start = New login_page
        start.Show()
    End Sub

    Private Sub loan_statement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loggedInUserName = loggedInUserName
        LoadLoanStatementData()
        Populate()
        lblUsername.Text = loggedInUserName
        Me.AcceptButton = Nothing
        Me.KeyPreview = True
    End Sub
    Private Sub loan_statement_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
        End If
    End Sub

    Private Sub LoadLoanStatementData()
        Try
            Dim query As String = "SELECT * FROM LoanRequestTbl WHERE MemUserName = @Username"
            Dim ds As New DataSet()

            Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30")
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Username", loggedInUserName)

                    con.Open()

                    Dim adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(ds)
                End Using
            End Using
            DataGridView1.DataSource = ds.Tables(0)
            Dim totalBalance As Decimal = CalculateTotalBalance()
            lblTotalBalance.Text = totalBalance.ToString("C")
        Catch ex As Exception
            MessageBox.Show("Error while loading statement: " & ex.Message)
        End Try

        Try
            Dim query As String = "SELECT * FROM AdminLoanApprovalTbl WHERE MemUserName = @Username"
            Dim ds As New DataSet()

            Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30")
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Username", loggedInUserName)

                    con.Open()

                    Dim adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(ds)
                End Using
            End Using
            DataGridView2.DataSource = ds.Tables(0)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim loanOwed As Decimal = Convert.ToDecimal(ds.Tables(0).Rows(0)("LoanOwed"))
                lblLoanOwed.Text = loanOwed.ToString("C")

                Dim dateJoined As DateTime = Convert.ToDateTime(ds.Tables(0).Rows(0)("DateJoined"))
                lblDateJoined.Text = dateJoined.ToString("yyyy-MM-dd")
            End If
        Catch ex As Exception
            MessageBox.Show("Error while loading Loan statement: " & ex.Message)
        End Try
    End Sub
    Private Function CalculateTotalBalance() As Decimal
        Dim totalBalance As Decimal = 0

        Try
            Dim query As String = "SELECT SUM(TransactionAmount) FROM statementTbl WHERE MemUserName = @Username"

            Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30")
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Username", loggedInUserName)

                    con.Open()

                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot DBNull.Value Then
                        totalBalance = Convert.ToDecimal(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error while calculating total balance: " & ex.Message)
        End Try

        Return totalBalance
    End Function

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub
End Class