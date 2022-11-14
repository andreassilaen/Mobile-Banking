<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hsldata
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DBInputDataSet1 = New Project_VB.DBInputDataSet1()
        Me.DBInputDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TinputmhsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TinputmhsTableAdapter = New Project_VB.DBInputDataSet1TableAdapters.TinputmhsTableAdapter()
        Me.NimDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodematkulDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NilaitugasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NilaiutsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NilaiuasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatkulDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NilaiangkaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NilaihurufDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBInputDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBInputDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TinputmhsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NimDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn, Me.KodematkulDataGridViewTextBoxColumn, Me.NilaitugasDataGridViewTextBoxColumn, Me.NilaiutsDataGridViewTextBoxColumn, Me.NilaiuasDataGridViewTextBoxColumn, Me.MatkulDataGridViewTextBoxColumn, Me.NilaiangkaDataGridViewTextBoxColumn, Me.NilaihurufDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TinputmhsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(26, 35)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(528, 260)
        Me.DataGridView1.TabIndex = 0
        '
        'DBInputDataSet1
        '
        Me.DBInputDataSet1.DataSetName = "DBInputDataSet1"
        Me.DBInputDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DBInputDataSet1BindingSource
        '
        Me.DBInputDataSet1BindingSource.DataSource = Me.DBInputDataSet1
        Me.DBInputDataSet1BindingSource.Position = 0
        '
        'TinputmhsBindingSource
        '
        Me.TinputmhsBindingSource.DataMember = "Tinputmhs"
        Me.TinputmhsBindingSource.DataSource = Me.DBInputDataSet1BindingSource
        '
        'TinputmhsTableAdapter
        '
        Me.TinputmhsTableAdapter.ClearBeforeFill = True
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 332)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NIM"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(71, 329)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(150, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(239, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 22)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "CARI"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(115, 402)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 22)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "UPDATE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(386, 402)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(71, 22)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'hsldata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "hsldata"
        Me.Text = "hsldata"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBInputDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBInputDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TinputmhsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DBInputDataSet1BindingSource As BindingSource
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
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
