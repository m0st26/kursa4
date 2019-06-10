Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, eps As Double
        Dim it As Double
        Dim z As String = ""
        a = TextBox1.Text
        b = TextBox2.Text
        it = TextBox3.Text
        eps = TextBox5.Text
        poli_opt(a, b, it, eps, z)
        TextBox4.Text = z
    End Sub
End Class