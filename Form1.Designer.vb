<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtDui = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblDui = New System.Windows.Forms.Label()
        Me.dgvMostrar = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.grpCodigo = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpDatos.SuspendLayout()
        CType(Me.dgvMostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCodigo.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.txtCorreo)
        Me.grpDatos.Controls.Add(Me.txtEdad)
        Me.grpDatos.Controls.Add(Me.txtDui)
        Me.grpDatos.Controls.Add(Me.lblCorreo)
        Me.grpDatos.Controls.Add(Me.lblEdad)
        Me.grpDatos.Controls.Add(Me.lblDui)
        Me.grpDatos.Controls.Add(Me.dgvMostrar)
        Me.grpDatos.Controls.Add(Me.txtApellido)
        Me.grpDatos.Controls.Add(Me.txtDireccion)
        Me.grpDatos.Controls.Add(Me.txtGenero)
        Me.grpDatos.Controls.Add(Me.txtNombre)
        Me.grpDatos.Controls.Add(Me.lblApellido)
        Me.grpDatos.Controls.Add(Me.lblGenero)
        Me.grpDatos.Controls.Add(Me.lblDireccion)
        Me.grpDatos.Controls.Add(Me.Label1)
        Me.grpDatos.Controls.Add(Me.lblNombre)
        Me.grpDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatos.Location = New System.Drawing.Point(27, 193)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(874, 448)
        Me.grpDatos.TabIndex = 3
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos Alumno"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(520, 88)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(311, 24)
        Me.txtCorreo.TabIndex = 16
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(520, 135)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(88, 24)
        Me.txtEdad.TabIndex = 15
        '
        'txtDui
        '
        Me.txtDui.Location = New System.Drawing.Point(520, 44)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDui.Size = New System.Drawing.Size(311, 24)
        Me.txtDui.TabIndex = 14
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(443, 88)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(55, 18)
        Me.lblCorreo.TabIndex = 13
        Me.lblCorreo.Text = "Correo"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(443, 135)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(42, 18)
        Me.lblEdad.TabIndex = 12
        Me.lblEdad.Text = "Edad"
        '
        'lblDui
        '
        Me.lblDui.AutoSize = True
        Me.lblDui.Location = New System.Drawing.Point(443, 44)
        Me.lblDui.Name = "lblDui"
        Me.lblDui.Size = New System.Drawing.Size(33, 18)
        Me.lblDui.TabIndex = 11
        Me.lblDui.Text = "DUI"
        '
        'dgvMostrar
        '
        Me.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMostrar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dgvMostrar.Location = New System.Drawing.Point(15, 244)
        Me.dgvMostrar.Name = "dgvMostrar"
        Me.dgvMostrar.Size = New System.Drawing.Size(825, 186)
        Me.dgvMostrar.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Apellido"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Genero"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Direccion"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "DUI"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Correo"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Edad"
        Me.Column8.Name = "Column8"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(108, 94)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(311, 24)
        Me.txtApellido.TabIndex = 9
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(108, 185)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(311, 24)
        Me.txtDireccion.TabIndex = 8
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(108, 141)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(88, 24)
        Me.txtGenero.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(108, 50)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(311, 24)
        Me.txtNombre.TabIndex = 6
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(31, 94)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(59, 18)
        Me.lblApellido.TabIndex = 4
        Me.lblApellido.Text = "Apellido"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Location = New System.Drawing.Point(31, 141)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(58, 18)
        Me.lblGenero.TabIndex = 3
        Me.lblGenero.Text = "Genero"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(31, 185)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(71, 18)
        Me.lblDireccion.TabIndex = 2
        Me.lblDireccion.Text = "Direccion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 18)
        Me.Label1.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(31, 50)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(62, 18)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(493, 33)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 32)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'grpCodigo
        '
        Me.grpCodigo.Controls.Add(Me.btnSalir)
        Me.grpCodigo.Controls.Add(Me.txtCodigo)
        Me.grpCodigo.Controls.Add(Me.btnGenerar)
        Me.grpCodigo.Controls.Add(Me.btnAgregar)
        Me.grpCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCodigo.Location = New System.Drawing.Point(25, 82)
        Me.grpCodigo.Name = "grpCodigo"
        Me.grpCodigo.Size = New System.Drawing.Size(804, 103)
        Me.grpCodigo.TabIndex = 2
        Me.grpCodigo.TabStop = False
        Me.grpCodigo.Text = "Generar Codigo Alumno"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(645, 31)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 32)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(17, 39)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(258, 24)
        Me.txtCodigo.TabIndex = 1
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(294, 36)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(140, 30)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "Generar Codigo"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(337, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 25)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Ingreso de Estudiantes"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 674)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grpDatos)
        Me.Controls.Add(Me.grpCodigo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        CType(Me.dgvMostrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCodigo.ResumeLayout(False)
        Me.grpCodigo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpDatos As GroupBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblGenero As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents grpCodigo As GroupBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtDui As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblEdad As Label
    Friend WithEvents lblDui As Label
    Friend WithEvents dgvMostrar As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
