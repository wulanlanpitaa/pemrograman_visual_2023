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
        Me.Tpanjang = New System.Windows.Forms.TextBox()
        Me.Tlebar = New System.Windows.Forms.TextBox()
        Me.Thasil = New System.Windows.Forms.TextBox()
        Me.luasbs = New System.Windows.Forms.Button()
        Me.kelilingbs = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bujur Sangkar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Panjang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lebar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(368, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hasil"
        '
        'Tpanjang
        '
        Me.Tpanjang.Location = New System.Drawing.Point(215, 121)
        Me.Tpanjang.Name = "Tpanjang"
        Me.Tpanjang.Size = New System.Drawing.Size(131, 22)
        Me.Tpanjang.TabIndex = 4
        '
        'Tlebar
        '
        Me.Tlebar.Location = New System.Drawing.Point(215, 182)
        Me.Tlebar.Name = "Tlebar"
        Me.Tlebar.Size = New System.Drawing.Size(131, 22)
        Me.Tlebar.TabIndex = 5
        '
        'Thasil
        '
        Me.Thasil.Location = New System.Drawing.Point(498, 166)
        Me.Thasil.Name = "Thasil"
        Me.Thasil.Size = New System.Drawing.Size(131, 22)
        Me.Thasil.TabIndex = 6
        '
        'luasbs
        '
        Me.luasbs.Location = New System.Drawing.Point(80, 293)
        Me.luasbs.Name = "luasbs"
        Me.luasbs.Size = New System.Drawing.Size(191, 35)
        Me.luasbs.TabIndex = 7
        Me.luasbs.Text = "Luas Bujur Sangkar"
        Me.luasbs.UseVisualStyleBackColor = True
        '
        'kelilingbs
        '
        Me.kelilingbs.Location = New System.Drawing.Point(374, 286)
        Me.kelilingbs.Name = "kelilingbs"
        Me.kelilingbs.Size = New System.Drawing.Size(191, 42)
        Me.kelilingbs.TabIndex = 8
        Me.kelilingbs.Text = "Keliling Bujur Sangkar"
        Me.kelilingbs.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 504)
        Me.Controls.Add(Me.kelilingbs)
        Me.Controls.Add(Me.luasbs)
        Me.Controls.Add(Me.Thasil)
        Me.Controls.Add(Me.Tlebar)
        Me.Controls.Add(Me.Tpanjang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Bujur Sangkar Wulan Puspita"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Tpanjang As TextBox
    Friend WithEvents Tlebar As TextBox
    Friend WithEvents Thasil As TextBox
    Friend WithEvents luasbs As Button
    Friend WithEvents kelilingbs As Button
End Class
