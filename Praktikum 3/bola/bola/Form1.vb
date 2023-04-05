Public Class Form1
    Private Sub Volumebola_Click(sender As Object, e As EventArgs) Handles Volumebola.Click
        Dim jarijari, hasil As Double
        jarijari = Val(Tjarijari.Text)
        hasil = Val(Thasil.Text)

        Thasil.Text = 4 / 3 * 22 / 7 * Val(Tjarijari.Text) ^ 3
    End Sub

    Private Sub Luasbola_Click(sender As Object, e As EventArgs) Handles Luasbola.Click
        Thasil.Text = 4 * 22 / 7 * Val(Tjarijari.Text) ^ 2
    End Sub
End Class
