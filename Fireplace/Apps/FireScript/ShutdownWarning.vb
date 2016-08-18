Public Class ShutdownWarning
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            FPA_Player.askshutdown = False
            FireplaceScriptAPP.askshutdown = False
        End If
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButton1.Checked = True Then
            FPA_Player.askshutdown = False
            FireplaceScriptAPP.askshutdown = False
        End If
        Me.Close()
    End Sub
End Class