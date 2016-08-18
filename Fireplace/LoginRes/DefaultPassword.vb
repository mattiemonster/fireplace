Public Class DefaultPassword
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SetPassword.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub DefaultPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Desktop.loginResBackColor = "blue" Then
            BackColor = Color.Blue
            Label1.ForeColor = Color.White
        End If

        If Desktop.loginResBackColor = "white" Then
            BackColor = Color.White
            Label1.ForeColor = Color.Black
        End If

        If Desktop.loginResBackColor = "red" Then
            BackColor = Color.Red
            Label1.ForeColor = Color.White
        End If

        If Desktop.loginResBackColor = "green" Then
            BackColor = Color.Green
            Label1.ForeColor = Color.White
        End If

        If Desktop.loginResBackColor = "gray" Then
            BackColor = Color.Gray
            Label1.ForeColor = Color.White
        End If

        If Desktop.loginResBackColor = "light_blue" Then
            BackColor = Color.LightBlue
            Label1.ForeColor = Color.White
        End If

        If Desktop.loginResBackColor = "light_green" Then
            BackColor = Color.LightGreen
            Label1.ForeColor = Color.White
        End If
    End Sub

    Public Sub refreshBackground()
        If Desktop.loginResBackColor = "blue" Then
            BackColor = Color.Blue
            Label1.ForeColor = Color.White
        End If

        If Desktop.loginResBackColor = "white" Then
            BackColor = Color.White
            Label1.ForeColor = Color.Black
        End If

        If Desktop.loginResBackColor = "red" Then
            BackColor = Color.Red
            Label1.ForeColor = Color.White
        End If

        If Desktop.loginResBackColor = "green" Then
            BackColor = Color.Green
            Label1.ForeColor = Color.White
        End If

        If Desktop.loginResBackColor = "gray" Then
            BackColor = Color.Gray
            Label1.ForeColor = Color.White
        End If

        If Desktop.loginResBackColor = "light_blue" Then
            BackColor = Color.LightBlue
            Label1.ForeColor = Color.White
        End If

        If Desktop.loginResBackColor = "light_green" Then
            BackColor = Color.LightGreen
            Label1.ForeColor = Color.White
        End If
    End Sub
End Class