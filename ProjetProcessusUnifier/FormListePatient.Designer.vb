<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListePatient
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REPONSE1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REPONSE2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VILLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REPONSE4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REPONSEVRAI1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSupprimerSel = New System.Windows.Forms.Button()
        Me.btnModifierSel = New System.Windows.Forms.Button()
        Me.btnAjouterSel = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.lblAtt = New System.Windows.Forms.Label()
        Me.pbxAtt = New System.Windows.Forms.PictureBox()
        Me.btnConsultation = New System.Windows.Forms.Button()
        Me.btnConsultationSel = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAtt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.NOM, Me.REPONSE1, Me.REPONSE2, Me.VILLE, Me.REPONSE4, Me.REPONSEVRAI1})
        Me.DataGridView1.Location = New System.Drawing.Point(7, 38)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(727, 291)
        Me.DataGridView1.TabIndex = 86
        '
        'ID
        '
        Me.ID.HeaderText = "CODE"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'NOM
        '
        Me.NOM.HeaderText = "NOM"
        Me.NOM.Name = "NOM"
        Me.NOM.ReadOnly = True
        '
        'REPONSE1
        '
        Me.REPONSE1.HeaderText = "PRENOM"
        Me.REPONSE1.Name = "REPONSE1"
        Me.REPONSE1.ReadOnly = True
        '
        'REPONSE2
        '
        Me.REPONSE2.FillWeight = 144.0!
        Me.REPONSE2.HeaderText = "DATE NAISSANCE"
        Me.REPONSE2.Name = "REPONSE2"
        Me.REPONSE2.ReadOnly = True
        '
        'VILLE
        '
        Me.VILLE.FillWeight = 144.0!
        Me.VILLE.HeaderText = "VILLE"
        Me.VILLE.Name = "VILLE"
        Me.VILLE.ReadOnly = True
        Me.VILLE.Width = 70
        '
        'REPONSE4
        '
        Me.REPONSE4.FillWeight = 144.0!
        Me.REPONSE4.HeaderText = "TELEPHONE"
        Me.REPONSE4.Name = "REPONSE4"
        Me.REPONSE4.ReadOnly = True
        '
        'REPONSEVRAI1
        '
        Me.REPONSEVRAI1.FillWeight = 144.0!
        Me.REPONSEVRAI1.HeaderText = "STATUT"
        Me.REPONSEVRAI1.MinimumWidth = 6
        Me.REPONSEVRAI1.Name = "REPONSEVRAI1"
        Me.REPONSEVRAI1.ReadOnly = True
        Me.REPONSEVRAI1.Width = 130
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(276, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 31)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Liste des patients "
        '
        'btnSupprimerSel
        '
        Me.btnSupprimerSel.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.depositphotos_123432976_stock_photo_yellow_and_orange_gradient_abstract
        Me.btnSupprimerSel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSupprimerSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupprimerSel.Location = New System.Drawing.Point(627, 336)
        Me.btnSupprimerSel.Name = "btnSupprimerSel"
        Me.btnSupprimerSel.Size = New System.Drawing.Size(108, 32)
        Me.btnSupprimerSel.TabIndex = 91
        Me.btnSupprimerSel.Text = "Supprimer"
        Me.btnSupprimerSel.UseVisualStyleBackColor = True
        '
        'btnModifierSel
        '
        Me.btnModifierSel.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.depositphotos_123432976_stock_photo_yellow_and_orange_gradient_abstract
        Me.btnModifierSel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModifierSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifierSel.Location = New System.Drawing.Point(513, 336)
        Me.btnModifierSel.Name = "btnModifierSel"
        Me.btnModifierSel.Size = New System.Drawing.Size(108, 32)
        Me.btnModifierSel.TabIndex = 92
        Me.btnModifierSel.Text = "Modifier"
        Me.btnModifierSel.UseVisualStyleBackColor = True
        '
        'btnAjouterSel
        '
        Me.btnAjouterSel.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.depositphotos_123432976_stock_photo_yellow_and_orange_gradient_abstract
        Me.btnAjouterSel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAjouterSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouterSel.Location = New System.Drawing.Point(397, 336)
        Me.btnAjouterSel.Name = "btnAjouterSel"
        Me.btnAjouterSel.Size = New System.Drawing.Size(108, 32)
        Me.btnAjouterSel.TabIndex = 93
        Me.btnAjouterSel.Text = "Ajouter"
        Me.btnAjouterSel.UseVisualStyleBackColor = True
        '
        'btnAjouter
        '
        Me.btnAjouter.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.degrade_gris_bleu_1095_593
        Me.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAjouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouter.ForeColor = System.Drawing.Color.White
        Me.btnAjouter.Location = New System.Drawing.Point(397, 337)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(108, 31)
        Me.btnAjouter.TabIndex = 96
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'btnSupprimer
        '
        Me.btnSupprimer.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.degrade_gris_bleu_1095_593
        Me.btnSupprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSupprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupprimer.ForeColor = System.Drawing.Color.White
        Me.btnSupprimer.Location = New System.Drawing.Point(627, 337)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(108, 31)
        Me.btnSupprimer.TabIndex = 95
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = True
        '
        'btnModifier
        '
        Me.btnModifier.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.degrade_gris_bleu_1095_593
        Me.btnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifier.ForeColor = System.Drawing.Color.White
        Me.btnModifier.Location = New System.Drawing.Point(513, 337)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(108, 31)
        Me.btnModifier.TabIndex = 94
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'lblAtt
        '
        Me.lblAtt.BackColor = System.Drawing.Color.Transparent
        Me.lblAtt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAtt.Location = New System.Drawing.Point(20, 328)
        Me.lblAtt.Name = "lblAtt"
        Me.lblAtt.Size = New System.Drawing.Size(261, 45)
        Me.lblAtt.TabIndex = 97
        Me.lblAtt.Text = "Selectionnr un patient avant modification, suppression ou consultation"
        Me.lblAtt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbxAtt
        '
        Me.pbxAtt.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.avertissement_signe_exclamation_pression_mark_jaune_icone_feux_erreur_point_lattention_vector_triangle_symbole_isole_gwgdkp
        Me.pbxAtt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxAtt.Location = New System.Drawing.Point(7, 331)
        Me.pbxAtt.Name = "pbxAtt"
        Me.pbxAtt.Size = New System.Drawing.Size(16, 38)
        Me.pbxAtt.TabIndex = 98
        Me.pbxAtt.TabStop = False
        '
        'btnConsultation
        '
        Me.btnConsultation.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.degrade_gris_bleu_1095_593
        Me.btnConsultation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConsultation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultation.ForeColor = System.Drawing.Color.White
        Me.btnConsultation.Location = New System.Drawing.Point(279, 337)
        Me.btnConsultation.Name = "btnConsultation"
        Me.btnConsultation.Size = New System.Drawing.Size(108, 31)
        Me.btnConsultation.TabIndex = 100
        Me.btnConsultation.Text = "Consultation"
        Me.btnConsultation.UseVisualStyleBackColor = True
        '
        'btnConsultationSel
        '
        Me.btnConsultationSel.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.depositphotos_123432976_stock_photo_yellow_and_orange_gradient_abstract
        Me.btnConsultationSel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConsultationSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultationSel.Location = New System.Drawing.Point(279, 336)
        Me.btnConsultationSel.Name = "btnConsultationSel"
        Me.btnConsultationSel.Size = New System.Drawing.Size(108, 32)
        Me.btnConsultationSel.TabIndex = 99
        Me.btnConsultationSel.Text = "Consultation"
        Me.btnConsultationSel.UseVisualStyleBackColor = True
        '
        'FormListePatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.degrade_gris_bleu_1095_593
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(738, 371)
        Me.Controls.Add(Me.btnConsultation)
        Me.Controls.Add(Me.btnConsultationSel)
        Me.Controls.Add(Me.pbxAtt)
        Me.Controls.Add(Me.lblAtt)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.btnSupprimer)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.btnAjouterSel)
        Me.Controls.Add(Me.btnModifierSel)
        Me.Controls.Add(Me.btnSupprimerSel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormListePatient"
        Me.Text = "FormListePatient"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAtt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents NOM As DataGridViewTextBoxColumn
    Friend WithEvents REPONSE1 As DataGridViewTextBoxColumn
    Friend WithEvents REPONSE2 As DataGridViewTextBoxColumn
    Friend WithEvents VILLE As DataGridViewTextBoxColumn
    Friend WithEvents REPONSE4 As DataGridViewTextBoxColumn
    Friend WithEvents REPONSEVRAI1 As DataGridViewTextBoxColumn
    Friend WithEvents btnSupprimerSel As Button
    Friend WithEvents btnModifierSel As Button
    Friend WithEvents btnAjouterSel As Button
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents btnModifier As Button
    Friend WithEvents lblAtt As Label
    Friend WithEvents pbxAtt As PictureBox
    Friend WithEvents btnConsultation As Button
    Friend WithEvents btnConsultationSel As Button
End Class
