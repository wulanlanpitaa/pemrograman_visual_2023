﻿Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtNilaiAkhir.Text) >= 60) Then
            TxtKeterangan.Text = "Anda Lulus"
        Else
            TxtKeterangan.Text = "Anda tidak Lulus, Silahkan mengulang tahun depan"
        End If
    End Sub
End Class
