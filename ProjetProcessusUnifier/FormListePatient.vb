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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Index = e.RowIndex
        Dim Selected As DataGridViewRow
        Selected = DataGridView1.Rows(Index)
        If FormMiseAjourPatient.btnValider.Text = "Modifier" Or FormMiseAjourPatient.btnValider.Text = "Supprimer" Then

            idPatient = CInt(Selected.Cells(0).Value.ToString())
            FormMiseAjourPatient.txtNomPatient.Text = Selected.Cells(1).Value.ToString()
            FormMiseAjourPatient.txtPrenomPatient.Text = Selected.Cells(2).Value.ToString()
            FormMiseAjourPatient.txtProfession.Text = Selected.Cells(3).Value.ToString()
            FormMiseAjourPatient.dtDatePatient.Text = Selected.Cells(4).Value.ToString()
            FormMiseAjourPatient.txtVillePatient.Text = Selected.Cells(5).Value.ToString()
            FormMiseAjourPatient.txtTelPatient.Text = Selected.Cells(6).Value.ToString()
            Dim statut As String = Selected.Cells(7).Value.ToString()
            If statut = "En attente" And FormMiseAjourPatient.btnValider.Text = "Consultation Ancien Patient" Then

                FormMiseAjourPatient.btnValider.Enabled = False

            Else

                FormMiseAjourPatient.btnValider.Enabled = True

            End If

        End If

    End Sub
End Class