Public Class Login2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Email Masik Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf TextBox2.Text = "" Then
            MsgBox("Password Masih Kosong", vbExclamation, "Pesan")
            Exit Sub
        End If
        If TextBox1.Text = "mhs1@gmail.com" Or TextBox2.Text = "mhs1" Then
            nilaimhs.ShowDialog()
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class