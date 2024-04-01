<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminPage
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
        Me.pnlTopSide = New System.Windows.Forms.Panel()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.picMinimize = New System.Windows.Forms.PictureBox()
        Me.picMaximize = New System.Windows.Forms.PictureBox()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.tbQuantity = New System.Windows.Forms.TextBox()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.pnlInventory = New System.Windows.Forms.Panel()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.pnlOnButtonInventory = New System.Windows.Forms.Panel()
        Me.pnlOnButtonUsers = New System.Windows.Forms.Panel()
        Me.pnlUsers = New System.Windows.Forms.Panel()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.pnlLeftSide.SuspendLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopSide.SuspendLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInventory.SuspendLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUsers.SuspendLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLeftSide
        '
        Me.pnlLeftSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlLeftSide.Controls.Add(Me.pnlOnButtonUsers)
        Me.pnlLeftSide.Controls.Add(Me.pnlOnButtonInventory)
        Me.pnlLeftSide.Controls.Add(Me.btnUsers)
        Me.pnlLeftSide.Controls.Add(Me.btnInventory)
        Me.pnlLeftSide.Controls.Add(Me.weFoods)
        Me.pnlLeftSide.Controls.Add(Me.logoPictureBox)
        Me.pnlLeftSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeftSide.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeftSide.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.pnlLeftSide.Name = "pnlLeftSide"
        Me.pnlLeftSide.Size = New System.Drawing.Size(214, 473)
        Me.pnlLeftSide.TabIndex = 1
        '
        'weFoods
        '
        Me.weFoods.AutoSize = True
        Me.weFoods.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.weFoods.ForeColor = System.Drawing.SystemColors.Control
        Me.weFoods.Location = New System.Drawing.Point(72, 16)
        Me.weFoods.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.weFoods.Name = "weFoods"
        Me.weFoods.Size = New System.Drawing.Size(118, 32)
        Me.weFoods.TabIndex = 2
        Me.weFoods.Text = "WeFoods"
        '
        'logoPictureBox
        '
        Me.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.logoPictureBox.Image = Global.RestaurantManagementSystem.My.Resources.Resources.logoRestaurant
        Me.logoPictureBox.Location = New System.Drawing.Point(15, 10)
        Me.logoPictureBox.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.logoPictureBox.Name = "logoPictureBox"
        Me.logoPictureBox.Size = New System.Drawing.Size(45, 46)
        Me.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.logoPictureBox.TabIndex = 2
        Me.logoPictureBox.TabStop = False
        '
        'pnlTopSide
        '
        Me.pnlTopSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.pnlTopSide.Controls.Add(Me.picClose)
        Me.pnlTopSide.Controls.Add(Me.picMinimize)
        Me.pnlTopSide.Controls.Add(Me.picMaximize)
        Me.pnlTopSide.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopSide.Location = New System.Drawing.Point(214, 0)
        Me.pnlTopSide.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTopSide.Name = "pnlTopSide"
        Me.pnlTopSide.Size = New System.Drawing.Size(636, 58)
        Me.pnlTopSide.TabIndex = 2
        '
        'picClose
        '
        Me.picClose.BackgroundImage = Global.RestaurantManagementSystem.My.Resources.Resources.btnClose
        Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picClose.Location = New System.Drawing.Point(612, 2)
        Me.picClose.Margin = New System.Windows.Forms.Padding(2)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(15, 16)
        Me.picClose.TabIndex = 2
        Me.picClose.TabStop = False
        '
        'picMinimize
        '
        Me.picMinimize.BackgroundImage = Global.RestaurantManagementSystem.My.Resources.Resources.btnMinimize
        Me.picMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMinimize.Location = New System.Drawing.Point(573, 2)
        Me.picMinimize.Margin = New System.Windows.Forms.Padding(2)
        Me.picMinimize.Name = "picMinimize"
        Me.picMinimize.Size = New System.Drawing.Size(15, 16)
        Me.picMinimize.TabIndex = 9
        Me.picMinimize.TabStop = False
        '
        'picMaximize
        '
        Me.picMaximize.BackgroundImage = Global.RestaurantManagementSystem.My.Resources.Resources.btnMaximize
        Me.picMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMaximize.Location = New System.Drawing.Point(592, 2)
        Me.picMaximize.Margin = New System.Windows.Forms.Padding(2)
        Me.picMaximize.Name = "picMaximize"
        Me.picMaximize.Size = New System.Drawing.Size(15, 16)
        Me.picMaximize.TabIndex = 10
        Me.picMaximize.TabStop = False
        '
        'btnInventory
        '
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.SystemColors.Control
        Me.btnInventory.Image = Global.RestaurantManagementSystem.My.Resources.Resources.btnFoods
        Me.btnInventory.Location = New System.Drawing.Point(-2, 101)
        Me.btnInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(214, 44)
        Me.btnInventory.TabIndex = 3
        Me.btnInventory.Text = "   Inventory"
        Me.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.FlatAppearance.BorderSize = 0
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUsers.Image = Global.RestaurantManagementSystem.My.Resources.Resources.btnAboutUs
        Me.btnUsers.Location = New System.Drawing.Point(-2, 197)
        Me.btnUsers.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(214, 44)
        Me.btnUsers.TabIndex = 9
        Me.btnUsers.Text = "  Users"
        Me.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'tbPrice
        '
        Me.tbPrice.Location = New System.Drawing.Point(208, 55)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(100, 20)
        Me.tbPrice.TabIndex = 3
        '
        'tbQuantity
        '
        Me.tbQuantity.Location = New System.Drawing.Point(398, 52)
        Me.tbQuantity.Name = "tbQuantity"
        Me.tbQuantity.Size = New System.Drawing.Size(100, 20)
        Me.tbQuantity.TabIndex = 4
        '
        'tbSearch
        '
        Me.tbSearch.Location = New System.Drawing.Point(504, 19)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(100, 20)
        Me.tbSearch.TabIndex = 5
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(44, 55)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(100, 20)
        Me.tbName.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(171, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(346, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(457, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Search"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Lime
        Me.btnAdd.Location = New System.Drawing.Point(69, 94)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Orange
        Me.btnUpdate.Location = New System.Drawing.Point(233, 94)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(423, 94)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'pnlInventory
        '
        Me.pnlInventory.Controls.Add(Me.dgvInventory)
        Me.pnlInventory.Controls.Add(Me.btnDelete)
        Me.pnlInventory.Controls.Add(Me.Label1)
        Me.pnlInventory.Controls.Add(Me.tbName)
        Me.pnlInventory.Controls.Add(Me.btnUpdate)
        Me.pnlInventory.Controls.Add(Me.btnAdd)
        Me.pnlInventory.Controls.Add(Me.Label4)
        Me.pnlInventory.Controls.Add(Me.Label2)
        Me.pnlInventory.Controls.Add(Me.tbPrice)
        Me.pnlInventory.Controls.Add(Me.Label3)
        Me.pnlInventory.Controls.Add(Me.tbQuantity)
        Me.pnlInventory.Controls.Add(Me.tbSearch)
        Me.pnlInventory.Location = New System.Drawing.Point(217, 63)
        Me.pnlInventory.Name = "pnlInventory"
        Me.pnlInventory.Size = New System.Drawing.Size(624, 398)
        Me.pnlInventory.TabIndex = 3
        '
        'dgvInventory
        '
        Me.dgvInventory.AllowUserToAddRows = False
        Me.dgvInventory.AllowUserToDeleteRows = False
        Me.dgvInventory.AllowUserToResizeColumns = False
        Me.dgvInventory.AllowUserToResizeRows = False
        Me.dgvInventory.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Location = New System.Drawing.Point(9, 134)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvInventory.Size = New System.Drawing.Size(615, 251)
        Me.dgvInventory.TabIndex = 14
        '
        'pnlOnButtonInventory
        '
        Me.pnlOnButtonInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.pnlOnButtonInventory.Location = New System.Drawing.Point(0, 101)
        Me.pnlOnButtonInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlOnButtonInventory.Name = "pnlOnButtonInventory"
        Me.pnlOnButtonInventory.Size = New System.Drawing.Size(8, 44)
        Me.pnlOnButtonInventory.TabIndex = 10
        '
        'pnlOnButtonUsers
        '
        Me.pnlOnButtonUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.pnlOnButtonUsers.Location = New System.Drawing.Point(0, 197)
        Me.pnlOnButtonUsers.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlOnButtonUsers.Name = "pnlOnButtonUsers"
        Me.pnlOnButtonUsers.Size = New System.Drawing.Size(8, 44)
        Me.pnlOnButtonUsers.TabIndex = 3
        '
        'pnlUsers
        '
        Me.pnlUsers.Controls.Add(Me.dgvUsers)
        Me.pnlUsers.Location = New System.Drawing.Point(217, 63)
        Me.pnlUsers.Name = "pnlUsers"
        Me.pnlUsers.Size = New System.Drawing.Size(624, 398)
        Me.pnlUsers.TabIndex = 15
        '
        'dgvUsers
        '
        Me.dgvUsers.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(59, 38)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.Size = New System.Drawing.Size(468, 335)
        Me.dgvUsers.TabIndex = 0
        '
        'adminPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(850, 473)
        Me.Controls.Add(Me.pnlUsers)
        Me.Controls.Add(Me.pnlInventory)
        Me.Controls.Add(Me.pnlTopSide)
        Me.Controls.Add(Me.pnlLeftSide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "adminPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminPage"
        Me.pnlLeftSide.ResumeLayout(False)
        Me.pnlLeftSide.PerformLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopSide.ResumeLayout(False)
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInventory.ResumeLayout(False)
        Me.pnlInventory.PerformLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUsers.ResumeLayout(False)
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLeftSide As Panel
    Friend WithEvents weFoods As Label
    Friend WithEvents logoPictureBox As PictureBox
    Friend WithEvents pnlTopSide As Panel
    Friend WithEvents picClose As PictureBox
    Friend WithEvents picMinimize As PictureBox
    Friend WithEvents picMaximize As PictureBox
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnUsers As Button
    Friend WithEvents tbPrice As TextBox
    Friend WithEvents tbQuantity As TextBox
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents pnlInventory As Panel
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents pnlOnButtonUsers As Panel
    Friend WithEvents pnlOnButtonInventory As Panel
    Friend WithEvents pnlUsers As Panel
    Friend WithEvents dgvUsers As DataGridView
End Class
