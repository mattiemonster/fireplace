Public Class SelectUser

    Public usedslots As Integer = 1
    Public loggedas As String = "Admin"
    Public password As String = "password@123"
    Public quickloginallowed = True

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

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Desktop.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MoreIntroductionInfomation.Show()
        MoreIntroductionInfomation.TopMost = True
        MoreIntroductionInfomation.TopMost = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        End
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            EnterUsername.Show()
        Else
            loggedas = ComboBox1.Text
            LoginForm.Show()
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        createnewuser.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        SetPassword.Show()
    End Sub

    Private Sub QuickLogonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuickLogonToolStripMenuItem.Click
        If quickloginallowed = True Then
            QuickLogin.Show()
        Else
            engine.fpQuickLogonDisabled()
            QuickLogonDisabled.Show()
        End If
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        SetPassword.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        shutdown.Show()
    End Sub

    Private Sub DEBUGLOGININSTANTToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Desktop.Show()
    End Sub

    Private Sub SelectUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Desktop.loginResBackColor = "blue" Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
            Label4.ForeColor = Color.White
            BackColor = Color.Blue
        End If

        If Desktop.loginResBackColor = "white" Then
            Label1.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
            Label4.ForeColor = Color.Black
            BackColor = Color.White
        End If

        If Desktop.loginResBackColor = "red" Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
            Label4.ForeColor = Color.White
            BackColor = Color.Red
        End If

        If Desktop.loginResBackColor = "green" Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
            Label4.ForeColor = Color.White
            BackColor = Color.Green
        End If

        If Desktop.loginResBackColor = "gray" Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
            Label4.ForeColor = Color.White
            BackColor = Color.Gray
        End If

        If Desktop.loginResBackColor = "light_blue" Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
            Label4.ForeColor = Color.White
            BackColor = Color.LightBlue
        End If

        If Desktop.loginResBackColor = "light_green" Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
            Label4.ForeColor = Color.White
            BackColor = Color.LightGreen
        End If
    End Sub

    Public Sub refreshBack()
        If Desktop.loginResBackColor = "blue" Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
            Label4.ForeColor = Color.White
            BackColor = Color.Blue
        End If

        If Desktop.loginResBackColor = "white" Then
            Label1.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
            Label4.ForeColor = Color.Black
            BackColor = Color.White
        End If

        If Desktop.loginResBackColor = "red" Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
            Label4.ForeColor = Color.White
            BackColor = Color.Red
        End If

        If Desktop.loginResBackColor = "green" Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
            Label4.ForeColor = Color.White
            BackColor = Color.Green
        End If

        If Desktop.loginResBackColor = "gray" Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
            Label4.ForeColor = Color.White
            BackColor = Color.Gray
        End If

        If Desktop.loginResBackColor = "light_blue" Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
            Label4.ForeColor = Color.White
            BackColor = Color.LightBlue
        End If

        If Desktop.loginResBackColor = "light_green" Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
            Label4.ForeColor = Color.White
            BackColor = Color.LightGreen
        End If
    End Sub
End Class