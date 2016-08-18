Public Class SetPassword

    Public origpassword = "noinput"
    Public npass = "npass"

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub SetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Button1.Enabled = False
        TextBox2.Enabled = False
        Button3.Enabled = False

        If Desktop.loginResBackColor = "blue" Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            BackColor = Color.Blue
        End If

        If Desktop.loginResBackColor = "white" Then
            Label1.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            BackColor = Color.White
        End If

        If Desktop.loginResBackColor = "red" Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            BackColor = Color.Red
        End If

        If Desktop.loginResBackColor = "green" Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            BackColor = Color.Green
        End If

        If Desktop.loginResBackColor = "gray" Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            BackColor = Color.Gray
        End If

        If Desktop.loginResBackColor = "light_blue" Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            BackColor = Color.LightBlue
        End If

        If Desktop.loginResBackColor = "light_green" Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = SelectUser.password Then
            origpassword = "done"
            TextBox1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = True
            TextBox2.Enabled = True
        Else
            PasswordWrong.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Enabled = False
        TextBox2.Enabled = False
        Button1.Enabled = True
        npass = TextBox2.Text
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        SelectUser.password = npass
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub ShowTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowTextToolStripMenuItem.Click
        MsgBox("Text: " + TextBox1.Text)
    End Sub

    Private Sub ShowTextToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ShowTextToolStripMenuItem1.Click
        MsgBox("Text: " + TextBox2.Text)
    End Sub

    Public Sub refreshBack()
        If Desktop.loginResBackColor = "blue" Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            BackColor = Color.Blue
        End If

        If Desktop.loginResBackColor = "white" Then
            Label1.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            BackColor = Color.White
        End If

        If Desktop.loginResBackColor = "red" Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            BackColor = Color.Red
        End If

        If Desktop.loginResBackColor = "green" Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            BackColor = Color.Green
        End If

        If Desktop.loginResBackColor = "gray" Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            BackColor = Color.Gray
        End If

        If Desktop.loginResBackColor = "light_blue" Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            BackColor = Color.LightBlue
        End If

        If Desktop.loginResBackColor = "light_green" Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            BackColor = Color.LightGreen
        End If
    End Sub
End Class