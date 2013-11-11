Public Class Class1
    Public Shared Function normalreboot()
        Dim normalrebootoption
        normalrebootoption = Shell("adb/adb.exe reboot", vbHide)
        Return normalrebootoption
    End Function
End Class
