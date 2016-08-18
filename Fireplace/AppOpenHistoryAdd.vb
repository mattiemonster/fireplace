Public Class AppOpenHistoryAdd
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AppOpenHistory.ListBox1.Items.Add("App: " + TextBox1.Text + " | Using: " + TextBox2.Text)
        Close()
    End Sub
End Class