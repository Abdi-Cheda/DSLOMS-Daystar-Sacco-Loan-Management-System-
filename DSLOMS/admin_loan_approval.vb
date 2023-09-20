Imports System.Data.SqlClient
Public Class admin_loan_approval
    Private Sub admin_loan_approval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToDataGridView()
        RefreshDataGridView()
        LoadUsernames()
    End Sub
    Private Sub LoadDataToDataGridView()
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30"
        Dim query As String = "SELECT * FROM LoanRequestTbl"

        Dim dataTable As New DataTable()

        Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30")
            Using adapter As New SqlDataAdapter(query, con)
                con.Open()
                adapter.Fill(dataTable)
            End Using
        End Using

        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim memUserName As String = txtMemUserName.Text
        Dim loanRequestId As String = txtLoanRequestID.Text
        Dim requestStatus As String = txtRequestStatus.Text
        Dim rejectReason As String = txtRejectReason.Text
        Dim loanOwed As Double

        If Not Double.TryParse(txtLoanOwed.Text, loanOwed) Then
            MessageBox.Show("Invalid Loan Amount. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim dateJoined As DateTime = txtDateJoined.Value
        Try
            Using connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30")
                connection.Open()
                Dim query As String = "INSERT INTO AdminLoanApprovalTbl (MemUserName, DateJoined, LoanOwed, LoanRequestID, RequestStatus, RejectReason) VALUES (@MemUserName, @DateJoined, @LoanOwed, @LoanRequestID, @RequestStatus, @RejectReason); UPDATE AdminLoanApprovalTbl SET LoanOwed = @LoanOwed WHERE MemUserName = @MemUserName;"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@MemUserName", memUserName)
                    cmd.Parameters.AddWithValue("@DateJoined", dateJoined)
                    cmd.Parameters.AddWithValue("@LoanOwed", loanOwed)
                    cmd.Parameters.AddWithValue("@LoanRequestID", loanRequestId)
                    cmd.Parameters.AddWithValue("@RequestStatus", requestStatus)
                    cmd.Parameters.AddWithValue("@RejectReason", rejectReason)

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Loan processed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding the transaction: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        RefreshDataGridView()
    End Sub
    Private Sub RefreshDataGridView()

        Dim query As String = "SELECT MemUserName, DateJoined, LoanOwed, LoanRequestID, RequestStatus, RejectReason FROM AdminLoanApprovalTbl;"

        Try
            Using connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30")
                connection.Open()

                Using adapter As New SqlDataAdapter(query, connection)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    DataGridView2.DataSource = dataTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim back = New admin_page
        back.Show()
    End Sub
End Class