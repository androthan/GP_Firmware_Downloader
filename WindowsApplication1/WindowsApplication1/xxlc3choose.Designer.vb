<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xxlc3choose
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.group1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.radio1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.group1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(160, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 102)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "다운하러 가기"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'group1
        '
        Me.group1.Controls.Add(Me.RadioButton1)
        Me.group1.Controls.Add(Me.radio1)
        Me.group1.Controls.Add(Me.RadioButton2)
        Me.group1.Controls.Add(Me.RadioButton3)
        Me.group1.Location = New System.Drawing.Point(12, 12)
        Me.group1.Name = "group1"
        Me.group1.Size = New System.Drawing.Size(140, 107)
        Me.group1.TabIndex = 6
        Me.group1.TabStop = False
        Me.group1.Text = "펌웨어"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 63)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(121, 16)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "LC3 풀디오덱스펌"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'radio1
        '
        Me.radio1.AutoSize = True
        Me.radio1.Location = New System.Drawing.Point(6, 20)
        Me.radio1.Name = "radio1"
        Me.radio1.Size = New System.Drawing.Size(101, 16)
        Me.radio1.TabIndex = 0
        Me.radio1.TabStop = True
        Me.radio1.Text = "XXLC3 순정펌"
        Me.radio1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(101, 16)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "XXLC3 루팅펌"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 85)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(109, 16)
        Me.RadioButton3.TabIndex = 5
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "해외 커널(공용)"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'xxlc3choose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(254, 126)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.group1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "xxlc3choose"
        Me.ShowIcon = False
        Me.Text = "XXLC3 FIRMWARE choose"
        Me.group1.ResumeLayout(False)
        Me.group1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents group1 As System.Windows.Forms.GroupBox
    Friend WithEvents radio1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
End Class
