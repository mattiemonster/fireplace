Public Class QuickLogonDisabled
    Private Sub QuickLogonDisabled_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        HELP_MESSAGES.helpQuickLogonDisabled()
    End Sub
End Class