Imports System.ComponentModel
Imports Portable.Licensing
Imports System
Imports System.IO
Imports System.Text
Imports Portable.Licensing.Validation


''' Copyright © 2013 Thorsten Weiß     
'''
''' Author:
'''  Thorsten Weiss        weiss.thorsten@gmx.de
'''
''' Permission is hereby granted, free of charge, to any person obtaining
''' a copy of this software and associated documentation files (the
''' "Software"), to deal in the Software without restriction, including
''' without limitation the rights to use, copy, modify, merge, publish,
''' distribute, sublicense, and/or sell copies of the Software, and to
''' permit persons to whom the Software is furnished to do so, subject to
''' the following conditions:
''' 
''' The above copyright notice and this permission notice shall be
''' included in all copies or substantial portions of the Software.
''' 
''' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
''' EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
''' MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
''' NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
''' LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
''' OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
''' WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


Public Class Form1

    ''' <summary>
    '''  This class performs the main function.
    '''
    '''
    '''  First definie the variables
    ''' </summary>

    Private ULicense As Portable.Licensing.License

    Private PrivateKey As String
    Private PublicKey As String

    ''' <summary>
    ''' 
    '''  Set default values 
    ''' </summary>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'dtpExpiration.MinDate = DateTime.Now.AddDays(1)

    End Sub

    ''' <summary>
    '''  1. define a KeyGenerator and a KeyPair
    ''' 
    '''  2. split the KeyPair into the private key (encoded with the password) and public key 
    ''' </summary>
    Private Sub BtnCreateKeys_Click(sender As Object, e As EventArgs) Handles BtnCreateKeys.Click

        Dim KeyGenerator = Portable.Licensing.Security.Cryptography.KeyGenerator.Create
        Dim KeyPair = KeyGenerator.GenerateKeyPair

        PrivateKey = KeyPair.ToEncryptedPrivateKeyString(txtpassword.Text.Trim)
        PublicKey = KeyPair.ToPublicKeyString

        BtnCreateLic.Enabled = True

    End Sub


    ''' <summary>
    '''  1. define a new Dictionary for the addition attributes and add the attributes
    '''  
    '''  2. define a new Dictionary for the product features and add the features
    ''' 
    '''  3. create new guid as unique identifier
    ''' 
    '''  4. define the license with the required parameters
    ''' 
    '''  5. select Path and filename to write the license
    ''' </summary>
    Private Sub BtnCreateLic_Click(sender As Object, e As EventArgs) Handles BtnCreateLic.Click

        Dim AttributesDictionarty As New Dictionary(Of String, String)
        AttributesDictionarty.Add(txtAttributeName.Text, txtAttributeValue.Text)

        Dim ProductFeatureDictionarty As New Dictionary(Of String, String)
        ProductFeatureDictionarty.Add("Sales", chksales.Checked.ToString)
        ProductFeatureDictionarty.Add("Billing", chkbilling.Checked.ToString)

        Dim licenseId As Guid = Guid.NewGuid

        Dim Ulicense As Portable.Licensing.License = Portable.Licensing.License.[New].WithUniqueIdentifier(licenseId).As(GetLicenseType).WithMaximumUtilization(10).WithAdditionalAttributes(AttributesDictionarty).WithProductFeatures(ProductFeatureDictionarty).LicensedTo(txtCustomer.Text, txtEMail.Text).ExpiresAt(CDate(dtpExpiration.Text)).CreateAndSignWithPrivateKey(PrivateKey, txtpassword.Text)

        Dim SfDLicense As New SaveFileDialog()

        SfDLicense.Filter = "License (*.lic)|*.lic"
        SfDLicense.FilterIndex = 1
        SfDLicense.RestoreDirectory = True
        If SfDLicense.ShowDialog() = DialogResult.OK Then
            File.WriteAllText(SfDLicense.FileName, Ulicense.ToString, Encoding.UTF8)
        End If

        BtnOpenLic.Enabled = True

    End Sub


    ''' <summary>
    '''  1. clear validation textbox
    '''  
    '''  2. define a new stream and select and read the license
    ''' 
    '''  3. read the values from the license
    ''' 
    '''  4. validate the license (expiration date and signature)
    ''' 
    ''' </summary>
    Private Sub BtnOpenLic_Click(sender As Object, e As EventArgs) Handles BtnOpenLic.Click

        lbxValidation.Items.Clear()

        Dim OfDLicense As New OpenFileDialog()
        'Dim LicStreamReader As StreamReader
        Dim myStream As Stream = Nothing

        'OfDLicense.InitialDirectory = "c:\"
        OfDLicense.Filter = "License (*.lic)|*.lic"
        OfDLicense.FilterIndex = 1
        OfDLicense.RestoreDirectory = True

        If OfDLicense.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = OfDLicense.OpenFile()
                If (myStream IsNot Nothing) Then
                    ULicense = Portable.Licensing.License.Load(myStream)

                    txtCustomerRO.Text = ULicense.Customer.Name.ToString
                    txtEMailRO.Text = ULicense.Customer.Email.ToString
                    txtUsersRO.Text = ULicense.Quantity.ToString
                    txtAttributeNameRO.Text = "Software"
                    txtAttributeValueRO.Text = ULicense.AdditionalAttributes.Get(txtAttributeNameRO.Text)
                    chkSalesRO.Checked = ULicense.ProductFeatures.Get("Sales")
                    chkBillingRO.Checked = ULicense.ProductFeatures.Get("Billing")

                    lbxValidation.Items.Add(ValidateLicense(ULicense).ToString)
                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If

    End Sub

    ''' <summary>
    '''  check licensetype
    ''' 
    ''' </summary>
    Private Function LicenseException(ByVal license As Portable.Licensing.License) As Boolean
        If (license.Type = LicenseType.Trial) Then
            Return True
        End If
        Return False
    End Function


    ''' <summary>
    '''  get licensetype
    ''' 
    ''' </summary>
    Private Function GetLicenseType() As LicenseType
        If (cbxLicenseType.Text = "Trial") Then
            Return LicenseType.Trial
        Else
            Return LicenseType.Standard
        End If

    End Function

    ''' <summary>
    ''' validate license and define return value
    ''' 
    ''' </summary>
    Private Function ValidateLicense(ByVal license As Portable.Licensing.License) As String

        Dim ReturnValue As String = "License is Valid"

        Dim validationFailures = license.Validate().ExpirationDate().When(AddressOf LicenseException).And().Signature(PublicKey).AssertValidLicense()

        If (Not IsNothing(validationFailures)) Then
            ReturnValue = ""
            For Each validationFailure As IValidationFailure In validationFailures
                ReturnValue = ReturnValue & validationFailure.HowToResolve & ": " & vbNewLine & validationFailure.Message & vbNewLine
            Next
        End If

        Return ReturnValue

    End Function



End Class

