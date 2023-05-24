

Public Class FrmVistaPrevia

    Private Sub FrmVistaPrevia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsRegistros.Monitores' table. You can move, or remove it, as needed.
        Me.MonitoresTableAdapter.Fill(Me.DsRegistros.Monitores)

        Me.ReportViewer1.RefreshReport
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class

