'Alisson Leiva Salazar
'10/15/18
Public Class Form1
        Private decWholesale As Decimal
        Private decMarkup As Decimal
        Private decRetailPrice As Decimal

        Private Sub btnGetRetail_Click(sender As Object, e As EventArgs) Handles btnGetRetail.Click

                Try
                        'Convert to Decimal Values
                        decWholesale = CDec(txtWholeCost.Text)
                        decMarkup = CDec(txtMarkup.Text)
                        CalculateRetailPrice(decWholesale, decMarkup)

                Catch
                        'ERROR Message
                        MessageBox.Show("Invalid Input: Must be valid numeric values.")
                End Try
        End Sub
        Private Function CalculateRetailPrice(ByVal decWholesale As Decimal, ByVal decMarkup As Decimal) As Decimal
                If (decWholesale >= 0 And decMarkup >= 0) Then
                        decRetailPrice = decWholesale * (1 + decMarkup / 100)
                        lblRetailOut.Text = CStr(decRetailPrice)
                Else
                        MessageBox.Show("Value must be positive.")

                End If
                Return decRetailPrice
        End Function

        Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
                Me.Close()
        End Sub


End Class
