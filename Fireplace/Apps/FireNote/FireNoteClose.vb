Public Class FireNoteClose
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = Desktop.appFireNoteShowCloseMsg Then
            Desktop.appFireNoteShowCloseMsg = False
        End If
        FireNote.Close()
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RadioButton1.Checked = False
    End Sub
End Class