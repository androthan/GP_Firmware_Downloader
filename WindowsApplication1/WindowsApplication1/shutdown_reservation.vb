Public Class shutdown_reservation

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then normal_shutdown_reservation.Show()
        If RadioButton2.Checked Then Shell("shutdown -a")
    End Sub
End Class