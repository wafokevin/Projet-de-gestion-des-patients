Public Class FormListePatient
    Dim Index As Integer
    Public idPatient As Integer
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

        FormMiseAjourPatient.txtNomPatient.Enabled = True
        FormMiseAjourPatient.txtPrenomPatient.Enabled = True
        FormMiseAjourPatient.dtDatePatient.Enabled = True
        FormMiseAjourPatient.txtVillePatient.Enabled = True
        FormMiseAjourPatient.txtTelPatient.Enabled = True
        FormMiseAjourPatient.txtProfession.Enabled = True

        FormMiseAjourPatient.lblTitre.Text = "Formulaire d'ajout des patients"
        FormMiseAjourPatient.btnValider.Text = "Ajouter"

        FormMiseAjourPatient.btnValider.Enabled = True

    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click

        FormMiseAjourPatient.ViderChamp()
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
        FormMiseAjourPatient.txtNomPatient.Enabled = True
        FormMiseAjourPatient.txtPrenomPatient.Enabled = True
        FormMiseAjourPatient.dtDatePatient.Enabled = True
        FormMiseAjourPatient.txtVillePatient.Enabled = True
        FormMiseAjourPatient.txtTelPatient.Enabled = True
        FormMiseAjourPatient.txtProfession.Enabled = True
        FormMiseAjourPatient.lblTitre.Text = "Formulaire modification des patients"
        FormMiseAjourPatient.btnValider.Text = "Modifier"

        FormMiseAjourPatient.btnValider.Enabled = True

    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        FormMiseAjourPatient.ViderChamp()

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
        FormMiseAjourPatient.btnValider.Enabled = True

    End Sub

    Private Sub FormListePatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormConnection.ListePatient(DataGridView1)
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



        FormMiseAjourPatient.txtNomPatient.Enabled = True
        FormMiseAjourPatient.txtPrenomPatient.Enabled = True
        FormMiseAjourPatient.dtDatePatient.Enabled = True
        FormMiseAjourPatient.txtVillePatient.Enabled = True
        FormMiseAjourPatient.txtTelPatient.Enabled = True
        FormMiseAjourPatient.txtProfession.Enabled = True


    End Sub

    Private Sub btnConsultation_Click(sender As Object, e As EventArgs) Handles btnConsultation.Click
        FormMiseAjourPatient.ViderChamp()

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

        FormMiseAjourPatient.btnValider.Enabled = True


        FormMiseAjourPatient.lblTitre.Text = "Nouvelle consultation d'un ancien patient : "
        FormMiseAjourPatient.btnValider.Text = "Consultation Ancien Patient"
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub
End Class