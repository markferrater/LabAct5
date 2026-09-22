<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdatingUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label6 = New Label()
        txtPassword = New TextBox()
        txtEmail = New TextBox()
        txtLastName = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtFirstName = New TextBox()
        Button2 = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(29, 25)
        Label6.Name = "Label6"
        Label6.Size = New Size(121, 32)
        Label6.TabIndex = 25
        Label6.Text = "Edit Users"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(151, 164)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(164, 23)
        txtPassword.TabIndex = 23
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(151, 133)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(164, 23)
        txtEmail.TabIndex = 22
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(151, 103)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(164, 23)
        txtLastName.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(30, 106)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 15)
        Label5.TabIndex = 20
        Label5.Text = "Last Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 73)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 15)
        Label4.TabIndex = 18
        Label4.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 167)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 17
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 136)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 15)
        Label1.TabIndex = 16
        Label1.Text = "Email"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(151, 70)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(164, 23)
        txtFirstName.TabIndex = 15
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(96, 218)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 37)
        Button2.TabIndex = 14
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(215, 218)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 37)
        Button1.TabIndex = 13
        Button1.Text = "Update"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' UpdatingUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(365, 273)
        Controls.Add(Label6)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        Controls.Add(txtLastName)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtFirstName)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "UpdatingUser"
        Text = "UpdatingUser"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
