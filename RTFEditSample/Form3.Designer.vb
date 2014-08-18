<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(10, 12)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(277, 146)
        Me.RichTextBox2.TabIndex = 1
        Me.RichTextBox2.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(10, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "描画する"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 205)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Name = "Form3"
        Me.Text = "テキスト形式から RTF を再現"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
