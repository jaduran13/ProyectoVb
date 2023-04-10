Public Class FrmInicioSesion
    Private Sub TxtUsuario_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtUsuario.MouseClick
        If TxtUsuario.Text = "Ingrese su ID" Then
            TxtUsuario.Clear()
        End If
    End Sub

    Private Sub TxtUsuario_LostFocus(sender As Object, e As EventArgs) Handles TxtUsuario.LostFocus
        If TxtUsuario.Text = "" Or TxtUsuario.Text.Length = 0 Then
            TxtUsuario.Text = "Ingrese su ID"
        End If
    End Sub
End Class