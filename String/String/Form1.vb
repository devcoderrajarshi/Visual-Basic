Public Class Form1
    Dim brray(30), findthis As String
    Dim str, k As String
    Dim a, i, b As Integer

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox5.Text = Val(TextBox1.Text.Length - 1)
    End Sub



    Dim flag As Integer = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        brray(30) = TextBox1.Text
        findthis = TextBox2.Text


        For Each str In brray(30)
            If str.Contains(findthis) Then
                MsgBox("String " & findthis & " found")
            End If
        Next
    End Sub









    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        brray(30) = TextBox1.Text
        findthis = TextBox2.Text
        k = TextBox3.Text
        For i = 0 To Val(TextBox1.Text.Length - 1)
            If brray(i) = findthis Then

                brray(i) = k
            End If
        Next i
        TextBox4.Text = brray(30)


    End Sub
End Class
