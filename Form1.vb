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
        If alumno.datosAceptados Then
            MsgBox("alumno " & alumno.nombreAlumno & " Registrado")
        Else

        End If

    End Sub
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If txtNombre.Text = "" Then
            MsgBox("Debe ingresar su nombre")
        Else
            txtCodigo.Text = alumno.generarCodigo(txtNombre.Text)
        End If
    End Sub
End Class
