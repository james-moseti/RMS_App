<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminPage))
        Me.pnlLeftSide = New System.Windows.Forms.Panel()
        Me.pnlOnButtonUsers = New System.Windows.Forms.Panel()
        Me.pnlOnButtonInventory = New System.Windows.Forms.Panel()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.weFoods = New System.Windows.Forms.Label()
        Me.logoPictureBox = New System.Windows.Forms.PictureBox()
        Me.pnlTopSide = New System.Windows.Forms.Panel()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.picMinimize = New System.Windows.Forms.PictureBox()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.tbQuantity = New System.Windows.Forms.TextBox()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddStock = New System.Windows.Forms.Button()
        Me.btnUpdateStock = New System.Windows.Forms.Button()
        Me.btnDeleteStock = New System.Windows.Forms.Button()
        Me.pnlInventory = New System.Windows.Forms.Panel()
        Me.gbStockDetails = New System.Windows.Forms.GroupBox()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.gbCommand = New System.Windows.Forms.GroupBox()
        Me.gbStockEntry = New System.Windows.Forms.GroupBox()
        Me.pnlUsers = New System.Windows.Forms.Panel()
        Me.gbUsersList = New System.Windows.Forms.GroupBox()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.lblSearchByName = New System.Windows.Forms.Label()
        Me.tbSearchByNameAP = New System.Windows.Forms.TextBox()
        Me.gbAddUser = New System.Windows.Forms.GroupBox()
        Me.lblFirstNameAP = New System.Windows.Forms.Label()
        Me.tbFirstNameAP = New System.Windows.Forms.TextBox()
        Me.lblLastNameAP = New System.Windows.Forms.Label()
        Me.tbLastNameAP = New System.Windows.Forms.TextBox()
        Me.lblEmailAP = New System.Windows.Forms.Label()
        Me.tbUserEmailAP = New System.Windows.Forms.TextBox()
        Me.pnlLeftSide.SuspendLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopSide.SuspendLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInventory.SuspendLayout()
        Me.gbStockDetails.SuspendLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCommand.SuspendLayout()
        Me.gbStockEntry.SuspendLayout()
        Me.pnlUsers.SuspendLayout()
        Me.gbUsersList.SuspendLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.gbAddUser.SuspendLayout()
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
        Me.pnlLeftSide.Size = New System.Drawing.Size(214, 502)
        Me.pnlLeftSide.TabIndex = 1
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
        'pnlOnButtonInventory
        '
        Me.pnlOnButtonInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.pnlOnButtonInventory.Location = New System.Drawing.Point(0, 101)
        Me.pnlOnButtonInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlOnButtonInventory.Name = "pnlOnButtonInventory"
        Me.pnlOnButtonInventory.Size = New System.Drawing.Size(8, 44)
        Me.pnlOnButtonInventory.TabIndex = 10
        '
        'btnUsers
        '
        Me.btnUsers.FlatAppearance.BorderSize = 0
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUsers.Image = CType(resources.GetObject("btnUsers.Image"), System.Drawing.Image)
        Me.btnUsers.Location = New System.Drawing.Point(-2, 197)
        Me.btnUsers.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(214, 44)
        Me.btnUsers.TabIndex = 9
        Me.btnUsers.Text = "  Users"
        Me.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.SystemColors.Control
        Me.btnInventory.Image = CType(resources.GetObject("btnInventory.Image"), System.Drawing.Image)
        Me.btnInventory.Location = New System.Drawing.Point(-2, 101)
        Me.btnInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(214, 44)
        Me.btnInventory.TabIndex = 3
        Me.btnInventory.Text = "   Inventory"
        Me.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInventory.UseVisualStyleBackColor = True
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
        Me.logoPictureBox.Image = CType(resources.GetObject("logoPictureBox.Image"), System.Drawing.Image)
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
        Me.pnlTopSide.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopSide.Location = New System.Drawing.Point(214, 0)
        Me.pnlTopSide.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTopSide.Name = "pnlTopSide"
        Me.pnlTopSide.Size = New System.Drawing.Size(634, 58)
        Me.pnlTopSide.TabIndex = 2
        '
        'picClose
        '
        Me.picClose.BackgroundImage = CType(resources.GetObject("picClose.BackgroundImage"), System.Drawing.Image)
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
        Me.picMinimize.BackgroundImage = CType(resources.GetObject("picMinimize.BackgroundImage"), System.Drawing.Image)
        Me.picMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMinimize.Location = New System.Drawing.Point(592, 2)
        Me.picMinimize.Margin = New System.Windows.Forms.Padding(2)
        Me.picMinimize.Name = "picMinimize"
        Me.picMinimize.Size = New System.Drawing.Size(15, 16)
        Me.picMinimize.TabIndex = 9
        Me.picMinimize.TabStop = False
        '
        'tbPrice
        '
        Me.tbPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPrice.ForeColor = System.Drawing.Color.Black
        Me.tbPrice.Location = New System.Drawing.Point(80, 54)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(125, 23)
        Me.tbPrice.TabIndex = 3
        '
        'tbQuantity
        '
        Me.tbQuantity.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQuantity.ForeColor = System.Drawing.Color.Black
        Me.tbQuantity.Location = New System.Drawing.Point(80, 84)
        Me.tbQuantity.Name = "tbQuantity"
        Me.tbQuantity.Size = New System.Drawing.Size(125, 23)
        Me.tbQuantity.TabIndex = 4
        '
        'tbSearch
        '
        Me.tbSearch.BackColor = System.Drawing.Color.White
        Me.tbSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearch.ForeColor = System.Drawing.Color.Black
        Me.tbSearch.Location = New System.Drawing.Point(150, 24)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(134, 23)
        Me.tbSearch.TabIndex = 5
        '
        'tbName
        '
        Me.tbName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.ForeColor = System.Drawing.Color.Black
        Me.tbName.Location = New System.Drawing.Point(80, 24)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(125, 23)
        Me.tbName.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Search by name: "
        '
        'btnAddStock
        '
        Me.btnAddStock.BackColor = System.Drawing.Color.Lime
        Me.btnAddStock.FlatAppearance.BorderSize = 0
        Me.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddStock.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStock.Location = New System.Drawing.Point(30, 67)
        Me.btnAddStock.Name = "btnAddStock"
        Me.btnAddStock.Size = New System.Drawing.Size(75, 23)
        Me.btnAddStock.TabIndex = 11
        Me.btnAddStock.Text = "Add"
        Me.btnAddStock.UseVisualStyleBackColor = False
        '
        'btnUpdateStock
        '
        Me.btnUpdateStock.BackColor = System.Drawing.Color.Orange
        Me.btnUpdateStock.FlatAppearance.BorderSize = 0
        Me.btnUpdateStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateStock.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateStock.Location = New System.Drawing.Point(121, 67)
        Me.btnUpdateStock.Name = "btnUpdateStock"
        Me.btnUpdateStock.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateStock.TabIndex = 12
        Me.btnUpdateStock.Text = "Update"
        Me.btnUpdateStock.UseVisualStyleBackColor = False
        '
        'btnDeleteStock
        '
        Me.btnDeleteStock.BackColor = System.Drawing.Color.Red
        Me.btnDeleteStock.FlatAppearance.BorderSize = 0
        Me.btnDeleteStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteStock.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteStock.Location = New System.Drawing.Point(208, 65)
        Me.btnDeleteStock.Name = "btnDeleteStock"
        Me.btnDeleteStock.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteStock.TabIndex = 13
        Me.btnDeleteStock.Text = "Delete"
        Me.btnDeleteStock.UseVisualStyleBackColor = False
        '
        'pnlInventory
        '
        Me.pnlInventory.Controls.Add(Me.gbStockDetails)
        Me.pnlInventory.Controls.Add(Me.gbCommand)
        Me.pnlInventory.Controls.Add(Me.gbStockEntry)
        Me.pnlInventory.Location = New System.Drawing.Point(217, 63)
        Me.pnlInventory.Name = "pnlInventory"
        Me.pnlInventory.Size = New System.Drawing.Size(626, 437)
        Me.pnlInventory.TabIndex = 3
        '
        'gbStockDetails
        '
        Me.gbStockDetails.Controls.Add(Me.dgvInventory)
        Me.gbStockDetails.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbStockDetails.Location = New System.Drawing.Point(5, 145)
        Me.gbStockDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.gbStockDetails.Name = "gbStockDetails"
        Me.gbStockDetails.Padding = New System.Windows.Forms.Padding(2)
        Me.gbStockDetails.Size = New System.Drawing.Size(611, 283)
        Me.gbStockDetails.TabIndex = 17
        Me.gbStockDetails.TabStop = False
        Me.gbStockDetails.Text = "Stock's Details"
        '
        'dgvInventory
        '
        Me.dgvInventory.AllowUserToAddRows = False
        Me.dgvInventory.AllowUserToDeleteRows = False
        Me.dgvInventory.AllowUserToResizeColumns = False
        Me.dgvInventory.AllowUserToResizeRows = False
        Me.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInventory.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Location = New System.Drawing.Point(9, 20)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.ReadOnly = True
        Me.dgvInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvInventory.Size = New System.Drawing.Size(596, 251)
        Me.dgvInventory.TabIndex = 14
        '
        'gbCommand
        '
        Me.gbCommand.Controls.Add(Me.btnDeleteStock)
        Me.gbCommand.Controls.Add(Me.btnUpdateStock)
        Me.gbCommand.Controls.Add(Me.btnAddStock)
        Me.gbCommand.Controls.Add(Me.Label4)
        Me.gbCommand.Controls.Add(Me.tbSearch)
        Me.gbCommand.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCommand.Location = New System.Drawing.Point(302, 30)
        Me.gbCommand.Margin = New System.Windows.Forms.Padding(2)
        Me.gbCommand.Name = "gbCommand"
        Me.gbCommand.Padding = New System.Windows.Forms.Padding(2)
        Me.gbCommand.Size = New System.Drawing.Size(302, 106)
        Me.gbCommand.TabIndex = 16
        Me.gbCommand.TabStop = False
        Me.gbCommand.Text = "Command"
        '
        'gbStockEntry
        '
        Me.gbStockEntry.Controls.Add(Me.Label1)
        Me.gbStockEntry.Controls.Add(Me.tbName)
        Me.gbStockEntry.Controls.Add(Me.Label2)
        Me.gbStockEntry.Controls.Add(Me.tbPrice)
        Me.gbStockEntry.Controls.Add(Me.Label3)
        Me.gbStockEntry.Controls.Add(Me.tbQuantity)
        Me.gbStockEntry.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbStockEntry.Location = New System.Drawing.Point(13, 15)
        Me.gbStockEntry.Margin = New System.Windows.Forms.Padding(2)
        Me.gbStockEntry.Name = "gbStockEntry"
        Me.gbStockEntry.Padding = New System.Windows.Forms.Padding(2)
        Me.gbStockEntry.Size = New System.Drawing.Size(208, 122)
        Me.gbStockEntry.TabIndex = 15
        Me.gbStockEntry.TabStop = False
        Me.gbStockEntry.Text = "Stock Entry"
        '
        'pnlUsers
        '
        Me.pnlUsers.Controls.Add(Me.gbUsersList)
        Me.pnlUsers.Controls.Add(Me.GroupBox2)
        Me.pnlUsers.Controls.Add(Me.gbAddUser)
        Me.pnlUsers.Location = New System.Drawing.Point(217, 63)
        Me.pnlUsers.Name = "pnlUsers"
        Me.pnlUsers.Size = New System.Drawing.Size(624, 437)
        Me.pnlUsers.TabIndex = 15
        '
        'gbUsersList
        '
        Me.gbUsersList.Controls.Add(Me.dgvUsers)
        Me.gbUsersList.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbUsersList.Location = New System.Drawing.Point(10, 133)
        Me.gbUsersList.Margin = New System.Windows.Forms.Padding(2)
        Me.gbUsersList.Name = "gbUsersList"
        Me.gbUsersList.Padding = New System.Windows.Forms.Padding(2)
        Me.gbUsersList.Size = New System.Drawing.Size(594, 301)
        Me.gbUsersList.TabIndex = 20
        Me.gbUsersList.TabStop = False
        Me.gbUsersList.Text = "Users List"
        '
        'dgvUsers
        '
        Me.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsers.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(14, 20)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.ReadOnly = True
        Me.dgvUsers.RowHeadersWidth = 51
        Me.dgvUsers.Size = New System.Drawing.Size(572, 275)
        Me.dgvUsers.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDeleteUser)
        Me.GroupBox2.Controls.Add(Me.lblSearchByName)
        Me.GroupBox2.Controls.Add(Me.tbSearchByNameAP)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(297, 22)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(302, 106)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Command"
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.BackColor = System.Drawing.Color.Red
        Me.btnDeleteUser.FlatAppearance.BorderSize = 0
        Me.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteUser.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteUser.Location = New System.Drawing.Point(208, 65)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteUser.TabIndex = 13
        Me.btnDeleteUser.Text = "Delete"
        Me.btnDeleteUser.UseVisualStyleBackColor = False
        '
        'lblSearchByName
        '
        Me.lblSearchByName.AutoSize = True
        Me.lblSearchByName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchByName.Location = New System.Drawing.Point(28, 25)
        Me.lblSearchByName.Name = "lblSearchByName"
        Me.lblSearchByName.Size = New System.Drawing.Size(98, 15)
        Me.lblSearchByName.TabIndex = 10
        Me.lblSearchByName.Text = "Search by name: "
        '
        'tbSearchByNameAP
        '
        Me.tbSearchByNameAP.BackColor = System.Drawing.Color.White
        Me.tbSearchByNameAP.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearchByNameAP.ForeColor = System.Drawing.Color.Black
        Me.tbSearchByNameAP.Location = New System.Drawing.Point(150, 24)
        Me.tbSearchByNameAP.Name = "tbSearchByNameAP"
        Me.tbSearchByNameAP.Size = New System.Drawing.Size(134, 23)
        Me.tbSearchByNameAP.TabIndex = 5
        '
        'gbAddUser
        '
        Me.gbAddUser.Controls.Add(Me.lblFirstNameAP)
        Me.gbAddUser.Controls.Add(Me.tbFirstNameAP)
        Me.gbAddUser.Controls.Add(Me.lblLastNameAP)
        Me.gbAddUser.Controls.Add(Me.tbLastNameAP)
        Me.gbAddUser.Controls.Add(Me.lblEmailAP)
        Me.gbAddUser.Controls.Add(Me.tbUserEmailAP)
        Me.gbAddUser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAddUser.Location = New System.Drawing.Point(14, 6)
        Me.gbAddUser.Margin = New System.Windows.Forms.Padding(2)
        Me.gbAddUser.Name = "gbAddUser"
        Me.gbAddUser.Padding = New System.Windows.Forms.Padding(2)
        Me.gbAddUser.Size = New System.Drawing.Size(226, 122)
        Me.gbAddUser.TabIndex = 18
        Me.gbAddUser.TabStop = False
        Me.gbAddUser.Text = "User Entry"
        '
        'lblFirstNameAP
        '
        Me.lblFirstNameAP.AutoSize = True
        Me.lblFirstNameAP.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstNameAP.Location = New System.Drawing.Point(10, 24)
        Me.lblFirstNameAP.Name = "lblFirstNameAP"
        Me.lblFirstNameAP.Size = New System.Drawing.Size(64, 15)
        Me.lblFirstNameAP.TabIndex = 7
        Me.lblFirstNameAP.Text = "First Name"
        '
        'tbFirstNameAP
        '
        Me.tbFirstNameAP.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFirstNameAP.ForeColor = System.Drawing.Color.Black
        Me.tbFirstNameAP.Location = New System.Drawing.Point(90, 24)
        Me.tbFirstNameAP.Name = "tbFirstNameAP"
        Me.tbFirstNameAP.Size = New System.Drawing.Size(125, 23)
        Me.tbFirstNameAP.TabIndex = 6
        '
        'lblLastNameAP
        '
        Me.lblLastNameAP.AutoSize = True
        Me.lblLastNameAP.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastNameAP.Location = New System.Drawing.Point(10, 55)
        Me.lblLastNameAP.Name = "lblLastNameAP"
        Me.lblLastNameAP.Size = New System.Drawing.Size(63, 15)
        Me.lblLastNameAP.TabIndex = 8
        Me.lblLastNameAP.Text = "Last Name"
        '
        'tbLastNameAP
        '
        Me.tbLastNameAP.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLastNameAP.ForeColor = System.Drawing.Color.Black
        Me.tbLastNameAP.Location = New System.Drawing.Point(90, 54)
        Me.tbLastNameAP.Name = "tbLastNameAP"
        Me.tbLastNameAP.Size = New System.Drawing.Size(125, 23)
        Me.tbLastNameAP.TabIndex = 3
        '
        'lblEmailAP
        '
        Me.lblEmailAP.AutoSize = True
        Me.lblEmailAP.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailAP.Location = New System.Drawing.Point(10, 86)
        Me.lblEmailAP.Name = "lblEmailAP"
        Me.lblEmailAP.Size = New System.Drawing.Size(36, 15)
        Me.lblEmailAP.TabIndex = 9
        Me.lblEmailAP.Text = "Email"
        '
        'tbUserEmailAP
        '
        Me.tbUserEmailAP.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUserEmailAP.ForeColor = System.Drawing.Color.Black
        Me.tbUserEmailAP.Location = New System.Drawing.Point(90, 84)
        Me.tbUserEmailAP.Name = "tbUserEmailAP"
        Me.tbUserEmailAP.Size = New System.Drawing.Size(125, 23)
        Me.tbUserEmailAP.TabIndex = 4
        '
        'adminPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(848, 502)
        Me.Controls.Add(Me.pnlTopSide)
        Me.Controls.Add(Me.pnlLeftSide)
        Me.Controls.Add(Me.pnlInventory)
        Me.Controls.Add(Me.pnlUsers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "adminPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminPage"
        Me.pnlLeftSide.ResumeLayout(False)
        Me.pnlLeftSide.PerformLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopSide.ResumeLayout(False)
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInventory.ResumeLayout(False)
        Me.gbStockDetails.ResumeLayout(False)
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCommand.ResumeLayout(False)
        Me.gbCommand.PerformLayout()
        Me.gbStockEntry.ResumeLayout(False)
        Me.gbStockEntry.PerformLayout()
        Me.pnlUsers.ResumeLayout(False)
        Me.gbUsersList.ResumeLayout(False)
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbAddUser.ResumeLayout(False)
        Me.gbAddUser.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLeftSide As Panel
    Friend WithEvents weFoods As Label
    Friend WithEvents logoPictureBox As PictureBox
    Friend WithEvents pnlTopSide As Panel
    Friend WithEvents picClose As PictureBox
    Friend WithEvents picMinimize As PictureBox
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
    Friend WithEvents btnAddStock As Button
    Friend WithEvents btnUpdateStock As Button
    Friend WithEvents btnDeleteStock As Button
    Friend WithEvents pnlInventory As Panel
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents pnlOnButtonUsers As Panel
    Friend WithEvents pnlOnButtonInventory As Panel
    Friend WithEvents pnlUsers As Panel
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents gbStockEntry As GroupBox
    Friend WithEvents gbCommand As GroupBox
    Friend WithEvents gbStockDetails As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents lblSearchByName As Label
    Friend WithEvents tbSearchByNameAP As TextBox
    Friend WithEvents gbAddUser As GroupBox
    Friend WithEvents lblFirstNameAP As Label
    Friend WithEvents tbFirstNameAP As TextBox
    Friend WithEvents lblLastNameAP As Label
    Friend WithEvents tbLastNameAP As TextBox
    Friend WithEvents lblEmailAP As Label
    Friend WithEvents tbUserEmailAP As TextBox
    Friend WithEvents gbUsersList As GroupBox
End Class
