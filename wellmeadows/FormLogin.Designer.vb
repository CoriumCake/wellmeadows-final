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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pnl_login = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtUsername = New wellmeadows.RoundCornerTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassword = New wellmeadows.RoundCornerTextbox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Login = New System.Windows.Forms.Label()
        Me.Banner = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnl_newpass = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New wellmeadows.RoundCornerTextbox()
        Me.txtNewPassword = New wellmeadows.RoundCornerTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSubmitNewPassword = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlEmailAndOTP = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEmail = New wellmeadows.RoundCornerTextbox()
        Me.txtOTP = New wellmeadows.RoundCornerTextbox()
        Me.btnSendOTP = New System.Windows.Forms.Button()
        Me.btnSubmitOTP = New System.Windows.Forms.Button()
        Me.pnlNewPassword = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RoundCornerTextbox1 = New wellmeadows.RoundCornerTextbox()
        Me.RoundCornerTextbox2 = New wellmeadows.RoundCornerTextbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.pnl_login.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Banner.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_newpass.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.pnlEmailAndOTP.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.pnlNewPassword.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_login
        '
        Me.pnl_login.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnl_login.Controls.Add(Me.TableLayoutPanel1)
        Me.pnl_login.Location = New System.Drawing.Point(0, 0)
        Me.pnl_login.Name = "pnl_login"
        Me.pnl_login.Size = New System.Drawing.Size(834, 571)
        Me.pnl_login.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.BackgroundImage = Global.wellmeadows.My.Resources.Resources.login_border
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.9916!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.78008!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.17427!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtUsername, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPassword, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btnLogin, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.chkShowPassword, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LinkLabel1, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Login, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(130, 122)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.24646!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.66289!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.13031!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.51852!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.62963!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(574, 404)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label2, 2)
        Me.Label2.Font = New System.Drawing.Font("Inter", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(140, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(342, 61)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username or Email"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(40, 79)
        Me.Label9.Margin = New System.Windows.Forms.Padding(40, 0, 3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 98)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Email"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtUsername, 2)
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(143, 126)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 6, 3, 8)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(291, 30)
        Me.txtUsername.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Inter", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(140, 167)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 50)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Password"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPassword
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtPassword, 2)
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(140, 217)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(294, 30)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnLogin.BackgroundImage = Global.wellmeadows.My.Resources.Resources.login_button1
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnLogin, 2)
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(206, 326)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(0, 5, 40, 0)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(170, 43)
        Me.btnLogin.TabIndex = 9
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPassword.Location = New System.Drawing.Point(143, 273)
        Me.chkShowPassword.Margin = New System.Windows.Forms.Padding(3, 3, 3, 8)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(144, 24)
        Me.chkShowPassword.TabIndex = 3
        Me.chkShowPassword.Text = "show password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(308, 270)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(10, 0, 3, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(141, 27)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "forgot password?"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LinkLabel1.UseMnemonic = False
        '
        'Login
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Login, 2)
        Me.Login.Font = New System.Drawing.Font("Inter", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.Location = New System.Drawing.Point(140, 7)
        Me.Login.Margin = New System.Windows.Forms.Padding(0, 7, 30, 0)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(312, 50)
        Me.Login.TabIndex = 12
        Me.Login.Text = "Login"
        Me.Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Banner
        '
        Me.Banner.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Banner.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Banner.Controls.Add(Me.Label1)
        Me.Banner.Controls.Add(Me.PictureBox1)
        Me.Banner.Location = New System.Drawing.Point(0, 0)
        Me.Banner.Name = "Banner"
        Me.Banner.Size = New System.Drawing.Size(828, 105)
        Me.Banner.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(297, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 92)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Wellmeadows"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.wellmeadows.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(230, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnl_newpass
        '
        Me.pnl_newpass.Controls.Add(Me.TableLayoutPanel2)
        Me.pnl_newpass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_newpass.Location = New System.Drawing.Point(0, 0)
        Me.pnl_newpass.Name = "pnl_newpass"
        Me.pnl_newpass.Size = New System.Drawing.Size(834, 562)
        Me.pnl_newpass.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.BackgroundImage = Global.wellmeadows.My.Resources.Resources.login_border
        Me.TableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.223!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.16725!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.60976!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtConfirmPassword, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.txtNewPassword, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSubmitNewPassword, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 2, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(130, 122)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.07317!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.68293!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.13605!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(634, 462)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label7, 3)
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(316, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1, 1)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "  New Password"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel2.SetColumnSpan(Me.txtConfirmPassword, 2)
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(178, 265)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(0, 6, 3, 8)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(1, 30)
        Me.txtConfirmPassword.TabIndex = 12
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel2.SetColumnSpan(Me.txtNewPassword, 2)
        Me.txtNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(178, 169)
        Me.txtNewPassword.Margin = New System.Windows.Forms.Padding(0, 6, 3, 8)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(1, 30)
        Me.txtNewPassword.TabIndex = 10
        Me.txtNewPassword.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(178, 119)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Password"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(178, 233)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Confirm Password"
        '
        'btnSubmitNewPassword
        '
        Me.btnSubmitNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSubmitNewPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSubmitNewPassword.BackgroundImage = Global.wellmeadows.My.Resources.Resources.login_button1
        Me.btnSubmitNewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSubmitNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmitNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitNewPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSubmitNewPassword.Location = New System.Drawing.Point(329, 318)
        Me.btnSubmitNewPassword.Margin = New System.Windows.Forms.Padding(15, 8, 3, 9)
        Me.btnSubmitNewPassword.Name = "btnSubmitNewPassword"
        Me.btnSubmitNewPassword.Size = New System.Drawing.Size(1, 47)
        Me.btnSubmitNewPassword.TabIndex = 9
        Me.btnSubmitNewPassword.Text = "SUBMIT"
        Me.btnSubmitNewPassword.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(473, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 20)
        Me.Label8.TabIndex = 15
        '
        'pnlEmailAndOTP
        '
        Me.pnlEmailAndOTP.Controls.Add(Me.TableLayoutPanel3)
        Me.pnlEmailAndOTP.Location = New System.Drawing.Point(8, 8)
        Me.pnlEmailAndOTP.Name = "pnlEmailAndOTP"
        Me.pnlEmailAndOTP.Size = New System.Drawing.Size(834, 562)
        Me.pnlEmailAndOTP.TabIndex = 6
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.BackgroundImage = Global.wellmeadows.My.Resources.Resources.login_border
        Me.TableLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.96406!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.34672!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.6!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtEmail, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtOTP, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.btnSendOTP, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.btnSubmitOTP, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label9, 0, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(130, 122)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.38461!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.69231!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.92308!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(574, 395)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 177)
        Me.Label3.Margin = New System.Windows.Forms.Padding(40, 0, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 83)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "OTP"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label10, 4)
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(565, 62)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "  Reset Password"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel3.SetColumnSpan(Me.txtEmail, 2)
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(137, 112)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(0, 6, 3, 8)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(333, 30)
        Me.txtEmail.TabIndex = 10
        '
        'txtOTP
        '
        Me.txtOTP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel3.SetColumnSpan(Me.txtOTP, 2)
        Me.txtOTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOTP.Location = New System.Drawing.Point(137, 202)
        Me.txtOTP.Margin = New System.Windows.Forms.Padding(0, 6, 3, 8)
        Me.txtOTP.Name = "txtOTP"
        Me.txtOTP.Size = New System.Drawing.Size(190, 30)
        Me.txtOTP.TabIndex = 12
        '
        'btnSendOTP
        '
        Me.btnSendOTP.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSendOTP.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSendOTP.BackgroundImage = Global.wellmeadows.My.Resources.Resources.login_button1
        Me.btnSendOTP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSendOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSendOTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendOTP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSendOTP.Location = New System.Drawing.Point(140, 268)
        Me.btnSendOTP.Margin = New System.Windows.Forms.Padding(3, 8, 3, 9)
        Me.btnSendOTP.Name = "btnSendOTP"
        Me.btnSendOTP.Size = New System.Drawing.Size(147, 55)
        Me.btnSendOTP.TabIndex = 13
        Me.btnSendOTP.Text = "OTP"
        Me.btnSendOTP.UseVisualStyleBackColor = False
        '
        'btnSubmitOTP
        '
        Me.btnSubmitOTP.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSubmitOTP.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSubmitOTP.BackgroundImage = Global.wellmeadows.My.Resources.Resources.login_button1
        Me.btnSubmitOTP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSubmitOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmitOTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitOTP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSubmitOTP.Location = New System.Drawing.Point(305, 268)
        Me.btnSubmitOTP.Margin = New System.Windows.Forms.Padding(15, 8, 3, 9)
        Me.btnSubmitOTP.Name = "btnSubmitOTP"
        Me.btnSubmitOTP.Size = New System.Drawing.Size(165, 55)
        Me.btnSubmitOTP.TabIndex = 9
        Me.btnSubmitOTP.Text = "SUBMIT"
        Me.btnSubmitOTP.UseVisualStyleBackColor = False
        '
        'pnlNewPassword
        '
        Me.pnlNewPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNewPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.pnlNewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlNewPassword.Controls.Add(Me.TableLayoutPanel4)
        Me.pnlNewPassword.Location = New System.Drawing.Point(0, 0)
        Me.pnlNewPassword.Name = "pnlNewPassword"
        Me.pnlNewPassword.Size = New System.Drawing.Size(834, 562)
        Me.pnlNewPassword.TabIndex = 5
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel4.BackgroundImage = Global.wellmeadows.My.Resources.Resources.login_border
        Me.TableLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.223!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.16725!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.60976!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label11, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.RoundCornerTextbox1, 1, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.RoundCornerTextbox2, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label12, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label13, 1, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Button1, 1, 5)
        Me.TableLayoutPanel4.Controls.Add(Me.Label14, 2, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(130, 122)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 7
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.07317!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.68293!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.13605!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(574, 395)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel4.SetColumnSpan(Me.Label11, 3)
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(565, 62)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "  New Password"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RoundCornerTextbox1
        '
        Me.RoundCornerTextbox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel4.SetColumnSpan(Me.RoundCornerTextbox1, 2)
        Me.RoundCornerTextbox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundCornerTextbox1.Location = New System.Drawing.Point(162, 197)
        Me.RoundCornerTextbox1.Margin = New System.Windows.Forms.Padding(0, 6, 3, 8)
        Me.RoundCornerTextbox1.Name = "RoundCornerTextbox1"
        Me.RoundCornerTextbox1.Size = New System.Drawing.Size(261, 30)
        Me.RoundCornerTextbox1.TabIndex = 12
        Me.RoundCornerTextbox1.UseSystemPasswordChar = True
        '
        'RoundCornerTextbox2
        '
        Me.RoundCornerTextbox2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel4.SetColumnSpan(Me.RoundCornerTextbox2, 2)
        Me.RoundCornerTextbox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundCornerTextbox2.Location = New System.Drawing.Point(162, 115)
        Me.RoundCornerTextbox2.Margin = New System.Windows.Forms.Padding(0, 6, 3, 8)
        Me.RoundCornerTextbox2.Name = "RoundCornerTextbox2"
        Me.RoundCornerTextbox2.Size = New System.Drawing.Size(261, 30)
        Me.RoundCornerTextbox2.TabIndex = 10
        Me.RoundCornerTextbox2.UseSystemPasswordChar = True
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(162, 78)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 20)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Password"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(162, 165)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(137, 20)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Confirm Password"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Button1.BackgroundImage = Global.wellmeadows.My.Resources.Resources.login_button1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(215, 250)
        Me.Button1.Margin = New System.Windows.Forms.Padding(15, 8, 3, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 47)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "SUBMIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(429, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 20)
        Me.Label14.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(834, 562)
        Me.Controls.Add(Me.Banner)
        Me.Controls.Add(Me.pnl_login)
        Me.Controls.Add(Me.pnlEmailAndOTP)
        Me.Controls.Add(Me.pnlNewPassword)
        Me.Controls.Add(Me.pnl_newpass)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(994, 782)
        Me.MinimumSize = New System.Drawing.Size(844, 582)
        Me.Name = "Form1"
        Me.Text = "Wellsmeadows Hospital"
        Me.pnl_login.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Banner.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_newpass.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.pnlEmailAndOTP.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.pnlNewPassword.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_login As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As RoundCornerTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassword As RoundCornerTextbox
    Friend WithEvents btnLogin As Button
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Login As Label
    Friend WithEvents Banner As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnl_newpass As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtConfirmPassword As RoundCornerTextbox
    Friend WithEvents txtNewPassword As RoundCornerTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSubmitNewPassword As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents pnlEmailAndOTP As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtEmail As RoundCornerTextbox
    Friend WithEvents txtOTP As RoundCornerTextbox
    Friend WithEvents btnSendOTP As Button
    Friend WithEvents btnSubmitOTP As Button
    Friend WithEvents pnlNewPassword As Panel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents RoundCornerTextbox1 As RoundCornerTextbox
    Friend WithEvents RoundCornerTextbox2 As RoundCornerTextbox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label14 As Label
End Class
