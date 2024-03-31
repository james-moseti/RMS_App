<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblSignUp = New System.Windows.Forms.Label()
        Me.lblAlreadyHaveAccount = New System.Windows.Forms.Label()
        Me.llblSignIn = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlFirstName = New System.Windows.Forms.Panel()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.pnlLastName = New System.Windows.Forms.Panel()
        Me.pnlSUEmail = New System.Windows.Forms.Panel()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.pnlSUPassword = New System.Windows.Forms.Panel()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblSUEmail = New System.Windows.Forms.Label()
        Me.lblSUPassword = New System.Windows.Forms.Label()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFirstName.SuspendLayout()
        Me.pnlSUEmail.SuspendLayout()
        Me.pnlSUPassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RestaurantManagementSystem.My.Resources.Resources.icons8_male_user_96
        Me.PictureBox1.Location = New System.Drawing.Point(177, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblSignUp
        '
        Me.lblSignUp.AutoSize = True
        Me.lblSignUp.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignUp.Location = New System.Drawing.Point(201, 163)
        Me.lblSignUp.Name = "lblSignUp"
        Me.lblSignUp.Size = New System.Drawing.Size(84, 28)
        Me.lblSignUp.TabIndex = 1
        Me.lblSignUp.Text = "Sign Up"
        '
        'lblAlreadyHaveAccount
        '
        Me.lblAlreadyHaveAccount.AutoSize = True
        Me.lblAlreadyHaveAccount.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlreadyHaveAccount.Location = New System.Drawing.Point(129, 558)
        Me.lblAlreadyHaveAccount.Name = "lblAlreadyHaveAccount"
        Me.lblAlreadyHaveAccount.Size = New System.Drawing.Size(189, 20)
        Me.lblAlreadyHaveAccount.TabIndex = 2
        Me.lblAlreadyHaveAccount.Text = "Already have an account? "
        '
        'llblSignIn
        '
        Me.llblSignIn.AutoSize = True
        Me.llblSignIn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblSignIn.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.llblSignIn.Location = New System.Drawing.Point(314, 557)
        Me.llblSignIn.Name = "llblSignIn"
        Me.llblSignIn.Size = New System.Drawing.Size(56, 20)
        Me.llblSignIn.TabIndex = 3
        Me.llblSignIn.TabStop = True
        Me.llblSignIn.Text = "Sign In"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(125, 491)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(250, 41)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Sign Up"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'pnlFirstName
        '
        Me.pnlFirstName.BackColor = System.Drawing.Color.White
        Me.pnlFirstName.Controls.Add(Me.tbFirstName)
        Me.pnlFirstName.Location = New System.Drawing.Point(125, 204)
        Me.pnlFirstName.Name = "pnlFirstName"
        Me.pnlFirstName.Size = New System.Drawing.Size(250, 46)
        Me.pnlFirstName.TabIndex = 5
        '
        'tbFirstName
        '
        Me.tbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbFirstName.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFirstName.ForeColor = System.Drawing.Color.Black
        Me.tbFirstName.Location = New System.Drawing.Point(11, 10)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(226, 23)
        Me.tbFirstName.TabIndex = 13
        '
        'pnlLastName
        '
        Me.pnlLastName.BackColor = System.Drawing.Color.White
        Me.pnlLastName.Location = New System.Drawing.Point(125, 280)
        Me.pnlLastName.Name = "pnlLastName"
        Me.pnlLastName.Size = New System.Drawing.Size(250, 46)
        Me.pnlLastName.TabIndex = 6
        '
        'pnlSUEmail
        '
        Me.pnlSUEmail.BackColor = System.Drawing.Color.White
        Me.pnlSUEmail.Controls.Add(Me.tbEmail)
        Me.pnlSUEmail.Location = New System.Drawing.Point(125, 352)
        Me.pnlSUEmail.Name = "pnlSUEmail"
        Me.pnlSUEmail.Size = New System.Drawing.Size(250, 46)
        Me.pnlSUEmail.TabIndex = 7
        '
        'tbEmail
        '
        Me.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbEmail.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmail.ForeColor = System.Drawing.Color.Black
        Me.tbEmail.Location = New System.Drawing.Point(11, 11)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(226, 23)
        Me.tbEmail.TabIndex = 15
        '
        'pnlSUPassword
        '
        Me.pnlSUPassword.BackColor = System.Drawing.Color.White
        Me.pnlSUPassword.Controls.Add(Me.tbPassword)
        Me.pnlSUPassword.Location = New System.Drawing.Point(125, 421)
        Me.pnlSUPassword.Name = "pnlSUPassword"
        Me.pnlSUPassword.Size = New System.Drawing.Size(250, 46)
        Me.pnlSUPassword.TabIndex = 8
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(26, 214)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(83, 20)
        Me.lblFirstName.TabIndex = 9
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(26, 293)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(80, 20)
        Me.lblLastName.TabIndex = 10
        Me.lblLastName.Text = "Last Name"
        '
        'lblSUEmail
        '
        Me.lblSUEmail.AutoSize = True
        Me.lblSUEmail.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSUEmail.Location = New System.Drawing.Point(26, 365)
        Me.lblSUEmail.Name = "lblSUEmail"
        Me.lblSUEmail.Size = New System.Drawing.Size(46, 20)
        Me.lblSUEmail.TabIndex = 11
        Me.lblSUEmail.Text = "Email"
        '
        'lblSUPassword
        '
        Me.lblSUPassword.AutoSize = True
        Me.lblSUPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSUPassword.Location = New System.Drawing.Point(26, 431)
        Me.lblSUPassword.Name = "lblSUPassword"
        Me.lblSUPassword.Size = New System.Drawing.Size(73, 20)
        Me.lblSUPassword.TabIndex = 12
        Me.lblSUPassword.Text = "Password"
        '
        'tbLastName
        '
        Me.tbLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbLastName.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLastName.ForeColor = System.Drawing.Color.Black
        Me.tbLastName.Location = New System.Drawing.Point(136, 291)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(226, 23)
        Me.tbLastName.TabIndex = 14
        '
        'tbPassword
        '
        Me.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbPassword.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.ForeColor = System.Drawing.Color.Black
        Me.tbPassword.Location = New System.Drawing.Point(11, 11)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(229, 23)
        Me.tbPassword.TabIndex = 15
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(490, 636)
        Me.Controls.Add(Me.tbLastName)
        Me.Controls.Add(Me.lblSUPassword)
        Me.Controls.Add(Me.lblSUEmail)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.pnlSUPassword)
        Me.Controls.Add(Me.pnlSUEmail)
        Me.Controls.Add(Me.pnlLastName)
        Me.Controls.Add(Me.pnlFirstName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.llblSignIn)
        Me.Controls.Add(Me.lblAlreadyHaveAccount)
        Me.Controls.Add(Me.lblSignUp)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignUp"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFirstName.ResumeLayout(False)
        Me.pnlFirstName.PerformLayout()
        Me.pnlSUEmail.ResumeLayout(False)
        Me.pnlSUEmail.PerformLayout()
        Me.pnlSUPassword.ResumeLayout(False)
        Me.pnlSUPassword.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblSignUp As Label
    Friend WithEvents lblAlreadyHaveAccount As Label
    Friend WithEvents llblSignIn As LinkLabel

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblSignIn.LinkClicked
        Form1.Show()
        Me.Close()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents pnlFirstName As Panel
    Friend WithEvents pnlLastName As Panel
    Friend WithEvents pnlSUEmail As Panel
    Friend WithEvents pnlSUPassword As Panel
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblSUEmail As Label
    Friend WithEvents lblSUPassword As Label
    Friend WithEvents tbFirstName As TextBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents tbLastName As TextBox
    Friend WithEvents tbPassword As TextBox
End Class
