Imports System.Data.SqlClient
Public Class reports_and_statements
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim back = New admin_page
        back.Show()
    End Sub

    Private Sub LoadStatementData(selectedUsername As String)
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30"
        Dim selectStatementQuery As String = "SELECT * FROM StatementTbl WHERE MemUserName = @MemUserName"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(selectStatementQuery, connection)
                command.Parameters.AddWithValue("@MemUserName", selectedUsername)

                Dim statementDataAdapter As New SqlDataAdapter(command)
                Dim statementDataTable As New DataTable()

                statementDataAdapter.Fill(statementDataTable)

                DataGridView1.DataSource = statementDataTable
            End Using
        End Using
    End Sub

    Private Sub LoadLoanRepaymentData(selectedUsername As String)
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30"
        Dim selectLoanRepaymentQuery As String = "SELECT * FROM LoanRepaymentTbl WHERE UserName = @MemUserName"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(selectLoanRepaymentQuery, connection)
                command.Parameters.AddWithValue("@MemUserName", selectedUsername)

                Dim loanRepaymentDataAdapter As New SqlDataAdapter(command)
                Dim loanRepaymentDataTable As New DataTable()

                loanRepaymentDataAdapter.Fill(loanRepaymentDataTable)

                DataGridView2.DataSource = loanRepaymentDataTable
            End Using
        End Using
    End Sub


    Private Sub LoadTotalBalance(selectedUsername As String)
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30"
        Dim selectTotalBalanceQuery As String = "SELECT TotalBalance FROM StatementTbl WHERE MemUserName = @MemUserName"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(selectTotalBalanceQuery, connection)
                command.Parameters.AddWithValue("@MemUserName", selectedUsername)

                connection.Open()

                Dim totalBalance As Object = command.ExecuteScalar()

                If totalBalance IsNot Nothing AndAlso Not IsDBNull(totalBalance) Then
                    TotalBalanceLbl.Text = totalBalance.ToString()
                Else
                    TotalBalanceLbl.Text = "N/A"
                End If
            End Using
        End Using
    End Sub

    Private Sub LoadLoanAmount(selectedUsername As String)
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30"
        Dim selectLoanAmountQuery As String = "SELECT SUM(LoanBorrowed) FROM LoanRepaymentTbl WHERE UserName = @MemUserName"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(selectLoanAmountQuery, connection)
                command.Parameters.AddWithValue("@MemUserName", selectedUsername)

                connection.Open()

                Dim loanAmount As Object = command.ExecuteScalar()

                If loanAmount IsNot Nothing AndAlso Not IsDBNull(loanAmount) Then
                    LoanAmountLbl.Text = loanAmount.ToString()
                Else
                    LoanAmountLbl.Text = "N/A"
                End If
            End Using
        End Using
    End Sub

    Private Sub LoadFine(selectedUsername As String)
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30"
        Dim selectFineQuery As String = "SELECT Fine FROM LoanRepaymentTbl WHERE UserName = @MemUserName"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(selectFineQuery, connection)
                command.Parameters.AddWithValue("@MemUserName", selectedUsername)

                connection.Open()

                Dim fine As Object = command.ExecuteScalar()

                If fine IsNot Nothing AndAlso Not IsDBNull(fine) Then
                    FineLbl.Text = fine.ToString()
                Else
                    FineLbl.Text = "N/A"
                End If
            End Using
        End Using
    End Sub
    Private Sub LoadInterest(selectedUsername As String)
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30"
        Dim selectInterestQuery As String = "SELECT (LoanAndIntrestAmount - LoanBorrowed) FROM LoanRepaymentTbl WHERE UserName = @MemUserName"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(selectInterestQuery, connection)
                command.Parameters.AddWithValue("@MemUserName", selectedUsername)

                connection.Open()

                Dim interest As Object = command.ExecuteScalar()

                If interest IsNot Nothing AndAlso Not IsDBNull(interest) Then
                    IntrestLbl.Text = interest.ToString()
                Else
                    IntrestLbl.Text = "N/A"
                End If
            End Using
        End Using
    End Sub
    Private Sub LoadPaidAmount(selectedUsername As String)
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30"
        Dim selectPaidAmountQuery As String = "SELECT (Installment1 + Installment2 + Installment3) FROM LoanRepaymentTbl WHERE UserName = @MemUserName"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(selectPaidAmountQuery, connection)
                command.Parameters.AddWithValue("@MemUserName", selectedUsername)

                connection.Open()

                Dim paidAmount As Object = command.ExecuteScalar()

                If paidAmount IsNot Nothing AndAlso Not IsDBNull(paidAmount) Then
                    PaidAmountLbl.Text = paidAmount.ToString()
                Else
                    PaidAmountLbl.Text = "N/A"
                End If
            End Using
        End Using
    End Sub
    Private Sub reports_and_statements_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsernames()
        DateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd")
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

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        Dim selectedUsername As String = txtMemUserName.Text.Trim()

        If Not String.IsNullOrEmpty(selectedUsername) Then
            LoadStatementData(selectedUsername)
            LoadLoanRepaymentData(selectedUsername)
            LoadTotalBalance(selectedUsername)
            LoadLoanAmount(selectedUsername)
            LoadFine(selectedUsername)
            LoadInterest(selectedUsername)
            LoadPaidAmount(selectedUsername)
        End If
        If Not String.IsNullOrEmpty(txtMemUserName.Text) Then
            Dim selectQuery As String = "SELECT MemName, MemMobile, MemIdPassNo FROM MembershipTbl WHERE MemUserName = @MemUserName"

            Using connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30")
                Using command As New SqlCommand(selectQuery, connection)
                    command.Parameters.AddWithValue("@MemUserName", selectedUsername)

                    connection.Open()

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            AccountOwnerLbl.Text = reader("MemName").ToString()
                            ContactLbl.Text = reader("MemMobile").ToString()
                            MemPassIdLbl2.Text = reader("MemIdPassNo").ToString()
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub printDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printDocument.PrintPage
        ' Define the drawing area and font
        Dim printArea As New RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height)
        Dim font As New Font("Arial", 12)

        ' Create a StringFormat object for alignment
        Dim format As New StringFormat()
        format.Alignment = StringAlignment.Center

        ' Draw the content on the print page
        Dim yPos As Single = printArea.Top
        Dim lineHeight As Single = font.GetHeight(e.Graphics) + 5

        ' Draw each label's text
        e.Graphics.DrawString("Account Owner: " & AccountOwnerLbl.Text, font, Brushes.Black, printArea, format)
        yPos += lineHeight

        e.Graphics.DrawString("Contact: " & ContactLbl.Text, font, Brushes.Black, printArea, format)
        yPos += lineHeight

        ' Repeat the above for other labels like TotalBalanceLbl, LoanAmountLbl, etc.

        ' Indicate that there's more content to print
        e.HasMorePages = False ' Set to True if you want to print multiple pages
    End Sub

    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        Dim printDialog As New PrintDialog()
        printDialog.Document = printDocument

        If printDialog.ShowDialog() = DialogResult.OK Then
            printDocument.Print()
        End If
    End Sub
End Class
