<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportShow
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DbWellsmeadowsHospitalG19DataSet = New wellmeadows.dbWellsmeadowsHospitalG19DataSet()
        Me.VwStaffFullDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwStaffFullDetailsTableAdapter = New wellmeadows.dbWellsmeadowsHospitalG19DataSetTableAdapters.vwStaffFullDetailsTableAdapter()
        CType(Me.DbWellsmeadowsHospitalG19DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwStaffFullDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.VwStaffFullDetailsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "wellmeadows.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1428, 844)
        Me.ReportViewer1.TabIndex = 0
        '
        'DbWellsmeadowsHospitalG19DataSet
        '
        Me.DbWellsmeadowsHospitalG19DataSet.DataSetName = "dbWellsmeadowsHospitalG19DataSet"
        Me.DbWellsmeadowsHospitalG19DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwStaffFullDetailsBindingSource
        '
        Me.VwStaffFullDetailsBindingSource.DataMember = "vwStaffFullDetails"
        Me.VwStaffFullDetailsBindingSource.DataSource = Me.DbWellsmeadowsHospitalG19DataSet
        '
        'VwStaffFullDetailsTableAdapter
        '
        Me.VwStaffFullDetailsTableAdapter.ClearBeforeFill = True
        '
        'ReportShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1428, 844)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReportShow"
        Me.Text = "ReportShow"
        CType(Me.DbWellsmeadowsHospitalG19DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwStaffFullDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DbWellsmeadowsHospitalG19DataSet As dbWellsmeadowsHospitalG19DataSet
    Friend WithEvents VwStaffFullDetailsBindingSource As BindingSource
    Friend WithEvents VwStaffFullDetailsTableAdapter As dbWellsmeadowsHospitalG19DataSetTableAdapters.vwStaffFullDetailsTableAdapter
End Class
