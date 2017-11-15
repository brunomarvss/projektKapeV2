Module moduleAddEmployee
    Sub ResetDefaultEmployeeTextFields()
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

    Sub AddNewEmployee()
        ''  Declares the variable only on adding employees
        Dim getLname = "", getMname = "", getFname = "", getSuffix = "", getContact = "", getAddress = "", getCity = "", getProvince = "", getJob As String = ""
        Dim setLname = "", setMname = "", setFname = "", setSuffix = "", setContact = "", setAddress = "", setCity = "", setProvince = "", setJob As String = ""

        Try
            rs = New ADODB.Recordset

            ''  Initialize declared variables
            getJob = formUpdateEmployee.txtJobTitle.Text.Trim

            getLname = formUpdateEmployee.txtLname.Text.Trim
            getMname = formUpdateEmployee.txtMname.Text.Trim
            getFname = formUpdateEmployee.txtFname.Text.Trim
            getSuffix = formUpdateEmployee.txtSuffix.Text.Trim

            getContact = formUpdateEmployee.txtContact.Text.Trim
            getAddress = formUpdateEmployee.txtAddress.Text.Trim
            getCity = formUpdateEmployee.txtCity.Text.Trim
            getProvince = formUpdateEmployee.txtProvince.Text.Trim


            ''  Check if any text fields have no applicable record
            If getJob = "Work Title" Or getLname = "Last Name" Or getFname = "First Name" Or getContact = "Contact Number" Or getAddress = "Address Details" Or getCity = "City" Or getProvince = "State/Province" Then
                MsgBox("You must fill up all fields before you commit saving of data/s", vbCritical, "Error")
                Exit Sub

            Else

                setJob = getJob
                setLname = getLname
                setFname = getFname
                setContact = getContact
                setAddress = getAddress
                setCity = getCity
                setProvince = getProvince
            End If

            ''  If necessary name of people have suffix or middle name on their name or nothing
            If getSuffix = "Suffix e.g. (Jr.)" Then
                setSuffix = "<N/A>"
            Else
                setSuffix = getSuffix
            End If

            If getMname = "Middle Name" Then
                setMname = "<N/A>"
            Else
                setMname = getMname
            End If



            ''  Process after passing on restrictions

            With rs
                If .State <> 0 Then .Close()
                .Open("INSERT INTO Employees (LastName, FirstName, MiddleName, Suffix, JobTitle, Contact, Address, City, Province)" +
                      "VALUES ('" + setLname + "', '" + setFname + "', '" + setMname + "', '" + setSuffix + "', '" +
                      setJob + "', '" + setContact + "', '" + setAddress + "', '" + setCity + "', '" + setProvince + "');", cn, 1, 2)

                '''''''''''''''''''''''''Insert employee data on the database'''''''''''''''''''''''''
                MsgBox("Saving Successful!", MsgBoxStyle.Information, "Record Saved")
                Call ResetDefaultEmployeeTextFields()
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
