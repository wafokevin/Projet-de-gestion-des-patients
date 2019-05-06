Public Class FormListePatient
    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        btnConsultation.Visible = True
        btnAjouter.Visible = False
        btnModifier.Visible = True
        btnSupprimer.Visible = True

        btnConsultationSel.Visible = False
        btnAjouterSel.Visible = True
        btnModifierSel.Visible = False
        btnSupprimerSel.Visible = False


        pbxAtt.Visible = False
        lblAtt.Visible = False

        FormMiseAjourPatient.lblTitre.Text = "Formulaire d'ajout des patients"
        FormMiseAjourPatient.btnValider.Text = "Ajouter"

    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        btnConsultation.Visible = True
        btnAjouter.Visible = True
        btnModifier.Visible = False
        btnSupprimer.Visible = True

        btnConsultationSel.Visible = False
        btnAjouterSel.Visible = False
        btnModifierSel.Visible = True
        btnSupprimerSel.Visible = False

        pbxAtt.Visible = True
        lblAtt.Visible = True

        FormMiseAjourPatient.lblTitre.Text = "Formulaire modification des patients"
        FormMiseAjourPatient.btnValider.Text = "Modifier
"
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        btnConsultation.Visible = True
        btnAjouter.Visible = True
        btnModifier.Visible = True
        btnSupprimer.Visible = False

        btnConsultationSel.Visible = False
        btnAjouterSel.Visible = False
        btnModifierSel.Visible = False
        btnSupprimerSel.Visible = True

        pbxAtt.Visible = True
        lblAtt.Visible = True

        FormMiseAjourPatient.txtNomPatient.Enabled = False
        FormMiseAjourPatient.txtPrenomPatient.Enabled = False
        FormMiseAjourPatient.dtDatePatient.Enabled = False
        FormMiseAjourPatient.txtVillePatient.Enabled = False
        FormMiseAjourPatient.txtTelPatient.Enabled = False
        FormMiseAjourPatient.txtProfession.Enabled = False

        FormMiseAjourPatient.lblTitre.Text = "Formulaire supression des patients"
        FormMiseAjourPatient.btnValider.Text = "Supprimer"

    End Sub

    Private Sub FormListePatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAjouter.Visible = False
        btnModifier.Visible = True
        btnSupprimer.Visible = True

        btnAjouterSel.Visible = True
        btnModifierSel.Visible = False
        btnSupprimerSel.Visible = False

        pbxAtt.Visible = False
        lblAtt.Visible = False

        FormMiseAjourPatient.lblTitre.Text = "Formulaire d'ajout des patients"
        FormMiseAjourPatient.btnValider.Text = "Ajouter"

    End Sub

    Private Sub btnConsultation_Click(sender As Object, e As EventArgs) Handles btnConsultation.Click

        btnConsultation.Visible = False
        btnAjouter.Visible = True
        btnModifier.Visible = True
        btnSupprimer.Visible = True

        btnConsultationSel.Visible = True
        btnAjouterSel.Visible = False
        btnModifierSel.Visible = False
        btnSupprimerSel.Visible = False


        pbxAtt.Visible = True
        lblAtt.Visible = True

        FormMiseAjourPatient.txtNomPatient.Enabled = False
        FormMiseAjourPatient.txtPrenomPatient.Enabled = False
        FormMiseAjourPatient.dtDatePatient.Enabled = False
        FormMiseAjourPatient.txtVillePatient.Enabled = False
        FormMiseAjourPatient.txtTelPatient.Enabled = False
        FormMiseAjourPatient.txtProfession.Enabled = False

        FormMiseAjourPatient.lblTitre.Text = "Nouvelle consultation du patient : "
        FormMiseAjourPatient.btnValider.Text = "Consulter
"
    End Sub
End Class