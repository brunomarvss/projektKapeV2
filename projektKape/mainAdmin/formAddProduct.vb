Public Class formAddProduct
    Private Sub formAddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call moduleAddProduct.LoadRegisteredSuppliers()
        Call moduleAddProduct.ResetDefaultdSuppliers()
    End Sub


    ''  Default text field tips if text field was blank/null
    Private Sub txtBrand_Leave(sender As Object, e As EventArgs) Handles txtBrand.Leave
        If txtBrand.Text.Equals("") Then
            txtBrand.Text = "Brand Name"
        End If
    End Sub
    Private Sub txtGeneric_Leave(sender As Object, e As EventArgs) Handles txtGeneric.Leave
        If txtGeneric.Text.Equals("") Then
            txtGeneric.Text = "Generic Name"
        End If
    End Sub
    Private Sub txtQty_Leave(sender As Object, e As EventArgs) Handles txtQty.Leave
        If Not IsNumeric(txtQty.Text) Then
            MsgBox("'Item quantity' input must be numbers only", vbCritical, "Error")
            txtQty.Text = ""
            txtQty.Select()

        ElseIf Val(txtQty.Text) <= 0 Then
            MsgBox("'Item quantity' input must be more than or equal to value of 1", vbCritical, "Error")
            txtQty.Text = ""
            txtQty.Select()
        End If
    End Sub


    ''  Auto two decimal places when text field leaves
    Private Sub txtRawPrice_Leave(sender As Object, e As EventArgs) Handles txtRawPrice.Leave
        If Not IsNumeric(txtRawPrice.Text) Then
            MsgBox("'Raw price' input must be numbers only", vbCritical, "Error")
            txtRawPrice.Text = ""
            txtRawPrice.Select()

        ElseIf Val(txtRawPrice.Text) <= 0 Then
            MsgBox("'Raw price' input must be more than or equal to value of 1", vbCritical, "Error")
            txtRawPrice.Text = ""
            txtRawPrice.Select()

        Else
            txtRawPrice.Text = Format(Val(txtRawPrice.Text), "0.00")
        End If
    End Sub
    Private Sub txtSRP_Leave(sender As Object, e As EventArgs) Handles txtSRP.Leave
        If Not IsNumeric(txtSRP.Text) Then
            MsgBox("'SRP' input must be numbers only", vbCritical, "Error")
            txtSRP.Text = ""
            txtSRP.Select()

        ElseIf Val(txtSRP.Text) <= 0 Then
            MsgBox("'SRP' input must be more than or equal to value of 1", vbCritical, "Error")
            txtSRP.Text = ""
            txtSRP.Select()

        Else
            txtSRP.Text = Format(Val(txtSRP.Text), "0.00")
        End If
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call moduleAddProduct.AddNewProduct()
    End Sub
End Class