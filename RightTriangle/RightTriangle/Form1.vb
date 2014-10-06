Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

        If IsNumeric(txtSideOne.Text) = False Or IsNumeric(txtSideTwo.Text) = False Then
            MessageBox.Show("Please enter a valid number", "Error")
            Exit Sub
        End If

        Dim a As Double = CDbl(txtSideOne.Text)
        Dim b As Double = CDbl(txtSideTwo.Text)

        Dim result As Double = Math.Round(hypotenuse(a, b), 2)
        txtHyp.Text = CStr(result)

    End Sub

    Function hypotenuse(ByVal a As Double, ByVal b As Double) As Double

        Dim c As Double
        c = Math.Sqrt(a ^ 2 + b ^ 2)
        Return c

    End Function

End Class
