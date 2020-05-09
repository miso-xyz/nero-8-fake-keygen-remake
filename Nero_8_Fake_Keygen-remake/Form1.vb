Public Class Form1
    Dim blnButtonDown, blnButtonDown_
    Private Sub Button1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Button1.Paint
        If blnButtonDown = False Then
            ControlPaint.DrawBorder3D(e.Graphics, sender.ClientRectangle,
                    Border3DStyle.Raised)
        Else
            ControlPaint.DrawBorder3D(e.Graphics, sender.ClientRectangle,
                    Border3DStyle.Sunken)
        End If
    End Sub

    Private Sub Button1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        blnButtonDown = True
        sender.Invalidate()
    End Sub

    Private Sub Button1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseUp
        blnButtonDown = False
        sender.Invalidate()
    End Sub

    Private Sub Button2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Button2.Paint
        If blnButtonDown_ = False Then
            ControlPaint.DrawBorder3D(e.Graphics, sender.ClientRectangle,
                    Border3DStyle.Raised)
        Else
            ControlPaint.DrawBorder3D(e.Graphics, sender.ClientRectangle,
                    Border3DStyle.Sunken)
        End If
    End Sub
    Private Sub Button2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseDown
        blnButtonDown_ = True
        sender.Invalidate()
    End Sub

    Private Sub Button2_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseUp
        blnButtonDown_ = False
        sender.Invalidate()
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim keys As New List(Of String)({"1K22-2867-0K95-61K4-5000-CKAC-AA8X", "1K22-0867-0795-66M4-5271-7557-AXK0", "1K22-0867-0795-66M4-5855-5503-1CMX", "1K22-0867-0795-66M4-5568-9364-090A", "1K22-OO1B-11OS-EG9S-S229-EBKE-OK1E", "1K22-0867-0795-66M4-5610-1840-003A", "1K22-0867-0795-66M4-5236-8953-XE9M", "1K22-0867-0795-66M4-5733-4721-XE94"})
        Dim rng_ As New Random
        RichTextBox1.Text = keys(rng_.Next(0, 7))
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
