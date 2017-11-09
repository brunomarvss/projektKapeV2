
Module moduleAddProduct
    Sub ResetDefaultdSuppliers()
        formAddProduct.txtBrand.Text = "Brand Name"
        formAddProduct.txtGeneric.Text = "Generic Name"
        formAddProduct.txtQty.Text = "Item Quantity"
        formAddProduct.txtRawPrice.Text = "Raw Price"
        formAddProduct.txtSRP.Text = "SRP"
    End Sub

    Sub LoadRegisteredSuppliers()
        Try
            rs = New ADODB.Recordset

            With rs
                If .State <> 0 Then .Close()
                .Open("SELECT * FROM Suppliers;", cn, 1, 2)

                '''''''''''''''''''''''''Select employee data only on the database'''''''''''''''''''''''''
                formAddProduct.comboSupplierList.Items.Clear()
                formAddProduct.comboSupplierList.Items.Add("(Select One Supplier)")

                While .EOF = False
                    formAddProduct.comboSupplierList.Items.Add(.Fields("Company").Value)
                    .MoveNext()
                End While
                .Close()
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub AddNewProduct()
        ''  Declares the variable only on adding employees
        Dim getBrand = "", getGeneric = "", getQty = "", getSupplier = "", getRawPrice = "", getSRP As String = ""
        Dim setBrand = "", setGeneric = "", setQty = "", setSupplier = "", setRawPrice = "", setSRP As String = ""

        ''  Initialize declared variables
        getSupplier = formAddProduct.comboSupplierList.SelectedItem.ToString

        getBrand = formAddProduct.txtBrand.Text.Trim
        getGeneric = formAddProduct.txtGeneric.Text.Trim
        getQty = formAddProduct.txtQty.Text.Trim

        getRawPrice = formAddProduct.txtRawPrice.Text.Trim
        getSRP = formAddProduct.txtSRP.Text.Trim


        ''  Restrictions on text fields
        If getBrand = "Brand Name" Or getGeneric = "Generic Name" Or getQty = "Item Quantity" Or getSupplier = "(Select One Supplier)" Or getRawPrice = "Raw Price" Or getSRP = "SRP" Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            Exit Sub

        Else

            setBrand = getBrand
            setGeneric = getGeneric
            setQty = getQty
            setSupplier = getSupplier
            setRawPrice = getRawPrice
            setSRP = getSRP
        End If



        ''  Process after passing on restrictions
        Try
            rs = New ADODB.Recordset

            With rs
                ''  Check if new product information is unique
                If .State <> 0 Then .Close()
                .Open("SELECT BrandName FROM Products WHERE BrandName ='" + setBrand + "';", cn, 1, 2)

                If .EOF = False Then
                    MsgBox("This product was already registered, product brand name must be no items matched on registered items")
                    Exit Sub
                End If

                ''  Get coresponding ID value for selected company name
                If .State <> 0 Then .Close()
                .Open("SELECT ID FROM Suppliers WHERE Company ='" + getSupplier + "';", cn, 1, 2)

                If .EOF = False Then
                    setSupplier = .Fields("ID").Value
                End If

                ''  Set values from desire input of user
                If .State <> 0 Then .Close()
                .Open("INSERT INTO Products (BrandName, GenericName, RawPrice, SRP, Supplier_ID)" +
                      "VALUES ('" + setBrand + "', '" + setGeneric + "', '" + Format(Val(setRawPrice), "0.00") + "', '" + Format(Val(setSRP), "0.00") + "', '" + setSupplier + "');", cn, 1, 2)

                ''  Set values of items available for notification on dashboard
                If .State <> 0 Then .Close()
                .Open("INSERT INTO Inventory (InitialLevel, CurrentLevel)" +
                      "VALUES ('" + setQty + "','" + setQty + "');", cn, 1, 2)

                MsgBox("Saving Successful!", MsgBoxStyle.Information, "Record Saved")
                Call ResetDefaultdSuppliers()
                formAddProduct.comboSupplierList.SelectedIndex = 0
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
