<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlEmail = New System.Windows.Forms.Panel()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.pnlPswd = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblNewToWeFoods = New System.Windows.Forms.Label()
        Me.llnkSignUp = New System.Windows.Forms.LinkLabel()
        Me.lblEmailView = New System.Windows.Forms.Label()
        Me.lblPswdView = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlEmail.SuspendLayout()
        Me.pnlPswd.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(197, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sign In"
        '
        'pnlEmail
        '
        Me.pnlEmail.BackColor = System.Drawing.Color.White
        Me.pnlEmail.Controls.Add(Me.lblEmailView)
        Me.pnlEmail.Controls.Add(Me.txtUsername)
        Me.pnlEmail.Controls.Add(Me.PictureBox2)
        Me.pnlEmail.Location = New System.Drawing.Point(83, 250)
        Me.pnlEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlEmail.Name = "pnlEmail"
        Me.pnlEmail.Size = New System.Drawing.Size(335, 74)
        Me.pnlEmail.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(72, 36)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUsername.MaxLength = 50
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(247, 23)
        Me.txtUsername.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(72, 40)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(247, 23)
        Me.txtPassword.TabIndex = 4
        '
        'pnlPswd
        '
        Me.pnlPswd.BackColor = System.Drawing.Color.White
        Me.pnlPswd.Controls.Add(Me.lblPswdView)
        Me.pnlPswd.Controls.Add(Me.txtPassword)
        Me.pnlPswd.Controls.Add(Me.PictureBox3)
        Me.pnlPswd.Location = New System.Drawing.Point(83, 346)
        Me.pnlPswd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlPswd.Name = "pnlPswd"
        Me.pnlPswd.Size = New System.Drawing.Size(335, 75)
        Me.pnlPswd.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(83, 458)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(335, 44)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblNewToWeFoods
        '
        Me.lblNewToWeFoods.AutoSize = True
        Me.lblNewToWeFoods.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewToWeFoods.Location = New System.Drawing.Point(130, 536)
        Me.lblNewToWeFoods.Name = "lblNewToWeFoods"
        Me.lblNewToWeFoods.Size = New System.Drawing.Size(136, 20)
        Me.lblNewToWeFoods.TabIndex = 6
        Me.lblNewToWeFoods.Text = "New to WeFoods? "
        '
        'llnkSignUp
        '
        Me.llnkSignUp.AutoSize = True
        Me.llnkSignUp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llnkSignUp.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.llnkSignUp.Location = New System.Drawing.Point(262, 535)
        Me.llnkSignUp.Name = "llnkSignUp"
        Me.llnkSignUp.Size = New System.Drawing.Size(63, 20)
        Me.llnkSignUp.TabIndex = 7
        Me.llnkSignUp.TabStop = True
        Me.llnkSignUp.Text = "Sign Up"
        '
        'lblEmailView
        '
        Me.lblEmailView.AutoSize = True
        Me.lblEmailView.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailView.Location = New System.Drawing.Point(71, 6)
        Me.lblEmailView.Name = "lblEmailView"
        Me.lblEmailView.Size = New System.Drawing.Size(46, 20)
        Me.lblEmailView.TabIndex = 5
        Me.lblEmailView.Text = "Email"
        '
        'lblPswdView
        '
        Me.lblPswdView.AutoSize = True
        Me.lblPswdView.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPswdView.Location = New System.Drawing.Point(73, 10)
        Me.lblPswdView.Name = "lblPswdView"
        Me.lblPswdView.Size = New System.Drawing.Size(73, 20)
        Me.lblPswdView.TabIndex = 5
        Me.lblPswdView.Text = "Password"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.RestaurantManagementSystem.My.Resources.Resources.icons8_password_48
        Me.PictureBox3.Location = New System.Drawing.Point(7, 13)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RestaurantManagementSystem.My.Resources.Resources.icons8_account_48
        Me.PictureBox2.Location = New System.Drawing.Point(7, 10)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 52)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RestaurantManagementSystem.My.Resources.Resources.icons8_male_user_96
        Me.PictureBox1.Location = New System.Drawing.Point(155, 28)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 156)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(489, 636)
        Me.Controls.Add(Me.llnkSignUp)
        Me.Controls.Add(Me.lblNewToWeFoods)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.pnlPswd)
        Me.Controls.Add(Me.pnlEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginInterface"
        Me.pnlEmail.ResumeLayout(False)
        Me.pnlEmail.PerformLayout()
        Me.pnlPswd.ResumeLayout(False)
        Me.pnlPswd.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlEmail As Panel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents pnlPswd As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblNewToWeFoods As Label
    Friend WithEvents llnkSignUp As LinkLabel
    Friend WithEvents lblEmailView As Label
    Friend WithEvents lblPswdView As Label
End Class
