﻿Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtMasaKerja.Text) >= 20) Then
            txtKeterangan.Text = "Anda mendapat bonus berupa motor"

        ElseIf (txtMasaKerja.Text >= 15) Then
            txtKeterangan.Text = "Anda mendapat bonus sepeda gunung"

        ElseIf (txtMasaKerja.Text >= 10) Then
            txtKeterangan.Text = "Anda mendapat binus cincin emas 5gr"

        ElseIf (txtMasaKerja.Text >= 5) Then
            txtKeterangan.Text = "Anda mendapat voucher belanja Rp.500rb"

        Else
            txtKeterangan.Text = "Maaf anda belum layak dapat bonus"
        End If
    End Sub
End Class
