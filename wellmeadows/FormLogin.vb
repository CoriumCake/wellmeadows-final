Public Class Form1
    Private dbHelper As New DatabaseHelper()
    Private otpHelper As New OTPHelper()

    ' Constructor
    Public Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    ' Method to hide all panels initially
    Private Sub HideAllPanels()
        pnl_login.Visible = False
        pnlNewPassword.Visible = False
        pnlEmailAndOTP.Visible = False
    End Sub

    ' Form Load event to initialize the default panel
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideAllPanels()
        pnl_login.Visible = True
    End Sub

    ' Handle login logic
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Make sure to remove extra spaces from username and password inputs
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        If dbHelper.ValidateUser(username, password) Then
            ' Fetch the user details after successful login
            Dim userDetails As DataTable = dbHelper.GetUserDetailsByUsername(username)

            If userDetails IsNot Nothing AndAlso userDetails.Rows.Count > 0 Then
                ' Store the user session information in the SessionManager
                SessionManager.LoggedInUserID = CInt(userDetails.Rows(0)("StaffID"))
                SessionManager.LoggedInUserFullName = userDetails.Rows(0)("FirstName").ToString() & " " & userDetails.Rows(0)("LastName").ToString()
                SessionManager.LoggedInUserPosition = userDetails.Rows(0)("Position").ToString()
                SessionManager.LoggedInUserPicture = If(userDetails.Rows(0)("Picture") IsNot DBNull.Value, CType(userDetails.Rows(0)("Picture"), Byte()), Nothing)

                ' Open the MainPanel form and hide the login form
                Dim dashboardForm As New MainPanel()
                dashboardForm.StartPosition = FormStartPosition.CenterScreen
                dashboardForm.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("Invalid username/email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    ' Handle Forgot Password Link
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        txtEmail.Clear() ' Clear the email textbox
        txtOTP.Clear() ' Clear the OTP textbox

        HideAllPanels()
        pnlEmailAndOTP.Visible = True
    End Sub

    ' Handle email submission and OTP sending
    Private Sub btnSendOTP_Click(sender As Object, e As EventArgs) Handles btnSendOTP.Click
        If dbHelper.UserExistsByEmail(txtEmail.Text) Then
            otpHelper.SendOTP(txtEmail.Text)
        Else
            MessageBox.Show("Email not found.")
        End If
    End Sub

    ' Handle OTP submission and validation
    Private Sub btnSubmitOTP_Click(sender As Object, e As EventArgs) Handles btnSubmitOTP.Click
        If String.IsNullOrWhiteSpace(txtEmail.Text) Or String.IsNullOrWhiteSpace(txtOTP.Text) Then
            MessageBox.Show("Please enter both your email and the OTP.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit the method if validation fails
        End If

        ' Validate the OTP
        If otpHelper.ValidateOTP(txtOTP.Text) Then
            HideAllPanels()
            pnlNewPassword.Visible = True
        Else
            MessageBox.Show("Invalid OTP. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Handle password reset
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RoundCornerTextbox2.Text = RoundCornerTextbox1.Text Then
            ' Update the password in the database
            dbHelper.UpdatePassword(txtEmail.Text, RoundCornerTextbox1.Text)

            ' Show success message
            MessageBox.Show("Password successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Hide the current panels and show the login panel
            HideAllPanels()
            pnl_login.Visible = True
        Else
            ' Show error if passwords don't match
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Show or hide password
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        ' If the checkbox is checked, show the password
        If chkShowPassword.Checked Then
            txtPassword.UseSystemPasswordChar = False ' Show password
        Else
            txtPassword.UseSystemPasswordChar = True ' Hide password (use default masking character)
        End If
    End Sub
End Class
