Imports System.Data.SqlClient

Public Class formDaftar

    Dim tblUser As String
    Dim Da As SqlDataAdapter
    Dim Ds As DataSet
    Dim Cmd As SqlCommand
    Dim Rd As SqlDataReader
    Dim urutan As String
    Dim hitung As String

    Sub autoUsers()
        Call formLogin.koneksi()
        TextBox1.Enabled = False
        Cmd = New SqlCommand("SELECT * FROM users where id_users in(select max(id_users) from users)", formLogin.Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        If Not Rd.HasRows Then
            urutan = "US" + "001"


        Else
            hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            urutan = "US" + Microsoft.VisualBasic.Right("000" & hitung, 3)

        End If
        TextBox1.Text = urutan
        Rd.Close()
    End Sub

    Sub autoAnggota()
        Call formLogin.koneksi()
        Dim anggotaId As String
        Dim finalId As String
        Cmd = New SqlCommand("SELECT * FROM anggota where id_anggota in(SELECT MAX(id_anggota) from anggota)", formLogin.Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()


        If Not Rd.HasRows Then
            finalId = "AG" + "001"

        Else
            anggotaId = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            finalId = "AG" + Microsoft.VisualBasic.Right("000" & anggotaId, 3)

        End If

        TextBox2.Text = finalId
        Rd.Close()

    End Sub

    Sub cekAkun()
            Dim dataRead As String
            dataRead = "SELECT * FROM users where username ='" & dafusername.Text & "' "
            Cmd = New SqlCommand(dataRead, formLogin.Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Rd.HasRows Then
                MessageBox.Show("Username sudah digunakan")
                dafusername.Focus()
                dafusername.Text = ""

                If MsgBoxResult.Ok Then
                    Rd.Close()


                End If

            Else
                Rd.Close()

            End If

    End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        formLogin.Show()
        Me.Hide()
        formLogin.captcha()





    End Sub

    Private Sub dafusername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dafusername.KeyPress
        Dim boleh = "abcdefghijklmnopqrstuvwxyz1234567890_"
        e.Handled = Not (boleh.Contains(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dafusername.TextChanged

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call autoAnggota()
        Call autoUsers()





    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If dafusername.Text = "" Or dafPass.Text = "" Then
            MessageBox.Show("Kolom tidak boleh kosong")

        Else
            Call cekAkun()
            Call formLogin.koneksi()
            Dim inputDataUsers As String
            inputDataUsers = "INSERT INTO users values('" & TextBox1.Text & "','" & dafusername.Text & "', '" & dafPass.Text & "', 'users')"
            Cmd = New SqlCommand(inputDataUsers, formLogin.Conn)
            Cmd.ExecuteNonQuery()

            Cmd = New SqlCommand("SELECT * FROM users where id_users = '" & TextBox1.Text & "' ", formLogin.Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Rd.HasRows Then
                MessageBox.Show("Tersimpan, Mohon Lanjut mengisi identitas anda")
                formIdentitas.Show()
                Me.Hide()

            Else
                MessageBox.Show("Data tidak tersimpan")

            End If

        End If

        


    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub dafPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dafPass.KeyPress
        e.Handled = Not (Char.IsLetterOrDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub

End Class