Imports System.Text.RegularExpressions
Public Class BoughtCar
    Public Function ValidatePhone(ByVal strPhoneNum As String) As Boolean
        'Create Reg Exp Pattern
        Dim strPhonePattern As String = "^\d{11}$"
        'Create Reg Ex Object
        Dim rePhone As New Regex(strPhonePattern)
        If Not String.IsNullOrEmpty(strPhoneNum) Then
            Return rePhone.IsMatch(strPhoneNum)
        Else
            Return False
        End If
    End Function
    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        Name.Text = ""
        PhoneNum.Text = ""
        Email.Text = ""
        Address.Text = ""
    End Sub
    Dim Bought_Car_Form2 As BoughtCarFinal

    Private Sub NextPage_Click(sender As Object, e As EventArgs) Handles NextPage.Click
        If Name.Text = Nothing OrElse Address.Text = Nothing OrElse Email.Text = Nothing OrElse PhoneNum.Text = Nothing Then
            MessageBox.Show("Please Fill in the Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not ValidatePhone(PhoneNum.Text) Then
            MessageBox.Show("Please Enter A Valid Phone Number", "Incorrect Phone Format", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        GlobalData.Name = Name.Text
        GlobalData.PhoneNum = PhoneNum.Text
        GlobalData.Address = Address.Text
        GlobalData.Email = Email.Text
        GlobalData.ReceiptNum += 1

        If Bought_Car_Form2 Is Nothing Then
            Bought_Car_Form2 = New BoughtCarFinal
        End If
        Bought_Car_Form2.Show()
        Me.Close()
    End Sub
    Dim Car_Main As CarMain
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        ' Goes to Loading
        GlobalData.Name = Nothing
        GlobalData.PhoneNum = Nothing
        GlobalData.Email = Nothing
        GlobalData.Address = Nothing
        GlobalData.Brand = Nothing
        GlobalData.Model = Nothing
        GlobalData.Price = Nothing
        GlobalData.Years = Nothing
        GlobalData.AnnualInterest = Nothing
        GlobalData.TotalPrice = Nothing
        GlobalData.MonthlyDues = Nothing

        If Car_Main Is Nothing Then
            Car_Main = New CarMain
        End If
        Car_Main.Show()
        Me.Close()
    End Sub
End Class