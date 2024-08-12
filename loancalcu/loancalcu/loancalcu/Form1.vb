Public Class Form1
    Dim loanAmount As Double
    Dim annualInterestRate As Double
    Dim yearsToPay As Integer
    Dim monthlyPayment As Double
    Dim totalLoanPayment As Double
    Dim totalInterest As Double
    Dim totalAnnualPayment As Double
    Dim monthlyInterestRate As Double
    Dim numberOfPayments As Integer
    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox8.Text = TextBox1.Text
        TextBox16.Text = TextBox3.Text
        TextBox10.Text = TextBox2.Text
        TextBox9.Text = TextBox7.Text



        monthlyInterestRate = annualInterestRate / 12
        numberOfPayments = yearsToPay * 12

        ' Calculate monthly payment using the formula
        If monthlyInterestRate = 0 Then
            monthlyPayment = loanAmount / numberOfPayments
        Else
            monthlyPayment = loanAmount * (monthlyInterestRate * (1 + monthlyInterestRate) ^ numberOfPayments) / ((1 + monthlyInterestRate) ^ numberOfPayments - 1)
        End If

        ' Calculate total loan payment, total interest, and total annual payment
        totalLoanPayment = monthlyPayment * numberOfPayments
        totalInterest = totalLoanPayment - loanAmount
        totalAnnualPayment = monthlyPayment * 12



    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged

    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        loanAmount = TextBox4.Text
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class
