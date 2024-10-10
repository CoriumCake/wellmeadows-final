Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class DatabaseHelper
    Private connectionString As String = "Data Source=graphite\DB1101171;Initial Catalog=dbWellsmeadowsHospitalG19;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"

    ' Method to hash passwords using SHA256
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            ' Hash the password directly without trimming
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return Convert.ToBase64String(hash)
        End Using
    End Function

    ' Check if user exists by email
    Public Function UserExistsByEmail(email As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM staff WHERE email = @Email"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Email", email)
                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    ' Validate user login by checking hashed password
    Public Function ValidateUser(usernameOrEmail As String, password As String) As Boolean
        Dim query As String = "SELECT PasswordHash FROM staff WHERE (Username = @UsernameOrEmail OR email = @UsernameOrEmail)"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@UsernameOrEmail", usernameOrEmail)
                connection.Open()
                Dim storedHash As String = Convert.ToString(command.ExecuteScalar())

                If Not String.IsNullOrEmpty(storedHash) Then
                    ' Hash the input password without trimming
                    Dim hashedPassword As String = HashPassword(password)

                    ' Compare the stored hash with the hashed input password
                    Return storedHash = hashedPassword
                End If
                Return False
            End Using
        End Using
    End Function

    ' Update password in the database by hashing it first
    Public Sub UpdatePassword(email As String, newPassword As String)
        Dim hashedPassword As String = HashPassword(newPassword)
        Dim query As String = "UPDATE staff SET PasswordHash = @Password WHERE email = @Email"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Password", hashedPassword)
                command.Parameters.AddWithValue("@Email", email)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Function GetUserDetailsByUsername(username As String) As DataTable
        Dim query As String = "SELECT StaffID, FirstName, LastName, Position, Picture FROM staff WHERE Username = @Username OR Email = @Username"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                connection.Open()

                Using adapter As New SqlDataAdapter(command)
                    Dim userDetails As New DataTable()
                    adapter.Fill(userDetails)
                    Return userDetails
                End Using
            End Using
        End Using
    End Function


End Class
