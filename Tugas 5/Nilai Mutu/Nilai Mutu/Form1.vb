
Public Class Form1
        Private Function HitungNilaiAkhir(khd As Integer, tgs As Integer, uts As Integer, uas As Integer) As Integer
            Dim nilaiAkhir As Integer
            nilaiAkhir = (25 / 100 * khd) + (35 / 100 * tgs) + (20 / 100 * uts) + (20 / 100 * uas)
            Return nilaiAkhir
        End Function
        Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
            Dim nim, khd, tgs, uts, uas, nilaiAkhir As Integer
            Dim nama, prodi As String

            nim = Val(txtnim.Text)
            nama = Val(txtnama.Text)
            prodi = Val(txtprodi.Text)
            khd = Val(txtnilaikehadiran.Text)
            tgs = Val(txtTugas.Text)
            uts = Val(txtUTS.Text)
            uas = Val(txtUAS.Text)

            nilaiAkhir = HitungNilaiAkhir(khd, tgs, uts, uas)

            txtnilaiakhir.Text = Str(nilaiAkhir)
            If (nilaiAkhir >= 85) Then
                txtnilaimutu.Text = "A"

            ElseIf (nilaiAkhir >= 75) Then
                txtnilaimutu.Text = "B"

            ElseIf (nilaiAkhir >= 55) Then
                txtnilaimutu.Text = "C"

            ElseIf (nilaiAkhir >= 30) Then
                txtnilaimutu.Text = "D"

            Else
                txtnilaimutu.Text = "E"
            End If
        End Sub
    End Class
