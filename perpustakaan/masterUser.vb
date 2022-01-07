Imports System.Data.SqlClient

Public Class masterUser
    Dim tblUser As String
    Dim Da As SqlDataAdapter
    Dim Ds As DataSet
    Dim Cmd As SqlCommand
    Dim Rd As SqlDataReader
    Public Shared urutan As String
    Dim hitung As String

    Sub tabelUser()
        Call formLogin.koneksi()
        Da = New SqlDataAdapter("SELECT * FROM users", formLogin.Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "users")
        DGVusers.DataSource = (Ds.Tables("users"))

    End Sub


    Sub cari()
        Call formLogin.koneksi()
        Dim search As String
        search = "SELECT * FROM users where id_users = '" & TextBox5.Text & "' Or username = '" & TextBox5.Text & "' "
        Da = New SqlDataAdapter(search, formLogin.Conn)
        Ds = New DataSet
        Da.Fill(Ds, "users")
        DGVusers.DataSource = (Ds.Tables("users"))
        Cmd = New SqlCommand(search, formLogin.Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        If Not Rd.HasRows Then
            MessageBox.Show("Users tidak terdaftar")
        End If

    End Sub


    Private Sub masterUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tabelUser()
        ComboBox1.Items.Add("admin")
        ComboBox1.Items.Add("users")

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        ComboBox1.Enabled = False
        TextBox1.Text = urutan
        btnSave.Hide()


    End Sub

    Private Sub DGVusers_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVusers.CellClick
        Dim i As Integer
        i = DGVusers.CurrentRow.Index
        On Error Resume Next

        TextBox1.Text = DGVusers.Item(0, i).Value
        TextBox2.Text = DGVusers.Item(1, i).Value
        TextBox3.Text = DGVusers.Item(2, i).Value
        ComboBox1.Text = DGVusers.Item(3, i).Value


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call formLogin.koneksi()
        If Button2.Text = "EDIT" Then
            Button2.Text = "UPDATE"
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            ComboBox1.Enabled = True

        ElseIf Button2.Text = "UPDATE" Then
            Dim editData As String
            editData = "UPDATE users SET username = '" & TextBox2.Text & "', password = '" & TextBox3.Text & "', level = '" & ComboBox1.Text & "' WHERE id_users = '" & TextBox1.Text & "' "
            Da = New SqlDataAdapter(editData, formLogin.Conn)
            Cmd = New SqlCommand(editData, formLogin.Conn)
            Ds = New DataSet
            Da.Fill(Ds, "users")
            DGVusers.DataSource = (Ds.Tables("users"))
            Call tabelUser()
            Button2.Text = "EDIT"
            MessageBox.Show("Data berhsail diubah")

            TextBox2.Enabled = False
            TextBox3.Enabled = False
            ComboBox1.Enabled = False

        End If

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Call cari()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call formLogin.koneksi()

        If TextBox1.Text = " " Then
            MessageBox.Show("Pilih user terlebih dahulu")

        Else
            Dim hapus As String
            hapus = "DELETE FROM anggota where id_users = '" & TextBox1.Text & "' "
            Cmd = New SqlCommand(hapus, formLogin.Conn)
            Cmd.ExecuteNonQuery()
            Call tabelUser()

            Dim hapusUsers As String
            hapusUsers = "DELETE FROM users where id_users = '" & TextBox1.Text & "' "
            Cmd = New SqlCommand(hapusUsers, formLogin.Conn)
            Cmd.ExecuteNonQuery()
            Call tabelUser()


            'MsgBox("Yakin ingin menghapus ?", vbYesNo)
            'If MsgBoxResult.Yes Then


            'End If

        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Call formLogin.koneksi()
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        ComboBox1.Enabled = True
        Cmd = New SqlCommand("SELECT * FROM users where id_users in(select max(id_users) from users)", formLogin.Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        If Not Rd.HasRows Then
            urutan = "US" + "001"
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            ComboBox1.Enabled = True


        Else
            hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            urutan = "US" + Microsoft.VisualBasic.Right("000" & hitung, 3)

        End If
        TextBox1.Text = urutan
        Rd.Close()
        btnCreate.Hide()
        btnSave.Show()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call formLogin.koneksi()
        Dim input As String
        input = "INSERT INTO users values ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & ComboBox1.Text & "') "
        Cmd = New SqlCommand(input, formLogin.Conn)
        Cmd.ExecuteNonQuery()
        Call tabelUser()
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        ComboBox1.Enabled = False
        btnSave.Hide()
        btnCreate.Show()
        MessageBox.Show("Berhasil")


    End Sub

End Class