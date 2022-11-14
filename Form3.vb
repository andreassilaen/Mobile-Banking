Public Class Form3
    Private Sub Admisi_Click(sender As Object, e As EventArgs) Handles Admisi.Click
        Dim inp As New inputnilai
        inp.Show()
        'Me.Hide() form1 tetap berjalan di background
        Me.Close()
    End Sub

    Private Sub Mahasiswa_Click(sender As Object, e As EventArgs) Handles Mahasiswa.Click
        Dim inp As New hsldata
        inp.Show()
        'Me.Hide() form1 tetap berjalan di background
        Me.Close()
    End Sub
End Class