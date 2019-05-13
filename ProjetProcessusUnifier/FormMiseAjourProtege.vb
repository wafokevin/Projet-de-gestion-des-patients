Public Class FormMiseAjourProtege
    Private Sub FormMiseAjourProtege_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormConnection.ListeProtege(FormListeProtege.DataGridView1)
    End Sub

    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        If btnValider.Text = "Ajouter" Then

            If txtLibelleProtege.Text = "" Or txtQuantMinProtege.Text = "" Or txtQuantProtege.Text = "" Or txtRefProtege.Text = "" Or typeProtege.Text = "" Then
                MsgBox("Tous les champs sont obligatoires!!!")
            Else
                FormConnection.AjouterProtege(txtRefProtege.Text, txtLibelleProtege.Text, txtQuantProtege.Text, txtQuantMinProtege.Text, typeProtege.Text)
                FormConnection.ListeProtege(FormListeProtege.DataGridView1)
                ViderChamp()

            End If
        ElseIf btnValider.Text = "Modifier" Then
            If txtLibelleProtege.Text = "" Or txtQuantMinProtege.Text = "" Or txtQuantProtege.Text = "" Or txtRefProtege.Text = "" Or typeProtege.Text = "" Then
                MsgBox("Tous les champs sont obligatoires!!!")
            Else
                FormConnection.ModifierProtege(FormListeProtege.idProtege, txtRefProtege.Text, txtLibelleProtege.Text, txtQuantProtege.Text, txtQuantMinProtege.Text, typeProtege.Text)
                FormConnection.ListeProtege(FormListeProtege.DataGridView1)
                ViderChamp()
            End If
        ElseIf btnValider.Text = "Delete" Then

            FormConnection.SupprimerProtege(FormListeProtege.idProtege)
            FormConnection.ListeProtege(FormListeProtege.DataGridView1)
            ViderChamp()

        End If
    End Sub
    Sub ViderChamp()
        txtLibelleProtege.Text = ""
        txtQuantMinProtege.Text = ""
        txtQuantProtege.Text = ""
        txtRefProtege.Text = ""
        typeProtege.Items.Clear()
    End Sub
End Class