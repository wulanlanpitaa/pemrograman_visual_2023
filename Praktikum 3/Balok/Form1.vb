Public Class Form1

    Private Sub Volumebalok_Click(sender As Object, e As EventArgs) Handles Volumebalok.Click
        Dim panjang, lebar, tinggi, hasil As Integer
        panjang = Val(Tpanjang.Text)
        lebar = Val(Tlebar.Text)
        tinggi = Val(Ttinggi.Text)
        hasil = Val(Thasil.Text)

        Thasil.Text = Val(Tpanjang.Text) * Val(Tlebar.Text) * Val(Ttinggi.Text)
    End Sub

    Private Sub Luaspermukaan_Click(sender As Object, e As EventArgs) Handles Luaspermukaan.Click
        Thasil.Text = 2 * Val(Tpanjang.Text) * Val(Tlebar.Text) + Val(Tpanjang.Text) * Val(Ttinggi.Text) + Val(Tlebar.Text) * Val(Ttinggi.Text)
    End Sub
End Class
