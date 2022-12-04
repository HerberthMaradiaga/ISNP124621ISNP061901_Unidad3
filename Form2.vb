Public Class Form2
    Dim auto As New Auto
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        auto.datosAuto(txtCodigo.Text,
                          txtmarca.Text,
                          txtmodelo.Text,
                          txtaño.Text,
                          txtcapacidad.Text,
                          txttipo.Text,
                          txtclase.Text,
                          txtcolor.Text
                          )

        dgvMostrar.Rows.Add(txtCodigo.Text,
                            auto.marcaAuto,
                            auto.modeloAuto,
                            auto.añoAuto,
                            auto.capacidadAuto,
                            auto.tipoAuto,
                            auto.claseAuto,
                            auto.colorAuto)

        If auto.datosAceptados Then
            MsgBox("alumno " & auto.marcaAuto & " " & auto.modeloAuto & " Registrado con exito")
        End If

        txtCodigo.Text = ""
        txtmarca.Text = ""
        txtmodelo.Text = ""
        txtaño.Text = ""
        txtcapacidad.Text = ""
        txttipo.Text = ""
        txtcolor.Text = ""
        txtclase.Text = ""
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If txtmarca.Text = "" Then
            MsgBox("Debe ingresar la marca del auto")
        Else
            txtCodigo.Text = auto.generarCodigo(txtmarca.Text)
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class