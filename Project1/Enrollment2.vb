Imports MySql.Data.MySqlClient
Public Class Enrollment2
    'user=your mysql user name; password=your password; database=your database name
    Dim str As String = "server=localhost; uid=root; pwd=; database=project_coviduniversity"
    Dim con As New MySqlConnection(str)

    Private Sub ButtonEnroll_Click(sender As Object, e As EventArgs) Handles ButtonEnroll.Click

        MessageBox.Show("You are now enrolled mofo")
        Me.Hide()
        login.Show()

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click

    End Sub
End Class