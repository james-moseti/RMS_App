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
        Me.picMaximize = New System.Windows.Forms.PictureBox()
        Me.picMinimize = New System.Windows.Forms.PictureBox()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.weFoods = New System.Windows.Forms.Label()
        Me.logoPictureBox = New System.Windows.Forms.PictureBox()
        Me.btnAboutUs = New System.Windows.Forms.Button()
        Me.btnMyCart = New System.Windows.Forms.Button()
        Me.btnDrinks = New System.Windows.Forms.Button()
        Me.pnlOnButtonPosition = New System.Windows.Forms.Panel()
        Me.btnFoods = New System.Windows.Forms.Button()
        Me.pnlTopSide = New System.Windows.Forms.Panel()
        Me.pnlLeftSide.SuspendLayout()
        CType(Me.picMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopSide.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLeftSide
        '
        Me.pnlLeftSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlLeftSide.Controls.Add(Me.weFoods)
        Me.pnlLeftSide.Controls.Add(Me.logoPictureBox)
        Me.pnlLeftSide.Controls.Add(Me.btnAboutUs)
        Me.pnlLeftSide.Controls.Add(Me.btnMyCart)
        Me.pnlLeftSide.Controls.Add(Me.btnDrinks)
        Me.pnlLeftSide.Controls.Add(Me.pnlOnButtonPosition)
        Me.pnlLeftSide.Controls.Add(Me.btnFoods)
        Me.pnlLeftSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeftSide.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeftSide.Name = "pnlLeftSide"
        Me.pnlLeftSide.Size = New System.Drawing.Size(285, 582)
        Me.pnlLeftSide.TabIndex = 0
        '
        'picMaximize
        '
        Me.picMaximize.BackgroundImage = Global.RestaurantManagementSystem.My.Resources.Resources.btnMaximize
        Me.picMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMaximize.Location = New System.Drawing.Point(790, 3)
        Me.picMaximize.Name = "picMaximize"
        Me.picMaximize.Size = New System.Drawing.Size(20, 20)
        Me.picMaximize.TabIndex = 10
        Me.picMaximize.TabStop = False
        '
        'picMinimize
        '
        Me.picMinimize.BackgroundImage = Global.RestaurantManagementSystem.My.Resources.Resources.btnMinimize
        Me.picMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMinimize.Location = New System.Drawing.Point(764, 3)
        Me.picMinimize.Name = "picMinimize"
        Me.picMinimize.Size = New System.Drawing.Size(20, 20)
        Me.picMinimize.TabIndex = 9
        Me.picMinimize.TabStop = False
        '
        'picClose
        '
        Me.picClose.BackgroundImage = Global.RestaurantManagementSystem.My.Resources.Resources.btnClose
        Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picClose.Location = New System.Drawing.Point(816, 3)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(20, 20)
        Me.picClose.TabIndex = 2
        Me.picClose.TabStop = False
        '
        'weFoods
        '
        Me.weFoods.AutoSize = True
        Me.weFoods.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.weFoods.ForeColor = System.Drawing.SystemColors.Control
        Me.weFoods.Location = New System.Drawing.Point(96, 19)
        Me.weFoods.Name = "weFoods"
        Me.weFoods.Size = New System.Drawing.Size(147, 41)
        Me.weFoods.TabIndex = 2
        Me.weFoods.Text = "WeFoods"
        '
        'logoPictureBox
        '
        Me.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.logoPictureBox.Image = Global.RestaurantManagementSystem.My.Resources.Resources.logoRestaurant
        Me.logoPictureBox.Location = New System.Drawing.Point(20, 12)
        Me.logoPictureBox.Name = "logoPictureBox"
        Me.logoPictureBox.Size = New System.Drawing.Size(60, 56)
        Me.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.logoPictureBox.TabIndex = 2
        Me.logoPictureBox.TabStop = False
        '
        'btnAboutUs
        '
        Me.btnAboutUs.FlatAppearance.BorderSize = 0
        Me.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAboutUs.Font = New System.Drawing.Font("FiraCode Nerd Font Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAboutUs.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAboutUs.Image = Global.RestaurantManagementSystem.My.Resources.Resources.btnAboutUs
        Me.btnAboutUs.Location = New System.Drawing.Point(0, 320)
        Me.btnAboutUs.Name = "btnAboutUs"
        Me.btnAboutUs.Size = New System.Drawing.Size(285, 54)
        Me.btnAboutUs.TabIndex = 8
        Me.btnAboutUs.Text = "  About Us"
        Me.btnAboutUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAboutUs.UseVisualStyleBackColor = True
        '
        'btnMyCart
        '
        Me.btnMyCart.FlatAppearance.BorderSize = 0
        Me.btnMyCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyCart.Font = New System.Drawing.Font("FiraCode Nerd Font Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyCart.ForeColor = System.Drawing.SystemColors.Control
        Me.btnMyCart.Image = Global.RestaurantManagementSystem.My.Resources.Resources.picCart
        Me.btnMyCart.Location = New System.Drawing.Point(0, 247)
        Me.btnMyCart.Name = "btnMyCart"
        Me.btnMyCart.Size = New System.Drawing.Size(285, 54)
        Me.btnMyCart.TabIndex = 6
        Me.btnMyCart.Text = "  My Cart"
        Me.btnMyCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMyCart.UseVisualStyleBackColor = True
        '
        'btnDrinks
        '
        Me.btnDrinks.FlatAppearance.BorderSize = 0
        Me.btnDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDrinks.Font = New System.Drawing.Font("FiraCode Nerd Font Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrinks.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDrinks.Image = Global.RestaurantManagementSystem.My.Resources.Resources.btnDrinks
        Me.btnDrinks.Location = New System.Drawing.Point(0, 174)
        Me.btnDrinks.Name = "btnDrinks"
        Me.btnDrinks.Size = New System.Drawing.Size(285, 54)
        Me.btnDrinks.TabIndex = 4
        Me.btnDrinks.Text = "   Drinks"
        Me.btnDrinks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDrinks.UseVisualStyleBackColor = True
        '
        'pnlOnButtonPosition
        '
        Me.pnlOnButtonPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.pnlOnButtonPosition.Location = New System.Drawing.Point(-1, 101)
        Me.pnlOnButtonPosition.Name = "pnlOnButtonPosition"
        Me.pnlOnButtonPosition.Size = New System.Drawing.Size(10, 54)
        Me.pnlOnButtonPosition.TabIndex = 2
        '
        'btnFoods
        '
        Me.btnFoods.FlatAppearance.BorderSize = 0
        Me.btnFoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoods.Font = New System.Drawing.Font("FiraCode Nerd Font Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoods.ForeColor = System.Drawing.SystemColors.Control
        Me.btnFoods.Image = Global.RestaurantManagementSystem.My.Resources.Resources.btnFoods
        Me.btnFoods.Location = New System.Drawing.Point(0, 101)
        Me.btnFoods.Name = "btnFoods"
        Me.btnFoods.Size = New System.Drawing.Size(285, 54)
        Me.btnFoods.TabIndex = 2
        Me.btnFoods.Text = "   Foods"
        Me.btnFoods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFoods.UseVisualStyleBackColor = True
        '
        'pnlTopSide
        '
        Me.pnlTopSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.pnlTopSide.Controls.Add(Me.picClose)
        Me.pnlTopSide.Controls.Add(Me.picMinimize)
        Me.pnlTopSide.Controls.Add(Me.picMaximize)
        Me.pnlTopSide.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopSide.Location = New System.Drawing.Point(285, 0)
        Me.pnlTopSide.Name = "pnlTopSide"
        Me.pnlTopSide.Size = New System.Drawing.Size(848, 71)
        Me.pnlTopSide.TabIndex = 1
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 582)
        Me.Controls.Add(Me.pnlTopSide)
        Me.Controls.Add(Me.pnlLeftSide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.pnlLeftSide.ResumeLayout(False)
        Me.pnlLeftSide.PerformLayout()
        CType(Me.picMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopSide.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLeftSide As Panel
    Friend WithEvents pnlTopSide As Panel
    Friend WithEvents btnFoods As Button
    Friend WithEvents pnlOnButtonPosition As Panel
    Friend WithEvents btnAboutUs As Button
    Friend WithEvents btnMyCart As Button
    Friend WithEvents btnDrinks As Button
    Friend WithEvents logoPictureBox As PictureBox
    Friend WithEvents weFoods As Label
    Friend WithEvents picClose As PictureBox
    Friend WithEvents picMaximize As PictureBox
    Friend WithEvents picMinimize As PictureBox
End Class
