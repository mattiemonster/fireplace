Public Class WebAddFavourite
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            TextBox1.Text = WebBrowser.WebBrowser1.Url.ToString
        Catch ex As NullReferenceException
            MsgBox("The web browser currently has no page open.", MsgBoxStyle.Exclamation, "NullReferenceException")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            WebFavourites.ListBox1.Items.Add(WebBrowser.WebBrowser1.Url.ToString)
        Catch ex As NullReferenceException
            MsgBox("Go to a url first!", MsgBoxStyle.Exclamation, "NullReferenceException")
        End Try
    End Sub
End Class