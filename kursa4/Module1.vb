Imports System.Math
Module Module1
    Public z As String = ""
    Public c As Double
    Public fun As Double
    Public Delegate Function func(ByVal x As Double) As Double
    Public Sub voutput(ByVal s As String, ByRef t As TextBox) 'вывод в текстбох
        t.Text = s
    End Sub
    Public Sub loutput(ByVal s As String, ByRef t As Label)
        t.Text = s
    End Sub
    Function integ(ByVal x As Double, ByVal method As Boolean) As Double
        If method Then
            fun = Exp(Pow(x, 2))
        Else
            fun = Pow(x, 2) + 4
        End If
        Return fun
    End Function
    Function one(ByVal x0 As Double, ByVal x1 As Double, ByVal e As Single) As Double 'это минимум функции. он для проверки епта
        Dim x As Double
        x = Exp(Pow(-x1, 2)) * Simp(x0, x1, e, True)
        Return x
    End Function
    Function maxone(ByVal x0 As Double, ByVal x1 As Double, ByVal e As Single, ByVal method As Boolean) As Double 'это максимум функции 
        If method Then
            fun = -one(x0, x1, e)
        Else
            fun = 5 * Exp(-x1) + 4 * x1 + x1 ^ 3 / 3
        End If
        Return fun
    End Function
    Sub optim(ByRef a As Double, ByRef b As Double, ByRef exp As Double, ByRef res As String, ByVal method As Boolean) 'первое задание 
        z = ""
        res = ""
        Dim x1, x2, k1, k2, F1, F2, fa, xa, x0 As Double
        x0 = 0
        k1 = (3 - Sqrt(5)) / 2 : k2 = (Sqrt(5) - 1) / 2
        x1 = a + k1 * (b - a) : x2 = a + k2 * (b - a)
        F1 = maxone(x0, x1, exp, method) : F2 = maxone(x0, x2, exp, method)
            Do
                If F1 < F2 Then
                    b = x2
                    x2 = x1
                    x1 = a + k1 * (b - a)
                    F2 = F1
                    F1 = Abs(maxone(x0, x1, exp, method))
                Else
                    a = x1
                    x1 = x2
                    x2 = a + k2 * (b - a)
                    F1 = F2
                    F2 = Abs(maxone(x0, x2, exp, method))
                End If
                z = z + "Решение Оптимизации" + vbNewLine + " a= " & Format(a, "0.00000  |  ") & " b=" & Format(b, "0.00000  |  ") & " x1= " & Format(x1, "0.00000  |  ") & " x2=" & Format(x2, "0.00000  |  ") _
 & " F(x1)= " & Format(maxone(x0, x1, exp, method), "0.00000  |  ") & " F(x2)=" & Format(maxone(x0, x2, exp, method), "0.00000  |  ") & " (a-b)=" & Format((b - a), "0.00000  |  " & vbNewLine)
                z = z + vbCrLf
            Loop While (b - a) > exp
            xa = (a + b) / 2
            fa = maxone(x0, xa, exp, method)
            z = z + " f(x)=" & fa & " x=" & xa
        res = "Результат:" & vbNewLine & "Максимум функции" & Space(1) & -fa & Space(1) & "при x =" & -xa
    End Sub
    Public Function Simp(ByVal x0 As Single, ByVal x1 As Single, ByVal e As Single, ByVal method As Boolean) As Single
        Dim n As Integer = 2
        Dim cc, i As Integer
        Dim h As Single
        Dim s As Single
        Dim s1, x As Single
        s = (integ(x0, method) + 4 * integ((x0 + x1) / 2, method) + integ(x1, method)) * h / 3
        z = z + "Решение симпосоном" + vbNewLine
        z = z + Space(2) + "h=" + Format(h, "0.0000") + Space(6) + "S1=" + Format(s1, "0.0000") + Space(6) + "S=" + Format(s, "0.0000") + Space(6) + "n=" + CStr(n) + vbNewLine
        z = z + vbNewLine
        z = z + Space(2) + "h=" + Format(h, "0.0000") + Space(6) + Space(6) + "S=" + Format(s, "0.0000") + Space(6) + "n=" + CStr(n) + vbNewLine
        Do
            n = n * 2
            h = (x1 - x0) / n
            s1 = s
            cc = 4
            x = x0
            s = integ(x0, method) + integ(x1, method)
            For i = 1 To n - 1
                x = x + h
                s = s + cc * integ(x, method)
                cc = 6 - cc
            Next
            s = s * h / 3
            z = z + Space(2) + "h=" + Format(h, "0.0000") + Space(6) + "S1=" + Format(s1, "0.0000") + Space(6) + "S=" + Format(s, "0.0000") + Space(6) + "n=" + CStr(n) + vbNewLine
            z = z + vbNewLine
            z = z + Space(2) + "h=" + Format(h, "0.0000") + Space(6) + Space(6) + "S=" + Format(s, "0.0000") + Space(6) + "n=" + CStr(n) + vbNewLine
        Loop Until Abs(s - s1) / 15 < e
        Return s
    End Function
    Public Sub poli_opt(ByVal a As Double, ByVal b As Double, ByVal it As Integer, ByVal eps As Double, ByRef z As String)
        Dim method As Boolean = True
        Dim h As Double
        h = (b - a) / it
        b = a
        For i = 0 To it
            z = z + "a=" + Format(a, "0.0000") + Space(2) + "b=" + Format(b, "0.0000") + Space(2) + "x=" + Format(maxone(a, b, eps, method), "0.0000") + vbNewLine
            b = b + h
        Next
    End Sub
    Sub poli_nu(ByVal a As Double, ByVal b As Double, ByVal it As Integer, ByVal eps As Double, ByRef z As String)
        Dim method As Boolean = True
        Dim h As Double
        h = (b - a) / it
        b = a
        For i = 0 To it
            z = z + "a=" + Format(a, "0.0000") + Space(2) + "b=" + Format(b, "0.0000") + Space(2) + "x=" + Format(two(b, eps, method), "0.0000" + vbNewLine)
            b = b + h
        Next
    End Sub
    Sub polovinka(ByVal a As Double, ByVal b As Double, ByVal e As Double, ByRef result As String, ByVal method As Boolean)
        z = ""
        result = ""
        Dim n As Integer
        c = (a + b) / 2
        n = 0
        Do Until (b - a) < e
            n = n + 1
            If (two(c, e, method) * two(b, e, method) < 0) Then
                a = c
            Else
                b = c
            End If
            z = z & "Решение методом половинного деления" + vbNewLine + (Format(a, "0.0000")) + Space(11) + (Format(b, "0.0000")) + Space(11) + (Format(two(a, e, method), "0.000000")) + Space(11) + (Format(two(b, e, method), "0.000000")) + vbNewLine
            c = (a + b) / 2
        Loop
        result = "Корень уравнения x:" & c & vbNewLine + "Колличество итераций: " & n
    End Sub

    Function two(ByVal x As Double, ByVal eps As Double, ByVal method As Boolean) As Double
        If method Then
            fun = 3 * Sin(Pow(x, 1 / 2)) + x - 3
        Else
            fun = 3 * Sin(Pow(x, 1 / 2)) + x - 3
        End If
        Return fun
    End Function
End Module
