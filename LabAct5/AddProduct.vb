Imports System.Net

Public Class AddProduct
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim prd_Name As String = txtProductName.Text
        Dim prd_Price As Integer
        Dim prd_Qty As Integer

        If Not Integer.TryParse(txtProductPrice.Text, prd_Price) Then
            MsgBox("Please enter a valid price", vbOKOnly + vbCritical)
            Exit Sub
        End If

        If Not Integer.TryParse(txtProductQty.Text, prd_Qty) Then
            MsgBox("Please enter a valid quantity", vbOKOnly + vbCritical)
            Exit Sub
        End If

        Try

            If prd_Name = Nothing OrElse prd_Price = Nothing OrElse prd_Qty = Nothing Then

                MsgBox("Please fill in all fields", vbOKOnly + vbCritical)
                Exit Sub

            Else

                Call addPrds(prd_Name, prd_Price, prd_Qty)

            End If


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical + vbOKOnly)
        End Try




    End Sub
End Class