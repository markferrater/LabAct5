Public Class AddUsers
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstName As String = txtFirstName.Text
        Dim lastName As String = txtLastName.Text
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text
        Dim confirmPassword As String = txtConfirmPassword.Text


        If firstName = "" OrElse lastName = "" OrElse email = "" OrElse password = "" OrElse confirmPassword = "" Then

            MsgBox("Please fill in all fields", vbOKOnly + vbCritical)
            Exit Sub

        Else

            If password <> confirmPassword Then

                MsgBox("Passwords do not match", vbOKOnly + vbCritical)

                txtPassword.Clear()
                txtConfirmPassword.Clear()

                txtPassword.Focus()


                Exit Sub

            Else

                Call addUser(firstName, lastName, email, password)

            End If

        End If



    End Sub
End Class