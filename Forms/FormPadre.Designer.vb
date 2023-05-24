<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPadre
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
        Me.BarraMenusFormPadre = New System.Windows.Forms.MenuStrip()
        Me.menuArchivos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFormularios = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchivoCerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.opFormularioCRUD = New System.Windows.Forms.ToolStripMenuItem()
        Me.opFormularioA = New System.Windows.Forms.ToolStripMenuItem()
        Me.opFormularioB = New System.Windows.Forms.ToolStripMenuItem()
        Me.opFormularioC = New System.Windows.Forms.ToolStripMenuItem()
        Me.opReporte1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.opReporte2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.opReporte3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarraMenusFormPadre.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarraMenusFormPadre
        '
        Me.BarraMenusFormPadre.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BarraMenusFormPadre.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuArchivos, Me.menuFormularios, Me.menuReportes})
        Me.BarraMenusFormPadre.Location = New System.Drawing.Point(0, 0)
        Me.BarraMenusFormPadre.Name = "BarraMenusFormPadre"
        Me.BarraMenusFormPadre.Size = New System.Drawing.Size(800, 28)
        Me.BarraMenusFormPadre.TabIndex = 1
        Me.BarraMenusFormPadre.Text = "MenuStrip1"
        '
        'menuArchivos
        '
        Me.menuArchivos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoCerrar})
        Me.menuArchivos.Name = "menuArchivos"
        Me.menuArchivos.Size = New System.Drawing.Size(73, 24)
        Me.menuArchivos.Text = "Archivo"
        '
        'menuFormularios
        '
        Me.menuFormularios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opFormularioCRUD, Me.opFormularioA, Me.opFormularioB, Me.opFormularioC})
        Me.menuFormularios.Name = "menuFormularios"
        Me.menuFormularios.Size = New System.Drawing.Size(101, 24)
        Me.menuFormularios.Text = "Formularios"
        '
        'menuReportes
        '
        Me.menuReportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opReporte1, Me.opReporte2, Me.opReporte3})
        Me.menuReportes.Name = "menuReportes"
        Me.menuReportes.Size = New System.Drawing.Size(82, 24)
        Me.menuReportes.Text = "Reportes"
        '
        'ArchivoCerrar
        '
        Me.ArchivoCerrar.Name = "ArchivoCerrar"
        Me.ArchivoCerrar.Size = New System.Drawing.Size(224, 26)
        Me.ArchivoCerrar.Text = "cerrar"
        '
        'opFormularioCRUD
        '
        Me.opFormularioCRUD.Name = "opFormularioCRUD"
        Me.opFormularioCRUD.Size = New System.Drawing.Size(224, 26)
        Me.opFormularioCRUD.Text = "FormularioCRUD"
        '
        'opFormularioA
        '
        Me.opFormularioA.Name = "opFormularioA"
        Me.opFormularioA.Size = New System.Drawing.Size(224, 26)
        Me.opFormularioA.Text = "FormA"
        '
        'opFormularioB
        '
        Me.opFormularioB.Name = "opFormularioB"
        Me.opFormularioB.Size = New System.Drawing.Size(224, 26)
        Me.opFormularioB.Text = "FormB"
        '
        'opFormularioC
        '
        Me.opFormularioC.Name = "opFormularioC"
        Me.opFormularioC.Size = New System.Drawing.Size(224, 26)
        Me.opFormularioC.Text = "FormC"
        '
        'opReporte1
        '
        Me.opReporte1.Name = "opReporte1"
        Me.opReporte1.Size = New System.Drawing.Size(224, 26)
        Me.opReporte1.Text = "Reporte1"
        '
        'opReporte2
        '
        Me.opReporte2.Name = "opReporte2"
        Me.opReporte2.Size = New System.Drawing.Size(224, 26)
        Me.opReporte2.Text = "Reporte2"
        '
        'opReporte3
        '
        Me.opReporte3.Name = "opReporte3"
        Me.opReporte3.Size = New System.Drawing.Size(224, 26)
        Me.opReporte3.Text = "Reporte3"
        '
        'FormPadre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BarraMenusFormPadre)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.BarraMenusFormPadre
        Me.Name = "FormPadre"
        Me.Text = "FormPadre"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BarraMenusFormPadre.ResumeLayout(False)
        Me.BarraMenusFormPadre.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarraMenusFormPadre As MenuStrip
    Friend WithEvents menuArchivos As ToolStripMenuItem
    Friend WithEvents ArchivoCerrar As ToolStripMenuItem
    Friend WithEvents menuFormularios As ToolStripMenuItem
    Friend WithEvents menuReportes As ToolStripMenuItem
    Friend WithEvents opFormularioCRUD As ToolStripMenuItem
    Friend WithEvents opFormularioA As ToolStripMenuItem
    Friend WithEvents opFormularioB As ToolStripMenuItem
    Friend WithEvents opFormularioC As ToolStripMenuItem
    Friend WithEvents opReporte1 As ToolStripMenuItem
    Friend WithEvents opReporte2 As ToolStripMenuItem
    Friend WithEvents opReporte3 As ToolStripMenuItem
End Class
