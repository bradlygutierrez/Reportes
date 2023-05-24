<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVistaPrevia
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
        Me.DsRegistros = New MonitoresUCA.dsRegistros()
        Me.MonitoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MonitoresTableAdapter = New MonitoresUCA.dsRegistrosTableAdapters.MonitoresTableAdapter()
        CType(Me.DsRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonitoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "dsRegistros"
        ReportDataSource1.Value = Me.MonitoresBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MonitoresUCA.rptMonitores.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.ServerReport.ReportPath = "C:\DiseñoRPT\rptMonitores.rdlc"
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DsRegistros
        '
        Me.DsRegistros.DataSetName = "dsRegistros"
        Me.DsRegistros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MonitoresBindingSource
        '
        Me.MonitoresBindingSource.DataMember = "Monitores"
        Me.MonitoresBindingSource.DataSource = Me.DsRegistros
        '
        'MonitoresTableAdapter
        '
        Me.MonitoresTableAdapter.ClearBeforeFill = True
        '
        'FrmVistaPrevia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmVistaPrevia"
        Me.Text = "FrmVistaPrevia"
        CType(Me.DsRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonitoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DsRegistros As dsRegistros
    Friend WithEvents MonitoresBindingSource As BindingSource
    Friend WithEvents MonitoresTableAdapter As dsRegistrosTableAdapters.MonitoresTableAdapter
End Class
