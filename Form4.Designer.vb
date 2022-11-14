<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextHuruf = New System.Windows.Forms.TextBox()
        Me.TextMatkul = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ButtonClr = New System.Windows.Forms.Button()
        Me.TextAngka = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextUAS = New System.Windows.Forms.TextBox()
        Me.TextUTS = New System.Windows.Forms.TextBox()
        Me.TextTugas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextNIM = New System.Windows.Forms.TextBox()
        Me.TextNama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NimDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodematkulDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NilaitugasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NilaiutsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NilaiuasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatkulDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NilaiangkaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NilaihurufDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TinputmhsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBInputDataSet1 = New Project_VB.DBInputDataSet1()
        Me.TinputmhsTableAdapter = New Project_VB.DBInputDataSet1TableAdapters.TinputmhsTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TinputmhsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBInputDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 527)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.ButtonSave)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.TextHuruf)
        Me.TabPage1.Controls.Add(Me.TextMatkul)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.ButtonClr)
        Me.TabPage1.Controls.Add(Me.TextAngka)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(792, 501)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Brown
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(673, 449)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 29)
        Me.Button2.TabIndex = 63
        Me.Button2.Text = "LOGOUT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.Brown
        Me.ButtonSave.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonSave.Location = New System.Drawing.Point(565, 357)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(87, 27)
        Me.ButtonSave.TabIndex = 61
        Me.ButtonSave.Text = "SAVE"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(321, 316)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Nilai Huruf"
        '
        'TextHuruf
        '
        Me.TextHuruf.Location = New System.Drawing.Point(397, 312)
        Me.TextHuruf.Margin = New System.Windows.Forms.Padding(2)
        Me.TextHuruf.Name = "TextHuruf"
        Me.TextHuruf.Size = New System.Drawing.Size(93, 20)
        Me.TextHuruf.TabIndex = 59
        '
        'TextMatkul
        '
        Me.TextMatkul.Location = New System.Drawing.Point(397, 261)
        Me.TextMatkul.Margin = New System.Windows.Forms.Padding(2)
        Me.TextMatkul.Name = "TextMatkul"
        Me.TextMatkul.Size = New System.Drawing.Size(293, 20)
        Me.TextMatkul.TabIndex = 58
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(321, 266)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Matkul"
        '
        'ButtonClr
        '
        Me.ButtonClr.BackColor = System.Drawing.Color.Brown
        Me.ButtonClr.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonClr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonClr.Location = New System.Drawing.Point(193, 357)
        Me.ButtonClr.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonClr.Name = "ButtonClr"
        Me.ButtonClr.Size = New System.Drawing.Size(87, 27)
        Me.ButtonClr.TabIndex = 56
        Me.ButtonClr.Text = "CLEAR"
        Me.ButtonClr.UseVisualStyleBackColor = False
        '
        'TextAngka
        '
        Me.TextAngka.Location = New System.Drawing.Point(397, 287)
        Me.TextAngka.Margin = New System.Windows.Forms.Padding(2)
        Me.TextAngka.Name = "TextAngka"
        Me.TextAngka.Size = New System.Drawing.Size(93, 20)
        Me.TextAngka.TabIndex = 55
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(321, 292)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Nilai Angka"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.TextUAS)
        Me.GroupBox2.Controls.Add(Me.TextUTS)
        Me.GroupBox2.Controls.Add(Me.TextTugas)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(406, 88)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(282, 151)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Menghitung Nilai"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Brown
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(159, 103)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 40)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "HITUNG"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextUAS
        '
        Me.TextUAS.Location = New System.Drawing.Point(78, 77)
        Me.TextUAS.Margin = New System.Windows.Forms.Padding(2)
        Me.TextUAS.Name = "TextUAS"
        Me.TextUAS.Size = New System.Drawing.Size(117, 20)
        Me.TextUAS.TabIndex = 5
        '
        'TextUTS
        '
        Me.TextUTS.Location = New System.Drawing.Point(78, 51)
        Me.TextUTS.Margin = New System.Windows.Forms.Padding(2)
        Me.TextUTS.Name = "TextUTS"
        Me.TextUTS.Size = New System.Drawing.Size(117, 20)
        Me.TextUTS.TabIndex = 4
        '
        'TextTugas
        '
        Me.TextTugas.Location = New System.Drawing.Point(78, 27)
        Me.TextTugas.Margin = New System.Windows.Forms.Padding(2)
        Me.TextTugas.Name = "TextTugas"
        Me.TextTugas.Size = New System.Drawing.Size(117, 20)
        Me.TextTugas.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(13, 79)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Nilai UAS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(13, 55)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nilai UTS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(13, 29)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nilai Tugas"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextNIM)
        Me.GroupBox1.Controls.Add(Me.TextNama)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(102, 87)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(300, 151)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Mahasiswa"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"SI23008", "SI23009", "SI23010", "SI23013"})
        Me.ComboBox1.Location = New System.Drawing.Point(102, 99)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(178, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'TextNIM
        '
        Me.TextNIM.Location = New System.Drawing.Point(102, 70)
        Me.TextNIM.Margin = New System.Windows.Forms.Padding(2)
        Me.TextNIM.Name = "TextNIM"
        Me.TextNIM.Size = New System.Drawing.Size(178, 20)
        Me.TextNIM.TabIndex = 2
        '
        'TextNama
        '
        Me.TextNama.Location = New System.Drawing.Point(102, 38)
        Me.TextNama.Margin = New System.Windows.Forms.Padding(2)
        Me.TextNama.Name = "TextNama"
        Me.TextNama.Size = New System.Drawing.Size(178, 20)
        Me.TextNama.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(10, 104)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Kode Matkul"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(10, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NIM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(10, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 14.25!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(200, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 21)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "PROGRAM MENGHITUNG NILAI MAHASISWA"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(792, 501)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(468, 457)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(71, 22)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "DELETE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(245, 457)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(71, 22)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "UPDATE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(296, 398)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(71, 22)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "CARI"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(128, 398)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(150, 20)
        Me.TextBox1.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(80, 403)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Nama"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NimDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn, Me.KodematkulDataGridViewTextBoxColumn, Me.NilaitugasDataGridViewTextBoxColumn, Me.NilaiutsDataGridViewTextBoxColumn, Me.NilaiuasDataGridViewTextBoxColumn, Me.MatkulDataGridViewTextBoxColumn, Me.NilaiangkaDataGridViewTextBoxColumn, Me.NilaihurufDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TinputmhsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(129, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(524, 281)
        Me.DataGridView1.TabIndex = 0
        '
        'NimDataGridViewTextBoxColumn
        '
        Me.NimDataGridViewTextBoxColumn.DataPropertyName = "nim"
        Me.NimDataGridViewTextBoxColumn.HeaderText = "nim"
        Me.NimDataGridViewTextBoxColumn.Name = "NimDataGridViewTextBoxColumn"
        '
        'NamaDataGridViewTextBoxColumn
        '
        Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "nama"
        Me.NamaDataGridViewTextBoxColumn.HeaderText = "nama"
        Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
        '
        'KodematkulDataGridViewTextBoxColumn
        '
        Me.KodematkulDataGridViewTextBoxColumn.DataPropertyName = "kode_matkul"
        Me.KodematkulDataGridViewTextBoxColumn.HeaderText = "kode_matkul"
        Me.KodematkulDataGridViewTextBoxColumn.Name = "KodematkulDataGridViewTextBoxColumn"
        '
        'NilaitugasDataGridViewTextBoxColumn
        '
        Me.NilaitugasDataGridViewTextBoxColumn.DataPropertyName = "nilai_tugas"
        Me.NilaitugasDataGridViewTextBoxColumn.HeaderText = "nilai_tugas"
        Me.NilaitugasDataGridViewTextBoxColumn.Name = "NilaitugasDataGridViewTextBoxColumn"
        '
        'NilaiutsDataGridViewTextBoxColumn
        '
        Me.NilaiutsDataGridViewTextBoxColumn.DataPropertyName = "nilai_uts"
        Me.NilaiutsDataGridViewTextBoxColumn.HeaderText = "nilai_uts"
        Me.NilaiutsDataGridViewTextBoxColumn.Name = "NilaiutsDataGridViewTextBoxColumn"
        '
        'NilaiuasDataGridViewTextBoxColumn
        '
        Me.NilaiuasDataGridViewTextBoxColumn.DataPropertyName = "nilai_uas"
        Me.NilaiuasDataGridViewTextBoxColumn.HeaderText = "nilai_uas"
        Me.NilaiuasDataGridViewTextBoxColumn.Name = "NilaiuasDataGridViewTextBoxColumn"
        '
        'MatkulDataGridViewTextBoxColumn
        '
        Me.MatkulDataGridViewTextBoxColumn.DataPropertyName = "matkul"
        Me.MatkulDataGridViewTextBoxColumn.HeaderText = "matkul"
        Me.MatkulDataGridViewTextBoxColumn.Name = "MatkulDataGridViewTextBoxColumn"
        '
        'NilaiangkaDataGridViewTextBoxColumn
        '
        Me.NilaiangkaDataGridViewTextBoxColumn.DataPropertyName = "nilai_angka"
        Me.NilaiangkaDataGridViewTextBoxColumn.HeaderText = "nilai_angka"
        Me.NilaiangkaDataGridViewTextBoxColumn.Name = "NilaiangkaDataGridViewTextBoxColumn"
        '
        'NilaihurufDataGridViewTextBoxColumn
        '
        Me.NilaihurufDataGridViewTextBoxColumn.DataPropertyName = "nilai_huruf"
        Me.NilaihurufDataGridViewTextBoxColumn.HeaderText = "nilai_huruf"
        Me.NilaihurufDataGridViewTextBoxColumn.Name = "NilaihurufDataGridViewTextBoxColumn"
        '
        'TinputmhsBindingSource
        '
        Me.TinputmhsBindingSource.DataMember = "Tinputmhs"
        Me.TinputmhsBindingSource.DataSource = Me.DBInputDataSet1
        '
        'DBInputDataSet1
        '
        Me.DBInputDataSet1.DataSetName = "DBInputDataSet1"
        Me.DBInputDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TinputmhsTableAdapter
        '
        Me.TinputmhsTableAdapter.ClearBeforeFill = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 524)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TinputmhsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBInputDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ButtonSave As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TextHuruf As TextBox
    Friend WithEvents TextMatkul As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ButtonClr As Button
    Friend WithEvents TextAngka As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextUAS As TextBox
    Friend WithEvents TextUTS As TextBox
    Friend WithEvents TextTugas As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextNIM As TextBox
    Friend WithEvents TextNama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DBInputDataSet1 As DBInputDataSet1
    Friend WithEvents TinputmhsBindingSource As BindingSource
    Friend WithEvents TinputmhsTableAdapter As DBInputDataSet1TableAdapters.TinputmhsTableAdapter
    Friend WithEvents NimDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KodematkulDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NilaitugasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NilaiutsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NilaiuasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MatkulDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NilaiangkaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NilaihurufDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
