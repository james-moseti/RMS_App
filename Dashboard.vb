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
End Class