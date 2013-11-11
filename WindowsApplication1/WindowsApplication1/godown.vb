Public Class krdl1

    Private Sub godown1_Click(sender As System.Object, e As System.EventArgs) Handles godown1.Click
        If (RadioButton1.Checked) Then ld1original.Show()
        If (RadioButton2.Checked) Then ld1rooting.Show()
        Close()
    End Sub
End Class