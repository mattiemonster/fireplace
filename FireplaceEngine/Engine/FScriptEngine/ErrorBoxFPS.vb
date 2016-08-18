Public Class ErrorBoxFPS

    Public t_internal As Integer = 2
    Public t_warn As Integer = 1
    Public t_critical As Integer = 3
    Public t_error As Integer = -1
    Public success As Integer = 0

    '0X* = An error encourntered in a FP script app.

    Public Sub error_AppMajor()
        MsgBox("ERROR 0X3T003 - The current app encountered a critical error (3T); threw 'error_AppMajor'. No description of error given! The app may be forcefully shutdown.", MsgBoxStyle.Critical, "Fireplace Script App Critical Error Message")
    End Sub

    Public Sub error_AppWarning()
        MsgBox("ERROR 0X1T002 - The current app has encountered a error  (1T); threw 'error_AppWarning'. No description of warning given!", MsgBoxStyle.Exclamation, "App Warning Message")
    End Sub

    Public Sub commandNotFoundApp()
        MsgBox("ERROR 0X2T001 - Internal App Error (2T): The command was not found!", MsgBoxStyle.Exclamation, "Uh oh.")
    End Sub

    Public Sub error_FeatureNotYetAdded()
        MsgBox("ERROR 0X1T000 - App Error: Feature Not Yet Added!", MsgBoxStyle.Information, "DANG IT! - 0X-1T000")
    End Sub

End Class