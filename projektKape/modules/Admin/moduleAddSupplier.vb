Module moduleAddSupplier
    Sub ResetDefaultSupplierTextFields()
        formAddSupplier.txtCompany.Text = "Company Name"
        formAddSupplier.txtLname.Text = "Last Name"
        formAddSupplier.txtFname.Text = "First Name"
        formAddSupplier.txtSuffix.Text = "Suffix e.g. (Jr.)"
        formAddSupplier.txtContact.Text = "Contact Number"
        formAddSupplier.txtAddress.Text = "Address Details"
        formAddSupplier.txtCity.Text = "City"
        formAddSupplier.txtProvince.Text = "Province"
    End Sub
    Sub AddNewSupplier()
        ''  Declares the variable only on adding suppliers
        Dim getLname = "", getFname = "", getSuffix = "", getContact = "", getAddress = "", getCity = "", getProvince = "", getCompany As String = ""
        Dim setLname = "", setFname = "", setSuffix = "", setContact = "", setAddress = "", setCity = "", setProvince = "", setCompany As String = ""

        Try
            rs = New ADODB.Recordset

            ''  Initialize declared variables
            getCompany = formAddSupplier.txtCompany.Text.Trim

            getLname = formAddSupplier.txtLname.Text.Trim
            getFname = formAddSupplier.txtFname.Text.Trim
            getSuffix = formAddSupplier.txtSuffix.Text.Trim

            getContact = formAddSupplier.txtContact.Text.Trim
            getAddress = formAddSupplier.txtAddress.Text.Trim
            getCity = formAddSupplier.txtCity.Text.Trim
            getProvince = formAddSupplier.txtProvince.Text.Trim


            ''  Restrictions on text fields
            If getCompany = "Company Name" Or getLname = "Last Name" Or getFname = "First Name" Or getContact = "Contact Number" Or getAddress = "Address Details" Or getCity = "City" Or getProvince = "Province" Then
                MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
                Exit Sub

            Else

                setCompany = getCompany
                setLname = getLname
                setFname = getFname
                setContact = getContact
                setAddress = getAddress
                setCity = getCity
                setProvince = getProvince
            End If

            ''  If necessary name of people have suffix on their name or nothing
            If getSuffix = "Suffix e.g. (Jr.)" Then
                setSuffix = "<N/A>"
            Else
                setSuffix = getSuffix
            End If



            ''  Process after passing on restrictions

            With rs
                ''  Check if new product information is unique
                If .State <> 0 Then .Close()
                .Open("SELECT Company FROM Suppliers WHERE Company ='" + setCompany + "';", cn, 1, 2)

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
                Call ResetDefaultSupplierTextFields()
                ' formAddSupplier.txtCompany.Text = Nothing

                'formAddSupplier.txtLname.Text = Nothing
                'formAddSupplier.txtFname.Text = Nothing
                'formAddSupplier.txtSuffix.Text = Nothing

                'formAddSupplier.txtContact.Text = Nothing
                'formAddSupplier.txtAddress.Text = Nothing
                'formAddSupplier.txtCity.Text = Nothing
                'formAddSupplier.txtProvince.Text = Nothing
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
