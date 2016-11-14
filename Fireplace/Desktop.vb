Public Class Desktop

    Public omenutype = "classic"
    Public classicmenuopen = False
    Public loginname = "Admin"
    Public loginResBackColor = "blue"
    Public appFireNoteShowCloseMsg = True
    Public appFireNoteShowClearMsg = True
    Public qld_fancy = True

    Private Sub Desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartClassic1.Hide()
        Label2.Text = loginname + "!"
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

    Private Sub ShutdownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShutdownToolStripMenuItem.Click
        End
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        If omenutype = "classic" And classicmenuopen = True Then
            StartClassic1.Hide()
            classicmenuopen = False
        ElseIf omenutype = "classic" And classicmenuopen = False Then
            StartClassic1.Show()
            classicmenuopen = True
        ElseIf StartClassic1.menutype = "fullscreen" And omenutype = "fullscreen" Then
            fullmenu.Show()
        Else
            MsgBox("Invalid menu state incountered.")
        End If
    End Sub

    Private Sub ChangeDesktopBackgroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeDesktopBackgroundToolStripMenuItem.Click
        DesktopBackground.Show()
    End Sub

    Public Sub setBackWhite()
        BackColor = Color.White
    End Sub

    Public Sub setBackGray()
        BackColor = Color.Gray
    End Sub

    Public Sub setBackBlue()
        BackColor = Color.Blue
    End Sub

    Public Sub setBackGreen()
        BackColor = Color.Green
    End Sub

    Public Sub setBackRed()
        BackColor = Color.Red
    End Sub

    Public Sub setBackYellow()
        BackColor = Color.Yellow
    End Sub

    Public Sub setBackBrown()
        BackColor = Color.Brown
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(Date.Now.ToString("dd/MM/yyyy HH:mm:ss"), MsgBoxStyle.Information, "Date and Time (day/month/year)")
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        HELP_menu.Show()
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem1.Click
        HELP_desktopbackground.Show()
    End Sub
End Class