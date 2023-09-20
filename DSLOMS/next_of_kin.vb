Imports System.Data.SqlClient
Public Class next_of_kin
    Public Property LoggedInUserName As String
    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox4.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.BackColor = Color.White
        PictureBox4.ForeColor = Color.White
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
    Private Sub Button4_Click(sender As Object, e As EventArgs) 
        Application.Exit()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Dim logout = New login_page
        logout.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        Dim logout = New login_page
        logout.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        KinTb.Clear()
        RshipTb.Clear()
        IdPassTb.Clear()
        PhoneTb.Clear()
        PercentTb.Clear()
        KinDOB.Value = DateTime.Now
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Dim home As New home_page()
        home.UserName = UserName
        home.Show()
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        Dim back As savings_and_deposit_management = New savings_and_deposit_management()
        back.UserName = UserName
        back.Show()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim nextOfKinName As String = KinTb.Text
        Dim relationship As String = RshipTb.Text
        Dim idPassportNumber As String = IdPassTb.Text
        Dim phoneNumber As String = PhoneTb.Text
        Dim dateOfBirth As Date = KinDOB.Value
        Dim percentageShare As Decimal
        If Decimal.TryParse(PercentTb.Text, percentageShare) Then
        Else
            MessageBox.Show("Invalid percentage value. Please enter a valid decimal number.")
            Return
        End If

        Dim userName As String = LoggedInUserName

        Try
            Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30")
                con.Open()

                Dim existingPercentage As Decimal = 0
                For Each row As DataGridViewRow In DataGridView1.Rows
                    existingPercentage += CDec(row.Cells("PercentageShare").Value)
                Next

                Dim totalPercentage As Decimal = existingPercentage + percentageShare

                If totalPercentage > 100 Then
                    MessageBox.Show($"Invalid. You cant assure more than {100 - existingPercentage}% of your share value.")
                    Return
                End If


                Dim query As String = "INSERT INTO NextOfKinTbl (MemUserName, NextOfKinName, Relationship, IDPassportNumber, PhoneNumber, DateOfBirth, PercentageShare) VALUES (@MemUserName, @NextOfKinName, @Relationship, @IDPassportNumber, @PhoneNumber, @DateOfBirth, @PercentageShare)"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@MemUserName", userName)
                    cmd.Parameters.AddWithValue("@NextOfKinName", nextOfKinName)
                    cmd.Parameters.AddWithValue("@Relationship", relationship)
                    cmd.Parameters.AddWithValue("@IDPassportNumber", idPassportNumber)
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
                    cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth)
                    cmd.Parameters.AddWithValue("@PercentageShare", percentageShare)

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show($"Next of kin information saved successfully. You are left with only {100 - (existingPercentage + percentageShare)}% to assign to Next of Kin.")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error while saving next of kin information: " & ex.Message)
        End Try

        LoadNextOfKinData()
    End Sub

    Private Sub next_of_kin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoggedInUserName = UserName
        LoadNextOfKinData()
        Populate()
        UserNameTb.Text = UserName
    End Sub

    Private Sub LoadNextOfKinData()
        Try
            Dim query As String = "SELECT * FROM NextOfKinTbl WHERE MemUserName = @Username"
            Dim ds As New DataSet()

            Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30")
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Username", UserName)

                    con.Open()

                    Dim adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(ds)
                End Using
            End Using

            DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error while loading next of kin information: " & ex.Message)
        End Try
    End Sub
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = DataGridView1.SelectedRows(0).Index
            Dim nextOfKinID As Integer = CInt(DataGridView1.Rows(selectedRowIndex).Cells("NextOfKinId").Value)

            Try
                Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30")
                    con.Open()

                    Dim query As String = "DELETE FROM NextOfKinTbl WHERE NextOfKinID = @NextOfKinId"

                    Using cmd As New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@NextOfKinId", nextOfKinID)
                        cmd.ExecuteNonQuery()
                    End Using

                End Using

                MessageBox.Show("Next of kin information deleted successfully.")
            Catch ex As Exception
                MessageBox.Show("Error while deleting next of kin information: " & ex.Message)
            End Try

            LoadNextOfKinData()
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub DataGridView1_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DataGridView1.UserDeletingRow
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim rowIndex As Integer = e.RowIndex
        Dim colIndex As Integer = e.ColumnIndex

        If DataGridView1.Columns(colIndex).Name = "NextOfKinId" Then
            Return
        End If

        Dim nextOfKinID As Integer = CInt(DataGridView1.Rows(rowIndex).Cells("NextOfKinId").Value)
        Dim newValue As Object = DataGridView1.Rows(rowIndex).Cells(colIndex).Value

        Try
            Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30")
                con.Open()
                Dim columnName As String = DataGridView1.Columns(colIndex).Name
                Dim query As String = "UPDATE NextOfKinTbl SET " & columnName & " = @NewValue WHERE NextOfKinId = @NextOfKinId"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@NewValue", newValue)
                    cmd.Parameters.AddWithValue("@NextOfKinId", nextOfKinID)
                    cmd.ExecuteNonQuery()
                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show("Error while updating next of kin information: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            KinTb.Text = selectedRow.Cells("NextOfKinName").Value.ToString()
            RshipTb.Text = selectedRow.Cells("Relationship").Value.ToString()
            IdPassTb.Text = selectedRow.Cells("IDPassportNumber").Value.ToString()
            PhoneTb.Text = selectedRow.Cells("PhoneNumber").Value.ToString()
            KinDOB.Value = CDate(selectedRow.Cells("DateOfBirth").Value)
            PercentTb.Text = selectedRow.Cells("PercentageShare").Value.ToString()
        End If
    End Sub
    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub
End Class