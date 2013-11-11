Public Class odinallversion

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            Shell("explorer http://hsh97.tistory.com/attachment/cfile23.uf@2001613B4F79ABCE14343C.zip")
        End If
        If RadioButton2.Checked Then
            Shell("explorer http://hsh97.tistory.com/attachment/cfile6.uf@111639494FCF590B29F3FF.7z")
        End If
        If RadioButton3.Checked Then
            Shell("explorer http://hsh97.tistory.com/attachment/cfile8.uf@1676934F4FD59C772E3FA3.zip")
        End If
        If RadioButton4.Checked Then
            Shell("explorer http://hsh97.tistory.com/attachment/cfile25.uf@184E38395085152C0D85CD.7z")
        End If
        If RadioButton5.Checked Then
            MsgBox("추후에 추가될 예정입니다", vbInformation, "추가 예정")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        localdown.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        odinnowrun.Show()
        Me.Close()
    End Sub
End Class