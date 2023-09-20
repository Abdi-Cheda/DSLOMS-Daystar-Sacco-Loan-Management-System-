Imports System.Data.SqlClient
Public Class member_management
    Private Sub member_management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToDataGridView()
    End Sub
    Private Sub LoadDataToDataGridView()
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30"
        Dim query As String = "SELECT * FROM MembershipTbl"

        Dim dataTable As New DataTable()

        Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Abdi Cheda\Documents\MembershipVbDb.mdf"";Integrated Security=True;Connect Timeout=30")
            Using adapter As New SqlDataAdapter(query, con)
                con.Open()
                adapter.Fill(dataTable)
            End Using
        End Using

        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub sadmBtn_Click(sender As Object, e As EventArgs) Handles sadmBtn.Click
        Me.Hide()
        Dim back = New admin_page
        back.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub
End Class