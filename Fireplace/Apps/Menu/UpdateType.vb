Public Class UpdateType
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Classic" Then
            Desktop.StartClassic1.menutype = "classic"
            Desktop.omenutype = "classic"
        ElseIf ComboBox1.Text = "Fullscreen" Then
            Desktop.StartClassic1.menutype = "fullscreen"
            Desktop.omenutype = "fullscreen"
            Desktop.StartClassic1.Hide()
        Else
            MsgBox("Not a valid menu type.")
        End If
    End Sub

    Private Sub UpdateType_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class