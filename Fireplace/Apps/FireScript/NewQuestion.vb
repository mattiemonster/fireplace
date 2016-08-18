Public Class NewQuestion

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FireplaceScriptAPP.SaveFileDialog1.ShowDialog()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FireplaceScriptAPP.TextBox1.Clear()
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class