Public Class Settings


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text = "Fullscreen" Then
            Desktop.StartClassic1.menutype = "fullscreen"
            Desktop.omenutype = "fullscreen"
            Desktop.Show()
            Me.Close()
        ElseIf ComboBox1.Text = "Classic" Then
            Desktop.StartClassic1.menutype = "classic"
            Desktop.omenutype = "classic"
            Desktop.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
