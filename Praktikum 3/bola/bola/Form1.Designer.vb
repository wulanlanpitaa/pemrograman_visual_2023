﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Tjarijari = New System.Windows.Forms.TextBox()
        Me.Thasil = New System.Windows.Forms.TextBox()
        Me.Volumebola = New System.Windows.Forms.Button()
        Me.Luasbola = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(271, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bola"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jari-Jari"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hasil"
        '
        'Tjarijari
        '
        Me.Tjarijari.Location = New System.Drawing.Point(277, 127)
        Me.Tjarijari.Name = "Tjarijari"
        Me.Tjarijari.Size = New System.Drawing.Size(100, 22)
        Me.Tjarijari.TabIndex = 3
        '
        'Thasil
        '
        Me.Thasil.Location = New System.Drawing.Point(277, 210)
        Me.Thasil.Name = "Thasil"
        Me.Thasil.Size = New System.Drawing.Size(100, 22)
        Me.Thasil.TabIndex = 4
        '
        'Volumebola
        '
        Me.Volumebola.Location = New System.Drawing.Point(121, 345)
        Me.Volumebola.Name = "Volumebola"
        Me.Volumebola.Size = New System.Drawing.Size(134, 52)
        Me.Volumebola.TabIndex = 5
        Me.Volumebola.Text = "Volume Bola"
        Me.Volumebola.UseVisualStyleBackColor = True
        '
        'Luasbola
        '
        Me.Luasbola.Location = New System.Drawing.Point(346, 345)
        Me.Luasbola.Name = "Luasbola"
        Me.Luasbola.Size = New System.Drawing.Size(188, 52)
        Me.Luasbola.TabIndex = 6
        Me.Luasbola.Text = "Luas Permukaan Bola"
        Me.Luasbola.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 488)
        Me.Controls.Add(Me.Luasbola)
        Me.Controls.Add(Me.Volumebola)
        Me.Controls.Add(Me.Thasil)
        Me.Controls.Add(Me.Tjarijari)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Perhitungan Bola Wulan Puspita"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Tjarijari As TextBox
    Friend WithEvents Thasil As TextBox
    Friend WithEvents Volumebola As Button
    Friend WithEvents Luasbola As Button
End Class
