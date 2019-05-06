Public Class FormConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(60, 0, 0, 0)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormPrincipal.Show()
    End Sub
End Class
