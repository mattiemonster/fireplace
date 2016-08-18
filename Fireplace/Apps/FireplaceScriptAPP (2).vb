Public Class FireplaceScriptAPP

    Public ibinput = "Input Box"

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub FireplaceScriptAPP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Visible = False
        TextBox1.WordWrap = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim writer As New IO.StreamWriter(SaveFileDialog1.FileName)
        writer.Write(TextBox1.Text)
        writer.Close()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim reader As New IO.StreamReader(OpenFileDialog1.FileName)
        TextBox1.Text = reader.ReadToEnd
        reader.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(TextBox1.Lines)
        For i = 0 To ListBox1.Items.Count - 1
            Dim sstring As String = ListBox1.Items.Item(i)
            Dim sarray() As String = Split(sstring)

            If sarray(0) = "helloworld" Then
                MsgBox("Hello World")
            End If

            If sarray(0) = "message" Then
                MsgBox(sarray(1), , sarray(2))
            End If

            If sarray(0) = "errorbeep" Then
                Beep()
            End If

            If sarray(0) = "ib" Then
                ibinput = InputBox("Input:", "Please enter your input")
                MsgBox("You entered:" + ibinput)
            End If
        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        About.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Credits.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NewQuestion.Show()
    End Sub
End Class
