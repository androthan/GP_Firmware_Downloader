Public Class etcfunction

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then inputpassword.Show()
        If RadioButton2.Checked Then shutdown_reservation.Show()
    End Sub
End Class