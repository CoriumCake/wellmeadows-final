Imports System.Data.SqlClient
Imports System.Xml.XPath

Public Class MainPanel
    Private staffPanelLogic As New StaffPanelLogic()
    Private navigationLogic As NavigationLogic
    Private patientPanelLogic As New PatientPanelLogic()
    Private dbHelper As New DatabaseHelper()
    Private connectionString As String = "Data Source=graphite\DB1101171;Initial Catalog=dbWellsmeadowsHospitalG19;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeAsync()
        Dim powerBIUrl As String = "https://app.powerbi.com/view?r=eyJrIjoiMGI1M2JhYzYtNmY1OC00NGJlLWI1MWEtNTM3MWM5MmY3Yzc2IiwidCI6ImU0OWRhNTdiLWI2MDItNDY2Ny1iMjU3LWYyMjgxOWUwZjA5MCIsImMiOjEwfQ%3D%3D"

        WebView21.Source = New Uri(powerBIUrl)

        ' Pass a reference of MainPanel to NavigationLogic
        navigationLogic = New NavigationLogic(Me)

        ' Load datasets and update labels
        Me.VwPatientLocalDetailsTableAdapter.Fill(Me.DbWellsmeadowsHospitalG19DataSet.vwPatientLocalDetails)
        Me.InpatientsTableAdapter.Fill(Me.DbWellsmeadowsHospitalG19DataSet.Inpatients)
        Me.VwStaffFullDetailsTableAdapter.Fill(Me.DbWellsmeadowsHospitalG19DataSet.vwStaffFullDetails)
        Me.PatientsTableAdapter.Fill(Me.DbWellsmeadowsHospitalG19DataSet.Patients)
        Me.STAFFTableAdapter.Fill(Me.DbWellsmeadowsHospitalG19DataSet.STAFF)

        ' Initialize panels and labels (your existing logic)
        UpdateUserLabelsInAllPanels(Me)
        navigationLogic.HideAllPanels()
        panel_Dashboard.Visible = True
        navigationLogic.ResetLabelColors()
        lbldashboard.ForeColor = Color.Orange
    End Sub

    ' Sidebar label click events
    Private Sub lblDashboard_Click(sender As Object, e As EventArgs) Handles lbldashboard.Click
        navigationLogic.DashboardClick()
    End Sub

    Private Sub lblStaff_Click(sender As Object, e As EventArgs) Handles lblstaff.Click
        navigationLogic.StaffClick()
    End Sub

    Private Sub lblPatient_Click(sender As Object, e As EventArgs) Handles lblpatient.Click
        navigationLogic.PatientClick()
    End Sub

    Private Sub lblWard_Click(sender As Object, e As EventArgs) Handles lblward.Click
        navigationLogic.WardClick()
    End Sub

    Private Sub lblSupplier_Click(sender As Object, e As EventArgs) Handles lblsupplier.Click
        navigationLogic.SupplierClick()
    End Sub

    Private Sub lblAppointment_Click(sender As Object, e As EventArgs) Handles lblappoint.Click
        navigationLogic.AppointmentClick()
    End Sub

    Private Sub lbllogout_Click(sender As Object, e As EventArgs) Handles lbllogout.Click
        navigationLogic.LogoutClick()
    End Sub

    Private Sub lblhelp_Click(sender As Object, e As EventArgs) Handles lblhelp.Click
        navigationLogic.HelpClick()
    End Sub

    ' Method to update user labels in all panels
    Private Sub UpdateUserLabelsInAllPanels(control As Control)
        For Each innerCtrl As Control In control.Controls
            If TypeOf innerCtrl Is Label Then
                If innerCtrl.Name.ToLower().Contains("fullname") Then
                    innerCtrl.Text = SessionManager.LoggedInUserFullName
                End If
                If innerCtrl.Name.ToLower().Contains("position") Then
                    innerCtrl.Text = SessionManager.LoggedInUserPosition
                End If
            End If

            If innerCtrl.HasChildren Then
                UpdateUserLabelsInAllPanels(innerCtrl)
            End If
        Next
    End Sub

    ' Dashboard '
    Private Async Sub InitializeAsync()
        Await WebView21.EnsureCoreWebView2Async(Nothing)
    End Sub

    ' STAFF '
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles report_staff.Click

        ' Create an instance of the ReportForm
        Dim reportForm As New ReportShow()

        ' Show the report form
        reportForm.Show()

    End Sub
    Private Sub staff_add_save_btn_Click(sender As Object, e As EventArgs) Handles staff_add_save_btn.Click
        ' Add staff with qualifications and experience
        staffPanelLogic.AddStaff(
        txtFirstName_staff_add, txtLastName_staff_add, dateDoB_staff_add, txtPhone_staff_add, txtEmail_staff_add, txtAddress_staff_add, txtSex_staff_add, txtNIN_staff_add, txtPosition_staff_add,
        txtSalary_staff_add, txtWorkhour_staff_add, txtSalaryScale_staff_add, txtWOM_staff_add, txtPOT_staff_add, txtWard_staff_add,
        txtQualificationType_staff_add, dateQualificationDate_staff_add, txtInstitution_staff_add,
        txtExperiencePosition_staff_add, dateExperienceStartDate_staff_add1, dateExperienceFinishDate_staff_add, txtExperienceOrganization_staff_add)

        ' Refresh staff list along with qualifications and experience
        RefreshStaffListGrid()

        ' Clear form and switch back to list view
        ClearStaffForm()
        pnl_Staff_Add_2.Visible = False
        pnl_Staff_List.Visible = True
    End Sub

    Private Sub ClearStaffForm()
        staffPanelLogic.ClearStaffForm(pnl_Staff_Edit_1)
    End Sub
    Private Sub RefreshStaffListGrid()
        staffPanelLogic.RefreshStaffList(staff_list_grid)
    End Sub

    Private Sub RoundCornerTextbox10_KeyDown(sender As Object, e As KeyEventArgs) Handles staff_search.KeyDown
        ' Check if the pressed key is Enter
        If e.KeyCode = Keys.Enter Then
            ' Call the search function when Enter is pressed
            Dim searchTerm As String = staff_search.Text.Trim()

            ' Create an instance of StaffPanelLogic to call the search method
            Dim staffLogic As New StaffPanelLogic()
            Dim results As DataTable = staffLogic.SearchStaffByQualificationOrWork(searchTerm)

            ' Bind the results to the DataGridView or display as needed
            If results IsNot Nothing Then
                staff_list_grid.DataSource = results
            End If
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btn_staff_add_Click(sender As Object, e As EventArgs) Handles staff_add_btn.Click
        pnl_Staff_Edit_1.Visible = False
        pnl_Staff_List.Visible = False
        pnl_Staff_Add_1.Visible = True
        pnl_Staff_Edit_2.Visible = False

        ' Fetch the next StaffID and update the txtID field
        txtID_staff_add.Text = staffPanelLogic.GetNextStaffID().ToString()
    End Sub
    Private Sub Staff_Next_btn_Click(sender As Object, e As EventArgs) Handles Staff_Next_btn.Click
        pnl_Staff_Add_1.Visible = False
        pnl_Staff_Add_2.Visible = True
    End Sub
    Private Sub Staff_Back_btn_Click(sender As Object, e As EventArgs) Handles Staff_Back_btn.Click
        pnl_Staff_Add_2.Visible = False
        pnl_Staff_Add_1.Visible = True
    End Sub

    ' Delete STAFF
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles staff_del_btn.Click
        If staff_list_grid.SelectedRows.Count > 0 Then
            Dim staffID As Integer = Convert.ToInt32(staff_list_grid.SelectedRows(0).Cells(0).Value)
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this staff record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                staffPanelLogic.DeleteStaffRecord(staffID)
                RefreshStaffListGrid()
            End If
        Else
            MessageBox.Show("Please select a staff record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles staff_back_btn_1.Click
        pnl_Staff_Edit_1.Visible = False
        pnl_Staff_List.Visible = True
    End Sub

    Private Sub staff_edit_btn_1_Click(sender As Object, e As EventArgs) Handles staff_edit_btn.Click
        If staff_list_grid.SelectedRows.Count > 0 Then
            Dim staffID As Integer = Convert.ToInt32(staff_list_grid.SelectedRows(0).Cells(0).Value)
            staffPanelLogic.LoadStaffDataToEdit(staffID, Me)
            staffPanelLogic.SwitchPanel(Me, True)
        Else
            MessageBox.Show("Please select a staff record to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub staff_edit_btn_back_2_Click(sender As Object, e As EventArgs) Handles staff_edit_btn_back_2.Click
        staffPanelLogic.SwitchPanel(Me, True)
    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click
        staffPanelLogic.SwitchPanel(Me, False, True)
    End Sub

    Private Sub staff_edit_btn_save_Click(sender As Object, e As EventArgs) Handles staff_edit_btn_save.Click
        ' Update the staff record in the database
        staffPanelLogic.UpdateStaffRecord(Me)

        ' Refresh the DataGridView
        RefreshStaffListGrid()

        ' Switch back to the list panel
        pnl_Staff_Edit_2.Visible = False
        pnl_Staff_List.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        staffPanelLogic.SwitchPanel(Me, False)
    End Sub

    'Patient'
    Private Sub RoundCornerTextbox42_KeyDown(sender As Object, e As KeyEventArgs) Handles patient_search.KeyDown
        ' Check if the pressed key is Enter
        If e.KeyCode = Keys.Enter Then
            ' Call the search function when Enter is pressed
            Dim searchTerm As String = patient_search.Text.Trim()

            ' Create an instance of StaffPanelLogic to call the search method
            Dim PatientLogic As New PatientPanelLogic()
            Dim results As DataTable = PatientLogic.SearchPatientByNameOrDetails(searchTerm)

            ' Bind the results to the DataGridView or display as needed
            If results IsNot Nothing Then
                patient_list_grid.DataSource = results
            End If
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub RefreshPatientList()
        patientPanelLogic.RefreshPatientList(patient_list_grid)
    End Sub
    Private Sub ClearPatientForm()
        patientPanelLogic.ClearPatientForm(pnl_Patient_add)
    End Sub

    Private Sub patient_add_btn_save_Click(sender As Object, e As EventArgs) Handles patient_add_btn_save.Click
        ' Add patient with personal and doctor information
        patientPanelLogic.AddPatient(
        txtFirstName_patient_add, txtLastName_patient_add, txtAddress_patient_add, txtSex_patient_add,
        txtPhone_patient_add, txtPatientID, datePickerDOB_patient_add, datePickerDateRegistered_patient,
        txtMaritalStatus_patient_add, txtNextOfKin_patient_add, txtDoctorFullName_patient_add,
        txtClinicNumber_patient_add, txtDoctorAddress_patient_add, txtDoctorPhone_patient_add)

        ' Refresh patient list after adding the new patient
        RefreshPatientList()

        ' Clear form and switch back to list view
        ClearPatientForm()
        pnl_Patient_add.Visible = False
        panel_Patient_list.Visible = True
        txtPatientID.Text = patientPanelLogic.GetNextPatientID().ToString()
    End Sub

    Private Sub patient_add_btn_Click(sender As Object, e As EventArgs) Handles patient_add_btn.Click
        panel_Patient_list.Visible = False
        pnl_Patient_add.Visible = True
        txtID_patient_add.Text = patientPanelLogic.GetNextPatientID().ToString()
    End Sub

    Private Sub patient_edit_btn_back_Click(sender As Object, e As EventArgs) Handles patient_edit_btn_back.Click
        pnl_Patient_edit.Visible = False
        panel_Patient_list.Visible = True
    End Sub

    Private Sub patient_edit_btn_Click(sender As Object, e As EventArgs) Handles patient_edit_btn.Click
        If patient_list_grid.SelectedRows.Count > 0 Then
            Dim PatientID As Integer = Convert.ToInt32(patient_list_grid.SelectedRows(0).Cells(0).Value)
            patientPanelLogic.LoadPatientDataToEdit(PatientID, Me)
            patientPanelLogic.SwitchPanel(Me, True)
        Else
            MessageBox.Show("Please select a staff record to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub patient_add_btn_back_Click(sender As Object, e As EventArgs) Handles patient_add_btn_back.Click
        pnl_Patient_edit.Visible = False
        panel_Patient_list.Visible = True
    End Sub

    Private Sub patient_del_btn_Click(sender As Object, e As EventArgs) Handles patient_del_btn.Click
        If patient_list_grid.SelectedRows.Count > 0 Then
            Dim PatientID As Integer = Convert.ToInt32(patient_list_grid.SelectedRows(0).Cells(0).Value)

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this patient record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                patientPanelLogic.DeletePatientRecord(PatientID)
                RefreshPatientList()
            End If
        Else
            MessageBox.Show("Please select a patient record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub patient_edit_btn_save_Click(sender As Object, e As EventArgs) Handles patient_edit_btn_save.Click
        ' Update the staff record in the database
        patientPanelLogic.UpdatePatient(Me)

        ' Refresh the DataGridView
        RefreshPatientList()

        ' Switch back to the list panel
        pnl_Patient_edit.Visible = False
        panel_Patient_list.Visible = True
    End Sub

    Private Sub patient_print_Click(sender As Object, e As EventArgs) Handles patient_print.Click
        ' Create an instance of the ReportForm
        Dim reportForm As New ReportPatient()

        ' Show the report form
        reportForm.Show()
    End Sub

    Private Sub Button19_Click_1(sender As Object, e As EventArgs) Handles Button19.Click
        pnl_Staff_Edit_1.Visible = False
        pnl_Staff_Edit_2.Visible = False
        pnl_Staff_List.Visible = True
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        pnl_Staff_Add_1.Visible = False
        pnl_Staff_List.Visible = True
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        pnl_Staff_Add_1.Visible = False
        pnl_Staff_Add_2.Visible = False
        pnl_Staff_Edit_1.Visible = False
        pnl_Staff_Edit_2.Visible = True
    End Sub
    'edit 2 go to edit 1'
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        pnl_Staff_Edit_2.Visible = False
        pnl_Staff_Add_1.Visible = False
        pnl_Staff_Add_2.Visible = False
        pnl_Staff_Edit_1.Visible = True
    End Sub
End Class
