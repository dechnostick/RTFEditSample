Public Class Form2

    ' 動作を確認するためのフォーム。
    ' ユーザの入力が変換された様子を確認するためのもの。
    Public Property ASCII
        Get
            Return Me.TextBox1.Text
        End Get
        Set(ByVal value)
            Me.TextBox1.Text = value
        End Set
    End Property
End Class