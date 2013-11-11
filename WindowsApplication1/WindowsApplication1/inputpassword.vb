Public Class inputpassword

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "I am developer 971119" Then
            dpi_calculator.Show()
            Close()
        Else
            MsgBox("암호가 틀렸습니다" + vbCrLf + "또한 개발자외에는 접근할 수 없습니다", vbCritical, "접근이 불가합니다")
        End If
    End Sub

    Private Sub inputpassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox1.PasswordChar = "●"
    End Sub
End Class