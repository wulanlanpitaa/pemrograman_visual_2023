Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub Reload()
        oMatakuliah.getAllData(DataGridView1)
    End Sub

    Private Sub txtKode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKode.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            oMatakuliah.Carimatakuliah(txtKode.Text)
            If (matakuliah_baru = False) Then
                TampilMatakuliah()
            Else
                MessageBox.Show("Data Tidak Ditemukan.")
            End If
        End If
    End Sub

    Private Sub TampilMatakuliah()
        txtKode.Text = oMatakuliah.kodemk
        txtNama.Text = oMatakuliah.namamk
        txtSKS.Text = oMatakuliah.sks
        txtProdi.Text = oMatakuliah.prodi
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearEntry()
    End Sub

    Private Sub ClearEntry()
        txtKode.Clear()
        txtNama.Clear()
        txtSKS.Clear()
        txtProdi.Clear()
        txtKode.Focus()
    End Sub

    Private Sub SimpanDataMatakuliah()
        oMatakuliah.kodemk = txtKode.Text
        oMatakuliah.namamk = txtNama.Text
        oMatakuliah.sks = txtSKS.Text
        oMatakuliah.prodi = txtProdi.Text
        oMatakuliah.Simpan()
        Reload()
        If (oMatakuliah.InsertState = True) Then
            MessageBox.Show("Data berhasil disimpan.")
        ElseIf (oMatakuliah.UpdateState = True) Then
            MessageBox.Show("Data berhasil diperbarui.")
        Else
            MessageBox.Show("Data gagal disimpan.")
        End If
        ClearEntry()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If (txtKode.Text <> "") Then
            SimpanDataMatakuliah()
            ClearEntry()
            Reload()
        Else
            MessageBox.Show("kode mk dan nama mk tidak boleh kosong!")
        End If
    End Sub

    Private Sub Hapus()
        If (matakuliah_baru = False And txtKode.Text <> "") Then
            oMatakuliah.Hapus(txtKode.Text)
            ClearEntry()
            Reload()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim jawab As Integer
        jawab = MessageBox.Show("Apakah Data akan dihapus?", "Confirm", MessageBoxButtons.YesNo)
        If (jawab = vbYes) Then
            Hapus()
        Else
            MessageBox.Show("Data batal dihapus")
        End If
    End Sub
End Class