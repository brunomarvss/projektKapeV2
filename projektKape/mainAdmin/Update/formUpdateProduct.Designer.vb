﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formUpdateProduct
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
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtSupplier = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'txtBrand
        '
        '
        '
        '
        Me.txtBrand.CustomButton.Image = Nothing
        Me.txtBrand.CustomButton.Location = New System.Drawing.Point(197, 1)
        Me.txtBrand.CustomButton.Name = ""
        Me.txtBrand.CustomButton.Size = New System.Drawing.Size(37, 37)
        Me.txtBrand.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBrand.CustomButton.TabIndex = 1
        Me.txtBrand.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBrand.CustomButton.UseSelectable = True
        Me.txtBrand.CustomButton.Visible = False
        Me.txtBrand.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtBrand.Lines = New String() {"Brand Name"}
        Me.txtBrand.Location = New System.Drawing.Point(176, 89)
        Me.txtBrand.MaxLength = 32767
        Me.txtBrand.Multiline = True
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBrand.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBrand.SelectedText = ""
        Me.txtBrand.SelectionLength = 0
        Me.txtBrand.SelectionStart = 0
        Me.txtBrand.ShortcutsEnabled = True
        Me.txtBrand.Size = New System.Drawing.Size(235, 39)
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
        Me.txtGeneric.CustomButton.Location = New System.Drawing.Point(197, 1)
        Me.txtGeneric.CustomButton.Name = ""
        Me.txtGeneric.CustomButton.Size = New System.Drawing.Size(37, 37)
        Me.txtGeneric.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtGeneric.CustomButton.TabIndex = 1
        Me.txtGeneric.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtGeneric.CustomButton.UseSelectable = True
        Me.txtGeneric.CustomButton.Visible = False
        Me.txtGeneric.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtGeneric.Lines = New String() {"Generic Name"}
        Me.txtGeneric.Location = New System.Drawing.Point(176, 155)
        Me.txtGeneric.MaxLength = 32767
        Me.txtGeneric.Multiline = True
        Me.txtGeneric.Name = "txtGeneric"
        Me.txtGeneric.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGeneric.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtGeneric.SelectedText = ""
        Me.txtGeneric.SelectionLength = 0
        Me.txtGeneric.SelectionStart = 0
        Me.txtGeneric.ShortcutsEnabled = True
        Me.txtGeneric.Size = New System.Drawing.Size(235, 39)
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
        Me.txtQty.CustomButton.Location = New System.Drawing.Point(197, 1)
        Me.txtQty.CustomButton.Name = ""
        Me.txtQty.CustomButton.Size = New System.Drawing.Size(37, 37)
        Me.txtQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtQty.CustomButton.TabIndex = 1
        Me.txtQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtQty.CustomButton.UseSelectable = True
        Me.txtQty.CustomButton.Visible = False
        Me.txtQty.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtQty.Lines = New String() {"Quantity"}
        Me.txtQty.Location = New System.Drawing.Point(176, 216)
        Me.txtQty.MaxLength = 32767
        Me.txtQty.Multiline = True
        Me.txtQty.Name = "txtQty"
        Me.txtQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtQty.SelectedText = ""
        Me.txtQty.SelectionLength = 0
        Me.txtQty.SelectionStart = 0
        Me.txtQty.ShortcutsEnabled = True
        Me.txtQty.Size = New System.Drawing.Size(235, 39)
        Me.txtQty.TabIndex = 2
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
        Me.txtRawPrice.CustomButton.Location = New System.Drawing.Point(197, 1)
        Me.txtRawPrice.CustomButton.Name = ""
        Me.txtRawPrice.CustomButton.Size = New System.Drawing.Size(37, 37)
        Me.txtRawPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRawPrice.CustomButton.TabIndex = 1
        Me.txtRawPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRawPrice.CustomButton.UseSelectable = True
        Me.txtRawPrice.CustomButton.Visible = False
        Me.txtRawPrice.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtRawPrice.Lines = New String() {"Raw Price"}
        Me.txtRawPrice.Location = New System.Drawing.Point(176, 346)
        Me.txtRawPrice.MaxLength = 32767
        Me.txtRawPrice.Multiline = True
        Me.txtRawPrice.Name = "txtRawPrice"
        Me.txtRawPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRawPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRawPrice.SelectedText = ""
        Me.txtRawPrice.SelectionLength = 0
        Me.txtRawPrice.SelectionStart = 0
        Me.txtRawPrice.ShortcutsEnabled = True
        Me.txtRawPrice.Size = New System.Drawing.Size(235, 39)
        Me.txtRawPrice.TabIndex = 5
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
        Me.txtSRP.CustomButton.Location = New System.Drawing.Point(197, 1)
        Me.txtSRP.CustomButton.Name = ""
        Me.txtSRP.CustomButton.Size = New System.Drawing.Size(37, 37)
        Me.txtSRP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSRP.CustomButton.TabIndex = 1
        Me.txtSRP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSRP.CustomButton.UseSelectable = True
        Me.txtSRP.CustomButton.Visible = False
        Me.txtSRP.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtSRP.Lines = New String() {"SRP"}
        Me.txtSRP.Location = New System.Drawing.Point(176, 406)
        Me.txtSRP.MaxLength = 32767
        Me.txtSRP.Multiline = True
        Me.txtSRP.Name = "txtSRP"
        Me.txtSRP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSRP.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSRP.SelectedText = ""
        Me.txtSRP.SelectionLength = 0
        Me.txtSRP.SelectionStart = 0
        Me.txtSRP.ShortcutsEnabled = True
        Me.txtSRP.Size = New System.Drawing.Size(235, 39)
        Me.txtSRP.TabIndex = 6
        Me.txtSRP.Text = "SRP"
        Me.txtSRP.UseSelectable = True
        Me.txtSRP.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSRP.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnSave
        '
        Me.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnSave.Location = New System.Drawing.Point(135, 480)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(174, 48)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel7.Location = New System.Drawing.Point(8, 346)
        Me.MetroLabel7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(76, 25)
        Me.MetroLabel7.TabIndex = 19
        Me.MetroLabel7.Text = "Pricing:"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel8.Location = New System.Drawing.Point(8, 89)
        Me.MetroLabel8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(163, 25)
        Me.MetroLabel8.TabIndex = 20
        Me.MetroLabel8.Text = "Item Information:"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel9.Location = New System.Drawing.Point(8, 282)
        Me.MetroLabel9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(88, 25)
        Me.MetroLabel9.TabIndex = 20
        Me.MetroLabel9.Text = "Supplier:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.Location = New System.Drawing.Point(150, 410)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
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
        Me.MetroLabel1.Location = New System.Drawing.Point(150, 350)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(24, 25)
        Me.MetroLabel1.TabIndex = 23
        Me.MetroLabel1.Text = "₱"
        '
        'txtSupplier
        '
        '
        '
        '
        Me.txtSupplier.CustomButton.Image = Nothing
        Me.txtSupplier.CustomButton.Location = New System.Drawing.Point(197, 1)
        Me.txtSupplier.CustomButton.Name = ""
        Me.txtSupplier.CustomButton.Size = New System.Drawing.Size(37, 37)
        Me.txtSupplier.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSupplier.CustomButton.TabIndex = 1
        Me.txtSupplier.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSupplier.CustomButton.UseSelectable = True
        Me.txtSupplier.CustomButton.Visible = False
        Me.txtSupplier.Enabled = False
        Me.txtSupplier.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtSupplier.Lines = New String() {"Supplier"}
        Me.txtSupplier.Location = New System.Drawing.Point(176, 282)
        Me.txtSupplier.MaxLength = 32767
        Me.txtSupplier.Multiline = True
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSupplier.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSupplier.SelectedText = ""
        Me.txtSupplier.SelectionLength = 0
        Me.txtSupplier.SelectionStart = 0
        Me.txtSupplier.ShortcutsEnabled = True
        Me.txtSupplier.Size = New System.Drawing.Size(235, 39)
        Me.txtSupplier.TabIndex = 24
        Me.txtSupplier.Text = "Supplier"
        Me.txtSupplier.UseSelectable = True
        Me.txtSupplier.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSupplier.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'formUpdateProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 551)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtSRP)
        Me.Controls.Add(Me.txtRawPrice)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtGeneric)
        Me.Controls.Add(Me.txtBrand)
        Me.Name = "formUpdateProduct"
        Me.Text = "Add Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBrand As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtGeneric As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtQty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtRawPrice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSRP As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtSupplier As MetroFramework.Controls.MetroTextBox
End Class
