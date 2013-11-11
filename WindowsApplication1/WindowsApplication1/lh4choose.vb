Public Class lh4choose

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If (RadioButton1.Checked) Then lh4origin.Show()
        If (RadioButton2.Checked) Then lh4rooting.Show()
        Close()
    End Sub
End Class