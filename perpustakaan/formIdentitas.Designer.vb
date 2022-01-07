<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formIdentitas
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
        Me.dafNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dafNik = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dafAlamat = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Lengkap"
        '
        'dafNama
        '
        Me.dafNama.Location = New System.Drawing.Point(26, 55)
        Me.dafNama.Name = "dafNama"
        Me.dafNama.Size = New System.Drawing.Size(271, 20)
        Me.dafNama.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NIK"
        '
        'dafNik
        '
        Me.dafNik.Location = New System.Drawing.Point(26, 105)
        Me.dafNik.MaxLength = 16
        Me.dafNik.Name = "dafNik"
        Me.dafNik.Size = New System.Drawing.Size(271, 20)
        Me.dafNik.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Alamat"
        '
        'dafAlamat
        '
        Me.dafAlamat.Location = New System.Drawing.Point(26, 156)
        Me.dafAlamat.Multiline = True
        Me.dafAlamat.Name = "dafAlamat"
        Me.dafAlamat.Size = New System.Drawing.Size(271, 75)
        Me.dafAlamat.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(37, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(240, 45)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "SIMPAN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'formIdentitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 449)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dafAlamat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dafNik)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dafNama)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formIdentitas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IDENTITAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dafNama As System.Windows.Forms.TextBox
    Friend WithEvents dafNik As System.Windows.Forms.TextBox
    Friend WithEvents dafAlamat As System.Windows.Forms.TextBox
End Class
