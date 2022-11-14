Public Class nilaimhs
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lgn As New Login2
        lgn.Show()
        'Me.Hide() form1 tetap berjalan di background
        Me.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Object Based Programming" Then TextBox1.Text = 90
        If ComboBox2.Text = "Oracle Database Administrator" Then TextBox1.Text = 85
        If ComboBox2.Text = "Web Development" Then TextBox1.Text = 78
        If ComboBox2.Text = "Analysis and Design Information of System" Then TextBox1.Text = 80
        If ComboBox2.Text = "Object Based Programming" Then TextBox3.Text = 85
        If ComboBox2.Text = "Oracle Database Administrator" Then TextBox3.Text = 80
        If ComboBox2.Text = "Web Development" Then TextBox3.Text = 84
        If ComboBox2.Text = "Analysis and Design Information of System" Then TextBox3.Text = 78
        If ComboBox2.Text = "Object Based Programming" Then TextBox4.Text = 80
        If ComboBox2.Text = "Oracle Database Administrator" Then TextBox4.Text = 80
        If ComboBox2.Text = "Web Development" Then TextBox4.Text = 79
        If ComboBox2.Text = "Analysis and Design Information of System" Then TextBox4.Text = 77
        If ComboBox2.Text = "Object Based Programming" Then TextBox2.Text = 83.5
        If ComboBox2.Text = "Oracle Database Administrator" Then TextBox2.Text = 81
        If ComboBox2.Text = "Web Development" Then TextBox1.Text = 80.3
        If ComboBox2.Text = "Analysis and Design Information of System" Then TextBox2.Text = 77.9
    End Sub
End Class