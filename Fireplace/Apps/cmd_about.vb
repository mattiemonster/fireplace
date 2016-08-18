Public Class cmd_about
    Private Sub cmd_about_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class