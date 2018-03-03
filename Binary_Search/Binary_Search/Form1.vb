Public Class Form1
    Dim array(100), brray(100) As Integer
    Dim n, i As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim j, x, temp As Integer
        n = Val(TextBox1.Text)


        For i = 0 To n - 1
            x = InputBox("Enter The elements for sorting")
            array(i) = x

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
        For i = 0 To n
            brray(i) = array(i)
        Next i


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim lb As Integer
        Dim ub, p, midl, flag As Integer
        Dim u As Integer
        lb = 0
        ub = (n - 1)
        flag = 0
        p = Val(TextBox2.Text)

        For u = 0 To n

            midl = (lb + ub) / 2
            If array(midl) = p Then

                flag = 1



            Else

                If array(midl) < p Then

                    lb = midl + 1

                Else

                    ub = midl - 1

                End If
            End If
        Next u




        If (flag = 1) Then

            MsgBox("the element is present in index " & Val(midl) & " in the given list")

        Else

            MsgBox("The element is not present in the list")
        End If

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        For i = 0 To n - 1
            ListBox1.Items.Add(brray(i))

        Next i
    End Sub
End Class