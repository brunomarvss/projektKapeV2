Imports Microsoft.Office.Interop
Imports System.Globalization

Public Class formMainAdmin
    Dim selectedSearchType As String = ""
    Dim TimeValue As Decimal = 1000.0
    Public prodID = "", prodQty = "", employeeID = "", supplierCompany As String = ""
    Dim getSuffix = "", setSuffix As String = ""

    ''  Declaration of values used on initialization of "EXCEL WORKBOOK"
    Dim xl As New Excel.Application
    Dim xlwbook As Excel.Workbook
    Dim xlwsheet As Excel.Worksheet
    Public row As Integer = 8

    ''  Get specific/range of date to be generated on "View Reports" Section 
    Dim txtSelectedSearch As String = ""
    Dim txtSearchDay = "", txtSearchMonth = "", txtSearchYear As String = ""
    Dim txtSpecificDate = "", txtSearchDate As String = ""
    Dim xdate As Date = "Apr-19-1997"


    ''  Base comparation of query values
    Public queryQty = "", querySupplier = "", queryRawPrice = "", queryTotalRawPrice = "", querySRP = "", queryTotalSRP = "", queryIncome As String = ""
    Public queryData = "", storedData As String = ""

    ''  Stored * filter data
    Public dataSupplierID, dataSupplierName, dataItem, dataQtySold, dataRawPrice, dataTotalRawPrice, dataSRP, dataTotalSRP, dataIncome As String()

    ''  Related to supplier and filtered data/s if increase of size of array will be implement
    Public searchID As Integer = 1
    Public accendSize = 0, matchField = 0, ctr As Integer = 0

    ''  Get stored values from arrays to printing of reports
    Public x = 0, y As Integer = 0
    Public IDValue = 1, uniqueValue As Integer = 0
    Public traceValue As Integer = 0
    Public totalRaw = "", totalSRP = "", totalIncome As String = ""



    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        labelTimeAdmin.Text = Format(Now, "yyyy-MM-dd    hh:mm:ss")
    End Sub
    Private Sub TimerStats_Tick(sender As Object, e As EventArgs) Handles TimerStats.Tick
        'StatDaily.Value = StatDaily.Value + (TimeValue * 0.002)
        'MsgBox(StatDaily.Value)
    End Sub
    Private Sub formMainAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Start()
        TimerStats.Start()
        Call moduleAdminStatistics.evaluateDailySales()

        ''  Close recent excel processes from "View Reports" Event triggered
        Call connectionModule.TerminateExcel()

        ''  Refresh month to be choice by abbreviation
        comboSearchMonth.Items.Clear()
        For i As Integer = 1 To 12
            comboSearchMonth.Items.Add(MonthName(i, True))
        Next

        ''''  RESET TO DEFAULT VALUES ''''

        ''  Initialize starting or selected value on reports
        comboSelectedReport.SelectedIndex = 0
        comboSearchDay.SelectedIndex = 0
        comboSearchMonth.SelectedIndex = 0
        comboSearchYear.SelectedIndex = 0

        ''  Initialize * value with first index
        comboSearchProduct.SelectedIndex = 0
        comboSearchEmployee.SelectedIndex = 0
        comboSearchSupplier.SelectedIndex = 0

        txtSearchProduct.Text = "SEARCH"
        txtSearchEmployee.Text = "SEARCH"
        txtSearchSupplier.Text = "SEARCH"

        ''  List all datas recorded on the database
        'refreshDashboard()
        selectedSearchType = "ORDER BY Products.BrandName"
        refreshProductList()

        selectedSearchType = "ORDER BY Employees.ID"
        refreshEmployeeList()

        selectedSearchType = "ORDER BY Suppliers.ID"
        refreshSupplierList()
    End Sub



    ''  Reload * data/s from the database
    Sub refreshDashboard()
        Dim dateString As String = "#09/03/2017#"
        'MsgBox(DateAndTime.Weekday(dateString))
        MsgBox(Format(Now, "yyyy"))
    End Sub
    Sub refreshProductList()
        Try
            rs = New ADODB.Recordset

            With rs
                If .State <> 0 Then .Close()
                .Open("SELECT Products.*, Suppliers.*, Inventory.CurrentLevel " +
                      "FROM ((Products " +
                      "INNER JOIN Inventory ON Products.ID=Inventory.ID) " +
                      "INNER JOIN Suppliers ON Products.Supplier_ID=Suppliers.ID) " +
                      selectedSearchType + ";", cn, 1, 2)

                '''''''''''''''''''''''''Backup query if joining will be cancelled'''''''''''''''''''''''''
                '.Open("SELECT * FROM Products WHERE BrandName Like '%" + txtSearchProduct.Text.Trim + "%'", cn, 1, 2)

                '''''''''''''''''''''''''List all possible products search by employee'''''''''''''''''''''''''
                listProducts.Items.Clear()
                selectedSearchType = ""

                While .EOF = False
                    listItems = listProducts.Items.Add(.Fields("Products.ID").Value)
                    listItems.SubItems.Insert(1, New ListViewItem.ListViewSubItem(Nothing, .Fields("BrandName").Value))
                    listItems.SubItems.Insert(2, New ListViewItem.ListViewSubItem(Nothing, .Fields("GenericName").Value))
                    listItems.SubItems.Insert(3, New ListViewItem.ListViewSubItem(Nothing, .Fields("CurrentLevel").Value))
                    listItems.SubItems.Insert(4, New ListViewItem.ListViewSubItem(Nothing, .Fields("Company").Value))
                    listItems.SubItems.Insert(5, New ListViewItem.ListViewSubItem(Nothing, .Fields("RawPrice").Value))
                    listItems.SubItems.Insert(6, New ListViewItem.ListViewSubItem(Nothing, .Fields("SRP").Value))
                    .MoveNext()
                End While
                .Close()
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub refreshEmployeeList()
        Try
            rs = New ADODB.Recordset

            With rs
                If .State <> 0 Then .Close()
                .Open("SELECT * FROM Employees " +
                "WHERE NOT JobTitle='Owner' " + selectedSearchType + ";", cn, 1, 2)

                ''  List all registered employee accounts from the database
                listEmployee.Items.Clear()
                selectedSearchType = ""

                While .EOF = False
                    ''  Initials variable to clear recent value
                    getSuffix = vbNull
                    getSuffix = .Fields("Suffix").Value

                    ''  Checks if variable is not null 
                    If Not getSuffix.Equals("<N/A>") Then
                        setSuffix = " " + getSuffix + ", "
                    Else
                        setSuffix = ", "
                    End If

                    listItems = listEmployee.Items.Add(.Fields("ID").Value)
                    listItems.SubItems.Insert(1, New ListViewItem.ListViewSubItem(Nothing, .Fields("LastName").Value + setSuffix + .Fields("FirstName").Value + " " + .Fields("MiddleName").Value))
                    listItems.SubItems.Insert(2, New ListViewItem.ListViewSubItem(Nothing, .Fields("Contact").Value))
                    listItems.SubItems.Insert(3, New ListViewItem.ListViewSubItem(Nothing, .Fields("JobTitle").Value))
                    listItems.SubItems.Insert(4, New ListViewItem.ListViewSubItem(Nothing, .Fields("Address").Value + " " + .Fields("City").Value + " " + .Fields("Province").Value))
                    .MoveNext()
                End While
                .Close()
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub refreshSupplierList()
        Try
            rs = New ADODB.Recordset
            With rs
                If .State <> 0 Then .Close()
                .Open("SELECT * FROM Suppliers " + selectedSearchType + ";", cn, 1, 2)

                '''''''''''''''''''''''''Select supplier data only on the database'''''''''''''''''''''''''
                listSupplier.Items.Clear()
                selectedSearchType = ""

                While .EOF = False
                    ''  Initials variable to clear recent value
                    getSuffix = vbNull
                    getSuffix = .Fields("Suffix").Value

                    ''  Checks if variable is not null 
                    If Not getSuffix.Equals("<N/A>") Then
                        setSuffix = " " + getSuffix + ", "
                    Else
                        setSuffix = ", "
                    End If

                    listItems = listSupplier.Items.Add(.Fields("Company").Value)
                    listItems.SubItems.Insert(1, New ListViewItem.ListViewSubItem(Nothing, .Fields("LastName").Value + setSuffix + .Fields("FirstName").Value))
                    listItems.SubItems.Insert(2, New ListViewItem.ListViewSubItem(Nothing, .Fields("Contact").Value))
                    listItems.SubItems.Insert(3, New ListViewItem.ListViewSubItem(Nothing, .Fields("Address").Value + ", " + .Fields("City").Value + ", " + .Fields("Province").Value))
                    .MoveNext()
                End While
                .Close()
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    ''  GET unique ID for selected items/products etc.  ''
    Sub getProductData()
        Try
            Dim item As ListView.SelectedListViewItemCollection = listProducts.SelectedItems
            Dim items As ListViewItem
            Dim i As Integer = 0
            prodID = ""
            supplierCompany = ""


            For Each items In item
                ''  Get only the data of first colume
                prodID = items.SubItems(i).Text
                i += 1 : formUpdateProduct.txtBrand.Text = items.SubItems(i).Text
                i += 1 : formUpdateProduct.txtGeneric.Text = items.SubItems(i).Text
                i += 1 : prodQty = items.SubItems(i).Text
                i += 1 : formUpdateProduct.txtSupplier.Text = items.SubItems(i).Text
                i += 1 : formUpdateProduct.txtRawPrice.Text = items.SubItems(i).Text
                i += 1 : formUpdateProduct.txtSRP.Text = items.SubItems(i).Text
            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub getEmployeeData()
        Try
            Dim item As ListView.SelectedListViewItemCollection = listEmployee.SelectedItems
            Dim items As ListViewItem
            Dim i As Integer = 0
            employeeID = ""

            For Each items In item
                ''  Get only the data of first colume
                employeeID = items.SubItems(i).Text
            Next

            selectedSearchType = "AND ID=" + employeeID

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub getSupplierData()
        Try
            Dim item As ListView.SelectedListViewItemCollection = listSupplier.SelectedItems
            Dim items As ListViewItem
            Dim i As Integer = 0
            supplierCompany = ""

            For Each items In item
                ''  Get only the data of first colume
                supplierCompany = items.SubItems(i).Text
            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    Private Sub listProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listProducts.SelectedIndexChanged
        Call getProductData()
        MsgBox(prodID)
    End Sub
    Private Sub listEmployees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listEmployee.SelectedIndexChanged
        Call getEmployeeData()
    End Sub
    Private Sub listSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listSupplier.SelectedIndexChanged
        Call getSupplierData()
    End Sub

    ''  SELECTION of ITEM first before commit of REMOVAL  ''
    Private Sub listProducts_Click(sender As Object, e As EventArgs) Handles listProducts.Click
        Call getProductData()
    End Sub
    Private Sub listEmployee_Click(sender As Object, e As EventArgs) Handles listEmployee.Click
        Call getEmployeeData()
    End Sub
    Private Sub listSupplier_Click(sender As Object, e As EventArgs) Handles listSupplier.Click
        Call getSupplierData()
    End Sub



    ''  CREATION of items/products etc.  ''
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        formAddProduct.Dispose()
        formAddProduct.ShowDialog()
    End Sub
    Private Sub btnAddStock_Click(sender As Object, e As EventArgs) Handles btnAddStock.Click
        MsgBox("Double click an item in the listview to add a stock.", vbInformation)

    End Sub
    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        formAddEmployee.Dispose()
        formAddEmployee.ShowDialog()
    End Sub
    Private Sub btnAddSupplier_Click(sender As Object, e As EventArgs) Handles btnAddSupplier.Click
        formAddSupplier.Dispose()
        formAddSupplier.ShowDialog()
    End Sub



    ''  UPDATE selected item on a list  ''
    Private Sub listProducts_DoubleClick(sender As Object, e As EventArgs) Handles listProducts.DoubleClick
        Try
            formUpdateProduct.Dispose()
            Call getProductData()
            formUpdateProduct.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub listEmployee_DoubleClick(sender As Object, e As EventArgs) Handles listEmployee.DoubleClick
        ''  GET first unique ID for identification of selected item
        Call getProductData()

        Try
            rs = New ADODB.Recordset

            With rs
                If .State <> 0 Then .Close()
                .Open("SELECT * FROM Employees " +
                "WHERE Not JobTitle='Owner' " + selectedSearchType + ";", cn, 1, 2)


                If .EOF = False Then
                    formUpdateEmployee.Dispose()

                    formUpdateEmployee.txtLname.Text = .Fields("LastName").Value
                    formUpdateEmployee.txtSuffix.Text = .Fields("Suffix").Value
                    formUpdateEmployee.txtFname.Text = .Fields("FirstName").Value
                    formUpdateEmployee.txtMname.Text = .Fields("MiddleName").Value
                    formUpdateEmployee.txtContact.Text = .Fields("Contact").Value
                    formUpdateEmployee.txtJobTitle.Text = .Fields("JobTitle").Value
                    formUpdateEmployee.txtAddress.Text = .Fields("Address").Value
                    formUpdateEmployee.txtCity.Text = .Fields("City").Value
                    formUpdateEmployee.txtProvince.Text = .Fields("Province").Value

                    formUpdateEmployee.ShowDialog()
                End If
                .Close()
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub listSupplier_DoubleClick(sender As Object, e As EventArgs) Handles listSupplier.DoubleClick
        ''  GET first unique ID for identification of selected item
        Call getProductData()

        Try
            rs = New ADODB.Recordset

            With rs
                If .State <> 0 Then .Close()
                .Open("SELECT * FROM Suppliers " +
                      "WHERE Company ='" + supplierCompany + "';", cn, 1, 2)


                If .EOF = False Then
                    formUpdateSupplier.Dispose()

                    formUpdateSupplier.txtCompany.Text = .Fields("Company").Value
                    formUpdateSupplier.txtLname.Text = .Fields("LastName").Value
                    formUpdateSupplier.txtSuffix.Text = .Fields("Suffix").Value
                    formUpdateSupplier.txtFname.Text = .Fields("FirstName").Value
                    formUpdateSupplier.txtContact.Text = .Fields("Contact").Value
                    formUpdateSupplier.txtAddress.Text = .Fields("Address").Value
                    formUpdateSupplier.txtCity.Text = .Fields("City").Value
                    formUpdateSupplier.txtProvince.Text = .Fields("Province").Value

                    formUpdateSupplier.ShowDialog()
                End If
                .Close()
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    ''  DELETION of selected items/products etc.  "
    Private Sub btnDelProduct_Click(sender As Object, e As EventArgs) Handles btnDelProduct.Click
        Try
            rs = New ADODB.Recordset

            If MessageBox.Show("DO YOU WANT TO DELETE THIS REGISTERED PRODUCT ITEM?", "ECT Pharmacy", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                With rs
                    If .State <> 0 Then .Close()
                    .Open("DELETE FROM Products " +
                          "WHERE ID =" + prodID + ";", cn, 1, 2)

                    If .State <> 0 Then .Close()
                    .Open("DELETE FROM Inventory " +
                          "WHERE ID =" + prodID + ";", cn, 1, 2)

                End With

                MsgBox("RECORD DELETED SUCCESSFUL!", vbInformation, "ECT Pharmacy")
                Call refreshProductList()

            Else
                Exit Sub

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnDelEmployee_Click(sender As Object, e As EventArgs) Handles btnDelEmployee.Click
        Try
            rs = New ADODB.Recordset

            If MessageBox.Show("DO YOU WANT TO DELETE THIS REGISTERED EMPLOYEE?", "ECT Pharmacy", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                With rs
                    If .State <> 0 Then .Close()
                    .Open("DELETE FROM Employees " +
                          "WHERE ID =" + employeeID + ";", cn, 1, 2)

                End With

                MsgBox("RECORD DELETED SUCCESSFUL!", vbInformation, "ECT Pharmacy")
                Call refreshEmployeeList()

            Else
                Exit Sub

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnDelSupplier_Click(sender As Object, e As EventArgs) Handles btnDelSupplier.Click
        Try
            rs = New ADODB.Recordset

            If MessageBox.Show("DO YOU WANT TO DELETE THIS REGISTERED SUPPLIER?", "ECT Pharmacy", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                With rs
                    If .State <> 0 Then .Close()
                    .Open("DELETE FROM Suppliers " +
                          "WHERE Company='" + supplierCompany + "';", cn, 1, 2)

                End With

                MsgBox("RECORD DELETED SUCCESSFUL!", vbInformation, "ECT Pharmacy")
                Call refreshSupplierList()

            Else
                Exit Sub

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    ''  Automatic highlight * input text in a certain text field/s
    Private Sub txtSearchProduct_Click(sender As Object, e As EventArgs) Handles txtSearchProduct.Click
        txtSearchProduct.SelectAll()

        If comboSearchProduct.SelectedIndex.Equals(0) Then
            MsgBox("Select specific category type first to be search", vbCritical, "Error")
            selectedSearchType = Nothing
            comboSearchProduct.Select()
            Exit Sub
        End If
    End Sub
    Private Sub txtSearchEmployee_Click(sender As Object, e As EventArgs) Handles txtSearchEmployee.Click
        txtSearchEmployee.SelectAll()
        selectedSearchType = ""

        If comboSearchEmployee.SelectedIndex.Equals(0) Then
            MsgBox("Select specific category type first to be search", vbCritical, "Error")
            selectedSearchType = Nothing
            comboSearchEmployee.Select()
            Exit Sub
        End If
    End Sub
    Private Sub txtSearchSupplier_Click(sender As Object, e As EventArgs) Handles txtSearchSupplier.Click
        txtSearchSupplier.SelectAll()

        If comboSearchSupplier.SelectedIndex.Equals(0) Then
            MsgBox("Select specific category type first to be search", vbCritical, "Error")
            selectedSearchType = Nothing
            comboSearchSupplier.Select()
            Exit Sub
        End If
    End Sub



    ''  Check first category selected by the user for specific search
    Private Sub txtSearchProduct_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProduct.TextChanged
        Dim txtSearch = txtSearchProduct.Text.Trim

        If comboSearchProduct.SelectedIndex.Equals(1) Then
            selectedSearchType = "WHERE Products.BrandName LIKE '%" + txtSearch + "%' " +
                                 "ORDER BY Products.BrandName"
        ElseIf comboSearchProduct.SelectedIndex.Equals(2) Then
            selectedSearchType = "WHERE Inventory.CurrentLevel LIKE '%" + txtSearch + "%' " +
                                 "ORDER BY Products.BrandName"
        ElseIf comboSearchProduct.SelectedIndex.Equals(3) Then
            selectedSearchType = "WHERE Suppliers.Company LIKE '%" + txtSearch + "%' " +
                                 "ORDER BY Products.BrandName"
        ElseIf comboSearchProduct.SelectedIndex.Equals(4) Then
            selectedSearchType = "WHERE Products.SRP LIKE '%" + txtSearch + "%' " +
                                 "ORDER BY Products.BrandName"
        End If

        Call refreshProductList()
    End Sub
    Private Sub txtSearchEmployee_TextChanged(sender As Object, e As EventArgs) Handles txtSearchEmployee.TextChanged
        Dim txtSearch = txtSearchEmployee.Text.Trim

        If comboSearchEmployee.SelectedIndex.Equals(1) Then
            selectedSearchType = "AND (Address LIKE '%" + txtSearch + "%' OR City LIKE '%" + txtSearch + "%' OR Province LIKE '%" + txtSearch + "%') " +
                                 "ORDER BY Employees.ID"
        ElseIf comboSearchEmployee.SelectedIndex.Equals(2) Then
            selectedSearchType = "AND Contact LIKE '%" + txtSearch + "%' " +
                                 "ORDER BY Employees.ID"
        ElseIf comboSearchEmployee.SelectedIndex.Equals(3) Then
            selectedSearchType = "AND JobTitle LIKE '%" + txtSearch + "%' " +
                                 "ORDER BY Employees.ID"
        ElseIf comboSearchEmployee.SelectedIndex.Equals(4) Then
            selectedSearchType = "AND (LastName LIKE '%" + txtSearch + "%' OR Suffix LIKE '%" + txtSearch + "%' OR FirstName LIKE '%" + txtSearch + "%' OR MiddleName LIKE '%" + txtSearch + "%') " +
                                 "ORDER BY Employees.ID"
        End If

        refreshEmployeeList()
    End Sub
    Private Sub txtSearchSupplier_TextChanged(sender As Object, e As EventArgs) Handles txtSearchSupplier.TextChanged
        Dim txtSearch = txtSearchSupplier.Text.Trim

        If comboSearchSupplier.SelectedIndex.Equals(1) Then
            selectedSearchType = "WHERE (Address LIKE '%" + txtSearch + "%' OR City LIKE '%" + txtSearch + "%' OR Province LIKE '%" + txtSearch + "%') " +
                                 "ORDER BY Suppliers.ID"
        ElseIf comboSearchSupplier.SelectedIndex.Equals(2) Then
            selectedSearchType = "WHERE Company LIKE '%" + txtSearch + "%' " +
                                 "ORDER BY Suppliers.ID"
        ElseIf comboSearchSupplier.SelectedIndex.Equals(3) Then
            selectedSearchType = "WHERE Contact LIKE '%" + txtSearch + "%' " +
                                 "ORDER BY Suppliers.ID"
        ElseIf comboSearchSupplier.SelectedIndex.Equals(4) Then
            selectedSearchType = "WHERE LastName LIKE '%" + txtSearch + "%' OR FirstName LIKE '%" + txtSearch + "%' OR Suffix LIKE '%" + txtSearch + "%' " +
                                 "ORDER BY Suppliers.ID"
        End If

        refreshSupplierList()
    End Sub



    ''  REPORT SECTION  ''
    Private Sub comboSelectedReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboSelectedReport.SelectedIndexChanged
        ''  Conditional statement based on what user desire to generate report
        If comboSelectedReport.SelectedIndex.Equals(1) Then
            comboSearchDay.Enabled = True : comboSearchMonth.Enabled = True : comboSearchYear.Enabled = True
        ElseIf comboSelectedReport.SelectedIndex.Equals(2) Then
            comboSearchDay.Enabled = False : comboSearchMonth.Enabled = True : comboSearchYear.Enabled = True
        ElseIf comboSelectedReport.SelectedIndex.Equals(3) Then
            comboSearchDay.Enabled = False : comboSearchMonth.Enabled = False : comboSearchYear.Enabled = True
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click
        ''  Close recent excel processes from "View Reports" Event triggered
        Call connectionModule.TerminateExcel()

        ''  Restriction upon selections of user
        If comboSelectedReport.SelectedIndex.Equals(0) Then
            MsgBox("Select range/specific report to be generated first")
            Exit Sub

        ElseIf comboSelectedReport.SelectedIndex.Equals(1) Then
            If ((String.IsNullOrEmpty(comboSearchDay.SelectedItem)) Or (String.IsNullOrEmpty(comboSearchMonth.SelectedItem)) Or (String.IsNullOrEmpty(comboSearchYear.SelectedItem))) Then
                MsgBox("Please select specific date you want to generate on 'View Reports' first")
                Exit Sub

            Else
                ''  set specific values of specific date to be search
                Call setSpecificDateValues()

            End If

        ElseIf comboSelectedReport.SelectedIndex.Equals(2) Then
            If ((String.IsNullOrEmpty(comboSearchMonth.SelectedItem)) Or (String.IsNullOrEmpty(comboSearchYear.SelectedItem))) Then
                MsgBox("Please select specific date of month and year you want to generate on 'View Reports' first")
                Exit Sub

            Else
                ''  set specific values of specific date to be search
                Call setSpecificDateValues()

            End If

        ElseIf comboSelectedReport.SelectedIndex.Equals(3) Then
            If (String.IsNullOrEmpty(comboSearchYear.SelectedItem)) Then
                MsgBox("Please select specific date of year you want to generate on 'View Reports' first")
                Exit Sub

            End If
        End If



        ''  Conditional statement based on what user desire to generate report
        If comboSelectedReport.SelectedIndex.Equals(1) Then
            'txtSelectedSearch = "WHERE (CustomerRecord.CSR_DateOfSale BETWEEN '" + txtSpecificDate + "' AND '" + txtSpecificDate + " 23:59:59');"
            txtSelectedSearch = "WHERE (CustomerRecord.CSR_DateOfSale LIKE '%" + txtSpecificDate + "%') ORDER BY CustomerRecord.CSR_Item;"
        ElseIf comboSelectedReport.SelectedIndex.Equals(2) Then
            txtSelectedSearch = "WHERE CustomerRecord.CSR_DateOfSale LIKE '%" + txtSearchDate + "%' ORDER BY CustomerRecord.CSR_Item;"
        ElseIf comboSelectedReport.SelectedIndex.Equals(3) Then
            txtSelectedSearch = "WHERE CustomerRecord.CSR_DateOfSale LIKE '%" + txtSearchYear + "%' ORDER BY CustomerRecord.CSR_Item;"
        Else
            Exit Sub
        End If

        ''''  Declaration for excel report ''''
        ''  Initialize all varaibles to be use and reset to default values
        row = 8

        ''  Base comparation of query values
        queryQty = "" : querySupplier = "" : queryRawPrice = "" : queryTotalRawPrice = "" : querySRP = "" : queryTotalSRP = "" : queryIncome = ""
        queryData = "" : storedData = ""

        ''  Related to supplier and filtered data/s if increase of size of array will be implement
        searchID = 1 : accendSize = 0 : matchField = 0 : ctr = 0

        ''  Force reset/change size of arrays
        ReDim Preserve dataSupplierID(accendSize)
        ReDim Preserve dataSupplierName(accendSize)
        ReDim Preserve dataItem(accendSize)
        ReDim Preserve dataQtySold(matchField)
        ReDim Preserve dataRawPrice(accendSize)
        ReDim Preserve dataTotalRawPrice(matchField)
        ReDim Preserve dataSRP(accendSize)
        ReDim Preserve dataTotalSRP(matchField)
        ReDim Preserve dataIncome(matchField)

        ''  Stored * filter data
        Array.Clear(dataSupplierID, 0, dataSupplierID.Length) : Array.Clear(dataSupplierName, 0, dataSupplierName.Length) : Array.Clear(dataItem, 0, dataItem.Length)
        Array.Clear(dataQtySold, 0, dataQtySold.Length) : Array.Clear(dataRawPrice, 0, dataRawPrice.Length) : Array.Clear(dataTotalRawPrice, 0, dataTotalRawPrice.Length)
        Array.Clear(dataSRP, 0, dataSRP.Length) : Array.Clear(dataTotalSRP, 0, dataTotalSRP.Length) : Array.Clear(dataIncome, 0, dataIncome.Length)


        ''''  Get stored values from arrays to printing of reports ''''
        ''  Loop purposes
        x = 0 : y = 0

        '' Trackdown * the same supplier on their products
        IDValue = 1 : uniqueValue = 0 : traceValue = 0

        ''  Sum * desire values
        totalRaw = "" : totalSRP = "" : totalIncome = ""



        xl = CreateObject("Excel.Application")
        xlwbook = xl.Workbooks.Add(Application.StartupPath & "\ect-excel-format-report.xlsx")
        xlwsheet = xlwbook.Sheets("Sheet2")

        xlwsheet.Cells(2, 7) = "CURRENT DATE: " + Format(Now, "MM-dd-yyyy")
        If comboSelectedReport.SelectedIndex.Equals(1) Then
            xlwsheet.Cells(3, 1) = "DAILY REPORT: " + comboSearchMonth.SelectedItem + "-" + comboSearchDay.SelectedItem + "-" + comboSearchYear.SelectedItem
        ElseIf comboSelectedReport.SelectedIndex.equals(2) Then
            xlwsheet.Cells(3, 1) = "MONTHLY REPORT: " + comboSearchMonth.SelectedItem + "-" + comboSearchYear.SelectedItem
        ElseIf comboSelectedReport.SelectedIndex.equals(3) Then
            xlwsheet.Cells(3, 1) = "ANNUAL REPORT: " + comboSearchYear.SelectedItem
        End If


        Try
            rs = New ADODB.Recordset
            With rs

                If .State <> 0 Then .Close()
                .Open("SELECT Products.*, Suppliers.*, CustomerRecord.* " +
                      "FROM ((Products " +
                      "INNER JOIN Suppliers ON Products.Supplier_ID = Suppliers.ID) " +
                      "INNER JOIN CustomerRecord ON Products.BrandName = CustomerRecord.CSR_Item) " +
                      txtSelectedSearch, cn, 1, 2)

                If .EOF = True Then
                    MsgBox("Requested date of report does not exist")
                    Exit Sub
                End If


                '''''''''''''''''''''''''''''''' OVERALL PROCESSES OF FILTERING DATA/S ''''''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''' DO NOT MODIFY THIS PROCESS/ALGORITHM  ''''''''''''''''''''''''''''''''

                While .EOF = False
                    ''  Get incoming datas
                    searchID = .Fields("Supplier_ID").Value
                    querySupplier = .Fields("Company").Value
                    queryData = .Fields("BrandName").Value
                    queryQty = .Fields("CSR_Qty").Value
                    queryRawPrice = .Fields("RawPrice").Value
                    querySRP = .Fields("SRP").Value
                    queryIncome = Val(querySRP) - Val(queryRawPrice)
                    Console.WriteLine(ctr.ToString + ": " + searchID.ToString + ": " + queryQty.ToString + ": " + queryData.ToString)


                    If queryData = storedData Then
                        ''  Calculates * specific values to compute total value of currency
                        Call calculateTotalValues()

                    Else
                        ''  if not the same with other comparation
                        dataSupplierID(accendSize) = searchID
                        dataSupplierName(accendSize) = querySupplier
                        dataItem(accendSize) = queryData
                        dataRawPrice(accendSize) = queryRawPrice
                        dataSRP(accendSize) = querySRP

                        ''  increase size of array if value not matched on "SINGLE DATA" 
                        accendSize = accendSize + 1
                        storedData = queryData

                        If Not ctr = 0 Then
                            ''  increase size of array if value not matched on "TOTAL DATA" 
                            matchField = matchField + 1
                        End If

                        ''  force increase size of array for new incoming data/s
                        ''  Reinitialize declaration
                        ReDim Preserve dataSupplierID(accendSize)
                        ReDim Preserve dataSupplierName(accendSize)
                        ReDim Preserve dataItem(accendSize)
                        ReDim Preserve dataQtySold(matchField)
                        ReDim Preserve dataRawPrice(accendSize)
                        ReDim Preserve dataSRP(accendSize)
                        ReDim Preserve dataTotalRawPrice(matchField)
                        ReDim Preserve dataTotalSRP(matchField)
                        ReDim Preserve dataIncome(matchField)

                        ''  Calculates * specific values to compute total value of currency
                        Call calculateTotalValues()
                    End If

                    ''  Holds count of looping inside the processes
                    ctr += 1
                    .MoveNext()

                End While
                .Close()

                ''''''''''''''''''''''''''' END OF ACQUIRING DATA/S SAVE FROM THE DATABASE '''''''''''''''''''''''''''


                ''  REPORTS
                ''  Process of generation of print
                While y <= (dataQtySold.Length - 1)
                    If IDValue = dataSupplierID(y) Then
                        traceValue += 1
                    End If

                    y = y + 1
                End While

                While x <= (dataQtySold.Length - 1)
                    'Console.WriteLine(x.ToString + ": " + dataSupplierID(x) + ": " + dataItem(x) + ": " + dataQtySold(x) + ": " + dataRawPrice(x) + ": " + dataTotalRawPrice(x) + ": " + dataSRP(x) + ": " + dataTotalSRP(x) + ": " + dataIncome(x))

                    If Not traceValue = 0 Then
                        If IDValue = dataSupplierID(x) Then

                            If uniqueValue = 0 Then
                                xlwsheet.Cells(row, 1) = dataSupplierName(x)
                                uniqueValue += 1
                            End If

                            xlwsheet.Cells.Range("D" + row.ToString + ":I" + row.ToString).NumberFormat = "₱0.00"

                            xlwsheet.Cells(row, 2) = dataItem(x)
                            xlwsheet.Cells(row, 3) = dataQtySold(x)
                            xlwsheet.Cells(row, 4) = dataRawPrice(x)
                            xlwsheet.Cells(row, 5) = dataTotalRawPrice(x)
                            xlwsheet.Cells(row, 6) = dataSRP(x)
                            xlwsheet.Cells(row, 7) = dataTotalSRP(x)
                            xlwsheet.Cells(row, 8) = dataIncome(x)

                            totalRaw = Format(Val(totalRaw) + Val(dataTotalRawPrice(x)), "0.00")
                            totalSRP = Format(Val(totalSRP) + Val(dataTotalSRP(x)), "0.00")
                            totalIncome = Format(Val(totalIncome) + Val(dataIncome(x)), "0.00")

                            row += 1
                            traceValue -= 1
                        End If
                    End If

                    If traceValue = 0 Then
                        Call printTotalValues()
                    End If

                    x = x + 1
                End While

            End With


            '''''''''''''''''''''''''''''''' PREVIEW OF REPORT AFTER GATHERING OF DATA ''''''''''''''''''''''''''''''''
            xl.Visible = True
            xlwsheet.Protect()
            xlwbook.PrintPreview()
            xlwbook.Close()
            xl.Quit()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Sub setSpecificDateValues()
        txtSearchDay = comboSearchDay.SelectedItem
        txtSearchMonth = comboSearchMonth.SelectedItem
        txtSearchYear = comboSearchYear.SelectedItem

        ''  Will report the date of the day if 'Month' or 'Year' selected on reports
        If comboSelectedReport.SelectedIndex.Equals(1) Then
            txtSelectedSearch = comboSearchMonth.SelectedItem + "/" + txtSearchDay + "/" + txtSearchYear
            txtSpecificDate = txtSearchMonth.ToString + "/" + txtSearchDay.ToString + "/" + txtSearchYear.ToString

        ElseIf comboSelectedReport.SelectedIndex.Equals(2) Then
            txtSelectedSearch = comboSearchMonth.SelectedItem + "-" + txtSearchYear

        End If

        ''  Convert selected abbreviation of "Month" to number
        xdate = txtSelectedSearch
        txtSearchMonth = DatePart("m", xdate)
        txtSpecificDate = txtSearchMonth.ToString + "/" + txtSearchDay.ToString + "/" + txtSearchYear.ToString
        ''  Concatenate and affix '0' string if number of month is one digit
        For i As Integer = 1 To 10
            If (Val(txtSearchMonth) = i) Then
                txtSearchMonth = "0" + txtSearchMonth.ToString
            End If
        Next


        txtSearchDate = txtSearchMonth.ToString + "/_%_%/" + txtSearchYear.ToString
        MsgBox(txtSpecificDate + " " + xdate.ToShortDateString + "_" + txtSearchDate)
    End Sub
    Sub calculateTotalValues()
        ''  Calculates * specific values to compute total value of currency
        queryRawPrice = Format(Val(dataTotalRawPrice(matchField)) + Val(queryRawPrice), "0.00")
        querySRP = Format(Val(dataTotalSRP(matchField)) + Val(querySRP), "0.00")
        queryIncome = Format(Val(dataIncome(matchField)) + Val(queryIncome), "0.00")

        dataQtySold(matchField) += Val(queryQty)
        dataTotalRawPrice(matchField) = queryRawPrice
        dataTotalSRP(matchField) = querySRP
        dataIncome(matchField) = queryIncome

    End Sub
    Sub printTotalValues()
        row += 1
        xlwsheet.Cells(row, 5) = "TOTAL RAW"
        xlwsheet.Cells(row, 7) = "TOTAL SRP"
        xlwsheet.Cells(row, 8) = "TOTAL INCOME"

        row += 1
        xlwsheet.Cells.Range("D" + row.ToString + ":I" + row.ToString).NumberFormat = "₱0.00"
        xlwsheet.Cells(row, 5) = totalRaw
        xlwsheet.Cells(row, 7) = totalSRP
        xlwsheet.Cells(row, 8) = totalIncome

        totalRaw = "" : totalSRP = "" : totalIncome = ""
        row += 1
        IDValue += 1
        y = 0
        uniqueValue = 0

        While y <= (dataQtySold.Length - 1)
            If IDValue = dataSupplierID(y) Then
                traceValue += 1
            End If

            y = y + 1
        End While

        If traceValue = 0 Then
            x = dataQtySold.Length + 1
        Else
            row += 2
            x = -1
        End If
    End Sub
End Class