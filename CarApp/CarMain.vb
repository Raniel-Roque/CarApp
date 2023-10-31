Public Class CarMain
    Dim YearSave As ULong = 0
    Dim Resetting As Boolean = False
    Dim HondaCars() As String = {"City", "Jazz"}
    Dim HondaCarsPrice() As ULong = {973000, 1090000}
    Dim HondaImage() As Image = {My.Resources.HCity, My.Resources.HJazz}
    Dim KiaCars() As String = {"Rio", "Sorento"}
    Dim KiaCarsPrice() As ULong = {985000, 2448000}
    Dim KiaImage() As Image = {My.Resources.KRio, My.Resources.KSorento}
    Dim NissanCars() As String = {"Patrol", "Sentro"}
    Dim NissanCarsPrice() As ULong = {4758000, 175000}
    Dim NissanImage() As Image = {My.Resources.NPatrol, My.Resources.NSentro}
    Dim ToyotaCars() As String = {"Altis", "Avanza", "Camry"}
    Dim ToyotaCarsPrice() As ULong = {1135000, 1059000, 2457000}
    Dim ToyotaImage() As Image = {My.Resources.TAtlis, My.Resources.TAvanza, My.Resources.TCamry}
    Dim AnnualInterest() As Integer = {11, 8, 9, 10}
    Private Function CustomFormat(value As Double) As String
        If Math.Floor(value) = 0 Then
            ' Display as 0.XX when the whole number part is less than 1
            Return Format(value, "₱0.00")
        Else
            ' Display as XX.XX for other values
            Return Format(value, "₱#,##.00")
        End If
    End Function

    Private Sub Calculate()
        If Resetting = True Then
            Return
        End If

        If Car.SelectedIndex = -1 OrElse YearsToPay.Text = Nothing OrElse YearsToPay.Text = "Enter Years" Then
            TotalPrice.Text = "₱0.00"
            MonthlyDue.Text = "₱0.00"
            Return
        End If

        Dim Result As ULong

        If Not ULong.TryParse(YearsToPay.Text, Result) Then
            MessageBox.Show("Please Enter a Valid Amount", "Invalid Bet", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            YearsToPay.Text = YearSave
            YearsToPay.SelectionStart = YearsToPay.Text.Length
            Return
        End If

        YearSave = YearsToPay.Text

        If YearsToPay.Text = 0 Then
            TotalPrice.Text = Price.Text
            MonthlyDue.Text = "₱0.00"
            Return
        End If

        Select Case CarBrand.SelectedIndex
            Case 0
                CostCalculate(HondaCarsPrice(Car.SelectedIndex), YearsToPay.Text, AnnualInterest(CarBrand.SelectedIndex))
            Case 1
                CostCalculate(KiaCarsPrice(Car.SelectedIndex), YearsToPay.Text, AnnualInterest(CarBrand.SelectedIndex))
            Case 2
                CostCalculate(NissanCarsPrice(Car.SelectedIndex), YearsToPay.Text, AnnualInterest(CarBrand.SelectedIndex))
            Case 3
                CostCalculate(ToyotaCarsPrice(Car.SelectedIndex), YearsToPay.Text, AnnualInterest(CarBrand.SelectedIndex))
        End Select
    End Sub
    Private Sub CostCalculate(Price As ULong, Years As Integer, Interest As Decimal)
        Dim TotalPrice As Decimal
        TotalPrice = ((Price * (Interest / 100)) * Years) + Price
        Me.TotalPrice.Text = CustomFormat(TotalPrice)
        MonthlyDue.Text = CustomFormat(TotalPrice / (Years * 12))
    End Sub
    Private Sub CarBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CarBrand.SelectedIndexChanged
        If Resetting = True Then
            Return
        End If

        Price.Clear()
        TotalPrice.Text = "₱0.00"
        MonthlyDue.Text = "₱0.00"
        CarPic.Image = Nothing

        Car.Items.Clear()

        Select Case CarBrand.SelectedIndex
            Case 0
                Car.Items.AddRange(HondaCars)
                CarBrand0.Image = My.Resources.Honda
                CarBrand1.Image = My.Resources.Honda
            Case 1
                Car.Items.AddRange(KiaCars)
                CarBrand0.Image = My.Resources.Kia
                CarBrand1.Image = My.Resources.Kia
            Case 2
                Car.Items.AddRange(NissanCars)
                CarBrand0.Image = My.Resources.Nissan
                CarBrand1.Image = My.Resources.Nissan
            Case 3
                Car.Items.AddRange(ToyotaCars)
                CarBrand0.Image = My.Resources.toyota
                CarBrand1.Image = My.Resources.toyota
        End Select

        Interest.Text = AnnualInterest(CarBrand.SelectedIndex).ToString + "%"
    End Sub

    Private Sub Car_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Car.SelectedIndexChanged
        If Resetting = True Then
            Return
        End If

        Price.Clear()
        TotalPrice.Clear()
        MonthlyDue.Clear()

        Select Case CarBrand.SelectedIndex
            Case 0
                Price.Text = CustomFormat(HondaCarsPrice(Car.SelectedIndex))
                CarPic.Image = HondaImage(Car.SelectedIndex)
            Case 1
                Price.Text = CustomFormat(KiaCarsPrice(Car.SelectedIndex))
                CarPic.Image = KiaImage(Car.SelectedIndex)
            Case 2
                Price.Text = CustomFormat(NissanCarsPrice(Car.SelectedIndex))
                CarPic.Image = NissanImage(Car.SelectedIndex)
            Case 3
                Price.Text = CustomFormat(ToyotaCarsPrice(Car.SelectedIndex))
                CarPic.Image = ToyotaImage(Car.SelectedIndex)
        End Select

        Calculate()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles YearsToPay.TextChanged
        Calculate()
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        Resetting = True
        Price.Clear()
        YearsToPay.Clear()
        Interest.Clear()
        TotalPrice.Clear()
        MonthlyDue.Clear()
        CarBrand.SelectedIndex = -1
        Car.Items.Clear()
        CarBrand0.Image = Nothing
        CarBrand1.Image = Nothing
        CarPic.Image = Nothing
        Resetting = False
    End Sub
    Dim Bought_Car_Form1 As BoughtCar
    Private Sub Buy_Click(sender As Object, e As EventArgs) Handles Buy.Click
        If CarBrand.SelectedIndex = -1 OrElse Car.SelectedIndex = -1 Or YearsToPay.Text = Nothing Then
            MessageBox.Show("Please Fill in the Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        GlobalData.Brand = CarBrand.Text
        GlobalData.Model = Car.Text
        GlobalData.Price = Price.Text
        GlobalData.Years = YearsToPay.Text
        GlobalData.AnnualInterest = Interest.Text
        GlobalData.TotalPrice = TotalPrice.Text
        GlobalData.MonthlyDues = MonthlyDue.Text

        If Bought_Car_Form1 Is Nothing Then
            Bought_Car_Form1 = New BoughtCar
        End If
        Bought_Car_Form1.Show()
        Me.Close()
    End Sub
    Dim Load_Main As LoadCar
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        ' Goes to Loading
        If Load_Main Is Nothing Then
            Load_Main = New LoadCar
        End If
        Load_Main.Show()
        Me.Close()
    End Sub
End Class