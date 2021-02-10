Public Class PRODOTTO

    Private IdProdotto As Integer
    Private DescriptionProdotto As String
    Private TipoProdotto As Integer
    Private ALLProdottoMerce As List(Of MERCE)

    Public Property Id As Integer
        Get
            Return IdProdotto
        End Get
        Set(value As Integer)
            IdProdotto = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return DescriptionProdotto
        End Get
        Set(value As String)
            DescriptionProdotto = value
        End Set
    End Property

    Public Property Tipo As Integer
        Get
            Return TipoProdotto
        End Get
        Set(value As Integer)
            TipoProdotto = value
        End Set
    End Property

    Public Property AllMerce As List(Of MERCE)
        Get
            Return ALLProdottoMerce
        End Get
        Set(value As List(Of MERCE))
            ALLProdottoMerce = value
        End Set
    End Property

    Public Sub AddMerce(MERCA As MERCE)
        Me.AllMerce.Add(MERCA)

    End Sub

    Public Sub RemoveMerce(MERCA As MERCE)
        Me.AllMerce.Remove(MERCA)
    End Sub

End Class
