Public Class fullmenu

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        'MsgBox("Please bare with me while I add this feature again.")
        'engine.fpFeatureNotFound()
        UpdateType.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextEditor.Show()
        TextEditor.TopMost = True
        TextEditor.TopMost = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        WebBrowser.Show()
        WebBrowser.TopMost = True
        WebBrowser.TopMost = False
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        FireplaceScriptAPP.Show()
        FireplaceScriptAPP.TopMost = True
        FireplaceScriptAPP.TopMost = False
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Calc.Show()
        Calc.TopMost = True
        Calc.TopMost = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        shutdown.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 
        Application.Restart()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        run.Show()
        run.TopMost = True
        run.TopMost = False
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        FireNote.Show()
        FireNote.TopMost = True
        FireNote.TopMost = False
    End Sub
End Class