Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button4.Hide()
        Button2.Hide()
        Label1.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, eps As Double
        Dim result As String = ""
        a = TextBox1.Text
        b = TextBox2.Text
        eps = TextBox3.Text
        polovinka(a, b, eps, result, True)
        TextBox1.Hide() : TextBox2.Hide() : TextBox3.Hide() : Label2.Hide() : Label3.Hide() : Label4.Hide() : Button6.Hide()
        Button1.Hide()
        Button2.Show() : Button4.Show()
        Label1.Show()
        loutput(result, Label1)
        Beep()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
        Form4.TextBox1.Text = ""
        Form4.TextBox1.Text = z
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Hide()
        Form1.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Show() : TextBox2.Show() : TextBox3.Show()
        Label2.Show() : Label3.Show() : Label4.Show()
        Button2.Hide() : Button4.Hide()
        Label1.Hide()
        Button1.Show()
        Button6.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form7.Show()
    End Sub
End Class