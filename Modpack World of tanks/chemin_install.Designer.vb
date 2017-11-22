<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chemin_install
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(chemin_install))
        Me.Chemin = New System.Windows.Forms.TextBox()
        Me.message_verif = New System.Windows.Forms.Label()
        Me.dialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.Parcourir = New System.Windows.Forms.Panel()
        Me.Suivant = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Chemin
        '
        Me.Chemin.Location = New System.Drawing.Point(19, 55)
        Me.Chemin.Name = "Chemin"
        Me.Chemin.Size = New System.Drawing.Size(314, 20)
        Me.Chemin.TabIndex = 0
        '
        'message_verif
        '
        Me.message_verif.AutoSize = True
        Me.message_verif.BackColor = System.Drawing.Color.Transparent
        Me.message_verif.ForeColor = System.Drawing.Color.White
        Me.message_verif.Location = New System.Drawing.Point(19, 39)
        Me.message_verif.Name = "message_verif"
        Me.message_verif.Size = New System.Drawing.Size(176, 13)
        Me.message_verif.TabIndex = 3
        Me.message_verif.Text = "Sélectionnez le chemin d'installation"
        '
        'Parcourir
        '
        Me.Parcourir.BackColor = System.Drawing.Color.Transparent
        Me.Parcourir.Location = New System.Drawing.Point(15, 84)
        Me.Parcourir.Name = "Parcourir"
        Me.Parcourir.Size = New System.Drawing.Size(150, 51)
        Me.Parcourir.TabIndex = 4
        '
        'Suivant
        '
        Me.Suivant.BackColor = System.Drawing.Color.Transparent
        Me.Suivant.Location = New System.Drawing.Point(187, 84)
        Me.Suivant.Name = "Suivant"
        Me.Suivant.Size = New System.Drawing.Size(150, 51)
        Me.Suivant.TabIndex = 5
        '
        'chemin_install
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(350, 157)
        Me.Controls.Add(Me.Suivant)
        Me.Controls.Add(Me.Parcourir)
        Me.Controls.Add(Me.message_verif)
        Me.Controls.Add(Me.Chemin)
        Me.Name = "chemin_install"
        Me.Text = "Dossier installation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chemin As TextBox
    Friend WithEvents message_verif As Label
    Friend WithEvents dialog As FolderBrowserDialog
    Friend WithEvents Parcourir As Panel
    Friend WithEvents Suivant As Panel
End Class
