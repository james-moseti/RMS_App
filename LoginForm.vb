Imports System.Diagnostics.Eventing
Imports System.IO
Imports Microsoft.Data.SqlClient

Public Module globalvar
    Public userid As String
End Module

Public Class Form1
    Dim conn As SqlConnection
    Dim dbPath As String = Path.Combine(Application.StartupPath, "restaurant.mdf")
    Dim cmd As SqlCommand



    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtUsername.Text = "Username"
        'txtUsername.ForeColor = Color.DarkGray

        'txtPassword.Text = "Password"
        'txtPassword.ForeColor = Color.DarkGray

    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        'If txtUsername.Text = "Username" Then
        'txtUsername.Text = ""
        'txtUsername.ForeColor = Color.Black
        'End If
    End Sub

    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        'If txtUsername.Text = "" Then
        'txtUsername.Text = "Username"
        'txtUsername.ForeColor = Color.DarkGray
        'End If
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        'If txtPassword.Text = "Password" Then
        'txtPassword.Text = ""
        'txtPassword.PasswordChar = "•"
        'txtPassword.ForeColor = Color.Black
        'End If
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        'If txtPassword.Text = "" Then
        'txtPassword.Text = "Password"
        'txtPassword.PasswordChar = ""
        'txtPassword.ForeColor = Color.DarkGray
        'End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        conn = New SqlConnection()
        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & dbPath & ";Integrated Security=True;Connect Timeout=30"
        Dim reader As SqlDataReader
        Dim admin As Boolean = False
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Enter all values")
        Else
            Try
                conn.Open()
                'MessageBox.Show("Connection successful")
                Dim query = "SELECT * FROM users WHERE userid = 1"
                cmd = New SqlCommand(query, conn)
                reader = cmd.ExecuteReader
                While reader.Read
                    Dim adminmail = reader("email").ToString
                    Dim adminpassword = reader("password").ToString
                    If txtUsername.Text = adminmail And txtPassword.Text = adminpassword Then
                        admin = True
                    End If
                End While
                conn.Close()
                ''MessageBox.Show(admin)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            If admin = True Then
                MsgBox("Welcome admin")
                txtUsername.Text = ""
                txtPassword.Text = ""
                adminPage.Show()
                Me.Hide()
            Else
                Try
                    Dim conn1 As New SqlConnection
                    Dim cmd1 As New SqlCommand
                    Dim reader1 As SqlDataReader
                    conn1.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & dbPath & ";Integrated Security=True;Connect Timeout=30"
                    conn1.Open()
                    Dim query1 As String = "SELECT * FROM users WHERE email = @email AND password = @password;"
                    cmd1 = New SqlCommand(query1, conn1)
                    cmd1.Parameters.AddWithValue("@email", txtUsername.Text)
                    cmd1.Parameters.AddWithValue("@password", txtPassword.Text)

                    reader1 = cmd1.ExecuteReader
                    Dim count As Integer = 0
                    While reader1.Read
                        count = count + 1
                        userid = reader1("userid").ToString
                    End While

                    If count = 1 Then
                        MsgBox("Login successful")
                        'MsgBox(userid)
                        txtUsername.Text = ""
                        txtPassword.Text = ""
                        Dashboard.Show()
                        Me.Hide()
                    Else
                        MsgBox("Incorrect username or password")
                    End If
                    conn1.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llnkSignUp.LinkClicked
        SignUp.Show()
        Me.Close()
    End Sub
End Class
