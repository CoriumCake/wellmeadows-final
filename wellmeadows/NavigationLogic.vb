Public Class NavigationLogic
    Private mainPanel As MainPanel

    Public Sub New(mainPanel As MainPanel)
        Me.mainPanel = mainPanel
    End Sub

    ' Method to hide all content panels
    Public Sub HideAllPanels()
        mainPanel.panel_Dashboard.Visible = False
        mainPanel.panel_Staff.Visible = False
        mainPanel.panel_Patient.Visible = False
        mainPanel.panel_Ward.Visible = False
        mainPanel.panel_Supplier.Visible = False
        mainPanel.panel_Appointment.Visible = False
        mainPanel.panel_Profile.Visible = False
        mainPanel.pnl_Staff_Add_1.Visible = False
        mainPanel.pnl_Staff_Add_2.Visible = False
        mainPanel.pnl_Staff_Edit_1.Visible = False
        mainPanel.pnl_Staff_Edit_2.Visible = False
    End Sub

    ' Method to reset label colors to default
    Public Sub ResetLabelColors()
        mainPanel.lbldashboard.ForeColor = Color.White
        mainPanel.lblstaff.ForeColor = Color.White
        mainPanel.lblpatient.ForeColor = Color.White
        mainPanel.lblward.ForeColor = Color.White
        mainPanel.lblsupplier.ForeColor = Color.White
        mainPanel.lblappoint.ForeColor = Color.White
        mainPanel.lbllogout.ForeColor = Color.White
        mainPanel.lblhelp.ForeColor = Color.White
    End Sub

    ' Dashboard Click event handler
    Public Sub DashboardClick()
        HideAllPanels()
        mainPanel.panel_Dashboard.Visible = True
        ResetLabelColors()
        mainPanel.lbldashboard.ForeColor = Color.Orange
    End Sub

    ' Staff Click event handler
    Public Sub StaffClick()
        HideAllPanels()
        mainPanel.panel_Staff.Visible = True
        mainPanel.pnl_Staff_List.Visible = True
        ResetLabelColors()
        mainPanel.lblstaff.ForeColor = Color.Orange
    End Sub

    ' Patient Click event handler
    Public Sub PatientClick()
        HideAllPanels()
        mainPanel.panel_Patient.Visible = True
        ResetLabelColors()
        mainPanel.lblpatient.ForeColor = Color.Orange
    End Sub

    ' Ward Click event handler
    Public Sub WardClick()
        HideAllPanels()
        mainPanel.panel_Ward.Visible = True
        ResetLabelColors()
        mainPanel.lblward.ForeColor = Color.Orange
    End Sub

    ' Supplier Click event handler
    Public Sub SupplierClick()
        HideAllPanels()
        mainPanel.panel_Supplier.Visible = True
        ResetLabelColors()
        mainPanel.lblsupplier.ForeColor = Color.Orange
    End Sub

    ' Appointment Click event handler
    Public Sub AppointmentClick()
        HideAllPanels()
        mainPanel.panel_Appointment.Visible = True
        ResetLabelColors()
        mainPanel.lblappoint.ForeColor = Color.Orange
    End Sub

    ' Logout Click event handler
    Public Sub LogoutClick()
        Dim loginForm As New Form1()
        loginForm.StartPosition = FormStartPosition.CenterScreen
        loginForm.Show()
        mainPanel.Hide()
    End Sub

    ' Help Click event handler
    Public Sub HelpClick()
        MessageBox.Show("Contact : g19wellmeadows@gmail.com", "Help", MessageBoxButtons.OK)
    End Sub
End Class
