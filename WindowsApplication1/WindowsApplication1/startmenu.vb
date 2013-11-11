Imports WinHttp

Public Class startmenu
    Public WinHttp As New WinHttpRequest
    Public update_new As String
    Public nowversion As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "갤럭시 플레이어3.6(YP-GS1)" Then
            Form1.Show()
            Me.Close()
        Else
            If ComboBox1.Text = "갤럭시 플레이어4.2(YP-GI1)" Then
                갤플4.Show()
                Me.Close()
            End If
        End If
        If ComboBox1.SelectedIndex = 0 Then
            MsgBox("하위의 기기목록을 이용해 선택해주세요")
        End If
        If ComboBox1.Text = "갤럭시 플레이어 4.0(?) (YP-GB1)" Then
            MsgBox("추가될 예정입니다", vbInformation, "준비중입니다")
        End If
        If ComboBox1.Text = "갤럭시 플레이어 70+ (YP-GB70ED)" Then
            갤플70.Show()
            Me.Close()
            'MsgBox("추가될 예정입니다", vbInformation, "준비중입니다")
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub
    Private Sub startmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim check1 As String
        check1 = My.Computer.Info.OSFullName.ToString
        On Error GoTo err1
        ComboBox1.SelectedIndex = 0
        'Label2.Text = check1
        ' If InStr(check1, "XP") > 0 Then
        If My.Computer.Network.IsAvailable = True Then
            If InStr(check1, "XP") > 0 Then
                ' WinHttp.Open("GET", "http://hsh97.dothome.co.kr/galnum.txt")
                WinHttp.Open("GET", "http://hsh97.dothome.co.kr/(xp)galversion.txt")
                'WinHttp.Open("GET", "http://hsh97.allalla.com/galversion.txt")
                WinHttp.Send()
                update_new = WinHttp.ResponseText
            Else
                'WinHttp.Open("GET", "http://hsh97.dothome.co.kr/galnum.txt")
                WinHttp.Open("GET", "http://hsh97.dothome.co.kr/galversion.txt")
                'WinHttp.Open("GET", "http://hsh97.allalla.com/galversion.txt")
                WinHttp.Send()
                update_new = WinHttp.ResponseText
            End If
            nowversion = My.Application.Info.Version.ToString '"3.0.15.0000"
            If update_new = nowversion Then

            ElseIf update_new < nowversion Then
                MsgBox("하위버전")
            ElseIf update_new > nowversion Then
                updateform.Show()
            Else

            End If
        Else
        End If
        If System.IO.File.Exists("gmswait.dll") = True Then
        ElseIf System.IO.File.Exists("gmswait.dll") = False Then
            MsgBox("프로그램을 구성하는 일부 파일이 존재하지 않습니다" + vbCrLf + "파일이 모두 있는지 확인하시고 없다면 재설치해주세요", vbCritical)
            Me.Close()
        End If
        'Else
        '    MsgBox("윈도우xp에서만 실행될수있습니다" + vbCrLf + "따라서 프로그램을 종료합니다", vbCritical, "For xp")
        '    Me.Close()
        'End If
        Exit Sub
err1:   MsgBox("알 수 없는 오류가 발생하였습니다" + vbCrLf + "따라서 자동업데이트를 중단합니다", vbCritical, "오류가 발생했습니다")
    End Sub
    Public Function apppath()
        Dim app_path As String
        Dim Cpo As Integer

        app_path = System.Reflection.Assembly.GetExecutingAssembly.Location
        Cpo = InStrRev(app_path, "\")
        app_path = app_path.Substring(0, Cpo)
        Return app_path
    End Function
    Private Sub save_resource(ByVal FilePath As String, ByVal File As Object)
        Dim FByte() As Byte = File
        My.Computer.FileSystem.WriteAllBytes(FilePath, FByte, True)
    End Sub
End Class