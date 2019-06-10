Public Class Form6
    Public result As String = ""
    Public a, b, ee As Double
    Public met As Integer
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Hide() : TextBox2.Hide() : TextBox3.Hide()
        Label2.Hide() : Label3.Hide() : Label4.Hide() : Label5.Hide()
        Button5.Hide() : Button4.Hide() : Button8.Hide() '5- выполнить 4 - лог 8 - другой метод
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        a = TextBox1.Text
        b = TextBox2.Text
        ee = TextBox3.Text
        TextBox1.Hide() : TextBox2.Hide() : TextBox3.Hide()
        Label3.Hide() : Label4.Hide() : Label5.Hide()
        Button5.Hide()
        Label2.Show()
        If met = 1 Then
            optim(a, b, ee, result, False)
        ElseIf met = 2 Then
            polovinka(a, b, ee, result, False)
        ElseIf met = 3 Then
            result = "Результат интегрирования:" & Space(2) & Simp(a, b, ee, False)
        End If
        loutput(result, Label2)
        Beep()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        End
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()
        Form1.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        z = ""
        TextBox1.Text = "" : TextBox2.Text = "" : TextBox3.Text = "" : Label2.Text = ""
        TextBox1.Hide() : TextBox2.Hide() : TextBox3.Hide()
        Label2.Hide() : Label3.Hide() : Label4.Hide() : Label5.Hide()
        Button5.Hide() : Button4.Hide() : Button8.Hide()
        Label1.Show() : Button1.Show() : Button2.Show() : Button3.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        z = ""
        met = 1
        Label1.Hide()
        Button1.Hide() : Button2.Hide() : Button3.Hide()
        TextBox1.Show() : TextBox2.Show() : TextBox3.Show()
        Label3.Show() : Label4.Show() : Label5.Show()
        Button5.Show() : Button4.Show() : Button8.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form4.Show()
        Form4.TextBox1.Text = ""
        Form4.TextBox1.Text = z
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        z = ""
        met = 2
        Label1.Hide()
        Button1.Hide() : Button2.Hide() : Button3.Hide()
        TextBox1.Show() : TextBox2.Show() : TextBox3.Show()
        Label3.Show() : Label4.Show() : Label5.Show()
        Button5.Show() : Button4.Show() : Button8.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        z = ""
        met = 3
        Label1.Hide()
        Button1.Hide() : Button2.Hide() : Button3.Hide()
        TextBox1.Show() : TextBox2.Show() : TextBox3.Show()
        Label3.Show() : Label4.Show() : Label5.Show()
        Button5.Show() : Button4.Show() : Button8.Show()
    End Sub
    ' label1 - выберите метод button 1-3,6-7 скрыть
End Class