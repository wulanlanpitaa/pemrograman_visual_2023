Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtUmur.Text) <= 10) Then
            txtKeterangan.Text = "Anak-Anak"

        ElseIf (txtUmur.Text <= 15) Then
            txtKeterangan.Text = "Remaja"

        ElseIf (txtUmur.Text <= 30) Then
            txtKeterangan.Text = "Dewasa"

        Else
            txtKeterangan.Text = "Parubaya"
        End If
    End Sub
End Class
