Public Class shutdown
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckedListBox1.GetItemChecked(0) = True Then
            End
        ElseIf CheckedListBox1.GetItemChecked(1) = True Then
            Application.Restart()
        Else
            MsgBox("No option selected!", MsgBoxStyle.Critical, "Error performing action.")
        End If
    End Sub
End Class