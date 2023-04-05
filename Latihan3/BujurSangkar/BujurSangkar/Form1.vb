Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles luasbs.Click
        Thasil.Text = Val(Tpanjang.Text) * Val(Tpanjang.Text)
    End Sub

    Private Sub kelilingbs_Click(sender As Object, e As EventArgs) Handles kelilingbs.Click
        Thasil.Text = 4 * Val(Tpanjang.Text)
    End Sub
End Class
