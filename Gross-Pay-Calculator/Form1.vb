Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim hoursWorked As Double
        Dim grossPay As Double
        Double.TryParse(txtHoursWorked.Text, hoursWorked)
        If hoursWorked >= 0.0 AndAlso hoursWorked <= 40.0 Then
            grossPay = hoursWorked * 10.65
            txtResults.Text = grossPay.ToString("C2")
        Else
            txtResults.Text = "Error"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Display a message box to confirm whether the user wants to exit
        Dim msgResponse As MsgBoxResult, Cancel
        msgResponse = MsgBox("Are you sure you want to exit?", vbQuestion + vbYesNo, "Confirm Exit")

        ' If the user clicks No, cancel the form closing event
        If msgResponse = vbNo Then
            Cancel = True
        ElseIf msgResponse = vbYes Then
            Me.Close()
        End If
    End Sub
End Class
