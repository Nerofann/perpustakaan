Imports System.Data.SqlClient

Public Class masterAnggota
    Dim Da As SqlDataAdapter
    Dim Ds As DataSet
    Dim Cmd As SqlCommand
    Dim Rd As SqlDataReader
    Dim tblAnggota As String

    Sub tabelAnggota()
        Call formLogin.koneksi()
        Da = New SqlDataAdapter("SELECT * FROM anggota", formLogin.Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "anggota")
        DGVanggota.DataSource = (Ds.Tables("anggota"))


    End Sub



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tabelAnggota()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False



    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub DGVanggota_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVanggota.CellClick
        Dim i As Integer
        i = DGVanggota.CurrentRow.Index

        TextBox1.Text = DGVanggota.Item(0, i).Value
        TextBox2.Text = DGVanggota.Item(1, i).Value
        TextBox3.Text = DGVanggota.Item(2, i).Value
        TextBox4.Text = DGVanggota.Item(3, i).Value
        TextBox5.Text = DGVanggota.Item(4, i).Value




    End Sub

    
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

        TextBox1.Text = finalId
        Rd.Close()
       
        If TextBox1.Text <> " " Then
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            DGVanggota.Enabled = False

        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call formLogin.koneksi()
        Dim dataAnggota As String
        Dim autoIdUser As String
        autoIdUser = "SELECT users.id_users, users.username, anggota.nama_lengkap FROM anggota join users on (users.id_users=anggota.id_users)"
        Cmd = New SqlCommand(autoIdUser, formLogin.Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        Dim idUser As String = masterUser.urutan
        TextBox6.Text = masterUser.urutan
        dataAnggota = "INSERT INTO anggota values('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', cast('" & TextBox5.Text & "' as date),) "
        Cmd = New SqlCommand(dataAnggota, formLogin.Conn)
        Cmd.ExecuteNonQuery()
        Call tabelAnggota()
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        DGVanggota.Enabled = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "EDIT" Then

        End If

    End Sub

    Private Sub DGVanggota_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVanggota.CellContentClick
        Dim i As Integer
        i = DGVanggota.CurrentRow.Index

        TextBox1.Text = DGVanggota.Item(0, i).Value
        TextBox2.Text = DGVanggota.Item(1, i).Value
        TextBox3.Text = DGVanggota.Item(2, i).Value
        TextBox4.Text = DGVanggota.Item(3, i).Value
        TextBox5.Text = DGVanggota.Item(4, i).Value


    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call formLogin.koneksi()
        Cmd = New SqlCommand("DELETE FROM anggota where id_anggota = '" & TextBox1.Text & "' ", formLogin.Conn)
        Cmd.ExecuteNonQuery()

        Rd = Cmd.ExecuteReader
        If Not Rd.HasRows Then
            MessageBox.Show("Anggota terhapus")
        End If
        Call tabelAnggota()

    End Sub
End Class