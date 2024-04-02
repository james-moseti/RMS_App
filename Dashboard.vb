Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class Dashboard
    Dim conn As SqlConnection
    Dim dbPath As String = Path.Combine(Application.StartupPath, "restaurant.mdf")

    Private Sub logoPictureBox_Click(sender As Object, e As EventArgs) Handles logoPictureBox.Click
        logoPictureBox.BorderStyle = BorderStyle.None
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlFoods.Visible = True
        pnlDrinks.Visible = False
        pnlMyCart.Visible = False
        'pnlAboutUs.Visible = False

        'Orange panel to the left
        pnlOnButtonFood.Visible = True
        pnlOnButtonDrinks.Visible = False
        pnlOnButtonCart.Visible = False
        pnlOnButtonAbout.Visible = False

        lblCardNumber.Visible = False
        txtCardNumber.Visible = False

    End Sub

    Private Sub btnFoods_Click(sender As Object, e As EventArgs) Handles btnFoods.Click
        pnlFoods.Visible = True
        pnlDrinks.Visible = False
        pnlMyCart.Visible = False
        'pnlAboutUs.Visible = False


        'Orange panel to the left
        pnlOnButtonFood.Visible = True
        pnlOnButtonDrinks.Visible = False
        pnlOnButtonCart.Visible = False
        pnlOnButtonAbout.Visible = False
    End Sub

    Private Sub btnDrinks_Click(sender As Object, e As EventArgs) Handles btnDrinks.Click
        pnlFoods.Visible = False
        pnlDrinks.Visible = True
        pnlMyCart.Visible = False
        'pnlAboutUs.Visible = False


        'Orange panel to the left
        pnlOnButtonFood.Visible = False
        pnlOnButtonDrinks.Visible = True
        pnlOnButtonCart.Visible = False
        pnlOnButtonAbout.Visible = False
    End Sub

    Private Sub btnMyCart_Click(sender As Object, e As EventArgs) Handles btnMyCart.Click
        pnlFoods.Visible = False
        pnlDrinks.Visible = False
        pnlMyCart.Visible = True
        'pnlAboutUs.Visible = False


        'Orange panel to the left
        pnlOnButtonFood.Visible = False
        pnlOnButtonDrinks.Visible = False
        pnlOnButtonCart.Visible = True
        pnlOnButtonAbout.Visible = False
    End Sub

    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
        pnlFoods.Visible = False
        pnlDrinks.Visible = False
        pnlMyCart.Visible = False
        'pnlAboutUs.Visible = True


        'Orange panel to the left
        pnlOnButtonFood.Visible = False
        pnlOnButtonDrinks.Visible = False
        pnlOnButtonCart.Visible = False
        pnlOnButtonAbout.Visible = True
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Application.Exit()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCola.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCola.Click

    End Sub

    Private Sub pnlFoods_Paint(sender As Object, e As PaintEventArgs) Handles pnlFoods.Paint

    End Sub

    Public num As Integer
    Public Function increment(ByRef num As Integer) As Integer
        Return num + 1
    End Function

    Public Function decrement(ByRef num As Integer) As Integer
        If num = 0 Then
            Return num
        Else
            Return num - 1
        End If
    End Function

    Private Sub btnAddChicken_Click(sender As Object, e As EventArgs) Handles btnAddChicken.Click

        num = Integer.Parse(txtChicken.Text)
        Dim num2 As Integer = increment(num)
        txtChicken.Text = num2.ToString
    End Sub

    Private Sub btnSubChicken_Click(sender As Object, e As EventArgs) Handles btnSubChicken.Click

        num = Integer.Parse(txtChicken.Text)
        Dim num2 As Integer = decrement(num)
        txtChicken.Text = num2.ToString
    End Sub

    Private Sub btnAddNoodles_Click(sender As Object, e As EventArgs) Handles btnAddNoodles.Click
        num = Integer.Parse(txtNoodles.Text)
        Dim num2 As Integer = increment(num)
        txtNoodles.Text = num2.ToString
    End Sub

    Private Sub btnSubNoodles_Click(sender As Object, e As EventArgs) Handles btnSubNoodles.Click
        num = Integer.Parse(txtNoodles.Text)
        Dim num2 As Integer = decrement(num)
        txtNoodles.Text = num2.ToString
    End Sub

    Private Sub btnAddPizza_Click(sender As Object, e As EventArgs) Handles btnAddPizza.Click
        num = Integer.Parse(txtPizza.Text)
        Dim num2 As Integer = increment(num)
        txtPizza.Text = num2.ToString
    End Sub

    Private Sub btnSubPizza_Click(sender As Object, e As EventArgs) Handles btnSubPizza.Click
        num = Integer.Parse(txtPizza.Text)
        Dim num2 As Integer = decrement(num)
        txtPizza.Text = num2.ToString
    End Sub

    Private Sub btnAddRice_Click(sender As Object, e As EventArgs) Handles btnAddRice.Click
        num = Integer.Parse(txtRice.Text)
        Dim num2 As Integer = increment(num)
        txtRice.Text = num2.ToString
    End Sub

    Private Sub btnSubRice_Click(sender As Object, e As EventArgs) Handles btnSubRice.Click
        num = Integer.Parse(txtRice.Text)
        Dim num2 As Integer = decrement(num)
        txtRice.Text = num2.ToString
    End Sub

    Private Sub btnAddBurger_Click(sender As Object, e As EventArgs) Handles btnAddBurger.Click
        num = Integer.Parse(txtBurger.Text)
        Dim num2 As Integer = increment(num)
        txtBurger.Text = num2.ToString
    End Sub

    Private Sub btnSubBurger_Click(sender As Object, e As EventArgs) Handles btnSubBurger.Click
        num = Integer.Parse(txtBurger.Text)
        Dim num2 As Integer = decrement(num)
        txtBurger.Text = num2.ToString
    End Sub

    Private Sub btnAddOther_Click(sender As Object, e As EventArgs) Handles btnAddPancake.Click
        num = Integer.Parse(txtPancake.Text)
        Dim num2 As Integer = increment(num)
        txtPancake.Text = num2.ToString
    End Sub

    Private Sub btnSubOther_Click(sender As Object, e As EventArgs) Handles btnSubPancake.Click
        num = Integer.Parse(txtPancake.Text)
        Dim num2 As Integer = decrement(num)
        txtPancake.Text = num2.ToString
    End Sub

    Private Sub btnAddCola_Click(sender As Object, e As EventArgs) Handles btnAddCola.Click
        num = Integer.Parse(txtCola.Text)
        Dim num2 As Integer = increment(num)
        txtCola.Text = num2.ToString
    End Sub

    Private Sub btnSubCola_Click(sender As Object, e As EventArgs) Handles btnSubCola.Click
        num = Integer.Parse(txtCola.Text)
        Dim num2 As Integer = decrement(num)
        txtCola.Text = num2.ToString
    End Sub

    Private Sub btnAddCoffee_Click(sender As Object, e As EventArgs) Handles btnAddCoffee.Click
        num = Integer.Parse(txtCoffee.Text)
        Dim num2 As Integer = increment(num)
        txtCoffee.Text = num2.ToString
    End Sub

    Private Sub btnSubCoffee_Click(sender As Object, e As EventArgs) Handles btnSubCoffee.Click
        num = Integer.Parse(txtCoffee.Text)
        Dim num2 As Integer = decrement(num)
        txtCoffee.Text = num2.ToString
    End Sub

    Private Sub btnAddMilk_Click(sender As Object, e As EventArgs) Handles btnAddMilk.Click
        num = Integer.Parse(txtMilk.Text)
        Dim num2 As Integer = increment(num)
        txtMilk.Text = num2.ToString
    End Sub

    Private Sub btnSubMilk_Click(sender As Object, e As EventArgs) Handles btnSubMilk.Click
        num = Integer.Parse(txtMilk.Text)
        Dim num2 As Integer = decrement(num)
        txtMilk.Text = num2.ToString
    End Sub

    Private Sub btnAddChampagne_Click(sender As Object, e As EventArgs) Handles btnAddChampagne.Click
        num = Integer.Parse(txtChampagne.Text)
        Dim num2 As Integer = increment(num)
        txtChampagne.Text = num2.ToString
    End Sub

    Private Sub btnSubChampagne_Click(sender As Object, e As EventArgs) Handles btnSubChampagne.Click
        num = Integer.Parse(txtChampagne.Text)
        Dim num2 As Integer = decrement(num)
        txtChampagne.Text = num2.ToString
    End Sub

    Private Sub btnAddMate_Click(sender As Object, e As EventArgs) Handles btnAddMate.Click
        num = Integer.Parse(txtMate.Text)
        Dim num2 As Integer = increment(num)
        txtMate.Text = num2.ToString
    End Sub

    Private Sub btnSubMate_Click(sender As Object, e As EventArgs) Handles btnSubMate.Click
        num = Integer.Parse(txtMate.Text)
        Dim num2 As Integer = decrement(num)
        txtMate.Text = num2.ToString
    End Sub

    Private Sub btnAddOtherDrink_Click(sender As Object, e As EventArgs) Handles btnAddBeer.Click
        num = Integer.Parse(txtBeer.Text)
        Dim num2 As Integer = increment(num)
        txtBeer.Text = num2.ToString
    End Sub

    Private Sub btnSubOtherDrink_Click(sender As Object, e As EventArgs) Handles btnSubBeer.Click
        num = Integer.Parse(txtBeer.Text)
        Dim num2 As Integer = decrement(num)
        txtBeer.Text = num2.ToString
    End Sub

    Private Sub btnAddToCartFoods_Click(sender As Object, e As EventArgs) Handles btnAddToCartFoods.Click

        If Integer.TryParse(txtChicken.Text, Nothing) AndAlso Integer.Parse(txtChicken.Text) > 0 Then
            addcart(1, txtChicken.Text)
        End If

        If Integer.TryParse(txtNoodles.Text, Nothing) AndAlso Integer.Parse(txtNoodles.Text) > 0 Then
            addcart(2, txtNoodles.Text)
        End If

        If Integer.TryParse(txtPizza.Text, Nothing) AndAlso Integer.Parse(txtPizza.Text) > 0 Then
            addcart(3, txtPizza.Text)
        End If

        If Integer.TryParse(txtRice.Text, Nothing) AndAlso Integer.Parse(txtRice.Text) > 0 Then
            addcart(4, txtRice.Text)
        End If

        If Integer.TryParse(txtBurger.Text, Nothing) AndAlso Integer.Parse(txtBurger.Text) > 0 Then
            addcart(5, txtBurger.Text)
        End If

        If Integer.TryParse(txtPancake.Text, Nothing) AndAlso Integer.Parse(txtPancake.Text) > 0 Then
            addcart(14, txtPancake.Text)
        End If

    End Sub

    Private Sub btnAddToCartDrinks_Click(sender As Object, e As EventArgs) Handles btnAddToCartDrinks.Click
        If Integer.TryParse(txtCola.Text, Nothing) AndAlso Integer.Parse(txtCola.Text) > 0 Then
            addcart(6, txtCola.Text)
        End If

        If Integer.TryParse(txtCoffee.Text, Nothing) AndAlso Integer.Parse(txtCoffee.Text) > 0 Then
            addcart(7, txtCoffee.Text)
        End If

        If Integer.TryParse(txtMilk.Text, Nothing) AndAlso Integer.Parse(txtMilk.Text) > 0 Then
            addcart(8, txtMilk.Text)
        End If

        If Integer.TryParse(txtChampagne.Text, Nothing) AndAlso Integer.Parse(txtChampagne.Text) > 0 Then
            addcart(9, txtRice.Text)
        End If

        If Integer.TryParse(txtMate.Text, Nothing) AndAlso Integer.Parse(txtMate.Text) > 0 Then
            addcart(15, txtMate.Text)
        End If

        If Integer.TryParse(txtPancake.Text, Nothing) AndAlso Integer.Parse(txtPancake.Text) > 0 Then
            addcart(16, txtPancake.Text)
        End If

        If Integer.TryParse(txtBeer.Text, Nothing) AndAlso Integer.Parse(txtBeer.Text) > 0 Then
            addcart(20, txtBeer.Text)
        End If

    End Sub

    Private Sub AddOrder(category As String)
        ' Open connection
        conn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & dbPath & ";Integrated Security=True;Connect Timeout=30")
        conn.Open()

        ' Begin a transaction
        Dim transaction As SqlTransaction = conn.BeginTransaction()

        Try
            ' Create command to insert into orders table
            Dim insertOrderCommand As New SqlCommand("INSERT INTO orders (userid, total_amount) VALUES (@userid, @total_amount); SELECT SCOPE_IDENTITY();", conn, transaction)
            insertOrderCommand.Parameters.AddWithValue("@userid", 1) ' Example userid, replace with actual userid
            ' Calculate total amount based on items in the cart
            Dim totalAmount As Integer = CalculateTotalAmount()
            insertOrderCommand.Parameters.AddWithValue("@total_amount", totalAmount)

            ' Execute command to insert order and get the inserted order id
            Dim orderId As Integer = Convert.ToInt32(insertOrderCommand.ExecuteScalar())

            ' Create command to insert into orderitems table for each item in the cart
            Dim insertOrderItemCommand As New SqlCommand("INSERT INTO orderitems (orderid, itemid, quantity) VALUES (@orderid, @itemid, @quantity);", conn, transaction)
            For Each control As Control In pnlMyCart.Controls
                If TypeOf control Is Label Then
                    Dim label As Label = DirectCast(control, Label)
                    Dim itemDetails() As String = label.Text.Split(":")
                    Dim itemName As String = itemDetails(0).Trim()
                    Dim quantity As Integer = Convert.ToInt32(itemDetails(1).Trim())
                    ' Fetch itemid from inventory table based on item name and category (foods or drinks)
                    Dim itemId As Integer = GetItemId(itemName, category)
                    ' Insert order item
                    insertOrderItemCommand.Parameters.Clear()
                    insertOrderItemCommand.Parameters.AddWithValue("@orderid", orderId)
                    insertOrderItemCommand.Parameters.AddWithValue("@itemid", itemId)
                    insertOrderItemCommand.Parameters.AddWithValue("@quantity", quantity)
                    insertOrderItemCommand.ExecuteNonQuery()
                    ' Deduct stock from inventory
                    DeductStock(itemId, quantity)
                End If
            Next

            ' Commit the transaction if all operations succeed
            transaction.Commit()
            MessageBox.Show("Order placed successfully!")
        Catch ex As Exception
            ' Rollback the transaction if an exception occurs
            transaction.Rollback()
            MessageBox.Show("Failed to place order: " & ex.Message)
        Finally
            ' Close connection
            conn.Close()
        End Try
    End Sub

    Private Function CalculateTotalAmount() As Integer
        ' Your logic to calculate total amount based on items in the cart
        Return 0 ' Placeholder, replace with actual calculation
    End Function

    Private Function GetItemId(itemName As String, category As String) As Integer
        ' Your logic to fetch itemid from inventory table based on item name and category
        Return 0 ' Placeholder, replace with actual database query
    End Function

    Private Sub DeductStock(itemId As Integer, quantity As Integer)
        ' Your logic to deduct stock from the inventory table
        ' Example SQL command:
        ' UPDATE inventory SET stock = stock - @quantity WHERE itemid = @itemid
    End Sub

    Private Sub addcart(ByVal itemid As Integer, ByVal quantity As Integer)
        conn = New SqlConnection()
        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & dbPath & ";Integrated Security=True;Connect Timeout=30"
        Try
            conn.Open()
            Dim query As String = "INSERT INTO cart VALUES(@itemid, @quantity)"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@itemid", itemid)
            cmd.Parameters.AddWithValue("@quantity", quantity)
            cmd.ExecuteNonQuery()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub cbPaymentOption_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPaymentOption.SelectedIndexChanged
        If cbPaymentOption.SelectedItem.ToString() = "Card" Then
            lblCardNumber.Visible = True
            txtCardNumber.Visible = True
        Else
            lblCardNumber.Visible = False
            txtCardNumber.Visible = False
        End If
    End Sub
End Class