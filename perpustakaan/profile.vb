Imports System.Data.SqlClient

Public Class profile
    Dim Da As SqlDataAdapter
    Dim Cmd As SqlCommand
    Dim Rd As SqlDataReader
    Dim Ds As DataSet

    Sub dataDiri()
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
                    MessageBox.Show("data ada")
                End If

            End If

        End If


    End Sub

    Private Sub profile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call dataDiri()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class