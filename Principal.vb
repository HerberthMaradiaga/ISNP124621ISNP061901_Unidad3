Public Class Principal
    Private Sub btnregistroe_Click(sender As Object, e As EventArgs) Handles btnregistroe.Click
        Form1.Show()
    End Sub

    Private Sub btnregistroa_Click(sender As Object, e As EventArgs) Handles btnregistroa.Click
        Form2.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class