Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Imports System.Text.RegularExpressions
Imports Microsoft.Data.SqlClient

Public Class Dashboard
    Dim conn As SqlConnection
    Dim dbPath As String = Path.Combine(Application.StartupPath, "restaurant.mdf")
    Dim dbdataset2 As DataTable
    Dim itemid As String

    Private Sub logoPictureBox_Click(sender As Object, e As EventArgs) Handles logoPictureBox.Click
        logoPictureBox.BorderStyle = BorderStyle.None
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlFoods.Visible = True
        pnlDrinks.Visible = False
        pnlMyCart.Visible = False
        pnlAboutUs.Visible = False

        'Orange panel to the left
        pnlOnButtonFood.Visible = True
        pnlOnButtonDrinks.Visible = False
        pnlOnButtonCart.Visible = False
        pnlOnButtonAbout.Visible = False

        lblCardNumber.Visible = False
        txtCardNumber.Visible = False
        lblTableNumber.Visible = False
        txtTableNumber.Visible = False
        lblMpesaCode.Visible = False
        txtConfirmMpesaCode.Visible = False
        getuserinfo()
        DeleteAllCartItems()
    End Sub

    Private Sub btnFoods_Click(sender As Object, e As EventArgs) Handles btnFoods.Click
        pnlFoods.Visible = True
        pnlDrinks.Visible = False
        pnlMyCart.Visible = False
        pnlAboutUs.Visible = False


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
        pnlAboutUs.Visible = False


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
        pnlAboutUs.Visible = False


        'Orange panel to the left
        pnlOnButtonFood.Visible = False
        pnlOnButtonDrinks.Visible = False
        pnlOnButtonCart.Visible = True
        pnlOnButtonAbout.Visible = False

        loadtablecart()
        gettotal()
        getuserinfo()

    End Sub

    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
        pnlFoods.Visible = False
        pnlDrinks.Visible = False
        pnlMyCart.Visible = False
        pnlAboutUs.Visible = True


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
            addcart(16, txtPancake.Text)
        End If
        If txtChicken.Text <> 0 Or txtNoodles.Text <> 0 Or txtPizza.Text <> 0 Or txtRice.Text <> 0 Or txtBurger.Text <> 0 Or txtPancake.Text <> 0 Then
            MsgBox("Added to cart successfully")
        End If

        txtChicken.Text = 0
        txtNoodles.Text = 0
        txtPizza.Text = 0
        txtRice.Text = 0
        txtBurger.Text = 0
        txtPancake.Text = 0
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
            addcart(9, txtChampagne.Text)
        End If

        If Integer.TryParse(txtMate.Text, Nothing) AndAlso Integer.Parse(txtMate.Text) > 0 Then
            addcart(15, txtMate.Text)
        End If
        If Integer.TryParse(txtBeer.Text, Nothing) AndAlso Integer.Parse(txtBeer.Text) > 0 Then
            addcart(20, txtBeer.Text)
        End If

        If txtCola.Text <> 0 Or txtCola.Text <> 0 Or txtCoffee.Text <> 0 Or txtMilk.Text <> 0 Or txtChampagne.Text <> 0 Or txtMate.Text <> 0 Or txtBeer.Text <> 0 Then
            MsgBox("Added to cart successfully")
        End If

        txtCola.Text = 0
        txtCoffee.Text = 0
        txtMilk.Text = 0
        txtChampagne.Text = 0
        txtMate.Text = 0
        txtBeer.Text = 0
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
        ElseIf cbPaymentOption.SelectedItem.ToString() = "Mpesa" Then
            lblMpesaCode.Visible = True
            txtConfirmMpesaCode.Visible = True
        Else
            lblCardNumber.Visible = False
            txtCardNumber.Visible = False
        End If
    End Sub
    Private Sub loadtablecart()
        conn = New SqlConnection()
        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & dbPath & ";Integrated Security=True;Connect Timeout=30"
        Dim da2 = New SqlDataAdapter
        Dim bsource2 = New BindingSource
        dbdataset2 = New DataTable
        Try
            conn.Open()
            Dim query4 As String = "SELECT inventory.itemid, inventory.name, inventory.price, cart.quantity, (inventory.price * cart.quantity) AS [Total price] FROM cart JOIN inventory ON cart.itemid = inventory.itemid;"
            Dim cmd3 = New SqlCommand(query4, conn)
            da2.SelectCommand = cmd3
            da2.Fill(dbdataset2)
            bsource2.DataSource = dbdataset2
            dgvCart.DataSource = bsource2
            da2.Update(dbdataset2)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub gettotal()
        Dim reader As SqlDataReader
        conn = New SqlConnection()
        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & dbPath & ";Integrated Security=True;Connect Timeout=30"
        Try
            conn.Open()
            Dim query As String = "WITH joinedtable AS (SELECT inventory.name, inventory.price, cart.quantity, (inventory.price * cart.quantity) AS Total_price FROM cart JOIN inventory ON cart.itemid = inventory.itemid) SELECT SUM(Total_price) AS totalamount from joinedtable"
            Dim cmd As New SqlCommand(query, conn)
            reader = cmd.ExecuteReader
            While reader.Read
                Dim totalamount = reader("totalamount").ToString
                tbTotal.Text = totalamount
            End While
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub getuserinfo()
        Dim reader As SqlDataReader
        conn = New SqlConnection()
        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & dbPath & ";Integrated Security=True;Connect Timeout=30"
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM users WHERE userid = @userid;"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@userid", userid)
            reader = cmd.ExecuteReader
            While reader.Read
                txtEmailCart.Text = reader("email").ToString
                txtfirstnamecart.Text = reader("first_name").ToString
                txtlastnamecart.Text = reader("last_name").ToString
            End While
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub cbModeOfOrder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbModeOfOrder.SelectedIndexChanged
        If cbModeOfOrder.SelectedItem.ToString() = "In Restaurant" Then
            lblCounty.Visible = False
            cbCountyCart.Visible = False
            lblCityCart.Visible = False
            txtCityCart.Visible = False
            lblStreetAddressCart.Visible = False
            txtStreetAddressCart.Visible = False
            lblTableNumber.Visible = True
            txtTableNumber.Visible = True
            lblPhoneNumber.Visible = False
            txtPhoneNumber.Visible = False
        Else
            lblCounty.Visible = True
            cbCountyCart.Visible = True
            lblCityCart.Visible = True
            txtCityCart.Visible = True
            lblStreetAddressCart.Visible = True
            txtStreetAddressCart.Visible = True
            lblTableNumber.Visible = False
            txtTableNumber.Visible = False
            lblPhoneNumber.Visible = True
            txtPhoneNumber.Visible = True
        End If
    End Sub

    Private Sub btnDeleteOrder_Click(sender As Object, e As EventArgs) Handles btnDeleteOrder.Click
        If itemid = "" Then
            MsgBox("Please select an order to be deleted from cart")
        Else
            conn = New SqlConnection()
            conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & dbPath & ";Integrated Security=True;Connect Timeout=30"
            Try
                conn.Open()
                Dim query As String = "DELETE FROM cart WHERE itemid = @itemid"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@itemid", itemid)
                cmd.ExecuteNonQuery()
                conn.Close()

                loadtablecart()
                gettotal()
                itemid = ""
                MsgBox("Order removed from cart successfully.")
            Catch ex As Exception
                MsgBox("Failed to delete items from cart: " & ex.Message)
            Finally
                conn.Dispose()
            End Try
        End If
    End Sub

    Private Sub DeleteAllCartItems()
        conn = New SqlConnection()
        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & dbPath & ";Integrated Security=True;Connect Timeout=30"
        Try
            conn.Open()
            Dim query As String = "DELETE FROM cart"
            Dim cmd As New SqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            conn.Close()

            loadtablecart()
            gettotal()
            'MsgBox("All items removed from cart successfully.")
        Catch ex As Exception
            MsgBox("Failed to delete items from cart: " & ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Function ValidateTableNumber(ByVal tableNumber As String) As Boolean
        Dim parsedTableNumber As Integer
        If Integer.TryParse(tableNumber, parsedTableNumber) Then
            ' Check if table number is within the range of 1 to 100
            If parsedTableNumber >= 1 AndAlso parsedTableNumber <= 100 Then
                Return True
            End If
        End If
        Return False
    End Function

    Private Function ValidateMpesaConfirmationCode(ByVal confirmationCode As String) As Boolean
        ' Check if the confirmation code is exactly 10 characters
        If confirmationCode.Length = 10 Then
            ' Check if all characters are uppercase letters or digits
            For Each ch As Char In confirmationCode
                If Not Char.IsLetterOrDigit(ch) OrElse Char.IsLower(ch) Then
                    Return False
                End If
            Next
            Return True
        End If
        Return False
    End Function

    Private Function ValidateCardNumber(ByVal cardNumber As String) As Boolean
        ' Check if the card number is exactly 11 digits
        If cardNumber.Length = 11 AndAlso cardNumber.All(Function(c) Char.IsDigit(c)) Then
            Return True
        End If
        Return False
    End Function


    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        ' Validating the phone number

        If cbModeOfOrder.SelectedItem = "" Then
            MsgBox("Enter the mode of order")
        Else
            If cbModeOfOrder.SelectedItem = "In Restaurant" Then
                If ValidateTableNumber(txtTableNumber.Text) Then
                    ''MessageBox.Show("Table number must be a number between 1 and 100.", "Invalid Table Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    If cbPaymentOption.SelectedItem = "" Then
                        MsgBox("Enter your preferred payment option")
                    ElseIf cbPaymentOption.SelectedItem = "Cash" Then
                        Dim tableNumberMessage As String = $"The order for table number {txtTableNumber.Text} has been received and you will be served shortly. Enjoy your meal!"
                        MessageBox.Show(tableNumberMessage, "Pickup Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ElseIf cbPaymentOption.SelectedItem = "Card" Then
                        If ValidateCardNumber(txtCardNumber.Text) Then
                            Dim tableNumberMessage As String = $"The order for table number {txtTableNumber.Text} has been received and you will be served shortly. Enjoy your meal!"
                            MessageBox.Show(tableNumberMessage, "Pickup Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Invalid card number. Please enter 11 digits.", "Invalid Card Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                    Else
                        If ValidateMpesaConfirmationCode(txtConfirmMpesaCode.Text) Then
                            Dim tableNumberMessage As String = $"The order for table number {txtTableNumber.Text} has been received and you will be served shortly. Enjoy your meal!"
                            MessageBox.Show(tableNumberMessage, "Pickup Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Invalid M-Pesa confirmation code. Please enter 10 uppercase letters/digits.", "Invalid M-Pesa Confirmation Code", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If

                    End If
                Else
                    MessageBox.Show("Table number must be a number between 1 and 100.", "Invalid Table Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If

            Else

                If String.IsNullOrEmpty(txtCityCart.Text) OrElse String.IsNullOrEmpty(txtStreetAddressCart.Text) OrElse String.IsNullOrEmpty(cbCountyCart.SelectedItem?.ToString()) Then
                    MessageBox.Show("Please fill in all delivery information.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                Else
                    If ValidatePhoneNumber(txtPhoneNumber.Text) Then
                        If cbPaymentOption.SelectedItem = "" Then
                            MsgBox("Enter your preferred payment option")
                        ElseIf cbPaymentOption.SelectedItem = "Cash" Then
                            Dim deliveryMessage As String = $"Your order will be delivered to:
City: {txtCityCart.Text}
Street Address: {txtStreetAddressCart.Text}
County: {cbCountyCart.SelectedItem.ToString()}

Payment on Delivery"
                            MessageBox.Show(deliveryMessage, "Delivery Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ElseIf cbPaymentOption.SelectedItem = "Card" Then
                            If ValidateCardNumber(txtCardNumber.Text) Then
                                Dim deliveryMessage As String = $"Your order will be delivered to:
City: {txtCityCart.Text}
Street Address: {txtStreetAddressCart.Text}
County: {cbCountyCart.SelectedItem.ToString()}

Payment on Delivery"
                                MessageBox.Show(deliveryMessage, "Delivery Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("Invalid card number. Please enter 11 digits.", "Invalid Card Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return
                            End If
                        Else
                            If ValidateMpesaConfirmationCode(txtConfirmMpesaCode.Text) Then
                                Dim deliveryMessage As String = $"Your order will be delivered to:
City: {txtCityCart.Text}
Street Address: {txtStreetAddressCart.Text}
County: {cbCountyCart.SelectedItem.ToString()}

Payment on Delivery"
                                MessageBox.Show(deliveryMessage, "Delivery Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("Invalid M-Pesa confirmation code. Please enter 10 uppercase letters/digits.", "Invalid M-Pesa Confirmation Code", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return
                            End If

                        End If
                    Else
                        MessageBox.Show("Invalid phone number. Please enter a valid Kenyan phone number starting with +254 and followed by exactly 9 digits.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End If


            End If
        End If
        For Each row As DataGridViewRow In dgvCart.Rows
            Dim itemid As Integer = Convert.ToInt32(row.Cells("itemid").Value)
            Dim quantity As Integer = Convert.ToInt32(row.Cells("quantity").Value)
            DeductItemsFromInventory(itemid, quantity)
        Next
    End Sub

    Private Function ValidatePhoneNumber(phoneNumber As String) As Boolean
        Dim pattern As String = "^\+254\d{9}$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(phoneNumber)
    End Function

    Private Sub DeductItemsFromInventory(ByVal itemid As Integer, ByVal quantity As Integer)
        conn = New SqlConnection()
        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & dbPath & ";Integrated Security=True;Connect Timeout=30"
        Try
            conn.Open()
            Dim query As String = "UPDATE inventory SET quantity = quantity - @quantity WHERE itemid = @itemid"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@quantity", quantity)
            cmd.Parameters.AddWithValue("@itemid", itemid)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Failed to deduct stock from inventory for item ID " & itemid & ": " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub dgvCart_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCart.CellClick, dgvCart.CellDoubleClick, dgvCart.CellContentDoubleClick, dgvCart.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = dgvCart.Rows(e.RowIndex)
            itemid = row.Cells("itemid").Value.ToString
        End If
    End Sub
End Class