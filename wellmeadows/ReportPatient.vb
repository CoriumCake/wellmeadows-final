Public Class ReportPatient
    Private Sub ReportPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbWellsmeadowsHospitalG19DataSet.Inpatients' table. You can move, or remove it, as needed.
        Me.InpatientsTableAdapter.Fill(Me.DbWellsmeadowsHospitalG19DataSet.Inpatients)
        'TODO: This line of code loads data into the 'DbWellsmeadowsHospitalG19DataSet.Patients' table. You can move, or remove it, as needed.
        Me.PatientsTableAdapter.Fill(Me.DbWellsmeadowsHospitalG19DataSet.Patients)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class