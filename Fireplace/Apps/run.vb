﻿'Imports FireplaceEngine

'Fireplace engine has been built into the application

Public Class run

    'Public errorboxs As New ErrorBox
    ' Public engine As New EngineObjects

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "run" Then
            MsgBox("Well. Press OK.")
            AppOpenHistory.ListBox1.Items.Add("App: Run | Using: Run - wait? why?")
        ElseIf TextBox1.Text = "web" Then
            WebBrowser.Show()
            WebBrowser.TopMost = True
            WebBrowser.TopMost = False
            AppOpenHistory.ListBox1.Items.Add("App: Web Browser | Using: Run")
        ElseIf TextBox1.Text = "text" Then
            TextEditor.Show()
            TextEditor.TopMost = True
            TextEditor.TopMost = False
            AppOpenHistory.ListBox1.Items.Add("App: Text Editor | Using: Run")
        ElseIf TextBox1.Text = "cmd" Then
            cmd.Show()
            cmd.TopMost = True
            cmd.TopMost = False
            AppOpenHistory.ListBox1.Items.Add("App: Command Prompt | Using: Run")
        ElseIf TextBox1.Text = "fireplace_script" Then
            FireplaceScriptAPP.Show()
            FireplaceScriptAPP.TopMost = True
            FireplaceScriptAPP.TopMost = False
            AppOpenHistory.ListBox1.Items.Add("App: Fireplace Script App | Using: Run")
        ElseIf TextBox1.Text = "endfp" Then
            shutdown.Show()
        ElseIf TextBox1.Text = "resfp" Then
            shutdown.Show()
        ElseIf TextBox1.Text = "calc" Then
            Calc.Show()
            Calc.TopMost = True
            Calc.TopMost = False
            AppOpenHistory.ListBox1.Items.Add("App: Calculator | Using: Run")
            Close()
        ElseIf TextBox1.Text = "key_hash" Then
            KeyHashCode.Show()
            KeyHashCode.TopMost = True
            KeyHashCode.TopMost = False
            AppOpenHistory.ListBox1.Items.Add("App: Key Hash Code Getter | Using: Run")
            Close()
        ElseIf TextBox1.Text = "key_type" Then
            KeyType.Show()
            KeyType.TopMost = True
            KeyType.TopMost = False
            AppOpenHistory.ListBox1.Items.Add("App: Key Type Getter | Using: Run")
            Close()
        ElseIf TextBox1.Text = "key_char" Then
            KeyChar.Show()
            KeyChar.TopMost = True
            KeyChar.TopMost = False
            AppOpenHistory.ListBox1.Items.Add("App: Key Char Getter | Using: Run")
            Close()
        ElseIf TextBox1.Text = "fpnote" Then
            FireNote.Show()
            FireNote.TopMost = True
            FireNote.TopMost = False
            AppOpenHistory.ListBox1.Items.Add("App: Firenote | Using: Run")
            Close()
        ElseIf TextBox1.Text = "openapphis" Then
            AppOpenHistory.Show()
            AppOpenHistory.TopMost = True
            AppOpenHistory.TopMost = False
            AppOpenHistory.ListBox1.Items.Add("App: Opened App History | Using: Run")
            Close()
        ElseIf TextBox1.Text = "boxtester_errorcritical" Then
            engine.mjrerr()
            AppOpenHistory.ListBox1.Items.Add("App: Critical error | Using: Run")
            Close()
        ElseIf TextBox1.Text = "boxtester_apperrorcritical" Then
            engine.mjrerrs()
            AppOpenHistory.ListBox1.Items.Add("App: App Critical Error | Using: Run")
            Close()
        ElseIf TextBox1.Text = "boxtester_errorwarn" Then
            engine.warn()
            AppOpenHistory.ListBox1.Items.Add("App: Warning | Using: Run")
            Close()
        ElseIf TextBox1.Text = "boxtester_apperrorwarn" Then
            engine.warns()
            AppOpenHistory.ListBox1.Items.Add("App: App Warning | Using: Run")
            Close()
        ElseIf TextBox1.Text = "boxtester_fpfeaturenotfound" Then
            engine.fpFeatureNotFound()
            AppOpenHistory.ListBox1.Items.Add("App: Feature Not Found Error | Using: Run")
            Close()
        ElseIf TextBox1.Text = "boxtester_e1X-1T001" Then
            engine.e1Xneg1T001()
            AppOpenHistory.ListBox1.Items.Add("App: e1X-1T001 | Using: Run")
            Close()
        ElseIf TextBox1.Text = "fpwinexplorer" Then
            MsgBox("FIREPLACE_WINEXPLORER IS A TESTING APPLICATION")
            AppOpenHistory.ListBox1.Items.Add("App: Fireplace Windows Explorer | Using: Run")
            FireplaceWindowsExplorer.Show()
            Close()
        ElseIf TextBox1.Text = "error_dictionary" Then
            ED_MENU.Show()
            AppOpenHistory.ListBox1.Items.Add("App: Error Dictionary | Using: Run")
            Close()
        ElseIf TextBox1.Text = "desktop" Then
            Desktop.Show()
            AppOpenHistory.ListBox1.Items.Add("App: Desktop | Using: Run")
            Close()
        ElseIf TextBox1.Text = "oldintroduction" Then
            Form1.Show()
            AppOpenHistory.ListBox1.Items.Add("App: Old Introduction | Using: Run")
            Close()
        ElseIf TextBox1.Text = "fpa_player" Then
            FPA_Player.Show()
            AppOpenHistory.ListBox1.Items.Add("App: FPA Player | Using: Run")
            Close()
        ElseIf TextBox1.Text = "help" Then
            HELP_menu.Show()
            AppOpenHistory.ListBox1.Items.Add("App: Help | Using: Run")
        ElseIf TextBox1.Text = "help_changebackground" Then
            HELP_desktopbackground.Show()
            AppOpenHistory.ListBox1.Items.Add("App: Help - Change Desktop Background | Using: Run")
        ElseIf TextBox1.Text = "quick_logon_disabled" Then
            QuickLogonDisabled.Show()
            AppOpenHistory.ListBox1.Items.Add("App: Quick Logon Disabled Window | Using: Run")
        ElseIf TextBox1.Text = "help_qldisabled" Then
            HELP_MESSAGES.helpQuickLogonDisabled()
            AppOpenHistory.ListBox1.Items.Add("App: Quick Logon Disabled Help | Using: Run")
        ElseIf TextBox1.Text = "help_qltoggle" Then
            HELP_MESSAGES.helpQuickLogonToggle()
            AppOpenHistory.ListBox1.Items.Add("App: Quick Logon Toggle Help | Using: Run")
        ElseIf TextBox1.Text = "help_qldisabled_fancy" Then
            AppOpenHistory.ListBox1.Items.Add("App: Quick Logon Disabled Help (Fancy) | Using: Run")
            QLDHelpFancy.Show()
        ElseIf TextBox1.Text = "cmd_about" Then
            AppOpenHistory.ListBox1.Items.Add("App: About FP CMD | Using: Run")
            cmd_about.Show()
        Else
            MsgBox("This program does not exist. Please press 'OK' to close this and try again.")
        End If
    End Sub

    Private Sub run_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class