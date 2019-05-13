Public Class FormListeProtege
    Public idProtege As Integer
    Dim Index As Integer
    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click

        FormMiseAjourProtege.txtLibelleProtege.Enabled = True
        FormMiseAjourProtege.txtQuantMinProtege.Enabled = True
        FormMiseAjourProtege.txtQuantProtege.Enabled = True
        FormMiseAjourProtege.txtRefProtege.Enabled = True
        FormMiseAjourProtege.typeProtege.Enabled = True

        btnAjouter.Visible = False
        btnModifier.Visible = True
        btnSupprimer.Visible = True

        btnAjouterSel.Visible = True
        btnModifierSel.Visible = False
        btnSupprimerSel.Visible = False

        pbxAtt.Visible = True
        lblAtt.Visible = True

        FormMiseAjourProtege.lblTitre.Text = "Formulaire d'ajout des proteges"
        FormMiseAjourProtege.btnValider.Text = "Ajouter"
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        FormMiseAjourProtege.txtLibelleProtege.Enabled = True
        FormMiseAjourProtege.txtQuantMinProtege.Enabled = True
        FormMiseAjourProtege.txtQuantProtege.Enabled = True
        FormMiseAjourProtege.txtRefProtege.Enabled = True
        FormMiseAjourProtege.typeProtege.Enabled = True
        btnAjouter.Visible = True
        btnModifier.Visible = False
        btnSupprimer.Visible = True

        btnAjouterSel.Visible = False
        btnModifierSel.Visible = True
        btnSupprimerSel.Visible = False

        pbxAtt.Visible = True
        lblAtt.Visible = True

        FormMiseAjourProtege.lblTitre.Text = "Formulaire de modification des proteges"
        FormMiseAjourProtege.btnValider.Text = "Modifier"
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        FormMiseAjourProtege.txtLibelleProtege.Enabled = False
        FormMiseAjourProtege.txtQuantMinProtege.Enabled = False
        FormMiseAjourProtege.txtQuantProtege.Enabled = False
        FormMiseAjourProtege.txtRefProtege.Enabled = False
        FormMiseAjourProtege.typeProtege.Enabled = False

        btnAjouter.Visible = True
        btnModifier.Visible = True
        btnSupprimer.Visible = False

        btnAjouterSel.Visible = False
        btnModifierSel.Visible = False
        btnSupprimerSel.Visible = True

        pbxAtt.Visible = True
        lblAtt.Visible = True

        FormMiseAjourProtege.lblTitre.Text = "Formulaire de suppression des proteges"
        FormMiseAjourProtege.btnValider.Text = "Delete"
    End Sub

    Private Sub FormListeProtege_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnAjouter.Visible = False
        btnModifier.Visible = True
        btnSupprimer.Visible = True

        btnAjouterSel.Visible = True
        btnModifierSel.Visible = False
        btnSupprimerSel.Visible = False

        pbxAtt.Visible = True
        lblAtt.Visible = True

        FormMiseAjourProtege.lblTitre.Text = "Formulaire d'ajout des proteges"
        FormMiseAjourProtege.btnValider.Text = "Ajouter"
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Index = e.RowIndex
        Dim Selected As DataGridViewRow
        Selected = DataGridView1.Rows(Index)
        If FormMiseAjourProtege.btnValider.Text = "Modifier" Or FormMiseAjourProtege.btnValider.Text = "Delete" Then

            idProtege = CInt(Selected.Cells(0).Value.ToString())
            FormMiseAjourProtege.txtRefProtege.Text = Selected.Cells(1).Value.ToString()
            FormMiseAjourProtege.txtLibelleProtege.Text = Selected.Cells(2).Value.ToString()
            FormMiseAjourProtege.txtQuantProtege.Text = Selected.Cells(3).Value.ToString()
            FormMiseAjourProtege.txtQuantMinProtege.Text = Selected.Cells(4).Value.ToString()
            FormMiseAjourProtege.typeProtege.Text = Selected.Cells(5).Value.ToString()

        End If
    End Sub

End Class