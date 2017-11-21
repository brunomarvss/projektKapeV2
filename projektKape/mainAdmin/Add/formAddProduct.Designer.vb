<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formAddProduct
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtBrand = New MetroFramework.Controls.MetroTextBox()
        Me.txtGeneric = New MetroFramework.Controls.MetroTextBox()
        Me.txtQty = New MetroFramework.Controls.MetroTextBox()
        Me.txtRawPrice = New MetroFramework.Controls.MetroTextBox()
        Me.txtSRP = New MetroFramework.Controls.MetroTextBox()
        Me.comboSupplierList = New MetroFramework.Controls.MetroComboBox()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.txtReorderQty = New MetroFramework.Controls.MetroTextBox()
        Me.txtReorderLvl = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'txtBrand
        '
        '
        '
        '
        Me.txtBrand.CustomButton.Image = Nothing
        Me.txtBrand.CustomButton.Location = New System.Drawing.Point(267, 2)
        Me.txtBrand.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBrand.CustomButton.Name = ""
        Me.txtBrand.CustomButton.Size = New System.Drawing.Size(43, 43)
        Me.txtBrand.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBrand.CustomButton.TabIndex = 1
        Me.txtBrand.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBrand.CustomButton.UseSelectable = True
        Me.txtBrand.CustomButton.Visible = False
        Me.txtBrand.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtBrand.Lines = New String() {"Brand Name"}
        Me.txtBrand.Location = New System.Drawing.Point(175, 110)
        Me.txtBrand.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBrand.MaxLength = 32767
        Me.txtBrand.Multiline = True
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBrand.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBrand.SelectedText = ""
        Me.txtBrand.SelectionLength = 0
        Me.txtBrand.SelectionStart = 0
        Me.txtBrand.ShortcutsEnabled = True
        Me.txtBrand.Size = New System.Drawing.Size(313, 48)
        Me.txtBrand.TabIndex = 0
        Me.txtBrand.Text = "Brand Name"
        Me.txtBrand.UseSelectable = True
        Me.txtBrand.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBrand.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtGeneric
        '
        '
        '
        '
        Me.txtGeneric.CustomButton.Image = Nothing
        Me.txtGeneric.CustomButton.Location = New System.Drawing.Point(267, 2)
        Me.txtGeneric.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGeneric.CustomButton.Name = ""
        Me.txtGeneric.CustomButton.Size = New System.Drawing.Size(43, 43)
        Me.txtGeneric.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtGeneric.CustomButton.TabIndex = 1
        Me.txtGeneric.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtGeneric.CustomButton.UseSelectable = True
        Me.txtGeneric.CustomButton.Visible = False
        Me.txtGeneric.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtGeneric.Lines = New String() {"Generic Name"}
        Me.txtGeneric.Location = New System.Drawing.Point(175, 191)
        Me.txtGeneric.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGeneric.MaxLength = 32767
        Me.txtGeneric.Multiline = True
        Me.txtGeneric.Name = "txtGeneric"
        Me.txtGeneric.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGeneric.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtGeneric.SelectedText = ""
        Me.txtGeneric.SelectionLength = 0
        Me.txtGeneric.SelectionStart = 0
        Me.txtGeneric.ShortcutsEnabled = True
        Me.txtGeneric.Size = New System.Drawing.Size(313, 48)
        Me.txtGeneric.TabIndex = 1
        Me.txtGeneric.Text = "Generic Name"
        Me.txtGeneric.UseSelectable = True
        Me.txtGeneric.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtGeneric.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtQty
        '
        '
        '
        '
        Me.txtQty.CustomButton.Image = Nothing
        Me.txtQty.CustomButton.Location = New System.Drawing.Point(267, 2)
        Me.txtQty.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQty.CustomButton.Name = ""
        Me.txtQty.CustomButton.Size = New System.Drawing.Size(43, 43)
        Me.txtQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtQty.CustomButton.TabIndex = 1
        Me.txtQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtQty.CustomButton.UseSelectable = True
        Me.txtQty.CustomButton.Visible = False
        Me.txtQty.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtQty.Lines = New String() {"Quantity"}
        Me.txtQty.Location = New System.Drawing.Point(353, 402)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQty.MaxLength = 32767
        Me.txtQty.Multiline = True
        Me.txtQty.Name = "txtQty"
        Me.txtQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtQty.SelectedText = ""
        Me.txtQty.SelectionLength = 0
        Me.txtQty.SelectionStart = 0
        Me.txtQty.ShortcutsEnabled = True
        Me.txtQty.Size = New System.Drawing.Size(313, 48)
        Me.txtQty.TabIndex = 6
        Me.txtQty.Text = "Quantity"
        Me.txtQty.UseSelectable = True
        Me.txtQty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtQty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtRawPrice
        '
        '
        '
        '
        Me.txtRawPrice.CustomButton.Image = Nothing
        Me.txtRawPrice.CustomButton.Location = New System.Drawing.Point(267, 2)
        Me.txtRawPrice.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRawPrice.CustomButton.Name = ""
        Me.txtRawPrice.CustomButton.Size = New System.Drawing.Size(43, 43)
        Me.txtRawPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRawPrice.CustomButton.TabIndex = 1
        Me.txtRawPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRawPrice.CustomButton.UseSelectable = True
        Me.txtRawPrice.CustomButton.Visible = False
        Me.txtRawPrice.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtRawPrice.Lines = New String() {"Raw Price"}
        Me.txtRawPrice.Location = New System.Drawing.Point(654, 182)
        Me.txtRawPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRawPrice.MaxLength = 32767
        Me.txtRawPrice.Multiline = True
        Me.txtRawPrice.Name = "txtRawPrice"
        Me.txtRawPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRawPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRawPrice.SelectedText = ""
        Me.txtRawPrice.SelectionLength = 0
        Me.txtRawPrice.SelectionStart = 0
        Me.txtRawPrice.ShortcutsEnabled = True
        Me.txtRawPrice.Size = New System.Drawing.Size(313, 48)
        Me.txtRawPrice.TabIndex = 4
        Me.txtRawPrice.Text = "Raw Price"
        Me.txtRawPrice.UseSelectable = True
        Me.txtRawPrice.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRawPrice.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSRP
        '
        '
        '
        '
        Me.txtSRP.CustomButton.Image = Nothing
        Me.txtSRP.CustomButton.Location = New System.Drawing.Point(267, 2)
        Me.txtSRP.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSRP.CustomButton.Name = ""
        Me.txtSRP.CustomButton.Size = New System.Drawing.Size(43, 43)
        Me.txtSRP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSRP.CustomButton.TabIndex = 1
        Me.txtSRP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSRP.CustomButton.UseSelectable = True
        Me.txtSRP.CustomButton.Visible = False
        Me.txtSRP.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtSRP.Lines = New String() {"SRP"}
        Me.txtSRP.Location = New System.Drawing.Point(654, 256)
        Me.txtSRP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSRP.MaxLength = 32767
        Me.txtSRP.Multiline = True
        Me.txtSRP.Name = "txtSRP"
        Me.txtSRP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSRP.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSRP.SelectedText = ""
        Me.txtSRP.SelectionLength = 0
        Me.txtSRP.SelectionStart = 0
        Me.txtSRP.ShortcutsEnabled = True
        Me.txtSRP.Size = New System.Drawing.Size(313, 48)
        Me.txtSRP.TabIndex = 5
        Me.txtSRP.Text = "SRP"
        Me.txtSRP.UseSelectable = True
        Me.txtSRP.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSRP.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'comboSupplierList
        '
        Me.comboSupplierList.FormattingEnabled = True
        Me.comboSupplierList.ItemHeight = 24
        Me.comboSupplierList.Items.AddRange(New Object() {"(Select One Supplier)", "1", "2"})
        Me.comboSupplierList.Location = New System.Drawing.Point(654, 110)
        Me.comboSupplierList.Margin = New System.Windows.Forms.Padding(4)
        Me.comboSupplierList.Name = "comboSupplierList"
        Me.comboSupplierList.Size = New System.Drawing.Size(312, 30)
        Me.comboSupplierList.TabIndex = 3
        Me.comboSupplierList.UseSelectable = True
        '
        'btnSave
        '
        Me.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnSave.Location = New System.Drawing.Point(353, 605)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(232, 59)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel7.Location = New System.Drawing.Point(512, 160)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(80, 25)
        Me.MetroLabel7.TabIndex = 19
        Me.MetroLabel7.Text = "Pricing:"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel8.Location = New System.Drawing.Point(30, 74)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(170, 25)
        Me.MetroLabel8.TabIndex = 20
        Me.MetroLabel8.Text = "Item Information:"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel9.Location = New System.Drawing.Point(512, 81)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(93, 25)
        Me.MetroLabel9.TabIndex = 20
        Me.MetroLabel9.Text = "Supplier:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.Location = New System.Drawing.Point(619, 261)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(24, 25)
        Me.MetroLabel2.TabIndex = 22
        Me.MetroLabel2.Text = "₱"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(619, 187)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(24, 25)
        Me.MetroLabel1.TabIndex = 23
        Me.MetroLabel1.Text = "₱"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(18, 48)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(543, 20)
        Me.MetroLabel3.TabIndex = 24
        Me.MetroLabel3.Text = "_________________________________________________________________________________" &
    "________"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(43, 123)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(121, 25)
        Me.MetroLabel4.TabIndex = 25
        Me.MetroLabel4.Text = "Brand Name:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(28, 191)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(136, 25)
        Me.MetroLabel5.TabIndex = 26
        Me.MetroLabel5.Text = "Generic Name:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel6.Location = New System.Drawing.Point(254, 402)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(88, 25)
        Me.MetroLabel6.TabIndex = 27
        Me.MetroLabel6.Text = "Quantity:"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel10.Location = New System.Drawing.Point(517, 187)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(98, 25)
        Me.MetroLabel10.TabIndex = 28
        Me.MetroLabel10.Text = "Raw Price:"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel11.Location = New System.Drawing.Point(506, 256)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(109, 50)
        Me.MetroLabel11.TabIndex = 29
        Me.MetroLabel11.Text = "Suggested " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Retail Price:"
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel13.Location = New System.Drawing.Point(183, 514)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(159, 25)
        Me.MetroLabel13.TabIndex = 35
        Me.MetroLabel13.Text = "Reorder Quantity:"
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel14.Location = New System.Drawing.Point(212, 458)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(130, 25)
        Me.MetroLabel14.TabIndex = 34
        Me.MetroLabel14.Text = "Reorder Level:"
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel15.Location = New System.Drawing.Point(208, 344)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(182, 25)
        Me.MetroLabel15.TabIndex = 33
        Me.MetroLabel15.Text = "Inventory Settings:"
        '
        'txtReorderQty
        '
        '
        '
        '
        Me.txtReorderQty.CustomButton.Image = Nothing
        Me.txtReorderQty.CustomButton.Location = New System.Drawing.Point(267, 2)
        Me.txtReorderQty.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReorderQty.CustomButton.Name = ""
        Me.txtReorderQty.CustomButton.Size = New System.Drawing.Size(43, 43)
        Me.txtReorderQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtReorderQty.CustomButton.TabIndex = 1
        Me.txtReorderQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtReorderQty.CustomButton.UseSelectable = True
        Me.txtReorderQty.CustomButton.Visible = False
        Me.txtReorderQty.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtReorderQty.Lines = New String() {"Generic Name"}
        Me.txtReorderQty.Location = New System.Drawing.Point(353, 514)
        Me.txtReorderQty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReorderQty.MaxLength = 32767
        Me.txtReorderQty.Multiline = True
        Me.txtReorderQty.Name = "txtReorderQty"
        Me.txtReorderQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReorderQty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtReorderQty.SelectedText = ""
        Me.txtReorderQty.SelectionLength = 0
        Me.txtReorderQty.SelectionStart = 0
        Me.txtReorderQty.ShortcutsEnabled = True
        Me.txtReorderQty.Size = New System.Drawing.Size(313, 48)
        Me.txtReorderQty.TabIndex = 8
        Me.txtReorderQty.Text = "Generic Name"
        Me.txtReorderQty.UseSelectable = True
        Me.txtReorderQty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtReorderQty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtReorderLvl
        '
        '
        '
        '
        Me.txtReorderLvl.CustomButton.Image = Nothing
        Me.txtReorderLvl.CustomButton.Location = New System.Drawing.Point(267, 2)
        Me.txtReorderLvl.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReorderLvl.CustomButton.Name = ""
        Me.txtReorderLvl.CustomButton.Size = New System.Drawing.Size(43, 43)
        Me.txtReorderLvl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtReorderLvl.CustomButton.TabIndex = 1
        Me.txtReorderLvl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtReorderLvl.CustomButton.UseSelectable = True
        Me.txtReorderLvl.CustomButton.Visible = False
        Me.txtReorderLvl.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtReorderLvl.Lines = New String() {"Brand Name"}
        Me.txtReorderLvl.Location = New System.Drawing.Point(353, 458)
        Me.txtReorderLvl.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReorderLvl.MaxLength = 32767
        Me.txtReorderLvl.Multiline = True
        Me.txtReorderLvl.Name = "txtReorderLvl"
        Me.txtReorderLvl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReorderLvl.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtReorderLvl.SelectedText = ""
        Me.txtReorderLvl.SelectionLength = 0
        Me.txtReorderLvl.SelectionStart = 0
        Me.txtReorderLvl.ShortcutsEnabled = True
        Me.txtReorderLvl.Size = New System.Drawing.Size(313, 48)
        Me.txtReorderLvl.TabIndex = 7
        Me.txtReorderLvl.Text = "Brand Name"
        Me.txtReorderLvl.UseSelectable = True
        Me.txtReorderLvl.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtReorderLvl.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'formAddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 678)
        Me.Controls.Add(Me.MetroLabel13)
        Me.Controls.Add(Me.MetroLabel14)
        Me.Controls.Add(Me.MetroLabel15)
        Me.Controls.Add(Me.txtReorderQty)
        Me.Controls.Add(Me.txtReorderLvl)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.comboSupplierList)
        Me.Controls.Add(Me.txtSRP)
        Me.Controls.Add(Me.txtRawPrice)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtGeneric)
        Me.Controls.Add(Me.txtBrand)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "formAddProduct"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Text = "Add Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBrand As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtGeneric As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtQty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtRawPrice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSRP As MetroFramework.Controls.MetroTextBox
    Friend WithEvents comboSupplierList As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtReorderQty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtReorderLvl As MetroFramework.Controls.MetroTextBox
End Class
