Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tsbUsers_Click(sender As Object, e As EventArgs) Handles tsbUsers.Click
        ManageUsers.Show()
        Me.Close()
    End Sub

    Private Sub tsbProducts_Click(sender As Object, e As EventArgs) Handles tsbProducts.Click
        MangeProducts.Show()
        Me.Close()
    End Sub
End Class