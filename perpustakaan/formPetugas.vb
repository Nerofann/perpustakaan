Imports System.Data.SqlClient

Public Class w
    Dim simpan As DataSet
    Dim dataBuku As String

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call formLogin.koneksi()

    End Sub

    Private Sub ToolStripComboBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub LOGINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGINToolStripMenuItem.Click

    End Sub

    Private Sub MasterUsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterUsersToolStripMenuItem.Click

        masterUser.Show()


    End Sub

    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        End
    End Sub

    Private Sub MasterPetugasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterPetugasToolStripMenuItem.Click
        masterAnggota.Show()
    End Sub

    Private Sub MasterBukuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterBukuToolStripMenuItem.Click
        masterBuku.Show()
    End Sub

    Private Sub PeminjamanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeminjamanToolStripMenuItem.Click
        masterPeminjaman.Show()

    End Sub

    Private Sub PROFILEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PROFILEToolStripMenuItem.Click

    End Sub

    Private Sub MyProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyProfileToolStripMenuItem.Click
        profile.Show()

    End Sub
End Class