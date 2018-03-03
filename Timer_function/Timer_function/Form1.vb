Public Class Form1
    Dim x, y, v, w As Integer

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer4.Interval = 25
        Timer2.Enabled = False
        Timer1.Enabled = False
        Timer3.Enabled = False
        Timer4.Enabled = True
    End Sub
    Private Sub move_left()

        PictureBox1.Left = PictureBox1.Left - 5
    End Sub
    Private Sub move_top()
        PictureBox1.Top = PictureBox1.Top - 5
    End Sub
    Private Sub move_down()
        PictureBox1.Top = PictureBox1.Top + 5
    End Sub
    Private Sub move_right()
        PictureBox1.Left = PictureBox1.Left + 5
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        move_left()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        move_top()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        move_down()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        move_right()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer4.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer3.Interval = 25
        Timer2.Enabled = False
        Timer1.Enabled = False
        Timer3.Enabled = True
        Timer4.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer2.Enabled = True
        Timer2.Interval = 25
        Timer1.Enabled = False
        Timer3.Enabled = False
        Timer4.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Timer1.Interval = 25
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer4.Enabled = False
    End Sub
End Class
