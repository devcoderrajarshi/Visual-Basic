Public Class Form1
    Dim colours() As Color
    Dim colourindex As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        OvalShape1.FillColor = colours(colourindex Mod colours.Length)
        colourindex += 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        colours = {Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Purple}
        OvalShape1.FillStyle = PowerPacks.FillStyle.Solid
        OvalShape1.FillColor = colours(0)
        Timer1.Enabled = True
        Timer1.Interval = 500
    End Sub
End Class
