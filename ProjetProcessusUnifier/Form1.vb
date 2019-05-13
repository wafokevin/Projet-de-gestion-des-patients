Imports MySql.Data.MySqlClient

Public Class FormConnection


    Dim Connection As MySqlConnection

    Sub SeconnecterBd()
        Connection = New MySqlConnection("server=localhost; user id= root; password= ; database=bd_audioprothesiste;Port=3308; SslMode=none ")

        Try
            If Connection.State = ConnectionState.Closed Then
                Connection.Open()


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Sub AjouterPatient(ByVal nom As String, ByVal prenom As String, ByVal profession As String, ByVal telephone As String, ByVal ville As String, ByVal dateP As Date)
        SeconnecterBd()
        If Connection.State = ConnectionState.Open Then
            'Connection = New MySqlConnection("server=localhost; user id= root; password= ; database=bd_auditttttttoprothesiste")
            ' Connection.Open()

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
                    table.Rows.Add(id, nom, prenom, fonction, dateP, telephone, ville, "En attente")
                End While
                Connection.Close()
            End Using

        Else
            MessageBox.Show("Connection fermer")
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
    Dim table(6) As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles login.Click
        FormPrincipal.Show()
        'table = RecupereUtilisateur(TextBoxLogin.Text)
        'If table(3) = "" Then
        '    MsgBox("Le login saisi est incorrect")

        'ElseIf TextBoxPasse.Text = table(4) Then

        '    FormPrincipal.Show()
        '    TextBoxLogin.Text = ""
        '    TextBoxPasse.Text = ""
        'Else
        '    MsgBox("Le mot de passe saisi est incorrect")
        'End If

    End Sub
    Sub AjouterProtege(ByVal reference As String, ByVal Libelle As String, ByVal Quantite As Integer, ByVal QuantiteMin As Integer, ByVal type As String)
        SeconnecterBd()
        If Connection.State = ConnectionState.Open Then


            Dim cmd As New MySqlCommand("INSERT INTO protege (reference_protege, libelle_protege,quantite_protege,quantite_min_protege, type_protege) VALUES (@reference_protege, @libelle_protege,@quantite_protege,@quantite_min_protege, @type_protege)", Connection)
            cmd.Parameters.AddWithValue("@reference_protege", reference)

            cmd.Parameters.AddWithValue("@libelle_protege", Libelle)
            cmd.Parameters.AddWithValue("@quantite_protege", Quantite)
            cmd.Parameters.AddWithValue("@quantite_min_protege", QuantiteMin)
            cmd.Parameters.AddWithValue("@type_protege", type)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
            Connection.Close()
        Else
            MessageBox.Show("Connection fermer")
        End If
    End Sub

    Sub ListeProtege(ByRef table As DataGridView)
        SeconnecterBd()
        If Connection.State = ConnectionState.Open Then
            table.Rows.Clear()
            Dim cmd As New MySqlCommand("SELECT * FROM protege", Connection)
            Using lire As MySqlDataReader = cmd.ExecuteReader()
                While lire.Read
                    Dim ID As Integer = lire("id_protege")
                    Dim refernce As String = lire("reference_protege")
                    Dim Libelle As String = lire("libelle_protege")
                    Dim Quantite As Integer = lire("quantite_protege")
                    Dim QuantiteMin As Integer = lire("quantite_min_protege")
                    Dim type As String = lire("type_protege")
                    table.Rows.Add(ID, refernce, Libelle, Quantite, QuantiteMin, type)
                End While
                Connection.Close()
            End Using

        Else
            MessageBox.Show("Connection fermer")
        End If
    End Sub
    Sub ModifierProtege(ByVal id As Integer, ByVal reference As String, ByVal Libelle As String, ByVal Quantite As Integer, ByVal QuantiteMin As Integer, ByVal type As String)
        SeconnecterBd()
        If Connection.State = ConnectionState.Open Then

            Try
                Dim cmd As New MySqlCommand("UPDATE protege SET reference_protege=@reference_protege,libelle_protege=@libelle_protege,quantite_protege=@quantite_protege,quantite_min_protege=@quantite_min_protege, type_protege=@type_protege WHERE id_protege=@id_protege", Connection)
                cmd.Parameters.AddWithValue("@id_protege", id)
                cmd.Parameters.AddWithValue("@reference_protege", reference)
                cmd.Parameters.AddWithValue("@libelle_protege", Libelle)
                cmd.Parameters.AddWithValue("@quantite_protege", Quantite)
                cmd.Parameters.AddWithValue("@quantite_min_protege", QuantiteMin)
                cmd.Parameters.AddWithValue("@type_protege", type)

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
    Sub SupprimerProtege(ByVal ID As Integer)
        SeconnecterBd()
        If Connection.State = ConnectionState.Open Then
            Dim cmd As New MySqlCommand("DELETE FROM protege WHERE id_protege=@id_protege", Connection)
            cmd.Parameters.AddWithValue("@id_protege", ID)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
            Connection.Close()
        Else
            MessageBox.Show("Connection fermer")
        End If
    End Sub
    Function RecupereUtilisateur(ByVal login1 As String)
        SeconnecterBd()
        If Connection.State = ConnectionState.Open Then

            Dim cmd As New MySqlCommand("SELECT * FROM utilisateur", Connection)
            Using lire As MySqlDataReader = cmd.ExecuteReader()
                Dim matable(6) As String
                While lire.Read
                    If login1 = lire("login") Then
                        matable(0) = lire("id_utilisateur").ToString()
                        matable(1) = lire("nom_utilisateur")
                        matable(2) = lire("prenom_utilisateur")
                        matable(3) = lire("login")
                        matable(4) = lire("password")
                        matable(5) = lire("fonction_utilisateur")
                    End If

                End While
                Return matable
                Connection.Close()
            End Using

        Else
            MessageBox.Show("Connection fermer")
            Return 1
        End If
    End Function


End Class
