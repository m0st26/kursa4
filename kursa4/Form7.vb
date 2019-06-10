Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, eps As Double
        Dim it As Double
        Dim z As String = ""
        a = TextBox2.Text
        b = TextBox3.Text
        it = TextBox4.Text
        eps = TextBox5.Text
        poli_nu(a, b, it, eps, z)
        TextBox1.Text = z
    End Sub
End Class