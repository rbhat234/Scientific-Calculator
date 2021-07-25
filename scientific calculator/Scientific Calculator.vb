Public Class Form1
    Dim assigne_input As Double = 0
    Dim operation As String
    Dim found_expression As Boolean = False
    Dim h As Integer = 0
    Dim firstnum, secondnum, q As String

    Private Sub onoff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles onoff.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Clear()
            TextBox1.Text = ""
            Label3.Text = ""
            RichTextBox1.Text = ""
            zero.Visible = False
            tan.Visible = False
            subtract.Visible = False
            sqrt.Visible = False
            sin.Visible = False
            power.Visible = False
            percent.Visible = False
            multiply.Visible = False
            log.Visible = False
            cbrt.Visible = False
            dot.Visible = False
            divide.Visible = False
            cos.Visible = False
            ce.Visible = False
            historylb.Visible = False
            ButtonEqual.Visible = False
            historyb.Visible = False
            Label2.Visible = False
            remander.Visible = False
            Button26.Visible = False
            Button25.Visible = False
            memory.Visible = False
            RichTextBox1.Visible = False
            del.Visible = False
            x.Visible = False
            Button1.Visible = False
            backspace.Visible = False
            b9.Visible = False
            b8.Visible = False
            b7.Visible = False
            b6.Visible = False
            b5.Visible = False
            b4.Visible = False
            b3.Visible = False
            b2.Visible = False
            b1.Visible = False
            add.Visible = False
        Else
            TextBox1.Text = "0"
            Label3.Text = "0"
            Label2.Text = "There's no history yet"
            RichTextBox1.Clear()
            historylb.Visible = True
            memory.Visible = True
            RichTextBox1.Visible = True
            del.Visible = True
            Label2.Visible = True
            zero.Visible = True
            tan.Visible = True
            subtract.Visible = True
            sqrt.Visible = True
            sin.Visible = True
            power.Visible = True
            percent.Visible = True
            multiply.Visible = True
            log.Visible = True
            cbrt.Visible = True
            dot.Visible = True
            divide.Visible = True
            cos.Visible = True
            ce.Visible = True

            ButtonEqual.Visible = True
            historyb.Visible = True
            remander.Visible = True
            Button26.Visible = True
            Button25.Visible = True

            x.Visible = True
            Button1.Visible = True
            backspace.Visible = True
            b9.Visible = True
            b8.Visible = True
            b7.Visible = True
            b6.Visible = True
            b5.Visible = True
            b4.Visible = True
            b3.Visible = True
            b2.Visible = True
            b1.Visible = True
            add.Visible = True
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        del.Visible = False

    End Sub

    Private Sub OperationClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subtract.Click, remander.Click, power.Click, multiply.Click, divide.Click, add.Click
        Dim b As Button = sender
        If (assigne_input <> "0") Then
            ButtonEqual.PerformClick()
            found_expression = True
            operation = b.Text
            Label3.Text = assigne_input & "   " & operation
        Else
            operation = b.Text
            assigne_input = Double.Parse(TextBox1.Text)
            found_expression = True
            Label3.Text = assigne_input & "   " & operation
        End If
        q = Label3.Text
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        historyb.Show()
        Me.Hide()
    End Sub

    Private Sub del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles del.Click
        RichTextBox1.Clear()
        If (Label2.Text = "") Then
            Label2.Text = "There's no history yet"
        End If

    End Sub

    Private Sub NumberClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zero.Click, TextBox1.Click, dot.Click, b9.Click, b8.Click, b7.Click, b6.Click, b5.Click, b4.Click, b3.Click, b2.Click, b1.Click
        Dim b As Button = sender
        If (TextBox1.Text = "0" Or (found_expression)) Then
            TextBox1.Clear()
            TextBox1.Text = b.Text
            found_expression = False
        ElseIf (b.Text = ".") Then
            If (Not TextBox1.Text.Contains(".")) Then
                TextBox1.Text = TextBox1.Text + b.Text
            End If
        Else
            TextBox1.Text = TextBox1.Text + b.Text
        End If
    End Sub

    Private Sub ButtonEqual_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEqual.Click
        secondnum = TextBox1.Text

        Label3.Text = ""
        Select Case operation
            Case "+"
                TextBox1.Text = (assigne_input + Double.Parse(TextBox1.Text)).ToString()
            Case "-"
                TextBox1.Text = (assigne_input - Double.Parse(TextBox1.Text)).ToString()
            Case "X"
                TextBox1.Text = (assigne_input * Double.Parse(TextBox1.Text)).ToString()
            Case "/"
                TextBox1.Text = (assigne_input / Double.Parse(TextBox1.Text)).ToString()
            Case "^"
                TextBox1.Text = (assigne_input ^ Double.Parse(TextBox1.Text)).ToString()
            Case "Mod"
                TextBox1.Text = (assigne_input Mod Double.Parse(TextBox1.Text)).ToString()
        End Select
        assigne_input = Double.Parse(TextBox1.Text)
        operation = ""

        'history part starts from here
        del.Visible = True
        RichTextBox1.AppendText(q & "     " & secondnum & "  =  " & vbNewLine)
        RichTextBox1.AppendText(vbNewLine & vbTab & TextBox1.Text & vbNewLine & vbNewLine)
        Label2.Text = ""
    End Sub

    Private Sub ce_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ce.Click
        TextBox1.Clear()
        TextBox1.Text = "0"
        Label3.Text = ""
    End Sub

    Private Sub percent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles percent.Click
        Dim a As Double
        a = Convert.ToDouble(TextBox1.Text) / Convert.ToDouble(100)
        TextBox1.Text = System.Convert.ToString(a)
    End Sub

    Private Sub sqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sqrt.Click
        Dim a As Double
        Label3.Text = "Sqrt(" & (TextBox1.Text) & ")"
        a = Math.Sqrt(TextBox1.Text)
        TextBox1.Text = System.Convert.ToString(a)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles x.Click
        Dim a As Double
        a = Convert.ToDouble(1.0 / Convert.ToDouble(TextBox1.Text))
        TextBox1.Text = System.Convert.ToString(a)
    End Sub

    Private Sub backspace_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backspace.Click
        If TextBox1.Text.Length > 0 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1)
        End If
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles historyb.Click
        'Me.Hide()
        'history.Show()

        If h = 0 Then
            RichTextBox1.Location = New Point(13, 167)
            RichTextBox1.Width = 393
            RichTextBox1.Height = 386
            del.Location = New Point(332, 511)
            del.Width = 45
            del.Height = 42
            Label2.Location = New Point(136, 167)
            h = 1
        Else
            RichTextBox1.Location = New Point(451, 87)
            RichTextBox1.Width = 221
            RichTextBox1.Height = 407
            del.Location = New Point(627, 503)
            del.Width = 45
            del.Height = 42
            Label2.Location = New Point(462, 53)
            h = 0
        End If





    End Sub

    Private Sub sin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sin.Click
        Label3.Text = "SIN(" & TextBox1.Text & "°)"
        Dim a = Math.Sin(TextBox1.Text)
        TextBox1.Text = a
    End Sub

    Private Sub cos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cos.Click
        Label3.Text = "COS(" & TextBox1.Text & "°)"
        Dim a = Math.Cos(TextBox1.Text)
        TextBox1.Text = a
    End Sub

    Private Sub tan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tan.Click
        Label3.Text = "TAN(" & TextBox1.Text & "°)"
        Dim a = Math.Tan(TextBox1.Text)
        TextBox1.Text = a
    End Sub

    Private Sub log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles log.Click
        Label3.Text = "log(" & TextBox1.Text & ")"
        If TextBox1.Text = "0" Then
            MsgBox("Invalid Input")
        Else
            Dim a = Math.Log(TextBox1.Text)
            TextBox1.Text = a
        End If

    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        Label3.Text = "fact(" & TextBox1.Text & "!)"
        If TextBox1.Text = "0" Then
            MsgBox("Invalid Input")
        Else
            Dim n As Double
            n = Val(TextBox1.Text)
            For i = 1 To n - 1
                TextBox1.Text *= i
            Next
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text.Contains("-")) Then
            TextBox1.Text = TextBox1.Text.Remove(0, 1)
        Else
            TextBox1.Text = "-" & TextBox1.Text
        End If
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        TextBox1.Text = "3.1415926535897932384626433832795"
    End Sub

    Private Sub cbrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbrt.Click
        Label3.Text = "Cube Root (" & TextBox1.Text & ")"
        Dim a, b As Double
        a = Val(TextBox1.Text)
        b = a ^ (1 / 3)
        TextBox1.Text = b
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class