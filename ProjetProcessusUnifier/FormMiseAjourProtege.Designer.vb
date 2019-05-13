<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMiseAjourProtege
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQuantMinProtege = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQuantProtege = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLibelleProtege = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.txtRefProtege = New System.Windows.Forms.TextBox()
        Me.typeProt = New System.Windows.Forms.Label()
        Me.typeProtege = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnValider
        '
        Me.btnValider.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.degrade_gris_bleu_1095_593
        Me.btnValider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValider.ForeColor = System.Drawing.Color.White
        Me.btnValider.Location = New System.Drawing.Point(50, 335)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(108, 31)
        Me.btnValider.TabIndex = 72
        Me.btnValider.Text = "Valider"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(4, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 18)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Quantite minimale :"
        '
        'txtQuantMinProtege
        '
        Me.txtQuantMinProtege.BackColor = System.Drawing.SystemColors.Menu
        Me.txtQuantMinProtege.Location = New System.Drawing.Point(8, 255)
        Me.txtQuantMinProtege.Name = "txtQuantMinProtege"
        Me.txtQuantMinProtege.Size = New System.Drawing.Size(195, 20)
        Me.txtQuantMinProtege.TabIndex = 70
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(5, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 18)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Quantite :"
        '
        'txtQuantProtege
        '
        Me.txtQuantProtege.BackColor = System.Drawing.SystemColors.Menu
        Me.txtQuantProtege.Location = New System.Drawing.Point(5, 202)
        Me.txtQuantProtege.Name = "txtQuantProtege"
        Me.txtQuantProtege.Size = New System.Drawing.Size(195, 20)
        Me.txtQuantProtege.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 18)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Libelle :"
        '
        'txtLibelleProtege
        '
        Me.txtLibelleProtege.BackColor = System.Drawing.SystemColors.Menu
        Me.txtLibelleProtege.Location = New System.Drawing.Point(9, 148)
        Me.txtLibelleProtege.Name = "txtLibelleProtege"
        Me.txtLibelleProtege.Size = New System.Drawing.Size(195, 20)
        Me.txtLibelleProtege.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(5, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Reference :"
        '
        'lblTitre
        '
        Me.lblTitre.BackColor = System.Drawing.Color.Transparent
        Me.lblTitre.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.Color.White
        Me.lblTitre.Location = New System.Drawing.Point(1, 2)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(196, 68)
        Me.lblTitre.TabIndex = 62
        Me.lblTitre.Text = "Enregistrement protege"
        Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRefProtege
        '
        Me.txtRefProtege.BackColor = System.Drawing.SystemColors.Menu
        Me.txtRefProtege.Location = New System.Drawing.Point(7, 91)
        Me.txtRefProtege.Name = "txtRefProtege"
        Me.txtRefProtege.Size = New System.Drawing.Size(196, 20)
        Me.txtRefProtege.TabIndex = 61
        '
        'typeProt
        '
        Me.typeProt.BackColor = System.Drawing.Color.Transparent
        Me.typeProt.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typeProt.ForeColor = System.Drawing.Color.White
        Me.typeProt.Location = New System.Drawing.Point(5, 287)
        Me.typeProt.Name = "typeProt"
        Me.typeProt.Size = New System.Drawing.Size(189, 18)
        Me.typeProt.TabIndex = 73
        Me.typeProt.Text = "Type:"
        '
        'typeProtege
        '
        Me.typeProtege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.typeProtege.FormattingEnabled = True
        Me.typeProtege.Items.AddRange(New Object() {"CONTOUR", "INTRA/MESURE", "BOITIER"})
        Me.typeProtege.Location = New System.Drawing.Point(8, 308)
        Me.typeProtege.Name = "typeProtege"
        Me.typeProtege.Size = New System.Drawing.Size(196, 21)
        Me.typeProtege.TabIndex = 74
        '
        'FormMiseAjourProtege
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.degrade_gris_bleu_1095_593
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(205, 371)
        Me.Controls.Add(Me.typeProtege)
        Me.Controls.Add(Me.typeProt)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQuantMinProtege)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtQuantProtege)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLibelleProtege)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.txtRefProtege)
        Me.Name = "FormMiseAjourProtege"
        Me.Text = "FormMiseAjourProtege"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnValider As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQuantMinProtege As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtQuantProtege As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLibelleProtege As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTitre As Label
    Friend WithEvents txtRefProtege As TextBox
    Friend WithEvents typeProt As Label
    Friend WithEvents typeProtege As ComboBox
End Class
