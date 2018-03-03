Public Class Form1




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        If CheckBox1.Checked = True And CheckBox2.Checked = True Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Italic And FontStyle.Bold)



        End If










        If RadioButton1.Checked = True Then
            TextBox1.ForeColor = Color.Red



        End If


        If RadioButton2.Checked = True Then
            TextBox1.ForeColor = Color.Green
        End If


        If RadioButton3.Checked = True Then
            TextBox1.ForeColor = Color.Blue

        End If





    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        CheckBox3.Enabled = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        RadioButton3.Enabled = False


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
        CheckBox3.Enabled = True
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        RadioButton3.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox1.Font = New Font(TextBox1.Font, FontStyle.Regular)

        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        CheckBox3.Enabled = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        RadioButton3.Enabled = False


        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
