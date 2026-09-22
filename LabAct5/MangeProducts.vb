Imports System.Net
Imports Microsoft.VisualBasic.ApplicationServices

Public Class MangeProducts
    Public selectedRow As DataGridViewRow = Nothing

    Public prd_Name As String
    Public prd_Price As Integer
    Public prd_Qty As Integer
    Public prd_Id As Integer


    Private Sub MangeProducts_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Dashboard.Show()
    End Sub

    Private Sub MangeProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadProducts(dgvProducts)
    End Sub

    Private Sub MangeProducts_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        selectedRow = Nothing
        btnDelete.Enabled = False
        btnEdit.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddProduct.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        MsgBox("Product ID: " & prd_Id & vbCrLf & "Product Name: " & prd_Name & vbCrLf & "Product Price: " & prd_Price & vbCrLf & "Product Quantity: " & prd_Qty)

        Dim update As New UpdatingProducts(prd_Name, prd_Price, prd_Qty, prd_Id)

        update.Show()

    End Sub

    Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick
        selectedRow = dgvProducts.Rows(e.RowIndex)

        testlabel.Text = selectedRow.Cells(3).Value.ToString()

        If e.RowIndex >= 0 Then

            prd_Name = selectedRow.Cells(0).Value.ToString()
            prd_Price = selectedRow.Cells(1).Value.ToString()
            prd_Qty = selectedRow.Cells(2).Value.ToString()
            prd_Id = selectedRow.Cells(3).Value.ToString()


            btnEdit.Enabled = True
            btnDelete.Enabled = True

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtProductSearch.TextChanged

        Dim text As String = txtProductSearch.Text

        Call searchProduct(text, dgvProducts)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Call softDeleteProduct(prd_Id)

    End Sub
End Class