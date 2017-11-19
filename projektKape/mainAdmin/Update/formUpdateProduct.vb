Public Class formUpdateProduct
    ''  Automatic highlight * input text in a certain text field/s
    Private Sub txtBrand_Click(sender As Object, e As MouseEventArgs) Handles txtBrand.Click
        txtBrand.SelectAll()
    End Sub
    Private Sub txtGeneric_Click(sender As Object, e As MouseEventArgs) Handles txtGeneric.Click
        txtGeneric.SelectAll()
    End Sub
    Private Sub txtRawPrice_Click(sender As Object, e As MouseEventArgs) Handles txtRawPrice.Click
        txtRawPrice.SelectAll()
    End Sub
    Private Sub txtSRP_Click(sender As Object, e As MouseEventArgs) Handles txtSRP.Click
        txtSRP.SelectAll()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call moduleProduct.restrictUpdateProducts()
    End Sub
End Class