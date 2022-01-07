Public Class buktiPembayaran
    Private Sub buktiPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox7.Text = detailPinjam.TextBox7.Text
        TextBox1.Text = detailPinjam.TextBox1.Text
        TextBox3.Text = detailPinjam.TextBox5.Text
        TextBox4.Text = detailPinjam.TextBox9.Text
    End Sub
End Class