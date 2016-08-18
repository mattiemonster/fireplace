Public Class NewCWindow
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'FireplaceScriptAPP.TextBox1.AppendText(vbNewLine + "cwindow " + NumericUpDown1.Value + " " + NumericUpDown2.Value + " " + NumericUpDown3.Value + " " + NumericUpDown4.Value)
        FireplaceScriptAPP.TextBox1.AppendText(vbNewLine)
        FireplaceScriptAPP.TextBox1.AppendText("cwindow ")
        FireplaceScriptAPP.TextBox1.AppendText(NumericUpDown3.Value)
        FireplaceScriptAPP.TextBox1.AppendText(" ")
        FireplaceScriptAPP.TextBox1.AppendText(NumericUpDown4.Value)
        FireplaceScriptAPP.TextBox1.AppendText(" ")
        FireplaceScriptAPP.TextBox1.AppendText(NumericUpDown1.Value)
        FireplaceScriptAPP.TextBox1.AppendText(" ")
        FireplaceScriptAPP.TextBox1.AppendText(NumericUpDown2.Value)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FireplaceScriptAPP.TextBox1.AppendText(vbNewLine)
        FireplaceScriptAPP.TextBox1.AppendText("cwindow ")
        FireplaceScriptAPP.TextBox1.AppendText(NumericUpDown3.Value)
        FireplaceScriptAPP.TextBox1.AppendText(" ")
        FireplaceScriptAPP.TextBox1.AppendText(NumericUpDown4.Value)
        FireplaceScriptAPP.TextBox1.AppendText(" ")
        FireplaceScriptAPP.TextBox1.AppendText(NumericUpDown1.Value)
        FireplaceScriptAPP.TextBox1.AppendText(" ")
        FireplaceScriptAPP.TextBox1.AppendText(NumericUpDown2.Value)
        FireplaceScriptAPP.TextBox1.AppendText(vbNewLine)
        FireplaceScriptAPP.TextBox1.AppendText("cwindow_show")
    End Sub
End Class