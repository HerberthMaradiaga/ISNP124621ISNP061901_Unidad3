Public Class Form1
    Dim alumno As New Alumno
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        alumno.datosAlumno(txtCodigo.Text,
                           txtNombre.Text,
                           txtApellido.Text,
                           txtGenero.Text,
                           txtDireccion.Text,
                           txtDui.Text,
                           txtEdad.Text,
                           txtCorreo.Text
                           )

        dgvMostrar.Rows.Add(txtCodigo.Text,
                            alumno.nombreAlumno,
                            alumno.apellidoAlumno,
                            alumno.generoAlumno,
                            alumno.direccionAlumno,
                            alumno.duiAlumno,
                            alumno.correoAlumno,
                            alumno.edadAlumno)

        If alumno.datosAceptados Then
            MsgBox("alumno " & alumno.nombreAlumno & " " & alumno.apellidoAlumno & " Registrado con exito")
        End If

        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtGenero.Text = ""
        txtDireccion.Text = ""
        txtDui.Text = ""
        txtEdad.Text = ""
        txtCorreo.Text = ""

    End Sub
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If txtNombre.Text = "" Then
            MsgBox("Debe ingresar su nombre")
        Else
            txtCodigo.Text = alumno.generarCodigo(txtNombre.Text)
        End If
    End Sub
    'esta instruccion cerrara el formulario al pulsar el boton salir
    'sin necesidad de arrastrar el puntero hasta la X en la esquina de la pantalla
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class
