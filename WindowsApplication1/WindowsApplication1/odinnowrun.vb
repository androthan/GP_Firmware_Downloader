Public Class odinnowrun

    Private Sub odinnowrun_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Shell("odin/Odin3-v1.85/Odin3_v1.85.exe")
        End If
        If RadioButton2.Checked = True Then

        End If
        If RadioButton3.Checked = True Then

        End If
        If RadioButton4.Checked = True Then
            Shell("odin/Odin3.07/Odin3_v3.07.exe")
        End If
        If RadioButton5.Checked = True Then
            MsgBox("추후에 추가될 예정입니다")
        End If
    End Sub
End Class