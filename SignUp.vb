Imports System.IO
Imports Microsoft.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class SignUp
    Dim conn2 As SqlConnection
    Dim dbPath As String = Path.Combine(Application.StartupPath, "restaurant.mdf")
    Dim cmd2 As SqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn2 = New SqlConnection()
        conn2.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & dbPath & ";Integrated Security=True;Connect Timeout=30"
        Dim pass As Boolean
        pass = tbPassword.Text = tbConfirmPassword.Text
        Dim emailRegex As New Regex("^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$")
        Dim nameRegex As New Regex("[a-zA-Z]")

        If pass Then
            If tbFirstName.Text = "" OrElse tbLastName.Text = "" OrElse tbEmail.Text = "" OrElse tbPassword.Text = "" OrElse tbConfirmPassword.Text = "" Then
                MsgBox("Enter all information")
            ElseIf Not emailRegex.IsMatch(tbEmail.Text) Then
                MsgBox("Invalid email format")
            ElseIf Not nameRegex.IsMatch(tbFirstName.Text) OrElse Not nameRegex.IsMatch(tbLastName.Text) Then
                MsgBox("First name and last name must contain alphabetical characters")
            ElseIf tbPassword.Text.Contains(" ") OrElse tbConfirmPassword.Text.Contains(" ") Then
                MsgBox("Password cannot contain spaces")
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
                    MsgBox("Account created successfully!")
                    conn2.Close()
                    Form1.Show()
                    Me.Close()
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
            If tbFirstName.Text = "" OrElse tbLastName.Text = "" OrElse tbEmail.Text = "" OrElse tbPassword.Text = "" OrElse tbConfirmPassword.Text = "" Then
                MsgBox("Enter all information")
            Else
                MsgBox("Passwords do not match")
            End If
            tbPassword.Text = ""
            tbConfirmPassword.Text = ""
        End If
    End Sub
End Class
