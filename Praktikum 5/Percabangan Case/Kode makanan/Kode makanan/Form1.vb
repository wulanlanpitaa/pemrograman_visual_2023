Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txtKodeMakanan.Text
            Case "NGR" : txtKeterangan.Text = "Nasi Goreng"

            Case "BGR" : txtKeterangan.Text = "Burger"

            Case "KFC" : txtKeterangan.Text = "Kentaki Fried Chiken"

            Case Else : txtKeterangan.Text = "Kode Makanan tidak ditemukan"
        End Select
    End Sub
End Class
