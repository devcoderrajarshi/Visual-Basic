Public Class Form1



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, i, flag As Double
        flag = 0
        n = Val(TextBox1.Text)
        If n = 2 Then
            MsgBox("This is a Prime Number ")
        Else
            For i = 3 To (n / 2)
                If n Mod i = 0 Then
                    flag = flag + 1
                End If
            Next i
            If flag = 0 Then
                MsgBox("This is a Prime Number ")
            Else
                MsgBox("This is not a Prime Number ")
            End If
        End If


    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
    End Sub
End Class
