Imports MySql.Data.MySqlClient
Public Class Enrollment

    'user=your mysql user name; password=your password; database=your database name
    Dim str As String = "server=localhost; uid=root; pwd=; database=project_pmdudatabase"
    Dim con As New MySqlConnection(str)

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs)
        Button21.BackColor = Color.Red
        Button2.BackColor = Color.White
        Button3.BackColor = Color.White
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As MySqlCommand
        con.Open()

        If sname.TextLength <= 0 Or fname.TextLength <= 0 Or mname.TextLength <= 0 Or TextBox4.TextLength <= 0 Or TextBox5.TextLength <= 0 Then
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

            If TextBox4.TextLength <= 0 Then
                Label33.Visible = True
            End If

            If TextBox5.TextLength <= 0 Then
                Label34.Visible = True
            End If

            If ComboBox1.SelectedIndex < 0 Then
                Label35.Visible = True
            End If

        Else
            Try
                cmd = con.CreateCommand
                cmd.CommandText = "insert into studentinfo (firstname, surname, middlename) values (@fname, @sname, @mname);"
                cmd.Parameters.AddWithValue("@fname", fname.Text)
                cmd.Parameters.AddWithValue("@sname", sname.Text)
                cmd.Parameters.AddWithValue("@mname", mname.Text)
                cmd.ExecuteNonQuery()

            Catch ex As Exception

            End Try
            Enrollment2.Show()
            Me.Hide()
        End If
        con.Close()
    End Sub
End Class