Imports System.Data.SqlClient

Public Class masterPeminjaman
    Dim Da As SqlDataAdapter
    Dim Ds As DataSet
    Dim Cmd As SqlCommand
    Dim Rd As SqlDataReader

    'Sub tabelPeminjaman()
    'Call formLogin.koneksi()
    'Dim tabelPeminjaman As String
    'tabelPeminjaman = "SELECT peminjaman.* , peminjaman_buku.id, peminjaman_buku.kode_buku , peminjaman_buku.tgl_kembali , peminjaman_buku.tgl_kembali , peminjaman_buku.denda , peminjaman_buku.jml_hari_denda from peminjaman join peminjaman_buku on(peminjaman.id_pinjam = peminjaman_buku.id_pinjam)"
    'Da = New SqlDataAdapter(tabelPeminjaman, formLogin.Conn)
    'Ds = New DataSet
    ' Da.Fill(Ds, "peminjaman")
    'DGVpeminjaman.DataSource = (Ds.Tables("peminjaman"))

    'End Sub
    Sub tabelBuku()
        Call formLogin.koneksi()
        Da = New SqlDataAdapter("SELECT kode_buku, judul, penulis, penerbit, deskripsi, harga FROM buku", formLogin.Conn)
        Ds = New DataSet
        Da.Fill(Ds, ("buku"))
        DGVpeminjaman.DataSource = (Ds.Tables("buku"))


    End Sub

    Private Sub masterPeminjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call tabelPeminjaman()
        Call tabelBuku()

    End Sub

    Private Sub btnCariNama_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariNama.Click
        Call formLogin.koneksi()
        Dim findName As String
        findName = "SELECT * FROM buku where judul like '%" & tbxCari.Text & "%' "
        Da = New SqlDataAdapter(findName, formLogin.Conn)
        Ds = New DataSet
        Da.Fill(Ds, "buku")
        DGVpeminjaman.DataSource = (Ds.Tables("buku"))

    End Sub

    Private Sub btnCariKode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariKode.Click
        Call formLogin.koneksi()
        Dim findKode As String
        findKode = "SELECT * FROM buku where kode_buku like '%" & tbxCari.Text & "%' "
        Da = New SqlDataAdapter(findKode, formLogin.Conn)
        Ds = New DataSet
        Da.Fill(Ds, "buku")
        DGVpeminjaman.DataSource = (Ds.Tables("buku"))


    End Sub

    Private Sub btnCariPenulis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariPenulis.Click
        Call formLogin.koneksi()
        Dim findPenulis As String
        findPenulis = "SELECT * FROM buku where penulis like '%" & tbxCari.Text & "%' "
        Da = New SqlDataAdapter(findPenulis, formLogin.Conn)
        Ds = New DataSet
        Da.Fill(Ds, "buku")
        DGVpeminjaman.DataSource = (Ds.Tables("buku"))

    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        If NumericUpDown1.Value = 0 Then
            MessageBox.Show("Jumlah minimal pinjam = 1")

        Else
            Call formLogin.koneksi()
            Cmd = New SqlCommand("SELECT * FROM petugas where nama_petugas = '" & TextBox5.Text & "' ", formLogin.Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            detailPinjam.TextBox10.Text = Rd("id_petugas").ToString
            detailPinjam.Show()
            Rd.Close()

        End If

    End Sub

    Private Sub DGVpeminjaman_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVpeminjaman.CellClick
        Dim i As Integer
        i = DGVpeminjaman.CurrentRow.Index

        kodeBuku.Text = DGVpeminjaman.Item(0, i).Value
        TextBox1.Text = DGVpeminjaman.Item(1, i).Value
        TextBox2.Text = DGVpeminjaman.Item(2, i).Value
        TextBox3.Text = DGVpeminjaman.Item(3, i).Value
        TextBox4.Text = FormatNumber(DGVpeminjaman.Item(5, i).Value)

    End Sub


    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub
End Class