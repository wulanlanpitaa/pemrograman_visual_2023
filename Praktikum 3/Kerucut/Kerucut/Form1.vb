Public Class Form1
    Private Sub Volumekerucut_Click(sender As Object, e As EventArgs) Handles Volumekerucut.Click
        Dim jarijari, sisi, tinggi, hasil As Double
        jarijari = Val(Tjarijari.Text)
        sisi = Val(Tsisi.Text)
        tinggi = Val(Ttinggi.Text)
        hasil = Val(Thasil.Text)

        Thasil.Text = 1 / 3 * 22 / 7 * Val(Tjarijari.Text) ^ 2 * Val(Ttinggi.Text)
    End Sub

    Private Sub Luaspermukaankerucut_Click(sender As Object, e As EventArgs) Handles Luaspermukaankerucut.Click
        Thasil.Text = 22 / 7 * Val(Tjarijari.Text) * Val(Tjarijari.Text) + Val(Tsisi.Text)
    End Sub
End Class