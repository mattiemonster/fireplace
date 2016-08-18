Public Class engine
    'Define all the classes as an object.
    Public ebox As New ERROR_BOX
    Public eboxfps As New ERROR_BOX_FPS
    Public fpthrow As New ERROR_THROW
    Public math As New MATH

    Public Shared Sub mjrerr()
        ERROR_BOX.error_FireplaceMajor()
    End Sub

    Public Shared Sub mjrerrs()
        ERROR_BOX_FPS.error_AppMajor()
    End Sub

    Public Shared Sub warn()
        ERROR_BOX.error_FireplaceWarning()
    End Sub

    Public Shared Sub warns()
        ERROR_BOX_FPS.error_AppWarning()
    End Sub

    Public Shared Sub throw_mjrerr()
        ERROR_THROW.throwFPCritical()
    End Sub

    Public Shared Sub throw_mjrerrs()
        ERROR_THROW.throwFPSCritical()
    End Sub

    Public Shared Sub throw_warn()
        ERROR_THROW.throwFPWarn()
    End Sub

    Public Shared Sub throw_warns()
        ERROR_THROW.throwFPSWarn()
    End Sub

    Public Shared Sub throw_cmdNFnd()
        ERROR_THROW.throwCmdNotFound()
    End Sub

    Public Shared Sub cmdNtFnd()
        ERROR_BOX.commandNotFound()
    End Sub

    Public Shared Function add2(one As Integer, two As Integer) As Integer
        Return MATH.add2(one, two)
    End Function

    Public Shared Function sub2(one As Integer, two As Integer) As Integer
        Return MATH.sub2(one, two)
    End Function

    Public Shared Function div2(one As Integer, two As Integer) As Integer
        Return MATH.divide2(one, two)
    End Function

    Public Shared Function times2(one As Integer, two As Integer) As Integer
        Return MATH.times2(one, two)
    End Function

    Public Shared Sub fpsFeatureNotImplemented()
        ERROR_BOX_FPS.error_FeatureNotYetAdded()
    End Sub

    Public Shared Sub throwFpsFeatureNotFound()
        ERROR_THROW.throwFPSFeatureNotFound()
    End Sub

    Public Shared Sub e1X2T000()
        ERROR_BOX.e1X2T000()
    End Sub

    Public Shared Sub e1X1T000()
        ERROR_BOX.e1X1T000()
    End Sub

    Public Shared Sub e1Xneg1T000()
        ERROR_BOX.e1Xneg1T000()
    End Sub

    Public Shared Sub e1Xneg1T001()
        ERROR_BOX.e1Xneg1T001()
    End Sub

    Public Shared Sub fpFeatureNotFound()
        ERROR_BOX.featureNotImplemented()
    End Sub

    Public Shared Sub throwFpFeatureNotFound()
        ERROR_THROW.throwFPFeatureNotFound()
    End Sub

    Public Shared Sub throwFpsWindowAlreadyCreated()
        ERROR_THROW.throwFPSWindowAlreadyCreated()
    End Sub

    Public Shared Sub FpsWindowAlreadyCreated()
        ERROR_BOX_FPS.windowAlreadyCreated()
    End Sub

    Public Shared Sub throw0X2T002()
        ERROR_BOX_FPS.windowAlreadyCreated()
    End Sub
End Class