Public Class Form1
    Private Sub Hitung_Click(sender As Object, e As EventArgs) Handles Keliling.Click
        Thasil.Text = 2 * Val(Tsisi1.Text + Tsisi2.Text)
    End Sub

    Private Sub Luas_Click(sender As Object, e As EventArgs) Handles Luas.Click
        Thasil.Text = 1 / 2 * Val(Tdiagonal1.Text) * Val(Tdiagonal2.Text)
    End Sub
End Class
