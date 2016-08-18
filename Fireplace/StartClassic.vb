Public Class StartClassic

    Public menutype = "classic"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        shutdown.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text = "Restart" Then
            shutdown.Show()
        ElseIf ComboBox1.Text = "Return back to Windows" Then
            shutdown.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ToolStripComboBox1.Text = "Classic" Then
            menutype = "classic"
            Desktop.omenutype = "classic"
        ElseIf ToolStripComboBox1.Text = "Fullscreen" Then
            menutype = "fullscreen"
            Desktop.omenutype = "fullscreen"
            Desktop.StartClassic1.Hide()
        Else
            MsgBox("Not a valid menu type.")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Calc.Show()
        Calc.TopMost = True
        Calc.TopMost = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WebBrowser.Show()
        WebBrowser.TopMost = True
        WebBrowser.TopMost = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FireplaceScriptAPP.Show()
        FireplaceScriptAPP.TopMost = True
        FireplaceScriptAPP.TopMost = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextEditor.Show()
        TextEditor.TopMost = True
        TextEditor.TopMost = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        run.Show()
        run.TopMost = True
        run.TopMost = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        FireNote.Show()
        FireNote.TopMost = True
        FireNote.TopMost = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        fpSettings.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        HELP_menu.Show()
    End Sub
End Class