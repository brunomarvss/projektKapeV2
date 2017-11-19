Module moduleSupplier
    Sub ResetDefaultAddSupplierTextFields()
        formAddSupplier.txtCompany.Text = "Company Name"
        formAddSupplier.txtLname.Text = "Last Name"
        formAddSupplier.txtFname.Text = "First Name"
        formAddSupplier.txtSuffix.Text = "Suffix e.g. (Jr.)"
        formAddSupplier.txtContact.Text = "Contact Number"
        formAddSupplier.txtAddress.Text = "Address Details"
        formAddSupplier.txtCity.Text = "City"
        formAddSupplier.txtProvince.Text = "Province"
    End Sub
    Sub ResetDefaultUpdateSupplierTextFields()
        formUpdateSupplier.txtCompany.Text = "Company Name"
        formUpdateSupplier.txtLname.Text = "Last Name"
        formUpdateSupplier.txtFname.Text = "First Name"
        formUpdateSupplier.txtSuffix.Text = "Suffix e.g. (Jr.)"
        formUpdateSupplier.txtContact.Text = "Contact Number"
        formUpdateSupplier.txtAddress.Text = "Address Details"
        formUpdateSupplier.txtCity.Text = "City"
        formUpdateSupplier.txtProvince.Text = "Province"
    End Sub

    Sub restrictAddSuppliers()
        ''  Default text field tips if text field was blank/null
        If formAddSupplier.txtCompany.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formAddSupplier.txtCompany.Select()
            Exit Sub
        End If

        If formAddSupplier.txtLname.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formAddSupplier.txtLname.Select()
            Exit Sub
        End If

        If formAddSupplier.txtFname.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formAddSupplier.txtFname.Select()
            Exit Sub
        End If

        If (formAddSupplier.txtSuffix.Text.Equals("") Or formAddSupplier.txtSuffix.Text.Equals("Suffix e.g. (Jr.)")) Then
            formAddSupplier.txtSuffix.Text = "<N/A>"
        End If

        If Not IsNumeric(formAddSupplier.txtContact.Text) Then
            MsgBox("'Contact Number' input must be numbers only", vbCritical, "Error")
            formAddSupplier.txtContact.Text = ""
            formAddSupplier.txtContact.Select()
            Exit Sub

        ElseIf Val(formAddSupplier.txtContact.Text) < 0 Then
            MsgBox("'Contact Number' input must not contain negative values", vbCritical, "Error")
            formAddSupplier.txtContact.Text = ""
            formAddSupplier.txtContact.Select()
            Exit Sub

        ElseIf ((formAddSupplier.txtContact.Text.Length < 11) Or (formAddSupplier.txtContact.Text.Length > 11)) Then
            MsgBox("'Contact Number' input must be 11 digit numbers", vbCritical, "Error")
            formAddSupplier.txtContact.Text = ""
            formAddSupplier.txtContact.Select()
            Exit Sub

        ElseIf Not formAddSupplier.txtContact.Text.Substring(0, 2).Equals("09") Then
            MsgBox("'Contact Number' input must starts at '09' numbers (PH based digits)", vbCritical, "Error")
            formAddSupplier.txtContact.Text = ""
            formAddSupplier.txtContact.Select()
            Exit Sub

        End If

        If formAddSupplier.txtAddress.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formAddSupplier.txtAddress.Select()
            Exit Sub
        End If

        If formAddSupplier.txtCity.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formAddSupplier.txtCity.Select()
            Exit Sub
        End If

        If formAddSupplier.txtProvince.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formAddSupplier.txtProvince.Select()
            Exit Sub
        End If

        Call AddSupplier()
    End Sub
    Sub restrictUpdateSuppliers()
        ''  Default text field tips if text field was blank/null
        If formUpdateSupplier.txtCompany.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formUpdateSupplier.txtCompany.Select()
            Exit Sub
        End If

        If formUpdateSupplier.txtLname.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formUpdateSupplier.txtLname.Select()
            Exit Sub
        End If

        If formUpdateSupplier.txtFname.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formUpdateSupplier.txtFname.Select()
            Exit Sub
        End If

        If (formUpdateSupplier.txtSuffix.Text.Equals("") Or formUpdateSupplier.txtSuffix.Text.Equals("Suffix e.g. (Jr.)")) Then
            formUpdateSupplier.txtSuffix.Text = "<N/A>"
        End If

        If Not IsNumeric(formUpdateSupplier.txtContact.Text) Then
            MsgBox("'Contact Number' input must be numbers only", vbCritical, "Error")
            formUpdateSupplier.txtContact.Text = ""
            formUpdateSupplier.txtContact.Select()
            Exit Sub

        ElseIf Val(formUpdateSupplier.txtContact.Text) < 0 Then
            MsgBox("'Contact Number' input must not contain negative values", vbCritical, "Error")
            formUpdateSupplier.txtContact.Text = ""
            formUpdateSupplier.txtContact.Select()
            Exit Sub

        ElseIf ((formUpdateSupplier.txtContact.Text.Length < 11) Or (formUpdateSupplier.txtContact.Text.Length > 11)) Then
            MsgBox("'Contact Number' input must be 11 digit numbers", vbCritical, "Error")
            formUpdateSupplier.txtContact.Text = ""
            formUpdateSupplier.txtContact.Select()
            Exit Sub

        ElseIf Not formUpdateSupplier.txtContact.Text.Substring(0, 2).Equals("09") Then
            MsgBox("'Contact Number' input must starts at '09' numbers (PH based digits)", vbCritical, "Error")
            formUpdateSupplier.txtContact.Text = ""
            formUpdateSupplier.txtContact.Select()
            Exit Sub

        End If

        If formUpdateSupplier.txtAddress.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formUpdateSupplier.txtAddress.Select()
            Exit Sub
        End If

        If formUpdateSupplier.txtCity.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formUpdateSupplier.txtCity.Select()
            Exit Sub
        End If

        If formUpdateSupplier.txtProvince.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formUpdateSupplier.txtProvince.Select()
            Exit Sub
        End If

        Call UpdateSupplier()
    End Sub

    Sub AddSupplier()
        ''  Declares the variable only on adding suppliers
        Dim setLname = "", setFname = "", setSuffix = "", setContact = "", setAddress = "", setCity = "", setProvince = "", setCompany As String = ""

        Try
            rs = New ADODB.Recordset

            ''  Initialize declared variables
            setCompany = formAddSupplier.txtCompany.Text.Trim

            setLname = formAddSupplier.txtLname.Text.Trim
            setFname = formAddSupplier.txtFname.Text.Trim
            setSuffix = formAddSupplier.txtSuffix.Text.Trim

            setContact = formAddSupplier.txtContact.Text.Trim
            setAddress = formAddSupplier.txtAddress.Text.Trim
            setCity = formAddSupplier.txtCity.Text.Trim
            setProvince = formAddSupplier.txtProvince.Text.Trim


            ''  Restrictions on text fields
            If setCompany = "Company Name" Or setLname = "Last Name" Or setFname = "First Name" Or setContact = "Contact Number" Or setAddress = "Address Details" Or setCity = "City" Or setProvince = "Province" Then
                MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
                Exit Sub

            End If

            ''  If necessary name of people have suffix on their name or nothing
            If setSuffix = "Suffix e.g. (Jr.)" Then
                setSuffix = "<N/A>"
            End If



            ''  Process after passing on restrictions

            With rs
                ''  Check if new supplier information is unique
                If .State <> 0 Then .Close()
                .Open("SELECT Company FROM Suppliers WHERE Company='" + setCompany + "';", cn, 1, 2)

                If .EOF = False Then
                    MsgBox("This company was already registered, supplier's company name must be no items matched on registered companies")
                    Exit Sub
                End If

                ''  Saves new supplier data on the database
                If .State <> 0 Then .Close()
                .Open("INSERT INTO Suppliers (LastName, FirstName, Suffix, Company, Contact, Address, City, Province)" +
                      "VALUES ('" + setLname + "', '" + setFname + "', '" + setSuffix + "', '" +
                      setCompany + "', '" + setContact + "', '" + setAddress + "', '" + setCity + "', '" + setProvince + "');", cn, 1, 2)

                MsgBox("Saving Successful!", MsgBoxStyle.Information, "Record Saved")
                Call formMainAdmin.refreshSupplierList()
                Call ResetDefaultAddSupplierTextFields()
                formAddSupplier.txtCompany.Select()
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub UpdateSupplier()
        ''  Declares the variable only on adding suppliers
        Dim setLname = "", setFname = "", setSuffix = "", setContact = "", setAddress = "", setCity = "", setProvince = "", setCompany As String = ""

        Try
            rs = New ADODB.Recordset

            ''  Initialize declared variables
            setCompany = formUpdateSupplier.txtCompany.Text.Trim

            setLname = formUpdateSupplier.txtLname.Text.Trim
            setFname = formUpdateSupplier.txtFname.Text.Trim
            setSuffix = formUpdateSupplier.txtSuffix.Text.Trim

            setContact = formUpdateSupplier.txtContact.Text.Trim
            setAddress = formUpdateSupplier.txtAddress.Text.Trim
            setCity = formUpdateSupplier.txtCity.Text.Trim
            setProvince = formUpdateSupplier.txtProvince.Text.Trim

            ''  Process after passing on restrictions

            With rs
                ''  Check if new supplier information is unique
                If .State <> 0 Then .Close()
                .Open("SELECT Company FROM Suppliers WHERE Company='" + setCompany + "';", cn, 1, 2)

                If .EOF = False Then
                    MsgBox("This company was already registered, supplier's company name must be no items matched on registered companies")
                    Exit Sub
                End If

                ''  Update existing data for a new one
                If .State <> 0 Then .Close()
                .Open("UPDATE Suppliers " +
                      "SET Company='" + setCompany + "', FirstName='" + setFname + "', LastName='" + setLname + "', " + "Suffix='" + setSuffix + "', " +
                      "Contact='" + setContact + "', Address='" + setAddress + "', City='" + setCity + "', Province='" + setProvince + "' " +
                      "WHERE Company='" + formMainAdmin.supplierCompany + "';", cn, 1, 2)

                MsgBox("SUPPLIER UPDATED!", vbInformation, "ECT Pharmacy POS")
                Call formMainAdmin.refreshSupplierList()
                Call ResetDefaultUpdateSupplierTextFields()
                formUpdateSupplier.Hide()
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
