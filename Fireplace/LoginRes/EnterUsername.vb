Public Class EnterUsername
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub EnterUsername_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Desktop.loginResBackColor = "blue" Then
            Label1.ForeColor = Color.Black
            BackColor = Color.Blue
        End If

        If Desktop.loginResBackColor = "white" Then
            Label1.ForeColor = Color.White
            BackColor = Color.White
        End If

        If Desktop.loginResBackColor = "red" Then
            Label1.ForeColor = Color.Black
            BackColor = Color.Red
        End If

        If Desktop.loginResBackColor = "green" Then
            Label1.ForeColor = Color.Black
            BackColor = Color.Green
        End If

        If Desktop.loginResBackColor = "gray" Then
            Label1.ForeColor = Color.Black
            BackColor = Color.Gray
        End If

        If Desktop.loginResBackColor = "light_blue" Then
            Label1.ForeColor = Color.Black
            BackColor = Color.LightBlue
        End If

        If Desktop.loginResBackColor = "light_green" Then
            Label1.ForeColor = Color.Black
            BackColor = Color.LightGreen
        End If
    End Sub

    Public Sub refreshBack()
        If Desktop.loginResBackColor = "blue" Then
            Label1.ForeColor = Color.Black
            BackColor = Color.Blue
        End If

        If Desktop.loginResBackColor = "white" Then
            Label1.ForeColor = Color.White
            BackColor = Color.White
        End If

        If Desktop.loginResBackColor = "red" Then
            Label1.ForeColor = Color.Black
            BackColor = Color.Red
        End If

        If Desktop.loginResBackColor = "green" Then
            Label1.ForeColor = Color.Black
            BackColor = Color.Green
        End If

        If Desktop.loginResBackColor = "gray" Then
            Label1.ForeColor = Color.Black
            BackColor = Color.Gray
        End If

        If Desktop.loginResBackColor = "light_blue" Then
            Label1.ForeColor = Color.Black
            BackColor = Color.LightBlue
        End If

        If Desktop.loginResBackColor = "light_green" Then
            Label1.ForeColor = Color.Black
            BackColor = Color.LightGreen
        End If
    End Sub
End Class