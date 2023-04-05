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
        Me.Talas = New System.Windows.Forms.TextBox()
        Me.Ttinggi = New System.Windows.Forms.TextBox()
        Me.Tluas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Hitung = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Perhitungan Segitiga"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tinggi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alas"
        '
        'Talas
        '
        Me.Talas.Location = New System.Drawing.Point(173, 113)
        Me.Talas.Name = "Talas"
        Me.Talas.Size = New System.Drawing.Size(173, 22)
        Me.Talas.TabIndex = 3
        '
        'Ttinggi
        '
        Me.Ttinggi.Location = New System.Drawing.Point(173, 211)
        Me.Ttinggi.Name = "Ttinggi"
        Me.Ttinggi.Size = New System.Drawing.Size(173, 22)
        Me.Ttinggi.TabIndex = 4
        '
        'Tluas
        '
        Me.Tluas.Location = New System.Drawing.Point(173, 320)
        Me.Tluas.Name = "Tluas"
        Me.Tluas.Size = New System.Drawing.Size(173, 22)
        Me.Tluas.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Luas"
        '
        'Hitung
        '
        Me.Hitung.Location = New System.Drawing.Point(441, 249)
        Me.Hitung.Name = "Hitung"
        Me.Hitung.Size = New System.Drawing.Size(116, 60)
        Me.Hitung.TabIndex = 7
        Me.Hitung.Text = "Hitung"
        Me.Hitung.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 446)
        Me.Controls.Add(Me.Hitung)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Tluas)
        Me.Controls.Add(Me.Ttinggi)
        Me.Controls.Add(Me.Talas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Perhitungan Segitiga Wulan Puspita"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Talas As TextBox
    Friend WithEvents Ttinggi As TextBox
    Friend WithEvents Tluas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Hitung As Button
End Class
