Public Class ORDINE
    Private IdOrdine As Integer
    Private IdLavoroOrdine As LAVORO
    Private IdMerceOrdine As MERCE
    Private QuantitaRichiestaOrdine As Integer
    Private DataCreationOrdine As DateTime
    Private IdClienteOrdine As CLIENTE
    Private StatoOrdine As Integer
    Private DescriptionOrdine As String


    Public Property ID As Integer
        Get
            Return IdOrdine
        End Get
        Set(value As Integer)
            IdOrdine = value
        End Set
    End Property

    Public Property Idlavoro As LAVORO
        Get
            Return IdLavoroOrdine
        End Get
        Set(value As LAVORO)
            IdLavoroOrdine = value
        End Set
    End Property

    Public Property IdMerce As MERCE
        Get
            Return IdMerceOrdine
        End Get
        Set(value As MERCE)
            IdMerceOrdine = value
        End Set
    End Property

    Public Property IdClient As CLIENTE
        Get
            Return IdClienteOrdine
        End Get
        Set(value As CLIENTE)
            IdClienteOrdine = value
        End Set
    End Property

    Public Property QuantitaRichiesta As Integer
        Get
            Return QuantitaRichiestaOrdine
        End Get
        Set(value As Integer)
            QuantitaRichiestaOrdine = value
        End Set
    End Property

    Public Property DataCreation As DateTime
        Get
            Return DataCreationOrdine
        End Get
        Set(value As DateTime)
            DataCreationOrdine = value
        End Set
    End Property

    Public Property Stato As Integer
        Get
            Return StatoOrdine
        End Get
        Set(value As Integer)
            StatoOrdine = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return DescriptionOrdine
        End Get
        Set(value As String)
            DescriptionOrdine = value
        End Set
    End Property
End Class
