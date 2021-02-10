Public Class Index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim Utent As String = Request.Params("UT")
        Dim PAssword As String = Request.Params("PSWD")
        Dim SqlADD As StringBuilder = New StringBuilder("")
        Dim pasutente As String = "Non"
        'Dim SqlD = DAL.SelectDV(String.Format("select * from RisoNew..LAVORATORE where LAVORATORE.Utente='{0}' and LAVORATORE.Password='{1}'", Utent, PAssword))
        Dim SqlD = DAL.SelectDV(String.Format(ConfigurationManager.AppSettings("Accesso"), Utent, PAssword))
        If SqlD.Count > 0 Then
            Dim utenteA As String
            Dim RuoloA As String

            SqlADD.Append("{")
            For i = 0 To SqlD.Count - 1

                utenteA = SqlD.Item(i).Item("Utente")
                RuoloA = SqlD.Item(i).Item("Ruolo")
                SqlADD.Append(String.Format("""utente"":""{0}"",""Ruolo"":""{1}""", utenteA, RuoloA))

            Next
            SqlADD.Append("}")
            Response.Write(SqlADD)
        Else
            Response.Write(pasutente)
        End If

    End Sub

End Class