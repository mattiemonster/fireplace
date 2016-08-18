Public Class createnewuser

    Public createdusers = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        SelectUser.ComboBox1.Items.Add(TextBox1.Text)
        SelectUser.usedslots = SelectUser.usedslots + 1
        Close()
    End Sub

    Private Sub createnewuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Desktop.loginResBackColor = "blue" Then
            BackColor = Color.Blue
        End If

        If Desktop.loginResBackColor = "white" Then
            BackColor = Color.White
        End If

        If Desktop.loginResBackColor = "red" Then
            BackColor = Color.Red
        End If

        If Desktop.loginResBackColor = "green" Then
            BackColor = Color.Green
        End If

        If Desktop.loginResBackColor = "gray" Then
            BackColor = Color.Gray
        End If

        If Desktop.loginResBackColor = "light_blue" Then
            BackColor = Color.LightBlue
        End If

        If Desktop.loginResBackColor = "light_green" Then
            BackColor = Color.LightGreen
        End If
    End Sub

    Public Sub refreshBackground()
        If Desktop.loginResBackColor = "blue" Then
            BackColor = Color.Blue
        End If

        If Desktop.loginResBackColor = "white" Then
            BackColor = Color.White
        End If

        If Desktop.loginResBackColor = "red" Then
            BackColor = Color.Red
        End If

        If Desktop.loginResBackColor = "green" Then
            BackColor = Color.Green
        End If

        If Desktop.loginResBackColor = "gray" Then
            BackColor = Color.Gray
        End If

        If Desktop.loginResBackColor = "light_blue" Then
            BackColor = Color.LightBlue
        End If

        If Desktop.loginResBackColor = "light_green" Then
            BackColor = Color.LightGreen
        End If
    End Sub
End Class