Public Class MERCE

    Private IdMerce As Integer
    Private QuantitaMerce As Integer
    Private IdProdottoMerce As Integer
    Private QuantitaInitialMerce As Integer
    Private DataCreationMerce As DateTime
    Private AllOrdineMerce As List(Of ORDINE)

    Public Property Id As Integer
        Get
            Return IdMerce
        End Get
        Set(value As Integer)
            IdMerce = value
        End Set
    End Property

    Public Property Quantita As Integer
        Get
            Return QuantitaMerce
        End Get
        Set(value As Integer)
            QuantitaMerce = value
        End Set
    End Property


    Public Property IdProdotto As Integer
        Get
            Return IdProdottoMerce
        End Get
        Set(value As Integer)
            IdProdottoMerce = value
        End Set
    End Property

    Public Property QuantitaInitial As Integer
        Get
            Return QuantitaInitialMerce
        End Get
        Set(value As Integer)
            QuantitaInitialMerce = value
        End Set
    End Property

    Public Property DataCreation As DateTime
        Get
            Return DataCreationMerce
        End Get
        Set(value As DateTime)
            DataCreationMerce = value

        End Set
    End Property

    Public Property AllOrdine As List(Of ORDINE)
        Get
            Return AllOrdineMerce
        End Get
        Set(value As List(Of ORDINE))
            AllOrdineMerce = value
        End Set
    End Property

    Public Sub AddOrdine(ORDI As ORDINE)
        Me.AllOrdine.Add(ORDI)

    End Sub

    Public Sub RemoveOrdine(ORDI As ORDINE)
        Me.AllOrdine.Remove(ORDI)
    End Sub

End Class
