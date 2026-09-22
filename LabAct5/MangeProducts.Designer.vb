<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MangeProducts
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        testlabel = New Label()
        btnDelete = New Button()
        btnEdit = New Button()
        Button1 = New Button()
        dgvProducts = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        txtProductSearch = New TextBox()
        Button2 = New Button()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' testlabel
        ' 
        testlabel.AutoSize = True
        testlabel.Location = New Point(441, 300)
        testlabel.Name = "testlabel"
        testlabel.Size = New Size(41, 15)
        testlabel.TabIndex = 9
        testlabel.Text = "Label1"
        ' 
        ' btnDelete
        ' 
        btnDelete.Enabled = False
        btnDelete.Location = New Point(247, 289)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(105, 37)
        btnDelete.TabIndex = 8
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Enabled = False
        btnEdit.Location = New Point(136, 289)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(105, 37)
        btnEdit.TabIndex = 7
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(23, 289)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 37)
        Button1.TabIndex = 6
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' dgvProducts
        ' 
        dgvProducts.AllowUserToAddRows = False
        dgvProducts.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.Gainsboro
        dgvProducts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProducts.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column5})
        dgvProducts.Location = New Point(22, 50)
        dgvProducts.Name = "dgvProducts"
        dgvProducts.ReadOnly = True
        dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProducts.Size = New Size(538, 223)
        dgvProducts.TabIndex = 5
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Name"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 130
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Price"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 130
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Quantity"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 130
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "productId"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' txtProductSearch
        ' 
        txtProductSearch.Location = New Point(22, 12)
        txtProductSearch.Name = "txtProductSearch"
        txtProductSearch.Size = New Size(175, 23)
        txtProductSearch.TabIndex = 10
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(214, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 11
        Button2.Text = "Search"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' MangeProducts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(581, 342)
        Controls.Add(Button2)
        Controls.Add(txtProductSearch)
        Controls.Add(testlabel)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(Button1)
        Controls.Add(dgvProducts)
        Name = "MangeProducts"
        Text = "MangeProducts"
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents testlabel As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents txtProductSearch As TextBox
    Friend WithEvents Button2 As Button
End Class
