﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Export
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.exportFPA = New System.Windows.Forms.SaveFileDialog()
        Me.exportFPAS = New System.Windows.Forms.SaveFileDialog()
        Me.exportTXT = New System.Windows.Forms.SaveFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Export as..."
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Export as application... (.fpa)", "Export source... (.fpas)", "Export source... (.txt)"})
        Me.ComboBox1.Location = New System.Drawing.Point(39, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(248, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.Text = "Select export type from list..."
        '
        'exportFPA
        '
        Me.exportFPA.AddExtension = False
        Me.exportFPA.DefaultExt = "fpa"
        Me.exportFPA.Filter = "Fireplace Application|*.fpa"
        Me.exportFPA.ShowHelp = True
        Me.exportFPA.Title = "Export as .fpa"
        '
        'exportFPAS
        '
        Me.exportFPAS.DefaultExt = "fpas"
        Me.exportFPAS.Filter = "Fireplace App Source File|*.fpas"
        Me.exportFPAS.Title = "Export source as .fpas"
        '
        'exportTXT
        '
        Me.exportTXT.DefaultExt = "txt"
        Me.exportTXT.Filter = "Text Document|*.txt"
        Me.exportTXT.Title = "Export source as .txt"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(212, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Export"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(39, 52)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Export
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(321, 86)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Export"
        Me.Text = "Export"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents exportFPA As SaveFileDialog
    Friend WithEvents exportFPAS As SaveFileDialog
    Friend WithEvents exportTXT As SaveFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
