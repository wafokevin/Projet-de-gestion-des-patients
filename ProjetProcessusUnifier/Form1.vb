Imports MySql.Data.MySqlClient

Public Class FormConnection


    Dim Connection As MySqlConnection

    Sub SeconnecterBd()
        Connection = New MySqlConnection("server=localhost; user id= root; password= ; database=bd_audioprothesiste; SslMode=none ")

        Try
            If Connection.State = ConnectionState.Closed Then
                Connection.Open()


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub SupprimerPatient(ByVal id As Integer)
        SeconnecterBd()
        Dim cmd As New MySqlCommand("DELETE FROM patient WHERE id_patient=@id_patient", Connection)
        cmd.Parameters.AddWithValue("@id_patient", id)
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        Connection.Close()
    End Sub
    Sub g(ByVal nom As String, ByVal prenom As String, ByVal profession As String, ByVal telephone As String, ByVal ville As String, ByVal dateP As Date, ByVal id As Integer)
        SeconnecterBd()
        If Connection.State = ConnectionState.Open Then
            Try
                Dim cmd As New MySqlCommand("UPDATE patient SET nom_patient=@nom_patient,  prenom_patient=@prenom_patient, fonction_patient=@fonction_patient,telephone_patient=@telephone_patient, ville_patient=@ville_patient WHERE id_patient=@id_patient", Connection)
                cmd.Parameters.AddWithValue("@nom_patient", nom)
                cmd.Parameters.AddWithValue("@prenom_patient", prenom)
                cmd.Parameters.AddWithValue("@fonction_patient", profession)
                cmd.Parameters.AddWithValue("@telephone_patient", telephone)
                cmd.Parameters.AddWithValue("@ville_patient", ville)
                cmd.Parameters.AddWithValue("@date_naissance_patient", dateP)
                cmd.Parameters.AddWithValue("@id_patient", id)
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
                Connection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MessageBox.Show("Connection fermer")
        End If
    End Sub


    Sub AjouterPatient(ByVal nom As String, ByVal prenom As String, ByVal profession As String, ByVal telephone As String, ByVal ville As String, ByVal dateP As Date)
        SeconnecterBd()
        If Connection.State = ConnectionState.Open Then

            Dim cmd As New MySqlCommand("INSERT INTO patient (nom_patient, prenom_patient, fonction_patient, telephone_patient, ville_patient, date_naissance_patient) VALUES (@nom_patient, @prenom_patient, @fonction_patient, @telephone_patient, @ville_patient, @date_naissance_patient)", Connection)
            cmd.Parameters.AddWithValue("@nom_patient", nom)
            cmd.Parameters.AddWithValue("@prenom_patient", prenom)
            cmd.Parameters.AddWithValue("@fonction_patient", profession)
            cmd.Parameters.AddWithValue("@telephone_patient", telephone)
            cmd.Parameters.AddWithValue("@ville_patient", ville)
            cmd.Parameters.AddWithValue("@date_naissance_patient", dateP)

            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
            Connection.Close()
        Else
            MessageBox.Show("Connection fermer")
        End If
    End Sub

    Sub ListePatient(ByRef table As DataGridView)
        SeconnecterBd()
        If Connection.State = ConnectionState.Open Then
            table.Rows.Clear()
            Dim cmd As New MySqlCommand("SELECT * FROM patient", Connection)
            Using lire As MySqlDataReader = cmd.ExecuteReader()
                While lire.Read
                    Dim id As Integer = lire("id_patient")
                    Dim nom As String = lire("nom_patient")
                    Dim prenom As String = lire("prenom_patient")
                    Dim fonction As String = lire("fonction_patient")
                    Dim telephone As String = lire("telephone_patient")
                    Dim ville As String = lire("ville_patient")
                    Dim dateP As Date = lire("date_naissance_patient")
                    Dim statut As String = lire("statut_patient")
                    table.Rows.Add(id, nom, prenom, fonction, dateP, telephone, ville, statut)
                End While
                Connection.Close()
            End Using

        Else
            MessageBox.Show("Connection fermer")
        End If
    End Sub
    Sub ChangerStatut(ByVal statut As String)
        SeconnecterBd()
        If Connection.State = ConnectionState.Open Then
            Dim cmd As New MySqlCommand("UPDATE patient SET statut_patient=@statut_patient", Connection)
            cmd.Parameters.AddWithValue("@statut_patient", statut)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
            Connection.Close()
            MsgBox("")

        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(60, 0, 0, 0)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub

    Sub ListePatientEnAttente(ByRef table As DataGridView)
        SeconnecterBd()
        If Connection.State = ConnectionState.Open Then
            table.Rows.Clear()
            Dim cmd As New MySqlCommand("SELECT * FROM patient where statut_patient='En attente'", Connection)
            Using lire As MySqlDataReader = cmd.ExecuteReader()
                While lire.Read
                    Dim id As String = lire("id_patient")

                    Dim nom As String = lire("nom_patient")
                    Dim prenom As String = lire("prenom_patient")

                    table.Rows.Add(id, nom & " " & prenom)
                End While
                Connection.Close()
            End Using

        Else
            MessageBox.Show("Connection fermer")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormPrincipal.Show()
    End Sub
End Class
