Imports MySql.Data.MySqlClient
Public Class Enrollment2
    'user=your mysql user name; password=your password; database=your database name
    Dim str As String = "server=localhost; uid=root; pwd=; database=project_pmdudatabase"
    Dim con As New MySqlConnection(str)

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        MessageBox.Show("You are now enrolled mofo")
        Me.Hide()
        login.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Enrollment.Show()
    End Sub
End Class