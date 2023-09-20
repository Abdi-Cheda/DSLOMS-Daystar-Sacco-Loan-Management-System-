Imports System.Data.SqlClient
Public Class loan_management
    Private con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30")

    Private loggedInUserName As String

    Public Sub New(userName As String)
        InitializeComponent()
        loggedInUserName = userName
    End Sub

    Private Sub loan_management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserDetails()
        Dim transactionAmount As Decimal = LoadTransactionAmount()
        AmountTb.Text = transactionAmount.ToString()
    End Sub
    Private Sub LoadUserDetails()
        Try
            con.Open()

            Dim membershipQuery As String = "SELECT * FROM MembershipTbl WHERE MemUserName = @username"
            Using membershipCmd As SqlCommand = New SqlCommand(membershipQuery, con)
                membershipCmd.Parameters.AddWithValue("@username", loggedInUserName)

                Using membershipReader As SqlDataReader = membershipCmd.ExecuteReader()
                    If membershipReader.Read() Then
                        MemNameTb.Text = membershipReader("MemName").ToString()
                        MemEmailTb.Text = membershipReader("MemEmail").ToString()
                        MemMobileTb.Text = membershipReader("MemMobile").ToString()
                        MemUserNameTb.Text = membershipReader("MemUserName").ToString()
                        MemIdPassNoTb.Text = membershipReader("MemIdPassNo").ToString()
                        MemAddTb.Text = membershipReader("MemAdd").ToString()
                        MemDepTb.Text = membershipReader("MemDep").ToString()
                    End If
                End Using
            End Using

            Dim dateJoinedQuery As String = "SELECT DateJoined FROM AdminLoanApprovalTbl WHERE MemUserName = @username"
            Using dateJoinedCmd As SqlCommand = New SqlCommand(dateJoinedQuery, con)
                dateJoinedCmd.Parameters.AddWithValue("@username", loggedInUserName)

                Dim dateJoined As Object = dateJoinedCmd.ExecuteScalar()
                If dateJoined IsNot DBNull.Value Then
                    Dim dateJoinedValue As DateTime = Convert.ToDateTime(dateJoined)
                    lblDateJoined.Text = dateJoinedValue.ToString("yyyy-MM-dd")
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
    Private Function LoadTransactionAmount() As Decimal
        Dim transactionAmount As Decimal = 0

        Try
            Dim query As String = "SELECT SUM(TransactionAmount) FROM statementTbl WHERE MemUserName = @Username"

            Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30")
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Username", loggedInUserName)

                    con.Open()

                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot DBNull.Value Then
                        transactionAmount = Convert.ToDecimal(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error while loading transaction amount: " & ex.Message)
        End Try

        Return transactionAmount
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub RequestLoanBtn_Click(sender As Object, e As EventArgs) Handles RequestLoanBtn.Click
        If TermsCb.SelectedIndex = -1 OrElse
       SecurityCb.SelectedIndex = -1 OrElse
       String.IsNullOrEmpty(MemNameTb.Text) OrElse
       String.IsNullOrEmpty(MemUserNameTb.Text) OrElse
       String.IsNullOrEmpty(MemIdPassNoTb.Text) OrElse
       String.IsNullOrEmpty(MemAddTb.Text) OrElse
       String.IsNullOrEmpty(MemEmailTb.Text) OrElse
       String.IsNullOrEmpty(MemMobileTb.Text) OrElse
       String.IsNullOrEmpty(MemDepTb.Text) OrElse
       String.IsNullOrEmpty(ContractTb.Text) OrElse
       String.IsNullOrEmpty(GrossTb.Text) OrElse
       String.IsNullOrEmpty(NetTb.Text) OrElse
       String.IsNullOrEmpty(PosTb.Text) OrElse
       String.IsNullOrEmpty(AmountTb.Text) OrElse
       String.IsNullOrEmpty(LoanAppliedTb.Text) OrElse
       String.IsNullOrEmpty(PurposeTb.Text) OrElse
       String.IsNullOrEmpty(RepaymentTb.Text) OrElse
       String.IsNullOrEmpty(SpecifyTb.Text) OrElse
       String.IsNullOrEmpty(DeductionTb.Text) OrElse
       borrowDatePicker.Value = DateTime.Now Then
            MessageBox.Show("Please fill in all fields to sign up.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim transactionAmount As Decimal = LoadTransactionAmount()
        AmountTb.Text = transactionAmount.ToString()

        If Decimal.TryParse(AmountTb.Text, transactionAmount) Then
            If Decimal.Parse(LoanAppliedTb.Text) > 3 * transactionAmount Then
                MessageBox.Show("Loan amount cannot exceed 3 times your saving amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Else
            MessageBox.Show("Invalid value for loan amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim memName As String = MemNameTb.Text
        Dim memIdPassNo As String = MemIdPassNoTb.Text
        Dim memUserName As String = MemUserNameTb.Text
        Dim memAdd As String = MemAddTb.Text
        Dim memDep As String = MemDepTb.Text
        Dim memEmail As String = MemEmailTb.Text
        Dim memMobile As String = MemMobileTb.Text
        Dim terms As String = TermsCb.SelectedItem.ToString()
        Dim contract As String = ContractTb.Text
        Dim gross As String = GrossTb.Text
        Dim net As String = NetTb.Text
        Dim position As String = PosTb.Text
        Dim loanApplied As String = LoanAppliedTb.Text
        Dim purpose As String = PurposeTb.Text
        Dim security As String = SecurityCb.SelectedItem.ToString()
        Dim specify As String = SpecifyTb.Text
        Dim deduction As String = DeductionTb.Text
        Dim borrowDate As DateTime = borrowDatePicker.Value

        Dim repayment As Integer
        If Integer.TryParse(RepaymentTb.Text, repayment) Then

            If repayment > 36 Then
                MessageBox.Show("Repayment period must be less than or equal to 36 months.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Else
            MessageBox.Show("Invalid value for repayment period.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            con.Open()

            Dim insertQuery As String = "INSERT INTO LoanRequestTbl (MemName, MemIdPassNo, MemUserName, MemAdd, MemDep, MemEmail, MemMobile, Terms, Contract, Gross, Net, Position, LoanApplied, Purpose, Repayment, Security, Specify, Deduction, borrowDate) " &
                                       "VALUES (@memName, @memIdPassNo, @memUserName, @memAdd, @memDep, @memEmail, @memMobile, @terms, @contract, @gross, @net, @position, @loanApplied, @purpose, @repayment, @security, @specify, @deduction, @borrowDate)"

            Using insertCmd As SqlCommand = New SqlCommand(insertQuery, con)

                insertCmd.Parameters.AddWithValue("@memName", memName)
                insertCmd.Parameters.AddWithValue("@memIdPassNo", memIdPassNo)
                insertCmd.Parameters.AddWithValue("@memUserName", memUserName)
                insertCmd.Parameters.AddWithValue("@memAdd", memAdd)
                insertCmd.Parameters.AddWithValue("@memDep", memDep)
                insertCmd.Parameters.AddWithValue("@memEmail", memEmail)
                insertCmd.Parameters.AddWithValue("@memMobile", memMobile)
                insertCmd.Parameters.AddWithValue("@terms", terms)
                insertCmd.Parameters.AddWithValue("@contract", contract)
                insertCmd.Parameters.AddWithValue("@gross", gross)
                insertCmd.Parameters.AddWithValue("@net", net)
                insertCmd.Parameters.AddWithValue("@position", position)
                insertCmd.Parameters.AddWithValue("@loanApplied", loanApplied)
                insertCmd.Parameters.AddWithValue("@purpose", purpose)
                insertCmd.Parameters.AddWithValue("@repayment", repayment)
                insertCmd.Parameters.AddWithValue("@security", security)
                insertCmd.Parameters.AddWithValue("@specify", specify)
                insertCmd.Parameters.AddWithValue("@deduction", deduction)
                insertCmd.Parameters.AddWithValue("@borrowDate", borrowDate)

                insertCmd.ExecuteNonQuery()

                MessageBox.Show("Loan request submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

        Catch ex As Exception
            MessageBox.Show("Error submitting loan request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Dim home As home_page = New home_page()
        home.UserName = loggedInUserName
        home.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim back As loan_page = New loan_page()
        back.UserName = loggedInUserName
        back.Show()
    End Sub

    Private Sub MaxAmountBtn_Click(sender As Object, e As EventArgs) Handles MaxAmountBtn.Click
        Dim amount As Decimal
        If Decimal.TryParse(AmountTb.Text, amount) Then
            LoanAppliedTb.Text = (amount * 3).ToString()
        Else
            MessageBox.Show("Invalid value in AmountTb.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class