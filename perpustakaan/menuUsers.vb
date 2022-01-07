Imports System.Data.SqlClient

Public Class menuUsers
    Dim Da As SqlDataAdapter
    Dim Cmd As SqlCommand
    Dim Rd As SqlDataReader
    Dim Ds As DataSet

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        profile.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        End

    End Sub

    Private Sub CariBukuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CariBukuToolStripMenuItem.Click
        masterPeminjaman.Show()


    End Sub

    Private Sub menuUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False

        Call formLogin.koneksi()
        Cmd = New SqlCommand("SELECT * from users where username = '" & formLogin.tbxusername.Text & "' ", formLogin.Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        If Rd.HasRows Then
            TextBox5.Text = Rd("id_users").ToString
            Rd.Close()

            If Rd.IsClosed Then
                Cmd = New SqlCommand("SELECT * FROM anggota where id_users = '" & TextBox5.Text & "'", formLogin.Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()

                If Rd.HasRows Then
                    TextBox1.Text = Rd("nama_lengkap").ToString
                    TextBox2.Text = Rd("nik").ToString
                    TextBox3.Text = Rd("Alamat").ToString
                    TextBox4.Text = Rd("tgl_daftar").ToString
                    TextBox6.Text = Rd("id_anggota")
                    MessageBox.Show("Berhasil")
                End If

            End If

        End If



    End Sub
End Class