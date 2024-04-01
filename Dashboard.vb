Public Class Dashboard

    Private Sub logoPictureBox_Click(sender As Object, e As EventArgs) Handles logoPictureBox.Click
        logoPictureBox.BorderStyle = BorderStyle.None
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlFoods.Visible = True
        pnlDrinks.Visible = False
        'pnlMyCart.Visible = False
        'pnlAboutUs.Visible = False

        'Orange panel to the left
        pnlOnButtonFood.Visible = True
        pnlOnButtonDrinks.Visible = False
        pnlOnButtonCart.Visible = False
        pnlOnButtonAbout.Visible = False

    End Sub

    Private Sub btnFoods_Click(sender As Object, e As EventArgs) Handles btnFoods.Click
        pnlFoods.Visible = True
        pnlDrinks.Visible = False
        'pnlMyCart.Visible = False
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
        'pnlMyCart.Visible = False
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
        'pnlMyCart.Visible = True
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
        'pnlMyCart.Visible = False
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

    Private Sub btnAddOther_Click(sender As Object, e As EventArgs) Handles btnAddOther.Click
        num = Integer.Parse(txtOther.Text)
        Dim num2 As Integer = increment(num)
        txtOther.Text = num2.ToString
    End Sub

    Private Sub btnSubOther_Click(sender As Object, e As EventArgs) Handles btnSubOther.Click
        num = Integer.Parse(txtOther.Text)
        Dim num2 As Integer = increment(num)
        txtOther.Text = num2.ToString
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
        Dim num2 As Integer = increment(num)
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

    Private Sub btnAddOtherDrink_Click(sender As Object, e As EventArgs) Handles btnAddOtherDrink.Click
        num = Integer.Parse(txtOtherDrink.Text)
        Dim num2 As Integer = increment(num)
        txtOtherDrink.Text = num2.ToString
    End Sub

    Private Sub btnSubOtherDrink_Click(sender As Object, e As EventArgs) Handles btnSubOtherDrink.Click
        num = Integer.Parse(txtOtherDrink.Text)
        Dim num2 As Integer = decrement(num)
        txtOtherDrink.Text = num2.ToString
    End Sub
End Class