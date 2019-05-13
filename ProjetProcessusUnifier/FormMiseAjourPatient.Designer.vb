<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMiseAjourPatient
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
        Me.txtTelPatient = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtVillePatient = New System.Windows.Forms.TextBox()
        Me.dtDatePatient = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrenomPatient = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.txtNomPatient = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProfession = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnValider
        '
        Me.btnValider.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.degrade_gris_bleu_1095_593
        Me.btnValider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValider.ForeColor = System.Drawing.Color.White
        Me.btnValider.Location = New System.Drawing.Point(17, 415)
        Me.btnValider.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(248, 38)
        Me.btnValider.TabIndex = 58
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(11, 308)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(252, 22)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Telephone :"
        '
        'txtTelPatient
        '
        Me.txtTelPatient.BackColor = System.Drawing.SystemColors.Menu
        Me.txtTelPatient.Location = New System.Drawing.Point(12, 334)
        Me.txtTelPatient.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTelPatient.Name = "txtTelPatient"
        Me.txtTelPatient.Size = New System.Drawing.Size(259, 22)
        Me.txtTelPatient.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 254)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(252, 22)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Ville :"
        '
        'txtVillePatient
        '
        Me.txtVillePatient.BackColor = System.Drawing.SystemColors.Menu
        Me.txtVillePatient.Location = New System.Drawing.Point(12, 279)
        Me.txtVillePatient.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVillePatient.Name = "txtVillePatient"
        Me.txtVillePatient.Size = New System.Drawing.Size(259, 22)
        Me.txtVillePatient.TabIndex = 54
        '
        'dtDatePatient
        '
        Me.dtDatePatient.CalendarMonthBackground = System.Drawing.SystemColors.Menu
        Me.dtDatePatient.Location = New System.Drawing.Point(12, 222)
        Me.dtDatePatient.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtDatePatient.Name = "dtDatePatient"
        Me.dtDatePatient.Size = New System.Drawing.Size(260, 22)
        Me.dtDatePatient.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 196)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(252, 22)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Date naissance :"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 138)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(252, 22)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Prenom :"
        '
        'txtPrenomPatient
        '
        Me.txtPrenomPatient.BackColor = System.Drawing.SystemColors.Menu
        Me.txtPrenomPatient.Location = New System.Drawing.Point(12, 164)
        Me.txtPrenomPatient.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrenomPatient.Name = "txtPrenomPatient"
        Me.txtPrenomPatient.Size = New System.Drawing.Size(259, 22)
        Me.txtPrenomPatient.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 22)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Nom :"
        '
        'lblTitre
        '
        Me.lblTitre.BackColor = System.Drawing.Color.Transparent
        Me.lblTitre.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.Color.White
        Me.lblTitre.Location = New System.Drawing.Point(4, 1)
        Me.lblTitre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(261, 84)
        Me.lblTitre.TabIndex = 48
        Me.lblTitre.Text = "Enregistrement patients"
        Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNomPatient
        '
        Me.txtNomPatient.BackColor = System.Drawing.SystemColors.Menu
        Me.txtNomPatient.Location = New System.Drawing.Point(12, 110)
        Me.txtNomPatient.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNomPatient.Name = "txtNomPatient"
        Me.txtNomPatient.Size = New System.Drawing.Size(260, 22)
        Me.txtNomPatient.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 359)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 22)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Prefession :"
        '
        'txtProfession
        '
        Me.txtProfession.BackColor = System.Drawing.SystemColors.Menu
        Me.txtProfession.Location = New System.Drawing.Point(13, 385)
        Me.txtProfession.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProfession.Name = "txtProfession"
        Me.txtProfession.Size = New System.Drawing.Size(259, 22)
        Me.txtProfession.TabIndex = 59
        '
        'FormMiseAjourPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.degrade_gris_bleu_1095_593
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(273, 457)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProfession)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTelPatient)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtVillePatient)
        Me.Controls.Add(Me.dtDatePatient)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPrenomPatient)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.txtNomPatient)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormMiseAjourPatient"
        Me.Text = "FormAjouterPatient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnValider As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTelPatient As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtVillePatient As TextBox
    Friend WithEvents dtDatePatient As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrenomPatient As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTitre As Label
    Friend WithEvents txtNomPatient As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProfession As TextBox
End Class
