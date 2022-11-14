Public Class login1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Email Masih Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf TextBox2.Text = "" Then
            MsgBox("Password Masih Kosong", vbExclamation, "Pesan")
            Exit Sub
        End If
        If TextBox1.Text = "admisi1@gmail.com" Or TextBox2.Text = "admisi1" Then
            Form4.ShowDialog()
            Me.Hide()
        Else
            MsgBox("Password dan user Name Anda Harap Periksa", vbExclamation, "Gagal")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New Form1
        frm.Show()
        'Me.Hide() form1 tetap berjalan di background
        Me.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_MouseMove(sender As Object, e As MouseEventArgs) Handles Button1.MouseMove


    End Sub

    Private Sub Button2_MouseMove(sender As Object, e As MouseEventArgs) Handles Button2.MouseMove

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class