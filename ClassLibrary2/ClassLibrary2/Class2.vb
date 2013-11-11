Public Class Class2
    Public Shared Function downloadmodereboot()
        Dim downloadrebootoption
        downloadrebootoption = Shell("adb/adb.exe reboot download", vbHide)
        Return downloadrebootoption
    End Function
End Class
