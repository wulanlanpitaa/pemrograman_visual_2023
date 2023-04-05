Public Class Form1
    Private Sub Keliling_Click(sender As Object, e As EventArgs) Handles Keliling.Click
        Thasil.Text = 3.14 * Val(Tjari.Text) ^ 2
    End Sub

    Private Sub Luas_Click(sender As Object, e As EventArgs) Handles Luas.Click
        Thasil.Text = 2 * 3.14 * Val(Tjari.Text)
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        Tjari.Text = ""
        Thasil.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
