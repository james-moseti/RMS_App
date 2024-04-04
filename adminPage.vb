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
    Dim userid As Integer

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub picMinimize_Click(sender As Object, e As EventArgs) Handles picMinimize.Click
        Me.WindowState = FormWindowState.Minimized
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

    Private Sub btnAddStock_Click(sender As Object, e As EventArgs) Handles btnAddStock.Click
        conn3 = New SqlConnection()
        conn3.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & dbPath & ";Integrated Security=True;Connect Timeout=30"
        Try
            conn3.Open()
            Dim query3 As String = "INSERT INTO inventory (name, price, quantity) VALUES (@name, @price, @quantity);"
            cmd3 = New SqlCommand(query3, conn3)
            cmd3.Parameters.AddWithValue("@name", tbName.Text)
            cmd3.Parameters.AddWithValue("@price", tbPrice.Text)
            cmd3.Parameters.AddWithValue("@quantity", tbQuantity.Text)
            cmd3.ExecuteNonQuery()
            conn3.Close()
            MsgBox("Item added successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn3.Dispose()
        End Try
        loadtableinventory()
        reset()
    End Sub
    Private Sub reset()
        tbName.Text = ""
        tbPrice.Text = ""
        tbQuantity.Text = ""
        tbSearch.Text = ""
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdateStock.Click
        conn3 = New SqlConnection()
        conn3.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & dbPath & ";Integrated Security=True;Connect Timeout=30"
        Try
            conn3.Open()
            Dim query3 As String = "UPDATE inventory SET name = @name, price = @price, quantity = @quantity WHERE itemid = @itemid;"
            cmd3 = New SqlCommand(query3, conn3)
            cmd3.Parameters.AddWithValue("@name", tbName.Text)
            cmd3.Parameters.AddWithValue("@price", tbPrice.Text)
            cmd3.Parameters.AddWithValue("@quantity", tbQuantity.Text)
            cmd3.Parameters.AddWithValue("@itemid", itemid)
            cmd3.ExecuteNonQuery()
            conn3.Close()
            MsgBox("Item Updated successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn3.Dispose()
        End Try
        loadtableinventory()
        reset()
    End Sub

    Private Sub dgvInventory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellContentClick, dgvInventory.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = dgvInventory.Rows(e.RowIndex)
            tbName.Text = row.Cells("name").Value.ToString
            tbPrice.Text = row.Cells("price").Value.ToString
            tbQuantity.Text = row.Cells("quantity").Value.ToString
            itemid = row.Cells("itemid").Value.ToString
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDeleteStock.Click
        conn3 = New SqlConnection()
        conn3.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & dbPath & ";Integrated Security=True;Connect Timeout=30"
        Try
            conn3.Open()
            Dim query3 As String = "DELETE FROM inventory WHERE itemid = @itemid;"
            cmd3 = New SqlCommand(query3, conn3)
            cmd3.Parameters.AddWithValue("@itemid", itemid)
            cmd3.ExecuteNonQuery()
            conn3.Close()
            MsgBox("Item Deleted successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn3.Dispose()
        End Try
        loadtableinventory()
        reset()
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        Try
            Dim dv As New DataView(dbdataset)
            dv.RowFilter = String.Format("name like '%{0}%'", tbSearch.Text)
            dgvInventory.DataSource = dv
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub resetUserFields()
        tbFirstNameAP.Text = ""
        tbLastNameAP.Text = ""
        tbUserEmailAP.Text = ""
        tbSearchByNameAP.Text = ""
    End Sub

    Private Sub dgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick, dgvUsers.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = dgvUsers.Rows(e.RowIndex)
            tbFirstNameAP.Text = row.Cells("first_name").Value.ToString
            tbLastNameAP.Text = row.Cells("last_name").Value.ToString
            tbUserEmailAP.Text = row.Cells("email").Value.ToString
            userid = row.Cells("userid").Value.ToString
        End If
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        conn4 = New SqlConnection()
        conn4.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & dbPath & ";Integrated Security=True;Connect Timeout=30"
        Try
            conn4.Open()
            Dim query4 As String = "DELETE FROM users WHERE userid = @userid;"
            cmd4 = New SqlCommand(query4, conn4)
            cmd4.Parameters.AddWithValue("@userid", userid)
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
