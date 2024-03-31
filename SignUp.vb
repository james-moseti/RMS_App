Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class SignUp
    Dim conn2 As SqlConnection
    Dim dbPath As String = Path.Combine(Application.StartupPath, "restaurant.mdf")
    Dim cmd2 As SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn2 = New SqlConnection()
        conn2.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & dbPath & ";Integrated Security=True;Connect Timeout=30"
        Dim pass As Boolean
        pass = tbPassword.Text = tbConfirmPassword.Text
        If pass = True Then
            If tbFirstName.Text = "" Or tbLastName.Text = "" Or tbEmail.Text = "" Or tbPassword.Text = "" Or tbConfirmPassword.Text = "" Then
                MsgBox("Enter all information")
            Else
                Try
                    conn2.Open()
                    Dim query2 = "INSERT INTO users VALUES(@email, @firstname, @lastname, @password);"
                    cmd2 = New SqlCommand(query2, conn2)
                    cmd2.Parameters.AddWithValue("@firstname", tbFirstName.Text)
                    cmd2.Parameters.AddWithValue("@lastname", tbLastName.Text)
                    cmd2.Parameters.AddWithValue("@email", tbEmail.Text)
                    cmd2.Parameters.AddWithValue("@password", tbPassword.Text)
                    cmd2.ExecuteNonQuery()
                    MsgBox("Successful, Go back to login page and log in")
                    conn2.Close()
                    tbFirstName.Text = ""
                    tbLastName.Text = ""
                    tbEmail.Text = ""
                    tbPassword.Text = ""
                    tbConfirmPassword.Text = ""
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conn2.Dispose()
                End Try
            End If
        Else
            If tbFirstName.Text = "" Or tbLastName.Text = "" Or tbEmail.Text = "" Or tbPassword.Text = "" Or tbConfirmPassword.Text = "" Then
                MsgBox("Enter all information")
            Else
                MsgBox("Passwords do not match")
            End If
            tbPassword.Text = ""
            tbConfirmPassword.Text = ""
        End If

    End Sub
End Class