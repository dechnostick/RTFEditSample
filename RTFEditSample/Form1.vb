Imports System.Text

Public Class Form1

    Private f2 As New Form2()
    Private f3 As New Form3()
    Private fontSize As Single = 0
    Private buffer As New RichTextBox()

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' このフォームで生成された RTF を Text 形式に変換したものが格納される
        f2.Show()
        f2.Location = New Point(Location.X + Width, Location.Y)

        ' RTF を Text に変換したものをさらに RTF へ戻すためのフォーム
        f3.Show()
        f3.Location = New Point(f2.Location.X, f2.Location.Y + f2.Height)

        fontSize = RichTextBox1.SelectionFont.Size
    End Sub

    Private Sub Color_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Button赤.Click, Button戻す.Click

        ' 選択された範囲の Font を変更する
        ' 処理中の画面描画を抑えるため、非表示の RichTextBox で作業する
        Dim selectionStart As Integer = RichTextBox1.SelectionStart
        Dim selectionLength As Integer = selectionStart + RichTextBox1.SelectionLength
        buffer.Rtf = RichTextBox1.Rtf
        For i As Integer = selectionStart To selectionLength - 1

            ' 選択中の Font が複数種類あることを考慮し、一文字ずつ処理する
            buffer.SelectionStart = i
            buffer.SelectionLength = 1

            If DirectCast(sender, Button).Name.Replace("Button", String.Empty).Equals("赤") Then
                ' 赤太字
                buffer.SelectionColor = Color.Red
                buffer.SelectionFont = New Font(buffer.SelectionFont.FontFamily,
                                                fontSize, FontStyle.Bold)
            Else
                ' 黒細字(標準)
                buffer.SelectionColor = Color.Black
                buffer.SelectionFont = New Font(buffer.SelectionFont.FontFamily,
                                                fontSize, FontStyle.Regular)
            End If
        Next
        RichTextBox1.Rtf = buffer.Rtf
        RichTextBox1.SelectionStart = selectionLength
    End Sub

    Private Sub Icon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Buttonブタ.Click, Button会話.Click, Button回転.Click

        ' 画像のボタンをクリックしたときに、カーソル位置に指定された画像を挿入する
        Dim key As String = DirectCast(sender, Button).Name.Replace("Button", String.Empty)
        RichTextBox1.SelectedRtf = Converter.RTFHeader & Converter.Hashtable(key) & Converter.RTFFooter
        RichTextBox1.Focus()
    End Sub

    Private Sub Convert()

        ' RTF を Text 形式に変換する
        ' 処理中の画面描画を抑えるため、非表示の RichTextBox で作業する
        buffer.Rtf = RichTextBox1.Rtf
        Dim sb As New StringBuilder()
        Dim t As String = String.Empty
        For i As Integer = 0 To buffer.Text.Length

            ' 一文字ずつ置き換えていく
            buffer.SelectionStart = i
            buffer.SelectionLength = 1

            Select Case buffer.SelectionType
                Case RichTextBoxSelectionTypes.Text
                    t = Converter.Escape(buffer.SelectedText)
                    If buffer.SelectionColor = Color.Red Then
                        ' 赤太字の場合
                        sb.Append(Converter.Emphasize(t))
                    Else
                        ' 黒細字(標準)の場合
                        sb.Append(t)
                    End If
                Case RichTextBoxSelectionTypes.Object
                    ' 画像の場合は所定の文字実体参照に置き換える
                    sb.Append(Converter.ToCharacterReference(buffer.SelectedRtf))
            End Select
        Next
        Dim ascii As String = Converter.Simplify(sb.ToString())
        f2.ASCII = ascii
        f3.ASCII = ascii
    End Sub

    Private Sub Button保存_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button保存.Click
        RichTextBox1.SaveFile("tmp.rtf")
    End Sub

    Private Sub Button読み出し_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button読み出し.Click
        RichTextBox1.LoadFile("tmp.rtf")
    End Sub

    Private Sub Form1_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        ' 複数のフォームの位置を揃える
        f2.Location = New Point(Location.X + Width, Location.Y)
        f3.Location = New Point(f2.Location.X, f2.Location.Y + f2.Height)
    End Sub

    Private Sub Button変換_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button変換.Click
        ' 変換を実行する
        Convert()
    End Sub
End Class
