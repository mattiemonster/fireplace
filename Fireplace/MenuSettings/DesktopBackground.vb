Public Class DesktopBackground
    Private Sub DesktopBackground_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "White" Then
            Desktop.setBackWhite()
        ElseIf ComboBox1.Text = "Gray" Then
            Desktop.setBackGray()
        ElseIf ComboBox1.Text = "Blue" Then
            Desktop.setBackBlue()
        ElseIf ComboBox1.Text = "Green" Then
            Desktop.setBackGreen()
        ElseIf ComboBox1.Text = "Red" Then
            Desktop.setBackRed()
        ElseIf ComboBox1.Text = "Yellow" Then
            Desktop.setBackYellow()
        ElseIf ComboBox1.Text = "Brown" Then
            Desktop.setBackBrown()
        Else
            MsgBox("The colour you typed in or selected is not currently added in. Sorry!", MsgBoxStyle.Critical, "Error changing background!")
            engine.fpFeatureNotFound()
            engine.e1Xneg1T001()
        End If
    End Sub
End Class