<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportPatient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.InpatientsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbWellsmeadowsHospitalG19DataSet = New wellmeadows.dbWellsmeadowsHospitalG19DataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PatientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientsTableAdapter = New wellmeadows.dbWellsmeadowsHospitalG19DataSetTableAdapters.PatientsTableAdapter()
        Me.InpatientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InpatientsTableAdapter = New wellmeadows.dbWellsmeadowsHospitalG19DataSetTableAdapters.InpatientsTableAdapter()
        Me.OutpatientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.vwPatientLocalDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.InpatientsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbWellsmeadowsHospitalG19DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InpatientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutpatientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vwPatientLocalDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InpatientsBindingSource1
        '
        Me.InpatientsBindingSource1.DataMember = "Inpatients"
        Me.InpatientsBindingSource1.DataSource = Me.DbWellsmeadowsHospitalG19DataSet
        '
        'DbWellsmeadowsHospitalG19DataSet
        '
        Me.DbWellsmeadowsHospitalG19DataSet.DataSetName = "dbWellsmeadowsHospitalG19DataSet"
        Me.DbWellsmeadowsHospitalG19DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.InpatientsBindingSource1
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "wellmeadows.ReportPatie.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1428, 844)
        Me.ReportViewer1.TabIndex = 0
        '
        'PatientsBindingSource
        '
        Me.PatientsBindingSource.DataMember = "Patients"
        Me.PatientsBindingSource.DataSource = Me.DbWellsmeadowsHospitalG19DataSet
        '
        'PatientsTableAdapter
        '
        Me.PatientsTableAdapter.ClearBeforeFill = True
        '
        'InpatientsBindingSource
        '
        Me.InpatientsBindingSource.DataMember = "Inpatients"
        Me.InpatientsBindingSource.DataSource = Me.DbWellsmeadowsHospitalG19DataSet
        '
        'InpatientsTableAdapter
        '
        Me.InpatientsTableAdapter.ClearBeforeFill = True
        '
        'OutpatientsBindingSource
        '
        Me.OutpatientsBindingSource.DataMember = "Outpatients"
        Me.OutpatientsBindingSource.DataSource = Me.DbWellsmeadowsHospitalG19DataSet
        '
        'vwPatientLocalDetailsBindingSource
        '
        Me.vwPatientLocalDetailsBindingSource.DataMember = "vwPatientLocalDetails"
        Me.vwPatientLocalDetailsBindingSource.DataSource = Me.DbWellsmeadowsHospitalG19DataSet
        '
        'ReportPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1428, 844)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReportPatient"
        Me.Text = "ReportPatient"
        CType(Me.InpatientsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbWellsmeadowsHospitalG19DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InpatientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutpatientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vwPatientLocalDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DbWellsmeadowsHospitalG19DataSet As dbWellsmeadowsHospitalG19DataSet
    Friend WithEvents PatientsBindingSource As BindingSource
    Friend WithEvents PatientsTableAdapter As dbWellsmeadowsHospitalG19DataSetTableAdapters.PatientsTableAdapter
    Friend WithEvents InpatientsBindingSource As BindingSource
    Friend WithEvents InpatientsTableAdapter As dbWellsmeadowsHospitalG19DataSetTableAdapters.InpatientsTableAdapter
    Friend WithEvents OutpatientsBindingSource As BindingSource
    Friend WithEvents InpatientsBindingSource1 As BindingSource
    Friend WithEvents vwPatientLocalDetailsBindingSource As BindingSource
End Class
