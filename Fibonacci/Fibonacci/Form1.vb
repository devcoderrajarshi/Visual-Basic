Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b As Integer
        Dim i As Integer
        Dim aux As Integer
        Dim n As Integer
        n = Val(TextBox1.Text)
        a = 0
        b = 1
        TextBox2.Text = Val(a)
        TextBox2.Text = Val(b)
        For i = 0 To n - 2
            aux = a + b
            TextBox2.Text = Val(aux)
            a = b
            b = aux
        Next i
    End Sub
End Class
