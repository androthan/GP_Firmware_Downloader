Public Class Class3
    Public Shared Function recoverymodereboot()
        Dim recoveryrebootoption
        recoveryrebootoption = Shell("adb/adb.exe reboot recovery", vbHide)
        Return recoveryrebootoption
    End Function
End Class
