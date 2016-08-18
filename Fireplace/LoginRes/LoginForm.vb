Public Class LoginForm

    Public loginas = "Admin"
    Public username = "user"
    Public inputpassword = "NONE"
    Public loginstate = "epassword"

    Private Sub CreateNewAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateNewAccountToolStripMenuItem.Click
        createnewuser.Show()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        DefaultPassword.Show()
    End Sub

    Private Sub ShutdownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShutdownToolStripMenuItem.Click
        End
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        Application.Restart()
    End Sub

    Private Sub MinimizeLogonWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeLogonWindowToolStripMenuItem.Click
        WindowState = FormWindowState.Minimized
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = SelectUser.password And loginstate = "epassword" Then
            Label2.Hide()
            TextBox1.Hide()
            Label1.Text = "Welcome!"
            Button1.Text = "Continue..."
            loginstate = "logedin"
        ElseIf loginstate = "logedin" Then
            'MsgBox(loginas)
            Desktop.loginname = loginas
            Desktop.Show()
            Close()
        Else
            PasswordWrong.Show()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Desktop.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MoreIntroductionInfomation.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loginstate = "epassword"
        loginas = SelectUser.loggedas
        Label1.Text = SelectUser.loggedas

        If Desktop.loginResBackColor = "blue" Then
            Label1.ForeColor = Color.Black
            BackColor = Color.Blue
        End If

        If Desktop.loginResBackColor = "white" Then
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

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        createnewuser.Show()
        Close()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        SetPassword.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub RunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunToolStripMenuItem.Click
        runLoginMessage.Show()
    End Sub

    Public Sub refreshBack()
        If Desktop.loginResBackColor = "blue" Then
            Label1.ForeColor = Color.Black
            BackColor = Color.Blue
        End If

        If Desktop.loginResBackColor = "white" Then
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