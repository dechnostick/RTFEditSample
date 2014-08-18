RTFEditSample
=============

RichTextBox の RTF を操作することで文字の装飾や画像の埋め込みができるようになる。

![](http://cdn-ak.f.st-hatena.com/images/fotolife/d/dechnostick/20140819/20140819000803.gif)

文字の装飾は

```vb
                buffer.SelectionColor = Color.Red
                buffer.SelectionFont = New Font(buffer.SelectionFont.FontFamily,
                                                fontSize, FontStyle.Bold)
```

といった形で行う。

画像はいったん RTF 形式で保存したものをテキストエディタで開いて画像部分を抜き出し、これを該当部分にセットすることで埋め込む。

```vb
        RichTextBox1.SelectedRtf = Converter.RTFHeader & Converter.Hashtable(key) & Converter.RTFFooter
```
