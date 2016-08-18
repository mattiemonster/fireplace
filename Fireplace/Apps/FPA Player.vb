Public Class FPA_Player
    Public ibinput As String = "Input not set!"
    Public askshutdown As Boolean = True
    Public windowCreatedCount As Integer = 0
    Public windowOpened As Boolean = False
    Public windowCreated As Boolean = False
    Public frameTitle As String

    Dim frame As Form = New Form()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim reader As New IO.StreamReader(OpenFileDialog1.FileName)
        TextBox1.Text = reader.ReadToEnd
        reader.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(TextBox1.Lines)
        For i = 0 To ListBox1.Items.Count - 1
            Dim sstring As String = ListBox1.Items.Item(i)
            Dim sarray() As String = Split(sstring)

            If sarray(0) = "helloworld" Then
                MsgBox("Hello World")
            End If

            If sarray(0) = "message" Then
                If sarray.Length < 3 Then
                    MsgBox("Not enough data!", MsgBoxStyle.Critical, "Fireplace App Internal Error!")
                ElseIf sarray(1) = "" Then
                    MsgBox("Not enough data!", MsgBoxStyle.Critical, "Fireplace App Internal Error!")
                ElseIf sarray(2) = "" Then
                    MsgBox("Not enough data!", MsgBoxStyle.Critical, "Fireplace App Internal Error!")
                Else
                    MsgBox(sarray(1), , sarray(2))
                End If
            End If

            If sarray(0) = "errorbeep" Then
                Beep()
            End If

            If sarray(0) = "errorwin" Then
                ErrorWindow.Show()
            End If

            If sarray(0) = "error" Then
                Beep()
                ErrorWindow.Show()
            End If

            If sarray(0) = "ib" Then
                ibinput = InputBox("Input:", "Please enter your input")
                MsgBox("You entered:" + ibinput)
            End If

            If sarray(0) = "runcalc" Then
                Calc.Show()
                Calc.TopMost = True
                Calc.TopMost = False
            End If

            If sarray(0) = "console_echo" Then
                MsgBox(sarray(1))
            End If

            If sarray(0) = "fperror_critical" Then
                engine.mjrerr()
            End If

            If sarray(0) = "error_critical" Then
                engine.mjrerrs()
            End If

            If sarray(0) = "fperror_warn" Then
                engine.warn()
            End If

            If sarray(0) = "error_warn" Then
                engine.warns()
            End If

            If sarray(0) = "fpe_warn_notImplemented" Then
                engine.fpFeatureNotFound()
            End If

            If sarray(0) = "warn_notImplemented" Then
                engine.fpsFeatureNotImplemented()
            End If

            If sarray(0) = "fp_ver" Then
                fpVer.Show()
            End If

            If sarray(0) = "fps_ver" Then
                About.Show()
            End If

            If sarray(0) = "fps_about" Then
                About.Show()
            End If

            If sarray(0) = "fps_credit" Then
                Credits.Show()
            End If

            If sarray(0) = "fp_about" Then
                MoreIntroductionInfomation.Show()
            End If

            If sarray(0) = "fp_loginInfo" Then
                MoreIntroductionInfomation.Show()
            End If

            If sarray(0) = "fp_credit" Then
                Credits.Show()
            End If

            If sarray(0) = "fp_end" Then
                If askshutdown = True Then
                    ShutdownWarning.Show()
                Else
                    End
                End If
            End If

            If sarray(0) = "endfp" Then
                If askshutdown = True Then
                    ShutdownWarning.Show()
                Else
                    End
                End If
            End If

            If sarray(0) = "cwindow" Then
                frame = New Form()
                If sarray.Length = 5 Then
                    frame.SetBounds(sarray(1), sarray(2), sarray(3), sarray(4))
                Else
                    MsgBox("Argument mismatch - Only 4 arguments allowed.", MsgBoxStyle.Critical, "Internal App Error!")
                End If

            End If

            If sarray(0) = "cwindow_tick" Then
                MsgBox("The command 'cwindow_tick' is obsolete. Can cause problems. Using this command is not recommened and will be removed soon.", MsgBoxStyle.Exclamation, "Internal App Warning.")
                If Application.OpenForms().OfType(Of Form).Contains(frame) Then
                    windowOpened = True
                Else
                    windowOpened = False
                End If

                If frame.IsDisposed = False Then
                    windowCreated = True
                ElseIf frame.IsDisposed = True Then
                    windowCreated = False
                Else
                    MsgBox("Invalid disposed state!", MsgBoxStyle.Critical, "Internal App Error!")
                End If
            End If

            If sarray(0) = "cwindow_show" Then
                If windowOpened = True Then
                    Console.WriteLine("APP ERROR: WINDOW ALREADY OPENED")
                    Return
                End If

                frame.Show()
            End If

            If sarray(0) = "cwindow_setTitle" Then
                If sarray.Length < 2 Then
                    MsgBox("Argument mismatch - Not enough arguments!", MsgBoxStyle.Critical, "Internal App Error!")
                    Return
                ElseIf sarray.Length > 2 Then
                    MsgBox("Argument mismatch - Too many arguments!", MsgBoxStyle.Critical, "Internal App Error!")
                    Return
                ElseIf sarray(1) = " " Then
                    MsgBox("Argument mismatch - Not enough arguments!", MsgBoxStyle.Critical, "Internal App Error!")
                Else
                    frameTitle = sarray(1)
                    frame.Text = frameTitle
                End If
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class