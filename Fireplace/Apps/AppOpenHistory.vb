Public Class AppOpenHistory

    Public i As Integer = 0
    Public l As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'MsgBox("Feature wip!")
        'engine.fpFeatureNotFound()
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AppOpenHistoryAdd.Show()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim writer As New IO.StreamWriter(SaveFileDialog1.FileName)
        TextBox1.Clear()
        i = 0
        l = ListBox1.Items.Count
        For i = 0 To l
            If i = 0 Then
                TextBox1.AppendText(ListBox1.Items.Item(i) + vbNewLine)
            Else
                TextBox1.AppendText(ListBox1.Items.Item(i - 1) + vbNewLine)
            End If
        Next
        writer.Write(TextBox1.Text)
        writer.Close()
    End Sub
End Class