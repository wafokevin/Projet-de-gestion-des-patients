Public Class FormMiseAjourPatient
    Private Sub FormAjouterPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        FormConnection.AjouterPatient(txtNomPatient.Text, txtPrenomPatient.Text, txtProfession.Text, txtTelPatient.Text, txtVillePatient.Text, dtDatePatient.Text)
    End Sub
End Class