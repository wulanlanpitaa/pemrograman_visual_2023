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
        Me.Tjarijari = New System.Windows.Forms.TextBox()
        Me.Ttinggi = New System.Windows.Forms.TextBox()
        Me.Thasil = New System.Windows.Forms.TextBox()
        Me.Volumetabung = New System.Windows.Forms.Button()
        Me.Luaspermukaantabung = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(290, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tabung"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jari-jari"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(134, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tinggi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(134, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hasil"
        '
        'Tjarijari
        '
        Me.Tjarijari.Location = New System.Drawing.Point(296, 117)
        Me.Tjarijari.Name = "Tjarijari"
        Me.Tjarijari.Size = New System.Drawing.Size(100, 22)
        Me.Tjarijari.TabIndex = 4
        '
        'Ttinggi
        '
        Me.Ttinggi.Location = New System.Drawing.Point(296, 223)
        Me.Ttinggi.Name = "Ttinggi"
        Me.Ttinggi.Size = New System.Drawing.Size(100, 22)
        Me.Ttinggi.TabIndex = 5
        '
        'Thasil
        '
        Me.Thasil.Location = New System.Drawing.Point(296, 298)
        Me.Thasil.Name = "Thasil"
        Me.Thasil.Size = New System.Drawing.Size(100, 22)
        Me.Thasil.TabIndex = 6
        '
        'Volumetabung
        '
        Me.Volumetabung.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Volumetabung.Location = New System.Drawing.Point(99, 399)
        Me.Volumetabung.Name = "Volumetabung"
        Me.Volumetabung.Size = New System.Drawing.Size(214, 56)
        Me.Volumetabung.TabIndex = 7
        Me.Volumetabung.Text = "Volumetabung"
        Me.Volumetabung.UseVisualStyleBackColor = True
        '
        'Luaspermukaantabung
        '
        Me.Luaspermukaantabung.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Luaspermukaantabung.Location = New System.Drawing.Point(446, 399)
        Me.Luaspermukaantabung.Name = "Luaspermukaantabung"
        Me.Luaspermukaantabung.Size = New System.Drawing.Size(278, 51)
        Me.Luaspermukaantabung.TabIndex = 8
        Me.Luaspermukaantabung.Text = "Luaspermukaantabung"
        Me.Luaspermukaantabung.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 521)
        Me.Controls.Add(Me.Luaspermukaantabung)
        Me.Controls.Add(Me.Volumetabung)
        Me.Controls.Add(Me.Thasil)
        Me.Controls.Add(Me.Ttinggi)
        Me.Controls.Add(Me.Tjarijari)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Perhitungan Tabung Wulan Puspita"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Tjarijari As TextBox
    Friend WithEvents Ttinggi As TextBox
    Friend WithEvents Thasil As TextBox
    Friend WithEvents Volumetabung As Button
    Friend WithEvents Luaspermukaantabung As Button
End Class
