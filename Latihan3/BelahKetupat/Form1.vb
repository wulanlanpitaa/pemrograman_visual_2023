Public Class Form1
    Private Sub luasbk_Click(sender As Object, e As EventArgs) Handles luasbk.Click
        Thasil.Text = 1 / 2 * Val(Tdiagonal1.Text) * Val(Tdiagonal2.Text)
    End Sub

    Private Sub kelilingbk_Click(sender As Object, e As EventArgs) Handles kelilingbk.Click
        Thasil.Text = 4 * Val(Tsisi.Text)
    End Sub
End Class
