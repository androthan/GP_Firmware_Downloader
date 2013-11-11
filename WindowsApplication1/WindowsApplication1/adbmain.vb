Imports ClassLibrary2.Class1
Imports ClassLibrary2.Class2
Imports ClassLibrary2.Class3

Public Class adbmain

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        normalreboot()
        MsgBox("일반으로 재부팅중입니다, 잠시만 기다려주십시오")
    End Sub

    Private Sub adbmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Shell("adb/adb.exe start-server")
        'pleasewait.Show()
        'Shell("devices.bat", vbHide)
        Shell("devices.exe", vbHide)
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub adbmain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Kill("temp1.tmp")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim f As New System.IO.StreamReader("temp1.tmp")
        Dim a As String
        a = f.ReadToEnd()
        TextBox1.Text = a
        f.Close()
        'f.Dispose()
        Timer1.Stop()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        recoverymodereboot()
        MsgBox("리커버리 모드로 재부팅중입니다, 잠시만 기다려주십시오")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        downloadmodereboot()
        MsgBox("다운로드모드로 재부팅중입니다, 잠시만 기다려주십시오")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'TextBox1.Text = ""
        Kill("temp1.tmp")
        Shell("refreshdevices.exe")
        Timer1.Enabled = True
        Timer1.Start()
    End Sub
End Class