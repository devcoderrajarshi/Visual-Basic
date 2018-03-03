Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Timer1.Interval = 1000
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        OvalShape1.FillStyle = PowerPacks.FillStyle.Solid
        OvalShape1.FillColor = Color.Red
        Timer2.Enabled = True
        Timer2.Interval = 1000
        Timer3.Enabled = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        OvalShape1.FillStyle = PowerPacks.FillStyle.Solid
        OvalShape1.FillColor = Color.Blue
        Timer3.Enabled = True
        Timer3.Interval = 1000
        Timer1.Enabled = False
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        OvalShape1.FillStyle = PowerPacks.FillStyle.Solid
        OvalShape1.FillColor = Color.Green
        Timer1.Enabled = True
        Timer1.Interval = 1000
        Timer2.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
    End Sub
End Class
