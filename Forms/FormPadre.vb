Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports MonitoresUCA.My
Public Class program
    Public Shared Sub Main(args As String())
        Dim ap As New MyApplication()
        ap.Run(args)
    End Sub
End Class

Public Class FormPadre
    Private Sub FormularioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles opFormularioCRUD.Click
        Form1.Show()
    End Sub

    Private Sub FormPadre_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ArchivoCerrar_Click(sender As Object, e As EventArgs) Handles ArchivoCerrar.Click
        Me.Close()
    End Sub

    Public Sub verReporte(ByVal t As DataTable, ByVal ds As String, ByVal nombreRpt As String)
        Try
            Dim rpt As New ReportDataSource(ds, t)
            FrmVistaPrevia.ReportViewer1.LocalReport.DataSources.Clear()
            FrmVistaPrevia.ReportViewer1.LocalReport.DataSources.Add(rpt)
            FrmVistaPrevia.ReportViewer1.LocalReport.ReportPath = nombreRpt
            FrmVistaPrevia.ReportViewer1.LocalReport.Refresh()
            FrmVistaPrevia.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar")
        End Try
    End Sub

    Private Sub Report1_click(sender As Object, e As EventArgs) Handles opReporte1.Click
        Try
            Dim tsql As String = "Select * from Monitores"
            Dim conn As New SqlConnection(My.Settings.strConnection)
            Dim da As New SqlDataAdapter(tsql, conn)
            Dim t As New DataTable
            da.Fill(t)
            verReporte(t, "DsRegistros", "C:\DiseñoRPT\rptMonitores.rdlc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar el reporte")
        End Try
    End Sub
End Class