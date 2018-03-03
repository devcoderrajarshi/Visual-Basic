
Public Class Form1
    Dim a, b, c As Double
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = (a - b)
        MsgBox(c)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = (a * b)
        MsgBox(c)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = (a / b)
        MsgBox(c)
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = (a + b)
        MsgBox(c)

    End Sub
End Class
