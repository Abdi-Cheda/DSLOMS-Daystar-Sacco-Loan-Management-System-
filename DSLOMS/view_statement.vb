Imports System.Data.SqlClient
Public Class view_statement
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
        Dim back = New savings_and_deposit_management
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

    Private Sub view_statement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loggedInUserName = loggedInUserName
        LoadViewStatementData()
        Populate()
        lblUsername.Text = loggedInUserName
    End Sub

    Private Sub LoadViewStatementData()
        Try
            Dim query As String = "SELECT * FROM statementTbl WHERE MemUserName = @Username"
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
            Dim totalBalance As Decimal = CalculatetotalBalance()
            lblTotalBalance.Text = totalBalance.ToString("C")

            Dim dateJoinedQuery As String = "SELECT DateJoined FROM AdminLoanApprovalTbl WHERE MemUserName = @username"
            Using conDateJoined As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30")
                Using dateJoinedCmd As SqlCommand = New SqlCommand(dateJoinedQuery, conDateJoined)
                    dateJoinedCmd.Parameters.AddWithValue("@username", loggedInUserName)

                    conDateJoined.Open() ' Open the connection

                    Dim dateJoined As Object = dateJoinedCmd.ExecuteScalar()
                    If dateJoined IsNot DBNull.Value Then
                        Dim dateJoinedValue As DateTime = Convert.ToDateTime(dateJoined)
                        lblDateJoined.Text = dateJoinedValue.ToString("yyyy-MM-dd")
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error while loading statement: " & ex.Message)
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