Module moduleEmployee
    Sub ResetDefaultAddEmployeeTextFields()
        formAddEmployee.txtJobTitle.Text = "Work Title"
        formAddEmployee.txtLname.Text = "Last Name"
        formAddEmployee.txtFname.Text = "First Name"
        formAddEmployee.txtMname.Text = "Middle Name"
        formAddEmployee.txtSuffix.Text = "Suffix e.g. (Jr.)"
        formAddEmployee.txtContact.Text = "Contact Number"
        formAddEmployee.txtAddress.Text = "Address Details"
        formAddEmployee.txtCity.Text = "City"
        formAddEmployee.txtProvince.Text = "Province"
    End Sub
    Sub ResetDefaultUpdateEmployeeTextFields()
        formUpdateEmployee.txtJobTitle.Text = "Work Title"
        formUpdateEmployee.txtLname.Text = "Last Name"
        formUpdateEmployee.txtFname.Text = "First Name"
        formUpdateEmployee.txtMname.Text = "Middle Name"
        formUpdateEmployee.txtSuffix.Text = "Suffix e.g. (Jr.)"
        formUpdateEmployee.txtContact.Text = "Contact Number"
        formUpdateEmployee.txtAddress.Text = "Address Details"
        formUpdateEmployee.txtCity.Text = "City"
        formUpdateEmployee.txtProvince.Text = "Province"
    End Sub

    Sub restrictAddEmployees()
        ''  Default text field tips if text field was blank/null
        If formAddEmployee.txtJobTitle.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formAddEmployee.txtJobTitle.Select()
            Exit Sub
        End If

        If formAddEmployee.txtLname.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formAddEmployee.txtLname.Select()
            Exit Sub
        End If

        If formAddEmployee.txtFname.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formAddEmployee.txtFname.Select()
            Exit Sub
        End If

        If (formAddEmployee.txtMname.Text.Equals("") Or formAddEmployee.txtMname.Text.Equals("Middle Name")) Then
            formAddEmployee.txtMname.Text = "<N/A>"
        End If

        If (formAddEmployee.txtSuffix.Text.Equals("") Or formAddEmployee.txtSuffix.Text.Equals("Suffix e.g. (Jr.)")) Then
            formAddEmployee.txtSuffix.Text = "<N/A>"
        End If

        If Not IsNumeric(formAddEmployee.txtContact.Text) Then
            MsgBox("'Contact Number' input must not be blank and numbers only", vbCritical, "Error")
            formAddEmployee.txtContact.Text = ""
            formAddEmployee.txtContact.Select()
            Exit Sub

        ElseIf Val(formAddEmployee.txtContact.Text) < 0 Then
            MsgBox("'Contact Number' input must not contain negative values", vbCritical, "Error")
            formAddEmployee.txtContact.Text = ""
            formAddEmployee.txtContact.Select()
            Exit Sub

        ElseIf ((formAddEmployee.txtContact.Text.Length < 11) Or (formAddEmployee.txtContact.Text.Length > 11)) Then
            MsgBox("'Contact Number' input must be 11 digit numbers", vbCritical, "Error")
            formAddEmployee.txtContact.Text = ""
            formAddEmployee.txtContact.Select()
            Exit Sub

        ElseIf Not formAddEmployee.txtContact.Text.Substring(0, 2).Equals("09") Then
            MsgBox("'Contact Number' input must starts at '09' numbers (PH based digits)", vbCritical, "Error")
            formAddEmployee.txtContact.Text = ""
            formAddEmployee.txtContact.Select()
            Exit Sub

        End If

        If formAddEmployee.txtAddress.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formAddEmployee.txtAddress.Select()
            Exit Sub
        End If

        If formAddEmployee.txtCity.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formAddEmployee.txtCity.Select()
            Exit Sub
        End If

        If formAddEmployee.txtProvince.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formAddEmployee.txtProvince.Select()
            Exit Sub
        End If

        Call AddEmployee()
    End Sub
    Sub restrictUpdateEmployees()
        ''  Default text field tips if text field was blank/null
        If formUpdateEmployee.txtJobTitle.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formUpdateEmployee.txtJobTitle.Select()
            Exit Sub
        End If

        If formUpdateEmployee.txtLname.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formUpdateEmployee.txtLname.Select()
            Exit Sub
        End If

        If formUpdateEmployee.txtFname.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formUpdateEmployee.txtFname.Select()
            Exit Sub
        End If

        If formUpdateEmployee.txtMname.Text.Equals("") Then
            formUpdateEmployee.txtMname.Text = "<N/A>"
        End If

        If formUpdateEmployee.txtSuffix.Text.Equals("") Then
            formUpdateEmployee.txtSuffix.Text = "<N/A>"
        End If

        If Not IsNumeric(formUpdateEmployee.txtContact.Text) Then
            MsgBox("'Contact Number' input must not be blank and numbers only", vbCritical, "Error")
            formUpdateEmployee.txtContact.Text = ""
            formUpdateEmployee.txtContact.Select()
            Exit Sub

        ElseIf Val(formUpdateEmployee.txtContact.Text) < 0 Then
            MsgBox("'Contact Number' input must not contain negative values", vbCritical, "Error")
            formUpdateEmployee.txtContact.Text = ""
            formUpdateEmployee.txtContact.Select()
            Exit Sub

        ElseIf ((formUpdateEmployee.txtContact.Text.Length < 11) Or (formUpdateEmployee.txtContact.Text.Length > 11)) Then
            MsgBox("'Contact Number' input must be 11 digit numbers", vbCritical, "Error")
            formUpdateEmployee.txtContact.Text = ""
            formUpdateEmployee.txtContact.Select()
            Exit Sub

        ElseIf Not formUpdateEmployee.txtContact.Text.Substring(0, 2).Equals("09") Then
            MsgBox("'Contact Number' input must starts at '09' numbers (PH based digits)", vbCritical, "Error")
            formUpdateEmployee.txtContact.Text = ""
            formUpdateEmployee.txtContact.Select()
            Exit Sub

        End If

        If formUpdateEmployee.txtAddress.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formUpdateEmployee.txtAddress.Select()
            Exit Sub
        End If

        If formUpdateEmployee.txtCity.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formUpdateEmployee.txtCity.Select()
            Exit Sub
        End If

        If formUpdateEmployee.txtProvince.Text.Equals("") Then
            MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
            formUpdateEmployee.txtProvince.Select()
            Exit Sub
        End If

        Call UpdateEmployee()
    End Sub

    Sub AddEmployee()
        ''  Declares the variable only on adding employees
        Dim setLname = "", setMname = "", setFname = "", setSuffix = "", setContact = "", setAddress = "", setCity = "", setProvince = "", setJob As String = ""

        Try
            rs = New ADODB.Recordset

            ''  Initialize declared variables
            setJob = formAddEmployee.txtJobTitle.Text.Trim

            setLname = formAddEmployee.txtLname.Text.Trim
            setMname = formAddEmployee.txtMname.Text.Trim
            setFname = formAddEmployee.txtFname.Text.Trim
            setSuffix = formAddEmployee.txtSuffix.Text.Trim

            setContact = formAddEmployee.txtContact.Text.Trim
            setAddress = formAddEmployee.txtAddress.Text.Trim
            setCity = formAddEmployee.txtCity.Text.Trim
            setProvince = formAddEmployee.txtProvince.Text.Trim


            ''  Check if any text fields have no applicable record
            If setJob = "Work Title" Or setLname = "Last Name" Or setFname = "First Name" Or setContact = "Contact Number" Or setAddress = "Address Details" Or setCity = "City" Or setProvince = "Province" Then
                MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
                Exit Sub

            End If

            ''  If necessary name of people have suffix or middle name on their name or nothing
            If setSuffix = "Suffix e.g. (Jr.)" Then
                setSuffix = "<N/A>"
            End If

            If setMname = "Middle Name" Then
                setMname = "<N/A>"
            End If



            ''  Process after passing on restrictions

            With rs
                ''  Check if new employee information is unique
                If .State <> 0 Then .Close()
                .Open("SELECT * FROM Employees " +
                      "WHERE (LastName='" + setLname + "' AND FirstName='" + setFname + "' AND " +
                      "MiddleName='" + setMname + "' AND Suffix='" + setSuffix + "');", cn, 1, 2)

                If .EOF = False Then
                    MsgBox("This employee was already registered, supplier's company name must be no items matched on registered companies")
                    Exit Sub
                End If

                ''  Saves new employee data on the database
                If .State <> 0 Then .Close()
                .Open("INSERT INTO Employees (LastName, FirstName, MiddleName, Suffix, JobTitle, Contact, Address, City, Province)" +
                      "VALUES ('" + setLname + "', '" + setFname + "', '" + setMname + "', '" + setSuffix + "', '" +
                      setJob + "', '" + setContact + "', '" + setAddress + "', '" + setCity + "', '" + setProvince + "');", cn, 1, 2)

                '''''''''''''''''''''''''Insert employee data on the database'''''''''''''''''''''''''
                MsgBox("Saving Successful!", MsgBoxStyle.Information, "Record Saved")
                Call formMainAdmin.refreshEmployeeList()
                Call ResetDefaultAddEmployeeTextFields()
                formAddEmployee.txtJobTitle.Select()
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub UpdateEmployee()
        ''  Declares the variable only on adding employees
        Dim setLname = "", setMname = "", setFname = "", setSuffix = "", setContact = "", setAddress = "", setCity = "", setProvince = "", setJob As String = ""

        Try
            rs = New ADODB.Recordset

            ''  Initialize declared variables
            setJob = formUpdateEmployee.txtJobTitle.Text.Trim

            setLname = formUpdateEmployee.txtLname.Text.Trim
            setMname = formUpdateEmployee.txtMname.Text.Trim
            setFname = formUpdateEmployee.txtFname.Text.Trim
            setSuffix = formUpdateEmployee.txtSuffix.Text.Trim

            setContact = formUpdateEmployee.txtContact.Text.Trim
            setAddress = formUpdateEmployee.txtAddress.Text.Trim
            setCity = formUpdateEmployee.txtCity.Text.Trim
            setProvince = formUpdateEmployee.txtProvince.Text.Trim



            ''  Process after passing on restrictions

            With rs
                ''  Check if new employee information is unique
                If .State <> 0 Then .Close()
                .Open("SELECT * FROM Employees " +
                      "WHERE (LastName='" + setLname + "' AND FirstName='" + setFname + "' AND " +
                      "MiddleName='" + setMname + "' AND Suffix='" + setSuffix + "');", cn, 1, 2)

                If .EOF = False Then
                    MsgBox("This employee was already registered, supplier's company name must be no items matched on registered companies")
                    Exit Sub
                End If

                ''  Update existing data for a new one
                If .State <> 0 Then .Close()
                .Open("UPDATE Employees " +
                      "SET LastName='" + setLname + "', FirstName='" + setFname + "', MiddleName='" + setMname + "', " +
                      "Suffix='" + setSuffix + "', Contact='" + setContact + "', JobTitle='" + setJob + "', " +
                      "Address='" + setAddress + "', City='" + setCity + "', Province='" + setProvince + "' " +
                      "WHERE ID=" + formMainAdmin.employeeID + ";", cn, 1, 2)

                MsgBox("EMPLOYEE UPDATED!", vbInformation, "ECT Pharmacy POS")
                Call formMainAdmin.refreshEmployeeList()
                Call ResetDefaultUpdateProductTextFields()
                formUpdateEmployee.Hide()
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
