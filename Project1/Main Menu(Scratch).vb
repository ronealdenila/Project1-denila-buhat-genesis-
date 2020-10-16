Public Class Main_Menu


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabPage1.Show()
        TabPage2.Hide()
        TabPage3.Hide()
        TabPage4.Hide()
        TabPage5.Hide()
        TabPage6.Hide()
        TabPage7.Hide()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabPage1.Hide()
        TabPage2.Show()
        TabPage3.Hide()
        TabPage4.Hide()
        TabPage5.Hide()
        TabPage6.Hide()
        TabPage7.Hide()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabPage1.Hide()
        TabPage2.Hide()
        TabPage3.Show()
        TabPage4.Hide()
        TabPage5.Hide()
        TabPage6.Hide()
        Label22.Hide()
        Label23.Hide()
        Label4.Hide()
        TabPage7.Hide()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabPage1.Hide()
        TabPage2.Hide()
        TabPage3.Hide()
        TabPage4.Show()
        TabPage5.Hide()
        TabPage6.Hide()
        TabPage7.Hide()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button8.BackColor = Color.FromArgb(241, 169, 33)
        Button9.BackColor = Color.FromArgb(241, 169, 33)
        Button11.BackColor = Color.FromArgb(241, 169, 33)
        TabPage1.Hide()
        TabPage2.Hide()
        TabPage3.Hide()
        TabPage4.Hide()
        TabPage5.Show()
        TabPage6.Hide()
        Panel1.Hide()
        Panel2.Hide()
        Panel4.Hide()
        TabPage7.Hide()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TabPage1.Hide()
        TabPage2.Hide()
        TabPage3.Hide()
        TabPage4.Hide()
        TabPage5.Hide()
        TabPage6.Show()
        TabPage7.Hide()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' Define the message you want to see inside the message box.
        Dim msg = "Are you sure you want to Logout?"

        ' Define a title for the message box.
        Dim title = "Logout"


        ' Now define a style for the message box. In this example, the
        ' message box will have Yes and No buttons, the default will be
        ' the No button, and a Critical Message icon will be present.
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or
            MsgBoxStyle.Critical

        ' Display the message box and save the response, Yes or No.
        Dim response = MsgBox(msg, style, title)

        ' Take some action based on the response.
        If response = MsgBoxResult.Yes Then
            MsgBox("Logout Succesfully", , title)
            Me.Hide()
            login.TextBoxUsername.Text = ""
            login.TextBoxPassword.Text = ""
            login.Show()
        Else

        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)
    End Sub

    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabPage1.Show()
        TabPage2.Hide()
        TabPage3.Hide()
        TabPage4.Hide()
        TabPage5.Hide()
        TabPage6.Hide()
        TabPage7.Hide()
    End Sub
    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        TabPage1.Hide()
        TabPage2.Hide()
        TabPage3.Hide()
        TabPage4.Hide()
        TabPage5.Hide()
        TabPage6.Hide()
        TabPage7.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Panel1.Show()
        Panel2.Hide()
        Panel4.Hide()
        Button8.BackColor = Color.FromArgb(140, 39, 3)
        Button9.BackColor = Color.FromArgb(241, 169, 33)
        Button11.BackColor = Color.FromArgb(241, 169, 33)

    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Panel1.Hide()
        Panel2.Show()
        Panel4.Hide()
        Button8.BackColor = Color.FromArgb(241, 169, 33)
        Button9.BackColor = Color.FromArgb(140, 39, 3)
        Button11.BackColor = Color.FromArgb(241, 169, 33)
    End Sub
    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click
        Panel1.Hide()
        Panel2.Hide()
        Panel4.Show()
        Button8.BackColor = Color.FromArgb(241, 169, 33)
        Button9.BackColor = Color.FromArgb(241, 169, 33)
        Button11.BackColor = Color.FromArgb(140, 39, 3)
    End Sub

    Private Sub TabPage5_Click(sender As Object, e As EventArgs) Handles TabPage5.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = "100"
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox1.Text = "200"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = "500"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text = "1000"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = "2000"
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox1.Text = "3000"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox1.Text = "4000"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = "5000"
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Button21.BackColor = Color.FromArgb(241, 169, 33)
        Button22.BackColor = Color.White
        Button23.BackColor = Color.White
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Button21.BackColor = Color.White
        Button22.BackColor = Color.FromArgb(241, 169, 33)
        Button23.BackColor = Color.White
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Button21.BackColor = Color.White
        Button22.BackColor = Color.White
        Button23.BackColor = Color.FromArgb(241, 169, 33)
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Button29.SendToBack()
        Button30.BringToFront()
        Button31.BringToFront()
        Button32.BringToFront()
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Button29.BringToFront()
        Button30.SendToBack()
        Button31.BringToFront()
        Button32.BringToFront()
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Button29.BringToFront()
        Button30.BringToFront()
        Button31.SendToBack()
        Button32.BringToFront()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Button29.BringToFront()
        Button30.BringToFront()
        Button31.BringToFront()
        Button32.SendToBack()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        ' Define the message you want to see inside the message box.
        Dim msg = "Thank you! Placido, Mitra & Denila University appreciate your feedback. "

        ' Define a title for the message box.
        Dim title = "Feedback Sent Succesfully"


        ' Now define a style for the message box. In this example, the
        ' message box will have Yes and No buttons, the default will be
        ' the No button, and a Critical Message icon will be present.
        Dim style = MsgBoxStyle.OkOnly

        ' Display the message box and save the response, Yes or No.
        Dim response = MsgBox(msg, style, title)

        ' Take some action based on the response.
        If response = MsgBoxResult.Yes Then
            Me.Hide()
        Else
        End If
        Button29.BringToFront()
        Button30.BringToFront()
        Button31.BringToFront()
        Button32.BringToFront()

        Button21.BackColor = Color.White
        Button22.BackColor = Color.White
        Button23.BackColor = Color.White

        TextBox3.Text = ""
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click

        If ComboBox1.SelectedItem = "2018-2019" Or ComboBox1.SelectedItem = "2019-2020" Then
            Panel10.Hide()
            Panel9.Hide()
            Panel20.Hide()
            Panel21.Hide()
            Label22.Hide()
            Label23.Show()
            Label4.Hide()
        Else
            ' Define the message you want to see inside the message box.
            Dim msg = "Please Select School Year"
            ' Define a title for the message box.
            Dim title = ""
            ' Now define a style for the message box. In this example, the
            ' message box will have Yes and No buttons, the default will be
            ' the No button, and a Critical Message icon will be present.
            Dim style = MsgBoxStyle.OkOnly
            ' Display the message box and save the response, Yes or No.
            Dim response = MsgBox(msg, style, title)
        End If
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click

        If ComboBox1.SelectedItem = "2018-2019" Then
            Panel10.Show()
            Panel9.Hide()

            Label22.Show()
            Label23.Hide()
            Label4.Hide()
        ElseIf ComboBox1.SelectedItem = "2019-2020" Then
            Panel10.Hide()
            Panel9.Hide()
            Panel21.Show()
            Panel20.Hide()

            Label4.Hide()
            Label22.Show()
            Label23.Hide()
        Else
            ' Define the message you want to see inside the message box.
            Dim msg = "Please Select School Year"
            ' Define a title for the message box.
            Dim title = ""
            ' Now define a style for the message box. In this example, the
            ' message box will have Yes and No buttons, the default will be
            ' the No button, and a Critical Message icon will be present.
            Dim style = MsgBoxStyle.OkOnly
            ' Display the message box and save the response, Yes or No.
            Dim response = MsgBox(msg, style, title)
        End If
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click

        If ComboBox1.SelectedItem = "2018-2019" Then
            Panel9.Show()
            Panel10.Hide()

            Label4.Show()
            Label22.Hide()
            Label23.Hide()

        ElseIf ComboBox1.SelectedItem = "2019-2020" Then
            Panel9.Hide()
            Panel10.Hide()
            Panel20.Show()
            Panel21.Hide()

            Label4.Show()
            Label22.Hide()
            Label23.Hide()

        Else
            ' Define the message you want to see inside the message box.
            Dim msg = "Please Select School Year"
            ' Define a title for the message box.
            Dim title = ""
            ' Now define a style for the message box. In this example, the
            ' message box will have Yes and No buttons, the default will be
            ' the No button, and a Critical Message icon will be present.
            Dim style = MsgBoxStyle.OkOnly
            ' Display the message box and save the response, Yes or No.
            Dim response = MsgBox(msg, style, title)
        End If

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        TabPage1.Hide()
        TabPage2.Hide()
        TabPage3.Hide()
        TabPage4.Hide()
        TabPage5.Hide()
        TabPage6.Hide()
        TabPage7.Show()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ' Define the message you want to see inside the message box.
        Dim msg = "Thanks for using PMDU E-wallet. Unfortunately, developer on this project needs more time to learn more about the subject to enhance this application. For now, please proceed to cashier for the payment."
        ' Define a title for the message box.
        Dim title = "PMDU E-Wallet Unavailable"
        ' Now define a style for the message box. In this example, the
        ' message box will have Yes and No buttons, the default will be
        ' the No button, and a Critical Message icon will be present.
        Dim style = MsgBoxStyle.OkOnly
        ' Display the message box and save the response, Yes or No.
        Dim response = MsgBox(msg, style, title)
        ' Take some action based on the response.
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        ' Define the message you want to see inside the message box.
        Dim msg = "Thanks for using PMDU E-wallet. Unfortunately, developer on this project needs more time to learn more about the subject to enhance this application. For now, please proceed to cashier for the payment."
        ' Define a title for the message box.
        Dim title = "PMDU E-Wallet Unavailable"
        ' Now define a style for the message box. In this example, the
        ' message box will have Yes and No buttons, the default will be
        ' the No button, and a Critical Message icon will be present.
        Dim style = MsgBoxStyle.OkOnly
        ' Display the message box and save the response, Yes or No.
        Dim response = MsgBox(msg, style, title)
        ' Take some action based on the response.
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' Define the message you want to see inside the message box.
        Dim msg = "Thanks for using PMDU E-wallet. Unfortunately, developer on this project needs more time to learn more about the subject to enhance this application. For now, please proceed to SAO to update your information."
        ' Define a title for the message box.
        Dim title = "Edit Unavailable"
        ' Now define a style for the message box. In this example, the
        ' message box will have Yes and No buttons, the default will be
        ' the No button, and a Critical Message icon will be present.
        Dim style = MsgBoxStyle.OkOnly
        ' Display the message box and save the response, Yes or No.
        Dim response = MsgBox(msg, style, title)
        ' Take some action based on the response.
    End Sub

End Class