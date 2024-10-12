Imports System.Data.SqlClient

Public Class StaffPanelLogic

    Dim connectionString As String = "Data Source=graphite\DB1101171;Initial Catalog=dbWellsmeadowsHospitalG19;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"

    ' Function to search staff by qualification or experience
    Public Function SearchStaffByQualificationOrWork(searchTerm As String) As DataTable
        Dim query As String = "SELECT * FROM vwStaffFullDetails " &
                              "WHERE QualificationType LIKE '%' + @SearchTerm + '%' " &
                              "OR QualificationInstitution LIKE '%' + @SearchTerm + '%' " &
                              "OR ExperiencePosition LIKE '%' + @SearchTerm + '%' " &
                              "OR ExperienceOrganization LIKE '%' + @SearchTerm + '%' " &
                              "OR FirstName LIKE '%' + @SearchTerm + '%' " &
                              "OR LastName LIKE '%' + @SearchTerm + '%' " &
                              "OR StaffPosition LIKE '%' + @SearchTerm + '%'"

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

    ' Method to get next StaffID
    Public Function GetNextStaffID() As Integer
        Dim nextStaffID As Integer = 1 ' Default to 1 if there are no records

        Dim query As String = "SELECT ISNULL(MAX(StaffID), 0) + 1 FROM STAFF"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                nextStaffID = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using

        Return nextStaffID
    End Function

    ' Method to clear the staff form
    Public Sub ClearStaffForm(pnl_Staff_Edit_1 As Panel)
        For Each ctrl As Control In pnl_Staff_Edit_1.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear() ' Clear all textboxes
            End If
        Next
        ' Clear DateTimePickers or other controls if needed
        For Each ctrl As Control In pnl_Staff_Edit_1.Controls
            If TypeOf ctrl Is DateTimePicker Then
                DirectCast(ctrl, DateTimePicker).Value = DateTime.Now
            End If
        Next
    End Sub

    ' Method to add a new staff member
    Public Sub AddStaff(txtFirstName As TextBox, txtLastName As TextBox, datePickerDOB As DateTimePicker, txtPhone As TextBox, txtEmail As TextBox, txtAddress As TextBox, txtSex As TextBox, txtNIN As TextBox, txtPosition As TextBox, txtSalary As TextBox, txtWorkingHour As TextBox, txtSalaryScale As TextBox, txtPaidType As TextBox, txtPoT As TextBox, txtWard As TextBox, txtQualificationType As TextBox, dateQualificationDate As DateTimePicker, txtInstitution As TextBox, txtExperiencePosition As TextBox, dateExperienceStartDate As DateTimePicker, dateExperienceFinishDate As DateTimePicker, txtExperienceOrganization As TextBox)

        Dim nextStaffID As Integer = GetNextStaffID()

        Dim query As String = "BEGIN TRANSACTION;

                                -- First, insert into STAFF table
                                INSERT INTO STAFF (StaffID, FirstName, LastName, Date_of_birth, Permanent_or_temporary, Phone_number, email, Address, Sex, National_Insurance_Number, Position, Salary, hour_week, Salary_Scale, Paid_monthly_or_week, Ward)
                                VALUES (@NextStaffID, @FirstName, @LastName, @DOB, @Permanent_or_temporary, @Phone, @Email, @Address, @Sex, @NIN, @Position, @Salary, @WorkingHour, @SalaryScale, @PaidType, @Ward);

                                -- Then, insert into Qualifications table
                                INSERT INTO Qualifications (StaffID, Type, Date, Institution)
                                VALUES (@NextStaffID, @QualificationType, @QualificationDate, @Institution);

                                -- Finally, insert into Experience table
                                INSERT INTO Experience (Staff_ID, Position, Start_Date, Finish_Date, Organization)
                                VALUES (@NextStaffID, @ExperiencePosition, @ExperienceStartDate, @ExperienceFinishDate, @Organization);

                                COMMIT;"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Add parameters to avoid SQL Injection
                command.Parameters.AddWithValue("@NextStaffID", nextStaffID)
                command.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim())
                command.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim())
                command.Parameters.AddWithValue("@DOB", datePickerDOB.Value)
                command.Parameters.AddWithValue("@Permanent_or_temporary", txtPoT.Text.Trim())
                command.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim())
                command.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
                command.Parameters.AddWithValue("@Address", txtAddress.Text.Trim())
                command.Parameters.AddWithValue("@Sex", txtSex.Text.Trim())
                command.Parameters.AddWithValue("@NIN", txtNIN.Text.Trim())
                command.Parameters.AddWithValue("@Position", txtPosition.Text.Trim())
                command.Parameters.AddWithValue("@Salary", Decimal.Parse(txtSalary.Text.Trim()))
                command.Parameters.AddWithValue("@WorkingHour", Integer.Parse(txtWorkingHour.Text.Trim()))
                command.Parameters.AddWithValue("@SalaryScale", Decimal.Parse(txtSalaryScale.Text.Trim()))
                command.Parameters.AddWithValue("@PaidType", txtPaidType.Text.Trim())
                command.Parameters.AddWithValue("@Ward", Integer.Parse(txtWard.Text.Trim()))

                ' Qualification parameters
                command.Parameters.AddWithValue("@QualificationType", txtQualificationType.Text.Trim())
                command.Parameters.AddWithValue("@QualificationDate", dateQualificationDate.Value)
                command.Parameters.AddWithValue("@Institution", txtInstitution.Text.Trim())

                ' Experience parameters
                command.Parameters.AddWithValue("@ExperiencePosition", txtExperiencePosition.Text.Trim())
                command.Parameters.AddWithValue("@ExperienceStartDate", dateExperienceStartDate.Value)
                command.Parameters.AddWithValue("@ExperienceFinishDate", dateExperienceFinishDate.Value)
                command.Parameters.AddWithValue("@Organization", txtExperienceOrganization.Text.Trim())

                ' Open connection and execute the query
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
            End Using
        End Using

        ' Notify the user
        MessageBox.Show("New staff record added successfully!")
    End Sub

    Public Sub RefreshStaffList(staffListGrid As DataGridView)
        ' Your logic for refreshing the grid, similar to what was described previously
        Dim query As String = "SELECT Staff.StaffID, Staff.FirstName, Staff.LastName, Staff.Sex, Staff.Date_of_birth, " &
                      "Qualifications.Type AS QualificationType, Qualifications.Date AS QualificationDate, Qualifications.Institution AS QualificationInstitution, " &
                      "Experience.Position AS ExperiencePosition, Experience.Start_Date AS ExperienceStartDate, Experience.Finish_Date AS ExperienceFinishDate, Experience.Organization AS ExperienceOrganization " &
                      "FROM Staff " &
                      "LEFT JOIN Qualifications ON Staff.StaffID = Qualifications.StaffID " &
                      "LEFT JOIN Experience ON Staff.StaffID = Experience.Staff_ID"


        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim adapter As New SqlDataAdapter(command)
                Dim staffData As New DataTable()
                adapter.Fill(staffData)

                ' Bind the new data to the grid
                staffListGrid.DataSource = staffData
            End Using
        End Using
    End Sub
    Public Sub LoadStaffDataToEdit(staffID As Integer, mainPanel As MainPanel)
        ' Query to select staff details including qualifications and experience
        Dim query As String = "SELECT s.*, q.Type AS QualificationType, q.Institution AS QualificationInstitution, " &
                          "q.Date AS QualificationDate, e.Position AS ExperiencePosition, e.Organization AS ExperienceOrganization, " &
                          "e.Start_Date AS ExperienceStartDate, e.Finish_Date AS ExperienceFinishDate " &
                          "FROM STAFF s " &
                          "LEFT JOIN Qualifications q ON s.StaffID = q.StaffID " &
                          "LEFT JOIN Experience e ON s.StaffID = e.Staff_ID " &
                          "WHERE s.StaffID = @StaffID"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@StaffID", staffID)

                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Load staff data into the form fields
                        mainPanel.txtID_staff_edit1.Text = reader("StaffID").ToString()
                        mainPanel.txtFirstName_staff_edit1.Text = reader("FirstName").ToString()
                        mainPanel.txtLastName_staff_edit1.Text = reader("LastName").ToString()
                        mainPanel.datePickerDOB_staff_edit1.Value = Convert.ToDateTime(reader("Date_of_birth"))
                        mainPanel.txtPot_staff_edit1.Text = reader("Permanent_or_temporary").ToString()
                        mainPanel.txtPhone_staff_edit1.Text = reader("Phone_number").ToString()
                        mainPanel.txtEmail_staff_edit1.Text = reader("email").ToString()
                        mainPanel.txtAddress_staff_edit1.Text = reader("Address").ToString()
                        mainPanel.txtSex_staff_edit1.Text = reader("Sex").ToString()
                        mainPanel.txtNIN_staff_edit1.Text = reader("National_Insurance_Number").ToString()
                        mainPanel.txtPosition_staff_edit1.Text = reader("Position").ToString()
                        mainPanel.txtSalary_staff_edit1.Text = reader("Salary").ToString()
                        mainPanel.txtWorkingHour_staff_edit1.Text = reader("hour_week").ToString()
                        mainPanel.txtSalaryScale_staff_edit1.Text = reader("Salary_Scale").ToString()
                        mainPanel.txtPaidType_staff_edit1.Text = reader("Paid_monthly_or_week").ToString()
                        mainPanel.txtWard_staff_edit1.Text = reader("Ward").ToString()

                        ' Load qualification data
                        mainPanel.txtQualificationType_edit1.Text = reader("QualificationType").ToString()
                        mainPanel.txtQualificationInstitution_edit1.Text = reader("QualificationInstitution").ToString()
                        mainPanel.dateQualificationDate_edit1.Value = Convert.ToDateTime(reader("QualificationDate"))

                        ' Load experience data
                        mainPanel.txtExperiencePosition_edit1.Text = reader("ExperiencePosition").ToString()
                        mainPanel.txtExperienceOrganization_edit1.Text = reader("ExperienceOrganization").ToString()
                        mainPanel.dateExperienceStartDate_edit1.Value = Convert.ToDateTime(reader("ExperienceStartDate"))
                        mainPanel.dateExperienceFinishDate_edit1.Value = Convert.ToDateTime(reader("ExperienceFinishDate"))
                    End If
                End Using
            End Using
        End Using
    End Sub

    Public Sub UpdateStaffRecord(mainPanel As MainPanel)
        ' Update query for staff, qualification, and experience
        Dim query As String = "BEGIN TRANSACTION; " &
                          "UPDATE STAFF SET FirstName = @FirstName, LastName = @LastName, Date_of_birth = @DOB, Permanent_or_temporary = @Permanent_or_temporary, " &
                          "Phone_number = @Phone, email = @Email, Address = @Address, Sex = @Sex, National_Insurance_Number = @NIN, Position = @Position, " &
                          "Salary = @Salary, hour_week = @WorkingHour, Salary_Scale = @SalaryScale, Paid_monthly_or_week = @PaidType, Ward = @Ward WHERE StaffID = @StaffID; " &
                          "UPDATE Qualifications SET Type = @QualificationType, Institution = @QualificationInstitution, Date = @QualificationDate WHERE StaffID = @StaffID; " &
                          "UPDATE Experience SET Position = @ExperiencePosition, Organization = @ExperienceOrganization, Start_Date = @ExperienceStartDate, Finish_Date = @ExperienceFinishDate WHERE Staff_ID = @StaffID; " &
                          "COMMIT;"


        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Add parameters for staff data
                command.Parameters.AddWithValue("@StaffID", mainPanel.txtID_staff_edit.Text)
                command.Parameters.AddWithValue("@FirstName", mainPanel.txtFirstName_staff_edit.Text.Trim())
                command.Parameters.AddWithValue("@LastName", mainPanel.txtLastName_staff_edit.Text.Trim())
                command.Parameters.AddWithValue("@DOB", mainPanel.datePickerDOB_staff_edit.Value)
                command.Parameters.AddWithValue("@Permanent_or_temporary", mainPanel.txtPot_staff_edit.Text.Trim())
                command.Parameters.AddWithValue("@Phone", mainPanel.txtPhone_staff_edit.Text.Trim())
                command.Parameters.AddWithValue("@Email", mainPanel.txtEmail_staff_edit.Text.Trim())
                command.Parameters.AddWithValue("@Address", mainPanel.txtAddress_staff_edit.Text.Trim())
                command.Parameters.AddWithValue("@Sex", mainPanel.txtSex_staff_edit.Text.Trim())
                command.Parameters.AddWithValue("@NIN", mainPanel.txtNIN_staff_edit.Text.Trim())
                command.Parameters.AddWithValue("@Position", mainPanel.txtPosition_staff_edit.Text.Trim())
                command.Parameters.AddWithValue("@Salary", Decimal.Parse(mainPanel.txtSalary_staff_edit.Text.Trim()))
                command.Parameters.AddWithValue("@WorkingHour", Integer.Parse(mainPanel.txtWorkingHour_staff_edit.Text.Trim()))
                command.Parameters.AddWithValue("@SalaryScale", Decimal.Parse(mainPanel.txtSalaryScale_staff_edit.Text.Trim()))
                command.Parameters.AddWithValue("@PaidType", mainPanel.txtPaidType_staff_edit.Text.Trim())
                command.Parameters.AddWithValue("@Ward", Integer.Parse(mainPanel.txtWard_staff_edit.Text.Trim()))

                ' Add parameters for qualification data
                command.Parameters.AddWithValue("@QualificationType", mainPanel.txtQualificationType_edit.Text.Trim())
                command.Parameters.AddWithValue("@QualificationInstitution", mainPanel.txtQualificationInstitution_edit.Text.Trim())
                command.Parameters.AddWithValue("@QualificationDate", mainPanel.dateQualificationDate_edit.Value)

                ' Add parameters for experience data
                command.Parameters.AddWithValue("@ExperiencePosition", mainPanel.txtExperiencePosition_edit.Text.Trim())
                command.Parameters.AddWithValue("@ExperienceOrganization", mainPanel.txtExperienceOrganization_edit.Text.Trim())
                command.Parameters.AddWithValue("@ExperienceStartDate", mainPanel.dateExperienceStartDate_edit.Value)
                command.Parameters.AddWithValue("@ExperienceFinishDate", mainPanel.dateExperienceFinishDate_edit.Value)

                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                connection.Close()

                ' Notify user
                If rowsAffected > 0 Then
                    MessageBox.Show("Staff record updated successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No changes were made to the staff record.", "Update Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        End Using
    End Sub

    Public Sub SwitchPanel(mainPanel As MainPanel, showEditPanel As Boolean, Optional showEdit2Panel As Boolean = False)
        mainPanel.pnl_Staff_Edit_1.Visible = True
        mainPanel.pnl_Staff_List.Visible = Not (showEditPanel Or showEdit2Panel)
        mainPanel.pnl_Staff_Add_1.Visible = showEditPanel
        mainPanel.pnl_Staff_Edit_2.Visible = showEdit2Panel
    End Sub
    ' Function to delete staff record
    Public Sub DeleteStaffRecord(staffID As Integer)
        Dim query As String = "DELETE FROM STAFF WHERE StaffID = @StaffID"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@StaffID", staffID)

                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()

                MessageBox.Show("Staff record deleted successfully.", "Deletion Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End Using
    End Sub

End Class
