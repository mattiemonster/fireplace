Public Class ERROR_THROW
    Public Shared Sub throwFPCritical()
        MsgBox("1X2T000 - Fireplace encountered a critical error; threw 'error_FireplaceMajor'. No description of error given! Fireplace may be forcefully shutdown.", MsgBoxStyle.Critical, "Fireplace Critical Error Message - 1X2T000")
    End Sub

    Public Shared Sub throwFPSCritical()
        MsgBox("ERROR 0X3T003 - The current app encountered a critical error (3T); threw 'error_AppMajor'. No description of error given! The app may be forcefully shutdown.", MsgBoxStyle.Critical, "Fireplace Script App Critical Error Message")
    End Sub

    Public Shared Sub throwFPWarn()
        MsgBox("1X1T000 - Fireplace has encountered a error; threw 'error_FireplaceWarning'. No description of warning given!", MsgBoxStyle.Exclamation, "Fireplace Warning Message - 1X1T000")
    End Sub

    Public Shared Sub throwFPSWarn()
        MsgBox("ERROR 0X1T002 - The current app has encountered a error  (1T); threw 'error_AppWarning'. No description of warning given!", MsgBoxStyle.Exclamation, "App Warning Message")
    End Sub

    Public Shared Sub throwCmdNotFound()
        MsgBox("1X-1T000 - The command that you tried to execute was not found or did not work.", MsgBoxStyle.Exclamation, "1X-1T000")
    End Sub

    Public Shared Sub throwFPSFeatureNotFound()
        MsgBox("ERROR 0X-1T000 - App Error: Feature Not Yet Added!", MsgBoxStyle.Information, "DANG IT! - 0X-1T000")
    End Sub

    Public Shared Sub throwFPFeatureNotFound()
        MsgBox("1X-1T001 - The feature you tried to use in Fireplace has not yet been implemented.", MsgBoxStyle.Information, "DANG IT! - 1X-1T001")
    End Sub

    Public Shared Sub throwFPSWindowAlreadyCreated()
        MsgBox("ERROR 0X2T002 - Internal App Error: Window Already Created!", MsgBoxStyle.Critical, "DANG IT! - 0X2T002")
    End Sub

    Public Shared Sub throwQuickLogonDisabled()
        MsgBox("ERROR 1X-1T002 - Quick Logon is disabled. You must logon using the alternative method to be able to enable it.", MsgBoxStyle.Critical, "DANG IT! - 1X-1T002")
    End Sub
End Class