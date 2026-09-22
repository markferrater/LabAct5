<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageUsers
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Button1 = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        testlabel = New Label()
        txtUserSearch = New TextBox()
        Button2 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = Color.Gainsboro
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DataGridView1.Location = New Point(12, 55)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(663, 223)
        DataGridView1.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "First Name"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 130
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Last Name"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 130
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Email"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 130
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Password"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 130
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "userId"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(13, 294)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 37)
        Button1.TabIndex = 1
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Enabled = False
        btnEdit.Location = New Point(126, 294)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(105, 37)
        btnEdit.TabIndex = 2
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Enabled = False
        btnDelete.Location = New Point(237, 294)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(105, 37)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' testlabel
        ' 
        testlabel.AutoSize = True
        testlabel.Location = New Point(563, 305)
        testlabel.Name = "testlabel"
        testlabel.Size = New Size(41, 15)
        testlabel.TabIndex = 4
        testlabel.Text = "Label1"
        ' 
        ' txtUserSearch
        ' 
        txtUserSearch.Location = New Point(12, 15)
        txtUserSearch.Name = "txtUserSearch"
        txtUserSearch.Size = New Size(177, 23)
        txtUserSearch.TabIndex = 5
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(208, 14)
        Button2.Name = "Button2"
        Button2.Size = New Size(87, 24)
        Button2.TabIndex = 6
        Button2.Text = "Search"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ManageUsers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(686, 346)
        Controls.Add(Button2)
        Controls.Add(txtUserSearch)
        Controls.Add(testlabel)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Name = "ManageUsers"
        Text = "ManageUsers"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents testlabel As Label
    Friend WithEvents txtUserSearch As TextBox
    Friend WithEvents Button2 As Button
End Class
