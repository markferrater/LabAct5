Public Class UpdatingUser

    Public firstname As String
    Public lastname As String
    Public email As String
    Public password As String
    Public id As Integer

    Public Sub New(firstname As String, lastname As String, email As String, password As String, id As Integer)
        InitializeComponent()

        Me.firstname = firstname
        Me.lastname = lastname
        Me.email = email
        Me.password = password
        Me.id = id

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Call updateUser(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPassword.Text, id)

        Me.Close()

    End Sub

    Private Sub UpdatingUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtFirstName.Text = firstname
        txtLastName.Text = lastname
        txtEmail.Text = email
        txtPassword.Text = password

    End Sub
End Class