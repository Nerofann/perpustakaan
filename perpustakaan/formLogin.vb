Imports System.Data.SqlClient


Public Class formLogin
    Public Shared Conn As SqlConnection
    Dim Da As SqlDataAdapter
    Dim Cmd As SqlCommand
    Dim Rd As SqlDataReader
    Dim Ds As DataSet
    Dim MyDB As String
    Dim loginB As Boolean
    Public Shared hasil As String = ""
    Public Shared namaPeminjam As String = ""


    Sub koneksi()
        MyDB = "data source=WINDOWS-1SSA0J1;initial catalog=Perpustakaan;integrated security=true"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()

    End Sub

    Sub kondisiAwal()
        Call koneksi()
        Da = New SqlDataAdapter("SELECT * FROM  petugas", Conn)
    End Sub

    Sub captcha()
        Dim nilai As String = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz"

        Dim count = 0
        Dim rndm As New Random
        Dim yauda = ""

        While count < 5
            yauda = rndm.Next(0, nilai.Length)
            hasil = hasil & nilai(yauda)
            count = count + 1


        End While

        TextBox1.Text = hasil
        tbxcaptcha.Text = hasil

    End Sub

    Sub login()
        Call koneksi()
        Dim check As String
        check = "SELECT * FROM users where username = '" & tbxusername.Text & "' and password = '" & tbxpassword.Text & "' "
        Cmd = New SqlCommand(check, Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()



        If Rd.HasRows Then
            namaPeminjam = Rd("id_users").ToString

            If tbxcaptcha.Text <> hasil Then
                MessageBox.Show("Kode Captcha tidak sama")

            ElseIf tbxcaptcha.Text = hasil Then

                If Rd("level").ToString = "admin" Then

                    w.Show()
                    Me.Hide()

                ElseIf Rd("level").ToString <> "admin" Then
                    menuUsers.Show()
                    Me.Hide()

                End If

            End If

        Else
            MessageBox.Show("Username atau password yang anda gunakan salah")
        End If

    End Sub


    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxpassword.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbljudul.Click

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxcaptcha.TextChanged

    End Sub

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        If TextBox1.Text = "" Then
            Call captcha()

        Else
            hasil = ""

        End If



    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Call login()
        If tbxusername.Text = "" Or tbxpassword.Text = "" Then
            MessageBox.Show("Username Dan Password tidak boleh kosong")

        End If



    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Daftar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Daftar.LinkClicked
        formDaftar.Show()
        Me.Hide()
        hasil = ""


    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub xnama()
        Throw New NotImplementedException
    End Sub

    Private Function XName() As Object()
        Throw New NotImplementedException
    End Function

End Class
