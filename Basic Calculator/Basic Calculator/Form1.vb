Public Class Form1
    Dim a As Double
    Dim b As Double
    Dim k As Double
    Dim temp As Double
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        temp = Val(a)
        a = 9
        TextBox1.Text = Val(a)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        a = 1
        TextBox1.Text = Val(a)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        temp = Val(a)
        a = 2
        TextBox1.Text = Val(a)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        temp = Val(a)
        a = 3
        TextBox1.Text = Val(a)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        temp = Val(a)
        a = 4
        TextBox1.Text = Val(a)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        temp = Val(a)
        a = 5
        TextBox1.Text = Val(a)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        temp = Val(a)
        a = 6
        TextBox1.Text = Val(a)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        temp = Val(a)
        a = 7
        TextBox1.Text = Val(a)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        temp = Val(a)
        a = 8
        TextBox1.Text = Val(a)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        temp = Val(a)

        a = 0
        TextBox1.Text = Val(a)


    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        End
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        k = (a + temp)


    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        TextBox3.Text = Val(k)


    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        k = (temp - a)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        k = (a * temp)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        k = (temp / a)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox3.Text = ""
        TextBox1.Text = ""
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Label4.Visible = True
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) 

    End Sub


End Class
