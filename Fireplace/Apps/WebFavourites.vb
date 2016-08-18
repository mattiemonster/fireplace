Public Class WebFavourites

    Public null = False
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser.WebBrowser1.Navigate(ListBox1.SelectedItem)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If null = False Then
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub
End Class