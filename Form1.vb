Public Class frmMain
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Validate input
        If Not IsNumeric(txtNumber.Text) Then
            MsgBox("The value you entered was invalid. Try again.")
            Exit Sub
        End If
        If txtNumber.Text < 1 Or txtNumber.Text > 12 Then
            MsgBox("The value you entered was invalid. Try again.")
            Exit Sub
        End If
        ' Valid input. Call recursive function
        Dim intValue As Integer = txtNumber.Text
        Factorial(intValue)
    End Sub

    Public Function Factorial(ByVal num As Byte) As Long
        ' Recursive funcion to handle the factorial
        Dim i As Integer
        If num <= 0 Then Exit Function
        Factorial = 1
        For i = 1 To num
            Factorial = Factorial * i
            lstFactorialBox.Items.Add(i.ToString() & "! " & Factorial)
        Next
    End Function
End Class
