<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Mahasiswa = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Admisi = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(545, 381)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 19)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "HASIL DATA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(320, 379)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 19)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "INPUT NILAI"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Mahasiswa)
        Me.Panel3.Location = New System.Drawing.Point(516, 198)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(169, 180)
        Me.Panel3.TabIndex = 18
        '
        'Mahasiswa
        '
        Me.Mahasiswa.BackgroundImage = Global.Project_VB.My.Resources.Resources.img
        Me.Mahasiswa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Mahasiswa.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Mahasiswa.FlatAppearance.BorderSize = 0
        Me.Mahasiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Mahasiswa.Location = New System.Drawing.Point(0, 0)
        Me.Mahasiswa.Name = "Mahasiswa"
        Me.Mahasiswa.Size = New System.Drawing.Size(169, 180)
        Me.Mahasiswa.TabIndex = 2
        Me.Mahasiswa.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Admisi)
        Me.Panel1.Location = New System.Drawing.Point(295, 198)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(167, 180)
        Me.Panel1.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(222, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(175, 200)
        Me.Panel2.TabIndex = 1
        '
        'Admisi
        '
        Me.Admisi.BackColor = System.Drawing.Color.Maroon
        Me.Admisi.BackgroundImage = Global.Project_VB.My.Resources.Resources.download
        Me.Admisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Admisi.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Admisi.FlatAppearance.BorderSize = 0
        Me.Admisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Admisi.Location = New System.Drawing.Point(-1, -1)
        Me.Admisi.Name = "Admisi"
        Me.Admisi.Size = New System.Drawing.Size(168, 181)
        Me.Admisi.TabIndex = 0
        Me.Admisi.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(378, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "HOMEPAGE ADMISI"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = Global.Project_VB.My.Resources.Resources.Logo_UNTAR_Universitas_Tarumanagara_removebg_preview__1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(116, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 112)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Mahasiswa As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Admisi As Button
    Friend WithEvents Label1 As Label
End Class
