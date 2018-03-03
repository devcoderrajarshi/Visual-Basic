Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, c, b As String
        a = TextBox1.Text
        b = TextBox2.Text
        c = a + " " & b
        TextBox3.Text = c

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class