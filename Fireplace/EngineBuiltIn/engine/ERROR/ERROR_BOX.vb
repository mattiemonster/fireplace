﻿Public Class ERROR_BOX
    Public Shared Sub error_FireplaceMajor()
        MsgBox("1X2T000 - Fireplace encountered a critical error; threw 'error_FireplaceMajor'. No description of error given! Fireplace may be forcefully shutdown.", MsgBoxStyle.Critical, "Fireplace Critical Error Message - 1X2T000")
    End Sub

    Public Shared Sub e1X2T000()
        MsgBox("ERROR 1X2T000", MsgBoxStyle.Critical, "1X2T000")
    End Sub

    Public Shared Sub error_FireplaceWarning()
        MsgBox("1X1T000 - Fireplace has encountered a error; threw 'error_FireplaceWarning'. No description of warning given!", MsgBoxStyle.Exclamation, "Fireplace Warning Message - 1X1T000")
    End Sub

    Public Shared Sub e1X1T000()
        MsgBox("ERROR 1X1T000", MsgBoxStyle.Exclamation, "1X1T000")
    End Sub

    Public Shared Sub commandNotFound()
        MsgBox("1X-1T000 - The command that you tried to execute was not found or did not work.", MsgBoxStyle.Exclamation, "1X-1T000")
    End Sub

    Public Shared Sub e1Xneg1T000()
        MsgBox("ERROR 1X-1T000", MsgBoxStyle.Exclamation, "1X-1T000")
    End Sub

    Public Shared Sub featureNotImplemented()
        MsgBox("1X-1T001 - The feature you tried to use in Fireplace has not yet been implemented.", MsgBoxStyle.Information, "1X-1T001")
    End Sub

    Public Shared Sub e1Xneg1T001()
        MsgBox("ERROR 1X-1T001", MsgBoxStyle.Exclamation, "1X-1T001")
    End Sub

    Public Shared Sub quickLoginDisabled()
        MsgBox("ERROR 1X-1T002", MsgBoxStyle.Critical, "1X-1T002")
    End Sub

    Public Shared Sub e1Xneg1T002()
        MsgBox("ERROR 1X-1T002", MsgBoxStyle.Critical, "1X-1T002")
    End Sub
End Class