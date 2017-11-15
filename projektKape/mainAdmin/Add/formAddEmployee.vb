Public Class formAddEmployee
    Private Sub formAddEmployee_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call moduleAddEmployee.ResetDefaultEmployeeTextFields()

    End Sub


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


    ''  Default text field tips if text field was blank/null
    Private Sub txtJobTitle_Leave(sender As Object, e As EventArgs) Handles txtJobTitle.Leave
        If txtJobTitle.Text.Equals("") Then
            txtJobTitle.Text = "Work Title"
        End If
    End Sub
    Private Sub txtLname_Leave(sender As Object, e As EventArgs) Handles txtLname.Leave
        If txtLname.Text.Equals("") Then
            txtLname.Text = "Last Name"
        End If
    End Sub
    Private Sub txtFname_Leave(sender As Object, e As EventArgs) Handles txtFname.Leave
        If txtFname.Text.Equals("") Then
            txtFname.Text = "First Name"
        End If
    End Sub
    Private Sub txtMname_Leave(sender As Object, e As EventArgs) Handles txtMname.Leave
        If txtMname.Text.Equals("") Then
            txtMname.Text = "Middle Name"
        End If
    End Sub
    Private Sub txtSuffix_Leave(sender As Object, e As EventArgs) Handles txtSuffix.Leave
        If txtSuffix.Text.Equals("") Then
            txtSuffix.Text = "Suffix e.g. (Jr.)"
        End If
    End Sub
    Private Sub txtContact_Leave(sender As Object, e As EventArgs) Handles txtContact.Leave
        If Not IsNumeric(txtContact.Text) Then
            MsgBox("'Contact Number' input must be numbers only", vbCritical, "Error")
            txtContact.Text = ""
            txtContact.Select()
        End If
        If Val(txtContact.Text) < 0 Then
            MsgBox("'Contact Number' input must not contain negative values", vbCritical, "Error")
            txtContact.Text = ""
            txtContact.Select()
        End If
        If ((txtContact.Text.Length < 11) Or (txtContact.Text.Length > 11)) Then
            MsgBox("'Contact Number' input must be 11 digit numbers", vbCritical, "Error")
            txtContact.Text = ""
            txtContact.Select()
        End If
        If Not txtContact.Text.Substring(0, 2).Equals("09") Then
            MsgBox("'Contact Number' input must starts at '09' numbers (PH based digits)", vbCritical, "Error")
            txtContact.Text = ""
            txtContact.Select()

        End If
    End Sub
    Private Sub txtAddress_Leave(sender As Object, e As EventArgs) Handles txtAddress.Leave
        If txtAddress.Text.Equals("") Then
            txtAddress.Text = "Address Details"
        End If
    End Sub
    Private Sub txtCity_Leave(sender As Object, e As EventArgs) Handles txtCity.Leave
        If txtCity.Text.Equals("") Then
            txtCity.Text = "City"
        End If
    End Sub
    Private Sub txtProvince_Leave(sender As Object, e As EventArgs) Handles txtProvince.Leave
        If txtProvince.Text.Equals("") Then
            txtProvince.Text = "Province"
        End If
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Call moduleAddEmployee.AddNewEmployee()


        Dim count As Integer = 9
        While Not count = 0
            ''  Length of array match with count

            '<N/A>
            count = count - 1
        End While

    End Sub
End Class