Public Class Form1
    Dim array(100)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, i, j, x, k, temp As Integer
        n = Val(TextBox1.Text)
        For i = 0 To n - 1
            x = InputBox("Enter The elements for sorting")
            array(i) = x
            ListBox1.Items.Add(array(i))
        Next i


        For i = 0 To n - 2
            For j = 0 To n - i - 2
                If array(j) > array(j + 1) Then
                    temp = array(j)
                    array(j) = array(j + 1)
                    array(j + 1) = temp

                End If
            Next j
        Next i
        For k = 0 To n - 1
            ListBox2.Items.Add(array(k))
        Next k


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
