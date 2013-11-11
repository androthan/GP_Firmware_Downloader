Public Class normal_shutdown_reservation

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim A, B, C, D As Long
        'A = Val(NumericUpDown1.Text) * 3600
        'B = Val(TextBox2.Text) * 60
        'C = Val(TextBox3.Text)
        'D = A + B + C
        'Shell("shutdown -s -t" & A)
        Dim app_path As String
        Dim Cpo As Integer

        app_path = System.Reflection.Assembly.GetExecutingAssembly.Location
        Cpo = InStrRev(app_path, "\")
        app_path = app_path.Substring(0, Cpo)
        Shell("cd", "" & app_path)
    End Sub
End Class