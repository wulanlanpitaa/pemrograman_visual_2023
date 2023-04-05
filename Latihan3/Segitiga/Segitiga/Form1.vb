Public Class Form1
    Private Sub Hitung_Click(sender As Object, e As EventArgs) Handles Hitung.Click
        Dim alas As Double, tinggi As Double, luas As Double
        alas = Val(Talas.Text)
        tinggi = Val(Ttinggi.Text)
        luas = 0.5 * alas * tinggi
        Tluas.Text = luas
    End Sub
End Class
