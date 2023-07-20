Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampildatagrid()
        cmbjenis.Items.Add("Seafood")
        cmbjenis.Items.Add("Ayam")
        cmbjenis.Items.Add("Pizza")
    End Sub

    Sub tampildatagrid()
        Call koneksi()
        da = New MySqlDataAdapter("Select * from makanan2", conn)
        ds = New DataSet
        da.Fill(ds, "makanan2")
        DataGridView1.DataSource = ds.Tables("makanan2")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub cmbjenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbjenis.SelectedIndexChanged
        If cmbjenis.Text = "Seafood" Then
            cmbnama.Items.Clear()
            cmbnama.Text = ""
            cmbnama.Items.Add("Kerang")
            cmbnama.Items.Add("Kepiting")
            cmbnama.Items.Add("Lobster")

        ElseIf cmbjenis.Text = "Ayam" Then
            cmbnama.Items.Clear()
            cmbnama.Text = ""
            cmbnama.Items.Add("Ayam Goreng")
            cmbnama.Items.Add("Ayam Bakar")
            cmbnama.Items.Add("Ayam Geprek")

        ElseIf cmbjenis.Text = "Pizza" Then
            cmbnama.Items.Clear()
            cmbnama.Text = ""
            cmbnama.Items.Add("Pizza Pasta")
            cmbnama.Items.Add("Pizza Sicilia")
            cmbnama.Items.Add("Pizza Cheesy Crust")
        End If
    End Sub

    Private Sub cmbnama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbnama.SelectedIndexChanged
        If cmbnama.Text = "Kerang" Then
            txtharga.Text = 60000
        ElseIf cmbnama.Text = "Kepiting" Then
            txtharga.Text = 40000
        ElseIf cmbnama.Text = "Lobster" Then
            txtharga.Text = 100000
        ElseIf cmbnama.Text = "Ayam Goreng" Then
            txtharga.Text = 50000
        ElseIf cmbnama.Text = "Ayam Bakar" Then
            txtharga.Text = 90000
        ElseIf cmbnama.Text = "Ayam Geprek" Then
            txtharga.Text = 15000
        ElseIf cmbnama.Text = "Pizza Pasta" Then
            txtharga.Text = 120000
        ElseIf cmbnama.Text = "Pizza Sicilia" Then
            txtharga.Text = 120000
        ElseIf cmbnama.Text = "Pizza Cheesy Crust" Then
            txtharga.Text = 150000
        End If
    End Sub

    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        Call koneksi()
        txttotal.Text = Val(txtharga.Text) * Val(txtjumlah.Text)
        tampildatagrid()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        End
    End Sub
End Class
