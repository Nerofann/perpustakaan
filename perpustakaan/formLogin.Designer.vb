<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLogin
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
        Me.lblusername = New System.Windows.Forms.Label()
        Me.tbxusername = New System.Windows.Forms.TextBox()
        Me.tbxpassword = New System.Windows.Forms.TextBox()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.lblcaptcha = New System.Windows.Forms.Label()
        Me.tbxcaptcha = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.lbljudul = New System.Windows.Forms.Label()
        Me.Daftar = New System.Windows.Forms.LinkLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(29, 93)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(85, 17)
        Me.lblusername.TabIndex = 0
        Me.lblusername.Text = "USERNAME"
        Me.lblusername.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbxusername
        '
        Me.tbxusername.Location = New System.Drawing.Point(45, 113)
        Me.tbxusername.Name = "tbxusername"
        Me.tbxusername.Size = New System.Drawing.Size(231, 20)
        Me.tbxusername.TabIndex = 1
        '
        'tbxpassword
        '
        Me.tbxpassword.Location = New System.Drawing.Point(45, 181)
        Me.tbxpassword.Name = "tbxpassword"
        Me.tbxpassword.Size = New System.Drawing.Size(231, 20)
        Me.tbxpassword.TabIndex = 2
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.Location = New System.Drawing.Point(29, 161)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(88, 17)
        Me.lblpassword.TabIndex = 3
        Me.lblpassword.Text = "PASSWORD"
        Me.lblpassword.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblcaptcha
        '
        Me.lblcaptcha.AutoSize = True
        Me.lblcaptcha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcaptcha.Location = New System.Drawing.Point(29, 238)
        Me.lblcaptcha.Name = "lblcaptcha"
        Me.lblcaptcha.Size = New System.Drawing.Size(80, 17)
        Me.lblcaptcha.TabIndex = 4
        Me.lblcaptcha.Text = "CAPTCHA :"
        Me.lblcaptcha.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbxcaptcha
        '
        Me.tbxcaptcha.Location = New System.Drawing.Point(45, 290)
        Me.tbxcaptcha.MaxLength = 5
        Me.tbxcaptcha.Multiline = True
        Me.tbxcaptcha.Name = "tbxcaptcha"
        Me.tbxcaptcha.Size = New System.Drawing.Size(231, 23)
        Me.tbxcaptcha.TabIndex = 6
        '
        'btnlogin
        '
        Me.btnlogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnlogin.Location = New System.Drawing.Point(31, 347)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(259, 36)
        Me.btnlogin.TabIndex = 7
        Me.btnlogin.Text = "LOGIN"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(31, 401)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(259, 36)
        Me.btnexit.TabIndex = 8
        Me.btnexit.Text = "TUTUP APLIKASI"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'lbljudul
        '
        Me.lbljudul.BackColor = System.Drawing.Color.Red
        Me.lbljudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljudul.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lbljudul.Location = New System.Drawing.Point(1, -1)
        Me.lbljudul.Name = "lbljudul"
        Me.lbljudul.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbljudul.Size = New System.Drawing.Size(317, 57)
        Me.lbljudul.TabIndex = 9
        Me.lbljudul.Text = "LOGIN"
        Me.lbljudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Daftar
        '
        Me.Daftar.AutoSize = True
        Me.Daftar.Location = New System.Drawing.Point(270, 65)
        Me.Daftar.Name = "Daftar"
        Me.Daftar.Size = New System.Drawing.Size(36, 13)
        Me.Daftar.TabIndex = 12
        Me.Daftar.TabStop = True
        Me.Daftar.Text = "Daftar"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(152, 226)
        Me.TextBox1.MaxLength = 5
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(124, 40)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'formLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 449)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Daftar)
        Me.Controls.Add(Me.lbljudul)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.tbxcaptcha)
        Me.Controls.Add(Me.lblcaptcha)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.tbxpassword)
        Me.Controls.Add(Me.tbxusername)
        Me.Controls.Add(Me.lblusername)
        Me.Name = "formLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents tbxusername As System.Windows.Forms.TextBox
    Friend WithEvents tbxpassword As System.Windows.Forms.TextBox
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents lblcaptcha As System.Windows.Forms.Label
    Friend WithEvents tbxcaptcha As System.Windows.Forms.TextBox
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents lbljudul As System.Windows.Forms.Label
    Friend WithEvents Daftar As System.Windows.Forms.LinkLabel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
