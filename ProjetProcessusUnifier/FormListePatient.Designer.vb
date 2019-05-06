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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.DataGridView1.Location = New System.Drawing.Point(9, 47)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(969, 358)
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
        Me.Label1.Location = New System.Drawing.Point(368, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 38)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Liste des patients "
        '
        'btnSupprimerSel
        '
        Me.btnSupprimerSel.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.depositphotos_123432976_stock_photo_yellow_and_orange_gradient_abstract
        Me.btnSupprimerSel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSupprimerSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupprimerSel.Location = New System.Drawing.Point(836, 414)
        Me.btnSupprimerSel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSupprimerSel.Name = "btnSupprimerSel"
        Me.btnSupprimerSel.Size = New System.Drawing.Size(144, 39)
        Me.btnSupprimerSel.TabIndex = 91
        Me.btnSupprimerSel.Text = "Supprimer"
        Me.btnSupprimerSel.UseVisualStyleBackColor = True
        '
        'btnModifierSel
        '
        Me.btnModifierSel.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.depositphotos_123432976_stock_photo_yellow_and_orange_gradient_abstract
        Me.btnModifierSel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModifierSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifierSel.Location = New System.Drawing.Point(684, 414)
        Me.btnModifierSel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnModifierSel.Name = "btnModifierSel"
        Me.btnModifierSel.Size = New System.Drawing.Size(144, 39)
        Me.btnModifierSel.TabIndex = 92
        Me.btnModifierSel.Text = "Modifier"
        Me.btnModifierSel.UseVisualStyleBackColor = True
        '
        'btnAjouterSel
        '
        Me.btnAjouterSel.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.depositphotos_123432976_stock_photo_yellow_and_orange_gradient_abstract
        Me.btnAjouterSel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAjouterSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouterSel.Location = New System.Drawing.Point(529, 414)
        Me.btnAjouterSel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAjouterSel.Name = "btnAjouterSel"
        Me.btnAjouterSel.Size = New System.Drawing.Size(144, 39)
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
        Me.btnAjouter.Location = New System.Drawing.Point(529, 415)
        Me.btnAjouter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(144, 38)
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
        Me.btnSupprimer.Location = New System.Drawing.Point(836, 415)
        Me.btnSupprimer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(144, 38)
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
        Me.btnModifier.Location = New System.Drawing.Point(684, 415)
        Me.btnModifier.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(144, 38)
        Me.btnModifier.TabIndex = 94
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'lblAtt
        '
        Me.lblAtt.BackColor = System.Drawing.Color.Transparent
        Me.lblAtt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAtt.Location = New System.Drawing.Point(27, 404)
        Me.lblAtt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAtt.Name = "lblAtt"
        Me.lblAtt.Size = New System.Drawing.Size(348, 55)
        Me.lblAtt.TabIndex = 97
        Me.lblAtt.Text = "Selectionnr un patient avant modification, suppression ou consultation"
        Me.lblAtt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbxAtt
        '
        Me.pbxAtt.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.avertissement_signe_exclamation_pression_mark_jaune_icone_feux_erreur_point_lattention_vector_triangle_symbole_isole_gwgdkp
        Me.pbxAtt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxAtt.Location = New System.Drawing.Point(9, 407)
        Me.pbxAtt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbxAtt.Name = "pbxAtt"
        Me.pbxAtt.Size = New System.Drawing.Size(21, 47)
        Me.pbxAtt.TabIndex = 98
        Me.pbxAtt.TabStop = False
        '
        'btnConsultation
        '
        Me.btnConsultation.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.degrade_gris_bleu_1095_593
        Me.btnConsultation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConsultation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultation.ForeColor = System.Drawing.Color.White
        Me.btnConsultation.Location = New System.Drawing.Point(372, 415)
        Me.btnConsultation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConsultation.Name = "btnConsultation"
        Me.btnConsultation.Size = New System.Drawing.Size(144, 38)
        Me.btnConsultation.TabIndex = 100
        Me.btnConsultation.Text = "Consultation"
        Me.btnConsultation.UseVisualStyleBackColor = True
        '
        'btnConsultationSel
        '
        Me.btnConsultationSel.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.depositphotos_123432976_stock_photo_yellow_and_orange_gradient_abstract
        Me.btnConsultationSel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConsultationSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultationSel.Location = New System.Drawing.Point(372, 414)
        Me.btnConsultationSel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConsultationSel.Name = "btnConsultationSel"
        Me.btnConsultationSel.Size = New System.Drawing.Size(144, 39)
        Me.btnConsultationSel.TabIndex = 99
        Me.btnConsultationSel.Text = "Consultation"
        Me.btnConsultationSel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(515, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(274, 115)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Modif Abdou"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(189, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(274, 115)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Modif Abdou"
        '
        'FormListePatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.degrade_gris_bleu_1095_593
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 457)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
