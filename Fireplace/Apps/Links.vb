Public Class Links

    Public null = True

    Public page = WebBrowser.WebBrowser1.Url

    Private Sub Links_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser.WebBrowser1.Navigate("http://google.com/")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser.WebBrowser1.Navigate("http://bing.com/")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            MsgBox(WebBrowser.WebBrowser1.Url.ToString, MsgBoxStyle.Information, "Current page")
        Catch ex As NullReferenceException
            MsgBox("The web browser currently has no page open.", MsgBoxStyle.Exclamation, "NullReferenceException")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebBrowser.WebBrowser1.Navigate("http://fireplacevos.codeplex.com/")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        WebBrowser.WebBrowser1.Navigate("http://youtube.com/")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WebBrowser.WebBrowser1.Navigate("http://facebook.com/")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        WebBrowser.WebBrowser1.Navigate("http://twitter.com/")
    End Sub
End Class