Public Class CALCULATOR
    Dim value As Double
    Dim op As String

    Private Sub BtnOperationClicked(sender As Object, e As EventArgs) Handles Button4.Click, Button3.Click, Button2.Click, Button18.Click, Button1.Click, Button8.Click, Button19.Click, Button16.Click, Button12.Click
        Dim btn As Button = DirectCast(sender, Button)
        Dim newValue As Double = CDbl(txtNumber.Text)
        Select Case btn.Text
            Case "*", "/", "+", "-"
                value = newValue
                op = btn.Text
                txtNumber.Text = 0
            Case "="
                Select Case op
                    Case "*"
                        value *= newValue
                    Case "/"
                        value /= newValue
                    Case "+"
                        value += newValue
                    Case "-"
                        value -= newValue
                End Select
                txtNumber.Text = value
            Case "AC"
                value = 0
                op = ""
                txtNumber.Text = 0
            Case "."
                If Not txtNumber.Text.Contains("."c) Then
                    txtNumber.Text = txtNumber.Text + "."
                End If
            Case "+/-"
                txtNumber.Text = -newValue
            Case "%"
                txtNumber.Text = newValue / 100
        End Select
    End Sub

    Private Sub BtnNumberClicked(sender As Object, e As EventArgs) Handles Button9.Click, Button7.Click, Button6.Click, Button5.Click, Button17.Click, Button15.Click, Button14.Click, Button13.Click, Button11.Click, Button10.Click
        Dim btn As Button = DirectCast(sender, Button)
        If txtNumber.Text = "0" Then
            txtNumber.Text = btn.Text
        Else
            txtNumber.Text = txtNumber.Text + btn.Text
        End If
    End Sub

    Private Sub CALCULATOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
