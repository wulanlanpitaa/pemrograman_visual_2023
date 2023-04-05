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
        Me.Tsisi = New System.Windows.Forms.TextBox()
        Me.Tdiagonal1 = New System.Windows.Forms.TextBox()
        Me.Tdiagonal2 = New System.Windows.Forms.TextBox()
        Me.Thasil = New System.Windows.Forms.TextBox()
        Me.luasbk = New System.Windows.Forms.Button()
        Me.kelilingbk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Perhitungan Belah Ketupat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sisi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Diagonal1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Diagonal2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(434, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Hasil"
        '
        'Tsisi
        '
        Me.Tsisi.Location = New System.Drawing.Point(211, 99)
        Me.Tsisi.Name = "Tsisi"
        Me.Tsisi.Size = New System.Drawing.Size(100, 22)
        Me.Tsisi.TabIndex = 5
        '
        'Tdiagonal1
        '
        Me.Tdiagonal1.Location = New System.Drawing.Point(211, 190)
        Me.Tdiagonal1.Name = "Tdiagonal1"
        Me.Tdiagonal1.Size = New System.Drawing.Size(100, 22)
        Me.Tdiagonal1.TabIndex = 6
        '
        'Tdiagonal2
        '
        Me.Tdiagonal2.Location = New System.Drawing.Point(211, 264)
        Me.Tdiagonal2.Name = "Tdiagonal2"
        Me.Tdiagonal2.Size = New System.Drawing.Size(100, 22)
        Me.Tdiagonal2.TabIndex = 7
        '
        'Thasil
        '
        Me.Thasil.Location = New System.Drawing.Point(545, 191)
        Me.Thasil.Name = "Thasil"
        Me.Thasil.Size = New System.Drawing.Size(100, 22)
        Me.Thasil.TabIndex = 8
        '
        'luasbk
        '
        Me.luasbk.Location = New System.Drawing.Point(165, 344)
        Me.luasbk.Name = "luasbk"
        Me.luasbk.Size = New System.Drawing.Size(187, 54)
        Me.luasbk.TabIndex = 9
        Me.luasbk.Text = "Luas Belah Ketupat"
        Me.luasbk.UseVisualStyleBackColor = True
        '
        'kelilingbk
        '
        Me.kelilingbk.Location = New System.Drawing.Point(419, 344)
        Me.kelilingbk.Name = "kelilingbk"
        Me.kelilingbk.Size = New System.Drawing.Size(189, 54)
        Me.kelilingbk.TabIndex = 10
        Me.kelilingbk.Text = "Keliling Belah Ketupat"
        Me.kelilingbk.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 493)
        Me.Controls.Add(Me.kelilingbk)
        Me.Controls.Add(Me.luasbk)
        Me.Controls.Add(Me.Thasil)
        Me.Controls.Add(Me.Tdiagonal2)
        Me.Controls.Add(Me.Tdiagonal1)
        Me.Controls.Add(Me.Tsisi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Program Belah Ketupat Wulan Puspita"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Tsisi As TextBox
    Friend WithEvents Tdiagonal1 As TextBox
    Friend WithEvents Tdiagonal2 As TextBox
    Friend WithEvents Thasil As TextBox
    Friend WithEvents luasbk As Button
    Friend WithEvents kelilingbk As Button
End Class
