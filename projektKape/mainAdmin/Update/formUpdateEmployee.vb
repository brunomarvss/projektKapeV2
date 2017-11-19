Public Class formUpdateEmployee
    ''  Automatic highlight * input text in a certain text field/s
    Private Sub txtJobTitle_Click(sender As Object, e As EventArgs) Handles txtJobTitle.Click
        txtJobTitle.SelectAll()
    End Sub
    Private Sub txtLname_Click(sender As Object, e As EventArgs) Handles txtLname.Click
        txtLname.SelectAll()
    End Sub
    Private Sub txtFname_Click(sender As Object, e As EventArgs) Handles txtFname.Click
        txtFname.SelectAll()
    End Sub
    Private Sub txtMname_Click(sender As Object, e As EventArgs) Handles txtMname.Click
        txtMname.SelectAll()
    End Sub
    Private Sub txtSuffix_Click(sender As Object, e As EventArgs) Handles txtSuffix.Click
        txtSuffix.SelectAll()
    End Sub
    Private Sub txtContact_Click(sender As Object, e As EventArgs) Handles txtContact.Click
        txtContact.SelectAll()
    End Sub
    Private Sub txtAddress_Click(sender As Object, e As EventArgs) Handles txtAddress.Click
        txtAddress.SelectAll()
    End Sub
    Private Sub txtCity_Click(sender As Object, e As EventArgs) Handles txtCity.Click
        txtCity.SelectAll()
    End Sub
    Private Sub txtProvince_Click(sender As Object, e As EventArgs) Handles txtProvince.Click
        txtProvince.SelectAll()
    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call moduleEmployee.restrictUpdateEmployees()
    End Sub
End Class