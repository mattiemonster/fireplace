Imports System.ComponentModel

Public Class QuickLogonToggle
    Private Sub QuickLogonToggle_HelpButtonClicked(sender As Object, e As CancelEventArgs) Handles Me.HelpButtonClicked
        engine.helpQuickLogonToggle()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SelectUser.quickloginallowed = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SelectUser.quickloginallowed = False
    End Sub
End Class