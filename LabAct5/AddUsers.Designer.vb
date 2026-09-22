<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUsers
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
        Button1 = New Button()
        Button2 = New Button()
        txtFirstName = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtLastName = New TextBox()
        txtEmail = New TextBox()
        txtPassword = New TextBox()
        txtConfirmPassword = New TextBox()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(232, 248)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 37)
        Button1.TabIndex = 0
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(113, 248)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 37)
        Button2.TabIndex = 1
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(168, 68)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(164, 23)
        txtFirstName.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(47, 134)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 15)
        Label1.TabIndex = 3
        Label1.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(47, 165)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 4
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(47, 199)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 15)
        Label3.TabIndex = 6
        Label3.Text = "Confirm Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(47, 71)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 15)
        Label4.TabIndex = 5
        Label4.Text = "First Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(47, 104)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 15)
        Label5.TabIndex = 7
        Label5.Text = "Last Name"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(168, 101)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(164, 23)
        txtLastName.TabIndex = 8
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(168, 131)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(164, 23)
        txtEmail.TabIndex = 9
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(168, 162)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(164, 23)
        txtPassword.TabIndex = 10
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(168, 196)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(164, 23)
        txtConfirmPassword.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(46, 23)
        Label6.Name = "Label6"
        Label6.Size = New Size(124, 32)
        Label6.TabIndex = 12
        Label6.Text = "Add Users"
        ' 
        ' AddUsers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(406, 316)
        Controls.Add(Label6)
        Controls.Add(txtConfirmPassword)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        Controls.Add(txtLastName)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtFirstName)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "AddUsers"
        Text = "AddUsers"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label6 As Label
End Class
