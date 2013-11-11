Public Class dpi_calculator

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A, B As Long
        A = TextBox1.Text
        B = A * 1
        MsgBox("DPI값=" & B)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim C, D As Long
        C = TextBox2.Text
        D = C * 1
        MsgBox("PX값=" & D)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim M, F As Double
        M = TextBox3.Text
        F = M * 0.666666
        MsgBox("DPI값=" & F)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim G, H As Double
        G = TextBox4.Text
        H = G / 0.666666
        MsgBox("PX값=" & H)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim I, J As Double
        I = TextBox5.Text
        J = I * 0.5
        MsgBox("DPI값=" & J)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim K, L As Double
        K = TextBox6.Text
        L = K / 0.5
        MsgBox("PX값=" & L)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim N, O As Double
        N = TextBox7.Text
        O = N * 1.33333
        MsgBox("PX값=" & O)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim P, Q As Double
        P = TextBox8.Text
        Q = P / 1.333333
        MsgBox("DPI값=" & Q)
    End Sub
End Class