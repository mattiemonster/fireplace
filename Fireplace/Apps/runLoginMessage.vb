Public Class runLoginMessage
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = SelectUser.password) Then
            run.Show()
            Close()
        ElseIf (TextBox1.Text = "") Then
            runLoginEnterPassword.Show()
            Close()
        Else
            runLoginPassWrong.Show()
            Close()
        End If
    End Sub
End Class