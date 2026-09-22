Public Class ManageUsers
    Public selectedRow As DataGridViewRow = Nothing

    Public firstName As String
    Public lastName As String
    Public email As String
    Public password As String
    Public userId As Integer

    Private Sub ManageUsers_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Dashboard.Show()
    End Sub

    Private Sub ManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadUsers(DataGridView1)
    End Sub

    Private Sub ManageUsers_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        selectedRow = Nothing
        btnDelete.Enabled = False
        btnEdit.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddUsers.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        selectedRow = DataGridView1.Rows(e.RowIndex)

        testlabel.Text = selectedRow.Cells(0).Value.ToString()

        If e.RowIndex >= 0 Then

            firstName = selectedRow.Cells(0).Value.ToString()
            lastName = selectedRow.Cells(1).Value.ToString()
            email = selectedRow.Cells(2).Value.ToString()
            password = selectedRow.Cells(3).Value.ToString()
            userId = Integer.Parse(selectedRow.Cells(4).Value.ToString())


            btnEdit.Enabled = True
            btnDelete.Enabled = True

        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If firstName <> "" AndAlso lastName <> "" AndAlso email <> "" AndAlso password <> "" Then

            Dim updateForm As New UpdatingUser(firstName, lastName, email, password, userId)

            updateForm.Show()


        Else
            MsgBox("Please select a user to edit", vbOKOnly + vbCritical)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Call softDeleteUser(userId)
    End Sub

    Private Sub txtUserSearch_TextChanged(sender As Object, e As EventArgs) Handles txtUserSearch.TextChanged
        Dim text As String = txtUserSearch.Text

        Call searchUser(text, DataGridView1)
    End Sub
End Class