<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlLeftSide = New System.Windows.Forms.Panel()
        Me.weFoods = New System.Windows.Forms.Label()
        Me.logoPictureBox = New System.Windows.Forms.PictureBox()
        Me.btnAboutUs = New System.Windows.Forms.Button()
        Me.btnMyCart = New System.Windows.Forms.Button()
        Me.btnDrinks = New System.Windows.Forms.Button()
        Me.pnlfood = New System.Windows.Forms.Panel()
        Me.btnFoods = New System.Windows.Forms.Button()
        Me.picMaximize = New System.Windows.Forms.PictureBox()
        Me.picMinimize = New System.Windows.Forms.PictureBox()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.pnlTopSide = New System.Windows.Forms.Panel()
        Me.pnlabout = New System.Windows.Forms.Panel()
        Me.pnlcart = New System.Windows.Forms.Panel()
        Me.pnldrinks = New System.Windows.Forms.Panel()
        Me.pnlLeftSide.SuspendLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopSide.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLeftSide
        '
        Me.pnlLeftSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlLeftSide.Controls.Add(Me.pnlabout)
        Me.pnlLeftSide.Controls.Add(Me.pnlcart)
        Me.pnlLeftSide.Controls.Add(Me.pnldrinks)
        Me.pnlLeftSide.Controls.Add(Me.weFoods)
        Me.pnlLeftSide.Controls.Add(Me.logoPictureBox)
        Me.pnlLeftSide.Controls.Add(Me.btnAboutUs)
        Me.pnlLeftSide.Controls.Add(Me.btnMyCart)
        Me.pnlLeftSide.Controls.Add(Me.btnDrinks)
        Me.pnlLeftSide.Controls.Add(Me.pnlfood)
        Me.pnlLeftSide.Controls.Add(Me.btnFoods)
        Me.pnlLeftSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeftSide.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeftSide.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlLeftSide.Name = "pnlLeftSide"
        Me.pnlLeftSide.Size = New System.Drawing.Size(321, 728)
        Me.pnlLeftSide.TabIndex = 0
        '
        'weFoods
        '
        Me.weFoods.AutoSize = True
        Me.weFoods.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.weFoods.ForeColor = System.Drawing.SystemColors.Control
        Me.weFoods.Location = New System.Drawing.Point(108, 24)
        Me.weFoods.Name = "weFoods"
        Me.weFoods.Size = New System.Drawing.Size(175, 48)
        Me.weFoods.TabIndex = 2
        Me.weFoods.Text = "WeFoods"
        '
        'logoPictureBox
        '
        Me.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.logoPictureBox.Image = Global.RestaurantManagementSystem.My.Resources.Resources.logoRestaurant
        Me.logoPictureBox.Location = New System.Drawing.Point(22, 15)
        Me.logoPictureBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.logoPictureBox.Name = "logoPictureBox"
        Me.logoPictureBox.Size = New System.Drawing.Size(68, 70)
        Me.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.logoPictureBox.TabIndex = 2
        Me.logoPictureBox.TabStop = False
        '
        'btnAboutUs
        '
        Me.btnAboutUs.FlatAppearance.BorderSize = 0
        Me.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAboutUs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAboutUs.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAboutUs.Image = Global.RestaurantManagementSystem.My.Resources.Resources.btnAboutUs
        Me.btnAboutUs.Location = New System.Drawing.Point(0, 400)
        Me.btnAboutUs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAboutUs.Name = "btnAboutUs"
        Me.btnAboutUs.Size = New System.Drawing.Size(321, 68)
        Me.btnAboutUs.TabIndex = 8
        Me.btnAboutUs.Text = "  About Us"
        Me.btnAboutUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAboutUs.UseVisualStyleBackColor = True
        '
        'btnMyCart
        '
        Me.btnMyCart.FlatAppearance.BorderSize = 0
        Me.btnMyCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyCart.ForeColor = System.Drawing.SystemColors.Control
        Me.btnMyCart.Image = Global.RestaurantManagementSystem.My.Resources.Resources.picCart
        Me.btnMyCart.Location = New System.Drawing.Point(0, 309)
        Me.btnMyCart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMyCart.Name = "btnMyCart"
        Me.btnMyCart.Size = New System.Drawing.Size(321, 68)
        Me.btnMyCart.TabIndex = 6
        Me.btnMyCart.Text = "  My Cart"
        Me.btnMyCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMyCart.UseVisualStyleBackColor = True
        '
        'btnDrinks
        '
        Me.btnDrinks.FlatAppearance.BorderSize = 0
        Me.btnDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrinks.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDrinks.Image = Global.RestaurantManagementSystem.My.Resources.Resources.btnDrinks
        Me.btnDrinks.Location = New System.Drawing.Point(0, 218)
        Me.btnDrinks.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDrinks.Name = "btnDrinks"
        Me.btnDrinks.Size = New System.Drawing.Size(321, 68)
        Me.btnDrinks.TabIndex = 4
        Me.btnDrinks.Text = "   Drinks"
        Me.btnDrinks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDrinks.UseVisualStyleBackColor = True
        '
        'pnlfood
        '
        Me.pnlfood.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.pnlfood.Location = New System.Drawing.Point(-1, 126)
        Me.pnlfood.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlfood.Name = "pnlfood"
        Me.pnlfood.Size = New System.Drawing.Size(11, 68)
        Me.pnlfood.TabIndex = 2
        '
        'btnFoods
        '
        Me.btnFoods.FlatAppearance.BorderSize = 0
        Me.btnFoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoods.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoods.ForeColor = System.Drawing.SystemColors.Control
        Me.btnFoods.Image = Global.RestaurantManagementSystem.My.Resources.Resources.btnFoods
        Me.btnFoods.Location = New System.Drawing.Point(0, 126)
        Me.btnFoods.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFoods.Name = "btnFoods"
        Me.btnFoods.Size = New System.Drawing.Size(321, 68)
        Me.btnFoods.TabIndex = 2
        Me.btnFoods.Text = "   Foods"
        Me.btnFoods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFoods.UseVisualStyleBackColor = True
        '
        'picMaximize
        '
        Me.picMaximize.BackgroundImage = Global.RestaurantManagementSystem.My.Resources.Resources.btnMaximize
        Me.picMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMaximize.Location = New System.Drawing.Point(889, 4)
        Me.picMaximize.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picMaximize.Name = "picMaximize"
        Me.picMaximize.Size = New System.Drawing.Size(22, 25)
        Me.picMaximize.TabIndex = 10
        Me.picMaximize.TabStop = False
        '
        'picMinimize
        '
        Me.picMinimize.BackgroundImage = Global.RestaurantManagementSystem.My.Resources.Resources.btnMinimize
        Me.picMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMinimize.Location = New System.Drawing.Point(860, 4)
        Me.picMinimize.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picMinimize.Name = "picMinimize"
        Me.picMinimize.Size = New System.Drawing.Size(22, 25)
        Me.picMinimize.TabIndex = 9
        Me.picMinimize.TabStop = False
        '
        'picClose
        '
        Me.picClose.BackgroundImage = Global.RestaurantManagementSystem.My.Resources.Resources.btnClose
        Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picClose.Location = New System.Drawing.Point(918, 4)
        Me.picClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(22, 25)
        Me.picClose.TabIndex = 2
        Me.picClose.TabStop = False
        '
        'pnlTopSide
        '
        Me.pnlTopSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.pnlTopSide.Controls.Add(Me.picClose)
        Me.pnlTopSide.Controls.Add(Me.picMinimize)
        Me.pnlTopSide.Controls.Add(Me.picMaximize)
        Me.pnlTopSide.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopSide.Location = New System.Drawing.Point(321, 0)
        Me.pnlTopSide.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlTopSide.Name = "pnlTopSide"
        Me.pnlTopSide.Size = New System.Drawing.Size(954, 89)
        Me.pnlTopSide.TabIndex = 1
        '
        'pnlabout
        '
        Me.pnlabout.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.pnlabout.Location = New System.Drawing.Point(0, 400)
        Me.pnlabout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlabout.Name = "pnlabout"
        Me.pnlabout.Size = New System.Drawing.Size(11, 68)
        Me.pnlabout.TabIndex = 3
        '
        'pnlcart
        '
        Me.pnlcart.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.pnlcart.Location = New System.Drawing.Point(3, 309)
        Me.pnlcart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlcart.Name = "pnlcart"
        Me.pnlcart.Size = New System.Drawing.Size(11, 68)
        Me.pnlcart.TabIndex = 3
        '
        'pnldrinks
        '
        Me.pnldrinks.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.pnldrinks.Location = New System.Drawing.Point(3, 218)
        Me.pnldrinks.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnldrinks.Name = "pnldrinks"
        Me.pnldrinks.Size = New System.Drawing.Size(11, 68)
        Me.pnldrinks.TabIndex = 3
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1275, 728)
        Me.Controls.Add(Me.pnlTopSide)
        Me.Controls.Add(Me.pnlLeftSide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.pnlLeftSide.ResumeLayout(False)
        Me.pnlLeftSide.PerformLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopSide.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLeftSide As Panel
    Friend WithEvents pnlTopSide As Panel
    Friend WithEvents btnFoods As Button
    Friend WithEvents pnlfood As Panel
    Friend WithEvents btnAboutUs As Button
    Friend WithEvents btnMyCart As Button
    Friend WithEvents btnDrinks As Button
    Friend WithEvents logoPictureBox As PictureBox
    Friend WithEvents weFoods As Label
    Friend WithEvents picClose As PictureBox
    Friend WithEvents picMaximize As PictureBox
    Friend WithEvents picMinimize As PictureBox
    Friend WithEvents pnlabout As Panel
    Friend WithEvents pnlcart As Panel
    Friend WithEvents pnldrinks As Panel
End Class
