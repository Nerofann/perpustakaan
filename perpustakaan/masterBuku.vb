Imports System.Data.SqlClient

Public Class masterBuku
    Dim Da As SqlDataAdapter
    Dim Ds As DataSet
    Dim Cmd As SqlCommand
    Dim Rd As SqlDataReader
    Dim urutanKode As String
    Dim kodeBuku As String
    Dim kodeLokasi As String
    Dim urutanLokasi As String

    Sub autoKodeBuku()
        Cmd = New SqlCommand("SELECT * FROM buku where kode_buku in (select max(kode_buku)from buku)", formLogin.Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        If Not Rd.HasRows Then

            kodeBuku = "BK" + "001"

        Else
            urutanKode = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            kodeBuku = "BK" + Microsoft.VisualBasic.Right("000" + urutanKode, 3)
        End If
        tbxKodebuku.Text = kodeBuku
        Rd.Close()

    End Sub
    Sub autoKodeLokasi()
        Cmd = New SqlCommand("SELECT * FROM lokasi where kode_lokasi in (select max(kode_Lokasi)from lokasi)", formLogin.Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()


        If Not Rd.HasRows Then
            kodeLokasi = "LK" + "001"

        Else
            urutanLokasi = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            kodeLokasi = "LK" + Microsoft.VisualBasic.Right("000" + urutanLokasi, 3)

        End If
        tbxKodeLokasi.Text = kodeLokasi
        Rd.Close()

    End Sub

    Sub lokItem()

        If CbxLantai.Text = "" Then
            Dim i As Integer
            i = 0
            While i < 3
                i = i + 1
                CbxLantai.Items.Add(i)

            End While


        ElseIf CbxLantai.Text = "1" Then
            CbxRak.Items.Clear()
            Dim j As Integer
            j = 0
            While j < 10
                j = j + 1
                CbxRak.Items.Add(j)

            End While

        ElseIf CbxLantai.Text = "2" Then
            CbxRak.Items.Clear()
            Dim r As Integer
            r = 10
            While r < 20
                r = r + 1
                CbxRak.Items.Add(r)

            End While

        ElseIf CbxLantai.Text = "3" Then
            CbxRak.Items.Clear()
            Dim a As Integer
            a = 20
            While a < 30
                a = a + 1
                CbxRak.Items.Add(a)

            End While

        Else
            MessageBox.Show("Masukkan nama lantai yang benar")

        End If



    End Sub

    Sub tabelBuku()
        Call formLogin.koneksi()
        Da = New SqlDataAdapter("SELECT buku.* , lokasi.lantai, lokasi.rak FROM buku join lokasi on(buku.kode_lokasi = lokasi.kode_lokasi)", formLogin.Conn)
        Ds = New DataSet
        Da.Fill(Ds, "buku")
        DGVbuku.DataSource = (Ds.Tables("buku"))
        



    End Sub

    Sub katBuku()
        Call formLogin.koneksi()
        Cmd = New SqlCommand("SELECT nama_kat FROM kategori order by id_kat", formLogin.Conn)
        Rd = Cmd.ExecuteReader

        While Rd.Read

            CbxKategori.Items.Add(Rd("nama_kat"))
        End While
        Rd.Close()

    End Sub

    Sub katAction()
        Call formLogin.koneksi()
        Cmd = New SqlCommand("SELECT nama_kat FROM kategori order by id_kat", formLogin.Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        If Rd.HasRows Then
            CbxKategori.Text = Rd("nama_kat").ToString

        End If
        Rd.Close()



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub masterBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tabelBuku()
        Call lokItem()
        Call katBuku()
        Call katAction()
        CbxKategori.Text = ""
        tbxCari.Focus()
        tbxKodebuku.Enabled = False
        tbxJudul.Enabled = False
        tbxPenulis.Enabled = False
        tbxPenerbit.Enabled = False
        tbxDeskripsi.Enabled = False
        tbxHarga.Enabled = False
        tbxStok.Enabled = False
        tbxKodeLokasi.Enabled = False
        CbxKategori.Enabled = False
        CbxRak.Enabled = False
        CbxLantai.Enabled = False


    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Call autoKodeBuku()
        Call autoKodeLokasi()
        If btnCreate.Text = "CREATE" Then
            btnCreate.Hide()
            tbxJudul.Text = ""
            tbxPenulis.Text = ""
            tbxPenerbit.Text = ""
            tbxDeskripsi.Text = ""
            tbxHarga.Text = ""
            tbxStok.Text = ""
            CbxKategori.Text = ""
            CbxRak.Text = ""
            CbxLantai.Text = ""
            TextBox1.Text = ""
            tbxJudul.Focus()
            DGVbuku.Enabled = False

        End If
        tbxJudul.Focus()
        tbxKodebuku.Enabled = False
        tbxJudul.Enabled = True
        tbxPenulis.Enabled = True
        tbxPenerbit.Enabled = True
        tbxDeskripsi.Enabled = True
        tbxHarga.Enabled = True
        tbxStok.Enabled = True
        tbxKodeLokasi.Enabled = False
        CbxKategori.Enabled = True
        CbxRak.Enabled = True
        CbxLantai.Enabled = True

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindKode.Click
        Call formLogin.koneksi()
        Dim findKode As String
        findKode = "SELECT * FROM buku where kode_buku like '%" & tbxCari.Text & "%' "
        Da = New SqlDataAdapter(findKode, formLogin.Conn)
        Ds = New DataSet
        Da.Fill(Ds, "buku")
        DGVbuku.DataSource = (Ds.Tables("buku"))

    End Sub

    Private Sub DGVbuku_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVbuku.CellClick
        Dim i As Integer
        i = DGVbuku.CurrentRow.Index

        tbxKodebuku.Text = DGVbuku.Item(0, i).Value
        tbxKodeLokasi.Text = DGVbuku.Item(1, i).Value
        TextBox1.Text = DGVbuku.Item(2, i).Value
        tbxJudul.Text = DGVbuku.Item(3, i).Value
        tbxPenulis.Text = DGVbuku.Item(4, i).Value
        tbxPenerbit.Text = DGVbuku.Item(5, i).Value
        tbxDeskripsi.Text = DGVbuku.Item(6, i).Value
        tbxHarga.Text = FormatNumber(DGVbuku.Item(7, i).Value)
        tbxStok.Text = DGVbuku.Item(8, i).Value
        CbxLantai.Text = DGVbuku.Item(9, i).Value
        CbxRak.Text = DGVbuku.Item(10, i).Value

        Call katAction()


    End Sub


    Private Sub CbxLantai_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxLantai.SelectedIndexChanged
        Call lokItem()
    End Sub

    Private Sub CbxKategori_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxKategori.SelectedIndexChanged

    End Sub

    Private Sub tbxKodebuku_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxKodebuku.TextChanged

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call formLogin.koneksi()
        Dim dataLokasi As String
        dataLokasi = "INSERT INTO lokasi values('" & tbxKodeLokasi.Text & "', 'Buku', '" & CbxLantai.Text & "', '" & CbxRak.Text & "')"
        Cmd = New SqlCommand(dataLokasi, formLogin.Conn)
        Cmd.ExecuteNonQuery()

        Dim dataBuku As String
        dataBuku = "INSERT INTO buku values('" & tbxKodebuku.Text & "','" & tbxKodeLokasi.Text & "', '" & TextBox1.Text & "', '" & tbxJudul.Text & "', '" & tbxPenulis.Text & "', '" & tbxPenerbit.Text & "', '" & tbxDeskripsi.Text & "', '" & tbxHarga.Text & "', '" & tbxStok.Text & "' ) "
        Cmd = New SqlCommand(dataBuku, formLogin.Conn)
        Cmd.ExecuteNonQuery()
        Call tabelBuku()


    End Sub

    Private Sub tbxCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxCari.TextChanged


    End Sub

    Private Sub btnFindName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindName.Click
        Call formLogin.koneksi()
        Dim nyariNama As String
        nyariNama = "SELECT buku.* , lokasi.lantai, lokasi.rak FROM buku join lokasi on (buku.kode_lokasi = lokasi.kode_lokasi) where judul like '%" & tbxCari.Text & "%' "
        Da = New SqlDataAdapter(nyariNama, formLogin.Conn)
        Ds = New DataSet
        Da.Fill(Ds, "buku")
        DGVbuku.DataSource = (Ds.Tables("buku"))
        Cmd = New SqlCommand(nyariNama, formLogin.Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()


        If Not Rd.HasRows Then
            MessageBox.Show("Buku tidak ada")

        End If
        Rd.Close()



    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

    End Sub

    Private Sub tbxKodeLokasi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxKodeLokasi.TextChanged

    End Sub

    Private Sub DGVbuku_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVbuku.CellContentClick

    End Sub

    Private Sub tbxHarga_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxHarga.TextChanged

    End Sub
End Class