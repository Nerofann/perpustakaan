Imports System.Data.SqlClient

Public Class detailPinjam
    Dim Da As SqlDataAdapter
    Dim Ds As DataSet
    Dim Cmd As SqlCommand
    Dim Rd As SqlDataReader

    Sub autoStruk()
        Call formLogin.koneksi()
        Dim strukKode As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
        Dim count = 0
        Dim rndm As New Random
        Dim hasil As String = ""
        Dim yauda = ""
        While count < 10
            yauda = rndm.Next(0, strukKode.Length)
            hasil = hasil & strukKode(yauda)
            count = count + 1
        End While
        TextBox7.Text = "STK-" + hasil
        Cmd = New SqlCommand("SELECT * FROM peminjaman_buku", formLogin.Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

    End Sub

    Sub jumlahPinjam()
        Dim totalBayar As Integer
        totalBayar = TextBox5.Text * TextBox9.Text
        TextBox6.Text = FormatNumber(totalBayar)

    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub detailPinjam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call autoStruk()
        TextBox1.Text = masterPeminjaman.TextBox1.Text
        TextBox2.Text = masterPeminjaman.TextBox2.Text
        TextBox3.Text = masterPeminjaman.TextBox3.Text
        TextBox4.Text = menuUsers.TextBox1.Text
        TextBox5.Text = masterPeminjaman.TextBox4.Text
        TextBox9.Text = masterPeminjaman.NumericUpDown1.Value
        kodeBuku.Text = masterPeminjaman.kodeBuku.Text
        idAnggota.Text = menuUsers.TextBox6.Text
        TextBox8.Text = masterPeminjaman.TextBox5.Text
        Call jumlahPinjam()
        Call formLogin.koneksi()




    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Call formLogin.koneksi()
        Dim dataPinjam As String
        dataPinjam = "INSERT INTO peminjaman values('" & TextBox7.Text & "', '" & idAnggota.Text & "', '" & TextBox10.Text & "') "
        Cmd = New SqlCommand(dataPinjam, formLogin.Conn)
        Cmd.ExecuteNonQuery()

        Cmd = New SqlCommand("SELECT * FROM peminjaman where id_pinjam = '" & TextBox7.Text & "' ", formLogin.Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        If Rd.HasRows Then
            Rd.Close()

            If Rd.IsClosed Then
                Call formLogin.koneksi()
                Cmd = New SqlCommand("INSERT INTO peminjaman_buku (kode_buku , id_pinjam , tgl_pinjam, status , denda , jml_hari_denda )  values('" & kodeBuku.Text & "', '" & TextBox7.Text & "', CAST (GETDATE () as date), 'Perlu Dibayar', '0', '0')", formLogin.Conn)
                Cmd.ExecuteNonQuery()

                Cmd = New SqlCommand("SELECT * FROM peminjaman_buku where id_pinjam = '" & TextBox7.Text & "' ", formLogin.Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()

                If Rd.HasRows Then
                    Rd.Close()
                    MessageBox.Show("Silahkan ke kasir untuk melakukan pembayaran")
                    Me.Hide()
                    buktiPembayaran.Show()

                Else
                    MessageBox.Show("Gagal Melakukan Transaksai")

                End If

            End If

        End If





    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        panduanTransaksi.Show()

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        masterPeminjaman.Show()

    End Sub

    Private Sub idAnggota_TextChanged(sender As Object, e As EventArgs) Handles idAnggota.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged

    End Sub
End Class