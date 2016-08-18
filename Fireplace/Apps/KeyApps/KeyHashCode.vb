Public Class KeyHashCode

    Public previousHash = "There has been no previous hash code that has been recorded."

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        MsgBox(e.GetHashCode.ToString)
        previousHash = e.GetHashCode.ToString
        TextBox1.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(previousHash)
    End Sub
End Class