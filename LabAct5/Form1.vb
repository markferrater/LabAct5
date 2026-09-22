Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text

        Call checkUser(email, password)

        txtEmail.Clear()
        txtPassword.Clear()

        txtEmail.Focus()
    End Sub
End Class
