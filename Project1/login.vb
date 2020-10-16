Imports MySql.Data.MySqlClient
Public Class login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MainMenu.Show()
        Me.Hide()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Portal.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        ForgotPassword.Show()
        TextBoxUsername.Text = ""
        TextBoxPassword.Text = ""
    End Sub


End Class