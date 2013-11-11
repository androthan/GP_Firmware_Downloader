Imports WinHttp
Imports System.Text
Imports System.IO
Imports System.Net
Imports System.Version



Public Class updateform

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Shell("explorer http://hsh97.dothome.co.kr/galaxyplayerfirmwaredownloader.exe")
        If InStr(Label3.Text, "XP") > 0 Then
            Shell("explorer http://hsh97.dothome.co.kr/(forxp)galaxyplayerfirmwaredownloader.exe")
        Else
            Shell("explorer http://hsh97.allalla.com/galaxyplayerfirmwaredownloader.exe")
        End If
        startmenu.Close()
        Close()
    End Sub

    Dim WinHTTP As New WinHttp.WinHttpRequest

    Private Sub updateform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As String
        a = My.Computer.Info.OSFullName.ToString
        If InStr(a, "XP") > 0 Then
            Dim wReq As WebRequest = WebRequest.Create("http://hsh97.dothome.co.kr/(xp)galupdateinformation.txt")
            Dim wResp As WebResponse = wReq.GetResponse
            Dim RespStream As System.IO.Stream = wResp.GetResponseStream
            Dim Reader As System.IO.StreamReader = New System.IO.StreamReader(RespStream, System.Text.Encoding.UTF8)
            Dim RespHTML As String = Reader.ReadToEnd
            TextBox1.Text = RespHTML
        Else
            'WinHTTP.Open("GET", "http://hsh97.allalla.com/galupdateinformation.txt")
            'WinHTTP.Send()
            'TextBox1.Text = WinHTTP.ResponseText
            Dim wReq As WebRequest = WebRequest.Create("http://hsh97.dothome.co.kr/galupdateinformation.txt")
            Dim wResp As WebResponse = wReq.GetResponse
            Dim RespStream As System.IO.Stream = wResp.GetResponseStream
            Dim Reader As System.IO.StreamReader = New System.IO.StreamReader(RespStream, System.Text.Encoding.UTF8)
            Dim RespHTML As String = Reader.ReadToEnd
            TextBox1.Text = RespHTML
        End If
        'Dim wResp As WebResponse = wReq.GetResponse
        'Dim RespStream As System.IO.Stream = wResp.GetResponseStream
        'Dim Reader As System.IO.StreamReader = New System.IO.StreamReader(RespStream, System.Text.Encoding.UTF8)
        'Dim RespHTML As String = Reader.ReadToEnd
        'TextBox1.Text = RespHTML
        Label2.Text = String.Format("현재버전: {0}", My.Application.Info.Version.ToString)
        'Label2.Text = "현재 버전: 3.0.0.2002"
        Label3.Text = My.Computer.Info.OSFullName
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a, b, c, d, f As String
        a = My.Computer.FileSystem.SpecialDirectories.Desktop
        c = "G.p.f.d_installer.exe"
        b = a & "\" & c
        d = "(forxp)G.p.f.d_installer.exe"
        f = a & "\" & d
        If InStr(Label3.Text, "XP") > 0 Then
            If System.IO.File.Exists(f) = True Then
                Kill(f)
                My.Computer.Network.DownloadFile("http://hsh97.allalla.com/(forxp)G.p.f.d_installer.exe", f, vbNullString, vbNullString, True, 2000, True, UICancelOption.DoNothing)
                    'My.Computer.Network.DownloadFile("http://hsh97.allalla.com/(forxp)galaxyplayerfirmwaredownloader.exe", f, vbNullString, vbNullString, True, 2000, True, UICancelOption.DoNothing)
                    If CheckBox1.Checked = True Then
                        MsgBox(a & "에 " & f & " 라는 이름으로 설치파일이 저장되었습니다" + vbCrLf + "자동으로 설치파일을 실행합니다", vbInformation)
                    ' Shell(b)
                    If System.IO.File.Exists(f) = True Then
                        Shell(f)
                    ElseIf System.IO.File.Exists(f) = False Then
                        MsgBox("파일이 없어 실행할수없습니다" + vbCrLf + "백신에 의해 설치프로그램이 삭제되었거나 사용자께서 임의로 파일을 삭제하신것같습니다" + vbCrLf + "백신에 의해 차단된경우 백신을 임시로 꺼주시고 임의로 삭제하신 것이라면 다시 다운하셔서 설치하시기를 바라겠습니다", vbCritical, "실행될 수 없습니다")
                    Else
                        MsgBox("알 수 없는  오류가 발생하였습니다")
                    End If
                    Else
                        MsgBox(a & "에 " & f & " 라는 이름으로 설치파일이 저장되었습니다" + vbCrLf + "프로그램을 종료하시고 설치파일을 실행해 수동설치해주세요" + vbCrLf + "추후에 설치파일을 원하는 경로에 다운로드되게 할수있도록 할 예정입니다", vbInformation, "다운이 완료되었습니다")
                    End If
            ElseIf System.IO.File.Exists(b) = False Then
                    My.Computer.Network.DownloadFile("http://hsh97.allalla.com/(forxp)G.p.f.d_installer.exe", f, vbNullString, vbNullString, True, 2000, True, UICancelOption.DoNothing)
                    'My.Computer.Network.DownloadFile("http://hsh97.allalla.com/(forxp)galaxyplayerfirmwaredownloader.exe", f, vbNullString, vbNullString, True, 2000, True, UICancelOption.DoNothing)
                    If CheckBox1.Checked = True Then
                        MsgBox(a & "에 " & f & " 라는 이름으로 설치파일이 저장되었습니다" + vbCrLf + "자동으로 설치파일을 실행합니다", vbInformation)
                        Shell(b)
                    Else
                        MsgBox(a & "에 " & f & " 라는 이름으로 설치파일이 저장되었습니다" + vbCrLf + "프로그램을 종료하시고 설치파일을 실행해 수동설치해주세요" + vbCrLf + "추후에 설치파일을 원하는 경로에 다운로드되게 할수있도록 할 예정입니다", vbInformation, "다운이 완료되었습니다")
                    End If
            Else
                    MsgBox("알수없는 오류로 다운로드를 진행할 수 없습니다" + vbCrLf + "왼쪽의 수동다운로드 버튼을 눌러 다운해주시거나 블로그를 방문해주세요", vbCritical)
            End If
        'Else
        If System.IO.File.Exists(b) = True Then
            Kill(b)
            My.Computer.Network.DownloadFile("http://hsh97.allalla.com/G.p.f.d_installer.exe", b, vbNullString, vbNullString, True, 2000, True, UICancelOption.DoNothing)
            'My.Computer.Network.DownloadFile("http://hsh97.allalla.com/galaxyplayerfirmwaredownloader.exe", b, vbNullString, vbNullString, True, 2000, True, UICancelOption.DoNothing)
            If CheckBox1.Checked = True Then
                MsgBox(a & "에 " & c & " 라는 이름으로 설치파일이 저장되었습니다" + vbCrLf + "자동으로 설치파일을 실행합니다", vbInformation)
                If System.IO.File.Exists(b) = True Then
                    Shell(b)
                ElseIf System.IO.File.Exists(b) = False Then
                    MsgBox("파일이 없어 실행할수없습니다" + vbCrLf + "백신에 의해 설치프로그램이 삭제되었거나 사용자께서 임의로 파일을 삭제하신것같습니다" + vbCrLf + "백신에 의해 차단된경우 백신을 임시로 꺼주시고 임의로 삭제하신 것이라면 다시 다운하셔서 설치하시기를 바라겠습니다", vbCritical, "실행될 수 없습니다")
                Else
                    MsgBox("알 수 없는  오류가 발생하였습니다")
                End If
                Else
                    MsgBox(a & "에 " & c & " 라는 이름으로 설치파일이 저장되었습니다" + vbCrLf + "프로그램을 종료하시고 설치파일을 실행해 수동설치해주세요" + vbCrLf + "추후에 설치파일을 원하는 경로에 다운로드되게 할수있도록 할 예정입니다", vbInformation, "다운이 완료되었습니다")
            End If
        ElseIf System.IO.File.Exists(b) = False Then
            My.Computer.Network.DownloadFile("http://hsh97.allalla.com/G.p.f.d_installer.exe", b, vbNullString, vbNullString, True, 2000, True, UICancelOption.DoNothing)
            'My.Computer.Network.DownloadFile("http://hsh97.allalla.com/galaxyplayerfirmwaredownloader.exe", b, vbNullString, vbNullString, True, 2000, True, UICancelOption.DoNothing)
            If CheckBox1.Checked = True Then
                MsgBox(a & "에 " & c & " 라는 이름으로 설치파일이 저장되었습니다" + vbCrLf + "자동으로 설치파일을 실행합니다", vbInformation)
                Shell(b)
            Else
                MsgBox(a & "에 " & c & " 라는 이름으로 설치파일이 저장되었습니다" + vbCrLf + "프로그램을 종료하시고 설치파일을 실행해 수동설치해주세요" + vbCrLf + "추후에 설치파일을 원하는 경로에 다운로드되게 할수있도록 할 예정입니다", vbInformation, "다운이 완료되었습니다")
            End If
        Else
            MsgBox("알수없는 오류로 다운로드를 진행할 수 없습니다" + vbCrLf + "왼쪽의 수동다운로드 버튼을 눌러 다운해주시거나 블로그를 방문해주세요", vbCritical)
        End If
        End If
    End Sub
End Class