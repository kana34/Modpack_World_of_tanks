<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mods
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mods))
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.pmod = New System.Windows.Forms.CheckBox()
        Me.WN8_EFF_Damage = New System.Windows.Forms.CheckBox()
        Me.crosshair = New System.Windows.Forms.CheckBox()
        Me.channel = New System.Windows.Forms.CheckBox()
        Me.xvm = New System.Windows.Forms.CheckBox()
        Me.Menu_home = New System.Windows.Forms.Panel()
        Me.Menu_news = New System.Windows.Forms.Panel()
        Me.Bouton_install_mods = New System.Windows.Forms.Panel()
        Me.Bouton_desinstall_mods = New System.Windows.Forms.Panel()
        Me.Bouton_close = New System.Windows.Forms.Panel()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox
        '
        Me.GroupBox.BackColor = System.Drawing.Color.White
        Me.GroupBox.Controls.Add(Me.pmod)
        Me.GroupBox.Controls.Add(Me.WN8_EFF_Damage)
        Me.GroupBox.Controls.Add(Me.crosshair)
        Me.GroupBox.Controls.Add(Me.channel)
        Me.GroupBox.Controls.Add(Me.xvm)
        Me.GroupBox.Location = New System.Drawing.Point(293, 144)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(171, 263)
        Me.GroupBox.TabIndex = 0
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Mods"
        '
        'pmod
        '
        Me.pmod.AutoSize = True
        Me.pmod.Location = New System.Drawing.Point(7, 88)
        Me.pmod.Name = "pmod"
        Me.pmod.Size = New System.Drawing.Size(53, 17)
        Me.pmod.TabIndex = 6
        Me.pmod.Text = "Pmod"
        Me.pmod.UseVisualStyleBackColor = True
        '
        'WN8_EFF_Damage
        '
        Me.WN8_EFF_Damage.AutoSize = True
        Me.WN8_EFF_Damage.Location = New System.Drawing.Point(7, 111)
        Me.WN8_EFF_Damage.Name = "WN8_EFF_Damage"
        Me.WN8_EFF_Damage.Size = New System.Drawing.Size(128, 17)
        Me.WN8_EFF_Damage.TabIndex = 5
        Me.WN8_EFF_Damage.Text = "WN8 - EFF - Damage"
        Me.WN8_EFF_Damage.UseVisualStyleBackColor = True
        '
        'crosshair
        '
        Me.crosshair.AutoSize = True
        Me.crosshair.Location = New System.Drawing.Point(7, 65)
        Me.crosshair.Name = "crosshair"
        Me.crosshair.Size = New System.Drawing.Size(69, 17)
        Me.crosshair.TabIndex = 3
        Me.crosshair.Text = "Crosshair"
        Me.crosshair.UseVisualStyleBackColor = True
        '
        'channel
        '
        Me.channel.AutoSize = True
        Me.channel.Checked = True
        Me.channel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.channel.Enabled = False
        Me.channel.Location = New System.Drawing.Point(7, 19)
        Me.channel.Name = "channel"
        Me.channel.Size = New System.Drawing.Size(128, 17)
        Me.channel.TabIndex = 0
        Me.channel.Text = "Channel Actuel-Force"
        Me.channel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.channel.UseVisualStyleBackColor = True
        '
        'xvm
        '
        Me.xvm.AutoSize = True
        Me.xvm.Location = New System.Drawing.Point(7, 42)
        Me.xvm.Name = "xvm"
        Me.xvm.Size = New System.Drawing.Size(47, 17)
        Me.xvm.TabIndex = 1
        Me.xvm.Text = "Xvm"
        Me.xvm.UseVisualStyleBackColor = True
        '
        'Menu_home
        '
        Me.Menu_home.BackColor = System.Drawing.Color.Transparent
        Me.Menu_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Menu_home.Location = New System.Drawing.Point(1, 4)
        Me.Menu_home.Name = "Menu_home"
        Me.Menu_home.Size = New System.Drawing.Size(135, 59)
        Me.Menu_home.TabIndex = 3
        '
        'Menu_news
        '
        Me.Menu_news.BackColor = System.Drawing.Color.Transparent
        Me.Menu_news.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Menu_news.Location = New System.Drawing.Point(140, 4)
        Me.Menu_news.Name = "Menu_news"
        Me.Menu_news.Size = New System.Drawing.Size(135, 59)
        Me.Menu_news.TabIndex = 3
        '
        'Bouton_install_mods
        '
        Me.Bouton_install_mods.BackColor = System.Drawing.Color.Transparent
        Me.Bouton_install_mods.Location = New System.Drawing.Point(19, 182)
        Me.Bouton_install_mods.Name = "Bouton_install_mods"
        Me.Bouton_install_mods.Size = New System.Drawing.Size(234, 57)
        Me.Bouton_install_mods.TabIndex = 4
        '
        'Bouton_desinstall_mods
        '
        Me.Bouton_desinstall_mods.BackColor = System.Drawing.Color.Transparent
        Me.Bouton_desinstall_mods.Location = New System.Drawing.Point(19, 258)
        Me.Bouton_desinstall_mods.Name = "Bouton_desinstall_mods"
        Me.Bouton_desinstall_mods.Size = New System.Drawing.Size(234, 57)
        Me.Bouton_desinstall_mods.TabIndex = 5
        '
        'Bouton_close
        '
        Me.Bouton_close.BackColor = System.Drawing.Color.Transparent
        Me.Bouton_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bouton_close.Location = New System.Drawing.Point(465, 33)
        Me.Bouton_close.Name = "Bouton_close"
        Me.Bouton_close.Size = New System.Drawing.Size(30, 30)
        Me.Bouton_close.TabIndex = 11
        '
        'mods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.Bouton_close)
        Me.Controls.Add(Me.Bouton_desinstall_mods)
        Me.Controls.Add(Me.Bouton_install_mods)
        Me.Controls.Add(Me.Menu_news)
        Me.Controls.Add(Me.Menu_home)
        Me.Controls.Add(Me.GroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mods"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mods"
        Me.TransparencyKey = System.Drawing.Color.LightCoral
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents crosshair As CheckBox
    Friend WithEvents xvm As CheckBox
    Friend WithEvents channel As CheckBox
    Friend WithEvents Menu_home As Panel
    Friend WithEvents Menu_news As Panel
    Friend WithEvents Bouton_install_mods As Panel
    Friend WithEvents Bouton_desinstall_mods As Panel
    Friend WithEvents pmod As CheckBox
    Friend WithEvents WN8_EFF_Damage As CheckBox
    Friend WithEvents Bouton_close As Panel
End Class
