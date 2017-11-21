
Module moduleProduct
    Sub ResetDefaultAddProductTextFields()
        formAddProduct.txtBrand.Text = "Brand Name"
        formAddProduct.txtGeneric.Text = "Generic Name"

        formAddProduct.txtRawPrice.Text = "Raw Price"
        formAddProduct.txtSRP.Text = "SRP"

        formAddProduct.txtQty.Text = "Item Quantity"
        formAddProduct.txtReorderLvl.Text = "Reorder Level"
        formAddProduct.txtReorderQty.Text = "Reorder Quantity"
    End Sub
    Sub ResetDefaultUpdateProductTextFields()
        formUpdateProduct.txtBrand.Text = "Brand Name"
        formUpdateProduct.txtGeneric.Text = "Generic Name"
        formUpdateProduct.txtRawPrice.Text = "Raw Price"
        formUpdateProduct.txtSRP.Text = "SRP"
        formUpdateProduct.txtSupplier.Text = "Supplier"
    End Sub
    Sub LoadRegisteredSuppliers()
        Try
            rs = New ADODB.Recordset

            With rs
                If .State <> 0 Then .Close()
                .Open("SELECT * FROM Suppliers ORDER BY Company;", cn, 1, 2)

                '''''''''''''''''''''''''Select employee data only on the database'''''''''''''''''''''''''
                formAddProduct.comboSupplierList.Items.Clear()
                formAddProduct.comboSupplierList.Items.Add("(Select One Supplier)")

                While .EOF = False
                    formAddProduct.comboSupplierList.Items.Add(.Fields("Company").Value)
                    .MoveNext()
                End While

                formAddProduct.comboSupplierList.SelectedIndex = 0
                .Close()
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub restrictAddProducts()
        If formAddProduct.txtBrand.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formAddProduct.txtBrand.Select()
            Exit Sub
        End If

        If formAddProduct.txtGeneric.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formAddProduct.txtGeneric.Select()
            Exit Sub
        End If



        If formAddProduct.comboSupplierList.SelectedItem.Equals("(Select One Supplier)") Then
            MsgBox("Select designated supplier for this product item", vbCritical, "Error")
            formAddProduct.comboSupplierList.Select()
            Exit Sub
        End If

        ''  Auto two decimal places when text field leaves
        If Not IsNumeric(formAddProduct.txtRawPrice.Text) Then
            MsgBox("'Raw price' input must not be blank and numbers only", vbCritical, "Error")
            formAddProduct.txtRawPrice.Text = ""
            formAddProduct.txtRawPrice.Select()
            Exit Sub

        ElseIf Val(formAddProduct.txtRawPrice.Text) < 0 Then
            MsgBox("'Raw price' input must be more than to value of 1", vbCritical, "Error")
            formAddProduct.txtRawPrice.Text = ""
            formAddProduct.txtRawPrice.Select()
            Exit Sub

        Else
            formAddProduct.txtRawPrice.Text = Format(Val(formAddProduct.txtRawPrice.Text), "0.00")
        End If

        If Not IsNumeric(formAddProduct.txtSRP.Text) Then
            MsgBox("'SRP' input must not be blank and numbers only", vbCritical, "Error")
            formAddProduct.txtSRP.Text = ""
            formAddProduct.txtSRP.Select()
            Exit Sub

        ElseIf Val(formAddProduct.txtSRP.Text) < 0 Then
            MsgBox("'SRP' input must be more than to value of 0", vbCritical, "Error")
            formAddProduct.txtSRP.Text = ""
            formAddProduct.txtSRP.Select()
            Exit Sub

        Else
            formAddProduct.txtSRP.Text = Format(Val(formAddProduct.txtSRP.Text), "0.00")
        End If



        ''  Settings for product stocks
        If Not IsNumeric(formAddProduct.txtQty.Text) Then
            MsgBox("'Item quantity' input must not be blank and numbers only", vbCritical, "Error")
            formAddProduct.txtQty.Text = "0"
            formAddProduct.txtQty.Select()
            Exit Sub

        ElseIf Val(formAddProduct.txtQty.Text) < 0 Then
            MsgBox("'Item quantity' input must be more than to value of 0", vbCritical, "Error")
            formAddProduct.txtQty.Text = "0"
            formAddProduct.txtQty.Select()
            Exit Sub

        End If

        If Not IsNumeric(formAddProduct.txtReorderLvl.Text) Then
            MsgBox("'Reorder Level' input must not be blank and numbers only", vbCritical, "Error")
            formAddProduct.txtReorderLvl.Text = "0"
            formAddProduct.txtReorderLvl.Select()
            Exit Sub

        ElseIf (Val(formAddProduct.txtReorderLvl.Text) < 0) Or (Val(formAddProduct.txtReorderLvl.Text) >= Val(formAddProduct.txtQty.Text)) Then
            MsgBox("'Reorder Level' input must be more than to zero and less than to quantity", vbCritical, "Error")
            formAddProduct.txtReorderLvl.Text = "0"
            formAddProduct.txtReorderLvl.Select()
            Exit Sub

        End If

        If Not IsNumeric(formAddProduct.txtReorderQty.Text) Then
            MsgBox("'Reorder quantity' input must not be blank and numbers only", vbCritical, "Error")
            formAddProduct.txtReorderQty.Text = "0"
            formAddProduct.txtReorderQty.Select()
            Exit Sub

        ElseIf Val(formAddProduct.txtReorderQty.Text) < 0 Then
            MsgBox("'Reorder quantity' input must be more than to value of 0", vbCritical, "Error")
            formAddProduct.txtReorderQty.Text = "0"
            formAddProduct.txtReorderQty.Select()
            Exit Sub

        End If

        Call AddProduct()
    End Sub
    Sub restrictUpdateProducts()
        If formUpdateProduct.txtBrand.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formUpdateProduct.txtBrand.Select()
            Exit Sub
        End If

        If formUpdateProduct.txtGeneric.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formUpdateProduct.txtGeneric.Select()
            Exit Sub
        End If



        ''  Auto two decimal places when text field leaves
        If Not IsNumeric(formUpdateProduct.txtRawPrice.Text) Then
            MsgBox("'Raw price' input must not be blank and numbers only", vbCritical, "Error")
            formUpdateProduct.txtRawPrice.Text = ""
            formUpdateProduct.txtRawPrice.Select()
            Exit Sub

        ElseIf Val(formUpdateProduct.txtRawPrice.Text) < 0 Then
            MsgBox("'Raw price' input must be more than to value of 0", vbCritical, "Error")
            formUpdateProduct.txtRawPrice.Text = ""
            formUpdateProduct.txtRawPrice.Select()
            Exit Sub

        Else
            formUpdateProduct.txtRawPrice.Text = Format(Val(formUpdateProduct.txtRawPrice.Text), "0.00")
        End If

        If Not IsNumeric(formUpdateProduct.txtSRP.Text) Then
            MsgBox("'SRP' input must not be blank and numbers only", vbCritical, "Error")
            formUpdateProduct.txtSRP.Text = ""
            formUpdateProduct.txtSRP.Select()
            Exit Sub

        ElseIf Val(formUpdateProduct.txtSRP.Text) < 0 Then
            MsgBox("'SRP' input must be more than to value of 0", vbCritical, "Error")
            formUpdateProduct.txtSRP.Text = ""
            formUpdateProduct.txtSRP.Select()
            Exit Sub

        Else
            formUpdateProduct.txtSRP.Text = Format(Val(formUpdateProduct.txtSRP.Text), "0.00")
        End If

        Call UpdateProduct()
    End Sub
    Sub AddProduct()
        ''  Declares the variable only on adding employees
        Dim setBrand = "", setGeneric = "", setQty = "", setReorderLvl = "", setReorderQty = "", setSupplier = "", setRawPrice = "", setSRP As String = ""

        Try
            rs = New ADODB.Recordset

            ''  Initialize declared variables
            setSupplier = formAddProduct.comboSupplierList.SelectedItem.ToString

            setBrand = formAddProduct.txtBrand.Text.Trim
            setGeneric = formAddProduct.txtGeneric.Text.Trim

            setRawPrice = formAddProduct.txtRawPrice.Text.Trim
            setSRP = formAddProduct.txtSRP.Text.Trim

            setQty = formAddProduct.txtQty.Text.Trim
            setReorderLvl = formAddProduct.txtReorderLvl.Text.Trim
            setReorderQty = formAddProduct.txtReorderLvl.Text.Trim


            ''  Restrictions on text fields
            If setBrand = "Brand Name" Or setGeneric = "Generic Name" Or
                setReorderLvl = "Reorder Level" Or setReorderQty = "Reorder Quantity" Or
                setQty = "Item Quantity" Or setSupplier = "(Select One Supplier)" Or
                setRawPrice = "Raw Price" Or setSRP = "SRP" Then

                MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
                Exit Sub

            End If



            ''  Process after passing on restrictions

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
                .Open("SELECT ID FROM Suppliers WHERE Company ='" + setSupplier + "';", cn, 1, 2)

                If .EOF = False Then
                    setSupplier = .Fields("ID").Value
                End If

                ''  Set values from desire input of user
                If .State <> 0 Then .Close()
                .Open("INSERT INTO Products (BrandName, GenericName, RawPrice, SRP, Supplier_ID)" +
                      "VALUES ('" + setBrand + "', '" + setGeneric + "', '" + Format(Val(setRawPrice), "0.00") + "', '" + Format(Val(setSRP), "0.00") + "', '" + setSupplier + "');", cn, 1, 2)

                ''  Set values of items CurrentLevel for notification on dashboard
                If .State <> 0 Then .Close()
                .Open("INSERT INTO Inventory (InitialLevel, CurrentLevel, ReorderLevel, MinReorderQty)" +
                      "VALUES ('" + setQty + "','" + setQty + "','" + setReorderLvl + "','" + setReorderQty + "');", cn, 1, 2)

                MsgBox("Saving Successful!", MsgBoxStyle.Information, "Record Saved")
                Call formMainAdmin.refreshProductList()
                Call ResetDefaultAddProductTextFields()
                formAddProduct.comboSupplierList.SelectedIndex = 0
                formAddProduct.txtBrand.Select()
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub UpdateProduct()
        ''  Declares the variable only on adding employees
        Dim setBrand = "", setGeneric = "", setQty = "", setSupplier = "", setRawPrice = "", setSRP As String = ""

        Try
            rs = New ADODB.Recordset

            ''  Initialize declared variables
            setSupplier = formUpdateProduct.txtSupplier.Text.Trim

            setBrand = formUpdateProduct.txtBrand.Text.Trim
            setGeneric = formUpdateProduct.txtGeneric.Text.Trim

            setRawPrice = formUpdateProduct.txtRawPrice.Text.Trim
            setSRP = formUpdateProduct.txtSRP.Text.Trim



            ''  Process after passing on restrictions

            With rs
                ''  Check if new product information is unique
                If .State <> 0 Then .Close()
                .Open("SELECT BrandName FROM Products WHERE BrandName ='" + setBrand + "';", cn, 1, 2)

                If .EOF = False Then
                    MsgBox("This product was already registered, product brand name must be no items matched on registered items")
                    Exit Sub
                End If

                ''  Update existing data for a new one
                If .State <> 0 Then .Close()
                .Open("UPDATE Products " +
                      "SET BrandName='" + setBrand + "', GenericName='" + setGeneric + "', " +
                      "RawPrice='" + setRawPrice + "', SRP='" + setSRP + "' " +
                      "WHERE ID=" + formMainAdmin.prodID + "", cn, 1, 2)

                MsgBox("ITEM UPDATED!", vbInformation, "ECT Pharmacy POS")
                Call formMainAdmin.refreshProductList()
                Call ResetDefaultUpdateProductTextFields()
                formUpdateProduct.Hide()
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
