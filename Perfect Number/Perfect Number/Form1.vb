Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, sum, a, i As Integer

        n = Val(TextBox1.Text)
        a = n
        For i = 1 To (n / 2)
            If n Mod i = 0 Then
                sum = sum + i
            End If
        Next i
        If sum = a Then
            MsgBox("This number is a perfect Number")
        Else
            MsgBox("This number is not a perfect Number")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
