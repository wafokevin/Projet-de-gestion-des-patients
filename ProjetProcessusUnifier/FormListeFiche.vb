Public Class FormListeFiche
    Private Sub FormListeFiche_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnVoirFiche_Click(sender As Object, e As EventArgs) Handles btnVoirFiche.Click
        FormVoirFiche1.Close()
        FormVoirFiche2.Close()
        FormPrincipal.ChargePanel2(FormVoirFiche1)
        FormPrincipal.ChargePanel3(FormVoirFiche2)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

End Class