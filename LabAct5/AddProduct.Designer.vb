<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProduct
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
        Label6.Location = New Point(31, 26)
        Label6.Name = "Label6"
        Label6.Size = New Size(160, 32)
        Label6.TabIndex = 25
        Label6.Text = "Add Products"
        ' 
        ' txtProductQty
        ' 
        txtProductQty.Location = New Point(153, 134)
        txtProductQty.Name = "txtProductQty"
        txtProductQty.Size = New Size(164, 23)
        txtProductQty.TabIndex = 22
        ' 
        ' txtProductPrice
        ' 
        txtProductPrice.Location = New Point(153, 104)
        txtProductPrice.Name = "txtProductPrice"
        txtProductPrice.Size = New Size(164, 23)
        txtProductPrice.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(31, 107)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 15)
        Label5.TabIndex = 20
        Label5.Text = " Product Price"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(32, 74)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 15)
        Label4.TabIndex = 18
        Label4.Text = "Product Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(32, 137)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 15)
        Label1.TabIndex = 16
        Label1.Text = "Product Quantity"
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(153, 71)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(164, 23)
        txtProductName.TabIndex = 15
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(60, 180)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 37)
        Button2.TabIndex = 14
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(179, 180)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 37)
        Button1.TabIndex = 13
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' AddProduct
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(364, 235)
        Controls.Add(Label6)
        Controls.Add(txtProductQty)
        Controls.Add(txtProductPrice)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(txtProductName)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "AddProduct"
        Text = "AddProduct"
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
