Public Class FormPatientEnAtte
    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click

        FormPrincipal.ChargePanel2(FormFichePatient1)
        FormPrincipal.ChargePanel3(FormFichePatient2)
    End Sub

    Private Sub FormPatientEnAtte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class