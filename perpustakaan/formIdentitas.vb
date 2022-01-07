Imports System.Data.SqlClient


Public Class formIdentitas
    Dim Cmd As SqlCommand
    Dim Rd As SqlDataReader

    Sub dataUsers()
       

    End Sub


    Private Sub formIdentitas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If dafNik.TextLength <> 16 Then
            MessageBox.Show("Panjang nik harus 16 digit")

        Else
            Call formLogin.koneksi()
            Dim inputDataAnggota As String
            inputDataAnggota = "INSERT INTO anggota values('" & formDaftar.TextBox2.Text & "','" & dafNama.Text & "', '" & dafNik.Text & "', '" & dafAlamat.Text & "', cast(GETDATE() as date), '" & formDaftar.TextBox1.Text & "')"
            Cmd = New SqlCommand(inputDataAnggota, formLogin.Conn)
            Cmd.ExecuteNonQuery()

            Dim cekDataMasuk As String
            cekDataMasuk = "SELECT users.id_users, anggota.id_users FROM users join anggota on (users.id_users = anggota.id_users) where users.id_users = '" & formDaftar.TextBox1.Text & "' "
            Cmd = New SqlCommand(cekDataMasuk, formLogin.Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Rd.HasRows Then
                MessageBox.Show("Data tersimpan")
                formLogin.Show()
                formLogin.captcha()
                Me.Hide()

            Else
                MessageBox.Show("Gagal")
            End If

        End If
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        formDaftar.Show()

    End Sub

    Private Sub dafNama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dafNama.TextChanged

    End Sub

    Private Sub dafNik_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dafNik.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub

    Private Sub dafNik_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dafNik.TextChanged

    End Sub
End Class