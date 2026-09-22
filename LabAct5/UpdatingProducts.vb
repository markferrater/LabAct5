Imports System.Net

Public Class UpdatingProducts
    Public prd_name As String
    Public prd_price As Integer
    Public prd_qty As Integer
    Public prd_id As Integer

    Public Sub New(prd_name As String, prd_price As Integer, prd_qty As Integer, prd_id As Integer)
        InitializeComponent()

        Me.prd_name = prd_name
        Me.prd_price = prd_price
        Me.prd_qty = prd_qty
        Me.prd_id = prd_id

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Call updatePrd(txtProductName.Text, Integer.Parse(txtProductPrice.Text), Integer.Parse(txtProductQty.Text), prd_id)

        Me.Close()
    End Sub

    Private Sub UpdatingProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtProductName.Text = prd_name
        txtProductPrice.Text = prd_price.ToString()
        txtProductQty.Text = prd_qty.ToString()

    End Sub
End Class