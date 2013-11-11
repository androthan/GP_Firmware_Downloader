Public Class Form1

    '                                                                           '
    '  Name:                                                                    '
    '                                                                           '
    '    CommandShell.vb                                                        '
    '                                                                           '
    '  Description:                                                             '
    '                                                                           '
    '    GUI front end for a command line shell                                 '
    '                                                                           '
    '  Notes:                                                                   '
    '                                                                           '
    '    Type all the regular DOS commands in the text box input and they are   '
    '    executed with the results displayed in the top portion of the display. '
    '                                                                           '
    '  Audit:                                                                   '
    '                                                                           '

    Private WithEvents MyProcess As Process
    Private Delegate Sub AppendOutputTextDelegate(ByVal text As String)

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.AcceptButton = ExecuteButton

        MyProcess = New Process

        With MyProcess.StartInfo
            .FileName = "CMD.EXE"
            .UseShellExecute = False
            .CreateNoWindow = True
            .RedirectStandardInput = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With

        MyProcess.Start()

        MyProcess.BeginErrorReadLine()      'start async read on stderr
        MyProcess.BeginOutputReadLine()     'start async read on stdout

        AppendOutputText("Process Started at: " & MyProcess.StartTime.ToString)

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        MyProcess.StandardInput.WriteLine("EXIT") 'send an EXIT command to the Command Prompt
        MyProcess.StandardInput.Flush()
        MyProcess.Close()

    End Sub

    Private Sub MyProcess_ErrorDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles MyProcess.ErrorDataReceived

        AppendOutputText(vbCrLf & "Error: " & e.Data)

    End Sub

    Private Sub MyProcess_OutputDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles MyProcess.OutputDataReceived

        AppendOutputText(vbCrLf & e.Data)

    End Sub

    Private Sub ExecuteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExecuteButton.Click

        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = ""

    End Sub

    Private Sub AppendOutputText(ByVal text As String)

        If OutputTextBox.InvokeRequired Then
            Dim myDelegate As New AppendOutputTextDelegate(AddressOf AppendOutputText)
            Me.Invoke(myDelegate, text)
        Else
            OutputTextBox.AppendText(text)
        End If

    End Sub

End Class
