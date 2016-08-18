Public Class EngineObjects

    'Define all the classes as an object.
    Public ebox As New ErrorBox
    Public eboxfps As New ErrorBoxFPS
    Public fpthrow As New fpthrow
    Public math As New Math

    Public Sub mjrerr()
        ebox.error_FireplaceMajor()
    End Sub

    Public Sub mjrerrs()
        eboxfps.error_AppMajor()
    End Sub

    Public Sub warn()
        ebox.error_FireplaceWarning()
    End Sub

    Public Sub warns()
        eboxfps.error_AppWarning()
    End Sub

    Public Sub throw_mjrerr()
        fpthrow.throwFPCritical()
    End Sub

    Public Sub throw_mjrerrs()
        fpthrow.throwFPSCritical()
    End Sub

    Public Sub throw_warn()
        fpthrow.throwFPWarn()
    End Sub

    Public Sub throw_warns()
        fpthrow.throwFPSWarn()
    End Sub

    Public Sub throw_cmdNFnd()
        fpthrow.throwCmdNotFound()
    End Sub

    Public Sub cmdNtFnd()
        ebox.commandNotFound()
    End Sub

    Public Function add2(one As Integer, two As Integer) As Integer
        Return math.add2(one, two)
    End Function

    Public Function sub2(one As Integer, two As Integer) As Integer
        Return math.sub2(one, two)
    End Function

    Public Function div2(one As Integer, two As Integer) As Integer
        Return math.divide2(one, two)
    End Function

    Public Function times2(one As Integer, two As Integer) As Integer
        Return math.times2(one, two)
    End Function

    Public Sub fpsFeatureNotImplemented()
        eboxfps.error_FeatureNotYetAdded()
    End Sub

    Public Sub throwFpsFeatureNotFound()
        fpthrow.throwFPSFeatureNotFound()
    End Sub

    Public Sub e1X2T000()
        ebox.e1X2T000()
    End Sub

    Public Sub e1X1T000()
        ebox.e1X1T000()
    End Sub

    Public Sub e1Xneg1T000()
        ebox.e1Xneg1T000()
    End Sub

    Public Sub e1Xneg1T001()
        ebox.e1Xneg1T001()
    End Sub

    Public Sub fpFeatureNotFound()
        ebox.featureNotImplemented()
    End Sub

    Public Sub throwFpFeatureNotFound()
        fpthrow.throwFPSFeatureNotFound()
    End Sub

End Class