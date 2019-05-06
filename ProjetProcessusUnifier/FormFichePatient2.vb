Public Class FormFichePatient2
    Private Sub FormFichePatient2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridViewGaucheAud.Rows.Add("12", "0.56", "")
        DataGridViewGaucheAud.Rows.Add("5", "", "0.5")
        DataGridViewGaucheAud.Rows.Add("15", "", "0.85")
        DataGridViewGaucheAud.Rows.Add("21", "2", "0.4")
        DataGridViewGaucheAud.Rows.Add("44", "", "0.54")
        DataGridViewGaucheAud.Rows.Add("82", "", "20")
        DataGridViewGaucheAud.Rows.Add("02", "0.003", "0.01")

        DataGridViewDroiteAud.Rows.Add("80", "", "0.14")
        DataGridViewDroiteAud.Rows.Add("52", "0.54", "0.04")
        DataGridViewDroiteAud.Rows.Add("23", "0.1", "")
        DataGridViewDroiteAud.Rows.Add("7", "0.25", "0.02")
        DataGridViewDroiteAud.Rows.Add("023", "0.85", "")
        DataGridViewDroiteAud.Rows.Add("0.5", "", "")
        DataGridViewDroiteAud.Rows.Add("0.12", "", "0.47")

        DataGridViewWeber.Rows.Add("100")
        DataGridViewWeber.Rows.Add("250")
        DataGridViewWeber.Rows.Add("300")
        DataGridViewWeber.Rows.Add("70")
        DataGridViewWeber.Rows.Add("19")



    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click

        FormPrincipal.ChargePanel3(FormFichePatient3)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

End Class