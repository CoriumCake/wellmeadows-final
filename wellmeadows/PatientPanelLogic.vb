Imports System.Data.SqlClient

Public Class PatientPanelLogic

    Dim connectionString As String = "Data Source=graphite\DB1101171;Initial Catalog=dbWellsmeadowsHospitalG19;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"

    ' Function to search patients by name or details
    Public Function SearchPatientByNameOrDetails(searchTerm As String) As DataTable
        Dim query As String = "SELECT * FROM vwPatientFullDetails " &
                              "WHERE FirstName LIKE '%' + @SearchTerm + '%' " &
                              "OR LastName LIKE '%' + @SearchTerm + '%' " &
                              "OR Gender LIKE '%' + @SearchTerm + '%' " &
                              "OR Address LIKE '%' + @SearchTerm + '%' " &
                              "OR DoctorFullName LIKE '%' + @SearchTerm + '%'" ' Assuming DoctorFullName is part of the view

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@SearchTerm", searchTerm)
                connection.Open()

                Using adapter As New SqlDataAdapter(command)
                    Dim results As New DataTable()
                    adapter.Fill(results)
                    Return results
                End Using
            End Using
        End Using
    End Function

    ' Method to get the next PatientID
    Public Function GetNextPatientID() As Integer
        Dim nextPatientID As Integer = 1 ' Default to 1 if there are no records

        Dim query As String = "SELECT ISNULL(MAX(Patients_ID), 0) + 1 FROM Patients"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                nextPatientID = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using

        Return nextPatientID
    End Function

    ' Method to clear the patient form
    Public Sub ClearPatientForm(pnl_Patient_Edit As Panel)
        For Each ctrl As Control In pnl_Patient_Edit.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear() ' Clear all textboxes
            End If
        Next
        ' Clear DateTimePickers or other controls if needed
        For Each ctrl As Control In pnl_Patient_Edit.Controls
            If TypeOf ctrl Is DateTimePicker Then
                DirectCast(ctrl, DateTimePicker).Value = DateTime.Now
            End If
        Next
    End Sub
    Public Sub AddPatient(txtFirstName_patient_add As TextBox, txtLastName_patient_add As TextBox, txtAddress_patient_add As TextBox, txtSex_patient_add As TextBox, txtPhone_patient_add As TextBox, txtPatientID_patient_add As TextBox, datePickerDOB_patient_add As DateTimePicker, datePickerDateRegistered_patient_add As DateTimePicker, txtMaritalStatus_patient_add As TextBox, txtNextOfKin_patient_add As TextBox, txtDoctorFullName_patient_add As TextBox, txtClinicNumber_patient_add As TextBox, txtDoctorAddress_patient_add As TextBox, txtDoctorPhone_patient_add As TextBox)

        ' Get the next Patient ID
        Dim nextPatientID As Integer = GetNextPatientID()

        ' Generate or retrieve the next unique Clinic Number
        Dim nextClinicNumber As Integer = GetNextClinicNumber()

        ' Split the DoctorFullName into FirstName and LastName
        Dim doctorFirstName As String = ""
        Dim doctorLastName As String = ""
        Dim doctorFullNameParts As String() = txtDoctorFullName_patient_add.Text.Trim().Split(" "c)

        If doctorFullNameParts.Length > 1 Then
            doctorFirstName = doctorFullNameParts(0)
            doctorLastName = String.Join(" ", doctorFullNameParts.Skip(1)) ' Joins the rest of the string as last name
        Else
            doctorFirstName = txtDoctorFullName_patient_add.Text.Trim()
            doctorLastName = "" ' No last name provided
        End If

        Try
            ' Check the values being passed before the query is executed
            MessageBox.Show("FirstName: " & txtFirstName_patient_add.Text &
                            ", LastName: " & txtLastName_patient_add.Text &
                            ", Address: " & txtAddress_patient_add.Text &
                            ", Sex: " & txtSex_patient_add.Text &
                            ", Phone: " & txtPhone_patient_add.Text &
                            ", DOB: " & datePickerDOB_patient_add.Value.ToString() &
                            ", MaritalStatus: " & txtMaritalStatus_patient_add.Text &
                            ", DateRegistered: " & datePickerDateRegistered_patient_add.Value.ToString() &
                            ", NextOfKin: " & txtNextOfKin_patient_add.Text)

            ' Insert into Patients table
            Dim query As String = "BEGIN TRANSACTION; " &
                       "INSERT INTO Patients (Patients_ID, Firstname, Lastname, Address, Sex, TelePhone_number, Date_of_birth, MaritalStatus, Date_Register_with_the_hospital, NextofKin) " &
                       "VALUES (@NextPatientID, @FirstName, @LastName, @Address, @Sex, @Phone, @DOB, @MaritalStatus, @DateRegistered, @NextOfKin); " &
                       "INSERT INTO Local_doctor (Clinic_number, Patients_ID, Firstname, Lastname, Telephone_number, Address) " &
                       "VALUES (@NextClinicNumber, @NextPatientID, @DoctorFirstName, @DoctorLastName, @DoctorPhone, @DoctorAddress); " &
                       "COMMIT;"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    ' Add parameters for Patients table
                    command.Parameters.AddWithValue("@NextPatientID", nextPatientID)
                    command.Parameters.AddWithValue("@FirstName", txtFirstName_patient_add.Text.Trim())
                    command.Parameters.AddWithValue("@LastName", txtLastName_patient_add.Text.Trim())
                    command.Parameters.AddWithValue("@Address", txtAddress_patient_add.Text.Trim())
                    command.Parameters.AddWithValue("@Sex", txtSex_patient_add.Text.Trim())
                    command.Parameters.AddWithValue("@Phone", txtPhone_patient_add.Text.Trim())
                    command.Parameters.AddWithValue("@DOB", datePickerDOB_patient_add.Value)
                    command.Parameters.AddWithValue("@MaritalStatus", txtMaritalStatus_patient_add.Text.Trim())
                    command.Parameters.AddWithValue("@DateRegistered", datePickerDateRegistered_patient_add.Value)
                    command.Parameters.AddWithValue("@NextOfKin", txtNextOfKin_patient_add.Text.Trim())

                    ' Add parameters for Local_doctor table
                    command.Parameters.AddWithValue("@NextClinicNumber", nextClinicNumber)
                    command.Parameters.AddWithValue("@DoctorFirstName", doctorFirstName)
                    command.Parameters.AddWithValue("@DoctorLastName", doctorLastName)
                    command.Parameters.AddWithValue("@DoctorPhone", txtDoctorPhone_patient_add.Text.Trim())
                    command.Parameters.AddWithValue("@DoctorAddress", txtDoctorAddress_patient_add.Text.Trim())


                    ' Open connection and execute query
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("New patient record added successfully!")
        Catch ex As SqlException
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try


    End Sub





    ' Method to refresh patient list
    Public Sub RefreshPatientList(patientListGrid As DataGridView)
        ' SQL query to retrieve patient details
        Dim query As String = "SELECT Patients.Patients_ID, Patients.FirstName, Patients.LastName, Patients.Sex, Patients.Date_of_birth, " &
                          "Patients.MaritalStatus, Patients.NextofKin " &
                          "FROM Patients" ' Add space before FROM

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim adapter As New SqlDataAdapter(command)
                Dim patientData As New DataTable()
                adapter.Fill(patientData)

                ' Bind the new data to the grid
                patientListGrid.DataSource = patientData
            End Using
        End Using
    End Sub


    ' Method to load patient data for editing
    Public Sub LoadPatientDataToEdit(patientID As Integer, mainPanel As MainPanel)
        Dim query As String = "SELECT * FROM vwPatientLocalDetails WHERE PatientNumber = @PatientID"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@PatientID", patientID)

                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Load patient data into the form fields
                        mainPanel.txtPatientID.Text = reader("PatientNumber").ToString()
                        mainPanel.txtFirstName_patient.Text = reader("FirstName").ToString()
                        mainPanel.txtLastName_patient.Text = reader("LastName").ToString()
                        mainPanel.datePickerDOB_patient.Value = Convert.ToDateTime(reader("DOB"))
                        mainPanel.txtAddress_patient.Text = reader("PatientAddress").ToString()
                        mainPanel.txtSex_patient.Text = reader("Gender").ToString()
                        mainPanel.txtPhone_patient.Text = reader("PhoneNumber").ToString()
                        mainPanel.txtMaritalStatus_patient.Text = reader("MaritalStatus").ToString()
                        mainPanel.datePickerDateRegistered_patient.Value = Convert.ToDateTime(reader("DateRegistered"))
                        mainPanel.txtNextOfKin_patient.Text = reader("NextOfKin").ToString()
                        mainPanel.txtDoctorFullName_patient.Text = reader("DoctorFullName").ToString()
                        mainPanel.txtClinicNumber_patient.Text = reader("Clinic_Number").ToString()
                        mainPanel.txtDoctorAddress_patient.Text = reader("DoctorAddress").ToString()
                        mainPanel.txtDoctorPhone_patient.Text = reader("DoctorPhone").ToString()
                    End If
                End Using
            End Using
        End Using
    End Sub

    ' Method to update a patient record
    Public Sub UpdatePatient(mainPanel As MainPanel)
        ' Split the DoctorFullName into FirstName and LastName
        Dim doctorFirstName As String = ""
        Dim doctorLastName As String = ""
        Dim doctorFullNameParts As String() = mainPanel.txtDoctorFullName_patient.Text.Trim().Split(" "c)

        If doctorFullNameParts.Length > 1 Then
            doctorFirstName = doctorFullNameParts(0)
            doctorLastName = String.Join(" ", doctorFullNameParts.Skip(1)) ' Joins the rest of the string as last name (in case of multiple parts in last name)
        Else
            doctorFirstName = mainPanel.txtDoctorFullName_patient.Text.Trim()
            doctorLastName = "" ' No last name provided
        End If

        ' Update query for both Patients and Local_doctor tables
        Dim query As String = "BEGIN TRANSACTION; " &
                          "UPDATE Patients SET Firstname = @FirstName, Lastname = @LastName, Address = @Address, Sex = @Sex, " &
                          "TelePhone_number = @Phone, Date_of_birth = @DOB, MaritalStatus = @MaritalStatus, " &
                          "Date_Register_with_the_hospital = @DateRegistered, NextofKin = @NextOfKin WHERE Patients_ID = @PatientID; " &
                          "UPDATE Local_doctor SET Clinic_number = @ClinicNumber, Firstname = @DoctorFirstName, Lastname = @DoctorLastName, " &
                          "Telephone_number = @DoctorPhone, Address = @DoctorAddress WHERE Patients_ID = @PatientID; " &
                          "COMMIT;"

        ' Execute the query
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Add parameters for patient data
                command.Parameters.AddWithValue("@PatientID", mainPanel.txtPatientID.Text.Trim())
                command.Parameters.AddWithValue("@FirstName", mainPanel.txtFirstName_patient.Text.Trim())
                command.Parameters.AddWithValue("@LastName", mainPanel.txtLastName_patient.Text.Trim())
                command.Parameters.AddWithValue("@Address", mainPanel.txtAddress_patient.Text.Trim())
                command.Parameters.AddWithValue("@Sex", mainPanel.txtSex_patient.Text.Trim())
                command.Parameters.AddWithValue("@Phone", mainPanel.txtPhone_patient.Text.Trim())
                command.Parameters.AddWithValue("@DOB", mainPanel.datePickerDOB_patient.Value)
                command.Parameters.AddWithValue("@MaritalStatus", mainPanel.txtMaritalStatus_patient.Text.Trim())
                command.Parameters.AddWithValue("@DateRegistered", mainPanel.datePickerDateRegistered_patient.Value)
                command.Parameters.AddWithValue("@NextOfKin", mainPanel.txtNextOfKin_patient.Text.Trim())

                ' Add parameters for Local_doctor table
                command.Parameters.AddWithValue("@ClinicNumber", mainPanel.txtClinicNumber_patient.Text.Trim())
                command.Parameters.AddWithValue("@DoctorFirstName", doctorFirstName)
                command.Parameters.AddWithValue("@DoctorLastName", doctorLastName)
                command.Parameters.AddWithValue("@DoctorPhone", mainPanel.txtDoctorPhone_patient.Text.Trim())
                command.Parameters.AddWithValue("@DoctorAddress", mainPanel.txtDoctorAddress_patient.Text.Trim())

                ' Execute the query
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                connection.Close()

                ' Notify user
                If rowsAffected > 0 Then
                    MessageBox.Show("Patient record updated successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No changes were made to the patient record.", "Update Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        End Using
    End Sub

    ' Method to delete a patient record
    Public Sub DeletePatientRecord(patientID As Integer)
        Dim query As String = "DELETE FROM Patients WHERE Patients_ID = @PatientsID"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@PatientsID", patientID)

                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()

                MessageBox.Show("Patient record deleted successfully.", "Deletion Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End Using
    End Sub

    ' Function to get the next available Clinic Number (assuming it’s an integer)
    Public Function GetNextClinicNumber() As Integer
        Dim nextClinicNumber As Integer = 1 ' Default to 1 if there are no records

        Dim query As String = "SELECT ISNULL(MAX(Clinic_number), 0) + 1 FROM Local_doctor"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                nextClinicNumber = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using

        Return nextClinicNumber
    End Function

    Public Sub SwitchPanel(mainPanel As MainPanel, showEditPanel As Boolean, Optional showEdit2Panel As Boolean = False)
        mainPanel.pnl_Patient_add.Visible = False
        mainPanel.panel_Patient_list.Visible = Not (showEditPanel Or showEdit2Panel)
        mainPanel.pnl_Patient_edit.Visible = showEditPanel
    End Sub
End Class

