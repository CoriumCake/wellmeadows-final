Imports System.Data.SqlClient

Public Class MainPanel

    Private dbHelper As New DatabaseHelper()

    ' Method to hide all content panels
    Private Sub HideAllPanels()
        panel_Dashboard.Visible = False
        panel_Staff.Visible = False
        panel_Patient.Visible = False
        panel_Ward.Visible = False
        panel_Supplier.Visible = False
        panel_Appointment.Visible = False
        panel_Profile.Visible = False
        pnl_Staff_Edit_1.Visible = False
        pnl_Staff_List.Visible = False
    End Sub

    ' Method to reset label colors to default
    Private Sub ResetLabelColors()
        lbldashboard.ForeColor = Color.White
        lblstaff.ForeColor = Color.White
        lblpatient.ForeColor = Color.White
        lblward.ForeColor = Color.White
        lblsupplier.ForeColor = Color.White
        lblappoint.ForeColor = Color.White
        lbllogout.ForeColor = Color.White
        lblhelp.ForeColor = Color.White
    End Sub

    Private Sub UpdateUserLabelsInAllPanels(control As Control)
        ' Loop through all controls within the provided control (e.g., a Panel or the form itself)
        For Each innerCtrl As Control In control.Controls
            ' If the control is a Label
            If TypeOf innerCtrl Is Label Then
                ' If the label's name contains "FullName", set it to LoggedInUserFullName
                If innerCtrl.Name.ToLower().Contains("fullname") Then
                    innerCtrl.Text = SessionManager.LoggedInUserFullName
                End If

                ' If the label's name contains "Position", set it to LoggedInUserPosition
                If innerCtrl.Name.ToLower().Contains("position") Then
                    innerCtrl.Text = SessionManager.LoggedInUserPosition
                End If
            End If

            ' Recursively call this method if the control contains other controls (e.g., Panel, GroupBox)
            If innerCtrl.HasChildren Then
                UpdateUserLabelsInAllPanels(innerCtrl)
            End If
        Next
    End Sub

    ' Form Load event to initialize the default panel
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbWellsmeadowsHospitalG19DataSet.vwStaffFullDetails' table. You can move, or remove it, as needed.
        ' Me.VwStaffFullDetailsTableAdapter.Fill(Me.DbWellsmeadowsHospitalG19DataSet.vwStaffFullDetails)

        ' Update labels for all panels
        UpdateUserLabelsInAllPanels(Me)

        ' Load the user's picture if available
        If SessionManager.LoggedInUserPicture IsNot Nothing Then
            Using ms As New IO.MemoryStream(SessionManager.LoggedInUserPicture)
                CircularPictureBox1.Image = Image.FromStream(ms)
            End Using
        Else
            ' Set a default picture from resources
            CircularPictureBox1.Image = My.Resources._99999 ' Replace with your actual default image resource
        End If

        ' Load data into tables
        ' Me.PatientsTableAdapter.Fill(Me.DbWellsmeadowsHospitalG19DataSet.Patients)
        '  Me.STAFFTableAdapter.Fill(Me.DbWellsmeadowsHospitalG19DataSet.STAFF)

        ' Initialize panel visibility
        HideAllPanels()
        panel_Dashboard.Visible = True
        ResetLabelColors()
        lbldashboard.ForeColor = Color.Orange
    End Sub

    ' Sidebar label click events
    Private Sub lblDashboard_Click(sender As Object, e As EventArgs) Handles lbldashboard.Click
        HideAllPanels()
        panel_Dashboard.Visible = True
        ResetLabelColors()
        lbldashboard.ForeColor = Color.Orange  ' Set active color
    End Sub

    Private Sub lblStaff_Click(sender As Object, e As EventArgs) Handles lblstaff.Click
        HideAllPanels()
        panel_Staff.Visible = True
        pnl_Staff_List.Visible = True
        ResetLabelColors()
        lblstaff.ForeColor = Color.Orange  ' Set active color
    End Sub

    Private Sub lblPatient_Click(sender As Object, e As EventArgs) Handles lblpatient.Click
        HideAllPanels()
        panel_Patient.Visible = True
        ResetLabelColors()
        lblpatient.ForeColor = Color.Orange  ' Set active color
    End Sub

    Private Sub lblWard_Click(sender As Object, e As EventArgs) Handles lblward.Click
        HideAllPanels()
        panel_Ward.Visible = True
        ResetLabelColors()
        lblward.ForeColor = Color.Orange  ' Set active color
    End Sub

    Private Sub lblSupplier_Click(sender As Object, e As EventArgs) Handles lblsupplier.Click
        HideAllPanels()
        panel_Supplier.Visible = True
        ResetLabelColors()
        lblsupplier.ForeColor = Color.Orange  ' Set active color
    End Sub

    Private Sub lblAppointment_Click(sender As Object, e As EventArgs) Handles lblappoint.Click
        HideAllPanels()
        panel_Appointment.Visible = True
        ResetLabelColors()
        lblappoint.ForeColor = Color.Orange  ' Set active color
    End Sub

    Private Sub lbllogout_Click(sender As Object, e As EventArgs) Handles lbllogout.Click
        ' Logic for logging out
        Dim loginForm As New Form1() ' Assuming you have a LoginForm or LoginPage
        loginForm.StartPosition = FormStartPosition.CenterScreen
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub lblhelp_Click(sender As Object, e As EventArgs) Handles lblhelp.Click
        MessageBox.Show("Contact : g19wellmeadows@gmail.com", "Help", MessageBoxButtons.OK)
    End Sub

    Private Sub CircularPictureBox2_Click(sender As Object, e As EventArgs)
        HideAllPanels()
        panel_Profile.Visible = True
        ResetLabelColors()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        HideAllPanels()
        panel_Dashboard.Visible = True
        ResetLabelColors()
        lbldashboard.ForeColor = Color.Orange  ' Set active color
    End Sub

    Private Sub CircularPictureBox4_Click(sender As Object, e As EventArgs)
        HideAllPanels()
        panel_Profile.Visible = True
        ResetLabelColors()
    End Sub

    Private Sub staff_list_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles staff_list_grid.CellClick
        ' Ensure the row index is valid
        If e.RowIndex >= 0 Then
            ' Clear previous selections
            staff_list_grid.ClearSelection()

            ' Select the entire row
            staff_list_grid.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub CircularPictureBox1_Click(sender As Object, e As EventArgs) Handles CircularPictureBox1.Click
        HideAllPanels()
        panel_Profile.Visible = True
        ResetLabelColors()
    End Sub

    ' Function to search staff by qualification or experience
    Public Function SearchStaffByQualificationOrWork(searchTerm As String) As DataTable
        Dim query As String = "SELECT *
                          FROM vwStaffFullDetails " &
                          "WHERE QualificationType LIKE '%' + @SearchTerm + '%' " &
                          "OR QualificationInstitution LIKE '%' + @SearchTerm + '%' " &
                          "OR ExperiencePosition LIKE '%' + @SearchTerm + '%' " &
                          "OR ExperienceOrganization LIKE '%' + @SearchTerm + '%' " &
                          "OR FirstName LIKE '%' + @SearchTerm + '%' " &
                          "OR LastName LIKE '%' + @SearchTerm + '%' " &
                          "OR StaffPosition LIKE '%' + @SearchTerm + '%'"

        Dim connectionString As String = "Data Source=graphite\DB1101171;Initial Catalog=dbWellsmeadowsHospitalG19;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"
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

    ' Handle the Enter key for search
    Private Sub RoundCornerTextbox10_KeyDown(sender As Object, e As KeyEventArgs) Handles RoundCornerTextbox10.KeyDown
        ' Debug to check if the event is triggered
        Debug.WriteLine("KeyDown event fired! Key: " & e.KeyCode.ToString())

        ' Check if the pressed key is Enter
        If e.KeyCode = Keys.Enter Then
            ' Debug to check if Enter key is detected
            Debug.WriteLine("Enter key pressed!")

            ' Call the search function when Enter is pressed
            Dim searchTerm As String = RoundCornerTextbox10.Text.Trim()

            ' Call the function to search based on qualification or previous work
            Dim results As DataTable = SearchStaffByQualificationOrWork(searchTerm)

            ' Bind the results to the DataGridView or display as needed
            If results IsNot Nothing Then
                staff_list_grid.DataSource = results
            End If

            ' Optionally prevent the "ding" sound when pressing Enter
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btn_staff_add_Click(sender As Object, e As EventArgs) Handles btn_staff_add.Click
        ' Hide all other panels first
        HideAllPanels()

        ' Now make sure the staff edit panel is shown
        panel_Staff.Visible = True
        pnl_Staff_List.Visible = False
        pnl_Staff_Edit_1.Visible = True

        ' Reset label colors and set the active label color
        ResetLabelColors()
        lblstaff.ForeColor = Color.Orange  ' Set active color
    End Sub

    Private Sub pnl_Staff_Edit_2_Paint(sender As Object, e As PaintEventArgs) Handles pnl_Staff_Edit_2.Paint

    End Sub
End Class
