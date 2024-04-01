Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class adminPage
    Dim conn3 As SqlConnection
    Dim conn4 As SqlConnection
    Dim dbPath As String = Path.Combine(Application.StartupPath, "restaurant.mdf")
    Dim cmd3 As SqlCommand
    Dim cmd4 As SqlCommand
    Dim dbdataset As DataTable
    Dim dbdataset1 As DataTable
    Dim itemid As Integer

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub picMinimize_Click(sender As Object, e As EventArgs) Handles picMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub picMaximize_Click(sender As Object, e As EventArgs) Handles picMaximize.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        pnlInventory.Visible = True
        pnlUsers.Visible = False

        pnlOnButtonInventory.Visible = True
        pnlOnButtonUsers.Visible = False
    End Sub

    Private Sub adminPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlInventory.Visible = True
        pnlUsers.Visible = False

        pnlOnButtonInventory.Visible = True
        pnlOnButtonUsers.Visible = False
        loadtableinventory()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        loadtableusers()
        pnlInventory.Visible = False
        pnlUsers.Visible = True

        pnlOnButtonInventory.Visible = False
        pnlOnButtonUsers.Visible = True
    End Sub

    Private Sub loadtableinventory()
        conn3 = New SqlConnection()
        conn3.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & dbPath & ";Integrated Security=True;Connect Timeout=30"
        Dim da = New SqlDataAdapter
        Dim bsource = New BindingSource
        dbdataset = New DataTable
        Try
            conn3.Open()
            Dim query3 As String = "SELECT * FROM inventory;"
            cmd3 = New SqlCommand(query3, conn3)
            da.SelectCommand = cmd3
            da.Fill(dbdataset)
            bsource.DataSource = dbdataset
            dgvInventory.DataSource = bsource
            da.Update(dbdataset)
            conn3.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn3.Dispose()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        conn4 = New SqlConnection()
        conn4.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & dbPath & ";Integrated Security=True;Connect Timeout=30"
        Try
            conn4.Open()
            Dim query4 As String = "INSERT INTO users (first_name, last_name, email) VALUES (@first_name, @last_name, @email);"
            cmd4 = New SqlCommand(query4, conn4)
            cmd4.Parameters.AddWithValue("@first_name", tbFirstNameAP.Text)
            cmd4.Parameters.AddWithValue("@last_name", tbLastNameAP.Text)
            cmd4.Parameters.AddWithValue("@email", tbUserEmailAP.Text)
            cmd4.ExecuteNonQuery()
            conn4.Close()
            MsgBox("User added successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn4.Dispose()
        End Try
        loadtableusers()
        resetUserFields()
    End Sub

    Private Sub resetUserFields()
        tbFirstNameAP.Text = ""
        tbLastNameAP.Text = ""
        tbUserEmailAP.Text = ""
        tbSearchByNameAP.Text = ""
    End Sub

    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click
        conn4 = New SqlConnection()
        conn4.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & dbPath & ";Integrated Security=True;Connect Timeout=30"
        Try
            conn4.Open()
            Dim query4 As String = "UPDATE users SET first_name = @first_name, last_name = @last_name, email = @email WHERE userid = @userid;"
            cmd4 = New SqlCommand(query4, conn4)
            cmd4.Parameters.AddWithValue("@first_name", tbFirstNameAP.Text)
            cmd4.Parameters.AddWithValue("@last_name", tbLastNameAP.Text)
            cmd4.Parameters.AddWithValue("@email", tbUserEmailAP.Text)
            cmd4.Parameters.AddWithValue("@userid", itemid)
            cmd4.ExecuteNonQuery()
            conn4.Close()
            MsgBox("User Updated successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn4.Dispose()
        End Try
        loadtableusers()
        resetUserFields()
    End Sub

    Private Sub dgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick, dgvUsers.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = dgvUsers.Rows(e.RowIndex)
            tbFirstNameAP.Text = row.Cells("first_name").Value.ToString
            tbLastNameAP.Text = row.Cells("last_name").Value.ToString
            tbUserEmailAP.Text = row.Cells("email").Value.ToString
            itemid = row.Cells("userid").Value.ToString
        End If
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        conn4 = New SqlConnection()
        conn4.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & dbPath & ";Integrated Security=True;Connect Timeout=30"
        Try
            conn4.Open()
            Dim query4 As String = "DELETE FROM users WHERE userid = @userid;"
            cmd4 = New SqlCommand(query4, conn4)
            cmd4.Parameters.AddWithValue("@userid", itemid)
            cmd4.ExecuteNonQuery()
            conn4.Close()
            MsgBox("User Deleted successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn4.Dispose()
        End Try
        loadtableusers()
        resetUserFields()
    End Sub

    Private Sub tbSearchByNameAP_TextChanged(sender As Object, e As EventArgs) Handles tbSearchByNameAP.TextChanged
        Try
            Dim dv As New DataView(dbdataset1)
            dv.RowFilter = String.Format("first_name LIKE '%{0}%' OR last_name LIKE '%{0}%' OR email LIKE '%{0}%'", tbSearchByNameAP.Text)
            dgvUsers.DataSource = dv
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub loadtableusers()
        Dim da1 = New SqlDataAdapter
        Dim bsource1 = New BindingSource
        dbdataset1 = New DataTable
        conn4 = New SqlConnection()
        conn4.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & dbPath & ";Integrated Security=True;Connect Timeout=30"
        Try
            conn4.Open()
            Dim query4 As String = "SELECT userid, email, first_name, last_name FROM users;"
            cmd4 = New SqlCommand(query4, conn4)
            da1.SelectCommand = cmd4
            da1.Fill(dbdataset1)
            bsource1.DataSource = dbdataset1
            dgvUsers.DataSource = bsource1
            da1.Update(dbdataset1)
            conn4.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn4.Dispose()
        End Try
    End Sub
End Class
