Public Class Form1
    Private Sub Volumekubus_Click(sender As Object, e As EventArgs) Handles Volumekubus.Click
        Dim sisi, hasil As Integer
        hasil = sisi ^ 3
        sisi = Val(Tsisi.Text)
        hasil = Val(Thasil.Text)

        Thasil.Text = Val(Tsisi.Text) ^ 3
    End Sub

    Private Sub Luaskubus_Click(sender As Object, e As EventArgs) Handles Luaskubus.Click
        Thasil.Text = 6 * Val(Tsisi.Text) ^ 2
    End Sub
End Class
