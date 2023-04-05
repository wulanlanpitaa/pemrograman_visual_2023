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
        Me.Tsisi = New System.Windows.Forms.TextBox()
        Me.Thasil = New System.Windows.Forms.TextBox()
        Me.Volumekubus = New System.Windows.Forms.Button()
        Me.Luaskubus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(308, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kubus"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sisi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hasil"
        '
        'Tsisi
        '
        Me.Tsisi.Location = New System.Drawing.Point(219, 118)
        Me.Tsisi.Name = "Tsisi"
        Me.Tsisi.Size = New System.Drawing.Size(100, 22)
        Me.Tsisi.TabIndex = 3
        '
        'Thasil
        '
        Me.Thasil.Location = New System.Drawing.Point(219, 193)
        Me.Thasil.Name = "Thasil"
        Me.Thasil.Size = New System.Drawing.Size(100, 22)
        Me.Thasil.TabIndex = 4
        '
        'Volumekubus
        '
        Me.Volumekubus.Location = New System.Drawing.Point(100, 305)
        Me.Volumekubus.Name = "Volumekubus"
        Me.Volumekubus.Size = New System.Drawing.Size(155, 50)
        Me.Volumekubus.TabIndex = 5
        Me.Volumekubus.Text = "Volume Kubus"
        Me.Volumekubus.UseVisualStyleBackColor = True
        '
        'Luaskubus
        '
        Me.Luaskubus.Location = New System.Drawing.Point(372, 305)
        Me.Luaskubus.Name = "Luaskubus"
        Me.Luaskubus.Size = New System.Drawing.Size(228, 50)
        Me.Luaskubus.TabIndex = 6
        Me.Luaskubus.Text = "Luas Permukaan Kubus"
        Me.Luaskubus.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 500)
        Me.Controls.Add(Me.Luaskubus)
        Me.Controls.Add(Me.Volumekubus)
        Me.Controls.Add(Me.Thasil)
        Me.Controls.Add(Me.Tsisi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Perhitungan Kubus Wulan Puspita"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Tsisi As TextBox
    Friend WithEvents Thasil As TextBox
    Friend WithEvents Volumekubus As Button
    Friend WithEvents Luaskubus As Button
End Class
