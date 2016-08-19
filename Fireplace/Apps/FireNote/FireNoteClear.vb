Public Class FireNoteClear
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = Desktop.appFireNoteShowClearMsg Then
            Desktop.appFireNoteShowClearMsg = False
        End If
        FireNote.TextBox1.Clear()
        Close()
    End Sub
End Class