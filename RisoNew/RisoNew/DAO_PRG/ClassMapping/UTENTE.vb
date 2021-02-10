Public Class UTENTE

    Private IdImpiegati As Integer
    Private NomeUtente As String
    Private CognomeUtente As String
    Private RuoloUtente As Integer
    Private UtenteUtente As String
    Private Passwordutente As String
    Private ALLLavoroUtente As List(Of LAVORO)

    Public Property Id As Integer
        Get
            Return IdImpiegati
        End Get
        Set(value As Integer)
            IdImpiegati = value
        End Set
    End Property

    Public Property Nome As String
        Get
            Return NomeUtente
        End Get
        Set(value As String)
            NomeUtente = value
        End Set
    End Property

    Public Property Cognome As String
        Get
            Return CognomeUtente
        End Get
        Set(value As String)
            CognomeUtente = value
        End Set
    End Property

    Public Property Ruolo As Integer
        Get
            Return RuoloUtente
        End Get
        Set(value As Integer)
            RuoloUtente = value
        End Set
    End Property

    Public Property Utente As String
        Get
            Return UtenteUtente
        End Get
        Set(value As String)
            UtenteUtente = value
        End Set
    End Property


    Public Property Password As String
        Get
            Return Passwordutente
        End Get
        Set(value As String)
            Passwordutente = value
        End Set
    End Property


    Public Property ALLLavoro As List(Of LAVORO)
        Get
            Return ALLLavoroUtente
        End Get
        Set(value As List(Of LAVORO))
            ALLLavoroUtente = value
        End Set
    End Property

    Public Sub AddLavoro(LAVA As LAVORO)
        Me.ALLLavoro.Add(LAVA)

    End Sub

    Public Sub RemoveLavoro(LAVA As LAVORO)
        Me.ALLLavoro.Remove(LAVA)
    End Sub

End Class
