Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txtKodeBaju.Text
            Case "NVD" : txtKeterangan.Text = "Nevada"

            Case "OCL" : txtKeterangan.Text = "Oclo"

            Case "PLNT" : txtKeterangan.Text = "Planet"

            Case Else : txtKeterangan.Text = "Kode Baju tidak ditemukan"
        End Select
    End Sub
End Class
