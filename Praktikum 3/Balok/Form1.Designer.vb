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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tpanjang = New System.Windows.Forms.TextBox()
        Me.Tlebar = New System.Windows.Forms.TextBox()
        Me.Ttinggi = New System.Windows.Forms.TextBox()
        Me.Thasil = New System.Windows.Forms.TextBox()
        Me.Volumebalok = New System.Windows.Forms.Button()
        Me.Luaspermukaan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Balok"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Panjang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lebar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tinggi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 32)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Hasil"
        '
        'Tpanjang
        '
        Me.Tpanjang.Location = New System.Drawing.Point(256, 77)
        Me.Tpanjang.Name = "Tpanjang"
        Me.Tpanjang.Size = New System.Drawing.Size(100, 22)
        Me.Tpanjang.TabIndex = 5
        '
        'Tlebar
        '
        Me.Tlebar.Location = New System.Drawing.Point(256, 144)
        Me.Tlebar.Name = "Tlebar"
        Me.Tlebar.Size = New System.Drawing.Size(100, 22)
        Me.Tlebar.TabIndex = 6
        '
        'Ttinggi
        '
        Me.Ttinggi.Location = New System.Drawing.Point(256, 228)
        Me.Ttinggi.Name = "Ttinggi"
        Me.Ttinggi.Size = New System.Drawing.Size(100, 22)
        Me.Ttinggi.TabIndex = 7
        '
        'Thasil
        '
        Me.Thasil.Location = New System.Drawing.Point(256, 300)
        Me.Thasil.Name = "Thasil"
        Me.Thasil.Size = New System.Drawing.Size(100, 22)
        Me.Thasil.TabIndex = 8
        '
        'Volumebalok
        '
        Me.Volumebalok.Location = New System.Drawing.Point(197, 376)
        Me.Volumebalok.Name = "Volumebalok"
        Me.Volumebalok.Size = New System.Drawing.Size(159, 51)
        Me.Volumebalok.TabIndex = 9
        Me.Volumebalok.Text = "Volume"
        Me.Volumebalok.UseVisualStyleBackColor = True
        '
        'Luaspermukaan
        '
        Me.Luaspermukaan.Location = New System.Drawing.Point(436, 376)
        Me.Luaspermukaan.Name = "Luaspermukaan"
        Me.Luaspermukaan.Size = New System.Drawing.Size(150, 51)
        Me.Luaspermukaan.TabIndex = 10
        Me.Luaspermukaan.Text = "Luas Permukaan"
        Me.Luaspermukaan.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 537)
        Me.Controls.Add(Me.Luaspermukaan)
        Me.Controls.Add(Me.Volumebalok)
        Me.Controls.Add(Me.Thasil)
        Me.Controls.Add(Me.Ttinggi)
        Me.Controls.Add(Me.Tlebar)
        Me.Controls.Add(Me.Tpanjang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Perhitungan Balok Wulan Puspita"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Tpanjang As TextBox
    Friend WithEvents Tlebar As TextBox
    Friend WithEvents Ttinggi As TextBox
    Friend WithEvents Thasil As TextBox
    Friend WithEvents Volumebalok As Button
    Friend WithEvents Luaspermukaan As Button
End Class
