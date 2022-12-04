<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.txtclase = New System.Windows.Forms.TextBox()
        Me.txtcolor = New System.Windows.Forms.TextBox()
        Me.txttipo = New System.Windows.Forms.TextBox()
        Me.lblclase = New System.Windows.Forms.Label()
        Me.lblolor = New System.Windows.Forms.Label()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.dgvMostrar = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtmodelo = New System.Windows.Forms.TextBox()
        Me.txtcapacidad = New System.Windows.Forms.TextBox()
        Me.txtaño = New System.Windows.Forms.TextBox()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.lblmodelo = New System.Windows.Forms.Label()
        Me.lblaño = New System.Windows.Forms.Label()
        Me.lblcapacidad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblmarca = New System.Windows.Forms.Label()
        Me.grpCodigo = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.grpDatos.SuspendLayout()
        CType(Me.dgvMostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCodigo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(353, 39)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(174, 25)
        Me.lbltitulo.TabIndex = 20
        Me.lbltitulo.Text = "Ingreso de Autos"
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.txtclase)
        Me.grpDatos.Controls.Add(Me.txtcolor)
        Me.grpDatos.Controls.Add(Me.txttipo)
        Me.grpDatos.Controls.Add(Me.lblclase)
        Me.grpDatos.Controls.Add(Me.lblolor)
        Me.grpDatos.Controls.Add(Me.lbltipo)
        Me.grpDatos.Controls.Add(Me.dgvMostrar)
        Me.grpDatos.Controls.Add(Me.txtmodelo)
        Me.grpDatos.Controls.Add(Me.txtcapacidad)
        Me.grpDatos.Controls.Add(Me.txtaño)
        Me.grpDatos.Controls.Add(Me.txtmarca)
        Me.grpDatos.Controls.Add(Me.lblmodelo)
        Me.grpDatos.Controls.Add(Me.lblaño)
        Me.grpDatos.Controls.Add(Me.lblcapacidad)
        Me.grpDatos.Controls.Add(Me.Label1)
        Me.grpDatos.Controls.Add(Me.lblmarca)
        Me.grpDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatos.Location = New System.Drawing.Point(43, 223)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(874, 457)
        Me.grpDatos.TabIndex = 19
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos Auto"
        '
        'txtclase
        '
        Me.txtclase.Location = New System.Drawing.Point(520, 88)
        Me.txtclase.Name = "txtclase"
        Me.txtclase.Size = New System.Drawing.Size(311, 24)
        Me.txtclase.TabIndex = 16
        '
        'txtcolor
        '
        Me.txtcolor.Location = New System.Drawing.Point(520, 135)
        Me.txtcolor.Name = "txtcolor"
        Me.txtcolor.Size = New System.Drawing.Size(88, 24)
        Me.txtcolor.TabIndex = 15
        '
        'txttipo
        '
        Me.txttipo.Location = New System.Drawing.Point(520, 44)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txttipo.Size = New System.Drawing.Size(311, 24)
        Me.txttipo.TabIndex = 14
        '
        'lblclase
        '
        Me.lblclase.AutoSize = True
        Me.lblclase.Location = New System.Drawing.Point(443, 88)
        Me.lblclase.Name = "lblclase"
        Me.lblclase.Size = New System.Drawing.Size(46, 18)
        Me.lblclase.TabIndex = 13
        Me.lblclase.Text = "Clase"
        '
        'lblolor
        '
        Me.lblolor.AutoSize = True
        Me.lblolor.Location = New System.Drawing.Point(443, 135)
        Me.lblolor.Name = "lblolor"
        Me.lblolor.Size = New System.Drawing.Size(45, 18)
        Me.lblolor.TabIndex = 12
        Me.lblolor.Text = "Color"
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(443, 44)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(37, 18)
        Me.lbltipo.TabIndex = 11
        Me.lbltipo.Text = "Tipo"
        '
        'dgvMostrar
        '
        Me.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMostrar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dgvMostrar.Location = New System.Drawing.Point(15, 230)
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
        Me.Column2.HeaderText = "Marca"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Modelo"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Año"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Capacidad"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Tipo"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Clase"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Color"
        Me.Column8.Name = "Column8"
        '
        'txtmodelo
        '
        Me.txtmodelo.Location = New System.Drawing.Point(108, 94)
        Me.txtmodelo.Name = "txtmodelo"
        Me.txtmodelo.Size = New System.Drawing.Size(311, 24)
        Me.txtmodelo.TabIndex = 9
        '
        'txtcapacidad
        '
        Me.txtcapacidad.Location = New System.Drawing.Point(108, 185)
        Me.txtcapacidad.Name = "txtcapacidad"
        Me.txtcapacidad.Size = New System.Drawing.Size(311, 24)
        Me.txtcapacidad.TabIndex = 8
        '
        'txtaño
        '
        Me.txtaño.Location = New System.Drawing.Point(108, 141)
        Me.txtaño.Name = "txtaño"
        Me.txtaño.Size = New System.Drawing.Size(88, 24)
        Me.txtaño.TabIndex = 7
        '
        'txtmarca
        '
        Me.txtmarca.Location = New System.Drawing.Point(108, 50)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(311, 24)
        Me.txtmarca.TabIndex = 6
        '
        'lblmodelo
        '
        Me.lblmodelo.AutoSize = True
        Me.lblmodelo.Location = New System.Drawing.Point(31, 94)
        Me.lblmodelo.Name = "lblmodelo"
        Me.lblmodelo.Size = New System.Drawing.Size(58, 18)
        Me.lblmodelo.TabIndex = 4
        Me.lblmodelo.Text = "Modelo"
        '
        'lblaño
        '
        Me.lblaño.AutoSize = True
        Me.lblaño.Location = New System.Drawing.Point(31, 141)
        Me.lblaño.Name = "lblaño"
        Me.lblaño.Size = New System.Drawing.Size(34, 18)
        Me.lblaño.TabIndex = 3
        Me.lblaño.Text = "Año"
        '
        'lblcapacidad
        '
        Me.lblcapacidad.AutoSize = True
        Me.lblcapacidad.Location = New System.Drawing.Point(31, 185)
        Me.lblcapacidad.Name = "lblcapacidad"
        Me.lblcapacidad.Size = New System.Drawing.Size(78, 18)
        Me.lblcapacidad.TabIndex = 2
        Me.lblcapacidad.Text = "Capacidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 18)
        Me.Label1.TabIndex = 1
        '
        'lblmarca
        '
        Me.lblmarca.AutoSize = True
        Me.lblmarca.Location = New System.Drawing.Point(31, 50)
        Me.lblmarca.Name = "lblmarca"
        Me.lblmarca.Size = New System.Drawing.Size(50, 18)
        Me.lblmarca.TabIndex = 0
        Me.lblmarca.Text = "Marca"
        '
        'grpCodigo
        '
        Me.grpCodigo.Controls.Add(Me.btnSalir)
        Me.grpCodigo.Controls.Add(Me.txtCodigo)
        Me.grpCodigo.Controls.Add(Me.btnGenerar)
        Me.grpCodigo.Controls.Add(Me.btnAgregar)
        Me.grpCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCodigo.Location = New System.Drawing.Point(41, 112)
        Me.grpCodigo.Name = "grpCodigo"
        Me.grpCodigo.Size = New System.Drawing.Size(804, 103)
        Me.grpCodigo.TabIndex = 18
        Me.grpCodigo.TabStop = False
        Me.grpCodigo.Text = "Generar Codigo Auto"
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
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(493, 33)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 32)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 702)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.grpDatos)
        Me.Controls.Add(Me.grpCodigo)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        CType(Me.dgvMostrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCodigo.ResumeLayout(False)
        Me.grpCodigo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltitulo As Label
    Friend WithEvents grpDatos As GroupBox
    Friend WithEvents txtclase As TextBox
    Friend WithEvents txtcolor As TextBox
    Friend WithEvents txttipo As TextBox
    Friend WithEvents lblclase As Label
    Friend WithEvents lblolor As Label
    Friend WithEvents lbltipo As Label
    Friend WithEvents dgvMostrar As DataGridView
    Friend WithEvents txtmodelo As TextBox
    Friend WithEvents txtcapacidad As TextBox
    Friend WithEvents txtaño As TextBox
    Friend WithEvents txtmarca As TextBox
    Friend WithEvents lblmodelo As Label
    Friend WithEvents lblaño As Label
    Friend WithEvents lblcapacidad As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblmarca As Label
    Friend WithEvents grpCodigo As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
