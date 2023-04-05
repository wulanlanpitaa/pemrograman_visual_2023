<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tjari = New System.Windows.Forms.TextBox()
        Me.Thasil = New System.Windows.Forms.TextBox()
        Me.Keliling = New System.Windows.Forms.Button()
        Me.Luas = New System.Windows.Forms.Button()
        Me.Hapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(305, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lingkaran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Input Jari-Jari"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hasil"
        '
        'Tjari
        '
        Me.Tjari.Location = New System.Drawing.Point(219, 120)
        Me.Tjari.Name = "Tjari"
        Me.Tjari.Size = New System.Drawing.Size(148, 22)
        Me.Tjari.TabIndex = 3
        '
        'Thasil
        '
        Me.Thasil.Location = New System.Drawing.Point(219, 178)
        Me.Thasil.Name = "Thasil"
        Me.Thasil.Size = New System.Drawing.Size(148, 22)
        Me.Thasil.TabIndex = 4
        '
        'Keliling
        '
        Me.Keliling.Location = New System.Drawing.Point(65, 283)
        Me.Keliling.Name = "Keliling"
        Me.Keliling.Size = New System.Drawing.Size(138, 55)
        Me.Keliling.TabIndex = 5
        Me.Keliling.Text = "Keliling Lingkaran"
        Me.Keliling.UseVisualStyleBackColor = True
        '
        'Luas
        '
        Me.Luas.Location = New System.Drawing.Point(262, 283)
        Me.Luas.Name = "Luas"
        Me.Luas.Size = New System.Drawing.Size(131, 61)
        Me.Luas.TabIndex = 6
        Me.Luas.Text = "Luas"
        Me.Luas.UseVisualStyleBackColor = True
        '
        'Hapus
        '
        Me.Hapus.Location = New System.Drawing.Point(454, 286)
        Me.Hapus.Name = "Hapus"
        Me.Hapus.Size = New System.Drawing.Size(125, 58)
        Me.Hapus.TabIndex = 7
        Me.Hapus.Text = "Clear"
        Me.Hapus.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 447)
        Me.Controls.Add(Me.Hapus)
        Me.Controls.Add(Me.Luas)
        Me.Controls.Add(Me.Keliling)
        Me.Controls.Add(Me.Thasil)
        Me.Controls.Add(Me.Tjari)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Perhitungan Lingkaran Wulan Puspita"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Tjari As TextBox
    Friend WithEvents Thasil As TextBox
    Friend WithEvents Keliling As Button
    Friend WithEvents Luas As Button
    Friend WithEvents Hapus As Button
End Class
