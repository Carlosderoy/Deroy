Public Class Form1
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        UsernameTextBox.Text = String.Empty
        PasswordTextBox.Text = String.Empty
        MessageBox.Show("Form Submitted Succesfully.")
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles ResetButton.Click
        UsernameTextBox.Text = String.Empty
        PasswordTextBox.Text = String.Empty

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub PasswordTextBox_Click(sender As Object, e As EventArgs) Handles PasswordTextBox.Click
        If PasswordTextBox.PasswordChar = "*" Then
            PasswordTextBox.PasswordChar = ControlChars.NullChar ' Display characters as normal
        Else
            PasswordTextBox.PasswordChar = "*" ' Mask characters with '*'
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class
