Public Class Form4
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim lgn As New login1
        lgn.Show()
        'Me.Hide() form1 tetap berjalan di background
        Me.Close()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBInputDataSet1.Tinputmhs' table. You can move, or remove it, as needed.
        Me.TinputmhsTableAdapter.Fill(Me.DBInputDataSet1.Tinputmhs)

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        TinputmhsTableAdapter.Insert(TextNIM.Text, TextNama.Text, ComboBox1.SelectedItem, TextTugas.Text, TextUTS.Text,
       TextUAS.Text, TextMatkul.Text, TextAngka.Text, TextHuruf.Text)
        Me.TinputmhsTableAdapter.Fill(Me.DBInputDataSet1.Tinputmhs)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TinputmhsTableAdapter.CNM(DBInputDataSet1.Tinputmhs, TextBox1.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TinputmhsTableAdapter.Update(DBInputDataSet1.Tinputmhs)
    End Sub

    Private Sub Form4_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        TinputmhsTableAdapter.Update(DBInputDataSet1.Tinputmhs)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim selectedItem As String
        Dim result As System.Windows.Forms.DialogResult

        selectedItem = DataGridView1.SelectedCells(0).Value.ToString

        result = MessageBox.Show("Yakin Mahasiswa Dengan NIM" & selectedItem &
            "Akan Dihapus?", "Konfirmasi", MessageBoxButtons.OKCancel,
                             MessageBoxIcon.Warning)

        If result = System.Windows.Forms.DialogResult.OK Then
            TinputmhsTableAdapter.DeleteQuery(selectedItem)

            Me.TinputmhsTableAdapter.Fill(Me.DBInputDataSet1.Tinputmhs)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub
End Class