Public Class LAVORO

    Private IdLavoro As Integer
    Private IdUtenteAssegnazioneLavoro As UTENTE
    Private DataAssegnazioneLavoro As DateTime
    Private DataChiusureLavoro As DateTime
    Private IdUtenteLavorazioneLavoro As UTENTE
    Private IdTipoLavorazioneLavoro As TIPOLAVORAZIONE
    Private AllOrdineLavoro As List(Of ORDINE)

    Public Property Id As Integer
        Get
            Return IdLavoro
        End Get
        Set(value As Integer)
            IdLavoro = value
        End Set
    End Property

    Public Property IdUtenteAssegnazione As UTENTE
        Get
            Return IdUtenteAssegnazioneLavoro
        End Get
        Set(value As UTENTE)
            IdUtenteAssegnazioneLavoro = value
        End Set
    End Property

    Public Property DataAssegnazione As DateTime
        Get
            Return DataAssegnazioneLavoro
        End Get
        Set(value As DateTime)
            DataAssegnazioneLavoro = value
        End Set
    End Property

    Public Property DataChiusure As DateTime
        Get
            Return DataChiusureLavoro
        End Get
        Set(value As DateTime)
            DataChiusureLavoro = value
        End Set
    End Property

    Public Property IdUtenteLavorazione As UTENTE
        Get
            Return IdUtenteLavorazioneLavoro
        End Get
        Set(value As UTENTE)
            IdUtenteLavorazioneLavoro = value
        End Set
    End Property

    Public Property IdTipoLavorazione As TIPOLAVORAZIONE
        Get
            Return IdTipoLavorazioneLavoro
        End Get
        Set(value As TIPOLAVORAZIONE)
            IdTipoLavorazioneLavoro = value
        End Set
    End Property

    Public Property AllOrdine As List(Of ORDINE)
        Get
            Return AllOrdineLavoro
        End Get
        Set(value As List(Of ORDINE))
            AllOrdineLavoro = value
        End Set
    End Property

    Public Sub AddOrdine(ORDI As ORDINE)
        Me.AllOrdine.Add(ORDI)

    End Sub

    Public Sub RemoveOrdine(ORDI As ORDINE)
        Me.AllOrdine.Remove(ORDI)
    End Sub

End Class
