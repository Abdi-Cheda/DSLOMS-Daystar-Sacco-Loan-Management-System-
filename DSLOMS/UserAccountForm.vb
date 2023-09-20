Imports System.Data.SqlClient

Public Class UserAccountForm
    Private con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30")
    Public Property UserName As String
    Public Sub New(userName As String)
        Me.UserName = userName
        InitializeComponent()
    End Sub
    Private Sub UserAccountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserDetails()
        MemNewUserNameTb.Text = UserName
    End Sub

    Private Sub LoadUserDetails()
        Try
            con.Open()
            Dim query As String = "SELECT * FROM MembershipTbl WHERE MemUserName = @username"
            Dim cmd As SqlCommand = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@username", UserName)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                MemNameTb.Text = reader("MemName").ToString()
                MemEmailTb.Text = reader("MemEmail").ToString()
                MemMobileTb.Text = reader("MemMobile").ToString()
                MemUserNameTb.Text = reader("MemUserName").ToString()
                MemDOB.Value = reader("MemDOB").ToString()
                MemIdPassNoTb.Text = reader("MemIdPassNo").ToString()
                MemAddTb.Text = reader("MemAdd").ToString()
                MemPostTb.Text = reader("MemPost").ToString()
                MemCompanyTb.Text = reader("MemCompany").ToString()
                MemProfTb.Text = reader("MemProf").ToString()
                MemDepTb.Text = reader("MemDep").ToString()
                MemOtherTb.Text = reader("MemOther").ToString()
                MemGenderCb.SelectedItem = reader("MemGender").ToString()
                MemIntroCb.SelectedItem = reader("MemIntro").ToString()
                MemStatusCb.SelectedItem = reader("MemStatus").ToString()
                MemPassTb.Text = reader("MemPass").ToString()
            End If

            reader.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub UpdateUserDetails()
        Try
            con.Open()
            Dim query As String = "UPDATE MembershipTbl SET MemName = @name, MemPass = @password, MemUserName = @newUsername, MemEmail = @email, MemMobile = @mobile, MemDOB = @dob, MemIdPassNo = @idPassNo, MemAdd = @address, MemPost = @post, MemCompany = @company, MemProf = @profession, MemDep = @department, MemOther = @other, MemGender = @gender, MemIntro = @intro, MemStatus = @status WHERE MemUserName = @username"
            Dim cmd As SqlCommand = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@name", MemNameTb.Text)
            cmd.Parameters.AddWithValue("@password", MemPassTb.Text)
            cmd.Parameters.AddWithValue("@newUsername", MemNewUserNameTb.Text)
            cmd.Parameters.AddWithValue("@email", MemEmailTb.Text)
            cmd.Parameters.AddWithValue("@mobile", MemMobileTb.Text)
            cmd.Parameters.AddWithValue("@dob", MemDOB.Value)
            cmd.Parameters.AddWithValue("@idPassNo", MemIdPassNoTb.Text)
            cmd.Parameters.AddWithValue("@address", MemAddTb.Text)
            cmd.Parameters.AddWithValue("@post", MemPostTb.Text)
            cmd.Parameters.AddWithValue("@company", MemCompanyTb.Text)
            cmd.Parameters.AddWithValue("@profession", MemProfTb.Text)
            cmd.Parameters.AddWithValue("@department", MemDepTb.Text)
            cmd.Parameters.AddWithValue("@other", MemOtherTb.Text)
            cmd.Parameters.AddWithValue("@gender", MemGenderCb.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@intro", MemIntroCb.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@status", MemStatusCb.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@username", UserName)

            cmd.ExecuteNonQuery()
            MessageBox.Show("User details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UserName = MemNewUserNameTb.Text
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error updating user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        MemNewUserNameTb.Text = UserName
        UpdateUserDetails()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub homeBtn_Click(sender As Object, e As EventArgs) Handles homeBtn.Click
        Me.Hide()
        Dim home As home_page = New home_page()
        home.UserName = UserName
        home.Show()
    End Sub
End Class