Public Class Export
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Export as application... (.fpa)" Then
            exportFPA.ShowDialog()
        ElseIf ComboBox1.Text = "Export source... (.fpas)" Then
            exportFPAS.ShowDialog()
        ElseIf ComboBox1.Text = "Export source... (.txt)" Then
            exportTXT.ShowDialog()
        Else
            MsgBox("Invalid export format!", MsgBoxStyle.Critical, "Fireplace Script Export Error")
        End If
    End Sub

    Private Sub exportFPA_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles exportFPA.FileOk
        Dim writer As New IO.StreamWriter(exportFPA.FileName)
        writer.Write(FireplaceScriptAPP.TextBox1.Text)
        writer.Close()
    End Sub

    Private Sub exportFPAS_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles exportFPAS.FileOk
        Dim writer As New IO.StreamWriter(exportFPAS.FileName)
        writer.Write(FireplaceScriptAPP.TextBox1.Text)
        writer.Close()
    End Sub

    Private Sub exportTXT_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles exportTXT.FileOk
        Dim writer As New IO.StreamWriter(exportTXT.FileName)
        writer.Write(FireplaceScriptAPP.TextBox1.Text)
        writer.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Export_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True
    End Sub
End Class