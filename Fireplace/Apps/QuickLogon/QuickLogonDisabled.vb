Public Class QuickLogonDisabled

    Private Sub QuickLogonDisabled_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If Desktop.qld_fancy = True Then
            QLDHelpFancy.Show()
        Else
            HELP_MESSAGES.helpQuickLogonDisabled()
        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        QLDSettings.Show()
        Hide()
    End Sub
End Class