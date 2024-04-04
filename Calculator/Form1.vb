Public Class Form1

    Dim Number1 As Integer
    Dim Number2 As Integer
    Dim Answer As Integer

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Number1 = TextBox1.Text
        Number2 = TextBox2.Text
        Answer = Number1 + Number2
        MessageBox.Show(Answer)

    End Sub
End Class
