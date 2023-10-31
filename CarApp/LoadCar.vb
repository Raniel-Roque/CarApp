Public Class LoadCar
    Private Sub Load_Tick(sender As Object, e As EventArgs) Handles Load.Tick
        If PB.Value <= PB.Maximum - 1 Then
            PB.Value += 5
        ElseIf PB.Value = PB.Maximum Then
            PB.Dispose()
            Button1.Visible = True
        End If
    End Sub

    Dim Car_Main As CarMain
    Private Sub Enter_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Goes to main menu 
        If Car_Main Is Nothing Then
            Car_Main = New CarMain
        End If
        Car_Main.Show()
        Me.Close()
    End Sub
End Class