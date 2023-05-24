<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btPrimero = New System.Windows.Forms.Button()
        Me.btAnterior = New System.Windows.Forms.Button()
        Me.btSiguiente = New System.Windows.Forms.Button()
        Me.btUltimo = New System.Windows.Forms.Button()
        Me.ctId = New System.Windows.Forms.TextBox()
        Me.CiudadBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBMonitoresUcaDataSet = New MonitoresUCA.DBMonitoresUcaDataSet()
        Me.CiudadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCiudades = New MonitoresUCA.dsCiudades()
        Me.ctNombre = New System.Windows.Forms.TextBox()
        Me.ctEstado = New System.Windows.Forms.TextBox()
        Me.ctBuscar = New System.Windows.Forms.TextBox()
        Me.ctObservaciones = New System.Windows.Forms.RichTextBox()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.btBorrar = New System.Windows.Forms.Button()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.etPosicion = New System.Windows.Forms.Label()
        Me.CiudadTableAdapter = New MonitoresUCA.dsCiudadesTableAdapters.CiudadTableAdapter()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.CiudadTableAdapter1 = New MonitoresUCA.DBMonitoresUcaDataSetTableAdapters.CiudadTableAdapter()
        Me.DBMonitoresUcaDataSet1 = New MonitoresUCA.dsRegistros()
        CType(Me.CiudadBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBMonitoresUcaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CiudadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCiudades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBMonitoresUcaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 116)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 165)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 226)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Estado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 294)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Observaciones:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(415, 43)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(248, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Listado de ciudades"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(567, 331)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Buscar:"
        '
        'btPrimero
        '
        Me.btPrimero.Location = New System.Drawing.Point(92, 457)
        Me.btPrimero.Margin = New System.Windows.Forms.Padding(4)
        Me.btPrimero.Name = "btPrimero"
        Me.btPrimero.Size = New System.Drawing.Size(100, 28)
        Me.btPrimero.TabIndex = 6
        Me.btPrimero.Text = "Primero"
        Me.btPrimero.UseVisualStyleBackColor = True
        '
        'btAnterior
        '
        Me.btAnterior.Location = New System.Drawing.Point(301, 457)
        Me.btAnterior.Margin = New System.Windows.Forms.Padding(4)
        Me.btAnterior.Name = "btAnterior"
        Me.btAnterior.Size = New System.Drawing.Size(100, 28)
        Me.btAnterior.TabIndex = 7
        Me.btAnterior.Text = "Anterior"
        Me.btAnterior.UseVisualStyleBackColor = True
        '
        'btSiguiente
        '
        Me.btSiguiente.Location = New System.Drawing.Point(684, 457)
        Me.btSiguiente.Margin = New System.Windows.Forms.Padding(4)
        Me.btSiguiente.Name = "btSiguiente"
        Me.btSiguiente.Size = New System.Drawing.Size(100, 28)
        Me.btSiguiente.TabIndex = 8
        Me.btSiguiente.Text = "Siguiente"
        Me.btSiguiente.UseVisualStyleBackColor = True
        '
        'btUltimo
        '
        Me.btUltimo.Location = New System.Drawing.Point(897, 457)
        Me.btUltimo.Margin = New System.Windows.Forms.Padding(4)
        Me.btUltimo.Name = "btUltimo"
        Me.btUltimo.Size = New System.Drawing.Size(100, 28)
        Me.btUltimo.TabIndex = 9
        Me.btUltimo.Text = "Ultimo"
        Me.btUltimo.UseVisualStyleBackColor = True
        '
        'ctId
        '
        Me.ctId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CiudadBindingSource1, "id", True))
        Me.ctId.Location = New System.Drawing.Point(200, 116)
        Me.ctId.Margin = New System.Windows.Forms.Padding(4)
        Me.ctId.Name = "ctId"
        Me.ctId.Size = New System.Drawing.Size(211, 22)
        Me.ctId.TabIndex = 10
        '
        'CiudadBindingSource1
        '
        Me.CiudadBindingSource1.DataMember = "Ciudad"
        Me.CiudadBindingSource1.DataSource = Me.DBMonitoresUcaDataSet
        '
        'DBMonitoresUcaDataSet
        '
        Me.DBMonitoresUcaDataSet.DataSetName = "DBMonitoresUcaDataSet"
        Me.DBMonitoresUcaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CiudadBindingSource
        '
        Me.CiudadBindingSource.DataMember = "Ciudad"
        Me.CiudadBindingSource.DataSource = Me.DsCiudades
        '
        'DsCiudades
        '
        Me.DsCiudades.DataSetName = "dsCiudades"
        Me.DsCiudades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ctNombre
        '
        Me.ctNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CiudadBindingSource1, "nombre", True))
        Me.ctNombre.Location = New System.Drawing.Point(200, 166)
        Me.ctNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.ctNombre.Name = "ctNombre"
        Me.ctNombre.Size = New System.Drawing.Size(211, 22)
        Me.ctNombre.TabIndex = 11
        '
        'ctEstado
        '
        Me.ctEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CiudadBindingSource1, "estado", True))
        Me.ctEstado.Location = New System.Drawing.Point(200, 224)
        Me.ctEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.ctEstado.Name = "ctEstado"
        Me.ctEstado.Size = New System.Drawing.Size(211, 22)
        Me.ctEstado.TabIndex = 12
        '
        'ctBuscar
        '
        Me.ctBuscar.Location = New System.Drawing.Point(684, 331)
        Me.ctBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.ctBuscar.Name = "ctBuscar"
        Me.ctBuscar.Size = New System.Drawing.Size(211, 22)
        Me.ctBuscar.TabIndex = 13
        '
        'ctObservaciones
        '
        Me.ctObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CiudadBindingSource1, "observaciones", True))
        Me.ctObservaciones.Location = New System.Drawing.Point(200, 294)
        Me.ctObservaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.ctObservaciones.Name = "ctObservaciones"
        Me.ctObservaciones.Size = New System.Drawing.Size(211, 112)
        Me.ctObservaciones.TabIndex = 15
        Me.ctObservaciones.Text = ""
        '
        'btAgregar
        '
        Me.btAgregar.Location = New System.Drawing.Point(751, 110)
        Me.btAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(100, 28)
        Me.btAgregar.TabIndex = 16
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'btBorrar
        '
        Me.btBorrar.Location = New System.Drawing.Point(821, 166)
        Me.btBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btBorrar.Name = "btBorrar"
        Me.btBorrar.Size = New System.Drawing.Size(100, 28)
        Me.btBorrar.TabIndex = 19
        Me.btBorrar.Text = "Borrar"
        Me.btBorrar.UseVisualStyleBackColor = True
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(751, 379)
        Me.btBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(100, 28)
        Me.btBuscar.TabIndex = 20
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'etPosicion
        '
        Me.etPosicion.AccessibleName = ""
        Me.etPosicion.AutoSize = True
        Me.etPosicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etPosicion.Location = New System.Drawing.Point(517, 469)
        Me.etPosicion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.etPosicion.Name = "etPosicion"
        Me.etPosicion.Size = New System.Drawing.Size(82, 18)
        Me.etPosicion.TabIndex = 21
        Me.etPosicion.Text = "No registros"
        Me.etPosicion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CiudadTableAdapter
        '
        Me.CiudadTableAdapter.ClearBeforeFill = True
        '
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(883, 110)
        Me.btGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(100, 28)
        Me.btGuardar.TabIndex = 22
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'CiudadTableAdapter1
        '
        Me.CiudadTableAdapter1.ClearBeforeFill = True
        '
        'DBMonitoresUcaDataSet1
        '
        Me.DBMonitoresUcaDataSet1.DataSetName = "DBMonitoresUcaDataSet1"
        Me.DBMonitoresUcaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.btGuardar)
        Me.Controls.Add(Me.etPosicion)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.btBorrar)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.ctObservaciones)
        Me.Controls.Add(Me.ctBuscar)
        Me.Controls.Add(Me.ctEstado)
        Me.Controls.Add(Me.ctNombre)
        Me.Controls.Add(Me.ctId)
        Me.Controls.Add(Me.btUltimo)
        Me.Controls.Add(Me.btSiguiente)
        Me.Controls.Add(Me.btAnterior)
        Me.Controls.Add(Me.btPrimero)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.CiudadBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBMonitoresUcaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CiudadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCiudades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBMonitoresUcaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btPrimero As Button
    Friend WithEvents btAnterior As Button
    Friend WithEvents btSiguiente As Button
    Friend WithEvents btUltimo As Button
    Friend WithEvents ctId As TextBox
    Friend WithEvents ctNombre As TextBox
    Friend WithEvents ctEstado As TextBox
    Friend WithEvents ctBuscar As TextBox
    Friend WithEvents ctObservaciones As RichTextBox
    Friend WithEvents btAgregar As Button
    Friend WithEvents btBorrar As Button
    Friend WithEvents btBuscar As Button
    Friend WithEvents etPosicion As Label
    Friend WithEvents DsCiudades As dsCiudades
    Friend WithEvents CiudadBindingSource As BindingSource
    Friend WithEvents CiudadTableAdapter As dsCiudadesTableAdapters.CiudadTableAdapter
    Friend WithEvents btGuardar As Button
    Friend WithEvents DBMonitoresUcaDataSet As DBMonitoresUcaDataSet
    Friend WithEvents CiudadBindingSource1 As BindingSource
    Friend WithEvents CiudadTableAdapter1 As DBMonitoresUcaDataSetTableAdapters.CiudadTableAdapter
    Friend WithEvents DBMonitoresUcaDataSet1 As dsRegistros
End Class
