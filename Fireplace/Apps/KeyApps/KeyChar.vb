Public Class KeyChar

    Public previousChar = "There has been no previous key char."

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        MsgBox(e.KeyChar.ToString)
        previousChar = e.KeyChar.ToString
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(previousChar)
    End Sub
End Class