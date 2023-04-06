Public Class Form1
    Private Sub Volumetabung_Click(sender As Object, e As EventArgs) Handles Volumetabung.Click
        Dim jarijari, tinggi, hasil As Double
        jarijari = Val(Tjarijari.Text)
        tinggi = Val(Ttinggi.Text)
        hasil = Val(Thasil.Text)

        Thasil.Text = 22 / 7 * Val(Tjarijari.Text) ^ 2 * Val(Ttinggi.Text)
    End Sub

    Private Sub Luaspermukaantabung_Click(sender As Object, e As EventArgs) Handles Luaspermukaantabung.Click
        Thasil.Text = 2 * 22 / 7 * Val(Tjarijari.Text) * Val(Tjarijari.Text) + Val(Ttinggi.Text)
    End Sub
End Class
