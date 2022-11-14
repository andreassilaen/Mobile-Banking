Public Class inputnilai
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Nama As String
        Dim NIM As String
        Dim Tugas As Double
        Dim UTS As Double
        Dim UAS As Double
        Dim Angka As Double
        Dim Huruf As String
        Dim Matkul As String

        Nama = TextNama.Text
        NIM = TextNIM.Text
        Tugas = Val(TextTugas.Text)
        UTS = Val(TextUTS.Text)
        UAS = Val(TextUAS.Text)
        Angka = (0.2 * Tugas + 0.3 * UTS + 0.5 * UAS)
        TextAngka.Text = Angka

        If TextAngka.Text >= 90 Then
            TextHuruf.Text = "A"
        ElseIf TextAngka.Text >= 80 Then
            TextHuruf.Text = "B"
        ElseIf TextAngka.Text >= 70 Then
            TextHuruf.Text = "C"
        ElseIf TextAngka.Text >= 60 Then
            TextHuruf.Text = "D"
        Else
            TextHuruf.Text = "E"
        End If
    End Sub

    Private Sub ButtonClr_Click(sender As Object, e As EventArgs) Handles ButtonClr.Click
        TextNama.Text = ""
        TextNIM.Text = ""
        ComboBox1.Text = ""
        TextTugas.Text = ""
        TextUTS.Text = ""
        TextUAS.Text = ""
        TextMatkul.Text = ""
        TextAngka.Text = ""
        TextHuruf.Text = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "SI23008" Then
            TextMatkul.Text = "Programming"
        ElseIf ComboBox1.Text = "SI23009" Then
            TextMatkul.Text = "Database"
        ElseIf ComboBox1.Text = "SI23010" Then
            TextMatkul.Text = "APSI"
        ElseIf ComboBox1.Text = "SI23013" Then
            TextMatkul.Text = "Website Dev"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim lgn As New Form3
        lgn.Show()
        'Me.Hide() form1 tetap berjalan di background
        Me.Close()
    End Sub


End Class