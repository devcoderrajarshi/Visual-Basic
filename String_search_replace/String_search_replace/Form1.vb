Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (InStr(TextBox1.Text, TextBox2.Text) = 0) Then
            MsgBox("The Substring you have entered not found")
        Else
            MsgBox("The Substring is found")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox4.Text = Replace(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
