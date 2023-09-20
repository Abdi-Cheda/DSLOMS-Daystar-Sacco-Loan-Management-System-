Imports System.Data.SqlClient
Public Class loan_repayment
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30")
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim home = New admin_page
        home.Show()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If UnameTb.Text = "" Or SalaryTb.Text = "" Or Inst1Tb.Text = "" Or Inst2Tb.Text = "" Or
       Inst3Tb.Text = "" Or LoanTypeTb.Text = "" Or LoanAmountTb.Text = "" Or FineTb.Text = "" Or
       LoanIntrestTb.Text = "" Or LoanStatusTb.Text = "" Then
            MessageBox.Show("Please fill in all the required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim UserName As String = UnameTb.Text
        Dim salaryAmount As String = SalaryTb.Text
        Dim inst1 As String = Inst1Tb.Text
        Dim inst2 As String = Inst2Tb.Text
        Dim inst3 As String = Inst3Tb.Text
        Dim loanType As String = LoanTypeTb.Text
        Dim loanAmount As String = LoanAmountTb.Text
        Dim fineAmount As String = FineTb.Text
        Dim loanIntrest As String = LoanIntrestTb.Text
        Dim loanStatus As String = LoanStatusTb.Text
        Dim repaymentTime As DateTime = paymentDatePicker.Value

        Try
            Using connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30")
                connection.Open()
                Dim query As String = "INSERT INTO LoanRepaymentTbl (UserName, SalaryAmount, Installment1, Installment2, Installment3, DateOfPayment, LoanAndIntrestAmount, LoanBorrowed, LoanType, Fine, LoanStatus) VALUES (@UserName, @SalaryAmount, @Installment1, @Installment2, @Installment3, @DateOfPayment, @LoanAndIntrestAmount, @LoanBorrowed, @LoanType, @Fine, @LoanStatus);"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@UserName", UserName)
                    cmd.Parameters.AddWithValue("@SalaryAmount", salaryAmount)
                    cmd.Parameters.AddWithValue("@Installment1", inst1)
                    cmd.Parameters.AddWithValue("@Installment2", inst2)
                    cmd.Parameters.AddWithValue("@Installment3", inst3)
                    cmd.Parameters.AddWithValue("@DateOfPayment", repaymentTime)
                    cmd.Parameters.AddWithValue("@LoanAndIntrestAmount", loanIntrest)
                    cmd.Parameters.AddWithValue("@LoanBorrowed", loanAmount)
                    cmd.Parameters.AddWithValue("@LoanType", loanType)
                    cmd.Parameters.AddWithValue("@Fine", fineAmount)
                    cmd.Parameters.AddWithValue("@LoanStatus", loanStatus)

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Loan-Repayment processed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding the transaction: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                        UnameTb.Items.Add(reader("MemUserName").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub loan_repayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsernames()
    End Sub
End Class