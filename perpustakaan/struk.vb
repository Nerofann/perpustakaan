Imports System.Data.SqlClient

Public Class struk
    Dim Da As SqlDataAdapter
    Dim Ds As DataSet
    Dim Cmd As SqlCommand
    Dim Rd As SqlDataReader

    Private Sub struk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox7.Text = detailPinjam.TextBox7.Text
        TextBox1.Text = detailPinjam.TextBox1.Text
        TextBox3.Text = detailPinjam.TextBox5.Text
        TextBox4.Text = detailPinjam.TextBox9.Text
        TextBox5.Text = FormatNumber(detailPinjam.TextBox6.Text)
        TextBox6.Text = FormatNumber(detailPinjam.TextBox6.Text)


    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub


End Class