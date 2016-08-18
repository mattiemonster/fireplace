Public Class NewMessage
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FireplaceScriptAPP.TextBox1.AppendText(vbNewLine + "message " + TextBox1.Text + " " + TextBox2.Text)
    End Sub
End Class