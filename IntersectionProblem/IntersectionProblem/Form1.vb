Option Strict On

Public Class Form1

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim Ast, Bst, Cst, Dst As String
        Dim A, B, C, D As Double

        ' Read the input from the user
        Ast = txtA.Text
        Bst = txtB.Text
        Cst = txtC.Text
        Dst = txtD.Text

        ' All input must be numbers
        If Not (IsNumeric(Ast) And IsNumeric(Bst) And IsNumeric(Cst) _
                And IsNumeric(Dst)) Then
            MessageBox.Show("Please enter valid numbers", "Error!")
            Exit Sub
        End If

        ' Convert to double
        A = CDbl(Ast)
        B = CDbl(Bst)
        C = CDbl(Cst)
        D = CDbl(Dst)

        If A > B Or C > D Then
            MessageBox.Show("A must be less than B and C must be less than D.", "Error")
            Exit Sub
        End If

        ' Please write your code here...
        txtResult.Text = FindIntersection(A, B, C, D)

    End Sub

    Function FindIntersection(a As Double, b As Double, c As Double, d As Double) As String

        Dim message As String
        If (b < c) Or (d < a) Then
            message = "There is no intersection."
        Else
            Dim begpoint As Double = Math.Max(a, c)
            Dim endpoint As Double = Math.Min(b, d)
            message = "The intersection is from " & begpoint & " to " & endpoint & "."
        End If
        Return message

    End Function

End Class
