<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button保存 = New System.Windows.Forms.Button()
        Me.Button読み出し = New System.Windows.Forms.Button()
        Me.Button変換 = New System.Windows.Forms.Button()
        Me.Button赤 = New System.Windows.Forms.Button()
        Me.Button戻す = New System.Windows.Forms.Button()
        Me.Buttonブタ = New System.Windows.Forms.Button()
        Me.Button会話 = New System.Windows.Forms.Button()
        Me.Button回転 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 10)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(260, 146)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'Button保存
        '
        Me.Button保存.Location = New System.Drawing.Point(12, 243)
        Me.Button保存.Name = "Button保存"
        Me.Button保存.Size = New System.Drawing.Size(146, 37)
        Me.Button保存.TabIndex = 2
        Me.Button保存.Text = "ファイルに保存する"
        Me.Button保存.UseVisualStyleBackColor = True
        '
        'Button読み出し
        '
        Me.Button読み出し.Location = New System.Drawing.Point(164, 243)
        Me.Button読み出し.Name = "Button読み出し"
        Me.Button読み出し.Size = New System.Drawing.Size(114, 37)
        Me.Button読み出し.TabIndex = 3
        Me.Button読み出し.Text = "ファイルから読み出す"
        Me.Button読み出し.UseVisualStyleBackColor = True
        '
        'Button変換
        '
        Me.Button変換.Location = New System.Drawing.Point(12, 200)
        Me.Button変換.Name = "Button変換"
        Me.Button変換.Size = New System.Drawing.Size(146, 37)
        Me.Button変換.TabIndex = 17
        Me.Button変換.Text = "テキスト形式に変換する"
        Me.Button変換.UseVisualStyleBackColor = True
        '
        'Button赤
        '
        Me.Button赤.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button赤.ForeColor = System.Drawing.Color.Red
        Me.Button赤.Location = New System.Drawing.Point(12, 162)
        Me.Button赤.Name = "Button赤"
        Me.Button赤.Size = New System.Drawing.Size(70, 32)
        Me.Button赤.TabIndex = 18
        Me.Button赤.Text = "赤くする"
        Me.Button赤.UseVisualStyleBackColor = True
        '
        'Button戻す
        '
        Me.Button戻す.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button戻す.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button戻す.Location = New System.Drawing.Point(87, 162)
        Me.Button戻す.Name = "Button戻す"
        Me.Button戻す.Size = New System.Drawing.Size(71, 32)
        Me.Button戻す.TabIndex = 18
        Me.Button戻す.Text = "戻す"
        Me.Button戻す.UseVisualStyleBackColor = True
        '
        'Buttonブタ
        '
        Me.Buttonブタ.BackgroundImage = Global.RTFEditSample.My.Resources.Resources.ブタ
        Me.Buttonブタ.Location = New System.Drawing.Point(164, 162)
        Me.Buttonブタ.Name = "Buttonブタ"
        Me.Buttonブタ.Size = New System.Drawing.Size(32, 32)
        Me.Buttonブタ.TabIndex = 21
        Me.Buttonブタ.UseVisualStyleBackColor = True
        '
        'Button会話
        '
        Me.Button会話.BackgroundImage = Global.RTFEditSample.My.Resources.Resources.会話
        Me.Button会話.Location = New System.Drawing.Point(202, 162)
        Me.Button会話.Name = "Button会話"
        Me.Button会話.Size = New System.Drawing.Size(32, 32)
        Me.Button会話.TabIndex = 20
        Me.Button会話.UseVisualStyleBackColor = True
        '
        'Button回転
        '
        Me.Button回転.BackgroundImage = Global.RTFEditSample.My.Resources.Resources.回転
        Me.Button回転.Location = New System.Drawing.Point(240, 162)
        Me.Button回転.Name = "Button回転"
        Me.Button回転.Size = New System.Drawing.Size(32, 32)
        Me.Button回転.TabIndex = 19
        Me.Button回転.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 302)
        Me.Controls.Add(Me.Buttonブタ)
        Me.Controls.Add(Me.Button会話)
        Me.Controls.Add(Me.Button回転)
        Me.Controls.Add(Me.Button戻す)
        Me.Controls.Add(Me.Button赤)
        Me.Controls.Add(Me.Button変換)
        Me.Controls.Add(Me.Button読み出し)
        Me.Controls.Add(Me.Button保存)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "Form1"
        Me.Text = "入力"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button保存 As System.Windows.Forms.Button
    Friend WithEvents Button読み出し As System.Windows.Forms.Button
    Friend WithEvents Button変換 As System.Windows.Forms.Button
    Friend WithEvents Button赤 As System.Windows.Forms.Button
    Friend WithEvents Button戻す As System.Windows.Forms.Button
    Friend WithEvents Button回転 As System.Windows.Forms.Button
    Friend WithEvents Button会話 As System.Windows.Forms.Button
    Friend WithEvents Buttonブタ As System.Windows.Forms.Button

End Class
