Public Class 갤플42krld2choose

    Private Sub 갤플42krld2choose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As String
        a = "ALL made by hwang씨(imscs21)"
        ToolStripStatusLabel1.Text = a
    End Sub

    Private Sub 갤플42krld2choose_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim a As String
        a = "ALL made by hwang씨(imscs21)"
        ToolStripStatusLabel1.Text = a
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            ld2stockecker.Show()
            Me.Close()
        End If
        If RadioButton2.Checked = True Then
            If MsgBox("이 펌웨어는 삼성에서 정식으로 배포한 커널이 아닌 추출된 커널이 들어있습니다" + vbCrLf + "따라서 루팅카운터가 올라갈 수 있습니다" + vbCrLf + "해외펌을 적용중이신 분은 무조건 커널을 적용해야합니다" + vbCrLf + "정말로 다운하시겠습니까?(확인을 누르면 다운로드창으로 이동합니다)", MsgBoxStyle.OkCancel, "정말로 다운로드하시겠습니까?") = MsgBoxResult.Ok Then
                ld2stockwithker.Show()
                Me.Close()
            Else

            End If
        End If
        If RadioButton3.Checked = True Then
            ld2rootexker.Show()
            Me.Close()
        End If
        If RadioButton4.Checked = True Then
            If MsgBox("이 펌웨어는 삼성에서 정식으로 배포한 커널이 아닌 추출된 커널이 들어있습니다" + vbCrLf + "따라서 루팅카운터가 올라갈 수 있습니다" + vbCrLf + "해외펌을 적용중이신 분은 무조건 커널을 적용해야합니다" + vbCrLf + "정말로 다운하시겠습니까?(확인을 누르면 다운로드창으로 이동합니다)", MsgBoxStyle.OkCancel, "정말로 다운로드하시겠습니까?") = MsgBoxResult.Ok Then
                ld2rootwithker.Show()
                Me.Close()
            Else

            End If
        End If
        If RadioButton5.Checked = True Then
            If MsgBox("이 커널은 삼성에서 정식으로 배포한 커널이 아닌 추출된 커널입니다" + vbCrLf + "따라서 적용시 루팅카운터가 올라갈 수 있습니다" + vbCrLf + "해외펌을 적용중이신 분은 무조건 커널을 적용해야하시만 국내펌이신 분들은 굳이 적용하실 필요가 없습니다" + vbCrLf + "정말로 다운하시겠습니까?(확인을 누르면 다운로드창으로 이동합니다)", MsgBoxStyle.OkCancel, "정말로 다운로드하시겠습니까?") = MsgBoxResult.Ok Then
                Shell("explorer http://hsh97.tistory.com/attachment/cfile9.uf@236AF33851975A1C2F1412.tar")
                Me.Close()
            Else
            End If
        End If
    End Sub
End Class