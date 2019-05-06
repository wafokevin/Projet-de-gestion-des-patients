Public Class FormDebutFichePatient
    Private Sub FormDebutFichePatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(60, 0, 0, 0)
        Panel1.Width = FormPrincipal.Panel3.Width
        Panel1.Height = FormPrincipal.Panel3.Height
    End Sub
End Class