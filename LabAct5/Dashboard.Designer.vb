<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        ToolStrip1 = New ToolStrip()
        tsbUsers = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        tsbProducts = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {tsbUsers, ToolStripSeparator1, tsbProducts, ToolStripSeparator2})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(800, 25)
        ToolStrip1.TabIndex = 0
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' tsbUsers
        ' 
        tsbUsers.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbUsers.Image = CType(resources.GetObject("tsbUsers.Image"), Image)
        tsbUsers.ImageTransparentColor = Color.Magenta
        tsbUsers.Name = "tsbUsers"
        tsbUsers.Size = New Size(39, 22)
        tsbUsers.Text = "Users"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' tsbProducts
        ' 
        tsbProducts.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbProducts.Image = CType(resources.GetObject("tsbProducts.Image"), Image)
        tsbProducts.ImageTransparentColor = Color.Magenta
        tsbProducts.Name = "tsbProducts"
        tsbProducts.Size = New Size(58, 22)
        tsbProducts.Text = "Products"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 25)
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ToolStrip1)
        Name = "Dashboard"
        Text = "Dashboard"
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbUsers As ToolStripButton
    Friend WithEvents tsbProducts As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
