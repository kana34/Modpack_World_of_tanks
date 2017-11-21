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
        Me.Chemin = New System.Windows.Forms.TextBox()
        Me.Parcourir = New System.Windows.Forms.Button()
        Me.Suivant = New System.Windows.Forms.Button()
        Me.message_verif = New System.Windows.Forms.Label()
        Me.dialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'Chemin
        '
        Me.Chemin.Location = New System.Drawing.Point(12, 48)
        Me.Chemin.Name = "Chemin"
        Me.Chemin.Size = New System.Drawing.Size(234, 20)
        Me.Chemin.TabIndex = 0
        '
        'Parcourir
        '
        Me.Parcourir.Location = New System.Drawing.Point(252, 44)
        Me.Parcourir.Name = "Parcourir"
        Me.Parcourir.Size = New System.Drawing.Size(73, 28)
        Me.Parcourir.TabIndex = 1
        Me.Parcourir.Text = "Parcourir"
        Me.Parcourir.UseVisualStyleBackColor = True
        '
        'Suivant
        '
        Me.Suivant.Location = New System.Drawing.Point(252, 78)
        Me.Suivant.Name = "Suivant"
        Me.Suivant.Size = New System.Drawing.Size(73, 28)
        Me.Suivant.TabIndex = 2
        Me.Suivant.Text = "Suivant"
        Me.Suivant.UseVisualStyleBackColor = True
        '
        'message_verif
        '
        Me.message_verif.AutoSize = True
        Me.message_verif.Location = New System.Drawing.Point(13, 75)
        Me.message_verif.Name = "message_verif"
        Me.message_verif.Size = New System.Drawing.Size(75, 13)
        Me.message_verif.TabIndex = 3
        Me.message_verif.Text = "message_verif"
        '
        'chemin_install
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 142)
        Me.Controls.Add(Me.message_verif)
        Me.Controls.Add(Me.Suivant)
        Me.Controls.Add(Me.Parcourir)
        Me.Controls.Add(Me.Chemin)
        Me.Name = "chemin_install"
        Me.Text = "Dossier installation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chemin As TextBox
    Friend WithEvents Parcourir As Button
    Friend WithEvents Suivant As Button
    Friend WithEvents message_verif As Label
    Friend WithEvents dialog As FolderBrowserDialog
End Class
