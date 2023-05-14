Public Class Form1
    Private Sub txtSubmit_Click(sender As Object, e As EventArgs) Handles txtSubmit.Click
        If (Val(txtMasaKerja.Text) >= 30) Then
            txtKeterangan.Text = "Selamat anda mendapatkan THR 1juta dan parcel"

        ElseIf (txtMasaKerja.Text >= 15) Then
            txtKeterangan.Text = "Selamat anda mendapatkan THR 700rb dan parcel"

        ElseIf (txtMasaKerja.Text >= 10) Then
            txtKeterangan.Text = "Selamat anda mendapatkan THR 500rb"

        ElseIf (txtMasaKerja.Text >= 5) Then
            txtKeterangan.Text = "Selamat anda mendapatkan THR 300rb"

        Else
            txtKeterangan.Text = "Maaf anda belum layak dapat THR"
        End If
    End Sub
End Class
