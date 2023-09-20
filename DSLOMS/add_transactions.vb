Imports System.Data.SqlClient
Public Class add_transactions
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30"

    Private Sub btnAddTransaction_Click(sender As Object, e As EventArgs) Handles btnAddTransaction.Click
        Dim memUserName As String = txtMemUserName.Text
        Dim memName As String = txtMemName.Text
        Dim transactionType As String = txtTransactionType.Text
        Dim transactionAmount As Double

        If Not Double.TryParse(txtTransactionAmount.Text, transactionAmount) Then
            MessageBox.Show("Invalid Transaction Amount. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim transactionDate As DateTime = txtTransactionDate.Value
        Dim totalBalance As Double

        If Not Double.TryParse(txtTotalBalance.Text, totalBalance) Then
            MessageBox.Show("Invalid Total Balance. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        totalBalance += transactionAmount
        Try
            Using connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30")
                connection.Open()
                Dim query As String = "INSERT INTO statementTbl (MemUserName, MemName, TransactionType, TransactionAmount, TransactionDate) VALUES (@MemUserName, @MemName, @TransactionType, @TransactionAmount, @TransactionDate); UPDATE statementTbl SET TotalBalance = @TotalBalance WHERE MemUserName = @MemUserName;"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@MemUserName", memUserName)
                    cmd.Parameters.AddWithValue("@MemName", memName)
                    cmd.Parameters.AddWithValue("@TransactionType", transactionType)
                    cmd.Parameters.AddWithValue("@TransactionAmount", transactionAmount)
                    cmd.Parameters.AddWithValue("@TransactionDate", transactionDate)
                    cmd.Parameters.AddWithValue("@TotalBalance", totalBalance)

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Transaction added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtTotalBalance.Text = totalBalance.ToString("0.00")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding the transaction: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        RefreshDataGridView()
    End Sub

    Private Sub add_transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGridView()
        LoadUsernames()
    End Sub
    Private Sub LoadUsernames()
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30"
        Dim selectUsernamesQuery As String = "SELECT MemUserName FROM MembershipTbl"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(selectUsernamesQuery, connection)
                connection.Open()

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        txtMemUserName.Items.Add(reader("MemUserName").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub
    Private Sub RefreshDataGridView()

        Dim query As String = "SELECT MemUserName, MemName, TransactionType, TransactionAmount, TransactionDate, TotalBalance FROM statementTbl;"

        Try
            Using connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30")
                connection.Open()

                Using adapter As New SqlDataAdapter(query, connection)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    dgAddTransaction.DataSource = dataTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim back = New admin_page
        back.Show()
    End Sub
End Class