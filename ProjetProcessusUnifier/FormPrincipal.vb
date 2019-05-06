Public Class FormPrincipal

    Sub ChargePanel2(ByVal NewForm As Form)

        Panel2.Controls.Clear()

        Dim fh As Object = TryCast(NewForm, Object)

        fh.TopLevel = False

        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        fh.Dock = DockStyle.Fill

        Me.Panel2.Controls.Add(fh)

        Me.Panel2.Tag = Panel2

        fh.Show()

    End Sub

    Sub ChargePanel3(ByVal NewForm As Form)

        Panel3.Controls.Clear()

        Dim fh As Object = TryCast(NewForm, Object)

        fh.TopLevel = False

        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        fh.Dock = DockStyle.Fill

        Me.Panel3.Controls.Add(fh)

        Me.Panel3.Tag = Panel3

        fh.Show()

    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ChargePanel2(FormMiseAjourPatient)

        ChargePanel3(FormListePatient)

        btn1.Visible = False
        btn2.Visible = True
        btn3.Visible = True
        btn4.Visible = True
        btn5.Visible = True
        btn6.Visible = True

        btnSelect1.Visible = True
        btnSelect2.Visible = False
        btnSelect3.Visible = False
        btnSelect4.Visible = False
        btnSelect5.Visible = False
        btnSelect6.Visible = False

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btn1_Click_1(sender As Object, e As EventArgs) Handles btn1.Click
        FormMiseAjourPatient.Close()
        FormListePatient.Close()
        ChargePanel2(FormMiseAjourPatient)
        ChargePanel3(FormListePatient)

        btn1.Visible = False
        btn2.Visible = True
        btn3.Visible = True
        btn4.Visible = True
        btn5.Visible = True
        btn6.Visible = True

        btnSelect1.Visible = True
        btnSelect2.Visible = False
        btnSelect3.Visible = False
        btnSelect4.Visible = False
        btnSelect5.Visible = False
        btnSelect6.Visible = False

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click

        FormPatientEnAtte.Close()
        FormDebutFichePatient.Close()
        ChargePanel2(FormPatientEnAtte)
        ChargePanel3(FormDebutFichePatient)

        btn1.Visible = True
        btn2.Visible = False
        btn3.Visible = True
        btn4.Visible = True
        btn5.Visible = True
        btn6.Visible = True

        btnSelect1.Visible = False
        btnSelect2.Visible = True
        btnSelect3.Visible = False
        btnSelect4.Visible = False
        btnSelect5.Visible = False
        btnSelect6.Visible = False

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        btn1.Visible = True
        btn2.Visible = True
        btn3.Visible = False
        btn4.Visible = True
        btn5.Visible = True
        btn6.Visible = True

        btnSelect1.Visible = False
        btnSelect2.Visible = False
        btnSelect3.Visible = True
        btnSelect4.Visible = False
        btnSelect5.Visible = False
        btnSelect6.Visible = False
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        btn1.Visible = True
        btn2.Visible = True
        btn3.Visible = True
        btn4.Visible = False
        btn5.Visible = True
        btn6.Visible = True

        btnSelect1.Visible = False
        btnSelect2.Visible = False
        btnSelect3.Visible = False
        btnSelect4.Visible = True
        btnSelect5.Visible = False
        btnSelect6.Visible = False
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        btn1.Visible = True
        btn2.Visible = True
        btn3.Visible = True
        btn4.Visible = True
        btn5.Visible = False
        btn6.Visible = True

        btnSelect1.Visible = False
        btnSelect2.Visible = False
        btnSelect3.Visible = False
        btnSelect4.Visible = False
        btnSelect5.Visible = True
        btnSelect6.Visible = False
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        btn1.Visible = True
        btn2.Visible = True
        btn3.Visible = True
        btn4.Visible = True
        btn5.Visible = True
        btn6.Visible = False

        btnSelect1.Visible = False
        btnSelect2.Visible = False
        btnSelect3.Visible = False
        btnSelect4.Visible = False
        btnSelect5.Visible = False
        btnSelect6.Visible = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class