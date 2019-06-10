Imports System.Math
Public Class Form2
    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, exp As Double
        Dim result As String = ""
        Dim z As String = ""
        a = CDbl(TextBox1.Text)
        b = CDbl(TextBox2.Text)
        exp = CDbl(TextBox3.Text)
        optim(a, b, exp, result, True)
        loutput(result, Label5)
        TextBox1.Hide() : TextBox2.Hide() : TextBox3.Hide()
        Label2.Hide() : Label3.Hide() : Label4.Hide()
        Button5.Show()
        Label5.Show()
        Beep()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'главное меню
        Form1.Show()
        Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'вiхiд
        End
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form4.Show()
        Form4.TextBox1.Text = ""
        Form4.TextBox1.Text = z
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'нужно чтобы не выводилась сразу кнопка для перезапуска и лэйбл с результатами
        Button5.Hide()
        Label5.Hide()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'кнопка перезапуска решения
        TextBox1.Show() : TextBox2.Show() : TextBox3.Show()
        Label2.Show() : Label3.Show() : Label4.Show()
        Button5.Hide()
        Label5.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form5.Show()
    End Sub
End Class