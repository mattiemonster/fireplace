Public Class StartClassic

    Public menutype = "classic"


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text = "Restart" Then
            Application.Restart()
        ElseIf ComboBox1.Text = "Return back to Windows" Then
            End
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

    Private Sub StartClassic_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Calc.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WebBrowser.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FireplaceScriptAPP.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextEditor.Show()
    End Sub
End Class
