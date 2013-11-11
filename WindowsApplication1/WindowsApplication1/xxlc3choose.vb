Public Class xxlc3choose

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RadioButton3.Checked) Then
            'Shell("explorer http://ka.do/T6x")
            Shell("explorer http://hsh97.tistory.com/attachment/cfile27.uf@1313284650BDE07A0FF14D.tar", vbHide)
        End If
        If (radio1.Checked) Then
            lc3stock.Show()
            Me.Close()
        End If
        If (RadioButton2.Checked) Then
            lc3rooting.Show()
            'Me.Close()
            Close()
        End If
        If (RadioButton1.Checked) Then
            lc3fulldeodexed.Show()
            Me.Close()
        End If
    End Sub
End Class