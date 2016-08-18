Public Class Desktop

    Public omenutype = "classic"
    Public classicmenuopen = False


    Private Sub Desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartClassic1.Hide()
        Label2.Text = SelectUser.loggedas + "!"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If classicmenuopen = False And omenutype = "classic" Then
            StartClassic1.Show()
            classicmenuopen = True
        ElseIf classicmenuopen = True And omenutype = "classic" Then
            StartClassic1.Hide()
            classicmenuopen = False
        ElseIf StartClassic1.menutype = "fullscreen" And omenutype = "fullscreen" Then
            fullmenu.Show()
        End If
    End Sub

    Private Sub StartClassic1_Load(sender As Object, e As EventArgs) Handles StartClassic1.Load

    End Sub
End Class