Public Class FrmPrincipal


    Sub mostrarHora()
        LblHora.Text = DateTime.Now.ToString("hh:mm.ss")
    End Sub

    Private Sub TmrAuxiliar_Tick(sender As Object, e As EventArgs) Handles TmrAuxiliar.Tick
        mostrarHora()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TmrAuxiliar.Enabled = True

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        MsgBox("Registro guardado satisfactoriamente.", MsgBoxStyle.Information, "Sistema UCA")
        BtnLimpiar.PerformClick()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtNombres.Clear()
        TxtApellidos.Clear()
        TxtMotivo.Clear()
        TxtNombres.Focus()
    End Sub
End Class
