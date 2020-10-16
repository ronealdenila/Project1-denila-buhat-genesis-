Public Class ForgotPassword

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        TextBox1.Text = ""
    End Sub
    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = "" Then
            TextBox1.Text = "Email"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        TextBox1.Text = "Email"
        login.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.TextLength <= 0 Then
            MsgBox("Please enter your enrolled Email.")
        ElseIf TextBox1.TextLength >= 0 Then
            ' Define the message you want to see inside the message box.
            Dim msg = "Email sent. If the email address you entered is enrolled at PMD University, you'll receive an email with with instructions on how to set a new password."
            ' Define a title for the message box.
            Dim title = "Password Reset Succesfully"
            ' Now define a style for the message box. In this example, the
            ' message box will have Yes and No buttons, the default will be
            ' the No button, and a Critical Message icon will be present.
            Dim style = MsgBoxStyle.OkOnly
            ' Display the message box and save the response, Yes or No.
            Dim response = MsgBox(msg, style, title)
            ' Take some action based on the response.
            If response = MsgBoxResult.Ok Then
                Me.Hide()
                TextBox1.Text = "Email"
                login.Show()

            End If

        End If
    End Sub
End Class