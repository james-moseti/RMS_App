Public Class Dashboard
    Private Sub logoPictureBox_Click(sender As Object, e As EventArgs) Handles logoPictureBox.Click
        logoPictureBox.BorderStyle = BorderStyle.None
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlfood.Visible = True
        pnldrinks.Visible = False
        pnlcart.Visible = False
        pnlabout.Visible = False

    End Sub

    Private Sub btnFoods_Click(sender As Object, e As EventArgs) Handles btnFoods.Click
<<<<<<< HEAD
        pnlOnButtonPosition.Height = btnFoods.Height
        pnlOnButtonPosition.Top = btnFoods.Top
        pnlFoods.Visible = True
        pnlDrinks.Visible = False
=======
        pnlfood.Height = btnFoods.Height
        pnlfood.Top = btnFoods.Top
        pnlfood.Visible = True
        pnldrinks.Visible = False
        pnlcart.Visible = False
        pnlabout.Visible = False
        'pnlFoods.Visible = True
        'pnlDrinks.Visible = False
>>>>>>> 2212dfbf1755d5570f628be0f730dd90b7798aa6
        'pnlMyCart.Visible = False
        'pnlAboutUs.Visible = False
    End Sub

    Private Sub btnDrinks_Click(sender As Object, e As EventArgs) Handles btnDrinks.Click
<<<<<<< HEAD
        pnlOnButtonPosition.Height = btnDrinks.Height
        pnlOnButtonPosition.Top = btnDrinks.Top
        pnlFoods.Visible = False
        pnlDrinks.Visible = True
=======
        pnlfood.Height = btnDrinks.Height
        pnlfood.Top = btnDrinks.Top
        pnlfood.Visible = False
        pnldrinks.Visible = True
        pnlcart.Visible = False
        pnlabout.Visible = False
        'pnlFoods.Visible = False
        'pnlDrinks.Visible = True
>>>>>>> 2212dfbf1755d5570f628be0f730dd90b7798aa6
        'pnlMyCart.Visible = False
        'pnlAboutUs.Visible = False
    End Sub

    Private Sub btnMyCart_Click(sender As Object, e As EventArgs) Handles btnMyCart.Click
<<<<<<< HEAD
        pnlOnButtonPosition.Height = btnMyCart.Height
        pnlOnButtonPosition.Top = btnMyCart.Top
        pnlFoods.Visible = False
        pnlDrinks.Visible = False
=======
        pnlfood.Height = btnMyCart.Height
        pnlfood.Top = btnMyCart.Top
        pnlfood.Visible = False
        pnldrinks.Visible = False
        pnlcart.Visible = True
        pnlabout.Visible = False
        'pnlFoods.Visible = False
        'pnlDrinks.Visible = False
>>>>>>> 2212dfbf1755d5570f628be0f730dd90b7798aa6
        'pnlMyCart.Visible = True
        'pnlAboutUs.Visible = False
    End Sub

    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
<<<<<<< HEAD
        pnlOnButtonPosition.Height = btnAboutUs.Height
        pnlOnButtonPosition.Top = btnAboutUs.Top
        pnlFoods.Visible = False
        pnlDrinks.Visible = False
=======
        pnlfood.Height = btnAboutUs.Height
        pnlfood.Top = btnAboutUs.Top
        pnlfood.Visible = False
        pnldrinks.Visible = False
        pnlcart.Visible = False
        pnlabout.Visible = True
        'pnlFoods.Visible = False
        'pnlDrinks.Visible = False
>>>>>>> 2212dfbf1755d5570f628be0f730dd90b7798aa6
        'pnlMyCart.Visible = False
        'pnlAboutUs.Visible = True
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCola.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCola.Click

    End Sub
End Class