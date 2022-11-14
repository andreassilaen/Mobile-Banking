Public Class Form1
    Private Sub Admisi_Click(sender As Object, e As EventArgs) Handles Admisi.Click
        Dim lgn As New login1
        lgn.Show()
        'Me.Hide() form1 tetap berjalan di background
        Me.Close()
    End Sub

    Private Sub Mahasiswa_Click(sender As Object, e As EventArgs) Handles Mahasiswa.Click
        Dim lgn As New Login2
        lgn.Show()
        'Me.Hide() form1 tetap berjalan di background
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
        (Me.ClientRectangle, Color.Maroon, Color.GhostWhite, Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint

    End Sub
End Class
