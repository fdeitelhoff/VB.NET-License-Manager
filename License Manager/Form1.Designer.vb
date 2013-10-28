<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.BtnCreateKeys = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpExpiration = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbxLicenseType = New System.Windows.Forms.ComboBox()
        Me.BtnCreateLic = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAttributeValue = New System.Windows.Forms.TextBox()
        Me.txtAttributeName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUsers = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkbilling = New System.Windows.Forms.CheckBox()
        Me.chksales = New System.Windows.Forms.CheckBox()
        Me.txtEMail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtLicenseTypeRO = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnOpenLic = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAttributeValueRO = New System.Windows.Forms.TextBox()
        Me.txtAttributeNameRO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUsersRO = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkBillingRO = New System.Windows.Forms.CheckBox()
        Me.chkSalesRO = New System.Windows.Forms.CheckBox()
        Me.txtEMailRO = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCustomerRO = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbxValidation = New System.Windows.Forms.ListBox()
        Me.SfDLicense = New System.Windows.Forms.SaveFileDialog()
        Me.OfDLicense = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtKey)
        Me.GroupBox1.Controls.Add(Me.BtnCreateKeys)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtpassword)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Key Management"
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(69, 45)
        Me.txtKey.Multiline = True
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(458, 68)
        Me.txtKey.TabIndex = 3
        '
        'BtnCreateKeys
        '
        Me.BtnCreateKeys.Location = New System.Drawing.Point(533, 19)
        Me.BtnCreateKeys.Name = "BtnCreateKeys"
        Me.BtnCreateKeys.Size = New System.Drawing.Size(124, 92)
        Me.BtnCreateKeys.TabIndex = 2
        Me.BtnCreateKeys.Text = "Create Keys"
        Me.BtnCreateKeys.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Password:"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(69, 19)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(458, 20)
        Me.txtpassword.TabIndex = 0
        Me.txtpassword.Text = "test"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.dtpExpiration)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cbxLicenseType)
        Me.GroupBox2.Controls.Add(Me.BtnCreateLic)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtAttributeValue)
        Me.GroupBox2.Controls.Add(Me.txtAttributeName)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtUsers)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.chkbilling)
        Me.GroupBox2.Controls.Add(Me.chksales)
        Me.GroupBox2.Controls.Add(Me.txtEMail)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtCustomer)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(664, 189)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "License Details"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(266, 102)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Expires at:"
        '
        'dtpExpiration
        '
        Me.dtpExpiration.Location = New System.Drawing.Point(328, 101)
        Me.dtpExpiration.Name = "dtpExpiration"
        Me.dtpExpiration.Size = New System.Drawing.Size(200, 20)
        Me.dtpExpiration.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(248, 79)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "License Type:"
        '
        'cbxLicenseType
        '
        Me.cbxLicenseType.FormattingEnabled = True
        Me.cbxLicenseType.Items.AddRange(New Object() {"Trial", "Standard"})
        Me.cbxLicenseType.Location = New System.Drawing.Point(329, 74)
        Me.cbxLicenseType.Name = "cbxLicenseType"
        Me.cbxLicenseType.Size = New System.Drawing.Size(199, 21)
        Me.cbxLicenseType.TabIndex = 12
        Me.cbxLicenseType.Text = "Trial"
        '
        'BtnCreateLic
        '
        Me.BtnCreateLic.Enabled = False
        Me.BtnCreateLic.Location = New System.Drawing.Point(533, 19)
        Me.BtnCreateLic.Name = "BtnCreateLic"
        Me.BtnCreateLic.Size = New System.Drawing.Size(124, 160)
        Me.BtnCreateLic.TabIndex = 3
        Me.BtnCreateLic.Text = "Create License"
        Me.BtnCreateLic.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(285, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Attribute Value:"
        '
        'txtAttributeValue
        '
        Me.txtAttributeValue.Location = New System.Drawing.Point(370, 157)
        Me.txtAttributeValue.Name = "txtAttributeValue"
        Me.txtAttributeValue.Size = New System.Drawing.Size(157, 20)
        Me.txtAttributeValue.TabIndex = 10
        Me.txtAttributeValue.Text = "VS2012"
        '
        'txtAttributeName
        '
        Me.txtAttributeName.Location = New System.Drawing.Point(96, 157)
        Me.txtAttributeName.Name = "txtAttributeName"
        Me.txtAttributeName.Size = New System.Drawing.Size(157, 20)
        Me.txtAttributeName.TabIndex = 9
        Me.txtAttributeName.Text = "Software"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Attribute Name:"
        '
        'txtUsers
        '
        Me.txtUsers.Location = New System.Drawing.Point(69, 127)
        Me.txtUsers.Name = "txtUsers"
        Me.txtUsers.Size = New System.Drawing.Size(458, 20)
        Me.txtUsers.TabIndex = 7
        Me.txtUsers.Text = "10"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Max Users:"
        '
        'chkbilling
        '
        Me.chkbilling.AutoSize = True
        Me.chkbilling.Location = New System.Drawing.Point(69, 98)
        Me.chkbilling.Name = "chkbilling"
        Me.chkbilling.Size = New System.Drawing.Size(53, 17)
        Me.chkbilling.TabIndex = 5
        Me.chkbilling.Text = "Billing"
        Me.chkbilling.UseVisualStyleBackColor = True
        '
        'chksales
        '
        Me.chksales.AutoSize = True
        Me.chksales.Checked = True
        Me.chksales.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chksales.Location = New System.Drawing.Point(69, 75)
        Me.chksales.Name = "chksales"
        Me.chksales.Size = New System.Drawing.Size(52, 17)
        Me.chksales.TabIndex = 4
        Me.chksales.Text = "Sales"
        Me.chksales.UseVisualStyleBackColor = True
        '
        'txtEMail
        '
        Me.txtEMail.Location = New System.Drawing.Point(69, 48)
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.Size = New System.Drawing.Size(458, 20)
        Me.txtEMail.TabIndex = 3
        Me.txtEMail.Text = "weiss.thorsten@gmx.de"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "E-Mail:"
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(70, 20)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(458, 20)
        Me.txtCustomer.TabIndex = 1
        Me.txtCustomer.Text = "Thorsten Weiss"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Customer:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtLicenseTypeRO)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.BtnOpenLic)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtAttributeValueRO)
        Me.GroupBox4.Controls.Add(Me.txtAttributeNameRO)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtUsersRO)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.chkBillingRO)
        Me.GroupBox4.Controls.Add(Me.chkSalesRO)
        Me.GroupBox4.Controls.Add(Me.txtEMailRO)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtCustomerRO)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 332)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(664, 185)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "License Details"
        '
        'txtLicenseTypeRO
        '
        Me.txtLicenseTypeRO.Location = New System.Drawing.Point(407, 75)
        Me.txtLicenseTypeRO.Name = "txtLicenseTypeRO"
        Me.txtLicenseTypeRO.Size = New System.Drawing.Size(120, 20)
        Me.txtLicenseTypeRO.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(326, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "License Type:"
        '
        'BtnOpenLic
        '
        Me.BtnOpenLic.Enabled = False
        Me.BtnOpenLic.Location = New System.Drawing.Point(533, 19)
        Me.BtnOpenLic.Name = "BtnOpenLic"
        Me.BtnOpenLic.Size = New System.Drawing.Size(124, 160)
        Me.BtnOpenLic.TabIndex = 3
        Me.BtnOpenLic.Text = "Open License"
        Me.BtnOpenLic.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(285, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Attribute Value:"
        '
        'txtAttributeValueRO
        '
        Me.txtAttributeValueRO.Location = New System.Drawing.Point(370, 151)
        Me.txtAttributeValueRO.Name = "txtAttributeValueRO"
        Me.txtAttributeValueRO.Size = New System.Drawing.Size(157, 20)
        Me.txtAttributeValueRO.TabIndex = 10
        '
        'txtAttributeNameRO
        '
        Me.txtAttributeNameRO.Location = New System.Drawing.Point(96, 151)
        Me.txtAttributeNameRO.Name = "txtAttributeNameRO"
        Me.txtAttributeNameRO.Size = New System.Drawing.Size(157, 20)
        Me.txtAttributeNameRO.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Attribute Name:"
        '
        'txtUsersRO
        '
        Me.txtUsersRO.Location = New System.Drawing.Point(69, 121)
        Me.txtUsersRO.Name = "txtUsersRO"
        Me.txtUsersRO.Size = New System.Drawing.Size(458, 20)
        Me.txtUsersRO.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Max Users:"
        '
        'chkBillingRO
        '
        Me.chkBillingRO.AutoSize = True
        Me.chkBillingRO.Enabled = False
        Me.chkBillingRO.Location = New System.Drawing.Point(69, 98)
        Me.chkBillingRO.Name = "chkBillingRO"
        Me.chkBillingRO.Size = New System.Drawing.Size(53, 17)
        Me.chkBillingRO.TabIndex = 5
        Me.chkBillingRO.Text = "Billing"
        Me.chkBillingRO.UseVisualStyleBackColor = True
        '
        'chkSalesRO
        '
        Me.chkSalesRO.AutoSize = True
        Me.chkSalesRO.Enabled = False
        Me.chkSalesRO.Location = New System.Drawing.Point(69, 75)
        Me.chkSalesRO.Name = "chkSalesRO"
        Me.chkSalesRO.Size = New System.Drawing.Size(52, 17)
        Me.chkSalesRO.TabIndex = 4
        Me.chkSalesRO.Text = "Sales"
        Me.chkSalesRO.UseVisualStyleBackColor = True
        '
        'txtEMailRO
        '
        Me.txtEMailRO.Location = New System.Drawing.Point(69, 48)
        Me.txtEMailRO.Name = "txtEMailRO"
        Me.txtEMailRO.Size = New System.Drawing.Size(458, 20)
        Me.txtEMailRO.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "E-Mail:"
        '
        'txtCustomerRO
        '
        Me.txtCustomerRO.Location = New System.Drawing.Point(70, 20)
        Me.txtCustomerRO.Name = "txtCustomerRO"
        Me.txtCustomerRO.Size = New System.Drawing.Size(458, 20)
        Me.txtCustomerRO.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Customer:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbxValidation)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 523)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(664, 124)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Validation Messages"
        '
        'lbxValidation
        '
        Me.lbxValidation.FormattingEnabled = True
        Me.lbxValidation.Location = New System.Drawing.Point(6, 19)
        Me.lbxValidation.Name = "lbxValidation"
        Me.lbxValidation.Size = New System.Drawing.Size(652, 95)
        Me.lbxValidation.TabIndex = 0
        '
        'SfDLicense
        '
        Me.SfDLicense.FileName = "License.lic"
        Me.SfDLicense.Filter = """License|*.lic"""
        '
        'OfDLicense
        '
        Me.OfDLicense.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 656)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Portable.License Demo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCreateKeys As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCreateLic As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAttributeValue As System.Windows.Forms.TextBox
    Friend WithEvents txtAttributeName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUsers As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkbilling As System.Windows.Forms.CheckBox
    Friend WithEvents chksales As System.Windows.Forms.CheckBox
    Friend WithEvents txtEMail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnOpenLic As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAttributeValueRO As System.Windows.Forms.TextBox
    Friend WithEvents txtAttributeNameRO As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtUsersRO As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkBillingRO As System.Windows.Forms.CheckBox
    Friend WithEvents chkSalesRO As System.Windows.Forms.CheckBox
    Friend WithEvents txtEMailRO As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerRO As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbxValidation As System.Windows.Forms.ListBox
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbxLicenseType As System.Windows.Forms.ComboBox
    Friend WithEvents txtLicenseTypeRO As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpExpiration As System.Windows.Forms.DateTimePicker
    Friend WithEvents SfDLicense As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OfDLicense As System.Windows.Forms.OpenFileDialog

End Class
