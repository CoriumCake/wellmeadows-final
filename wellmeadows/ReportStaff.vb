Public Class ReportShow
    Public Sub LoadStaffReport(staffID As Integer)
    End Sub

    Private Sub ReportShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbWellsmeadowsHospitalG19DataSet.vwStaffFullDetails' table. You can move, or remove it, as needed.
        Me.VwStaffFullDetailsTableAdapter.Fill(Me.DbWellsmeadowsHospitalG19DataSet.vwStaffFullDetails)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class