Imports savereseource1.Class1
Public Class localdown

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim saveFileDialog1 As New SaveFileDialog
        Dim location1 As String
        location1 = My.Computer.FileSystem.SpecialDirectories.Desktop
        saveFileDialog1.InitialDirectory = location1

        saveFileDialog1.Title = "저장하려는 위치를 지정하십시오"

        saveFileDialog1.CheckFileExists = True

        saveFileDialog1.CheckPathExists = True

        saveFileDialog1.DefaultExt = "7z"

        saveFileDialog1.Filter = "zip files (*.zip)|*.zip|7z files (*.7z)|*.7z"

        saveFileDialog1.FilterIndex = 2

        saveFileDialog1.RestoreDirectory = True

        Dim a, b, c, d, f As String
        a = My.Computer.FileSystem.SpecialDirectories.Desktop
        b = a & "\Odin3_07.7z"
        c = a & "\Odin3_v3.04.7z"
        d = a & "\odin3_v3.04_kor"
        f = a & "\Odin3-v1.85.zip"
        If RadioButton1.Checked = True Then
            'If System.IO.File.Exists(b) = False Then

            If (saveFileDialog1.ShowDialog() = DialogResult.OK) Then
                Dim o185 As String
                o185 = saveFileDialog1.FileName
                Save_reseourecs(o185, My.Resources.Odin3_v1_85)
                MsgBox(" 지정하신 경로로 압축파일이 저장되었습니다", vbInformation, "저장 완료")
                'ElseIf (saveFileDialog1.ShowDialog = DialogResult.Cancel) Then
            End If
            'Save_reseourecs(b, My.Resources.Odin3_07)

            'ElseIf System.IO.File.Exists(b) = True Then
            '    MsgBox(a & " 에 이미 저장되어 있습니다", vbInformation, "파일이 이미 존재합니다")
            'Else
            '    MsgBox("알 수 없는 오류입니다", vbCritical, "오류")

            'End If
        End If

        If RadioButton2.Checked = True Then
            If (saveFileDialog1.ShowDialog() = DialogResult.OK) Then
                Dim o304e As String
                o304e = saveFileDialog1.FileName
                Save_reseourecs(o304e, My.Resources.Odin3_v3_04)
                MsgBox(" 지정하신 경로로 압축파일이 저장되었습니다", vbInformation, "저장 완료")
                'ElseIf (saveFileDialog1.ShowDialog = DialogResult.Cancel) Then
            End If
            'If System.IO.File.Exists(c) = False Then
            '    Save_reseourecs(c, My.Resources.Odin3_v3_04)
            '    MsgBox(a & " 에 저장되었습니다", vbInformation, "저장 완료")
            'ElseIf System.IO.File.Exists(c) = True Then
            '    MsgBox(a & " 에 이미 저장되어 있습니다", vbInformation, "파일이 이미 존재합니다")
            'Else
            '    MsgBox("알 수 없는 오류입니다", vbCritical, "오류")
            'End If
        End If

        If RadioButton3.Checked = True Then
            If (saveFileDialog1.ShowDialog() = DialogResult.OK) Then
                Dim o304k As String
                o304k = saveFileDialog1.FileName
                Save_reseourecs(o304k, My.Resources.odin3_v3_04_kor)
                MsgBox("지정하신 경로로 압축파일이 저장되었습니다", vbInformation, "저장 완료")
                'ElseIf (saveFileDialog1.ShowDialog = DialogResult.Cancel) Then
            End If
            'If System.IO.File.Exists(d) = False Then
            '    Save_reseourecs(d, My.Resources.odin3_v3_04_kor)
            '    MsgBox(a & " 에 저장되었습니다", vbInformation, "저장 완료")
            'ElseIf System.IO.File.Exists(d) = True Then
            '    MsgBox(a & " 에 이미 저장되어 있습니다", vbInformation, "파일이 이미 존재합니다")
            'Else
            '    MsgBox("알 수 없는 오류입니다", vbCritical, "오류")
            'End If
        End If

        If RadioButton4.Checked = True Then
            If (saveFileDialog1.ShowDialog() = DialogResult.OK) Then
                Dim o307 As String
                o307 = saveFileDialog1.FileName
                Save_reseourecs(o307, My.Resources.Odin3_07)
                MsgBox(" 지정하신 경로로 압축파일이 저장되었습니다", vbInformation, "저장 완료")
                'ElseIf saveFileDialog1. DialogResult.Cancel) Then
            End If
            'If System.IO.File.Exists(f) = False Then
            '    Save_reseourecs(f, My.Resources.Odin3_v1_85)
            '    MsgBox(a & " 에 저장되었습니다", vbInformation, "저장 완료")
            'ElseIf System.IO.File.Exists(f) = True Then
            '    MsgBox(a & " 에 이미 저장되어 있습니다", vbInformation, "파일이 이미 존재합니다")
            'Else
            '    MsgBox("알 수 없는 오류입니다", vbCritical, "오류")
            'End If
        End If

        If RadioButton5.Checked = True Then
            MsgBox("추후에 추가될 예정입니다")
        End If
    End Sub

End Class