Public Class QLDSettings



    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        QuickLogonDisabled.Show()
        Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Desktop.qld_fancy = True Then
            CurrentlyOn.Show()
        Else
            CurrentlyOff.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Desktop.qld_fancy = True Then
            Desktop.qld_fancy = False
        Else
            Desktop.qld_fancy = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Desktop.qld_fancy = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Desktop.qld_fancy = False
    End Sub
End Class