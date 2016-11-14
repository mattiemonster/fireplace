Public Class HELP_MESSAGES

    Public Shared Sub helpQuickLogonToggle()
        MsgBox("Use the button to toggle the ability to use the Quick Login feature.", MsgBoxStyle.Information, "Help")
    End Sub

    Public Shared Sub helpQuickLogonDisabled()
        MsgBox("The quick logon feature of Fireplace is currently disabled. Please either log in normally, or type in the admin password to turn quick logon on.", MsgBoxStyle.Information, "Help")
    End Sub

End Class