Public Class Form1
    Dim myAge As Integer
    Dim myName As String

    Private Sub btnDraw_Click(sender As Object, e As EventArgs) Handles btnDraw.Click
        Dim myNumber As Integer
        myAge = txtAge.Text
        myName = txtName.Text
        myNumber = Int(Rnd() * 200) + 1
        TextBox3.Text = myNumber

        If myNumber > 120 And myAge > 50 Then
            txtOutcome.Text = "Congratualation" & " " & myName & ", you won a lucky prize"
        Else
            txtOutcome.Text = "Sorry" & " " & myName & ", you did not win any prize"
        End If
    End Sub
End Class
