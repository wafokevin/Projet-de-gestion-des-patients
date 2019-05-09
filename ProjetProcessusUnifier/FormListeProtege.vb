Public Class FormListeProtege
    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click


        btnAjouter.Visible = False
        btnModifier.Visible = True
        btnSupprimer.Visible = True

        btnAjouterSel.Visible = True
        btnModifierSel.Visible = False
        btnSupprimerSel.Visible = False

        pbxAtt.Visible = True
        lblAtt.Visible = True

        FormMiseAjourProtege.lblTitre.Text = "Formulaire d'ajout des proteges"
        FormMiseAjourProtege.btnValider.Text = "Ajouter"
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        btnAjouter.Visible = True
        btnModifier.Visible = False
        btnSupprimer.Visible = True

        btnAjouterSel.Visible = False
        btnModifierSel.Visible = True
        btnSupprimerSel.Visible = False

        pbxAtt.Visible = True
        lblAtt.Visible = True

        FormMiseAjourProtege.lblTitre.Text = "Formulaire de modification des proteges"
        FormMiseAjourProtege.btnValider.Text = "Modifier"
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        btnAjouter.Visible = True
        btnModifier.Visible = True
        btnSupprimer.Visible = False

        btnAjouterSel.Visible = False
        btnModifierSel.Visible = False
        btnSupprimerSel.Visible = True

        pbxAtt.Visible = True
        lblAtt.Visible = True

        FormMiseAjourProtege.lblTitre.Text = "Formulaire de suppression des proteges"
        FormMiseAjourProtege.btnValider.Text = "Supprimer"
    End Sub

    Private Sub FormListeProtege_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnAjouter.Visible = False
        btnModifier.Visible = True
        btnSupprimer.Visible = True

        btnAjouterSel.Visible = True
        btnModifierSel.Visible = False
        btnSupprimerSel.Visible = False

        pbxAtt.Visible = True
        lblAtt.Visible = True

        FormMiseAjourProtege.lblTitre.Text = "Formulaire d'ajout des proteges"
        FormMiseAjourProtege.btnValider.Text = "Ajouter"
    End Sub
End Class