<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdatingProducts
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
        txtProductQty = New TextBox()
        txtProductPrice = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label1 = New Label()
        txtProductName = New TextBox()
        Button2 = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(32, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(157, 32)
        Label6.TabIndex = 36
        Label6.Text = "Edit Products"
        ' 
        ' txtProductQty
        ' 
        txtProductQty.Location = New Point(153, 128)
        txtProductQty.Name = "txtProductQty"
        txtProductQty.Size = New Size(164, 23)
        txtProductQty.TabIndex = 44
        ' 
        ' txtProductPrice
        ' 
        txtProductPrice.Location = New Point(153, 98)
        txtProductPrice.Name = "txtProductPrice"
        txtProductPrice.Size = New Size(164, 23)
        txtProductPrice.TabIndex = 43
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(31, 101)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 15)
        Label5.TabIndex = 42
        Label5.Text = " Product Price"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(32, 68)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 15)
        Label4.TabIndex = 41
        Label4.Text = "Product Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(32, 131)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 15)
        Label1.TabIndex = 40
        Label1.Text = "Product Quantity"
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(153, 65)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(164, 23)
        txtProductName.TabIndex = 39
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(60, 174)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 37)
        Button2.TabIndex = 38
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(179, 174)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 37)
        Button1.TabIndex = 37
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' UpdatingProducts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(355, 232)
        Controls.Add(txtProductQty)
        Controls.Add(txtProductPrice)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(txtProductName)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Name = "UpdatingProducts"
        Text = "UpdatingProducts"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txtProductQty As TextBox
    Friend WithEvents txtProductPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
