Public Class FormMiseAjourPatient
    Private Sub FormAjouterPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormConnection.ListePatient(FormListePatient.DataGridView1)
    End Sub

    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click

        If btnValider.Text = "Ajouter" Then
            If txtNomPatient.Text = "" Or txtPrenomPatient.Text = "" Or txtProfession.Text = "" Or txtTelPatient.Text = "" Or txtVillePatient.Text = "" Then
                MsgBox("Tous les champs sont obligatoire !!!")
            Else
                FormConnection.AjouterPatient(txtNomPatient.Text, txtPrenomPatient.Text, txtProfession.Text, txtTelPatient.Text, txtVillePatient.Text, dtDatePatient.Text)
                FormConnection.ListePatient(FormListePatient.DataGridView1)
                ViderChamp()

            End If
        End If
        If btnValider.Text = "Supprimer" Then

            FormConnection.SupprimerPatient(FormListePatient.idPatient)
            FormConnection.ListePatient(FormListePatient.DataGridView1)
            ViderChamp()
        End If

        If btnValider.Text = "Modifier" Then
            FormConnection.ModifierPatient(txtNomPatient.Text, txtPrenomPatient.Text, txtProfession.Text, txtTelPatient.Text, txtVillePatient.Text, dtDatePatient.Text, FormListePatient.idPatient)
            FormConnection.ListePatient(FormListePatient.DataGridView1)
            ViderChamp()

        End If

        If btnValider.Text = "Consultation Ancien Patient" Then
            FormConnection.ChangerStatut("En attente")

            btnValider.Enabled = False

            FormConnection.ListePatient(FormListePatient.DataGridView1)
        End If

    End Sub
    Sub ViderChamp()
        txtVillePatient.Text = ""
        txtTelPatient.Text = ""
        txtProfession.Text = ""
        txtPrenomPatient.Text = ""
        txtNomPatient.Text = ""
        dtDatePatient.Text = ""
    End Sub
End Class