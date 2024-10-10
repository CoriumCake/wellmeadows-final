Imports System.Net.Mail

Public Class OTPHelper
    Private otp As String

    ' Generate a random OTP
    Public Function GenerateOTP() As String
        Dim rnd As New Random()
        otp = rnd.Next(100000, 999999).ToString() ' Generate a 6-digit OTP
        Return otp
    End Function

    ' Send OTP to the provided email using SMTP
    Public Sub SendOTP(email As String)
        Dim generatedOtp = GenerateOTP()

        Try
            ' Set up the email
            Dim mail As New MailMessage()
            mail.From = New MailAddress("G19wellmeadows@gmail.com") ' Your email
            mail.To.Add(email)
            mail.Subject = "Your OTP Code"
            mail.Body = "Your OTP code is: " & generatedOtp

            ' SMTP configuration for Gmail
            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587 ' Use port 587 for TLS/SSL
            smtp.Credentials = New Net.NetworkCredential("G19wellmeadows@gmail.com", "ngwd saoo nxtv gsnt") ' Your Gmail address and app password
            smtp.EnableSsl = True

            ' Send the email
            smtp.Send(mail)

            MessageBox.Show("OTP has been sent to your email.")
        Catch ex As Exception
            MessageBox.Show("Error sending OTP: " & ex.Message)
        End Try
    End Sub

    ' Validate the OTP
    Public Function ValidateOTP(inputOTP As String) As Boolean
        Return otp = inputOTP
    End Function
End Class
