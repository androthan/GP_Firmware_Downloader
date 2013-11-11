Imports ClassLibrary1.Class1
Imports ClassLibrary2.Class1
Imports ClassLibrary2.checkdebuger
Imports ClassLibrary2.Class2
Imports ClassLibrary2.Class3
Imports ClassLibrary2.string1
Imports ClassLibrary2.string2

Public Class Form1

    Private Sub orginalfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles orginalfirm.Click
        krdl1.Show()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AboutBox1.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        lh4choose.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MsgBox(howtogodown() + vbCrLf + howtogorecovery(), vbInformation, "리커버리 혹은 다운로드모드 들어가는 법")
        'MsgBox("다운로드 들어가는 법: 전원 off 상태에서 홈키+볼륨하키+전원" + vbCrLf + "리커버리 들어가는 법: 전원 off 상태에서 홈키+볼륨상키+전원", vbInformation, "리커버리 혹은 다운로드모드 들어가는 법")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Shell("explorer http://down2.local.sec.samsung.com/uploadimg2/comLocal/service/support/download/sw/KiesSetup.exe")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Shell("explorer http://down2.local.sec.samsung.com/uploadimg2/comLocal/service/support/consumer/download/SAMSUNG_USB_Driver_for_Mobile_Phones.zip")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        startmenu.Show()
        Me.Close()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        etcfunction.Show()
    End Sub

    Private Sub 프로그램정보ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 프로그램정보ToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub 리붓옵션ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 리붓옵션ToolStripMenuItem.Click
        adbmain.Show()
    End Sub

    Private Sub 기기선택창가기ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 기기선택창가기ToolStripMenuItem.Click
        startmenu.Show()
        Close()
    End Sub

    Private Sub Usb디버깅이체크확인ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Usb디버깅이체크확인ToolStripMenuItem.Click
        'MsgBox("기능을 사용하시기전 환경설정-애플리케이션-개발-USB 디버깅에 체크되어있는지 확인해 주십시오", vbInformation, "USB디버깅 체킹 유무확인 바람")
        MsgBox(pleasecheckdebuger, vbInformation, "USB디버깅 체킹 유무확인 바람")
    End Sub

    Private Sub 추가예정ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles 추가예정ToolStripMenuItem2.Click
        MsgBox(waitmsgdll, vbInformation, "추가예정")
    End Sub

    Private Sub 추가예정ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 추가예정ToolStripMenuItem1.Click
        MsgBox(waitmsgdll, vbInformation, "추가예정")
    End Sub

    Private Sub 일반재부팅ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 일반재부팅ToolStripMenuItem.Click
        normalreboot()
        'Shell("adb/adb.exe reboot", vbHide)
        MsgBox("일반 모드로 재부팅 중입니다 잠시만 기다려 주십시오...", vbInformation, "잠시만 기다려 주십시오")
    End Sub

    Private Sub 리커버리모드로재부팅ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 리커버리모드로재부팅ToolStripMenuItem.Click
        recoverymodereboot()
        'Shell("adb/adb.exe reboot recovery", vbHide)
        MsgBox("리커버리 모드로 재부팅 중입니다 잠시만 기다려 주십시오...", vbInformation, "잠시만 기다려 주십시오")
    End Sub

    Private Sub 다운로드모드로재부팅ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 다운로드모드로재부팅ToolStripMenuItem.Click
        downloadmodereboot()
        'Shell("adb/adb.exe reboot download", vbHide)
        MsgBox("다운로드 모드로 재부팅 중입니다 잠시만 기다려 주십시오...", vbInformation, "잠시만 기다려 주십시오")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        odinallversion.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox(waitmsgdll, vbInformation, "추가예정")
    End Sub

    Private Sub 시스템정보ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 시스템정보ToolStripMenuItem.Click
        syteminfo.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        adbmain.Show()
    End Sub
End Class