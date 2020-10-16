Imports MySql.Data.MySqlClient
Public Class Enrollment

    'user=your mysql user name; password=your password; database=your database name
    Dim str As String = "server=localhost; uid=root; pwd=; database=project_coviduniversity"
    Dim con As New MySqlConnection(str)

    Private Sub Button21_Click(sender As Object, e As EventArgs)
        Button21.BackColor = Color.Red
        Button2.BackColor = Color.White
        Button3.BackColor = Color.White
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Button21.BackColor = Color.White
        Button2.BackColor = Color.Red
        Button3.BackColor = Color.White
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Button21.BackColor = Color.White
        Button2.BackColor = Color.White
        Button3.BackColor = Color.Red
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Portal.Show()
    End Sub

    Private Sub ClearInputUpdateData()
        sname.Text = ""
        fname.Text = ""
        mname.Text = ""
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        Dim cmd As MySqlCommand
        Dim rdb As String = ""
        con.Open()

        If sname.TextLength <= 0 Or fname.TextLength <= 0 Or mname.TextLength <= 0 Or email.TextLength <= 0 Or address.TextLength <= 0 Then
            MsgBox("Please Fill all the Form")
            Label30.Visible = False
            Label31.Visible = False
            Label32.Visible = False
            Label33.Visible = False
            Label34.Visible = False
            Label35.Visible = False

            If sname.TextLength <= 0 Then
                Label30.Visible = True
            End If

            If fname.TextLength <= 0 Then
                Label31.Visible = True
            End If

            If mname.TextLength <= 0 Then
                Label32.Visible = True
            End If

            If email.TextLength <= 0 Then
                Label33.Visible = True
            End If

            If address.TextLength <= 0 Then
                Label34.Visible = True
            End If

            If ComboBox1.SelectedIndex < 0 Then
                Label35.Visible = True
            End If

        Else
            Try
                cmd = con.CreateCommand
                cmd.CommandText = "insert into personalprofile (surname, firstName, middleName,birthdate,gender,email,address,course) values (@surname, @firstName, @middleName, @birthdate, @gender, @email, @address, @course);"
                cmd.Parameters.AddWithValue("@surname", sname.Text)
                cmd.Parameters.AddWithValue("@firstName", fname.Text)
                cmd.Parameters.AddWithValue("@middleName", mname.Text)
                cmd.Parameters.AddWithValue("@birthdate", birthdate.Value)
                If RadioButtonMale.Checked Then
                    rdb = "Male"
                ElseIf RadioButtonFemale.Checked Then
                    rdb = "Female"
                End If

                cmd.Parameters.AddWithValue("@gender", rdb)
                cmd.Parameters.AddWithValue("@email", email.Text)
                cmd.Parameters.AddWithValue("@address", address.Text)
                cmd.Parameters.AddWithValue("@course", mname.Text)

                cmd.ExecuteNonQuery()

            Catch ex As Exception

            End Try
            Enrollment2.Show()
            Me.Hide()
        End If
        con.Close()
    End Sub
End Class