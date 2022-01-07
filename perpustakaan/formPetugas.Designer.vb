<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class w
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MASTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterPetugasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HISTORYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeminjamanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROFILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(573, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MENU PETUGAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Red
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.MASTERToolStripMenuItem, Me.HISTORYToolStripMenuItem, Me.PROFILEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(573, 27)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LOGINToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(46, 23)
        Me.ToolStripMenuItem1.Text = "FILE"
        '
        'LOGINToolStripMenuItem
        '
        Me.LOGINToolStripMenuItem.Name = "LOGINToolStripMenuItem"
        Me.LOGINToolStripMenuItem.Size = New System.Drawing.Size(121, 24)
        Me.LOGINToolStripMenuItem.Text = "LOGIN"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(121, 24)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'MASTERToolStripMenuItem
        '
        Me.MASTERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterUsersToolStripMenuItem, Me.MasterPetugasToolStripMenuItem, Me.MasterBukuToolStripMenuItem})
        Me.MASTERToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.MASTERToolStripMenuItem.Name = "MASTERToolStripMenuItem"
        Me.MASTERToolStripMenuItem.Size = New System.Drawing.Size(76, 23)
        Me.MASTERToolStripMenuItem.Text = "MASTER"
        '
        'MasterUsersToolStripMenuItem
        '
        Me.MasterUsersToolStripMenuItem.Name = "MasterUsersToolStripMenuItem"
        Me.MasterUsersToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.MasterUsersToolStripMenuItem.Text = "Master Users"
        '
        'MasterPetugasToolStripMenuItem
        '
        Me.MasterPetugasToolStripMenuItem.Name = "MasterPetugasToolStripMenuItem"
        Me.MasterPetugasToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.MasterPetugasToolStripMenuItem.Text = "Master Anggota"
        '
        'MasterBukuToolStripMenuItem
        '
        Me.MasterBukuToolStripMenuItem.Name = "MasterBukuToolStripMenuItem"
        Me.MasterBukuToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.MasterBukuToolStripMenuItem.Text = "Master Buku"
        '
        'HISTORYToolStripMenuItem
        '
        Me.HISTORYToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PeminjamanToolStripMenuItem})
        Me.HISTORYToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.HISTORYToolStripMenuItem.Name = "HISTORYToolStripMenuItem"
        Me.HISTORYToolStripMenuItem.Size = New System.Drawing.Size(80, 23)
        Me.HISTORYToolStripMenuItem.Text = "HISTORY"
        '
        'PeminjamanToolStripMenuItem
        '
        Me.PeminjamanToolStripMenuItem.Name = "PeminjamanToolStripMenuItem"
        Me.PeminjamanToolStripMenuItem.Size = New System.Drawing.Size(161, 24)
        Me.PeminjamanToolStripMenuItem.Text = "Peminjaman"
        '
        'PROFILEToolStripMenuItem
        '
        Me.PROFILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MyProfileToolStripMenuItem})
        Me.PROFILEToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.PROFILEToolStripMenuItem.Name = "PROFILEToolStripMenuItem"
        Me.PROFILEToolStripMenuItem.Size = New System.Drawing.Size(75, 23)
        Me.PROFILEToolStripMenuItem.Text = "PROFILE"
        '
        'MyProfileToolStripMenuItem
        '
        Me.MyProfileToolStripMenuItem.Name = "MyProfileToolStripMenuItem"
        Me.MyProfileToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.MyProfileToolStripMenuItem.Text = "My Profile"
        '
        'w
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 377)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "w"
        Me.Text = "MENU PETUGAS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MASTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterPetugasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterBukuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HISTORYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PeminjamanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PROFILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
