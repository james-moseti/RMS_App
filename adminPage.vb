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
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub picMaximize_Click(sender As Object, e As EventArgs) Handles picMaximize.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        ElseIf Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub btnFoods_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
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

    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        'loadtableusers()
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
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
            da1.Fill(dbdataset)
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