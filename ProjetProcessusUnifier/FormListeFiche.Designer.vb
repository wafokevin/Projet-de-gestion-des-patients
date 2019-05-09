<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormListeFiche
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnVoirFiche = New System.Windows.Forms.Button()
        Me.pbxAtt = New System.Windows.Forms.PictureBox()
        Me.lblAtt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REPONSE2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REPONSE1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VILLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REPONSE4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.pbxAtt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVoirFiche
        '
        Me.btnVoirFiche.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.degrade_gris_bleu_1095_593
        Me.btnVoirFiche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVoirFiche.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoirFiche.ForeColor = System.Drawing.Color.White
        Me.btnVoirFiche.Location = New System.Drawing.Point(833, 433)
        Me.btnVoirFiche.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVoirFiche.Name = "btnVoirFiche"
        Me.btnVoirFiche.Size = New System.Drawing.Size(144, 38)
        Me.btnVoirFiche.TabIndex = 106
        Me.btnVoirFiche.Text = "Voir fiche"
        Me.btnVoirFiche.UseVisualStyleBackColor = True
        '
        'pbxAtt
        '
        Me.pbxAtt.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.avertissement_signe_exclamation_pression_mark_jaune_icone_feux_erreur_point_lattention_vector_triangle_symbole_isole_gwgdkp
        Me.pbxAtt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxAtt.Location = New System.Drawing.Point(8, 425)
        Me.pbxAtt.Margin = New System.Windows.Forms.Padding(4)
        Me.pbxAtt.Name = "pbxAtt"
        Me.pbxAtt.Size = New System.Drawing.Size(21, 47)
        Me.pbxAtt.TabIndex = 104
        Me.pbxAtt.TabStop = False
        '
        'lblAtt
        '
        Me.lblAtt.BackColor = System.Drawing.Color.Transparent
        Me.lblAtt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAtt.Location = New System.Drawing.Point(25, 421)
        Me.lblAtt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAtt.Name = "lblAtt"
        Me.lblAtt.Size = New System.Drawing.Size(280, 55)
        Me.lblAtt.TabIndex = 103
        Me.lblAtt.Text = "Selectionnr une fiche avant de cliquer sur un bouton" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblAtt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 36)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Liste des fiches patients "
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Column1, Me.REPONSE2, Me.NOM, Me.REPONSE1, Me.VILLE, Me.REPONSE4})
        Me.DataGridView1.Location = New System.Drawing.Point(8, 63)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(969, 358)
        Me.DataGridView1.TabIndex = 101
        '
        'ID
        '
        Me.ID.HeaderText = "CODE PATIENT"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "DATE CONSULTATION"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'REPONSE2
        '
        Me.REPONSE2.FillWeight = 144.0!
        Me.REPONSE2.HeaderText = "AGE"
        Me.REPONSE2.Name = "REPONSE2"
        Me.REPONSE2.ReadOnly = True
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
        'FormListeFiche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.degrade_gris_bleu_1095_593
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 498)
        Me.Controls.Add(Me.btnVoirFiche)
        Me.Controls.Add(Me.pbxAtt)
        Me.Controls.Add(Me.lblAtt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormListeFiche"
        Me.Text = "FormListeFiche"
        CType(Me.pbxAtt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnVoirFiche As Button
    Friend WithEvents pbxAtt As PictureBox
    Friend WithEvents lblAtt As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents REPONSE2 As DataGridViewTextBoxColumn
    Friend WithEvents NOM As DataGridViewTextBoxColumn
    Friend WithEvents REPONSE1 As DataGridViewTextBoxColumn
    Friend WithEvents VILLE As DataGridViewTextBoxColumn
    Friend WithEvents REPONSE4 As DataGridViewTextBoxColumn
End Class
