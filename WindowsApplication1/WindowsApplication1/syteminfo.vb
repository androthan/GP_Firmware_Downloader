Public Class syteminfo

    Private Sub syteminfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a, b, c, j As String
        Dim d, f, g, h As Double
        a = My.Computer.Info.OSFullName
        b = My.Computer.Info.OSVersion
        c = My.Computer.Info.OSPlatform
        d = My.Computer.Info.TotalPhysicalMemory
        f = My.Computer.Info.AvailablePhysicalMemory
        g = (d / 1048576)
        h = f / 1048576
        j = vbNullString

        Label1.Text = ("OS버전: " & a)
        Label2.Text = ("빌드번호: " & b)
        Label3.Text = ("플랫폼 네임: " & c)
        Label4.Text = ("총 시스템 메모리(Total RAM): " & g & "MB")
        Label5.Text = ("사용 가능한 메모리(Available RAM): " & h & "MB")
    End Sub
End Class