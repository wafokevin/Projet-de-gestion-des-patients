Public Class FormFichePatientGainProthetique
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        FormPrincipal.ChargePanel3(FormFichePatient3)
    End Sub

    Private Sub FormFichePatientGainProthetique_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.BackColor = Color.FromArgb(60, 0, 0, 0)
    End Sub
End Class