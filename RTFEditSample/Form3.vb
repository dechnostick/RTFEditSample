Imports System.Text

Public Class Form3

    Private enc As Encoding = Encoding.GetEncoding("shift_jis")
    Private fontSize As Single = 0
    Private buffer As New RichTextBox()
    Private _ascii As String = String.Empty

    Private Sub Form3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fontSize = RichTextBox2.SelectionFont.Size
    End Sub

    Public Property ASCII
        Get
            Return _ascii
        End Get
        Set(ByVal value)
            _ascii = value
        End Set
    End Property

    Private Sub ShowPreview()

        ' Text 形式に変換されたユーザの入力を RTF に戻す処理
        ' (完全な再現ではなく、定められた要素のみを復元することに注意)
        RichTextBox2.Clear()
        buffer.Clear()
        Dim sb As New StringBuilder()
        Dim tokenCR As New StringBuilder()
        Dim tokenHTML As New StringBuilder()
        Dim isCR As Boolean = False
        Dim isHTML As Boolean = False
        Dim isStartEM As Boolean = False
        Dim str As String = _ascii.Replace(vbCrLf, vbCr)

        ' Text 形式のデータを一文字ずつ確認する
        ' 処理中の画面描画を抑えるため、非表示の RichTextBox で作業する
        For Each chr As Char In str.ToCharArray

            If chr = "&"c Then
                ' 文字実体参照(開始)
                tokenCR = New StringBuilder()
                isCR = True
                tokenCR.Append(chr)
            ElseIf isCR And chr <> ";"c Then
                ' 文字実体参照(途中)
                tokenCR.Append(chr)
            ElseIf isCR And chr = ";"c Then
                ' 文字実体参照(終了)
                isCR = False
                tokenCR.Append(chr)

            ElseIf chr = "<"c Then
                ' HTML(開始)
                tokenHTML = New StringBuilder()
                isHTML = True
                tokenHTML.Append(chr)
            ElseIf isHTML And chr <> ">"c Then
                ' HTML(途中)
                tokenHTML.Append(chr)
            ElseIf isHTML And chr = ">"c Then
                ' HTML(終了)
                isHTML = False
                tokenHTML.Append(chr)

            Else
                ' ユーザ入力そのもの
                sb.Append(ToHex(chr))
            End If

            If Not isCR And Not tokenCR Is Nothing AndAlso tokenCR.ToString.Length <> 0 Then
                ' 文字列が文字実体参照だったので、RTF に変換する
                sb.Append(Converter.Hashtable(tokenCR.ToString()))
                tokenCR = New StringBuilder()

            ElseIf Not isHTML And Not tokenHTML Is Nothing AndAlso tokenHTML.ToString.Length <> 0 Then

                If Converter.IsBR(tokenHTML.ToString()) Then
                    ' 文字列が改行タグだった
                    sb.Append(ToHex(Converter.Hashtable(tokenHTML.ToString())))
                ElseIf Converter.IsStartEM(tokenHTML.ToString()) Then
                    ' 文字列が強調タグ(開始)だった
                    isStartEM = True
                Else
                    ' 文字列が強調タグ(終了)だった
                    isStartEM = False
                End If

                tokenHTML = New StringBuilder()
            End If

            If Not sb Is Nothing AndAlso sb.ToString.Length <> 0 Then

                ' 文字または変換された RTF を出力結果として格納する
                buffer.SelectedRtf = Converter.RTFHeader & sb.ToString() & Converter.RTFFooter

                ' 格納した一文字を選択状態にする
                buffer.SelectionStart = buffer.Text.Length - 1
                buffer.SelectionLength = 1

                If isStartEM Then
                    ' 開始タグがあったので、赤太字にする
                    buffer.SelectionColor = Color.Red
                    buffer.SelectionFont = New Font(RichTextBox2.SelectionFont.FontFamily,
                                                          fontSize, FontStyle.Bold)
                Else
                    ' 終了タグがあったので、黒細字(標準)に戻す
                    buffer.SelectionColor = Color.Black
                    buffer.SelectionFont = New Font(RichTextBox2.SelectionFont.FontFamily,
                                                          fontSize, FontStyle.Regular)
                End If

                ' 選択状態を解除し、カーソルを行末に移動する
                buffer.SelectionStart = buffer.Text.Length
                sb = New StringBuilder()
            End If
        Next

        RichTextBox2.Rtf = buffer.Rtf
    End Sub

    Private Function ToHex(ByVal str As String) As String

        ' 非 ASCII については Shift_JIS として受け取った上で HEX に変換する
        Dim bb As Byte() = enc.GetBytes(str)
        Dim sb As New StringBuilder()
        For Each b As Byte In bb
            sb.Append("\'")
            sb.AppendFormat("{0:x2}", b)
        Next
        Return sb.ToString()
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' 変換を実行する
        ShowPreview()
    End Sub
End Class