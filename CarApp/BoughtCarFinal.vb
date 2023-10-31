Public Class BoughtCarFinal
    Private Sub BoughtCarFinal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentDate As DateTime = DateAdd(DateInterval.Month, 1, Date.Now)

        Name.Text = GlobalData.Name
        PhoneNum.Text = GlobalData.PhoneNum
        Email.Text = GlobalData.Email
        Address.Text = GlobalData.Address
        ReceiptNo.Text = GlobalData.ReceiptNum
        DateBox.Text = Date.Now.ToString("MMMM dd yyyy")

        Brand.Text = GlobalData.Brand
        Model.Text = GlobalData.Model
        Price.Text = GlobalData.Price
        YearsToPay.Text = GlobalData.Years
        Interest.Text = GlobalData.AnnualInterest
        TotalPrice.Text = GlobalData.TotalPrice
        MonthlyDue.Text = GlobalData.MonthlyDues

        If GlobalData.Years = 0 Then
            NextPayment.Text = "Fully Paid"
        Else
            NextPayment.Text = currentDate.ToString("MMMM dd yyyy")
        End If


    End Sub
    Dim Car_Main As CarMain
    Private Sub NextPage_Click(sender As Object, e As EventArgs) Handles NextPage.Click
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