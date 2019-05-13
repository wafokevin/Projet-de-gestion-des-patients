<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConnection
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.login = New System.Windows.Forms.Button()
        Me.txtPasse = New System.Windows.Forms.Label()
        Me.TextBoxPasse = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxLogin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.login)
        Me.Panel1.Controls.Add(Me.txtPasse)
        Me.Panel1.Controls.Add(Me.TextBoxPasse)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBoxLogin)
        Me.Panel1.Location = New System.Drawing.Point(0, 139)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(699, 200)
        Me.Panel1.TabIndex = 0
        '
        'login
        '
        Me.login.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.bouton_connexion
        Me.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.login.Location = New System.Drawing.Point(396, 157)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(128, 31)
        Me.login.TabIndex = 15
        Me.login.UseVisualStyleBackColor = True
        '
        'txtPasse
        '
        Me.txtPasse.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasse.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtPasse.Location = New System.Drawing.Point(120, 109)
        Me.txtPasse.Name = "txtPasse"
        Me.txtPasse.Size = New System.Drawing.Size(189, 23)
        Me.txtPasse.TabIndex = 14
        Me.txtPasse.Text = "MOT DE PASSE"
        Me.txtPasse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxPasse
        '
        Me.TextBoxPasse.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPasse.Location = New System.Drawing.Point(315, 109)
        Me.TextBoxPasse.Name = "TextBoxPasse"
        Me.TextBoxPasse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPasse.Size = New System.Drawing.Size(209, 28)
        Me.TextBoxPasse.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(120, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "LOGIN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxLogin
        '
        Me.TextBoxLogin.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLogin.Location = New System.Drawing.Point(315, 66)
        Me.TextBoxLogin.Name = "TextBoxLogin"
        Me.TextBoxLogin.Size = New System.Drawing.Size(209, 28)
        Me.TextBoxLogin.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Engravers MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(429, 396)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(242, 54)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Polyclinique la perle"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Engravers MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 54)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "gestion des patients"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Engravers MT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(2, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(351, 54)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Gest-Pat"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources._37293750_vector_illustration_de_la_croix_rouge_rouge_icône_quot_x_quot_le_bouton_fermer_incorrecte_cesser_de_fum1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(624, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 34)
        Me.Button1.TabIndex = 19
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Engravers MT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(425, 342)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(273, 54)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Poly-per"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'FormConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjetProcessusUnifier.My.Resources.Resources.medecin_orl_copy_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(698, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormConnection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GEST-PAT"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents login As Button
    Friend WithEvents txtPasse As Label
    Friend WithEvents TextBoxPasse As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxLogin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
End Class
